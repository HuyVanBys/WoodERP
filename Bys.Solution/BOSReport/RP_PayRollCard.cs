using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RP_PayRollCard : BaseReport
    {
        public RP_PayRollCard()
        {
            InitializeComponent();
        }

        private void TableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            if (tableCell == null)
                return;

            decimal value = 0;
            Decimal.TryParse(tableCell.Text, out value);
            if (value == 0)
            {
                tableCell.Text = "-";
            }
        }

    }
}
