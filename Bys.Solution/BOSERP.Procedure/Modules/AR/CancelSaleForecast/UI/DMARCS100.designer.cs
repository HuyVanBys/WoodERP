using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CancelSaleForecast.UI
{
	/// <summary>
	/// Summary description for DMARCS100
	/// </summary>
	partial class DMARCS100
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
            this.fld_lkeARCancelVoucherStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteARCancelSaleForecastEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtARCancelVoucherExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARCancelVoucherDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARCancelVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_pteARCancelSaleForecastItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARCancelSaleForecastItems = new BOSERP.Modules.CancelSaleForecast.ARCancelSaleForecastItemsGridControl();
            this.fld_dgvARCancelVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medARCancelVoucherComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtARCancelVoucherTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCancelVoucherTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARCancelVoucherDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel45 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel44 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel47 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCancelVoucherSubTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelSaleForecastEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelSaleForecastItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCancelSaleForecastItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCancelVoucherComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherSubTotalAmount.Properties)).BeginInit();
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
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(676, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 104;
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lkeARCancelVoucherStatus
            // 
            this.fld_lkeARCancelVoucherStatus.BOSAllowAddNew = false;
            this.fld_lkeARCancelVoucherStatus.BOSAllowDummy = false;
            this.fld_lkeARCancelVoucherStatus.BOSComment = null;
            this.fld_lkeARCancelVoucherStatus.BOSDataMember = "ARCancelSaleForecastStatus";
            this.fld_lkeARCancelVoucherStatus.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_lkeARCancelVoucherStatus.BOSDescription = null;
            this.fld_lkeARCancelVoucherStatus.BOSError = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldGroup = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldParent = null;
            this.fld_lkeARCancelVoucherStatus.BOSFieldRelation = null;
            this.fld_lkeARCancelVoucherStatus.BOSPrivilege = null;
            this.fld_lkeARCancelVoucherStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARCancelVoucherStatus.BOSSelectType = null;
            this.fld_lkeARCancelVoucherStatus.BOSSelectTypeValue = null;
            this.fld_lkeARCancelVoucherStatus.CurrentDisplayText = null;
            this.fld_lkeARCancelVoucherStatus.Location = new System.Drawing.Point(206, 89);
            this.fld_lkeARCancelVoucherStatus.Name = "fld_lkeARCancelVoucherStatus";
            this.fld_lkeARCancelVoucherStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_lkeARCancelVoucherStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCancelVoucherStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCancelVoucherStatus.Properties.ColumnName = null;
            this.fld_lkeARCancelVoucherStatus.Properties.NullText = "";
            this.fld_lkeARCancelVoucherStatus.Properties.ReadOnly = true;
            this.fld_lkeARCancelVoucherStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCancelVoucherStatus.Screen = null;
            this.fld_lkeARCancelVoucherStatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARCancelVoucherStatus.TabIndex = 108;
            this.fld_lkeARCancelVoucherStatus.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ARCancelSaleForecasts";
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
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 98;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp_1);
            // 
            // fld_pteARCancelSaleForecastEmployeePicture
            // 
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSComment = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSDataMember = "ARCancelSaleForecastEmployeePicture";
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSDescription = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSError = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSPrivilege = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARCancelSaleForecastEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCancelSaleForecastEmployeePicture.FileName = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.FilePath = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteARCancelSaleForecastEmployeePicture.Name = "fld_pteARCancelSaleForecastEmployeePicture";
            this.fld_pteARCancelSaleForecastEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARCancelSaleForecastEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARCancelSaleForecastEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARCancelSaleForecastEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARCancelSaleForecastEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCancelSaleForecastEmployeePicture.Screen = null;
            this.fld_pteARCancelSaleForecastEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARCancelSaleForecastEmployeePicture.TabIndex = 109;
            this.fld_pteARCancelSaleForecastEmployeePicture.Tag = "DC";
            // 
            // fld_txtARCancelVoucherExchangeRate
            // 
            this.fld_txtARCancelVoucherExchangeRate.BOSComment = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSDataMember = "ARCancelSaleForecastExchangeRate";
            this.fld_txtARCancelVoucherExchangeRate.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherExchangeRate.BOSDescription = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSError = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSPrivilege = null;
            this.fld_txtARCancelVoucherExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherExchangeRate.Location = new System.Drawing.Point(722, 38);
            this.fld_txtARCancelVoucherExchangeRate.Name = "fld_txtARCancelVoucherExchangeRate";
            this.fld_txtARCancelVoucherExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARCancelVoucherExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherExchangeRate.Screen = null;
            this.fld_txtARCancelVoucherExchangeRate.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARCancelVoucherExchangeRate.TabIndex = 99;
            this.fld_txtARCancelVoucherExchangeRate.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(401, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(73, 13);
            this.bosLabel2.TabIndex = 103;
            this.bosLabel2.Text = "Ngày đơn hàng";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
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
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(119, 92);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 107;
            this.bosLabel5.Text = "Tình trạng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(119, 66);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(62, 13);
            this.bosLabel1.TabIndex = 106;
            this.bosLabel1.Text = "Mã đơn hàng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
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
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = null;
            this.fld_txtARSaleOrderNo.BOSDataMember = "ARSaleForecastNo";
            this.fld_txtARSaleOrderNo.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = null;
            this.fld_txtARSaleOrderNo.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(206, 63);
            this.fld_txtARSaleOrderNo.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Properties.ReadOnly = true;
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 100;
            this.fld_txtARSaleOrderNo.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = "";
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(206, 37);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
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
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
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
            // fld_dteARSaleOrderDate
            // 
            this.fld_dteARSaleOrderDate.BOSComment = null;
            this.fld_dteARSaleOrderDate.BOSDataMember = "ARSaleForecastDate";
            this.fld_dteARSaleOrderDate.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_dteARSaleOrderDate.BOSDescription = null;
            this.fld_dteARSaleOrderDate.BOSError = null;
            this.fld_dteARSaleOrderDate.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDate.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDate.BOSPrivilege = null;
            this.fld_dteARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDate.EditValue = null;
            this.fld_dteARSaleOrderDate.Location = new System.Drawing.Point(497, 64);
            this.fld_dteARSaleOrderDate.Name = "fld_dteARSaleOrderDate";
            this.fld_dteARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDate.Properties.ReadOnly = true;
            this.fld_dteARSaleOrderDate.Screen = null;
            this.fld_dteARSaleOrderDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARSaleOrderDate.TabIndex = 102;
            this.fld_dteARSaleOrderDate.Tag = "DC";
            // 
            // fld_dteARCancelVoucherDate
            // 
            this.fld_dteARCancelVoucherDate.BOSComment = null;
            this.fld_dteARCancelVoucherDate.BOSDataMember = "ARCancelSaleForecastDate";
            this.fld_dteARCancelVoucherDate.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_dteARCancelVoucherDate.BOSDescription = null;
            this.fld_dteARCancelVoucherDate.BOSError = null;
            this.fld_dteARCancelVoucherDate.BOSFieldGroup = null;
            this.fld_dteARCancelVoucherDate.BOSFieldRelation = null;
            this.fld_dteARCancelVoucherDate.BOSPrivilege = null;
            this.fld_dteARCancelVoucherDate.BOSPropertyName = "EditValue";
            this.fld_dteARCancelVoucherDate.EditValue = null;
            this.fld_dteARCancelVoucherDate.Location = new System.Drawing.Point(497, 11);
            this.fld_dteARCancelVoucherDate.Name = "fld_dteARCancelVoucherDate";
            this.fld_dteARCancelVoucherDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARCancelVoucherDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARCancelVoucherDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARCancelVoucherDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARCancelVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARCancelVoucherDate.Screen = null;
            this.fld_dteARCancelVoucherDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARCancelVoucherDate.TabIndex = 96;
            this.fld_dteARCancelVoucherDate.Tag = "DC";
            // 
            // fld_txtARCancelVoucherNo
            // 
            this.fld_txtARCancelVoucherNo.BOSComment = null;
            this.fld_txtARCancelVoucherNo.BOSDataMember = "ARCancelSaleForecastNo";
            this.fld_txtARCancelVoucherNo.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherNo.BOSDescription = null;
            this.fld_txtARCancelVoucherNo.BOSError = null;
            this.fld_txtARCancelVoucherNo.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherNo.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherNo.BOSPrivilege = null;
            this.fld_txtARCancelVoucherNo.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherNo.Location = new System.Drawing.Point(206, 11);
            this.fld_txtARCancelVoucherNo.MenuManager = this.screenToolbar;
            this.fld_txtARCancelVoucherNo.Name = "fld_txtARCancelVoucherNo";
            this.fld_txtARCancelVoucherNo.Screen = null;
            this.fld_txtARCancelVoucherNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARCancelVoucherNo.TabIndex = 95;
            this.fld_txtARCancelVoucherNo.Tag = "DC";
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
            this.fld_grcGroupControl3.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_grcGroupControl3.Controls.Add(this.fld_pteARCancelSaleForecastItemProductPicture);
            this.fld_grcGroupControl3.Controls.Add(this.fld_lblLabel48);
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcARCancelSaleForecastItems);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(3, 131);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(905, 163);
            this.fld_grcGroupControl3.TabIndex = 112;
            this.fld_grcGroupControl3.Text = "Danh sách sản phẩm";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARCancelSaleForecastItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(66, 25);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(716, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 11;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            // 
            // fld_pteARCancelSaleForecastItemProductPicture
            // 
            this.fld_pteARCancelSaleForecastItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSComment = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSDataMember = "ARCancelSaleForecastItemProductPicture";
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSDataSource = "ARCancelSaleForecastItems";
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSDescription = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSError = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSPrivilege = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARCancelSaleForecastItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARCancelSaleForecastItemProductPicture.FileName = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.FilePath = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.Location = new System.Drawing.Point(788, 27);
            this.fld_pteARCancelSaleForecastItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARCancelSaleForecastItemProductPicture.Name = "fld_pteARCancelSaleForecastItemProductPicture";
            this.fld_pteARCancelSaleForecastItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARCancelSaleForecastItemProductPicture.Screen = null;
            this.fld_pteARCancelSaleForecastItemProductPicture.Size = new System.Drawing.Size(111, 103);
            this.fld_pteARCancelSaleForecastItemProductPicture.TabIndex = 60;
            this.fld_pteARCancelSaleForecastItemProductPicture.Tag = "DC";
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
            // 
            // fld_dgcARCancelSaleForecastItems
            // 
            this.fld_dgcARCancelSaleForecastItems.AllowDrop = true;
            this.fld_dgcARCancelSaleForecastItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARCancelSaleForecastItems.BOSComment = null;
            this.fld_dgcARCancelSaleForecastItems.BOSDataMember = null;
            this.fld_dgcARCancelSaleForecastItems.BOSDataSource = "ARCancelSaleForecastItems";
            this.fld_dgcARCancelSaleForecastItems.BOSDescription = null;
            this.fld_dgcARCancelSaleForecastItems.BOSError = null;
            this.fld_dgcARCancelSaleForecastItems.BOSFieldGroup = null;
            this.fld_dgcARCancelSaleForecastItems.BOSFieldRelation = null;
            this.fld_dgcARCancelSaleForecastItems.BOSGridType = null;
            this.fld_dgcARCancelSaleForecastItems.BOSPrivilege = null;
            this.fld_dgcARCancelSaleForecastItems.BOSPropertyName = null;
            this.fld_dgcARCancelSaleForecastItems.CommodityType = "";
            this.fld_dgcARCancelSaleForecastItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCancelSaleForecastItems.Location = new System.Drawing.Point(11, 51);
            this.fld_dgcARCancelSaleForecastItems.MainView = this.fld_dgvARCancelVoucher;
            this.fld_dgcARCancelSaleForecastItems.Name = "fld_dgcARCancelSaleForecastItems";
            this.fld_dgcARCancelSaleForecastItems.PrintReport = false;
            this.fld_dgcARCancelSaleForecastItems.Screen = null;
            this.fld_dgcARCancelSaleForecastItems.Size = new System.Drawing.Size(771, 107);
            this.fld_dgcARCancelSaleForecastItems.TabIndex = 12;
            this.fld_dgcARCancelSaleForecastItems.Tag = "DC";
            this.fld_dgcARCancelSaleForecastItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCancelVoucher});
            // 
            // fld_dgvARCancelVoucher
            // 
            this.fld_dgvARCancelVoucher.GridControl = this.fld_dgcARCancelSaleForecastItems;
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
            this.bosLine1.Controls.Add(this.fld_medARCancelVoucherComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 300);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(285, 118);
            this.bosLine1.TabIndex = 119;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medARCancelVoucherComment
            // 
            this.fld_medARCancelVoucherComment.BOSComment = null;
            this.fld_medARCancelVoucherComment.BOSDataMember = "ARCancelSaleForecastDesc";
            this.fld_medARCancelVoucherComment.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_medARCancelVoucherComment.BOSDescription = null;
            this.fld_medARCancelVoucherComment.BOSError = null;
            this.fld_medARCancelVoucherComment.BOSFieldGroup = null;
            this.fld_medARCancelVoucherComment.BOSFieldRelation = null;
            this.fld_medARCancelVoucherComment.BOSPrivilege = null;
            this.fld_medARCancelVoucherComment.BOSPropertyName = "EditValue";
            this.fld_medARCancelVoucherComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medARCancelVoucherComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medARCancelVoucherComment.Name = "fld_medARCancelVoucherComment";
            this.fld_medARCancelVoucherComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARCancelVoucherComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARCancelVoucherComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARCancelVoucherComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARCancelVoucherComment.Screen = null;
            this.fld_medARCancelVoucherComment.Size = new System.Drawing.Size(279, 98);
            this.fld_medARCancelVoucherComment.TabIndex = 0;
            this.fld_medARCancelVoucherComment.Tag = "DC";
            // 
            // fld_txtARCancelVoucherTaxAmount
            // 
            this.fld_txtARCancelVoucherTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTaxAmount.BOSComment = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSDataMember = "ARCancelSaleForecastTaxAmount";
            this.fld_txtARCancelVoucherTaxAmount.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherTaxAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSError = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTaxAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherTaxAmount.Location = new System.Drawing.Point(808, 362);
            this.fld_txtARCancelVoucherTaxAmount.Name = "fld_txtARCancelVoucherTaxAmount";
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTaxAmount.Screen = null;
            this.fld_txtARCancelVoucherTaxAmount.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCancelVoucherTaxAmount.TabIndex = 117;
            this.fld_txtARCancelVoucherTaxAmount.Tag = "DC";
            // 
            // fld_txtARCancelVoucherTaxPercent
            // 
            this.fld_txtARCancelVoucherTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTaxPercent.BOSComment = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSDataMember = "ARCancelSaleForecastTaxPercent";
            this.fld_txtARCancelVoucherTaxPercent.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherTaxPercent.BOSDescription = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSError = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTaxPercent.EditValue = "0.00";
            this.fld_txtARCancelVoucherTaxPercent.Location = new System.Drawing.Point(734, 362);
            this.fld_txtARCancelVoucherTaxPercent.Name = "fld_txtARCancelVoucherTaxPercent";
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTaxPercent.Screen = null;
            this.fld_txtARCancelVoucherTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARCancelVoucherTaxPercent.TabIndex = 116;
            this.fld_txtARCancelVoucherTaxPercent.Tag = "DC";
            // 
            // fld_txtARCancelVoucherDiscountPerCent
            // 
            this.fld_txtARCancelVoucherDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherDiscountPerCent.BOSComment = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDataMember = "ARCancelSaleForecastDiscountPerCent";
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherDiscountPerCent.BOSDescription = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSError = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSPrivilege = null;
            this.fld_txtARCancelVoucherDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherDiscountPerCent.EditValue = "0.00";
            this.fld_txtARCancelVoucherDiscountPerCent.Location = new System.Drawing.Point(734, 336);
            this.fld_txtARCancelVoucherDiscountPerCent.Name = "fld_txtARCancelVoucherDiscountPerCent";
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherDiscountPerCent.Screen = null;
            this.fld_txtARCancelVoucherDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtARCancelVoucherDiscountPerCent.TabIndex = 114;
            this.fld_txtARCancelVoucherDiscountPerCent.Tag = "DC";
            // 
            // fld_lblLabel45
            // 
            this.fld_lblLabel45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel45.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel45.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel45.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel45.BOSComment = null;
            this.fld_lblLabel45.BOSDataMember = null;
            this.fld_lblLabel45.BOSDataSource = null;
            this.fld_lblLabel45.BOSDescription = null;
            this.fld_lblLabel45.BOSError = null;
            this.fld_lblLabel45.BOSFieldGroup = null;
            this.fld_lblLabel45.BOSFieldRelation = null;
            this.fld_lblLabel45.BOSPrivilege = null;
            this.fld_lblLabel45.BOSPropertyName = null;
            this.fld_lblLabel45.Location = new System.Drawing.Point(618, 339);
            this.fld_lblLabel45.Name = "fld_lblLabel45";
            this.fld_lblLabel45.Screen = null;
            this.fld_lblLabel45.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel45.TabIndex = 121;
            this.fld_lblLabel45.Text = "Chiết khấu";
            // 
            // fld_lblLabel44
            // 
            this.fld_lblLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel44.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel44.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel44.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel44.BOSComment = null;
            this.fld_lblLabel44.BOSDataMember = null;
            this.fld_lblLabel44.BOSDataSource = null;
            this.fld_lblLabel44.BOSDescription = null;
            this.fld_lblLabel44.BOSError = null;
            this.fld_lblLabel44.BOSFieldGroup = null;
            this.fld_lblLabel44.BOSFieldRelation = null;
            this.fld_lblLabel44.BOSPrivilege = null;
            this.fld_lblLabel44.BOSPropertyName = null;
            this.fld_lblLabel44.Location = new System.Drawing.Point(618, 312);
            this.fld_lblLabel44.Name = "fld_lblLabel44";
            this.fld_lblLabel44.Screen = null;
            this.fld_lblLabel44.Size = new System.Drawing.Size(50, 13);
            this.fld_lblLabel44.TabIndex = 120;
            this.fld_lblLabel44.Text = "Tổng cộng";
            // 
            // fld_txtARCancelVoucherDiscountFix
            // 
            this.fld_txtARCancelVoucherDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherDiscountFix.BOSComment = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSDataMember = "ARCancelSaleForecastDiscountFix";
            this.fld_txtARCancelVoucherDiscountFix.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherDiscountFix.BOSDescription = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSError = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSPrivilege = null;
            this.fld_txtARCancelVoucherDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherDiscountFix.EditValue = "0.00";
            this.fld_txtARCancelVoucherDiscountFix.Location = new System.Drawing.Point(808, 336);
            this.fld_txtARCancelVoucherDiscountFix.Name = "fld_txtARCancelVoucherDiscountFix";
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherDiscountFix.Screen = null;
            this.fld_txtARCancelVoucherDiscountFix.Size = new System.Drawing.Size(100, 20);
            this.fld_txtARCancelVoucherDiscountFix.TabIndex = 115;
            this.fld_txtARCancelVoucherDiscountFix.Tag = "DC";
            // 
            // fld_lblLabel47
            // 
            this.fld_lblLabel47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel47.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel47.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel47.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel47.Appearance.Options.UseFont = true;
            this.fld_lblLabel47.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel47.BOSComment = null;
            this.fld_lblLabel47.BOSDataMember = null;
            this.fld_lblLabel47.BOSDataSource = null;
            this.fld_lblLabel47.BOSDescription = null;
            this.fld_lblLabel47.BOSError = null;
            this.fld_lblLabel47.BOSFieldGroup = null;
            this.fld_lblLabel47.BOSFieldRelation = null;
            this.fld_lblLabel47.BOSPrivilege = null;
            this.fld_lblLabel47.BOSPropertyName = null;
            this.fld_lblLabel47.Location = new System.Drawing.Point(618, 393);
            this.fld_lblLabel47.Name = "fld_lblLabel47";
            this.fld_lblLabel47.Screen = null;
            this.fld_lblLabel47.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel47.TabIndex = 123;
            this.fld_lblLabel47.Text = "THÀNH TIỀN";
            // 
            // fld_txtARCancelVoucherTotalAmount
            // 
            this.fld_txtARCancelVoucherTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherTotalAmount.BOSComment = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSDataMember = "ARCancelSaleForecastTotalAmount";
            this.fld_txtARCancelVoucherTotalAmount.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherTotalAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSError = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherTotalAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherTotalAmount.Location = new System.Drawing.Point(734, 390);
            this.fld_txtARCancelVoucherTotalAmount.Name = "fld_txtARCancelVoucherTotalAmount";
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCancelVoucherTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherTotalAmount.Screen = null;
            this.fld_txtARCancelVoucherTotalAmount.Size = new System.Drawing.Size(174, 20);
            this.fld_txtARCancelVoucherTotalAmount.TabIndex = 118;
            this.fld_txtARCancelVoucherTotalAmount.Tag = "DC";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = null;
            this.fld_lblLabel46.BOSDataMember = null;
            this.fld_lblLabel46.BOSDataSource = null;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = null;
            this.fld_lblLabel46.BOSFieldRelation = null;
            this.fld_lblLabel46.BOSPrivilege = null;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(618, 365);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel46.TabIndex = 122;
            this.fld_lblLabel46.Text = "Thuế";
            // 
            // fld_txtARCancelVoucherSubTotalAmount
            // 
            this.fld_txtARCancelVoucherSubTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARCancelVoucherSubTotalAmount.BOSComment = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDataMember = "ARCancelSaleForecastSubTotalAmount";
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDataSource = "ARCancelSaleForecasts";
            this.fld_txtARCancelVoucherSubTotalAmount.BOSDescription = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSError = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSFieldGroup = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSFieldRelation = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSPrivilege = null;
            this.fld_txtARCancelVoucherSubTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtARCancelVoucherSubTotalAmount.EditValue = "0.00";
            this.fld_txtARCancelVoucherSubTotalAmount.Location = new System.Drawing.Point(734, 309);
            this.fld_txtARCancelVoucherSubTotalAmount.Name = "fld_txtARCancelVoucherSubTotalAmount";
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCancelVoucherSubTotalAmount.Properties.ReadOnly = true;
            this.fld_txtARCancelVoucherSubTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCancelVoucherSubTotalAmount.Screen = null;
            this.fld_txtARCancelVoucherSubTotalAmount.Size = new System.Drawing.Size(174, 20);
            this.fld_txtARCancelVoucherSubTotalAmount.TabIndex = 113;
            this.fld_txtARCancelVoucherSubTotalAmount.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_pteARCancelSaleForecastEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTaxAmount);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel45);
            this.bosPanel1.Controls.Add(this.fld_dteARCancelVoucherDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel44);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherDiscountFix);
            this.bosPanel1.Controls.Add(this.fld_dteARSaleOrderDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel47);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lblLabel46);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherSubTotalAmount);
            this.bosPanel1.Controls.Add(this.fld_txtARSaleOrderNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeARCancelVoucherStatus);
            this.bosPanel1.Controls.Add(this.fld_txtARCancelVoucherExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(914, 422);
            this.bosPanel1.TabIndex = 124;
            // 
            // DMARCS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(914, 422);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMARCS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCancelVoucherStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelSaleForecastEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARCancelVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            this.fld_grcGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARCancelSaleForecastItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCancelSaleForecastItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCancelVoucher)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARCancelVoucherComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCancelVoucherSubTotalAmount.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeARCancelVoucherStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSPictureEdit fld_pteARCancelSaleForecastEmployeePicture;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherExchangeRate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDate;
        private BOSComponent.BOSDateEdit fld_dteARCancelVoucherDate;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherNo;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl3;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSPictureEdit fld_pteARCancelSaleForecastItemProductPicture;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSERP.Modules.CancelSaleForecast.ARCancelSaleForecastItemsGridControl fld_dgcARCancelSaleForecastItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCancelVoucher;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medARCancelVoucherComment;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTaxAmount;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTaxPercent;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherDiscountPerCent;
        private BOSComponent.BOSLabel fld_lblLabel45;
        private BOSComponent.BOSLabel fld_lblLabel44;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherDiscountFix;
        private BOSComponent.BOSLabel fld_lblLabel47;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherTotalAmount;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSTextBox fld_txtARCancelVoucherSubTotalAmount;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
