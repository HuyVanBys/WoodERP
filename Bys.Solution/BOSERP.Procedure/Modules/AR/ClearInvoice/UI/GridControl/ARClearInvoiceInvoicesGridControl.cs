using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.ClearInvoice
{
    public class ARClearInvoiceInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearInvoiceEntities entity = (ClearInvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "ARClearInvoiceInvoiceAllocationAmount")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            GridColumn columnCurrency = gridView.Columns["FK_GECurrencyID"];
            if (columnCurrency != null)
            {
                columnCurrency.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpCurrency = new RepositoryItemLookUpEdit();
                rpCurrency.DisplayMember = "GECurrencyName";
                rpCurrency.ValueMember = "GECurrencyID";
                rpCurrency.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet;
                rpCurrency.DataSource = ds.Tables[0];
                columnCurrency.ColumnEdit = rpCurrency;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ClearInvoiceModule)Screen.Module).DeleteSelectedInvoiceIn();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ClearInvoiceEntities entity = (ClearInvoiceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARClearInvoiceInvoicesInfo objPaymentsInfo = (ARClearInvoiceInvoicesInfo)gridView.GetRow(e.RowHandle);
                if (objPaymentsInfo != null)
                {
                    if (gridView.FocusedColumn.FieldName == "ARClearInvoiceInvoiceAllocationAmount")
                    {
                        if (objPaymentsInfo.ARClearInvoiceInvoiceAllocationAmount > objPaymentsInfo.ARClearInvoiceInvoiceRemainAmount)
                        {
                            MessageBox.Show(ClearInvoiceInLocalizedResources.ErrorAllocationAmount,
                                            BaseLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ARClearInvoiceInvoiceAllocationAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        else
                        {
                            ((ClearInvoiceModule)Screen.Module).ChangeAllocationAmount();
                        }
                    }
                }
            }
        }
    }
}
