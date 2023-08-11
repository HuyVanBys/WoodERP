using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP046CurrencysACCount : BaseReport
    {
        public RP046CurrencysACCount()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }


        private void xrTableCell74_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell74.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell74.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell74.Font = new Font(xrTableCell74.Font.FontFamily, xrTableCell74.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell74.Font = new Font(xrTableCell74.Font.FontFamily, xrTableCell74.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell16.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell16.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell16.Font = new Font(xrTableCell16.Font.FontFamily, xrTableCell16.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell16.Font = new Font(xrTableCell16.Font.FontFamily, xrTableCell16.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell75_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell75.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell75.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell75.Font = new Font(xrTableCell75.Font.FontFamily, xrTableCell75.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell75.Font = new Font(xrTableCell75.Font.FontFamily, xrTableCell75.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell17.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell17.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell17.Font = new Font(xrTableCell17.Font.FontFamily, xrTableCell17.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell17.Font = new Font(xrTableCell17.Font.FontFamily, xrTableCell17.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell76_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell76.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell76.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell76.Font = new Font(xrTableCell76.Font.FontFamily, xrTableCell76.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell76.Font = new Font(xrTableCell76.Font.FontFamily, xrTableCell76.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell18.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell18.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell18.Font = new Font(xrTableCell18.Font.FontFamily, xrTableCell18.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell18.Font = new Font(xrTableCell18.Font.FontFamily, xrTableCell18.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell77_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell77.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell77.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell77.Font = new Font(xrTableCell77.Font.FontFamily, xrTableCell77.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell77.Font = new Font(xrTableCell77.Font.FontFamily, xrTableCell77.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell19.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell19.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell19.Font = new Font(xrTableCell19.Font.FontFamily, xrTableCell19.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell19.Font = new Font(xrTableCell19.Font.FontFamily, xrTableCell19.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell78_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell78.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell78.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell78.Font = new Font(xrTableCell78.Font.FontFamily, xrTableCell78.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell78.Font = new Font(xrTableCell78.Font.FontFamily, xrTableCell78.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell21.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell21.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell21.Font = new Font(xrTableCell21.Font.FontFamily, xrTableCell21.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell21.Font = new Font(xrTableCell21.Font.FontFamily, xrTableCell21.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell79_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell79.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell79.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell79.Font = new Font(xrTableCell79.Font.FontFamily, xrTableCell79.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell79.Font = new Font(xrTableCell79.Font.FontFamily, xrTableCell79.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell22.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell22.Text = string.Empty;
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell22.Font = new Font(xrTableCell22.Font.FontFamily, xrTableCell22.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell22.Font = new Font(xrTableCell22.Font.FontFamily, xrTableCell22.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell14.Font = new Font(xrTableCell14.Font.FontFamily, xrTableCell14.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell14.Font = new Font(xrTableCell14.Font.FontFamily, xrTableCell14.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsEndBalance)
            {
                xrTableCell15.Font = new Font(xrTableCell15.Font.FontFamily, xrTableCell15.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell15.Font = new Font(xrTableCell15.Font.FontFamily, xrTableCell15.Font.Size, FontStyle.Regular);
            }
        }
    }
}
