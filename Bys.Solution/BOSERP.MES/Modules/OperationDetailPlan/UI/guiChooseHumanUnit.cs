using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiChooseHumanUnit : BOSERPScreen
    {
        public List<MMDetailPlanHumanUnitsInfo> HumanUnitList { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> RoomGroupItemDataList { get; set; }
        public List<MMBatchProductProductionNormItemsViewInfo> DetailPlanSelected { get; set; }
        public BOSTreeList RoomGroupItemList { get; set; }
        public BindingList<HRDepartmentRoomGroupItemsInfo> bindingListSource { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> ResultList { get; set; }
        public guiChooseHumanUnit()
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
        private void guiChooseHumanUnit_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ResultList = new List<HRDepartmentRoomGroupItemsInfo>();
            InitDataSourceOperations();
            int departmentID = 0;
            int departmentRoomID = 0;
            int departmentRoomGroupItemID = 0;
            int employeeID = 0;
            string operationID = fld_cmbOperations.EditValue != null ? fld_cmbOperations.EditValue.ToString() : null;

            GetTreeDataSource(departmentID, departmentRoomID, departmentRoomGroupItemID, employeeID, operationID);
            #region InitTreeList
            bindingListSource = new BindingList<HRDepartmentRoomGroupItemsInfo>();
            RoomGroupItemDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlGroupItems.KeyFieldName = "HRDepartmentRoomGroupItemID";
            fld_trlGroupItems.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            fld_trlGroupItems.Columns.Clear();
            AddTreeListColumns(fld_trlGroupItems, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(fld_trlGroupItems, 1, "HRDepartmentRoomGroupItemNo", "Mã tổ", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 2, "HRDepartmentRoomGroupItemName", "Tên tổ", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 3, "HREmployeeNo", "Mã nhân viên", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 4, "HREmployeeName", "Tên nhân viên", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 5, "HRDepartmentName", "Phòng ban", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 6, "HRDepartmentRoomName", "Bộ phận", true, false, string.Empty, false);
            fld_trlGroupItems.OptionsView.ShowSummaryFooter = true;
            fld_trlGroupItems.OptionsBehavior.ImmediateEditor = true;
            fld_trlGroupItems.OptionsCustomization.AllowFilter = true;
            fld_trlGroupItems.OptionsNavigation.UseTabKey = true;
            fld_trlGroupItems.OptionsView.ShowAutoFilterRow = true;
            fld_trlGroupItems.DataSource = bindingListSource;
            fld_trlGroupItems.CellValueChanging += Fld_trlGroupItems_CellValueChanging;
            fld_trlGroupItems.ForceInitialize();
            if (DetailPlanSelected != null && DetailPlanSelected.Count > 0)
                InvalidateSelectNode();
            fld_trlGroupItems.RefreshDataSource();
            fld_trlGroupItems.ExpandAll();
            #endregion
        }

        public void InvalidateSelectNode()
        {
            TreeListColumn col = fld_trlGroupItems.Columns["Selected"];
            if (fld_trlGroupItems.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlGroupItems.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.HREmployeeID > 0)
                        if (DetailPlanSelected != null)
                            DetailPlanSelected.ForEach(o =>
                            {
                                if (o.HumanUnit != null && o.HumanUnit.Count > 0
                                && o.HumanUnit.Any(h => h.FK_HREmployeeID == childNote.HREmployeeID)
                                )
                                    Child.SetValue(col, true);
                            });

                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void SetValueValidateNode(DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.HREmployeeID > 0)
                        if (DetailPlanSelected != null)
                            DetailPlanSelected.ForEach(o =>
                            {
                                if (o.HumanUnit != null && o.HumanUnit.Count > 0
                                && o.HumanUnit.Any(h => h.FK_HREmployeeID == childNote.HREmployeeID)
                                )
                                    Child.SetValue(col, true);
                            });

                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void SetValueChildNode(bool value, DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null)
                        childNote.Selected = value;
                    Child.SetValue(col, value);
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueChildNode(value, Child, col);
                }
        }
        public void GetValueFromTree(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.Selected && childNote.HREmployeeID > 0)
                        ResultList.Add((HRDepartmentRoomGroupItemsInfo)childNote.Clone());
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        GetValueFromTree(Child);
                }
        }
        private void Fld_trlGroupItems_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selected")
            {
                if (e.Value != null)
                {
                    bool value = false;
                    if (e.Value != null) value = (bool)e.Value;

                    fld_trlGroupItems.FocusedNode.SetValue(e.Column, value);
                    HRDepartmentRoomGroupItemsInfo currentNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(fld_trlGroupItems.FocusedNode);
                    if (currentNote != null)
                        currentNote.Selected = value;
                    SetValueChildNode(value, fld_trlGroupItems.FocusedNode, e.Column);
                    fld_trlGroupItems.RefreshDataSource();
                }
            }
        }
        public void InitDataSourceOperations()
        {
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationsByGroupAndIsPlan(ProductType.Product.ToString(), true);
            List<string> opID = new List<string>();
            List<string> opName = new List<string>();
            if (DetailPlanSelected != null)
                opID = DetailPlanSelected.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            if (operationList != null)
            {
                MMOperationsInfo item = new MMOperationsInfo();
                item.MMOperationName = "Khác";
                operationList.Insert(0, item);
            }
            fld_cmbOperations.Properties.DataSource = operationList;
            if (operationList != null && opID != null && opID.Count > 0)
            {
                string selectText = string.Empty;
                foreach (var item in opID)
                {
                    MMOperationsInfo found = operationList.Where(o => o.MMOperationID.ToString() == item).FirstOrDefault();
                    if (found != null) opName.Add(found.MMOperationName);
                }
                fld_cmbOperations.EditValue = string.Join(",", opID.ToArray());
                fld_cmbOperations.SelectedText = string.Join(",", opID.ToArray());
                fld_cmbOperations.RefreshEditValue();
            }
        }
        public void AddTreeListColumns(TreeList tree, int visibleIndex, string fieldName, string caption, bool readOnly, bool AllowEdit, string formatNumber, bool checkbox)
        {
            tree.BeginUpdate();
            TreeListColumn column = tree.Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            tree.OptionsView.AutoWidth = false;
            column.Caption = caption;
            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;

            if (!string.IsNullOrEmpty(formatNumber))
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = formatNumber;
            }
            if (checkbox)
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            tree.EndUpdate();
            tree.Update();
        }
        public void GetTreeDataSource(int departmentID, int departmentRoomID, int departmentRoomGroupItemID, int employeeID, string operationID)
        {
            HRDepartmentRoomGroupItemsController controller = new HRDepartmentRoomGroupItemsController();
            RoomGroupItemDataList = controller.GetHumanUnitDataBySomeConditions(departmentID, departmentRoomID, departmentRoomGroupItemID, employeeID, operationID);
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void Fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int departmentID = 0;
            int departmentroomID = 0;
            if (fld_lkeHRDepartmentID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentID);
            if (fld_lkeHRDepartmentRoomID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentRoomID.EditValue.ToString(), out departmentroomID);
            fld_lkeHRDepartmentRoomGroupItemID.DepartmentID = departmentID;
            fld_lkeHRDepartmentRoomGroupItemID.DepartmentroomID = departmentroomID;
        }
        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            int departmentID = 0;
            int departmentRoomID = 0;
            int departmentRoomGroupItemID = 0;

            string operationID = fld_cmbOperations.EditValue != null ? fld_cmbOperations.EditValue.ToString() : null;
            if (fld_lkeHRDepartmentID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentID);
            if (fld_lkeHRDepartmentRoomID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentRoomID.EditValue.ToString(), out departmentRoomID);
            if (fld_lkeHRDepartmentRoomGroupItemID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentRoomGroupItemID.EditValue.ToString(), out departmentRoomGroupItemID);
            if (operationID.Contains("0,")) operationID = string.Empty;
            GetTreeDataSource(departmentID, departmentRoomID, departmentRoomGroupItemID, 0, operationID);
            bindingListSource = new BindingList<HRDepartmentRoomGroupItemsInfo>();
            if (RoomGroupItemDataList != null && RoomGroupItemDataList.Count > 0)
                RoomGroupItemDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlGroupItems.DataSource = bindingListSource;
            fld_trlGroupItems.RefreshDataSource();
            fld_trlGroupItems.ExpandAll();
        }
        private void Fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList.Clear();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlGroupItems.Nodes)
            {
                HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.HREmployeeID > 0)
                    ResultList.Add((HRDepartmentRoomGroupItemsInfo)childNote.Clone());
                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    GetValueFromTree(Child);
            }
            if (ResultList == null || ResultList.Count == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn nhân công");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void Fld_lkeHRDepartmentRoomID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int department = 0;
            if (fld_lkeHRDepartmentID.EditValue != null)
            {
                if (int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out department))
                {
                    if (department > 0 && BOSApp.LookupTables.Contains(TableName.HRDepartmentRoomsTableName))
                    {
                        DataSet ds = (DataSet)BOSApp.LookupTables[TableName.HRDepartmentRoomsTableName];
                        if (ds != null && ds.Tables.Count > 0)
                        {
                            DataTable table = ds.Tables[0].Copy();
                            DataTable dataSource = table.Clone();
                            foreach (DataRow row in table.Rows)
                            {
                                int value = 0;
                                if (row["FK_HRDepartmentID"] != null)
                                {
                                    if (int.TryParse(row["FK_HRDepartmentID"].ToString(), out value))
                                    {
                                        if (value == department)
                                        {
                                            dataSource.Rows.Add(row.ItemArray);
                                        }
                                    }
                                }
                            }
                            if (dataSource != null && dataSource.Rows.Count > 0)
                                fld_lkeHRDepartmentRoomID.Properties.DataSource = dataSource;
                        }
                    }
                }
            }
        }
    }
}
