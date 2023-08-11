using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RPTimeSheetAuditDetail : BaseReport
    {
        public RPTimeSheetAuditDetail()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

    }
}
