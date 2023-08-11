using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RP_Acceptance : BaseReport
    {
        public RP_Acceptance()
        {
            InitializeComponent();
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            if (!String.IsNullOrEmpty(tableCell.Text))
            {
                Decimal.TryParse(tableCell.Text, out strNumber);
                if (strNumber % 1 > 0)
                    tableCell.Text = strNumber.ToString("n3");
                else
                    tableCell.Text = strNumber.ToString("n0");
            }
        }

        private void xrTableCellAtributes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = strNumber.ToString("n0");
        }
    }
}
