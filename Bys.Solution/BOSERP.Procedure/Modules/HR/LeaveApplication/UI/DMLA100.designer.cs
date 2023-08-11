using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LeaveApplication.UI
{
	/// <summary>
	/// Summary description for DMLA100
	/// </summary>
	partial class DMLA100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSTextBox fld_txtHRRequestLeaveDayNo;
		private BOSComponent.BOSTextBox fld_txtHRRequestLeaveDayNote;
        private BOSComponent.BOSDateEdit fld_dteHRRequestLeaveDayFromDate1;
		private BOSComponent.BOSMemoEdit fld_medHRRequestLeaveDayReason;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
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
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRTimeSheetParamID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRRequestLeaveDayStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRApproveEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeLeaveID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRRequestLeaveDayEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteHRLeaveApplicationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRRequestLeaveDayToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRRequestLeaveDayToHour = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRequestLeaveDayFromHour = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRequestLeaveDayNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRequestLeaveDayNote = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRRequestLeaveDayFromDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHRRequestLeaveDayReason = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRRequestLeaveDays = new BOSERP.Modules.LeaveApplication.HRRequestLeaveDaysGridControl();
            this.fld_dgvHREmployeeOTs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetParamID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRequestLeaveDayStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRApproveEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeLeaveID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRequestLeaveDayEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLeaveApplicationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLeaveApplicationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayToHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayFromHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayFromDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayFromDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRequestLeaveDayReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRequestLeaveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRTimeSheetParamID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHRRequestLeaveDayStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRApproveEmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeLeaveID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.fld_grcGroupControl.Controls.Add(this.fld_pteHRRequestLeaveDayEmployeePicture);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRLeaveApplicationDate);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRRequestLeaveDayToDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRRequestLeaveDayToHour);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRRequestLeaveDayFromHour);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRRequestLeaveDayNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRRequestLeaveDayNote);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRRequestLeaveDayFromDate1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRRequestLeaveDayReason);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1114, 170);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.Location = new System.Drawing.Point(760, 114);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(69, 13);
            this.bosLabel7.TabIndex = 111;
            this.bosLabel7.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel7.Text = "Loại nghỉ phép";
            // 
            // fld_lkeFK_HRTimeSheetParamID
            // 
            this.fld_lkeFK_HRTimeSheetParamID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTimeSheetParamID.BOSAllowDummy = false;
            this.fld_lkeFK_HRTimeSheetParamID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.BOSDataMember = "FK_HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeFK_HRTimeSheetParamID.BOSDescription = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSError = null;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTimeSheetParamID.BOSSelectType = "";
            this.fld_lkeFK_HRTimeSheetParamID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRTimeSheetParamID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.Location = new System.Drawing.Point(856, 111);
            this.fld_lkeFK_HRTimeSheetParamID.Name = "fld_lkeFK_HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTimeSheetParamID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTimeSheetParamName", "Loại nghỉ phép")});
            this.fld_lkeFK_HRTimeSheetParamID.Properties.DisplayMember = "HRTimeSheetParamName";
            this.fld_lkeFK_HRTimeSheetParamID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTimeSheetParamID.Properties.ValueMember = "HRTimeSheetParamID";
            this.fld_lkeFK_HRTimeSheetParamID.Screen = null;
            this.fld_lkeFK_HRTimeSheetParamID.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_HRTimeSheetParamID.TabIndex = 110;
            this.fld_lkeFK_HRTimeSheetParamID.Tag = "DC";
            this.fld_lkeFK_HRTimeSheetParamID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRTimeSheetParamID_QueryPopUp);
            // 
            // fld_lkeHRRequestLeaveDayStatus
            // 
            this.fld_lkeHRRequestLeaveDayStatus.BOSAllowAddNew = false;
            this.fld_lkeHRRequestLeaveDayStatus.BOSAllowDummy = true;
            this.fld_lkeHRRequestLeaveDayStatus.BOSComment = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSDataMember = "HRRequestLeaveDayStatus";
            this.fld_lkeHRRequestLeaveDayStatus.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeHRRequestLeaveDayStatus.BOSDescription = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSError = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSFieldGroup = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSFieldParent = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSFieldRelation = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSPrivilege = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRRequestLeaveDayStatus.BOSSelectType = null;
            this.fld_lkeHRRequestLeaveDayStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRRequestLeaveDayStatus.CurrentDisplayText = null;
            this.fld_lkeHRRequestLeaveDayStatus.Location = new System.Drawing.Point(856, 32);
            this.fld_lkeHRRequestLeaveDayStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRRequestLeaveDayStatus.Name = "fld_lkeHRRequestLeaveDayStatus";
            this.fld_lkeHRRequestLeaveDayStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRRequestLeaveDayStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRRequestLeaveDayStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRRequestLeaveDayStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRRequestLeaveDayStatus.Properties.ReadOnly = true;
            this.fld_lkeHRRequestLeaveDayStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRRequestLeaveDayStatus.Screen = null;
            this.fld_lkeHRRequestLeaveDayStatus.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeHRRequestLeaveDayStatus.TabIndex = 108;
            this.fld_lkeHRRequestLeaveDayStatus.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(760, 35);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 109;
            this.bosLabel6.Text = "Tình trạng";
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
            this.bosLabel5.Location = new System.Drawing.Point(760, 87);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(59, 13);
            this.bosLabel5.TabIndex = 84;
            this.bosLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel5.Text = "Người duyệt";
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
            this.bosLabel4.Location = new System.Drawing.Point(129, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(47, 13);
            this.bosLabel4.TabIndex = 83;
            this.bosLabel4.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel4.Text = "Người tạo";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(409, 87);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(71, 13);
            this.bosLabel3.TabIndex = 82;
            this.bosLabel3.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Text = "Nhân viên nghỉ";
            // 
            // fld_lkeFK_HRApproveEmployeeID
            // 
            this.fld_lkeFK_HRApproveEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRApproveEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRApproveEmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSDataMember = "FK_HRApproveEmployeeID";
            this.fld_lkeFK_HRApproveEmployeeID.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeFK_HRApproveEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRApproveEmployeeID.BOSError = null;
            this.fld_lkeFK_HRApproveEmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRApproveEmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.Location = new System.Drawing.Point(856, 84);
            this.fld_lkeFK_HRApproveEmployeeID.Name = "fld_lkeFK_HRApproveEmployeeID";
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRApproveEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HRApproveEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRApproveEmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.ReadOnly = true;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRApproveEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRApproveEmployeeID.Screen = null;
            this.fld_lkeFK_HRApproveEmployeeID.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_HRApproveEmployeeID.TabIndex = 81;
            this.fld_lkeFK_HRApproveEmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeLeaveID
            // 
            this.fld_lkeFK_HREmployeeLeaveID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeLeaveID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeLeaveID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSDataMember = "FK_HREmployeeLeaveID";
            this.fld_lkeFK_HREmployeeLeaveID.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeFK_HREmployeeLeaveID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeLeaveID.BOSError = null;
            this.fld_lkeFK_HREmployeeLeaveID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeLeaveID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.Location = new System.Drawing.Point(502, 84);
            this.fld_lkeFK_HREmployeeLeaveID.Name = "fld_lkeFK_HREmployeeLeaveID";
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeLeaveID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeLeaveID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeLeaveID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeLeaveID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeLeaveID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeLeaveID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeLeaveID.Screen = null;
            this.fld_lkeFK_HREmployeeLeaveID.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_HREmployeeLeaveID.TabIndex = 80;
            this.fld_lkeFK_HREmployeeLeaveID.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(217, 84);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(166, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 79;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteHRRequestLeaveDayEmployeePicture
            // 
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSComment = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSDataMember = "HRRequestLeaveDayEmployeePicture";
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSDataSource = "HRRequestLeaveDays";
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSDescription = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSError = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRRequestLeaveDayEmployeePicture.Location = new System.Drawing.Point(12, 35);
            this.fld_pteHRRequestLeaveDayEmployeePicture.Name = "fld_pteHRRequestLeaveDayEmployeePicture";
            this.fld_pteHRRequestLeaveDayEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRRequestLeaveDayEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRRequestLeaveDayEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRRequestLeaveDayEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRRequestLeaveDayEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRRequestLeaveDayEmployeePicture.Screen = null;
            this.fld_pteHRRequestLeaveDayEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRRequestLeaveDayEmployeePicture.TabIndex = 78;
            this.fld_pteHRRequestLeaveDayEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRRequestLeaveDays";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(12, 137);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 77;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_dteHRLeaveApplicationDate
            // 
            this.fld_dteHRLeaveApplicationDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRLeaveApplicationDate.BOSDataMember = "HRLeaveApplicationDate";
            this.fld_dteHRLeaveApplicationDate.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dteHRLeaveApplicationDate.BOSDescription = null;
            this.fld_dteHRLeaveApplicationDate.BOSError = null;
            this.fld_dteHRLeaveApplicationDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRLeaveApplicationDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRLeaveApplicationDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRLeaveApplicationDate.BOSPropertyName = "EditValue";
            this.fld_dteHRLeaveApplicationDate.EditValue = null;
            this.fld_dteHRLeaveApplicationDate.Location = new System.Drawing.Point(217, 58);
            this.fld_dteHRLeaveApplicationDate.Name = "fld_dteHRLeaveApplicationDate";
            this.fld_dteHRLeaveApplicationDate.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_dteHRLeaveApplicationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRLeaveApplicationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRLeaveApplicationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRLeaveApplicationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRLeaveApplicationDate.Properties.ReadOnly = true;
            this.fld_dteHRLeaveApplicationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRLeaveApplicationDate.Screen = null;
            this.fld_dteHRLeaveApplicationDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteHRLeaveApplicationDate.TabIndex = 18;
            this.fld_dteHRLeaveApplicationDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(129, 61);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(72, 13);
            this.bosLabel1.TabIndex = 19;
            this.bosLabel1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Text = "Ngày chứng từ";
            // 
            // fld_dteHRRequestLeaveDayToDate
            // 
            this.fld_dteHRRequestLeaveDayToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayToDate.BOSDataMember = "HRRequestLeaveDayToDate";
            this.fld_dteHRRequestLeaveDayToDate.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dteHRRequestLeaveDayToDate.BOSDescription = null;
            this.fld_dteHRRequestLeaveDayToDate.BOSError = null;
            this.fld_dteHRRequestLeaveDayToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRequestLeaveDayToDate.EditValue = null;
            this.fld_dteHRRequestLeaveDayToDate.Location = new System.Drawing.Point(856, 58);
            this.fld_dteHRRequestLeaveDayToDate.Name = "fld_dteHRRequestLeaveDayToDate";
            this.fld_dteHRRequestLeaveDayToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRequestLeaveDayToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRequestLeaveDayToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRequestLeaveDayToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRequestLeaveDayToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRequestLeaveDayToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRequestLeaveDayToDate.Screen = null;
            this.fld_dteHRRequestLeaveDayToDate.Size = new System.Drawing.Size(166, 20);
            this.fld_dteHRRequestLeaveDayToDate.TabIndex = 4;
            this.fld_dteHRRequestLeaveDayToDate.Tag = "DC";
            // 
            // fld_txtHRRequestLeaveDayToHour
            // 
            this.fld_txtHRRequestLeaveDayToHour.BOSComment = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSDataMember = "HRRequestLeaveDayToHour";
            this.fld_txtHRRequestLeaveDayToHour.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtHRRequestLeaveDayToHour.BOSDescription = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSError = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSFieldGroup = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSFieldRelation = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSPrivilege = null;
            this.fld_txtHRRequestLeaveDayToHour.BOSPropertyName = "EditValue";
            this.fld_txtHRRequestLeaveDayToHour.Location = new System.Drawing.Point(1028, 58);
            this.fld_txtHRRequestLeaveDayToHour.Name = "fld_txtHRRequestLeaveDayToHour";
            this.fld_txtHRRequestLeaveDayToHour.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHRRequestLeaveDayToHour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHRRequestLeaveDayToHour.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHRRequestLeaveDayToHour.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHRRequestLeaveDayToHour.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHRRequestLeaveDayToHour.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHRRequestLeaveDayToHour.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRequestLeaveDayToHour.Properties.NullText = "00:00";
            this.fld_txtHRRequestLeaveDayToHour.Screen = null;
            this.fld_txtHRRequestLeaveDayToHour.Size = new System.Drawing.Size(55, 20);
            this.fld_txtHRRequestLeaveDayToHour.TabIndex = 5;
            this.fld_txtHRRequestLeaveDayToHour.Tag = "DC";
            // 
            // fld_txtHRRequestLeaveDayFromHour
            // 
            this.fld_txtHRRequestLeaveDayFromHour.BOSComment = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSDataMember = "HRRequestLeaveDayFromHour";
            this.fld_txtHRRequestLeaveDayFromHour.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtHRRequestLeaveDayFromHour.BOSDescription = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSError = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSFieldGroup = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSFieldRelation = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSPrivilege = null;
            this.fld_txtHRRequestLeaveDayFromHour.BOSPropertyName = "EditValue";
            this.fld_txtHRRequestLeaveDayFromHour.Location = new System.Drawing.Point(681, 58);
            this.fld_txtHRRequestLeaveDayFromHour.MenuManager = this.screenToolbar;
            this.fld_txtHRRequestLeaveDayFromHour.Name = "fld_txtHRRequestLeaveDayFromHour";
            this.fld_txtHRRequestLeaveDayFromHour.Properties.DisplayFormat.FormatString = "HH:mm";
            this.fld_txtHRRequestLeaveDayFromHour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHRRequestLeaveDayFromHour.Properties.EditFormat.FormatString = "HH:mm";
            this.fld_txtHRRequestLeaveDayFromHour.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_txtHRRequestLeaveDayFromHour.Properties.Mask.EditMask = "HH:mm";
            this.fld_txtHRRequestLeaveDayFromHour.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.fld_txtHRRequestLeaveDayFromHour.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRequestLeaveDayFromHour.Properties.NullText = "00:00";
            this.fld_txtHRRequestLeaveDayFromHour.Screen = null;
            this.fld_txtHRRequestLeaveDayFromHour.Size = new System.Drawing.Size(55, 20);
            this.fld_txtHRRequestLeaveDayFromHour.TabIndex = 3;
            this.fld_txtHRRequestLeaveDayFromHour.Tag = "DC";
            // 
            // fld_txtHRRequestLeaveDayNo
            // 
            this.fld_txtHRRequestLeaveDayNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNo.BOSDataMember = "HRRequestLeaveDayNo";
            this.fld_txtHRRequestLeaveDayNo.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtHRRequestLeaveDayNo.BOSDescription = null;
            this.fld_txtHRRequestLeaveDayNo.BOSError = null;
            this.fld_txtHRRequestLeaveDayNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNo.BOSPropertyName = "Text";
            this.fld_txtHRRequestLeaveDayNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNo.Location = new System.Drawing.Point(217, 32);
            this.fld_txtHRRequestLeaveDayNo.Name = "fld_txtHRRequestLeaveDayNo";
            this.fld_txtHRRequestLeaveDayNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRequestLeaveDayNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRequestLeaveDayNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRequestLeaveDayNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRequestLeaveDayNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRequestLeaveDayNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRequestLeaveDayNo.Screen = null;
            this.fld_txtHRRequestLeaveDayNo.Size = new System.Drawing.Size(166, 20);
            this.fld_txtHRRequestLeaveDayNo.TabIndex = 0;
            this.fld_txtHRRequestLeaveDayNo.Tag = "DC";
            // 
            // fld_txtHRRequestLeaveDayNote
            // 
            this.fld_txtHRRequestLeaveDayNote.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNote.BOSDataMember = "HRRequestLeaveDayNote";
            this.fld_txtHRRequestLeaveDayNote.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtHRRequestLeaveDayNote.BOSDescription = null;
            this.fld_txtHRRequestLeaveDayNote.BOSError = null;
            this.fld_txtHRRequestLeaveDayNote.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNote.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNote.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNote.BOSPropertyName = "Text";
            this.fld_txtHRRequestLeaveDayNote.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRRequestLeaveDayNote.Location = new System.Drawing.Point(502, 32);
            this.fld_txtHRRequestLeaveDayNote.Name = "fld_txtHRRequestLeaveDayNote";
            this.fld_txtHRRequestLeaveDayNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRequestLeaveDayNote.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRequestLeaveDayNote.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRequestLeaveDayNote.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRequestLeaveDayNote.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRequestLeaveDayNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRequestLeaveDayNote.Screen = null;
            this.fld_txtHRRequestLeaveDayNote.Size = new System.Drawing.Size(234, 20);
            this.fld_txtHRRequestLeaveDayNote.TabIndex = 1;
            this.fld_txtHRRequestLeaveDayNote.Tag = "DC";
            // 
            // fld_dteHRRequestLeaveDayFromDate1
            // 
            this.fld_dteHRRequestLeaveDayFromDate1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSDataMember = "HRRequestLeaveDayFromDate";
            this.fld_dteHRRequestLeaveDayFromDate1.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dteHRRequestLeaveDayFromDate1.BOSDescription = null;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSError = null;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRRequestLeaveDayFromDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRRequestLeaveDayFromDate1.EditValue = null;
            this.fld_dteHRRequestLeaveDayFromDate1.Location = new System.Drawing.Point(502, 58);
            this.fld_dteHRRequestLeaveDayFromDate1.Name = "fld_dteHRRequestLeaveDayFromDate1";
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRequestLeaveDayFromDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRequestLeaveDayFromDate1.Screen = null;
            this.fld_dteHRRequestLeaveDayFromDate1.Size = new System.Drawing.Size(166, 20);
            this.fld_dteHRRequestLeaveDayFromDate1.TabIndex = 2;
            this.fld_dteHRRequestLeaveDayFromDate1.Tag = "DC";
            // 
            // fld_medHRRequestLeaveDayReason
            // 
            this.fld_medHRRequestLeaveDayReason.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRRequestLeaveDayReason.BOSDataMember = "HRRequestLeaveDayReason";
            this.fld_medHRRequestLeaveDayReason.BOSDataSource = "HRRequestLeaveDays";
            this.fld_medHRRequestLeaveDayReason.BOSDescription = null;
            this.fld_medHRRequestLeaveDayReason.BOSError = null;
            this.fld_medHRRequestLeaveDayReason.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRRequestLeaveDayReason.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRRequestLeaveDayReason.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRRequestLeaveDayReason.BOSPropertyName = "Text";
            this.fld_medHRRequestLeaveDayReason.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRRequestLeaveDayReason.Location = new System.Drawing.Point(217, 110);
            this.fld_medHRRequestLeaveDayReason.Name = "fld_medHRRequestLeaveDayReason";
            this.fld_medHRRequestLeaveDayReason.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRequestLeaveDayReason.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRequestLeaveDayReason.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRequestLeaveDayReason.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRequestLeaveDayReason.Screen = null;
            this.fld_medHRRequestLeaveDayReason.Size = new System.Drawing.Size(529, 46);
            this.fld_medHRRequestLeaveDayReason.TabIndex = 8;
            this.fld_medHRRequestLeaveDayReason.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(760, 61);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Text = "Ngày kết thúc nghỉ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(129, 35);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 13;
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(405, 35);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel5.TabIndex = 14;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Tên chứng từ";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(409, 61);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(88, 13);
            this.fld_lblLabel6.TabIndex = 15;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Ngày bắt đầu nghỉ";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(129, 113);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 17;
            this.fld_lblLabel8.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel8.Text = "Diễn giải";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRRequestLeaveDays);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 176);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(1114, 371);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHRRequestLeaveDays
            // 
            this.fld_dgcHRRequestLeaveDays.AllowDrop = true;
            this.fld_dgcHRRequestLeaveDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRRequestLeaveDays.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dgcHRRequestLeaveDays.BOSDescription = null;
            this.fld_dgcHRRequestLeaveDays.BOSError = null;
            this.fld_dgcHRRequestLeaveDays.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.BOSGridType = null;
            this.fld_dgcHRRequestLeaveDays.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRRequestLeaveDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRequestLeaveDays.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHRRequestLeaveDays.MainView = this.fld_dgvHREmployeeOTs;
            this.fld_dgcHRRequestLeaveDays.Name = "fld_dgcHRRequestLeaveDays";
            this.fld_dgcHRRequestLeaveDays.PrintReport = false;
            this.fld_dgcHRRequestLeaveDays.Screen = null;
            this.fld_dgcHRRequestLeaveDays.Size = new System.Drawing.Size(1106, 341);
            this.fld_dgcHRRequestLeaveDays.TabIndex = 1;
            this.fld_dgcHRRequestLeaveDays.Tag = "DC";
            this.fld_dgcHRRequestLeaveDays.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeOTs});
            // 
            // fld_dgvHREmployeeOTs
            // 
            this.fld_dgvHREmployeeOTs.GridControl = this.fld_dgcHRRequestLeaveDays;
            this.fld_dgvHREmployeeOTs.Name = "fld_dgvHREmployeeOTs";
            this.fld_dgvHREmployeeOTs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1114, 559);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMLA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1114, 559);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMLA100";
            this.Text = "Thông tin nghỉ phép";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTimeSheetParamID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRRequestLeaveDayStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRApproveEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeLeaveID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRequestLeaveDayEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLeaveApplicationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRLeaveApplicationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayToHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayFromHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRequestLeaveDayNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayFromDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRequestLeaveDayFromDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRequestLeaveDayReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRequestLeaveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeOTs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtHRRequestLeaveDayFromHour;
        private BOSComponent.BOSTextBox fld_txtHRRequestLeaveDayToHour;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHRRequestLeaveDayToDate;
        private BOSComponent.BOSDateEdit fld_dteHRLeaveApplicationDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSPictureEdit fld_pteHRRequestLeaveDayEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRApproveEmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeLeaveID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeHRRequestLeaveDayStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private HRRequestLeaveDaysGridControl fld_dgcHRRequestLeaveDays;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeOTs;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRTimeSheetParamID;
	}
}
