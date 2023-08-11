using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace BOSERP.Modules.Customer
{
    public partial class ARSaleOrdersGridControl : BOSComponent.BOSGridControl
    {
        public ARSaleOrdersGridControl()
        {
            InitializeComponent();
        }

        public ARSaleOrdersGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["ARSaleOrderDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }
    }
}
