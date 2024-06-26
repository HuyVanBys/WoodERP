using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.InvoiceIn
{
    public class InvoiceInEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        public int CountItemsInInvoiceInPackageItemList = 0;
        /// <summary>
        /// Gets or sets invoice in item list
        /// </summary>
        public BOSItemsEntityList<APInvoiceInItemsInfo> InvoiceInItemsList { get; set; }

        /// <summary>
        /// Gets or sets the invoice item list including the item's components
        /// </summary>
        public BOSItemsEntityList<APInvoiceInItemsInfo> ComponentInvoiceInItemList { get; set; }
        public BOSList<APClearingDetailsInfo> PaymentDetailList { get; set; }
        public BOSList<APInvoiceInPackageItemsInfo> InvoiceInPackageItemList { get; set; }
        public BOSList<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailShowList { get; set; }
        public BOSList<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailList { get; set; }
        public BOSList<APInvoiceInPackageItemDetailsInfo> DeleteInvoiceInPackageItemDetailList { get; set; }
        public BOSList<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailReportList { get; set; }
        #endregion

        #region Constructor
        public InvoiceInEntities()
            : base()
        {
            InvoiceInItemsList = new BOSItemsEntityList<APInvoiceInItemsInfo>();
            ComponentInvoiceInItemList = new BOSItemsEntityList<APInvoiceInItemsInfo>();
            PaymentDetailList = new BOSList<APClearingDetailsInfo>();
            InvoiceInPackageItemList = new BOSList<APInvoiceInPackageItemsInfo>();
            InvoiceInPackageItemDetailShowList = new BOSList<APInvoiceInPackageItemDetailsInfo>();
            InvoiceInPackageItemDetailList = new BOSList<APInvoiceInPackageItemDetailsInfo>();
            DeleteInvoiceInPackageItemDetailList = new BOSList<APInvoiceInPackageItemDetailsInfo>();
            InvoiceInPackageItemDetailReportList = new BOSList<APInvoiceInPackageItemDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APInvoiceInsInfo();
            SearchObject = new APInvoiceInsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APInvoiceInItemsTableName, new APInvoiceInItemsInfo());
            ModuleObjects.Add(TableName.APInvoiceInPackageItemsTableName, new APInvoiceInPackageItemsInfo());
            ModuleObjects.Add(TableName.APInvoiceInPackageItemDetailsTableName, new APInvoiceInPackageItemDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceInItemsList.InitBOSList(this,
                                             TableName.APInvoiceInsTableName,
                                             TableName.APInvoiceInItemsTableName,
                                             BOSList<APInvoiceInItemsInfo>.cstRelationForeign);
            InvoiceInItemsList.ItemTableForeignKey = "FK_APInvoiceInID";

            InvoiceInPackageItemList.InitBOSList(this,
                                               TableName.APInvoiceInsTableName,
                                               TableName.APInvoiceInPackageItemsTableName,
                                               BOSList<APInvoiceInPackageItemsInfo>.cstRelationForeign);
            InvoiceInPackageItemList.ItemTableForeignKey = "FK_APInvoiceInID";

            InvoiceInPackageItemDetailShowList.InitBOSList(this,
                                               TableName.APInvoiceInPackageItemsTableName,
                                               TableName.APInvoiceInPackageItemDetailsTableName,
                                               BOSList<APInvoiceInPackageItemDetailsInfo>.cstRelationForeign);
            InvoiceInPackageItemDetailShowList.ItemTableForeignKey = "FK_APInvoiceInPackageItemID";

            InvoiceInPackageItemDetailList.InitBOSList(this,
                                               TableName.APInvoiceInPackageItemsTableName,
                                               TableName.APInvoiceInPackageItemDetailsTableName,
                                               BOSList<APInvoiceInPackageItemDetailsInfo>.cstRelationForeign);
            InvoiceInPackageItemDetailList.ItemTableForeignKey = "FK_APInvoiceInPackageItemID";

            DeleteInvoiceInPackageItemDetailList.InitBOSList(this,
                                               TableName.APInvoiceInPackageItemsTableName,
                                               TableName.APInvoiceInPackageItemDetailsTableName,
                                               BOSList<APInvoiceInPackageItemDetailsInfo>.cstRelationForeign);
            DeleteInvoiceInPackageItemDetailList.ItemTableForeignKey = "FK_APInvoiceInPackageItemID";

            InvoiceInPackageItemDetailReportList.InitBOSList(this,
                                               TableName.APInvoiceInPackageItemsTableName,
                                               TableName.APInvoiceInPackageItemDetailsTableName,
                                               BOSList<APInvoiceInPackageItemDetailsInfo>.cstRelationForeign);
            InvoiceInPackageItemDetailReportList.ItemTableForeignKey = "FK_APInvoiceInPackageItemID";
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceInItemsList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(InvoiceInModule.DocumentEntryGridControlName);
            InvoiceInPackageItemList.InitBOSListGridControl("fld_dgcAPInvoiceInPackageItems");
            InvoiceInPackageItemDetailShowList.InitBOSListGridControl("fld_dgcAPInvoiceInPackageItemDetails");
            InvoiceInPackageItemDetailList.InitBOSListGridControl();
            InvoiceInPackageItemDetailReportList.InitBOSListGridControl("fld_dgcAPInvoiceInPackageItemDetails2");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceInItemsList.SetDefaultListAndRefreshGridControl();
                ComponentInvoiceInItemList.SetDefaultListAndRefreshGridControl();
                InvoiceInPackageItemList.SetDefaultListAndRefreshGridControl();
                InvoiceInPackageItemDetailShowList.SetDefaultListAndRefreshGridControl();
                InvoiceInPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                DeleteInvoiceInPackageItemDetailList.SetDefaultListAndRefreshGridControl();
                InvoiceInPackageItemDetailReportList.SetDefaultListAndRefreshGridControl();
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

            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            objInvoiceInsInfo.APInvoiceInDate = DateTime.Now;
            objInvoiceInsInfo.APInvoiceInSupplierNoDate = DateTime.Now;
            objInvoiceInsInfo.APInvoiceInDeliveryDate = DateTime.Now;
            objInvoiceInsInfo.APInvoiceInValidateDate = DateTime.Now;
            objInvoiceInsInfo.APInvoiceInVATDate = DateTime.Now;
            //  objInvoiceInsInfo.APInvoiceInType = InvoiceInType.PurchaseReceipt.ToString();
            objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.New.ToString();
            objInvoiceInsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objInvoiceInsInfo.APInvoiceInExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objInvoiceInsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objInvoiceInsInfo.FK_BRCreatedBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objInvoiceInsInfo.APInvoiceInDesc = InvoiceInLocalizedResources.InvoiceDefaultDesc;
            objInvoiceInsInfo.APInvoiceInDeliveryAddressLine3 = BOSApp.CurrentCompanyInfo.CSCompanyAddressLine3;
            CountItemsInInvoiceInPackageItemList = 0;
            //Set transit-in stock for updating transit-in quantity
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                objInvoiceInsInfo.FK_ICStockID = objStocksInfo.ICStockID;
            }

            UpdateMainObjectBindingSource();
        }
        public override int CreateMainObject()
        {
            APInvoiceInsInfo objInvoiceInInfo = (APInvoiceInsInfo)MainObject;
            int iObjectID = 0;
            bool editObjectNo = true;
            if (objInvoiceInInfo.APInvoiceInNo.Equals(cstNewObjectText))
            {
                editObjectNo = false;
            }
            iObjectID = base.CreateMainObject();
            if (!editObjectNo && iObjectID > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo = new GENumberingInfo();
                if (objInvoiceInInfo.APInvoiceInType != InvoiceInType.Roundwood.ToString() && (objInvoiceInInfo.APInvoiceInType != InvoiceInType.Lumber.ToString()))
                {
                    objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductSerialNo");
                    if (objGENumberingInfo != null)
                        UpdateProductLotNo(objGENumberingInfo.GENumberingStart);
                }
                else
                {
                    objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductWoodSerialNo");
                    if (objGENumberingInfo != null)
                        UpdateProductWoodLotNo(objGENumberingInfo.GENumberingStart);
                }

            }
            return iObjectID;
        }
        #region Invalidate Module Objects Functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            SetPropertyChangeEventLock(false);
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            APInvoiceInsInfo objTransaction = objInvoiceInsController.GetInformationTransactionByInvoiceInIDAndNo(objInvoiceInsInfo.APInvoiceInID, objInvoiceInsInfo.APInvoiceInNo);
            if (objTransaction != null)
            {
                objInvoiceInsInfo.APInvoiceInDepositBalance = objTransaction.APInvoiceInDepositBalance;
                objInvoiceInsInfo.APInvoiceInWaitingPayment = objTransaction.APInvoiceInWaitingPayment;
            }
            else
            {
                objInvoiceInsInfo.APInvoiceInDepositBalance = 0;
                objInvoiceInsInfo.APInvoiceInWaitingPayment = 0;
            }
            objInvoiceInsInfo.APInvoiceInBalanceDue = objInvoiceInsInfo.APInvoiceInTotalCost - objInvoiceInsInfo.APInvoiceInDepositBalance;
            SetPropertyChangeEventLock(true);
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            APInvoiceInItemsController objItemsController = new APInvoiceInItemsController();

            DataSet ds = objItemsController.GetInvoiceInItemByInvoiceInID(iObjectID);
            InvoiceInItemsList.Invalidate(ds);


            //Invalidate item components
            InvalidateItemComponents();

            //CountItemsInInvoiceInPackageItemList = InvoiceInPackageItemList.Count();
            //InvoiceInPackageItemList.Clear();

            //bool isEditing = false;
            //InvoiceInPackageItemList.Invalidate(iObjectID);
            //InvoiceInPackageItemList.ForEach(o =>
            //{
            //    if (o.APInvoiceInPackageItemID == 0)
            //    {
            //        isEditing = true;
            //    }
            //});
            //if (!isEditing)
            //{
            //    InvoiceInPackageItemDetailShowList.Clear();
            //    InvoiceInPackageItemList.ForEach(o =>
            //    {
            //        APInvoiceInPackageItemDetailsController objInvoiceInPackageItemDetailsController = new APInvoiceInPackageItemDetailsController();
            //        List<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailList = objInvoiceInPackageItemDetailsController.GetPackageItemDetailsListByPackageItemID(o.APInvoiceInPackageItemID);
            //        InvoiceInPackageItemDetailList.ForEach(x =>
            //        {
            //            InvoiceInPackageItemDetailShowList.Add(x);
            //        });
            //    });
            //}
            //InvoiceInPackageItemDetailShowList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            InvoiceInItemsList.SaveItemObjects();
        }

        public void UpdateReferencePurchaseOrderInvoiceInAmount()
        {
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APInvoiceInsInfo mainObject = MainObject as APInvoiceInsInfo;
            //Rollback

            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            foreach (APInvoiceInItemsInfo invoiceItem in InvoiceInItemsList.BackupList)
            {
                //Update References Purchase Order
                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(mainObject.APInvoiceInReference);
                if (objPurchaseOrdersInfo != null)
                {
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceInAmount -= invoiceItem.APInvoiceInItemTotalCost;
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                }


            }

            //Update References Purchase Order
            foreach (APInvoiceInItemsInfo invoiceItem in InvoiceInItemsList)
            {
                APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(mainObject.APInvoiceInReference);
                if (objPurchaseOrdersInfo != null)
                {
                    objPurchaseOrdersInfo.APPurchaseOrderInvoiceInAmount += invoiceItem.APInvoiceInItemTotalCost;
                    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
                }
            }
        }

        /// <summary>
        /// Update reference purchase orders that the current invoice has been created from
        /// </summary>
        public void UpdateReferencePurchaseOrders()
        {
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            List<APPurchaseOrdersInfo> purchaseOrders = new List<APPurchaseOrdersInfo>();
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)MainObject;
            string[] purchaseOrderNos = invoice.APInvoiceInReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < purchaseOrderNos.Length; i++)
            {
                string purchaseOrderNo = purchaseOrderNos[i].Trim();
                APPurchaseOrdersInfo purchaseOrder = purchaseOrders.Where(po => po.APPurchaseOrderNo == purchaseOrderNo).FirstOrDefault();
                if (purchaseOrder == null)
                {
                    purchaseOrder = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(purchaseOrderNo);
                    if (purchaseOrder != null)
                    {
                        purchaseOrders.Add(purchaseOrder);
                        List<APPurchaseOrderItemsInfo> purchaseOrderItems = objPurchaseOrderItemsController.GetComponentItemsByPurchaseOrderID(purchaseOrder.APPurchaseOrderID);
                    }
                }
            }

            //Rollback packaged quantity of reference purchase order items
            foreach (APInvoiceInItemsInfo invoiceItem in InvoiceInItemsList.BackupList)
            {
                APPurchaseOrderItemsInfo purchaseOrderItem = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(invoiceItem.FK_APPurchaseOrderItemID);
                if (purchaseOrderItem != null)
                {
                    purchaseOrderItem.APPurchaseOrderItemPackagedQty -= invoiceItem.APInvoiceInItemProductExchangeQty / purchaseOrderItem.APPurchaseOrderItemProductFactor;
                    objPurchaseOrderItemsController.UpdatePackagedQty(purchaseOrderItem.APPurchaseOrderItemID, purchaseOrderItem.APPurchaseOrderItemPackagedQty);
                }
            }

            //Update new packaged quantity of reference purchase order items            
            foreach (APInvoiceInItemsInfo invoiceItem in InvoiceInItemsList)
            {
                APPurchaseOrderItemsInfo purchaseOrderItem = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(invoiceItem.FK_APPurchaseOrderItemID);
                if (purchaseOrderItem != null)
                {
                    purchaseOrderItem.APPurchaseOrderItemPackagedQty += invoiceItem.APInvoiceInItemProductExchangeQty / purchaseOrderItem.APPurchaseOrderItemProductFactor;
                    objPurchaseOrderItemsController.UpdatePackagedQty(purchaseOrderItem.APPurchaseOrderItemID, purchaseOrderItem.APPurchaseOrderItemPackagedQty);
                }
            }

            //Update the purchase order's status
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            foreach (APPurchaseOrdersInfo purchaseOrder in purchaseOrders)
            {
                if (purchaseOrder.APPurchaseOrderStatus == PurchaseOrderStatus.New.ToString())
                {
                    purchaseOrder.APPurchaseOrderStatus = PurchaseOrderStatus.Packaged.ToString();
                }
                purchaseOrder.APPurchaseOrderPackingDate = objInvoiceInsInfo.APInvoiceInValidateDate;
                objPurchaseOrdersController.UpdateObject(purchaseOrder);
            }
        }

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.APInvoiceInItemsTableName]);
            UpdateModuleObjectBindingSource(TableName.APInvoiceInItemsTableName);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                APInvoiceInItemsInfo invoiceItem = (APInvoiceInItemsInfo)item;
                SetDefaultValuesFromProduct(productID, invoiceItem);
                SetProductCost(invoiceItem);
                invoiceItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                invoiceItem.FK_ICStockID = objInvoiceInsInfo.FK_ICStockID;
                invoiceItem.APInvoiceInItemReceiptedQty = 0;
                invoiceItem.APInvoiceInItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
            }
        }
        #endregion


        public void UpdateTotalCost()
        {
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            objInvoiceInsInfo.APInvoiceInSubTotalCost = 0;

            int currencyDecimal = BOSApp.GetDecimalNumberByCurrencyID(objInvoiceInsInfo.FK_GECurrencyID);

            foreach (APInvoiceInItemsInfo entItem in InvoiceInItemsList)
            {
                objInvoiceInsInfo.APInvoiceInSubTotalCost += entItem.APInvoiceInItemTotalCost;
            }
            objInvoiceInsInfo.APInvoiceInSubTotalCost = Math.Round(objInvoiceInsInfo.APInvoiceInSubTotalCost, currencyDecimal, MidpointRounding.AwayFromZero);

            objInvoiceInsInfo.APInvoiceInDiscountFix = objInvoiceInsInfo.APInvoiceInSubTotalCost * objInvoiceInsInfo.APInvoiceInDiscountPerCent / 100;
            objInvoiceInsInfo.APInvoiceInDiscountFix = Math.Round(objInvoiceInsInfo.APInvoiceInDiscountFix, currencyDecimal, MidpointRounding.AwayFromZero);

            objInvoiceInsInfo.APInvoiceInTaxAmount = (objInvoiceInsInfo.APInvoiceInSubTotalCost -
                                                         objInvoiceInsInfo.APInvoiceInDiscountFix +
                                                         objInvoiceInsInfo.APInvoiceInShippingFees +
                                                         objInvoiceInsInfo.APInvoiceInShippingExtraFees) * objInvoiceInsInfo.APInvoiceInTaxPercent / 100;
            objInvoiceInsInfo.APInvoiceInTaxAmount = Math.Round(objInvoiceInsInfo.APInvoiceInTaxAmount, currencyDecimal, MidpointRounding.AwayFromZero);

            objInvoiceInsInfo.APInvoiceInTotalCost = objInvoiceInsInfo.APInvoiceInSubTotalCost -
                                                        objInvoiceInsInfo.APInvoiceInDiscountFix +
                                                        objInvoiceInsInfo.APInvoiceInTaxAmount +
                                                        objInvoiceInsInfo.APInvoiceInShippingFees +
                                                        objInvoiceInsInfo.APInvoiceInShippingExtraFees;
            objInvoiceInsInfo.APInvoiceInTotalCost = Math.Round(objInvoiceInsInfo.APInvoiceInTotalCost, currencyDecimal, MidpointRounding.AwayFromZero);

            objInvoiceInsInfo.APInvoiceInDepositBalance = PaymentDetailList.Sum(p => p.APClearingDetailAmount);
            if (objInvoiceInsInfo.OldObject != null)
            {
                APInvoiceInsInfo oldInvoice = (APInvoiceInsInfo)objInvoiceInsInfo.OldObject;
                objInvoiceInsInfo.APInvoiceInBalanceDue = oldInvoice.APInvoiceInBalanceDue +
                                                            oldInvoice.APInvoiceInDepositBalance - objInvoiceInsInfo.APInvoiceInDepositBalance +
                                                            objInvoiceInsInfo.APInvoiceInTotalCost - oldInvoice.APInvoiceInTotalCost;
            }
            else
            {
                objInvoiceInsInfo.APInvoiceInBalanceDue = objInvoiceInsInfo.APInvoiceInTotalCost - objInvoiceInsInfo.APInvoiceInDepositBalance;
            }
            BOSApp.RoundByCurrency(objInvoiceInsInfo, objInvoiceInsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        #region Generate Entities
        /// <summary>
        /// Generate invoice and it's items from purchase orders
        /// </summary>
        /// <param name="objTemplatePurchaseOrdersInfo">Template purchase order is used to copy general info</param>
        /// <param name="selectedPurchaseOrders">Selected purchase orders</param>
        public void GenerateEntitiesFromPurchaseOrders(APPurchaseOrdersInfo objTemplatePurchaseOrdersInfo, IList<APPurchaseOrdersInfo> selectedPurchaseOrders)
        {
            //Generate invoice
            GenerateInvoiceFromPurchaseOrder(objTemplatePurchaseOrdersInfo);

            APInvoiceInsInfo invoice = (APInvoiceInsInfo)MainObject;
            invoice.APInvoiceInReference = string.Empty;
            for (int i = 0; i < selectedPurchaseOrders.Count; i++)
            {
                invoice.APInvoiceInReference += selectedPurchaseOrders[i].APPurchaseOrderNo;
                invoice.APInvoiceInDepositBalance += selectedPurchaseOrders[i].APPurchaseOrderPaidAmount;
                if (i < selectedPurchaseOrders.Count - 1)
                {
                    invoice.APInvoiceInReference += ", ";
                }
            }

            //Generate invoice items
            foreach (APPurchaseOrdersInfo objPurchaseOrdersInfo in selectedPurchaseOrders)
            {
                GenerateInvoiceItemsFromPurchaseOrder(objPurchaseOrdersInfo);
            }

            UpdateTotalCost();
        }

        /// <summary>
        /// Generate invoice and it's items from a given purchase order
        /// </summary>
        /// <param name="objPurchaseOrdersInfo">Given purchase order</param>
        public void GenerateEntitiesFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            //Generate invoice            
            GenerateInvoiceFromPurchaseOrder(objPurchaseOrdersInfo);

            //Generate invoice items
            GenerateInvoiceItemsFromPurchaseOrder(objPurchaseOrdersInfo);

            UpdateTotalCost();
        }

        /// <summary>
        /// Generate an invoice from a given purchase order and set to main object
        /// </summary>
        /// <param name="objPurchaseOrdersInfo">Given purchase order</param>
        private void GenerateInvoiceFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            //Copy invoice
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            APInvoiceInsInfo objOldInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsInfo.Clone();
            BOSUtil.CopyObject(objPurchaseOrdersInfo, objInvoiceInsInfo);
            objInvoiceInsInfo.APInvoiceInReference = objPurchaseOrdersInfo.APPurchaseOrderNo;
            objInvoiceInsInfo.APInvoiceInSupplierNo = objPurchaseOrdersInfo.APPurchaseOrderContractNo;
            objInvoiceInsInfo.APInvoiceInContractDate = objPurchaseOrdersInfo.APPurchaseOrderContractDate;
            objInvoiceInsInfo.APInvoiceInContractNo = objPurchaseOrdersInfo.APPurchaseOrderContractNo;
            objInvoiceInsInfo.APInvoiceInContractDate = objPurchaseOrdersInfo.APPurchaseOrderContractDate;
            //objInvoiceInsInfo.APInvoiceInProject = objPurchaseOrdersInfo.APPurchaseOrderProject;

            //Set transit-in stock
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStocksInfo = null;
            if (objPurchaseOrdersInfo.FK_BRBranchID > 0)
            {
                objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), objPurchaseOrdersInfo.FK_BRBranchID);
            }
            else
            {
                objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }
            if (objStocksInfo != null)
            {
                objInvoiceInsInfo.FK_ICStockID = objStocksInfo.ICStockID;
            }

            //Restore some its own properties
            objInvoiceInsInfo.APInvoiceInNo = objOldInvoiceInsInfo.APInvoiceInNo;
            objInvoiceInsInfo.APInvoiceInDesc = objOldInvoiceInsInfo.APInvoiceInDesc;
            objInvoiceInsInfo.APInvoiceInEmployeePicture = objOldInvoiceInsInfo.APInvoiceInEmployeePicture;
            //objInvoiceInsInfo.APInvoiceInType = objOldInvoiceInsInfo.APInvoiceInType;
            objInvoiceInsInfo.APInvoiceInStatus = objOldInvoiceInsInfo.APInvoiceInStatus;
            objInvoiceInsInfo.APInvoiceInDate = objOldInvoiceInsInfo.APInvoiceInDate;
            //objInvoiceInsInfo.APInvoiceInValidateDate = objOldInvoiceInsInfo.APInvoiceInValidateDate;
            objInvoiceInsInfo.APInvoiceInValidateDate = GetDateForPayment(objPurchaseOrdersInfo.APPurchaseOrderID);
            objInvoiceInsInfo.FK_HREmployeeID = objOldInvoiceInsInfo.FK_HREmployeeID;
            objInvoiceInsInfo.APInvoiceInTaxPercent = objPurchaseOrdersInfo.APPurchaseOrderTaxPercent;
        }

        /// <summary>
        /// Generate invoice items from a given purchase order and add them to the current invoice item list        
        /// </summary>
        /// <param name="objPurchaseOrdersInfo">Given purchase order</param>
        private void GenerateInvoiceItemsFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            //Copy item list
            BOSList<APPurchaseOrderItemsInfo> purchaseOrderItems = new BOSList<APPurchaseOrderItemsInfo>();
            purchaseOrderItems.InitBOSList(null, TableName.APPurchaseOrdersTableName, TableName.APPurchaseOrderItemsTableName, BOSList<APPurchaseOrderItemsInfo>.cstRelationForeign);
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();

            List<APPurchaseOrderItemsInfo> purchaseOrderItemsList = objPurchaseOrderItemsController.GetAllItemsByPurchaseOrderID(objPurchaseOrdersInfo.APPurchaseOrderID);
            purchaseOrderItems.Invalidate(purchaseOrderItemsList.Where(o => o.APPurchaseOrderItemDivision == PurchaseOrderItemDivision.Product.ToString()).ToList());
            foreach (APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo in purchaseOrderItems)
            {
                if (objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemPackagedQty > 0)
                {
                    APInvoiceInItemsInfo objInvoiceInItemsInfo = new APInvoiceInItemsInfo();
                    BOSUtil.CopyObject(objPurchaseOrderItemsInfo, objInvoiceInItemsInfo);

                    //Set transit-in stock
                    ICStocksController objStockController = new ICStocksController();
                    ICStocksInfo objStocksInfo = null;
                    if (objPurchaseOrdersInfo.FK_BRBranchID > 0)
                    {
                        objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), objPurchaseOrdersInfo.FK_BRBranchID);
                    }
                    else
                    {
                        objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                    }
                    if (objStocksInfo != null)
                    {
                        objInvoiceInItemsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                    }

                    objInvoiceInItemsInfo.FK_APPurchaseOrderID = objPurchaseOrderItemsInfo.FK_APPurchaseOrderID;
                    objInvoiceInItemsInfo.FK_APPurchaseOrderItemID = objPurchaseOrderItemsInfo.APPurchaseOrderItemID;
                    objInvoiceInItemsInfo.APInvoiceInItemProductQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty - objPurchaseOrderItemsInfo.APPurchaseOrderItemPackagedQty;
                    objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty = 0;
                    objInvoiceInItemsInfo.APInvoiceInItemWoodQty = objPurchaseOrderItemsInfo.APPurchaseOrderItemWoodQty;
                    objInvoiceInItemsInfo.FK_ICModelID = objPurchaseOrderItemsInfo.FK_ICModelID;
                    objInvoiceInItemsInfo.FK_ICModelDetailID = objPurchaseOrderItemsInfo.FK_ICModelDetailID;
                    objInvoiceInItemsInfo.APInvoiceInItemProductSupplierNo = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductSupplierNo;
                    //TKChinh [Add]
                    objInvoiceInItemsInfo.APInvoiceInItemProductUnitCostTam = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductUnitCostTam;
                    objInvoiceInItemsInfo.APInvoiceInItemTotalCostTam = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductUnitCostTam * objPurchaseOrderItemsInfo.APPurchaseOrderItemWoodQty;
                    //TKChinh [End]
                    objInvoiceInItemsInfo.APInvoiceInItemProductQtySter = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQtySter;
                    objInvoiceInItemsInfo.APInvoiceInItemProductUnitCostSter = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductUnitCostSter;
                    objInvoiceInItemsInfo.APInvoiceInItemTotalCostSter = objPurchaseOrderItemsInfo.APPurchaseOrderItemTotalCostSter;
                    objInvoiceInItemsInfo.FK_ICProductAttributeTTMTID = objPurchaseOrderItemsInfo.FK_ICProductAttributeTTMTID;
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objPurchaseOrderItemsInfo.FK_ICProductID);
                    objInvoiceInItemsInfo.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                    if (objProductsInfo != null)
                    {
                        //if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                        //{
                        //    objInvoiceInItemsInfo.APInvoiceInItemProductQty = Math.Round(objInvoiceInItemsInfo.APInvoiceInItemProductQty, 4, MidpointRounding.AwayFromZero);
                        //}
                        //else
                        //{
                        //    objInvoiceInItemsInfo.APInvoiceInItemProductQty = Math.Round(objInvoiceInItemsInfo.APInvoiceInItemProductQty, 2, MidpointRounding.AwayFromZero);
                        //}
                        objInvoiceInItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    }
                    objInvoiceInItemsInfo.APInvoiceInItemProductFactor = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductFactor;
                    SetProductCostByProductUnitCost(objInvoiceInItemsInfo);
                    InvoiceInItemsList.Add(objInvoiceInItemsInfo);
                }
            }
        }
        #endregion

        public override void SetDefaultValuesFromSupplier(APSuppliersInfo objSuppliersInfo)
        {
            base.SetDefaultValuesFromSupplier(objSuppliersInfo);
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            objInvoiceInsInfo.APInvoiceInValidateDate = objInvoiceInsInfo.APInvoiceInDate.AddDays(objSuppliersInfo.APSupplierDueDays);
        }

        /// <summary>
        /// Invalidate item components of the receipt items
        /// </summary>
        public void InvalidateItemComponents()
        {
            APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            List<APInvoiceInItemsInfo> items = objInvoiceInItemsController.GetComponentItemsByInvoiceInID(objInvoiceInsInfo.APInvoiceInID);
            ComponentInvoiceInItemList.Clear();
            ComponentInvoiceInItemList.OriginalList.Clear();
            ComponentInvoiceInItemList.BackupList.Clear();
            foreach (APInvoiceInItemsInfo item in items)
            {
                ComponentInvoiceInItemList.Add((APInvoiceInItemsInfo)item.Clone());
            }

            foreach (APInvoiceInItemsInfo item in ComponentInvoiceInItemList)
            {
                ComponentInvoiceInItemList.OriginalList.Add((APInvoiceInItemsInfo)item.Clone());
                ComponentInvoiceInItemList.BackupList.Add((APInvoiceInItemsInfo)item.Clone());
            }
        }

        #region Accounting
        #endregion

        //TNDLoc [ADD][17/11/2015][Issue New From Purchase Receipt],START
        public void GenerateEntitiesFromPurchaseReceipts(ICReceiptsInfo objReceiptsInfo, IList<ICReceiptItemsInfo> receiptItemList)
        {
            //Generate invoice
            //Copy invoice
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            APInvoiceInsInfo objOldInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsInfo.Clone();
            BOSUtil.CopyObject(objReceiptsInfo, objInvoiceInsInfo);
            //  objInvoiceInsInfo.APInvoiceInReference = objReceiptsInfo.ICReceiptReference; 

            //Set transit-in stock
            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStocksInfo = null;
            if (objReceiptsInfo.FK_BRBranchID > 0)
            {
                objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), objReceiptsInfo.FK_BRBranchID);
            }
            else
            {
                objStocksInfo = (ICStocksInfo)objStockController.GetStockByTypeAndBranchID(StockType.TransitIn.ToString(), BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }
            if (objStocksInfo != null)
            {
                objInvoiceInsInfo.FK_ICStockID = objStocksInfo.ICStockID;
            }

            //Restore some its own properties
            objInvoiceInsInfo.APInvoiceInNo = objOldInvoiceInsInfo.APInvoiceInNo;
            //objInvoiceInsInfo.APInvoiceInDesc = objOldInvoiceInsInfo.APInvoiceInDesc;
            objInvoiceInsInfo.APInvoiceInEmployeePicture = objOldInvoiceInsInfo.APInvoiceInEmployeePicture;
            objInvoiceInsInfo.APInvoiceInType = objReceiptsInfo.ICReceiptReceiptType;
            objInvoiceInsInfo.APInvoiceInStatus = objOldInvoiceInsInfo.APInvoiceInStatus;
            objInvoiceInsInfo.APInvoiceInDate = objOldInvoiceInsInfo.APInvoiceInDate;
            //objInvoiceInsInfo.APInvoiceInValidateDate = objOldInvoiceInsInfo.APInvoiceInValidateDate;
            objInvoiceInsInfo.APInvoiceInValidateDate = GetDateForPayment(objReceiptsInfo.FK_APPurchaseOrderID);
            objInvoiceInsInfo.FK_HREmployeeID = objOldInvoiceInsInfo.FK_HREmployeeID;
            objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.New.ToString();

            //Generate invoice items
            foreach (ICReceiptItemsInfo objReceiptItemsInfo in receiptItemList)
            {
                if (objReceiptItemsInfo.ICReceiptItemProductQty > 0)
                {
                    APInvoiceInItemsInfo objInvoiceInItemsInfo = new APInvoiceInItemsInfo();
                    BOSUtil.CopyObject(objReceiptItemsInfo, objInvoiceInItemsInfo);

                    //Set transit-in stock
                    objInvoiceInItemsInfo.FK_ICStockID = objInvoiceInsInfo.FK_ICStockID;

                    objInvoiceInItemsInfo.FK_APPurchaseOrderID = objReceiptItemsInfo.FK_APPurchaseOrderID;
                    objInvoiceInItemsInfo.FK_ICReceiptID = objReceiptItemsInfo.FK_ICReceiptID;
                    objInvoiceInItemsInfo.FK_ICReceiptItemID = objReceiptItemsInfo.Id;
                    objInvoiceInItemsInfo.APInvoiceInItemProductQty = objReceiptItemsInfo.ICReceiptItemProductQty
                                                                    - objReceiptItemsInfo.ICReceiptItemInvoiceInItemQty;
                    /*
                        Số lượng hóa đơn = Số lượng nhập kho - Số lượng đã làm hóa đơn
                     */
                    objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty = objReceiptItemsInfo.ICReceiptItemProductQty;
                    objInvoiceInItemsInfo.FK_ICProductAttributeWoodTypeID = objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID;
                    objInvoiceInItemsInfo.APInvoiceInItemQty1 = objReceiptItemsInfo.ICReceiptItemWoodQty;
                    objInvoiceInItemsInfo.APInvoiceInItemProductAttribute = objReceiptItemsInfo.ICReceiptItemProductAttribute;
                    objInvoiceInItemsInfo.FK_ICProductID = objReceiptItemsInfo.FK_ICProductID;
                    objInvoiceInItemsInfo.FK_ICModelID = objReceiptItemsInfo.FK_ICModelID;
                    objInvoiceInItemsInfo.FK_ICModelDetailID = objReceiptItemsInfo.FK_ICModelDetailID;
                    objInvoiceInItemsInfo.APInvoiceInItemProductSupplierNo = objReceiptItemsInfo.ICReceiptItemProductSupplierNo;
                    objInvoiceInItemsInfo.APInvoiceInItemWoodQty = objReceiptItemsInfo.ICReceiptItemWoodQty;
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        //if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                        //                objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                        //{
                        //    objInvoiceInItemsInfo.APInvoiceInItemProductQty = Math.Round(objInvoiceInItemsInfo.APInvoiceInItemProductQty, 4, MidpointRounding.AwayFromZero);
                        //}
                        //else
                        //{
                        //    objInvoiceInItemsInfo.APInvoiceInItemProductQty = Math.Round(objInvoiceInItemsInfo.APInvoiceInItemProductQty, 2, MidpointRounding.AwayFromZero);
                        //}
                        objInvoiceInItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    }
                    //TKChinh [Add]
                    APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                    APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(objReceiptItemsInfo.FK_APPurchaseOrderItemID);
                    if (objPurchaseOrderItemsInfo != null)
                    {
                        objInvoiceInItemsInfo.APInvoiceInItemProductUnitCostTam = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductUnitCostTam;
                        objInvoiceInItemsInfo.APInvoiceInItemTotalCostTam = objPurchaseOrderItemsInfo.APPurchaseOrderItemProductUnitCostTam * objInvoiceInItemsInfo.APInvoiceInItemWoodQty;
                    }
                    //TKChinh [End]

                    objInvoiceInItemsInfo.APInvoiceInItemProductQtySter = objReceiptItemsInfo.ICReceiptItemProductQtySter;
                    objInvoiceInItemsInfo.APInvoiceInItemProductUnitCostSter = objReceiptItemsInfo.ICReceiptItemProductUnitCostSter;
                    objInvoiceInItemsInfo.APInvoiceInItemTotalCostSter = objReceiptItemsInfo.ICReceiptItemTotalCostSter;
                    objInvoiceInItemsInfo.APInvoiceInItemProductFactor = objReceiptItemsInfo.ICReceiptItemProductFactor;
                    objInvoiceInItemsInfo.FK_ICProductAttributeTTMTID = objReceiptItemsInfo.FK_ICProductAttributeTTMTID;
                    //SetProductCost(objInvoiceInItemsInfo);
                    SetProductCostByProductUnitCost(objInvoiceInItemsInfo);
                    // objInvoiceInItemsInfo.APInvoiceInItemReceiptedQty = 0;
                    InvoiceInItemsList.Add(objInvoiceInItemsInfo);
                }
            }

            UpdateTotalCost();
        }
        //TNDLoc [ADD][17/11/2015][Issue New From Purchase Receipt],END
        public DateTime GetDateForPayment(int purcharOrderID)
        {
            APInvoiceInsInfo objInvoicesInfo = (APInvoiceInsInfo)MainObject;
            DateTime Times = new DateTime();
            List<APPurchaseOrderPaymentTimesInfo> ListPurchaseOrderPaymentTimes = new List<APPurchaseOrderPaymentTimesInfo>();
            APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = new APPurchaseOrderPaymentTimesInfo();
            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();
            GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();

            GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
            List<GEPaymentTermItemsInfo> ListPaymentTermItem = new List<GEPaymentTermItemsInfo>();
            GEPaymentTermItemsController objPaymentTermItemsController = new GEPaymentTermItemsController();
            ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetPurchaseReceiptByReceiptReference(objInvoicesInfo.APInvoiceInReference);

            ListPurchaseOrderPaymentTimes = objPurchaseOrderPaymentTimesController.GetObjectByAPPurchaseOrderID(purcharOrderID);
            objPurchaseOrderPaymentTimesInfo = ListPurchaseOrderPaymentTimes.Where(x => x.APPurchaseOrderPaymentTimePaymentType == "Payment").FirstOrDefault();

            if (objPurchaseOrderPaymentTimesInfo != null)
            {
                //objPaymentTermsInfo = (GEPaymentTermsInfo)objPaymentTermsController.GetObjectByID(objPurchaseOrderPaymentTimesInfo.FK_GEPaymentTermID);
                ListPaymentTermItem = objPaymentTermItemsController.GetListItemByPaymentTermID(objPurchaseOrderPaymentTimesInfo.FK_GEPaymentTermID);

                if (objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Deposit.ToString())
                {
                    objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Deposit.ToString()).FirstOrDefault();
                }
                if (objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Payment.ToString())
                {
                    objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                }
                if (objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimePaymentType == "Final Payment")
                {
                    objPaymentTermItemsInfo = ListPaymentTermItem.Where(x => x.GEPaymentTermItemPaymentType == PaymentTermItemPaymentType.Payment.ToString()).FirstOrDefault();
                }


                if (objPaymentTermItemsInfo != null)
                {
                    if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsContract.ToString() || objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsBeforeDelivery.ToString())
                    {
                        Times = objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeDate;
                    }
                    if (objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsAfterDelivery.ToString() || objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate == PaymentTermItemPaymentDate.IsInvoiceIn.ToString())
                    {
                        if (objInvoicesInfo.APInvoiceInVATDate.ToString("dd-MM-yyyy") != "01-01-0001" && objInvoicesInfo.APInvoiceInVATDate.ToString("dd-MM-yyyy") != "12-31-9999")
                        {
                            if (objReceiptsInfo == null)
                            {
                                Times = objInvoicesInfo.APInvoiceInVATDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                            }
                            else if (objReceiptsInfo.ICReceiptDate.ToString("dd-MM-yyyy") != "01-01-0001" && objReceiptsInfo.ICReceiptDate.ToString("dd-MM-yyyy") != "12-31-9999")
                            {
                                if (objReceiptsInfo.ICReceiptDate > objInvoicesInfo.APInvoiceInVATDate)
                                {
                                    Times = objReceiptsInfo.ICReceiptDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                                else
                                {
                                    Times = objInvoicesInfo.APInvoiceInVATDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                                }
                            }
                            else
                            {
                                Times = objInvoicesInfo.APInvoiceInVATDate.AddDays(objPaymentTermItemsInfo.GEPaymentTermItemDay);
                            }
                        }
                    }
                }
            }
            return Times;


        }

        public List<ICReceiptItemsInfo> ToPurchaseReceiptList(IList<APPurchaseOrderItemsInfo> purchaseOrderItemList)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            List<ICReceiptItemsInfo> receiptItemsList = new List<ICReceiptItemsInfo>();
            foreach (APPurchaseOrderItemsInfo obj in purchaseOrderItemList)
            {
                decimal qty = 0;
                if (obj.APPurchaseOrderItemProductQty > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(obj, objReceiptItemsInfo);
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        //NN GIANG ADD AccountID WITH PRODUCT - START - 25-04-2016
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        //NN GIANG ADD AccountID WITH PRODUCT - END - 25-04-2016
                        objReceiptItemsInfo.FK_ACAccountID = GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ACAccountID);
                        //if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                        //            objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                        //{
                        //    qty = Math.Round((obj.APPurchaseOrderItemProductQty), 4, MidpointRounding.AwayFromZero);
                        //}
                        //else
                        //{
                        //    qty = Math.Round((obj.APPurchaseOrderItemProductQty), 2, MidpointRounding.AwayFromZero);
                        //}
                        //if (objProductsInfo.ICProductType == ProductType.Equipment.ToString())
                        //     ((PurchaseReceiptModule)Module).GeneralSeriesForIngredientPackaging(objReceiptItemsInfo);
                    }

                    //ReceiptItemIDMax += 1;
                    //objReceiptItemsInfo.Id = ReceiptItemIDMax;
                    objReceiptItemsInfo.ICReceiptItemProductQty = qty;
                    objReceiptItemsInfo.FK_APPurchaseOrderItemID = obj.APPurchaseOrderItemID;
                    objReceiptItemsInfo.FK_ICModelID = obj.FK_ICModelID;
                    objReceiptItemsInfo.FK_ICModelDetailID = obj.FK_ICModelDetailID;
                    objReceiptItemsInfo.FK_MMBatchProductID = obj.FK_MMBatchProductID;
                    SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    objReceiptItemsInfo.ICReceiptItemProductSupplierNo = obj.APPurchaseOrderItemProductSupplierNo;
                    objReceiptItemsInfo.ICReceiptItemWoodQty = obj.APPurchaseOrderItemWoodQty;
                    objReceiptItemsInfo.ICReceiptItemInventoryCost = objReceiptItemsInfo.ICReceiptItemProductUnitCost;
                    receiptItemsList.Add(objReceiptItemsInfo);
                }
            }
            return receiptItemsList;
        }

        public override bool CompleteTransaction()
        {
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)MainObject;
            invoice.APInvoiceInStatus = InvoiceInStatus.Completed.ToString();
            UpdateMainObject();
            UpdateUnifinishedCost();
            return base.CompleteTransaction();
        }

        public void UpdateUnifinishedCost()
        {
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)MainObject;
            foreach (APInvoiceInItemsInfo objInvoiceInItemsInfo in InvoiceInItemsList)
            {
                ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = objUnfinishedConstructionCostsController.GetObjectByID(objInvoiceInItemsInfo.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (objUnfinishedConstructionCostsInfo != null)
                {
                    objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostValue += (objInvoiceInItemsInfo.APInvoiceInItemExtCost - objInvoiceInItemsInfo.APInvoiceInItemDiscountAmount) * invoice.APInvoiceInExchangeRate;
                    objUnfinishedConstructionCostsController.UpdateObject(objUnfinishedConstructionCostsInfo);
                }
            }
        }

        public void RemoveOldInvoiceInPackageItemDetailItem(IBOSList<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailsList)
        {
            List<APInvoiceInPackageItemDetailsInfo> RemovePackageItemDetailsList = (List<APInvoiceInPackageItemDetailsInfo>)InvoiceInPackageItemDetailsList;
            RemovePackageItemDetailsList.ForEach(o =>
            {
                InvoiceInPackageItemDetailShowList.ForEach(x =>
                {
                    if (o.FK_APPOPackageItemID > 0)
                    {
                        if (x.FK_APPOPackageItemID == o.FK_APPOPackageItemID)
                            InvoiceInPackageItemDetailShowList.Remove(x);
                    }
                    else if (x.FK_APInvoiceInPackageItemID == o.FK_APInvoiceInPackageItemID)
                        InvoiceInPackageItemDetailShowList.Remove(x);
                });
            });
        }
        public override void SetProductCostByProductUnitCost(BusinessObject objItem)
        {
            base.SetProductCostByProductUnitCost(objItem);
            APInvoiceInsInfo mainObject = (APInvoiceInsInfo)MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = objCurrenciesController.GetObjectByID(mainObject.FK_GECurrencyID) as GECurrenciesInfo;
            if (objCurrenciesInfo == null || objCurrenciesInfo.GECurrencyNo != "VND")
                return;
            BOSDbUtil dbUtil = new BOSDbUtil();
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, "APInvoiceInExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;
            object value = dbUtil.GetPropertyValue(objItem, "APInvoiceInItemTaxAmount");
            decimal amount = 0;
            if (value != null)
            {
                amount = Convert.ToDecimal(value);
                amount = Math.Round(amount, 0);
                dbUtil.SetPropertyValue(objItem, "APInvoiceInItemTaxAmount", amount);
                dbUtil.SetPropertyValue(objItem, "APInvoiceInItemExchangeTaxAmount", amount * exchangeRate);
            }
            value = dbUtil.GetPropertyValue(objItem, "APInvoiceInItemExtCost");
            if (value != null)
            {
                amount = Convert.ToDecimal(value);
                dbUtil.SetPropertyValue(objItem, "APInvoiceInItemExchangeExtCost", Math.Round(amount * exchangeRate, 0, MidpointRounding.AwayFromZero));
            }
            value = dbUtil.GetPropertyValue(objItem, "APInvoiceInItemTotalCost");
            if (value != null)
            {
                amount = Convert.ToDecimal(value);
                dbUtil.SetPropertyValue(objItem, "APInvoiceInItemExchangeTotalCost", Math.Round(amount * exchangeRate, 0, MidpointRounding.AwayFromZero));
            }
        }

        public override bool CancelCompleteTransaction()
        {
            APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)MainObject;
            objInvoiceInsInfo.APInvoiceInStatus = InvoiceInStatus.New.ToString();
            UpdateMainObject();
            return true;
        }

        public void RollbackUnifinishedCost()
        {
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            APInvoiceInsInfo invoice = (APInvoiceInsInfo)MainObject;
            foreach (APInvoiceInItemsInfo objInvoiceInItemsInfo in InvoiceInItemsList)
            {
                ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = objUnfinishedConstructionCostsController.GetObjectByID(objInvoiceInItemsInfo.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                if (objUnfinishedConstructionCostsInfo != null)
                {
                    objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostValue -= (objInvoiceInItemsInfo.APInvoiceInItemExtCost - objInvoiceInItemsInfo.APInvoiceInItemDiscountAmount) * invoice.APInvoiceInExchangeRate;
                    objUnfinishedConstructionCostsController.UpdateObject(objUnfinishedConstructionCostsInfo);
                }
            }
        }

        public void ModuleAfterCancelCompleted()
        {
            RollbackUnifinishedCost();
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                InvoiceInItemsList.DeleteItemObjects();

                APPurchaseOrdersController objPurchaseOrderController = new APPurchaseOrdersController();
                objPurchaseOrderController.RollbackReferencePurchaseOrdersAndItemByInvoiceInID(iObjectID);

                ICReceiptsController objReceiptsController = new ICReceiptsController();
                objReceiptsController.RollbackReferencesReceiptAndItemByInvoiceInID(iObjectID);
            }
        }
    }
}
