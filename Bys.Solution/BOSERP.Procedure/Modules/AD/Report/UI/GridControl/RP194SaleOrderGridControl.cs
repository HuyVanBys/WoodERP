using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP194SaleOrderGridControl : ReportGridControl
    {
        string[] RP194Columns = new string[]
        {
            "FirstWeekAmount"
            , "SecondWeekAmount"
            , "ThirdWeekAmount"
            , "TheFourthWeekAmount"
            , "SaleAmount"
            , "SaleAmountLastYear"
            , "GrowthPercent"
        };

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            RP194Columns.All(o =>
            {
                GridColumn column = gridView.Columns[o];
                if (column != null)
                {
                    column.SummaryItem.FieldName = o;
                    column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    column.SummaryItem.DisplayFormat = "{0:n3}";
                }
                return true;
            });
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            //base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Nhân viên bán hàng";
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tuần 1";
            column.FieldName = "FirstWeekAmount";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tuần 2";
            column.FieldName = "SecondWeekAmount";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tuần 3";
            column.FieldName = "ThirdWeekAmount";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tuần 4";
            column.FieldName = "TheFourthWeekAmount";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lũy kế";
            column.FieldName = "SaleAmount";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Doanh số năm trước";
            column.FieldName = "SaleAmountLastYear";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỷ lệ tăng trường";
            column.FieldName = "GrowthPercent";
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ghi chú";
            column.FieldName = "Descriptions";
            gridView.Columns.Add(column);
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = allowEdit;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + formatType + "}"; ;
        }

        #region LuuNH Delete
        //public GridView GridViewMain { get; set; }

        ///// <summary>
        ///// Gets or sets product group list
        ///// </summary>
        //public List<HREmployeesInfo> EmployeeList { get; set; }

        //public override void InitializeControl()
        //{
        //    base.InitializeControl();
        //}

        ///// <summary>
        ///// Add dynamic columnn to gridview
        ///// </summary>
        ///// <param name="table">The data table</param>
        ///// <param name="dateFrom">The invoice date from</param>
        ///// <param name="dateTo">The invoice date to</param>
        ///// <param name="dateType">Type of date</param>
        //public void AddDataSource(DataTable table, DateTime dateFrom, DateTime dateTo)
        //{
        //    this.DataSource = table;
        //    BandedGridView bandedView = InitializeBandedGridView(GridViewMain, dateFrom, dateTo);
        //    MainView = bandedView;
        //    ViewCollection.AddRange(new BaseView[] { bandedView });
        //}

        ///// <summary>
        ///// Initialize BandedGridView
        ///// </summary>
        ///// <param name="gridView">The gridview</param>
        ///// <returns>Banded gridview</returns>
        //private BandedGridView InitializeBandedGridView(GridView gridView, DateTime dateFrom, DateTime dateTo)
        //{
        //    gridView.Columns.Clear();

        //    BandedGridView bandedView = new BandedGridView();
        //    bandedView.GridControl = this;
        //    bandedView.Name = "bandedGridView1";
        //    bandedView.OptionsCustomization.AllowFilter = false;
        //    bandedView.OptionsView.ColumnAutoWidth = false;
        //    bandedView.OptionsView.ShowGroupPanel = false;
        //    //bandedView.OptionsView.ShowFooter = false;
        //    bandedView.OptionsView.ShowFooter = true;
        //    bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

        //    GridBand gridBand = CreateNewGridBand("", ReportLocalizedResources.Information);
        //    bandedView.Bands.Add(gridBand);
        //    BandedGridColumn EmployeeName = CreateNewColumn("HREmployeeName", ReportLocalizedResources.HREmployeeName, gridBand);
        //    EmployeeName.Width = 150;

        //    //GridBand1
        //    gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        //    gridBand.MinWidth = 300;

        //    List<BandedGridColumn> columns = new List<BandedGridColumn>();
        //    List<GridBand> bands = new List<GridBand>();
        //    DateTime index = dateFrom;
        //    if (index <= dateTo)
        //    {
        //        string bandName = index.ToString("MM/yyyy");
        //        GridBand band = CreateNewGridBand(bandName, bandName);
        //        bands.Add(band);
        //        bandedView.Bands.Add(band);

        //        int dem = 0;
        //        while (dem <= 3)
        //        {
        //            string quantityColumnName = "InvoiceAmount_" + dem.ToString();
        //            BandedGridColumn column = CreateNumericColumn(quantityColumnName, string.Format(ReportLocalizedResources.Week, (dem+1).ToString()), band);
        //            bandedView.Columns[quantityColumnName].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //            bandedView.Columns[quantityColumnName].SummaryItem.FieldName = quantityColumnName;
        //            bandedView.Columns[quantityColumnName].SummaryItem.DisplayFormat = column.DisplayFormat.FormatString;
        //            //column.BestFit();
        //            column.Width = 100;

        //            GridGroupSummaryItem item1 = new GridGroupSummaryItem();
        //            item1.FieldName = quantityColumnName;
        //            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //            item1.DisplayFormat = column.DisplayFormat.FormatString;
        //            item1.ShowInGroupColumnFooter = bandedView.Columns[quantityColumnName];
        //            bandedView.GroupSummary.Add(item1);

        //            dem++;
        //        }
        //    }
        //    //bandedView.Columns["ICDepartmentName"].GroupIndex = 0;
        //    //bandedView.Columns["ICProductGroupParentName"].GroupIndex = 1;

        //    BandedGridColumn accumulation = CreateNumericColumn("Accumulation", ReportLocalizedResources.Accumulation, gridBand);
        //    bandedView.Columns["Accumulation"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //    bandedView.Columns["Accumulation"].SummaryItem.FieldName = "Accumulation";
        //    bandedView.Columns["Accumulation"].SummaryItem.DisplayFormat = accumulation.DisplayFormat.FormatString;
        //    //accumulation.BestFit();
        //    accumulation.Width = 80;

        //    GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
        //    summaryItem.FieldName = "Accumulation";
        //    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //    summaryItem.DisplayFormat = accumulation.DisplayFormat.FormatString;
        //    summaryItem.ShowInGroupColumnFooter = bandedView.Columns["Accumulation"];
        //    bandedView.GroupSummary.Add(summaryItem);

        //    BandedGridColumn salesYearBefore = CreateNumericColumn("SalesYearBefore", string.Format(ReportLocalizedResources.SalesYearBefore, index.AddYears(-1).ToString("MM/yyyy")), gridBand);
        //    bandedView.Columns["SalesYearBefore"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //    bandedView.Columns["SalesYearBefore"].SummaryItem.FieldName = "SalesYearBefore";
        //    bandedView.Columns["SalesYearBefore"].SummaryItem.DisplayFormat = salesYearBefore.DisplayFormat.FormatString;
        //    //salesYearBefore.BestFit();
        //    salesYearBefore.Width = 100;

        //    summaryItem = new GridGroupSummaryItem();
        //    summaryItem.FieldName = "SalesYearBefore";
        //    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        //    summaryItem.DisplayFormat = salesYearBefore.DisplayFormat.FormatString;
        //    summaryItem.ShowInGroupColumnFooter = bandedView.Columns["SalesYearBefore"];
        //    bandedView.GroupSummary.Add(summaryItem);

        //    CreateNumericColumn("RatioGrowth", ReportLocalizedResources.RatioGrowth, gridBand);

        //    CreateNewColumn("Note", ReportLocalizedResources.Note, gridBand);


        //    gridView.BestFitColumns();

        //    return bandedView;
        //}

        ///// <summary>
        ///// Create new grid band
        ///// </summary>
        ///// <param name="name">The name of column</param>
        ///// <param name="header">The header caption of grid band</param>
        ///// <returns>The grid band</returns>
        //private GridBand CreateNewGridBand(string name, string header)
        //{
        //    GridBand gridBand1 = new GridBand();
        //    gridBand1.Caption = header;
        //    gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
        //    gridBand1.Name = name;
        //    return gridBand1;
        //}

        ///// <summary>
        ///// Create new column for grid band
        ///// </summary>
        ///// <param name="name">The name of column</param>
        ///// <param name="header">The header cation of grid band</param>
        ///// <param name="owner">The grid band</param>
        ///// <returns>The banded grid column</returns>
        //private BandedGridColumn CreateNewColumn(string name, string header, GridBand owner)
        //{
        //    BandedGridColumn bandedColumn = new BandedGridColumn();
        //    bandedColumn.Name = name;
        //    bandedColumn.Caption = header;
        //    bandedColumn.FieldName = name;
        //    bandedColumn.Visible = true;
        //    bandedColumn.OptionsColumn.AllowEdit = false;
        //    bandedColumn.OwnerBand = owner;
        //    bandedColumn.Width = 80;
        //    return bandedColumn;
        //}

        ///// <summary>
        ///// Create new column for grid band in numeric format
        ///// </summary>
        ///// <param name="name">The name of column</param>
        ///// <param name="header">The header cation of grid band</param>
        ///// <param name="owner">The grid band</param>        
        ///// <returns>The banded grid column</returns>
        //private BandedGridColumn CreateNumericColumn(string name, string header, GridBand owner)
        //{
        //    BandedGridColumn bandedColumn = new BandedGridColumn();
        //    bandedColumn.Name = name;
        //    bandedColumn.Caption = header;
        //    bandedColumn.FieldName = name;
        //    bandedColumn.Visible = true;
        //    bandedColumn.OptionsColumn.AllowEdit = false;
        //    bandedColumn.DisplayFormat.FormatType = FormatType.Numeric;
        //    bandedColumn.DisplayFormat.FormatString = "{0:n0}";
        //    bandedColumn.OwnerBand = owner;
        //    bandedColumn.Width = 80;
        //    return bandedColumn;
        //}

        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
        //    GridViewMain = gridView;
        //    return gridView;
        //}
        #endregion
    }
}
