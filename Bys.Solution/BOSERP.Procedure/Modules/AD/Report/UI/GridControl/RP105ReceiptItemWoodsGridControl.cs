using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105ReceiptItemWoodsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Hoành (min)";
            column.FieldName = "ICReceiptItemProductPerimeterMin";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hoành (max)";
            column.FieldName = "ICReceiptItemProductPerimeterMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "ICReceiptItemWoodQty")
                {
                    column.Visible = true;
                    column.Caption = "Số lượng";
                }
                if (column.FieldName == "ICReceiptItemProductQty")
                {
                    column.Visible = true;
                    column.DisplayFormat.FormatString = "{0:n4}";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.Caption = "KL thực tế (m3)";
                }
                if (column.FieldName == "ICReceiptItemProductHeight")
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
