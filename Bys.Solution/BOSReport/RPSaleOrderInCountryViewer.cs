using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPSaleOrderInCountryViewer : BaseReport
    {
        public RPSaleOrderInCountryViewer()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        //private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTableCell cell = (XRTableCell)sender;
        //    double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderItemTotalAmount"));
        //    if (recordNumber == 0)
        //    {
        //        string text = "0.00";
        //        cell.Text = text;
        //    }
        //}

        //private void xrTableCell82_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTableCell cell = (XRTableCell)sender;
        //    double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderSubTotalAmount"));
        //    if (recordNumber == 0)
        //    {
        //        string text = "0.00";
        //        cell.Text = text;
        //    }
        //}

        //private void xrTableCell58_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTableCell cell = (XRTableCell)sender;
        //    double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderTaxAmount"));
        //    if (recordNumber == 0)
        //    {
        //        string text = "0.00";
        //        cell.Text = text;
        //    }
        //}

        //private void xrTableCell62_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTableCell cell = (XRTableCell)sender;
        //    double recordNumber = Convert.ToDouble(GetCurrentColumnValue("ARSaleOrderTotalAmount"));
        //    if (recordNumber == 0)
        //    {
        //        string text = "0.00";
        //        cell.Text = text;
        //    }
        //}
    }
}
