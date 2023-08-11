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
    public partial class RP121N : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;
        public List<ARSaleOrdersInfo> SaleOrderList;
        public RP121N()
        {
            InitializeComponent();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
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

                    fld_dgcRP121NARSaleOrders.ExportToXlsx(fileName);
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            //if (fld_lkeFK_ACObjectID.EditValue == null || fld_lkeFK_ACObjectID.EditValue.ToString() == "0")
            //{
            //    MessageBox.Show(ReportLocalizedResources.NeedSelectCustomerBeforeView,
            //                        ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            int customerID = 0;
            int saleOrderID = 0;
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            if (fld_txtARSaleOrderID.EditValue != null)
                int.TryParse(fld_txtARSaleOrderID.EditValue.ToString(), out saleOrderID);
            ADReportsController objReportsController = new ADReportsController();
            List<ARSaleOrdersInfo> saleOrderList = objReportsController.GetSaleOrderForDebtReport(objectID, objectType, searchFromDate, searchToDate, saleOrderID);
            List<ARInvoiceTransactionsInfo> documentList = objReportsController.GetInvoiceAndDepositBySaleOrderID(objectID, objectType, searchFromDate, searchToDate, saleOrderID);

            int countPayment = 1;
            List<string> documentType = new List<string>();
            //documentType.Add("Deposit");
            //documentType.Add("Payment");
            documentType.Add("Invoice");
            List<ARInvoiceTransactionsInfo> filterList = new List<ARInvoiceTransactionsInfo>();
            List<ARInvoiceTransactionsInfo> filterInvoiceList = new List<ARInvoiceTransactionsInfo>();
            List<int> saleOrderIDList = new List<int>();
            List<string> invoiceNoList = new List<string>();

            foreach (string type in documentType)
            {
                filterList = documentList.Where(t => t.DocumentType == type).ToList();
                if (filterList != null)
                {
                    saleOrderIDList = filterList.Select(t => t.FK_ARSaleOrderID).Distinct().ToList();
                    if (saleOrderIDList != null)
                    {
                        foreach (int soID in saleOrderIDList)
                        {
                            invoiceNoList = filterList.Where(t => t.FK_ARSaleOrderID == soID).Select(t => t.ARInvoiceNo).Distinct().ToList();
                            if (invoiceNoList != null)
                            {
                                foreach (string invoiceNo in invoiceNoList)
                                {
                                    filterInvoiceList = filterList.Where(t => t.ARInvoiceNo == invoiceNo && t.FK_ARSaleOrderID == soID).ToList();
                                    if (filterInvoiceList != null && filterInvoiceList.Count > countPayment)
                                    {
                                        countPayment = filterInvoiceList.Count;
                                    }
                                }

                            }
                        }
                    }
                }
            }
            DataTable dt = CreateDataTable(countPayment);
            FillDataTable(countPayment, saleOrderList, documentList, dt);

            GridView gridView = (GridView)fld_dgcRP121NARSaleOrders.MainView;
            fld_dgcRP121NARSaleOrders.MainView = InitializeCustomerBandedGridView(gridView, countPayment);

            fld_dgcRP121NARSaleOrders.DataSource = dt;
            BandedGridView gv = (BandedGridView)fld_dgcRP121NARSaleOrders.MainView;
            gv.BestFitColumns();
        }
        public DataTable CreateDataTable(int countPayment)
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ARSaleOrderNo", typeof(string));
            dataTable.Columns.Add("ARSaleOrderTotalAmount", typeof(decimal));
            dataTable.Columns.Add("ARSaleOrderDate", typeof(DateTime));
            dataTable.Columns.Add("ARSaleOrderPONo", typeof(string));
            dataTable.Columns.Add("ARCustomerNo", typeof(string));
            dataTable.Columns.Add("ARCustomerName", typeof(string));

            dataTable.Columns.Add("DepositAmount", typeof(decimal));
            dataTable.Columns.Add("DepositDueDate", typeof(DateTime));
            dataTable.Columns.Add("DepositPaymentAmount", typeof(decimal));
            dataTable.Columns.Add("DepositPaymentDate", typeof(DateTime));
            dataTable.Columns.Add("DepositLateDate", typeof(int));

            dataTable.Columns.Add("ICShipmentProposalNo", typeof(string));
            dataTable.Columns.Add("InvoiceNo", typeof(string));
            dataTable.Columns.Add("InvoiceDate", typeof(DateTime));
            dataTable.Columns.Add("ARInvoiceTotalAmount", typeof(decimal));
            dataTable.Columns.Add("PaymentDueDate", typeof(DateTime));
            dataTable.Columns.Add("PaymentDueAmount", typeof(decimal));
            dataTable.Columns.Add("PaymentLeft", typeof(decimal));
            for (int i = 1; i <= countPayment; i++)
            {
                dataTable.Columns.Add("PaymentDate_" + i, typeof(DateTime));
                dataTable.Columns.Add("PaymentAmount_" + i, typeof(decimal));
                dataTable.Columns.Add("PaymentLateDate_" + i, typeof(int));
            }

            dataTable.Columns.Add("ARSaleOrderTotalPaidAmount", typeof(decimal));
            dataTable.Columns.Add("ARSaleOrderTotalAmountDiff", typeof(decimal));
            dataTable.Columns.Add("ARSaleOrderReportStatus", typeof(string));


            return dataTable;
        }
        public void FillDataTable(int countPayment, List<ARSaleOrdersInfo> saleOrderList, List<ARInvoiceTransactionsInfo> documents, DataTable dt)
        {
            List<ARInvoiceTransactionsInfo> filterList;
            List<ARInvoiceTransactionsInfo> filterInvoiceList;
            foreach (ARSaleOrdersInfo saleOrder in saleOrderList)
            {
                filterList = documents.Where(t => t.FK_ARSaleOrderID == saleOrder.ARSaleOrderID).ToList();
                if (filterList != null)
                {
                    decimal sumOfPayment = filterList.Sum(t => t.PaymentAmount);
                    decimal amountDiff = saleOrder.ARSaleOrderTotalAmount - sumOfPayment;

                    filterList = filterList.OrderBy(t => t.DocumentType)
                                            .ThenBy(t => t.ARInvoiceNo)
                                            .ThenBy(t => t.PaymentDate).ToList();
                    List<string> distinctInvoiceNo = new List<string>();
                    foreach (ARInvoiceTransactionsInfo document in filterList)
                    {
                        if (document.DocumentType == "Deposit")
                        {
                            DataRow dr = dt.NewRow();
                            dr["ARSaleOrderNo"] = saleOrder.ARSaleOrderNo;
                            dr["ARSaleOrderTotalAmount"] = saleOrder.ARSaleOrderTotalAmount;
                            dr["ARSaleOrderDate"] = saleOrder.ARSaleOrderDate;
                            dr["ARSaleOrderPONo"] = saleOrder.ARSaleOrderPONo;
                            dr["ARCustomerNo"] = saleOrder.ARCustomerNo;
                            dr["ARCustomerName"] = saleOrder.ARCustomerName;
                            dr["DepositAmount"] = document.PaymentDueAmount;
                            dr["DepositDueDate"] = document.PaymentDueDate;
                            dr["DepositPaymentDate"] = document.PaymentDate;
                            dr["DepositPaymentAmount"] = document.PaymentAmount;
                            int lateDate = (document.PaymentDate - document.PaymentDueDate).Days;
                            if (lateDate > 0)
                            {
                                dr["DepositLateDate"] = lateDate;
                            }
                            dr["ICShipmentProposalNo"] = document.ShipmentProposalNo;
                            dr["InvoiceNo"] = document.ARInvoiceNo;
                            dr["InvoiceDate"] = document.ARInvoiceDate;
                            dr["ARInvoiceTotalAmount"] = document.ARInvoiceAmount;
                            //dr["PaymentDueDate"] = document.ARInvoiceTotalAmount;
                            // dr["PaymentDueAmount"] = 0;
                            dr["ARSaleOrderTotalPaidAmount"] = sumOfPayment;
                            dr["ARSaleOrderTotalAmountDiff"] = amountDiff;

                            if (document.PaymentDueAmount > document.PaymentAmount)
                            {
                                if (amountDiff > 0 || (amountDiff == 0 && saleOrder.ARSaleOrderTotalAmount == 0))
                                {
                                    dr["ARSaleOrderReportStatus"] = "Đang thực hiện";
                                }
                                else
                                {
                                    dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                                }
                            }
                            else
                            {
                                dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                            }

                            dt.Rows.Add(dr);
                        }
                        else if (document.DocumentType == "Payment")
                        {
                            DataRow dr = dt.NewRow();
                            dr["ARSaleOrderNo"] = saleOrder.ARSaleOrderNo;
                            dr["ARSaleOrderTotalAmount"] = saleOrder.ARSaleOrderTotalAmount;
                            dr["ARSaleOrderDate"] = saleOrder.ARSaleOrderDate;
                            dr["ARSaleOrderPONo"] = saleOrder.ARSaleOrderPONo;
                            dr["ARCustomerNo"] = saleOrder.ARCustomerNo;
                            dr["ARCustomerName"] = saleOrder.ARCustomerName;
                            dr["PaymentDueAmount"] = document.PaymentDueAmount;
                            dr["PaymentDueDate"] = document.PaymentDueDate;
                            dr["PaymentDate_1"] = document.PaymentDate;
                            dr["PaymentAmount_1"] = document.PaymentAmount;
                            int lateDate = (document.PaymentDate - document.PaymentDueDate).Days;
                            if (lateDate > 0)
                            {
                                dr["PaymentLateDate_1"] = lateDate;
                            }

                            dr["ICShipmentProposalNo"] = document.ShipmentProposalNo;
                            dr["InvoiceNo"] = document.ARInvoiceNo;
                            dr["InvoiceDate"] = document.ARInvoiceDate;
                            dr["ARInvoiceTotalAmount"] = document.ARInvoiceAmount;
                            //dr["PaymentDueDate"] = document.ARInvoiceTotalAmount;
                            // dr["PaymentDueAmount"] = 0;
                            dr["ARSaleOrderTotalPaidAmount"] = sumOfPayment;
                            dr["ARSaleOrderTotalAmountDiff"] = amountDiff;

                            if (document.PaymentDueAmount > document.PaymentAmount)
                            {
                                if (amountDiff > 0 || (amountDiff == 0 && saleOrder.ARSaleOrderTotalAmount == 0))
                                {
                                    dr["ARSaleOrderReportStatus"] = "Đang thực hiện";
                                }
                                else
                                {
                                    dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                                }
                            }
                            else
                            {
                                dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                            }

                            dt.Rows.Add(dr);
                        }
                        else if (document.DocumentType == "Invoice")
                        {
                            if (!distinctInvoiceNo.Contains(document.ARInvoiceNo))
                            {
                                filterInvoiceList = filterList.Where(t => t.ARInvoiceNo == document.ARInvoiceNo).ToList();
                                filterInvoiceList = filterInvoiceList.OrderBy(t => t.PaymentDate).ToList();

                                DataRow dr = dt.NewRow();
                                dr["ARSaleOrderNo"] = saleOrder.ARSaleOrderNo;
                                dr["ARSaleOrderTotalAmount"] = saleOrder.ARSaleOrderTotalAmount;
                                dr["ARSaleOrderDate"] = saleOrder.ARSaleOrderDate;
                                dr["ARSaleOrderPONo"] = saleOrder.ARSaleOrderPONo;
                                dr["ARCustomerNo"] = saleOrder.ARCustomerNo;
                                dr["ARCustomerName"] = saleOrder.ARCustomerName;
                                dr["PaymentDueAmount"] = document.PaymentDueAmount;
                                dr["PaymentDueDate"] = document.PaymentDueDate;

                                decimal paidAmount = 0;
                                if (filterInvoiceList.Count > 0)
                                {
                                    paidAmount = filterInvoiceList.Sum(t => t.PaymentAmount);
                                }

                                decimal paymentLeft = document.PaymentDueAmount - paidAmount;

                                dr["PaymentLeft"] = paymentLeft;

                                int countIndex = 1;
                                foreach (ARInvoiceTransactionsInfo doc in filterInvoiceList)
                                {
                                    dr["PaymentDate_" + countIndex] = doc.PaymentDate;
                                    dr["PaymentAmount_" + countIndex] = doc.PaymentAmount;
                                    int lateDate = (doc.PaymentDate - doc.PaymentDueDate).Days;
                                    if (lateDate > 0)
                                    {
                                        dr["PaymentLateDate_" + countIndex] = lateDate;
                                    }
                                    countIndex++;
                                }
                                dr["ICShipmentProposalNo"] = document.ShipmentProposalNo;
                                dr["InvoiceNo"] = document.ARInvoiceNo;
                                dr["InvoiceDate"] = document.ARInvoiceDate;
                                dr["ARInvoiceTotalAmount"] = document.ARInvoiceAmount;
                                //dr["PaymentDueDate"] = document.ARInvoiceTotalAmount;
                                // dr["PaymentDueAmount"] = 0;
                                dr["ARSaleOrderTotalPaidAmount"] = sumOfPayment;
                                dr["ARSaleOrderTotalAmountDiff"] = amountDiff;
                                decimal paymentAmount = filterInvoiceList.Sum(t => t.PaymentAmount);
                                if (document.PaymentDueAmount > paymentAmount)
                                {
                                    if (amountDiff > 0 || (amountDiff == 0 && saleOrder.ARSaleOrderTotalAmount == 0))
                                    {
                                        dr["ARSaleOrderReportStatus"] = "Đang thực hiện";
                                    }
                                    else
                                    {
                                        dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                                    }
                                }
                                else
                                {
                                    dr["ARSaleOrderReportStatus"] = "Hoàn tất";
                                }

                                dt.Rows.Add(dr);

                                distinctInvoiceNo.Add(document.ARInvoiceNo);
                            }
                        }
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
        public BandedGridView InitializeCustomerBandedGridView(GridView gridView, int countPayment)
        {

            BandedGridView bandedView = new BandedGridView();

            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowChildrenInGroupPanel = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsView.ShowFooter = true;
            //bandedView.OptionsView.ShowColumnHeaders = false;

            List<GridBand> GridBandList = new List<GridBand>();



            //1. Lot No
            GridBand sttBand = CreateGridBand("THÔNG TIN KHÁCH HÀNG", GridBandList);
            CreateBandedGridColumn("ARSaleOrderNo", "SỐ PI BÁN HÀNG", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARSaleOrderTotalAmount", "TỔNG TIỀN ĐƠN HÀNG", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARSaleOrderDate", "NGÀY ĐƠN HÀNG/ HỢP ĐỒNG", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARSaleOrderPONo", "SỐ PO/ HĐ", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerNo", "MÃ KHÁCH HÀNG", sttBand, bandedView, 50);
            CreateBandedGridColumn("ARCustomerName", "TÊN KHÁCH HÀNG", sttBand, bandedView, 50);

            GridBand depositBand = CreateGridBand("THÔNG TIN CỌC", GridBandList);
            CreateBandedGridColumn("DepositAmount", "SỐ TIỀN ĐẶT CỌC", depositBand, bandedView, 50);
            CreateBandedGridColumn("DepositDueDate", "NGÀY ĐẾN HẠN ĐẶT CỌC", depositBand, bandedView, 50);
            CreateBandedGridColumn("DepositPaymentAmount", "SỐ TIỀN THANH TOÁN CỌC", depositBand, bandedView, 50);
            CreateBandedGridColumn("DepositPaymentDate", "NGÀY THANH TOÁN CỌC THỰC TẾ", depositBand, bandedView, 50);
            CreateBandedGridColumn("DepositLateDate", "SỐ NGÀY TRỄ HẠN", depositBand, bandedView, 50);

            GridBand paymentBand = CreateGridBand("THÔNG TIN THANH TOÁN", GridBandList);
            CreateBandedGridColumn("ICShipmentProposalNo", "SỐ ĐNXK", paymentBand, bandedView, 50);
            CreateBandedGridColumn("InvoiceNo", "SỐ PG", paymentBand, bandedView, 50);
            CreateBandedGridColumn("InvoiceDate", "NGÀY PG", paymentBand, bandedView, 50);
            CreateBandedGridColumn("ARInvoiceTotalAmount", "SỐ TIỀN TRÊN PG", paymentBand, bandedView, 50);
            CreateBandedGridColumn("PaymentDueDate", "NGÀY ĐẾN HẠN THANH TOÁN", paymentBand, bandedView, 50);
            CreateBandedGridColumn("PaymentDueAmount", "SỐ TIỀN ĐẾN HẠN", paymentBand, bandedView, 50);
            CreateBandedGridColumn("PaymentLeft", "SỐ TIỀN PHẢI THU", paymentBand, bandedView, 50);
            for (int i = 1; i <= countPayment; i++)
            {
                CreateBandedGridColumn("PaymentDate_" + i, "NGÀY THANH TOÁN THỰC TẾ LẦN " + i, paymentBand, bandedView, 50);
                CreateBandedGridColumn("PaymentAmount_" + i, "SỐ TIỀN THANH TOÁN LẦN " + i, paymentBand, bandedView, 50);
                CreateBandedGridColumn("PaymentLateDate_" + i, "SỐ NGÀY TRỄ HẠN", paymentBand, bandedView, 50);
            }
            CreateBandedGridColumn("ARSaleOrderTotalPaidAmount", "TỔNG SỐ TIỀN THANH TOÁN CỦA PI", paymentBand, bandedView, 50);
            CreateBandedGridColumn("ARSaleOrderTotalAmountDiff", "CHÊNH LỆCH SỐ TIỀN GIỮA PI VÀ THỰC TẾ THU", paymentBand, bandedView, 50);
            CreateBandedGridColumn("ARSaleOrderReportStatus", "TÌNH TRẠNG THANH TOÁN", paymentBand, bandedView, 50);

            bandedView.Bands.AddRange(GridBandList.ToArray());
            bandedView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(bandedView_CustomColumnDisplayText);
            bandedView.BestFitColumns();
            return bandedView;
        }
        void bandedView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                string columnName = e.Column.FieldName;
                if (columnName == "ARSaleOrderTotalAmount"
                        || columnName == "DepositAmount"
                        || columnName == "DepositPaymentAmount"
                    || columnName == "ARInvoiceTotalAmount"
                    || columnName == "PaymentDueAmount"
                    || columnName == "ARSaleOrderTotalPaidAmount"
                    || columnName == "ARSaleOrderTotalAmountDiff"
                     || columnName == "PaymentLeft"
                    || columnName.Contains("PaymentAmount_"))
                {
                    double value = 0;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        double result = value % 1;
                        string formatN = "N";

                        int formatIndex = 0;
                        while (result % 1 != 0)
                        {
                            result *= 10;
                            formatIndex++;
                        }
                        if (formatIndex > 0)
                        {
                            formatIndex = 2;
                        }
                        formatN = "N" + formatIndex;


                        e.DisplayText = value.ToString(formatN);

                    }
                }
                else if (
                    columnName == "ARSaleOrderDate"
                    || columnName == "DepositDueDate"
                    || columnName == "DepositPaymentDate"
                    || columnName == "PaymentDueDate"
                    || columnName == "InvoiceDate"
                     || columnName.Contains("PaymentDate_"))
                {
                    DateTime dateValue = DateTime.Now;
                    if (DateTime.TryParse(e.Value.ToString(), out dateValue))
                    {
                        if (dateValue.ToString("yyyy") == "9999"
                            || dateValue.ToString("yyyy") == "0001"
                            || dateValue.ToString("yyyy") == "1900")
                        {
                            e.DisplayText = string.Empty;
                        }
                    }
                }
            }

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

            bandedLocation.OptionsColumn.ShowCaption = true;
            bandedView.Columns.Add(bandedLocation);

        }
        public decimal SumList(List<ARSaleOrdersInfo> SaleOrderList)
        {
            decimal SumCoc = 0;
            string saleOrderNo = string.Empty;
            if (SaleOrderList != null)
            {
                foreach (ARSaleOrdersInfo item in SaleOrderList)
                {
                    if (!saleOrderNo.Contains(item.ReportSaleOrderNo))
                    {
                        SumCoc += item.TienCoc;
                        saleOrderNo += item.ReportSaleOrderNo;
                    }
                }
            }
            return SumCoc;
        }
    }
}
