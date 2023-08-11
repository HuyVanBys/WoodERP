using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Candidate.UI
{
	/// <summary>
	/// Summary description for SRCM100
	/// </summary>
	partial class SMCM100
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
            this.fld_txtHRCandidateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRCandidateName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCandidateContactAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRCandidateIDNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRCandiadates = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteCandidateCreateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteCandidateCreateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRCandidateGenderCombo = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateContactAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandiadates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRCandidateGenderCombo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRCandidateNo
            // 
            this.fld_txtHRCandidateNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateNo.BOSDataMember = "HRCandidateNo";
            this.fld_txtHRCandidateNo.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateNo.BOSDescription = null;
            this.fld_txtHRCandidateNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateNo.BOSPropertyName = "Text";
            this.fld_txtHRCandidateNo.Location = new System.Drawing.Point(116, 9);
            this.fld_txtHRCandidateNo.Name = "fld_txtHRCandidateNo";
            this.fld_txtHRCandidateNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateNo.Screen = null;
            this.fld_txtHRCandidateNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRCandidateNo.TabIndex = 25;
            this.fld_txtHRCandidateNo.Tag = "SC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(24, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel2.TabIndex = 30;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã nhân viên";
            // 
            // fld_txtHRCandidateName
            // 
            this.fld_txtHRCandidateName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateName.BOSDataMember = "HRCandidateName";
            this.fld_txtHRCandidateName.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateName.BOSDescription = null;
            this.fld_txtHRCandidateName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateName.BOSPropertyName = "Text";
            this.fld_txtHRCandidateName.Location = new System.Drawing.Point(116, 35);
            this.fld_txtHRCandidateName.Name = "fld_txtHRCandidateName";
            this.fld_txtHRCandidateName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateName.Screen = null;
            this.fld_txtHRCandidateName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRCandidateName.TabIndex = 26;
            this.fld_txtHRCandidateName.Tag = "SC";
            // 
            // fld_txtHRCandidateContactAddressLine1
            // 
            this.fld_txtHRCandidateContactAddressLine1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateContactAddressLine1.BOSDataMember = "HRCandidateContactAddressLine1";
            this.fld_txtHRCandidateContactAddressLine1.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateContactAddressLine1.BOSDescription = null;
            this.fld_txtHRCandidateContactAddressLine1.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateContactAddressLine1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateContactAddressLine1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateContactAddressLine1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateContactAddressLine1.BOSPropertyName = "Text";
            this.fld_txtHRCandidateContactAddressLine1.Location = new System.Drawing.Point(116, 61);
            this.fld_txtHRCandidateContactAddressLine1.Name = "fld_txtHRCandidateContactAddressLine1";
            this.fld_txtHRCandidateContactAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateContactAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateContactAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateContactAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateContactAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateContactAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateContactAddressLine1.Screen = null;
            this.fld_txtHRCandidateContactAddressLine1.Size = new System.Drawing.Size(451, 20);
            this.fld_txtHRCandidateContactAddressLine1.TabIndex = 27;
            this.fld_txtHRCandidateContactAddressLine1.Tag = "SC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(24, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel4.TabIndex = 33;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Tên nhân viên";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(326, 15);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(38, 13);
            this.fld_lblLabel9.TabIndex = 31;
            this.fld_lblLabel9.Tag = "SI";
            this.fld_lblLabel9.Text = "Giới tính";
            // 
            // fld_txtHRCandidateIDNumber
            // 
            this.fld_txtHRCandidateIDNumber.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateIDNumber.BOSDataMember = "HRCandidateIDNumber";
            this.fld_txtHRCandidateIDNumber.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateIDNumber.BOSDescription = null;
            this.fld_txtHRCandidateIDNumber.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateIDNumber.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateIDNumber.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateIDNumber.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCandidateIDNumber.BOSPropertyName = "Text";
            this.fld_txtHRCandidateIDNumber.Location = new System.Drawing.Point(415, 38);
            this.fld_txtHRCandidateIDNumber.Name = "fld_txtHRCandidateIDNumber";
            this.fld_txtHRCandidateIDNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateIDNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateIDNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateIDNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateIDNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateIDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateIDNumber.Screen = null;
            this.fld_txtHRCandidateIDNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRCandidateIDNumber.TabIndex = 29;
            this.fld_txtHRCandidateIDNumber.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(24, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 32;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Địa chỉ";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(326, 41);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(44, 13);
            this.fld_lblLabel11.TabIndex = 34;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Số CMND";
            // 
            // fld_dgcHRCandiadates
            // 
            this.fld_dgcHRCandiadates.BOSComment = null;
            this.fld_dgcHRCandiadates.BOSDataMember = null;
            this.fld_dgcHRCandiadates.BOSDataSource = "HRCandidates";
            this.fld_dgcHRCandiadates.BOSDescription = null;
            this.fld_dgcHRCandiadates.BOSError = null;
            this.fld_dgcHRCandiadates.BOSFieldGroup = null;
            this.fld_dgcHRCandiadates.BOSFieldRelation = null;
            this.fld_dgcHRCandiadates.BOSPrivilege = null;
            this.fld_dgcHRCandiadates.BOSPropertyName = null;
            this.fld_dgcHRCandiadates.Location = new System.Drawing.Point(36, 355);
            this.fld_dgcHRCandiadates.MenuManager = this.screenToolbar;
            this.fld_dgcHRCandiadates.Name = "fld_dgcHRCandiadates";
            this.fld_dgcHRCandiadates.Screen = null;
            this.fld_dgcHRCandiadates.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRCandiadates.TabIndex = 35;
            this.fld_dgcHRCandiadates.Tag = "SR";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(24, 90);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel14.TabIndex = 128;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày tạo từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(326, 90);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 129;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dteCandidateCreateFrom
            // 
            this.fld_dteCandidateCreateFrom.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateFrom.BOSDataMember = "CandidateCreateFrom";
            this.fld_dteCandidateCreateFrom.BOSDataSource = "HRCandidates";
            this.fld_dteCandidateCreateFrom.BOSDescription = null;
            this.fld_dteCandidateCreateFrom.BOSError = null;
            this.fld_dteCandidateCreateFrom.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateFrom.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateFrom.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateFrom.BOSPropertyName = "EditValue";
            this.fld_dteCandidateCreateFrom.EditValue = null;
            this.fld_dteCandidateCreateFrom.Location = new System.Drawing.Point(116, 87);
            this.fld_dteCandidateCreateFrom.Name = "fld_dteCandidateCreateFrom";
            this.fld_dteCandidateCreateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteCandidateCreateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteCandidateCreateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteCandidateCreateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteCandidateCreateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCandidateCreateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCandidateCreateFrom.Screen = null;
            this.fld_dteCandidateCreateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteCandidateCreateFrom.TabIndex = 126;
            this.fld_dteCandidateCreateFrom.Tag = "SC";
            // 
            // fld_dteCandidateCreateTo
            // 
            this.fld_dteCandidateCreateTo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateTo.BOSDataMember = "CandidateCreateTo";
            this.fld_dteCandidateCreateTo.BOSDataSource = "HRCandidates";
            this.fld_dteCandidateCreateTo.BOSDescription = null;
            this.fld_dteCandidateCreateTo.BOSError = null;
            this.fld_dteCandidateCreateTo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateTo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateTo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteCandidateCreateTo.BOSPropertyName = "EditValue";
            this.fld_dteCandidateCreateTo.EditValue = null;
            this.fld_dteCandidateCreateTo.Location = new System.Drawing.Point(415, 87);
            this.fld_dteCandidateCreateTo.Name = "fld_dteCandidateCreateTo";
            this.fld_dteCandidateCreateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteCandidateCreateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteCandidateCreateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteCandidateCreateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteCandidateCreateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCandidateCreateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCandidateCreateTo.Screen = null;
            this.fld_dteCandidateCreateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteCandidateCreateTo.TabIndex = 127;
            this.fld_dteCandidateCreateTo.Tag = "SC";
            // 
            // fld_lkeHRCandidateGenderCombo
            // 
            this.fld_lkeHRCandidateGenderCombo.BOSAllowAddNew = false;
            this.fld_lkeHRCandidateGenderCombo.BOSAllowDummy = true;
            this.fld_lkeHRCandidateGenderCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSDataMember = "HRCandidateGenderCombo";
            this.fld_lkeHRCandidateGenderCombo.BOSDataSource = "HREmployees";
            this.fld_lkeHRCandidateGenderCombo.BOSDescription = null;
            this.fld_lkeHRCandidateGenderCombo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSPropertyName = "EditValue";
            this.fld_lkeHRCandidateGenderCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.Location = new System.Drawing.Point(415, 12);
            this.fld_lkeHRCandidateGenderCombo.Name = "fld_lkeHRCandidateGenderCombo";
            this.fld_lkeHRCandidateGenderCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRCandidateGenderCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRCandidateGenderCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRCandidateGenderCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRCandidateGenderCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRCandidateGenderCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRCandidateGenderCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRCandidateGenderCombo.Screen = null;
            this.fld_lkeHRCandidateGenderCombo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRCandidateGenderCombo.TabIndex = 130;
            this.fld_lkeHRCandidateGenderCombo.Tag = "SC";
            // 
            // SMCM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeHRCandidateGenderCombo);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteCandidateCreateFrom);
            this.Controls.Add(this.fld_dteCandidateCreateTo);
            this.Controls.Add(this.fld_dgcHRCandiadates);
            this.Controls.Add(this.fld_txtHRCandidateNo);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtHRCandidateName);
            this.Controls.Add(this.fld_txtHRCandidateContactAddressLine1);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lblLabel9);
            this.Controls.Add(this.fld_txtHRCandidateIDNumber);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Name = "SMCM100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRCandidateIDNumber, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel9, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtHRCandidateContactAddressLine1, 0);
            this.Controls.SetChildIndex(this.fld_txtHRCandidateName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_txtHRCandidateNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRCandiadates, 0);
            this.Controls.SetChildIndex(this.fld_dteCandidateCreateTo, 0);
            this.Controls.SetChildIndex(this.fld_dteCandidateCreateFrom, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRCandidateGenderCombo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateContactAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandiadates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCandidateCreateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRCandidateGenderCombo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRCandidateNo;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSTextBox fld_txtHRCandidateName;
        private BOSComponent.BOSTextBox fld_txtHRCandidateContactAddressLine1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSTextBox fld_txtHRCandidateIDNumber;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRCandiadates;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteCandidateCreateFrom;
        private BOSComponent.BOSDateEdit fld_dteCandidateCreateTo;
        private BOSComponent.BOSLookupEdit fld_lkeHRCandidateGenderCombo;
	}
}
