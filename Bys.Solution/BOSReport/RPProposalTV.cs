using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProposalTV : BaseReport
    {

        public RPProposalTV()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xr_tbcDiscount10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string value = this.xr_tbcSubTotalAmount.Summary.GetResult().ToString();
                decimal strNumber = 0;
                Decimal.TryParse(value, out strNumber);
                XRTableCell tablecell = sender as XRTableCell;
                //10% discount
                strNumber = strNumber * (decimal)0.1;
                tablecell.Text = strNumber.ToString("n2");
            }
            catch (Exception ex)
            {
            }
        }

        private void xr_tbcTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string value = this.xr_tbcSubTotalAmount.Summary.GetResult().ToString();
                decimal strNumber = 0;
                Decimal.TryParse(value, out strNumber);
                XRTableCell tablecell = sender as XRTableCell;
                // - 10% discount
                strNumber = strNumber * (decimal)1.1;
                tablecell.Text = strNumber.ToString("n2");
            }
            catch (Exception ex)
            {
            }
        }
    }
}