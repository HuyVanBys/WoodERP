using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC101
	/// </summary>
    partial class DMPC116
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
            this.fld_btnSaveMMProductionCompletionTimeConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCompletionTimeConfigs = new BOSERP.Modules.ProductConstant.MMProductionCompletionTimeConfigGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvMMReuseSpecificateConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnMMExecuteTimeConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMExecuteTimeConfig = new BOSERP.Modules.ProductConstant.MMExecuteTimeConfigGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnMMDepartmentAndOperations = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMDepartmentAndOperations = new BOSERP.Modules.ProductConstant.MMDepartmentAndOperationsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveMMDepartmentCapacityConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMDepartmentCapacityConfigs = new BOSERP.Modules.ProductConstant.MMDepartmentCapacityConfigsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnMMProductGroupTypeSwitchingConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductGroupTypeSwitchingConfigs = new BOSERP.Modules.ProductConstant.MMProductGroupTypeSwitchingConfigsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCompletionTimeConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMExecuteTimeConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentAndOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentCapacityConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductGroupTypeSwitchingConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnSaveMMProductionCompletionTimeConfigs
            // 
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSComment = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDataMember = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDataSource = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDescription = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSError = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSFieldGroup = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSFieldRelation = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSPrivilege = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSPropertyName = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Location = new System.Drawing.Point(980, 5);
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Name = "fld_btnSaveMMProductionCompletionTimeConfigs";
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Screen = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveMMProductionCompletionTimeConfigs.TabIndex = 1;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Text = "bosButton1";
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Click += new System.EventHandler(this.fld_btnSaveMMProductionCompletionTimeConfigs_Click);
            // 
            // fld_dgcMMProductionCompletionTimeConfigs
            // 
            this.fld_dgcMMProductionCompletionTimeConfigs.AllowDrop = true;
            this.fld_dgcMMProductionCompletionTimeConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSDataMember = null;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSDataSource = "MMProductionCompletionTimeConfigs";
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSDescription = null;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSFieldRelation = null;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSGridType = null;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductionCompletionTimeConfigs.BOSPropertyName = null;
            this.fld_dgcMMProductionCompletionTimeConfigs.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductionCompletionTimeConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCompletionTimeConfigs.Location = new System.Drawing.Point(3, 5);
            this.fld_dgcMMProductionCompletionTimeConfigs.MainView = this.fld_dgvProductType;
            this.fld_dgcMMProductionCompletionTimeConfigs.Name = "fld_dgcMMProductionCompletionTimeConfigs";
            this.fld_dgcMMProductionCompletionTimeConfigs.PrintReport = false;
            this.fld_dgcMMProductionCompletionTimeConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProductionCompletionTimeConfigs, true);
            this.fld_dgcMMProductionCompletionTimeConfigs.Size = new System.Drawing.Size(971, 437);
            this.fld_dgcMMProductionCompletionTimeConfigs.TabIndex = 0;
            this.fld_dgcMMProductionCompletionTimeConfigs.Tag = "DC";
            this.fld_dgcMMProductionCompletionTimeConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMProductionCompletionTimeConfigs;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // fld_dgvMMReuseSpecificateConfigs
            // 
            this.fld_dgvMMReuseSpecificateConfigs.Name = "fld_dgvMMReuseSpecificateConfigs";
            this.fld_dgvMMReuseSpecificateConfigs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1021, 474);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1021, 474);
            this.bosTabControl1.TabIndex = 2;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnSaveMMProductionCompletionTimeConfigs);
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCompletionTimeConfigs);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1014, 445);
            this.xtraTabPage1.Text = "Cấu hình thời gian hoàn thành sản xuất";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnMMExecuteTimeConfigs);
            this.xtraTabPage2.Controls.Add(this.fld_dgcMMExecuteTimeConfig);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1014, 445);
            this.xtraTabPage2.Text = "Cấu hình thời gian thực hiện";
            // 
            // fld_btnMMExecuteTimeConfigs
            // 
            this.fld_btnMMExecuteTimeConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMMExecuteTimeConfigs.BOSComment = null;
            this.fld_btnMMExecuteTimeConfigs.BOSDataMember = null;
            this.fld_btnMMExecuteTimeConfigs.BOSDataSource = null;
            this.fld_btnMMExecuteTimeConfigs.BOSDescription = null;
            this.fld_btnMMExecuteTimeConfigs.BOSError = null;
            this.fld_btnMMExecuteTimeConfigs.BOSFieldGroup = null;
            this.fld_btnMMExecuteTimeConfigs.BOSFieldRelation = null;
            this.fld_btnMMExecuteTimeConfigs.BOSPrivilege = null;
            this.fld_btnMMExecuteTimeConfigs.BOSPropertyName = null;
            this.fld_btnMMExecuteTimeConfigs.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnMMExecuteTimeConfigs.Location = new System.Drawing.Point(980, 6);
            this.fld_btnMMExecuteTimeConfigs.Name = "fld_btnMMExecuteTimeConfigs";
            this.fld_btnMMExecuteTimeConfigs.Screen = null;
            this.fld_btnMMExecuteTimeConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnMMExecuteTimeConfigs.TabIndex = 1;
            this.fld_btnMMExecuteTimeConfigs.Text = "bosButton1";
            this.fld_btnMMExecuteTimeConfigs.Click += new System.EventHandler(this.fld_btnMMExecuteTimeConfigs_Click);
            // 
            // fld_dgcMMExecuteTimeConfig
            // 
            this.fld_dgcMMExecuteTimeConfig.AllowDrop = true;
            this.fld_dgcMMExecuteTimeConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMExecuteTimeConfig.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMExecuteTimeConfig.BOSDataMember = null;
            this.fld_dgcMMExecuteTimeConfig.BOSDataSource = "MMExecuteTimeConfigs";
            this.fld_dgcMMExecuteTimeConfig.BOSDescription = null;
            this.fld_dgcMMExecuteTimeConfig.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMExecuteTimeConfig.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMExecuteTimeConfig.BOSFieldRelation = null;
            this.fld_dgcMMExecuteTimeConfig.BOSGridType = null;
            this.fld_dgcMMExecuteTimeConfig.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMExecuteTimeConfig.BOSPropertyName = null;
            this.fld_dgcMMExecuteTimeConfig.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMExecuteTimeConfig.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMExecuteTimeConfig.Location = new System.Drawing.Point(3, 6);
            this.fld_dgcMMExecuteTimeConfig.MainView = this.gridView1;
            this.fld_dgcMMExecuteTimeConfig.Name = "fld_dgcMMExecuteTimeConfig";
            this.fld_dgcMMExecuteTimeConfig.PrintReport = false;
            this.fld_dgcMMExecuteTimeConfig.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMExecuteTimeConfig, true);
            this.fld_dgcMMExecuteTimeConfig.Size = new System.Drawing.Size(972, 439);
            this.fld_dgcMMExecuteTimeConfig.TabIndex = 0;
            this.fld_dgcMMExecuteTimeConfig.Tag = "DC";
            this.fld_dgcMMExecuteTimeConfig.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMExecuteTimeConfig;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_btnMMDepartmentAndOperations);
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMDepartmentAndOperations);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1014, 445);
            this.xtraTabPage3.Text = "Cấu hình Phân xưởng và công đoạn";
            // 
            // fld_btnMMDepartmentAndOperations
            // 
            this.fld_btnMMDepartmentAndOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMMDepartmentAndOperations.BOSComment = null;
            this.fld_btnMMDepartmentAndOperations.BOSDataMember = null;
            this.fld_btnMMDepartmentAndOperations.BOSDataSource = null;
            this.fld_btnMMDepartmentAndOperations.BOSDescription = null;
            this.fld_btnMMDepartmentAndOperations.BOSError = null;
            this.fld_btnMMDepartmentAndOperations.BOSFieldGroup = null;
            this.fld_btnMMDepartmentAndOperations.BOSFieldRelation = null;
            this.fld_btnMMDepartmentAndOperations.BOSPrivilege = null;
            this.fld_btnMMDepartmentAndOperations.BOSPropertyName = null;
            this.fld_btnMMDepartmentAndOperations.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnMMDepartmentAndOperations.Location = new System.Drawing.Point(980, 3);
            this.fld_btnMMDepartmentAndOperations.Name = "fld_btnMMDepartmentAndOperations";
            this.fld_btnMMDepartmentAndOperations.Screen = null;
            this.fld_btnMMDepartmentAndOperations.Size = new System.Drawing.Size(31, 30);
            this.fld_btnMMDepartmentAndOperations.TabIndex = 3;
            this.fld_btnMMDepartmentAndOperations.Text = "bosButton1";
            this.fld_btnMMDepartmentAndOperations.Click += new System.EventHandler(this.fld_btnMMDepartmentAndOperations_Click);
            // 
            // fld_dgcMMDepartmentAndOperations
            // 
            this.fld_dgcMMDepartmentAndOperations.AllowDrop = true;
            this.fld_dgcMMDepartmentAndOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDepartmentAndOperations.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentAndOperations.BOSDataMember = null;
            this.fld_dgcMMDepartmentAndOperations.BOSDataSource = "MMDepartmentAndOperations";
            this.fld_dgcMMDepartmentAndOperations.BOSDescription = null;
            this.fld_dgcMMDepartmentAndOperations.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentAndOperations.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentAndOperations.BOSFieldRelation = null;
            this.fld_dgcMMDepartmentAndOperations.BOSGridType = null;
            this.fld_dgcMMDepartmentAndOperations.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentAndOperations.BOSPropertyName = null;
            this.fld_dgcMMDepartmentAndOperations.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentAndOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMDepartmentAndOperations.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMDepartmentAndOperations.MainView = this.gridView2;
            this.fld_dgcMMDepartmentAndOperations.Name = "fld_dgcMMDepartmentAndOperations";
            this.fld_dgcMMDepartmentAndOperations.PrintReport = false;
            this.fld_dgcMMDepartmentAndOperations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMDepartmentAndOperations, true);
            this.fld_dgcMMDepartmentAndOperations.Size = new System.Drawing.Size(972, 439);
            this.fld_dgcMMDepartmentAndOperations.TabIndex = 2;
            this.fld_dgcMMDepartmentAndOperations.Tag = "DC";
            this.fld_dgcMMDepartmentAndOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMDepartmentAndOperations;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_btnSaveMMDepartmentCapacityConfigs);
            this.xtraTabPage4.Controls.Add(this.fld_dgcMMDepartmentCapacityConfigs);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1014, 445);
            this.xtraTabPage4.Text = "Cấu hình năng suất phân xưởng";
            // 
            // fld_btnSaveMMDepartmentCapacityConfigs
            // 
            this.fld_btnSaveMMDepartmentCapacityConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSComment = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSDataMember = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSDataSource = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSDescription = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSError = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSFieldGroup = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSFieldRelation = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSPrivilege = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.BOSPropertyName = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveMMDepartmentCapacityConfigs.Location = new System.Drawing.Point(980, 3);
            this.fld_btnSaveMMDepartmentCapacityConfigs.Name = "fld_btnSaveMMDepartmentCapacityConfigs";
            this.fld_btnSaveMMDepartmentCapacityConfigs.Screen = null;
            this.fld_btnSaveMMDepartmentCapacityConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveMMDepartmentCapacityConfigs.TabIndex = 5;
            this.fld_btnSaveMMDepartmentCapacityConfigs.Text = "bosButton1";
            this.fld_btnSaveMMDepartmentCapacityConfigs.Click += new System.EventHandler(this.fld_btnSaveMMDepartmentCapacityConfigs_Click);
            // 
            // fld_dgcMMDepartmentCapacityConfigs
            // 
            this.fld_dgcMMDepartmentCapacityConfigs.AllowDrop = true;
            this.fld_dgcMMDepartmentCapacityConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMDepartmentCapacityConfigs.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSDataMember = null;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSDataSource = "MMDepartmentCapacityConfigs";
            this.fld_dgcMMDepartmentCapacityConfigs.BOSDescription = null;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSFieldRelation = null;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSGridType = null;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentCapacityConfigs.BOSPropertyName = null;
            this.fld_dgcMMDepartmentCapacityConfigs.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMDepartmentCapacityConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMDepartmentCapacityConfigs.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMDepartmentCapacityConfigs.MainView = this.gridView3;
            this.fld_dgcMMDepartmentCapacityConfigs.Name = "fld_dgcMMDepartmentCapacityConfigs";
            this.fld_dgcMMDepartmentCapacityConfigs.PrintReport = false;
            this.fld_dgcMMDepartmentCapacityConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMDepartmentCapacityConfigs, true);
            this.fld_dgcMMDepartmentCapacityConfigs.Size = new System.Drawing.Size(972, 439);
            this.fld_dgcMMDepartmentCapacityConfigs.TabIndex = 4;
            this.fld_dgcMMDepartmentCapacityConfigs.Tag = "DC";
            this.fld_dgcMMDepartmentCapacityConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMDepartmentCapacityConfigs;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_btnMMProductGroupTypeSwitchingConfigs);
            this.xtraTabPage5.Controls.Add(this.fld_dgcMMProductGroupTypeSwitchingConfigs);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1014, 445);
            this.xtraTabPage5.Text = "Cấu hình loại thay thế";
            // 
            // fld_btnMMProductGroupTypeSwitchingConfigs
            // 
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSComment = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSDataMember = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSDataSource = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSDescription = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSError = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSFieldGroup = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSFieldRelation = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSPrivilege = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.BOSPropertyName = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Location = new System.Drawing.Point(980, 3);
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Name = "fld_btnMMProductGroupTypeSwitchingConfigs";
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Screen = null;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnMMProductGroupTypeSwitchingConfigs.TabIndex = 7;
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Text = "bosButton1";
            this.fld_btnMMProductGroupTypeSwitchingConfigs.Click += new System.EventHandler(this.fld_btnMMProductGroupTypeSwitchingConfigs_Click);
            // 
            // fld_dgcMMProductGroupTypeSwitchingConfigs
            // 
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.AllowDrop = true;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSDataMember = null;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSDataSource = "MMProductGroupTypeSwitchingConfigs";
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSDescription = null;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSFieldRelation = null;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSGridType = null;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.BOSPropertyName = null;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.MainView = this.gridView4;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Name = "fld_dgcMMProductGroupTypeSwitchingConfigs";
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.PrintReport = false;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProductGroupTypeSwitchingConfigs, true);
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Size = new System.Drawing.Size(972, 439);
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.TabIndex = 6;
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.Tag = "DC";
            this.fld_dgcMMProductGroupTypeSwitchingConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProductGroupTypeSwitchingConfigs;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // DMPC116
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1021, 474);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPC116";
            this.Text = "Cấu hình thời gian thực hiện theo công đoạn";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCompletionTimeConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMExecuteTimeConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentAndOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDepartmentCapacityConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductGroupTypeSwitchingConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMReuseSpecificateConfigs;
        private IContainer components;
        private MMProductionCompletionTimeConfigGridControl fld_dgcMMProductionCompletionTimeConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSaveMMProductionCompletionTimeConfigs;
        private BOSComponent.BOSButton fld_btnMMExecuteTimeConfigs;
        private MMExecuteTimeConfigGridControl fld_dgcMMExecuteTimeConfig;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSButton fld_btnMMDepartmentAndOperations;
        private MMDepartmentAndOperationsGridControl fld_dgcMMDepartmentAndOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSButton fld_btnSaveMMDepartmentCapacityConfigs;
        private MMDepartmentCapacityConfigsGridControl fld_dgcMMDepartmentCapacityConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private BOSComponent.BOSButton fld_btnMMProductGroupTypeSwitchingConfigs;
        private MMProductGroupTypeSwitchingConfigsGridControl fld_dgcMMProductGroupTypeSwitchingConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
	}
}
