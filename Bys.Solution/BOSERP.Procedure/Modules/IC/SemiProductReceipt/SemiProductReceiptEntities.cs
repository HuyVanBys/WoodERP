using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BOSERP.Modules.SemiProductReceipt
{
    public class SemiProductReceiptEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        /// 
        public int CountItemsInReceiptPackageItemList = 0;

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }


        public BOSList<ICReceiptPackageItemsInfo> ReceiptPackageItemList { get; set; }

        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailShowList { get; set; }

        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailList { get; set; }

        public BOSList<ICReceiptPackageItemDetailsInfo> DeleteReceiptPackageItemDetailList { get; set; }

        public BOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailReportList { get; set; }

        public BOSList<ICInventoryItemPackagesInfo> InventoryItemPackageList { get; set; }

        #endregion

        #region Constructor
        public SemiProductReceiptEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ComponentReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();

            ReceiptPackageItemList = new BOSList<ICReceiptPackageItemsInfo>();
            ReceiptPackageItemDetailShowList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            DeleteReceiptPackageItemDetailList = new BOSList<ICReceiptPackageItemDetailsInfo>();
            ReceiptPackageItemDetailReportList = new BOSList<ICReceiptPackageItemDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICReceiptsInfo();
            SearchObject = new ICReceiptsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICReceiptItemsTableName, new ICReceiptItemsInfo());
            ModuleObjects.Add(TableName.ICReceiptPackageItemsTableName, new ICReceiptPackageItemsInfo());
            ModuleObjects.Add(TableName.ICReceiptPackageItemDetailsTableName, new ICReceiptPackageItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            ReceiptItemsList.InitBOSList(this,
                                                              TableName.ICReceiptsTableName,
                                                              TableName.ICReceiptItemsTableName,
                                                              BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ReceiptItemsList.ItemTableForeignKey = "FK_ICReceiptID";

            ComponentReceiptItemList.InitBOSList(this,
                                                TableName.ICReceiptsTableName,
                                                TableName.ICReceiptItemsTableName,
                                                BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ComponentReceiptItemList.ItemTableForeignKey = "FK_ICReceiptID";

            ReceiptPackageItemList.InitBOSList(this,
                                               TableName.ICReceiptsTableName,
                                               TableName.ICReceiptPackageItemsTableName,
                                               BOSList<ICReceiptPackageItemsInfo>.cstRelationForeign);
            ReceiptPackageItemList.ItemTableForeignKey = "FK_ICReceiptID";

            ReceiptPackageItemDetailShowList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailShowList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            ReceiptPackageItemDetailList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            DeleteReceiptPackageItemDetailList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            DeleteReceiptPackageItemDetailList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";

            ReceiptPackageItemDetailReportList.InitBOSList(this,
                                               TableName.ICReceiptPackageItemsTableName,
                                               TableName.ICReceiptPackageItemDetailsTableName,
                                               BOSList<ICReceiptPackageItemDetailsInfo>.cstRelationForeign);
            ReceiptPackageItemDetailReportList.ItemTableForeignKey = "FK_ICReceiptPackageItemID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(SemiProductReceiptModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(SemiProductReceiptModule.DocumentEntryGridControlName);

            ReceiptPackageItemList.InitBOSListGridControl("fld_dgcICReceiptPackageItems");
            ReceiptPackageItemDetailShowList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails");
            ReceiptPackageItemDetailList.InitBOSListGridControl();
            ReceiptPackageItemDetailReportList.InitBOSListGridControl("fld_dgcICReceiptPackageItemDetails2");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                ComponentReceiptItemList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();

                ReceiptPackageItemList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeleteReceiptPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                ReceiptPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
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

            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptDate = DateTime.Now;
            objReceiptsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            // objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.Receipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            //ReceiptItemsList.Invalidate(iObjectID);
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(iObjectID);
            //receiptItems.ForEach(o =>
            //{
            //    MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(o.FK_MMBatchProductItemID);
            //    if (objBatchProductItemsInfo != null)
            //    {
            //        o.ICReceiptItemSOName = objBatchProductItemsInfo.MMBatchProductItemSOName;
            //    }
            //});
            receiptItems = receiptItems.OrderBy(item => item.Id).ToList();
            ReceiptItemsList.Invalidate(receiptItems);
            InvalidateItemComponents();
            //ReceiptPackageItemList.Invalidate(iObjectID);
            ICReceiptComponentItemsController objReceiptComponentItemsController = new ICReceiptComponentItemsController();
            List<ICReceiptComponentItemsInfo> receiptComponentItemList = objReceiptComponentItemsController.GetReceiptComponentItemByReceiptID(iObjectID);

            // Invalidate receipt item packages
            if (receiptComponentItemList != null)
            {
                foreach (ICReceiptComponentItemsInfo objReceiptComponentItemsInfo in receiptComponentItemList)
                {
                    if (objReceiptComponentItemsInfo.ReceiptItemPackageList == null)
                    {
                        objReceiptComponentItemsInfo.ReceiptItemPackageList = new BOSList<ICReceiptItemPackagesInfo>();
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.InitBOSList(
                                                            this,
                                                            TableName.ICReceiptComponentItemsTableName,
                                                            TableName.ICReceiptItemPackagesTableName,
                                                            BOSList<ICReceiptItemPackagesInfo>.cstRelationForeign);
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.ItemTableForeignKey = "FK_ICReceiptComponentItemID";
                        objReceiptComponentItemsInfo.ReceiptItemPackageList.Invalidate(objReceiptComponentItemsInfo.ICReceiptComponentItemID);
                    }
                }

                CountItemsInReceiptPackageItemList = ReceiptPackageItemList.Count();
                ReceiptPackageItemList.Clear();

                bool isEditing = false;
                ReceiptPackageItemList.Invalidate(iObjectID);
                ReceiptPackageItemList.ForEach(o =>
                {
                    if (o.ICReceiptPackageItemID == 0)
                    {
                        isEditing = true;
                    }
                });
                if (!isEditing)
                {
                    ReceiptPackageItemDetailShowList.Clear();
                    ReceiptPackageItemList.ForEach(o =>
                    {
                        ICReceiptPackageItemDetailsController objReceiptPackageItemDetailsController = new ICReceiptPackageItemDetailsController();
                        List<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailList = objReceiptPackageItemDetailsController.GetPackageItemDetailsListByPackageItemID(o.ICReceiptPackageItemID);
                        ReceiptPackageItemDetailList.ForEach(x =>
                        {
                            ReceiptPackageItemDetailShowList.Add(x);
                        });
                    });
                }
                if (ReceiptPackageItemDetailShowList.GridControl != null)
                    ReceiptPackageItemDetailShowList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            ICReceiptsInfo mainobject = (ICReceiptsInfo)MainObject;
            ReceiptItemsList.SaveItemObjects();
            //SaveAccountingData();
        }
        public override bool CompleteTransaction()
        {
            ICReceiptsInfo mainobject = (ICReceiptsInfo)MainObject;
            mainobject.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public void UpdateTotalCost()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptSubTotalCost = 0;
            foreach (ICReceiptItemsInfo entItem in ReceiptItemsList)
            {
                objReceiptsInfo.ICReceiptSubTotalCost += entItem.ICReceiptItemTotalCost;
                BOSApp.RoundByCurrency(entItem, objReceiptsInfo.FK_GECurrencyID);
            }
            objReceiptsInfo.ICReceiptTotalCost = objReceiptsInfo.ICReceiptSubTotalCost;
            BOSApp.RoundByCurrency(objReceiptsInfo, objReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICReceiptItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICReceiptItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICReceiptsInfo objICReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo receiptItem = (ICReceiptItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                receiptItem.ICReceiptItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                receiptItem.ICReceiptItemProductType = objProductsInfo.ICProductType;
            }
        }

        /// <summary>
        /// Invalidate item components of the receipt items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            List<ICReceiptItemsInfo> items = objReceiptItemsController.GetComponentItemsByReceiptID(objReceiptsInfo.ICReceiptID);
            ComponentReceiptItemList.Clear();
            ComponentReceiptItemList.OriginalList.Clear();
            ComponentReceiptItemList.BackupList.Clear();
            foreach (ICReceiptItemsInfo item in items)
            {
                ComponentReceiptItemList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                ComponentReceiptItemList.OriginalList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemList)
            {
                ComponentReceiptItemList.BackupList.Add((ICReceiptItemsInfo)item.Clone());
            }
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objReceiptsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }
        #endregion

        //TNDLoc [ADD][27/11/2015][Semi Product Shipment],START
        public void GenerateReceiptItemFromShipmentItem(ICShipmentItemsInfo shipmentItem, int account)
        {
            decimal qty = 0;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
            BOSUtil.CopyObject(shipmentItem, objReceiptItemsInfo);
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = BOSApp.GetProductFromCurrentProductList(objReceiptItemsInfo.FK_ICProductID);
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
                    qty = Math.Round(shipmentItem.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                }
                else
                {
                    qty = Math.Round(shipmentItem.ICShipmentItemProductQty, 3, MidpointRounding.AwayFromZero);
                }
            }
            objReceiptItemsInfo.ICReceiptItemProductQty = qty;
            objReceiptItemsInfo.ICReceiptItemProductUnitCost = shipmentItem.ICShipmentItemProductUnitPrice;
            objReceiptItemsInfo.ICReceiptItemInventoryCost = shipmentItem.ICShipmentItemProductUnitPrice;
            objReceiptItemsInfo.ICReceiptItemExtCost = objReceiptItemsInfo.ICReceiptItemProductQty * objReceiptItemsInfo.ICReceiptItemProductUnitCost;
            objReceiptItemsInfo.ICReceiptItemTotalCost = objReceiptItemsInfo.ICReceiptItemProductQty * objReceiptItemsInfo.ICReceiptItemProductUnitCost;
            objReceiptItemsInfo.FK_ICShipmentItemID = shipmentItem.Id;
            objReceiptItemsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
            objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID > 0 ? objReceiptsInfo.FK_MMOperationID : shipmentItem.FK_MMOperationID;
            objReceiptItemsInfo.ICReceiptItemProductSupplierNo = shipmentItem.ICShipmentItemProductSupplierNo;
            objReceiptItemsInfo.FK_MMBatchProductProductionNormItemID = shipmentItem.FK_MMBatchProductProductionNormItemID;
            objReceiptItemsInfo.FK_MMBatchProductID = shipmentItem.FK_MMBatchProductID;
            objReceiptItemsInfo.FK_MMBatchProductItemID = shipmentItem.FK_MMBatchProductItemID;
            objReceiptItemsInfo.FK_ICProductForBatchID = shipmentItem.FK_ICProductForBatchID;
            objReceiptItemsInfo.FK_ACAccountID = account;
            ReceiptItemsList.Add(objReceiptItemsInfo);

        }

        public List<ICProductSerialNumbersInfo> GenerateProductSerialNumber()
        {
            List<ICProductSerialNumbersInfo> productSerialNumbers = new List<ICProductSerialNumbersInfo>();
            ICProductSerialNumbersController objProductSerialNumbersController = new ICProductSerialNumbersController();
            ICProductSerialNumbersInfo objProductSerialNumbersInfo;
            GENumberingController objNumberingController = new GENumberingController();
            GENumberingInfo objNumberingInfo;
            string productSerialNumber;
            ReceiptItemsList.ForEach(o =>
            {
                for (int i = 0; i < o.ICReceiptItemProductQty; i++)
                {
                    objNumberingInfo = (GENumberingInfo)objNumberingController.GetObjectByName("ProductSerialNumber");
                    DateTime currentDate = BOSApp.GetCurrentServerDate();

                    if (objNumberingInfo.AAUpdatedDate.Year < currentDate.Year)
                    {
                        objNumberingInfo.GENumberingStart = Convert.ToInt32(Math.Pow(10, objNumberingInfo.GENumberingLength - 1)) + 1;
                    }
                    objProductSerialNumbersInfo = new ICProductSerialNumbersInfo();
                    if (objNumberingInfo != null)
                    {
                        productSerialNumber = objNumberingInfo.GENumberingStart.ToString().PadLeft(objNumberingInfo.GENumberingLength, '0');
                        objProductSerialNumbersInfo.ICProductSerialNumberNo = string.Format(PurchaseReceiptLocalizedResources.ProductSerialNumberDefault, currentDate.Year.ToString().Substring(2, 2), productSerialNumber);
                        objProductSerialNumbersInfo.FK_ICProductID = o.FK_ICProductID;
                        objProductSerialNumbersInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                        objProductSerialNumbersController.CreateObject(objProductSerialNumbersInfo);
                        productSerialNumbers.Add(objProductSerialNumbersInfo);
                        objNumberingInfo.GENumberingStart++;
                        objNumberingController.UpdateObject(objNumberingInfo);
                    }
                }
            });

            return productSerialNumbers;
        }

        public void RemoveOldReceiptPackageItemDetailItem(IBOSList<ICReceiptPackageItemDetailsInfo> ReceiptPackageItemDetailsList)
        {
            List<ICReceiptPackageItemDetailsInfo> RemovePackageItemDetailsList = (List<ICReceiptPackageItemDetailsInfo>)ReceiptPackageItemDetailsList;
            RemovePackageItemDetailsList.ForEach(o =>
            {
                ReceiptPackageItemDetailShowList.ForEach(x =>
                {
                    if (o.FK_APPOPackageItemID > 0)
                    {
                        if (x.FK_APPOPackageItemID == o.FK_APPOPackageItemID)
                            ReceiptPackageItemDetailShowList.Remove(x);
                    }
                    else if (o.FK_APInvoiceInPackageItemID > 0)
                    {
                        if (x.FK_APInvoiceInPackageItemID == o.FK_APInvoiceInPackageItemID)
                            ReceiptPackageItemDetailShowList.Remove(x);
                    }
                    else if (x.FK_ICReceiptPackageItemID == o.FK_ICReceiptPackageItemID)
                        ReceiptPackageItemDetailShowList.Remove(x);
                });
            });
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            ICReceiptsInfo mainObject = (ICReceiptsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

            string mainObjectNo = objICStocksInfo == null
                                    ? base.GetMainObjectNo(ref numberingStart)
                                    : base.GetMainObjectNo(ref numberingStart, objICStocksInfo);
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            ICReceiptsInfo mainObject = (ICReceiptsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

            if (objICStocksInfo == null)
                base.UpdateObjectNumbering(numberingStart);
            else
                UpdateStockNumbering(numberingStart, objICStocksInfo);
        }

        public void UpdateStockNumbering(int numberingStart, ICStocksInfo objICStocksInfo)
        {
            GEStockNumberingsInfo objGEStockNumberingsInfo = (new GEStockNumberingsController()).GetGEStockNumberingByModuleNameAndStockID(Module.Name, objICStocksInfo.ICStockID);
            if (objGEStockNumberingsInfo != null)
            {
                objGEStockNumberingsInfo.GEStockNumberingStart = numberingStart + 1;
                (new GEStockNumberingsController()).UpdateObject(objGEStockNumberingsInfo);
            }
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            if (strTableName == TableName.ICReceiptsTableName)
            {
                ICReceiptsController objReceiptsController = new ICReceiptsController();
                objReceiptsController.DeleteSemiProductReceipt(iObjectID);
            }
        }
    }
}