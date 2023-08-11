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
    public partial class RP202 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP202()
        {
            InitializeComponent();
        }

        private void RP202_Load(object sender, EventArgs e)
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
            if (fld_dteSearchFromDate.DateTime != DateTime.MaxValue && fld_dteSearchToDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
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
            bandedView.OptionsView.ShowFooter = false;
            bandedView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);
            BandedGridColumn gridColumnBatchNo = CreateNewColumnNoneBand("MMBatchProductNo", "Mã LSX");
            BandedGridColumn gridColumnBatchItemProductSerial = CreateNewColumnNoneBand("MMBatchProductItemProductSerial", "Mã Lô");
            BandedGridColumn gridColumnProductForBatchNo = CreateNewColumnNoneBand("ICProductNo", "Mã thành phẩm");
            BandedGridColumn gridColumnProductNo = CreateNewColumn("MMBatchProductProductionNormItemNo", "Mã chi tiết", gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("MMBatchProductProductionNormItemProductName", "Tên chi tiết", gridBand);
            BandedGridColumn gridColumnProductHeight = CreateNewColumn("MMBatchProductProductionNormItemProductHeight", "Dày", gridBand);
            BandedGridColumn gridColumnProductWidth = CreateNewColumn("MMBatchProductProductionNormItemProductWidth", "Rộng", gridBand);
            BandedGridColumn gridColumnProductLength = CreateNewColumn("MMBatchProductProductionNormItemProductLength", "Dài", gridBand);
            BandedGridColumn gridColumnProductQty = CreateNewColumn("MMBatchProductProductionNormItemQuantity", "Số lượng", gridBand);
            BandedGridColumn gridColumnProductBlock = CreateNewColumn("MMBatchProductProductionNormItemBlock", "Khối lượng", gridBand);


            bandedView.Columns.Add(gridColumnBatchNo);
            bandedView.Columns.Add(gridColumnBatchItemProductSerial);
            bandedView.Columns.Add(gridColumnProductForBatchNo);
            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);

            bandedView.Columns.Add(gridColumnProductHeight);
            bandedView.Columns.Add(gridColumnProductWidth);
            bandedView.Columns.Add(gridColumnProductLength);
            bandedView.Columns.Add(gridColumnProductQty);
            bandedView.Columns.Add(gridColumnProductBlock);
            gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 200;


            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            operationList = operationList.OrderBy(t => t.MMOperationOrder).ToList();
            foreach (MMOperationsInfo operation in operationList)
            {
                GridBand band = CreateNewGridBand(operation.MMOperationNo, operation.MMOperationName);
                bandedView.Bands.Add(band);

                BandedGridColumn gridColumnReceiptQty = CreateNewColumn("ReceiptQty_" + operation.MMOperationID, "SL nhập", band);
                BandedGridColumn gridColumnReceiptWoodQty = CreateNewColumn("ReceiptWoodQty_" + operation.MMOperationID, "m3 nhập", band);
                BandedGridColumn gridColumnSLThieu = CreateNewColumn("SLThieu_" + operation.MMOperationID, "SL thiếu", band);
                // BandedGridColumn gridColumnSynchronousPercent = CreateNewColumn("SynchronousPercent_" + operation.MMOperationID, "% hoàn thành", band);
                bandedView.Columns.Add(gridColumnReceiptQty);
                bandedView.Columns.Add(gridColumnReceiptWoodQty);
                bandedView.Columns.Add(gridColumnSLThieu);
                //bandedView.Columns.Add(gridColumnSynchronousPercent);
            }
            gridColumnBatchNo.GroupIndex = 1;
            gridColumnBatchItemProductSerial.GroupIndex = 2;
            gridColumnProductForBatchNo.GroupIndex = 3;
            gridColumnBatchItemProductSerial.Group();
            gridColumnBatchNo.Group();
            gridColumnProductForBatchNo.Group();
            return bandedView;
        }

        private void FillDataTable(DataTable dt, List<int> distinctList, List<MMBatchProductProductionNormItemsInfo> dataList)
        {
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();

            MMBatchProductProductionNormItemsInfo matchItem;
            foreach (int itemID in distinctList)
            {

                matchItem = dataList.FirstOrDefault(t => t.MMBatchProductProductionNormItemID == itemID);
                if (matchItem != null)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["MMBatchProductNo"] = matchItem.MMBatchProductNo;
                    newRow["MMBatchProductItemProductSerial"] = matchItem.MMBatchProductItemProductSerial;
                    newRow["ICProductNo"] = matchItem.ICProductNo;
                    newRow["MMBatchProductProductionNormItemNo"] = matchItem.MMBatchProductProductionNormItemNo;
                    newRow["MMBatchProductProductionNormItemProductName"] = matchItem.MMBatchProductProductionNormItemProductName;
                    newRow["MMBatchProductProductionNormItemProductHeight"] = matchItem.MMBatchProductProductionNormItemProductHeight;
                    newRow["MMBatchProductProductionNormItemProductWidth"] = matchItem.MMBatchProductProductionNormItemProductWidth;
                    newRow["MMBatchProductProductionNormItemProductLength"] = matchItem.MMBatchProductProductionNormItemProductLength;
                    newRow["MMBatchProductProductionNormItemQuantity"] = matchItem.MMBatchProductProductionNormItemQuantity.ToString("N0");
                    newRow["MMBatchProductProductionNormItemBlock"] = matchItem.M3ThucTe.ToString("N4");


                    foreach (MMOperationsInfo operation in operationList)
                    {
                        // decimal Slhoantat = 0;
                        decimal SLNhap = 0;
                        decimal m3Nhap = 0;
                        decimal SLThieu = 0;

                        for (int i = 0; i < dataList.Count; i++)
                        {
                            matchItem = dataList[i];
                            if (matchItem.MMBatchProductProductionNormItemID == itemID
                                && matchItem.FK_MMOperationID == operation.MMOperationID)
                            {
                                SLNhap += matchItem.SLNhap;
                                m3Nhap += matchItem.Blocks;
                                SLThieu += (matchItem.MMBatchProductProductionNormItemQuantity - matchItem.SLNhap);
                                dataList.RemoveAt(i--);
                            }
                        }

                        if (SLNhap == 0 && m3Nhap == 0 && SLThieu == 0)
                        {
                            newRow["ReceiptQty_" + operation.MMOperationID] = "-";
                            newRow["ReceiptWoodQty_" + operation.MMOperationID] = "-";
                            newRow["SLThieu_" + operation.MMOperationID] = "-";
                        }
                        else
                        {

                            newRow["ReceiptQty_" + operation.MMOperationID] = SLNhap.ToString("N0");
                            if (m3Nhap > 0)
                                newRow["ReceiptWoodQty_" + operation.MMOperationID] = m3Nhap.ToString("N4");
                            else
                                newRow["ReceiptWoodQty_" + operation.MMOperationID] = "0";
                            newRow["SLThieu_" + operation.MMOperationID] = SLThieu.ToString("N0");

                        }


                    }
                    dt.Rows.Add(newRow);
                }
            }

        }

        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("MMBatchProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductItemProductSerial", typeof(string)));
            dt.Columns.Add(new DataColumn("ICProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemNo", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemProductName", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemProductHeight", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemProductWidth", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemProductLength", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemQuantity", typeof(string)));
            dt.Columns.Add(new DataColumn("MMBatchProductProductionNormItemBlock", typeof(string)));


            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetOperationForSynchronousBatchReport();


            foreach (MMOperationsInfo operation in operationList)
            {
                dt.Columns.Add(new DataColumn("ReceiptQty_" + operation.MMOperationID, typeof(string)));
                dt.Columns.Add(new DataColumn("ReceiptWoodQty_" + operation.MMOperationID, typeof(string)));
                dt.Columns.Add(new DataColumn("SLThieu_" + operation.MMOperationID, typeof(string)));
                // dt.Columns.Add(new DataColumn("SynchronousPercent_" + operation.MMOperationID, typeof(string)));
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

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        /// 
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int batchProductID = 0;
            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            Report145Object RP202Object = objBatchProductProductionNormItemsController.GetItemForReport145(fromDate, toDate, batchProductID);
            List<MMBatchProductProductionNormItemsInfo> ListItem = RP202Object.dataList;


            ////=> distinct list

            //List<MMBatchProductProductionNormItemsInfo> distinctList = new List<MMBatchProductProductionNormItemsInfo>();
            //MMBatchProductProductionNormItemsInfo matchItem;
            //foreach (MMBatchProductProductionNormItemsInfo item in ListItem)
            //{
            //    if (distinctList.Count == 0)
            //    {
            //        distinctList.Add(item);
            //    }
            //    else
            //    {
            //        matchItem = distinctList.FirstOrDefault(i => i.MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID);
            //        if (matchItem == null)
            //        {
            //            distinctList.Add(item);
            //        }
            //    }
            //}

            DataTable dt = InitDataTable();
            FillDataTable(dt, RP202Object.distinctList, ListItem);

            fld_dgcMMBatchProductProductionNormItems.DataSource = dt;

            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
            gridView.Columns["MMBatchProductProductionNormItemNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            BOSProgressBar.Close();
        }



        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            ExportToExcel(gridView);
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