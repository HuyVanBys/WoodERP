using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105PurchasePlanItemWoodsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Rộng (min)";
            column.FieldName = "MMPurchasePlanItemProductMinWidth";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng (max)";
            column.FieldName = "MMPurchasePlanItemProductMaxWidth";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (min)";
            column.FieldName = "MMPurchasePlanItemProductMinLength";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài (max)";
            column.FieldName = "MMPurchasePlanItemProductMaxLength";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày phách tươi (min)";
            column.FieldName = "MMPurchasePlanItemFreshLumberMinHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày phách tươi (max)";
            column.FieldName = "MMPurchasePlanItemFreshLumberMaxHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày phách khô (min)";
            column.FieldName = "MMPurchasePlanItemDryLumberMinHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày phách khô (max)";
            column.FieldName = "MMPurchasePlanItemDryLumberMaxHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMPurchasePlanItemPurchaseProposalQty")
                {
                    column.Caption = "Khối lượng đã đề nghị";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "MMPurchasePlanItemProductHeight")
                {
                    column.Group();
                    column.GroupIndex = 0;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
                if (column.FieldName == "MMPurchasePlanItemProductName")
                {
                    column.Group();
                    column.GroupIndex = 1;
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                }
                if (column.FieldName == "MMPurchasePlanItemQuantity")
                {
                    column.FieldName = "MMPurchasePlanItemQuantity";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "MMPurchasePlanItemBPProductionNormItemQty")
                {
                    column.Caption = "Khối lượng ĐM";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "MMPurchasePlanItemInventoryStock")
                {
                    column.Caption = "Khối lượng có thể sử dụng";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                if (column.FieldName == "MMPurchasePlanItemBPQuantity")
                {
                    column.Caption = "Khối lượng theo ĐVT định mức";
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
            }

            gridView.ExpandAllGroups();
            return gridView;
        }
    }
}
