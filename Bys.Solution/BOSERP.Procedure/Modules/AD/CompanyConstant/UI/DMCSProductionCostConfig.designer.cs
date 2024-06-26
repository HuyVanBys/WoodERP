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
    partial class DMCSProductionCostConfig
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.bosLine21 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMMProductionCostFactorGroups1 = new BOSERP.Modules.CompanyConstant.MMProductionCostFactorGroupsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveCustomerAccountConfig = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMMProductionCostLinkConfigs = new BOSERP.Modules.CompanyConstant.MMProductionCostLinkConfigsGridControl();
            this.fld_btnSaveProductionCostLinkConfigsList = new BOSComponent.BOSButton(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductionCostInProgressClassifyType = new BOSERP.Modules.CompanyConstant.ProductionCostInProgressClassifyTypeGridControl();
            this.fld_btnInProgressClassifyType = new BOSComponent.BOSButton(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductionCostInProgressCalType = new BOSERP.Modules.CompanyConstant.ProductionCostInProgressCalTypeGridControl();
            this.fld_btnInProgressCalType = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductionCostAllocationType = new BOSERP.Modules.CompanyConstant.ProductionCostAllocationTypeGridControl();
            this.fld_btnProductionCostAllocationType = new BOSComponent.BOSButton(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcProductionCostCollectType = new BOSERP.Modules.CompanyConstant.ProductionCostCollectTypeGridControl();
            this.fld_btnProductionCostCollectType = new BOSComponent.BOSButton(this.components);
            this.fld_tabFactor = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveFactor = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostFactors = new BOSERP.Modules.CompanyConstant.MMProductionCostFactorsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveAllocationRate = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostFactorAllocationRates = new BOSERP.Modules.CompanyConstant.MMProductionCostFactorAllocationRatesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactorGroups1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostLinkConfigs)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostInProgressClassifyType)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostInProgressCalType)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostAllocationType)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostCollectType)).BeginInit();
            this.fld_tabFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactorAllocationRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLine21
            // 
            this.bosLine21.BOSComment = null;
            this.bosLine21.BOSDataMember = null;
            this.bosLine21.BOSDataSource = null;
            this.bosLine21.BOSDescription = null;
            this.bosLine21.BOSError = null;
            this.bosLine21.BOSFieldGroup = null;
            this.bosLine21.BOSFieldRelation = null;
            this.bosLine21.BOSPrivilege = null;
            this.bosLine21.BOSPropertyName = null;
            this.bosLine21.Controls.Add(this.fld_dgcMMProductionCostFactorGroups1);
            this.bosLine21.Controls.Add(this.fld_btnSaveCustomerAccountConfig);
            this.bosLine21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine21.Location = new System.Drawing.Point(3, 3);
            this.bosLine21.Name = "bosLine21";
            this.bosLine21.Screen = null;
            this.bosLine21.Size = new System.Drawing.Size(377, 227);
            this.bosLine21.TabIndex = 0;
            this.bosLine21.TabStop = false;
            this.bosLine21.Text = "Nhóm yếu tố tính giá thành";
            // 
            // fld_dgcMMProductionCostFactorGroups1
            // 
            this.fld_dgcMMProductionCostFactorGroups1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostFactorGroups1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorGroups1.BOSDataMember = null;
            this.fld_dgcMMProductionCostFactorGroups1.BOSDataSource = "MMProductionCostFactorGroups";
            this.fld_dgcMMProductionCostFactorGroups1.BOSDescription = null;
            this.fld_dgcMMProductionCostFactorGroups1.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorGroups1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorGroups1.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostFactorGroups1.BOSGridType = null;
            this.fld_dgcMMProductionCostFactorGroups1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorGroups1.BOSPropertyName = null;
            this.fld_dgcMMProductionCostFactorGroups1.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorGroups1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostFactorGroups1.Location = new System.Drawing.Point(9, 20);
            this.fld_dgcMMProductionCostFactorGroups1.Name = "fld_dgcMMProductionCostFactorGroups1";
            this.fld_dgcMMProductionCostFactorGroups1.PrintReport = false;
            this.fld_dgcMMProductionCostFactorGroups1.Screen = null;
            this.fld_dgcMMProductionCostFactorGroups1.Size = new System.Drawing.Size(321, 201);
            this.fld_dgcMMProductionCostFactorGroups1.TabIndex = 0;
            this.fld_dgcMMProductionCostFactorGroups1.Tag = "DC";
            this.fld_dgcMMProductionCostFactorGroups1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMProductionCostFactorGroups1;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
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
            this.fld_btnSaveCustomerAccountConfig.Enabled = false;
            this.fld_btnSaveCustomerAccountConfig.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveCustomerAccountConfig.Location = new System.Drawing.Point(336, 20);
            this.fld_btnSaveCustomerAccountConfig.Name = "fld_btnSaveCustomerAccountConfig";
            this.fld_btnSaveCustomerAccountConfig.Screen = null;
            this.fld_btnSaveCustomerAccountConfig.Size = new System.Drawing.Size(35, 39);
            this.fld_btnSaveCustomerAccountConfig.TabIndex = 1;
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
            this.bosPanel1.Size = new System.Drawing.Size(1259, 692);
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
            this.fld_tabCompany.Size = new System.Drawing.Size(1259, 692);
            this.fld_tabCompany.TabIndex = 0;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabInfomation,
            this.fld_tabFactor,
            this.xtraTabPage1});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.AutoScroll = true;
            this.fld_tabInfomation.Controls.Add(this.bosGroupControl2);
            this.fld_tabInfomation.Controls.Add(this.bosLine21);
            this.fld_tabInfomation.Controls.Add(this.bosLine1);
            this.fld_tabInfomation.Controls.Add(this.bosLine4);
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(1252, 663);
            this.fld_tabInfomation.Text = "Chung";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.bosLine5);
            this.bosGroupControl2.Controls.Add(this.bosLine3);
            this.bosGroupControl2.Controls.Add(this.bosLine2);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 236);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(1242, 352);
            this.bosGroupControl2.TabIndex = 4;
            this.bosGroupControl2.Text = "Tính dở dang";
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
            this.bosLine5.Controls.Add(this.fld_dgcMMProductionCostLinkConfigs);
            this.bosLine5.Controls.Add(this.fld_btnSaveProductionCostLinkConfigsList);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(783, 25);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bosLine5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(453, 323);
            this.bosLine5.TabIndex = 1;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Liên kết phương pháp tính và phân loại";
            // 
            // fld_dgcMMProductionCostLinkConfigs
            // 
            this.fld_dgcMMProductionCostLinkConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostLinkConfigs.BOSComment = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSDataMember = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSDataSource = "MMProductionCostLinkConfigs";
            this.fld_dgcMMProductionCostLinkConfigs.BOSDescription = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSError = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSGridType = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSPrivilege = null;
            this.fld_dgcMMProductionCostLinkConfigs.BOSPropertyName = null;
            this.fld_dgcMMProductionCostLinkConfigs.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostLinkConfigs.Location = new System.Drawing.Point(9, 20);
            this.fld_dgcMMProductionCostLinkConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionCostLinkConfigs.Name = "fld_dgcMMProductionCostLinkConfigs";
            this.fld_dgcMMProductionCostLinkConfigs.PrintReport = false;
            this.fld_dgcMMProductionCostLinkConfigs.Screen = null;
            this.fld_dgcMMProductionCostLinkConfigs.Size = new System.Drawing.Size(397, 297);
            this.fld_dgcMMProductionCostLinkConfigs.TabIndex = 0;
            // 
            // fld_btnSaveProductionCostLinkConfigsList
            // 
            this.fld_btnSaveProductionCostLinkConfigsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveProductionCostLinkConfigsList.BOSComment = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSDataMember = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSDataSource = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSDescription = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSError = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSFieldGroup = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSFieldRelation = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSPrivilege = null;
            this.fld_btnSaveProductionCostLinkConfigsList.BOSPropertyName = null;
            this.fld_btnSaveProductionCostLinkConfigsList.Enabled = false;
            this.fld_btnSaveProductionCostLinkConfigsList.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveProductionCostLinkConfigsList.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnSaveProductionCostLinkConfigsList.Location = new System.Drawing.Point(411, 20);
            this.fld_btnSaveProductionCostLinkConfigsList.Name = "fld_btnSaveProductionCostLinkConfigsList";
            this.fld_btnSaveProductionCostLinkConfigsList.Screen = null;
            this.fld_btnSaveProductionCostLinkConfigsList.Size = new System.Drawing.Size(36, 34);
            this.fld_btnSaveProductionCostLinkConfigsList.TabIndex = 1;
            this.fld_btnSaveProductionCostLinkConfigsList.Click += new System.EventHandler(this.fld_btnSaveProductionCostLinkConfigsList_Click);
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
            this.bosLine3.Controls.Add(this.fld_dgcProductionCostInProgressClassifyType);
            this.bosLine3.Controls.Add(this.fld_btnInProgressClassifyType);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(9, 24);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bosLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(368, 323);
            this.bosLine3.TabIndex = 70;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Phân loại phương pháp tính dở dang";
            // 
            // fld_dgcProductionCostInProgressClassifyType
            // 
            this.fld_dgcProductionCostInProgressClassifyType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionCostInProgressClassifyType.BOSComment = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSDataMember = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductionCostInProgressClassifyType.BOSDescription = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSError = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSFieldGroup = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSFieldRelation = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSGridType = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSPrivilege = null;
            this.fld_dgcProductionCostInProgressClassifyType.BOSPropertyName = null;
            this.fld_dgcProductionCostInProgressClassifyType.CommodityType = global::Localization.CommonLocalizedResources.String2;
            gridLevelNode1.RelationName = "Level1";
            this.fld_dgcProductionCostInProgressClassifyType.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.fld_dgcProductionCostInProgressClassifyType.Location = new System.Drawing.Point(3, 20);
            this.fld_dgcProductionCostInProgressClassifyType.MenuManager = this.screenToolbar;
            this.fld_dgcProductionCostInProgressClassifyType.Name = "fld_dgcProductionCostInProgressClassifyType";
            this.fld_dgcProductionCostInProgressClassifyType.PrintReport = false;
            this.fld_dgcProductionCostInProgressClassifyType.Screen = null;
            this.fld_dgcProductionCostInProgressClassifyType.Size = new System.Drawing.Size(317, 297);
            this.fld_dgcProductionCostInProgressClassifyType.TabIndex = 0;
            // 
            // fld_btnInProgressClassifyType
            // 
            this.fld_btnInProgressClassifyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnInProgressClassifyType.BOSComment = null;
            this.fld_btnInProgressClassifyType.BOSDataMember = null;
            this.fld_btnInProgressClassifyType.BOSDataSource = null;
            this.fld_btnInProgressClassifyType.BOSDescription = null;
            this.fld_btnInProgressClassifyType.BOSError = null;
            this.fld_btnInProgressClassifyType.BOSFieldGroup = null;
            this.fld_btnInProgressClassifyType.BOSFieldRelation = null;
            this.fld_btnInProgressClassifyType.BOSPrivilege = null;
            this.fld_btnInProgressClassifyType.BOSPropertyName = null;
            this.fld_btnInProgressClassifyType.Enabled = false;
            this.fld_btnInProgressClassifyType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnInProgressClassifyType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnInProgressClassifyType.Location = new System.Drawing.Point(326, 20);
            this.fld_btnInProgressClassifyType.Name = "fld_btnInProgressClassifyType";
            this.fld_btnInProgressClassifyType.Screen = null;
            this.fld_btnInProgressClassifyType.Size = new System.Drawing.Size(36, 35);
            this.fld_btnInProgressClassifyType.TabIndex = 1;
            this.fld_btnInProgressClassifyType.Click += new System.EventHandler(this.fld_btnInProgressClassifyType_Click);
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
            this.bosLine2.Controls.Add(this.fld_dgcProductionCostInProgressCalType);
            this.bosLine2.Controls.Add(this.fld_btnInProgressCalType);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(383, 25);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bosLine2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(394, 323);
            this.bosLine2.TabIndex = 0;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Phương pháp tính dở dang cuối kỳ";
            // 
            // fld_dgcProductionCostInProgressCalType
            // 
            this.fld_dgcProductionCostInProgressCalType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionCostInProgressCalType.BOSComment = null;
            this.fld_dgcProductionCostInProgressCalType.BOSDataMember = null;
            this.fld_dgcProductionCostInProgressCalType.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductionCostInProgressCalType.BOSDescription = null;
            this.fld_dgcProductionCostInProgressCalType.BOSError = null;
            this.fld_dgcProductionCostInProgressCalType.BOSFieldGroup = null;
            this.fld_dgcProductionCostInProgressCalType.BOSFieldRelation = null;
            this.fld_dgcProductionCostInProgressCalType.BOSGridType = null;
            this.fld_dgcProductionCostInProgressCalType.BOSPrivilege = null;
            this.fld_dgcProductionCostInProgressCalType.BOSPropertyName = null;
            this.fld_dgcProductionCostInProgressCalType.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcProductionCostInProgressCalType.Location = new System.Drawing.Point(9, 20);
            this.fld_dgcProductionCostInProgressCalType.MenuManager = this.screenToolbar;
            this.fld_dgcProductionCostInProgressCalType.Name = "fld_dgcProductionCostInProgressCalType";
            this.fld_dgcProductionCostInProgressCalType.PrintReport = false;
            this.fld_dgcProductionCostInProgressCalType.Screen = null;
            this.fld_dgcProductionCostInProgressCalType.Size = new System.Drawing.Size(338, 297);
            this.fld_dgcProductionCostInProgressCalType.TabIndex = 0;
            // 
            // fld_btnInProgressCalType
            // 
            this.fld_btnInProgressCalType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnInProgressCalType.BOSComment = null;
            this.fld_btnInProgressCalType.BOSDataMember = null;
            this.fld_btnInProgressCalType.BOSDataSource = null;
            this.fld_btnInProgressCalType.BOSDescription = null;
            this.fld_btnInProgressCalType.BOSError = null;
            this.fld_btnInProgressCalType.BOSFieldGroup = null;
            this.fld_btnInProgressCalType.BOSFieldRelation = null;
            this.fld_btnInProgressCalType.BOSPrivilege = null;
            this.fld_btnInProgressCalType.BOSPropertyName = null;
            this.fld_btnInProgressCalType.Enabled = false;
            this.fld_btnInProgressCalType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnInProgressCalType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnInProgressCalType.Location = new System.Drawing.Point(352, 20);
            this.fld_btnInProgressCalType.Name = "fld_btnInProgressCalType";
            this.fld_btnInProgressCalType.Screen = null;
            this.fld_btnInProgressCalType.Size = new System.Drawing.Size(36, 34);
            this.fld_btnInProgressCalType.TabIndex = 1;
            this.fld_btnInProgressCalType.Click += new System.EventHandler(this.fld_btnInProgressCalType_Click);
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
            this.bosLine1.Controls.Add(this.fld_dgcProductionCostAllocationType);
            this.bosLine1.Controls.Add(this.fld_btnProductionCostAllocationType);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(786, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bosLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(459, 227);
            this.bosLine1.TabIndex = 2;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Cách phân bổ";
            // 
            // fld_dgcProductionCostAllocationType
            // 
            this.fld_dgcProductionCostAllocationType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionCostAllocationType.BOSComment = null;
            this.fld_dgcProductionCostAllocationType.BOSDataMember = null;
            this.fld_dgcProductionCostAllocationType.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductionCostAllocationType.BOSDescription = null;
            this.fld_dgcProductionCostAllocationType.BOSError = null;
            this.fld_dgcProductionCostAllocationType.BOSFieldGroup = null;
            this.fld_dgcProductionCostAllocationType.BOSFieldRelation = null;
            this.fld_dgcProductionCostAllocationType.BOSGridType = null;
            this.fld_dgcProductionCostAllocationType.BOSPrivilege = null;
            this.fld_dgcProductionCostAllocationType.BOSPropertyName = null;
            this.fld_dgcProductionCostAllocationType.CommodityType = global::Localization.CommonLocalizedResources.String2;
            gridLevelNode2.RelationName = "Level1";
            this.fld_dgcProductionCostAllocationType.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.fld_dgcProductionCostAllocationType.Location = new System.Drawing.Point(9, 20);
            this.fld_dgcProductionCostAllocationType.MenuManager = this.screenToolbar;
            this.fld_dgcProductionCostAllocationType.Name = "fld_dgcProductionCostAllocationType";
            this.fld_dgcProductionCostAllocationType.PrintReport = false;
            this.fld_dgcProductionCostAllocationType.Screen = null;
            this.fld_dgcProductionCostAllocationType.Size = new System.Drawing.Size(397, 201);
            this.fld_dgcProductionCostAllocationType.TabIndex = 0;
            // 
            // fld_btnProductionCostAllocationType
            // 
            this.fld_btnProductionCostAllocationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnProductionCostAllocationType.BOSComment = null;
            this.fld_btnProductionCostAllocationType.BOSDataMember = null;
            this.fld_btnProductionCostAllocationType.BOSDataSource = null;
            this.fld_btnProductionCostAllocationType.BOSDescription = null;
            this.fld_btnProductionCostAllocationType.BOSError = null;
            this.fld_btnProductionCostAllocationType.BOSFieldGroup = null;
            this.fld_btnProductionCostAllocationType.BOSFieldRelation = null;
            this.fld_btnProductionCostAllocationType.BOSPrivilege = null;
            this.fld_btnProductionCostAllocationType.BOSPropertyName = null;
            this.fld_btnProductionCostAllocationType.Enabled = false;
            this.fld_btnProductionCostAllocationType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnProductionCostAllocationType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnProductionCostAllocationType.Location = new System.Drawing.Point(411, 20);
            this.fld_btnProductionCostAllocationType.Name = "fld_btnProductionCostAllocationType";
            this.fld_btnProductionCostAllocationType.Screen = null;
            this.fld_btnProductionCostAllocationType.Size = new System.Drawing.Size(38, 39);
            this.fld_btnProductionCostAllocationType.TabIndex = 1;
            this.fld_btnProductionCostAllocationType.Click += new System.EventHandler(this.fld_btnProductionCostAllocationType_Click);
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
            this.bosLine4.Controls.Add(this.fld_dgcProductionCostCollectType);
            this.bosLine4.Controls.Add(this.fld_btnProductionCostCollectType);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(386, 3);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bosLine4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(394, 227);
            this.bosLine4.TabIndex = 1;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Cách tập hợp";
            // 
            // fld_dgcProductionCostCollectType
            // 
            this.fld_dgcProductionCostCollectType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionCostCollectType.BOSComment = null;
            this.fld_dgcProductionCostCollectType.BOSDataMember = null;
            this.fld_dgcProductionCostCollectType.BOSDataSource = "ADConfigValues";
            this.fld_dgcProductionCostCollectType.BOSDescription = null;
            this.fld_dgcProductionCostCollectType.BOSError = null;
            this.fld_dgcProductionCostCollectType.BOSFieldGroup = null;
            this.fld_dgcProductionCostCollectType.BOSFieldRelation = null;
            this.fld_dgcProductionCostCollectType.BOSGridType = null;
            this.fld_dgcProductionCostCollectType.BOSPrivilege = null;
            this.fld_dgcProductionCostCollectType.BOSPropertyName = null;
            this.fld_dgcProductionCostCollectType.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcProductionCostCollectType.Location = new System.Drawing.Point(9, 20);
            this.fld_dgcProductionCostCollectType.MenuManager = this.screenToolbar;
            this.fld_dgcProductionCostCollectType.Name = "fld_dgcProductionCostCollectType";
            this.fld_dgcProductionCostCollectType.PrintReport = false;
            this.fld_dgcProductionCostCollectType.Screen = null;
            this.fld_dgcProductionCostCollectType.Size = new System.Drawing.Size(338, 201);
            this.fld_dgcProductionCostCollectType.TabIndex = 0;
            // 
            // fld_btnProductionCostCollectType
            // 
            this.fld_btnProductionCostCollectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnProductionCostCollectType.BOSComment = null;
            this.fld_btnProductionCostCollectType.BOSDataMember = null;
            this.fld_btnProductionCostCollectType.BOSDataSource = null;
            this.fld_btnProductionCostCollectType.BOSDescription = null;
            this.fld_btnProductionCostCollectType.BOSError = null;
            this.fld_btnProductionCostCollectType.BOSFieldGroup = null;
            this.fld_btnProductionCostCollectType.BOSFieldRelation = null;
            this.fld_btnProductionCostCollectType.BOSPrivilege = null;
            this.fld_btnProductionCostCollectType.BOSPropertyName = null;
            this.fld_btnProductionCostCollectType.Enabled = false;
            this.fld_btnProductionCostCollectType.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnProductionCostCollectType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnProductionCostCollectType.Location = new System.Drawing.Point(352, 20);
            this.fld_btnProductionCostCollectType.Name = "fld_btnProductionCostCollectType";
            this.fld_btnProductionCostCollectType.Screen = null;
            this.fld_btnProductionCostCollectType.Size = new System.Drawing.Size(36, 39);
            this.fld_btnProductionCostCollectType.TabIndex = 1;
            this.fld_btnProductionCostCollectType.Click += new System.EventHandler(this.fld_btnProductionCostCollectType_Click);
            // 
            // fld_tabFactor
            // 
            this.fld_tabFactor.Controls.Add(this.fld_btnSaveFactor);
            this.fld_tabFactor.Controls.Add(this.fld_dgcMMProductionCostFactors);
            this.fld_tabFactor.Name = "fld_tabFactor";
            this.fld_tabFactor.Size = new System.Drawing.Size(1252, 663);
            this.fld_tabFactor.Text = "Yếu tố tính giá thành";
            // 
            // fld_btnSaveFactor
            // 
            this.fld_btnSaveFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveFactor.BOSComment = null;
            this.fld_btnSaveFactor.BOSDataMember = null;
            this.fld_btnSaveFactor.BOSDataSource = null;
            this.fld_btnSaveFactor.BOSDescription = null;
            this.fld_btnSaveFactor.BOSError = null;
            this.fld_btnSaveFactor.BOSFieldGroup = null;
            this.fld_btnSaveFactor.BOSFieldRelation = null;
            this.fld_btnSaveFactor.BOSPrivilege = null;
            this.fld_btnSaveFactor.BOSPropertyName = null;
            this.fld_btnSaveFactor.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveFactor.Location = new System.Drawing.Point(1207, 3);
            this.fld_btnSaveFactor.Name = "fld_btnSaveFactor";
            this.fld_btnSaveFactor.Screen = null;
            this.fld_btnSaveFactor.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveFactor.TabIndex = 8;
            this.fld_btnSaveFactor.Text = "bosButton1";
            this.fld_btnSaveFactor.Click += new System.EventHandler(this.fld_btnSaveFactor_Click);
            // 
            // fld_dgcMMProductionCostFactors
            // 
            this.fld_dgcMMProductionCostFactors.AllowDrop = true;
            this.fld_dgcMMProductionCostFactors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostFactors.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactors.BOSDataMember = null;
            this.fld_dgcMMProductionCostFactors.BOSDataSource = "MMProductionCostFactors";
            this.fld_dgcMMProductionCostFactors.BOSDescription = null;
            this.fld_dgcMMProductionCostFactors.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactors.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactors.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostFactors.BOSGridType = null;
            this.fld_dgcMMProductionCostFactors.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactors.BOSPropertyName = null;
            this.fld_dgcMMProductionCostFactors.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactors.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostFactors.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMProductionCostFactors.MainView = this.gridView1;
            this.fld_dgcMMProductionCostFactors.Name = "fld_dgcMMProductionCostFactors";
            this.fld_dgcMMProductionCostFactors.PrintReport = false;
            this.fld_dgcMMProductionCostFactors.Screen = null;
            this.fld_dgcMMProductionCostFactors.Size = new System.Drawing.Size(1198, 657);
            this.fld_dgcMMProductionCostFactors.TabIndex = 5;
            this.fld_dgcMMProductionCostFactors.Tag = "DC";
            this.fld_dgcMMProductionCostFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostFactors;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnSaveAllocationRate);
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostFactorAllocationRates);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1252, 663);
            this.xtraTabPage1.Text = "Cấu hình tỷ lệ cho chi phí chung";
            // 
            // fld_btnSaveAllocationRate
            // 
            this.fld_btnSaveAllocationRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveAllocationRate.BOSComment = null;
            this.fld_btnSaveAllocationRate.BOSDataMember = null;
            this.fld_btnSaveAllocationRate.BOSDataSource = null;
            this.fld_btnSaveAllocationRate.BOSDescription = null;
            this.fld_btnSaveAllocationRate.BOSError = null;
            this.fld_btnSaveAllocationRate.BOSFieldGroup = null;
            this.fld_btnSaveAllocationRate.BOSFieldRelation = null;
            this.fld_btnSaveAllocationRate.BOSPrivilege = null;
            this.fld_btnSaveAllocationRate.BOSPropertyName = null;
            this.fld_btnSaveAllocationRate.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveAllocationRate.Location = new System.Drawing.Point(1207, 3);
            this.fld_btnSaveAllocationRate.Name = "fld_btnSaveAllocationRate";
            this.fld_btnSaveAllocationRate.Screen = null;
            this.fld_btnSaveAllocationRate.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveAllocationRate.TabIndex = 10;
            this.fld_btnSaveAllocationRate.Text = "bosButton1";
            this.fld_btnSaveAllocationRate.Click += new System.EventHandler(this.fld_btnSaveAllocationRate_Click);
            // 
            // fld_dgcMMProductionCostFactorAllocationRates
            // 
            this.fld_dgcMMProductionCostFactorAllocationRates.AllowDrop = true;
            this.fld_dgcMMProductionCostFactorAllocationRates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSDataMember = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSDataSource = "MMProductionCostFactorAllocationRates";
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSDescription = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSGridType = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorAllocationRates.BOSPropertyName = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostFactorAllocationRates.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostFactorAllocationRates.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMProductionCostFactorAllocationRates.MainView = this.gridView2;
            this.fld_dgcMMProductionCostFactorAllocationRates.Name = "fld_dgcMMProductionCostFactorAllocationRates";
            this.fld_dgcMMProductionCostFactorAllocationRates.PrintReport = false;
            this.fld_dgcMMProductionCostFactorAllocationRates.Screen = null;
            this.fld_dgcMMProductionCostFactorAllocationRates.Size = new System.Drawing.Size(1198, 657);
            this.fld_dgcMMProductionCostFactorAllocationRates.TabIndex = 9;
            this.fld_dgcMMProductionCostFactorAllocationRates.Tag = "DC";
            this.fld_dgcMMProductionCostFactorAllocationRates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostFactorAllocationRates;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMCSProductionCostConfig
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1259, 692);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCSProductionCostConfig";
            this.Text = "Cấu hình Tính giá thành";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosLine21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactorGroups1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostLinkConfigs)).EndInit();
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostInProgressClassifyType)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostInProgressCalType)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostAllocationType)).EndInit();
            this.bosLine4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionCostCollectType)).EndInit();
            this.fld_tabFactor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFactorAllocationRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLine bosLine21;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSaveCustomerAccountConfig;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private BOSComponent.BOSLine bosLine4;
        private ProductionCostCollectTypeGridControl fld_dgcProductionCostCollectType;
        private BOSComponent.BOSButton fld_btnProductionCostCollectType;
        private BOSComponent.BOSLine bosLine1;
        private ProductionCostAllocationTypeGridControl fld_dgcProductionCostAllocationType;
        private BOSComponent.BOSButton fld_btnProductionCostAllocationType;
        private BOSComponent.BOSLine bosLine2;
        private ProductionCostInProgressCalTypeGridControl fld_dgcProductionCostInProgressCalType;
        private BOSComponent.BOSButton fld_btnInProgressCalType;
        private DevExpress.XtraTab.XtraTabPage fld_tabFactor;
        private BOSComponent.BOSButton fld_btnSaveFactor;
        private MMProductionCostFactorsGridControl fld_dgcMMProductionCostFactors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnSaveAllocationRate;
        private MMProductionCostFactorAllocationRatesGridControl fld_dgcMMProductionCostFactorAllocationRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MMProductionCostFactorGroupsGridControl fld_dgcMMProductionCostFactorGroups1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSButton fld_btnInProgressClassifyType;
        private ProductionCostInProgressClassifyTypeGridControl fld_dgcProductionCostInProgressClassifyType;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSButton fld_btnSaveProductionCostLinkConfigsList;
        private MMProductionCostLinkConfigsGridControl fld_dgcMMProductionCostLinkConfigs;
        private BOSComponent.BOSGroupControl bosGroupControl2;
    }
}