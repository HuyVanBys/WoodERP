using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.WoodMaterialsProduct
{
    class WoodMaterialsProductEntities : ERPModuleEntities
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
        public BOSList<ICProductMeasureUnitsInfo> ProductMeasureUnitList { get; set; }

        #endregion

        #region Constructor
        public WoodMaterialsProductEntities()
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
            ProductMeasureUnitList = new BOSList<ICProductMeasureUnitsInfo>();
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
            ProductMeasureUnitList.InitBOSList(this,
                                    TableName.ICProductsTableName,
                                    TableName.ICProductMeasureUnitsTableName,
                                    BOSList<ICProductMeasureUnitsInfo>.cstRelationForeign);
            ProductMeasureUnitList.ItemTableForeignKey = "FK_ICProductID";


        }
        public override void InitGridControlInBOSList()
        {

            ICProductItemsList.InitBOSListGridControl();
            ICProductSuppliersList.InitBOSListGridControl();
            ProductBranchPriceList.InitBOSListGridControl();
            //HistoryDetailList.InitBOSListGridControl();
            //ProductPurchasePriceList.InitBOSListGridControl(); 
            ProductMeasureUnitList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

                ICProductItemsList.SetDefaultListAndRefreshGridControl();
                ICProductSuppliersList.SetDefaultListAndRefreshGridControl();
                //ICProductUnitsList.SetDefaultListAndRefreshGridControl();

                ICProductPricesList.SetDefaultListAndRefreshGridControl();
                //SynProductPriceLevels();

                //ProductBranchPriceList.SetDefaultListAndRefreshGridControl();

                // ProductPurchasePriceList.SetDefaultListAndRefreshGridControl();
                //SynProductPurchasePrices(); 
                ProductMeasureUnitList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions

        //public override void SetMainObjectInfo(int iObjectID)
        //{
        //    ICProductsController productController = new ICProductsController();
        //    MainObject = productController.GetProductByID(iObjectID);
        //}

        public override void InvalidateModuleObjects(int iObjectID)
        {

            //InvalidateProductPriceLevels(iObjectID);

            //ICProductUnitsList.Invalidate(iObjectID);

            ICProductSuppliersList.Invalidate(iObjectID);

            ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
            List<ICProductBranchPricesInfo> productSellingPrices = objProductBranchPricesController.GetProductBranchPriceByProductIDAndType(iObjectID, ProductBranchPriceType.Sale.ToString());
            //ProductBranchPriceList.Invalidate(productSellingPrices);

            //InvalidateProductPurchasePrices(iObjectID);
            //ICProductItemsList.Invalidate(iObjectID);
            ProductMeasureUnitList.Invalidate(iObjectID);

        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            SaveProductComponent();
            ICProductPricesList.SaveItemObjects();
            ICProductUnitsList.SaveItemObjects();
            ICProductSuppliersList.SaveItemObjects();

            ProductBranchPriceList.SaveItemObjects();
            ProductPurchasePriceList.SaveItemObjects();
            ProductMeasureUnitList.SaveItemObjects();
        }
        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            int rtn = base.SaveMainObject();

            return rtn;
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string productNo = base.GetMainObjectNo(ref numberingStart);
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.FK_ICProductSaleUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.FK_ICProductPurchaseUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            if (objProductGroupsInfo != null)
            {
                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                productNo = string.Format("{0}{1}", objProductGroupsInfo.ICProductGroupNo, productNo);
            }
            if (objDepartmentsInfo != null)
            {
                productNo = string.Format("{0}{1}", objDepartmentsInfo.ICDepartmentNo, productNo);
            }
            return productNo;
        }

        #endregion
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductType = ProductType.SemiProduct.ToString();
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.NoneSpecific.ToString();
            ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)BOSApp.GetFirstObjectFromLookupTable(TableName.ICMeasureUnitsTableName);
            if (objMeasureUnitsInfo != null)
            {
                objProductsInfo.FK_ICProductBasicUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }
            // objProductsInfo.ICProductHasBeenInProdNorm = false;
            //objProductsInfo.ICProductIdentifyWoodType = true;
            //objProductsInfo.ICProductIdentifyFirstAndLastName = true;
            objProductsInfo.ICProductType = ProductType.SemiProduct.ToString();

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
        public void SaveProductComponent()
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

        public void SavePrimaryImage(string url)
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            if (string.IsNullOrEmpty(url))
                return;

            ApiClientHelper.UpdatePrimaryImage(url, objProductsInfo.ICProductID);
        }
        #endregion

    }
}