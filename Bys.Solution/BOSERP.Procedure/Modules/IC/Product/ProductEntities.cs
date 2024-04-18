using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BOSERP.Modules.Product
{
    public class ProductEntities : ERPModuleEntities
    {
        #region Declare Constant
        public const String strICProductsObjectName = "ICProducts";

        public const String strICProductAlternativesObjectName = "ICProductAlternatives";
        public const String strICProductComponentsObjectName = "ICProductComponents";
        public const String strICProductAttributesObjectName = "ICProductAttributes";
        public const String strICProductUnitsObjectName = "ICProductUnits";
        public const String strMaterial = "Material";
        public const String strAsset = "Asset";
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSList<ICProductBranchPricesInfo> ProductBranchPriceList { get; set; }

        public BOSList<ICProductItemsInfo> ICProductItemsList { get; set; }

        public BOSList<ICProductBranchPricesInfo> ProductPurchasePriceList { get; set; }

        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSList<ICProductComponentsInfo> ICProductComponentsList { get; set; }

        public BOSList<ICProductPricesInfo> ICProductPricesList { get; set; }

        public ICProductUnitsInfo ICProductUnitsObject { get; set; }

        public BOSList<ICProductUnitsInfo> ICProductUnitsList { get; set; }

        public BOSList<MMBatchProductItemsInfo> MMBatchProductItemList { get; set; }

        public BOSList<ICProductProfilesInfo> ICProductProfilesList { get; set; }

        public BOSList<ICProductSuppliersInfo> ICProductSuppliersList { get; set; }

        public BOSList<ICProductWorkItemsInfo> ICProductWorkItemList { get; set; }

        public BOSList<ICProductWorkItemsInfo> ICProductWorkItemMaterialList { get; set; }

        public BOSList<ICProductTasksInfo> ICProductTaskList { get; set; }

        public BOSList<ICProductFilesInfo> ProductFilesList { get; set; }

        public BOSList<ICProductProfilesInfo> ProductProfileList { get; set; }

        public BOSList<ICProductWorkItemsInfo> ICProductWorkItemAssetList { get; set; }

        public BOSList<ICProductDetailsInfo> ICProductDetailsList { get; set; }

        public List<ICProductsInfo> PrintQCodeItemsList { get; set; }

        public BOSList<ICProductMeasureUnitsInfo> ProductMeasureUnitList { get; set; }
        public BOSTreeList ProductionNormItemList { get; set; }
        public BOSTreeList ProductionNormItemHardwareList { get; set; }
        public BOSList<MMProductionNormItemHardwaresInfo> ProductionNormItemHardwareDetailList { get; set; }
        public BOSList<ICProductPackingDetailsInfo> ICProductPackingDetailsList { get; set; }
        public BOSList<MMProductionNormItemsInfo> GeneralMaterialList { get; set; }
        public BOSList<ICProductsInfo> ProductList { get; set; }
        public BOSList<ICProductsInfo> ProductItemList { get; set; }
        public BOSList<ICProductItemMaterialsInfo> PNIMList { get; set; }
        public BOSList<ICProductItemProcesssInfo> PIProcessList { get; set; }
        public BOSTreeList ProductItemTreeList { get; set; }

        public BOSList<ICProductTemplatesInfo> ProductTemplateList { get; set; }
        public BOSList<ICProductBranchsInfo> ProductBranchList { get; set; }

        public BOSList<ICProductTolenrancesInfo> ProductTolenrancesList { get; set; }
        public BOSList<ICProductContainerDetailsInfo> ProductContainerDetailList { get; set; }

        public BOSList<ICProductCustomersInfo> ProductCustomerList { get; set; }
        #endregion

        #region Constructor
        public ProductEntities()
            : base()
        {
            ICProductUnitsObject = new ICProductUnitsInfo();

            ICProductComponentsList = new BOSList<ICProductComponentsInfo>();
            ICProductPricesList = new BOSList<ICProductPricesInfo>();
            ICProductUnitsList = new BOSList<ICProductUnitsInfo>();
            ICProductSuppliersList = new BOSList<ICProductSuppliersInfo>();
            ProductBranchPriceList = new BOSList<ICProductBranchPricesInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            ProductPurchasePriceList = new BOSList<ICProductBranchPricesInfo>();
            MMBatchProductItemList = new BOSList<MMBatchProductItemsInfo>();
            ICProductProfilesList = new BOSList<ICProductProfilesInfo>();
            ICProductWorkItemList = new BOSList<ICProductWorkItemsInfo>();
            ICProductWorkItemMaterialList = new BOSList<ICProductWorkItemsInfo>();
            ICProductWorkItemAssetList = new BOSList<ICProductWorkItemsInfo>();
            ICProductTaskList = new BOSList<ICProductTasksInfo>();
            ProductFilesList = new BOSList<ICProductFilesInfo>();
            ProductProfileList = new BOSList<ICProductProfilesInfo>();
            ICProductDetailsList = new BOSList<ICProductDetailsInfo>();
            PrintQCodeItemsList = new List<ICProductsInfo>();
            ProductMeasureUnitList = new BOSList<ICProductMeasureUnitsInfo>();
            ProductionNormItemList = new BOSTreeList();
            ProductionNormItemHardwareList = new BOSTreeList();
            ProductionNormItemHardwareDetailList = new BOSList<MMProductionNormItemHardwaresInfo>();
            ICProductPackingDetailsList = new BOSList<ICProductPackingDetailsInfo>();
            GeneralMaterialList = new BOSList<MMProductionNormItemsInfo>();
            ProductItemList = new BOSList<ICProductsInfo>();
            PNIMList = new BOSList<ICProductItemMaterialsInfo>();
            PIProcessList = new BOSList<ICProductItemProcesssInfo>();
            ProductItemTreeList = new BOSTreeList();
            ProductList = new BOSList<ICProductsInfo>();
            ProductTemplateList = new BOSList<ICProductTemplatesInfo>();
            ProductBranchList = new BOSList<ICProductBranchsInfo>();
            ProductTolenrancesList = new BOSList<ICProductTolenrancesInfo>();
            ProductContainerDetailList = new BOSList<ICProductContainerDetailsInfo>();
            ProductCustomerList = new BOSList<ICProductCustomersInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductsInfo();
            SearchObject = new ICProductsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductComponentsTableName, new ICProductComponentsInfo());
            ModuleObjects.Add(TableName.ICProductPricesTableName, new ICProductPricesInfo());
            ModuleObjects.Add(TableName.ICProductUnitsTableName, new ICProductUnitsInfo());
            ModuleObjects.Add(TableName.ICProductSuppliersTableName, new ICProductSuppliersInfo());
            ModuleObjects.Add(TableName.ICProductBranchPricesTableName, new ICProductBranchPricesInfo());
            ModuleObjects.Add(TableName.MMBatchProductItemsTableName, new MMBatchProductItemsInfo());
            ModuleObjects.Add(TableName.ICProductProfilesTableName, new ICProductProfilesInfo());
            ModuleObjects.Add(TableName.ICProductsTableName, new ICProductsInfo());
            ModuleObjects.Add(TableName.ICProductItems, new ICProductItemsInfo());
            ModuleObjects.Add(TableName.ICProductWorkItemsTableName, new ICProductWorkItemsInfo());
            ModuleObjects.Add(TableName.ICProductTasksTableName, new ICProductTasksInfo());
            ModuleObjects.Add(TableName.ICProductFilesTableName, new ICProductFilesInfo());
            ModuleObjects.Add(TableName.ICProductDetailsTableName, new ICProductDetailsInfo());
            ModuleObjects.Add(TableName.ICProductMeasureUnitsTableName, new ICProductMeasureUnitsInfo());
            ModuleObjects.Add(TableName.ICProductPackingDetailsTableName, new ICProductPackingDetailsInfo());
            ModuleObjects.Add(TableName.ICProductTemplatesTableName, new ICProductTemplatesInfo());
            ModuleObjects.Add(TableName.ICProductBranchsTableName, new ICProductBranchsInfo());
        }

        public override void InitModuleObjectList()
        {
            ICProductComponentsList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductComponentsTableName,
                                                BOSList<ICProductComponentsInfo>.cstRelationForeign);
            ICProductComponentsList.ItemTableForeignKey = "FK_ICProductComponentParentID";

            ICProductPricesList.InitBOSList(
                                            this,
                                            TableName.ICProductsTableName,
                                            TableName.ICProductPricesTableName,
                                            BOSList<ICProductPricesInfo>.cstRelationForeign);
            ICProductPricesList.ItemTableForeignKey = "FK_ICProductID";

            ICProductUnitsList.InitBOSList(
                                            this,
                                            TableName.ICProductsTableName,
                                            TableName.ICProductUnitsTableName,
                                            BOSList<ICProductUnitsInfo>.cstRelationForeign);
            ICProductPricesList.ItemTableForeignKey = "FK_ICProductID";

            ICProductSuppliersList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductSuppliersTableName,
                                               BOSList<ICProductSuppliersInfo>.cstRelationForeign);
            ICProductSuppliersList.ItemTableForeignKey = "FK_ICProductID";

            ProductBranchPriceList.InitBOSList(this,
                                                    TableName.ICProductsTableName,
                                                    TableName.ICProductBranchPricesTableName,
                                                    BOSList<ICProductBranchPricesInfo>.cstRelationForeign);
            ProductBranchPriceList.ItemTableForeignKey = "FK_ICProductID";

            ProductPurchasePriceList.InitBOSList(this,
                                                    TableName.ICProductsTableName,
                                                    TableName.ICProductBranchPricesTableName,
                                                    BOSList<ICProductBranchPricesInfo>.cstRelationForeign);
            ProductPurchasePriceList.ItemTableForeignKey = "FK_ICProductID";

            HistoryDetailList.InitBOSList(this,
                                           TableName.GEObjectHistoryTableName,
                                           TableName.GEHistoryDetailsTableName,
                                           BOSList<GEHistoryDetailsInfo>.cstRelationForeign);

            MMBatchProductItemList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.MMBatchProductItemsTableName,
                                                BOSList<MMBatchProductItemsInfo>.cstRelationForeign);
            MMBatchProductItemList.ItemTableForeignKey = "FK_ICProductID";

            ICProductProfilesList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductProfilesTableName,
                                                BOSList<ICProductProfilesInfo>.cstRelationForeign);
            ICProductProfilesList.ItemTableForeignKey = "FK_ICProductID";

            ICProductWorkItemList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductWorkItemsTableName,
                                               BOSList<ICProductWorkItemsInfo>.cstRelationForeign);
            ICProductWorkItemList.ItemTableForeignKey = "FK_ICProductWorkItemParentID";

            ICProductWorkItemMaterialList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductWorkItemsTableName,
                                               BOSList<ICProductWorkItemsInfo>.cstRelationNone);
            ICProductWorkItemMaterialList.ItemTableForeignKey = "FK_ICProductID";

            ICProductWorkItemAssetList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductWorkItemsTableName,
                                               BOSList<ICProductWorkItemsInfo>.cstRelationNone);
            ICProductWorkItemAssetList.ItemTableForeignKey = "FK_ICProductID";

            ICProductTaskList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductTasksTableName,
                                               BOSList<ICProductTasksInfo>.cstRelationNone);
            ICProductTaskList.ItemTableForeignKey = "FK_ICProductParentID";
            ProductFilesList.InitBOSList(this,
                                               String.Empty,
                                               TableName.ICProductFilesTableName,
                                               BOSList<ICProductTasksInfo>.cstRelationNone);
            ProductProfileList.InitBOSList(this,
                                               String.Empty,
                                               TableName.ICProductProfilesTableName,
                                               BOSList<ICProductProfilesInfo>.cstRelationNone);
            ProductProfileList.ItemTableForeignKey = "FK_ICProductID";

            ICProductDetailsList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductDetailsTableName,
                                                BOSList<ICProductDetailsInfo>.cstRelationForeign);
            ICProductDetailsList.ItemTableForeignKey = "FK_ICProductID";

            ProductMeasureUnitList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductMeasureUnitsTableName,
                                                BOSList<ICProductMeasureUnitsInfo>.cstRelationForeign);
            ProductMeasureUnitList.ItemTableForeignKey = "FK_ICProductID";
            ProductionNormItemList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);
            ProductionNormItemHardwareList.InitBOSList(this,
                                                string.Empty,
                                                TableName.MMProductionNormItemsTableName,
                                                BOSTreeList.cstRelationNone);
            ProductionNormItemHardwareDetailList.InitBOSList(this,
                                               TableName.MMProductionNormItemsTableName,
                                               TableName.MMProductionNormItemHardwaresTableName,
                                               BOSList<MMProductionNormItemHardwaresInfo>.cstRelationForeign);
            ProductionNormItemHardwareDetailList.ItemTableForeignKey = "FK_MMProductionNormItemID";

            ICProductPackingDetailsList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductPackingDetailsTableName,
                                                BOSList<ICProductPackingDetailsInfo>.cstRelationForeign);
            ICProductPackingDetailsList.ItemTableForeignKey = "FK_ICProductID";

            GeneralMaterialList.InitBOSList(this,
                                              string.Empty,
                                              TableName.MMProductionNormItemsTableName,
                                              BOSList<MMProductionNormItemsInfo>.cstRelationNone);
            ProductList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductProfilesInfo>.cstRelationNone);

            ProductItemList.InitBOSList(this,
                                        string.Empty,
                                        TableName.ICProductsTableName,
                                        BOSList<ICProductProfilesInfo>.cstRelationNone);

            PNIMList.InitBOSList(this,
                                        string.Empty,
                                        "ICProductItemMaterials",
                                        BOSList<ICProductItemMaterialsInfo>.cstRelationNone);
            PIProcessList.InitBOSList(this,
                                        string.Empty,
                                        "ICProductItemProcesss",
                                        BOSList<ICProductItemProcesssInfo>.cstRelationNone);

            ProductItemTreeList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductItemsTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductItemTreeList.ItemTableForeignKey = "FK_ICProductCarcassID";

            ProductTemplateList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductTemplatesTableName,
                                                BOSTreeList.cstRelationForeign);
            ProductTemplateList.ItemTableForeignKey = "FK_ICProductID";
            ProductBranchList.InitBOSList(this,
                                              TableName.ICProductsTableName,
                                              TableName.ICProductBranchsTableName,
                                              BOSList<ICProductBranchsInfo>.cstRelationForeign);
            ProductBranchList.ItemTableForeignKey = "FK_ICProductID";

            ProductTolenrancesList.InitBOSList(this,
                                              TableName.ICProductsTableName,
                                              TableName.ICProductTolenrancesTableName,
                                              BOSList<ICProductTolenrancesInfo>.cstRelationForeign);
            ProductTolenrancesList.ItemTableForeignKey = "FK_ICProductID";
            ProductContainerDetailList.InitBOSList(this,
                                                    TableName.ICProductsTableName,
                                                    TableName.ICProductContainerDetailsTableName,
                                                    BOSList<ICProductContainerDetailsInfo>.cstRelationForeign);
            ProductContainerDetailList.ItemTableForeignKey = "FK_ICProductID";
            ProductCustomerList.InitBOSList(this,
                                              TableName.ICProductsTableName,
                                              TableName.ICProductCustomersTableName,
                                              BOSList<ICProductBranchsInfo>.cstRelationForeign);
            ProductCustomerList.ItemTableForeignKey = "FK_ICProductID";
        }

        public override void InitGridControlInBOSList()
        {
            ICProductComponentsList.InitBOSListGridControl(ProductModule.ProductComponentsGridControlName);
            ICProductSuppliersList.InitBOSListGridControl();
            ProductBranchPriceList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            ProductPurchasePriceList.InitBOSListGridControl();
            MMBatchProductItemList.InitBOSListGridControl();
            ICProductProfilesList.InitBOSListGridControl("fld_dgcICProductProfiles");
            ICProductWorkItemList.InitBOSListGridControl(ProductModule.ICProductWorkItemsGridControlName);
            ICProductWorkItemMaterialList.InitBOSListGridControl(ProductModule.ICProductWorkItemMaterialsGridControlName);
            ICProductWorkItemAssetList.InitBOSListGridControl(ProductModule.ICProductWorkItemAssetsGridControlName);
            ICProductTaskList.InitBOSListGridControl(ProductModule.ICProductTasksGridControlName);
            ProductFilesList.InitBOSListGridControl(ProductModule.ICProductImagesGridControlName);
            ProductProfileList.InitBOSListGridControl(ProductModule.ICProductProfileGridControlName);
            ICProductDetailsList.InitBOSListGridControl("fld_dgcICProductDetails");
            ProductMeasureUnitList.InitBOSListGridControl();
            ProductionNormItemList.InitBOSTreeListControl("fld_trlProductionNormItemTreeList");
            ProductionNormItemHardwareList.InitBOSTreeListControl("fld_trlMMProductionNormItemsHardware");
            ICProductPackingDetailsList.InitBOSListGridControl("fld_dgcICProductPackingDetails");
            GeneralMaterialList.InitBOSListGridControl("fld_dgcMMProductionNormItems");
            ProductList.InitBOSListGridControl();
            ProductItemTreeList.InitBOSTreeListControl("fld_trlICProductItems");
            ProductTemplateList.InitBOSListGridControl("fld_dgcICProductTemplates");
            ProductBranchList.InitBOSListGridControl("fld_dgcICProductBranchs");
            ProductTolenrancesList.InitBOSListGridControl("fld_dgcICProductTolenrances");
            ProductContainerDetailList.InitBOSListGridControl("fld_dgcICProductContainerDetails");
            ProductCustomerList.InitBOSListGridControl("fld_dgcICProductCustomers");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductActiveCheck = true;
            objProductsInfo.ICProductIsFollowInventoryStock = true;
            objProductsInfo.ICProductType = ProductType.Product.ToString();
            objProductsInfo.ICProductOriginOfProduct = ProductOrigin.Production.ToString();
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.NoneSpecific.ToString();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            DataSet ds = BOSApp.LookupTables.Contains( TableName.ICMeasureUnitsTableName)? (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] : null;
            string stMeasureUnitDefault = ADConfigValueUtility.GetConfigTextByGroupAndValue("MeasureUnitDefault", "Product");
            if (string.IsNullOrEmpty(stMeasureUnitDefault)) stMeasureUnitDefault = "pcs";
            if (ds != null && ds.Tables.Count > 0)
            {
                DataRow result = ds.Tables[0].Rows.Cast<DataRow>().Where(x => (x["ICMeasureUnitName"] != null ? x["ICMeasureUnitName"].ToString().ToUpper() : "")
                                                                             == stMeasureUnitDefault.ToUpper()).FirstOrDefault();
                if (result != null)
                {
                    objMeasureUnitsInfo = (ICMeasureUnitsInfo)(new ICMeasureUnitsController()).GetObjectFromDataRow(result);
                    objProductsInfo.FK_ICProductBasicUnitID = objMeasureUnitsInfo != null ? objMeasureUnitsInfo.ICMeasureUnitID : 0;
                }
            }
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.ProductNo.ToString()));
            objProductsInfo.FK_ICDepartmentID = objICDepartmentsInfo != null ? objICDepartmentsInfo.ICDepartmentID : 0;
            //ACAccountsController accountController = new ACAccountsController();
            //ACAccountsInfo account = accountController.GetObjectByNo(AccountDefault.DefaultAccount.ToString()) as ACAccountsInfo;
            //if (account != null)
            //    objProductsInfo.FK_ACAccountID = account.ACAccountID;
            objProductsInfo.ICProductLockedPurchaseOrder = false;
            ICPriceCalculationMethodsController objPriceCalculationMethodsController = new ICPriceCalculationMethodsController();
            ICPriceCalculationMethodsInfo objPriceCalculationMethodsInfo = (ICPriceCalculationMethodsInfo)objPriceCalculationMethodsController.GetPriceCalculationMethodDefault();
            if (objPriceCalculationMethodsInfo != null)
                objProductsInfo.FK_ICPriceCalculationMethodID = objPriceCalculationMethodsInfo.ICPriceCalculationMethodID;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = objConfigValuesController.GetADConfigValuesByDefaultProductType();
            if (configValuesList.Count() > 0)
            {
                ADConfigValuesInfo found = configValuesList.Where(C => C.ADConfigKeyValue == objProductsInfo.ICProductType).FirstOrDefault();
                if (found != null)
                {
                    objProductsInfo.ICProductIsFollowInventoryStock = false;
                }
                else objProductsInfo.ICProductIsFollowInventoryStock = true;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            ICProductComponentsList.SetDefaultListAndRefreshGridControl();
            ICProductSuppliersList.SetDefaultListAndRefreshGridControl();
            ICProductUnitsList.SetDefaultListAndRefreshGridControl();

            ICProductPricesList.SetDefaultListAndRefreshGridControl();
            SynProductPriceLevels();

            ProductBranchPriceList.SetDefaultListAndRefreshGridControl();

            ProductPurchasePriceList.SetDefaultListAndRefreshGridControl();
            SynProductPurchasePrices();
            MMBatchProductItemList.SetDefaultListAndRefreshGridControl();
            ICProductProfilesList.SetDefaultListAndRefreshGridControl();
            ICProductWorkItemList.SetDefaultListAndRefreshGridControl();
            ICProductWorkItemMaterialList.SetDefaultListAndRefreshGridControl();
            ICProductWorkItemAssetList.SetDefaultListAndRefreshGridControl();
            ICProductTaskList.SetDefaultListAndRefreshGridControl();
            ProductFilesList.SetDefaultListAndRefreshGridControl();
            ICProductDetailsList.SetDefaultListAndRefreshGridControl();
            ProductMeasureUnitList.SetDefaultListAndRefreshGridControl();
            ProductionNormItemList.SetDefaultListAndRefreshTreeListControl();
            ProductionNormItemHardwareList.SetDefaultListAndRefreshTreeListControl();
            ICProductPackingDetailsList.SetDefaultListAndRefreshGridControl();
            GeneralMaterialList.SetDefaultListAndRefreshGridControl();
            ProductItemTreeList.SetDefaultListAndRefreshTreeListControl();
            ProductTemplateList.SetDefaultListAndRefreshGridControl();
            ProductTolenrancesList.SetDefaultListAndRefreshGridControl();
            ProductContainerDetailList.SetDefaultListAndRefreshGridControl();
            ProductBranchList.SetDefaultListAndRefreshGridControl();
            ProductCustomerList.SetDefaultListAndRefreshGridControl();
            InitContainerDetailList(0);
        }

        /// <summary>
        /// Invalidate the product's price levels
        /// </summary>
        /// <param name="productID">Product id</param>
        public void InvalidateProductPriceLevels(int productID)
        {
            ICProductPricesList.Invalidate(productID);

            SynProductPriceLevels();
        }

        /// <summary>
        /// Synchronize the product's price levels with the master ones
        /// </summary>
        private void SynProductPriceLevels()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
            BOSList<ARPriceLevelsInfo> priceLevels = new BOSList<ARPriceLevelsInfo>();
            DataSet ds = objPriceLevelsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARPriceLevelsInfo objPriceLevelsInfo = (ARPriceLevelsInfo)objPriceLevelsController.GetObjectFromDataRow(row);
                    priceLevels.Add(objPriceLevelsInfo);
                }
            }

            //Add new price levels to product price level list
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            foreach (ARPriceLevelsInfo objPriceLevelsInfo in priceLevels)
                if (!ICProductPricesList.Exists("FK_ARPriceLevelID", objPriceLevelsInfo.ARPriceLevelID))
                {
                    ICProductPricesInfo objProductPricesInfo = new ICProductPricesInfo();
                    objProductPricesInfo.FK_ARPriceLevelID = objPriceLevelsInfo.ARPriceLevelID;
                    objProductPricesInfo.FK_ICProductID = objProductsInfo.ICProductID;
                    objProductPricesInfo.ICProductPriceMarkDown = objPriceLevelsInfo.ARPriceLevelMarkDown;
                    ICProductPricesList.Add(objProductPricesInfo);
                }

            //Delete old price levels from product price level list
            for (int i = 0; i < ICProductPricesList.Count; i++)
                if (!priceLevels.Exists("ARPriceLevelID", ICProductPricesList[i].FK_ARPriceLevelID))
                {
                    ICProductPricesList.RemoveAt(i);
                    i--;
                }
        }

        /// <summary>
        /// Invalidate the product's purchase prices
        /// </summary>
        /// <param name="productID">Product id</param>
        public void InvalidateProductPurchasePrices(int productID)
        {
            ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
            List<ICProductBranchPricesInfo> productPurchasePrices = objProductBranchPricesController.GetProductBranchPriceByProductIDAndType(productID, ProductBranchPriceType.Purchase.ToString());
            ProductPurchasePriceList.Invalidate(productPurchasePrices);

            SynProductPurchasePrices();
        }

        /// <summary>
        /// Synchronize the product's purchase prices with currencies
        /// </summary>
        private void SynProductPurchasePrices()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            List<GECurrenciesInfo> currencies = new List<GECurrenciesInfo>();
            DataSet ds = objCurrenciesController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectFromDataRow(row);
                    currencies.Add(objCurrenciesInfo);
                }
            }

            //Add new currency to product purchase prices            
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            foreach (GECurrenciesInfo objCurrenciesInfo in currencies)
            {
                if (!ProductPurchasePriceList.Exists("FK_GECurrencyID", objCurrenciesInfo.GECurrencyID))
                {
                    ICProductBranchPricesInfo objProductBranchPricesInfo = new ICProductBranchPricesInfo();
                    objProductBranchPricesInfo.FK_BRBranchID = 0;
                    objProductBranchPricesInfo.FK_ICProductID = objProductsInfo.ICProductID;
                    if (objCurrenciesInfo.GECurrencyID == BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID)
                    {
                        objProductBranchPricesInfo.ICProductBranchPrice = objProductsInfo.ICProductSupplierPrice;
                    }
                    else
                    {
                        objProductBranchPricesInfo.ICProductBranchPrice = 0;
                    }

                    objProductBranchPricesInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
                    objProductBranchPricesInfo.ICProductBranchPriceType = ProductBranchPriceType.Purchase.ToString();
                    ProductPurchasePriceList.Add(objProductBranchPricesInfo);
                    ProductPurchasePriceList.BackupList.Add(objProductBranchPricesInfo);
                }
            }

            //Delete old currencies from product branch prices
            for (int i = 0; i < ProductPurchasePriceList.Count; i++)
            {
                GECurrenciesInfo objCurrencyInfo = currencies.Where(c => c.GECurrencyID == ProductPurchasePriceList[i].FK_GECurrencyID).FirstOrDefault();
                if (objCurrencyInfo == null)
                {
                    ProductPurchasePriceList.RemoveAt(i);
                    ProductPurchasePriceList.BackupList.RemoveAt(i);
                    i--;
                }
            }
        }

        public override void DuplicateModuleObjectList()
        {
            ICProductComponentsList.Duplicate();
            ICProductPricesList.Duplicate();
            ICProductSuppliersList.Duplicate();
            ProductBranchPriceList.Duplicate();
            ICProductPackingDetailsList.Duplicate();
            foreach (ICProductBranchPricesInfo productPrice in ProductBranchPriceList)
            {
                productPrice.ICProductBranchPrice = 0;
            }
            ProductPurchasePriceList.Duplicate();
            ProductBranchList.Duplicate();
            ProductTolenrancesList.Duplicate();
            ProductContainerDetailList.Duplicate();
            ProductCustomerList.Duplicate();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            InvalidateProductPriceLevels(iObjectID);

            ICProductUnitsList.Invalidate(iObjectID);

            ICProductSuppliersList.Invalidate(iObjectID);

            ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
            List<ICProductBranchPricesInfo> productSellingPrices = objProductBranchPricesController.GetProductBranchPriceByProductIDAndType(iObjectID, ProductBranchPriceType.Sale.ToString());
            ProductBranchPriceList.Invalidate(productSellingPrices);

            InvalidateProductPurchasePrices(iObjectID);

            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            MMBatchProductItemList.GridControl.DataSource = objBatchProductItemsController.GetListItemByproductID(objProductsInfo.ICProductID);
            ICProductProfilesController objProductProfilesController = new ICProductProfilesController();
            ICProductProfilesList.Invalidate(iObjectID);

            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> productComponentsList = objProductComponentsController.GetProductComponentListByProductID(iObjectID);
            ICProductComponentsList.Invalidate(productComponentsList);

            ICProductWorkItemsController objProductWorkItemsController = new ICProductWorkItemsController();
            List<ICProductWorkItemsInfo> productWorkItems = objProductWorkItemsController.GetProductWorkItemsByProductWorkItemParentID(iObjectID);
            ICProductWorkItemList.Invalidate(productWorkItems);

            List<ICProductWorkItemsInfo> productWorkItemLists = objProductWorkItemsController.GetProductWorkItemsByProductWorkItemParentIDAndParentType(iObjectID, objProductsInfo.ICProductType);

            List<ICProductWorkItemsInfo> productWorkItemMaterials = productWorkItemLists.Where(o => o.ICProductWorkItemType == strMaterial).ToList();
            ICProductWorkItemMaterialList.Invalidate(productWorkItemMaterials);

            List<ICProductWorkItemsInfo> productWorkItemAssets = productWorkItemLists.Where(o => o.ICProductWorkItemType == strAsset).ToList();
            ICProductWorkItemAssetList.Invalidate(productWorkItemAssets);

            ICProductTasksController objProductTasksController = new ICProductTasksController();
            List<ICProductTasksInfo> productTasks = objProductTasksController.GetProductTasksByProductIDAndParentType(iObjectID, objProductsInfo.ICProductType);
            ICProductTaskList.Invalidate(productTasks);

            List<ICProductFilesInfo> productFiles = ApiClientHelper.GetImages(iObjectID);
            if (productFiles == null)
                productFiles = new List<ICProductFilesInfo>();

            ProductFilesList.Invalidate(productFiles);

            ICProductDetailsList.Invalidate(iObjectID);

            ProductMeasureUnitList.Invalidate(iObjectID);
            ProductBranchList.Invalidate(iObjectID);
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            List<ICProductCustomersInfo> productCustomerList = objProductCustomersController.GetProductCustomerListByProductID(iObjectID);
            ProductCustomerList.Invalidate(productCustomerList);
            InitTolenranceList(iObjectID);
            InitContainerDetailList(iObjectID);
            InvalidateBOM();
            InvalidateBOMHardware();
            ICProductPackingDetailsList.Invalidate(iObjectID);
            InvalidateBOMGeneralMaterial();
            InvalidateProductItemTreeList();

            InvalidProductTemplate();
        }

        public void InitTolenranceList(int iObjectID)
        {
            ICProductTolenrancesController objProductTolenrancesController = new ICProductTolenrancesController();
            List<ICProductTolenrancesInfo> productTolenrancesList = objProductTolenrancesController.GetProductTolenranceByProductID(iObjectID);
            ProductTolenrancesList.Invalidate(productTolenrancesList);
        }
        public void InitContainerDetailList(int iObjectID)
        {
            ICProductContainerDetailsController objProductContainerDetailsController = new ICProductContainerDetailsController();
            List<ICProductContainerDetailsInfo> productContainerList = objProductContainerDetailsController.GetContainerDetailByProductID(iObjectID);
            ProductContainerDetailList.Invalidate(productContainerList);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            //Boolean newProduct = false;
            bool isInvalid = false;
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;


            if (objProductsInfo.FK_ICProductAttributeFinishingID == 0)
            {
                objProductsInfo.FK_ICProductAttributeFinishingID = 0;
                objProductsInfo.ICProductAttributeFinishing = string.Empty;
                objProductsInfo.ICProductAttributeFinishingText = string.Empty;
            }
            objProductsInfo.FK_ICProductSaleUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.FK_ICProductPurchaseUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            //objProductsInfo.HasComponent = false;
            if (objProductsInfo.ICProductCartonBlock == 0)
                objProductsInfo.ICProductCartonBlock = (objProductsInfo.ICProductWidth * objProductsInfo.ICProductHeight * objProductsInfo.ICProductLength) / (decimal)Math.Pow(10, 9);
           
            return base.SaveMainObject();
        }
        public void SetProductNoBySomeMateria()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            if (objProductsInfo.ICProductNo != cstNewObjectText)
                return;

            //ProductEntities entity = (ProductEntities)CurrentModuleEntity;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            GENumberingController objNumberingController = new GENumberingController();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            List<ICProductAttributesInfo> listAttributeColor = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeColorColumnName);
            ICProductAttributesInfo objProductAttributesInfo = listAttributeColor.Where(i => i.ICProductAttributeID == objProductsInfo.FK_ICProductAttributeColorID).FirstOrDefault();
            GENumberingInfo objNumberingInfo = objNumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            string color1 = string.Empty;
            string color2 = string.Empty;
            if (objProductAttributesInfo != null)
            {
                string[] arrListStr = objProductsInfo.ICProductNo.Split('.');
                if (arrListStr.Length > 1)
                {
                    objProductsInfo.ICProductNo = arrListStr[0];
                    for (int i = 1; i < arrListStr.Length; i++)
                    {
                        if (listAttributeColor.Where(t => t.ICProductAttributeAbbreviation == arrListStr[i]).FirstOrDefault() == null)
                            objProductsInfo.ICProductNo += ("." + arrListStr[i]);
                    }
                }
                if (!string.IsNullOrEmpty(objProductAttributesInfo.ICProductAttributeAbbreviation.Trim()) || !string.IsNullOrEmpty(objProductsInfo.ICProductColorAttribute.Trim()))
                {
                    if (!string.IsNullOrEmpty(objProductAttributesInfo.ICProductAttributeAbbreviation.Trim()))
                    {
                        color1 = "." + objProductAttributesInfo.ICProductAttributeAbbreviation;
                    }
                    string[] arrListColor = objProductsInfo.ICProductColorAttribute.Split(',');
                    if (arrListColor.Length > 0 && arrListColor[0] != string.Empty)
                    {
                        for (int i = 0; i < arrListColor.Length; i++)
                        {
                            objProductAttributesInfo = listAttributeColor.Where(t => t.ICProductAttributeID == int.Parse(arrListColor[i])).FirstOrDefault();
                            if (objProductAttributesInfo != null && !string.IsNullOrEmpty(objProductAttributesInfo.ICProductAttributeAbbreviation.Trim()))
                                color2 = color2 + "." + objProductAttributesInfo.ICProductAttributeAbbreviation;
                        }
                    }
                }
                if (objDepartmentsInfo != null && objProductGroupsInfo != null && objNumberingInfo != null && objProductsInfo.ICProductNo.Length > objNumberingInfo.GENumberingLength)
                {
                    if (objProductsInfo.FK_ICProductCarcassID > 0)
                        objProductsInfo.ICProductNo = objProductsInfo.ICProductNo + color1 + color2;
                    else
                    {
                        objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                        objProductsInfo.ICProductNo = objDepartmentsInfo.ICDepartmentNo
                                                        + objProductGroupsInfo.ICProductGroupNo
                                                        + objProductsInfo.ICProductNo.Substring(objProductsInfo.ICProductNo.Length - objNumberingInfo.GENumberingLength)
                                                        + color1
                                                        + color2;
                    }
                    objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;

                }
            }
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = GetMainObjectNoByGenerateProductNoConfig(ref numberingStart, false);
            if (!string.IsNullOrWhiteSpace(mainObjectNo))
            {
                return mainObjectNo;
            }

            return GenerateMainObjectNo(ref numberingStart);
        }

        public string GenerateMainObjectNo(ref int numberingStart)
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            if (objProductsInfo.ICProductNo != cstNewObjectText)
                return objProductsInfo.ICProductNo;

            string productNo = string.Empty;
            ICProductsController objProductsController = new ICProductsController();
            string strMainObjectNo = base.GetMainObjectNo(ref numberingStart);
            List<string> itemStrNo = new List<string>();
            if (objProductsInfo.FK_ICProductCarcassID > 0)
            {
                ICProductsInfo carcassProductsInfo = BOSApp.GetProductFromCurrentProductList(objProductsInfo.FK_ICProductCarcassID);
                productNo = carcassProductsInfo == null ? string.Empty : carcassProductsInfo.ICProductNo;
                List<string> arrNo = productNo.Split('.').ToList();
                productNo = arrNo.FirstOrDefault();
            }
            if (string.IsNullOrWhiteSpace(productNo))
            {   
                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                string departmentNo = objDepartmentsController.GetObjectNoByID(objProductsInfo.FK_ICDepartmentID);
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo rootInfo = objProductGroupsController.GetRootGroupByGroup(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
                string rootNo = rootInfo != null ? rootInfo.ICProductGroupNo: string.Empty;
                string productGroupNo = objProductGroupsController.GetObjectNoByID(objProductsInfo.FK_ICProductGroupID);
                //if (productGroupNo.Length > 2)
                //{
                //    productGroupNo = productGroupNo.Substring(0, 2);
                //}
                
                itemStrNo.Add(departmentNo);
                itemStrNo.Add(rootNo);
                itemStrNo.Add(productGroupNo);
                itemStrNo.Add(strMainObjectNo);
                
                productNo = string.Join("", itemStrNo.ToArray());
            }
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();

            List<int> arrListColor = new List<int>();
            if (!string.IsNullOrWhiteSpace(objProductsInfo.ICProductColorAttribute))
            {
                arrListColor = objProductsInfo.ICProductColorAttribute.Split(',').Select(o => Int32.Parse(o)).ToList();
            }
            arrListColor.Add(objProductsInfo.FK_ICProductAttributeColorID);

            List<ICProductAttributesInfo> listAttr = objProductAttributesController.GetProductAttributeByProductAttributeReferenceByCharater(string.Join(",", arrListColor.ToArray()), ",");

            string subNo = listAttr.Where(o => o.ICProductAttributeID == objProductsInfo.FK_ICProductAttributeColorID).Select(o => o.ICProductAttributeAbbreviation.Trim()).FirstOrDefault();

            if (!string.IsNullOrEmpty(subNo))
                subNo = string.Format(".{0}", subNo);
            else
                subNo = string.Empty;

            string subAtrr = string.Join(".", listAttr.Where(o => o.ICProductAttributeID != objProductsInfo.FK_ICProductAttributeColorID).Select(o => o.ICProductAttributeAbbreviation.Trim()).ToArray());
            productNo = productNo + subNo + (string.IsNullOrWhiteSpace(subAtrr) ? string.Empty : "." + subAtrr);

            int index = 1;
            string tmpProductNo = productNo;
            while (objProductsController.IsExist(tmpProductNo))
            {
                tmpProductNo = productNo + index;
                index++;
            }
            return tmpProductNo;
        }

        public override void SaveModuleObjects()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            SaveProductComponent();
            ICProductPricesList.SaveItemObjects();
            ICProductUnitsList.SaveItemObjects();
            ICProductSuppliersList.SaveItemObjects();

            ProductBranchPriceList.SaveItemObjects();
            ProductPurchasePriceList.SaveItemObjects();

            SaveProductComponent();

            ICProductProfilesList.SaveItemObjects();
            ICProductWorkItemList.SaveItemObjects();
            ICProductWorkItemList.ForEach(o =>
            {
                if (o.ProductWorkItemComponentsList == null)
                {
                    o.ProductWorkItemComponentsList = new BOSList<ICProductWorkItemsInfo>();
                    o.ProductWorkItemComponentsList.InitBOSList(this,
                                                       TableName.ICProductsTableName,
                                                       TableName.ICProductWorkItemsTableName,
                                                       BOSList<ICProductWorkItemsInfo>.cstRelationNone);
                }
                if (o.ProductWorkItemTasksList == null)
                {
                    o.ProductWorkItemTasksList = new BOSList<ICProductTasksInfo>();
                    o.ProductWorkItemTasksList.InitBOSList(this,
                                                       TableName.ICProductsTableName,
                                                       TableName.ICProductTasksTableName,
                                                       BOSList<ICProductTasksInfo>.cstRelationNone);
                }

                foreach (ICProductWorkItemsInfo objProductComponentsInfo in o.ProductWorkItemComponentsList)
                {
                    objProductComponentsInfo.FK_ICProductID = o.FK_ICProductWorkItemParentID;
                }

                foreach (ICProductTasksInfo objProductTask in o.ProductWorkItemTasksList)
                {
                    objProductTask.FK_ICProductParentID = o.FK_ICProductWorkItemParentID;
                }
                o.ProductWorkItemComponentsList.SaveItemObjects();
                o.ProductWorkItemTasksList.SaveItemObjects();
            });
            ICProductDetailsList.SaveItemObjects();
            ProductMeasureUnitList.SaveItemObjects();
            ICProductPackingDetailsList.SaveItemObjects();
            ProductTemplateList.SaveItemObjects();
            ProductBranchList.SaveItemObjects();
            ICProductTemplateItemsController pimController = new ICProductTemplateItemsController();
            List<ICProductTemplateItemsInfo> pimList = pimController.GetProductTemplateItemByProductID(objProductsInfo.ICProductID);
            List<int> existIdList = new List<int>();
            ProductTemplateList.ForEach(o =>
            {
                if (o.ItemList != null && o.ItemList.Count() > 0)
                {
                    foreach (ICProductTemplateItemsInfo m in o.ItemList)
                    {
                        m.FK_ICProductTemplateID = o.ICProductTemplateID;
                        if (m.ICProductTemplateItemID == 0)
                        {
                            pimController.CreateObject(m);
                        }
                        else
                        {
                            pimController.UpdateObject(m);
                        }
                        existIdList.Add(m.ICProductTemplateItemID);
                    }
                    foreach (ICProductTemplateItemsInfo pim in pimList)
                    {
                        if (!existIdList.Contains(pim.ICProductTemplateItemID))
                        {
                            pimController.DeleteObject(pim.ICProductTemplateItemID);
                        }
                    }
                }
            });

            ProductTolenrancesList.SaveItemObjects();
            ProductContainerDetailList.SaveItemObjects();
            ProductCustomerList.SaveItemObjects();
        }

        /// <summary>
        /// Save product component list
        /// </summary>
        public void SaveProductComponent()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            int sortOrder = 0;
            foreach (ICProductComponentsInfo objProductComponentsInfo in ICProductComponentsList)
            {
                sortOrder++;
                objProductComponentsInfo.FK_ICProductComponentParentID = objProductsInfo.ICProductID;
                objProductComponentsInfo.ICProductComponentSortOrder = sortOrder;
            }
            ICProductComponentsList.SaveItemObjects();
        }
        #endregion
        public void InvalidateProductItemTreeList()
        {
            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            ICProductItemsController productItemController = new ICProductItemsController();
            List<ICProductItemsInfo> collection = productItemController.GetProductItemsByProductCarcassID(mainObject.ICProductID);

            ProductItemTreeList.Clear();
            ICProductItemsInfo item = new ICProductItemsInfo();

            ProductItemTreeList.Add(item);

            item.SubList = new BOSTreeList();
            object objType = ProductItemTreeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            item.SubList = (BOSTreeList)objType;
            item.SubList.InitBOSList(this, "ICProductItems", "ICProductItems");


            if (collection != null && collection.Any())
            {

                InvalidateTreeList(item.SubList, collection, 0);
                ////Cụm & chi tiết rời
                //List<ICProductItemsInfo> parentList = collection.Where(t => t.ICProductItemParentID == 0).ToList();

                //parentList.ForEach(parent =>
                //{

                //    ICProductItemsInfo nodeParent = parent.Clone() as ICProductItemsInfo;
                //    item.SubList.Add(nodeParent);
                //    AddChildNode(collection, nodeParent);

                //});

            }
            RefreshProductItemTreeListView(ProductItemTreeList);
        }

        private void InvalidateTreeList(IBOSTreeList treeList, List<ICProductItemsInfo> collection, int parentID)
        {
            if (treeList != null && collection != null)
            {
                treeList.Clear();
                treeList.OriginalList.Clear();
                treeList.BackupList.Clear();

                foreach (ICProductItemsInfo productItem in collection)
                {
                    if (productItem.ICProductItemParentID == parentID)
                    {
                        ICProductItemsInfo productItem1 = productItem.Clone() as ICProductItemsInfo;
                        productItem1.BackupObject = productItem1.Clone() as ICProductItemsInfo;
                        treeList.Add(productItem1);
                        object objType = treeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                        productItem1.SubList = (BOSTreeList)objType;
                        productItem1.SubList.InitBOSList(this, TableName.ICProductItemsTableName, TableName.ICProductItemsTableName);
                        this.InvalidateTreeList(productItem1.SubList, collection, productItem1.ICProductItemID);

                        productItem1 = productItem.Clone() as ICProductItemsInfo;
                        treeList.OriginalList.Add(productItem1);
                        productItem1 = productItem.Clone() as ICProductItemsInfo;
                        treeList.BackupList.Add(productItem1);
                    }
                }

            }
        }

        public void AddChildNode(List<ICProductItemsInfo> collection, ICProductItemsInfo parent)
        {
            //Chi tiết
            ICProductItemsInfo childNode;
            List<ICProductItemsInfo> childList = collection.Where(t => t.ICProductItemParentID == parent.ICProductItemID).ToList();
            if (childList != null && childList.Any())
            {
                parent.SubList = new BOSTreeList();
                object objType = ProductItemTreeList.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                parent.SubList = (BOSTreeList)objType;
                parent.SubList.InitBOSList(this, "ICProductItems", "ICProductItems");

                childList.ForEach(child =>
                {
                    childNode = child.Clone() as ICProductItemsInfo;
                    parent.SubList.Add(childNode);
                    AddChildNode(collection, childNode);
                });
            }

        }

        public void RefreshProductItemTreeListView(BOSTreeList treelist)
        {
            if (treelist != null && treelist.TreeListControl != null)
            {
                treelist.TreeListControl.RefreshDataSource();
                treelist.TreeListControl.ExpandAll();
                treelist.TreeListControl.BestFitColumns();
            }
        }

        public void InvalidateBOM()
        {
            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetCarcassByProductID(mainObject.ICProductID);

            ProductionNormItemList.Clear();

            if (collection != null && collection.Any())
            {
                ProductionNormItemList.Invalidate(collection, 0);
            }
            RefreshProductItemTreeListView(ProductionNormItemList);
        }

        public void InvalidateBOMHardware()
        {
            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetCarcassByProductIDHardware(mainObject.ICProductID);

            ProductionNormItemHardwareList.Clear();

            if (collection != null && collection.Any())
            {
                ProductionNormItemHardwareList.Invalidate(collection, 0);
            }
            RefreshProductItemTreeListView(ProductionNormItemHardwareList);
        }


        public void InvalidateBOMGeneralMaterial()
        {
            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            MMProductionNormItemsController productItemController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> collection = productItemController.GetCarcassByProductIDGeneralMaterial(mainObject.ICProductID);

            GeneralMaterialList.Invalidate(collection);
            if (GeneralMaterialList.GridControl != null)
            {
                GeneralMaterialList.GridControl.RefreshDataSource();
            }
        }

        public void UpdateImages()
        {
            ICProductFilesController objProductFilesController = new ICProductFilesController();

            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            List<ICProductFilesInfo> productFiles = objProductFilesController.GetICProductFilesByProductID(mainObject.ICProductID);

            List<ICProductFilesInfo> productFilesAdd = new List<ICProductFilesInfo>();
            List<ICProductFilesInfo> productFilesDelete = new List<ICProductFilesInfo>();
            productFilesAdd = ProductFilesList.Where(o => o.ICProductFileName == new Guid()).ToList();
            productFilesDelete = productFiles.Where(o => !ProductFilesList.Any(s => s.ICProductFileName == o.ICProductFileName)).ToList();
            if (productFilesAdd.Where(o => !o.IsDefault).Any())
            {
                ApiClientHelper.AddImage(productFilesAdd.Where(o => o.IsDefault).Select(o => o.ICProductFilePath).ToList(), mainObject.ICProductID);
            }
            if (productFilesAdd.Where(o => o.IsDefault).Any())
            {
                ApiClientHelper.UpdatePrimaryImage(productFilesAdd.Where(o => o.IsDefault).FirstOrDefault().ICProductFilePath, mainObject.ICProductID);
            }
            productFilesDelete.ForEach(p =>
            {
                objProductFilesController.DeleteObject(p.ICProductFileID);
            });
        }

        public void SaveProfile(ICProductProfilesInfo objProductProfilesInfo)
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            ICProductProfilesController objICProductProfilesController = new ICProductProfilesController();
            if (objProductsInfo.ICProductID == 0)
            {
                objProductProfilesInfo.AACreatedUser = BOSApp.CurrentUser;
                objProductProfilesInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
                objProductProfilesInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objICProductProfilesController.CreateObject(objProductProfilesInfo);
            }
            else
            {
                objProductProfilesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objProductProfilesInfo.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                objICProductProfilesController.UpdateObject(objProductProfilesInfo);
            }

        }
        public void GenerateProductCustomer()
        {
            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ICProductCustomersInfo objProductCustomersInfo = new ICProductCustomersInfo();
            objProductCustomersInfo.AACreatedDate = DateTime.Now;
            objProductCustomersInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
            objProductCustomersInfo.FK_ICProductID = mainObject.ICProductID;
            objProductCustomersInfo.ICProductCustomerNumber = mainObject.ICProductCustomerNumber;
            objProductCustomersInfo.ICProductCustomerName = mainObject.ICProductName;
            objProductCustomersInfo.ICProductCustomerPackagingDetail = mainObject.ICProductPackagingDetailEnglish;
            objProductCustomersInfo.ICProductCustomerPackagingInfoVietnam = mainObject.ICProductPackagingDetail;
            objProductCustomersInfo.ICProductCustomerProductionComment = string.Format("- Mô tả: {0}" + Environment.NewLine + "- KT: {1}" + Environment.NewLine + "- ĐG: {2}",
                                                                                            mainObject.ICProductName2,
                                                                                            string.Format("{0}x{1}x{2}mm", (int)mainObject.ICProductWidth, (int)mainObject.ICProductLength, (int)mainObject.ICProductHeight),
                                                                                            mainObject.ICProductPackagingDetail);
        }
        private void InvalidProductTemplate()
        {
            ICProductsInfo mainObject = (ICProductsInfo)this.MainObject;

            ICProductTemplatesController templatesController = new ICProductTemplatesController();
            List<ICProductTemplatesInfo> templates = templatesController.GetProductTemplatesByProductID(mainObject.ICProductID);

            ICProductTemplateItemsController itemCtrl = new ICProductTemplateItemsController();
            List<ICProductTemplateItemsInfo> itemList = itemCtrl.GetProductTemplateItemByProductID(mainObject.ICProductID);

            templates.ForEach(btp =>
            {
                btp.ItemList = new BindingList<ICProductTemplateItemsInfo>();
                itemList.ForEach(m =>
                {
                    if (m.FK_ICProductTemplateID == btp.ICProductTemplateID)
                    {
                        btp.ItemList.Add(m);
                    }
                });
            });

            ProductTemplateList.Invalidate(templates);
            ProductTemplateList.GridControl.RefreshDataSource();
        }
    }
}
