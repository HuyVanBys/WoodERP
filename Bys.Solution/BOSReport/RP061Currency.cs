using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP061Currency : BaseReport
    {

        public RP061Currency()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell31.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell31.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell31.Text = string.Empty;
                else
                    xrTableCell31.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
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
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell32.Text = string.Empty;
            else
            {
                xrTableCell32.Text = String.Format("{0:#,##0}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Regular);
            }

        }


        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Regular);
            }

        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell11.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell11.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell11.Text = string.Empty;
                else
                    xrTableCell11.Text = String.Format("{0:#,##0.00}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell11.Font = new Font(xrTableCell31.Font.FontFamily, xrTableCell31.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell11.Font = new Font(xrTableCell31.Font.FontFamily, xrTableCell31.Font.Size, FontStyle.Regular);
            }
        }
        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell33.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell33.Text = string.Empty;
            else
            {
                xrTableCell33.Text = String.Format("{0:#,##0}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Regular);
            }
        }
    }
}
