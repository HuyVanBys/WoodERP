using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class ICWidthGroupsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICWidthGroupsList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedICWidthGroups();
            }
        }
    }
}
