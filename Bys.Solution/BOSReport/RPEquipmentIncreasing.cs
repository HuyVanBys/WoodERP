using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPEquipmentIncreasing : BaseReport
    {
        public GECurrenciesInfo objCurrenciesInfo { get; set; }

        public RPEquipmentIncreasing(int currencyID)
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            objCurrenciesInfo = objCurrenciesController.GetObjectByID(currencyID) as GECurrenciesInfo;
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

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FomatPrice(sender);
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            FomatPrice(sender);
        }
    }
}
