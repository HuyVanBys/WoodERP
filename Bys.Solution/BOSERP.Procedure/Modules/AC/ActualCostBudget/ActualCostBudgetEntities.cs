using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.ActualCostBudget
{
    public class ActualCostBudgetEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACActualCostBudgetDetailsInfo> ACActualCostBudgetDetailsList { get; set; }
        #endregion

        #region Constructor
        public ActualCostBudgetEntities()
            : base()
        {
            ACActualCostBudgetDetailsList = new BOSList<ACActualCostBudgetDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACActualCostBudgetsInfo();
            SearchObject = new ACActualCostBudgetsInfo();
        }

        public override void InitModuleObjectList()
        {
            ACActualCostBudgetDetailsList.InitBOSList(
                                              this,
                                              TableName.ACActualCostBudgetsTableName,
                                              TableName.ACActualCostBudgetDetailsTableName,
                                              BOSList<ACActualCostBudgetDetailsInfo>.cstRelationForeign);
            ACActualCostBudgetDetailsList.ItemTableForeignKey = "FK_ACActualCostBudgetID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ACActualCostBudgetDetailsList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACActualCostBudgetDetailsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACActualCostBudgetDetailsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ACActualCostBudgetDetailsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACActualCostBudgetsInfo revenueBudget = (ACActualCostBudgetsInfo)MainObject;
            revenueBudget.ACActualCostBudgetDate = DateTime.Now;
            revenueBudget.ACActualCostBudgetStatus = ActualCostBudgetStatus.New.ToString();
            revenueBudget.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            revenueBudget.ACActualCostBudgetExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();

        }

        public override void DuplicateModuleObjectList()
        {
            ACActualCostBudgetDetailsList.Duplicate();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACActualCostBudgetDetailsTableName, new ACActualCostBudgetDetailsInfo());
        }
    }
}
