using BOSCommon;
using BOSCommon.Extensions;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP_RevenueByCustomer1 : ReportForm
    {

        public BOSLookupEdit ViewTypeControl;
        private BackgroundWorker ExportWorker;
        public string FilePath { get; set; }
        public RP_RevenueByCustomer1()
        {
            InitializeComponent();
        }
        public string PublicLotNo = string.Empty;
        public double PublicExchangeRate = 0;
        public decimal OldRoundingNumber = 1;
        public decimal RoundingNumber = 1;
        private void RPPTCP_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_tbYear.EditValue = DateTime.Now.Year.ToString();
            //fld_dteFromYear.DateTime = DateTime.Now;
            //fld_dteToYear.DateTime = DateTime.Now;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = objConfigValuesController.GetADConfigValuesByKeyGroup("ViewType");
            if (fld_lkeViewType != null)
            {
                fld_lkeViewType.Properties.DataSource = configValuesList;
            }
            configValuesList = objConfigValuesController.GetADConfigValuesByKeyGroup("RoundingNumber");
            if (fld_lkeRoundingNumber != null)
            {
                fld_lkeRoundingNumber.Properties.DataSource = configValuesList;
                fld_lkeRoundingNumber.EditValue = "1";
            }
        }


        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, List<string> distinctMonth, DateTime fromMonth, DateTime toMonth)
        {


            string viewType = "Month";
            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
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
            GridBand sttBand = CreateGridBand("", GridBandList);
            CreateBandedGridColumn("STT", "STT", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerNo", "Mã khách hàng", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerName", "Tên khách hàng", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerDeliveryAddressLine1", "Địa chỉ", sttBand, bandedView, 50);
            CreateBandedGridColumn("StateProvince", "Tỉnh/Thành", sttBand, bandedView, 50);
            CreateBandedGridColumn("LocalArea", "Miền", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerTypeName", "Đối tượng KH", sttBand, bandedView, 50);
            CreateBandedGridColumn("ProductGroupAbbreviation", "Nhóm hàng cha", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerContactName", "Người liên hệ", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerContactPhone", "Số điện thoại", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerContactEmail1", "Email", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerDesc", "Đặc điểm", sttBand, bandedView, 50);
            CreateBandedGridColumn("HREmployeeName", "NV quản lý", sttBand, bandedView, 50);

            sttBand = CreateGridBand("Doanh thu 3 năm liền kề", GridBandList);
            DateTime compareDate = new DateTime(toMonth.Year - 3, 1, 1);
            DateTime endDate = new DateTime(toMonth.Year - 1, 1, 1);
            if (fld_lkeViewType.EditValue != null)
            {
                viewType = fld_lkeViewType.EditValue.ToString();
            }
            int i = 0;
            if (viewType == "Year")
            {
                while ((endDate - compareDate).Days >= 0)
                {
                    CreateBandedNumbericN2GridColumn(compareDate.ToString("yyyy"), compareDate.ToString("yyyy"), sttBand, bandedView);
                    compareDate = compareDate.AddYears(1);
                }
            }
            else if (viewType == "Month")
            {
                while (i < 3)
                {
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang1Nam{0}", i + 1), String.Format("T1/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang2Nam{0}", i + 1), String.Format("T2/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang3Nam{0}", i + 1), String.Format("T3/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang4Nam{0}", i + 1), String.Format("T4/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang5Nam{0}", i + 1), String.Format("T5/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang6Nam{0}", i + 1), String.Format("T6/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang7Nam{0}", i + 1), String.Format("T7/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang8Nam{0}", i + 1), String.Format("T8/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang9Nam{0}", i + 1), String.Format("T9/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang10Nam{0}", i + 1), String.Format("T10/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang11Nam{0}", i + 1), String.Format("T11/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeThang12Nam{0}", i + 1), String.Format("T12/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    i++;
                }
            }
            else
            {
                while (i < 3)
                {
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeQuy1Nam{0}", i + 1), String.Format("Q1/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeQuy2Nam{0}", i + 1), String.Format("Q2/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeQuy3Nam{0}", i + 1), String.Format("Q3/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    CreateBandedNumbericN0GridColumn(String.Format("DoanhThuLienKeQuy4Nam{0}", i + 1), String.Format("Q4/{0}", fromMonth.Year - 3 + i), sttBand, bandedView);
                    i++;
                }
            }
            sttBand = CreateGridBand("", GridBandList);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictAmount", string.Format("Doanh thu dự kiến {0} (PM)", toMonth.Year), sttBand, bandedView);
            sttBand = CreateGridBand("Doanh thu sales điều chỉnh", GridBandList);
            CreateBandedNumbericN2GridColumn("ARRevenueForecastItemPredictSalePercent", "%", sttBand, bandedView);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictSaleAmount", "Doanh thu", sttBand, bandedView);
            sttBand = CreateGridBand("Doanh thu duyệt", GridBandList);
            CreateBandedNumbericN2GridColumn("ARRevenueForecastItemPredictAcceptPercent", "%", sttBand, bandedView);
            CreateBandedNumbericN0GridColumn("ARRevenueForecastItemPredictAcceptAmount", "Doanh thu", sttBand, bandedView);
            sttBand = CreateGridBand(string.Format("Doanh thu dự kiến {0}", toMonth.Year), GridBandList);
            if (viewType == "Month")
            {
                CreateBandedNumbericN0GridColumn("DoanhThuThang1", "T1", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang2", "T2", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang3", "T3", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang4", "T4", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang5", "T5", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang6", "T6", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang7", "T7", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang8", "T8", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang9", "T9", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang10", "T10", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang11", "T11", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThang12", "T12", sttBand, bandedView);
            }
            else if (viewType == "Year")
            {
                CreateBandedNumbericN0GridColumn("DoanhThuNam", DateTime.Now.ToString("yyyy"), sttBand, bandedView);
            }
            else
            {
                CreateBandedNumbericN0GridColumn("DoanhThuQuy1", "Quý 1", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuQuy2", "Quý 2", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuQuy3", "Quý 3", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuQuy4", "Quý 4", sttBand, bandedView);
            }
            sttBand = CreateGridBand(string.Format("Doanh thu thực tế {0}", toMonth.Year), GridBandList);
            if (viewType == "Month")
            {
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang1", "T1", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang2", "T2", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang3", "T3", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang4", "T4", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang5", "T5", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang6", "T6", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang7", "T7", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang8", "T8", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang9", "T9", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang10", "T10", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang11", "T11", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeThang12", "T12", sttBand, bandedView);
            }
            else if (viewType == "Year")
            {
                CreateBandedNumbericN0GridColumn("DoanhThuThucTe", DateTime.Now.ToString("yyyy"), sttBand, bandedView);
            }
            else
            {
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeQuy1", "Quý 1", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeQuy2", "Quý 2", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeQuy3", "Quý 3", sttBand, bandedView);
                CreateBandedNumbericN0GridColumn("DoanhThuThucTeQuy4", "Quý 4", sttBand, bandedView);
            }
            sttBand = CreateGridBand("", GridBandList);
            CreateBandedNumbericN0GridColumn("DoanhThuThucTe", "Tổng doanh thu thực tế đến " + DateTime.Now.ToString("dd/MM/yyyy"), sttBand, bandedView);
            CreateBandedNumbericN0GridColumn("TyLeDatDuoc", "Đạt được so với thực tế", sttBand, bandedView);
            CreateBandedGridColumn("Comment", "Ghi chú", sttBand, bandedView, 50);
            //foreach (string monthStr in distinctMonth)
            //{

            //}




            //bandedView.DoubleClick += new EventHandler(bandedView_DoubleClick);
            //bandedView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(bandedView_CustomDrawCell);
            bandedView.Bands.AddRange(GridBandList.ToArray());
            //bandedView.RowCellStyle += new RowCellStyleEventHandler(bandedView_RowCellStyle);

            //bandedView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(bandedView_CustomColumnDisplayText);
            //bandedView.OptionsMenu.EnableColumnMenu = true;

            bandedView.BestFitColumns();
            return bandedView;
        }

        void bandedView_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView view = (BandedGridView)sender;
            view.BestFitColumns();
        }

        void bandedView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo cell = e.Cell as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo;
            cell.CellButtonRect = Rectangle.Empty;
        }




        void bandedView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            DateTime value = DateTime.Now;
            if (DateTime.TryParse(e.Value.ToString(), out value))
            {
                if (value.ToString("yyyy") == "9999" || value.ToString("yyyy") == "0001")
                {
                    e.DisplayText = string.Empty;
                }

            }

            int intValue = 0;
            if (int.TryParse(e.Value.ToString(), out intValue))
            {
                if (intValue == 0)
                {
                    e.DisplayText = string.Empty;
                }
            }
        }

        void bandedView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            //e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 8, FontStyle.Regular);

            BandedGridView view = (BandedGridView)fld_dgcARInvoices.MainView;
            if (view != null)
            {
                DataRow dr = view.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    if (dr["RowType"] == "Sum")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Italic | FontStyle.Bold);
                        e.Appearance.BackColor = Color.LightBlue;
                    }
                    else if (dr["RowType"] == "SumTotal")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                        e.Appearance.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                        e.Appearance.BackColor = Color.Transparent;
                    }
                }
            }
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


        public GridBand CreateGridBand(string caption)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;
            return gridBand;
        }

        public void CreateBandedGridColumnCenter(string name, string caption, GridBand ownerBand, BandedGridView bandedView, int minWidth)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            bandedLocation.MinWidth = minWidth;
            bandedView.Columns.Add(bandedLocation);

        }
        public void CreateBandedGridColumnCenter(string name, string caption, BandedGridView bandedView, int minWidth)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            bandedLocation.MinWidth = minWidth;
            bandedView.Columns.Add(bandedLocation);

        }

        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, int minWidth)
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
            bandedView.Columns.Add(bandedLocation);

        }


        public void CreateBandedNumbericN4GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n4}";
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);


            //   bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n4}";
        }

        public void CreateBandedNumbericN2GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
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
            bandedLocation.MinWidth = 50;
            bandedView.Columns.Add(bandedLocation);

            // bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }

        public void CreateBandedNumbericN0GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n0}";
            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.False;
            bandedLocation.MinWidth = 50;
            bandedView.Columns.Add(bandedLocation);

            //   bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n0}";
        }

        public void CreateBandedWeekGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;
            bandedLocation.DisplayFormat.FormatType = FormatType.Numeric;
            bandedLocation.DisplayFormat.FormatString = "{0:n0}";
            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.True;
            bandedLocation.MinWidth = 50;
            bandedView.Columns.Add(bandedLocation);

            //   bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //  bandedLocation.SummaryItem.DisplayFormat = "{0:n0}";
        }

        public double CalculateExchange(double exchangeQty, string operation, double value)
        {
            double result = 0;
            if (operation == ExchangeRateConfigOperationType.Plus.ToString())
            {
                result = exchangeQty + value;
            }
            else if (operation == ExchangeRateConfigOperationType.Minus.ToString())
            {
                result = exchangeQty - value;
            }
            else if (operation == ExchangeRateConfigOperationType.Multi.ToString())
            {
                result = exchangeQty * value;
            }
            else if (operation == ExchangeRateConfigOperationType.Split.ToString())
            {
                result = exchangeQty / value;
            }
            else
            {
                result = exchangeQty;
            }
            return result;
        }



        public void FillDataTable(List<ADReportsInfo> dataList
                                    , DataTable dt, int year
            )
        {
            List<ADReportsInfo> filterList = new List<ADReportsInfo>();
            List<string> distinctList = dataList.Select(t => t.ARCustomerID
                                                        + "_" + t.ARCustomerNo
                                                        + "_" + t.ARCustomerName
                                                        + "_" + t.HREmployeeName).Distinct().ToList();
            int count = 0;
            foreach (string key in distinctList)
            {

                filterList = dataList.Where(t => (t.ARCustomerID
                                                        + "_" + t.ARCustomerNo
                                                        + "_" + t.ARCustomerName
                                                        + "_" + t.HREmployeeName) == key).ToList();
                DataRow dr = dt.NewRow();
                dr["STT"] = (++count).ToString();
                dr["ARCustomerNo"] = filterList[0].ARCustomerNo;
                dr["ARCustomerName"] = filterList[0].ARCustomerName;
                dr["ARCustomerDeliveryAddressLine1"] = filterList[0].ARCustomerDeliveryAddressLine1;
                dr["StateProvince"] = filterList[0].StateProvince;
                dr["LocalArea"] = filterList[0].LocalArea;
                dr["ARCustomerTypeName"] = filterList[0].ARCustomerTypeName;
                dr["ProductGroupAbbreviation"] = filterList[0].ProductGroupAbbreviation;
                dr["ARCustomerContactName"] = filterList[0].ARCustomerContactName;
                dr["ARCustomerContactPhone"] = filterList[0].ARCustomerContactPhone;
                dr["ARCustomerContactEmail1"] = filterList[0].ARCustomerContactEmail1;
                dr["ARCustomerDesc"] = filterList[0].ARCustomerDesc;
                dr["HREmployeeName"] = filterList[0].HREmployeeName;
                dr["Comment"] = filterList[0].Comment;
                dr["DoanhThuLienKeThang1Nam1"] = filterList[0].DoanhThuLienKeThang1Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang2Nam1"] = filterList[0].DoanhThuLienKeThang2Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang3Nam1"] = filterList[0].DoanhThuLienKeThang3Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang4Nam1"] = filterList[0].DoanhThuLienKeThang4Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang5Nam1"] = filterList[0].DoanhThuLienKeThang5Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang6Nam1"] = filterList[0].DoanhThuLienKeThang6Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang7Nam1"] = filterList[0].DoanhThuLienKeThang7Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang8Nam1"] = filterList[0].DoanhThuLienKeThang8Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang9Nam1"] = filterList[0].DoanhThuLienKeThang9Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang10Nam1"] = filterList[0].DoanhThuLienKeThang10Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang11Nam1"] = filterList[0].DoanhThuLienKeThang11Nam1 / RoundingNumber;
                dr["DoanhThuLienKeThang12Nam1"] = filterList[0].DoanhThuLienKeThang12Nam1 / RoundingNumber;
                dr["DoanhThuLienKeQuy1Nam1"] = (filterList[0].DoanhThuLienKeThang1Nam1 + filterList[0].DoanhThuLienKeThang2Nam1 + filterList[0].DoanhThuLienKeThang3Nam1) / RoundingNumber;
                dr["DoanhThuLienKeQuy2Nam1"] = (filterList[0].DoanhThuLienKeThang4Nam1 + filterList[0].DoanhThuLienKeThang5Nam1 + filterList[0].DoanhThuLienKeThang6Nam1) / RoundingNumber;
                dr["DoanhThuLienKeQuy3Nam1"] = (filterList[0].DoanhThuLienKeThang7Nam1 + filterList[0].DoanhThuLienKeThang8Nam1 + filterList[0].DoanhThuLienKeThang9Nam1) / RoundingNumber;
                dr["DoanhThuLienKeQuy4Nam1"] = (filterList[0].DoanhThuLienKeThang10Nam1 + filterList[0].DoanhThuLienKeThang11Nam1 + filterList[0].DoanhThuLienKeThang12Nam1) / RoundingNumber;
                dr["DoanhThuLienKeThang1Nam2"] = filterList[0].DoanhThuLienKeThang1Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang2Nam2"] = filterList[0].DoanhThuLienKeThang2Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang3Nam2"] = filterList[0].DoanhThuLienKeThang3Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang4Nam2"] = filterList[0].DoanhThuLienKeThang4Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang5Nam2"] = filterList[0].DoanhThuLienKeThang5Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang6Nam2"] = filterList[0].DoanhThuLienKeThang6Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang7Nam2"] = filterList[0].DoanhThuLienKeThang7Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang8Nam2"] = filterList[0].DoanhThuLienKeThang8Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang9Nam2"] = filterList[0].DoanhThuLienKeThang9Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang10Nam2"] = filterList[0].DoanhThuLienKeThang10Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang11Nam2"] = filterList[0].DoanhThuLienKeThang11Nam2 / RoundingNumber;
                dr["DoanhThuLienKeThang12Nam2"] = filterList[0].DoanhThuLienKeThang12Nam2 / RoundingNumber;
                dr["DoanhThuLienKeQuy1Nam2"] = (filterList[0].DoanhThuLienKeThang1Nam2 + filterList[0].DoanhThuLienKeThang2Nam2 + filterList[0].DoanhThuLienKeThang3Nam2) / RoundingNumber;
                dr["DoanhThuLienKeQuy2Nam2"] = (filterList[0].DoanhThuLienKeThang4Nam2 + filterList[0].DoanhThuLienKeThang5Nam2 + filterList[0].DoanhThuLienKeThang6Nam2) / RoundingNumber;
                dr["DoanhThuLienKeQuy3Nam2"] = (filterList[0].DoanhThuLienKeThang7Nam2 + filterList[0].DoanhThuLienKeThang8Nam2 + filterList[0].DoanhThuLienKeThang9Nam2) / RoundingNumber;
                dr["DoanhThuLienKeQuy4Nam2"] = (filterList[0].DoanhThuLienKeThang10Nam2 + filterList[0].DoanhThuLienKeThang11Nam2 + filterList[0].DoanhThuLienKeThang12Nam2) / RoundingNumber;
                dr["DoanhThuLienKeThang1Nam3"] = filterList[0].DoanhThuLienKeThang1Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang2Nam3"] = filterList[0].DoanhThuLienKeThang2Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang3Nam3"] = filterList[0].DoanhThuLienKeThang3Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang4Nam3"] = filterList[0].DoanhThuLienKeThang4Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang5Nam3"] = filterList[0].DoanhThuLienKeThang5Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang6Nam3"] = filterList[0].DoanhThuLienKeThang6Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang7Nam3"] = filterList[0].DoanhThuLienKeThang7Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang8Nam3"] = filterList[0].DoanhThuLienKeThang8Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang9Nam3"] = filterList[0].DoanhThuLienKeThang9Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang10Nam3"] = filterList[0].DoanhThuLienKeThang10Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang11Nam3"] = filterList[0].DoanhThuLienKeThang11Nam3 / RoundingNumber;
                dr["DoanhThuLienKeThang12Nam3"] = filterList[0].DoanhThuLienKeThang12Nam3 / RoundingNumber;
                dr["DoanhThuLienKeQuy1Nam3"] = (filterList[0].DoanhThuLienKeThang1Nam3 + filterList[0].DoanhThuLienKeThang2Nam3 + filterList[0].DoanhThuLienKeThang3Nam3) / RoundingNumber;
                dr["DoanhThuLienKeQuy2Nam3"] = (filterList[0].DoanhThuLienKeThang4Nam3 + filterList[0].DoanhThuLienKeThang5Nam3 + filterList[0].DoanhThuLienKeThang6Nam3) / RoundingNumber;
                dr["DoanhThuLienKeQuy3Nam3"] = (filterList[0].DoanhThuLienKeThang7Nam3 + filterList[0].DoanhThuLienKeThang8Nam3 + filterList[0].DoanhThuLienKeThang9Nam3) / RoundingNumber;
                dr["DoanhThuLienKeQuy4Nam3"] = (filterList[0].DoanhThuLienKeThang10Nam3 + filterList[0].DoanhThuLienKeThang11Nam3 + filterList[0].DoanhThuLienKeThang12Nam3) / RoundingNumber;
                dr["DoanhThuThang1"] = filterList[0].DoanhThuThang1 / RoundingNumber;
                dr["DoanhThuThang2"] = filterList[0].DoanhThuThang2 / RoundingNumber;
                dr["DoanhThuThang3"] = filterList[0].DoanhThuThang3 / RoundingNumber;
                dr["DoanhThuThang4"] = filterList[0].DoanhThuThang4 / RoundingNumber;
                dr["DoanhThuThang5"] = filterList[0].DoanhThuThang5 / RoundingNumber;
                dr["DoanhThuThang6"] = filterList[0].DoanhThuThang6 / RoundingNumber;
                dr["DoanhThuThang7"] = filterList[0].DoanhThuThang7 / RoundingNumber;
                dr["DoanhThuThang8"] = filterList[0].DoanhThuThang8 / RoundingNumber;
                dr["DoanhThuThang9"] = filterList[0].DoanhThuThang9 / RoundingNumber;
                dr["DoanhThuThang10"] = filterList[0].DoanhThuThang10 / RoundingNumber;
                dr["DoanhThuThang11"] = filterList[0].DoanhThuThang11 / RoundingNumber;
                dr["DoanhThuThang12"] = filterList[0].DoanhThuThang12 / RoundingNumber;
                dr["DoanhThuNam"] = filterList[0].ARRevenueForecastItemPredictAcceptAmount / RoundingNumber;
                dr["DoanhThuQuy1"] = (filterList[0].DoanhThuThang1 + filterList[0].DoanhThuThang2 + filterList[0].DoanhThuThang3) / RoundingNumber;
                dr["DoanhThuQuy2"] = (filterList[0].DoanhThuThang4 + filterList[0].DoanhThuThang5 + filterList[0].DoanhThuThang6) / RoundingNumber;
                dr["DoanhThuQuy3"] = (filterList[0].DoanhThuThang7 + filterList[0].DoanhThuThang8 + filterList[0].DoanhThuThang9) / RoundingNumber;
                dr["DoanhThuQuy4"] = (filterList[0].DoanhThuThang10 + filterList[0].DoanhThuThang11 + filterList[0].DoanhThuThang12) / RoundingNumber;
                dr["DoanhThuThucTeThang1"] = filterList[0].DoanhThuThucTeThang1 / RoundingNumber;
                dr["DoanhThuThucTeThang2"] = filterList[0].DoanhThuThucTeThang2 / RoundingNumber;
                dr["DoanhThuThucTeThang3"] = filterList[0].DoanhThuThucTeThang3 / RoundingNumber;
                dr["DoanhThuThucTeThang4"] = filterList[0].DoanhThuThucTeThang4 / RoundingNumber;
                dr["DoanhThuThucTeThang5"] = filterList[0].DoanhThuThucTeThang5 / RoundingNumber;
                dr["DoanhThuThucTeThang6"] = filterList[0].DoanhThuThucTeThang6 / RoundingNumber;
                dr["DoanhThuThucTeThang7"] = filterList[0].DoanhThuThucTeThang7 / RoundingNumber;
                dr["DoanhThuThucTeThang8"] = filterList[0].DoanhThuThucTeThang8 / RoundingNumber;
                dr["DoanhThuThucTeThang9"] = filterList[0].DoanhThuThucTeThang9 / RoundingNumber;
                dr["DoanhThuThucTeThang10"] = filterList[0].DoanhThuThucTeThang10 / RoundingNumber;
                dr["DoanhThuThucTeThang11"] = filterList[0].DoanhThuThucTeThang11 / RoundingNumber;
                dr["DoanhThuThucTeThang12"] = filterList[0].DoanhThuThucTeThang12 / RoundingNumber;
                dr["DoanhThuThucTeQuy1"] = filterList[0].DoanhThuThucTeQuy1 / RoundingNumber;
                dr["DoanhThuThucTeQuy2"] = filterList[0].DoanhThuThucTeQuy2 / RoundingNumber;
                dr["DoanhThuThucTeQuy3"] = filterList[0].DoanhThuThucTeQuy3 / RoundingNumber;
                dr["DoanhThuThucTeQuy4"] = filterList[0].DoanhThuThucTeQuy4 / RoundingNumber;
                dr["ARRevenueForecastItemPredictAmount"] = filterList[0].ARRevenueForecastItemPredictAmount / RoundingNumber;
                dr["ARRevenueForecastItemPredictSalePercent"] = filterList[0].ARRevenueForecastItemPredictSalePercent;
                dr["ARRevenueForecastItemPredictSaleAmount"] = filterList[0].ARRevenueForecastItemPredictSaleAmount / RoundingNumber;
                dr["ARRevenueForecastItemPredictAcceptPercent"] = filterList[0].ARRevenueForecastItemPredictAcceptPercent;
                dr["ARRevenueForecastItemPredictAcceptAmount"] = filterList[0].ARRevenueForecastItemPredictAcceptAmount / RoundingNumber;
                foreach (ADReportsInfo data in filterList)
                {
                    if (dt.Columns[data.Nam] != null)
                    {
                        dr[data.Nam] = data.DoanhThu / RoundingNumber;
                    }
                    if (data.Nam == year.ToString())
                    {
                        if (filterList[0].TyLeDatDuoc != 0)
                        {
                            dr["TyLeDatDuoc"] = data.DoanhThu / filterList[0].TyLeDatDuoc * 100;
                        }
                        else
                        {
                            dr["TyLeDatDuoc"] = 0;
                        }
                    }
                }
                if (dr[year.ToString()] != null)
                {
                    dr["DoanhThuThucTe"] = dr[year.ToString()];
                }
                dt.Rows.Add(dr);
            }




        }

        public DataRow MergeRow(DataRow curRow, DataRow compareRow, List<string> mergeCols, DataTable dt)
        {
            string notMatchCol = string.Empty;
            foreach (string colName in mergeCols)
            {
                if (dt.Columns[colName] != null)
                {
                    if (dt.Columns[colName].DataType == System.Type.GetType("System.String"))
                    {
                        if (curRow[colName].ToString() == compareRow[colName].ToString())
                        {
                            curRow[colName] = string.Empty;
                        }
                        else
                        {
                            notMatchCol = colName;
                            break;
                        }
                    }
                    else if (dt.Columns[colName].DataType == System.Type.GetType("System.Double"))
                    {
                        if (Double.Parse(curRow[colName].ToString()) == Double.Parse(compareRow[colName].ToString()))
                        {
                            curRow[colName] = 0;
                        }
                        else
                        {
                            notMatchCol = colName;
                            break;
                        }
                    }
                    else if (dt.Columns[colName].DataType == System.Type.GetType("System.Int32"))
                    {
                        if (Int32.Parse(curRow[colName].ToString()) == Int32.Parse(compareRow[colName].ToString()))
                        {
                            curRow[colName] = 0;
                        }
                        else
                        {
                            notMatchCol = colName;
                            break;
                        }
                    }

                }
            }

            bool isColNotMatch = false;
            foreach (string colName in mergeCols)
            {
                if (colName == notMatchCol)
                {
                    isColNotMatch = true;
                }

                if (isColNotMatch)
                {
                    compareRow[colName] = curRow[colName];
                }
            }

            return compareRow;
        }

        public DataTable CreateDataTable(List<ADReportsInfo> dataList, List<string> distinctMonth)
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(String));
            dataTable.Columns.Add("ARCustomerNo", typeof(String));
            dataTable.Columns.Add("ARCustomerName", typeof(String));
            dataTable.Columns.Add("HREmployeeName", typeof(String));
            dataTable.Columns.Add("ARCustomerDeliveryAddressLine1", typeof(String));
            dataTable.Columns.Add("StateProvince", typeof(String));
            dataTable.Columns.Add("LocalArea", typeof(String));
            dataTable.Columns.Add("ARCustomerTypeName", typeof(String));
            dataTable.Columns.Add("ProductGroupAbbreviation", typeof(String));
            dataTable.Columns.Add("ARCustomerContactName", typeof(String));
            dataTable.Columns.Add("ARCustomerContactPhone", typeof(String));
            dataTable.Columns.Add("ARCustomerContactEmail1", typeof(String));
            dataTable.Columns.Add("ARCustomerDesc", typeof(String));
            dataTable.Columns.Add("DoanhThuLienKeThang1Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang2Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang3Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang4Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang5Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang6Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang7Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang8Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang9Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang10Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang11Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang12Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy1Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy2Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy3Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy4Nam1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang1Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang2Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang3Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang4Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang5Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang6Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang7Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang8Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang9Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang10Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang11Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang12Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy1Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy2Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy3Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy4Nam2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang1Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang2Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang3Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang4Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang5Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang6Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang7Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang8Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang9Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang10Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang11Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeThang12Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy1Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy2Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy3Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuLienKeQuy4Nam3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang4", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang5", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang6", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang7", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang8", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang9", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang10", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang11", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThang12", typeof(decimal));
            dataTable.Columns.Add("DoanhThuNam", typeof(decimal));
            dataTable.Columns.Add("DoanhThuQuy1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuQuy2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuQuy3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuQuy4", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang4", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang5", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang6", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang7", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang8", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang9", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang10", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang11", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeThang12", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTe", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeQuy1", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeQuy2", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeQuy3", typeof(decimal));
            dataTable.Columns.Add("DoanhThuThucTeQuy4", typeof(decimal));
            dataTable.Columns.Add("ARRevenueForecastItemPredictAmount", typeof(decimal));
            dataTable.Columns.Add("ARRevenueForecastItemPredictSalePercent", typeof(decimal));
            dataTable.Columns.Add("ARRevenueForecastItemPredictSaleAmount", typeof(decimal));
            dataTable.Columns.Add("ARRevenueForecastItemPredictAcceptPercent", typeof(decimal));
            dataTable.Columns.Add("ARRevenueForecastItemPredictAcceptAmount", typeof(decimal));
            dataTable.Columns.Add("TyLeDatDuoc", typeof(decimal));
            dataTable.Columns.Add("Comment", typeof(String));
            foreach (string monthStr in distinctMonth)
            {
                dataTable.Columns.Add(monthStr, typeof(decimal));
            }



            return dataTable;
        }


        public void ShowData(bool isPrint)
        {
            BOSProgressBar.Start("Đang xử lý báo cáo");
            //DateTime fromMonth = fld_dteFromYear.DateTime;
            //DateTime toMonth = fld_dteToYear.DateTime;
            int year = 0;
            int.TryParse(fld_tbYear.EditValue.ToString(), out year);
            int customerID = 0;
            string customerType = string.Empty;
            int employeeID = 0;
            bool isCheckDiscount = false;
            if (fld_lkeARCustomerID.EditValue != null)
            {
                int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customerID);
            }
            //if (customerID == 0)
            //{
            //    MessageBox.Show("Đối tượng đang để trống, vui lòng chọn đối tượng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (fld_lkeHREmployeeID.EditValue != null)
            {
                int.TryParse(fld_lkeHREmployeeID.EditValue.ToString(), out employeeID);
            }
            if (fld_lkeARCustomerType.EditValue != null)
            {
                customerType = fld_lkeARCustomerType.EditValue.ToString();
            }
            decimal roundingNumber = 1;
            if (fld_lkeRoundingNumber.EditValue != null)
            {
                decimal.TryParse(fld_lkeRoundingNumber.EditValue.ToString(), out roundingNumber);
                RoundingNumber = roundingNumber;
            }
            if (fld_ckeIsDiscount.Checked != null)
                isCheckDiscount = fld_ckeIsDiscount.Checked;
            DateTime fromMonth = new DateTime(year, 1, 1);
            DateTime toMonth = year == DateTime.Now.Year ? DateTime.Now : new DateTime(year, 12, 31);
            ADReportsController reportController = new ADReportsController();
            List<ADReportsInfo> reportData = reportController.GetRevenueByCustomer_1(fromMonth, toMonth, customerID, customerType, employeeID, isCheckDiscount);


            List<string> distinctyear = new List<string>();
            int i = 0;
            while (i <= 3)
            {
                distinctyear.Add(toMonth.AddYears(-i).ToString("yyyy"));
                i++;
            }

            DataTable dt = CreateDataTable(reportData, distinctyear);
            FillDataTable(reportData, dt, year);
            GridView gridView = (GridView)fld_dgcARInvoices.MainView;
            fld_dgcARInvoices.MainView = InitializeCustomerBandedGridView(gridView, distinctyear, fromMonth, toMonth);

            fld_dgcARInvoices.DataSource = dt;

            BandedGridView view = (BandedGridView)fld_dgcARInvoices.MainView;

            view.BestFitColumns();


            //if (isPrint)
            //{
            //    string xrDate = "( Từ tháng " + fromMonth.ToString("MM/yyyy") + " đến tháng " + toMonth.ToString("MM/yyyy") + " )";

            //    RPPTCP_Print report = new RPPTCP_Print(view, xrDate);
            //    guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevSaleOrderItemReportViewerPath, true);
            //    reviewer.Show();
            //}

            BOSProgressBar.Close();
        }
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowData(false);

        }

        private void fld_lkeICProductSerieLotNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            //LookUpEdit lookup = (LookUpEdit)sender;
            //ICProductSeriesController psController = new ICProductSeriesController();
            //List<ICProductSeriesInfo> psList = psController.GetLotNoFromPriceSheetForReport();

            //lookup.Properties.DataSource = psList;
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ShowData(true);
        }




        private void bosButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                //saveFileDialog1.InitialDirectory = @"C:\";

                //saveFileDialog1.Title = "Save Files";

                //saveFileDialog1.DefaultExt = "xlsx";

                //saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                //saveFileDialog1.FilterIndex = 2;

                //saveFileDialog1.RestoreDirectory = true;

                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{

                //    string fileName = saveFileDialog1.FileName;

                //    fld_dgcARInvoices.ExportToXlsx(fileName);
                //}
                ExportWorker = new BackgroundWorker
                {
                    WorkerReportsProgress = true,
                    WorkerSupportsCancellation = true
                };
                ExportWorker.DoWork += new DoWorkEventHandler(ExportWorker_DoWork);
                ExportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportWorker_RunWorkerCompleted);
                ExportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int year = 0;
            int customerID = 0;
            string customerType = string.Empty;
            int.TryParse(fld_tbYear.EditValue.ToString(), out year);
            BackgroundWorker background = sender as BackgroundWorker;
            background.ReportProgress(5);
            string documentPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BYSERP");
            if (!Directory.Exists(documentPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(documentPath);
            }
            DataTable dt = (DataTable)fld_dgcARInvoices.DataSource;
            List<ADReportsInfo> rp = new List<ADReportsInfo>();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ADReportsController objInvoicesController = new ADReportsController();
                    foreach (DataRow row in dt.Rows)
                    {
                        ADReportsInfo objInvoicesInfo = (ADReportsInfo)objInvoicesController.GetObjectFromDataRow(row);
                        if (row[(year - 3).ToString()] != null)
                        {
                            object objValue = row[(year - 3).ToString()];
                            if (objValue != System.DBNull.Value)
                            {
                                objInvoicesInfo.DoanhThuLienKeNam1 = (decimal)objValue;
                            }
                        }
                        if (row[(year - 2).ToString()] != null)
                        {
                            object objValue = row[(year - 2).ToString()];
                            if (objValue != System.DBNull.Value)
                            {
                                objInvoicesInfo.DoanhThuLienKeNam2 = (decimal)objValue;
                            }
                        }
                        if (row[(year - 1).ToString()] != null)
                        {
                            object objValue = row[(year - 1).ToString()];
                            if (objValue != System.DBNull.Value)
                            {
                                objInvoicesInfo.DoanhThuLienKeNam3 = (decimal)objValue;
                            }
                        }
                        rp.Add(objInvoicesInfo);
                    }
                }
            }
            if (fld_lkeARCustomerID.EditValue != null)
            {
                int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customerID);
            }
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            if (fld_lkeARCustomerType.EditValue != null)
            {
                customerType = fld_lkeARCustomerType.EditValue.ToString();
            }
            string customerTypeName = BOSApp.GetDisplayTextFromConfigValue("CustomerType", customerType);
            FilePath = Path.Combine(documentPath,
                string.Format("BaoCaoDoanhThuDuKien_Nam_{0}_NhanVien_{1}_{2}_{3}.xls",
                year,
                rp[0].HREmployeeName.RemoveUnicode().RemoveWhiteSpace(),
                rp[0].ARCustomerTypeName.RemoveUnicode().RemoveWhiteSpace(),
                DateTimeOffset.Now.ToUnixTimeSeconds()));
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = xlApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            xlApp.StandardFont = "Times New Roman";
            xlApp.StandardFontSize = 13;
            worksheet.Name = "Báo cáo doanh thu dự kiến";
            var nameSheet = worksheet.get_Range("A2", "AW2");
            nameSheet.Merge();
            nameSheet.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            nameSheet.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            nameSheet.Font.Size = 15;
            nameSheet.Font.Bold = true;
            nameSheet.HorizontalAlignment = HorizontalAlignment.Center;
            nameSheet.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            nameSheet.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.Color = Color.Black;
            nameSheet.Range["A1"].Value = string.Format("BÁO CÁO DOANH THU CHI TIẾT THEO KHÁCH HÀNG {0}",
                                                        objCustomersInfo != null ? objCustomersInfo.ARCustomerName.ToUpper() : customerTypeName.ToUpper());
            var header1 = worksheet.get_Range("A3", "M3");
            header1.Merge();
            header1.HorizontalAlignment = HorizontalAlignment.Center;
            header1.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header1.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header1.Font.Bold = true;
            header1.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header1.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header1.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header1.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header1.Range["A1"].Value = "Thông tin khách hàng";

            var header2 = worksheet.get_Range("N3", "P3");
            header2.Merge();
            header2.HorizontalAlignment = HorizontalAlignment.Center;
            header2.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header2.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header2.Font.Bold = true;
            header2.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header2.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header2.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header2.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header2.Range["A1"].Value = "Doanh thu 3 năm liền kề";

            var header3 = worksheet.get_Range("R3", "S3");
            header3.Merge();
            header3.HorizontalAlignment = HorizontalAlignment.Center;
            header3.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header3.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header3.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header3.Font.Bold = true;
            header3.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header3.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header3.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header3.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header3.Range["A1"].Value = "Doanh thu sales điều chỉnh";

            var header4 = worksheet.get_Range("T3", "U3");
            header4.Merge();
            header4.HorizontalAlignment = HorizontalAlignment.Center;
            header4.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header4.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header4.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header4.Font.Bold = true;
            header4.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header4.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header4.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header4.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header4.Range["A1"].Value = "Doanh thu duyệt";

            var header5 = worksheet.get_Range("W3", "AH3");
            header5.Merge();
            header5.HorizontalAlignment = HorizontalAlignment.Center;
            header5.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header5.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header5.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header5.Font.Bold = true;
            header5.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header5.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header5.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header5.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header5.Range["A1"].Value = "Doanh thu dự kiến 2024";

            var header6 = worksheet.get_Range("AI3", "AT3");
            header6.Merge();
            header6.HorizontalAlignment = HorizontalAlignment.Center;
            header6.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            header6.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header6.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header6.Font.Bold = true;
            header6.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header6.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header6.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header6.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            header6.Range["A1"].Value = "Doanh thu thực tế 2024";

            var header = worksheet.get_Range("A4", "AW4");
            header.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header.Font.Bold = true;
            header.Range["A1"].Value = "STT";
            header.Range["B1"].Value = "Mã khách";
            header.Range["C1"].Value = "Tên khách hàng";
            header.Range["D1"].Value = "Địa chỉ";
            header.Range["E1"].Value = "Tỉnh thành";
            header.Range["F1"].Value = "Miền";
            header.Range["G1"].Value = "Đối tượng KH";
            header.Range["H1"].Value = "Nhóm khách hàng cha";
            header.Range["I1"].Value = "Người liên hệ";
            header.Range["J1"].Value = "Số điện thoại";
            header.Range["K1"].Value = "Email";
            header.Range["L1"].Value = "Đặc điểm";
            header.Range["M1"].Value = "Nhân viên quản lý";
            header.Range["N1"].Value = (year - 3).ToString();
            header.Range["O1"].Value = (year - 2).ToString();
            header.Range["P1"].Value = (year - 1).ToString();
            header.Range["Q1"].Value = "Doanh thu dự kiến " + year.ToString();
            header.Range["R1"].Value = "%";
            header.Range["S1"].Value = "Doanh thu";
            header.Range["T1"].Value = "%";
            header.Range["U1"].Value = "Doanh thu";
            header.Range["V1"].Value = "Tổng doanh thu 5 năm liền kề";
            header.Range["W1"].Value = "T1";
            header.Range["X1"].Value = "T2";
            header.Range["Y1"].Value = "T3";
            header.Range["Z1"].Value = "T4";
            header.Range["AA1"].Value = "T5";
            header.Range["AB1"].Value = "T6";
            header.Range["AC1"].Value = "T7";
            header.Range["AD1"].Value = "T8";
            header.Range["AE1"].Value = "T9";
            header.Range["AF1"].Value = "T10";
            header.Range["AG1"].Value = "T11";
            header.Range["AH1"].Value = "T12";
            header.Range["AI1"].Value = "T1";
            header.Range["AJ1"].Value = "T2";
            header.Range["AK1"].Value = "T3";
            header.Range["AL1"].Value = "T4";
            header.Range["AM1"].Value = "T5";
            header.Range["AN1"].Value = "T6";
            header.Range["AO1"].Value = "T7";
            header.Range["AP1"].Value = "T8";
            header.Range["AQ1"].Value = "T9";
            header.Range["AR1"].Value = "T10";
            header.Range["AS1"].Value = "T11";
            header.Range["AT1"].Value = "T12";
            header.Range["AU1"].Value = string.Format("Tổng doanh thu thực tế đến {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            header.Range["AV1"].Value = "Đạt được so với thực tế";
            header.Range["AW1"].Value = "Ghi chú";

            worksheet.Range["A:A"].EntireColumn.NumberFormat = "0";
            worksheet.Range["B:B"].EntireColumn.NumberFormat = "@";
            worksheet.Range["C:C"].EntireColumn.NumberFormat = "@";
            worksheet.Range["D:D"].EntireColumn.NumberFormat = "@";
            worksheet.Range["E:E"].EntireColumn.NumberFormat = "@";
            worksheet.Range["F:F"].EntireColumn.NumberFormat = "@";
            worksheet.Range["G:G"].EntireColumn.NumberFormat = "@";
            worksheet.Range["H:H"].EntireColumn.NumberFormat = "@";
            worksheet.Range["I:I"].EntireColumn.NumberFormat = "@";
            worksheet.Range["J:J"].EntireColumn.NumberFormat = "@";
            worksheet.Range["K:K"].EntireColumn.NumberFormat = "@";
            worksheet.Range["L:L"].EntireColumn.NumberFormat = "@";
            worksheet.Range["M:M"].EntireColumn.NumberFormat = "@";
            worksheet.Range["N:N"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["O:O"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["P:P"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["Q:Q"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["R:R"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["S:S"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["T:T"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["U:U"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["V:V"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["W:W"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["X:X"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["Y:Y"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["Z:Z"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AA:AA"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AB:AB"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AC:AC"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AD:AD"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AE:AE"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AF:AF"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AG:AG"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AH:AH"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AI:AI"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AJ:AJ"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AK:AK"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AL:AL"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AM:AM"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AN:AN"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AO:AO"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AP:AP"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AQ:AQ"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AR:AR"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AS:AS"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AT:AT"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AU:AU"].EntireColumn.NumberFormat = "#,###";
            worksheet.Range["AV:AV"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["AW:AW"].EntireColumn.NumberFormat = "@";
            background.ReportProgress(8);
            int index = 5;
            int totalItem = rp.Count() + 5;
            int process = 0;
            rp.ForEach(o =>
            {
                worksheet.Range[$"A{index}"].Value = index - 4;
                worksheet.Range[$"B{index}"].Value = o.ARCustomerNo;
                worksheet.Range[$"C{index}"].Value = o.ARCustomerName;
                worksheet.Range[$"D{index}"].Value = o.ARCustomerDeliveryAddressLine1;
                worksheet.Range[$"E{index}"].Value = o.StateProvince == null ? "" : o.StateProvince;
                worksheet.Range[$"F{index}"].Value = o.LocalArea == null ? "" : o.LocalArea;
                worksheet.Range[$"G{index}"].Value = o.ARCustomerTypeName;
                worksheet.Range[$"H{index}"].Value = o.ProductGroupAbbreviation;
                worksheet.Range[$"I{index}"].Value = o.ARCustomerContactName;
                worksheet.Range[$"J{index}"].Value = o.ARCustomerContactPhone;
                worksheet.Range[$"K{index}"].Value = o.ARCustomerContactEmail1;
                worksheet.Range[$"L{index}"].Value = o.ARCustomerDesc;
                worksheet.Range[$"M{index}"].Value = o.HREmployeeName;
                worksheet.Range[$"N{index}"].Value = o.DoanhThuLienKeNam1;
                worksheet.Range[$"O{index}"].Value = o.DoanhThuLienKeNam2;
                worksheet.Range[$"P{index}"].Value = o.DoanhThuLienKeNam3;
                worksheet.Range[$"Q{index}"].Value = o.ARRevenueForecastItemPredictAmount;
                worksheet.Range[$"R{index}"].Value = o.ARRevenueForecastItemPredictSalePercent;
                worksheet.Range[$"S{index}"].Value = o.ARRevenueForecastItemPredictSaleAmount;
                worksheet.Range[$"T{index}"].Value = o.ARRevenueForecastItemPredictAcceptPercent;
                worksheet.Range[$"U{index}"].Value = o.ARRevenueForecastItemPredictAcceptAmount;
                worksheet.Range[$"W{index}"].Value = o.DoanhThuThang1;
                worksheet.Range[$"X{index}"].Value = o.DoanhThuThang2;
                worksheet.Range[$"Y{index}"].Value = o.DoanhThuThang3;
                worksheet.Range[$"Z{index}"].Value = o.DoanhThuThang4;
                worksheet.Range[$"AA{index}"].Value = o.DoanhThuThang5;
                worksheet.Range[$"AB{index}"].Value = o.DoanhThuThang6;
                worksheet.Range[$"AC{index}"].Value = o.DoanhThuThang7;
                worksheet.Range[$"AD{index}"].Value = o.DoanhThuThang8;
                worksheet.Range[$"AE{index}"].Value = o.DoanhThuThang9;
                worksheet.Range[$"AF{index}"].Value = o.DoanhThuThang10;
                worksheet.Range[$"AG{index}"].Value = o.DoanhThuThang11;
                worksheet.Range[$"AH{index}"].Value = o.DoanhThuThang12;
                worksheet.Range[$"AI{index}"].Value = o.DoanhThuThucTeThang1;
                worksheet.Range[$"AJ{index}"].Value = o.DoanhThuThucTeThang2;
                worksheet.Range[$"AK{index}"].Value = o.DoanhThuThucTeThang3;
                worksheet.Range[$"AL{index}"].Value = o.DoanhThuThucTeThang4;
                worksheet.Range[$"AM{index}"].Value = o.DoanhThuThucTeThang5;
                worksheet.Range[$"AN{index}"].Value = o.DoanhThuThucTeThang6;
                worksheet.Range[$"AO{index}"].Value = o.DoanhThuThucTeThang7;
                worksheet.Range[$"AP{index}"].Value = o.DoanhThuThucTeThang8;
                worksheet.Range[$"AQ{index}"].Value = o.DoanhThuThucTeThang9;
                worksheet.Range[$"AR{index}"].Value = o.DoanhThuThucTeThang10;
                worksheet.Range[$"AS{index}"].Value = o.DoanhThuThucTeThang11;
                worksheet.Range[$"AT{index}"].Value = o.DoanhThuThucTeThang12;
                worksheet.Range[$"AU{index}"].Value = o.DoanhThuThucTe;
                worksheet.Range[$"AV{index}"].Value = o.TyLeDatDuoc;
                worksheet.Range[$"AW{index}"].Value = o.Comment;
                index++;
                process = 8 + 100 * index / totalItem;
                if (process >= 100)
                    process = 99;
                background.ReportProgress(process);
            });
            var usedRange = worksheet.get_Range($"A4", $"AW{index - 1}");
            usedRange.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Color = Color.Black;

            worksheet.get_Range("A4", "AW4").EntireColumn.AutoFit();
            workbook.SaveAs(FilePath);
            workbook.Close(true, misValue, misValue);
            xlApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(xlApp);
            background.ReportProgress(100);

            if (File.Exists(FilePath))
            {
                Process.Start(FilePath);
            }
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void ExportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
        private void fld_ceMergeWatch_CheckedChanged(object sender, EventArgs e)
        {
            ShowData(false);
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ShowData(true);
        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeRoundingNumber_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            DataTable dt = (DataTable)fld_dgcARInvoices.DataSource;
            if (dt != null)
            {
                OldRoundingNumber = RoundingNumber;
                decimal roundingNumber = 1;
                if (e.Value != null)
                {
                    decimal.TryParse(e.Value.ToString(), out roundingNumber);
                    RoundingNumber = roundingNumber;
                }
                UpdateRoundingNumber(dt);
            }
        }
        public void UpdateRoundingNumber(DataTable dt)
        {
            int year = 0;
            int customerID = 0;
            string customerType = string.Empty;
            int employeeID = 0;
            bool isCheckDiscount = false;
            int.TryParse(fld_tbYear.EditValue.ToString(), out year);
            if (fld_lkeARCustomerID.EditValue != null)
            {
                int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customerID);
            }
            //if (customerID == 0)
            //{
            //    MessageBox.Show("Đối tượng đang để trống, vui lòng chọn đối tượng!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (fld_lkeHREmployeeID.EditValue != null)
            {
                int.TryParse(fld_lkeHREmployeeID.EditValue.ToString(), out employeeID);
            }
            if (fld_lkeARCustomerType.EditValue != null)
            {
                customerType = fld_lkeARCustomerType.EditValue.ToString();
            }
            if (fld_ckeIsDiscount.Checked != null)
                isCheckDiscount = fld_ckeIsDiscount.Checked;
            DateTime fromMonth = new DateTime(year, 1, 1);
            DateTime toMonth = year == DateTime.Now.Year ? DateTime.Now : new DateTime(year, 12, 31);
            ADReportsController reportController = new ADReportsController();
            List<ADReportsInfo> reportData = reportController.GetRevenueByCustomer_1(fromMonth, toMonth, customerID, customerType, employeeID, isCheckDiscount);    
            dt.Clear();
            FillDataTable(reportData, dt, year);
            fld_dgcARInvoices.DataSource = dt;
            BandedGridView view = (BandedGridView)fld_dgcARInvoices.MainView;

            view.BestFitColumns();
        }
    }

}
