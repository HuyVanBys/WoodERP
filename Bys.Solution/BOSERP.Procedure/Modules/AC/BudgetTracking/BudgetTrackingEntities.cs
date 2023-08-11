using System;

namespace BOSERP.Modules.BudgetTracking
{
    class BudgetTrackingEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACBudgetTrackingItemsInfo> BudgetTrackingItemsList { get; set; }
        #endregion

        #region Constructor
        public BudgetTrackingEntities()
            : base()
        {
            BudgetTrackingItemsList = new BOSList<ACBudgetTrackingItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACBudgetTrackingsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACBudgetTrackingItems", new ACBudgetTrackingItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            BudgetTrackingItemsList.InitBOSList(
                                            this,
                                            "ACBudgetTrackings",
                                            "ACBudgetTrackingItems",
                                            BOSList<ACBudgetTrackingItemsInfo>.cstRelationForeign);
            BudgetTrackingItemsList.ItemTableForeignKey = "FK_ACBudgetTrackingID";
        }

        public override void InitGridControlInBOSList()
        {
            BudgetTrackingItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            base.SetDefaultMainObject();

            ACBudgetTrackingsInfo objBudgetTrackingsInfo = (ACBudgetTrackingsInfo)MainObject;
            objBudgetTrackingsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objBudgetTrackingsInfo.ACBudgetTrackingFromYear = BOSApp.GetCurrentServerDate();
            objBudgetTrackingsInfo.ACBudgetTrackingToMonth = BOSApp.GetCurrentServerDate();
            UpdateModuleObjectsBindingSource();
            try
            {
                BudgetTrackingItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            BudgetTrackingItemsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            BudgetTrackingItemsList.SaveItemObjects();
        }
        #endregion

        public void SaveBalanceObject()
        {
            BudgetTrackingItemsList.SaveItemObjects();
        }
    }
}
