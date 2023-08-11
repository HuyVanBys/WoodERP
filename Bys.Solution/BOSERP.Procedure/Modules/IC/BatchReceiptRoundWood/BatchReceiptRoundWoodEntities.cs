using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using BOSLib;
using BOSCommon;
using BOSComponent;
using System.Linq;
using Localization;

namespace BOSERP.Modules.BatchReceiptRoundWood
{
    public class BatchReceiptRoundWoodEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        private int OriginalReceiptItemIDMax;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public BatchReceiptRoundWoodEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ComponentReceiptItemList = new BOSItemsEntityList<ICReceiptItemsInfo>();
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
        }

        public override void InitGridControlInBOSList()
        {

            ReceiptItemsList.InitBOSListGridControl(BatchReceiptRoundWoodModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchReceiptRoundWoodModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                ComponentReceiptItemList.SetDefaultListAndRefreshGridControl();
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
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.SubRoundWood.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.ICReceiptReceiptType = ProductType.Roundwood.ToString();
            objReceiptsInfo.ICReceiptPackNo = GetProductWoodLotNo();
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptItemsList.Invalidate(iObjectID);

            //Invalidate components
            InvalidateItemComponents();
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            //objReceiptsInfo.FK_ACObjectID = objReceiptsInfo.FK_APSupplierID;
            //objReceiptsInfo.ICObjectType = ObjectType.Supplier.ToString();

            int receiptID = base.SaveMainObject();
            //SaveAccountingData();
            return receiptID;
        }

        public override void SaveModuleObjects()
        {
            //Save item list

            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();


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
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ICReceiptItemsInfo receiptItem = (ICReceiptItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                receiptItem.FK_ICProductAttributeWoodTypeID = objICReceiptsInfo.FK_ICProductAttributeWoodTypeID;
                receiptItem.FK_GECountryID = objICReceiptsInfo.FK_GECountryID;
                receiptItem.FK_MMBatchProductID = objICReceiptsInfo.FK_MMBatchProductID;
                receiptItem.FK_ICProductAttributeTTMTID = objICReceiptsInfo.FK_ICProductAttributeTTMTID;
                receiptItem.ICReceiptItemWoodQty = objICReceiptsInfo.ICReceiptTotalQty;
                receiptItem.ICReceiptItemContainerNo = objICReceiptsInfo.ICReceiptContainerNo;
                receiptItem.FK_MMOperationID = objICReceiptsInfo.FK_MMOperationID;
                receiptItem.FK_ICStockID = objICReceiptsInfo.FK_ICStockID;
                receiptItem.ICReceiptItemLotNo = objICReceiptsInfo.ICReceiptPackNo;
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
        public void ApprovedReceipt()
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            //Update status of stock receipt
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            //Generate product series
            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                if (item.ICReceiptItemLotNo.Trim() == string.Empty)
                    item.ICReceiptItemLotNo = receipt.ICReceiptPackNo;
            }
            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                if (!string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                    {
                        TransactionUtil.UpdateProductSerieQuantity(
                                                item.FK_ICProductID,
                                                item.FK_ICProductSerieID,
                                                TransactionUtil.cstInventoryReceipt,
                                                item.ICReceiptItemProductSerialNo,
                                                receipt.ICReceiptDate,
                                                item.FK_ICProductAttributeWoodTypeID,
                                                item.FK_ICProductAttributeTTMTID,
                                                item.FK_GECountryID,
                                                item.FK_ICProductAttributeQualityID,
                                                item.ICReceiptItemLotNo,
                                                item.ICReceiptItemWoodQty,
                                                item.ICReceiptItemLogListNo,
                                                item.ICReceiptItemContainerNo,
                                                item.ICReceiptItemProductDesc,
                                                item.ICReceiptItemProductHeight,
                                                item.ICReceiptItemProductWidth,
                                                item.ICReceiptItemProductLength,
                                                item.ICReceiptItemProductPerimeter,
                                                item.ICReceiptItemWidthMax,
                                                item.ICReceiptItemLenghtMax,
                                                item.ICReceiptItemProductPerimeterMax,
                                                item.ICReceiptItemWidthMin,
                                                item.ICReceiptItemLenghtMin);

                    }
                    ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                    if (objProductSeriesInfo != null)
                    {
                        item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                        if (!item.IsSubItem)
                        {
                            ICReceiptItemsInfo item1 = ReceiptItemsList.Where(i => i.ICReceiptItemID == item.ICReceiptItemID).FirstOrDefault();
                            if (item1 != null)
                            {
                                item1.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                            }
                        }
                    }
                }
            }

            //Update product series to the items
            ReceiptItemsList.SaveItemObjects();
           
            SaveAccountingData();
        }


        #region Accounting
        public override bool SaveAccountingData()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objReceiptsInfo.ICReceiptNo);
            if (!objReceiptsInfo.ICReceiptAcceptanceType.Equals(ReceiptAcceptanceType.RoundWoodSplit.ToString()))
            {
                foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                {
                    BOSUtil.CopyObject(objReceiptsInfo, objDocumentsInfo);
                }
            }
            else if (objReceiptsInfo.ICReceiptAcceptanceType.Equals(ReceiptAcceptanceType.RoundWoodSplit.ToString()))
            {
                if (docList != null)
                {
                    foreach (ACDocumentsInfo item in docList)
                    {
                        objDocumentsController.DeleteByID(item.ACDocumentID);
                    }
                }
            }
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (ACDocumentsInfo objDocumentsInfo in docList)
            {
               objDocumentEntrysController.DeleteByForeignColumn("FK_ACDocumentID", objDocumentsInfo.ACDocumentID);
            }
            foreach (ACDocumentEntrysInfo item in DocumentEntryList)
            {
                item.ACDocumentEntryID = 0;
            }
            return base.SaveAccountingData();
        }
        #endregion

        public override bool CompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();

            ApprovedReceipt();
            ((BatchReceiptRoundWoodModule)Module).UpdateShipmentItemReference();
            //ModuleAfterCompleted();

            return true;
        }
    }
}

