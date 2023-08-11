using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConfigSalesTarget.UI
{
	/// <summary>
	/// Summary description for fld_pteICReturnShippingEmployeePicture
	/// </summary>
    partial class DMCST100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRConfigSalesTargetEmployeePicture;


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
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRConfigSalesTargetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteHRConfigSalesTargetDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRConfigSalesTargetNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_CSCompanyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRConfigSalesTargetAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRConfigSalesTargetApplyFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRConfigSalesTargetApplyToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRConfigSalesTargetType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRConfigSalesTargetParentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRConfigSalesTargetApplicableSubjects = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeApprovedID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRConfigSalesTargetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRConfigSalesTargetItemsGridControl = new BOSERP.Modules.ConfigSalesTarget.HRConfigSalesTargetItemsGridControl();
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRConfigSalesTargetName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRConfigSalesTargetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesTargetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesTargetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigSalesTargetParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesTargetItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetName.Properties)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "Please choose a staff.";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteHRConfigSalesTargetEmployeePicture
            // 
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSDataMember = "HRConfigSalesTargetEmployeePicture";
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSDataSource = "HRConfigSalesTargets";
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSDescription = null;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_pteHRConfigSalesTargetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRConfigSalesTargetEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteHRConfigSalesTargetEmployeePicture.Name = "fld_pteHRConfigSalesTargetEmployeePicture";
            this.fld_pteHRConfigSalesTargetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRConfigSalesTargetEmployeePicture.Screen = null;
            this.fld_pteHRConfigSalesTargetEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRConfigSalesTargetEmployeePicture.TabIndex = 0;
            this.fld_pteHRConfigSalesTargetEmployeePicture.Tag = "DC";
            // 
            // fld_dteHRConfigSalesTargetDate
            // 
            this.fld_dteHRConfigSalesTargetDate.BOSComment = null;
            this.fld_dteHRConfigSalesTargetDate.BOSDataMember = "HRConfigSalesTargetDate";
            this.fld_dteHRConfigSalesTargetDate.BOSDataSource = "HRConfigSalesTargets";
            this.fld_dteHRConfigSalesTargetDate.BOSDescription = null;
            this.fld_dteHRConfigSalesTargetDate.BOSError = null;
            this.fld_dteHRConfigSalesTargetDate.BOSFieldGroup = null;
            this.fld_dteHRConfigSalesTargetDate.BOSFieldRelation = null;
            this.fld_dteHRConfigSalesTargetDate.BOSPrivilege = null;
            this.fld_dteHRConfigSalesTargetDate.BOSPropertyName = "EditValue";
            this.fld_dteHRConfigSalesTargetDate.EditValue = null;
            this.fld_dteHRConfigSalesTargetDate.Location = new System.Drawing.Point(218, 64);
            this.fld_dteHRConfigSalesTargetDate.MenuManager = this.screenToolbar;
            this.fld_dteHRConfigSalesTargetDate.Name = "fld_dteHRConfigSalesTargetDate";
            this.fld_dteHRConfigSalesTargetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRConfigSalesTargetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRConfigSalesTargetDate.Screen = null;
            this.fld_dteHRConfigSalesTargetDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteHRConfigSalesTargetDate.TabIndex = 3;
            this.fld_dteHRConfigSalesTargetDate.Tag = "DC";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(136, 67);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel1.TabIndex = 4;
            this.BOSLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.BOSLabel1.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(136, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Text = "Mã chứng từ";
            // 
            // fld_txtHRConfigSalesTargetNo
            // 
            this.fld_txtHRConfigSalesTargetNo.BOSComment = null;
            this.fld_txtHRConfigSalesTargetNo.BOSDataMember = "HRConfigSalesTargetNo";
            this.fld_txtHRConfigSalesTargetNo.BOSDataSource = "HRConfigSalesTargets";
            this.fld_txtHRConfigSalesTargetNo.BOSDescription = null;
            this.fld_txtHRConfigSalesTargetNo.BOSError = null;
            this.fld_txtHRConfigSalesTargetNo.BOSFieldGroup = null;
            this.fld_txtHRConfigSalesTargetNo.BOSFieldRelation = null;
            this.fld_txtHRConfigSalesTargetNo.BOSPrivilege = null;
            this.fld_txtHRConfigSalesTargetNo.BOSPropertyName = "EditValue";
            this.fld_txtHRConfigSalesTargetNo.Location = new System.Drawing.Point(218, 12);
            this.fld_txtHRConfigSalesTargetNo.MenuManager = this.screenToolbar;
            this.fld_txtHRConfigSalesTargetNo.Name = "fld_txtHRConfigSalesTargetNo";
            this.fld_txtHRConfigSalesTargetNo.Screen = null;
            this.fld_txtHRConfigSalesTargetNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtHRConfigSalesTargetNo.TabIndex = 0;
            this.fld_txtHRConfigSalesTargetNo.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_CSCompanyID);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_txtHRConfigSalesTargetAmount);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesTargetApplyFromDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesTargetApplyToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesTargetType);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRConfigSalesTargetParentID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesTargetApplicableSubjects);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeApprovedID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesTargetStatus);
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtHRConfigSalesTargetName);
            this.bosPanel1.Controls.Add(this.fld_pteHRConfigSalesTargetEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtHRConfigSalesTargetNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_dteHRConfigSalesTargetDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(664, 510);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_CSCompanyID
            // 
            this.fld_lkeFK_CSCompanyID.BOSAllowAddNew = false;
            this.fld_lkeFK_CSCompanyID.BOSAllowDummy = true;
            this.fld_lkeFK_CSCompanyID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSDataMember = "FK_CSCompanyID";
            this.fld_lkeFK_CSCompanyID.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_CSCompanyID.BOSDescription = null;
            this.fld_lkeFK_CSCompanyID.BOSError = null;
            this.fld_lkeFK_CSCompanyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_CSCompanyID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.CurrentDisplayText = null;
            this.fld_lkeFK_CSCompanyID.Location = new System.Drawing.Point(218, 116);
            this.fld_lkeFK_CSCompanyID.Name = "fld_lkeFK_CSCompanyID";
            this.fld_lkeFK_CSCompanyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_CSCompanyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_CSCompanyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_CSCompanyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_CSCompanyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_CSCompanyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyDesc", "Tên công ty")});
            this.fld_lkeFK_CSCompanyID.Properties.DisplayMember = "CSCompanyDesc";
            this.fld_lkeFK_CSCompanyID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_CSCompanyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_CSCompanyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_CSCompanyID.Properties.ValueMember = "CSCompanyID";
            this.fld_lkeFK_CSCompanyID.Screen = null;
            this.fld_lkeFK_CSCompanyID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_CSCompanyID.TabIndex = 7;
            this.fld_lkeFK_CSCompanyID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(400, 145);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 441;
            this.bosLabel13.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel13.Text = "Đến ngày";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(400, 171);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(33, 13);
            this.bosLabel10.TabIndex = 434;
            this.bosLabel10.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel10.Text = "Số tiền";
            // 
            // fld_txtHRConfigSalesTargetAmount
            // 
            this.fld_txtHRConfigSalesTargetAmount.BOSComment = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSDataMember = "HRConfigSalesTargetAmount";
            this.fld_txtHRConfigSalesTargetAmount.BOSDataSource = "HRConfigSalesTargets";
            this.fld_txtHRConfigSalesTargetAmount.BOSDescription = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSError = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSFieldGroup = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSFieldRelation = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSPrivilege = null;
            this.fld_txtHRConfigSalesTargetAmount.BOSPropertyName = "EditValue";
            this.fld_txtHRConfigSalesTargetAmount.Location = new System.Drawing.Point(478, 168);
            this.fld_txtHRConfigSalesTargetAmount.MenuManager = this.screenToolbar;
            this.fld_txtHRConfigSalesTargetAmount.Name = "fld_txtHRConfigSalesTargetAmount";
            this.fld_txtHRConfigSalesTargetAmount.Screen = null;
            this.fld_txtHRConfigSalesTargetAmount.Size = new System.Drawing.Size(171, 20);
            this.fld_txtHRConfigSalesTargetAmount.TabIndex = 12;
            this.fld_txtHRConfigSalesTargetAmount.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(136, 145);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(40, 13);
            this.bosLabel12.TabIndex = 440;
            this.bosLabel12.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel12.Text = "Từ ngày";
            // 
            // fld_lkeHRConfigSalesTargetApplyFromDate
            // 
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSComment = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSDataMember = "HRConfigSalesTargetApplyFromDate";
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSDescription = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSError = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSFieldGroup = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSFieldRelation = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSPrivilege = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesTargetApplyFromDate.EditValue = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Location = new System.Drawing.Point(218, 142);
            this.fld_lkeHRConfigSalesTargetApplyFromDate.MenuManager = this.screenToolbar;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Name = "fld_lkeHRConfigSalesTargetApplyFromDate";
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Screen = null;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeHRConfigSalesTargetApplyFromDate.TabIndex = 9;
            this.fld_lkeHRConfigSalesTargetApplyFromDate.Tag = "DC";
            this.fld_lkeHRConfigSalesTargetApplyFromDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRConfigSalesTargetApplyFromDate_CloseUp);
            // 
            // fld_lkeHRConfigSalesTargetApplyToDate
            // 
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSComment = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSDataMember = "HRConfigSalesTargetApplyToDate";
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSDescription = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSError = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSFieldGroup = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSFieldRelation = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSPrivilege = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesTargetApplyToDate.EditValue = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.Location = new System.Drawing.Point(478, 142);
            this.fld_lkeHRConfigSalesTargetApplyToDate.MenuManager = this.screenToolbar;
            this.fld_lkeHRConfigSalesTargetApplyToDate.Name = "fld_lkeHRConfigSalesTargetApplyToDate";
            this.fld_lkeHRConfigSalesTargetApplyToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesTargetApplyToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_lkeHRConfigSalesTargetApplyToDate.Screen = null;
            this.fld_lkeHRConfigSalesTargetApplyToDate.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeHRConfigSalesTargetApplyToDate.TabIndex = 10;
            this.fld_lkeHRConfigSalesTargetApplyToDate.Tag = "DC";
            this.fld_lkeHRConfigSalesTargetApplyToDate.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRConfigSalesTargetApplyToDate_CloseUp);
            // 
            // fld_lkeHRConfigSalesTargetType
            // 
            this.fld_lkeHRConfigSalesTargetType.BOSAllowAddNew = false;
            this.fld_lkeHRConfigSalesTargetType.BOSAllowDummy = true;
            this.fld_lkeHRConfigSalesTargetType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSDataMember = "HRConfigSalesTargetType";
            this.fld_lkeHRConfigSalesTargetType.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeHRConfigSalesTargetType.BOSDescription = null;
            this.fld_lkeHRConfigSalesTargetType.BOSError = null;
            this.fld_lkeHRConfigSalesTargetType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesTargetType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.CurrentDisplayText = null;
            this.fld_lkeHRConfigSalesTargetType.Location = new System.Drawing.Point(218, 168);
            this.fld_lkeHRConfigSalesTargetType.Name = "fld_lkeHRConfigSalesTargetType";
            this.fld_lkeHRConfigSalesTargetType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRConfigSalesTargetType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRConfigSalesTargetType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRConfigSalesTargetType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRConfigSalesTargetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesTargetType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetType.Properties.PopupWidth = 40;
            this.fld_lkeHRConfigSalesTargetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRConfigSalesTargetType.Screen = null;
            this.fld_lkeHRConfigSalesTargetType.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeHRConfigSalesTargetType.TabIndex = 11;
            this.fld_lkeHRConfigSalesTargetType.Tag = "DC";
            this.fld_lkeHRConfigSalesTargetType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRConfigSalesTargetType_CloseUp);
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(136, 171);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(19, 13);
            this.bosLabel11.TabIndex = 436;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.Text = "Loại";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(400, 119);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 433;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(478, 116);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", 30, "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 8;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(136, 119);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(38, 13);
            this.bosLabel7.TabIndex = 430;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel7.Text = "Công ty";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(400, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(73, 13);
            this.bosLabel6.TabIndex = 429;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "CHDST kế thừa";
            // 
            // fld_lkeFK_HRConfigSalesTargetParentID
            // 
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSDataMember = "FK_HRConfigSalesTargetParentID";
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSDescription = null;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSError = null;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Location = new System.Drawing.Point(478, 90);
            this.fld_lkeFK_HRConfigSalesTargetParentID.Name = "fld_lkeFK_HRConfigSalesTargetParentID";
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigSalesTargetNo", "Mã chứng từ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRConfigSalesTargetName", 30, "Tên chứng từ")});
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.DisplayMember = "HRConfigSalesTargetNo";
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Properties.ValueMember = "HRConfigSalesTargetID";
            this.fld_lkeFK_HRConfigSalesTargetParentID.Screen = null;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HRConfigSalesTargetParentID.TabIndex = 6;
            this.fld_lkeFK_HRConfigSalesTargetParentID.Tag = "DC";
            this.fld_lkeFK_HRConfigSalesTargetParentID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRConfigSalesTargetParentID_CloseUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(136, 93);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 425;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "ĐT áp dụng";
            // 
            // fld_lkeHRConfigSalesTargetApplicableSubjects
            // 
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSAllowAddNew = false;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSAllowDummy = true;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSDataMember = "HRConfigSalesTargetApplicableSubjects";
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSDescription = null;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSError = null;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.CurrentDisplayText = null;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Location = new System.Drawing.Point(218, 90);
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Name = "fld_lkeHRConfigSalesTargetApplicableSubjects";
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.PopupWidth = 40;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Screen = null;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.TabIndex = 5;
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.Tag = "DC";
            this.fld_lkeHRConfigSalesTargetApplicableSubjects.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRConfigSalesTargetApplicableSubjects_CloseUp);
            // 
            // fld_lkeFK_HREmployeeApprovedID
            // 
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeApprovedID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataMember = "FK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSError = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeApprovedID.Location = new System.Drawing.Point(478, 64);
            this.fld_lkeFK_HREmployeeApprovedID.Name = "fld_lkeFK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeApprovedID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ReadOnly = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeApprovedID.Screen = null;
            this.fld_lkeFK_HREmployeeApprovedID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HREmployeeApprovedID.TabIndex = 4;
            this.fld_lkeFK_HREmployeeApprovedID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(400, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 421;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Text = "Người duyệt";
            // 
            // fld_lkeHRConfigSalesTargetStatus
            // 
            this.fld_lkeHRConfigSalesTargetStatus.BOSAllowAddNew = false;
            this.fld_lkeHRConfigSalesTargetStatus.BOSAllowDummy = false;
            this.fld_lkeHRConfigSalesTargetStatus.BOSComment = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSDataMember = "HRConfigSalesTargetStatus";
            this.fld_lkeHRConfigSalesTargetStatus.BOSDataSource = "HRConfigSalesTargets";
            this.fld_lkeHRConfigSalesTargetStatus.BOSDescription = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSError = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSFieldGroup = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSFieldParent = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSFieldRelation = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSPrivilege = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesTargetStatus.BOSSelectType = null;
            this.fld_lkeHRConfigSalesTargetStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRConfigSalesTargetStatus.CurrentDisplayText = null;
            this.fld_lkeHRConfigSalesTargetStatus.Location = new System.Drawing.Point(478, 12);
            this.fld_lkeHRConfigSalesTargetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRConfigSalesTargetStatus.Name = "fld_lkeHRConfigSalesTargetStatus";
            this.fld_lkeHRConfigSalesTargetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesTargetStatus.Properties.ReadOnly = true;
            this.fld_lkeHRConfigSalesTargetStatus.Screen = null;
            this.fld_lkeHRConfigSalesTargetStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeHRConfigSalesTargetStatus.TabIndex = 1;
            this.fld_lkeHRConfigSalesTargetStatus.Tag = "DC";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 194);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(648, 304);
            this.xtraTabControl1.TabIndex = 418;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRConfigSalesTargetItemsGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(641, 275);
            this.xtraTabPage1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcHRConfigSalesTargetItemsGridControl
            // 
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSComment = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSDataMember = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSDataSource = "HRConfigSalesTargetItems";
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSDescription = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSError = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSGridType = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSPrivilege = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.BOSPropertyName = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.ConfigSalesTargetItemList = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.GridViewMain = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcHRConfigSalesTargetItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Name = "fld_dgcHRConfigSalesTargetItemsGridControl";
            this.fld_dgcHRConfigSalesTargetItemsGridControl.PrintReport = false;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Screen = null;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Size = new System.Drawing.Size(637, 269);
            this.fld_dgcHRConfigSalesTargetItemsGridControl.TabIndex = 0;
            this.fld_dgcHRConfigSalesTargetItemsGridControl.Validated += new System.EventHandler(this.fld_dgcHRConfigSalesTargetItemsGridControl_Validated);
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(136, 41);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel3.TabIndex = 417;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Text = "Tên chứng từ";
            // 
            // fld_txtHRConfigSalesTargetName
            // 
            this.fld_txtHRConfigSalesTargetName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRConfigSalesTargetName.BOSDataMember = "HRConfigSalesTargetName";
            this.fld_txtHRConfigSalesTargetName.BOSDataSource = "HRConfigSalesTargets";
            this.fld_txtHRConfigSalesTargetName.BOSDescription = null;
            this.fld_txtHRConfigSalesTargetName.BOSError = "Tên chứng từ không thể rỗng";
            this.fld_txtHRConfigSalesTargetName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRConfigSalesTargetName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRConfigSalesTargetName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRConfigSalesTargetName.BOSPropertyName = "Text";
            this.fld_txtHRConfigSalesTargetName.Location = new System.Drawing.Point(218, 38);
            this.fld_txtHRConfigSalesTargetName.Name = "fld_txtHRConfigSalesTargetName";
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRConfigSalesTargetName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRConfigSalesTargetName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRConfigSalesTargetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRConfigSalesTargetName.Screen = null;
            this.fld_txtHRConfigSalesTargetName.Size = new System.Drawing.Size(431, 20);
            this.fld_txtHRConfigSalesTargetName.TabIndex = 2;
            this.fld_txtHRConfigSalesTargetName.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(400, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(642, 205);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
            // 
            // DMCST100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(664, 510);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCST100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRConfigSalesTargetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesTargetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesTargetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_CSCompanyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplyToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRConfigSalesTargetParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetApplicableSubjects.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesTargetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesTargetItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesTargetName.Properties)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteHRConfigSalesTargetDate;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesTargetNo;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReturnShippingItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesTargetName;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private HRConfigSalesTargetItemsGridControl fld_dgcHRConfigSalesTargetItemsGridControl;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeHRConfigSalesTargetStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRConfigSalesTargetApplicableSubjects;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeApprovedID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRConfigSalesTargetParentID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesTargetAmount;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeHRConfigSalesTargetType;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSDateEdit fld_lkeHRConfigSalesTargetApplyFromDate;
        private BOSComponent.BOSDateEdit fld_lkeHRConfigSalesTargetApplyToDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_CSCompanyID;
	}
}
