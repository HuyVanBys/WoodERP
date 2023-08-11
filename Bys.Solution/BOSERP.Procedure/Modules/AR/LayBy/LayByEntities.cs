using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP.Modules.LayBy
{
    public class LayByEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        private ARSaleOrdersInfo _aRSaleOrdersObject;
        private ARSaleOrderItemsInfo _aRSaleOrderItemsObject;

        public BOSItemsEntityList<ARSaleOrderItemsInfo> lstARSaleOrderItems;
        public BOSList<ARCustomerPaymentDetailsInfo> lstARCustomerPaymentDetails;
        #endregion

        #region Public Properties
        public ARSaleOrdersInfo ARSaleOrdersObject
        {
            get
            {
                return _aRSaleOrdersObject;
            }
            set
            {
                _aRSaleOrdersObject = value;
            }
        }
        public ARSaleOrderItemsInfo ARSaleOrderItemsObject
        {
            get
            {
                return _aRSaleOrderItemsObject;
            }
            set
            {
                _aRSaleOrderItemsObject = value;
            }
        }

        public BOSItemsEntityList<ARSaleOrderItemsInfo> ARSaleOrderItemsList
        {
            get
            {
                return lstARSaleOrderItems;
            }
            set
            {
                lstARSaleOrderItems = value;
            }
        }

        public BOSList<ARCustomerPaymentDetailsInfo> ARCustomerPaymentDetailsList
        {
            get
            {
                return lstARCustomerPaymentDetails;
            }
            set
            {
                lstARCustomerPaymentDetails = value;
            }
        }
        #endregion

        #region Constructor
        public LayByEntities()
            : base()
        {
            _aRSaleOrdersObject = new ARSaleOrdersInfo();

            _aRSaleOrderItemsObject = new ARSaleOrderItemsInfo();

            lstARSaleOrderItems = new BOSItemsEntityList<ARSaleOrderItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = ARSaleOrdersObject;
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ARSaleOrderItems", ARSaleOrderItemsObject);
        }

        public override void InitModuleObjectList()
        {
            lstARSaleOrderItems = new BOSItemsEntityList<ARSaleOrderItemsInfo>();
            lstARSaleOrderItems.InitBOSList(this,
                 BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARSaleOrdersInfo)),
                 BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARSaleOrderItemsInfo)));
        }

        public override void InitGridControlInBOSList()
        {
            lstARSaleOrderItems.InitBOSListGridControl("fld_dgcARLayByItems");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                lstARSaleOrderItems.SetDefaultListAndRefreshGridControl();
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

            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
            objSaleOrdersInfo.ARSaleOrderDate = DateTime.Now;
            objSaleOrdersInfo.ARSaleOrderDeliveryDate = BOSUtil.GetYearEndDate();
            objSaleOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.New.ToString();
            if (BOSApp.CurrentCompanyInfo != null)
            {
                objSaleOrdersInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            }
            objSaleOrdersInfo.FK_ARPriceLevelID = 1;
            objSaleOrdersInfo.ARSaleOrderTypeCombo = SaleOrderType.LayBy.ToString();
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleOrderItemsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            ARSaleOrderItemsList.EndCurrentEdit();
            UpdateTotalAmount();
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            ARSaleOrderItemsList.SaveItemObjects();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ARSaleOrderItemsInfo objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)ModuleObjects[TableName.ARSaleOrderItemsTableName];
                objSaleOrderItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objSaleOrderItemsInfo.FK_ICStockID = ((ARSaleOrdersInfo)MainObject).FK_ICStockID;
                objSaleOrderItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                objSaleOrderItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                objSaleOrderItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objSaleOrderItemsInfo.ARSaleOrderItemProductAttribute = objProductsInfo.ICProductAttribute;
                objSaleOrderItemsInfo.ARSaleOrderItemProductSerialNo = objProductsInfo.ICProductBarCode;
                UpdateModuleObjectBindingSource(TableName.ARSaleOrderItemsTableName);
            }
        }

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of sale receipt
            ((ARSaleOrdersInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price basing on price level
            foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
                SetProductPrice(entItem, TableName.ARSaleOrderItemsTableName);
            ARSaleOrderItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                objSaleOrdersInfo.ARSaleOrderNetAmount = 0;
                objSaleOrdersInfo.ARSaleOrderTaxAmount = 0;
                objSaleOrdersInfo.ARSaleOrderSubTotalAmount = 0;
                foreach (ARSaleOrderItemsInfo entItem in ARSaleOrderItemsList)
                {
                    objSaleOrdersInfo.ARSaleOrderNetAmount += entItem.ARSaleOrderItemNetAmount;
                    objSaleOrdersInfo.ARSaleOrderTaxAmount += entItem.ARSaleOrderItemTaxAmount;
                    objSaleOrdersInfo.ARSaleOrderSubTotalAmount += entItem.ARSaleOrderItemTotalAmount;
                }
                BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderDiscountFix = objSaleOrdersInfo.ARSaleOrderSubTotalAmount * objSaleOrdersInfo.ARSaleOrderDiscountPerCent / 100;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderDiscountFix", objSaleOrdersInfo.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderTotalAmount = objSaleOrdersInfo.ARSaleOrderSubTotalAmount - objSaleOrdersInfo.ARSaleOrderDiscountFix;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderTotalAmount", objSaleOrdersInfo.FK_GECurrencyID);
                objSaleOrdersInfo.ARSaleOrderBalanceDue = objSaleOrdersInfo.ARSaleOrderTotalAmount - objSaleOrdersInfo.ARSaleOrderDepositBalance;
                BOSApp.RoundByCurrency(objSaleOrdersInfo, "ARSaleOrderBalanceDue", objSaleOrdersInfo.FK_GECurrencyID);
                UpdateMainObjectBindingSource();
            }
        }

        public int TakePayment(decimal totalAmount)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Generate open document if it's the first payment
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    AROpenDocumentsInfo objOpenDocumentsInfo = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                    if (objOpenDocumentsInfo == null)
                    {
                        DataGenerator.GenerateOpenDocumentFromSaleOrder((ARSaleOrdersInfo)MainObject);
                        objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);
                    }
                    ARCustomerPaymentsInfo objCustomerPaymentsInfo = CustomerPayment.CustomerPaymentModule.TakePayment(objOpenDocumentsInfo, totalAmount, ARCustomerPaymentDetailsList);
                    scope.Complete();
                    return objCustomerPaymentsInfo.ARCustomerPaymentID;
                }
                catch (Exception)
                {
                    scope.Dispose();
                    return 0;
                }
            }
        }

        public override bool CompleteTransaction()
        {
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;

            //Generate invoice
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo objInvoicesInfo = DataGenerator.GenerateInvoiceFromSaleOrder(objSaleOrdersInfo);
            objInvoicesInfo.ARInvoiceNo = BOSApp.GetMainObjectNo(ModuleName.Invoice, objInvoicesInfo);
            objInvoicesController.CreateObject(objInvoicesInfo);
            BOSApp.UpdateObjectNumbering(ModuleName.Invoice);
            if (objInvoicesInfo.ARInvoiceID > 0)
            {
                //Generate invoice items
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                List<ARInvoiceItemsInfo> invoiceItemList = DataGenerator.GenerateInvoiceItemsFromSaleOrderItems(
                                                                                                    ARSaleOrderItemsList);
                foreach (ARInvoiceItemsInfo invoiceItem in invoiceItemList)
                {
                    invoiceItem.FK_ARInvoiceID = objInvoicesInfo.ARInvoiceID;
                    objInvoiceItemsController.CreateObject(invoiceItem);
                }

                //Generate shipment
                ICShipmentsController objShipmentsController = new ICShipmentsController();
                ICShipmentsInfo objShipmentsInfo = DataGenerator.GenerateShipmentFromInvoice(objInvoicesInfo);
                objShipmentsInfo.ICShipmentNo = BOSApp.GetMainObjectNo(ModuleName.Shipment, objShipmentsInfo);
                objShipmentsController.CreateObject(objShipmentsInfo);
                BOSApp.UpdateObjectNumbering(ModuleName.Shipment);
                if (objShipmentsInfo.ICShipmentID > 0)
                {
                    //Generate all items of shipment
                    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                    List<ICShipmentItemsInfo> shipmentItemList = DataGenerator.GenerateShipmentItemsFromInvoiceItems(invoiceItemList);
                    foreach (ICShipmentItemsInfo shipmentItem in shipmentItemList)
                    {
                        shipmentItem.FK_ICShipmentID = objShipmentsInfo.ICShipmentID;
                        objShipmentItemsController.CreateObject(shipmentItem);
                    }

                    //Update open document to refer to the generated invoice   
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    AROpenDocumentsInfo objOpenDocumentsInfo = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                    if (objOpenDocumentsInfo != null)
                    {
                        objOpenDocumentsInfo.FK_ARInvoiceID = objInvoicesInfo.ARInvoiceID;
                        objOpenDocumentsController.UpdateObject(objOpenDocumentsInfo);
                    }
                }
            }

            //Update sale order status
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            objSaleOrdersInfo.AAUpdatedDate = DateTime.Now;
            objSaleOrdersInfo.AAUpdatedUser = BOSApp.CurrentUser;
            objSaleOrdersInfo.ARSaleOrderStatus = SaleOrderStatus.Shipped.ToString();
            objSaleOrdersController.UpdateObject(MainObject);
            return true;
        }

        public override bool IsInvalidInventory()
        {
            return ARSaleOrderItemsList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
        }

        public void CancelLayBy()
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Update sale order
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)MainObject;
                    objSaleOrdersInfo.AAUpdatedDate = DateTime.Now;
                    objSaleOrdersInfo.AAUpdatedUser = BOSApp.CurrentUser;
                    objSaleOrdersInfo.ARSaleOrderStatus = LayByModule.cstLayByStatusCancel;
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);

                    scope.Complete();

                    MessageBox.Show("Cancel successfully", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }
        }
    }
}
