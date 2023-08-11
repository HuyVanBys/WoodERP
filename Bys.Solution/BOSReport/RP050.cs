using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP050 : BaseReport
    {

        public RP050()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell12.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell12.Text = string.Empty;
            else
            {
                xrTableCell12.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell32.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell32.Text = string.Empty;
            else
            {
                xrTableCell32.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell37_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell37.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell37.Text = string.Empty;
            else
            {
                xrTableCell37.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell34.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell34.Text = string.Empty;
            else
            {
                xrTableCell34.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell25.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell25.Text = string.Empty;
            else
            {
                xrTableCell25.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell19.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell19.Text = string.Empty;
            else
            {
                xrTableCell19.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell44.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell44.Text = string.Empty;
            else
            {
                xrTableCell44.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell14.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell14.Text = string.Empty;
            else
            {
                xrTableCell14.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            decimal text = 0;
            decimal.TryParse(xrTableCell26.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell26.Text = string.Empty;
            else
            {
                xrTableCell26.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell13.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell13.Text = string.Empty;
            else
            {
                xrTableCell13.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell33.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell33.Text = string.Empty;
            else
            {
                xrTableCell33.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell53_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell53.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell53.Text = string.Empty;
            else
            {
                xrTableCell53.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell39.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell39.Text = string.Empty;
            else
            {
                xrTableCell39.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell15.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell15.Text = string.Empty;
            else
            {
                xrTableCell15.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell35.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell35.Text = string.Empty;
            else
            {
                xrTableCell35.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell54_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell54.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell54.Text = string.Empty;
            else
            {
                xrTableCell54.Text = String.Format("{0:#,##0.00}", text);
            }
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell22.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell22.Text = string.Empty;
            else
            {
                xrTableCell22.Text = String.Format("{0:#,##0.00}", text);
            }
        }

    }
}
