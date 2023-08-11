using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
namespace BOSReport
{
    public partial class RPTimeSheetDetailA3 : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        /// 
        public HRTimeSheetsInfo objTimeSheetsInfo { get; set; }
        public RPTimeSheetDetailA3(HRTimeSheetsInfo timeSheetsInfo)
        {
            InitializeComponent();
            objTimeSheetsInfo = timeSheetsInfo;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        /// <summary>
        /// Add dynamic column in report
        /// </summary>
        public void AddDynamicColumn()
        {
            int number = 5;
            for (DateTime date = objTimeSheetsInfo.HRTimeSheetFromDate.Date; date <= objTimeSheetsInfo.HRTimeSheetToDate.Date; date = date.Date.AddDays(1))
            {
                //Report header
                XRTableCell tableCell1 = new XRTableCell();
                //string dayOfWeek = ConvertDayOfWeek(date.DayOfWeek.ToString());
                //tableCell1.Text = dayOfWeek + Environment.NewLine + Environment.NewLine + date.ToString("dd-MM");
                tableCell1.Text = date.ToString("dd-MM");
                tableCell1.Weight = 0.8;
                tableCell1.Multiline = true;
                if (date.DayOfWeek.ToString() == "Sunday")
                {
                    tableCell1.BackColor = Color.Yellow;
                    tableCell1.ForeColor = Color.Red;
                }
                xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell1 });
                //Report header number
                XRTableCell tableCell2 = new XRTableCell();
                tableCell2.Text = number.ToString();
                tableCell2.Weight = 0.8;
                tableCell2.Multiline = true;
                xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell2 });
                //Report detail
                XRTableCell tableCell3 = new XRTableCell();
                tableCell3.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0}", date.ToString("yyyyMMdd"))) });
                tableCell3.Multiline = true;
                tableCell3.EvenStyleName = "";
                tableCell3.OddStyleName = "";
                //tableCell3.Weight = 0.95;
                tableCell3.WidthF = tableCell1.WidthF;
                xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell3 });
                number++;
            }
            AddColumns(number);
            //xrTableCellSTT.WidthF = 48;
            xrTableCellDetailSTT.WidthF = xrTableCellNBSTT.WidthF = xrTableCellSTT.WidthF;

            //xrTableCellNo.WidthF = 55;
            xrTableCellDetailNo.WidthF = xrTableCellNBNo.WidthF = xrTableCellNo.WidthF;

            xrTableCellEmployeeName.WidthF = xrTableCellNBEmployeeName.WidthF = xrTableCellDetailEmployeeName.WidthF;
            xrTableCellDepartmentRoomName.WidthF = xrTableCellNBDepartmentRoomName.WidthF = xrTableCellDetailDepartmentRoomName.WidthF;
        }


        private void AddColumns(int number)
        {
            //Cấu hình cột giờ công chuẩn
            XRTableCell tableCell = new XRTableCell();
            tableCell.Text = "Tổng giờ công chuẩn";
            tableCell.Weight = 0.8;
            tableCell.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });
            //Report header number
            XRTableCell tableCell2 = new XRTableCell();
            tableCell2.Text = (number++).ToString();
            tableCell2.Weight = 0.8;
            tableCell2.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell2 });
            //Report detail
            XRTableCell tableCell3 = new XRTableCell();
            tableCell3.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "giocongchuan", "{0:n2}") });
            tableCell3.Multiline = true;
            tableCell3.EvenStyleName = "";
            tableCell3.OddStyleName = "";
            tableCell3.WidthF = tableCell.WidthF;
            tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell3 });

            //Cấu hình giờ OT tính cả chủ nhật
            XRTableCell tableCell4 = new XRTableCell();
            tableCell4.Text = "Tổng giờ tăng ca tính luôn chủ nhật";
            tableCell4.Weight = 0.8;
            tableCell4.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell4 });
            //Report header number
            XRTableCell tableCell5 = new XRTableCell();
            tableCell5.Text = (number++).ToString();
            tableCell5.Weight = 0.8;
            tableCell5.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell5 });
            //Report detail
            XRTableCell tableCell6 = new XRTableCell();
            tableCell6.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "sumot", "{0:n2}") });
            tableCell6.Multiline = true;
            tableCell6.EvenStyleName = "";
            tableCell6.OddStyleName = "";
            tableCell6.WidthF = tableCell4.WidthF;
            tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell6 });

            ////Cấu hình giờ OT không tính chủ nhật
            XRTableCell tableCell7 = new XRTableCell();
            tableCell7.Text = "Tổng giờ tăng ca không tính chủ nhật";
            tableCell7.Weight = 0.8;
            tableCell7.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell7 });
            //Report header number
            XRTableCell tableCell8 = new XRTableCell();
            tableCell8.Text = (number++).ToString();
            tableCell8.Weight = 0.8;
            tableCell8.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell8 });
            //Report detail
            XRTableCell tableCell9 = new XRTableCell();
            tableCell9.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "sumotnotsun", "{0:n2}") });
            tableCell9.Multiline = true;
            tableCell9.EvenStyleName = "";
            tableCell9.OddStyleName = "";
            tableCell9.WidthF = tableCell7.WidthF;
            tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell9 });

            ////Số ngày nghĩ có phép
            XRTableCell tableCell10 = new XRTableCell();
            tableCell10.Text = "Số ngày nghỉ có phép (NP)";
            tableCell10.Weight = 0.8;
            tableCell10.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell10 });
            //Report header number
            XRTableCell tableCell11 = new XRTableCell();
            tableCell11.Text = (number++).ToString();
            tableCell11.Weight = 0.8;
            tableCell11.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell11 });
            //Report detail
            XRTableCell tableCell12 = new XRTableCell();
            tableCell12.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "nghicophep", "{0:n2}") });
            tableCell12.Multiline = true;
            tableCell12.EvenStyleName = "";
            tableCell12.OddStyleName = "";
            tableCell12.WidthF = tableCell10.WidthF;
            tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell12 });

            //Số ngày nghĩ không phép
            XRTableCell tableCell13 = new XRTableCell();
            tableCell13.Text = "Số ngày nghỉ không phép (NKP)";
            tableCell13.Weight = 0.8;
            tableCell13.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell13 });
            //Report header number
            XRTableCell tableCell14 = new XRTableCell();
            tableCell14.Text = (number++).ToString();
            tableCell14.Weight = 0.8;
            tableCell14.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell14 });
            //Report detail
            XRTableCell tableCell15 = new XRTableCell();
            tableCell15.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "nghikhongphep", "{0:n2}") });
            tableCell15.Multiline = true;
            tableCell15.EvenStyleName = "";
            tableCell15.OddStyleName = "";
            tableCell15.WidthF = tableCell13.WidthF;
            tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell15 });

            //Số ngày xuống ca có phép
            XRTableCell tableCell16 = new XRTableCell();
            tableCell16.Text = "Số ngày xuống ca có phép (TC)";
            tableCell16.Weight = 0.8;
            tableCell16.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell16 });
            //Report header number
            XRTableCell tableCell17 = new XRTableCell();
            tableCell17.Text = (number++).ToString();
            tableCell17.Weight = 0.8;
            tableCell17.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell17 });
            //Report detail
            XRTableCell tableCell18 = new XRTableCell();
            tableCell18.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "xuongcacophep", "{0:n2}") });
            tableCell18.Multiline = true;
            tableCell18.EvenStyleName = "";
            tableCell18.OddStyleName = "";
            tableCell18.WidthF = tableCell16.WidthF;
            tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell18 });

            //xuống ca không phép
            XRTableCell tableCell19 = new XRTableCell();
            tableCell19.Text = "Số ngày xuống ca không phép (KTC)";
            tableCell19.Weight = 0.8;
            tableCell19.Multiline = true;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell19 });
            //Report header number
            XRTableCell tableCell20 = new XRTableCell();
            tableCell20.Text = (number++).ToString();
            tableCell20.Weight = 0.8;
            tableCell20.Multiline = true;
            xrTableRowHeaderNB.Cells.AddRange(new XRTableCell[] { tableCell20 });
            //Report detail
            XRTableCell tableCell21 = new XRTableCell();
            tableCell21.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "xuongcakhongphep", "{0:n2}") });
            tableCell21.Multiline = true;
            tableCell21.EvenStyleName = "";
            tableCell21.OddStyleName = "";
            tableCell21.WidthF = tableCell19.WidthF;
            tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            tableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell21 });
        }

        public string ConvertDayOfWeek(string DayOfWeek)
        {
            switch (DayOfWeek)
            {
                case "Monday": return "Thứ Hai";
                case "Tuesday": return "Thứ Ba";
                case "Wednesday": return "Thứ Tư";
                case "Thursday": return "Thứ Năm";
                case "Friday": return "Thứ Sáu";
                case "Saturday": return "Thứ Bảy";
                default: return "Chủ Nhật";
            }
        }

    }
}
