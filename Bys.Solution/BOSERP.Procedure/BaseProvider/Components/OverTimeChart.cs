using BOSLib;
using DevExpress.XtraCharts;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSERP
{
    public partial class OverTimeChart : BOSComponent.BOSChartControl
    {
        public enum FilterTypeEnum { DayOfWeek, DayOfMonth, Month, Year };

        #region Constant
        private String[] DayOfWeeks = { CommonLocalizedResources.Mon, CommonLocalizedResources.Tue,
                                        CommonLocalizedResources.Wed, CommonLocalizedResources.Thu,
                                        CommonLocalizedResources.Fri, CommonLocalizedResources.Sat, CommonLocalizedResources.Sun };
        private String[] Months = { CommonLocalizedResources.Jan, CommonLocalizedResources.Feb, CommonLocalizedResources.Mar,
                                    CommonLocalizedResources.Apr, CommonLocalizedResources.May, CommonLocalizedResources.Jun,
                                    CommonLocalizedResources.Jul, CommonLocalizedResources.Aug, CommonLocalizedResources.Sep,
                                    CommonLocalizedResources.Oct, CommonLocalizedResources.Nov, CommonLocalizedResources.Dec };
        private string DateProperty = "DocumentDate";
        private string TotalAmountProperty = "TotalAmount";
        #endregion



        #region Variables
        protected List<int> ExistingYears;
        #endregion

        #region Properties
        public List<OverTimeChartPointInfo> Points { get; set; }

        public FilterTypeEnum FilterType { get; set; }
        #endregion

        #region Constructors
        public OverTimeChart()
        {
            InitializeComponent();

            ExistingYears = new List<int>();
        }

        public OverTimeChart(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

            ExistingYears = new List<int>();
        }
        #endregion

        public void ShowOverTimeChart()
        {
            this.Series[0].Points.Clear();
            List<double> totalAmounts = new List<double>();
            switch (FilterType)
            {
                case FilterTypeEnum.DayOfWeek:
                    totalAmounts = GetTotalAmountsByDayOfWeek();
                    break;
                case FilterTypeEnum.DayOfMonth:
                    totalAmounts = GetTotalAmountsByDayOfMonth();
                    break;
                case FilterTypeEnum.Month:
                    totalAmounts = GetTotalAmountsByMonth();
                    break;
                case FilterTypeEnum.Year:
                    totalAmounts = GetTotalAmountsByYear();
                    break;
            }

            for (int i = 0; i < totalAmounts.Count; i++)
            {
                totalAmounts[i] = Math.Round(totalAmounts[i], 2);
            }

            SeriesPoint point = new SeriesPoint();
            for (int i = 0; i < totalAmounts.Count; i++)
            {
                switch (FilterType)
                {
                    case FilterTypeEnum.DayOfWeek:
                        point = new SeriesPoint(DayOfWeeks[i], totalAmounts[i]);
                        break;
                    case FilterTypeEnum.DayOfMonth:
                        point = new SeriesPoint((i + 1).ToString(), totalAmounts[i]);
                        break;
                    case FilterTypeEnum.Month:
                        point = new SeriesPoint(Months[i], totalAmounts[i]);
                        break;
                    case FilterTypeEnum.Year:
                        point = new SeriesPoint(ExistingYears[i].ToString(), totalAmounts[i]);
                        break;
                }
                this.Series[0].Points.Add(point);
            }
        }

        private List<double> GetTotalAmountsByDayOfWeek()
        {
            List<double> totalAmounts = InitList(7);
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BusinessObject point in Points)
            {
                switch (DateTime.Parse(dbUtil.GetPropertyValue(point, DateProperty).ToString()).DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        totalAmounts[0] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Tuesday:
                        totalAmounts[1] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Wednesday:
                        totalAmounts[2] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Thursday:
                        totalAmounts[3] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Friday:
                        totalAmounts[4] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Saturday:
                        totalAmounts[5] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                    case DayOfWeek.Sunday:
                        totalAmounts[6] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
                        break;
                }
            }
            return totalAmounts;
        }

        private List<double> GetTotalAmountsByDayOfMonth()
        {
            List<double> totalAmounts = InitList(31);
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BusinessObject point in Points)
            {
                int orderDay = DateTime.Parse(dbUtil.GetPropertyValue(point, DateProperty).ToString()).Day;
                totalAmounts[orderDay - 1] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
            }
            return totalAmounts;
        }

        private List<double> GetTotalAmountsByMonth()
        {
            List<double> totalAmounts = InitList(12);
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BusinessObject point in Points)
            {
                int orderMonth = DateTime.Parse(dbUtil.GetPropertyValue(point, DateProperty).ToString()).Month;
                totalAmounts[orderMonth - 1] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
            }
            return totalAmounts;
        }

        private List<double> GetTotalAmountsByYear()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BusinessObject point in Points)
            {
                int orderYear = DateTime.Parse(dbUtil.GetPropertyValue(point, DateProperty).ToString()).Year;
                if (ExistingYears.Count == 0 || ExistingYears.Contains(orderYear) == false)
                    ExistingYears.Add(orderYear);
            }
            ExistingYears.Sort();
            List<double> totalAmounts = InitList(ExistingYears.Count);
            foreach (BusinessObject point in Points)
            {
                int orderYear = DateTime.Parse(dbUtil.GetPropertyValue(point, DateProperty).ToString()).Year;
                totalAmounts[ExistingYears.IndexOf(orderYear)] += Double.Parse(dbUtil.GetPropertyValue(point, TotalAmountProperty).ToString());
            }
            return totalAmounts;
        }

        private List<double> InitList(int numElement)
        {
            List<double> list = new List<double>(numElement);
            for (int i = 0; i < numElement; i++)
                list.Add(0);
            return list;
        }
    }
}
