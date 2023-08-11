using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP034ICTransferItemsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ICTransferItemProductQty"] != null)
            {
                gridView.Columns["ICTransferItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICTransferItemProductQty"].DisplayFormat.FormatString = "{0:n2}";
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICTransferDate";
            column.Caption = ReportLocalizedResources.ICTransferDate;
            column.OptionsColumn.AllowEdit = false;
            column.ColumnEdit = new RepositoryItemDateEdit();
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICTransferNo";
            column.Caption = ReportLocalizedResources.ICTransferNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICTransferStatusDisplayText";
            column.Caption = ReportLocalizedResources.ICTransferStatusDisplayText;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
