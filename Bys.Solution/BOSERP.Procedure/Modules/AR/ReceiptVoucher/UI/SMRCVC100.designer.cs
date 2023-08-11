using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReceiptVoucher.UI
{
	/// <summary>
	/// Summary description for SMRCVC100
	/// </summary>
	partial class SMRCVC100
	{
        private BOSComponent.BOSTextBox fld_txtARReceiptVoucherNo;
        private ReceiptVoucherGridControl fld_dgcARReceiptVoucher;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARReceiptVoucher;


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
            this.fld_txtARReceiptVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcARReceiptVoucher = new BOSERP.Modules.ReceiptVoucher.ReceiptVoucherGridControl();
            this.fld_dgvARReceiptVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromARReceiptVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARReceiptVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARReceiptVoucherType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceiptVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARReceiptVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceiptVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceiptVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceiptVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceiptVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceiptVoucherType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARReceiptVoucherNo
            // 
            this.fld_txtARReceiptVoucherNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARReceiptVoucherNo.BOSDataMember = "ARReceiptVoucherNo";
            this.fld_txtARReceiptVoucherNo.BOSDataSource = "ARReceiptVouchers";
            this.fld_txtARReceiptVoucherNo.BOSDescription = null;
            this.fld_txtARReceiptVoucherNo.BOSError = null;
            this.fld_txtARReceiptVoucherNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARReceiptVoucherNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARReceiptVoucherNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARReceiptVoucherNo.BOSPropertyName = "Text";
            this.fld_txtARReceiptVoucherNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARReceiptVoucherNo.Location = new System.Drawing.Point(124, 24);
            this.fld_txtARReceiptVoucherNo.Name = "fld_txtARReceiptVoucherNo";
            this.fld_txtARReceiptVoucherNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARReceiptVoucherNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARReceiptVoucherNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARReceiptVoucherNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARReceiptVoucherNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARReceiptVoucherNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARReceiptVoucherNo.Screen = null;
            this.fld_txtARReceiptVoucherNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARReceiptVoucherNo.TabIndex = 0;
            this.fld_txtARReceiptVoucherNo.Tag = "SC";
            // 
            // fld_dgcARReceiptVoucher
            // 
            this.fld_dgcARReceiptVoucher.AllowDrop = true;
            this.fld_dgcARReceiptVoucher.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.BOSDataSource = "ARReceiptVouchers";
            this.fld_dgcARReceiptVoucher.BOSDescription = null;
            this.fld_dgcARReceiptVoucher.BOSError = null;
            this.fld_dgcARReceiptVoucher.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARReceiptVoucher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARReceiptVoucher.Location = new System.Drawing.Point(12, 215);
            this.fld_dgcARReceiptVoucher.MainView = this.fld_dgvARReceiptVoucher;
            this.fld_dgcARReceiptVoucher.Name = "fld_dgcARReceiptVoucher";
            this.fld_dgcARReceiptVoucher.Screen = null;
            this.fld_dgcARReceiptVoucher.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcARReceiptVoucher.TabIndex = 6;
            this.fld_dgcARReceiptVoucher.Tag = "SR";
            this.fld_dgcARReceiptVoucher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARReceiptVoucher});
            // 
            // fld_dgvARReceiptVoucher
            // 
            this.fld_dgvARReceiptVoucher.GridControl = this.fld_dgcARReceiptVoucher;
            this.fld_dgvARReceiptVoucher.Name = "fld_dgvARReceiptVoucher";
            this.fld_dgvARReceiptVoucher.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARReceiptVouchers";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(124, 76);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.Location = new System.Drawing.Point(23, 105);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 15;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.Location = new System.Drawing.Point(23, 157);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel14.TabIndex = 19;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.Location = new System.Drawing.Point(295, 157);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 20;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(124, 102);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromARReceiptVoucherDate
            // 
            this.fld_dteSearchFromARReceiptVoucherDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSDataMember = "ReceiptVoucherDateFrom";
            this.fld_dteSearchFromARReceiptVoucherDate.BOSDataSource = "ARReceiptVouchers";
            this.fld_dteSearchFromARReceiptVoucherDate.BOSDescription = null;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSError = null;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARReceiptVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARReceiptVoucherDate.EditValue = null;
            this.fld_dteSearchFromARReceiptVoucherDate.Location = new System.Drawing.Point(124, 154);
            this.fld_dteSearchFromARReceiptVoucherDate.Name = "fld_dteSearchFromARReceiptVoucherDate";
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARReceiptVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARReceiptVoucherDate.Screen = null;
            this.fld_dteSearchFromARReceiptVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARReceiptVoucherDate.TabIndex = 5;
            this.fld_dteSearchFromARReceiptVoucherDate.Tag = "SC";
            // 
            // fld_dteSearchToARReceiptVoucherDate
            // 
            this.fld_dteSearchToARReceiptVoucherDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARReceiptVoucherDate.BOSDataMember = "ReceiptVoucherDateTo";
            this.fld_dteSearchToARReceiptVoucherDate.BOSDataSource = "ARReceiptVouchers";
            this.fld_dteSearchToARReceiptVoucherDate.BOSDescription = null;
            this.fld_dteSearchToARReceiptVoucherDate.BOSError = null;
            this.fld_dteSearchToARReceiptVoucherDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARReceiptVoucherDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARReceiptVoucherDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARReceiptVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARReceiptVoucherDate.EditValue = null;
            this.fld_dteSearchToARReceiptVoucherDate.Location = new System.Drawing.Point(329, 154);
            this.fld_dteSearchToARReceiptVoucherDate.Name = "fld_dteSearchToARReceiptVoucherDate";
            this.fld_dteSearchToARReceiptVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARReceiptVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARReceiptVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARReceiptVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARReceiptVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARReceiptVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARReceiptVoucherDate.Screen = null;
            this.fld_dteSearchToARReceiptVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARReceiptVoucherDate.TabIndex = 6;
            this.fld_dteSearchToARReceiptVoucherDate.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(23, 79);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đối tượng";
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
            this.bosLabel3.Location = new System.Drawing.Point(23, 27);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Mã chứng từ";
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
            this.bosLabel1.Location = new System.Drawing.Point(23, 53);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(66, 13);
            this.bosLabel1.TabIndex = 10;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Loại chứng từ";
            // 
            // fld_lkeARReceiptVoucherType
            // 
            this.fld_lkeARReceiptVoucherType.BOSAllowAddNew = false;
            this.fld_lkeARReceiptVoucherType.BOSAllowDummy = true;
            this.fld_lkeARReceiptVoucherType.BOSComment = null;
            this.fld_lkeARReceiptVoucherType.BOSDataMember = "ARReceiptVoucherType";
            this.fld_lkeARReceiptVoucherType.BOSDataSource = "ARReceiptVouchers";
            this.fld_lkeARReceiptVoucherType.BOSDescription = null;
            this.fld_lkeARReceiptVoucherType.BOSError = null;
            this.fld_lkeARReceiptVoucherType.BOSFieldGroup = null;
            this.fld_lkeARReceiptVoucherType.BOSFieldParent = null;
            this.fld_lkeARReceiptVoucherType.BOSFieldRelation = null;
            this.fld_lkeARReceiptVoucherType.BOSPrivilege = null;
            this.fld_lkeARReceiptVoucherType.BOSPropertyName = "EditValue";
            this.fld_lkeARReceiptVoucherType.BOSSelectType = null;
            this.fld_lkeARReceiptVoucherType.BOSSelectTypeValue = null;
            this.fld_lkeARReceiptVoucherType.CurrentDisplayText = null;
            this.fld_lkeARReceiptVoucherType.Location = new System.Drawing.Point(124, 50);
            this.fld_lkeARReceiptVoucherType.MenuManager = this.screenToolbar;
            this.fld_lkeARReceiptVoucherType.Name = "fld_lkeARReceiptVoucherType";
            this.fld_lkeARReceiptVoucherType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARReceiptVoucherType.Screen = null;
            this.fld_lkeARReceiptVoucherType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARReceiptVoucherType.TabIndex = 1;
            this.fld_lkeARReceiptVoucherType.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(23, 131);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 26;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARReceiptVouchers";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(124, 128);
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
            // SMRCVC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeARReceiptVoucherType);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dteSearchFromARReceiptVoucherDate);
            this.Controls.Add(this.fld_dteSearchToARReceiptVoucherDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtARReceiptVoucherNo);
            this.Controls.Add(this.fld_dgcARReceiptVoucher);
            this.Name = "SMRCVC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcARReceiptVoucher, 0);
            this.Controls.SetChildIndex(this.fld_txtARReceiptVoucherNo, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARReceiptVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARReceiptVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_lkeARReceiptVoucherType, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARReceiptVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARReceiptVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARReceiptVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceiptVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARReceiptVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceiptVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARReceiptVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARReceiptVoucherType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARReceiptVoucherDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARReceiptVoucherDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeARReceiptVoucherType;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
