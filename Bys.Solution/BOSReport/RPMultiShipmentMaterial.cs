using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPMultiShipmentMaterial : BaseReport
    {
        public RPMultiShipmentMaterial()
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrLabel1.Text == "PHIẾU XUẤT KHO VẬT TƯ - ")
                xrLabel1.Text = "PHIẾU XUẤT KHO VẬT TƯ";
        }
    }
}
