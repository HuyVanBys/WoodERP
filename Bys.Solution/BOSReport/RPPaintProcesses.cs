using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPaintProcesses : BaseReport
    {
        public RPPaintProcesses()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        private void xrTableCell25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell xrTableCell = (XRTableCell)sender;
            string text = Convert.ToString(xrTableCell25.Text.ToString());
            if (text != string.Empty)
            {
                xrTableCell.Font = new Font(xrTableCell.Font, FontStyle.Bold);
            }
        }
    }
}
