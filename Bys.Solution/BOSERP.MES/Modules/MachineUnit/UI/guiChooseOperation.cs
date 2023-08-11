using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineUnit
{
    public partial class guiChooseOperation : BOSERPScreen
    {
        public List<MMOperationsInfo> OperationItemDataList { get; set; }
        public BindingList<MMOperationsInfo> bindingListSource { get; set; }
        public List<MMOperationsInfo> OperationDataSelected { get; set; }
        public List<MMOperationsInfo> ResultList { get; set; }
        public guiChooseOperation()
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
        private void guiChooseOperation_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ResultList = new List<MMOperationsInfo>();
            #region InitTreeList
            bindingListSource = new BindingList<MMOperationsInfo>();
            OperationItemDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlGroupItems.KeyFieldName = "MMOperationID";
            fld_trlGroupItems.ParentFieldName = "MMOperationParentID";
            fld_trlGroupItems.Columns.Clear();
            AddTreeListColumns(fld_trlGroupItems, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(fld_trlGroupItems, 1, "MMOperationNo", "Mã CĐ", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 2, "MMOperationName", "Tên CĐ", true, false, string.Empty, false);

            fld_trlGroupItems.OptionsView.ShowSummaryFooter = true;
            fld_trlGroupItems.OptionsBehavior.ImmediateEditor = true;
            fld_trlGroupItems.OptionsCustomization.AllowFilter = true;
            fld_trlGroupItems.OptionsNavigation.UseTabKey = true;
            fld_trlGroupItems.OptionsView.ShowAutoFilterRow = true;
            fld_trlGroupItems.DataSource = bindingListSource;
            fld_trlGroupItems.CellValueChanging += Fld_trlGroupItems_CellValueChanging;
            fld_trlGroupItems.ForceInitialize();
            if (OperationDataSelected != null && OperationDataSelected.Count > 0)
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
                    MMOperationsInfo childNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.MMOperationID > 0)
                        if (OperationDataSelected != null)
                            OperationDataSelected.ForEach(o =>
                            {
                                if (o.MMOperationID == childNote.MMOperationID)
                                    Child.SetValue(col, true);
                            });

                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SetValueValidateNode(Child, col);
                }
        }
        public void SetValueValidateNode(DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
            {
                MMOperationsInfo childNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.MMOperationID > 0)
                    if (OperationDataSelected != null)
                        OperationDataSelected.ForEach(o =>
                        {
                            if (o.MMOperationID == childNote.MMOperationID)
                                Child.SetValue(col, true);
                        });

                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    SetValueValidateNode(Child, col);
            }
        }
        public void SetValueChildNode(bool value, DevExpress.XtraTreeList.Nodes.TreeListNode node, TreeListColumn col)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
            {
                MMOperationsInfo childNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null)
                    childNote.Selected = value;
                Child.SetValue(col, value);
                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    SetValueChildNode(value, Child, col);
            }
        }
        public void GetValueFromTree(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in node.Nodes)
            {
                MMOperationsInfo childNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.MMOperationID > 0)
                    ResultList.Add((MMOperationsInfo)childNote.Clone());
                else if (ResultList != null && !childNote.Selected)
                {
                    int index = ResultList.IndexOf(childNote);
                    if (index >= 0) ResultList.RemoveAt(index);
                }

                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    GetValueFromTree(Child);
            }
        }
        private void Fld_trlGroupItems_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selected" && e.Value != null)
            {
                fld_trlGroupItems.FocusedNode.SetValue(e.Column, e.Value);
                MMOperationsInfo currentNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(fld_trlGroupItems.FocusedNode);
                if (currentNote != null)
                    currentNote.Selected = (bool)e.Value;
                SetValueChildNode((bool)e.Value, fld_trlGroupItems.FocusedNode, e.Column);
                fld_trlGroupItems.RefreshDataSource();
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
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList.Clear();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlGroupItems.Nodes)
            {
                MMOperationsInfo childNote = (MMOperationsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.MMOperationID > 0)
                    ResultList.Add((MMOperationsInfo)childNote.Clone());
                else if (ResultList != null && !childNote.Selected)
                {
                    int index = ResultList.IndexOf(childNote);
                    if (index >= 0) ResultList.RemoveAt(index);
                }
                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    GetValueFromTree(Child);
            }
            if (ResultList == null || ResultList.Count == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn công đoạn");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
