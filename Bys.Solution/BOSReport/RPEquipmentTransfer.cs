using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPEquipmentTransfer : BaseReport
    {
        public RPEquipmentTransfer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
