using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for DMPN100
	/// </summary>
	partial class DMPN100
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_txtMMProductionNormBlock = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnShowMoreProduct1s = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteMMProductionNormProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_txtMMProductionNormTotalPaint = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormProductLoadCont20DC = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionNormOldProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionNormOverallSize = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMProductionNormName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteMMProductionNormPromulgateDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMProductionNormVersion = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_tabProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdateCarcass = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreatePicture = new BOSComponent.BOSButton(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormSemiProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_btnCreateNewDetails = new BOSComponent.BOSButton(this.components);
            this.fld_trlMMProductionNormItems = new BOSERP.Modules.ProductionNorm.ProductionNormItemsTreeListControl();
            this.fld_btnChoossePaintA = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateWood = new BOSComponent.BOSButton(this.components);
            this.fld_btnCreateNewDetail = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMProductionNormWoodStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionNormDepreciationRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabHardware = new DevExpress.XtraTab.XtraTabPage();
            this.grcHw = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlMMProductionNormItemsHardwareCarcass = new BOSERP.Modules.ProductionNorm.ProductionNormItemsHardwareCarcassTreeListControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeICProductHardwareID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteMMProductionNormsProductItemPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_btnChangeHardware = new BOSComponent.BOSButton(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlMMProductionNormItemsHardware = new BOSERP.Modules.ProductionNorm.ProductionNormItemsHardwareTreeListControl();
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormHardwareDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeMMProductionNormHardwareStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPaint = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormIngredientPaintDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeICProductIngredientPaintID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlMMProductionNormItemsPaint = new BOSERP.Modules.ProductionNorm.ProductionNormItemsPaintTreeListControl();
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMPaintProcessesID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkePackaging = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionNormIngredientPackagingDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_btnPLDGAddChild = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddFromProduct = new BOSComponent.BOSButton(this.components);
            this.fld_btnPLDGAddParent = new BOSComponent.BOSButton(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlMMProductionNormItemsPackaging = new BOSERP.Modules.ProductionNorm.ProductionNormItemsPackagingTreeListControl();
            this.fld_lkeMMProductionNormPackingMaterialStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabGeneralMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionNormItems = new BOSERP.Modules.ProductionNorm.MMProductionNormItemsGridControl();
            this.fld_btnUpdateFromConfigMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductMaterialID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblMaterialProduct = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMProductionNormGeneralMaterialStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblMaterialStatus = new BOSComponent.BOSLabel(this.components);
            this.fld_tabOperation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdateFromConfig = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMProductionNormOperationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcProductionNormItemOperations = new BOSComponent.BOSGridControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dgcICProducts = new BOSERP.Modules.ProductionNorm.ProductsGridControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionNormItemCarcass = new BOSERP.Modules.ProductionNorm.MMProductionNormItemCarcassGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormTotalPaint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormProductLoadCont20DC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOldProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOverallSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormSemiProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormWoodStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormDepreciationRate.Properties)).BeginInit();
            this.fld_tabHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcHw)).BeginInit();
            this.grcHw.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardwareCarcass)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormsProductItemPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormHardwareDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormHardwareStatus.Properties)).BeginInit();
            this.fld_tabPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormIngredientPaintDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesID.Properties)).BeginInit();
            this.fld_tabPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormIngredientPackagingDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPackaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPackingMaterialStatus.Properties)).BeginInit();
            this.fld_tabGeneralMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties)).BeginInit();
            this.fld_tabOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormOperationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemOperations)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemCarcass)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1019, 692);
            this.splitContainerControl1.SplitterPosition = 154;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormBlock);
            this.panelControl1.Controls.Add(this.bosLabel12);
            this.panelControl1.Controls.Add(this.fld_btnShowMoreProduct1s);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.panelControl1.Controls.Add(this.fld_pteMMProductionNormProductPicture);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormTotalPaint);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormProductLoadCont20DC);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormOldProductNo);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormOverallSize);
            this.panelControl1.Controls.Add(this.bosLabel6);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_lkeMMProductionNormType);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormName);
            this.panelControl1.Controls.Add(this.bosLabel7);
            this.panelControl1.Controls.Add(this.fld_medMMProductionNormDesc);
            this.panelControl1.Controls.Add(this.bosLabel13);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel19);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormNo);
            this.panelControl1.Controls.Add(this.bosLabel14);
            this.panelControl1.Controls.Add(this.fld_lblLabel4);
            this.panelControl1.Controls.Add(this.bosLabel15);
            this.panelControl1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.panelControl1.Controls.Add(this.fld_dteMMProductionNormPromulgateDate);
            this.panelControl1.Controls.Add(this.fld_txtMMProductionNormVersion);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1019, 154);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_txtMMProductionNormBlock
            // 
            this.fld_txtMMProductionNormBlock.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormBlock.BOSDataMember = "MMProductionNormBlock";
            this.fld_txtMMProductionNormBlock.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormBlock.BOSDescription = null;
            this.fld_txtMMProductionNormBlock.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormBlock.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormBlock.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormBlock.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormBlock.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormBlock.Enabled = false;
            this.fld_txtMMProductionNormBlock.Location = new System.Drawing.Point(521, 57);
            this.fld_txtMMProductionNormBlock.Name = "fld_txtMMProductionNormBlock";
            this.fld_txtMMProductionNormBlock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormBlock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormBlock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormBlock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormBlock.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormBlock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormBlock.Screen = null;
            this.fld_txtMMProductionNormBlock.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormBlock.TabIndex = 8;
            this.fld_txtMMProductionNormBlock.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(436, 61);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(62, 13);
            this.bosLabel12.TabIndex = 126;
            this.bosLabel12.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Text = "Tổng m3 tinh";
            // 
            // fld_btnShowMoreProduct1s
            // 
            this.fld_btnShowMoreProduct1s.BOSComment = null;
            this.fld_btnShowMoreProduct1s.BOSDataMember = null;
            this.fld_btnShowMoreProduct1s.BOSDataSource = null;
            this.fld_btnShowMoreProduct1s.BOSDescription = null;
            this.fld_btnShowMoreProduct1s.BOSError = null;
            this.fld_btnShowMoreProduct1s.BOSFieldGroup = null;
            this.fld_btnShowMoreProduct1s.BOSFieldRelation = null;
            this.fld_btnShowMoreProduct1s.BOSPrivilege = null;
            this.fld_btnShowMoreProduct1s.BOSPropertyName = null;
            this.fld_btnShowMoreProduct1s.Location = new System.Drawing.Point(680, 5);
            this.fld_btnShowMoreProduct1s.Name = "fld_btnShowMoreProduct1s";
            this.fld_btnShowMoreProduct1s.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowMoreProduct1s, true);
            this.fld_btnShowMoreProduct1s.Size = new System.Drawing.Size(24, 20);
            this.fld_btnShowMoreProduct1s.TabIndex = 2;
            this.fld_btnShowMoreProduct1s.Text = "...";
            this.fld_btnShowMoreProduct1s.Click += new System.EventHandler(this.fld_btnShowMoreProduct1s_Click);
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(521, 5);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProoductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 1;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductID_CloseUp);
            this.fld_lkeFK_ICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ICProductID_QueryPopUp);
            this.fld_lkeFK_ICProductID.Popup += new System.EventHandler(this.fld_lkeFK_ICProductID_Popup);
            // 
            // fld_pteMMProductionNormProductPicture
            // 
            this.fld_pteMMProductionNormProductPicture.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSDataMember = "MMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormProductPicture.BOSDescription = null;
            this.fld_pteMMProductionNormProductPicture.BOSError = null;
            this.fld_pteMMProductionNormProductPicture.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormProductPicture.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormProductPicture.Location = new System.Drawing.Point(5, 5);
            this.fld_pteMMProductionNormProductPicture.Name = "fld_pteMMProductionNormProductPicture";
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteMMProductionNormProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteMMProductionNormProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteMMProductionNormProductPicture, true);
            this.fld_pteMMProductionNormProductPicture.Size = new System.Drawing.Size(120, 112);
            this.fld_pteMMProductionNormProductPicture.TabIndex = 101;
            this.fld_pteMMProductionNormProductPicture.Tag = "DC";
            // 
            // fld_txtMMProductionNormTotalPaint
            // 
            this.fld_txtMMProductionNormTotalPaint.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormTotalPaint.BOSDataMember = "MMProductionNormTotalPaint";
            this.fld_txtMMProductionNormTotalPaint.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormTotalPaint.BOSDescription = null;
            this.fld_txtMMProductionNormTotalPaint.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormTotalPaint.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormTotalPaint.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormTotalPaint.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormTotalPaint.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormTotalPaint.Location = new System.Drawing.Point(239, 58);
            this.fld_txtMMProductionNormTotalPaint.Name = "fld_txtMMProductionNormTotalPaint";
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormTotalPaint.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormTotalPaint.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormTotalPaint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormTotalPaint.Screen = null;
            this.fld_txtMMProductionNormTotalPaint.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormTotalPaint.TabIndex = 7;
            this.fld_txtMMProductionNormTotalPaint.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(137, 86);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(76, 13);
            this.bosLabel5.TabIndex = 122;
            this.bosLabel5.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.Text = "Ngày phát hành";
            // 
            // fld_txtMMProductionNormProductLoadCont20DC
            // 
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSDataMember = "MMProductionNormProductLoadCont20DC";
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSDescription = null;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormProductLoadCont20DC.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormProductLoadCont20DC.Location = new System.Drawing.Point(805, 57);
            this.fld_txtMMProductionNormProductLoadCont20DC.Name = "fld_txtMMProductionNormProductLoadCont20DC";
            this.fld_txtMMProductionNormProductLoadCont20DC.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormProductLoadCont20DC.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormProductLoadCont20DC.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormProductLoadCont20DC.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormProductLoadCont20DC.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormProductLoadCont20DC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormProductLoadCont20DC.Screen = null;
            this.fld_txtMMProductionNormProductLoadCont20DC.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormProductLoadCont20DC.TabIndex = 9;
            this.fld_txtMMProductionNormProductLoadCont20DC.Tag = "DC";
            // 
            // fld_txtMMProductionNormOldProductNo
            // 
            this.fld_txtMMProductionNormOldProductNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOldProductNo.BOSDataMember = "MMProductionNormOldProductNo";
            this.fld_txtMMProductionNormOldProductNo.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormOldProductNo.BOSDescription = null;
            this.fld_txtMMProductionNormOldProductNo.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOldProductNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOldProductNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOldProductNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOldProductNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormOldProductNo.Location = new System.Drawing.Point(805, 31);
            this.fld_txtMMProductionNormOldProductNo.Name = "fld_txtMMProductionNormOldProductNo";
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormOldProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormOldProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormOldProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormOldProductNo.Screen = null;
            this.fld_txtMMProductionNormOldProductNo.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormOldProductNo.TabIndex = 6;
            this.fld_txtMMProductionNormOldProductNo.Tag = "DC";
            // 
            // fld_txtMMProductionNormOverallSize
            // 
            this.fld_txtMMProductionNormOverallSize.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOverallSize.BOSDataMember = "MMProductionNormOverallSize";
            this.fld_txtMMProductionNormOverallSize.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormOverallSize.BOSDescription = null;
            this.fld_txtMMProductionNormOverallSize.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOverallSize.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOverallSize.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOverallSize.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormOverallSize.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormOverallSize.Location = new System.Drawing.Point(521, 31);
            this.fld_txtMMProductionNormOverallSize.Name = "fld_txtMMProductionNormOverallSize";
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormOverallSize.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormOverallSize.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormOverallSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormOverallSize.Screen = null;
            this.fld_txtMMProductionNormOverallSize.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormOverallSize.TabIndex = 5;
            this.fld_txtMMProductionNormOverallSize.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(728, 8);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 121;
            this.bosLabel6.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.Text = "Loại định mức";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(436, 8);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 124;
            this.bosLabel3.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // fld_lkeMMProductionNormType
            // 
            this.fld_lkeMMProductionNormType.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormType.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormType.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSDataMember = "MMProductionNormType";
            this.fld_lkeMMProductionNormType.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormType.BOSDescription = null;
            this.fld_lkeMMProductionNormType.BOSError = null;
            this.fld_lkeMMProductionNormType.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormType.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormType.Location = new System.Drawing.Point(805, 5);
            this.fld_lkeMMProductionNormType.Name = "fld_lkeMMProductionNormType";
            this.fld_lkeMMProductionNormType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionNormType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormType.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormType.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionNormType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormType.Screen = null;
            this.fld_lkeMMProductionNormType.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeMMProductionNormType.TabIndex = 3;
            this.fld_lkeMMProductionNormType.Tag = "DC";
            // 
            // fld_txtMMProductionNormName
            // 
            this.fld_txtMMProductionNormName.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormName.BOSDataMember = "MMProductionNormName";
            this.fld_txtMMProductionNormName.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormName.BOSDescription = null;
            this.fld_txtMMProductionNormName.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormName.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormName.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormName.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormName.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormName.Location = new System.Drawing.Point(239, 31);
            this.fld_txtMMProductionNormName.Name = "fld_txtMMProductionNormName";
            this.fld_txtMMProductionNormName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionNormName, true);
            this.fld_txtMMProductionNormName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormName.TabIndex = 4;
            this.fld_txtMMProductionNormName.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(436, 86);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(69, 13);
            this.bosLabel7.TabIndex = 120;
            this.bosLabel7.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.Text = "Lần phát hành";
            // 
            // fld_medMMProductionNormDesc
            // 
            this.fld_medMMProductionNormDesc.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormDesc.BOSDataMember = "MMProductionNormDesc";
            this.fld_medMMProductionNormDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormDesc.BOSDescription = null;
            this.fld_medMMProductionNormDesc.BOSError = null;
            this.fld_medMMProductionNormDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormDesc.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionNormDesc.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormDesc.Location = new System.Drawing.Point(805, 83);
            this.fld_medMMProductionNormDesc.Name = "fld_medMMProductionNormDesc";
            this.fld_medMMProductionNormDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionNormDesc, true);
            this.fld_medMMProductionNormDesc.Size = new System.Drawing.Size(183, 45);
            this.fld_medMMProductionNormDesc.TabIndex = 12;
            this.fld_medMMProductionNormDesc.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(728, 86);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(40, 13);
            this.bosLabel13.TabIndex = 125;
            this.bosLabel13.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel13.Text = "Diễn giải";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(728, 60);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(57, 13);
            this.bosLabel2.TabIndex = 119;
            this.bosLabel2.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Text = "PCS/Carton";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(728, 34);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(65, 13);
            this.bosLabel19.TabIndex = 118;
            this.bosLabel19.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel19.Text = "Mã SP HT cũ";
            // 
            // fld_txtMMProductionNormNo
            // 
            this.fld_txtMMProductionNormNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormNo.BOSDataMember = "MMProductionNormNo";
            this.fld_txtMMProductionNormNo.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormNo.BOSDescription = null;
            this.fld_txtMMProductionNormNo.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormNo.Location = new System.Drawing.Point(239, 5);
            this.fld_txtMMProductionNormNo.Name = "fld_txtMMProductionNormNo";
            this.fld_txtMMProductionNormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionNormNo, true);
            this.fld_txtMMProductionNormNo.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormNo.TabIndex = 0;
            this.fld_txtMMProductionNormNo.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(436, 34);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(56, 13);
            this.bosLabel14.TabIndex = 116;
            this.bosLabel14.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel14.Text = "KT tổng thể";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(137, 8);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 123;
            this.fld_lblLabel4.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseFont = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(137, 61);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(87, 13);
            this.bosLabel15.TabIndex = 117;
            this.bosLabel15.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel15.Text = "Tổng DT sơn (M2)";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMProductionNorms";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 123);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.MESLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 100;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_dteMMProductionNormPromulgateDate
            // 
            this.fld_dteMMProductionNormPromulgateDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionNormPromulgateDate.BOSDataMember = "MMProductionNormPromulgateDate";
            this.fld_dteMMProductionNormPromulgateDate.BOSDataSource = "MMProductionNorms";
            this.fld_dteMMProductionNormPromulgateDate.BOSDescription = null;
            this.fld_dteMMProductionNormPromulgateDate.BOSError = null;
            this.fld_dteMMProductionNormPromulgateDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionNormPromulgateDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionNormPromulgateDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMProductionNormPromulgateDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionNormPromulgateDate.EditValue = null;
            this.fld_dteMMProductionNormPromulgateDate.Location = new System.Drawing.Point(239, 83);
            this.fld_dteMMProductionNormPromulgateDate.Name = "fld_dteMMProductionNormPromulgateDate";
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionNormPromulgateDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionNormPromulgateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionNormPromulgateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionNormPromulgateDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionNormPromulgateDate, true);
            this.fld_dteMMProductionNormPromulgateDate.Size = new System.Drawing.Size(183, 20);
            this.fld_dteMMProductionNormPromulgateDate.TabIndex = 10;
            this.fld_dteMMProductionNormPromulgateDate.Tag = "DC";
            // 
            // fld_txtMMProductionNormVersion
            // 
            this.fld_txtMMProductionNormVersion.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormVersion.BOSDataMember = "MMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormVersion.BOSDescription = null;
            this.fld_txtMMProductionNormVersion.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormVersion.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormVersion.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormVersion.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormVersion.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormVersion.Location = new System.Drawing.Point(521, 83);
            this.fld_txtMMProductionNormVersion.Name = "fld_txtMMProductionNormVersion";
            this.fld_txtMMProductionNormVersion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormVersion.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormVersion.Screen = null;
            this.fld_txtMMProductionNormVersion.Size = new System.Drawing.Size(183, 20);
            this.fld_txtMMProductionNormVersion.TabIndex = 11;
            this.fld_txtMMProductionNormVersion.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(137, 34);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 115;
            this.bosLabel1.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_tabProductionNorm);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1019, 532);
            this.panelControl2.TabIndex = 0;
            // 
            // fld_tabProductionNorm
            // 
            this.fld_tabProductionNorm.BOSComment = null;
            this.fld_tabProductionNorm.BOSDataMember = null;
            this.fld_tabProductionNorm.BOSDataSource = null;
            this.fld_tabProductionNorm.BOSDescription = null;
            this.fld_tabProductionNorm.BOSError = null;
            this.fld_tabProductionNorm.BOSFieldGroup = null;
            this.fld_tabProductionNorm.BOSFieldRelation = null;
            this.fld_tabProductionNorm.BOSPrivilege = null;
            this.fld_tabProductionNorm.BOSPropertyName = null;
            this.fld_tabProductionNorm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(2, 2);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.Screen = null;
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabSemiProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabProductionNorm, true);
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(1015, 528);
            this.fld_tabProductionNorm.TabIndex = 2;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSemiProduct,
            this.fld_tabHardware,
            this.fld_tabPaint,
            this.fld_tabPackaging,
            this.fld_tabGeneralMaterial,
            this.fld_tabOperation,
            this.xtraTabPage1});
            this.fld_tabProductionNorm.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabProductionNorm_SelectedPageChanged);
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnUpdateCarcass);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnCreatePicture);
            this.fld_tabSemiProduct.Controls.Add(this.bosLabel20);
            this.fld_tabSemiProduct.Controls.Add(this.fld_medMMProductionNormSemiProductDesc);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnCreateNewDetails);
            this.fld_tabSemiProduct.Controls.Add(this.fld_trlMMProductionNormItems);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnChoossePaintA);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnUpdateWood);
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnCreateNewDetail);
            this.fld_tabSemiProduct.Controls.Add(this.fld_lkeMMProductionNormWoodStatus);
            this.fld_tabSemiProduct.Controls.Add(this.bosLabel8);
            this.fld_tabSemiProduct.Controls.Add(this.fld_txtMMProductionNormDepreciationRate);
            this.fld_tabSemiProduct.Controls.Add(this.bosLabel11);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabSemiProduct, true);
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabSemiProduct.Text = "ĐM Gổ";
            // 
            // fld_btnUpdateCarcass
            // 
            this.fld_btnUpdateCarcass.BOSComment = null;
            this.fld_btnUpdateCarcass.BOSDataMember = null;
            this.fld_btnUpdateCarcass.BOSDataSource = null;
            this.fld_btnUpdateCarcass.BOSDescription = null;
            this.fld_btnUpdateCarcass.BOSError = null;
            this.fld_btnUpdateCarcass.BOSFieldGroup = null;
            this.fld_btnUpdateCarcass.BOSFieldRelation = null;
            this.fld_btnUpdateCarcass.BOSPrivilege = null;
            this.fld_btnUpdateCarcass.BOSPropertyName = null;
            this.fld_btnUpdateCarcass.Location = new System.Drawing.Point(610, 15);
            this.fld_btnUpdateCarcass.Name = "fld_btnUpdateCarcass";
            this.fld_btnUpdateCarcass.Screen = null;
            this.fld_btnUpdateCarcass.Size = new System.Drawing.Size(124, 25);
            this.fld_btnUpdateCarcass.TabIndex = 128;
            this.fld_btnUpdateCarcass.Text = "Cập nhật Carcass";
            this.fld_btnUpdateCarcass.Click += new System.EventHandler(this.fld_btnUpdateCarcass_Click);
            // 
            // fld_btnCreatePicture
            // 
            this.fld_btnCreatePicture.BOSComment = null;
            this.fld_btnCreatePicture.BOSDataMember = null;
            this.fld_btnCreatePicture.BOSDataSource = null;
            this.fld_btnCreatePicture.BOSDescription = null;
            this.fld_btnCreatePicture.BOSError = null;
            this.fld_btnCreatePicture.BOSFieldGroup = null;
            this.fld_btnCreatePicture.BOSFieldRelation = null;
            this.fld_btnCreatePicture.BOSPrivilege = null;
            this.fld_btnCreatePicture.BOSPropertyName = null;
            this.fld_btnCreatePicture.Location = new System.Drawing.Point(740, 15);
            this.fld_btnCreatePicture.Name = "fld_btnCreatePicture";
            this.fld_btnCreatePicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCreatePicture, true);
            this.fld_btnCreatePicture.Size = new System.Drawing.Size(124, 25);
            this.fld_btnCreatePicture.TabIndex = 127;
            this.fld_btnCreatePicture.Text = "Thêm hình ảnh";
            this.fld_btnCreatePicture.Visible = false;
            this.fld_btnCreatePicture.Click += new System.EventHandler(this.fld_btnCreatePicture_Click);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(13, 41);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(40, 13);
            this.bosLabel20.TabIndex = 126;
            this.bosLabel20.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel20.Text = "Diễn giải";
            // 
            // fld_medMMProductionNormSemiProductDesc
            // 
            this.fld_medMMProductionNormSemiProductDesc.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormSemiProductDesc.BOSDataMember = "MMProductionNormSemiProductDesc";
            this.fld_medMMProductionNormSemiProductDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormSemiProductDesc.BOSDescription = null;
            this.fld_medMMProductionNormSemiProductDesc.BOSError = null;
            this.fld_medMMProductionNormSemiProductDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormSemiProductDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormSemiProductDesc.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormSemiProductDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionNormSemiProductDesc.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormSemiProductDesc.Location = new System.Drawing.Point(113, 38);
            this.fld_medMMProductionNormSemiProductDesc.Name = "fld_medMMProductionNormSemiProductDesc";
            this.fld_medMMProductionNormSemiProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormSemiProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormSemiProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormSemiProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormSemiProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionNormSemiProductDesc, true);
            this.fld_medMMProductionNormSemiProductDesc.Size = new System.Drawing.Size(485, 45);
            this.fld_medMMProductionNormSemiProductDesc.TabIndex = 93;
            this.fld_medMMProductionNormSemiProductDesc.Tag = "DC";
            // 
            // fld_btnCreateNewDetails
            // 
            this.fld_btnCreateNewDetails.BOSComment = null;
            this.fld_btnCreateNewDetails.BOSDataMember = null;
            this.fld_btnCreateNewDetails.BOSDataSource = null;
            this.fld_btnCreateNewDetails.BOSDescription = null;
            this.fld_btnCreateNewDetails.BOSError = null;
            this.fld_btnCreateNewDetails.BOSFieldGroup = null;
            this.fld_btnCreateNewDetails.BOSFieldRelation = null;
            this.fld_btnCreateNewDetails.BOSPrivilege = null;
            this.fld_btnCreateNewDetails.BOSPropertyName = null;
            this.fld_btnCreateNewDetails.Location = new System.Drawing.Point(870, 15);
            this.fld_btnCreateNewDetails.Name = "fld_btnCreateNewDetails";
            this.fld_btnCreateNewDetails.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCreateNewDetails, true);
            this.fld_btnCreateNewDetails.Size = new System.Drawing.Size(124, 25);
            this.fld_btnCreateNewDetails.TabIndex = 2;
            this.fld_btnCreateNewDetails.Text = "Tạo cụm/chi tiết mới";
            this.fld_btnCreateNewDetails.Visible = false;
            this.fld_btnCreateNewDetails.Click += new System.EventHandler(this.fld_btnCreateNewDetails_Click);
            // 
            // fld_trlMMProductionNormItems
            // 
            this.fld_trlMMProductionNormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItems.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItems.BOSDataMember = null;
            this.fld_trlMMProductionNormItems.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItems.BOSDescription = null;
            this.fld_trlMMProductionNormItems.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItems.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItems.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItems.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItems.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItems.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItems.BOSPropertyName = null;
            this.fld_trlMMProductionNormItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItems.Location = new System.Drawing.Point(1, 89);
            this.fld_trlMMProductionNormItems.Name = "fld_trlMMProductionNormItems";
            this.fld_trlMMProductionNormItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItems.Screen = null;
            this.fld_trlMMProductionNormItems.Size = new System.Drawing.Size(1007, 410);
            this.fld_trlMMProductionNormItems.TabIndex = 92;
            this.fld_trlMMProductionNormItems.Tag = "DC";
            this.fld_trlMMProductionNormItems.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMProductionNormItems_NodeCellStyle);
            this.fld_trlMMProductionNormItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fld_trlMMProductionNormItems_MouseDown);
            this.fld_trlMMProductionNormItems.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMProductionNormItems_CustomDrawNodeCell);
            this.fld_trlMMProductionNormItems.DragOver += new System.Windows.Forms.DragEventHandler(this.fld_trlMMProductionNormItems_DragOver);
            this.fld_trlMMProductionNormItems.LeftCoordChanged += new System.EventHandler(this.fld_trlMMProductionNormItems_LeftCoordChanged);
            this.fld_trlMMProductionNormItems.InvalidNodeException += new DevExpress.XtraTreeList.InvalidNodeExceptionEventHandler(this.fld_trlMMProductionNormItems_InvalidNodeException);
            this.fld_trlMMProductionNormItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItems_KeyUp);
            this.fld_trlMMProductionNormItems.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItems_CellValueChanged);
            this.fld_trlMMProductionNormItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fld_trlMMProductionNormItems_MouseMove);
            this.fld_trlMMProductionNormItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.fld_trlMMProductionNormItems_DragDrop);
            // 
            // fld_btnChoossePaintA
            // 
            this.fld_btnChoossePaintA.BOSComment = null;
            this.fld_btnChoossePaintA.BOSDataMember = null;
            this.fld_btnChoossePaintA.BOSDataSource = null;
            this.fld_btnChoossePaintA.BOSDescription = null;
            this.fld_btnChoossePaintA.BOSError = null;
            this.fld_btnChoossePaintA.BOSFieldGroup = null;
            this.fld_btnChoossePaintA.BOSFieldRelation = null;
            this.fld_btnChoossePaintA.BOSPrivilege = null;
            this.fld_btnChoossePaintA.BOSPropertyName = null;
            this.fld_btnChoossePaintA.Location = new System.Drawing.Point(870, 46);
            this.fld_btnChoossePaintA.Name = "fld_btnChoossePaintA";
            this.fld_btnChoossePaintA.Screen = null;
            this.fld_btnChoossePaintA.Size = new System.Drawing.Size(124, 25);
            this.fld_btnChoossePaintA.TabIndex = 1;
            this.fld_btnChoossePaintA.Text = "Chọn công thức sơn A (2m4c)";
            this.fld_btnChoossePaintA.Visible = false;
            this.fld_btnChoossePaintA.Click += new System.EventHandler(this.fld_btnChoossePaintA_Click);
            // 
            // fld_btnUpdateWood
            // 
            this.fld_btnUpdateWood.BOSComment = null;
            this.fld_btnUpdateWood.BOSDataMember = null;
            this.fld_btnUpdateWood.BOSDataSource = null;
            this.fld_btnUpdateWood.BOSDescription = null;
            this.fld_btnUpdateWood.BOSError = null;
            this.fld_btnUpdateWood.BOSFieldGroup = null;
            this.fld_btnUpdateWood.BOSFieldRelation = null;
            this.fld_btnUpdateWood.BOSPrivilege = null;
            this.fld_btnUpdateWood.BOSPropertyName = null;
            this.fld_btnUpdateWood.Location = new System.Drawing.Point(740, 46);
            this.fld_btnUpdateWood.Name = "fld_btnUpdateWood";
            this.fld_btnUpdateWood.Screen = null;
            this.fld_btnUpdateWood.Size = new System.Drawing.Size(124, 25);
            this.fld_btnUpdateWood.TabIndex = 1;
            this.fld_btnUpdateWood.Text = "Cập nhật NL";
            this.fld_btnUpdateWood.Visible = false;
            this.fld_btnUpdateWood.Click += new System.EventHandler(this.fld_btnUpdateWood_Click);
            // 
            // fld_btnCreateNewDetail
            // 
            this.fld_btnCreateNewDetail.BOSComment = null;
            this.fld_btnCreateNewDetail.BOSDataMember = null;
            this.fld_btnCreateNewDetail.BOSDataSource = null;
            this.fld_btnCreateNewDetail.BOSDescription = null;
            this.fld_btnCreateNewDetail.BOSError = null;
            this.fld_btnCreateNewDetail.BOSFieldGroup = null;
            this.fld_btnCreateNewDetail.BOSFieldRelation = null;
            this.fld_btnCreateNewDetail.BOSPrivilege = null;
            this.fld_btnCreateNewDetail.BOSPropertyName = null;
            this.fld_btnCreateNewDetail.Location = new System.Drawing.Point(610, 46);
            this.fld_btnCreateNewDetail.Name = "fld_btnCreateNewDetail";
            this.fld_btnCreateNewDetail.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCreateNewDetail, true);
            this.fld_btnCreateNewDetail.Size = new System.Drawing.Size(124, 25);
            this.fld_btnCreateNewDetail.TabIndex = 1;
            this.fld_btnCreateNewDetail.Text = "Thêm nguyên vật liệu";
            this.fld_btnCreateNewDetail.Visible = false;
            this.fld_btnCreateNewDetail.Click += new System.EventHandler(this.fld_btnCreateNewDetail_Click);
            // 
            // fld_lkeMMProductionNormWoodStatus
            // 
            this.fld_lkeMMProductionNormWoodStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormWoodStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormWoodStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSDataMember = "MMProductionNormWoodStatus";
            this.fld_lkeMMProductionNormWoodStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormWoodStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormWoodStatus.BOSError = null;
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormWoodStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormWoodStatus.Location = new System.Drawing.Point(413, 12);
            this.fld_lkeMMProductionNormWoodStatus.Name = "fld_lkeMMProductionNormWoodStatus";
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormWoodStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormWoodStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormWoodStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormWoodStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionNormWoodStatus, true);
            this.fld_lkeMMProductionNormWoodStatus.Size = new System.Drawing.Size(185, 20);
            this.fld_lkeMMProductionNormWoodStatus.TabIndex = 90;
            this.fld_lkeMMProductionNormWoodStatus.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(13, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(69, 13);
            this.bosLabel8.TabIndex = 78;
            this.bosLabel8.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.Text = "Hệ số tiêu hao";
            // 
            // fld_txtMMProductionNormDepreciationRate
            // 
            this.fld_txtMMProductionNormDepreciationRate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormDepreciationRate.BOSDataMember = "MMProductionNormDepreciationRate";
            this.fld_txtMMProductionNormDepreciationRate.BOSDataSource = "MMProductionNorms";
            this.fld_txtMMProductionNormDepreciationRate.BOSDescription = null;
            this.fld_txtMMProductionNormDepreciationRate.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormDepreciationRate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormDepreciationRate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormDepreciationRate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionNormDepreciationRate.BOSPropertyName = "Text";
            this.fld_txtMMProductionNormDepreciationRate.Location = new System.Drawing.Point(113, 12);
            this.fld_txtMMProductionNormDepreciationRate.Name = "fld_txtMMProductionNormDepreciationRate";
            this.fld_txtMMProductionNormDepreciationRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionNormDepreciationRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionNormDepreciationRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionNormDepreciationRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionNormDepreciationRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionNormDepreciationRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionNormDepreciationRate.Screen = null;
            this.fld_txtMMProductionNormDepreciationRate.Size = new System.Drawing.Size(174, 20);
            this.fld_txtMMProductionNormDepreciationRate.TabIndex = 0;
            this.fld_txtMMProductionNormDepreciationRate.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(347, 15);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(48, 13);
            this.bosLabel11.TabIndex = 81;
            this.bosLabel11.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.Text = "Trạng thái";
            // 
            // fld_tabHardware
            // 
            this.fld_tabHardware.Controls.Add(this.grcHw);
            this.fld_tabHardware.Controls.Add(this.bosLabel21);
            this.fld_tabHardware.Controls.Add(this.fld_medMMProductionNormHardwareDesc);
            this.fld_tabHardware.Controls.Add(this.fld_lkeMMProductionNormHardwareStatus);
            this.fld_tabHardware.Controls.Add(this.bosLabel9);
            this.fld_tabHardware.Name = "fld_tabHardware";
            this.ScreenHelper.SetShowHelp(this.fld_tabHardware, true);
            this.fld_tabHardware.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabHardware.Text = "ĐM Hardware";
            // 
            // grcHw
            // 
            this.grcHw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcHw.BOSComment = null;
            this.grcHw.BOSDataMember = null;
            this.grcHw.BOSDataSource = null;
            this.grcHw.BOSDescription = null;
            this.grcHw.BOSError = null;
            this.grcHw.BOSFieldGroup = null;
            this.grcHw.BOSFieldRelation = null;
            this.grcHw.BOSPrivilege = null;
            this.grcHw.BOSPropertyName = null;
            this.grcHw.Location = new System.Drawing.Point(0, 82);
            this.grcHw.Name = "grcHw";
            this.grcHw.Screen = null;
            this.grcHw.SelectedTabPage = this.xtraTabPage2;
            this.grcHw.Size = new System.Drawing.Size(1008, 417);
            this.grcHw.TabIndex = 131;
            this.grcHw.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_trlMMProductionNormItemsHardwareCarcass);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1001, 388);
            this.xtraTabPage2.Text = "Hardware theo mã Carcass";
            // 
            // fld_trlMMProductionNormItemsHardwareCarcass
            // 
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSDescription = null;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardwareCarcass.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsHardwareCarcass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlMMProductionNormItemsHardwareCarcass.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsHardwareCarcass.Location = new System.Drawing.Point(0, 0);
            this.fld_trlMMProductionNormItemsHardwareCarcass.Name = "fld_trlMMProductionNormItemsHardwareCarcass";
            this.fld_trlMMProductionNormItemsHardwareCarcass.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsHardwareCarcass.Screen = null;
            this.fld_trlMMProductionNormItemsHardwareCarcass.Size = new System.Drawing.Size(1001, 388);
            this.fld_trlMMProductionNormItemsHardwareCarcass.TabIndex = 103;
            this.fld_trlMMProductionNormItemsHardwareCarcass.Tag = "DC";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_lkeICProductHardwareID);
            this.xtraTabPage3.Controls.Add(this.fld_pteMMProductionNormsProductItemPicture);
            this.xtraTabPage3.Controls.Add(this.fld_btnChangeHardware);
            this.xtraTabPage3.Controls.Add(this.bosLabel16);
            this.xtraTabPage3.Controls.Add(this.fld_trlMMProductionNormItemsHardware);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1001, 388);
            this.xtraTabPage3.Text = "Hardware bổ sung";
            // 
            // fld_lkeICProductHardwareID
            // 
            this.fld_lkeICProductHardwareID.BOSAllowAddNew = false;
            this.fld_lkeICProductHardwareID.BOSAllowDummy = true;
            this.fld_lkeICProductHardwareID.BOSComment = null;
            this.fld_lkeICProductHardwareID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductHardwareID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductHardwareID.BOSDescription = null;
            this.fld_lkeICProductHardwareID.BOSError = null;
            this.fld_lkeICProductHardwareID.BOSFieldGroup = null;
            this.fld_lkeICProductHardwareID.BOSFieldParent = null;
            this.fld_lkeICProductHardwareID.BOSFieldRelation = null;
            this.fld_lkeICProductHardwareID.BOSPrivilege = null;
            this.fld_lkeICProductHardwareID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductHardwareID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductHardwareID.BOSSelectTypeValue = "Hardware;Equipment";
            this.fld_lkeICProductHardwareID.CurrentDisplayText = null;
            this.fld_lkeICProductHardwareID.Location = new System.Drawing.Point(64, 12);
            this.fld_lkeICProductHardwareID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductHardwareID.Name = "fld_lkeICProductHardwareID";
            this.fld_lkeICProductHardwareID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductHardwareID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductHardwareID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductHardwareID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductHardwareID.Screen = null;
            this.fld_lkeICProductHardwareID.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeICProductHardwareID.TabIndex = 124;
            this.fld_lkeICProductHardwareID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductHardwareID_KeyUp);
            this.fld_lkeICProductHardwareID.Popup += new System.EventHandler(this.fld_lkeICProductHardwareID_Popup);
            // 
            // fld_pteMMProductionNormsProductItemPicture
            // 
            this.fld_pteMMProductionNormsProductItemPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteMMProductionNormsProductItemPicture.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormsProductItemPicture.BOSDataMember = "MMProductionNormsProductItemPicture";
            this.fld_pteMMProductionNormsProductItemPicture.BOSDataSource = "MMProductionNorms";
            this.fld_pteMMProductionNormsProductItemPicture.BOSDescription = null;
            this.fld_pteMMProductionNormsProductItemPicture.BOSError = null;
            this.fld_pteMMProductionNormsProductItemPicture.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormsProductItemPicture.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormsProductItemPicture.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormsProductItemPicture.BOSPropertyName = "EditValue";
            this.fld_pteMMProductionNormsProductItemPicture.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_pteMMProductionNormsProductItemPicture.Location = new System.Drawing.Point(887, 40);
            this.fld_pteMMProductionNormsProductItemPicture.Name = "fld_pteMMProductionNormsProductItemPicture";
            this.fld_pteMMProductionNormsProductItemPicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteMMProductionNormsProductItemPicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteMMProductionNormsProductItemPicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteMMProductionNormsProductItemPicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteMMProductionNormsProductItemPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.fld_pteMMProductionNormsProductItemPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteMMProductionNormsProductItemPicture, true);
            this.fld_pteMMProductionNormsProductItemPicture.Size = new System.Drawing.Size(111, 68);
            this.fld_pteMMProductionNormsProductItemPicture.TabIndex = 129;
            this.fld_pteMMProductionNormsProductItemPicture.Tag = "DC";
            // 
            // fld_btnChangeHardware
            // 
            this.fld_btnChangeHardware.BOSComment = null;
            this.fld_btnChangeHardware.BOSDataMember = null;
            this.fld_btnChangeHardware.BOSDataSource = null;
            this.fld_btnChangeHardware.BOSDescription = null;
            this.fld_btnChangeHardware.BOSError = null;
            this.fld_btnChangeHardware.BOSFieldGroup = null;
            this.fld_btnChangeHardware.BOSFieldRelation = null;
            this.fld_btnChangeHardware.BOSPrivilege = null;
            this.fld_btnChangeHardware.BOSPropertyName = null;
            this.fld_btnChangeHardware.Location = new System.Drawing.Point(314, 9);
            this.fld_btnChangeHardware.Name = "fld_btnChangeHardware";
            this.fld_btnChangeHardware.Screen = null;
            this.fld_btnChangeHardware.Size = new System.Drawing.Size(124, 25);
            this.fld_btnChangeHardware.TabIndex = 130;
            this.fld_btnChangeHardware.Text = "Thay đổi hardware";
            this.fld_btnChangeHardware.Click += new System.EventHandler(this.fld_btnChangeHardware_Click);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(12, 15);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(46, 13);
            this.bosLabel16.TabIndex = 123;
            this.bosLabel16.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel16.Text = "Hardware";
            // 
            // fld_trlMMProductionNormItemsHardware
            // 
            this.fld_trlMMProductionNormItemsHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsHardware.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardware.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsHardware.BOSDescription = null;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsHardware.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsHardware.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardware.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardware.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsHardware.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsHardware.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsHardware.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsHardware.Location = new System.Drawing.Point(3, 40);
            this.fld_trlMMProductionNormItemsHardware.Name = "fld_trlMMProductionNormItemsHardware";
            this.fld_trlMMProductionNormItemsHardware.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsHardware.Screen = null;
            this.fld_trlMMProductionNormItemsHardware.Size = new System.Drawing.Size(878, 345);
            this.fld_trlMMProductionNormItemsHardware.TabIndex = 102;
            this.fld_trlMMProductionNormItemsHardware.Tag = "DC";
            this.fld_trlMMProductionNormItemsHardware.LeftCoordChanged += new System.EventHandler(this.fld_trlMMProductionNormItemsHardware_LeftCoordChanged);
            this.fld_trlMMProductionNormItemsHardware.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItemsHardware_KeyUp);
            this.fld_trlMMProductionNormItemsHardware.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsHardware_CellValueChanged);
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(12, 34);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(40, 13);
            this.bosLabel21.TabIndex = 128;
            this.bosLabel21.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel21.Text = "Diễn giải";
            // 
            // fld_medMMProductionNormHardwareDesc
            // 
            this.fld_medMMProductionNormHardwareDesc.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormHardwareDesc.BOSDataMember = "MMProductionNormHardwareDesc";
            this.fld_medMMProductionNormHardwareDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormHardwareDesc.BOSDescription = null;
            this.fld_medMMProductionNormHardwareDesc.BOSError = null;
            this.fld_medMMProductionNormHardwareDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormHardwareDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormHardwareDesc.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormHardwareDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionNormHardwareDesc.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormHardwareDesc.Location = new System.Drawing.Point(83, 31);
            this.fld_medMMProductionNormHardwareDesc.Name = "fld_medMMProductionNormHardwareDesc";
            this.fld_medMMProductionNormHardwareDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormHardwareDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormHardwareDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormHardwareDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormHardwareDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionNormHardwareDesc, true);
            this.fld_medMMProductionNormHardwareDesc.Size = new System.Drawing.Size(456, 45);
            this.fld_medMMProductionNormHardwareDesc.TabIndex = 127;
            this.fld_medMMProductionNormHardwareDesc.Tag = "DC";
            // 
            // fld_lkeMMProductionNormHardwareStatus
            // 
            this.fld_lkeMMProductionNormHardwareStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormHardwareStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormHardwareStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSDataMember = "MMProductionNormHardwareStatus";
            this.fld_lkeMMProductionNormHardwareStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormHardwareStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormHardwareStatus.BOSError = null;
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormHardwareStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormHardwareStatus.Location = new System.Drawing.Point(83, 5);
            this.fld_lkeMMProductionNormHardwareStatus.Name = "fld_lkeMMProductionNormHardwareStatus";
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormHardwareStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormHardwareStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormHardwareStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionNormHardwareStatus, true);
            this.fld_lkeMMProductionNormHardwareStatus.Size = new System.Drawing.Size(146, 20);
            this.fld_lkeMMProductionNormHardwareStatus.TabIndex = 101;
            this.fld_lkeMMProductionNormHardwareStatus.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(8, 8);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(48, 13);
            this.bosLabel9.TabIndex = 100;
            this.bosLabel9.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // fld_tabPaint
            // 
            this.fld_tabPaint.Controls.Add(this.bosLabel24);
            this.fld_tabPaint.Controls.Add(this.fld_medMMProductionNormIngredientPaintDesc);
            this.fld_tabPaint.Controls.Add(this.fld_lkeICProductIngredientPaintID);
            this.fld_tabPaint.Controls.Add(this.bosLabel17);
            this.fld_tabPaint.Controls.Add(this.fld_trlMMProductionNormItemsPaint);
            this.fld_tabPaint.Controls.Add(this.bosLookupEdit1);
            this.fld_tabPaint.Controls.Add(this.bosLabel22);
            this.fld_tabPaint.Controls.Add(this.fld_lkeMMPaintProcessesID);
            this.fld_tabPaint.Controls.Add(this.bosLabel4);
            this.fld_tabPaint.Name = "fld_tabPaint";
            this.fld_tabPaint.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabPaint.Text = "ĐM Sơn";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(6, 38);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(40, 13);
            this.bosLabel24.TabIndex = 128;
            this.bosLabel24.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel24.Text = "Diễn giải";
            // 
            // fld_medMMProductionNormIngredientPaintDesc
            // 
            this.fld_medMMProductionNormIngredientPaintDesc.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSDataMember = "MMProductionNormIngredientPaintDesc";
            this.fld_medMMProductionNormIngredientPaintDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormIngredientPaintDesc.BOSDescription = null;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSError = null;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPaintDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionNormIngredientPaintDesc.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPaintDesc.Location = new System.Drawing.Point(80, 35);
            this.fld_medMMProductionNormIngredientPaintDesc.Name = "fld_medMMProductionNormIngredientPaintDesc";
            this.fld_medMMProductionNormIngredientPaintDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormIngredientPaintDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormIngredientPaintDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormIngredientPaintDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormIngredientPaintDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionNormIngredientPaintDesc, true);
            this.fld_medMMProductionNormIngredientPaintDesc.Size = new System.Drawing.Size(414, 45);
            this.fld_medMMProductionNormIngredientPaintDesc.TabIndex = 127;
            this.fld_medMMProductionNormIngredientPaintDesc.Tag = "DC";
            // 
            // fld_lkeICProductIngredientPaintID
            // 
            this.fld_lkeICProductIngredientPaintID.BOSAllowAddNew = false;
            this.fld_lkeICProductIngredientPaintID.BOSAllowDummy = true;
            this.fld_lkeICProductIngredientPaintID.BOSComment = null;
            this.fld_lkeICProductIngredientPaintID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductIngredientPaintID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductIngredientPaintID.BOSDescription = null;
            this.fld_lkeICProductIngredientPaintID.BOSError = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldGroup = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldParent = null;
            this.fld_lkeICProductIngredientPaintID.BOSFieldRelation = null;
            this.fld_lkeICProductIngredientPaintID.BOSPrivilege = null;
            this.fld_lkeICProductIngredientPaintID.BOSPropertyName = null;
            this.fld_lkeICProductIngredientPaintID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductIngredientPaintID.BOSSelectTypeValue = "IngredientPaint;Equipment";
            this.fld_lkeICProductIngredientPaintID.CurrentDisplayText = null;
            this.fld_lkeICProductIngredientPaintID.Location = new System.Drawing.Point(549, 9);
            this.fld_lkeICProductIngredientPaintID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductIngredientPaintID.Name = "fld_lkeICProductIngredientPaintID";
            this.fld_lkeICProductIngredientPaintID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIngredientPaintID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductIngredientPaintID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductIngredientPaintID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductIngredientPaintID.Screen = null;
            this.fld_lkeICProductIngredientPaintID.Size = new System.Drawing.Size(255, 20);
            this.fld_lkeICProductIngredientPaintID.TabIndex = 126;
            this.fld_lkeICProductIngredientPaintID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductIngredientPaintID_KeyUp);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(516, 12);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(19, 13);
            this.bosLabel17.TabIndex = 125;
            this.bosLabel17.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel17.Text = "Sơn";
            this.bosLabel17.Visible = false;
            // 
            // fld_trlMMProductionNormItemsPaint
            // 
            this.fld_trlMMProductionNormItemsPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsPaint.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPaint.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsPaint.BOSDescription = null;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsPaint.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsPaint.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPaint.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPaint.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsPaint.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPaint.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsPaint.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsPaint.Location = new System.Drawing.Point(1, 84);
            this.fld_trlMMProductionNormItemsPaint.Name = "fld_trlMMProductionNormItemsPaint";
            this.fld_trlMMProductionNormItemsPaint.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsPaint.Screen = null;
            this.fld_trlMMProductionNormItemsPaint.Size = new System.Drawing.Size(1007, 415);
            this.fld_trlMMProductionNormItemsPaint.TabIndex = 104;
            this.fld_trlMMProductionNormItemsPaint.Tag = "DC";
            this.fld_trlMMProductionNormItemsPaint.LeftCoordChanged += new System.EventHandler(this.fld_trlMMProductionNormItemsPaint_LeftCoordChanged);
            this.fld_trlMMProductionNormItemsPaint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItemsPaint_KeyUp);
            this.fld_trlMMProductionNormItemsPaint.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsPaint_CellValueChanged);
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSDataMember = "MMProductionNormPaintStatus";
            this.bosLookupEdit1.BOSDataSource = "MMProductionNorms";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(80, 9);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.bosLookupEdit1.Properties.ReadOnly = true;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(148, 20);
            this.bosLookupEdit1.TabIndex = 103;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseFont = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(6, 12);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(48, 13);
            this.bosLabel22.TabIndex = 102;
            this.bosLabel22.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel22.Text = "Trạng thái";
            // 
            // fld_lkeMMPaintProcessesID
            // 
            this.fld_lkeMMPaintProcessesID.BOSAllowAddNew = false;
            this.fld_lkeMMPaintProcessesID.BOSAllowDummy = true;
            this.fld_lkeMMPaintProcessesID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSDataMember = "MMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.BOSDataSource = "MMPaintProcessess";
            this.fld_lkeMMPaintProcessesID.BOSDescription = null;
            this.fld_lkeMMPaintProcessesID.BOSError = null;
            this.fld_lkeMMPaintProcessesID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.CurrentDisplayText = null;
            this.fld_lkeMMPaintProcessesID.Location = new System.Drawing.Point(311, 9);
            this.fld_lkeMMPaintProcessesID.Name = "fld_lkeMMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMPaintProcessesID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMPaintProcessesID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPaintProcessesID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesNo", "Mã qui trình"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesPaintNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesPaintName", "Màu sơn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMPaintProcessesProductGroupName", "Hệ sơn")});
            this.fld_lkeMMPaintProcessesID.Properties.DisplayMember = "MMPaintProcessesDesc";
            this.fld_lkeMMPaintProcessesID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMPaintProcessesID.Properties.PopupWidth = 40;
            this.fld_lkeMMPaintProcessesID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMPaintProcessesID.Properties.ValueMember = "MMPaintProcessesID";
            this.fld_lkeMMPaintProcessesID.Screen = null;
            this.fld_lkeMMPaintProcessesID.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeMMPaintProcessesID.TabIndex = 2;
            this.fld_lkeMMPaintProcessesID.Tag = "DC";
            this.fld_lkeMMPaintProcessesID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMPaintProcessesID_KeyUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(244, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(59, 13);
            this.bosLabel4.TabIndex = 83;
            this.bosLabel4.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Text = "Qui trình sơn";
            // 
            // fld_tabPackaging
            // 
            this.fld_tabPackaging.Controls.Add(this.fld_lkePackaging);
            this.fld_tabPackaging.Controls.Add(this.bosLabel25);
            this.fld_tabPackaging.Controls.Add(this.fld_medMMProductionNormIngredientPackagingDesc);
            this.fld_tabPackaging.Controls.Add(this.fld_btnPLDGAddChild);
            this.fld_tabPackaging.Controls.Add(this.fld_btnAddFromProduct);
            this.fld_tabPackaging.Controls.Add(this.fld_btnPLDGAddParent);
            this.fld_tabPackaging.Controls.Add(this.bosLabel10);
            this.fld_tabPackaging.Controls.Add(this.fld_trlMMProductionNormItemsPackaging);
            this.fld_tabPackaging.Controls.Add(this.fld_lkeMMProductionNormPackingMaterialStatus);
            this.fld_tabPackaging.Controls.Add(this.bosLabel23);
            this.fld_tabPackaging.Name = "fld_tabPackaging";
            this.fld_tabPackaging.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabPackaging.Text = "ĐM Phụ liệu đóng gói";
            // 
            // fld_lkePackaging
            // 
            this.fld_lkePackaging.BOSAllowAddNew = false;
            this.fld_lkePackaging.BOSAllowDummy = true;
            this.fld_lkePackaging.BOSComment = null;
            this.fld_lkePackaging.BOSDataMember = "ICProductID";
            this.fld_lkePackaging.BOSDataSource = "ICProducts";
            this.fld_lkePackaging.BOSDescription = null;
            this.fld_lkePackaging.BOSError = null;
            this.fld_lkePackaging.BOSFieldGroup = null;
            this.fld_lkePackaging.BOSFieldParent = null;
            this.fld_lkePackaging.BOSFieldRelation = null;
            this.fld_lkePackaging.BOSPrivilege = null;
            this.fld_lkePackaging.BOSPropertyName = null;
            this.fld_lkePackaging.BOSSelectType = "ICProductType";
            this.fld_lkePackaging.BOSSelectTypeValue = "IngredientPackaging;Verneer;ArtificialBoard;Equipment";
            this.fld_lkePackaging.CurrentDisplayText = null;
            this.fld_lkePackaging.Location = new System.Drawing.Point(285, 9);
            this.fld_lkePackaging.MenuManager = this.screenToolbar;
            this.fld_lkePackaging.Name = "fld_lkePackaging";
            this.fld_lkePackaging.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePackaging.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkePackaging.Properties.DisplayMember = "ICProductName";
            this.fld_lkePackaging.Properties.ValueMember = "ICProductID";
            this.fld_lkePackaging.Screen = null;
            this.fld_lkePackaging.Size = new System.Drawing.Size(242, 20);
            this.fld_lkePackaging.TabIndex = 131;
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(13, 38);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, true);
            this.bosLabel25.Size = new System.Drawing.Size(40, 13);
            this.bosLabel25.TabIndex = 130;
            this.bosLabel25.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel25.Text = "Diễn giải";
            // 
            // fld_medMMProductionNormIngredientPackagingDesc
            // 
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSDataMember = "MMProductionNormIngredientPackagingDesc";
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSDataSource = "MMProductionNorms";
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSDescription = null;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSError = null;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPackagingDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionNormIngredientPackagingDesc.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionNormIngredientPackagingDesc.Location = new System.Drawing.Point(84, 35);
            this.fld_medMMProductionNormIngredientPackagingDesc.Name = "fld_medMMProductionNormIngredientPackagingDesc";
            this.fld_medMMProductionNormIngredientPackagingDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionNormIngredientPackagingDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionNormIngredientPackagingDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionNormIngredientPackagingDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionNormIngredientPackagingDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionNormIngredientPackagingDesc, true);
            this.fld_medMMProductionNormIngredientPackagingDesc.Size = new System.Drawing.Size(443, 45);
            this.fld_medMMProductionNormIngredientPackagingDesc.TabIndex = 129;
            this.fld_medMMProductionNormIngredientPackagingDesc.Tag = "DC";
            // 
            // fld_btnPLDGAddChild
            // 
            this.fld_btnPLDGAddChild.BOSComment = null;
            this.fld_btnPLDGAddChild.BOSDataMember = null;
            this.fld_btnPLDGAddChild.BOSDataSource = null;
            this.fld_btnPLDGAddChild.BOSDescription = null;
            this.fld_btnPLDGAddChild.BOSError = null;
            this.fld_btnPLDGAddChild.BOSFieldGroup = null;
            this.fld_btnPLDGAddChild.BOSFieldRelation = null;
            this.fld_btnPLDGAddChild.BOSPrivilege = null;
            this.fld_btnPLDGAddChild.BOSPropertyName = null;
            this.fld_btnPLDGAddChild.Location = new System.Drawing.Point(627, 3);
            this.fld_btnPLDGAddChild.Name = "fld_btnPLDGAddChild";
            this.fld_btnPLDGAddChild.Screen = null;
            this.fld_btnPLDGAddChild.Size = new System.Drawing.Size(91, 27);
            this.fld_btnPLDGAddChild.TabIndex = 126;
            this.fld_btnPLDGAddChild.Text = "Thêm con";
            this.fld_btnPLDGAddChild.Click += new System.EventHandler(this.fld_btnPLDGAddChild_Click);
            // 
            // fld_btnAddFromProduct
            // 
            this.fld_btnAddFromProduct.BOSComment = null;
            this.fld_btnAddFromProduct.BOSDataMember = null;
            this.fld_btnAddFromProduct.BOSDataSource = null;
            this.fld_btnAddFromProduct.BOSDescription = null;
            this.fld_btnAddFromProduct.BOSError = null;
            this.fld_btnAddFromProduct.BOSFieldGroup = null;
            this.fld_btnAddFromProduct.BOSFieldRelation = null;
            this.fld_btnAddFromProduct.BOSPrivilege = null;
            this.fld_btnAddFromProduct.BOSPropertyName = null;
            this.fld_btnAddFromProduct.Location = new System.Drawing.Point(734, 3);
            this.fld_btnAddFromProduct.Name = "fld_btnAddFromProduct";
            this.fld_btnAddFromProduct.Screen = null;
            this.fld_btnAddFromProduct.Size = new System.Drawing.Size(177, 27);
            this.fld_btnAddFromProduct.TabIndex = 125;
            this.fld_btnAddFromProduct.Text = "Thêm định mức từ SP";
            this.fld_btnAddFromProduct.Click += new System.EventHandler(this.fld_btnAddFromProduct_Click);
            // 
            // fld_btnPLDGAddParent
            // 
            this.fld_btnPLDGAddParent.BOSComment = null;
            this.fld_btnPLDGAddParent.BOSDataMember = null;
            this.fld_btnPLDGAddParent.BOSDataSource = null;
            this.fld_btnPLDGAddParent.BOSDescription = null;
            this.fld_btnPLDGAddParent.BOSError = null;
            this.fld_btnPLDGAddParent.BOSFieldGroup = null;
            this.fld_btnPLDGAddParent.BOSFieldRelation = null;
            this.fld_btnPLDGAddParent.BOSPrivilege = null;
            this.fld_btnPLDGAddParent.BOSPropertyName = null;
            this.fld_btnPLDGAddParent.Location = new System.Drawing.Point(540, 3);
            this.fld_btnPLDGAddParent.Name = "fld_btnPLDGAddParent";
            this.fld_btnPLDGAddParent.Screen = null;
            this.fld_btnPLDGAddParent.Size = new System.Drawing.Size(81, 27);
            this.fld_btnPLDGAddParent.TabIndex = 125;
            this.fld_btnPLDGAddParent.Text = "Thêm cha";
            this.fld_btnPLDGAddParent.Click += new System.EventHandler(this.fld_btnPLDGAddParent_Click);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(250, 12);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(29, 13);
            this.bosLabel10.TabIndex = 123;
            this.bosLabel10.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.Text = "PLDG";
            // 
            // fld_trlMMProductionNormItemsPackaging
            // 
            this.fld_trlMMProductionNormItemsPackaging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMProductionNormItemsPackaging.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPackaging.BOSDataMember = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSDataSource = "MMProductionNormItems";
            this.fld_trlMMProductionNormItemsPackaging.BOSDescription = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSDisplayOption = true;
            this.fld_trlMMProductionNormItemsPackaging.BOSDisplayRoot = false;
            this.fld_trlMMProductionNormItemsPackaging.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPackaging.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPackaging.BOSFieldRelation = null;
            this.fld_trlMMProductionNormItemsPackaging.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_trlMMProductionNormItemsPackaging.BOSPropertyName = null;
            this.fld_trlMMProductionNormItemsPackaging.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlMMProductionNormItemsPackaging.Location = new System.Drawing.Point(0, 86);
            this.fld_trlMMProductionNormItemsPackaging.Name = "fld_trlMMProductionNormItemsPackaging";
            this.fld_trlMMProductionNormItemsPackaging.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMProductionNormItemsPackaging.Screen = null;
            this.fld_trlMMProductionNormItemsPackaging.Size = new System.Drawing.Size(1007, 413);
            this.fld_trlMMProductionNormItemsPackaging.TabIndex = 103;
            this.fld_trlMMProductionNormItemsPackaging.Tag = "DC";
            this.fld_trlMMProductionNormItemsPackaging.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlMMProductionNormItemsPackaging_NodeCellStyle);
            this.fld_trlMMProductionNormItemsPackaging.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlMMProductionNormItemsPackaging_CustomDrawNodeCell);
            this.fld_trlMMProductionNormItemsPackaging.LeftCoordChanged += new System.EventHandler(this.fld_trlMMProductionNormItemsPackaging_LeftCoordChanged);
            this.fld_trlMMProductionNormItemsPackaging.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlMMProductionNormItemsPackaging_KeyUp);
            this.fld_trlMMProductionNormItemsPackaging.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlMMProductionNormItemsPackaging_CellValueChanged);
            // 
            // fld_lkeMMProductionNormPackingMaterialStatus
            // 
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDataMember = "MMProductionNormPackingMaterialStatus";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSError = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Location = new System.Drawing.Point(84, 9);
            this.fld_lkeMMProductionNormPackingMaterialStatus.Name = "fld_lkeMMProductionNormPackingMaterialStatus";
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Screen = null;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Size = new System.Drawing.Size(136, 20);
            this.fld_lkeMMProductionNormPackingMaterialStatus.TabIndex = 1;
            this.fld_lkeMMProductionNormPackingMaterialStatus.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(13, 12);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(48, 13);
            this.bosLabel23.TabIndex = 100;
            this.bosLabel23.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel23.Text = "Trạng thái";
            // 
            // fld_tabGeneralMaterial
            // 
            this.fld_tabGeneralMaterial.Controls.Add(this.bosTabControl1);
            this.fld_tabGeneralMaterial.Controls.Add(this.fld_lkeMMProductionNormGeneralMaterialStatus);
            this.fld_tabGeneralMaterial.Controls.Add(this.fld_lblMaterialStatus);
            this.fld_tabGeneralMaterial.Name = "fld_tabGeneralMaterial";
            this.fld_tabGeneralMaterial.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabGeneralMaterial.Text = "Vật tư khác";
            // 
            // fld_dgcMMProductionNormItems
            // 
            this.fld_dgcMMProductionNormItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionNormItems.BOSComment = null;
            this.fld_dgcMMProductionNormItems.BOSDataMember = null;
            this.fld_dgcMMProductionNormItems.BOSDataSource = "MMProductionNormItems";
            this.fld_dgcMMProductionNormItems.BOSDescription = null;
            this.fld_dgcMMProductionNormItems.BOSError = null;
            this.fld_dgcMMProductionNormItems.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItems.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItems.BOSGridType = null;
            this.fld_dgcMMProductionNormItems.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItems.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItems.Location = new System.Drawing.Point(0, 42);
            this.fld_dgcMMProductionNormItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItems.Name = "fld_dgcMMProductionNormItems";
            this.fld_dgcMMProductionNormItems.PrintReport = false;
            this.fld_dgcMMProductionNormItems.Screen = null;
            this.fld_dgcMMProductionNormItems.Size = new System.Drawing.Size(1001, 394);
            this.fld_dgcMMProductionNormItems.TabIndex = 136;
            // 
            // fld_btnUpdateFromConfigMaterial
            // 
            this.fld_btnUpdateFromConfigMaterial.BOSComment = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDataMember = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDataSource = null;
            this.fld_btnUpdateFromConfigMaterial.BOSDescription = null;
            this.fld_btnUpdateFromConfigMaterial.BOSError = null;
            this.fld_btnUpdateFromConfigMaterial.BOSFieldGroup = null;
            this.fld_btnUpdateFromConfigMaterial.BOSFieldRelation = null;
            this.fld_btnUpdateFromConfigMaterial.BOSPrivilege = null;
            this.fld_btnUpdateFromConfigMaterial.BOSPropertyName = null;
            this.fld_btnUpdateFromConfigMaterial.Location = new System.Drawing.Point(315, 5);
            this.fld_btnUpdateFromConfigMaterial.Name = "fld_btnUpdateFromConfigMaterial";
            this.fld_btnUpdateFromConfigMaterial.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateFromConfigMaterial, true);
            this.fld_btnUpdateFromConfigMaterial.Size = new System.Drawing.Size(124, 25);
            this.fld_btnUpdateFromConfigMaterial.TabIndex = 135;
            this.fld_btnUpdateFromConfigMaterial.Text = "Cập nhật cấu hình";
            this.fld_btnUpdateFromConfigMaterial.Click += new System.EventHandler(this.fld_btnUpdateFromConfigMaterial_Click);
            // 
            // fld_lkeICProductMaterialID
            // 
            this.fld_lkeICProductMaterialID.BOSAllowAddNew = false;
            this.fld_lkeICProductMaterialID.BOSAllowDummy = true;
            this.fld_lkeICProductMaterialID.BOSComment = null;
            this.fld_lkeICProductMaterialID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductMaterialID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductMaterialID.BOSDescription = null;
            this.fld_lkeICProductMaterialID.BOSError = null;
            this.fld_lkeICProductMaterialID.BOSFieldGroup = null;
            this.fld_lkeICProductMaterialID.BOSFieldParent = null;
            this.fld_lkeICProductMaterialID.BOSFieldRelation = null;
            this.fld_lkeICProductMaterialID.BOSPrivilege = null;
            this.fld_lkeICProductMaterialID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductMaterialID.BOSSelectType = "ICProductType";
            this.fld_lkeICProductMaterialID.BOSSelectTypeValue = "Hardware;IngredientPackaging;Verneer;ArtificialBoard;IngredientPaint;Equipment";
            this.fld_lkeICProductMaterialID.CurrentDisplayText = null;
            this.fld_lkeICProductMaterialID.Location = new System.Drawing.Point(60, 7);
            this.fld_lkeICProductMaterialID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductMaterialID.Name = "fld_lkeICProductMaterialID";
            this.fld_lkeICProductMaterialID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductMaterialID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductMaterialID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductMaterialID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductMaterialID.Screen = null;
            this.fld_lkeICProductMaterialID.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeICProductMaterialID.TabIndex = 132;
            this.fld_lkeICProductMaterialID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductMaterialID_KeyUp);
            // 
            // fld_lblMaterialProduct
            // 
            this.fld_lblMaterialProduct.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblMaterialProduct.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblMaterialProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblMaterialProduct.Appearance.Options.UseBackColor = true;
            this.fld_lblMaterialProduct.Appearance.Options.UseFont = true;
            this.fld_lblMaterialProduct.Appearance.Options.UseForeColor = true;
            this.fld_lblMaterialProduct.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSDescription = null;
            this.fld_lblMaterialProduct.BOSError = null;
            this.fld_lblMaterialProduct.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.BOSPropertyName = null;
            this.fld_lblMaterialProduct.Location = new System.Drawing.Point(8, 10);
            this.fld_lblMaterialProduct.Name = "fld_lblMaterialProduct";
            this.fld_lblMaterialProduct.Screen = null;
            this.fld_lblMaterialProduct.Size = new System.Drawing.Size(28, 13);
            this.fld_lblMaterialProduct.TabIndex = 131;
            this.fld_lblMaterialProduct.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialProduct.Text = "Vật tư";
            // 
            // fld_lkeMMProductionNormGeneralMaterialStatus
            // 
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDataMember = "MMProductionNormGeneralMaterialStatus";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSError = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Location = new System.Drawing.Point(85, 10);
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Name = "fld_lkeMMProductionNormGeneralMaterialStatus";
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionNormGeneralMaterialStatus, true);
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Size = new System.Drawing.Size(146, 20);
            this.fld_lkeMMProductionNormGeneralMaterialStatus.TabIndex = 130;
            this.fld_lkeMMProductionNormGeneralMaterialStatus.Tag = "DC";
            // 
            // fld_lblMaterialStatus
            // 
            this.fld_lblMaterialStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblMaterialStatus.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblMaterialStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblMaterialStatus.Appearance.Options.UseBackColor = true;
            this.fld_lblMaterialStatus.Appearance.Options.UseFont = true;
            this.fld_lblMaterialStatus.Appearance.Options.UseForeColor = true;
            this.fld_lblMaterialStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSDescription = null;
            this.fld_lblMaterialStatus.BOSError = null;
            this.fld_lblMaterialStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.BOSPropertyName = null;
            this.fld_lblMaterialStatus.Location = new System.Drawing.Point(10, 13);
            this.fld_lblMaterialStatus.Name = "fld_lblMaterialStatus";
            this.fld_lblMaterialStatus.Screen = null;
            this.fld_lblMaterialStatus.Size = new System.Drawing.Size(48, 13);
            this.fld_lblMaterialStatus.TabIndex = 129;
            this.fld_lblMaterialStatus.Tag = global::Localization.MESLocalizedResources.String1;
            this.fld_lblMaterialStatus.Text = "Trạng thái";
            // 
            // fld_tabOperation
            // 
            this.fld_tabOperation.Controls.Add(this.fld_btnUpdateFromConfig);
            this.fld_tabOperation.Controls.Add(this.fld_lkeMMProductionNormOperationStatus);
            this.fld_tabOperation.Controls.Add(this.bosLabel18);
            this.fld_tabOperation.Controls.Add(this.fld_dgcProductionNormItemOperations);
            this.fld_tabOperation.Name = "fld_tabOperation";
            this.fld_tabOperation.Size = new System.Drawing.Size(1008, 499);
            this.fld_tabOperation.Text = "ĐM Công đoạn";
            // 
            // fld_btnUpdateFromConfig
            // 
            this.fld_btnUpdateFromConfig.BOSComment = null;
            this.fld_btnUpdateFromConfig.BOSDataMember = null;
            this.fld_btnUpdateFromConfig.BOSDataSource = null;
            this.fld_btnUpdateFromConfig.BOSDescription = null;
            this.fld_btnUpdateFromConfig.BOSError = null;
            this.fld_btnUpdateFromConfig.BOSFieldGroup = null;
            this.fld_btnUpdateFromConfig.BOSFieldRelation = null;
            this.fld_btnUpdateFromConfig.BOSPrivilege = null;
            this.fld_btnUpdateFromConfig.BOSPropertyName = null;
            this.fld_btnUpdateFromConfig.Location = new System.Drawing.Point(259, 3);
            this.fld_btnUpdateFromConfig.Name = "fld_btnUpdateFromConfig";
            this.fld_btnUpdateFromConfig.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateFromConfig, true);
            this.fld_btnUpdateFromConfig.Size = new System.Drawing.Size(124, 25);
            this.fld_btnUpdateFromConfig.TabIndex = 106;
            this.fld_btnUpdateFromConfig.Text = "Cập nhật cấu hình";
            this.fld_btnUpdateFromConfig.Click += new System.EventHandler(this.fld_btnUpdateFromConfig_Click);
            // 
            // fld_lkeMMProductionNormOperationStatus
            // 
            this.fld_lkeMMProductionNormOperationStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionNormOperationStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionNormOperationStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSDataMember = "MMProductionNormOperationStatus";
            this.fld_lkeMMProductionNormOperationStatus.BOSDataSource = "MMProductionNorms";
            this.fld_lkeMMProductionNormOperationStatus.BOSDescription = null;
            this.fld_lkeMMProductionNormOperationStatus.BOSError = null;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionNormOperationStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionNormOperationStatus.Location = new System.Drawing.Point(84, 7);
            this.fld_lkeMMProductionNormOperationStatus.Name = "fld_lkeMMProductionNormOperationStatus";
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionNormOperationStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionNormOperationStatus.Properties.ReadOnly = true;
            this.fld_lkeMMProductionNormOperationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionNormOperationStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionNormOperationStatus, true);
            this.fld_lkeMMProductionNormOperationStatus.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeMMProductionNormOperationStatus.TabIndex = 105;
            this.fld_lkeMMProductionNormOperationStatus.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(10, 10);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 104;
            this.bosLabel18.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel18.Text = "Trạng thái";
            // 
            // fld_dgcProductionNormItemOperations
            // 
            this.fld_dgcProductionNormItemOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductionNormItemOperations.BOSComment = null;
            this.fld_dgcProductionNormItemOperations.BOSDataMember = null;
            this.fld_dgcProductionNormItemOperations.BOSDataSource = null;
            this.fld_dgcProductionNormItemOperations.BOSDescription = null;
            this.fld_dgcProductionNormItemOperations.BOSError = null;
            this.fld_dgcProductionNormItemOperations.BOSFieldGroup = null;
            this.fld_dgcProductionNormItemOperations.BOSFieldRelation = null;
            this.fld_dgcProductionNormItemOperations.BOSGridType = null;
            this.fld_dgcProductionNormItemOperations.BOSPrivilege = null;
            this.fld_dgcProductionNormItemOperations.BOSPropertyName = null;
            this.fld_dgcProductionNormItemOperations.Location = new System.Drawing.Point(0, 33);
            this.fld_dgcProductionNormItemOperations.MenuManager = this.screenToolbar;
            this.fld_dgcProductionNormItemOperations.Name = "fld_dgcProductionNormItemOperations";
            this.fld_dgcProductionNormItemOperations.PrintReport = false;
            this.fld_dgcProductionNormItemOperations.Screen = null;
            this.fld_dgcProductionNormItemOperations.Size = new System.Drawing.Size(1008, 466);
            this.fld_dgcProductionNormItemOperations.TabIndex = 94;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.PageVisible = false;
            this.xtraTabPage1.Size = new System.Drawing.Size(1008, 499);
            this.xtraTabPage1.Text = "Tạo BTP";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1008, 499);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.fld_btnSave);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(2, 459);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1004, 38);
            this.panelControl5.TabIndex = 1;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(930, 8);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSave, true);
            this.fld_btnSave.Size = new System.Drawing.Size(69, 25);
            this.fld_btnSave.TabIndex = 107;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Controls.Add(this.fld_dgcICProducts);
            this.panelControl4.Location = new System.Drawing.Point(1, 3);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1007, 453);
            this.panelControl4.TabIndex = 0;
            // 
            // fld_dgcICProducts
            // 
            this.fld_dgcICProducts.BOSComment = null;
            this.fld_dgcICProducts.BOSDataMember = null;
            this.fld_dgcICProducts.BOSDataSource = "ICProducts";
            this.fld_dgcICProducts.BOSDescription = null;
            this.fld_dgcICProducts.BOSError = null;
            this.fld_dgcICProducts.BOSFieldGroup = null;
            this.fld_dgcICProducts.BOSFieldRelation = null;
            this.fld_dgcICProducts.BOSGridType = null;
            this.fld_dgcICProducts.BOSPrivilege = null;
            this.fld_dgcICProducts.BOSPropertyName = null;
            this.fld_dgcICProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProducts.Location = new System.Drawing.Point(2, 2);
            this.fld_dgcICProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICProducts.Name = "fld_dgcICProducts";
            this.fld_dgcICProducts.PrintReport = false;
            this.fld_dgcICProducts.Screen = null;
            this.fld_dgcICProducts.Size = new System.Drawing.Size(1003, 449);
            this.fld_dgcICProducts.TabIndex = 2;
            this.fld_dgcICProducts.Tag = "DC";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 36);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage5;
            this.bosTabControl1.Size = new System.Drawing.Size(1008, 465);
            this.bosTabControl1.TabIndex = 137;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcMMProductionNormItemCarcass);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1001, 436);
            this.xtraTabPage4.Text = "Vật tư chung theo mã Carcass";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_dgcMMProductionNormItems);
            this.xtraTabPage5.Controls.Add(this.fld_btnUpdateFromConfigMaterial);
            this.xtraTabPage5.Controls.Add(this.fld_lkeICProductMaterialID);
            this.xtraTabPage5.Controls.Add(this.fld_lblMaterialProduct);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1001, 436);
            this.xtraTabPage5.Text = "Vật tư chung bổ sung";
            // 
            // fld_dgcMMProductionNormItemCarcass
            // 
            this.fld_dgcMMProductionNormItemCarcass.BOSComment = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSDataMember = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSDataSource = "MMProductionNormItems";
            this.fld_dgcMMProductionNormItemCarcass.BOSDescription = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSError = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSFieldGroup = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSGridType = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSPrivilege = null;
            this.fld_dgcMMProductionNormItemCarcass.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItemCarcass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionNormItemCarcass.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionNormItemCarcass.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionNormItemCarcass.Name = "fld_dgcMMProductionNormItemCarcass";
            this.fld_dgcMMProductionNormItemCarcass.PrintReport = false;
            this.fld_dgcMMProductionNormItemCarcass.Screen = null;
            this.fld_dgcMMProductionNormItemCarcass.Size = new System.Drawing.Size(1001, 436);
            this.fld_dgcMMProductionNormItemCarcass.TabIndex = 137;
            // 
            // DMPN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1019, 692);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DMPN100";
            this.Text = "Bảng định mức";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormTotalPaint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormProductLoadCont20DC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOldProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormOverallSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionNormPromulgateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabSemiProduct.ResumeLayout(false);
            this.fld_tabSemiProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormSemiProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormWoodStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionNormDepreciationRate.Properties)).EndInit();
            this.fld_tabHardware.ResumeLayout(false);
            this.fld_tabHardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcHw)).EndInit();
            this.grcHw.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardwareCarcass)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteMMProductionNormsProductItemPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsHardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormHardwareDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormHardwareStatus.Properties)).EndInit();
            this.fld_tabPaint.ResumeLayout(false);
            this.fld_tabPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormIngredientPaintDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPaintProcessesID.Properties)).EndInit();
            this.fld_tabPackaging.ResumeLayout(false);
            this.fld_tabPackaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionNormIngredientPackagingDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMProductionNormItemsPackaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormPackingMaterialStatus.Properties)).EndInit();
            this.fld_tabGeneralMaterial.ResumeLayout(false);
            this.fld_tabGeneralMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormGeneralMaterialStatus.Properties)).EndInit();
            this.fld_tabOperation.ResumeLayout(false);
            this.fld_tabOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionNormOperationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductionNormItemOperations)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemCarcass)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormBlock;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSButton fld_btnShowMoreProduct1s;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormProductPicture;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormTotalPaint;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormProductLoadCont20DC;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormOldProductNo;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormOverallSize;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormType;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormName;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormDesc;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormNo;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteMMProductionNormPromulgateDate;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormVersion;
        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private ProductionNormItemsTreeListControl fld_trlMMProductionNormItems;
        private BOSComponent.BOSButton fld_btnCreateNewDetail;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormWoodStatus;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtMMProductionNormDepreciationRate;
        private BOSComponent.BOSLabel bosLabel11;
        private DevExpress.XtraTab.XtraTabPage fld_tabHardware;
        private ProductionNormItemsHardwareTreeListControl fld_trlMMProductionNormItemsHardware;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormHardwareStatus;
        private BOSComponent.BOSLabel bosLabel9;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackaging;
        private ProductionNormItemsPackagingTreeListControl fld_trlMMProductionNormItemsPackaging;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormPackingMaterialStatus;
        private BOSComponent.BOSLabel bosLabel23;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaint;
        private ProductionNormItemsPaintTreeListControl fld_trlMMProductionNormItemsPaint;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeMMPaintProcessesID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnCreateNewDetails;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnPLDGAddChild;
        private BOSComponent.BOSButton fld_btnPLDGAddParent;
        private BOSComponent.BOSLookupEdit fld_lkeICProductHardwareID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIngredientPaintID;
        private BOSComponent.BOSLabel bosLabel17;
        private DevExpress.XtraTab.XtraTabPage fld_tabOperation;
        private BOSComponent.BOSGridControl fld_dgcProductionNormItemOperations;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormOperationStatus;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormSemiProductDesc;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormHardwareDesc;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormIngredientPaintDesc;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSMemoEdit fld_medMMProductionNormIngredientPackagingDesc;
        private BOSComponent.BOSPictureEdit fld_pteMMProductionNormsProductItemPicture;
        private BOSComponent.BOSButton fld_btnCreatePicture;
        private BOSComponent.BOSButton fld_btnChoossePaintA;
        private BOSComponent.BOSButton fld_btnUpdateFromConfig;
        private BOSComponent.BOSButton fld_btnUpdateWood;
        private BOSComponent.BOSLookupEdit fld_lkePackaging;
        private BOSComponent.BOSButton fld_btnUpdateCarcass;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private ProductsGridControl fld_dgcICProducts;
        private BOSComponent.BOSButton fld_btnSave;
        private DevExpress.XtraTab.XtraTabPage fld_tabGeneralMaterial;
        private BOSComponent.BOSLookupEdit fld_lkeICProductMaterialID;
        private BOSComponent.BOSLabel fld_lblMaterialProduct;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionNormGeneralMaterialStatus;
        private BOSComponent.BOSLabel fld_lblMaterialStatus;
        private BOSComponent.BOSButton fld_btnUpdateFromConfigMaterial;
        private MMProductionNormItemsGridControl fld_dgcMMProductionNormItems;
        private BOSComponent.BOSButton fld_btnAddFromProduct;
        private BOSComponent.BOSButton fld_btnChangeHardware;
        private BOSComponent.BOSTabControl grcHw;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ProductionNormItemsHardwareCarcassTreeListControl fld_trlMMProductionNormItemsHardwareCarcass;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private MMProductionNormItemCarcassGridControl fld_dgcMMProductionNormItemCarcass;

	}
}
