using BOSCommon.Constants;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentCD
{
    public class ICShipmentItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentCDEntities entity = (ShipmentCDEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n4}";
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemProductDesc"];
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

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                {
                    ((ShipmentCDModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((ShipmentCDModule)Screen.Module).SelectSeriesNoDefault();
                    ((ShipmentCDModule)Screen.Module).ChangeItemSerieNo(item);
                }

                else
                {
                    ShipmentCDEntities entity = (ShipmentCDEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    ((ShipmentCDModule)Screen.Module).ChangeItemFromShipmentItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentCDModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }
    }
}
