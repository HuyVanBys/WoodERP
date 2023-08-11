using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP210 : BaseReport
    {
        public RP210()
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

    }
}
