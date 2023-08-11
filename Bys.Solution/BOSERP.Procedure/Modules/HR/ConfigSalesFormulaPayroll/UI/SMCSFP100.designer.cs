using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConfigSalesFormulaPayroll.UI
{
	/// <summary>
	/// Summary description for SMCSFP100
	/// </summary>
	partial class SMCSFP100
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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRConfigSalesFormulaPayrolls = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtARCancelVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit3 = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesFormulaPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(16, 30);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(16, 56);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 26;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(16, 160);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 27;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(298, 160);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ngày";
            // 
            // fld_dgcHRConfigSalesFormulaPayrolls
            // 
            this.fld_dgcHRConfigSalesFormulaPayrolls.AllowDrop = true;
            this.fld_dgcHRConfigSalesFormulaPayrolls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSDescription = null;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSError = null;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRConfigSalesFormulaPayrolls.BOSPropertyName = null;
            this.fld_dgcHRConfigSalesFormulaPayrolls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRConfigSalesFormulaPayrolls.Location = new System.Drawing.Point(12, 206);
            this.fld_dgcHRConfigSalesFormulaPayrolls.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRConfigSalesFormulaPayrolls.Name = "fld_dgcHRConfigSalesFormulaPayrolls";
            this.fld_dgcHRConfigSalesFormulaPayrolls.Screen = null;
            this.fld_dgcHRConfigSalesFormulaPayrolls.Size = new System.Drawing.Size(838, 349);
            this.fld_dgcHRConfigSalesFormulaPayrolls.TabIndex = 33;
            this.fld_dgcHRConfigSalesFormulaPayrolls.Tag = "SR";
            this.fld_dgcHRConfigSalesFormulaPayrolls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRConfigSalesFormulaPayrolls;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_txtARCancelVoucherNo
            // 
            this.fld_txtARCancelVoucherNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCancelVoucherNo.BOSDataMember = "HRConfigSalesFormulaPayrollNo";
            this.fld_txtARCancelVoucherNo.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_txtARCancelVoucherNo.BOSDescription = null;
            this.fld_txtARCancelVoucherNo.BOSError = null;
            this.fld_txtARCancelVoucherNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCancelVoucherNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCancelVoucherNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCancelVoucherNo.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARCancelVoucherNo.Location = new System.Drawing.Point(122, 27);
            this.fld_txtARCancelVoucherNo.Name = "fld_txtARCancelVoucherNo";
            this.fld_txtARCancelVoucherNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherNo.Screen = null;
            this.fld_txtARCancelVoucherNo.Size = new System.Drawing.Size(155, 20);
            this.fld_txtARCancelVoucherNo.TabIndex = 0;
            this.fld_txtARCancelVoucherNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(122, 53);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(16, 82);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(59, 13);
            this.bosLabel1.TabIndex = 41;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Người duyệt";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSDataMember = "FK_HREmployeeApprovedID";
            this.bosLookupEdit1.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.Location = new System.Drawing.Point(122, 79);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.bosLookupEdit1.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(155, 20);
            this.bosLookupEdit1.TabIndex = 40;
            this.bosLookupEdit1.Tag = "SC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "HRConfigSalesFormulaPayrollDateFromDate";
            this.bosDateEdit1.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(122, 156);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.ReadOnly = true;
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(155, 20);
            this.bosDateEdit1.TabIndex = 113;
            this.bosDateEdit1.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(16, 133);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(99, 13);
            this.bosLabel4.TabIndex = 112;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Thời gian áp dụng từ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(298, 133);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 110;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Đến ngày";
            // 
            // fld_dteARSaleOrderDate
            // 
            this.fld_dteARSaleOrderDate.BOSComment = null;
            this.fld_dteARSaleOrderDate.BOSDataMember = "HRConfigSalesFormulaPayrollDateToDate";
            this.fld_dteARSaleOrderDate.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_dteARSaleOrderDate.BOSDescription = null;
            this.fld_dteARSaleOrderDate.BOSError = null;
            this.fld_dteARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDate.EditValue = null;
            this.fld_dteARSaleOrderDate.Location = new System.Drawing.Point(367, 156);
            this.fld_dteARSaleOrderDate.Name = "fld_dteARSaleOrderDate";
            this.fld_dteARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_dteARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDate.Properties.ReadOnly = true;
            this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDate.Screen = null;
            this.fld_dteARSaleOrderDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARSaleOrderDate.TabIndex = 111;
            this.fld_dteARSaleOrderDate.Tag = "SC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(16, 107);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(62, 13);
            this.bosLabel27.TabIndex = 552;
            this.bosLabel27.Text = "Loại cấu hình";
            // 
            // fld_lkeARSaleOrderProductType
            // 
            this.fld_lkeARSaleOrderProductType.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderProductType.BOSAllowDummy = false;
            this.fld_lkeARSaleOrderProductType.BOSComment = null;
            this.fld_lkeARSaleOrderProductType.BOSDataMember = "HRConfigSalesFormulaPayrollType";
            this.fld_lkeARSaleOrderProductType.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_lkeARSaleOrderProductType.BOSDescription = null;
            this.fld_lkeARSaleOrderProductType.BOSError = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldParent = null;
            this.fld_lkeARSaleOrderProductType.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderProductType.BOSPrivilege = null;
            this.fld_lkeARSaleOrderProductType.BOSPropertyName = "EditValue";
            this.fld_lkeARSaleOrderProductType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderProductType.Location = new System.Drawing.Point(122, 104);
            this.fld_lkeARSaleOrderProductType.Name = "fld_lkeARSaleOrderProductType";
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARSaleOrderProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderProductType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeARSaleOrderProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderProductType, true);
            this.fld_lkeARSaleOrderProductType.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeARSaleOrderProductType.TabIndex = 551;
            this.fld_lkeARSaleOrderProductType.Tag = "SC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "HRConfigSalesFormulaPayrollFromDate";
            this.bosDateEdit2.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(122, 130);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.ReadOnly = true;
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(155, 20);
            this.bosDateEdit2.TabIndex = 553;
            this.bosDateEdit2.Tag = "SC";
            // 
            // bosDateEdit3
            // 
            this.bosDateEdit3.BOSComment = null;
            this.bosDateEdit3.BOSDataMember = "HRConfigSalesFormulaPayrollToDate";
            this.bosDateEdit3.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.bosDateEdit3.BOSDescription = null;
            this.bosDateEdit3.BOSError = null;
            this.bosDateEdit3.BOSFieldGroup = null;
            this.bosDateEdit3.BOSFieldRelation = null;
            this.bosDateEdit3.BOSPrivilege = null;
            this.bosDateEdit3.BOSPropertyName = "EditValue";
            this.bosDateEdit3.EditValue = null;
            this.bosDateEdit3.Location = new System.Drawing.Point(367, 130);
            this.bosDateEdit3.Name = "bosDateEdit3";
            this.bosDateEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosDateEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit3.Properties.ReadOnly = true;
            this.bosDateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit3.Screen = null;
            this.bosDateEdit3.Size = new System.Drawing.Size(153, 20);
            this.bosDateEdit3.TabIndex = 554;
            this.bosDateEdit3.Tag = "SC";
            // 
            // SMCSFP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosDateEdit2);
            this.Controls.Add(this.bosDateEdit3);
            this.Controls.Add(this.bosLabel27);
            this.Controls.Add(this.fld_lkeARSaleOrderProductType);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_dteARSaleOrderDate);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLookupEdit1);
            this.Controls.Add(this.fld_dgcHRConfigSalesFormulaPayrolls);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtARCancelVoucherNo);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lblLabel17);
            this.Name = "SMCSFP100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_txtARCancelVoucherNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRConfigSalesFormulaPayrolls, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            this.Controls.SetChildIndex(this.fld_lkeARSaleOrderProductType, 0);
            this.Controls.SetChildIndex(this.bosLabel27, 0);
            this.Controls.SetChildIndex(this.bosDateEdit3, 0);
            this.Controls.SetChildIndex(this.bosDateEdit2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRConfigSalesFormulaPayrolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRConfigSalesFormulaPayrolls;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDate;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderProductType;
        private BOSComponent.BOSDateEdit bosDateEdit2;
        private BOSComponent.BOSDateEdit bosDateEdit3;
	}
}
