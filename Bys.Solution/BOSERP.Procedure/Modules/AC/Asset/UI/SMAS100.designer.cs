using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Asset.UI
{
	/// <summary>
	/// Summary description for SMAS100
	/// </summary>
	partial class SMAS100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSTextBox fld_txtACAssetNo;
        private BOSComponent.BOSTextBox fld_txtACAssetName;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAssetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACAssetType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAssets = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAssetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã tài sản";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(34, 56);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên tài sản";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(34, 82);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(54, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Loại tài sản";
            // 
            // fld_txtACAssetNo
            // 
            this.fld_txtACAssetNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetNo.BOSDataMember = "ACAssetNo";
            this.fld_txtACAssetNo.BOSDataSource = "ACAssets";
            this.fld_txtACAssetNo.BOSDescription = null;
            this.fld_txtACAssetNo.BOSError = null;
            this.fld_txtACAssetNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetNo.BOSPropertyName = "Text";
            this.fld_txtACAssetNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetNo.Location = new System.Drawing.Point(115, 27);
            this.fld_txtACAssetNo.Name = "fld_txtACAssetNo";
            this.fld_txtACAssetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetNo.Screen = null;
            this.fld_txtACAssetNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetNo.TabIndex = 0;
            this.fld_txtACAssetNo.Tag = "SC";
            // 
            // fld_txtACAssetName
            // 
            this.fld_txtACAssetName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetName.BOSDataMember = "ACAssetName";
            this.fld_txtACAssetName.BOSDataSource = "ACAssets";
            this.fld_txtACAssetName.BOSDescription = null;
            this.fld_txtACAssetName.BOSError = null;
            this.fld_txtACAssetName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetName.BOSPropertyName = "Text";
            this.fld_txtACAssetName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACAssetName.Location = new System.Drawing.Point(115, 53);
            this.fld_txtACAssetName.Name = "fld_txtACAssetName";
            this.fld_txtACAssetName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetName.Screen = null;
            this.fld_txtACAssetName.Size = new System.Drawing.Size(319, 20);
            this.fld_txtACAssetName.TabIndex = 1;
            this.fld_txtACAssetName.Tag = "SC";
            // 
            // fld_lkeACAssetType
            // 
            this.fld_lkeACAssetType.BOSAllowAddNew = false;
            this.fld_lkeACAssetType.BOSAllowDummy = true;
            this.fld_lkeACAssetType.BOSComment = null;
            this.fld_lkeACAssetType.BOSDataMember = "ACAssetType";
            this.fld_lkeACAssetType.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetType.BOSDescription = null;
            this.fld_lkeACAssetType.BOSError = null;
            this.fld_lkeACAssetType.BOSFieldGroup = null;
            this.fld_lkeACAssetType.BOSFieldParent = null;
            this.fld_lkeACAssetType.BOSFieldRelation = null;
            this.fld_lkeACAssetType.BOSPrivilege = null;
            this.fld_lkeACAssetType.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetType.BOSSelectType = null;
            this.fld_lkeACAssetType.BOSSelectTypeValue = null;
            this.fld_lkeACAssetType.CurrentDisplayText = null;
            this.fld_lkeACAssetType.Location = new System.Drawing.Point(115, 79);
            this.fld_lkeACAssetType.MenuManager = this.screenToolbar;
            this.fld_lkeACAssetType.Name = "fld_lkeACAssetType";
            this.fld_lkeACAssetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetType.Screen = null;
            this.fld_lkeACAssetType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAssetType.TabIndex = 2;
            this.fld_lkeACAssetType.Tag = "SC";
            // 
            // fld_dgcAssets
            // 
            this.fld_dgcAssets.BOSComment = null;
            this.fld_dgcAssets.BOSDataMember = null;
            this.fld_dgcAssets.BOSDataSource = "ACAssets";
            this.fld_dgcAssets.BOSDescription = null;
            this.fld_dgcAssets.BOSError = null;
            this.fld_dgcAssets.BOSFieldGroup = null;
            this.fld_dgcAssets.BOSFieldRelation = null;
            this.fld_dgcAssets.BOSPrivilege = null;
            this.fld_dgcAssets.BOSPropertyName = null;
            this.fld_dgcAssets.Location = new System.Drawing.Point(34, 216);
            this.fld_dgcAssets.MenuManager = this.screenToolbar;
            this.fld_dgcAssets.Name = "fld_dgcAssets";
            this.fld_dgcAssets.Screen = null;
            this.fld_dgcAssets.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAssets.TabIndex = 11;
            this.fld_dgcAssets.Tag = "SR";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(34, 108);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tình trạng";
            // 
            // fld_lkeACAssetStatus
            // 
            this.fld_lkeACAssetStatus.BOSAllowAddNew = false;
            this.fld_lkeACAssetStatus.BOSAllowDummy = true;
            this.fld_lkeACAssetStatus.BOSComment = null;
            this.fld_lkeACAssetStatus.BOSDataMember = "ACAssetStatus";
            this.fld_lkeACAssetStatus.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetStatus.BOSDescription = null;
            this.fld_lkeACAssetStatus.BOSError = null;
            this.fld_lkeACAssetStatus.BOSFieldGroup = null;
            this.fld_lkeACAssetStatus.BOSFieldParent = null;
            this.fld_lkeACAssetStatus.BOSFieldRelation = null;
            this.fld_lkeACAssetStatus.BOSPrivilege = null;
            this.fld_lkeACAssetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetStatus.BOSSelectType = null;
            this.fld_lkeACAssetStatus.BOSSelectTypeValue = null;
            this.fld_lkeACAssetStatus.CurrentDisplayText = null;
            this.fld_lkeACAssetStatus.Location = new System.Drawing.Point(115, 105);
            this.fld_lkeACAssetStatus.Name = "fld_lkeACAssetStatus";
            this.fld_lkeACAssetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetStatus.Screen = null;
            this.fld_lkeACAssetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAssetStatus.TabIndex = 3;
            this.fld_lkeACAssetStatus.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(34, 134);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Phòng ban";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(115, 131);
            this.fld_lkeFK_HRDepartmentRoomID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(34, 160);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(21, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "NCC";
            // 
            // fld_lkeAPSupplierID
            // 
            this.fld_lkeAPSupplierID.BOSAllowAddNew = false;
            this.fld_lkeAPSupplierID.BOSAllowDummy = true;
            this.fld_lkeAPSupplierID.BOSComment = null;
            this.fld_lkeAPSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeAPSupplierID.BOSDataSource = "ACAssets";
            this.fld_lkeAPSupplierID.BOSDescription = null;
            this.fld_lkeAPSupplierID.BOSError = null;
            this.fld_lkeAPSupplierID.BOSFieldGroup = null;
            this.fld_lkeAPSupplierID.BOSFieldParent = null;
            this.fld_lkeAPSupplierID.BOSFieldRelation = null;
            this.fld_lkeAPSupplierID.BOSPrivilege = null;
            this.fld_lkeAPSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeAPSupplierID.BOSSelectType = null;
            this.fld_lkeAPSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeAPSupplierID.CurrentDisplayText = null;
            this.fld_lkeAPSupplierID.Location = new System.Drawing.Point(115, 157);
            this.fld_lkeAPSupplierID.MenuManager = this.screenToolbar;
            this.fld_lkeAPSupplierID.Name = "fld_lkeAPSupplierID";
            this.fld_lkeAPSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeAPSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeAPSupplierID.Screen = null;
            this.fld_lkeAPSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPSupplierID.TabIndex = 5;
            this.fld_lkeAPSupplierID.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Location = new System.Drawing.Point(34, 186);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 22;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(115, 183);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 6;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMAS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeAPSupplierID);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.Controls.Add(this.fld_dgcAssets);
            this.Controls.Add(this.fld_lkeACAssetStatus);
            this.Controls.Add(this.fld_lkeACAssetType);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_txtACAssetNo);
            this.Controls.Add(this.fld_txtACAssetName);
            this.Name = "SMAS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACAssetName, 0);
            this.Controls.SetChildIndex(this.fld_txtACAssetNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAssetType, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAssetStatus, 0);
            this.Controls.SetChildIndex(this.fld_dgcAssets, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentRoomID, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPSupplierID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLookupEdit fld_lkeACAssetType;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcAssets;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeACAssetStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeAPSupplierID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
