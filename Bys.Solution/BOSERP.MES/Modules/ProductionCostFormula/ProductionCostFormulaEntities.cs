using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.ProductionCostFormula
{
    public class ProductionCostFormulaEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMProductionCostFormulaDetailsInfo> MMProductionCostFormulaDetailsList { get; set; }
        public BOSList<MMProductionCostFormulaOperationsInfo> MMProductionCostFormulaOperationsList { get; set; }
        public BOSList<MMProductionCostFormulaOperationItemsInfo> MMProductionCostFormulaOperationItemsList { get; set; }
        public BOSList<MMProductionCostFormulaProductsInfo> MMProductionCostFormulaProductsList { get; set; }
        #endregion

        #region Constructor
        public ProductionCostFormulaEntities()
            : base()
        {
            MMProductionCostFormulaDetailsList = new BOSList<MMProductionCostFormulaDetailsInfo>();
            MMProductionCostFormulaOperationsList = new BOSList<MMProductionCostFormulaOperationsInfo>();
            MMProductionCostFormulaOperationItemsList = new BOSList<MMProductionCostFormulaOperationItemsInfo>();
            MMProductionCostFormulaProductsList = new BOSList<MMProductionCostFormulaProductsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProductionCostFormulasInfo();
            SearchObject = new MMProductionCostFormulasInfo();
        }

        public override void InitModuleObjectList()
        {
            MMProductionCostFormulaDetailsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostFormulasTableName,
                                              TableName.MMProductionCostFormulaDetailsTableName,
                                              BOSList<MMProductionCostFormulaDetailsInfo>.cstRelationForeign);
            MMProductionCostFormulaDetailsList.ItemTableForeignKey = "FK_MMProductionCostFormulaID";

            MMProductionCostFormulaOperationsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostFormulasTableName,
                                              TableName.MMProductionCostFormulaOperationsTableName,
                                              BOSList<MMProductionCostFormulaOperationsInfo>.cstRelationForeign);
            MMProductionCostFormulaOperationsList.ItemTableForeignKey = "FK_MMProductionCostFormulaID";

            MMProductionCostFormulaOperationItemsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostFormulasTableName,
                                              TableName.MMProductionCostFormulaOperationItemsTableName,
                                              BOSList<MMProductionCostFormulaOperationItemsInfo>.cstRelationForeign);
            MMProductionCostFormulaOperationItemsList.ItemTableForeignKey = "FK_MMProductionCostFormulaID";

            MMProductionCostFormulaProductsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostFormulasTableName,
                                              TableName.MMProductionCostFormulaProductsTableName,
                                              BOSList<MMProductionCostFormulaProductsInfo>.cstRelationForeign);
            MMProductionCostFormulaProductsList.ItemTableForeignKey = "FK_MMProductionCostFormulaID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            MMProductionCostFormulaDetailsList.InitBOSListGridControl();
            MMProductionCostFormulaOperationsList.InitBOSListGridControl();
            MMProductionCostFormulaOperationItemsList.InitBOSListGridControl();
            MMProductionCostFormulaProductsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MMProductionCostFormulaDetailsList.SetDefaultListAndRefreshGridControl();
                MMProductionCostFormulaOperationsList.SetDefaultListAndRefreshGridControl();
                MMProductionCostFormulaOperationItemsList.SetDefaultListAndRefreshGridControl();
                MMProductionCostFormulaProductsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMProductionCostFormulaDetailsList.Invalidate(iObjectID);
            MMProductionCostFormulaOperationsList.Invalidate(iObjectID);
            MMProductionCostFormulaOperationItemsList.Invalidate(iObjectID);
            MMProductionCostFormulaProductsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            MMProductionCostFormulaDetailsList.SaveItemObjects();
            MMProductionCostFormulaOperationsList.SaveItemObjects();
            MMProductionCostFormulaOperationItemsList.SaveItemObjects();
            MMProductionCostFormulaProductsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMProductionCostFormulasInfo productionCostFormulasInfo = (MMProductionCostFormulasInfo)MainObject;
            productionCostFormulasInfo.MMProductionCostFormulaDate = DateTime.Now;
            productionCostFormulasInfo.MMProductionCostFormulaFromDate = BOSUtil.GetMonthBeginDate();
            productionCostFormulasInfo.MMProductionCostFormulaToDate = BOSUtil.GetMonthEndDate();

            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProductionCostFormulaDetailsTableName, new MMProductionCostFormulaDetailsInfo());
            ModuleObjects.Add(TableName.MMProductionCostFormulaOperationsTableName, new MMProductionCostFormulaOperationsInfo());
            ModuleObjects.Add(TableName.MMProductionCostFormulaProductsTableName, new MMProductionCostFormulaProductsInfo());
            ModuleObjects.Add(TableName.MMProductionCostFormulaOperationItemsTableName, new MMProductionCostFormulaOperationItemsInfo());
        }
    }
}
