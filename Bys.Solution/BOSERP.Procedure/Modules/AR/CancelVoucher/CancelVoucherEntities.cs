using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.CancelVoucher
{
    public class CancelVoucherEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSItemsEntityList<ARCancelVoucherItemsInfo> CancelVoucherItemList { get; set; }

        public BOSList<ARCancelVoucherItemCostsInfo> CancelVoucherItemCostList { get; set; }

        public BOSItemsEntityList<ARCancelVoucherItemsInfo> ComponentCancelVoucherItemList { get; set; }

        public BOSList<ARSaleOrderPaymentTimesInfo> SaleOrderPaymentTimesList { get; set; }
        #endregion

        #region Constructor
        public CancelVoucherEntities()
            : base()
        {
            CancelVoucherItemList = new BOSItemsEntityList<ARCancelVoucherItemsInfo>();
            ComponentCancelVoucherItemList = new BOSItemsEntityList<ARCancelVoucherItemsInfo>();
            CancelVoucherItemCostList = new BOSList<ARCancelVoucherItemCostsInfo>();
            SaleOrderPaymentTimesList = new BOSList<ARSaleOrderPaymentTimesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new ARCancelVouchersInfo();
            MainObject = new ARCancelVouchersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARCancelVoucherItemsTableName, new ARCancelVoucherItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CancelVoucherItemList.InitBOSList(this,
                                            TableName.ARCancelVouchersTableName,
                                            TableName.ARCancelVoucherItemsTableName,
                                            BOSList<ARCancelVoucherItemsInfo>.cstRelationForeign);

            CancelVoucherItemCostList.InitBOSList(this,
                                            TableName.ARCancelVouchersTableName,
                                            TableName.ARCancelVoucherItemCostsTableName,
                                            BOSList<ARCancelVoucherItemCostsInfo>.cstRelationForeign);

            SaleOrderPaymentTimesList.InitBOSList(this,
                                              TableName.ARSaleOrdersTableName,
                                              TableName.ARSaleOrderPaymentTimesTableName,
                                              BOSList<ARSaleOrderPaymentTimesInfo>.cstRelationForeign);
            SaleOrderPaymentTimesList.ItemTableForeignKey = "FK_ARSaleOrderID";
        }

        public override void InitGridControlInBOSList()
        {
            CancelVoucherItemList.InitBOSListGridControl();
            CancelVoucherItemCostList.InitBOSListGridControl("fld_dgcCancelVoucherItemCostsGridControl");
            SaleOrderPaymentTimesList.InitBOSListGridControl("fld_dgcARSaleOrderPaymentTimes");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CancelVoucherItemList.SetDefaultListAndRefreshGridControl();
                ComponentCancelVoucherItemList.SetDefaultListAndRefreshGridControl();
                CancelVoucherItemCostList.SetDefaultListAndRefreshGridControl();
                SaleOrderPaymentTimesList.SetDefaultListAndRefreshGridControl();
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

            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)MainObject;
            objCancelVouchersInfo.ARCancelVoucherDate = DateTime.Now;
            objCancelVouchersInfo.ARCancelVoucherStatus = CancelVoucherStatus.New.ToString();
            objCancelVouchersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCancelVouchersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objCancelVouchersInfo.ARCancelVoucherExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)MainObject;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objCancelVouchersInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                objCancelVouchersInfo.ARSaleOrderNo = objSaleOrdersInfo.ARSaleOrderNo;
                objCancelVouchersInfo.ARSaleOrderDate = objSaleOrdersInfo.ARSaleOrderDate;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            CancelVoucherItemList.Invalidate(iObjectID);
            CancelVoucherItemCostList.Invalidate(iObjectID);
            InvalidateSaleOrderPaymentTimesList();
            //Invalidate item components
            InvalidateItemComponents();
        }
        
        public void InvalidateSaleOrderPaymentTimesList()
        {
            ARCancelVouchersInfo mainObject = (ARCancelVouchersInfo)MainObject;
            if(mainObject.FK_ARSaleOrderID > 0)
            {
                List<ARSaleOrderPaymentTimesInfo> listPaymentTime = (new ARSaleOrderPaymentTimesController()).GetListPaymentTimeBySaleOrderID(mainObject.FK_ARSaleOrderID);
                SaleOrderPaymentTimesList.Invalidate(listPaymentTime);
                SaleOrderPaymentTimesList.GridControl?.RefreshDataSource();
            }
        }
        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            CancelVoucherItemList.SaveItemObjects();
            CancelVoucherItemCostList.SaveItemObjects();

            //Invalidate item components
            InvalidateItemComponents();
        }

        /// <summary>
        /// Update the reference sale order that the cancel voucher has been created from
        /// </summary>
        /// 

        public override bool CompleteTransaction()
        {
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)MainObject;
            if (objCancelVouchersInfo.ARCancelVoucherStatus == CancelVoucherStatus.New.ToString())
            {
                objCancelVouchersInfo.ARCancelVoucherStatus = CancelVoucherStatus.Complete.ToString();
                UpdateMainObject();
            }
            if (objCancelVouchersInfo.FK_ARSaleOrderID > 0)
            {
                UpdateReferenceSaleOrder();
                UpdateReferenceSaleOrderItemWork();
            }
            ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
            foreach (ARCancelVoucherItemsInfo objCancelVoucherItemsInfo in CancelVoucherItemList)
            {
                objCancelVoucherItemsInfo.ARCancelVoucherItemTotalQty += objCancelVoucherItemsInfo.ARCancelVoucherItemProductQty;

            }
            CancelVoucherItemList.SaveItemObjects();
            return base.CompleteTransaction();
        }

        public void UpdateReferenceSaleOrderItemWork()
        {
            ARSaleOrderItemWorksController objSaleOrderItemWorksController = new ARSaleOrderItemWorksController();
            ARSaleOrderItemWorksInfo objSaleOrderItemWorksInfo = new ARSaleOrderItemWorksInfo();
            CancelVoucherItemCostList.ForEach(o =>
            {
                objSaleOrderItemWorksInfo = (ARSaleOrderItemWorksInfo)objSaleOrderItemWorksController.GetObjectByID(o.FK_ARSaleOrderItemWorkID);
                if (objSaleOrderItemWorksInfo == null)
                    return;
                objSaleOrderItemWorksInfo.ARSaleOrderItemWorkCancelQty += o.ARCancelVoucherItemCostProductQty;
                objSaleOrderItemWorksController.UpdateObject(objSaleOrderItemWorksInfo);
            });
        }

        public void UpdateReferenceSaleForecast()
        {
            ARCancelVouchersInfo cancelVoucher = (ARCancelVouchersInfo)MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSaleForecastItemsInfo objSaleForecastItemsInfo = new ARSaleForecastItemsInfo();
            foreach (ARCancelVoucherItemsInfo item in CancelVoucherItemList)
            {
                if (item.FK_ARSaleOrderItemID > 0)
                {
                    objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo != null)
                    {
                        if (objSaleOrderItemsInfo.FK_ARSaleForecastItemID > 0)
                        {
                            objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(objSaleOrderItemsInfo.FK_ARSaleForecastItemID);
                            if (objSaleForecastItemsInfo != null)
                            {
                                objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty -= item.ARCancelVoucherItemProductQty;
                                objSaleForecastItemsController.UpdateObject(objSaleForecastItemsInfo);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateReferenceSaleOrder()
        {
            ARCancelVouchersInfo cancelVoucher = (ARCancelVouchersInfo)MainObject;
            BOSList<ARSaleOrderItemsInfo> saleOrderItems = new BOSList<ARSaleOrderItemsInfo>();
            saleOrderItems.InitBOSList(this, TableName.ARSaleOrdersTableName, TableName.ARSaleOrderItemsTableName);
            saleOrderItems.ItemTableForeignKey = "FK_ARSaleOrderID";
            saleOrderItems.Invalidate(cancelVoucher.FK_ARSaleOrderID);

            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSaleForecastItemsInfo objSaleForecastItemsInfo;
            ARSaleOrderItemsInfo saleOrderItem;

            ARClearingDetailsController objClearingDetailsController = new ARClearingDetailsController();
            List<ARClearingDetailsInfo> clearingDetails = new List<ARClearingDetailsInfo>();

            //Update the new total canceled quantity of the reference sale order items
            saleOrderItems = new BOSList<ARSaleOrderItemsInfo>();
            foreach (ARCancelVoucherItemsInfo cancelVoucherItem in CancelVoucherItemList)
            {
                decimal cancelVoucherItemQty = cancelVoucherItem.ARCancelVoucherItemProductQty;

                saleOrderItem = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(cancelVoucherItem.FK_ARSaleOrderItemID);
                if (saleOrderItem != null)
                {
                    saleOrderItem.ARSaleOrderItemCanceledQty += cancelVoucherItemQty;
                    objSaleOrderItemsController.UpdateObject(saleOrderItem);
                    saleOrderItems.Add(saleOrderItem);
                }
            }

            //Cancel the whole sale order if its all items are canceled
            bool cancelAll = true;
            bool completed = true;
            foreach (ARSaleOrderItemsInfo saleOrderItemInfo in saleOrderItems)
            {
                if (saleOrderItemInfo.ARSaleOrderItemCanceledQty < saleOrderItemInfo.ARSaleOrderItemProductQty)
                {
                    cancelAll = false;
                }
                objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(saleOrderItemInfo.FK_ARSaleForecastItemID);
                if (objSaleForecastItemsInfo != null)
                {
                    if (objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty > 0)
                    {
                        completed = false;
                        objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty = saleOrderItemInfo.ARSaleOrderItemProductQty - saleOrderItemInfo.ARSaleOrderItemCanceledQty;
                        objSaleForecastItemsController.UpdateObject(objSaleForecastItemsInfo);
                    }
                }
            }
            if (cancelAll)
            {
                List<ARSaleOrderItemsInfo> saleOrderItemsList = new List<ARSaleOrderItemsInfo>();
                saleOrderItemsList = (List<ARSaleOrderItemsInfo>)objSaleOrderItemsController.GetListFromDataSet(objSaleOrderItemsController.GetAllDataBySaleOrderID(cancelVoucher.FK_ARSaleOrderID));
                if (saleOrderItemsList.Count() != saleOrderItems.Count())
                    cancelAll = false;
            }
            if (cancelAll)
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo saleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(cancelVoucher.FK_ARSaleOrderID);
                if (saleOrder != null)
                {
                    saleOrder.ARSaleOrderStatus = SaleOrderStatus.Canceled.ToString();
                    saleOrder.AAUpdatedUser = BOSApp.CurrentUser;
                    saleOrder.AAUpdatedDate = DateTime.Now;
                    objSaleOrdersController.UpdateObject(saleOrder);
                }
            }
            else
            {
                ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                ARSaleOrdersInfo saleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(cancelVoucher.FK_ARSaleOrderID);
                if (saleOrder != null)
                {
                    saleOrder.ARSaleOrderStatus = SaleOrderStatus.Confirmed.ToString();
                    saleOrder.AAUpdatedUser = BOSApp.CurrentUser;
                    saleOrder.AAUpdatedDate = DateTime.Now;
                    objSaleOrdersController.UpdateObject(saleOrder);
                }
            }
            if (completed)
            {
                ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
                ARSaleForecastsInfo objSaleForecastsInfo = objSaleForecastsController.GetSaleForecastBySaleOrderID(cancelVoucher.FK_ARSaleOrderID);
                if (objSaleForecastsInfo != null)
                {
                    objSaleForecastsInfo.ARSaleForecastStatus = SaleForecastStatus.Confirmed.ToString();
                    objSaleForecastsInfo.AAUpdatedUser = BOSApp.CurrentUser;
                    objSaleForecastsInfo.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(objSaleForecastsInfo);
                }
            }
            else
            {
                ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
                ARSaleForecastsInfo objSaleForecastsInfo = objSaleForecastsController.GetSaleForecastBySaleOrderID(cancelVoucher.FK_ARSaleOrderID);
                if (objSaleForecastsInfo != null)
                {
                    objSaleForecastsInfo.ARSaleForecastStatus = SaleForecastStatus.Incomplete.ToString();
                    objSaleForecastsInfo.AAUpdatedUser = BOSApp.CurrentUser;
                    objSaleForecastsInfo.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(objSaleForecastsInfo);
                }
            }
            //GIANG- ADD
            int allocationPlanStockID = 0;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objAllocationPlanStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.AllocationPlan.ToString(), cancelVoucher.FK_BRBranchID);
            if (objAllocationPlanStocksInfo != null)
            {
                allocationPlanStockID = objAllocationPlanStocksInfo.ICStockID;
            }
            int saleOrderStockID = 0;

            ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), cancelVoucher.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                saleOrderStockID = objStocksInfo.ICStockID;
            }

            MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            foreach (ARCancelVoucherItemsInfo cancelVoucherItem in CancelVoucherItemList)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(cancelVoucherItem.FK_ARSaleOrderItemID);
                if (objSaleOrderItemsInfo != null)
                {
                    /* Cộng kho hoạch định */
                    if (objSaleOrderItemsInfo.FK_MMAllocationPlanItemID > 0)
                    {
                        objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)objAllocationPlanItemsController.GetObjectByID(objSaleOrderItemsInfo.FK_MMAllocationPlanItemID);
                        if (objAllocationPlanItemsInfo != null)
                        {
                            objAllocationPlanItemsInfo.MMAllocationPlanItemSaleOrderQty -= cancelVoucherItem.ARCancelVoucherItemProductQty;
                            objAllocationPlanItemsController.UpdateObject(objAllocationPlanItemsInfo);
                        }
                    }
                }
            }
            if (cancelAll)
            {
                clearingDetails = objClearingDetailsController.GetClearingDetailBySaleOrderID(cancelVoucher.FK_ARSaleOrderID);
                clearingDetails.ForEach(o =>
                {
                    o.ARClearingDetailAmount = 0;
                    objClearingDetailsController.UpdateObject(o);
                });
            }
            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
            objSaleOrderPaymentTimesController.UpdateSaleOrderPaymentTimesByCancelVoucherID(cancelVoucher.ARCancelVoucherID);

            GLHelper.PostedTransactions(this.Module.Name, cancelVoucher.ARCancelVoucherID, ModulePostingType.SaleOrder, ModulePostingType.Allocation, ModulePostingType.InvoiceTrans);
        }

        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            if (strTableName == TableName.ARCancelVouchersTableName)
            {
                //Rollback the total canceled quantity of the reference sale order items
                ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                foreach (ARCancelVoucherItemsInfo objCancelVoucherItemsInfo in CancelVoucherItemList)
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(objCancelVoucherItemsInfo.FK_ARSaleOrderItemID);
                    objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty -= objCancelVoucherItemsInfo.ARCancelVoucherItemProductQty;
                    objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                }
            }
        }

        /// <summary>
        /// Update the total amount of the cancel voucher whenever
        /// user changes any info affecting to it
        /// </summary>
        public void UpdateTotalAmount()
        {
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)MainObject;
            objCancelVouchersInfo.ARCancelVoucherNetAmount = 0;
            objCancelVouchersInfo.ARCancelVoucherSubTotalAmount = 0;
            foreach (ARCancelVoucherItemsInfo objCancelVoucherItemsInfo in CancelVoucherItemList)
            {
                BOSApp.RoundByCurrency(objCancelVoucherItemsInfo, objCancelVouchersInfo.FK_GECurrencyID);
                objCancelVouchersInfo.ARCancelVoucherNetAmount += objCancelVoucherItemsInfo.ARCancelVoucherItemNetAmount;
                objCancelVouchersInfo.ARCancelVoucherSubTotalAmount += objCancelVoucherItemsInfo.ARCancelVoucherItemTotalAmount;
            }
            BOSApp.RoundByCurrency(objCancelVouchersInfo, objCancelVouchersInfo.FK_GECurrencyID);
            objCancelVouchersInfo.ARCancelVoucherDiscountFix = objCancelVouchersInfo.ARCancelVoucherSubTotalAmount * objCancelVouchersInfo.ARCancelVoucherDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objCancelVouchersInfo, "ARCancelVoucherDiscountFix", objCancelVouchersInfo.FK_GECurrencyID);
            objCancelVouchersInfo.ARCancelVoucherTaxAmount = (objCancelVouchersInfo.ARCancelVoucherSubTotalAmount - objCancelVouchersInfo.ARCancelVoucherDiscountFix) * objCancelVouchersInfo.ARCancelVoucherTaxPercent / 100;
            BOSApp.RoundByCurrency(objCancelVouchersInfo, "ARCancelVoucherTaxAmount", objCancelVouchersInfo.FK_GECurrencyID);
            objCancelVouchersInfo.ARCancelVoucherTotalAmount = objCancelVouchersInfo.ARCancelVoucherSubTotalAmount - objCancelVouchersInfo.ARCancelVoucherDiscountFix + objCancelVouchersInfo.ARCancelVoucherTaxAmount;
            BOSApp.RoundByCurrency(objCancelVouchersInfo, "ARCancelVoucherTotalAmount", objCancelVouchersInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Invalidate item components of the cancel voucher items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
            ARCancelVouchersInfo objCancelVouchersInfo = (ARCancelVouchersInfo)MainObject;
            List<ARCancelVoucherItemsInfo> items = objCancelVoucherItemsController.GetComponentItemsByCancelVoucherID(objCancelVouchersInfo.ARCancelVoucherID);
            ComponentCancelVoucherItemList.Clear();
            ComponentCancelVoucherItemList.OriginalList.Clear();
            ComponentCancelVoucherItemList.BackupList.Clear();
            foreach (ARCancelVoucherItemsInfo item in items)
            {
                ComponentCancelVoucherItemList.Add((ARCancelVoucherItemsInfo)item.Clone());
            }

            foreach (ARCancelVoucherItemsInfo item in ComponentCancelVoucherItemList)
            {
                ComponentCancelVoucherItemList.OriginalList.Add((ARCancelVoucherItemsInfo)item.Clone());
                ComponentCancelVoucherItemList.BackupList.Add((ARCancelVoucherItemsInfo)item.Clone());
            }
        }
    }
}
