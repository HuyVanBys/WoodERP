using System.Data;

namespace BOSERP.Modules.Report
{
    public partial class ARRP004InvoiceItemsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
            col.FieldName = "ARInvoiceItemSupplierName";
            col.Caption = "Supplier";
            gridView.Columns.Add(col);

            BRBranchsController objBranchsController = new BRBranchsController();
            DataSet ds = (DataSet)BOSApp.LookupTables["BRBranchs"];
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectFromDataRow(row);
                col = new DevExpress.XtraGrid.Columns.GridColumn();
                col.FieldName = objBranchsInfo.BRBranchID.ToString();
                col.Caption = objBranchsInfo.BRBranchName;
                col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                col.DisplayFormat.FormatString = "{0:n0}";
                col.SummaryItem.FieldName = col.FieldName;
                col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                col.SummaryItem.DisplayFormat = "{0:n0}";
                gridView.Columns.Add(col);
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                gridView.Columns[objBranchsInfo.BRBranchID.ToString()].VisibleIndex = i + 20;
                gridView.Columns[objBranchsInfo.BRBranchID.ToString()].BestFit();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.Editable = false;
            return gridView;
        }
    }
}
