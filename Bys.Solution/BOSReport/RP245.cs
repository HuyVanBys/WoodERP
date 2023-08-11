using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RP245 : BaseReport
    {
        public RP245()
        {
            InitializeComponent();
        }

        private void xrTableCellQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
