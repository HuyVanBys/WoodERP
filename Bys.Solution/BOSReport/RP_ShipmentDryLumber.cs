using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ShipmentDryLumber : BaseReport
    {
        public RP_ShipmentDryLumber()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = Double.Parse(xrTableCell8.Text.ToString());
            //decimal so = Math.Round((decimal)text, 0);
            //xrTableCell8.Text = string.Format("{0:n0}", so);
            //xrTableCell8.Padding = 2;
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = Double.Parse(xrTableCell19.Text.ToString());
            //decimal so = Math.Round((decimal)text, 0);
            //xrTableCell19.Text = string.Format("{0:n0}", so);
            //xrTableCell19.Padding = 2;
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = Double.Parse(xrTableCell9.Text.ToString());
            //decimal so = Math.Round((decimal)text, 0);
            //xrTableCell9.Text = string.Format("{0:n0}", so);
            //xrTableCell9.Padding = 2;
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell21.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell21.Text = string.Format("{0:n0}", so);
            xrTableCell21.Padding = 2;
        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double text = Double.Parse(xrTableCell11.Text.ToString());
            decimal so = Math.Round((decimal)text, 0);
            xrTableCell11.Text = string.Format("{0:n0}", so);
            xrTableCell11.Padding = 2;
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //decimal text = 0;
            //decimal.TryParse(xrTableCell15.Text.ToString(), out text);
            //decimal so = Math.Round((decimal)text, 0);
            //xrTableCell15.Text = string.Format("{0:n0}", so);
            //xrTableCell15.Padding = 2;
        }

        private void xrLabel17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double text = Double.Parse(xrLabel17.Text.ToString());
            //decimal so = Math.Round((decimal)text, 0);
            //xrLabel17.Text = string.Format("{0:n0}", so);
            //xrLabel17.Padding = 2;
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell29_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell41_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell43_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell45_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrTableCell4.Text.ToString(), out number);
            if (number % 1 == 0) 
            {
                decimal so = Math.Round((decimal)number, 0);
                xrTableCell4.Text = string.Format("{0:n0}", so);
            }
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrLabel6.Text.ToString(), out number);
            if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrLabel6.Text = string.Format("{0:n0}", so);
            }
        }

        private void xrLabel6_SummaryCalculated(object sender, DevExpress.XtraReports.UI.TextFormatEventArgs e)
        {

        }

        private void xrLabel6_SummaryRowChanged(object sender, EventArgs e)
        {

        }

        private void xrLabel6_TextChanged(object sender, EventArgs e)
        {

        }

        private void xrLabel6_SummaryGetResult(object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
        {

        }

        private void xrLabel6_SummaryReset(object sender, EventArgs e)
        {

        }

        private void xrLabel6_Draw(object sender, DevExpress.XtraReports.UI.DrawEventArgs e)
        {

        }

        private void xrLabel6_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrLabel6.Text.ToString(), out number);
            if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrLabel6.Text = string.Format("{0:n0}", so);
            }
        }

        private void xrLabel6_HtmlItemCreated(object sender, DevExpress.XtraReports.UI.HtmlEventArgs e)
        {

        }

        private void xrLabel6_EvaluateBinding(object sender, DevExpress.XtraReports.UI.BindingEventArgs e)
        {

        }

        private void xrLabel6_AfterPrint(object sender, EventArgs e)
        {

        }
    }
}
