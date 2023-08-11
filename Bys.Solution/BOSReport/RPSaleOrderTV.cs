using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPSaleOrderTV : BaseReport
    {

        public const int CurrencyID_VND = 100000;
        public const int CurrencyID_USD = 100001;
        public int GECurrencyID = CurrencyID_USD;
        public RPSaleOrderTV()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public RPSaleOrderTV(int currencyID)
        {
            InitializeComponent();
            GECurrencyID = currencyID;
        }

        private void xrTableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (strNumber % 1 > 0)
                tableCell.Text = strNumber.ToString("n3");
            else
                tableCell.Text = strNumber.ToString("n0");
        }

        private void xrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel tableCell = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = ToString(strNumber);
        }

        private string ToString(decimal number)
        {
            if (GECurrencyID == CurrencyID_VND)
            {
                Math.Round(number, 0, MidpointRounding.AwayFromZero);
                return number.ToString("n0");
            }
            return number.ToString("n2");
        }

        private void xr_tbcDiscount10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //try
            //{
            //    string value = this.xr_tbcSubTotalAmount.Summary.GetResult().ToString();
            //    decimal strNumber = 0;
            //    Decimal.TryParse(value, out strNumber);
            //    XRTableCell tablecell = sender as XRTableCell;
            //    //10% discount
            //    strNumber = strNumber * (decimal)0.1;
            //    tablecell.Text = strNumber.ToString("n2");
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void xr_tbcTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //try
            //{
            //    string value = this.xr_tbcSubTotalAmount.Summary.GetResult().ToString();
            //    decimal strNumber = 0;
            //    Decimal.TryParse(value, out strNumber);
            //    XRTableCell tablecell = sender as XRTableCell;
            //    // - 10% discount
            //    strNumber = strNumber * (decimal)0.9;
            //    tablecell.Text = strNumber.ToString("n2");
            //}
            //catch (Exception ex)
            //{
            //}
        }
    }
}