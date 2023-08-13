using Accounting.DataLayer.Models;
using Accounting.Utility;
using Accounting.ViewModels.User;
using System;
using System.Windows.Forms;

namespace Accounting.App.Forms.Users
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void Users()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                #region search model
                UserSearchModel searchModel = new UserSearchModel();
                searchModel.FullName = txtSearch.Text;
                #endregion

                var users = db.UserRepository.GetList(searchModel);

                dgvUsers.Rows.Clear();
                foreach (var item in users)
                {
                    dgvUsers.Rows.Add(item.Id, item.CreationDate, item.FullName,
                        item.RoleName, item.Mobile, item.UserName, item.Status,
                        item.IsBlock, item.Role);
                }

                AppTools.DeActivate(dgvUsers, btnEdit);
                AppTools.DeActivate(btnBlock, btnUnBlock);
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Users();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            Users();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateUser();
            if (frm.ShowDialog() == DialogResult.OK)
                Users();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.ThereAreRows())
            {
                var frm = new frmCreateUser();
                frm.UserId = dgvUsers.GetId();
                if (frm.ShowDialog() == DialogResult.OK)
                    Users();
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.ThereAreRows())
            {
                byte role = dgvUsers.GetRole();
                if (role != Statuses.AdminSystem)
                {
                    if (AppTools.TwoChoiceWarningMessage())
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            long userId = dgvUsers.GetId();
                            db.UserRepository.Block(userId);
                            db.SaveChanges();
                            AppTools.Message(Statuses.Success);
                            Users();
                        }
                    }
                }
                else
                {
                    AppTools.Message(Statuses.AdminIsNotBlocked);
                }
            }
        }

        private void btnUnBlock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.ThereAreRows())
            {
                if (AppTools.TwoChoiceWarningMessage())
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        long userId = dgvUsers.GetId();
                        db.UserRepository.UnBlock(userId);
                        db.SaveChanges();
                        AppTools.Message(Statuses.Success);
                        Users();
                    }
                }
            }
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.ThereAreRows())
            {
                bool status = dgvUsers.GetStatus();
                switch (status)
                {
                    case Statuses.Blocked:
                        AppTools.Activate(btnUnBlock);
                        AppTools.DeActivate(btnBlock);
                        break;
                    case Statuses.NotBlocked:
                        AppTools.Activate(btnBlock);
                        AppTools.DeActivate(btnUnBlock);
                        break;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Users();
        }
    }
}