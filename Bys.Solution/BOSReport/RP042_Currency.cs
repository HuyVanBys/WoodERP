using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP042_Currency : BaseReport
    {
        /// <summary>
        /// Default start page number
        /// </summary>
        private int PageNumber = 1;
        public RP042_Currency()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableRow4_AfterPrint(object sender, EventArgs e)
        {
            if (PageNumber == 1)
                xrTableRow4.Visible = true;
            else
                xrTableRow4.Visible = false;
            PageNumber += 1;
        }

        private void xrLabel25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = " Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " N?m " + DateTime.Now.Year;
        }
    }
}
