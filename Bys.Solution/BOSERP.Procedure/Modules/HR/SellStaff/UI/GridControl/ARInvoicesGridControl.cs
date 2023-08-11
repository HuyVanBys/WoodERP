using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace BOSERP.Modules.SellStaff
{
    public partial class ARInvoicesGridControl : BOSComponent.BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["ARInvoiceDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }

        public void RefreshDataSource(DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0)
                this.DataSource = ds.Tables[0];
            else
                this.DataSource = null;
            this.RefreshDataSource();
        }
    }
}
