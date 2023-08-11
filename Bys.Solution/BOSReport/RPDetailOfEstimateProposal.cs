using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPDetailOfEstimateProposal : BaseReport
    {
        public const int CurrencyID_VND = 100000;
        public const int CurrencyID_USD = 100001;
        public int GECurrencyID = CurrencyID_USD;
        public RPDetailOfEstimateProposal()
        {
            InitializeComponent();
        }

        public RPDetailOfEstimateProposal(int currencyID)
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

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (strNumber % 1 > 0)
                tableCell.Text = strNumber.ToString("n3");
            else
                tableCell.Text = strNumber.ToString("n0");
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
