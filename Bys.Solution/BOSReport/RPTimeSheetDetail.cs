using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTimeSheetDetail : BaseReport
    {
        public RPTimeSheetDetail()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

    }
}
