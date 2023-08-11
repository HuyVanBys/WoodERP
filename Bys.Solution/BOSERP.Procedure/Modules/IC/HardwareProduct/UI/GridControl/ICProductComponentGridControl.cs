using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.HardwareProduct
{
    public class ICProductComponentGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            HardwareProductEntities entity = (HardwareProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductComponentsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductName;
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductDesc;
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductComponentQty"] != null)
            {
                gridView.Columns["ICProductComponentQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductComponentDesc"] != null)
            {
                gridView.Columns["ICProductComponentDesc"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HardwareProductModule)Screen.Module).DeleteItemFromICProductComponentsList();
            }
        }
    }
}
