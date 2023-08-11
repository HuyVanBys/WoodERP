using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPSaleOrderForWoodViewer : BaseReport
    {
        public RPSaleOrderForWoodViewer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell99_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime ngay = DateTime.Parse(xrTableCell99.Text.ToString());
            if (ngay.Date == DateTime.MinValue.Date || ngay.Date == DateTime.MaxValue.Date)
            {
                xrTableCell99.Text = "";
            }
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell cell = (XRTableCell)sender;
            //double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderItemTotalAmountText"));
            //if (recordNumber == 0)
            //{
            //    string text = "0.00";
            //    cell.Text = text;
            //}
        }

        private void xrTableCell82_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell cell = (XRTableCell)sender;
            //double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderTotalAmountText"));
            //if (recordNumber == 0)
            //{
            //    string text = "0.00";
            //    cell.Text = text;
            //}
        }
    }
}
