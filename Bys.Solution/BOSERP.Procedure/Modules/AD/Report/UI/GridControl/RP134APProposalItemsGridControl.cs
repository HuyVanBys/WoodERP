using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public class RP134APProposalItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ICReceiptQty";
            column.Caption = ReportLocalizedResources.ICReceiptItemProductQty;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SLthieu";
            column.Caption = ReportLocalizedResources.MisssingInventoryStockQuantity;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderNo";
            column.Caption = ReportLocalizedResources.PurchaseOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemProductName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APPurchaseOrderdate";
            column.Caption = ReportLocalizedResources.DocumentDate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APProposalNo";
            column.Caption = ReportLocalizedResources.ProposalNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalNo";
            column.Caption = "Mã LCP";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APProposalItemProductQty";
            column.Caption = ReportLocalizedResources.APProposalProductQty;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "APProposalItemPurchaseOrderQty";
            column.Caption = ReportLocalizedResources.APPurchaseOrderItemProductQty1;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            GridColumn column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["FK_MMAllocationProposalID"];
            if (column != null)
            {
                column.Visible = true;
                column.VisibleIndex = 4;
            }
            return gridView;
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    APProposalItemsInfo item = (APProposalItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        (((RP134)Screen)).GetAllData(item);
                    }
                }
            }
        }

    }
}
