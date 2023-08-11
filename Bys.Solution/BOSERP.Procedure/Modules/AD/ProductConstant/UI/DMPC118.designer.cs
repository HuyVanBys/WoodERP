using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
    /// <summary>
    /// Summary description for DMPC118
    /// </summary>
    partial class DMPC118
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPC118));
            this.fld_dgvMMReuseSpecificateConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSaveMMDefaultAllocationOperationConfigs = new BOSComponent.BOSButton(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcMMDefaultAllocationOperationConfigs = new BOSERP.Modules.ProductConstant.MMDefaultAllocationOperationConfigsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys = new BOSComponent.BOSButton(this.components);
            this.fld_btnSaveConfigProductionComplexity = new BOSComponent.BOSButton(this.components);
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcMMConfigMaterialShipmentUtilitys = new BOSERP.Modules.ProductConstant.MMConfigMaterialShipmentUtilitysGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcConfigProductionComplexityType = new BOSERP.Modules.ProductConstant.ConfigProductionComplexityTypeGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcMMAllocationOperationConfigs = new BOSERP.Modules.ProductConstant.MMAllocationOperationConfigsGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSaveMMProductionCompletionTimeConfigs = new BOSComponent.BOSButton(this.components);
            this.fld_btnSaveBomChangeRate = new DevExpress.XtraEditors.SimpleButton();
            this.fld_textBOMChangeRate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDefaultAllocationOperationConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMConfigMaterialShipmentUtilitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcConfigProductionComplexityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationOperationConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_textBOMChangeRate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_btnSaveMMDefaultAllocationOperationConfigs);
            this.bosPanel1.Controls.Add(this.groupControl4);
            this.bosPanel1.Controls.Add(this.fld_btnSaveMMConfigMaterialShipmentUtilitys);
            this.bosPanel1.Controls.Add(this.fld_btnSaveConfigProductionComplexity);
            this.bosPanel1.Controls.Add(this.groupControl3);
            this.bosPanel1.Controls.Add(this.groupControl2);
            this.bosPanel1.Controls.Add(this.groupControl1);
            this.bosPanel1.Controls.Add(this.fld_btnSaveMMProductionCompletionTimeConfigs);
            this.bosPanel1.Controls.Add(this.fld_btnSaveBomChangeRate);
            this.bosPanel1.Controls.Add(this.fld_textBOMChangeRate);
            this.bosPanel1.Controls.Add(this.labelControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1167, 629);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_btnSaveMMDefaultAllocationOperationConfigs
            // 
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSComment = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSDataMember = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSDataSource = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSDescription = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSError = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSFieldGroup = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSFieldRelation = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSPrivilege = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.BOSPropertyName = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Location = new System.Drawing.Point(1109, 52);
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Name = "fld_btnSaveMMDefaultAllocationOperationConfigs";
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Screen = null;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.TabIndex = 15;
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Text = "bosButton1";
            this.fld_btnSaveMMDefaultAllocationOperationConfigs.Click += new System.EventHandler(this.fld_btnSaveMMDefaultAllocationOperationConfigs_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.fld_dgcMMDefaultAllocationOperationConfigs);
            this.groupControl4.Location = new System.Drawing.Point(586, 50);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(517, 215);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "Cấu hình hiển thị công đoạn cấp phát NPL";
            // 
            // fld_dgcMMDefaultAllocationOperationConfigs
            // 
            this.fld_dgcMMDefaultAllocationOperationConfigs.AllowDrop = true;
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSComment = "";
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSDataMember = null;
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSDataSource = "MMDefaultAllocationOperationConfigs";
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSDescription = null;
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSError = "";
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSFieldGroup = "";
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSFieldRelation = null;
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSGridType = null;
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSPrivilege = "";
            this.fld_dgcMMDefaultAllocationOperationConfigs.BOSPropertyName = null;
            this.fld_dgcMMDefaultAllocationOperationConfigs.CommodityType = "";
            this.fld_dgcMMDefaultAllocationOperationConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMDefaultAllocationOperationConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMDefaultAllocationOperationConfigs.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMDefaultAllocationOperationConfigs.MainView = this.gridView3;
            this.fld_dgcMMDefaultAllocationOperationConfigs.Name = "fld_dgcMMDefaultAllocationOperationConfigs";
            this.fld_dgcMMDefaultAllocationOperationConfigs.PrintReport = false;
            this.fld_dgcMMDefaultAllocationOperationConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMDefaultAllocationOperationConfigs, true);
            this.fld_dgcMMDefaultAllocationOperationConfigs.Size = new System.Drawing.Size(513, 190);
            this.fld_dgcMMDefaultAllocationOperationConfigs.TabIndex = 0;
            this.fld_dgcMMDefaultAllocationOperationConfigs.Tag = "DC";
            this.fld_dgcMMDefaultAllocationOperationConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMMDefaultAllocationOperationConfigs;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveMMConfigMaterialShipmentUtilitys
            // 
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSComment = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSDataMember = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSDataSource = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSDescription = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSError = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSFieldGroup = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSFieldRelation = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSPrivilege = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.BOSPropertyName = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Location = new System.Drawing.Point(535, 420);
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Name = "fld_btnSaveMMConfigMaterialShipmentUtilitys";
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Screen = null;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.TabIndex = 13;
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Text = "bosButton1";
            this.fld_btnSaveMMConfigMaterialShipmentUtilitys.Click += new System.EventHandler(this.fld_btnSaveMMConfigMaterialShipmentUtilitys_Click);
            // 
            // fld_btnSaveConfigProductionComplexity
            // 
            this.fld_btnSaveConfigProductionComplexity.BOSComment = null;
            this.fld_btnSaveConfigProductionComplexity.BOSDataMember = null;
            this.fld_btnSaveConfigProductionComplexity.BOSDataSource = null;
            this.fld_btnSaveConfigProductionComplexity.BOSDescription = null;
            this.fld_btnSaveConfigProductionComplexity.BOSError = null;
            this.fld_btnSaveConfigProductionComplexity.BOSFieldGroup = null;
            this.fld_btnSaveConfigProductionComplexity.BOSFieldRelation = null;
            this.fld_btnSaveConfigProductionComplexity.BOSPrivilege = null;
            this.fld_btnSaveConfigProductionComplexity.BOSPropertyName = null;
            this.fld_btnSaveConfigProductionComplexity.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveConfigProductionComplexity.Location = new System.Drawing.Point(535, 202);
            this.fld_btnSaveConfigProductionComplexity.Name = "fld_btnSaveConfigProductionComplexity";
            this.fld_btnSaveConfigProductionComplexity.Screen = null;
            this.fld_btnSaveConfigProductionComplexity.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveConfigProductionComplexity.TabIndex = 11;
            this.fld_btnSaveConfigProductionComplexity.Text = "bosButton1";
            this.fld_btnSaveConfigProductionComplexity.Click += new System.EventHandler(this.fld_btnSaveConfigProductionComplexity_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.fld_dgcMMConfigMaterialShipmentUtilitys);
            this.groupControl3.Location = new System.Drawing.Point(12, 420);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(517, 154);
            this.groupControl3.TabIndex = 12;
            this.groupControl3.Text = "Cấu hình Tiện ích xuất kho nguyên liệu";
            // 
            // fld_dgcMMConfigMaterialShipmentUtilitys
            // 
            this.fld_dgcMMConfigMaterialShipmentUtilitys.AllowDrop = true;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSComment = "";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSDataMember = null;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSDataSource = "MMConfigMaterialShipmentUtilitys";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSDescription = null;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSError = "";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSFieldGroup = "";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSFieldRelation = null;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSGridType = null;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSPrivilege = "";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.BOSPropertyName = null;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.CommodityType = "";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMConfigMaterialShipmentUtilitys.MainView = this.gridView2;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Name = "fld_dgcMMConfigMaterialShipmentUtilitys";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.PrintReport = false;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMConfigMaterialShipmentUtilitys, true);
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Size = new System.Drawing.Size(513, 129);
            this.fld_dgcMMConfigMaterialShipmentUtilitys.TabIndex = 0;
            this.fld_dgcMMConfigMaterialShipmentUtilitys.Tag = "DC";
            this.fld_dgcMMConfigMaterialShipmentUtilitys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMConfigMaterialShipmentUtilitys;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.fld_dgcConfigProductionComplexityType);
            this.groupControl2.Location = new System.Drawing.Point(12, 202);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(517, 212);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Cấu hình độ phức tạp sản xuất";
            // 
            // fld_dgcConfigProductionComplexityType
            // 
            this.fld_dgcConfigProductionComplexityType.AllowDrop = true;
            this.fld_dgcConfigProductionComplexityType.BOSComment = "";
            this.fld_dgcConfigProductionComplexityType.BOSDataMember = null;
            this.fld_dgcConfigProductionComplexityType.BOSDataSource = "";
            this.fld_dgcConfigProductionComplexityType.BOSDescription = null;
            this.fld_dgcConfigProductionComplexityType.BOSError = "";
            this.fld_dgcConfigProductionComplexityType.BOSFieldGroup = "";
            this.fld_dgcConfigProductionComplexityType.BOSFieldRelation = null;
            this.fld_dgcConfigProductionComplexityType.BOSGridType = null;
            this.fld_dgcConfigProductionComplexityType.BOSPrivilege = "";
            this.fld_dgcConfigProductionComplexityType.BOSPropertyName = null;
            this.fld_dgcConfigProductionComplexityType.CommodityType = "";
            this.fld_dgcConfigProductionComplexityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcConfigProductionComplexityType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcConfigProductionComplexityType.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcConfigProductionComplexityType.MainView = this.gridView1;
            this.fld_dgcConfigProductionComplexityType.Name = "fld_dgcConfigProductionComplexityType";
            this.fld_dgcConfigProductionComplexityType.PrintReport = false;
            this.fld_dgcConfigProductionComplexityType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcConfigProductionComplexityType, true);
            this.fld_dgcConfigProductionComplexityType.Size = new System.Drawing.Size(513, 187);
            this.fld_dgcConfigProductionComplexityType.TabIndex = 0;
            this.fld_dgcConfigProductionComplexityType.Tag = "DC";
            this.fld_dgcConfigProductionComplexityType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcConfigProductionComplexityType;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_dgcMMAllocationOperationConfigs);
            this.groupControl1.Location = new System.Drawing.Point(12, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(517, 144);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Cấu hình công đoạn cấp phát NPL";
            // 
            // fld_dgcMMAllocationOperationConfigs
            // 
            this.fld_dgcMMAllocationOperationConfigs.AllowDrop = true;
            this.fld_dgcMMAllocationOperationConfigs.BOSComment = "";
            this.fld_dgcMMAllocationOperationConfigs.BOSDataMember = null;
            this.fld_dgcMMAllocationOperationConfigs.BOSDataSource = "MMAllocationOperationConfigs";
            this.fld_dgcMMAllocationOperationConfigs.BOSDescription = null;
            this.fld_dgcMMAllocationOperationConfigs.BOSError = "";
            this.fld_dgcMMAllocationOperationConfigs.BOSFieldGroup = "";
            this.fld_dgcMMAllocationOperationConfigs.BOSFieldRelation = null;
            this.fld_dgcMMAllocationOperationConfigs.BOSGridType = null;
            this.fld_dgcMMAllocationOperationConfigs.BOSPrivilege = "";
            this.fld_dgcMMAllocationOperationConfigs.BOSPropertyName = null;
            this.fld_dgcMMAllocationOperationConfigs.CommodityType = "";
            this.fld_dgcMMAllocationOperationConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMAllocationOperationConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMAllocationOperationConfigs.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMAllocationOperationConfigs.MainView = this.fld_dgvProductType;
            this.fld_dgcMMAllocationOperationConfigs.Name = "fld_dgcMMAllocationOperationConfigs";
            this.fld_dgcMMAllocationOperationConfigs.PrintReport = false;
            this.fld_dgcMMAllocationOperationConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMAllocationOperationConfigs, true);
            this.fld_dgcMMAllocationOperationConfigs.Size = new System.Drawing.Size(513, 119);
            this.fld_dgcMMAllocationOperationConfigs.TabIndex = 0;
            this.fld_dgcMMAllocationOperationConfigs.Tag = "DC";
            this.fld_dgcMMAllocationOperationConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMAllocationOperationConfigs;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // fld_btnSaveMMProductionCompletionTimeConfigs
            // 
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSComment = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDataMember = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDataSource = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSDescription = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSError = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSFieldGroup = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSFieldRelation = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSPrivilege = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.BOSPropertyName = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Location = new System.Drawing.Point(533, 50);
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Name = "fld_btnSaveMMProductionCompletionTimeConfigs";
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Screen = null;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Size = new System.Drawing.Size(31, 30);
            this.fld_btnSaveMMProductionCompletionTimeConfigs.TabIndex = 7;
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Text = "bosButton1";
            this.fld_btnSaveMMProductionCompletionTimeConfigs.Click += new System.EventHandler(this.fld_btnSaveMMProductionCompletionTimeConfigs_Click);
            // 
            // fld_btnSaveBomChangeRate
            // 
            this.fld_btnSaveBomChangeRate.Location = new System.Drawing.Point(240, 16);
            this.fld_btnSaveBomChangeRate.Name = "fld_btnSaveBomChangeRate";
            this.fld_btnSaveBomChangeRate.Size = new System.Drawing.Size(53, 20);
            this.fld_btnSaveBomChangeRate.TabIndex = 6;
            this.fld_btnSaveBomChangeRate.Text = "Lưu";
            this.fld_btnSaveBomChangeRate.Click += new System.EventHandler(this.fld_btnSaveBomChangeRate_Click);
            // 
            // fld_textBOMChangeRate
            // 
            this.fld_textBOMChangeRate.EditValue = 0;
            this.fld_textBOMChangeRate.Location = new System.Drawing.Point(134, 16);
            this.fld_textBOMChangeRate.MenuManager = this.screenToolbar;
            this.fld_textBOMChangeRate.Name = "fld_textBOMChangeRate";
            this.fld_textBOMChangeRate.Properties.Appearance.Options.UseTextOptions = true;
            this.fld_textBOMChangeRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.fld_textBOMChangeRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_textBOMChangeRate.Size = new System.Drawing.Size(100, 20);
            this.fld_textBOMChangeRate.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tỷ lệ thay đổi định mức";
            // 
            // DMPC118
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1167, 629);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPC118.IconOptions.Icon")));
            this.Name = "DMPC118";
            this.Text = "Cấu hình công đoạn cấp phát NPL";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMDefaultAllocationOperationConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMConfigMaterialShipmentUtilitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcConfigProductionComplexityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationOperationConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_textBOMChangeRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMReuseSpecificateConfigs;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private MMAllocationOperationConfigsGridControl fld_dgcMMAllocationOperationConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private BOSComponent.BOSButton fld_btnSaveMMProductionCompletionTimeConfigs;
        private DevExpress.XtraEditors.SimpleButton fld_btnSaveBomChangeRate;
        private DevExpress.XtraEditors.TextEdit fld_textBOMChangeRate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private BOSComponent.BOSButton fld_btnSaveConfigProductionComplexity;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ConfigProductionComplexityTypeGridControl fld_dgcConfigProductionComplexityType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnSaveMMConfigMaterialShipmentUtilitys;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private MMConfigMaterialShipmentUtilitysGridControl fld_dgcMMConfigMaterialShipmentUtilitys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnSaveMMDefaultAllocationOperationConfigs;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private MMDefaultAllocationOperationConfigsGridControl fld_dgcMMDefaultAllocationOperationConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}
