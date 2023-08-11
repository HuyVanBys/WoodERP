using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class BPProductionNormItemProcesssGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMBatchProductProductionNormItemProcesssInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }


    }
}
