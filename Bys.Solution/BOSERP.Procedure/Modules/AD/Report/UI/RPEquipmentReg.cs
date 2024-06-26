using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RPEquipmentReg : ReportForm
    {
        #region Variables

        public int BatchProduct { get; set; }
        public int EquipmentProductID { get; set; }
        public DateTime _FromDate { get; set; }
        public DateTime _ToDate { get; set; }

        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RPEquipmentReg()
        {
            InitializeComponent();
            _FromDate = DateTime.Now;
            _ToDate = DateTime.Now;
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = _FromDate;
            fld_dteSearchToDate.DateTime = new DateTime(_FromDate.Year, _FromDate.Month, _FromDate.Day).AddDays(7);
            if (_ToDate.Date != DateTime.Now.Date)
                fld_dteSearchToDate.DateTime = _ToDate;
            if (BatchProduct > 0 || EquipmentProductID > 0)
            {
                fld_lkeMMBatchProductID.EditValue = BatchProduct;
                fld_lkeICEquipmentProductID.EditValue = EquipmentProductID;
                fld_dteSearchFromDate.DateTime = _FromDate;
                fld_dteSearchToDate.DateTime = _ToDate;
            }
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        private GridBand CreateNewGridBand(string name, string header)
        {
            GridBand gridBand1 = new GridBand();
            gridBand1.Caption = header;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand1.Name = name;
            return gridBand1;
        }

        private BandedGridColumn CreateNewColumnNoneBand(string name, string header)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = false;
            return bandedColumn;
        }

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
        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("FK_ICEquipmentID", typeof(int)));
            dt.Columns.Add(new DataColumn("ICProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ICProductName", typeof(string)));
            dt.Columns.Add(new DataColumn("MMDetailPlanEquipmentInventoryStockQty", typeof(decimal)));

            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            if (toDate.Date >= fromDate.Date)
            {
                int numDays = (int)(toDate.Date - fromDate.Date).TotalDays + 1;
                for (int i = 0; i < numDays; i++)
                {
                    string strDate = fromDate.AddDays(i).ToString("ddMMyy");
                    dt.Columns.Add(new DataColumn("Available_" + strDate, typeof(decimal)));
                    //dt.Columns.Add(new DataColumn("Allowcate_" + strDate, typeof(decimal)));
                    dt.Columns.Add(new DataColumn("Planed_" + strDate, typeof(decimal)));
                }
            }
            return dt;
        }
        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();
            //  bandedView.GridControl = fld_dgcSynchronousData;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnProductNo = CreateNewColumn("ICProductNo", "Mã khuôn", gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("ICProductName", "Tên", gridBand);
            BandedGridColumn gridColumnStockQty = CreateNewColumn("MMDetailPlanEquipmentInventoryStockQty", "SL có", gridBand);

            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);
            bandedView.Columns.Add(gridColumnStockQty);
            gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 200;



            DateTime fromDate = _FromDate;
            DateTime toDate = _ToDate;
            if (toDate.Date >= fromDate.Date)
            {
                int numDays = (int)(toDate.Date - fromDate.Date).TotalDays + 1;
                for (int i = 0; i < numDays; i++)
                {

                    string strDate = fromDate.AddDays(i).ToString("ddMMyy");
                    GridBand band = CreateNewGridBand(fromDate.AddDays(i).ToString("ddMMyy"), fromDate.AddDays(i).ToString("dd/MM/yyyy"));
                    bandedView.Bands.Add(band);

                    BandedGridColumn Available_ = CreateNewColumn("Available_" + strDate, "SL rảnh", band);
                    Available_.DisplayFormat.FormatType = FormatType.Numeric;
                    Available_.DisplayFormat.FormatString = "{0:####}";

                    string caption = "Đã kế hoạch";
                    if (fromDate.AddDays(i).Date < DateTime.Now.Date)
                        caption = "SL đã cấp phát";
                    BandedGridColumn Planed_ = CreateNewColumn("Planed_" + strDate, caption, band);
                    Planed_.DisplayFormat.FormatType = FormatType.Numeric;
                    Planed_.DisplayFormat.FormatString = "{0:####}";
                    bandedView.Columns.Add(Available_);
                    //bandedView.Columns.Add(Allowcate_);
                    bandedView.Columns.Add(Planed_);
                }
            }
            return bandedView;
        }

        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int BatchProductID = 0;
            int ProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            if (fld_lkeICEquipmentProductID.EditValue != null)
                int.TryParse(fld_lkeICEquipmentProductID.EditValue.ToString(), out ProductID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            MMDetailPlanEquipmentsController odpEController = new MMDetailPlanEquipmentsController();
            List<MMDetailPlanEquipmentsInfo> resultData = odpEController.GetRegistrationEquipmentData(BatchProductID, ProductID, FromDate, ToDate);
            DataTable dt = InitDataTable();
            FillDataTable(dt, resultData);

            fld_dgcSynchronousData.DataSource = dt;
            GridView gridView = (GridView)fld_dgcSynchronousData.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

            BOSProgressBar.Close();
        }
        private void FillDataTable(DataTable dt, List<MMDetailPlanEquipmentsInfo> odpicList)
        {
            List<int> Equipments = new List<int>();
            Equipments = odpicList.Select(o => o.FK_ICEquipmentID).Distinct().ToList();
            List<MMDetailPlanEquipmentsInfo> itemList;
            foreach (int matchKey in Equipments)
            {
                DataRow newRow = dt.NewRow();
                itemList = odpicList.Where(i => i.FK_ICEquipmentID == matchKey).ToList();
                if (itemList != null && itemList.Count > 0)
                {
                    newRow["FK_ICEquipmentID"] = itemList[0].FK_ICEquipmentID;
                    newRow["ICProductNo"] = itemList[0].ICProductNo;
                    newRow["ICProductName"] = itemList[0].ICProductName;
                    newRow["MMDetailPlanEquipmentInventoryStockQty"] = itemList[0].MMDetailPlanEquipmentInventoryStockQty;

                    DateTime fromDate = _FromDate;
                    DateTime startDate = _FromDate;
                    DateTime toDate = _ToDate;
                    if (toDate.Date >= fromDate.Date)
                    {
                        int numDays = (int)(toDate.Date - fromDate.Date).TotalDays + 1;
                        for (int i = 0; i < numDays; i++)
                        {
                            startDate = fromDate.AddDays(i);
                            string strDate = startDate.ToString("ddMMyy");
                            List<MMDetailPlanEquipmentsInfo> detailResult = itemList.Where(o => startDate.Date >= o.MMDetailPlanEquipmentFromDate.Date && startDate.Date <= o.MMDetailPlanEquipmentToDate.Date).ToList();
                            if (detailResult != null && detailResult.Count > 0)
                            {
                                decimal Allowcate = detailResult.Sum(o => o.AlowcatedQty);
                                decimal Planed = detailResult.Sum(o => o.PlanedQty);
                                decimal Available = itemList[0].MMDetailPlanEquipmentInventoryStockQty - Allowcate - Planed;
                                if (Available > 0)
                                    newRow["Available_" + strDate] = Available;

                                //if (Allowcate > 0)
                                //    newRow["Allowcate_" + strDate] = Allowcate;

                                if (Planed > 0)
                                    newRow["Planed_" + strDate] = Planed;
                            }
                            else
                            {
                                decimal Available = itemList[0].MMDetailPlanEquipmentInventoryStockQty;
                                newRow["Available_" + strDate] = Available;
                            }
                        }
                    }
                }
                dt.Rows.Add(newRow);
            }
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
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

                    fld_dgcSynchronousData.ExportToXlsx(fileName);
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

        #region Initialize export excel parameter
        //protected override List<ExportExcelParameter> GetReportHeader()
        //{
        //    //List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
        //    //lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 4));
        //    //return lstHeaderParameter;
        //}
        #endregion

        private void Fld_btnFind_Click(object sender, EventArgs e)
        {
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            bool isReInit = false;
            if (_FromDate.Date != FromDate.Date) { _FromDate = FromDate; isReInit = true; }
            if (_ToDate.Date != ToDate.Date) { _ToDate = ToDate; isReInit = true; }
            if (isReInit)
            {
                BandedGridView bandedView = fld_dgcSynchronousData.InitializeBandedGridView(fld_dgcSynchronousData.MainView as GridView);
                fld_dgcSynchronousData.MainView = bandedView;
            }
            ShowReportData();
        }
    }

}