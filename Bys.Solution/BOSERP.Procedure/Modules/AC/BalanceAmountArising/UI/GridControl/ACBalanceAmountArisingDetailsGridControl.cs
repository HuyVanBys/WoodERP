using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.BalanceAmountArising
{
    public partial class ACBalanceAmountArisingDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BalanceAmountArisingEntities entity = (BalanceAmountArisingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BalanceAmountArisingDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.ShowFooter = true;
            //gridView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            //InitColumnSummary("ACBalanceAmountArisingDetailStartPeriodDebitBalance", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ACBalanceAmountArisingDetailStartPeriodCreditBalance", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ACBalanceAmountArisingDetailPeriodDebitBalance", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ACBalanceAmountArisingDetailPeriodCreditBalance", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ACBalanceAmountArisingDetailEndPeriodDebitBalance", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ACBalanceAmountArisingDetailEndPeriodCreditBalance", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }
    }
}
