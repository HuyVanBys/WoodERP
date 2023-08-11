using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPStampProductsForReceipt : BaseReport
    {
        public RPStampProductsForReceipt()
        {
            InitializeComponent();
            xrPictureBox1.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
