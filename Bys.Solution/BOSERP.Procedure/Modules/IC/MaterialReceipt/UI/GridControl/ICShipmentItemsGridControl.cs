using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialReceipt
{
    public class ICShipmentItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICShipmentItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            //if (gridView.Columns["ICShipmentNo"] != null)
            //{
            //    gridView.Columns["ICShipmentNo"].Group();
            //}

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(p => p.ICProductID == matchCodeID);
                    e.DisplayText = objProductsInfo != null ? objProductsInfo.ICProductNo : string.Empty;
                }
                else
                    e.DisplayText = string.Empty;
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã phiếu xuất";
            column.FieldName = "ICShipmentNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng nội địa";
            column.FieldName = "ICShipmentItemSOName";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
