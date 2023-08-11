using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleCost.UI
{
	/// <summary>
    /// Summary description for SMSOC100
	/// </summary>
    partial class SMSOC100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSTextBox fld_txtACDocumentNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSDateEdit fld_dteSearchFromACDocumentDate;
		private BOSComponent.BOSDateEdit fld_dteSearchToACDocumentDate;
        private BOSComponent.BOSLabel fld_lblLabel8;


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
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcDocuments = new ACDocumentsGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel.Location = new System.Drawing.Point(19, 20);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(19, 72);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Nhân viên";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(19, 150);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Ngày chứng từ từ";
            // 
            // fld_txtACDocumentNo
            // 
            this.fld_txtACDocumentNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo.BOSDescription = null;
            this.fld_txtACDocumentNo.BOSError = null;
            this.fld_txtACDocumentNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo.Location = new System.Drawing.Point(129, 17);
            this.fld_txtACDocumentNo.Name = "fld_txtACDocumentNo";
            this.fld_txtACDocumentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo.Screen = null;
            this.fld_txtACDocumentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo.TabIndex = 0;
            this.fld_txtACDocumentNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(129, 69);
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
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromACDocumentDate
            // 
            this.fld_dteSearchFromACDocumentDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromACDocumentDate.BOSDataMember = "DocumentDateFrom";
            this.fld_dteSearchFromACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteSearchFromACDocumentDate.BOSDescription = null;
            this.fld_dteSearchFromACDocumentDate.BOSError = null;
            this.fld_dteSearchFromACDocumentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromACDocumentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromACDocumentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromACDocumentDate.EditValue = null;
            this.fld_dteSearchFromACDocumentDate.Location = new System.Drawing.Point(129, 147);
            this.fld_dteSearchFromACDocumentDate.Name = "fld_dteSearchFromACDocumentDate";
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromACDocumentDate.Screen = null;
            this.fld_dteSearchFromACDocumentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromACDocumentDate.TabIndex = 5;
            this.fld_dteSearchFromACDocumentDate.Tag = "SC";
            // 
            // fld_dteSearchToACDocumentDate
            // 
            this.fld_dteSearchToACDocumentDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToACDocumentDate.BOSDataMember = "DocumentDateTo";
            this.fld_dteSearchToACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteSearchToACDocumentDate.BOSDescription = null;
            this.fld_dteSearchToACDocumentDate.BOSError = null;
            this.fld_dteSearchToACDocumentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToACDocumentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToACDocumentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToACDocumentDate.EditValue = null;
            this.fld_dteSearchToACDocumentDate.Location = new System.Drawing.Point(337, 147);
            this.fld_dteSearchToACDocumentDate.Name = "fld_dteSearchToACDocumentDate";
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToACDocumentDate.Screen = null;
            this.fld_dteSearchToACDocumentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToACDocumentDate.TabIndex = 6;
            this.fld_dteSearchToACDocumentDate.Tag = "SC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Location = new System.Drawing.Point(299, 150);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel8.TabIndex = 12;
            this.fld_lblLabel8.Tag = "SI";
            this.fld_lblLabel8.Text = "Đến";
            // 
            // fld_dgcDocuments
            // 
            this.fld_dgcDocuments.BOSComment = null;
            this.fld_dgcDocuments.BOSDataMember = null;
            this.fld_dgcDocuments.BOSDataSource = "ACDocuments";
            this.fld_dgcDocuments.BOSDescription = null;
            this.fld_dgcDocuments.BOSError = null;
            this.fld_dgcDocuments.BOSFieldGroup = null;
            this.fld_dgcDocuments.BOSFieldRelation = null;
            this.fld_dgcDocuments.BOSPrivilege = null;
            this.fld_dgcDocuments.BOSPropertyName = null;
            this.fld_dgcDocuments.Location = new System.Drawing.Point(19, 244);
            this.fld_dgcDocuments.MenuManager = this.screenToolbar;
            this.fld_dgcDocuments.Name = "fld_dgcDocuments";
            this.fld_dgcDocuments.Screen = null;
            this.fld_dgcDocuments.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcDocuments.TabIndex = 13;
            this.fld_dgcDocuments.Tag = "SR";
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
            this.bosLabel1.Location = new System.Drawing.Point(19, 46);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(84, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Người thanh toán";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(129, 43);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(19, 98);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 5;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Mã lô hàng";
            // 
            // fld_txtICReceiptPackNo
            // 
            this.fld_txtICReceiptPackNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptPackNo.BOSDataMember = "ICReceiptPackNo";
            this.fld_txtICReceiptPackNo.BOSDataSource = "ACDocuments";
            this.fld_txtICReceiptPackNo.BOSDescription = null;
            this.fld_txtICReceiptPackNo.BOSError = null;
            this.fld_txtICReceiptPackNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptPackNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptPackNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptPackNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptPackNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICReceiptPackNo.Location = new System.Drawing.Point(129, 95);
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptPackNo.Screen = null;
            this.fld_txtICReceiptPackNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptPackNo.TabIndex = 3;
            this.fld_txtICReceiptPackNo.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(19, 124);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 20;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(129, 121);
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
            // SMFP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_dgcDocuments);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtICReceiptPackNo);
            this.Controls.Add(this.fld_txtACDocumentNo);
            this.Controls.Add(this.fld_lblLabel8);
            this.Controls.Add(this.fld_dteSearchFromACDocumentDate);
            this.Controls.Add(this.fld_dteSearchToACDocumentDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Name = "SMFP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToACDocumentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromACDocumentDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            this.Controls.SetChildIndex(this.fld_txtACDocumentNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptPackNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcDocuments, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private ACDocumentsGridControl fld_dgcDocuments;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICReceiptPackNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
