using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105InvoiceInItemWoodsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Dày(mm)";
            column.FieldName = "APInvoiceInItemProductHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (min)";
            column.FieldName = "APInvoiceInItemProductLengthMin";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (max)";
            column.FieldName = "APInvoiceInItemProductLengthMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hoành (min)";
            column.FieldName = "APInvoiceInItemProductPerimeterMin";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hoành (max)";
            column.FieldName = "APInvoiceInItemProductPerimeterMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng (min)";
            column.FieldName = "APInvoiceInItemProductWidthMin";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng (max)";
            column.FieldName = "APInvoiceInItemProductWidthMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "APInvoiceInItemProductQty")
                {
                    column.Caption = "Khối lượng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.Visible = true;
                }
                if (column.FieldName == "APInvoiceInItemReceiptedQty")
                {
                    column.Caption = "Khối lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.Visible = true;
                }
                if (column.FieldName == "APInvoiceInItemProductHeight")
                {
                    column.Group();
                    //column.GroupIndex = 0;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
            }

            gridView.ExpandAllGroups();
            return gridView;
        }
    }
}
