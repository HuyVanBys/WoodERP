using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.PurchaseProposal
{
    public class PurchaseProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<APProposalItemsInfo> PurchaseProposalItemList { get; set; }

        public BOSList<APProposalItemTotalsInfo> PurchaseProposalItemTotalList { get; set; }

        public BOSList<MMPurchasePlanItemsInfo> PurchasePlanItemList { get; set; }

        /// <summary>
        /// Gets or sets the referred proposal items for creating a new proposalAPProposalItemTotals
        /// </summary>
        public BOSList<APProposalItemsInfo> ReferredProposalItemList { get; set; }

        /// <summary>
        /// Gets or sets a value indicates whether unselected proposal items will be canceled
        /// if the proposal is created from reference ones
        /// </summary>
        public bool CancelUnselectedProposalItems { get; set; }
        #endregion

        #region Constructor
        public PurchaseProposalEntities()
            : base()
        {
            PurchaseProposalItemList = new BOSList<APProposalItemsInfo>();
            PurchaseProposalItemTotalList = new BOSList<APProposalItemTotalsInfo>();
            ReferredProposalItemList = new BOSList<APProposalItemsInfo>();
            PurchasePlanItemList = new BOSList<MMPurchasePlanItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new APProposalsInfo();
            SearchObject = new APProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APProposalItemsTableName, new APProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            PurchaseProposalItemList.InitBOSList(
                                        this,
                                        TableName.APProposalsTableName,
                                        TableName.APProposalItemsTableName,
                                        BOSList<APProposalItemsInfo>.cstRelationForeign);

            PurchaseProposalItemTotalList.InitBOSList(
                                        this,
                                        TableName.APProposalsTableName,
                                        TableName.APProposalItemTotalsTableName,
                                        BOSList<APProposalItemsInfo>.cstRelationForeign);

            ReferredProposalItemList.InitBOSList(
                                            this,
                                            TableName.APProposalsTableName,
                                            TableName.APProposalItemsTableName,
                                            BOSList<APProposalItemsInfo>.cstRelationForeign);

            PurchasePlanItemList.InitBOSList(this,
                                        null,
                                        TableName.MMPurchasePlanItemsTableName,
                                        BOSList<MMPurchasePlanItemsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PurchaseProposalItemList.InitBOSListGridControl();
            PurchaseProposalItemTotalList.InitBOSListGridControl("fld_dgcAPProposalItemTotals");
            ReferredProposalItemList.InitBOSListGridControl();
            PurchasePlanItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            objProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objProposalsInfo.APProposalDate = this.Module.GetServerDate();
            objProposalsInfo.APPurchaseProposalType = PurchaseProposalType.SaleOrder.ToString();
            objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalStatus.New.ToString();
            objProposalsInfo.APProposalApproveStatus = ApproveStatus.NeedApprove;
            objProposalsInfo.APProposalNeedTime = this.Module.GetServerDate();
            objProposalsInfo.APProposalNeedToTime = this.Module.GetServerDate();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PurchaseProposalItemList.SetDefaultListAndRefreshGridControl();
                PurchaseProposalItemTotalList.SetDefaultListAndRefreshGridControl();
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
            APProposalsController objMainObjectController = new APProposalsController();
            MainObject = objMainObjectController.GeProposalByID(iObjectID);
            UpdateMainObjectBindingSource(); 
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            PurchaseProposalItemList.Clear();
            PurchaseProposalItemTotalList.Clear();

            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            List<APProposalItemsInfo> proposalItemList = objProposalItemsController.GetItemByProposalID(iObjectID);
            PurchaseProposalItemList.Invalidate(proposalItemList);
            PurchaseProposalItemTotalList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();

        }

        public override void SaveModuleObjects()
        {
            if (PurchaseProposalItemList.Count > 0)
            {
                PurchaseProposalItemList.SaveItemObjects();
            }

            if (PurchaseProposalItemTotalList.Count > 0)
            {
                PurchaseProposalItemTotalList.SaveItemObjects();
            }

            if (ReferredProposalItemList.Count > 0)
            {
                APProposalItemsController objProposalItemsController = new APProposalItemsController();
                foreach (APProposalItemsInfo objProposalItemsInfo in ReferredProposalItemList)
                {
                    if (objProposalItemsInfo.Selected)
                    {
                        objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Confirmed.ToString();
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                    else if (CancelUnselectedProposalItems)
                    {
                        objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Canceled.ToString();
                        objProposalItemsController.UpdateObject(objProposalItemsInfo);
                    }
                }

                APProposalsController objProposalsController = new APProposalsController();
                List<int> proposalIDs = new List<int>();
                foreach (APProposalItemsInfo item in ReferredProposalItemList)
                {
                    if (!proposalIDs.Exists(id => item.FK_APProposalID == id))
                    {
                        objProposalsController.ConfirmProposal(item.FK_APProposalID);
                        proposalIDs.Add(item.FK_APProposalID);
                    }
                }
            }
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            APProposalItemsInfo item = (APProposalItemsInfo)ModuleObjects[TableName.APProposalItemsTableName];
            SetValuesAfterValidateProduct(iICProductID, item);
        }

        public void SetValuesAfterValidateProduct(APProposalItemsInfo item)
        {
            SetValuesAfterValidateProduct(item.FK_ICProductID, item);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                APProposalItemsInfo proposalItem = (APProposalItemsInfo)item;
                //SetDefaultValuesFromProduct(productID, proposalItem);
                proposalItem.FK_ICProductID = objProductsInfo.ICProductID;
                proposalItem.APProposalItemProductName = objProductsInfo.ICProductName;
                proposalItem.APProposalItemProductDesc = objProductsInfo.ICProductDesc;
                proposalItem.APProposalItemProductAttribute = objProductsInfo.ICProductAttribute;
                proposalItem.APProposalItemProductType = objProductsInfo.ICProductType;
                proposalItem.APProposalItemProductUnitCost = objProductsInfo.ICProductSupplierPrice;
                proposalItem.APProposalItemProductTaxPercent = SetDefaultProductTaxPercent(objProductsInfo);
                SetProductCost(proposalItem);
                APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
                proposalItem.APPurchaseProposalItemType = objProposalsInfo.APPurchaseProposalType;
                proposalItem.FK_BRBranchID = objProposalsInfo.FK_BRBranchID;
                proposalItem.FK_APSupplierID = objProductsInfo.FK_APSupplierID;
                proposalItem.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                proposalItem.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                if (proposalItem.FK_ICMeasureUnitID == 0)
                    if (objProductsInfo.FK_ICProductPurchaseUnitID != 0)
                        proposalItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                    else
                        proposalItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                proposalItem.APProposalItemPurchaseOrderQty = 0;
                proposalItem.APProposalItemProductSupplierNo = objProductsInfo.ICProductSupplierNumber;
                proposalItem.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                proposalItem.APProposalItemProductDesc = objProductsInfo.ICProductDesc;
                proposalItem.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
                proposalItem.APProposalItemProductType = objProductsInfo.ICProductType;
                proposalItem.APProposalItemNeedTime = objProposalsInfo.APProposalNeedTime;
                proposalItem.APProposalItemNeedToTime = objProposalsInfo.APProposalNeedToTime;

                if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString() &&
                        proposalItem.FK_MMAllocationProposalID == 0 &&
                        proposalItem.FK_MMAllocationProposalItemID == 0 &&
                        proposalItem.FK_MMPurchasePlanID == 0 &&
                        proposalItem.FK_MMPurchasePlanItemID == 0)
                {
                    proposalItem.APProposalItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
                }
            }
        }

        /// <summary>
        /// Update proposal item status
        /// </summary>
        /// <param name="objProposalItemsInfo">Info of proposal item</param>
        public void UpdateProposalItemStatus(APProposalItemsInfo objProposalItemsInfo)
        {
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            objProposalItemsController.UpdateObject(objProposalItemsInfo);
        }

        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public bool ApproveProposal()
        {
            SetPropertyChangeEventLock(false);
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            MMPurchasePlanItemTotalsController objPurchasePlanItemTotalsController = new MMPurchasePlanItemTotalsController();
            MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = new MMPurchasePlanItemsInfo();
            MMPurchasePlanItemTotalsInfo objPurchasePlanItemTotalsInfo = new MMPurchasePlanItemTotalsInfo();
            foreach (APProposalItemsInfo objProposalItemsInfo in PurchaseProposalItemList)
            {
                if (objProposalItemsInfo.APPurchaseProposalItemStatus != PurchaseProposalItemStatus.Purchased.ToString())
                {
                    objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Approved.ToString();
                }
                objPurchasePlanItemsInfo = (MMPurchasePlanItemsInfo)objPurchasePlanItemsController.GetObjectByID(objProposalItemsInfo.FK_MMPurchasePlanItemID);
                if (objPurchasePlanItemsInfo != null)
                {
                    objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty += objProposalItemsInfo.APProposalItemProductQty;
                    objPurchasePlanItemsController.UpdateObject(objPurchasePlanItemsInfo);
                }
                List<MMPurchasePlanItemTotalsInfo> purchasePlanItemTotalList = new List<MMPurchasePlanItemTotalsInfo>();
                purchasePlanItemTotalList = objPurchasePlanItemTotalsController.GetPurchasePlanItemTotalByMMBatchProductIDAndMMPurchasePlanIDAndICProductID(objProposalItemsInfo.FK_MMBatchProductID, objProposalItemsInfo.FK_MMPurchasePlanID, objProposalItemsInfo.FK_ICProductID);
                if (purchasePlanItemTotalList != null && purchasePlanItemTotalList.Count > 0)
                {
                    purchasePlanItemTotalList[0].MMPurchasePlanItemTotalPurchaseProposalQty += objProposalItemsInfo.APProposalItemProductQty;
                    objPurchasePlanItemTotalsController.UpdateObject(purchasePlanItemTotalList[0]);
                }
            }
            PurchaseProposalItemList.SaveItemObjects();
            foreach (APProposalItemTotalsInfo objProposalItemTotalsInfo in PurchaseProposalItemTotalList)
            {
                if (objProposalItemTotalsInfo.APPurchaseProposalItemStatus != PurchaseProposalItemStatus.Purchased.ToString())
                {
                    objProposalItemTotalsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Approved.ToString();
                }
            }
            PurchaseProposalItemTotalList.SaveItemObjects();
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalStatus.Approved.ToString();
            objProposalsInfo.APProposalApproveStatus = ApproveStatus.Approved;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        /// <summary>
        /// Discard all items of the proposal
        /// </summary>
        public bool DiscardProposal()
        {
            SetPropertyChangeEventLock(false);
            APProposalsInfo mainObject = (APProposalsInfo)MainObject;
            PurchaseProposalItemList.Invalidate(mainObject.APProposalID);
            bool check = false;
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            MMPurchasePlanItemTotalsController objPurchasePlanItemTotalsController = new MMPurchasePlanItemTotalsController();
            MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = new MMPurchasePlanItemsInfo();
            foreach (APProposalItemsInfo objProposalItemsInfo in PurchaseProposalItemList)
            {
                objPurchasePlanItemsInfo = (MMPurchasePlanItemsInfo)objPurchasePlanItemsController.GetObjectByID(objProposalItemsInfo.FK_MMPurchasePlanItemID);
                if (objPurchasePlanItemsInfo != null)
                {
                    List<MMPurchasePlanItemTotalsInfo> purchasePlanItemTotalList = new List<MMPurchasePlanItemTotalsInfo>();
                    if (objProposalItemsInfo.APPurchaseProposalItemStatus == PurchaseProposalItemStatus.Approved.ToString())
                    {
                        objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty -= objProposalItemsInfo.APProposalItemProductExchangeQty - objProposalItemsInfo.APProposalItemPurchaseOrderQty;
                        //HIEUNT [Hủy số lượng danh sách tổng KHMH],START
                        purchasePlanItemTotalList = objPurchasePlanItemTotalsController.GetPurchasePlanItemTotalByMMBatchProductIDAndMMPurchasePlanIDAndICProductID
                            (objProposalItemsInfo.FK_MMBatchProductID, objProposalItemsInfo.FK_MMPurchasePlanID, objProposalItemsInfo.FK_ICProductID);
                        if (purchasePlanItemTotalList != null && purchasePlanItemTotalList.Count > 0)
                        {
                            purchasePlanItemTotalList[0].MMPurchasePlanItemTotalPurchaseProposalQty -= objProposalItemsInfo.APProposalItemProductExchangeQty - objProposalItemsInfo.APProposalItemPurchaseOrderQty;
                            objPurchasePlanItemTotalsController.UpdateObject(purchasePlanItemTotalList[0]);
                        }
                        //HIEUNT [Duyệt số lượng danh sách tổng KHMH],END
                    }
                    objPurchasePlanItemsController.UpdateObject(objPurchasePlanItemsInfo);
                }
                if (objProposalItemsInfo.APProposalItemProductQty > (objProposalItemsInfo.APProposalItemPurchaseOrderQty + objProposalItemsInfo.APProposalItemCanceledQty))
                {
                    if (objProposalItemsInfo.APPurchaseProposalItemStatus != PurchaseProposalItemStatus.Purchased.ToString())
                    {
                        objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Canceled.ToString();
                        objProposalItemsInfo.APProposalItemCanceledQty = objProposalItemsInfo.APProposalItemProductExchangeQty - objProposalItemsInfo.APProposalItemPurchaseOrderQty;
                        objProposalItemsInfo.APProposalItemCanceledWoodQty = objProposalItemsInfo.APProposalItemWoodQty - objProposalItemsInfo.APProposalItemPurchaseOrderWoodQty;
                    }
                    check = true;
                }
            }
            PurchaseProposalItemList.SaveItemObjects();
            //HIEUNT [Hủy số lượng danh sách tổng DNMH],START
            foreach (APProposalItemTotalsInfo objProposalItemTotalsInfo in PurchaseProposalItemTotalList)
            {
                if (objProposalItemTotalsInfo.APProposalItemTotalProductQty > (objProposalItemTotalsInfo.APProposalItemTotalPurchaseOrderQty + objProposalItemTotalsInfo.APProposalItemTotalCanceledQty))
                {
                    if (objProposalItemTotalsInfo.APPurchaseProposalItemStatus != PurchaseProposalItemStatus.Purchased.ToString())
                    {
                        objProposalItemTotalsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.Canceled.ToString();
                        objProposalItemTotalsInfo.APProposalItemTotalCanceledQty = objProposalItemTotalsInfo.APProposalItemTotalProductQty - objProposalItemTotalsInfo.APProposalItemTotalPurchaseOrderQty;
                        objProposalItemTotalsInfo.APProposalItemTotalCanceledWoodQty = objProposalItemTotalsInfo.APProposalItemTotalWoodQty - objProposalItemTotalsInfo.APProposalItemTotalPurchaseOrderWoodQty;
                    }
                }
            }
            PurchaseProposalItemTotalList.SaveItemObjects();
            //HIEUNT [Hủy số lượng danh sách tổng DNMH],START

            //Update the proposal's status
            if (check)
            {
                APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
                objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalStatus.Canceled.ToString();
                UpdateMainObject();
                SetPropertyChangeEventLock(true);
                return true;
            }
            else
                return false;
        }

        public bool ConfirmProposal()
        {
            SetPropertyChangeEventLock(false);
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalStatus.Confirmed.ToString();
            objProposalsInfo.APProposalApproveStatus = ApproveStatus.NeedApprove;
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        /// <summary>
        /// Update total cost whenever discount, freight, fee is changed
        /// </summary>
        public void UpdateTotalCost()
        {
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            objProposalsInfo.APProposalSubTotalCost = 0;
            foreach (APProposalItemsInfo objProposalItemsInfo in PurchaseProposalItemList)
            {
                objProposalsInfo.APProposalSubTotalCost += objProposalItemsInfo.APProposalItemTotalCost;
            }
            objProposalsInfo.APProposalTotalCost = objProposalsInfo.APProposalSubTotalCost + objProposalsInfo.APProposalTaxAmount;
            UpdateMainObjectBindingSource();
        }

        public decimal CheckTotalCostOfItemList()
        {
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            decimal subTotalCost = 0;
            decimal totalCost = 0;
            foreach (APProposalItemsInfo objProposalItemsInfo in PurchaseProposalItemList)
            {
                subTotalCost += objProposalItemsInfo.APProposalItemTotalCost;
            }
            totalCost = subTotalCost + objProposalsInfo.APProposalTaxAmount;
            return totalCost;
        }

        public override void DuplicateModuleObjectList()
        {
            PurchaseProposalItemList.Duplicate();
            foreach (APProposalItemsInfo item in PurchaseProposalItemList)
            {
                item.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
                item.APProposalItemPurchaseOrderQty = 0;
            }
        }
        public void UpdateReferencePurchasePlan(APProposalItemsInfo item)
        {
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            APProposalItemsInfo objProposalItemsInfo = new APProposalItemsInfo();
            APProposalItemsController objProposalItemsController = new APProposalItemsController();


            MMPurchasePlanItemsController objPurchasePlanItemController = new MMPurchasePlanItemsController();
            List<MMPurchasePlanItemsInfo> ListPurchasePlanItemsInfo = objPurchasePlanItemController.GetPurchasePlanItemByProposal(objProposalsInfo.FK_MMPurchasePlanID);
            foreach (MMPurchasePlanItemsInfo items in ListPurchasePlanItemsInfo)
            {

                if (items.MMPurchasePlanItemID == item.FK_MMPurchasePlanItemID)
                {
                    items.MMPurchasePlanItemPurchaseProposalQty = items.MMPurchasePlanItemPurchaseProposalQty - item.APProposalItemCanceledQty;
                    objPurchasePlanItemController.UpdateObject(items);
                }
            }

        }
        public void DiscardPurchasePlanItems()
        {
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            foreach (APProposalItemsInfo item in PurchaseProposalItemList)
            {
                MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = (MMPurchasePlanItemsInfo)objPurchasePlanItemsController.GetObjectByID(item.FK_MMPurchasePlanItemID);
                if (objPurchasePlanItemsInfo != null)
                {
                    decimal purchasedProposalQty = objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty - item.APProposalItemProductQty;
                    if (purchasedProposalQty > 0)
                    {
                        objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty = purchasedProposalQty;
                    }
                    else
                    {
                        objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty = 0;
                    }
                    objPurchasePlanItemsController.UpdateObject(objPurchasePlanItemsInfo);
                }
            }
        }
        //HIEUNT [Cập nhật lại dữ liệu khi hủy duyệt],START
        public bool UpdateValueCancelApproveProposal()
        {
            SetPropertyChangeEventLock(false);
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            MMPurchasePlanItemTotalsController objPurchasePlanItemTotalsController = new MMPurchasePlanItemTotalsController();
            MMPurchasePlanItemsInfo objPurchasePlanItemsInfo = new MMPurchasePlanItemsInfo();
            MMPurchasePlanItemTotalsInfo objPurchasePlanItemTotalsInfo = new MMPurchasePlanItemTotalsInfo();
            foreach (APProposalItemsInfo objProposalItemsInfo in PurchaseProposalItemList)
            {
                objProposalItemsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
                objPurchasePlanItemsInfo = (MMPurchasePlanItemsInfo)objPurchasePlanItemsController.GetObjectByID(objProposalItemsInfo.FK_MMPurchasePlanItemID);
                if (objPurchasePlanItemsInfo != null)
                {
                    objPurchasePlanItemsInfo.MMPurchasePlanItemPurchaseProposalQty -= objProposalItemsInfo.APProposalItemProductQty;
                    objPurchasePlanItemsController.UpdateObject(objPurchasePlanItemsInfo);
                }
                //HIEUNT [Hủy duyệt số lượng danh sách tổng KHMH],START
                List<MMPurchasePlanItemTotalsInfo> purchasePlanItemTotalList = new List<MMPurchasePlanItemTotalsInfo>();
                purchasePlanItemTotalList = objPurchasePlanItemTotalsController.GetPurchasePlanItemTotalByMMBatchProductIDAndMMPurchasePlanIDAndICProductID(objProposalItemsInfo.FK_MMBatchProductID, objProposalItemsInfo.FK_MMPurchasePlanID, objProposalItemsInfo.FK_ICProductID);
                if (purchasePlanItemTotalList != null && purchasePlanItemTotalList.Count > 0)
                {
                    purchasePlanItemTotalList[0].MMPurchasePlanItemTotalPurchaseProposalQty -= objProposalItemsInfo.APProposalItemProductQty;
                    objPurchasePlanItemTotalsController.UpdateObject(purchasePlanItemTotalList[0]);
                }
                //HIEUNT [Hủy duyệt số lượng danh sách tổng KHMH],END
            }
            PurchaseProposalItemList.SaveItemObjects();
            foreach (APProposalItemTotalsInfo objProposalItemTotalsInfo in PurchaseProposalItemTotalList)
            {
                objProposalItemTotalsInfo.APPurchaseProposalItemStatus = PurchaseProposalItemStatus.New.ToString();
            }
            PurchaseProposalItemTotalList.SaveItemObjects();

            //Update the proposal's status
            APProposalsInfo objProposalsInfo = (APProposalsInfo)MainObject;
            objProposalsInfo.APPurchaseProposalStatus = PurchaseProposalStatus.New.ToString();
            UpdateMainObject();
            SetPropertyChangeEventLock(true);
            return true;
        }

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                PurchaseProposalItemList.DeleteItemObjects();
                PurchaseProposalItemTotalList.DeleteItemObjects();
                PurchasePlanItemList.DeleteItemObjects();
                ReferredProposalItemList.DeleteItemObjects();
            }
        }
    }
}
