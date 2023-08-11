using DevExpress.XtraReports.UI;

namespace BOSReport
{
    public partial class RPAdvanceRefund : BaseReport
    {
        public RPAdvanceRefund()
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = xrTableCell2;
            if (cell.Text == "0")
            {
                cell.Text = string.Empty;
            }
        }

    }
}
