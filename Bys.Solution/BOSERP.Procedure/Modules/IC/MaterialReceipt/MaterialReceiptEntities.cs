using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.MaterialReceipt
{
    public class MaterialReceiptEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        private int OriginalReceiptItemIDMax;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets receipt item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemList { get; set; }
        #endregion

        #region Constructor
        public MaterialReceiptEntities()
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

            ReceiptItemsList.InitBOSListGridControl(MaterialReceiptModule.ReceiptItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(MaterialReceiptModule.DocumentEntryGridControlName);
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
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.MaterialReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<ICReceiptItemsInfo> receiptItems = objReceiptItemsController.GetItemsByReceiptID(iObjectID);
            receiptItems.ForEach(o =>
            {
                MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(o.FK_MMBatchProductItemID);
                if (objBatchProductItemsInfo != null)
                {
                    o.ICReceiptItemSOName = objBatchProductItemsInfo.MMBatchProductItemSOName;
                }
            });
            ReceiptItemsList.Invalidate(receiptItems);

            //Invalidate components
            InvalidateItemComponents();
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            //objReceiptsInfo.FK_ACObjectID = objReceiptsInfo.FK_ACObjectID;
            //objReceiptsInfo.ICObjectType = ObjectType.Supplier.ToString();
            //int receiptID = base.SaveMainObject();
            //return receiptID;
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
                receiptItem.ICReceiptItemProductHeight = objProductsInfo.ICProductHeight;
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
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
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

        public override bool CompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();

            if (objReceiptsInfo.ICReceiptTypeCombo != null)
            {
                if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.MaterialReturnReceipt.ToString() || objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.MaterialRedundantReceipt.ToString())
                {
                    ((MaterialReceiptModule)Module).GenerateAllocationProposalFromMaterialReceipt();
                }
            }
            UpdateMainObject();
            ApprovedReceipt();


            return true;
        }

        public void GenerateEntitiesFromShipment(List<ICShipmentItemsInfo> shipmentItems)
        {
            shipmentItems.ForEach(o => ReceiptItemsList.Add(ToReceiptItem(o)));
        }

        public ICReceiptItemsInfo ToReceiptItem(ICShipmentItemsInfo objShipmentItemsInfo)
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;

            ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();

            objReceiptItemsInfo.FK_ICReceiptID = objReceiptsInfo.ICReceiptID;
            objReceiptItemsInfo.FK_ICShipmentID = objShipmentItemsInfo.FK_ICShipmentID;
            objReceiptItemsInfo.FK_ICShipmentItemID = objShipmentItemsInfo.Id;
            BOSUtil.CopyObject(objShipmentItemsInfo, objReceiptItemsInfo);
            objReceiptItemsInfo.FK_ICStockID = objShipmentItemsInfo.FK_ICStockID;
            objReceiptItemsInfo.ICReceiptItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo;
            objReceiptItemsInfo.ICReceiptItemProductQty = objShipmentItemsInfo.ICShipmentItemProductQty;
            objReceiptItemsInfo.ICReceiptItemProductFactor = objShipmentItemsInfo.ICShipmentItemProductFactor;
            objReceiptItemsInfo.ICReceiptItemQty1 = objShipmentItemsInfo.ICShipmentItemProductQty;
            objReceiptItemsInfo.ICReceiptItemProductQtyOld = objReceiptItemsInfo.ICReceiptItemProductQty;
            objReceiptItemsInfo.ICReceiptItemProductUnitPrice = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
            objReceiptItemsInfo.ICReceiptItemComment = objShipmentItemsInfo.ICShipmentItemComment;

            objReceiptItemsInfo.ICReceiptItemProductWidth = objShipmentItemsInfo.ICShipmentItemWidth;
            objReceiptItemsInfo.ICReceiptItemProductHeight = objShipmentItemsInfo.ICShipmentItemHeight;
            objReceiptItemsInfo.ICReceiptItemProductLength = objShipmentItemsInfo.ICShipmentItemLength;

            objReceiptItemsInfo.ICReceiptItemLenghtMin = objShipmentItemsInfo.ICShipmentItemLengthMin;
            objReceiptItemsInfo.ICReceiptItemWidthMin = objShipmentItemsInfo.ICShipmentItemWidthMin;
            objReceiptItemsInfo.ICReceiptItemProductPerimeter = objShipmentItemsInfo.ICShipmentItemPerimeter;

            objReceiptItemsInfo.ICReceiptItemLenghtMax = objShipmentItemsInfo.ICShipmentItemLengthMax;
            objReceiptItemsInfo.ICReceiptItemWidthMax = objShipmentItemsInfo.ICShipmentItemWidthMax;
            objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objShipmentItemsInfo.FK_ICProductAttributeTTMTID;
            objReceiptItemsInfo.FK_ICProductAttributeQualityID = objShipmentItemsInfo.FK_ICProductAttributeQualityID;
            objReceiptItemsInfo.FK_GECountryID = objShipmentItemsInfo.FK_GECountryID;
            objReceiptItemsInfo.ICReceiptItemSOName = objShipmentItemsInfo.ICShipmentItemSOName;

            ICProductsInfo product = BOSApp.GetProductFromCurrentProductList(objShipmentItemsInfo.FK_ICProductID);
            if (product != null && product.ICPriceCalculationMethodMethod == PriceCalculationMethod.Average.ToString())
                objReceiptItemsInfo.ICReceiptItemIsAverageCalculation = true;

            SetProductCostByProductUnitCost(objReceiptItemsInfo);
            return objReceiptItemsInfo;
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
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ReceiptItemsList.DeleteItemObjects();
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                objProductSeriesController.DeleteReferSeries(iObjectID);
            }
        }

        public override bool CancelCompleteTransaction()
        {
            ICReceiptsInfo mainObject = (ICReceiptsInfo)MainObject;
            bool isSuccess = base.CancelCompleteTransaction();
            if (!isSuccess)
                return false;

            mainObject.ICReceiptStatus = ReceiptStatus.New.ToString();
            UpdateMainObject();
            return isSuccess;
        }
    }
}

