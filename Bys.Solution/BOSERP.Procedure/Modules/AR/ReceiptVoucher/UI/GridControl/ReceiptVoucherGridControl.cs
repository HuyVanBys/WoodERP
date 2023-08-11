using BOSCommon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.ReceiptVoucher
{
    public partial class ReceiptVoucherGridControl : BOSSearchResultsGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReceiptVoucherLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            gridView.Columns.Add(column);
        }

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

                ARReceiptVouchersController controller = new ARReceiptVouchersController();
                ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)controller.GetObjectFromDataRow(row.Row);
                if (objReceiptVouchersInfo != null)
                {
                    if (objReceiptVouchersInfo.ARReceiptVoucherStatus == ReceiptVoucherStatus.Canceled.ToString())
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.Red;
                        e.HighPriority = true;
                    }
                }
            }
        }
    }
}
