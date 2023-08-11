using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CustomerPayment.UI
{
	/// <summary>
	/// Summary description for SMARCP100
	/// </summary>
	partial class SMARCP100
	{
        private BOSComponent.BOSTextBox fld_txtARCustomerPaymentNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSSearchResultsGridControl fld_dgcARCustomerPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomerPayment;


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
            this.fld_txtARCustomerPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARCustomerPayment = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARCustomerPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARCustomerPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_txtARCustomerPaymentNo.Location = new System.Drawing.Point(154, 36);
            this.fld_txtARCustomerPaymentNo.Name = "fld_txtARCustomerPaymentNo";
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerPaymentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCustomerPaymentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCustomerPaymentNo.Screen = null;
            this.fld_txtARCustomerPaymentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCustomerPaymentNo.TabIndex = 1;
            this.fld_txtARCustomerPaymentNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel.Location = new System.Drawing.Point(46, 39);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 7;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_dgcARCustomerPayment
            // 
            this.fld_dgcARCustomerPayment.AllowDrop = true;
            this.fld_dgcARCustomerPayment.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.BOSDataSource = "ARCustomerPayments";
            this.fld_dgcARCustomerPayment.BOSDescription = null;
            this.fld_dgcARCustomerPayment.BOSError = null;
            this.fld_dgcARCustomerPayment.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARCustomerPayment.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCustomerPayment.Location = new System.Drawing.Point(96, 201);
            this.fld_dgcARCustomerPayment.MainView = this.fld_dgvARCustomerPayment;
            this.fld_dgcARCustomerPayment.Name = "fld_dgcARCustomerPayment";
            this.fld_dgcARCustomerPayment.Screen = null;
            this.fld_dgcARCustomerPayment.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcARCustomerPayment.TabIndex = 6;
            this.fld_dgcARCustomerPayment.Tag = "SR";
            this.fld_dgcARCustomerPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomerPayment});
            // 
            // fld_dgvARCustomerPayment
            // 
            this.fld_dgvARCustomerPayment.GridControl = this.fld_dgcARCustomerPayment;
            this.fld_dgvARCustomerPayment.Name = "fld_dgvARCustomerPayment";
            this.fld_dgvARCustomerPayment.PaintStyleName = "Office2003";
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
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(46, 168);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(86, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Ngày chứng từ từ";
            // 
            // fld_dteSearchFromARCustomerPaymentDate
            // 
            this.fld_dteSearchFromARCustomerPaymentDate.BOSComment = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataMember = "CustomerPaymentDateFrom";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchFromARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSError = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchFromARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARCustomerPaymentDate.EditValue = null;
            this.fld_dteSearchFromARCustomerPaymentDate.Location = new System.Drawing.Point(154, 165);
            this.fld_dteSearchFromARCustomerPaymentDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromARCustomerPaymentDate.Name = "fld_dteSearchFromARCustomerPaymentDate";
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCustomerPaymentDate.Screen = null;
            this.fld_dteSearchFromARCustomerPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARCustomerPaymentDate.TabIndex = 5;
            this.fld_dteSearchFromARCustomerPaymentDate.Tag = "SC";
            // 
            // fld_dteSearchToARCustomerPaymentDate
            // 
            this.fld_dteSearchToARCustomerPaymentDate.BOSComment = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSDataMember = "CustomerPaymentDateTo";
            this.fld_dteSearchToARCustomerPaymentDate.BOSDataSource = "ARCustomerPayments";
            this.fld_dteSearchToARCustomerPaymentDate.BOSDescription = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSError = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchToARCustomerPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARCustomerPaymentDate.EditValue = null;
            this.fld_dteSearchToARCustomerPaymentDate.Location = new System.Drawing.Point(365, 165);
            this.fld_dteSearchToARCustomerPaymentDate.Name = "fld_dteSearchToARCustomerPaymentDate";
            this.fld_dteSearchToARCustomerPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARCustomerPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCustomerPaymentDate.Screen = null;
            this.fld_dteSearchToARCustomerPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARCustomerPaymentDate.TabIndex = 6;
            this.fld_dteSearchToARCustomerPaymentDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(329, 168);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
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
            this.bosLabel3.Location = new System.Drawing.Point(46, 91);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(56, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Khách hàng";
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
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(154, 88);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 3;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.Location = new System.Drawing.Point(46, 116);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARCustomerPayments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(154, 113);
            this.fld_lkeFK_HREmployeeID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 4;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel5.Location = new System.Drawing.Point(46, 65);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Mã hóa đơn";
            // 
            // fld_txtARInvoiceNo
            // 
            this.fld_txtARInvoiceNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARInvoiceNo.BOSDataMember = "ARInvoiceNo";
            this.fld_txtARInvoiceNo.BOSDataSource = "ARCustomerPayments";
            this.fld_txtARInvoiceNo.BOSDescription = null;
            this.fld_txtARInvoiceNo.BOSError = null;
            this.fld_txtARInvoiceNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARInvoiceNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARInvoiceNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARInvoiceNo.BOSPropertyName = "Text";
            this.fld_txtARInvoiceNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtARInvoiceNo.Location = new System.Drawing.Point(154, 62);
            this.fld_txtARInvoiceNo.Name = "fld_txtARInvoiceNo";
            this.fld_txtARInvoiceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARInvoiceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARInvoiceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARInvoiceNo.Screen = null;
            this.fld_txtARInvoiceNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARInvoiceNo.TabIndex = 2;
            this.fld_txtARInvoiceNo.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel6.Location = new System.Drawing.Point(45, 142);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 43;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Chi nhánh";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(154, 139);
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
            this.fld_lkeFK_BRBranchID.TabIndex = 42;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMARCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_dteSearchToARCustomerPaymentDate);
            this.Controls.Add(this.fld_dteSearchFromARCustomerPaymentDate);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcARCustomerPayment);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtARInvoiceNo);
            this.Controls.Add(this.fld_txtARCustomerPaymentNo);
            this.Name = "SMARCP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtARCustomerPaymentNo, 0);
            this.Controls.SetChildIndex(this.fld_txtARInvoiceNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcARCustomerPayment, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCustomerPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARCustomerPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomerPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCustomerPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARCustomerPaymentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARCustomerPaymentDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtARInvoiceNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
