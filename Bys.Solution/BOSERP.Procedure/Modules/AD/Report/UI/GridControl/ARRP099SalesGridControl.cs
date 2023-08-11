using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSERP.Modules.Report
{
    public partial class ARRP099SalesGridControl : ReportGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }

        /// <summary>
        /// Gets or sets product group list
        /// </summary>
        public List<ARCustomersInfo> CustomerList { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
        }

        /// <summary>
        /// Add dynamic columnn to gridview
        /// </summary>
        /// <param name="table">The data table</param>
        /// <param name="dateFrom">The invoice date from</param>
        /// <param name="dateTo">The invoice date to</param>
        /// <param name="dateType">Type of date</param>
        public void AddDataSource(DataTable table, DateTime dateFrom, DateTime dateTo)
        {
            this.DataSource = table;
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain, dateFrom, dateTo);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
        }

        /// <summary>
        /// Initialize BandedGridView
        /// </summary>
        /// <param name="gridView">The gridview</param>
        /// <returns>Banded gridview</returns>
        private BandedGridView InitializeBandedGridView(GridView gridView, DateTime dateFrom, DateTime dateTo)
        {
            gridView.Columns.Clear();
            BandedGridView bandedView = new BandedGridView();
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            //bandedView.OptionsView.ShowFooter = false;
            bandedView.OptionsView.ShowFooter = true;
            bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

            GridBand gridBand = CreateNewGridBand("", ReportLocalizedResources.Information);
            bandedView.Bands.Add(gridBand);
            CreateNewColumn("ARCustomerName", ReportLocalizedResources.CustomerName, gridBand);
            CreateNewColumn("Form", ReportLocalizedResources.Form, gridBand);
            CreateNumericColumn("TotalInvoiceAmount", ReportLocalizedResources.TotalSales, gridBand);
            CreateNumericColumn("TotalPaymentAmount", ReportLocalizedResources.TotalRevenue, gridBand);

            //GridBand1
            gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 200;

            List<BandedGridColumn> columns = new List<BandedGridColumn>();
            List<GridBand> bands = new List<GridBand>();
            DateTime index = dateFrom;
            while (index <= dateTo)
            {
                string bandName = index.ToString("MM/yyyy");
                GridBand band = CreateNewGridBand(bandName, bandName);
                bands.Add(band);
                bandedView.Bands.Add(band);

                string quantityColumnName = "InvoiceAmount_" + index.ToString("MM/yyyy");
                BandedGridColumn column = CreateNumericColumn(quantityColumnName, ReportLocalizedResources.Sales, band);
                bandedView.Columns[quantityColumnName].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                bandedView.Columns[quantityColumnName].SummaryItem.FieldName = quantityColumnName;
                bandedView.Columns[quantityColumnName].SummaryItem.DisplayFormat = column.DisplayFormat.FormatString;
                column.BestFit();

                string totalColumnName = "PaymentAmount_" + index.ToString("MM/yyyy");
                BandedGridColumn totalColumn = CreateNumericColumn(totalColumnName, ReportLocalizedResources.Revenue, band);
                totalColumn.Width = 100;
                bandedView.Columns[totalColumnName].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                bandedView.Columns[totalColumnName].SummaryItem.FieldName = totalColumnName;
                bandedView.Columns[totalColumnName].SummaryItem.DisplayFormat = totalColumn.DisplayFormat.FormatString;

                GridGroupSummaryItem item1 = new GridGroupSummaryItem();
                item1.FieldName = quantityColumnName;
                item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                item1.DisplayFormat = column.DisplayFormat.FormatString;
                item1.ShowInGroupColumnFooter = bandedView.Columns[quantityColumnName];
                bandedView.GroupSummary.Add(item1);

                item1 = new GridGroupSummaryItem();
                item1.FieldName = totalColumnName;
                item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                item1.DisplayFormat = totalColumn.DisplayFormat.FormatString;
                item1.ShowInGroupColumnFooter = bandedView.Columns[totalColumnName];
                bandedView.GroupSummary.Add(item1);
                index = index.AddMonths(1);
            }
            //bandedView.Columns["ICDepartmentName"].GroupIndex = 0;
            //bandedView.Columns["ICProductGroupParentName"].GroupIndex = 1;
            return bandedView;
        }

        /// <summary>
        /// Create new grid band
        /// </summary>
        /// <param name="name">The name of column</param>
        /// <param name="header">The header caption of grid band</param>
        /// <returns>The grid band</returns>
        private GridBand CreateNewGridBand(string name, string header)
        {
            GridBand gridBand1 = new GridBand();
            gridBand1.Caption = header;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand1.Name = name;
            return gridBand1;
        }

        /// <summary>
        /// Create new column for grid band
        /// </summary>
        /// <param name="name">The name of column</param>
        /// <param name="header">The header cation of grid band</param>
        /// <param name="owner">The grid band</param>
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNewColumn(string name, string header, GridBand owner)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = false;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        /// <summary>
        /// Create new column for grid band in numeric format
        /// </summary>
        /// <param name="name">The name of column</param>
        /// <param name="header">The header cation of grid band</param>
        /// <param name="owner">The grid band</param>        
        /// <returns>The banded grid column</returns>
        private BandedGridColumn CreateNumericColumn(string name, string header, GridBand owner)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = false;
            bandedColumn.DisplayFormat.FormatType = FormatType.Numeric;
            bandedColumn.DisplayFormat.FormatString = "{0:n0}";
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //GridColumn column = gridView.Columns["ICProductGroupParentName"];
            //gridView.OptionsView.ShowFooter = true;
            //gridView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            //InitColumnSummary("ARInvoiceItemProductQty", DevExpress.Data.SummaryItemType.Sum);
            //InitColumnSummary("ARInvoiceItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            //if (column != null)
            //{
            //    column.Group();
            //}
            //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            //item1.FieldName = "ARInvoiceItemTotalAmount";
            //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item1.DisplayFormat = "{0:n2}";
            //item1.ShowInGroupColumnFooter = gridView.Columns["ARInvoiceItemTotalAmount"];
            //gridView.GroupSummary.Add(item1);
            GridViewMain = gridView;
            return gridView;
        }
    }
}
