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
    public partial class RP020 : ReportForm
    {
        /// <summary>
        /// employee comparision chart control
        /// </summary>
        private ChartControl EmployeeComparisonChart;

        /// <summary>
        /// Axits y of chart type
        /// </summary>
        public enum AxisYChart { ExtPrice = 1, ExtCost = 2, Qty = 3 };

        /// <summary>
        /// Axits y of chart
        /// </summary>
        private AxisYChart AxisYChartType;

        public RP020()
        {
            InitializeComponent();
            //Set default Invoice from date to date
            fld_dteFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.EditValue = BOSUtil.GetMonthEndDate();
        }

        /// <summary>
        /// View comparing sales over time between the employees
        /// </summary>
        private void ViewEmployeeComparisonChart()
        {

            ADReportsController objReportsController = new ADReportsController();
            DateTime fromDate = Convert.ToDateTime(fld_dteFromDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteToDate.EditValue);
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));

            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int employeeQty = Convert.ToInt32(fld_cmbEmployeeQty.EditValue);
            List<HREmployeesInfo> employeeList = new List<HREmployeesInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //employeeList = objReportsController.GetEmployeeSaleSummaryList(locationID, branchID, null, fromDate, toDate);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<HREmployeesInfo> result = objReportsController.GetEmployeeSaleSummaryList(0, branch.BRBranchID, null, fromDate, toDate);
                    employeeList.AddRange(result);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            employeeList = employeeList.Where(e => e.TotalSaleAmount != 0).ToList();
            if (AxisYChartType == AxisYChart.ExtPrice)
            {
                employeeList = employeeList.OrderByDescending(e => e.TotalSaleAmount).ToList();
            }
            else if (AxisYChartType == AxisYChart.Qty)
            {
                employeeList = employeeList.OrderByDescending(e => e.TotalSaleQty).ToList();
            }
            employeeQty = Math.Min(employeeQty, employeeList.Count);
            List<decimal> lstTypeValue = new List<decimal>();
            EmployeeComparisonChart.Series[0].Points.Clear();
            for (int i = 0; i < employeeQty; i++)
            {
                HREmployeesInfo objEmployeesInfo = employeeList[i];
                SeriesPoint point = new SeriesPoint();
                switch (AxisYChartType)
                {
                    case AxisYChart.ExtPrice:
                        point = new SeriesPoint(objEmployeesInfo.HREmployeeName, objEmployeesInfo.TotalSaleAmount);
                        lstTypeValue.Add(objEmployeesInfo.TotalSaleAmount);
                        break;
                    case AxisYChart.Qty:
                        point = new SeriesPoint(objEmployeesInfo.HREmployeeName, objEmployeesInfo.TotalSaleQty);
                        lstTypeValue.Add(objEmployeesInfo.TotalSaleQty);
                        break;
                }
                EmployeeComparisonChart.Series[0].Points.Add(point);
            }
        }

        private void RP020_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            EmployeeComparisonChart = fld_chcEmployeeComparison;
            AxisYChartType = AxisYChart.ExtPrice;
            fld_chcEmployeeComparison.Titles[0].Text = fld_ctxItemExtPrice.Text;
            ViewEmployeeComparisonChart();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ViewEmployeeComparisonChart();
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

        private void fld_ctxItemExtPrice_Click(object sender, EventArgs e)
        {
            fld_chcEmployeeComparison.Titles[0].Text = fld_ctxItemExtPrice.Text;
            AxisYChartType = AxisYChart.ExtPrice;
            ViewEmployeeComparisonChart();
        }

        private void fld_ctxItemQty_Click(object sender, EventArgs e)
        {
            fld_chcEmployeeComparison.Titles[0].Text = fld_ctxItemQty.Text;
            AxisYChartType = AxisYChart.Qty;
            ViewEmployeeComparisonChart();
        }
    }
}