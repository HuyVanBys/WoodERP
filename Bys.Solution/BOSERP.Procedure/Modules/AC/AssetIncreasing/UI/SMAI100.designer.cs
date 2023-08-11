using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AssetIncreasing.UI
{
	/// <summary>
	/// Summary description for SMER100
	/// </summary>
	partial class SMAI100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSTextBox fld_txtICReceiptNo;
		private BOSComponent.BOSTextBox fld_txtICReceiptInvoiceInNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSDateEdit fld_dteSearchFromICReceiptDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToICReceiptDate1;


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
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICReceiptDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcReceipts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceipts)).BeginInit();
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
            this.fld_lblLabel.Location = new System.Drawing.Point(27, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(27, 106);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Nhân viên";
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
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(27, 80);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(21, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "NCC";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(28, 56);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(80, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Mã hóa đơn NCC";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(28, 157);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(305, 157);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel5.TabIndex = 9;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Đến";
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(133, 27);
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptNo.Screen = null;
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo.TabIndex = 0;
            this.fld_txtICReceiptNo.Tag = "SC";
            // 
            // fld_txtICReceiptInvoiceInNo
            // 
            this.fld_txtICReceiptInvoiceInNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo.BOSDataMember = "ICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptInvoiceInNo.BOSDescription = null;
            this.fld_txtICReceiptInvoiceInNo.BOSError = null;
            this.fld_txtICReceiptInvoiceInNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptInvoiceInNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptInvoiceInNo.Location = new System.Drawing.Point(133, 53);
            this.fld_txtICReceiptInvoiceInNo.Name = "fld_txtICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptInvoiceInNo.Screen = null;
            this.fld_txtICReceiptInvoiceInNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptInvoiceInNo.TabIndex = 1;
            this.fld_txtICReceiptInvoiceInNo.Tag = "SC";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(133, 77);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_APSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 2;
            this.fld_lkeFK_APSupplierID.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(133, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromICReceiptDate
            // 
            this.fld_dteSearchFromICReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICReceiptDate.BOSDataMember = "ReceiptDateFrom";
            this.fld_dteSearchFromICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteSearchFromICReceiptDate.BOSDescription = null;
            this.fld_dteSearchFromICReceiptDate.BOSError = null;
            this.fld_dteSearchFromICReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICReceiptDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICReceiptDate.EditValue = null;
            this.fld_dteSearchFromICReceiptDate.Location = new System.Drawing.Point(133, 154);
            this.fld_dteSearchFromICReceiptDate.Name = "fld_dteSearchFromICReceiptDate";
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICReceiptDate.Screen = null;
            this.fld_dteSearchFromICReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromICReceiptDate.TabIndex = 5;
            this.fld_dteSearchFromICReceiptDate.Tag = "SC";
            // 
            // fld_dteSearchToICReceiptDate1
            // 
            this.fld_dteSearchToICReceiptDate1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICReceiptDate1.BOSDataMember = "ReceiptDateTo";
            this.fld_dteSearchToICReceiptDate1.BOSDataSource = "ICReceipts";
            this.fld_dteSearchToICReceiptDate1.BOSDescription = null;
            this.fld_dteSearchToICReceiptDate1.BOSError = null;
            this.fld_dteSearchToICReceiptDate1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICReceiptDate1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICReceiptDate1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICReceiptDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICReceiptDate1.EditValue = null;
            this.fld_dteSearchToICReceiptDate1.Location = new System.Drawing.Point(346, 154);
            this.fld_dteSearchToICReceiptDate1.Name = "fld_dteSearchToICReceiptDate1";
            this.fld_dteSearchToICReceiptDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICReceiptDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICReceiptDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICReceiptDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICReceiptDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICReceiptDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICReceiptDate1.Screen = null;
            this.fld_dteSearchToICReceiptDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToICReceiptDate1.TabIndex = 6;
            this.fld_dteSearchToICReceiptDate1.Tag = "SC";
            // 
            // fld_dgcReceipts
            // 
            this.fld_dgcReceipts.BOSComment = null;
            this.fld_dgcReceipts.BOSDataMember = null;
            this.fld_dgcReceipts.BOSDataSource = "ICReceipts";
            this.fld_dgcReceipts.BOSDescription = null;
            this.fld_dgcReceipts.BOSError = null;
            this.fld_dgcReceipts.BOSFieldGroup = null;
            this.fld_dgcReceipts.BOSFieldRelation = null;
            this.fld_dgcReceipts.BOSPrivilege = null;
            this.fld_dgcReceipts.BOSPropertyName = null;
            this.fld_dgcReceipts.Location = new System.Drawing.Point(27, 193);
            this.fld_dgcReceipts.MenuManager = this.screenToolbar;
            this.fld_dgcReceipts.Name = "fld_dgcReceipts";
            this.fld_dgcReceipts.Screen = null;
            this.fld_dgcReceipts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcReceipts.TabIndex = 10;
            this.fld_dgcReceipts.Tag = "SR";
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
            this.bosLabel1.Location = new System.Drawing.Point(27, 132);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 26;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICReceipts";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(133, 129);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMER100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcReceipts);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtICReceiptNo);
            this.Controls.Add(this.fld_txtICReceiptInvoiceInNo);
            this.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dteSearchFromICReceiptDate);
            this.Controls.Add(this.fld_dteSearchToICReceiptDate1);
            this.Name = "SMAI100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToICReceiptDate1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptInvoiceInNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcReceipts, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcReceipts;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
