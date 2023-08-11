using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ReceiptForLumber : BaseReport
    {
        public RP_ReceiptForLumber()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell20.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell20.Text = so.ToString();
            xrTableCell20.Padding = 2;
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell21.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell21.Text = so.ToString();
            xrTableCell21.Padding = 2;
        }

        //private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    double text = double.Parse(xrTableCell11.Text.ToString());
        //    double so = Math.Round(text, 0);
        //    xrTableCell11.Text = so.ToString();
        //    xrTableCell11.Padding=2;
        //}

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell19.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell19.Text = so.ToString();
            xrTableCell19.Padding = 2;
        }

        //private void xrTableCell18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    double text = double.Parse(xrTableCell18.Text.ToString());
        //    double so = Math.Round(text, 0);
        //    xrTableCell18.Text = so.ToString();
        //    xrTableCell18.Padding=2;
        //}

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell15.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell15.Text = so.ToString();
            xrTableCell15.Padding = 2;
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
            string value = this.sumProductQtyHide.Summary.GetResult().ToString();
            decimal strNumber = 0;
            Decimal.TryParse(value, out strNumber);
            XRLabel label = sender as XRLabel;
            if (strNumber % 1 != 0)
            {
                label.Text = strNumber.ToString("n4");
            }
            else
            {
                label.Text = strNumber.ToString("n0");
            }
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
