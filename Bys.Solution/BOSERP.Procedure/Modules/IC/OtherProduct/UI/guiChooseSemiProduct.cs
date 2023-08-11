using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.OtherProduct
{
    public partial class guiChooseSemiProduct : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>

        public List<MMProductionNormItemsInfo> OperationItemDataList { get; set; }
        public BindingList<MMProductionNormItemsInfo> bindingListSource { get; set; }
        public List<ICProductSemisInfo> OperationDataSelected { get; set; }
        public List<MMProductionNormItemsInfo> ResultList { get; set; }
        public guiChooseSemiProduct()
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
            OperationItemDataList = new List<MMProductionNormItemsInfo>();
            OperationItemDataList.Add(new MMProductionNormItemsInfo());
        }
        private void guiChooseSemiProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ResultList = new List<MMProductionNormItemsInfo>();
            #region InitTreeList
            bindingListSource = new BindingList<MMProductionNormItemsInfo>();
            OperationItemDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlSemiItems.KeyFieldName = "MMProductionNormItemID";
            fld_trlSemiItems.ParentFieldName = "MMProductionNormItemParentID";
            fld_trlSemiItems.Columns.Clear();
            AddTreeListColumns(fld_trlSemiItems, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(fld_trlSemiItems, 1, "MMProductionNormItemNo", "Mã chi tiết", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlSemiItems, 2, "MMProductionNormItemProductName", "Tên chi tiết", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlSemiItems, 3, "MMProductionNormItemProductHeight", "Dày", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlSemiItems, 4, "MMProductionNormItemProductWidth", "Rộng", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlSemiItems, 5, "MMProductionNormItemProductLength", "Dài", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlSemiItems, 5, "MMProductionNormItemProductDesc", "QTSX", true, false, string.Empty, false);
            fld_trlSemiItems.OptionsView.ShowSummaryFooter = true;
            fld_trlSemiItems.OptionsBehavior.ImmediateEditor = true;
            fld_trlSemiItems.OptionsCustomization.AllowFilter = true;
            fld_trlSemiItems.OptionsNavigation.UseTabKey = true;
            fld_trlSemiItems.OptionsView.ShowAutoFilterRow = true;
            fld_trlSemiItems.OptionsBehavior.PopulateServiceColumns = true;
            fld_trlSemiItems.DataSource = bindingListSource;
            fld_trlSemiItems.CellValueChanging += Fld_trlGroupItems_CellValueChanging;
            fld_trlSemiItems.ForceInitialize();
            if (OperationDataSelected != null && OperationDataSelected.Count > 0)
                InvalidateSelectNode();
            fld_trlSemiItems.RefreshDataSource();
            fld_trlSemiItems.ExpandAll();
            #endregion
        }

        public void InvalidateSelectNode()
        {
            TreeListColumn col = fld_trlSemiItems.Columns["Selected"];
            if (fld_trlSemiItems.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlSemiItems.Nodes)
                {
                    MMProductionNormItemsInfo childNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.FK_ICProductID > 0)
                        if (OperationDataSelected != null)
                            OperationDataSelected.ForEach(o =>
                            {
                                if (o.FK_ICProductSemiID == childNote.FK_ICProductID)
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
                MMProductionNormItemsInfo childNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.FK_ICProductID > 0)
                    if (OperationDataSelected != null)
                        OperationDataSelected.ForEach(o =>
                        {
                            if (o.FK_ICProductSemiID == childNote.FK_ICProductID)
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
                MMProductionNormItemsInfo childNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(Child);
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
                MMProductionNormItemsInfo childNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.MMProductionNormItemID > 0)
                    ResultList.Add((MMProductionNormItemsInfo)childNote.Clone());
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
            if (e.Column.FieldName == "Selected")
            {
                if (e.Value != null)
                {
                    fld_trlSemiItems.FocusedNode.SetValue(e.Column, e.Value);
                    MMProductionNormItemsInfo currentNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(fld_trlSemiItems.FocusedNode);
                    if (currentNote != null)
                        currentNote.Selected = (bool)e.Value;
                    SetValueChildNode((bool)e.Value, fld_trlSemiItems.FocusedNode, e.Column);
                    fld_trlSemiItems.RefreshDataSource();
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
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList.Clear();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlSemiItems.Nodes)
            {
                MMProductionNormItemsInfo childNote = (MMProductionNormItemsInfo)fld_trlSemiItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.MMProductionNormItemID > 0)
                    ResultList.Add((MMProductionNormItemsInfo)childNote.Clone());
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
                BOSApp.ShowMessage("Vui lòng chọn chi tiết BTP");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void Fld_lkeMMProductionNormID_Validated_1(object sender, EventArgs e)
        {
            int value = 0;
            if (fld_lkeMMProductionNormID.EditValue != null)
            {
                int.TryParse(fld_lkeMMProductionNormID.EditValue.ToString(), out value);
                if (value > 0)
                {
                    MMProductionNormItemsController contrl = new MMProductionNormItemsController();
                    OperationItemDataList = contrl.GetNormItemOperationsByParentAndGroupType("SemiProduct", value);
                    bindingListSource = new BindingList<MMProductionNormItemsInfo>();
                    if (OperationItemDataList != null)
                    {

                        OperationItemDataList.ForEach(o => bindingListSource.Add(o));
                        fld_trlSemiItems.DataSource = bindingListSource;
                        fld_trlSemiItems.RefreshDataSource();
                        fld_trlSemiItems.ExpandAll();
                    }

                }
            }
        }
    }
}
