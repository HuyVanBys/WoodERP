using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADTemplatesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TemplatesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.FocusedRowChanged += GridView_FocusedRowChanged1;
            return gridView;
        }

        private void GridView_FocusedRowChanged1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gv = (GridView)MainView;
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)gv.GetFocusedRow();
            if (objADTemplatesInfo == null)
                objADTemplatesInfo = new ADTemplatesInfo();
            entity.InvalidateModuleObject(objADTemplatesInfo);
            //(Screen.Module as CompanyConstantModule).
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedTemplates();
            }
        }
    }
}
