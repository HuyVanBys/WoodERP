using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPSaleOrderForWoodOutSourcingViewer : BaseReport
    {
        public RPSaleOrderForWoodOutSourcingViewer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
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
            //double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderTotalAmountVATText"));
            //if (recordNumber == 0)
            //{
            //    string text = "0.00";
            //    cell.Text = text;
            //}
        }

        private void xrTableCell58_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell cell = (XRTableCell)sender;
            //double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderAmountVATText"));
            //if (recordNumber == 0)
            //{
            //    string text = "0.00";
            //    cell.Text = text;
            //}
        }

        private void xrTableCell62_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
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
