using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class ICModelsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ModelList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            // gridView.CustomRowCellEdit
            return gridView;
        }


        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                // if (gridView.FocusedRowHandle >= 0)
                // {
                ((ProductConstantModule)Screen.Module).RemoveSelectModelConfig();
                // }
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICModelsInfo objModelsInfo = (ICModelsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((ProductConstantModule)Screen.Module).InvalidateModelDetailConfigs(objModelsInfo);
            }
        }
        public ICModelsInfo GetCurrentModel()
        {
            GridView gridView = (GridView)MainView;
            ICModelsInfo objModelsInfo = (ICModelsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            return objModelsInfo;
        }
    }
}
