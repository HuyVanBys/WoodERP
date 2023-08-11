using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.RetailVAT
{
    public class POSItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARInvoiceItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ARInvoiceNo"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["FK_ARInvoiceID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            gridView.ExpandAllGroups();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ARInvoiceNo";
            column.Caption = "Mã chứng từ bán lẻ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceItemProductNo";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARInvoiceDate";
            column.Caption = "Ngày chứng từ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACObjectName";
            column.Caption = "Đối tượng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSellerName";
            column.Caption = "Người bán";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_ARSellerID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        //ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            //        //e.DisplayText = objModelDetailsController.GetObjectNameByID(matchCodeID);
            //    }
            //    else
            //    {
            //        e.DisplayText = string.Empty;
            //    }
            //} 
        }
    }
}
