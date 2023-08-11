using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP209 : BaseReport
    {
        public RP209()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell11.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell11.Text = string.Empty;
            else
                xrTableCell11.Text = String.Format("{0:#,##0}", text);
        }

        private void xrTableCell30_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell30.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell30.Text = string.Empty;
            else
            {
                xrTableCell30.Text = String.Format("{0:#,##0}", text);
            }
        }

    }
}
