using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AliasConfig.UI
{
	/// <summary>
    /// Summary description for DMALS100
	/// </summary>
    partial class DMALS100
	{
        private AAColumnAliasGridControl fld_dgcAAColumnAlias;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMALS100));
            this.fld_dgcAAColumnAlias = new BOSERP.Modules.AliasConfig.AAColumnAliasGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveAliasConfigs = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtTableName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_txtModuleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnSaveFieldFormat = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSTFieldFormatsGridControls = new BOSERP.Modules.AliasConfig.STFieldFormatsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnFormatSearch = new DevExpress.XtraEditors.SimpleButton();
            this.fld_txtTableFormatName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtbCurrency = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveCurrency = new BOSComponent.BOSButton(this.components);
            this.fld_dgcGECurrenciesGridControl = new BOSERP.Modules.AliasConfig.CurrencysGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtbDepartmentFormat = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveICDepartmentFormats = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICDepartmentFormatsGridControl = new BOSERP.Modules.AliasConfig.DepartmentFormatGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAAColumnAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTableName.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtModuleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTFieldFormatsGridControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTableFormatName.Properties)).BeginInit();
            this.xtbCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGECurrenciesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtbDepartmentFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartmentFormatsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAAColumnAlias
            // 
            this.fld_dgcAAColumnAlias.AllowDrop = true;
            this.fld_dgcAAColumnAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAAColumnAlias.BOSComment = "";
            this.fld_dgcAAColumnAlias.BOSDataMember = "";
            this.fld_dgcAAColumnAlias.BOSDataSource = "AAColumnAlias";
            this.fld_dgcAAColumnAlias.BOSDescription = null;
            this.fld_dgcAAColumnAlias.BOSError = null;
            this.fld_dgcAAColumnAlias.BOSFieldGroup = "";
            this.fld_dgcAAColumnAlias.BOSFieldRelation = "";
            this.fld_dgcAAColumnAlias.BOSGridType = null;
            this.fld_dgcAAColumnAlias.BOSPrivilege = "";
            this.fld_dgcAAColumnAlias.BOSPropertyName = "";
            this.fld_dgcAAColumnAlias.CommodityType = "";
            this.fld_dgcAAColumnAlias.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAAColumnAlias.Location = new System.Drawing.Point(7, 46);
            this.fld_dgcAAColumnAlias.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcAAColumnAlias.Name = "fld_dgcAAColumnAlias";
            this.fld_dgcAAColumnAlias.PrintReport = false;
            this.fld_dgcAAColumnAlias.Screen = null;
            this.fld_dgcAAColumnAlias.Size = new System.Drawing.Size(911, 534);
            this.fld_dgcAAColumnAlias.TabIndex = 4;
            this.fld_dgcAAColumnAlias.Tag = "DC";
            this.fld_dgcAAColumnAlias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcAAColumnAlias;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.xtraTabControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(970, 624);
            this.bosPanel1.TabIndex = 6;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(970, 624);
            this.xtraTabControl2.TabIndex = 30;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtbCurrency,
            this.xtbDepartmentFormat});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_btnSaveAliasConfigs);
            this.xtraTabPage3.Controls.Add(this.bosLabel1);
            this.xtraTabPage3.Controls.Add(this.fld_txtTableName);
            this.xtraTabPage3.Controls.Add(this.fld_dgcAAColumnAlias);
            this.xtraTabPage3.Controls.Add(this.fld_btnSearch);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(968, 599);
            this.xtraTabPage3.Text = "Cấu hình cột cho lưới";
            // 
            // fld_btnSaveAliasConfigs
            // 
            this.fld_btnSaveAliasConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveAliasConfigs.BOSComment = null;
            this.fld_btnSaveAliasConfigs.BOSDataMember = null;
            this.fld_btnSaveAliasConfigs.BOSDataSource = null;
            this.fld_btnSaveAliasConfigs.BOSDescription = null;
            this.fld_btnSaveAliasConfigs.BOSError = null;
            this.fld_btnSaveAliasConfigs.BOSFieldGroup = null;
            this.fld_btnSaveAliasConfigs.BOSFieldRelation = null;
            this.fld_btnSaveAliasConfigs.BOSPrivilege = null;
            this.fld_btnSaveAliasConfigs.BOSPropertyName = null;
            this.fld_btnSaveAliasConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveAliasConfigs.Location = new System.Drawing.Point(924, 46);
            this.fld_btnSaveAliasConfigs.Name = "fld_btnSaveAliasConfigs";
            this.fld_btnSaveAliasConfigs.Screen = null;
            this.fld_btnSaveAliasConfigs.Size = new System.Drawing.Size(34, 34);
            this.fld_btnSaveAliasConfigs.TabIndex = 30;
            this.fld_btnSaveAliasConfigs.Text = "bosButton1";
            this.fld_btnSaveAliasConfigs.Click += new System.EventHandler(this.fld_btnSaveAliasConfigs_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(12, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(45, 13);
            this.bosLabel1.TabIndex = 27;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên bảng";
            // 
            // fld_txtTableName
            // 
            this.fld_txtTableName.BOSComment = null;
            this.fld_txtTableName.BOSDataMember = "";
            this.fld_txtTableName.BOSDataSource = "";
            this.fld_txtTableName.BOSDescription = null;
            this.fld_txtTableName.BOSError = null;
            this.fld_txtTableName.BOSFieldGroup = null;
            this.fld_txtTableName.BOSFieldRelation = null;
            this.fld_txtTableName.BOSPrivilege = null;
            this.fld_txtTableName.BOSPropertyName = "Text";
            this.fld_txtTableName.Location = new System.Drawing.Point(69, 11);
            this.fld_txtTableName.MenuManager = this.screenToolbar;
            this.fld_txtTableName.Name = "fld_txtTableName";
            this.fld_txtTableName.Screen = null;
            this.fld_txtTableName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtTableName.TabIndex = 28;
            this.fld_txtTableName.Tag = "DC";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(258, 10);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(96, 23);
            this.fld_btnSearch.TabIndex = 29;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_txtModuleName);
            this.xtraTabPage4.Controls.Add(this.labelControl2);
            this.xtraTabPage4.Controls.Add(this.fld_btnSaveFieldFormat);
            this.xtraTabPage4.Controls.Add(this.fld_dgcSTFieldFormatsGridControls);
            this.xtraTabPage4.Controls.Add(this.fld_btnFormatSearch);
            this.xtraTabPage4.Controls.Add(this.fld_txtTableFormatName);
            this.xtraTabPage4.Controls.Add(this.labelControl1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(954, 592);
            this.xtraTabPage4.Text = "Cấu hình định dạng hiển thị";
            // 
            // fld_txtModuleName
            // 
            this.fld_txtModuleName.Location = new System.Drawing.Point(331, 11);
            this.fld_txtModuleName.MenuManager = this.screenToolbar;
            this.fld_txtModuleName.Name = "fld_txtModuleName";
            this.fld_txtModuleName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtModuleName.TabIndex = 34;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(274, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Module";
            // 
            // fld_btnSaveFieldFormat
            // 
            this.fld_btnSaveFieldFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveFieldFormat.BOSComment = null;
            this.fld_btnSaveFieldFormat.BOSDataMember = null;
            this.fld_btnSaveFieldFormat.BOSDataSource = null;
            this.fld_btnSaveFieldFormat.BOSDescription = null;
            this.fld_btnSaveFieldFormat.BOSError = null;
            this.fld_btnSaveFieldFormat.BOSFieldGroup = null;
            this.fld_btnSaveFieldFormat.BOSFieldRelation = null;
            this.fld_btnSaveFieldFormat.BOSPrivilege = null;
            this.fld_btnSaveFieldFormat.BOSPropertyName = null;
            this.fld_btnSaveFieldFormat.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveFieldFormat.Location = new System.Drawing.Point(910, 46);
            this.fld_btnSaveFieldFormat.Name = "fld_btnSaveFieldFormat";
            this.fld_btnSaveFieldFormat.Screen = null;
            this.fld_btnSaveFieldFormat.Size = new System.Drawing.Size(34, 34);
            this.fld_btnSaveFieldFormat.TabIndex = 32;
            this.fld_btnSaveFieldFormat.Text = "bosButton1";
            this.fld_btnSaveFieldFormat.Click += new System.EventHandler(this.fld_btnSaveFieldFormat_Click);
            // 
            // fld_dgcSTFieldFormatsGridControls
            // 
            this.fld_dgcSTFieldFormatsGridControls.AllowDrop = true;
            this.fld_dgcSTFieldFormatsGridControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSTFieldFormatsGridControls.BOSComment = "";
            this.fld_dgcSTFieldFormatsGridControls.BOSDataMember = "";
            this.fld_dgcSTFieldFormatsGridControls.BOSDataSource = "STFieldFormats";
            this.fld_dgcSTFieldFormatsGridControls.BOSDescription = null;
            this.fld_dgcSTFieldFormatsGridControls.BOSError = null;
            this.fld_dgcSTFieldFormatsGridControls.BOSFieldGroup = "";
            this.fld_dgcSTFieldFormatsGridControls.BOSFieldRelation = "";
            this.fld_dgcSTFieldFormatsGridControls.BOSGridType = null;
            this.fld_dgcSTFieldFormatsGridControls.BOSPrivilege = "";
            this.fld_dgcSTFieldFormatsGridControls.BOSPropertyName = "";
            this.fld_dgcSTFieldFormatsGridControls.CommodityType = "";
            this.fld_dgcSTFieldFormatsGridControls.CurrentTableFilter = null;
            this.fld_dgcSTFieldFormatsGridControls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSTFieldFormatsGridControls.Location = new System.Drawing.Point(7, 46);
            this.fld_dgcSTFieldFormatsGridControls.MainView = this.gridView1;
            this.fld_dgcSTFieldFormatsGridControls.Name = "fld_dgcSTFieldFormatsGridControls";
            this.fld_dgcSTFieldFormatsGridControls.PrintReport = false;
            this.fld_dgcSTFieldFormatsGridControls.Screen = null;
            this.fld_dgcSTFieldFormatsGridControls.Size = new System.Drawing.Size(897, 527);
            this.fld_dgcSTFieldFormatsGridControls.TabIndex = 31;
            this.fld_dgcSTFieldFormatsGridControls.Tag = "DC";
            this.fld_dgcSTFieldFormatsGridControls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcSTFieldFormatsGridControls;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_btnFormatSearch
            // 
            this.fld_btnFormatSearch.Location = new System.Drawing.Point(530, 9);
            this.fld_btnFormatSearch.Name = "fld_btnFormatSearch";
            this.fld_btnFormatSearch.Size = new System.Drawing.Size(96, 23);
            this.fld_btnFormatSearch.TabIndex = 2;
            this.fld_btnFormatSearch.Text = "Tìm kiếm";
            this.fld_btnFormatSearch.Click += new System.EventHandler(this.fld_btnFormatSearch_Click);
            // 
            // fld_txtTableFormatName
            // 
            this.fld_txtTableFormatName.Location = new System.Drawing.Point(69, 11);
            this.fld_txtTableFormatName.MenuManager = this.screenToolbar;
            this.fld_txtTableFormatName.Name = "fld_txtTableFormatName";
            this.fld_txtTableFormatName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtTableFormatName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên bảng";
            // 
            // xtbCurrency
            // 
            this.xtbCurrency.Controls.Add(this.fld_btnSaveCurrency);
            this.xtbCurrency.Controls.Add(this.fld_dgcGECurrenciesGridControl);
            this.xtbCurrency.Name = "xtbCurrency";
            this.xtbCurrency.Size = new System.Drawing.Size(954, 592);
            this.xtbCurrency.Text = "Cấu hình định dạng theo tiền tệ";
            // 
            // fld_btnSaveCurrency
            // 
            this.fld_btnSaveCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveCurrency.BOSComment = null;
            this.fld_btnSaveCurrency.BOSDataMember = null;
            this.fld_btnSaveCurrency.BOSDataSource = null;
            this.fld_btnSaveCurrency.BOSDescription = null;
            this.fld_btnSaveCurrency.BOSError = null;
            this.fld_btnSaveCurrency.BOSFieldGroup = null;
            this.fld_btnSaveCurrency.BOSFieldRelation = null;
            this.fld_btnSaveCurrency.BOSPrivilege = null;
            this.fld_btnSaveCurrency.BOSPropertyName = null;
            this.fld_btnSaveCurrency.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveCurrency.Location = new System.Drawing.Point(909, 3);
            this.fld_btnSaveCurrency.Name = "fld_btnSaveCurrency";
            this.fld_btnSaveCurrency.Screen = null;
            this.fld_btnSaveCurrency.Size = new System.Drawing.Size(34, 34);
            this.fld_btnSaveCurrency.TabIndex = 33;
            this.fld_btnSaveCurrency.Text = "bosButton1";
            this.fld_btnSaveCurrency.Click += new System.EventHandler(this.fld_btnSaveCurrency_Click);
            // 
            // fld_dgcGECurrenciesGridControl
            // 
            this.fld_dgcGECurrenciesGridControl.AllowDrop = true;
            this.fld_dgcGECurrenciesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcGECurrenciesGridControl.BOSComment = "";
            this.fld_dgcGECurrenciesGridControl.BOSDataMember = "";
            this.fld_dgcGECurrenciesGridControl.BOSDataSource = "GECurrencies";
            this.fld_dgcGECurrenciesGridControl.BOSDescription = null;
            this.fld_dgcGECurrenciesGridControl.BOSError = null;
            this.fld_dgcGECurrenciesGridControl.BOSFieldGroup = "";
            this.fld_dgcGECurrenciesGridControl.BOSFieldRelation = "";
            this.fld_dgcGECurrenciesGridControl.BOSGridType = null;
            this.fld_dgcGECurrenciesGridControl.BOSPrivilege = "";
            this.fld_dgcGECurrenciesGridControl.BOSPropertyName = "";
            this.fld_dgcGECurrenciesGridControl.CommodityType = "";
            this.fld_dgcGECurrenciesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcGECurrenciesGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcGECurrenciesGridControl.MainView = this.gridView2;
            this.fld_dgcGECurrenciesGridControl.Name = "fld_dgcGECurrenciesGridControl";
            this.fld_dgcGECurrenciesGridControl.PrintReport = false;
            this.fld_dgcGECurrenciesGridControl.Screen = null;
            this.fld_dgcGECurrenciesGridControl.Size = new System.Drawing.Size(900, 589);
            this.fld_dgcGECurrenciesGridControl.TabIndex = 32;
            this.fld_dgcGECurrenciesGridControl.Tag = "DC";
            this.fld_dgcGECurrenciesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcGECurrenciesGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtbDepartmentFormat
            // 
            this.xtbDepartmentFormat.Controls.Add(this.fld_btnSaveICDepartmentFormats);
            this.xtbDepartmentFormat.Controls.Add(this.fld_dgcICDepartmentFormatsGridControl);
            this.xtbDepartmentFormat.Name = "xtbDepartmentFormat";
            this.xtbDepartmentFormat.Size = new System.Drawing.Size(968, 599);
            this.xtbDepartmentFormat.Text = "Cấu hình định dạng theo loại hàng hóa";
            // 
            // fld_btnSaveICDepartmentFormats
            // 
            this.fld_btnSaveICDepartmentFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveICDepartmentFormats.BOSComment = null;
            this.fld_btnSaveICDepartmentFormats.BOSDataMember = null;
            this.fld_btnSaveICDepartmentFormats.BOSDataSource = null;
            this.fld_btnSaveICDepartmentFormats.BOSDescription = null;
            this.fld_btnSaveICDepartmentFormats.BOSError = null;
            this.fld_btnSaveICDepartmentFormats.BOSFieldGroup = null;
            this.fld_btnSaveICDepartmentFormats.BOSFieldRelation = null;
            this.fld_btnSaveICDepartmentFormats.BOSPrivilege = null;
            this.fld_btnSaveICDepartmentFormats.BOSPropertyName = null;
            this.fld_btnSaveICDepartmentFormats.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveICDepartmentFormats.Location = new System.Drawing.Point(927, 2);
            this.fld_btnSaveICDepartmentFormats.Name = "fld_btnSaveICDepartmentFormats";
            this.fld_btnSaveICDepartmentFormats.Screen = null;
            this.fld_btnSaveICDepartmentFormats.Size = new System.Drawing.Size(34, 34);
            this.fld_btnSaveICDepartmentFormats.TabIndex = 35;
            this.fld_btnSaveICDepartmentFormats.Text = "bosButton1";
            this.fld_btnSaveICDepartmentFormats.Click += new System.EventHandler(this.fld_btnSaveICDepartmentFormats_Click);
            // 
            // fld_dgcICDepartmentFormatsGridControl
            // 
            this.fld_dgcICDepartmentFormatsGridControl.AllowDrop = true;
            this.fld_dgcICDepartmentFormatsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICDepartmentFormatsGridControl.BOSComment = "";
            this.fld_dgcICDepartmentFormatsGridControl.BOSDataMember = "";
            this.fld_dgcICDepartmentFormatsGridControl.BOSDataSource = "ICDepartmentFormats";
            this.fld_dgcICDepartmentFormatsGridControl.BOSDescription = null;
            this.fld_dgcICDepartmentFormatsGridControl.BOSError = null;
            this.fld_dgcICDepartmentFormatsGridControl.BOSFieldGroup = "";
            this.fld_dgcICDepartmentFormatsGridControl.BOSFieldRelation = "";
            this.fld_dgcICDepartmentFormatsGridControl.BOSGridType = null;
            this.fld_dgcICDepartmentFormatsGridControl.BOSPrivilege = "";
            this.fld_dgcICDepartmentFormatsGridControl.BOSPropertyName = "";
            this.fld_dgcICDepartmentFormatsGridControl.CommodityType = "";
            this.fld_dgcICDepartmentFormatsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICDepartmentFormatsGridControl.Location = new System.Drawing.Point(7, 2);
            this.fld_dgcICDepartmentFormatsGridControl.MainView = this.gridView3;
            this.fld_dgcICDepartmentFormatsGridControl.Name = "fld_dgcICDepartmentFormatsGridControl";
            this.fld_dgcICDepartmentFormatsGridControl.PrintReport = false;
            this.fld_dgcICDepartmentFormatsGridControl.Screen = null;
            this.fld_dgcICDepartmentFormatsGridControl.Size = new System.Drawing.Size(914, 596);
            this.fld_dgcICDepartmentFormatsGridControl.TabIndex = 34;
            this.fld_dgcICDepartmentFormatsGridControl.Tag = "DC";
            this.fld_dgcICDepartmentFormatsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcICDepartmentFormatsGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // DMALS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(970, 624);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMALS100.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "DMALS100";
            this.Text = "Cấu hình hiển thị lưới";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAAColumnAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTableName.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtModuleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTFieldFormatsGridControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTableFormatName.Properties)).EndInit();
            this.xtbCurrency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGECurrenciesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtbDepartmentFormat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartmentFormatsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox fld_txtTableName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnSearch;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSButton fld_btnSaveAliasConfigs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton fld_btnFormatSearch;
        private DevExpress.XtraEditors.TextEdit fld_txtTableFormatName;
        private BOSComponent.BOSButton fld_btnSaveFieldFormat;
        private STFieldFormatsGridControl fld_dgcSTFieldFormatsGridControls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit fld_txtModuleName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtbCurrency;
        private CurrencysGridControl fld_dgcGECurrenciesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnSaveCurrency;
        private DevExpress.XtraTab.XtraTabPage xtbDepartmentFormat;
        private BOSComponent.BOSButton fld_btnSaveICDepartmentFormats;
        private DepartmentFormatGridControl fld_dgcICDepartmentFormatsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}
