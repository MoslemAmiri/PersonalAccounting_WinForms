using Accounting.App.Forms.BasicInformation;
using Accounting.App.Forms.CostAndIncomes;
using Accounting.App.Forms.Reports;
using Accounting.App.Forms.Users;
using Accounting.Utility;
using System;
using System.Windows.Forms;

namespace Accounting.App.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public Form Form;

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToDatePersian();
            lblTime.Text = DateTime.Now.ToTimePersian();
            lblUserSystem.Text = PublicVariable.FullName;

            if(PublicVariable.Role != Statuses.AdminSystem)
                mnuUsers.Visible = false;

            var frm = new frmBackground();
            frm.MdiParent = this;
            Form = frm;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToTimePersian();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateCostType_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncomeType();
            frm.Type = Statuses.Cost;
            frm.ShowDialog();
        }

        private void btnCostsTypes_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomeTypes();
            frm.Type = Statuses.Cost;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnCreateIncomeType_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncomeType();
            frm.Type = Statuses.Income;
            frm.ShowDialog();
        }

        private void btnIncomesTypes_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomeTypes();
            frm.Type = Statuses.Income;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnCreateCost_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncome();
            frm.Type = Statuses.Cost;
            frm.ShowDialog();
        }

        private void btnCosts_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomes();
            frm.Type = Statuses.Cost;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnCreateIncome_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncome();
            frm.Type = Statuses.Income;
            frm.ShowDialog();
        }

        private void btnIncomes_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomes();
            frm.Type = Statuses.Income;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnCreateCost_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncome();
            frm.Type = Statuses.Cost;
            frm.ShowDialog();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomes();
            frm.Type = Statuses.Cost;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnCreateIncome_Click(object sender, EventArgs e)
        {
            var frm = new frmCreateCostOrIncome();
            frm.Type = Statuses.Income;
            frm.ShowDialog();
        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            var frm = new frmCostOrIncomes();
            frm.Type = Statuses.Income;
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new frmReport().ShowDialog();
        }

        private void brnCreateUser_Menu_Click(object sender, EventArgs e)
        {
            new frmCreateUser().ShowDialog();
        }

        private void btnUsers_Menu_Click(object sender, EventArgs e)
        {
            var frm = new frmUsers();
            frm.MdiParent = this;
            Form.Close();
            Form = frm;
            frm.Show();
        }

        private void btnChangePassword_Menu_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}