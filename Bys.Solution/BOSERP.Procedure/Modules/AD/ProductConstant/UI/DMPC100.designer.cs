using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC100
	/// </summary>
	partial class DMPC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPC100));
            this.fld_dgvICProductAttributes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton5 = new BOSComponent.BOSButton(this.components);
            this.bosButton6 = new BOSComponent.BOSButton(this.components);
            this.bosButton7 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton8 = new BOSComponent.BOSButton(this.components);
            this.bosButton9 = new BOSComponent.BOSButton(this.components);
            this.bosButton10 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton11 = new BOSComponent.BOSButton(this.components);
            this.bosButton12 = new BOSComponent.BOSButton(this.components);
            this.bosButton13 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton14 = new BOSComponent.BOSButton(this.components);
            this.bosButton15 = new BOSComponent.BOSButton(this.components);
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton16 = new BOSComponent.BOSButton(this.components);
            this.bosButton17 = new BOSComponent.BOSButton(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView18 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView19 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView20 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView22 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView23 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView24 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView25 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView26 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView27 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSavePaint = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancelPaint = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddPaint = new BOSComponent.BOSButton(this.components);
            this.gridView28 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.gridView29 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView30 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView31 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView32 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView33 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView34 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView35 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView36 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView37 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabQuality = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcQuality = new BOSERP.Modules.ProductConstant.QualityGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICConfigQualityAccordWoodType = new BOSERP.Modules.ProductConstant.ConfigQualityAccordWoodGridControl();
            this.gridView57 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabFSCType = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcTTMT = new BOSERP.Modules.ProductConstant.TTMTGridControl();
            this.gridView38 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabHTType = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHTType = new BOSERP.Modules.ProductConstant.HTTypeGridControl();
            this.gridView39 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPaintType = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcCoLor = new BOSERP.Modules.ProductConstant.CoLorGridControl();
            this.gridView40 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabWoodType = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcWoodType = new BOSERP.Modules.ProductConstant.WoodTypeGridControl();
            this.gridView41 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcProductAttributes = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabThink = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcThickGridControl = new BOSERP.Modules.ProductConstant.ThickGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICConfigThinkAccordWoodType = new BOSERP.Modules.ProductConstant.ConfigThinkAccordWoodGridControl();
            this.gridView51 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductAttributes = new BOSERP.Modules.ProductConstant.AttributesGridControl();
            this.gridView48 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage13 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductGroupHeights = new BOSERP.Modules.ProductConstant.ICProductGroupHeightsGridControl();
            this.fld_tabAddMaterialType = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductAttributeAddMaterialType = new BOSERP.Modules.ProductConstant.AddMaterialGridControl();
            this.gridView49 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage14 = new DevExpress.XtraTab.XtraTabPage();
            this.attributesGridControl1 = new BOSERP.Modules.ProductConstant.AttributesGridControl();
            this.gridView52 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_GroupCluster = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSemiGroupType = new BOSERP.Modules.ProductConstant.CauHinhNhomCumGridControl();
            this.gridView53 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPerimeterGroup = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICPerimeterGroups = new BOSERP.Modules.ProductConstant.ICPerimeterGroupsGridControl();
            this.gridView56 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabLengthGroup = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICLengthGroups = new BOSERP.Modules.ProductConstant.ICLengthGroupsGridControl();
            this.gridView58 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabWidthGroup = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICWidthGroups = new BOSERP.Modules.ProductConstant.ICWidthGroupsGridControl();
            this.gridView60 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage15 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICMaterialConfigs = new BOSERP.Modules.ProductConstant.ICMaterialConfigsGridControl();
            this.gridView59 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.qualityGridControl1 = new BOSERP.Modules.ProductConstant.QualityGridControl();
            this.gridView42 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.woodTypeGridControl1 = new BOSERP.Modules.ProductConstant.WoodTypeGridControl();
            this.gridView43 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.coLorGridControl1 = new BOSERP.Modules.ProductConstant.CoLorGridControl();
            this.gridView44 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.htTypeGridControl1 = new BOSERP.Modules.ProductConstant.HTTypeGridControl();
            this.gridView45 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
            this.ttmtGridControl1 = new BOSERP.Modules.ProductConstant.TTMTGridControl();
            this.gridView46 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView47 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView54 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView55 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView50 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProductAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView37)).BeginInit();
            this.fld_tabQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).BeginInit();
            this.bosGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConfigQualityAccordWoodType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView57)).BeginInit();
            this.fld_tabFSCType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTTMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).BeginInit();
            this.fld_tabHTType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHTType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView39)).BeginInit();
            this.fld_tabPaintType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCoLor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView40)).BeginInit();
            this.fld_tabWoodType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductAttributes)).BeginInit();
            this.fld_dgcProductAttributes.SuspendLayout();
            this.fld_tabThink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcThickGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConfigThinkAccordWoodType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView51)).BeginInit();
            this.xtraTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView48)).BeginInit();
            this.xtraTabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductGroupHeights)).BeginInit();
            this.fld_tabAddMaterialType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAttributeAddMaterialType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView49)).BeginInit();
            this.xtraTabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView52)).BeginInit();
            this.fld_GroupCluster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiGroupType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView53)).BeginInit();
            this.fld_tabPerimeterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPerimeterGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView56)).BeginInit();
            this.fld_tabLengthGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICLengthGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView58)).BeginInit();
            this.fld_tabWidthGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICWidthGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView60)).BeginInit();
            this.xtraTabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICMaterialConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView59)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView42)).BeginInit();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woodTypeGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView43)).BeginInit();
            this.xtraTabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coLorGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView44)).BeginInit();
            this.xtraTabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htTypeGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView45)).BeginInit();
            this.xtraTabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttmtGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView50)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvICProductAttributes
            // 
            this.fld_dgvICProductAttributes.Name = "fld_dgvICProductAttributes";
            this.fld_dgvICProductAttributes.PaintStyleName = "Office2003";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // gridView5
            // 
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // gridView8
            // 
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosButton1);
            this.xtraTabPage1.Controls.Add(this.bosButton2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage1.Text = "Chất lượng";
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
            this.bosButton1.Location = new System.Drawing.Point(781, 3);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(86, 27);
            this.bosButton1.TabIndex = 20;
            this.bosButton1.Text = "Hủy";
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
            this.bosButton2.Location = new System.Drawing.Point(689, 3);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(86, 27);
            this.bosButton2.TabIndex = 19;
            this.bosButton2.Text = "Thêm";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosButton5);
            this.xtraTabPage2.Controls.Add(this.bosButton6);
            this.xtraTabPage2.Controls.Add(this.bosButton7);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage2, true);
            this.xtraTabPage2.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage2.Text = "Loại gổ";
            // 
            // bosButton5
            // 
            this.bosButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton5.BOSComment = null;
            this.bosButton5.BOSDataMember = null;
            this.bosButton5.BOSDataSource = null;
            this.bosButton5.BOSDescription = null;
            this.bosButton5.BOSError = null;
            this.bosButton5.BOSFieldGroup = null;
            this.bosButton5.BOSFieldRelation = null;
            this.bosButton5.BOSPrivilege = null;
            this.bosButton5.BOSPropertyName = null;
            this.bosButton5.Location = new System.Drawing.Point(689, 3);
            this.bosButton5.Name = "bosButton5";
            this.bosButton5.Screen = null;
            this.bosButton5.Size = new System.Drawing.Size(86, 27);
            this.bosButton5.TabIndex = 4;
            this.bosButton5.Text = "Lưu";
            // 
            // bosButton6
            // 
            this.bosButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton6.BOSComment = null;
            this.bosButton6.BOSDataMember = null;
            this.bosButton6.BOSDataSource = null;
            this.bosButton6.BOSDescription = null;
            this.bosButton6.BOSError = null;
            this.bosButton6.BOSFieldGroup = null;
            this.bosButton6.BOSFieldRelation = null;
            this.bosButton6.BOSPrivilege = null;
            this.bosButton6.BOSPropertyName = null;
            this.bosButton6.Location = new System.Drawing.Point(781, 3);
            this.bosButton6.Name = "bosButton6";
            this.bosButton6.Screen = null;
            this.bosButton6.Size = new System.Drawing.Size(86, 27);
            this.bosButton6.TabIndex = 5;
            this.bosButton6.Text = "Hủy";
            // 
            // bosButton7
            // 
            this.bosButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton7.BOSComment = null;
            this.bosButton7.BOSDataMember = null;
            this.bosButton7.BOSDataSource = null;
            this.bosButton7.BOSDescription = null;
            this.bosButton7.BOSError = null;
            this.bosButton7.BOSFieldGroup = null;
            this.bosButton7.BOSFieldRelation = null;
            this.bosButton7.BOSPrivilege = null;
            this.bosButton7.BOSPropertyName = null;
            this.bosButton7.Location = new System.Drawing.Point(597, 3);
            this.bosButton7.Name = "bosButton7";
            this.bosButton7.Screen = null;
            this.bosButton7.Size = new System.Drawing.Size(86, 27);
            this.bosButton7.TabIndex = 4;
            this.bosButton7.Text = "Thêm";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosButton8);
            this.xtraTabPage3.Controls.Add(this.bosButton9);
            this.xtraTabPage3.Controls.Add(this.bosButton10);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage3, true);
            this.xtraTabPage3.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage3.Text = "Màu sơn";
            // 
            // bosButton8
            // 
            this.bosButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton8.BOSComment = null;
            this.bosButton8.BOSDataMember = null;
            this.bosButton8.BOSDataSource = null;
            this.bosButton8.BOSDescription = null;
            this.bosButton8.BOSError = null;
            this.bosButton8.BOSFieldGroup = null;
            this.bosButton8.BOSFieldRelation = null;
            this.bosButton8.BOSPrivilege = null;
            this.bosButton8.BOSPropertyName = null;
            this.bosButton8.Location = new System.Drawing.Point(689, 3);
            this.bosButton8.Name = "bosButton8";
            this.bosButton8.Screen = null;
            this.bosButton8.Size = new System.Drawing.Size(86, 27);
            this.bosButton8.TabIndex = 8;
            this.bosButton8.Text = "Lưu";
            // 
            // bosButton9
            // 
            this.bosButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton9.BOSComment = null;
            this.bosButton9.BOSDataMember = null;
            this.bosButton9.BOSDataSource = null;
            this.bosButton9.BOSDescription = null;
            this.bosButton9.BOSError = null;
            this.bosButton9.BOSFieldGroup = null;
            this.bosButton9.BOSFieldRelation = null;
            this.bosButton9.BOSPrivilege = null;
            this.bosButton9.BOSPropertyName = null;
            this.bosButton9.Location = new System.Drawing.Point(781, 3);
            this.bosButton9.Name = "bosButton9";
            this.bosButton9.Screen = null;
            this.bosButton9.Size = new System.Drawing.Size(86, 27);
            this.bosButton9.TabIndex = 9;
            this.bosButton9.Text = "Hủy";
            // 
            // bosButton10
            // 
            this.bosButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton10.BOSComment = null;
            this.bosButton10.BOSDataMember = null;
            this.bosButton10.BOSDataSource = null;
            this.bosButton10.BOSDescription = null;
            this.bosButton10.BOSError = null;
            this.bosButton10.BOSFieldGroup = null;
            this.bosButton10.BOSFieldRelation = null;
            this.bosButton10.BOSPrivilege = null;
            this.bosButton10.BOSPropertyName = null;
            this.bosButton10.Location = new System.Drawing.Point(597, 3);
            this.bosButton10.Name = "bosButton10";
            this.bosButton10.Screen = null;
            this.bosButton10.Size = new System.Drawing.Size(86, 27);
            this.bosButton10.TabIndex = 7;
            this.bosButton10.Text = "Thêm";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.bosButton11);
            this.xtraTabPage4.Controls.Add(this.bosButton12);
            this.xtraTabPage4.Controls.Add(this.bosButton13);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage4.Text = "Hoàn thiện";
            // 
            // bosButton11
            // 
            this.bosButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton11.BOSComment = null;
            this.bosButton11.BOSDataMember = null;
            this.bosButton11.BOSDataSource = null;
            this.bosButton11.BOSDescription = null;
            this.bosButton11.BOSError = null;
            this.bosButton11.BOSFieldGroup = null;
            this.bosButton11.BOSFieldRelation = null;
            this.bosButton11.BOSPrivilege = null;
            this.bosButton11.BOSPropertyName = null;
            this.bosButton11.Location = new System.Drawing.Point(689, 3);
            this.bosButton11.Name = "bosButton11";
            this.bosButton11.Screen = null;
            this.bosButton11.Size = new System.Drawing.Size(86, 27);
            this.bosButton11.TabIndex = 8;
            this.bosButton11.Text = "Lưu";
            // 
            // bosButton12
            // 
            this.bosButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton12.BOSComment = null;
            this.bosButton12.BOSDataMember = null;
            this.bosButton12.BOSDataSource = null;
            this.bosButton12.BOSDescription = null;
            this.bosButton12.BOSError = null;
            this.bosButton12.BOSFieldGroup = null;
            this.bosButton12.BOSFieldRelation = null;
            this.bosButton12.BOSPrivilege = null;
            this.bosButton12.BOSPropertyName = null;
            this.bosButton12.Location = new System.Drawing.Point(781, 3);
            this.bosButton12.Name = "bosButton12";
            this.bosButton12.Screen = null;
            this.bosButton12.Size = new System.Drawing.Size(86, 27);
            this.bosButton12.TabIndex = 9;
            this.bosButton12.Text = "Hủy";
            // 
            // bosButton13
            // 
            this.bosButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton13.BOSComment = null;
            this.bosButton13.BOSDataMember = null;
            this.bosButton13.BOSDataSource = null;
            this.bosButton13.BOSDescription = null;
            this.bosButton13.BOSError = null;
            this.bosButton13.BOSFieldGroup = null;
            this.bosButton13.BOSFieldRelation = null;
            this.bosButton13.BOSPrivilege = null;
            this.bosButton13.BOSPropertyName = null;
            this.bosButton13.Location = new System.Drawing.Point(597, 3);
            this.bosButton13.Name = "bosButton13";
            this.bosButton13.Screen = null;
            this.bosButton13.Size = new System.Drawing.Size(86, 27);
            this.bosButton13.TabIndex = 7;
            this.bosButton13.Text = "Thêm";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.bosButton14);
            this.xtraTabPage5.Controls.Add(this.bosButton15);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage5.Text = "Nguồn gốc gỗ";
            // 
            // bosButton14
            // 
            this.bosButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton14.BOSComment = null;
            this.bosButton14.BOSDataMember = null;
            this.bosButton14.BOSDataSource = null;
            this.bosButton14.BOSDescription = null;
            this.bosButton14.BOSError = null;
            this.bosButton14.BOSFieldGroup = null;
            this.bosButton14.BOSFieldRelation = null;
            this.bosButton14.BOSPrivilege = null;
            this.bosButton14.BOSPropertyName = null;
            this.bosButton14.Location = new System.Drawing.Point(781, 3);
            this.bosButton14.Name = "bosButton14";
            this.bosButton14.Screen = null;
            this.bosButton14.Size = new System.Drawing.Size(86, 27);
            this.bosButton14.TabIndex = 13;
            this.bosButton14.Text = "Hủy";
            // 
            // bosButton15
            // 
            this.bosButton15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton15.BOSComment = null;
            this.bosButton15.BOSDataMember = null;
            this.bosButton15.BOSDataSource = null;
            this.bosButton15.BOSDescription = null;
            this.bosButton15.BOSError = null;
            this.bosButton15.BOSFieldGroup = null;
            this.bosButton15.BOSFieldRelation = null;
            this.bosButton15.BOSPrivilege = null;
            this.bosButton15.BOSPropertyName = null;
            this.bosButton15.Location = new System.Drawing.Point(689, 3);
            this.bosButton15.Name = "bosButton15";
            this.bosButton15.Screen = null;
            this.bosButton15.Size = new System.Drawing.Size(86, 27);
            this.bosButton15.TabIndex = 11;
            this.bosButton15.Text = "Thêm";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.bosButton16);
            this.xtraTabPage6.Controls.Add(this.bosButton17);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(871, 527);
            this.xtraTabPage6.Text = "Xuất xứ";
            // 
            // bosButton16
            // 
            this.bosButton16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton16.BOSComment = null;
            this.bosButton16.BOSDataMember = null;
            this.bosButton16.BOSDataSource = null;
            this.bosButton16.BOSDescription = null;
            this.bosButton16.BOSError = null;
            this.bosButton16.BOSFieldGroup = null;
            this.bosButton16.BOSFieldRelation = null;
            this.bosButton16.BOSPrivilege = null;
            this.bosButton16.BOSPropertyName = null;
            this.bosButton16.Location = new System.Drawing.Point(781, 3);
            this.bosButton16.Name = "bosButton16";
            this.bosButton16.Screen = null;
            this.bosButton16.Size = new System.Drawing.Size(86, 27);
            this.bosButton16.TabIndex = 17;
            this.bosButton16.Text = "Hủy";
            // 
            // bosButton17
            // 
            this.bosButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton17.BOSComment = null;
            this.bosButton17.BOSDataMember = null;
            this.bosButton17.BOSDataSource = null;
            this.bosButton17.BOSDescription = null;
            this.bosButton17.BOSError = null;
            this.bosButton17.BOSFieldGroup = null;
            this.bosButton17.BOSFieldRelation = null;
            this.bosButton17.BOSPrivilege = null;
            this.bosButton17.BOSPropertyName = null;
            this.bosButton17.Location = new System.Drawing.Point(689, 3);
            this.bosButton17.Name = "bosButton17";
            this.bosButton17.Screen = null;
            this.bosButton17.Size = new System.Drawing.Size(86, 27);
            this.bosButton17.TabIndex = 15;
            this.bosButton17.Text = "Thêm";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // gridView9
            // 
            this.gridView9.Name = "gridView9";
            this.gridView9.PaintStyleName = "Office2003";
            // 
            // gridView10
            // 
            this.gridView10.Name = "gridView10";
            this.gridView10.PaintStyleName = "Office2003";
            // 
            // gridView11
            // 
            this.gridView11.Name = "gridView11";
            this.gridView11.PaintStyleName = "Office2003";
            // 
            // gridView12
            // 
            this.gridView12.Name = "gridView12";
            this.gridView12.PaintStyleName = "Office2003";
            // 
            // gridView13
            // 
            this.gridView13.Name = "gridView13";
            this.gridView13.PaintStyleName = "Office2003";
            // 
            // gridView14
            // 
            this.gridView14.Name = "gridView14";
            this.gridView14.PaintStyleName = "Office2003";
            // 
            // gridView15
            // 
            this.gridView15.Name = "gridView15";
            this.gridView15.PaintStyleName = "Office2003";
            // 
            // gridView16
            // 
            this.gridView16.Name = "gridView16";
            this.gridView16.PaintStyleName = "Office2003";
            // 
            // gridView17
            // 
            this.gridView17.Name = "gridView17";
            this.gridView17.PaintStyleName = "Office2003";
            // 
            // gridView18
            // 
            this.gridView18.Name = "gridView18";
            this.gridView18.PaintStyleName = "Office2003";
            // 
            // gridView19
            // 
            this.gridView19.Name = "gridView19";
            this.gridView19.PaintStyleName = "Office2003";
            // 
            // gridView20
            // 
            this.gridView20.Name = "gridView20";
            this.gridView20.PaintStyleName = "Office2003";
            // 
            // gridView21
            // 
            this.gridView21.Name = "gridView21";
            this.gridView21.PaintStyleName = "Office2003";
            // 
            // gridView22
            // 
            this.gridView22.Name = "gridView22";
            this.gridView22.PaintStyleName = "Office2003";
            // 
            // gridView23
            // 
            this.gridView23.Name = "gridView23";
            this.gridView23.PaintStyleName = "Office2003";
            // 
            // gridView24
            // 
            this.gridView24.Name = "gridView24";
            this.gridView24.PaintStyleName = "Office2003";
            // 
            // gridView25
            // 
            this.gridView25.Name = "gridView25";
            this.gridView25.PaintStyleName = "Office2003";
            // 
            // gridView26
            // 
            this.gridView26.Name = "gridView26";
            this.gridView26.PaintStyleName = "Office2003";
            // 
            // gridView27
            // 
            this.gridView27.Name = "gridView27";
            this.gridView27.PaintStyleName = "Office2003";
            // 
            // fld_btnSavePaint
            // 
            this.fld_btnSavePaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSavePaint.BOSComment = null;
            this.fld_btnSavePaint.BOSDataMember = null;
            this.fld_btnSavePaint.BOSDataSource = null;
            this.fld_btnSavePaint.BOSDescription = null;
            this.fld_btnSavePaint.BOSError = null;
            this.fld_btnSavePaint.BOSFieldGroup = null;
            this.fld_btnSavePaint.BOSFieldRelation = null;
            this.fld_btnSavePaint.BOSPrivilege = null;
            this.fld_btnSavePaint.BOSPropertyName = null;
            this.fld_btnSavePaint.Location = new System.Drawing.Point(689, 3);
            this.fld_btnSavePaint.Name = "fld_btnSavePaint";
            this.fld_btnSavePaint.Screen = null;
            this.fld_btnSavePaint.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSavePaint.TabIndex = 8;
            this.fld_btnSavePaint.Text = "Lưu";
            // 
            // fld_btnCancelPaint
            // 
            this.fld_btnCancelPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancelPaint.BOSComment = null;
            this.fld_btnCancelPaint.BOSDataMember = null;
            this.fld_btnCancelPaint.BOSDataSource = null;
            this.fld_btnCancelPaint.BOSDescription = null;
            this.fld_btnCancelPaint.BOSError = null;
            this.fld_btnCancelPaint.BOSFieldGroup = null;
            this.fld_btnCancelPaint.BOSFieldRelation = null;
            this.fld_btnCancelPaint.BOSPrivilege = null;
            this.fld_btnCancelPaint.BOSPropertyName = null;
            this.fld_btnCancelPaint.Location = new System.Drawing.Point(781, 3);
            this.fld_btnCancelPaint.Name = "fld_btnCancelPaint";
            this.fld_btnCancelPaint.Screen = null;
            this.fld_btnCancelPaint.Size = new System.Drawing.Size(86, 27);
            this.fld_btnCancelPaint.TabIndex = 9;
            this.fld_btnCancelPaint.Text = "Hủy";
            // 
            // fld_btnAddPaint
            // 
            this.fld_btnAddPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddPaint.BOSComment = null;
            this.fld_btnAddPaint.BOSDataMember = null;
            this.fld_btnAddPaint.BOSDataSource = null;
            this.fld_btnAddPaint.BOSDescription = null;
            this.fld_btnAddPaint.BOSError = null;
            this.fld_btnAddPaint.BOSFieldGroup = null;
            this.fld_btnAddPaint.BOSFieldRelation = null;
            this.fld_btnAddPaint.BOSPrivilege = null;
            this.fld_btnAddPaint.BOSPropertyName = null;
            this.fld_btnAddPaint.Location = new System.Drawing.Point(597, 3);
            this.fld_btnAddPaint.Name = "fld_btnAddPaint";
            this.fld_btnAddPaint.Screen = null;
            this.fld_btnAddPaint.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAddPaint.TabIndex = 7;
            this.fld_btnAddPaint.Text = "Thêm";
            // 
            // gridView28
            // 
            this.gridView28.Name = "gridView28";
            this.gridView28.PaintStyleName = "Office2003";
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(689, 3);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(86, 27);
            this.fld_btnSave.TabIndex = 4;
            this.fld_btnSave.Text = "Lưu";
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(781, 3);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(86, 27);
            this.fld_btnCancel.TabIndex = 5;
            this.fld_btnCancel.Text = "Hủy";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAdd.BOSComment = null;
            this.fld_btnAdd.BOSDataMember = null;
            this.fld_btnAdd.BOSDataSource = null;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = null;
            this.fld_btnAdd.BOSFieldRelation = null;
            this.fld_btnAdd.BOSPrivilege = null;
            this.fld_btnAdd.BOSPropertyName = null;
            this.fld_btnAdd.Location = new System.Drawing.Point(597, 3);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(86, 27);
            this.fld_btnAdd.TabIndex = 4;
            this.fld_btnAdd.Text = "Thêm";
            // 
            // gridView29
            // 
            this.gridView29.Name = "gridView29";
            this.gridView29.PaintStyleName = "Office2003";
            // 
            // gridView30
            // 
            this.gridView30.Name = "gridView30";
            this.gridView30.PaintStyleName = "Office2003";
            // 
            // gridView31
            // 
            this.gridView31.Name = "gridView31";
            this.gridView31.PaintStyleName = "Office2003";
            // 
            // gridView32
            // 
            this.gridView32.Name = "gridView32";
            this.gridView32.PaintStyleName = "Office2003";
            // 
            // gridView33
            // 
            this.gridView33.Name = "gridView33";
            this.gridView33.PaintStyleName = "Office2003";
            // 
            // gridView34
            // 
            this.gridView34.Name = "gridView34";
            this.gridView34.PaintStyleName = "Office2003";
            // 
            // gridView35
            // 
            this.gridView35.Name = "gridView35";
            this.gridView35.PaintStyleName = "Office2003";
            // 
            // gridView36
            // 
            this.gridView36.Name = "gridView36";
            this.gridView36.PaintStyleName = "Office2003";
            // 
            // gridView37
            // 
            this.gridView37.Name = "gridView37";
            this.gridView37.PaintStyleName = "Office2003";
            // 
            // fld_tabQuality
            // 
            this.fld_tabQuality.Controls.Add(this.splitContainerControl2);
            this.fld_tabQuality.Name = "fld_tabQuality";
            this.fld_tabQuality.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabQuality.Text = "Chất lượng";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.bosGroupControl3);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1187, 623);
            this.splitContainerControl2.SplitterPosition = 247;
            this.splitContainerControl2.TabIndex = 18;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_dgcQuality);
            this.bosGroupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl3.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(247, 623);
            this.bosGroupControl3.TabIndex = 0;
            this.bosGroupControl3.Text = "Chất lượng";
            // 
            // fld_dgcQuality
            // 
            this.fld_dgcQuality.AllowDrop = true;
            this.fld_dgcQuality.BOSComment = "";
            this.fld_dgcQuality.BOSDataMember = null;
            this.fld_dgcQuality.BOSDataSource = "ICProductAttributes";
            this.fld_dgcQuality.BOSDescription = null;
            this.fld_dgcQuality.BOSError = "";
            this.fld_dgcQuality.BOSFieldGroup = "Accept";
            this.fld_dgcQuality.BOSFieldRelation = null;
            this.fld_dgcQuality.BOSGridType = null;
            this.fld_dgcQuality.BOSPrivilege = "";
            this.fld_dgcQuality.BOSPropertyName = null;
            this.fld_dgcQuality.CommodityType = "";
            this.fld_dgcQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcQuality.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcQuality.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcQuality.MainView = this.fld_dgvProductType;
            this.fld_dgcQuality.Name = "fld_dgcQuality";
            this.fld_dgcQuality.PrintReport = false;
            this.fld_dgcQuality.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcQuality, true);
            this.fld_dgcQuality.Size = new System.Drawing.Size(243, 598);
            this.fld_dgcQuality.TabIndex = 5;
            this.fld_dgcQuality.Tag = "DC";
            this.fld_dgcQuality.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcQuality;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosGroupControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(930, 623);
            this.panelControl1.TabIndex = 0;
            // 
            // bosGroupControl4
            // 
            this.bosGroupControl4.BOSComment = null;
            this.bosGroupControl4.BOSDataMember = null;
            this.bosGroupControl4.BOSDataSource = null;
            this.bosGroupControl4.BOSDescription = null;
            this.bosGroupControl4.BOSError = null;
            this.bosGroupControl4.BOSFieldGroup = null;
            this.bosGroupControl4.BOSFieldRelation = null;
            this.bosGroupControl4.BOSPrivilege = null;
            this.bosGroupControl4.BOSPropertyName = null;
            this.bosGroupControl4.Controls.Add(this.fld_dgcICConfigQualityAccordWoodType);
            this.bosGroupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl4.Location = new System.Drawing.Point(2, 2);
            this.bosGroupControl4.Name = "bosGroupControl4";
            this.bosGroupControl4.Screen = null;
            this.bosGroupControl4.Size = new System.Drawing.Size(926, 619);
            this.bosGroupControl4.TabIndex = 2;
            this.bosGroupControl4.Text = "Chất lượng theo loại gỗ";
            // 
            // fld_dgcICConfigQualityAccordWoodType
            // 
            this.fld_dgcICConfigQualityAccordWoodType.AllowDrop = true;
            this.fld_dgcICConfigQualityAccordWoodType.BOSComment = "";
            this.fld_dgcICConfigQualityAccordWoodType.BOSDataMember = null;
            this.fld_dgcICConfigQualityAccordWoodType.BOSDataSource = "ICConfigAccordWoodTypes";
            this.fld_dgcICConfigQualityAccordWoodType.BOSDescription = null;
            this.fld_dgcICConfigQualityAccordWoodType.BOSError = "";
            this.fld_dgcICConfigQualityAccordWoodType.BOSFieldGroup = "";
            this.fld_dgcICConfigQualityAccordWoodType.BOSFieldRelation = null;
            this.fld_dgcICConfigQualityAccordWoodType.BOSGridType = null;
            this.fld_dgcICConfigQualityAccordWoodType.BOSPrivilege = "";
            this.fld_dgcICConfigQualityAccordWoodType.BOSPropertyName = null;
            this.fld_dgcICConfigQualityAccordWoodType.CommodityType = "";
            this.fld_dgcICConfigQualityAccordWoodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICConfigQualityAccordWoodType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICConfigQualityAccordWoodType.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICConfigQualityAccordWoodType.MainView = this.gridView57;
            this.fld_dgcICConfigQualityAccordWoodType.Name = "fld_dgcICConfigQualityAccordWoodType";
            this.fld_dgcICConfigQualityAccordWoodType.PrintReport = false;
            this.fld_dgcICConfigQualityAccordWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICConfigQualityAccordWoodType, true);
            this.fld_dgcICConfigQualityAccordWoodType.Size = new System.Drawing.Size(922, 594);
            this.fld_dgcICConfigQualityAccordWoodType.TabIndex = 7;
            this.fld_dgcICConfigQualityAccordWoodType.Tag = "DC";
            this.fld_dgcICConfigQualityAccordWoodType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView57});
            // 
            // gridView57
            // 
            this.gridView57.GridControl = this.fld_dgcICConfigQualityAccordWoodType;
            this.gridView57.Name = "gridView57";
            this.gridView57.PaintStyleName = "Office2003";
            // 
            // fld_tabFSCType
            // 
            this.fld_tabFSCType.Controls.Add(this.fld_dgcTTMT);
            this.fld_tabFSCType.Name = "fld_tabFSCType";
            this.fld_tabFSCType.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabFSCType.Text = "Tình trạng môi trường";
            // 
            // fld_dgcTTMT
            // 
            this.fld_dgcTTMT.AllowDrop = true;
            this.fld_dgcTTMT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcTTMT.BOSComment = "";
            this.fld_dgcTTMT.BOSDataMember = null;
            this.fld_dgcTTMT.BOSDataSource = "ICProductAttributes";
            this.fld_dgcTTMT.BOSDescription = null;
            this.fld_dgcTTMT.BOSError = "";
            this.fld_dgcTTMT.BOSFieldGroup = "Accept";
            this.fld_dgcTTMT.BOSFieldRelation = null;
            this.fld_dgcTTMT.BOSGridType = null;
            this.fld_dgcTTMT.BOSPrivilege = "";
            this.fld_dgcTTMT.BOSPropertyName = null;
            this.fld_dgcTTMT.CommodityType = "";
            this.fld_dgcTTMT.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcTTMT.Location = new System.Drawing.Point(8, 8);
            this.fld_dgcTTMT.MainView = this.gridView38;
            this.fld_dgcTTMT.Name = "fld_dgcTTMT";
            this.fld_dgcTTMT.PrintReport = false;
            this.fld_dgcTTMT.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcTTMT, true);
            this.fld_dgcTTMT.Size = new System.Drawing.Size(1176, 612);
            this.fld_dgcTTMT.TabIndex = 5;
            this.fld_dgcTTMT.Tag = "DC";
            this.fld_dgcTTMT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView38});
            // 
            // gridView38
            // 
            this.gridView38.GridControl = this.fld_dgcTTMT;
            this.gridView38.Name = "gridView38";
            this.gridView38.PaintStyleName = "Office2003";
            // 
            // fld_tabHTType
            // 
            this.fld_tabHTType.Controls.Add(this.fld_dgcHTType);
            this.fld_tabHTType.Name = "fld_tabHTType";
            this.fld_tabHTType.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabHTType.Text = "Hoàn thiện";
            // 
            // fld_dgcHTType
            // 
            this.fld_dgcHTType.AllowDrop = true;
            this.fld_dgcHTType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHTType.BOSComment = "";
            this.fld_dgcHTType.BOSDataMember = null;
            this.fld_dgcHTType.BOSDataSource = "ICProductAttributes";
            this.fld_dgcHTType.BOSDescription = null;
            this.fld_dgcHTType.BOSError = "";
            this.fld_dgcHTType.BOSFieldGroup = "Accept";
            this.fld_dgcHTType.BOSFieldRelation = null;
            this.fld_dgcHTType.BOSGridType = null;
            this.fld_dgcHTType.BOSPrivilege = "";
            this.fld_dgcHTType.BOSPropertyName = null;
            this.fld_dgcHTType.CommodityType = "";
            this.fld_dgcHTType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHTType.Location = new System.Drawing.Point(8, 8);
            this.fld_dgcHTType.MainView = this.gridView39;
            this.fld_dgcHTType.Name = "fld_dgcHTType";
            this.fld_dgcHTType.PrintReport = false;
            this.fld_dgcHTType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHTType, true);
            this.fld_dgcHTType.Size = new System.Drawing.Size(1176, 612);
            this.fld_dgcHTType.TabIndex = 5;
            this.fld_dgcHTType.Tag = "DC";
            this.fld_dgcHTType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView39});
            // 
            // gridView39
            // 
            this.gridView39.GridControl = this.fld_dgcHTType;
            this.gridView39.Name = "gridView39";
            this.gridView39.PaintStyleName = "Office2003";
            // 
            // fld_tabPaintType
            // 
            this.fld_tabPaintType.Controls.Add(this.fld_dgcCoLor);
            this.fld_tabPaintType.Name = "fld_tabPaintType";
            this.ScreenHelper.SetShowHelp(this.fld_tabPaintType, true);
            this.fld_tabPaintType.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabPaintType.Text = "Màu sơn";
            // 
            // fld_dgcCoLor
            // 
            this.fld_dgcCoLor.AllowDrop = true;
            this.fld_dgcCoLor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCoLor.BOSComment = "";
            this.fld_dgcCoLor.BOSDataMember = null;
            this.fld_dgcCoLor.BOSDataSource = "ICProductAttributes";
            this.fld_dgcCoLor.BOSDescription = null;
            this.fld_dgcCoLor.BOSError = "";
            this.fld_dgcCoLor.BOSFieldGroup = "Accept";
            this.fld_dgcCoLor.BOSFieldRelation = null;
            this.fld_dgcCoLor.BOSGridType = null;
            this.fld_dgcCoLor.BOSPrivilege = "";
            this.fld_dgcCoLor.BOSPropertyName = null;
            this.fld_dgcCoLor.CommodityType = "";
            this.fld_dgcCoLor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCoLor.Location = new System.Drawing.Point(8, 8);
            this.fld_dgcCoLor.MainView = this.gridView40;
            this.fld_dgcCoLor.Name = "fld_dgcCoLor";
            this.fld_dgcCoLor.PrintReport = false;
            this.fld_dgcCoLor.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcCoLor, true);
            this.fld_dgcCoLor.Size = new System.Drawing.Size(1176, 612);
            this.fld_dgcCoLor.TabIndex = 5;
            this.fld_dgcCoLor.Tag = "DC";
            this.fld_dgcCoLor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView40});
            // 
            // gridView40
            // 
            this.gridView40.GridControl = this.fld_dgcCoLor;
            this.gridView40.Name = "gridView40";
            this.gridView40.PaintStyleName = "Office2003";
            // 
            // fld_tabWoodType
            // 
            this.fld_tabWoodType.Controls.Add(this.fld_dgcWoodType);
            this.fld_tabWoodType.Name = "fld_tabWoodType";
            this.ScreenHelper.SetShowHelp(this.fld_tabWoodType, true);
            this.fld_tabWoodType.Size = new System.Drawing.Size(1201, 630);
            this.fld_tabWoodType.Text = "Loại gổ";
            // 
            // fld_dgcWoodType
            // 
            this.fld_dgcWoodType.AllowDrop = true;
            this.fld_dgcWoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcWoodType.BOSComment = "";
            this.fld_dgcWoodType.BOSDataMember = null;
            this.fld_dgcWoodType.BOSDataSource = "ICProductAttributes";
            this.fld_dgcWoodType.BOSDescription = null;
            this.fld_dgcWoodType.BOSError = "";
            this.fld_dgcWoodType.BOSFieldGroup = "Accept";
            this.fld_dgcWoodType.BOSFieldRelation = null;
            this.fld_dgcWoodType.BOSGridType = null;
            this.fld_dgcWoodType.BOSPrivilege = "";
            this.fld_dgcWoodType.BOSPropertyName = null;
            this.fld_dgcWoodType.CommodityType = "";
            this.fld_dgcWoodType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcWoodType.Location = new System.Drawing.Point(5, 14);
            this.fld_dgcWoodType.MainView = this.gridView41;
            this.fld_dgcWoodType.Name = "fld_dgcWoodType";
            this.fld_dgcWoodType.PrintReport = false;
            this.fld_dgcWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcWoodType, true);
            this.fld_dgcWoodType.Size = new System.Drawing.Size(1190, 609);
            this.fld_dgcWoodType.TabIndex = 5;
            this.fld_dgcWoodType.Tag = "DC";
            this.fld_dgcWoodType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView41});
            // 
            // gridView41
            // 
            this.gridView41.GridControl = this.fld_dgcWoodType;
            this.gridView41.Name = "gridView41";
            this.gridView41.PaintStyleName = "Office2003";
            // 
            // fld_dgcProductAttributes
            // 
            this.fld_dgcProductAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductAttributes.BOSComment = null;
            this.fld_dgcProductAttributes.BOSDataMember = null;
            this.fld_dgcProductAttributes.BOSDataSource = null;
            this.fld_dgcProductAttributes.BOSDescription = null;
            this.fld_dgcProductAttributes.BOSError = null;
            this.fld_dgcProductAttributes.BOSFieldGroup = null;
            this.fld_dgcProductAttributes.BOSFieldRelation = null;
            this.fld_dgcProductAttributes.BOSPrivilege = null;
            this.fld_dgcProductAttributes.BOSPropertyName = null;
            this.fld_dgcProductAttributes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProductAttributes.Name = "fld_dgcProductAttributes";
            this.fld_dgcProductAttributes.Screen = null;
            this.fld_dgcProductAttributes.SelectedTabPage = this.fld_tabWoodType;
            this.ScreenHelper.SetShowHelp(this.fld_dgcProductAttributes, true);
            this.fld_dgcProductAttributes.Size = new System.Drawing.Size(1203, 655);
            this.fld_dgcProductAttributes.TabIndex = 15;
            this.fld_dgcProductAttributes.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabWoodType,
            this.fld_tabPaintType,
            this.fld_tabHTType,
            this.fld_tabFSCType,
            this.fld_tabThink,
            this.fld_tabQuality,
            this.xtraTabPage12,
            this.xtraTabPage13,
            this.fld_tabAddMaterialType,
            this.xtraTabPage14,
            this.fld_GroupCluster,
            this.fld_tabPerimeterGroup,
            this.fld_tabLengthGroup,
            this.fld_tabWidthGroup,
            this.xtraTabPage15});
            this.fld_dgcProductAttributes.Tag = "DC";
            // 
            // fld_tabThink
            // 
            this.fld_tabThink.Controls.Add(this.splitContainerControl1);
            this.fld_tabThink.Name = "fld_tabThink";
            this.fld_tabThink.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabThink.Text = "Độ dày";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1187, 623);
            this.splitContainerControl1.SplitterPosition = 358;
            this.splitContainerControl1.TabIndex = 17;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcThickGridControl);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(358, 623);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Độ dày";
            // 
            // fld_dgcThickGridControl
            // 
            this.fld_dgcThickGridControl.BOSComment = null;
            this.fld_dgcThickGridControl.BOSDataMember = null;
            this.fld_dgcThickGridControl.BOSDataSource = "ICProductAttributes";
            this.fld_dgcThickGridControl.BOSDescription = null;
            this.fld_dgcThickGridControl.BOSError = null;
            this.fld_dgcThickGridControl.BOSFieldGroup = "Accept";
            this.fld_dgcThickGridControl.BOSFieldRelation = null;
            this.fld_dgcThickGridControl.BOSGridType = null;
            this.fld_dgcThickGridControl.BOSPrivilege = null;
            this.fld_dgcThickGridControl.BOSPropertyName = null;
            this.fld_dgcThickGridControl.CommodityType = "";
            this.fld_dgcThickGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcThickGridControl.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcThickGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcThickGridControl.Name = "fld_dgcThickGridControl";
            this.fld_dgcThickGridControl.PrintReport = false;
            this.fld_dgcThickGridControl.Screen = null;
            this.fld_dgcThickGridControl.Size = new System.Drawing.Size(354, 598);
            this.fld_dgcThickGridControl.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.bosGroupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(819, 623);
            this.panelControl2.TabIndex = 0;
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcICConfigThinkAccordWoodType);
            this.bosGroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl2.Location = new System.Drawing.Point(2, 2);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(815, 619);
            this.bosGroupControl2.TabIndex = 2;
            this.bosGroupControl2.Text = "Độ dày theo loại gỗ";
            // 
            // fld_dgcICConfigThinkAccordWoodType
            // 
            this.fld_dgcICConfigThinkAccordWoodType.AllowDrop = true;
            this.fld_dgcICConfigThinkAccordWoodType.BOSComment = "";
            this.fld_dgcICConfigThinkAccordWoodType.BOSDataMember = null;
            this.fld_dgcICConfigThinkAccordWoodType.BOSDataSource = "ICConfigAccordWoodTypes";
            this.fld_dgcICConfigThinkAccordWoodType.BOSDescription = null;
            this.fld_dgcICConfigThinkAccordWoodType.BOSError = "";
            this.fld_dgcICConfigThinkAccordWoodType.BOSFieldGroup = "";
            this.fld_dgcICConfigThinkAccordWoodType.BOSFieldRelation = null;
            this.fld_dgcICConfigThinkAccordWoodType.BOSGridType = null;
            this.fld_dgcICConfigThinkAccordWoodType.BOSPrivilege = "";
            this.fld_dgcICConfigThinkAccordWoodType.BOSPropertyName = null;
            this.fld_dgcICConfigThinkAccordWoodType.CommodityType = "";
            this.fld_dgcICConfigThinkAccordWoodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICConfigThinkAccordWoodType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICConfigThinkAccordWoodType.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICConfigThinkAccordWoodType.MainView = this.gridView51;
            this.fld_dgcICConfigThinkAccordWoodType.Name = "fld_dgcICConfigThinkAccordWoodType";
            this.fld_dgcICConfigThinkAccordWoodType.PrintReport = false;
            this.fld_dgcICConfigThinkAccordWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICConfigThinkAccordWoodType, true);
            this.fld_dgcICConfigThinkAccordWoodType.Size = new System.Drawing.Size(811, 594);
            this.fld_dgcICConfigThinkAccordWoodType.TabIndex = 8;
            this.fld_dgcICConfigThinkAccordWoodType.Tag = "DC";
            this.fld_dgcICConfigThinkAccordWoodType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView51});
            // 
            // gridView51
            // 
            this.gridView51.GridControl = this.fld_dgcICConfigThinkAccordWoodType;
            this.gridView51.Name = "gridView51";
            this.gridView51.PaintStyleName = "Office2003";
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Controls.Add(this.fld_dgcICProductAttributes);
            this.xtraTabPage12.Name = "xtraTabPage12";
            this.xtraTabPage12.Size = new System.Drawing.Size(1187, 623);
            this.xtraTabPage12.Text = "Đặc tính";
            // 
            // fld_dgcICProductAttributes
            // 
            this.fld_dgcICProductAttributes.AllowDrop = true;
            this.fld_dgcICProductAttributes.BOSComment = "";
            this.fld_dgcICProductAttributes.BOSDataMember = null;
            this.fld_dgcICProductAttributes.BOSDataSource = " ICProductAttributes";
            this.fld_dgcICProductAttributes.BOSDescription = null;
            this.fld_dgcICProductAttributes.BOSError = "";
            this.fld_dgcICProductAttributes.BOSFieldGroup = "Accept";
            this.fld_dgcICProductAttributes.BOSFieldRelation = null;
            this.fld_dgcICProductAttributes.BOSGridType = null;
            this.fld_dgcICProductAttributes.BOSPrivilege = "";
            this.fld_dgcICProductAttributes.BOSPropertyName = null;
            this.fld_dgcICProductAttributes.CommodityType = "";
            this.fld_dgcICProductAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductAttributes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductAttributes.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductAttributes.MainView = this.gridView48;
            this.fld_dgcICProductAttributes.Name = "fld_dgcICProductAttributes";
            this.fld_dgcICProductAttributes.PrintReport = false;
            this.fld_dgcICProductAttributes.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductAttributes, true);
            this.fld_dgcICProductAttributes.Size = new System.Drawing.Size(1187, 623);
            this.fld_dgcICProductAttributes.TabIndex = 6;
            this.fld_dgcICProductAttributes.Tag = "DC";
            this.fld_dgcICProductAttributes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView48});
            // 
            // gridView48
            // 
            this.gridView48.GridControl = this.fld_dgcICProductAttributes;
            this.gridView48.Name = "gridView48";
            this.gridView48.PaintStyleName = "Office2003";
            // 
            // xtraTabPage13
            // 
            this.xtraTabPage13.Controls.Add(this.fld_dgcICProductGroupHeights);
            this.xtraTabPage13.Name = "xtraTabPage13";
            this.xtraTabPage13.Size = new System.Drawing.Size(1187, 623);
            this.xtraTabPage13.Text = "Nhóm dày";
            // 
            // fld_dgcICProductGroupHeights
            // 
            this.fld_dgcICProductGroupHeights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductGroupHeights.BOSComment = null;
            this.fld_dgcICProductGroupHeights.BOSDataMember = null;
            this.fld_dgcICProductGroupHeights.BOSDataSource = "ICProductGroupHeights";
            this.fld_dgcICProductGroupHeights.BOSDescription = null;
            this.fld_dgcICProductGroupHeights.BOSError = null;
            this.fld_dgcICProductGroupHeights.BOSFieldGroup = null;
            this.fld_dgcICProductGroupHeights.BOSFieldRelation = null;
            this.fld_dgcICProductGroupHeights.BOSGridType = null;
            this.fld_dgcICProductGroupHeights.BOSPrivilege = null;
            this.fld_dgcICProductGroupHeights.BOSPropertyName = null;
            this.fld_dgcICProductGroupHeights.CommodityType = "";
            this.fld_dgcICProductGroupHeights.Location = new System.Drawing.Point(1, 3);
            this.fld_dgcICProductGroupHeights.MenuManager = this.screenToolbar;
            this.fld_dgcICProductGroupHeights.Name = "fld_dgcICProductGroupHeights";
            this.fld_dgcICProductGroupHeights.PrintReport = false;
            this.fld_dgcICProductGroupHeights.Screen = null;
            this.fld_dgcICProductGroupHeights.Size = new System.Drawing.Size(1183, 620);
            this.fld_dgcICProductGroupHeights.TabIndex = 0;
            // 
            // fld_tabAddMaterialType
            // 
            this.fld_tabAddMaterialType.Controls.Add(this.fld_dgcICProductAttributeAddMaterialType);
            this.fld_tabAddMaterialType.Name = "fld_tabAddMaterialType";
            this.fld_tabAddMaterialType.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabAddMaterialType.Text = "Loại chỉ viền";
            // 
            // fld_dgcICProductAttributeAddMaterialType
            // 
            this.fld_dgcICProductAttributeAddMaterialType.AllowDrop = true;
            this.fld_dgcICProductAttributeAddMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductAttributeAddMaterialType.BOSComment = "";
            this.fld_dgcICProductAttributeAddMaterialType.BOSDataMember = null;
            this.fld_dgcICProductAttributeAddMaterialType.BOSDataSource = "ICProductAttributes";
            this.fld_dgcICProductAttributeAddMaterialType.BOSDescription = null;
            this.fld_dgcICProductAttributeAddMaterialType.BOSError = "";
            this.fld_dgcICProductAttributeAddMaterialType.BOSFieldGroup = "Accept";
            this.fld_dgcICProductAttributeAddMaterialType.BOSFieldRelation = null;
            this.fld_dgcICProductAttributeAddMaterialType.BOSGridType = null;
            this.fld_dgcICProductAttributeAddMaterialType.BOSPrivilege = "";
            this.fld_dgcICProductAttributeAddMaterialType.BOSPropertyName = null;
            this.fld_dgcICProductAttributeAddMaterialType.CommodityType = "";
            this.fld_dgcICProductAttributeAddMaterialType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductAttributeAddMaterialType.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcICProductAttributeAddMaterialType.MainView = this.gridView49;
            this.fld_dgcICProductAttributeAddMaterialType.Name = "fld_dgcICProductAttributeAddMaterialType";
            this.fld_dgcICProductAttributeAddMaterialType.PrintReport = false;
            this.fld_dgcICProductAttributeAddMaterialType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductAttributeAddMaterialType, true);
            this.fld_dgcICProductAttributeAddMaterialType.Size = new System.Drawing.Size(1176, 613);
            this.fld_dgcICProductAttributeAddMaterialType.TabIndex = 6;
            this.fld_dgcICProductAttributeAddMaterialType.Tag = "DC";
            this.fld_dgcICProductAttributeAddMaterialType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView49});
            // 
            // gridView49
            // 
            this.gridView49.GridControl = this.fld_dgcICProductAttributeAddMaterialType;
            this.gridView49.Name = "gridView49";
            this.gridView49.PaintStyleName = "Office2003";
            // 
            // xtraTabPage14
            // 
            this.xtraTabPage14.Controls.Add(this.attributesGridControl1);
            this.xtraTabPage14.Name = "xtraTabPage14";
            this.xtraTabPage14.Size = new System.Drawing.Size(1187, 623);
            this.xtraTabPage14.Text = "Công đoạn theo đặc tính";
            // 
            // attributesGridControl1
            // 
            this.attributesGridControl1.AllowDrop = true;
            this.attributesGridControl1.BOSComment = "";
            this.attributesGridControl1.BOSDataMember = null;
            this.attributesGridControl1.BOSDataSource = " ICProductAttributes";
            this.attributesGridControl1.BOSDescription = null;
            this.attributesGridControl1.BOSError = "";
            this.attributesGridControl1.BOSFieldGroup = "Accept";
            this.attributesGridControl1.BOSFieldRelation = null;
            this.attributesGridControl1.BOSGridType = null;
            this.attributesGridControl1.BOSPrivilege = "";
            this.attributesGridControl1.BOSPropertyName = null;
            this.attributesGridControl1.CommodityType = "";
            this.attributesGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.attributesGridControl1.Location = new System.Drawing.Point(0, 0);
            this.attributesGridControl1.MainView = this.gridView52;
            this.attributesGridControl1.Name = "attributesGridControl1";
            this.attributesGridControl1.PrintReport = false;
            this.attributesGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.attributesGridControl1, true);
            this.attributesGridControl1.Size = new System.Drawing.Size(1187, 623);
            this.attributesGridControl1.TabIndex = 7;
            this.attributesGridControl1.Tag = "DC";
            this.attributesGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView52});
            // 
            // gridView52
            // 
            this.gridView52.GridControl = this.attributesGridControl1;
            this.gridView52.Name = "gridView52";
            this.gridView52.PaintStyleName = "Office2003";
            // 
            // fld_GroupCluster
            // 
            this.fld_GroupCluster.Controls.Add(this.fld_dgcSemiGroupType);
            this.fld_GroupCluster.Name = "fld_GroupCluster";
            this.fld_GroupCluster.Size = new System.Drawing.Size(1187, 623);
            this.fld_GroupCluster.Text = "Nhóm cụm";
            // 
            // fld_dgcSemiGroupType
            // 
            this.fld_dgcSemiGroupType.AllowDrop = true;
            this.fld_dgcSemiGroupType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSemiGroupType.BOSComment = "";
            this.fld_dgcSemiGroupType.BOSDataMember = null;
            this.fld_dgcSemiGroupType.BOSDataSource = "ICProductAttributes";
            this.fld_dgcSemiGroupType.BOSDescription = null;
            this.fld_dgcSemiGroupType.BOSError = "";
            this.fld_dgcSemiGroupType.BOSFieldGroup = "Accept";
            this.fld_dgcSemiGroupType.BOSFieldRelation = null;
            this.fld_dgcSemiGroupType.BOSGridType = null;
            this.fld_dgcSemiGroupType.BOSPrivilege = "";
            this.fld_dgcSemiGroupType.BOSPropertyName = null;
            this.fld_dgcSemiGroupType.CommodityType = "";
            this.fld_dgcSemiGroupType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSemiGroupType.Location = new System.Drawing.Point(1, 0);
            this.fld_dgcSemiGroupType.MainView = this.gridView53;
            this.fld_dgcSemiGroupType.Name = "fld_dgcSemiGroupType";
            this.fld_dgcSemiGroupType.PrintReport = false;
            this.fld_dgcSemiGroupType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcSemiGroupType, true);
            this.fld_dgcSemiGroupType.Size = new System.Drawing.Size(1179, 623);
            this.fld_dgcSemiGroupType.TabIndex = 7;
            this.fld_dgcSemiGroupType.Tag = "DC";
            this.fld_dgcSemiGroupType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView53});
            // 
            // gridView53
            // 
            this.gridView53.GridControl = this.fld_dgcSemiGroupType;
            this.gridView53.Name = "gridView53";
            this.gridView53.PaintStyleName = "Office2003";
            // 
            // fld_tabPerimeterGroup
            // 
            this.fld_tabPerimeterGroup.Controls.Add(this.fld_dgcICPerimeterGroups);
            this.fld_tabPerimeterGroup.Name = "fld_tabPerimeterGroup";
            this.fld_tabPerimeterGroup.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabPerimeterGroup.Text = "Nhóm hoành";
            // 
            // fld_dgcICPerimeterGroups
            // 
            this.fld_dgcICPerimeterGroups.AllowDrop = true;
            this.fld_dgcICPerimeterGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICPerimeterGroups.BOSComment = "";
            this.fld_dgcICPerimeterGroups.BOSDataMember = null;
            this.fld_dgcICPerimeterGroups.BOSDataSource = "ICPerimeterGroups";
            this.fld_dgcICPerimeterGroups.BOSDescription = null;
            this.fld_dgcICPerimeterGroups.BOSError = "";
            this.fld_dgcICPerimeterGroups.BOSFieldGroup = "Accept";
            this.fld_dgcICPerimeterGroups.BOSFieldRelation = null;
            this.fld_dgcICPerimeterGroups.BOSGridType = null;
            this.fld_dgcICPerimeterGroups.BOSPrivilege = "";
            this.fld_dgcICPerimeterGroups.BOSPropertyName = null;
            this.fld_dgcICPerimeterGroups.CommodityType = "";
            this.fld_dgcICPerimeterGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICPerimeterGroups.Location = new System.Drawing.Point(2, 3);
            this.fld_dgcICPerimeterGroups.MainView = this.gridView56;
            this.fld_dgcICPerimeterGroups.Name = "fld_dgcICPerimeterGroups";
            this.fld_dgcICPerimeterGroups.PrintReport = false;
            this.fld_dgcICPerimeterGroups.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICPerimeterGroups, true);
            this.fld_dgcICPerimeterGroups.Size = new System.Drawing.Size(1185, 617);
            this.fld_dgcICPerimeterGroups.TabIndex = 8;
            this.fld_dgcICPerimeterGroups.Tag = "DC";
            this.fld_dgcICPerimeterGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView56});
            // 
            // gridView56
            // 
            this.gridView56.GridControl = this.fld_dgcICPerimeterGroups;
            this.gridView56.Name = "gridView56";
            this.gridView56.PaintStyleName = "Office2003";
            // 
            // fld_tabLengthGroup
            // 
            this.fld_tabLengthGroup.Controls.Add(this.fld_dgcICLengthGroups);
            this.fld_tabLengthGroup.Name = "fld_tabLengthGroup";
            this.fld_tabLengthGroup.Size = new System.Drawing.Size(1187, 623);
            this.fld_tabLengthGroup.Text = "Nhóm dài";
            // 
            // fld_dgcICLengthGroups
            // 
            this.fld_dgcICLengthGroups.AllowDrop = true;
            this.fld_dgcICLengthGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICLengthGroups.BOSComment = "";
            this.fld_dgcICLengthGroups.BOSDataMember = null;
            this.fld_dgcICLengthGroups.BOSDataSource = "ICLengthGroups";
            this.fld_dgcICLengthGroups.BOSDescription = null;
            this.fld_dgcICLengthGroups.BOSError = "";
            this.fld_dgcICLengthGroups.BOSFieldGroup = "Accept";
            this.fld_dgcICLengthGroups.BOSFieldRelation = null;
            this.fld_dgcICLengthGroups.BOSGridType = null;
            this.fld_dgcICLengthGroups.BOSPrivilege = "";
            this.fld_dgcICLengthGroups.BOSPropertyName = null;
            this.fld_dgcICLengthGroups.CommodityType = "";
            this.fld_dgcICLengthGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICLengthGroups.Location = new System.Drawing.Point(1, 3);
            this.fld_dgcICLengthGroups.MainView = this.gridView58;
            this.fld_dgcICLengthGroups.Name = "fld_dgcICLengthGroups";
            this.fld_dgcICLengthGroups.PrintReport = false;
            this.fld_dgcICLengthGroups.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICLengthGroups, true);
            this.fld_dgcICLengthGroups.Size = new System.Drawing.Size(1183, 620);
            this.fld_dgcICLengthGroups.TabIndex = 8;
            this.fld_dgcICLengthGroups.Tag = "DC";
            this.fld_dgcICLengthGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView58});
            // 
            // gridView58
            // 
            this.gridView58.GridControl = this.fld_dgcICLengthGroups;
            this.gridView58.Name = "gridView58";
            this.gridView58.PaintStyleName = "Office2003";
            // 
            // fld_tabWidthGroup
            // 
            this.fld_tabWidthGroup.Controls.Add(this.fld_dgcICWidthGroups);
            this.fld_tabWidthGroup.Name = "fld_tabWidthGroup";
            this.fld_tabWidthGroup.Size = new System.Drawing.Size(1201, 630);
            this.fld_tabWidthGroup.Text = "Nhóm rộng";
            // 
            // fld_dgcICWidthGroups
            // 
            this.fld_dgcICWidthGroups.AllowDrop = true;
            this.fld_dgcICWidthGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICWidthGroups.BOSComment = "";
            this.fld_dgcICWidthGroups.BOSDataMember = null;
            this.fld_dgcICWidthGroups.BOSDataSource = "ICWidthGroups";
            this.fld_dgcICWidthGroups.BOSDescription = null;
            this.fld_dgcICWidthGroups.BOSError = "";
            this.fld_dgcICWidthGroups.BOSFieldGroup = "Accept";
            this.fld_dgcICWidthGroups.BOSFieldRelation = null;
            this.fld_dgcICWidthGroups.BOSGridType = null;
            this.fld_dgcICWidthGroups.BOSPrivilege = "";
            this.fld_dgcICWidthGroups.BOSPropertyName = null;
            this.fld_dgcICWidthGroups.CommodityType = "";
            this.fld_dgcICWidthGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICWidthGroups.Location = new System.Drawing.Point(2, 1);
            this.fld_dgcICWidthGroups.MainView = this.gridView60;
            this.fld_dgcICWidthGroups.Name = "fld_dgcICWidthGroups";
            this.fld_dgcICWidthGroups.PrintReport = false;
            this.fld_dgcICWidthGroups.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICWidthGroups, true);
            this.fld_dgcICWidthGroups.Size = new System.Drawing.Size(1197, 627);
            this.fld_dgcICWidthGroups.TabIndex = 9;
            this.fld_dgcICWidthGroups.Tag = "DC";
            this.fld_dgcICWidthGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView60});
            // 
            // gridView60
            // 
            this.gridView60.GridControl = this.fld_dgcICWidthGroups;
            this.gridView60.Name = "gridView60";
            this.gridView60.PaintStyleName = "Office2003";
            // 
            // xtraTabPage15
            // 
            this.xtraTabPage15.Controls.Add(this.fld_dgcICMaterialConfigs);
            this.xtraTabPage15.Name = "xtraTabPage15";
            this.xtraTabPage15.Size = new System.Drawing.Size(1187, 623);
            this.xtraTabPage15.Text = "Cấu hình vật tư theo loại gỗ và đặc tính";
            // 
            // fld_dgcICMaterialConfigs
            // 
            this.fld_dgcICMaterialConfigs.AllowDrop = true;
            this.fld_dgcICMaterialConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICMaterialConfigs.BOSComment = "";
            this.fld_dgcICMaterialConfigs.BOSDataMember = null;
            this.fld_dgcICMaterialConfigs.BOSDataSource = "ICMaterialConfigs";
            this.fld_dgcICMaterialConfigs.BOSDescription = null;
            this.fld_dgcICMaterialConfigs.BOSError = "";
            this.fld_dgcICMaterialConfigs.BOSFieldGroup = "Accept";
            this.fld_dgcICMaterialConfigs.BOSFieldRelation = null;
            this.fld_dgcICMaterialConfigs.BOSGridType = null;
            this.fld_dgcICMaterialConfigs.BOSPrivilege = "";
            this.fld_dgcICMaterialConfigs.BOSPropertyName = null;
            this.fld_dgcICMaterialConfigs.CommodityType = "";
            this.fld_dgcICMaterialConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICMaterialConfigs.Location = new System.Drawing.Point(3, 0);
            this.fld_dgcICMaterialConfigs.MainView = this.gridView59;
            this.fld_dgcICMaterialConfigs.Name = "fld_dgcICMaterialConfigs";
            this.fld_dgcICMaterialConfigs.PrintReport = false;
            this.fld_dgcICMaterialConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICMaterialConfigs, true);
            this.fld_dgcICMaterialConfigs.Size = new System.Drawing.Size(1177, 623);
            this.fld_dgcICMaterialConfigs.TabIndex = 9;
            this.fld_dgcICMaterialConfigs.Tag = "DC";
            this.fld_dgcICMaterialConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView59});
            // 
            // gridView59
            // 
            this.gridView59.GridControl = this.fld_dgcICMaterialConfigs;
            this.gridView59.Name = "gridView59";
            this.gridView59.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_dgcProductAttributes);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1203, 655);
            this.bosPanel1.TabIndex = 16;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.qualityGridControl1);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(826, 521);
            this.xtraTabPage7.Text = "Chất lượng";
            // 
            // qualityGridControl1
            // 
            this.qualityGridControl1.AllowDrop = true;
            this.qualityGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityGridControl1.BOSComment = "";
            this.qualityGridControl1.BOSDataMember = null;
            this.qualityGridControl1.BOSDataSource = "ICProductAttributes";
            this.qualityGridControl1.BOSDescription = null;
            this.qualityGridControl1.BOSError = "";
            this.qualityGridControl1.BOSFieldGroup = "Accept";
            this.qualityGridControl1.BOSFieldRelation = null;
            this.qualityGridControl1.BOSGridType = null;
            this.qualityGridControl1.BOSPrivilege = "";
            this.qualityGridControl1.BOSPropertyName = null;
            this.qualityGridControl1.CommodityType = "";
            this.qualityGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.qualityGridControl1.Location = new System.Drawing.Point(8, 8);
            this.qualityGridControl1.MainView = this.gridView42;
            this.qualityGridControl1.Name = "qualityGridControl1";
            this.qualityGridControl1.PrintReport = false;
            this.qualityGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.qualityGridControl1, true);
            this.qualityGridControl1.Size = new System.Drawing.Size(815, 510);
            this.qualityGridControl1.TabIndex = 5;
            this.qualityGridControl1.Tag = "DC";
            this.qualityGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView42});
            // 
            // gridView42
            // 
            this.gridView42.GridControl = this.qualityGridControl1;
            this.gridView42.Name = "gridView42";
            this.gridView42.PaintStyleName = "Office2003";
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.woodTypeGridControl1);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage8, true);
            this.xtraTabPage8.Size = new System.Drawing.Size(826, 521);
            this.xtraTabPage8.Text = "Loại gổ";
            // 
            // woodTypeGridControl1
            // 
            this.woodTypeGridControl1.AllowDrop = true;
            this.woodTypeGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.woodTypeGridControl1.BOSComment = "";
            this.woodTypeGridControl1.BOSDataMember = null;
            this.woodTypeGridControl1.BOSDataSource = "ICProductAttributes";
            this.woodTypeGridControl1.BOSDescription = null;
            this.woodTypeGridControl1.BOSError = "";
            this.woodTypeGridControl1.BOSFieldGroup = "Accept";
            this.woodTypeGridControl1.BOSFieldRelation = null;
            this.woodTypeGridControl1.BOSGridType = null;
            this.woodTypeGridControl1.BOSPrivilege = "";
            this.woodTypeGridControl1.BOSPropertyName = null;
            this.woodTypeGridControl1.CommodityType = "";
            this.woodTypeGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.woodTypeGridControl1.Location = new System.Drawing.Point(5, 14);
            this.woodTypeGridControl1.MainView = this.gridView43;
            this.woodTypeGridControl1.Name = "woodTypeGridControl1";
            this.woodTypeGridControl1.PrintReport = false;
            this.woodTypeGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.woodTypeGridControl1, true);
            this.woodTypeGridControl1.Size = new System.Drawing.Size(815, 477);
            this.woodTypeGridControl1.TabIndex = 5;
            this.woodTypeGridControl1.Tag = "DC";
            this.woodTypeGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView43});
            // 
            // gridView43
            // 
            this.gridView43.GridControl = this.woodTypeGridControl1;
            this.gridView43.Name = "gridView43";
            this.gridView43.PaintStyleName = "Office2003";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.coLorGridControl1);
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.ScreenHelper.SetShowHelp(this.xtraTabPage9, true);
            this.xtraTabPage9.Size = new System.Drawing.Size(826, 521);
            this.xtraTabPage9.Text = "Màu sơn";
            // 
            // coLorGridControl1
            // 
            this.coLorGridControl1.AllowDrop = true;
            this.coLorGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coLorGridControl1.BOSComment = "";
            this.coLorGridControl1.BOSDataMember = null;
            this.coLorGridControl1.BOSDataSource = "ICProductAttributes";
            this.coLorGridControl1.BOSDescription = null;
            this.coLorGridControl1.BOSError = "";
            this.coLorGridControl1.BOSFieldGroup = "Accept";
            this.coLorGridControl1.BOSFieldRelation = null;
            this.coLorGridControl1.BOSGridType = null;
            this.coLorGridControl1.BOSPrivilege = "";
            this.coLorGridControl1.BOSPropertyName = null;
            this.coLorGridControl1.CommodityType = "";
            this.coLorGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.coLorGridControl1.Location = new System.Drawing.Point(8, 8);
            this.coLorGridControl1.MainView = this.gridView44;
            this.coLorGridControl1.Name = "coLorGridControl1";
            this.coLorGridControl1.PrintReport = false;
            this.coLorGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.coLorGridControl1, true);
            this.coLorGridControl1.Size = new System.Drawing.Size(815, 477);
            this.coLorGridControl1.TabIndex = 5;
            this.coLorGridControl1.Tag = "DC";
            this.coLorGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView44});
            // 
            // gridView44
            // 
            this.gridView44.GridControl = this.coLorGridControl1;
            this.gridView44.Name = "gridView44";
            this.gridView44.PaintStyleName = "Office2003";
            // 
            // xtraTabPage10
            // 
            this.xtraTabPage10.Controls.Add(this.htTypeGridControl1);
            this.xtraTabPage10.Name = "xtraTabPage10";
            this.xtraTabPage10.Size = new System.Drawing.Size(826, 521);
            this.xtraTabPage10.Text = "Hoàn thiện";
            // 
            // htTypeGridControl1
            // 
            this.htTypeGridControl1.AllowDrop = true;
            this.htTypeGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htTypeGridControl1.BOSComment = "";
            this.htTypeGridControl1.BOSDataMember = null;
            this.htTypeGridControl1.BOSDataSource = "ICProductAttributes";
            this.htTypeGridControl1.BOSDescription = null;
            this.htTypeGridControl1.BOSError = "";
            this.htTypeGridControl1.BOSFieldGroup = "Accept";
            this.htTypeGridControl1.BOSFieldRelation = null;
            this.htTypeGridControl1.BOSGridType = null;
            this.htTypeGridControl1.BOSPrivilege = "";
            this.htTypeGridControl1.BOSPropertyName = null;
            this.htTypeGridControl1.CommodityType = "";
            this.htTypeGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.htTypeGridControl1.Location = new System.Drawing.Point(8, 8);
            this.htTypeGridControl1.MainView = this.gridView45;
            this.htTypeGridControl1.Name = "htTypeGridControl1";
            this.htTypeGridControl1.PrintReport = false;
            this.htTypeGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.htTypeGridControl1, true);
            this.htTypeGridControl1.Size = new System.Drawing.Size(815, 477);
            this.htTypeGridControl1.TabIndex = 5;
            this.htTypeGridControl1.Tag = "DC";
            this.htTypeGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView45});
            // 
            // gridView45
            // 
            this.gridView45.GridControl = this.htTypeGridControl1;
            this.gridView45.Name = "gridView45";
            this.gridView45.PaintStyleName = "Office2003";
            // 
            // xtraTabPage11
            // 
            this.xtraTabPage11.Controls.Add(this.ttmtGridControl1);
            this.xtraTabPage11.Name = "xtraTabPage11";
            this.xtraTabPage11.Size = new System.Drawing.Size(826, 521);
            this.xtraTabPage11.Text = "Tình trạng môi trường";
            // 
            // ttmtGridControl1
            // 
            this.ttmtGridControl1.AllowDrop = true;
            this.ttmtGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ttmtGridControl1.BOSComment = "";
            this.ttmtGridControl1.BOSDataMember = null;
            this.ttmtGridControl1.BOSDataSource = "ICProductAttributes";
            this.ttmtGridControl1.BOSDescription = null;
            this.ttmtGridControl1.BOSError = "";
            this.ttmtGridControl1.BOSFieldGroup = "Accept";
            this.ttmtGridControl1.BOSFieldRelation = null;
            this.ttmtGridControl1.BOSGridType = null;
            this.ttmtGridControl1.BOSPrivilege = "";
            this.ttmtGridControl1.BOSPropertyName = null;
            this.ttmtGridControl1.CommodityType = "";
            this.ttmtGridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ttmtGridControl1.Location = new System.Drawing.Point(8, 8);
            this.ttmtGridControl1.MainView = this.gridView46;
            this.ttmtGridControl1.Name = "ttmtGridControl1";
            this.ttmtGridControl1.PrintReport = false;
            this.ttmtGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.ttmtGridControl1, true);
            this.ttmtGridControl1.Size = new System.Drawing.Size(815, 477);
            this.ttmtGridControl1.TabIndex = 5;
            this.ttmtGridControl1.Tag = "DC";
            this.ttmtGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView46});
            // 
            // gridView46
            // 
            this.gridView46.GridControl = this.ttmtGridControl1;
            this.gridView46.Name = "gridView46";
            this.gridView46.PaintStyleName = "Office2003";
            // 
            // gridView47
            // 
            this.gridView47.Name = "gridView47";
            this.gridView47.PaintStyleName = "Office2003";
            // 
            // gridView54
            // 
            this.gridView54.Name = "gridView54";
            this.gridView54.PaintStyleName = "Office2003";
            // 
            // gridView55
            // 
            this.gridView55.Name = "gridView55";
            this.gridView55.PaintStyleName = "Office2003";
            // 
            // gridView50
            // 
            this.gridView50.Name = "gridView50";
            this.gridView50.PaintStyleName = "Office2003";
            // 
            // DMPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1203, 655);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPC100.IconOptions.Icon")));
            this.Name = "DMPC100";
            this.Text = "Cấu hình thuộc tính gỗ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProductAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView37)).EndInit();
            this.fld_tabQuality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl4)).EndInit();
            this.bosGroupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConfigQualityAccordWoodType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView57)).EndInit();
            this.fld_tabFSCType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTTMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).EndInit();
            this.fld_tabHTType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHTType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView39)).EndInit();
            this.fld_tabPaintType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCoLor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView40)).EndInit();
            this.fld_tabWoodType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductAttributes)).EndInit();
            this.fld_dgcProductAttributes.ResumeLayout(false);
            this.fld_tabThink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcThickGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICConfigThinkAccordWoodType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView51)).EndInit();
            this.xtraTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView48)).EndInit();
            this.xtraTabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductGroupHeights)).EndInit();
            this.fld_tabAddMaterialType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductAttributeAddMaterialType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView49)).EndInit();
            this.xtraTabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView52)).EndInit();
            this.fld_GroupCluster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSemiGroupType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView53)).EndInit();
            this.fld_tabPerimeterGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPerimeterGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView56)).EndInit();
            this.fld_tabLengthGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICLengthGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView58)).EndInit();
            this.fld_tabWidthGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICWidthGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView60)).EndInit();
            this.xtraTabPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICMaterialConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView59)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qualityGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView42)).EndInit();
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.woodTypeGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView43)).EndInit();
            this.xtraTabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coLorGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView44)).EndInit();
            this.xtraTabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htTypeGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView45)).EndInit();
            this.xtraTabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ttmtGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProductAttributes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton bosButton2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton bosButton5;
        private BOSComponent.BOSButton bosButton6;
        private BOSComponent.BOSButton bosButton7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSButton bosButton8;
        private BOSComponent.BOSButton bosButton9;
        private BOSComponent.BOSButton bosButton10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSButton bosButton11;
        private BOSComponent.BOSButton bosButton12;
        private BOSComponent.BOSButton bosButton13;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private BOSComponent.BOSButton bosButton14;
        private BOSComponent.BOSButton bosButton15;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private BOSComponent.BOSButton bosButton16;
        private BOSComponent.BOSButton bosButton17;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView18;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView19;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView20;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView22;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView23;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView24;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView25;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView26;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView27;
        private BOSComponent.BOSButton fld_btnSavePaint;
        private BOSComponent.BOSButton fld_btnCancelPaint;
        private BOSComponent.BOSButton fld_btnAddPaint;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView28;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView29;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView30;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView31;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView32;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView33;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView34;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView35;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView36;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView37;
        private DevExpress.XtraTab.XtraTabPage fld_tabQuality;
        private DevExpress.XtraTab.XtraTabPage fld_tabFSCType;
        private DevExpress.XtraTab.XtraTabPage fld_tabHTType;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaintType;
        private DevExpress.XtraTab.XtraTabPage fld_tabWoodType;
        private BOSComponent.BOSTabControl fld_dgcProductAttributes;
        private BOSERP.Modules.ProductConstant.TTMTGridControl fld_dgcTTMT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView38;
        private BOSERP.Modules.ProductConstant.HTTypeGridControl fld_dgcHTType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView39;
        private BOSERP.Modules.ProductConstant.CoLorGridControl fld_dgcCoLor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView40;
        private BOSERP.Modules.ProductConstant.WoodTypeGridControl fld_dgcWoodType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView41;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;
        private AttributesGridControl fld_dgcICProductAttributes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView48;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private QualityGridControl qualityGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView42;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private WoodTypeGridControl woodTypeGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView43;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private CoLorGridControl coLorGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView44;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage10;
        private HTTypeGridControl htTypeGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView45;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage11;
        private TTMTGridControl ttmtGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView46;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView47;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage13;
        private ICProductGroupHeightsGridControl fld_dgcICProductGroupHeights;
        private DevExpress.XtraTab.XtraTabPage fld_tabAddMaterialType;
        private AddMaterialGridControl fld_dgcICProductAttributeAddMaterialType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView49;
        private DevExpress.XtraTab.XtraTabPage fld_tabThink;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage14;
        private DevExpress.XtraTab.XtraTabPage fld_GroupCluster;
        private DevExpress.XtraTab.XtraTabPage fld_tabPerimeterGroup;
        private DevExpress.XtraTab.XtraTabPage fld_tabLengthGroup;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage15;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView54;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView55;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView50;
        private ThickGridControl fld_dgcThickGridControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private QualityGridControl fld_dgcQuality;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSGroupControl bosGroupControl4;
        private ConfigQualityAccordWoodGridControl fld_dgcICConfigQualityAccordWoodType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView57;
        private ConfigThinkAccordWoodGridControl fld_dgcICConfigThinkAccordWoodType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView51;
        private AttributesGridControl attributesGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView52;
        private CauHinhNhomCumGridControl fld_dgcSemiGroupType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView53;
        private ICPerimeterGroupsGridControl fld_dgcICPerimeterGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView56;
        private ICLengthGroupsGridControl fld_dgcICLengthGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView58;
        private ICMaterialConfigsGridControl fld_dgcICMaterialConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView59;
        private DevExpress.XtraTab.XtraTabPage fld_tabWidthGroup;
        private ICWidthGroupsGridControl fld_dgcICWidthGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView60;
    }
}
