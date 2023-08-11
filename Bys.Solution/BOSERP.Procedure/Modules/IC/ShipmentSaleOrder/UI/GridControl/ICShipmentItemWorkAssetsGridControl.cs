using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ICShipmentItemWorkAssetsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            //bds.DataSource = entity.ShipmentItemWorkAssetList;
            this.DataSource = bds;
        }

        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

        //    return gridView;
        //}

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã thiết bị";
            column.FieldName = "ICShipmentItemProductSerialNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên thiết bị";
            column.FieldName = "ICShipmentItemProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
        //    if (gridView.Columns["ICShipmentItemProductQty"] != null)
        //    {
        //        gridView.Columns["ICShipmentItemProductQty"].OptionsColumn.AllowEdit = true;
        //    }
        //    if (gridView.Columns["ICShipmentItemProductDesc"] != null)
        //    {
        //        gridView.Columns["ICShipmentItemProductDesc"].OptionsColumn.AllowEdit = true;
        //    }
        //    return gridView;
        //}
    }
}
