using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
namespace BOSReport
{
    public partial class OperationDetailPlanItemBatch : BaseReport
    {

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DataTable Datasource { get; set; }
        public bool isCompensation { get; set; }
        public OperationDetailPlanItemBatch(DateTime fromDate, DateTime toDate, DataTable datasource, bool compensation)
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            FromDate = fromDate;
            ToDate = toDate;
            Datasource = datasource;
            isCompensation = compensation;
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;

        }

        /// <summary>
        /// Add dynamic column in report
        /// </summary>
        public void AddDynamicColumn()
        {
            TimeSpan tsDate = ToDate - FromDate;
            int count = tsDate.Days + 1;
            if (count > 0)
            {
                for (int i = 0; i <= count; i++)
                {

                    DateTime getDate = FromDate.AddDays(i);
                    string dateCol = getDate.Date.ToString("f", CultureInfo.CreateSpecificCulture("en-US"));
                    string dateCaption = getDate.Date.ToString("ddd, d MMM, yy", CultureInfo.CreateSpecificCulture("vi-vn"));

                    //Report header
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = dateCaption;
                    tableCell.Weight = 0.44;
                    xrTableRowHeader.Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    //tableCell.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, String.Format("{0:n4}", objStocksInfo.ICStockID.ToString())) });
                    tableCell.DataBindings.Add("Text", Datasource, dateCol, "{0:n0}");
                    tableCell.EvenStyleName = "";
                    tableCell.OddStyleName = "";
                    tableCell.Multiline = true;
                    tableCell.Weight = 0.57;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRowDetail.Cells.AddRange(new XRTableCell[] { tableCell });
                }
            }
        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            if (!isCompensation)
            {
                label.Text = string.Empty;
            }
        }
    }
}
