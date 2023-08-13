using System;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Models;
using Accounting.DataLayer.Context;
using Accounting.Utility;

namespace Accounting.App.Forms.Users
{
    public partial class frmCreateUser : Form
    {
        private readonly IPasswordHasher _passwordHasher;

        public frmCreateUser()
        {
            InitializeComponent();
            _passwordHasher = new PasswordHasher();
        }

        public long UserId;
        private bool _isBlock;
        private string _password;
        private string _creationDate;

        private bool ValidateInputs()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                #region required combobox
                if (cmbRole.SelectedIndex == 0)
                {
                    AppTools.Message(Statuses.RequiredCombobox);
                    return false;
                }
                #endregion

                #region password not match
                if (txtPassword.Text != txtRePassword.Text)
                {
                    AppTools.Message(Statuses.PasswordNotMatch);
                    return false;
                }
                #endregion

                #region duplicated record
                bool status = false;
                switch (UserId)
                {
                    case 0:
                        status = db.GenericUserRepository
                            .Exists(x => x.FullName == txtFullName.Text);
                        break;
                    default:
                        status = db.GenericUserRepository
                            .Exists(x => x.FullName == txtFullName.Text && x.Id != UserId);
                        break;
                }

                if (status)
                {
                    AppTools.Message(Statuses.DuplicatedRecord);
                    txtFullName.Focus();
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
                        var user = new User
                        {
                            Role = (byte)cmbRole.SelectedIndex,
                            FullName = txtFullName.Text,
                            Mobile = txtMobile.Text,
                            UserName = txtUserName.Text
                        };

                        switch (UserId)
                        {
                            case 0:
                                user.Password = _passwordHasher.Hash(txtPassword.Text);
                                user.CreationDate = DateTime.Now.ToDatePersian();
                                db.GenericUserRepository.Insert(user);
                                break;
                            default:
                                user.Id = UserId;
                                user.Password = _password;
                                user.CreationDate = _creationDate;
                                user.IsBlock = _isBlock;
                                db.GenericUserRepository.Update(user);
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

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;

            if (UserId > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Text = "فرم ویرایش کاربر";
                    btnSave.Text = "ویرایش اطلاعات";

                    var user = db.GenericUserRepository.Get(UserId);

                    cmbRole.SelectedIndex = user.Role == Statuses.AdminSystem ? Statuses.AdminSystem : Statuses.UserSystem;
                    txtFullName.Text = user.FullName;
                    txtMobile.Text = user.Mobile;
                    txtUserName.Text = user.UserName;

                    txtPassword.Enabled = false;
                    txtRePassword.Enabled = false;
                    txtPassword.Text = "********";
                    txtRePassword.Text = "********";

                    _password = user.Password;
                    _creationDate = user.CreationDate;
                    _isBlock = user.IsBlock;
                }
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.OnlyNumbers();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.EnglishLettersOnly();
        }
    }
}