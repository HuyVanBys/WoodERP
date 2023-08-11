﻿using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Proposal
{
    public partial class ProposalTemplateItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion
        private List<AAColumnAliasInfo> ColumnAliasList { get; set; }

        private DataTable TemplateItemWorkTypeDataTable { get; set; }

        private DataTable MeasureUnitDataTable { get; set; }

        public enum TemplateItemColumnName
        {
            ARProposalTemplateItemProductNo,
            ARProposalTemplateItemProductName,
            ARProposalTemplateItemProductQty,
            ARProposalTemplateItemWorkType,
            FK_ICMeasureUnitID,
            ARProposalTemplateItemSortOrder,
            ARProposalTemplateItemComponent,
            ARProposalTemplateItemProductDesc,
        }

        public enum MeasureUnitColumnName
        {
            ICMeasureUnitID,
            ICMeasureUnitName,
        }

        protected override void InitTreeListDataSource()
        {
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList tlTemplateItem = new BOSTreeList();
            if (this.BOSDisplayRoot)
            {
                ARProposalTemplateItemsInfo root = new ARProposalTemplateItemsInfo
                {
                    ARProposalTemplateItemProductName = TemplateLocalizedResources.PMTemplateItemProductNameRoot,
                };
                tlTemplateItem.Add(root);
                tlTemplateItem[0].SubList = entity.TemplateItemList;
            }
            else
                tlTemplateItem = entity.TemplateItemList;
            this.DataSource = tlTemplateItem;
        }

        public override void InitializeControl()
        {
            TreeList treeList = this;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsBehavior.DragNodes = true;
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;
            this.BOSDisplayOption = false;
            this.ForceInitialize();
            this.BestFitColumns();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(TemplateItemsTreeListControl_KeyUp);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(TreeList_CellValueChanged);
            this.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(TreeList_CellValueChanging);
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            ColumnAliasList = new List<AAColumnAliasInfo>();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.ARProposalTemplateItemsTableName);

            foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
            {
                AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                ColumnAliasList.Add(objAAColumnAliasInfo);
            }

            TemplateItemWorkTypeDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(TemplateItemColumnName.ARProposalTemplateItemWorkType.ToString().Substring(2));
            if (ds != null)
                TemplateItemWorkTypeDataTable = ds.Tables[0];
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            DataSet ds1 = objMeasureUnitsController.GetAllObjects();
            if (ds1 != null)
                MeasureUnitDataTable = ds1.Tables[0];
            AddTreeListColumns(1, TemplateItemColumnName.ARProposalTemplateItemProductName, true, false);
            AddTreeListColumns(2, TemplateItemColumnName.ARProposalTemplateItemProductNo, true, false);
            AddTreeListColumns(3, TemplateItemColumnName.ARProposalTemplateItemProductQty, false, true);
            //AddTreeListColumns(3, TemplateItemColumnName.ARProposalTemplateItemWorkType, false, true);
            AddTreeListColumns(4, TemplateItemColumnName.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(5, TemplateItemColumnName.ARProposalTemplateItemSortOrder, false, true);
            //AddTreeListColumns(6, TemplateItemColumnName.ARProposalTemplateItemComponent, false, true);
            AddTreeListColumns(7, TemplateItemColumnName.ARProposalTemplateItemProductDesc, true, false);
        }

        public void AddTreeListColumns(int index, TemplateItemColumnName fieldName, bool readOnly, bool allowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.VisibleIndex = index;
            column.OptionsColumn.ReadOnly = readOnly;
            column.OptionsColumn.AllowEdit = allowEdit;
            this.OptionsView.AutoWidth = false;
            column.OptionsColumn.FixedWidth = false;
            column.FieldName = fieldName.ToString();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit;
            RepositoryItemTextEdit repositoryItemTextEdit;
            LookUpColumnInfo columnInfo;
            switch (fieldName)
            {
                case TemplateItemColumnName.ARProposalTemplateItemProductName:
                    column.MinWidth = 400;
                    break;

                case TemplateItemColumnName.ARProposalTemplateItemProductQty:
                    repositoryItemTextEdit = new RepositoryItemTextEdit()
                    {
                        Mask =
                        {
                            MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                            EditMask = "n2",
                            UseMaskAsDisplayFormat = true
                        }
                    };

                    column.OptionsColumn.AllowEdit = allowEdit;
                    column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.Format.FormatString = "#,##0.00";
                    column.MinWidth = 50;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
                    break;

                case TemplateItemColumnName.ARProposalTemplateItemProductDesc:
                    column.MinWidth = 400;
                    break;

                case TemplateItemColumnName.ARProposalTemplateItemWorkType:
                    column.MinWidth = 100;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = (object)TemplateItemWorkTypeDataTable;
                    repositoryItemLookUpEdit.ValueMember = "Value";
                    repositoryItemLookUpEdit.DisplayMember = "Text";
                    repositoryItemLookUpEdit.ShowHeader = false;
                    repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                    columnInfo = new LookUpColumnInfo();
                    columnInfo.FieldName = "Text";
                    columnInfo.Width = 100;
                    repositoryItemLookUpEdit.Columns.Add(columnInfo);
                    repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                    this.RepositoryItems.Add(repositoryItemLookUpEdit);
                    break;

                case TemplateItemColumnName.FK_ICMeasureUnitID:
                    column.MinWidth = 50;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = MeasureUnitDataTable;
                    repositoryItemLookUpEdit.ValueMember = MeasureUnitColumnName.ICMeasureUnitID.ToString();
                    repositoryItemLookUpEdit.DisplayMember = MeasureUnitColumnName.ICMeasureUnitName.ToString();
                    repositoryItemLookUpEdit.ShowHeader = false;
                    repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                    columnInfo = new LookUpColumnInfo();
                    columnInfo.FieldName = MeasureUnitColumnName.ICMeasureUnitName.ToString();
                    columnInfo.Width = 60;
                    repositoryItemLookUpEdit.Columns.Add(columnInfo);
                    repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                    this.RepositoryItems.Add(repositoryItemLookUpEdit);
                    break;

                case TemplateItemColumnName.ARProposalTemplateItemSortOrder:
                    column.MinWidth = 50;
                    break;

                case TemplateItemColumnName.ARProposalTemplateItemComponent:
                    column.MinWidth = 100;
                    column.Caption = TemplateLocalizedResources.PMTemplateItemComponentCaption;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                    rpItemComponent.NullText = string.Empty;
                    rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                    column.ColumnEdit = rpItemComponent;
                    break;
            }

            AAColumnAliasInfo objColumnAliasInfo = ColumnAliasList.Where(s => s.AAColumnAliasName == fieldName.ToString()).FirstOrDefault();
            column.Caption = objColumnAliasInfo == null ? column.Caption : objColumnAliasInfo.AAColumnAliasCaption;

            this.EndUpdate();
            this.Update();
        }

        private void TemplateItemsTreeListControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(TemplateLocalizedResources.TemplateItemConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                ((ProposalModule)Screen.Module).DeleteTemplateItemFromTreeList();
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((ProposalModule)Screen.Module).ShowItemComponent();
        }

        private void TreeList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

        }

        private void TreeList_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ProposalEntities entity = (ProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.TemplateItemList.IsSwitchToEdit = false;
        }
    }
}