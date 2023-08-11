using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public partial class guiAddItemFromList : BOSERPScreen
    {
        int EmpGiveID = 0;
        int EmpTakeID = 0;
        int EmpQCID = 0;
        public int FK_MMOperationDetailPlanItemChildID { get; set; }
        DateTime Date;
        public List<MMJobTicketItemsInfo> JobTicketItemList { get; set; }
        public List<MMOperationDetailPlanCapacityItemsInfo> DataList { get; set; }
        public List<MMBatchProductProductionNormItemProcesssInfo> CurrentProcessOperationList = null;
        public guiAddItemFromList(List<MMJobTicketItemsInfo> ListJobTicketItem)
        {
            InitializeComponent();
            if (DataList == null)
                DataList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            JobTicketItemList = ListJobTicketItem;
            if (CurrentProcessOperationList == null)
                CurrentProcessOperationList = new List<MMBatchProductProductionNormItemProcesssInfo>();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void guiChooseOperationDetailPlanItemOperation_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            if (Date.Date == DateTime.MinValue.Date || Date.Date == DateTime.MaxValue.Date)
                fld_dteDate.EditValue = DateTime.Now;
            else
                fld_dteDate.EditValue = Date;
            fld_lkeHREmployeeGiveID.EditValue = EmpGiveID;
            fld_lkeHREmployeeTakeID.EditValue = EmpTakeID;
            fld_lkeHREmployeeQCID.EditValue = EmpQCID;
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            if (DataList == null)
                DataList = new List<MMOperationDetailPlanCapacityItemsInfo>();

            GetData();
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }
        private void fld_btnUpdateDetail_Click(object sender, EventArgs e)
        {
            int EmpGiveID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeGiveID);
            int EmpTakeID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeTakeID);
            int EmpQCID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeQCID);
            bool isError = false;
            if (DataList.Where(o => o.Selected).Count() > 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    DataList.ForEach(o =>
                    {
                        if (o.Selected
                            && (o.MMOperationDetailPlanCapacityItemPlanProductQty - o.MMOperationDetailPlanCapacityItemCompletedProductQty)
                            < o.MMOperationDetailPlanCapacityItemProductQty) { o.IsError = true; isError = true; }
                    });
                    if (isError)
                    {
                        BOSApp.ShowMessage("SL nhập vượt SL còn lại!");
                        return;
                    }
                    DataList.ForEach(o =>
                    {
                        if (o.Selected)
                        {
                            o.FK_HREmployeeGiveID = EmpGiveID;
                            o.FK_HREmployeeTakeID = EmpTakeID;
                            o.FK_HREmployeeQCID = EmpQCID;
                        }
                    });

                    fld_dgcMMOperationDetailPlanCapacityItemsGridControl.RefreshDataSource();
                }
            }
            else
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
        }

        public List<MMOperationsInfo> ReloadOperationLookupDataSource(int batchProductID)
        {
            MMBatchProductProductionNormItemProcesssController pCtrl
                = new MMBatchProductProductionNormItemProcesssController();

            CurrentProcessOperationList = pCtrl.GetProcessOperationByBatchProductIDForCapacity(batchProductID);

            MMOperationsController oCtrl = new MMOperationsController();
            List<MMOperationsInfo> oList = oCtrl.GetForCapacityByBatchProductID(batchProductID);

            return oList;
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<MMOperationDetailPlanCapacityItemsInfo> fillterList = (List<MMOperationDetailPlanCapacityItemsInfo>)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource;
            if (fillterList.Where(i => i.MMOperationDetailPlanCapacityItemProductQty > 0
                || i.MMOperationDetailPlanCapacityItemFailProductQty > 0).ToList().Count > 0)
            {

                List<MMOperationDetailPlanCapacityItemsInfo> CheckList = fillterList.Where(i => (i.MMOperationDetailPlanCapacityItemProductQty > 0
                                                                                              || i.MMOperationDetailPlanCapacityItemFailProductQty > 0)
                                                                                    && (i.FK_HREmployeeGiveID == 0 || i.FK_HREmployeeTakeID == 0 || i.FK_HREmployeeQCID == 0)).ToList();
                if (CheckList != null && CheckList.Count > 0)
                {
                    CheckList.ForEach(er => er.IsError = true);
                    BOSApp.ShowMessage("Người giao, người nhận, QC không thể để trống!");
                }
                else
                {
                    SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanCapacityItemsInfo>(fillterList.Where(i =>
                        i.MMOperationDetailPlanCapacityItemProductQty > 0
                     || i.MMOperationDetailPlanCapacityItemFailProductQty > 0).ToList(), "MMOperationDetailPlanCapacityItemID", "MMOperationDetailPlanCapacityItems", 0, BOSApp.CurrentUsersInfo.ADUserName);

                    BOSApp.ShowMessage("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            }
            else
            {
                BOSApp.ShowMessage("Vui lòng nhập SL chi tiết!");
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool IsOperationSyncProductCheck(int operationID)
        {
            MMOperationsController operationCtrl = new MMOperationsController();
            DataRow row = BOSApp.GetObjectFromCatche("MMOperations", "MMOperationID", operationID);
            MMOperationsInfo operation = row != null ? (MMOperationsInfo)operationCtrl.GetObjectFromDataRow(row) : null;
            if (operation != null)
                return operation.MMOperationSyncProductCheck;
            return false;
        }
        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            Date = fld_dteDate.DateTime;
            MMJobTicketItemsController pController = new MMJobTicketItemsController();
            List<MMJobTicketItemsInfo> pList = pController.GetProductForCapacityByJobTicketItemID(
                string.Join(",", JobTicketItemList.Where(o => o.Selected).Select(j => j.MMJobTicketItemID.ToString()).ToArray()));
            DataList.Clear();
            foreach (MMJobTicketItemsInfo item in pList)
            {
                MMOperationDetailPlanCapacityItemsInfo objODInfo = new MMOperationDetailPlanCapacityItemsInfo();
                objODInfo.FK_ICProductID = item.ICProductID;
                objODInfo.MMOperationDetailPlanCapacityItemProductName = item.ICProductName;
                objODInfo.FK_MMLineID = item.FK_MMLineID;
                objODInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                objODInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                objODInfo.FK_MMOperationID = item.MMOperationID;
                objODInfo.FK_HREmployeeGiveID = EmpGiveID;
                objODInfo.FK_HREmployeeTakeID = EmpTakeID;
                objODInfo.FK_HREmployeeQCID = EmpQCID;
                objODInfo.MMOperationDetailPlanCapacityItemDate = Date;
                objODInfo.MMOperationDetailPlanCapacityItemPlanProductQty = item.MMJobTicketItemTodoQty;
                objODInfo.MMOperationDetailPlanCapacityItemProductQty = 0;
                objODInfo.MMOperationDetailPlanCapacityItemRemainProductQty = item.MMJobTicketItemTodoQty - item.MMJobTicketItemReceiptQty;
                objODInfo.MMOperationDetailPlanCapacityItemCompletedProductQty = item.MMJobTicketItemReceiptQty;
                objODInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                objODInfo.MMOperationID = item.FK_MMOperationID;
                objODInfo.MMOperationOrder = item.MMOperationOrder;
                objODInfo.MMOperationDetailPlanCapacityItemIsBeginOperation = item.IsBeginOperation;
                objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = item.InOutStockCheck;
                objODInfo.MMOperationDetailPlanCapacityItemParentProductDesc = item.ICProductParentDesc;
                objODInfo.MMOperationDetailPlanCapacityItemParentProductName = item.ICProductParentName;
                objODInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                objODInfo.MMJobTicketItemGroup = item.MMJobTicketItemGroup;
                objODInfo.FK_MMJobTicketItemID = item.MMJobTicketItemID;
                objODInfo.FK_MMOperationDetailPlanItemChildID = item.FK_MMOperationDetailPlanItemChildID;
                DataList.Add(objODInfo);
            }
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource = DataList;
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.RefreshDataSource();
        }
        private void fld_chkSelectAllOperationDetailPlanItemOperation_CheckedChanged(object sender, EventArgs e)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> fillterList = (List<MMOperationDetailPlanCapacityItemsInfo>)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource;
            fillterList.ForEach(i => i.Selected = fld_chkSelectAllOperationDetailPlanItemOperation.Checked);
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource = fillterList;
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.RefreshDataSource();
        }


    }
}
