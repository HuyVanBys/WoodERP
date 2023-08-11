using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInvoiceProduct : BaseReport
    {
        public RPInvoiceProduct()
        {
            InitializeComponent();
            xrPictureBox1.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
