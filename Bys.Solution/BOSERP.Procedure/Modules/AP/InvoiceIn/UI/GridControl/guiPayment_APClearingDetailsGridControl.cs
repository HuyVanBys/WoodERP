using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public class guiPayment_APClearingDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentDetailList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((InvoiceInModule)Screen.Module).DeleteItemFromPaymentItemsList();
                MessageBox.Show(InvoiceLocalizedResources.ErrorDeleteItemFromPaymentItemsList,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("APClearingDetailAmount", DevExpress.Data.SummaryItemType.Sum);

            GridColumn column = gridView.Columns["APClearingDetailAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }
    }
}
