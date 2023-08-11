using System;

namespace BOSERP.Modules.SlimDatabase.UI
{
    /// <summary>
    /// Summary description for DMSDB100
    /// </summary>
    public partial class DMSDB100 : BOSERPScreen
    {

        public DMSDB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            int currentYear = DateTime.Now.Year;
            fld_dteFromDate.DateTime = new DateTime(currentYear - 2, 1, 1);
            fld_dteToDate.DateTime = new DateTime(currentYear - 2, 12, 31);

        }

        private void fld_btnDeleteAccountPayableData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            (this.Module as SlimDatabaseModule).DeleteAccountPayableData(fromDate, toDate);

        }

        private void fld_btnDeleteAccountReceivableData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            (this.Module as SlimDatabaseModule).DeleteAccountReceivableData(fromDate, toDate);
        }

        private void fld_btnDeleteInventoryControlData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            (this.Module as SlimDatabaseModule).DeleteInventoryControlData(fromDate, toDate);
        }

        private void fld_btnDeleteHumanResourcesData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            (this.Module as SlimDatabaseModule).DeleteHumanResourcesData(fromDate, toDate);
        }

        private void fld_btnDeleteAccountingData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            (this.Module as SlimDatabaseModule).DeleteAccountingData(fromDate, toDate);
        }
    }
}
