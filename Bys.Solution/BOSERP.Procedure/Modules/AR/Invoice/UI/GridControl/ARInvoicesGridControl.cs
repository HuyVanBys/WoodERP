using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.Invoice
{
    partial class ARInvoicesGridControl : BOSSearchResultsGridControl
    {

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (e.RowHandle >= 0)
            {
                DataRowView row = (DataRowView)gridview.GetRow(e.RowHandle);
                if (row == null)
                    return;

                ARInvoicesController controller = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)controller.GetObjectFromDataRow(row.Row);
                if (objInvoicesInfo != null)
                {
                    if (objInvoicesInfo.ARInvoiceBalanceDue == objInvoicesInfo.ARInvoiceTotalAmount)
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                    else if (objInvoicesInfo.ARInvoiceBalanceDue == 0)
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.LightGreen;
                        e.HighPriority = true;
                    }
                    else if (objInvoicesInfo.ARInvoiceBalanceDue < objInvoicesInfo.ARInvoiceTotalAmount)
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.Yellow;
                        e.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "ĐNXK";
            column.FieldName = "ARDeliveryPlanNosList";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
