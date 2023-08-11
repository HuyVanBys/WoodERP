using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPDocument : BaseReport
    {
        public RPDocument()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private string ToString(decimal number)
        {
            Math.Round(number, 0, MidpointRounding.AwayFromZero);
            return number.ToString("n0");
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = this.xrLabel19.Summary.GetResult().ToString();
            decimal strNumber = 0;
            Decimal.TryParse(value, out strNumber);
            XRTableCell label = sender as XRTableCell;
            if (strNumber % 1 != 0)
            {
                label.Text = strNumber.ToString("n2");
            }
            else
            {
                label.Text = strNumber.ToString("n0");
            }
        }

        private void xrTableCell20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = this.xrLabel21.Summary.GetResult().ToString();
            decimal strNumber = 0;
            Decimal.TryParse(value, out strNumber);
            XRTableCell label = sender as XRTableCell;
            if (strNumber % 1 != 0)
            {
                label.Text = strNumber.ToString("n2");
            }
            else
            {
                label.Text = strNumber.ToString("n0");
            }
        }
    }
}
