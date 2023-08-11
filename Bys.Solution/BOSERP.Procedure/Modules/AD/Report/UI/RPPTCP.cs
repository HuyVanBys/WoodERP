using BOSCommon;
using BOSLib;
using BOSReport;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RPPTCP : ReportForm
    {



        public RPPTCP()
        {
            InitializeComponent();
        }
        public string PublicLotNo = string.Empty;
        public double PublicExchangeRate = 0;
        private void RPPTCP_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromMonth.DateTime = DateTime.Now;
            fld_dteToMonth.DateTime = DateTime.Now;
        }


        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, List<string> distinctMonth, DateTime fromMonth, DateTime toMonth)
        {



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




            GridBand sttBand = CreateGridBand("BÁO CÁO PHÂN TÍCH CHI PHÍ (" + fromMonth.ToString("MM/yyyy") + " - " + toMonth.ToString("MM/yyyy") + ")", GridBandList);
            CreateBandedGridColumn("STT", "STT", sttBand, bandedView, 50);
            CreateBandedGridColumn("SegmentNo", "Mã chi phí", sttBand, bandedView, 50);
            CreateBandedGridColumn("SegmentName", "Tên chi phí", sttBand, bandedView, 50);
            CreateBandedGridColumn("SegmentType", "Nhóm chi phí", sttBand, bandedView, 50);
            CreateBandedGridColumn("DebitAccountNo", "Tài khoản nợ", sttBand, bandedView, 50);
            CreateBandedGridColumn("CostCenterName", "TTCP", sttBand, bandedView, 50);
            CreateBandedGridColumn("DeparmentName", "Phòng ban", sttBand, bandedView, 50);

            DateTime compareDate = new DateTime(fromMonth.Year, fromMonth.Month, 1);
            DateTime endDate = new DateTime(toMonth.Year, toMonth.Month, 1);
            while ((endDate - compareDate).Days >= 0)
            {
                CreateBandedNumbericN0GridColumn(compareDate.ToString("yyyyMM"), compareDate.ToString("MM/yyyy"), sttBand, bandedView);
                compareDate = compareDate.AddMonths(1);
            }
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

            BandedGridView view = (BandedGridView)fld_dgcARNormFeeConfigItems.MainView;
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
            bandedLocation.OptionsColumn.ShowCaption = false;
            bandedLocation.OptionsColumn.AllowMerge = DefaultBoolean.False;
            bandedLocation.MinWidth = 40;
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
                                    , DataTable dt
            )
        {
            List<ADReportsInfo> filterList = new List<ADReportsInfo>();
            List<string> distinctList = dataList.Select(t => t.SegmentNo
                                                        + "_" + t.SegmentName
                                                        + "_" + t.SegmentType
                                                        + "_" + t.DebitAccountNo
                                                        + "_" + t.CostCenterName
                                                        + "_" + t.DeparmentName).Distinct().ToList();
            int count = 0;
            foreach (string key in distinctList)
            {

                filterList = dataList.Where(t => (t.SegmentNo
                                                        + "_" + t.SegmentName
                                                        + "_" + t.SegmentType
                                                        + "_" + t.DebitAccountNo
                                                        + "_" + t.CostCenterName
                                                        + "_" + t.DeparmentName) == key).ToList();
                DataRow dr = dt.NewRow();
                dr["STT"] = (++count).ToString();
                dr["SegmentNo"] = filterList[0].SegmentNo;
                dr["SegmentName"] = filterList[0].SegmentName;
                dr["SegmentType"] = filterList[0].SegmentType;
                dr["DebitAccountNo"] = filterList[0].DebitAccountNo;
                dr["CostCenterName"] = filterList[0].CostCenterName;
                dr["DeparmentName"] = filterList[0].DeparmentName;

                foreach (ADReportsInfo data in filterList)
                {
                    if (dt.Columns[data.GetMonthStr] != null)
                    {
                        dr[data.GetMonthStr] = data.Volume;
                    }
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
            dataTable.Columns.Add("SegmentNo", typeof(String));
            dataTable.Columns.Add("SegmentName", typeof(String));
            dataTable.Columns.Add("SegmentType", typeof(String));
            dataTable.Columns.Add("DebitAccountNo", typeof(String));
            dataTable.Columns.Add("CostCenterName", typeof(String));
            dataTable.Columns.Add("DeparmentName", typeof(String));

            foreach (string monthStr in distinctMonth)
            {
                dataTable.Columns.Add(monthStr, typeof(Double));
            }



            return dataTable;
        }


        public void ShowData(bool isPrint)
        {
            BOSProgressBar.Start("Đang xử lý báo cáo");
            DateTime fromMonth = fld_dteFromMonth.DateTime;
            DateTime toMonth = fld_dteToMonth.DateTime;
            int segmentID = 0;
            if (fld_lkeACSegmentID.EditValue != null)
            {
                int.TryParse(fld_lkeACSegmentID.EditValue.ToString(), out segmentID);
            }

            string costType = string.Empty;
            if (fld_lkeACCostType.EditValue != null)
            {
                costType = fld_lkeACCostType.EditValue.ToString();
            }

            int debitAccountID = 0;
            if (fld_lkeACAccountID.EditValue != null)
            {
                int.TryParse(fld_lkeACAccountID.EditValue.ToString(), out debitAccountID);
            }

            int costCenterID = 0;
            if (fld_lkeACCostCenterID.EditValue != null)
            {
                int.TryParse(fld_lkeACCostCenterID.EditValue.ToString(), out costCenterID);
            }

            int departmentID = 0;
            if (fld_lkeHRDepartmentID.EditValue != null)
            {
                int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentID);
            }

            ADReportsController reportController = new ADReportsController();
            List<ADReportsInfo> reportData = reportController.GetValueForCostBugdetReport(segmentID, costType, debitAccountID, costCenterID, departmentID, fromMonth, toMonth);


            List<string> distinctMonth = reportData.Select(t => t.GetMonthStr).Distinct().ToList().OrderBy(t => t).ToList();

            DataTable dt = CreateDataTable(reportData, distinctMonth);
            FillDataTable(reportData, dt);
            GridView gridView = (GridView)fld_dgcARNormFeeConfigItems.MainView;
            fld_dgcARNormFeeConfigItems.MainView = InitializeCustomerBandedGridView(gridView, distinctMonth, fromMonth, toMonth);

            fld_dgcARNormFeeConfigItems.DataSource = dt;

            BandedGridView view = (BandedGridView)fld_dgcARNormFeeConfigItems.MainView;

            view.BestFitColumns();


            if (isPrint)
            {
                string xrDate = "( Từ tháng " + fromMonth.ToString("MM/yyyy") + " đến tháng " + toMonth.ToString("MM/yyyy") + " )";

                RPPTCP_Print report = new RPPTCP_Print(view, xrDate);
                guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevSaleOrderItemReportViewerPath, true);
                reviewer.Show();
            }

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
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    fld_dgcARNormFeeConfigItems.ExportToXlsx(fileName);
                }
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

        private void fld_ceMergeWatch_CheckedChanged(object sender, EventArgs e)
        {
            ShowData(false);
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ShowData(true);
        }


    }

}
