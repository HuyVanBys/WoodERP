using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.LumberProduct
{
    public class LumberProductEntities : ERPModuleEntities
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

        public BOSList<ICProductBranchPricesInfo> ProductPurchasePriceList { get; set; }

        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSList<ICProductComponentsInfo> ICProductComponentsList { get; set; }

        public BOSList<ICProductPricesInfo> ICProductPricesList { get; set; }

        public ICProductUnitsInfo ICProductUnitsObject { get; set; }

        public BOSList<ICProductUnitsInfo> ICProductUnitsList { get; set; }

        public BOSList<ICProductAlternativesInfo> ProductAlternativesList { get; set; }

        public BOSList<ICProductOutsourcingsInfo> ProductOutsourcingList { get; set; }

        public BOSList<ICProductSuppliersInfo> ICProductSuppliersList { get; set; }

        public BOSList<ICProductMeasureUnitsInfo> ProductMeasureUnitList { get; set; }
        public BOSList<ICProductTolenrancesInfo> ProductTolenrancesList { get; set; }

        #endregion

        #region Constructor
        public LumberProductEntities()
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

            ProductAlternativesList = new BOSList<ICProductAlternativesInfo>();
            ProductOutsourcingList = new BOSList<ICProductOutsourcingsInfo>();
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
            ModuleObjects.Add(TableName.ICProductAlternativesTableName, new ICProductAlternativesInfo());
            ModuleObjects.Add(TableName.ICProductOutsourcingsTableName, new ICProductOutsourcingsInfo());
            ModuleObjects.Add(TableName.ICProductMeasureUnitsTableName, new ICProductMeasureUnitsInfo());
        }

        public override void InitModuleObjectList()
        {
            ICProductComponentsList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductComponentsTableName,
                                                BOSList<ICProductComponentsInfo>.cstRelationForeign);
            ICProductComponentsList.ItemTableForeignKey = "FK_ICProductID";

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

            ProductAlternativesList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductAlternativesTableName,
                                                BOSList<ICProductAlternativesInfo>.cstRelationForeign);
            ProductAlternativesList.ItemTableForeignKey = "FK_ICProductAlternativeParentID";

            ProductOutsourcingList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductOutsourcingsTableName,
                                                BOSList<ICProductOutsourcingsInfo>.cstRelationForeign);
            ProductOutsourcingList.ItemTableForeignKey = "FK_ICProductOutsourcingParentID";

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
            ICProductComponentsList.InitBOSListGridControl();
            ICProductSuppliersList.InitBOSListGridControl();
            ProductBranchPriceList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            ProductPurchasePriceList.InitBOSListGridControl();
            ProductAlternativesList.InitBOSListGridControl("fld_dgcICProductAlternativesGridControl");
            ProductOutsourcingList.InitBOSListGridControl("fld_dgcICProductOutsourcingsGridControl");
            ProductMeasureUnitList.InitBOSListGridControl();
            ProductTolenrancesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.NoneSpecific.ToString();
            objProductsInfo.ICProductIsFollowInventoryStock = true;
            ADConfigValuesController configValuesController = new ADConfigValuesController();
            objProductsInfo.ICProductOriginOfProduct = configValuesController.GetObjectByGroupAndValue(ConfigValueGroup.ProductOriginOfProduct, "DomesticPurchase").ADConfigKeyValue;
            ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)BOSApp.GetFirstObjectFromLookupTable(TableName.ICMeasureUnitsTableName);
            if (objMeasureUnitsInfo != null)
            {
                objProductsInfo.FK_ICProductBasicUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }
            ACAccountsController accountController = new ACAccountsController();
            ACAccountsInfo account = accountController.GetObjectByNo(AccountDefault.DefaultAccount.ToString()) as ACAccountsInfo;
            if (account != null)
                objProductsInfo.FK_ACAccountID = account.ACAccountID;
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
            try
            {
                ICProductComponentsList.SetDefaultListAndRefreshGridControl();
                ICProductSuppliersList.SetDefaultListAndRefreshGridControl();
                ICProductUnitsList.SetDefaultListAndRefreshGridControl();

                ICProductPricesList.SetDefaultListAndRefreshGridControl();
                SynProductPriceLevels();

                ProductBranchPriceList.SetDefaultListAndRefreshGridControl();

                ProductPurchasePriceList.SetDefaultListAndRefreshGridControl();
                ProductAlternativesList.SetDefaultListAndRefreshGridControl();
                ProductOutsourcingList.SetDefaultListAndRefreshGridControl();
                ProductMeasureUnitList.SetDefaultListAndRefreshGridControl();
                ProductTolenrancesList.SetDefaultListAndRefreshGridControl();
                SynProductPurchasePrices();
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
            ProductAlternativesList.Duplicate();
            ProductOutsourcingList.Duplicate();
            foreach (ICProductBranchPricesInfo productPrice in ProductBranchPriceList)
            {
                productPrice.ICProductBranchPrice = 0;
            }
            ProductPurchasePriceList.Duplicate();
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

            InvalidateProductPurchasePrices(iObjectID);

            ICProductAlternativesController objProductAlternativesController = new ICProductAlternativesController();
            List<ICProductAlternativesInfo> productAlternativeList = objProductAlternativesController.GetAllObjectByProductParentID(iObjectID);
            ProductAlternativesList.Invalidate(productAlternativeList);

            ICProductOutsourcingsController objProductOutsourcingsController = new ICProductOutsourcingsController();
            List<ICProductOutsourcingsInfo> productOutsourcingsList = objProductOutsourcingsController.GetAllObjectByProductParentID(iObjectID);
            ProductOutsourcingList.Invalidate(productOutsourcingsList);
            ProductMeasureUnitList.Invalidate(iObjectID);

            ICProductTolenrancesController objProductTolenrancesController = new ICProductTolenrancesController();
            List<ICProductTolenrancesInfo> productTolenrancesList = objProductTolenrancesController.GetProductTolenranceByProductID(iObjectID);
            ProductTolenrancesList.Invalidate(productTolenrancesList);
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
                ICProductsInfo oldProductsInfo = (ICProductsInfo)MainObject.OldObject;
                if (objProductsInfo.FK_ICDepartmentID != oldProductsInfo.FK_ICDepartmentID || objProductsInfo.FK_ICProductGroupID != oldProductsInfo.FK_ICProductGroupID)
                {
                    int currentNumber = objProductsInfo.ICProductCreateNumber;
                    string mainObjectNo = GetMainObjectNoByGenerateProductNoConfig(ref currentNumber, true);

                    if (string.IsNullOrWhiteSpace(mainObjectNo))
                    {
                        mainObjectNo = GetMainObjectNo(ref currentNumber);
                    }

                    if (!string.IsNullOrWhiteSpace(mainObjectNo))
                        objProductsInfo.ICProductNo = mainObjectNo;
                }
            }
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

        public void SavePrimaryImage()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            if (string.IsNullOrEmpty(objProductsInfo.ICProductPrimaryPath))
                return;
            ApiClientHelper.UpdatePrimaryImage(objProductsInfo.ICProductPrimaryPath, objProductsInfo.ICProductID);
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
            SaveProductComponent();
            SaveProductAlternatives();
            SaveProductOutsourcing();
            ICProductPricesList.SaveItemObjects();
            ICProductUnitsList.SaveItemObjects();
            ICProductSuppliersList.SaveItemObjects();

            ProductBranchPriceList.SaveItemObjects();
            ProductPurchasePriceList.SaveItemObjects();
            ProductMeasureUnitList.SaveItemObjects();
            ProductTolenrancesList.SaveItemObjects();
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

        public void SaveProductAlternatives()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            int sortOrder = 0;
            foreach (ICProductAlternativesInfo item in ProductAlternativesList)
            {
                sortOrder++;
                item.FK_ICProductAlternativeParentID = objProductsInfo.ICProductID;
                item.ICProductAlternativeSortOrder = sortOrder;
            }
            ProductAlternativesList.SaveItemObjects();
        }

        public void SaveProductOutsourcing()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            int sortOrder = 0;
            foreach (ICProductOutsourcingsInfo item in ProductOutsourcingList)
            {
                sortOrder++;
                item.FK_ICProductOutsourcingParentID = objProductsInfo.ICProductID;
                item.ICProductOutsourcingSortOrder = sortOrder;
            }
            ProductOutsourcingList.SaveItemObjects();
        }



        #endregion
    }
}
