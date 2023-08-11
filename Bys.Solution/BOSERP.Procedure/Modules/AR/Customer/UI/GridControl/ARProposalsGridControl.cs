using System.ComponentModel;
using System.Data;

namespace BOSERP.Modules.Customer
{
    public partial class ARProposalsGridControl : BOSComponent.BOSGridControl
    {
        public ARProposalsGridControl()
        {
            InitializeComponent();
        }

        public ARProposalsGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridView.Columns["ARProposalDate"], DevExpress.Data.ColumnSortOrder.Descending));
            return gridView;
        }

        public void RefreshDataSource(DataSet ds)
        {
            if (ds.Tables.Count > 0)
                this.DataSource = ds.Tables[0];
            else
                this.DataSource = null;
            this.RefreshDataSource();
        }
    }
}
