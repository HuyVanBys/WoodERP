using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public class RP193ARSaleOrderItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            //base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ARSaleOrderItemRowNumber";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemRowNumber;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderDate";
            column.Caption = ReportLocalizedResources.ARSaleOrderDate1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderNo";
            column.Caption = ReportLocalizedResources.ARSaleOrderNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderSaleAgreement";
            column.Caption = ReportLocalizedResources.ARSaleOrderSaleAgreement;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACObjectName";
            column.Caption = ReportLocalizedResources.ACObjectName1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACObjectContactAddressLine3";
            column.Caption = ReportLocalizedResources.ACObjectContactAddressLine3;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = ReportLocalizedResources.ICProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemProductName";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemProductName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemPrice";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemPrice;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSellerName";
            column.Caption = ReportLocalizedResources.ARSellerName1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderDeliveryDate";
            column.Caption = ReportLocalizedResources.ARSaleOrderDeliveryDate1;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderDeliveryActualDate";
            column.Caption = ReportLocalizedResources.ARSaleOrderDeliveryActualDate;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemRemark";
            column.Caption = ReportLocalizedResources.ARSaleOrderItemRemark;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderItemTotalAmount";
            column.Caption = "Giá trị sau CK";
            column.OptionsColumn.AllowEdit = false;
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

            GridColumn column = gridView.Columns["ARSaleOrderItemPrice"];
            column.SummaryItem.FieldName = "ARSaleOrderItemPrice";
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n3}";

            GridColumn colSaleOrderItemTotalAmoun = gridView.Columns["ARSaleOrderItemTotalAmount"];
            colSaleOrderItemTotalAmoun.SummaryItem.FieldName = "ARSaleOrderItemTotalAmount";
            colSaleOrderItemTotalAmoun.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            colSaleOrderItemTotalAmoun.SummaryItem.DisplayFormat = "{0:n3}";

            return gridView;
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
            //if (e.CellValue != null && (e.Column.FieldName == "ReportContractFromDate" || e.Column.FieldName == "ReportContractToDate" ||
            //                               e.Column.FieldName == "NgayDatCoc"))
            //{
            //    if (DateTime.TryParse(e.CellValue.ToString(), out value))
            //    {
            //        if (value == DateTime.MinValue)
            //        {
            //            e.DisplayText = "";
            //        }
            //        if (value == DateTime.MaxValue)
            //        {
            //            e.DisplayText = "";
            //        }
            //    }
            //}

        }


    }
}
