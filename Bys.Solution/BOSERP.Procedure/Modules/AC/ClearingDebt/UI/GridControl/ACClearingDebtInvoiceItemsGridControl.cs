using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.ClearingDebt
{
    public class ACClearingDebtInvoiceItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearingDebtEntities entity = (ClearingDebtEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
                if (column.FieldName == "ACClearingDebtInvoiceItemGroup")
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
                ((ClearingDebtModule)Screen.Module).DeleteSelectedInvoice();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                ClearingDebtEntities entity = (ClearingDebtEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ACClearingDebtInvoiceItemsInfo objPaymentsInfo = (ACClearingDebtInvoiceItemsInfo)gridView.GetRow(e.RowHandle);
                if (objPaymentsInfo != null)
                {
                    if (e.Column.FieldName == "ACClearingDebtInvoiceItemAmountClearing")
                    {
                        decimal isValid = entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ACClearingDebtInvoiceItemTotalAmount
                                        - (entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ACClearingDebtInvoiceItemPaidAmount
                                        + entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ACClearingDebtInvoiceItemAmountClearing);
                        if (isValid < 0)
                        {
                            MessageBox.Show(ClearingDebtLocalizedResources.BigAmount, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ACClearingDebtInvoiceItemAmountClearing = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                        else
                        {
                            entity.InvoiceItemList[entity.InvoiceItemList.CurrentIndex].ACClearingDebtInvoiceItemRemainAmount = isValid;
                        }
                    }
                    //    else if (e.Column.FieldName == "ARCustomerPaymentTimePaymentPercent")
                    //    {
                    //        bool isValid = ((CustomerPaymentTimePaymentModule)Screen.Module).ChangeProposalPaymentAmount(objPaymentsInfo, true);
                    //        if (!isValid)
                    //        {
                    //            entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    //        }
                    //    }
                    //    ((CustomerPaymentTimePaymentModule)Screen.Module).UpdateTotalAmount();
                }
                ((ClearingDebtModule)Screen.Module).UpdateDocumentEntriesExt();
            }
        }
    }
}
