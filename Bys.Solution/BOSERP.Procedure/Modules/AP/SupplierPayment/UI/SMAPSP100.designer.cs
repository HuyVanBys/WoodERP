using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SupplierPayment.UI
{
	/// <summary>
	/// Summary description for SMAPSP100
	/// </summary>
	partial class SMAPSP100
    {
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtAPSupplierPaymentNo;
		private APSupplierPaymentsGridControl fld_dgcAPSupplierPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPSupplierPayment;


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
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPSupplierPaymentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcAPSupplierPayment = new BOSERP.Modules.SupplierPayment.APSupplierPaymentsGridControl();
            this.fld_dgvAPSupplierPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromAPSupplierPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPSupplierPaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPSupplierPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPSupplierPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPSupplierPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPSupplierPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPSupplierPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.Location = new System.Drawing.Point(25, 28);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel1.TabIndex = 6;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtAPSupplierPaymentNo
            // 
            this.fld_txtAPSupplierPaymentNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPSupplierPaymentNo.BOSDataMember = "APSupplierPaymentNo";
            this.fld_txtAPSupplierPaymentNo.BOSDataSource = "APSupplierPayments";
            this.fld_txtAPSupplierPaymentNo.BOSDescription = null;
            this.fld_txtAPSupplierPaymentNo.BOSError = null;
            this.fld_txtAPSupplierPaymentNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPSupplierPaymentNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPSupplierPaymentNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPSupplierPaymentNo.BOSPropertyName = "Text";
            this.fld_txtAPSupplierPaymentNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPSupplierPaymentNo.Location = new System.Drawing.Point(129, 25);
            this.fld_txtAPSupplierPaymentNo.Name = "fld_txtAPSupplierPaymentNo";
            this.fld_txtAPSupplierPaymentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPSupplierPaymentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPSupplierPaymentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPSupplierPaymentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPSupplierPaymentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPSupplierPaymentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPSupplierPaymentNo.Screen = null;
            this.fld_txtAPSupplierPaymentNo.Size = new System.Drawing.Size(157, 20);
            this.fld_txtAPSupplierPaymentNo.TabIndex = 0;
            this.fld_txtAPSupplierPaymentNo.Tag = "SC";
            // 
            // fld_dgcAPSupplierPayment
            // 
            this.fld_dgcAPSupplierPayment.AllowDrop = true;
            this.fld_dgcAPSupplierPayment.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.BOSDataSource = "APSupplierPayments";
            this.fld_dgcAPSupplierPayment.BOSDescription = null;
            this.fld_dgcAPSupplierPayment.BOSError = null;
            this.fld_dgcAPSupplierPayment.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPSupplierPayment.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPSupplierPayment.Location = new System.Drawing.Point(124, 238);
            this.fld_dgcAPSupplierPayment.MainView = this.fld_dgvAPSupplierPayment;
            this.fld_dgcAPSupplierPayment.Name = "fld_dgcAPSupplierPayment";
            this.fld_dgcAPSupplierPayment.Screen = null;
            this.fld_dgcAPSupplierPayment.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPSupplierPayment.TabIndex = 4;
            this.fld_dgcAPSupplierPayment.Tag = "SR";
            this.fld_dgcAPSupplierPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPSupplierPayment});
            // 
            // fld_dgvAPSupplierPayment
            // 
            this.fld_dgvAPSupplierPayment.GridControl = this.fld_dgcAPSupplierPayment;
            this.fld_dgvAPSupplierPayment.Name = "fld_dgvAPSupplierPayment";
            this.fld_dgvAPSupplierPayment.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(25, 54);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Đối tượng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(25, 80);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(129, 77);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(25, 132);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(86, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Ngày chứng từ từ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Location = new System.Drawing.Point(308, 132);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Đến";
            // 
            // fld_dteSearchFromAPSupplierPaymentDate
            // 
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSComment = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSDataMember = "SupplierPaymentDateFrom";
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSDataSource = "APSupplierPayments";
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSDescription = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSError = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPSupplierPaymentDate.EditValue = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.Location = new System.Drawing.Point(129, 129);
            this.fld_dteSearchFromAPSupplierPaymentDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPSupplierPaymentDate.Name = "fld_dteSearchFromAPSupplierPaymentDate";
            this.fld_dteSearchFromAPSupplierPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPSupplierPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPSupplierPaymentDate.Screen = null;
            this.fld_dteSearchFromAPSupplierPaymentDate.Size = new System.Drawing.Size(157, 20);
            this.fld_dteSearchFromAPSupplierPaymentDate.TabIndex = 4;
            this.fld_dteSearchFromAPSupplierPaymentDate.Tag = "SC";
            // 
            // fld_dteSearchToAPSupplierPaymentDate
            // 
            this.fld_dteSearchToAPSupplierPaymentDate.BOSComment = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSDataMember = "SupplierPaymentDateTo";
            this.fld_dteSearchToAPSupplierPaymentDate.BOSDataSource = "APSupplierPayments";
            this.fld_dteSearchToAPSupplierPaymentDate.BOSDescription = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSError = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSPrivilege = null;
            this.fld_dteSearchToAPSupplierPaymentDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPSupplierPaymentDate.EditValue = null;
            this.fld_dteSearchToAPSupplierPaymentDate.Location = new System.Drawing.Point(352, 129);
            this.fld_dteSearchToAPSupplierPaymentDate.Name = "fld_dteSearchToAPSupplierPaymentDate";
            this.fld_dteSearchToAPSupplierPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPSupplierPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPSupplierPaymentDate.Screen = null;
            this.fld_dteSearchToAPSupplierPaymentDate.Size = new System.Drawing.Size(157, 20);
            this.fld_dteSearchToAPSupplierPaymentDate.TabIndex = 5;
            this.fld_dteSearchToAPSupplierPaymentDate.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Location = new System.Drawing.Point(25, 106);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 20;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(129, 103);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APSupplierPayments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(129, 51);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // SMAPSP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dteSearchToAPSupplierPaymentDate);
            this.Controls.Add(this.fld_dteSearchFromAPSupplierPaymentDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dgcAPSupplierPayment);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtAPSupplierPaymentNo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel2);
            this.Name = "SMAPSP100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPSupplierPaymentNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPSupplierPayment, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPSupplierPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPSupplierPaymentDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPSupplierPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPSupplierPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPSupplierPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPSupplierPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPSupplierPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPSupplierPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPSupplierPaymentDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPSupplierPaymentDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
	}
}
