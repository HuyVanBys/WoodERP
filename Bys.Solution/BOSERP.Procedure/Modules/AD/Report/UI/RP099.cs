using BOSLib;
using DevExpress.Export;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP099 : ReportForm
    {
        #region Variables
        private int ICProductGroupID = 0;

        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        //private DataTable ReportDataSource;
        #endregion

        public RP099()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeFK_ACObjectID.BOSModuleType = "Invoice";
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate().AddMonths(-2);
            fld_dteToDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_lblBranchName.Text = string.Empty;
            //ShowReportData();
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
            if (fld_dteFromDate.DateTime != DateTime.MaxValue && fld_dteToDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            //int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            DateTime from = Convert.ToDateTime(fld_dteFromDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteToDate.EditValue);
            //List<ARCustomersInfo> customerList = GetcustomerList();

            //fld_dgcARRP099InvoiceItems.DataSource = customerList;
            DataTable dt = InitReportDataSource();
            fld_dgcARRP099InvoiceItems.AddDataSource(dt, from, to);
            fld_dgcARRP099InvoiceItems.RefreshDataSource();
            GridView gridView = (GridView)fld_dgcARRP099InvoiceItems.MainView;
            gridView.ExpandAllGroups();
            fld_lblBranchName.Text = string.Empty;
            BRBranchsController objBranchsController = new BRBranchsController();
            fld_lblBranchName.Text = fld_lkeFK_ACObjectID.Text;
            string txtfrom = String.Format("{0:MM/yyyy}", from);
            string txtto = String.Format("{0:MM/yyyy}", to);
            fld_lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromMonth, txtfrom,
                                                                                        ReportLocalizedResources.ToMonth, txtto);
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Get product group filter list
        /// </summary>
        /// <returns>The list of product group filter</returns>
        private List<ARCustomersInfo> GetcustomerList()
        {
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                if (objectKey.Count() == 2)
                {
                    objectID = Convert.ToInt32(objectKey[0]);
                    objectType = objectKey[1];
                }
            }

            //int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            int productGroupID = ICProductGroupID;
            ADReportsController objReportsController = new ADReportsController();

            DateTime from = Convert.ToDateTime(fld_dteFromDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteToDate.EditValue);

            List<ARCustomersInfo> CustomersInfo = objReportsController.GetTotalOrderQtAndTotalOrderAmountByObject(from, to, objectID, objectType);

            return CustomersInfo;
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBranchName.Text, 1, 5));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 5));
            return lstHeaderParameter;
        }
        #endregion

        /// <summary>
        /// Get report table
        /// </summary>
        /// <param name="productRows">List of product group filter</param>
        /// <param name="from">The invoice date from</param>
        /// <param name="to">The invoice date to</param>
        /// <returns>The data table</returns>
        public DataTable GetReportTable(DateTime from, DateTime to)
        {
            DataTable dataSource = new DataTable();
            DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
            DateTime index = new DateTime(from.Year, from.Month, 1);

            dataSource.Columns.Add(new DataColumn("ARCustomerName"));
            dataSource.Columns.Add(new DataColumn("Form"));
            dataSource.Columns.Add(new DataColumn("TotalInvoiceAmount", typeof(decimal)));
            dataSource.Columns.Add(new DataColumn("TotalPaymentAmount", typeof(decimal)));

            while (index <= to)
            {
                string quantityColumnName = "InvoiceAmount_" + index.ToString("MM/yyyy");
                dataSource.Columns.Add(new DataColumn(quantityColumnName, typeof(decimal)));
                string totalColumnName = "PaymentAmount_" + index.ToString("MM/yyyy");
                dataSource.Columns.Add(new DataColumn(totalColumnName, typeof(decimal)));
                index = index.AddMonths(1);
            }

            return dataSource;
        }

        private List<string> DistinctCustomerNos(List<ARCustomersInfo> customerList)
        {
            List<string> customerNos = new List<string>();
            if (customerList != null)
            {
                foreach (ARCustomersInfo customer in customerList)
                {
                    if (!customerNos.Contains(customer.ARCustomerNo))
                        customerNos.Add(customer.ARCustomerNo);
                }
            }

            return customerNos;
        }

        public DataTable InitReportDataSource()
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            //int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);

            List<ARCustomersInfo> customerList = GetcustomerList();
            DataTable reportDataSource = GetReportTable(fromDate, toDate);

            List<string> customerNos = DistinctCustomerNos(customerList);


            foreach (string customerNo in customerNos)
            {
                DataRow row = reportDataSource.NewRow();
                List<ARCustomersInfo> tempList = customerList.Where(item => item.ARCustomerNo == customerNo).ToList();

                if (tempList != null && tempList.Count != 0)
                {
                    row["ARCustomerName"] = tempList[0].ARCustomerName;
                    row["Form"] = string.Empty;
                    decimal totalInvoiceAmount = tempList.Where(item => item.IsInvoiceTotalAmount == true).Sum(item1 => item1.TotalAmount);
                    decimal totalPaymentAmount = tempList.Where(item => item.IsInvoiceTotalAmount == false).Sum(item1 => item1.TotalAmount);
                    row["TotalInvoiceAmount"] = totalInvoiceAmount;
                    row["TotalPaymentAmount"] = totalPaymentAmount;

                    DateTime index = new DateTime(fromDate.Year, fromDate.Month, 1);
                    while (index <= toDate)
                    {
                        ARCustomersInfo foundInvoiceItem = tempList.FirstOrDefault(item => item.Date.ToString("MM/yyyy") == index.ToString("MM/yyyy") && item.IsInvoiceTotalAmount == true);
                        ARCustomersInfo foundPaymentItem = tempList.FirstOrDefault(item => item.Date.ToString("MM/yyyy") == index.ToString("MM/yyyy") && item.IsInvoiceTotalAmount == false);
                        if (foundInvoiceItem != null)
                        {
                            string quantityColumnName = "InvoiceAMount_" + index.ToString("MM/yyyy");
                            row[quantityColumnName] = foundInvoiceItem.TotalAmount;
                        }
                        if (foundPaymentItem != null)
                        {
                            string quantityColumnName = "PaymentAMount_" + index.ToString("MM/yyyy");
                            row[quantityColumnName] = foundPaymentItem.TotalAmount;
                        }
                        index = index.AddMonths(1);
                    }
                }

                reportDataSource.Rows.Add(row);
            }

            return reportDataSource;
        }

        private void fld_btnExportexcel_Click(object sender, EventArgs e)
        {
            //GridView gridView = (GridView)fld_dgcARRP099InvoiceItems.MainView;
            //ExportToExcel(gridView);

            DevExpress.Export.ExportSettings.DefaultExportType = ExportType.DataAware;
            XlsxExportOptionsEx options = new XlsxExportOptionsEx();
            options.CustomizeSheetHeader += options_CustomizeSheetHeader;

            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView = (DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)fld_dgcARRP099InvoiceItems.MainView;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Tệp Excel (.xls)|*.xls|All files (.*)|*.*";
            saveDialog.FilterIndex = 2;
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridView.ExportToXlsx(saveDialog.FileName + ".xlsx", options);
                //System.Diagnostics.Process.Start(file);
            }
        }

        void options_CustomizeSheetHeader(DevExpress.Export.ContextEventArgs e)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;

            TimeSpan ts = toDate - fromDate;
            int monthCount = (int)(ts.TotalDays / 30);

            // Create a new row.
            CellObject row = new CellObject();
            // Specify row values.
            row.Value = fld_lblTitle.Text + " " + fld_lblBranchName.Text;
            // Specify row formatting.
            XlFormattingObject rowFormatting = new XlFormattingObject();
            rowFormatting.Font = new XlCellFont { Bold = true, Size = 14 };
            rowFormatting.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row.Formatting = rowFormatting;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row });

            CellObject row1 = new CellObject();
            // Specify row values.
            row1.Value = fld_lbl_FromdateTodate.Text;
            // Specify row formatting.
            XlFormattingObject rowFormatting1 = new XlFormattingObject();
            rowFormatting1.Font = new XlCellFont { Bold = true, Size = 12 };
            rowFormatting1.Alignment = new DevExpress.Export.Xl.XlCellAlignment { HorizontalAlignment = DevExpress.Export.Xl.XlHorizontalAlignment.Center, VerticalAlignment = DevExpress.Export.Xl.XlVerticalAlignment.Top };
            row1.Formatting = rowFormatting1;
            // Add the created row to the output document.
            e.ExportContext.AddRow(new[] { row1 });

            // Add an empty row to the output document.
            e.ExportContext.AddRow();
            // Merge cells of two new rows. 
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 0), new DevExpress.Export.Xl.XlCellPosition(5 + monthCount * 2, 1)));
            e.ExportContext.MergeCells(new DevExpress.Export.Xl.XlCellRange(new DevExpress.Export.Xl.XlCellPosition(0, 1), new DevExpress.Export.Xl.XlCellPosition(5 + monthCount * 2, 2)));
        }

    }

}