using BOSCommon.Constants;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class RP001SaleReceiptsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            InitColumnSummary("ARInvoiceTotalAmount", DevExpress.Data.SummaryItemType.Sum);

            GridColumn column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                column.Group();
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerContactAddressLine3;
            column.FieldName = "ARCustomerContactAddressLine3";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ARCustomerPaymentDetailDesc;
            column.FieldName = "ARCustomerPaymentDetailDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }


        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objInvoicesInfo != null)
                {
                    BOSERP.Modules.POS.POSModule posModule = (BOSERP.Modules.POS.POSModule)BOSApp.ShowModule(ModuleName.POS);
                    if (posModule != null)
                    {
                        posModule.ActionInvalidate(objInvoicesInfo.ARInvoiceID);
                    }
                }
            }
        }
    }
}
