using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace BOSERP.Modules.ACVAT.UI
{
	/// <summary>
	/// Summary description for SMAS100
	/// </summary>
    partial class SMACVAT100
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
            this.fld_dgcVATs = new VATSearchResultGridControl();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATInvoiceType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACVATInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACVATInvoiceDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACVATDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACVAT = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVATs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVAT.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVAT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcVATs
            // 
            this.fld_dgcVATs.BOSComment = null;
            this.fld_dgcVATs.BOSDataMember = null;
            this.fld_dgcVATs.BOSDataSource = "ACVATs";
            this.fld_dgcVATs.BOSDescription = null;
            this.fld_dgcVATs.BOSError = null;
            this.fld_dgcVATs.BOSFieldGroup = null;
            this.fld_dgcVATs.BOSFieldRelation = null;
            this.fld_dgcVATs.BOSPrivilege = null;
            this.fld_dgcVATs.BOSPropertyName = null;
            this.fld_dgcVATs.Location = new System.Drawing.Point(32, 325);
            this.fld_dgcVATs.MenuManager = this.screenToolbar;
            this.fld_dgcVATs.Name = "fld_dgcVATs";
            this.fld_dgcVATs.Screen = null;
            this.fld_dgcVATs.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcVATs.TabIndex = 11;
            this.fld_dgcVATs.Tag = "SR";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(32, 31);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(61, 13);
            this.bosLabel11.TabIndex = 13;
            this.bosLabel11.Tag = "SI";
            this.bosLabel11.Text = "Mã chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ACVATNo";
            this.bosTextBox1.BOSDataSource = "ACVATs";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(148, 28);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(131, 20);
            this.bosTextBox1.TabIndex = 12;
            this.bosTextBox1.Tag = "SC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel17.Location = new System.Drawing.Point(32, 57);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(66, 13);
            this.bosLabel17.TabIndex = 113;
            this.bosLabel17.Tag = "SI";
            this.bosLabel17.Text = "Loại chứng từ";
            // 
            // fld_lkeACVATInvoiceType
            // 
            this.fld_lkeACVATInvoiceType.BOSAllowAddNew = false;
            this.fld_lkeACVATInvoiceType.BOSAllowDummy = false;
            this.fld_lkeACVATInvoiceType.BOSComment = null;
            this.fld_lkeACVATInvoiceType.BOSDataMember = "ACVATInvoiceType";
            this.fld_lkeACVATInvoiceType.BOSDataSource = "ACVATs";
            this.fld_lkeACVATInvoiceType.BOSDescription = null;
            this.fld_lkeACVATInvoiceType.BOSError = null;
            this.fld_lkeACVATInvoiceType.BOSFieldGroup = null;
            this.fld_lkeACVATInvoiceType.BOSFieldParent = null;
            this.fld_lkeACVATInvoiceType.BOSFieldRelation = null;
            this.fld_lkeACVATInvoiceType.BOSPrivilege = null;
            this.fld_lkeACVATInvoiceType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATInvoiceType.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATInvoiceType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATInvoiceType.CurrentDisplayText = null;
            this.fld_lkeACVATInvoiceType.Location = new System.Drawing.Point(148, 54);
            this.fld_lkeACVATInvoiceType.Name = "fld_lkeACVATInvoiceType";
            this.fld_lkeACVATInvoiceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATInvoiceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATInvoiceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATInvoiceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATInvoiceType.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATInvoiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATInvoiceType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACVATInvoiceType, true);
            this.fld_lkeACVATInvoiceType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACVATInvoiceType.TabIndex = 112;
            this.fld_lkeACVATInvoiceType.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(32, 83);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 115;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Loại hóa đơn";
            // 
            // fld_lkeACVATDocumentType
            // 
            this.fld_lkeACVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeACVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeACVATDocumentType.BOSComment = null;
            this.fld_lkeACVATDocumentType.BOSDataMember = "ACVATDocumentType";
            this.fld_lkeACVATDocumentType.BOSDataSource = "ACVATs";
            this.fld_lkeACVATDocumentType.BOSDescription = null;
            this.fld_lkeACVATDocumentType.BOSError = null;
            this.fld_lkeACVATDocumentType.BOSFieldGroup = null;
            this.fld_lkeACVATDocumentType.BOSFieldParent = null;
            this.fld_lkeACVATDocumentType.BOSFieldRelation = null;
            this.fld_lkeACVATDocumentType.BOSPrivilege = null;
            this.fld_lkeACVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATDocumentType.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeACVATDocumentType.Location = new System.Drawing.Point(148, 80);
            this.fld_lkeACVATDocumentType.Name = "fld_lkeACVATDocumentType";
            this.fld_lkeACVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATDocumentType.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATDocumentType.Screen = null;
            this.fld_lkeACVATDocumentType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACVATDocumentType.TabIndex = 114;
            this.fld_lkeACVATDocumentType.Tag = "SC";
            // 
            // fld_txtACVATSymbol
            // 
            this.fld_txtACVATSymbol.BOSComment = null;
            this.fld_txtACVATSymbol.BOSDataMember = "ACVATSymbol";
            this.fld_txtACVATSymbol.BOSDataSource = "ACVATs";
            this.fld_txtACVATSymbol.BOSDescription = null;
            this.fld_txtACVATSymbol.BOSError = null;
            this.fld_txtACVATSymbol.BOSFieldGroup = null;
            this.fld_txtACVATSymbol.BOSFieldRelation = null;
            this.fld_txtACVATSymbol.BOSPrivilege = null;
            this.fld_txtACVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtACVATSymbol.Location = new System.Drawing.Point(148, 106);
            this.fld_txtACVATSymbol.MenuManager = this.screenToolbar;
            this.fld_txtACVATSymbol.Name = "fld_txtACVATSymbol";
            this.fld_txtACVATSymbol.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtACVATSymbol, false);
            this.fld_txtACVATSymbol.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATSymbol.TabIndex = 116;
            this.fld_txtACVATSymbol.Tag = "SC";
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
            this.bosLabel10.Location = new System.Drawing.Point(32, 109);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(32, 13);
            this.bosLabel10.TabIndex = 117;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Số seri";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(32, 212);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel13.TabIndex = 428;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Ngày hóa đơn";
            // 
            // fld_dteACVATInvoiceDate
            // 
            this.fld_dteACVATInvoiceDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDate.BOSDataMember = "ACVATInvoiceDate";
            this.fld_dteACVATInvoiceDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATInvoiceDate.BOSDescription = null;
            this.fld_dteACVATInvoiceDate.BOSError = null;
            this.fld_dteACVATInvoiceDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATInvoiceDate.EditValue = null;
            this.fld_dteACVATInvoiceDate.Location = new System.Drawing.Point(148, 209);
            this.fld_dteACVATInvoiceDate.Name = "fld_dteACVATInvoiceDate";
            this.fld_dteACVATInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATInvoiceDate.Screen = null;
            this.fld_dteACVATInvoiceDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATInvoiceDate.TabIndex = 427;
            this.fld_dteACVATInvoiceDate.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACVATs";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(148, 157);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 430;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(32, 160);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 429;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(32, 186);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(110, 13);
            this.bosLabel1.TabIndex = 432;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Ngày giao hóa đơn gốc";
            // 
            // fld_dteACVATInvoiceDeliveryDate
            // 
            this.fld_dteACVATInvoiceDeliveryDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDeliveryDate.BOSDataMember = "ACVATInvoiceDeliveryDate";
            this.fld_dteACVATInvoiceDeliveryDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATInvoiceDeliveryDate.BOSDescription = null;
            this.fld_dteACVATInvoiceDeliveryDate.BOSError = null;
            this.fld_dteACVATInvoiceDeliveryDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDeliveryDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDeliveryDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATInvoiceDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATInvoiceDeliveryDate.EditValue = null;
            this.fld_dteACVATInvoiceDeliveryDate.Location = new System.Drawing.Point(148, 183);
            this.fld_dteACVATInvoiceDeliveryDate.Name = "fld_dteACVATInvoiceDeliveryDate";
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATInvoiceDeliveryDate.Screen = null;
            this.fld_dteACVATInvoiceDeliveryDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATInvoiceDeliveryDate.TabIndex = 431;
            this.fld_dteACVATInvoiceDeliveryDate.Tag = "SC";
            // 
            // fld_txtACVATInvoiceNo
            // 
            this.fld_txtACVATInvoiceNo.BOSComment = null;
            this.fld_txtACVATInvoiceNo.BOSDataMember = "ACVATInvoiceNo";
            this.fld_txtACVATInvoiceNo.BOSDataSource = "ACVATs";
            this.fld_txtACVATInvoiceNo.BOSDescription = null;
            this.fld_txtACVATInvoiceNo.BOSError = null;
            this.fld_txtACVATInvoiceNo.BOSFieldGroup = null;
            this.fld_txtACVATInvoiceNo.BOSFieldRelation = null;
            this.fld_txtACVATInvoiceNo.BOSPrivilege = null;
            this.fld_txtACVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtACVATInvoiceNo.Location = new System.Drawing.Point(148, 132);
            this.fld_txtACVATInvoiceNo.MenuManager = this.screenToolbar;
            this.fld_txtACVATInvoiceNo.Name = "fld_txtACVATInvoiceNo";
            this.fld_txtACVATInvoiceNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtACVATInvoiceNo, false);
            this.fld_txtACVATInvoiceNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATInvoiceNo.TabIndex = 433;
            this.fld_txtACVATInvoiceNo.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(32, 135);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(54, 13);
            this.bosLabel3.TabIndex = 434;
            this.bosLabel3.Text = "Số hóa đơn";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(32, 238);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 437;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(326, 238);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 438;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đến";
            // 
            // fld_dteACVATDate
            // 
            this.fld_dteACVATDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATDate.BOSDataMember = "VATDateFrom";
            this.fld_dteACVATDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATDate.BOSDescription = null;
            this.fld_dteACVATDate.BOSError = null;
            this.fld_dteACVATDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVATDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATDate.EditValue = null;
            this.fld_dteACVATDate.Location = new System.Drawing.Point(148, 235);
            this.fld_dteACVATDate.Name = "fld_dteACVATDate";
            this.fld_dteACVATDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATDate.Screen = null;
            this.fld_dteACVATDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATDate.TabIndex = 435;
            this.fld_dteACVATDate.Tag = "SC";
            // 
            // fld_dteACVAT
            // 
            this.fld_dteACVAT.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVAT.BOSDataMember = "VATDateTo";
            this.fld_dteACVAT.BOSDataSource = "ACVATs";
            this.fld_dteACVAT.BOSDescription = null;
            this.fld_dteACVAT.BOSError = null;
            this.fld_dteACVAT.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVAT.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVAT.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteACVAT.BOSPropertyName = "EditValue";
            this.fld_dteACVAT.EditValue = null;
            this.fld_dteACVAT.Location = new System.Drawing.Point(370, 235);
            this.fld_dteACVAT.Name = "fld_dteACVAT";
            this.fld_dteACVAT.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVAT.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVAT.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVAT.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVAT.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVAT.Screen = null;
            this.fld_dteACVAT.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVAT.TabIndex = 436;
            this.fld_dteACVAT.Tag = "SC";
            // 
            // SMACVAT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_dteACVATDate);
            this.Controls.Add(this.fld_dteACVAT);
            this.Controls.Add(this.fld_txtACVATInvoiceNo);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dteACVATInvoiceDeliveryDate);
            this.Controls.Add(this.fld_txtACVATSymbol);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_dteACVATInvoiceDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeACVATDocumentType);
            this.Controls.Add(this.bosLabel17);
            this.Controls.Add(this.fld_lkeACVATInvoiceType);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_dgcVATs);
            this.Name = "SMACVAT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcVATs, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeACVATInvoiceType, 0);
            this.Controls.SetChildIndex(this.bosLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeACVATDocumentType, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteACVATInvoiceDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_txtACVATSymbol, 0);
            this.Controls.SetChildIndex(this.fld_dteACVATInvoiceDeliveryDate, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtACVATInvoiceNo, 0);
            this.Controls.SetChildIndex(this.fld_dteACVAT, 0);
            this.Controls.SetChildIndex(this.fld_dteACVATDate, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVATs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVAT.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVAT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private VATSearchResultGridControl fld_dgcVATs;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeACVATInvoiceType;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeACVATDocumentType;
        private BOSComponent.BOSTextBox fld_txtACVATSymbol;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSDateEdit fld_dteACVATInvoiceDate;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteACVATInvoiceDeliveryDate;
        private BOSComponent.BOSTextBox fld_txtACVATInvoiceNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteACVATDate;
        private BOSComponent.BOSDateEdit fld_dteACVAT;
	}
}
