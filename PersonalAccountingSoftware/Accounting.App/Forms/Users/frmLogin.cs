using Accounting.DataLayer.Models;
using Accounting.Utility;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Forms.Users
{
    public partial class frmLogin : Form
    {
        private readonly IPasswordHasher _passwordHasher;

        public frmLogin()
        {
            InitializeComponent();
            _passwordHasher = new PasswordHasher();
        }

        private bool ValidateInputs()
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var user = db.UserRepository.GetUserBy(txtUserName.Text);

                        if (user == null)
                        {
                            AppTools.Message(Statuses.UserNotFound);
                            return false;
                        }

                        if (!_passwordHasher.Check(user.Password, txtPassword.Text))
                        {
                            AppTools.Message(Statuses.UserNotFound);
                            return false;
                        }

                        if (user.IsBlock)
                        {
                            AppTools.Message(Statuses.UnauthorizedEntry);
                            return false;
                        }

                        #region public variable
                        PublicVariable.Role = user.Role;
                        PublicVariable.UserId = user.Id;
                        PublicVariable.UserName = user.UserName;
                        PublicVariable.FullName = user.FullName;
                        #endregion

                        return true;
                    }
                }
                catch (Exception)
                {
                    AppTools.Message(Statuses.Error);
                    return false;
                }
            }

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && BaseValidator.IsFormValid(components))
            {
                var frm = new frmMain();
                Visible = false;
                frm.ShowDialog();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.EnglishLettersOnly();
        }
    }
}