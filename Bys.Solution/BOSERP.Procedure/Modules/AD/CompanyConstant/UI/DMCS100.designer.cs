using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS100
	/// </summary>
	partial class DMCS100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCSCashFunds = new BOSERP.Modules.CompanyConstant.CSCashFundGridControl();
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcCSCompanyBanks = new BOSERP.Modules.CompanyConstant.CSCompanyBankGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grpGroupControl3 = new BOSComponent.BOSLine(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GESaleCurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GEPurchaseCurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanySaleExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyPurchaseExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyPhone = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyWebsite = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyEmail = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyAddressCountry = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyAddressLine1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyAddressStateProvince = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyAddressCity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyAddressPostalCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyDesc = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyFax = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtCSCompanyAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel89 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCSCompanyExceededDay = new BOSComponent.BOSTextBox(this.components);
            this.fld_grpGroupControl1 = new BOSComponent.BOSLine(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCSCashFunds)).BeginInit();
            this.fld_Line1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCSCompanyBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_grpGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GESaleCurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPurchaseCurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanySaleExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyPurchaseExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressLine1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressLine3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyExceededDay.Properties)).BeginInit();
            this.fld_grpGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_Line1);
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl3);
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(871, 790);
            this.bosPanel1.TabIndex = 334;
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcCSCashFunds);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(8, 545);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(810, 232);
            this.bosLine1.TabIndex = 64;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Danh sách quỹ tiền mặt";
            // 
            // fld_dgcCSCashFunds
            // 
            this.fld_dgcCSCashFunds.BOSComment = null;
            this.fld_dgcCSCashFunds.BOSDataMember = null;
            this.fld_dgcCSCashFunds.BOSDataSource = "CSCashFunds";
            this.fld_dgcCSCashFunds.BOSDescription = null;
            this.fld_dgcCSCashFunds.BOSError = null;
            this.fld_dgcCSCashFunds.BOSFieldGroup = null;
            this.fld_dgcCSCashFunds.BOSFieldRelation = null;
            this.fld_dgcCSCashFunds.BOSGridType = null;
            this.fld_dgcCSCashFunds.BOSPrivilege = null;
            this.fld_dgcCSCashFunds.BOSPropertyName = null;
            this.fld_dgcCSCashFunds.CommodityType = "";
            this.fld_dgcCSCashFunds.Location = new System.Drawing.Point(3, 21);
            this.fld_dgcCSCashFunds.MenuManager = this.screenToolbar;
            this.fld_dgcCSCashFunds.Name = "fld_dgcCSCashFunds";
            this.fld_dgcCSCashFunds.PrintReport = false;
            this.fld_dgcCSCashFunds.Screen = null;
            this.fld_dgcCSCashFunds.Size = new System.Drawing.Size(769, 204);
            this.fld_dgcCSCashFunds.TabIndex = 0;
            // 
            // fld_Line1
            // 
            this.fld_Line1.BOSComment = null;
            this.fld_Line1.BOSDataMember = null;
            this.fld_Line1.BOSDataSource = null;
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = null;
            this.fld_Line1.BOSFieldRelation = null;
            this.fld_Line1.BOSPrivilege = null;
            this.fld_Line1.BOSPropertyName = null;
            this.fld_Line1.Controls.Add(this.fld_dgcCSCompanyBanks);
            this.fld_Line1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_Line1.Location = new System.Drawing.Point(8, 337);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(810, 202);
            this.fld_Line1.TabIndex = 63;
            this.fld_Line1.TabStop = false;
            this.fld_Line1.Text = "Danh sách ngân hàng";
            // 
            // fld_dgcCSCompanyBanks
            // 
            this.fld_dgcCSCompanyBanks.AllowDrop = true;
            this.fld_dgcCSCompanyBanks.BOSComment = "";
            this.fld_dgcCSCompanyBanks.BOSDataMember = null;
            this.fld_dgcCSCompanyBanks.BOSDataSource = "CSCompanyBanks";
            this.fld_dgcCSCompanyBanks.BOSDescription = null;
            this.fld_dgcCSCompanyBanks.BOSError = "";
            this.fld_dgcCSCompanyBanks.BOSFieldGroup = "";
            this.fld_dgcCSCompanyBanks.BOSFieldRelation = null;
            this.fld_dgcCSCompanyBanks.BOSGridType = null;
            this.fld_dgcCSCompanyBanks.BOSPrivilege = "";
            this.fld_dgcCSCompanyBanks.BOSPropertyName = null;
            this.fld_dgcCSCompanyBanks.CommodityType = "";
            this.fld_dgcCSCompanyBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCSCompanyBanks.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCSCompanyBanks.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcCSCompanyBanks.MainView = this.gridView1;
            this.fld_dgcCSCompanyBanks.Name = "fld_dgcCSCompanyBanks";
            this.fld_dgcCSCompanyBanks.PrintReport = false;
            this.fld_dgcCSCompanyBanks.Screen = null;
            this.fld_dgcCSCompanyBanks.Size = new System.Drawing.Size(804, 182);
            this.fld_dgcCSCompanyBanks.TabIndex = 0;
            this.fld_dgcCSCompanyBanks.Tag = "DC";
            this.fld_dgcCSCompanyBanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcCSCompanyBanks;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_grpGroupControl3
            // 
            this.fld_grpGroupControl3.BOSComment = null;
            this.fld_grpGroupControl3.BOSDataMember = null;
            this.fld_grpGroupControl3.BOSDataSource = null;
            this.fld_grpGroupControl3.BOSDescription = null;
            this.fld_grpGroupControl3.BOSError = null;
            this.fld_grpGroupControl3.BOSFieldGroup = null;
            this.fld_grpGroupControl3.BOSFieldRelation = null;
            this.fld_grpGroupControl3.BOSPrivilege = null;
            this.fld_grpGroupControl3.BOSPropertyName = null;
            this.fld_grpGroupControl3.Controls.Add(this.bosLabel3);
            this.fld_grpGroupControl3.Controls.Add(this.bosLabel1);
            this.fld_grpGroupControl3.Controls.Add(this.fld_lkeFK_GESaleCurrencyID);
            this.fld_grpGroupControl3.Controls.Add(this.fld_lkeFK_GEPurchaseCurrencyID);
            this.fld_grpGroupControl3.Controls.Add(this.bosLabel4);
            this.fld_grpGroupControl3.Controls.Add(this.bosLabel2);
            this.fld_grpGroupControl3.Controls.Add(this.fld_txtCSCompanySaleExchangeRate);
            this.fld_grpGroupControl3.Controls.Add(this.fld_txtCSCompanyPurchaseExchangeRate);
            this.fld_grpGroupControl3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl3.Location = new System.Drawing.Point(8, 242);
            this.fld_grpGroupControl3.Name = "fld_grpGroupControl3";
            this.fld_grpGroupControl3.Screen = null;
            this.fld_grpGroupControl3.Size = new System.Drawing.Size(810, 89);
            this.fld_grpGroupControl3.TabIndex = 1;
            this.fld_grpGroupControl3.TabStop = false;
            this.fld_grpGroupControl3.Text = "Thông tin giao dịch";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(15, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 36;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại tiền bán";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(15, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(63, 13);
            this.bosLabel1.TabIndex = 36;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Loại tiền mua";
            // 
            // fld_lkeFK_GESaleCurrencyID
            // 
            this.fld_lkeFK_GESaleCurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GESaleCurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GESaleCurrencyID.BOSComment = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSDataMember = "FK_GESaleCurrencyID";
            this.fld_lkeFK_GESaleCurrencyID.BOSDataSource = "CSCompanys";
            this.fld_lkeFK_GESaleCurrencyID.BOSDescription = null;
            this.fld_lkeFK_GESaleCurrencyID.BOSError = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GESaleCurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GESaleCurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GESaleCurrencyID.CurrentDisplayText = "";
            this.fld_lkeFK_GESaleCurrencyID.Location = new System.Drawing.Point(133, 46);
            this.fld_lkeFK_GESaleCurrencyID.Name = "fld_lkeFK_GESaleCurrencyID";
            this.fld_lkeFK_GESaleCurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GESaleCurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GESaleCurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GESaleCurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GESaleCurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GESaleCurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GESaleCurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GESaleCurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GESaleCurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GESaleCurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GESaleCurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GESaleCurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GESaleCurrencyID.Screen = null;
            this.fld_lkeFK_GESaleCurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GESaleCurrencyID.TabIndex = 2;
            this.fld_lkeFK_GESaleCurrencyID.Tag = "DC";
            // 
            // fld_lkeFK_GEPurchaseCurrencyID
            // 
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSComment = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSDataMember = "FK_GEPurchaseCurrencyID";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSDataSource = "CSCompanys";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSDescription = null;
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSError = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.CurrentDisplayText = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.Location = new System.Drawing.Point(133, 20);
            this.fld_lkeFK_GEPurchaseCurrencyID.Name = "fld_lkeFK_GEPurchaseCurrencyID";
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPurchaseCurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GEPurchaseCurrencyID.Screen = null;
            this.fld_lkeFK_GEPurchaseCurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GEPurchaseCurrencyID.TabIndex = 0;
            this.fld_lkeFK_GEPurchaseCurrencyID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(319, 49);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 39;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(319, 23);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(29, 13);
            this.bosLabel2.TabIndex = 39;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tỷ giá";
            // 
            // fld_txtCSCompanySaleExchangeRate
            // 
            this.fld_txtCSCompanySaleExchangeRate.BOSComment = "";
            this.fld_txtCSCompanySaleExchangeRate.BOSDataMember = "CSCompanySaleExchangeRate";
            this.fld_txtCSCompanySaleExchangeRate.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanySaleExchangeRate.BOSDescription = null;
            this.fld_txtCSCompanySaleExchangeRate.BOSError = "";
            this.fld_txtCSCompanySaleExchangeRate.BOSFieldGroup = "";
            this.fld_txtCSCompanySaleExchangeRate.BOSFieldRelation = "";
            this.fld_txtCSCompanySaleExchangeRate.BOSPrivilege = "";
            this.fld_txtCSCompanySaleExchangeRate.BOSPropertyName = "Text";
            this.fld_txtCSCompanySaleExchangeRate.Location = new System.Drawing.Point(393, 46);
            this.fld_txtCSCompanySaleExchangeRate.Name = "fld_txtCSCompanySaleExchangeRate";
            this.fld_txtCSCompanySaleExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanySaleExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanySaleExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanySaleExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanySaleExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanySaleExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanySaleExchangeRate.Screen = null;
            this.fld_txtCSCompanySaleExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanySaleExchangeRate.TabIndex = 3;
            this.fld_txtCSCompanySaleExchangeRate.Tag = "DC";
            // 
            // fld_txtCSCompanyPurchaseExchangeRate
            // 
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSComment = "";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSDataMember = "CSCompanyPurchaseExchangeRate";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSDescription = null;
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSError = "";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSFieldGroup = "";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSFieldRelation = "";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSPrivilege = "";
            this.fld_txtCSCompanyPurchaseExchangeRate.BOSPropertyName = "Text";
            this.fld_txtCSCompanyPurchaseExchangeRate.Location = new System.Drawing.Point(393, 20);
            this.fld_txtCSCompanyPurchaseExchangeRate.Name = "fld_txtCSCompanyPurchaseExchangeRate";
            this.fld_txtCSCompanyPurchaseExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyPurchaseExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyPurchaseExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyPurchaseExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyPurchaseExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyPurchaseExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyPurchaseExchangeRate.Screen = null;
            this.fld_txtCSCompanyPurchaseExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyPurchaseExchangeRate.TabIndex = 1;
            this.fld_txtCSCompanyPurchaseExchangeRate.Tag = "DC";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(575, 72);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel10.TabIndex = 12;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Website";
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = null;
            this.fld_lblLabel9.Location = new System.Drawing.Point(575, 46);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel9.TabIndex = 11;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Email";
            // 
            // fld_txtCSCompanyPhone
            // 
            this.fld_txtCSCompanyPhone.BOSComment = "";
            this.fld_txtCSCompanyPhone.BOSDataMember = "CSCompanyPhone";
            this.fld_txtCSCompanyPhone.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyPhone.BOSDescription = null;
            this.fld_txtCSCompanyPhone.BOSError = "";
            this.fld_txtCSCompanyPhone.BOSFieldGroup = "";
            this.fld_txtCSCompanyPhone.BOSFieldRelation = "";
            this.fld_txtCSCompanyPhone.BOSPrivilege = "";
            this.fld_txtCSCompanyPhone.BOSPropertyName = "Text";
            this.fld_txtCSCompanyPhone.Location = new System.Drawing.Point(647, 17);
            this.fld_txtCSCompanyPhone.Name = "fld_txtCSCompanyPhone";
            this.fld_txtCSCompanyPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyPhone.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyPhone.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyPhone.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyPhone.Screen = null;
            this.fld_txtCSCompanyPhone.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyPhone.TabIndex = 7;
            this.fld_txtCSCompanyPhone.Tag = "DC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(575, 20);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel12.TabIndex = 14;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Điện thoại";
            // 
            // fld_txtCSCompanyWebsite
            // 
            this.fld_txtCSCompanyWebsite.BOSComment = "";
            this.fld_txtCSCompanyWebsite.BOSDataMember = "CSCompanyWebsite";
            this.fld_txtCSCompanyWebsite.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyWebsite.BOSDescription = null;
            this.fld_txtCSCompanyWebsite.BOSError = "";
            this.fld_txtCSCompanyWebsite.BOSFieldGroup = "";
            this.fld_txtCSCompanyWebsite.BOSFieldRelation = "";
            this.fld_txtCSCompanyWebsite.BOSPrivilege = "";
            this.fld_txtCSCompanyWebsite.BOSPropertyName = "Text";
            this.fld_txtCSCompanyWebsite.Location = new System.Drawing.Point(647, 69);
            this.fld_txtCSCompanyWebsite.Name = "fld_txtCSCompanyWebsite";
            this.fld_txtCSCompanyWebsite.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyWebsite.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyWebsite.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyWebsite.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyWebsite.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyWebsite.Screen = null;
            this.fld_txtCSCompanyWebsite.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyWebsite.TabIndex = 9;
            this.fld_txtCSCompanyWebsite.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(15, 176);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel8.TabIndex = 10;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Quốc gia";
            // 
            // fld_txtCSCompanyEmail
            // 
            this.fld_txtCSCompanyEmail.BOSComment = "";
            this.fld_txtCSCompanyEmail.BOSDataMember = "CSCompanyEmail";
            this.fld_txtCSCompanyEmail.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyEmail.BOSDescription = null;
            this.fld_txtCSCompanyEmail.BOSError = "";
            this.fld_txtCSCompanyEmail.BOSFieldGroup = "";
            this.fld_txtCSCompanyEmail.BOSFieldRelation = "";
            this.fld_txtCSCompanyEmail.BOSPrivilege = "";
            this.fld_txtCSCompanyEmail.BOSPropertyName = "Text";
            this.fld_txtCSCompanyEmail.Location = new System.Drawing.Point(647, 43);
            this.fld_txtCSCompanyEmail.Name = "fld_txtCSCompanyEmail";
            this.fld_txtCSCompanyEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyEmail.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyEmail.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyEmail.Screen = null;
            this.fld_txtCSCompanyEmail.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyEmail.TabIndex = 8;
            this.fld_txtCSCompanyEmail.Tag = "DC";
            // 
            // fld_txtCSCompanyAddressCountry
            // 
            this.fld_txtCSCompanyAddressCountry.BOSComment = "";
            this.fld_txtCSCompanyAddressCountry.BOSDataMember = "CSCompanyAddressCountry";
            this.fld_txtCSCompanyAddressCountry.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressCountry.BOSDescription = null;
            this.fld_txtCSCompanyAddressCountry.BOSError = "";
            this.fld_txtCSCompanyAddressCountry.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressCountry.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressCountry.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressCountry.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressCountry.Location = new System.Drawing.Point(133, 173);
            this.fld_txtCSCompanyAddressCountry.Name = "fld_txtCSCompanyAddressCountry";
            this.fld_txtCSCompanyAddressCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressCountry.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressCountry.Screen = null;
            this.fld_txtCSCompanyAddressCountry.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyAddressCountry.TabIndex = 5;
            this.fld_txtCSCompanyAddressCountry.Tag = "DC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(319, 150);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Tỉnh";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(319, 176);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel5.TabIndex = 7;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Mã vùng";
            // 
            // fld_txtCSCompanyAddressLine1
            // 
            this.fld_txtCSCompanyAddressLine1.BOSComment = "";
            this.fld_txtCSCompanyAddressLine1.BOSDataMember = "CSCompanyAddressLine1";
            this.fld_txtCSCompanyAddressLine1.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressLine1.BOSDescription = null;
            this.fld_txtCSCompanyAddressLine1.BOSError = "";
            this.fld_txtCSCompanyAddressLine1.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressLine1.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressLine1.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressLine1.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressLine1.Location = new System.Drawing.Point(133, 69);
            this.fld_txtCSCompanyAddressLine1.Name = "fld_txtCSCompanyAddressLine1";
            this.fld_txtCSCompanyAddressLine1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressLine1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressLine1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressLine1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressLine1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressLine1.Screen = null;
            this.fld_txtCSCompanyAddressLine1.Size = new System.Drawing.Size(410, 20);
            this.fld_txtCSCompanyAddressLine1.TabIndex = 1;
            this.fld_txtCSCompanyAddressLine1.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "";
            this.fld_Lablel2.BOSDataMember = "";
            this.fld_Lablel2.BOSDataSource = "";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "";
            this.fld_Lablel2.BOSFieldRelation = "";
            this.fld_Lablel2.BOSPrivilege = "";
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(15, 150);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(51, 13);
            this.fld_Lablel2.TabIndex = 6;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Thành phố";
            // 
            // fld_txtCSCompanyAddressStateProvince
            // 
            this.fld_txtCSCompanyAddressStateProvince.BOSComment = "";
            this.fld_txtCSCompanyAddressStateProvince.BOSDataMember = "CSCompanyAddressStateProvince";
            this.fld_txtCSCompanyAddressStateProvince.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressStateProvince.BOSDescription = null;
            this.fld_txtCSCompanyAddressStateProvince.BOSError = "";
            this.fld_txtCSCompanyAddressStateProvince.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressStateProvince.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressStateProvince.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressStateProvince.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressStateProvince.Location = new System.Drawing.Point(393, 147);
            this.fld_txtCSCompanyAddressStateProvince.Name = "fld_txtCSCompanyAddressStateProvince";
            this.fld_txtCSCompanyAddressStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressStateProvince.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressStateProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressStateProvince.Screen = null;
            this.fld_txtCSCompanyAddressStateProvince.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyAddressStateProvince.TabIndex = 4;
            this.fld_txtCSCompanyAddressStateProvince.Tag = "DC";
            // 
            // fld_txtCSCompanyAddressCity
            // 
            this.fld_txtCSCompanyAddressCity.BOSComment = "";
            this.fld_txtCSCompanyAddressCity.BOSDataMember = "CSCompanyAddressCity";
            this.fld_txtCSCompanyAddressCity.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressCity.BOSDescription = null;
            this.fld_txtCSCompanyAddressCity.BOSError = "";
            this.fld_txtCSCompanyAddressCity.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressCity.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressCity.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressCity.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressCity.Location = new System.Drawing.Point(133, 147);
            this.fld_txtCSCompanyAddressCity.Name = "fld_txtCSCompanyAddressCity";
            this.fld_txtCSCompanyAddressCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressCity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressCity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressCity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressCity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressCity.Screen = null;
            this.fld_txtCSCompanyAddressCity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyAddressCity.TabIndex = 3;
            this.fld_txtCSCompanyAddressCity.Tag = "DC";
            // 
            // fld_txtCSCompanyAddressPostalCode
            // 
            this.fld_txtCSCompanyAddressPostalCode.BOSComment = "";
            this.fld_txtCSCompanyAddressPostalCode.BOSDataMember = "CSCompanyAddressPostalCode";
            this.fld_txtCSCompanyAddressPostalCode.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressPostalCode.BOSDescription = null;
            this.fld_txtCSCompanyAddressPostalCode.BOSError = "";
            this.fld_txtCSCompanyAddressPostalCode.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressPostalCode.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressPostalCode.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressPostalCode.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressPostalCode.Location = new System.Drawing.Point(393, 173);
            this.fld_txtCSCompanyAddressPostalCode.Name = "fld_txtCSCompanyAddressPostalCode";
            this.fld_txtCSCompanyAddressPostalCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressPostalCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressPostalCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressPostalCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressPostalCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressPostalCode.Screen = null;
            this.fld_txtCSCompanyAddressPostalCode.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyAddressPostalCode.TabIndex = 6;
            this.fld_txtCSCompanyAddressPostalCode.Tag = "DC";
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = "";
            this.fld_Lablel1.BOSDataMember = "";
            this.fld_Lablel1.BOSDataSource = "";
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = "";
            this.fld_Lablel1.BOSFieldRelation = "";
            this.fld_Lablel1.BOSPrivilege = "";
            this.fld_Lablel1.BOSPropertyName = null;
            this.fld_Lablel1.Location = new System.Drawing.Point(15, 72);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(32, 13);
            this.fld_Lablel1.TabIndex = 5;
            this.fld_Lablel1.Tag = "";
            this.fld_Lablel1.Text = "Địa chỉ";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(15, 20);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel7.TabIndex = 59;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Tên công ty";
            // 
            // fld_txtCSCompanyDesc
            // 
            this.fld_txtCSCompanyDesc.BOSComment = "";
            this.fld_txtCSCompanyDesc.BOSDataMember = "CSCompanyDesc";
            this.fld_txtCSCompanyDesc.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyDesc.BOSDescription = null;
            this.fld_txtCSCompanyDesc.BOSError = "";
            this.fld_txtCSCompanyDesc.BOSFieldGroup = "";
            this.fld_txtCSCompanyDesc.BOSFieldRelation = "";
            this.fld_txtCSCompanyDesc.BOSPrivilege = "";
            this.fld_txtCSCompanyDesc.BOSPropertyName = "Text";
            this.fld_txtCSCompanyDesc.Location = new System.Drawing.Point(133, 17);
            this.fld_txtCSCompanyDesc.Name = "fld_txtCSCompanyDesc";
            this.fld_txtCSCompanyDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyDesc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyDesc.Screen = null;
            this.fld_txtCSCompanyDesc.Size = new System.Drawing.Size(410, 20);
            this.fld_txtCSCompanyDesc.TabIndex = 0;
            this.fld_txtCSCompanyDesc.Tag = "DC";
            // 
            // fld_txtCSCompanyFax
            // 
            this.fld_txtCSCompanyFax.BOSComment = "";
            this.fld_txtCSCompanyFax.BOSDataMember = "CSCompanyFax";
            this.fld_txtCSCompanyFax.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyFax.BOSDescription = null;
            this.fld_txtCSCompanyFax.BOSError = "";
            this.fld_txtCSCompanyFax.BOSFieldGroup = "";
            this.fld_txtCSCompanyFax.BOSFieldRelation = "";
            this.fld_txtCSCompanyFax.BOSPrivilege = "";
            this.fld_txtCSCompanyFax.BOSPropertyName = "Text";
            this.fld_txtCSCompanyFax.Location = new System.Drawing.Point(647, 95);
            this.fld_txtCSCompanyFax.Name = "fld_txtCSCompanyFax";
            this.fld_txtCSCompanyFax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyFax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyFax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyFax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyFax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyFax.Screen = null;
            this.fld_txtCSCompanyFax.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyFax.TabIndex = 10;
            this.fld_txtCSCompanyFax.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(575, 98);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(31, 13);
            this.fld_lblLabel11.TabIndex = 62;
            this.fld_lblLabel11.Tag = "";
            this.fld_lblLabel11.Text = "Số fax";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(575, 124);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel13.TabIndex = 60;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "Mã số thuế";
            // 
            // fld_txtCSCompanyTaxNumber
            // 
            this.fld_txtCSCompanyTaxNumber.BOSComment = "";
            this.fld_txtCSCompanyTaxNumber.BOSDataMember = "CSCompanyTaxNumber";
            this.fld_txtCSCompanyTaxNumber.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyTaxNumber.BOSDescription = null;
            this.fld_txtCSCompanyTaxNumber.BOSError = "";
            this.fld_txtCSCompanyTaxNumber.BOSFieldGroup = "";
            this.fld_txtCSCompanyTaxNumber.BOSFieldRelation = "";
            this.fld_txtCSCompanyTaxNumber.BOSPrivilege = "";
            this.fld_txtCSCompanyTaxNumber.BOSPropertyName = "Text";
            this.fld_txtCSCompanyTaxNumber.Location = new System.Drawing.Point(647, 121);
            this.fld_txtCSCompanyTaxNumber.Name = "fld_txtCSCompanyTaxNumber";
            this.fld_txtCSCompanyTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyTaxNumber.Screen = null;
            this.fld_txtCSCompanyTaxNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyTaxNumber.TabIndex = 11;
            this.fld_txtCSCompanyTaxNumber.Tag = "DC";
            // 
            // fld_txtCSCompanyAddressLine3
            // 
            this.fld_txtCSCompanyAddressLine3.BOSComment = "";
            this.fld_txtCSCompanyAddressLine3.BOSDataMember = "CSCompanyAddressLine3";
            this.fld_txtCSCompanyAddressLine3.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyAddressLine3.BOSDescription = null;
            this.fld_txtCSCompanyAddressLine3.BOSError = "";
            this.fld_txtCSCompanyAddressLine3.BOSFieldGroup = "";
            this.fld_txtCSCompanyAddressLine3.BOSFieldRelation = "";
            this.fld_txtCSCompanyAddressLine3.BOSPrivilege = "";
            this.fld_txtCSCompanyAddressLine3.BOSPropertyName = "Text";
            this.fld_txtCSCompanyAddressLine3.Location = new System.Drawing.Point(133, 121);
            this.fld_txtCSCompanyAddressLine3.Name = "fld_txtCSCompanyAddressLine3";
            this.fld_txtCSCompanyAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtCSCompanyAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtCSCompanyAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtCSCompanyAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtCSCompanyAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtCSCompanyAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtCSCompanyAddressLine3.Screen = null;
            this.fld_txtCSCompanyAddressLine3.Size = new System.Drawing.Size(410, 20);
            this.fld_txtCSCompanyAddressLine3.TabIndex = 2;
            this.fld_txtCSCompanyAddressLine3.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(15, 124);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(82, 13);
            this.bosLabel5.TabIndex = 64;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Địa chỉ giao hàng";
            // 
            // bosLabel89
            // 
            this.bosLabel89.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel89.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel89.Appearance.Options.UseBackColor = true;
            this.bosLabel89.Appearance.Options.UseForeColor = true;
            this.bosLabel89.BOSComment = null;
            this.bosLabel89.BOSDataMember = null;
            this.bosLabel89.BOSDataSource = null;
            this.bosLabel89.BOSDescription = null;
            this.bosLabel89.BOSError = null;
            this.bosLabel89.BOSFieldGroup = null;
            this.bosLabel89.BOSFieldRelation = null;
            this.bosLabel89.BOSPrivilege = null;
            this.bosLabel89.BOSPropertyName = null;
            this.bosLabel89.Location = new System.Drawing.Point(15, 202);
            this.bosLabel89.Name = "bosLabel89";
            this.bosLabel89.Screen = null;
            this.bosLabel89.Size = new System.Drawing.Size(90, 13);
            this.bosLabel89.TabIndex = 697;
            this.bosLabel89.Text = "Số ngày xuất vượt";
            // 
            // fld_txtCSCompanyExceededDay
            // 
            this.fld_txtCSCompanyExceededDay.BOSComment = null;
            this.fld_txtCSCompanyExceededDay.BOSDataMember = "CSCompanyExceededDay";
            this.fld_txtCSCompanyExceededDay.BOSDataSource = "CSCompanys";
            this.fld_txtCSCompanyExceededDay.BOSDescription = null;
            this.fld_txtCSCompanyExceededDay.BOSError = null;
            this.fld_txtCSCompanyExceededDay.BOSFieldGroup = null;
            this.fld_txtCSCompanyExceededDay.BOSFieldRelation = null;
            this.fld_txtCSCompanyExceededDay.BOSPrivilege = null;
            this.fld_txtCSCompanyExceededDay.BOSPropertyName = "EditValue";
            this.fld_txtCSCompanyExceededDay.Location = new System.Drawing.Point(133, 199);
            this.fld_txtCSCompanyExceededDay.Name = "fld_txtCSCompanyExceededDay";
            this.fld_txtCSCompanyExceededDay.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtCSCompanyExceededDay.Properties.MaskSettings.Set("mask", "n0");
            this.fld_txtCSCompanyExceededDay.Screen = null;
            this.fld_txtCSCompanyExceededDay.Size = new System.Drawing.Size(150, 20);
            this.fld_txtCSCompanyExceededDay.TabIndex = 696;
            this.fld_txtCSCompanyExceededDay.Tag = "DC";
            // 
            // fld_grpGroupControl1
            // 
            this.fld_grpGroupControl1.BOSComment = null;
            this.fld_grpGroupControl1.BOSDataMember = null;
            this.fld_grpGroupControl1.BOSDataSource = null;
            this.fld_grpGroupControl1.BOSDescription = null;
            this.fld_grpGroupControl1.BOSError = null;
            this.fld_grpGroupControl1.BOSFieldGroup = null;
            this.fld_grpGroupControl1.BOSFieldRelation = null;
            this.fld_grpGroupControl1.BOSPrivilege = null;
            this.fld_grpGroupControl1.BOSPropertyName = null;
            this.fld_grpGroupControl1.Controls.Add(this.bosLabel7);
            this.fld_grpGroupControl1.Controls.Add(this.bosTextBox2);
            this.fld_grpGroupControl1.Controls.Add(this.bosTextBox1);
            this.fld_grpGroupControl1.Controls.Add(this.bosLabel6);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyExceededDay);
            this.fld_grpGroupControl1.Controls.Add(this.bosLabel89);
            this.fld_grpGroupControl1.Controls.Add(this.bosLabel5);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressLine3);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyTaxNumber);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel13);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel11);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyFax);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyDesc);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.fld_grpGroupControl1.Controls.Add(this.fld_Lablel1);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressPostalCode);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressCity);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressStateProvince);
            this.fld_grpGroupControl1.Controls.Add(this.fld_Lablel2);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressLine1);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyAddressCountry);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyEmail);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyWebsite);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel12);
            this.fld_grpGroupControl1.Controls.Add(this.fld_txtCSCompanyPhone);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel9);
            this.fld_grpGroupControl1.Controls.Add(this.fld_lblLabel10);
            this.fld_grpGroupControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl1.Location = new System.Drawing.Point(8, 8);
            this.fld_grpGroupControl1.Name = "fld_grpGroupControl1";
            this.fld_grpGroupControl1.Screen = null;
            this.fld_grpGroupControl1.Size = new System.Drawing.Size(810, 228);
            this.fld_grpGroupControl1.TabIndex = 0;
            this.fld_grpGroupControl1.TabStop = false;
            this.fld_grpGroupControl1.Text = "Thông tin công ty";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "CSCompanyDesc1";
            this.bosTextBox1.BOSDataSource = "CSCompanys";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(133, 43);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(410, 20);
            this.bosTextBox1.TabIndex = 702;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(15, 46);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(113, 13);
            this.bosLabel6.TabIndex = 703;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tên công ty (tiếng anh)";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(15, 98);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(88, 13);
            this.bosLabel7.TabIndex = 705;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Địa chỉ (tiếng anh)";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "CSCompanyAddressStreet1";
            this.bosTextBox2.BOSDataSource = "CSCompanys";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(133, 95);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(410, 20);
            this.bosTextBox2.TabIndex = 704;
            this.bosTextBox2.Tag = "DC";
            // 
            // DMCS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(871, 790);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS100.IconOptions.Icon")));
            this.Name = "DMCS100";
            this.Text = "Cấu hình công ty";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCSCashFunds)).EndInit();
            this.fld_Line1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCSCompanyBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_grpGroupControl3.ResumeLayout(false);
            this.fld_grpGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GESaleCurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPurchaseCurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanySaleExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyPurchaseExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressLine1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyAddressLine3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCSCompanyExceededDay.Properties)).EndInit();
            this.fld_grpGroupControl1.ResumeLayout(false);
            this.fld_grpGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine fld_grpGroupControl3;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GESaleCurrencyID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPurchaseCurrencyID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtCSCompanySaleExchangeRate;
        private BOSComponent.BOSTextBox fld_txtCSCompanyPurchaseExchangeRate;
        private BOSComponent.BOSLine fld_Line1;
        private CSCompanyBankGridControl fld_dgcCSCompanyBanks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLine bosLine1;
        private CSCashFundGridControl fld_dgcCSCashFunds;
        private BOSComponent.BOSLine fld_grpGroupControl1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtCSCompanyExceededDay;
        private BOSComponent.BOSLabel bosLabel89;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressLine3;
        private BOSComponent.BOSTextBox fld_txtCSCompanyTaxNumber;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSTextBox fld_txtCSCompanyFax;
        private BOSComponent.BOSTextBox fld_txtCSCompanyDesc;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressPostalCode;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressCity;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressStateProvince;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressLine1;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtCSCompanyAddressCountry;
        private BOSComponent.BOSTextBox fld_txtCSCompanyEmail;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtCSCompanyWebsite;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox fld_txtCSCompanyPhone;
        private BOSComponent.BOSLabel fld_lblLabel9;
        private BOSComponent.BOSLabel fld_lblLabel10;
    }
}
