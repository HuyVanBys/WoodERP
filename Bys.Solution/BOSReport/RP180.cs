using BOSERP;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP180 : BaseReport
    {
        public RP180()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public string DateTimeReport { get; set; }

        private void xr_lblFromdateTodate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = DateTimeReport;
        }

    }
}
