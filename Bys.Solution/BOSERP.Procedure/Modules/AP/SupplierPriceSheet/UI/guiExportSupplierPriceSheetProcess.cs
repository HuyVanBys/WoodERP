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

namespace BOSERP.Modules.SupplierPriceSheet
{
    public partial class guiExportSupplierPriceSheetProcess : DevExpress.XtraEditors.XtraForm
    {
        private BackgroundWorker ExportWorker;

        private List<APPriceSheetItemsInfo> ListPriceSheetItems;

        private DateTime FromDate { get; set; }

        private DateTime ToDate { get; set; }

        private string SupplierName { get; set; }

        public string FilePath { get; set; }

        public guiExportSupplierPriceSheetProcess(List<APPriceSheetItemsInfo> listItems, DateTime fromDate, DateTime toDate, string supplierName)
        {
            ListPriceSheetItems = listItems;
            FromDate = fromDate;
            ToDate = toDate;
            SupplierName = supplierName;
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
                string.Format("BangGiaNCC_TuNgay_{0}_DenNgay_{1}_{2}_{3}.xls",
                FromDate.ToString("yyyy_MM_dd"),
                ToDate.ToString("yyyy_MM_dd"),
                SupplierName.RemoveUnicode().RemoveWhiteSpace(), 
                DateTimeOffset.Now.ToUnixTimeSeconds()));
            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlApp = new Excel.Application();            
            Excel.Workbook workbook = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet2 = (Excel.Worksheet)workbook.ActiveSheet;
            worksheet2.Name = "Sheet2";
            workbook.Sheets.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            xlApp.StandardFont = "Times New Roman";
            xlApp.StandardFontSize = 13;

            #region Sheet Bảng giá
            worksheet.Name = "Bảng giá";
            var header = worksheet.get_Range("A4", "O4");
            header.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header.Font.Bold = true;
            header.Range["A1"].Value = "STT";
            header.Range["B1"].Value = "Mã sản phẩm";
            header.Range["C1"].Value = "Mã HT cũ";
            header.Range["D1"].Value = "Mã SP NCC";
            header.Range["E1"].Value = "Tên sản phẩm";
            header.Range["F1"].Value = "Diễn giải (Mô tả)";
            header.Range["G1"].Value = "Đặc tính";
            header.Range["H1"].Value = "Diện tích";
            header.Range["I1"].Value = "ĐVT";
            header.Range["J1"].Value = "Đơn giá gốc";
            header.Range["K1"].Value = "Đơn giá /m2";
            header.Range["L1"].Value = "Đơn giá chưa thuế";
            header.Range["M1"].Value = "Mã NCC";
            header.Range["N1"].Value = "Tên NCC";
            header.Range["O1"].Value = "Loại tiền tệ";

            var nameSheet = worksheet.get_Range("A2", "O2");
            nameSheet.Merge();
            nameSheet.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            nameSheet.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            nameSheet.Font.Size = 15;
            nameSheet.Font.Bold = true;
            nameSheet.HorizontalAlignment = HorizontalAlignment.Center;
            nameSheet.VerticalAlignment = TileItemContentAlignment.MiddleCenter;
            nameSheet.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            nameSheet.Borders.Color = Color.Black;
            nameSheet.Range["A1"].Value = string.Format("BẢNG GIÁ NHÀ CUNG CẤP {0} Từ ngày {1} Đến ngày  {2}",
                                                        SupplierName,
                                                        FromDate.ToString("dd/MM/yyyy"),
                                                        ToDate.ToString("dd/MM/yyyy"));

            worksheet.Range["A:A"].EntireColumn.NumberFormat = "0";
            worksheet.Range["B:B"].EntireColumn.NumberFormat = "@";
            worksheet.Range["C:C"].EntireColumn.NumberFormat = "@";
            worksheet.Range["D:D"].EntireColumn.NumberFormat = "@";
            worksheet.Range["E:E"].EntireColumn.NumberFormat = "@";
            worksheet.Range["F:F"].EntireColumn.NumberFormat = "@";
            worksheet.Range["G:G"].EntireColumn.NumberFormat = "@";
            worksheet.Range["H:H"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["I:I"].EntireColumn.NumberFormat = "@";
            worksheet.Range["J:J"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["K:K"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["L:L"].EntireColumn.NumberFormat = "#,##0.00";
            worksheet.Range["M:M"].EntireColumn.NumberFormat = "@";
            worksheet.Range["N:N"].EntireColumn.NumberFormat = "@";
            worksheet.Range["O:O"].EntireColumn.NumberFormat = "@";
            background.ReportProgress(8);

            int index = 5;
            int totalItem = ListPriceSheetItems.Count() + 10;
            int process = 0;
            ListPriceSheetItems.ForEach(o =>
            {
                worksheet.Range[$"A{index}"].Value = index - 4;
                worksheet.Range[$"B{index}"].Value = o.APPriceSheetItemProductNo.Trim();
                worksheet.Range[$"C{index}"].Value = o.APPriceSheetItemProductNoOfOldSys.Trim();
                worksheet.Range[$"D{index}"].Value = o.APPriceSheetItemProductSupplierNumber.Trim();
                worksheet.Range[$"E{index}"].Value = o.APPriceSheetItemProductName.Trim();
                worksheet.Range[$"F{index}"].Value = o.APPriceSheetItemProductDesc.Trim();
                worksheet.Range[$"G{index}"].Value = o.ICProdAttPackingMaterialSpecialityName.Trim();
                worksheet.Range[$"H{index}"].Value = o.ICProductBoxArea;
                worksheet.Range[$"I{index}"].Value = o.ICMeasureUnitName.Trim();
                worksheet.Range[$"J{index}"].Value = o.APPriceSheetItemBasicPrice; //Đơn giá gốc
                worksheet.Range[$"K{index}"].Formula = string.Format("=IFERROR(VLOOKUP(G{0},Sheet2!$A$2:$B$8,2,0),0)", index); //Đơn giá / m2
                worksheet.Range[$"L{index}"].Formula = string.Format("=IF(H{0}={1}{2},0,H{3}*K{4})", index, (char)(34), (char)(34), index, index); //Đơn giá chưa thuế
                worksheet.Range[$"M{index}"].Value = o.ACObjectNo.Trim();
                worksheet.Range[$"N{index}"].Value = o.ACObjectName.Trim();
                worksheet.Range[$"O{index}"].Value = o.GECurrencyName.Trim();
                index++;
                process = 8 + 100 * index / totalItem;
                if (process >= 90)
                    process = 90;
                background.ReportProgress(process);
            });
            var usedRange = worksheet.get_Range($"A4", $"O{index - 1}");
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Borders.Color = Color.Black;
            #endregion

            #region Sheet2
            
            var header2 = worksheet2.get_Range("A1", "B1");
            header2.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkSeaGreen);
            header2.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            header2.Font.Bold = true;
            header2.Range["A1"].Value = "Đặc tính thùng";
            header2.Range["B1"].Value = "Giá";

            var usedRange2 = worksheet2.get_Range($"A1", $"B10");
            usedRange2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange2.Borders.Color = Color.Black;

            worksheet2.Range["A:A"].EntireColumn.NumberFormat = "@";
            worksheet2.Range["B:B"].EntireColumn.NumberFormat = "#,##0.00";
            background.ReportProgress(97);

            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> listProductAttributes = objProductAttributesController.GetProductAttributesByProductAttributeGroup("PackingMaterialSpeciality");

            index = 2;
            listProductAttributes.ForEach(o =>
            {
                worksheet2.Range[$"A{index}"].Value = o.ICProductAttributeValue.Trim();
                index++;
            });
            background.ReportProgress(99);
            #endregion


            worksheet.get_Range("A4", "O4").EntireColumn.AutoFit();
            worksheet2.get_Range("A1", "B1").EntireColumn.AutoFit();
            workbook.SaveAs(FilePath);
            workbook.Close(true, misValue, misValue);
            xlApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(worksheet2);
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