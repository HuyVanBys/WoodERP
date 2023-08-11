using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DeviceConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class SMDEC100
	{
		private BOSComponent.BOSTextBox fld_txtACAssetReceiptNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSDateEdit fld_dteSearchFromACAssetReceiptDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToACAssetReceiptDate1;


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
            this.fld_txtACAssetReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromACAssetReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToACAssetReceiptDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcACDevices = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACAssetReceiptNo
            // 
            this.fld_txtACAssetReceiptNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACAssetReceiptNo.BOSDataMember = "ACDeviceNo";
            this.fld_txtACAssetReceiptNo.BOSDataSource = "ACDevices";
            this.fld_txtACAssetReceiptNo.BOSDescription = null;
            this.fld_txtACAssetReceiptNo.BOSError = null;
            this.fld_txtACAssetReceiptNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACAssetReceiptNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACAssetReceiptNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACAssetReceiptNo.BOSPropertyName = "Text";
            this.fld_txtACAssetReceiptNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACAssetReceiptNo.Location = new System.Drawing.Point(147, 131);
            this.fld_txtACAssetReceiptNo.Name = "fld_txtACAssetReceiptNo";
            this.fld_txtACAssetReceiptNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetReceiptNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetReceiptNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetReceiptNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetReceiptNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetReceiptNo.Screen = null;
            this.fld_txtACAssetReceiptNo.Size = new System.Drawing.Size(161, 20);
            this.fld_txtACAssetReceiptNo.TabIndex = 0;
            this.fld_txtACAssetReceiptNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(57, 134);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
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
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel3.Location = new System.Drawing.Point(57, 238);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Location = new System.Drawing.Point(335, 238);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel4.TabIndex = 9;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Đến";
            // 
            // fld_dteSearchFromACAssetReceiptDate
            // 
            this.fld_dteSearchFromACAssetReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACAssetReceiptDate.BOSDataMember = "ACDeviceDateFrom";
            this.fld_dteSearchFromACAssetReceiptDate.BOSDataSource = "ACDevices";
            this.fld_dteSearchFromACAssetReceiptDate.BOSDescription = null;
            this.fld_dteSearchFromACAssetReceiptDate.BOSError = null;
            this.fld_dteSearchFromACAssetReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACAssetReceiptDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACAssetReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromACAssetReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromACAssetReceiptDate.EditValue = null;
            this.fld_dteSearchFromACAssetReceiptDate.Location = new System.Drawing.Point(147, 235);
            this.fld_dteSearchFromACAssetReceiptDate.Name = "fld_dteSearchFromACAssetReceiptDate";
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromACAssetReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromACAssetReceiptDate.Screen = null;
            this.fld_dteSearchFromACAssetReceiptDate.Size = new System.Drawing.Size(161, 20);
            this.fld_dteSearchFromACAssetReceiptDate.TabIndex = 5;
            this.fld_dteSearchFromACAssetReceiptDate.Tag = "SC";
            // 
            // fld_dteSearchToACAssetReceiptDate1
            // 
            this.fld_dteSearchToACAssetReceiptDate1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACAssetReceiptDate1.BOSDataMember = "ACDeviceDateTo";
            this.fld_dteSearchToACAssetReceiptDate1.BOSDataSource = "ACDevices";
            this.fld_dteSearchToACAssetReceiptDate1.BOSDescription = null;
            this.fld_dteSearchToACAssetReceiptDate1.BOSError = null;
            this.fld_dteSearchToACAssetReceiptDate1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACAssetReceiptDate1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACAssetReceiptDate1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToACAssetReceiptDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchToACAssetReceiptDate1.EditValue = null;
            this.fld_dteSearchToACAssetReceiptDate1.Location = new System.Drawing.Point(378, 235);
            this.fld_dteSearchToACAssetReceiptDate1.Name = "fld_dteSearchToACAssetReceiptDate1";
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToACAssetReceiptDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToACAssetReceiptDate1.Screen = null;
            this.fld_dteSearchToACAssetReceiptDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToACAssetReceiptDate1.TabIndex = 6;
            this.fld_dteSearchToACAssetReceiptDate1.Tag = "SC";
            // 
            // fld_dgcACDevices
            // 
            this.fld_dgcACDevices.BOSComment = null;
            this.fld_dgcACDevices.BOSDataMember = null;
            this.fld_dgcACDevices.BOSDataSource = "ACDevices";
            this.fld_dgcACDevices.BOSDescription = null;
            this.fld_dgcACDevices.BOSError = null;
            this.fld_dgcACDevices.BOSFieldGroup = null;
            this.fld_dgcACDevices.BOSFieldRelation = null;
            this.fld_dgcACDevices.BOSPrivilege = null;
            this.fld_dgcACDevices.BOSPropertyName = null;
            this.fld_dgcACDevices.Location = new System.Drawing.Point(53, 271);
            this.fld_dgcACDevices.MenuManager = this.screenToolbar;
            this.fld_dgcACDevices.Name = "fld_dgcACDevices";
            this.fld_dgcACDevices.Screen = null;
            this.fld_dgcACDevices.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACDevices.TabIndex = 10;
            this.fld_dgcACDevices.Tag = "SR";
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
            this.bosLabel5.Location = new System.Drawing.Point(57, 160);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(19, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Loại";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "ACDeviceIdentifierType";
            this.bosLookupEdit2.BOSDataSource = "ACDevices";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(147, 157);
            this.bosLookupEdit2.MenuManager = this.screenToolbar;
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(161, 20);
            this.bosLookupEdit2.TabIndex = 11;
            this.bosLookupEdit2.Tag = "SC";
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
            this.bosLabel4.Location = new System.Drawing.Point(57, 186);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 14;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Người lập";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit1.BOSDataSource = "ACDevices";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(147, 183);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên")});
            this.bosLookupEdit1.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.bosLookupEdit1.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(161, 20);
            this.bosLookupEdit1.TabIndex = 13;
            this.bosLookupEdit1.Tag = "SC";
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
            this.bosLabel7.Location = new System.Drawing.Point(57, 212);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(49, 13);
            this.bosLabel7.TabIndex = 16;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Tên MMTB";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ACDeviceName";
            this.bosTextBox1.BOSDataSource = "ACDevices";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(147, 209);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(161, 20);
            this.bosTextBox1.TabIndex = 15;
            this.bosTextBox1.Tag = "SC";
            // 
            // SMDEC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLookupEdit2);
            this.Controls.Add(this.fld_dgcACDevices);
            this.Controls.Add(this.fld_txtACAssetReceiptNo);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchFromACAssetReceiptDate);
            this.Controls.Add(this.fld_dteSearchToACAssetReceiptDate1);
            this.Name = "SMDEC100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToACAssetReceiptDate1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromACAssetReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_txtACAssetReceiptNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcACDevices, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit2, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACAssetReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACAssetReceiptDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcACDevices;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox bosTextBox1;
	}
}
