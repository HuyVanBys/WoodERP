using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public class HRKPIRegistrationItemTargetsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.KPIRegistrationItemTargetsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HRKPIRegistrationItemTargetToTalWeightBonus"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 3;
            }

            column = gridView.Columns["HRKPIRegistrationItemTargetName"];
            if (column != null)
            {
                column.VisibleIndex = 1;
            }

            column = gridView.Columns["HRKPIRegistrationItemTargetTotalTarget"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
                column.VisibleIndex = 2;
            }

            return gridView;
        }
    }
}
