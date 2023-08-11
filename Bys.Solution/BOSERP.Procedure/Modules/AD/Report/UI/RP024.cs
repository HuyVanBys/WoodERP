using System;

namespace BOSERP.Modules.Report
{
    public partial class RP024 : guiReportViewer
    {
        public RP024()
        {
            InitializeComponent();
        }

        public override bool FlagSetDockFill
        {
            get
            {
                base.FlagSetDockFill = true;
                return base.FlagSetDockFill;
            }
            set
            {
                base.FlagSetDockFill = value;
            }
        }

        private void RP024_Load(object sender, EventArgs e)
        {
            InitializeReport(BOSCommon.Constants.Report.InventoryStatisticsReportName);
        }
    }
}
