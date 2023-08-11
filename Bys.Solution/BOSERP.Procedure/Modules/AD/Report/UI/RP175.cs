using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.Report
{
    public partial class RP175 : ReportForm
    {
        string dateType = "Date";
        public RP175()
        {
            InitializeComponent();
        }

        private void RP175_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteSearchFromMonth.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchFromYear.DateTime = BOSUtil.GetYearBeginDate();
            fld_lkeHRLabouringConfigDateType.EditValue = "Date";
            fld_pnlMonth.Visible = false;
            fld_pnlYear.Visible = false;
            GridView bandView = (GridView)fld_dgcRP175LabourProductivity.MainView;
            fld_dgcRP175LabourProductivity.MainView = InitializeCustomerBandedGridView(bandView);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
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

                    fld_dgcRP175LabourProductivity.ExportToXlsx(fileName);
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
        public GridBand CreateGridBand(string caption, List<GridBand> GridBandList)
        {
            GridBand gridBand = new GridBand();
            gridBand.Caption = caption;
            gridBand.Name = "";
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            return gridBand;
        }

        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView, bool isgroup)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;

            bandedLocation.MinWidth = 100;
            if (isgroup)
                bandedLocation.Group();
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
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            bandedLocation.DisplayFormat.FormatString = "{0:n4}";
            bandedLocation.MinWidth = 50;
            bandedView.Columns.Add(bandedLocation);


            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n4}";
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
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }
        public void CreateBandedNumbericN2AverageSumGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
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
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }
        public void CreateBandedNotSumNumbericN2GridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
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
            bandedLocation.MinWidth = 100;
            bandedLocation.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            bandedView.Columns.Add(bandedLocation);
        }

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView)
        {
            MMOperationsController operationController = new MMOperationsController();
            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;

            List<GridBand> GridBandList = new List<GridBand>();
            //1. Date
            GridBand itemGridBandSelected = CreateGridBand("", GridBandList);
            itemGridBandSelected.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedGridColumn("ICReceiptDate", "Ngày", itemGridBandSelected, bandedView, false);
            //2.Sản lượng
            GridBand itemGridBandSL = CreateGridBand("SẢN LƯỢNG", GridBandList);
            itemGridBandSL.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandSL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySL", "Sản lượng(USD)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivityNS", "Năng suất(USD)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2GridColumn("ICReceiptLabourProductivitySLDG", "Sản lượng ĐG(USD)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2GridColumn("HRLabouringConfigItemQty", "Công nhật(Ngày)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2GridColumn("HRLabouringConfigItemOverTimeQty", "Công tăng ca(Ngày)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2GridColumn("HRLabouringConfigItemTotalQty", "Tổng công(Ngày)", itemGridBandSL, bandedView);
            CreateBandedNumbericN2AverageSumGridColumn("HRLabouringConfigItemOverTimeRate", "Hệ số tăng ca", itemGridBandSL, bandedView);
            //3.Lũy kế
            GridBand itemGridBandlk = CreateGridBand("LŨY KẾ", GridBandList);
            itemGridBandlk.AppearanceHeader.Options.UseTextOptions = true;
            itemGridBandlk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CreateBandedNotSumNumbericN2GridColumn("ICReceiptLabourProductivitySLLK", "Sản lượng lũy kế(USD)", itemGridBandlk, bandedView);
            CreateBandedNotSumNumbericN2GridColumn("ICReceiptLabourProductivityNSLK", "Năng suất lũy kế(USD)", itemGridBandlk, bandedView);

            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.BestFitColumns();
            return bandedView;
        }


        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ICReceiptDate", typeof(string)));
            dt.Columns.Add(new DataColumn("ICReceiptLabourProductivitySL", typeof(string)));
            dt.Columns.Add(new DataColumn("ICReceiptLabourProductivityNS", typeof(string)));
            dt.Columns.Add(new DataColumn("ICReceiptLabourProductivitySLDG", typeof(string)));
            dt.Columns.Add(new DataColumn("HRLabouringConfigItemQty", typeof(string)));
            dt.Columns.Add(new DataColumn("HRLabouringConfigItemOverTimeQty", typeof(string)));
            dt.Columns.Add(new DataColumn("HRLabouringConfigItemTotalQty", typeof(string)));
            dt.Columns.Add(new DataColumn("HRLabouringConfigItemOverTimeRate", typeof(string)));
            dt.Columns.Add(new DataColumn("ICReceiptLabourProductivitySLLK", typeof(string)));
            dt.Columns.Add(new DataColumn("ICReceiptLabourProductivityNSLK", typeof(string)));

            return dt;
        }

        //private void FillDataTable(DataTable dt, List<int> distinctList, List<MMProductionPlanItemsInfo> dataList)
        //{
        //    MMOperationsController operationController = new MMOperationsController();
        //    List<MMOperationsInfo> operationList = operationController.GetAllOperationsByOperationGroup("Material");

        //    MMProductionPlanItemsInfo matchItem;
        //    foreach (int itemID in distinctList)
        //    {

        //        matchItem = dataList.FirstOrDefault(t => t.FK_ARSaleOrderID == itemID);
        //        if (matchItem != null)
        //        {
        //            DataRow newRow = dt.NewRow();
        //            newRow["ARSaleOrderNo"] = matchItem.ARSaleOrderNo;
        //            newRow["ARSaleOrderDeliveryDate"] = matchItem.ARSaleOrderDeliveryDate.ToString("dd/MM/yyyy");
        //            newRow["MMBatchProductNo"] = matchItem.MMBatchProductNo;
        //            //newRow["MMProductionPlanNo"] = matchItem.MMProductionPlanNo;
        //            newRow["ARSaleOrderInputTotalQty"] = matchItem.ARSaleOrderInputTotalQty > 0 ? matchItem.ARSaleOrderInputTotalQty.ToString("N4") : "0";
        //            newRow["ARSaleOrderOutputTotalQty"] = matchItem.ARSaleOrderInputTotalQty > 0 ? matchItem.ARSaleOrderOutputTotalQty.ToString("N4") : "0";
        //            newRow["ARSaleOrderReceiptTotalQty"] = matchItem.ARSaleOrderInputTotalQty > 0 ? matchItem.ARSaleOrderReceiptTotalQty.ToString("N4") : "0";

        //            foreach (MMOperationsInfo operation in operationList)
        //            {
        //                double MMProductionPlanItemProductQty = 0;
        //                double MMProductionPlanItemOutProductQty = 0;
        //                double MMProductPlanShipmenProductQty = 0;
        //                double MMProductPlanReceiptProductQty = 0;
        //                double MMProductPlanPercentComplete = 0;
        //                double MMProductPlanConsumptionRate = 0;
        //                double ARSaleOrderShipmenProductQty = 0;

        //                for (int i = 0; i < dataList.Count; i++)
        //                {
        //                    matchItem = dataList[i];
        //                    if (matchItem.FK_ARSaleOrderID == itemID
        //                        && matchItem.FK_MMOperationID == operation.MMOperationID)
        //                    {
        //                        MMProductionPlanItemProductQty += matchItem.MMProductionPlanItemProductQty;
        //                        MMProductionPlanItemOutProductQty += matchItem.MMProductionPlanItemOutProductQty;
        //                        MMProductPlanShipmenProductQty += (matchItem.MMProductPlanShipmenProductQty);
        //                        MMProductPlanReceiptProductQty += (matchItem.MMProductPlanShipmenProductQty);
        //                        MMProductPlanPercentComplete += (matchItem.MMProductPlanShipmenProductQty);
        //                        MMProductPlanConsumptionRate += (matchItem.MMProductPlanShipmenProductQty);
        //                        ARSaleOrderShipmenProductQty += (matchItem.MMProductPlanShipmenProductQty);

        //                        dataList.RemoveAt(i--);
        //                    }
        //                }
        //                if (MMProductionPlanItemProductQty > 0)
        //                    MMProductPlanPercentComplete = MMProductPlanReceiptProductQty / MMProductionPlanItemProductQty * 100;
        //                if (MMProductPlanShipmenProductQty > 0)
        //                    MMProductPlanConsumptionRate = (MMProductPlanReceiptProductQty / MMProductPlanShipmenProductQty);

        //                newRow["MMProductionPlanItemProductQty_" + operation.MMOperationID] = MMProductionPlanItemProductQty > 0 ? MMProductionPlanItemProductQty.ToString("N4") : "";
        //                newRow["MMProductionPlanItemOutProductQty_" + operation.MMOperationID] = MMProductionPlanItemOutProductQty > 0 ? MMProductionPlanItemOutProductQty.ToString("N4") : "";
        //                newRow["MMProductPlanShipmenProductQty_" + operation.MMOperationID] = MMProductPlanShipmenProductQty > 0 ? MMProductPlanShipmenProductQty.ToString("N4") : "";
        //                newRow["MMProductPlanReceiptProductQty_" + operation.MMOperationID] = MMProductPlanReceiptProductQty > 0 ? MMProductPlanReceiptProductQty.ToString("N4") : "";
        //                newRow["MMProductPlanPercentComplete_" + operation.MMOperationID] = MMProductPlanPercentComplete > 0 ? MMProductPlanPercentComplete.ToString("0") + "%" : "";
        //                newRow["MMProductPlanConsumptionRate_" + operation.MMOperationID] = MMProductPlanConsumptionRate > 0 ? MMProductPlanConsumptionRate.ToString("N2") : "";
        //                newRow["ARSaleOrderShipmenProductQty_" + operation.MMOperationID] = ARSaleOrderShipmenProductQty > 0 ? ARSaleOrderShipmenProductQty.ToString("N4") : "";

        //            }
        //            dt.Rows.Add(newRow);
        //        }
        //    }

        //}

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        private void ShowReportData()
        {
            BOSProgressBar.Start("Đang tải dữ liệu...");

            int departmentID = 0;
            if (fld_lkeHRDepartmentID.EditValue != null)
            {
                int.TryParse(fld_lkeHRDepartmentID.EditValue.ToString(), out departmentID);
            }
            int departmentRoomID = 0;

            int departmentRoomGroupItemID = 0;
            string viewType = string.Empty;
            if (fld_lkeHRLabouringConfigDateType.EditValue != null)
            {
                viewType = fld_lkeHRLabouringConfigDateType.EditValue.ToString();
            }

            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            if (dateType == "Date")
            {
                fromDate = fld_dteSearchFromDate.DateTime;
                toDate = fld_dteSearchToDate.DateTime;
            }
            else if (dateType == "Month")
            {
                fromDate = new DateTime(fld_dteSearchFromMonth.DateTime.Year, fld_dteSearchFromMonth.DateTime.Month, 1);
                toDate = BOSUtil.GetMonthEndDate(fromDate);
            }
            else if (dateType == "Year")
            {
                fromDate = new DateTime(fld_dteSearchFromYear.DateTime.Year, 1, 1);
                toDate = BOSUtil.GetYearEndDate(fromDate);
            }



            ADReportsController ReportsController = new ADReportsController();
            DataTable dt = InitDataTable();
            dt = ReportsController.GetDataForReportLabourProductivity(viewType, departmentID, departmentRoomID, departmentRoomGroupItemID, fromDate, toDate);

            fld_dgcRP175LabourProductivity.DataSource = dt;

            GridView bandViewAfterInit = (GridView)fld_dgcRP175LabourProductivity.MainView;
            BOSProgressBar.Close();
        }
        private void fld_lkeHRLabouringConfigDateType_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeHRLabouringConfigDateType.EditValue != null && fld_lkeHRLabouringConfigDateType.EditValue.ToString() != string.Empty)
            {
                if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Date")
                {
                    fld_pnlDate.Visible = true;
                    fld_pnlMonth.Visible = false;
                    fld_pnlYear.Visible = false;
                    dateType = "Date";
                }
                else if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Month")
                {
                    fld_pnlDate.Visible = false;
                    fld_pnlMonth.Visible = true;
                    fld_pnlYear.Visible = false;
                    dateType = "Month";
                }
                else if (fld_lkeHRLabouringConfigDateType.EditValue.ToString() == "Year")
                {
                    fld_pnlDate.Visible = false;
                    fld_pnlMonth.Visible = false;
                    fld_pnlYear.Visible = true;
                    dateType = "Year";
                }
            }
        }

    }
}
