using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP110 : BaseReport
    {
        public RP110()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime date = DateTime.Parse(xrTableCell15.Text.ToString());
            if (date == DateTime.MinValue)
            {
                xrTableCell15.Text = "";
            }
        }


    }
}
