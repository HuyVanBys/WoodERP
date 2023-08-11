using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.HardwareProduct
{
    class HardwareProductEntities : ERPModuleEntities
    {

        #region Declare Constant
        public const String strICProductsObjectName = "ICProducts";

        public const String strICProductAlternativesObjectName = "ICProductAlternatives";
        public const String strICProductComponentsObjectName = "ICProductComponents";
        public const String strICProductAttributesObjectName = "ICProductAttributes";
        public const String strICProductUnitsObjectName = "ICProductUnits";
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ICProductBranchPricesInfo> ProductBranchPriceList { get; set; }
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }
        public BOSList<ICProductPricesInfo> ICProductPricesList { get; set; }
        public ICProductUnitsInfo ICProductUnitsObject { get; set; }
        public BOSList<ICProductUnitsInfo> ICProductUnitsList { get; set; }
        public BOSList<ICProductItemsInfo> ICProductItemsList { get; set; }
        public BOSList<ICProductsInfo> ICProductList { get; set; }
        public BOSList<ICProductSuppliersInfo> ICProductSuppliersList { get; set; }
        public BOSList<ICProductBranchPricesInfo> ProductPurchasePriceList { get; set; }
        public BOSList<ICProductFilesInfo> ProductFilesList { get; set; }
        public BOSList<ICProductComponentsInfo> ICProductComponentsList { get; set; }

        public BOSList<ICProductMeasureUnitsInfo> ProductMeasureUnitList { get; set; }
        public BOSList<ICProductTolenrancesInfo> ProductTolenrancesList { get; set; }

        #endregion

        #region Constructor
        public HardwareProductEntities()
            : base()
        {
            ICProductUnitsObject = new ICProductUnitsInfo();

            ICProductPricesList = new BOSList<ICProductPricesInfo>();
            ICProductUnitsList = new BOSList<ICProductUnitsInfo>();
            ICProductSuppliersList = new BOSList<ICProductSuppliersInfo>();
            ProductBranchPriceList = new BOSList<ICProductBranchPricesInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            ProductPurchasePriceList = new BOSList<ICProductBranchPricesInfo>();
            ICProductItemsList = new BOSList<ICProductItemsInfo>();
            ICProductList = new BOSList<ICProductsInfo>();
            ProductFilesList = new BOSList<ICProductFilesInfo>();
            ICProductComponentsList = new BOSList<ICProductComponentsInfo>();
            ProductMeasureUnitList = new BOSList<ICProductMeasureUnitsInfo>();
            ProductTolenrancesList = new BOSList<ICProductTolenrancesInfo>();
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
            ModuleObjects.Add(TableName.ICProductItems, new ICProductItemsInfo());
            ModuleObjects.Add(TableName.ICProductFilesTableName, new ICProductFilesInfo());
            ModuleObjects.Add(TableName.ICProductMeasureUnitsTableName, new ICProductMeasureUnitsInfo());
        }
        public override void InitModuleObjectList()
        {

            ICProductItemsList.InitBOSList(this,
                                               TableName.ICProductsTableName,
                                               TableName.ICProductItemsTableName,
                                               BOSList<ICProductItemsInfo>.cstRelationForeign);
            ICProductItemsList.ItemTableForeignKey = "FK_ICProductItemParentID";

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
            ProductFilesList.InitBOSList(this,
                                               String.Empty,
                                               TableName.ICProductFilesTableName,
                                               BOSList<ICProductTasksInfo>.cstRelationNone);
            ICProductComponentsList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductComponentsTableName,
                                                BOSList<ICProductComponentsInfo>.cstRelationForeign);
            ICProductComponentsList.ItemTableForeignKey = "FK_ICProductComponentParentID";

            ProductMeasureUnitList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductMeasureUnitsTableName,
                                                BOSList<ICProductMeasureUnitsInfo>.cstRelationForeign);
            ProductMeasureUnitList.ItemTableForeignKey = "FK_ICProductID";
            ProductTolenrancesList.InitBOSList(this,
                                              TableName.ICProductsTableName,
                                              TableName.ICProductTolenrancesTableName,
                                              BOSList<ICProductTolenrancesInfo>.cstRelationForeign);
            ProductTolenrancesList.ItemTableForeignKey = "FK_ICProductID";
        }
        public override void InitGridControlInBOSList()
        {

            ICProductItemsList.InitBOSListGridControl();
            ICProductSuppliersList.InitBOSListGridControl();
            ProductBranchPriceList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            ProductPurchasePriceList.InitBOSListGridControl();
            ProductFilesList.InitBOSListGridControl(HardwareProductModule.ICProductImagesGridControlName);
            ICProductComponentsList.InitBOSListGridControl(HardwareProductModule.ProductComponentsGridControlName);
            ProductMeasureUnitList.InitBOSListGridControl();
            ProductTolenrancesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICProductItemsList.SetDefaultListAndRefreshGridControl();
                ICProductSuppliersList.SetDefaultListAndRefreshGridControl();
                ICProductUnitsList.SetDefaultListAndRefreshGridControl();

                ICProductPricesList.SetDefaultListAndRefreshGridControl();
                SynProductPriceLevels();

                ProductBranchPriceList.SetDefaultListAndRefreshGridControl();

                ProductPurchasePriceList.SetDefaultListAndRefreshGridControl();
                SynProductPurchasePrices();
                ProductFilesList.SetDefaultListAndRefreshGridControl();
                ICProductComponentsList.SetDefaultListAndRefreshGridControl();
                ProductMeasureUnitList.SetDefaultListAndRefreshGridControl();
                ProductTolenrancesList.SetDefaultListAndRefreshGridControl();
                InitTolenranceList(0);
            }
            catch (Exception)
            {
                return;
            }
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

        public void InitTolenranceList(int iObjectID)
        {
            ICProductTolenrancesController objProductTolenrancesController = new ICProductTolenrancesController();
            List<ICProductTolenrancesInfo> productTolenrancesList = objProductTolenrancesController.GetProductTolenranceByProductID(iObjectID);
            ProductTolenrancesList.Invalidate(productTolenrancesList);
        }
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
            ICProductItemsList.Duplicate();
            ICProductPricesList.Duplicate();
            ICProductSuppliersList.Duplicate();
            ProductBranchPriceList.Duplicate();
            ICProductComponentsList.Duplicate();
            foreach (ICProductBranchPricesInfo productPrice in ProductBranchPriceList)
            {
                productPrice.ICProductBranchPrice = 0;
            }
            ProductPurchasePriceList.Duplicate();
            ProductTolenrancesList.Duplicate();
        }

        #endregion

        #region Invalidate Module Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {

            InvalidateProductPriceLevels(iObjectID);

            ICProductUnitsList.Invalidate(iObjectID);

            ICProductSuppliersList.Invalidate(iObjectID);

            ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
            List<ICProductBranchPricesInfo> productSellingPrices = objProductBranchPricesController.GetProductBranchPriceByProductIDAndType(iObjectID, ProductBranchPriceType.Sale.ToString());
            ProductBranchPriceList.Invalidate(productSellingPrices);

            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            List<ICProductComponentsInfo> productComponentsList = objProductComponentsController.GetProductComponentListByProductID(iObjectID);
            ICProductComponentsList.Invalidate(productComponentsList);

            InvalidateProductPurchasePrices(iObjectID);
            ICProductItemsList.Invalidate(iObjectID);

            List<ICProductFilesInfo> productFiles = ApiClientHelper.GetImages(iObjectID);
            if (productFiles != null)
                ProductFilesList.Invalidate(productFiles);
            ProductMeasureUnitList.Invalidate(iObjectID);

            InitTolenranceList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            //Boolean newProduct = false;
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.FK_ICProductSaleUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.FK_ICProductPurchaseUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.HasComponent = false;
            if (ICProductComponentsList.Count > 0)
            {
                objProductsInfo.HasComponent = true;
            }
            if (objProductsInfo.ICProductID > 0)
            {
                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
                GENumberingController objNumberingController = new GENumberingController();
                //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], START
                //GENumberingInfo objNumberingInfo = (GENumberingInfo)objNumberingController.GetObjectByName(Module.Name);
                GENumberingInfo objNumberingInfo;
                objNumberingInfo = objNumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                //List<GENumberingInfo> nuberingList = objNumberingController.GetNumberingListByName(Module.Name);
                //if (nuberingList.Count == 1)
                //{
                //    objNumberingInfo = nuberingList[0];
                //}
                //else
                //{
                //    objNumberingInfo = nuberingList.Where(i => i.FK_BRBranchID == BOSApp.CurrentCompanyInfo.FK_BRBranchID).FirstOrDefault();
                //}
                //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], END
                if (objDepartmentsInfo != null && objProductGroupsInfo != null && objNumberingInfo != null && objProductsInfo.ICProductNo.Length > objNumberingInfo.GENumberingLength
                    && objProductsInfo.ICProductNo == "***NEW***")
                {
                    objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                    objProductsInfo.ICProductNo = objDepartmentsInfo.ICDepartmentNo + objProductGroupsInfo.ICProductGroupNo + objProductsInfo.ICProductNo.Substring(objProductsInfo.ICProductNo.Length - objNumberingInfo.GENumberingLength);
                    objProductsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo;
                }
            }
            //else
            //{
            //    newProduct = true;
            //}

            int rtn = base.SaveMainObject();
            if (rtn > 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfoUpdateBarCode = (ICProductsInfo)objProductsController.GetObjectByID(rtn);
                if (objProductsInfo != null)
                {
                    objProductsInfoUpdateBarCode.ICProductBarCode = objProductsInfo.ICProductNo;
                    objProductsController.UpdateObject(objProductsInfoUpdateBarCode);
                }
            }
            return rtn;
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = GetMainObjectNoByGenerateProductNoConfig(ref numberingStart, false);
            if (!string.IsNullOrWhiteSpace(mainObjectNo))
            {
                return mainObjectNo;
            }

            string strMainObjectNo = base.GetMainObjectNo(ref numberingStart);
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            List<string> itemStrNo = new List<string>();
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            string departmentNo = objDepartmentsController.GetObjectNoByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo rootInfo = objProductGroupsController.GetRootGroupByGroup(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
            string rootNo = rootInfo != null ? rootInfo.ICProductGroupNo : string.Empty;
            string productGroupNo = objProductGroupsController.GetObjectNoByID(objProductsInfo.FK_ICProductGroupID);
            
            itemStrNo.Add(departmentNo);
            itemStrNo.Add(rootNo);
            itemStrNo.Add(productGroupNo);
            itemStrNo.Add(strMainObjectNo);

            strMainObjectNo = string.Join("", itemStrNo.ToArray());
            return strMainObjectNo;
        }
        public override void SaveModuleObjects()
        {
            SaveProductItems();
            SaveProductComponent();
            ICProductPricesList.SaveItemObjects();
            ICProductUnitsList.SaveItemObjects();
            ICProductSuppliersList.SaveItemObjects();

            ProductBranchPriceList.SaveItemObjects();
            ProductPurchasePriceList.SaveItemObjects();
            ProductMeasureUnitList.SaveItemObjects();
            ProductTolenrancesList.SaveItemObjects();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductType = ADConfigValueUtility.GetFirstConfigValueByGroup(ConfigValueGroup.ProductType);
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.NoneSpecific.ToString();
            objProductsInfo.ICProductIsFollowInventoryStock = true;
            ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)BOSApp.GetFirstObjectFromLookupTable(TableName.ICMeasureUnitsTableName);
            if (objMeasureUnitsInfo != null)
            {
                objProductsInfo.FK_ICProductBasicUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }
            // objProductsInfo.ICProductHasBeenInProdNorm = false;
            //objProductsInfo.ICProductIdentifyWoodType = true;
            //objProductsInfo.ICProductIdentifyFirstAndLastName = true;
            objProductsInfo.ICProductType = ProductType.Hardware.ToString();
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
        public void SaveProductItems()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            int sortOrder = 0;
            foreach (ICProductItemsInfo objProductComponentsInfo in ICProductItemsList)
            {
                sortOrder++;
                objProductComponentsInfo.FK_ICProductItemParentID = objProductsInfo.ICProductID;
                objProductComponentsInfo.ICProductItemSortOrder = sortOrder;
            }
            ICProductItemsList.SaveItemObjects();
        }

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

        public void UpdateProductItem()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            ICProductItemsInfo objProductItemsInfo = new ICProductItemsInfo();
            ICProductsInfo objProductParentsInfo = new ICProductsInfo();
            List<ICProductItemsInfo> productItemList = new List<ICProductItemsInfo>();
            ICProductItemsController objProductItemsController = new ICProductItemsController();
            ICProductsController objProductsController = new ICProductsController();
            if (objProductsInfo.FK_ICProductGroupParentID > 0)
            {
                int count = 0;
                int sortOrder = 0;
                if (objProductsInfo.ICProductID > 0)
                {
                    DataSet ds = objProductItemsController.GetAllDataByForeignColumn("FK_ICProductItemParentID", objProductsInfo.FK_ICProductGroupParentID);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        productItemList = (List<ICProductItemsInfo>)objProductItemsController.GetListFromDataSet(ds);
                    }
                    if (productItemList != null && productItemList.Count > 0)
                    {
                        sortOrder = productItemList.Count;
                        productItemList = productItemList.Where(x => x.FK_ICProductItemChildID == objProductsInfo.ICProductID).ToList();
                        if (productItemList != null)
                            count = productItemList.Count;
                    }

                    if (count == 0)
                    {
                        objProductItemsInfo.FK_ICProductItemChildID = objProductsInfo.ICProductID;
                        objProductItemsInfo.FK_ICProductItemParentID = objProductsInfo.FK_ICProductGroupParentID;
                        objProductItemsInfo.ICProductItemSortOrder = sortOrder + 1;
                        objProductItemsInfo.ICProductItemQty = 1;
                        objProductItemsController.CreateObject(objProductItemsInfo);

                        //Update parent HasComponent
                        objProductParentsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductsInfo.FK_ICProductGroupParentID);
                        if (objProductParentsInfo != null && objProductParentsInfo.ICProductID > 0)
                        {
                            objProductParentsInfo.HasComponent = true;
                            objProductsController.UpdateObject(objProductParentsInfo);
                        }
                    }
                }
            }
        }
        #endregion

        public void UpdateImages()
        {
            ICProductFilesController objProductFilesController = new ICProductFilesController();

            ICProductsInfo mainObject = (ICProductsInfo)MainObject;
            List<ICProductFilesInfo> productFiles = objProductFilesController.GetICProductFilesByProductID(mainObject.ICProductID);

            List<ICProductFilesInfo> productFilesAdd = new List<ICProductFilesInfo>();
            List<ICProductFilesInfo> productFilesDelete = new List<ICProductFilesInfo>();
            productFilesAdd = ProductFilesList.Where(o => o.ICProductFileName == new Guid()).ToList();
            productFilesDelete = productFiles.Where(o => !ProductFilesList.Any(s => s.ICProductFileName == o.ICProductFileName)).ToList();
            if (productFilesAdd.Count > 0)
            {

                ApiClientHelper.AddImage(productFilesAdd.Where(o => o.IsDefault == false).Select(o => o.ICProductFilePath).ToList(), mainObject.ICProductID);
                ApiClientHelper.UpdatePrimaryImage(productFilesAdd.Where(o => o.IsDefault == true).FirstOrDefault().ICProductFilePath, mainObject.ICProductID);
            }
        }

    }
}