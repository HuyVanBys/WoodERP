using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.Product
{
    public partial class ICProductTolenrancesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductTolenrancesList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName != "ICProductTolenranceType")
                    col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
