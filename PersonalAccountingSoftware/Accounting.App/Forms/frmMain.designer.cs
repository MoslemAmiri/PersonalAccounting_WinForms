namespace Accounting.App.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuCostAndIncomes = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreateCost_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCosts_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateIncome_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncomes_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBasicinformation = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreateCostType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCostsTypes_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateIncomeType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncomesTypes_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripDropDownButton();
            this.brnCreateUser_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangePassword_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCreateCost = new System.Windows.Forms.ToolStripButton();
            this.btnCosts = new System.Windows.Forms.ToolStripButton();
            this.btnCreateIncome = new System.Windows.Forms.ToolStripButton();
            this.btnIncomes = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCostAndIncomes,
            this.mnuBasicinformation,
            this.mnuUsers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // mnuCostAndIncomes
            // 
            this.mnuCostAndIncomes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCostAndIncomes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateCost_Menu,
            this.btnCosts_Menu,
            this.toolStripMenuItem1,
            this.btnCreateIncome_Menu,
            this.btnIncomes_Menu});
            this.mnuCostAndIncomes.Image = ((System.Drawing.Image)(resources.GetObject("mnuCostAndIncomes.Image")));
            this.mnuCostAndIncomes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCostAndIncomes.Name = "mnuCostAndIncomes";
            this.mnuCostAndIncomes.Size = new System.Drawing.Size(81, 24);
            this.mnuCostAndIncomes.Text = "هزینه و درآمد";
            // 
            // btnCreateCost_Menu
            // 
            this.btnCreateCost_Menu.Name = "btnCreateCost_Menu";
            this.btnCreateCost_Menu.Size = new System.Drawing.Size(141, 24);
            this.btnCreateCost_Menu.Text = "هزینه جدید";
            this.btnCreateCost_Menu.Click += new System.EventHandler(this.btnCreateCost_Menu_Click);
            // 
            // btnCosts_Menu
            // 
            this.btnCosts_Menu.Name = "btnCosts_Menu";
            this.btnCosts_Menu.Size = new System.Drawing.Size(141, 24);
            this.btnCosts_Menu.Text = "لیست هزینه‌ها";
            this.btnCosts_Menu.Click += new System.EventHandler(this.btnCosts_Menu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // btnCreateIncome_Menu
            // 
            this.btnCreateIncome_Menu.Name = "btnCreateIncome_Menu";
            this.btnCreateIncome_Menu.Size = new System.Drawing.Size(141, 24);
            this.btnCreateIncome_Menu.Text = "درآمد جدید";
            this.btnCreateIncome_Menu.Click += new System.EventHandler(this.btnCreateIncome_Menu_Click);
            // 
            // btnIncomes_Menu
            // 
            this.btnIncomes_Menu.Name = "btnIncomes_Menu";
            this.btnIncomes_Menu.Size = new System.Drawing.Size(141, 24);
            this.btnIncomes_Menu.Text = "لیست درآمدها";
            this.btnIncomes_Menu.Click += new System.EventHandler(this.btnIncomes_Menu_Click);
            // 
            // mnuBasicinformation
            // 
            this.mnuBasicinformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuBasicinformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateCostType_Menu,
            this.btnCostsTypes_Menu,
            this.toolStripMenuItem2,
            this.btnCreateIncomeType_Menu,
            this.btnIncomesTypes_Menu});
            this.mnuBasicinformation.Image = ((System.Drawing.Image)(resources.GetObject("mnuBasicinformation.Image")));
            this.mnuBasicinformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBasicinformation.Name = "mnuBasicinformation";
            this.mnuBasicinformation.Size = new System.Drawing.Size(81, 24);
            this.mnuBasicinformation.Text = "اطلاعات پایه";
            // 
            // btnCreateCostType_Menu
            // 
            this.btnCreateCostType_Menu.Name = "btnCreateCostType_Menu";
            this.btnCreateCostType_Menu.Size = new System.Drawing.Size(165, 24);
            this.btnCreateCostType_Menu.Text = "تعریف نوع هزینه";
            this.btnCreateCostType_Menu.Click += new System.EventHandler(this.btnCreateCostType_Menu_Click);
            // 
            // btnCostsTypes_Menu
            // 
            this.btnCostsTypes_Menu.Name = "btnCostsTypes_Menu";
            this.btnCostsTypes_Menu.Size = new System.Drawing.Size(165, 24);
            this.btnCostsTypes_Menu.Text = "لیست انواع هزینه‌ها";
            this.btnCostsTypes_Menu.Click += new System.EventHandler(this.btnCostsTypes_Menu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // btnCreateIncomeType_Menu
            // 
            this.btnCreateIncomeType_Menu.Name = "btnCreateIncomeType_Menu";
            this.btnCreateIncomeType_Menu.Size = new System.Drawing.Size(165, 24);
            this.btnCreateIncomeType_Menu.Text = "تعریف نوع درآمد";
            this.btnCreateIncomeType_Menu.Click += new System.EventHandler(this.btnCreateIncomeType_Menu_Click);
            // 
            // btnIncomesTypes_Menu
            // 
            this.btnIncomesTypes_Menu.Name = "btnIncomesTypes_Menu";
            this.btnIncomesTypes_Menu.Size = new System.Drawing.Size(165, 24);
            this.btnIncomesTypes_Menu.Text = "لیست انواع درآمدها";
            this.btnIncomesTypes_Menu.Click += new System.EventHandler(this.btnIncomesTypes_Menu_Click);
            // 
            // mnuUsers
            // 
            this.mnuUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brnCreateUser_Menu,
            this.btnUsers_Menu,
            this.toolStripMenuItem3,
            this.btnChangePassword_Menu});
            this.mnuUsers.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsers.Image")));
            this.mnuUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(94, 24);
            this.mnuUsers.Text = "مدیریت کاربران";
            // 
            // brnCreateUser_Menu
            // 
            this.brnCreateUser_Menu.Name = "brnCreateUser_Menu";
            this.brnCreateUser_Menu.Size = new System.Drawing.Size(140, 24);
            this.brnCreateUser_Menu.Text = "کاربر جدید";
            this.brnCreateUser_Menu.Click += new System.EventHandler(this.brnCreateUser_Menu_Click);
            // 
            // btnUsers_Menu
            // 
            this.btnUsers_Menu.Name = "btnUsers_Menu";
            this.btnUsers_Menu.Size = new System.Drawing.Size(140, 24);
            this.btnUsers_Menu.Text = "لیست کاربران";
            this.btnUsers_Menu.Click += new System.EventHandler(this.btnUsers_Menu_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(137, 6);
            // 
            // btnChangePassword_Menu
            // 
            this.btnChangePassword_Menu.Name = "btnChangePassword_Menu";
            this.btnChangePassword_Menu.Size = new System.Drawing.Size(140, 24);
            this.btnChangePassword_Menu.Text = "تغییر رمز عبور";
            this.btnChangePassword_Menu.Click += new System.EventHandler(this.btnChangePassword_Menu_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateCost,
            this.btnCosts,
            this.btnCreateIncome,
            this.btnIncomes,
            this.btnExit,
            this.btnRestart,
            this.btnChangePassword,
            this.btnReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(934, 75);
            this.toolStrip2.TabIndex = 1;
            // 
            // btnCreateCost
            // 
            this.btnCreateCost.AutoSize = false;
            this.btnCreateCost.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCost.Image")));
            this.btnCreateCost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateCost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateCost.Name = "btnCreateCost";
            this.btnCreateCost.Size = new System.Drawing.Size(90, 72);
            this.btnCreateCost.Text = "هزینه جدید";
            this.btnCreateCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateCost.Click += new System.EventHandler(this.btnCreateCost_Click);
            // 
            // btnCosts
            // 
            this.btnCosts.AutoSize = false;
            this.btnCosts.Image = ((System.Drawing.Image)(resources.GetObject("btnCosts.Image")));
            this.btnCosts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCosts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(90, 72);
            this.btnCosts.Text = "لیست هزینه‌ها";
            this.btnCosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCosts.Click += new System.EventHandler(this.btnCosts_Click);
            // 
            // btnCreateIncome
            // 
            this.btnCreateIncome.AutoSize = false;
            this.btnCreateIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateIncome.Image")));
            this.btnCreateIncome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateIncome.Name = "btnCreateIncome";
            this.btnCreateIncome.Size = new System.Drawing.Size(90, 72);
            this.btnCreateIncome.Text = "درآمد جدید";
            this.btnCreateIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateIncome.Click += new System.EventHandler(this.btnCreateIncome_Click);
            // 
            // btnIncomes
            // 
            this.btnIncomes.AutoSize = false;
            this.btnIncomes.Image = ((System.Drawing.Image)(resources.GetObject("btnIncomes.Image")));
            this.btnIncomes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncomes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(90, 72);
            this.btnIncomes.Text = "لیست درآمدها";
            this.btnIncomes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncomes.Click += new System.EventHandler(this.btnIncomes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.AutoSize = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 72);
            this.btnExit.Text = "خروج از برنامه";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnChangePassword.AutoSize = false;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(90, 72);
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = false;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(90, 72);
            this.btnReport.Text = "گزارش";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.lblUserSystem,
            this.toolStripSeparator2,
            this.toolStripStatusLabel1,
            this.lblDate,
            this.toolStripSeparator1,
            this.toolStripStatusLabel3,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 25);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel5.Text = "مدیر سیستم :";
            // 
            // lblUserSystem
            // 
            this.lblUserSystem.Name = "lblUserSystem";
            this.lblUserSystem.Size = new System.Drawing.Size(18, 20);
            this.lblUserSystem.Text = "...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 20);
            this.toolStripStatusLabel1.Text = "تاریخ امروز :";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 20);
            this.lblDate.Text = "0000/00/00";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 20);
            this.toolStripStatusLabel3.Text = "ساعت :";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 20);
            this.lblTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRestart.AutoSize = false;
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(90, 72);
            this.btnRestart.Text = "راه‌اندازی مجدد";
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری شخصی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCreateCost;
        private System.Windows.Forms.ToolStripButton btnCosts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblUserSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton mnuCostAndIncomes;
        private System.Windows.Forms.ToolStripMenuItem btnCreateCost_Menu;
        private System.Windows.Forms.ToolStripMenuItem btnCosts_Menu;
        private System.Windows.Forms.ToolStripDropDownButton mnuBasicinformation;
        private System.Windows.Forms.ToolStripMenuItem btnCreateCostType_Menu;
        private System.Windows.Forms.ToolStripMenuItem btnCostsTypes_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnCreateIncomeType_Menu;
        private System.Windows.Forms.ToolStripMenuItem btnIncomesTypes_Menu;
        private System.Windows.Forms.ToolStripDropDownButton mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem brnCreateUser_Menu;
        private System.Windows.Forms.ToolStripMenuItem btnUsers_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword_Menu;
        private System.Windows.Forms.ToolStripButton btnCreateIncome;
        private System.Windows.Forms.ToolStripButton btnIncomes;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnChangePassword;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnCreateIncome_Menu;
        private System.Windows.Forms.ToolStripMenuItem btnIncomes_Menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton btnRestart;
    }
}