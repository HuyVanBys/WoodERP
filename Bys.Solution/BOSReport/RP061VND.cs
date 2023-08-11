using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP061VND : BaseReport
    {

        public RP061VND()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal text = 0;
            decimal.TryParse(xrTableCell18.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell18.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                {
                    xrTableCell18.Text = String.Format("{0:#,##0}", text);
                }
                else
                {
                    xrTableCell18.Text = String.Format("{0:#,##0.00}", text);
                }
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell18.Font = new Font(xrTableCell18.Font.FontFamily, xrTableCell18.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell18.Font = new Font(xrTableCell18.Font.FontFamily, xrTableCell18.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal.TryParse(xrTableCell24.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell24.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                {
                    xrTableCell24.Text = String.Format("{0:#,##0}", text);
                }
                else
                {
                    xrTableCell24.Text = String.Format("{0:#,##0.00}", text);
                }
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell24.Font = new Font(xrTableCell24.Font.FontFamily, xrTableCell24.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell24.Font = new Font(xrTableCell24.Font.FontFamily, xrTableCell24.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal.TryParse(xrTableCell27.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell27.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                {
                    xrTableCell27.Text = String.Format("{0:#,##0}", text);
                }
                else
                {
                    xrTableCell27.Text = String.Format("{0:#,##0.00}", text);
                }
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
    }
}
