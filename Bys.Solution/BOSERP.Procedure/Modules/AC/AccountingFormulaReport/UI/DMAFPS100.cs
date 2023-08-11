using System;

namespace BOSERP.Modules.AccountingFormulaReport.UI
{
    public partial class DMAFPS100 : BOSERPScreen
    {

        public DMAFPS100()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            ((AccountingFormulaReportModule)Module).Print(dateFrom, dateTo);
        }
        private void RP056_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            DateTime openingDateFrom = fld_dteSearchOpeningFromDate.DateTime;
            DateTime openingDateTo = fld_dteSearchOpeningToDate.DateTime;
            int branchID = fld_lkeFK_BRBranchID.EditValue != null
                            ? Convert.ToInt32(fld_lkeFK_BRBranchID.EditValue)
                            : 0;
            int branchCentralID = fld_lkeFK_BRBranchCentralID.EditValue != null
                            ? Convert.ToInt32(fld_lkeFK_BRBranchCentralID.EditValue)
                            : 0;
            ((AccountingFormulaReportModule)Module).InitDataSourceReport(dateFrom, dateTo, openingDateFrom, openingDateTo, branchID, branchCentralID);
        }
    }
}
