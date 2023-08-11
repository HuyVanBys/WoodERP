using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.OperationDetailPlanCancel
{
    class OperationDetailPlanCancelModule : BaseModuleERP
    {

        public OperationDetailPlanCancelModule()
        {
            Name = "OperationDetailPlanCancel";
            CurrentModuleEntity = new OperationDetailPlanCancelEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();


        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            MMOperationDetailPlanCancelsInfo searchObject = (MMOperationDetailPlanCancelsInfo)entity.SearchObject;
            DataSet ds = new DataSet();
            if (searchObject != null)
            {
                MMOperationDetailPlanCancelsController bpcController = new MMOperationDetailPlanCancelsController();
                ds = bpcController.GetBySomeConditions(searchObject.MMOperationDetailPlanCancelNo
                                                        , searchObject.FK_HREmployeeID
                                                        , searchObject.MMOperationDetailPlanCancelStatus
                                                        , searchObject.FK_MMOperationDetailPlanID
                                                        , searchObject.OperationDetailPlanCancelDateFrom
                                                        , searchObject.OperationDetailPlanCancelDateTo);
            }

            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

        }

        public void DeleteItemFromOperationDetailPlanCancelItemList()
        {
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            entity.OperationDetailPlanCancelItemList.RemoveSelectedRowObjectFromList();

        }
        public override bool ActionComplete()
        {

            if (!CheckValidQty())
            {
                return false;
            }
            UpdateCancelItemChildProductQty();
            RollBackCompensateProductQty();
            return base.ActionComplete();
        }
        public bool RollBackCompensateProductQty()
        {
            bool result = true;
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            MMOperationDetailPlanCancelsInfo OperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)entity.MainObject;
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            MMOperationDetailPlanItemChildsController objOperationDetailPlanItemChildsController = new MMOperationDetailPlanItemChildsController();
            if (OperationDetailPlanCancelsInfo.FK_MMOperationDetailPlanID > 0)
            {
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)objOperationDetailPlansController.GetObjectByID(OperationDetailPlanCancelsInfo.FK_MMOperationDetailPlanID);
                if (objOperationDetailPlansInfo != null && objOperationDetailPlansInfo.MMOperationDetailPlanType == OperationDetailPlanType.Compensate.ToString())
                {

                    foreach (MMOperationDetailPlanCancelItemsInfo item in entity.OperationDetailPlanCancelItemList)
                    {
                        if (item.FK_MMOperationDetailPlanItemChildID > 0)
                            objOperationDetailPlanItemChildsController.UpdateOperationDetailPlanItemChildRefCompensateProductQty(item.FK_MMOperationDetailPlanItemChildID);
                    }
                    if (objOperationDetailPlansInfo.MMOperationDetailPlanStatus == OperationDetailPlanStatus.Completed.ToString())
                    {
                        objOperationDetailPlansInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
                        objOperationDetailPlansController.UpdateObject(objOperationDetailPlansInfo);
                    }
                    if (objOperationDetailPlansInfo.FK_MMOperationDetailPlanID > 0)
                    {
                        MMOperationDetailPlansInfo objOperationDetailPlansRefInfo = (MMOperationDetailPlansInfo)objOperationDetailPlansController.GetObjectByID(objOperationDetailPlansInfo.FK_MMOperationDetailPlanID);
                        if (objOperationDetailPlansRefInfo != null && objOperationDetailPlansRefInfo.MMOperationDetailPlanID > 0)
                        {
                            objOperationDetailPlansRefInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
                            objOperationDetailPlansController.UpdateObject(objOperationDetailPlansRefInfo);
                        }
                    }
                    else if (objOperationDetailPlansInfo.MMOperationDetailPlanType == OperationDetailPlanType.Compensate.ToString()
                        && objOperationDetailPlansInfo.FK_MMOperationDetailPlanID == 0)
                    {
                        List<MMOperationDetailPlansInfo> listPlan = objOperationDetailPlansController.GetListPlanByCompensatePlanID(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                        if (listPlan != null)
                        {
                            foreach (MMOperationDetailPlansInfo item in listPlan)
                            {

                                if (CheckCompletedRefPlan(item.MMOperationDetailPlanID))
                                {
                                    item.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Completed.ToString();
                                }
                                else
                                {
                                    item.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
                                }
                                objOperationDetailPlansController.UpdateObject(item);

                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool CheckCompletedRefPlan(int OperationDetailPlanID)
        {
            bool result = false;
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            result = objOperationDetailPlansController.CheckCompletedRefPlan(OperationDetailPlanID);

            return result;
        }
        public void UpdateCancelItemChildProductQty()
        {
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            MMOperationDetailPlanCancelsInfo OperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)entity.MainObject;
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            MMOperationDetailPlanItemChildsController odpicController = new MMOperationDetailPlanItemChildsController();
            MMOperationDetailPlanItemChildsInfo odpicInfo;
            List<int> OperationDetailPlanItemIDs = new List<int>();
            foreach (MMOperationDetailPlanCancelItemsInfo item in entity.OperationDetailPlanCancelItemList)
            {
                odpicInfo = (MMOperationDetailPlanItemChildsInfo)odpicController.GetObjectByID(item.FK_MMOperationDetailPlanItemChildID);
                if (odpicInfo != null)
                {
                    odpicInfo.MMOperationDetailPlanItemChildCancelQty += item.MMOperationDetailPlanCancelItemQty;
                    odpicController.UpdateObject(odpicInfo);
                }
                //Get list PlanItemID to update cancel item Ref
                if (item.FK_MMOperationDetailPlanItemID > 0)
                {
                    if (!OperationDetailPlanItemIDs.Exists(e => e == item.FK_MMOperationDetailPlanItemID))
                    {
                        OperationDetailPlanItemIDs.Add(item.FK_MMOperationDetailPlanItemID);
                    }
                }
            }
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)objOperationDetailPlansController.GetObjectByID(OperationDetailPlanCancelsInfo.FK_MMOperationDetailPlanID);
            if (objOperationDetailPlansInfo != null && objOperationDetailPlansInfo.MMOperationDetailPlanStatus == OperationDetailPlanStatus.Completed.ToString())
            {
                objOperationDetailPlansInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
                objOperationDetailPlansController.UpdateObject(objOperationDetailPlansInfo);
            }

            //update cancel item Ref
            if (OperationDetailPlanItemIDs != null && OperationDetailPlanItemIDs.Count > 0)
            {
                foreach (int ID in OperationDetailPlanItemIDs)
                {
                    UpdateCancelItemRefProductQty(ID);
                }

            }
        }

        public void UpdateRefOperationDetailPlan(int OperationDetailPlanID)
        {
            bool result = false;
            MMOperationDetailPlansController objOperationDetailPlansController = new MMOperationDetailPlansController();
            MMOperationDetailPlansInfo objOperationDetailPlanRefsInfo = (MMOperationDetailPlansInfo)objOperationDetailPlansController.GetObjectByID(OperationDetailPlanID);
            if (objOperationDetailPlanRefsInfo != null)
            {
                result = objOperationDetailPlansController.CheckCompletedRefPlan(OperationDetailPlanID);
                if (result)
                    objOperationDetailPlanRefsInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Completed.ToString();
                else
                    objOperationDetailPlanRefsInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
                objOperationDetailPlansController.UpdateObject(objOperationDetailPlanRefsInfo);
            }


        }

        public decimal UpdateCancelItemRefProductQty(int OperationDetailPlanItemID)
        {
            decimal result = 0;
            decimal cancelQty = 0;
            int cancel = 1;
            MMOperationDetailPlanItemChildsController objOperationDetailPlanItemChildsController = new MMOperationDetailPlanItemChildsController();
            MMOperationDetailPlanItemsController objOperationDetailPlanItemsController = new MMOperationDetailPlanItemsController();
            List<MMOperationDetailPlanItemChildsInfo> childItemList = objOperationDetailPlanItemChildsController.GetOperationDetailPlanItemChildByParentID(OperationDetailPlanItemID);
            if (childItemList != null && childItemList.Count > 0)
            {
                foreach (MMOperationDetailPlanItemChildsInfo obj in childItemList)
                {
                    decimal cancelChildQty = 0;
                    decimal itemQty = 0;
                    if (obj.MMOperationDetailPlanItemChildCancelQty > 0)
                    {
                        obj.SynchronousPercent = obj.MMOperationDetailPlanItemChildCancelQty / obj.MMOperationDetailPlanItemChildPlanProductQty;
                        itemQty = obj.MMOperationDetailPlanItemChildTotalProductQty / obj.MMOperationDetailPlanItemChildProductQty;
                        cancelChildQty = Math.Floor(obj.SynchronousPercent * itemQty);
                        if (cancelQty == 0)
                            cancelQty = cancelChildQty;
                        else if (cancelChildQty < cancelQty)
                            cancelQty = cancelChildQty;
                    }
                    else
                        cancel = 0;
                }
            }
            if (cancel == 1)
                result = cancelQty;
            else
                result = 0;

            MMOperationDetailPlanItemsInfo objOperationDetailPlanItemsInfo = (MMOperationDetailPlanItemsInfo)objOperationDetailPlanItemsController.GetObjectByID(OperationDetailPlanItemID);
            if (objOperationDetailPlanItemsInfo != null)
            {
                objOperationDetailPlanItemsInfo.MMOperationDetailPlanItemCancelProductQty = result;
                objOperationDetailPlanItemsController.UpdateObject(objOperationDetailPlanItemsInfo);
            }

            return result;
        }
        public bool CheckValidQty()
        {
            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            MMOperationDetailPlanItemChildsController odpicController = new MMOperationDetailPlanItemChildsController();
            MMOperationDetailPlanItemChildsInfo odpicInfo;
            decimal canCancelQty = 0;
            foreach (MMOperationDetailPlanCancelItemsInfo item in entity.OperationDetailPlanCancelItemList)
            {
                odpicInfo = (MMOperationDetailPlanItemChildsInfo)odpicController.GetItemForCancelByID(item.FK_MMOperationDetailPlanItemChildID, item.MMOperationDetailPlanCancelItemID);
                if (odpicInfo != null)
                {
                    canCancelQty = odpicInfo.MMOperationDetailPlanItemChildPlanProductQty
                                             - odpicInfo.MMOperationDetailPlanItemChildCancelQty // SL không bao gồm những chứng từ chưa duyệt
                                             - odpicInfo.MMOperationDetailPlanItemChildCompensateQty
                                             - odpicInfo.MMOperationDetailPlanItemChildCompletedProductQty;
                }
                if (item.MMOperationDetailPlanCancelItemQty > canCancelQty)
                {
                    MessageBox.Show("Sản phẩm " + item.MMOperationDetailPlanCancelItemProductNo + ", Mã lô: " + item.MMOperationDetailPlanCancelItemProductSerial + " có số lượng không hợp lệ. "
                                    + Environment.NewLine + "Số lượng có thể hủy tối đa là: " + canCancelQty
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        public override int ActionSave()
        {
            if (!CheckValidQty())
            {
                return 0;
            }


            return base.ActionSave();
        }


        public override void ActionNew()
        {
            base.ActionNew();

            OperationDetailPlanCancelEntities entity = (OperationDetailPlanCancelEntities)CurrentModuleEntity;
            MMOperationDetailPlanCancelsInfo OperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)entity.MainObject;

            MMOperationDetailPlanItemChildsController odpicController = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> odpicList = odpicController.GetItemForCancel();

            guiFind<MMOperationDetailPlanItemChildsInfo> guiFind
                = new guiFind<MMOperationDetailPlanItemChildsInfo>("MMOperationDetailPlanItemChilds"
                                                                    , odpicList
                                                                    , this
                                                                    , true);

        stampx:
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count > 0)
                {
                    MMOperationDetailPlanItemChildsInfo itemChild = guiFind.SelectedObjects[0];
                    if (itemChild != null)
                    {
                        MMOperationDetailPlanItemChildsInfo notMatch = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_MMOperationDetailPlanID != itemChild.FK_MMOperationDetailPlanID);
                        if (notMatch != null)
                        {
                            MessageBox.Show("Vui lòng chọn các sản phẩm cùng Kế hoạch sản xuất.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            goto stampx;
                        }
                        else
                        {
                            MMOperationDetailPlansController odpController = new MMOperationDetailPlansController();
                            MMOperationDetailPlansInfo odpInfo = (MMOperationDetailPlansInfo)odpController.GetObjectByID(itemChild.FK_MMOperationDetailPlanID);
                            if (odpInfo != null)
                            {
                                //=> Main Object

                                OperationDetailPlanCancelsInfo.FK_MMOperationDetailPlanID = odpInfo.MMOperationDetailPlanID;
                                OperationDetailPlanCancelsInfo.FK_MMLineID = odpInfo.FK_MMLineID;
                                OperationDetailPlanCancelsInfo.FK_MMOperationID = odpInfo.FK_MMOperationID;
                                OperationDetailPlanCancelsInfo.FK_MMWorkShopID = odpInfo.FK_MMWorkShopID;
                                OperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelWeek = odpInfo.MMOperationDetailPlanWeek;
                            }
                            //=> Module Object
                            List<MMOperationDetailPlanCancelItemsInfo> cancelList = new List<MMOperationDetailPlanCancelItemsInfo>();
                            MMOperationDetailPlanCancelItemsInfo cancelItem;
                            decimal cancelQty = 0;
                            foreach (MMOperationDetailPlanItemChildsInfo item in guiFind.SelectedObjects)
                            {
                                cancelQty = 0;
                                cancelItem = new MMOperationDetailPlanCancelItemsInfo();
                                BOSUtil.CopyObject(item, cancelItem);

                                cancelItem.FK_MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                                cancelQty = item.MMOperationDetailPlanItemChildPlanProductQty
                                             - item.MMOperationDetailPlanItemChildCancelQty
                                             - item.MMOperationDetailPlanItemChildCompensateQty
                                             - item.MMOperationDetailPlanItemChildCompletedProductQty;

                                if (cancelQty > 0)
                                {
                                    cancelItem.MMOperationDetailPlanCancelItemQty = cancelQty;
                                    cancelList.Add(cancelItem);
                                }
                            }

                            entity.OperationDetailPlanCancelItemList.Invalidate(cancelList);
                            entity.OperationDetailPlanCancelItemList.GridControl?.RefreshDataSource();
                        }
                    }
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public override void InvalidateToolbar()
        {
            MMOperationDetailPlanCancelsInfo objOperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)CurrentModuleEntity.MainObject;
            if (objOperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);

                if (objOperationDetailPlanCancelsInfo.MMOperationDetailPlanCancelStatus == OperationDetailPlanCancelStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }


            }

            base.InvalidateToolbar();
        }
    }
}
