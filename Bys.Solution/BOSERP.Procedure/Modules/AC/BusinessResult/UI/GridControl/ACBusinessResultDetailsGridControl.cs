using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.BusinessResult
{
    public partial class ACBusinessResultDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BusinessResultEntities entity = (BusinessResultEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACBusinessResultDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }

    }
}
