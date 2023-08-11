using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public class JobTicketModule : BaseModuleERP
    {
        #region Constants

        #endregion Constants

        #region Private Properties
        #endregion Private Properties
        public bool IsChooseItemEdit = false;
        public JobTicketModule()
        {
            Name = "JobTicket";
            CurrentModuleEntity = new JobTicketEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        #region Action
        public override void ActionNew()
        {
            base.ActionNew();
            FilterDataByControl();
        }
        public override void ActionEdit()
        {
            if (!IsChooseItemEdit)
                base.ActionEdit();
            IsChooseItemEdit = false;
        }
        public override bool SwitchToEditMode(BusinessObject obj, String strPropertyName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (!IsChooseItemEdit)
                base.SwitchToEditMode(obj, strPropertyName);
            return false;
        }
        public override int ActionSave()
        {
            SetDefaultName();
            return base.ActionSave();
        }
        public void SetDefaultName()
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            MMJobTicketsController mainContrl = new MMJobTicketsController();
            int backlogInMonth = 0;
            MMJobTicketsInfo getBacklogCount = mainContrl.GetBacklogInMonth(mainObject.MMJobTicketID, mainObject.MMJobTicketDate);
            if (getBacklogCount != null)
                backlogInMonth = getBacklogCount.BacklogInMonth;
            if (mainObject.MMJobTicketName.Trim() == string.Empty)
                mainObject.MMJobTicketName = "TGV-"
                    + mainObject.MMJobTicketDate.Year.ToString()
                    + mainObject.MMJobTicketDate.Month.ToString()
                    + "."
                    + (backlogInMonth + 1).ToString();
        }
        public void AddToJobTicketItemList(BOSList<MMJobTicketItemsInfo> SelectList)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            SelectList.ForEach(o =>
            {
                MMJobTicketItemsInfo bp = entity.JobTicketItem.FirstOrDefault(t => t.FK_MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID);
                if (bp != null && bp.MMJobTicketItemStatus == Status.New.ToString())
                {
                    bp.MMJobTicketItemTodoQty = o.MMJobTicketItemTodoQty;
                    bp.FK_MMOperationDetailPlanItemChildID = o.FK_MMOperationDetailPlanItemChildID;
                    bp.MMJobTicketItemPlanQty = o.MMJobTicketItemPlanQty;
                    bp.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                    bp.MMJobTicketItemDeliveryQty = o.MMJobTicketItemDeliveryQty;
                    bp.MMJobTicketItemExecutionMaxDate = o.MMJobTicketItemExecutionMaxDate;
                    bp.MMJobTicketItemExecutionFromDate = o.MMJobTicketItemExecutionFromDate;
                    bp.MMJobTicketItemExecutionToDate = o.MMJobTicketItemExecutionToDate;
                    bp.Selected = false;
                }
                else
                {
                    bp = new MMJobTicketItemsInfo();
                    BOSUtil.CopyObject(o, bp);
                    bp.FK_MMOperationDetailPlanItemChildID = o.FK_MMOperationDetailPlanItemChildID;
                    bp.MMJobTicketItemStatus = Status.New.ToString();
                    entity.JobTicketItem.Add(bp);
                }
            });
            FilterDataByControl();
        }
        public int RandomNumber(int min, int max, MMJobTicketItemsInfo bp, List<MMJobTicketItemsInfo> JobTicketItem)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            Random random = new Random();
            int rand = random.Next(min, max);
            var objExit = JobTicketItem.Where(o => o.FK_MMOperationDetailPlanItemChildID == bp.FK_MMOperationDetailPlanItemChildID && o.MMJobTicketItemAbstractID == rand).FirstOrDefault();
            if (objExit != null)
                RandomNumber(min + 1001, max + 1001, bp, JobTicketItem);
            return rand;
        }
        public void ShowPlanDetail()
        {
            if (IsEditable())
            {
                ActionEdit();
            }
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            entity.DetailPlanList.Clear();
            using (guiChooseDetailPlan guiChooseDetailPlan = new guiChooseDetailPlan())
            {
                guiChooseDetailPlan.Module = this;
                guiChooseDetailPlan.ShowDialog();

                if (guiChooseDetailPlan.DialogResult == DialogResult.OK)
                {
                    #region Main Object
                    mainObject.MMJobTicketFromDate = guiChooseDetailPlan.MMJobTicketFromDate;
                    mainObject.MMJobTicketToDate = guiChooseDetailPlan.MMJobTicketToDate;
                    mainObject.FK_HRDepartmentRoomGroupItemID = guiChooseDetailPlan.HRDepartmentRoomGroupItemID;
                    mainObject.FK_MMLineID = guiChooseDetailPlan.MMLineID;
                    mainObject.FK_MMWorkShopID = guiChooseDetailPlan.MMWorkShopID;
                    mainObject.FK_MMOperationID = guiChooseDetailPlan.MMOperationID;
                    #endregion
                    #region Module Object
                    AddToJobTicketItemList(guiChooseDetailPlan.SelectList);
                    #endregion
                }
            }
        }
        public void RemoveItem(MMJobTicketItemsInfo bp)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (bp != null && bp.MMJobTicketItemStatus == Status.New.ToString())
                {
                    JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
                    int iIndex = entity.JobTicketItem.IndexOf(bp);
                    if (iIndex >= 0)
                        entity.JobTicketItem.RemoveAt(iIndex);
                    FilterDataByControl();
                }
            }
        }
        public void ChangeJobTicketDate(DateTime fromDate, DateTime toDate)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
                MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;

                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật cho tất cả các chi tiết?") == DialogResult.Yes)
                    {
                        foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                        {
                            if (item.MMJobTicketItemStatus == Status.New.ToString()
                                && item.Selected)
                            {
                                item.MMJobTicketItemExecutionFromDate = fromDate;
                                item.MMJobTicketItemExecutionToDate = toDate;
                            }
                        }
                        entity.JobTicketItem.GridControl?.RefreshDataSource();
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }

        public void ApproveJobTicket()
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            entity.JobTicketItem.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {
                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn duyệt các chi tiết đã chọn?") == DialogResult.Yes)
                    {
                        bool isError1 = false;
                        foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                        {
                            if (item.Selected && item.MMJobTicketItemStatus != Status.New.ToString())
                            {
                                isError1 = true;
                                item.IsError = true;
                            }
                            if (item.Selected && !isError1)
                                item.MMJobTicketItemStatus = Status.Approved.ToString();

                        }
                        if (entity.JobTicketItem.Where(x => x.Selected).Count() > 0 && !isError1)
                        {
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemsInfo>(entity.JobTicketItem.Where(x => x.Selected).ToList(), "MMJobTicketItemID", "MMJobTicketItems", mainObject.MMJobTicketID, BOSApp.CurrentUsersInfo.ADUserName);
                            FilterDataByControl();
                            BOSApp.ShowMessage("Cập nhật thành công");
                        }
                        else
                        {
                            string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                            BOSApp.ShowMessage(mess);
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public void CancelJobTicket(MMJobTicketItemsInfo onlyItem)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            entity.JobTicketItem.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {
                CheckExitCapacity(null);
                bool isError1 = false;
                bool isError2 = false;
                if (entity.JobTicketItem.Where(o => (o.Selected && onlyItem == null) || onlyItem != null).Count() > 0)
                {

                    foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                    {
                        if ((onlyItem != null && onlyItem.MMJobTicketItemID == item.MMJobTicketItemID) || onlyItem == null)
                        {
                            if (item.MMJobTicketItemReceiptQty > 0 && item.Selected && item.MMJobTicketItemStatus == Status.Approved.ToString())
                            {
                                isError1 = true;
                                item.IsError = true;
                            }
                            if (item.Selected && (item.MMJobTicketItemStatus == Status.Canceled.ToString()
                                || item.MMJobTicketItemStatus == Status.Closed.ToString()
                                || item.MMJobTicketItemStatus == Status.New.ToString()))
                            {
                                isError2 = true;
                                item.IsError = true;
                            }
                            if (!isError2 && !isError1)
                                if (item.MMJobTicketItemStatus == Status.Approved.ToString() && item.Selected
                                    && item.MMJobTicketItemReceiptQty == 0)
                                    item.MMJobTicketItemStatus = Status.Canceled.ToString();
                        }

                    }
                    if (!isError2 && !isError1)
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn hủy các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            if (entity.JobTicketItem.Where(x => (x.Selected && onlyItem == null)
                                || (onlyItem != null && x.MMJobTicketItemID == onlyItem.MMJobTicketItemID)).Count() > 0)
                            {
                                SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemsInfo>(entity.JobTicketItem.Where(x => (x.Selected && onlyItem == null)
                                    || (onlyItem != null && x.MMJobTicketItemID == onlyItem.MMJobTicketItemID)).ToList(), "MMJobTicketItemID", "MMJobTicketItems", mainObject.MMJobTicketID, BOSApp.CurrentUsersInfo.ADUserName);
                                FilterDataByControl();
                                BOSApp.ShowMessage("Cập nhật thành công");
                            }
                        }
                    }
                    else
                    {
                        string mess = "Có lỗi xảy ra, chi tiết bạn chọn {0}";
                        string messEr1 = "đã nhập năng suất";
                        string messEr2 = "trạng thái khác đã duyệt";
                        if (isError1 && !isError2) mess = string.Format(mess, messEr1);
                        else if (!isError1 && isError2) mess = string.Format(mess, messEr2);
                        else if (isError1 && isError2) mess = string.Format(mess, messEr1 + ", " + messEr2);
                        BOSApp.ShowMessage(mess);
                    }

                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public void CloseJobTicket()
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            entity.JobTicketItem.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {
                bool isError1 = false;
                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                    {
                        if (item.Selected && (item.MMJobTicketItemStatus == Status.Canceled.ToString()
                            || item.MMJobTicketItemStatus == Status.Closed.ToString()
                            || item.MMJobTicketItemStatus == Status.New.ToString()))
                        {
                            isError1 = true;
                            item.IsError = true;
                        }
                        if (item.Selected && !isError1)
                            item.MMJobTicketItemStatus = Status.Closed.ToString();
                    }
                    if (isError1)
                    {
                        string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                        BOSApp.ShowMessage(mess);
                    }
                    else if (entity.JobTicketItem.Where(x => x.Selected).Count() > 0)
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn đóng các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemsInfo>(entity.JobTicketItem.Where(x => x.Selected).ToList(), "MMJobTicketItemID", "MMJobTicketItems", mainObject.MMJobTicketID, BOSApp.CurrentUsersInfo.ADUserName);
                            FilterDataByControl();
                            BOSApp.ShowMessage("Cập nhật thành công");
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public override void InvalidateToolbar()
        {
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)CurrentModuleEntity.MainObject;
            base.InvalidateToolbar();
            if (mainObject.MMJobTicketID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonAccounting, true);
                if (mainObject.MMJobTicketStatus == Status.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }
        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            MMJobTicketItemsGridControl fld_dgcMMJobTicketItems = (MMJobTicketItemsGridControl)Controls["fld_dgcMMJobTicketItems"];
            if (fld_dgcMMJobTicketItems == null) return;
            GridView gridView = (GridView)fld_dgcMMJobTicketItems.MainView;
            List<MMJobTicketItemsInfo> listView = new List<MMJobTicketItemsInfo>();
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;

            List<MMJobTicketItemsInfo> objects = new List<MMJobTicketItemsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(j);
                if (obj != null)
                {
                    objects.Add(obj);
                }
            }
            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(j);
                    if (obj != null)
                    {
                        listView.Add(obj);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }
                }
            }
            fld_dgcMMJobTicketItems?.RefreshDataSource();
        }
        #endregion
        #region Capacity
        public void UpdateReceiptCapacity(decimal qty)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            entity.JobTicketItem.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {

                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    bool iserror = false;

                    entity.JobTicketItem.ForEach(o =>
                    {
                        if (o.Selected &&
                            (o.MMJobTicketItemStatus == Status.Closed.ToString()
                            || o.MMJobTicketItemStatus == Status.Canceled.ToString()
                            || o.MMJobTicketItemStatus == Status.New.ToString()))
                        {
                            o.IsError = true;
                            iserror = true;
                        }
                    });
                    if (iserror)
                    {
                        BOSApp.ShowMessage("Chi tiết đã chọn có trạng thái không phù hợp!");
                        return;
                    }

                    entity.JobTicketItem.ForEach(o =>
                    {
                        if (o.Selected &&
                            (o.MMJobTicketItemStatus == Status.Closed.ToString()
                            || o.MMJobTicketItemStatus == Status.Canceled.ToString()
                            || o.MMJobTicketItemStatus == Status.New.ToString()))
                        {
                            if (o.MMJobTicketItemTodoQty - o.MMJobTicketItemReceiptQty < qty)
                            {
                                o.IsError = true;
                                iserror = true;
                            }
                        }
                    });
                    if (iserror)
                    {
                        BOSApp.ShowMessage("Số lượng lớn hơn SL còn lại có thể nhập!");
                        return;
                    }


                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn nhập các chi tiết đã chọn?") == DialogResult.Yes)
                    {
                        if (entity.JobTicketItem.Where(x => x.Selected).Count() > 0)
                        {
                            //SaveItemWithDataTableType.SaveItemWithoutDelete<MMJobTicketItemsInfo>(entity.JobTicketItem.Where(x => x.Selected).ToList(), "MMJobTicketItemID", "MMJobTicketItems", mainObject.MMJobTicketID);
                            //entity.JobTicketItem.GridControl.RefreshDataSource();
                            BOSApp.ShowMessage("Cập nhật thành công");
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }

        public void GetDefualtTicketDetail(List<MMJobTicketItemsInfo> JobTicketItem, decimal qty)
        {


            //MMOperationDetailPlanCapacityItemsController capacityCtrl = new MMOperationDetailPlanCapacityItemsController();
            //List<MMOperationDetailPlanCapacityItemsInfo> capacityList = capacityCtrl.SearchItemBySomeConditions
            //    (fromDate, toDate, productID, batchProductID, operationID, empGiveID, empTakeID, empQCID, productForBatchID);
        }
        #endregion
        #region InValidate data
        public void CheckExitCapacity(MMJobTicketItemsInfo item)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            MMJobTicketItemsController ctl = new MMJobTicketItemsController();
            List<MMJobTicketItemsInfo> list = ctl.GetListCapacityByJobTicket(mainObject.MMJobTicketID);
            if (item != null && list != null && list.Count > 0)
            {
                list.ForEach(o =>
                {
                    if (o.MMJobTicketItemID == item.MMJobTicketItemID)
                    {
                        item.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                        item.MMJobTicketItemReceiptQty = o.MMJobTicketItemReceiptQty;
                        item.MMJobTicketItemFailQty = o.MMJobTicketItemReceiptQty;
                    }
                });
            }
            else
            {
                foreach (MMJobTicketItemsInfo ticket in entity.JobTicketItem)
                {
                    list.ForEach(o =>
                    {
                        if (o.MMJobTicketItemID == ticket.MMJobTicketItemID)
                        {
                            ticket.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                            ticket.MMJobTicketItemReceiptQty = o.MMJobTicketItemReceiptQty;
                            ticket.MMJobTicketItemFailQty = o.MMJobTicketItemReceiptQty;
                        }
                    });
                }
                entity.JobTicketItem.GridControl?.RefreshDataSource();
            }
        }
        public List<MMOperationDetailPlanItemChildsInfo> GetPlanDetailRemain(int batchID
                                        , string planNo
                                        , DateTime? date
                                        , int MMWorkShopID
                                        , int MMLineID
                                        , int HRDepartmentRoomGroupItemID
                                        , int MMOperationID
                                        , int productForbatchID
                                        , int semiProductID
                                        )
        {
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)CurrentModuleEntity.MainObject;
            MMOperationDetailPlanItemChildsController controller = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> listResult = controller.GetPlanDetailRemain(batchID
                                        , planNo
                                        , date
                                        , MMWorkShopID
                                        , MMLineID
                                        , HRDepartmentRoomGroupItemID
                                        , MMOperationID
                                        , productForbatchID
                                        , semiProductID
                                        );
            return listResult;
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            FilterDataByControl();
        }
        public void FilterDataByControl()
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            if (entity.JobTicketItem.GridControl != null)
            {
                MMJobTicketItemsGridControl fld_dgcMMJobTicketItems = (MMJobTicketItemsGridControl)Controls["fld_dgcMMJobTicketItems"];
                BOSCheckEdit fld_chkStatusNew = (BOSCheckEdit)Controls["fld_chkStatusNew"];
                BOSCheckEdit fld_chkStatusCanceled = (BOSCheckEdit)Controls["fld_chkStatusCanceled"];
                BOSCheckEdit fld_chkStatusApproved = (BOSCheckEdit)Controls["fld_chkStatusApproved"];
                BOSCheckEdit fld_chkStatusClosed = (BOSCheckEdit)Controls["fld_chkStatusClosed"];
                if (fld_dgcMMJobTicketItems != null)
                {
                    FilterData(fld_dgcMMJobTicketItems, fld_chkStatusNew.Checked, fld_chkStatusCanceled.Checked, fld_chkStatusApproved.Checked, fld_chkStatusClosed.Checked);
                    entity.JobTicketItem.GridControl?.RefreshDataSource();
                }
            }
        }

        public void FilterData(MMJobTicketItemsGridControl fld_dgcMMJobTicketItems
                                                    , bool fld_chkStatusNew
                                                    , bool fld_chkStatusCanceled
                                                    , bool fld_chkStatusApproved
                                                    , bool fld_chkStatusClosed)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            GridView gridView = (GridView)fld_dgcMMJobTicketItems.MainView;

            List<GridColumn> lstColVisible = new List<GridColumn>();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                {
                    lstColVisible.Add(gridView.Columns[i]);
                }
            }
            List<MMJobTicketItemsInfo> bindingList = new List<MMJobTicketItemsInfo>();

            //Bind object list to grid for searching
            fld_dgcMMJobTicketItems.DataSource = entity.JobTicketItem;
            fld_dgcMMJobTicketItems.RefreshDataSource();

            for (int i = 0; i < entity.JobTicketItem.Count; i++)
            {

                MMJobTicketItemsInfo obj = entity.JobTicketItem[i];
                obj.Selected = false;
                if (obj.MMJobTicketItemStatus == Status.New.ToString())
                    if (fld_chkStatusNew && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMJobTicketItemStatus == Status.Canceled.ToString())
                    if (fld_chkStatusCanceled && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMJobTicketItemStatus == Status.Approved.ToString())
                    if (fld_chkStatusApproved && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMJobTicketItemStatus == Status.Closed.ToString())
                    if (fld_chkStatusClosed && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
            }
            fld_dgcMMJobTicketItems.DataSource = bindingList;
            fld_dgcMMJobTicketItems.RefreshDataSource();

        }
        #endregion

        #region Capacity

        public void UpdateJobticketQty()
        {

            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {
                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    bool error = false;
                    foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                    {
                        if (item.MMJobTicketItemStatus != Status.Approved.ToString()
                            && item.Selected)
                        {
                            item.IsError = true;
                            error = true;
                        }
                    }
                    if (error)
                    {
                        string mess = "Chi tiết bạn chọn trạng thái không phù hợp";
                        BOSApp.ShowMessage(mess);
                    }
                    else if (entity.JobTicketItem.Where(x => x.Selected).Count() > 0)
                    {
                        using (guiAddItemFromList gui = new guiAddItemFromList(entity.JobTicketItem.Where(x => x.Selected).ToList()))
                        {
                            gui.Module = this;
                            gui.WindowState = FormWindowState.Maximized;
                            gui.ShowDialog();

                            if (gui.DialogResult == DialogResult.OK)
                            {
                                Invalidate(mainObject.MMJobTicketID);
                            }
                        }

                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }

        public void UpdateJobticketQty(MMJobTicketItemsInfo obj)
        {

            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
            if (Toolbar.IsNullOrNoneAction() && mainObject.MMJobTicketID > 0)
            {
                if (obj.MMJobTicketItemStatus != Status.Approved.ToString())
                {
                    string mess = "Chi tiết bạn chọn trạng thái không phù hợp";
                    BOSApp.ShowMessage(mess);
                }
                else
                {
                    List<MMJobTicketItemsInfo> select = new List<MMJobTicketItemsInfo>();
                    select.Add(obj);
                    using (guiAddItemFromList gui = new guiAddItemFromList(select))
                    {
                        gui.Module = this;
                        gui.WindowState = FormWindowState.Maximized;
                        gui.ShowDialog();

                        if (gui.DialogResult == DialogResult.OK)
                        {
                            Invalidate(mainObject.MMJobTicketID);
                        }
                    }

                }
            }
        }
        public void UpdateEmployee()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
                MMJobTicketsInfo mainObject = (MMJobTicketsInfo)entity.MainObject;
                entity.JobTicketItem.EndCurrentEdit();
                if (entity.JobTicketItem.Where(o => o.Selected).Count() > 0)
                {
                    bool isError1 = false;
                    foreach (MMJobTicketItemsInfo item in entity.JobTicketItem)
                    {
                        if (item.Selected && item.MMJobTicketItemStatus != Status.New.ToString())
                        {
                            isError1 = true;
                        }
                    }
                    if (entity.JobTicketItem.Where(x => x.Selected).Count() > 0 && !isError1)
                    {
                        UpdateEmployee(entity.JobTicketItem.Where(x => x.Selected).ToList(), false);
                    }
                    else
                    {
                        BOSApp.ShowMessage("Chi tiết có trạng thái không phù hợp, bạn chỉ có thể xem dữ liệu!");
                        UpdateEmployee(entity.JobTicketItem.Where(x => x.Selected).ToList(), true);
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }

        public void UpdateEmployee(List<MMJobTicketItemsInfo> SelectTicketList, bool isView)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            List<string> roomIDList = SelectTicketList.Where(o => o.Selected).Select(i => i.FK_HRDepartmentRoomGroupItemID.ToString()).Distinct().ToList();
            if (roomIDList != null && roomIDList.Count > 0)
            {
                guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
                guiSearchEmployee.Module = this;
                guiSearchEmployee.roomIDList = roomIDList;
                guiSearchEmployee.TicketEmployeeSelectedList =
                    entity.JobTicketItemEmployeeList.Where(ep => SelectTicketList.Any(jtk => jtk.MMJobTicketItemAbstractID == ep.MMJobTicketItemEmployeeAbstract
                                    && jtk.FK_MMOperationDetailPlanItemChildID == ep.FK_MMOperationDetailPlanItemChildID
                                    && jtk.Selected)).ToList();

                if (guiSearchEmployee.ShowDialog() == DialogResult.OK && !isView)
                {
                    if (SelectTicketList.Where(o => o.Selected).ToList().Count > 0)
                    {
                        //List<MMJobTicketItemsInfo> jobItemList = SelectTicketList.Where(o =>
                        //    guiSearchEmployee.SelectedEmployeeList.Any(s => s.FK_HRDepartmentRoomGroupItemID == o.FK_HRDepartmentRoomGroupItemID)
                        //    && o.Selected).ToList();
                        //=> cho phép chọn khác tổ 
                        List<MMJobTicketItemsInfo> jobItemList = SelectTicketList.Where(o => o.Selected).ToList();

                        if (jobItemList != null && jobItemList.Count > 0)
                        {
                            List<MMJobTicketItemEmployeesInfo> exitList = entity.JobTicketItemEmployeeList.Where(ep =>
                                jobItemList.Any(jtk => jtk.MMJobTicketItemAbstractID == ep.MMJobTicketItemEmployeeAbstract
                                && jtk.FK_MMOperationDetailPlanItemChildID == ep.FK_MMOperationDetailPlanItemChildID)).ToList();


                            exitList.ForEach(ex =>
                            {
                                int iIdex = entity.JobTicketItemEmployeeList.IndexOf(ex);
                                if (iIdex >= 0)
                                {
                                    entity.JobTicketItemEmployeeList.RemoveAt(iIdex);
                                }
                            });
                        }
                        foreach (HREmployeesInfo objEmployeesInfo in guiSearchEmployee.SelectedEmployeeList)
                        {
                            // Nhân công chỉ phân bổ vào thẻ có cùng tổ

                            if (jobItemList != null && jobItemList.Count > 0)
                            {
                                jobItemList.ForEach(o =>
                                {
                                    if (o.MMJobTicketItemAbstractID > 0)
                                    {
                                        if (entity.JobTicketItemEmployeeList.Where(ep => ep.FK_HREmployeeID == objEmployeesInfo.HREmployeeID
                                                                                    && ep.MMJobTicketItemEmployeeAbstract == o.MMJobTicketItemAbstractID
                                                                                    && ep.FK_MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID).FirstOrDefault() == null)
                                        {
                                            MMJobTicketItemEmployeesInfo epl = new MMJobTicketItemEmployeesInfo();
                                            epl.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                            epl.MMJobTicketItemEmployeeAbstract = o.MMJobTicketItemAbstractID;
                                            epl.FK_MMOperationDetailPlanItemChildID = o.FK_MMOperationDetailPlanItemChildID;
                                            epl.FK_MMJobTicketItemID = o.MMJobTicketItemID;
                                            entity.JobTicketItemEmployeeList.Add(epl);
                                        }
                                    }
                                });
                            }
                        }

                    }

                }
            }
        }

        public void GetDataEmployee(MMJobTicketItemsInfo selected, bool isView)
        {
            JobTicketEntities entity = (JobTicketEntities)CurrentModuleEntity;
            List<string> roomIDList = new List<string>();
            roomIDList.Add(selected.FK_HRDepartmentRoomGroupItemID.ToString());
            if (roomIDList != null && roomIDList.Count > 0)
            {
                guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
                guiSearchEmployee.Module = this;
                guiSearchEmployee.roomIDList = roomIDList;
                guiSearchEmployee.TicketEmployeeSelectedList =
                    entity.JobTicketItemEmployeeList.Where(ep => ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).ToList();
                if (guiSearchEmployee.ShowDialog() == DialogResult.OK && !isView)
                {

                    List<MMJobTicketItemEmployeesInfo> unSelected =
                        entity.JobTicketItemEmployeeList.Where(ep => ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).ToList();
                    if (unSelected != null && unSelected.Count > 0)
                    {
                        unSelected.ForEach(u =>
                        {
                            HREmployeesInfo selectEmployee = guiSearchEmployee.SelectedEmployeeList.Where(s => s.HREmployeeID == u.FK_HREmployeeID).FirstOrDefault();
                            if (selectEmployee == null)
                            {
                                int iIndex = entity.JobTicketItemEmployeeList.IndexOf(u);
                                if (iIndex >= 0)
                                    entity.JobTicketItemEmployeeList.RemoveAt(iIndex);
                            }
                        });
                    }

                    foreach (HREmployeesInfo objEmployeesInfo in guiSearchEmployee.SelectedEmployeeList)
                    {
                        // Nhân công chỉ phân bổ vào thẻ có cùng tổ
                        if (selected.MMJobTicketItemAbstractID > 0)
                        {
                            if (entity.JobTicketItemEmployeeList.Where(ep => ep.FK_HREmployeeID == objEmployeesInfo.HREmployeeID
                                                                        && ep.MMJobTicketItemEmployeeAbstract == selected.MMJobTicketItemAbstractID
                                                                        && ep.FK_MMOperationDetailPlanItemChildID == selected.FK_MMOperationDetailPlanItemChildID).FirstOrDefault() == null)
                            {
                                MMJobTicketItemEmployeesInfo epl = new MMJobTicketItemEmployeesInfo();
                                epl.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                                epl.MMJobTicketItemEmployeeAbstract = selected.MMJobTicketItemAbstractID;
                                epl.FK_MMOperationDetailPlanItemChildID = selected.FK_MMOperationDetailPlanItemChildID;
                                epl.FK_MMJobTicketItemID = selected.MMJobTicketItemID;
                                entity.JobTicketItemEmployeeList.Add(epl);
                            }
                        }
                    }
                }
            }

        }
        #endregion
    }
}
