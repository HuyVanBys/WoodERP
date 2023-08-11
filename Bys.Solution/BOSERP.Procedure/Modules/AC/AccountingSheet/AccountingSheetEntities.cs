using System;

namespace BOSERP.Modules.AccountingSheet
{
    class AccountingSheetEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACAccountingSheetDetailsInfo> AccountingSheetDetailsList { get; set; }

        #endregion

        #region Constructor
        public AccountingSheetEntities()
            : base()
        {
            AccountingSheetDetailsList = new BOSList<ACAccountingSheetDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACAccountingSheetsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACAccountingSheetDetails", new ACAccountingSheetDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            AccountingSheetDetailsList.InitBOSList(
                                            this,
                                            "ACAccountingSheets",
                                            "ACAccountingSheetDetails",
                                            BOSList<ACAccountingSheetDetailsInfo>.cstRelationForeign);
            AccountingSheetDetailsList.ItemTableForeignKey = "FK_ACAccountingSheetID";
        }

        public override void InitGridControlInBOSList()
        {
            AccountingSheetDetailsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AccountingSheetDetailsList.SetDefaultListAndRefreshGridControl();
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
            AccountingSheetDetailsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            AccountingSheetDetailsList.SaveItemObjects();
        }
        #endregion
    }
}
