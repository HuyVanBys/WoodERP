using BOSERP;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class RP_TimeSheet : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public List<HRTimeSheetParamsInfo> OTFactorlist { get; set; }

        public RP_TimeSheet()
        {
            InitializeComponent();
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            OTFactorlist = objTimeSheetParamsController.GetDistinctOTTimeSheetParamsList();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        /// <summary>
        /// Add dynamic column in report
        /// </summary>
        public void AddDynamicColumn()
        {
            //Report header
            XRTableCell cell = new XRTableCell();
            cell.Text = "Bộ phận";
            cell.Weight = 0.7;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRDepartmentRoomName");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Multiline = true;
            cell.Weight = 0.9;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { cell });

            if (OTFactorlist != null)
            {
                foreach (HRTimeSheetParamsInfo timeSheetParamsInfo in OTFactorlist)
                {
                    //Report header
                    string fileNameHD = "Số người(HS" + timeSheetParamsInfo.HRTimeSheetParamValue2 + ")";
                    string fileName = "HS" + timeSheetParamsInfo.HRTimeSheetParamValue2 + "(N)";
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = fileNameHD;
                    tableCell.Weight = 0.7;
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", this.DataSource, fileName, "{0:n0}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Multiline = true;
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                    tableCell.Weight = 0.9;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report footer
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", this.DataSource, fileName, "{0:n0}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Summary.Running = SummaryRunning.Report;
                    tableCell.Summary.Func = SummaryFunc.Sum;
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.8;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowFooter.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report header
                    string fileName1HD = "Số giờ(HS" + timeSheetParamsInfo.HRTimeSheetParamValue2 + ")";
                    string fileName1 = "HS" + timeSheetParamsInfo.HRTimeSheetParamValue2 + "(G)";
                    tableCell = new XRTableCell();
                    tableCell.Text = fileName1HD;
                    tableCell.Weight = 0.7;
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", this.DataSource, fileName1, "{0:n2}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.9;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report Footer
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", this.DataSource, fileName1, "{0:n2}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Summary.Running = SummaryRunning.Report;
                    tableCell.Summary.Func = SummaryFunc.Sum;
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.8;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowFooter.Cells.AddRange(new XRTableCell[] { tableCell });
                }
            }

            //Add column inventory stock total quantity
            //Report header
            cell = new XRTableCell();
            cell.Text = "Tổng số người";
            cell.Weight = 0.7;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRTimeSheetParamSumHuman", "{0:n0}");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Multiline = true;
            cell.Weight = 0.9;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { cell });

            //Report Footer
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRTimeSheetParamSumHuman", "{0:n0}");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Summary.Running = SummaryRunning.Report;
            cell.Summary.Func = SummaryFunc.Sum;
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Multiline = true;
            cell.Weight = 0.79;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowFooter.Cells.AddRange(new XRTableCell[] { cell });

            //Report header
            cell = new XRTableCell();
            cell.Text = "Tổng số giờ";
            cell.Weight = 0.7;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRTimeSheetParamSumHours", "{0:n2}");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Multiline = true;
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Weight = 0.9;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { cell });

            //Report Footer
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRTimeSheetParamSumHours", "{0:n2}");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Summary.Running = SummaryRunning.Report;
            cell.Summary.Func = SummaryFunc.Sum;
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Multiline = true;
            cell.Weight = 0.79;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowFooter.Cells.AddRange(new XRTableCell[] { cell });

            //Report header
            cell = new XRTableCell();
            cell.Text = "Ghi chú";
            cell.Weight = 1.4;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "HRTimeSheetParamcomment");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Multiline = true;
            cell.Weight = 1.8;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { cell });

            //Report Footer
            cell = new XRTableCell();
            cell.DataBindings.Add("Text", this.DataSource, "");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Multiline = true;
            cell.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            cell.Weight = 1.6;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowFooter.Cells.AddRange(new XRTableCell[] { cell });
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell1.WidthF = 55;
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell4.WidthF = 55;
        }


    }
}
