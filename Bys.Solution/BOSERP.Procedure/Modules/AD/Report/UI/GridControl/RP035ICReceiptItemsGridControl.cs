using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP035ICReceiptItemsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n2}";
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICReceiptDate";
            column.Caption = ReportLocalizedResources.ICReceiptDate;
            column.OptionsColumn.AllowEdit = false;
            column.ColumnEdit = new RepositoryItemDateEdit();
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptNo";
            column.Caption = ReportLocalizedResources.ICReceiptNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptPackNo";
            column.Caption = ReportLocalizedResources.ICReceiptPackNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptTotalCost";
            column.Caption = ReportLocalizedResources.ICReceiptTotalCost;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptStatusDisplayText";
            column.Caption = ReportLocalizedResources.ICReceiptStatus;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APSupplierName";
            column.Caption = "Tên đối tượng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "GECurrencyName";
            column.Caption = ReportLocalizedResources.GECurrencyName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
