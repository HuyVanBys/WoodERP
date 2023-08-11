using System;

namespace BOSERP.Modules.BudgetTracking.UI
{
    /// <summary>
    /// Summary description for DMBUT100
    /// </summary>
    public partial class DMBUT100 : BOSERPScreen
    {

        public DMBUT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            BudgetTrackingEntities entity = (BudgetTrackingEntities)((BudgetTrackingModule)Module).CurrentModuleEntity;
            ACBudgetTrackingsInfo objBudgetTrackingsInfo = (ACBudgetTrackingsInfo)entity.MainObject;
            //((BudgetTrackingModule)Module).GetData(fld_dteACBalanceAmountArisingFromDate.DateTime, fld_dteACBalanceAmountArisingToDate.DateTime);
            ((BudgetTrackingModule)Module).GetData(objBudgetTrackingsInfo.FK_BRBranchID, fld_dteACBudgetTrackingFromYear.DateTime, fld_dteACBudgetTrackingToMonth.DateTime);
        }
    }
}
