using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPShipment : BaseReport
    {
        public RPShipment()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}
