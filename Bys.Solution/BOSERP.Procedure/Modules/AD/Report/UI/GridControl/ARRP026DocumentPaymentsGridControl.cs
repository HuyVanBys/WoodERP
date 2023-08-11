using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class ARRP026DocumentPaymentsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ARDocumentPaymentAmount", DevExpress.Data.SummaryItemType.Sum);

            GridColumn column = gridView.Columns["BRBranchName"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARCustomerName;
            col.FieldName = "ARCustomerName";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.BRBranchName;
            col.FieldName = "BRBranchName";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARSaleOrderNo;
            col.FieldName = "AROpenDocumentNo";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARSaleOrderDate;
            col.FieldName = "AROpenDocumentDate";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARCustomerPaymentNo;
            col.FieldName = "ARCustomerPaymentNo";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARCustomerPaymentDate;
            col.FieldName = "ARCustomerPaymentDate";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARCustomerContactAddressLine3;
            col.FieldName = "ARCustomerContactAddressLine3";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ARCustomerPaymentDetailDesc;
            col.FieldName = "ARCustomerPaymentDetailDesc";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);

            col = new GridColumn();
            col.Caption = ReportLocalizedResources.ACObjectName;
            col.FieldName = "ACObjectName";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);
        }
    }
}
