using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BugManagement.UI
{
	/// <summary>
	/// Summary description for DMBM100
	/// </summary>
    partial class DMBM100
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtBugManagementNo1;
        private BOSComponent.BOSTextBox fld_txtBugManagementName1;
		private BOSComponent.BOSMemoEdit fld_medBugManagementDesc;
		private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnHandle = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRBugManagementDetailQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRBugManagementHandleWaitQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRBugManagementHandleType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtBugManagementNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtBugManagementName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medBugManagementDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementDetailQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementHandleWaitQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBugManagementHandleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBugManagementNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBugManagementName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBugManagementDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.bosLookupEdit1);
            this.fld_grcGroupControl.Controls.Add(this.bosLookupEdit2);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnHandle);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRBugManagementDetailQty);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRBugManagementHandleWaitQty);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHRBugManagementHandleType);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel17);
            this.fld_grcGroupControl.Controls.Add(this.fld_Lablel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeAPInvoiceInStatus);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBugManagementNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtBugManagementName1);
            this.fld_grcGroupControl.Controls.Add(this.bosDateEdit1);
            this.fld_grcGroupControl.Controls.Add(this.bosMemoEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medBugManagementDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(884, 562);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_HREmployeeID";
            this.bosLookupEdit1.BOSDataSource = "HRBugManagements";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(112, 54);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên")});
            this.bosLookupEdit1.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.Properties.Tag = "DC";
            this.bosLookupEdit1.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(160, 20);
            this.bosLookupEdit1.TabIndex = 29;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "FK_HRErrorTypeID";
            this.bosLookupEdit2.BOSDataSource = "HRBugManagements";
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
            this.bosLookupEdit2.Location = new System.Drawing.Point(674, 106);
            this.bosLookupEdit2.MenuManager = this.screenToolbar;
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRErrorTypeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRErrorTypeName", "Tên")});
            this.bosLookupEdit2.Properties.DisplayMember = "HRErrorTypeName";
            this.bosLookupEdit2.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.Properties.Tag = "";
            this.bosLookupEdit2.Properties.ValueMember = "HRErrorTypeID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(160, 20);
            this.bosLookupEdit2.TabIndex = 28;
            this.bosLookupEdit2.Tag = "DC";
            this.bosLookupEdit2.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRErrorTypeID_CloseUp);
            // 
            // fld_btnHandle
            // 
            this.fld_btnHandle.BOSComment = null;
            this.fld_btnHandle.BOSDataMember = null;
            this.fld_btnHandle.BOSDataSource = null;
            this.fld_btnHandle.BOSDescription = null;
            this.fld_btnHandle.BOSError = null;
            this.fld_btnHandle.BOSFieldGroup = null;
            this.fld_btnHandle.BOSFieldRelation = null;
            this.fld_btnHandle.BOSPrivilege = null;
            this.fld_btnHandle.BOSPropertyName = null;
            this.fld_btnHandle.Location = new System.Drawing.Point(674, 161);
            this.fld_btnHandle.Name = "fld_btnHandle";
            this.fld_btnHandle.Screen = null;
            this.fld_btnHandle.Size = new System.Drawing.Size(160, 27);
            this.fld_btnHandle.TabIndex = 26;
            this.fld_btnHandle.Text = "Xử lý";
            this.fld_btnHandle.Click += new System.EventHandler(this.fld_btnHandle_Click);
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "HRBugManagements";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(409, 54);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã công đoạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_MMOperationID, true);
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 9;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSDataMember = "HRBugManagementBarCode";
            this.bosTextBox1.BOSDataSource = "HRBugManagements";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.bosTextBox1.Location = new System.Drawing.Point(112, 80);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox1.TabIndex = 13;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.Validated += new System.EventHandler(this.fld_txtHRBugManagementDetailQty_Validated);
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 83);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(39, 13);
            this.bosLabel7.TabIndex = 12;
            this.bosLabel7.Text = "Barcode";
            // 
            // fld_txtHRBugManagementDetailQty
            // 
            this.fld_txtHRBugManagementDetailQty.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementDetailQty.BOSDataMember = "HRBugManagementDetailQty";
            this.fld_txtHRBugManagementDetailQty.BOSDataSource = "HRBugManagements";
            this.fld_txtHRBugManagementDetailQty.BOSDescription = null;
            this.fld_txtHRBugManagementDetailQty.BOSError = null;
            this.fld_txtHRBugManagementDetailQty.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementDetailQty.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementDetailQty.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementDetailQty.BOSPropertyName = "Text";
            this.fld_txtHRBugManagementDetailQty.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementDetailQty.Location = new System.Drawing.Point(409, 80);
            this.fld_txtHRBugManagementDetailQty.Name = "fld_txtHRBugManagementDetailQty";
            this.fld_txtHRBugManagementDetailQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBugManagementDetailQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBugManagementDetailQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBugManagementDetailQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBugManagementDetailQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBugManagementDetailQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBugManagementDetailQty.Screen = null;
            this.fld_txtHRBugManagementDetailQty.Size = new System.Drawing.Size(160, 20);
            this.fld_txtHRBugManagementDetailQty.TabIndex = 15;
            this.fld_txtHRBugManagementDetailQty.Tag = "DC";
            this.fld_txtHRBugManagementDetailQty.Validated += new System.EventHandler(this.fld_txtHRBugManagementDetailQty_Validated);
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
            this.bosLabel6.Location = new System.Drawing.Point(309, 83);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(59, 13);
            this.bosLabel6.TabIndex = 14;
            this.bosLabel6.Text = "SL chi tiết lỗi";
            // 
            // fld_txtHRBugManagementHandleWaitQty
            // 
            this.fld_txtHRBugManagementHandleWaitQty.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementHandleWaitQty.BOSDataMember = "HRBugManagementHandleWaitQty";
            this.fld_txtHRBugManagementHandleWaitQty.BOSDataSource = "HRBugManagements";
            this.fld_txtHRBugManagementHandleWaitQty.BOSDescription = null;
            this.fld_txtHRBugManagementHandleWaitQty.BOSError = null;
            this.fld_txtHRBugManagementHandleWaitQty.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementHandleWaitQty.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementHandleWaitQty.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementHandleWaitQty.BOSPropertyName = "Text";
            this.fld_txtHRBugManagementHandleWaitQty.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtHRBugManagementHandleWaitQty.Location = new System.Drawing.Point(674, 80);
            this.fld_txtHRBugManagementHandleWaitQty.Name = "fld_txtHRBugManagementHandleWaitQty";
            this.fld_txtHRBugManagementHandleWaitQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRBugManagementHandleWaitQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRBugManagementHandleWaitQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRBugManagementHandleWaitQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRBugManagementHandleWaitQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRBugManagementHandleWaitQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRBugManagementHandleWaitQty.Screen = null;
            this.fld_txtHRBugManagementHandleWaitQty.Size = new System.Drawing.Size(160, 20);
            this.fld_txtHRBugManagementHandleWaitQty.TabIndex = 17;
            this.fld_txtHRBugManagementHandleWaitQty.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(610, 83);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(58, 13);
            this.bosLabel11.TabIndex = 16;
            this.bosLabel11.Text = "SL cần xử lý";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Location = new System.Drawing.Point(309, 57);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "Công đoạn lỗi";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Location = new System.Drawing.Point(610, 109);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(19, 13);
            this.bosLabel2.TabIndex = 20;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Loại";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(610, 135);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(51, 13);
            this.bosLabel1.TabIndex = 24;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Cách xử lý";
            // 
            // fld_lkeHRBugManagementHandleType
            // 
            this.fld_lkeHRBugManagementHandleType.BOSAllowAddNew = false;
            this.fld_lkeHRBugManagementHandleType.BOSAllowDummy = false;
            this.fld_lkeHRBugManagementHandleType.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSDataMember = "HRBugManagementHandleType";
            this.fld_lkeHRBugManagementHandleType.BOSDataSource = "HRBugManagements";
            this.fld_lkeHRBugManagementHandleType.BOSDescription = null;
            this.fld_lkeHRBugManagementHandleType.BOSError = null;
            this.fld_lkeHRBugManagementHandleType.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSPropertyName = "EditValue";
            this.fld_lkeHRBugManagementHandleType.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.CurrentDisplayText = null;
            this.fld_lkeHRBugManagementHandleType.Location = new System.Drawing.Point(674, 132);
            this.fld_lkeHRBugManagementHandleType.Name = "fld_lkeHRBugManagementHandleType";
            this.fld_lkeHRBugManagementHandleType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRBugManagementHandleType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRBugManagementHandleType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRBugManagementHandleType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRBugManagementHandleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRBugManagementHandleType.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeHRBugManagementHandleType.Properties.PopupWidth = 40;
            this.fld_lkeHRBugManagementHandleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRBugManagementHandleType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHRBugManagementHandleType, true);
            this.fld_lkeHRBugManagementHandleType.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeHRBugManagementHandleType.TabIndex = 25;
            this.fld_lkeHRBugManagementHandleType.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.Location = new System.Drawing.Point(12, 57);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(72, 13);
            this.bosLabel17.TabIndex = 6;
            this.bosLabel17.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel17.Text = "Người ghi nhận";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.Location = new System.Drawing.Point(610, 57);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 10;
            this.fld_Lablel2.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lkeAPInvoiceInStatus
            // 
            this.fld_lkeAPInvoiceInStatus.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInStatus.BOSAllowDummy = false;
            this.fld_lkeAPInvoiceInStatus.BOSComment = null;
            this.fld_lkeAPInvoiceInStatus.BOSDataMember = "HRBugManagementStatus";
            this.fld_lkeAPInvoiceInStatus.BOSDataSource = "HRBugManagements";
            this.fld_lkeAPInvoiceInStatus.BOSDescription = null;
            this.fld_lkeAPInvoiceInStatus.BOSError = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldGroup = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldParent = null;
            this.fld_lkeAPInvoiceInStatus.BOSFieldRelation = null;
            this.fld_lkeAPInvoiceInStatus.BOSPrivilege = null;
            this.fld_lkeAPInvoiceInStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInStatus.BOSSelectType = null;
            this.fld_lkeAPInvoiceInStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPInvoiceInStatus.CurrentDisplayText = null;
            this.fld_lkeAPInvoiceInStatus.Location = new System.Drawing.Point(674, 54);
            this.fld_lkeAPInvoiceInStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPInvoiceInStatus.Name = "fld_lkeAPInvoiceInStatus";
            this.fld_lkeAPInvoiceInStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeAPInvoiceInStatus.Properties.ReadOnly = true;
            this.fld_lkeAPInvoiceInStatus.Screen = null;
            this.fld_lkeAPInvoiceInStatus.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeAPInvoiceInStatus.TabIndex = 11;
            this.fld_lkeAPInvoiceInStatus.Tag = "DC";
            // 
            // fld_txtBugManagementNo1
            // 
            this.fld_txtBugManagementNo1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementNo1.BOSDataMember = "HRBugManagementNo";
            this.fld_txtBugManagementNo1.BOSDataSource = "HRBugManagements";
            this.fld_txtBugManagementNo1.BOSDescription = null;
            this.fld_txtBugManagementNo1.BOSError = null;
            this.fld_txtBugManagementNo1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementNo1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementNo1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementNo1.BOSPropertyName = "Text";
            this.fld_txtBugManagementNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtBugManagementNo1.Location = new System.Drawing.Point(112, 28);
            this.fld_txtBugManagementNo1.Name = "fld_txtBugManagementNo1";
            this.fld_txtBugManagementNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBugManagementNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBugManagementNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBugManagementNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBugManagementNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBugManagementNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBugManagementNo1.Screen = null;
            this.fld_txtBugManagementNo1.Size = new System.Drawing.Size(160, 20);
            this.fld_txtBugManagementNo1.TabIndex = 1;
            this.fld_txtBugManagementNo1.Tag = "DC";
            // 
            // fld_txtBugManagementName1
            // 
            this.fld_txtBugManagementName1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementName1.BOSDataMember = "HRBugManagementName";
            this.fld_txtBugManagementName1.BOSDataSource = "HRBugManagements";
            this.fld_txtBugManagementName1.BOSDescription = null;
            this.fld_txtBugManagementName1.BOSError = null;
            this.fld_txtBugManagementName1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementName1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementName1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtBugManagementName1.BOSPropertyName = "Text";
            this.fld_txtBugManagementName1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtBugManagementName1.Location = new System.Drawing.Point(409, 28);
            this.fld_txtBugManagementName1.Name = "fld_txtBugManagementName1";
            this.fld_txtBugManagementName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBugManagementName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBugManagementName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBugManagementName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBugManagementName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBugManagementName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBugManagementName1.Screen = null;
            this.fld_txtBugManagementName1.Size = new System.Drawing.Size(160, 20);
            this.fld_txtBugManagementName1.TabIndex = 3;
            this.fld_txtBugManagementName1.Tag = "DC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSDataMember = "HRBugManagementDate";
            this.bosDateEdit1.BOSDataSource = "HRBugManagements";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(674, 28);
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
            this.bosDateEdit1.Size = new System.Drawing.Size(160, 20);
            this.bosDateEdit1.TabIndex = 5;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSDataMember = "HRBugManagementOvercome";
            this.bosMemoEdit1.BOSDataSource = "HRBugManagements";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosMemoEdit1.Location = new System.Drawing.Point(112, 106);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(457, 38);
            this.bosMemoEdit1.TabIndex = 19;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_medBugManagementDesc
            // 
            this.fld_medBugManagementDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medBugManagementDesc.BOSDataMember = "HRBugManagementDesc";
            this.fld_medBugManagementDesc.BOSDataSource = "HRBugManagements";
            this.fld_medBugManagementDesc.BOSDescription = null;
            this.fld_medBugManagementDesc.BOSError = null;
            this.fld_medBugManagementDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medBugManagementDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medBugManagementDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medBugManagementDesc.BOSPropertyName = "Text";
            this.fld_medBugManagementDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medBugManagementDesc.Location = new System.Drawing.Point(112, 150);
            this.fld_medBugManagementDesc.Name = "fld_medBugManagementDesc";
            this.fld_medBugManagementDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medBugManagementDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medBugManagementDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medBugManagementDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medBugManagementDesc.Screen = null;
            this.fld_medBugManagementDesc.Size = new System.Drawing.Size(457, 38);
            this.fld_medBugManagementDesc.TabIndex = 23;
            this.fld_medBugManagementDesc.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 31);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(309, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel5.TabIndex = 2;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Tên chứng từ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.Location = new System.Drawing.Point(12, 109);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 18;
            this.bosLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.Text = "Khắc phục";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel4.Location = new System.Drawing.Point(610, 31);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(25, 13);
            this.bosLabel4.TabIndex = 4;
            this.bosLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Text = "Ngày";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 153);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel8.TabIndex = 22;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Ghi chú";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 0;
            // 
            // DMBM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBM100";
            this.Text = "Quản lý lỗi thường gặp";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementDetailQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRBugManagementHandleWaitQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBugManagementHandleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBugManagementNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBugManagementName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBugManagementDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInStatus;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRBugManagementHandleType;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtHRBugManagementDetailQty;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtHRBugManagementHandleWaitQty;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSButton fld_btnHandle;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
	}
}
