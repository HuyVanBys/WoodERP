using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPAdvanceRefundProposal : BaseReport
    {
        public GECurrenciesInfo objCurrenciesInfo { get; set; }
        public RPAdvanceRefundProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void RPAdvanceRefundProposal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            objCurrenciesInfo = objCurrenciesController.GetObjectByID(((HRAdvanceRefundsInfo)bsAdvanceRefundsInfo.DataSource).FK_GECurrencyID) as GECurrenciesInfo;
            if (objCurrenciesInfo != null)
            {
                if (objCurrenciesInfo.GECurrencyNo == "VND")
                {
                    xrLabel12.Text = string.Format(xrLabel12.Text, "đồng");
                    xrLabel61.Text = "đồng (1)";
                }
                else
                {
                    xrLabel12.Text = string.Format(xrLabel12.Text, objCurrenciesInfo.GECurrencyNo);
                    xrLabel61.Text = objCurrenciesInfo.GECurrencyNo + " (1)";
                }
            }
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FomatPrice(sender);
        }

        private void FomatPrice(object sender)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            if (objCurrenciesInfo != null)
            {
                if (objCurrenciesInfo.GECurrencyNo == "VND")
                {
                    Math.Round(strNumber, 0, MidpointRounding.AwayFromZero);
                    tableCell.Text = strNumber.ToString("n0");
                }
                else
                    tableCell.Text = strNumber.ToString("n2");
            }
            else
                tableCell.Text = strNumber.ToString("n2");
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FomatPrice(sender);
        }

        private void xr_lblPaymentProposalTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            if (objCurrenciesInfo != null)
            {
                if (objCurrenciesInfo.GECurrencyNo == "VND")
                {
                    label.Text = strNumber.ToString("n0");
                }
                else
                    label.Text = strNumber.ToString("n2");
            }
            else
                label.Text = strNumber.ToString("n2");
        }

        private void xr_lblAdvanceRefundTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            decimal strNumber = 0;
            Decimal.TryParse(label.Text, out strNumber);
            if (objCurrenciesInfo != null)
            {
                if (objCurrenciesInfo.GECurrencyNo == "VND")
                {
                    label.Text = strNumber.ToString("n0");
                }
                else
                    label.Text = strNumber.ToString("n2");
            }
            else
                label.Text = strNumber.ToString("n2");
        }
    }
}
