using BOSCommon.Constants;
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

namespace BOSERP.Modules.Project
{
    public partial class ProjectNormsTreeListControl : BOSTreeListControl
    {
        #region  properties

        private List<AAColumnAliasInfo> ColumnAliasList { get; set; }

        private DataTable ProjectNormProductTypeDataTable { get; set; }

        private DataTable ProjectNormStatusDataTable { get; set; }

        private DataTable MeasureUnitDataTable { get; set; }

        public enum ProjectNormColumnName
        {
            PMProjectNormProductName,
            PMProjectNormProductQty,
            PMProjectNormProductType,
            FK_ICMeasureUnitID,
            PMProjectNormSortOrder,
            PMProjectNormItem,
            PMProjectNormProductDesc,
            PMProjectNormStartDate,
            PMProjectNormEndDate,
            PMProjectNormStatus,
            PMProjectNormIsApproved
        }

        public enum MeasureUnitColumnName
        {
            ICMeasureUnitID,
            ICMeasureUnitName,
        }
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList tlProjectNorm = new BOSTreeList();
            if (this.BOSDisplayRoot)
            {
                PMProjectNormsInfo root = new PMProjectNormsInfo
                {
                    PMProjectNormProductName = ProjectLocalizedResources.PMProjectNormProductNameRoot,
                };
                tlProjectNorm.Add(root);
                tlProjectNorm[0].SubList = entity.ProjectNormList;
            }
            else
            {
                tlProjectNorm = entity.ProjectNormList;
            }
            this.DataSource = tlProjectNorm;
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

            ColumnAliasList = new List<AAColumnAliasInfo>();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.PMProjectNormsTableName);

            foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
            {
                AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                ColumnAliasList.Add(objAAColumnAliasInfo);
            }

            DataSet ds;
            ProjectNormProductTypeDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(ProjectNormColumnName.PMProjectNormProductType.ToString().Substring(2));
            if (ds != null)
                ProjectNormProductTypeDataTable = ds.Tables[0];

            ProjectNormStatusDataTable = new DataTable();
            ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(ProjectNormColumnName.PMProjectNormStatus.ToString().Substring(2));
            if (ds != null)
                ProjectNormStatusDataTable = ds.Tables[0];

            MeasureUnitDataTable = new DataTable();
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ds = objMeasureUnitsController.GetAllObjects();
            if (ds != null)
                MeasureUnitDataTable = ds.Tables[0];

            AddTreeListColumns(1, ProjectNormColumnName.PMProjectNormProductName, true, false);
            AddTreeListColumns(2, ProjectNormColumnName.PMProjectNormProductQty, false, true);
            AddTreeListColumns(3, ProjectNormColumnName.PMProjectNormProductType, false, true);
            AddTreeListColumns(4, ProjectNormColumnName.FK_ICMeasureUnitID, false, true);
            AddTreeListColumns(5, ProjectNormColumnName.PMProjectNormSortOrder, false, true);
            AddTreeListColumns(6, ProjectNormColumnName.PMProjectNormItem, false, true);
            AddTreeListColumns(7, ProjectNormColumnName.PMProjectNormProductDesc, true, false);
            AddTreeListColumns(8, ProjectNormColumnName.PMProjectNormStatus, false, true);
            AddTreeListColumns(9, ProjectNormColumnName.PMProjectNormStartDate, false, true);
            AddTreeListColumns(10, ProjectNormColumnName.PMProjectNormEndDate, false, true);
            AddTreeListColumns(11, ProjectNormColumnName.PMProjectNormIsApproved, false, true);

        }

        public void AddTreeListColumns(int index, ProjectNormColumnName fieldName, bool readOnly, bool allowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.VisibleIndex = index;
            column.FieldName = fieldName.ToString();
            column.OptionsColumn.ReadOnly = readOnly;
            column.OptionsColumn.AllowEdit = allowEdit;
            this.OptionsView.AutoWidth = false;
            column.OptionsColumn.FixedWidth = false;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit;
            RepositoryItemTextEdit repositoryItemTextEdit;
            RepositoryItemDateEdit repositoryItemDateEdit;
            LookUpColumnInfo columnInfo;
            switch (fieldName)
            {
                case ProjectNormColumnName.PMProjectNormProductName:
                    column.MinWidth = 400;
                    break;

                case ProjectNormColumnName.PMProjectNormProductQty:
                    repositoryItemTextEdit = new RepositoryItemTextEdit()
                    {
                        Mask =
                        {
                            MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                            EditMask = "n2",
                            UseMaskAsDisplayFormat = true
                        }
                    };
                    column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.Format.FormatString = "#,##0.00";
                    column.MinWidth = 50;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
                    break;

                case ProjectNormColumnName.PMProjectNormProductType:
                    column.MinWidth = 100;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = (object)ProjectNormProductTypeDataTable;
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

                case ProjectNormColumnName.PMProjectNormStatus:
                    column.MinWidth = 100;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = (object)ProjectNormStatusDataTable;
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

                case ProjectNormColumnName.PMProjectNormIsApproved:
                    column.MinWidth = 50;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemCheckEdit;
                    this.RepositoryItems.Add(repositoryItemCheckEdit);
                    break;

                case ProjectNormColumnName.FK_ICMeasureUnitID:
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

                case ProjectNormColumnName.PMProjectNormSortOrder:
                    column.MinWidth = 50;
                    break;

                case ProjectNormColumnName.PMProjectNormItem:
                    column.MinWidth = 100;
                    column.Caption = ProjectLocalizedResources.PMProjectNormItemCaption;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    RepositoryItemHyperLinkEdit rpItem = new RepositoryItemHyperLinkEdit();
                    rpItem.NullText = string.Empty;
                    rpItem.Click += new EventHandler(RpItem_Click);
                    column.ColumnEdit = rpItem;
                    break;

                case ProjectNormColumnName.PMProjectNormProductDesc:
                    column.MinWidth = 200;
                    break;
                case ProjectNormColumnName.PMProjectNormStartDate:
                    repositoryItemDateEdit = new RepositoryItemDateEdit()
                    {
                        Mask =
                        {
                            MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime,
                            EditMask = "dd/MM/yyyy",
                            UseMaskAsDisplayFormat = true
                        }
                    };
                    column.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
                    column.MinWidth = 80;
                    column.Format.FormatString = "dd/MM/yyyy";
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemDateEdit;
                    break;
                case ProjectNormColumnName.PMProjectNormEndDate:
                    repositoryItemDateEdit = new RepositoryItemDateEdit()
                    {
                        Mask =
                        {
                            MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime,
                            EditMask = "dd/MM/yyyy",
                            UseMaskAsDisplayFormat = true
                        }
                    };
                    column.Format.FormatType = DevExpress.Utils.FormatType.DateTime;
                    column.MinWidth = 80;
                    column.Format.FormatString = "dd/MM/yyyy";
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemDateEdit;
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
                if (MessageBox.Show(ProjectLocalizedResources.ProjectNormConfrimDeleteMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                ((ProjectModule)Screen.Module).DeleteProjectNormFromTreeList();
            }
        }

        private void RpItem_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Screen.Module).ShowProjectNormItem();
        }

        private void TreeList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == ProjectNormColumnName.PMProjectNormProductType.ToString()
                || e.Column.FieldName == ProjectNormColumnName.PMProjectNormSortOrder.ToString()
                || e.Column.FieldName == ProjectNormColumnName.FK_ICMeasureUnitID.ToString()
                || e.Column.FieldName == ProjectNormColumnName.PMProjectNormStatus.ToString()
                || e.Column.FieldName == ProjectNormColumnName.PMProjectNormIsApproved.ToString())
                ((ProjectModule)Screen.Module).ChangedProjectNorm();
            if (e.Column.FieldName == ProjectNormColumnName.PMProjectNormProductQty.ToString())
                ((ProjectModule)Screen.Module).ChangedProjectNormQty();
            if (e.Column.FieldName == ProjectNormColumnName.PMProjectNormStartDate.ToString())
                ((ProjectModule)Screen.Module).UpdateStartDay();
        }

        private void TreeList_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ProjectEntities entity = (ProjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.ProjectNormList.IsSwitchToEdit = false;
        }
    }
}
