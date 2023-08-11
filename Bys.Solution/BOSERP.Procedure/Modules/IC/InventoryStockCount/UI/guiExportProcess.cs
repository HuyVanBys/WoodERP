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

namespace BOSERP
{
    public partial class guiExportProcess : DevExpress.XtraEditors.XtraForm
    {
        private BackgroundWorker ExportWorker;

        DateTime InventoryDate { get; set; }

        int StockId { get; set; }

        string StockName { get; set; }

        public string FilePath { get; set; }

        public guiExportProcess(DateTime inventoryDate, int stockId, string stockName)
        {
            InventoryDate = inventoryDate;
            StockId = stockId;
            StockName = stockName;
            InitializeComponent();
        }

        private void guiExportProcess_Load(object sender, EventArgs e)
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
                string.Format("{0}_{1}_{2}.xls", 
                InventoryDate.ToString("yyyy_dd_MM"), 
                StockName.RemoveUnicode().RemoveWhiteSpace(), 
                DateTimeOffset.Now.ToUnixTimeSeconds()));
            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            xlApp.StandardFont = "Times New Roman";
            xlApp.StandardFontSize = 13;
            var header = worksheet.get_Range("A1", "M1");
            header.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(9, 132, 227));
            header.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            header.Font.Bold = true;
            header.Range["A1"].Value = "STT";
            header.Range["B1"].Value = "Mã sản phẩm";
            header.Range["C1"].Value = "Tên sản phẩm";
            header.Range["D1"].Value = "Mô tả";
            header.Range["E1"].Value = "ĐVT";
            header.Range["F1"].Value = "Mã kho";
            header.Range["G1"].Value = "Tên kho";
            header.Range["H1"].Value = "Mã lô";
            header.Range["I1"].Value = "Tồn kho chương trình";
            header.Range["J1"].Value = "Tồn kho thực tế";
            header.Range["K1"].Value = "Giá vốn các lô";
            header.Range["L1"].Value = "Giá vốn thực tế";
            header.Range["M1"].Value = "Ghi chú";
            worksheet.Range["A:A"].EntireColumn.NumberFormat = "0";
            worksheet.Range["B:B"].EntireColumn.NumberFormat = "@";
            worksheet.Range["C:C"].EntireColumn.NumberFormat = "@";
            worksheet.Range["D:D"].EntireColumn.NumberFormat = "@";
            worksheet.Range["E:E"].EntireColumn.NumberFormat = "@";
            worksheet.Range["F:F"].EntireColumn.NumberFormat = "@";
            worksheet.Range["G:G"].EntireColumn.NumberFormat = "@";
            worksheet.Range["H:H"].EntireColumn.NumberFormat = "@";
            worksheet.Range["I:I"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["J:J"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["K:K"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["L:L"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["M:M"].EntireColumn.NumberFormat = "@";
            background.ReportProgress(10);
            IPInventoryStockCountsController inventoryController = new IPInventoryStockCountsController();
            List<IPInventoryStockCountsInfo> exportDataList = inventoryController.GetInventoryForStockCount(InventoryDate, StockId);
            int index = 2;
            int totalItem = exportDataList.Count() + 10;
            int process = 0;
            exportDataList.ForEach(o =>
            {
                worksheet.Range[$"A{index}"].Value = index - 1;
                worksheet.Range[$"B{index}"].Value = o.ProductNo.Trim();
                worksheet.Range[$"C{index}"].Value = o.ProductName.Trim();
                worksheet.Range[$"D{index}"].Value = o.ProductDesc.Trim();
                worksheet.Range[$"E{index}"].Value = o.MeasureUnitName.Trim();
                worksheet.Range[$"F{index}"].Value = o.StockNo.Trim();
                worksheet.Range[$"G{index}"].Value = o.StockName.Trim();
                worksheet.Range[$"H{index}"].Value = o.ProductSerieNo;
                worksheet.Range[$"I{index}"].Value = o.ProgramInventoryQty;
                worksheet.Range[$"J{index}"].Value = o.ActualInventoryQty;
                worksheet.Range[$"K{index}"].Value = o.ProgramInventoryCost;
                worksheet.Range[$"L{index}"].Value = o.ProgramInventoryCost;
                worksheet.Range[$"M{index}"].Value = o.InventoryStockCountNote;
                index++;
                process = 10 + 100 * index / totalItem;
                if (process > 100)
                    process = 100;
                background.ReportProgress(process);
            });
            var usedRange = worksheet.get_Range($"A1", $"M{index - 1}");
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Color = Color.Black;
            worksheet.get_Range("A1", "M1").EntireColumn.AutoFit();
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