using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPurchaseOrderOutsourcings : BaseReport
    {
        public RPPurchaseOrderOutsourcings()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double day = double.Parse(xrTableCell13.Text.ToString());
            xrTableCell13.Text = day.ToString("N2");
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double rong = double.Parse(xrTableCell3.Text.ToString());
            xrTableCell3.Text = rong.ToString("N2");
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double dai = double.Parse(xrTableCell15.Text.ToString());
            xrTableCell15.Text = dai.ToString("N2");
        }

    }
}
