using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP148 : BaseReport
    {
        public RP148()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrLabel38_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
