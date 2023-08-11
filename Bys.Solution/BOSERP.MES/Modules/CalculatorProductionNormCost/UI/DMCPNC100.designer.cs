using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CalculatorProductionNormCost.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMCPNC100
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCPNC100));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_dgcMMCalculatorProductionNormCostItems = new BOSERP.Modules.CalculatorProductionNormCost.MMCalculatorProductionNormCostItemsGridControl();
            this.fld_ChartControl = new BOSComponent.BOSChartControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosTabControl2 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_trlProductionNormItemTreeList = new BOSERP.Modules.CalculatorProductionNormCost.ProductionNormItemsTreeListControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcMMCalculatorProductionNormItemMaterials = new BOSERP.Modules.CalculatorProductionNormCost.MMCalculatorProductionNormItemMaterialsGridControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeICProductHardwareID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlHardwareList = new BOSERP.Modules.CalculatorProductionNormCost.ProductionNormItemsHardwareTreeListControl();
            this.fld_tpPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_trlPaint = new BOSERP.Modules.CalculatorProductionNormCost.ProductionNormItemsPaintTreeListControl();
            this.fld_lkeICProductIngredientPaintID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkePackaging = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPLDGAddChild = new BOSComponent.BOSButton(this.components);
            this.fld_btnPLDGAddParent = new BOSComponent.BOSButton(this.components);
            this.fld_trlIngredientPackaging = new BOSERP.Modules.CalculatorProductionNormCost.ProductionNormItemsPackagingTreeListControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_lkeICProductMaterialID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblMaterialProduct = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcGeneralMaterial = new BOSERP.Modules.CalculatorProductionNormCost.GeneralMaterialsGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCalculate = new BOSComponent.BOSButton(this.components);
            this.fle_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_txtMMCalculatorProductionNormCostExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMProcessID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMPriceType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMCalculatorProductionNormCostType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMCalculatorProductionNormCostNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerType123 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormCostItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl2)).BeginInit();
            this.bosTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductionNormItemTreeList)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormItemMaterials)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHardwareList)).BeginInit();
            this.fld_tpPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).BeginInit();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackaging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlIngredientPackaging)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGeneralMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fle_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCalculatorProductionNormCostExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProcessID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCalculatorProductionNormCostType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCalculatorProductionNormCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosGroupControl2);
            this.xtraScrollableControl1.Controls.Add(this.bosTabControl1);
            this.xtraScrollableControl1.Controls.Add(this.bosGroupControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1467, 887);
            this.xtraScrollableControl1.TabIndex = 6;
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
            this.bosGroupControl2.Controls.Add(this.bosTextBox6);
            this.bosGroupControl2.Controls.Add(this.bosLabel23);
            this.bosGroupControl2.Controls.Add(this.bosTextBox5);
            this.bosGroupControl2.Controls.Add(this.bosLabel22);
            this.bosGroupControl2.Controls.Add(this.bosTextBox4);
            this.bosGroupControl2.Controls.Add(this.bosLabel21);
            this.bosGroupControl2.Controls.Add(this.bosTextBox2);
            this.bosGroupControl2.Controls.Add(this.bosLabel20);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductPrice01);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel23);
            this.bosGroupControl2.Location = new System.Drawing.Point(834, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(453, 118);
            this.bosGroupControl2.TabIndex = 32;
            this.bosGroupControl2.Tag = "DC";
            this.bosGroupControl2.Text = "Thông tin giá";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = "";
            this.bosTextBox6.BOSDataMember = "MMCalculatorProductionNormCostSOQPrice";
            this.bosTextBox6.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = null;
            this.bosTextBox6.BOSFieldGroup = "";
            this.bosTextBox6.BOSFieldRelation = "";
            this.bosTextBox6.BOSPrivilege = "";
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.EditValue = "0.000";
            this.bosTextBox6.Location = new System.Drawing.Point(81, 85);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox6.Properties.MaskSettings.Set("mask", "n0");
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(120, 20);
            this.bosTextBox6.TabIndex = 334;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = "";
            this.bosLabel23.Location = new System.Drawing.Point(14, 88);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(23, 13);
            this.bosLabel23.TabIndex = 335;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "SOQ";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = "";
            this.bosTextBox5.BOSDataMember = "MMCalculatorProductionNormCostGrossPrice";
            this.bosTextBox5.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = null;
            this.bosTextBox5.BOSFieldGroup = "";
            this.bosTextBox5.BOSFieldRelation = "";
            this.bosTextBox5.BOSPrivilege = "";
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.EditValue = "0.000";
            this.bosTextBox5.Location = new System.Drawing.Point(276, 59);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox5.Properties.MaskSettings.Set("mask", "n0");
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(120, 20);
            this.bosTextBox5.TabIndex = 332;
            this.bosTextBox5.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseFont = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(223, 62);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(44, 13);
            this.bosLabel22.TabIndex = 333;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Giá gross";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "MMCalculatorProductionNormCostNetPrice";
            this.bosTextBox4.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.EditValue = "0.000";
            this.bosTextBox4.Location = new System.Drawing.Point(81, 59);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox4.Properties.MaskSettings.Set("mask", "n0");
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(120, 20);
            this.bosTextBox4.TabIndex = 330;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseFont = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(14, 62);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(34, 13);
            this.bosLabel21.TabIndex = 331;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Giá net";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMCalculatorProductionNormCostBasicPrice";
            this.bosTextBox2.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "0.000";
            this.bosTextBox2.Location = new System.Drawing.Point(276, 33);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox2.Properties.MaskSettings.Set("mask", "n0");
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(120, 20);
            this.bosTextBox2.TabIndex = 328;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseFont = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = "";
            this.bosLabel20.Location = new System.Drawing.Point(223, 36);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(37, 13);
            this.bosLabel20.TabIndex = 329;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Giá gốc";
            // 
            // fld_txtICProductPrice01
            // 
            this.fld_txtICProductPrice01.BOSComment = "";
            this.fld_txtICProductPrice01.BOSDataMember = "MMCalculatorProductionNormCostCostPrice";
            this.fld_txtICProductPrice01.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_txtICProductPrice01.BOSDescription = null;
            this.fld_txtICProductPrice01.BOSError = null;
            this.fld_txtICProductPrice01.BOSFieldGroup = "";
            this.fld_txtICProductPrice01.BOSFieldRelation = "";
            this.fld_txtICProductPrice01.BOSPrivilege = "";
            this.fld_txtICProductPrice01.BOSPropertyName = "Text";
            this.fld_txtICProductPrice01.EditValue = "0.000";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(81, 33);
            this.fld_txtICProductPrice01.Name = "fld_txtICProductPrice01";
            this.fld_txtICProductPrice01.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fld_txtICProductPrice01.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductPrice01.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductPrice01.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductPrice01.Properties.MaskSettings.Set("mask", "n0");
            this.fld_txtICProductPrice01.Properties.ReadOnly = true;
            this.fld_txtICProductPrice01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductPrice01.Screen = null;
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(120, 20);
            this.fld_txtICProductPrice01.TabIndex = 326;
            this.fld_txtICProductPrice01.Tag = "DC";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseFont = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = "";
            this.fld_lblLabel23.Location = new System.Drawing.Point(14, 36);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel23.TabIndex = 327;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Tổng chi phí";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 127);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1464, 760);
            this.bosTabControl1.TabIndex = 10;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1462, 735);
            this.xtraTabPage1.Text = "Thông tin chung";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcMMCalculatorProductionNormCostItems);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_ChartControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1462, 735);
            this.splitContainerControl1.SplitterPosition = 1279;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_dgcMMCalculatorProductionNormCostItems
            // 
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSComment = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSDataMember = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSDataSource = "MMCalculatorProductionNormCostItems";
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSDescription = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSError = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSFieldGroup = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSFieldRelation = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSGridType = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSPrivilege = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.BOSPropertyName = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.CommodityType = "";
            this.fld_dgcMMCalculatorProductionNormCostItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMCalculatorProductionNormCostItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMCalculatorProductionNormCostItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMCalculatorProductionNormCostItems.Name = "fld_dgcMMCalculatorProductionNormCostItems";
            this.fld_dgcMMCalculatorProductionNormCostItems.PrintReport = false;
            this.fld_dgcMMCalculatorProductionNormCostItems.Screen = null;
            this.fld_dgcMMCalculatorProductionNormCostItems.Size = new System.Drawing.Size(1279, 735);
            this.fld_dgcMMCalculatorProductionNormCostItems.TabIndex = 1;
            this.fld_dgcMMCalculatorProductionNormCostItems.Tag = "DC";
            // 
            // fld_ChartControl
            // 
            this.fld_ChartControl.BOSComment = null;
            this.fld_ChartControl.BOSDataMember = null;
            this.fld_ChartControl.BOSDataSource = "";
            this.fld_ChartControl.BOSDescription = null;
            this.fld_ChartControl.BOSError = null;
            this.fld_ChartControl.BOSFieldGroup = null;
            this.fld_ChartControl.BOSFieldRelation = null;
            this.fld_ChartControl.BOSPrivilege = null;
            this.fld_ChartControl.BOSPropertyName = null;
            this.fld_ChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_ChartControl.Legend.Name = "Default Legend";
            this.fld_ChartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.fld_ChartControl.Location = new System.Drawing.Point(0, 0);
            this.fld_ChartControl.Name = "fld_ChartControl";
            this.fld_ChartControl.Screen = null;
            pieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pieSeriesLabel1.TextPattern = "{VP:N0}";
            series1.Label = pieSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.Tag = "DC";
            pieSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.UsePoints;
            pieSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = pieSeriesView1;
            this.fld_ChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.fld_ChartControl.SeriesTemplate.Label = pieSeriesLabel2;
            this.fld_ChartControl.SeriesTemplate.View = pieSeriesView2;
            this.ScreenHelper.SetShowHelp(this.fld_ChartControl, true);
            this.fld_ChartControl.Size = new System.Drawing.Size(173, 735);
            this.fld_ChartControl.TabIndex = 1;
            this.fld_ChartControl.Visible = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosTabControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1462, 735);
            this.xtraTabPage2.Text = "Thông tin chi tiết";
            // 
            // bosTabControl2
            // 
            this.bosTabControl2.BOSComment = null;
            this.bosTabControl2.BOSDataMember = null;
            this.bosTabControl2.BOSDataSource = null;
            this.bosTabControl2.BOSDescription = null;
            this.bosTabControl2.BOSError = null;
            this.bosTabControl2.BOSFieldGroup = null;
            this.bosTabControl2.BOSFieldRelation = null;
            this.bosTabControl2.BOSPrivilege = null;
            this.bosTabControl2.BOSPropertyName = null;
            this.bosTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl2.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl2.Name = "bosTabControl2";
            this.bosTabControl2.Screen = null;
            this.bosTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.bosTabControl2.Size = new System.Drawing.Size(1462, 735);
            this.bosTabControl2.TabIndex = 0;
            this.bosTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.fld_tpPaint,
            this.xtraTabPage7,
            this.xtraTabPage6});
            this.bosTabControl2.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.bosTabControl2_SelectedPageChanged);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosPanel1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1460, 710);
            this.xtraTabPage3.Text = "ĐM Gỗ";
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
            this.bosPanel1.Controls.Add(this.fld_trlProductionNormItemTreeList);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1460, 710);
            this.bosPanel1.TabIndex = 96;
            // 
            // fld_trlProductionNormItemTreeList
            // 
            this.fld_trlProductionNormItemTreeList.BOSComment = "";
            this.fld_trlProductionNormItemTreeList.BOSDataMember = null;
            this.fld_trlProductionNormItemTreeList.BOSDataSource = "MMCalculatorProductionNormItems";
            this.fld_trlProductionNormItemTreeList.BOSDescription = null;
            this.fld_trlProductionNormItemTreeList.BOSDisplayOption = true;
            this.fld_trlProductionNormItemTreeList.BOSDisplayRoot = false;
            this.fld_trlProductionNormItemTreeList.BOSError = "";
            this.fld_trlProductionNormItemTreeList.BOSFieldGroup = "";
            this.fld_trlProductionNormItemTreeList.BOSFieldRelation = null;
            this.fld_trlProductionNormItemTreeList.BOSPrivilege = "";
            this.fld_trlProductionNormItemTreeList.BOSPropertyName = null;
            this.fld_trlProductionNormItemTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlProductionNormItemTreeList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlProductionNormItemTreeList.Location = new System.Drawing.Point(0, 0);
            this.fld_trlProductionNormItemTreeList.Name = "fld_trlProductionNormItemTreeList";
            this.fld_trlProductionNormItemTreeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlProductionNormItemTreeList.Screen = null;
            this.fld_trlProductionNormItemTreeList.Size = new System.Drawing.Size(1460, 710);
            this.fld_trlProductionNormItemTreeList.TabIndex = 95;
            this.fld_trlProductionNormItemTreeList.Tag = "DC";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.bosPanel2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1460, 710);
            this.xtraTabPage4.Text = "Nguyên liệu sử dụng";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoScroll = true;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_dgcMMCalculatorProductionNormItemMaterials);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1460, 710);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_dgcMMCalculatorProductionNormItemMaterials
            // 
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSComment = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSDataMember = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSDataSource = "MMCalculatorProductionNormItemMaterials";
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSDescription = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSError = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSFieldGroup = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSFieldRelation = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSGridType = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSPrivilege = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.BOSPropertyName = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.CommodityType = "";
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcMMCalculatorProductionNormItemMaterials.MenuManager = this.screenToolbar;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Name = "fld_dgcMMCalculatorProductionNormItemMaterials";
            this.fld_dgcMMCalculatorProductionNormItemMaterials.PrintReport = false;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Screen = null;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Size = new System.Drawing.Size(1453, 704);
            this.fld_dgcMMCalculatorProductionNormItemMaterials.TabIndex = 1;
            this.fld_dgcMMCalculatorProductionNormItemMaterials.Tag = "DC";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_lkeICProductHardwareID);
            this.xtraTabPage5.Controls.Add(this.bosLabel25);
            this.xtraTabPage5.Controls.Add(this.fld_trlHardwareList);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1460, 710);
            this.xtraTabPage5.Text = "Hardware";
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
            this.fld_lkeICProductHardwareID.Location = new System.Drawing.Point(60, 8);
            this.fld_lkeICProductHardwareID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductHardwareID.Name = "fld_lkeICProductHardwareID";
            this.fld_lkeICProductHardwareID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductHardwareID.Properties.ColumnName = null;
            this.fld_lkeICProductHardwareID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductHardwareID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductHardwareID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductHardwareID.Screen = null;
            this.fld_lkeICProductHardwareID.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeICProductHardwareID.TabIndex = 128;
            this.fld_lkeICProductHardwareID.Visible = false;
            this.fld_lkeICProductHardwareID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductHardwareID_KeyUp);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseFont = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(5, 11);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(46, 13);
            this.bosLabel25.TabIndex = 127;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Hardware";
            this.bosLabel25.Visible = false;
            // 
            // fld_trlHardwareList
            // 
            this.fld_trlHardwareList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlHardwareList.BOSComment = "";
            this.fld_trlHardwareList.BOSDataMember = null;
            this.fld_trlHardwareList.BOSDataSource = "MMCalculatorProductionNormItems";
            this.fld_trlHardwareList.BOSDescription = null;
            this.fld_trlHardwareList.BOSDisplayOption = true;
            this.fld_trlHardwareList.BOSDisplayRoot = false;
            this.fld_trlHardwareList.BOSError = "";
            this.fld_trlHardwareList.BOSFieldGroup = "";
            this.fld_trlHardwareList.BOSFieldRelation = null;
            this.fld_trlHardwareList.BOSPrivilege = "";
            this.fld_trlHardwareList.BOSPropertyName = null;
            this.fld_trlHardwareList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlHardwareList.Location = new System.Drawing.Point(0, 34);
            this.fld_trlHardwareList.Name = "fld_trlHardwareList";
            this.fld_trlHardwareList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlHardwareList.Screen = null;
            this.fld_trlHardwareList.Size = new System.Drawing.Size(1460, 676);
            this.fld_trlHardwareList.TabIndex = 104;
            this.fld_trlHardwareList.Tag = "DC";
            this.fld_trlHardwareList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlHardwareList_KeyUp);
            // 
            // fld_tpPaint
            // 
            this.fld_tpPaint.Controls.Add(this.fld_trlPaint);
            this.fld_tpPaint.Controls.Add(this.fld_lkeICProductIngredientPaintID);
            this.fld_tpPaint.Controls.Add(this.bosLabel17);
            this.fld_tpPaint.Name = "fld_tpPaint";
            this.fld_tpPaint.Size = new System.Drawing.Size(1460, 710);
            this.fld_tpPaint.Text = "Sơn";
            // 
            // fld_trlPaint
            // 
            this.fld_trlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlPaint.BOSComment = "";
            this.fld_trlPaint.BOSDataMember = null;
            this.fld_trlPaint.BOSDataSource = "MMCalculatorProductionNormItems";
            this.fld_trlPaint.BOSDescription = null;
            this.fld_trlPaint.BOSDisplayOption = true;
            this.fld_trlPaint.BOSDisplayRoot = false;
            this.fld_trlPaint.BOSError = "";
            this.fld_trlPaint.BOSFieldGroup = "";
            this.fld_trlPaint.BOSFieldRelation = null;
            this.fld_trlPaint.BOSPrivilege = "";
            this.fld_trlPaint.BOSPropertyName = null;
            this.fld_trlPaint.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlPaint.Location = new System.Drawing.Point(1, 29);
            this.fld_trlPaint.Name = "fld_trlPaint";
            this.fld_trlPaint.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlPaint.Screen = null;
            this.fld_trlPaint.Size = new System.Drawing.Size(1459, 679);
            this.fld_trlPaint.TabIndex = 129;
            this.fld_trlPaint.Tag = "DC";
            this.fld_trlPaint.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlPaint_CellValueChanged);
            this.fld_trlPaint.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlPaint_KeyUp);
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
            this.fld_lkeICProductIngredientPaintID.Location = new System.Drawing.Point(40, 3);
            this.fld_lkeICProductIngredientPaintID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductIngredientPaintID.Name = "fld_lkeICProductIngredientPaintID";
            this.fld_lkeICProductIngredientPaintID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIngredientPaintID.Properties.ColumnName = null;
            this.fld_lkeICProductIngredientPaintID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductIngredientPaintID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductIngredientPaintID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductIngredientPaintID.Screen = null;
            this.fld_lkeICProductIngredientPaintID.Size = new System.Drawing.Size(255, 20);
            this.fld_lkeICProductIngredientPaintID.TabIndex = 128;
            this.fld_lkeICProductIngredientPaintID.Visible = false;
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
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(7, 6);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(19, 13);
            this.bosLabel17.TabIndex = 127;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Sơn";
            this.bosLabel17.Visible = false;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.fld_lkePackaging);
            this.xtraTabPage7.Controls.Add(this.bosLabel13);
            this.xtraTabPage7.Controls.Add(this.fld_btnPLDGAddChild);
            this.xtraTabPage7.Controls.Add(this.fld_btnPLDGAddParent);
            this.xtraTabPage7.Controls.Add(this.fld_trlIngredientPackaging);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(1460, 710);
            this.xtraTabPage7.Text = "Phụ liệu đóng gói";
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
            this.fld_lkePackaging.Location = new System.Drawing.Point(42, 10);
            this.fld_lkePackaging.MenuManager = this.screenToolbar;
            this.fld_lkePackaging.Name = "fld_lkePackaging";
            this.fld_lkePackaging.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePackaging.Properties.ColumnName = null;
            this.fld_lkePackaging.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkePackaging.Properties.DisplayMember = "ICProductName";
            this.fld_lkePackaging.Properties.ValueMember = "ICProductID";
            this.fld_lkePackaging.Screen = null;
            this.fld_lkePackaging.Size = new System.Drawing.Size(242, 20);
            this.fld_lkePackaging.TabIndex = 133;
            this.fld_lkePackaging.Visible = false;
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(7, 13);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(29, 13);
            this.bosLabel13.TabIndex = 132;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "PLDG";
            this.bosLabel13.Visible = false;
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
            this.fld_btnPLDGAddChild.Location = new System.Drawing.Point(377, 3);
            this.fld_btnPLDGAddChild.Name = "fld_btnPLDGAddChild";
            this.fld_btnPLDGAddChild.Screen = null;
            this.fld_btnPLDGAddChild.Size = new System.Drawing.Size(91, 27);
            this.fld_btnPLDGAddChild.TabIndex = 128;
            this.fld_btnPLDGAddChild.Text = "Thêm con";
            this.fld_btnPLDGAddChild.Visible = false;
            this.fld_btnPLDGAddChild.Click += new System.EventHandler(this.fld_btnPLDGAddChild_Click);
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
            this.fld_btnPLDGAddParent.Location = new System.Drawing.Point(290, 3);
            this.fld_btnPLDGAddParent.Name = "fld_btnPLDGAddParent";
            this.fld_btnPLDGAddParent.Screen = null;
            this.fld_btnPLDGAddParent.Size = new System.Drawing.Size(81, 27);
            this.fld_btnPLDGAddParent.TabIndex = 127;
            this.fld_btnPLDGAddParent.Text = "Thêm cha";
            this.fld_btnPLDGAddParent.Visible = false;
            this.fld_btnPLDGAddParent.Click += new System.EventHandler(this.fld_btnPLDGAddParent_Click);
            // 
            // fld_trlIngredientPackaging
            // 
            this.fld_trlIngredientPackaging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlIngredientPackaging.BOSComment = "";
            this.fld_trlIngredientPackaging.BOSDataMember = null;
            this.fld_trlIngredientPackaging.BOSDataSource = "MMCalculatorProductionNormItems";
            this.fld_trlIngredientPackaging.BOSDescription = null;
            this.fld_trlIngredientPackaging.BOSDisplayOption = true;
            this.fld_trlIngredientPackaging.BOSDisplayRoot = false;
            this.fld_trlIngredientPackaging.BOSError = "";
            this.fld_trlIngredientPackaging.BOSFieldGroup = "";
            this.fld_trlIngredientPackaging.BOSFieldRelation = null;
            this.fld_trlIngredientPackaging.BOSPrivilege = "";
            this.fld_trlIngredientPackaging.BOSPropertyName = null;
            this.fld_trlIngredientPackaging.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlIngredientPackaging.Location = new System.Drawing.Point(0, 36);
            this.fld_trlIngredientPackaging.Name = "fld_trlIngredientPackaging";
            this.fld_trlIngredientPackaging.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlIngredientPackaging.Screen = null;
            this.fld_trlIngredientPackaging.Size = new System.Drawing.Size(1460, 671);
            this.fld_trlIngredientPackaging.TabIndex = 104;
            this.fld_trlIngredientPackaging.Tag = "DC";
            this.fld_trlIngredientPackaging.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.fld_trlIngredientPackaging_NodeCellStyle);
            this.fld_trlIngredientPackaging.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.fld_trlIngredientPackaging_CustomDrawNodeCell);
            this.fld_trlIngredientPackaging.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.fld_trlIngredientPackaging_CellValueChanged);
            this.fld_trlIngredientPackaging.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_trlIngredientPackaging_KeyUp);
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.fld_lkeICProductMaterialID);
            this.xtraTabPage6.Controls.Add(this.fld_lblMaterialProduct);
            this.xtraTabPage6.Controls.Add(this.fld_dgcGeneralMaterial);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(1460, 710);
            this.xtraTabPage6.Text = "Vật tư khác";
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
            this.fld_lkeICProductMaterialID.Location = new System.Drawing.Point(55, 8);
            this.fld_lkeICProductMaterialID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductMaterialID.Name = "fld_lkeICProductMaterialID";
            this.fld_lkeICProductMaterialID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductMaterialID.Properties.ColumnName = null;
            this.fld_lkeICProductMaterialID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductMaterialID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductMaterialID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductMaterialID.Screen = null;
            this.fld_lkeICProductMaterialID.Size = new System.Drawing.Size(243, 20);
            this.fld_lkeICProductMaterialID.TabIndex = 141;
            this.fld_lkeICProductMaterialID.Visible = false;
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
            this.fld_lblMaterialProduct.BOSComment = "";
            this.fld_lblMaterialProduct.BOSDataMember = "";
            this.fld_lblMaterialProduct.BOSDataSource = "";
            this.fld_lblMaterialProduct.BOSDescription = null;
            this.fld_lblMaterialProduct.BOSError = null;
            this.fld_lblMaterialProduct.BOSFieldGroup = "";
            this.fld_lblMaterialProduct.BOSFieldRelation = "";
            this.fld_lblMaterialProduct.BOSPrivilege = "";
            this.fld_lblMaterialProduct.BOSPropertyName = null;
            this.fld_lblMaterialProduct.Location = new System.Drawing.Point(3, 11);
            this.fld_lblMaterialProduct.Name = "fld_lblMaterialProduct";
            this.fld_lblMaterialProduct.Screen = null;
            this.fld_lblMaterialProduct.Size = new System.Drawing.Size(28, 13);
            this.fld_lblMaterialProduct.TabIndex = 140;
            this.fld_lblMaterialProduct.Tag = "";
            this.fld_lblMaterialProduct.Text = "Vật tư";
            this.fld_lblMaterialProduct.Visible = false;
            // 
            // fld_dgcGeneralMaterial
            // 
            this.fld_dgcGeneralMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcGeneralMaterial.BOSComment = null;
            this.fld_dgcGeneralMaterial.BOSDataMember = null;
            this.fld_dgcGeneralMaterial.BOSDataSource = "MMCalculatorProductionNormItems";
            this.fld_dgcGeneralMaterial.BOSDescription = null;
            this.fld_dgcGeneralMaterial.BOSError = null;
            this.fld_dgcGeneralMaterial.BOSFieldGroup = null;
            this.fld_dgcGeneralMaterial.BOSFieldRelation = null;
            this.fld_dgcGeneralMaterial.BOSGridType = null;
            this.fld_dgcGeneralMaterial.BOSPrivilege = null;
            this.fld_dgcGeneralMaterial.BOSPropertyName = null;
            this.fld_dgcGeneralMaterial.CommodityType = "";
            this.fld_dgcGeneralMaterial.Location = new System.Drawing.Point(1, 34);
            this.fld_dgcGeneralMaterial.MenuManager = this.screenToolbar;
            this.fld_dgcGeneralMaterial.Name = "fld_dgcGeneralMaterial";
            this.fld_dgcGeneralMaterial.PrintReport = false;
            this.fld_dgcGeneralMaterial.Screen = null;
            this.fld_dgcGeneralMaterial.Size = new System.Drawing.Size(1456, 673);
            this.fld_dgcGeneralMaterial.TabIndex = 138;
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
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_btnCalculate);
            this.bosGroupControl1.Controls.Add(this.fle_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_MMProductionNormID);
            this.bosGroupControl1.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMCalculatorProductionNormCostExchangeRate);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.bosGroupControl1.Controls.Add(this.bosTextBox3);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_MMProcessID);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_dteMMCalculatorProductionNormCostEffectiveDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_lkeMMPriceType);
            this.bosGroupControl1.Controls.Add(this.fld_lkeMMCalculatorProductionNormCostType);
            this.bosGroupControl1.Controls.Add(this.bosDateEdit1);
            this.bosGroupControl1.Controls.Add(this.fld_txtMMCalculatorProductionNormCostNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeARCustomerType123);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(828, 118);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Tag = "DC";
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(251, 62);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(56, 13);
            this.bosLabel18.TabIndex = 842;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Khách hàng";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(12, 62);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(77, 13);
            this.bosLabel19.TabIndex = 841;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Loại khách hàng";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "";
            this.bosTextBox1.BOSDataSource = "";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(329, 85);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(130, 20);
            this.bosTextBox1.TabIndex = 31;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.bosTextBox1_CustomDisplayText);
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(251, 88);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(45, 13);
            this.bosLabel14.TabIndex = 30;
            this.bosLabel14.Text = "Tên hàng";
            // 
            // fld_btnCalculate
            // 
            this.fld_btnCalculate.BOSComment = null;
            this.fld_btnCalculate.BOSDataMember = null;
            this.fld_btnCalculate.BOSDataSource = null;
            this.fld_btnCalculate.BOSDescription = null;
            this.fld_btnCalculate.BOSError = null;
            this.fld_btnCalculate.BOSFieldGroup = null;
            this.fld_btnCalculate.BOSFieldRelation = null;
            this.fld_btnCalculate.BOSPrivilege = null;
            this.fld_btnCalculate.BOSPropertyName = null;
            this.fld_btnCalculate.Location = new System.Drawing.Point(698, 81);
            this.fld_btnCalculate.Name = "fld_btnCalculate";
            this.fld_btnCalculate.Screen = null;
            this.fld_btnCalculate.Size = new System.Drawing.Size(86, 25);
            this.fld_btnCalculate.TabIndex = 29;
            this.fld_btnCalculate.Tag = "DC";
            this.fld_btnCalculate.Text = "Tính giá";
            this.fld_btnCalculate.Click += new System.EventHandler(this.fld_btnCalculate_Click);
            // 
            // fle_lkeFK_GECurrencyID
            // 
            this.fle_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fle_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fle_lkeFK_GECurrencyID.BOSComment = null;
            this.fle_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fle_lkeFK_GECurrencyID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fle_lkeFK_GECurrencyID.BOSDescription = null;
            this.fle_lkeFK_GECurrencyID.BOSError = null;
            this.fle_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fle_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fle_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fle_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fle_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fle_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fle_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fle_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fle_lkeFK_GECurrencyID.Location = new System.Drawing.Point(135, 134);
            this.fle_lkeFK_GECurrencyID.MenuManager = this.screenToolbar;
            this.fle_lkeFK_GECurrencyID.Name = "fle_lkeFK_GECurrencyID";
            this.fle_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fle_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fle_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyNo", "Mã")});
            this.fle_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyNo";
            this.fle_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fle_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fle_lkeFK_GECurrencyID.Screen = null;
            this.fle_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fle_lkeFK_GECurrencyID.TabIndex = 9;
            this.fle_lkeFK_GECurrencyID.Tag = "DC";
            this.fle_lkeFK_GECurrencyID.Visible = false;
            this.fle_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fle_lkeFK_GECurrencyID_CloseUp);
            this.fle_lkeFK_GECurrencyID.TextChanged += new System.EventHandler(this.fle_lkeFK_GECurrencyID_TextChanged);
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(99, 85);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT cũ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName2", "Tên tiếng việt"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductWidth", "Dày"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductWidth", "Rộng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductLength", "Dài")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 4;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.TextChanged += new System.EventHandler(this.fld_lkeFK_ICProductID_TextChanged);
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(135, 135);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "LSX")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = "";
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 6;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.Visible = false;
            this.fld_lkeFK_MMBatchProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit4_QueryPopUp);
            this.fld_lkeFK_MMBatchProductID.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.fld_lkeFK_MMProductionNormID_CustomDisplayText);
            // 
            // fld_lkeFK_MMProductionNormID
            // 
            this.fld_lkeFK_MMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionNormID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormID.BOSDataMember = "FK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeFK_MMProductionNormID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormID.BOSError = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormID.Location = new System.Drawing.Point(562, 85);
            this.fld_lkeFK_MMProductionNormID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMProductionNormID.Name = "fld_lkeFK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormTypeString", "Loại")});
            this.fld_lkeFK_MMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeFK_MMProductionNormID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Screen = null;
            this.fld_lkeFK_MMProductionNormID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMProductionNormID.TabIndex = 6;
            this.fld_lkeFK_MMProductionNormID.Tag = "DC";
            this.fld_lkeFK_MMProductionNormID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit4_QueryPopUp);
            this.fld_lkeFK_MMProductionNormID.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.fld_lkeFK_MMProductionNormID_CustomDisplayText);
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "ICProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "EditValue";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(135, 135);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(150, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 28;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.Visible = false;
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_txtMMCalculatorProductionNormCostExchangeRate
            // 
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSComment = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSDataMember = "MMCalculatorProductionNormCostExchangeRate";
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSDescription = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSError = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSFieldGroup = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSFieldRelation = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSPrivilege = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.BOSPropertyName = "Text";
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Location = new System.Drawing.Point(135, 135);
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.MenuManager = this.screenToolbar;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Name = "fld_txtMMCalculatorProductionNormCostExchangeRate";
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Screen = null;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.TabIndex = 10;
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Tag = "DC";
            this.fld_txtMMCalculatorProductionNormCostExchangeRate.Visible = false;
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(477, 62);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 23;
            this.bosLabel9.Text = "Tình trạng";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(66, 138);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(29, 13);
            this.bosLabel10.TabIndex = 22;
            this.bosLabel10.Text = "Tỷ giá";
            this.bosLabel10.Visible = false;
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
            this.bosLabel11.Location = new System.Drawing.Point(66, 137);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(53, 13);
            this.bosLabel11.TabIndex = 21;
            this.bosLabel11.Text = "Loại tiền tệ";
            this.bosLabel11.Visible = false;
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMCalculatorProductionNormCostStatus";
            this.bosLookupEdit3.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(562, 59);
            this.bosLookupEdit3.MenuManager = this.screenToolbar;
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.ReadOnly = true;
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(130, 20);
            this.bosLookupEdit3.TabIndex = 11;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = null;
            this.bosTextBox3.BOSDataMember = "MMCalculatorProductionNormCostCostPrice";
            this.bosTextBox3.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = null;
            this.bosTextBox3.BOSFieldRelation = null;
            this.bosTextBox3.BOSPrivilege = null;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(135, 135);
            this.bosTextBox3.MenuManager = this.screenToolbar;
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox3.TabIndex = 8;
            this.bosTextBox3.Tag = "DC";
            this.bosTextBox3.Visible = false;
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
            this.bosLabel12.Location = new System.Drawing.Point(66, 138);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(30, 13);
            this.bosLabel12.TabIndex = 20;
            this.bosLabel12.Text = "Giá áp";
            this.bosLabel12.Visible = false;
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(87, 137);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(17, 13);
            this.bosLabel16.TabIndex = 18;
            this.bosLabel16.Text = "LSX";
            this.bosLabel16.Visible = false;
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
            this.bosLabel5.Location = new System.Drawing.Point(27, 137);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(102, 13);
            this.bosLabel5.TabIndex = 19;
            this.bosLabel5.Text = "Quy trình SX áp dụng";
            this.bosLabel5.Visible = false;
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
            this.bosLabel6.Location = new System.Drawing.Point(477, 88);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(64, 13);
            this.bosLabel6.TabIndex = 18;
            this.bosLabel6.Text = "BOM áp dụng";
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
            this.bosLabel7.Location = new System.Drawing.Point(27, 138);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(54, 13);
            this.bosLabel7.TabIndex = 12;
            this.bosLabel7.Text = "Nhóm hàng";
            this.bosLabel7.Visible = false;
            // 
            // fld_lkeFK_MMProcessID
            // 
            this.fld_lkeFK_MMProcessID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProcessID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProcessID.BOSComment = null;
            this.fld_lkeFK_MMProcessID.BOSDataMember = "FK_MMProcessID";
            this.fld_lkeFK_MMProcessID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeFK_MMProcessID.BOSDescription = null;
            this.fld_lkeFK_MMProcessID.BOSError = null;
            this.fld_lkeFK_MMProcessID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProcessID.BOSFieldParent = null;
            this.fld_lkeFK_MMProcessID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProcessID.BOSPrivilege = null;
            this.fld_lkeFK_MMProcessID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProcessID.BOSSelectType = null;
            this.fld_lkeFK_MMProcessID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProcessID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProcessID.Location = new System.Drawing.Point(135, 134);
            this.fld_lkeFK_MMProcessID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMProcessID.Name = "fld_lkeFK_MMProcessID";
            this.fld_lkeFK_MMProcessID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProcessID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProcessID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProcessName", "Tên")});
            this.fld_lkeFK_MMProcessID.Properties.DisplayMember = "MMProcessName";
            this.fld_lkeFK_MMProcessID.Properties.NullText = "";
            this.fld_lkeFK_MMProcessID.Properties.ValueMember = "MMProcessID";
            this.fld_lkeFK_MMProcessID.Screen = null;
            this.fld_lkeFK_MMProcessID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMProcessID.TabIndex = 11;
            this.fld_lkeFK_MMProcessID.Tag = "DC";
            this.fld_lkeFK_MMProcessID.Visible = false;
            this.fld_lkeFK_MMProcessID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMProcessID_QueryPopUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 88);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(41, 13);
            this.bosLabel8.TabIndex = 8;
            this.bosLabel8.Text = "Mã hàng";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(21, 140);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(62, 13);
            this.bosLabel15.TabIndex = 15;
            this.bosLabel15.Text = "Tính giá theo";
            this.bosLabel15.Visible = false;
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
            this.bosLabel4.Location = new System.Drawing.Point(206, 133);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(67, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Loại giá thành";
            this.bosLabel4.Visible = false;
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
            this.bosLabel3.Location = new System.Drawing.Point(477, 36);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(59, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Text = "Ngày lấy giá";
            // 
            // fld_dteMMCalculatorProductionNormCostEffectiveDate
            // 
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSComment = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSDataMember = "MMCalculatorProductionNormCostEffectiveDate";
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSDescription = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSError = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSFieldGroup = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSFieldRelation = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSPrivilege = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.BOSPropertyName = "EditValue";
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.EditValue = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Location = new System.Drawing.Point(562, 33);
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.MenuManager = this.screenToolbar;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Name = "fld_dteMMCalculatorProductionNormCostEffectiveDate";
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Screen = null;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Size = new System.Drawing.Size(130, 20);
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.TabIndex = 2;
            this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(251, 36);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Ngày chứng từ";
            // 
            // fld_lkeMMPriceType
            // 
            this.fld_lkeMMPriceType.BOSAllowAddNew = false;
            this.fld_lkeMMPriceType.BOSAllowDummy = false;
            this.fld_lkeMMPriceType.BOSComment = null;
            this.fld_lkeMMPriceType.BOSDataMember = "MMPriceType";
            this.fld_lkeMMPriceType.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeMMPriceType.BOSDescription = null;
            this.fld_lkeMMPriceType.BOSError = null;
            this.fld_lkeMMPriceType.BOSFieldGroup = null;
            this.fld_lkeMMPriceType.BOSFieldParent = null;
            this.fld_lkeMMPriceType.BOSFieldRelation = null;
            this.fld_lkeMMPriceType.BOSPrivilege = null;
            this.fld_lkeMMPriceType.BOSPropertyName = "EditValue";
            this.fld_lkeMMPriceType.BOSSelectType = null;
            this.fld_lkeMMPriceType.BOSSelectTypeValue = null;
            this.fld_lkeMMPriceType.CurrentDisplayText = null;
            this.fld_lkeMMPriceType.Location = new System.Drawing.Point(99, 137);
            this.fld_lkeMMPriceType.Name = "fld_lkeMMPriceType";
            this.fld_lkeMMPriceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPriceType.Properties.ColumnName = null;
            this.fld_lkeMMPriceType.Properties.NullText = "";
            this.fld_lkeMMPriceType.Screen = null;
            this.fld_lkeMMPriceType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMPriceType.TabIndex = 3;
            this.fld_lkeMMPriceType.Tag = "DC";
            this.fld_lkeMMPriceType.Visible = false;
            // 
            // fld_lkeMMCalculatorProductionNormCostType
            // 
            this.fld_lkeMMCalculatorProductionNormCostType.BOSAllowAddNew = false;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSAllowDummy = false;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSComment = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSDataMember = "MMCalculatorProductionNormCostType";
            this.fld_lkeMMCalculatorProductionNormCostType.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeMMCalculatorProductionNormCostType.BOSDescription = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSError = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSFieldGroup = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSFieldParent = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSFieldRelation = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSPrivilege = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSPropertyName = "EditValue";
            this.fld_lkeMMCalculatorProductionNormCostType.BOSSelectType = null;
            this.fld_lkeMMCalculatorProductionNormCostType.BOSSelectTypeValue = null;
            this.fld_lkeMMCalculatorProductionNormCostType.CurrentDisplayText = null;
            this.fld_lkeMMCalculatorProductionNormCostType.Location = new System.Drawing.Point(284, 130);
            this.fld_lkeMMCalculatorProductionNormCostType.MenuManager = this.screenToolbar;
            this.fld_lkeMMCalculatorProductionNormCostType.Name = "fld_lkeMMCalculatorProductionNormCostType";
            this.fld_lkeMMCalculatorProductionNormCostType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMCalculatorProductionNormCostType.Properties.ColumnName = null;
            this.fld_lkeMMCalculatorProductionNormCostType.Properties.NullText = "";
            this.fld_lkeMMCalculatorProductionNormCostType.Screen = null;
            this.fld_lkeMMCalculatorProductionNormCostType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMCalculatorProductionNormCostType.TabIndex = 3;
            this.fld_lkeMMCalculatorProductionNormCostType.Tag = "DC";
            this.fld_lkeMMCalculatorProductionNormCostType.Visible = false;
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "MMCalculatorProductionNormCostDate";
            this.bosDateEdit1.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(329, 33);
            this.bosDateEdit1.MenuManager = this.screenToolbar;
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(130, 20);
            this.bosDateEdit1.TabIndex = 1;
            this.bosDateEdit1.Tag = "DC";
            // 
            // fld_txtMMCalculatorProductionNormCostNo
            // 
            this.fld_txtMMCalculatorProductionNormCostNo.BOSComment = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSDataMember = "MMCalculatorProductionNormCostNo";
            this.fld_txtMMCalculatorProductionNormCostNo.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_txtMMCalculatorProductionNormCostNo.BOSDescription = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSError = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSFieldGroup = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSFieldRelation = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSPrivilege = null;
            this.fld_txtMMCalculatorProductionNormCostNo.BOSPropertyName = "Text";
            this.fld_txtMMCalculatorProductionNormCostNo.Location = new System.Drawing.Point(99, 33);
            this.fld_txtMMCalculatorProductionNormCostNo.MenuManager = this.screenToolbar;
            this.fld_txtMMCalculatorProductionNormCostNo.Name = "fld_txtMMCalculatorProductionNormCostNo";
            this.fld_txtMMCalculatorProductionNormCostNo.Properties.ReadOnly = true;
            this.fld_txtMMCalculatorProductionNormCostNo.Screen = null;
            this.fld_txtMMCalculatorProductionNormCostNo.Size = new System.Drawing.Size(130, 20);
            this.fld_txtMMCalculatorProductionNormCostNo.TabIndex = 0;
            this.fld_txtMMCalculatorProductionNormCostNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 12;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_lkeARCustomerType123
            // 
            this.fld_lkeARCustomerType123.BOSAllowAddNew = false;
            this.fld_lkeARCustomerType123.BOSAllowDummy = false;
            this.fld_lkeARCustomerType123.BOSComment = null;
            this.fld_lkeARCustomerType123.BOSDataMember = "ARCustomerType";
            this.fld_lkeARCustomerType123.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeARCustomerType123.BOSDescription = null;
            this.fld_lkeARCustomerType123.BOSError = "";
            this.fld_lkeARCustomerType123.BOSFieldGroup = "";
            this.fld_lkeARCustomerType123.BOSFieldParent = "";
            this.fld_lkeARCustomerType123.BOSFieldRelation = "";
            this.fld_lkeARCustomerType123.BOSPrivilege = "";
            this.fld_lkeARCustomerType123.BOSPropertyName = "EditValue";
            this.fld_lkeARCustomerType123.BOSSelectType = "";
            this.fld_lkeARCustomerType123.BOSSelectTypeValue = "";
            this.fld_lkeARCustomerType123.CurrentDisplayText = "";
            this.fld_lkeARCustomerType123.Location = new System.Drawing.Point(99, 59);
            this.fld_lkeARCustomerType123.Name = "fld_lkeARCustomerType123";
            this.fld_lkeARCustomerType123.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCustomerType123.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCustomerType123.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCustomerType123.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCustomerType123.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerType123.Properties.ColumnName = null;
            this.fld_lkeARCustomerType123.Properties.NullText = "";
            this.fld_lkeARCustomerType123.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCustomerType123.Screen = null;
            this.fld_lkeARCustomerType123.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeARCustomerType123.TabIndex = 839;
            this.fld_lkeARCustomerType123.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMCalculatorProductionNormCosts";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(329, 59);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 840;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            this.fld_lkeFK_ARCustomerID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ARCustomerID_CloseUp);
            // 
            // DMCPNC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1467, 887);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCPNC100.IconOptions.Icon")));
            this.Name = "DMCPNC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormCostItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ChartControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl2)).EndInit();
            this.bosTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlProductionNormItemTreeList)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCalculatorProductionNormItemMaterials)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductHardwareID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHardwareList)).EndInit();
            this.fld_tpPaint.ResumeLayout(false);
            this.fld_tpPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIngredientPaintID.Properties)).EndInit();
            this.xtraTabPage7.ResumeLayout(false);
            this.xtraTabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePackaging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlIngredientPackaging)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            this.xtraTabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductMaterialID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGeneralMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fle_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCalculatorProductionNormCostExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProcessID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMCalculatorProductionNormCostEffectiveDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMCalculatorProductionNormCostType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMCalculatorProductionNormCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtMMCalculatorProductionNormCostExchangeRate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProcessID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteMMCalculatorProductionNormCostEffectiveDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMMCalculatorProductionNormCostType;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSTextBox fld_txtMMCalculatorProductionNormCostNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fle_lkeFK_GECurrencyID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormID;
        private BOSComponent.BOSButton fld_btnCalculate;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSTabControl bosTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSComponent.BOSPanel bosPanel1;
        private ProductionNormItemsTreeListControl fld_trlProductionNormItemTreeList;
        private BOSComponent.BOSPanel bosPanel2;
        private MMCalculatorProductionNormItemMaterialsGridControl fld_dgcMMCalculatorProductionNormItemMaterials;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private ProductionNormItemsHardwareTreeListControl fld_trlHardwareList;
        private BOSComponent.BOSLookupEdit fld_lkeICProductHardwareID;
        private BOSComponent.BOSLabel bosLabel25;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private GeneralMaterialsGridControl fld_dgcGeneralMaterial;
        private BOSComponent.BOSLookupEdit fld_lkeICProductMaterialID;
        private BOSComponent.BOSLabel fld_lblMaterialProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private ProductionNormItemsPackagingTreeListControl fld_trlIngredientPackaging;
        private BOSComponent.BOSButton fld_btnPLDGAddChild;
        private BOSComponent.BOSButton fld_btnPLDGAddParent;
        private BOSComponent.BOSLookupEdit fld_lkePackaging;
        private BOSComponent.BOSLabel bosLabel13;
        private DevExpress.XtraTab.XtraTabPage fld_tpPaint;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIngredientPaintID;
        private BOSComponent.BOSLabel bosLabel17;
        private ProductionNormItemsPaintTreeListControl fld_trlPaint;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox bosTextBox1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private MMCalculatorProductionNormCostItemsGridControl fld_dgcMMCalculatorProductionNormCostItems;
        private BOSComponent.BOSChartControl fld_ChartControl;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeMMPriceType;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerType123;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private BOSComponent.BOSLabel fld_lblLabel23;
    }
}
