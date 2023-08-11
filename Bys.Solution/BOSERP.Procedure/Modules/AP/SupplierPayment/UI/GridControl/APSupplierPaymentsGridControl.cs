using BOSCommon;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.SupplierPayment
{
    public partial class APSupplierPaymentsGridControl : BOSSearchResultsGridControl
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

                APSupplierPaymentsController controller = new APSupplierPaymentsController();
                APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)controller.GetObjectFromDataRow(row.Row);
                if (objSupplierPaymentsInfo != null)
                {
                    if (objSupplierPaymentsInfo.APSupplierPaymentStatus == SupplierPaymentStatus.Canceled.ToString())
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
