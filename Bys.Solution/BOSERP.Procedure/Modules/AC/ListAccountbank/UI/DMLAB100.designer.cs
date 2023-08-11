using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ListAccountBank.UI
{
	/// <summary>
	/// Summary description for DMAS100
	/// </summary>
    partial class DMLAB100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMLAB100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACListAccountBankStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACListAccountBankAccountHolderIDCardDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACListAccountBankIBanNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACListAccountBankSwiftCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACVATObjectTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATObjectCareer = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACVATObjectAddress = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACListAccountbankNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATInvoiceDeliveryName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACListAccountBankStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountBankIBanNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountBankSwiftCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectCareer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountbankNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceDeliveryName.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEBankID);
            this.bosPanel1.Controls.Add(this.fld_lkeACListAccountBankStatus);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteACListAccountBankAccountHolderIDCardDate);
            this.bosPanel1.Controls.Add(this.fld_txtACListAccountBankIBanNumber);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_txtACListAccountBankSwiftCode);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosTextBox3);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_txtACVATObjectTaxNumber);
            this.bosPanel1.Controls.Add(this.fld_txtACVATObjectCareer);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.fld_txtACVATObjectAddress);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_txtACListAccountbankNo);
            this.bosPanel1.Controls.Add(this.fld_txtACVATInvoiceDeliveryName);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(860, 569);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel11.Location = new System.Drawing.Point(35, 79);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(52, 13);
            this.bosLabel11.TabIndex = 89;
            this.bosLabel11.Text = "Ngân hàng";
            // 
            // fld_lkeFK_GEBankID
            // 
            this.fld_lkeFK_GEBankID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEBankID.BOSAllowDummy = false;
            this.fld_lkeFK_GEBankID.BOSComment = null;
            this.fld_lkeFK_GEBankID.BOSDataMember = "FK_GEBankID";
            this.fld_lkeFK_GEBankID.BOSDataSource = "ACListAccountBanks";
            this.fld_lkeFK_GEBankID.BOSDescription = null;
            this.fld_lkeFK_GEBankID.BOSError = null;
            this.fld_lkeFK_GEBankID.BOSFieldGroup = null;
            this.fld_lkeFK_GEBankID.BOSFieldParent = null;
            this.fld_lkeFK_GEBankID.BOSFieldRelation = null;
            this.fld_lkeFK_GEBankID.BOSPrivilege = null;
            this.fld_lkeFK_GEBankID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEBankID.BOSSelectType = null;
            this.fld_lkeFK_GEBankID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEBankID.CurrentDisplayText = null;
            this.fld_lkeFK_GEBankID.Location = new System.Drawing.Point(124, 76);
            this.fld_lkeFK_GEBankID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GEBankID.Name = "fld_lkeFK_GEBankID";
            this.fld_lkeFK_GEBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEBankID.Properties.ColumnName = null;
            this.fld_lkeFK_GEBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEBankNo", "Mã giao dịch"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEBankName", "Tên ngân hàng")});
            this.fld_lkeFK_GEBankID.Properties.DisplayMember = "GEBankNo";
            this.fld_lkeFK_GEBankID.Properties.NullText = " ";
            this.fld_lkeFK_GEBankID.Properties.ValueMember = "GEBankID";
            this.fld_lkeFK_GEBankID.Screen = null;
            this.fld_lkeFK_GEBankID.Size = new System.Drawing.Size(486, 20);
            this.fld_lkeFK_GEBankID.TabIndex = 88;
            this.fld_lkeFK_GEBankID.Tag = "DC";
            this.fld_lkeFK_GEBankID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_GEBankID_Closed);
            // 
            // fld_lkeACListAccountBankStatus
            // 
            this.fld_lkeACListAccountBankStatus.BOSAllowAddNew = false;
            this.fld_lkeACListAccountBankStatus.BOSAllowDummy = false;
            this.fld_lkeACListAccountBankStatus.BOSComment = null;
            this.fld_lkeACListAccountBankStatus.BOSDataMember = "ACListAccountBankStatus";
            this.fld_lkeACListAccountBankStatus.BOSDataSource = "ACListAccountBanks";
            this.fld_lkeACListAccountBankStatus.BOSDescription = null;
            this.fld_lkeACListAccountBankStatus.BOSError = null;
            this.fld_lkeACListAccountBankStatus.BOSFieldGroup = null;
            this.fld_lkeACListAccountBankStatus.BOSFieldParent = null;
            this.fld_lkeACListAccountBankStatus.BOSFieldRelation = null;
            this.fld_lkeACListAccountBankStatus.BOSPrivilege = null;
            this.fld_lkeACListAccountBankStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACListAccountBankStatus.BOSSelectType = null;
            this.fld_lkeACListAccountBankStatus.BOSSelectTypeValue = null;
            this.fld_lkeACListAccountBankStatus.CurrentDisplayText = null;
            this.fld_lkeACListAccountBankStatus.EditValue = " ";
            this.fld_lkeACListAccountBankStatus.Enabled = false;
            this.fld_lkeACListAccountBankStatus.Location = new System.Drawing.Point(124, 287);
            this.fld_lkeACListAccountBankStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACListAccountBankStatus.Name = "fld_lkeACListAccountBankStatus";
            this.fld_lkeACListAccountBankStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACListAccountBankStatus.Properties.ColumnName = null;
            this.fld_lkeACListAccountBankStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", " ")});
            this.fld_lkeACListAccountBankStatus.Properties.DisplayMember = "GEStateProvinceName";
            this.fld_lkeACListAccountBankStatus.Properties.NullText = " ";
            this.fld_lkeACListAccountBankStatus.Properties.ValueMember = "GEStateProvinceID";
            this.fld_lkeACListAccountBankStatus.Screen = null;
            this.fld_lkeACListAccountBankStatus.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeACListAccountBankStatus.TabIndex = 87;
            this.fld_lkeACListAccountBankStatus.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = " ";
            this.bosLabel10.BOSDataMember = " ";
            this.bosLabel10.BOSDataSource = " ";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = " ";
            this.bosLabel10.BOSFieldRelation = " ";
            this.bosLabel10.BOSPrivilege = " ";
            this.bosLabel10.BOSPropertyName = " ";
            this.bosLabel10.Location = new System.Drawing.Point(35, 290);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(49, 13);
            this.bosLabel10.TabIndex = 86;
            this.bosLabel10.Tag = " ";
            this.bosLabel10.Text = "Trạng thái";
            // 
            // fld_dteACListAccountBankAccountHolderIDCardDate
            // 
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSComment = " ";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSDataMember = "ACListAccountBankAccountHolderIDCardDate";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSDataSource = "ACListAccountBanks";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSDescription = null;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSError = null;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSFieldGroup = " ";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSFieldRelation = " ";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSPrivilege = " ";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.BOSPropertyName = "EditValue";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.EditValue = null;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Location = new System.Drawing.Point(124, 261);
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Name = "fld_dteACListAccountBankAccountHolderIDCardDate";
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteACListAccountBankAccountHolderIDCardDate, true);
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Size = new System.Drawing.Size(192, 20);
            this.fld_dteACListAccountBankAccountHolderIDCardDate.TabIndex = 84;
            this.fld_dteACListAccountBankAccountHolderIDCardDate.Tag = "DC";
            // 
            // fld_txtACListAccountBankIBanNumber
            // 
            this.fld_txtACListAccountBankIBanNumber.BOSComment = null;
            this.fld_txtACListAccountBankIBanNumber.BOSDataMember = "ACListAccountBankIBanNumber";
            this.fld_txtACListAccountBankIBanNumber.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACListAccountBankIBanNumber.BOSDescription = null;
            this.fld_txtACListAccountBankIBanNumber.BOSError = null;
            this.fld_txtACListAccountBankIBanNumber.BOSFieldGroup = null;
            this.fld_txtACListAccountBankIBanNumber.BOSFieldRelation = null;
            this.fld_txtACListAccountBankIBanNumber.BOSPrivilege = null;
            this.fld_txtACListAccountBankIBanNumber.BOSPropertyName = "EditValue";
            this.fld_txtACListAccountBankIBanNumber.Location = new System.Drawing.Point(418, 50);
            this.fld_txtACListAccountBankIBanNumber.Name = "fld_txtACListAccountBankIBanNumber";
            this.fld_txtACListAccountBankIBanNumber.Screen = null;
            this.fld_txtACListAccountBankIBanNumber.Size = new System.Drawing.Size(192, 20);
            this.fld_txtACListAccountBankIBanNumber.TabIndex = 3;
            this.fld_txtACListAccountBankIBanNumber.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(349, 53);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(39, 13);
            this.bosLabel6.TabIndex = 83;
            this.bosLabel6.Text = "Số IBAN";
            // 
            // fld_txtACListAccountBankSwiftCode
            // 
            this.fld_txtACListAccountBankSwiftCode.BOSComment = null;
            this.fld_txtACListAccountBankSwiftCode.BOSDataMember = "ACListAccountBankSwiftCode";
            this.fld_txtACListAccountBankSwiftCode.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACListAccountBankSwiftCode.BOSDescription = null;
            this.fld_txtACListAccountBankSwiftCode.BOSError = null;
            this.fld_txtACListAccountBankSwiftCode.BOSFieldGroup = null;
            this.fld_txtACListAccountBankSwiftCode.BOSFieldRelation = null;
            this.fld_txtACListAccountBankSwiftCode.BOSPrivilege = null;
            this.fld_txtACListAccountBankSwiftCode.BOSPropertyName = "EditValue";
            this.fld_txtACListAccountBankSwiftCode.Location = new System.Drawing.Point(124, 50);
            this.fld_txtACListAccountBankSwiftCode.Name = "fld_txtACListAccountBankSwiftCode";
            this.fld_txtACListAccountBankSwiftCode.Screen = null;
            this.fld_txtACListAccountBankSwiftCode.Size = new System.Drawing.Size(192, 20);
            this.fld_txtACListAccountBankSwiftCode.TabIndex = 2;
            this.fld_txtACListAccountBankSwiftCode.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(35, 53);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(63, 13);
            this.bosLabel2.TabIndex = 81;
            this.bosLabel2.Text = "SWIFT CODE";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = null;
            this.bosTextBox2.BOSDataMember = "ACListAccountBankObjectAddress";
            this.bosTextBox2.BOSDataSource = "ACListAccountBanks";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = null;
            this.bosTextBox2.BOSFieldRelation = null;
            this.bosTextBox2.BOSPrivilege = null;
            this.bosTextBox2.BOSPropertyName = "EditValue";
            this.bosTextBox2.Location = new System.Drawing.Point(124, 209);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(486, 20);
            this.bosTextBox2.TabIndex = 8;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = " ";
            this.bosLabel1.BOSDataMember = " ";
            this.bosLabel1.BOSDataSource = " ";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = " ";
            this.bosLabel1.BOSFieldRelation = " ";
            this.bosLabel1.BOSPrivilege = " ";
            this.bosLabel1.BOSPropertyName = " ";
            this.bosLabel1.Location = new System.Drawing.Point(35, 212);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 78;
            this.bosLabel1.Tag = " ";
            this.bosLabel1.Text = "Địa chỉ";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = " ";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACListAccountBanks";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = " ";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = " ";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = " ";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = " ";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = " ";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = " ";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(124, 183);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, " ", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = " ";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(486, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 7;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACListAccountBankBranchCityID";
            this.bosLookupEdit1.BOSDataSource = "ACListAccountBanks";
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
            this.bosLookupEdit1.EditValue = " ";
            this.bosLookupEdit1.Location = new System.Drawing.Point(124, 154);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEStateProvinceName", " ")});
            this.bosLookupEdit1.Properties.DisplayMember = "GEStateProvinceName";
            this.bosLookupEdit1.Properties.NullText = " ";
            this.bosLookupEdit1.Properties.ValueMember = "GEStateProvinceID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(486, 20);
            this.bosLookupEdit1.TabIndex = 6;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "ACListAccountBankAccountHolderCity";
            this.bosTextBox3.BOSDataSource = "ACListAccountBanks";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "EditValue";
            this.bosTextBox3.Location = new System.Drawing.Point(418, 261);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(192, 20);
            this.bosTextBox3.TabIndex = 12;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ACListAccountBankAccount";
            this.bosTextBox1.BOSDataSource = "ACListAccountBanks";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(418, 23);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(192, 20);
            this.bosTextBox1.TabIndex = 1;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(349, 238);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(44, 13);
            this.bosLabel13.TabIndex = 69;
            this.bosLabel13.Text = "Số CMND";
            // 
            // fld_txtACVATObjectTaxNumber
            // 
            this.fld_txtACVATObjectTaxNumber.BOSComment = null;
            this.fld_txtACVATObjectTaxNumber.BOSDataMember = "ACListAccountBankAccountHolder";
            this.fld_txtACVATObjectTaxNumber.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACVATObjectTaxNumber.BOSDescription = null;
            this.fld_txtACVATObjectTaxNumber.BOSError = null;
            this.fld_txtACVATObjectTaxNumber.BOSFieldGroup = null;
            this.fld_txtACVATObjectTaxNumber.BOSFieldRelation = null;
            this.fld_txtACVATObjectTaxNumber.BOSPrivilege = null;
            this.fld_txtACVATObjectTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectTaxNumber.Location = new System.Drawing.Point(124, 235);
            this.fld_txtACVATObjectTaxNumber.Name = "fld_txtACVATObjectTaxNumber";
            this.fld_txtACVATObjectTaxNumber.Screen = null;
            this.fld_txtACVATObjectTaxNumber.Size = new System.Drawing.Size(192, 20);
            this.fld_txtACVATObjectTaxNumber.TabIndex = 9;
            this.fld_txtACVATObjectTaxNumber.Tag = "DC";
            // 
            // fld_txtACVATObjectCareer
            // 
            this.fld_txtACVATObjectCareer.BOSComment = null;
            this.fld_txtACVATObjectCareer.BOSDataMember = "ACListAccountBankAccountHolderIDNumber";
            this.fld_txtACVATObjectCareer.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACVATObjectCareer.BOSDescription = null;
            this.fld_txtACVATObjectCareer.BOSError = null;
            this.fld_txtACVATObjectCareer.BOSFieldGroup = null;
            this.fld_txtACVATObjectCareer.BOSFieldRelation = null;
            this.fld_txtACVATObjectCareer.BOSPrivilege = null;
            this.fld_txtACVATObjectCareer.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectCareer.Location = new System.Drawing.Point(418, 235);
            this.fld_txtACVATObjectCareer.Name = "fld_txtACVATObjectCareer";
            this.fld_txtACVATObjectCareer.Screen = null;
            this.fld_txtACVATObjectCareer.Size = new System.Drawing.Size(192, 20);
            this.fld_txtACVATObjectCareer.TabIndex = 10;
            this.fld_txtACVATObjectCareer.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(35, 238);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(81, 13);
            this.bosLabel12.TabIndex = 65;
            this.bosLabel12.Text = "Người thụ hưởng";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = " ";
            this.fld_lblLabel5.BOSDataMember = " ";
            this.fld_lblLabel5.BOSDataSource = " ";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = " ";
            this.fld_lblLabel5.BOSFieldRelation = " ";
            this.fld_lblLabel5.BOSPrivilege = " ";
            this.fld_lblLabel5.BOSPropertyName = " ";
            this.fld_lblLabel5.Location = new System.Drawing.Point(35, 186);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 62;
            this.fld_lblLabel5.Tag = " ";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(35, 105);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(72, 13);
            this.bosLabel14.TabIndex = 67;
            this.bosLabel14.Text = "Tên ngân hàng";
            // 
            // fld_txtACVATObjectAddress
            // 
            this.fld_txtACVATObjectAddress.BOSComment = null;
            this.fld_txtACVATObjectAddress.BOSDataMember = "ACListAccountBankName";
            this.fld_txtACVATObjectAddress.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACVATObjectAddress.BOSDescription = null;
            this.fld_txtACVATObjectAddress.BOSError = null;
            this.fld_txtACVATObjectAddress.BOSFieldGroup = null;
            this.fld_txtACVATObjectAddress.BOSFieldRelation = null;
            this.fld_txtACVATObjectAddress.BOSPrivilege = null;
            this.fld_txtACVATObjectAddress.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectAddress.EditValue = " ";
            this.fld_txtACVATObjectAddress.Location = new System.Drawing.Point(124, 102);
            this.fld_txtACVATObjectAddress.Name = "fld_txtACVATObjectAddress";
            this.fld_txtACVATObjectAddress.Screen = null;
            this.fld_txtACVATObjectAddress.Size = new System.Drawing.Size(486, 20);
            this.fld_txtACVATObjectAddress.TabIndex = 4;
            this.fld_txtACVATObjectAddress.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(35, 26);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(68, 13);
            this.bosLabel9.TabIndex = 63;
            this.bosLabel9.Text = "Mã ngân hàng";
            // 
            // fld_txtACListAccountbankNo
            // 
            this.fld_txtACListAccountbankNo.BOSComment = null;
            this.fld_txtACListAccountbankNo.BOSDataMember = "ACListAccountbankNo";
            this.fld_txtACListAccountbankNo.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACListAccountbankNo.BOSDescription = null;
            this.fld_txtACListAccountbankNo.BOSError = null;
            this.fld_txtACListAccountbankNo.BOSFieldGroup = null;
            this.fld_txtACListAccountbankNo.BOSFieldRelation = null;
            this.fld_txtACListAccountbankNo.BOSPrivilege = null;
            this.fld_txtACListAccountbankNo.BOSPropertyName = "EditValue";
            this.fld_txtACListAccountbankNo.Location = new System.Drawing.Point(124, 23);
            this.fld_txtACListAccountbankNo.Name = "fld_txtACListAccountbankNo";
            this.fld_txtACListAccountbankNo.Properties.ReadOnly = true;
            this.fld_txtACListAccountbankNo.Screen = null;
            this.fld_txtACListAccountbankNo.Size = new System.Drawing.Size(192, 20);
            this.fld_txtACListAccountbankNo.TabIndex = 0;
            this.fld_txtACListAccountbankNo.Tag = "DC";
            // 
            // fld_txtACVATInvoiceDeliveryName
            // 
            this.fld_txtACVATInvoiceDeliveryName.BOSComment = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSDataMember = "ACListAccountBankBranch";
            this.fld_txtACVATInvoiceDeliveryName.BOSDataSource = "ACListAccountBanks";
            this.fld_txtACVATInvoiceDeliveryName.BOSDescription = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSError = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSFieldGroup = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSFieldRelation = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSPrivilege = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSPropertyName = "EditValue";
            this.fld_txtACVATInvoiceDeliveryName.Location = new System.Drawing.Point(124, 128);
            this.fld_txtACVATInvoiceDeliveryName.Name = "fld_txtACVATInvoiceDeliveryName";
            this.fld_txtACVATInvoiceDeliveryName.Screen = null;
            this.fld_txtACVATInvoiceDeliveryName.Size = new System.Drawing.Size(486, 20);
            this.fld_txtACVATInvoiceDeliveryName.TabIndex = 5;
            this.fld_txtACVATInvoiceDeliveryName.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(35, 264);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 72;
            this.bosLabel7.Text = "Ngày cấp";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(349, 264);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(35, 13);
            this.bosLabel8.TabIndex = 75;
            this.bosLabel8.Text = "Nơi cấp";
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
            this.bosLabel5.Location = new System.Drawing.Point(349, 26);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(59, 13);
            this.bosLabel5.TabIndex = 71;
            this.bosLabel5.Text = "Số tài khoản";
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
            this.bosLabel4.Location = new System.Drawing.Point(35, 156);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(39, 13);
            this.bosLabel4.TabIndex = 76;
            this.bosLabel4.Text = "Tỉnh/ TP";
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
            this.bosLabel3.Location = new System.Drawing.Point(35, 131);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 73;
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // DMLAB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(860, 569);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMLAB100.IconOptions.Icon")));
            this.Name = "DMLAB100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACListAccountBankStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACListAccountBankAccountHolderIDCardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountBankIBanNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountBankSwiftCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectCareer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACListAccountbankNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceDeliveryName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtACVATObjectTaxNumber;
        private BOSComponent.BOSTextBox fld_txtACVATObjectCareer;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtACVATObjectAddress;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtACListAccountbankNo;
        private BOSComponent.BOSTextBox fld_txtACVATInvoiceDeliveryName;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox fld_txtACListAccountBankIBanNumber;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtACListAccountBankSwiftCode;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACListAccountBankAccountHolderIDCardDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeACListAccountBankStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEBankID;
    }
}
