using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules
{
    public class APPurchaseOrderItemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<APPurchaseOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = (GridColumn)Columns["FK_APPurchaseOrderID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["APPurchaseOrderItemRemainedQty"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }    
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Đơn mua hàng";
            newColumn.FieldName = "APPurchaseOrderNo";
            newColumn.Group();
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "MMBatchProductSOName";
            newColumn.Visible = true;
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_ICModelDetailID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            //        e.DisplayText = objModelDetailsController.GetObjectNameByID(matchCodeID); ;
            //    }
            //    else
            //        e.DisplayText = "";
            //}
        }
    }
}
