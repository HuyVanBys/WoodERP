using BOSCommon;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
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
    public partial class RP182 : ReportForm
    {
        #region Variables


        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        public DataTable InvoicetemDataTable;
        List<int> OperationIDList;
        #endregion

        public RP182()
        {
            InitializeComponent();
        }

        private void RP182_Load(object sender, EventArgs e)
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

        public void CreateBandedGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
        {
            BandedGridColumn bandedLocation = new BandedGridColumn();
            bandedLocation.Name = name;
            bandedLocation.Caption = caption;
            bandedLocation.FieldName = name;
            bandedLocation.Visible = true;
            bandedLocation.OptionsColumn.AllowEdit = false;
            bandedLocation.OwnerBand = ownerBand;

            bandedLocation.MinWidth = 100;
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
            bandedLocation.MinWidth = 100;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }

        public void CreateBandedPercentGridColumn(string name, string caption, GridBand ownerBand, BandedGridView bandedView)
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
            bandedLocation.MinWidth = 40;
            bandedView.Columns.Add(bandedLocation);

            bandedLocation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            bandedLocation.SummaryItem.DisplayFormat = "{0:n2}";
        }
        public DataTable ReportDataSource;
        public void NewDataTable(int countPaymentTime)
        {
            ReportDataSource = new DataTable();
            ReportDataSource.Columns.Add("APPurchaseOrderNo", typeof(string));
            ReportDataSource.Columns.Add("PurchaseTotalCost", typeof(decimal));
            ReportDataSource.Columns.Add("APInvoiceInContractDate", typeof(string));
            ReportDataSource.Columns.Add("APInvoiceInContractNo", typeof(string));
            ReportDataSource.Columns.Add("APSupplierNo", typeof(string));
            ReportDataSource.Columns.Add("APSupplierName", typeof(string));
            ReportDataSource.Columns.Add("APInvoiceInSupplierNo", typeof(string));
            ReportDataSource.Columns.Add("APInvoiceInVATDate", typeof(string));
            ReportDataSource.Columns.Add("APPurchaseOrderTotalCost", typeof(decimal));
            ReportDataSource.Columns.Add("APPurchaseOrderDeposit", typeof(decimal));


            for (int i = 1; i <= countPaymentTime; i++)
            {
                ReportDataSource.Columns.Add(i + "PaymentAmount", typeof(decimal));
                ReportDataSource.Columns.Add(i + "PaymentDueDate", typeof(string));
                ReportDataSource.Columns.Add(i + "PaymentRealDate", typeof(string));
            }
            ReportDataSource.Columns.Add("CLDate", typeof(string));
            ReportDataSource.Columns.Add("CLAMOUNT", typeof(decimal));
            ReportDataSource.Columns.Add("STATUS", typeof(string));
        }

        public void FillDataSourceTable(List<APPurchaseOrderPaymentTimesInfo> paymentTimeList)
        {
            ReportDataSource.Rows.Clear();

            List<int> purchaseOrderIDList = (List<int>)paymentTimeList.Select(t => t.APPurchaseOrderID).Distinct().ToList();

            APPurchaseOrderPaymentTimesInfo item;
            List<APPurchaseOrderPaymentTimesInfo> itemList;
            foreach (int id in purchaseOrderIDList)
            {
                item = paymentTimeList.FirstOrDefault(t => t.APPurchaseOrderID == id);

                DataRow row = ReportDataSource.NewRow();
                row["APPurchaseOrderNo"] = item.APPurchaseOrderNo;
                row["PurchaseTotalCost"] = item.PurchaseTotalCost;
                row["APInvoiceInContractDate"] = item.APInvoiceInContractDate;
                row["APInvoiceInContractNo"] = item.APInvoiceInContractNo;
                row["APSupplierNo"] = item.APSupplierNo;
                row["APSupplierName"] = item.APSupplierName;
                row["APInvoiceInSupplierNo"] = item.APInvoiceInSupplierNo;
                row["APInvoiceInVATDate"] = item.APInvoiceInVATDate;
                row["APPurchaseOrderTotalCost"] = item.APPurchaseOrderTotalCost;
                row["APPurchaseOrderDeposit"] = item.APPurchaseOrderDeposit;


                itemList = paymentTimeList.Where(t => t.APPurchaseOrderID == id).ToList().OrderBy(t => t.APPurchaseOrderPaymentTimeID).ToList();
                int count = 1;
                decimal TTamount = 0;
                int CLdate = 0;
                foreach (APPurchaseOrderPaymentTimesInfo itemDetail in itemList)
                {
                    if (ReportDataSource.Columns[count + "PaymentAmount"] != null)
                    {
                        row[count + "PaymentAmount"] = itemDetail.SupplierPaymentAmount;
                    }
                    if (ReportDataSource.Columns[count + "PaymentDueDate"] != null)
                    {
                        if (itemDetail.APPurchaseOrderPaymentTermRequest == PurchaseOrderPaymentTermRequest.Other.ToString())
                        {
                            if (itemDetail.APPurchaseOrderPaymentTimeDate.ToString("dd/MM/yyyy") != "01/01/1900" &&
                                itemDetail.APPurchaseOrderPaymentTimeDate.Date != DateTime.MaxValue.Date)
                                row[count + "PaymentDueDate"] = itemDetail.APPurchaseOrderPaymentTimeDate.ToString("dd/MM/yyyy");

                        }
                        else
                        {
                            if (itemDetail.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Deposit.ToString())
                            {
                                if (itemDetail.ARSaleOrderPaymentTimeDueDate.ToString("dd/MM/yyyy") != "01/01/1900" &&
                                itemDetail.ARSaleOrderPaymentTimeDueDate.Date != DateTime.MaxValue.Date)
                                    row[count + "PaymentDueDate"] = itemDetail.ARSaleOrderPaymentTimeDueDate.ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                if (itemDetail.APInvoiceInValidateDate.ToString("dd/MM/yyyy") != "01/01/1900" &&
                                itemDetail.APInvoiceInValidateDate.Date != DateTime.MaxValue.Date)
                                    row[count + "PaymentDueDate"] = itemDetail.APInvoiceInValidateDate.ToString("dd/MM/yyyy");
                            }
                        }
                    }
                    if (ReportDataSource.Columns[count + "PaymentRealDate"] != null)
                    {
                        if (itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "01/01/1900" &&
                                itemDetail.SupplierPaymentDate.Date == DateTime.MaxValue.Date)
                            row[count + "PaymentRealDate"] = itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy");
                    }
                    TTamount += itemDetail.SupplierPaymentAmount;
                    if (itemDetail.APPurchaseOrderPaymentTermRequest == PurchaseOrderPaymentTermRequest.Other.ToString())
                    {
                        if (itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "01/01/1900"
                                && itemDetail.APPurchaseOrderPaymentTimeDate.ToString("dd/MM/yyyy") != "31/12/9999"
                            && itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "31/12/9999"
                                && itemDetail.APPurchaseOrderPaymentTimeDate.ToString("dd/MM/yyyy") != "01/01/1900")
                        {
                            TimeSpan ts = itemDetail.SupplierPaymentDate - itemDetail.APPurchaseOrderPaymentTimeDate;
                            CLdate += ts.Days;
                        }
                    }
                    else
                    {
                        if (itemDetail.APPurchaseOrderPaymentTimePaymentType == PurchaseOrderPaymentTimePaymentType.Deposit.ToString())
                        {
                            if (itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "01/01/1900"
                                && itemDetail.ARSaleOrderPaymentTimeDueDate.ToString("dd/MM/yyyy") != "31/12/9999"
                                && itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "31/12/9999"
                                && itemDetail.ARSaleOrderPaymentTimeDueDate.ToString("dd/MM/yyyy") != "01/01/1900")
                            {
                                TimeSpan ts = itemDetail.SupplierPaymentDate - itemDetail.ARSaleOrderPaymentTimeDueDate;
                                CLdate += ts.Days;
                            }
                        }
                        else
                        {
                            if (itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "01/01/1900"
                                && itemDetail.APInvoiceInValidateDate.ToString("dd/MM/yyyy") != "31/12/9999"
                                && itemDetail.SupplierPaymentDate.ToString("dd/MM/yyyy") != "31/12/9999"
                                && itemDetail.APInvoiceInValidateDate.ToString("dd/MM/yyyy") != "01/01/1900")
                            {
                                TimeSpan ts = itemDetail.SupplierPaymentDate - itemDetail.APInvoiceInValidateDate;
                                CLdate += ts.Days;
                            }
                        }

                    }
                    count++;
                }

                row["CLDate"] = CLdate;
                if (item.APPurchaseOrderTotalCost > 0)
                {
                    row["CLAMOUNT"] = (item.APPurchaseOrderTotalCost + item.APPurchaseOrderDeposit) - TTamount;
                }

                string status = string.Empty;

                if ((item.APPurchaseOrderTotalCost + item.APPurchaseOrderDeposit) == TTamount)
                {
                    status = "Xong";
                }
                if (TTamount == 0)
                {
                    status = "Chưa thực hiện";
                }
                else if (((item.APPurchaseOrderTotalCost + item.APPurchaseOrderDeposit) - TTamount) > 0)
                {
                    status = "Đang thực hiện";
                }
                row["STATUS"] = status;

                ReportDataSource.Rows.Add(row);
            }



        }

        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, int countPaymentTime)
        {

            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;

            List<GridBand> GridBandList = new List<GridBand>();




            //1. General information
            GridBand itemGridBandSelected = CreateGridBand("THÔNG TIN CHUNG", GridBandList);
            //itemGridBandSelected.Fixed = FixedStyle.Left;
            CreateBandedGridColumn("APPurchaseOrderNo", "MÃ ĐƠN MUA HÀNG", itemGridBandSelected, bandedView);
            CreateBandedNumbericN2GridColumn("PurchaseTotalCost", "TỔNG TIỀN ĐƠN HÀNG", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APInvoiceInContractDate", "NGÀY ĐƠN HÀNG/ HỢP ĐỒNG", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APInvoiceInContractNo", "SỐ ĐƠN HÀNG/ HỢP ĐỒNG", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APSupplierNo", "MÃ NCC", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APSupplierName", "TÊN NCC", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APInvoiceInSupplierNo", "SỐ HÓA ĐƠN", itemGridBandSelected, bandedView);
            CreateBandedGridColumn("APInvoiceInVATDate", "NGÀY HÓA ĐƠN", itemGridBandSelected, bandedView);
            CreateBandedNumbericN2GridColumn("APPurchaseOrderTotalCost", "TỔNG TIỀN HÓA ĐƠN", itemGridBandSelected, bandedView);
            CreateBandedNumbericN2GridColumn("APPurchaseOrderDeposit", "TIỀN CỌC", itemGridBandSelected, bandedView);
            //2. DETAIL
            GridBand itemGridBandTAVICO = CreateGridBand("CHI TIẾT", GridBandList);

            for (int i = 1; i <= countPaymentTime; i++)
            {
                CreateBandedNumbericN2GridColumn(i + "PaymentAmount", "SỐ TIỀN THANH TOÁN LẦN " + i, itemGridBandTAVICO, bandedView);
                CreateBandedGridColumn(i + "PaymentDueDate", "NGÀY ĐẾN HẠN THANH TOÁN LẦN " + i, itemGridBandTAVICO, bandedView);
                CreateBandedGridColumn(i + "PaymentRealDate", "NGÀY THANH TOÁN THỰC TẾ LẦN " + i, itemGridBandTAVICO, bandedView);
            }

            CreateBandedGridColumn("CLDate", "CHÊNH LỆCH SỐ NGÀY THANH TOÁN", itemGridBandTAVICO, bandedView);
            CreateBandedNumbericN2GridColumn("CLAMOUNT", "CHÊNH LỆCH SỐ TIỀN THANH TOÁN SO VỚI ĐƠN HÀNG", itemGridBandTAVICO, bandedView);
            CreateBandedGridColumn("STATUS", "TÌNH TRẠNG THANH TOÁN", itemGridBandTAVICO, bandedView);

            bandedView.Bands.AddRange(GridBandList.ToArray());

            ////bandedView.Columns["APPurchaseOrderNo"].Group();
            bandedView.ExpandAllGroups();
            bandedView.BestFitColumns();
            return bandedView;
        }
        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);

            int supplierID = 0;
            if (fld_lkeAPSupplierID.EditValue != null)
            {
                int.TryParse(fld_lkeAPSupplierID.EditValue.ToString(), out supplierID);
            }

            string purchaseOrderNo = string.Empty;
            if (fld_txtAPPurchaseOrderNo.EditValue != null)
            {
                purchaseOrderNo = fld_txtAPPurchaseOrderNo.EditValue.ToString();
            }

            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;

            APPurchaseOrderPaymentTimesController controller = new APPurchaseOrderPaymentTimesController();
            List<APPurchaseOrderPaymentTimesInfo> paymentTimeList = controller.GetDataForReport182(supplierID, purchaseOrderNo, fromDate, toDate);

            int maxCount = 0;
            if (paymentTimeList != null && paymentTimeList.Count > 0)
            {
                maxCount = paymentTimeList.Select(t => t.PaymentTimeCount).Max();
            }

            GridView bandView = (GridView)fld_dgcAPInvoiceInItems.MainView;
            fld_dgcAPInvoiceInItems.MainView = InitializeCustomerBandedGridView(bandView, maxCount);
            NewDataTable(maxCount);
            FillDataSourceTable(paymentTimeList);
            fld_dgcAPInvoiceInItems.DataSource = ReportDataSource;

            BandedGridView bandView2 = (BandedGridView)fld_dgcAPInvoiceInItems.MainView;

            bandView2.BestFitColumns();
            bandView2.ExpandAllGroups();
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

                    fld_dgcAPInvoiceInItems.ExportToXlsx(fileName);
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

        private void fld_lkeICProductSerieLotNo_Popup(object sender, EventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;


        }

        #region Initialize export excel parameter
        #endregion
    }

}