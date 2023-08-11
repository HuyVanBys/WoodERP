using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_WoodPurchaseReceiptForRoundWoodAndMoney : BaseReport
    {
        public RP_WoodPurchaseReceiptForRoundWoodAndMoney()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell17.Text.ToString());
            double so = Math.Round(text, 4);
            xrTableCell17.Text = string.Format("{0:n4}", so);
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell8.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell8.Text = string.Format("{0:n0}", so);
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell6.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell6.Text = string.Format("{0:n0}", so);
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrTableCell15.Text.ToString());
            double so = Math.Round(text, 0);
            xrTableCell15.Text = string.Format("{0:n0}", so);
        }

        private void xrLabel31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrLabel31.Text.ToString());
            double so = Math.Round(text, 0);
            xrLabel31.Text = string.Format("{0:n0}", so);
        }

        private void xrLabel32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = double.Parse(xrLabel32.Text.ToString());
            double so = Math.Round(text, 4);
            xrLabel32.Text = string.Format("{0:n4}", so);
        }

    }
}
