using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.ProductionCostWood
{
    class ProductionCostWoodEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets ingredient cost item list
        /// </summary>
        public BOSList<MMProductionCostIngredientCostsInfo> ProductionCostIngredientCostList { get; set; }

        /// <summary>
        /// Gets or sets directlabor cost item list
        /// </summary>
        public BOSList<MMProductionCostDirectLaborCostsInfo> ProductionCostDirectLaborCostList { get; set; }

        /// <summary>
        /// Gets or sets product cost item list
        /// </summary>
        public BOSList<MMProductionCostItemsInfo> ProductionCostItemList { get; set; }

        public BOSList<MMProductPricesInfo> ProductPriceList { get; set; }
        public BOSList<MMProductPriceIncompletesInfo> ProductPriceIncompletesList { get; set; }

        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor622 { get; set; }
        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor627 { get; set; }
        //public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor6278 { get; set; }
        //public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor6279 { get; set; }

        #endregion

        #region Constructor
        public ProductionCostWoodEntities()
            : base()
        {
            ProductionCostItemList = new BOSList<MMProductionCostItemsInfo>();
            ProductionCostDirectLaborCostList = new BOSList<MMProductionCostDirectLaborCostsInfo>();
            ProductionCostIngredientCostList = new BOSList<MMProductionCostIngredientCostsInfo>();

            ProductPriceList = new BOSList<MMProductPricesInfo>();
            ProductPriceIncompletesList = new BOSList<MMProductPriceIncompletesInfo>();
            OverallProductionCostListFor622 = new BOSList<MMProductionCostOverallsInfo>();
            OverallProductionCostListFor627 = new BOSList<MMProductionCostOverallsInfo>();
            //OverallProductionCostListFor6278 = new BOSList<MMProductionCostOverallsInfo>();
            //OverallProductionCostListFor6279 = new BOSList<MMProductionCostOverallsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProductionCostsInfo();
            SearchObject = new MMProductionCostsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostsTableName, new MMProductionCostIngredientCostsInfo());
            ModuleObjects.Add(TableName.MMProductionCostDirectLaborCostsTableName, new MMProductionCostDirectLaborCostsInfo());
            ModuleObjects.Add(TableName.MMProductionCostItemsTableName, new MMProductionCostItemsInfo());
            ModuleObjects.Add(TableName.MMProductPricesTableName, new MMProductPricesInfo());
            ModuleObjects.Add(TableName.MMProductPriceIncompletesTableName, new MMProductPriceIncompletesInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductionCostIngredientCostList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostsTableName,
                                          BOSList<MMProductionCostIngredientCostsInfo>.cstRelationForeign);
            ProductionCostIngredientCostList.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostDirectLaborCostList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostDirectLaborCostsTableName,
                                          BOSList<MMProductionCostDirectLaborCostsInfo>.cstRelationForeign);
            ProductionCostDirectLaborCostList.ItemTableForeignKey = "FK_MMProductionCostID";
            ProductionCostItemList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostItemsTableName,
                                          BOSList<MMProductionCostItemsInfo>.cstRelationForeign);
            ProductionCostItemList.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductPriceList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductPricesTableName,
                                          BOSList<MMProductPricesInfo>.cstRelationForeign);
            ProductPriceList.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductPriceIncompletesList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductPriceIncompletesTableName,
                                          BOSList<MMProductPriceIncompletesInfo>.cstRelationForeign);
            ProductPriceIncompletesList.ItemTableForeignKey = "FK_MMProductionCostID";

            OverallProductionCostListFor622.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostOverallsTableName,
                                          BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            OverallProductionCostListFor622.ItemTableForeignKey = "FK_MMProductionCostID";

            OverallProductionCostListFor627.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostOverallsTableName,
                                          BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            OverallProductionCostListFor627.ItemTableForeignKey = "FK_MMProductionCostID";

            //OverallProductionCostListFor6278.InitBOSList(
            //                              this,
            //                              TableName.MMProductionCostsTableName,
            //                              TableName.MMProductionCostOverallsTableName,
            //                              BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            //OverallProductionCostListFor6278.ItemTableForeignKey = "FK_MMProductionCostID";

            //OverallProductionCostListFor6279.InitBOSList(
            //                              this,
            //                              TableName.MMProductionCostsTableName,
            //                              TableName.MMProductionCostOverallsTableName,
            //                              BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            //OverallProductionCostListFor6279.ItemTableForeignKey = "FK_MMProductionCostID";

        }

        public override void InitGridControlInBOSList()
        {
            ProductionCostIngredientCostList.InitBOSListGridControl();
            ProductionCostDirectLaborCostList.InitBOSListGridControl();
            ProductionCostItemList.InitBOSListGridControl();
            ProductPriceList.InitBOSListGridControl();
            ProductPriceIncompletesList.InitBOSListGridControl();
            OverallProductionCostListFor622.InitBOSListGridControl("fld_dgcMMProductionCostOveralls622");
            OverallProductionCostListFor627.InitBOSListGridControl("fld_dgcMMProductionCostOveralls627");
            //OverallProductionCostListFor6278.InitBOSListGridControl("fld_dgcMMProductionCostOveralls6278");
            //OverallProductionCostListFor6279.InitBOSListGridControl("fld_dgcMMProductionCostOveralls6279");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)MainObject;
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();
            objProductionCostsInfo.MMProductionCostType = ProductionCostType.ProductionCostWood.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductionCostIngredientCostList.SetDefaultListAndRefreshGridControl();
                ProductionCostDirectLaborCostList.SetDefaultListAndRefreshGridControl();
                ProductionCostItemList.SetDefaultListAndRefreshGridControl();
                ProductPriceList.SetDefaultListAndRefreshGridControl();
                ProductPriceIncompletesList.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor622.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor627.SetDefaultListAndRefreshGridControl();
                //OverallProductionCostListFor6278.SetDefaultListAndRefreshGridControl();
                //OverallProductionCostListFor6279.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects ,Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProductionCostIngredientCostList.Invalidate(iObjectID);
            ProductionCostDirectLaborCostList.Invalidate(iObjectID);
            ProductionCostItemList.Invalidate(iObjectID);
            ProductPriceList.Invalidate(iObjectID);
            ProductPriceIncompletesList.Invalidate(iObjectID);
            MMProductionCostOverallsController overallProductionCostController = new MMProductionCostOverallsController();
            List<MMProductionCostOverallsInfo> dataSource1 = new List<MMProductionCostOverallsInfo>();
            List<MMProductionCostOverallsInfo> dataSource2 = new List<MMProductionCostOverallsInfo>();

            List<MMProductionCostOverallsInfo> objProductionCostList = overallProductionCostController.GetAllDataProductionCostID(iObjectID);

            foreach (MMProductionCostOverallsInfo item in objProductionCostList)
            {
                if (item.MMProductionCostOverallCostTypeCombo == "6222" || item.MMProductionCostOverallCostTypeCombo == "6223")
                {
                    dataSource1.Add(item);
                }
                if (item.MMProductionCostOverallCostTypeCombo == "6271" || item.MMProductionCostOverallCostTypeCombo == "6272")
                {
                    dataSource2.Add(item);
                }
            }


            // dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiNhanCongTrucTiep);
            OverallProductionCostListFor622.Invalidate(dataSource1);
            //dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiSanXuatChung);
            OverallProductionCostListFor627.Invalidate(dataSource2);
            //dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiChungNhaMay1);
            //OverallProductionCostListFor6278.Invalidate(dataSource);
            //dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiChungNhaMay2);
            //OverallProductionCostListFor6279.Invalidate(dataSource);
            UpdateOverallProductionCostsAppropriationCost();
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            //ProductionCostIngredientCostList.SaveItemObjects();
            //ProductionCostDirectLaborCostList.SaveItemObjects();
            //ProductionCostItemList.SaveItemObjects();
            //ProductPriceList.SaveItemObjects();
            //ProductPriceIncompletesList.SaveItemObjects();
            OverallProductionCostListFor622.SaveItemObjects();
            OverallProductionCostListFor627.SaveItemObjects();
            //OverallProductionCostListFor6278.SaveItemObjects();
            //OverallProductionCostListFor6279.SaveItemObjects();
        }
        #endregion   

        private void UpdateOverallProductionCostsAppropriationCost()
        {
            MMProductionCostsInfo mainObject = MainObject as MMProductionCostsInfo;
            mainObject.DirectLaborCostFor622AppropriationAmount = OverallProductionCostListFor622.Sum(item => item.MMProductionCostOverallTotalCost);
            mainObject.OverallProductionCostFor627AppropriationAmount = OverallProductionCostListFor627.Sum(item => item.MMProductionCostOverallTotalCost);
            //mainObject.OverallProductionCostFor6278AppropriationAmount = OverallProductionCostListFor6278.Sum(item => item.MMProductionCostOverallTotalCost);
            //mainObject.OverallProductionCostFor6279AppropriationAmount = OverallProductionCostListFor6279.Sum(item => item.MMProductionCostOverallTotalCost);
        }
    }
}
