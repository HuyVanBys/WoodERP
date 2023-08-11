using BOSCommon;
using BOSCommon.Constants;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetDecreasing
{
    public class ShipmentItemGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;

            gridView.Columns.Add(column);
        }
        private void AddNewRow_Click(object sender, EventArgs e)
        {
            AssetDecreasingEntities entity = (AssetDecreasingEntities)(this.Screen.Module as AssetDecreasingModule).CurrentModuleEntity;
            ICShipmentsInfo ShipmentItemsInfo = (ICShipmentsInfo)entity.MainObject;
            if (ShipmentItemsInfo.ICShipmentStatus != ShipmentStatus.Complete.ToString())
            {
                (this.Screen.Module as AssetDecreasingModule).ActionEdit();
            }
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex].Clone();
            objShipmentItemsInfo.Id = 0;
            entity.ShipmentItemList.Add(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HREmployeeUserID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAssetID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACDepreciationCostAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnLookupEdit(TableName.ACAccountsTableName, EquipmentShipmentLocalizedResources.ACAccountNo, column.FieldName);
            }

            column = gridView.Columns["FK_ICProductIdentifiedEquipmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            AssetDecreasingEntities entity = (AssetDecreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((AssetDecreasingModule)Screen.Module).ResetModelDetail(item);
                }
                if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                {
                    ((AssetDecreasingModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else
                {
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    if (e.Column.FieldName == "ICShipmentItemProductQty")
                    {
                        ((AssetDecreasingModule)Screen.Module).ChangeItemQty();
                    }
                    (entity.Module as AssetDecreasingModule).ChangeItemFromShipmentItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AssetDecreasingModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }
    }
}
