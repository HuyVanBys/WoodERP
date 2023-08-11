using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP047 : BaseReport
    {
        public RP047()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell7.Font = new Font(xrTableCell7.Font.FontFamily, xrTableCell7.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell7.Font = new Font(xrTableCell7.Font.FontFamily, xrTableCell7.Font.Size, FontStyle.Regular);
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
                if (curencyName == "VND")
                    xrTableCell32.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell32.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell34.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell34.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell34.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell34.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell34.Font = new Font(xrTableCell34.Font.FontFamily, xrTableCell34.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell34.Font = new Font(xrTableCell34.Font.FontFamily, xrTableCell34.Font.Size, FontStyle.Regular);
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
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell35.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell35.Text = string.Empty;
            else
            {
                xrTableCell35.Text = String.Format("{0:#,##0}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell35.Font = new Font(xrTableCell35.Font.FontFamily, xrTableCell35.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell35.Font = new Font(xrTableCell35.Font.FontFamily, xrTableCell35.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell47_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell47.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell47.Text = string.Empty;
            else
            {
                xrTableCell47.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0)
            {
                xrTableCell27.Text = string.Empty;
            }
        }
    }
}
