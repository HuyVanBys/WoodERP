using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.HREvaluationStandard
{
    public partial class HREvaluationRanksGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HREvaluationStandardEntities entity = (HREvaluationStandardEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            HREvaluationRanksController objEvaluationRanksController = new HREvaluationRanksController();
            DataSet ds = objEvaluationRanksController.GetAllObjects();
            entity.HREvaluationRankList.Invalidate(ds);
            bds.DataSource = entity.HREvaluationRankList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HREvaluationRankName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREvaluationRankFromValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREvaluationRankToValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }
    }
}
