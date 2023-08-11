using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SellStaff.UI
{
	/// <summary>
	/// Summary description for DMMEEM101
	/// </summary>
	partial class DMSS100
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHREmployeeAllowanceHouse = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeExtraSalary1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeAllowancePhone = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeAllowanceGas = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHREmployeeUnionMemberFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeSyndicatePaymentAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeSyndicatePaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeTaxPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel56 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeSocialInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPercent = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRInsCalculatedSalaryType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHREmployeeHealthInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeProbationarySalaryAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeSkillCoefficient = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRConfigRankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRConfigScaleID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeePayRollCalculatedWorkType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRAllowanceManageConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel60 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRWorkingShiftID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRPayRollCalculatedSalaryType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeSalarySocialInsurance = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeBonusSale = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeJobPerformanceAmt = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePercentContractSlrAmt = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeContractSlrAmt = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeProbationaryMonth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeWorkingSlrAmt = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeSalaryFactor = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeePayrollFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRTimeSheetScaleID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_ceHREmployeeHaveOutOfWorkIns = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeOutOfWorkIns = new BOSComponent.BOSTextBox(this.components);
            this.fld_ceHREmployeeHaveInsurrance = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeHealthInsNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel40 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeHealthInsRegisteredPlace = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeHealthInsExpiryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREmployeeHealthInsRegisteredDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHREmployeeSocialInsNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeSocialInsRegisteredDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel49 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel50 = new BOSComponent.BOSLabel(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowanceHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeExtraSalary1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowancePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowanceGas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeUnionMemberFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSyndicatePaymentAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSyndicatePaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTaxPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSocialInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRInsCalculatedSalaryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeProbationarySalaryAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSkillCoefficient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigRankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigScaleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRAllowanceManageConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRWorkingShiftID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollCalculatedSalaryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSalarySocialInsurance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBonusSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeJobPerformanceAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePercentContractSlrAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractSlrAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeProbationaryMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkingSlrAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSalaryFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetScaleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).BeginInit();
            this.fld_grcGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveOutOfWorkIns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeOutOfWorkIns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveInsurrance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsExpiryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsExpiryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsRegisteredDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSocialInsNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeSocialInsRegisteredDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Controls.Add(this.fld_grcGroupControl5);
            this.panel1.Controls.Add(this.fld_grcGroupControl3);
            this.panel1.Controls.Add(this.fld_grcGroupControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 735);
            this.panel1.TabIndex = 6;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeAllowanceHouse);
            this.bosGroupControl1.Controls.Add(this.bosLabel23);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeExtraSalary1);
            this.bosGroupControl1.Controls.Add(this.bosLabel21);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeAllowancePhone);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_txtHREmployeeAllowanceGas);
            this.bosGroupControl1.Controls.Add(this.bosLabel25);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 195);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(926, 81);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Text = "Phụ cấp cố định";
            // 
            // fld_txtHREmployeeAllowanceHouse
            // 
            this.fld_txtHREmployeeAllowanceHouse.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceHouse.BOSDataMember = "HREmployeeAllowanceHouse";
            this.fld_txtHREmployeeAllowanceHouse.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeAllowanceHouse.BOSDescription = null;
            this.fld_txtHREmployeeAllowanceHouse.BOSError = null;
            this.fld_txtHREmployeeAllowanceHouse.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceHouse.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceHouse.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceHouse.BOSPropertyName = "Text";
            this.fld_txtHREmployeeAllowanceHouse.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceHouse.Location = new System.Drawing.Point(468, 51);
            this.fld_txtHREmployeeAllowanceHouse.Name = "fld_txtHREmployeeAllowanceHouse";
            this.fld_txtHREmployeeAllowanceHouse.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeAllowanceHouse.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeAllowanceHouse.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeAllowanceHouse.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeAllowanceHouse.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeAllowanceHouse.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeAllowanceHouse.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeAllowanceHouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeAllowanceHouse.Screen = null;
            this.fld_txtHREmployeeAllowanceHouse.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeAllowanceHouse.TabIndex = 3;
            this.fld_txtHREmployeeAllowanceHouse.Tag = "DC";
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
            this.bosLabel23.Location = new System.Drawing.Point(346, 54);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(75, 13);
            this.bosLabel23.TabIndex = 62;
            this.bosLabel23.Text = "Hỗ trợ nhà ở VP";
            // 
            // fld_txtHREmployeeExtraSalary1
            // 
            this.fld_txtHREmployeeExtraSalary1.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeExtraSalary1.BOSDataMember = "HREmployeeExtraSalary1";
            this.fld_txtHREmployeeExtraSalary1.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeExtraSalary1.BOSDescription = null;
            this.fld_txtHREmployeeExtraSalary1.BOSError = null;
            this.fld_txtHREmployeeExtraSalary1.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeExtraSalary1.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeExtraSalary1.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeExtraSalary1.BOSPropertyName = "Text";
            this.fld_txtHREmployeeExtraSalary1.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeExtraSalary1.Location = new System.Drawing.Point(148, 51);
            this.fld_txtHREmployeeExtraSalary1.Name = "fld_txtHREmployeeExtraSalary1";
            this.fld_txtHREmployeeExtraSalary1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeExtraSalary1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeExtraSalary1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeExtraSalary1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeExtraSalary1.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeExtraSalary1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeExtraSalary1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeExtraSalary1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeExtraSalary1.Screen = null;
            this.fld_txtHREmployeeExtraSalary1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeExtraSalary1.TabIndex = 2;
            this.fld_txtHREmployeeExtraSalary1.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel21.Location = new System.Drawing.Point(16, 54);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(114, 13);
            this.bosLabel21.TabIndex = 60;
            this.bosLabel21.Text = "Phụ cấp CĐ hàng tháng";
            // 
            // fld_txtHREmployeeAllowancePhone
            // 
            this.fld_txtHREmployeeAllowancePhone.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowancePhone.BOSDataMember = "HREmployeeAllowancePhone";
            this.fld_txtHREmployeeAllowancePhone.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeAllowancePhone.BOSDescription = null;
            this.fld_txtHREmployeeAllowancePhone.BOSError = null;
            this.fld_txtHREmployeeAllowancePhone.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowancePhone.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowancePhone.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowancePhone.BOSPropertyName = "Text";
            this.fld_txtHREmployeeAllowancePhone.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowancePhone.Location = new System.Drawing.Point(148, 25);
            this.fld_txtHREmployeeAllowancePhone.Name = "fld_txtHREmployeeAllowancePhone";
            this.fld_txtHREmployeeAllowancePhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeAllowancePhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeAllowancePhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeAllowancePhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeAllowancePhone.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeAllowancePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeAllowancePhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeAllowancePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeAllowancePhone.Screen = null;
            this.fld_txtHREmployeeAllowancePhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeAllowancePhone.TabIndex = 0;
            this.fld_txtHREmployeeAllowancePhone.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.Location = new System.Drawing.Point(16, 28);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(101, 13);
            this.bosLabel16.TabIndex = 26;
            this.bosLabel16.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel16.Text = "Hỗ trợ tiền điện thoại";
            // 
            // fld_txtHREmployeeAllowanceGas
            // 
            this.fld_txtHREmployeeAllowanceGas.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceGas.BOSDataMember = "HREmployeeAllowanceGas";
            this.fld_txtHREmployeeAllowanceGas.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeAllowanceGas.BOSDescription = null;
            this.fld_txtHREmployeeAllowanceGas.BOSError = null;
            this.fld_txtHREmployeeAllowanceGas.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceGas.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceGas.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceGas.BOSPropertyName = "Text";
            this.fld_txtHREmployeeAllowanceGas.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeAllowanceGas.Location = new System.Drawing.Point(468, 25);
            this.fld_txtHREmployeeAllowanceGas.Name = "fld_txtHREmployeeAllowanceGas";
            this.fld_txtHREmployeeAllowanceGas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeAllowanceGas.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeAllowanceGas.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeAllowanceGas.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeAllowanceGas.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeAllowanceGas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeAllowanceGas.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeAllowanceGas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeAllowanceGas.Screen = null;
            this.fld_txtHREmployeeAllowanceGas.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeAllowanceGas.TabIndex = 1;
            this.fld_txtHREmployeeAllowanceGas.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.Location = new System.Drawing.Point(346, 28);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(72, 13);
            this.bosLabel25.TabIndex = 24;
            this.bosLabel25.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel25.Text = "Hỗ trợ xăng xe";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.BOSComment = null;
            this.fld_grcGroupControl5.BOSDataMember = null;
            this.fld_grcGroupControl5.BOSDataSource = null;
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = null;
            this.fld_grcGroupControl5.BOSFieldRelation = null;
            this.fld_grcGroupControl5.BOSPrivilege = null;
            this.fld_grcGroupControl5.BOSPropertyName = null;
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeUnionMemberFee);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeSyndicatePaymentAmount);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel45);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeSyndicatePaymentPercent);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeTaxPaymentPercent);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel46);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel56);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeSocialInsPaymentPercent);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel43);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblPercent);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel14);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel51);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeHRInsCalculatedSalaryType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeHealthInsPaymentPercent);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHREmployeeOutOfWorkInsPaymentPercent);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 559);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(926, 140);
            this.fld_grcGroupControl5.TabIndex = 3;
            this.fld_grcGroupControl5.Text = "Các khoản khấu trừ lương";
            // 
            // fld_txtHREmployeeUnionMemberFee
            // 
            this.fld_txtHREmployeeUnionMemberFee.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeUnionMemberFee.BOSDataMember = "HREmployeeUnionMemberFee";
            this.fld_txtHREmployeeUnionMemberFee.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeUnionMemberFee.BOSDescription = null;
            this.fld_txtHREmployeeUnionMemberFee.BOSError = null;
            this.fld_txtHREmployeeUnionMemberFee.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeUnionMemberFee.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeUnionMemberFee.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeUnionMemberFee.BOSPropertyName = "Text";
            this.fld_txtHREmployeeUnionMemberFee.EditValue = "0.00";
            this.fld_txtHREmployeeUnionMemberFee.Location = new System.Drawing.Point(443, 110);
            this.fld_txtHREmployeeUnionMemberFee.Name = "fld_txtHREmployeeUnionMemberFee";
            this.fld_txtHREmployeeUnionMemberFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeUnionMemberFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeUnionMemberFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeUnionMemberFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeUnionMemberFee.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeUnionMemberFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeUnionMemberFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeUnionMemberFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeUnionMemberFee.Screen = null;
            this.fld_txtHREmployeeUnionMemberFee.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeUnionMemberFee.TabIndex = 7;
            this.fld_txtHREmployeeUnionMemberFee.Tag = "DC";
            this.fld_txtHREmployeeUnionMemberFee.Visible = false;
            // 
            // fld_txtHREmployeeSyndicatePaymentAmount
            // 
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSDataMember = "HREmployeeSyndicatePaymentAmount";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSDescription = null;
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSError = null;
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSyndicatePaymentAmount.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSyndicatePaymentAmount.EditValue = "0";
            this.fld_txtHREmployeeSyndicatePaymentAmount.Location = new System.Drawing.Point(485, 83);
            this.fld_txtHREmployeeSyndicatePaymentAmount.Name = "fld_txtHREmployeeSyndicatePaymentAmount";
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSyndicatePaymentAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Screen = null;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Size = new System.Drawing.Size(83, 20);
            this.fld_txtHREmployeeSyndicatePaymentAmount.TabIndex = 5;
            this.fld_txtHREmployeeSyndicatePaymentAmount.Tag = "DC";
            // 
            // fld_lblLabel45
            // 
            this.fld_lblLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel45.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel45.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSDescription = null;
            this.fld_lblLabel45.BOSError = null;
            this.fld_lblLabel45.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.Location = new System.Drawing.Point(11, 35);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel45.TabIndex = 26;
            this.fld_lblLabel45.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel45.Text = "Dựa vào lương";
            // 
            // fld_txtHREmployeeSyndicatePaymentPercent
            // 
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSComment = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSDataMember = "HREmployeeSyndicatePaymentPercent";
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSDescription = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSError = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSFieldGroup = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSFieldRelation = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSPrivilege = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSyndicatePaymentPercent.Location = new System.Drawing.Point(443, 83);
            this.fld_txtHREmployeeSyndicatePaymentPercent.Name = "fld_txtHREmployeeSyndicatePaymentPercent";
            this.fld_txtHREmployeeSyndicatePaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeSyndicatePaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSyndicatePaymentPercent.Screen = null;
            this.fld_txtHREmployeeSyndicatePaymentPercent.Size = new System.Drawing.Size(22, 20);
            this.fld_txtHREmployeeSyndicatePaymentPercent.TabIndex = 4;
            this.fld_txtHREmployeeSyndicatePaymentPercent.Tag = "DC";
            // 
            // fld_txtHREmployeeTaxPaymentPercent
            // 
            this.fld_txtHREmployeeTaxPaymentPercent.BOSComment = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSDataMember = "HREmployeeTaxPaymentPercent";
            this.fld_txtHREmployeeTaxPaymentPercent.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeTaxPaymentPercent.BOSDescription = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSError = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSFieldGroup = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSFieldRelation = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSPrivilege = null;
            this.fld_txtHREmployeeTaxPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHREmployeeTaxPaymentPercent.Location = new System.Drawing.Point(443, 57);
            this.fld_txtHREmployeeTaxPaymentPercent.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeeTaxPaymentPercent.Name = "fld_txtHREmployeeTaxPaymentPercent";
            this.fld_txtHREmployeeTaxPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeTaxPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeTaxPaymentPercent.Screen = null;
            this.fld_txtHREmployeeTaxPaymentPercent.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeTaxPaymentPercent.TabIndex = 2;
            this.fld_txtHREmployeeTaxPaymentPercent.Tag = "DC";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(11, 86);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel46.TabIndex = 45;
            this.fld_lblLabel46.Text = "BHYT (%)";
            // 
            // fld_lblLabel56
            // 
            this.fld_lblLabel56.BOSComment = null;
            this.fld_lblLabel56.BOSDataMember = null;
            this.fld_lblLabel56.BOSDataSource = null;
            this.fld_lblLabel56.BOSDescription = null;
            this.fld_lblLabel56.BOSError = null;
            this.fld_lblLabel56.BOSFieldGroup = null;
            this.fld_lblLabel56.BOSFieldRelation = null;
            this.fld_lblLabel56.BOSPrivilege = null;
            this.fld_lblLabel56.BOSPropertyName = null;
            this.fld_lblLabel56.Location = new System.Drawing.Point(11, 113);
            this.fld_lblLabel56.Name = "fld_lblLabel56";
            this.fld_lblLabel56.Screen = null;
            this.fld_lblLabel56.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel56.TabIndex = 45;
            this.fld_lblLabel56.Text = "BHTN (%)";
            // 
            // fld_txtHREmployeeSocialInsPaymentPercent
            // 
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSDataMember = "HREmployeeSocialInsPaymentPercent";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSDescription = null;
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSError = null;
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSocialInsPaymentPercent.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsPaymentPercent.Location = new System.Drawing.Point(117, 57);
            this.fld_txtHREmployeeSocialInsPaymentPercent.Name = "fld_txtHREmployeeSocialInsPaymentPercent";
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSocialInsPaymentPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Screen = null;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeSocialInsPaymentPercent.TabIndex = 1;
            this.fld_txtHREmployeeSocialInsPaymentPercent.Tag = "DC";
            // 
            // fld_lblLabel43
            // 
            this.fld_lblLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel43.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel43.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel43.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSDescription = null;
            this.fld_lblLabel43.BOSError = null;
            this.fld_lblLabel43.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.Location = new System.Drawing.Point(11, 60);
            this.fld_lblLabel43.Name = "fld_lblLabel43";
            this.fld_lblLabel43.Screen = null;
            this.fld_lblLabel43.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel43.TabIndex = 24;
            this.fld_lblLabel43.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel43.Text = "BHXH (%)";
            // 
            // fld_lblPercent
            // 
            this.fld_lblPercent.BOSComment = null;
            this.fld_lblPercent.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblPercent.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblPercent.BOSDescription = null;
            this.fld_lblPercent.BOSError = null;
            this.fld_lblPercent.BOSFieldGroup = null;
            this.fld_lblPercent.BOSFieldRelation = null;
            this.fld_lblPercent.BOSPrivilege = null;
            this.fld_lblPercent.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblPercent.Location = new System.Drawing.Point(468, 86);
            this.fld_lblPercent.Name = "fld_lblPercent";
            this.fld_lblPercent.Screen = null;
            this.fld_lblPercent.Size = new System.Drawing.Size(11, 13);
            this.fld_lblPercent.TabIndex = 49;
            this.fld_lblPercent.Tag = "DC";
            this.fld_lblPercent.Text = "%";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.Location = new System.Drawing.Point(355, 113);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(64, 13);
            this.bosLabel4.TabIndex = 49;
            this.bosLabel4.Tag = "DC";
            this.bosLabel4.Text = "Phí đoàn viên";
            this.bosLabel4.Visible = false;
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel14.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel14.Location = new System.Drawing.Point(354, 86);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(67, 13);
            this.bosLabel14.TabIndex = 49;
            this.bosLabel14.Tag = "DC";
            this.bosLabel14.Text = "Phí công đoàn";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.BOSComment = null;
            this.fld_lblLabel51.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel51.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = null;
            this.fld_lblLabel51.BOSFieldRelation = null;
            this.fld_lblLabel51.BOSPrivilege = null;
            this.fld_lblLabel51.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel51.Location = new System.Drawing.Point(376, 60);
            this.fld_lblLabel51.Name = "fld_lblLabel51";
            this.fld_lblLabel51.Screen = null;
            this.fld_lblLabel51.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel51.TabIndex = 49;
            this.fld_lblLabel51.Tag = "DC";
            this.fld_lblLabel51.Text = "Thuế (%)";
            // 
            // fld_lkeHRInsCalculatedSalaryType
            // 
            this.fld_lkeHRInsCalculatedSalaryType.BOSAllowAddNew = false;
            this.fld_lkeHRInsCalculatedSalaryType.BOSAllowDummy = false;
            this.fld_lkeHRInsCalculatedSalaryType.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSDataMember = "HRInsCalculatedSalaryType";
            this.fld_lkeHRInsCalculatedSalaryType.BOSDataSource = "HREmployees";
            this.fld_lkeHRInsCalculatedSalaryType.BOSDescription = null;
            this.fld_lkeHRInsCalculatedSalaryType.BOSError = null;
            this.fld_lkeHRInsCalculatedSalaryType.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSPropertyName = "EditValue";
            this.fld_lkeHRInsCalculatedSalaryType.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.CurrentDisplayText = null;
            this.fld_lkeHRInsCalculatedSalaryType.Location = new System.Drawing.Point(117, 32);
            this.fld_lkeHRInsCalculatedSalaryType.Name = "fld_lkeHRInsCalculatedSalaryType";
            this.fld_lkeHRInsCalculatedSalaryType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRInsCalculatedSalaryType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRInsCalculatedSalaryType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRInsCalculatedSalaryType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRInsCalculatedSalaryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRInsCalculatedSalaryType.Properties.ColumnName = null;
            this.fld_lkeHRInsCalculatedSalaryType.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRInsCalculatedSalaryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRInsCalculatedSalaryType.Screen = null;
            this.fld_lkeHRInsCalculatedSalaryType.Size = new System.Drawing.Size(451, 20);
            this.fld_lkeHRInsCalculatedSalaryType.TabIndex = 0;
            this.fld_lkeHRInsCalculatedSalaryType.Tag = "DC";
            // 
            // fld_txtHREmployeeHealthInsPaymentPercent
            // 
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSComment = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSDataMember = "HREmployeeHealthInsPaymentPercent";
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSDescription = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSError = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSFieldGroup = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSFieldRelation = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSPrivilege = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHREmployeeHealthInsPaymentPercent.Location = new System.Drawing.Point(117, 83);
            this.fld_txtHREmployeeHealthInsPaymentPercent.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeeHealthInsPaymentPercent.Name = "fld_txtHREmployeeHealthInsPaymentPercent";
            this.fld_txtHREmployeeHealthInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeHealthInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeHealthInsPaymentPercent.Screen = null;
            this.fld_txtHREmployeeHealthInsPaymentPercent.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeHealthInsPaymentPercent.TabIndex = 3;
            this.fld_txtHREmployeeHealthInsPaymentPercent.Tag = "DC";
            // 
            // fld_txtHREmployeeOutOfWorkInsPaymentPercent
            // 
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSComment = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSDataMember = "HREmployeeOutOfWorkInsPaymentPercent";
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSDescription = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSError = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSFieldGroup = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSFieldRelation = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSPrivilege = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Location = new System.Drawing.Point(117, 110);
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.MenuManager = this.screenToolbar;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Name = "fld_txtHREmployeeOutOfWorkInsPaymentPercent";
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Screen = null;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.TabIndex = 6;
            this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Tag = "DC";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeProbationarySalaryAmount);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeSkillCoefficient);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HRConfigRankID);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HRConfigScaleID);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeHREmployeePayRollCalculatedWorkType);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HRAllowanceManageConfigID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel60);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HRWorkingShiftID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeHRPayRollCalculatedSalaryType);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel61);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeSalarySocialInsurance);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeBonusSale);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeJobPerformanceAmt);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeePercentContractSlrAmt);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeContractSlrAmt);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeProbationaryMonth);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeWorkingSlrAmt);
            this.fld_grcGroupControl3.Controls.Add(this.fld_txtHREmployeeSalaryFactor);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_HRTimeSheetScaleID);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel17);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel19);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel20);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel22);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl3.Controls.Add(this.bosLabel15);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(926, 190);
            this.fld_grcGroupControl3.TabIndex = 0;
            this.fld_grcGroupControl3.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl3.Text = "Chấm công && lương";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.Location = new System.Drawing.Point(657, 107);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(73, 13);
            this.bosLabel13.TabIndex = 9;
            this.bosLabel13.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel13.Text = "Hệ số tay nghề";
            // 
            // fld_txtHREmployeeProbationarySalaryAmount
            // 
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSDataMember = "HREmployeeProbationarySalaryAmount";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSDescription = null;
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSError = null;
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationarySalaryAmount.BOSPropertyName = "Text";
            this.fld_txtHREmployeeProbationarySalaryAmount.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationarySalaryAmount.Location = new System.Drawing.Point(148, 156);
            this.fld_txtHREmployeeProbationarySalaryAmount.Name = "fld_txtHREmployeeProbationarySalaryAmount";
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeProbationarySalaryAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeProbationarySalaryAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeProbationarySalaryAmount.Screen = null;
            this.fld_txtHREmployeeProbationarySalaryAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeProbationarySalaryAmount.TabIndex = 16;
            this.fld_txtHREmployeeProbationarySalaryAmount.Tag = "DC";
            // 
            // fld_txtHREmployeeSkillCoefficient
            // 
            this.fld_txtHREmployeeSkillCoefficient.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSkillCoefficient.BOSDataMember = "HREmployeeSkillCoefficient";
            this.fld_txtHREmployeeSkillCoefficient.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSkillCoefficient.BOSDescription = null;
            this.fld_txtHREmployeeSkillCoefficient.BOSError = null;
            this.fld_txtHREmployeeSkillCoefficient.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSkillCoefficient.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSkillCoefficient.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSkillCoefficient.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSkillCoefficient.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSkillCoefficient.Location = new System.Drawing.Point(746, 104);
            this.fld_txtHREmployeeSkillCoefficient.Name = "fld_txtHREmployeeSkillCoefficient";
            this.fld_txtHREmployeeSkillCoefficient.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSkillCoefficient.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSkillCoefficient.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSkillCoefficient.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSkillCoefficient.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtHREmployeeSkillCoefficient.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtHREmployeeSkillCoefficient.Properties.EditFormat.FormatString = "n2";
            this.fld_txtHREmployeeSkillCoefficient.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtHREmployeeSkillCoefficient.Properties.Mask.EditMask = "n2";
            this.fld_txtHREmployeeSkillCoefficient.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSkillCoefficient.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSkillCoefficient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSkillCoefficient.Screen = null;
            this.fld_txtHREmployeeSkillCoefficient.Size = new System.Drawing.Size(136, 20);
            this.fld_txtHREmployeeSkillCoefficient.TabIndex = 12;
            this.fld_txtHREmployeeSkillCoefficient.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel5.Location = new System.Drawing.Point(16, 159);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(72, 13);
            this.bosLabel5.TabIndex = 67;
            this.bosLabel5.Text = "Lương thử việc";
            // 
            // fld_lkeFK_HRConfigRankID
            // 
            this.fld_lkeFK_HRConfigRankID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRConfigRankID.BOSAllowDummy = false;
            this.fld_lkeFK_HRConfigRankID.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSDataMember = "FK_HRConfigRankID";
            this.fld_lkeFK_HRConfigRankID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRConfigRankID.BOSDescription = "";
            this.fld_lkeFK_HRConfigRankID.BOSError = null;
            this.fld_lkeFK_HRConfigRankID.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRConfigRankID.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.CurrentDisplayText = null;
            this.fld_lkeFK_HRConfigRankID.Location = new System.Drawing.Point(468, 78);
            this.fld_lkeFK_HRConfigRankID.Name = "fld_lkeFK_HRConfigRankID";
            this.fld_lkeFK_HRConfigRankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRConfigRankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRConfigRankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRConfigRankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRConfigRankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRConfigRankID.Properties.ColumnName = null;
            this.fld_lkeFK_HRConfigRankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigRankNo", "Mã bậc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigRankName", "Tên bậc")});
            this.fld_lkeFK_HRConfigRankID.Properties.DisplayMember = "HRConfigRankName";
            this.fld_lkeFK_HRConfigRankID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigRankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRConfigRankID.Properties.ValueMember = "HRConfigRankID";
            this.fld_lkeFK_HRConfigRankID.Screen = null;
            this.fld_lkeFK_HRConfigRankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRConfigRankID.TabIndex = 8;
            this.fld_lkeFK_HRConfigRankID.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel12.Location = new System.Drawing.Point(346, 81);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(65, 13);
            this.bosLabel12.TabIndex = 65;
            this.bosLabel12.Text = "Bậc công việc";
            // 
            // fld_lkeFK_HRConfigScaleID
            // 
            this.fld_lkeFK_HRConfigScaleID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRConfigScaleID.BOSAllowDummy = false;
            this.fld_lkeFK_HRConfigScaleID.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSDataMember = "FK_HRConfigScaleID";
            this.fld_lkeFK_HRConfigScaleID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRConfigScaleID.BOSDescription = "";
            this.fld_lkeFK_HRConfigScaleID.BOSError = null;
            this.fld_lkeFK_HRConfigScaleID.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRConfigScaleID.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.CurrentDisplayText = null;
            this.fld_lkeFK_HRConfigScaleID.Location = new System.Drawing.Point(468, 52);
            this.fld_lkeFK_HRConfigScaleID.Name = "fld_lkeFK_HRConfigScaleID";
            this.fld_lkeFK_HRConfigScaleID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRConfigScaleID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRConfigScaleID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRConfigScaleID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRConfigScaleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRConfigScaleID.Properties.ColumnName = null;
            this.fld_lkeFK_HRConfigScaleID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigScaleNo", "Mã ngạch"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigScaleName", "Tên ngạch")});
            this.fld_lkeFK_HRConfigScaleID.Properties.DisplayMember = "HRConfigScaleName";
            this.fld_lkeFK_HRConfigScaleID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRConfigScaleID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRConfigScaleID.Properties.ValueMember = "HRConfigScaleID";
            this.fld_lkeFK_HRConfigScaleID.Screen = null;
            this.fld_lkeFK_HRConfigScaleID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRConfigScaleID.TabIndex = 5;
            this.fld_lkeFK_HRConfigScaleID.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel11.Location = new System.Drawing.Point(346, 55);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(30, 13);
            this.bosLabel11.TabIndex = 63;
            this.bosLabel11.Text = "Ngạch";
            // 
            // fld_lkeHREmployeePayRollCalculatedWorkType
            // 
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSAllowAddNew = false;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSAllowDummy = true;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSDataMember = "HREmployeePayRollCalculatedWorkType";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSDescription = "";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSError = null;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.CurrentDisplayText = null;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Location = new System.Drawing.Point(746, 26);
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Name = "fld_lkeHREmployeePayRollCalculatedWorkType";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.ColumnName = null;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeePayRollCalculatedWorkType, true);
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeHREmployeePayRollCalculatedWorkType.TabIndex = 2;
            this.fld_lkeHREmployeePayRollCalculatedWorkType.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(657, 29);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(54, 13);
            this.bosLabel6.TabIndex = 61;
            this.bosLabel6.Text = "Loại xếp ca";
            // 
            // fld_lkeFK_HRAllowanceManageConfigID
            // 
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSAllowDummy = true;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSComment = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSDataMember = "FK_HRAllowanceManageConfigID";
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSDescription = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSError = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSFieldGroup = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSFieldParent = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSFieldRelation = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSPrivilege = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSSelectType = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.CurrentDisplayText = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.Location = new System.Drawing.Point(148, 130);
            this.fld_lkeFK_HRAllowanceManageConfigID.Name = "fld_lkeFK_HRAllowanceManageConfigID";
            this.fld_lkeFK_HRAllowanceManageConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRAllowanceManageConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRAllowanceManageConfigName", "Mức phụ cấp")});
            this.fld_lkeFK_HRAllowanceManageConfigID.Properties.DisplayMember = "HRAllowanceManageConfigName";
            this.fld_lkeFK_HRAllowanceManageConfigID.Properties.ValueMember = "HRAllowanceManageConfigID";
            this.fld_lkeFK_HRAllowanceManageConfigID.Screen = null;
            this.fld_lkeFK_HRAllowanceManageConfigID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRAllowanceManageConfigID.TabIndex = 14;
            this.fld_lkeFK_HRAllowanceManageConfigID.Tag = "DC";
            // 
            // fld_lblLabel60
            // 
            this.fld_lblLabel60.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel60.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel60.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel60.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel60.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSDescription = null;
            this.fld_lblLabel60.BOSError = null;
            this.fld_lblLabel60.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.Location = new System.Drawing.Point(16, 55);
            this.fld_lblLabel60.Name = "fld_lblLabel60";
            this.fld_lblLabel60.Screen = null;
            this.fld_lblLabel60.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel60.TabIndex = 5;
            this.fld_lblLabel60.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel60.Text = "Lương căn bản";
            // 
            // fld_lkeFK_HRWorkingShiftID
            // 
            this.fld_lkeFK_HRWorkingShiftID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRWorkingShiftID.BOSAllowDummy = false;
            this.fld_lkeFK_HRWorkingShiftID.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSDataMember = "FK_HRWorkingShiftID";
            this.fld_lkeFK_HRWorkingShiftID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRWorkingShiftID.BOSDescription = "";
            this.fld_lkeFK_HRWorkingShiftID.BOSError = null;
            this.fld_lkeFK_HRWorkingShiftID.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRWorkingShiftID.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.CurrentDisplayText = null;
            this.fld_lkeFK_HRWorkingShiftID.Location = new System.Drawing.Point(746, 52);
            this.fld_lkeFK_HRWorkingShiftID.Name = "fld_lkeFK_HRWorkingShiftID";
            this.fld_lkeFK_HRWorkingShiftID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRWorkingShiftID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRWorkingShiftID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRWorkingShiftID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRWorkingShiftID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRWorkingShiftID.Properties.ColumnName = null;
            this.fld_lkeFK_HRWorkingShiftID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRWorkingShiftName", "Ca làm việc")});
            this.fld_lkeFK_HRWorkingShiftID.Properties.DisplayMember = "HRWorkingShiftName";
            this.fld_lkeFK_HRWorkingShiftID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_HRWorkingShiftID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRWorkingShiftID.Properties.ValueMember = "HRWorkingShiftID";
            this.fld_lkeFK_HRWorkingShiftID.Screen = null;
            this.fld_lkeFK_HRWorkingShiftID.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeFK_HRWorkingShiftID.TabIndex = 6;
            this.fld_lkeFK_HRWorkingShiftID.Tag = "DC";
            this.fld_lkeFK_HRWorkingShiftID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRWorkingShiftID_QueryPopUp);
            // 
            // fld_lkeHRPayRollCalculatedSalaryType
            // 
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSAllowDummy = false;
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSDataMember = "HRPayRollCalculatedSalaryType";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSDataSource = "HREmployees";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSDescription = null;
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSError = null;
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSFieldParent = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSSelectType = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.BOSSelectTypeValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.CurrentDisplayText = null;
            this.fld_lkeHRPayRollCalculatedSalaryType.Location = new System.Drawing.Point(468, 104);
            this.fld_lkeHRPayRollCalculatedSalaryType.Name = "fld_lkeHRPayRollCalculatedSalaryType";
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.ColumnName = null;
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRPayRollCalculatedSalaryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRPayRollCalculatedSalaryType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRPayRollCalculatedSalaryType, true);
            this.fld_lkeHRPayRollCalculatedSalaryType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollCalculatedSalaryType.TabIndex = 11;
            this.fld_lkeHRPayRollCalculatedSalaryType.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.Location = new System.Drawing.Point(779, 149);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(85, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.Text = "Số tháng thử việc";
            this.bosLabel3.Visible = false;
            // 
            // fld_lblLabel61
            // 
            this.fld_lblLabel61.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel61.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel61.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel61.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSDescription = null;
            this.fld_lblLabel61.BOSError = null;
            this.fld_lblLabel61.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.Location = new System.Drawing.Point(346, 29);
            this.fld_lblLabel61.Name = "fld_lblLabel61";
            this.fld_lblLabel61.Screen = null;
            this.fld_lblLabel61.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel61.TabIndex = 7;
            this.fld_lblLabel61.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel61.Text = "Hệ số";
            // 
            // fld_txtHREmployeeSalarySocialInsurance
            // 
            this.fld_txtHREmployeeSalarySocialInsurance.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSDataMember = "HREmployeeSalarySocialInsurance";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSDescription = "";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSError = null;
            this.fld_txtHREmployeeSalarySocialInsurance.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalarySocialInsurance.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSalarySocialInsurance.EditValue = "0";
            this.fld_txtHREmployeeSalarySocialInsurance.Location = new System.Drawing.Point(148, 78);
            this.fld_txtHREmployeeSalarySocialInsurance.Name = "fld_txtHREmployeeSalarySocialInsurance";
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSalarySocialInsurance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSalarySocialInsurance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSalarySocialInsurance.Screen = null;
            this.fld_txtHREmployeeSalarySocialInsurance.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeSalarySocialInsurance.TabIndex = 7;
            this.fld_txtHREmployeeSalarySocialInsurance.Tag = "DC";
            // 
            // fld_txtHREmployeeBonusSale
            // 
            this.fld_txtHREmployeeBonusSale.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeBonusSale.BOSDataMember = "HREmployeeBonusSale";
            this.fld_txtHREmployeeBonusSale.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeBonusSale.BOSDescription = "";
            this.fld_txtHREmployeeBonusSale.BOSError = null;
            this.fld_txtHREmployeeBonusSale.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeBonusSale.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeBonusSale.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeBonusSale.BOSPropertyName = "Text";
            this.fld_txtHREmployeeBonusSale.EditValue = "0";
            this.fld_txtHREmployeeBonusSale.Location = new System.Drawing.Point(468, 130);
            this.fld_txtHREmployeeBonusSale.Name = "fld_txtHREmployeeBonusSale";
            this.fld_txtHREmployeeBonusSale.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeBonusSale.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeBonusSale.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeBonusSale.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeBonusSale.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeBonusSale.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeBonusSale.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeBonusSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeBonusSale.Screen = null;
            this.fld_txtHREmployeeBonusSale.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeBonusSale.TabIndex = 13;
            this.fld_txtHREmployeeBonusSale.Tag = "DC";
            this.fld_txtHREmployeeBonusSale.Visible = false;
            // 
            // fld_txtHREmployeeJobPerformanceAmt
            // 
            this.fld_txtHREmployeeJobPerformanceAmt.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSDataMember = "HREmployeeJobPerformanceAmt";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSDescription = "";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSError = null;
            this.fld_txtHREmployeeJobPerformanceAmt.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeJobPerformanceAmt.BOSPropertyName = "Text";
            this.fld_txtHREmployeeJobPerformanceAmt.EditValue = "0";
            this.fld_txtHREmployeeJobPerformanceAmt.Location = new System.Drawing.Point(148, 104);
            this.fld_txtHREmployeeJobPerformanceAmt.Name = "fld_txtHREmployeeJobPerformanceAmt";
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeJobPerformanceAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeJobPerformanceAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeJobPerformanceAmt.Screen = null;
            this.fld_txtHREmployeeJobPerformanceAmt.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeJobPerformanceAmt.TabIndex = 10;
            this.fld_txtHREmployeeJobPerformanceAmt.Tag = "DC";
            // 
            // fld_txtHREmployeePercentContractSlrAmt
            // 
            this.fld_txtHREmployeePercentContractSlrAmt.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSDataMember = "HREmployeePercentContractSlrAmt";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSDescription = "";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSError = null;
            this.fld_txtHREmployeePercentContractSlrAmt.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeePercentContractSlrAmt.BOSPropertyName = "Text";
            this.fld_txtHREmployeePercentContractSlrAmt.EditValue = "New";
            this.fld_txtHREmployeePercentContractSlrAmt.Location = new System.Drawing.Point(97, 52);
            this.fld_txtHREmployeePercentContractSlrAmt.Name = "fld_txtHREmployeePercentContractSlrAmt";
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Mask.EditMask = "n0";
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeePercentContractSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePercentContractSlrAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fld_txtHREmployeePercentContractSlrAmt.Screen = null;
            this.fld_txtHREmployeePercentContractSlrAmt.Size = new System.Drawing.Size(28, 20);
            this.fld_txtHREmployeePercentContractSlrAmt.TabIndex = 3;
            this.fld_txtHREmployeePercentContractSlrAmt.Tag = "DC";
            this.fld_txtHREmployeePercentContractSlrAmt.Validated += new System.EventHandler(this.fld_txtHREmployeePercentContractSlrAmt_Validated);
            // 
            // fld_txtHREmployeeContractSlrAmt
            // 
            this.fld_txtHREmployeeContractSlrAmt.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContractSlrAmt.BOSDataMember = "HREmployeeContractSlrAmt";
            this.fld_txtHREmployeeContractSlrAmt.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeContractSlrAmt.BOSDescription = null;
            this.fld_txtHREmployeeContractSlrAmt.BOSError = null;
            this.fld_txtHREmployeeContractSlrAmt.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContractSlrAmt.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContractSlrAmt.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContractSlrAmt.BOSPropertyName = "Text";
            this.fld_txtHREmployeeContractSlrAmt.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeContractSlrAmt.Location = new System.Drawing.Point(148, 52);
            this.fld_txtHREmployeeContractSlrAmt.Name = "fld_txtHREmployeeContractSlrAmt";
            this.fld_txtHREmployeeContractSlrAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeContractSlrAmt.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeContractSlrAmt.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeContractSlrAmt.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeContractSlrAmt.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeContractSlrAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeContractSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeContractSlrAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeContractSlrAmt.Screen = null;
            this.fld_txtHREmployeeContractSlrAmt.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeContractSlrAmt.TabIndex = 4;
            this.fld_txtHREmployeeContractSlrAmt.Tag = "DC";
            // 
            // fld_txtHREmployeeProbationaryMonth
            // 
            this.fld_txtHREmployeeProbationaryMonth.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationaryMonth.BOSDataMember = "HREmployeeProbationaryMonth";
            this.fld_txtHREmployeeProbationaryMonth.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeProbationaryMonth.BOSDescription = null;
            this.fld_txtHREmployeeProbationaryMonth.BOSError = null;
            this.fld_txtHREmployeeProbationaryMonth.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationaryMonth.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationaryMonth.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeProbationaryMonth.BOSPropertyName = "Text";
            this.fld_txtHREmployeeProbationaryMonth.EditValue = "0";
            this.fld_txtHREmployeeProbationaryMonth.Location = new System.Drawing.Point(870, 149);
            this.fld_txtHREmployeeProbationaryMonth.Name = "fld_txtHREmployeeProbationaryMonth";
            this.fld_txtHREmployeeProbationaryMonth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeProbationaryMonth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeProbationaryMonth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeProbationaryMonth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeProbationaryMonth.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeProbationaryMonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeProbationaryMonth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeProbationaryMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeProbationaryMonth.Screen = null;
            this.fld_txtHREmployeeProbationaryMonth.Size = new System.Drawing.Size(26, 20);
            this.fld_txtHREmployeeProbationaryMonth.TabIndex = 12;
            this.fld_txtHREmployeeProbationaryMonth.Tag = "DC";
            this.fld_txtHREmployeeProbationaryMonth.Visible = false;
            // 
            // fld_txtHREmployeeWorkingSlrAmt
            // 
            this.fld_txtHREmployeeWorkingSlrAmt.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSDataMember = "HREmployeeWorkingSlrAmt";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSDescription = null;
            this.fld_txtHREmployeeWorkingSlrAmt.BOSError = null;
            this.fld_txtHREmployeeWorkingSlrAmt.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeWorkingSlrAmt.BOSPropertyName = "Text";
            this.fld_txtHREmployeeWorkingSlrAmt.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeWorkingSlrAmt.Location = new System.Drawing.Point(148, 26);
            this.fld_txtHREmployeeWorkingSlrAmt.Name = "fld_txtHREmployeeWorkingSlrAmt";
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeWorkingSlrAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeWorkingSlrAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeWorkingSlrAmt.Screen = null;
            this.fld_txtHREmployeeWorkingSlrAmt.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeWorkingSlrAmt.TabIndex = 0;
            this.fld_txtHREmployeeWorkingSlrAmt.Tag = "DC";
            // 
            // fld_txtHREmployeeSalaryFactor
            // 
            this.fld_txtHREmployeeSalaryFactor.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalaryFactor.BOSDataMember = "HREmployeeSalaryFactor";
            this.fld_txtHREmployeeSalaryFactor.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSalaryFactor.BOSDescription = null;
            this.fld_txtHREmployeeSalaryFactor.BOSError = null;
            this.fld_txtHREmployeeSalaryFactor.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalaryFactor.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalaryFactor.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalaryFactor.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSalaryFactor.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSalaryFactor.Location = new System.Drawing.Point(468, 26);
            this.fld_txtHREmployeeSalaryFactor.Name = "fld_txtHREmployeeSalaryFactor";
            this.fld_txtHREmployeeSalaryFactor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSalaryFactor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSalaryFactor.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSalaryFactor.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSalaryFactor.Properties.Mask.EditMask = "n";
            this.fld_txtHREmployeeSalaryFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHREmployeeSalaryFactor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSalaryFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSalaryFactor.Screen = null;
            this.fld_txtHREmployeeSalaryFactor.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREmployeeSalaryFactor.TabIndex = 1;
            this.fld_txtHREmployeeSalaryFactor.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeePayrollFormulaID
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDataMember = "FK_HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Location = new System.Drawing.Point(746, 78);
            this.fld_lkeFK_HREmployeePayrollFormulaID.Name = "fld_lkeFK_HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaID.TabIndex = 9;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Tag = "DC";
            this.fld_lkeFK_HREmployeePayrollFormulaID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HREmployeePayrollFormulaID_QueryPopUp);
            // 
            // fld_lkeFK_HRTimeSheetScaleID
            // 
            this.fld_lkeFK_HRTimeSheetScaleID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSAllowDummy = true;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSComment = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSDataMember = "FK_HRTimeSheetScaleID";
            this.fld_lkeFK_HRTimeSheetScaleID.BOSDataSource = "HREmployees";
            this.fld_lkeFK_HRTimeSheetScaleID.BOSDescription = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSError = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSFieldGroup = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSFieldParent = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSFieldRelation = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSPrivilege = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTimeSheetScaleID.BOSSelectType = null;
            this.fld_lkeFK_HRTimeSheetScaleID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRTimeSheetScaleID.CurrentDisplayText = null;
            this.fld_lkeFK_HRTimeSheetScaleID.Location = new System.Drawing.Point(747, 146);
            this.fld_lkeFK_HRTimeSheetScaleID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRTimeSheetScaleID.Name = "fld_lkeFK_HRTimeSheetScaleID";
            this.fld_lkeFK_HRTimeSheetScaleID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTimeSheetScaleID.Properties.ColumnName = null;
            this.fld_lkeFK_HRTimeSheetScaleID.Properties.DisplayMember = "HRTimeSheetScaleDesc";
            this.fld_lkeFK_HRTimeSheetScaleID.Properties.ValueMember = "HRTimeSheetScaleID";
            this.fld_lkeFK_HRTimeSheetScaleID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRTimeSheetScaleID, true);
            this.fld_lkeFK_HRTimeSheetScaleID.Size = new System.Drawing.Size(26, 20);
            this.fld_lkeFK_HRTimeSheetScaleID.TabIndex = 11;
            this.fld_lkeFK_HRTimeSheetScaleID.Tag = "DC";
            this.fld_lkeFK_HRTimeSheetScaleID.Visible = false;
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
            this.bosLabel1.Location = new System.Drawing.Point(657, 81);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(81, 13);
            this.bosLabel1.TabIndex = 58;
            this.bosLabel1.Text = "Nhóm chấm công";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel8.Location = new System.Drawing.Point(657, 149);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(84, 13);
            this.bosLabel8.TabIndex = 58;
            this.bosLabel8.Text = "Thang chấm công";
            this.bosLabel8.Visible = false;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel2.Location = new System.Drawing.Point(657, 55);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(54, 13);
            this.bosLabel2.TabIndex = 58;
            this.bosLabel2.Text = "Ca làm việc";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel9.Location = new System.Drawing.Point(346, 107);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(75, 13);
            this.bosLabel9.TabIndex = 58;
            this.bosLabel9.Text = "Tính lương theo";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel17.Location = new System.Drawing.Point(131, 55);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(11, 13);
            this.bosLabel17.TabIndex = 3;
            this.bosLabel17.Text = "%";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel19.Location = new System.Drawing.Point(346, 133);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(84, 13);
            this.bosLabel19.TabIndex = 58;
            this.bosLabel19.Text = "Thưởng doanh số";
            this.bosLabel19.Visible = false;
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel20.Location = new System.Drawing.Point(16, 81);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(50, 13);
            this.bosLabel20.TabIndex = 58;
            this.bosLabel20.Text = "Mức lương";
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
            this.bosLabel22.Location = new System.Drawing.Point(16, 133);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(80, 13);
            this.bosLabel22.TabIndex = 58;
            this.bosLabel22.Text = "Tính hiệu quả CV";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel18.Location = new System.Drawing.Point(16, 107);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(77, 13);
            this.bosLabel18.TabIndex = 58;
            this.bosLabel18.Text = "Lương hiệu quả ";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel15.Location = new System.Drawing.Point(16, 29);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(75, 13);
            this.bosLabel15.TabIndex = 58;
            this.bosLabel15.Text = "Mức lương tổng";
            // 
            // fld_grcGroupControl4
            // 
            this.fld_grcGroupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl4.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl4.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl4.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSDescription = null;
            this.fld_grcGroupControl4.BOSError = null;
            this.fld_grcGroupControl4.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl4.Controls.Add(this.fld_ceHREmployeeHaveOutOfWorkIns);
            this.fld_grcGroupControl4.Controls.Add(this.bosLine1);
            this.fld_grcGroupControl4.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtHREmployeeOutOfWorkIns);
            this.fld_grcGroupControl4.Controls.Add(this.fld_ceHREmployeeHaveInsurrance);
            this.fld_grcGroupControl4.Controls.Add(this.fld_Line2);
            this.fld_grcGroupControl4.Controls.Add(this.fld_Line1);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel38);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel36);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtHREmployeeHealthInsNo);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel40);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtHREmployeeHealthInsRegisteredPlace);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel41);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteHREmployeeHealthInsExpiryDate);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteHREmployeeHealthInsRegisteredDate);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtHREmployeeSocialInsNo);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel47);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel48);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteHREmployeeSocialInsRegisteredDate);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel49);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel50);
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(3, 282);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(926, 271);
            this.fld_grcGroupControl4.TabIndex = 2;
            this.fld_grcGroupControl4.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl4.Text = "Thông tin bảo hiểm";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.Location = new System.Drawing.Point(16, 245);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(47, 13);
            this.bosLabel10.TabIndex = 67;
            this.bosLabel10.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel10.Text = "Mức đóng";
            // 
            // fld_ceHREmployeeHaveOutOfWorkIns
            // 
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSComment = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDataMember = "HREmployeeHaveOutOfWorkIns";
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDataSource = "HREmployees";
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSDescription = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSError = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSFieldGroup = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSFieldRelation = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSPrivilege = null;
            this.fld_ceHREmployeeHaveOutOfWorkIns.BOSPropertyName = "EditValue";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Location = new System.Drawing.Point(365, 242);
            this.fld_ceHREmployeeHaveOutOfWorkIns.MenuManager = this.screenToolbar;
            this.fld_ceHREmployeeHaveOutOfWorkIns.Name = "fld_ceHREmployeeHaveOutOfWorkIns";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Properties.Caption = "Có tham gia bảo hiểm";
            this.fld_ceHREmployeeHaveOutOfWorkIns.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ceHREmployeeHaveOutOfWorkIns, true);
            this.fld_ceHREmployeeHaveOutOfWorkIns.Size = new System.Drawing.Size(203, 19);
            this.fld_ceHREmployeeHaveOutOfWorkIns.TabIndex = 8;
            this.fld_ceHREmployeeHaveOutOfWorkIns.Tag = "DC";
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
            this.bosLine1.Location = new System.Drawing.Point(111, 222);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(467, 10);
            this.bosLine1.TabIndex = 65;
            this.bosLine1.TabStop = false;
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(12, 219);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(94, 13);
            this.bosLabel7.TabIndex = 64;
            this.bosLabel7.Text = "Bảo hiểm tai nạn";
            // 
            // fld_txtHREmployeeOutOfWorkIns
            // 
            this.fld_txtHREmployeeOutOfWorkIns.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeOutOfWorkIns.BOSDataMember = "HREmployeeOutOfWorkIns";
            this.fld_txtHREmployeeOutOfWorkIns.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeOutOfWorkIns.BOSDescription = null;
            this.fld_txtHREmployeeOutOfWorkIns.BOSError = null;
            this.fld_txtHREmployeeOutOfWorkIns.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeOutOfWorkIns.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeOutOfWorkIns.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeOutOfWorkIns.BOSPropertyName = "Text";
            this.fld_txtHREmployeeOutOfWorkIns.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeOutOfWorkIns.Location = new System.Drawing.Point(110, 241);
            this.fld_txtHREmployeeOutOfWorkIns.Name = "fld_txtHREmployeeOutOfWorkIns";
            this.fld_txtHREmployeeOutOfWorkIns.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeOutOfWorkIns.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeOutOfWorkIns.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeOutOfWorkIns.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeOutOfWorkIns.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeOutOfWorkIns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeOutOfWorkIns.Screen = null;
            this.fld_txtHREmployeeOutOfWorkIns.Size = new System.Drawing.Size(188, 20);
            this.fld_txtHREmployeeOutOfWorkIns.TabIndex = 7;
            this.fld_txtHREmployeeOutOfWorkIns.Tag = "DC";
            // 
            // fld_ceHREmployeeHaveInsurrance
            // 
            this.fld_ceHREmployeeHaveInsurrance.BOSComment = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSDataMember = "HREmployeeHaveInsurrance";
            this.fld_ceHREmployeeHaveInsurrance.BOSDataSource = "HREmployees";
            this.fld_ceHREmployeeHaveInsurrance.BOSDescription = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSError = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSFieldGroup = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSFieldRelation = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSPrivilege = null;
            this.fld_ceHREmployeeHaveInsurrance.BOSPropertyName = "EditValue";
            this.fld_ceHREmployeeHaveInsurrance.Location = new System.Drawing.Point(365, 78);
            this.fld_ceHREmployeeHaveInsurrance.MenuManager = this.screenToolbar;
            this.fld_ceHREmployeeHaveInsurrance.Name = "fld_ceHREmployeeHaveInsurrance";
            this.fld_ceHREmployeeHaveInsurrance.Properties.Caption = "Có tham gia bảo hiểm";
            this.fld_ceHREmployeeHaveInsurrance.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_ceHREmployeeHaveInsurrance, true);
            this.fld_ceHREmployeeHaveInsurrance.Size = new System.Drawing.Size(203, 19);
            this.fld_ceHREmployeeHaveInsurrance.TabIndex = 2;
            this.fld_ceHREmployeeHaveInsurrance.Tag = "DC";
            this.fld_ceHREmployeeHaveInsurrance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fld_ceHREmployeeHaveInsurrance_MouseClick);
            // 
            // fld_Line2
            // 
            this.fld_Line2.BOSComment = null;
            this.fld_Line2.BOSDataMember = null;
            this.fld_Line2.BOSDataSource = null;
            this.fld_Line2.BOSDescription = null;
            this.fld_Line2.BOSError = null;
            this.fld_Line2.BOSFieldGroup = null;
            this.fld_Line2.BOSFieldRelation = null;
            this.fld_Line2.BOSPrivilege = null;
            this.fld_Line2.BOSPropertyName = null;
            this.fld_Line2.Location = new System.Drawing.Point(93, 119);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(480, 10);
            this.fld_Line2.TabIndex = 46;
            this.fld_Line2.TabStop = false;
            // 
            // fld_Line1
            // 
            this.fld_Line1.BOSComment = null;
            this.fld_Line1.BOSDataMember = null;
            this.fld_Line1.BOSDataSource = null;
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = null;
            this.fld_Line1.BOSFieldRelation = null;
            this.fld_Line1.BOSPrivilege = null;
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Location = new System.Drawing.Point(110, 33);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(467, 10);
            this.fld_Line1.TabIndex = 46;
            this.fld_Line1.TabStop = false;
            // 
            // fld_lblLabel38
            // 
            this.fld_lblLabel38.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel38.Appearance.Options.UseFont = true;
            this.fld_lblLabel38.BOSComment = null;
            this.fld_lblLabel38.BOSDataMember = null;
            this.fld_lblLabel38.BOSDataSource = null;
            this.fld_lblLabel38.BOSDescription = null;
            this.fld_lblLabel38.BOSError = null;
            this.fld_lblLabel38.BOSFieldGroup = null;
            this.fld_lblLabel38.BOSFieldRelation = null;
            this.fld_lblLabel38.BOSPrivilege = null;
            this.fld_lblLabel38.BOSPropertyName = null;
            this.fld_lblLabel38.Location = new System.Drawing.Point(12, 116);
            this.fld_lblLabel38.Name = "fld_lblLabel38";
            this.fld_lblLabel38.Screen = null;
            this.fld_lblLabel38.Size = new System.Drawing.Size(77, 13);
            this.fld_lblLabel38.TabIndex = 45;
            this.fld_lblLabel38.Text = "Bảo hiểm y tế";
            // 
            // fld_lblLabel36
            // 
            this.fld_lblLabel36.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel36.Appearance.Options.UseFont = true;
            this.fld_lblLabel36.BOSComment = null;
            this.fld_lblLabel36.BOSDataMember = null;
            this.fld_lblLabel36.BOSDataSource = null;
            this.fld_lblLabel36.BOSDescription = null;
            this.fld_lblLabel36.BOSError = null;
            this.fld_lblLabel36.BOSFieldGroup = null;
            this.fld_lblLabel36.BOSFieldRelation = null;
            this.fld_lblLabel36.BOSPrivilege = null;
            this.fld_lblLabel36.BOSPropertyName = null;
            this.fld_lblLabel36.Location = new System.Drawing.Point(11, 30);
            this.fld_lblLabel36.Name = "fld_lblLabel36";
            this.fld_lblLabel36.Screen = null;
            this.fld_lblLabel36.Size = new System.Drawing.Size(89, 13);
            this.fld_lblLabel36.TabIndex = 45;
            this.fld_lblLabel36.Text = "Bảo hiểm xã hội";
            // 
            // fld_txtHREmployeeHealthInsNo
            // 
            this.fld_txtHREmployeeHealthInsNo.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsNo.BOSDataMember = "HREmployeeHealthInsNo";
            this.fld_txtHREmployeeHealthInsNo.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeHealthInsNo.BOSDescription = null;
            this.fld_txtHREmployeeHealthInsNo.BOSError = null;
            this.fld_txtHREmployeeHealthInsNo.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsNo.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsNo.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeeHealthInsNo.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsNo.Location = new System.Drawing.Point(109, 136);
            this.fld_txtHREmployeeHealthInsNo.Name = "fld_txtHREmployeeHealthInsNo";
            this.fld_txtHREmployeeHealthInsNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeHealthInsNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeHealthInsNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeHealthInsNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeHealthInsNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeHealthInsNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeHealthInsNo.Screen = null;
            this.fld_txtHREmployeeHealthInsNo.Size = new System.Drawing.Size(466, 20);
            this.fld_txtHREmployeeHealthInsNo.TabIndex = 3;
            this.fld_txtHREmployeeHealthInsNo.Tag = "DC";
            // 
            // fld_lblLabel40
            // 
            this.fld_lblLabel40.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel40.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel40.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel40.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel40.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSDescription = null;
            this.fld_lblLabel40.BOSError = null;
            this.fld_lblLabel40.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.Location = new System.Drawing.Point(14, 55);
            this.fld_lblLabel40.Name = "fld_lblLabel40";
            this.fld_lblLabel40.Screen = null;
            this.fld_lblLabel40.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel40.TabIndex = 21;
            this.fld_lblLabel40.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel40.Text = "Số sổ bảo hiểm";
            // 
            // fld_txtHREmployeeHealthInsRegisteredPlace
            // 
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSDataMember = "HREmployeeHealthInsRegisteredPlace";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSDescription = null;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSError = null;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.BOSPropertyName = "Text";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Location = new System.Drawing.Point(109, 160);
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Name = "fld_txtHREmployeeHealthInsRegisteredPlace";
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Screen = null;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Size = new System.Drawing.Size(466, 20);
            this.fld_txtHREmployeeHealthInsRegisteredPlace.TabIndex = 4;
            this.fld_txtHREmployeeHealthInsRegisteredPlace.Tag = "DC";
            // 
            // fld_lblLabel41
            // 
            this.fld_lblLabel41.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel41.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel41.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel41.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel41.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSDescription = null;
            this.fld_lblLabel41.BOSError = null;
            this.fld_lblLabel41.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.Location = new System.Drawing.Point(14, 79);
            this.fld_lblLabel41.Name = "fld_lblLabel41";
            this.fld_lblLabel41.Screen = null;
            this.fld_lblLabel41.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel41.TabIndex = 22;
            this.fld_lblLabel41.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel41.Text = "Ngày đăng ký";
            // 
            // fld_dteHREmployeeHealthInsExpiryDate
            // 
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSDataMember = "HREmployeeHealthInsExpiryDate";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSDescription = null;
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSError = null;
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsExpiryDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeHealthInsExpiryDate.EditValue = null;
            this.fld_dteHREmployeeHealthInsExpiryDate.Location = new System.Drawing.Point(450, 184);
            this.fld_dteHREmployeeHealthInsExpiryDate.Name = "fld_dteHREmployeeHealthInsExpiryDate";
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeHealthInsExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeHealthInsExpiryDate.Screen = null;
            this.fld_dteHREmployeeHealthInsExpiryDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHREmployeeHealthInsExpiryDate.TabIndex = 6;
            this.fld_dteHREmployeeHealthInsExpiryDate.Tag = "DC";
            this.fld_dteHREmployeeHealthInsExpiryDate.Visible = false;
            // 
            // fld_dteHREmployeeHealthInsRegisteredDate
            // 
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSDataMember = "HREmployeeHealthInsRegisteredDate";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSDescription = null;
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSError = null;
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeHealthInsRegisteredDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeHealthInsRegisteredDate.EditValue = null;
            this.fld_dteHREmployeeHealthInsRegisteredDate.Location = new System.Drawing.Point(109, 184);
            this.fld_dteHREmployeeHealthInsRegisteredDate.Name = "fld_dteHREmployeeHealthInsRegisteredDate";
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeHealthInsRegisteredDate.Screen = null;
            this.fld_dteHREmployeeHealthInsRegisteredDate.Size = new System.Drawing.Size(189, 20);
            this.fld_dteHREmployeeHealthInsRegisteredDate.TabIndex = 5;
            this.fld_dteHREmployeeHealthInsRegisteredDate.Tag = "DC";
            // 
            // fld_txtHREmployeeSocialInsNo
            // 
            this.fld_txtHREmployeeSocialInsNo.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsNo.BOSDataMember = "HREmployeeSocialInsNo";
            this.fld_txtHREmployeeSocialInsNo.BOSDataSource = "HREmployees";
            this.fld_txtHREmployeeSocialInsNo.BOSDescription = null;
            this.fld_txtHREmployeeSocialInsNo.BOSError = null;
            this.fld_txtHREmployeeSocialInsNo.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsNo.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsNo.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeeSocialInsNo.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHREmployeeSocialInsNo.Location = new System.Drawing.Point(109, 52);
            this.fld_txtHREmployeeSocialInsNo.Name = "fld_txtHREmployeeSocialInsNo";
            this.fld_txtHREmployeeSocialInsNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeSocialInsNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeSocialInsNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeSocialInsNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeSocialInsNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeSocialInsNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeSocialInsNo.Screen = null;
            this.fld_txtHREmployeeSocialInsNo.Size = new System.Drawing.Size(466, 20);
            this.fld_txtHREmployeeSocialInsNo.TabIndex = 0;
            this.fld_txtHREmployeeSocialInsNo.Tag = "DC";
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.Location = new System.Drawing.Point(16, 138);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel47.TabIndex = 41;
            this.fld_lblLabel47.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel47.Text = "Số BHYT";
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.Location = new System.Drawing.Point(16, 162);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel48.TabIndex = 42;
            this.fld_lblLabel48.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel48.Text = "Nơi khám bệnh";
            // 
            // fld_dteHREmployeeSocialInsRegisteredDate
            // 
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSDataMember = "HREmployeeSocialInsRegisteredDate";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSDataSource = "HREmployees";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSDescription = null;
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSError = null;
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHREmployeeSocialInsRegisteredDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeSocialInsRegisteredDate.EditValue = null;
            this.fld_dteHREmployeeSocialInsRegisteredDate.Location = new System.Drawing.Point(109, 76);
            this.fld_dteHREmployeeSocialInsRegisteredDate.Name = "fld_dteHREmployeeSocialInsRegisteredDate";
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeSocialInsRegisteredDate.Screen = null;
            this.fld_dteHREmployeeSocialInsRegisteredDate.Size = new System.Drawing.Size(189, 20);
            this.fld_dteHREmployeeSocialInsRegisteredDate.TabIndex = 1;
            this.fld_dteHREmployeeSocialInsRegisteredDate.Tag = "DC";
            // 
            // fld_lblLabel49
            // 
            this.fld_lblLabel49.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel49.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel49.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel49.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel49.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSDescription = null;
            this.fld_lblLabel49.BOSError = null;
            this.fld_lblLabel49.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.Location = new System.Drawing.Point(16, 187);
            this.fld_lblLabel49.Name = "fld_lblLabel49";
            this.fld_lblLabel49.Screen = null;
            this.fld_lblLabel49.Size = new System.Drawing.Size(45, 13);
            this.fld_lblLabel49.TabIndex = 43;
            this.fld_lblLabel49.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel49.Text = "Ngày cấp";
            // 
            // fld_lblLabel50
            // 
            this.fld_lblLabel50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel50.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel50.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel50.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel50.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSDescription = null;
            this.fld_lblLabel50.BOSError = null;
            this.fld_lblLabel50.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.Location = new System.Drawing.Point(367, 187);
            this.fld_lblLabel50.Name = "fld_lblLabel50";
            this.fld_lblLabel50.Screen = null;
            this.fld_lblLabel50.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel50.TabIndex = 44;
            this.fld_lblLabel50.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel50.Text = "Ngày hết hạn";
            this.fld_lblLabel50.Visible = false;
            // 
            // DMSS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1139, 735);
            this.Controls.Add(this.panel1);
            this.Name = "DMSS100";
            this.ScreenNumber = "DMSS100";
            this.Tag = "DM";
            this.Text = "Thông tin lương - bảo hiểm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowanceHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeExtraSalary1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowancePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeAllowanceGas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeUnionMemberFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSyndicatePaymentAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSyndicatePaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeTaxPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSocialInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRInsCalculatedSalaryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeOutOfWorkInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeProbationarySalaryAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSkillCoefficient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigRankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigScaleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayRollCalculatedWorkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRAllowanceManageConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRWorkingShiftID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollCalculatedSalaryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSalarySocialInsurance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeBonusSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeJobPerformanceAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePercentContractSlrAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeContractSlrAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeProbationaryMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkingSlrAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSalaryFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetScaleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).EndInit();
            this.fld_grcGroupControl4.ResumeLayout(false);
            this.fld_grcGroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveOutOfWorkIns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeOutOfWorkIns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ceHREmployeeHaveInsurrance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeHealthInsRegisteredPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsExpiryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsExpiryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsRegisteredDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeHealthInsRegisteredDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeSocialInsNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeSocialInsRegisteredDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeSocialInsRegisteredDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtHREmployeeAllowanceGas;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSTextBox fld_txtHREmployeeUnionMemberFee;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSyndicatePaymentAmount;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSyndicatePaymentPercent;
        private BOSComponent.BOSTextBox fld_txtHREmployeeTaxPaymentPercent;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel fld_lblLabel56;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSocialInsPaymentPercent;
        private BOSComponent.BOSLabel fld_lblLabel43;
        private BOSComponent.BOSLabel fld_lblPercent;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel fld_lblLabel51;
        private BOSComponent.BOSLookupEdit fld_lkeHRInsCalculatedSalaryType;
        private BOSComponent.BOSTextBox fld_txtHREmployeeHealthInsPaymentPercent;
        private BOSComponent.BOSTextBox fld_txtHREmployeeOutOfWorkInsPaymentPercent;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtHREmployeeProbationarySalaryAmount;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSkillCoefficient;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRConfigRankID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRConfigScaleID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeePayRollCalculatedWorkType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRAllowanceManageConfigID;
        private BOSComponent.BOSLabel fld_lblLabel60;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRWorkingShiftID;
        private BOSComponent.BOSLookupEdit fld_lkeHRPayRollCalculatedSalaryType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSalarySocialInsurance;
        private BOSComponent.BOSTextBox fld_txtHREmployeeBonusSale;
        private BOSComponent.BOSTextBox fld_txtHREmployeeJobPerformanceAmt;
        private BOSComponent.BOSTextBox fld_txtHREmployeePercentContractSlrAmt;
        private BOSComponent.BOSTextBox fld_txtHREmployeeContractSlrAmt;
        private BOSComponent.BOSTextBox fld_txtHREmployeeProbationaryMonth;
        private BOSComponent.BOSTextBox fld_txtHREmployeeWorkingSlrAmt;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSalaryFactor;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRTimeSheetScaleID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSGroupControl fld_grcGroupControl4;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSCheckEdit fld_ceHREmployeeHaveOutOfWorkIns;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtHREmployeeOutOfWorkIns;
        private BOSComponent.BOSCheckEdit fld_ceHREmployeeHaveInsurrance;
        private BOSComponent.BOSLine fld_Line2;
        private BOSComponent.BOSLine fld_Line1;
        private BOSComponent.BOSLabel fld_lblLabel38;
        private BOSComponent.BOSLabel fld_lblLabel36;
        private BOSComponent.BOSTextBox fld_txtHREmployeeHealthInsNo;
        private BOSComponent.BOSLabel fld_lblLabel40;
        private BOSComponent.BOSTextBox fld_txtHREmployeeHealthInsRegisteredPlace;
        private BOSComponent.BOSLabel fld_lblLabel41;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeHealthInsExpiryDate;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeHealthInsRegisteredDate;
        private BOSComponent.BOSTextBox fld_txtHREmployeeSocialInsNo;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSDateEdit fld_dteHREmployeeSocialInsRegisteredDate;
        private BOSComponent.BOSLabel fld_lblLabel49;
        private BOSComponent.BOSLabel fld_lblLabel50;
        private BOSComponent.BOSTextBox fld_txtHREmployeeAllowancePhone;
        private BOSComponent.BOSTextBox fld_txtHREmployeeExtraSalary1;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox fld_txtHREmployeeAllowanceHouse;
        private BOSComponent.BOSLabel bosLabel23;
	}
}
