using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerRepaid.UI
{
	/// <summary>
	/// Summary description for SMCR100
	/// </summary>
	partial class SMCR100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARCustomerPaymentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARCustomerPaymentDate1;


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
            this.fld_txtARCustomerPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARCustomerPaymentDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcCustomerPayments = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(27, 29);
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
            this.fld_lblLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(26, 55);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Khách hàng";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(26, 81);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Nhân viên";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(26, 133);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(308, 133);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Đến";
            // 
            // fld_txtARCustomerPaymentNo
            // 
            this.fld_txtARCustomerPaymentNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo.BOSDataMember = "ARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARCustomerPaymentNo.BOSDescription = null;
            this.fld_txtARCustomerPaymentNo.BOSError = null;
            this.fld_txtARCustomerPaymentNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo.BOSPropertyName = "Text";
            this.fld_txtARCustomerPaymentNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARCustomerPaymentNo.Location = new System.Drawing.Point(135, 26);
            this.fld_txtARCustomerPaymentNo.Name = "fld_txtARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentNo.Screen = null;
            this.fld_txtARCustomerPaymentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentNo.TabIndex = 9;
            this.fld_txtARCustomerPaymentNo.Tag = "SC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(135, 52);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Name")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 10;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(135, 78);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 11;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromARCustomerPaymentDate
            // 
            this.fld_dteSearchFromARCustomerPaymentDate.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataMember = "CustomerPaymentDateFrom";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSError = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARCustomerPaymentDate.EditValue = null;
            this.fld_dteSearchFromARCustomerPaymentDate.Location = new System.Drawing.Point(135, 130);
            this.fld_dteSearchFromARCustomerPaymentDate.Name = "fld_dteSearchFromARCustomerPaymentDate";
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCustomerPaymentDate.Screen = null;
            this.fld_dteSearchFromARCustomerPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARCustomerPaymentDate.TabIndex = 12;
            this.fld_dteSearchFromARCustomerPaymentDate.Tag = "SC";
            // 
            // fld_dteSearchToARCustomerPaymentDate1
            // 
            this.fld_dteSearchToARCustomerPaymentDate1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSDataMember = "CustomerPaymentDateTo";
            this.fld_dteSearchToARCustomerPaymentDate1.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchToARCustomerPaymentDate1.BOSDescription = null;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSError = null;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteSearchToARCustomerPaymentDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARCustomerPaymentDate1.EditValue = null;
            this.fld_dteSearchToARCustomerPaymentDate1.Location = new System.Drawing.Point(349, 130);
            this.fld_dteSearchToARCustomerPaymentDate1.Name = "fld_dteSearchToARCustomerPaymentDate1";
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARCustomerPaymentDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCustomerPaymentDate1.Screen = null;
            this.fld_dteSearchToARCustomerPaymentDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARCustomerPaymentDate1.TabIndex = 13;
            this.fld_dteSearchToARCustomerPaymentDate1.Tag = "SC";
            // 
            // fld_dgcCustomerPayments
            // 
            this.fld_dgcCustomerPayments.BOSComment = null;
            this.fld_dgcCustomerPayments.BOSDataMember = null;
            this.fld_dgcCustomerPayments.BOSDataSource = "ARCustomerPayments";
            this.fld_dgcCustomerPayments.BOSDescription = null;
            this.fld_dgcCustomerPayments.BOSError = null;
            this.fld_dgcCustomerPayments.BOSFieldGroup = null;
            this.fld_dgcCustomerPayments.BOSFieldRelation = null;
            this.fld_dgcCustomerPayments.BOSPrivilege = null;
            this.fld_dgcCustomerPayments.BOSPropertyName = null;
            this.fld_dgcCustomerPayments.Location = new System.Drawing.Point(60, 176);
            this.fld_dgcCustomerPayments.MenuManager = this.screenToolbar;
            this.fld_dgcCustomerPayments.Name = "fld_dgcCustomerPayments";
            this.fld_dgcCustomerPayments.Screen = null;
            this.fld_dgcCustomerPayments.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcCustomerPayments.TabIndex = 14;
            this.fld_dgcCustomerPayments.Tag = "SR";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(135, 104);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 40;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(26, 107);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 41;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // SMCR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcCustomerPayments);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtARCustomerPaymentNo);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_dteSearchToARCustomerPaymentDate1);
            this.Controls.Add(this.fld_dteSearchFromARCustomerPaymentDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Name = "SMCR100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCustomerPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARCustomerPaymentDate1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerPaymentNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcCustomerPayments, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCustomerPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcCustomerPayments;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
