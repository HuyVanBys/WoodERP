using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP063 : BaseReport
    {

        public RP063()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime CurrentDate = BOSApp.GetCurrentServerDate();
            (sender as XRLabel).Text = String.Format("Ngày {0} tháng {1} năm {2}", CurrentDate.Day, CurrentDate.Month, CurrentDate.Year);
        }

        private void xrLabel16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = String.Format("ngày {0}", (sender as XRLabel).Text);
        }
    }
}
