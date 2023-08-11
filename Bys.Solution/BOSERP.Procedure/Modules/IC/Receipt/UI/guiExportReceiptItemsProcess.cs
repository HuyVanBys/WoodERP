using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using BOSLib;
using BOSCommon.Extensions;

namespace BOSERP.Modules.Receipt
{
    public partial class guiExportReceiptItemsProcess : DevExpress.XtraEditors.XtraForm
    {
        private BackgroundWorker ExportWorker;

        private List<ICReceiptItemsInfo> ListReceiptItem;

        private string ReceiptNo { get; set; }

        public string FilePath { get; set; }

        public guiExportReceiptItemsProcess(List<ICReceiptItemsInfo> listItems, string receiptNo)
        {
            ListReceiptItem = listItems;
            ReceiptNo = receiptNo;
            InitializeComponent();

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            List<ICMeasureUnitsInfo> listMeasureUnitsInfo = objMeasureUnitsController.GetAllAliveMeasureUnit();
            ICProductsForViewInfo productsInfo = new ICProductsForViewInfo();

            List<ICStocksInfo> listStocksInfo = (new ICStocksController()).GetAllStocks();
            ICStocksInfo objStocksInfo = new ICStocksInfo();

            foreach (ICReceiptItemsInfo item in ListReceiptItem)
            {
                objMeasureUnitsInfo = listMeasureUnitsInfo.FirstOrDefault(o => o.ICMeasureUnitID == item.FK_ICMeasureUnitID);
                if(objMeasureUnitsInfo != null)
                {
                    item.ICMeasureUnitName = objMeasureUnitsInfo.ICMeasureUnitName;
                }
                else
                {
                    item.ICMeasureUnitName = string.Empty;
                }

                productsInfo = BOSApp.CurrentProductList.FirstOrDefault(o => o.ICProductID == item.FK_ICProductID);
                if(productsInfo != null)
                {
                    item.ICProductNo = productsInfo.ICProductNo;
                }
                else
                {
                    item.ICProductNo = string.Empty;
                }

                objStocksInfo = listStocksInfo.FirstOrDefault(o => o.ICStockID == item.FK_ICStockID);
                if (objStocksInfo != null)
                {
                    item.ICStockName = objStocksInfo.ICStockNo;
                }
                else
                {
                    item.ICStockName = string.Empty;
                }
            }    
        }

        private void guiExportReceiptItemsProcess_Load(object sender, EventArgs e)
        {
            ExportWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            ExportWorker.DoWork += new DoWorkEventHandler(ExportWorker_DoWork);
            ExportWorker.ProgressChanged += new ProgressChangedEventHandler(ExportWorker_ProgressChanged);
            ExportWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ExportWorker_RunWorkerCompleted);
            ExportWorker.RunWorkerAsync();
        }

        private void ExportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        private void ExportWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            fld_pgbProcessExport.EditValue = e.ProgressPercentage;
        }

        private void ExportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker background = sender as BackgroundWorker;
            background.ReportProgress(5);
            string documentPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BYSERP");
            if (!Directory.Exists(documentPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(documentPath);
            }
            FilePath = Path.Combine(documentPath, 
                string.Format("DanhSachSP_{0}_{1}.xlsx",
                ReceiptNo,
                DateTimeOffset.Now.ToUnixTimeSeconds()));
            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            xlApp.StandardFont = "Times New Roman";
            xlApp.StandardFontSize = 13;
            var header = worksheet.get_Range("A1", "K1");
            header.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(9, 132, 227));
            header.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            header.Font.Bold = true;
            header.Range["A1"].Value = "STT";
            header.Range["B1"].Value = "Mã sản phẩm (*)";
            header.Range["C1"].Value = "Mã SP đối tác";
            header.Range["D1"].Value = "Mã hệ thống cũ";
            header.Range["E1"].Value = "Tên sản phẩm";
            header.Range["F1"].Value = "Mô tả";
            header.Range["G1"].Value = "Đơn vị tính";
            header.Range["H1"].Value = "Số lượng";
            header.Range["I1"].Value = "Đơn giá";
            header.Range["J1"].Value = "Mã kho";
            header.Range["K1"].Value = "Mã lô hàng/ Mã kiện";
            worksheet.Range["A:A"].EntireColumn.NumberFormat = "0";
            worksheet.Range["B:B"].EntireColumn.NumberFormat = "@";
            worksheet.Range["C:C"].EntireColumn.NumberFormat = "@";
            worksheet.Range["D:D"].EntireColumn.NumberFormat = "@";
            worksheet.Range["E:E"].EntireColumn.NumberFormat = "@";
            worksheet.Range["F:F"].EntireColumn.NumberFormat = "@";
            worksheet.Range["G:G"].EntireColumn.NumberFormat = "@";
            worksheet.Range["H:H"].EntireColumn.NumberFormat = "#,##0.000000";
            worksheet.Range["I:I"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["J:J"].EntireColumn.NumberFormat = "@";
            worksheet.Range["K:K"].EntireColumn.NumberFormat = "@";
            background.ReportProgress(10);

            int index = 2;
            int totalItem = ListReceiptItem.Count() + 10;
            int process = 0;
            ListReceiptItem.ForEach(o =>
            {
                worksheet.Range[$"A{index}"].Value = index - 1;
                worksheet.Range[$"B{index}"].Value = o.ICProductNo.Trim();
                worksheet.Range[$"C{index}"].Value = o.ICReceiptItemProductSupplierNo.Trim();
                worksheet.Range[$"D{index}"].Value = o.ICReceiptItemProductNoOfOldSys.Trim();
                worksheet.Range[$"E{index}"].Value = o.ICReceiptItemProductName.Trim();
                worksheet.Range[$"F{index}"].Value = o.ICReceiptItemProductDesc.Trim();
                worksheet.Range[$"G{index}"].Value = o.ICMeasureUnitName.Trim();
                worksheet.Range[$"H{index}"].Value = o.ICReceiptItemProductQty;
                worksheet.Range[$"I{index}"].Value = o.ICReceiptItemProductUnitCost;
                worksheet.Range[$"J{index}"].Value = o.ICStockName.Trim();
                worksheet.Range[$"K{index}"].Value = o.ICReceiptItemProductSerialNo.Trim();
                index++;
                process = 10 + 100 * index / totalItem;
                if (process > 100)
                    process = 100;
                background.ReportProgress(process);
            });
            var usedRange = worksheet.get_Range($"A1", $"K{index - 1}");
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Color = Color.Black;
            worksheet.get_Range("A1", "K1").EntireColumn.AutoFit();
            workbook.SaveAs(FilePath);
            workbook.Close(true, misValue, misValue);
            xlApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(xlApp);
            background.ReportProgress(100);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}