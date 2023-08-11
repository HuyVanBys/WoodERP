using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaymentVoucher : BaseReport
    {
        public RPPaymentVoucher()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrLabel24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormatPrice(sender);
        }

        private void FormatPrice(object sender)
        {
            GECurrenciesInfo objCurrenciesInfo = ((GECurrenciesInfo)bsGECurrenciesInfo.DataSource);
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            if (objCurrenciesInfo != null)
            {
                if (objCurrenciesInfo.GECurrencyNo == "VND")
                {
                    label.Text = strNumber.ToString("n0");
                }
                else
                    label.Text = strNumber.ToString("n2");
            }
            else
                label.Text = strNumber.ToString("n2");
        }

        private void xrLabel30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormatPrice(sender);
        }

        private void xrLabel31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FormatPrice(sender);
        }

    }
}
