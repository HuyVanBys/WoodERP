using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class ChooseHumanUnitTreeControl : TreeList
    {
        public BindingList<HRDepartmentRoomGroupItemsInfo> bindingListSource { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> RoomGroupItemDataList { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> ResultList { get; set; }
        public BaseModule Module { get; set; }
        public void InitializeControl()
        {
            #region InitTreeList
            GetTreeDataSource(0, 0, string.Empty);
            bindingListSource = new BindingList<HRDepartmentRoomGroupItemsInfo>();
            if (RoomGroupItemDataList != null)
                RoomGroupItemDataList.ForEach(o => bindingListSource.Add(o));
            this.KeyFieldName = "HRDepartmentRoomGroupItemID";
            this.ParentFieldName = "HRDepartmentRoomGroupItemParentID";
            this.Columns.Clear();
            AddTreeListColumns(this, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(this, 1, "HRDepartmentRoomGroupItemNo", "Mã tổ", true, false, string.Empty, false);
            AddTreeListColumns(this, 2, "HRDepartmentRoomGroupItemName", "Tên tổ", true, false, string.Empty, false);
            AddTreeListColumns(this, 3, "HREmployeeNo", "Mã nhân viên", true, false, string.Empty, false);
            AddTreeListColumns(this, 4, "HREmployeeName", "Tên nhân viên", true, false, string.Empty, false);
            AddTreeListColumns(this, 5, "HRDepartmentName", "Phòng ban", true, false, string.Empty, false);
            AddTreeListColumns(this, 6, "HRDepartmentRoomName", "Bộ phận", true, false, string.Empty, false);
            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
            this.OptionsCustomization.AllowFilter = true;
            this.OptionsNavigation.UseTabKey = true;
            this.OptionsView.ShowAutoFilterRow = true;
            this.DataSource = bindingListSource;
            this.CellValueChanging += ChooseHumanUnitTreeControl_CellValueChanging;
            this.CellValueChanged += ChooseHumanUnitTreeControl_CellValueChanged;
            this.ForceInitialize();
            this.RefreshDataSource();
            //this.ExpandAll();
            #endregion
        }

        private void ChooseHumanUnitTreeControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            //((OperationDetailPlanModule)this.Module).InvalidateHumanPlanByNoteChange();
        }

        public void SetValueChildNode(bool value, DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)this.GetDataRecordByNode(Child);
                    if (childNote != null)
                    {
                        childNote.Selected = value;
                        ((OperationDetailPlanModule)this.Module).ChangeHumanSelectNote(childNote, value);
                    }
                    Child.SetValue(col, value);
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueChildNode(value, Child, col);
                }
        }

        public void GetSelectedValueFromTree(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            if (node.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
                {
                    HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)this.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.Selected && childNote.HREmployeeID > 0)
                    {
                        ResultList.Add((HRDepartmentRoomGroupItemsInfo)childNote.Clone());
                    }
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        GetSelectedValueFromTree(Child);
                }
        }
        private void ChooseHumanUnitTreeControl_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selected")
            {
                if (e.Value != null)
                {
                    this.FocusedNode.SetValue(e.Column, e.Value);
                    HRDepartmentRoomGroupItemsInfo currentNote = (HRDepartmentRoomGroupItemsInfo)this.GetDataRecordByNode(this.FocusedNode);
                    if (currentNote != null)
                        currentNote.Selected = (bool)e.Value;
                    SetValueChildNode((bool)e.Value, this.FocusedNode, e.Column);
                    this.RefreshDataSource();
                    ((OperationDetailPlanModule)this.Module).InvalidateHumanPlanByNoteChange();
                }
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

        public void GetTreeDataSource(int? departmentID, int? departmentRoom, string operationList)
        {
            HRDepartmentRoomGroupItemsController controller = new HRDepartmentRoomGroupItemsController();
            if (string.IsNullOrEmpty(operationList))
                RoomGroupItemDataList = controller.GetHumanUnitDataBySomeConditions(departmentID, departmentRoom, 0, 0, operationList);
            else
                RoomGroupItemDataList = controller.GetHumanUnitDataByOperationAndSomeConditions(departmentID, departmentRoom, 0, 0, operationList);
        }

        public void AddTreeListColumns(int visibleIndex, string fieldName, string caption, bool readOnly, bool AllowEdit, string formatNumber, bool checkbox)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;
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

            this.EndUpdate();
            this.Update();
        }
    }
}
