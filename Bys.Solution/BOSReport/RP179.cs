using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RP179 : BaseReport
    {
        public RP179()
        {
            InitializeComponent();
        }

        public string FullAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string DateTimeReport { get; set; }

        private void xr_lblBRBranchAddressLine3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = FullAddress;
        }

        private void xr_lblBRBranchPhone_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = PhoneNumber;
        }

        private void xr_lblBRBranchFax_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = FaxNumber;
        }

        private void xr_lblFromdateTodate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = DateTimeReport;
        }

        private void xrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = " Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " N?m " + DateTime.Now.Year;
        }

    }
}
