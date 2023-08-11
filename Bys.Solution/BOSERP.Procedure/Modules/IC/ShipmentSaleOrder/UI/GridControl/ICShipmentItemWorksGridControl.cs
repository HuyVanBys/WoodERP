using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ICShipmentItemWorksGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            //bds.DataSource = entity.ShipmentItemWorkList;
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
            column.Caption = "Mã công việc";
            column.FieldName = "ICShipmentItemProductSerialNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên công việc";
            column.FieldName = "ICShipmentItemProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "ICShipmentItemProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }


    }
}
