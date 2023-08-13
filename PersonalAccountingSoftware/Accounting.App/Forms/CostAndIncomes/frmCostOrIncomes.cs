using Accounting.Business;
using Accounting.DataLayer.Models;
using Accounting.Utility;
using Accounting.ViewModels.CostOrIncome;
using System;
using System.Windows.Forms;

namespace Accounting.App.Forms.CostAndIncomes
{
    public partial class frmCostOrIncomes : Form
    {
        public frmCostOrIncomes()
        {
            InitializeComponent();
        }

        public byte Type;

        private void CostOrIncomes()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                #region search model
                CostOrIncomeSearchModel searchModel = new CostOrIncomeSearchModel();
                searchModel.DateFrom = dtpDateFrom.ToDatePersian();
                searchModel.DateTo = dtpDateTo.ToDatePersian();
                searchModel.Title = txtSearch.Text;
                searchModel.Status = cmbFilter.SelectedIndex;
                searchModel.Type = Type;
                #endregion

                var costOrIncomes = db.CostOrIncomeRepository.GetList(searchModel);

                dgvCostOrIncomes.Rows.Clear();
                foreach (var item in costOrIncomes)
                {
                    dgvCostOrIncomes.Rows.Add(item.Id, item.Date, item.Time,
                        item.Amount, item.CostOrIncomeType, item.Description,
                        item.IsRemoved);
                }

                double sumOfCostOrIncomes = Report.SumOfCostOrIncomes(searchModel);
                lblSumOfCostOrIncomes.Text = sumOfCostOrIncomes.ToMoney();

                AppTools.DeActivate(dgvCostOrIncomes, btnEdit);
                AppTools.DeActivate(btnRemove, btnRestore);
            }
        }

        private void frmCostOrIncomes_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;

            if (Type == Statuses.Income)
            {
                Text = "لیست درآمدها";
                lblItem_1.Text = "مجموع درآمدها :";
                col_CostOrIncome.HeaderText = "نوع درآمد";
            }

            CostOrIncomes();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            #region reset
            txtSearch.Text = string.Empty;
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            #endregion

            CostOrIncomes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncome();
            frm.Type = Type;
            if (frm.ShowDialog() == DialogResult.OK)
                CostOrIncomes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCostOrIncomes.ThereAreRows())
            {
                var frm = new frmCreateCostOrIncome();
                frm.CostOrIncomeId = dgvCostOrIncomes.GetId();
                frm.Type = Type;
                if (frm.ShowDialog() == DialogResult.OK)
                    CostOrIncomes();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCostOrIncomes.ThereAreRows())
            {
                if (AppTools.TwoChoiceWarningMessage())
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        long costOrIncomeId = dgvCostOrIncomes.GetId();
                        db.CostOrIncomeRepository.Remove(costOrIncomeId);
                        db.SaveChanges();
                        AppTools.Message(Statuses.Success);
                        CostOrIncomes();
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvCostOrIncomes.ThereAreRows())
            {
                if (AppTools.TwoChoiceWarningMessage())
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        long costOrIncomeId = dgvCostOrIncomes.GetId();
                        db.CostOrIncomeRepository.Restore(costOrIncomeId);
                        db.SaveChanges();
                        AppTools.Message(Statuses.Success);
                        CostOrIncomes();
                    }
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostOrIncomes();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            CostOrIncomes();
        }

        private void dgvCostOrIncomes_Click(object sender, EventArgs e)
        {
            if (dgvCostOrIncomes.ThereAreRows())
            {
                bool status = dgvCostOrIncomes.GetStatus();
                switch (status)
                {
                    case Statuses.Removed:
                        AppTools.Activate(btnRestore);
                        break;
                    case Statuses.NotRemoved:
                        AppTools.Activate(btnRemove);
                        break;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CostOrIncomes();
        }
    }
}