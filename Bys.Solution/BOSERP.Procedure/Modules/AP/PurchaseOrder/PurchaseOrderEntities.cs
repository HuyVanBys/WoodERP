using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP.Modules.PurchaseOrder
{
    class PurchaseOrderEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion
        #region Public Properties
        public int CountItemsInPOPackageItemList = 0;
        public BOSItemsEntityList<APPurchaseOrderItemsInfo> PurchaseOrderItemList { get; set; }
        public BOSList<APProposalItemsInfo> ProposalItemList { get; set; }
        public BOSList<APPurchaseOrdersInfo> PurchaseOrderList { get; set; }
        public BOSItemsEntityList<APPurchaseOrderItemsInfo> ComponentPurchaseOrderItemList { get; set; }
        public BOSList<APPurchaseOrderPaymentTimesInfo> APPurchaseOrderPaymentTimesList { get; set; }
        public BOSList<APPurchaseOrderItemOutSourcingsInfo> PurchaseOrderItemOutSourcingList { get; set; }
        public BOSList<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }
        public BOSList<APPOPackageItemsInfo> POPackageItemList { get; set; }
        public BOSList<APPOPackageItemDetailsInfo> POPackageItemDetailShowList { get; set; }
        public BOSList<APPOPackageItemDetailsInfo> POPackageItemDetailList { get; set; }
        public BOSList<APPOPackageItemDetailsInfo> DeletePOPackageItemDetailList { get; set; }
        public BOSList<APPOPackageItemDetailsInfo> POPackageItemDetailReportList { get; set; }
        public BOSList<APPurchaseOrderItemDeliverysInfo> APPurchaseOrderItemDeliveryList { get; set; }
        #endregion

        #region Constructor
        public PurchaseOrderEntities()
            : base()
        {
            PurchaseOrderItemList = new BOSItemsEntityList<APPurchaseOrderItemsInfo>();
            ProposalItemList = new BOSList<APProposalItemsInfo>();
            ComponentPurchaseOrderItemList = new BOSItemsEntityList<APPurchaseOrderItemsInfo>();
            APPurchaseOrderPaymentTimesList = new BOSList<APPurchaseOrderPaymentTimesInfo>();
            PurchaseOrderList = new BOSList<APPurchaseOrdersInfo>();
            SaleOrderItemList = new BOSList<ARSaleOrderItemsInfo>();
            POPackageItemList = new BOSList<APPOPackageItemsInfo>();
            POPackageItemDetailShowList = new BOSList<APPOPackageItemDetailsInfo>();
            POPackageItemDetailList = new BOSList<APPOPackageItemDetailsInfo>();
            DeletePOPackageItemDetailList = new BOSList<APPOPackageItemDetailsInfo>();
            POPackageItemDetailReportList = new BOSList<APPOPackageItemDetailsInfo>();
            PurchaseOrderItemOutSourcingList = new BOSList<APPurchaseOrderItemOutSourcingsInfo>();
            APPurchaseOrderItemDeliveryList = new BOSList<APPurchaseOrderItemDeliverysInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APPurchaseOrdersInfo();
            SearchObject = new APPurchaseOrdersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APPurchaseOrderItemsTableName, new APPurchaseOrderItemsInfo());
            ModuleObjects.Add(TableName.APProposalItemsTableName, new APProposalItemsInfo());
            ModuleObjects.Add(TableName.GELocationsTableName, new GELocationsInfo());
            ModuleObjects.Add(TableName.APPurchaseOrderPaymentTimesTableName, new APPurchaseOrderPaymentTimesInfo());
            ModuleObjects.Add(TableName.APPurchaseOrdersTableName, new APPurchaseOrdersInfo());
            ModuleObjects.Add(TableName.ARSaleOrderItemsTableName, new ARSaleOrderItemsInfo());
            ModuleObjects.Add(TableName.APPOPackageItemsTableName, new APPOPackageItemsInfo());
            ModuleObjects.Add(TableName.APPOPackageItemDetailsTableName, new APPOPackageItemDetailsInfo());
            ModuleObjects.Add(TableName.APPurchaseOrderItemOutSourcingsTableName, new APPurchaseOrderItemOutSourcingsInfo());
            ModuleObjects.Add(TableName.APPurchaseOrderItemDeliverysTableName, new APPurchaseOrderItemDeliverysInfo());
        }

        public override void InitModuleObjectList()
        {
            PurchaseOrderItemList.InitBOSList(this,
                                                 TableName.APPurchaseOrdersTableName,
                                                 TableName.APPurchaseOrderItemsTableName,
                                                 BOSList<APPurchaseOrderItemsInfo>.cstRelationForeign);
            PurchaseOrderItemList.ItemTableForeignKey = "FK_APPurchaseOrderID";

            ProposalItemList.InitBOSList(this,
                                         null,
                                         TableName.APProposalItemsTableName,
                                         BOSList<APProposalItemsInfo>.cstRelationNone);
            PurchaseOrderList.InitBOSList(this,
                                         null,
                                         TableName.APPurchaseOrdersTableName,
                                         BOSList<APPurchaseOrdersInfo>.cstRelationNone);
            APPurchaseOrderPaymentTimesList.InitBOSList(
                                             this,
                                             TableName.APPurchaseOrdersTableName,
                                             TableName.APPurchaseOrderPaymentTimesTableName,
                                             BOSList<APPurchaseOrderPaymentTimesInfo>.cstRelationForeign);
            APPurchaseOrderPaymentTimesList.ItemTableForeignKey = "FK_APPurchaseOrderID";

            SaleOrderItemList.InitBOSList(this
                                            , null
                                            , TableName.ARSaleOrderItemsTableName
                                            , BOSList<ARSaleOrderItemsInfo>.cstRelationNone);

            POPackageItemList.InitBOSList(this,
                                               TableName.APPurchaseOrdersTableName,
                                               TableName.APPOPackageItemsTableName,
                                               BOSList<APPOPackageItemsInfo>.cstRelationForeign);
            POPackageItemList.ItemTableForeignKey = "FK_APPurchaseOrderID";

            POPackageItemDetailShowList.InitBOSList(this,
                                               TableName.APPOPackageItemsTableName,
                                               TableName.APPOPackageItemDetailsTableName,
                                               BOSList<APPOPackageItemDetailsInfo>.cstRelationForeign);
            POPackageItemDetailShowList.ItemTableForeignKey = "FK_APPOPackageItemID";

            POPackageItemDetailList.InitBOSList(this,
                                               TableName.APPOPackageItemsTableName,
                                               TableName.APPOPackageItemDetailsTableName,
                                               BOSList<APPOPackageItemDetailsInfo>.cstRelationForeign);
            POPackageItemDetailList.ItemTableForeignKey = "FK_APPOPackageItemID";

            DeletePOPackageItemDetailList.InitBOSList(this,
                                               TableName.APPOPackageItemsTableName,
                                               TableName.APPOPackageItemDetailsTableName,
                                               BOSList<APPOPackageItemDetailsInfo>.cstRelationForeign);
            DeletePOPackageItemDetailList.ItemTableForeignKey = "FK_APPOPackageItemID";

            POPackageItemDetailReportList.InitBOSList(this,
                                               TableName.APPOPackageItemsTableName,
                                               TableName.APPOPackageItemDetailsTableName,
                                               BOSList<APPOPackageItemDetailsInfo>.cstRelationForeign);
            POPackageItemDetailReportList.ItemTableForeignKey = "FK_APPOPackageItemID";

            PurchaseOrderItemOutSourcingList.InitBOSList(this,
                                                        TableName.APPurchaseOrdersTableName,
                                                        TableName.APPurchaseOrderItemOutSourcingsTableName,
                                                        BOSList<APPurchaseOrderItemOutSourcingsInfo>.cstRelationForeign);
            PurchaseOrderItemOutSourcingList.ItemTableForeignKey = "FK_APPurchaseOrderID";

            APPurchaseOrderItemDeliveryList.InitBOSList(this,
                                                 TableName.APPurchaseOrdersTableName,
                                                 TableName.APPurchaseOrderItemDeliverysTableName,
                                                 BOSList<APPurchaseOrderItemDeliverysInfo>.cstRelationForeign);
            APPurchaseOrderItemDeliveryList.ItemTableForeignKey = "FK_APPurchaseOrderID";
        }

        public override void InitGridControlInBOSList()
        {
            PurchaseOrderItemList.InitBOSListGridControl(PurchaseOrderModule.PurchaseOrderItemGridControlName);
            ProposalItemList.InitBOSListGridControl();
            APPurchaseOrderPaymentTimesList.InitBOSListGridControl();
            //PurchaseOrderList.InitBOSListGridControl();
            SaleOrderItemList.InitBOSListGridControl("fld_dgcARSaleOrder");
            POPackageItemList.InitBOSListGridControl("fld_dgcAPPOPackageItems");
            POPackageItemDetailShowList.InitBOSListGridControl("fld_dgcAPPOPackageItemDetails");
            POPackageItemDetailList.InitBOSListGridControl();
            POPackageItemDetailReportList.InitBOSListGridControl("fld_dgcAPPOPackageItemDetails2");
            PurchaseOrderItemOutSourcingList.InitBOSListGridControl("fld_dgcAPPurchaseOrderItemOutSourcingsGridControl");
            APPurchaseOrderItemDeliveryList.InitBOSListGridControl("fld_dgcAPPurchaseOrderItemDeliverys");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PurchaseOrderItemList.SetDefaultListAndRefreshGridControl();

                //ProposalItemList.SetDefaultListAndRefreshGridControl();
                ComponentPurchaseOrderItemList.SetDefaultListAndRefreshGridControl();
                APPurchaseOrderPaymentTimesList.SetDefaultListAndRefreshGridControl();
                SaleOrderItemList.SetDefaultListAndRefreshGridControl();
                POPackageItemList.SetDefaultListAndRefreshGridControl();
                POPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                POPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeletePOPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                POPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
                PurchaseOrderItemOutSourcingList.SetDefaultListAndRefreshGridControl();
                APPurchaseOrderItemDeliveryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();

            List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objPurchaseOrderItemsController.GetListObjectByFK_APPurchaseOrderID(iObjectID);
            PurchaseOrderItemList.Invalidate(purchaseOrderItemList.Where(o => o.APPurchaseOrderItemDivision == PurchaseOrderItemDivision.Product.ToString()).ToList());

            foreach (APPurchaseOrderItemsInfo entItem in PurchaseOrderItemList)
            {
                entItem.APPurchaseOrderItemRemainedQty = entItem.APPurchaseOrderItemProductExchangeQty - entItem.APPurchaseOrderItemProductCanceledQty - entItem.APPurchaseOrderItemReceiptedQty;
                entItem.ICProductOrigin = entItem.APPurchaseOrderItemProductOrigin;
            }

            //Invalidate item components
            InvalidateItemComponents();

            //InvalidatePOPaymentTime(iObjectID);
            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            List<APPurchaseOrderPaymentTimesInfo> listPaymentTimes = (List<APPurchaseOrderPaymentTimesInfo>)objPurchaseOrderPaymentTimesController.GetListPaymentTimeByAPPurchaseOrderID(iObjectID);
            APPurchaseOrderPaymentTimesList.Invalidate(listPaymentTimes);

            CountItemsInPOPackageItemList = POPackageItemList.Count();
            POPackageItemList.Clear();

            bool isEditing = false;
            POPackageItemList.Invalidate(iObjectID);
            POPackageItemList.ForEach(o =>
            {
                if (o.APPOPackageItemID == 0)
                {
                    isEditing = true;
                }
            });
            if (!isEditing)
            {
                POPackageItemDetailShowList.Clear();
                POPackageItemList.ForEach(o =>
                {
                    APPOPackageItemDetailsController objPOPackageItemDetailsController = new APPOPackageItemDetailsController();
                    List<APPOPackageItemDetailsInfo> POPackageItemDetailList = objPOPackageItemDetailsController.GetPackageItemDetailsListByPackageItemID(o.APPOPackageItemID);
                    POPackageItemDetailList.ForEach(x =>
                    {
                        POPackageItemDetailShowList.Add(x);
                    });
                });
            }
            POPackageItemDetailShowList.GridControl?.RefreshDataSource();
            PurchaseOrderItemOutSourcingList.Invalidate(iObjectID);
            APPurchaseOrderItemDeliveryList.Invalidate(iObjectID);
        }

        public void InvalidatePOPaymentTime(int iObjectID)
        {
            APPurchaseOrderPaymentTimesController objPOPaymentTimeController = new APPurchaseOrderPaymentTimesController();
            List<APPurchaseOrderPaymentTimesInfo> list = objPOPaymentTimeController.GetPaidPaymentTimeByPurchaseOrderID(iObjectID);
            APPurchaseOrderPaymentTimesList.Invalidate(list);
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            //Set default date to now when create a new purchase order.
            objPurchaseOrdersInfo.APPurchaseOrderApproveStatus = ApproveStatus.NeedApprove;
            objPurchaseOrdersInfo.APPurchaseOrderDate = DateTime.Now;
            objPurchaseOrdersInfo.APPurchaseOrderDeliveryDate = BOSApp.GetCurrentServerDate();
            objPurchaseOrdersInfo.APPurchaseOrderContractDate = BOSApp.GetCurrentServerDate();
            objPurchaseOrdersInfo.APPurchaseOrderValidateDate = BOSApp.GetCurrentServerDate();
            objPurchaseOrdersInfo.APPurchaseOrderPackingDate = BOSApp.GetCurrentServerDate();
            objPurchaseOrdersInfo.APPurchaseOrderType = PurchaseOrderType.SaleOrder.ToString();
            objPurchaseOrdersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objPurchaseOrdersInfo.APPurchaseOrderExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objPurchaseOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objPurchaseOrdersInfo.APPurchaseOrderInvoiceAddressLine3 = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine1;
            objPurchaseOrdersInfo.APPurchaseOrderDeliveryAddressLine3 = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine3;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                objPurchaseOrdersInfo.FK_ICStockID = objStocksInfo.ICStockID;
            }

            //Set status
            objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.New.ToString();

            objPurchaseOrdersInfo.FK_APPurchasingStaffID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;

            UpdateMainObjectBindingSource();
        }

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            //Reset purchase stock by the selected branch
            foreach (APPurchaseOrderPaymentTimesInfo item in APPurchaseOrderPaymentTimesList)
            {
                item.APPurchaseOrderPaymentTimeStatus = PurchaseOrderPaymentTimeStatus.New.ToString();
                item.APPurchaseOrderPaymentTimeDate = DateTime.Parse(item.APPurchaseOrderPaymentTimeDate.ToShortDateString());
                item.ARSaleOrderPaymentTimeDueDate = DateTime.Parse(item.ARSaleOrderPaymentTimeDueDate.ToShortDateString());
                item.ARSaleOrderPaymentTimeBalanceDue = item.APPurchaseOrderPaymentTimeAmount;
                item.APPurchaseOrderPaymentTimeRealTotalAmount = item.APPurchaseOrderPaymentTimeAmount;
            }
            APPurchaseOrderPaymentTimesList.SaveItemObjects();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            if (objPurchaseOrdersInfo.FK_BRBranchID > 0)
            {
                ICStocksController objStocksController = new ICStocksController();
                ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetStockByTypeAndBranchID(StockType.Purchase.ToString(), objPurchaseOrdersInfo.FK_BRBranchID);
                if (objStocksInfo != null)
                {
                    objPurchaseOrdersInfo.FK_ICStockID = objStocksInfo.ICStockID;
                    foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in PurchaseOrderItemList)
                    {
                        objPurchaseOrderItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                    }
                }
            }
            //UpdateReferenceProposals();
            PurchaseOrderItemList.ForEach(o =>
            {
                o.APPurchaseOrderItemDivision = PurchaseOrderItemDivision.Product.ToString();
            });
            PurchaseOrderItemList.SaveItemObjects();
            PurchaseOrderItemOutSourcingList.SaveItemObjects();
            APPurchaseOrderItemDeliveryList.SaveItemObjects();
        }

        /// <summary>
        /// Update reference proposals if the purchase order has been created from them
        /// </summary>
        private void UpdateReferenceProposals()
        {
            //Rollback purchased quantity of proposal items            
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            ICProductComponentsController objProductComponentsController = new ICProductComponentsController();
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in PurchaseOrderItemList.BackupList)
            {
                if (objPurchaseOrderItemsInfo.FK_APProposalItemID > 0)
                {
                    APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(objPurchaseOrderItemsInfo.FK_APProposalItemID);
                    if (objProposalItemsInfo != null)
                    {
                        decimal purchasedQty = Math.Min(objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty, objProposalItemsInfo.APProposalItemPurchaseOrderQty);
                        objProposalItemsInfo.APProposalItemPurchaseOrderQty -= purchasedQty;
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }
            }

            //Update new purchased quantity of proposal items
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in PurchaseOrderItemList)
            {
                if (objPurchaseOrderItemsInfo.FK_APProposalItemID > 0)
                {
                    APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(objPurchaseOrderItemsInfo.FK_APProposalItemID);
                    if (objProposalItemsInfo != null)
                    {
                        decimal purchasedQty = Math.Min(objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty,
                                                        objProposalItemsInfo.APProposalItemProductQty - objProposalItemsInfo.APProposalItemPurchaseOrderQty);
                        objProposalItemsInfo.APProposalItemPurchaseOrderQty += purchasedQty;
                        if (objProposalItemsInfo.APProposalItemPurchaseOrderQty == objProposalItemsInfo.APProposalItemProductQty)
                        {
                            objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Purchased.ToString();
                        }
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.APPurchaseOrderItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.APPurchaseOrderItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                APPurchaseOrderItemsInfo purchaseOrderItem = (APPurchaseOrderItemsInfo)item;
                purchaseOrderItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(purchaseOrderItem.FK_ICProductID, purchaseOrderItem);
                SetProductCost(purchaseOrderItem);
                purchaseOrderItem.APPurchaseOrderItemType = objPurchaseOrdersInfo.APPurchaseOrderType;
                purchaseOrderItem.APPurchaseOrderItemDeliveryDate = objPurchaseOrdersInfo.APPurchaseOrderDeliveryDate;
                purchaseOrderItem.FK_ICStockID = objPurchaseOrdersInfo.FK_ICStockID;
                purchaseOrderItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                purchaseOrderItem.APPurchaseOrderItemPackagedQty = 0;
                purchaseOrderItem.APPurchaseOrderItemReceiptedQty = 0;
                purchaseOrderItem.APPurchaseOrderItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                purchaseOrderItem.APPurchaseOrderItemProductOrigin = objProductsInfo.ICProductOrigin;
                purchaseOrderItem.ICProductOrigin = objProductsInfo.ICProductOrigin;
                purchaseOrderItem.FK_MMBatchProductID = objPurchaseOrdersInfo.FK_MMBatchProductID;
                purchaseOrderItem.APPurchaseOrderItemProductHeight = objProductsInfo.ICProductHeight;
                purchaseOrderItem.APPurchaseOrderItemProductWidth = objProductsInfo.ICProductWidth;
                purchaseOrderItem.APPurchaseOrderItemProductLenght = objProductsInfo.ICProductLength;
                purchaseOrderItem.FK_ICLengthGroupID = objProductsInfo.FK_ICLengthGroupID;
                purchaseOrderItem.FK_ICPerimeterGroupID = objProductsInfo.FK_ICPerimeterGroupID;
                purchaseOrderItem.FK_ICProductThickGroupID = objProductsInfo.FK_ICProductThickGroupID;
            }
        }

        /// <summary>
        /// Whenever discount, freight, fee is changed, total must be recalculated and updated
        /// </summary>
        public void UpdateTotalCost()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost = 0;
            decimal volume = 0;
            foreach (APPurchaseOrderItemsInfo entItem in PurchaseOrderItemList)
            {
                entItem.APPurchaseOrderItemTotalCost = (entItem.APPurchaseOrderItemProductUnitCost * entItem.APPurchaseOrderItemProductQty) - entItem.APPurchaseOrderItemDiscountAmount + entItem.APPurchaseOrderItemTaxAmount;
                objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost += entItem.APPurchaseOrderItemTotalCost;
                volume += entItem.APPurchaseOrderItemUnitVolumn * entItem.APPurchaseOrderItemProductQty;
            }
            if (volume > 0)
            {
                objPurchaseOrdersInfo.APPurchaseOrderVolume = volume;
            }

            objPurchaseOrdersInfo.APPurchaseOrderDiscountFix = objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost * objPurchaseOrdersInfo.APPurchaseOrderDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objPurchaseOrdersInfo, "APPurchaseOrderDiscountFix", objPurchaseOrdersInfo.FK_GECurrencyID);
            objPurchaseOrdersInfo.APPurchaseOrderTaxAmount = (objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost -
                                                                objPurchaseOrdersInfo.APPurchaseOrderDiscountFix +
                                                                objPurchaseOrdersInfo.APPurchaseOrderShippingFees +
                                                                objPurchaseOrdersInfo.APPurchaseOrderShippingExtraFees) * objPurchaseOrdersInfo.APPurchaseOrderTaxPercent / 100;
            BOSApp.RoundByCurrency(objPurchaseOrdersInfo, "APPurchaseOrderTaxAmount", objPurchaseOrdersInfo.FK_GECurrencyID);
            objPurchaseOrdersInfo.APPurchaseOrderTotalCost = objPurchaseOrdersInfo.APPurchaseOrderSubTotalCost -
                                                                objPurchaseOrdersInfo.APPurchaseOrderDiscountFix +
                                                                objPurchaseOrdersInfo.APPurchaseOrderTaxAmount +
                                                                objPurchaseOrdersInfo.APPurchaseOrderShippingFees +
                                                                objPurchaseOrdersInfo.APPurchaseOrderShippingExtraFees;
            BOSApp.RoundByCurrency(objPurchaseOrdersInfo, "APPurchaseOrderTotalCost", objPurchaseOrdersInfo.FK_GECurrencyID);
            objPurchaseOrdersInfo.APPurchaseOrderBalanceDue = objPurchaseOrdersInfo.APPurchaseOrderTotalCost - objPurchaseOrdersInfo.APPurchaseOrderDepositBalance;
            BOSApp.RoundByCurrency(objPurchaseOrdersInfo, objPurchaseOrdersInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void UpdateProductQty()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            objPurchaseOrdersInfo.APPurchaseOrderVolume = 0;
            if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.Lumber.ToString()
                || objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == ProductType.Roundwood.ToString())
            {
                foreach (APPurchaseOrderItemsInfo item in PurchaseOrderItemList)
                {
                    objPurchaseOrdersInfo.APPurchaseOrderVolume += item.APPurchaseOrderItemProductQty;
                }

            }
            UpdateMainObjectBindingSource();
        }
        /// <summary>
        /// Invalidate item components of the purchase order items
        /// </summary>
        public void InvalidateItemComponents()
        {
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            List<APPurchaseOrderItemsInfo> items = objPurchaseOrderItemsController.GetComponentItemsByPurchaseOrderID(objPurchaseOrdersInfo.APPurchaseOrderID);
            ComponentPurchaseOrderItemList.Clear();
            ComponentPurchaseOrderItemList.OriginalList.Clear();
            ComponentPurchaseOrderItemList.BackupList.Clear();
            foreach (APPurchaseOrderItemsInfo item in items)
            {
                ComponentPurchaseOrderItemList.Add((APPurchaseOrderItemsInfo)item.Clone());
            }

            foreach (APPurchaseOrderItemsInfo item in ComponentPurchaseOrderItemList)
            {
                ComponentPurchaseOrderItemList.OriginalList.Add((APPurchaseOrderItemsInfo)item.Clone());
                ComponentPurchaseOrderItemList.BackupList.Add((APPurchaseOrderItemsInfo)item.Clone());
            }
        }

        //[NKVung]  [Discard Error Message]   [START]
        public void UpdateProposalItemQty()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            APProposalsController objProposalsController = new APProposalsController();
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            foreach (APPurchaseOrderItemsInfo item in PurchaseOrderItemList)
            {
                APProposalsInfo objProposalsInfo = (APProposalsInfo)objProposalsController.GetObjectByID(item.FK_APProposalID);
                APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_APProposalItemID);
                if (objProposalsInfo != null && objProposalItemsInfo != null)
                {
                    if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Approved.ToString()
                        || objProposalItemsInfo.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Approved.ToString())
                    {
                        objProposalItemsInfo.APProposalItemPurchaseOrderQty += item.APPurchaseOrderItemProductExchangeQty;
                        objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty += item.APPurchaseOrderItemWoodQty;
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }
            }
        }
        public void DiscardProposalItemQty()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            APProposalsController objProposalsController = new APProposalsController();
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            foreach (APPurchaseOrderItemsInfo item in PurchaseOrderItemList)
            {
                APProposalsInfo objProposalsInfo = (APProposalsInfo)objProposalsController.GetObjectByID(item.FK_APProposalID);
                APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_APProposalItemID);
                if (objProposalsInfo != null && objProposalItemsInfo != null)
                {
                    if (objProposalsInfo.APPurchaseProposalStatus == PurchaseProposalStatus.Approved.ToString()
                        || objProposalItemsInfo.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Approved.ToString())
                    {
                        decimal purchasedQty = objProposalItemsInfo.APProposalItemPurchaseOrderQty - (item.APPurchaseOrderItemProductQty - item.APPurchaseOrderItemReceiptedQty);
                        decimal woodQty = objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty - (item.APPurchaseOrderItemWoodQty - item.APPurchaseOrderItemQty3);
                        if (purchasedQty >= 0)
                        {
                            objProposalItemsInfo.APProposalItemPurchaseOrderQty = purchasedQty;
                        }
                        else
                        {
                            objProposalItemsInfo.APProposalItemPurchaseOrderQty = 0;
                        }
                        if (woodQty >= 0)
                        {
                            objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty = woodQty;
                        }
                        else
                        {
                            objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty = 0;
                        }
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }
            }
        }
        //[NKVung]  [Discard Error Message]   [END]
        public override bool CompleteTransaction()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            //////////////Move out transaction///////////////
            //UpdateProposalItemQty();
            //UpdateARSaleOrderItemQty();
            //////////////Move out transaction///////////////
            SetPropertyChangeEventLock(false);
            objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Approved.ToString();
            objPurchaseOrdersInfo.APPurchaseOrderApproveStatus = ApproveStatus.Approved;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            //Invalidate item components
            // InvalidateItemComponents();
            //Update new purchase order quantity
            //ICProductsController objProductsController = new ICProductsController();
            //if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo != ProductType.Rent.ToString())
            //{
            //    foreach (APPurchaseOrderItemsInfo entItem in ComponentPurchaseOrderItemList)
            //    {
            //        entItem.APPurchaseOrderItemProductType = ((ICProductsInfo)objProductsController.GetObjectByID(entItem.FK_ICProductID)).ICProductType;
            //    }
            //}
            //CreateAPPurchaseOrderItemDeliveryList();
            return base.CompleteTransaction();
        }

        public void UpdateARSaleOrderItemQty()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            foreach (APPurchaseOrderItemsInfo item in PurchaseOrderItemList)
            {
                ARSaleOrderItemsInfo objARSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                if (objARSaleOrderItemsInfo != null)
                {
                    objARSaleOrderItemsInfo.ARSaleOrderItemPOIQty += item.APPurchaseOrderItemProductQty;
                    objSaleOrderItemsController.UpdateObject(objARSaleOrderItemsInfo);
                }
            }
        }
        public void DiscardARSaleOrderItemQty()
        {
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            foreach (APPurchaseOrderItemsInfo item in PurchaseOrderItemList)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                if (objSaleOrderItemsInfo != null)
                {
                    decimal purchasedQty = objSaleOrderItemsInfo.ARSaleOrderItemPOIQty - (item.APPurchaseOrderItemProductQty - item.APPurchaseOrderItemReceiptedQty);

                    if (purchasedQty >= 0)
                    {
                        objSaleOrderItemsInfo.ARSaleOrderItemPOIQty = purchasedQty;
                    }
                    else
                    {
                        objSaleOrderItemsInfo.ARSaleOrderItemPOIQty = 0;
                    }
                    objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                }
            }
        }

        public void RemoveOldPOPackageItemDetailItem(IBOSList<APPOPackageItemDetailsInfo> POPackageItemDetailsList)
        {
            List<APPOPackageItemDetailsInfo> RemovePackageItemDetailsList = (List<APPOPackageItemDetailsInfo>)POPackageItemDetailsList;
            RemovePackageItemDetailsList.ForEach(o =>
            {
                POPackageItemDetailShowList.ForEach(x =>
                {
                    if (x.FK_APPOPackageItemID == o.FK_APPOPackageItemID)
                        POPackageItemDetailShowList.Remove(x);
                });
            });
        }

        public void CreateAPPurchaseOrderItemDeliveryList()
        {
            APPurchaseOrdersInfo mainObject = (APPurchaseOrdersInfo)MainObject;
            APPurchaseOrderItemDeliveryList.Clear();
            foreach (APPurchaseOrderItemsInfo objPO in PurchaseOrderItemList)
            {
                APPurchaseOrderItemDeliverysInfo item = new APPurchaseOrderItemDeliverysInfo();
                BOSUtil.CopyObject(objPO, item);
                item.FK_APPurchaseOrderItemID = objPO.APPurchaseOrderItemID;
                item.APPurchaseOrderItemDeliveryDate = objPO.APPurchaseOrderItemDeliveryDate;
                APPurchaseOrderItemDeliveryList.Add(item);
            }
            APPurchaseOrderItemDeliveryList.SaveItemObjects();
            APPurchaseOrderItemDeliveryList.GridControl?.RefreshDataSource();
        }
    }
}
