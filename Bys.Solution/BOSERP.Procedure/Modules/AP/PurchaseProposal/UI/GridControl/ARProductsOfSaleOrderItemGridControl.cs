using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class ARProductsOfSaleOrderItemGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderItemsInfo> datasouce)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = datasouce;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.SaleOrderName;
            column.FieldName = "ARSaleOrderName";
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.Group();
            }

            return gridView;
        }
    }
}
