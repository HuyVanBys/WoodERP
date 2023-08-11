using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.Package
{
    public partial class ICProductsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PackageEntities entity = (PackageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PackageProductList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = PackageProductLocalizedResources.ICPackageProductQty;
            column.FieldName = "ICPackageProductQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
