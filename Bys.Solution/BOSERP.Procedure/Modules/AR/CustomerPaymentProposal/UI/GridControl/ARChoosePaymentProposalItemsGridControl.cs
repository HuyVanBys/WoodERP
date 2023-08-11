using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BOSERP.Modules.CustomerPaymentProposal
{
    public partial class ARChoosePaymentProposalItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARPaymentProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CustomerPaymentProposalLocalizedResources.WaitingPayment;
            column.FieldName = "ARPaymentProposalItemWaitingPayment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
