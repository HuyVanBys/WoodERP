using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP058 : ReportForm
    {
        public RP058()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            HRPayRollsController objPayRollsController = new HRPayRollsController();
            RPPayRoll report = new RPPayRoll();
            //report.LoadLayout(BOSCommon.Constants.Report.DevPayRollReportPath);
            InitPayRollReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPayRollReportPath, true);
            reviewer.Show();
        }

        private void RP058_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dtePayrollDate.EditValue = DateTime.Now;

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }
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

        /// <summary>
        /// Init payroll report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitPayRollReport(XtraReport report)
        {
            List<HREmployeePayRollsInfo> employeePayRollList = SetEmployeePayRollReportDataSource();

            //Set current branch

            SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //Set payroll date
            XRLabel payrollMonth = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollMonth"];
            DateTime month = fld_dtePayrollDate.DateTime;
            if (payrollMonth != null)
                payrollMonth.Text = month.Month.ToString();
            XRLabel payrollYear = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollYear"];
            if (payrollYear != null)
                payrollYear.Text = month.Year.ToString();

            //convert payroll total amount to word
            XRLabel amountToWord = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWord"];
            if (amountToWord != null)
            {
                decimal payRollTotalAmt = employeePayRollList.Sum(e => e.HREmployeePayRollTotalSalary);
                if (payRollTotalAmt > 0)
                {
                    GECurrenciesController objCurrenciesController = new GECurrenciesController();
                    amountToWord.Text = ConvertAmountToWord.ReadAmount(payRollTotalAmt.ToString(), BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID);
                }
            }
            if (employeePayRollList.Count > 0)
                report.DataSource = employeePayRollList;
        }

        /// <summary>
        /// Sets the employee payroll list for report data source
        /// </summary>
        /// <returns>Employee payroll list</returns>
        private List<HREmployeePayRollsInfo> SetEmployeePayRollReportDataSource()
        {
            List<HREmployeePayRollsInfo> employeePayRollList = new List<HREmployeePayRollsInfo>();
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime month = fld_dtePayrollDate.DateTime;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollList(
            //                                                                            locationID,
            //                                                                            branchID,
            //                                                                            departmentID,
            //                                                                            departmentRoomID,
            //                                                                            month);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<HREmployeePayRollsInfo> result = objEmployeePayRollsController.GetEmployeePayRollList(
                                                                                        null,
                                                                                        branch.BRBranchID,
                                                                                        departmentID,
                                                                                        departmentRoomID,
                                                                                        month);
                    employeePayRollList.AddRange(result);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            foreach (HREmployeePayRollsInfo objEmployeePayRollsInfo in employeePayRollList)
            {
                CalculatePayRollTotalAmounts(objEmployeePayRollsInfo);
            }
            return employeePayRollList;
        }

        /// <summary>
        /// Calculate the total amounts of an employee's payroll
        /// </summary>
        /// <param name="objEmployeePayRollsInfo">Given employee payroll</param>        
        public void CalculatePayRollTotalAmounts(HREmployeePayRollsInfo objEmployeePayRollsInfo)
        {
            //Calculate total working salary
            objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary = objEmployeePayRollsInfo.HREmployeePayRollWorkingSalary +
                                                                            objEmployeePayRollsInfo.HREmployeePayRollOTSalary +
                                                                            objEmployeePayRollsInfo.HREmployeePayRollLeaveSalary;

            //Calculate total deducted amount
            objEmployeePayRollsInfo.HREmployeePayRollTotalInsAmt = objEmployeePayRollsInfo.HREmployeePayRollSocialInsAmount +
                                                                       objEmployeePayRollsInfo.HREmployeePayRollHealthInsAmount +
                                                                       objEmployeePayRollsInfo.HREmployeePayRollOutOfWorkInsAmount;

            objEmployeePayRollsInfo.HREmployeePayRollTotalDeductedAmt = objEmployeePayRollsInfo.HREmployeePayRollSocialInsAmount +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollHealthInsAmount +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollOutOfWorkInsAmount +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollSyndicateFee +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollDiscipline +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollIncomeTaxAmount +
                                                                          objEmployeePayRollsInfo.HREmployeePayRollAdvance;

            //Calcalate total additional amount
            objEmployeePayRollsInfo.HREmployeePayRollTotalAddAmt = objEmployeePayRollsInfo.HREmployeePayRollCommission +
                                                                    objEmployeePayRollsInfo.HREmployeePayRollReward +
                                                                    objEmployeePayRollsInfo.HREmployeePayRollExtraSalary;

            objEmployeePayRollsInfo.HREmployeePayRollTotalIncome = objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary + objEmployeePayRollsInfo.HREmployeePayRollTotalAddAmt;

            //Calculate total salary
            objEmployeePayRollsInfo.HREmployeePayRollTotalSalary = Convert.ToDecimal(BOSUtil.RoundToThousand(Convert.ToDouble(objEmployeePayRollsInfo.HREmployeePayRollTotalIncome - objEmployeePayRollsInfo.HREmployeePayRollTotalDeductedAmt)));
        }
    }
}
