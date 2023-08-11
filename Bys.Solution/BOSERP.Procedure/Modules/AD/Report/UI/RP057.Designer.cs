﻿namespace BOSERP.Modules.Report
{
    partial class RP057
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.fld_dteTimeSheetDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_rdgTimeSheetType = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_lkeHRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeGELocationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTimeSheetID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTimeSheetDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTimeSheetDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgTimeSheetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(403, 124);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 0;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(322, 124);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(75, 27);
            this.fld_btnView.TabIndex = 14;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // fld_dteTimeSheetDate
            // 
            this.fld_dteTimeSheetDate.BOSComment = null;
            this.fld_dteTimeSheetDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteTimeSheetDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteTimeSheetDate.BOSDescription = null;
            this.fld_dteTimeSheetDate.BOSError = null;
            this.fld_dteTimeSheetDate.BOSFieldGroup = null;
            this.fld_dteTimeSheetDate.BOSFieldRelation = null;
            this.fld_dteTimeSheetDate.BOSPrivilege = null;
            this.fld_dteTimeSheetDate.BOSPropertyName = null;
            this.fld_dteTimeSheetDate.EditValue = null;
            this.fld_dteTimeSheetDate.Location = new System.Drawing.Point(90, 12);
            this.fld_dteTimeSheetDate.Name = "fld_dteTimeSheetDate";
            this.fld_dteTimeSheetDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteTimeSheetDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteTimeSheetDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteTimeSheetDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteTimeSheetDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteTimeSheetDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteTimeSheetDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteTimeSheetDate.Screen = null;
            this.fld_dteTimeSheetDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteTimeSheetDate.TabIndex = 2;
            this.fld_dteTimeSheetDate.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(23, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(30, 13);
            this.bosLabel10.TabIndex = 1;
            this.bosLabel10.Text = "Tháng";
            // 
            // fld_rdgTimeSheetType
            // 
            this.fld_rdgTimeSheetType.BOSComment = null;
            this.fld_rdgTimeSheetType.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_rdgTimeSheetType.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_rdgTimeSheetType.BOSDescription = null;
            this.fld_rdgTimeSheetType.BOSError = null;
            this.fld_rdgTimeSheetType.BOSFieldGroup = null;
            this.fld_rdgTimeSheetType.BOSFieldRelation = null;
            this.fld_rdgTimeSheetType.BOSPrivilege = null;
            this.fld_rdgTimeSheetType.BOSPropertyName = null;
            this.fld_rdgTimeSheetType.EditValue = 1;
            this.fld_rdgTimeSheetType.Location = new System.Drawing.Point(273, 6);
            this.fld_rdgTimeSheetType.MenuManager = this.screenToolbar;
            this.fld_rdgTimeSheetType.Name = "fld_rdgTimeSheetType";
            this.fld_rdgTimeSheetType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_rdgTimeSheetType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tổng hợp"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Chi tiết")});
            this.fld_rdgTimeSheetType.Screen = null;
            this.fld_rdgTimeSheetType.Size = new System.Drawing.Size(205, 33);
            this.fld_rdgTimeSheetType.TabIndex = 3;
            this.fld_rdgTimeSheetType.Tag = "DC";
            // 
            // fld_lkeHRDepartmentRoomID
            // 
            this.fld_lkeHRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID.BOSError = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID.Location = new System.Drawing.Point(328, 71);
            this.fld_lkeHRDepartmentRoomID.Name = "fld_lkeHRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeHRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Screen = null;
            this.fld_lkeHRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomID.TabIndex = 11;
            // 
            // fld_lkeHRDepartmentID
            // 
            this.fld_lkeHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentID.BOSComment = null;
            this.fld_lkeHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartmentID.BOSDescription = null;
            this.fld_lkeHRDepartmentID.BOSError = null;
            this.fld_lkeHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentID.BOSSelectType = null;
            this.fld_lkeHRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentID.Location = new System.Drawing.Point(90, 71);
            this.fld_lkeHRDepartmentID.Name = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.Screen = null;
            this.fld_lkeHRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentID.TabIndex = 9;
            // 
            // fld_lkeGELocationID
            // 
            this.fld_lkeGELocationID.BOSAllowAddNew = false;
            this.fld_lkeGELocationID.BOSAllowDummy = true;
            this.fld_lkeGELocationID.BOSComment = null;
            this.fld_lkeGELocationID.BOSDataMember = "GELocationID";
            this.fld_lkeGELocationID.BOSDataSource = "GELocations";
            this.fld_lkeGELocationID.BOSDescription = null;
            this.fld_lkeGELocationID.BOSError = null;
            this.fld_lkeGELocationID.BOSFieldGroup = null;
            this.fld_lkeGELocationID.BOSFieldParent = null;
            this.fld_lkeGELocationID.BOSFieldRelation = null;
            this.fld_lkeGELocationID.BOSPrivilege = null;
            this.fld_lkeGELocationID.BOSPropertyName = null;
            this.fld_lkeGELocationID.BOSSelectType = null;
            this.fld_lkeGELocationID.BOSSelectTypeValue = null;
            this.fld_lkeGELocationID.CurrentDisplayText = null;
            this.fld_lkeGELocationID.Location = new System.Drawing.Point(90, 45);
            this.fld_lkeGELocationID.Name = "fld_lkeGELocationID";
            this.fld_lkeGELocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGELocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GELocationName", "Vị trí")});
            this.fld_lkeGELocationID.Properties.DisplayMember = "GELocationName";
            this.fld_lkeGELocationID.Properties.ValueMember = "GELocationID";
            this.fld_lkeGELocationID.Screen = null;
            this.fld_lkeGELocationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGELocationID.TabIndex = 5;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(328, 45);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 7;
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
            this.bosLabel4.Location = new System.Drawing.Point(23, 74);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(39, 13);
            this.bosLabel4.TabIndex = 8;
            this.bosLabel4.Text = "Bộ phận";
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
            this.bosLabel6.Location = new System.Drawing.Point(23, 48);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(21, 13);
            this.bosLabel6.TabIndex = 4;
            this.bosLabel6.Text = "Vị trí";
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
            this.bosLabel3.Location = new System.Drawing.Point(262, 48);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Chi nhánh";
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
            this.bosLabel5.Location = new System.Drawing.Point(262, 74);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(51, 13);
            this.bosLabel5.TabIndex = 10;
            this.bosLabel5.Text = "Phòng ban";
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
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(23, 100);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel4.TabIndex = 12;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Bảng công";
            // 
            // fld_lkeHRTimeSheetID
            // 
            this.fld_lkeHRTimeSheetID.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetID.BOSAllowDummy = true;
            this.fld_lkeHRTimeSheetID.BOSComment = "";
            this.fld_lkeHRTimeSheetID.BOSDataMember = "HRTimeSheetID";
            this.fld_lkeHRTimeSheetID.BOSDataSource = "HRTimeSheets";
            this.fld_lkeHRTimeSheetID.BOSDescription = null;
            this.fld_lkeHRTimeSheetID.BOSError = null;
            this.fld_lkeHRTimeSheetID.BOSFieldGroup = null;
            this.fld_lkeHRTimeSheetID.BOSFieldParent = null;
            this.fld_lkeHRTimeSheetID.BOSFieldRelation = null;
            this.fld_lkeHRTimeSheetID.BOSPrivilege = null;
            this.fld_lkeHRTimeSheetID.BOSPropertyName = null;
            this.fld_lkeHRTimeSheetID.BOSSelectType = null;
            this.fld_lkeHRTimeSheetID.BOSSelectTypeValue = null;
            this.fld_lkeHRTimeSheetID.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetID.Location = new System.Drawing.Point(90, 97);
            this.fld_lkeHRTimeSheetID.Name = "fld_lkeHRTimeSheetID";
            this.fld_lkeHRTimeSheetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTimeSheetNo", "Mã bảng công"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTimeSheetName", "Tên bảng công")});
            this.fld_lkeHRTimeSheetID.Properties.DisplayMember = "HRTimeSheetName";
            this.fld_lkeHRTimeSheetID.Properties.ValueMember = "HRTimeSheetID";
            this.fld_lkeHRTimeSheetID.Screen = null;
            this.fld_lkeHRTimeSheetID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTimeSheetID.TabIndex = 13;
            this.fld_lkeHRTimeSheetID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRTimeSheetID_QueryPopUp);
            // 
            // RP057
            // 
            this.AcceptButton = this.fld_btnView;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(495, 160);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lkeHRDepartmentRoomID);
            this.Controls.Add(this.fld_lkeHRDepartmentID);
            this.Controls.Add(this.fld_lkeGELocationID);
            this.Controls.Add(this.fld_lkeHRTimeSheetID);
            this.Controls.Add(this.fld_lkeBRBranchID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_rdgTimeSheetType);
            this.Controls.Add(this.fld_dteTimeSheetDate);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_btnView);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP057";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.RP057_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnView, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.fld_dteTimeSheetDate, 0);
            this.Controls.SetChildIndex(this.fld_rdgTimeSheetType, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeBRBranchID, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRTimeSheetID, 0);
            this.Controls.SetChildIndex(this.fld_lkeGELocationID, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRDepartmentRoomID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTimeSheetDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTimeSheetDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgTimeSheetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteTimeSheetDate;
        private BOSComponent.BOSButton fld_btnView;
        private BOSComponent.BOSRadioGroup fld_rdgTimeSheetType;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeGELocationID;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetID;
    }
}