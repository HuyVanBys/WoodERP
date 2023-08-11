using BOSERP;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPInventoryStockCountVM : BaseReport
    {
        /// <summary>
        /// Inventory Stock Count
        /// </summary>
        public RPInventoryStockCountVM()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTabelCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            if (tableCell == null)
                return;
            decimal value = 0;
            decimal.TryParse(tableCell.Text, out value);
            if (value == 0)
            {
                tableCell.Text = "-";
                tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
        }
    }
}
