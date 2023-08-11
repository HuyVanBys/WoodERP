using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPReturnShipping : BaseReport
    {
        public string GECurrencyName { get; set; }
        public RPReturnShipping()
        {
            InitializeComponent();
        }

        public RPReturnShipping(string currencyName)
        {
            InitializeComponent();
            GECurrencyName = currencyName;
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = strNumber.ToString("n2");
        }

        private void xrTableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = GECurrencyName == "VND" ? strNumber.ToString("n0") : strNumber.ToString("n2");
        }

        private void sumQtyShow_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = this.sumSubAmountHide.Summary.GetResult().ToString();
            decimal strNumber = 0;
            Decimal.TryParse(value, out strNumber);
            XRLabel label = sender as XRLabel;
            label.Text = GECurrencyName == "VND" ? strNumber.ToString("n0") : strNumber.ToString("n2");
        }

        private void xrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            label.Text = GECurrencyName == "VND" ? strNumber.ToString("n0") : strNumber.ToString("n2");
        }
    }
}
