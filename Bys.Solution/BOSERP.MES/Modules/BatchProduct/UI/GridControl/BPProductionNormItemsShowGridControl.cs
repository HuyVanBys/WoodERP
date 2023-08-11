using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class BPProductionNormItemsShowGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMBatchProductProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }


    }
}
