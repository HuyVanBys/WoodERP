using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTimeSheetDetailA4Landscape : BaseReport
    {
        public RPTimeSheetDetailA4Landscape()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

    }
}
