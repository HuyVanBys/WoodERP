using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP128MMAllocationPlanItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Lệnh sản xuất";
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày xuất hàng";
            column.FieldName = "MMBatchProductToDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Trạng thái";
            column.FieldName = "Trangthai";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày thực tế hoạch định gỗ";
            column.FieldName = "MMAllocationPlanDateDryLumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày thực tế hoạch HW";
            column.FieldName = "MMAllocationPlanDateHardware";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày thực tế hoạch sơn";
            column.FieldName = "MMAllocationPlanDateIngredientPaint";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày thực tế hoạch PLDG";
            column.FieldName = "MMAllocationPlanDateIngredientPackaging";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "MMBatchProductToDate" || e.Column.FieldName == "MMAllocationPlanDateDryLumber"
                                        || e.Column.FieldName == "MMAllocationPlanDateHardware" || e.Column.FieldName == "MMAllocationPlanDateIngredientPaint"
                                        || e.Column.FieldName == "MMAllocationPlanDateIngredientPackaging"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            return gridView;
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    MMAllocationPlansInfo item = (MMAllocationPlansInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        (((RP128)Screen)).GetAllDataDetail(item);
                    }
                }
            }
        }
        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
        //    gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
        //    GridColumn column = gridView.Columns["LenhSanXuat"];
        //    if (column != null)
        //    {

        //        column.Group();
        //    }


        //    return gridView;
        //}

    }
}
