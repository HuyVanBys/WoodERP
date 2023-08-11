using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP069 : BaseReport
    {
        public RP069()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XRTableCell tableCell = sender as XRTableCell;
                decimal strNumber = 0;
                Decimal.TryParse(tableCell.Text, out strNumber);
                tableCell.Text = strNumber.ToString("n0");
            }
            catch (Exception ex) { }
        }
    }
}
