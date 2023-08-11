using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaymentVoucher.UI
{
	/// <summary>
	/// Summary description for SMPMVC100
	/// </summary>
	partial class SMPMVC100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherNo;
		private PaymentVoucherGridControl fld_dgcAPPaymentVoucher;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPaymentVoucher;


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
            this.fld_txtAPPaymentVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcAPPaymentVoucher = new BOSERP.Modules.PaymentVoucher.PaymentVoucherGridControl();
            this.fld_dgvAPPaymentVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromAPPaymentVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPPaymentVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPaymentVoucherType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPaymentVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPaymentVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPaymentVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPaymentVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPaymentVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherType.Properties)).BeginInit();
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
            this.fld_lblLabel.Location = new System.Drawing.Point(22, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 0;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtAPPaymentVoucherNo
            // 
            this.fld_txtAPPaymentVoucherNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherNo.BOSDataMember = "APPaymentVoucherNo";
            this.fld_txtAPPaymentVoucherNo.BOSDataSource = "APPaymentVouchers";
            this.fld_txtAPPaymentVoucherNo.BOSDescription = null;
            this.fld_txtAPPaymentVoucherNo.BOSError = null;
            this.fld_txtAPPaymentVoucherNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherNo.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherNo.Location = new System.Drawing.Point(123, 12);
            this.fld_txtAPPaymentVoucherNo.Name = "fld_txtAPPaymentVoucherNo";
            this.fld_txtAPPaymentVoucherNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherNo.Screen = null;
            this.fld_txtAPPaymentVoucherNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherNo.TabIndex = 0;
            this.fld_txtAPPaymentVoucherNo.Tag = "SC";
            // 
            // fld_dgcAPPaymentVoucher
            // 
            this.fld_dgcAPPaymentVoucher.AllowDrop = true;
            this.fld_dgcAPPaymentVoucher.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.BOSDataSource = "APPaymentVouchers";
            this.fld_dgcAPPaymentVoucher.BOSDescription = null;
            this.fld_dgcAPPaymentVoucher.BOSError = null;
            this.fld_dgcAPPaymentVoucher.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcAPPaymentVoucher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPaymentVoucher.Location = new System.Drawing.Point(110, 240);
            this.fld_dgcAPPaymentVoucher.MainView = this.fld_dgvAPPaymentVoucher;
            this.fld_dgcAPPaymentVoucher.Name = "fld_dgcAPPaymentVoucher";
            this.fld_dgcAPPaymentVoucher.Screen = null;
            this.fld_dgcAPPaymentVoucher.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPPaymentVoucher.TabIndex = 10;
            this.fld_dgcAPPaymentVoucher.Tag = "SR";
            this.fld_dgcAPPaymentVoucher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPaymentVoucher});
            this.fld_dgcAPPaymentVoucher.Load += new System.EventHandler(this.fld_dgcAPPaymentVoucher_Load);
            // 
            // fld_dgvAPPaymentVoucher
            // 
            this.fld_dgvAPPaymentVoucher.GridControl = this.fld_dgcAPPaymentVoucher;
            this.fld_dgvAPPaymentVoucher.Name = "fld_dgvAPPaymentVoucher";
            this.fld_dgvAPPaymentVoucher.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = string.Empty;
            this.fld_lblLabel13.BOSDataMember = string.Empty;
            this.fld_lblLabel13.BOSDataSource = string.Empty;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = string.Empty;
            this.fld_lblLabel13.BOSFieldRelation = string.Empty;
            this.fld_lblLabel13.BOSPrivilege = string.Empty;
            this.fld_lblLabel13.BOSPropertyName = string.Empty;
            this.fld_lblLabel13.Location = new System.Drawing.Point(22, 93);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 4;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = string.Empty;
            this.fld_lblLabel14.BOSDataMember = string.Empty;
            this.fld_lblLabel14.BOSDataSource = string.Empty;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = string.Empty;
            this.fld_lblLabel14.BOSFieldRelation = string.Empty;
            this.fld_lblLabel14.BOSPrivilege = string.Empty;
            this.fld_lblLabel14.BOSPropertyName = string.Empty;
            this.fld_lblLabel14.Location = new System.Drawing.Point(22, 145);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel14.TabIndex = 6;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = string.Empty;
            this.fld_lblLabel17.BOSDataMember = string.Empty;
            this.fld_lblLabel17.BOSDataSource = string.Empty;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = string.Empty;
            this.fld_lblLabel17.BOSFieldRelation = string.Empty;
            this.fld_lblLabel17.BOSPrivilege = string.Empty;
            this.fld_lblLabel17.BOSPropertyName = string.Empty;
            this.fld_lblLabel17.Location = new System.Drawing.Point(294, 145);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 8;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(123, 90);
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
            this.fld_lkeFK_HREmployeeID.Properties.NullText = string.Empty;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromAPPaymentVoucherDate
            // 
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSComment = string.Empty;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSDataMember = "PaymentVoucherDateFrom";
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSDataSource = "APPaymentVouchers";
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSDescription = null;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSError = null;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchFromAPPaymentVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPPaymentVoucherDate.EditValue = null;
            this.fld_dteSearchFromAPPaymentVoucherDate.Location = new System.Drawing.Point(123, 142);
            this.fld_dteSearchFromAPPaymentVoucherDate.Name = "fld_dteSearchFromAPPaymentVoucherDate";
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPPaymentVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPPaymentVoucherDate.Screen = null;
            this.fld_dteSearchFromAPPaymentVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPPaymentVoucherDate.TabIndex = 5;
            this.fld_dteSearchFromAPPaymentVoucherDate.Tag = "SC";
            // 
            // fld_dteSearchToAPPaymentVoucherDate
            // 
            this.fld_dteSearchToAPPaymentVoucherDate.BOSComment = string.Empty;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSDataMember = "PaymentVoucherDateTo";
            this.fld_dteSearchToAPPaymentVoucherDate.BOSDataSource = "APPaymentVouchers";
            this.fld_dteSearchToAPPaymentVoucherDate.BOSDescription = null;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSError = null;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSFieldGroup = string.Empty;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSFieldRelation = string.Empty;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSPrivilege = string.Empty;
            this.fld_dteSearchToAPPaymentVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPPaymentVoucherDate.EditValue = null;
            this.fld_dteSearchToAPPaymentVoucherDate.Location = new System.Drawing.Point(328, 142);
            this.fld_dteSearchToAPPaymentVoucherDate.Name = "fld_dteSearchToAPPaymentVoucherDate";
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPPaymentVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPPaymentVoucherDate.Screen = null;
            this.fld_dteSearchToAPPaymentVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPPaymentVoucherDate.TabIndex = 6;
            this.fld_dteSearchToAPPaymentVoucherDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = string.Empty;
            this.bosLabel2.Location = new System.Drawing.Point(22, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đối tượng";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPaymentVouchers";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(123, 64);
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
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = string.Empty;
            this.bosLabel1.Location = new System.Drawing.Point(22, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(66, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Loại chứng từ";
            // 
            // fld_lkeAPPaymentVoucherType
            // 
            this.fld_lkeAPPaymentVoucherType.BOSAllowAddNew = false;
            this.fld_lkeAPPaymentVoucherType.BOSAllowDummy = true;
            this.fld_lkeAPPaymentVoucherType.BOSComment = null;
            this.fld_lkeAPPaymentVoucherType.BOSDataMember = "APPaymentVoucherType";
            this.fld_lkeAPPaymentVoucherType.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeAPPaymentVoucherType.BOSDescription = null;
            this.fld_lkeAPPaymentVoucherType.BOSError = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldGroup = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldParent = null;
            this.fld_lkeAPPaymentVoucherType.BOSFieldRelation = null;
            this.fld_lkeAPPaymentVoucherType.BOSPrivilege = null;
            this.fld_lkeAPPaymentVoucherType.BOSPropertyName = "EditValue";
            this.fld_lkeAPPaymentVoucherType.BOSSelectType = null;
            this.fld_lkeAPPaymentVoucherType.BOSSelectTypeValue = null;
            this.fld_lkeAPPaymentVoucherType.CurrentDisplayText = null;
            this.fld_lkeAPPaymentVoucherType.Location = new System.Drawing.Point(123, 38);
            this.fld_lkeAPPaymentVoucherType.MenuManager = this.screenToolbar;
            this.fld_lkeAPPaymentVoucherType.Name = "fld_lkeAPPaymentVoucherType";
            this.fld_lkeAPPaymentVoucherType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPaymentVoucherType.Screen = null;
            this.fld_lkeAPPaymentVoucherType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPaymentVoucherType.TabIndex = 1;
            this.fld_lkeAPPaymentVoucherType.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = string.Empty;
            this.bosLabel3.Location = new System.Drawing.Point(22, 119);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 94;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APPaymentVouchers";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = string.Empty;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(123, 116);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = string.Empty;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMPMVC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeAPPaymentVoucherType);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dteSearchFromAPPaymentVoucherDate);
            this.Controls.Add(this.fld_dteSearchToAPPaymentVoucherDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcAPPaymentVoucher);
            this.Controls.Add(this.fld_txtAPPaymentVoucherNo);
            this.Name = "SMPMVC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtAPPaymentVoucherNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPPaymentVoucher, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPPaymentVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPPaymentVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            this.Controls.SetChildIndex(this.fld_lkeAPPaymentVoucherType, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPaymentVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPaymentVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPaymentVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPaymentVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPaymentVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPaymentVoucherType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPPaymentVoucherDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPPaymentVoucherDate;
        private BOSComponent.BOSLabel bosLabel2;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeAPPaymentVoucherType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
