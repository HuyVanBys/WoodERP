using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ShipmentRoundWood : BaseReport
    {
        public RP_ShipmentRoundWood()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell6.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell6.Text = string.Format("{0:n0}", so);
            xrTableCell6.Padding = 2;
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell8.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell8.Text = string.Format("{0:n0}", so);
            xrTableCell8.Padding = 2;
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell15.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell15.Text = string.Format("{0:n0}", so);
            xrTableCell15.Padding = 2;
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrLabel17.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrLabel17.Text = string.Format("{0:n0}", so);
            xrLabel17.Padding = 2;
        }

    }
}
