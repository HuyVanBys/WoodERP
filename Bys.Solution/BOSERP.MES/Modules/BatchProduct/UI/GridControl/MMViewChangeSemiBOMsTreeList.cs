using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.StyleFormatConditions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class MMViewChangeSemiBOMsTreeList : BOSTreeListControl
    {
        public void InitTreeListDataSource(List<MMBatchProductProductionNormItemsViewInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            // Custom column
            foreach (TreeListColumn column in this.Columns)
            {
                if (column.FieldName == "MMBatchProductProductionNormItemJobCreateQty" ||
                    column.FieldName == "MMBatchProductProductionNormItemReceiptQty" ||
                    column.FieldName == "MMBatchProductProductionNormItemNewQuantity")
                {
                    column.AppearanceCell.BackColor = Color.AntiqueWhite;
                }
                if (column.FieldName == "MMBatchProductProductionNormItemApplyQuantity")
                {
                    column.AppearanceCell.BackColor = Color.PaleTurquoise;
                }
                if (column.FieldName == "MMBatchProductProductionNormItemQuantity")
                {
                    column.AppearanceCell.BackColor = Color.DarkGray;
                }
                column.OptionsColumn.AllowEdit = false;
            }
            guiChangeToNeedMerge mergeForm = (guiChangeToNeedMerge)this.Screen;
            if (mergeForm != null && mergeForm.isChangeBOM)
            {
                #region Apply col
                TreeListColumn column = this.Columns["Apply"];
                if (column == null)
                    column = this.Columns.Add();
                column.Visible = true;
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                column.Caption = "Áp dụng";
                column.OptionsColumn.FixedWidth = false;
                column.VisibleIndex = 1;
                column.FieldName = "Apply";
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                rpItemComponent.NullText = "Áp dụng";
                rpItemComponent.Click += RpItemComponent_Click;
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            #endregion

            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.FocusedNodeChanged += MMViewChangeSemiBOMsTreeList_FocusedNodeChanged;
            this.CustomColumnDisplayText += MMViewChangeSemiBOMsTreeList_CustomColumnDisplayText;
            this.CustomDrawNodeCell += MMViewChangeSemiBOMsTreeList_CustomDrawNodeCell;
            this.OptionsMenu.ShowConditionalFormattingItem = true;
            CustomizingConditionalFormatting(this);

        }

        private void MMViewChangeSemiBOMsTreeList_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MMBatchProductProductionNormItemMaterialType" ||
                    e.Column.FieldName == "MMBatchProductProductionNormItemProcessType" ||
                    e.Column.FieldName == "MMBatchProductProductionNormItemHWType" ||
                    e.Column.FieldName == "MMBatchProductProductionNormItemPaintType" ||
                    e.Column.FieldName == "MMBatchProductProductionNormItemPackType" ||
                    e.Column.FieldName == "MMBatchProductProductionNormItemGeneralType")
                {
                    if (e.CellValue != null && e.CellValue.ToString() == "Yes") e.Appearance.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void MMViewChangeSemiBOMsTreeList_CustomColumnDisplayText(object sender, DevExpress.XtraTreeList.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Apply")
            {
                MMBatchProductProductionNormItemsViewInfo itemNote = (MMBatchProductProductionNormItemsViewInfo)this.GetDataRecordByNode(e.Node);
                if (itemNote == null) return;
                if (itemNote.MMBatchProductProductionNormItemType == "Normal"
                    && itemNote.MMBatchProductProductionNormItemMaterialType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemProcessType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemHWType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemPaintType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemPackType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemGeneralType != "Yes"
                    ) e.DisplayText = "";
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            TreeListNode node = this.GetSelectedNode();
            if (node != null)
            {
                MMBatchProductProductionNormItemsViewInfo itemNote = (MMBatchProductProductionNormItemsViewInfo)this.GetDataRecordByNode(node);
                if (itemNote == null) return;
                if (itemNote.MMBatchProductProductionNormItemType == "Normal"
                    && itemNote.MMBatchProductProductionNormItemMaterialType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemProcessType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemHWType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemPaintType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemPackType != "Yes"
                    && itemNote.MMBatchProductProductionNormItemGeneralType != "Yes"
                    )
                {
                    HyperLinkEdit rpItemComponent = (HyperLinkEdit)sender;
                    if (rpItemComponent != null) { rpItemComponent.Text = string.Empty; }
                    return;
                }
                guiChangeToNeedMerge mergeForm = (guiChangeToNeedMerge)this.Screen;
                if (!mergeForm.CheckAllowChangeBOM())
                    return;

                List<MMBatchProductProductionNormItemsViewInfo> selectedNodes = new List<MMBatchProductProductionNormItemsViewInfo>();
                if (itemNote != null) selectedNodes.Add(itemNote);
                SelectAllChildren(node, selectedNodes);


                if (mergeForm != null) mergeForm.ApplySemiProduct(selectedNodes, null, "All");

            }
        }

        private void MMViewChangeSemiBOMsTreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            TreeListNode node = this.GetSelectedNode();
            if (node != null)
            {
                List<MMBatchProductProductionNormItemsViewInfo> selectedNodes = new List<MMBatchProductProductionNormItemsViewInfo>();
                MMBatchProductProductionNormItemsViewInfo itemNote = (MMBatchProductProductionNormItemsViewInfo)this.GetDataRecordByNode(node);
                if (itemNote != null) selectedNodes.Add(itemNote);
                //SelectAllChildren(node, selectedNodes);
                guiChangeToNeedMerge mergeForm = (guiChangeToNeedMerge)this.Screen;
                if (mergeForm != null) mergeForm.SemiSelectChange(selectedNodes);
            }
        }
        public void SelectAllChildren(TreeListNode node, List<MMBatchProductProductionNormItemsViewInfo> selectedNodes)
        {
            if (node.Nodes != null)
            {
                foreach (TreeListNode Child in node.Nodes)
                {
                    MMBatchProductProductionNormItemsViewInfo childNote = (MMBatchProductProductionNormItemsViewInfo)this.GetDataRecordByNode(Child);
                    if (childNote != null) selectedNodes.Add(childNote);
                    if (Child.Nodes != null && Child.Nodes.Count > 0)
                        SelectAllChildren(Child, selectedNodes);
                }
            }
        }
        public void CustomizingConditionalFormatting(TreeList treeList)
        {
            #region MMBatchProductProductionNormItemType
            FormatConditionRuleContains ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Red;
            ruleForMark.Values = new object[] { ((object)("Delete")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemType"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Green;
            ruleForMark.Values = new object[] { ((object)("New")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemType"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.YellowGreen;
            ruleForMark.Values = new object[] { ((object)("Increase")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemType"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Orange;
            ruleForMark.Values = new object[] { ((object)("Decrease")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemType"], ruleForMark);


            TreeListFormatRule ruleForTypeOfObject = new TreeListFormatRule();
            ruleForTypeOfObject.Column = treeList.Columns["MMBatchProductProductionNormItemType"];
            //ruleForTypeOfObject.ColumnApplyTo = treeList.Columns["MMBatchProductProductionNormItemNewQuantity"];
            treeList.FormatRules.Add(ruleForTypeOfObject);

            #endregion
            #region MMBatchProductProductionNormItemNewQuantity
            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Red;
            ruleForMark.Values = new object[] { ((object)("Delete")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemNewQuantity"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Green;
            ruleForMark.Values = new object[] { ((object)("New")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemNewQuantity"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.YellowGreen;
            ruleForMark.Values = new object[] { ((object)("Increase")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemNewQuantity"], ruleForMark);

            ruleForMark = new FormatConditionRuleContains();
            ruleForMark.Appearance.BackColor = Color.Orange;
            ruleForMark.Values = new object[] { ((object)("Decrease")) };
            treeList.FormatRules.Add(treeList.Columns["MMBatchProductProductionNormItemNewQuantity"], ruleForMark);

            ruleForTypeOfObject = new TreeListFormatRule();
            ruleForTypeOfObject.Column = treeList.Columns["MMBatchProductProductionNormItemNewQuantity"];
            ruleForTypeOfObject.ColumnApplyTo = treeList.Columns["MMBatchProductProductionNormItemNewQuantity"];
            treeList.FormatRules.Add(ruleForTypeOfObject);


            #endregion
        }
    }
}
