using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.OtherProduct
{
    public class OtherProductEntities : ERPModuleEntities
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
        /// <summary>
        /// Gets or sets product branch price list
        /// </summary>
        public BOSList<ICProductBranchPricesInfo> ProductBranchPriceList { get; set; }

        /// <summary>
        /// Gets or sets edit purchase price by currency list
        /// </summary>
        public BOSList<ICProductBranchPricesInfo> ProductPurchasePriceList { get; set; }

        /// <summary>
        /// Gets or sets history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSList<ICProductComponentsInfo> ICProductComponentsList { get; set; }

        public BOSList<ICProductPricesInfo> ICProductPricesList { get; set; }

        public ICProductUnitsInfo ICProductUnitsObject { get; set; }

        public BOSList<ICProductUnitsInfo> ICProductUnitsList { get; set; }

        /// <summary>
        /// Gets or sets suppliers of product
        /// </summary>
        public BOSList<ICProductSuppliersInfo> ICProductSuppliersList { get; set; }

        public BOSList<ICProductMeasureUnitsInfo> ProductMeasureUnitList { get; set; }
        public BOSList<ICProductOperationsInfo> ProductOperationList { get; set; }
        public BOSList<ICProductMachinesInfo> ProductMachineList { get; set; }
        public BOSList<ICProductSemisInfo> ProductSemiList { get; set; }
        public BOSList<ICProductTolenrancesInfo> ProductTolenrancesList { get; set; }
        #endregion

        #region Constructor
        public OtherProductEntities()
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
            ProductMeasureUnitList = new BOSList<ICProductMeasureUnitsInfo>();
            ProductOperationList = new BOSList<ICProductOperationsInfo>();
            ProductMachineList = new BOSList<ICProductMachinesInfo>();
            ProductSemiList = new BOSList<ICProductSemisInfo>();
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
            ModuleObjects.Add(TableName.ICProductMeasureUnitsTableName, new ICProductMeasureUnitsInfo());
            ModuleObjects.Add("ICProductOperations", new ICProductOperationsInfo());
            ModuleObjects.Add("ICProductMachines", new ICProductMachinesInfo());
            ModuleObjects.Add("ICProductSemis", new ICProductSemisInfo());
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

            ProductMeasureUnitList.InitBOSList(this,
                                                TableName.ICProductsTableName,
                                                TableName.ICProductMeasureUnitsTableName,
                                                BOSList<ICProductMeasureUnitsInfo>.cstRelationForeign);
            ProductMeasureUnitList.ItemTableForeignKey = "FK_ICProductID";
            ProductOperationList.InitBOSList(this,
                                       TableName.ICProductsTableName,
                                       "ICProductOperations",
                                       BOSList<ICProductOperationsInfo>.cstRelationForeign);
            ProductOperationList.ItemTableForeignKey = "FK_ICProductID";

            ProductMachineList.InitBOSList(this,
                                       TableName.ICProductsTableName,
                                       "ICProductMachines",
                                       BOSList<ICProductMachinesInfo>.cstRelationForeign);
            ProductMachineList.ItemTableForeignKey = "FK_ICProductID";

            ProductSemiList.InitBOSList(this,
                                       TableName.ICProductsTableName,
                                       "ICProductSemis",
                                       BOSList<ICProductSemisInfo>.cstRelationForeign);
            ProductSemiList.ItemTableForeignKey = "FK_ICProductID";
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
            ProductMeasureUnitList.InitBOSListGridControl();
            ProductOperationList.InitBOSListGridControl();
            ProductMachineList.InitBOSListGridControl();
            ProductSemiList.InitBOSListGridControl();
            ProductTolenrancesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductType = ProductType.Equipment.ToString();
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.NoneSpecific.ToString();
            objProductsInfo.FK_ICPriceCalculationMethodID = (new ICPriceCalculationMethodsController()).GetPriceCalculationMethodDefault().ICPriceCalculationMethodID;
            ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)BOSApp.GetFirstObjectFromLookupTable(TableName.ICMeasureUnitsTableName);
            if (objMeasureUnitsInfo != null)
            {
                objProductsInfo.FK_ICProductBasicUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }
            ACAccountsController accountController = new ACAccountsController();
            ACAccountsInfo account = accountController.GetObjectByNo(AccountDefault.DefaultAccount.ToString()) as ACAccountsInfo;
            if (account != null)
                objProductsInfo.FK_ACAccountID = account.ACAccountID;
            objProductsInfo.ICProductOriginOfProduct = ProductOrigin.DomesticPurchase.ToString();
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
                SynProductPurchasePrices();
                ProductMeasureUnitList.SetDefaultListAndRefreshGridControl();
                ProductOperationList.SetDefaultListAndRefreshGridControl();
                ProductMachineList.SetDefaultListAndRefreshGridControl();
                ProductSemiList.SetDefaultListAndRefreshGridControl();
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
            foreach (ICProductBranchPricesInfo productPrice in ProductBranchPriceList)
            {
                productPrice.ICProductBranchPrice = 0;
            }
            ProductPurchasePriceList.Duplicate();
            ProductMachineList.Duplicate();
            ProductOperationList.Duplicate();
            ProductSemiList.Duplicate();
            ProductTolenrancesList.Duplicate();
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
            ProductMeasureUnitList.Invalidate(iObjectID);
            if (objProductsInfo.ICProductType == ProductType.Equipment.ToString() ||
                objProductsInfo.ICProductType == ProductType.MMTB.ToString())
            {
                if (objProductsInfo.ICProductType == ProductType.MMTB.ToString())
                    ProductOperationList.Invalidate(iObjectID);
                ProductSemiList.Invalidate(iObjectID);
                ProductMachineList.Invalidate(iObjectID);
            }
            InitTolenranceList(iObjectID);

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.FK_ICProductSaleUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.FK_ICProductPurchaseUnitID = objProductsInfo.FK_ICProductBasicUnitID;
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

        public void SavePrimaryImage(string url)
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            if (string.IsNullOrEmpty(url))
                return;

            ApiClientHelper.UpdatePrimaryImage(url, objProductsInfo.ICProductID);
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
            SaveProductComponent();
            ICProductPricesList.SaveItemObjects();
            ICProductUnitsList.SaveItemObjects();
            ICProductSuppliersList.SaveItemObjects();

            ProductBranchPriceList.SaveItemObjects();
            ProductPurchasePriceList.SaveItemObjects();
            ProductMeasureUnitList.SaveItemObjects();
            ProductOperationList.SaveItemObjects();
            ProductSemiList.SaveItemObjects();
            ProductMachineList.SaveItemObjects();
            ProductTolenrancesList.SaveItemObjects();
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
    }
}
