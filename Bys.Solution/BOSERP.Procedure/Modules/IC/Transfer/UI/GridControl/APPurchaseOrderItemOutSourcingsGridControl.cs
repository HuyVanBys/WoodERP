using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public partial class APPurchaseOrderItemOutSourcingsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<APPurchaseOrderItemOutSourcingsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["APPurchaseOrderItemOutSourcingGroup"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += GridView_EndGrouping;
            return gridView;
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
        }
    }
}
