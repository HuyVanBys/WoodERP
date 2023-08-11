using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP109 : BaseReport
    {
        public RP109()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell30.Text.ToString(), out text);
            decimal so = Math.Round(text, 2);
            if (so == 0)
                xrTableCell30.Text = string.Empty;
            //else
            //{
            //    xrTableCell30.Text = String.Format("{0:n2}", text);
            //}
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell31.Text.ToString(), out text);
            decimal so = Math.Round(text, 2);
            if (so == 0)
                xrTableCell31.Text = string.Empty;
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell12.Text.ToString(), out text);
            decimal so = Math.Round(text, 2);
            if (so == 0)
                xrTableCell12.Text = string.Empty;
        }

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell13.Text.ToString(), out text);
            decimal so = Math.Round(text, 2);
            if (so == 0)
                xrTableCell13.Text = string.Empty;
        }
    }
}
