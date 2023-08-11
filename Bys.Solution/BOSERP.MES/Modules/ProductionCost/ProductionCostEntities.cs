using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.ProductionCost
{
    class ProductionCostEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets ingredient cost item list
        /// </summary>
        //public BOSList<MMProductionCostIngredientCostsInfo> ProductionCostIngredientCostList { get; set; }
        public BOSList<MMProductionCostIngredientCostsInfo> ProductionCostIngredientCostListPhoi { get; set; }
        public BOSList<MMProductionCostIngredientCostSCsInfo> ProductionCostIngredientCostListSC { get; set; }
        public BOSList<MMProductionCostIngredientCostTCsInfo> ProductionCostIngredientCostListTC { get; set; }
        public BOSList<MMProductionCostIngredientCostLRsInfo> ProductionCostIngredientCostListLR { get; set; }
        public BOSList<MMProductionCostIngredientCostSonsInfo> ProductionCostIngredientCostListSon { get; set; }
        public BOSList<MMProductionCostIngredientCostDGsInfo> ProductionCostIngredientCostListDG { get; set; }

        public BOSList<MMProductionCostIngredientCostDDsInfo> ProductionCostIngredientCostListDDPhoi { get; set; }
        public BOSList<MMProductionCostIngredientCostDDSCsInfo> ProductionCostIngredientCostListDDSC { get; set; }
        public BOSList<MMProductionCostIngredientCostDDTCsInfo> ProductionCostIngredientCostListDDTC { get; set; }
        public BOSList<MMProductionCostIngredientCostDDLRsInfo> ProductionCostIngredientCostListDDLR { get; set; }
        public BOSList<MMProductionCostIngredientCostDDSonsInfo> ProductionCostIngredientCostListDDSon { get; set; }
        public BOSList<MMProductionCostIngredientCostDDDGsInfo> ProductionCostIngredientCostListDDDG { get; set; }
        /// <summary>
        /// Gets or sets directlabor cost item list
        /// </summary>
        public BOSList<MMProductionCostDirectLaborCostsInfo> ProductionCostDirectLaborCostList { get; set; }

        /// <summary>
        /// Gets or sets product cost item list
        /// </summary>
        public BOSList<MMProductionCostItemsInfo> ProductionCostItemList { get; set; }

        public BOSList<MMProductionCostOtherFeesInfo> ProductionCostOtherFeesList { get; set; }

        //public BOSList<MMProductPricesInfo> ProductPriceList { get; set; }
        //public BOSList<MMProductPriceIncompletesInfo> ProductPriceIncompletesList { get; set; }

        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor622 { get; set; }
        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor627 { get; set; }
        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor627A { get; set; }
        public BOSList<MMProductionCostOverallsInfo> OverallProductionCostListFor6279 { get; set; }

        #endregion

        #region Constructor
        public ProductionCostEntities()
            : base()
        {
            ProductionCostItemList = new BOSList<MMProductionCostItemsInfo>();
            ProductionCostDirectLaborCostList = new BOSList<MMProductionCostDirectLaborCostsInfo>();

            ProductionCostIngredientCostListPhoi = new BOSList<MMProductionCostIngredientCostsInfo>();
            ProductionCostIngredientCostListSC = new BOSList<MMProductionCostIngredientCostSCsInfo>();
            ProductionCostIngredientCostListTC = new BOSList<MMProductionCostIngredientCostTCsInfo>();
            ProductionCostIngredientCostListLR = new BOSList<MMProductionCostIngredientCostLRsInfo>();
            ProductionCostIngredientCostListSon = new BOSList<MMProductionCostIngredientCostSonsInfo>();
            ProductionCostIngredientCostListDG = new BOSList<MMProductionCostIngredientCostDGsInfo>();

            ProductionCostIngredientCostListDDPhoi = new BOSList<MMProductionCostIngredientCostDDsInfo>();
            ProductionCostIngredientCostListDDSC = new BOSList<MMProductionCostIngredientCostDDSCsInfo>();
            ProductionCostIngredientCostListDDTC = new BOSList<MMProductionCostIngredientCostDDTCsInfo>();
            ProductionCostIngredientCostListDDLR = new BOSList<MMProductionCostIngredientCostDDLRsInfo>();
            ProductionCostIngredientCostListDDSon = new BOSList<MMProductionCostIngredientCostDDSonsInfo>();
            ProductionCostIngredientCostListDDDG = new BOSList<MMProductionCostIngredientCostDDDGsInfo>();

            OverallProductionCostListFor622 = new BOSList<MMProductionCostOverallsInfo>();
            OverallProductionCostListFor627 = new BOSList<MMProductionCostOverallsInfo>();
            OverallProductionCostListFor627A = new BOSList<MMProductionCostOverallsInfo>();
            OverallProductionCostListFor6279 = new BOSList<MMProductionCostOverallsInfo>();
            ProductionCostOtherFeesList = new BOSList<MMProductionCostOtherFeesInfo>();
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
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostSCsTableName, new MMProductionCostIngredientCostSCsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostTCsTableName, new MMProductionCostIngredientCostTCsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostLRsTableName, new MMProductionCostIngredientCostLRsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostSonsTableName, new MMProductionCostIngredientCostSonsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDGsTableName, new MMProductionCostIngredientCostDGsInfo());

            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDsTableName, new MMProductionCostIngredientCostDDsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDSCsTableName, new MMProductionCostIngredientCostDDSCsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDTCsTableName, new MMProductionCostIngredientCostDDTCsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDLRsTableName, new MMProductionCostIngredientCostDDLRsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDSonsTableName, new MMProductionCostIngredientCostDDSonsInfo());
            ModuleObjects.Add(TableName.MMProductionCostIngredientCostDDDGsTableName, new MMProductionCostIngredientCostDDDGsInfo());

            ModuleObjects.Add(TableName.MMProductionCostDirectLaborCostsTableName, new MMProductionCostDirectLaborCostsInfo());
            ModuleObjects.Add(TableName.MMProductionCostItemsTableName, new MMProductionCostItemsInfo());
            ModuleObjects.Add(TableName.MMProductionCostOtherFeesTableName, new MMProductionCostOtherFeesInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductionCostIngredientCostListPhoi.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostsTableName,
                                          BOSList<MMProductionCostIngredientCostsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListPhoi.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListSC.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostSCsTableName,
                                          BOSList<MMProductionCostIngredientCostSCsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListSC.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListTC.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostTCsTableName,
                                          BOSList<MMProductionCostIngredientCostTCsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListTC.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListLR.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostLRsTableName,
                                          BOSList<MMProductionCostIngredientCostLRsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListLR.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListSon.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostSonsTableName,
                                          BOSList<MMProductionCostIngredientCostSonsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListSon.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDG.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDGsTableName,
                                          BOSList<MMProductionCostIngredientCostDGsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDG.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDPhoi.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDsTableName,
                                          BOSList<MMProductionCostIngredientCostDDsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDPhoi.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDSC.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDSCsTableName,
                                          BOSList<MMProductionCostIngredientCostDDSCsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDSC.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDTC.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDTCsTableName,
                                          BOSList<MMProductionCostIngredientCostDDTCsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDTC.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDLR.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDLRsTableName,
                                          BOSList<MMProductionCostIngredientCostDDLRsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDLR.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDSon.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDSonsTableName,
                                          BOSList<MMProductionCostIngredientCostDDSonsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDSon.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostIngredientCostListDDDG.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostIngredientCostDDDGsTableName,
                                          BOSList<MMProductionCostIngredientCostDDDGsInfo>.cstRelationForeign);
            ProductionCostIngredientCostListDDDG.ItemTableForeignKey = "FK_MMProductionCostID";

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

            OverallProductionCostListFor627A.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostOverallsTableName,
                                          BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            OverallProductionCostListFor627A.ItemTableForeignKey = "FK_MMProductionCostID";

            OverallProductionCostListFor6279.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostOverallsTableName,
                                          BOSList<MMProductionCostOverallsInfo>.cstRelationForeign);
            OverallProductionCostListFor6279.ItemTableForeignKey = "FK_MMProductionCostID";

            ProductionCostOtherFeesList.InitBOSList(
                                          this,
                                          TableName.MMProductionCostsTableName,
                                          TableName.MMProductionCostOtherFeesTableName,
                                          BOSList<MMProductionCostOtherFeesInfo>.cstRelationForeign);
            ProductionCostOtherFeesList.ItemTableForeignKey = "FK_MMProductionCostID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductionCostIngredientCostListPhoi.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCosts");
            ProductionCostIngredientCostListSC.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCostsSC");
            ProductionCostIngredientCostListTC.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCostsTC");
            ProductionCostIngredientCostListLR.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCostsLR");
            ProductionCostIngredientCostListSon.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCostsSon");
            ProductionCostIngredientCostListDG.InitBOSListGridControl("fld_dgcMMProductionCostIngredientCostsDG");

            ProductionCostIngredientCostListDDPhoi.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesPhoi");
            ProductionCostIngredientCostListDDSC.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesSC");
            ProductionCostIngredientCostListDDTC.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesTC");
            ProductionCostIngredientCostListDDLR.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesLR");
            ProductionCostIngredientCostListDDSon.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesSon");
            ProductionCostIngredientCostListDDDG.InitBOSListGridControl("fld_dgcMMProductionCostIngredientIncompletesDG");

            ProductionCostDirectLaborCostList.InitBOSListGridControl();
            ProductionCostItemList.InitBOSListGridControl();
            OverallProductionCostListFor622.InitBOSListGridControl("fld_dgcMMProductionCostOveralls622");
            OverallProductionCostListFor627.InitBOSListGridControl("fld_dgcMMProductionCostOveralls627");
            OverallProductionCostListFor627A.InitBOSListGridControl("fld_dgcMMProductionCostOveralls627A");
            OverallProductionCostListFor6279.InitBOSListGridControl("fld_dgcMMProductionCostOveralls6279");
            ProductionCostOtherFeesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMProductionCostsInfo objProductionCostsInfo = (MMProductionCostsInfo)MainObject;
            objProductionCostsInfo.MMProductionCostStatus = MMProductionCostStatus.New.ToString();
            objProductionCostsInfo.MMProductionCostType = ProductionCostType.ProductionCost.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductionCostIngredientCostListPhoi.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListSC.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListTC.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListLR.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListSon.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDG.SetDefaultListAndRefreshGridControl();
                ProductionCostDirectLaborCostList.SetDefaultListAndRefreshGridControl();
                ProductionCostItemList.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor622.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor627.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor627A.SetDefaultListAndRefreshGridControl();
                OverallProductionCostListFor6279.SetDefaultListAndRefreshGridControl();
                ProductionCostOtherFeesList.SetDefaultListAndRefreshGridControl();

                ProductionCostIngredientCostListDDPhoi.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDDSC.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDDTC.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDDLR.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDDSon.SetDefaultListAndRefreshGridControl();
                ProductionCostIngredientCostListDDDG.SetDefaultListAndRefreshGridControl();

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
            ProductionCostIngredientCostListPhoi.Invalidate(iObjectID);
            ProductionCostIngredientCostListSC.Invalidate(iObjectID);
            ProductionCostIngredientCostListTC.Invalidate(iObjectID);
            ProductionCostIngredientCostListLR.Invalidate(iObjectID);
            ProductionCostIngredientCostListSon.Invalidate(iObjectID);
            ProductionCostIngredientCostListDG.Invalidate(iObjectID);
            ProductionCostDirectLaborCostList.Invalidate(iObjectID);

            ProductionCostIngredientCostListDDPhoi.Invalidate(iObjectID);
            ProductionCostIngredientCostListDDSC.Invalidate(iObjectID);
            ProductionCostIngredientCostListDDTC.Invalidate(iObjectID);
            ProductionCostIngredientCostListDDLR.Invalidate(iObjectID);
            ProductionCostIngredientCostListDDSon.Invalidate(iObjectID);
            ProductionCostIngredientCostListDDDG.Invalidate(iObjectID);

            ProductionCostItemList.Invalidate(iObjectID);
            MMProductionCostOverallsController overallProductionCostController = new MMProductionCostOverallsController();
            List<MMProductionCostOverallsInfo> dataSource;
            List<MMProductionCostOverallsInfo> CPNCTTList = new List<MMProductionCostOverallsInfo>();
            List<MMProductionCostOverallsInfo> CPCList = new List<MMProductionCostOverallsInfo>();
            string[] ChiPhiNhanCongTrucTiepList = new string[] { "6224", "6225", "6226", "6227", "6228", "6229" };
            foreach (string item in ChiPhiNhanCongTrucTiepList)
            {
                dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, item);
                CPNCTTList.AddRange(dataSource);
            }
            OverallProductionCostListFor622.Invalidate(CPNCTTList);
            string[] ChiPhiChungList = new string[] { "6273", "6274", "6275", "6276", "6277", "6278" };
            foreach (string item in ChiPhiChungList)
            {
                dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, item);
                CPCList.AddRange(dataSource);
            }
            OverallProductionCostListFor627.Invalidate(CPCList);
            dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiChungNhaMay627A);
            OverallProductionCostListFor627A.Invalidate(dataSource);
            dataSource = overallProductionCostController.GetOverallProductionCostsByProductionCostIDAndOverallProductionCostCostType(iObjectID, ProductionCostAccounts.ChiPhiChungNhaMay6279);
            OverallProductionCostListFor6279.Invalidate(dataSource);
            UpdateOverallProductionCostsAppropriationCost();

            ProductionCostOtherFeesList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            //ProductionCostItemList.SaveItemObjects();
            //ProductionCostIngredientCostListPhoi.SaveItemObjects();
            //ProductionCostIngredientCostListSC.SaveItemObjects();
            //ProductionCostIngredientCostListTC.SaveItemObjects();
            //ProductionCostIngredientCostListLR.SaveItemObjects();
            //ProductionCostIngredientCostListSon.SaveItemObjects();
            //ProductionCostIngredientCostListDG.SaveItemObjects();
            //ProductionCostDirectLaborCostList.SaveItemObjects();
            OverallProductionCostListFor622.SaveItemObjects();
            OverallProductionCostListFor627.SaveItemObjects();
            OverallProductionCostListFor627A.SaveItemObjects();
            OverallProductionCostListFor6279.SaveItemObjects();
            ProductionCostOtherFeesList.SaveItemObjects();
        }
        #endregion   

        private void UpdateOverallProductionCostsAppropriationCost()
        {
            MMProductionCostsInfo mainObject = MainObject as MMProductionCostsInfo;
            mainObject.DirectLaborCostFor622AppropriationAmount = OverallProductionCostListFor622.Sum(item => item.MMProductionCostOverallTotalCost);
            mainObject.DirectLaborCostFor622TotalAmount = mainObject.DirectLaborCostFor622AppropriationAmount;

            mainObject.OverallProductionCostFor627AppropriationAmount = OverallProductionCostListFor627.Sum(item => item.MMProductionCostOverallTotalCost);
            mainObject.OverallProductionCostFor627TotalAmount = mainObject.OverallProductionCostFor627AppropriationAmount;

            mainObject.OverallProductionCostFor627AAppropriationAmount = OverallProductionCostListFor627A.Sum(item => item.MMProductionCostOverallTotalCost);
            mainObject.OverallProductionCostFor627ATotalAmount = mainObject.OverallProductionCostFor627AAppropriationAmount;

            mainObject.OverallProductionCostFor6279AppropriationAmount = OverallProductionCostListFor6279.Sum(item => item.MMProductionCostOverallTotalCost);
            mainObject.OverallProductionCostFor6279TotalAmount = mainObject.OverallProductionCostFor6279AppropriationAmount;
            UpdateMainObjectBindingSource();
        }
    }
}
