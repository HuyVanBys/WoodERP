using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS105
    /// </summary>
    partial class DMCS105
    {


        /// <summary>
        /// Clean up any resources being used
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (components != null)
                    components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS105));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.fld_tabHumanResource = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabOvertimeConfig = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRTimeSheetParam2s = new BOSERP.Modules.CompanyConstant.HRTimeSheetParam2GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPayrollConfig = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRTimeSheetParams = new BOSERP.Modules.CompanyConstant.HRTimeSheetParamGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_grpGroupControl15 = new BOSComponent.BOSLine(this.components);
            this.fld_txtNormalLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtOTLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBirthLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtSickLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAnnualLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtOTToTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtOTValueTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtOTFromTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtSubtractOT = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtOTAuditDay = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtOTAuditMonth = new BOSComponent.BOSTextBox(this.components);
            this.fld_grpGroupControl14 = new BOSComponent.BOSLine(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHoursPerDay = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtDaysPerMonth = new BOSComponent.BOSTextBox(this.components);
            this.fld_grpGroupControl13 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcHRWorkingShifts = new BOSERP.Modules.CompanyConstant.WorkingShiftGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcHREmployeePieceWorks = new BOSERP.Modules.CompanyConstant.HREmployeePieceWorksGridControl();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcHRSalaryTypeGridControl = new BOSERP.Modules.CompanyConstant.HRSalaryTypeGridControl();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHREmployeeSalaryConfigs = new BOSERP.Modules.CompanyConstant.EmployeeSalaryConfigsGridControl();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADConfigValues = new BOSERP.Modules.CompanyConstant.HRTimeSheetParam3GridControl();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcTrainingCourse = new BOSERP.Modules.CompanyConstant.TrainingCoursesGridControl();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabUserAppPermission = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddGroup = new BOSComponent.BOSButton(this.components);
            this.fld_lkeADUserGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeConfigFunction = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeConfigGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcADAppUserPermissions = new BOSERP.Modules.CompanyConstant.AppUserPermissionsGridControl();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRErrorTypes = new BOSERP.Modules.CompanyConstant.ErrorTypesGridControl();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRAllowanceManageConfigHistorys = new BOSERP.Modules.CompanyConstant.HRAllowanceManageConfigHistorysGridControl();
            this.gridView24 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fld_btnSaveAllowanceManageConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRAllowanceManageConfigs = new BOSERP.Modules.CompanyConstant.HRAllowanceManageConfigsGridControl();
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.fld_dgcADInsurrancePlans = new BOSERP.Modules.CompanyConstant.ADInsurrancePlansGridControl();
            this.gridView27 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.fld_dgcADInsurrancePapers = new BOSERP.Modules.CompanyConstant.ADInsurrancePapersGridControl();
            this.gridView28 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.fld_dgcADInsurranceConditions = new BOSERP.Modules.CompanyConstant.ADInsurranceConditionsGridControl();
            this.gridView29 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRATMCardManageConfigs = new BOSERP.Modules.CompanyConstant.HRATMCardManageConfigsGridControl();
            this.gridView26 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceHealthInsPercentNext = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceSocialInsPercentNext = new BOSComponent.BOSTextBox(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceHealthInsPercentPrevious = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceSocialInsPercentPrevious = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRInsurranceDateApply = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtADInsurranceDependencyLevel = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtADInsurranceLevelNotTaxable = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceSocialInsPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceHealthInsPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRInsurranceHealthInsPercentDN = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRInsurranceOutOfWorkInsPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRInsurranceSocialInsPercentDN = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSaveInsurrances = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADTimesheetConfigs = new BOSERP.Modules.CompanyConstant.ADTimesheetConfigsGridControl();
            this.gridView41 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveTimesheetConfigs = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRConfigRanks = new BOSERP.Modules.CompanyConstant.HRConfigRanksGridControl();
            this.gridView19 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveRank = new BOSComponent.BOSButton(this.components);
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRConfigScales = new BOSERP.Modules.CompanyConstant.HRConfigScalesGridControl();
            this.gridView18 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveScale = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRSeniorityLeaveDayConfigs = new BOSERP.Modules.CompanyConstant.HRSeniorityLeaveDayConfigsGridControl();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs = new BOSERP.Modules.CompanyConstant.HRDepartmentRoomLeaveDayConfigsGridControl();
            this.gridView22 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHROtherLeaveDayConfigs = new BOSERP.Modules.CompanyConstant.HROtherLeaveDayConfigsGridControl();
            this.gridView23 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRAnnualLeaveDayConfigs = new BOSERP.Modules.CompanyConstant.HRAnnualLeaveDayConfigsGridControl();
            this.gridView20 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage13 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fld_dgcHRRelationships = new BOSERP.Modules.CompanyConstant.HRRelationshipsGridControl();
            this.gridView25 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveRelationships = new BOSComponent.BOSButton(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView32 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView33 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView34 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHumanResource)).BeginInit();
            this.fld_tabHumanResource.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabOvertimeConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetParam2s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.fld_tabPayrollConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.fld_grpGroupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtNormalLeaveDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTLeaveDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBirthLeaveDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSickLeaveDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAnnualLeaveDays.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTToTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTValueTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTFromTime.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubtractOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTAuditDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTAuditMonth.Properties)).BeginInit();
            this.fld_grpGroupControl14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHoursPerDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDaysPerMonth.Properties)).BeginInit();
            this.fld_grpGroupControl13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRWorkingShifts)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSalaryTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSalaryConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADConfigValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTrainingCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            this.fld_tabUserAppPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeADUserGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeConfigFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeConfigGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADAppUserPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRErrorTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            this.xtraTabPage8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceManageConfigHistorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView24)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceManageConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            this.xtraTabPage9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurrancePlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurrancePapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView28)).BeginInit();
            this.groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurranceConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView29)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardManageConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView26)).BeginInit();
            this.bosLine3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentNext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentNext.Properties)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentPrevious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentPrevious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRInsurranceDateApply.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRInsurranceDateApply.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtADInsurranceDependencyLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtADInsurranceLevelNotTaxable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentDN.Properties)).BeginInit();
            this.xtraTabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTimesheetConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView41)).BeginInit();
            this.xtraTabPage11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigRanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).BeginInit();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigScales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).BeginInit();
            this.xtraTabPage12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSeniorityLeaveDayConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomLeaveDayConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROtherLeaveDayConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView23)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAnnualLeaveDayConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).BeginInit();
            this.xtraTabPage13.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRelationships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView34)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_tabHumanResource
            // 
            this.fld_tabHumanResource.BOSComment = null;
            this.fld_tabHumanResource.BOSDataMember = null;
            this.fld_tabHumanResource.BOSDataSource = null;
            this.fld_tabHumanResource.BOSDescription = null;
            this.fld_tabHumanResource.BOSError = null;
            this.fld_tabHumanResource.BOSFieldGroup = null;
            this.fld_tabHumanResource.BOSFieldRelation = null;
            this.fld_tabHumanResource.BOSPrivilege = null;
            this.fld_tabHumanResource.BOSPropertyName = null;
            resources.ApplyResources(this.fld_tabHumanResource, "fld_tabHumanResource");
            this.fld_tabHumanResource.Name = "fld_tabHumanResource";
            this.fld_tabHumanResource.Screen = null;
            this.fld_tabHumanResource.SelectedTabPage = this.xtraTabPage2;
            this.ScreenHelper.SetShowHelp(this.fld_tabHumanResource, ((bool)(resources.GetObject("fld_tabHumanResource.ShowHelp"))));
            this.fld_tabHumanResource.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage6,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.fld_tabUserAppPermission,
            this.xtraTabPage7,
            this.xtraTabPage8,
            this.xtraTabPage9,
            this.xtraTabPage10,
            this.xtraTabPage11,
            this.xtraTabPage12,
            this.xtraTabPage13});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_tabCompany);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage2, ((bool)(resources.GetObject("xtraTabPage2.ShowHelp"))));
            resources.ApplyResources(this.xtraTabPage2, "xtraTabPage2");
            // 
            // fld_tabCompany
            // 
            this.fld_tabCompany.BOSComment = null;
            this.fld_tabCompany.BOSDataMember = null;
            this.fld_tabCompany.BOSDataSource = null;
            this.fld_tabCompany.BOSDescription = null;
            this.fld_tabCompany.BOSError = null;
            this.fld_tabCompany.BOSFieldGroup = null;
            this.fld_tabCompany.BOSFieldRelation = null;
            this.fld_tabCompany.BOSPrivilege = null;
            this.fld_tabCompany.BOSPropertyName = null;
            resources.ApplyResources(this.fld_tabCompany, "fld_tabCompany");
            this.fld_tabCompany.Name = "fld_tabCompany";
            this.fld_tabCompany.Screen = null;
            this.fld_tabCompany.SelectedTabPage = this.fld_tabOvertimeConfig;
            this.ScreenHelper.SetShowHelp(this.fld_tabCompany, ((bool)(resources.GetObject("fld_tabCompany.ShowHelp"))));
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabOvertimeConfig,
            this.fld_tabPayrollConfig});
            // 
            // fld_tabOvertimeConfig
            // 
            resources.ApplyResources(this.fld_tabOvertimeConfig, "fld_tabOvertimeConfig");
            this.fld_tabOvertimeConfig.Controls.Add(this.fld_dgcHRTimeSheetParam2s);
            this.fld_tabOvertimeConfig.Name = "fld_tabOvertimeConfig";
            // 
            // fld_dgcHRTimeSheetParam2s
            // 
            this.fld_dgcHRTimeSheetParam2s.AllowDrop = true;
            this.fld_dgcHRTimeSheetParam2s.BOSComment = "";
            this.fld_dgcHRTimeSheetParam2s.BOSDataMember = null;
            this.fld_dgcHRTimeSheetParam2s.BOSDataSource = "HRTimeSheetParams";
            this.fld_dgcHRTimeSheetParam2s.BOSDescription = null;
            this.fld_dgcHRTimeSheetParam2s.BOSError = "";
            this.fld_dgcHRTimeSheetParam2s.BOSFieldGroup = "";
            this.fld_dgcHRTimeSheetParam2s.BOSFieldRelation = null;
            this.fld_dgcHRTimeSheetParam2s.BOSGridType = null;
            this.fld_dgcHRTimeSheetParam2s.BOSPrivilege = "";
            this.fld_dgcHRTimeSheetParam2s.BOSPropertyName = null;
            this.fld_dgcHRTimeSheetParam2s.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRTimeSheetParam2s, "fld_dgcHRTimeSheetParam2s");
            this.fld_dgcHRTimeSheetParam2s.MainView = this.gridView2;
            this.fld_dgcHRTimeSheetParam2s.Name = "fld_dgcHRTimeSheetParam2s";
            this.fld_dgcHRTimeSheetParam2s.PrintReport = false;
            this.fld_dgcHRTimeSheetParam2s.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRTimeSheetParam2s, ((bool)(resources.GetObject("fld_dgcHRTimeSheetParam2s.ShowHelp"))));
            this.fld_dgcHRTimeSheetParam2s.Tag = "DC";
            this.fld_dgcHRTimeSheetParam2s.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHRTimeSheetParam2s;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_tabPayrollConfig
            // 
            this.fld_tabPayrollConfig.Controls.Add(this.fld_dgcHRTimeSheetParams);
            this.fld_tabPayrollConfig.Name = "fld_tabPayrollConfig";
            resources.ApplyResources(this.fld_tabPayrollConfig, "fld_tabPayrollConfig");
            // 
            // fld_dgcHRTimeSheetParams
            // 
            this.fld_dgcHRTimeSheetParams.AllowDrop = true;
            this.fld_dgcHRTimeSheetParams.BOSComment = "";
            this.fld_dgcHRTimeSheetParams.BOSDataMember = null;
            this.fld_dgcHRTimeSheetParams.BOSDataSource = "HRTimeSheetParams";
            this.fld_dgcHRTimeSheetParams.BOSDescription = null;
            this.fld_dgcHRTimeSheetParams.BOSError = "";
            this.fld_dgcHRTimeSheetParams.BOSFieldGroup = "";
            this.fld_dgcHRTimeSheetParams.BOSFieldRelation = null;
            this.fld_dgcHRTimeSheetParams.BOSGridType = null;
            this.fld_dgcHRTimeSheetParams.BOSPrivilege = "";
            this.fld_dgcHRTimeSheetParams.BOSPropertyName = null;
            this.fld_dgcHRTimeSheetParams.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRTimeSheetParams, "fld_dgcHRTimeSheetParams");
            gridLevelNode1.RelationName = "Level1";
            this.fld_dgcHRTimeSheetParams.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.fld_dgcHRTimeSheetParams.MainView = this.gridView1;
            this.fld_dgcHRTimeSheetParams.Name = "fld_dgcHRTimeSheetParams";
            this.fld_dgcHRTimeSheetParams.PrintReport = false;
            this.fld_dgcHRTimeSheetParams.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRTimeSheetParams, ((bool)(resources.GetObject("fld_dgcHRTimeSheetParams.ShowHelp"))));
            this.fld_dgcHRTimeSheetParams.Tag = "DC";
            this.fld_dgcHRTimeSheetParams.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHRTimeSheetParams;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_grpGroupControl15);
            this.xtraTabPage1.Controls.Add(this.bosLine2);
            this.xtraTabPage1.Controls.Add(this.bosLine1);
            this.xtraTabPage1.Controls.Add(this.fld_grpGroupControl14);
            this.xtraTabPage1.Controls.Add(this.fld_grpGroupControl13);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage1, ((bool)(resources.GetObject("xtraTabPage1.ShowHelp"))));
            resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
            // 
            // fld_grpGroupControl15
            // 
            this.fld_grpGroupControl15.BOSComment = null;
            this.fld_grpGroupControl15.BOSDataMember = null;
            this.fld_grpGroupControl15.BOSDataSource = null;
            this.fld_grpGroupControl15.BOSDescription = null;
            this.fld_grpGroupControl15.BOSError = null;
            this.fld_grpGroupControl15.BOSFieldGroup = null;
            this.fld_grpGroupControl15.BOSFieldRelation = null;
            this.fld_grpGroupControl15.BOSPrivilege = null;
            this.fld_grpGroupControl15.BOSPropertyName = null;
            this.fld_grpGroupControl15.Controls.Add(this.fld_txtNormalLeaveDays);
            this.fld_grpGroupControl15.Controls.Add(this.fld_txtOTLeaveDays);
            this.fld_grpGroupControl15.Controls.Add(this.fld_txtBirthLeaveDays);
            this.fld_grpGroupControl15.Controls.Add(this.fld_txtSickLeaveDays);
            this.fld_grpGroupControl15.Controls.Add(this.fld_txtAnnualLeaveDays);
            this.fld_grpGroupControl15.Controls.Add(this.bosLabel5);
            this.fld_grpGroupControl15.Controls.Add(this.bosLabel4);
            this.fld_grpGroupControl15.Controls.Add(this.bosLabel3);
            this.fld_grpGroupControl15.Controls.Add(this.bosLabel2);
            this.fld_grpGroupControl15.Controls.Add(this.bosLabel1);
            resources.ApplyResources(this.fld_grpGroupControl15, "fld_grpGroupControl15");
            this.fld_grpGroupControl15.Name = "fld_grpGroupControl15";
            this.fld_grpGroupControl15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grpGroupControl15, ((bool)(resources.GetObject("fld_grpGroupControl15.ShowHelp"))));
            this.fld_grpGroupControl15.TabStop = false;
            // 
            // fld_txtNormalLeaveDays
            // 
            this.fld_txtNormalLeaveDays.BOSComment = null;
            this.fld_txtNormalLeaveDays.BOSDataMember = null;
            this.fld_txtNormalLeaveDays.BOSDataSource = null;
            this.fld_txtNormalLeaveDays.BOSDescription = null;
            this.fld_txtNormalLeaveDays.BOSError = null;
            this.fld_txtNormalLeaveDays.BOSFieldGroup = null;
            this.fld_txtNormalLeaveDays.BOSFieldRelation = null;
            this.fld_txtNormalLeaveDays.BOSPrivilege = null;
            this.fld_txtNormalLeaveDays.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtNormalLeaveDays, "fld_txtNormalLeaveDays");
            this.fld_txtNormalLeaveDays.MenuManager = this.screenToolbar;
            this.fld_txtNormalLeaveDays.Name = "fld_txtNormalLeaveDays";
            this.fld_txtNormalLeaveDays.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtNormalLeaveDays, ((bool)(resources.GetObject("fld_txtNormalLeaveDays.ShowHelp"))));
            // 
            // fld_txtOTLeaveDays
            // 
            this.fld_txtOTLeaveDays.BOSComment = null;
            this.fld_txtOTLeaveDays.BOSDataMember = null;
            this.fld_txtOTLeaveDays.BOSDataSource = null;
            this.fld_txtOTLeaveDays.BOSDescription = null;
            this.fld_txtOTLeaveDays.BOSError = null;
            this.fld_txtOTLeaveDays.BOSFieldGroup = null;
            this.fld_txtOTLeaveDays.BOSFieldRelation = null;
            this.fld_txtOTLeaveDays.BOSPrivilege = null;
            this.fld_txtOTLeaveDays.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTLeaveDays, "fld_txtOTLeaveDays");
            this.fld_txtOTLeaveDays.MenuManager = this.screenToolbar;
            this.fld_txtOTLeaveDays.Name = "fld_txtOTLeaveDays";
            this.fld_txtOTLeaveDays.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTLeaveDays, ((bool)(resources.GetObject("fld_txtOTLeaveDays.ShowHelp"))));
            // 
            // fld_txtBirthLeaveDays
            // 
            this.fld_txtBirthLeaveDays.BOSComment = null;
            this.fld_txtBirthLeaveDays.BOSDataMember = null;
            this.fld_txtBirthLeaveDays.BOSDataSource = null;
            this.fld_txtBirthLeaveDays.BOSDescription = null;
            this.fld_txtBirthLeaveDays.BOSError = null;
            this.fld_txtBirthLeaveDays.BOSFieldGroup = null;
            this.fld_txtBirthLeaveDays.BOSFieldRelation = null;
            this.fld_txtBirthLeaveDays.BOSPrivilege = null;
            this.fld_txtBirthLeaveDays.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtBirthLeaveDays, "fld_txtBirthLeaveDays");
            this.fld_txtBirthLeaveDays.MenuManager = this.screenToolbar;
            this.fld_txtBirthLeaveDays.Name = "fld_txtBirthLeaveDays";
            this.fld_txtBirthLeaveDays.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtBirthLeaveDays, ((bool)(resources.GetObject("fld_txtBirthLeaveDays.ShowHelp"))));
            // 
            // fld_txtSickLeaveDays
            // 
            this.fld_txtSickLeaveDays.BOSComment = null;
            this.fld_txtSickLeaveDays.BOSDataMember = null;
            this.fld_txtSickLeaveDays.BOSDataSource = null;
            this.fld_txtSickLeaveDays.BOSDescription = null;
            this.fld_txtSickLeaveDays.BOSError = null;
            this.fld_txtSickLeaveDays.BOSFieldGroup = null;
            this.fld_txtSickLeaveDays.BOSFieldRelation = null;
            this.fld_txtSickLeaveDays.BOSPrivilege = null;
            this.fld_txtSickLeaveDays.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtSickLeaveDays, "fld_txtSickLeaveDays");
            this.fld_txtSickLeaveDays.MenuManager = this.screenToolbar;
            this.fld_txtSickLeaveDays.Name = "fld_txtSickLeaveDays";
            this.fld_txtSickLeaveDays.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtSickLeaveDays, ((bool)(resources.GetObject("fld_txtSickLeaveDays.ShowHelp"))));
            // 
            // fld_txtAnnualLeaveDays
            // 
            this.fld_txtAnnualLeaveDays.BOSComment = null;
            this.fld_txtAnnualLeaveDays.BOSDataMember = null;
            this.fld_txtAnnualLeaveDays.BOSDataSource = null;
            this.fld_txtAnnualLeaveDays.BOSDescription = null;
            this.fld_txtAnnualLeaveDays.BOSError = null;
            this.fld_txtAnnualLeaveDays.BOSFieldGroup = null;
            this.fld_txtAnnualLeaveDays.BOSFieldRelation = null;
            this.fld_txtAnnualLeaveDays.BOSPrivilege = null;
            this.fld_txtAnnualLeaveDays.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtAnnualLeaveDays, "fld_txtAnnualLeaveDays");
            this.fld_txtAnnualLeaveDays.MenuManager = this.screenToolbar;
            this.fld_txtAnnualLeaveDays.Name = "fld_txtAnnualLeaveDays";
            this.fld_txtAnnualLeaveDays.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAnnualLeaveDays, ((bool)(resources.GetObject("fld_txtAnnualLeaveDays.ShowHelp"))));
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosLabel9);
            this.bosLine2.Controls.Add(this.fld_txtOTToTime);
            this.bosLine2.Controls.Add(this.bosLabel12);
            this.bosLine2.Controls.Add(this.fld_txtOTValueTime);
            this.bosLine2.Controls.Add(this.bosLabel10);
            this.bosLine2.Controls.Add(this.fld_txtOTFromTime);
            resources.ApplyResources(this.bosLine2, "bosLine2");
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine2, ((bool)(resources.GetObject("bosLine2.ShowHelp"))));
            this.bosLine2.TabStop = false;
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel9, "bosLabel9");
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, ((bool)(resources.GetObject("bosLabel9.ShowHelp"))));
            // 
            // fld_txtOTToTime
            // 
            this.fld_txtOTToTime.BOSComment = null;
            this.fld_txtOTToTime.BOSDataMember = null;
            this.fld_txtOTToTime.BOSDataSource = null;
            this.fld_txtOTToTime.BOSDescription = null;
            this.fld_txtOTToTime.BOSError = null;
            this.fld_txtOTToTime.BOSFieldGroup = null;
            this.fld_txtOTToTime.BOSFieldRelation = null;
            this.fld_txtOTToTime.BOSPrivilege = null;
            this.fld_txtOTToTime.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTToTime, "fld_txtOTToTime");
            this.fld_txtOTToTime.Name = "fld_txtOTToTime";
            this.fld_txtOTToTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.fld_txtOTToTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtOTToTime.Properties.Mask.EditMask = resources.GetString("fld_txtOTToTime.Properties.Mask.EditMask");
            this.fld_txtOTToTime.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtOTToTime.Properties.Mask.MaskType")));
            this.fld_txtOTToTime.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTToTime, ((bool)(resources.GetObject("fld_txtOTToTime.ShowHelp"))));
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel12, "bosLabel12");
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, ((bool)(resources.GetObject("bosLabel12.ShowHelp"))));
            // 
            // fld_txtOTValueTime
            // 
            this.fld_txtOTValueTime.BOSComment = null;
            this.fld_txtOTValueTime.BOSDataMember = null;
            this.fld_txtOTValueTime.BOSDataSource = null;
            this.fld_txtOTValueTime.BOSDescription = null;
            this.fld_txtOTValueTime.BOSError = null;
            this.fld_txtOTValueTime.BOSFieldGroup = null;
            this.fld_txtOTValueTime.BOSFieldRelation = null;
            this.fld_txtOTValueTime.BOSPrivilege = null;
            this.fld_txtOTValueTime.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTValueTime, "fld_txtOTValueTime");
            this.fld_txtOTValueTime.Name = "fld_txtOTValueTime";
            this.fld_txtOTValueTime.Properties.Mask.EditMask = resources.GetString("fld_txtOTValueTime.Properties.Mask.EditMask");
            this.fld_txtOTValueTime.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtOTValueTime.Properties.Mask.MaskType")));
            this.fld_txtOTValueTime.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTValueTime, ((bool)(resources.GetObject("fld_txtOTValueTime.ShowHelp"))));
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
            // 
            // fld_txtOTFromTime
            // 
            this.fld_txtOTFromTime.BOSComment = null;
            this.fld_txtOTFromTime.BOSDataMember = null;
            this.fld_txtOTFromTime.BOSDataSource = null;
            this.fld_txtOTFromTime.BOSDescription = null;
            this.fld_txtOTFromTime.BOSError = null;
            this.fld_txtOTFromTime.BOSFieldGroup = null;
            this.fld_txtOTFromTime.BOSFieldRelation = null;
            this.fld_txtOTFromTime.BOSPrivilege = null;
            this.fld_txtOTFromTime.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTFromTime, "fld_txtOTFromTime");
            this.fld_txtOTFromTime.Name = "fld_txtOTFromTime";
            this.fld_txtOTFromTime.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.fld_txtOTFromTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtOTFromTime.Properties.Mask.EditMask = resources.GetString("fld_txtOTFromTime.Properties.Mask.EditMask");
            this.fld_txtOTFromTime.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtOTFromTime.Properties.Mask.MaskType")));
            this.fld_txtOTFromTime.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTFromTime, ((bool)(resources.GetObject("fld_txtOTFromTime.ShowHelp"))));
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_txtSubtractOT);
            this.bosLine1.Controls.Add(this.bosLabel24);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.fld_txtOTAuditDay);
            this.bosLine1.Controls.Add(this.bosLabel8);
            this.bosLine1.Controls.Add(this.fld_txtOTAuditMonth);
            resources.ApplyResources(this.bosLine1, "bosLine1");
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_txtSubtractOT
            // 
            this.fld_txtSubtractOT.BOSComment = null;
            this.fld_txtSubtractOT.BOSDataMember = null;
            this.fld_txtSubtractOT.BOSDataSource = null;
            this.fld_txtSubtractOT.BOSDescription = null;
            this.fld_txtSubtractOT.BOSError = null;
            this.fld_txtSubtractOT.BOSFieldGroup = null;
            this.fld_txtSubtractOT.BOSFieldRelation = null;
            this.fld_txtSubtractOT.BOSPrivilege = null;
            this.fld_txtSubtractOT.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtSubtractOT, "fld_txtSubtractOT");
            this.fld_txtSubtractOT.Name = "fld_txtSubtractOT";
            this.fld_txtSubtractOT.Properties.Mask.EditMask = resources.GetString("fld_txtSubtractOT.Properties.Mask.EditMask");
            this.fld_txtSubtractOT.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtSubtractOT.Properties.Mask.MaskType")));
            this.fld_txtSubtractOT.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtSubtractOT, ((bool)(resources.GetObject("fld_txtSubtractOT.ShowHelp"))));
            // 
            // bosLabel24
            // 
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel24, "bosLabel24");
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, ((bool)(resources.GetObject("bosLabel24.ShowHelp"))));
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            // 
            // fld_txtOTAuditDay
            // 
            this.fld_txtOTAuditDay.BOSComment = null;
            this.fld_txtOTAuditDay.BOSDataMember = null;
            this.fld_txtOTAuditDay.BOSDataSource = null;
            this.fld_txtOTAuditDay.BOSDescription = null;
            this.fld_txtOTAuditDay.BOSError = null;
            this.fld_txtOTAuditDay.BOSFieldGroup = null;
            this.fld_txtOTAuditDay.BOSFieldRelation = null;
            this.fld_txtOTAuditDay.BOSPrivilege = null;
            this.fld_txtOTAuditDay.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTAuditDay, "fld_txtOTAuditDay");
            this.fld_txtOTAuditDay.Name = "fld_txtOTAuditDay";
            this.fld_txtOTAuditDay.Properties.Mask.EditMask = resources.GetString("fld_txtOTAuditDay.Properties.Mask.EditMask");
            this.fld_txtOTAuditDay.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtOTAuditDay.Properties.Mask.MaskType")));
            this.fld_txtOTAuditDay.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTAuditDay, ((bool)(resources.GetObject("fld_txtOTAuditDay.ShowHelp"))));
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, ((bool)(resources.GetObject("bosLabel8.ShowHelp"))));
            // 
            // fld_txtOTAuditMonth
            // 
            this.fld_txtOTAuditMonth.BOSComment = null;
            this.fld_txtOTAuditMonth.BOSDataMember = null;
            this.fld_txtOTAuditMonth.BOSDataSource = null;
            this.fld_txtOTAuditMonth.BOSDescription = null;
            this.fld_txtOTAuditMonth.BOSError = null;
            this.fld_txtOTAuditMonth.BOSFieldGroup = null;
            this.fld_txtOTAuditMonth.BOSFieldRelation = null;
            this.fld_txtOTAuditMonth.BOSPrivilege = null;
            this.fld_txtOTAuditMonth.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtOTAuditMonth, "fld_txtOTAuditMonth");
            this.fld_txtOTAuditMonth.Name = "fld_txtOTAuditMonth";
            this.fld_txtOTAuditMonth.Properties.Mask.EditMask = resources.GetString("fld_txtOTAuditMonth.Properties.Mask.EditMask");
            this.fld_txtOTAuditMonth.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtOTAuditMonth.Properties.Mask.MaskType")));
            this.fld_txtOTAuditMonth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtOTAuditMonth, ((bool)(resources.GetObject("fld_txtOTAuditMonth.ShowHelp"))));
            // 
            // fld_grpGroupControl14
            // 
            this.fld_grpGroupControl14.BOSComment = null;
            this.fld_grpGroupControl14.BOSDataMember = null;
            this.fld_grpGroupControl14.BOSDataSource = null;
            this.fld_grpGroupControl14.BOSDescription = null;
            this.fld_grpGroupControl14.BOSError = null;
            this.fld_grpGroupControl14.BOSFieldGroup = null;
            this.fld_grpGroupControl14.BOSFieldRelation = null;
            this.fld_grpGroupControl14.BOSPrivilege = null;
            this.fld_grpGroupControl14.BOSPropertyName = null;
            this.fld_grpGroupControl14.Controls.Add(this.bosLabel7);
            this.fld_grpGroupControl14.Controls.Add(this.bosLabel11);
            this.fld_grpGroupControl14.Controls.Add(this.fld_txtHoursPerDay);
            this.fld_grpGroupControl14.Controls.Add(this.fld_txtDaysPerMonth);
            resources.ApplyResources(this.fld_grpGroupControl14, "fld_grpGroupControl14");
            this.fld_grpGroupControl14.Name = "fld_grpGroupControl14";
            this.fld_grpGroupControl14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grpGroupControl14, ((bool)(resources.GetObject("fld_grpGroupControl14.ShowHelp"))));
            this.fld_grpGroupControl14.TabStop = false;
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel7, "bosLabel7");
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, ((bool)(resources.GetObject("bosLabel7.ShowHelp"))));
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel11, "bosLabel11");
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, ((bool)(resources.GetObject("bosLabel11.ShowHelp"))));
            // 
            // fld_txtHoursPerDay
            // 
            this.fld_txtHoursPerDay.BOSComment = null;
            this.fld_txtHoursPerDay.BOSDataMember = null;
            this.fld_txtHoursPerDay.BOSDataSource = null;
            this.fld_txtHoursPerDay.BOSDescription = null;
            this.fld_txtHoursPerDay.BOSError = null;
            this.fld_txtHoursPerDay.BOSFieldGroup = null;
            this.fld_txtHoursPerDay.BOSFieldRelation = null;
            this.fld_txtHoursPerDay.BOSPrivilege = null;
            this.fld_txtHoursPerDay.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHoursPerDay, "fld_txtHoursPerDay");
            this.fld_txtHoursPerDay.MenuManager = this.screenToolbar;
            this.fld_txtHoursPerDay.Name = "fld_txtHoursPerDay";
            this.fld_txtHoursPerDay.Properties.Mask.EditMask = resources.GetString("fld_txtHoursPerDay.Properties.Mask.EditMask");
            this.fld_txtHoursPerDay.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHoursPerDay.Properties.Mask.MaskType")));
            this.fld_txtHoursPerDay.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHoursPerDay, ((bool)(resources.GetObject("fld_txtHoursPerDay.ShowHelp"))));
            // 
            // fld_txtDaysPerMonth
            // 
            this.fld_txtDaysPerMonth.BOSComment = null;
            this.fld_txtDaysPerMonth.BOSDataMember = null;
            this.fld_txtDaysPerMonth.BOSDataSource = null;
            this.fld_txtDaysPerMonth.BOSDescription = null;
            this.fld_txtDaysPerMonth.BOSError = null;
            this.fld_txtDaysPerMonth.BOSFieldGroup = null;
            this.fld_txtDaysPerMonth.BOSFieldRelation = null;
            this.fld_txtDaysPerMonth.BOSPrivilege = null;
            this.fld_txtDaysPerMonth.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtDaysPerMonth, "fld_txtDaysPerMonth");
            this.fld_txtDaysPerMonth.MenuManager = this.screenToolbar;
            this.fld_txtDaysPerMonth.Name = "fld_txtDaysPerMonth";
            this.fld_txtDaysPerMonth.Properties.Mask.EditMask = resources.GetString("fld_txtDaysPerMonth.Properties.Mask.EditMask");
            this.fld_txtDaysPerMonth.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtDaysPerMonth.Properties.Mask.MaskType")));
            this.fld_txtDaysPerMonth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtDaysPerMonth, ((bool)(resources.GetObject("fld_txtDaysPerMonth.ShowHelp"))));
            // 
            // fld_grpGroupControl13
            // 
            this.fld_grpGroupControl13.BOSComment = null;
            this.fld_grpGroupControl13.BOSDataMember = null;
            this.fld_grpGroupControl13.BOSDataSource = null;
            this.fld_grpGroupControl13.BOSDescription = null;
            this.fld_grpGroupControl13.BOSError = null;
            this.fld_grpGroupControl13.BOSFieldGroup = null;
            this.fld_grpGroupControl13.BOSFieldRelation = null;
            this.fld_grpGroupControl13.BOSPrivilege = null;
            this.fld_grpGroupControl13.BOSPropertyName = null;
            this.fld_grpGroupControl13.Controls.Add(this.fld_dgcHRWorkingShifts);
            resources.ApplyResources(this.fld_grpGroupControl13, "fld_grpGroupControl13");
            this.fld_grpGroupControl13.Name = "fld_grpGroupControl13";
            this.fld_grpGroupControl13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grpGroupControl13, ((bool)(resources.GetObject("fld_grpGroupControl13.ShowHelp"))));
            this.fld_grpGroupControl13.TabStop = false;
            // 
            // fld_dgcHRWorkingShifts
            // 
            this.fld_dgcHRWorkingShifts.BOSComment = null;
            this.fld_dgcHRWorkingShifts.BOSDataMember = null;
            this.fld_dgcHRWorkingShifts.BOSDataSource = "HRWorkingShifts";
            this.fld_dgcHRWorkingShifts.BOSDescription = null;
            this.fld_dgcHRWorkingShifts.BOSError = null;
            this.fld_dgcHRWorkingShifts.BOSFieldGroup = null;
            this.fld_dgcHRWorkingShifts.BOSFieldRelation = null;
            this.fld_dgcHRWorkingShifts.BOSGridType = null;
            this.fld_dgcHRWorkingShifts.BOSPrivilege = null;
            this.fld_dgcHRWorkingShifts.BOSPropertyName = null;
            this.fld_dgcHRWorkingShifts.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRWorkingShifts, "fld_dgcHRWorkingShifts");
            this.fld_dgcHRWorkingShifts.MenuManager = this.screenToolbar;
            this.fld_dgcHRWorkingShifts.Name = "fld_dgcHRWorkingShifts";
            this.fld_dgcHRWorkingShifts.PrintReport = false;
            this.fld_dgcHRWorkingShifts.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRWorkingShifts, ((bool)(resources.GetObject("fld_dgcHRWorkingShifts.ShowHelp"))));
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosLine6);
            this.xtraTabPage3.Controls.Add(this.bosLine5);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, ((bool)(resources.GetObject("xtraTabPage3.ShowHelp"))));
            resources.ApplyResources(this.xtraTabPage3, "xtraTabPage3");
            // 
            // bosLine6
            // 
            resources.ApplyResources(this.bosLine6, "bosLine6");
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_dgcHREmployeePieceWorks);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine6, ((bool)(resources.GetObject("bosLine6.ShowHelp"))));
            this.bosLine6.TabStop = false;
            // 
            // fld_dgcHREmployeePieceWorks
            // 
            this.fld_dgcHREmployeePieceWorks.AllowDrop = true;
            this.fld_dgcHREmployeePieceWorks.BOSComment = "";
            this.fld_dgcHREmployeePieceWorks.BOSDataMember = null;
            this.fld_dgcHREmployeePieceWorks.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dgcHREmployeePieceWorks.BOSDescription = null;
            this.fld_dgcHREmployeePieceWorks.BOSError = "";
            this.fld_dgcHREmployeePieceWorks.BOSFieldGroup = "";
            this.fld_dgcHREmployeePieceWorks.BOSFieldRelation = null;
            this.fld_dgcHREmployeePieceWorks.BOSGridType = null;
            this.fld_dgcHREmployeePieceWorks.BOSPrivilege = "";
            this.fld_dgcHREmployeePieceWorks.BOSPropertyName = null;
            this.fld_dgcHREmployeePieceWorks.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHREmployeePieceWorks, "fld_dgcHREmployeePieceWorks");
            this.fld_dgcHREmployeePieceWorks.MainView = this.gridView11;
            this.fld_dgcHREmployeePieceWorks.Name = "fld_dgcHREmployeePieceWorks";
            this.fld_dgcHREmployeePieceWorks.PrintReport = false;
            this.fld_dgcHREmployeePieceWorks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeePieceWorks, ((bool)(resources.GetObject("fld_dgcHREmployeePieceWorks.ShowHelp"))));
            this.fld_dgcHREmployeePieceWorks.Tag = "DC";
            this.fld_dgcHREmployeePieceWorks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView11});
            // 
            // gridView11
            // 
            this.gridView11.GridControl = this.fld_dgcHREmployeePieceWorks;
            this.gridView11.Name = "gridView11";
            this.gridView11.PaintStyleName = "Office2003";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_dgcHRSalaryTypeGridControl);
            resources.ApplyResources(this.bosLine5, "bosLine5");
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine5, ((bool)(resources.GetObject("bosLine5.ShowHelp"))));
            this.bosLine5.TabStop = false;
            // 
            // fld_dgcHRSalaryTypeGridControl
            // 
            this.fld_dgcHRSalaryTypeGridControl.AllowDrop = true;
            this.fld_dgcHRSalaryTypeGridControl.BOSComment = "";
            this.fld_dgcHRSalaryTypeGridControl.BOSDataMember = null;
            this.fld_dgcHRSalaryTypeGridControl.BOSDataSource = "HRTimesheetGroups";
            this.fld_dgcHRSalaryTypeGridControl.BOSDescription = null;
            this.fld_dgcHRSalaryTypeGridControl.BOSError = "";
            this.fld_dgcHRSalaryTypeGridControl.BOSFieldGroup = "";
            this.fld_dgcHRSalaryTypeGridControl.BOSFieldRelation = null;
            this.fld_dgcHRSalaryTypeGridControl.BOSGridType = null;
            this.fld_dgcHRSalaryTypeGridControl.BOSPrivilege = "";
            this.fld_dgcHRSalaryTypeGridControl.BOSPropertyName = null;
            this.fld_dgcHRSalaryTypeGridControl.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRSalaryTypeGridControl, "fld_dgcHRSalaryTypeGridControl");
            this.fld_dgcHRSalaryTypeGridControl.MainView = this.gridView10;
            this.fld_dgcHRSalaryTypeGridControl.Name = "fld_dgcHRSalaryTypeGridControl";
            this.fld_dgcHRSalaryTypeGridControl.PrintReport = false;
            this.fld_dgcHRSalaryTypeGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRSalaryTypeGridControl, ((bool)(resources.GetObject("fld_dgcHRSalaryTypeGridControl.ShowHelp"))));
            this.fld_dgcHRSalaryTypeGridControl.Tag = "DC";
            this.fld_dgcHRSalaryTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
            // 
            // gridView10
            // 
            this.gridView10.GridControl = this.fld_dgcHRSalaryTypeGridControl;
            this.gridView10.Name = "gridView10";
            this.gridView10.PaintStyleName = "Office2003";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.fld_dgcHREmployeeSalaryConfigs);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.PageVisible = false;
            resources.ApplyResources(this.xtraTabPage6, "xtraTabPage6");
            // 
            // fld_dgcHREmployeeSalaryConfigs
            // 
            this.fld_dgcHREmployeeSalaryConfigs.AllowDrop = true;
            this.fld_dgcHREmployeeSalaryConfigs.BOSComment = "";
            this.fld_dgcHREmployeeSalaryConfigs.BOSDataMember = null;
            this.fld_dgcHREmployeeSalaryConfigs.BOSDataSource = "HREmployeeSalaryConfigs";
            this.fld_dgcHREmployeeSalaryConfigs.BOSDescription = null;
            this.fld_dgcHREmployeeSalaryConfigs.BOSError = "";
            this.fld_dgcHREmployeeSalaryConfigs.BOSFieldGroup = "";
            this.fld_dgcHREmployeeSalaryConfigs.BOSFieldRelation = null;
            this.fld_dgcHREmployeeSalaryConfigs.BOSGridType = "";
            this.fld_dgcHREmployeeSalaryConfigs.BOSPrivilege = "";
            this.fld_dgcHREmployeeSalaryConfigs.BOSPropertyName = null;
            this.fld_dgcHREmployeeSalaryConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHREmployeeSalaryConfigs, "fld_dgcHREmployeeSalaryConfigs");
            this.fld_dgcHREmployeeSalaryConfigs.MainView = this.gridView14;
            this.fld_dgcHREmployeeSalaryConfigs.Name = "fld_dgcHREmployeeSalaryConfigs";
            this.fld_dgcHREmployeeSalaryConfigs.PrintReport = false;
            this.fld_dgcHREmployeeSalaryConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeSalaryConfigs, ((bool)(resources.GetObject("fld_dgcHREmployeeSalaryConfigs.ShowHelp"))));
            this.fld_dgcHREmployeeSalaryConfigs.Tag = "DC";
            this.fld_dgcHREmployeeSalaryConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView14});
            // 
            // gridView14
            // 
            this.gridView14.GridControl = this.fld_dgcHREmployeeSalaryConfigs;
            this.gridView14.Name = "gridView14";
            this.gridView14.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcADConfigValues);
            this.xtraTabPage4.Name = "xtraTabPage4";
            resources.ApplyResources(this.xtraTabPage4, "xtraTabPage4");
            // 
            // fld_dgcADConfigValues
            // 
            this.fld_dgcADConfigValues.AllowDrop = true;
            this.fld_dgcADConfigValues.BOSComment = "";
            this.fld_dgcADConfigValues.BOSDataMember = null;
            this.fld_dgcADConfigValues.BOSDataSource = "ADConfigValues";
            this.fld_dgcADConfigValues.BOSDescription = null;
            this.fld_dgcADConfigValues.BOSError = "";
            this.fld_dgcADConfigValues.BOSFieldGroup = "";
            this.fld_dgcADConfigValues.BOSFieldRelation = null;
            this.fld_dgcADConfigValues.BOSGridType = "";
            this.fld_dgcADConfigValues.BOSPrivilege = "";
            this.fld_dgcADConfigValues.BOSPropertyName = null;
            this.fld_dgcADConfigValues.CommodityType = "";
            resources.ApplyResources(this.fld_dgcADConfigValues, "fld_dgcADConfigValues");
            this.fld_dgcADConfigValues.MainView = this.gridView12;
            this.fld_dgcADConfigValues.Name = "fld_dgcADConfigValues";
            this.fld_dgcADConfigValues.PrintReport = false;
            this.fld_dgcADConfigValues.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADConfigValues, ((bool)(resources.GetObject("fld_dgcADConfigValues.ShowHelp"))));
            this.fld_dgcADConfigValues.Tag = "DC";
            this.fld_dgcADConfigValues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView12});
            // 
            // gridView12
            // 
            this.gridView12.GridControl = this.fld_dgcADConfigValues;
            this.gridView12.Name = "gridView12";
            this.gridView12.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_dgcTrainingCourse);
            this.xtraTabPage5.Name = "xtraTabPage5";
            resources.ApplyResources(this.xtraTabPage5, "xtraTabPage5");
            // 
            // fld_dgcTrainingCourse
            // 
            this.fld_dgcTrainingCourse.AllowDrop = true;
            this.fld_dgcTrainingCourse.BOSComment = "";
            this.fld_dgcTrainingCourse.BOSDataMember = null;
            this.fld_dgcTrainingCourse.BOSDataSource = "ADConfigValues";
            this.fld_dgcTrainingCourse.BOSDescription = null;
            this.fld_dgcTrainingCourse.BOSError = "";
            this.fld_dgcTrainingCourse.BOSFieldGroup = "";
            this.fld_dgcTrainingCourse.BOSFieldRelation = null;
            this.fld_dgcTrainingCourse.BOSGridType = "";
            this.fld_dgcTrainingCourse.BOSPrivilege = "";
            this.fld_dgcTrainingCourse.BOSPropertyName = null;
            this.fld_dgcTrainingCourse.CommodityType = "";
            resources.ApplyResources(this.fld_dgcTrainingCourse, "fld_dgcTrainingCourse");
            this.fld_dgcTrainingCourse.MainView = this.gridView13;
            this.fld_dgcTrainingCourse.Name = "fld_dgcTrainingCourse";
            this.fld_dgcTrainingCourse.PrintReport = false;
            this.fld_dgcTrainingCourse.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcTrainingCourse, ((bool)(resources.GetObject("fld_dgcTrainingCourse.ShowHelp"))));
            this.fld_dgcTrainingCourse.Tag = "DC";
            this.fld_dgcTrainingCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView13});
            // 
            // gridView13
            // 
            this.gridView13.GridControl = this.fld_dgcTrainingCourse;
            this.gridView13.Name = "gridView13";
            this.gridView13.PaintStyleName = "Office2003";
            // 
            // fld_tabUserAppPermission
            // 
            this.fld_tabUserAppPermission.Controls.Add(this.fld_btnAddGroup);
            this.fld_tabUserAppPermission.Controls.Add(this.fld_lkeADUserGroupID);
            this.fld_tabUserAppPermission.Controls.Add(this.bosLabel15);
            this.fld_tabUserAppPermission.Controls.Add(this.fld_lkeConfigFunction);
            this.fld_tabUserAppPermission.Controls.Add(this.bosLabel14);
            this.fld_tabUserAppPermission.Controls.Add(this.fld_lkeConfigGroup);
            this.fld_tabUserAppPermission.Controls.Add(this.bosLabel13);
            this.fld_tabUserAppPermission.Controls.Add(this.fld_dgcADAppUserPermissions);
            this.fld_tabUserAppPermission.Name = "fld_tabUserAppPermission";
            this.fld_tabUserAppPermission.PageVisible = false;
            resources.ApplyResources(this.fld_tabUserAppPermission, "fld_tabUserAppPermission");
            // 
            // fld_btnAddGroup
            // 
            this.fld_btnAddGroup.BOSComment = null;
            this.fld_btnAddGroup.BOSDataMember = null;
            this.fld_btnAddGroup.BOSDataSource = null;
            this.fld_btnAddGroup.BOSDescription = null;
            this.fld_btnAddGroup.BOSError = null;
            this.fld_btnAddGroup.BOSFieldGroup = null;
            this.fld_btnAddGroup.BOSFieldRelation = null;
            this.fld_btnAddGroup.BOSPrivilege = null;
            this.fld_btnAddGroup.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnAddGroup, "fld_btnAddGroup");
            this.fld_btnAddGroup.Name = "fld_btnAddGroup";
            this.fld_btnAddGroup.Screen = null;
            this.fld_btnAddGroup.Click += new System.EventHandler(this.fld_btnAddGroup_Click);
            // 
            // fld_lkeADUserGroupID
            // 
            this.fld_lkeADUserGroupID.BOSAllowAddNew = false;
            this.fld_lkeADUserGroupID.BOSAllowDummy = true;
            this.fld_lkeADUserGroupID.BOSComment = "";
            this.fld_lkeADUserGroupID.BOSDataMember = "ADUserGroupID";
            this.fld_lkeADUserGroupID.BOSDataSource = "ADUserGroups";
            this.fld_lkeADUserGroupID.BOSDescription = null;
            this.fld_lkeADUserGroupID.BOSError = null;
            this.fld_lkeADUserGroupID.BOSFieldGroup = "";
            this.fld_lkeADUserGroupID.BOSFieldParent = "";
            this.fld_lkeADUserGroupID.BOSFieldRelation = "";
            this.fld_lkeADUserGroupID.BOSPrivilege = "";
            this.fld_lkeADUserGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeADUserGroupID.BOSSelectType = "";
            this.fld_lkeADUserGroupID.BOSSelectTypeValue = "";
            this.fld_lkeADUserGroupID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeADUserGroupID, "fld_lkeADUserGroupID");
            this.fld_lkeADUserGroupID.Name = "fld_lkeADUserGroupID";
            this.fld_lkeADUserGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeADUserGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeADUserGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeADUserGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeADUserGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeADUserGroupID.Properties.Buttons"))))});
            this.fld_lkeADUserGroupID.Properties.ColumnName = null;
            this.fld_lkeADUserGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeADUserGroupID.Properties.Columns"), resources.GetString("fld_lkeADUserGroupID.Properties.Columns1"))});
            this.fld_lkeADUserGroupID.Properties.DisplayMember = "ADUserGroupName";
            this.fld_lkeADUserGroupID.Properties.NullText = resources.GetString("fld_lkeADUserGroupID.Properties.NullText");
            this.fld_lkeADUserGroupID.Properties.PopupWidth = 40;
            this.fld_lkeADUserGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeADUserGroupID.Properties.ValueMember = "ADUserGroupID";
            this.fld_lkeADUserGroupID.Screen = null;
            this.fld_lkeADUserGroupID.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel15, "bosLabel15");
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, ((bool)(resources.GetObject("bosLabel15.ShowHelp"))));
            this.bosLabel15.Tag = "";
            // 
            // fld_lkeConfigFunction
            // 
            this.fld_lkeConfigFunction.BOSAllowAddNew = false;
            this.fld_lkeConfigFunction.BOSAllowDummy = true;
            this.fld_lkeConfigFunction.BOSComment = "";
            this.fld_lkeConfigFunction.BOSDataMember = "ADConfigKeyValue";
            this.fld_lkeConfigFunction.BOSDataSource = "ADConfigValues";
            this.fld_lkeConfigFunction.BOSDescription = null;
            this.fld_lkeConfigFunction.BOSError = null;
            this.fld_lkeConfigFunction.BOSFieldGroup = "";
            this.fld_lkeConfigFunction.BOSFieldParent = "";
            this.fld_lkeConfigFunction.BOSFieldRelation = "";
            this.fld_lkeConfigFunction.BOSPrivilege = "";
            this.fld_lkeConfigFunction.BOSPropertyName = "EditValue";
            this.fld_lkeConfigFunction.BOSSelectType = "";
            this.fld_lkeConfigFunction.BOSSelectTypeValue = "";
            this.fld_lkeConfigFunction.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeConfigFunction, "fld_lkeConfigFunction");
            this.fld_lkeConfigFunction.Name = "fld_lkeConfigFunction";
            this.fld_lkeConfigFunction.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeConfigFunction.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeConfigFunction.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeConfigFunction.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeConfigFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeConfigFunction.Properties.Buttons"))))});
            this.fld_lkeConfigFunction.Properties.ColumnName = null;
            this.fld_lkeConfigFunction.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeConfigFunction.Properties.Columns"), resources.GetString("fld_lkeConfigFunction.Properties.Columns1"))});
            this.fld_lkeConfigFunction.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeConfigFunction.Properties.NullText = resources.GetString("fld_lkeConfigFunction.Properties.NullText");
            this.fld_lkeConfigFunction.Properties.PopupWidth = 40;
            this.fld_lkeConfigFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeConfigFunction.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeConfigFunction.Screen = null;
            this.fld_lkeConfigFunction.Tag = "DC";
            this.fld_lkeConfigFunction.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeConfigFunction_QueryPopUp);
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel14, "bosLabel14");
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, ((bool)(resources.GetObject("bosLabel14.ShowHelp"))));
            this.bosLabel14.Tag = "";
            // 
            // fld_lkeConfigGroup
            // 
            this.fld_lkeConfigGroup.BOSAllowAddNew = false;
            this.fld_lkeConfigGroup.BOSAllowDummy = true;
            this.fld_lkeConfigGroup.BOSComment = "";
            this.fld_lkeConfigGroup.BOSDataMember = "ADConfigKeyValue";
            this.fld_lkeConfigGroup.BOSDataSource = "ADConfigValues";
            this.fld_lkeConfigGroup.BOSDescription = null;
            this.fld_lkeConfigGroup.BOSError = null;
            this.fld_lkeConfigGroup.BOSFieldGroup = "";
            this.fld_lkeConfigGroup.BOSFieldParent = "";
            this.fld_lkeConfigGroup.BOSFieldRelation = "";
            this.fld_lkeConfigGroup.BOSPrivilege = "";
            this.fld_lkeConfigGroup.BOSPropertyName = "EditValue";
            this.fld_lkeConfigGroup.BOSSelectType = "";
            this.fld_lkeConfigGroup.BOSSelectTypeValue = "";
            this.fld_lkeConfigGroup.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeConfigGroup, "fld_lkeConfigGroup");
            this.fld_lkeConfigGroup.Name = "fld_lkeConfigGroup";
            this.fld_lkeConfigGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeConfigGroup.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeConfigGroup.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeConfigGroup.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeConfigGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeConfigGroup.Properties.Buttons"))))});
            this.fld_lkeConfigGroup.Properties.ColumnName = null;
            this.fld_lkeConfigGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeConfigGroup.Properties.Columns"), resources.GetString("fld_lkeConfigGroup.Properties.Columns1"))});
            this.fld_lkeConfigGroup.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeConfigGroup.Properties.NullText = resources.GetString("fld_lkeConfigGroup.Properties.NullText");
            this.fld_lkeConfigGroup.Properties.PopupWidth = 40;
            this.fld_lkeConfigGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeConfigGroup.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeConfigGroup.Screen = null;
            this.fld_lkeConfigGroup.Tag = "DC";
            this.fld_lkeConfigGroup.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeConfigGroup_QueryPopUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel13, "bosLabel13");
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Tag = "";
            // 
            // fld_dgcADAppUserPermissions
            // 
            this.fld_dgcADAppUserPermissions.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcADAppUserPermissions, "fld_dgcADAppUserPermissions");
            this.fld_dgcADAppUserPermissions.BOSComment = "";
            this.fld_dgcADAppUserPermissions.BOSDataMember = null;
            this.fld_dgcADAppUserPermissions.BOSDataSource = "ADAppUserPermissions";
            this.fld_dgcADAppUserPermissions.BOSDescription = null;
            this.fld_dgcADAppUserPermissions.BOSError = "";
            this.fld_dgcADAppUserPermissions.BOSFieldGroup = "";
            this.fld_dgcADAppUserPermissions.BOSFieldRelation = null;
            this.fld_dgcADAppUserPermissions.BOSGridType = "";
            this.fld_dgcADAppUserPermissions.BOSPrivilege = "";
            this.fld_dgcADAppUserPermissions.BOSPropertyName = null;
            this.fld_dgcADAppUserPermissions.CommodityType = "";
            this.fld_dgcADAppUserPermissions.MainView = this.gridView15;
            this.fld_dgcADAppUserPermissions.Name = "fld_dgcADAppUserPermissions";
            this.fld_dgcADAppUserPermissions.PrintReport = false;
            this.fld_dgcADAppUserPermissions.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADAppUserPermissions, ((bool)(resources.GetObject("fld_dgcADAppUserPermissions.ShowHelp"))));
            this.fld_dgcADAppUserPermissions.Tag = "DC";
            this.fld_dgcADAppUserPermissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView15});
            // 
            // gridView15
            // 
            this.gridView15.GridControl = this.fld_dgcADAppUserPermissions;
            this.gridView15.Name = "gridView15";
            this.gridView15.PaintStyleName = "Office2003";
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.fld_dgcHRErrorTypes);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.PageVisible = false;
            resources.ApplyResources(this.xtraTabPage7, "xtraTabPage7");
            // 
            // fld_dgcHRErrorTypes
            // 
            this.fld_dgcHRErrorTypes.AllowDrop = true;
            this.fld_dgcHRErrorTypes.BOSComment = "";
            this.fld_dgcHRErrorTypes.BOSDataMember = null;
            this.fld_dgcHRErrorTypes.BOSDataSource = "HRErrorTypes";
            this.fld_dgcHRErrorTypes.BOSDescription = null;
            this.fld_dgcHRErrorTypes.BOSError = "";
            this.fld_dgcHRErrorTypes.BOSFieldGroup = "";
            this.fld_dgcHRErrorTypes.BOSFieldRelation = null;
            this.fld_dgcHRErrorTypes.BOSGridType = "";
            this.fld_dgcHRErrorTypes.BOSPrivilege = "";
            this.fld_dgcHRErrorTypes.BOSPropertyName = null;
            this.fld_dgcHRErrorTypes.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRErrorTypes, "fld_dgcHRErrorTypes");
            this.fld_dgcHRErrorTypes.MainView = this.gridView16;
            this.fld_dgcHRErrorTypes.Name = "fld_dgcHRErrorTypes";
            this.fld_dgcHRErrorTypes.PrintReport = false;
            this.fld_dgcHRErrorTypes.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRErrorTypes, ((bool)(resources.GetObject("fld_dgcHRErrorTypes.ShowHelp"))));
            this.fld_dgcHRErrorTypes.Tag = "DC";
            this.fld_dgcHRErrorTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView16});
            // 
            // gridView16
            // 
            this.gridView16.GridControl = this.fld_dgcHRErrorTypes;
            this.gridView16.Name = "gridView16";
            this.gridView16.PaintStyleName = "Office2003";
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.groupBox6);
            this.xtraTabPage8.Controls.Add(this.groupBox5);
            this.xtraTabPage8.Name = "xtraTabPage8";
            resources.ApplyResources(this.xtraTabPage8, "xtraTabPage8");
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fld_dgcHRAllowanceManageConfigHistorys);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.ScreenHelper.SetShowHelp(this.groupBox6, ((bool)(resources.GetObject("groupBox6.ShowHelp"))));
            this.groupBox6.TabStop = false;
            // 
            // fld_dgcHRAllowanceManageConfigHistorys
            // 
            this.fld_dgcHRAllowanceManageConfigHistorys.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHRAllowanceManageConfigHistorys, "fld_dgcHRAllowanceManageConfigHistorys");
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSComment = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSDataMember = null;
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSDataSource = "HRAllowanceManageConfigHistorys";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSDescription = null;
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSError = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSFieldGroup = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSFieldRelation = null;
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSGridType = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSPrivilege = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.BOSPropertyName = null;
            this.fld_dgcHRAllowanceManageConfigHistorys.CommodityType = "";
            this.fld_dgcHRAllowanceManageConfigHistorys.MainView = this.gridView24;
            this.fld_dgcHRAllowanceManageConfigHistorys.Name = "fld_dgcHRAllowanceManageConfigHistorys";
            this.fld_dgcHRAllowanceManageConfigHistorys.PrintReport = false;
            this.fld_dgcHRAllowanceManageConfigHistorys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRAllowanceManageConfigHistorys, ((bool)(resources.GetObject("fld_dgcHRAllowanceManageConfigHistorys.ShowHelp"))));
            this.fld_dgcHRAllowanceManageConfigHistorys.Tag = "DC";
            this.fld_dgcHRAllowanceManageConfigHistorys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView24});
            // 
            // gridView24
            // 
            this.gridView24.GridControl = this.fld_dgcHRAllowanceManageConfigHistorys;
            this.gridView24.Name = "gridView24";
            this.gridView24.PaintStyleName = "Office2003";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fld_btnSaveAllowanceManageConfigs);
            this.groupBox5.Controls.Add(this.fld_dgcHRAllowanceManageConfigs);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.ScreenHelper.SetShowHelp(this.groupBox5, ((bool)(resources.GetObject("groupBox5.ShowHelp"))));
            this.groupBox5.TabStop = false;
            // 
            // fld_btnSaveAllowanceManageConfigs
            // 
            resources.ApplyResources(this.fld_btnSaveAllowanceManageConfigs, "fld_btnSaveAllowanceManageConfigs");
            this.fld_btnSaveAllowanceManageConfigs.BOSComment = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSDataMember = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSDataSource = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSDescription = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSError = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSFieldGroup = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSFieldRelation = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSPrivilege = null;
            this.fld_btnSaveAllowanceManageConfigs.BOSPropertyName = null;
            this.fld_btnSaveAllowanceManageConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveAllowanceManageConfigs.Name = "fld_btnSaveAllowanceManageConfigs";
            this.fld_btnSaveAllowanceManageConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveAllowanceManageConfigs, ((bool)(resources.GetObject("fld_btnSaveAllowanceManageConfigs.ShowHelp"))));
            this.fld_btnSaveAllowanceManageConfigs.Click += new System.EventHandler(this.fld_btnSaveAllowanceManageConfigs_Click);
            // 
            // fld_dgcHRAllowanceManageConfigs
            // 
            this.fld_dgcHRAllowanceManageConfigs.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHRAllowanceManageConfigs, "fld_dgcHRAllowanceManageConfigs");
            this.fld_dgcHRAllowanceManageConfigs.BOSComment = "";
            this.fld_dgcHRAllowanceManageConfigs.BOSDataMember = null;
            this.fld_dgcHRAllowanceManageConfigs.BOSDataSource = "HRAllowanceManageConfigs";
            this.fld_dgcHRAllowanceManageConfigs.BOSDescription = null;
            this.fld_dgcHRAllowanceManageConfigs.BOSError = "";
            this.fld_dgcHRAllowanceManageConfigs.BOSFieldGroup = "";
            this.fld_dgcHRAllowanceManageConfigs.BOSFieldRelation = null;
            this.fld_dgcHRAllowanceManageConfigs.BOSGridType = "";
            this.fld_dgcHRAllowanceManageConfigs.BOSPrivilege = "";
            this.fld_dgcHRAllowanceManageConfigs.BOSPropertyName = null;
            this.fld_dgcHRAllowanceManageConfigs.CommodityType = "";
            this.fld_dgcHRAllowanceManageConfigs.MainView = this.gridView17;
            this.fld_dgcHRAllowanceManageConfigs.Name = "fld_dgcHRAllowanceManageConfigs";
            this.fld_dgcHRAllowanceManageConfigs.PrintReport = false;
            this.fld_dgcHRAllowanceManageConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRAllowanceManageConfigs, ((bool)(resources.GetObject("fld_dgcHRAllowanceManageConfigs.ShowHelp"))));
            this.fld_dgcHRAllowanceManageConfigs.Tag = "DC";
            this.fld_dgcHRAllowanceManageConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView17});
            // 
            // gridView17
            // 
            this.gridView17.GridControl = this.fld_dgcHRAllowanceManageConfigs;
            this.gridView17.Name = "gridView17";
            this.gridView17.PaintStyleName = "Office2003";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.panel3);
            this.xtraTabPage9.Name = "xtraTabPage9";
            resources.ApplyResources(this.xtraTabPage9, "xtraTabPage9");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.bosButton2);
            this.panel3.Controls.Add(this.splitContainer3);
            this.panel3.Controls.Add(this.bosButton1);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Controls.Add(this.bosLine3);
            this.panel3.Controls.Add(this.bosLine4);
            this.panel3.Controls.Add(this.fld_btnSaveInsurrances);
            this.panel3.Name = "panel3";
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            resources.ApplyResources(this.bosButton2, "bosButton2");
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton2, ((bool)(resources.GetObject("bosButton2.ShowHelp"))));
            this.bosButton2.Click += new System.EventHandler(this.BosButton2_Click);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox31);
            this.ScreenHelper.SetShowHelp(this.splitContainer3.Panel1, ((bool)(resources.GetObject("splitContainer3.Panel1.ShowHelp"))));
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.ScreenHelper.SetShowHelp(this.splitContainer3.Panel2, ((bool)(resources.GetObject("splitContainer3.Panel2.ShowHelp"))));
            this.ScreenHelper.SetShowHelp(this.splitContainer3, ((bool)(resources.GetObject("splitContainer3.ShowHelp"))));
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.fld_dgcADInsurrancePlans);
            resources.ApplyResources(this.groupBox31, "groupBox31");
            this.groupBox31.Name = "groupBox31";
            this.ScreenHelper.SetShowHelp(this.groupBox31, ((bool)(resources.GetObject("groupBox31.ShowHelp"))));
            this.groupBox31.TabStop = false;
            // 
            // fld_dgcADInsurrancePlans
            // 
            this.fld_dgcADInsurrancePlans.AllowDrop = true;
            this.fld_dgcADInsurrancePlans.BOSComment = "";
            this.fld_dgcADInsurrancePlans.BOSDataMember = null;
            this.fld_dgcADInsurrancePlans.BOSDataSource = "ADInsurrancePlans";
            this.fld_dgcADInsurrancePlans.BOSDescription = null;
            this.fld_dgcADInsurrancePlans.BOSError = "";
            this.fld_dgcADInsurrancePlans.BOSFieldGroup = "";
            this.fld_dgcADInsurrancePlans.BOSFieldRelation = null;
            this.fld_dgcADInsurrancePlans.BOSGridType = "";
            this.fld_dgcADInsurrancePlans.BOSPrivilege = "";
            this.fld_dgcADInsurrancePlans.BOSPropertyName = null;
            this.fld_dgcADInsurrancePlans.CommodityType = "";
            resources.ApplyResources(this.fld_dgcADInsurrancePlans, "fld_dgcADInsurrancePlans");
            this.fld_dgcADInsurrancePlans.MainView = this.gridView27;
            this.fld_dgcADInsurrancePlans.Name = "fld_dgcADInsurrancePlans";
            this.fld_dgcADInsurrancePlans.PrintReport = false;
            this.fld_dgcADInsurrancePlans.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADInsurrancePlans, ((bool)(resources.GetObject("fld_dgcADInsurrancePlans.ShowHelp"))));
            this.fld_dgcADInsurrancePlans.Tag = "DC";
            this.fld_dgcADInsurrancePlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView27});
            // 
            // gridView27
            // 
            this.gridView27.GridControl = this.fld_dgcADInsurrancePlans;
            this.gridView27.Name = "gridView27";
            this.gridView27.PaintStyleName = "Office2003";
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox32);
            this.ScreenHelper.SetShowHelp(this.splitContainer4.Panel1, ((bool)(resources.GetObject("splitContainer4.Panel1.ShowHelp"))));
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox33);
            this.ScreenHelper.SetShowHelp(this.splitContainer4.Panel2, ((bool)(resources.GetObject("splitContainer4.Panel2.ShowHelp"))));
            this.ScreenHelper.SetShowHelp(this.splitContainer4, ((bool)(resources.GetObject("splitContainer4.ShowHelp"))));
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.fld_dgcADInsurrancePapers);
            resources.ApplyResources(this.groupBox32, "groupBox32");
            this.groupBox32.Name = "groupBox32";
            this.ScreenHelper.SetShowHelp(this.groupBox32, ((bool)(resources.GetObject("groupBox32.ShowHelp"))));
            this.groupBox32.TabStop = false;
            // 
            // fld_dgcADInsurrancePapers
            // 
            this.fld_dgcADInsurrancePapers.AllowDrop = true;
            this.fld_dgcADInsurrancePapers.BOSComment = "";
            this.fld_dgcADInsurrancePapers.BOSDataMember = null;
            this.fld_dgcADInsurrancePapers.BOSDataSource = "ADInsurrancePapers";
            this.fld_dgcADInsurrancePapers.BOSDescription = null;
            this.fld_dgcADInsurrancePapers.BOSError = "";
            this.fld_dgcADInsurrancePapers.BOSFieldGroup = "";
            this.fld_dgcADInsurrancePapers.BOSFieldRelation = null;
            this.fld_dgcADInsurrancePapers.BOSGridType = "";
            this.fld_dgcADInsurrancePapers.BOSPrivilege = "";
            this.fld_dgcADInsurrancePapers.BOSPropertyName = null;
            this.fld_dgcADInsurrancePapers.CommodityType = "";
            resources.ApplyResources(this.fld_dgcADInsurrancePapers, "fld_dgcADInsurrancePapers");
            this.fld_dgcADInsurrancePapers.MainView = this.gridView28;
            this.fld_dgcADInsurrancePapers.Name = "fld_dgcADInsurrancePapers";
            this.fld_dgcADInsurrancePapers.PrintReport = false;
            this.fld_dgcADInsurrancePapers.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADInsurrancePapers, ((bool)(resources.GetObject("fld_dgcADInsurrancePapers.ShowHelp"))));
            this.fld_dgcADInsurrancePapers.Tag = "DC";
            this.fld_dgcADInsurrancePapers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView28});
            // 
            // gridView28
            // 
            this.gridView28.GridControl = this.fld_dgcADInsurrancePapers;
            this.gridView28.Name = "gridView28";
            this.gridView28.PaintStyleName = "Office2003";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.fld_dgcADInsurranceConditions);
            resources.ApplyResources(this.groupBox33, "groupBox33");
            this.groupBox33.Name = "groupBox33";
            this.ScreenHelper.SetShowHelp(this.groupBox33, ((bool)(resources.GetObject("groupBox33.ShowHelp"))));
            this.groupBox33.TabStop = false;
            // 
            // fld_dgcADInsurranceConditions
            // 
            this.fld_dgcADInsurranceConditions.AllowDrop = true;
            this.fld_dgcADInsurranceConditions.BOSComment = "";
            this.fld_dgcADInsurranceConditions.BOSDataMember = null;
            this.fld_dgcADInsurranceConditions.BOSDataSource = "ADInsurranceConditions";
            this.fld_dgcADInsurranceConditions.BOSDescription = null;
            this.fld_dgcADInsurranceConditions.BOSError = "";
            this.fld_dgcADInsurranceConditions.BOSFieldGroup = "";
            this.fld_dgcADInsurranceConditions.BOSFieldRelation = null;
            this.fld_dgcADInsurranceConditions.BOSGridType = "";
            this.fld_dgcADInsurranceConditions.BOSPrivilege = "";
            this.fld_dgcADInsurranceConditions.BOSPropertyName = null;
            this.fld_dgcADInsurranceConditions.CommodityType = "";
            resources.ApplyResources(this.fld_dgcADInsurranceConditions, "fld_dgcADInsurranceConditions");
            this.fld_dgcADInsurranceConditions.MainView = this.gridView29;
            this.fld_dgcADInsurranceConditions.Name = "fld_dgcADInsurranceConditions";
            this.fld_dgcADInsurranceConditions.PrintReport = false;
            this.fld_dgcADInsurranceConditions.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADInsurranceConditions, ((bool)(resources.GetObject("fld_dgcADInsurranceConditions.ShowHelp"))));
            this.fld_dgcADInsurranceConditions.Tag = "DC";
            this.fld_dgcADInsurranceConditions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView29});
            // 
            // gridView29
            // 
            this.gridView29.GridControl = this.fld_dgcADInsurranceConditions;
            this.gridView29.Name = "gridView29";
            this.gridView29.PaintStyleName = "Office2003";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            resources.ApplyResources(this.bosButton1, "bosButton1");
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, ((bool)(resources.GetObject("bosButton1.ShowHelp"))));
            this.bosButton1.Click += new System.EventHandler(this.BosButton1_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.fld_dgcHRATMCardManageConfigs);
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // fld_dgcHRATMCardManageConfigs
            // 
            this.fld_dgcHRATMCardManageConfigs.AllowDrop = true;
            this.fld_dgcHRATMCardManageConfigs.BOSComment = "";
            this.fld_dgcHRATMCardManageConfigs.BOSDataMember = null;
            this.fld_dgcHRATMCardManageConfigs.BOSDataSource = "HRATMCardManageConfigs";
            this.fld_dgcHRATMCardManageConfigs.BOSDescription = null;
            this.fld_dgcHRATMCardManageConfigs.BOSError = "";
            this.fld_dgcHRATMCardManageConfigs.BOSFieldGroup = "";
            this.fld_dgcHRATMCardManageConfigs.BOSFieldRelation = null;
            this.fld_dgcHRATMCardManageConfigs.BOSGridType = "";
            this.fld_dgcHRATMCardManageConfigs.BOSPrivilege = "";
            this.fld_dgcHRATMCardManageConfigs.BOSPropertyName = null;
            this.fld_dgcHRATMCardManageConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRATMCardManageConfigs, "fld_dgcHRATMCardManageConfigs");
            this.fld_dgcHRATMCardManageConfigs.MainView = this.gridView26;
            this.fld_dgcHRATMCardManageConfigs.Name = "fld_dgcHRATMCardManageConfigs";
            this.fld_dgcHRATMCardManageConfigs.PrintReport = false;
            this.fld_dgcHRATMCardManageConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRATMCardManageConfigs, ((bool)(resources.GetObject("fld_dgcHRATMCardManageConfigs.ShowHelp"))));
            this.fld_dgcHRATMCardManageConfigs.Tag = "DC";
            this.fld_dgcHRATMCardManageConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView26});
            // 
            // gridView26
            // 
            this.gridView26.GridControl = this.fld_dgcHRATMCardManageConfigs;
            this.gridView26.Name = "gridView26";
            this.gridView26.PaintStyleName = "Office2003";
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.groupBox9);
            this.bosLine3.Controls.Add(this.groupBox8);
            this.bosLine3.Controls.Add(this.fld_dteHRInsurranceDateApply);
            this.bosLine3.Controls.Add(this.bosLabel25);
            resources.ApplyResources(this.bosLine3, "bosLine3");
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine3, ((bool)(resources.GetObject("bosLine3.ShowHelp"))));
            this.bosLine3.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.fld_txtHRInsurranceOutOfWorkInsPercentNext);
            this.groupBox9.Controls.Add(this.bosLabel28);
            this.groupBox9.Controls.Add(this.bosLabel33);
            this.groupBox9.Controls.Add(this.fld_txtHRInsurranceHealthInsPercentNext);
            this.groupBox9.Controls.Add(this.bosLabel34);
            this.groupBox9.Controls.Add(this.fld_txtHRInsurranceSocialInsPercentNext);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.ScreenHelper.SetShowHelp(this.groupBox9, ((bool)(resources.GetObject("groupBox9.ShowHelp"))));
            this.groupBox9.TabStop = false;
            // 
            // fld_txtHRInsurranceOutOfWorkInsPercentNext
            // 
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSComment = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSDataMember = "HRInsurranceOutOfWorkInsPercentNext";
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSDescription = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSError = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSFieldGroup = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSFieldRelation = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSPrivilege = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceOutOfWorkInsPercentNext, "fld_txtHRInsurranceOutOfWorkInsPercentNext");
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Name = "fld_txtHRInsurranceOutOfWorkInsPercentNext";
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat" +
        "")));
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceOutOfWorkInsPercentNext, ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentNext.ShowHelp"))));
            this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel28, "bosLabel28");
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel28, ((bool)(resources.GetObject("bosLabel28.ShowHelp"))));
            // 
            // bosLabel33
            // 
            this.bosLabel33.BOSComment = null;
            this.bosLabel33.BOSDataMember = null;
            this.bosLabel33.BOSDataSource = null;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = null;
            this.bosLabel33.BOSFieldRelation = null;
            this.bosLabel33.BOSPrivilege = null;
            this.bosLabel33.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel33, "bosLabel33");
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel33, ((bool)(resources.GetObject("bosLabel33.ShowHelp"))));
            // 
            // fld_txtHRInsurranceHealthInsPercentNext
            // 
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSComment = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSDataMember = "HRInsurranceHealthInsPercentNext";
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSDescription = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSError = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSFieldGroup = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSFieldRelation = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSPrivilege = null;
            this.fld_txtHRInsurranceHealthInsPercentNext.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceHealthInsPercentNext, "fld_txtHRInsurranceHealthInsPercentNext");
            this.fld_txtHRInsurranceHealthInsPercentNext.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceHealthInsPercentNext.Name = "fld_txtHRInsurranceHealthInsPercentNext";
            this.fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRInsurranceHealthInsPercentNext.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceHealthInsPercentNext, ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentNext.ShowHelp"))));
            this.fld_txtHRInsurranceHealthInsPercentNext.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel34, "bosLabel34");
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel34, ((bool)(resources.GetObject("bosLabel34.ShowHelp"))));
            // 
            // fld_txtHRInsurranceSocialInsPercentNext
            // 
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSComment = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSDataMember = "HRInsurranceSocialInsPercentNext";
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSDescription = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSError = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSFieldGroup = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSFieldRelation = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSPrivilege = null;
            this.fld_txtHRInsurranceSocialInsPercentNext.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceSocialInsPercentNext, "fld_txtHRInsurranceSocialInsPercentNext");
            this.fld_txtHRInsurranceSocialInsPercentNext.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceSocialInsPercentNext.Name = "fld_txtHRInsurranceSocialInsPercentNext";
            this.fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentNext.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHRInsurranceSocialInsPercentNext.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceSocialInsPercentNext, ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentNext.ShowHelp"))));
            this.fld_txtHRInsurranceSocialInsPercentNext.Tag = "DC";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious);
            this.groupBox8.Controls.Add(this.bosLabel32);
            this.groupBox8.Controls.Add(this.bosLabel31);
            this.groupBox8.Controls.Add(this.fld_txtHRInsurranceHealthInsPercentPrevious);
            this.groupBox8.Controls.Add(this.bosLabel29);
            this.groupBox8.Controls.Add(this.fld_txtHRInsurranceSocialInsPercentPrevious);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.ScreenHelper.SetShowHelp(this.groupBox8, ((bool)(resources.GetObject("groupBox8.ShowHelp"))));
            this.groupBox8.TabStop = false;
            // 
            // fld_txtHRInsurranceOutOfWorkInsPercentPrevious
            // 
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSComment = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSDataMember = "HRInsurranceOutOfWorkInsPercentPrevious";
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSDescription = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSError = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSFieldGroup = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSFieldRelation = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSPrivilege = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious, "fld_txtHRInsurranceOutOfWorkInsPercentPrevious");
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Name = "fld_txtHRInsurranceOutOfWorkInsPercentPrevious";
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties.Mask.UseMaskAsDisplayFo" +
        "rmat")));
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious, ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentPrevious.ShowHelp"))));
            this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = null;
            this.bosLabel32.BOSDataSource = null;
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel32, "bosLabel32");
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel32, ((bool)(resources.GetObject("bosLabel32.ShowHelp"))));
            // 
            // bosLabel31
            // 
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel31, "bosLabel31");
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel31, ((bool)(resources.GetObject("bosLabel31.ShowHelp"))));
            // 
            // fld_txtHRInsurranceHealthInsPercentPrevious
            // 
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSComment = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSDataMember = "HRInsurranceHealthInsPercentPrevious";
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSDescription = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSError = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSFieldGroup = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSFieldRelation = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSPrivilege = null;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceHealthInsPercentPrevious, "fld_txtHRInsurranceHealthInsPercentPrevious");
            this.fld_txtHRInsurranceHealthInsPercentPrevious.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Name = "fld_txtHRInsurranceHealthInsPercentPrevious";
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentPrevious.Properties.Mask.UseMaskAsDisplayForma" +
        "t")));
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceHealthInsPercentPrevious, ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentPrevious.ShowHelp"))));
            this.fld_txtHRInsurranceHealthInsPercentPrevious.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel29, "bosLabel29");
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, ((bool)(resources.GetObject("bosLabel29.ShowHelp"))));
            // 
            // fld_txtHRInsurranceSocialInsPercentPrevious
            // 
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSComment = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSDataMember = "HRInsurranceSocialInsPercentPrevious";
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSDescription = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSError = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSFieldGroup = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSFieldRelation = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSPrivilege = null;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceSocialInsPercentPrevious, "fld_txtHRInsurranceSocialInsPercentPrevious");
            this.fld_txtHRInsurranceSocialInsPercentPrevious.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Name = "fld_txtHRInsurranceSocialInsPercentPrevious";
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentPrevious.Properties.Mask.UseMaskAsDisplayForma" +
        "t")));
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceSocialInsPercentPrevious, ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentPrevious.ShowHelp"))));
            this.fld_txtHRInsurranceSocialInsPercentPrevious.Tag = "DC";
            // 
            // fld_dteHRInsurranceDateApply
            // 
            this.fld_dteHRInsurranceDateApply.BOSComment = null;
            this.fld_dteHRInsurranceDateApply.BOSDataMember = "HRInsurranceDateApply";
            this.fld_dteHRInsurranceDateApply.BOSDataSource = "ADInsurrances";
            this.fld_dteHRInsurranceDateApply.BOSDescription = "";
            this.fld_dteHRInsurranceDateApply.BOSError = null;
            this.fld_dteHRInsurranceDateApply.BOSFieldGroup = null;
            this.fld_dteHRInsurranceDateApply.BOSFieldRelation = null;
            this.fld_dteHRInsurranceDateApply.BOSPrivilege = null;
            this.fld_dteHRInsurranceDateApply.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHRInsurranceDateApply, "fld_dteHRInsurranceDateApply");
            this.fld_dteHRInsurranceDateApply.Name = "fld_dteHRInsurranceDateApply";
            this.fld_dteHRInsurranceDateApply.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRInsurranceDateApply.Properties.Buttons"))))});
            this.fld_dteHRInsurranceDateApply.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRInsurranceDateApply.Properties.DisplayFormat.FormatString = "dd";
            this.fld_dteHRInsurranceDateApply.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRInsurranceDateApply.Properties.EditFormat.FormatString = "dd";
            this.fld_dteHRInsurranceDateApply.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRInsurranceDateApply.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHRInsurranceDateApply, ((bool)(resources.GetObject("fld_dteHRInsurranceDateApply.ShowHelp"))));
            this.fld_dteHRInsurranceDateApply.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel25, "bosLabel25");
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, ((bool)(resources.GetObject("bosLabel25.ShowHelp"))));
            // 
            // bosLine4
            // 
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.bosLabel21);
            this.bosLine4.Controls.Add(this.bosLabel18);
            this.bosLine4.Controls.Add(this.fld_txtADInsurranceDependencyLevel);
            this.bosLine4.Controls.Add(this.bosLabel20);
            this.bosLine4.Controls.Add(this.fld_txtADInsurranceLevelNotTaxable);
            this.bosLine4.Controls.Add(this.bosLabel22);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceSocialInsPercent);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceOutOfWorkInsPercentDN);
            this.bosLine4.Controls.Add(this.bosLabel16);
            this.bosLine4.Controls.Add(this.bosLabel19);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceHealthInsPercent);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceHealthInsPercentDN);
            this.bosLine4.Controls.Add(this.bosLabel17);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceOutOfWorkInsPercent);
            this.bosLine4.Controls.Add(this.fld_txtHRInsurranceSocialInsPercentDN);
            this.bosLine4.Controls.Add(this.bosLabel23);
            resources.ApplyResources(this.bosLine4, "bosLine4");
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine4, ((bool)(resources.GetObject("bosLine4.ShowHelp"))));
            this.bosLine4.TabStop = false;
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel21, "bosLabel21");
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, ((bool)(resources.GetObject("bosLabel21.ShowHelp"))));
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel18, "bosLabel18");
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, ((bool)(resources.GetObject("bosLabel18.ShowHelp"))));
            // 
            // fld_txtADInsurranceDependencyLevel
            // 
            this.fld_txtADInsurranceDependencyLevel.BOSComment = null;
            this.fld_txtADInsurranceDependencyLevel.BOSDataMember = "ADInsurranceDependencyLevel";
            this.fld_txtADInsurranceDependencyLevel.BOSDataSource = "ADInsurrances";
            this.fld_txtADInsurranceDependencyLevel.BOSDescription = null;
            this.fld_txtADInsurranceDependencyLevel.BOSError = null;
            this.fld_txtADInsurranceDependencyLevel.BOSFieldGroup = null;
            this.fld_txtADInsurranceDependencyLevel.BOSFieldRelation = null;
            this.fld_txtADInsurranceDependencyLevel.BOSPrivilege = null;
            this.fld_txtADInsurranceDependencyLevel.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtADInsurranceDependencyLevel, "fld_txtADInsurranceDependencyLevel");
            this.fld_txtADInsurranceDependencyLevel.MenuManager = this.screenToolbar;
            this.fld_txtADInsurranceDependencyLevel.Name = "fld_txtADInsurranceDependencyLevel";
            this.fld_txtADInsurranceDependencyLevel.Properties.Mask.EditMask = resources.GetString("fld_txtADInsurranceDependencyLevel.Properties.Mask.EditMask");
            this.fld_txtADInsurranceDependencyLevel.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtADInsurranceDependencyLevel.Properties.Mask.MaskType")));
            this.fld_txtADInsurranceDependencyLevel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtADInsurranceDependencyLevel, ((bool)(resources.GetObject("fld_txtADInsurranceDependencyLevel.ShowHelp"))));
            this.fld_txtADInsurranceDependencyLevel.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel20, "bosLabel20");
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, ((bool)(resources.GetObject("bosLabel20.ShowHelp"))));
            // 
            // fld_txtADInsurranceLevelNotTaxable
            // 
            this.fld_txtADInsurranceLevelNotTaxable.BOSComment = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSDataMember = "ADInsurranceLevelNotTaxable";
            this.fld_txtADInsurranceLevelNotTaxable.BOSDataSource = "ADInsurrances";
            this.fld_txtADInsurranceLevelNotTaxable.BOSDescription = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSError = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSFieldGroup = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSFieldRelation = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSPrivilege = null;
            this.fld_txtADInsurranceLevelNotTaxable.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtADInsurranceLevelNotTaxable, "fld_txtADInsurranceLevelNotTaxable");
            this.fld_txtADInsurranceLevelNotTaxable.MenuManager = this.screenToolbar;
            this.fld_txtADInsurranceLevelNotTaxable.Name = "fld_txtADInsurranceLevelNotTaxable";
            this.fld_txtADInsurranceLevelNotTaxable.Properties.Mask.EditMask = resources.GetString("fld_txtADInsurranceLevelNotTaxable.Properties.Mask.EditMask");
            this.fld_txtADInsurranceLevelNotTaxable.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtADInsurranceLevelNotTaxable.Properties.Mask.MaskType")));
            this.fld_txtADInsurranceLevelNotTaxable.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtADInsurranceLevelNotTaxable, ((bool)(resources.GetObject("fld_txtADInsurranceLevelNotTaxable.ShowHelp"))));
            this.fld_txtADInsurranceLevelNotTaxable.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel22, "bosLabel22");
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, ((bool)(resources.GetObject("bosLabel22.ShowHelp"))));
            // 
            // fld_txtHRInsurranceSocialInsPercent
            // 
            this.fld_txtHRInsurranceSocialInsPercent.BOSComment = null;
            this.fld_txtHRInsurranceSocialInsPercent.BOSDataMember = "HRInsurranceSocialInsPercent";
            this.fld_txtHRInsurranceSocialInsPercent.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceSocialInsPercent.BOSDescription = null;
            this.fld_txtHRInsurranceSocialInsPercent.BOSError = null;
            this.fld_txtHRInsurranceSocialInsPercent.BOSFieldGroup = null;
            this.fld_txtHRInsurranceSocialInsPercent.BOSFieldRelation = null;
            this.fld_txtHRInsurranceSocialInsPercent.BOSPrivilege = "Text";
            this.fld_txtHRInsurranceSocialInsPercent.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceSocialInsPercent, "fld_txtHRInsurranceSocialInsPercent");
            this.fld_txtHRInsurranceSocialInsPercent.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceSocialInsPercent.Name = "fld_txtHRInsurranceSocialInsPercent";
            this.fld_txtHRInsurranceSocialInsPercent.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceSocialInsPercent.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceSocialInsPercent.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceSocialInsPercent.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceSocialInsPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceSocialInsPercent, ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercent.ShowHelp"))));
            this.fld_txtHRInsurranceSocialInsPercent.Tag = "DC";
            // 
            // fld_txtHRInsurranceOutOfWorkInsPercentDN
            // 
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSComment = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSDataMember = "HRInsurranceOutOfWorkInsPercentDN";
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSDescription = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSError = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSFieldGroup = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSFieldRelation = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSPrivilege = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceOutOfWorkInsPercentDN, "fld_txtHRInsurranceOutOfWorkInsPercentDN");
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Name = "fld_txtHRInsurranceOutOfWorkInsPercentDN";
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceOutOfWorkInsPercentDN, ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercentDN.ShowHelp"))));
            this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel16, "bosLabel16");
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, ((bool)(resources.GetObject("bosLabel16.ShowHelp"))));
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel19, "bosLabel19");
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, ((bool)(resources.GetObject("bosLabel19.ShowHelp"))));
            // 
            // fld_txtHRInsurranceHealthInsPercent
            // 
            this.fld_txtHRInsurranceHealthInsPercent.BOSComment = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSDataMember = "HRInsurranceHealthInsPercent";
            this.fld_txtHRInsurranceHealthInsPercent.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceHealthInsPercent.BOSDescription = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSError = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSFieldGroup = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSFieldRelation = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSPrivilege = null;
            this.fld_txtHRInsurranceHealthInsPercent.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceHealthInsPercent, "fld_txtHRInsurranceHealthInsPercent");
            this.fld_txtHRInsurranceHealthInsPercent.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceHealthInsPercent.Name = "fld_txtHRInsurranceHealthInsPercent";
            this.fld_txtHRInsurranceHealthInsPercent.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceHealthInsPercent.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceHealthInsPercent.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceHealthInsPercent.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceHealthInsPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceHealthInsPercent, ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercent.ShowHelp"))));
            this.fld_txtHRInsurranceHealthInsPercent.Tag = "DC";
            // 
            // fld_txtHRInsurranceHealthInsPercentDN
            // 
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSComment = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSDataMember = "HRInsurranceHealthInsPercentDN";
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSDescription = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSError = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSFieldGroup = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSFieldRelation = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSPrivilege = null;
            this.fld_txtHRInsurranceHealthInsPercentDN.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceHealthInsPercentDN, "fld_txtHRInsurranceHealthInsPercentDN");
            this.fld_txtHRInsurranceHealthInsPercentDN.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceHealthInsPercentDN.Name = "fld_txtHRInsurranceHealthInsPercentDN";
            this.fld_txtHRInsurranceHealthInsPercentDN.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceHealthInsPercentDN.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceHealthInsPercentDN.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentDN.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceHealthInsPercentDN.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceHealthInsPercentDN, ((bool)(resources.GetObject("fld_txtHRInsurranceHealthInsPercentDN.ShowHelp"))));
            this.fld_txtHRInsurranceHealthInsPercentDN.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel17, "bosLabel17");
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, ((bool)(resources.GetObject("bosLabel17.ShowHelp"))));
            // 
            // fld_txtHRInsurranceOutOfWorkInsPercent
            // 
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSComment = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSDataMember = "HRInsurranceOutOfWorkInsPercent";
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSDescription = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSError = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSFieldGroup = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSFieldRelation = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSPrivilege = null;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceOutOfWorkInsPercent, "fld_txtHRInsurranceOutOfWorkInsPercent");
            this.fld_txtHRInsurranceOutOfWorkInsPercent.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceOutOfWorkInsPercent.Name = "fld_txtHRInsurranceOutOfWorkInsPercent";
            this.fld_txtHRInsurranceOutOfWorkInsPercent.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceOutOfWorkInsPercent.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceOutOfWorkInsPercent.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercent.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceOutOfWorkInsPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceOutOfWorkInsPercent, ((bool)(resources.GetObject("fld_txtHRInsurranceOutOfWorkInsPercent.ShowHelp"))));
            this.fld_txtHRInsurranceOutOfWorkInsPercent.Tag = "DC";
            // 
            // fld_txtHRInsurranceSocialInsPercentDN
            // 
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSComment = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSDataMember = "HRInsurranceSocialInsPercentDN";
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSDataSource = "ADInsurrances";
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSDescription = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSError = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSFieldGroup = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSFieldRelation = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSPrivilege = null;
            this.fld_txtHRInsurranceSocialInsPercentDN.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHRInsurranceSocialInsPercentDN, "fld_txtHRInsurranceSocialInsPercentDN");
            this.fld_txtHRInsurranceSocialInsPercentDN.MenuManager = this.screenToolbar;
            this.fld_txtHRInsurranceSocialInsPercentDN.Name = "fld_txtHRInsurranceSocialInsPercentDN";
            this.fld_txtHRInsurranceSocialInsPercentDN.Properties.Mask.EditMask = resources.GetString("fld_txtHRInsurranceSocialInsPercentDN.Properties.Mask.EditMask");
            this.fld_txtHRInsurranceSocialInsPercentDN.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentDN.Properties.Mask.MaskType")));
            this.fld_txtHRInsurranceSocialInsPercentDN.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRInsurranceSocialInsPercentDN, ((bool)(resources.GetObject("fld_txtHRInsurranceSocialInsPercentDN.ShowHelp"))));
            this.fld_txtHRInsurranceSocialInsPercentDN.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel23, "bosLabel23");
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, ((bool)(resources.GetObject("bosLabel23.ShowHelp"))));
            // 
            // fld_btnSaveInsurrances
            // 
            this.fld_btnSaveInsurrances.BOSComment = null;
            this.fld_btnSaveInsurrances.BOSDataMember = null;
            this.fld_btnSaveInsurrances.BOSDataSource = null;
            this.fld_btnSaveInsurrances.BOSDescription = null;
            this.fld_btnSaveInsurrances.BOSError = null;
            this.fld_btnSaveInsurrances.BOSFieldGroup = null;
            this.fld_btnSaveInsurrances.BOSFieldRelation = null;
            this.fld_btnSaveInsurrances.BOSPrivilege = null;
            this.fld_btnSaveInsurrances.BOSPropertyName = null;
            this.fld_btnSaveInsurrances.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            resources.ApplyResources(this.fld_btnSaveInsurrances, "fld_btnSaveInsurrances");
            this.fld_btnSaveInsurrances.Name = "fld_btnSaveInsurrances";
            this.fld_btnSaveInsurrances.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveInsurrances, ((bool)(resources.GetObject("fld_btnSaveInsurrances.ShowHelp"))));
            this.fld_btnSaveInsurrances.Click += new System.EventHandler(this.fld_btnSaveInsurrances_Click);
            // 
            // xtraTabPage10
            // 
            this.xtraTabPage10.Controls.Add(this.fld_dgcADTimesheetConfigs);
            this.xtraTabPage10.Controls.Add(this.fld_btnSaveTimesheetConfigs);
            this.xtraTabPage10.Name = "xtraTabPage10";
            resources.ApplyResources(this.xtraTabPage10, "xtraTabPage10");
            // 
            // fld_dgcADTimesheetConfigs
            // 
            this.fld_dgcADTimesheetConfigs.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcADTimesheetConfigs, "fld_dgcADTimesheetConfigs");
            this.fld_dgcADTimesheetConfigs.BOSComment = "";
            this.fld_dgcADTimesheetConfigs.BOSDataMember = null;
            this.fld_dgcADTimesheetConfigs.BOSDataSource = "ADTimesheetConfigs";
            this.fld_dgcADTimesheetConfigs.BOSDescription = null;
            this.fld_dgcADTimesheetConfigs.BOSError = "";
            this.fld_dgcADTimesheetConfigs.BOSFieldGroup = "";
            this.fld_dgcADTimesheetConfigs.BOSFieldRelation = null;
            this.fld_dgcADTimesheetConfigs.BOSGridType = null;
            this.fld_dgcADTimesheetConfigs.BOSPrivilege = "";
            this.fld_dgcADTimesheetConfigs.BOSPropertyName = null;
            this.fld_dgcADTimesheetConfigs.CommodityType = "";
            this.fld_dgcADTimesheetConfigs.MainView = this.gridView41;
            this.fld_dgcADTimesheetConfigs.Name = "fld_dgcADTimesheetConfigs";
            this.fld_dgcADTimesheetConfigs.PrintReport = false;
            this.fld_dgcADTimesheetConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADTimesheetConfigs, ((bool)(resources.GetObject("fld_dgcADTimesheetConfigs.ShowHelp"))));
            this.fld_dgcADTimesheetConfigs.Tag = "DC";
            this.fld_dgcADTimesheetConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView41});
            // 
            // gridView41
            // 
            this.gridView41.GridControl = this.fld_dgcADTimesheetConfigs;
            this.gridView41.Name = "gridView41";
            this.gridView41.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveTimesheetConfigs
            // 
            resources.ApplyResources(this.fld_btnSaveTimesheetConfigs, "fld_btnSaveTimesheetConfigs");
            this.fld_btnSaveTimesheetConfigs.BOSComment = null;
            this.fld_btnSaveTimesheetConfigs.BOSDataMember = null;
            this.fld_btnSaveTimesheetConfigs.BOSDataSource = null;
            this.fld_btnSaveTimesheetConfigs.BOSDescription = null;
            this.fld_btnSaveTimesheetConfigs.BOSError = null;
            this.fld_btnSaveTimesheetConfigs.BOSFieldGroup = null;
            this.fld_btnSaveTimesheetConfigs.BOSFieldRelation = null;
            this.fld_btnSaveTimesheetConfigs.BOSPrivilege = null;
            this.fld_btnSaveTimesheetConfigs.BOSPropertyName = null;
            this.fld_btnSaveTimesheetConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveTimesheetConfigs.Name = "fld_btnSaveTimesheetConfigs";
            this.fld_btnSaveTimesheetConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveTimesheetConfigs, ((bool)(resources.GetObject("fld_btnSaveTimesheetConfigs.ShowHelp"))));
            this.fld_btnSaveTimesheetConfigs.Click += new System.EventHandler(this.fld_btnSaveTimesheetConfigs_Click);
            // 
            // xtraTabPage11
            // 
            this.xtraTabPage11.Controls.Add(this.panel1);
            this.xtraTabPage11.Name = "xtraTabPage11";
            resources.ApplyResources(this.xtraTabPage11, "xtraTabPage11");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox23);
            this.panel1.Controls.Add(this.groupBox25);
            this.panel1.Name = "panel1";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.fld_dgcHRConfigRanks);
            this.groupBox23.Controls.Add(this.fld_btnSaveRank);
            resources.ApplyResources(this.groupBox23, "groupBox23");
            this.groupBox23.Name = "groupBox23";
            this.ScreenHelper.SetShowHelp(this.groupBox23, ((bool)(resources.GetObject("groupBox23.ShowHelp"))));
            this.groupBox23.TabStop = false;
            // 
            // fld_dgcHRConfigRanks
            // 
            this.fld_dgcHRConfigRanks.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHRConfigRanks, "fld_dgcHRConfigRanks");
            this.fld_dgcHRConfigRanks.BOSComment = "";
            this.fld_dgcHRConfigRanks.BOSDataMember = null;
            this.fld_dgcHRConfigRanks.BOSDataSource = "HRConfigRanks";
            this.fld_dgcHRConfigRanks.BOSDescription = null;
            this.fld_dgcHRConfigRanks.BOSError = "";
            this.fld_dgcHRConfigRanks.BOSFieldGroup = "";
            this.fld_dgcHRConfigRanks.BOSFieldRelation = null;
            this.fld_dgcHRConfigRanks.BOSGridType = null;
            this.fld_dgcHRConfigRanks.BOSPrivilege = "";
            this.fld_dgcHRConfigRanks.BOSPropertyName = null;
            this.fld_dgcHRConfigRanks.CommodityType = "";
            this.fld_dgcHRConfigRanks.MainView = this.gridView19;
            this.fld_dgcHRConfigRanks.Name = "fld_dgcHRConfigRanks";
            this.fld_dgcHRConfigRanks.PrintReport = false;
            this.fld_dgcHRConfigRanks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRConfigRanks, ((bool)(resources.GetObject("fld_dgcHRConfigRanks.ShowHelp"))));
            this.fld_dgcHRConfigRanks.Tag = "DC";
            this.fld_dgcHRConfigRanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView19});
            // 
            // gridView19
            // 
            this.gridView19.GridControl = this.fld_dgcHRConfigRanks;
            this.gridView19.Name = "gridView19";
            this.gridView19.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveRank
            // 
            resources.ApplyResources(this.fld_btnSaveRank, "fld_btnSaveRank");
            this.fld_btnSaveRank.BOSComment = null;
            this.fld_btnSaveRank.BOSDataMember = null;
            this.fld_btnSaveRank.BOSDataSource = null;
            this.fld_btnSaveRank.BOSDescription = null;
            this.fld_btnSaveRank.BOSError = null;
            this.fld_btnSaveRank.BOSFieldGroup = null;
            this.fld_btnSaveRank.BOSFieldRelation = null;
            this.fld_btnSaveRank.BOSPrivilege = null;
            this.fld_btnSaveRank.BOSPropertyName = null;
            this.fld_btnSaveRank.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveRank.Name = "fld_btnSaveRank";
            this.fld_btnSaveRank.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveRank, ((bool)(resources.GetObject("fld_btnSaveRank.ShowHelp"))));
            this.fld_btnSaveRank.Click += new System.EventHandler(this.fld_btnSaveRank_Click);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.fld_dgcHRConfigScales);
            this.groupBox25.Controls.Add(this.fld_btnSaveScale);
            resources.ApplyResources(this.groupBox25, "groupBox25");
            this.groupBox25.Name = "groupBox25";
            this.ScreenHelper.SetShowHelp(this.groupBox25, ((bool)(resources.GetObject("groupBox25.ShowHelp"))));
            this.groupBox25.TabStop = false;
            // 
            // fld_dgcHRConfigScales
            // 
            this.fld_dgcHRConfigScales.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHRConfigScales, "fld_dgcHRConfigScales");
            this.fld_dgcHRConfigScales.BOSComment = "";
            this.fld_dgcHRConfigScales.BOSDataMember = null;
            this.fld_dgcHRConfigScales.BOSDataSource = "HRConfigScales";
            this.fld_dgcHRConfigScales.BOSDescription = null;
            this.fld_dgcHRConfigScales.BOSError = "";
            this.fld_dgcHRConfigScales.BOSFieldGroup = "";
            this.fld_dgcHRConfigScales.BOSFieldRelation = null;
            this.fld_dgcHRConfigScales.BOSGridType = null;
            this.fld_dgcHRConfigScales.BOSPrivilege = "";
            this.fld_dgcHRConfigScales.BOSPropertyName = null;
            this.fld_dgcHRConfigScales.CommodityType = "";
            this.fld_dgcHRConfigScales.MainView = this.gridView18;
            this.fld_dgcHRConfigScales.Name = "fld_dgcHRConfigScales";
            this.fld_dgcHRConfigScales.PrintReport = false;
            this.fld_dgcHRConfigScales.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRConfigScales, ((bool)(resources.GetObject("fld_dgcHRConfigScales.ShowHelp"))));
            this.fld_dgcHRConfigScales.Tag = "DC";
            this.fld_dgcHRConfigScales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView18});
            // 
            // gridView18
            // 
            this.gridView18.GridControl = this.fld_dgcHRConfigScales;
            this.gridView18.Name = "gridView18";
            this.gridView18.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveScale
            // 
            resources.ApplyResources(this.fld_btnSaveScale, "fld_btnSaveScale");
            this.fld_btnSaveScale.BOSComment = null;
            this.fld_btnSaveScale.BOSDataMember = null;
            this.fld_btnSaveScale.BOSDataSource = null;
            this.fld_btnSaveScale.BOSDescription = null;
            this.fld_btnSaveScale.BOSError = null;
            this.fld_btnSaveScale.BOSFieldGroup = null;
            this.fld_btnSaveScale.BOSFieldRelation = null;
            this.fld_btnSaveScale.BOSPrivilege = null;
            this.fld_btnSaveScale.BOSPropertyName = null;
            this.fld_btnSaveScale.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveScale.Name = "fld_btnSaveScale";
            this.fld_btnSaveScale.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveScale, ((bool)(resources.GetObject("fld_btnSaveScale.ShowHelp"))));
            this.fld_btnSaveScale.Click += new System.EventHandler(this.fld_btnSaveScale_Click);
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Controls.Add(this.panel2);
            this.xtraTabPage12.Name = "xtraTabPage12";
            resources.ApplyResources(this.xtraTabPage12, "xtraTabPage12");
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Name = "panel2";
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fld_dgcHRSeniorityLeaveDayConfigs);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.ScreenHelper.SetShowHelp(this.groupBox2, ((bool)(resources.GetObject("groupBox2.ShowHelp"))));
            this.groupBox2.TabStop = false;
            // 
            // fld_dgcHRSeniorityLeaveDayConfigs
            // 
            this.fld_dgcHRSeniorityLeaveDayConfigs.AllowDrop = true;
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSComment = "";
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSDataMember = null;
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSDataSource = "HRSeniorityLeaveDayConfigs";
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSDescription = null;
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSError = "";
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSFieldGroup = "";
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSFieldRelation = null;
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSGridType = null;
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSPrivilege = "";
            this.fld_dgcHRSeniorityLeaveDayConfigs.BOSPropertyName = null;
            this.fld_dgcHRSeniorityLeaveDayConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRSeniorityLeaveDayConfigs, "fld_dgcHRSeniorityLeaveDayConfigs");
            this.fld_dgcHRSeniorityLeaveDayConfigs.MainView = this.gridView21;
            this.fld_dgcHRSeniorityLeaveDayConfigs.Name = "fld_dgcHRSeniorityLeaveDayConfigs";
            this.fld_dgcHRSeniorityLeaveDayConfigs.PrintReport = false;
            this.fld_dgcHRSeniorityLeaveDayConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRSeniorityLeaveDayConfigs, ((bool)(resources.GetObject("fld_dgcHRSeniorityLeaveDayConfigs.ShowHelp"))));
            this.fld_dgcHRSeniorityLeaveDayConfigs.Tag = "DC";
            this.fld_dgcHRSeniorityLeaveDayConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView21});
            // 
            // gridView21
            // 
            this.gridView21.GridControl = this.fld_dgcHRSeniorityLeaveDayConfigs;
            this.gridView21.Name = "gridView21";
            this.gridView21.PaintStyleName = "Office2003";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.ScreenHelper.SetShowHelp(this.splitContainer1.Panel1, ((bool)(resources.GetObject("splitContainer1.Panel1.ShowHelp"))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.ScreenHelper.SetShowHelp(this.splitContainer1.Panel2, ((bool)(resources.GetObject("splitContainer1.Panel2.ShowHelp"))));
            this.ScreenHelper.SetShowHelp(this.splitContainer1, ((bool)(resources.GetObject("splitContainer1.ShowHelp"))));
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fld_dgcHRDepartmentRoomLeaveDayConfigs);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.ScreenHelper.SetShowHelp(this.groupBox3, ((bool)(resources.GetObject("groupBox3.ShowHelp"))));
            this.groupBox3.TabStop = false;
            // 
            // fld_dgcHRDepartmentRoomLeaveDayConfigs
            // 
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.AllowDrop = true;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSComment = "";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSDataMember = null;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSDataSource = "HRDepartmentRoomLeaveDayConfigs";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSDescription = null;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSError = "";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSFieldGroup = "";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSFieldRelation = null;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSGridType = null;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSPrivilege = "";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.BOSPropertyName = null;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRDepartmentRoomLeaveDayConfigs, "fld_dgcHRDepartmentRoomLeaveDayConfigs");
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.MainView = this.gridView22;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.Name = "fld_dgcHRDepartmentRoomLeaveDayConfigs";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.PrintReport = false;
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRDepartmentRoomLeaveDayConfigs, ((bool)(resources.GetObject("fld_dgcHRDepartmentRoomLeaveDayConfigs.ShowHelp"))));
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.Tag = "DC";
            this.fld_dgcHRDepartmentRoomLeaveDayConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView22});
            // 
            // gridView22
            // 
            this.gridView22.GridControl = this.fld_dgcHRDepartmentRoomLeaveDayConfigs;
            this.gridView22.Name = "gridView22";
            this.gridView22.PaintStyleName = "Office2003";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fld_dgcHROtherLeaveDayConfigs);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.ScreenHelper.SetShowHelp(this.groupBox4, ((bool)(resources.GetObject("groupBox4.ShowHelp"))));
            this.groupBox4.TabStop = false;
            // 
            // fld_dgcHROtherLeaveDayConfigs
            // 
            this.fld_dgcHROtherLeaveDayConfigs.AllowDrop = true;
            this.fld_dgcHROtherLeaveDayConfigs.BOSComment = "";
            this.fld_dgcHROtherLeaveDayConfigs.BOSDataMember = null;
            this.fld_dgcHROtherLeaveDayConfigs.BOSDataSource = "HROtherLeaveDayConfigs";
            this.fld_dgcHROtherLeaveDayConfigs.BOSDescription = null;
            this.fld_dgcHROtherLeaveDayConfigs.BOSError = "";
            this.fld_dgcHROtherLeaveDayConfigs.BOSFieldGroup = "";
            this.fld_dgcHROtherLeaveDayConfigs.BOSFieldRelation = null;
            this.fld_dgcHROtherLeaveDayConfigs.BOSGridType = null;
            this.fld_dgcHROtherLeaveDayConfigs.BOSPrivilege = "";
            this.fld_dgcHROtherLeaveDayConfigs.BOSPropertyName = null;
            this.fld_dgcHROtherLeaveDayConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHROtherLeaveDayConfigs, "fld_dgcHROtherLeaveDayConfigs");
            this.fld_dgcHROtherLeaveDayConfigs.MainView = this.gridView23;
            this.fld_dgcHROtherLeaveDayConfigs.Name = "fld_dgcHROtherLeaveDayConfigs";
            this.fld_dgcHROtherLeaveDayConfigs.PrintReport = false;
            this.fld_dgcHROtherLeaveDayConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHROtherLeaveDayConfigs, ((bool)(resources.GetObject("fld_dgcHROtherLeaveDayConfigs.ShowHelp"))));
            this.fld_dgcHROtherLeaveDayConfigs.Tag = "DC";
            this.fld_dgcHROtherLeaveDayConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView23});
            // 
            // gridView23
            // 
            this.gridView23.GridControl = this.fld_dgcHROtherLeaveDayConfigs;
            this.gridView23.Name = "gridView23";
            this.gridView23.PaintStyleName = "Office2003";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.fld_dgcHRAnnualLeaveDayConfigs);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // fld_dgcHRAnnualLeaveDayConfigs
            // 
            this.fld_dgcHRAnnualLeaveDayConfigs.AllowDrop = true;
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSComment = "";
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSDataMember = null;
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSDataSource = "HRAnnualLeaveDayConfigs";
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSDescription = null;
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSError = "";
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSFieldGroup = "";
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSFieldRelation = null;
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSGridType = null;
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSPrivilege = "";
            this.fld_dgcHRAnnualLeaveDayConfigs.BOSPropertyName = null;
            this.fld_dgcHRAnnualLeaveDayConfigs.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRAnnualLeaveDayConfigs, "fld_dgcHRAnnualLeaveDayConfigs");
            this.fld_dgcHRAnnualLeaveDayConfigs.MainView = this.gridView20;
            this.fld_dgcHRAnnualLeaveDayConfigs.Name = "fld_dgcHRAnnualLeaveDayConfigs";
            this.fld_dgcHRAnnualLeaveDayConfigs.PrintReport = false;
            this.fld_dgcHRAnnualLeaveDayConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRAnnualLeaveDayConfigs, ((bool)(resources.GetObject("fld_dgcHRAnnualLeaveDayConfigs.ShowHelp"))));
            this.fld_dgcHRAnnualLeaveDayConfigs.Tag = "DC";
            this.fld_dgcHRAnnualLeaveDayConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView20});
            // 
            // gridView20
            // 
            this.gridView20.GridControl = this.fld_dgcHRAnnualLeaveDayConfigs;
            this.gridView20.Name = "gridView20";
            this.gridView20.PaintStyleName = "Office2003";
            // 
            // xtraTabPage13
            // 
            this.xtraTabPage13.Controls.Add(this.groupBox7);
            this.xtraTabPage13.Name = "xtraTabPage13";
            resources.ApplyResources(this.xtraTabPage13, "xtraTabPage13");
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fld_dgcHRRelationships);
            this.groupBox7.Controls.Add(this.fld_btnSaveRelationships);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.ScreenHelper.SetShowHelp(this.groupBox7, ((bool)(resources.GetObject("groupBox7.ShowHelp"))));
            this.groupBox7.TabStop = false;
            // 
            // fld_dgcHRRelationships
            // 
            this.fld_dgcHRRelationships.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcHRRelationships, "fld_dgcHRRelationships");
            this.fld_dgcHRRelationships.BOSComment = "";
            this.fld_dgcHRRelationships.BOSDataMember = null;
            this.fld_dgcHRRelationships.BOSDataSource = "HRRelationships";
            this.fld_dgcHRRelationships.BOSDescription = null;
            this.fld_dgcHRRelationships.BOSError = "";
            this.fld_dgcHRRelationships.BOSFieldGroup = "";
            this.fld_dgcHRRelationships.BOSFieldRelation = null;
            this.fld_dgcHRRelationships.BOSGridType = null;
            this.fld_dgcHRRelationships.BOSPrivilege = "";
            this.fld_dgcHRRelationships.BOSPropertyName = null;
            this.fld_dgcHRRelationships.CommodityType = "";
            this.fld_dgcHRRelationships.MainView = this.gridView25;
            this.fld_dgcHRRelationships.Name = "fld_dgcHRRelationships";
            this.fld_dgcHRRelationships.PrintReport = false;
            this.fld_dgcHRRelationships.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRRelationships, ((bool)(resources.GetObject("fld_dgcHRRelationships.ShowHelp"))));
            this.fld_dgcHRRelationships.Tag = "DC";
            this.fld_dgcHRRelationships.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView25});
            // 
            // gridView25
            // 
            this.gridView25.GridControl = this.fld_dgcHRRelationships;
            this.gridView25.Name = "gridView25";
            this.gridView25.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveRelationships
            // 
            resources.ApplyResources(this.fld_btnSaveRelationships, "fld_btnSaveRelationships");
            this.fld_btnSaveRelationships.BOSComment = "";
            this.fld_btnSaveRelationships.BOSDataMember = null;
            this.fld_btnSaveRelationships.BOSDataSource = null;
            this.fld_btnSaveRelationships.BOSDescription = null;
            this.fld_btnSaveRelationships.BOSError = null;
            this.fld_btnSaveRelationships.BOSFieldGroup = null;
            this.fld_btnSaveRelationships.BOSFieldRelation = null;
            this.fld_btnSaveRelationships.BOSPrivilege = null;
            this.fld_btnSaveRelationships.BOSPropertyName = null;
            this.fld_btnSaveRelationships.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveRelationships.Name = "fld_btnSaveRelationships";
            this.fld_btnSaveRelationships.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveRelationships, ((bool)(resources.GetObject("fld_btnSaveRelationships.ShowHelp"))));
            this.fld_btnSaveRelationships.Click += new System.EventHandler(this.fld_btnSaveRelationships_Click);
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // gridView5
            // 
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // gridView8
            // 
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // gridView9
            // 
            this.gridView9.Name = "gridView9";
            this.gridView9.PaintStyleName = "Office2003";
            // 
            // gridView32
            // 
            this.gridView32.Name = "gridView32";
            this.gridView32.PaintStyleName = "Office2003";
            // 
            // gridView33
            // 
            this.gridView33.Name = "gridView33";
            this.gridView33.PaintStyleName = "Office2003";
            // 
            // gridView34
            // 
            this.gridView34.Name = "gridView34";
            this.gridView34.PaintStyleName = "Office2003";
            // 
            // DMCS105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_tabHumanResource);
            this.Name = "DMCS105";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_tabHumanResource, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHumanResource)).EndInit();
            this.fld_tabHumanResource.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabOvertimeConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetParam2s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.fld_tabPayrollConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.fld_grpGroupControl15.ResumeLayout(false);
            this.fld_grpGroupControl15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtNormalLeaveDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTLeaveDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBirthLeaveDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSickLeaveDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAnnualLeaveDays.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTToTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTValueTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTFromTime.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSubtractOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTAuditDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtOTAuditMonth.Properties)).EndInit();
            this.fld_grpGroupControl14.ResumeLayout(false);
            this.fld_grpGroupControl14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHoursPerDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtDaysPerMonth.Properties)).EndInit();
            this.fld_grpGroupControl13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRWorkingShifts)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePieceWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSalaryTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSalaryConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADConfigValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTrainingCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            this.fld_tabUserAppPermission.ResumeLayout(false);
            this.fld_tabUserAppPermission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeADUserGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeConfigFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeConfigGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADAppUserPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRErrorTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            this.xtraTabPage8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceManageConfigHistorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView24)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAllowanceManageConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            this.xtraTabPage9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurrancePlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView27)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurrancePapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView28)).EndInit();
            this.groupBox33.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADInsurranceConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView29)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardManageConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView26)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentNext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentNext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentNext.Properties)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentPrevious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentPrevious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentPrevious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRInsurranceDateApply.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRInsurranceDateApply.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtADInsurranceDependencyLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtADInsurranceLevelNotTaxable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercentDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceHealthInsPercentDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceOutOfWorkInsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRInsurranceSocialInsPercentDN.Properties)).EndInit();
            this.xtraTabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTimesheetConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView41)).EndInit();
            this.xtraTabPage11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigRanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).EndInit();
            this.groupBox25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigScales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).EndInit();
            this.xtraTabPage12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSeniorityLeaveDayConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomLeaveDayConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHROtherLeaveDayConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView23)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAnnualLeaveDayConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).EndInit();
            this.xtraTabPage13.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRelationships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabHumanResource;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLine fld_grpGroupControl14;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtHoursPerDay;
        private BOSComponent.BOSTextBox fld_txtDaysPerMonth;
        private BOSComponent.BOSLine fld_grpGroupControl13;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private HRTimeSheetParamGridControl fld_dgcHRTimeSheetParams;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private WorkingShiftGridControl fld_dgcHRWorkingShifts;
        private BOSComponent.BOSLine fld_grpGroupControl15;
        private BOSComponent.BOSTextBox fld_txtNormalLeaveDays;
        private BOSComponent.BOSTextBox fld_txtOTLeaveDays;
        private BOSComponent.BOSTextBox fld_txtBirthLeaveDays;
        private BOSComponent.BOSTextBox fld_txtSickLeaveDays;
        private BOSComponent.BOSTextBox fld_txtAnnualLeaveDays;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSLine bosLine5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private HREmployeePieceWorksGridControl fld_dgcHREmployeePieceWorks; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private HRSalaryTypeGridControl fld_dgcHRSalaryTypeGridControl; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private HRTimeSheetParam2GridControl fld_dgcHRTimeSheetParam2s; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private HRTimeSheetParam3GridControl fld_dgcADConfigValues; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private TrainingCoursesGridControl fld_dgcTrainingCourse; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtOTAuditMonth;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtOTAuditDay;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtOTToTime;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtOTFromTime;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtOTValueTime;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private EmployeeSalaryConfigsGridControl fld_dgcHREmployeeSalaryConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraTab.XtraTabPage fld_tabUserAppPermission;
        private AppUserPermissionsGridControl fld_dgcADAppUserPermissions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private ErrorTypesGridControl fld_dgcHRErrorTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabOvertimeConfig;
        private DevExpress.XtraTab.XtraTabPage fld_tabPayrollConfig;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeADUserGroupID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeConfigFunction;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeConfigGroup;
        private BOSComponent.BOSButton fld_btnAddGroup;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private HRAllowanceManageConfigsGridControl fld_dgcHRAllowanceManageConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage10;
        private BOSComponent.BOSButton fld_btnSaveTimesheetConfigs;
        private ADTimesheetConfigsGridControl fld_dgcADTimesheetConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView41;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage11;
        private Panel panel1;
        private GroupBox groupBox23;
        private BOSComponent.BOSButton fld_btnSaveScale;
        private GroupBox groupBox25;
        private BOSComponent.BOSButton fld_btnSaveRank;
        private HRConfigRanksGridControl fld_dgcHRConfigRanks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView19;
        private HRConfigScalesGridControl fld_dgcHRConfigScales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView18;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;
        private Panel panel2;
        private GroupBox groupBox1;
        private HRAnnualLeaveDayConfigsGridControl fld_dgcHRAnnualLeaveDayConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView20;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private HRSeniorityLeaveDayConfigsGridControl fld_dgcHRSeniorityLeaveDayConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private GroupBox groupBox3;
        private HRDepartmentRoomLeaveDayConfigsGridControl fld_dgcHRDepartmentRoomLeaveDayConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView22;
        private GroupBox groupBox4;
        private HROtherLeaveDayConfigsGridControl fld_dgcHROtherLeaveDayConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView23;
        private GroupBox groupBox5;
        private BOSComponent.BOSButton fld_btnSaveAllowanceManageConfigs;
        private GroupBox groupBox6;
        private HRAllowanceManageConfigHistorysGridControl fld_dgcHRAllowanceManageConfigHistorys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView24;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage13;
        private GroupBox groupBox7;
        private HRRelationshipsGridControl fld_dgcHRRelationships; 
        private DevExpress.XtraGrid.Views.Grid.GridView gridView25;
        private BOSComponent.BOSButton fld_btnSaveRelationships;
        private BOSComponent.BOSTextBox fld_txtSubtractOT;
        private BOSComponent.BOSLabel bosLabel24;
        private Panel panel3;
        private BOSComponent.BOSLine bosLine3;
        private GroupBox groupBox9;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceOutOfWorkInsPercentNext;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceHealthInsPercentNext;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceSocialInsPercentNext;
        private GroupBox groupBox8;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceOutOfWorkInsPercentPrevious;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceHealthInsPercentPrevious;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceSocialInsPercentPrevious;
        private BOSComponent.BOSDateEdit fld_dteHRInsurranceDateApply;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtADInsurranceDependencyLevel;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtADInsurranceLevelNotTaxable;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceSocialInsPercent;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceOutOfWorkInsPercentDN;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceHealthInsPercent;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceHealthInsPercentDN;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceOutOfWorkInsPercent;
        private BOSComponent.BOSTextBox fld_txtHRInsurranceSocialInsPercentDN;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSButton fld_btnSaveInsurrances;
        private GroupBox groupBox10;
        private HRATMCardManageConfigsGridControl fld_dgcHRATMCardManageConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView26;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton bosButton2;
        private SplitContainer splitContainer3;
        private GroupBox groupBox31;
        private ADInsurrancePlansGridControl fld_dgcADInsurrancePlans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView27;
        private SplitContainer splitContainer4;
        private GroupBox groupBox32;
        private ADInsurrancePapersGridControl fld_dgcADInsurrancePapers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView28;
        private GroupBox groupBox33;
        private ADInsurranceConditionsGridControl fld_dgcADInsurranceConditions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView29;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView32;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView33;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView34;
    }
}
