using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTransferBorrowSamples : BaseReport
    {
        public RPTransferBorrowSamples()
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        decimal dTotalNumber = 0;
        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = sender as XRTableCell;
            //decimal strNumber = 0;
            //Decimal.TryParse(tableCell.Text, out strNumber);
            //if (strNumber % 1 != 0)
            //{
            //    tableCell.Text = strNumber.ToString("n3");
            //}
            //else
            //    tableCell.Text = strNumber.ToString("n0");
        }

        private void xrLabelQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            if (strNumber % 1 != 0)
            {
                label.Text = strNumber.ToString("n3");
            }
            else
                label.Text = strNumber.ToString("n0");
        }

        private void xrTableCell5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal dNumber = 0;
            Decimal.TryParse(label.Text, out dNumber);
            dTotalNumber = dTotalNumber + dNumber;
            xrTableCell5.Text = xrTableCell5.Text.Replace(",",".");
            xrTableCell15.Text = dTotalNumber.ToString("n0").Replace(",", ".");
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrTableCell15.Text = xrTableCell15.Text.Replace(",", ".");
        }

        private void xrTableCell15_TextChanged(object sender, EventArgs e)
        {
            //xrTableCell15.Text = xrTableCell15.Text.Replace(",", ".");
        }
    }
}
