using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBatchProductsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<MMBatchProductsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            List<string> colList = new List<string>() { "FK_ARCustomerID",
                                                        "ACObjectName"};
            for (int i = gridView.Columns.Count - 1; i >= 0; i--)
            {
                if (colList.Contains(gridView.Columns[i].FieldName))
                {
                    gridView.Columns.RemoveAt(i);
                }
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Tên khách hàng";
            column.FieldName = "ARCustomerName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã khách hàng";
            column.FieldName = "ARCustomerNo";
            gridView.Columns.Add(column);
        }
    }
}
