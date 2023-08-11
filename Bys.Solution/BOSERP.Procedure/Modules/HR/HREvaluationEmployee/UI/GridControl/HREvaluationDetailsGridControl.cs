using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationEmployee
{
    class HREvaluationDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREvaluationDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["HREvaluationDetailResult"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
