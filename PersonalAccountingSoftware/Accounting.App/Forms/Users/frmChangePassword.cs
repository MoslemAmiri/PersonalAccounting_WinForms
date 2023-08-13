using Accounting.DataLayer.Models;
using Accounting.Utility;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Forms.Users
{
    public partial class frmChangePassword : Form
    {
        private readonly IPasswordHasher _passwordHasher;

        public frmChangePassword()
        {
            InitializeComponent();
            _passwordHasher = new PasswordHasher();
        }

        private bool ValidateInputs()
        {
            if (txtCurrentPassword.Text != "" && txtNewPassword.Text != "" && txtRepeatPassword.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var user = db.UserRepository.GetUserBy(PublicVariable.UserName);

                    if (user == null)
                    {
                        AppTools.Message(Statuses.UserNotFound);
                        return false;
                    }

                    if (!_passwordHasher.Check(user.Password, txtCurrentPassword.Text))
                    {
                        AppTools.Message(Statuses.CurrentPasswordIsNotCorrect);
                        return false;
                    }

                    if(txtNewPassword.Text == txtCurrentPassword.Text)
                    {
                        AppTools.Message(Statuses.SelectNewPassword);
                        return false;
                    }

                    if (txtNewPassword.Text != txtRepeatPassword.Text)
                    {
                        AppTools.Message(Statuses.PasswordNotMatch);
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && BaseValidator.IsFormValid(components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    try
                    {
                        var user = db.UserRepository.GetUserBy(PublicVariable.UserName);
                        user.Password = _passwordHasher.Hash(txtNewPassword.Text);
                        db.SaveChanges();
                        AppTools.Message(Statuses.Success);
                        Application.Restart();
                    }
                    catch (Exception)
                    {
                        AppTools.Message(Statuses.Error);
                        return;
                    }
                }
            }
        }
    }
}