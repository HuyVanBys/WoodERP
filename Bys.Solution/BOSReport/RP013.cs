using BOSERP;
using DevExpress.XtraReports.UI;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP013 : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public List<ICStocksInfo> StockList { get; set; }

        public RP013(List<ICStocksInfo> stockList)
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            StockList = stockList;
        }

        /// <summary>
        /// Add dynamic column in report
        /// </summary>
        public void AddDynamicColumn()
        {
            if (StockList != null)
            {
                foreach (ICStocksInfo objStocksInfo in StockList)
                {
                    //Report header
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = objStocksInfo.ICStockName;
                    tableCell.Weight = 0.6;
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", this.DataSource, objStocksInfo.ICStockID.ToString(), "{0:n4}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.77;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });
                }
            }

            //Add column inventory stock total quantity
            //Report header
            XRTableCell cell = new XRTableCell();
            cell.Text = BOSReportResources.ICInventoryStockTotalQty;
            cell.Weight = 0.6;
            xrTableRowHeader.Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            //cell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", "ICInventoryStockTotalQty")) });
            //cell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", "ICInventoryStockTotalQty")) });
            cell.DataBindings.Add("Text", this.DataSource, "ICInventoryStockTotalQty", "{0:n4}");
            cell.EvenStyleName = "";
            cell.OddStyleName = "";
            cell.Multiline = true;
            cell.Weight = 0.77;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRowDetail.Cells.AddRange(new XRTableCell[] { cell });
        }

    }
}
