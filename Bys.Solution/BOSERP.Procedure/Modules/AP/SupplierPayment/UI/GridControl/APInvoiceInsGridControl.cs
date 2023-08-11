using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPayment
{
    public class APInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.APInvoiceInList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((SupplierPaymentModule)Screen.Module).DeleteSelectedInvoice();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SupplierPaymentLocalizedResources.APDocumentPaymentAmountCaption;
            column.FieldName = "APDocumentPaymentAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                APInvoiceInsInfo objInvoiceInsInfo = (APInvoiceInsInfo)gridView.GetRow(e.RowHandle);
                if (objInvoiceInsInfo != null)
                {
                    if (e.Column.FieldName == "APDocumentPaymentAmount")
                    {
                        ((SupplierPaymentModule)Screen.Module).ChangeInvoicePaymentAmount(objInvoiceInsInfo);
                    }
                }
            }
        }
    }
}
