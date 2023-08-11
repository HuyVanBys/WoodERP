using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Candidate.UI
{
	/// <summary>
	/// Summary description for DMCM100
	/// </summary>
	partial class DMCM102
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcHRCandidateCertificates = new BOSERP.Modules.Candidate.HRCandidateCertificatesGridControl();
            this.fld_dgvHREmployeeTranfers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.HRCandidateCertificateName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnEditCertificate = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeleteCertificate = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddCertificate = new BOSComponent.BOSButton(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox10 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.bosDateEdit5 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRCandidateCertificateType = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox25 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox28 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox27 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCandidateTel1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox16 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox12 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox19 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox15 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCandidateWeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox18 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox14 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox17 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox13 = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeHRCandidateSalaryExpected = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox20 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRCandidateSubmitType = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRCandidateAdditionalCV = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosCheckEdit3 = new BOSComponent.BOSCheckEdit(this.components);
            this.bosCheckEdit2 = new BOSComponent.BOSCheckEdit(this.components);
            this.bosDateEdit4 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRCandidateWorkingPalce = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRCandidateYearWorking = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosTextBox22 = new BOSComponent.BOSTextBox(this.components);
            this.bosDateEdit3 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRCandidateIDCardDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosTextBox21 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox24 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox23 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox26 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCandidateSpecialize = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRCandidateExperience = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandidateCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeTranfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).BeginInit();
            this.bosGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRCandidateCertificateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit5.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateCertificateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox25.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox28.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox27.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateTel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox19.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRCandidateSalaryExpected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox20.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateSubmitType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRCandidateAdditionalCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateWorkingPalce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateYearWorking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRCandidateIDCardDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRCandidateIDCardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox24.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox26.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateSpecialize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateExperience.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_dgcHRCandidateCertificates);
            this.bosPanel1.Controls.Add(this.bosGroupControl4);
            this.bosPanel1.Controls.Add(this.bosGroupControl3);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(932, 746);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_dgcHRCandidateCertificates
            // 
            this.fld_dgcHRCandidateCertificates.AllowDrop = true;
            this.fld_dgcHRCandidateCertificates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRCandidateCertificates.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.BOSDataSource = "HRCandidateCertificates";
            this.fld_dgcHRCandidateCertificates.BOSDescription = null;
            this.fld_dgcHRCandidateCertificates.BOSError = null;
            this.fld_dgcHRCandidateCertificates.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.BOSGridType = null;
            this.fld_dgcHRCandidateCertificates.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRCandidateCertificates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRCandidateCertificates.Location = new System.Drawing.Point(3, 541);
            this.fld_dgcHRCandidateCertificates.MainView = this.fld_dgvHREmployeeTranfers;
            this.fld_dgcHRCandidateCertificates.Name = "fld_dgcHRCandidateCertificates";
            this.fld_dgcHRCandidateCertificates.PrintReport = false;
            this.fld_dgcHRCandidateCertificates.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRCandidateCertificates, true);
            this.fld_dgcHRCandidateCertificates.Size = new System.Drawing.Size(926, 193);
            this.fld_dgcHRCandidateCertificates.TabIndex = 7;
            this.fld_dgcHRCandidateCertificates.Tag = "DC";
            this.fld_dgcHRCandidateCertificates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeTranfers});
            // 
            // fld_dgvHREmployeeTranfers
            // 
            this.fld_dgvHREmployeeTranfers.GridControl = this.fld_dgcHRCandidateCertificates;
            this.fld_dgvHREmployeeTranfers.Name = "fld_dgvHREmployeeTranfers";
            this.fld_dgvHREmployeeTranfers.PaintStyleName = "Office2003";
            // 
            // bosGroupControl4
            // 
            this.bosGroupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl4.BOSComment = null;
            this.bosGroupControl4.BOSDataMember = null;
            this.bosGroupControl4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosGroupControl4.BOSDescription = null;
            this.bosGroupControl4.BOSError = null;
            this.bosGroupControl4.BOSFieldGroup = null;
            this.bosGroupControl4.BOSFieldRelation = null;
            this.bosGroupControl4.BOSPrivilege = null;
            this.bosGroupControl4.BOSPropertyName = null;
            this.bosGroupControl4.Controls.Add(this.HRCandidateCertificateName);
            this.bosGroupControl4.Controls.Add(this.fld_btnEditCertificate);
            this.bosGroupControl4.Controls.Add(this.fld_btnDeleteCertificate);
            this.bosGroupControl4.Controls.Add(this.fld_btnAddCertificate);
            this.bosGroupControl4.Controls.Add(this.bosLabel35);
            this.bosGroupControl4.Controls.Add(this.bosTextBox10);
            this.bosGroupControl4.Controls.Add(this.bosLabel19);
            this.bosGroupControl4.Controls.Add(this.bosCheckEdit1);
            this.bosGroupControl4.Controls.Add(this.bosDateEdit5);
            this.bosGroupControl4.Controls.Add(this.fld_txtHRCandidateCertificateType);
            this.bosGroupControl4.Controls.Add(this.bosTextBox25);
            this.bosGroupControl4.Controls.Add(this.bosLabel34);
            this.bosGroupControl4.Controls.Add(this.bosTextBox8);
            this.bosGroupControl4.Controls.Add(this.bosLabel14);
            this.bosGroupControl4.Controls.Add(this.bosLabel16);
            this.bosGroupControl4.Controls.Add(this.bosTextBox9);
            this.bosGroupControl4.Controls.Add(this.bosLabel17);
            this.bosGroupControl4.Controls.Add(this.bosLabel18);
            this.bosGroupControl4.Controls.Add(this.bosTextBox28);
            this.bosGroupControl4.Controls.Add(this.bosTextBox27);
            this.bosGroupControl4.Controls.Add(this.fld_txtHRCandidateTel1);
            this.bosGroupControl4.Controls.Add(this.bosLabel37);
            this.bosGroupControl4.Controls.Add(this.bosLabel36);
            this.bosGroupControl4.Controls.Add(this.bosLabel4);
            this.bosGroupControl4.Location = new System.Drawing.Point(3, 405);
            this.bosGroupControl4.Name = "bosGroupControl4";
            this.bosGroupControl4.Screen = null;
            this.bosGroupControl4.Size = new System.Drawing.Size(920, 130);
            this.bosGroupControl4.TabIndex = 3;
            this.bosGroupControl4.Text = "Trình độ học vấn";
            // 
            // HRCandidateCertificateName
            // 
            this.HRCandidateCertificateName.BOSComment = null;
            this.HRCandidateCertificateName.BOSDataMember = "HRCandidateCertificateName";
            this.HRCandidateCertificateName.BOSDataSource = "HRCandidateCertificates";
            this.HRCandidateCertificateName.BOSDescription = null;
            this.HRCandidateCertificateName.BOSError = null;
            this.HRCandidateCertificateName.BOSFieldGroup = null;
            this.HRCandidateCertificateName.BOSFieldRelation = null;
            this.HRCandidateCertificateName.BOSPrivilege = null;
            this.HRCandidateCertificateName.BOSPropertyName = "Text";
            this.HRCandidateCertificateName.Location = new System.Drawing.Point(360, 77);
            this.HRCandidateCertificateName.Name = "HRCandidateCertificateName";
            this.HRCandidateCertificateName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HRCandidateCertificateName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HRCandidateCertificateName.Properties.Appearance.Options.UseBackColor = true;
            this.HRCandidateCertificateName.Properties.Appearance.Options.UseForeColor = true;
            this.HRCandidateCertificateName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HRCandidateCertificateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HRCandidateCertificateName.Screen = null;
            this.HRCandidateCertificateName.Size = new System.Drawing.Size(343, 20);
            this.HRCandidateCertificateName.TabIndex = 5;
            this.HRCandidateCertificateName.Tag = "DC";
            // 
            // fld_btnEditCertificate
            // 
            this.fld_btnEditCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEditCertificate.BOSComment = null;
            this.fld_btnEditCertificate.BOSDataMember = null;
            this.fld_btnEditCertificate.BOSDataSource = null;
            this.fld_btnEditCertificate.BOSDescription = null;
            this.fld_btnEditCertificate.BOSError = null;
            this.fld_btnEditCertificate.BOSFieldGroup = null;
            this.fld_btnEditCertificate.BOSFieldRelation = null;
            this.fld_btnEditCertificate.BOSPrivilege = null;
            this.fld_btnEditCertificate.BOSPropertyName = null;
            this.fld_btnEditCertificate.Location = new System.Drawing.Point(785, 96);
            this.fld_btnEditCertificate.Name = "fld_btnEditCertificate";
            this.fld_btnEditCertificate.Screen = null;
            this.fld_btnEditCertificate.Size = new System.Drawing.Size(60, 27);
            this.fld_btnEditCertificate.TabIndex = 5;
            this.fld_btnEditCertificate.Text = "Sửa";
            this.fld_btnEditCertificate.Click += new System.EventHandler(this.fld_btnEditCertificate_Click);
            // 
            // fld_btnDeleteCertificate
            // 
            this.fld_btnDeleteCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDeleteCertificate.BOSComment = null;
            this.fld_btnDeleteCertificate.BOSDataMember = null;
            this.fld_btnDeleteCertificate.BOSDataSource = null;
            this.fld_btnDeleteCertificate.BOSDescription = null;
            this.fld_btnDeleteCertificate.BOSError = null;
            this.fld_btnDeleteCertificate.BOSFieldGroup = null;
            this.fld_btnDeleteCertificate.BOSFieldRelation = null;
            this.fld_btnDeleteCertificate.BOSPrivilege = null;
            this.fld_btnDeleteCertificate.BOSPropertyName = null;
            this.fld_btnDeleteCertificate.Location = new System.Drawing.Point(851, 96);
            this.fld_btnDeleteCertificate.Name = "fld_btnDeleteCertificate";
            this.fld_btnDeleteCertificate.Screen = null;
            this.fld_btnDeleteCertificate.Size = new System.Drawing.Size(64, 27);
            this.fld_btnDeleteCertificate.TabIndex = 6;
            this.fld_btnDeleteCertificate.Text = "Xóa";
            this.fld_btnDeleteCertificate.Click += new System.EventHandler(this.fld_btnDeleteCertificate_Click);
            // 
            // fld_btnAddCertificate
            // 
            this.fld_btnAddCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddCertificate.BOSComment = null;
            this.fld_btnAddCertificate.BOSDataMember = null;
            this.fld_btnAddCertificate.BOSDataSource = null;
            this.fld_btnAddCertificate.BOSDescription = null;
            this.fld_btnAddCertificate.BOSError = null;
            this.fld_btnAddCertificate.BOSFieldGroup = null;
            this.fld_btnAddCertificate.BOSFieldRelation = null;
            this.fld_btnAddCertificate.BOSPrivilege = null;
            this.fld_btnAddCertificate.BOSPropertyName = null;
            this.fld_btnAddCertificate.Location = new System.Drawing.Point(711, 96);
            this.fld_btnAddCertificate.Name = "fld_btnAddCertificate";
            this.fld_btnAddCertificate.Screen = null;
            this.fld_btnAddCertificate.Size = new System.Drawing.Size(68, 27);
            this.fld_btnAddCertificate.TabIndex = 4;
            this.fld_btnAddCertificate.Text = "Thêm";
            this.fld_btnAddCertificate.Click += new System.EventHandler(this.fld_btnAddCertificate_Click);
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(281, 80);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(65, 13);
            this.bosLabel35.TabIndex = 133;
            this.bosLabel35.Text = "Tên bằng cấp";
            // 
            // bosTextBox10
            // 
            this.bosTextBox10.BOSComment = null;
            this.bosTextBox10.BOSDataMember = "HRCandidateCertificateClassification";
            this.bosTextBox10.BOSDataSource = "HRCandidateCertificates";
            this.bosTextBox10.BOSDescription = null;
            this.bosTextBox10.BOSError = null;
            this.bosTextBox10.BOSFieldGroup = null;
            this.bosTextBox10.BOSFieldRelation = null;
            this.bosTextBox10.BOSPrivilege = null;
            this.bosTextBox10.BOSPropertyName = "Text";
            this.bosTextBox10.Location = new System.Drawing.Point(153, 103);
            this.bosTextBox10.Name = "bosTextBox10";
            this.bosTextBox10.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox10.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox10.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox10.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox10, true);
            this.bosTextBox10.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox10.TabIndex = 6;
            this.bosTextBox10.Tag = "DC";
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
            this.bosLabel19.Location = new System.Drawing.Point(20, 106);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(37, 13);
            this.bosLabel19.TabIndex = 133;
            this.bosLabel19.Text = "Xếp loại";
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = "HRCandidateGraduateStudent";
            this.bosCheckEdit1.BOSDataSource = "HRCandidates";
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = "EditValue";
            this.bosCheckEdit1.Location = new System.Drawing.Point(709, 51);
            this.bosCheckEdit1.MenuManager = this.screenToolbar;
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Sinh viên mới ra trường";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(163, 19);
            this.bosCheckEdit1.TabIndex = 2;
            this.bosCheckEdit1.Tag = "DC";
            // 
            // bosDateEdit5
            // 
            this.bosDateEdit5.BOSComment = null;
            this.bosDateEdit5.BOSDataMember = "HRCandidateCertificateIssuedDate";
            this.bosDateEdit5.BOSDataSource = "HRCandidateCertificates";
            this.bosDateEdit5.BOSDescription = null;
            this.bosDateEdit5.BOSError = null;
            this.bosDateEdit5.BOSFieldGroup = null;
            this.bosDateEdit5.BOSFieldRelation = null;
            this.bosDateEdit5.BOSPrivilege = null;
            this.bosDateEdit5.BOSPropertyName = "EditValue";
            this.bosDateEdit5.EditValue = null;
            this.bosDateEdit5.Location = new System.Drawing.Point(360, 103);
            this.bosDateEdit5.Name = "bosDateEdit5";
            this.bosDateEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit5.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit5.Screen = null;
            this.bosDateEdit5.Size = new System.Drawing.Size(113, 20);
            this.bosDateEdit5.TabIndex = 7;
            this.bosDateEdit5.Tag = "DC";
            // 
            // fld_txtHRCandidateCertificateType
            // 
            this.fld_txtHRCandidateCertificateType.BOSComment = null;
            this.fld_txtHRCandidateCertificateType.BOSDataMember = "HRCandidateCertificateType";
            this.fld_txtHRCandidateCertificateType.BOSDataSource = "HRCandidateCertificates";
            this.fld_txtHRCandidateCertificateType.BOSDescription = null;
            this.fld_txtHRCandidateCertificateType.BOSError = null;
            this.fld_txtHRCandidateCertificateType.BOSFieldGroup = null;
            this.fld_txtHRCandidateCertificateType.BOSFieldRelation = null;
            this.fld_txtHRCandidateCertificateType.BOSPrivilege = null;
            this.fld_txtHRCandidateCertificateType.BOSPropertyName = "Text";
            this.fld_txtHRCandidateCertificateType.Location = new System.Drawing.Point(153, 77);
            this.fld_txtHRCandidateCertificateType.Name = "fld_txtHRCandidateCertificateType";
            this.fld_txtHRCandidateCertificateType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateCertificateType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateCertificateType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateCertificateType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateCertificateType.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateCertificateType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateCertificateType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateCertificateType, true);
            this.fld_txtHRCandidateCertificateType.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateCertificateType.TabIndex = 4;
            this.fld_txtHRCandidateCertificateType.Tag = "DC";
            // 
            // bosTextBox25
            // 
            this.bosTextBox25.BOSComment = null;
            this.bosTextBox25.BOSDataMember = "HRCandidateCertificateIssuedUser";
            this.bosTextBox25.BOSDataSource = "HRCandidateCertificates";
            this.bosTextBox25.BOSDescription = null;
            this.bosTextBox25.BOSError = null;
            this.bosTextBox25.BOSFieldGroup = null;
            this.bosTextBox25.BOSFieldRelation = null;
            this.bosTextBox25.BOSPrivilege = null;
            this.bosTextBox25.BOSPropertyName = "Text";
            this.bosTextBox25.Location = new System.Drawing.Point(580, 103);
            this.bosTextBox25.Name = "bosTextBox25";
            this.bosTextBox25.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox25.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox25.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox25.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox25.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox25.Screen = null;
            this.bosTextBox25.Size = new System.Drawing.Size(123, 20);
            this.bosTextBox25.TabIndex = 8;
            this.bosTextBox25.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = null;
            this.bosLabel34.BOSDataMember = null;
            this.bosLabel34.BOSDataSource = null;
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = null;
            this.bosLabel34.BOSFieldRelation = null;
            this.bosLabel34.BOSPrivilege = null;
            this.bosLabel34.BOSPropertyName = null;
            this.bosLabel34.Location = new System.Drawing.Point(539, 106);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(35, 13);
            this.bosLabel34.TabIndex = 128;
            this.bosLabel34.Text = "Nơi cấp";
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = null;
            this.bosTextBox8.BOSDataMember = "HRCandidateSkill";
            this.bosTextBox8.BOSDataSource = "HRCandidates";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = null;
            this.bosTextBox8.BOSFieldGroup = null;
            this.bosTextBox8.BOSFieldRelation = null;
            this.bosTextBox8.BOSPrivilege = null;
            this.bosTextBox8.BOSPropertyName = "Text";
            this.bosTextBox8.Location = new System.Drawing.Point(153, 51);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox8.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox8.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox8.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox8, true);
            this.bosTextBox8.Size = new System.Drawing.Size(320, 20);
            this.bosTextBox8.TabIndex = 3;
            this.bosTextBox8.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(20, 54);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(84, 13);
            this.bosLabel14.TabIndex = 128;
            this.bosLabel14.Text = "Kỹ năng, ưu điểm";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel16.Location = new System.Drawing.Point(20, 80);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(66, 13);
            this.bosLabel16.TabIndex = 127;
            this.bosLabel16.Text = "Loại bằng cấp";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = null;
            this.bosTextBox9.BOSDataMember = "HRCandidateEducation";
            this.bosTextBox9.BOSDataSource = "HRCandidates";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = null;
            this.bosTextBox9.BOSFieldGroup = null;
            this.bosTextBox9.BOSFieldRelation = null;
            this.bosTextBox9.BOSPrivilege = null;
            this.bosTextBox9.BOSPropertyName = "Text";
            this.bosTextBox9.Location = new System.Drawing.Point(153, 25);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox9, true);
            this.bosTextBox9.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox9.TabIndex = 0;
            this.bosTextBox9.Tag = "DC";
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
            this.bosLabel17.Location = new System.Drawing.Point(20, 28);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(39, 13);
            this.bosLabel17.TabIndex = 120;
            this.bosLabel17.Text = "Học vấn";
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
            this.bosLabel18.Location = new System.Drawing.Point(301, 106);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(45, 13);
            this.bosLabel18.TabIndex = 125;
            this.bosLabel18.Text = "Ngày cấp";
            // 
            // bosTextBox28
            // 
            this.bosTextBox28.BOSComment = null;
            this.bosTextBox28.BOSDataMember = "HRCandidateLanguageSkill";
            this.bosTextBox28.BOSDataSource = "HRCandidates";
            this.bosTextBox28.BOSDescription = null;
            this.bosTextBox28.BOSError = null;
            this.bosTextBox28.BOSFieldGroup = null;
            this.bosTextBox28.BOSFieldRelation = null;
            this.bosTextBox28.BOSPrivilege = null;
            this.bosTextBox28.BOSPropertyName = "Text";
            this.bosTextBox28.Location = new System.Drawing.Point(580, 51);
            this.bosTextBox28.Name = "bosTextBox28";
            this.bosTextBox28.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox28.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox28.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox28.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox28.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox28.Screen = null;
            this.bosTextBox28.Size = new System.Drawing.Size(123, 20);
            this.bosTextBox28.TabIndex = 1;
            this.bosTextBox28.Tag = "DC";
            // 
            // bosTextBox27
            // 
            this.bosTextBox27.BOSComment = null;
            this.bosTextBox27.BOSDataMember = "HRCandidateComputerSkill";
            this.bosTextBox27.BOSDataSource = "HRCandidates";
            this.bosTextBox27.BOSDescription = null;
            this.bosTextBox27.BOSError = null;
            this.bosTextBox27.BOSFieldGroup = null;
            this.bosTextBox27.BOSFieldRelation = null;
            this.bosTextBox27.BOSPrivilege = null;
            this.bosTextBox27.BOSPropertyName = "Text";
            this.bosTextBox27.Location = new System.Drawing.Point(580, 25);
            this.bosTextBox27.Name = "bosTextBox27";
            this.bosTextBox27.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox27.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox27.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox27.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox27.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox27.Screen = null;
            this.bosTextBox27.Size = new System.Drawing.Size(123, 20);
            this.bosTextBox27.TabIndex = 1;
            this.bosTextBox27.Tag = "DC";
            // 
            // fld_txtHRCandidateTel1
            // 
            this.fld_txtHRCandidateTel1.BOSComment = null;
            this.fld_txtHRCandidateTel1.BOSDataMember = "HRCandidateIQ";
            this.fld_txtHRCandidateTel1.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateTel1.BOSDescription = null;
            this.fld_txtHRCandidateTel1.BOSError = null;
            this.fld_txtHRCandidateTel1.BOSFieldGroup = null;
            this.fld_txtHRCandidateTel1.BOSFieldRelation = null;
            this.fld_txtHRCandidateTel1.BOSPrivilege = null;
            this.fld_txtHRCandidateTel1.BOSPropertyName = "Text";
            this.fld_txtHRCandidateTel1.Location = new System.Drawing.Point(360, 25);
            this.fld_txtHRCandidateTel1.Name = "fld_txtHRCandidateTel1";
            this.fld_txtHRCandidateTel1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateTel1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateTel1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateTel1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateTel1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateTel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateTel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateTel1, true);
            this.fld_txtHRCandidateTel1.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateTel1.TabIndex = 1;
            this.fld_txtHRCandidateTel1.Tag = "DC";
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = null;
            this.bosLabel37.BOSDataMember = null;
            this.bosLabel37.BOSDataSource = null;
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = null;
            this.bosLabel37.BOSFieldRelation = null;
            this.bosLabel37.BOSPrivilege = null;
            this.bosLabel37.BOSPropertyName = null;
            this.bosLabel37.Location = new System.Drawing.Point(484, 54);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(90, 13);
            this.bosLabel37.TabIndex = 109;
            this.bosLabel37.Text = "Kỹ năng ngoại ngữ";
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = null;
            this.bosLabel36.BOSDataMember = null;
            this.bosLabel36.BOSDataSource = null;
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = null;
            this.bosLabel36.BOSFieldRelation = null;
            this.bosLabel36.BOSPrivilege = null;
            this.bosLabel36.BOSPropertyName = null;
            this.bosLabel36.Location = new System.Drawing.Point(503, 28);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(71, 13);
            this.bosLabel36.TabIndex = 109;
            this.bosLabel36.Text = "Kỹ năng vi tính";
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
            this.bosLabel4.Location = new System.Drawing.Point(302, 28);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(44, 13);
            this.bosLabel4.TabIndex = 109;
            this.bosLabel4.Text = "Chỉ số IQ";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.bosTextBox5);
            this.bosGroupControl3.Controls.Add(this.bosTextBox1);
            this.bosGroupControl3.Controls.Add(this.bosLabel10);
            this.bosGroupControl3.Controls.Add(this.bosLabel11);
            this.bosGroupControl3.Controls.Add(this.bosTextBox3);
            this.bosGroupControl3.Controls.Add(this.bosLabel12);
            this.bosGroupControl3.Controls.Add(this.bosLabel13);
            this.bosGroupControl3.Controls.Add(this.bosTextBox4);
            this.bosGroupControl3.Controls.Add(this.bosLabel15);
            this.bosGroupControl3.Controls.Add(this.bosTextBox6);
            this.bosGroupControl3.Location = new System.Drawing.Point(3, 212);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(920, 77);
            this.bosGroupControl3.TabIndex = 1;
            this.bosGroupControl3.Text = "Kinh nghiệm làm việc";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = null;
            this.bosTextBox5.BOSDataMember = "HRCandidateCurrentWorking";
            this.bosTextBox5.BOSDataSource = "HRCandidates";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = null;
            this.bosTextBox5.BOSFieldRelation = null;
            this.bosTextBox5.BOSPrivilege = null;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Location = new System.Drawing.Point(399, 25);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox5, true);
            this.bosTextBox5.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox5.TabIndex = 1;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "HRCandidateCurrentPosition";
            this.bosTextBox1.BOSDataSource = "HRCandidates";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(669, 25);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(130, 20);
            this.bosTextBox1.TabIndex = 2;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel10.Location = new System.Drawing.Point(563, 28);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(81, 13);
            this.bosLabel10.TabIndex = 128;
            this.bosLabel10.Text = "Chức vụ  hiện tại";
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
            this.bosLabel11.Location = new System.Drawing.Point(292, 28);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(85, 13);
            this.bosLabel11.TabIndex = 127;
            this.bosLabel11.Text = "Công việc hiện tại";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "HRCandidateCompanyWorked";
            this.bosTextBox3.BOSDataSource = "HRCandidates";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(156, 25);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, true);
            this.bosTextBox3.Size = new System.Drawing.Size(110, 20);
            this.bosTextBox3.TabIndex = 0;
            this.bosTextBox3.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(20, 28);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(92, 13);
            this.bosLabel12.TabIndex = 120;
            this.bosLabel12.Text = "Số Cty đã từng làm";
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
            this.bosLabel13.Location = new System.Drawing.Point(20, 54);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(88, 13);
            this.bosLabel13.TabIndex = 125;
            this.bosLabel13.Text = "Mức lương hiện tại";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "HRCandidateCurrentSalary";
            this.bosTextBox4.BOSDataSource = "HRCandidates";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Location = new System.Drawing.Point(156, 51);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(110, 20);
            this.bosTextBox4.TabIndex = 3;
            this.bosTextBox4.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(292, 54);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(92, 13);
            this.bosLabel15.TabIndex = 123;
            this.bosLabel15.Text = "Công việc từng làm";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = null;
            this.bosTextBox6.BOSDataMember = "HRCandidateWorked";
            this.bosTextBox6.BOSDataSource = "HRCandidates";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = null;
            this.bosTextBox6.BOSFieldRelation = null;
            this.bosTextBox6.BOSPrivilege = null;
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.Location = new System.Drawing.Point(399, 51);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox6, true);
            this.bosTextBox6.Size = new System.Drawing.Size(400, 20);
            this.bosTextBox6.TabIndex = 4;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.bosTextBox16);
            this.bosGroupControl2.Controls.Add(this.bosTextBox12);
            this.bosGroupControl2.Controls.Add(this.bosLabel24);
            this.bosGroupControl2.Controls.Add(this.bosLabel20);
            this.bosGroupControl2.Controls.Add(this.bosTextBox19);
            this.bosGroupControl2.Controls.Add(this.bosTextBox15);
            this.bosGroupControl2.Controls.Add(this.fld_txtHRCandidateWeight);
            this.bosGroupControl2.Controls.Add(this.bosLabel27);
            this.bosGroupControl2.Controls.Add(this.bosLabel23);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel18);
            this.bosGroupControl2.Controls.Add(this.bosLabel26);
            this.bosGroupControl2.Controls.Add(this.bosLabel22);
            this.bosGroupControl2.Controls.Add(this.bosTextBox18);
            this.bosGroupControl2.Controls.Add(this.bosTextBox14);
            this.bosGroupControl2.Controls.Add(this.bosLabel25);
            this.bosGroupControl2.Controls.Add(this.bosLabel21);
            this.bosGroupControl2.Controls.Add(this.bosTextBox17);
            this.bosGroupControl2.Controls.Add(this.bosTextBox13);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 295);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(920, 104);
            this.bosGroupControl2.TabIndex = 2;
            this.bosGroupControl2.Text = "Thông tin ngoại hình";
            // 
            // bosTextBox16
            // 
            this.bosTextBox16.BOSComment = null;
            this.bosTextBox16.BOSDataMember = "HRCandidateTeeth";
            this.bosTextBox16.BOSDataSource = "HRCandidates";
            this.bosTextBox16.BOSDescription = null;
            this.bosTextBox16.BOSError = null;
            this.bosTextBox16.BOSFieldGroup = null;
            this.bosTextBox16.BOSFieldRelation = null;
            this.bosTextBox16.BOSPrivilege = null;
            this.bosTextBox16.BOSPropertyName = "Text";
            this.bosTextBox16.Location = new System.Drawing.Point(156, 77);
            this.bosTextBox16.Name = "bosTextBox16";
            this.bosTextBox16.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox16.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox16.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox16.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox16.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox16.Screen = null;
            this.bosTextBox16.Size = new System.Drawing.Size(110, 20);
            this.bosTextBox16.TabIndex = 6;
            this.bosTextBox16.Tag = "DC";
            // 
            // bosTextBox12
            // 
            this.bosTextBox12.BOSComment = null;
            this.bosTextBox12.BOSDataMember = "HRCandidateHeight";
            this.bosTextBox12.BOSDataSource = "HRCandidates";
            this.bosTextBox12.BOSDescription = null;
            this.bosTextBox12.BOSError = null;
            this.bosTextBox12.BOSFieldGroup = null;
            this.bosTextBox12.BOSFieldRelation = null;
            this.bosTextBox12.BOSPrivilege = null;
            this.bosTextBox12.BOSPropertyName = "Text";
            this.bosTextBox12.Location = new System.Drawing.Point(399, 25);
            this.bosTextBox12.Name = "bosTextBox12";
            this.bosTextBox12.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox12.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox12.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox12.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox12.Screen = null;
            this.bosTextBox12.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox12.TabIndex = 1;
            this.bosTextBox12.Tag = "DC";
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
            this.bosLabel24.Location = new System.Drawing.Point(23, 80);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(56, 13);
            this.bosLabel24.TabIndex = 110;
            this.bosLabel24.Text = "Răng Miệng";
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
            this.bosLabel20.Location = new System.Drawing.Point(292, 28);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(66, 13);
            this.bosLabel20.TabIndex = 110;
            this.bosLabel20.Text = "Chiều cao (m)";
            // 
            // bosTextBox19
            // 
            this.bosTextBox19.BOSComment = null;
            this.bosTextBox19.BOSDataMember = "HRCandidateVoice";
            this.bosTextBox19.BOSDataSource = "HRCandidates";
            this.bosTextBox19.BOSDescription = null;
            this.bosTextBox19.BOSError = null;
            this.bosTextBox19.BOSFieldGroup = null;
            this.bosTextBox19.BOSFieldRelation = null;
            this.bosTextBox19.BOSPrivilege = null;
            this.bosTextBox19.BOSPropertyName = "Text";
            this.bosTextBox19.Location = new System.Drawing.Point(669, 77);
            this.bosTextBox19.Name = "bosTextBox19";
            this.bosTextBox19.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox19.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox19.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox19.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox19.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox19.Screen = null;
            this.bosTextBox19.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox19.TabIndex = 8;
            this.bosTextBox19.Tag = "DC";
            // 
            // bosTextBox15
            // 
            this.bosTextBox15.BOSComment = null;
            this.bosTextBox15.BOSDataMember = "HRCandidateCommunication";
            this.bosTextBox15.BOSDataSource = "HRCandidates";
            this.bosTextBox15.BOSDescription = null;
            this.bosTextBox15.BOSError = null;
            this.bosTextBox15.BOSFieldGroup = null;
            this.bosTextBox15.BOSFieldRelation = null;
            this.bosTextBox15.BOSPrivilege = null;
            this.bosTextBox15.BOSPropertyName = "Text";
            this.bosTextBox15.Location = new System.Drawing.Point(399, 77);
            this.bosTextBox15.Name = "bosTextBox15";
            this.bosTextBox15.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox15.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox15.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox15.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox15.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox15.Screen = null;
            this.bosTextBox15.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox15.TabIndex = 7;
            this.bosTextBox15.Tag = "DC";
            // 
            // fld_txtHRCandidateWeight
            // 
            this.fld_txtHRCandidateWeight.BOSComment = null;
            this.fld_txtHRCandidateWeight.BOSDataMember = "HRCandidateWeight";
            this.fld_txtHRCandidateWeight.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateWeight.BOSDescription = null;
            this.fld_txtHRCandidateWeight.BOSError = null;
            this.fld_txtHRCandidateWeight.BOSFieldGroup = null;
            this.fld_txtHRCandidateWeight.BOSFieldRelation = null;
            this.fld_txtHRCandidateWeight.BOSPrivilege = null;
            this.fld_txtHRCandidateWeight.BOSPropertyName = "Text";
            this.fld_txtHRCandidateWeight.Location = new System.Drawing.Point(669, 25);
            this.fld_txtHRCandidateWeight.Name = "fld_txtHRCandidateWeight";
            this.fld_txtHRCandidateWeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateWeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateWeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateWeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateWeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateWeight, true);
            this.fld_txtHRCandidateWeight.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateWeight.TabIndex = 2;
            this.fld_txtHRCandidateWeight.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(563, 80);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(44, 13);
            this.bosLabel27.TabIndex = 110;
            this.bosLabel27.Text = "Giọng nói";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel23.Location = new System.Drawing.Point(292, 80);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(42, 13);
            this.bosLabel23.TabIndex = 110;
            this.bosLabel23.Text = "Giao tiếp";
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
            this.fld_lblLabel18.Location = new System.Drawing.Point(563, 28);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel18, true);
            this.fld_lblLabel18.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel18.TabIndex = 110;
            this.fld_lblLabel18.Text = "Cân nặng (kg)";
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
            this.bosLabel26.Location = new System.Drawing.Point(563, 54);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(53, 13);
            this.bosLabel26.TabIndex = 111;
            this.bosLabel26.Text = "Trang điểm";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel22.Location = new System.Drawing.Point(23, 54);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(54, 13);
            this.bosLabel22.TabIndex = 111;
            this.bosLabel22.Text = "Trang phục";
            // 
            // bosTextBox18
            // 
            this.bosTextBox18.BOSComment = null;
            this.bosTextBox18.BOSDataMember = "HRCandidateMakeup";
            this.bosTextBox18.BOSDataSource = "HRCandidates";
            this.bosTextBox18.BOSDescription = null;
            this.bosTextBox18.BOSError = null;
            this.bosTextBox18.BOSFieldGroup = null;
            this.bosTextBox18.BOSFieldRelation = null;
            this.bosTextBox18.BOSPrivilege = null;
            this.bosTextBox18.BOSPropertyName = "Text";
            this.bosTextBox18.Location = new System.Drawing.Point(669, 51);
            this.bosTextBox18.Name = "bosTextBox18";
            this.bosTextBox18.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox18.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox18.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox18.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox18.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox18.Screen = null;
            this.bosTextBox18.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox18.TabIndex = 5;
            this.bosTextBox18.Tag = "DC";
            // 
            // bosTextBox14
            // 
            this.bosTextBox14.BOSComment = null;
            this.bosTextBox14.BOSDataMember = "HRCandidateDress";
            this.bosTextBox14.BOSDataSource = "HRCandidates";
            this.bosTextBox14.BOSDescription = null;
            this.bosTextBox14.BOSError = null;
            this.bosTextBox14.BOSFieldGroup = null;
            this.bosTextBox14.BOSFieldRelation = null;
            this.bosTextBox14.BOSPrivilege = null;
            this.bosTextBox14.BOSPropertyName = "Text";
            this.bosTextBox14.Location = new System.Drawing.Point(156, 51);
            this.bosTextBox14.Name = "bosTextBox14";
            this.bosTextBox14.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox14.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox14.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox14.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox14.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox14.Screen = null;
            this.bosTextBox14.Size = new System.Drawing.Size(110, 20);
            this.bosTextBox14.TabIndex = 3;
            this.bosTextBox14.Tag = "DC";
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
            this.bosLabel25.Location = new System.Drawing.Point(292, 54);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(40, 13);
            this.bosLabel25.TabIndex = 109;
            this.bosLabel25.Text = "Đầu Tóc";
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
            this.bosLabel21.Location = new System.Drawing.Point(23, 28);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(50, 13);
            this.bosLabel21.TabIndex = 109;
            this.bosLabel21.Text = "Ngoại hình";
            // 
            // bosTextBox17
            // 
            this.bosTextBox17.BOSComment = null;
            this.bosTextBox17.BOSDataMember = "HRCandidateHair";
            this.bosTextBox17.BOSDataSource = "HRCandidates";
            this.bosTextBox17.BOSDescription = null;
            this.bosTextBox17.BOSError = null;
            this.bosTextBox17.BOSFieldGroup = null;
            this.bosTextBox17.BOSFieldRelation = null;
            this.bosTextBox17.BOSPrivilege = null;
            this.bosTextBox17.BOSPropertyName = "Text";
            this.bosTextBox17.Location = new System.Drawing.Point(399, 51);
            this.bosTextBox17.Name = "bosTextBox17";
            this.bosTextBox17.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox17.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox17.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox17.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox17.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox17.Screen = null;
            this.bosTextBox17.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox17.TabIndex = 4;
            this.bosTextBox17.Tag = "DC";
            // 
            // bosTextBox13
            // 
            this.bosTextBox13.BOSComment = null;
            this.bosTextBox13.BOSDataMember = "HRCandidateExternality";
            this.bosTextBox13.BOSDataSource = "HRCandidates";
            this.bosTextBox13.BOSDescription = null;
            this.bosTextBox13.BOSError = null;
            this.bosTextBox13.BOSFieldGroup = null;
            this.bosTextBox13.BOSFieldRelation = null;
            this.bosTextBox13.BOSPrivilege = null;
            this.bosTextBox13.BOSPropertyName = "Text";
            this.bosTextBox13.Location = new System.Drawing.Point(156, 25);
            this.bosTextBox13.Name = "bosTextBox13";
            this.bosTextBox13.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox13.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox13.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox13.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox13.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox13.Screen = null;
            this.bosTextBox13.Size = new System.Drawing.Size(110, 20);
            this.bosTextBox13.TabIndex = 0;
            this.bosTextBox13.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRCandidateSalaryExpected);
            this.bosGroupControl1.Controls.Add(this.bosTextBox20);
            this.bosGroupControl1.Controls.Add(this.bosLabel28);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRCandidateSubmitType);
            this.bosGroupControl1.Controls.Add(this.fld_medHRCandidateAdditionalCV);
            this.bosGroupControl1.Controls.Add(this.bosLabel29);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosCheckEdit3);
            this.bosGroupControl1.Controls.Add(this.bosCheckEdit2);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit4);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit2);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRCandidateWorkingPalce);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRCandidateYearWorking);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLabel32);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel31);
            this.bosGroupControl1.Controls.Add(this.bosLabel30);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel12);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.bosTextBox22);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit3);
            this.bosGroupControl1.Controls.Add(this.fld_dteHRCandidateIDCardDate);
            this.bosGroupControl1.Controls.Add(this.bosTextBox21);
            this.bosGroupControl1.Controls.Add(this.bosTextBox24);
            this.bosGroupControl1.Controls.Add(this.bosTextBox23);
            this.bosGroupControl1.Controls.Add(this.bosTextBox26);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRCandidateSpecialize);
            this.bosGroupControl1.Controls.Add(this.bosLabel33);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRCandidateExperience);
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(923, 206);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeHRCandidateSalaryExpected
            // 
            this.fld_lkeHRCandidateSalaryExpected.BOSAllowAddNew = true;
            this.fld_lkeHRCandidateSalaryExpected.BOSAllowDummy = true;
            this.fld_lkeHRCandidateSalaryExpected.BOSComment = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSDataMember = "HRCandidateSalaryExpected";
            this.fld_lkeHRCandidateSalaryExpected.BOSDataSource = "HRCandidates";
            this.fld_lkeHRCandidateSalaryExpected.BOSDescription = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSError = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSFieldGroup = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRCandidateSalaryExpected.BOSFieldRelation = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSPrivilege = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSPropertyName = "EditValue";
            this.fld_lkeHRCandidateSalaryExpected.BOSSelectType = null;
            this.fld_lkeHRCandidateSalaryExpected.BOSSelectTypeValue = null;
            this.fld_lkeHRCandidateSalaryExpected.CurrentDisplayText = null;
            this.fld_lkeHRCandidateSalaryExpected.Location = new System.Drawing.Point(672, 51);
            this.fld_lkeHRCandidateSalaryExpected.Name = "fld_lkeHRCandidateSalaryExpected";
            this.fld_lkeHRCandidateSalaryExpected.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRCandidateSalaryExpected.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRCandidateSalaryExpected.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRCandidateSalaryExpected.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRCandidateSalaryExpected.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRCandidateSalaryExpected.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRCandidateSalaryExpected.Properties.PopupWidth = 40;
            this.fld_lkeHRCandidateSalaryExpected.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRCandidateSalaryExpected.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRCandidateSalaryExpected, true);
            this.fld_lkeHRCandidateSalaryExpected.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeHRCandidateSalaryExpected.TabIndex = 124;
            this.fld_lkeHRCandidateSalaryExpected.Tag = "DC";
            // 
            // bosTextBox20
            // 
            this.bosTextBox20.BOSComment = null;
            this.bosTextBox20.BOSDataMember = "HRCandidateRate";
            this.bosTextBox20.BOSDataSource = "HRCandidates";
            this.bosTextBox20.BOSDescription = null;
            this.bosTextBox20.BOSError = null;
            this.bosTextBox20.BOSFieldGroup = null;
            this.bosTextBox20.BOSFieldRelation = null;
            this.bosTextBox20.BOSPrivilege = null;
            this.bosTextBox20.BOSPropertyName = "Text";
            this.bosTextBox20.Location = new System.Drawing.Point(156, 181);
            this.bosTextBox20.Name = "bosTextBox20";
            this.bosTextBox20.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox20.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox20.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox20.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox20.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox20.Screen = null;
            this.bosTextBox20.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox20.TabIndex = 16;
            this.bosTextBox20.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(23, 184);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(24, 13);
            this.bosLabel28.TabIndex = 123;
            this.bosLabel28.Text = "Điểm";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel3.Location = new System.Drawing.Point(23, 158);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(86, 13);
            this.bosLabel3.TabIndex = 121;
            this.bosLabel3.Text = "Hình thức  nộp HS";
            // 
            // fld_txtHRCandidateSubmitType
            // 
            this.fld_txtHRCandidateSubmitType.BOSComment = null;
            this.fld_txtHRCandidateSubmitType.BOSDataMember = "HRCandidateSubmitType";
            this.fld_txtHRCandidateSubmitType.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateSubmitType.BOSDescription = null;
            this.fld_txtHRCandidateSubmitType.BOSError = null;
            this.fld_txtHRCandidateSubmitType.BOSFieldGroup = null;
            this.fld_txtHRCandidateSubmitType.BOSFieldRelation = null;
            this.fld_txtHRCandidateSubmitType.BOSPrivilege = null;
            this.fld_txtHRCandidateSubmitType.BOSPropertyName = "Text";
            this.fld_txtHRCandidateSubmitType.Location = new System.Drawing.Point(156, 155);
            this.fld_txtHRCandidateSubmitType.Name = "fld_txtHRCandidateSubmitType";
            this.fld_txtHRCandidateSubmitType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateSubmitType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateSubmitType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateSubmitType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateSubmitType.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateSubmitType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateSubmitType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateSubmitType, true);
            this.fld_txtHRCandidateSubmitType.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateSubmitType.TabIndex = 15;
            this.fld_txtHRCandidateSubmitType.Tag = "DC";
            // 
            // fld_medHRCandidateAdditionalCV
            // 
            this.fld_medHRCandidateAdditionalCV.BOSComment = null;
            this.fld_medHRCandidateAdditionalCV.BOSDataMember = "HRCandidateAdditionalCV";
            this.fld_medHRCandidateAdditionalCV.BOSDataSource = "HRCandidates";
            this.fld_medHRCandidateAdditionalCV.BOSDescription = null;
            this.fld_medHRCandidateAdditionalCV.BOSError = null;
            this.fld_medHRCandidateAdditionalCV.BOSFieldGroup = null;
            this.fld_medHRCandidateAdditionalCV.BOSFieldRelation = null;
            this.fld_medHRCandidateAdditionalCV.BOSPrivilege = null;
            this.fld_medHRCandidateAdditionalCV.BOSPropertyName = "Text";
            this.fld_medHRCandidateAdditionalCV.Location = new System.Drawing.Point(402, 155);
            this.fld_medHRCandidateAdditionalCV.Name = "fld_medHRCandidateAdditionalCV";
            this.fld_medHRCandidateAdditionalCV.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRCandidateAdditionalCV.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRCandidateAdditionalCV.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRCandidateAdditionalCV.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRCandidateAdditionalCV.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRCandidateAdditionalCV, true);
            this.fld_medHRCandidateAdditionalCV.Size = new System.Drawing.Size(400, 20);
            this.fld_medHRCandidateAdditionalCV.TabIndex = 17;
            this.fld_medHRCandidateAdditionalCV.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(563, 80);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(86, 13);
            this.bosLabel29.TabIndex = 118;
            this.bosLabel29.Text = "Ngày hết thử việc";
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
            this.bosLabel6.Location = new System.Drawing.Point(292, 80);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(88, 13);
            this.bosLabel6.TabIndex = 118;
            this.bosLabel6.Text = "Ngày vào thử việc";
            // 
            // bosCheckEdit3
            // 
            this.bosCheckEdit3.BOSComment = null;
            this.bosCheckEdit3.BOSDataMember = "HRCandidateOTTime";
            this.bosCheckEdit3.BOSDataSource = "HRCandidates";
            this.bosCheckEdit3.BOSDescription = null;
            this.bosCheckEdit3.BOSError = null;
            this.bosCheckEdit3.BOSFieldGroup = null;
            this.bosCheckEdit3.BOSFieldRelation = null;
            this.bosCheckEdit3.BOSPrivilege = null;
            this.bosCheckEdit3.BOSPropertyName = "EditValue";
            this.bosCheckEdit3.Location = new System.Drawing.Point(607, 182);
            this.bosCheckEdit3.Name = "bosCheckEdit3";
            this.bosCheckEdit3.Properties.Caption = "giờ hành chánh có tăng ca 7tr/tháng";
            this.bosCheckEdit3.Screen = null;
            this.bosCheckEdit3.Size = new System.Drawing.Size(208, 19);
            this.bosCheckEdit3.TabIndex = 2;
            this.bosCheckEdit3.Tag = "DC";
            // 
            // bosCheckEdit2
            // 
            this.bosCheckEdit2.BOSComment = null;
            this.bosCheckEdit2.BOSDataMember = "HRCandidateHCTime";
            this.bosCheckEdit2.BOSDataSource = "HRCandidates";
            this.bosCheckEdit2.BOSDescription = null;
            this.bosCheckEdit2.BOSError = null;
            this.bosCheckEdit2.BOSFieldGroup = null;
            this.bosCheckEdit2.BOSFieldRelation = null;
            this.bosCheckEdit2.BOSPrivilege = null;
            this.bosCheckEdit2.BOSPropertyName = "EditValue";
            this.bosCheckEdit2.Location = new System.Drawing.Point(400, 181);
            this.bosCheckEdit2.Name = "bosCheckEdit2";
            this.bosCheckEdit2.Properties.Caption = "giờ hành chánh mức lương 4tr/tháng";
            this.bosCheckEdit2.Screen = null;
            this.bosCheckEdit2.Size = new System.Drawing.Size(210, 19);
            this.bosCheckEdit2.TabIndex = 2;
            this.bosCheckEdit2.Tag = "DC";
            // 
            // bosDateEdit4
            // 
            this.bosDateEdit4.BOSComment = null;
            this.bosDateEdit4.BOSDataMember = "HRCandidateDateEndProbationary";
            this.bosDateEdit4.BOSDataSource = "HRCandidates";
            this.bosDateEdit4.BOSDescription = null;
            this.bosDateEdit4.BOSError = null;
            this.bosDateEdit4.BOSFieldGroup = null;
            this.bosDateEdit4.BOSFieldRelation = null;
            this.bosDateEdit4.BOSPrivilege = null;
            this.bosDateEdit4.BOSPropertyName = "EditValue";
            this.bosDateEdit4.EditValue = null;
            this.bosDateEdit4.Location = new System.Drawing.Point(672, 77);
            this.bosDateEdit4.Name = "bosDateEdit4";
            this.bosDateEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit4.Screen = null;
            this.bosDateEdit4.Size = new System.Drawing.Size(130, 20);
            this.bosDateEdit4.TabIndex = 8;
            this.bosDateEdit4.Tag = "DC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "HRCandidateDateStartProbationary";
            this.bosDateEdit2.BOSDataSource = "HRCandidates";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(402, 77);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(140, 20);
            this.bosDateEdit2.TabIndex = 7;
            this.bosDateEdit2.Tag = "DC";
            // 
            // fld_txtHRCandidateWorkingPalce
            // 
            this.fld_txtHRCandidateWorkingPalce.BOSComment = null;
            this.fld_txtHRCandidateWorkingPalce.BOSDataMember = "HRCandidateWorkingPalce";
            this.fld_txtHRCandidateWorkingPalce.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateWorkingPalce.BOSDescription = null;
            this.fld_txtHRCandidateWorkingPalce.BOSError = null;
            this.fld_txtHRCandidateWorkingPalce.BOSFieldGroup = null;
            this.fld_txtHRCandidateWorkingPalce.BOSFieldRelation = null;
            this.fld_txtHRCandidateWorkingPalce.BOSPrivilege = null;
            this.fld_txtHRCandidateWorkingPalce.BOSPropertyName = "Text";
            this.fld_txtHRCandidateWorkingPalce.Location = new System.Drawing.Point(156, 51);
            this.fld_txtHRCandidateWorkingPalce.Name = "fld_txtHRCandidateWorkingPalce";
            this.fld_txtHRCandidateWorkingPalce.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateWorkingPalce.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateWorkingPalce.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateWorkingPalce.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateWorkingPalce.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateWorkingPalce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateWorkingPalce.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateWorkingPalce, true);
            this.fld_txtHRCandidateWorkingPalce.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateWorkingPalce.TabIndex = 3;
            this.fld_txtHRCandidateWorkingPalce.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(23, 54);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(56, 13);
            this.bosLabel2.TabIndex = 115;
            this.bosLabel2.Text = "Nơi làm việc";
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
            this.bosLabel5.Location = new System.Drawing.Point(563, 28);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(74, 13);
            this.bosLabel5.TabIndex = 113;
            this.bosLabel5.Text = "Vị trí ứng tuyển";
            // 
            // fld_txtHRCandidateYearWorking
            // 
            this.fld_txtHRCandidateYearWorking.BOSComment = null;
            this.fld_txtHRCandidateYearWorking.BOSDataMember = "HRCandidateYearWorking";
            this.fld_txtHRCandidateYearWorking.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateYearWorking.BOSDescription = null;
            this.fld_txtHRCandidateYearWorking.BOSError = null;
            this.fld_txtHRCandidateYearWorking.BOSFieldGroup = null;
            this.fld_txtHRCandidateYearWorking.BOSFieldRelation = null;
            this.fld_txtHRCandidateYearWorking.BOSPrivilege = null;
            this.fld_txtHRCandidateYearWorking.BOSPropertyName = "Text";
            this.fld_txtHRCandidateYearWorking.Location = new System.Drawing.Point(156, 25);
            this.fld_txtHRCandidateYearWorking.Name = "fld_txtHRCandidateYearWorking";
            this.fld_txtHRCandidateYearWorking.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateYearWorking.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateYearWorking.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateYearWorking.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateYearWorking.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateYearWorking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateYearWorking.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateYearWorking, true);
            this.fld_txtHRCandidateYearWorking.Size = new System.Drawing.Size(113, 20);
            this.fld_txtHRCandidateYearWorking.TabIndex = 0;
            this.fld_txtHRCandidateYearWorking.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(23, 28);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel5, true);
            this.fld_lblLabel5.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel5.TabIndex = 84;
            this.fld_lblLabel5.Text = "Số năm đi làm";
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
            this.bosLabel8.Location = new System.Drawing.Point(292, 106);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 98;
            this.bosLabel8.Text = "Lương thử việc";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.Location = new System.Drawing.Point(23, 80);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(127, 13);
            this.bosLabel1.TabIndex = 98;
            this.bosLabel1.Text = "TG có thể bắt đầu làm việc";
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
            this.bosLabel7.Location = new System.Drawing.Point(23, 106);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(88, 13);
            this.bosLabel7.TabIndex = 98;
            this.bosLabel7.Text = "TG thử việc còn lại";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = null;
            this.bosLabel32.BOSDataSource = null;
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(292, 158);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(70, 13);
            this.bosLabel32.TabIndex = 98;
            this.bosLabel32.Text = "Bổ sung  hồ sơ";
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
            this.bosLabel9.Location = new System.Drawing.Point(563, 54);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(91, 13);
            this.bosLabel9.TabIndex = 98;
            this.bosLabel9.Text = "Mức lương yêu cầu";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(23, 132);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(73, 13);
            this.bosLabel31.TabIndex = 98;
            this.bosLabel31.Text = "Chuyển đến BP";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = null;
            this.bosLabel30.BOSDataMember = null;
            this.bosLabel30.BOSDataSource = null;
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = null;
            this.bosLabel30.BOSFieldRelation = null;
            this.bosLabel30.BOSPrivilege = null;
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(563, 106);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(83, 13);
            this.bosLabel30.TabIndex = 98;
            this.bosLabel30.Text = "Lương chính thức";
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(292, 54);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, true);
            this.fld_lblLabel12.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel12.TabIndex = 98;
            this.fld_lblLabel12.Text = "Chuyên ngành";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "HRCandidateDateCanWork";
            this.bosDateEdit1.BOSDataSource = "HRCandidates";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(156, 77);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(113, 20);
            this.bosDateEdit1.TabIndex = 6;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosTextBox22
            // 
            this.bosTextBox22.BOSComment = null;
            this.bosTextBox22.BOSDataMember = "HRCandidateSalaryProbationary";
            this.bosTextBox22.BOSDataSource = "HRCandidates";
            this.bosTextBox22.BOSDescription = null;
            this.bosTextBox22.BOSError = null;
            this.bosTextBox22.BOSFieldGroup = null;
            this.bosTextBox22.BOSFieldRelation = null;
            this.bosTextBox22.BOSPrivilege = null;
            this.bosTextBox22.BOSPropertyName = "Text";
            this.bosTextBox22.Location = new System.Drawing.Point(402, 103);
            this.bosTextBox22.Name = "bosTextBox22";
            this.bosTextBox22.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox22.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox22.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox22.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox22.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox22.Screen = null;
            this.bosTextBox22.Size = new System.Drawing.Size(140, 20);
            this.bosTextBox22.TabIndex = 10;
            this.bosTextBox22.Tag = "DC";
            // 
            // bosDateEdit3
            // 
            this.bosDateEdit3.BOSComment = null;
            this.bosDateEdit3.BOSDataMember = "HRCandidateDateChangeDepartment";
            this.bosDateEdit3.BOSDataSource = "HRCandidates";
            this.bosDateEdit3.BOSDescription = null;
            this.bosDateEdit3.BOSError = null;
            this.bosDateEdit3.BOSFieldGroup = null;
            this.bosDateEdit3.BOSFieldRelation = null;
            this.bosDateEdit3.BOSPrivilege = null;
            this.bosDateEdit3.BOSPropertyName = "EditValue";
            this.bosDateEdit3.EditValue = null;
            this.bosDateEdit3.Location = new System.Drawing.Point(402, 129);
            this.bosDateEdit3.Name = "bosDateEdit3";
            this.bosDateEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit3.Screen = null;
            this.bosDateEdit3.Size = new System.Drawing.Size(140, 20);
            this.bosDateEdit3.TabIndex = 13;
            this.bosDateEdit3.Tag = "DC";
            // 
            // fld_dteHRCandidateIDCardDate
            // 
            this.fld_dteHRCandidateIDCardDate.BOSComment = null;
            this.fld_dteHRCandidateIDCardDate.BOSDataMember = "HRCandidateDateCreatedCV";
            this.fld_dteHRCandidateIDCardDate.BOSDataSource = "HRCandidates";
            this.fld_dteHRCandidateIDCardDate.BOSDescription = null;
            this.fld_dteHRCandidateIDCardDate.BOSError = null;
            this.fld_dteHRCandidateIDCardDate.BOSFieldGroup = null;
            this.fld_dteHRCandidateIDCardDate.BOSFieldRelation = null;
            this.fld_dteHRCandidateIDCardDate.BOSPrivilege = null;
            this.fld_dteHRCandidateIDCardDate.BOSPropertyName = "EditValue";
            this.fld_dteHRCandidateIDCardDate.EditValue = null;
            this.fld_dteHRCandidateIDCardDate.Location = new System.Drawing.Point(672, 129);
            this.fld_dteHRCandidateIDCardDate.Name = "fld_dteHRCandidateIDCardDate";
            this.fld_dteHRCandidateIDCardDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRCandidateIDCardDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRCandidateIDCardDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRCandidateIDCardDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRCandidateIDCardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRCandidateIDCardDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRCandidateIDCardDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHRCandidateIDCardDate, true);
            this.fld_dteHRCandidateIDCardDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteHRCandidateIDCardDate.TabIndex = 14;
            this.fld_dteHRCandidateIDCardDate.Tag = "DC";
            // 
            // bosTextBox21
            // 
            this.bosTextBox21.BOSComment = null;
            this.bosTextBox21.BOSDataMember = "HRCandidateDateProbationaryRemain";
            this.bosTextBox21.BOSDataSource = "HRCandidates";
            this.bosTextBox21.BOSDescription = null;
            this.bosTextBox21.BOSError = null;
            this.bosTextBox21.BOSFieldGroup = null;
            this.bosTextBox21.BOSFieldRelation = null;
            this.bosTextBox21.BOSPrivilege = null;
            this.bosTextBox21.BOSPropertyName = "Text";
            this.bosTextBox21.Location = new System.Drawing.Point(156, 103);
            this.bosTextBox21.Name = "bosTextBox21";
            this.bosTextBox21.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox21.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox21.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox21.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox21.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox21.Screen = null;
            this.bosTextBox21.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox21.TabIndex = 9;
            this.bosTextBox21.Tag = "DC";
            // 
            // bosTextBox24
            // 
            this.bosTextBox24.BOSComment = null;
            this.bosTextBox24.BOSDataMember = "HRCandidateDepartmentTo";
            this.bosTextBox24.BOSDataSource = "HRCandidates";
            this.bosTextBox24.BOSDescription = null;
            this.bosTextBox24.BOSError = null;
            this.bosTextBox24.BOSFieldGroup = null;
            this.bosTextBox24.BOSFieldRelation = null;
            this.bosTextBox24.BOSPrivilege = null;
            this.bosTextBox24.BOSPropertyName = "Text";
            this.bosTextBox24.Location = new System.Drawing.Point(156, 129);
            this.bosTextBox24.Name = "bosTextBox24";
            this.bosTextBox24.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox24.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox24.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox24.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox24.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox24.Screen = null;
            this.bosTextBox24.Size = new System.Drawing.Size(113, 20);
            this.bosTextBox24.TabIndex = 12;
            this.bosTextBox24.Tag = "DC";
            // 
            // bosTextBox23
            // 
            this.bosTextBox23.BOSComment = null;
            this.bosTextBox23.BOSDataMember = "HRCandidateOfficalSalary";
            this.bosTextBox23.BOSDataSource = "HRCandidates";
            this.bosTextBox23.BOSDescription = null;
            this.bosTextBox23.BOSError = null;
            this.bosTextBox23.BOSFieldGroup = null;
            this.bosTextBox23.BOSFieldRelation = null;
            this.bosTextBox23.BOSPrivilege = null;
            this.bosTextBox23.BOSPropertyName = "Text";
            this.bosTextBox23.Location = new System.Drawing.Point(672, 103);
            this.bosTextBox23.Name = "bosTextBox23";
            this.bosTextBox23.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox23.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox23.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox23.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox23.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox23.Screen = null;
            this.bosTextBox23.Size = new System.Drawing.Size(130, 20);
            this.bosTextBox23.TabIndex = 11;
            this.bosTextBox23.Tag = "DC";
            // 
            // bosTextBox26
            // 
            this.bosTextBox26.BOSComment = null;
            this.bosTextBox26.BOSDataMember = "HRCandidatePositionApply";
            this.bosTextBox26.BOSDataSource = "HRCandidates";
            this.bosTextBox26.BOSDescription = null;
            this.bosTextBox26.BOSError = null;
            this.bosTextBox26.BOSFieldGroup = null;
            this.bosTextBox26.BOSFieldRelation = null;
            this.bosTextBox26.BOSPrivilege = null;
            this.bosTextBox26.BOSPropertyName = "Text";
            this.bosTextBox26.Location = new System.Drawing.Point(672, 25);
            this.bosTextBox26.Name = "bosTextBox26";
            this.bosTextBox26.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox26.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox26.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox26.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox26.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox26.Screen = null;
            this.bosTextBox26.Size = new System.Drawing.Size(130, 20);
            this.bosTextBox26.TabIndex = 2;
            this.bosTextBox26.Tag = "DC";
            // 
            // fld_txtHRCandidateSpecialize
            // 
            this.fld_txtHRCandidateSpecialize.BOSComment = null;
            this.fld_txtHRCandidateSpecialize.BOSDataMember = "HRCandidateSpecialize";
            this.fld_txtHRCandidateSpecialize.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateSpecialize.BOSDescription = null;
            this.fld_txtHRCandidateSpecialize.BOSError = null;
            this.fld_txtHRCandidateSpecialize.BOSFieldGroup = null;
            this.fld_txtHRCandidateSpecialize.BOSFieldRelation = null;
            this.fld_txtHRCandidateSpecialize.BOSPrivilege = null;
            this.fld_txtHRCandidateSpecialize.BOSPropertyName = "Text";
            this.fld_txtHRCandidateSpecialize.Location = new System.Drawing.Point(402, 51);
            this.fld_txtHRCandidateSpecialize.Name = "fld_txtHRCandidateSpecialize";
            this.fld_txtHRCandidateSpecialize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateSpecialize.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateSpecialize.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateSpecialize.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateSpecialize.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateSpecialize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateSpecialize.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateSpecialize, true);
            this.fld_txtHRCandidateSpecialize.Size = new System.Drawing.Size(140, 20);
            this.fld_txtHRCandidateSpecialize.TabIndex = 4;
            this.fld_txtHRCandidateSpecialize.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = null;
            this.bosLabel33.BOSDataMember = null;
            this.bosLabel33.BOSDataSource = null;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = null;
            this.bosLabel33.BOSFieldRelation = null;
            this.bosLabel33.BOSPrivilege = null;
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(292, 132);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(66, 13);
            this.bosLabel33.TabIndex = 101;
            this.bosLabel33.Text = "Ngày chuyển ";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(292, 28);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel8, true);
            this.fld_lblLabel8.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel8.TabIndex = 95;
            this.fld_lblLabel8.Text = "Kinh nghiệm";
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(563, 132);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel16, true);
            this.fld_lblLabel16.Size = new System.Drawing.Size(81, 13);
            this.fld_lblLabel16.TabIndex = 101;
            this.fld_lblLabel16.Text = "Ngày nhập hồ sơ";
            // 
            // fld_txtHRCandidateExperience
            // 
            this.fld_txtHRCandidateExperience.BOSComment = null;
            this.fld_txtHRCandidateExperience.BOSDataMember = "HRCandidateExperience";
            this.fld_txtHRCandidateExperience.BOSDataSource = "HRCandidates";
            this.fld_txtHRCandidateExperience.BOSDescription = null;
            this.fld_txtHRCandidateExperience.BOSError = null;
            this.fld_txtHRCandidateExperience.BOSFieldGroup = null;
            this.fld_txtHRCandidateExperience.BOSFieldRelation = null;
            this.fld_txtHRCandidateExperience.BOSPrivilege = null;
            this.fld_txtHRCandidateExperience.BOSPropertyName = "Text";
            this.fld_txtHRCandidateExperience.Location = new System.Drawing.Point(402, 25);
            this.fld_txtHRCandidateExperience.Name = "fld_txtHRCandidateExperience";
            this.fld_txtHRCandidateExperience.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCandidateExperience.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCandidateExperience.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCandidateExperience.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCandidateExperience.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCandidateExperience.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCandidateExperience.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRCandidateExperience, true);
            this.fld_txtHRCandidateExperience.Size = new System.Drawing.Size(140, 20);
            this.fld_txtHRCandidateExperience.TabIndex = 1;
            this.fld_txtHRCandidateExperience.Tag = "DC";
            // 
            // DMCM102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(932, 746);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCM102";
            this.Tag = "DM";
            this.Text = "Thông tin ứng viên";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCandidateCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeTranfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).EndInit();
            this.bosGroupControl4.ResumeLayout(false);
            this.bosGroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRCandidateCertificateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit5.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateCertificateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox25.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox28.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox27.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateTel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox19.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRCandidateSalaryExpected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox20.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateSubmitType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRCandidateAdditionalCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateWorkingPalce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateYearWorking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRCandidateIDCardDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRCandidateIDCardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox24.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox26.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateSpecialize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCandidateExperience.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSTextBox fld_txtHRCandidateYearWorking;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSDateEdit fld_dteHRCandidateIDCardDate;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSTextBox fld_txtHRCandidateExperience;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtHRCandidateTel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtHRCandidateWorkingPalce;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHRCandidateSpecialize;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSGroupControl bosGroupControl4;
        private BOSComponent.BOSTextBox fld_txtHRCandidateCertificateType;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox bosTextBox21;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSDateEdit bosDateEdit4;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox bosTextBox22;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSTextBox bosTextBox23;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSMemoEdit fld_medHRCandidateAdditionalCV;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTextBox bosTextBox24;
        private BOSComponent.BOSDateEdit bosDateEdit3;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSTextBox bosTextBox16;
        private BOSComponent.BOSTextBox bosTextBox12;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox bosTextBox19;
        private BOSComponent.BOSTextBox bosTextBox15;
        private BOSComponent.BOSTextBox fld_txtHRCandidateWeight;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox bosTextBox18;
        private BOSComponent.BOSTextBox bosTextBox14;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox bosTextBox17;
        private BOSComponent.BOSTextBox bosTextBox13;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtHRCandidateSubmitType;
        private BOSComponent.BOSTextBox bosTextBox25;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSDateEdit bosDateEdit5;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox bosTextBox20;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
        private BOSComponent.BOSTextBox bosTextBox10;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox HRCandidateCertificateName;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSTextBox bosTextBox26;
        private BOSComponent.BOSButton fld_btnAddCertificate;
        private BOSComponent.BOSButton fld_btnDeleteCertificate;
        private BOSComponent.BOSButton fld_btnEditCertificate;
        private HRCandidateCertificatesGridControl fld_dgcHRCandidateCertificates;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeTranfers;
        private BOSComponent.BOSTextBox bosTextBox28;
        private BOSComponent.BOSTextBox bosTextBox27;
        private BOSComponent.BOSLabel bosLabel37;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSCheckEdit bosCheckEdit3;
        private BOSComponent.BOSCheckEdit bosCheckEdit2;
        private BOSComponent.BOSLookupEdit fld_lkeHRCandidateSalaryExpected;
	}
}
