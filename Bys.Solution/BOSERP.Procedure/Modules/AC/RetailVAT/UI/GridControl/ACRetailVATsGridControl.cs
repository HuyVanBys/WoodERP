using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Drawing;
using BOSCommon;

namespace BOSERP.Modules.RetailVAT
{
    partial class ACRetailVATsGridControl : BOSSearchResultsGridControl
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

                ACRetailVATsController controller = new ACRetailVATsController();
                ACRetailVATsInfo objRetailVATsInfo = (ACRetailVATsInfo)controller.GetObjectFromDataRow(row.Row);
                if (objRetailVATsInfo != null)
                {
                    if (objRetailVATsInfo.ACRetailVATStatus == RetailVATStatus.New.ToString())
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                    else if (objRetailVATsInfo.ACRetailVATStatus == RetailVATStatus.Completed.ToString())
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.Yellow;
                        e.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.LightGreen;
                        e.HighPriority = true;
                    }
                }
            }
        }
    }
}
