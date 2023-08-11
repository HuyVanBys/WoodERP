using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP051 : BaseReport
    {

        public RP051()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text xrTableCell32 
        }
    }
}
