using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Drawing;

namespace BOSERP.Modules.Report
{
    public partial class RP143ACDocumentsGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;



            GridColumn column = gridView.Columns["ACDocumentDesc"];
            if (column != null)
            {
                column.Group();
            }

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "ACDocumentTotalAmount";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:n}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["ACDocumentTotalAmount"];

            item = new GridGroupSummaryItem();
            item.FieldName = "ACDocumentDesc";
            item.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            item.DisplayFormat = "{0:n}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["ACDocumentNo"];



            InitColumnSummary("ACDocumentTotalAmount", DevExpress.Data.SummaryItemType.Custom);
            InitColumnSummary("ACDocumentNo", DevExpress.Data.SummaryItemType.Custom);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(gridView_CustomSummaryCalculate);
            gridView.CustomDrawFooterCell += new FooterCellCustomDrawEventHandler(gridView_CustomDrawFooterCell);
            gridView.CustomDrawRowFooterCell += new FooterCellCustomDrawEventHandler(gridView_CustomDrawRowFooterCell);
            return gridView;
        }

        void gridView_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ACDocumentTotalAmount")
            {
                e.Appearance.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                //   e.Handled = true;
            }
        }


        void gridView_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ACDocumentTotalAmount")
            {
                e.Appearance.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                //  e.Handled = true;
            }
        }

        void gridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.IsTotalSummary && e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                if (((DevExpress.XtraGrid.GridSummaryItem)e.Item).FieldName == "ACDocumentNo")
                {
                    e.TotalValue = "Tổng cộng";
                }
                else
                {
                    e.TotalValue = ((RP102)this.Screen).GetFinalTotalAmount();

                    //gridView.Columns[((DevExpress.XtraGrid.GridSummaryItem)e.Item).FieldName].AppearanceCell.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                    //((DevExpress.XtraGrid.GridSummaryItem)e.Item) = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                }
            }

            if (e.IsGroupSummary && e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                e.TotalValue = "Tổng cộng";
            }
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.ACDocumentNo;
            column.FieldName = "ACDocumentNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.ACDocumentDesc;
            column.FieldName = "ACDocumentDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.Details;
            column.FieldName = "Details";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rp = new RepositoryItemHyperLinkEdit();
            rp.Click += new EventHandler(rp_Click);
            rp.NullText = ReportLocalizedResources.Details;
            column.ColumnEdit = rp;
            gridView.Columns.Add(column);

        }
        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        void rp_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ((RP102)this.Screen).ShowDetails(gridView.FocusedRowHandle);
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //GridView gridView = (GridView)sender;
            //if (gridView.FocusedRowHandle >= 0)
            //{
            //    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)gridView.GetRow(gridView.FocusedRowHandle);                
            //    BOSERP.Modules.SaleOrder.SaleOrderModule saleOrderModule = (BOSERP.Modules.SaleOrder.SaleOrderModule)BOSApp.ShowModule(ModuleName.SaleOrder);
            //    saleOrderModule.ActionInvalidate(objSaleOrdersInfo.ARSaleOrderID);
            //}
        }
    }
}
