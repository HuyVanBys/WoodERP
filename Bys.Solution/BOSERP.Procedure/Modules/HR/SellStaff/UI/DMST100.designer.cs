using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMST100
	/// </summary>
	partial class DMST100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSTextBox fld_txtHREmployeeNo1;
		private BOSComponent.BOSLookupEdit fld_lkeHREmployeeStatusCombo;
        private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeStartWorkingDate;
		private BOSComponent.BOSTextBox fld_txtHREmployeeEmail1;
		private BOSComponent.BOSMemoEdit fld_medHREmployeeDesc;
		private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel13;
		private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeGenderCombo;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSLabel fld_lblLabel25;
		private BOSComponent.BOSLabel fld_lblLabel27;
		private BOSComponent.BOSLabel fld_lblLabel28;
		private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSLabel fld_lblLabel30;
		private BOSComponent.BOSLabel fld_lblLabel32;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContactAddress;
		private BOSComponent.BOSTextBox fld_txtHREmployeeContactPostalCode;
        private BOSComponent.BOSTextBox fld_txtHREmployeeBankAccount1;
		private BOSComponent.BOSTextBox fld_txtHREmployeeBankName;
		private BOSComponent.BOSTextBox fld_txtHREmployeeTaxNumber;
        private BOSComponent.BOSTextBox fld_txtHREmployeeName;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMST100));
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ceHREmployeeIsAllowedLeave = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_gbPauseStatus = new System.Windows.Forms.GroupBox();
            this.fld_dteHREmployeeEndPauseDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeStartPauseDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRTimeSheetParamID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteHREmployeeApprenticeDay = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeDobYear = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeAnnualLeaveRemain = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeStopWorkingDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkdFK_GEStateProvinceBirthPlaceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentroomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_ceHREmployeeIsUnionMember = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeHREmployeeMaritalStatusCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeDob = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREmployeeIDCardDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeMonthWorking = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeCardNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeIDNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEIDCardStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEReligionID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GENationalityID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GENativeStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLevel = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRLevelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHREmployeeStatusCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeEmail1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_ptbHREmployeePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fld_txtHREmployeePictureFileName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeDobString = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTel2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeStartWorkingDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHREmployeeTel1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHREmployeeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeGenderCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeName = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEWardID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeContactTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeContactAddress = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContactPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEStateProvinceID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEDistrictID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeBankAccount1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeBankName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnAddContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteContact = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditContact = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeContacts = new BOSERP.Modules.SellStaff.HREmployeeContactsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeIsAllowedLeave.Properties)).BeginInit();
            this.fld_gbPauseStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeEndPauseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeEndPauseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartPauseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartPauseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetParamID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeApprenticeDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeApprenticeDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeDobYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAnnualLeaveRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStopWorkingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStopWorkingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentroomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeIsUnionMember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeMaritalStatusCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeDob.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeDob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeIDCardDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeIDCardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeMonthWorking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEIDCardStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEReligionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GENationalityID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GENativeStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatusCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeEmail1.Properties)).BeginInit();
            this.fld_Line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbHREmployeePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePictureFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeDobString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartWorkingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartWorkingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGenderCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEWardID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContactTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBankAccount1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTaxNumber.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            resources.ApplyResources(this.fld_grcGroupControl, "fld_grcGroupControl");
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = null;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = null;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = null;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_ceHREmployeeIsAllowedLeave);
            this.fld_grcGroupControl.Controls.Add(this.fld_gbPauseStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel26);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl.Controls.Add(this.bosLookupEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeeApprenticeDay);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel20);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeDobYear);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel19);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeAnnualLeaveRemain);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel17);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHREmployeeTypeCombo);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel16);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeeStopWorkingDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel15);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkdFK_GEStateProvinceBirthPlaceID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRDepartmentroomID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel14);
            this.fld_grcGroupControl.Controls.Add(this.fld_ceHREmployeeIsUnionMember);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHREmployeeMaritalStatusCombo);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeeDob);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeeIDCardDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeMonthWorking);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeCardNumber);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeIDNumber);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_GEIDCardStateProvinceID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_GEReligionID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_GENationalityID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_GENativeStateProvinceID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLevel);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRLevelID);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHREmployeeStatusCombo);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeEmail1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel18);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_Line);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel22);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeDobString);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeTel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHREmployeeStartWorkingDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeTel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHREmployeeDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel16);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel20);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHREmployeeGenderCombo);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREmployeeName);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, ((bool)(resources.GetObject("fld_grcGroupControl.ShowHelp"))));
            // 
            // fld_ceHREmployeeIsAllowedLeave
            // 
            this.fld_ceHREmployeeIsAllowedLeave.BOSComment = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSDataMember = "HREmployeeIsAllowedLeave";
            this.fld_ceHREmployeeIsAllowedLeave.BOSDataSource = "HREmployees";
            this.fld_ceHREmployeeIsAllowedLeave.BOSDescription = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSError = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSFieldGroup = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSFieldRelation = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSPrivilege = null;
            this.fld_ceHREmployeeIsAllowedLeave.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_ceHREmployeeIsAllowedLeave, "fld_ceHREmployeeIsAllowedLeave");
            this.fld_ceHREmployeeIsAllowedLeave.MenuManager = this.screenToolbar;
            this.fld_ceHREmployeeIsAllowedLeave.Name = "fld_ceHREmployeeIsAllowedLeave";
            this.fld_ceHREmployeeIsAllowedLeave.Properties.Caption = resources.GetString("fld_ceHREmployeeIsAllowedLeave.Properties.Caption");
            this.fld_ceHREmployeeIsAllowedLeave.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ceHREmployeeIsAllowedLeave, ((bool)(resources.GetObject("fld_ceHREmployeeIsAllowedLeave.ShowHelp"))));
            this.fld_ceHREmployeeIsAllowedLeave.Tag = "DC";
            // 
            // fld_gbPauseStatus
            // 
            this.fld_gbPauseStatus.Controls.Add(this.fld_dteHREmployeeEndPauseDate);
            this.fld_gbPauseStatus.Controls.Add(this.bosLabel25);
            this.fld_gbPauseStatus.Controls.Add(this.fld_dteHREmployeeStartPauseDate);
            this.fld_gbPauseStatus.Controls.Add(this.bosLabel24);
            this.fld_gbPauseStatus.Controls.Add(this.bosLabel23);
            this.fld_gbPauseStatus.Controls.Add(this.fld_lkeFK_HRTimeSheetParamID);
            resources.ApplyResources(this.fld_gbPauseStatus, "fld_gbPauseStatus");
            this.fld_gbPauseStatus.Name = "fld_gbPauseStatus";
            this.fld_gbPauseStatus.TabStop = false;
            // 
            // fld_dteHREmployeeEndPauseDate
            // 
            this.fld_dteHREmployeeEndPauseDate.BOSComment = null;
            this.fld_dteHREmployeeEndPauseDate.BOSDataMember = "HREmployeeEndPauseDate";
            this.fld_dteHREmployeeEndPauseDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeEndPauseDate.BOSDescription = null;
            this.fld_dteHREmployeeEndPauseDate.BOSError = null;
            this.fld_dteHREmployeeEndPauseDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeEndPauseDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeEndPauseDate.BOSPrivilege = null;
            this.fld_dteHREmployeeEndPauseDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeEndPauseDate, "fld_dteHREmployeeEndPauseDate");
            this.fld_dteHREmployeeEndPauseDate.Name = "fld_dteHREmployeeEndPauseDate";
            this.fld_dteHREmployeeEndPauseDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeEndPauseDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeEndPauseDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeEndPauseDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeEndPauseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeEndPauseDate.Properties.Buttons"))))});
            this.fld_dteHREmployeeEndPauseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeEndPauseDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeEndPauseDate, ((bool)(resources.GetObject("fld_dteHREmployeeEndPauseDate.ShowHelp"))));
            this.fld_dteHREmployeeEndPauseDate.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
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
            // fld_dteHREmployeeStartPauseDate
            // 
            this.fld_dteHREmployeeStartPauseDate.BOSComment = null;
            this.fld_dteHREmployeeStartPauseDate.BOSDataMember = "HREmployeeStartPauseDate";
            this.fld_dteHREmployeeStartPauseDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeStartPauseDate.BOSDescription = null;
            this.fld_dteHREmployeeStartPauseDate.BOSError = null;
            this.fld_dteHREmployeeStartPauseDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeStartPauseDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeStartPauseDate.BOSPrivilege = null;
            this.fld_dteHREmployeeStartPauseDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeStartPauseDate, "fld_dteHREmployeeStartPauseDate");
            this.fld_dteHREmployeeStartPauseDate.Name = "fld_dteHREmployeeStartPauseDate";
            this.fld_dteHREmployeeStartPauseDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeStartPauseDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeStartPauseDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeStartPauseDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeStartPauseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeStartPauseDate.Properties.Buttons"))))});
            this.fld_dteHREmployeeStartPauseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeStartPauseDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeStartPauseDate, ((bool)(resources.GetObject("fld_dteHREmployeeStartPauseDate.ShowHelp"))));
            this.fld_dteHREmployeeStartPauseDate.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
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
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
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
            // fld_lkeFK_HRTimeSheetParamID
            // 
            this.fld_lkeFK_HRTimeSheetParamID.BOSAllowAddNew = true;
            this.fld_lkeFK_HRTimeSheetParamID.BOSAllowDummy = true;
            this.fld_lkeFK_HRTimeSheetParamID.BOSComment = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSDataMember = "FK_HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRTimeSheetParamID.BOSDescription = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSError = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldGroup = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldParent = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldRelation = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSPrivilege = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTimeSheetParamID.BOSSelectType = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRTimeSheetParamID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRTimeSheetParamID, "fld_lkeFK_HRTimeSheetParamID");
            this.fld_lkeFK_HRTimeSheetParamID.Name = "fld_lkeFK_HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRTimeSheetParamID.Properties.Buttons"))))});
            this.fld_lkeFK_HRTimeSheetParamID.Properties.ColumnName = null;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRTimeSheetParamID.Properties.Columns"), resources.GetString("fld_lkeFK_HRTimeSheetParamID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRTimeSheetParamID.Properties.Columns2"), resources.GetString("fld_lkeFK_HRTimeSheetParamID.Properties.Columns3"))});
            this.fld_lkeFK_HRTimeSheetParamID.Properties.DisplayMember = "HRTimeSheetParamName";
            this.fld_lkeFK_HRTimeSheetParamID.Properties.NullText = resources.GetString("fld_lkeFK_HRTimeSheetParamID.Properties.NullText");
            this.fld_lkeFK_HRTimeSheetParamID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.ValueMember = "HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRTimeSheetParamID, ((bool)(resources.GetObject("fld_lkeFK_HRTimeSheetParamID.ShowHelp"))));
            this.fld_lkeFK_HRTimeSheetParamID.Tag = "DC";
            this.fld_lkeFK_HRTimeSheetParamID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRTimeSheetParamID_QueryPopUp);
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel26, "bosLabel26");
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel26, ((bool)(resources.GetObject("bosLabel26.ShowHelp"))));
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
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
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACAccountPurchaseID";
            this.bosLookupEdit1.BOSDataSource = "HREmployees";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            resources.ApplyResources(this.bosLookupEdit1, "bosLookupEdit1");
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("bosLookupEdit1.Properties.Buttons"))))});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("bosLookupEdit1.Properties.Columns"), resources.GetString("bosLookupEdit1.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("bosLookupEdit1.Properties.Columns2"), resources.GetString("bosLookupEdit1.Properties.Columns3"))});
            this.bosLookupEdit1.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit1.Properties.NullText = resources.GetString("bosLookupEdit1.Properties.NullText");
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, ((bool)(resources.GetObject("bosLookupEdit1.ShowHelp"))));
            this.bosLookupEdit1.Tag = "DC";
            this.bosLookupEdit1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_txtFK_HRDepartmentRoomGroupteamItemID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupTeamItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataMember = "FK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID, "fld_lkeFK_HRDepartmentRoomGroupTeamItemID");
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Buttons"))))});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns"), resources.GetString("fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.Columns1"))});
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.DisplayMember = "HRDepartmentRoomGroupTeamItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.NullText = resources.GetString("fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.NullText");
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties.ValueMember = "HRDepartmentRoomGroupTeamItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID, ((bool)(resources.GetObject("fld_lkeFK_HRDepartmentRoomGroupTeamItemID.ShowHelp"))));
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_txtFK_HRDepartmentRoomGroupteamItemID_QueryPopUp);
            // 
            // fld_dteHREmployeeApprenticeDay
            // 
            this.fld_dteHREmployeeApprenticeDay.BOSComment = "";
            this.fld_dteHREmployeeApprenticeDay.BOSDataMember = "HREmployeeApprenticeDay";
            this.fld_dteHREmployeeApprenticeDay.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeApprenticeDay.BOSDescription = null;
            this.fld_dteHREmployeeApprenticeDay.BOSError = null;
            this.fld_dteHREmployeeApprenticeDay.BOSFieldGroup = null;
            this.fld_dteHREmployeeApprenticeDay.BOSFieldRelation = null;
            this.fld_dteHREmployeeApprenticeDay.BOSPrivilege = null;
            this.fld_dteHREmployeeApprenticeDay.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeApprenticeDay, "fld_dteHREmployeeApprenticeDay");
            this.fld_dteHREmployeeApprenticeDay.Name = "fld_dteHREmployeeApprenticeDay";
            this.fld_dteHREmployeeApprenticeDay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeApprenticeDay.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeApprenticeDay.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeApprenticeDay.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeApprenticeDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeApprenticeDay.Properties.Buttons"))))});
            this.fld_dteHREmployeeApprenticeDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeApprenticeDay.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeApprenticeDay, ((bool)(resources.GetObject("fld_dteHREmployeeApprenticeDay.ShowHelp"))));
            this.fld_dteHREmployeeApprenticeDay.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
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
            // fld_txtHREmployeeDobYear
            // 
            this.fld_txtHREmployeeDobYear.BOSComment = "";
            this.fld_txtHREmployeeDobYear.BOSDataMember = "";
            this.fld_txtHREmployeeDobYear.BOSDataSource = "";
            this.fld_txtHREmployeeDobYear.BOSDescription = null;
            this.fld_txtHREmployeeDobYear.BOSError = null;
            this.fld_txtHREmployeeDobYear.BOSFieldGroup = null;
            this.fld_txtHREmployeeDobYear.BOSFieldRelation = null;
            this.fld_txtHREmployeeDobYear.BOSPrivilege = null;
            this.fld_txtHREmployeeDobYear.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeDobYear, "fld_txtHREmployeeDobYear");
            this.fld_txtHREmployeeDobYear.Name = "fld_txtHREmployeeDobYear";
            this.fld_txtHREmployeeDobYear.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeDobYear.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeDobYear.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeDobYear.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeDobYear.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeDobYear.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeDobYear.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeDobYear, ((bool)(resources.GetObject("fld_txtHREmployeeDobYear.ShowHelp"))));
            this.fld_txtHREmployeeDobYear.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
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
            // fld_txtHREmployeeAnnualLeaveRemain
            // 
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSComment = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSDataMember = "HREmployeeAnnualLeaveRemain";
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSDescription = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSError = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSFieldGroup = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSFieldRelation = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSPrivilege = null;
            this.fld_txtHREmployeeAnnualLeaveRemain.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeAnnualLeaveRemain, "fld_txtHREmployeeAnnualLeaveRemain");
            this.fld_txtHREmployeeAnnualLeaveRemain.Name = "fld_txtHREmployeeAnnualLeaveRemain";
            this.fld_txtHREmployeeAnnualLeaveRemain.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeAnnualLeaveRemain.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeAnnualLeaveRemain.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeAnnualLeaveRemain.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeAnnualLeaveRemain.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeAnnualLeaveRemain.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeAnnualLeaveRemain.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeAnnualLeaveRemain, ((bool)(resources.GetObject("fld_txtHREmployeeAnnualLeaveRemain.ShowHelp"))));
            this.fld_txtHREmployeeAnnualLeaveRemain.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
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
            // fld_lkeHREmployeeTypeCombo
            // 
            this.fld_lkeHREmployeeTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeTypeCombo.BOSAllowDummy = true;
            this.fld_lkeHREmployeeTypeCombo.BOSComment = null;
            this.fld_lkeHREmployeeTypeCombo.BOSDataMember = "HREmployeeTypeCombo";
            this.fld_lkeHREmployeeTypeCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeTypeCombo.BOSDescription = null;
            this.fld_lkeHREmployeeTypeCombo.BOSError = null;
            this.fld_lkeHREmployeeTypeCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeTypeCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeTypeCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeTypeCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeTypeCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeTypeCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeTypeCombo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeTypeCombo, "fld_lkeHREmployeeTypeCombo");
            this.fld_lkeHREmployeeTypeCombo.Name = "fld_lkeHREmployeeTypeCombo";
            this.fld_lkeHREmployeeTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeTypeCombo.Properties.Buttons"))))});
            this.fld_lkeHREmployeeTypeCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeTypeCombo.Properties.NullText = resources.GetString("fld_lkeHREmployeeTypeCombo.Properties.NullText");
            this.fld_lkeHREmployeeTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeTypeCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeTypeCombo, ((bool)(resources.GetObject("fld_lkeHREmployeeTypeCombo.ShowHelp"))));
            this.fld_lkeHREmployeeTypeCombo.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
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
            // fld_dteHREmployeeStopWorkingDate
            // 
            this.fld_dteHREmployeeStopWorkingDate.BOSComment = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSDataMember = "HREmployeeStopWorkingDate";
            this.fld_dteHREmployeeStopWorkingDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeStopWorkingDate.BOSDescription = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSError = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSPrivilege = null;
            this.fld_dteHREmployeeStopWorkingDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeStopWorkingDate, "fld_dteHREmployeeStopWorkingDate");
            this.fld_dteHREmployeeStopWorkingDate.Name = "fld_dteHREmployeeStopWorkingDate";
            this.fld_dteHREmployeeStopWorkingDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeStopWorkingDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeStopWorkingDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeStopWorkingDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeStopWorkingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeStopWorkingDate.Properties.Buttons"))))});
            this.fld_dteHREmployeeStopWorkingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeStopWorkingDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeStopWorkingDate, ((bool)(resources.GetObject("fld_dteHREmployeeStopWorkingDate.ShowHelp"))));
            this.fld_dteHREmployeeStopWorkingDate.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel15, "bosLabel15");
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, ((bool)(resources.GetObject("bosLabel15.ShowHelp"))));
            // 
            // fld_lkdFK_GEStateProvinceBirthPlaceID
            // 
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSAllowAddNew = true;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSAllowDummy = true;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSComment = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSDataMember = "FK_GEStateProvinceBirthPlaceID";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSDataSource = "HREmployees";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSDescription = "";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSError = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSFieldGroup = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSFieldRelation = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSPrivilege = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSPropertyName = "EditValue";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSSelectType = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.BOSSelectTypeValue = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkdFK_GEStateProvinceBirthPlaceID, "fld_lkdFK_GEStateProvinceBirthPlaceID");
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Name = "fld_lkdFK_GEStateProvinceBirthPlaceID";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Buttons"))))});
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.ColumnName = null;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Columns"), resources.GetString("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Columns2"), resources.GetString("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.Columns3"))});
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.NullText = resources.GetString("fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.NullText");
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.PopupWidth = 40;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkdFK_GEStateProvinceBirthPlaceID, ((bool)(resources.GetObject("fld_lkdFK_GEStateProvinceBirthPlaceID.ShowHelp"))));
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.Tag = "DC";
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkdFK_GEStateProvinceBirthPlaceID_CloseUp);
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanged);
            this.fld_lkdFK_GEStateProvinceBirthPlaceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_HRDepartmentroomID
            // 
            this.fld_lkeFK_HRDepartmentroomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentroomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentroomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentroomID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentroomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRDepartmentroomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentroomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentroomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentroomID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRDepartmentroomID, "fld_lkeFK_HRDepartmentroomID");
            this.fld_lkeFK_HRDepartmentroomID.Name = "fld_lkeFK_HRDepartmentroomID";
            this.fld_lkeFK_HRDepartmentroomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentroomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentroomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentroomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentroomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRDepartmentroomID.Properties.Buttons"))))});
            this.fld_lkeFK_HRDepartmentroomID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentroomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns"), resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns2"), resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns4"), resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.Columns5"))});
            this.fld_lkeFK_HRDepartmentroomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentroomID.Properties.NullText = resources.GetString("fld_lkeFK_HRDepartmentroomID.Properties.NullText");
            this.fld_lkeFK_HRDepartmentroomID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentroomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentroomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentroomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentroomID, ((bool)(resources.GetObject("fld_lkeFK_HRDepartmentroomID.ShowHelp"))));
            this.fld_lkeFK_HRDepartmentroomID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentroomID.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentroomID_Validated);
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID1
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRDepartmentRoomGroupItemID1, "fld_lkeFK_HRDepartmentRoomGroupItemID1");
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID1";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Buttons"))))});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Columns"), resources.GetString("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Columns2"), resources.GetString("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.Columns3"))});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.NullText = resources.GetString("fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.NullText");
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomGroupItemID1, ((bool)(resources.GetObject("fld_lkeFK_HRDepartmentRoomGroupItemID1.ShowHelp"))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentRoomGroupItemID1_Validated);
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel14, "bosLabel14");
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, ((bool)(resources.GetObject("bosLabel14.ShowHelp"))));
            // 
            // fld_ceHREmployeeIsUnionMember
            // 
            this.fld_ceHREmployeeIsUnionMember.BOSComment = null;
            this.fld_ceHREmployeeIsUnionMember.BOSDataMember = "HREmployeeIsUnionMember";
            this.fld_ceHREmployeeIsUnionMember.BOSDataSource = "HREmployees";
            this.fld_ceHREmployeeIsUnionMember.BOSDescription = null;
            this.fld_ceHREmployeeIsUnionMember.BOSError = null;
            this.fld_ceHREmployeeIsUnionMember.BOSFieldGroup = null;
            this.fld_ceHREmployeeIsUnionMember.BOSFieldRelation = null;
            this.fld_ceHREmployeeIsUnionMember.BOSPrivilege = null;
            this.fld_ceHREmployeeIsUnionMember.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_ceHREmployeeIsUnionMember, "fld_ceHREmployeeIsUnionMember");
            this.fld_ceHREmployeeIsUnionMember.MenuManager = this.screenToolbar;
            this.fld_ceHREmployeeIsUnionMember.Name = "fld_ceHREmployeeIsUnionMember";
            this.fld_ceHREmployeeIsUnionMember.Properties.Caption = resources.GetString("fld_ceHREmployeeIsUnionMember.Properties.Caption");
            this.fld_ceHREmployeeIsUnionMember.Screen = null;
            this.fld_ceHREmployeeIsUnionMember.Tag = "DC";
            // 
            // fld_lkeHREmployeeMaritalStatusCombo
            // 
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSAllowDummy = false;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSComment = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSDataMember = "HREmployeeMaritalStatusCombo";
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSDescription = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSError = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeMaritalStatusCombo, "fld_lkeHREmployeeMaritalStatusCombo");
            this.fld_lkeHREmployeeMaritalStatusCombo.Name = "fld_lkeHREmployeeMaritalStatusCombo";
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeMaritalStatusCombo.Properties.Buttons"))))});
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.NullText = resources.GetString("fld_lkeHREmployeeMaritalStatusCombo.Properties.NullText");
            this.fld_lkeHREmployeeMaritalStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeMaritalStatusCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeMaritalStatusCombo, ((bool)(resources.GetObject("fld_lkeHREmployeeMaritalStatusCombo.ShowHelp"))));
            this.fld_lkeHREmployeeMaritalStatusCombo.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
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
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel13, "bosLabel13");
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, ((bool)(resources.GetObject("bosLabel13.ShowHelp"))));
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
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
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
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
            // fld_dteHREmployeeDob
            // 
            this.fld_dteHREmployeeDob.BOSComment = null;
            this.fld_dteHREmployeeDob.BOSDataMember = "HREmployeeDob";
            this.fld_dteHREmployeeDob.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeDob.BOSDescription = null;
            this.fld_dteHREmployeeDob.BOSError = null;
            this.fld_dteHREmployeeDob.BOSFieldGroup = null;
            this.fld_dteHREmployeeDob.BOSFieldRelation = null;
            this.fld_dteHREmployeeDob.BOSPrivilege = null;
            this.fld_dteHREmployeeDob.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeDob, "fld_dteHREmployeeDob");
            this.fld_dteHREmployeeDob.Name = "fld_dteHREmployeeDob";
            this.fld_dteHREmployeeDob.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeDob.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeDob.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeDob.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeDob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeDob.Properties.Buttons"))))});
            this.fld_dteHREmployeeDob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeDob.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeDob, ((bool)(resources.GetObject("fld_dteHREmployeeDob.ShowHelp"))));
            this.fld_dteHREmployeeDob.Tag = "DC";
            this.fld_dteHREmployeeDob.TextChanged += new System.EventHandler(this.fld_dteHREmployeeDob_TextChanged);
            this.fld_dteHREmployeeDob.Validated += new System.EventHandler(this.fld_dteHREmployeeDob_Validated);
            // 
            // fld_dteHREmployeeIDCardDate
            // 
            this.fld_dteHREmployeeIDCardDate.BOSComment = null;
            this.fld_dteHREmployeeIDCardDate.BOSDataMember = "HREmployeeIDCardDate";
            this.fld_dteHREmployeeIDCardDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeIDCardDate.BOSDescription = null;
            this.fld_dteHREmployeeIDCardDate.BOSError = null;
            this.fld_dteHREmployeeIDCardDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeIDCardDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeIDCardDate.BOSPrivilege = null;
            this.fld_dteHREmployeeIDCardDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeIDCardDate, "fld_dteHREmployeeIDCardDate");
            this.fld_dteHREmployeeIDCardDate.Name = "fld_dteHREmployeeIDCardDate";
            this.fld_dteHREmployeeIDCardDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeIDCardDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeIDCardDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeIDCardDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeIDCardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeIDCardDate.Properties.Buttons"))))});
            this.fld_dteHREmployeeIDCardDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeIDCardDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeIDCardDate, ((bool)(resources.GetObject("fld_dteHREmployeeIDCardDate.ShowHelp"))));
            this.fld_dteHREmployeeIDCardDate.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
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
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
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
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
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
            // fld_txtHREmployeeMonthWorking
            // 
            this.fld_txtHREmployeeMonthWorking.BOSComment = null;
            this.fld_txtHREmployeeMonthWorking.BOSDataMember = "HREmployeeWorkingMonths";
            this.fld_txtHREmployeeMonthWorking.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeMonthWorking.BOSDescription = null;
            this.fld_txtHREmployeeMonthWorking.BOSError = null;
            this.fld_txtHREmployeeMonthWorking.BOSFieldGroup = null;
            this.fld_txtHREmployeeMonthWorking.BOSFieldRelation = null;
            this.fld_txtHREmployeeMonthWorking.BOSPrivilege = null;
            this.fld_txtHREmployeeMonthWorking.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeMonthWorking, "fld_txtHREmployeeMonthWorking");
            this.fld_txtHREmployeeMonthWorking.Name = "fld_txtHREmployeeMonthWorking";
            this.fld_txtHREmployeeMonthWorking.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeMonthWorking.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeMonthWorking.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeMonthWorking.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeMonthWorking.Properties.Mask.EditMask = resources.GetString("fld_txtHREmployeeMonthWorking.Properties.Mask.EditMask");
            this.fld_txtHREmployeeMonthWorking.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeMonthWorking.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeMonthWorking.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeMonthWorking, ((bool)(resources.GetObject("fld_txtHREmployeeMonthWorking.ShowHelp"))));
            this.fld_txtHREmployeeMonthWorking.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
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
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_BRBranchID, "fld_lkeFK_BRBranchID");
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_BRBranchID.Properties.Buttons"))))});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // fld_txtHREmployeeCardNumber
            // 
            this.fld_txtHREmployeeCardNumber.BOSComment = null;
            this.fld_txtHREmployeeCardNumber.BOSDataMember = "HREmployeeCardNumber";
            this.fld_txtHREmployeeCardNumber.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeCardNumber.BOSDescription = null;
            this.fld_txtHREmployeeCardNumber.BOSError = null;
            this.fld_txtHREmployeeCardNumber.BOSFieldGroup = null;
            this.fld_txtHREmployeeCardNumber.BOSFieldRelation = null;
            this.fld_txtHREmployeeCardNumber.BOSPrivilege = null;
            this.fld_txtHREmployeeCardNumber.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeCardNumber, "fld_txtHREmployeeCardNumber");
            this.fld_txtHREmployeeCardNumber.Name = "fld_txtHREmployeeCardNumber";
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeCardNumber.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeCardNumber.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeCardNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeCardNumber, ((bool)(resources.GetObject("fld_txtHREmployeeCardNumber.ShowHelp"))));
            this.fld_txtHREmployeeCardNumber.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
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
            // fld_txtHREmployeeIDNumber
            // 
            this.fld_txtHREmployeeIDNumber.BOSComment = null;
            this.fld_txtHREmployeeIDNumber.BOSDataMember = "HREmployeeIDNumber";
            this.fld_txtHREmployeeIDNumber.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeIDNumber.BOSDescription = null;
            this.fld_txtHREmployeeIDNumber.BOSError = null;
            this.fld_txtHREmployeeIDNumber.BOSFieldGroup = null;
            this.fld_txtHREmployeeIDNumber.BOSFieldRelation = null;
            this.fld_txtHREmployeeIDNumber.BOSPrivilege = null;
            this.fld_txtHREmployeeIDNumber.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeIDNumber, "fld_txtHREmployeeIDNumber");
            this.fld_txtHREmployeeIDNumber.Name = "fld_txtHREmployeeIDNumber";
            this.fld_txtHREmployeeIDNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeIDNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeIDNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeIDNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeIDNumber.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeIDNumber.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeIDNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeIDNumber, ((bool)(resources.GetObject("fld_txtHREmployeeIDNumber.ShowHelp"))));
            this.fld_txtHREmployeeIDNumber.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
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
            // fld_lkeFK_GEIDCardStateProvinceID
            // 
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSAllowDummy = true;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSComment = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSDataMember = "FK_GEIDCardStateProvinceID";
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSError = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSFieldGroup = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSFieldRelation = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSPrivilege = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSSelectType = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GEIDCardStateProvinceID, "fld_lkeFK_GEIDCardStateProvinceID");
            this.fld_lkeFK_GEIDCardStateProvinceID.Name = "fld_lkeFK_GEIDCardStateProvinceID";
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GEIDCardStateProvinceID.Properties.Buttons"))))});
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEIDCardStateProvinceID.Properties.Columns"), resources.GetString("fld_lkeFK_GEIDCardStateProvinceID.Properties.Columns1"))});
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.NullText = resources.GetString("fld_lkeFK_GEIDCardStateProvinceID.Properties.NullText");
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEIDCardStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEIDCardStateProvinceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEIDCardStateProvinceID, ((bool)(resources.GetObject("fld_lkeFK_GEIDCardStateProvinceID.ShowHelp"))));
            this.fld_lkeFK_GEIDCardStateProvinceID.Tag = "DC";
            this.fld_lkeFK_GEIDCardStateProvinceID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEIDCardStateProvinceID_EditValueChanged);
            this.fld_lkeFK_GEIDCardStateProvinceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEIDCardStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_GEReligionID
            // 
            this.fld_lkeFK_GEReligionID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEReligionID.BOSAllowDummy = true;
            this.fld_lkeFK_GEReligionID.BOSComment = null;
            this.fld_lkeFK_GEReligionID.BOSDataMember = "FK_GEReligionID";
            this.fld_lkeFK_GEReligionID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_GEReligionID.BOSDescription = null;
            this.fld_lkeFK_GEReligionID.BOSError = null;
            this.fld_lkeFK_GEReligionID.BOSFieldGroup = null;
            this.fld_lkeFK_GEReligionID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEReligionID.BOSFieldRelation = null;
            this.fld_lkeFK_GEReligionID.BOSPrivilege = null;
            this.fld_lkeFK_GEReligionID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEReligionID.BOSSelectType = null;
            this.fld_lkeFK_GEReligionID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEReligionID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GEReligionID, "fld_lkeFK_GEReligionID");
            this.fld_lkeFK_GEReligionID.Name = "fld_lkeFK_GEReligionID";
            this.fld_lkeFK_GEReligionID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEReligionID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEReligionID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEReligionID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEReligionID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GEReligionID.Properties.Buttons"))))});
            this.fld_lkeFK_GEReligionID.Properties.ColumnName = null;
            this.fld_lkeFK_GEReligionID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEReligionID.Properties.Columns"), resources.GetString("fld_lkeFK_GEReligionID.Properties.Columns1"))});
            this.fld_lkeFK_GEReligionID.Properties.DisplayMember = "GEReligionName";
            this.fld_lkeFK_GEReligionID.Properties.NullText = resources.GetString("fld_lkeFK_GEReligionID.Properties.NullText");
            this.fld_lkeFK_GEReligionID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEReligionID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEReligionID.Properties.ValueMember = "GEReligionID";
            this.fld_lkeFK_GEReligionID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEReligionID, ((bool)(resources.GetObject("fld_lkeFK_GEReligionID.ShowHelp"))));
            this.fld_lkeFK_GEReligionID.Tag = "DC";
            this.fld_lkeFK_GEReligionID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEReligionID_EditValueChanged);
            this.fld_lkeFK_GEReligionID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEReligionID_EditValueChanging);
            // 
            // fld_lkeFK_GENationalityID
            // 
            this.fld_lkeFK_GENationalityID.BOSAllowAddNew = true;
            this.fld_lkeFK_GENationalityID.BOSAllowDummy = true;
            this.fld_lkeFK_GENationalityID.BOSComment = null;
            this.fld_lkeFK_GENationalityID.BOSDataMember = "FK_GENationalityID";
            this.fld_lkeFK_GENationalityID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_GENationalityID.BOSDescription = null;
            this.fld_lkeFK_GENationalityID.BOSError = null;
            this.fld_lkeFK_GENationalityID.BOSFieldGroup = null;
            this.fld_lkeFK_GENationalityID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GENationalityID.BOSFieldRelation = null;
            this.fld_lkeFK_GENationalityID.BOSPrivilege = null;
            this.fld_lkeFK_GENationalityID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GENationalityID.BOSSelectType = null;
            this.fld_lkeFK_GENationalityID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GENationalityID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GENationalityID, "fld_lkeFK_GENationalityID");
            this.fld_lkeFK_GENationalityID.Name = "fld_lkeFK_GENationalityID";
            this.fld_lkeFK_GENationalityID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GENationalityID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GENationalityID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GENationalityID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GENationalityID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GENationalityID.Properties.Buttons"))))});
            this.fld_lkeFK_GENationalityID.Properties.ColumnName = null;
            this.fld_lkeFK_GENationalityID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GENationalityID.Properties.Columns"), resources.GetString("fld_lkeFK_GENationalityID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GENationalityID.Properties.Columns2"), resources.GetString("fld_lkeFK_GENationalityID.Properties.Columns3"))});
            this.fld_lkeFK_GENationalityID.Properties.DisplayMember = "GENationalityName";
            this.fld_lkeFK_GENationalityID.Properties.NullText = resources.GetString("fld_lkeFK_GENationalityID.Properties.NullText");
            this.fld_lkeFK_GENationalityID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GENationalityID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GENationalityID.Properties.ValueMember = "GENationalityID";
            this.fld_lkeFK_GENationalityID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GENationalityID, ((bool)(resources.GetObject("fld_lkeFK_GENationalityID.ShowHelp"))));
            this.fld_lkeFK_GENationalityID.Tag = "DC";
            this.fld_lkeFK_GENationalityID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GENationalityID_EditValueChanged);
            this.fld_lkeFK_GENationalityID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GENationalityID_EditValueChanging);
            // 
            // fld_lkeFK_GENativeStateProvinceID
            // 
            this.fld_lkeFK_GENativeStateProvinceID.BOSAllowAddNew = true;
            this.fld_lkeFK_GENativeStateProvinceID.BOSAllowDummy = true;
            this.fld_lkeFK_GENativeStateProvinceID.BOSComment = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSDataMember = "FK_GENativeStateProvinceID";
            this.fld_lkeFK_GENativeStateProvinceID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_GENativeStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSError = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSFieldGroup = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GENativeStateProvinceID.BOSFieldRelation = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSPrivilege = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GENativeStateProvinceID.BOSSelectType = null;
            this.fld_lkeFK_GENativeStateProvinceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GENativeStateProvinceID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GENativeStateProvinceID, "fld_lkeFK_GENativeStateProvinceID");
            this.fld_lkeFK_GENativeStateProvinceID.Name = "fld_lkeFK_GENativeStateProvinceID";
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GENativeStateProvinceID.Properties.Buttons"))))});
            this.fld_lkeFK_GENativeStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GENativeStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GENativeStateProvinceID.Properties.Columns"), resources.GetString("fld_lkeFK_GENativeStateProvinceID.Properties.Columns1"))});
            this.fld_lkeFK_GENativeStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GENativeStateProvinceID.Properties.NullText = resources.GetString("fld_lkeFK_GENativeStateProvinceID.Properties.NullText");
            this.fld_lkeFK_GENativeStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GENativeStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GENativeStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GENativeStateProvinceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GENativeStateProvinceID, ((bool)(resources.GetObject("fld_lkeFK_GENativeStateProvinceID.ShowHelp"))));
            this.fld_lkeFK_GENativeStateProvinceID.Tag = "DC";
            this.fld_lkeFK_GENativeStateProvinceID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GENativeStateProvinceID_EditValueChanged);
            this.fld_lkeFK_GENativeStateProvinceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GENativeStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRDepartmentID, "fld_lkeFK_HRDepartmentID");
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Buttons"))))});
            this.fld_lkeFK_HRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentID.Properties.Columns"), resources.GetString("fld_lkeFK_HRDepartmentID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns3"))), resources.GetString("fld_lkeFK_HRDepartmentID.Properties.Columns4"), ((bool)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_lkeFK_HRDepartmentID.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRDepartmentID.Properties.Columns9"), resources.GetString("fld_lkeFK_HRDepartmentID.Properties.Columns10"))});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = resources.GetString("fld_lkeFK_HRDepartmentID.Properties.NullText");
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, ((bool)(resources.GetObject("fld_lkeFK_HRDepartmentID.ShowHelp"))));
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_HRDepartmentID_EditValueChanged);
            this.fld_lkeFK_HRDepartmentID.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentID_Validated_1);
            // 
            // fld_lblLevel
            // 
            this.fld_lblLevel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLevel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLevel.Appearance.Options.UseBackColor = true;
            this.fld_lblLevel.Appearance.Options.UseForeColor = true;
            this.fld_lblLevel.BOSComment = null;
            this.fld_lblLevel.BOSDataMember = null;
            this.fld_lblLevel.BOSDataSource = null;
            this.fld_lblLevel.BOSDescription = null;
            this.fld_lblLevel.BOSError = null;
            this.fld_lblLevel.BOSFieldGroup = null;
            this.fld_lblLevel.BOSFieldRelation = null;
            this.fld_lblLevel.BOSPrivilege = null;
            this.fld_lblLevel.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLevel, "fld_lblLevel");
            this.fld_lblLevel.Name = "fld_lblLevel";
            this.fld_lblLevel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLevel, ((bool)(resources.GetObject("fld_lblLevel.ShowHelp"))));
            // 
            // fld_lkeFK_HRLevelID
            // 
            this.fld_lkeFK_HRLevelID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRLevelID.BOSAllowDummy = true;
            this.fld_lkeFK_HRLevelID.BOSComment = null;
            this.fld_lkeFK_HRLevelID.BOSDataMember = "FK_HRLevelID";
            this.fld_lkeFK_HRLevelID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRLevelID.BOSDescription = null;
            this.fld_lkeFK_HRLevelID.BOSError = null;
            this.fld_lkeFK_HRLevelID.BOSFieldGroup = null;
            this.fld_lkeFK_HRLevelID.BOSFieldParent = null;
            this.fld_lkeFK_HRLevelID.BOSFieldRelation = null;
            this.fld_lkeFK_HRLevelID.BOSPrivilege = null;
            this.fld_lkeFK_HRLevelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRLevelID.BOSSelectType = null;
            this.fld_lkeFK_HRLevelID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRLevelID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HRLevelID, "fld_lkeFK_HRLevelID");
            this.fld_lkeFK_HRLevelID.Name = "fld_lkeFK_HRLevelID";
            this.fld_lkeFK_HRLevelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRLevelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRLevelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRLevelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRLevelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Buttons"))))});
            this.fld_lkeFK_HRLevelID.Properties.ColumnName = null;
            this.fld_lkeFK_HRLevelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRLevelID.Properties.Columns"), resources.GetString("fld_lkeFK_HRLevelID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns3"))), resources.GetString("fld_lkeFK_HRLevelID.Properties.Columns4"), ((bool)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_lkeFK_HRLevelID.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HRLevelID.Properties.Columns9"), resources.GetString("fld_lkeFK_HRLevelID.Properties.Columns10"))});
            this.fld_lkeFK_HRLevelID.Properties.DisplayMember = "HRLevelName";
            this.fld_lkeFK_HRLevelID.Properties.NullText = resources.GetString("fld_lkeFK_HRLevelID.Properties.NullText");
            this.fld_lkeFK_HRLevelID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRLevelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRLevelID.Properties.ValueMember = "HRLevelID";
            this.fld_lkeFK_HRLevelID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRLevelID, ((bool)(resources.GetObject("fld_lkeFK_HRLevelID.ShowHelp"))));
            this.fld_lkeFK_HRLevelID.Tag = "DC";
            this.fld_lkeFK_HRLevelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRLevelID_CloseUp);
            // 
            // fld_txtHREmployeeNo1
            // 
            this.fld_txtHREmployeeNo1.BOSComment = null;
            this.fld_txtHREmployeeNo1.BOSDataMember = "HREmployeeNo";
            this.fld_txtHREmployeeNo1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeNo1.BOSDescription = null;
            this.fld_txtHREmployeeNo1.BOSError = null;
            this.fld_txtHREmployeeNo1.BOSFieldGroup = null;
            this.fld_txtHREmployeeNo1.BOSFieldRelation = null;
            this.fld_txtHREmployeeNo1.BOSPrivilege = null;
            this.fld_txtHREmployeeNo1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeNo1, "fld_txtHREmployeeNo1");
            this.fld_txtHREmployeeNo1.Name = "fld_txtHREmployeeNo1";
            this.fld_txtHREmployeeNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeNo1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeNo1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeNo1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeNo1, ((bool)(resources.GetObject("fld_txtHREmployeeNo1.ShowHelp"))));
            this.fld_txtHREmployeeNo1.Tag = "DC";
            // 
            // fld_lkeHREmployeeStatusCombo
            // 
            this.fld_lkeHREmployeeStatusCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeStatusCombo.BOSAllowDummy = false;
            this.fld_lkeHREmployeeStatusCombo.BOSComment = null;
            this.fld_lkeHREmployeeStatusCombo.BOSDataMember = "HREmployeeStatusCombo";
            this.fld_lkeHREmployeeStatusCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeStatusCombo.BOSDescription = null;
            this.fld_lkeHREmployeeStatusCombo.BOSError = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeStatusCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeStatusCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeStatusCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeStatusCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeStatusCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeStatusCombo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeStatusCombo, "fld_lkeHREmployeeStatusCombo");
            this.fld_lkeHREmployeeStatusCombo.Name = "fld_lkeHREmployeeStatusCombo";
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeStatusCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeStatusCombo.Properties.Buttons"))))});
            this.fld_lkeHREmployeeStatusCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeStatusCombo.Properties.NullText = resources.GetString("fld_lkeHREmployeeStatusCombo.Properties.NullText");
            this.fld_lkeHREmployeeStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeStatusCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeStatusCombo, ((bool)(resources.GetObject("fld_lkeHREmployeeStatusCombo.ShowHelp"))));
            this.fld_lkeHREmployeeStatusCombo.Tag = "DC";
            this.fld_lkeHREmployeeStatusCombo.Validated += new System.EventHandler(this.fld_lkeHREmployeeStatusCombo_Validated);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = null;
            this.fld_lblLabel5.BOSDataMember = null;
            this.fld_lblLabel5.BOSDataSource = null;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = null;
            this.fld_lblLabel5.BOSFieldRelation = null;
            this.fld_lblLabel5.BOSPrivilege = null;
            this.fld_lblLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel5, "fld_lblLabel5");
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel5, ((bool)(resources.GetObject("fld_lblLabel5.ShowHelp"))));
            // 
            // fld_txtHREmployeeEmail1
            // 
            this.fld_txtHREmployeeEmail1.BOSComment = null;
            this.fld_txtHREmployeeEmail1.BOSDataMember = "HREmployeeEmail1";
            this.fld_txtHREmployeeEmail1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeEmail1.BOSDescription = null;
            this.fld_txtHREmployeeEmail1.BOSError = null;
            this.fld_txtHREmployeeEmail1.BOSFieldGroup = null;
            this.fld_txtHREmployeeEmail1.BOSFieldRelation = null;
            this.fld_txtHREmployeeEmail1.BOSPrivilege = null;
            this.fld_txtHREmployeeEmail1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeEmail1, "fld_txtHREmployeeEmail1");
            this.fld_txtHREmployeeEmail1.Name = "fld_txtHREmployeeEmail1";
            this.fld_txtHREmployeeEmail1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeEmail1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeEmail1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeEmail1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeEmail1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeEmail1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeEmail1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeEmail1, ((bool)(resources.GetObject("fld_txtHREmployeeEmail1.ShowHelp"))));
            this.fld_txtHREmployeeEmail1.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
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
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = null;
            this.fld_lblLabel18.BOSDataMember = null;
            this.fld_lblLabel18.BOSDataSource = null;
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = null;
            this.fld_lblLabel18.BOSFieldRelation = null;
            this.fld_lblLabel18.BOSPrivilege = null;
            this.fld_lblLabel18.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel18, "fld_lblLabel18");
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel18, ((bool)(resources.GetObject("fld_lblLabel18.ShowHelp"))));
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = null;
            this.fld_lblLabel7.BOSDataMember = null;
            this.fld_lblLabel7.BOSDataSource = null;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = null;
            this.fld_lblLabel7.BOSFieldRelation = null;
            this.fld_lblLabel7.BOSPrivilege = null;
            this.fld_lblLabel7.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel7, "fld_lblLabel7");
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel7, ((bool)(resources.GetObject("fld_lblLabel7.ShowHelp"))));
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = null;
            this.fld_Line.BOSDataMember = null;
            this.fld_Line.BOSDataSource = null;
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = null;
            this.fld_Line.BOSFieldRelation = null;
            this.fld_Line.BOSPrivilege = null;
            this.fld_Line.BOSPropertyName = null;
            this.fld_Line.Controls.Add(this.fld_ptbHREmployeePicture);
            this.fld_Line.Controls.Add(this.pictureBox1);
            this.fld_Line.Controls.Add(this.fld_txtHREmployeePictureFileName);
            resources.ApplyResources(this.fld_Line, "fld_Line");
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line, ((bool)(resources.GetObject("fld_Line.ShowHelp"))));
            this.fld_Line.TabStop = false;
            // 
            // fld_ptbHREmployeePicture
            // 
            this.fld_ptbHREmployeePicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbHREmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.fld_ptbHREmployeePicture, "fld_ptbHREmployeePicture");
            this.fld_ptbHREmployeePicture.Name = "fld_ptbHREmployeePicture";
            this.fld_ptbHREmployeePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BOSERP.Procedure.Properties.Resources.Edit;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fld_txtHREmployeePictureFileName
            // 
            this.fld_txtHREmployeePictureFileName.BOSComment = null;
            this.fld_txtHREmployeePictureFileName.BOSDataMember = "HREmployeePictureFileName";
            this.fld_txtHREmployeePictureFileName.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeePictureFileName.BOSDescription = null;
            this.fld_txtHREmployeePictureFileName.BOSError = null;
            this.fld_txtHREmployeePictureFileName.BOSFieldGroup = null;
            this.fld_txtHREmployeePictureFileName.BOSFieldRelation = null;
            this.fld_txtHREmployeePictureFileName.BOSPrivilege = null;
            this.fld_txtHREmployeePictureFileName.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeePictureFileName, "fld_txtHREmployeePictureFileName");
            this.fld_txtHREmployeePictureFileName.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeePictureFileName.Name = "fld_txtHREmployeePictureFileName";
            this.fld_txtHREmployeePictureFileName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("fld_txtHREmployeePictureFileName.Properties.Appearance.Font")));
            this.fld_txtHREmployeePictureFileName.Properties.Appearance.Options.UseFont = true;
            this.fld_txtHREmployeePictureFileName.Properties.ReadOnly = true;
            this.fld_txtHREmployeePictureFileName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeePictureFileName, ((bool)(resources.GetObject("fld_txtHREmployeePictureFileName.ShowHelp"))));
            this.fld_txtHREmployeePictureFileName.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
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
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = null;
            this.fld_lblLabel22.BOSDataMember = null;
            this.fld_lblLabel22.BOSDataSource = null;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = null;
            this.fld_lblLabel22.BOSFieldRelation = null;
            this.fld_lblLabel22.BOSPrivilege = null;
            this.fld_lblLabel22.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel22, "fld_lblLabel22");
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel22, ((bool)(resources.GetObject("fld_lblLabel22.ShowHelp"))));
            // 
            // fld_txtHREmployeeDobString
            // 
            this.fld_txtHREmployeeDobString.BOSComment = null;
            this.fld_txtHREmployeeDobString.BOSDataMember = "HREmployeeDobString";
            this.fld_txtHREmployeeDobString.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeDobString.BOSDescription = null;
            this.fld_txtHREmployeeDobString.BOSError = null;
            this.fld_txtHREmployeeDobString.BOSFieldGroup = null;
            this.fld_txtHREmployeeDobString.BOSFieldRelation = null;
            this.fld_txtHREmployeeDobString.BOSPrivilege = null;
            this.fld_txtHREmployeeDobString.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeDobString, "fld_txtHREmployeeDobString");
            this.fld_txtHREmployeeDobString.Name = "fld_txtHREmployeeDobString";
            this.fld_txtHREmployeeDobString.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeDobString.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeDobString.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeDobString.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeDobString.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeDobString.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeDobString.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeDobString, ((bool)(resources.GetObject("fld_txtHREmployeeDobString.ShowHelp"))));
            this.fld_txtHREmployeeDobString.Tag = "DC";
            this.fld_txtHREmployeeDobString.TextChanged += new System.EventHandler(this.fld_txtHREmployeeDobString_TextChanged);
            // 
            // fld_txtHREmployeeTel2
            // 
            this.fld_txtHREmployeeTel2.BOSComment = null;
            this.fld_txtHREmployeeTel2.BOSDataMember = "HREmployeeTel2";
            this.fld_txtHREmployeeTel2.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeTel2.BOSDescription = null;
            this.fld_txtHREmployeeTel2.BOSError = null;
            this.fld_txtHREmployeeTel2.BOSFieldGroup = null;
            this.fld_txtHREmployeeTel2.BOSFieldRelation = null;
            this.fld_txtHREmployeeTel2.BOSPrivilege = null;
            this.fld_txtHREmployeeTel2.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeTel2, "fld_txtHREmployeeTel2");
            this.fld_txtHREmployeeTel2.Name = "fld_txtHREmployeeTel2";
            this.fld_txtHREmployeeTel2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTel2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTel2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTel2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTel2.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeTel2.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeTel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeTel2, ((bool)(resources.GetObject("fld_txtHREmployeeTel2.ShowHelp"))));
            this.fld_txtHREmployeeTel2.Tag = "DC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = null;
            this.fld_lblLabel12.BOSDataMember = null;
            this.fld_lblLabel12.BOSDataSource = null;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = null;
            this.fld_lblLabel12.BOSFieldRelation = null;
            this.fld_lblLabel12.BOSPrivilege = null;
            this.fld_lblLabel12.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel12, "fld_lblLabel12");
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, ((bool)(resources.GetObject("fld_lblLabel12.ShowHelp"))));
            // 
            // fld_dteHREmployeeStartWorkingDate
            // 
            this.fld_dteHREmployeeStartWorkingDate.BOSComment = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSDataMember = "HREmployeeStartWorkingDate";
            this.fld_dteHREmployeeStartWorkingDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeStartWorkingDate.BOSDescription = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSError = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSPrivilege = null;
            this.fld_dteHREmployeeStartWorkingDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteHREmployeeStartWorkingDate, "fld_dteHREmployeeStartWorkingDate");
            this.fld_dteHREmployeeStartWorkingDate.Name = "fld_dteHREmployeeStartWorkingDate";
            this.fld_dteHREmployeeStartWorkingDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeStartWorkingDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeStartWorkingDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeStartWorkingDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeStartWorkingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHREmployeeStartWorkingDate.Properties.Buttons"))))});
            this.fld_dteHREmployeeStartWorkingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeStartWorkingDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeStartWorkingDate, ((bool)(resources.GetObject("fld_dteHREmployeeStartWorkingDate.ShowHelp"))));
            this.fld_dteHREmployeeStartWorkingDate.Tag = "DC";
            // 
            // fld_txtHREmployeeTel1
            // 
            this.fld_txtHREmployeeTel1.BOSComment = null;
            this.fld_txtHREmployeeTel1.BOSDataMember = "HREmployeeTel1";
            this.fld_txtHREmployeeTel1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeTel1.BOSDescription = null;
            this.fld_txtHREmployeeTel1.BOSError = null;
            this.fld_txtHREmployeeTel1.BOSFieldGroup = null;
            this.fld_txtHREmployeeTel1.BOSFieldRelation = null;
            this.fld_txtHREmployeeTel1.BOSPrivilege = null;
            this.fld_txtHREmployeeTel1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeTel1, "fld_txtHREmployeeTel1");
            this.fld_txtHREmployeeTel1.Name = "fld_txtHREmployeeTel1";
            this.fld_txtHREmployeeTel1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTel1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTel1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTel1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTel1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeTel1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeTel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeTel1, ((bool)(resources.GetObject("fld_txtHREmployeeTel1.ShowHelp"))));
            this.fld_txtHREmployeeTel1.Tag = "DC";
            // 
            // fld_medHREmployeeDesc
            // 
            this.fld_medHREmployeeDesc.BOSComment = null;
            this.fld_medHREmployeeDesc.BOSDataMember = "HREmployeeDesc";
            this.fld_medHREmployeeDesc.BOSDataSource = "HREmployees";
            this.fld_medHREmployeeDesc.BOSDescription = null;
            this.fld_medHREmployeeDesc.BOSError = null;
            this.fld_medHREmployeeDesc.BOSFieldGroup = null;
            this.fld_medHREmployeeDesc.BOSFieldRelation = null;
            this.fld_medHREmployeeDesc.BOSPrivilege = null;
            this.fld_medHREmployeeDesc.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_medHREmployeeDesc, "fld_medHREmployeeDesc");
            this.fld_medHREmployeeDesc.Name = "fld_medHREmployeeDesc";
            this.fld_medHREmployeeDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREmployeeDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREmployeeDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREmployeeDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREmployeeDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHREmployeeDesc, ((bool)(resources.GetObject("fld_medHREmployeeDesc.ShowHelp"))));
            this.fld_medHREmployeeDesc.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = null;
            this.fld_lblLabel8.BOSDataMember = null;
            this.fld_lblLabel8.BOSDataSource = null;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = null;
            this.fld_lblLabel8.BOSFieldRelation = null;
            this.fld_lblLabel8.BOSPrivilege = null;
            this.fld_lblLabel8.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel8, "fld_lblLabel8");
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel8, ((bool)(resources.GetObject("fld_lblLabel8.ShowHelp"))));
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = null;
            this.fld_lblLabel9.BOSDataMember = null;
            this.fld_lblLabel9.BOSDataSource = null;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = null;
            this.fld_lblLabel9.BOSFieldRelation = null;
            this.fld_lblLabel9.BOSPrivilege = null;
            this.fld_lblLabel9.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel9, "fld_lblLabel9");
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel9, ((bool)(resources.GetObject("fld_lblLabel9.ShowHelp"))));
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = null;
            this.fld_lblLabel11.BOSDataMember = null;
            this.fld_lblLabel11.BOSDataSource = null;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = null;
            this.fld_lblLabel11.BOSFieldRelation = null;
            this.fld_lblLabel11.BOSPrivilege = null;
            this.fld_lblLabel11.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel11, "fld_lblLabel11");
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, ((bool)(resources.GetObject("fld_lblLabel11.ShowHelp"))));
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = null;
            this.fld_lblLabel13.BOSDataMember = null;
            this.fld_lblLabel13.BOSDataSource = null;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = null;
            this.fld_lblLabel13.BOSFieldRelation = null;
            this.fld_lblLabel13.BOSPrivilege = null;
            this.fld_lblLabel13.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel13, "fld_lblLabel13");
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel13, ((bool)(resources.GetObject("fld_lblLabel13.ShowHelp"))));
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = null;
            this.fld_lblLabel15.BOSDataMember = null;
            this.fld_lblLabel15.BOSDataSource = null;
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = null;
            this.fld_lblLabel15.BOSFieldRelation = null;
            this.fld_lblLabel15.BOSPrivilege = null;
            this.fld_lblLabel15.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel15, "fld_lblLabel15");
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, ((bool)(resources.GetObject("fld_lblLabel15.ShowHelp"))));
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = null;
            this.fld_lblLabel16.BOSDataMember = null;
            this.fld_lblLabel16.BOSDataSource = null;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = null;
            this.fld_lblLabel16.BOSFieldRelation = null;
            this.fld_lblLabel16.BOSPrivilege = null;
            this.fld_lblLabel16.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel16, "fld_lblLabel16");
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel16, ((bool)(resources.GetObject("fld_lblLabel16.ShowHelp"))));
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = null;
            this.fld_lblLabel20.BOSDataMember = null;
            this.fld_lblLabel20.BOSDataSource = null;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = null;
            this.fld_lblLabel20.BOSFieldRelation = null;
            this.fld_lblLabel20.BOSPrivilege = null;
            this.fld_lblLabel20.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel20, "fld_lblLabel20");
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel20, ((bool)(resources.GetObject("fld_lblLabel20.ShowHelp"))));
            // 
            // fld_lkeHREmployeeGenderCombo
            // 
            this.fld_lkeHREmployeeGenderCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeGenderCombo.BOSAllowDummy = true;
            this.fld_lkeHREmployeeGenderCombo.BOSComment = null;
            this.fld_lkeHREmployeeGenderCombo.BOSDataMember = "HREmployeeGenderCombo";
            this.fld_lkeHREmployeeGenderCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeGenderCombo.BOSDescription = null;
            this.fld_lkeHREmployeeGenderCombo.BOSError = null;
            this.fld_lkeHREmployeeGenderCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeGenderCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeGenderCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeGenderCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeGenderCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeGenderCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeGenderCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeGenderCombo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeGenderCombo, "fld_lkeHREmployeeGenderCombo");
            this.fld_lkeHREmployeeGenderCombo.Name = "fld_lkeHREmployeeGenderCombo";
            this.fld_lkeHREmployeeGenderCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeGenderCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeGenderCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeGenderCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeGenderCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeGenderCombo.Properties.Buttons"))))});
            this.fld_lkeHREmployeeGenderCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeGenderCombo.Properties.NullText = resources.GetString("fld_lkeHREmployeeGenderCombo.Properties.NullText");
            this.fld_lkeHREmployeeGenderCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeGenderCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeGenderCombo, ((bool)(resources.GetObject("fld_lkeHREmployeeGenderCombo.ShowHelp"))));
            this.fld_lkeHREmployeeGenderCombo.Tag = "DC";
            // 
            // fld_txtHREmployeeName
            // 
            this.fld_txtHREmployeeName.BOSComment = null;
            this.fld_txtHREmployeeName.BOSDataMember = "HREmployeeName";
            this.fld_txtHREmployeeName.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeName.BOSDescription = null;
            this.fld_txtHREmployeeName.BOSError = null;
            this.fld_txtHREmployeeName.BOSFieldGroup = null;
            this.fld_txtHREmployeeName.BOSFieldRelation = null;
            this.fld_txtHREmployeeName.BOSPrivilege = null;
            this.fld_txtHREmployeeName.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeName, "fld_txtHREmployeeName");
            this.fld_txtHREmployeeName.Name = "fld_txtHREmployeeName";
            this.fld_txtHREmployeeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeName, ((bool)(resources.GetObject("fld_txtHREmployeeName.ShowHelp"))));
            this.fld_txtHREmployeeName.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            resources.ApplyResources(this.fld_grcGroupControl1, "fld_grcGroupControl1");
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = null;
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = null;
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = null;
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel22);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEWardID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeHREmployeeContactTypeCombo);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel25);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel27);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel28);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHREmployeeContactAddress);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHREmployeeContactPostalCode);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GECountryID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEStateProvinceID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEDistrictID);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl1, ((bool)(resources.GetObject("fld_grcGroupControl1.ShowHelp"))));
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
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
            // fld_lkeFK_GEWardID
            // 
            this.fld_lkeFK_GEWardID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEWardID.BOSAllowDummy = true;
            this.fld_lkeFK_GEWardID.BOSComment = null;
            this.fld_lkeFK_GEWardID.BOSDataMember = "FK_GEWardID";
            this.fld_lkeFK_GEWardID.BOSDataSource = "HREmployeeContacts";
            this.fld_lkeFK_GEWardID.BOSDescription = null;
            this.fld_lkeFK_GEWardID.BOSError = null;
            this.fld_lkeFK_GEWardID.BOSFieldGroup = null;
            this.fld_lkeFK_GEWardID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEWardID.BOSFieldRelation = null;
            this.fld_lkeFK_GEWardID.BOSPrivilege = null;
            this.fld_lkeFK_GEWardID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEWardID.BOSSelectType = null;
            this.fld_lkeFK_GEWardID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEWardID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GEWardID, "fld_lkeFK_GEWardID");
            this.fld_lkeFK_GEWardID.Name = "fld_lkeFK_GEWardID";
            this.fld_lkeFK_GEWardID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEWardID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEWardID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEWardID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEWardID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GEWardID.Properties.Buttons"))))});
            this.fld_lkeFK_GEWardID.Properties.ColumnName = null;
            this.fld_lkeFK_GEWardID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEWardID.Properties.Columns"), resources.GetString("fld_lkeFK_GEWardID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEWardID.Properties.Columns2"), resources.GetString("fld_lkeFK_GEWardID.Properties.Columns3"))});
            this.fld_lkeFK_GEWardID.Properties.DisplayMember = "GEWardName";
            this.fld_lkeFK_GEWardID.Properties.NullText = resources.GetString("fld_lkeFK_GEWardID.Properties.NullText");
            this.fld_lkeFK_GEWardID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEWardID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEWardID.Properties.ValueMember = "GEWardID";
            this.fld_lkeFK_GEWardID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEWardID, ((bool)(resources.GetObject("fld_lkeFK_GEWardID.ShowHelp"))));
            this.fld_lkeFK_GEWardID.Tag = "DC";
            this.fld_lkeFK_GEWardID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEWardID_EditValueChanged);
            this.fld_lkeFK_GEWardID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEWardID_EditValueChanging);
            // 
            // fld_lkeHREmployeeContactTypeCombo
            // 
            this.fld_lkeHREmployeeContactTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeContactTypeCombo.BOSAllowDummy = false;
            this.fld_lkeHREmployeeContactTypeCombo.BOSComment = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSDataMember = "HREmployeeContactTypeCombo";
            this.fld_lkeHREmployeeContactTypeCombo.BOSDataSource = "HREmployeeContacts";
            this.fld_lkeHREmployeeContactTypeCombo.BOSDescription = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSError = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSFieldGroup = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSFieldParent = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSFieldRelation = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSPrivilege = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeContactTypeCombo.BOSSelectType = null;
            this.fld_lkeHREmployeeContactTypeCombo.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeContactTypeCombo.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeHREmployeeContactTypeCombo, "fld_lkeHREmployeeContactTypeCombo");
            this.fld_lkeHREmployeeContactTypeCombo.Name = "fld_lkeHREmployeeContactTypeCombo";
            this.fld_lkeHREmployeeContactTypeCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeContactTypeCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeContactTypeCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeContactTypeCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeContactTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeHREmployeeContactTypeCombo.Properties.Buttons"))))});
            this.fld_lkeHREmployeeContactTypeCombo.Properties.ColumnName = null;
            this.fld_lkeHREmployeeContactTypeCombo.Properties.NullText = resources.GetString("fld_lkeHREmployeeContactTypeCombo.Properties.NullText");
            this.fld_lkeHREmployeeContactTypeCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeContactTypeCombo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeeContactTypeCombo, ((bool)(resources.GetObject("fld_lkeHREmployeeContactTypeCombo.ShowHelp"))));
            this.fld_lkeHREmployeeContactTypeCombo.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
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
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = null;
            this.fld_lblLabel23.BOSDataMember = null;
            this.fld_lblLabel23.BOSDataSource = null;
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = null;
            this.fld_lblLabel23.BOSFieldRelation = null;
            this.fld_lblLabel23.BOSPrivilege = null;
            this.fld_lblLabel23.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel23, "fld_lblLabel23");
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel23, ((bool)(resources.GetObject("fld_lblLabel23.ShowHelp"))));
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
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
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel25, "fld_lblLabel25");
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel25, ((bool)(resources.GetObject("fld_lblLabel25.ShowHelp"))));
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = null;
            this.fld_lblLabel27.BOSDataMember = null;
            this.fld_lblLabel27.BOSDataSource = null;
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = null;
            this.fld_lblLabel27.BOSFieldRelation = null;
            this.fld_lblLabel27.BOSPrivilege = null;
            this.fld_lblLabel27.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel27, "fld_lblLabel27");
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, ((bool)(resources.GetObject("fld_lblLabel27.ShowHelp"))));
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = null;
            this.fld_lblLabel28.BOSDataMember = null;
            this.fld_lblLabel28.BOSDataSource = null;
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = null;
            this.fld_lblLabel28.BOSFieldRelation = null;
            this.fld_lblLabel28.BOSPrivilege = null;
            this.fld_lblLabel28.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel28, "fld_lblLabel28");
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, ((bool)(resources.GetObject("fld_lblLabel28.ShowHelp"))));
            // 
            // fld_txtHREmployeeContactAddress
            // 
            this.fld_txtHREmployeeContactAddress.BOSComment = null;
            this.fld_txtHREmployeeContactAddress.BOSDataMember = "HREmployeeContactAddress";
            this.fld_txtHREmployeeContactAddress.BOSDataSource = "HREmployeeContacts";
            this.fld_txtHREmployeeContactAddress.BOSDescription = null;
            this.fld_txtHREmployeeContactAddress.BOSError = null;
            this.fld_txtHREmployeeContactAddress.BOSFieldGroup = null;
            this.fld_txtHREmployeeContactAddress.BOSFieldRelation = null;
            this.fld_txtHREmployeeContactAddress.BOSPrivilege = null;
            this.fld_txtHREmployeeContactAddress.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeContactAddress, "fld_txtHREmployeeContactAddress");
            this.fld_txtHREmployeeContactAddress.Name = "fld_txtHREmployeeContactAddress";
            this.fld_txtHREmployeeContactAddress.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactAddress.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactAddress.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactAddress.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactAddress.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeContactAddress, ((bool)(resources.GetObject("fld_txtHREmployeeContactAddress.ShowHelp"))));
            this.fld_txtHREmployeeContactAddress.Tag = "DC";
            // 
            // fld_txtHREmployeeContactPostalCode
            // 
            this.fld_txtHREmployeeContactPostalCode.BOSComment = null;
            this.fld_txtHREmployeeContactPostalCode.BOSDataMember = "HREmployeeContactPostalCode";
            this.fld_txtHREmployeeContactPostalCode.BOSDataSource = "HREmployeeContacts";
            this.fld_txtHREmployeeContactPostalCode.BOSDescription = null;
            this.fld_txtHREmployeeContactPostalCode.BOSError = null;
            this.fld_txtHREmployeeContactPostalCode.BOSFieldGroup = null;
            this.fld_txtHREmployeeContactPostalCode.BOSFieldRelation = null;
            this.fld_txtHREmployeeContactPostalCode.BOSPrivilege = null;
            this.fld_txtHREmployeeContactPostalCode.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeContactPostalCode, "fld_txtHREmployeeContactPostalCode");
            this.fld_txtHREmployeeContactPostalCode.Name = "fld_txtHREmployeeContactPostalCode";
            this.fld_txtHREmployeeContactPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContactPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContactPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContactPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContactPostalCode.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeContactPostalCode, ((bool)(resources.GetObject("fld_txtHREmployeeContactPostalCode.ShowHelp"))));
            this.fld_txtHREmployeeContactPostalCode.Tag = "DC";
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = true;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = true;
            this.fld_lkeFK_GECountryID.BOSComment = null;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "HREmployeeContacts";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = null;
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GECountryID, "fld_lkeFK_GECountryID");
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GECountryID.Properties.Buttons"))))});
            this.fld_lkeFK_GECountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECountryID.Properties.Columns"), resources.GetString("fld_lkeFK_GECountryID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECountryID.Properties.Columns2"), resources.GetString("fld_lkeFK_GECountryID.Properties.Columns3"))});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = resources.GetString("fld_lkeFK_GECountryID.Properties.NullText");
            this.fld_lkeFK_GECountryID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID, ((bool)(resources.GetObject("fld_lkeFK_GECountryID.ShowHelp"))));
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GECountryID_EditValueChanged);
            this.fld_lkeFK_GECountryID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GECountryID_EditValueChanging);
            // 
            // fld_lkeFK_GEStateProvinceID
            // 
            this.fld_lkeFK_GEStateProvinceID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEStateProvinceID.BOSAllowDummy = true;
            this.fld_lkeFK_GEStateProvinceID.BOSComment = null;
            this.fld_lkeFK_GEStateProvinceID.BOSDataMember = "FK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.BOSDataSource = "HREmployeeContacts";
            this.fld_lkeFK_GEStateProvinceID.BOSDescription = null;
            this.fld_lkeFK_GEStateProvinceID.BOSError = null;
            this.fld_lkeFK_GEStateProvinceID.BOSFieldGroup = null;
            this.fld_lkeFK_GEStateProvinceID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEStateProvinceID.BOSFieldRelation = null;
            this.fld_lkeFK_GEStateProvinceID.BOSPrivilege = null;
            this.fld_lkeFK_GEStateProvinceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEStateProvinceID.BOSSelectType = null;
            this.fld_lkeFK_GEStateProvinceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEStateProvinceID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GEStateProvinceID, "fld_lkeFK_GEStateProvinceID");
            this.fld_lkeFK_GEStateProvinceID.Name = "fld_lkeFK_GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEStateProvinceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GEStateProvinceID.Properties.Buttons"))))});
            this.fld_lkeFK_GEStateProvinceID.Properties.ColumnName = null;
            this.fld_lkeFK_GEStateProvinceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEStateProvinceID.Properties.Columns"), resources.GetString("fld_lkeFK_GEStateProvinceID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEStateProvinceID.Properties.Columns2"), resources.GetString("fld_lkeFK_GEStateProvinceID.Properties.Columns3"))});
            this.fld_lkeFK_GEStateProvinceID.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeFK_GEStateProvinceID.Properties.NullText = resources.GetString("fld_lkeFK_GEStateProvinceID.Properties.NullText");
            this.fld_lkeFK_GEStateProvinceID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEStateProvinceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEStateProvinceID.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeFK_GEStateProvinceID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEStateProvinceID, ((bool)(resources.GetObject("fld_lkeFK_GEStateProvinceID.ShowHelp"))));
            this.fld_lkeFK_GEStateProvinceID.Tag = "DC";
            this.fld_lkeFK_GEStateProvinceID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanged);
            this.fld_lkeFK_GEStateProvinceID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEStateProvinceID_EditValueChanging);
            // 
            // fld_lkeFK_GEDistrictID
            // 
            this.fld_lkeFK_GEDistrictID.BOSAllowAddNew = true;
            this.fld_lkeFK_GEDistrictID.BOSAllowDummy = true;
            this.fld_lkeFK_GEDistrictID.BOSComment = null;
            this.fld_lkeFK_GEDistrictID.BOSDataMember = "FK_GEDistrictID";
            this.fld_lkeFK_GEDistrictID.BOSDataSource = "HREmployeeContacts";
            this.fld_lkeFK_GEDistrictID.BOSDescription = null;
            this.fld_lkeFK_GEDistrictID.BOSError = null;
            this.fld_lkeFK_GEDistrictID.BOSFieldGroup = null;
            this.fld_lkeFK_GEDistrictID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GEDistrictID.BOSFieldRelation = null;
            this.fld_lkeFK_GEDistrictID.BOSPrivilege = null;
            this.fld_lkeFK_GEDistrictID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEDistrictID.BOSSelectType = null;
            this.fld_lkeFK_GEDistrictID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEDistrictID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GEDistrictID, "fld_lkeFK_GEDistrictID");
            this.fld_lkeFK_GEDistrictID.Name = "fld_lkeFK_GEDistrictID";
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEDistrictID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEDistrictID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GEDistrictID.Properties.Buttons"))))});
            this.fld_lkeFK_GEDistrictID.Properties.ColumnName = null;
            this.fld_lkeFK_GEDistrictID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEDistrictID.Properties.Columns"), resources.GetString("fld_lkeFK_GEDistrictID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GEDistrictID.Properties.Columns2"), resources.GetString("fld_lkeFK_GEDistrictID.Properties.Columns3"))});
            this.fld_lkeFK_GEDistrictID.Properties.DisplayMember = "GEDistrictName";
            this.fld_lkeFK_GEDistrictID.Properties.NullText = resources.GetString("fld_lkeFK_GEDistrictID.Properties.NullText");
            this.fld_lkeFK_GEDistrictID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEDistrictID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEDistrictID.Properties.ValueMember = "GEDistrictID";
            this.fld_lkeFK_GEDistrictID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEDistrictID, ((bool)(resources.GetObject("fld_lkeFK_GEDistrictID.ShowHelp"))));
            this.fld_lkeFK_GEDistrictID.Tag = "DC";
            this.fld_lkeFK_GEDistrictID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_GEDistrictID_EditValueChanged);
            this.fld_lkeFK_GEDistrictID.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_lkeFK_GEDistrictID_EditValueChanging);
            // 
            // fld_grcGroupControl2
            // 
            resources.ApplyResources(this.fld_grcGroupControl2, "fld_grcGroupControl2");
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = null;
            this.fld_grcGroupControl2.BOSDataMember = null;
            this.fld_grcGroupControl2.BOSDataSource = null;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = null;
            this.fld_grcGroupControl2.BOSFieldRelation = null;
            this.fld_grcGroupControl2.BOSPrivilege = null;
            this.fld_grcGroupControl2.BOSPropertyName = null;
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel29);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel30);
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel32);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtHREmployeeBankAccount1);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtHREmployeeBankName);
            this.fld_grcGroupControl2.Controls.Add(this.fld_txtHREmployeeTaxNumber);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl2, ((bool)(resources.GetObject("fld_grcGroupControl2.ShowHelp"))));
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = null;
            this.fld_lblLabel29.BOSDataMember = null;
            this.fld_lblLabel29.BOSDataSource = null;
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = null;
            this.fld_lblLabel29.BOSFieldRelation = null;
            this.fld_lblLabel29.BOSPrivilege = null;
            this.fld_lblLabel29.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel29, "fld_lblLabel29");
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel29, ((bool)(resources.GetObject("fld_lblLabel29.ShowHelp"))));
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = null;
            this.fld_lblLabel30.BOSDataMember = null;
            this.fld_lblLabel30.BOSDataSource = null;
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = null;
            this.fld_lblLabel30.BOSFieldRelation = null;
            this.fld_lblLabel30.BOSPrivilege = null;
            this.fld_lblLabel30.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel30, "fld_lblLabel30");
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel30, ((bool)(resources.GetObject("fld_lblLabel30.ShowHelp"))));
            // 
            // fld_lblLabel32
            // 
            this.fld_lblLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel32.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel32.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel32.BOSComment = null;
            this.fld_lblLabel32.BOSDataMember = null;
            this.fld_lblLabel32.BOSDataSource = null;
            this.fld_lblLabel32.BOSDescription = null;
            this.fld_lblLabel32.BOSError = null;
            this.fld_lblLabel32.BOSFieldGroup = null;
            this.fld_lblLabel32.BOSFieldRelation = null;
            this.fld_lblLabel32.BOSPrivilege = null;
            this.fld_lblLabel32.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel32, "fld_lblLabel32");
            this.fld_lblLabel32.Name = "fld_lblLabel32";
            this.fld_lblLabel32.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel32, ((bool)(resources.GetObject("fld_lblLabel32.ShowHelp"))));
            // 
            // fld_txtHREmployeeBankAccount1
            // 
            this.fld_txtHREmployeeBankAccount1.BOSComment = null;
            this.fld_txtHREmployeeBankAccount1.BOSDataMember = "HREmployeeBankAccount1";
            this.fld_txtHREmployeeBankAccount1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeBankAccount1.BOSDescription = null;
            this.fld_txtHREmployeeBankAccount1.BOSError = null;
            this.fld_txtHREmployeeBankAccount1.BOSFieldGroup = null;
            this.fld_txtHREmployeeBankAccount1.BOSFieldRelation = null;
            this.fld_txtHREmployeeBankAccount1.BOSPrivilege = null;
            this.fld_txtHREmployeeBankAccount1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeBankAccount1, "fld_txtHREmployeeBankAccount1");
            this.fld_txtHREmployeeBankAccount1.Name = "fld_txtHREmployeeBankAccount1";
            this.fld_txtHREmployeeBankAccount1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeBankAccount1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeBankAccount1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeBankAccount1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeBankAccount1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeBankAccount1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeBankAccount1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeBankAccount1, ((bool)(resources.GetObject("fld_txtHREmployeeBankAccount1.ShowHelp"))));
            this.fld_txtHREmployeeBankAccount1.Tag = "DC";
            // 
            // fld_txtHREmployeeBankName
            // 
            this.fld_txtHREmployeeBankName.BOSComment = null;
            this.fld_txtHREmployeeBankName.BOSDataMember = "HREmployeeBankName";
            this.fld_txtHREmployeeBankName.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeBankName.BOSDescription = null;
            this.fld_txtHREmployeeBankName.BOSError = null;
            this.fld_txtHREmployeeBankName.BOSFieldGroup = null;
            this.fld_txtHREmployeeBankName.BOSFieldRelation = null;
            this.fld_txtHREmployeeBankName.BOSPrivilege = null;
            this.fld_txtHREmployeeBankName.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeBankName, "fld_txtHREmployeeBankName");
            this.fld_txtHREmployeeBankName.Name = "fld_txtHREmployeeBankName";
            this.fld_txtHREmployeeBankName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeBankName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeBankName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeBankName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeBankName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeBankName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeBankName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeBankName, ((bool)(resources.GetObject("fld_txtHREmployeeBankName.ShowHelp"))));
            this.fld_txtHREmployeeBankName.Tag = "DC";
            // 
            // fld_txtHREmployeeTaxNumber
            // 
            this.fld_txtHREmployeeTaxNumber.BOSComment = null;
            this.fld_txtHREmployeeTaxNumber.BOSDataMember = "HREmployeeTaxNumber";
            this.fld_txtHREmployeeTaxNumber.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeTaxNumber.BOSDescription = null;
            this.fld_txtHREmployeeTaxNumber.BOSError = null;
            this.fld_txtHREmployeeTaxNumber.BOSFieldGroup = null;
            this.fld_txtHREmployeeTaxNumber.BOSFieldRelation = null;
            this.fld_txtHREmployeeTaxNumber.BOSPrivilege = null;
            this.fld_txtHREmployeeTaxNumber.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtHREmployeeTaxNumber, "fld_txtHREmployeeTaxNumber");
            this.fld_txtHREmployeeTaxNumber.Name = "fld_txtHREmployeeTaxNumber";
            this.fld_txtHREmployeeTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtHREmployeeTaxNumber.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtHREmployeeTaxNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeeTaxNumber, ((bool)(resources.GetObject("fld_txtHREmployeeTaxNumber.ShowHelp"))));
            this.fld_txtHREmployeeTaxNumber.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_btnAddContact);
            this.bosPanel1.Controls.Add(this.fld_btnDeleteContact);
            this.bosPanel1.Controls.Add(this.fld_btnEditContact);
            this.bosPanel1.Controls.Add(this.fld_dgcHREmployeeContacts);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // fld_btnAddContact
            // 
            resources.ApplyResources(this.fld_btnAddContact, "fld_btnAddContact");
            this.fld_btnAddContact.BOSComment = null;
            this.fld_btnAddContact.BOSDataMember = null;
            this.fld_btnAddContact.BOSDataSource = null;
            this.fld_btnAddContact.BOSDescription = null;
            this.fld_btnAddContact.BOSError = null;
            this.fld_btnAddContact.BOSFieldGroup = null;
            this.fld_btnAddContact.BOSFieldRelation = null;
            this.fld_btnAddContact.BOSPrivilege = null;
            this.fld_btnAddContact.BOSPropertyName = null;
            this.fld_btnAddContact.Name = "fld_btnAddContact";
            this.fld_btnAddContact.Screen = null;
            this.fld_btnAddContact.Click += new System.EventHandler(this.fld_btnAddContact_Click);
            // 
            // fld_btnDeleteContact
            // 
            resources.ApplyResources(this.fld_btnDeleteContact, "fld_btnDeleteContact");
            this.fld_btnDeleteContact.BOSComment = null;
            this.fld_btnDeleteContact.BOSDataMember = null;
            this.fld_btnDeleteContact.BOSDataSource = null;
            this.fld_btnDeleteContact.BOSDescription = null;
            this.fld_btnDeleteContact.BOSError = null;
            this.fld_btnDeleteContact.BOSFieldGroup = null;
            this.fld_btnDeleteContact.BOSFieldRelation = null;
            this.fld_btnDeleteContact.BOSPrivilege = null;
            this.fld_btnDeleteContact.BOSPropertyName = null;
            this.fld_btnDeleteContact.Name = "fld_btnDeleteContact";
            this.fld_btnDeleteContact.Screen = null;
            this.fld_btnDeleteContact.Click += new System.EventHandler(this.fld_btnDeleteContact_Click);
            // 
            // fld_btnEditContact
            // 
            resources.ApplyResources(this.fld_btnEditContact, "fld_btnEditContact");
            this.fld_btnEditContact.BOSComment = null;
            this.fld_btnEditContact.BOSDataMember = null;
            this.fld_btnEditContact.BOSDataSource = null;
            this.fld_btnEditContact.BOSDescription = null;
            this.fld_btnEditContact.BOSError = null;
            this.fld_btnEditContact.BOSFieldGroup = null;
            this.fld_btnEditContact.BOSFieldRelation = null;
            this.fld_btnEditContact.BOSPrivilege = null;
            this.fld_btnEditContact.BOSPropertyName = null;
            this.fld_btnEditContact.Name = "fld_btnEditContact";
            this.fld_btnEditContact.Screen = null;
            this.fld_btnEditContact.Click += new System.EventHandler(this.fld_btnEditContact_Click);
            // 
            // fld_dgcHREmployeeContacts
            // 
            resources.ApplyResources(this.fld_dgcHREmployeeContacts, "fld_dgcHREmployeeContacts");
            this.fld_dgcHREmployeeContacts.BOSComment = null;
            this.fld_dgcHREmployeeContacts.BOSDataMember = null;
            this.fld_dgcHREmployeeContacts.BOSDataSource = "HREmployeeContacts";
            this.fld_dgcHREmployeeContacts.BOSDescription = null;
            this.fld_dgcHREmployeeContacts.BOSError = null;
            this.fld_dgcHREmployeeContacts.BOSFieldGroup = null;
            this.fld_dgcHREmployeeContacts.BOSFieldRelation = null;
            this.fld_dgcHREmployeeContacts.BOSGridType = null;
            this.fld_dgcHREmployeeContacts.BOSPrivilege = null;
            this.fld_dgcHREmployeeContacts.BOSPropertyName = null;
            this.fld_dgcHREmployeeContacts.CommodityType = "";
            this.fld_dgcHREmployeeContacts.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeContacts.Name = "fld_dgcHREmployeeContacts";
            this.fld_dgcHREmployeeContacts.PrintReport = false;
            this.fld_dgcHREmployeeContacts.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployeeContacts, ((bool)(resources.GetObject("fld_dgcHREmployeeContacts.ShowHelp"))));
            // 
            // DMST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMST100.IconOptions.Icon")));
            this.Name = "DMST100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeIsAllowedLeave.Properties)).EndInit();
            this.fld_gbPauseStatus.ResumeLayout(false);
            this.fld_gbPauseStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeEndPauseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeEndPauseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartPauseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartPauseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetParamID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupTeamItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeApprenticeDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeApprenticeDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeDobYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAnnualLeaveRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStopWorkingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStopWorkingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkdFK_GEStateProvinceBirthPlaceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentroomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeIsUnionMember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeMaritalStatusCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeDob.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeDob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeIDCardDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeIDCardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeMonthWorking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEIDCardStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEReligionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GENationalityID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GENativeStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRLevelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatusCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeEmail1.Properties)).EndInit();
            this.fld_Line.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbHREmployeePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePictureFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeDobString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartWorkingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeStartWorkingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGenderCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEWardID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeContactTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContactPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEStateProvinceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEDistrictID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            this.fld_grcGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBankAccount1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTaxNumber.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLevel;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRLevelID;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTel2;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTel1;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtHREmployeeIDNumber;
        private BOSComponent.BOSTextBox fld_txtHREmployeeCardNumber;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHREmployeeMonthWorking;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeIDCardDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSERP.Modules.SellStaff.HREmployeeContactsGridControl fld_dgcHREmployeeContacts;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSButton fld_btnAddContact;
        private BOSComponent.BOSButton fld_btnDeleteContact;
        private BOSComponent.BOSButton fld_btnEditContact;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeMaritalStatusCombo;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeContactTypeCombo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GENativeStateProvinceID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEIDCardStateProvinceID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEDistrictID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEStateProvinceID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEReligionID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GENationalityID;
        private BOSComponent.BOSCheckEdit fld_ceHREmployeeIsUnionMember;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID1;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeStopWorkingDate;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeTypeCombo;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtHREmployeeAnnualLeaveRemain;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtHREmployeeDobString;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeDob;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentroomID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtHREmployeeDobYear;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeApprenticeDay;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkdFK_GEStateProvinceBirthPlaceID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupTeamItemID;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEWardID;
        private GroupBox fld_gbPauseStatus;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeEndPauseDate;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeStartPauseDate;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRTimeSheetParamID;
        private BOSComponent.BOSCheckEdit fld_ceHREmployeeIsAllowedLeave;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSTextBox fld_txtHREmployeePictureFileName;
        private PictureBox fld_ptbHREmployeePicture;
        private PictureBox pictureBox1;
    }
}
