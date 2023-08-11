using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS102
	/// </summary>
	partial class DMCS102
	{
		private ProductTypeGridControl fld_dgcProductType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS102));
            this.fld_dgcProductType = new BOSERP.Modules.CompanyConstant.ProductTypeGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcPriceLevel = new BOSERP.Modules.CompanyConstant.PriceLevelGridControl();
            this.fld_dgvPriceLevel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grpGroupControl6 = new BOSComponent.BOSLine(this.components);
            this.fld_grpGroupControl8 = new BOSComponent.BOSLine(this.components);
            this.fld_grpGroupControl7 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICMeasureUnits = new BOSERP.Modules.CompanyConstant.ICMeasureUnitsGridControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductOrigin = new BOSERP.Modules.CompanyConstant.ProductOriginGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductTrademark = new BOSERP.Modules.CompanyConstant.ProductTrademarkGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductCollection = new BOSERP.Modules.CompanyConstant.ProductCollectionGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductStorageCondition = new BOSERP.Modules.CompanyConstant.ProductStorageConditionGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductFormulaPriceConfigsGridControl = new BOSERP.Modules.CompanyConstant.ICProductFormulaPriceConfigsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tclProductTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabProductTemplates = new DevExpress.XtraTab.XtraTabPage();
            this.fld_pnlProductTemplate = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.fld_trlProductTemplates = new BOSERP.Modules.CompanyConstant.ICProductTemplateConfigsTreeListControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_txtProductTemplateName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnDeleteProductTemplate = new DevExpress.XtraEditors.SimpleButton();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddProductTemplate = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btn_SavePackageNumering = new BOSComponent.BOSButton(this.components);
            this.fld_btnSaveProductNoConfigs = new BOSComponent.BOSButton(this.components);
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcGEPackageNumeringConfigsGridControl = new BOSERP.Modules.CompanyConstant.GEPackageNumeringConfigsGridControl();
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcGenerateProductNoConfigsGridControl = new BOSERP.Modules.CompanyConstant.GEGenerateProductNoConfigsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPriceLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvPriceLevel)).BeginInit();
            this.fld_grpGroupControl6.SuspendLayout();
            this.fld_grpGroupControl8.SuspendLayout();
            this.fld_grpGroupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICMeasureUnits)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductTrademark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductStorageCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductFormulaPriceConfigsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclProductTabControl)).BeginInit();
            this.fld_tclProductTabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.fld_tabProductTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnlProductTemplate)).BeginInit();
            this.fld_pnlProductTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductTemplateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateNo.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEPackageNumeringConfigsGridControl)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGenerateProductNoConfigsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcProductType
            // 
            this.fld_dgcProductType.AllowDrop = true;
            this.fld_dgcProductType.BOSComment = "";
            this.fld_dgcProductType.BOSDataMember = null;
            this.fld_dgcProductType.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductType.BOSDescription = null;
            this.fld_dgcProductType.BOSError = "";
            this.fld_dgcProductType.BOSFieldGroup = "";
            this.fld_dgcProductType.BOSFieldRelation = null;
            this.fld_dgcProductType.BOSGridType = null;
            this.fld_dgcProductType.BOSPrivilege = "";
            this.fld_dgcProductType.BOSPropertyName = null;
            this.fld_dgcProductType.CommodityType = "";
            this.fld_dgcProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcProductType.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcProductType.MainView = this.fld_dgvProductType;
            this.fld_dgcProductType.Name = "fld_dgcProductType";
            this.fld_dgcProductType.PrintReport = false;
            this.fld_dgcProductType.Screen = null;
            this.fld_dgcProductType.Size = new System.Drawing.Size(444, 128);
            this.fld_dgcProductType.TabIndex = 4;
            this.fld_dgcProductType.Tag = "DC";
            this.fld_dgcProductType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcProductType;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // fld_dgcPriceLevel
            // 
            this.fld_dgcPriceLevel.AllowDrop = true;
            this.fld_dgcPriceLevel.BOSComment = "";
            this.fld_dgcPriceLevel.BOSDataMember = null;
            this.fld_dgcPriceLevel.BOSDataSource = "ARPriceLevels";
            this.fld_dgcPriceLevel.BOSDescription = null;
            this.fld_dgcPriceLevel.BOSError = "";
            this.fld_dgcPriceLevel.BOSFieldGroup = "";
            this.fld_dgcPriceLevel.BOSFieldRelation = null;
            this.fld_dgcPriceLevel.BOSGridType = null;
            this.fld_dgcPriceLevel.BOSPrivilege = "";
            this.fld_dgcPriceLevel.BOSPropertyName = null;
            this.fld_dgcPriceLevel.CommodityType = "";
            this.fld_dgcPriceLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcPriceLevel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPriceLevel.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcPriceLevel.MainView = this.fld_dgvPriceLevel;
            this.fld_dgcPriceLevel.MinimumSize = new System.Drawing.Size(0, 7);
            this.fld_dgcPriceLevel.Name = "fld_dgcPriceLevel";
            this.fld_dgcPriceLevel.PrintReport = false;
            this.fld_dgcPriceLevel.Screen = null;
            this.fld_dgcPriceLevel.Size = new System.Drawing.Size(450, 162);
            this.fld_dgcPriceLevel.TabIndex = 10;
            this.fld_dgcPriceLevel.Tag = "DC";
            this.fld_dgcPriceLevel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvPriceLevel});
            // 
            // fld_dgvPriceLevel
            // 
            this.fld_dgvPriceLevel.GridControl = this.fld_dgcPriceLevel;
            this.fld_dgvPriceLevel.Name = "fld_dgvPriceLevel";
            this.fld_dgvPriceLevel.PaintStyleName = "Office2003";
            // 
            // fld_grpGroupControl6
            // 
            this.fld_grpGroupControl6.BOSComment = null;
            this.fld_grpGroupControl6.BOSDataMember = null;
            this.fld_grpGroupControl6.BOSDataSource = null;
            this.fld_grpGroupControl6.BOSDescription = null;
            this.fld_grpGroupControl6.BOSError = null;
            this.fld_grpGroupControl6.BOSFieldGroup = null;
            this.fld_grpGroupControl6.BOSFieldRelation = null;
            this.fld_grpGroupControl6.BOSPrivilege = null;
            this.fld_grpGroupControl6.BOSPropertyName = null;
            this.fld_grpGroupControl6.Controls.Add(this.fld_dgcProductType);
            this.fld_grpGroupControl6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl6.Location = new System.Drawing.Point(12, 12);
            this.fld_grpGroupControl6.Name = "fld_grpGroupControl6";
            this.fld_grpGroupControl6.Screen = null;
            this.fld_grpGroupControl6.Size = new System.Drawing.Size(450, 148);
            this.fld_grpGroupControl6.TabIndex = 0;
            this.fld_grpGroupControl6.TabStop = false;
            this.fld_grpGroupControl6.Text = "Loại sản phẩm";
            // 
            // fld_grpGroupControl8
            // 
            this.fld_grpGroupControl8.BOSComment = null;
            this.fld_grpGroupControl8.BOSDataMember = null;
            this.fld_grpGroupControl8.BOSDataSource = null;
            this.fld_grpGroupControl8.BOSDescription = null;
            this.fld_grpGroupControl8.BOSError = null;
            this.fld_grpGroupControl8.BOSFieldGroup = null;
            this.fld_grpGroupControl8.BOSFieldRelation = null;
            this.fld_grpGroupControl8.BOSPrivilege = null;
            this.fld_grpGroupControl8.BOSPropertyName = null;
            this.fld_grpGroupControl8.Controls.Add(this.fld_dgcPriceLevel);
            this.fld_grpGroupControl8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl8.Location = new System.Drawing.Point(6, 363);
            this.fld_grpGroupControl8.Name = "fld_grpGroupControl8";
            this.fld_grpGroupControl8.Screen = null;
            this.fld_grpGroupControl8.Size = new System.Drawing.Size(456, 182);
            this.fld_grpGroupControl8.TabIndex = 3;
            this.fld_grpGroupControl8.TabStop = false;
            this.fld_grpGroupControl8.Text = "Mức giá áp dụng";
            // 
            // fld_grpGroupControl7
            // 
            this.fld_grpGroupControl7.BOSComment = null;
            this.fld_grpGroupControl7.BOSDataMember = null;
            this.fld_grpGroupControl7.BOSDataSource = null;
            this.fld_grpGroupControl7.BOSDescription = null;
            this.fld_grpGroupControl7.BOSError = null;
            this.fld_grpGroupControl7.BOSFieldGroup = null;
            this.fld_grpGroupControl7.BOSFieldRelation = null;
            this.fld_grpGroupControl7.BOSPrivilege = null;
            this.fld_grpGroupControl7.BOSPropertyName = null;
            this.fld_grpGroupControl7.Controls.Add(this.fld_dgcICMeasureUnits);
            this.fld_grpGroupControl7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl7.Location = new System.Drawing.Point(12, 166);
            this.fld_grpGroupControl7.Name = "fld_grpGroupControl7";
            this.fld_grpGroupControl7.Screen = null;
            this.fld_grpGroupControl7.Size = new System.Drawing.Size(450, 191);
            this.fld_grpGroupControl7.TabIndex = 2;
            this.fld_grpGroupControl7.TabStop = false;
            this.fld_grpGroupControl7.Text = "Đơn vị tính";
            // 
            // fld_dgcICMeasureUnits
            // 
            this.fld_dgcICMeasureUnits.BOSComment = null;
            this.fld_dgcICMeasureUnits.BOSDataMember = null;
            this.fld_dgcICMeasureUnits.BOSDataSource = "ICMeasureUnits";
            this.fld_dgcICMeasureUnits.BOSDescription = null;
            this.fld_dgcICMeasureUnits.BOSError = null;
            this.fld_dgcICMeasureUnits.BOSFieldGroup = null;
            this.fld_dgcICMeasureUnits.BOSFieldRelation = null;
            this.fld_dgcICMeasureUnits.BOSGridType = null;
            this.fld_dgcICMeasureUnits.BOSPrivilege = null;
            this.fld_dgcICMeasureUnits.BOSPropertyName = null;
            this.fld_dgcICMeasureUnits.CommodityType = "";
            this.fld_dgcICMeasureUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICMeasureUnits.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICMeasureUnits.Name = "fld_dgcICMeasureUnits";
            this.fld_dgcICMeasureUnits.PrintReport = false;
            this.fld_dgcICMeasureUnits.Screen = null;
            this.fld_dgcICMeasureUnits.Size = new System.Drawing.Size(444, 171);
            this.fld_dgcICMeasureUnits.TabIndex = 0;
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
            this.bosLine1.Controls.Add(this.fld_dgcProductOrigin);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(468, 12);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(450, 148);
            this.bosLine1.TabIndex = 1;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Xuất xứ";
            // 
            // fld_dgcProductOrigin
            // 
            this.fld_dgcProductOrigin.AllowDrop = true;
            this.fld_dgcProductOrigin.BOSComment = "";
            this.fld_dgcProductOrigin.BOSDataMember = "";
            this.fld_dgcProductOrigin.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductOrigin.BOSDescription = null;
            this.fld_dgcProductOrigin.BOSError = "";
            this.fld_dgcProductOrigin.BOSFieldGroup = "";
            this.fld_dgcProductOrigin.BOSFieldRelation = null;
            this.fld_dgcProductOrigin.BOSGridType = null;
            this.fld_dgcProductOrigin.BOSPrivilege = "";
            this.fld_dgcProductOrigin.BOSPropertyName = null;
            this.fld_dgcProductOrigin.CommodityType = "";
            this.fld_dgcProductOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductOrigin.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcProductOrigin.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcProductOrigin.MainView = this.gridView1;
            this.fld_dgcProductOrigin.Name = "fld_dgcProductOrigin";
            this.fld_dgcProductOrigin.PrintReport = false;
            this.fld_dgcProductOrigin.Screen = null;
            this.fld_dgcProductOrigin.Size = new System.Drawing.Size(444, 128);
            this.fld_dgcProductOrigin.TabIndex = 4;
            this.fld_dgcProductOrigin.Tag = "DC";
            this.fld_dgcProductOrigin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcProductOrigin;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
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
            this.bosLine2.Controls.Add(this.fld_dgcProductTrademark);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(468, 166);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(450, 191);
            this.bosLine2.TabIndex = 6;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thương hiệu";
            // 
            // fld_dgcProductTrademark
            // 
            this.fld_dgcProductTrademark.AllowDrop = true;
            this.fld_dgcProductTrademark.BOSComment = "";
            this.fld_dgcProductTrademark.BOSDataMember = "";
            this.fld_dgcProductTrademark.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductTrademark.BOSDescription = null;
            this.fld_dgcProductTrademark.BOSError = "";
            this.fld_dgcProductTrademark.BOSFieldGroup = "";
            this.fld_dgcProductTrademark.BOSFieldRelation = null;
            this.fld_dgcProductTrademark.BOSGridType = null;
            this.fld_dgcProductTrademark.BOSPrivilege = "";
            this.fld_dgcProductTrademark.BOSPropertyName = null;
            this.fld_dgcProductTrademark.CommodityType = "";
            this.fld_dgcProductTrademark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductTrademark.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcProductTrademark.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcProductTrademark.MainView = this.gridView2;
            this.fld_dgcProductTrademark.Name = "fld_dgcProductTrademark";
            this.fld_dgcProductTrademark.PrintReport = false;
            this.fld_dgcProductTrademark.Screen = null;
            this.fld_dgcProductTrademark.Size = new System.Drawing.Size(444, 171);
            this.fld_dgcProductTrademark.TabIndex = 4;
            this.fld_dgcProductTrademark.Tag = "DC";
            this.fld_dgcProductTrademark.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcProductTrademark;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosLine6);
            this.bosPanel1.Controls.Add(this.bosLine5);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl6);
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl8);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.fld_grpGroupControl7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1530, 752);
            this.bosPanel1.TabIndex = 335;
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
            this.bosLine6.Controls.Add(this.fld_dgcProductCollection);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(933, 12);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(450, 191);
            this.bosLine6.TabIndex = 7;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Collection";
            // 
            // fld_dgcProductCollection
            // 
            this.fld_dgcProductCollection.AllowDrop = true;
            this.fld_dgcProductCollection.BOSComment = "";
            this.fld_dgcProductCollection.BOSDataMember = "";
            this.fld_dgcProductCollection.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductCollection.BOSDescription = null;
            this.fld_dgcProductCollection.BOSError = "";
            this.fld_dgcProductCollection.BOSFieldGroup = "";
            this.fld_dgcProductCollection.BOSFieldRelation = null;
            this.fld_dgcProductCollection.BOSGridType = null;
            this.fld_dgcProductCollection.BOSPrivilege = "";
            this.fld_dgcProductCollection.BOSPropertyName = null;
            this.fld_dgcProductCollection.CommodityType = "";
            this.fld_dgcProductCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductCollection.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcProductCollection.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcProductCollection.MainView = this.gridView5;
            this.fld_dgcProductCollection.Name = "fld_dgcProductCollection";
            this.fld_dgcProductCollection.PrintReport = false;
            this.fld_dgcProductCollection.Screen = null;
            this.fld_dgcProductCollection.Size = new System.Drawing.Size(444, 171);
            this.fld_dgcProductCollection.TabIndex = 4;
            this.fld_dgcProductCollection.Tag = "DC";
            this.fld_dgcProductCollection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcProductCollection;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
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
            this.bosLine5.Controls.Add(this.fld_dgcProductStorageCondition);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(468, 363);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(450, 182);
            this.bosLine5.TabIndex = 8;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Điều kiện bảo quản";
            // 
            // fld_dgcProductStorageCondition
            // 
            this.fld_dgcProductStorageCondition.AllowDrop = true;
            this.fld_dgcProductStorageCondition.BOSComment = "";
            this.fld_dgcProductStorageCondition.BOSDataMember = "";
            this.fld_dgcProductStorageCondition.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductStorageCondition.BOSDescription = null;
            this.fld_dgcProductStorageCondition.BOSError = "";
            this.fld_dgcProductStorageCondition.BOSFieldGroup = "";
            this.fld_dgcProductStorageCondition.BOSFieldRelation = null;
            this.fld_dgcProductStorageCondition.BOSGridType = null;
            this.fld_dgcProductStorageCondition.BOSPrivilege = "";
            this.fld_dgcProductStorageCondition.BOSPropertyName = null;
            this.fld_dgcProductStorageCondition.CommodityType = "";
            this.fld_dgcProductStorageCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProductStorageCondition.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcProductStorageCondition.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcProductStorageCondition.MainView = this.gridView4;
            this.fld_dgcProductStorageCondition.Name = "fld_dgcProductStorageCondition";
            this.fld_dgcProductStorageCondition.PrintReport = false;
            this.fld_dgcProductStorageCondition.Screen = null;
            this.fld_dgcProductStorageCondition.Size = new System.Drawing.Size(444, 162);
            this.fld_dgcProductStorageCondition.TabIndex = 4;
            this.fld_dgcProductStorageCondition.Tag = "DC";
            this.fld_dgcProductStorageCondition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcProductStorageCondition;
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
            this.bosLine3.Controls.Add(this.fld_dgcICProductFormulaPriceConfigsGridControl);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(9, 551);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(909, 182);
            this.bosLine3.TabIndex = 7;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Công thức tính giá";
            // 
            // fld_dgcICProductFormulaPriceConfigsGridControl
            // 
            this.fld_dgcICProductFormulaPriceConfigsGridControl.AllowDrop = true;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSComment = "";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSDataMember = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSDataSource = "ICProductFormulaPriceConfigs";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSDescription = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSError = "";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSFieldGroup = "";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSGridType = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSPrivilege = "";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.CommodityType = "";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICProductFormulaPriceConfigsGridControl.MainView = this.gridView3;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.MinimumSize = new System.Drawing.Size(0, 7);
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Name = "fld_dgcICProductFormulaPriceConfigsGridControl";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.PrintReport = false;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Screen = null;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Size = new System.Drawing.Size(903, 162);
            this.fld_dgcICProductFormulaPriceConfigsGridControl.TabIndex = 10;
            this.fld_dgcICProductFormulaPriceConfigsGridControl.Tag = "DC";
            this.fld_dgcICProductFormulaPriceConfigsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcICProductFormulaPriceConfigsGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // fld_tclProductTabControl
            // 
            this.fld_tclProductTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tclProductTabControl.Location = new System.Drawing.Point(0, 0);
            this.fld_tclProductTabControl.Name = "fld_tclProductTabControl";
            this.fld_tclProductTabControl.SelectedTabPage = this.xtraTabPage1;
            this.fld_tclProductTabControl.Size = new System.Drawing.Size(1532, 777);
            this.fld_tclProductTabControl.TabIndex = 336;
            this.fld_tclProductTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.fld_tabProductTemplates,
            this.xtraTabPage2});
            this.fld_tclProductTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tclProductTabContrl_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosPanel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1530, 752);
            this.xtraTabPage1.Text = "Cấu hình chung";
            // 
            // fld_tabProductTemplates
            // 
            this.fld_tabProductTemplates.AutoScroll = true;
            this.fld_tabProductTemplates.Controls.Add(this.fld_pnlProductTemplate);
            this.fld_tabProductTemplates.Name = "fld_tabProductTemplates";
            this.fld_tabProductTemplates.Size = new System.Drawing.Size(1516, 745);
            this.fld_tabProductTemplates.Text = "Khu vực";
            // 
            // fld_pnlProductTemplate
            // 
            this.fld_pnlProductTemplate.Controls.Add(this.groupControl2);
            this.fld_pnlProductTemplate.Controls.Add(this.groupControl1);
            this.fld_pnlProductTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlProductTemplate.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlProductTemplate.Name = "fld_pnlProductTemplate";
            this.fld_pnlProductTemplate.Size = new System.Drawing.Size(1516, 745);
            this.fld_pnlProductTemplate.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.fld_trlProductTemplates);
            this.groupControl2.Location = new System.Drawing.Point(10, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1499, 625);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Danh sách khu vực";
            // 
            // fld_trlProductTemplates
            // 
            this.fld_trlProductTemplates.BOSComment = "";
            this.fld_trlProductTemplates.BOSDataMember = null;
            this.fld_trlProductTemplates.BOSDataSource = "ICProductTemplateConfigs";
            this.fld_trlProductTemplates.BOSDescription = null;
            this.fld_trlProductTemplates.BOSDisplayOption = false;
            this.fld_trlProductTemplates.BOSDisplayRoot = true;
            this.fld_trlProductTemplates.BOSError = "";
            this.fld_trlProductTemplates.BOSFieldGroup = "";
            this.fld_trlProductTemplates.BOSFieldRelation = null;
            this.fld_trlProductTemplates.BOSPrivilege = "";
            this.fld_trlProductTemplates.BOSPropertyName = null;
            this.fld_trlProductTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlProductTemplates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlProductTemplates.Location = new System.Drawing.Point(2, 23);
            this.fld_trlProductTemplates.Name = "fld_trlProductTemplates";
            this.fld_trlProductTemplates.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlProductTemplates.Screen = null;
            this.fld_trlProductTemplates.Size = new System.Drawing.Size(1495, 600);
            this.fld_trlProductTemplates.TabIndex = 0;
            this.fld_trlProductTemplates.Tag = "DC";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_txtProductTemplateName);
            this.groupControl1.Controls.Add(this.fld_txtICProductTemplateNo);
            this.groupControl1.Controls.Add(this.fld_btnDeleteProductTemplate);
            this.groupControl1.Controls.Add(this.bosLabel1);
            this.groupControl1.Controls.Add(this.fld_btnAddProductTemplate);
            this.groupControl1.Controls.Add(this.fld_lblLabel2);
            this.groupControl1.Location = new System.Drawing.Point(10, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(518, 104);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Thông tin chung";
            // 
            // fld_txtProductTemplateName
            // 
            this.fld_txtProductTemplateName.BOSComment = null;
            this.fld_txtProductTemplateName.BOSDataMember = "ICProductTemplateName";
            this.fld_txtProductTemplateName.BOSDataSource = "ICProductTemplates";
            this.fld_txtProductTemplateName.BOSDescription = null;
            this.fld_txtProductTemplateName.BOSError = null;
            this.fld_txtProductTemplateName.BOSFieldGroup = null;
            this.fld_txtProductTemplateName.BOSFieldRelation = null;
            this.fld_txtProductTemplateName.BOSPrivilege = null;
            this.fld_txtProductTemplateName.BOSPropertyName = "EditValue";
            this.fld_txtProductTemplateName.Location = new System.Drawing.Point(100, 63);
            this.fld_txtProductTemplateName.MenuManager = this.screenToolbar;
            this.fld_txtProductTemplateName.Name = "fld_txtProductTemplateName";
            this.fld_txtProductTemplateName.Screen = null;
            this.fld_txtProductTemplateName.Size = new System.Drawing.Size(193, 20);
            this.fld_txtProductTemplateName.TabIndex = 18;
            this.fld_txtProductTemplateName.Tag = "DC";
            // 
            // fld_txtICProductTemplateNo
            // 
            this.fld_txtICProductTemplateNo.BOSComment = null;
            this.fld_txtICProductTemplateNo.BOSDataMember = "ICProductTemplateNo";
            this.fld_txtICProductTemplateNo.BOSDataSource = "ICProductTemplates";
            this.fld_txtICProductTemplateNo.BOSDescription = null;
            this.fld_txtICProductTemplateNo.BOSError = null;
            this.fld_txtICProductTemplateNo.BOSFieldGroup = null;
            this.fld_txtICProductTemplateNo.BOSFieldRelation = null;
            this.fld_txtICProductTemplateNo.BOSPrivilege = null;
            this.fld_txtICProductTemplateNo.BOSPropertyName = "EditValue";
            this.fld_txtICProductTemplateNo.Location = new System.Drawing.Point(100, 37);
            this.fld_txtICProductTemplateNo.MenuManager = this.screenToolbar;
            this.fld_txtICProductTemplateNo.Name = "fld_txtICProductTemplateNo";
            this.fld_txtICProductTemplateNo.Screen = null;
            this.fld_txtICProductTemplateNo.Size = new System.Drawing.Size(193, 20);
            this.fld_txtICProductTemplateNo.TabIndex = 17;
            this.fld_txtICProductTemplateNo.Tag = "DC";
            // 
            // fld_btnDeleteProductTemplate
            // 
            this.fld_btnDeleteProductTemplate.Location = new System.Drawing.Point(418, 60);
            this.fld_btnDeleteProductTemplate.Name = "fld_btnDeleteProductTemplate";
            this.fld_btnDeleteProductTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeleteProductTemplate.TabIndex = 3;
            this.fld_btnDeleteProductTemplate.Text = "Xóa";
            this.fld_btnDeleteProductTemplate.Click += new System.EventHandler(this.fld_btnDeleteProductTemplate_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(18, 40);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(55, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã khu vực";
            // 
            // fld_btnAddProductTemplate
            // 
            this.fld_btnAddProductTemplate.Location = new System.Drawing.Point(337, 60);
            this.fld_btnAddProductTemplate.Name = "fld_btnAddProductTemplate";
            this.fld_btnAddProductTemplate.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddProductTemplate.TabIndex = 2;
            this.fld_btnAddProductTemplate.Text = "Thêm";
            this.fld_btnAddProductTemplate.Click += new System.EventHandler(this.fld_btnAddProductTemplate_Click);
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(18, 66);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(59, 13);
            this.fld_lblLabel2.TabIndex = 14;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Tên khu vực";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btn_SavePackageNumering);
            this.xtraTabPage2.Controls.Add(this.fld_btnSaveProductNoConfigs);
            this.xtraTabPage2.Controls.Add(this.bosLine7);
            this.xtraTabPage2.Controls.Add(this.bosLine4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1516, 745);
            this.xtraTabPage2.Text = "Cấu hình khác";
            // 
            // fld_btn_SavePackageNumering
            // 
            this.fld_btn_SavePackageNumering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btn_SavePackageNumering.BOSComment = null;
            this.fld_btn_SavePackageNumering.BOSDataMember = null;
            this.fld_btn_SavePackageNumering.BOSDataSource = null;
            this.fld_btn_SavePackageNumering.BOSDescription = null;
            this.fld_btn_SavePackageNumering.BOSError = null;
            this.fld_btn_SavePackageNumering.BOSFieldGroup = null;
            this.fld_btn_SavePackageNumering.BOSFieldRelation = null;
            this.fld_btn_SavePackageNumering.BOSPrivilege = null;
            this.fld_btn_SavePackageNumering.BOSPropertyName = null;
            this.fld_btn_SavePackageNumering.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btn_SavePackageNumering.Location = new System.Drawing.Point(1482, 376);
            this.fld_btn_SavePackageNumering.Name = "fld_btn_SavePackageNumering";
            this.fld_btn_SavePackageNumering.Screen = null;
            this.fld_btn_SavePackageNumering.Size = new System.Drawing.Size(31, 30);
            this.fld_btn_SavePackageNumering.TabIndex = 3;
            this.fld_btn_SavePackageNumering.Text = "bosButton1";
            this.fld_btn_SavePackageNumering.Click += new System.EventHandler(this.fld_btn_SavePackageNumering_Click);
            // 
            // fld_btnSaveProductNoConfigs
            // 
            this.fld_btnSaveProductNoConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveProductNoConfigs.BOSComment = null;
            this.fld_btnSaveProductNoConfigs.BOSDataMember = null;
            this.fld_btnSaveProductNoConfigs.BOSDataSource = null;
            this.fld_btnSaveProductNoConfigs.BOSDescription = null;
            this.fld_btnSaveProductNoConfigs.BOSError = null;
            this.fld_btnSaveProductNoConfigs.BOSFieldGroup = null;
            this.fld_btnSaveProductNoConfigs.BOSFieldRelation = null;
            this.fld_btnSaveProductNoConfigs.BOSPrivilege = null;
            this.fld_btnSaveProductNoConfigs.BOSPropertyName = null;
            this.fld_btnSaveProductNoConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveProductNoConfigs.Location = new System.Drawing.Point(1482, 24);
            this.fld_btnSaveProductNoConfigs.Name = "fld_btnSaveProductNoConfigs";
            this.fld_btnSaveProductNoConfigs.Screen = null;
            this.fld_btnSaveProductNoConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveProductNoConfigs.TabIndex = 3;
            this.fld_btnSaveProductNoConfigs.Text = "bosButton1";
            this.fld_btnSaveProductNoConfigs.Click += new System.EventHandler(this.fld_btnSaveProductNoConfigs_Click);
            // 
            // bosLine7
            // 
            this.bosLine7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.fld_dgcGEPackageNumeringConfigsGridControl);
            this.bosLine7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine7.Location = new System.Drawing.Point(11, 359);
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.bosLine7.Size = new System.Drawing.Size(1462, 368);
            this.bosLine7.TabIndex = 2;
            this.bosLine7.TabStop = false;
            this.bosLine7.Text = "Cấu hình sinh mã kiện";
            // 
            // fld_dgcGEPackageNumeringConfigsGridControl
            // 
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSComment = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSDataMember = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSDataSource = "GEPackageNumeringConfigs";
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSDescription = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSError = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSFieldGroup = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSGridType = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSPrivilege = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.CommodityType = "";
            this.fld_dgcGEPackageNumeringConfigsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcGEPackageNumeringConfigsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEPackageNumeringConfigsGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcGEPackageNumeringConfigsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcGEPackageNumeringConfigsGridControl.Name = "fld_dgcGEPackageNumeringConfigsGridControl";
            this.fld_dgcGEPackageNumeringConfigsGridControl.PrintReport = false;
            this.fld_dgcGEPackageNumeringConfigsGridControl.Screen = null;
            this.fld_dgcGEPackageNumeringConfigsGridControl.Size = new System.Drawing.Size(1456, 348);
            this.fld_dgcGEPackageNumeringConfigsGridControl.TabIndex = 0;
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_dgcGenerateProductNoConfigsGridControl);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(8, 7);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(1468, 346);
            this.bosLine4.TabIndex = 1;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Cấu hình sinh mã";
            // 
            // fld_dgcGenerateProductNoConfigsGridControl
            // 
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSComment = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSDataMember = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSDataSource = "GEGenerateProductNoConfigs";
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSDescription = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSError = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSFieldGroup = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSFieldRelation = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSGridType = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSPrivilege = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.BOSPropertyName = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.CommodityType = "";
            this.fld_dgcGenerateProductNoConfigsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcGenerateProductNoConfigsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGenerateProductNoConfigsGridControl.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcGenerateProductNoConfigsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcGenerateProductNoConfigsGridControl.Name = "fld_dgcGenerateProductNoConfigsGridControl";
            this.fld_dgcGenerateProductNoConfigsGridControl.PrintReport = false;
            this.fld_dgcGenerateProductNoConfigsGridControl.Screen = null;
            this.fld_dgcGenerateProductNoConfigsGridControl.Size = new System.Drawing.Size(1462, 326);
            this.fld_dgcGenerateProductNoConfigsGridControl.TabIndex = 0;
            // 
            // DMCS102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1532, 777);
            this.Controls.Add(this.fld_tclProductTabControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS102.IconOptions.Icon")));
            this.Name = "DMCS102";
            this.Text = "Cấu hình sản phẩm";
            this.Controls.SetChildIndex(this.fld_tclProductTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPriceLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvPriceLevel)).EndInit();
            this.fld_grpGroupControl6.ResumeLayout(false);
            this.fld_grpGroupControl8.ResumeLayout(false);
            this.fld_grpGroupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICMeasureUnits)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductTrademark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductStorageCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductFormulaPriceConfigsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclProductTabControl)).EndInit();
            this.fld_tclProductTabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.fld_tabProductTemplates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnlProductTemplate)).EndInit();
            this.fld_pnlProductTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductTemplateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductTemplateNo.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.bosLine7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEPackageNumeringConfigsGridControl)).EndInit();
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGenerateProductNoConfigsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private PriceLevelGridControl fld_dgcPriceLevel;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvPriceLevel;
        private BOSComponent.BOSLine fld_grpGroupControl6;
        private BOSComponent.BOSLine fld_grpGroupControl8;
        private BOSComponent.BOSLine fld_grpGroupControl7;
        private ICMeasureUnitsGridControl fld_dgcICMeasureUnits;
        private BOSComponent.BOSLine bosLine1;
        private ProductOriginGridControl fld_dgcProductOrigin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLine bosLine2;
        private ProductTrademarkGridControl fld_dgcProductTrademark;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine3;
        private ICProductFormulaPriceConfigsGridControl fld_dgcICProductFormulaPriceConfigsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabControl fld_tclProductTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductTemplates;
        private DevExpress.XtraEditors.PanelControl fld_pnlProductTemplate;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton fld_btnDeleteProductTemplate;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddProductTemplate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private BOSERP.Modules.CompanyConstant.ICProductTemplateConfigsTreeListControl fld_trlProductTemplates;
        private BOSComponent.BOSTextBox fld_txtICProductTemplateNo;
        private BOSComponent.BOSTextBox fld_txtProductTemplateName;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLine bosLine4;
        private GEGenerateProductNoConfigsGridControl fld_dgcGenerateProductNoConfigsGridControl;
        private BOSComponent.BOSLine bosLine5;
        private ProductStorageConditionGridControl fld_dgcProductStorageCondition;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSLine bosLine6;
        private ProductCollectionGridControl fld_dgcProductCollection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSLine bosLine7;
        private GEPackageNumeringConfigsGridControl fld_dgcGEPackageNumeringConfigsGridControl;
        private BOSComponent.BOSButton fld_btn_SavePackageNumering;
        private BOSComponent.BOSButton fld_btnSaveProductNoConfigs;
    }
}
