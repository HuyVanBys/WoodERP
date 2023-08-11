using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.InventoryLeadger
{
    public partial class InventoryLeadgerGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InventoryLeadgerEntities entity = (InventoryLeadgerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICTransactionsList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Số thanh (Tấm)";
            column.FieldName = "ICTransactionQty1";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn vị tính";
            column.FieldName = "ICMeasureUnitName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((InventoryLeadgerModule)Screen.Module).ShowReffModule();
        }
    }
}
