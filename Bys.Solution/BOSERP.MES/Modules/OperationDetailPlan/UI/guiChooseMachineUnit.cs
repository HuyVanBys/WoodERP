using BOSCommon;
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
    public partial class guiChooseMachineUnit : BOSERPScreen
    {
        public List<MMDetailPlanMachineUnitsInfo> PlanMachineUnitList { get; set; }
        public List<MMMachineUnitsInfo> MachineUnitDataList { get; set; }
        public List<MMBatchProductProductionNormItemsViewInfo> DetailPlanSelected { get; set; }
        public BOSTreeList MachineUnitItemList { get; set; }
        public BindingList<MMMachineUnitsInfo> bindingListSource { get; set; }
        public List<MMMachineUnitsInfo> ResultList { get; set; }
        public guiChooseMachineUnit()
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
        private void guiChooseMachineUnit_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ResultList = new List<MMMachineUnitsInfo>();
            InitDataSourceOperations();
            int workshopID = 0;
            int lineID = 0;

            string operationID = fld_cmbOperations.EditValue != null ? fld_cmbOperations.EditValue.ToString() : null;

            GetTreeDataSource(workshopID, lineID, operationID);
            #region InitTreeList
            bindingListSource = new BindingList<MMMachineUnitsInfo>();
            MachineUnitDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlGroupItems.KeyFieldName = "MMMachineUnitID";
            fld_trlGroupItems.ParentFieldName = "MMMachineUnitParentID";
            fld_trlGroupItems.Columns.Clear();
            AddTreeListColumns(fld_trlGroupItems, 0, "Selected", "Chọn", false, true, string.Empty, true);
            AddTreeListColumns(fld_trlGroupItems, 1, "MMMachineUnitNo", "Mã tổ", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 2, "MMMachineUnitName", "Tên tổ", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 3, "ACAssetNo", "Mã máy", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 4, "ACAssetName", "Tên máy", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 5, "MMLineName", "Chuyền", true, false, string.Empty, false);
            AddTreeListColumns(fld_trlGroupItems, 6, "MMWorkShopName", "Xưởng", true, false, string.Empty, false);

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
            // fld_trlGroupItems.ExpandAll();
            #endregion
        }
        public void InvalidateSelectNode()
        {
            TreeListColumn col = fld_trlGroupItems.Columns["Selected"];
            if (fld_trlGroupItems.Nodes != null)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlGroupItems.Nodes)
                {
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.FK_ACAssetID > 0)
                        if (DetailPlanSelected != null)
                            DetailPlanSelected.ForEach(o =>
                            {
                                if (o.MachineUnit != null && o.MachineUnit.Count > 0
                                && o.MachineUnit.Any(h => h.FK_ACAssetID == childNote.FK_ACAssetID)
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
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.FK_ACAssetID > 0)
                        if (DetailPlanSelected != null)
                            DetailPlanSelected.ForEach(o =>
                            {
                                if (o.MachineUnit != null && o.MachineUnit.Count > 0
                                && o.MachineUnit.Any(h => h.FK_ACAssetID == childNote.FK_ACAssetID)
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
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
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
                    MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                    if (childNote != null && childNote.Selected && childNote.FK_ACAssetID > 0)
                        ResultList.Add((MMMachineUnitsInfo)childNote.Clone());
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
                    MMMachineUnitsInfo currentNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(fld_trlGroupItems.FocusedNode);
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
            MMOperationsInfo itemOp = new MMOperationsInfo();
            itemOp.MMOperationName = "Khác";
            operationList.Insert(0, itemOp);

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
        public void GetTreeDataSource(int worShopID, int lineID, string operationID)
        {
            MMMachineUnitsController controller = new MMMachineUnitsController();
            MachineUnitDataList = controller.GetMachineUnitDataBySomeConditions(worShopID, lineID, operationID);
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            int workShopID = 0;
            int lineID = 0;

            string operationID = fld_cmbOperations.EditValue != null ? fld_cmbOperations.EditValue.ToString() : null;
            if (fld_lkeMMWorkShopID.EditValue != null)
                int.TryParse(fld_lkeMMWorkShopID.EditValue.ToString(), out workShopID);
            if (fld_lkeMMLineID.EditValue != null)
                int.TryParse(fld_lkeMMLineID.EditValue.ToString(), out lineID);
            if (operationID.Contains("0,")) operationID = string.Empty;
            GetTreeDataSource(workShopID, lineID, operationID);
            bindingListSource = new BindingList<MMMachineUnitsInfo>();
            if (MachineUnitDataList != null && MachineUnitDataList.Count > 0)
                MachineUnitDataList.ForEach(o => bindingListSource.Add(o));
            fld_trlGroupItems.DataSource = bindingListSource;
            fld_trlGroupItems.RefreshDataSource();
            fld_trlGroupItems.ExpandAll();
        }
        private void Fld_btnOK_Click(object sender, EventArgs e)
        {
            ResultList.Clear();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Child in fld_trlGroupItems.Nodes)
            {
                MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)fld_trlGroupItems.GetDataRecordByNode(Child);
                if (childNote != null && childNote.Selected && childNote.FK_ACAssetID > 0)
                    ResultList.Add((MMMachineUnitsInfo)childNote.Clone());
                if (Child.Nodes != null && Child.Nodes.Count > 0)
                    GetValueFromTree(Child);
            }
            if (ResultList == null || ResultList.Count == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn máy móc");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void Fld_lkeMMLineID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int workShop = 0;
            if (fld_lkeMMWorkShopID.EditValue != null)
            {
                if (int.TryParse(fld_lkeMMWorkShopID.EditValue.ToString(), out workShop))
                {
                    if (workShop > 0 && BOSApp.LookupTables.Contains("MMLines"))
                    {
                        DataSet ds = (DataSet)BOSApp.LookupTables["MMLines"];
                        if (ds != null && ds.Tables.Count > 0)
                        {
                            DataTable table = ds.Tables[0].Copy();
                            DataTable dataSource = table.Clone();
                            foreach (DataRow row in table.Rows)
                            {
                                int value = 0;
                                if (row["FK_MMWorkShopID"] != null)
                                {
                                    if (int.TryParse(row["FK_MMWorkShopID"].ToString(), out value))
                                    {
                                        if (value == workShop)
                                        {
                                            dataSource.Rows.Add(row.ItemArray);
                                        }
                                    }
                                }
                            }
                            if (dataSource != null && dataSource.Rows.Count > 0)
                                fld_lkeMMLineID.Properties.DataSource = dataSource;
                        }
                    }
                }
            }
        }
    }
}
