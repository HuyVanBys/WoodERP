using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC101
	/// </summary>
	partial class DMPDC101
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_btnUpdatePriceDG = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_medBatchProductNo_Phoi = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdatePricePhoi = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPricePhoi = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCosts = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePriceSC = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPriceSC = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCostsSC = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostSCsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePriceTC = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPriceTC = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCostsTC = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostTCsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePriceLR = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPriceLR = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCostsLR = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostLRsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnUpdatePriceSon = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPriceSon = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCostsSon = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostSonsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton6 = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPriceDG = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMProductionCostIngredientCostsDG = new BOSERP.Modules.ProductionCost.MMProductionCostIngredientCostDGsGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnUpdatePriceDG)).BeginInit();
            this.fld_btnUpdatePriceDG.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBatchProductNo_Phoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_btnUpdatePriceDG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 567);
            this.panel1.TabIndex = 29;
            // 
            // fld_btnUpdatePriceDG
            // 
            this.fld_btnUpdatePriceDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnUpdatePriceDG.BOSComment = null;
            this.fld_btnUpdatePriceDG.BOSDataMember = null;
            this.fld_btnUpdatePriceDG.BOSDataSource = null;
            this.fld_btnUpdatePriceDG.BOSDescription = null;
            this.fld_btnUpdatePriceDG.BOSError = null;
            this.fld_btnUpdatePriceDG.BOSFieldGroup = null;
            this.fld_btnUpdatePriceDG.BOSFieldRelation = null;
            this.fld_btnUpdatePriceDG.BOSPrivilege = null;
            this.fld_btnUpdatePriceDG.BOSPropertyName = null;
            this.fld_btnUpdatePriceDG.Location = new System.Drawing.Point(3, 3);
            this.fld_btnUpdatePriceDG.Name = "fld_btnUpdatePriceDG";
            this.fld_btnUpdatePriceDG.Screen = null;
            this.fld_btnUpdatePriceDG.SelectedTabPage = this.xtraTabPage1;
            this.fld_btnUpdatePriceDG.Size = new System.Drawing.Size(856, 561);
            this.fld_btnUpdatePriceDG.TabIndex = 30;
            this.fld_btnUpdatePriceDG.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage5,
            this.xtraTabPage4,
            this.xtraTabPage6});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_medBatchProductNo_Phoi);
            this.xtraTabPage1.Controls.Add(this.bosLabel5);
            this.xtraTabPage1.Controls.Add(this.bosButton1);
            this.xtraTabPage1.Controls.Add(this.fld_btnUpdatePricePhoi);
            this.xtraTabPage1.Controls.Add(this.fld_btnApplyPricePhoi);
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostIngredientCosts);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage1.Text = "Công đoạn Phôi";
            // 
            // fld_medBatchProductNo_Phoi
            // 
            this.fld_medBatchProductNo_Phoi.BOSComment = null;
            this.fld_medBatchProductNo_Phoi.BOSDataMember = "BatchProductNo_Phoi";
            this.fld_medBatchProductNo_Phoi.BOSDataSource = "MMProductionCosts";
            this.fld_medBatchProductNo_Phoi.BOSDescription = null;
            this.fld_medBatchProductNo_Phoi.BOSError = null;
            this.fld_medBatchProductNo_Phoi.BOSFieldGroup = null;
            this.fld_medBatchProductNo_Phoi.BOSFieldRelation = null;
            this.fld_medBatchProductNo_Phoi.BOSPrivilege = null;
            this.fld_medBatchProductNo_Phoi.BOSPropertyName = "EditValue";
            this.fld_medBatchProductNo_Phoi.Location = new System.Drawing.Point(88, 3);
            this.fld_medBatchProductNo_Phoi.MenuManager = this.screenToolbar;
            this.fld_medBatchProductNo_Phoi.Name = "fld_medBatchProductNo_Phoi";
            this.fld_medBatchProductNo_Phoi.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medBatchProductNo_Phoi, false);
            this.fld_medBatchProductNo_Phoi.Size = new System.Drawing.Size(749, 48);
            this.fld_medBatchProductNo_Phoi.TabIndex = 371;
            this.fld_medBatchProductNo_Phoi.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(14, 13);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(68, 13);
            this.bosLabel5.TabIndex = 372;
            this.bosLabel5.Text = "Lệnh sản xuất";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(215, 57);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(87, 30);
            this.bosButton1.TabIndex = 370;
            this.bosButton1.Text = "Lưu";
            this.bosButton1.Visible = false;
            // 
            // fld_btnUpdatePricePhoi
            // 
            this.fld_btnUpdatePricePhoi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePricePhoi.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePricePhoi.BOSComment = null;
            this.fld_btnUpdatePricePhoi.BOSDataMember = null;
            this.fld_btnUpdatePricePhoi.BOSDataSource = null;
            this.fld_btnUpdatePricePhoi.BOSDescription = null;
            this.fld_btnUpdatePricePhoi.BOSError = null;
            this.fld_btnUpdatePricePhoi.BOSFieldGroup = null;
            this.fld_btnUpdatePricePhoi.BOSFieldRelation = null;
            this.fld_btnUpdatePricePhoi.BOSPrivilege = null;
            this.fld_btnUpdatePricePhoi.BOSPropertyName = null;
            this.fld_btnUpdatePricePhoi.Location = new System.Drawing.Point(107, 57);
            this.fld_btnUpdatePricePhoi.Name = "fld_btnUpdatePricePhoi";
            this.fld_btnUpdatePricePhoi.Screen = null;
            this.fld_btnUpdatePricePhoi.Size = new System.Drawing.Size(102, 30);
            this.fld_btnUpdatePricePhoi.TabIndex = 370;
            this.fld_btnUpdatePricePhoi.Text = "Cập nhật hạch toán";
            this.fld_btnUpdatePricePhoi.Click += new System.EventHandler(this.fld_btnUpdatePricePhoi_Click);
            // 
            // fld_btnApplyPricePhoi
            // 
            this.fld_btnApplyPricePhoi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPricePhoi.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPricePhoi.BOSComment = null;
            this.fld_btnApplyPricePhoi.BOSDataMember = null;
            this.fld_btnApplyPricePhoi.BOSDataSource = null;
            this.fld_btnApplyPricePhoi.BOSDescription = null;
            this.fld_btnApplyPricePhoi.BOSError = null;
            this.fld_btnApplyPricePhoi.BOSFieldGroup = null;
            this.fld_btnApplyPricePhoi.BOSFieldRelation = null;
            this.fld_btnApplyPricePhoi.BOSPrivilege = null;
            this.fld_btnApplyPricePhoi.BOSPropertyName = null;
            this.fld_btnApplyPricePhoi.Location = new System.Drawing.Point(14, 57);
            this.fld_btnApplyPricePhoi.Name = "fld_btnApplyPricePhoi";
            this.fld_btnApplyPricePhoi.Screen = null;
            this.fld_btnApplyPricePhoi.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPricePhoi.TabIndex = 370;
            this.fld_btnApplyPricePhoi.Text = "Tính giá";
            this.fld_btnApplyPricePhoi.Click += new System.EventHandler(this.fld_btnApplyPrice_Click);
            // 
            // fld_dgcMMProductionCostIngredientCosts
            // 
            this.fld_dgcMMProductionCostIngredientCosts.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCosts.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSDataSource = "MMProductionCostIngredientCosts";
            this.fld_dgcMMProductionCostIngredientCosts.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCosts.Location = new System.Drawing.Point(7, 93);
            this.fld_dgcMMProductionCostIngredientCosts.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMProductionCostIngredientCosts.Name = "fld_dgcMMProductionCostIngredientCosts";
            this.fld_dgcMMProductionCostIngredientCosts.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCosts.Screen = null;
            this.fld_dgcMMProductionCostIngredientCosts.Size = new System.Drawing.Size(838, 435);
            this.fld_dgcMMProductionCostIngredientCosts.TabIndex = 30;
            this.fld_dgcMMProductionCostIngredientCosts.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMProductionCostIngredientCosts;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnUpdatePriceSC);
            this.xtraTabPage2.Controls.Add(this.fld_btnApplyPriceSC);
            this.xtraTabPage2.Controls.Add(this.fld_dgcMMProductionCostIngredientCostsSC);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage2.Text = "Công đoạn sơ chế";
            // 
            // fld_btnUpdatePriceSC
            // 
            this.fld_btnUpdatePriceSC.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePriceSC.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePriceSC.BOSComment = null;
            this.fld_btnUpdatePriceSC.BOSDataMember = null;
            this.fld_btnUpdatePriceSC.BOSDataSource = null;
            this.fld_btnUpdatePriceSC.BOSDescription = null;
            this.fld_btnUpdatePriceSC.BOSError = null;
            this.fld_btnUpdatePriceSC.BOSFieldGroup = null;
            this.fld_btnUpdatePriceSC.BOSFieldRelation = null;
            this.fld_btnUpdatePriceSC.BOSPrivilege = null;
            this.fld_btnUpdatePriceSC.BOSPropertyName = null;
            this.fld_btnUpdatePriceSC.Location = new System.Drawing.Point(98, 4);
            this.fld_btnUpdatePriceSC.Name = "fld_btnUpdatePriceSC";
            this.fld_btnUpdatePriceSC.Screen = null;
            this.fld_btnUpdatePriceSC.Size = new System.Drawing.Size(102, 30);
            this.fld_btnUpdatePriceSC.TabIndex = 373;
            this.fld_btnUpdatePriceSC.Text = "Cập nhật hạch toán";
            this.fld_btnUpdatePriceSC.Click += new System.EventHandler(this.fld_btnUpdatePriceSC_Click);
            // 
            // fld_btnApplyPriceSC
            // 
            this.fld_btnApplyPriceSC.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPriceSC.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPriceSC.BOSComment = null;
            this.fld_btnApplyPriceSC.BOSDataMember = null;
            this.fld_btnApplyPriceSC.BOSDataSource = null;
            this.fld_btnApplyPriceSC.BOSDescription = null;
            this.fld_btnApplyPriceSC.BOSError = null;
            this.fld_btnApplyPriceSC.BOSFieldGroup = null;
            this.fld_btnApplyPriceSC.BOSFieldRelation = null;
            this.fld_btnApplyPriceSC.BOSPrivilege = null;
            this.fld_btnApplyPriceSC.BOSPropertyName = null;
            this.fld_btnApplyPriceSC.Location = new System.Drawing.Point(5, 4);
            this.fld_btnApplyPriceSC.Name = "fld_btnApplyPriceSC";
            this.fld_btnApplyPriceSC.Screen = null;
            this.fld_btnApplyPriceSC.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPriceSC.TabIndex = 372;
            this.fld_btnApplyPriceSC.Text = "Tính giá";
            this.fld_btnApplyPriceSC.Click += new System.EventHandler(this.fld_btnApplyPriceSC_Click);
            // 
            // fld_dgcMMProductionCostIngredientCostsSC
            // 
            this.fld_dgcMMProductionCostIngredientCostsSC.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCostsSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSDataSource = "MMProductionCostIngredientCostSCs";
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCostsSC.Location = new System.Drawing.Point(5, 40);
            this.fld_dgcMMProductionCostIngredientCostsSC.MainView = this.gridView1;
            this.fld_dgcMMProductionCostIngredientCostsSC.Name = "fld_dgcMMProductionCostIngredientCostsSC";
            this.fld_dgcMMProductionCostIngredientCostsSC.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCostsSC.Screen = null;
            this.fld_dgcMMProductionCostIngredientCostsSC.Size = new System.Drawing.Size(838, 489);
            this.fld_dgcMMProductionCostIngredientCostsSC.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientCostsSC.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCostsSC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostIngredientCostsSC;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_btnUpdatePriceTC);
            this.xtraTabPage3.Controls.Add(this.fld_btnApplyPriceTC);
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionCostIngredientCostsTC);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage3.Text = "Công đoạn tinh chế";
            // 
            // fld_btnUpdatePriceTC
            // 
            this.fld_btnUpdatePriceTC.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePriceTC.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePriceTC.BOSComment = null;
            this.fld_btnUpdatePriceTC.BOSDataMember = null;
            this.fld_btnUpdatePriceTC.BOSDataSource = null;
            this.fld_btnUpdatePriceTC.BOSDescription = null;
            this.fld_btnUpdatePriceTC.BOSError = null;
            this.fld_btnUpdatePriceTC.BOSFieldGroup = null;
            this.fld_btnUpdatePriceTC.BOSFieldRelation = null;
            this.fld_btnUpdatePriceTC.BOSPrivilege = null;
            this.fld_btnUpdatePriceTC.BOSPropertyName = null;
            this.fld_btnUpdatePriceTC.Location = new System.Drawing.Point(98, 4);
            this.fld_btnUpdatePriceTC.Name = "fld_btnUpdatePriceTC";
            this.fld_btnUpdatePriceTC.Screen = null;
            this.fld_btnUpdatePriceTC.Size = new System.Drawing.Size(102, 30);
            this.fld_btnUpdatePriceTC.TabIndex = 374;
            this.fld_btnUpdatePriceTC.Text = "Cập nhật hạch toán";
            this.fld_btnUpdatePriceTC.Click += new System.EventHandler(this.fld_btnUpdatePriceTC_Click);
            // 
            // fld_btnApplyPriceTC
            // 
            this.fld_btnApplyPriceTC.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPriceTC.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPriceTC.BOSComment = null;
            this.fld_btnApplyPriceTC.BOSDataMember = null;
            this.fld_btnApplyPriceTC.BOSDataSource = null;
            this.fld_btnApplyPriceTC.BOSDescription = null;
            this.fld_btnApplyPriceTC.BOSError = null;
            this.fld_btnApplyPriceTC.BOSFieldGroup = null;
            this.fld_btnApplyPriceTC.BOSFieldRelation = null;
            this.fld_btnApplyPriceTC.BOSPrivilege = null;
            this.fld_btnApplyPriceTC.BOSPropertyName = null;
            this.fld_btnApplyPriceTC.Location = new System.Drawing.Point(5, 4);
            this.fld_btnApplyPriceTC.Name = "fld_btnApplyPriceTC";
            this.fld_btnApplyPriceTC.Screen = null;
            this.fld_btnApplyPriceTC.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPriceTC.TabIndex = 372;
            this.fld_btnApplyPriceTC.Text = "Tính giá";
            this.fld_btnApplyPriceTC.Click += new System.EventHandler(this.fld_btnApplyPriceTC_Click);
            // 
            // fld_dgcMMProductionCostIngredientCostsTC
            // 
            this.fld_dgcMMProductionCostIngredientCostsTC.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCostsTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSDataSource = "MMProductionCostIngredientCostTCs";
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCostsTC.Location = new System.Drawing.Point(5, 40);
            this.fld_dgcMMProductionCostIngredientCostsTC.MainView = this.gridView2;
            this.fld_dgcMMProductionCostIngredientCostsTC.Name = "fld_dgcMMProductionCostIngredientCostsTC";
            this.fld_dgcMMProductionCostIngredientCostsTC.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCostsTC.Screen = null;
            this.fld_dgcMMProductionCostIngredientCostsTC.Size = new System.Drawing.Size(838, 489);
            this.fld_dgcMMProductionCostIngredientCostsTC.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientCostsTC.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCostsTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostIngredientCostsTC;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_btnUpdatePriceLR);
            this.xtraTabPage5.Controls.Add(this.fld_btnApplyPriceLR);
            this.xtraTabPage5.Controls.Add(this.fld_dgcMMProductionCostIngredientCostsLR);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage5.Text = "Công đoạn lắp ráp";
            // 
            // fld_btnUpdatePriceLR
            // 
            this.fld_btnUpdatePriceLR.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePriceLR.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePriceLR.BOSComment = null;
            this.fld_btnUpdatePriceLR.BOSDataMember = null;
            this.fld_btnUpdatePriceLR.BOSDataSource = null;
            this.fld_btnUpdatePriceLR.BOSDescription = null;
            this.fld_btnUpdatePriceLR.BOSError = null;
            this.fld_btnUpdatePriceLR.BOSFieldGroup = null;
            this.fld_btnUpdatePriceLR.BOSFieldRelation = null;
            this.fld_btnUpdatePriceLR.BOSPrivilege = null;
            this.fld_btnUpdatePriceLR.BOSPropertyName = null;
            this.fld_btnUpdatePriceLR.Location = new System.Drawing.Point(98, 4);
            this.fld_btnUpdatePriceLR.Name = "fld_btnUpdatePriceLR";
            this.fld_btnUpdatePriceLR.Screen = null;
            this.fld_btnUpdatePriceLR.Size = new System.Drawing.Size(102, 30);
            this.fld_btnUpdatePriceLR.TabIndex = 374;
            this.fld_btnUpdatePriceLR.Text = "Cập nhật hạch toán";
            this.fld_btnUpdatePriceLR.Click += new System.EventHandler(this.fld_btnUpdatePriceLR_Click);
            // 
            // fld_btnApplyPriceLR
            // 
            this.fld_btnApplyPriceLR.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPriceLR.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPriceLR.BOSComment = null;
            this.fld_btnApplyPriceLR.BOSDataMember = null;
            this.fld_btnApplyPriceLR.BOSDataSource = null;
            this.fld_btnApplyPriceLR.BOSDescription = null;
            this.fld_btnApplyPriceLR.BOSError = null;
            this.fld_btnApplyPriceLR.BOSFieldGroup = null;
            this.fld_btnApplyPriceLR.BOSFieldRelation = null;
            this.fld_btnApplyPriceLR.BOSPrivilege = null;
            this.fld_btnApplyPriceLR.BOSPropertyName = null;
            this.fld_btnApplyPriceLR.Location = new System.Drawing.Point(5, 4);
            this.fld_btnApplyPriceLR.Name = "fld_btnApplyPriceLR";
            this.fld_btnApplyPriceLR.Screen = null;
            this.fld_btnApplyPriceLR.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPriceLR.TabIndex = 372;
            this.fld_btnApplyPriceLR.Text = "Tính giá";
            this.fld_btnApplyPriceLR.Click += new System.EventHandler(this.fld_btnApplyPriceLR_Click);
            // 
            // fld_dgcMMProductionCostIngredientCostsLR
            // 
            this.fld_dgcMMProductionCostIngredientCostsLR.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCostsLR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSDataSource = "MMProductionCostIngredientCostLRs";
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCostsLR.Location = new System.Drawing.Point(5, 40);
            this.fld_dgcMMProductionCostIngredientCostsLR.MainView = this.gridView4;
            this.fld_dgcMMProductionCostIngredientCostsLR.Name = "fld_dgcMMProductionCostIngredientCostsLR";
            this.fld_dgcMMProductionCostIngredientCostsLR.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCostsLR.Screen = null;
            this.fld_dgcMMProductionCostIngredientCostsLR.Size = new System.Drawing.Size(838, 489);
            this.fld_dgcMMProductionCostIngredientCostsLR.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientCostsLR.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCostsLR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProductionCostIngredientCostsLR;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_btnUpdatePriceSon);
            this.xtraTabPage4.Controls.Add(this.fld_btnApplyPriceSon);
            this.xtraTabPage4.Controls.Add(this.fld_dgcMMProductionCostIngredientCostsSon);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage4.Text = "Công đoạn sơn";
            // 
            // fld_btnUpdatePriceSon
            // 
            this.fld_btnUpdatePriceSon.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePriceSon.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePriceSon.BOSComment = null;
            this.fld_btnUpdatePriceSon.BOSDataMember = null;
            this.fld_btnUpdatePriceSon.BOSDataSource = null;
            this.fld_btnUpdatePriceSon.BOSDescription = null;
            this.fld_btnUpdatePriceSon.BOSError = null;
            this.fld_btnUpdatePriceSon.BOSFieldGroup = null;
            this.fld_btnUpdatePriceSon.BOSFieldRelation = null;
            this.fld_btnUpdatePriceSon.BOSPrivilege = null;
            this.fld_btnUpdatePriceSon.BOSPropertyName = null;
            this.fld_btnUpdatePriceSon.Location = new System.Drawing.Point(98, 4);
            this.fld_btnUpdatePriceSon.Name = "fld_btnUpdatePriceSon";
            this.fld_btnUpdatePriceSon.Screen = null;
            this.fld_btnUpdatePriceSon.Size = new System.Drawing.Size(102, 30);
            this.fld_btnUpdatePriceSon.TabIndex = 374;
            this.fld_btnUpdatePriceSon.Text = "Cập nhật hạch toán";
            this.fld_btnUpdatePriceSon.Click += new System.EventHandler(this.fld_btnUpdatePriceSon_Click);
            // 
            // fld_btnApplyPriceSon
            // 
            this.fld_btnApplyPriceSon.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPriceSon.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPriceSon.BOSComment = null;
            this.fld_btnApplyPriceSon.BOSDataMember = null;
            this.fld_btnApplyPriceSon.BOSDataSource = null;
            this.fld_btnApplyPriceSon.BOSDescription = null;
            this.fld_btnApplyPriceSon.BOSError = null;
            this.fld_btnApplyPriceSon.BOSFieldGroup = null;
            this.fld_btnApplyPriceSon.BOSFieldRelation = null;
            this.fld_btnApplyPriceSon.BOSPrivilege = null;
            this.fld_btnApplyPriceSon.BOSPropertyName = null;
            this.fld_btnApplyPriceSon.Location = new System.Drawing.Point(5, 4);
            this.fld_btnApplyPriceSon.Name = "fld_btnApplyPriceSon";
            this.fld_btnApplyPriceSon.Screen = null;
            this.fld_btnApplyPriceSon.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPriceSon.TabIndex = 372;
            this.fld_btnApplyPriceSon.Text = "Tính giá";
            this.fld_btnApplyPriceSon.Click += new System.EventHandler(this.fld_btnApplyPriceSon_Click);
            // 
            // fld_dgcMMProductionCostIngredientCostsSon
            // 
            this.fld_dgcMMProductionCostIngredientCostsSon.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCostsSon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSDataSource = "MMProductionCostIngredientCostSons";
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCostsSon.Location = new System.Drawing.Point(5, 40);
            this.fld_dgcMMProductionCostIngredientCostsSon.MainView = this.gridView3;
            this.fld_dgcMMProductionCostIngredientCostsSon.Name = "fld_dgcMMProductionCostIngredientCostsSon";
            this.fld_dgcMMProductionCostIngredientCostsSon.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCostsSon.Screen = null;
            this.fld_dgcMMProductionCostIngredientCostsSon.Size = new System.Drawing.Size(838, 489);
            this.fld_dgcMMProductionCostIngredientCostsSon.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientCostsSon.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCostsSon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMProductionCostIngredientCostsSon;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.bosButton6);
            this.xtraTabPage6.Controls.Add(this.fld_btnApplyPriceDG);
            this.xtraTabPage6.Controls.Add(this.fld_dgcMMProductionCostIngredientCostsDG);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(849, 532);
            this.xtraTabPage6.Text = "Công đoạn đóng gói";
            // 
            // bosButton6
            // 
            this.bosButton6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton6.Appearance.Options.UseForeColor = true;
            this.bosButton6.BOSComment = null;
            this.bosButton6.BOSDataMember = null;
            this.bosButton6.BOSDataSource = null;
            this.bosButton6.BOSDescription = null;
            this.bosButton6.BOSError = null;
            this.bosButton6.BOSFieldGroup = null;
            this.bosButton6.BOSFieldRelation = null;
            this.bosButton6.BOSPrivilege = null;
            this.bosButton6.BOSPropertyName = null;
            this.bosButton6.Location = new System.Drawing.Point(98, 4);
            this.bosButton6.Name = "bosButton6";
            this.bosButton6.Screen = null;
            this.bosButton6.Size = new System.Drawing.Size(102, 30);
            this.bosButton6.TabIndex = 374;
            this.bosButton6.Text = "Cập nhật hạch toán";
            this.bosButton6.Click += new System.EventHandler(this.bosButton6_Click);
            // 
            // fld_btnApplyPriceDG
            // 
            this.fld_btnApplyPriceDG.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPriceDG.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPriceDG.BOSComment = null;
            this.fld_btnApplyPriceDG.BOSDataMember = null;
            this.fld_btnApplyPriceDG.BOSDataSource = null;
            this.fld_btnApplyPriceDG.BOSDescription = null;
            this.fld_btnApplyPriceDG.BOSError = null;
            this.fld_btnApplyPriceDG.BOSFieldGroup = null;
            this.fld_btnApplyPriceDG.BOSFieldRelation = null;
            this.fld_btnApplyPriceDG.BOSPrivilege = null;
            this.fld_btnApplyPriceDG.BOSPropertyName = null;
            this.fld_btnApplyPriceDG.Location = new System.Drawing.Point(5, 4);
            this.fld_btnApplyPriceDG.Name = "fld_btnApplyPriceDG";
            this.fld_btnApplyPriceDG.Screen = null;
            this.fld_btnApplyPriceDG.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPriceDG.TabIndex = 372;
            this.fld_btnApplyPriceDG.Text = "Tính giá";
            this.fld_btnApplyPriceDG.Click += new System.EventHandler(this.fld_btnApplyPriceDG_Click);
            // 
            // fld_dgcMMProductionCostIngredientCostsDG
            // 
            this.fld_dgcMMProductionCostIngredientCostsDG.AllowDrop = true;
            this.fld_dgcMMProductionCostIngredientCostsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSComment = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSDataMember = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSDataSource = "MMProductionCostIngredientCostDGs";
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSDescription = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCostsDG.Location = new System.Drawing.Point(5, 40);
            this.fld_dgcMMProductionCostIngredientCostsDG.MainView = this.gridView5;
            this.fld_dgcMMProductionCostIngredientCostsDG.Name = "fld_dgcMMProductionCostIngredientCostsDG";
            this.fld_dgcMMProductionCostIngredientCostsDG.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCostsDG.Screen = null;
            this.fld_dgcMMProductionCostIngredientCostsDG.Size = new System.Drawing.Size(838, 489);
            this.fld_dgcMMProductionCostIngredientCostsDG.TabIndex = 371;
            this.fld_dgcMMProductionCostIngredientCostsDG.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCostsDG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcMMProductionCostIngredientCostsDG;
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // DMPDC101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.panel1);
            this.Name = "DMPDC101";
            this.Text = "Chi phí NVL trực tiếp";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnUpdatePriceDG)).EndInit();
            this.fld_btnUpdatePriceDG.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medBatchProductNo_Phoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCostsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private Panel panel1;
        private BOSComponent.BOSTabControl fld_btnUpdatePriceDG;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private MMProductionCostIngredientCostsGridControl fld_dgcMMProductionCostIngredientCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private IContainer components;
        private BOSComponent.BOSButton fld_btnApplyPricePhoi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private BOSComponent.BOSButton fld_btnApplyPriceSC;
        private MMProductionCostIngredientCostSCsGridControl fld_dgcMMProductionCostIngredientCostsSC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnApplyPriceTC;
        private MMProductionCostIngredientCostTCsGridControl fld_dgcMMProductionCostIngredientCostsTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnApplyPriceSon;
        private MMProductionCostIngredientCostSonsGridControl fld_dgcMMProductionCostIngredientCostsSon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSButton fld_btnApplyPriceLR;
        private MMProductionCostIngredientCostLRsGridControl fld_dgcMMProductionCostIngredientCostsLR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSButton fld_btnApplyPriceDG;
        private MMProductionCostIngredientCostDGsGridControl fld_dgcMMProductionCostIngredientCostsDG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton fld_btnUpdatePricePhoi;
        private BOSComponent.BOSButton fld_btnUpdatePriceSC;
        private BOSComponent.BOSButton fld_btnUpdatePriceTC;
        private BOSComponent.BOSButton fld_btnUpdatePriceLR;
        private BOSComponent.BOSButton fld_btnUpdatePriceSon;
        private BOSComponent.BOSButton bosButton6;
        private BOSComponent.BOSMemoEdit fld_medBatchProductNo_Phoi;
        private BOSComponent.BOSLabel bosLabel5;

    }
}
