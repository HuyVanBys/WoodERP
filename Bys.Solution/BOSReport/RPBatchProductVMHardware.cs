using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProductVMHardware : BaseReport
    {
        public RPBatchProductVMHardware()
        {
            InitializeComponent();
            xrPictureBox1.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
    }
}