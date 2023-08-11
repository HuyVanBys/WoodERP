using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP203 : ReportForm
    {
        #region Variables


        int BatchProduct = 0;
        int ProductForBatchID = 0;
        int _OperationID = 0;
        DateTime _FromDate = BOSUtil.GetMonthBeginDate();
        DateTime _ToDate = BOSUtil.GetMonthEndDate();

        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP203()
        {
            InitializeComponent();
        }

        public RP203(int batchProductID, int productForBatchID, int OperationID, DateTime fromDate, DateTime toDate, BOSERP.Modules.Report.ReportModule module)
        {
            this.Module = module;
            InitializeComponent();
            InitializeControls(Controls);
            fld_dgcSynchronousData.Screen = this;
            fld_dgcSynchronousData.InitializeControl();
            BatchProduct = batchProductID;
            _OperationID = OperationID;
            ProductForBatchID = productForBatchID;
            _FromDate = fromDate;
            _ToDate = toDate;
            fld_dteSearchFromDate.EditValue = fromDate;
            fld_dteSearchToDate.EditValue = toDate;
            ShowReportData();
        }


        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            if (BatchProduct > 0 || _OperationID > 0)
            {
                fld_dteSearchFromDate.DateTime = _FromDate;
                fld_dteSearchToDate.DateTime = _ToDate;
                fld_lkeMMBatchProductID.EditValue = BatchProduct;
                fld_lkeICProductID.EditValue = ProductForBatchID;
            }
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            productList.Add(new ICProductsInfo());

            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(t => t.ICProductType == ProductType.Product.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                productList.Add(newObj);
            });

            fld_lkeICProductID.Properties.DataSource = productList;
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
            dt.Columns.Add(new DataColumn("OperationPlanNo", typeof(string)));
            dt.Columns.Add(new DataColumn("OperationPlanID", typeof(int)));
            dt.Columns.Add(new DataColumn("OperationPlanType", typeof(string)));
            dt.Columns.Add(new DataColumn("BatchProductSerialNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ProductForBatchNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ProductForBatchID", typeof(int)));
            dt.Columns.Add(new DataColumn("ProductForBatchName", typeof(string)));
            dt.Columns.Add(new DataColumn("ChildStatus", typeof(string)));
            dt.Columns.Add(new DataColumn("RefNo", typeof(string)));
            dt.Columns.Add(new DataColumn("Week", typeof(string)));
            dt.Columns.Add(new DataColumn("SaleOrderNo", typeof(string)));
            dt.Columns.Add(new DataColumn("BatchProductItemProductQty", typeof(string)));
            dt.Columns.Add(new DataColumn("OperationDetailPlanItemProductQty", typeof(string)));
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

        private void FillDataTable(DataTable dt, List<MMOperationDetailPlanItemChildsInfo> odpicList)
        {
            List<string> batchProductItemIDs = new List<string>();
            string key = string.Empty;
            foreach (MMOperationDetailPlanItemChildsInfo item in odpicList)
            {
                key = item.MMBatchProductID + "_" + item.FK_MMOperationDetailPlanItemID + "_" + item.FK_MMBatchProductItemID;
                if (!batchProductItemIDs.Contains(key))
                {
                    batchProductItemIDs.Add(key);
                }
            }

            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            List<MMOperationDetailPlanItemChildsInfo> itemList;
            foreach (string matchKey in batchProductItemIDs)
            {
                string[] keys = matchKey.Split('_');
                int batchProductID = int.Parse(keys[0]);
                int batchProductItemID = int.Parse(keys[2]);
                int operationDetailPlanItemID = int.Parse(keys[1]);
                DataRow newRow = dt.NewRow();

                MMOperationDetailPlanItemChildsInfo item = odpicList.FirstOrDefault(i => i.FK_MMBatchProductItemID == batchProductItemID
                                                                                    && i.FK_MMOperationDetailPlanItemID == operationDetailPlanItemID);


                newRow["OperationPlanNo"] = item.MMOperationDetailPlanNo;
                newRow["OperationPlanID"] = item.MMOperationDetailPlanID;
                newRow["ProductForBatchID"] = item.FK_ICProductForBatchID;
                newRow["OperationPlanType"] = item.MMOperationDetailPlanType;
                newRow["BatchProductNo"] = item.MMBatchProductNo;
                newRow["BatchProductSerialNo"] = item.MMOperationDetailPlanItemChildProductSerial;
                newRow["ProductForBatchNo"] = item.ProductForBatchNo;
                newRow["ProductForBatchName"] = item.ProductForBatchName;

                newRow["RefNo"] = item.FK_MMOperationDetailPlanNo;
                newRow["Week"] = item.MMOperationDetailPlanWeek;
                newRow["SaleOrderNo"] = item.ARSaleOrderNo;
                newRow["BatchProductItemProductQty"] = item.MMOperationDetailPlanItemChildBatchProductItemProductQty;
                newRow["OperationDetailPlanItemProductQty"] = item.MMOperationDetailPlanItemPlanProductQty;
                newRow["DeliveryDate"] = item.MMBatchProductItemDeliveryDate.ToString("dd/MM/yyyy");


                foreach (MMOperationsInfo operation in operationList)
                {
                    if (operation.MMOperationID == item.MMOperationID)
                    {
                        itemList = new List<MMOperationDetailPlanItemChildsInfo>();
                        itemList = odpicList.Where(i => i.FK_MMBatchProductItemID == batchProductItemID
                                                        && i.MMOperationID == operation.MMOperationID
                                                        && i.FK_MMOperationDetailPlanItemID == operationDetailPlanItemID).ToList();

                        decimal SynchronousPercent = 0;
                        decimal WoodQty = 0;

                        if (itemList != null && itemList.Count > 0)
                        {
                            SynchronousPercent = itemList.Min(i => i.SynchronousPercent);
                            WoodQty = itemList.Sum(i => i.WoodQty);
                        }
                        if (WoodQty > 0)
                            newRow["ReceiptQty_" + operation.MMOperationID] = WoodQty.ToString("N4");
                        else
                            newRow["ReceiptQty_" + operation.MMOperationID] = "-";
                        if (SynchronousPercent > 0)
                            newRow["SynchronousPercent_" + operation.MMOperationID] = SynchronousPercent.ToString("N2");
                        else
                            newRow["SynchronousPercent_" + operation.MMOperationID] = "-";
                        if (SynchronousPercent == 100)
                        {
                            newRow["ChildStatus"] = "Đã nhập đủ";
                            newRow["RefNo"] = "";
                        }
                        else if (item.MMOperationDetailPlanStatus == OperationDetailPlanStatus.Approved.ToString() && SynchronousPercent != 100)
                        {
                            newRow["ChildStatus"] = "Đang sản xuất";
                        }
                        else if (item.MMOperationDetailPlanStatus == OperationDetailPlanStatus.Completed.ToString() && SynchronousPercent != 100)
                            newRow["ChildStatus"] = "Đã có KH bù";
                        else
                            newRow["ChildStatus"] = "Đang sản xuất";

                    }
                    else
                    {
                        newRow["ReceiptQty_" + operation.MMOperationID] = string.Empty;
                        newRow["SynchronousPercent_" + operation.MMOperationID] = string.Empty;

                    }
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
            //bandedView.OptionsView.ShowFooter = false;
            //bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnBatchNo = CreateNewColumnNoneBand("BatchProductNo", ReportLocalizedResources.MMBatchProductNoRP);
            BandedGridColumn gridColumnOperationPlanNo = CreateNewColumnNoneBand("OperationPlanNo", ReportLocalizedResources.OperationPlanNo);
            BandedGridColumn gridColumnOperationPlanType = CreateNewColumn("OperationPlanType", ReportLocalizedResources.OperationPlanType, gridBand);
            BandedGridColumn gridColumnProductSerialNo = CreateNewColumn("BatchProductSerialNo", ReportLocalizedResources.BatchProductSerialNo, gridBand);
            BandedGridColumn gridColumnProductNo = CreateNewColumn("ProductForBatchNo", ReportLocalizedResources.ProductForBatchNo, gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("ProductForBatchName", ReportLocalizedResources.ProductForBatchName, gridBand);
            BandedGridColumn gridColumnChildStatus = CreateNewColumn("ChildStatus", "Trạng thái", gridBand);
            BandedGridColumn gridColumnRefNo = CreateNewColumn("RefNo", "Kế hoạch bù", gridBand);
            BandedGridColumn gridColumnWeek = CreateNewColumn("Week", "Tuần", gridBand);
            BandedGridColumn gridColumnSaleOrderNo = CreateNewColumn("SaleOrderNo", ReportLocalizedResources.SaleOrderNo, gridBand);
            BandedGridColumn gridColumnNeededTime = CreateNewColumn("BatchProductItemProductQty", ReportLocalizedResources.MMBatchProductItemProductQtyRP, gridBand);
            BandedGridColumn gridColumnPlanQty = CreateNewColumn("OperationDetailPlanItemProductQty", ReportLocalizedResources.OperationDetailPlanItemPlanProductQty, gridBand);
            BandedGridColumn gridColumnDeliveryDate = CreateNewColumn("DeliveryDate", ReportLocalizedResources.ARSaleOrderDeliveryDateRP, gridBand);


            bandedView.Columns.Add(gridColumnOperationPlanNo);
            bandedView.Columns.Add(gridColumnOperationPlanType);
            bandedView.Columns.Add(gridColumnProductSerialNo);
            bandedView.Columns.Add(gridColumnBatchNo);
            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);

            bandedView.Columns.Add(gridColumnChildStatus);
            bandedView.Columns.Add(gridColumnRefNo);
            bandedView.Columns.Add(gridColumnWeek);

            bandedView.Columns.Add(gridColumnSaleOrderNo);
            bandedView.Columns.Add(gridColumnNeededTime);
            bandedView.Columns.Add(gridColumnPlanQty);
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
            gridColumnOperationPlanNo.Group();
            bandedView.DoubleClick += new EventHandler(bandedView_DoubleClick);
            return bandedView;
        }

        void bandedView_DoubleClick(object sender, EventArgs e)
        {
            BandedGridView View = sender as BandedGridView;
            if (View.FocusedRowHandle >= 0)
            {
                DataRowView rowV = (DataRowView)View.GetRow(View.FocusedRowHandle);

                if (rowV != null)
                {
                    DataRow row = rowV.Row;
                    int OperationPlanID = 0;
                    int ProductForBatchID = 0;

                    if (row["OperationPlanID"] != null)
                    {
                        OperationPlanID = int.Parse(row["OperationPlanID"].ToString());
                    }
                    if (row["ProductForBatchID"] != null)
                    {
                        ProductForBatchID = int.Parse(row["ProductForBatchID"].ToString());
                    }
                    if (OperationPlanID > 0 && ProductForBatchID > 0)
                    {
                        RP204 RP204 = new RP204(OperationPlanID, ProductForBatchID, Convert.ToDateTime(fld_dteSearchFromDate.EditValue), Convert.ToDateTime(fld_dteSearchToDate.EditValue), (BOSERP.Modules.Report.ReportModule)this.Module);
                        RP204.Show();
                        GridView gridView = (GridView)RP204.fld_dgcMMOperationDetailPlanItemChilds.MainView;
                        gridView.ExpandAllGroups();
                        gridView.BestFitColumns();
                    }
                }
            }
        }

        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int BatchProductID = 0;
            int OperationDetailPlanID = 0;
            int ProductID = 0;
            int OperationID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            if (fld_lkeMMOperationDetailPlanID.EditValue != null)
                int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out OperationDetailPlanID);
            if (fld_lkeICProductID.EditValue != null)
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out ProductID);
            if (fld_lkeMMOperationID.EditValue != null)
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out OperationID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            MMOperationsController operationsController = new MMOperationsController();
            MMOperationsInfo operation = (MMOperationsInfo)operationsController.GetObjectByID(OperationID);
            if (operation != null)
            {
                fld_lblOperationName.Text = "CÔNG ĐOẠN " + operation.MMOperationName.ToUpper();
            }
            else
            {
                fld_lblOperationName.Text = "";
            }

            if (BatchProduct > 0)
                BatchProductID = BatchProduct;
            if (ProductForBatchID > 0)
                ProductID = ProductForBatchID;
            if (_OperationID > 0)
                OperationID = _OperationID;

            if (BatchProduct > 0)
            {
                FromDate = _FromDate;
                ToDate = _ToDate;
                fld_dteSearchFromDate.EditValue = _FromDate;
                fld_dteSearchToDate.EditValue = _ToDate;
                fld_lkeMMBatchProductID.EditValue = BatchProduct;
            }
            MMOperationDetailPlanItemChildsController odpicController = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> odpicList = odpicController.GetSynchronousOperationDetailPlanData(BatchProductID, OperationDetailPlanID, FromDate, ToDate, ProductID, OperationID);
            // InitBandedGridView();

            DataTable dt = InitDataTable();
            FillDataTable(dt, odpicList);

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

        private void fld_lkeICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int BatchProductID = 0;
            int OperationDetailPlanID = 0;

            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out OperationDetailPlanID);

            ICProductsController productsController = new ICProductsController();
            List<ICProductsInfo> productList = productsController.GetProductByBatchProductIDAndOperationPlanID(BatchProductID, OperationDetailPlanID);
            List<ICProductsInfo> result = new List<ICProductsInfo>();
            result.Add(new ICProductsInfo());
            result.AddRange(productList);
            fld_lkeICProductID.Properties.DataSource = result;

        }

        private void fld_lkeMMOperationDetailPlanID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int BatchProductID = 0;
            int OperationID = 0;

            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out OperationID);

            MMOperationDetailPlansController OperationDetailPlansController = new MMOperationDetailPlansController();
            List<MMOperationDetailPlansInfo> operationDetailPlanList = OperationDetailPlansController.GetPlanByBatchProductIDAndOperationID(BatchProductID, OperationID);
            List<MMOperationDetailPlansInfo> result = new List<MMOperationDetailPlansInfo>();
            result.Add(new MMOperationDetailPlansInfo());
            result.AddRange(operationDetailPlanList);

            fld_lkeMMOperationDetailPlanID.Properties.DataSource = result;
        }

        private void fld_dgcSynchronousData_DoubleClick(object sender, EventArgs e)
        {

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