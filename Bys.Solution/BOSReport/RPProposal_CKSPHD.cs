using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPProposal_CKSPHD : BaseReport
    {
        public const int CurrencyID_VND = 100000;
        public const int CurrencyID_USD = 100001;
        public int GECurrencyID = CurrencyID_USD;
        public RPProposal_CKSPHD()
        {
            InitializeComponent();
        }

        public RPProposal_CKSPHD(int currencyID)
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

        public void xrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        private void xrLabel50_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            label.Text = ToString(strNumber);
        }
    }
}
