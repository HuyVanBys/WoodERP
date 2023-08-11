using BOSCommon.Constants;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class ARRP025SaleOrdersGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            RepositoryItemDateEdit repositoryItemTimeEdit = new RepositoryItemDateEdit();
            // repositoryItemDateEdit
            repositoryItemTimeEdit.AutoHeight = false;
            repositoryItemTimeEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemTimeEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemTimeEdit.EditFormat.FormatString = "HH:mm:ss";
            repositoryItemTimeEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemTimeEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemTimeEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemTimeEdit.Name = "repositoryItemTimeEdit1";
            GridColumn columnDateTime = gridView.Columns["ARSaleOrderDeliveryTime"];
            if (columnDateTime != null)
            {
                columnDateTime.ColumnEdit = repositoryItemTimeEdit;
            }
            InitColumnSummary("ARSaleOrderTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARSaleOrderDepositBalance", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ARSaleOrderBalanceDue", DevExpress.Data.SummaryItemType.Sum);
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
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)gridView.GetRow(gridView.FocusedRowHandle);
                BOSERP.Modules.SaleOrder.SaleOrderModule saleOrderModule = (BOSERP.Modules.SaleOrder.SaleOrderModule)BOSApp.ShowModule(ModuleName.SaleOrder);
                saleOrderModule.ActionInvalidate(objSaleOrdersInfo.ARSaleOrderID);
            }
        }
    }
}
