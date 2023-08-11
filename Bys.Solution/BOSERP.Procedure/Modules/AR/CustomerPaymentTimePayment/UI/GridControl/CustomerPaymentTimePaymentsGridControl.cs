using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CustomerPaymentTimePayment
{
    public class CustomerPaymentTimePaymentsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARCustomerPaymentTimePaymentList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            GridColumn column = gridView.Columns["ARCustomerPaymentTimePaymentPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARCustomerPaymentTimePaymentAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ARSaleContractID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARCustomerPaymentTimePaymentBankFeeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARCustomerPaymentTimePaymentExchangeRate"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["GECurrencyNo"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerPaymentTimePaymentModule)Screen.Module).DeleteSelectedInvoice();
            }
        }

        //protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);

        //    GridColumn column = new GridColumn();
        //    column.FieldName = "ARInvoiceVATInvoiceNo";
        //    column.Caption = "Số hóa đơn";
        //    column.OptionsColumn.AllowEdit = false;
        //    gridView.Columns.Add(column);
        //}

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            if (gridView.FocusedRowHandle >= 0)
            {
                CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ARCustomerPaymentTimePaymentsInfo objPaymentsInfo = (ARCustomerPaymentTimePaymentsInfo)gridView.GetRow(e.RowHandle);
                if (objPaymentsInfo != null)
                {
                    if (e.Column.FieldName == "ARCustomerPaymentTimePaymentAmount")
                    {
                        bool isValid = ((CustomerPaymentTimePaymentModule)Screen.Module).ChangeProposalPaymentAmount(objPaymentsInfo, false);
                        if (!isValid)
                        {
                            entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                    else if (e.Column.FieldName == "ARCustomerPaymentTimePaymentPercent")
                    {
                        bool isValid = ((CustomerPaymentTimePaymentModule)Screen.Module).ChangeProposalPaymentAmount(objPaymentsInfo, true);
                        if (!isValid)
                        {
                            entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                    else if (e.Column.FieldName == "ARCustomerPaymentTimePaymentBankFeeAmount")
                    {
                        bool isValid = ((CustomerPaymentTimePaymentModule)Screen.Module).ChangeProposalPaymentAmount(objPaymentsInfo, false);
                        if (!isValid)
                        {
                            entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentBankFeeAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        }
                    }
                    ((CustomerPaymentTimePaymentModule)Screen.Module).UpdateTotalAmount();
                }
            }
        }
    }
}
