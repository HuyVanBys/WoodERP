using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RevenueForecast
{
    public partial class RevenueForecastItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public GridView GridViewMain { get; set; }
        public int RowHandle { get; set; }
        public override void InitGridControlDataSource()
        {
            RevenueForecastEntities entity = (RevenueForecastEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RevenueForecastItemList;
            this.DataSource = bds;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = false;
        }
        public BandedGridView InitializeBandedGridView(GridView gridView)
        {
            RevenueForecastEntities entity = (RevenueForecastEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARRevenueForecastsInfo mainObject = (ARRevenueForecastsInfo)entity.MainObject;
            BandedGridView bandedView = new BandedGridView();
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowChildrenInGroupPanel = true;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;
            bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            bandedView.OptionsView.ShowColumnHeaders = true;
            bandedView.OptionsCustomization.AllowSort = true;
            bandedView.OptionsCustomization.AllowGroup = true;
            List<GridBand> GridBandList = new List<GridBand>();
            GridBand sttBand = CreateGridBand("Thông tin khách hàng", GridBandList);
            CreateBandedGridColumn("FK_ARCustomerID", "Mã KH", sttBand, bandedView, 100, false);
            CreateBandedGridColumn("ARRevenueForecastItemCustomerName", "Tên KH", sttBand, bandedView, 200, false);
            CreateBandedGridColumn("ARRevenueForecastItemCustomerAddressLine3", "Địa chỉ", sttBand, bandedView, 200, false);
            CreateBandedGridColumn("ARRevenueForecastItemCustomerEmail", "Email", sttBand, bandedView, 100, false);
            CreateBandedGridColumn("ARRevenueForecastItemCustomerTel", "Tel", sttBand, bandedView, 50, false);
            int year = mainObject.ARRevenueForecastYear == 0 ? DateTime.Now.Year : mainObject.ARRevenueForecastYear;
            sttBand = CreateGridBand("Doanh thu 3 năm liền kề", GridBandList);
            int i = 0;
            while (i < 3)
            {
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}January", i == 0 ?"":i.ToString()), string.Format("01/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}Febuary", i == 0 ? "" : i.ToString()), string.Format("02/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}March", i == 0 ? "" : i.ToString()), string.Format("03/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}April", i == 0 ? "" : i.ToString()), string.Format("04/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}May", i == 0 ? "" : i.ToString()), string.Format("05/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}June", i == 0 ? "" : i.ToString()), string.Format("06/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}July", i == 0 ? "" : i.ToString()), string.Format("07/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}August", i == 0 ? "" : i.ToString()), string.Format("08/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}September", i == 0 ? "" : i.ToString()), string.Format("09/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}October", i == 0 ? "" : i.ToString()), string.Format("10/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}November", i == 0 ? "" : i.ToString()), string.Format("11/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                CreateBandedNumbericN0GridColumn(string.Format("ARRevenueForecastItemPre{0}December", i == 0 ? "" : i.ToString()), string.Format("12/{0}", (year - 3 + i).ToString()), sttBand, bandedView, false);
                i++;
            }
            sttBand = CreateGridBand("", GridBandList);
            CreateBandedNumbericN2GridColumn("ARRevenueForecastItemPredictAmount", "Doanh thu dự kiến  (năm)", sttBand, bandedView, true);
            sttBand = CreateGridBand("Doanh thu sales điều chỉnh (năm)", GridBandList);
            CreateBandedNumbericN2GridColumn("ARRevenueForecastItemPredictSalePercent", "%", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictSaleAmount", "Doanh thu", sttBand, bandedView, true);
            sttBand = CreateGridBand("Doanh thu duyệt (năm)", GridBandList);
            CreateBandedNumbericN2GridColumn("ARRevenueForecastItemPredictAcceptPercent", "%", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictAcceptAmount", "Doanh thu", sttBand, bandedView, true);
            sttBand = CreateGridBand("Doanh thu dự kiến (tháng)", GridBandList);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictJanuary", "T1", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictFebuary", "T2", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictMarch", "T3", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictApril", "T4", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictMay", "T5", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictJune", "T6", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictJuly", "T7", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictAugust", "T8", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictSeptember", "T9", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictOctober", "T10", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictNovember", "T11", sttBand, bandedView, true);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictDecember", "T12", sttBand, bandedView, true);
            sttBand = CreateGridBand("", GridBandList);
            CreateBandedGridColumn("ARRevenueForecastItemPredictComment", "Ghi chú", sttBand, bandedView, 50, true);
            sttBand = CreateGridBand("Doanh thu thực tế (tháng)", GridBandList);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemJanuary", "T1", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemFebuary", "T2", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemMarch", "T3", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemApril", "T4", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemMay", "T5", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemJune", "T6", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemJuly", "T7", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemAugust", "T8", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemSeptember", "T9", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemOctober", "T10", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemNovember", "T11", sttBand, bandedView, false);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemDecember", "T12", sttBand, bandedView, false);
            sttBand = CreateGridBand("", GridBandList);
            CreateBandedGridColumn("ARRevenueForecastItemPredictRealComment", "Ghi chú thực tế", sttBand, bandedView, 50, mainObject.ARRevenueForecastStatus != "Confirmed");
            CreateBandedHyperLinkGridColum("EditComment", "Sửa ghi chú thực tế", sttBand, bandedView);
            bandedView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            bandedView.KeyUp += new KeyEventHandler(BandedView_KeyUp);
            return bandedView;
        }
        private void BandedView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                BandedGridView bandedView = (BandedGridView)MainView;
                if (bandedView.FocusedRowHandle >= 0)
                {
                    ((RevenueForecastModule)Screen.Module).RemoveRevenueForecastItem();
                }
            }
        }
        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, int minWidth, bool allowEdit)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.MinWidth = minWidth;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.False;
            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedLocation.OptionsColumn.AllowEdit = allowEdit;
            bandedLocation.AppearanceHeader.Options.UseTextOptions = true;
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            bandedView.Columns.Add(bandedLocation);

        }
        public void CreateBandedNumbericN0GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, bool allowEdit)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = allowEdit;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n0}";
            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.False;
            bandedLocation.MinWidth = 80;
            bandedLocation.AppearanceHeader.Options.UseTextOptions = true;
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            bandedView.Columns.Add(bandedLocation);

            //   bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n0}";
        }
        public void CreateBandedNumbericN2GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, bool allowEdit)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n2}";
            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.False;
            bandedLocation.MinWidth = 100;
            bandedLocation.AppearanceHeader.Options.UseTextOptions = true;
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            bandedLocation.OptionsColumn.AllowEdit = allowEdit;
            bandedView.Columns.Add(bandedLocation);

            // bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }
        public void CreateBandedHyperLinkGridColum(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = true;
            bandedLocation.OwnerBand = ownerBand;

            RepositoryItemHyperLinkEdit EditCommentInfo = new RepositoryItemHyperLinkEdit();
            EditCommentInfo.NullText = "Sửa ghi chú thực tế";
            EditCommentInfo.Click += new EventHandler(EditCommentInfo_Click);
            bandedLocation.ColumnEdit = EditCommentInfo;
            bandedView.Columns.Add(bandedLocation);
        }
        public GridBand CreateGridBand(string caption, List<GridBand> GridBandList)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            GridBandList.Add(gridBand);
            return gridBand;
        }
        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }
        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                ARRevenueForecastItemsInfo item = (ARRevenueForecastItemsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "ARRevenueForecastItemPredictSalePercent")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictSalePercent(item);
                }
                if (e.Column.FieldName == "ARRevenueForecastItemPredictAcceptPercent")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictAcceptPercent(item);
                }
                if (e.Column.FieldName == "ARRevenueForecastItemPredictAmount")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictRevenue(item);
                    ((RevenueForecastModule)Screen.Module).ChangePredictSalesRevenue(item);
                    ((RevenueForecastModule)Screen.Module).ChangePredictAcceptRevenue(item);
                }
                if (e.Column.FieldName == "ARRevenueForecastItemPredictSaleAmount")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictSalesRevenue(item);
                    ((RevenueForecastModule)Screen.Module).ChangePredictAcceptRevenue(item);
                }
                if (e.Column.FieldName == "ARRevenueForecastItemPredictAcceptAmount")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictAcceptRevenue(item);
                }
                if (e.Column.FieldName == "ARRevenueForecastItemPredictJanuary"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictFebuary"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictMarch"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictApril"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictMay"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictJune"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictJuly"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictAugust"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictSeptember"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictOctober"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictNovember"
                    || e.Column.FieldName == "ARRevenueForecastItemPredictDecember")
                {
                    ((RevenueForecastModule)Screen.Module).ChangePredictAcceptMonthRevenue(item);
                }
            }
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //GridColumn column = gridView.Columns["FK_ARCustomerID"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 1;
            //}
            //column = gridView.Columns["ARRevenueForecastItemCustomerName"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 2;
            //}
            //column = gridView.Columns["ARRevenueForecastItemCustomerAddressLine3"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 3;
            //}
            //column = gridView.Columns["ARRevenueForecastItemCustomerEmail"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 4;
            //}
            //column = gridView.Columns["ARRevenueForecastItemCustomerTel"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 5;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictAmount"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 42;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictSalePercent"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 43;
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictSaleAmount"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 44;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictAcceptPercent"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 45;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictAcceptAmount"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 46;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictJanuary"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 47;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictFebuary"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 48;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictMarch"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 49;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictApril"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 50;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictMay"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 51;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictJune"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 52;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictJuly"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 53;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictAugust"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 54;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictSeptember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 55;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictOctober"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 56;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictNovember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 57;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictDecember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 58;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictComment"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 59;
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = gridView.Columns["ARRevenueForecastItemJanuary"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 60;
            //}
            //column = gridView.Columns["ARRevenueForecastItemFebuary"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 61;
            //}
            //column = gridView.Columns["ARRevenueForecastItemMarch"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 62;
            //}
            //column = gridView.Columns["ARRevenueForecastItemApril"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 63;
            //}
            //column = gridView.Columns["ARRevenueForecastItemMay"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 64;
            //}
            //column = gridView.Columns["ARRevenueForecastItemJune"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 65;
            //}
            //column = gridView.Columns["ARRevenueForecastItemJuly"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 66;
            //}
            //column = gridView.Columns["ARRevenueForecastItemAugust"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 67;
            //}
            //column = gridView.Columns["ARRevenueForecastItemSeptember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 68;
            //}
            //column = gridView.Columns["ARRevenueForecastItemOctober"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 69;
            //}
            //column = gridView.Columns["ARRevenueForecastItemNovember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 70;
            //}
            //column = gridView.Columns["ARRevenueForecastItemDecember"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 71;
            //}
            //column = gridView.Columns["ARRevenueForecastItemPredictRealComment"];
            //if (column != null)
            //{
            //    column.VisibleIndex = 72;
            //    column.OptionsColumn.AllowEdit = true;
            ////}
            //return gridView;
        }
        //public void LoadCaptionRevenueYear(int year)
        //{
        //    GridView gridView = (GridView)MainView;
        //    GridColumn column = gridView.Columns["ARRevenueForecastItemPreJanuary"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 1/", year - 3);
        //        column.VisibleIndex = 6;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreFebuary"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 2/", year - 3);
        //        column.VisibleIndex = 7;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreMarch"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 3/", year - 3);
        //        column.VisibleIndex = 8;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreApril"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 4/", year - 3);
        //        column.VisibleIndex = 9;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreMay"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 5/", year - 3);
        //        column.VisibleIndex = 10;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreJune"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 6/", year - 3);
        //        column.VisibleIndex = 11;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreJuly"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 7/", year - 3);
        //        column.VisibleIndex = 12;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreAugust"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 8/", year - 3);
        //        column.VisibleIndex = 13;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreSeptember"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 9/", year - 3);
        //        column.VisibleIndex = 14;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreOctober"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 10/", year - 3);
        //        column.VisibleIndex = 15;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreNovember"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 11/", year - 3);
        //        column.VisibleIndex = 16;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPreDecember"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 12/", year - 3);
        //        column.VisibleIndex = 17;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1January"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 1/", year - 2);
        //        column.VisibleIndex = 18;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1Febuary"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 2/", year - 2);
        //        column.VisibleIndex = 19;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1March"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 3/", year - 2);
        //        column.VisibleIndex = 20;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1April"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 4/", year - 2);
        //        column.VisibleIndex = 21;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1May"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 5/", year - 2);
        //        column.VisibleIndex = 22;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1June"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 6/", year - 2);
        //        column.VisibleIndex = 23;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1July"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 7/", year - 2);
        //        column.VisibleIndex = 24;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1August"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 8/", year - 2);
        //        column.VisibleIndex = 25;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1September"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 9/", year - 2);
        //        column.VisibleIndex = 26;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1October"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 10/", year - 2);
        //        column.VisibleIndex = 27;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1November"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 11/", year - 2);
        //        column.VisibleIndex = 28;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre1December"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 12/", year - 2);
        //        column.VisibleIndex = 29;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2January"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 1/", year - 1);
        //        column.VisibleIndex = 30;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2Febuary"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 2/", year - 1);
        //        column.VisibleIndex = 31;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2March"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 3/", year - 1);
        //        column.VisibleIndex = 32;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2April"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 4/", year - 1);
        //        column.VisibleIndex = 33;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2May"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 5/", year - 1);
        //        column.VisibleIndex = 34;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2June"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 6/", year - 1);
        //        column.VisibleIndex = 35;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2July"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 7/", year - 1);
        //        column.VisibleIndex = 36;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2August"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 8/", year - 1);
        //        column.VisibleIndex = 37;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2September"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 9/", year - 1);
        //        column.VisibleIndex = 38;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2October"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 10/", year - 1);
        //        column.VisibleIndex = 39;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2November"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 11/", year - 1);
        //        column.VisibleIndex = 40;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPre2December"];
        //    if (column != null)
        //    {
        //        column.Caption = string.Format("Doanh thu tháng 12/", year - 1);
        //        column.VisibleIndex = 41;
        //    }
        //    column = gridView.Columns["ARRevenueForecastItemPredictRealComment"];
        //    if (column != null)
        //    {
        //        column.OptionsColumn.AllowEdit = false;
        //    }
        //}
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Sửa ghi chú thực tế";
            column.FieldName = "EditComment";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 73;

            RepositoryItemHyperLinkEdit EditCommentInfo = new RepositoryItemHyperLinkEdit();
            EditCommentInfo.NullText = "Sửa ghi chú thực tế";
            EditCommentInfo.Click += new EventHandler(EditCommentInfo_Click);
            column.ColumnEdit = EditCommentInfo;
            gridView.Columns.Add(column);

        }
        private void EditCommentInfo_Click(object sender, EventArgs e)
        {
            ((RevenueForecastModule)Screen.Module).UpdateRealityComment();
        }    
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            //GridView gridView = (GridView)MainView;
            //ARRevenueForecastItemsInfo item = (ARRevenueForecastItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            //if (e.Column.FieldName == "ARRevenueForecastItemPredictSalePercent")
            //{
            //    ((RevenueForecastModule)Screen.Module).ChangePredictSalePercent();
            //}    
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARCustomerID")
            {
                if (e.Value != null)
                {
                    int customerID = 0;
                    int.TryParse(e.Value.ToString(), out customerID);
                    if (customerID == 0)
                    {
                        e.DisplayText = String.Empty;
                        return;
                    }
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                    if (objCustomersInfo != null)
                    {
                        e.DisplayText = objCustomersInfo.ARCustomerNo;
                    }
                }
            }
        }
    }
}
