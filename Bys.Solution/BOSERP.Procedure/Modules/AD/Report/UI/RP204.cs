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
    public partial class RP204 : ReportForm
    {
        #region Variables

        int OperationPlanID = 0;
        int ProductForBatchID = 0;
        DateTime FromDate = BOSUtil.GetMonthBeginDate();
        DateTime ToDate = BOSUtil.GetMonthEndDate();

        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP204()
        {
            InitializeComponent();
        }

        public RP204(int operationPlanID, int productForBatchID, DateTime fromDate, DateTime toDate, BOSERP.Modules.Report.ReportModule Module)
        {
            this.Module = Module;
            InitializeComponent();
            InitializeControls(Controls);
            fld_dgcMMOperationDetailPlanItemChilds.Screen = this;
            fld_dgcMMOperationDetailPlanItemChilds.InitializeControl();
            OperationPlanID = operationPlanID;
            ProductForBatchID = productForBatchID;
            FromDate = fromDate;
            ToDate = toDate;
            fld_dteSearchFromDate.DateTime = fromDate;
            fld_dteSearchToDate.DateTime = toDate;
            if (fld_lkeMMOperationDetailPlanID != null)
                fld_lkeMMOperationDetailPlanID.EditValue = operationPlanID;
            if (fld_lkeICProductID != null)
                fld_lkeICProductID.EditValue = productForBatchID;
            ShowReportData();
        }
        private void RP204_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            if (OperationPlanID > 0 || ProductForBatchID > 0)
            {
                fld_dteSearchFromDate.DateTime = FromDate;
                fld_dteSearchToDate.DateTime = ToDate;
                fld_lkeMMOperationDetailPlanID.EditValue = OperationPlanID;
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
            if (fld_dteSearchFromDate.DateTime != DateTime.MaxValue && fld_dteSearchToDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }


        private void FillDataTable(DataTable dt, List<MMOperationDetailPlanItemChildsInfo> distinctList, List<MMOperationDetailPlanItemChildsInfo> dataList)
        {
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();
            List<MMOperationDetailPlanItemChildsInfo> matchList;
            foreach (MMOperationDetailPlanItemChildsInfo item in distinctList)
            {
                DataRow newRow = dt.NewRow();
                newRow["MMOperationDetailPlanNo"] = item.MMOperationDetailPlanNo;
                newRow["MMBatchProductNo"] = item.MMBatchProductNo;
                newRow["MMOperationDetailPlanItemChildProductNo"] = item.MMOperationDetailPlanItemChildProductNo;
                newRow["MMOperationDetailPlanItemChildProductName"] = item.MMOperationDetailPlanItemChildProductName;
                newRow["MMOperationDetailPlanItemChildSaleOrdeNo"] = item.MMOperationDetailPlanItemChildSaleOrdeNo;
                newRow["MMOperationDetailPlanItemChildProductHeight"] = item.MMOperationDetailPlanItemChildProductHeight;
                newRow["MMOperationDetailPlanItemChildProductLength"] = item.MMOperationDetailPlanItemChildProductLength;
                newRow["MMOperationDetailPlanItemChildProductWidth"] = item.MMOperationDetailPlanItemChildProductWidth;
                newRow["MMOperationDetailPlanItemChildProductWoodType"] = item.MMOperationDetailPlanItemChildProductWoodType;
                newRow["MMOperationDetailPlanItemChildProductQty"] = item.MMOperationDetailPlanItemChildProductQty;
                newRow["MMOperationDetailPlanItemChildBlockPerOne"] = item.MMOperationDetailPlanItemChildBlockPerOne.ToString("N4");
                newRow["MMOperationDetailPlanItemChildPlanProductQty"] = item.MMOperationDetailPlanItemChildPlanProductQty;
                newRow["MMOperationDetailPlanItemChildCancelQty"] = item.MMOperationDetailPlanItemChildCancelQty;
                newRow["MMOperationDetailPlanItemChildCompensateQty"] = item.MMOperationDetailPlanItemChildCompensateQty;
                newRow["MMOperationDetailPlanItemChildPlanBlock"] = item.MMOperationDetailPlanItemChildPlanBlock.ToString("N4");
                newRow["OperationPlanID"] = item.MMOperationDetailPlanID;
                newRow["ProductForBatchID"] = item.FK_ICProductForBatchID;
                newRow["MMOperationDetailPlanItemChildID"] = item.MMOperationDetailPlanItemChildID;
                newRow["MMOperationDetailPlanItemChildBarcode"] = item.MMOperationDetailPlanItemChildBarcode;

                foreach (MMOperationsInfo operation in operationList)
                {
                    decimal KLNhap = 0;
                    decimal SLNhap = 0;
                    decimal SLThieu = 0;
                    matchList = dataList.Where(t => t.MMOperationDetailPlanNo == item.MMOperationDetailPlanNo
                                                            && t.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                            && t.MMOperationDetailPlanItemChildProductNo == item.MMOperationDetailPlanItemChildProductNo
                                                            && t.MMOperationID == operation.MMOperationID).ToList();
                    if (matchList != null && matchList.Count > 0)
                    {
                        KLNhap = matchList.Sum(i => i.KLNhap);
                        SLNhap = matchList.Sum(i => i.SLNhap);

                        SLThieu = matchList.Sum(i => i.SLThieu)
                                - matchList.Sum(i => i.MMOperationDetailPlanItemChildCancelQty)
                                - matchList.Sum(i => i.MMOperationDetailPlanItemChildCompensateQty);

                        newRow["MMOperationDetailPlanItemOperationName"] = operation.MMOperationName;
                    }
                    if (SLNhap != 0)
                        newRow["SLNhap_" + operation.MMOperationID] = SLNhap.ToString("N0");
                    else
                        newRow["SLNhap_" + operation.MMOperationID] = "-";

                    if (KLNhap != 0)
                        newRow["KLNhap_" + operation.MMOperationID] = KLNhap.ToString("N4");
                    else
                        newRow["KLNhap_" + operation.MMOperationID] = "-";

                    if (SLThieu != 0)
                        newRow["SLThieu_" + operation.MMOperationID] = SLThieu.ToString("N0");
                    else
                        newRow["SLThieu_" + operation.MMOperationID] = "-";
                }
                dt.Rows.Add(newRow);
            }

        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        public void ShowReportData()
        {
            //BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int operationDetailPlanID = 0;
            int productID = 0;
            int operationID = 0;
            if (fld_lkeMMOperationDetailPlanID.EditValue != null)
                int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out operationDetailPlanID);
            if (fld_lkeICProductID.EditValue != null)
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);
            if (fld_lkeMMOperationID.EditValue != null)
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            if (ProductForBatchID > 0)
                productID = ProductForBatchID;
            if (OperationPlanID > 0)
            {
                operationDetailPlanID = OperationPlanID;
                fromDate = FromDate;
                toDate = ToDate;
                fld_dteSearchFromDate.EditValue = FromDate;
                fld_dteSearchToDate.EditValue = ToDate;
                fld_lkeMMOperationDetailPlanID.EditValue = OperationPlanID;
            }

            MMOperationDetailPlanItemChildsController objOperationDetailPlanItemChildsController = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> ListItem = objOperationDetailPlanItemChildsController.GetItemForReport147(fromDate, toDate, operationDetailPlanID, productID, operationID);

            List<MMOperationDetailPlanItemChildsInfo> distinctList = new List<MMOperationDetailPlanItemChildsInfo>();
            MMOperationDetailPlanItemChildsInfo matchItem;
            foreach (MMOperationDetailPlanItemChildsInfo item in ListItem)
            {
                if (distinctList.Count == 0)
                {
                    distinctList.Add(item);
                }
                else
                {
                    matchItem = distinctList.FirstOrDefault(t => t.MMOperationDetailPlanNo == item.MMOperationDetailPlanNo
                                                            && t.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                            && t.MMOperationDetailPlanItemChildProductNo == item.MMOperationDetailPlanItemChildProductNo);
                    if (matchItem == null)
                    {
                        distinctList.Add(item);
                    }
                }

            }
            DataTable dt = InitDataTable();
            FillDataTable(dt, distinctList, ListItem);

            fld_dgcMMOperationDetailPlanItemChilds.DataSource = dt;

            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChilds.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

            //BOSProgressBar.Close();
        }

        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnOperationDetailPlanNo = CreateNewColumnNoneBand("MMOperationDetailPlanNo", "Mã KHSX");
            BandedGridColumn gridColumnBatchProductNo = CreateNewColumnNoneBand("MMBatchProductNo", "Mã LSX");
            BandedGridColumn gridColumnProductNo = CreateNewColumn("MMOperationDetailPlanItemChildProductNo", "Mã chi tiết", gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("MMOperationDetailPlanItemChildProductName", "Tên chi tiết", gridBand);
            BandedGridColumn gridColumnSaleOrdeNo = CreateNewColumn("MMOperationDetailPlanItemChildSaleOrdeNo", "P.I", gridBand);
            BandedGridColumn gridColumnProductWoodType = CreateNewColumn("MMOperationDetailPlanItemChildProductWoodType", "Loại gỗ", gridBand);
            BandedGridColumn gridColumnProductQty = CreateNewColumn("MMOperationDetailPlanItemChildProductQty", "Số lượng CT/SP", gridBand);
            BandedGridColumn gridColumnPlanProductQty = CreateNewColumn("MMOperationDetailPlanItemChildPlanProductQty", "Số lượng hoạch định", gridBand);
            BandedGridColumn gridColumnOperationName = CreateNewColumn("MMOperationDetailPlanItemOperationName", "Công đoạn", gridBand);




            bandedView.Columns.Add(gridColumnOperationDetailPlanNo);
            bandedView.Columns.Add(gridColumnBatchProductNo);
            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);
            bandedView.Columns.Add(gridColumnSaleOrdeNo);
            bandedView.Columns.Add(gridColumnProductWoodType);
            bandedView.Columns.Add(gridColumnProductQty);
            bandedView.Columns.Add(gridColumnPlanProductQty);
            bandedView.Columns.Add(gridColumnOperationName);

            gridBand.MinWidth = 200;


            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            operationList = operationList.OrderBy(t => t.MMOperationOrder).ToList();
            foreach (MMOperationsInfo operation in operationList)
            {
                GridBand band = CreateNewGridBand(operation.MMOperationNo, operation.MMOperationName);
                bandedView.Bands.Add(band);

                BandedGridColumn gridColumnReceiptQty = CreateNewColumn("SLNhap_" + operation.MMOperationID, "Số lượng nhập", band);
                BandedGridColumn gridColumnSynchronousPercent = CreateNewColumn("KLNhap_" + operation.MMOperationID, "Khối lượng nhập", band);
                BandedGridColumn gridColumnSLThieu = CreateNewColumn("SLThieu_" + operation.MMOperationID, "Số lượng thiếu", band);

                bandedView.Columns.Add(gridColumnReceiptQty);
                bandedView.Columns.Add(gridColumnSynchronousPercent);
                bandedView.Columns.Add(gridColumnSLThieu);
            }
            gridColumnOperationDetailPlanNo.GroupIndex = 1;
            gridColumnBatchProductNo.GroupIndex = 2;
            gridColumnOperationDetailPlanNo.Group();
            gridColumnBatchProductNo.Group();
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
                    string barcodeID = string.Empty;
                    if (row["OperationPlanID"] != null)
                    {
                        OperationPlanID = int.Parse(row["OperationPlanID"].ToString());
                    }
                    if (row["ProductForBatchID"] != null)
                    {
                        ProductForBatchID = int.Parse(row["ProductForBatchID"].ToString());
                    }
                    if (row["MMOperationDetailPlanItemChildBarcode"] != null)
                    {
                        barcodeID = row["MMOperationDetailPlanItemChildBarcode"].ToString().PadLeft(2, '0');
                    }
                    //if (OperationPlanID > 0 && ProductForBatchID > 0)
                    //{
                    //    RP197 RP197 = new RP197(OperationPlanID, ProductForBatchID, barcodeID, Convert.ToDateTime(fld_dteSearchFromDate.EditValue)
                    //        , Convert.ToDateTime(fld_dteSearchToDate.EditValue), (BOSERP.Modules.Report.ReportModule)this.Module);
                    //    RP197.Show();
                    //    GridView gridView = (GridView)RP197.fld_dgcSynchronousData.MainView;
                    //    gridView.ExpandAllGroups();
                    //    gridView.BestFitColumns();
                    //}
                }
            }
        }
        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("MMOperationDetailPlanNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("OperationPlanID", typeof(int)));
            dt.Columns.Add(new DataColumn("ProductForBatchID", typeof(int)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildID", typeof(int)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductName", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildSaleOrdeNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductHeight", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductWidth", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductLength", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductWoodType", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildProductQty", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildBlockPerOne", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildPlanProductQty", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildPlanBlock", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemOperationName", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildCancelQty", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildCompensateQty", typeof(string)));
            dt.Columns.Add(new DataColumn("MMOperationDetailPlanItemChildBarcode", typeof(string)));
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();


            foreach (MMOperationsInfo operation in operationList)
            {
                dt.Columns.Add(new DataColumn("SLNhap_" + operation.MMOperationID, typeof(string)));
                dt.Columns.Add(new DataColumn("KLNhap_" + operation.MMOperationID, typeof(string)));
                dt.Columns.Add(new DataColumn("SLThieu_" + operation.MMOperationID, typeof(string)));
            }

            return dt;
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


        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcMMOperationDetailPlanItemChilds.MainView;
            ExportToXls(gridView);
        }


        public void ChangeProductDatSource()
        {
            int DetailPlanID = 0;
            int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out DetailPlanID);
            List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ListProduct = objProductsController.GetProductByBatchProductIDAndOperationPlanID(0, DetailPlanID);
            fld_lkeICProductID.Properties.DataSource = ListProduct;
        }


        private void fld_lkeICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ChangeProductDatSource();
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