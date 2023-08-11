using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ProductWorkItemTasksGridControl : BOSGridControl
    {
        BOSList<ICProductTasksInfo> ProductTaskList { get; set; }
        public void InvalidateDataSource(BOSList<ICProductTasksInfo> dataSource)
        {
            ProductTaskList = new BOSList<ICProductTasksInfo>();
            ProductTaskList = dataSource;
            DataSource = ProductTaskList;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductTaskQty"] != null)
            {
                gridView.Columns["ICProductTaskQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskTotalEstimatedDays"] != null)
            {
                gridView.Columns["ICProductTaskTotalEstimatedDays"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskTotalEstimatedHours"] != null)
            {
                gridView.Columns["ICProductTaskTotalEstimatedHours"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductTaskEstimatedTotalCost"] != null)
            {
                gridView.Columns["ICProductTaskEstimatedTotalCost"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = sender as GridView;
            string productNo = gridView.FocusedValue.ToString();
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ProductTaskList.Remove(ProductTaskList.Where(o => o.ICProductTaskNo.Equals(productNo)).FirstOrDefault());
            }
            RefreshDataSource();
        }
    }
}
