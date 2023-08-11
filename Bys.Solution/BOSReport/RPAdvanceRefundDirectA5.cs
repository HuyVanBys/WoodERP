using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAdvanceRefundDirectA5 : BaseReport
    {
        public const int CurrencyID_VND = 100000;
        public const int CurrencyID_USD = 100001;
        public int GECurrencyID = CurrencyID_USD;
        public RPAdvanceRefundDirectA5()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public RPAdvanceRefundDirectA5(int currencyID)
        {
            InitializeComponent();
            GECurrencyID = currencyID;
        }

        private void xrTableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private void xrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel tableCell = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private string ToString(decimal number)
        {
            if (GECurrencyID == CurrencyID_VND)
            {
                Math.Round(number, 0, MidpointRounding.AwayFromZero);
                return number.ToString("n0");
            }
            return number.ToString("n2");
        }
    }
}
