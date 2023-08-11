using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AllocationProposal.UI
{
	/// <summary>
	/// Summary description for DMAPL100
	/// </summary>
	partial class DMAPL100
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
            this.fld_dgvMMAllocationProposalWoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabProductionNorm = new DevExpress.XtraTab.XtraTabControl();
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnItemWood = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemWoodsGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemWoodsGridControl();
            this.fld_tabOtherMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomOtherMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemSteelsGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemSteelsGridControl();
            this.fld_tabHardware = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomItemHardware = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemHardwaresGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemHardwaresGridControl();
            this.fld_tabIngredientPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomItemPaint = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemPaintsGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemPaintsGridControl();
            this.fld_tabIngredientPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_showZoomItemPackaging = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemPackagingGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemPackagingsGridControl();
            this.fld_tabGeneralMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomItemInstrument = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemInstrumentsGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemInstrumentsGridControl();
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnZoomSemiProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAllocationPlanItemSemiGridControl = new BOSERP.Modules.AllocationProposal.MMAllocationPlanItemSemiProductGridControl();
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_btnUnApprove = new BOSComponent.BOSButton(this.components);
            this.fld_btnApprove = new BOSComponent.BOSButton(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_btnClosePlan = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateInventoryStock = new BOSComponent.BOSButton(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMAllocationPlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMAllocationPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteMMAllocationPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMAllocationPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeHRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeIDReceive = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdateOtherInfo = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnUnPlanned = new BOSComponent.BOSButton(this.components);
            this.fld_btnPlanned = new BOSComponent.BOSButton(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dteAllocationPlanDate = new DevExpress.XtraEditors.DateEdit();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdateItemPlanDate = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMAllocationProposalWoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemWoodsGridControl)).BeginInit();
            this.fld_tabOtherMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemSteelsGridControl)).BeginInit();
            this.fld_tabHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemHardwaresGridControl)).BeginInit();
            this.fld_tabIngredientPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemPaintsGridControl)).BeginInit();
            this.fld_tabIngredientPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemPackagingGridControl)).BeginInit();
            this.fld_tabGeneralMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemInstrumentsGridControl)).BeginInit();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemSemiGridControl)).BeginInit();
            this.bosLine4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMAllocationPlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMAllocationPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMAllocationPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMAllocationPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMAllocationPlanNo.Properties)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeIDReceive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAllocationPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAllocationPlanDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvMMAllocationProposalWoods
            // 
            this.fld_dgvMMAllocationProposalWoods.Name = "fld_dgvMMAllocationProposalWoods";
            this.fld_dgvMMAllocationProposalWoods.PaintStyleName = "Office2003";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // gridView5
            // 
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_tabProductionNorm);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Controls.Add(this.groupBox1);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.bosLine5);
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1348, 708);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_tabProductionNorm
            // 
            this.fld_tabProductionNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(9, 145);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabMaterial;
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(1324, 560);
            this.fld_tabProductionNorm.TabIndex = 134;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabMaterial,
            this.fld_tabOtherMaterial,
            this.fld_tabHardware,
            this.fld_tabIngredientPaint,
            this.fld_tabIngredientPackaging,
            this.fld_tabGeneralMaterial,
            this.fld_tabSemiProduct});
            this.fld_tabProductionNorm.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabProductionNorm_SelectedPageChanged);
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_btnItemWood);
            this.fld_tabMaterial.Controls.Add(this.fld_dgcAllocationPlanItemWoodsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(1318, 532);
            this.fld_tabMaterial.Text = "ĐM Nguyên liệu chính";
            // 
            // fld_btnItemWood
            // 
            this.fld_btnItemWood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnItemWood.BOSComment = null;
            this.fld_btnItemWood.BOSDataMember = null;
            this.fld_btnItemWood.BOSDataSource = null;
            this.fld_btnItemWood.BOSDescription = null;
            this.fld_btnItemWood.BOSError = null;
            this.fld_btnItemWood.BOSFieldGroup = null;
            this.fld_btnItemWood.BOSFieldRelation = null;
            this.fld_btnItemWood.BOSPrivilege = null;
            this.fld_btnItemWood.BOSPropertyName = null;
            this.fld_btnItemWood.Location = new System.Drawing.Point(1291, 6);
            this.fld_btnItemWood.Name = "fld_btnItemWood";
            this.fld_btnItemWood.Screen = null;
            this.fld_btnItemWood.Size = new System.Drawing.Size(22, 22);
            this.fld_btnItemWood.TabIndex = 408;
            this.fld_btnItemWood.Text = "❐";
            this.fld_btnItemWood.ToolTip = "Phóng to";
            this.fld_btnItemWood.Click += new System.EventHandler(this.Fld_btnItemWood_Click);
            // 
            // fld_dgcAllocationPlanItemWoodsGridControl
            // 
            this.fld_dgcAllocationPlanItemWoodsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemWoodsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemWoodsGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemWoodsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemWoodsGridControl.Name = "fld_dgcAllocationPlanItemWoodsGridControl";
            this.fld_dgcAllocationPlanItemWoodsGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemWoodsGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemWoodsGridControl.Size = new System.Drawing.Size(1307, 519);
            this.fld_dgcAllocationPlanItemWoodsGridControl.TabIndex = 26;
            // 
            // fld_tabOtherMaterial
            // 
            this.fld_tabOtherMaterial.Controls.Add(this.fld_btnZoomOtherMaterial);
            this.fld_tabOtherMaterial.Controls.Add(this.fld_dgcAllocationPlanItemSteelsGridControl);
            this.fld_tabOtherMaterial.Name = "fld_tabOtherMaterial";
            this.fld_tabOtherMaterial.Size = new System.Drawing.Size(1312, 525);
            this.fld_tabOtherMaterial.Text = "ĐM Nguyên phụ liệu";
            // 
            // fld_btnZoomOtherMaterial
            // 
            this.fld_btnZoomOtherMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomOtherMaterial.BOSComment = null;
            this.fld_btnZoomOtherMaterial.BOSDataMember = null;
            this.fld_btnZoomOtherMaterial.BOSDataSource = null;
            this.fld_btnZoomOtherMaterial.BOSDescription = null;
            this.fld_btnZoomOtherMaterial.BOSError = null;
            this.fld_btnZoomOtherMaterial.BOSFieldGroup = null;
            this.fld_btnZoomOtherMaterial.BOSFieldRelation = null;
            this.fld_btnZoomOtherMaterial.BOSPrivilege = null;
            this.fld_btnZoomOtherMaterial.BOSPropertyName = null;
            this.fld_btnZoomOtherMaterial.Location = new System.Drawing.Point(1283, 6);
            this.fld_btnZoomOtherMaterial.Name = "fld_btnZoomOtherMaterial";
            this.fld_btnZoomOtherMaterial.Screen = null;
            this.fld_btnZoomOtherMaterial.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomOtherMaterial.TabIndex = 408;
            this.fld_btnZoomOtherMaterial.Text = "❐";
            this.fld_btnZoomOtherMaterial.ToolTip = "Phóng to";
            this.fld_btnZoomOtherMaterial.Click += new System.EventHandler(this.Fld_btnZoomOtherMaterial_Click);
            // 
            // fld_dgcAllocationPlanItemSteelsGridControl
            // 
            this.fld_dgcAllocationPlanItemSteelsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemSteelsGridControl.Location = new System.Drawing.Point(7, 6);
            this.fld_dgcAllocationPlanItemSteelsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemSteelsGridControl.Name = "fld_dgcAllocationPlanItemSteelsGridControl";
            this.fld_dgcAllocationPlanItemSteelsGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemSteelsGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemSteelsGridControl.Size = new System.Drawing.Size(1298, 513);
            this.fld_dgcAllocationPlanItemSteelsGridControl.TabIndex = 1;
            // 
            // fld_tabHardware
            // 
            this.fld_tabHardware.Controls.Add(this.fld_btnZoomItemHardware);
            this.fld_tabHardware.Controls.Add(this.fld_dgcAllocationPlanItemHardwaresGridControl);
            this.fld_tabHardware.Name = "fld_tabHardware";
            this.fld_tabHardware.Size = new System.Drawing.Size(1312, 525);
            this.fld_tabHardware.Text = "ĐM Hardware";
            // 
            // fld_btnZoomItemHardware
            // 
            this.fld_btnZoomItemHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomItemHardware.BOSComment = null;
            this.fld_btnZoomItemHardware.BOSDataMember = null;
            this.fld_btnZoomItemHardware.BOSDataSource = null;
            this.fld_btnZoomItemHardware.BOSDescription = null;
            this.fld_btnZoomItemHardware.BOSError = null;
            this.fld_btnZoomItemHardware.BOSFieldGroup = null;
            this.fld_btnZoomItemHardware.BOSFieldRelation = null;
            this.fld_btnZoomItemHardware.BOSPrivilege = null;
            this.fld_btnZoomItemHardware.BOSPropertyName = null;
            this.fld_btnZoomItemHardware.Location = new System.Drawing.Point(1285, 6);
            this.fld_btnZoomItemHardware.Name = "fld_btnZoomItemHardware";
            this.fld_btnZoomItemHardware.Screen = null;
            this.fld_btnZoomItemHardware.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomItemHardware.TabIndex = 408;
            this.fld_btnZoomItemHardware.Text = "❐";
            this.fld_btnZoomItemHardware.ToolTip = "Phóng to";
            this.fld_btnZoomItemHardware.Click += new System.EventHandler(this.Fld_btnZoomItemHardware_Click);
            // 
            // fld_dgcAllocationPlanItemHardwaresGridControl
            // 
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemHardwaresGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Name = "fld_dgcAllocationPlanItemHardwaresGridControl";
            this.fld_dgcAllocationPlanItemHardwaresGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemHardwaresGridControl.Size = new System.Drawing.Size(1301, 512);
            this.fld_dgcAllocationPlanItemHardwaresGridControl.TabIndex = 27;
            // 
            // fld_tabIngredientPaint
            // 
            this.fld_tabIngredientPaint.Controls.Add(this.fld_btnZoomItemPaint);
            this.fld_tabIngredientPaint.Controls.Add(this.fld_dgcAllocationPlanItemPaintsGridControl);
            this.fld_tabIngredientPaint.Name = "fld_tabIngredientPaint";
            this.fld_tabIngredientPaint.Size = new System.Drawing.Size(1312, 525);
            this.fld_tabIngredientPaint.Text = "ĐM Sơn";
            // 
            // fld_btnZoomItemPaint
            // 
            this.fld_btnZoomItemPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomItemPaint.BOSComment = null;
            this.fld_btnZoomItemPaint.BOSDataMember = null;
            this.fld_btnZoomItemPaint.BOSDataSource = null;
            this.fld_btnZoomItemPaint.BOSDescription = null;
            this.fld_btnZoomItemPaint.BOSError = null;
            this.fld_btnZoomItemPaint.BOSFieldGroup = null;
            this.fld_btnZoomItemPaint.BOSFieldRelation = null;
            this.fld_btnZoomItemPaint.BOSPrivilege = null;
            this.fld_btnZoomItemPaint.BOSPropertyName = null;
            this.fld_btnZoomItemPaint.Location = new System.Drawing.Point(1286, 6);
            this.fld_btnZoomItemPaint.Name = "fld_btnZoomItemPaint";
            this.fld_btnZoomItemPaint.Screen = null;
            this.fld_btnZoomItemPaint.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomItemPaint.TabIndex = 408;
            this.fld_btnZoomItemPaint.Text = "❐";
            this.fld_btnZoomItemPaint.ToolTip = "Phóng to";
            this.fld_btnZoomItemPaint.Click += new System.EventHandler(this.Fld_btnZoomItemPaint_Click);
            // 
            // fld_dgcAllocationPlanItemPaintsGridControl
            // 
            this.fld_dgcAllocationPlanItemPaintsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemPaintsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemPaintsGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemPaintsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemPaintsGridControl.Name = "fld_dgcAllocationPlanItemPaintsGridControl";
            this.fld_dgcAllocationPlanItemPaintsGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemPaintsGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemPaintsGridControl.Size = new System.Drawing.Size(1301, 512);
            this.fld_dgcAllocationPlanItemPaintsGridControl.TabIndex = 27;
            // 
            // fld_tabIngredientPackaging
            // 
            this.fld_tabIngredientPackaging.Controls.Add(this.fld_showZoomItemPackaging);
            this.fld_tabIngredientPackaging.Controls.Add(this.fld_dgcAllocationPlanItemPackagingGridControl);
            this.fld_tabIngredientPackaging.Name = "fld_tabIngredientPackaging";
            this.fld_tabIngredientPackaging.Size = new System.Drawing.Size(1312, 525);
            this.fld_tabIngredientPackaging.Text = "ĐM Phụ liệu đóng gói";
            // 
            // fld_showZoomItemPackaging
            // 
            this.fld_showZoomItemPackaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_showZoomItemPackaging.BOSComment = null;
            this.fld_showZoomItemPackaging.BOSDataMember = null;
            this.fld_showZoomItemPackaging.BOSDataSource = null;
            this.fld_showZoomItemPackaging.BOSDescription = null;
            this.fld_showZoomItemPackaging.BOSError = null;
            this.fld_showZoomItemPackaging.BOSFieldGroup = null;
            this.fld_showZoomItemPackaging.BOSFieldRelation = null;
            this.fld_showZoomItemPackaging.BOSPrivilege = null;
            this.fld_showZoomItemPackaging.BOSPropertyName = null;
            this.fld_showZoomItemPackaging.Location = new System.Drawing.Point(1285, 6);
            this.fld_showZoomItemPackaging.Name = "fld_showZoomItemPackaging";
            this.fld_showZoomItemPackaging.Screen = null;
            this.fld_showZoomItemPackaging.Size = new System.Drawing.Size(22, 22);
            this.fld_showZoomItemPackaging.TabIndex = 408;
            this.fld_showZoomItemPackaging.Text = "❐";
            this.fld_showZoomItemPackaging.ToolTip = "Phóng to";
            this.fld_showZoomItemPackaging.Click += new System.EventHandler(this.Fld_showZoomItemPackaging_Click);
            // 
            // fld_dgcAllocationPlanItemPackagingGridControl
            // 
            this.fld_dgcAllocationPlanItemPackagingGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemPackagingGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemPackagingGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemPackagingGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemPackagingGridControl.Name = "fld_dgcAllocationPlanItemPackagingGridControl";
            this.fld_dgcAllocationPlanItemPackagingGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemPackagingGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemPackagingGridControl.Size = new System.Drawing.Size(1301, 512);
            this.fld_dgcAllocationPlanItemPackagingGridControl.TabIndex = 27;
            // 
            // fld_tabGeneralMaterial
            // 
            this.fld_tabGeneralMaterial.Controls.Add(this.fld_btnZoomItemInstrument);
            this.fld_tabGeneralMaterial.Controls.Add(this.fld_dgcAllocationPlanItemInstrumentsGridControl);
            this.fld_tabGeneralMaterial.Name = "fld_tabGeneralMaterial";
            this.fld_tabGeneralMaterial.Size = new System.Drawing.Size(1312, 525);
            this.fld_tabGeneralMaterial.Text = "Vật tư SX chung";
            // 
            // fld_btnZoomItemInstrument
            // 
            this.fld_btnZoomItemInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomItemInstrument.BOSComment = null;
            this.fld_btnZoomItemInstrument.BOSDataMember = null;
            this.fld_btnZoomItemInstrument.BOSDataSource = null;
            this.fld_btnZoomItemInstrument.BOSDescription = null;
            this.fld_btnZoomItemInstrument.BOSError = null;
            this.fld_btnZoomItemInstrument.BOSFieldGroup = null;
            this.fld_btnZoomItemInstrument.BOSFieldRelation = null;
            this.fld_btnZoomItemInstrument.BOSPrivilege = null;
            this.fld_btnZoomItemInstrument.BOSPropertyName = null;
            this.fld_btnZoomItemInstrument.Location = new System.Drawing.Point(1285, 6);
            this.fld_btnZoomItemInstrument.Name = "fld_btnZoomItemInstrument";
            this.fld_btnZoomItemInstrument.Screen = null;
            this.fld_btnZoomItemInstrument.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomItemInstrument.TabIndex = 408;
            this.fld_btnZoomItemInstrument.Text = "❐";
            this.fld_btnZoomItemInstrument.ToolTip = "Phóng to";
            this.fld_btnZoomItemInstrument.Click += new System.EventHandler(this.Fld_btnZoomItemInstrument_Click);
            // 
            // fld_dgcAllocationPlanItemInstrumentsGridControl
            // 
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Name = "fld_dgcAllocationPlanItemInstrumentsGridControl";
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.Size = new System.Drawing.Size(1301, 512);
            this.fld_dgcAllocationPlanItemInstrumentsGridControl.TabIndex = 27;
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_btnZoomSemiProduct);
            this.fld_tabSemiProduct.Controls.Add(this.fld_dgcAllocationPlanItemSemiGridControl);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(1318, 532);
            this.fld_tabSemiProduct.Text = "Bán thành phẩm";
            // 
            // fld_btnZoomSemiProduct
            // 
            this.fld_btnZoomSemiProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomSemiProduct.BOSComment = null;
            this.fld_btnZoomSemiProduct.BOSDataMember = null;
            this.fld_btnZoomSemiProduct.BOSDataSource = null;
            this.fld_btnZoomSemiProduct.BOSDescription = null;
            this.fld_btnZoomSemiProduct.BOSError = null;
            this.fld_btnZoomSemiProduct.BOSFieldGroup = null;
            this.fld_btnZoomSemiProduct.BOSFieldRelation = null;
            this.fld_btnZoomSemiProduct.BOSPrivilege = null;
            this.fld_btnZoomSemiProduct.BOSPropertyName = null;
            this.fld_btnZoomSemiProduct.Location = new System.Drawing.Point(1291, 6);
            this.fld_btnZoomSemiProduct.Name = "fld_btnZoomSemiProduct";
            this.fld_btnZoomSemiProduct.Screen = null;
            this.fld_btnZoomSemiProduct.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomSemiProduct.TabIndex = 408;
            this.fld_btnZoomSemiProduct.Text = "❐";
            this.fld_btnZoomSemiProduct.ToolTip = "Phóng to";
            this.fld_btnZoomSemiProduct.Click += new System.EventHandler(this.Fld_btnZoomSemiProduct_Click);
            // 
            // fld_dgcAllocationPlanItemSemiGridControl
            // 
            this.fld_dgcAllocationPlanItemSemiGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSComment = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSDataMember = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSDescription = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSError = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSFieldGroup = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSFieldRelation = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSGridType = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSPrivilege = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.BOSPropertyName = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.CommodityType = "";
            this.fld_dgcAllocationPlanItemSemiGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAllocationPlanItemSemiGridControl.Location = new System.Drawing.Point(6, 6);
            this.fld_dgcAllocationPlanItemSemiGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAllocationPlanItemSemiGridControl.Name = "fld_dgcAllocationPlanItemSemiGridControl";
            this.fld_dgcAllocationPlanItemSemiGridControl.PrintReport = false;
            this.fld_dgcAllocationPlanItemSemiGridControl.Screen = null;
            this.fld_dgcAllocationPlanItemSemiGridControl.Size = new System.Drawing.Size(1307, 519);
            this.fld_dgcAllocationPlanItemSemiGridControl.TabIndex = 27;
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
            this.bosLine4.Controls.Add(this.fld_btnUnApprove);
            this.bosLine4.Controls.Add(this.fld_btnApprove);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine4.Location = new System.Drawing.Point(868, 58);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(140, 81);
            this.bosLine4.TabIndex = 133;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Thao tác cấp phát";
            // 
            // fld_btnUnApprove
            // 
            this.fld_btnUnApprove.BOSComment = null;
            this.fld_btnUnApprove.BOSDataMember = null;
            this.fld_btnUnApprove.BOSDataSource = null;
            this.fld_btnUnApprove.BOSDescription = null;
            this.fld_btnUnApprove.BOSError = null;
            this.fld_btnUnApprove.BOSFieldGroup = null;
            this.fld_btnUnApprove.BOSFieldRelation = null;
            this.fld_btnUnApprove.BOSPrivilege = null;
            this.fld_btnUnApprove.BOSPropertyName = null;
            this.fld_btnUnApprove.Location = new System.Drawing.Point(11, 48);
            this.fld_btnUnApprove.Name = "fld_btnUnApprove";
            this.fld_btnUnApprove.Screen = null;
            this.fld_btnUnApprove.Size = new System.Drawing.Size(116, 22);
            this.fld_btnUnApprove.TabIndex = 132;
            this.fld_btnUnApprove.Text = "Hủy duyệt cấp phát";
            this.fld_btnUnApprove.Click += new System.EventHandler(this.Fld_btnUnApprove_Click);
            // 
            // fld_btnApprove
            // 
            this.fld_btnApprove.BOSComment = null;
            this.fld_btnApprove.BOSDataMember = null;
            this.fld_btnApprove.BOSDataSource = null;
            this.fld_btnApprove.BOSDescription = null;
            this.fld_btnApprove.BOSError = null;
            this.fld_btnApprove.BOSFieldGroup = null;
            this.fld_btnApprove.BOSFieldRelation = null;
            this.fld_btnApprove.BOSPrivilege = null;
            this.fld_btnApprove.BOSPropertyName = null;
            this.fld_btnApprove.Location = new System.Drawing.Point(11, 20);
            this.fld_btnApprove.Name = "fld_btnApprove";
            this.fld_btnApprove.Screen = null;
            this.fld_btnApprove.Size = new System.Drawing.Size(116, 22);
            this.fld_btnApprove.TabIndex = 3;
            this.fld_btnApprove.Text = "Duyệt cấp phát";
            this.fld_btnApprove.Click += new System.EventHandler(this.Fld_btnApprove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_btnClosePlan);
            this.groupBox1.Controls.Add(this.fld_btnUpdateInventoryStock);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1014, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 132);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiện ích";
            // 
            // fld_btnClosePlan
            // 
            this.fld_btnClosePlan.BOSComment = null;
            this.fld_btnClosePlan.BOSDataMember = null;
            this.fld_btnClosePlan.BOSDataSource = null;
            this.fld_btnClosePlan.BOSDescription = null;
            this.fld_btnClosePlan.BOSError = null;
            this.fld_btnClosePlan.BOSFieldGroup = null;
            this.fld_btnClosePlan.BOSFieldRelation = null;
            this.fld_btnClosePlan.BOSPrivilege = null;
            this.fld_btnClosePlan.BOSPropertyName = null;
            this.fld_btnClosePlan.Location = new System.Drawing.Point(6, 45);
            this.fld_btnClosePlan.Name = "fld_btnClosePlan";
            this.fld_btnClosePlan.Screen = null;
            this.fld_btnClosePlan.Size = new System.Drawing.Size(104, 22);
            this.fld_btnClosePlan.TabIndex = 133;
            this.fld_btnClosePlan.Text = "Huỷ chi tiết";
            this.fld_btnClosePlan.Click += new System.EventHandler(this.fld_btnClosePlan_Click);
            // 
            // fld_btnUpdateInventoryStock
            // 
            this.fld_btnUpdateInventoryStock.BOSComment = null;
            this.fld_btnUpdateInventoryStock.BOSDataMember = null;
            this.fld_btnUpdateInventoryStock.BOSDataSource = null;
            this.fld_btnUpdateInventoryStock.BOSDescription = null;
            this.fld_btnUpdateInventoryStock.BOSError = null;
            this.fld_btnUpdateInventoryStock.BOSFieldGroup = null;
            this.fld_btnUpdateInventoryStock.BOSFieldRelation = null;
            this.fld_btnUpdateInventoryStock.BOSPrivilege = null;
            this.fld_btnUpdateInventoryStock.BOSPropertyName = null;
            this.fld_btnUpdateInventoryStock.Location = new System.Drawing.Point(7, 17);
            this.fld_btnUpdateInventoryStock.Name = "fld_btnUpdateInventoryStock";
            this.fld_btnUpdateInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateInventoryStock, true);
            this.fld_btnUpdateInventoryStock.Size = new System.Drawing.Size(104, 22);
            this.fld_btnUpdateInventoryStock.TabIndex = 0;
            this.fld_btnUpdateInventoryStock.Text = "Xem tồn kho";
            this.fld_btnUpdateInventoryStock.Click += new System.EventHandler(this.fld_btnUpdateInventoryStock_Click);
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "";
            this.bosTextBox1.BOSDataSource = "";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Enabled = false;
            this.bosTextBox1.Location = new System.Drawing.Point(13, 726);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.Salmon;
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(35, 20);
            this.bosTextBox1.TabIndex = 130;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel24.Appearance.Options.UseFont = true;
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(66, 729);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(300, 13);
            this.bosLabel24.TabIndex = 129;
            this.bosLabel24.Text = "Số lượng kế hoạch lớn hơn số lượng tồn kho thời điểm";
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
            this.bosLine5.Controls.Add(this.bosLabel1);
            this.bosLine5.Controls.Add(this.bosLabel6);
            this.bosLine5.Controls.Add(this.fld_medMMAllocationPlanDesc);
            this.bosLine5.Controls.Add(this.bosLabel3);
            this.bosLine5.Controls.Add(this.fld_lkeMMAllocationPlanStatus);
            this.bosLine5.Controls.Add(this.fld_dteMMAllocationPlanDate);
            this.bosLine5.Controls.Add(this.fld_dgcFK_MMBatchProductID);
            this.bosLine5.Controls.Add(this.bosLabel17);
            this.bosLine5.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosLine5.Controls.Add(this.bosLookupEdit2);
            this.bosLine5.Controls.Add(this.bosLabel4);
            this.bosLine5.Controls.Add(this.bosLabel5);
            this.bosLine5.Controls.Add(this.fld_txtMMAllocationPlanNo);
            this.bosLine5.Controls.Add(this.bosLabel7);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(9, 7);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(415, 132);
            this.bosLine5.TabIndex = 128;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Thông tin chung";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(11, 20);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(218, 71);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 127;
            this.bosLabel6.Text = "Nhân viên";
            // 
            // fld_medMMAllocationPlanDesc
            // 
            this.fld_medMMAllocationPlanDesc.BOSComment = null;
            this.fld_medMMAllocationPlanDesc.BOSDataMember = "MMAllocationPlanDesc";
            this.fld_medMMAllocationPlanDesc.BOSDataSource = "MMAllocationPlans";
            this.fld_medMMAllocationPlanDesc.BOSDescription = null;
            this.fld_medMMAllocationPlanDesc.BOSError = null;
            this.fld_medMMAllocationPlanDesc.BOSFieldGroup = null;
            this.fld_medMMAllocationPlanDesc.BOSFieldRelation = null;
            this.fld_medMMAllocationPlanDesc.BOSPrivilege = null;
            this.fld_medMMAllocationPlanDesc.BOSPropertyName = "EditValue";
            this.fld_medMMAllocationPlanDesc.Location = new System.Drawing.Point(83, 94);
            this.fld_medMMAllocationPlanDesc.MenuManager = this.screenToolbar;
            this.fld_medMMAllocationPlanDesc.Name = "fld_medMMAllocationPlanDesc";
            this.fld_medMMAllocationPlanDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMAllocationPlanDesc, true);
            this.fld_medMMAllocationPlanDesc.Size = new System.Drawing.Size(326, 32);
            this.fld_medMMAllocationPlanDesc.TabIndex = 6;
            this.fld_medMMAllocationPlanDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(218, 44);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 24;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_lkeMMAllocationPlanStatus
            // 
            this.fld_lkeMMAllocationPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeMMAllocationPlanStatus.BOSAllowDummy = false;
            this.fld_lkeMMAllocationPlanStatus.BOSComment = "";
            this.fld_lkeMMAllocationPlanStatus.BOSDataMember = "MMAllocationPlanStatus";
            this.fld_lkeMMAllocationPlanStatus.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeMMAllocationPlanStatus.BOSDescription = null;
            this.fld_lkeMMAllocationPlanStatus.BOSError = null;
            this.fld_lkeMMAllocationPlanStatus.BOSFieldGroup = "";
            this.fld_lkeMMAllocationPlanStatus.BOSFieldParent = "";
            this.fld_lkeMMAllocationPlanStatus.BOSFieldRelation = "";
            this.fld_lkeMMAllocationPlanStatus.BOSPrivilege = "";
            this.fld_lkeMMAllocationPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMAllocationPlanStatus.BOSSelectType = "";
            this.fld_lkeMMAllocationPlanStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMAllocationPlanStatus.CurrentDisplayText = "";
            this.fld_lkeMMAllocationPlanStatus.Location = new System.Drawing.Point(289, 42);
            this.fld_lkeMMAllocationPlanStatus.Name = "fld_lkeMMAllocationPlanStatus";
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMAllocationPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMAllocationPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMAllocationPlanStatus.Properties.ColumnName = null;
            this.fld_lkeMMAllocationPlanStatus.Properties.NullText = "";
            this.fld_lkeMMAllocationPlanStatus.Properties.ReadOnly = true;
            this.fld_lkeMMAllocationPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMAllocationPlanStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMAllocationPlanStatus, true);
            this.fld_lkeMMAllocationPlanStatus.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeMMAllocationPlanStatus.TabIndex = 3;
            this.fld_lkeMMAllocationPlanStatus.Tag = "DC";
            // 
            // fld_dteMMAllocationPlanDate
            // 
            this.fld_dteMMAllocationPlanDate.BOSComment = "";
            this.fld_dteMMAllocationPlanDate.BOSDataMember = "MMAllocationPlanDate";
            this.fld_dteMMAllocationPlanDate.BOSDataSource = "MMAllocationPlans";
            this.fld_dteMMAllocationPlanDate.BOSDescription = null;
            this.fld_dteMMAllocationPlanDate.BOSError = null;
            this.fld_dteMMAllocationPlanDate.BOSFieldGroup = "";
            this.fld_dteMMAllocationPlanDate.BOSFieldRelation = "";
            this.fld_dteMMAllocationPlanDate.BOSPrivilege = "";
            this.fld_dteMMAllocationPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteMMAllocationPlanDate.EditValue = null;
            this.fld_dteMMAllocationPlanDate.Location = new System.Drawing.Point(289, 16);
            this.fld_dteMMAllocationPlanDate.Name = "fld_dteMMAllocationPlanDate";
            this.fld_dteMMAllocationPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMAllocationPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMAllocationPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMAllocationPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMAllocationPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMAllocationPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMAllocationPlanDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMAllocationPlanDate, true);
            this.fld_dteMMAllocationPlanDate.Size = new System.Drawing.Size(120, 20);
            this.fld_dteMMAllocationPlanDate.TabIndex = 1;
            this.fld_dteMMAllocationPlanDate.Tag = "DC";
            // 
            // fld_dgcFK_MMBatchProductID
            // 
            this.fld_dgcFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_dgcFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_dgcFK_MMBatchProductID.BOSComment = null;
            this.fld_dgcFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.BOSDataSource = "MMAllocationPlans";
            this.fld_dgcFK_MMBatchProductID.BOSDescription = null;
            this.fld_dgcFK_MMBatchProductID.BOSError = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_dgcFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_dgcFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_dgcFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_dgcFK_MMBatchProductID.BOSSelectType = null;
            this.fld_dgcFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_dgcFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_dgcFK_MMBatchProductID.Enabled = false;
            this.fld_dgcFK_MMBatchProductID.Location = new System.Drawing.Point(83, 42);
            this.fld_dgcFK_MMBatchProductID.Name = "fld_dgcFK_MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dgcFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_dgcFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductName", "Tên")});
            this.fld_dgcFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_dgcFK_MMBatchProductID.Properties.NullText = "";
            this.fld_dgcFK_MMBatchProductID.Properties.ReadOnly = true;
            this.fld_dgcFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dgcFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_dgcFK_MMBatchProductID.Screen = null;
            this.fld_dgcFK_MMBatchProductID.Size = new System.Drawing.Size(120, 20);
            this.fld_dgcFK_MMBatchProductID.TabIndex = 2;
            this.fld_dgcFK_MMBatchProductID.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(11, 70);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(65, 13);
            this.bosLabel17.TabIndex = 28;
            this.bosLabel17.Text = "Loại kế hoạch";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMAllocationPlans";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(289, 68);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.ReadOnly = true;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 5;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "MMAllocationPlanPurpose";
            this.bosLookupEdit2.BOSDataSource = "MMAllocationPlans";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(83, 68);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(120, 20);
            this.bosLookupEdit2.TabIndex = 4;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(11, 45);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(34, 13);
            this.bosLabel4.TabIndex = 8;
            this.bosLabel4.Text = "Mã LSX";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(11, 96);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 34;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_txtMMAllocationPlanNo
            // 
            this.fld_txtMMAllocationPlanNo.BOSComment = null;
            this.fld_txtMMAllocationPlanNo.BOSDataMember = "MMAllocationPlanNo";
            this.fld_txtMMAllocationPlanNo.BOSDataSource = "MMAllocationPlans";
            this.fld_txtMMAllocationPlanNo.BOSDescription = null;
            this.fld_txtMMAllocationPlanNo.BOSError = null;
            this.fld_txtMMAllocationPlanNo.BOSFieldGroup = null;
            this.fld_txtMMAllocationPlanNo.BOSFieldRelation = null;
            this.fld_txtMMAllocationPlanNo.BOSPrivilege = null;
            this.fld_txtMMAllocationPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtMMAllocationPlanNo.Location = new System.Drawing.Point(83, 16);
            this.fld_txtMMAllocationPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtMMAllocationPlanNo.Name = "fld_txtMMAllocationPlanNo";
            this.fld_txtMMAllocationPlanNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMAllocationPlanNo, true);
            this.fld_txtMMAllocationPlanNo.Size = new System.Drawing.Size(120, 20);
            this.fld_txtMMAllocationPlanNo.TabIndex = 0;
            this.fld_txtMMAllocationPlanNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(218, 20);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(42, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Ngày lập";
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
            this.bosLine3.Controls.Add(this.fld_lkeHRDepartmentRoomGroupItemID);
            this.bosLine3.Controls.Add(this.bosLabel2);
            this.bosLine3.Controls.Add(this.fld_lkeFK_HREmployeeIDReceive);
            this.bosLine3.Controls.Add(this.bosLabel12);
            this.bosLine3.Controls.Add(this.fld_btnUpdateOtherInfo);
            this.bosLine3.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosLine3.Controls.Add(this.fld_lkeFK_MMLineID);
            this.bosLine3.Controls.Add(this.bosLabel21);
            this.bosLine3.Controls.Add(this.bosLabel20);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(430, 7);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(284, 132);
            this.bosLine3.TabIndex = 125;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Cập nhật thông tin cấp phát";
            // 
            // fld_lkeHRDepartmentRoomGroupItemID
            // 
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSComment = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDataSource = "MMAllocationPlanItems";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldGroup = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldParent = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSFieldRelation = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPrivilege = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectType = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.BOSSelectTypeValue = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.CurrentDisplayText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(75, 69);
            this.fld_lkeHRDepartmentRoomGroupItemID.Name = "fld_lkeHRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.NullText = "";
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeHRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeHRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeHRDepartmentRoomGroupItemID.TabIndex = 2;
            this.fld_lkeHRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeHRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRDepartmentRoomGroupItemID_QueryPopUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(9, 98);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(55, 13);
            this.bosLabel2.TabIndex = 129;
            this.bosLabel2.Text = "Người nhận";
            // 
            // fld_lkeFK_HREmployeeIDReceive
            // 
            this.fld_lkeFK_HREmployeeIDReceive.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeIDReceive.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeIDReceive.BOSComment = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDataMember = "FK_HREmployeeIDReceive";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_HREmployeeIDReceive.BOSDescription = null;
            this.fld_lkeFK_HREmployeeIDReceive.BOSError = null;
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeIDReceive.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeIDReceive.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeIDReceive.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeIDReceive.Location = new System.Drawing.Point(75, 95);
            this.fld_lkeFK_HREmployeeIDReceive.Name = "fld_lkeFK_HREmployeeIDReceive";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeIDReceive.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HREmployeeIDReceive.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeIDReceive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeIDReceive.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeIDReceive.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeIDReceive, true);
            this.fld_lkeFK_HREmployeeIDReceive.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeIDReceive.TabIndex = 3;
            this.fld_lkeFK_HREmployeeIDReceive.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(9, 72);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(12, 13);
            this.bosLabel12.TabIndex = 23;
            this.bosLabel12.Text = "Tổ";
            // 
            // fld_btnUpdateOtherInfo
            // 
            this.fld_btnUpdateOtherInfo.BOSComment = null;
            this.fld_btnUpdateOtherInfo.BOSDataMember = null;
            this.fld_btnUpdateOtherInfo.BOSDataSource = null;
            this.fld_btnUpdateOtherInfo.BOSDescription = null;
            this.fld_btnUpdateOtherInfo.BOSError = null;
            this.fld_btnUpdateOtherInfo.BOSFieldGroup = null;
            this.fld_btnUpdateOtherInfo.BOSFieldRelation = null;
            this.fld_btnUpdateOtherInfo.BOSPrivilege = null;
            this.fld_btnUpdateOtherInfo.BOSPropertyName = null;
            this.fld_btnUpdateOtherInfo.Location = new System.Drawing.Point(201, 95);
            this.fld_btnUpdateOtherInfo.Name = "fld_btnUpdateOtherInfo";
            this.fld_btnUpdateOtherInfo.Screen = null;
            this.fld_btnUpdateOtherInfo.Size = new System.Drawing.Size(74, 20);
            this.fld_btnUpdateOtherInfo.TabIndex = 2;
            this.fld_btnUpdateOtherInfo.Text = "Cập nhật";
            this.fld_btnUpdateOtherInfo.Click += new System.EventHandler(this.Fld_btnUpdateOtherInfo_Click);
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMAllocationPlans";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(75, 17);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 0;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            this.fld_lkeFK_MMWorkShopID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMWorkShopID_QueryPopUp);
            this.fld_lkeFK_MMWorkShopID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMWorkShopID_CloseUp);
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = true;
            this.fld_lkeFK_MMLineID.BOSComment = "";
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMAllocationPlanItems";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = "";
            this.fld_lkeFK_MMLineID.BOSFieldParent = "";
            this.fld_lkeFK_MMLineID.BOSFieldRelation = "";
            this.fld_lkeFK_MMLineID.BOSPrivilege = "";
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = "";
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMLineID.CurrentDisplayText = "";
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(75, 43);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = "";
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 1;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            this.fld_lkeFK_MMLineID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMLineID_QueryPopUp);
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(9, 20);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(31, 13);
            this.bosLabel21.TabIndex = 14;
            this.bosLabel21.Text = "Xưởng";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(9, 46);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(37, 13);
            this.bosLabel20.TabIndex = 22;
            this.bosLabel20.Text = "Chuyền";
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
            this.bosLine1.Controls.Add(this.fld_btnUnPlanned);
            this.bosLine1.Controls.Add(this.fld_btnPlanned);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(720, 58);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(142, 81);
            this.bosLine1.TabIndex = 124;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thao tác kế hoạch";
            // 
            // fld_btnUnPlanned
            // 
            this.fld_btnUnPlanned.BOSComment = null;
            this.fld_btnUnPlanned.BOSDataMember = null;
            this.fld_btnUnPlanned.BOSDataSource = null;
            this.fld_btnUnPlanned.BOSDescription = null;
            this.fld_btnUnPlanned.BOSError = null;
            this.fld_btnUnPlanned.BOSFieldGroup = null;
            this.fld_btnUnPlanned.BOSFieldRelation = null;
            this.fld_btnUnPlanned.BOSPrivilege = null;
            this.fld_btnUnPlanned.BOSPropertyName = null;
            this.fld_btnUnPlanned.Location = new System.Drawing.Point(13, 48);
            this.fld_btnUnPlanned.Name = "fld_btnUnPlanned";
            this.fld_btnUnPlanned.Screen = null;
            this.fld_btnUnPlanned.Size = new System.Drawing.Size(116, 22);
            this.fld_btnUnPlanned.TabIndex = 2;
            this.fld_btnUnPlanned.Text = "Hủy duyệt kế hoạch";
            this.fld_btnUnPlanned.Click += new System.EventHandler(this.Fld_btnUnPlannedClick);
            // 
            // fld_btnPlanned
            // 
            this.fld_btnPlanned.BOSComment = null;
            this.fld_btnPlanned.BOSDataMember = null;
            this.fld_btnPlanned.BOSDataSource = null;
            this.fld_btnPlanned.BOSDescription = null;
            this.fld_btnPlanned.BOSError = null;
            this.fld_btnPlanned.BOSFieldGroup = null;
            this.fld_btnPlanned.BOSFieldRelation = null;
            this.fld_btnPlanned.BOSPrivilege = null;
            this.fld_btnPlanned.BOSPropertyName = null;
            this.fld_btnPlanned.Location = new System.Drawing.Point(13, 20);
            this.fld_btnPlanned.Name = "fld_btnPlanned";
            this.fld_btnPlanned.Screen = null;
            this.fld_btnPlanned.Size = new System.Drawing.Size(116, 22);
            this.fld_btnPlanned.TabIndex = 1;
            this.fld_btnPlanned.Text = "Duyệt kế hoạch";
            this.fld_btnPlanned.Click += new System.EventHandler(this.Fld_btnPlanned_Click);
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
            this.bosLine2.Controls.Add(this.fld_dteAllocationPlanDate);
            this.bosLine2.Controls.Add(this.bosLabel11);
            this.bosLine2.Controls.Add(this.fld_btnUpdateItemPlanDate);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(720, 7);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(288, 45);
            this.bosLine2.TabIndex = 121;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Cập nhật ngày kế hoạch";
            // 
            // fld_dteAllocationPlanDate
            // 
            this.fld_dteAllocationPlanDate.EditValue = null;
            this.fld_dteAllocationPlanDate.Location = new System.Drawing.Point(77, 17);
            this.fld_dteAllocationPlanDate.MenuManager = this.screenToolbar;
            this.fld_dteAllocationPlanDate.Name = "fld_dteAllocationPlanDate";
            this.fld_dteAllocationPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAllocationPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAllocationPlanDate.Size = new System.Drawing.Size(116, 20);
            this.fld_dteAllocationPlanDate.TabIndex = 0;
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(11, 20);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(45, 13);
            this.bosLabel11.TabIndex = 18;
            this.bosLabel11.Text = "Ngày cần";
            // 
            // fld_btnUpdateItemPlanDate
            // 
            this.fld_btnUpdateItemPlanDate.BOSComment = null;
            this.fld_btnUpdateItemPlanDate.BOSDataMember = null;
            this.fld_btnUpdateItemPlanDate.BOSDataSource = null;
            this.fld_btnUpdateItemPlanDate.BOSDescription = null;
            this.fld_btnUpdateItemPlanDate.BOSError = null;
            this.fld_btnUpdateItemPlanDate.BOSFieldGroup = null;
            this.fld_btnUpdateItemPlanDate.BOSFieldRelation = null;
            this.fld_btnUpdateItemPlanDate.BOSPrivilege = null;
            this.fld_btnUpdateItemPlanDate.BOSPropertyName = null;
            this.fld_btnUpdateItemPlanDate.Location = new System.Drawing.Point(199, 18);
            this.fld_btnUpdateItemPlanDate.Name = "fld_btnUpdateItemPlanDate";
            this.fld_btnUpdateItemPlanDate.Screen = null;
            this.fld_btnUpdateItemPlanDate.Size = new System.Drawing.Size(74, 20);
            this.fld_btnUpdateItemPlanDate.TabIndex = 1;
            this.fld_btnUpdateItemPlanDate.Text = "Cập nhật";
            this.fld_btnUpdateItemPlanDate.Click += new System.EventHandler(this.Fld_btnUpdateItemPlanDate_Click);
            // 
            // DMAPL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1348, 708);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAPL100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMAllocationProposalWoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemWoodsGridControl)).EndInit();
            this.fld_tabOtherMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemSteelsGridControl)).EndInit();
            this.fld_tabHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemHardwaresGridControl)).EndInit();
            this.fld_tabIngredientPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemPaintsGridControl)).EndInit();
            this.fld_tabIngredientPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemPackagingGridControl)).EndInit();
            this.fld_tabGeneralMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemInstrumentsGridControl)).EndInit();
            this.fld_tabSemiProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAllocationPlanItemSemiGridControl)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMAllocationPlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMAllocationPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMAllocationPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMAllocationPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMAllocationPlanNo.Properties)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeIDReceive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAllocationPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAllocationPlanDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMAllocationProposalWoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSButton fld_btnUpdateInventoryStock;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSMemoEdit fld_medMMAllocationPlanDesc;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeMMAllocationPlanStatus;
        private BOSComponent.BOSDateEdit fld_dteMMAllocationPlanDate;
        private BOSComponent.BOSLookupEdit fld_dgcFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtMMAllocationPlanNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSButton fld_btnUpdateOtherInfo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButton fld_btnUnApprove;
        private BOSComponent.BOSButton fld_btnUnPlanned;
        private BOSComponent.BOSButton fld_btnPlanned;
        private BOSComponent.BOSButton fld_btnApprove;
        private DevExpress.XtraEditors.DateEdit fld_dteAllocationPlanDate;
        private BOSComponent.BOSButton fld_btnUpdateItemPlanDate;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLine bosLine2;
        private GroupBox groupBox1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeIDReceive;
        private BOSComponent.BOSButton fld_btnClosePlan;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomGroupItemID;
        private DevExpress.XtraTab.XtraTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabOtherMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tabIngredientPaint;
        private DevExpress.XtraTab.XtraTabPage fld_tabIngredientPackaging;
        private DevExpress.XtraTab.XtraTabPage fld_tabGeneralMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private AllocationProposal.MMAllocationPlanItemWoodsGridControl fld_dgcAllocationPlanItemWoodsGridControl;
        private AllocationProposal.MMAllocationPlanItemSteelsGridControl fld_dgcAllocationPlanItemSteelsGridControl;
        private MMAllocationPlanItemHardwaresGridControl fld_dgcAllocationPlanItemHardwaresGridControl;
        private MMAllocationPlanItemPaintsGridControl fld_dgcAllocationPlanItemPaintsGridControl;
        private MMAllocationPlanItemPackagingsGridControl fld_dgcAllocationPlanItemPackagingGridControl;
        private MMAllocationPlanItemInstrumentsGridControl fld_dgcAllocationPlanItemInstrumentsGridControl;
        private MMAllocationPlanItemSemiProductGridControl fld_dgcAllocationPlanItemSemiGridControl;
        private BOSComponent.BOSButton fld_btnItemWood;
        private BOSComponent.BOSButton fld_btnZoomOtherMaterial;
        private BOSComponent.BOSButton fld_btnZoomItemHardware;
        private BOSComponent.BOSButton fld_btnZoomItemPaint;
        private BOSComponent.BOSButton fld_showZoomItemPackaging;
        private BOSComponent.BOSButton fld_btnZoomItemInstrument;
        private BOSComponent.BOSButton fld_btnZoomSemiProduct;
    }
}
