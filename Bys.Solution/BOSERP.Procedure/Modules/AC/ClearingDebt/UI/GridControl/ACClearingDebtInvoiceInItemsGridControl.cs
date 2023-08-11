using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.ClearingDebt
{
    public class ACClearingDebtInvoiceInItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
                if (column.FieldName == "ACClearingDebtInvoiceInItemGroup")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (column.FieldName == "FK_ACAccountID")
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
                ((ClearingDebtModule)Screen.Module).DeleteSelectedInvoiceIn();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ClearingDebtEntities entity = (ClearingDebtEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ACClearingDebtInvoiceInItemsInfo objInvoiceInInfo = (ACClearingDebtInvoiceInItemsInfo)gridView.GetRow(e.RowHandle);
                if (objInvoiceInInfo != null)
                {
                    if (e.Column.FieldName == "ACClearingDebtInvoiceInItemAmountClearing")
                    {
                        decimal isValid = entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].ACClearingDebtInvoiceInItemTotalAmount
                                        - (entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].ACClearingDebtInvoiceInItemPaidAmount
                                        + entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].ACClearingDebtInvoiceInItemAmountClearing);
                        if (isValid < 0)
                        {
                            MessageBox.Show(ClearingDebtLocalizedResources.BigAmount, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].ACClearingDebtInvoiceInItemAmountClearing = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        else
                        {
                            entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex].ACClearingDebtInvoiceInItemRemainAmount = isValid;
                        }
                    }
                }
                ((ClearingDebtModule)Screen.Module).UpdateDocumentEntriesExt();
            }
        }
    }
}
