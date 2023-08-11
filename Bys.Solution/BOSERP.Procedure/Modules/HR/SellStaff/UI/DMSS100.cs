using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMMEEM101
    /// </summary>
    public partial class DMSS100 : BOSERPScreen
    {

        public DMSS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtHREmployeeContractSlrAmt_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeContractSalary();
        }

        private void fld_txtHREmployeeSalaryFactor_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeContractSalaryFactor();
        }

        private void fld_txtHREmployeeWorkingSlrAmt_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeWorkingSalary();
        }

        private void fld_txtHREmployeeDaysPerMonth_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeDaysPerMonth();
        }

        private void fld_txtHREmployeeHoursPerDay_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeHoursPerDay();
        }

        private void fld_txtHREmployeeProbationaryMonth_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_HREmployeePayrollFormulaID_QueryPopUp(object sender, CancelEventArgs e)
        {
            //HREmployeePayrollFormulasController objEmployeePayrollFormulasController = new HREmployeePayrollFormulasController();
            //List<HREmployeePayrollFormulasInfo> list = new List<HREmployeePayrollFormulasInfo>();
            //list = objEmployeePayrollFormulasController.GetAllEmployeePayrollFormulas();
            //if (list != null)
            //{
            //    list.Insert(0, new HREmployeePayrollFormulasInfo());
            //}
            //fld_lkeFK_HREmployeePayrollFormulaID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRAllowanceManageConfigID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lookup = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lookup.OldEditValue)
            {
                int id = Convert.ToInt32(e.Value);
                ((SellStaffModule)Module).ChangeAllowanceConfig(id);
            }
        }

        private void fld_lkeFK_HRWorkingShiftID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> lstWorkingShifts = null;
            lstWorkingShifts = (List<HRWorkingShiftsInfo>)objWorkingShiftsController.GetListFromDataSet(objWorkingShiftsController.GetAllAliveObjects());
            if (lstWorkingShifts != null)
            {
                lstWorkingShifts.Insert(0, new HRWorkingShiftsInfo());
            }
            fld_lkeFK_HRWorkingShiftID.Properties.DataSource = lstWorkingShifts.Where(o => o.FK_HRWorkingShiftID == 0).ToList();
            fld_lkeFK_HRWorkingShiftID.EditValue = 0;
        }

        private void fld_lkeFK_HRConfigRankID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRConfigRanksController objConfigRanksController = new HRConfigRanksController();
            int id = Convert.ToInt32(fld_lkeFK_HRConfigScaleID.EditValue);
            List<HRConfigRanksInfo> list = new List<HRConfigRanksInfo>();
            list = (List<HRConfigRanksInfo>)objConfigRanksController.GetListFromDataSet(objConfigRanksController.GetAllDataByForeignColumn("FK_HRConfigScaleID", id));
            if (list != null)
            {
                list.Insert(0, new HRConfigRanksInfo());
            }
            fld_lkeFK_HRConfigRankID.Properties.DataSource = list;
        }

        private void fld_lkeFK_HRConfigRankID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            HRConfigRanksController objConfigRanksController = new HRConfigRanksController();
            int id = Convert.ToInt32(e.Value);
            HRConfigRanksInfo objConfigRanksInfo = new HRConfigRanksInfo();
            objConfigRanksInfo = (HRConfigRanksInfo)objConfigRanksController.GetObjectByID(id);
            if (objConfigRanksInfo != null && objConfigRanksInfo.IsUpdate)
            {
                ((SellStaffModule)Module).ChangeConfigRankSalary(objConfigRanksInfo);
            }
        }

        private void fld_lkeFK_HRAllowanceManageConfigID_QueryPopUp(object sender, CancelEventArgs e)
        {
            HRAllowanceManageConfigsController objAllowanceManageConfigsController = new HRAllowanceManageConfigsController();
            List<HRAllowanceManageConfigsInfo> lstObj = (List<HRAllowanceManageConfigsInfo>)objAllowanceManageConfigsController.GetListFromDataSet(objAllowanceManageConfigsController.GetAllObjects());
            fld_lkeFK_HRAllowanceManageConfigID.Properties.DataSource = lstObj.Where(o => BOSApp.GetCurrentServerDate().Subtract(o.HRAllowanceManageConfigFromDate).TotalDays >= 0 && BOSApp.GetCurrentServerDate().Subtract(o.HRAllowanceManageConfigToDate).TotalDays <= 0).ToList();
        }

        private void fld_txtHREmployeePercentContractSlrAmt_Validated(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).UpdateSalaryInfo();
        }

        private void Fld_ceHREmployeeHaveInsurrance_MouseClick(object sender, MouseEventArgs e)
        {
            if (!fld_ceHREmployeeHaveInsurrance.Checked)
            {
                ((SellStaffModule)Module).UpdateInsurrances();
            }
        }
    }
}
