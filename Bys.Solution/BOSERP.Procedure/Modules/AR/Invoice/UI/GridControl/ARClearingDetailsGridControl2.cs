using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ARClearingDetailsGridControl2 : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceEntities entity = (InvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentDetailList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((InvoiceModule)Screen.Module).DeleteItemFromPaymentItemsList();
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

            GridColumn column = gridView.Columns["ARClearingDetailAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["FK_ARCustomerPaymentID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            InitColumnSummary("ARClearingDetailAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }
    }
}
