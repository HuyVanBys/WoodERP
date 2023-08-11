using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseProposal
{
    public class CancelPurchaseProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<APCancelPurchaseProposalItemsInfo> CancelPurchaseProposalItemList { get; set; }

        /// <summary>
        /// Gets or sets the referred proposal items for creating a new proposal
        /// </summary>
        public BOSList<APCancelPurchaseProposalItemsInfo> ReferredProposalItemList { get; set; }


        #endregion

        #region Constructor
        public CancelPurchaseProposalEntities()
            : base()
        {
            CancelPurchaseProposalItemList = new BOSList<APCancelPurchaseProposalItemsInfo>();
            ReferredProposalItemList = new BOSList<APCancelPurchaseProposalItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APCancelPurchaseProposalsInfo();
            SearchObject = new APCancelPurchaseProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APCancelPurchaseProposalItemsTableName, new APCancelPurchaseProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CancelPurchaseProposalItemList.InitBOSList(
                                        this,
                                        TableName.APCancelPurchaseProposalsTableName,
                                        TableName.APCancelPurchaseProposalItemsTableName,
                                        BOSList<APCancelPurchaseProposalItemsInfo>.cstRelationForeign);

            ReferredProposalItemList.InitBOSList(
                                            this,
                                            null,
                                            TableName.APCancelPurchaseProposalItemsTableName,
                                            BOSList<APCancelPurchaseProposalItemsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            CancelPurchaseProposalItemList.InitBOSListGridControl();
            ReferredProposalItemList.InitBOSListGridControl("fld_dgcAPProductsOfProposalItemsGridControl");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)MainObject;
            objCancelPurchaseProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalDate = DateTime.Now;
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalStatus = PurchaseProposalStatus.New.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CancelPurchaseProposalItemList.SetDefaultListAndRefreshGridControl();
                ReferredProposalItemList.SetDefaultListAndRefreshGridControl();
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
            APCancelPurchaseProposalItemsController objCancelPurchaseOrderItemsController = new APCancelPurchaseProposalItemsController();
            List<APCancelPurchaseProposalItemsInfo> listItem = objCancelPurchaseOrderItemsController.GetAllItemsFromCancelPurchaseProposalID(iObjectID);
            CancelPurchaseProposalItemList.Invalidate(listItem);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            if (CancelPurchaseProposalItemList.Count > 0)
            {
                CancelPurchaseProposalItemList.SaveItemObjects();
            }

        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            APCancelPurchaseProposalItemsInfo item = (APCancelPurchaseProposalItemsInfo)ModuleObjects[TableName.APProposalItemsTableName];
            SetValuesAfterValidateProduct(iICProductID, item);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                APCancelPurchaseProposalItemsInfo proposalItem = (APCancelPurchaseProposalItemsInfo)item;
                SetDefaultValuesFromProduct(productID, proposalItem);
                SetProductCost(proposalItem);

                APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)MainObject;
                proposalItem.APCancelPurchaseProposalItemType = objCancelPurchaseProposalsInfo.APCancelPurchaseProposalType;
                proposalItem.FK_BRBranchID = objCancelPurchaseProposalsInfo.FK_BRBranchID;
                proposalItem.FK_APSupplierID = objProductsInfo.FK_APSupplierID;
                proposalItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                proposalItem.APCancelPurchaseProposalItemPurchaseOrderQty = 0;
                proposalItem.APCancelPurchaseProposalItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                proposalItem.APCancelPurchaseProposalItemStatus = CancelPurchaseProposalItemStatus.New.ToString();
            }
        }

        /// <summary>
        /// Discard all items of the proposal
        /// </summary>
        public bool ApproveProposal()
        {
            SetPropertyChangeEventLock(false);
            bool check = false;
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = new MMPurchasePlanItemsInfo();
            foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in CancelPurchaseProposalItemList)
            {
                if (DiscardProposalItem(objCancelPurchaseProposalItemsInfo))
                {
                    //update purchase plan
                    objPurchasePlanItemsInfo = (MMPurchasePlanItemsInfo)objPurchasePlanItemsController.GetObjectByID(objCancelPurchaseProposalItemsInfo.FK_MMPurchasePlanItemID);
                    if (objPurchasePlanItemsInfo != null)
                    {
                        objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty -= objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemProductQty;
                        objPurchasePlanItemsController.UpdateObject(objPurchasePlanItemsInfo);
                    }
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            //Update the proposal's status
            if (check)
            {
                CancelPurchaseProposalItemList.SaveItemObjects();
                APCancelPurchaseProposalsInfo mainObject = (APCancelPurchaseProposalsInfo)MainObject;
                mainObject.APCancelPurchaseProposalStatus = CancelPurchaseProposalStatus.Approved.ToString();
                UpdateMainObject();

                APProposalsController objProposalsController = new APProposalsController();
                List<APProposalsInfo> listProposalsInfo = objProposalsController.GetProposalListByCancelPurchaseProposalID(mainObject.APCancelPurchaseProposalID);
                foreach(APProposalsInfo item in listProposalsInfo)
                {
                    if(item.APProposalProductQty == item.APProposalCanceledQty
                        && item.APProposalPurchaseOrderQty == 0) //hủy hết
                    {
                        item.APPurchaseProposalStatus = PurchaseProposalStatus.Canceled.ToString();
                        objProposalsController.UpdateObject(item);
                    }
                    else if (item.APProposalProductQty == item.APProposalCanceledQty + item.APProposalPurchaseOrderQty) //hủy 1 phần
                    {
                        item.APPurchaseProposalStatus = PurchaseProposalStatus.Ordered.ToString();
                        objProposalsController.UpdateObject(item);
                    }
                }    

                SetPropertyChangeEventLock(true);
                return true;
            }
            else
            {
                SetPropertyChangeEventLock(true);
                return false;
            }
        }
        /// <summary>
        /// Discard a proposal item
        /// </summary>
        /// <param name="item">Given item</param>
        public bool DiscardProposalItem(APCancelPurchaseProposalItemsInfo item)
        {
            bool result = false;
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_APProposalItemID);
            if (objProposalItemsInfo != null && objProposalItemsInfo.APProposalItemID > 0)
            {

                if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Approved.ToString() ||
                    objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.New.ToString())
                {
                    List<APPurchaseOrderItemsInfo> PurchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
                    APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                    PurchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByProposalItemIDAndPurchaseOrderStatus(item.FK_APProposalItemID, string.Empty);
                    decimal SLDMH = 0;
                    decimal SLDaHuy = 0;
                    if (PurchaseOrderItemList != null && PurchaseOrderItemList.Count > 0)
                    {
                        SLDMH = PurchaseOrderItemList.Sum(poi => poi.APPurchaseOrderItemProductQty);
                        SLDaHuy = PurchaseOrderItemList.Sum(poi => poi.APPurchaseOrderItemProductCanceledQty);
                    }
                    //SL còn lại > sl don hang + sl da huy
                    if (objProposalItemsInfo.APProposalItemProductQty > (SLDMH - SLDaHuy + objProposalItemsInfo.APProposalItemCanceledQty))
                    {
                        //SL huy <= sl con lai
                        if (item.APCancelPurchaseProposalItemProductQty <=
                            Math.Round((objProposalItemsInfo.APProposalItemProductQty - (SLDMH - SLDaHuy - objProposalItemsInfo.APProposalItemCanceledQty)), 5, MidpointRounding.AwayFromZero))
                        {
                            objProposalItemsInfo.APProposalItemCanceledQty += item.APCancelPurchaseProposalItemProductQty;
                            objProposalItemsInfo.APProposalItemCanceledWoodQty += item.APCancelPurchaseProposalItemWoodQty;
                            objProposalItemsController.UpdateObject(objProposalItemsInfo);
                            result = true;
                        }
                        else
                        {
                            MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotDiscardProposalItemWhenRemainQtyLessThanCancelQtyMessage, item.APCancelPurchaseProposalItemProductDesc),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotDiscardProposalItemWhenRemainQtyLessThanCancelQtyMessage, item.APCancelPurchaseProposalItemProductDesc),
                                   CommonLocalizedResources.MessageBoxDefaultCaption,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                else if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Purchased.ToString())
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CannotDiscardPurchasedItem,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Canceled.ToString())
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CancelProposalitem,
                                                   CommonLocalizedResources.MessageBoxDefaultCaption,
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CannotDiscardDisapprovedItem,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotFindProposalItemMessage, item.APCancelPurchaseProposalItemProductName),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            return result;
        }

        public bool CheckCancelQty(APCancelPurchaseProposalItemsInfo item)
        {
            bool result = false;
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            APProposalItemsInfo objProposalItemsInfo = (APProposalItemsInfo)objProposalItemsController.GetObjectByID(item.FK_APProposalItemID);
            if (objProposalItemsInfo != null && objProposalItemsInfo.APProposalItemID > 0)
            {

                if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Approved.ToString() ||
                    objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.New.ToString())
                {
                    List<APPurchaseOrderItemsInfo> PurchaseOrderItemList = new List<APPurchaseOrderItemsInfo>();
                    APPurchaseOrderItemsController objPurchaseOrderItemsController = new APPurchaseOrderItemsController();
                    PurchaseOrderItemList = objPurchaseOrderItemsController.GetPurchaseOrderItemByProposalItemIDAndPurchaseOrderStatus(item.FK_APProposalItemID, string.Empty);
                    decimal SLDMH = 0;
                    decimal SLDaHuy = 0;
                    if (PurchaseOrderItemList != null && PurchaseOrderItemList.Count > 0)
                    {
                        SLDMH = PurchaseOrderItemList.Sum(poi => poi.APPurchaseOrderItemProductQty);
                        SLDaHuy = PurchaseOrderItemList.Sum(poi => poi.APPurchaseOrderItemProductCanceledQty);
                    }
                    //SL còn lại > sl don hang + sl da huy
                    if (objProposalItemsInfo.APProposalItemProductQty > (SLDMH - SLDaHuy + objProposalItemsInfo.APProposalItemCanceledQty))
                    {
                        //SL huy <= sl con lai
                        if (item.APCancelPurchaseProposalItemProductQty <= (objProposalItemsInfo.APProposalItemProductQty - (SLDMH - SLDaHuy - objProposalItemsInfo.APProposalItemCanceledQty)))
                        {
                            result = true;
                        }
                        else
                        {
                            MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotDiscardProposalItemWhenRemainQtyLessThanCancelQtyMessage, item.APCancelPurchaseProposalItemProductDesc),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotDiscardProposalItemWhenRemainQtyLessThanCancelQtyMessage, item.APCancelPurchaseProposalItemProductDesc),
                                   CommonLocalizedResources.MessageBoxDefaultCaption,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                else if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Purchased.ToString())
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CannotDiscardPurchasedItem,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (objProposalItemsInfo.APPurchaseProposalItemStatus == CancelPurchaseProposalItemStatus.Canceled.ToString())
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CancelProposalitem,
                                                   CommonLocalizedResources.MessageBoxDefaultCaption,
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(CancelPurchaseProposalLocalizedResources.CannotDiscardDisapprovedItem,
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(string.Format(CancelPurchaseProposalLocalizedResources.CannotFindProposalItemMessage, item.APCancelPurchaseProposalItemProductDesc),
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            return result;
        }

        /// <summary>
        /// Update total cost whenever discount, freight, fee is changed
        /// </summary>
        public void UpdateTotalCost()
        {
            APCancelPurchaseProposalsInfo objCancelPurchaseProposalsInfo = (APCancelPurchaseProposalsInfo)MainObject;
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalSubTotalCost = 0;
            foreach (APCancelPurchaseProposalItemsInfo objCancelPurchaseProposalItemsInfo in CancelPurchaseProposalItemList)
            {
                objCancelPurchaseProposalsInfo.APCancelPurchaseProposalSubTotalCost += objCancelPurchaseProposalItemsInfo.APCancelPurchaseProposalItemTotalCost;
            }
            objCancelPurchaseProposalsInfo.APCancelPurchaseProposalTotalCost = objCancelPurchaseProposalsInfo.APCancelPurchaseProposalSubTotalCost + objCancelPurchaseProposalsInfo.APCancelPurchaseProposalTaxAmount;
            UpdateMainObjectBindingSource();
        }
    }
}
