using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInventoryProductSerie : BaseReport
    {
        public RPInventoryProductSerie()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        public string ProductSerieLotNo { set; get; }
        public string ProductSerieNo { set; get; }
        public string ProductQty { set; get; }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell1.Text = ProductSerieNo;
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell2.Text = ProductQty;
        }

    }
}
