using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class ChooseMachineUnitTreeControl : TreeList
    {
        public BindingList<MMMachineUnitsInfo> bindingListSource { get; set; }
        public List<MMMachineUnitsInfo> MachineGroupItemDataList { get; set; }
        public List<MMMachineUnitsInfo> ResultList { get; set; }
        public BaseModule Module { get; set; }
        public void InitializeControl()
        {
            #region InitTreeList

            this.KeyFieldName = "MMMachineUnitID";
            this.ParentFieldName = "MMMachineUnitParentID";
            this.Columns.Clear();
            AddTreeListColumns(this, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(this, 1, "MMMachineUnitNo", "Mã tổ", true, false, string.Empty, false);
            AddTreeListColumns(this, 2, "MMMachineUnitName", "Tên tổ", true, false, string.Empty, false);
            AddTreeListColumns(this, 3, "ACAssetNo", "Mã máy", true, false, string.Empty, false);
            AddTreeListColumns(this, 4, "ACAssetName", "Tên máy", true, false, string.Empty, false);
            AddTreeListColumns(this, 5, "MMMachineUnitCapacity", "Năng suất", false, true, string.Empty, false);
            AddTreeListColumns(this, 6, "MMCapacityUnit", "ĐVT năng suất", false, true, string.Empty, false);
            AddTreeListColumns(this, 7, "MMMachineUnitQty", "Định biên", false, true, string.Empty, false);
            AddTreeListColumns(this, 8, "MMMachineUnitSetupTime", "TG setup (phút)", false, true, string.Empty, false);
            AddTreeListColumns(this, 9, "MMLineName", "Chuyền", true, false, string.Empty, false);
            AddTreeListColumns(this, 10, "MMWorkShopName", "Xưởng", true, false, string.Empty, false);
            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
            this.OptionsCustomization.AllowFilter = true;
            this.OptionsNavigation.UseTabKey = true;
            this.OptionsView.ShowAutoFilterRow = true;
            this.DataSource = bindingListSource;
            this.CellValueChanging += ChooseHumanUnitTreeControl_CellValueChanging;
            this.CellValueChanged += ChooseHumanUnitTreeControl_CellValueChanged;
            this.ForceInitialize();

            #endregion
        }
        private void ChooseHumanUnitTreeControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            //((OperationDetailPlanModule)this.Module).InvalidateMachinePlanByNoteChange();
        }
        public void SetValueChildNode(bool value, TreeListNode node, TreeListColumn col)
        {
            if (node.Nodes != null)
                foreach (TreeListNode Child in node.Nodes)
                {
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)this.GetDataRecordByNode(Child);
                    if (childNote != null)
                    {
                        childNote.Selected = value;
                        ((OperationDetailPlanModule)this.Module).ChangeMachineSelectNote(childNote, value);
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
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)this.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.Selected && childNote.FK_ACAssetID > 0)
                        ResultList.Add((MMMachineUnitsInfo)childNote.Clone());
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
                    bool value = false;
                    if (e.Value != null) value = (bool)e.Value;
                    this.FocusedNode.SetValue(e.Column, value);
                    MMMachineUnitsInfo currentNote = (MMMachineUnitsInfo)this.GetDataRecordByNode(this.FocusedNode);
                    if (currentNote != null)
                        currentNote.Selected = value;
                    SetValueChildNode(value, this.FocusedNode, e.Column);
                    this.RefreshDataSource();
                    ((OperationDetailPlanModule)this.Module).InvalidateMachinePlanByNoteChange();
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

        public void GetTreeDataSource(int workShopID, int lineID, string operation, string listSemiProduct)
        {
            MMMachineUnitsController controller = new MMMachineUnitsController();
            if (!string.IsNullOrEmpty(listSemiProduct))
            {
                MachineGroupItemDataList = controller.GetFilterMachineUnitDataBySomeCriteria(workShopID, lineID, operation, listSemiProduct);
            }
            else if (string.IsNullOrEmpty(operation))
                MachineGroupItemDataList = controller.GetMachineUnitDataBySomeConditions(workShopID, lineID, operation);
            else
                MachineGroupItemDataList = controller.GetMachineUnitDataByOperationAndSomeConditions(workShopID, lineID, operation);
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
