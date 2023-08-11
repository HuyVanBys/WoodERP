using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP156 : ReportForm
    {
        #region Variables

        /*
         Báo cáo lấy các item của các kế hoạch.
         Lấy các năng suất theo công đoạn và thời gian.
         */


        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP156()
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
            dt.Columns.Add(new DataColumn("ProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ProductName", typeof(string)));
            dt.Columns.Add(new DataColumn("OperationName", typeof(string)));
            dt.Columns.Add(new DataColumn("StockName", typeof(string)));
            dt.Columns.Add(new DataColumn("BatchProductQty", typeof(double)));
            dt.Columns.Add(new DataColumn("Block", typeof(double)));
            dt.Columns.Add(new DataColumn("Paint", typeof(double)));
            dt.Columns.Add(new DataColumn("ReceiptQty", typeof(double)));
            dt.Columns.Add(new DataColumn("ReceiptAmount", typeof(double)));
            dt.Columns.Add(new DataColumn("ShipmentQty", typeof(double)));
            dt.Columns.Add(new DataColumn("ShipmentAmount", typeof(double)));
            dt.Columns.Add(new DataColumn("InventoryQty", typeof(double)));
            dt.Columns.Add(new DataColumn("InventoryAmount", typeof(double)));
            dt.Columns.Add(new DataColumn("TypeCombo", typeof(string)));
            return dt;
        }

        private void FillDataTable(DataTable dt)
        {
            //List<string> itemChildIDs = new List<string>();

            //string key = string.Empty;
            //foreach (MMOperationDetailPlanItemChildsInfo item in odpicList)
            //{
            //    key = item.MMOperationDetailPlanItemChildID + "_" + item.MMOperationID;
            //    if (!itemChildIDs.Contains(key))
            //    {
            //        itemChildIDs.Add(key);
            //    }
            //}

            //MMOperationsController operationController = new MMOperationsController();
            //List<MMOperationsInfo> operationList = operationController.GetOperationOnCapacity();

            //List<MMOperationDetailPlanItemChildsInfo> itemList;
            //List<MMOperationDetailPlanItemChildsInfo> matchList;
            //foreach (string itemChildIDstr in itemChildIDs)
            //{
            //    string[] itemChildIDarr = itemChildIDstr.Split('_');
            //    int itemChildID = int.Parse(itemChildIDarr[0]);
            //    int operationID = int.Parse(itemChildIDarr[1]);
            //    DataRow newRow = dt.NewRow();

            //    MMOperationDetailPlanItemChildsInfo item = odpicList.FirstOrDefault(i => i.MMOperationDetailPlanItemChildID == itemChildID
            //                                                                             && i.MMOperationID == operationID);

            //    if (item != null)
            //    {
            //        newRow["OperationPlanNo"] = item.MMOperationDetailPlanNo;
            //        newRow["BatchProductNo"] = item.MMBatchProductNo;
            //        newRow["BatchProductSerialNo"] = item.MMOperationDetailPlanItemChildProductSerial;
            //        newRow["ProductNo"] = item.MMOperationDetailPlanItemChildProductNo;
            //        newRow["ProductName"] = item.MMOperationDetailPlanItemChildProductName;
            //        newRow["ProductHeight"] = item.MMOperationDetailPlanItemChildProductHeight;
            //        newRow["ProductWidth"] = item.MMOperationDetailPlanItemChildProductWidth;
            //        newRow["ProductLength"] = item.MMOperationDetailPlanItemChildProductLength;
            //        newRow["PlanProductQty"] = item.MMOperationDetailPlanItemChildPlanProductQty;
            //        newRow["Operation"] = item.MMOperationName;
            //        newRow["SaleOrderNo"] = item.ARSaleOrderNo;
            //        //itemList = odpicList.Where(i => i.MMOperationDetailPlanItemChildID == itemChildID
            //        //                                                                         && i.MMOperationID == operationID).ToList();
            //        //if (itemList != null && itemList.Count > 0)
            //        //{
            //        //    string dateCol = string.Empty;
            //        //    foreach (MMOperationDetailPlanItemChildsInfo matchItem in itemList)
            //        //    {
            //        //        dateCol = matchItem.CapacityDate.Date.ToString("f", CultureInfo.CreateSpecificCulture("en-US"));
            //        //        if (dt.Columns[dateCol] != null)
            //        //        {
            //        //            newRow[dateCol] = matchItem.CapacityItemCompletedProductQty.ToString("N0");
            //        //        } 
            //        //    }

            //        //}   




            //        foreach (MMOperationsInfo operation in operationList)
            //        {
            //            double KLNhap = 0;
            //            double SLNhap = 0;
            //            double SLThieu = 0;
            //            matchList = odpicList.Where(t => t.MMOperationDetailPlanItemChildID == itemChildID
            //                                                    && t.MMOperationID == operation.MMOperationID).ToList();
            //            if (matchList != null && matchList.Count > 0)
            //            {

            //                SLNhap = matchList.Sum(i => i.CapacityItemCompletedProductQty);
            //                KLNhap = SLNhap * item.MMOperationDetailPlanItemChildBlockPerOne;
            //                SLThieu = item.MMOperationDetailPlanItemChildPlanProductQty - SLNhap;
            //                newRow["MMOperationDetailPlanItemOperationName"] = operation.MMOperationName;
            //            }
            //            if (SLNhap != 0)
            //                newRow["SLNhap_" + operation.MMOperationID] = SLNhap.ToString("N0");
            //            else
            //                newRow["SLNhap_" + operation.MMOperationID] = "-";

            //            if (KLNhap != 0)
            //                newRow["KLNhap_" + operation.MMOperationID] = KLNhap.ToString("N4");
            //            else
            //                newRow["KLNhap_" + operation.MMOperationID] = "-";

            //            if (SLThieu != 0)
            //                newRow["SLThieu_" + operation.MMOperationID] = SLThieu.ToString("N0");
            //            else
            //                newRow["SLThieu_" + operation.MMOperationID] = "-";
            //        }
            //    }
            //    dt.Rows.Add(newRow);
            //}

        }

        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();

            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = false;

            //Thông tin
            GridBand gridBand = CreateNewGridBand("ICProductGroupName", ReportLocalizedResources.ICProductGoupInfo);
            bandedView.Bands.Add(gridBand);

            BandedGridColumn gridColumnBatchProductNo = CreateNewColumn("BatchProductNo", "Mã KHSX (LSX)", gridBand);
            BandedGridColumn gridColumnProductNo = CreateNewColumn("ProductNo", "Mã SP", gridBand);
            BandedGridColumn gridColumnProductName = CreateNewColumn("ProductName", "Tên SP", gridBand);
            BandedGridColumn gridColumnOperationName = CreateNewColumn("OperationName", "Công đoạn", gridBand);
            BandedGridColumn gridColumnStockName = CreateNewColumn("StockName", "Kho", gridBand);
            BandedGridColumn gridColumnBatchProductQty = CreateNewColumn("BatchProductQty", "SL theo KHSX", gridBand);
            BandedGridColumn gridColumnBlock = CreateNewColumn("Block", "m3 tinh", gridBand);
            BandedGridColumn gridColumnPaint = CreateNewColumn("Paint", "m2 sơn", gridBand);

            bandedView.Columns.Add(gridColumnBatchProductNo);
            bandedView.Columns.Add(gridColumnProductNo);
            bandedView.Columns.Add(gridColumnProductName);
            bandedView.Columns.Add(gridColumnOperationName);
            bandedView.Columns.Add(gridColumnStockName);
            bandedView.Columns.Add(gridColumnBatchProductQty);
            bandedView.Columns.Add(gridColumnBlock);
            bandedView.Columns.Add(gridColumnPaint);

            gridColumnBatchProductNo.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridColumnBatchProductNo.SortIndex = 1;


            gridColumnProductNo.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridColumnProductNo.SortIndex = 2;

            gridColumnOperationName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridColumnOperationName.SortIndex = 3;

            gridColumnStockName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridColumnStockName.SortIndex = 4;


            gridBand.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridBand.MinWidth = 150;

            // nhập
            GridBand band = CreateNewGridBand("Receipt", "NHẬP");
            BandedGridColumn gridColumnReceiptQty = CreateNewColumn("ReceiptQty", "SL", band);
            BandedGridColumn gridColumnReceiptAmount = CreateNewColumn("ReceiptAmount", "GIÁ TRỊ", band);
            gridColumnReceiptAmount.DisplayFormat.FormatString = "{0:n4}";
            gridColumnReceiptAmount.DisplayFormat.FormatType = FormatType.Numeric;
            bandedView.Bands.Add(band);
            bandedView.Columns.Add(gridColumnReceiptQty);
            bandedView.Columns.Add(gridColumnReceiptAmount);

            // xuất
            GridBand band2 = CreateNewGridBand("Shipment", "XUẤT");
            BandedGridColumn gridColumnShipmentQty = CreateNewColumn("ShipmentQty", "SL", band2);
            BandedGridColumn gridColumnShipmentAmount = CreateNewColumn("ShipmentAmount", "GIÁ TRỊ", band2);
            gridColumnShipmentAmount.DisplayFormat.FormatString = "{0:n4}";
            gridColumnShipmentAmount.DisplayFormat.FormatType = FormatType.Numeric;
            bandedView.Bands.Add(band2);
            bandedView.Columns.Add(gridColumnShipmentQty);
            bandedView.Columns.Add(gridColumnShipmentAmount);

            // tồn
            GridBand band3 = CreateNewGridBand("Inventory", "TỒN");
            BandedGridColumn gridColumnInventoryQty = CreateNewColumn("InventoryQty", "SL", band3);
            BandedGridColumn gridColumnInventoryAmount = CreateNewColumn("InventoryAmount", "GIÁ TRỊ", band3);
            gridColumnInventoryAmount.DisplayFormat.FormatString = "{0:n4}";
            gridColumnInventoryAmount.DisplayFormat.FormatType = FormatType.Numeric;
            bandedView.Bands.Add(band3);
            bandedView.Columns.Add(gridColumnInventoryQty);
            bandedView.Columns.Add(gridColumnInventoryAmount);

            bandedView.OptionsView.ShowAutoFilterRow = true;
            bandedView.OptionsView.ShowFooter = true;


            //  bandedView.OptionsView.ShowDetailButtons = true;
            return bandedView;
        }
        List<MMBatchProductProductionNormItemsInfo> BlockPaintList = new List<MMBatchProductProductionNormItemsInfo>();
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);

            int BatchProductID = 0;
            int ProductID = 0;



            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            if (fld_lkeICProductID.EditValue != null)
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out ProductID);

            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            DataTable ResultTable = InitDataTable();




            ADReportsController reportController = new ADReportsController();

            BlockPaintList = reportController.GetBPPNIBlockAndPaint(BatchProductID, FromDate, ToDate, ProductID);

            BOSProgressBar.Start("Nhập xuất phách");
            DataSet LumberDS = reportController.GetLumberReceiptShipmentForRP156(BatchProductID, FromDate, ToDate);

            if (LumberDS != null && LumberDS.Tables.Count > 0)
            {
                ResultTable.Merge(LumberDS.Tables[0]);
            }

            MMBatchProductsController bpController = new MMBatchProductsController();
            //MMBatchProductProductionNormItemsController bppniController = new MMBatchProductProductionNormItemsController();
            //List<MMBatchProductsInfo> BPList = new List<MMBatchProductsInfo>();
            //if (BatchProductID == 0)
            //{

            //    BPList = bpController.GetAllObject();
            //}
            //else
            //{
            //    MMBatchProductsInfo bpInfo = (MMBatchProductsInfo)bpController.GetObjectByID(BatchProductID);
            //    if (bpInfo != null)
            //    {
            //        BPList.Add(bpInfo);
            //    }
            //}
            //foreach (MMBatchProductsInfo bp in BPList)
            //{
            BOSProgressBar.Start("Nhập xuất vật tư");
            DataSet MaterialNotInBPDS = reportController.GetMaterialReceiptShipmentForRP156NotInBP(BatchProductID, FromDate, ToDate);
            if (MaterialNotInBPDS != null && MaterialNotInBPDS.Tables.Count > 0)
            {
                ResultTable.Merge(MaterialNotInBPDS.Tables[0]);
            }
            DataSet MaterialNotInBPDS2 = reportController.GetMaterialReceiptShipmentForRP156NotInBP2(BatchProductID, FromDate, ToDate);
            if (MaterialNotInBPDS2 != null && MaterialNotInBPDS2.Tables.Count > 0)
            {
                ResultTable.Merge(MaterialNotInBPDS2.Tables[0]);
            }

            BOSProgressBar.Start("Nhập xuất BTP");
            DataSet BTPReceiptDS = reportController.GetBTPHaveReceiptForRP156(BatchProductID, FromDate, ToDate, ProductID);

            //if (BTPReceiptDS != null && BTPReceiptDS.Tables.Count > 0)
            //{

            //   // ResultTable.Merge(BTPReceiptDS.Tables[0]);
            //}

            DataSet BTPShipmentDS = reportController.GetBTPHaveShipmentForRP156(BatchProductID, FromDate, ToDate, ProductID);
            //if (BTPShipmentDS != null && BTPShipmentDS.Tables.Count > 0)
            //{
            BTPReceiptDS.Merge(BTPShipmentDS);

            CalculateInventory(ref BTPReceiptDS);
            ResultTable.Merge(BTPReceiptDS.Tables[0]);
            //}

            DataSet BTPNoneReceiptShipmentDS = reportController.GetBTPNotHaveReceiptShipmentForRP156(BatchProductID, FromDate, ToDate, ProductID);
            if (BTPNoneReceiptShipmentDS != null && BTPNoneReceiptShipmentDS.Tables.Count > 0)
            {
                ResultTable.Merge(BTPNoneReceiptShipmentDS.Tables[0]);
            }

            BOSProgressBar.Start("Nhập xuất TP");

            DataSet TPReceiptDS = reportController.GetTPHaveReceiptForRP156(BatchProductID, FromDate, ToDate, ProductID);
            //if (TPReceiptDS != null && TPReceiptDS.Tables.Count > 0)
            //{
            // //   CalculateInventory(ref TPReceiptDS);
            //    ResultTable.Merge(TPReceiptDS.Tables[0]);

            //}

            DataSet TPShipmentDS = reportController.GetTPHaveShipmentForRP156(BatchProductID, FromDate, ToDate, ProductID);
            //if (TPShipmentDS != null && TPShipmentDS.Tables.Count > 0)
            //{
            TPReceiptDS.Merge(TPShipmentDS);
            CalculateInventory(ref TPReceiptDS);
            ResultTable.Merge(TPReceiptDS.Tables[0]);
            // }

            DataSet TPNoneReceiptShipmentDS = reportController.GetTPNotHaveReceiptShipmentForRP156(BatchProductID, FromDate, ToDate, ProductID);
            if (TPNoneReceiptShipmentDS != null && TPNoneReceiptShipmentDS.Tables.Count > 0)
            {
                ResultTable.Merge(TPNoneReceiptShipmentDS.Tables[0]);
            }

            //}

            // fld_dgcSynchronousData.InitializeControl();



            fld_dgcSynchronousData.DataSource = ResultTable;

            //GridView gridView = (GridView)fld_dgcSynchronousData.MainView;
            //gridView.ExpandAllGroups();
            //gridView.BestFitColumns();

            BOSProgressBar.Close();
        }
        List<RP156Object> ObjectList = new List<RP156Object>();

        public bool IsExistInObjectList(string key)
        {
            bool isExist = false;

            if (ObjectList.FirstOrDefault(t => t.Key == key) == null)
            {
                isExist = false;
            }
            else
            {
                isExist = true;
            }

            return isExist;
        }

        public void CalculateInventory(ref DataSet ds)
        {

            if (ds != null && ds.Tables.Count > 0)
            {
                ObjectList = new List<RP156Object>();
                ds.Tables[0].DefaultView.Sort = "BatchProductNo, ProductNo, StockName, TypeCombo ASC";
                foreach (DataRowView drv in ds.Tables[0].DefaultView)
                {
                    DataRow dr = drv.Row;

                    MMBatchProductProductionNormItemsInfo item = BlockPaintList.FirstOrDefault(i => i.MMBatchProductNo == dr["BatchProductNo"].ToString()
                                                                                                && i.ProductNo == dr["ProductNo"].ToString());
                    if (item != null)
                    {
                        dr["BatchProductQty"] = item.MMBatchProductProductionNormItemQuantity;
                        dr["Block"] = item.MMBatchProductProductionNormItemBlocks;
                        dr["Paint"] = item.MMBatchProductProductionNormItemPaint;
                    }


                    string key = dr["BatchProductNo"].ToString() + "_" + dr["ProductNo"].ToString() + "_" + dr["StockName"].ToString();
                    if (!IsExistInObjectList(key))
                    {
                        if (dr["TypeCombo"].ToString() == "Receipt")
                        {
                            RP156Object obj = new RP156Object(key, double.Parse(dr["ReceiptQty"].ToString()), double.Parse(dr["ReceiptAmount"].ToString()));
                            if (obj != null)
                            {
                                ObjectList.Add(obj);
                                dr["InventoryQty"] = obj.Qty;
                                dr["InventoryAmount"] = obj.Amount;
                            }
                        }
                        else
                        {
                            RP156Object obj = new RP156Object(key, -double.Parse(dr["ShipmentQty"].ToString()), -double.Parse(dr["ShipmentAmount"].ToString()));
                            if (obj != null)
                            {
                                ObjectList.Add(obj);
                                dr["InventoryQty"] = obj.Qty;
                                dr["InventoryAmount"] = obj.Amount;
                            }
                        }
                    }
                    else
                    {
                        foreach (RP156Object obj in ObjectList)
                        {
                            if (obj.Key == key)
                            {
                                if (dr["TypeCombo"].ToString() == "Receipt")
                                {
                                    obj.Amount += double.Parse(dr["ReceiptAmount"].ToString());
                                    obj.Qty += double.Parse(dr["ReceiptQty"].ToString());
                                }
                                else
                                {
                                    obj.Amount -= double.Parse(dr["ShipmentAmount"].ToString());
                                    obj.Qty -= double.Parse(dr["ShipmentQty"].ToString());
                                }
                                dr["InventoryQty"] = obj.Qty;
                                dr["InventoryAmount"] = obj.Amount;
                                break;
                            }
                        }
                    }
                }
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

        private void fld_lkeMMOperationDetailPlanID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int BatchProductID = 0;
            int OperationID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);

            //MMOperationDetailPlansController OperationDetailPlansController = new MMOperationDetailPlansController();
            //List<MMOperationDetailPlansInfo> operationDetailPlanList = OperationDetailPlansController.GetPlanByBatchProductIDAndOperationID(BatchProductID, OperationID);
            //List<MMOperationDetailPlansInfo> result = new List<MMOperationDetailPlansInfo>();
            //result.Add(new MMOperationDetailPlansInfo());
            //result.AddRange(operationDetailPlanList);

            //fld_lkeMMOperationDetailPlanID.Properties.DataSource = result;
        }

        private void fld_lkeICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int BatchProductID = 0;
            // int DetailPlanID = 0;
            // if (fld_lkeMMOperationDetailPlanID.EditValue != null)
            //     int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out DetailPlanID);
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out BatchProductID);
            List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
            ADReportsController objProductsController = new ADReportsController();
            ListProduct = objProductsController.GetProductByBatchProductID(BatchProductID);
            fld_lkeICProductID.Properties.DataSource = ListProduct;
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

    public class RP156Object
    {
        public string Key;
        public double Qty;
        public double Amount;

        public RP156Object(string key, double qty, double amount)
        {
            this.Key = key;
            this.Qty = qty;
            this.Amount = amount;
        }
    }
}