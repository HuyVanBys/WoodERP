using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryStatistics
{
    public partial class InventoryStatisticsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InventoryStatisticsEntities entity = (InventoryStatisticsEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICTransactionStatisticsList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ICTransactionReceiptBalance"] != null)
            {
                gridView.Columns["ICTransactionReceiptBalance"].Caption = "Giá trị nhập";
            }
            if (gridView.Columns["ICTransactionShipmentBalance"] != null)
            {
                gridView.Columns["ICTransactionShipmentBalance"].Caption = "Giá trị xuất";
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ICMeasureUnitName";
            column.Caption = "ĐVT";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName2";
            column.Caption = "Tên tiếng việt";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((InventoryStatisticsModule)Screen.Module).ShowInventoryLeadgerModule();
        }
    }
}
