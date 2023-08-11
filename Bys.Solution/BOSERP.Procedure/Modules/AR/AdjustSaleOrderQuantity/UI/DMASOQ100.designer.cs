using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdjustSaleOrderQuantity.UI
{
	/// <summary>
	/// Summary description for DMARCS100
	/// </summary>
    partial class DMASOQ100
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
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARAdjustSaleOrderQuantityStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARAdjustSaleOrderQuantityDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARAdjustSaleOrderQuantityNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARAdjustSaleOrderQuantityItems = new BOSERP.Modules.AdjustSaleOrderQuantity.ARAdjustSaleOrderQuantityItemsGridControl();
            this.fld_dgvARCancelVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medARAdjustSaleOrderQuantityComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAdjustSaleOrderQuantityDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAdjustSaleOrderQuantityDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAdjustSaleOrderQuantityItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAdjustSaleOrderQuantityComment.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(401, 68);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 104;
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lkeARAdjustSaleOrderQuantityStatus
            // 
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSAllowAddNew = false;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSAllowDummy = false;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSComment = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSDataMember = "ARAdjustSaleOrderQuantityStatus";
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSDescription = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSError = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSFieldGroup = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSFieldParent = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSFieldRelation = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSPrivilege = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSSelectType = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.BOSSelectTypeValue = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.CurrentDisplayText = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Location = new System.Drawing.Point(206, 65);
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Name = "fld_lkeARAdjustSaleOrderQuantityStatus";
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.ReadOnly = true;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Screen = null;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARAdjustSaleOrderQuantityStatus.TabIndex = 108;
            this.fld_lkeARAdjustSaleOrderQuantityStatus.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(497, 38);
            this.fld_lkeFK_GECurrencyID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 98;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_pteARAdjustSaleOrderQuantityEmployeePicture
            // 
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSComment = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSDataMember = "ARAdjustSaleOrderQuantityEmployeePicture";
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSDescription = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSError = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSPrivilege = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Name = "fld_pteARAdjustSaleOrderQuantityEmployeePicture";
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Screen = null;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.TabIndex = 109;
            this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Tag = "DC";
            // 
            // fld_txtARAdjustSaleOrderQuantityExchangeRate
            // 
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSComment = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSDataMember = "ARAdjustSaleOrderQuantityExchangeRate";
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSDescription = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSError = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSFieldGroup = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSFieldRelation = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSPrivilege = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Location = new System.Drawing.Point(497, 66);
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Name = "fld_txtARAdjustSaleOrderQuantityExchangeRate";
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Screen = null;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.TabIndex = 99;
            this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(401, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 105;
            this.bosLabel3.Text = "Loại tiền tệ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(119, 68);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 107;
            this.bosLabel5.Text = "Tình trạng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(119, 40);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 101;
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(206, 37);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 97;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 94;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(119, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 111;
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // fld_dteARAdjustSaleOrderQuantityDate
            // 
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSComment = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSDataMember = "ARAdjustSaleOrderQuantityDate";
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSDescription = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSError = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSFieldGroup = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSFieldRelation = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSPrivilege = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.BOSPropertyName = "EditValue";
            this.fld_dteARAdjustSaleOrderQuantityDate.EditValue = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.Location = new System.Drawing.Point(497, 11);
            this.fld_dteARAdjustSaleOrderQuantityDate.Name = "fld_dteARAdjustSaleOrderQuantityDate";
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARAdjustSaleOrderQuantityDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARAdjustSaleOrderQuantityDate.Screen = null;
            this.fld_dteARAdjustSaleOrderQuantityDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARAdjustSaleOrderQuantityDate.TabIndex = 96;
            this.fld_dteARAdjustSaleOrderQuantityDate.Tag = "DC";
            // 
            // fld_txtARAdjustSaleOrderQuantityNo
            // 
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSComment = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDataMember = "ARAdjustSaleOrderQuantityNo";
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSDescription = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSError = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSFieldGroup = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSFieldRelation = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSPrivilege = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.BOSPropertyName = "EditValue";
            this.fld_txtARAdjustSaleOrderQuantityNo.Location = new System.Drawing.Point(206, 11);
            this.fld_txtARAdjustSaleOrderQuantityNo.MenuManager = this.screenToolbar;
            this.fld_txtARAdjustSaleOrderQuantityNo.Name = "fld_txtARAdjustSaleOrderQuantityNo";
            this.fld_txtARAdjustSaleOrderQuantityNo.Screen = null;
            this.fld_txtARAdjustSaleOrderQuantityNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARAdjustSaleOrderQuantityNo.TabIndex = 95;
            this.fld_txtARAdjustSaleOrderQuantityNo.Tag = "DC";
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(401, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 110;
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcARAdjustSaleOrderQuantityItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 131);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(877, 364);
            this.fld_grcGroupControl3.TabIndex = 112;
            this.fld_grcGroupControl3.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcARAdjustSaleOrderQuantityItems
            // 
            this.fld_dgcARAdjustSaleOrderQuantityItems.AllowDrop = true;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSComment = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSDataMember = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSDataSource = "ARAdjustSaleOrderQuantityItems";
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSDescription = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSError = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSFieldGroup = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSFieldRelation = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSGridType = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSPrivilege = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.BOSPropertyName = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARAdjustSaleOrderQuantityItems.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcARAdjustSaleOrderQuantityItems.MainView = this.fld_dgvARCancelVoucher;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Name = "fld_dgcARAdjustSaleOrderQuantityItems";
            this.fld_dgcARAdjustSaleOrderQuantityItems.PrintReport = false;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Screen = null;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Size = new System.Drawing.Size(866, 334);
            this.fld_dgcARAdjustSaleOrderQuantityItems.TabIndex = 61;
            this.fld_dgcARAdjustSaleOrderQuantityItems.Tag = "DC";
            this.fld_dgcARAdjustSaleOrderQuantityItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCancelVoucher});
            // 
            // fld_dgvARCancelVoucher
            // 
            this.fld_dgvARCancelVoucher.GridControl = this.fld_dgcARAdjustSaleOrderQuantityItems;
            this.fld_dgvARCancelVoucher.Name = "fld_dgvARCancelVoucher";
            this.fld_dgvARCancelVoucher.PaintStyleName = "Office2003";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medARAdjustSaleOrderQuantityComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 501);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(844, 67);
            this.bosLine1.TabIndex = 119;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medARAdjustSaleOrderQuantityComment
            // 
            this.fld_medARAdjustSaleOrderQuantityComment.BOSComment = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSDataMember = "ARAdjustSaleOrderQuantityComment";
            this.fld_medARAdjustSaleOrderQuantityComment.BOSDataSource = "ARAdjustSaleOrderQuantitys";
            this.fld_medARAdjustSaleOrderQuantityComment.BOSDescription = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSError = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSFieldGroup = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSFieldRelation = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSPrivilege = null;
            this.fld_medARAdjustSaleOrderQuantityComment.BOSPropertyName = "EditValue";
            this.fld_medARAdjustSaleOrderQuantityComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARAdjustSaleOrderQuantityComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARAdjustSaleOrderQuantityComment.Name = "fld_medARAdjustSaleOrderQuantityComment";
            this.fld_medARAdjustSaleOrderQuantityComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARAdjustSaleOrderQuantityComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARAdjustSaleOrderQuantityComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARAdjustSaleOrderQuantityComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARAdjustSaleOrderQuantityComment.Screen = null;
            this.fld_medARAdjustSaleOrderQuantityComment.Size = new System.Drawing.Size(838, 47);
            this.fld_medARAdjustSaleOrderQuantityComment.TabIndex = 0;
            this.fld_medARAdjustSaleOrderQuantityComment.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_pteARAdjustSaleOrderQuantityEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_txtARAdjustSaleOrderQuantityNo);
            this.bosPanel1.Controls.Add(this.fld_dteARAdjustSaleOrderQuantityDate);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeARAdjustSaleOrderQuantityStatus);
            this.bosPanel1.Controls.Add(this.fld_txtARAdjustSaleOrderQuantityExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(886, 580);
            this.bosPanel1.TabIndex = 124;
            // 
            // DMASOQ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(886, 580);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMASOQ100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARAdjustSaleOrderQuantityStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARAdjustSaleOrderQuantityEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAdjustSaleOrderQuantityDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARAdjustSaleOrderQuantityDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARAdjustSaleOrderQuantityNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARAdjustSaleOrderQuantityItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARAdjustSaleOrderQuantityComment.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeARAdjustSaleOrderQuantityStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSPictureEdit fld_pteARAdjustSaleOrderQuantityEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtARAdjustSaleOrderQuantityExchangeRate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteARAdjustSaleOrderQuantityDate;
        private BOSComponent.BOSTextBox fld_txtARAdjustSaleOrderQuantityNo;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medARAdjustSaleOrderQuantityComment;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSERP.Modules.AdjustSaleOrderQuantity.ARAdjustSaleOrderQuantityItemsGridControl fld_dgcARAdjustSaleOrderQuantityItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCancelVoucher;
	}
}
