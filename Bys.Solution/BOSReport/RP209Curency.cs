using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP209Curency : BaseReport
    {
        int CurrencyID;
        public RP209Curency(int currencyID)
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            CurrencyID = currencyID;
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
        }

        private void xrTableCell23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell23.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell23.Text = string.Empty;
            else
            {
                xrTableCell23.Text = String.Format("{0:#,##0}", text);
            }
        }

        private void xrTableCell26_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell26.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell26.Text = string.Empty;
            else
            {
                if (CurrencyID == 0)
                    xrTableCell26.Text = String.Format("{0:#,##0}", text);
                else
                    xrTableCell26.Text = String.Format("{0:#,##0.00}", text);
            }
        }

    }
}
