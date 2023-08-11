using BOSLib;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP022 : ReportForm
    {
        private String[] DayOfWeeks = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        private String[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private enum FilterType { DayOfWeek, DayOfMonth, Month, Year };
        private FilterType filterType;
        private BOSList<ARInvoicesInfo> lstARInvoice;
        private List<int> lstExistYear;

        public RP022()
        {
            InitializeComponent();
            lstARInvoice = new BOSList<ARInvoicesInfo>();
            lstExistYear = new List<int>();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RP022_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            filterType = FilterType.DayOfWeek;
            ViewSaleOverTimeChart(filterType);
        }

        private void ViewSaleOverTimeChart(FilterType type)
        {
            lstARInvoice.Clear();
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARInvoicesInfo))));
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            DataSet ds = objInvoicesController.GetDataSet(queryBuilder.ToString());
            fld_chcSaleOverTime.Series[0].Points.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectFromDataRow(row);
                lstARInvoice.Add(objInvoicesInfo);
            }

            List<decimal> lstInvoiceTotalAmount = new List<decimal>();
            switch (type)
            {
                case FilterType.DayOfWeek:
                    lstInvoiceTotalAmount = GetInvoiceTotalAmountByDayOfWeek(lstARInvoice);
                    break;
                case FilterType.DayOfMonth:
                    lstInvoiceTotalAmount = GetInvoiceTotalAmountByDayOfMonth(lstARInvoice);
                    break;
                case FilterType.Month:
                    lstInvoiceTotalAmount = GetInvoiceTotalAmountByMonth(lstARInvoice);
                    break;
                case FilterType.Year:
                    lstInvoiceTotalAmount = GetInvoiceTotalAmountByYear(lstARInvoice);
                    break;
            }

            for (int i = 0; i < lstInvoiceTotalAmount.Count; i++)
            {
                lstInvoiceTotalAmount[i] = Math.Round(lstInvoiceTotalAmount[i], 2);
            }

            SeriesPoint point = new SeriesPoint();
            for (int i = 0; i < lstInvoiceTotalAmount.Count; i++)
            {
                switch (type)
                {
                    case FilterType.DayOfWeek:
                        point = new SeriesPoint(DayOfWeeks[i], lstInvoiceTotalAmount[i]);
                        break;
                    case FilterType.DayOfMonth:
                        point = new SeriesPoint((i + 1).ToString(), lstInvoiceTotalAmount[i]);
                        break;
                    case FilterType.Month:
                        point = new SeriesPoint(Months[i], lstInvoiceTotalAmount[i]);
                        break;
                    case FilterType.Year:
                        point = new SeriesPoint(lstExistYear[i].ToString(), lstInvoiceTotalAmount[i]);
                        break;
                }
                fld_chcSaleOverTime.Series[0].Points.Add(point);
            }
        }

        private List<decimal> GetInvoiceTotalAmountByDayOfWeek(BOSList<ARInvoicesInfo> lstInvoice)
        {
            List<decimal> lstInvoiceTotalAmount = InitList(7);

            foreach (ARInvoicesInfo objInvoiceInfo in lstInvoice)
            {
                switch (objInvoiceInfo.ARInvoiceDate.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        lstInvoiceTotalAmount[0] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Tuesday:
                        lstInvoiceTotalAmount[1] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Wednesday:
                        lstInvoiceTotalAmount[2] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Thursday:
                        lstInvoiceTotalAmount[3] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Friday:
                        lstInvoiceTotalAmount[4] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Saturday:
                        lstInvoiceTotalAmount[5] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                    case DayOfWeek.Sunday:
                        lstInvoiceTotalAmount[6] += objInvoiceInfo.ARInvoiceTotalAmount;
                        break;
                }
            }
            return lstInvoiceTotalAmount;
        }

        private List<decimal> GetInvoiceTotalAmountByDayOfMonth(BOSList<ARInvoicesInfo> lstInvoice)
        {
            List<decimal> lstInvoiceTotalAmount = InitList(31);

            foreach (ARInvoicesInfo objInvoicesInfo in lstInvoice)
            {
                int orderDay = objInvoicesInfo.ARInvoiceDate.Day;
                lstInvoiceTotalAmount[orderDay - 1] += objInvoicesInfo.ARInvoiceTotalAmount;
            }
            return lstInvoiceTotalAmount;
        }

        private List<decimal> GetInvoiceTotalAmountByMonth(BOSList<ARInvoicesInfo> lstInvoice)
        {
            List<decimal> lstInvoiceTotalAmount = InitList(12);

            foreach (ARInvoicesInfo objInvoicesInfo in lstInvoice)
            {
                int orderMonth = objInvoicesInfo.ARInvoiceDate.Month;
                lstInvoiceTotalAmount[orderMonth - 1] += objInvoicesInfo.ARInvoiceTotalAmount;
            }
            return lstInvoiceTotalAmount;
        }

        private List<decimal> GetInvoiceTotalAmountByYear(BOSList<ARInvoicesInfo> lstInvoice)
        {
            foreach (ARInvoicesInfo objInvoicesInfo in lstInvoice)
            {
                int orderYear = objInvoicesInfo.ARInvoiceDate.Year;
                if (lstExistYear.Count == 0 || lstExistYear.Contains(orderYear) == false)
                    lstExistYear.Add(orderYear);
            }
            lstExistYear.Sort();
            List<decimal> lstInvoiceTotalAmount = InitList(lstExistYear.Count);

            foreach (ARInvoicesInfo objInvoicesInfo in lstInvoice)
            {
                int orderYear = objInvoicesInfo.ARInvoiceDate.Year;
                lstInvoiceTotalAmount[lstExistYear.IndexOf(orderYear)] += objInvoicesInfo.ARInvoiceTotalAmount;
            }

            return lstInvoiceTotalAmount;
        }

        private void fld_ctxItemDayOfWeek_Click(object sender, EventArgs e)
        {
            fld_lblFilter.Text = fld_ctxItemDayOfWeek.Text;
            filterType = FilterType.DayOfWeek;
            ViewSaleOverTimeChart(filterType);
        }

        private void fld_ctxItemDayOfMonth_Click(object sender, EventArgs e)
        {
            fld_lblFilter.Text = fld_ctxItemDayOfMonth.Text;
            filterType = FilterType.DayOfMonth;
            ViewSaleOverTimeChart(filterType);
        }

        private void fld_ctxItemMonth_Click(object sender, EventArgs e)
        {
            fld_lblFilter.Text = fld_ctxItemMonth.Text;
            filterType = FilterType.Month;
            ViewSaleOverTimeChart(filterType);
        }

        private void fld_ctxItemYear_Click(object sender, EventArgs e)
        {
            fld_lblFilter.Text = fld_ctxItemYear.Text;
            filterType = FilterType.Year;
            ViewSaleOverTimeChart(filterType);
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ViewSaleOverTimeChart(filterType);
        }

        private List<decimal> InitList(int numElement)
        {
            List<decimal> list = new List<decimal>(numElement);
            for (int i = 0; i < numElement; i++)
                list.Add(0);
            return list;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
    }
}