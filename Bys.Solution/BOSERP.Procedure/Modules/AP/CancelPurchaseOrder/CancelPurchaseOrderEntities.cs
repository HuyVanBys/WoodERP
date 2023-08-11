using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CancelPurchaseOrder
{
    public class CancelPurchaseOrderEntities : BaseTransactionEntities
    {
        #region Declare all entities variables


        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<APCancelPurchaseOrderItemsInfo> CancelPurchaseOrderItemList { get; set; }

        /// <summary>
        /// Gets or sets the list of canceled items including the item's components
        /// </summary>
        public BOSItemsEntityList<APCancelPurchaseOrderItemsInfo> ComponentCancelPurchaseOrderItemList { get; set; }
        #endregion

        #region Constructor
        public CancelPurchaseOrderEntities()
            : base()
        {
            CancelPurchaseOrderItemList = new BOSItemsEntityList<APCancelPurchaseOrderItemsInfo>();
            ComponentCancelPurchaseOrderItemList = new BOSItemsEntityList<APCancelPurchaseOrderItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new APCancelPurchaseOrdersInfo();
            MainObject = new APCancelPurchaseOrdersInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APCancelPurchaseOrderItemsTableName, new APCancelPurchaseOrderItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CancelPurchaseOrderItemList.InitBOSList(this,
                                            TableName.APCancelPurchaseOrdersTableName,
                                            TableName.APCancelPurchaseOrderItemsTableName,
                                            BOSList<APCancelPurchaseOrderItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            CancelPurchaseOrderItemList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CancelPurchaseOrderItemList.SetDefaultListAndRefreshGridControl();
                ComponentCancelPurchaseOrderItemList.SetDefaultListAndRefreshGridControl();
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

            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;
            objCancelPurchaseOrdersInfo.APCancelPurchaseOrderDate = DateTime.Now;
            objCancelPurchaseOrdersInfo.APCancelPurchaseOrderStatus = CancelPurchaseOrderStatus.New.ToString();
            objCancelPurchaseOrdersInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCancelPurchaseOrdersInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            APCancelPurchaseOrderItemsController objCancelPurchaseOrderItemsController = new APCancelPurchaseOrderItemsController();
            List<APCancelPurchaseOrderItemsInfo> listCancePurchaseOrderItem = objCancelPurchaseOrderItemsController.GetAllItemsFromCancelPurchaseOrderID(iObjectID);
            CancelPurchaseOrderItemList.Invalidate(listCancePurchaseOrderItem);
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            CancelPurchaseOrderItemList.SaveItemObjects();
        }


        #endregion



        public override bool CompleteTransaction()
        {
            //CancelPurchaseOrderEntities entity = (CancelPurchaseOrderEntities)CurrentModuleEntity;
            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;
            APPurchaseOrdersInfo objPurchaseOrdersInfo = new APPurchaseOrdersInfo();
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            List<APPurchaseOrderItemsInfo> ListPurchaseOrderItems = new List<APPurchaseOrderItemsInfo>();
            APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
            APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = new APPurchaseOrderItemsInfo();
            bool flag = false;
            bool flagclone = false;
            int count = 0;
            int countclone = 0;
            int countlist = 0;

            //objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(objCancelPurchaseOrdersInfo.APCancelPurchaseOrderReference);
            //if (objPurchaseOrdersInfo != null)
            //{
            //    ListPurchaseOrderItems = objPurchaseOrderItemsController.GetListObjectByFK_APPurchaseOrderID(objPurchaseOrdersInfo.APPurchaseOrderID);
            //    countlist = ListPurchaseOrderItems.Count();
            //}
            if (objCancelPurchaseOrdersInfo.APCancelPurchaseOrderStatus == CancelPurchaseOrderStatus.New.ToString())
            {
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderStatus = CancelPurchaseOrderStatus.Complete.ToString();
                objCancelPurchaseOrdersInfo.APCancelPurchaseOrderApproveDate = DateTime.Now;
                UpdateMainObject();
            }
            //if (ListPurchaseOrderItems.Count == CancelPurchaseOrderItemList.Count)
            //{
            //    foreach (APCancelPurchaseOrderItemsInfo item in CancelPurchaseOrderItemList)
            //    {
            //        decimal qty = 0;
            //        objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(item.FK_APPurchaseOrderItemID);
            //        if (objPurchaseOrderItemsInfo != null)
            //        {
            //            if (item.APCancelPurchaseOrderItemProductQty == objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty)
            //            {
            //                count++;
            //            }
            //            else if (objPurchaseOrderItemsInfo.APPurchaseOrderItemProductQty == (item.APCancelPurchaseOrderItemProductQty + objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty) && objPurchaseOrderItemsInfo.APPurchaseOrderItemReceiptedQty != 0)
            //            {
            //                countclone++;
            //            }
            //            else
            //            {
            //                flag = true;
            //                break;
            //            }

            //        }
            //    }
            //}
            //else
            //{
            //    objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
            //    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //}

            //if (flag && objPurchaseOrdersInfo != null && countclone != countlist && countclone != countlist)
            //{
            //    objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Incompleted.ToString();
            //    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //}
            //if (!flag && objPurchaseOrdersInfo != null && count == countlist)
            //{
            //    objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Canceled.ToString();
            //    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //}
            //if (!flag && objPurchaseOrdersInfo != null && countclone == countlist)
            //{
            //    objPurchaseOrdersInfo.APPurchaseOrderStatus = PurchaseOrderStatus.Completed.ToString();
            //    objPurchaseOrdersController.UpdateObject(objPurchaseOrdersInfo);
            //}
            
            UpdateReference();
            UpdatePurchaseOrderPaymentTimes();

            // cap nhat deposit neu chua thu tien. Thu roi thi khong cap nhat
            UpdateCancelAmountToDetailDeposit();

            GLHelper.PostedTransactions(this.Module.Name, objCancelPurchaseOrdersInfo.APCancelPurchaseOrderID, ModulePostingType.Purchase, ModulePostingType.InvoiceInTrans);
            return true;
        }

        public void UpdateCancelAmountToDetailDeposit()
        {
            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;

            APPOPaymentTimeInvoiceInDetailsController detailController = new APPOPaymentTimeInvoiceInDetailsController();
            List<APPOPaymentTimeInvoiceInDetailsInfo> detailList = detailController.GetDetailDepositByPurchaseOrderNo(objCancelPurchaseOrdersInfo.APCancelPurchaseOrderReference);

            if (detailList != null && detailList.Count > 0)
            {
                decimal totalCancelAmount = 0;

                totalCancelAmount = CancelPurchaseOrderItemList.Sum(t => t.APCancelPurchaseOrderItemTotalCost);

                foreach (APPOPaymentTimeInvoiceInDetailsInfo detail in detailList)
                {
                    detail.APPOPaymentTimeInvoiceInDetailCancelAmount += (totalCancelAmount / 100
                                                           * detail.APPurchaseOrderPaymentTimePaymentTermItemPercentPayment);
                    BOSApp.RoundByCurrency(detail, "APPOPaymentTimeInvoiceInDetailCancelAmount", objCancelPurchaseOrdersInfo.FK_GECurrencyID);
                    detailController.UpdateObject(detail);
                }
            }
        }

        public void UpdateReference()
        {
            foreach (APCancelPurchaseOrderItemsInfo item in CancelPurchaseOrderItemList)
            {
                APPurchaseOrderItemsInfo objPurchaseOrderItemsInfo = new APPurchaseOrderItemsInfo();
                APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                APProposalItemsController objProposalItemsController = new APProposalItemsController();
                APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();

                objPurchaseOrderItemsInfo = (APPurchaseOrderItemsInfo)objPurchaseOrderItemsController.GetObjectByID(item.FK_APPurchaseOrderItemID);

                if (objPurchaseOrderItemsInfo != null)
                {
                    //objPurchaseOrderItemsInfo.APPurchaseOrderItemProductCanceledQty += item.APCancelPurchaseOrderItemProductQty;
                    //objPurchaseOrderItemsInfo.APPurchaseOrderItemCanceledWoodQty += item.APCancelPurchaseOrderItemWoodQty;
                    //objPurchaseOrderItemsController.UpdateObject(objPurchaseOrderItemsInfo);

                    objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(objPurchaseOrderItemsInfo.FK_APProposalItemID);
                    if (objProposalItemsInfo != null)
                    {
                        objProposalItemsInfo.APProposalItemPurchaseOrderQty -= item.APCancelPurchaseOrderItemProductQty;
                        objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty -= item.APCancelPurchaseOrderItemWoodQty;
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }
            }

            APCancelPurchaseOrdersInfo mainObject = (APCancelPurchaseOrdersInfo)MainObject;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            List<APPurchaseOrdersInfo> listPurchaseOrdersInfo = objPurchaseOrdersController.GetListPurchaseOrderByCancelPurchaseOrderID(mainObject.APCancelPurchaseOrderID);

            foreach (APPurchaseOrdersInfo item in listPurchaseOrdersInfo)
            {
                if (item.SumPurchaseOrderQty == item.SumCanceledQty) //hủy hết
                {
                    item.APPurchaseOrderStatus = PurchaseOrderStatus.Canceled.ToString();
                    objPurchaseOrdersController.UpdateObject(item);
                }
                //else if (item.APProposalProductQty == item.APProposalCanceledQty + item.APProposalPurchaseOrderQty) //hủy 1 phần
                //{
                //    item.APPurchaseProposalStatus = PurchaseProposalStatus.Ordered.ToString();
                //    objPurchaseOrdersController.UpdateObject(item);
                //}
            }
        }

        public void UpdatePurchaseOrderPaymentTimes()
        {

            APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;
            APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
            objPurchaseOrderPaymentTimesController.UpdatePurchaseOrderPaymentTimesByCancelPurchaseOrderID(objCancelPurchaseOrdersInfo.APCancelPurchaseOrderID);

            APPOPaymentTimeInvoiceInDetailsController detailController = new APPOPaymentTimeInvoiceInDetailsController();
            CancelPurchaseOrderItemList.Select(o1 => o1.FK_APPurchaseOrderID).Distinct().ToList().ForEach(o1 =>
            {
                List<APPOPaymentTimeInvoiceInDetailsInfo> paymentsList = detailController.GetPaidPaymentByPurchaseOrderID(o1);
                if (paymentsList.Count() == 0)
                {
                    detailController.InsertDetailByPurchaseOrderID(o1
                                                                    , ModuleName.PurchaseOrder
                                                                    , BOSApp.CurrentUsersInfo.ADUserName);
                }

            });
        }

        //public void UpdatePurchaseOrderPaymentTimes()
        //{
        //    APCancelPurchaseOrdersInfo objCancelPurchaseOrdersInfo = (APCancelPurchaseOrdersInfo)MainObject;
        //    decimal TotalCostCancel = 0;
        //    TotalCostCancel = CancelPurchaseOrderItemList.Sum(x => x.APCancelPurchaseOrderItemTotalCost);
        //    APPurchaseOrdersInfo objPurchaseOrdersInfo = new APPurchaseOrdersInfo();
        //    APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
        //    objPurchaseOrdersInfo = (APPurchaseOrdersInfo)objPurchaseOrdersController.GetObjectByNo(objCancelPurchaseOrdersInfo.APCancelPurchaseOrderReference);
        //    if (objPurchaseOrdersInfo != null)
        //    {
        //        APPurchaseOrderPaymentTimesInfo objPurchaseOrderPaymentTimesInfo = new APPurchaseOrderPaymentTimesInfo();
        //        APPurchaseOrderPaymentTimesController objPurchaseOrderPaymentTimesController = new APPurchaseOrderPaymentTimesController();
        //        objPurchaseOrderPaymentTimesInfo = (APPurchaseOrderPaymentTimesInfo)objPurchaseOrderPaymentTimesController.GetObjectByAPPurchaseOrderID(objPurchaseOrdersInfo.APPurchaseOrderID).FirstOrDefault();

        //        if (objPurchaseOrderPaymentTimesInfo != null)
        //        {

        //            objPurchaseOrderPaymentTimesInfo.APPurchaseOrderPaymentTimeAmount -= TotalCostCancel;
        //            objPurchaseOrderPaymentTimesInfo.ARSaleOrderPaymentTimeBalanceDue -= TotalCostCancel;
        //            objPurchaseOrderPaymentTimesController.UpdateObject(objPurchaseOrderPaymentTimesInfo);


        //        }
        //    }
        //}
    }
}
