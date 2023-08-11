using System.Windows.Forms;

namespace BOSERP.Modules.ReturnSupplier
{
    public partial class ICProductsGridControl : BOSComponent.BOSGridControl
    {


        public override void InitGridControlDataSource()
        {
            //base.InitGridControlDataSource();
            ReturnSupplierEntities entity = (ReturnSupplierEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductsList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //Set all column allwi edit .
            gridView.Columns["AASelected"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

    }
}
