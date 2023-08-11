using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionPlanning
{
    public partial class ARSaleOrderItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "FK_ARCustomerID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "PI";
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "ARSaleOrderName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ARSaleOrderNo"];

            if (column != null)
            {
                column.Group();
            }
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }

    }
}
