using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BOSERP.Modules.ReturnShipping
{
    public class ReturnShippingEntities : GLReceiptEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        public BOSItemsEntityList<ICReceiptItemsInfo> ComponentReceiptItemsList { get; set; }


        #endregion

        #region Constructor
        public ReturnShippingEntities()
            : base()
        {
            ReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
            ComponentReceiptItemsList = new BOSItemsEntityList<ICReceiptItemsInfo>();
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

            ComponentReceiptItemsList.InitBOSList(this,
                                            TableName.ICReceiptsTableName,
                                            TableName.ICReceiptItemsTableName,
                                            BOSItemsEntityList<ICReceiptItemsInfo>.cstRelationForeign);
            ComponentReceiptItemsList.ItemTableForeignKey = "FK_ICReceiptID";
        }

        public override void InitGridControlInBOSList()
        {
            ReceiptItemsList.InitBOSListGridControl(ReturnShippingModule.ReceiptItemsGridControlName);
            DocumentEntryList.InitBOSListGridControl(ReturnShippingModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ReceiptItemsList.SetDefaultListAndRefreshGridControl();
                ComponentReceiptItemsList.SetDefaultListAndRefreshGridControl();
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
            objReceiptsInfo.ICReceiptDate = BOSApp.GetCurrentServerDate();
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.ReturnShipping.ToString();
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemsList = objReceiptItemsController.GetReceiptItemForReturnShipping(iObjectID);
            ReceiptItemsList.Invalidate(receiptItemsList);
            InvalidateItemComponents();
            
            ICReceiptItemsInfo item = ReceiptItemsList.FirstOrDefault(o => o.FK_ICShipmentID > 0);
            if(item != null)
            {
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
                ICShipmentsController objShipmentsController = new ICShipmentsController();
                objReceiptsInfo.ICShipmentNo = objShipmentsController.GetObjectNoByID(item.FK_ICShipmentID);
            }
        }

        public void InvalidateItemComponents()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> items = objReceiptItemsController.GetComponentItemsByReceiptID(objReceiptsInfo.ICReceiptID);
            ComponentReceiptItemsList.Clear();
            ComponentReceiptItemsList.OriginalList.Clear();
            ComponentReceiptItemsList.BackupList.Clear();
            foreach (ICReceiptItemsInfo item in items)
            {
                ComponentReceiptItemsList.Add((ICReceiptItemsInfo)item.Clone());
            }

            foreach (ICReceiptItemsInfo item in ComponentReceiptItemsList)
            {
                ComponentReceiptItemsList.OriginalList.Add((ICReceiptItemsInfo)item.Clone());
            }
            if (objReceiptsInfo.ICReceiptStatus == ReceiptStatus.Complete.ToString())
            {
                foreach (ICReceiptItemsInfo item in ComponentReceiptItemsList)
                {
                    ComponentReceiptItemsList.BackupList.Add((ICReceiptItemsInfo)item.Clone());
                }
            }
        }

        public override void SaveModuleObjects()
        {
            ReceiptItemsList.SaveItemObjects();
            SaveAccountingData();
        }

        public override bool CompleteTransaction()
        {
            //Update the sale return's status
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            UpdateMainObject();

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ReceiptItemsList.ForEach(o =>
            {
                ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsController.GetObjectByID(o.FK_ICShipmentItemID);
                if (objShipmentItemsInfo == null)
                    return;
                objShipmentItemsInfo.ICShipmentItemQty1 += o.ICReceiptItemProductQty;
                objShipmentItemsController.UpdateObject(objShipmentItemsInfo);

                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(o.FK_ICShipmentItemID);
                if (objSaleOrderItemsInfo != null)
                {
                    objSaleOrderItemsInfo.ARSaleOrderItemQty1 += o.ICReceiptItemProductQty;
                    objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                }

                //if (o.FK_ICProductSerieID == 0)
                //{
                //    objProductSeriesInfo = new ICProductSeriesInfo();
                //    objProductSeriesInfo.ICProductSerieNo = o.ICReceiptItemProductSerialNo;
                //    objProductSeriesInfo.ICProductSerieLotNo = o.ICReceiptItemProductSerialNo;
                //    objProductSeriesInfo.FK_ICProductID = o.FK_ICProductID;
                //    objProductSeriesInfo.ICInventoryStockQuantity = o.ICReceiptItemProductQty;
                //    objProductSeriesInfo.ICProductSerieProductDesc = o.ICReceiptItemProductDesc;
                //    o.FK_ICProductSerieID = objProductSeriesController.CreateObject(objProductSeriesInfo);
                //}
                //objReceiptItemsController.UpdateObject(o);
            });

            InvalidateItemComponents();
            return base.CompleteTransaction();
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
            //objReceiptItemsInfo.ICReceiptItemProductDiscount = objShipmentItemsInfo.ICShipmentItemProductDiscount;
            //objReceiptItemsInfo.ICReceiptItemProductTaxPercent = objShipmentItemsInfo.ICShipmentItemProductTaxPercent;
            objReceiptItemsInfo.FK_ICStockID = objShipmentItemsInfo.FK_ICStockID;
            objReceiptItemsInfo.ICReceiptItemProductSerialNo = objShipmentItemsInfo.ICShipmentItemProductSerialNo;
            objReceiptItemsInfo.ICReceiptItemProductQty = objShipmentItemsInfo.ICShipmentItemProductQtyReturn;
            objReceiptItemsInfo.ICReceiptItemQty1 = objShipmentItemsInfo.ICShipmentItemProductQty;
            objReceiptItemsInfo.ICReceiptItemProductQtyOld = objReceiptItemsInfo.ICReceiptItemProductQty;
            objReceiptItemsInfo.ICReceiptItemProductUnitPrice = objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
            objReceiptItemsInfo.ICReceiptDate = objShipmentItemsInfo.ICShipmentDate;
            objReceiptItemsInfo.ICReceiptItemWoodQty = objShipmentItemsInfo.ICShipmentItemWoodQty;
            objReceiptItemsInfo.ICReceiptItemProductUnitCost = AccountHelper.GetProductUnitCost(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo.ICReceiptItemProductSerialNo, objReceiptsInfo.ICShipmentDate);
            SetProductCostByProductUnitCost(objReceiptItemsInfo);
            return objReceiptItemsInfo;
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objReceiptsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACObjectID = objReceiptsInfo.FK_ACObjectID;
                objDocumentsInfo.ACObjectType = objReceiptsInfo.ICObjectType;
                objDocumentsInfo.ACDocumentDate = objReceiptsInfo.ICReceiptDate;
                objDocumentsInfo.ACDocumentInvoiceDate = objReceiptsInfo.ICReceiptDate;
            }

            return base.SaveAccountingData();
        }

        public void UpdateTotalAmount()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;
            objReceiptsInfo.ICReceiptTotalCost = 0;
            foreach (ICReceiptItemsInfo entItem in ReceiptItemsList)
            {
                objReceiptsInfo.ICReceiptTotalCost += entItem.ICReceiptItemProductUnitCost * entItem.ICReceiptItemProductQty;
                BOSApp.RoundByCurrency(entItem, objReceiptsInfo.FK_GECurrencyID);
            }
            BOSApp.RoundByCurrency(objReceiptsInfo, objReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
        #endregion

        public override void AfterCompleteTransaction()
        {
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)MainObject;

            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            objProductSeriesController.GenerateProductSerieByReceiptID(objReceiptsInfo.ICReceiptID);
        }
    }
}
