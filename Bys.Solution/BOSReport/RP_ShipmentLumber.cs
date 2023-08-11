using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ShipmentLumber : BaseReport
    {
        public RP_ShipmentLumber()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell8.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell8.Text = string.Format("{0:n0}", so);
            xrTableCell8.Padding = 2;
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (strNumber % 1 != 0)
            {
                tableCell.Text = strNumber.ToString("n4");
            }
            else
                tableCell.Text = strNumber.ToString("n0");
        }

        private void sumQtyShow_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = this.sumQtyHide.Summary.GetResult().ToString();
            decimal strNumber = 0;
            Decimal.TryParse(value, out strNumber);
            if (strNumber % 1 != 0)
            {
                sumQtyShow.Text = strNumber.ToString("n4");
            }
            else
            {
                sumQtyShow.Text = strNumber.ToString("n0");
            }
        }

        private void xrLabelQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            if (strNumber % 1 != 0)
            {
                label.Text = strNumber.ToString("n4");
            }
            else
                label.Text = strNumber.ToString("n0");
        }
    }
}
