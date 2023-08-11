using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public partial class guiAddItemFromList : BOSERPScreen
    {
        int BatchProductID = 0;
        int OperationID = 0;
        int EmpGiveID = 0;
        int EmpTakeID = 0;
        int EmpQCID = 0;
        public int FK_MMOperationDetailPlanItemChildID { get; set; }
        bool IsBeginOperation = false;
        bool HasReceipt = false;
        DateTime Date;
        public List<MMOperationDetailPlanCapacityItemsInfo> DataList { get; set; }
        public guiAddItemFromList(int batchProductID, int operationID, int empGiveID, int empTakeID, int empQCID, DateTime date, bool isBeginOperation, bool hasReceipt)
        {
            InitializeComponent();
            OperationID = operationID;
            BatchProductID = batchProductID;
            Date = date;
            EmpGiveID = empGiveID;
            EmpTakeID = empTakeID;
            EmpQCID = empQCID;
            IsBeginOperation = isBeginOperation;
            HasReceipt = hasReceipt;
            if (DataList == null)
                DataList = new List<MMOperationDetailPlanCapacityItemsInfo>();
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
            fld_lkeFK_MMOperationID.EditValue = OperationID;
            fld_lkeMMBatchProductID.EditValue = BatchProductID;
            fld_dteDate.EditValue = Date;
            fld_lkeHREmployeeGiveID.EditValue = EmpGiveID;
            fld_lkeHREmployeeTakeID.EditValue = EmpTakeID;
            fld_lkeHREmployeeQCID.EditValue = EmpQCID;
            fld_ckeBeginOperation.Checked = IsBeginOperation;
            fld_ckeHasReceipt.Checked = HasReceipt;
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.OperationDetailPlanItemChildsList.InitBOSListGridControl(fld_dgcMMOperationDetailPlanCapacityItemsGridControl);
            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.MainView;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            if (DataList == null)
                DataList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();

        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<MMOperationDetailPlanCapacityItemsInfo> fillterList = (List<MMOperationDetailPlanCapacityItemsInfo>)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource;
            if (fillterList.Where(i => i.Selected).ToList().Count > 0)
                entity.OperationDetailPlanCapacityItemsList.AddRange(fillterList.Where(i => i.Selected).ToList());
            entity.OperationDetailPlanCapacityItemsList.GridControl?.RefreshDataSource();
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            OperationID = BOSApp.GetIntFromLookupEdit(fld_lkeFK_MMOperationID);
            bool isSyncProductCheck = ((OperationDetailPlanCapacityModule)Module).IsOperationSyncProductCheck(OperationID);
            BatchProductID = BOSApp.GetIntFromLookupEdit(fld_lkeMMBatchProductID);
            Date = fld_dteDate.DateTime;
            EmpGiveID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeGiveID);
            EmpTakeID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeTakeID);
            EmpQCID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeQCID);
            HREmployeesController empController = new HREmployeesController();
            HREmployeesInfo empGive = (HREmployeesInfo)empController.GetObjectByID(EmpGiveID);
            if (empGive == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn Người giao");
                return;
            }
            HREmployeesInfo empTake = (HREmployeesInfo)empController.GetObjectByID(EmpTakeID);
            if (empTake == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn Người nhận");
                return;
            }
            if (empGive != null && empGive.FK_HRDepartmentRoomGroupItemID == 0)
            {
                BOSApp.ShowMessage("Vui lòng xác định Tổ của Người giao");
                return;
            }
            if (empTake != null && empTake.FK_HRDepartmentRoomGroupItemID == 0)
            {
                BOSApp.ShowMessage("Vui lòng xác định Tổ của Người nhận");
                return;
            }
            ICProductsController pController = new ICProductsController();
            List<ICProductsInfo> pList = pController.GetProductForCapacityByBatchProductIDAndOperationID(Convert.ToInt32(fld_lkeMMBatchProductID.EditValue), Convert.ToInt32(fld_lkeFK_MMOperationID.EditValue), isSyncProductCheck);
            DataList.Clear();
            foreach (ICProductsInfo item in pList)
            {
                MMOperationDetailPlanCapacityItemsInfo objODInfo = new MMOperationDetailPlanCapacityItemsInfo();
                objODInfo.FK_ICProductID = item.ICProductID;
                objODInfo.MMOperationDetailPlanCapacityItemProductName = item.ICProductName;
                objODInfo.FK_MMLineID = item.FK_MMLineID;
                objODInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                objODInfo.FK_MMBatchProductID = BatchProductID;
                objODInfo.FK_MMOperationID = OperationID;
                objODInfo.FK_HREmployeeGiveID = EmpGiveID;
                objODInfo.FK_HREmployeeTakeID = EmpTakeID;
                objODInfo.FK_HREmployeeQCID = EmpQCID;
                objODInfo.MMOperationDetailPlanCapacityItemDate = Date;
                objODInfo.MMOperationDetailPlanCapacityItemProductQty = 0;
                objODInfo.FK_HRDepartmentRoomGroupItemID = empGive.FK_HRDepartmentRoomGroupItemID;
                objODInfo.FK_HRToDepartmentRoomGroupItemID = empTake.FK_HRDepartmentRoomGroupItemID;
                if (fld_ckeDefaultByProcess.Checked)
                {
                    MMBatchProductProductionNormItemProcesssInfo process
                         = ((OperationDetailPlanCapacityModule)Module).CurrentProcessOperationList.FirstOrDefault(t => t.FK_MMOperationID == OperationID
                                                                        && t.FK_ICProductID == item.ICProductID);
                    if (process != null)
                    {
                        objODInfo.MMOperationDetailPlanCapacityItemIsBeginOperation = process.MMBatchProductProductionNormItemProcessIsBeginOperation;
                        objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = process.MMBatchProductProductionNormItemProcessInOutStockCheck;
                    }
                }
                else
                {
                    objODInfo.MMOperationDetailPlanCapacityItemIsBeginOperation = fld_ckeBeginOperation.Checked;
                    objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = fld_ckeHasReceipt.Checked;
                }

                objODInfo.MMOperationDetailPlanCapacityItemParentProductDesc = item.ICProductParentDesc;
                objODInfo.MMOperationDetailPlanCapacityItemParentProductName = item.ICProductParentName;
                objODInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                DataList.Add(objODInfo);
            }
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource = DataList;
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl?.RefreshDataSource();

        }

        private void fld_chkSelectAllOperationDetailPlanItemOperation_CheckedChanged(object sender, EventArgs e)
        {
            List<MMOperationDetailPlanCapacityItemsInfo> fillterList = (List<MMOperationDetailPlanCapacityItemsInfo>)fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource;
            fillterList.ForEach(i => i.Selected = fld_chkSelectAllOperationDetailPlanItemOperation.Checked);
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl.DataSource = fillterList;
            fld_dgcMMOperationDetailPlanCapacityItemsGridControl?.RefreshDataSource();
        }

        private void fld_lkeMMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            int batchProductID = 0;
            if (e.Value != null)
            {
                int.TryParse(e.Value.ToString(), out batchProductID);
            }
            fld_lkeFK_MMOperationID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module).ReloadOperationLookupDataSource(batchProductID);
            fld_lkeFK_MMOperationID.EditValue = null;
        }

        private void fld_ckeDefaultByProcess_CheckedChanged(object sender, EventArgs e)
        {
            fld_ckeHasReceipt.Enabled = !fld_ckeDefaultByProcess.Checked;
            fld_ckeBeginOperation.Enabled = !fld_ckeDefaultByProcess.Checked;
        }

    }
}
