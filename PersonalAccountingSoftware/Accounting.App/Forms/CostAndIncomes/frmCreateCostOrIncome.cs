using System;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Models;
using Accounting.DataLayer.Context;
using Accounting.Utility;

namespace Accounting.App.Forms.CostAndIncomes
{
    public partial class frmCreateCostOrIncome : Form
    {
        public frmCreateCostOrIncome()
        {
            InitializeComponent();
        }

        public byte Type;
        public long CostOrIncomeId;
        private string _date;
        private string _time;
        private bool _isRemoved;

        private void CostOrIncomeTypes()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                cmbCostOrIncome.DataSource = db.CostOrIncomeTypeRepository.GetCostOrIncomeTypes(Type);
                cmbCostOrIncome.DisplayMember = "Title";
                cmbCostOrIncome.ValueMember = "Id";
            }
        }

        private bool ValidateInputs()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                #region required combobox
                if (cmbCostOrIncome.SelectedIndex == 0)
                {
                    AppTools.Message(Statuses.RequiredCombobox);
                    return false;
                }
                #endregion

                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && BaseValidator.IsFormValid(components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    try
                    {
                        var costOrIncome = new CostOrIncome
                        {
                            UserId = PublicVariable.UserId,
                            CostOrIncomeTypeId = (long)cmbCostOrIncome.SelectedValue,
                            Amount = double.Parse(txtAmount.Text),
                            Description = txtDescription.Text,
                            Type = Type
                        };

                        switch (CostOrIncomeId)
                        {
                            case 0:
                                costOrIncome.Date = DateTime.Now.ToDatePersian();
                                costOrIncome.Time = DateTime.Now.ToTimePersian();
                                db.GenericCostOrIncomeRepository.Insert(costOrIncome);
                                break;
                            default:
                                costOrIncome.Id = CostOrIncomeId;
                                costOrIncome.Date = _date;
                                costOrIncome.Time = _time;
                                costOrIncome.IsRemoved = _isRemoved;
                                db.GenericCostOrIncomeRepository.Update(costOrIncome);
                                break;
                        }

                        db.SaveChanges();
                        AppTools.Message(Statuses.Success);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception)
                    {
                        AppTools.Message(Statuses.Error);
                        return;
                    }
                }
            }
        }

        private void frmCreateCostOrIncome_Load(object sender, EventArgs e)
        {
            CostOrIncomeTypes();

            if (Type == Statuses.Income)
            {
                Text = "فرم ثبت درآمد";
                groupBox1.Text = "درآمد";
                lblCostAndIncome.Text = "انتخاب درآمد :";
            }

            if (CostOrIncomeId > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    switch (Type)
                    {
                        case Statuses.Cost:
                            Text = "فرم ویرایش هزینه";
                            break;
                        default:
                            Text = "فرم ویرایش درآمد";
                            break;
                    }

                    btnSave.Text = "ویرایش اطلاعات";

                    var costOrIncome = db.GenericCostOrIncomeRepository.Get(CostOrIncomeId);
                    cmbCostOrIncome.SelectedValue = costOrIncome.CostOrIncomeTypeId;
                    txtAmount.Text = costOrIncome.Amount.ToString();
                    txtDescription.Text = costOrIncome.Description;

                    _date = costOrIncome.Date;
                    _time = costOrIncome.Time;
                    _isRemoved = costOrIncome.IsRemoved;
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            AppTools.PriceFormat(txtAmount);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.OnlyNumbers();
        }
    }
}