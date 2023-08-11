using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProductionNormProfile : BaseReport
    {
        #region Contructor
        public RPProductionNormProfile()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        #endregion
    }
}
