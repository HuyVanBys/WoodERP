using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.ClearingDebt
{
    public class ClearingDebtEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<ACClearingDebtInvoiceItemsInfo> InvoiceItemList { get; set; }

        public BOSList<ACClearingDebtInvoiceInItemsInfo> InvoiceInItemList { get; set; }

        #endregion

        #region Constructor
        public ClearingDebtEntities()
            : base()
        {
            InvoiceItemList = new BOSList<ACClearingDebtInvoiceItemsInfo>();
            InvoiceInItemList = new BOSList<ACClearingDebtInvoiceInItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACClearingDebtsInfo();
            SearchObject = new ACClearingDebtsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACClearingDebtInvoiceItemsTableName, new ACClearingDebtInvoiceItemsInfo());
            ModuleObjects.Add(TableName.ACClearingDebtInvoiceInItemsTableName, new ACClearingDebtInvoiceInItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceItemList.InitBOSList(
                                                    this,
                                                    TableName.ACClearingDebtsTableName,
                                                    TableName.ACClearingDebtInvoiceItemsTableName,
                                                    BOSList<ACClearingDebtInvoiceItemsInfo>.cstRelationForeign);
            InvoiceItemList.ItemTableForeignKey = "FK_ACClearingDebtID";
            InvoiceInItemList.InitBOSList(
                                                    this,
                                                    TableName.ACClearingDebtsTableName,
                                                    TableName.ACClearingDebtInvoiceInItemsTableName,
                                                    BOSList<ACClearingDebtInvoiceInItemsInfo>.cstRelationForeign);
            InvoiceInItemList.ItemTableForeignKey = "FK_ACClearingDebtID";
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceItemList.InitBOSListGridControl();
            InvoiceInItemList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl("fld_dgcDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACClearingDebtsInfo objClearingDebtsInfo = (ACClearingDebtsInfo)MainObject;
            objClearingDebtsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objClearingDebtsInfo.ACClearingDebtExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objClearingDebtsInfo.ACClearingDebtDate = DateTime.Now;
            objClearingDebtsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceItemList.SetDefaultListAndRefreshGridControl();
                InvoiceInItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)MainObject;
            if (mainObject.ACClearingDebtPostedStatus == PostedTransactionStatus.Posted.ToString())
            {
                ACClearingDebtInvoiceItemsController objClearingDebtInvoiceItemsController = new ACClearingDebtInvoiceItemsController();
                List<ACClearingDebtInvoiceItemsInfo> listInvoice = objClearingDebtInvoiceItemsController.GetInvoiceItemsByClearingDebtID(iObjectID);
                listInvoice.ForEach(p => p.ACClearingDebtInvoiceItemRemainAmount = p.ACClearingDebtInvoiceItemTotalAmount
                                                                                    - p.ACClearingDebtInvoiceItemPaidAmount
                                                                                    - p.ACClearingDebtInvoiceItemWaitingPayment);
                InvoiceItemList.Invalidate(listInvoice);

                ACClearingDebtInvoiceInItemsController objClearingDebtInvoiceInItemsController = new ACClearingDebtInvoiceInItemsController();
                List<ACClearingDebtInvoiceInItemsInfo> listInvoiceIn = objClearingDebtInvoiceInItemsController.GetInvoiceInItemsByClearingDebtID(iObjectID);
                listInvoiceIn.ForEach(p => p.ACClearingDebtInvoiceInItemRemainAmount = p.ACClearingDebtInvoiceInItemTotalAmount
                                                                                    - p.ACClearingDebtInvoiceInItemPaidAmount
                                                                                    - p.ACClearingDebtInvoiceInItemWaitingPayment);
                InvoiceInItemList.Invalidate(listInvoiceIn);
            }
            else
            {
                InvoiceItemList.Invalidate(iObjectID);
                InvoiceInItemList.Invalidate(iObjectID);
            }
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ACClearingDebtInvoiceItemsController objClearingDebtInvoiceItemsController = new ACClearingDebtInvoiceItemsController();
            ACClearingDebtInvoiceInItemsController objClearingDebtInvoiceInItemsController = new ACClearingDebtInvoiceInItemsController();
            for (int i = 0; i < InvoiceItemList.Count; i++)
            {
                if (InvoiceItemList[i].ACClearingDebtInvoiceItemAmountClearing <= 0)
                {
                    if (InvoiceItemList[i].ACClearingDebtInvoiceItemID > 0)
                    {
                        objClearingDebtInvoiceItemsController.DeleteObject(InvoiceItemList[i].ACClearingDebtInvoiceItemID);
                    }
                    InvoiceItemList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < InvoiceInItemList.Count; i++)
            {
                if (InvoiceInItemList[i].ACClearingDebtInvoiceInItemAmountClearing <= 0)
                {
                    if (InvoiceInItemList[i].ACClearingDebtInvoiceInItemID > 0)
                    {
                        objClearingDebtInvoiceInItemsController.DeleteObject(InvoiceInItemList[i].ACClearingDebtInvoiceInItemID);
                    }
                    InvoiceInItemList.RemoveAt(i);
                    i--;
                }
            }
            InvoiceItemList.SaveItemObjects();
            InvoiceInItemList.SaveItemObjects();
        }
        #endregion

        #region Complete
        public override bool CompleteTransaction()
        {
            #region update Invoice            
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ACClearingDebtsInfo clearingDebtsInfo = (ACClearingDebtsInfo)MainObject;
            clearingDebtsInfo.ACClearingDebtStatus = PurchaseOrderStatus.Completed.ToString();
            UpdateMainObject();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();

            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
            ARSaleOrderPaymentTimesInfo objSaleOrderPaymentTimesInfo;

            ARSaleOrdersInfo objSaleOrdersInfo = new ARSaleOrdersInfo();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();

            foreach (ACClearingDebtInvoiceItemsInfo item in InvoiceItemList)
            {
                objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(item.FK_ARSaleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    //TNDLoc [ADD][23/07/2015][Issue sale payment],START
                    #region Update payment Info
                    objSaleOrdersInfo.ARSaleOrderPaidAmount += item.ACClearingDebtInvoiceItemPaidAmount;
                    BOSApp.RoundByCurrency(objSaleOrdersInfo, clearingDebtsInfo.FK_GECurrencyID);
                    List<ARSaleOrderPaymentTimesInfo> objSaleOrderPaymentTimesList = objSaleOrderPaymentTimesController.GetItemsBySaleOrderID(item.FK_ARSaleOrderID);

                    objSaleOrderPaymentTimesInfo = objSaleOrderPaymentTimesList.FirstOrDefault(p => p.ARSaleOrderPaymentTimePaymentType == "Final Payment");
                    objSaleOrdersInfo.ARSaleOrderInvoiceAmount -= item.ACClearingDebtInvoiceItemAmountClearing;
                    BOSApp.RoundByCurrency(objSaleOrdersInfo, clearingDebtsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(objSaleOrderPaymentTimesInfo, clearingDebtsInfo.FK_GECurrencyID);


                    if (objSaleOrderPaymentTimesInfo != null)
                    {
                        objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeDepositBalance += item.ACClearingDebtInvoiceItemAmountClearing;
                        objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue -= item.ACClearingDebtInvoiceItemAmountClearing;
                        BOSApp.RoundByCurrency(objSaleOrderPaymentTimesInfo, clearingDebtsInfo.FK_GECurrencyID);
                        if (objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue > 0)
                        {
                            objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeStatus = SaleOrderPaymentTimeStatus.New.ToString();
                        }
                        else
                        {
                            objSaleOrderPaymentTimesInfo.ARSaleOrderPaymentTimeStatus = SaleOrderPaymentTimeStatus.Paid.ToString();
                        }
                        objSaleOrderPaymentTimesController.UpdateObject(objSaleOrderPaymentTimesInfo);
                    }
                    #endregion
                }
            }
            #endregion
            #region update InvoiceIn
            APInvoiceInsInfo objInvoiceInsInfo;
            APInvoiceInsController objInvoiceInsController = new APInvoiceInsController();
            foreach (ACClearingDebtInvoiceInItemsInfo item in InvoiceInItemList)
            {
                objInvoiceInsInfo = (APInvoiceInsInfo)objInvoiceInsController.GetObjectByID(item.FK_APInvoiceInID);
                if (objInvoiceInsInfo != null)
                {
                    objInvoiceInsInfo.APInvoiceInBalanceDue -= item.ACClearingDebtInvoiceInItemAmountClearing;
                    objInvoiceInsController.UpdateObject(objInvoiceInsInfo);
                }
            }
            #endregion
            return true;
        }
        #endregion        
    }
}
