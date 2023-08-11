using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.BranchStatistics
{
    public partial class APOwingInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BranchStatisticsEntities entity = (BranchStatisticsEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.APOwingInvoiceInList;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            InitColumnSummary("APInvoiceInTotalCost", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("APInvoiceInDepositBalance", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("APInvoiceInBalanceDue", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }
    }
}
