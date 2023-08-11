using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.SemiProductShipment
{
    public class SemiProductShipmentEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets shipment item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }
        #endregion

        #region Constructor
        public SemiProductShipmentEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ComponentShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ComponentShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ComponentShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(SemiProductShipmentModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(SemiProductShipmentModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                ComponentShipmentItemList.SetDefaultListAndRefreshGridControl();
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

            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.SemiProductShipment.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            ICImportAndExportReasonsInfo reason = (new ICImportAndExportReasonsController()).GetImportAndExportReasonByModuleName(this.Module.Name);
            objShipmentsInfo.FK_ACEquipmentShipmentReasonID = reason != null ? reason.ICImportAndExportReasonID : 0;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            //ShipmentItemList.Invalidate(iObjectID);
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = objShipmentItemsController.GetItemByShipmentID(iObjectID);
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            shipmentItemList.ForEach(o =>
            {
                MMBatchProductItemsInfo objBatchProducItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(o.FK_MMBatchProductItemID);
                if (objBatchProducItemsInfo != null)
                {
                    o.ICShipmentItemSOName = objBatchProducItemsInfo.MMBatchProductItemSOName;
                }    
            });
            ShipmentItemList.Invalidate(shipmentItemList.OrderBy(o => o.Id).ToList());
            //Invalidate item components
            InvalidateItemComponents();
        }
        #endregion

        #region Save Module Objects functions        
        public override void SaveModuleObjects()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            if (objShipmentsInfo.ICShipmentStatus != ShipmentStatus.EditAfterComplete.ToString())
            {
                ShipmentItemList.SaveItemObjects();
                SaveAccountingData();
            }
            else
            {
                objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
                UpdateMainObject();
            }
        }

        public override bool CompleteTransaction()
        {
            ICShipmentsInfo shipment = (ICShipmentsInfo)MainObject;
            shipment.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            InvalidateItemComponents();
            return base.CompleteTransaction();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ICShipmentItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.ICShipmentItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
                ICShipmentItemsInfo shipmentItem = (ICShipmentItemsInfo)item;
                shipmentItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(objProductsInfo.ICProductID, shipmentItem);
                shipmentItem.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
                shipmentItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                shipmentItem.ICShipmentItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
            }
        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Invalidate item components of the shipment items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetComponentItemsByShipmentID(objShipmentsInfo.ICShipmentID);
            ComponentShipmentItemList.Clear();
            ComponentShipmentItemList.OriginalList.Clear();
            ComponentShipmentItemList.BackupList.Clear();
            foreach (ICShipmentItemsInfo item in items)
            {
                ComponentShipmentItemList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.OriginalList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.BackupList.Add((ICShipmentItemsInfo)item.Clone());
            }
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objOperationsInfo != null)
            {
                if (objOperationsInfo.MMOperationNo != OperationNo.Thanhpham.ToString() ||
                    (objOperationsInfo.MMOperationNo == OperationNo.Thanhpham.ToString() && objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.SemiProductShipmentTransfer.ToString()))
                {


                    List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objShipmentsInfo.ICShipmentNo);
                    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                    {
                        BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
                    }
                    if (docList != null)
                    {
                        foreach (ACDocumentsInfo item in docList)
                        {
                            objDocumentsController.DeleteByID(item.ACDocumentID);
                        }
                    }
                    foreach (ACDocumentEntrysInfo item in DocumentEntryList)
                    {
                        item.ACDocumentEntryID = 0;
                    }

                    return base.SaveAccountingData();
                }
                else
                {

                    List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objShipmentsInfo.ICShipmentNo);
                    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                    {
                        objDocumentsController.DeleteByID(objDocumentsInfo.ACDocumentID);
                    }

                }

            }
            return false;
        }
        #endregion

        public void GenerateShipmentItemFromReceiptItemBTP(ICReceiptItemsInfo receiptItem)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(receiptItem.FK_ICProductID);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            BOSUtil.CopyObject(receiptItem, objShipmentItemsInfo);
            if (receiptItem.FK_ACAccountID == 0 && objProductsInfo != null)
            {
                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
            }
            objShipmentItemsInfo.FK_ICReceiptItemID = receiptItem.Id;
            objShipmentItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
            objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
            objShipmentItemsInfo.ICShipmentItemProductSerialNo = receiptItem.ICReceiptItemProductSerialNo;
            objShipmentItemsInfo.ICShipmentItemProductQty = receiptItem.ICReceiptItemProductRemainQty;
            objShipmentItemsInfo.ICShipmentItemProductSupplierNo = receiptItem.ICReceiptItemProductSupplierNo;
            objShipmentItemsInfo.FK_MMBatchProductID = receiptItem.FK_MMBatchProductID;
            objShipmentItemsInfo.FK_MMBatchProductItemID = receiptItem.FK_MMBatchProductItemID;
            objShipmentItemsInfo.FK_ICProductForBatchID = receiptItem.FK_ICProductForBatchID;
            objShipmentItemsInfo.FK_ICProductID = receiptItem.FK_ICProductID;
            objShipmentItemsInfo.ICShipmentItemHeight = receiptItem.ICReceiptItemProductHeight;
            objShipmentItemsInfo.ICShipmentItemWidth = receiptItem.ICReceiptItemProductWidth;
            objShipmentItemsInfo.ICShipmentItemLength = receiptItem.ICReceiptItemProductLength;
            objShipmentItemsInfo.FK_MMBatchProductProductionNormItemID = receiptItem.FK_MMBatchProductProductionNormItemID;
            SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
            objShipmentItemsInfo.ICShipmentItemProductQty = receiptItem.ICReceiptItemProductRemainQty;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductFactor;

            ShipmentItemList.Add(objShipmentItemsInfo);
        }


        public ICShipmentItemsInfo GenerateShipmentItemFromReceiptItem(ICReceiptItemsInfo receiptItem)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(receiptItem.FK_ICProductID);
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            BOSUtil.CopyObject(receiptItem, objShipmentItemsInfo);
            if (objShipmentsInfo.FK_MMOperationID > 0)
            {
                objShipmentItemsInfo.FK_ACAccountID = ((SemiProductShipmentModule)Module).GetAccountByOperation(objShipmentsInfo.FK_MMOperationID, objShipmentsInfo.FK_ICStockID);
            }
            else if (receiptItem.FK_ACAccountID == 0 && objProductsInfo != null)
            {
                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
            }
            objShipmentItemsInfo.FK_ICReceiptItemID = receiptItem.Id;
            objShipmentItemsInfo.FK_ICStockID = objShipmentsInfo.FK_ICStockID;
            objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = receiptItem.ICReceiptItemProductUnitCost;
            objShipmentItemsInfo.ICShipmentItemProductSerialNo = receiptItem.ICReceiptItemProductSerialNo;
            //objShipmentItemsInfo.ICShipmentItemProductQty = receiptItem.ReceiptItemRemainQty;
            objShipmentItemsInfo.ICShipmentItemProductQty = receiptItem.ICReceiptItemProductRemainQty;
            objShipmentItemsInfo.ICShipmentItemProductSupplierNo = receiptItem.ICReceiptItemProductSupplierNo;
            objShipmentItemsInfo.ICShipmentItemHeight = receiptItem.ICReceiptItemProductHeight;
            objShipmentItemsInfo.ICShipmentItemWidth = receiptItem.ICReceiptItemProductWidth;
            objShipmentItemsInfo.ICShipmentItemLength = receiptItem.ICReceiptItemProductLength;
            objShipmentItemsInfo.FK_ICProductForBatchID = receiptItem.FK_ICProductForBatchID;
            objShipmentItemsInfo.FK_MMBatchProductID = receiptItem.FK_MMBatchProductID;
            objShipmentItemsInfo.FK_MMBatchProductItemID = receiptItem.FK_MMBatchProductItemID;
            objShipmentItemsInfo.FK_MMBatchProductProductionNormItemID = receiptItem.FK_MMBatchProductProductionNormItemID;
            SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
            objShipmentItemsInfo.ICShipmentItemProductQty = receiptItem.ICReceiptItemProductRemainQty;
            objShipmentItemsInfo.ICShipmentItemProductExchangeQty = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductFactor;

            return objShipmentItemsInfo;
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

            string mainObjectNo = objICStocksInfo == null
                                    ? base.GetMainObjectNo(ref numberingStart)
                                    : base.GetMainObjectNo(ref numberingStart, objICStocksInfo);
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
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

        public override bool CancelCompleteTransaction()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            mainObject.ICShipmentStatus = ShipmentStatus.New.ToString();
            UpdateMainObject();
            return true;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            if (strTableName == TableName.ICShipmentsTableName)
            {
                ICShipmentsController shipmentsController = new ICShipmentsController();
                shipmentsController.DeleteSemiProductShipment(iObjectID);
            }
        }
    }
}
