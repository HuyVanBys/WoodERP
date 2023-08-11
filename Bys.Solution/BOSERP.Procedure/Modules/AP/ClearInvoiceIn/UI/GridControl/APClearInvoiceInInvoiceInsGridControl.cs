using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.ClearInvoiceIn
{
    public class APClearInvoiceInInvoiceInsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearInvoiceInEntities entity = (ClearInvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                if (column.FieldName == "APClearInvoiceInInvoiceInAllocationAmount")
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
                ((ClearInvoiceInModule)Screen.Module).DeleteSelectedInvoiceIn();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ClearInvoiceInEntities entity = (ClearInvoiceInEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                APClearInvoiceInInvoiceInsInfo objPaymentsInfo = (APClearInvoiceInInvoiceInsInfo)gridView.GetRow(e.RowHandle);
                if (objPaymentsInfo != null)
                {
                    if (gridView.FocusedColumn.FieldName == "APClearInvoiceInInvoiceInAllocationAmount")
                    {
                        if (objPaymentsInfo.APClearInvoiceInInvoiceInAllocationAmount > objPaymentsInfo.APClearInvoiceInInvoiceInRemainAmount)
                        {
                            MessageBox.Show(ClearInvoiceInLocalizedResources.ErrorAllocationAmount,
                                            BaseLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].APClearInvoiceInInvoiceInAllocationAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        else
                        {
                            ((ClearInvoiceInModule)Screen.Module).ChangeAllocationAmount();
                        }
                    }
                }

            }
        }
    }
}
