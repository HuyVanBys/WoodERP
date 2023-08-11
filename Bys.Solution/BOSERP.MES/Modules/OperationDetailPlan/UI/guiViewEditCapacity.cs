using BOSCommon;
using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiViewEditCapacity : BOSERPScreen
    {
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int OperationID { get; set; }
        public int NormID { get; set; }
        public int BatchID { get; set; }
        public int ProductOfBatchID { get; set; }
        public string SemiProductNo { get; set; }
        public string SemiProductName { get; set; }
        public List<MMOperationDetailPlanCapacityItemsInfo> EditDataList { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> SelectedTicketHuman { get; set; }
        public List<MMCapacityHumanUnitsInfo> HumanList { get; set; }
        public List<MMMachineUnitsInfo> SelectedTicketMachine { get; set; }
        public List<MMOperationsInfo> OperationList { get; set; }
        public List<MMOperationsInfo> OperationSelectList { get; set; }
        public guiViewEditCapacity()
        {
            InitializeComponent();
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
        private void guiViewEditCapacity_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            if (EditDataList == null) EditDataList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            SelectedTicketHuman = new List<HRDepartmentRoomGroupItemsInfo>();
            SelectedTicketMachine = new List<MMMachineUnitsInfo>();
            HumanList = new List<MMCapacityHumanUnitsInfo>();
            OperationSelectList = new List<MMOperationsInfo>();
            if (OperationList == null) OperationList = new List<MMOperationsInfo>();
            fld_dgcViewEditCapacityGridControl.DataSource = EditDataList;
            if (NormID > 0)
            {
                fld_dteFromDate.DateTime = Fromdate;
                fld_dteToDate.DateTime = Todate;
                fld_txtSemiProductNo.Text = SemiProductNo;
                fld_txtSemiProductName.Text = SemiProductName;
                fld_lkeMMBatchProductID.EditValue = BatchID;
                fld_lkeICProductForBatchID.EditValue = ProductOfBatchID;
            }
            DataSet ds;
            List<MMOperationsInfo> listOp = new List<MMOperationsInfo>();
            MMOperationsController control = new MMOperationsController();
            if (BOSApp.LookupTables.ContainsKey(TableName.MMOperationsTableName))
            {
                ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null)
                {
                    listOp = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                }
            }
            else
            {
                listOp = control.GetPlanOperationsByUserID(BOSApp.CurrentCompanyInfo.FK_BRBranchID, BOSApp.CurrentUsersInfo.ADUserID);
            }
            OperationList = listOp;
            MMOperationsInfo Operation = listOp.Where(o => o.MMOperationID == OperationID).FirstOrDefault();
            if (Operation == null) Operation = listOp.Where(o => o.MMOperationParentID == OperationID).FirstOrDefault();
            if (Operation != null)
            {
                OperationSelectList.Add(Operation);
                fld_bteViewEditOperation.EditValue = Operation.MMOperationName;
            }
            SearchData();
            NormID = 0;
            OperationID = 0;

            fld_dgcViewEditCapacityGridControl.RefreshDataSource();
        }
        public void ShowHumanUnit()
        {
            guiChooseHumanUnit gui = new guiChooseHumanUnit();
            gui.DetailPlanSelected = new List<MMBatchProductProductionNormItemsViewInfo>();
            gui.Module = this.Module;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                SelectedTicketHuman = gui.ResultList;
            }
        }
        public void ShowMachineUnit()
        {
            guiChooseMachineUnit gui = new guiChooseMachineUnit();
            gui.DetailPlanSelected = new List<MMBatchProductProductionNormItemsViewInfo>();
            gui.Module = this.Module;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                SelectedTicketMachine = gui.ResultList;
            }
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Fld_chkAllCapacity_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkAllCapacity.Checked);
            fld_dgcViewEditCapacityGridControl.RefreshDataSource();
        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcViewEditCapacityGridControl.MainView;
            List<MMOperationDetailPlanCapacityItemsInfo> listView = new List<MMOperationDetailPlanCapacityItemsInfo>();

            List<MMOperationDetailPlanCapacityItemsInfo> objects = new List<MMOperationDetailPlanCapacityItemsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanCapacityItemsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    objects.Add(objDataViewPermissionsInfo);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanCapacityItemsInfo objDataViewPermissionsInfo = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
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
        }

        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        public void SearchData()
        {
            DateTime fromdate = fld_dteFromDate.DateTime;
            DateTime todate = fld_dteToDate.DateTime;
            int batchID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
            {
                Int32.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchID);
            }
            int productOfBatchID = 0;
            if (fld_lkeICProductForBatchID.EditValue != null)
            {
                Int32.TryParse(fld_lkeICProductForBatchID.EditValue.ToString(), out productOfBatchID);
            }
            string operationID = string.Join(",", OperationSelectList.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());

            string humanID = string.Empty;
            string machineID = string.Empty;

            string semiProductNo = fld_txtSemiProductNo.EditValue != null ? fld_txtSemiProductNo.EditValue.ToString().Trim() : string.Empty;
            string semiProductName = fld_txtSemiProductName.EditValue != null ? fld_txtSemiProductName.EditValue.ToString().Trim() : string.Empty;

            MMOperationDetailPlanCapacityItemsController ctroler = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> listItem = ctroler.GetHistoryCapacityBySomeCriteria(fromdate
                                                                                                            , todate
                                                                                                            , batchID
                                                                                                            , productOfBatchID
                                                                                                            , operationID
                                                                                                            , humanID
                                                                                                            , machineID
                                                                                                            , semiProductNo
                                                                                                            , semiProductName
                                                                                                            , NormID);
            if (listItem != null)
            {
                HumanList = (new MMCapacityHumanUnitsController()).GetHistoryCapacityBySomeCriteria(fromdate
                                                                                                            , todate
                                                                                                            , batchID
                                                                                                            , productOfBatchID
                                                                                                            , operationID
                                                                                                            , humanID
                                                                                                            , machineID
                                                                                                            , semiProductNo
                                                                                                            , semiProductName
                                                                                                            , NormID);

                fld_dgcViewEditCapacityGridControl.DataSource = listItem;
                fld_dgcViewEditCapacityGridControl.RefreshDataSource();
            }
        }
        public void ShowOperation()
        {
            guiChooseOperation guiOperation = new guiChooseOperation();
            guiOperation.OperationItemDataList = OperationList;
            guiOperation.OperationDataSelected = OperationSelectList;
            guiOperation.Module = this.Module;
            guiOperation.ShowDialog();
            if (guiOperation.DialogResult == DialogResult.OK)
            {
                OperationSelectList = guiOperation.ResultList;
            }
            if (OperationSelectList != null)
                fld_bteViewEditOperation.EditValue = string.Join(",", OperationSelectList.Select(o => o.MMOperationName).ToArray());
        }
        private void Fld_btnCreateReceipt_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcViewEditCapacityGridControl.MainView;
            List<MMOperationDetailPlanCapacityItemsInfo> selectedList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            if (gridView != null)
            {
                List<object> filterList = new List<object>();
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object obj in filterList)
                    {
                        MMOperationDetailPlanCapacityItemsInfo capObj = (MMOperationDetailPlanCapacityItemsInfo)obj;
                        if (capObj != null && capObj.Selected)
                            selectedList.Add(capObj);
                    }
            }
            bool isNotSave = false;
            bool isErrorStatus = false;
            foreach (MMOperationDetailPlanCapacityItemsInfo item in selectedList)
            {
                if (item.MMOperationDetailPlanCapacityItemProductQty != item.MMOperationDetailPlanCapacityItemCompletedProductQty)
                    isNotSave = true;
                if (item.ItemStatus == Status.Canceled.ToString() || item.ItemStatus == Status.Closed.ToString())
                    isErrorStatus = true;
            }
            if (isNotSave)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chưa lưu thay đổi, bạn có muốn tạo phiếu nhập không?") == DialogResult.No)
                    return;
            }
            if (isErrorStatus)
            {
                BOSApp.ShowMessage("Tình trạng thẻ không phù hợp.");
                return;
            }
            if (selectedList != null && selectedList.Count > 0)
            {
                bool ErrorHasNotReceipt = false;
                bool ErrorQuantity = false;
                bool ErrorSameBatch = false;
                bool ErrorSameOperation = false;
                bool ErrorExitReceipt = false;
                //int batchID = selectedList[0].FK_MMBatchProductID;
                //int OperationID = selectedList[0].FK_MMOperationID;
                foreach (MMOperationDetailPlanCapacityItemsInfo item in selectedList)
                {
                    if (!item.MMOperationDetailPlanCapacityItemHasReceipt)
                    {
                        item.IsError = true;
                        ErrorHasNotReceipt = true;
                    }
                    if (item.MMOperationDetailPlanCapacityItemProductQty <= 0)
                    {
                        item.IsError = true;
                        ErrorQuantity = true;
                    }
                    //if (item.FK_MMBatchProductID != batchID)
                    //{
                    //    item.IsError = true;
                    //    ErrorSameBatch = true;
                    //}
                    //if (item.FK_MMOperationID != OperationID)
                    //{
                    //    item.IsError = true;
                    //    ErrorSameOperation = true;
                    //}
                    if (item.MMOperationDetailPlanCapacityItemProductQty - item.MMOperationDetailPlanCapacityItemCapacityProductQty <= 0)
                    {
                        item.IsError = true;
                        ErrorExitReceipt = true;
                    }
                }
                if (!ErrorHasNotReceipt && !ErrorQuantity && !ErrorSameBatch && !ErrorSameOperation && !ErrorExitReceipt)
                {
                    BaseModuleERP SemiProductReceipt = BaseModuleFactory.GetModule("SemiProductReceipt");
                    if (SemiProductReceipt != null)
                    {
                        SemiProductReceipt = BOSApp.ShowModule("SemiProductReceipt");

                        ICProductsInfo obj = BOSApp.GetProductFromCurrentProductList(selectedList[0].FK_ICProductID);
                        SemiProductReceipt.CallFunctionFromAnotherProject(selectedList, obj != null ? obj.ICProductType : "Product");
                        this.Close();
                    }
                }
                else
                {
                    string mess = "Có lỗi xảy ra, chi tiết bạn chọn: ";

                    if (ErrorHasNotReceipt) mess += Environment.NewLine + "Không cho phép nhập kho";
                    if (ErrorQuantity) mess += Environment.NewLine + "Số lượng nhập <=0";
                    //if (ErrorSameBatch) mess += Environment.NewLine + "Không cùng lệnh sản xuất";
                    //if (ErrorSameOperation) mess += Environment.NewLine + "Không cùng công đoạn";
                    if (ErrorExitReceipt) mess += Environment.NewLine + "Số lượng lớn hơn còn lại có thể nhập";
                    BOSApp.ShowMessage(mess);
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }

        }
        private void Fld_btnCreateErrorReceipt_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcViewEditCapacityGridControl.MainView;
            List<MMOperationDetailPlanCapacityItemsInfo> selectedList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            if (gridView != null)
            {
                List<object> filterList = new List<object>();
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object obj in filterList)
                    {
                        MMOperationDetailPlanCapacityItemsInfo capObj = (MMOperationDetailPlanCapacityItemsInfo)obj;
                        if (capObj != null && capObj.Selected)
                            selectedList.Add(capObj);
                    }
            }
            bool isNotSave = false;
            bool isErrorStatus = false;
            foreach (MMOperationDetailPlanCapacityItemsInfo item in selectedList)
            {
                if (item.MMOperationDetailPlanCapacityItemProductQty != item.MMOperationDetailPlanCapacityItemCompletedProductQty)
                    isNotSave = true;
                if (item.ItemStatus == Status.Canceled.ToString() || item.ItemStatus == Status.Closed.ToString())
                    isErrorStatus = true;
            }
            if (isNotSave)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chưa lưu thay đổi, bạn có muốn tạo phiếu nhập không?") == DialogResult.No)
                    return;
            }
            if (isErrorStatus)
            {
                BOSApp.ShowMessage("Tình trạng thẻ không phù hợp.");
                return;
            }
            if (selectedList != null && selectedList.Count > 0)
            {
                bool ErrorQuantity = false;
                bool ErrorSameBatch = false;
                bool ErrorSameOperation = false;
                bool ErrorExitReceipt = false;
                foreach (MMOperationDetailPlanCapacityItemsInfo item in selectedList)
                {
                    if (item.MMOperationDetailPlanCapacityItemFailProductQty <= 0)
                    {
                        item.IsError = true;
                        ErrorQuantity = true;
                    }

                    if (item.MMOperationDetailPlanCapacityItemFailProductQty - item.MMOperationDetailPlanCapacityItemFailReceiptQty <= 0)
                    {
                        item.IsError = true;
                        ErrorExitReceipt = true;
                    }
                }
                if (!ErrorQuantity && !ErrorSameBatch && !ErrorSameOperation && !ErrorExitReceipt)
                {
                    BaseModuleERP Receipt = BaseModuleFactory.GetModule("Receipt");
                    if (Receipt != null)
                    {
                        Receipt = BOSApp.ShowModule("Receipt");
                        selectedList.ForEach(s => s.FK_ICProductID = 0);
                        ICProductsInfo obj = BOSApp.GetProductFromCurrentProductList(selectedList[0].FK_ICProductID);
                        Receipt.CallFunctionFromAnotherProject(selectedList, obj != null ? obj.ICProductType : "Product");
                        this.Close();
                    }
                }
                else
                {
                    string mess = "Có lỗi xảy ra, chi tiết bạn chọn: ";

                    if (ErrorQuantity) mess += Environment.NewLine + "Số lượng không đạt <=0";
                    if (ErrorExitReceipt) mess += Environment.NewLine + "Số lượng lớn hơn còn lại có thể nhập";
                    BOSApp.ShowMessage(mess);
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }

        }
        private void Fld_bteViewEditOperation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ShowOperation();
        }

        private void fld_btnClear_Click(object sender, EventArgs e)
        {
            fld_lkeMMBatchProductID.EditValue = 0;
            fld_lkeICProductForBatchID.EditValue = 0;
            fld_txtSemiProductNo.EditValue = string.Empty;
            fld_txtSemiProductName.EditValue = string.Empty;
        }
    }
}
