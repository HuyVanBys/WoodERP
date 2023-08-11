using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdjustSaleOrderQuantity.UI
{
	/// <summary>
	/// Summary description for SMARCS100
	/// </summary>
    partial class SMASOQ100
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
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcARAdjustSaleOrderQuantitys = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARAdjustSaleOrderQuantityNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromARCancelVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARCancelVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAdjustSaleOrderQuantitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCancelVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCancelVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCancelVoucherDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCancelVoucherDate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel2.Location = new System.Drawing.Point(47, 110);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 54;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(158, 107);
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
            this.fld_lkeFK_BRBranchID.TabIndex = 44;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_dgcARAdjustSaleOrderQuantitys
            // 
            this.fld_dgcARAdjustSaleOrderQuantitys.AllowDrop = true;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSDescription = null;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSError = null;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARAdjustSaleOrderQuantitys.BOSPropertyName = null;
            this.fld_dgcARAdjustSaleOrderQuantitys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARAdjustSaleOrderQuantitys.Location = new System.Drawing.Point(46, 208);
            this.fld_dgcARAdjustSaleOrderQuantitys.MainView = this.fld_dgvGridControl;
            this.fld_dgcARAdjustSaleOrderQuantitys.Name = "fld_dgcARAdjustSaleOrderQuantitys";
            this.fld_dgcARAdjustSaleOrderQuantitys.Screen = null;
            this.fld_dgcARAdjustSaleOrderQuantitys.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcARAdjustSaleOrderQuantitys.TabIndex = 53;
            this.fld_dgcARAdjustSaleOrderQuantitys.Tag = "SR";
            this.fld_dgcARAdjustSaleOrderQuantitys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARAdjustSaleOrderQuantitys;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
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
            this.fld_lblLabel11.Location = new System.Drawing.Point(47, 32);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 47;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_txtARAdjustSaleOrderQuantityNo
            // 
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDataMember = "ARAdjustSaleOrderQuantityNo";
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDescription = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSError = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSPropertyName = "EditValue";
            this.fld_txtARAdjustSaleOrderQuantityNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARAdjustSaleOrderQuantityNo.Location = new System.Drawing.Point(158, 29);
            this.fld_txtARAdjustSaleOrderQuantityNo.Name = "fld_txtARAdjustSaleOrderQuantityNo";
            this.fld_txtARAdjustSaleOrderQuantityNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARAdjustSaleOrderQuantityNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARAdjustSaleOrderQuantityNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAdjustSaleOrderQuantityNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARAdjustSaleOrderQuantityNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARAdjustSaleOrderQuantityNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARAdjustSaleOrderQuantityNo.Screen = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARAdjustSaleOrderQuantityNo.TabIndex = 40;
            this.fld_txtARAdjustSaleOrderQuantityNo.Tag = "SC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(46, 58);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel12.TabIndex = 49;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(158, 55);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 42;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
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
            this.fld_lblLabel13.Location = new System.Drawing.Point(47, 84);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 50;
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(47, 136);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 51;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(158, 81);
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
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 43;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteSearchFromARCancelVoucherDate
            // 
            this.fld_dteSearchFromARCancelVoucherDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARCancelVoucherDate.BOSDataMember = "CancelSaleForecastDateFrom";
            this.fld_dteSearchFromARCancelVoucherDate.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_dteSearchFromARCancelVoucherDate.BOSDescription = null;
            this.fld_dteSearchFromARCancelVoucherDate.BOSError = null;
            this.fld_dteSearchFromARCancelVoucherDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARCancelVoucherDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARCancelVoucherDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromARCancelVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARCancelVoucherDate.EditValue = null;
            this.fld_dteSearchFromARCancelVoucherDate.Location = new System.Drawing.Point(158, 133);
            this.fld_dteSearchFromARCancelVoucherDate.Name = "fld_dteSearchFromARCancelVoucherDate";
            this.fld_dteSearchFromARCancelVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARCancelVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARCancelVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARCancelVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARCancelVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARCancelVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCancelVoucherDate.Screen = null;
            this.fld_dteSearchFromARCancelVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARCancelVoucherDate.TabIndex = 45;
            this.fld_dteSearchFromARCancelVoucherDate.Tag = "SC";
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(331, 136);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 52;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dteSearchToARCancelVoucherDate
            // 
            this.fld_dteSearchToARCancelVoucherDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARCancelVoucherDate.BOSDataMember = "CancelSaleForecastDateTo";
            this.fld_dteSearchToARCancelVoucherDate.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_dteSearchToARCancelVoucherDate.BOSDescription = null;
            this.fld_dteSearchToARCancelVoucherDate.BOSError = null;
            this.fld_dteSearchToARCancelVoucherDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARCancelVoucherDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARCancelVoucherDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToARCancelVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARCancelVoucherDate.EditValue = null;
            this.fld_dteSearchToARCancelVoucherDate.Location = new System.Drawing.Point(365, 133);
            this.fld_dteSearchToARCancelVoucherDate.Name = "fld_dteSearchToARCancelVoucherDate";
            this.fld_dteSearchToARCancelVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARCancelVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARCancelVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARCancelVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARCancelVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARCancelVoucherDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCancelVoucherDate.Screen = null;
            this.fld_dteSearchToARCancelVoucherDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARCancelVoucherDate.TabIndex = 46;
            this.fld_dteSearchToARCancelVoucherDate.Tag = "SC";
            // 
            // SMASOQ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcARAdjustSaleOrderQuantitys);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtARAdjustSaleOrderQuantityNo);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dteSearchFromARCancelVoucherDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchToARCancelVoucherDate);
            this.Name = "SMASOQ100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToARCancelVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCancelVoucherDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_txtARAdjustSaleOrderQuantityNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcARAdjustSaleOrderQuantitys, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAdjustSaleOrderQuantitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCancelVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCancelVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCancelVoucherDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCancelVoucherDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSSearchResultsGridControl fld_dgcARAdjustSaleOrderQuantitys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSTextBox fld_txtARAdjustSaleOrderQuantityNo;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARCancelVoucherDate;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchToARCancelVoucherDate;
        private IContainer components;
	}
}
