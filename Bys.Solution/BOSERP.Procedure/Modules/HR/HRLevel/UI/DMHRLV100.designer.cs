using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRLevel.UI
{
	/// <summary>
	/// Summary description for DMHRLV100
	/// </summary>
	partial class DMHRLV100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtHRLevelNo1;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtHRLevelName1;
		private BOSComponent.BOSMemoEdit fld_medHRLevelQualification;
		private BOSComponent.BOSMemoEdit fld_medHRLevelSkill;
		private BOSComponent.BOSMemoEdit fld_medHRLevelWorkExp;
		private BOSComponent.BOSMemoEdit fld_medHRLevelTraining;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private BOSComponent.BOSTextBox fld_txtHRLevelSocialInsPaymentPercent;
		private BOSComponent.BOSTextBox fld_txtHRLevelHealthInsPaymentPercent;
		private BOSComponent.BOSTextBox fld_txtHRLevelOutOfWorkInsPaymentPercent;
		private BOSComponent.BOSTextBox fld_txtHRLevelTaxPaymentPercent;
		private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel13;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSTextBox fld_txtHRLevelSalaryFactor1;
		private BOSComponent.BOSTextBox fld_txtHRLevelContractSlrAmt1;
		private BOSComponent.BOSTextBox fld_txtHRLevelWorkingSlrAmt1;
		private BOSComponent.BOSTextBox fld_txtHRLevelExtraSalary1;
		private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSLabel fld_lblLabel17;
		private BOSComponent.BOSLabel fld_lblLabel18;
		private BOSComponent.BOSLabel fld_lblLabel19;
        private BOSComponent.BOSMemoEdit fld_medHRLevelDesc;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHRLevelNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRLevelName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRLevelQualification = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medHRLevelSkill = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medHRLevelWorkExp = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medHRLevelTraining = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRLevelDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHRLevelSocialInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelHealthInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelTaxPaymentPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRLevelSalaryFactor1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelContractSlrAmt1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelWorkingSlrAmt1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRLevelExtraSalary1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelQualification.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelSkill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelWorkExp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelTraining.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSocialInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelHealthInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelTaxPaymentPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSalaryFactor1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelContractSlrAmt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelWorkingSlrAmt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelExtraSalary1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRLevelNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRLevelName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLevelQualification);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLevelSkill);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLevelWorkExp);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLevelTraining);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel10);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel19);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRLevelDesc);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(1, 1);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(704, 562);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_txtHRLevelNo1
            // 
            this.fld_txtHRLevelNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelNo1.BOSDataMember = "HRLevelNo";
            this.fld_txtHRLevelNo1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelNo1.BOSDescription = null;
            this.fld_txtHRLevelNo1.BOSError = null;
            this.fld_txtHRLevelNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelNo1.BOSPropertyName = "Text";
            this.fld_txtHRLevelNo1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelNo1.Location = new System.Drawing.Point(89, 29);
            this.fld_txtHRLevelNo1.Name = "fld_txtHRLevelNo1";
            this.fld_txtHRLevelNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelNo1.Screen = null;
            this.fld_txtHRLevelNo1.Size = new System.Drawing.Size(192, 20);
            this.fld_txtHRLevelNo1.TabIndex = 1;
            this.fld_txtHRLevelNo1.Tag = "DC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(20, 32);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(38, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Mã vị trí";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(310, 32);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel6.TabIndex = 9;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Tên vị trí";
            // 
            // fld_txtHRLevelName1
            // 
            this.fld_txtHRLevelName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelName1.BOSDataMember = "HRLevelName";
            this.fld_txtHRLevelName1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelName1.BOSDescription = null;
            this.fld_txtHRLevelName1.BOSError = null;
            this.fld_txtHRLevelName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelName1.BOSPropertyName = "Text";
            this.fld_txtHRLevelName1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelName1.Location = new System.Drawing.Point(367, 29);
            this.fld_txtHRLevelName1.Name = "fld_txtHRLevelName1";
            this.fld_txtHRLevelName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelName1.Screen = null;
            this.fld_txtHRLevelName1.Size = new System.Drawing.Size(332, 20);
            this.fld_txtHRLevelName1.TabIndex = 2;
            this.fld_txtHRLevelName1.Tag = "DC";
            // 
            // fld_medHRLevelQualification
            // 
            this.fld_medHRLevelQualification.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelQualification.BOSDataMember = "HRLevelQualification";
            this.fld_medHRLevelQualification.BOSDataSource = "HRLevels";
            this.fld_medHRLevelQualification.BOSDescription = null;
            this.fld_medHRLevelQualification.BOSError = null;
            this.fld_medHRLevelQualification.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelQualification.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelQualification.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelQualification.BOSPropertyName = "Text";
            this.fld_medHRLevelQualification.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelQualification.Location = new System.Drawing.Point(89, 118);
            this.fld_medHRLevelQualification.Name = "fld_medHRLevelQualification";
            this.fld_medHRLevelQualification.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRLevelQualification.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRLevelQualification.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRLevelQualification.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRLevelQualification.Screen = null;
            this.fld_medHRLevelQualification.Size = new System.Drawing.Size(610, 86);
            this.fld_medHRLevelQualification.TabIndex = 4;
            this.fld_medHRLevelQualification.Tag = "DC";
            // 
            // fld_medHRLevelSkill
            // 
            this.fld_medHRLevelSkill.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelSkill.BOSDataMember = "HRLevelSkill";
            this.fld_medHRLevelSkill.BOSDataSource = "HRLevels";
            this.fld_medHRLevelSkill.BOSDescription = null;
            this.fld_medHRLevelSkill.BOSError = null;
            this.fld_medHRLevelSkill.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelSkill.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelSkill.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelSkill.BOSPropertyName = "Text";
            this.fld_medHRLevelSkill.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelSkill.Location = new System.Drawing.Point(89, 210);
            this.fld_medHRLevelSkill.Name = "fld_medHRLevelSkill";
            this.fld_medHRLevelSkill.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRLevelSkill.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRLevelSkill.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRLevelSkill.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRLevelSkill.Screen = null;
            this.fld_medHRLevelSkill.Size = new System.Drawing.Size(610, 130);
            this.fld_medHRLevelSkill.TabIndex = 5;
            this.fld_medHRLevelSkill.Tag = "DC";
            // 
            // fld_medHRLevelWorkExp
            // 
            this.fld_medHRLevelWorkExp.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelWorkExp.BOSDataMember = "HRLevelWorkExp";
            this.fld_medHRLevelWorkExp.BOSDataSource = "HRLevels";
            this.fld_medHRLevelWorkExp.BOSDescription = null;
            this.fld_medHRLevelWorkExp.BOSError = null;
            this.fld_medHRLevelWorkExp.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelWorkExp.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelWorkExp.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelWorkExp.BOSPropertyName = "Text";
            this.fld_medHRLevelWorkExp.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelWorkExp.Location = new System.Drawing.Point(89, 346);
            this.fld_medHRLevelWorkExp.Name = "fld_medHRLevelWorkExp";
            this.fld_medHRLevelWorkExp.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRLevelWorkExp.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRLevelWorkExp.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRLevelWorkExp.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRLevelWorkExp.Screen = null;
            this.fld_medHRLevelWorkExp.Size = new System.Drawing.Size(610, 84);
            this.fld_medHRLevelWorkExp.TabIndex = 6;
            this.fld_medHRLevelWorkExp.Tag = "DC";
            // 
            // fld_medHRLevelTraining
            // 
            this.fld_medHRLevelTraining.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelTraining.BOSDataMember = "HRLevelTraining";
            this.fld_medHRLevelTraining.BOSDataSource = "HRLevels";
            this.fld_medHRLevelTraining.BOSDescription = null;
            this.fld_medHRLevelTraining.BOSError = null;
            this.fld_medHRLevelTraining.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelTraining.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelTraining.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelTraining.BOSPropertyName = "Text";
            this.fld_medHRLevelTraining.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelTraining.Location = new System.Drawing.Point(89, 436);
            this.fld_medHRLevelTraining.Name = "fld_medHRLevelTraining";
            this.fld_medHRLevelTraining.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRLevelTraining.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRLevelTraining.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRLevelTraining.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRLevelTraining.Screen = null;
            this.fld_medHRLevelTraining.Size = new System.Drawing.Size(610, 118);
            this.fld_medHRLevelTraining.TabIndex = 7;
            this.fld_medHRLevelTraining.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.Location = new System.Drawing.Point(20, 141);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel7.TabIndex = 15;
            this.fld_lblLabel7.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel7.Text = "Trình độ";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Location = new System.Drawing.Point(20, 249);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel8.TabIndex = 16;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Kỹ năng";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.Location = new System.Drawing.Point(20, 366);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel9.TabIndex = 17;
            this.fld_lblLabel9.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel9.Text = "Kinh nghiệm";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.Location = new System.Drawing.Point(20, 459);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel10.TabIndex = 18;
            this.fld_lblLabel10.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel10.Text = "PP đào tạo";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.Location = new System.Drawing.Point(20, 77);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel19.TabIndex = 35;
            this.fld_lblLabel19.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel19.Text = "Diễn giải";
            // 
            // fld_medHRLevelDesc
            // 
            this.fld_medHRLevelDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelDesc.BOSDataMember = "HRLevelDesc";
            this.fld_medHRLevelDesc.BOSDataSource = "HRLevels";
            this.fld_medHRLevelDesc.BOSDescription = null;
            this.fld_medHRLevelDesc.BOSError = null;
            this.fld_medHRLevelDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelDesc.BOSPropertyName = "Text";
            this.fld_medHRLevelDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRLevelDesc.Location = new System.Drawing.Point(89, 54);
            this.fld_medHRLevelDesc.Name = "fld_medHRLevelDesc";
            this.fld_medHRLevelDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRLevelDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRLevelDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRLevelDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRLevelDesc.Screen = null;
            this.fld_medHRLevelDesc.Size = new System.Drawing.Size(610, 60);
            this.fld_medHRLevelDesc.TabIndex = 3;
            this.fld_medHRLevelDesc.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelSocialInsPaymentPercent);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelHealthInsPaymentPercent);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelOutOfWorkInsPaymentPercent);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelTaxPaymentPercent);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel11);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelSalaryFactor1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelContractSlrAmt1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelWorkingSlrAmt1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtHRLevelExtraSalary1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel17);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel18);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(711, 1);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(282, 562);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Text = "Cơ cấu thu nhập";
            this.fld_grcGroupControl1.Visible = false;
            // 
            // fld_txtHRLevelSocialInsPaymentPercent
            // 
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSDataMember = "HRLevelSocialInsPaymentPercent";
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSDescription = null;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSError = null;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSocialInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHRLevelSocialInsPaymentPercent.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSocialInsPaymentPercent.Location = new System.Drawing.Point(105, 123);
            this.fld_txtHRLevelSocialInsPaymentPercent.Name = "fld_txtHRLevelSocialInsPaymentPercent";
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelSocialInsPaymentPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelSocialInsPaymentPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelSocialInsPaymentPercent.Screen = null;
            this.fld_txtHRLevelSocialInsPaymentPercent.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelSocialInsPaymentPercent.TabIndex = 5;
            this.fld_txtHRLevelSocialInsPaymentPercent.Tag = "DC";
            // 
            // fld_txtHRLevelHealthInsPaymentPercent
            // 
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSDataMember = "HRLevelHealthInsPaymentPercent";
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSDescription = null;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSError = null;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelHealthInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHRLevelHealthInsPaymentPercent.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelHealthInsPaymentPercent.Location = new System.Drawing.Point(105, 147);
            this.fld_txtHRLevelHealthInsPaymentPercent.Name = "fld_txtHRLevelHealthInsPaymentPercent";
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelHealthInsPaymentPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelHealthInsPaymentPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelHealthInsPaymentPercent.Screen = null;
            this.fld_txtHRLevelHealthInsPaymentPercent.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelHealthInsPaymentPercent.TabIndex = 6;
            this.fld_txtHRLevelHealthInsPaymentPercent.Tag = "DC";
            // 
            // fld_txtHRLevelOutOfWorkInsPaymentPercent
            // 
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSDataMember = "HRLevelOutOfWorkInsPaymentPercent";
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSDescription = null;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSError = null;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Location = new System.Drawing.Point(105, 171);
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Name = "fld_txtHRLevelOutOfWorkInsPaymentPercent";
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Screen = null;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.TabIndex = 7;
            this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Tag = "DC";
            // 
            // fld_txtHRLevelTaxPaymentPercent
            // 
            this.fld_txtHRLevelTaxPaymentPercent.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelTaxPaymentPercent.BOSDataMember = "HRLevelTaxPaymentPercent";
            this.fld_txtHRLevelTaxPaymentPercent.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelTaxPaymentPercent.BOSDescription = null;
            this.fld_txtHRLevelTaxPaymentPercent.BOSError = null;
            this.fld_txtHRLevelTaxPaymentPercent.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelTaxPaymentPercent.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelTaxPaymentPercent.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelTaxPaymentPercent.BOSPropertyName = "Text";
            this.fld_txtHRLevelTaxPaymentPercent.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelTaxPaymentPercent.Location = new System.Drawing.Point(105, 195);
            this.fld_txtHRLevelTaxPaymentPercent.Name = "fld_txtHRLevelTaxPaymentPercent";
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelTaxPaymentPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelTaxPaymentPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelTaxPaymentPercent.Screen = null;
            this.fld_txtHRLevelTaxPaymentPercent.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelTaxPaymentPercent.TabIndex = 8;
            this.fld_txtHRLevelTaxPaymentPercent.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.Location = new System.Drawing.Point(20, 126);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel11.TabIndex = 23;
            this.fld_lblLabel11.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel11.Text = "BHXH (%)";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.Location = new System.Drawing.Point(20, 150);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel12.TabIndex = 24;
            this.fld_lblLabel12.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel12.Text = "BHYT (%)";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.Location = new System.Drawing.Point(20, 174);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 25;
            this.fld_lblLabel13.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel13.Text = "BHTN (%)";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.Location = new System.Drawing.Point(20, 198);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(46, 13);
            this.fld_lblLabel14.TabIndex = 26;
            this.fld_lblLabel14.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel14.Text = "Thuế (%)";
            // 
            // fld_txtHRLevelSalaryFactor1
            // 
            this.fld_txtHRLevelSalaryFactor1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSalaryFactor1.BOSDataMember = "HRLevelSalaryFactor";
            this.fld_txtHRLevelSalaryFactor1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelSalaryFactor1.BOSDescription = null;
            this.fld_txtHRLevelSalaryFactor1.BOSError = null;
            this.fld_txtHRLevelSalaryFactor1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSalaryFactor1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSalaryFactor1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSalaryFactor1.BOSPropertyName = "Text";
            this.fld_txtHRLevelSalaryFactor1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelSalaryFactor1.Location = new System.Drawing.Point(105, 51);
            this.fld_txtHRLevelSalaryFactor1.Name = "fld_txtHRLevelSalaryFactor1";
            this.fld_txtHRLevelSalaryFactor1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelSalaryFactor1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelSalaryFactor1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelSalaryFactor1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelSalaryFactor1.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelSalaryFactor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelSalaryFactor1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelSalaryFactor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelSalaryFactor1.Screen = null;
            this.fld_txtHRLevelSalaryFactor1.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelSalaryFactor1.TabIndex = 2;
            this.fld_txtHRLevelSalaryFactor1.Tag = "DC";
            // 
            // fld_txtHRLevelContractSlrAmt1
            // 
            this.fld_txtHRLevelContractSlrAmt1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelContractSlrAmt1.BOSDataMember = "HRLevelContractSlrAmt";
            this.fld_txtHRLevelContractSlrAmt1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelContractSlrAmt1.BOSDescription = null;
            this.fld_txtHRLevelContractSlrAmt1.BOSError = null;
            this.fld_txtHRLevelContractSlrAmt1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelContractSlrAmt1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelContractSlrAmt1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelContractSlrAmt1.BOSPropertyName = "Text";
            this.fld_txtHRLevelContractSlrAmt1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelContractSlrAmt1.Location = new System.Drawing.Point(105, 27);
            this.fld_txtHRLevelContractSlrAmt1.Name = "fld_txtHRLevelContractSlrAmt1";
            this.fld_txtHRLevelContractSlrAmt1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelContractSlrAmt1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelContractSlrAmt1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelContractSlrAmt1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelContractSlrAmt1.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelContractSlrAmt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelContractSlrAmt1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelContractSlrAmt1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelContractSlrAmt1.Screen = null;
            this.fld_txtHRLevelContractSlrAmt1.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelContractSlrAmt1.TabIndex = 1;
            this.fld_txtHRLevelContractSlrAmt1.Tag = "DC";
            // 
            // fld_txtHRLevelWorkingSlrAmt1
            // 
            this.fld_txtHRLevelWorkingSlrAmt1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSDataMember = "HRLevelWorkingSlrAmt";
            this.fld_txtHRLevelWorkingSlrAmt1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelWorkingSlrAmt1.BOSDescription = null;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSError = null;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelWorkingSlrAmt1.BOSPropertyName = "Text";
            this.fld_txtHRLevelWorkingSlrAmt1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelWorkingSlrAmt1.Location = new System.Drawing.Point(105, 75);
            this.fld_txtHRLevelWorkingSlrAmt1.Name = "fld_txtHRLevelWorkingSlrAmt1";
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelWorkingSlrAmt1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelWorkingSlrAmt1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelWorkingSlrAmt1.Screen = null;
            this.fld_txtHRLevelWorkingSlrAmt1.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelWorkingSlrAmt1.TabIndex = 3;
            this.fld_txtHRLevelWorkingSlrAmt1.Tag = "DC";
            // 
            // fld_txtHRLevelExtraSalary1
            // 
            this.fld_txtHRLevelExtraSalary1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelExtraSalary1.BOSDataMember = "HRLevelExtraSalary1";
            this.fld_txtHRLevelExtraSalary1.BOSDataSource = "HRLevels";
            this.fld_txtHRLevelExtraSalary1.BOSDescription = null;
            this.fld_txtHRLevelExtraSalary1.BOSError = null;
            this.fld_txtHRLevelExtraSalary1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelExtraSalary1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelExtraSalary1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelExtraSalary1.BOSPropertyName = "Text";
            this.fld_txtHRLevelExtraSalary1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRLevelExtraSalary1.Location = new System.Drawing.Point(105, 99);
            this.fld_txtHRLevelExtraSalary1.Name = "fld_txtHRLevelExtraSalary1";
            this.fld_txtHRLevelExtraSalary1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRLevelExtraSalary1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRLevelExtraSalary1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRLevelExtraSalary1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRLevelExtraSalary1.Properties.Mask.EditMask = "n";
            this.fld_txtHRLevelExtraSalary1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRLevelExtraSalary1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRLevelExtraSalary1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRLevelExtraSalary1.Screen = null;
            this.fld_txtHRLevelExtraSalary1.Size = new System.Drawing.Size(170, 20);
            this.fld_txtHRLevelExtraSalary1.TabIndex = 4;
            this.fld_txtHRLevelExtraSalary1.Tag = "DC";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.Location = new System.Drawing.Point(20, 30);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel15.TabIndex = 31;
            this.fld_lblLabel15.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel15.Text = "Lương căn bản";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.Location = new System.Drawing.Point(20, 54);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel16.TabIndex = 32;
            this.fld_lblLabel16.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel16.Text = "Hệ số lương";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.Location = new System.Drawing.Point(20, 78);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel17.TabIndex = 33;
            this.fld_lblLabel17.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel17.Text = "Lương công việc";
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.Location = new System.Drawing.Point(20, 102);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel18.TabIndex = 34;
            this.fld_lblLabel18.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel18.Text = "Lương phụ cấp";
            // 
            // DMHRLV100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(709, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Name = "DMHRLV100";
            this.Text = "Thông Tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelQualification.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelSkill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelWorkExp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelTraining.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRLevelDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSocialInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelHealthInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelOutOfWorkInsPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelTaxPaymentPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelSalaryFactor1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelContractSlrAmt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelWorkingSlrAmt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRLevelExtraSalary1.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
	}
}
