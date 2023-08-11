using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP210Curency : BaseReport
    {
        public RP210Curency()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell10.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell10.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell10.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell10.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell10.Font = new Font(xrTableCell10.Font.FontFamily, xrTableCell10.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell10.Font = new Font(xrTableCell10.Font.FontFamily, xrTableCell10.Font.Size, FontStyle.Regular);
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
                    xrTableCell11.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell11.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell11.Font = new Font(xrTableCell11.Font.FontFamily, xrTableCell11.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell11.Font = new Font(xrTableCell11.Font.FontFamily, xrTableCell11.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell2.Font = new Font(xrTableCell2.Font.FontFamily, xrTableCell2.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell2.Font = new Font(xrTableCell2.Font.FontFamily, xrTableCell2.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell5.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell5.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell5.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell5.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell5.Font = new Font(xrTableCell5.Font.FontFamily, xrTableCell5.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell5.Font = new Font(xrTableCell5.Font.FontFamily, xrTableCell5.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell4.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell4.Text = string.Empty;
            else
            {
                if (curencyName == "VND")
                    xrTableCell4.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell4.Text = String.Format("{0:#,##0.00}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell4.Font = new Font(xrTableCell4.Font.FontFamily, xrTableCell4.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell4.Font = new Font(xrTableCell4.Font.FontFamily, xrTableCell4.Font.Size, FontStyle.Regular);
            }
        }

    }
}
