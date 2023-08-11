using BOSCommon;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP070 : ReportForm
    {
        public RP070()
        {
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            int viewType = Convert.ToInt32(fld_rdgViewType.EditValue);
            XtraReport report = null;
            if (viewType == 0)
            {
                report = new BOSReport.RP070();
            }
            else if (viewType == 1)
            {
                report = new BOSReport.RP070Details();
            }
            InitSalaryCalculationReport(report);
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RP070_Load(object sender, EventArgs e)
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
        public void InitSalaryCalculationReport(XtraReport report)
        {
            List<HREmployeePayRollsInfo> employeePayRollList = CalculatePayroll();
            if (employeePayRollList.Count > 0)
            {
                //Set current branch
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;

                //Set payroll date
                XRLabel payrollMonth = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollMonth"];
                DateTime month = fld_dtePayrollDate.DateTime;
                if (payrollMonth != null)
                    payrollMonth.Text = month.Month.ToString();
                XRLabel payrollYear = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblHRPayRollYear"];
                if (payrollYear != null)
                    payrollYear.Text = month.Year.ToString();
                report.DataSource = employeePayRollList;
            }
        }

        /// <summary>
        /// Calculate payroll for salary calculation
        /// </summary>
        /// <returns>Employee payroll list represents data for salary calculation</returns>
        private List<HREmployeePayRollsInfo> CalculatePayroll()
        {
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime month = fld_dtePayrollDate.DateTime;
            int viewType = Convert.ToInt32(fld_rdgViewType.EditValue);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<HREmployeePayRollsInfo> employeePayRollList = new List<HREmployeePayRollsInfo>();
            //List<HREmployeePayRollsInfo> employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollList(
            //                                                                        locationID,
            //                                                                        branchID,
            //                                                                        departmentID,
            //                                                                        departmentRoomID,
            //                                                                        month);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<HREmployeePayRollsInfo> list = objEmployeePayRollsController.GetEmployeePayRollList(
                                                                                    null,
                                                                                    branch.BRBranchID,
                                                                                    departmentID,
                                                                                    departmentRoomID,
                                                                                    month);
                    employeePayRollList.AddRange(list);
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            List<HREmployeePayRollsInfo> result = new List<HREmployeePayRollsInfo>();
            if (viewType == 0)
            {
                var groups = employeePayRollList.GroupBy(ep => ep.HRDepartmentRoomNo);
                foreach (var group in groups)
                {
                    HREmployeePayRollsInfo calculatedPayroll = new HREmployeePayRollsInfo();
                    foreach (HREmployeePayRollsInfo employeePayroll in group)
                    {
                        CalculatePayroll(employeePayroll);
                        calculatedPayroll.HRDepartmentRoomName = employeePayroll.HRDepartmentRoomName;
                        calculatedPayroll.HREmployeePayRollTotalIncome += employeePayroll.HREmployeePayRollTotalIncome;
                        calculatedPayroll.HREmployeePayRollInsSalary += employeePayroll.HREmployeePayRollInsSalary;

                        calculatedPayroll.HREmployeePayRollSocialInsAmount += employeePayroll.HREmployeePayRollSocialInsAmount;
                        calculatedPayroll.HREmployeePayRollHealthInsAmount += employeePayroll.HREmployeePayRollHealthInsAmount;
                        calculatedPayroll.HREmployeePayRollOutOfWorkInsAmount += employeePayroll.HREmployeePayRollOutOfWorkInsAmount;
                        calculatedPayroll.HREmployeePayRollSyndicateFee += employeePayroll.HREmployeePayRollSyndicateFee;
                        calculatedPayroll.HREmployeePayRollIncomeTaxAmount += employeePayroll.HREmployeePayRollIncomeTaxAmount;
                        calculatedPayroll.HREmployeePayRollAdvance += employeePayroll.HREmployeePayRollAdvance;

                        calculatedPayroll.HREmployeePayRollBussinessSocialInsAmount += employeePayroll.HREmployeePayRollBussinessSocialInsAmount;
                        calculatedPayroll.HREmployeePayRollBussinessHealthInsAmount += employeePayroll.HREmployeePayRollBussinessHealthInsAmount;
                        calculatedPayroll.HREmployeePayRollBussinessOutOfWorkInsAmount += employeePayroll.HREmployeePayRollBussinessOutOfWorkInsAmount;
                        calculatedPayroll.HREmployeePayRollBusinessSyndicateFee += employeePayroll.HREmployeePayRollBusinessSyndicateFee;
                    }
                    result.Add(calculatedPayroll);
                }
            }
            else if (viewType == 1)
            {
                foreach (HREmployeePayRollsInfo employeePayroll in employeePayRollList)
                {
                    CalculatePayroll(employeePayroll);
                    result.Add(employeePayroll);
                }
            }
            return result;
        }

        /// <summary>
        /// Calculate payroll of an employee
        /// </summary>
        /// <param name="employeePayroll">Employee payroll</param>        
        public void CalculatePayroll(HREmployeePayRollsInfo employeePayroll)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeePayroll.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                //Set amount for employee
                employeePayroll.HREmployeePayRollTotalWorkingSalary = employeePayroll.HREmployeePayRollWorkingSalary +
                                                                    employeePayroll.HREmployeePayRollOTSalary +
                                                                    employeePayroll.HREmployeePayRollLeaveSalary;

                employeePayroll.HREmployeePayRollTotalAddAmt = employeePayroll.HREmployeePayRollCommission +
                                                                        employeePayroll.HREmployeePayRollReward +
                                                                        employeePayroll.HREmployeePayRollExtraSalary;

                employeePayroll.HREmployeePayRollTotalIncome = employeePayroll.HREmployeePayRollTotalWorkingSalary +
                                                                        employeePayroll.HREmployeePayRollTotalAddAmt -
                                                                        employeePayroll.HREmployeePayRollDiscipline;


                //Set amount for enterprise
                decimal socialInsPercent = BOSApp.CurrentCompanyInfo.CSCompanySocialInsPercent;
                decimal healthInsPercent = BOSApp.CurrentCompanyInfo.CSCompanyHealthInsPercent;
                decimal outOfWorkInsPercent = BOSApp.CurrentCompanyInfo.CSCompanyOutOfWorkInsPercent;
                decimal syndicatePercent = BOSApp.CurrentCompanyInfo.CSCompanySyndicatePercent;
                if (objEmployeesInfo.HRInsCalculatedSalaryType.Equals(CalculatedSalaryType.Basic.ToString()))
                {
                    decimal contractSalary = objEmployeesInfo.HREmployeeContractSlrAmt * objEmployeesInfo.HREmployeeSalaryFactor;
                    employeePayroll.HREmployeePayRollInsSalary = contractSalary;
                    employeePayroll.HREmployeePayRollBussinessSocialInsAmount = contractSalary * (socialInsPercent - objEmployeesInfo.HREmployeeSocialInsPaymentPercent) / 100;
                    employeePayroll.HREmployeePayRollBussinessHealthInsAmount = contractSalary * (healthInsPercent - objEmployeesInfo.HREmployeeHealthInsPaymentPercent) / 100;
                    if (objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent > 0)
                    {
                        employeePayroll.HREmployeePayRollBussinessOutOfWorkInsAmount = contractSalary * (outOfWorkInsPercent - objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent) / 100;
                    }
                    employeePayroll.HREmployeePayRollBusinessSyndicateFee = contractSalary * syndicatePercent / 100;

                }
                else if (objEmployeesInfo.HRInsCalculatedSalaryType.Equals(CalculatedSalaryType.Working.ToString()))
                {
                    employeePayroll.HREmployeePayRollInsSalary = objEmployeesInfo.HREmployeeWorkingSlrAmt;
                    employeePayroll.HREmployeePayRollBussinessSocialInsAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt * (socialInsPercent - objEmployeesInfo.HREmployeeSocialInsPaymentPercent) / 100;
                    employeePayroll.HREmployeePayRollBussinessHealthInsAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt * (healthInsPercent - objEmployeesInfo.HREmployeeHealthInsPaymentPercent) / 100;
                    if (objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent > 0)
                    {
                        employeePayroll.HREmployeePayRollBussinessOutOfWorkInsAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt * (outOfWorkInsPercent - objEmployeesInfo.HREmployeeOutOfWorkInsPaymentPercent) / 100;
                    }
                    employeePayroll.HREmployeePayRollBusinessSyndicateFee = objEmployeesInfo.HREmployeeWorkingSlrAmt * syndicatePercent / 100;
                }
            }
        }
    }
}
