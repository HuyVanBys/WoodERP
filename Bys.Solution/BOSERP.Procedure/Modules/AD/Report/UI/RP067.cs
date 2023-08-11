using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP067 : ReportForm
    {
        public RP067()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            RPPayRollCard report = new RPPayRollCard();
            InitPayRollReport(report);
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }

        private void RP067_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromMonth.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteToMonth.DateTime = BOSUtil.GetYearEndDate();

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
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            //Set payroll date
            DateTime fromMonth = fld_dteFromMonth.DateTime;
            DateTime toMonth = fld_dteToMonth.DateTime;
            XRLabel dateTitle = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblDateTitle"];
            if (dateTitle != null)
            {
                dateTitle.Text = string.Format("{0} {1} {2} {3}",
                                                ReportLocalizedResources.FromMonth,
                                                fromMonth.ToString("MM/yyyy"),
                                                ReportLocalizedResources.ToMonth,
                                                toMonth.ToString("MM/yyyy"));
            }
            ADReportsController objReportsController = new ADReportsController();
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeHRDepartmentID.EditValue);
            int departmentRoomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            List<HREmployeePayRollsInfo> employeePayRolls = objReportsController.GetPayRollCard(locationID, branchID, departmentID, departmentRoomID, employeeID, fromMonth, toMonth);
            foreach (HREmployeePayRollsInfo employeePayRoll in employeePayRolls)
            {
                CalculatePayRollTotalAmounts(employeePayRoll);
            }
            report.DataSource = employeePayRolls;
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

            //Calcalate total additional amount
            objEmployeePayRollsInfo.HREmployeePayRollTotalAddAmt = objEmployeePayRollsInfo.HREmployeePayRollCommission +
                                                                    objEmployeePayRollsInfo.HREmployeePayRollReward +
                                                                    objEmployeePayRollsInfo.HREmployeePayRollExtraSalary;

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

            //Calculate total salary
            objEmployeePayRollsInfo.HREmployeePayRollTotalSalary = Convert.ToDecimal(BOSUtil.RoundToThousand(Convert.ToDouble(objEmployeePayRollsInfo.HREmployeePayRollTotalWorkingSalary +
                                                                    objEmployeePayRollsInfo.HREmployeePayRollTotalAddAmt -
                                                                    objEmployeePayRollsInfo.HREmployeePayRollTotalDeductedAmt)));
        }
    }
}
