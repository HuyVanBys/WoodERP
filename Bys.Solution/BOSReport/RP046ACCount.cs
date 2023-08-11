using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP046ACCount : BaseReport
    {
        public RP046ACCount()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell30.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell30.Text = string.Empty;
            else
            {
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell30.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell30.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell31.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell31.Text = string.Empty;
            else
            {
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell31.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell31.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell31.Font = new Font(xrTableCell31.Font.FontFamily, xrTableCell31.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell31.Font = new Font(xrTableCell31.Font.FontFamily, xrTableCell31.Font.Size, FontStyle.Regular);
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
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell32.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell32.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Regular);
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
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell33.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell33.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell9.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell9.Text = string.Empty;
            else
            {
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell9.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell9.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell9.Font = new Font(xrTableCell9.Font.FontFamily, xrTableCell9.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell9.Font = new Font(xrTableCell9.Font.FontFamily, xrTableCell9.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell10.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell10.Text = string.Empty;
            else
            {
                string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
                if (curencyName == "VND")
                    xrTableCell10.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell10.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell10.Font = new Font(xrTableCell10.Font.FontFamily, xrTableCell10.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell10.Font = new Font(xrTableCell10.Font.FontFamily, xrTableCell10.Font.Size, FontStyle.Regular);
            }
        }



        private void xrTableCell28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell28.Font = new Font(xrTableCell28.Font.FontFamily, xrTableCell28.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell28.Font = new Font(xrTableCell28.Font.FontFamily, xrTableCell28.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell29_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell29.Font = new Font(xrTableCell29.Font.FontFamily, xrTableCell29.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell29.Font = new Font(xrTableCell29.Font.FontFamily, xrTableCell29.Font.Size, FontStyle.Regular);
            }
        }
    }
}
