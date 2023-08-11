using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.SaleReturn
{
    public class SaleReturnEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets sale return item list
        /// </summary>
        public BOSItemsEntityList<ARSaleReturnItemsInfo> SaleReturnItemsList { get; set; }

        /// <summary>
        /// Gets or sets the component list of associating with sale return items
        /// </summary>
        public BOSItemsEntityList<ARSaleReturnItemsInfo> ComponentSaleReturnItemList { get; set; }

        /// <summary>
        /// Gets or sets the refundable invoices for the sale return
        /// </summary>
        public BOSList<ARInvoiceItemsInfo> RefundableInvoiceItems { get; set; }

        #endregion

        #region Constructor
        public SaleReturnEntities()
            : base()
        {
            SaleReturnItemsList = new BOSItemsEntityList<ARSaleReturnItemsInfo>();
            ComponentSaleReturnItemList = new BOSItemsEntityList<ARSaleReturnItemsInfo>();
            RefundableInvoiceItems = new BOSList<ARInvoiceItemsInfo>(this, string.Empty, TableName.ARInvoiceItemsTableName);
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARSaleReturnsInfo();
            SearchObject = new ARSaleReturnsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARSaleReturnItemsTableName, new ARSaleReturnItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            SaleReturnItemsList.InitBOSList(this,
                                            TableName.ARSaleReturnsTableName,
                                            TableName.ARSaleReturnItemsTableName,
                                            BOSItemsEntityList<ARSaleReturnItemsInfo>.cstRelationForeign);
            SaleReturnItemsList.ItemTableForeignKey = "FK_ARSaleReturnID";

            ComponentSaleReturnItemList.InitBOSList(this,
                                            TableName.ARSaleReturnsTableName,
                                            TableName.ARSaleReturnItemsTableName,
                                            BOSItemsEntityList<ARSaleReturnItemsInfo>.cstRelationForeign);
            ComponentSaleReturnItemList.ItemTableForeignKey = "FK_ARSaleReturnID";
        }

        public override void InitGridControlInBOSList()
        {
            SaleReturnItemsList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(SaleReturnModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SaleReturnItemsList.SetDefaultListAndRefreshGridControl();
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

            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            objSaleReturnsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objSaleReturnsInfo.ARSaleReturnDate = BOSApp.GetCurrentServerDate();
            objSaleReturnsInfo.ARSaleReturnGetPriceDate = BOSApp.GetCurrentServerDate();
            objSaleReturnsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleReturnsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objSaleReturnsInfo.ARSaleReturnExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objSaleReturnsInfo.ARSaleReturnDesc = SaleReturnLocalizedResources.SaleReturnDefaultDesc;

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            if (objSaleReturnsInfo.FK_ARInvoiceID > 0)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(objSaleReturnsInfo.FK_ARInvoiceID);
                if (objInvoicesInfo != null)
                {
                    objSaleReturnsInfo.ARInvoiceNo = objInvoicesInfo.ARInvoiceNo;
                    objSaleReturnsInfo.ARInvoiceDate = objInvoicesInfo.ARInvoiceDate;
                    UpdateMainObjectBindingSource();
                }
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            List<ARSaleReturnItemsInfo> listItem = objSaleReturnItemsController.GetItemsBySaleReturnID(iObjectID);
            SaleReturnItemsList.Invalidate(listItem);

            foreach (ARSaleReturnItemsInfo objSaleReturnItemsInfo in SaleReturnItemsList)
            {
                objSaleReturnItemsInfo.SaleReturnItemComponentList = new BOSList<ARSaleReturnItemComponentsInfo>();
                objSaleReturnItemsInfo.SaleReturnItemComponentList.InitBOSList(
                                                                    this,
                                                                    TableName.ARSaleReturnItemsTableName,
                                                                    TableName.ARSaleReturnItemComponentsTableName,
                                                                    BOSList<ARSaleReturnItemComponentsInfo>.cstRelationForeign);
                objSaleReturnItemsInfo.SaleReturnItemComponentList.ItemTableForeignKey = "FK_ARSaleReturnItemID";

                ARSaleReturnItemComponentsController objSaleReturnItemComponentsController = new ARSaleReturnItemComponentsController();
                List<ARSaleReturnItemComponentsInfo> components = objSaleReturnItemComponentsController.GetComponentsByItemID(objSaleReturnItemsInfo.ARSaleReturnItemID);
                objSaleReturnItemsInfo.SaleReturnItemComponentList.Invalidate(components);
            }

            //Invalidate item components
            InvalidateItemComponents();

            //Back up the sale return and its components in case it has been completed                        
            ComponentSaleReturnItemList.BackupList.Clear();
            ARSaleReturnsInfo saleReturn = (ARSaleReturnsInfo)MainObject;
            if (saleReturn.ARSaleReturnStatus == SaleReturnStatus.Complete.ToString())
            {
                saleReturn.BackupObject = (ARSaleReturnsInfo)saleReturn.Clone();
                foreach (ARSaleReturnItemsInfo item in ComponentSaleReturnItemList)
                {
                    ComponentSaleReturnItemList.BackupList.Add((ARSaleReturnItemsInfo)item.Clone());
                }
            }
        }

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            SaleReturnItemsList.SaveItemObjects();

            SaveSaleReturnItemComponents(SaleReturnItemsList);
            
        }
        public override void AfterSaveTransaction()
        {
            base.AfterSaveTransaction();
            //ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            //if (SaleReturnItemsList.Count() > 0 && SaleReturnItemsList.Where(o => o.FK_ICProductSerieID == 0).Count() > 0)
            //{
            //    objSaleReturnItemsController.UpdateDefualtSerialByObject(SaleReturnItemsList.FirstOrDefault().FK_ARSaleReturnID);
            //    InvalidateModuleObjects(SaleReturnItemsList.FirstOrDefault().FK_ARSaleReturnID);
            //}
            
        }

        /// <summary>
        /// Save component list of sale return items
        /// </summary>
        /// <param name="saleReturnItems">List of sale return items</param>
        private void SaveSaleReturnItemComponents(BOSItemsEntityList<ARSaleReturnItemsInfo> saleReturnItems)
        {
            if (saleReturnItems != null)
            {
                ARSaleReturnsInfo saleReturn = (ARSaleReturnsInfo)MainObject;
                ARSaleReturnItemComponentsController objSaleReturnItemComponentsController = new ARSaleReturnItemComponentsController();
                foreach (ARSaleReturnItemsInfo item in saleReturnItems)
                {
                    if (item.SaleReturnItemComponentList != null)
                    {
                        foreach (ARSaleReturnItemComponentsInfo component in item.SaleReturnItemComponentList)
                        {
                            component.FK_ARSaleReturnItemID = item.ARSaleReturnItemID;
                            component.ICProductSerieReceiptDate = saleReturn.ARSaleReturnDate;
                            SynProductSerie(component);
                        }
                        item.SaleReturnItemComponentList.SaveItemObjects();
                    }
                }
            }
        }
        #endregion

        public override bool IsInvalidInventory()
        {
            return ComponentSaleReturnItemList.IsInvalidInventory(TransactionUtil.cstInventoryReceipt);
        }

        public override bool CompleteTransaction()
        {
            //Update the sale return's status
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            objSaleReturnsInfo.ARSaleReturnStatus = SaleReturnStatus.Complete.ToString();
            UpdateMainObject();

            //Generate product series
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            foreach (ARSaleReturnItemsInfo item in SaleReturnItemsList)
            {
                if (!string.IsNullOrEmpty(item.ARSaleReturnItemProductSerialNo))
                {
                    ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ARSaleReturnItemProductSerialNo);
                    if (objProductSeriesInfo == null)
                    {
                        objProductSeriesInfo = new ICProductSeriesInfo();
                        objProductSeriesInfo.AACreatedDate = DateTime.Now;
                        objProductSeriesInfo.FK_ICProductID = item.FK_ICProductID;
                        objProductSeriesInfo.ICProductSerieNo = item.ARSaleReturnItemProductSerialNo;
                        objProductSeriesInfo.ICProductSerieLotNo = item.ARSaleReturnItemLotNo;
                        objProductSeriesInfo.ICProductSerieReceiptDate = objSaleReturnsInfo.ARSaleReturnDate;
                        objProductSeriesController.CreateObject(objProductSeriesInfo);
                    }
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    objSaleReturnItemsController.UpdateObject(item);
                }
            }
            return base.CompleteTransaction();
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
                ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
                objSaleReturnsController.DeleteObject(objSaleReturnsInfo.ARSaleReturnID);
                SaleReturnItemsList.DeleteItemObjects();
            }
        }
        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ARSaleReturnItemsInfo objSaleReturnItemsInfo = (ARSaleReturnItemsInfo)ModuleObjects[TableName.ARSaleReturnItemsTableName];
                objSaleReturnItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objSaleReturnItemsInfo.FK_ICStockID = objSaleReturnsInfo.FK_ICStockID;
                objSaleReturnItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                UpdateModuleObjectBindingSource(TableName.ARSaleReturnItemsTableName);
            }
        }

        public void UpdateTotalAmount()
        {
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            objSaleReturnsInfo.ARSaleReturnNetAmount = 0;
            objSaleReturnsInfo.ARSaleReturnSubTotalAmount = 0;
            foreach (ARSaleReturnItemsInfo entItem in SaleReturnItemsList)
            {
                BOSApp.RoundByCurrency(entItem, objSaleReturnsInfo.FK_GECurrencyID);
                objSaleReturnsInfo.ARSaleReturnNetAmount += entItem.ARSaleReturnItemNetAmount;
                objSaleReturnsInfo.ARSaleReturnSubTotalAmount += entItem.ARSaleReturnItemTotalAmount;
            }
            BOSApp.RoundByCurrency(objSaleReturnsInfo, objSaleReturnsInfo.FK_GECurrencyID);
            objSaleReturnsInfo.ARSaleReturnDiscountFix = objSaleReturnsInfo.ARSaleReturnSubTotalAmount * objSaleReturnsInfo.ARSaleReturnDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objSaleReturnsInfo, "ARSaleReturnDiscountFix", objSaleReturnsInfo.FK_GECurrencyID);
            objSaleReturnsInfo.ARSaleReturnTaxAmount = (objSaleReturnsInfo.ARSaleReturnSubTotalAmount - objSaleReturnsInfo.ARSaleReturnDiscountFix) * objSaleReturnsInfo.ARSaleReturnTaxPercent / 100;
            BOSApp.RoundByCurrency(objSaleReturnsInfo, "ARSaleReturnTaxAmount", objSaleReturnsInfo.FK_GECurrencyID);
            objSaleReturnsInfo.ARSaleReturnTotalAmount = objSaleReturnsInfo.ARSaleReturnSubTotalAmount + objSaleReturnsInfo.ARSaleReturnTaxAmount - objSaleReturnsInfo.ARSaleReturnDiscountFix;
            BOSApp.RoundByCurrency(objSaleReturnsInfo, "ARSaleReturnTotalAmount", objSaleReturnsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void GenerateEntitiesFromInvoice(ARInvoicesInfo objInvoicesInfo, List<ARInvoiceItemsInfo> invoiceItems)
        {
            //Copy sale return
            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)entity.MainObject;
            ARSaleReturnsInfo objOldSaleReturnsInfo = (ARSaleReturnsInfo)objSaleReturnsInfo.Clone();
            BOSUtil.CopyObject(objInvoicesInfo, objSaleReturnsInfo);
            objSaleReturnsInfo.STToolbarActionName = "FromInvoice";
            objSaleReturnsInfo.FK_ARInvoiceID = objInvoicesInfo.ARInvoiceID;
            objSaleReturnsInfo.FK_ICStockID = objInvoicesInfo.FK_ICStockID;
            objSaleReturnsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleReturnsInfo.FK_ACObjectID = objInvoicesInfo.FK_ACObjectID;
            objSaleReturnsInfo.ARObjectType = objInvoicesInfo.ARObjectType;
            objSaleReturnsInfo.ACObjectAccessKey = string.Join(";", new string[] { objSaleReturnsInfo.FK_ACObjectID.ToString(), objSaleReturnsInfo.ARObjectType });
            objSaleReturnsInfo.ARInvoiceProductType = objInvoicesInfo.ARInvoiceProductType;
            objSaleReturnsInfo.ARSaleReturnProductType = objInvoicesInfo.ARInvoiceProductType;
            objSaleReturnsInfo.ARInvoiceVATInvoiceNo = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objSaleReturnsInfo.ARSaleReturnInvoiceVATNo = objInvoicesInfo.ARInvoiceVATInvoiceNo;
            objSaleReturnsInfo.ARInvoiceVATSymbol = objInvoicesInfo.ARInvoiceVATSymbol;
            objSaleReturnsInfo.ARInvoiceTaxNumber = objInvoicesInfo.ARInvoiceTaxNumber;
            objSaleReturnsInfo.AROutputVATDocumentType = String.Empty;
            objSaleReturnsInfo.ARSaleReturnVATFormNo = String.Empty;
            objSaleReturnsInfo.ARSaleReturnVATSymbol = String.Empty;
            objSaleReturnsInfo.ARSaleReturnVATInvoiceNo = String.Empty;
            objSaleReturnsInfo.ARSaleReturnTaxNumber = String.Empty;
            objSaleReturnsInfo.FK_ACEInvoiceTypeID = 0;
            objSaleReturnsInfo.ARSaleReturnTransferredDate = DateTime.Now;
            objSaleReturnsInfo.ARSaleReturnProject = objInvoicesInfo.ARInvoiceProject;
            objSaleReturnsInfo.ARSaleReturnSaleContract = String.Join(", ", invoiceItems.Select(o => o.ARSaleOrderSaleContract).Distinct().ToArray());

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            if (objObjectsInfo != null)
                objSaleReturnsInfo.ACObjectContactAddressLine3 = objObjectsInfo.ACObjectDeliveryAddressLine1;

            //Restore some its own properties
            objSaleReturnsInfo.ARSaleReturnNo = objOldSaleReturnsInfo.ARSaleReturnNo;
            objSaleReturnsInfo.ARSaleReturnType = objOldSaleReturnsInfo.ARSaleReturnType;
            objSaleReturnsInfo.ARSaleReturnStatus = objOldSaleReturnsInfo.ARSaleReturnStatus;
            objSaleReturnsInfo.ARSaleReturnDate = objOldSaleReturnsInfo.ARSaleReturnDate;
            objSaleReturnsInfo.ARSaleReturnDesc = objOldSaleReturnsInfo.ARSaleReturnDesc;
            objSaleReturnsInfo.FK_HREmployeeID = objOldSaleReturnsInfo.FK_HREmployeeID;
            objSaleReturnsInfo.ARSaleReturnEmployeePicture = objOldSaleReturnsInfo.ARSaleReturnEmployeePicture;

            //Copy item list
            //ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            //DataSet ds = objInvoiceItemsController.GetAllDataByForeignColumn("FK_ARInvoiceID", objInvoicesInfo.ARInvoiceID);
            //BOSList<ARInvoiceItemsInfo> invoiceItems = new BOSList<ARInvoiceItemsInfo>(TableName.ARInvoiceItemsTableName);
            //invoiceItems.Invalidate(ds);
            foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in invoiceItems)
            {
                ARSaleReturnItemsInfo objSaleReturnItemsInfo = new ARSaleReturnItemsInfo();
                BOSUtil.CopyObject(objInvoiceItemsInfo, objSaleReturnItemsInfo);
                objSaleReturnItemsInfo.FK_ARInvoiceID = objInvoiceItemsInfo.FK_ARInvoiceID;
                objSaleReturnItemsInfo.FK_ARInvoiceItemID = objInvoiceItemsInfo.ARInvoiceItemID;
                objSaleReturnItemsInfo.ARSaleReturnItemProductQty = objInvoiceItemsInfo.ARInvoiceItemProductQty - objInvoiceItemsInfo.ARInvoiceItemReturnQty;
                objSaleReturnItemsInfo.ARSaleReturnItemProductExchangeQty = objSaleReturnItemsInfo.ARSaleReturnItemProductQty * objSaleReturnItemsInfo.ARSaleReturnItemProductFactor;
                objSaleReturnItemsInfo.ARListOfSalesChannelType = objInvoicesInfo.ARListOfSalesChannelType;
                objSaleReturnItemsInfo.ARSaleReturnItemProductUnitCost = objInvoiceItemsInfo.ARInvoiceItemProductUnitCost;
                objSaleReturnItemsInfo.ARSaleReturnItemExchangeUnitCost = objInvoiceItemsInfo.ARInvoiceItemExchangeUnitCost;

                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                objSaleReturnItemsInfo.ARSaleReturnItemProductCustomerNumber = objProductsInfo.ICProductCustomerNumber;
                objSaleReturnItemsInfo.ARSaleReturnItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                objSaleReturnItemsInfo.ICProductNo = objProductsInfo.ICProductNo;
                //Generate sale return item components from invoice items
                objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>();
                objInvoiceItemsInfo.InvoiceItemComponentList.InitBOSList(null,
                                                        TableName.ARInvoiceItemsTableName,
                                                        TableName.ARInvoiceItemComponentsTableName,
                                                        BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
                List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                objInvoiceItemsInfo.InvoiceItemComponentList.Invalidate(components);

                if (objInvoiceItemsInfo.InvoiceItemComponentList.Count > 0)
                {
                    objSaleReturnItemsInfo.SaleReturnItemComponentList = new BOSList<ARSaleReturnItemComponentsInfo>();
                    objSaleReturnItemsInfo.SaleReturnItemComponentList.InitBOSList(this,
                                                        TableName.ARSaleReturnItemsTableName,
                                                        TableName.ARSaleReturnItemComponentsTableName,
                                                        BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                    objSaleReturnItemsInfo.SaleReturnItemComponentList.ItemTableForeignKey = "FK_ARSaleReturnItemID";
                    foreach (ARInvoiceItemComponentsInfo invoiceItemComponent in objInvoiceItemsInfo.InvoiceItemComponentList)
                    {
                        ARSaleReturnItemComponentsInfo saleReturnItemComponent = new ARSaleReturnItemComponentsInfo();
                        BOSUtil.CopyObject(invoiceItemComponent, saleReturnItemComponent);
                        objSaleReturnItemsInfo.SaleReturnItemComponentList.Add(saleReturnItemComponent);
                    }
                }

                SetProductPriceByProductUnitPrice(objSaleReturnItemsInfo);
                entity.SaleReturnItemsList.Add(objSaleReturnItemsInfo);
            }
        }

        /// <summary>
        /// Invalidate item components of the sale order items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)MainObject;
            List<ARSaleReturnItemsInfo> items = objSaleReturnItemsController.GetComponentItemsBySaleReturnID(objSaleReturnsInfo.ARSaleReturnID);
            ComponentSaleReturnItemList.Clear();
            ComponentSaleReturnItemList.OriginalList.Clear();
            foreach (ARSaleReturnItemsInfo item in items)
            {
                ComponentSaleReturnItemList.Add((ARSaleReturnItemsInfo)item.Clone());
            }

            foreach (ARSaleReturnItemsInfo item in ComponentSaleReturnItemList)
            {
                ComponentSaleReturnItemList.OriginalList.Add((ARSaleReturnItemsInfo)item.Clone());
            }
        }

        public override int CreateMainObject()
        {
            ARSaleReturnsInfo mainObject = (ARSaleReturnsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo;
            int iObjectID = 0;
            bool editObjectNo = true;
            if (mainObject.ARSaleReturnNo.Equals(cstNewObjectText))
            {
                editObjectNo = false;
            }
            iObjectID = base.CreateMainObject();
            if (!editObjectNo && iObjectID > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("SaleReturnSerialNo");
                if (objGENumberingInfo != null)
                {
                    UpdateSaleReturnSerialNo(objGENumberingInfo.GENumberingStart);
                    foreach (ARSaleReturnItemsInfo item in SaleReturnItemsList)
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                            && objProductsInfo.ICPriceCalculationMethodMethod == PriceCalculationMethod.Specific.ToString()
                            && !item.ARSaleReturnItemIsAverageCalculation
                            && string.IsNullOrEmpty(item.ARSaleReturnItemLotNo))
                        {
                            if (BOSApp.IsWoodTypeDocument(mainObject.ARSaleReturnProductType, SaleReturnItemsList.FirstOrDefault()))
                                item.ARSaleReturnItemLotNo = mainObject.ARSaleReturnSerialNo;
                        }
                    }
                }
            }
            return iObjectID;
        }

        public string GetSaleReturnSerialNo()
        {
            string lotNo = string.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("SaleReturnSerialNo");
            if (objGENumberingInfo != null)
            {
                lotNo = GenarateObjectNo(objGENumberingInfo);
            }
            return lotNo;
        }

        public void UpdateSaleReturnSerialNo(int numberingStart)
        {
            if (numberingStart > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("SaleReturnSerialNo");
                if (objGENumberingInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                       || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                       || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
                    {
                        objGENumberingInfo.GENumberingStart = 1;
                    }
                    else
                    {
                        objGENumberingInfo.GENumberingStart = objGENumberingInfo.GENumberingStart + 1;
                    }
                    objGENumberingInfo.AAUpdatedDate = currentDate;
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
        }
    }
}
