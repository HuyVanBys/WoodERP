using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPContainerLoader : BaseReport
    {
        public RPContainerLoader()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        /// <summary>
        /// Add dynamic column in report
        /// </summary>
        public void AddDynamicColumn(List<ARContainerLoaderItemDetailsInfo> containerLoaderItemPINo, DataTable ContainerLoaderItemDetailTable)
        {
            //TimeSpan tsDate = ToDate - FromDate;
            //int count = tsDate.Days + 1;
            if (containerLoaderItemPINo.Count > 0)
            {
                foreach (ARContainerLoaderItemDetailsInfo item in containerLoaderItemPINo)
                {

                    //DateTime getDate = FromDate.AddDays(i);
                    // string dateCol = getDate.Date.ToString("f", CultureInfo.CreateSpecificCulture("en-US"));
                    string PInoCaption = item.ARSaleOrderNo;

                    //Report header
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = PInoCaption;
                    tableCell.Weight = 0.40;
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right;
                    tableCell.Name = "xrTableCellPino";
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", ContainerLoaderItemDetailTable, PInoCaption, "{0:n0}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Multiline = true;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    tableCell.BeforePrint += new System.Drawing.Printing.PrintEventHandler(tableCell_BeforePrint);
                    tableCell.Weight = 0.40;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report Footer
                    tableCell = new XRTableCell();
                    tableCell.DataBindings.Add("Text", ContainerLoaderItemDetailTable, PInoCaption, "{0:n0}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Summary.Running = SummaryRunning.Report;
                    tableCell.Summary.Func = SummaryFunc.Sum;
                    tableCell.Multiline = true;
                    tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                    tableCell.Weight = 0.40;
                    xrTableRowFooter.Cells.AddRange(new XRTableCell[] { tableCell });
                }
                //Report header
                XRTableCell tableCellTotalBlock = new XRTableCell();
                tableCellTotalBlock.Text = "Tổng lượng tinh gỗ";
                tableCellTotalBlock.Weight = 0.40;
                tableCellTotalBlock.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right;
                tableCellTotalBlock.Name = "xrTableCellPino";
                xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCellTotalBlock });

                //Report detail
                tableCellTotalBlock = new XRTableCell();
                //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                tableCellTotalBlock.DataBindings.Add("Text", ContainerLoaderItemDetailTable, "ARContainerLoaderItemTotalBlock", "{0:n4}");
                tableCellTotalBlock.EvenStyleName = "";
                tableCellTotalBlock.OddStyleName = "";
                tableCellTotalBlock.Multiline = true;
                tableCellTotalBlock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                tableCellTotalBlock.BeforePrint += new System.Drawing.Printing.PrintEventHandler(tableCell_BeforePrint);
                tableCellTotalBlock.Weight = 0.40;
                xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCellTotalBlock });

                //Report Footer
                tableCellTotalBlock = new XRTableCell();
                tableCellTotalBlock.DataBindings.Add("Text", ContainerLoaderItemDetailTable, "ARContainerLoaderItemTotalBlock", "{0:n4}");
                tableCellTotalBlock.EvenStyleName = "";
                tableCellTotalBlock.OddStyleName = "";
                tableCellTotalBlock.Summary.Running = SummaryRunning.Report;
                tableCellTotalBlock.Summary.Func = SummaryFunc.Sum;
                tableCellTotalBlock.Multiline = true;
                tableCellTotalBlock.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
                tableCellTotalBlock.Weight = 0.40;
                tableCellTotalBlock.Summary.FormatString.CompareTo("n4");
                xrTableRowFooter.Cells.AddRange(new XRTableCell[] { tableCellTotalBlock });
            }
        }
        private void tableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //double qty = double.Parse(tableCell.Text.ToString());
            XRTableCell tableCell = (XRTableCell)sender;
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            }
            else
            {
                tableCell.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right;
            }
        }
        private void xrxrProductNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrProductNo.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            }
            else
            {
                xrProductNo.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top;
            }
        }

        private void xrProductQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double qty = double.Parse(xrProductQty.Text.ToString());
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrProductQty.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                xrProductQty.Text = string.Empty;
            }
            else
            {
                xrProductQty.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top;
            }
        }

        private void xrTotalGW_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double qty = double.Parse(xrTotalGW.Text.ToString());
            xrTotalGW.Text = qty.ToString("n0");
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrTotalGW.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                xrTotalGW.Text = string.Empty;
            }
            else

            {
                xrTotalGW.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top;
            }

        }

        private void xrTotalCBM_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double qty = double.Parse(xrTotalCBM.Text.ToString());
            xrTotalCBM.Text = qty.ToString("n4");
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrTotalCBM.Borders = DevExpress.XtraPrinting.BorderSide.Right;
                xrTotalCBM.Text = string.Empty;
            }
            else
            {
                xrTotalCBM.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top;
            }

        }

        private void xrPicture_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrPicture.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            }
            else
            {
                xrPicture.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top;
            }
            //xrPicture.WidthF = 92; 
        }

        private void xrTableCellRecodeNumber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrTableCellRecodeNumber.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            }
            else
            {
                xrTableCellRecodeNumber.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left;
            }
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (String.IsNullOrEmpty(xrProductNo.Text))
            {
                xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            }
            else
            {
                xrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left;
            }
            xrPictureBox1.WidthF = xrPicture.WidthF;
        }

    }
}
