using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_MaterialShipmentA5CCDCGroup : BaseReport
    {
        public RP_MaterialShipmentA5CCDCGroup()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (strNumber % 1 != 0)
            {
                tableCell.Text = strNumber.ToString("n3");
            }
            else
                tableCell.Text = strNumber.ToString("n0");
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
    }
}
