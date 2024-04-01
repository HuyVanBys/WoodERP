using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Invoice
{
    public class InvoiceEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets invoice item list
        /// </summary>
        public BOSItemsEntityList<ARInvoiceItemsInfo> InvoiceItemsList { get; set; }

        /// <summary>
        /// Gets or sets invoice item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ARInvoiceItemsInfo> ComponentInvoiceItemList { get; set; }

        public BOSItemsEntityList<ARInvoiceItemsInfo> ManualCreateInvoiceItemsList { get; set; }

        public BOSList<ARClearingDetailsInfo> PaymentDetailList { get; set; }

        public BOSList<ARInvoiceItemWorksInfo> ARInvoiceItemCostList { get; set; }

        public BOSList<ARInvoiceCommissionsInfo> InvoiceCommissionsList { get; set; }
        #endregion

        #region Constructor
        public InvoiceEntities()
            : base()
        {
            InvoiceItemsList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            ComponentInvoiceItemList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            PaymentDetailList = new BOSList<ARClearingDetailsInfo>();
            ManualCreateInvoiceItemsList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            ARInvoiceItemCostList = new BOSList<ARInvoiceItemWorksInfo>();
            InvoiceCommissionsList = new BOSList<ARInvoiceCommissionsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARInvoicesInfo();
            SearchObject = new ARInvoicesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARInvoiceItemsTableName, new ARInvoiceItemsInfo());
            ModuleObjects.Add(TableName.ARInvoiceItemWorksTableName, new ARInvoiceItemWorksInfo());
            ModuleObjects.Add(TableName.ARInvoiceCommissionsTableName, new ARCommissionsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceItemsList.InitBOSList(this,
                                            TableName.ARInvoicesTableName,
                                            TableName.ARInvoiceItemsTableName,
                                            BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);
            InvoiceItemsList.ItemTableForeignKey = "FK_ARInvoiceID";

            ComponentInvoiceItemList.InitBOSList(this,
                                                        TableName.ARInvoicesTableName,
                                                        TableName.ARInvoiceItemsTableName,
                                                        BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);
            ComponentInvoiceItemList.ItemTableForeignKey = "FK_ARInvoiceID";

            ManualCreateInvoiceItemsList.InitBOSList(this,
                                            TableName.ARInvoicesTableName,
                                            TableName.ARInvoiceItemsTableName,
                                            BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);
            ManualCreateInvoiceItemsList.ItemTableForeignKey = "FK_ARInvoiceID";

            ARInvoiceItemCostList.InitBOSList(this,
                                    TableName.ARInvoicesTableName,
                                    TableName.ARInvoiceItemWorksTableName,
                                    BOSList<ARSaleOrderItemWorksInfo>.cstRelationForeign);
            ARInvoiceItemCostList.ItemTableForeignKey = "FK_ARInvoiceID";

            InvoiceCommissionsList.InitBOSList(this,
                                             TableName.ARInvoicesTableName,
                                             TableName.ARInvoiceCommissionsTableName,
                                             BOSList<ARCommissionsInfo>.cstRelationForeign);
            InvoiceCommissionsList.ItemTableForeignKey = "FK_ARInvoiceID";
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceItemsList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(InvoiceModule.DocumentEntryGridControlName);
            ARInvoiceItemCostList.InitBOSListGridControl(InvoiceModule.ARInvoiceItemCostGridControlName);
            InvoiceCommissionsList.InitBOSListGridControl("fld_dgcCommissionsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceItemsList.SetDefaultListAndRefreshGridControl();
                ComponentInvoiceItemList.SetDefaultListAndRefreshGridControl();
                ARInvoiceItemCostList.SetDefaultListAndRefreshGridControl();
                InvoiceCommissionsList.SetDefaultListAndRefreshGridControl();
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
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceDate = BOSApp.GetCurrentServerDate();
            objInvoicesInfo.ARInvoiceDeliveryDate = BOSApp.GetCurrentServerDate();
            objInvoicesInfo.ARInvoiceValidateDate = BOSApp.GetCurrentServerDate();
            objInvoicesInfo.ARInvoiceTypeCombo = InvoiceType.SaleOrder.ToString();
            objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.New.ToString();
            objInvoicesInfo.FK_ARPriceLevelID = 1;
            objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objInvoicesInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objInvoicesInfo.ARInvoiceExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objInvoicesInfo.ARInvoiceDesc = InvoiceLocalizedResources.InvoiceDefaultDesc;
            objInvoicesInfo.ARInvoiceMainSellerCommissionPercent = 100;
            objInvoicesInfo.ARInvoiceSOType = InvoiceSOType.MassProduction.ToString();
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetInvoiceTypeNo();
            if (objEInvoiceTypesInfo != null)
            {
                objInvoicesInfo.FK_ACEInvoiceTypeID = objEInvoiceTypesInfo.ACEInvoiceTypeID;
                objInvoicesInfo.ARInvoiceVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objInvoicesInfo.ARInvoiceVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
            if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
            {
                objInvoicesInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
            }
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            SetPropertyChangeEventLock(false);
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo objTransaction = objInvoicesController.GetInformationTransactionByInvoiceIDAndNo(objInvoicesInfo.ARInvoiceID, objInvoicesInfo.ARInvoiceNo);
            objInvoicesInfo.ACObjectAccessKey = objInvoicesInfo.FK_ACObjectID + ";" + objInvoicesInfo.ARObjectType;
            if (objTransaction != null)
            {
                objInvoicesInfo.ARInvoiceDepositBalance = objTransaction.ARInvoiceDepositBalance;
                objInvoicesInfo.ARInvoiceReceivingAmount = objTransaction.ARInvoiceReceivingAmount;
            }
            else
            {
                objInvoicesInfo.ARInvoiceDepositBalance = 0;
                objInvoicesInfo.ARInvoiceReceivingAmount = 0;
            }
            objInvoicesInfo.ARInvoiceBalanceDue = objInvoicesInfo.ARInvoiceTotalAmount - objInvoicesInfo.ARInvoiceDepositBalance;
            objInvoicesInfo.ActionNewFrom = objInvoicesInfo.STToolbarActionName;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {

            ARInvoiceItemsController objItemsController = new ARInvoiceItemsController();

            DataSet ds = objItemsController.GetInvoiceItemByInvoiceInID(iObjectID);
            InvoiceItemsList.Invalidate(ds);

            foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in InvoiceItemsList)
            {
                objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>();
                objInvoiceItemsInfo.InvoiceItemComponentList.InitBOSList(
                                                                    this,
                                                                    TableName.ARInvoiceItemsTableName,
                                                                    TableName.ARInvoiceItemComponentsTableName,
                                                                    BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                objInvoiceItemsInfo.InvoiceItemComponentList.ItemTableForeignKey = "FK_ARInvoiceItemID";

                ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
                List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                objInvoiceItemsInfo.InvoiceItemComponentList.Invalidate(components);
            }

            //Invalidate package list
            foreach (ARInvoiceItemsInfo item in InvoiceItemsList)
            {
                if (item.InvoiceItemPackageList == null)
                {
                    item.InvoiceItemPackageList = new BOSList<ARInvoiceItemPackagesInfo>();
                    item.InvoiceItemPackageList.InitBOSList(
                                                        this,
                                                        TableName.ARInvoiceItemsTableName,
                                                        TableName.ARInvoiceItemPackagesTableName,
                                                        BOSList<ARInvoiceItemPackagesInfo>.cstRelationForeign);
                    item.InvoiceItemPackageList.ItemTableForeignKey = "FK_ARInvoiceItemID";
                    item.InvoiceItemPackageList.Invalidate(item.ARInvoiceItemID);
                }
            }

            //Invalidate components
            InvalidateItemComponents();

            ComponentInvoiceItemList.BackupList.Clear();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString())
            {
                foreach (ARInvoiceItemsInfo item in ComponentInvoiceItemList)
                {
                    ComponentInvoiceItemList.BackupList.Add((ARInvoiceItemsInfo)item.Clone());
                }
            }
            ARInvoiceItemCostList.Invalidate(iObjectID);
            InvoiceCommissionsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            InvoiceItemsList.SaveItemObjects();

            ARInvoiceItemCostList.SaveItemObjects();
            // Save invoice item component
            SaveInvoiceItemComponentList(InvoiceItemsList);

            //Save accounting data
            //SaveAccountingData();

            InvoiceCommissionsList.SaveItemObjects();
        }

        /// <summary>
        /// Save invoice item component list by invoice item
        /// </summary>
        /// <param name="invoiceItemList">List of invoice item</param>
        public void SaveInvoiceItemComponentList(BOSItemsEntityList<ARInvoiceItemsInfo> invoiceItemList)
        {
            ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
            if (invoiceItemList != null)
            {
                foreach (ARInvoiceItemsInfo itemEntity in invoiceItemList)
                {
                    if (itemEntity.InvoiceItemComponentList != null)
                    {
                        foreach (ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo in itemEntity.InvoiceItemComponentList)
                        {
                            objInvoiceItemComponentsInfo.FK_ARInvoiceItemID = itemEntity.ARInvoiceItemID;
                        }
                        itemEntity.InvoiceItemComponentList.SaveItemObjects();
                    }
                }
            }
        }

        /// <summary>
        /// Update reference sale orders that the current invoice has been created from
        /// </summary>
        public void UpdateReferenceSaleOrders()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
            List<ARSaleOrdersInfo> saleOrders = new List<ARSaleOrdersInfo>();
            List<ARSaleOrderItemsInfo> allSaleOrderItems = new List<ARSaleOrderItemsInfo>();
            ARInvoicesInfo invoice = (ARInvoicesInfo)MainObject;
            string[] saleOrderNos = new string[0];
            ICShipmentProposalsController objShipmentProposalsController = new ICShipmentProposalsController();
            ICShipmentProposalItemsController objShipmentProposalItemsController = new ICShipmentProposalItemsController();
            ICShipmentProposalsInfo objShipmentProposalsInfo = (ICShipmentProposalsInfo)objShipmentProposalsController.GetObjectByNo(invoice.ARInvoiceReference);
            List<ICShipmentProposalItemsInfo> spiList = new List<ICShipmentProposalItemsInfo>();


            if (objShipmentProposalsInfo != null)
            {
                spiList = objShipmentProposalItemsController.GetShipmentProposalItemsByShipmentProposalID(objShipmentProposalsInfo.ICShipmentProposalID);

                saleOrderNos = objShipmentProposalsInfo.ICShipmentProposalReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


                foreach (ARInvoiceItemsInfo invoiceItem in ComponentInvoiceItemList.BackupList)
                {
                    decimal invoiceItemQty = invoiceItem.ARInvoiceItemProductQty;
                    ICShipmentProposalItemsInfo objShipmentProposalItemsInfo = spiList.Where(i => i.ICShipmentProposalItemID == invoiceItem.FK_ICShipmentProposalItemID &&
                            i.ICShipmentProposalItemProductRemainQty > 0).FirstOrDefault();
                    if (objShipmentProposalItemsInfo != null)
                    {
                        objShipmentProposalItemsInfo.ICShipmentProposalItemProductShippedQty -= invoiceItemQty;
                        objShipmentProposalItemsController.UpdateObject(objShipmentProposalItemsInfo);
                    }
                }
            }

            else if (!invoice.ARInvoiceReference.Equals(String.Empty))
            {
                saleOrderNos = invoice.ARInvoiceReference.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < saleOrderNos.Length; i++)
            {
                string saleOrderNo = saleOrderNos[i].Trim();
                ARSaleOrdersInfo saleOrder = saleOrders.Where(so => so.ARSaleOrderNo == saleOrderNo).FirstOrDefault();
                if (saleOrder == null)
                {
                    saleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(saleOrderNo);
                    if (saleOrder != null)
                    {
                        List<ARSaleOrderItemsInfo> saleOrderItems = objSaleOrderItemsController.GetComponentItemsBySaleOrderID(saleOrder.ARSaleOrderID);
                        //Set remained quantity for items
                        foreach (ARSaleOrderItemsInfo saleOrderItem in saleOrderItems)
                        {
                            saleOrderItem.ARSaleOrderItemRemainedQty = saleOrderItem.ARSaleOrderItemProductQty - saleOrderItem.ARSaleOrderItemCanceledQty - saleOrderItem.ARSaleOrderItemShippedQty;
                        }
                        allSaleOrderItems.AddRange(saleOrderItems);

                        //Set sto+ck for sale order to update SO inventory
                        ICStocksController objStocksController = new ICStocksController();
                        ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.SaleOrder.ToString(), saleOrder.FK_BRBranchID);
                        if (objStocksInfo != null)
                        {
                            saleOrder.SaleOrderStockID = objStocksInfo.ICStockID;
                        }
                        saleOrders.Add(saleOrder);
                    }
                }
            }


            //Rollback ordered quantity of the reference sale order
            foreach (ARInvoiceItemsInfo invoiceItem in ComponentInvoiceItemList.BackupList)
            {
                decimal invoiceItemQty = invoiceItem.ARInvoiceItemProductQty;
                while (invoiceItemQty > 0)
                {
                    ARSaleOrderItemsInfo saleOrderItem = allSaleOrderItems.Where(i => i.ARSaleOrderItemID == invoiceItem.FK_ARSaleOrderItemID &&
                                                                                      i.ARSaleOrderItemShippedQty > 0).FirstOrDefault();

                    decimal shippedQty = 0;
                    if (saleOrderItem != null)
                    {
                        shippedQty = Math.Min(invoiceItemQty, saleOrderItem.ARSaleOrderItemShippedQty);
                    }
                    else
                    {
                        saleOrderItem = allSaleOrderItems.Where(i => i.ARSaleOrderItemID == invoiceItem.FK_ARSaleOrderItemID).FirstOrDefault();
                        shippedQty = invoiceItemQty;
                    }

                    if (saleOrderItem != null)
                    {
                        //Rollback shipped quantity
                        saleOrderItem.ARSaleOrderItemShippedQty -= shippedQty;
                        saleOrderItem.ARSaleOrderItemRemainedQty = saleOrderItem.ARSaleOrderItemProductQty - saleOrderItem.ARSaleOrderItemCanceledQty - saleOrderItem.ARSaleOrderItemShippedQty;
                        //In case user removes an invoice item, the shipped quantity of the reference sale order one needs to be updated as well
                        if (!ComponentInvoiceItemList.Exists(i => i.ARInvoiceItemID == invoiceItem.ARInvoiceItemID))
                        {
                            if (!saleOrderItem.IsSubItem)
                            {
                                objSaleOrderItemsController.UpdateShippedQty(saleOrderItem.ARSaleOrderItemID, saleOrderItem.ARSaleOrderItemShippedQty);
                            }
                            else
                            {
                                objSOItemComponentsController.UpdateShippedQty(saleOrderItem.ARSOItemComponentID, saleOrderItem.ARSaleOrderItemShippedQty);
                            }
                        }

                        ARSaleOrdersInfo saleOrder = saleOrders.Where(so => so.ARSaleOrderID == saleOrderItem.FK_ARSaleOrderID).FirstOrDefault();

                        invoiceItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Update new ordered quantity
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            foreach (ARInvoiceItemsInfo invoiceItem in ComponentInvoiceItemList)
            {
                decimal invoiceItemQty = invoiceItem.ARInvoiceItemProductQty;
                while (invoiceItemQty > 0)
                {
                    ARSaleOrderItemsInfo saleOrderItem = allSaleOrderItems.Where(i => i.ARSaleOrderItemID == invoiceItem.FK_ARSaleOrderItemID &&
                                                                                    i.ARSaleOrderItemRemainedQty > 0).FirstOrDefault();

                    ICShipmentProposalItemsInfo objShipmentProposalItemsInfo = spiList.Where(i => i.ICShipmentProposalItemID == invoiceItem.FK_ICShipmentProposalItemID).FirstOrDefault();
                    if (objShipmentProposalItemsInfo != null)
                    {
                        objShipmentProposalItemsInfo.ICShipmentProposalItemProductShippedQty += invoiceItemQty;
                        objShipmentProposalItemsInfo.ICShipmentProposalItemProductRemainQty = objShipmentProposalItemsInfo.ICShipmentProposalItemProductQty - objShipmentProposalItemsInfo.ICShipmentProposalItemProductShippedQty;
                        objShipmentProposalItemsController.UpdateObject(objShipmentProposalItemsInfo);
                    }
                    decimal shippedQty = 0;
                    if (saleOrderItem != null)
                    {
                        shippedQty = Math.Min(invoiceItemQty, saleOrderItem.ARSaleOrderItemRemainedQty);
                    }
                    else
                    {
                        saleOrderItem = allSaleOrderItems.Where(i => i.ARSaleOrderItemID == invoiceItem.FK_ARSaleOrderItemID).FirstOrDefault();
                        shippedQty = invoiceItemQty;
                    }

                    if (saleOrderItem != null)
                    {
                        //Update new shipped quantity
                        saleOrderItem.ARSaleOrderItemShippedQty += shippedQty;
                        saleOrderItem.ARSaleOrderItemRemainedQty = saleOrderItem.ARSaleOrderItemProductQty - saleOrderItem.ARSaleOrderItemCanceledQty - saleOrderItem.ARSaleOrderItemShippedQty;
                        ////Update new proposed quantity
                        if (!saleOrderItem.IsSubItem)
                        {
                            objSaleOrderItemsController.UpdateShippedQty(saleOrderItem.ARSaleOrderItemID, saleOrderItem.ARSaleOrderItemShippedQty);
                        }
                        else
                        {
                            objSOItemComponentsController.UpdateShippedQty(saleOrderItem.ARSOItemComponentID, saleOrderItem.ARSaleOrderItemShippedQty);
                        }

                        ARSaleOrdersInfo saleOrder = saleOrders.Where(so => so.ARSaleOrderID == saleOrderItem.FK_ARSaleOrderID).FirstOrDefault();

                        invoiceItemQty -= shippedQty;
                    }
                    else
                    {
                        break;
                    }
                }

                GLHelper.PostedTransactions(this.Module.Name, invoice.ARInvoiceID, ModulePostingType.SaleOrder);
            }

            //Update
            foreach (ARInvoiceItemsInfo entItem in ComponentInvoiceItemList.BackupList)
            {
                //Update References Sale Order
                ARSaleOrdersInfo objSaleOrdersInfo = saleOrders.FirstOrDefault(s => s.ARSaleOrderID == entItem.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    objSaleOrdersInfo.ARSaleOrderInvoiceAmount -= entItem.ARInvoiceItemTotalAmount + (entItem.ARInvoiceItemTotalAmount * invoice.ARInvoiceTaxPercent / 100);
                    objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                }
            }
            //TNDLoc [ADD][27/07/2015][Issue update InvoiceAmount Sale Order],END
            //Update
            foreach (ARInvoiceItemsInfo entItem in InvoiceItemsList)
            {
                //Update References Sale Order
                ARSaleOrdersInfo objSaleOrdersInfo = saleOrders.FirstOrDefault(s => s.ARSaleOrderID == entItem.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    objSaleOrdersInfo.ARSaleOrderInvoiceAmount += entItem.ARInvoiceItemTotalAmount + (entItem.ARInvoiceItemTotalAmount * invoice.ARInvoiceTaxPercent / 100);
                    BOSApp.RoundByCurrency(objSaleOrdersInfo, objSaleOrdersInfo.FK_GECurrencyID);
                    //objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
                }
            }
            //TNDLoc [ADD][27/07/2015][Issue update InvoiceAmount Sale Order],END
            //Update the sale order's status
            foreach (ARSaleOrdersInfo saleOrder in saleOrders)
            {
                bool isRemained = false;
                foreach (ARSaleOrderItemsInfo saleOrderItem in allSaleOrderItems)
                {
                    if (saleOrderItem.FK_ARSaleOrderID == saleOrder.ARSaleOrderID &&
                        saleOrderItem.FK_ICProductID > 0 &&
                        saleOrderItem.ARSaleOrderItemRemainedQty > 0)
                    {
                        isRemained = true;
                        break;
                    }
                }

                if (!isRemained)
                {
                    saleOrder.ARSaleOrderStatus = SaleOrderStatus.Shipped.ToString();
                    saleOrder.AAUpdatedUser = BOSApp.CurrentUser;
                    saleOrder.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    objSaleOrdersController.UpdateObject(saleOrder);
                }
                else
                {
                    saleOrder.ARSaleOrderStatus = SaleOrderStatus.Incomplete.ToString();
                    saleOrder.AAUpdatedUser = BOSApp.CurrentUser;
                    saleOrder.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    objSaleOrdersController.UpdateObject(saleOrder);
                }
            }
        }

        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID, BusinessObject item)
        {
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == iICProductID);
            if (objProductsInfo != null)
            {       
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
                ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)item;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID, objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                objInvoiceItemsInfo.ICProductUnitPrice = objProductsInfo.ICProductPrice01;
                objInvoiceItemsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
                objInvoiceItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objInvoiceItemsInfo.ARInvoiceItemDeliveryDate = objInvoicesInfo.ARInvoiceDeliveryDate;
                objInvoiceItemsInfo.ARInvoiceItemProductName = objProductsInfo.ICProductName;
                objInvoiceItemsInfo.ARInvoiceItemProductName2 = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
            }
        }

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of proposal
            ((ARInvoicesInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price basing on price level
            foreach (ARInvoiceItemsInfo entItem in InvoiceItemsList)
                SetProductPrice(entItem, TableName.ARInvoiceItemsTableName);
            InvoiceItemsList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Update invoice total amount
        /// </summary>
        public void UpdateTotalAmount()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceNetAmount = 0;
            objInvoicesInfo.ARInvoiceSubTotalAmount = 0;
            objInvoicesInfo.ARInvoiceTotalCost = 0;
            foreach (ARInvoiceItemsInfo entItem in InvoiceItemsList)
            {
                if (objInvoicesInfo.ActionNewFrom != "Manual")
                {
                    BOSApp.RoundByCurrency(entItem, objInvoicesInfo.FK_GECurrencyID);
                }
                
                objInvoicesInfo.ARInvoiceNetAmount += entItem.ARInvoiceItemNetAmount;
                objInvoicesInfo.ARInvoiceSubTotalAmount += entItem.ARInvoiceItemTotalAmount;
                // entItem.ARInvoiceItemTotalAmount = entItem.ARInvoiceItemProductUnitPrice * entItem.ARInvoiceItemProductQty;                     
            }
            foreach (ARInvoiceItemWorksInfo item in ARInvoiceItemCostList)
            {
                objInvoicesInfo.ARInvoiceTotalCost += item.ARInvoiceItemWorkTotalAmount;
            }
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceDiscountFix = objInvoicesInfo.ARInvoiceSubTotalAmount * objInvoicesInfo.ARInvoiceDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceDiscountFix", objInvoicesInfo.FK_GECurrencyID);
            decimal subTotalAmount = 0;
            foreach (ARInvoiceItemsInfo item in InvoiceItemsList)
            {
                subTotalAmount += item.ARInvoiceItemProductUnitPrice * item.ARInvoiceItemProductQty - item.ARInvoiceItemDiscountAmount;
            }
            decimal totalAmount = subTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix;
            objInvoicesInfo.ARInvoiceCommissionAmount = totalAmount * objInvoicesInfo.ARInvoiceCommissionPercent / 100;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceCommissionAmount", objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceTaxAmount = (objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix + objInvoicesInfo.ARInvoiceTotalCost) * objInvoicesInfo.ARInvoiceTaxPercent / 100;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceTaxAmount", objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceTotalAmount = objInvoicesInfo.ARInvoiceSubTotalAmount -
                                                    objInvoicesInfo.ARInvoiceDiscountFix +
                                                    objInvoicesInfo.ARInvoiceTaxAmount +
                                                    objInvoicesInfo.ARInvoiceTotalCost;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceTotalAmount", objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceDepositBalance = PaymentDetailList.Sum(p => p.ARClearingDetailAmount);
            if (objInvoicesInfo.OldObject != null)
            {
                ARInvoicesInfo oldInvoice = (ARInvoicesInfo)objInvoicesInfo.OldObject;
                objInvoicesInfo.ARInvoiceBalanceDue = oldInvoice.ARInvoiceBalanceDue +
                                                        oldInvoice.ARInvoiceDepositBalance - objInvoicesInfo.ARInvoiceDepositBalance +
                                                        objInvoicesInfo.ARInvoiceTotalAmount - oldInvoice.ARInvoiceTotalAmount;
            }
            else
            {
                objInvoicesInfo.ARInvoiceBalanceDue = objInvoicesInfo.ARInvoiceTotalAmount - objInvoicesInfo.ARInvoiceDepositBalance;
            }
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        #region Generate Entities

        public void GenerateEntitiesFromSaleOrders(List<ARSaleOrderItemsInfo> saleOrderItemsList)
        {
            saleOrderItemsList.ForEach(o =>
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                BOSUtil.CopyObject(o, objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ICProductID = o.FK_ICProductID;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = null;
                if (objInvoiceItemsInfo.FK_ICProductID > 0)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        objInvoiceItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                        objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                        objInvoiceItemsInfo.ARInvoiceItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                        objInvoiceItemsInfo.ARInvoiceItemProductBarCode = objProductsInfo.ICProductBarCode;
                    }
                }
                SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                objInvoiceItemsInfo.ARSaleOrderNo = o.ARSaleOrderNo;
                objInvoiceItemsInfo.ARDeliveryPlanNo = o.ARDeliveryPlanNo;
                objInvoiceItemsInfo.FK_ARSaleOrderItemID = o.ARSaleOrderItemID;
                objInvoiceItemsInfo.FK_ICSectionProductID = o.FK_ICSectionProductID;
                objInvoiceItemsInfo.FK_ACCostCenterID = o.FK_ACCostCenterID;
                objInvoiceItemsInfo.ARInvoiceItemProductQty = o.ARSaleOrderItemProductQty - o.ARSaleOrderItemCanceledQty;
                objInvoiceItemsInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = o.ARSaleOrderItemProductUnitPrice - o.ARSaleOrderItemProductUnitPrice * o.ARSaleOrderItemProductDiscount / 100;
                objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = o.ARSaleOrderItemProductTaxPercent;
                objInvoiceItemsInfo.ARInvoiceItemTaxAmount = o.ARSaleOrderItemTaxAmount;
                objInvoiceItemsInfo.ARInvoiceItemProductDiscount = 0;
                objInvoiceItemsInfo.ARInvoiceItemDiscountAmount = 0;
                objInvoiceItemsInfo.FK_ARDeliveryPlanItemID = o.FK_ARDeliveryPlanItemID;
                objInvoiceItemsInfo.FK_ARProposalTemplateItemID = o.FK_ARProposalTemplateItemID;
                objInvoiceItemsInfo.ARProposalTemplateItemProductName = o.ARProposalTemplateItemProductName;
                objInvoiceItemsInfo.FK_ICMeasureUnitID = o.FK_ICMeasureUnitID;
                objInvoiceItemsInfo.FK_ICStockID = o.FK_ICStockID;
                objInvoiceItemsInfo.ARInvoiceItemProductSerialNo = o.ARSaleOrderItemProductSerialNo;
                objInvoiceItemsInfo.ARInvoiceItemLotNo = o.ARSaleOrderItemLotNo;
                objInvoiceItemsInfo.ARInvoiceItemProductFactor = o.ARSaleOrderItemProductFactor;
                objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty = o.ARSaleOrderItemProductExchangeQty;
                objInvoiceItemsInfo.FK_ICProductAttributeTTMTID = o.FK_ICProductAttributeTTMTID;
                objInvoiceItemsInfo.ARInvoiceItemPONo = o.ARSaleOrderItemPONo;

                ARInvoicesInfo mainObject = (ARInvoicesInfo)MainObject;
                decimal unitCost = AccountHelper.GetProductUnitCost(objInvoiceItemsInfo.FK_ICStockID, objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo.ARInvoiceItemProductSerialNo, mainObject.ARInvoiceDate);
                objInvoiceItemsInfo.ARInvoiceItemProductUnitCost = unitCost * objInvoiceItemsInfo.ARInvoiceItemProductFactor / mainObject.ARInvoiceExchangeRate;
                SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);

                //objInvoiceItemsInfo.ARInvoiceItemProductQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                if (o.FK_ICMeasureUnitBeforeChangeID > 0 && o.FK_ICMeasureUnitBeforeChangeID != o.FK_ICMeasureUnitID)
                {
                    decimal factor = GeneralHelper.CalculateProductMeasureUnitFactor(o.FK_ICProductID, o.FK_ICMeasureUnitBeforeChangeID, o.FK_ICMeasureUnitID);
                    objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = o.ARSaleOrderItemProductUnitPrice / factor;
                    objInvoiceItemsInfo.ARInvoiceItemNetAmount = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                    objInvoiceItemsInfo.ARInvoiceItemDiscountAmount = objInvoiceItemsInfo.ARInvoiceItemNetAmount * objInvoiceItemsInfo.ARInvoiceItemProductDiscount / 100;
                    objInvoiceItemsInfo.ARInvoiceItemTaxAmount = (objInvoiceItemsInfo.ARInvoiceItemNetAmount - objInvoiceItemsInfo.ARInvoiceItemDiscountAmount) * objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent / 100;
                    objInvoiceItemsInfo.ARInvoiceItemTotalAmount = objInvoiceItemsInfo.ARInvoiceItemNetAmount - objInvoiceItemsInfo.ARInvoiceItemDiscountAmount + objInvoiceItemsInfo.ARInvoiceItemTaxAmount;
                }

                AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
                objAccountDebitandCredit = GeneralAcountForInvoiceItem(objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ACAccountRevenueID = objAccountDebitandCredit.AccountCredit;

                InvoiceItemsList.Add(objInvoiceItemsInfo);
            });
            int index = 1;
            InvoiceItemsList.OrderBy(o => o.ARInvoiceItemSortOrder).ToList().ForEach(o => o.ARInvoiceItemSortOrder = index++);
        }

        public void GenerateEntitiesFromShipmentProposal(ICShipmentProposalsInfo objTemplateInfo, IList<ICShipmentProposalItemsInfo> selectedList)
        {
            //Generate invoice            
            GenerateInvoiceFromShipmentProposal(objTemplateInfo);
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceDepositBalance = 0;
            objInvoicesInfo.ARInvoiceOwingExchangeAmount = 0;
            objInvoicesInfo.ARInvoiceComment = string.Empty;
            objInvoicesInfo.ARInvoiceInternalComment = string.Empty;
            objInvoicesInfo.ARInvoiceReference = objTemplateInfo.ICShipmentProposalNo;
            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objTemplateInfo.ICShipmentProposalReference);
            if (objSaleOrdersInfo != null)
            {
                objInvoicesInfo.ARInvoiceExchangeRate = objSaleOrdersInfo.ARSaleOrderExchangeRate;
                objInvoicesInfo.FK_ARSellerID = objSaleOrdersInfo.FK_ARSellerID;
                objInvoicesInfo.ARInvoiceTaxPercent = objSaleOrdersInfo.ARSaleOrderTaxPercent;
                objInvoicesInfo.ARInvoiceDiscountPerCent = objSaleOrdersInfo.ARSaleOrderDiscountPerCent;
            }

            //Generate invoice items
            foreach (ICShipmentProposalItemsInfo objShipmentProposalItemsInfo in selectedList)
            {
                GenerateInvoiceItemsFromShipmentProposalItems(objShipmentProposalItemsInfo);
            }

            UpdateTotalAmount();
        }

        private void GenerateInvoiceFromShipmentProposal(ICShipmentProposalsInfo objShipmentProposalsInfo)
        {
            //Copy invoice
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARInvoicesInfo oldInvoice = (ARInvoicesInfo)MainObject.Clone();
            BOSUtil.CopyObject(objShipmentProposalsInfo, objInvoicesInfo);
            objInvoicesInfo.ARInvoiceSOType = objShipmentProposalsInfo.ICShipmentProposalType;
            //Recalculate deposit balance of the invoice
            //ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            //decimal totalInvoiceDeposit = objSaleOrdersController.GetTotalInvoiceDeposit(objSaleOrdersInfo.ARSaleOrderID);
            //decimal owingExchangeAmount = objSaleOrdersController.GetTotalDeposit(objSaleOrdersInfo.ARSaleOrderID, PaymentMethod.OwingExchange.ToString());
            //owingExchangeAmount = Math.Max(owingExchangeAmount - totalInvoiceDeposit, 0);
            //objInvoicesInfo.ARInvoiceDepositBalance = objSaleOrdersInfo.ARSaleOrderDepositBalance - totalInvoiceDeposit;
            //objInvoicesInfo.ARInvoiceOwingExchangeAmount = Math.Min(objSaleOrdersInfo.ARSaleOrderDepositBalance - totalInvoiceDeposit, owingExchangeAmount);

            //Restore some its own properties
            objInvoicesInfo.ARInvoiceNo = oldInvoice.ARInvoiceNo;
            objInvoicesInfo.ARInvoiceName = oldInvoice.ARInvoiceName;
            objInvoicesInfo.ARInvoiceDesc = oldInvoice.ARInvoiceDesc;
            objInvoicesInfo.ARInvoiceTypeCombo = oldInvoice.ARInvoiceTypeCombo;
            objInvoicesInfo.ARInvoiceStatus = oldInvoice.ARInvoiceStatus;
            objInvoicesInfo.ARInvoiceDate = oldInvoice.ARInvoiceDate;
            objInvoicesInfo.ARInvoiceValidateDate = oldInvoice.ARInvoiceValidateDate;
            objInvoicesInfo.ARInvoiceReference = objShipmentProposalsInfo.ICShipmentProposalNo;
            objInvoicesInfo.FK_MMBatchProductID = objShipmentProposalsInfo.FK_MMBatchProductID;
            //objInvoicesInfo.FK_HREmployeeID = oldInvoice.FK_HREmployeeID;
            objInvoicesInfo.ARInvoiceEmployeePicture = oldInvoice.ARInvoiceEmployeePicture;
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        private void GenerateInvoiceItemsFromShipmentProposalItems(ICShipmentProposalItemsInfo objShipmentProposalItemsInfo)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
            BOSUtil.CopyObject(objShipmentProposalItemsInfo, objInvoiceItemsInfo);
            objInvoiceItemsInfo.FK_ICProductID = objShipmentProposalItemsInfo.FK_ICProductID;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = null;
            if (objInvoiceItemsInfo.FK_ICProductID > 0)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objInvoiceItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                    objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                }
            }
            objInvoiceItemsInfo.FK_ARSaleOrderID = objShipmentProposalItemsInfo.FK_ARSaleOrderID;
            objInvoiceItemsInfo.FK_ARSaleOrderItemID = objShipmentProposalItemsInfo.FK_ARSaleOrderItemID;
            objInvoiceItemsInfo.FK_ICShipmentProposalItemID = objShipmentProposalItemsInfo.ICShipmentProposalItemID;
            objInvoiceItemsInfo.FK_ICShipmentProposalID = objShipmentProposalItemsInfo.FK_ICShipmentProposalID;
            objInvoiceItemsInfo.ARInvoiceItemProductQty = objShipmentProposalItemsInfo.ICShipmentProposalItemRemainQty;
            objInvoiceItemsInfo.FK_ICProductAttributeWoodTypeID = objShipmentProposalItemsInfo.FK_ICProductAttributeID;
            objInvoiceItemsInfo.ARInvoiceItemDeliveryDate = objInvoicesInfo.ARInvoiceDeliveryDate;
            objInvoiceItemsInfo.ARInvoiceItemColorText = objShipmentProposalItemsInfo.ICShipmentProposalItemColorText;
            objInvoiceItemsInfo.ARInvoiceItemHTText = objShipmentProposalItemsInfo.ICShipmentProposalItemHTText;
            objInvoiceItemsInfo.ARInvoiceItemPONo = objShipmentProposalItemsInfo.ICShipmentProposalItemPONo;
            objInvoiceItemsInfo.FK_ICProductSerieID = objShipmentProposalItemsInfo.FK_ICProductSerieID;
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(objShipmentProposalItemsInfo.FK_ARSaleOrderItemID);
            if (objSaleOrderItemsInfo != null)
            {
                objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice;
                objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent;
                objInvoiceItemsInfo.ARInvoiceItemTaxAmount = objSaleOrderItemsInfo.ARSaleOrderItemTaxAmount;
                objInvoiceItemsInfo.ARInvoiceItemProductDiscount = objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount;
                objInvoiceItemsInfo.ARInvoiceItemDiscountAmount = objSaleOrderItemsInfo.ARSaleOrderItemDiscountAmount;
                //TNDLoc [ADD][16/12/2015][Extra values from SaleOrder],START
                objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent;

                objInvoiceItemsInfo.ARInvoiceItemProductDiscount = objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount;
                SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);
                //TNDLoc [ADD][16/12/2015][Extra values from SaleOrder],END
            }

            objInvoiceItemsInfo.ARInvoiceItemProductQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
            SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo);

            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            objAccountDebitandCredit = GeneralAcountForInvoiceItem(objInvoiceItemsInfo);
            objInvoiceItemsInfo.FK_ACAccountRevenueID = objAccountDebitandCredit.AccountCredit;
            InvoiceItemsList.Add(objInvoiceItemsInfo);
        }

        /// <summary>
        /// Generate invoice and it's items from a given sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        public void GenerateEntitiesFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            //Generate invoice            
            GenerateInvoiceFromSaleOrder(objSaleOrdersInfo);

            //Generate invoice items
            GenerateInvoiceItemsFromSaleOrder(objSaleOrdersInfo);

            UpdateTotalAmount();
        }

        /// <summary>
        /// Generate an invoice from a given sale order and set to main object
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        private void GenerateInvoiceFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            //Copy invoice
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARInvoicesInfo oldInvoice = (ARInvoicesInfo)MainObject.Clone();
            BOSUtil.CopyObject(objSaleOrdersInfo, objInvoicesInfo);

            //Recalculate deposit balance of the invoice
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            decimal totalInvoiceDeposit = objSaleOrdersController.GetTotalInvoiceDeposit(objSaleOrdersInfo.ARSaleOrderID);
            decimal owingExchangeAmount = objSaleOrdersController.GetTotalDeposit(objSaleOrdersInfo.ARSaleOrderID, PaymentMethod.OwingExchange.ToString());
            owingExchangeAmount = Math.Max(owingExchangeAmount - totalInvoiceDeposit, 0);
            objInvoicesInfo.ARInvoiceDepositBalance = objSaleOrdersInfo.ARSaleOrderDepositBalance - totalInvoiceDeposit;
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceOwingExchangeAmount = Math.Min(objSaleOrdersInfo.ARSaleOrderDepositBalance - totalInvoiceDeposit, owingExchangeAmount);
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceSOType = objSaleOrdersInfo.ARSaleOrderType;
            //Restore some its own properties
            objInvoicesInfo.ARInvoiceNo = oldInvoice.ARInvoiceNo;
            objInvoicesInfo.ARInvoiceName = oldInvoice.ARInvoiceName;
            objInvoicesInfo.ARInvoiceDesc = oldInvoice.ARInvoiceDesc;
            objInvoicesInfo.ARInvoiceTypeCombo = oldInvoice.ARInvoiceTypeCombo;
            objInvoicesInfo.ARInvoiceStatus = oldInvoice.ARInvoiceStatus;
            objInvoicesInfo.ARInvoiceDate = oldInvoice.ARInvoiceDate;
            objInvoicesInfo.ARInvoiceValidateDate = oldInvoice.ARInvoiceValidateDate;
            objInvoicesInfo.ARInvoiceReference = objSaleOrdersInfo.ARSaleOrderNo;
            //objInvoicesInfo.FK_HREmployeeID = oldInvoice.FK_HREmployeeID;
            objInvoicesInfo.ARInvoiceEmployeePicture = oldInvoice.ARInvoiceEmployeePicture;
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        /// <summary>
        /// Generate invoice items from a given sale order and add them to the current invoice item list        
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        private void GenerateInvoiceItemsFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            //Copy item list
            BOSList<ARSaleOrderItemsInfo> saleOrderItems = new BOSList<ARSaleOrderItemsInfo>();
            saleOrderItems.InitBOSList(null, TableName.ARSaleOrdersTableName, TableName.ARSaleOrderItemsTableName, BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            ARSaleOrderItemsController objPurchaseOrderItemsController = new ARSaleOrderItemsController();

            // DataSet ds = objPurchaseOrderItemsController.GetAllDataBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
            List<ARSaleOrderItemsInfo> saleOrderItem = objPurchaseOrderItemsController.GetItemForInvoice(objSaleOrdersInfo.ARSaleOrderID);

            saleOrderItems.Invalidate(saleOrderItem);

            ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in saleOrderItems)
            {
                //objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty - objSaleOrderItemsInfo.ARSaleOrderItemShippedQty - objSaleOrderItemsInfo.ARSaleOrderItemCanceledQty;
                if (objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty > 0)
                {
                    ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                    BOSUtil.CopyObject(objSaleOrderItemsInfo, objInvoiceItemsInfo);
                    objInvoiceItemsInfo.FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID;
                    if (objInvoiceItemsInfo.FK_ICProductID > 0)
                    {
                        ICProductsController objProductsController = new ICProductsController();
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            objInvoiceItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                            objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                        }
                    }
                    objInvoiceItemsInfo.ARInvoiceItemHeight = objSaleOrdersInfo.ARSaleOrderItemHeight;
                    objInvoiceItemsInfo.ARInvoiceItemWidth = objSaleOrderItemsInfo.ARSaleOrderItemWidth;
                    objInvoiceItemsInfo.ARInvoiceItemLength = objSaleOrderItemsInfo.ARSaleOrderItemLength;

                    objInvoiceItemsInfo.FK_ARSaleOrderID = objSaleOrdersInfo.ARSaleOrderID;
                    objInvoiceItemsInfo.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                    objInvoiceItemsInfo.ARInvoiceItemProductQty = objSaleOrderItemsInfo.ARSaleOrderItemRemainedQty;
                    objInvoiceItemsInfo.ARInvoiceItemDeliveryDate = objInvoicesInfo.ARInvoiceDeliveryDate;
                    objInvoiceItemsInfo.FK_ICProductSerieID = objSaleOrderItemsInfo.FK_ICProductSerieID;

                    SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);
                    objInvoiceItemsInfo.ARInvoiceItemColorText = objSaleOrderItemsInfo.ARSaleOrderItemColorText;
                    objInvoiceItemsInfo.ARInvoiceItemHTText = objSaleOrderItemsInfo.ARSaleOrderItemHTText;
                    objInvoiceItemsInfo.ARInvoiceItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo;
                    objInvoiceItemsInfo.FK_ACCostCenterID = objSaleOrderItemsInfo.FK_ACCostCenterID;
                    objInvoiceItemsInfo.FK_ICSectionProductID = objSaleOrderItemsInfo.FK_ICSectionProductID;
                    objInvoiceItemsInfo.InvoiceItemPackageList = new BOSList<ARInvoiceItemPackagesInfo>();
                    objInvoiceItemsInfo.InvoiceItemPackageList.InitBOSList(
                                                        this,
                                                        TableName.ARInvoiceItemsTableName,
                                                        TableName.ARInvoiceItemPackagesTableName,
                                                        BOSList<ARInvoiceItemPackagesInfo>.cstRelationForeign);
                    objInvoiceItemsInfo.InvoiceItemPackageList.ItemTableForeignKey = "FK_ARInvoiceItemID";

                    //Generate invoice item component from sale order item
                    objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>();
                    objSaleOrderItemsInfo.ARSOItemComponentList.InitBOSList(null,
                                                            TableName.ARSaleOrderItemsTableName,
                                                            TableName.ARSOItemComponentsTableName,
                                                            BOSList<ARSOItemComponentsInfo>.cstRelationForeign);
                    ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                    List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                    objSaleOrderItemsInfo.ARSOItemComponentList.Invalidate(components);

                    if (objSaleOrderItemsInfo.ARSOItemComponentList.Count > 0)
                    {
                        objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>();
                        objInvoiceItemsInfo.InvoiceItemComponentList.InitBOSList(this,
                                                            TableName.ARInvoiceItemsTableName,
                                                            TableName.ARInvoiceItemComponentsTableName,
                                                            BOSList<ARInvoiceItemComponentsInfo>.cstRelationForeign);
                        objInvoiceItemsInfo.InvoiceItemComponentList.ItemTableForeignKey = "FK_ARInvoiceItemID";
                        foreach (ARSOItemComponentsInfo objSOItemComponentsInfo in objSaleOrderItemsInfo.ARSOItemComponentList)
                        {
                            ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo = new ARInvoiceItemComponentsInfo();
                            BOSUtil.CopyObject(objSOItemComponentsInfo, objInvoiceItemComponentsInfo);
                            objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = objSOItemComponentsInfo.ARSOItemComponentQty - objSOItemComponentsInfo.ARSOItemComponentShippedQty;
                            objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty = Math.Round(objInvoiceItemComponentsInfo.ARInvoiceItemComponentQty, 3, MidpointRounding.AwayFromZero);
                            objInvoiceItemsInfo.InvoiceItemComponentList.Add(objInvoiceItemComponentsInfo);
                        }
                    }
                    objInvoiceItemsInfo.ARInvoiceItemProductQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                    InvoiceItemsList.Add(objInvoiceItemsInfo);
                }
            }
        }
        #endregion

        public override void SetDefaultValuesFromObject(ACObjectsInfo objectsInfo)
        {
            base.SetDefaultValuesFromObject(objectsInfo);

            if(objectsInfo.ACObjectType == ObjectType.Customer.ToString())
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)(new ARCustomersController()).GetObjectByID(objectsInfo.ACObjectID);
                objInvoicesInfo.ARInvoiceValidateDate = objInvoicesInfo.ARInvoiceDate.AddDays(objCustomersInfo.ARCustomerDueDays);
            }
        }

        public void UpdateBatchProductDeliveryStatus(ARInvoicesInfo objInvoicesInfo)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            if (objInvoicesInfo.FK_MMBatchProductID > 0)
            {
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objInvoicesInfo.FK_MMBatchProductID);
                List<ARSaleOrderItemsInfo> saleorderitemList = new List<ARSaleOrderItemsInfo>();
                decimal saleorderitemQty = 0;
                decimal saleorderitemShipmentQty = 0;
                decimal saleorderitemCancelQty = 0;
                if (objBatchProductsInfo.FK_ARSaleOrderID > 0)
                {
                    ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                    saleorderitemList = objSaleOrderItemsController.GetAllitemBySaleOrderID(objBatchProductsInfo.FK_ARSaleOrderID);
                }
                saleorderitemQty = saleorderitemList.Sum(s => s.ARSaleOrderItemProductQty);
                saleorderitemShipmentQty = saleorderitemList.Sum(s => s.ARSaleOrderItemShippedQty);
                saleorderitemCancelQty = saleorderitemList.Sum(s => s.ARSaleOrderItemCanceledQty);
                if ((saleorderitemQty - saleorderitemCancelQty - saleorderitemShipmentQty) == 0)
                {
                    objBatchProductsInfo.MMBatchProductDeliveryStatus = BatchProductDeliveryStatus.Completed.ToString();
                }
                else
                {
                    objBatchProductsInfo.MMBatchProductDeliveryStatus = BatchProductDeliveryStatus.InComplete.ToString();
                }
                objBatchProductsController.UpdateObject(objBatchProductsInfo);
            }
        }

        public override bool CompleteTransaction()
        {
            //Update the invoice's status
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();

            objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.Complete.ToString();
            UpdateMainObject();

            //Set cost of goods sold for invoice items
            if (BOSApp.CurrentCompanyInfo.CSCostMethod == AccCostMethod.SpecificIdentification.ToString())
            {
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();

                foreach (ARInvoiceItemsInfo item in InvoiceItemsList)
                {
                    objAccountDebitandCredit = GeneralAcountForShipmentItem(item);
                    item.FK_ACAccountID = objAccountDebitandCredit.AccountCredit;
                    objInvoiceItemsController.UpdateObject(item);
                }
            }

            return true;
        }

        public void InvalidateItemComponents()
        {
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetComponentItemsByInvoiceID(objInvoicesInfo.ARInvoiceID);
            ComponentInvoiceItemList.Clear();
            ComponentInvoiceItemList.OriginalList.Clear();
            foreach (ARInvoiceItemsInfo item in items)
            {
                ComponentInvoiceItemList.Add((ARInvoiceItemsInfo)item.Clone());
            }

            foreach (ARInvoiceItemsInfo item in ComponentInvoiceItemList)
            {
                ComponentInvoiceItemList.OriginalList.Add((ARInvoiceItemsInfo)item.Clone());
            }
        }

        public AccountDebitandCredit GeneralAcountForShipmentItem(ARInvoiceItemsInfo item)
        {
            //int account = 0;
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            bool isIndoor = false;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            if (objProductsInfo != null)
            {
                #region Thành ph?m
                if (objProductsInfo.ICProductType == ProductType.Product.ToString()) // N?u là thành ph?m thì ki?m tra Gia Công hay S?n xu?t
                {
                    //Xác d?nh là Indoor hay OutDoor
                    if (objProductsController.GetBoolProductGroupsIsIndoorOrOurdoor(objProductsInfo.FK_ICProductGroupID))
                    {
                        //Indoor
                        isIndoor = true;
                    }
                    else
                    {
                        //Outdoor
                        isIndoor = false;
                    }
                    // Xác d?nh Thành ph?m t? s?n xu?t hay gia công
                    if (objReceiptItemsController.IsProductionOrOurSoucingReceipt(item.FK_ICProductID, item.FK_ICProductSerieID))
                    {
                        //Là s?n xu?t
                        if (isIndoor)
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc15572);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc63211);
                        }
                        else
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc15573);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc63212);
                        }

                    }
                    else
                    {
                        //Là gia công
                        if (isIndoor)
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1557_1);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6324);
                        }
                        else
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1557_2);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6324);
                        }
                    }

                }
                #endregion
                #region HW - Son - PLDG - CCDC - SemiProduct
                else
                //if (objProductsInfo.ICProductType == ProductType.Hardware.ToString()
                //|| objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString()
                //|| objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString()
                //|| objProductsInfo.ICProductType == ProductType.Equipment.ToString()
                //|| objProductsInfo.ICProductType == ProductType.SemiProduct.ToString())
                {
                    objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(item.FK_ICStockID);
                    if (objStocksInfo != null)
                    {
                        objAccountDebitandCredit = GeneralAccountByStock(objStocksInfo.ICStockNo);
                    }
                }
                #endregion
            }
            return objAccountDebitandCredit;

        }
        public int GetAccoutByNo(string accountNo)
        {
            int account = 0;
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            if (objAccountsInfo != null)
                account = objAccountsInfo.ACAccountID;
            return account;
        }
        public AccountDebitandCredit GeneralAccountByStock(string StockNo)
        {
            //int accountCredit = 0;
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            if (StockNo.Equals(StockNoHardCode.HW))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1527);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6322);
            }
            else if (StockNo.Equals(StockNoHardCode.Son) || StockNo.Equals(StockNoHardCode.NhienLieu))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1526);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6322);
            }
            else if (StockNo.Equals(StockNoHardCode.PLDG))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1528);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6322);
            }
            else if (StockNo.Equals(StockNoHardCode.CCDCBT))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1531);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6323);
            }
            else if (StockNo.Equals(StockNoHardCode.CCDCDL))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1532);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6323);
            }
            else if (StockNo.Equals(StockNoHardCode.CCDCSX))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1534);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6323);
            }
            else if (StockNo.Equals(StockNoHardCode.VPP))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1535);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6323);
            }
            else if (StockNo.Equals(StockNoHardCode.MMTB) || (StockNo.Equals(StockNoHardCode.MMTBCD) || (StockNo.Equals(StockNoHardCode.MMTBCT)) || (StockNo.Equals(StockNoHardCode.MMTBVP))))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1536);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6323);
            }
            else if (StockNo.Equals(StockNoHardCode.KhoPhoiXuong1) || StockNo.Equals(StockNoHardCode.KhoPhoiXuong2))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1551);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc62114);
            }
            else if (StockNo.Equals(StockNoHardCode.KhoSoCheXuong1) || StockNo.Equals(StockNoHardCode.KhoSoCheXuong2))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1552);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc62115);
            }
            else if (StockNo.Equals(StockNoHardCode.KhoTinhCheXuong1) || StockNo.Equals(StockNoHardCode.KhoTinhCheXuong2))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1553);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc62116);
            }
            else if (StockNo.Equals(StockNoHardCode.KhoLapRapXuong1) || StockNo.Equals(StockNoHardCode.KhoLapRapXuong2))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1554);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc62117);
            }
            else if (StockNo.Equals(StockNoHardCode.KhoSon))
            {
                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1555);
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc62118);
            }
            else
            {
                ICStocksController stockController = new ICStocksController();
                ICStocksInfo stock = stockController.GetObjectByNo(StockNo) as ICStocksInfo;
                if (stock != null)
                {
                    objAccountDebitandCredit.AccountCredit = GetAccountByStock(stock.ICStockID, 0);
                }
                objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6322);
            }


            return objAccountDebitandCredit;

        }

        public AccountDebitandCredit GeneralAcountForInvoiceItem(ARInvoiceItemsInfo item)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;

            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);

            if (objProductsInfo != null)
                objAccountDebitandCredit.AccountCredit = objProductsInfo.FK_ACAccountRevenueID;

            #region LuuNH delete
            ////int account = 0;
            //AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            //ARSaleOrdersInfo SaleOrdersInfo = new ARSaleOrdersInfo();
            //ARSaleOrdersController obj = new ARSaleOrdersController();
            //bool isIndoor = false;
            //bool isInternational = false;
            //ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            //ICProductsInfo objProductsInfo = new ICProductsInfo();
            //ICProductsController objProductsController = new ICProductsController();
            //objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            //ICStocksController objStocksController = new ICStocksController();
            //ICStocksInfo objStocksInfo = new ICStocksInfo();
            //ACAssetsController objAssetsController = new ACAssetsController();
            //ACAssetsInfo objAssetsInfo = new ACAssetsInfo();
            //objAssetsInfo = (ACAssetsInfo)objAssetsController.GetACAssetByProductID(item.FK_ICProductID);
            //if (objProductsInfo != null)
            //{
            //    //Xác d?nh PI là n?i d?a hay xu?t kh?u
            //    if (obj.IsInternational(item.FK_ARSaleOrderItemID))
            //    {
            //        isInternational = true;
            //    }
            //    else
            //    {
            //        isInternational = false;
            //    }
            //    #region Thành ph?m
            //    if (objProductsInfo.ICProductType == ProductType.Product.ToString()) // N?u là thành ph?m thì ki?m tra Gia Công hay S?n xu?t
            //    {
            //        //Xác d?nh là Indoor hay OutDoor
            //        if (objProductsController.GetBoolProductGroupsIsIndoorOrOurdoor(objProductsInfo.FK_ICProductGroupID))
            //        {
            //            //Indoor
            //            isIndoor = true;
            //        }
            //        else
            //        {
            //            //Outdoor
            //            isIndoor = false;
            //        }


            //        // Xác d?nh Thành ph?m t? s?n xu?t hay gia công
            //        if (objReceiptItemsController.IsProductionOrOurSoucingReceipt(item.FK_ICProductID, item.FK_ICProductSerieID))
            //        {
            //            //Là s?n xu?t
            //            if (isIndoor)
            //            {


            //                if (!isInternational)
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //                    objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5111_1);
            //                }
            //                else
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //                    objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5112_1);
            //                }

            //            }
            //            else
            //            {

            //                if (!isInternational)
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //                    objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5111_2);
            //                }
            //                else
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //                    objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5112_2);
            //                }
            //            }

            //        }
            //        else
            //        {
            //            //Là gia công
            //            if (isIndoor)
            //            {
            //                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5117_1);
            //                if (!isInternational)
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //                }
            //                else
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //                }
            //            }
            //            else
            //            {
            //                objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5117_2);

            //                if (!isInternational)
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //                }
            //                else
            //                {
            //                    objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //                }
            //            }
            //        }

            //    }
            //    else if (objProductsInfo.ICProductType == ProductType.Equipment.ToString() || objAssetsInfo != null)
            //    {
            //        objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc711);
            //        if (!isInternational)
            //        {
            //            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //        }
            //        else
            //        {
            //            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //        }
            //    }
            //    else if (objProductsInfo.ICProductType == ProductType.SemiProduct.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Detail.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Hardware.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.MMTB.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Ingredient.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.VVP.ToString() ||
            //             objProductsInfo.ICProductType == ProductType.Verneer.ToString()
            //            )
            //    {
            //        objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc5116);
            //        if (!isInternational)
            //        {
            //            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1312);
            //        }
            //        else
            //        {
            //            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc1313);
            //        }
            //    }
            //    #endregion

            //}
            #endregion
            return objAccountDebitandCredit;

        }

        public AccountDebitandCredit GeneralAcountForShipmentItem(int stockID, int productID, int productSerieID)
        {
            //int account = 0;
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
            bool isIndoor = false;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = new ICStocksInfo();
            if (objProductsInfo != null)
            {
                #region Thành ph?m
                if (objProductsInfo.ICProductType == ProductType.Product.ToString()) // N?u là thành ph?m thì ki?m tra Gia Công hay S?n xu?t
                {
                    //Xác d?nh là Indoor hay OutDoor
                    if (objProductsController.GetBoolProductGroupsIsIndoorOrOurdoor(objProductsInfo.FK_ICProductGroupID))
                    {
                        //Indoor
                        isIndoor = true;
                    }
                    else
                    {
                        //Outdoor
                        isIndoor = false;
                    }
                    // Xác d?nh Thành ph?m t? s?n xu?t hay gia công
                    if (objReceiptItemsController.IsProductionOrOurSoucingReceipt(productID, productSerieID))
                    {
                        //Là s?n xu?t
                        if (isIndoor)
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc15572);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc63211);
                        }
                        else
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc15573);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc63212);
                        }

                    }
                    else
                    {
                        //Là gia công
                        if (isIndoor)
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1557_1);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6324);
                        }
                        else
                        {
                            objAccountDebitandCredit.AccountCredit = GetAccoutByNo(AccAccount.Acc1557_2);
                            objAccountDebitandCredit.AccountDebit = GetAccoutByNo(AccAccount.Acc6324);
                        }
                    }

                }
                #endregion
                #region HW - Son - PLDG - CCDC - SemiProduct
                else
                //if (objProductsInfo.ICProductType == ProductType.Hardware.ToString()
                //|| objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString()
                //|| objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString()
                //|| objProductsInfo.ICProductType == ProductType.Equipment.ToString()
                //|| objProductsInfo.ICProductType == ProductType.SemiProduct.ToString())
                {
                    objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(stockID);
                    if (objStocksInfo != null)
                    {
                        objAccountDebitandCredit = GeneralAccountByStock(objStocksInfo.ICStockNo);
                    }
                }
                #endregion
            }
            return objAccountDebitandCredit;

        }

        public void GenerateEntitiesFromShipmentSaleOrder(List<ICShipmentItemsInfo> shipmentItems)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
            ARInvoiceItemsInfo validateInvoiceItem = new ARInvoiceItemsInfo();
            ARSaleOrderItemsInfo objSaleOrderItemsInfo = new ARSaleOrderItemsInfo();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsForViewInfo objProductsInfo = new ICProductsForViewInfo();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();

            shipmentItems.ForEach(o =>
                {
                    objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                    BOSUtil.CopyObject(o, objInvoiceItemsInfo);
                    objInvoiceItemsInfo.FK_ICProductID = o.FK_ICProductID;
                    
                    if (objInvoiceItemsInfo.FK_ICProductID > 0)
                    {
                        objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == objInvoiceItemsInfo.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            objInvoiceItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                            objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                            objInvoiceItemsInfo.ARInvoiceItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                            objInvoiceItemsInfo.ARInvoiceItemProductBarCode = objProductsInfo.ICProductBarCode;
                            objInvoiceItemsInfo.ARInvoiceItemProductName = objProductsInfo.ICProductName;
                            objInvoiceItemsInfo.ARInvoiceItemProductName2 = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                        }
                    }
                    SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo);
                    objShipmentItemsInfo = objShipmentItemsController.GetShipmentItemAcceptanceProductQty(o.Id);
                    objInvoiceItemsInfo.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                    objInvoiceItemsInfo.FK_ARSaleOrderItemID = o.FK_ARSaleOrderItemID;
                    objInvoiceItemsInfo.FK_ICShipmentItemID = o.Id;
                    objInvoiceItemsInfo.FK_ICShipmentID = o.FK_ICShipmentID;
                    objInvoiceItemsInfo.FK_ICSectionProductID = o.FK_ICSectionProductID;
                    objInvoiceItemsInfo.FK_ACCostCenterID = o.FK_ACCostCenterID;
                    objInvoiceItemsInfo.ARInvoiceItemProductQty = o.ICShipmentItemProductQty - o.ICShipmentItemRemaindProductQty;
                    objInvoiceItemsInfo.FK_ICMeasureUnitID = o.FK_ICMeasureUnitID;
                    objInvoiceItemsInfo.ARInvoiceItemProductFactor = o.ICShipmentItemProductFactor;
                    
                    if (objShipmentItemsInfo != null)
                    {
                        objInvoiceItemsInfo.ARInvoiceItemProductQty = objShipmentItemsInfo.ICShipmentItemAcceptanceProductQty;
                        objInvoiceItemsInfo.ARInvoiceItemAcceptanceProductQty = objShipmentItemsInfo.ICShipmentItemAcceptanceProductQty;
                    }
                    objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty * objInvoiceItemsInfo.ARInvoiceItemProductFactor, 6);
                    objInvoiceItemsInfo.ARInvoiceItemDeliveryDate = objInvoicesInfo.ARInvoiceDeliveryDate;
                    objInvoiceItemsInfo.FK_ICStockID = o.FK_ICStockID;
                    objInvoiceItemsInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                    objInvoiceItemsInfo.ARInvoiceItemProductSerialNo = o.ICShipmentItemProductSerialNo;
                    objInvoiceItemsInfo.ARInvoiceItemLotNo = o.ICShipmentItemLotNo;

                    objSaleOrderItemsInfo = (ARSaleOrderItemsInfo)objSaleOrderItemsController.GetObjectByID(o.FK_ARSaleOrderItemID);
                    if (objSaleOrderItemsInfo != null)
                    {
                        objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice - objSaleOrderItemsInfo.ARSaleOrderItemProductUnitPrice * objSaleOrderItemsInfo.ARSaleOrderItemProductDiscount / 100;
                        objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent;
                        objInvoiceItemsInfo.ARInvoiceItemTaxAmount = objSaleOrderItemsInfo.ARSaleOrderItemTaxAmount;
                        objInvoiceItemsInfo.ARInvoiceItemProductDiscount = 0;
                        objInvoiceItemsInfo.ARInvoiceItemDiscountAmount = 0;
                        objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = objSaleOrderItemsInfo.ARSaleOrderItemProductTaxPercent;
                        objInvoiceItemsInfo.ARInvoiceItemPONo = objSaleOrderItemsInfo.ARSaleOrderItemPONo;
                        objInvoiceItemsInfo.ARInvoiceItemTotalAmount = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                        SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);
                    }

                    objInvoiceItemsInfo.ARInvoiceItemProductQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                    

                    objAccountDebitandCredit = GeneralAcountForInvoiceItem(objInvoiceItemsInfo);
                    objInvoiceItemsInfo.FK_ACAccountRevenueID = objAccountDebitandCredit.AccountCredit;
                    objInvoiceItemsInfo.FK_ARProposalTemplateItemID = o.FK_ARProposalTemplateItemID;
                    objInvoiceItemsInfo.ARProposalTemplateItemProductName = o.ARProposalTemplateItemProductName;
                    //InvoiceItemsList.Add(objInvoiceItemsInfo);
                    //Add ShipmentInfomation
                    objInvoiceItemsInfo.ARInvoiceItemContainerNumber = o.ICShipmentItemContainerNumber;
                    objInvoiceItemsInfo.ARInvoiceItemContainerSealNumber = o.ICShipmentItemContainerSealNumber;
                    objInvoiceItemsInfo.ARInvoiceItemTractorTrailerNumber = o.ICShipmentItemTractorTrailerNumber;
                    objInvoiceItemsInfo.ARInvoiceItemShipNumber = o.ICShipmentItemShipNumber;
                    objInvoiceItemsInfo.ARInvoiceItemETDDate = o.ICShipmentItemETDDate;
                    InvoiceItemsList.Add(objInvoiceItemsInfo);
                    //validateInvoiceItem = InvoiceItemsList.FirstOrDefault(it => it.FK_ICProductID == objInvoiceItemsInfo.FK_ICProductID
                    //                                                        && it.FK_ICStockID == objInvoiceItemsInfo.FK_ICStockID
                    //                                                        && it.FK_ARSaleOrderID == objInvoiceItemsInfo.FK_ARSaleOrderID
                    //                                                        && it.FK_ARSaleOrderItemID == objInvoiceItemsInfo.FK_ARSaleOrderItemID
                    //                                                        && it.FK_ICProductSerieID == objInvoiceItemsInfo.FK_ICProductSerieID);
                    //if (validateInvoiceItem != null)
                    //{
                    //    validateInvoiceItem.ARInvoiceItemProductQty += objInvoiceItemsInfo.ARInvoiceItemProductQty;
                    //    validateInvoiceItem.ARInvoiceItemProductExchangeQty += objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty;
                    //    validateInvoiceItem.ARInvoiceItemAcceptanceProductQty += objInvoiceItemsInfo.ARInvoiceItemAcceptanceProductQty;
                    //    validateInvoiceItem.ARInvoiceItemTaxAmount += objInvoiceItemsInfo.ARInvoiceItemTaxAmount;
                    //    validateInvoiceItem.ARInvoiceItemProductDiscount += objInvoiceItemsInfo.ARInvoiceItemProductDiscount;
                    //    validateInvoiceItem.ARInvoiceItemNetAmount += objInvoiceItemsInfo.ARInvoiceItemNetAmount;
                    //    validateInvoiceItem.ARInvoiceItemTotalAmount += objInvoiceItemsInfo.ARInvoiceItemTotalAmount;
                    //}
                    //else
                    //{
                    //    InvoiceItemsList.Add(objInvoiceItemsInfo);
                    //}
                });
            int index = 1;
            InvoiceItemsList.OrderBy(o => o.ARInvoiceItemSortOrder).ToList().ForEach(o => o.ARInvoiceItemSortOrder = index++);
        }

        public override bool IsInvalidInventory()
        {
            ARInvoicesInfo mainObject = (ARInvoicesInfo)MainObject;
            if(mainObject.ARInvoiceTypeCombo == "InvoiceAndShipment")
            {
                BOSItemsEntityList<ARInvoiceItemsInfo> checkList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
                checkList.InitBOSList(this,
                                        TableName.ARInvoicesTableName,
                                        TableName.ARInvoiceItemsTableName,
                                        BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);
                checkList.ItemTableForeignKey = "FK_ARInvoiceID";
                checkList.Invalidate(ComponentInvoiceItemList);
                foreach (ARInvoiceItemsInfo item in InvoiceItemsList)
                {
                    if ((ComponentInvoiceItemList.FirstOrDefault(i => i.ARInvoiceItemID == item.ARInvoiceItemID)) == null)
                    {
                        checkList.Add(item);
                    }
                }

                return checkList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
            }
            return false;
        }

        public void GenerateEntitiesFromAcceptanceItem(List<ARAcceptanceItemsInfo> acceptanceItems)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;

            acceptanceItems.ForEach(o =>
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                BOSUtil.CopyObject(o, objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ICProductID = o.FK_ICProductID;
                ICProductsController objProductsController = new ICProductsController();
                objInvoiceItemsInfo.FK_ICProductGroupID = o.FK_ICProductGroupID;
                objInvoiceItemsInfo.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                objInvoiceItemsInfo.FK_ARSaleOrderItemID = o.FK_ARSaleOrderItemID;
                objInvoiceItemsInfo.FK_ARAcceptanceID = o.FK_ARAcceptanceID;
                objInvoiceItemsInfo.FK_ARAcceptanceItemID = o.ARAcceptanceItemID;
                objInvoiceItemsInfo.ARInvoiceItemProductQty = o.ARAcceptanceItemProductQty;
                objInvoiceItemsInfo.ARInvoiceItemDeliveryDate = objInvoicesInfo.ARInvoiceDeliveryDate;
                objInvoiceItemsInfo.FK_ARProposalTemplateItemID = o.FK_ARProposalTemplateItemID;
                objInvoiceItemsInfo.ARProposalTemplateItemProductName = o.ARProposalTemplateItemProductName;
                SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);
                SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo);

                AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
                objAccountDebitandCredit = GeneralAcountForInvoiceItem(objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ACAccountRevenueID = objAccountDebitandCredit.AccountCredit;
                objInvoiceItemsInfo.FK_ICSectionProductID = o.FK_ICSectionProductID;
                objInvoiceItemsInfo.FK_ACCostCenterID = o.FK_ACCostCenterID;
                InvoiceItemsList.Add(objInvoiceItemsInfo);
            });
        }

        public void GenerateEntitiesFromContainerLoadItems(List<ARContainerLoaderItemsInfo> containerLoaderItemList)
        {
            containerLoaderItemList.ForEach(o =>
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                BOSUtil.CopyObject(o, objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ICProductID = o.FK_ICProductID;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = null;
                if (objInvoiceItemsInfo.FK_ICProductID > 0)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objInvoiceItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        objInvoiceItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                        objInvoiceItemsInfo.ARInvoiceItemProductSupplierNo = objProductsInfo.ICProductCustomerNumber;
                    }
                }

                objInvoiceItemsInfo.FK_ICStockID = o.FK_ICStockID;
                objInvoiceItemsInfo.FK_ARSaleOrderID = o.FK_ARSaleOrderID;
                objInvoiceItemsInfo.FK_ARSaleOrderItemID = o.FK_ARSaleOrderItemID;
                objInvoiceItemsInfo.FK_ICSectionProductID = o.FK_ICSectionProductID;
                objInvoiceItemsInfo.FK_ACCostCenterID = o.FK_ACCostCenterID;
                objInvoiceItemsInfo.FK_ARContainerLoaderID = o.FK_ARContainerLoaderID;
                objInvoiceItemsInfo.FK_ARContainerLoaderItemID = o.ARContainerLoaderItemID;
                objInvoiceItemsInfo.ARInvoiceItemProductQty = o.ARContainerLoaderItemProductQty;
                objInvoiceItemsInfo.FK_ICProductSerieID = o.FK_ICProductSerieID;
                objInvoiceItemsInfo.ARInvoiceItemProductSerialNo = o.ARSaleOrderItemProductSerialNo;
                objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = o.ARSaleOrderItemProductUnitPrice;
                objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = o.ARSaleOrderItemProductTaxPercent;
                objInvoiceItemsInfo.ARInvoiceItemProductDiscount = o.ARSaleOrderItemProductDiscount;
                objInvoiceItemsInfo.FK_ARProposalTemplateItemID = o.FK_ARProposalTemplateItemID;
                objInvoiceItemsInfo.ARProposalTemplateItemProductName = o.ARProposalTemplateItemProductName;
                objInvoiceItemsInfo.ARInvoiceItemProductFactor = o.ARContainerLoaderItemProductFactor;
                objInvoiceItemsInfo.ARInvoiceItemProductExchangeQty = o.ARContainerLoaderItemProductExchangeQty;
                objInvoiceItemsInfo.ARInvoiceItemExchangeUnitCost = o.ARContainerLoaderItemExchangeUnitCost;
                objInvoiceItemsInfo.ARInvoiceItemExchangeTotalCost = o.ARContainerLoaderItemExchangeTotalCost;
                SetProductPriceByProductUnitPrice(objInvoiceItemsInfo);

                objInvoiceItemsInfo.ARInvoiceItemProductQty = Math.Round(objInvoiceItemsInfo.ARInvoiceItemProductQty, 3, MidpointRounding.AwayFromZero);
                SetValuesAfterValidateProduct(objInvoiceItemsInfo.FK_ICProductID, objInvoiceItemsInfo);

                AccountDebitandCredit objAccountDebitandCredit = new AccountDebitandCredit();
                objAccountDebitandCredit = GeneralAcountForInvoiceItem(objInvoiceItemsInfo);
                objInvoiceItemsInfo.FK_ACAccountRevenueID = objAccountDebitandCredit.AccountCredit;

                InvoiceItemsList.Add(objInvoiceItemsInfo);
            });
        }

        public void ModuleAfterCompleted()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            if (!string.IsNullOrEmpty(objInvoicesInfo.ARInvoiceReference))
            {
                //UpdateReferenceSaleOrders();

                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objRefTypeInvoicesInfo = objInvoicesController.GetReferenceTypeByInvoiceID(objInvoicesInfo.ARInvoiceID);
                if (objRefTypeInvoicesInfo != null)
                {
                    if (objRefTypeInvoicesInfo.ActionNewFrom == "ShipmentProposal")
                    {
                        ICShipmentProposalsController objShipmentProposalsController = new ICShipmentProposalsController();
                        objShipmentProposalsController.UpdateShipmentProposalAndItemByInvoiceID(objInvoicesInfo.ARInvoiceID);
                    }

                    if (string.IsNullOrEmpty(objRefTypeInvoicesInfo.ActionNewFrom))
                    {
                        ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                        objSaleOrdersController.UpdateSaleOrderAndItemByInvoiceID(objInvoicesInfo.ARInvoiceID, objRefTypeInvoicesInfo.ActionNewFrom);
                    }
                }
            }
            if (!(objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.DryLumber.ToString()
                || objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.Roundwood.ToString()
                || objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.FreshLumber.ToString()
               ))
            {
                //UpdateBatchProductDeliveryStatus(objInvoicesInfo);
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                objBatchProductsController.UpdateBatchProductByInvoiceID(objInvoicesInfo.ARInvoiceID);
            }
        }

        public override bool CancelCompleteTransaction()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.New.ToString();
            UpdateMainObject();
            if (!string.IsNullOrEmpty(objInvoicesInfo.ARInvoiceReference))
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objRefTypeInvoicesInfo = objInvoicesController.GetReferenceTypeByInvoiceID(objInvoicesInfo.ARInvoiceID);
                if (objRefTypeInvoicesInfo != null)
                {
                    if (objRefTypeInvoicesInfo.ActionNewFrom == "ShipmentProposal")
                    {
                        ICShipmentProposalsController objShipmentProposalsController = new ICShipmentProposalsController();
                        objShipmentProposalsController.UpdateShipmentProposalAndItemByInvoiceID(objInvoicesInfo.ARInvoiceID);
                    }

                    if (string.IsNullOrEmpty(objRefTypeInvoicesInfo.ActionNewFrom))
                    {
                        ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                        objSaleOrdersController.UpdateSaleOrderAndItemByInvoiceID(objInvoicesInfo.ARInvoiceID, objRefTypeInvoicesInfo.ActionNewFrom);
                    }
                }
            }
            if (!(objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.DryLumber.ToString()
                || objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.Roundwood.ToString()
                || objInvoicesInfo.ARInvoiceProductType == InvoiceSOType.FreshLumber.ToString()
               ))
            {
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                objBatchProductsController.UpdateBatchProductByInvoiceID(objInvoicesInfo.ARInvoiceID);
            }
            return true;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                objInvoicesController.DeleteByInvoiceID(objInvoicesInfo.ARInvoiceID);
                InvoiceItemsList.DeleteItemObjects();
                ARInvoiceItemCostList.DeleteItemObjects();
                InvoiceCommissionsList.DeleteItemObjects();
            }
        }
        public override void SetProductPriceByProductUnitPrice()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductPriceByProductUnitPrice(ModuleObjects[strItemTableName]);
                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }
        public override void SetProductPriceByProductUnitPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1M;

            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
            //Math Round Start
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            if (objInvoicesInfo.ActionNewFrom == "Manual")
            {
                decimalNumber = 3;
            }

                //Get Item Unit Price
                string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            unitPrice = Math.Round(unitPrice, decimalNumber);
            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            extPrice = Math.Round(extPrice, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Get or set item discount percent and amount
            string discountPercentColumnName = itemTablePrefix + "ProductDiscount";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";

            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));

            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            discountAmount = Math.Round(discountAmount, decimalNumber);

            discountAmount = extPrice * discountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);
            dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";

            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));

            taxAmount = Math.Round(taxAmount, decimalNumber);

            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //Set Item Exchange Total Cost
            //Fix tam, HDBH tao tu XKBH gia von luon la VND, ko * exchangeRate
            int shipmentItemID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICShipmentItemID"));

            columnName = itemTablePrefix + "ExchangeTotalCost";
            if (shipmentItemID > 0 && itemTableName == TableName.ARInvoiceItemsTableName)
                dbUtil.SetPropertyValue(item, columnName, qty * unitCost);
            else
                dbUtil.SetPropertyValue(item, columnName, (qty * unitCost) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";

            if (shipmentItemID > 0 && itemTableName == TableName.ARInvoiceItemsTableName)
                dbUtil.SetPropertyValue(item, columnName, unitCost / (factor != 0 ? factor : 1) );
            else
                dbUtil.SetPropertyValue(item, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, Math.Round(qty * factor,6));
            if (objInvoicesInfo.ActionNewFrom != "Manual")
            {
                BOSApp.RoundByCurrency(item, currencyID);
            }

            item.OldObject = (BusinessObject)item.Clone();
        }
    }
    public class AccountDebitandCredit
    {
        public int AccountDebit { set; get; }
        public int AccountCredit { set; get; }
    }
}
