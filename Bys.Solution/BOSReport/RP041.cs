using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP041 : BaseReport
    {
        public RP041()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public string FullAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string DateTimeReport { get; set; }

        private void xr_lblBRBranchAddressLine3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = FullAddress;
        }

        private void xr_lblBRBranchPhone_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = PhoneNumber;
        }

        private void xr_lblBRBranchFax_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = FaxNumber;
        }

        private void xr_lblFromdateTodate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = DateTimeReport;
        }

        private void xrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = " Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " Nãm " + DateTime.Now.Year;
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
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
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
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell11.Font = new Font(xrTableCell11.Font.FontFamily, xrTableCell11.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell11.Font = new Font(xrTableCell11.Font.FontFamily, xrTableCell11.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell12.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell12.Text = string.Empty;
            else
            {
                xrTableCell12.Text = String.Format("{0:#,##0}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell12.Font = new Font(xrTableCell12.Font.FontFamily, xrTableCell12.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell12.Font = new Font(xrTableCell12.Font.FontFamily, xrTableCell12.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell7.Text.ToString(), out text);
            string curencyName = GetCurrentColumnValue("GECurrencyName").ToString();
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell7.Text = string.Empty;
            else
            {
                xrTableCell7.Text = String.Format("{0:#,##0}", text);
            }
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell7.Font = new Font(xrTableCell7.Font.FontFamily, xrTableCell7.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell7.Font = new Font(xrTableCell7.Font.FontFamily, xrTableCell7.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell108_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool IsOpeningBalance = (bool)GetCurrentColumnValue("IsOpeningBalance");
            bool IsEndBalance = (bool)GetCurrentColumnValue("IsEndBalance");
            if (IsOpeningBalance || IsEndBalance)
            {
                xrTableCell108.Font = new Font(xrTableCell108.Font.FontFamily, xrTableCell108.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell108.Font = new Font(xrTableCell108.Font.FontFamily, xrTableCell108.Font.Size, FontStyle.Regular);
            }
        }
    }
}
