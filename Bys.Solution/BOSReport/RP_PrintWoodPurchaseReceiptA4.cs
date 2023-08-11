using BOSERP;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RP_PrintWoodPurchaseReceiptA4 : BaseReport
    {
        public RP_PrintWoodPurchaseReceiptA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + @"\Img\Logo\logoHoriz.png";
        }

    }
}
