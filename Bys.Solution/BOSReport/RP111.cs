using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP111 : BaseReport
    {
        public RP111()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(xrTableCell14.Text.ToString());
                if (date == DateTime.MinValue)
                {
                    xrTableCell14.Text = "";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void xrTableCell29_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(xrTableCell29.Text.ToString());
                if (date == DateTime.MinValue)
                {
                    xrTableCell29.Text = "";
                }
            }
            catch (Exception ex)
            {
            }
        }


    }
}
