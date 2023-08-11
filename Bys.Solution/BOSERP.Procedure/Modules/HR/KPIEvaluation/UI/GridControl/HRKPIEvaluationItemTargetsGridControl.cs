using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIEvaluation
{
    public class HRKPIEvaluationItemTargetsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.KPIEvaluationItemTargetsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HRKPIEvaluationItemTargetName"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 1;
            }

            column = gridView.Columns["HRKPIEvaluationItemTargetTotalTarget"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 2;
            }

            column = gridView.Columns["HRKPIEvaluationItemTargetTotalResult"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 3;
            }

            column = gridView.Columns["HRKPIEvaluationItemTargetToTalWeightBonus"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["HRKPIEvaluationItemTargetTotalAmount"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 5;
            }

            return gridView;
        }
    }
}
