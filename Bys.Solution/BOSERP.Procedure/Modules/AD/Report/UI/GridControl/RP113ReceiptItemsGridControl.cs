using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP113ReceiptItemsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column2 in gridView.Columns)
            {
                column2.Visible = false;
            }
            GridColumn column = gridView.Columns["ICDocumentTypeVN"];
            if (column != null)
            {
                column.Group();
                column.Visible = true;
            }

            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
                column.Visible = true;
            }

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 1;
            }

            column = gridView.Columns["ICReceiptItemProductDesc"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 2;

            }

            column = gridView.Columns["ICReceiptItemWoodQty"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 3;
                column.Caption = "Khối lượng";
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }

            column = gridView.Columns["ICReceiptItemWoodQtyToDate"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 4;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            //      gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView != null)
            {
                gridView.BestFitColumns();

            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();



            column = new GridColumn();
            column.Caption = "Khối lượng cho đến ngày";
            column.FieldName = "ICReceiptItemWoodQtyToDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại";
            column.FieldName = "ICDocumentTypeVN";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
