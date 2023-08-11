using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductShipment
{
    public partial class ICReceiptItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ICReceiptItemsInfo> dataSource)
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
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["FK_ICReceiptID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "FK_MMOperationIDInReceipt";
            column.Caption = "CĐ nhận tiếp theo";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeName";
            column.Caption = "Nhân viên";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptDate";
            column.Caption = "Ngày nhập kho BTP/TP";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.FieldName = "ICReceiptSOName";
            //column.Caption = "Mã đơn hàng nội bộ";
            //column.Visible = true;
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
            else if (e.Column.FieldName == "FK_MMOperationIDInReceipt")
            {
                if (e.Value != null)
                {
                    int id = 0;
                    if (int.TryParse(e.Value.ToString(), out id))
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", id, "MMOperationName");
                }
            }
        }
    }
}
