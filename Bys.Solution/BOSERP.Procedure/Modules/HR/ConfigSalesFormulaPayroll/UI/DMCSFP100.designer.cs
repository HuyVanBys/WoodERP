using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ConfigSalesFormulaPayroll.UI
{
	/// <summary>
	/// Summary description for DMCSFP100
	/// </summary>
	partial class DMCSFP100
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
            this.fld_txtHRConfigSalesFormulaPayrollNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dteHRConfigSalesFormulaPayrollDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl = new BOSERP.Modules.ConfigSalesFormulaPayroll.HRConfigSalesFormulaPayrollItemGridControl();
            this.fld_dgvARCancelVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARSaleOrderProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medHRConfigSalesFormulaPayrollDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeApprovedID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRConfigSalesFormulaPayrollName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRConfigSalesFormulaPayrollStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesFormulaPayrollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesFormulaPayrollDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcConfigSalesFormulaPayrollItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRConfigSalesFormulaPayrollDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesFormulaPayrollName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRConfigSalesFormulaPayrollNo
            // 
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSComment = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSDataMember = "HRConfigSalesFormulaPayrollNo";
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSDescription = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSError = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSFieldGroup = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSFieldRelation = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSPrivilege = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.BOSPropertyName = "EditValue";
            this.fld_txtHRConfigSalesFormulaPayrollNo.Location = new System.Drawing.Point(220, 11);
            this.fld_txtHRConfigSalesFormulaPayrollNo.MenuManager = this.screenToolbar;
            this.fld_txtHRConfigSalesFormulaPayrollNo.Name = "fld_txtHRConfigSalesFormulaPayrollNo";
            this.fld_txtHRConfigSalesFormulaPayrollNo.Screen = null;
            this.fld_txtHRConfigSalesFormulaPayrollNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtHRConfigSalesFormulaPayrollNo.TabIndex = 1;
            this.fld_txtHRConfigSalesFormulaPayrollNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(124, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_pteHRConfigSalesFormulaPayrollEmployeePicture
            // 
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSComment = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSDataMember = "HRConfigSalesFormulaPayrollEmployeePicture";
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSDescription = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSError = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Location = new System.Drawing.Point(8, 10);
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Name = "fld_pteHRConfigSalesFormulaPayrollEmployeePicture";
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Screen = null;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.TabIndex = 76;
            this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Tag = "DC";
            // 
            // fld_dteHRConfigSalesFormulaPayrollDate
            // 
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSComment = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSDataMember = "HRConfigSalesFormulaPayrollDate";
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSDescription = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSError = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSFieldGroup = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSFieldRelation = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSPrivilege = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.BOSPropertyName = "EditValue";
            this.fld_dteHRConfigSalesFormulaPayrollDate.EditValue = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.Location = new System.Drawing.Point(480, 11);
            this.fld_dteHRConfigSalesFormulaPayrollDate.Name = "fld_dteHRConfigSalesFormulaPayrollDate";
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRConfigSalesFormulaPayrollDate.Screen = null;
            this.fld_dteHRConfigSalesFormulaPayrollDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteHRConfigSalesFormulaPayrollDate.TabIndex = 2;
            this.fld_dteHRConfigSalesFormulaPayrollDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(396, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = null;
            this.fld_grcGroupControl3.BOSDataMember = null;
            this.fld_grcGroupControl3.BOSDataSource = null;
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = null;
            this.fld_grcGroupControl3.BOSFieldRelation = null;
            this.fld_grcGroupControl3.BOSPrivilege = null;
            this.fld_grcGroupControl3.BOSPropertyName = null;
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcConfigSalesFormulaPayrollItemsGridControl);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel48);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(0, 154);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(913, 344);
            this.fld_grcGroupControl3.TabIndex = 10;
            this.fld_grcGroupControl3.Text = "Danh sách cấu hình";
            // 
            // fld_dgcConfigSalesFormulaPayrollItemsGridControl
            // 
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.AllowDrop = true;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSComment = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSDataMember = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSDataSource = "HRConfigSalesFormulaPayrollItems";
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSDescription = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSError = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSGridType = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSPrivilege = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.BOSPropertyName = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Location = new System.Drawing.Point(8, 25);
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.MainView = this.fld_dgvARCancelVoucher;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Name = "fld_dgcConfigSalesFormulaPayrollItemsGridControl";
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.PrintReport = false;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.RowHandle = 0;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Screen = null;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Size = new System.Drawing.Size(900, 314);
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.TabIndex = 0;
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.Tag = "DC";
            this.fld_dgcConfigSalesFormulaPayrollItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCancelVoucher});
            // 
            // fld_dgvARCancelVoucher
            // 
            this.fld_dgvARCancelVoucher.GridControl = this.fld_dgcConfigSalesFormulaPayrollItemsGridControl;
            this.fld_dgvARCancelVoucher.Name = "fld_dgvARCancelVoucher";
            this.fld_dgvARCancelVoucher.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARCancelVoucherItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(66, 25);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(687, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 11;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.Visible = false;
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(13, 27);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Sản phẩm";
            this.fld_lblLabel48.Visible = false;
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(8, 112);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(124, 66);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(85, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Text = "Thời gian áp dụng";
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
            this.bosLabel3.Location = new System.Drawing.Point(662, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(59, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Người duyệt";
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
            this.bosPanel1.Controls.Add(this.bosDateEdit2);
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_lkeARSaleOrderProductType);
            this.bosPanel1.Controls.Add(this.fld_medHRConfigSalesFormulaPayrollDesc);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeApprovedID);
            this.bosPanel1.Controls.Add(this.fld_txtHRConfigSalesFormulaPayrollName);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeHRConfigSalesFormulaPayrollStatus);
            this.bosPanel1.Controls.Add(this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteHRConfigSalesFormulaPayrollDate);
            this.bosPanel1.Controls.Add(this.fld_txtHRConfigSalesFormulaPayrollNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(916, 510);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel27.Location = new System.Drawing.Point(662, 14);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel27, true);
            this.bosLabel27.Size = new System.Drawing.Size(62, 13);
            this.bosLabel27.TabIndex = 550;
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
            this.fld_lkeARSaleOrderProductType.Location = new System.Drawing.Point(751, 11);
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
            this.fld_lkeARSaleOrderProductType.TabIndex = 3;
            this.fld_lkeARSaleOrderProductType.Tag = "DC";
            // 
            // fld_medHRConfigSalesFormulaPayrollDesc
            // 
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSDataMember = "HRConfigSalesFormulaPayrollDesc";
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSDescription = null;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSError = null;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRConfigSalesFormulaPayrollDesc.BOSPropertyName = "EditValue";
            this.fld_medHRConfigSalesFormulaPayrollDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRConfigSalesFormulaPayrollDesc.Location = new System.Drawing.Point(220, 89);
            this.fld_medHRConfigSalesFormulaPayrollDesc.Name = "fld_medHRConfigSalesFormulaPayrollDesc";
            this.fld_medHRConfigSalesFormulaPayrollDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRConfigSalesFormulaPayrollDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRConfigSalesFormulaPayrollDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRConfigSalesFormulaPayrollDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRConfigSalesFormulaPayrollDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRConfigSalesFormulaPayrollDesc, true);
            this.fld_medHRConfigSalesFormulaPayrollDesc.Size = new System.Drawing.Size(413, 45);
            this.fld_medHRConfigSalesFormulaPayrollDesc.TabIndex = 9;
            this.fld_medHRConfigSalesFormulaPayrollDesc.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(124, 92);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 110;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Diễn giải";
            // 
            // fld_lkeFK_HREmployeeApprovedID
            // 
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeApprovedID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeApprovedID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataMember = "FK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_lkeFK_HREmployeeApprovedID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSError = null;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.Enabled = false;
            this.fld_lkeFK_HREmployeeApprovedID.Location = new System.Drawing.Point(751, 38);
            this.fld_lkeFK_HREmployeeApprovedID.Name = "fld_lkeFK_HREmployeeApprovedID";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeApprovedID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeApprovedID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeApprovedID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeApprovedID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeApprovedID.Screen = null;
            this.fld_lkeFK_HREmployeeApprovedID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_HREmployeeApprovedID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeApprovedID.Tag = "DC";
            // 
            // fld_txtHRConfigSalesFormulaPayrollName
            // 
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSComment = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSDataMember = "HRConfigSalesFormulaPayrollName";
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSDescription = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSError = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSFieldGroup = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSFieldRelation = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSPrivilege = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.BOSPropertyName = "EditValue";
            this.fld_txtHRConfigSalesFormulaPayrollName.Location = new System.Drawing.Point(220, 37);
            this.fld_txtHRConfigSalesFormulaPayrollName.MenuManager = this.screenToolbar;
            this.fld_txtHRConfigSalesFormulaPayrollName.Name = "fld_txtHRConfigSalesFormulaPayrollName";
            this.fld_txtHRConfigSalesFormulaPayrollName.Screen = null;
            this.fld_txtHRConfigSalesFormulaPayrollName.Size = new System.Drawing.Size(413, 20);
            this.fld_txtHRConfigSalesFormulaPayrollName.TabIndex = 4;
            this.fld_txtHRConfigSalesFormulaPayrollName.Tag = "DC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(124, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel5.TabIndex = 106;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Tên chứng từ";
            // 
            // fld_lkeHRConfigSalesFormulaPayrollStatus
            // 
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSAllowAddNew = false;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSAllowDummy = false;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSComment = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSDataMember = "HRConfigSalesFormulaPayrollStatus";
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSDescription = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSError = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSFieldGroup = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSFieldParent = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSFieldRelation = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSPrivilege = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSSelectType = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.CurrentDisplayText = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Location = new System.Drawing.Point(751, 64);
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Name = "fld_lkeHRConfigSalesFormulaPayrollStatus";
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.ReadOnly = true;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Screen = null;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.TabIndex = 8;
            this.fld_lkeHRConfigSalesFormulaPayrollStatus.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(396, 66);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(662, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Text = "Tình trạng";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "HRConfigSalesFormulaPayrollToDate";
            this.bosDateEdit1.BOSDataSource = "HRConfigSalesFormulaPayrolls";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(480, 63);
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
            this.bosDateEdit1.Size = new System.Drawing.Size(153, 20);
            this.bosDateEdit1.TabIndex = 7;
            this.bosDateEdit1.Tag = "DC";
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
            this.bosDateEdit2.Location = new System.Drawing.Point(220, 63);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(153, 20);
            this.bosDateEdit2.TabIndex = 6;
            this.bosDateEdit2.Tag = "DC";
            // 
            // DMCSFP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(916, 510);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCSFP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesFormulaPayrollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRConfigSalesFormulaPayrollEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesFormulaPayrollDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRConfigSalesFormulaPayrollDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcConfigSalesFormulaPayrollItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRConfigSalesFormulaPayrollDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeApprovedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRConfigSalesFormulaPayrollName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRConfigSalesFormulaPayrollStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRConfigSalesFormulaPayrollNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteHRConfigSalesFormulaPayrollEmployeePicture;
        private BOSComponent.BOSDateEdit fld_dteHRConfigSalesFormulaPayrollDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private HRConfigSalesFormulaPayrollItemGridControl fld_dgcConfigSalesFormulaPayrollItemsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCancelVoucher;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeHRConfigSalesFormulaPayrollStatus;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtHRConfigSalesFormulaPayrollName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeApprovedID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medHRConfigSalesFormulaPayrollDesc;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderProductType;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSDateEdit bosDateEdit2;
	}
}
