using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPPOSRetailBillVinmus : BaseReport
    {
        public RPPOSRetailBillVinmus()
        {
            InitializeComponent();
        }

        private void bs_ARInvoiceItemsInfo_CurrentChanged(object sender, EventArgs e)
        {

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
            if (number == 0)
                return "0";
            if (number < 1)
                return number.ToString("n3");
            return number / Convert.ToInt32(number) != 1 ? number.ToString("n3") : number.ToString("n0");
        }
    }
}
