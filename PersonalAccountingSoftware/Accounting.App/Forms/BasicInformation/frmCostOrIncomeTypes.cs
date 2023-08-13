using Accounting.DataLayer.Models;
using Accounting.Utility;
using System;
using System.Windows.Forms;

namespace Accounting.App.Forms.BasicInformation
{
    public partial class frmCostOrIncomeTypes : Form
    {
        public frmCostOrIncomeTypes()
        {
            InitializeComponent();
        }

        public byte Type;

        private void CostOrIncomeTypes()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var costOrIncomeTypes = db.CostOrIncomeTypeRepository.GetList(Type);

                dgvCostOrIncomeTypes.Rows.Clear();
                foreach (var item in costOrIncomeTypes)
                {
                    dgvCostOrIncomeTypes.Rows.Add(item.Id, item.CreationDate,
                        item.CostOrIncomesCount, item.Title);
                }
            }
        }

        private void frmCostOrIncomeTypes_Load(object sender, EventArgs e)
        {
            if (Type == Statuses.Income)
            {
                Text = "لیست انواع درآمدها";
                col_Title.HeaderText = "عنوان درآمد";
                col_CostsOrIncomesCount.HeaderText = "کل درآمدها";
            }

            CostOrIncomeTypes();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CostOrIncomeTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncomeType();
            frm.Type = Type;
            if (frm.ShowDialog() == DialogResult.OK)
                CostOrIncomeTypes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCostOrIncomeTypes.ThereAreRows())
            {
                var frm = new frmCreateCostOrIncomeType();
                frm.Type = Type;
                frm.CostOrIncomeTypeId = dgvCostOrIncomeTypes.GetId();
                if (frm.ShowDialog() == DialogResult.OK)
                    CostOrIncomeTypes();
            }
        }
    }
}