using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class ARProductionPlanningItemsGridControl : ItemGridControl
    {
        public void InvalidateDataSource(List<ARProductionPlanningItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ARProductionPlanningID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Tên SP tiếng Việt";
            newColumn.FieldName = "ICProductName2";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "ARProductionPlanningItemSaleOrderName";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }
    }
}
