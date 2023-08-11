using BOSERP;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP002 : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RP002(DataTable table, DateTime from, DateTime to, int dateIndex)
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            InitColumn(from, to, dateIndex);
            this.DataSource = table;
        }

        /// <summary>
        /// Init column by month or year
        /// </summary>
        /// <param name="from">The invoice date from</param>
        /// <param name="to">The invoice date to</param>
        /// <param name="dateIndex">Index of date in combobox control</param>
        public void InitColumn(DateTime from, DateTime to, int dateIndex)
        {
            DateTime index = new DateTime(from.Year, from.Month, 1);
            DateTime end = new DateTime(to.Year, to.Month, 1);
            string formatMonth = "MM/yyyy";
            string formatYear = "yyyy";
            while (index <= end)
            {
                if (dateIndex == 0)
                {
                    InitColumnByDateType(formatMonth, index);
                    index = index.AddMonths(1);
                }
                else
                {
                    InitColumnByDateType(formatYear, index);
                    index = index.AddYears(1);
                }
            }
        }

        /// <summary>
        /// Init column by date type
        /// </summary>
        /// <param name="dateType">The date format</param>
        /// <param name="index">The start index of date</param>
        public void InitColumnByDateType(string dateFormat, DateTime index)
        {
            XRTableCell tableInvoiceDate = new XRTableCell();
            tableInvoiceDate.Text = index.ToString(dateFormat);
            tableInvoiceDate.Name = tableInvoiceDate.Name = "invoiceDate_" + index.ToString(dateFormat);
            tableInvoiceDate.Weight = 20;
            xrTableRow4.Cells.Add(tableInvoiceDate);

            XRTableCell tableCellQty = new XRTableCell();
            XRTableCell tableCellAmount = new XRTableCell();
            XRTableCell tableCellRate = new XRTableCell();
            tableCellQty.Text = BOSReportResources.Qty;
            tableCellQty.Name = "tableCellQty_" + index.ToString(dateFormat);
            tableCellQty.Weight = 0.6;

            tableCellAmount.Text = BOSReportResources.Amount;
            tableCellAmount.Name = "tableCellAmount_" + index.ToString(dateFormat);
            tableCellAmount.Weight = 0.6;

            tableCellRate.Text = BOSReportResources.IncreasingRate;
            tableCellRate.Name = "tableCellRate_" + index.ToString(dateFormat);
            tableCellRate.Weight = 0.6;
            xrTableRow1.Cells.AddRange(new XRTableCell[] { tableCellQty, tableCellAmount, tableCellRate });

            //Report detail
            tableCellQty = new XRTableCell();
            tableCellAmount = new XRTableCell();
            tableCellRate = new XRTableCell();

            tableCellQty.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "Quantity_" + index.ToString(dateFormat), "{0:n0}") });
            tableCellQty.EvenStyleName = "";
            tableCellQty.OddStyleName = "";
            tableCellQty.Multiline = true;
            tableCellQty.Weight = 0.77;
            tableCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            tableCellAmount.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "Total_" + index.ToString(dateFormat), "{0:n0}") });
            tableCellAmount.EvenStyleName = "";
            tableCellAmount.OddStyleName = "";
            tableCellAmount.Multiline = true;
            tableCellAmount.Weight = 0.77;
            tableCellAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            tableCellRate.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "Percent_" + index.ToString(dateFormat)) });
            tableCellRate.EvenStyleName = "";
            tableCellRate.OddStyleName = "";
            tableCellRate.Multiline = true;
            tableCellRate.Weight = 0.77;
            tableCellRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRow3.Cells.AddRange(new XRTableCell[] { tableCellQty, tableCellAmount, tableCellRate });

        }

    }
}
