using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Estimate
{
    public partial class EstimateItemsTreeListControl : BOSTreeListControl
    {
        private List<AAColumnAliasInfo> ColumnAliasList { get; set; }

        private DataTable EstimateItemTypeDataTable { get; set; }

        private DataTable MeasureUnitDataTable { get; set; }

        public enum EstimateItemColumnName
        {
            AREstimateItemProductName,
            FK_ICMeasureUnitID,
            AREstimateItemProductQty,
            AREstimateItemType,
            AREstimateItemProductUnitPrice,
            AREstimateItemTotalAmount,
            AREstimateItemProductDesc,
            AREstimateItemProductWorkUnitPrice,
            AREstimateItemProductMaterialUnitPrice,
            AREstimateItemProductEquipmentUnitPrice,
            AREstimateItemWorkTotalAmount,
            AREstimateItemMaterialTotalAmount,
            AREstimateItemEquipmentTotalAmount,
        }

        public enum MeasureUnitColumnName
        {
            ICMeasureUnitID,
            ICMeasureUnitName,
        }

        protected override void InitTreeListDataSource()
        {
            EstimateEntities entity = (EstimateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource = entity.EstimateItemsList;
            DataSource = dataSource;
        }

        public override void InitializeControl()
        {
            TreeList treeList = this;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsBehavior.DragNodes = true;
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.ForceInitialize();
            this.BestFitColumns();
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(TreeList_CellValueChanged);
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            ColumnAliasList = new List<AAColumnAliasInfo>();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.AREstimateItemsTableName);

            foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
            {
                AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                ColumnAliasList.Add(objAAColumnAliasInfo);
            }

            EstimateItemTypeDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(EstimateItemColumnName.AREstimateItemType.ToString().Substring(2));
            if (ds != null)
                EstimateItemTypeDataTable = ds.Tables[0];

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            DataSet ds1 = objMeasureUnitsController.GetAllObjects();
            if (ds1 != null)
                MeasureUnitDataTable = ds1.Tables[0];

            AddTreeListColumns(1, EstimateItemColumnName.AREstimateItemProductName, true, false);
            AddTreeListColumns(2, EstimateItemColumnName.FK_ICMeasureUnitID, false, true);
            AddTreeListColumns(3, EstimateItemColumnName.AREstimateItemProductQty, false, true);
            AddTreeListColumns(4, EstimateItemColumnName.AREstimateItemProductWorkUnitPrice, true, false);
            AddTreeListColumns(5, EstimateItemColumnName.AREstimateItemProductMaterialUnitPrice, true, false);
            AddTreeListColumns(6, EstimateItemColumnName.AREstimateItemProductUnitPrice, false, true);
            AddTreeListColumns(7, EstimateItemColumnName.AREstimateItemWorkTotalAmount, true, false);
            AddTreeListColumns(8, EstimateItemColumnName.AREstimateItemMaterialTotalAmount, true, false);
            AddTreeListColumns(9, EstimateItemColumnName.AREstimateItemTotalAmount, true, false);
            AddTreeListColumns(10, EstimateItemColumnName.AREstimateItemType, false, true);
            AddTreeListColumns(11, EstimateItemColumnName.AREstimateItemProductDesc, true, false);
        }

        public void AddTreeListColumns(int index, EstimateItemColumnName fieldName, bool readOnly, bool allowEdit)
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
            LookUpColumnInfo columnInfo;
            switch (fieldName)
            {
                case EstimateItemColumnName.AREstimateItemProductName:
                    column.MinWidth = 400;
                    break;

                case EstimateItemColumnName.AREstimateItemType:
                    column.MinWidth = 100;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = (object)EstimateItemTypeDataTable;
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

                case EstimateItemColumnName.AREstimateItemProductQty:
                    repositoryItemTextEdit = new RepositoryItemTextEdit()
                    {
                        Mask =
                        {
                            MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                            EditMask = "n3",
                            UseMaskAsDisplayFormat = true
                        }
                    };
                    column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.Format.FormatString = "#,##0.000";
                    column.MinWidth = 60;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    break;

                case EstimateItemColumnName.AREstimateItemProductUnitPrice:
                case EstimateItemColumnName.AREstimateItemProductWorkUnitPrice:
                case EstimateItemColumnName.AREstimateItemProductMaterialUnitPrice:
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
                    column.Format.FormatString = "#,##0.000";
                    column.MinWidth = 100;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    break;

                case EstimateItemColumnName.AREstimateItemTotalAmount:
                case EstimateItemColumnName.AREstimateItemWorkTotalAmount:
                case EstimateItemColumnName.AREstimateItemMaterialTotalAmount:
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
                    column.MinWidth = 100;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    break;

                case EstimateItemColumnName.FK_ICMeasureUnitID:
                    column.MinWidth = 60;
                    column.OptionsColumn.AllowEdit = allowEdit;
                    repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DataSource = MeasureUnitDataTable;
                    repositoryItemLookUpEdit.ValueMember = MeasureUnitColumnName.ICMeasureUnitID.ToString();
                    repositoryItemLookUpEdit.DisplayMember = MeasureUnitColumnName.ICMeasureUnitName.ToString();
                    repositoryItemLookUpEdit.ShowHeader = false;
                    repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                    columnInfo = new LookUpColumnInfo();
                    columnInfo.FieldName = MeasureUnitColumnName.ICMeasureUnitName.ToString();
                    columnInfo.Width = 150;
                    repositoryItemLookUpEdit.Columns.Add(columnInfo);
                    repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                    column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                    this.RepositoryItems.Add(repositoryItemLookUpEdit);
                    break;

                case EstimateItemColumnName.AREstimateItemProductDesc:
                    column.MinWidth = 400;
                    break;
            }

            AAColumnAliasInfo objColumnAliasInfo = ColumnAliasList.Where(s => s.AAColumnAliasName == fieldName.ToString()).FirstOrDefault();
            column.Caption = objColumnAliasInfo == null ? column.Caption : objColumnAliasInfo.AAColumnAliasCaption;

            this.EndUpdate();
            this.Update();
        }

        private void RpItem_Click(object sender, EventArgs e)
        {
            //((ProjectModule)Screen.Module).ShowProjectNormItem();
        }

        private void TreeList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == EstimateItemColumnName.AREstimateItemProductQty.ToString()
                || e.Column.FieldName == EstimateItemColumnName.AREstimateItemProductUnitPrice.ToString())
                ((EstimateModule)Screen.Module).ChangeEstimateItemQty();
        }
    }
}
