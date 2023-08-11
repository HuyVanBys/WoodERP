using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP.Modules.ReceiptCD
{
    public class ReceiptCDEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSItemsEntityList<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        #endregion

        #region Constructor
        public ReceiptCDEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();

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


        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(ReceiptCDModule.ReceiptItemGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();

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
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.ReceiptCD.ToString();
            objReceiptsInfo.ICReceiptAcceptanceType = ReceiptCDAcceptanceType.RoundWood.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ReceiptItemsList.Invalidate(iObjectID);


        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {

            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ReceiptItemsList.SaveItemObjects();
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
            }
        }
        public override bool CompleteTransaction()
        {
            ICReceiptsInfo receipt = (ICReceiptsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();

            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();

            ICReceiptsController objReceiptCDsController = new ICReceiptsController();
            receipt.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();
            //objReceiptCDsController.UpdateObject(objReceiptInfo);
            List<ICProductsInfo> productList = objProductsController.GetListProductByICReceiptID(receipt.ICReceiptID);

            foreach (ICReceiptItemsInfo item in ReceiptItemsList)
            {
                if (!string.IsNullOrEmpty(item.ICReceiptItemProductSerialNo))
                {
                    //objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    objProductsInfo = (ICProductsInfo)productList.Where(p => p.ICProductID == item.FK_ICProductID).FirstOrDefault();
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
                            ICReceiptItemsInfo item1 = ReceiptItemsList.Where(i => i.Id == item.Id).FirstOrDefault();
                            if (item1 != null)
                            {
                                item1.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                            }
                        }
                    }
                }
            }
            //Update product series to the items
            ReceiptItemsList.SaveItemCDObjects();
            return true;
        }
    }
}
