using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.ClearInvoice
{
    public class ARClearInvoiceDocumentsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DocumentList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "ARClearInvoiceDocumentAllocationAmount")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ClearInvoiceModule)Screen.Module).DeleteSelectedInvoice();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ClearInvoiceEntities entity = (ClearInvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARClearInvoicesInfo objClearInvoicesInfo = (ARClearInvoicesInfo)entity.MainObject;
                ARClearInvoiceDocumentsInfo objPaymentsInfo = (ARClearInvoiceDocumentsInfo)gridView.GetRow(e.RowHandle);
                if (objPaymentsInfo != null)
                {
                    if (gridView.FocusedColumn.FieldName == "ARClearInvoiceDocumentAllocationAmount")
                    {
                        objPaymentsInfo.ARClearInvoiceDocumentExchangeAmount = objPaymentsInfo.ARClearInvoiceDocumentAllocationAmount 
                                                                                    * objPaymentsInfo.ARClearInvoiceDocumentExchangeRate
                                                                                    / (objClearInvoicesInfo.ARClearInvoiceExchangeRate == 0 ? 1 : objClearInvoicesInfo.ARClearInvoiceExchangeRate);
                        if (objPaymentsInfo.ARClearInvoiceDocumentAllocationAmount > objPaymentsInfo.ARClearInvoiceDocumentRemainAmount)
                        {
                            MessageBox.Show(ClearInvoiceInLocalizedResources.ErrorAllocationAmount,
                                            BaseLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            entity.DocumentList[entity.DocumentList.CurrentIndex].ARClearInvoiceDocumentAllocationAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                }
            }
        }
    }
}
