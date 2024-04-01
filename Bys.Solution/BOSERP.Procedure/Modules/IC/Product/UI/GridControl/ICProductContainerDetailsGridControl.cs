using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.Product
{
    public partial class ICProductContainerDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductContainerDetailList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowFooter = false;
            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName != "ICProductContainerType")
                    col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
