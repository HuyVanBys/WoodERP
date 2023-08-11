using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP033 : XtraReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public List<ICStocksInfo> StockList { get; set; }
        public RP033(List<ICStocksInfo> stockList)
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
                    tableCell.Weight = 1.1;
                    tableCell.Multiline = true;
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.8;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });
                }
            }
        }
    }
}
