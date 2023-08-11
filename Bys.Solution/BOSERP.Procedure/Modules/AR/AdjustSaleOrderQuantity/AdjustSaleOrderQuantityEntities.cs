using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.AdjustSaleOrderQuantity
{
    public class AdjustSaleOrderQuantityEntities : BaseTransactionEntities
    {
        #region Declare all entities variables


        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSList<ARAdjustSaleOrderQuantityItemsInfo> AdjustSaleOrderQuantityItemList { get; set; }

        #endregion

        #region Constructor
        public AdjustSaleOrderQuantityEntities()
            : base()
        {
            AdjustSaleOrderQuantityItemList = new BOSList<ARAdjustSaleOrderQuantityItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new ARAdjustSaleOrderQuantitysInfo();
            MainObject = new ARAdjustSaleOrderQuantitysInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARAdjustSaleOrderQuantityItemsTableName, new ARAdjustSaleOrderQuantityItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            AdjustSaleOrderQuantityItemList.InitBOSList(this,
                                            TableName.ARAdjustSaleOrderQuantitysTableName,
                                            TableName.ARAdjustSaleOrderQuantityItemsTableName,
                                            BOSList<ARCancelSaleForecastItemsInfo>.cstRelationForeign);
            AdjustSaleOrderQuantityItemList.ItemTableForeignKey = "FK_ARAdjustSaleOrderQuantityID";
        }

        public override void InitGridControlInBOSList()
        {
            AdjustSaleOrderQuantityItemList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AdjustSaleOrderQuantityItemList.SetDefaultListAndRefreshGridControl();
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

            ARAdjustSaleOrderQuantitysInfo objAdjustSaleOrderQuantitysInfo = (ARAdjustSaleOrderQuantitysInfo)MainObject;
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityDate = DateTime.Now;
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityStatus = AdjustSaleOrderQuantityStatus.New.ToString();
            objAdjustSaleOrderQuantitysInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            //ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;
            //ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            //ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByID(objCancelSaleForecastsInfo.FK_ARSaleForecastID);
            //if (objSaleForecastsInfo != null)
            //{
            //    objCancelSaleForecastsInfo.ARSaleForecastNo = objSaleForecastsInfo.ARSaleForecastNo;
            //    objCancelSaleForecastsInfo.ARSaleForecastDate = objSaleForecastsInfo.ARSaleForecastDate;
            //}
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            AdjustSaleOrderQuantityItemList.Invalidate(iObjectID);

            //Invalidate item components
            //InvalidateItemComponents();
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            //Update reference sale order
            // ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;

            AdjustSaleOrderQuantityItemList.SaveItemObjects();

            //Invalidate item components
            // InvalidateItemComponents();

            //Update the new ordered quantity of the canceled items
            //foreach (ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo in ComponentCancelSaleForecastItemList)
            //{
            //    TransactionUtil.UpdateInventoryStock(
            //                                        objCancelSaleForecastItemsInfo.FK_ICProductID,
            //                                        objCancelSaleForecastItemsInfo.FK_ICStockID,
            //                                        -objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty,
            //                                        TransactionUtil.cstInventoryReceipt);
            //}

        }

        #endregion

        /////// <summary>
        /////// Update the total amount of the cancel voucher whenever
        /////// user changes any info affecting to it
        /////// </summary>
        public void UpdateTotalAmount()
        {
            ARAdjustSaleOrderQuantitysInfo objAdjustSaleOrderQuantitysInfo = (ARAdjustSaleOrderQuantitysInfo)MainObject;
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityNetAmount = 0;
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityTotalAmount = 0;
            foreach (ARAdjustSaleOrderQuantityItemsInfo item in AdjustSaleOrderQuantityItemList)
            {
                BOSApp.RoundByCurrency(item, objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID);
                objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityNetAmount += item.ARAdjustSaleOrderQuantityItemNetAmount;
                objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantitySubTotalAmount += item.ARAdjustSaleOrderQuantityItemTotalAmount;
            }
            BOSApp.RoundByCurrency(objAdjustSaleOrderQuantitysInfo, objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID);
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityDiscountFix = objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantitySubTotalAmount * objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objAdjustSaleOrderQuantitysInfo, "ARAdjustSaleOrderQuantityDiscountFix", objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID);
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityTaxAmount = (objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantitySubTotalAmount - objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityDiscountFix) * objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityTaxPercent / 100;
            BOSApp.RoundByCurrency(objAdjustSaleOrderQuantitysInfo, "ARAdjustSaleOrderQuantityTaxAmount", objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID);
            objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityTotalAmount = objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantitySubTotalAmount - objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityDiscountFix + objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityTaxAmount;
            BOSApp.RoundByCurrency(objAdjustSaleOrderQuantitysInfo, "ARAdjustSaleOrderQuantityTotalAmount", objAdjustSaleOrderQuantitysInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public override bool CompleteTransaction()
        {
            //Update sale forecast's status
            ARAdjustSaleOrderQuantitysInfo objAdjustSaleOrderQuantitysInfo = (ARAdjustSaleOrderQuantitysInfo)MainObject;

            if (objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityStatus == AdjustSaleOrderQuantityStatus.New.ToString())
            {
                objAdjustSaleOrderQuantitysInfo.ARAdjustSaleOrderQuantityStatus = AdjustSaleOrderQuantityStatus.Approved.ToString();
                UpdateMainObject();
                //UpdateModuleObjectBatchStatus();
            }

            if (objAdjustSaleOrderQuantitysInfo.FK_ARSaleOrderID > 0)
            {
                UpdateSaleOrder();
            }

            return true;
        }
        public void UpdateSaleOrder()
        {
            ARAdjustSaleOrderQuantitysInfo mainObject = (ARAdjustSaleOrderQuantitysInfo)MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            MMProposalItemsInfo objProposalItemsInfo = new MMProposalItemsInfo();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();

            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();
            ARSaleForecastItemsInfo objSaleForecastItemsInfo = new ARSaleForecastItemsInfo();
            // List<ARSaleOrderItemsInfo> saleOrderItemList = new List<ARSaleOrderItemsInfo>();
            //List<BusinessObject> listBusiness = new List<BusinessObject>();
            //BusinessObject obj;
            decimal totalAmount = 0;
            decimal totalProduct = 0;
            decimal netAmount = 0;
            decimal oldBatchProductItemProductQty = 0;
            foreach (ARAdjustSaleOrderQuantityItemsInfo item in AdjustSaleOrderQuantityItemList)
            {
                List<ARSaleOrderItemsInfo> saleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemForCheckingAdjustSaleOrderValidQty(item.FK_ARSaleOrderItemID);
                decimal CancelQty = 0;
                if (saleOrderItemList != null && saleOrderItemList.Count > 0)
                {
                    CancelQty = saleOrderItemList.Sum(i => i.ARSaleOrderItemRemainedQty);
                }
                objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(item.FK_ARSaleOrderItemID);
                if (objSaleOrderItemsInfo != null)
                {
                    //Update SO Qty for Sale Forecast
                    objSaleForecastItemsInfo = (ARSaleForecastItemsInfo)objSaleForecastItemsController.GetObjectByID(objSaleOrderItemsInfo.FK_ARSaleForecastItemID);
                    if (objSaleForecastItemsInfo != null)
                    {
                        objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty = objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty - objSaleOrderItemsInfo.ARSaleOrderItemProductQty + item.ARAdjustSaleOrderQuantityItemProductQty;
                        objSaleForecastItemsInfo.ARSaleForecastItemRemainedQty = objSaleForecastItemsInfo.ARSaleForecastItemProductQty - objSaleForecastItemsInfo.ARSaleForecastItemCanceledQty - objSaleForecastItemsInfo.ARSaleForecastItemProductSOQty;
                        objSaleForecastItemsController.UpdateObject(objSaleForecastItemsInfo);
                    }


                    objSaleOrderItemsInfo.ARSaleOrderItemProductQty = item.ARAdjustSaleOrderQuantityItemProductQty;
                    netAmount = objSaleOrderItemsInfo.ARSaleOrderItemProductQty * objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                    objSaleOrderItemsInfo.ARSaleOrderItemPrice = netAmount;
                    objSaleOrderItemsInfo.ARSaleOrderItemNetAmount = netAmount;
                    BOSApp.RoundByCurrency(objSaleOrderItemsInfo, mainObject.FK_GECurrencyID);
                    objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount = netAmount * objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount / 100;
                    BOSApp.RoundByCurrency(objSaleOrderItemsInfo, "ARSaleOrderItemDiscountAmount", mainObject.FK_GECurrencyID);
                    objSaleOrderItemsInfo.ARSaleOrderItemTaxAmount = (netAmount - objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount) * objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent / 100;
                    BOSApp.RoundByCurrency(objSaleOrderItemsInfo, "ARSaleOrderItemTaxAmount", mainObject.FK_GECurrencyID);
                    objSaleOrderItemsInfo.ARSaleOrderItemTotalAmount = netAmount - objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount + objSaleOrderItemsInfo.ARSaleOrderItemTaxAmount;
                    BOSApp.RoundByCurrency(objSaleOrderItemsInfo, "ARSaleOrderItemTotalAmount", mainObject.FK_GECurrencyID);
                    totalAmount += objSaleOrderItemsInfo.ARSaleOrderItemTotalAmount;
                    totalProduct += objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                    //saleOrderItemList.Add(objSaleOrderItemsInfo);                  
                    objSaleOrderItemsController.UpdateObject(objSaleOrderItemsInfo);
                    //Update ProposalItems
                    #region Update ProposalItems
                    objProposalItemsInfo = (MMProposalItemsInfo)objProposalItemsController.GetFirstObjectByForeignColumn("FK_ARSaleOrderItemID", objSaleOrderItemsInfo.ARSaleOrderItemID);
                    if (objProposalItemsInfo != null)
                    {
                        objProposalItemsInfo.MMProposalItemProductQty = item.ARAdjustSaleOrderQuantityItemProductQty - CancelQty;
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                    #endregion
                    //Update MMBatchProduct
                    #region Update MMBatchProduct
                    objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetFirstObjectByForeignColumn("FK_ARSaleOrderItemID", objSaleOrderItemsInfo.ARSaleOrderItemID);
                    if (objBatchProductItemsInfo != null)
                    {
                        oldBatchProductItemProductQty = objBatchProductItemsInfo.MMBatchProductItemProductQty;
                        objBatchProductItemsInfo.MMBatchProductItemProductQty = item.ARAdjustSaleOrderQuantityItemProductQty - CancelQty;
                        objBatchProductItemsController.UpdateObject(objBatchProductItemsInfo);
                        List<MMBatchProductProductionNormItemsInfo> productionNormList = objBatchProductProductionNormItemsController.GetAllItemByBatchProductItemID(objBatchProductItemsInfo.MMBatchProductItemID);
                        if (productionNormList.Count > 0)
                        {
                            foreach (MMBatchProductProductionNormItemsInfo productionNormItem in productionNormList)
                            {
                                productionNormItem.MMBatchProductProductionNormItemQuantity = productionNormItem.MMBatchProductProductionNormItemQuantity / oldBatchProductItemProductQty * objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                productionNormItem.MMBatchProductProductionNormItemHardwareAssembleQuantity = productionNormItem.MMBatchProductProductionNormItemHardwareAssembleQuantity / oldBatchProductItemProductQty * objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                productionNormItem.MMBatchProductProductionNormItemHardwareAllocationQuantity = productionNormItem.MMBatchProductProductionNormItemHardwareAllocationQuantity / oldBatchProductItemProductQty * objBatchProductItemsInfo.MMBatchProductItemProductQty;
                                objBatchProductProductionNormItemsController.UpdateObject(productionNormItem);
                            }
                        }
                    }
                    #endregion
                }
            }
            //foreach (ARSaleOrderItemsInfo item in saleOrderItemList)
            //{
            //    obj = (BusinessObject)item;
            //    if (obj != null)
            //    {
            //        listBusiness.Add(obj);
            //    }
            //}
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(mainObject.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                //UpdateTotalAmountRound(objSaleOrdersInfo, listBusiness, objSaleOrdersInfo.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderTotalProduct = totalProduct;
                objSaleOrdersInfo.ARSaleOrderSubTotalAmount = totalAmount;
                objSaleOrdersInfo.ARSaleOrderDiscountFix = totalAmount * objSaleOrdersInfo.ARSaleOrderDiscountPerCent / 100;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderDiscountFix", mainObject.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderTaxAmount = (totalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix) * objSaleOrdersInfo.ARSaleOrderTaxPercent / 100;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTaxAmount", mainObject.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderTotalAmount = totalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix + objSaleOrdersInfo.ARSaleOrderTaxAmount;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTotalAmount", mainObject.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderBalanceDue", mainObject.FK_GECurrencyID);
                objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
            }

            //TKChinh [Add] Update payment times for sale order
            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
            List<ARSaleOrderPaymentTimesInfo> PaymentList = new List<ARSaleOrderPaymentTimesInfo>();
            PaymentList = objSaleOrderPaymentTimesController.GetItemsBySaleOrderID(mainObject.FK_ARSaleOrderID);
            if (PaymentList != null && PaymentList.Count > 0)
            {
                foreach (ARSaleOrderPaymentTimesInfo item in PaymentList)
                {
                    GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
                    GEPaymentTermsInfo PTInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(item.FK_GEPaymentTermID);
                    if (PTInfo != null)
                    {
                        item.ARSaleOrderPaymentTimeAmount = objSaleOrdersInfo.ARSaleOrderTotalAmount * PTInfo.GEPaymentTermPercentPayment / 100;
                        BOSApp.RoundByCurrency(item, "ARSaleOrderPaymentTimeAmount", mainObject.FK_GECurrencyID);
                        item.ARSaleOrderPaymentTimeBalanceDue = item.ARSaleOrderPaymentTimeAmount - item.ARSaleOrderPaymentTimeDepositBalance;
                        BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
                        objSaleOrderPaymentTimesController.UpdateObject(item);
                    }
                }
            }
        }
        //TKChinh [End]
    }
}
