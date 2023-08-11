using BOSERP;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP039 : BaseReport
    {
        public RP039()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void RP039_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            SetTextTableCell(Bands[BandKind.Detail]);
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = double.Parse(xrTableCell21.Text.ToString());
            //double so = Math.Round(text, 4);
            //xrTableCell21.Text = string.Format("{0:n4}",so);
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = double.Parse(xrTableCell3.Text.ToString());
            //double so = Math.Round(text, 4);
            //xrTableCell3.Text = string.Format("{0:n4}", so);
        }
    }
}
