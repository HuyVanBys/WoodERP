using BOSLib;
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
    public partial class RP201 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP201()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();


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
            // bandedColumn.OwnerBand = owner;
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

            dt.Columns.Add(new DataColumn("BatchProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("BatchProductSerialNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ProductForBatchNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ProductForBatchName", typeof(string)));
            dt.Columns.Add(new DataColumn("SaleOrderNo", typeof(string)));
            dt.Columns.Add(new DataColumn("BatchProductItemQty", typeof(string)));
            dt.Columns.Add(new DataColumn("DeliveryDate", typeof(string)));


            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();


            foreach (MMOperationsInfo operation in operationList)
            {
                dt.Columns.Add(new DataColumn("ReceiptQty_" + operation.MMOperationID, typeof(string)));
                dt.Columns.Add(new DataColumn("SynchronousPercent_" + operation.MMOperationID, typeof(string)));
            }

            return dt;
        }

        private void FillDataTable(DataTable dt, List<MMBatchProductProductionNormItemsInfo> bppnItemList)
        {
            List<int> batchProductItemIDs = new List<int>();

            foreach (MMBatchProductProductionNormItemsInfo item in bppnItemList)
            {
                if (!batchProductItemIDs.Contains(item.FK_MMBatchProductItemID))
                {
                    batchProductItemIDs.Add(item.FK_MMBatchProductItemID);
                }
            }

            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            List<MMBatchProductProductionNormItemsInfo> itemList;
            foreach (int batchProductItemID in batchProductItemIDs)
            {
                DataRow newRow = dt.NewRow();

                MMBatchProductProductionNormItemsInfo item = bppnItemList.FirstOrDefault(i => i.FK_MMBatchProductItemID == batchProductItemID);



                newRow["BatchProductNo"] = item.MMBatchProductNo;
                newRow["BatchProductSerialNo"] = item.MMBatchProductItemProductSerial;
                newRow["ProductForBatchNo"] = item.ProductForBatchNo;
                newRow["ProductForBatchName"] = item.ProductForBatchName;
                newRow["SaleOrderNo"] = item.ARSaleOrderNo;
                newRow["BatchProductItemQty"] = item.MMBatchProductItemProductQty;
                newRow["DeliveryDate"] = item.MMBatchProductItemDeliveryDate.ToString("dd/MM/yyyy");




                foreach (MMOperationsInfo operation in operationList)
                {
                    itemList = new List<MMBatchProductProductionNormItemsInfo>();
                    itemList = bppnItemList.Where(i => i.FK_MMBatchProductItemID == batchProductItemID && i.FK_MMOperationID == operation.MMOperationID).ToList();

                    if (operation.MMOperationID == 4)
                    {
                        if (batchProductItemID == 23)
                        {

                        }
                    }
                    decimal SynchronousPercent = 0;
                    decimal WoodQty = 0;

                    if (itemList != null && itemList.Count > 0)
                    {
                        SynchronousPercent = itemList.Min(i => i.SynchronousPercent);
                        WoodQty = itemList.Sum(i => i.Blocks);
                    }
                    if (WoodQty > 0)
                        newRow["ReceiptQty_" + operation.MMOperationID] = WoodQty.ToString("N4");
                    else
                        newRow["ReceiptQty_" + operation.MMOperationID] = "-";
                    if (WoodQty > 0)
                        newRow["SynchronousPercent_" + operation.MMOperationID] = SynchronousPercent.ToString("N2");
                    else
                        newRow["SynchronousPercent_" + operation.MMOperationID] = "-";

                }
                dt.Rows.Add(newRow);
            }

        }

        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();
            //  bandedView.GridControl = fld_dgcSynchronousData;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;
            bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnBatchNo = CreateNewColumnNoneBand("BatchProductNo", ReportLocalizedResources.BatchProductNo);
            BandedGridColumn gridColumnProductSerialNo = CreateNewColumn("BatchProductSerialNo", ReportLocalizedResources.BatchProductSerialNo, gridBand);
            BandedGridColumn gridColumnProductNo = CreateNewColumn("ProductForBatchNo", ReportLocalizedResources.ProductForBatchNo, gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("ProductForBatchName", ReportLocalizedResources.ProductForBatchName, gridBand);
            BandedGridColumn gridColumnSaleOrderNo = CreateNewColumn("SaleOrderNo", ReportLocalizedResources.SaleOrderNo, gridBand);
            BandedGridColumn gridColumnNeededTime = CreateNewColumn("BatchProductItemQty", ReportLocalizedResources.MMBatchProductItemProductQtyRP, gridBand);
            BandedGridColumn gridColumnDeliveryDate = CreateNewColumn("DeliveryDate", ReportLocalizedResources.ARSaleOrderDeliveryDateRP, gridBand);

            bandedView.Columns.Add(gridColumnProductSerialNo);
            bandedView.Columns.Add(gridColumnBatchNo);
            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);
            bandedView.Columns.Add(gridColumnSaleOrderNo);
            bandedView.Columns.Add(gridColumnNeededTime);
            bandedView.Columns.Add(gridColumnDeliveryDate);
            gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 200;


            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            operationList = operationList.OrderBy(t => t.MMOperationOrder).ToList();
            foreach (MMOperationsInfo operation in operationList)
            {
                GridBand band = CreateNewGridBand(operation.MMOperationNo, operation.MMOperationName);
                bandedView.Bands.Add(band);

                BandedGridColumn gridColumnReceiptQty = CreateNewColumn("ReceiptQty_" + operation.MMOperationID, ReportLocalizedResources.ReceiptQtyRP, band);
                BandedGridColumn gridColumnSynchronousPercent = CreateNewColumn("SynchronousPercent_" + operation.MMOperationID, ReportLocalizedResources.SynchronousPercent, band);
                bandedView.Columns.Add(gridColumnReceiptQty);
                bandedView.Columns.Add(gridColumnSynchronousPercent);
            }

            gridColumnBatchNo.Group();
            bandedView.DoubleClick += new EventHandler(bandedView_DoubleClick);
            return bandedView;
        }

        void bandedView_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView View = sender as BandedGridView;
            if (View.FocusedRowHandle >= 0)
            {
                DataRowView rowV = (DataRowView)View.GetRow(View.FocusedRowHandle);
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
                if (rowV != null)
                {
                    DataRow row = rowV.Row;
                    string BatchProductSerialNo = string.Empty;



                    if (row["BatchProductSerialNo"] != null)
                    {
                        BatchProductSerialNo = row["BatchProductSerialNo"].ToString();
                        objBatchProductItemsInfo = objBatchProductItemsController.GetBatchProductItemBySerialNo(BatchProductSerialNo);
                        if (objBatchProductItemsInfo != null)
                        {
                            RP203 RP203 = new RP203(objBatchProductItemsInfo.FK_MMBatchProductID, objBatchProductItemsInfo.FK_ICProductID, 0, Convert.ToDateTime(fld_dteSearchFromDate.EditValue), Convert.ToDateTime(fld_dteSearchToDate.EditValue), (BOSERP.Modules.Report.ReportModule)this.Module);
                            RP203.Show();
                            GridView gridView = (GridView)RP203.fld_dgcSynchronousData.MainView;
                            gridView.ExpandAllGroups();
                            gridView.BestFitColumns();
                        }
                    }
                }
            }
        }

        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int BatchProductID = 0;

            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            MMBatchProductProductionNormItemsController bppnItemController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> bppnItemList = bppnItemController.GetBatchSynchronousReportData(BatchProductID, FromDate, ToDate);


            DataTable dt = InitDataTable();
            FillDataTable(dt, bppnItemList);

            fld_dgcSynchronousData.DataSource = dt;

            GridView gridView = (GridView)fld_dgcSynchronousData.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

            BOSProgressBar.Close();
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
    }

}