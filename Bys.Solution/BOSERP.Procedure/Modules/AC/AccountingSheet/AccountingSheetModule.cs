using BOSLib;
using System.Collections.Generic;

namespace BOSERP.Modules.AccountingSheet
{
    class AccountingSheetModule : BaseModuleERP
    {
        #region Constant
        #endregion
        #region Public properties
        private List<ACAccountsInfo> AccountList;
        #endregion

        public AccountingSheetModule()
        {
            Name = "AccountingSheet";
            CurrentModuleEntity = new AccountingSheetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public override int ActionSave()
        {
            return base.ActionSave();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            AccountingSheetEntities entity = (AccountingSheetEntities)CurrentModuleEntity;
            ACAccountingSheetsInfo mainObject = (ACAccountingSheetsInfo)entity.MainObject;
            mainObject.ACAccountingSheetFromDate = BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate());
            mainObject.ACAccountingSheetToDate = BOSApp.GetPeriodEndDate(BOSApp.GetCurrentServerDate());
        }

        public void GetAccountingSheetDetails()
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            AccountingSheetEntities entity = (AccountingSheetEntities)CurrentModuleEntity;
            ACAccountingSheetsInfo mainObject = (ACAccountingSheetsInfo)entity.MainObject;
            entity.AccountingSheetDetailsList.Clear();

            ACAccountingSheetDetailsController controller = new ACAccountingSheetDetailsController();

            List<ACAccountingSheetDetailsInfo> details = controller.GetAccountingSheetDetails(mainObject.ACAccountingSheetFromDate
                                                                                            , mainObject.ACAccountingSheetToDate
                                                                                            , mainObject.FK_BRBranchID
                                                                                            , mainObject.FK_BRBranchCentralID);

            entity.AccountingSheetDetailsList.Invalidate(details);
            entity.AccountingSheetDetailsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }
    }
}
