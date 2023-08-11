using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RP_GetTotalShipmentSO : BaseReport
    {
        public RP_GetTotalShipmentSO()
        {
            InitializeComponent();
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
