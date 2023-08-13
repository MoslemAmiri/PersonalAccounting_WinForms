using System.Windows.Forms;

namespace Accounting.App.Forms
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void stiViewerControl1_Close(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}