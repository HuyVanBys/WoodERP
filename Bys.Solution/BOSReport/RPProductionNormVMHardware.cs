using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProductionNormVMHardware : BaseReport
    {
        public RPProductionNormVMHardware()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}