using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.CostBudget
{
    public class CostBudgetEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACCostBudgetDetailsInfo> ACCostBudgetDetailsList { get; set; }
        #endregion

        #region Constructor
        public CostBudgetEntities()
            : base()
        {
            ACCostBudgetDetailsList = new BOSList<ACCostBudgetDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACCostBudgetsInfo();
            SearchObject = new ACCostBudgetsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACCostBudgetDetailsList.InitBOSList(
                                              this,
                                              TableName.ACCostBudgetsTableName,
                                              TableName.ACCostBudgetDetailsTableName,
                                              BOSList<ACCostBudgetDetailsInfo>.cstRelationForeign);
            ACCostBudgetDetailsList.ItemTableForeignKey = "FK_ACCostBudgetID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ACCostBudgetDetailsList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACCostBudgetDetailsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACCostBudgetDetailsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ACCostBudgetDetailsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACCostBudgetsInfo revenueBudget = (ACCostBudgetsInfo)MainObject;
            revenueBudget.ACCostBudgetDate = DateTime.Now;
            revenueBudget.ACCostBudgetFromDate = DateTime.Now;
            revenueBudget.ACCostBudgetToDate = DateTime.Now;
            revenueBudget.ACCostBudgetStatus = CostBudgetStatus.New.ToString();
            revenueBudget.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            revenueBudget.ACCostBudgetExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACCostBudgetDetailsTableName, new ACCostBudgetDetailsInfo());
        }
    }
}
