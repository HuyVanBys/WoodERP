using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP054 : BaseReport
    {
        public RP054()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void DetailRow_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string accountNo = Convert.ToString(GetCurrentColumnValue("ACAccountNo"));
            if (accountNo.Length == 3)
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else
            {
                cell.Font = new Font(cell.Font, FontStyle.Regular);
            }
        }
    }
}
