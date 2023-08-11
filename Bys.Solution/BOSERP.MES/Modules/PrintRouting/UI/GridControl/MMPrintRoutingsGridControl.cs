using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.PrintRouting
{
    public partial class PrintRoutingGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PrintRoutingEntities entity = (PrintRoutingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PrintRoutingList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.Columns["MMPrintRoutingProductQty"].OptionsColumn.AllowEdit = true;
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    PrintRoutingEntities entity = (PrintRoutingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    entity.PrintRoutingList.RemoveSelectedRowObjectFromList();
                }
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            MMPrintRoutingsInfo item = (MMPrintRoutingsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "MMPrintRoutingProductQty")
                {
                    ((PrintRoutingModule)Screen.Module).UpdateQualityForItems(item);
                }
            }


        }

    }
}
