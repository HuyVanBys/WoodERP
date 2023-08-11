using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS105
    /// </summary>
    public partial class DMCS105 : BOSERPScreen
    {
        public DMCS105()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            // Load working time config
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            fld_txtDaysPerMonth.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.DaysPerMonth.ToString()).ADConfigKeyValue;
            fld_txtHoursPerDay.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.HoursPerDay.ToString()).ADConfigKeyValue;
            // Load leave days config
            fld_txtAnnualLeaveDays.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.AnnualLeaveDays.ToString()).ADConfigKeyValue;
            fld_txtSickLeaveDays.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SickLeaveDays.ToString()).ADConfigKeyValue;
            fld_txtBirthLeaveDays.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.BirthLeaveDays.ToString()).ADConfigKeyValue;
            fld_txtOTLeaveDays.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTLeaveDays.ToString()).ADConfigKeyValue;
            fld_txtNormalLeaveDays.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.NormalLeaveDays.ToString()).ADConfigKeyValue;

            // Load Over time Audit config
            fld_txtOTAuditMonth.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTAuditMonth.ToString()).ADConfigKeyValue;
            fld_txtOTAuditDay.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTAuditDay.ToString()).ADConfigKeyValue;

            // Load Over time config
            fld_txtOTFromTime.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTFromTime.ToString()).ADConfigKeyValue;
            fld_txtOTToTime.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTToTime.ToString()).ADConfigKeyValue;
            fld_txtOTValueTime.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTValueTime.ToString()).ADConfigKeyValue;
            fld_txtSubtractOT.EditValue = objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SubtractOT.ToString()).ADConfigKeyValue;
        }

        private void fld_btnButton2_Click(object sender, EventArgs e)
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveStaffConfig();
        }
        public void InvalidateEmployeeSalaryConfig()
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).InvalidateEmployeeSalaryConfig();
        }
        public void InvalidateAppUserPermission()
        {
            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).InvalidateAppUserPermission();
        }
        public void InvalidateErrorType()
        {

        }
        private void fld_lkeConfigGroup_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<ADConfigValuesInfo> ConfigValuesList = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).GetConfigGroupDataSource(ConfigValueGroup.AppUserPermissionType, string.Empty);
            fld_lkeConfigGroup.Properties.DataSource = ConfigValuesList;
        }

        private void fld_lkeConfigFunction_QueryPopUp(object sender, CancelEventArgs e)
        {
            string descType = string.Empty;
            if (fld_lkeConfigGroup.EditValue != null)
                descType = fld_lkeConfigGroup.EditValue.ToString();
            List<ADConfigValuesInfo> ConfigValuesList = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).GetConfigGroupDataSource(ConfigValueGroup.AppUserPermissionFunctionCode, descType);
            fld_lkeConfigFunction.Properties.DataSource = ConfigValuesList;
        }

        private void fld_btnAddGroup_Click(object sender, EventArgs e)
        {
            string descType = string.Empty;
            string functionCode = string.Empty;
            int groupID = 0;

            if (fld_lkeConfigGroup.EditValue != null)
                descType = fld_lkeConfigGroup.EditValue.ToString();
            if (fld_lkeConfigFunction.EditValue != null)
                functionCode = fld_lkeConfigFunction.EditValue.ToString();
            if (fld_lkeADUserGroupID.EditValue != null)
                groupID = int.Parse(fld_lkeADUserGroupID.EditValue.ToString());

            ((Modules.CompanyConstant.CompanyConstantModule)this.Module).AddAppUserPermission(descType, functionCode, groupID);
        }

        private void fld_btnSaveInsurrances_Click(object sender, EventArgs e)
        {
            bool check = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveInsurrances();
            if (check)
            {
                XtraMessageBox.Show("Luu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fld_btnSaveTimesheetConfigs_Click(object sender, EventArgs e)
        {
            bool check = ((Modules.CompanyConstant.CompanyConstantModule)this.Module).SaveTimesheetConfig();
            if (check)
            {
                XtraMessageBox.Show("Luu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fld_btnSaveScale_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveScales();
        }

        private void fld_btnSaveRank_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveRanks();
        }

        private void fld_btnSaveAllowanceManageConfigs_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveHRAllowanceManageConfigs();
        }

        private void fld_btnSaveRelationships_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveRelationships();
        }

        private void BosButton1_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveATMCardManageConfigs();
        }

        private void BosButton2_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)this.Module).SaveInsurranceButtons();
        }
    }
}
