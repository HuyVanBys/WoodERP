using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInvoiceInPayment : BaseReport
    {
        public string CurrencyName;
        public RPInvoiceInPayment()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            decimal text = 0;
            decimal.TryParse(cell.Text.ToString(), out text);
            decimal so = Math.Round(text, 2, MidpointRounding.AwayFromZero);
            if (so == 0)
                cell.Text = string.Empty;
            else
            {
                if (CurrencyName == "VND")
                {
                    cell.Text = String.Format("{0:#,##0}", text);
                }
                else
                {
                    cell.Text = String.Format("{0:#,##0.00}", text);
                }
            }

        }


    }
}
