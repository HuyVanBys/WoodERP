using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP158 : BaseReport
    {
        public RP158()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
