using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAllocationProposalWood : BaseReport
    {
        public RPAllocationProposalWood()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
