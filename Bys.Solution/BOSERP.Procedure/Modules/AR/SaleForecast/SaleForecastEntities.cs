using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace BOSERP.Modules.SaleForecast
{
    public class SaleForecastEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        public BOSItemsEntityList<ARSaleForecastItemsInfo> ARSaleForecastItemsList { get; set; }

        public BOSList<ARCustomerPaymentDetailsInfo> ARCustomerPaymentDetailsList { get; set; }

        public SortedList<int, ARProposalItemsInfo> ARReferenceProposalItems { get; set; }

        /// <summary>
        /// Gets or sets sale order template list
        /// </summary>
        public BOSList<ARSaleForecastTemplatesInfo> SaleForecastTemplatesList { get; set; }

        /// <summary>
        /// Gets or sets document payment list
        /// </summary>
        public BOSList<ARDocumentPaymentsInfo> DocumentPaymentList { get; set; }

        /// <summary>
        /// Gets or sets sale order item list including the item's components
        /// </summary>
        public BOSItemsEntityList<ARSaleForecastItemsInfo> ComponentSaleForecastItemList { get; set; }
        #endregion

        #region Constructor
        public SaleForecastEntities()
            : base()
        {
            ARSaleForecastItemsList = new BOSItemsEntityList<ARSaleForecastItemsInfo>();
            SaleForecastTemplatesList = new BOSList<ARSaleForecastTemplatesInfo>();
            ARReferenceProposalItems = new SortedList<int, ARProposalItemsInfo>();

            DocumentPaymentList = new BOSList<ARDocumentPaymentsInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();

            ComponentSaleForecastItemList = new BOSItemsEntityList<ARSaleForecastItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = new ARSaleForecastsInfo();
            SearchObject = new ARSaleForecastsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARSaleForecastItemsTableName, new ARSaleForecastItemsInfo());
            ModuleObjects.Add(TableName.ARDocumentPaymentsTableName, new ARDocumentPaymentsInfo());
        }

        public override void InitModuleObjectList()
        {
            ARSaleForecastItemsList = new BOSItemsEntityList<ARSaleForecastItemsInfo>();
            ARSaleForecastItemsList.InitBOSList(this, TableName.ARSaleForecastsTableName, TableName.ARSaleForecastItemsTableName);

            DocumentPaymentList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.ARDocumentPaymentsTableName,
                                          BOSList<ARInvoicesInfo>.cstRelationNone);
            HistoryDetailList.InitBOSList(this,
                                           TableName.GEObjectHistoryTableName,
                                           TableName.GEHistoryDetailsTableName,
                                           BOSList<GEHistoryDetailsInfo>.cstRelationForeign);

            SaleForecastTemplatesList.InitBOSList(
                                        this,
                                        TableName.ARSaleForecastsTableName,
                                        TableName.ARSaleForecastTemplatesTableName,
                                        BOSList<ARSaleForecastTemplatesInfo>.cstRelationForeign);

            ComponentSaleForecastItemList.InitBOSList(
                                                this,
                                                TableName.ARSaleForecastsTableName,
                                                TableName.ARSaleForecastItemsTableName,
                                                BOSList<ARSaleForecastItemsInfo>.cstRelationForeign);
            ComponentSaleForecastItemList.ItemTableForeignKey = "FK_ARSaleForecastID";
        }

        public override void InitGridControlInBOSList()
        {
            ARSaleForecastItemsList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            DocumentPaymentList.InitBOSListGridControl();
            SaleForecastTemplatesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ARSaleForecastItemsList.SetDefaultListAndRefreshGridControl();
                DocumentPaymentList.SetDefaultListAndRefreshGridControl();
                ComponentSaleForecastItemList.SetDefaultListAndRefreshGridControl();
                SaleForecastTemplatesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            objSaleForecastsInfo.ARSaleForecastTypeCombo = SaleForecastType.SaleForecast.ToString();
            objSaleForecastsInfo.ARSaleForecastDate = DateTime.Now;
            objSaleForecastsInfo.ARSaleForecastDeliveryDate = DateTime.Now;
            objSaleForecastsInfo.ARSaleForecastValidateDate = DateTime.Now;
            objSaleForecastsInfo.ARSaleForecastStatus = SaleForecastStatus.New.ToString();
            objSaleForecastsInfo.FK_ARPriceLevelID = 1;
            objSaleForecastsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleForecastsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objSaleForecastsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objSaleForecastsInfo.ARSaleForecastExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objSaleForecastsInfo.ARSaleForecastProductType = ProductType.Product.ToString();
            objSaleForecastsInfo.ARSaleForecastMainSellerCommissionPercent = 100;
            objSaleForecastsInfo.FK_GECurrencyID2 = 100001;
            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            GECurrencyExchangeRatesInfo objCurrencyExchangeRatesInfo = objCurrencyExchangeRatesController.GetCurrencyExchangeRateByCurrencyIDAnddate(objSaleForecastsInfo.FK_GECurrencyID2, objSaleForecastsInfo.ARSaleForecastDate);
            if (objCurrencyExchangeRatesInfo != null)
                objSaleForecastsInfo.ARSaleForecastExchangeRate2 = objCurrencyExchangeRatesInfo.GECurrencyExchangeRateExchangeRate;
            else
                objSaleForecastsInfo.ARSaleForecastExchangeRate2 = 1;
            objSaleForecastsInfo.ARSaleForecastExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions


        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();

            DataSet ds = objSaleForecastItemsController.GetAllDataBySaleForecastID(iObjectID);
            ARSaleForecastItemsList.Invalidate(ds);
            foreach (ARSaleForecastItemsInfo objSaleForecastItemsInfo in ARSaleForecastItemsList)
            {
                if (objSaleForecastItemsInfo.ComponentCount > 0)
                {
                    objSaleForecastItemsInfo.ARSFItemComponentList = new BOSList<ARSFItemComponentsInfo>();
                    objSaleForecastItemsInfo.ARSFItemComponentList.InitBOSList(
                                                                        this,
                                                                        TableName.ARSaleForecastItemsTableName,
                                                                        TableName.ARSFItemComponentsTableName,
                                                                        BOSList<ARSFItemComponentsInfo>.cstRelationForeign);
                    objSaleForecastItemsInfo.ARSFItemComponentList.ItemTableForeignKey = "FK_ARSaleForecastItemID";

                    ARSFItemComponentsController objSFItemComponentsController = new ARSFItemComponentsController();
                    List<ARSFItemComponentsInfo> components = objSFItemComponentsController.GetSFItemComponentListBySFItemID(objSaleForecastItemsInfo.ARSaleForecastItemID);
                    objSaleForecastItemsInfo.ARSFItemComponentList.Invalidate(components);
                }
            }
            //Invalidate document payment list by sale order no
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            List<ARDocumentPaymentsInfo> payments = objDocumentPaymentsController.GetDocumentPaymentsBySaleForecastNo(objSaleForecastsInfo.ARSaleForecastNo);
            DocumentPaymentList.Invalidate(payments);

            //Invalidate item components
            InvalidateItemComponents();

            ComponentSaleForecastItemList.BackupList.Clear();
            if (objSaleForecastsInfo.ARSaleForecastStatus == SaleForecastStatus.Confirmed.ToString() ||
                objSaleForecastsInfo.ARSaleForecastStatus == SaleForecastStatus.Incomplete.ToString())
            {
                foreach (ARSaleForecastItemsInfo item in ComponentSaleForecastItemList)
                {
                    ComponentSaleForecastItemList.BackupList.Add((ARSaleForecastItemsInfo)item.Clone());
                }
            }

            //Invalidate sale order templates list
            SaleForecastTemplatesList.Invalidate(iObjectID);
            foreach (ARSaleForecastTemplatesInfo objSaleForecastTemplatesInfo in SaleForecastTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objSaleForecastTemplatesInfo.AACreatedUser);
                string SaleForecastID = objSaleForecastTemplatesInfo.FK_ARSaleForecastID.ToString();
                objSaleForecastTemplatesInfo.ARSaleForecastTemplateName = objSaleForecastTemplatesInfo.ARSaleForecastTemplateName.Replace(SaleForecastID + "_", "");
                objSaleForecastTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }
            ds.Dispose();
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ARSaleForecastItemsList.SaveItemObjects();

            // Save sale order item component list
            SaveSFItemComponentList(ARSaleForecastItemsList);
        }

        /// <summary>
        /// Save sale order item component list
        /// </summary>
        /// <param name="SaleForecastItems">List of sale forecast item component</param>
        public void SaveSFItemComponentList(BOSItemsEntityList<ARSaleForecastItemsInfo> saleForecastItems)
        {
            foreach (ARSaleForecastItemsInfo itemEntity in saleForecastItems)
            {
                if (itemEntity.ARSFItemComponentList != null)
                {
                    foreach (ARSFItemComponentsInfo objSFItemComponentsInfo in itemEntity.ARSFItemComponentList)
                    {
                        objSFItemComponentsInfo.FK_ARSaleForecastItemID = itemEntity.ARSaleForecastItemID;
                    }
                    itemEntity.ARSFItemComponentList.SaveItemObjects();
                }
            }
        }

        public void UpdateReferenceProposal()
        {
            ARProposalItemsController objProposalItemsController = new ARProposalItemsController();
            foreach (ARSaleForecastItemsInfo entItem in ARSaleForecastItemsList)
            {
                if (ARReferenceProposalItems.ContainsKey(entItem.FK_ARProposalItemID))
                {
                    //Decrease quantity of the reference proposal
                    ARProposalItemsInfo objProposalItemsInfo = ARReferenceProposalItems[entItem.FK_ARProposalItemID];
                    TransactionUtil.UpdateInventoryStock(
                                    objProposalItemsInfo.FK_ICProductID,
                                    objProposalItemsInfo.FK_ICStockID,
                                    -Math.Min(entItem.ARSaleForecastItemProductQty, objProposalItemsInfo.ARProposalItemProductQtyRemained),
                                    TransactionUtil.cstInventoryProposal);

                    //Update ordered quantity of the proposal's item
                    objProposalItemsInfo.ARProposalItemProductQtyOld += Math.Min(entItem.ARSaleForecastItemProductQty, objProposalItemsInfo.ARProposalItemProductQtyRemained);
                    objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
                    objProposalItemsController.UpdateObject(objProposalItemsInfo);
                }
            }

            //Update the proposal's status
            bool isRemained = false;
            foreach (ARProposalItemsInfo objProposalItemsInfo in ARReferenceProposalItems.Values)
            {
                if (objProposalItemsInfo.ARProposalItemProductQtyRemained > 0)
                {
                    isRemained = true;
                    break;
                }
            }

            if (!isRemained)
            {
                ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
                if (!String.IsNullOrEmpty(objSaleForecastsInfo.ARSaleForecastReference))
                {
                    ARProposalsController objProposalsController = new ARProposalsController();
                    ARProposalsInfo objProposalsInfo = (ARProposalsInfo)objProposalsController.GetObjectByNo(objSaleForecastsInfo.ARSaleForecastReference);
                    if (objProposalsInfo != null)
                    {
                        objProposalsInfo.ARProposalStatus = "Ordered";
                        objProposalsController.UpdateObject(objProposalsInfo);
                    }
                }
            }
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID, BusinessObject businessObject)
        {
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(iICProductID);
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ARSaleForecastItemsInfo objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)businessObject;

            if (objProductsInfo != null)
            {
                objSaleForecastItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objSaleForecastItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID, objSaleForecastItemsInfo);
                objSaleForecastItemsInfo.ARSaleForecastItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                //objSaleForecastItemsInfo.ARSaleForecastItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(iICProductID, objSaleForecastsInfo.FK_ARCustomerID);
                objSaleForecastItemsInfo.ARSaleForecastItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
                objSaleForecastItemsInfo.FK_ICStockID = objSaleForecastsInfo.FK_ICStockID;
                objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty;
                objSaleForecastItemsInfo.ARSaleForecastItemDeliveryDate = objSaleForecastsInfo.ARSaleForecastDeliveryDate;
                objSaleForecastItemsInfo.ARSaleForecastItemDeliveryTime = objSaleForecastsInfo.ARSaleForecastDeliveryTime;
                objSaleForecastItemsInfo.ICProductUnitPrice = objSaleForecastItemsInfo.ARSaleForecastItemProductUnitPrice;
                objSaleForecastItemsInfo.ARSaleForecastItemCanceledQty = 0;
                objSaleForecastItemsInfo.ARSaleForecastItemShippedQty = 0;
                string itemwood = BOSApp.GetDisplayTextFromCatche(TableName.ICProductattributesTableName, "ICProductAttributeID", int.Parse(objProductsInfo.FK_ICProductAttributeWoodTypeID.ToString()), "ICProductAttributeValue");
                if (!string.IsNullOrEmpty(itemwood))
                    objSaleForecastItemsInfo.ARSaleForecastItemWoods = itemwood;
            }
        }
        public override decimal CalculateProductPrice(int productID, int measureUnitID)
        {
            decimal dbProductPrice = 0;
            ICProductsController objICProductsController = new ICProductsController();
            ICProductsInfo objICProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            //ARConfigOriginalUnitPricesController objcfoupController = new ARConfigOriginalUnitPricesController();
            //ARConfigOriginalUnitPricesInfo objconfig = objcfoupController.GetOriginalIsAlive();
            if (objICProductsInfo != null)
            {
                //Update the product's price by its unit
                ICProductUnitsController objProductUnitsController = new ICProductUnitsController();
                ICProductUnitsInfo objProductUnitsInfo = objProductUnitsController.GetProductUnitByProductIDAndUnitID(productID, measureUnitID);
                //if (objProductUnitsInfo != null)
                //{
                //    objICProductsInfo.ICProductPrice01 = objProductUnitsInfo.ICProductUnitPrice;
                //}

                //Update the product's price by the branch and currency
                //BOSDbUtil dbUtil = new BOSDbUtil();
                //ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
                //int currencyID = dbUtil.GetPropertyIntValue(MainObject, "FK_GECurrencyID");
                ////H Anh hach code set lại currency theo cấu hình và module
                //if (objconfig != null &&
                //    (Module.Name == ModuleName.SaleOrder
                //    //|| Module.Name == ModuleName.SaleForecast
                //    //|| Module.Name == ModuleName.Proposal
                //    ))
                //{
                //    if (objconfig.ARConfigOriginalUnitPriceHachCode)
                //    {
                //        currencyID = objconfig.FK_GECurrencyID;
                //    }
                //}

                //ICProductBranchPricesInfo objProductBranchPricesInfo = objProductBranchPricesController.GetProductPriceByProductIDAndBranchIDAndCurrencyIDAndType(
                //                                                                            productID,
                //                                                                            BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                //                                                                            currencyID,
                //                                                                            ProductBranchPriceType.Sale.ToString());
                //if (objProductBranchPricesInfo != null)
                //{
                //    objICProductsInfo.ICProductPrice01 = objProductBranchPricesInfo.ICProductBranchPrice;
                //}
                //else
                //{
                //    objICProductsInfo.ICProductPrice01 = 0;
                //}
                //Update the product's price based on price levels
                dbProductPrice = CalculateProductPriceBaseOnProductPriceLevel(objICProductsInfo);
            }

            return dbProductPrice;
        }

        public decimal CalculateProductPriceBaseOnProductPriceLevel(ICProductsInfo objICProductsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            decimal dbProductPrice = objICProductsInfo.ICProductPrice01;
            int priceLevelID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ARPriceLevelID"));
            if (priceLevelID > 0)
            {
                ICProductPricesController objProductPricesController = new ICProductPricesController();
                ICProductPricesInfo objProductPricesInfo = objProductPricesController.GetProductPriceByProductIDAndPriceLevelID(objICProductsInfo.ICProductID, priceLevelID);
                //If product has own price level
                if (objProductPricesInfo != null)
                    dbProductPrice = (1 - objProductPricesInfo.ICProductPriceMarkDown / 100) * objICProductsInfo.ICProductPrice01;
                //Else, get default price level
                else
                {
                    ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
                    ARPriceLevelsInfo objPriceLevelsInfo = (ARPriceLevelsInfo)objPriceLevelsController.GetObjectByID(priceLevelID);
                    if (objPriceLevelsInfo != null)
                        dbProductPrice = (1 - objPriceLevelsInfo.ARPriceLevelMarkDown / 100) * objICProductsInfo.ICProductPrice01;
                }
            }
            return dbProductPrice;
        }
        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of proposal
            ((ARSaleForecastsInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price based on price level
            foreach (ARSaleForecastItemsInfo entItem in ARSaleForecastItemsList)
            {
                SetProductPrice(entItem, TableName.ARSaleForecastItemsTableName);
            }
            ARSaleForecastItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            objSaleForecastsInfo.ARSaleForecastNetAmount = 0;
            objSaleForecastsInfo.ARSaleForecastSubTotalAmount = 0;
            objSaleForecastsInfo.ARSaleForecastTotalProduct = 0;
            foreach (ARSaleForecastItemsInfo entItem in ARSaleForecastItemsList)
            {
                RoundByCurrency(entItem);
                objSaleForecastsInfo.ARSaleForecastNetAmount += entItem.ARSaleForecastItemNetAmount;
                objSaleForecastsInfo.ARSaleForecastSubTotalAmount += entItem.ARSaleForecastItemTotalAmount;
                //objSaleForecastsInfo.ARSaleForecastSubTotalAmount += entItem.ARSaleForecastItemPrice;
                objSaleForecastsInfo.ARSaleForecastTotalProduct += entItem.ARSaleForecastItemProductQty;
            }
            objSaleForecastsInfo.ARSaleForecastSFCommissionAmount = objSaleForecastsInfo.ARSaleForecastSubTotalAmount * objSaleForecastsInfo.ARSaleForecastSFCommissionPercent / 100;

            BOSApp.RoundByCurrency(objSaleForecastsInfo, objSaleForecastsInfo.FK_GECurrencyID);
            if (objSaleForecastsInfo.ARSaleForecastDiscountPerCent > 0)
                objSaleForecastsInfo.ARSaleForecastDiscountFix = objSaleForecastsInfo.ARSaleForecastSubTotalAmount * objSaleForecastsInfo.ARSaleForecastDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objSaleForecastsInfo, "ARSaleForecastDiscountFix", objSaleForecastsInfo.FK_GECurrencyID);
            objSaleForecastsInfo.ARSaleForecastTaxAmount = (objSaleForecastsInfo.ARSaleForecastSubTotalAmount - objSaleForecastsInfo.ARSaleForecastDiscountFix) * objSaleForecastsInfo.ARSaleForecastTaxPercent / 100;
            BOSApp.RoundByCurrency(objSaleForecastsInfo, "ARSaleForecastTaxAmount", objSaleForecastsInfo.FK_GECurrencyID);
            objSaleForecastsInfo.ARSaleForecastTotalAmount = objSaleForecastsInfo.ARSaleForecastSubTotalAmount -
                                                        objSaleForecastsInfo.ARSaleForecastDiscountFix +
                                                        objSaleForecastsInfo.ARSaleForecastTaxAmount;
            BOSApp.RoundByCurrency(objSaleForecastsInfo, "ARSaleForecastTotalAmount", objSaleForecastsInfo.FK_GECurrencyID);
            objSaleForecastsInfo.ARSaleForecastBalanceDue = objSaleForecastsInfo.ARSaleForecastTotalAmount - objSaleForecastsInfo.ARSaleForecastDepositBalance;
            BOSApp.RoundByCurrency(objSaleForecastsInfo, "ARSaleForecastBalanceDue", objSaleForecastsInfo.FK_GECurrencyID);
            //Calculate customer comission
            decimal subTotalAmount = 0;
            foreach (ARSaleForecastItemsInfo objSaleForecastItemsInfo in ARSaleForecastItemsList)
            {
                subTotalAmount += objSaleForecastItemsInfo.ARSaleForecastItemNetAmount - objSaleForecastsInfo.ARSaleForecastDiscountFix;
            }
            decimal totalAmount = subTotalAmount;

            foreach (ARSaleForecastItemsInfo objSaleForecastItemsInfo in ARSaleForecastItemsList)
            {
                if (objSaleForecastsInfo.ARSaleForecastSaleType != SaleType.National.ToString())
                {
                    if (objSaleForecastsInfo.ARSaleForecastExchangeRate2 != 0)
                    {
                        objSaleForecastItemsInfo.ARSaleForecastItemProductUnitPrice2 = (objSaleForecastItemsInfo.ARSaleForecastItemProductUnitPrice * objSaleForecastsInfo.ARSaleForecastExchangeRate)
                                                                                        / objSaleForecastsInfo.ARSaleForecastExchangeRate2;
                    }
                }
                RoundByCurrency(objSaleForecastItemsInfo);
                objSaleForecastItemsInfo.ARSaleForecastItemTotalAmount2 = objSaleForecastItemsInfo.ARSaleForecastItemProductUnitPrice2 * objSaleForecastItemsInfo.ARSaleForecastItemProductQty;
                RoundByCurrency(objSaleForecastItemsInfo);
            }
            BOSApp.RoundByCurrency(objSaleForecastsInfo, objSaleForecastsInfo.FK_GECurrencyID);

            UpdateMainObjectBindingSource();
        }

        public void RoundByCurrency(ARSaleForecastItemsInfo obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            GECurrenciesController currencyController = new GECurrenciesController();
            //GECurrenciesInfo currency = currencyController.GetObjectByID(currencyID) as GECurrenciesInfo;
            GETablesController tableController = new GETablesController();
            if (obj != null)
            {
                string tableName = BOSUtil.GetTableNameFromBusinessObject(obj);
                List<GETablesInfo> tables = new List<GETablesInfo>();
                if (!BOSApp.RoundColTable.ContainsKey(tableName))
                {
                    DataSet ds = tableController.GetTableColumnNamesByTableName(tableName);
                    tables = (List<GETablesInfo>)tableController.GetListFromDataSet(ds);
                    BOSApp.RoundColTable.Add(tableName, ds);
                    //tables = tableController.GetColumnNamesByTableName(tableName);
                }
                else
                {
                    DataSet ds = (DataSet)BOSApp.RoundColTable[tableName];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            GETablesInfo objTablesInfo = new GETablesInfo();
                            objTablesInfo = (GETablesInfo)SqlDatabaseHelper.GetObjectFromDataRow(dr, typeof(GETablesInfo));
                            tables.Add(objTablesInfo);
                        }
                    }
                    ds.Dispose();
                }

                if (tables != null)
                {
                    foreach (GETablesInfo table in tables)
                    {
                        if (table.ColumnName != "ICProductUnitPrice" && (table.ColumnName != "ARSaleForecastItemProductUnitPrice" || objSaleForecastsInfo.FK_GECurrencyID == GECurrencyID.VND))
                        {
                            if (table.ColumnName == "ARSaleForecastItemProductUnitPrice2" || table.ColumnName == "ARSaleForecastItemTotalAmount2")
                            {
                                object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                decimal amount = 0;
                                if (value != null)
                                {
                                    amount = Convert.ToDecimal(value);
                                    amount = Math.Round(amount, BOSApp.GetDecimalNumberByCurrencyID(objSaleForecastsInfo.FK_GECurrencyID2));
                                    dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                }
                            }
                            else
                            {
                                object value = dbUtil.GetPropertyValue(obj, table.ColumnName);
                                decimal amount = 0;
                                if (value != null)
                                {
                                    amount = Convert.ToDecimal(value);
                                    amount = Math.Round(amount, BOSApp.GetDecimalNumberByCurrencyID(objSaleForecastsInfo.FK_GECurrencyID));
                                    dbUtil.SetPropertyValue(obj, table.ColumnName, amount);
                                }
                            }
                        }
                    }
                }

            }
        }

        public void SetProductPriceByProductUnitPrice(ARSaleForecastItemsInfo item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //Math Round Start
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Math Round Qty
            if (objProductsInfo != null)
            {
                if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                {
                    qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
                }
                else
                {
                    qty = Math.Round(qty, 2, MidpointRounding.AwayFromZero);
                }
            }
            //End




            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Get or set item discount percent and amount
            string discountPercentColumnName = itemTablePrefix + "ProductDiscount";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));
            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            decimal oldDiscountAmount = 0;
            if (item.OldObject == null)
            {
                item.OldObject = (BusinessObject)item.Clone();
            }
            if (item.OldObject != null)
            {
                oldDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, discountAmountColumnName));
            }
            if (discountAmount != oldDiscountAmount)
            {
                if (extPrice > 0)
                {
                    discountPercent = discountAmount / extPrice * 100;
                    dbUtil.SetPropertyValue(item, discountPercentColumnName, discountPercent);
                }
            }
            else
            {
                discountAmount = extPrice * discountPercent / 100;
                dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            }

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));
            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                //if (netAmount - discountAmount > 0)
                //{
                //    taxPercent = taxAmount / (netAmount - discountAmount) * 100;
                //    dbUtil.SetPropertyValue(item, taxPercentColumnName, taxPercent);
                //}            
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            RoundByCurrency(item);


            item.OldObject = (BusinessObject)item.Clone();
        }



        public void UpdateContQty()
        {
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            decimal contQty = 0;
            foreach (ARSaleForecastItemsInfo entItem in ARSaleForecastItemsList)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo products = BOSApp.GetProductFromCurrentProductList(entItem.FK_ICProductID);

                contQty += (entItem.ARSaleForecastItemProductQty * products.ICProductLength * products.ICProductWidth * products.ICProductHeight) * Convert.ToDecimal((Math.Pow(10, -9)));
            }
            if (contQty != 0)
            {
                contQty = (contQty) / 60;
            }

            objSaleForecastsInfo.ARSaleForecastContQty = contQty; //decimal.Parse(String.Format("{0:0.00}", contQty));

            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Take a deposit
        /// </summary>
        /// <param name="paymentDate">Payment date</param>
        /// <param name="paymentDesc">Payment desc</param>
        /// <param name="bankID">Bank id</param>
        /// <param name="bankAccount">Bank account</param>
        /// <param name="paymentAmount">Payment amount</param>
        /// <returns>Id of payment object</returns>
        public int TakePayment(DateTime paymentDate, string paymentDesc, int bankID, string bankAccount, decimal paymentAmount)
        {
            //using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            //{
            //    try
            //    {
            //        //Generate open document if it's the first payment
            //        ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            //        AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            //        AROpenDocumentsInfo objOpenDocumentsInfo = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objSaleForecastsInfo.ARSaleForecastNo);
            //        if (objOpenDocumentsInfo == null)
            //        {
            //            objOpenDocumentsInfo= DataGenerator.GenerateOpenDocumentFromSaleForecast((ARSaleForecastsInfo)MainObject);
            //            objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);
            //        }
            //        ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            //        ARCustomerPaymentsInfo objCustomerPaymentsInfo = CustomerPayment.CustomerPaymentModule.TakePayment(objOpenDocumentsInfo, paymentAmount, ARCustomerPaymentDetailsList);
            //        objCustomerPaymentsInfo.ARCustomerPaymentNo = BOSApp.GetMainObjectNo(ModuleName.Deposit);
            //        objCustomerPaymentsInfo.ARCustomerPaymentType = CustomerPaymentType.Deposit.ToString();
            //        objCustomerPaymentsInfo.ARCustomerPaymentDate = paymentDate;
            //        objCustomerPaymentsInfo.ARCustomerPaymentDesc = paymentDesc;
            //        objCustomerPaymentsInfo.FK_CSCompanyBankID = bankID;
            //        objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = bankAccount;
            //        objCustomerPaymentsController.UpdateObject(objCustomerPaymentsInfo);
            //        BOSApp.UpdateObjectNumbering(ModuleName.Deposit);

            //        //Update sale order
            //        ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();                    
            //        objSaleForecastsInfo.ARSaleForecastDepositBalance += Math.Min(paymentAmount, objSaleForecastsInfo.ARSaleForecastBalanceDue);
            //        objSaleForecastsInfo.ARSaleForecastBalanceDue -= Math.Min(paymentAmount, objSaleForecastsInfo.ARSaleForecastBalanceDue);
            //        objSaleForecastsController.UpdateObject(objSaleForecastsInfo);

            //        SavePaymentEntries(objCustomerPaymentsInfo);

            //        scope.Complete();
            //        return objCustomerPaymentsInfo.ARCustomerPaymentID;
            //    }
            //    catch (Exception ex)
            //    {
            //        scope.Dispose();
            return 0;
            //    }
            //}
        }

        /// <summary>
        /// Update a deposit
        /// </summary>
        /// <param name="customerPayment">Deposit object</param>
        /// <param name="objDocumentPaymentsInfo">Payment document of the deposit</param>
        public void UpdatePayment(ARCustomerPaymentsInfo customerPayment, ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            //using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            //{
            //    try
            //    {
            //        ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            //        ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            //        ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();

            //        //Update document payment
            //        objDocumentPaymentsInfo.ARDocumentPaymentAmount = customerPayment.ARCustomerPaymentTotalAmount;
            //        objDocumentPaymentsController.UpdateObject(objDocumentPaymentsInfo);

            //        //Update open document
            //        AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            //        ARSaleForecastsInfo SaleForecast = (ARSaleForecastsInfo)MainObject;
            //        AROpenDocumentsInfo openDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(SaleForecast.ARSaleForecastNo);
            //        if (openDocument != null)
            //        {
            //            int openDocumentID = openDocument.AROpenDocumentID;
            //            openDocument = DataGenerator.GenerateOpenDocumentFromSaleForecast(SaleForecast);
            //            openDocument.AROpenDocumentID = openDocumentID;
            //            objOpenDocumentsController.UpdateObject(openDocument);
            //        }

            //        //Update customer payment                    
            //        customerPayment.FK_ARCustomerID = SaleForecast.FK_ARCustomerID;
            //        customerPayment.FK_GECurrencyID = SaleForecast.FK_GECurrencyID;
            //        objCustomerPaymentsController.UpdateObject(customerPayment);

            //        //Update customer payment detail
            //        CustomerPayment.CustomerPaymentModule.UpdateCustomerPaymentDetails(customerPayment, ARCustomerPaymentDetailsList);

            //        //Update the deposit and balance due of the current sale order
            //        ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();                    
            //        SaleForecast.ARSaleForecastDepositBalance += Math.Min(customerPayment.ARCustomerPaymentTotalAmount, SaleForecast.ARSaleForecastBalanceDue);
            //        SaleForecast.ARSaleForecastBalanceDue -= Math.Min(customerPayment.ARCustomerPaymentTotalAmount, SaleForecast.ARSaleForecastBalanceDue);
            //        objSaleForecastsController.UpdateObject(SaleForecast);

            //        SavePaymentEntries(customerPayment);

            //        scope.Complete();
            //    }
            //    catch (Exception ex)
            //    {
            //        scope.Dispose();
            //    }
            //}
        }

        /// <summary>
        /// Delete payment
        /// </summary>
        /// <param name="objDocumentPaymentsInfo">Info of document payment</param>
        public void DeletePayment(ARDocumentPaymentsInfo objDocumentPaymentsInfo)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByID(objDocumentPaymentsInfo.FK_ARCustomerPaymentID);
                    if (objCustomerPaymentsInfo != null)
                    {
                        List<ARCustomerPaymentDetailsInfo> oldPaymentDetails = objCustomerPaymentDetailsController.GetDetailsByPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        foreach (ARCustomerPaymentDetailsInfo oldPaymentDetail in oldPaymentDetails)
                        {
                            CustomerPayment.CustomerPaymentModule.RollbackRelativeDataOfPaymentDetail((ARCustomerPaymentDetailsInfo)oldPaymentDetail);
                        }
                        objCustomerPaymentsController.DeleteByID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsController.DeletePaymentEntriesByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
                    }

                    //Update the deposit and balance due of the current sale order
                    ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
                    ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
                    objSaleForecastsInfo.ARSaleForecastDepositBalance -= objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleForecastsInfo.ARSaleForecastBalanceDue += objDocumentPaymentsInfo.ARDocumentPaymentAmount;
                    objSaleForecastsController.UpdateObject(objSaleForecastsInfo);

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        public void GenerateEntityFromProposal(ARProposalsInfo objProposalsInfo)
        {
            //Copy sale order
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            ARSaleForecastsInfo objOldSaleForecastsInfo = (ARSaleForecastsInfo)objSaleForecastsInfo.Clone();
            BOSUtil.CopyObject(objProposalsInfo, objSaleForecastsInfo);

            //Restore some its own properties
            objSaleForecastsInfo.ARSaleForecastNo = objOldSaleForecastsInfo.ARSaleForecastNo;
            objSaleForecastsInfo.ARSaleForecastName = objOldSaleForecastsInfo.ARSaleForecastName;
            objSaleForecastsInfo.ARSaleForecastTypeCombo = objOldSaleForecastsInfo.ARSaleForecastTypeCombo;
            objSaleForecastsInfo.ARSaleForecastStatus = objOldSaleForecastsInfo.ARSaleForecastStatus;
            objSaleForecastsInfo.ARSaleForecastDate = objOldSaleForecastsInfo.ARSaleForecastDate;
            objSaleForecastsInfo.ARSaleForecastDeliveryDate = objOldSaleForecastsInfo.ARSaleForecastDeliveryDate;
            objSaleForecastsInfo.ARSaleForecastValidateDate = objOldSaleForecastsInfo.ARSaleForecastValidateDate;
            objSaleForecastsInfo.ARSaleForecastDesc = objOldSaleForecastsInfo.ARSaleForecastDesc;
            objSaleForecastsInfo.ARSaleForecastReference = objProposalsInfo.ARProposalNo;
            objSaleForecastsInfo.FK_HREmployeeID = objOldSaleForecastsInfo.FK_HREmployeeID;
            objSaleForecastsInfo.ARSaleForecastEmployeePicture = objOldSaleForecastsInfo.ARSaleForecastEmployeePicture;
            objSaleForecastsInfo.ARSaleForecastBalanceDue = objSaleForecastsInfo.ARSaleForecastTotalAmount - objSaleForecastsInfo.ARSaleForecastDepositBalance;

            //Copy item list
            BOSList<ARProposalItemsInfo> lstProposalItems = new BOSList<ARProposalItemsInfo>();
            lstProposalItems.InitBOSList(null, "ARProposals", "ARProposalItems", BOSList<ARProposalItemsInfo>.cstRelationForeign);
            lstProposalItems.Invalidate(objProposalsInfo.ARProposalID);
            ARReferenceProposalItems.Clear();
            foreach (ARProposalItemsInfo objProposalItemsInfo in lstProposalItems)
            {
                objProposalItemsInfo.ARProposalItemProductQtyRemained = objProposalItemsInfo.ARProposalItemProductQty - objProposalItemsInfo.ARProposalItemProductQtyOld;
                if (objProposalItemsInfo.ARProposalItemProductQtyRemained > 0)
                {
                    ARSaleForecastItemsInfo objSaleForecastItemsInfo = new ARSaleForecastItemsInfo();
                    BOSUtil.CopyObject(objProposalItemsInfo, objSaleForecastItemsInfo);
                    objSaleForecastItemsInfo.FK_ARProposalID = objProposalsInfo.ARProposalID;
                    objSaleForecastItemsInfo.FK_ARProposalItemID = objProposalItemsInfo.ARProposalItemID;
                    objSaleForecastItemsInfo.ARSaleForecastItemProductQty = objProposalItemsInfo.ARProposalItemProductQtyRemained;
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(objProposalItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                               objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                               objProductsInfo.ICProductType == ProductType.Verneer.ToString())
                        {
                            objSaleForecastItemsInfo.ARSaleForecastItemProductQty = Math.Round(objSaleForecastItemsInfo.ARSaleForecastItemProductQty, 4, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            objSaleForecastItemsInfo.ARSaleForecastItemProductQty = Math.Round(objSaleForecastItemsInfo.ARSaleForecastItemProductQty, 2, MidpointRounding.AwayFromZero);
                        }
                    }
                    RoundByCurrency(objSaleForecastItemsInfo);
                    SetProductPriceByProductUnitPrice(objSaleForecastItemsInfo);
                    ARSaleForecastItemsList.Add(objSaleForecastItemsInfo);

                    ARReferenceProposalItems.Add(objProposalItemsInfo.ARProposalItemID, objProposalItemsInfo);
                }
            }

            UpdateTotalAmount();
        }

        public ARInvoicesInfo GenerateInvoiceFromSaleForecast(ARSaleForecastsInfo objSaleForecastsInfo)
        {
            ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
            BOSUtil.CopyObject(objSaleForecastsInfo, objInvoicesInfo);

            //Set own properties of invoice
            objInvoicesInfo.AACreatedUser = BOSApp.CurrentUser;
            objInvoicesInfo.AACreatedDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceReference = objSaleForecastsInfo.ARSaleForecastNo;
            objInvoicesInfo.ARInvoiceStatus = BOSCommon.InvoiceStatus.Complete.ToString();
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            return objInvoicesInfo;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            if (strTableName == TableName.ARSaleForecastsTableName)
            {
                //Decrease the ordered quantity of the item list
                foreach (ARSaleForecastItemsInfo item in ComponentSaleForecastItemList)
                {
                    TransactionUtil.UpdateInventoryStock(
                                                    item.FK_ICProductID,
                                                    item.FK_ICStockID,
                                                    -(item.ARSaleForecastItemProductQty - item.ARSaleForecastItemShippedQty),
                                                    TransactionUtil.cstInventorySaleOrder);
                }
            }
        }

        /// <summary>
        /// Invalidate item components of the sale order items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            List<ARSaleForecastItemsInfo> items = objSaleForecastItemsController.GetComponentItemsBySaleForecastID(objSaleForecastsInfo.ARSaleForecastID);
            ComponentSaleForecastItemList.Clear();
            ComponentSaleForecastItemList.OriginalList.Clear();
            foreach (ARSaleForecastItemsInfo item in items)
            {
                ComponentSaleForecastItemList.Add((ARSaleForecastItemsInfo)item.Clone());
            }

            foreach (ARSaleForecastItemsInfo item in ComponentSaleForecastItemList)
            {
                ComponentSaleForecastItemList.OriginalList.Add((ARSaleForecastItemsInfo)item.Clone());
            }
        }

        /// <summary>
        /// Save a template to database
        /// </summary>
        /// <param name="objVisitTemplatesInfo">Visit template object needs to be saved</param>
        public void SaveTemplate(ARSaleForecastTemplatesInfo objSaleForecastTemplatesInfo)
        {
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            ARSaleForecastTemplatesController objSaleForecastTemplatesController = new ARSaleForecastTemplatesController();
            if (objSaleForecastTemplatesInfo.ARSaleForecastTemplateID == 0)
            {
                objSaleForecastTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objSaleForecastTemplatesInfo.AACreatedDate = DateTime.Now;
                objSaleForecastTemplatesInfo.FK_ARSaleForecastID = objSaleForecastsInfo.ARSaleForecastID;
                objSaleForecastTemplatesController.CreateObject(objSaleForecastTemplatesInfo);
            }
            else
            {
                objSaleForecastTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objSaleForecastTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objSaleForecastTemplatesController.UpdateObject(objSaleForecastTemplatesInfo);
            }

        }

        public override void DuplicateModuleObjectList()
        {
            ARSaleForecastItemsList.Duplicate();
            ARSaleForecastItemsList.ForEach(a =>
            {
                a.ARSaleForecastItemCanceledQty = 0;
                a.ARSaleForecastItemShippedQty = 0;
                a.ARSaleForecastItemProductSOQty = 0;
            });
        }

        #region Accounting
        /// <summary>
        /// Save entries for the payment of the sale receipt
        /// </summary>
        /// <param name="customerPayment">Payment object</param>
        private void SavePaymentEntries(ARCustomerPaymentsInfo customerPayment)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            string oldReceiptVoucherNo = string.Empty;
            string oldBankTransferNo = string.Empty;
            //Delete all payment data first
            if (!string.IsNullOrEmpty(customerPayment.ARCustomerPaymentNo))
            {
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                ARReceiptVouchersInfo receiptVoucher = objReceiptVouchersController.GetReceiptVoucherByReference(customerPayment.ARCustomerPaymentNo);
                if (receiptVoucher != null)
                {
                    oldReceiptVoucherNo = receiptVoucher.ARReceiptVoucherNo;
                }

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo bankTransfer = objBankTransactionsController.GetBankTransactionByReference(customerPayment.ARCustomerPaymentNo);
                if (bankTransfer != null)
                {
                    oldBankTransferNo = bankTransfer.ACBankTransactionNo;
                }
                objCustomerPaymentsController.DeletePaymentEntriesByNo(customerPayment.ARCustomerPaymentNo);
            }

            //Add new payment entries 
            DocumentEntryList.SetDefaultListAndRefreshGridControl();
            decimal cashAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.Cash.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (cashAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo cashDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.Cash.ToString()).FirstOrDefault();
                if (cashDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (cashDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = cashDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        cashAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.PhieuThu.ToString(),
                                                                        AccEntryType.ThuTienUngTruoc.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = cashAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;

                    ARReceiptVouchersInfo receiptVoucher = CreateReceiptVoucher(customerPayment, oldReceiptVoucherNo, cashAmount, currencyID, exchangeRate);
                    if (receiptVoucher != null)
                    {
                        entry.ACDocumentNo = receiptVoucher.ARReceiptVoucherNo;
                    }
                }
            }

            decimal bankTransferAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (bankTransferAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo bankTransferDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).FirstOrDefault();
                if (bankTransferDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (bankTransferDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = bankTransferDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        bankTransferAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NopTienVaoTaiKhoan.ToString(),
                                                                        AccEntryType.ThuTienUngTruoc.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = bankTransferAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;

                    ACBankTransactionsInfo bankTransfer = CreateBankTransfer(customerPayment, oldBankTransferNo, bankTransferAmount, currencyID, exchangeRate);
                    if (bankTransfer != null)
                    {
                        entry.ACDocumentNo = bankTransfer.ACBankTransactionNo;
                    }
                }
            }

            decimal creditCardAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (creditCardAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                ARCustomerPaymentDetailsInfo creditCardDetail = ARCustomerPaymentDetailsList.Where(d => d.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).FirstOrDefault();
                if (creditCardDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (creditCardDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = creditCardDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        creditCardAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuCocBangTheTinDung.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = creditCardAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                }
            }

            decimal giftVoucherAmount = ARCustomerPaymentDetailsList.Where(pd => pd.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString()).Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (giftVoucherAmount > 0)
            {
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuCocBangPhieuGhiCo.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    entry.ACDocumentEntryAmount = giftVoucherAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * customerPayment.ARCustomerPaymentExchangeRate;
                }
            }

            //Add new payment documents that have relative entries            
            DocumentList.Clear();
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienUngTruoc.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangPhieuGhiCo.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangTheTinDung.ToString())
                {
                    ACDocumentsInfo document = DocumentList.Where(d => d.ACDocumentTypeName == entry.ACDocumentTypeName &&
                                                                (string.IsNullOrEmpty(entry.ACDocumentNo) || entry.ACDocumentNo == d.ACDocumentNo)).FirstOrDefault();
                    if (document == null)
                    {
                        document = new ACDocumentsInfo();
                        document.FK_ACDocumentTypeID = entry.FK_ACDocumentTypeID;
                        document.ACDocumentTypeName = entry.ACDocumentTypeName;
                        DocumentList.Add(document);
                    }
                    BOSUtil.CopyObject(customerPayment, document);
                    if (!string.IsNullOrEmpty(entry.ACDocumentNo))
                    {
                        document.ACDocumentNo = entry.ACDocumentNo;
                    }
                    if (entry.FK_GECurrencyID > 0)
                    {
                        document.FK_GECurrencyID = entry.FK_GECurrencyID;
                        document.ACDocumentExchangeRate = entry.ACDocumentExchangeRate;
                    }
                    document.ACDocumentReference = customerPayment.ARCustomerPaymentNo;
                    document.FK_ACObjectID = customerPayment.FK_ARCustomerID;
                    document.ACObjectType = ObjectType.Customer.ToString();
                }
            }
            SaveAccountingData();
        }

        public override bool SaveAccountingData()
        {
            SaveDocuments();

            SaveDocumentEntrys();

            return true;
        }

        /// <summary>
        /// Create a receipt voucher associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment</param>
        /// <param name="oldReceiptVoucherNo">Old receipt voucher no</param>
        /// <param name="amount">Receipted amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Receipt voucher object</returns>
        private ARReceiptVouchersInfo CreateReceiptVoucher(ARCustomerPaymentsInfo customerPayment, string oldReceiptVoucherNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();

            ARReceiptVouchersInfo receiptVoucher = new ARReceiptVouchersInfo();
            BOSUtil.CopyObject(customerPayment, receiptVoucher);
            if (string.IsNullOrEmpty(oldReceiptVoucherNo))
            {
                receiptVoucher.ARReceiptVoucherNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, receiptVoucher);
                BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
            }
            else
            {
                receiptVoucher.ARReceiptVoucherNo = oldReceiptVoucherNo;
            }
            receiptVoucher.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            receiptVoucher.ARObjectType = ObjectType.Customer.ToString();
            receiptVoucher.ARReceiptVoucherType = ReceiptVoucherType.Deposit.ToString();
            receiptVoucher.ARReceiptVoucherReference = customerPayment.ARCustomerPaymentNo;
            receiptVoucher.FK_GECurrencyID = currencyID;
            receiptVoucher.ARReceiptVoucherExchangeRate = exchangeRate;
            receiptVoucher.ARReceiptVoucherTotalAmount = amount;
            receiptVoucher.ARReceiptVoucherExchangeAmount = receiptVoucher.ARReceiptVoucherTotalAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
            int receiptVoucherID = objReceiptVouchersController.CreateObject(receiptVoucher);

            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", receiptVoucher.ARReceiptVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.PhieuThu.ToString())
                {
                    ARReceiptVoucherItemsInfo item = new ARReceiptVoucherItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ARReceiptVoucherID = receiptVoucher.ARReceiptVoucherID;
                    objReceiptVoucherItemsController.CreateObject(item);
                }
            }
            return receiptVoucher;
        }

        /// <summary>
        /// Create a bank transfer associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment</param>        
        /// <param name="oldBankTransferNo">Old bank transfer no</param>
        /// <param name="amount">Transferred amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Bank transaction object</returns>
        private ACBankTransactionsInfo CreateBankTransfer(ARCustomerPaymentsInfo customerPayment, string oldBankTransferNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(customerPayment.FK_CSCompanyBankID);

            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            ACBankTransactionsInfo bankTransfer = new ACBankTransactionsInfo();
            BOSUtil.CopyObject(customerPayment, bankTransfer);
            if (string.IsNullOrEmpty(oldBankTransferNo))
            {
                bankTransfer.ACBankTransactionNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, bankTransfer);
                BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
            }
            else
            {
                bankTransfer.ACBankTransactionNo = oldBankTransferNo;
            }
            bankTransfer.FK_ACObjectID = customerPayment.FK_ARCustomerID;
            bankTransfer.ACObjectType = ObjectType.Customer.ToString();
            bankTransfer.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
            bankTransfer.ACBankTransactionReference = customerPayment.ARCustomerPaymentNo;
            bankTransfer.ACBankTransactionReceiverBankName = bankName;
            bankTransfer.ACBankTransactionReceiverAccount = customerPayment.ARCustomerPaymentBankAccount;
            bankTransfer.FK_GECurrencyID = currencyID;
            bankTransfer.ACBankTransactionExchangeRate = exchangeRate;
            bankTransfer.ACBankTransactionTotalAmount = amount;
            bankTransfer.ACBankTransactionExchangeAmount = bankTransfer.ACBankTransactionTotalAmount * bankTransfer.ACBankTransactionExchangeRate;
            int bankTransferID = objBankTransactionsController.CreateObject(bankTransfer);

            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", bankTransfer.ACBankTransactionID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.NopTienVaoTaiKhoan.ToString())
                {
                    ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ACBankTransactionID = bankTransfer.ACBankTransactionID;
                    objBankTransactionItemsController.CreateObject(item);
                }
            }

            return bankTransfer;
        }
        #endregion

        public override bool CompleteTransaction()
        {
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)MainObject;
            if (objSaleForecastsInfo.ARSaleForecastStatus == SaleForecastStatus.New.ToString())
            {
                //Chỉ xác nhận cho SaleForecast => DBH lấy tình trạng này -> nếu chuyển sang Complete => DBH ko thể lấy dc. (đã rename toolbar = Xác nhận)
                objSaleForecastsInfo.ARSaleForecastStatus = SaleForecastStatus.Confirmed.ToString();
                UpdateMainObject();
            }
            return true;
        }

    }
}
