using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP213 : BaseReport
    {
        public RP213()
        {
            InitializeComponent();
            xrPictureBox1.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
