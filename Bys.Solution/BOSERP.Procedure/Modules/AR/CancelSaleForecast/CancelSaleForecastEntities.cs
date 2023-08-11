using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CancelSaleForecast
{
    public class CancelSaleForecastEntities : BaseTransactionEntities
    {
        #region Declare all entities variables


        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSList<ARCancelSaleForecastItemsInfo> CancelSaleForecastItemList { get; set; }

        /// <summary>
        /// Gets or sets the list of canceled items including the item's components
        /// </summary>
        public BOSList<ARCancelSaleForecastItemsInfo> ComponentCancelSaleForecastItemList { get; set; }
        #endregion

        #region Constructor
        public CancelSaleForecastEntities()
            : base()
        {
            CancelSaleForecastItemList = new BOSList<ARCancelSaleForecastItemsInfo>();
            ComponentCancelSaleForecastItemList = new BOSList<ARCancelSaleForecastItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new ARCancelSaleForecastsInfo();
            MainObject = new ARCancelSaleForecastsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARCancelSaleForecastItemsTableName, new ARCancelSaleForecastItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CancelSaleForecastItemList.InitBOSList(this,
                                            TableName.ARCancelSaleForecastsTableName,
                                            TableName.ARCancelSaleForecastItemsTableName,
                                            BOSList<ARCancelSaleForecastItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            CancelSaleForecastItemList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CancelSaleForecastItemList.SetDefaultListAndRefreshGridControl();
                ComponentCancelSaleForecastItemList.SetDefaultListAndRefreshGridControl();
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

            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;
            objCancelSaleForecastsInfo.ARCancelSaleForecastDate = DateTime.Now;
            objCancelSaleForecastsInfo.ARCancelSaleForecastStatus = CancelSaleForecastStatus.New.ToString();
            objCancelSaleForecastsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCancelSaleForecastsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objCancelSaleForecastsInfo.ARCancelSaleForecastExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);

            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;
            ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
            ARSaleForecastsInfo objSaleForecastsInfo = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByID(objCancelSaleForecastsInfo.FK_ARSaleForecastID);
            if (objSaleForecastsInfo != null)
            {
                objCancelSaleForecastsInfo.ARSaleForecastNo = objSaleForecastsInfo.ARSaleForecastNo;
                objCancelSaleForecastsInfo.ARSaleForecastDate = objSaleForecastsInfo.ARSaleForecastDate;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            CancelSaleForecastItemList.Invalidate(iObjectID);

            //Invalidate item components
            InvalidateItemComponents();
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
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;

            //Set total canceled quantity for items then save the item list
            foreach (ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo in CancelSaleForecastItemList)
            {
                ARCancelSaleForecastItemsInfo objOldCancelSaleForecastItemsInfo = CancelSaleForecastItemList.BackupList.Where(i => i.ARCancelSaleForecastItemID == objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemID).FirstOrDefault();
                if (objOldCancelSaleForecastItemsInfo != null)
                {
                    objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty = objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty -
                                                                            objOldCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty +
                                                                            objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty;
                }
                else
                {
                    objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalQty += objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemProductQty;
                }
            }
            CancelSaleForecastItemList.SaveItemObjects();

            //Invalidate item components
            InvalidateItemComponents();

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


        /// <summary>
        /// Update the reference sale order that the cancel voucher has been created from
        /// </summary>
        private void UpdateReferenceSaleForecast()
        {
            ARCancelSaleForecastsInfo cancelSaleForecast = (ARCancelSaleForecastsInfo)MainObject;

            ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = new ARCancelSaleForecastItemsInfo();
            BOSList<ARSaleForecastItemsInfo> saleForecastItems = new BOSList<ARSaleForecastItemsInfo>();
            ARSaleForecastsInfo objSaleForecastsInfo = new ARSaleForecastsInfo();
            List<ARSaleForecastItemsInfo> ListSaleforecastItems = new List<ARSaleForecastItemsInfo>();
            ARSaleForecastItemsController objSaleForecastItemsController = new ARSaleForecastItemsController();


            saleForecastItems.InitBOSList(this, TableName.ARSaleForecastsTableName, TableName.ARSaleForecastItemsTableName);
            saleForecastItems.ItemTableForeignKey = "FK_ARSaleForecastID";
            saleForecastItems.Invalidate(cancelSaleForecast.FK_ARSaleForecastID);

            //Rollback the total canceled quantity of the reference sale order items
            //foreach (ARCancelSaleForecastItemsInfo cancelSaleForecastItem in CancelSaleForecastItemList.BackupList)
            //{
            //    decimal cancelSaleForecastItemQty = cancelSaleForecastItem.ARCancelSaleForecastItemProductQty;
            //    while (cancelSaleForecastItemQty > 0)
            //    {
            //        ARSaleForecastItemsInfo saleForecastItem = saleForecastItems.Where(i => i.FK_ICProductID == cancelSaleForecastItem.FK_ICProductID &&
            //                                                                  i.ARSaleForecastItemCanceledQty > 0).FirstOrDefault();
            //        decimal canceledQty = 0;
            //        if (saleForecastItem != null)
            //        {
            //            canceledQty = Math.Min(cancelSaleForecastItemQty, saleForecastItem.ARSaleForecastItemCanceledQty);
            //        }
            //        else
            //        {
            //            saleForecastItem = saleForecastItems.Where(i => i.FK_ICProductID == cancelSaleForecastItem.FK_ICProductID).FirstOrDefault();
            //            canceledQty = cancelSaleForecastItemQty;
            //        }

            //        if (saleForecastItem != null)
            //        {
            //            saleForecastItem.ARSaleForecastItemCanceledQty -= canceledQty;
            //            objSaleForecastItemsController.UpdateObject(saleForecastItem);
            //        }
            //        else
            //        {
            //            break;
            //        }

            //        cancelSaleForecastItemQty -= canceledQty;
            //    }
            //}

            //Update the new total canceled quantity of the reference sale order items
            foreach (ARCancelSaleForecastItemsInfo cancelSaleForecastItem in CancelSaleForecastItemList)
            {
                decimal cancelSaleForecastItemQty = cancelSaleForecastItem.ARCancelSaleForecastItemProductQty;
                while (cancelSaleForecastItemQty > 0)
                {
                    ARSaleForecastItemsInfo saleForecastItem = saleForecastItems.Where(i => i.FK_ICProductID == cancelSaleForecastItem.FK_ICProductID &&
                                                                              i.ARSaleForecastItemProductQty - i.ARSaleForecastItemCanceledQty - i.ARSaleForecastItemProductSOQty > 0)
                                                                        .FirstOrDefault();
                    decimal canceledQty = 0;
                    if (saleForecastItem != null)
                    {
                        canceledQty = Math.Min(cancelSaleForecastItemQty, saleForecastItem.ARSaleForecastItemProductQty -
                                                                    saleForecastItem.ARSaleForecastItemCanceledQty -
                                                                    saleForecastItem.ARSaleForecastItemProductSOQty);
                    }
                    else
                    {
                        saleForecastItem = saleForecastItems.Where(i => i.FK_ICProductID == cancelSaleForecastItem.FK_ICProductID).FirstOrDefault();
                        canceledQty = cancelSaleForecastItemQty;
                    }

                    if (saleForecastItem != null)
                    {
                        saleForecastItem.ARSaleForecastItemCanceledQty += canceledQty;
                        objSaleForecastItemsController.UpdateObject(saleForecastItem);
                    }
                    else
                    {
                        break;
                    }

                    cancelSaleForecastItemQty -= canceledQty;
                }
            }

            //Cancel the whole sale order if its all items are canceled
            bool cancelAll = true;
            bool completed = true;
            foreach (ARSaleForecastItemsInfo saleForecastItem in saleForecastItems)
            {
                if (saleForecastItem.ARSaleForecastItemCanceledQty < saleForecastItem.ARSaleForecastItemProductQty)
                {
                    cancelAll = false;
                }
                if (saleForecastItem.ARSaleForecastItemProductQty > saleForecastItem.ARSaleForecastItemCanceledQty + saleForecastItem.ARSaleForecastItemProductSOQty)
                {
                    completed = false;
                }
            }

            if (cancelAll)
            {
                ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
                ARSaleForecastsInfo saleForecast = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByID(cancelSaleForecast.FK_ARSaleForecastID);
                if (saleForecast != null)
                {
                    saleForecast.ARSaleForecastStatus = SaleForecastStatus.Canceled.ToString();
                    saleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    saleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(saleForecast);
                }
            }
            else if (completed)
            {
                ARSaleForecastsController objSaleForecastsController = new ARSaleForecastsController();
                ARSaleForecastsInfo saleForecast = (ARSaleForecastsInfo)objSaleForecastsController.GetObjectByID(cancelSaleForecast.FK_ARSaleForecastID);
                if (saleForecast != null)
                {
                    saleForecast.ARSaleForecastStatus = SaleForecastStatus.Complete.ToString();
                    saleForecast.AAUpdatedUser = BOSApp.CurrentUser;
                    saleForecast.AAUpdatedDate = DateTime.Now;
                    objSaleForecastsController.UpdateObject(saleForecast);
                }
            }

        }
        #endregion

        ///// <summary>
        ///// Update the total amount of the cancel voucher whenever
        ///// user changes any info affecting to it
        ///// </summary>
        public void UpdateTotalAmount()
        {
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;
            objCancelSaleForecastsInfo.ARCancelSaleForecastNetAmount = 0;
            objCancelSaleForecastsInfo.ARCancelSaleForecastSubTotalAmount = 0;
            foreach (ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo in CancelSaleForecastItemList)
            {
                BOSApp.RoundByCurrency(objCancelSaleForecastItemsInfo, objCancelSaleForecastsInfo.FK_GECurrencyID);
                objCancelSaleForecastsInfo.ARCancelSaleForecastNetAmount += objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemNetAmount;
                objCancelSaleForecastsInfo.ARCancelSaleForecastSubTotalAmount += objCancelSaleForecastItemsInfo.ARCancelSaleForecastItemTotalAmount;
            }
            BOSApp.RoundByCurrency(objCancelSaleForecastsInfo, objCancelSaleForecastsInfo.FK_GECurrencyID);
            objCancelSaleForecastsInfo.ARCancelSaleForecastDiscountFix = objCancelSaleForecastsInfo.ARCancelSaleForecastSubTotalAmount * objCancelSaleForecastsInfo.ARCancelSaleForecastDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objCancelSaleForecastsInfo, "ARCancelSaleForecastDiscountFix", objCancelSaleForecastsInfo.FK_GECurrencyID);
            objCancelSaleForecastsInfo.ARCancelSaleForecastTaxAmount = (objCancelSaleForecastsInfo.ARCancelSaleForecastSubTotalAmount - objCancelSaleForecastsInfo.ARCancelSaleForecastDiscountFix) * objCancelSaleForecastsInfo.ARCancelSaleForecastTaxPercent / 100;
            BOSApp.RoundByCurrency(objCancelSaleForecastsInfo, "ARCancelSaleForecastTaxAmount", objCancelSaleForecastsInfo.FK_GECurrencyID);
            objCancelSaleForecastsInfo.ARCancelSaleForecastTotalAmount = objCancelSaleForecastsInfo.ARCancelSaleForecastSubTotalAmount - objCancelSaleForecastsInfo.ARCancelSaleForecastDiscountFix + objCancelSaleForecastsInfo.ARCancelSaleForecastTaxAmount;
            BOSApp.RoundByCurrency(objCancelSaleForecastsInfo, "ARCancelSaleForecastTotalAmount", objCancelSaleForecastsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Invalidate item components of the cancel voucher items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARCancelSaleForecastItemsController objCancelSaleForecastItemsController = new ARCancelSaleForecastItemsController();
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;
            List<ARCancelSaleForecastItemsInfo> items = objCancelSaleForecastItemsController.GetComponentItemsByCancelSaleForecastID(objCancelSaleForecastsInfo.ARCancelSaleForecastID);
            ComponentCancelSaleForecastItemList.Clear();
            ComponentCancelSaleForecastItemList.OriginalList.Clear();
            ComponentCancelSaleForecastItemList.BackupList.Clear();
            foreach (ARCancelSaleForecastItemsInfo item in items)
            {
                ComponentCancelSaleForecastItemList.Add((ARCancelSaleForecastItemsInfo)item.Clone());
            }

            foreach (ARCancelSaleForecastItemsInfo item in ComponentCancelSaleForecastItemList)
            {
                ComponentCancelSaleForecastItemList.OriginalList.Add((ARCancelSaleForecastItemsInfo)item.Clone());
                ComponentCancelSaleForecastItemList.BackupList.Add((ARCancelSaleForecastItemsInfo)item.Clone());
            }
        }

        public override bool CompleteTransaction()
        {
            //Update sale forecast's status
            ARCancelSaleForecastsInfo objCancelSaleForecastsInfo = (ARCancelSaleForecastsInfo)MainObject;

            if (objCancelSaleForecastsInfo.ARCancelSaleForecastStatus == CancelSaleForecastStatus.New.ToString())
            {
                objCancelSaleForecastsInfo.ARCancelSaleForecastStatus = CancelSaleForecastStatus.Complete.ToString();
                UpdateMainObject();
                //UpdateModuleObjectBatchStatus();
            }

            if (objCancelSaleForecastsInfo.FK_ARSaleForecastID > 0)
            {
                UpdateReferenceSaleForecast();
            }

            return true;
        }
    }
}
