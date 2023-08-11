using System;

namespace BOSERP.Modules.AccountingSheet.UI
{
    /// <summary>
    /// Summary description for DMBS100
    /// </summary>
    public partial class DMBS100 : BOSERPScreen
    {

        public DMBS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            //((AccountingSheetModule)Module).GetData2(fld_dteACAccountingSheetFromDate.DateTime, fld_dteACAccountingSheetToDate.DateTime);
            ((AccountingSheetModule)Module).GetAccountingSheetDetails();
        }
    }
}
