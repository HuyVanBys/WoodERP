using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.BalanceAmountArising
{
    public partial class ACBalanceAmountArisingObjectDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BalanceAmountArisingObjectDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }
    }
}
