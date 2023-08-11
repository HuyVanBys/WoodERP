using BOSComponent;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public class RP121ARSaleOrdersGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "GECurrencyNo";
            column.Caption = ReportLocalizedResources.GECurrencyNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerNo";
            column.Caption = ReportLocalizedResources.ARCustomerNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeName";
            column.Caption = ReportLocalizedResources.HREmployeeName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportSaleOrderNo";
            column.Caption = ReportLocalizedResources.ReportSaleOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderTotalAmount";
            column.Caption = "Số tiền trên PI";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ReportPaymentTerm";
            column.Caption = "Điều khoản thanh toán";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TienCoc";
            column.Caption = ReportLocalizedResources.SoTienDatCoc;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "NgayDatCoc";
            column.Caption = ReportLocalizedResources.NgayDatCoc;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "InvoiceNo";
            column.Caption = ReportLocalizedResources.InvoiceNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "SoTienHoaDon";
            column.Caption = ReportLocalizedResources.SoTienHoaDon;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "NgayXNNo";
            column.Caption = ReportLocalizedResources.NgayXNNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "NgayToiHan";
            column.Caption = "Ngày tới hạn";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "NoTrongHan";
            column.Caption = ReportLocalizedResources.NoTrongHan;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Khoang1";
            column.Caption = ReportLocalizedResources.Khoang1;
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Khoang2";
            column.Caption = ReportLocalizedResources.Khoang2;
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Khoang3";
            column.Caption = ReportLocalizedResources.Khoang3;
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

        }
        protected override void InitGridViewColumns(GridView gridView)
        {
            base.InitGridViewColumns(gridView);

        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "ARSaleOrderTotalAmount";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["ARSaleOrderTotalAmount"];
            InitColumnSummary("ARSaleOrderTotalAmount", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "SoTienHoaDon";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["SoTienHoaDon"];
            InitColumnSummary("SoTienHoaDon", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "NoTrongHan";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["NoTrongHan"];
            InitColumnSummary("NoTrongHan", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Khoang1";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Khoang1"];
            InitColumnSummary("Khoang1", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Khoang2";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Khoang2"];
            InitColumnSummary("Khoang2", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "Khoang3";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["Khoang3"];
            InitColumnSummary("Khoang3", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "SoTienDatCoc";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["SoTienDatCoc"];
            InitColumnSummary("SoTienDatCoc", DevExpress.Data.SummaryItemType.Sum);

            item = new GridGroupSummaryItem();
            item.FieldName = "TienCoc";
            item.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            item.DisplayFormat = "{0:N0}";
            gridView.GroupSummary.Add(item);
            item.ShowInGroupColumnFooter = gridView.Columns["TienCoc"];
            InitColumnSummary("TienCoc", DevExpress.Data.SummaryItemType.Custom);


            GridColumn column = gridView.Columns["GECurrencyNo"];
            if (column != null)
            {
                column.Group();
            }

            gridView.CustomSummaryCalculate += new CustomSummaryEventHandler(gridView_CustomSummaryCalculate);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }


        void gridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {

            if (e.IsGroupSummary)
            {
                GridView gridView = sender as GridView;
                List<ARSaleOrdersInfo> childRows = new List<ARSaleOrdersInfo>();
                GetChildRows(gridView, e.GroupRowHandle, childRows);
                RP121 screen = Screen as RP121;

                e.TotalValue = screen.SumList(childRows);

            }

            if (e.IsTotalSummary)
            {
                RP121 screen = Screen as RP121;
                e.TotalValue = screen.SumList(screen.SaleOrderList);

            }
        }

        //Returns the child data rows for the given group row 
        public void GetChildRows(GridView view, int groupRowHandle, List<ARSaleOrdersInfo> childRows)
        {
            if (!view.IsGroupRow(groupRowHandle)) return;
            //Get the number of immediate children 
            int childCount = view.GetChildRowCount(groupRowHandle);
            for (int i = 0; i < childCount; i++)
            {
                //Get the handle of a child row with the required index 
                int childHandle = view.GetChildRowHandle(groupRowHandle, i);
                //If the child is a group row, then add its children to the list 
                if (view.IsGroupRow(childHandle))
                    GetChildRows(view, childHandle, childRows);
                else
                {
                    // The child is a data row.  
                    // Add it to the childRows as long as the row wasn't added before 
                    ARSaleOrdersInfo row = view.GetRow(childHandle) as ARSaleOrdersInfo;
                    if (!childRows.Contains(row))
                        childRows.Add(row);
                }
            }
        }


        //void gridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        //{
        //    if (e.IsTotalSummary)
        //    {
        //        RP121 screen = Screen as RP121;

        //        e.TotalValue = screen.SumList(screen.SaleOrderList);

        //    }
        //}

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ReportContractFromDate" || e.Column.FieldName == "ReportContractToDate" ||
                                           e.Column.FieldName == "NgayDatCoc"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
