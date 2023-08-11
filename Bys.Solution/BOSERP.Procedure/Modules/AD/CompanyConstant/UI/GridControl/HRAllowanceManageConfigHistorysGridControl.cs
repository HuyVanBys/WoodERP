using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class HRAllowanceManageConfigHistorysGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AllowanceManageConfigHistorysList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        public void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedHRAllowanceManageConfigHistorys();
            }
        }
        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    GridView gridView = (GridView)sender;
        //    if (e.KeyCode == Keys.Delete)
        //    {                
        //        if (gridView.FocusedRowHandle >= 0)
        //        {
        //            ((CompanyConstantModule)Screen.Module).RemoveSelectedAllowanceManageConfigHistorys();
        //        }
        //    }
        //}
    }
}
