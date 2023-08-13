using System.Windows.Forms;
using Accounting.ViewModels.Report;
using Accounting.Utility;
using System;
using Stimulsoft.Report;
using Accounting.Business;

namespace Accounting.App.Forms.Reports
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Statistics()
        {
            #region date
            string dateFrom = dtpDateFrom.ToDatePersian();
            string dateTo = dtpDateTo.ToDatePersian();
            #endregion

            ReportViewModel report = Report.Statistics(dateFrom, dateTo);
            txtTotalCosts.Text = report.TotalCosts.ToMoney();
            txtCostsCount.Text = report.CostsCount.ToString();
            txtTotalIncomes.Text = report.TotalIncomes.ToMoney();
            txtIncomesCount.Text = report.IncomesCount.ToString();
            txtRemaining.Text = report.Remaining.ToMoney();
        }

        private void PrintTheReport()
        {
            try
            {
                StiOptions.Viewer.Windows.ShowPageDesignButton = true;
                StiOptions.Designer.CodeTabVisible = true;
                var LoadReport = new StiReport();
                LoadReport.Load(Environment.CurrentDirectory + @"\Prints\Report.mrt");
                LoadReport.Compile();
                LoadReport.ReportName = "گزارش هزینه‌ها و درآمدها";

                LoadReport["FullName"] = PublicVariable.FullName;
                LoadReport["DateFrom"] = dtpDateFrom.ToDatePersian();
                LoadReport["DateTo"] = dtpDateTo.ToDatePersian();
                LoadReport["TotalCosts"] = txtTotalCosts.Text;
                LoadReport["CostsCount"] = txtCostsCount.Text;
                LoadReport["TotalIncomes"] = txtTotalIncomes.Text;
                LoadReport["IncomesCount"] = txtIncomesCount.Text;
                LoadReport["Remaining"] = txtRemaining.Text;

                LoadReport.Dictionary.Synchronize();
                var rptviewer = new frmReportViewer()
                {
                    stiViewerControl1 = { Report = LoadReport }
                };

                LoadReport.Render();
                rptviewer.ShowDialog();
            }
            catch (Exception)
            {
                AppTools.Message(Statuses.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Statistics();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Statistics();
            PrintTheReport();
        }
    }
}