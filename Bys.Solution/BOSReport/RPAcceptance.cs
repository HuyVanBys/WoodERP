using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPAcceptance : BaseReport
    {
        public RPAcceptance()
        {
            InitializeComponent();
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (strNumber == 0 || (Convert.ToInt32(strNumber) != 0 && strNumber / Convert.ToInt32(strNumber) == 1))
            {
                tableCell.Text = strNumber.ToString("n0");
            }
            else if ((strNumber < 1 && strNumber > -1) || (Convert.ToInt32(strNumber) != 0 && strNumber / Convert.ToInt32(strNumber) > 1))
            {
                tableCell.Text = strNumber.ToString("n3");
            }
        }
    }
}
