using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.RevenueBudget
{
    public class RevenueBudgetEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACRevenueBudgetDetailsInfo> ACRevenueBudgetDetailsList { get; set; }
        #endregion

        #region Constructor
        public RevenueBudgetEntities()
            : base()
        {
            ACRevenueBudgetDetailsList = new BOSList<ACRevenueBudgetDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACRevenueBudgetsInfo();
            SearchObject = new ACRevenueBudgetsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACRevenueBudgetDetailsList.InitBOSList(
                                              this,
                                              TableName.ACRevenueBudgetsTableName,
                                              TableName.ACRevenueBudgetDetailsTableName,
                                              BOSList<ACRevenueBudgetDetailsInfo>.cstRelationForeign);
            ACRevenueBudgetDetailsList.ItemTableForeignKey = "FK_ACRevenueBudgetID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ACRevenueBudgetDetailsList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACRevenueBudgetDetailsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACRevenueBudgetDetailsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ACRevenueBudgetDetailsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACRevenueBudgetsInfo revenueBudget = (ACRevenueBudgetsInfo)MainObject;
            revenueBudget.ACRevenueBudgetDate = DateTime.Now;
            revenueBudget.ACRevenueBudgetStatus = RevenueBudgetStatus.New.ToString();
            revenueBudget.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            revenueBudget.ACRevenueBudgetExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();

        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACRevenueBudgetDetailsTableName, new ACRevenueBudgetDetailsInfo());
        }
    }
}
