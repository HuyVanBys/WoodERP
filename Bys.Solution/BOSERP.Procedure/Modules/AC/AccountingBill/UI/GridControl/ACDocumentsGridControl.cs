using BOSCommon;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.AccountingBill
{
    public partial class ACDocumentsGridControl : BOSSearchResultsGridControl
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

                ACDocumentsController controller = new ACDocumentsController();
                ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)controller.GetObjectFromDataRow(row.Row);
                if (objDocumentsInfo != null)
                {
                    if (objDocumentsInfo.ACDocumentStatus == DocumentStatus.Canceled.ToString())
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
