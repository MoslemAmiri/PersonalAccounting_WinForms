using Accounting.DataLayer.Context;
using Accounting.DataLayer.Models;
using Accounting.Utility;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Forms.BasicInformation
{
    public partial class frmCreateCostOrIncomeType : Form
    {
        public frmCreateCostOrIncomeType()
        {
            InitializeComponent();
        }

        public byte Type;
        public long CostOrIncomeTypeId;
        private string _creationDate;

        private bool ValidateInputs()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                #region duplicated record
                bool status = false;
                switch (CostOrIncomeTypeId)
                {
                    case 0:
                        status = db.GenericCostOrIncomeTypeRepository
                            .Exists(x => x.Title == txtTitle.Text && x.Type != Type);
                        break;
                    default:
                        status = db.GenericCostOrIncomeTypeRepository
                            .Exists(x => x.Title == txtTitle.Text && x.Type != Type && x.Id != CostOrIncomeTypeId);
                        break;
                }

                if (status)
                {
                    AppTools.Message(Statuses.DuplicatedRecord);
                    txtTitle.Focus();
                    return false;
                }
                #endregion

                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && BaseValidator.IsFormValid(components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    try
                    {
                        var costOrIncomeType = new CostOrIncomeType
                        {
                            Title = txtTitle.Text,
                            Type = Type
                        };

                        switch (CostOrIncomeTypeId)
                        {
                            case 0:
                                costOrIncomeType.CreationDate = DateTime.Now.ToDatePersian();
                                db.GenericCostOrIncomeTypeRepository.Insert(costOrIncomeType);
                                break;
                            default:
                                costOrIncomeType.Id = CostOrIncomeTypeId;
                                costOrIncomeType.CreationDate = _creationDate;
                                db.GenericCostOrIncomeTypeRepository.Update(costOrIncomeType);
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

        private void frmCreateCostOrIncomeType_Load(object sender, EventArgs e)
        {
            if (Type == Statuses.Income)
            {
                groupBox1.Text = "درآمد";
                Text = "فرم تعریف نوع درآمد";
                lblTitle.Text = "عنوان درآمد :";
                rfvTitle.ErrorMessage = "عنوان درآمد نمی‌تواند خالی باشد";
            }

            if (CostOrIncomeTypeId > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    switch (Type)
                    {
                        case Statuses.Cost:
                            Text = "فرم ویرایش نوع هزینه";
                            break;
                        default:
                            Text = "فرم ویرایش نوع درآمد";
                            break;
                    }

                    btnSave.Text = "ویرایش اطلاعات";

                    var costOrIncomeType = db.GenericCostOrIncomeTypeRepository.Get(CostOrIncomeTypeId);
                    txtTitle.Text = costOrIncomeType.Title;

                    _creationDate = costOrIncomeType.CreationDate;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}