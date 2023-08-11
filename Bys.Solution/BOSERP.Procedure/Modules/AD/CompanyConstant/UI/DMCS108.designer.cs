using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS101
	/// </summary>
	partial class DMCS108
	{
        private ARCustomerTypeAccountConfigsGridControl fld_dgcARCustomerTypeAccountConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvCustomerType;


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
            this.fld_dgcARCustomerTypeAccountConfigs = new BOSERP.Modules.CompanyConstant.ARCustomerTypeAccountConfigsGridControl();
            this.fld_dgvCustomerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grpGroupControl5 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveCustomerAccountConfig = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveACLoanReceiptTypes = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACLoanReceiptTypes = new BOSERP.Modules.CompanyConstant.ACLoanReceiptTypesGridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveProductAccountConfig = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductTypeAccountConfigs = new BOSERP.Modules.CompanyConstant.ICProductTypeAccountConfigsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnSaveSupplierAccountConfig = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPSupplierTypeAccountConfigs = new BOSERP.Modules.CompanyConstant.APSupplierTypeAccountConfigsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabBankAndCash = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAssetTypeDepreciationConfigsGridControl = new BOSERP.Modules.CompanyConstant.ACAssetTypeDepreciationConfigsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_btnACAssetTypeAccountConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACAssetTypeAccountConfigs = new BOSERP.Modules.CompanyConstant.ACAssetTypeAccountConfigsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACEquipmentStates = new BOSERP.Modules.CompanyConstant.ACEquipmentStatesGridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_btnACEquipmentTypeAccountConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcACEquipmentTypeAccountConfigs = new BOSERP.Modules.CompanyConstant.ACEquipmentTypeAccountConfigsGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerTypeAccountConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).BeginInit();
            this.fld_grpGroupControl5.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTypeAccountConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierTypeAccountConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabBankAndCash.SuspendLayout();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetTypeDepreciationConfigsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAssetTypeAccountConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEquipmentStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEquipmentTypeAccountConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcARCustomerTypeAccountConfigs
            // 
            this.fld_dgcARCustomerTypeAccountConfigs.AllowDrop = true;
            this.fld_dgcARCustomerTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARCustomerTypeAccountConfigs.BOSComment = "";
            this.fld_dgcARCustomerTypeAccountConfigs.BOSDataMember = null;
            this.fld_dgcARCustomerTypeAccountConfigs.BOSDataSource = "ARCustomerTypeAccountConfigs";
            this.fld_dgcARCustomerTypeAccountConfigs.BOSDescription = null;
            this.fld_dgcARCustomerTypeAccountConfigs.BOSError = "";
            this.fld_dgcARCustomerTypeAccountConfigs.BOSFieldGroup = "";
            this.fld_dgcARCustomerTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_dgcARCustomerTypeAccountConfigs.BOSGridType = null;
            this.fld_dgcARCustomerTypeAccountConfigs.BOSPrivilege = "";
            this.fld_dgcARCustomerTypeAccountConfigs.BOSPropertyName = null;
            this.fld_dgcARCustomerTypeAccountConfigs.CommodityType = "";
            this.fld_dgcARCustomerTypeAccountConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCustomerTypeAccountConfigs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcARCustomerTypeAccountConfigs.MainView = this.fld_dgvCustomerType;
            this.fld_dgcARCustomerTypeAccountConfigs.Name = "fld_dgcARCustomerTypeAccountConfigs";
            this.fld_dgcARCustomerTypeAccountConfigs.PrintReport = false;
            this.fld_dgcARCustomerTypeAccountConfigs.Screen = null;
            this.fld_dgcARCustomerTypeAccountConfigs.Size = new System.Drawing.Size(789, 164);
            this.fld_dgcARCustomerTypeAccountConfigs.TabIndex = 4;
            this.fld_dgcARCustomerTypeAccountConfigs.Tag = "DC";
            this.fld_dgcARCustomerTypeAccountConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvCustomerType});
            // 
            // fld_dgvCustomerType
            // 
            this.fld_dgvCustomerType.GridControl = this.fld_dgcARCustomerTypeAccountConfigs;
            this.fld_dgvCustomerType.Name = "fld_dgvCustomerType";
            this.fld_dgvCustomerType.PaintStyleName = "Office2003";
            // 
            // fld_grpGroupControl5
            // 
            this.fld_grpGroupControl5.BOSComment = null;
            this.fld_grpGroupControl5.BOSDataMember = null;
            this.fld_grpGroupControl5.BOSDataSource = null;
            this.fld_grpGroupControl5.BOSDescription = null;
            this.fld_grpGroupControl5.BOSError = null;
            this.fld_grpGroupControl5.BOSFieldGroup = null;
            this.fld_grpGroupControl5.BOSFieldRelation = null;
            this.fld_grpGroupControl5.BOSPrivilege = null;
            this.fld_grpGroupControl5.BOSPropertyName = null;
            this.fld_grpGroupControl5.Controls.Add(this.fld_btnSaveCustomerAccountConfig);
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcARCustomerTypeAccountConfigs);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(842, 190);
            this.fld_grpGroupControl5.TabIndex = 6;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Khách hàng";
            // 
            // fld_btnSaveCustomerAccountConfig
            // 
            this.fld_btnSaveCustomerAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveCustomerAccountConfig.BOSComment = null;
            this.fld_btnSaveCustomerAccountConfig.BOSDataMember = null;
            this.fld_btnSaveCustomerAccountConfig.BOSDataSource = null;
            this.fld_btnSaveCustomerAccountConfig.BOSDescription = null;
            this.fld_btnSaveCustomerAccountConfig.BOSError = null;
            this.fld_btnSaveCustomerAccountConfig.BOSFieldGroup = null;
            this.fld_btnSaveCustomerAccountConfig.BOSFieldRelation = null;
            this.fld_btnSaveCustomerAccountConfig.BOSPrivilege = null;
            this.fld_btnSaveCustomerAccountConfig.BOSPropertyName = null;
            this.fld_btnSaveCustomerAccountConfig.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveCustomerAccountConfig.Location = new System.Drawing.Point(801, 20);
            this.fld_btnSaveCustomerAccountConfig.Name = "fld_btnSaveCustomerAccountConfig";
            this.fld_btnSaveCustomerAccountConfig.Screen = null;
            this.fld_btnSaveCustomerAccountConfig.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveCustomerAccountConfig.TabIndex = 7;
            this.fld_btnSaveCustomerAccountConfig.Text = "bosButton1";
            this.fld_btnSaveCustomerAccountConfig.Click += new System.EventHandler(this.fld_btnSaveCustomerAccountConfig_Click);
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
            this.bosPanel1.Controls.Add(this.fld_tabCompany);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(883, 823);
            this.bosPanel1.TabIndex = 7;
            // 
            // fld_tabCompany
            // 
            this.fld_tabCompany.BOSComment = null;
            this.fld_tabCompany.BOSDataMember = null;
            this.fld_tabCompany.BOSDataSource = null;
            this.fld_tabCompany.BOSDescription = null;
            this.fld_tabCompany.BOSError = null;
            this.fld_tabCompany.BOSFieldGroup = null;
            this.fld_tabCompany.BOSFieldRelation = null;
            this.fld_tabCompany.BOSPrivilege = null;
            this.fld_tabCompany.BOSPropertyName = null;
            this.fld_tabCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabCompany.Location = new System.Drawing.Point(0, 0);
            this.fld_tabCompany.Name = "fld_tabCompany";
            this.fld_tabCompany.Screen = null;
            this.fld_tabCompany.SelectedTabPage = this.fld_tabInfomation;
            this.ScreenHelper.SetShowHelp(this.fld_tabCompany, true);
            this.fld_tabCompany.Size = new System.Drawing.Size(883, 823);
            this.fld_tabCompany.TabIndex = 63;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabInfomation,
            this.fld_tabBankAndCash,
            this.xtraTabPage1});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.AutoScroll = true;
            this.fld_tabInfomation.Controls.Add(this.bosLine6);
            this.fld_tabInfomation.Controls.Add(this.fld_grpGroupControl5);
            this.fld_tabInfomation.Controls.Add(this.bosLine2);
            this.fld_tabInfomation.Controls.Add(this.bosLine1);
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(877, 795);
            this.fld_tabInfomation.Text = "Tài khoản đối tượng";
            // 
            // bosLine6
            // 
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_btnSaveACLoanReceiptTypes);
            this.bosLine6.Controls.Add(this.fld_dgcACLoanReceiptTypes);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(3, 601);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(842, 190);
            this.bosLine6.TabIndex = 9;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Loại khế ước vay";
            // 
            // fld_btnSaveACLoanReceiptTypes
            // 
            this.fld_btnSaveACLoanReceiptTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveACLoanReceiptTypes.BOSComment = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSDataMember = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSDataSource = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSDescription = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSError = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSFieldGroup = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSFieldRelation = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSPrivilege = null;
            this.fld_btnSaveACLoanReceiptTypes.BOSPropertyName = null;
            this.fld_btnSaveACLoanReceiptTypes.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveACLoanReceiptTypes.Location = new System.Drawing.Point(801, 20);
            this.fld_btnSaveACLoanReceiptTypes.Name = "fld_btnSaveACLoanReceiptTypes";
            this.fld_btnSaveACLoanReceiptTypes.Screen = null;
            this.fld_btnSaveACLoanReceiptTypes.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveACLoanReceiptTypes.TabIndex = 7;
            this.fld_btnSaveACLoanReceiptTypes.Text = "bosButton1";
            this.fld_btnSaveACLoanReceiptTypes.Click += new System.EventHandler(this.fld_btnSaveACLoanReceiptTypes_Click);
            // 
            // fld_dgcACLoanReceiptTypes
            // 
            this.fld_dgcACLoanReceiptTypes.AllowDrop = true;
            this.fld_dgcACLoanReceiptTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACLoanReceiptTypes.BOSComment = "";
            this.fld_dgcACLoanReceiptTypes.BOSDataMember = null;
            this.fld_dgcACLoanReceiptTypes.BOSDataSource = "ACLoanReceiptTypes";
            this.fld_dgcACLoanReceiptTypes.BOSDescription = null;
            this.fld_dgcACLoanReceiptTypes.BOSError = "";
            this.fld_dgcACLoanReceiptTypes.BOSFieldGroup = "";
            this.fld_dgcACLoanReceiptTypes.BOSFieldRelation = null;
            this.fld_dgcACLoanReceiptTypes.BOSGridType = null;
            this.fld_dgcACLoanReceiptTypes.BOSPrivilege = "";
            this.fld_dgcACLoanReceiptTypes.BOSPropertyName = null;
            this.fld_dgcACLoanReceiptTypes.CommodityType = "";
            this.fld_dgcACLoanReceiptTypes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACLoanReceiptTypes.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcACLoanReceiptTypes.MainView = this.gridView6;
            this.fld_dgcACLoanReceiptTypes.Name = "fld_dgcACLoanReceiptTypes";
            this.fld_dgcACLoanReceiptTypes.PrintReport = false;
            this.fld_dgcACLoanReceiptTypes.Screen = null;
            this.fld_dgcACLoanReceiptTypes.Size = new System.Drawing.Size(789, 164);
            this.fld_dgcACLoanReceiptTypes.TabIndex = 4;
            this.fld_dgcACLoanReceiptTypes.Tag = "DC";
            this.fld_dgcACLoanReceiptTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.fld_dgcACLoanReceiptTypes;
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_btnSaveProductAccountConfig);
            this.bosLine2.Controls.Add(this.fld_dgcICProductTypeAccountConfigs);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 395);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(842, 200);
            this.bosLine2.TabIndex = 8;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Sản phẩm";
            // 
            // fld_btnSaveProductAccountConfig
            // 
            this.fld_btnSaveProductAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveProductAccountConfig.BOSComment = null;
            this.fld_btnSaveProductAccountConfig.BOSDataMember = null;
            this.fld_btnSaveProductAccountConfig.BOSDataSource = null;
            this.fld_btnSaveProductAccountConfig.BOSDescription = null;
            this.fld_btnSaveProductAccountConfig.BOSError = null;
            this.fld_btnSaveProductAccountConfig.BOSFieldGroup = null;
            this.fld_btnSaveProductAccountConfig.BOSFieldRelation = null;
            this.fld_btnSaveProductAccountConfig.BOSPrivilege = null;
            this.fld_btnSaveProductAccountConfig.BOSPropertyName = null;
            this.fld_btnSaveProductAccountConfig.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveProductAccountConfig.Location = new System.Drawing.Point(801, 20);
            this.fld_btnSaveProductAccountConfig.Name = "fld_btnSaveProductAccountConfig";
            this.fld_btnSaveProductAccountConfig.Screen = null;
            this.fld_btnSaveProductAccountConfig.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveProductAccountConfig.TabIndex = 7;
            this.fld_btnSaveProductAccountConfig.Text = "bosButton1";
            this.fld_btnSaveProductAccountConfig.Click += new System.EventHandler(this.fld_btnSaveProductAccountConfig_Click);
            // 
            // fld_dgcICProductTypeAccountConfigs
            // 
            this.fld_dgcICProductTypeAccountConfigs.AllowDrop = true;
            this.fld_dgcICProductTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductTypeAccountConfigs.BOSComment = "";
            this.fld_dgcICProductTypeAccountConfigs.BOSDataMember = null;
            this.fld_dgcICProductTypeAccountConfigs.BOSDataSource = "ICProductTypeAccountConfigs";
            this.fld_dgcICProductTypeAccountConfigs.BOSDescription = null;
            this.fld_dgcICProductTypeAccountConfigs.BOSError = "";
            this.fld_dgcICProductTypeAccountConfigs.BOSFieldGroup = "";
            this.fld_dgcICProductTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_dgcICProductTypeAccountConfigs.BOSGridType = null;
            this.fld_dgcICProductTypeAccountConfigs.BOSPrivilege = "";
            this.fld_dgcICProductTypeAccountConfigs.BOSPropertyName = null;
            this.fld_dgcICProductTypeAccountConfigs.CommodityType = "";
            this.fld_dgcICProductTypeAccountConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductTypeAccountConfigs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICProductTypeAccountConfigs.MainView = this.gridView2;
            this.fld_dgcICProductTypeAccountConfigs.Name = "fld_dgcICProductTypeAccountConfigs";
            this.fld_dgcICProductTypeAccountConfigs.PrintReport = false;
            this.fld_dgcICProductTypeAccountConfigs.Screen = null;
            this.fld_dgcICProductTypeAccountConfigs.Size = new System.Drawing.Size(789, 174);
            this.fld_dgcICProductTypeAccountConfigs.TabIndex = 4;
            this.fld_dgcICProductTypeAccountConfigs.Tag = "DC";
            this.fld_dgcICProductTypeAccountConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcICProductTypeAccountConfigs;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosLine1.Controls.Add(this.fld_btnSaveSupplierAccountConfig);
            this.bosLine1.Controls.Add(this.fld_dgcAPSupplierTypeAccountConfigs);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 199);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(842, 190);
            this.bosLine1.TabIndex = 7;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Nhà cung cấp";
            // 
            // fld_btnSaveSupplierAccountConfig
            // 
            this.fld_btnSaveSupplierAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveSupplierAccountConfig.BOSComment = null;
            this.fld_btnSaveSupplierAccountConfig.BOSDataMember = null;
            this.fld_btnSaveSupplierAccountConfig.BOSDataSource = null;
            this.fld_btnSaveSupplierAccountConfig.BOSDescription = null;
            this.fld_btnSaveSupplierAccountConfig.BOSError = null;
            this.fld_btnSaveSupplierAccountConfig.BOSFieldGroup = null;
            this.fld_btnSaveSupplierAccountConfig.BOSFieldRelation = null;
            this.fld_btnSaveSupplierAccountConfig.BOSPrivilege = null;
            this.fld_btnSaveSupplierAccountConfig.BOSPropertyName = null;
            this.fld_btnSaveSupplierAccountConfig.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveSupplierAccountConfig.Location = new System.Drawing.Point(801, 20);
            this.fld_btnSaveSupplierAccountConfig.Name = "fld_btnSaveSupplierAccountConfig";
            this.fld_btnSaveSupplierAccountConfig.Screen = null;
            this.fld_btnSaveSupplierAccountConfig.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveSupplierAccountConfig.TabIndex = 7;
            this.fld_btnSaveSupplierAccountConfig.Text = "bosButton1";
            this.fld_btnSaveSupplierAccountConfig.Click += new System.EventHandler(this.fld_btnSaveSupplierAccountConfig_Click);
            // 
            // fld_dgcAPSupplierTypeAccountConfigs
            // 
            this.fld_dgcAPSupplierTypeAccountConfigs.AllowDrop = true;
            this.fld_dgcAPSupplierTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSComment = "";
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSDataMember = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSDataSource = "APSupplierTypeAccountConfigs";
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSDescription = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSError = "";
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSFieldGroup = "";
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSGridType = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSPrivilege = "";
            this.fld_dgcAPSupplierTypeAccountConfigs.BOSPropertyName = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.CommodityType = "";
            this.fld_dgcAPSupplierTypeAccountConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPSupplierTypeAccountConfigs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcAPSupplierTypeAccountConfigs.MainView = this.gridView1;
            this.fld_dgcAPSupplierTypeAccountConfigs.Name = "fld_dgcAPSupplierTypeAccountConfigs";
            this.fld_dgcAPSupplierTypeAccountConfigs.PrintReport = false;
            this.fld_dgcAPSupplierTypeAccountConfigs.Screen = null;
            this.fld_dgcAPSupplierTypeAccountConfigs.Size = new System.Drawing.Size(789, 164);
            this.fld_dgcAPSupplierTypeAccountConfigs.TabIndex = 4;
            this.fld_dgcAPSupplierTypeAccountConfigs.Tag = "DC";
            this.fld_dgcAPSupplierTypeAccountConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPSupplierTypeAccountConfigs;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabBankAndCash
            // 
            this.fld_tabBankAndCash.AutoScroll = true;
            this.fld_tabBankAndCash.Controls.Add(this.bosLine4);
            this.fld_tabBankAndCash.Controls.Add(this.bosLine3);
            this.fld_tabBankAndCash.Name = "fld_tabBankAndCash";
            this.fld_tabBankAndCash.Size = new System.Drawing.Size(881, 688);
            this.fld_tabBankAndCash.Text = "Tài sản cố định";
            // 
            // bosLine4
            // 
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.bosButton1);
            this.bosLine4.Controls.Add(this.fld_dgcAssetTypeDepreciationConfigsGridControl);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(3, 236);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(858, 279);
            this.bosLine4.TabIndex = 7;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Thông tin kỳ khấu hao";
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.bosButton1.Location = new System.Drawing.Point(817, 20);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(31, 30);
            this.bosButton1.TabIndex = 7;
            this.bosButton1.Text = "bosButton1";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dgcAssetTypeDepreciationConfigsGridControl
            // 
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.AllowDrop = true;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSComment = "";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSDataMember = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSDataSource = "ACAssetTypeDepreciationConfigs";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSDescription = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSError = "";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSFieldGroup = "";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSGridType = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSPrivilege = "";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.CommodityType = "";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.MainView = this.gridView4;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Name = "fld_dgcAssetTypeDepreciationConfigsGridControl";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.PrintReport = false;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Screen = null;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Size = new System.Drawing.Size(805, 253);
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.TabIndex = 4;
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.Tag = "DC";
            this.fld_dgcAssetTypeDepreciationConfigsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcAssetTypeDepreciationConfigsGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // bosLine3
            // 
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_btnACAssetTypeAccountConfigs);
            this.bosLine3.Controls.Add(this.fld_dgcACAssetTypeAccountConfigs);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(3, 3);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(858, 227);
            this.bosLine3.TabIndex = 7;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Tài khoản tài sản cố định";
            // 
            // fld_btnACAssetTypeAccountConfigs
            // 
            this.fld_btnACAssetTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnACAssetTypeAccountConfigs.BOSComment = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSDataMember = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSDataSource = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSDescription = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSError = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSFieldGroup = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSPrivilege = null;
            this.fld_btnACAssetTypeAccountConfigs.BOSPropertyName = null;
            this.fld_btnACAssetTypeAccountConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnACAssetTypeAccountConfigs.Location = new System.Drawing.Point(817, 20);
            this.fld_btnACAssetTypeAccountConfigs.Name = "fld_btnACAssetTypeAccountConfigs";
            this.fld_btnACAssetTypeAccountConfigs.Screen = null;
            this.fld_btnACAssetTypeAccountConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnACAssetTypeAccountConfigs.TabIndex = 7;
            this.fld_btnACAssetTypeAccountConfigs.Text = "bosButton1";
            this.fld_btnACAssetTypeAccountConfigs.Click += new System.EventHandler(this.fld_btnACAssetTypeAccountConfigs_Click);
            // 
            // fld_dgcACAssetTypeAccountConfigs
            // 
            this.fld_dgcACAssetTypeAccountConfigs.AllowDrop = true;
            this.fld_dgcACAssetTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACAssetTypeAccountConfigs.BOSComment = "";
            this.fld_dgcACAssetTypeAccountConfigs.BOSDataMember = null;
            this.fld_dgcACAssetTypeAccountConfigs.BOSDataSource = "ACAssetTypeAccountConfigs";
            this.fld_dgcACAssetTypeAccountConfigs.BOSDescription = null;
            this.fld_dgcACAssetTypeAccountConfigs.BOSError = "";
            this.fld_dgcACAssetTypeAccountConfigs.BOSFieldGroup = "";
            this.fld_dgcACAssetTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_dgcACAssetTypeAccountConfigs.BOSGridType = null;
            this.fld_dgcACAssetTypeAccountConfigs.BOSPrivilege = "";
            this.fld_dgcACAssetTypeAccountConfigs.BOSPropertyName = null;
            this.fld_dgcACAssetTypeAccountConfigs.CommodityType = "";
            this.fld_dgcACAssetTypeAccountConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACAssetTypeAccountConfigs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcACAssetTypeAccountConfigs.MainView = this.gridView3;
            this.fld_dgcACAssetTypeAccountConfigs.Name = "fld_dgcACAssetTypeAccountConfigs";
            this.fld_dgcACAssetTypeAccountConfigs.PrintReport = false;
            this.fld_dgcACAssetTypeAccountConfigs.Screen = null;
            this.fld_dgcACAssetTypeAccountConfigs.Size = new System.Drawing.Size(805, 201);
            this.fld_dgcACAssetTypeAccountConfigs.TabIndex = 4;
            this.fld_dgcACAssetTypeAccountConfigs.Tag = "DC";
            this.fld_dgcACAssetTypeAccountConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcACAssetTypeAccountConfigs;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.bosLine7);
            this.xtraTabPage1.Controls.Add(this.bosLine5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(881, 688);
            this.xtraTabPage1.Text = "Công cụ dụng cụ";
            // 
            // bosLine7
            // 
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.bosButton2);
            this.bosLine7.Controls.Add(this.fld_dgcACEquipmentStates);
            this.bosLine7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine7.Location = new System.Drawing.Point(7, 426);
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.bosLine7.Size = new System.Drawing.Size(858, 227);
            this.bosLine7.TabIndex = 9;
            this.bosLine7.TabStop = false;
            this.bosLine7.Text = "Tình trạng thu hồi CCDC";
            // 
            // bosButton2
            // 
            this.bosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.bosButton2.Location = new System.Drawing.Point(817, 20);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(31, 30);
            this.bosButton2.TabIndex = 7;
            this.bosButton2.Text = "bosButton1";
            this.bosButton2.Click += new System.EventHandler(this.fld_btnACEquipmentStates_Click);
            // 
            // fld_dgcACEquipmentStates
            // 
            this.fld_dgcACEquipmentStates.AllowDrop = true;
            this.fld_dgcACEquipmentStates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACEquipmentStates.BOSComment = "";
            this.fld_dgcACEquipmentStates.BOSDataMember = null;
            this.fld_dgcACEquipmentStates.BOSDataSource = "ACEquipmentStates";
            this.fld_dgcACEquipmentStates.BOSDescription = null;
            this.fld_dgcACEquipmentStates.BOSError = "";
            this.fld_dgcACEquipmentStates.BOSFieldGroup = "";
            this.fld_dgcACEquipmentStates.BOSFieldRelation = null;
            this.fld_dgcACEquipmentStates.BOSGridType = null;
            this.fld_dgcACEquipmentStates.BOSPrivilege = "";
            this.fld_dgcACEquipmentStates.BOSPropertyName = null;
            this.fld_dgcACEquipmentStates.CommodityType = "";
            this.fld_dgcACEquipmentStates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEquipmentStates.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcACEquipmentStates.MainView = this.gridView7;
            this.fld_dgcACEquipmentStates.Name = "fld_dgcACEquipmentStates";
            this.fld_dgcACEquipmentStates.PrintReport = false;
            this.fld_dgcACEquipmentStates.Screen = null;
            this.fld_dgcACEquipmentStates.Size = new System.Drawing.Size(805, 201);
            this.fld_dgcACEquipmentStates.TabIndex = 4;
            this.fld_dgcACEquipmentStates.Tag = "DC";
            this.fld_dgcACEquipmentStates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.fld_dgcACEquipmentStates;
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.fld_btnACEquipmentTypeAccountConfigs);
            this.bosLine5.Controls.Add(this.fld_dgcACEquipmentTypeAccountConfigs);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(7, 3);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(858, 417);
            this.bosLine5.TabIndex = 8;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Tài khoản công cụ dụng cụ";
            // 
            // fld_btnACEquipmentTypeAccountConfigs
            // 
            this.fld_btnACEquipmentTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnACEquipmentTypeAccountConfigs.BOSComment = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSDataMember = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSDataSource = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSDescription = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSError = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSFieldGroup = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSPrivilege = null;
            this.fld_btnACEquipmentTypeAccountConfigs.BOSPropertyName = null;
            this.fld_btnACEquipmentTypeAccountConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnACEquipmentTypeAccountConfigs.Location = new System.Drawing.Point(817, 20);
            this.fld_btnACEquipmentTypeAccountConfigs.Name = "fld_btnACEquipmentTypeAccountConfigs";
            this.fld_btnACEquipmentTypeAccountConfigs.Screen = null;
            this.fld_btnACEquipmentTypeAccountConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnACEquipmentTypeAccountConfigs.TabIndex = 7;
            this.fld_btnACEquipmentTypeAccountConfigs.Text = "bosButton1";
            this.fld_btnACEquipmentTypeAccountConfigs.Click += new System.EventHandler(this.fld_btnACEquipmentTypeAccountConfigs_Click);
            // 
            // fld_dgcACEquipmentTypeAccountConfigs
            // 
            this.fld_dgcACEquipmentTypeAccountConfigs.AllowDrop = true;
            this.fld_dgcACEquipmentTypeAccountConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSComment = "";
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSDataMember = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSDataSource = "ACEquipmentTypeAccountConfigs";
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSDescription = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSError = "";
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSFieldGroup = "";
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSFieldRelation = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSGridType = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSPrivilege = "";
            this.fld_dgcACEquipmentTypeAccountConfigs.BOSPropertyName = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.CommodityType = "";
            this.fld_dgcACEquipmentTypeAccountConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEquipmentTypeAccountConfigs.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcACEquipmentTypeAccountConfigs.MainView = this.gridView5;
            this.fld_dgcACEquipmentTypeAccountConfigs.Name = "fld_dgcACEquipmentTypeAccountConfigs";
            this.fld_dgcACEquipmentTypeAccountConfigs.PrintReport = false;
            this.fld_dgcACEquipmentTypeAccountConfigs.Screen = null;
            this.fld_dgcACEquipmentTypeAccountConfigs.Size = new System.Drawing.Size(805, 391);
            this.fld_dgcACEquipmentTypeAccountConfigs.TabIndex = 4;
            this.fld_dgcACEquipmentTypeAccountConfigs.Tag = "DC";
            this.fld_dgcACEquipmentTypeAccountConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcACEquipmentTypeAccountConfigs;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // DMCS108
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(883, 823);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS108";
            this.Text = "Cấu hình tài khoản đối tượng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCustomerTypeAccountConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).EndInit();
            this.fld_grpGroupControl5.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACLoanReceiptTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTypeAccountConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPSupplierTypeAccountConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabBankAndCash.ResumeLayout(false);
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAssetTypeDepreciationConfigsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAssetTypeAccountConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.bosLine7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEquipmentStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEquipmentTypeAccountConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSaveCustomerAccountConfig;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButton fld_btnSaveSupplierAccountConfig;
        private APSupplierTypeAccountConfigsGridControl fld_dgcAPSupplierTypeAccountConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnSaveProductAccountConfig;
        private ICProductTypeAccountConfigsGridControl fld_dgcICProductTypeAccountConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSButton fld_btnACAssetTypeAccountConfigs;
        private ACAssetTypeAccountConfigsGridControl fld_dgcACAssetTypeAccountConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private DevExpress.XtraTab.XtraTabPage fld_tabBankAndCash;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSButton bosButton1;
        private ACAssetTypeDepreciationConfigsGridControl fld_dgcAssetTypeDepreciationConfigsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSButton fld_btnACEquipmentTypeAccountConfigs;
        private ACEquipmentTypeAccountConfigsGridControl fld_dgcACEquipmentTypeAccountConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSButton fld_btnSaveACLoanReceiptTypes;
        private ACLoanReceiptTypesGridControl fld_dgcACLoanReceiptTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private BOSComponent.BOSLine bosLine7;
        private BOSComponent.BOSButton bosButton2;
        private ACEquipmentStatesGridControl fld_dgcACEquipmentStates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
    }
}
