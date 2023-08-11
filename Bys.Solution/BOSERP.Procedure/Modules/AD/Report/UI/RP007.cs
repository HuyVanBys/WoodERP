using BOSLib;
using DevExpress.XtraCharts;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP007 : ReportForm
    {
        /// <summary>
        /// Sale comparision chart control
        /// </summary>
        private ChartControl SaleComparisionChart;

        /// <summary>
        /// Axits y of chart type
        /// </summary>
        private enum AxisYChart { ExtPrice = 1, ExtCost = 2, Qty = 3 };

        /// <summary>
        /// Axits y of chart
        /// </summary>
        private AxisYChart AxisYChartType;
        public RP007()
        {
            InitializeComponent();
            //Set default Invoice from date to date
            fld_dteSearchFromARInvoiceDate.EditValue = BOSUtil.GetYearBeginDate();
            fld_dteSearchToARInvoiceDate.EditValue = BOSUtil.GetYearEndDate();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ViewSaleComparisonChart();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// View comparing sales over time between the branches
        /// </summary>
        private void ViewSaleComparisonChart()
        {
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            BRBranchsController objBranchsController = new BRBranchsController();
            DataSet ds = objReportsController.GetBranchSaleSummary(fromDate, toDate);
            List<decimal> lstTypeValue = new List<decimal>();
            SaleComparisionChart.Series[0].Points.Clear();
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                          ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectFromDataRow(row);
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                BRBranchsInfo foundObject = BranchList.FirstOrDefault(item => item.BRBranchID == objBranchsInfo.BRBranchID);
                if (foundObject != null)
                {
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                    SeriesPoint point = new SeriesPoint();
                    switch (AxisYChartType)
                    {
                        case AxisYChart.ExtPrice:
                            point = new SeriesPoint(objBranchsInfo.BRBranchName, objBranchsInfo.TotalSaleAmount);
                            lstTypeValue.Add(objBranchsInfo.TotalSaleAmount);
                            break;
                        case AxisYChart.Qty:
                            point = new SeriesPoint(objBranchsInfo.BRBranchName, objBranchsInfo.TotalSaleQty);
                            lstTypeValue.Add(objBranchsInfo.TotalSaleQty);
                            break;
                    }
                    SaleComparisionChart.Series[0].Points.Add(point);
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                }
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            }
        }

        private void fld_ctxItemExtPrice_Click(object sender, EventArgs e)
        {
            fld_chcSaleComparison.Titles[0].Text = fld_ctxItemExtPrice.Text;
            AxisYChartType = AxisYChart.ExtPrice;
            ViewSaleComparisonChart();
        }

        private void fld_ctxItemQty_Click(object sender, EventArgs e)
        {
            fld_chcSaleComparison.Titles[0].Text = fld_ctxItemQty.Text;
            AxisYChartType = AxisYChart.Qty;
            ViewSaleComparisonChart();
        }

        private void RP007_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SaleComparisionChart = fld_chcSaleComparison;
            AxisYChartType = AxisYChart.ExtPrice;
            fld_chcSaleComparison.Titles[0].Text = fld_ctxItemExtPrice.Text;
            //ViewSaleComparisonChart();
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