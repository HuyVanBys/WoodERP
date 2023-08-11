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
    partial class DMCS122
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS122));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_btnProductTypeMapping = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductTypeMappings = new BOSERP.Modules.CompanyConstant.ICProductTypeMappingGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grpGroupControl5 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCommodityType = new BOSComponent.BOSButton(this.components);
            this.fld_dgcCommodityType = new BOSERP.Modules.CompanyConstant.CommodityTypeGridControl();
            this.fld_dgvCustomerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCommodityProductTypeMapping = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICCommodityProductTypeMappings = new BOSERP.Modules.CompanyConstant.ICCommodityProductTypeMappingGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_btnCommodityGridControlTypeMapping = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICCommodityGridControlTypeMappings = new BOSERP.Modules.CompanyConstant.ICCommodityGridControlTypeMappingGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTypeMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommodityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCommodityProductTypeMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCommodityGridControlTypeMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.xtraScrollableControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(903, 913);
            this.bosPanel1.TabIndex = 7;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.fld_tabCompany);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(903, 913);
            this.xtraScrollableControl1.TabIndex = 0;
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
            this.fld_tabCompany.Size = new System.Drawing.Size(903, 913);
            this.fld_tabCompany.TabIndex = 64;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabInfomation});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.AutoScroll = true;
            this.fld_tabInfomation.Controls.Add(this.bosLine3);
            this.fld_tabInfomation.Controls.Add(this.fld_grpGroupControl5);
            this.fld_tabInfomation.Controls.Add(this.bosLine2);
            this.fld_tabInfomation.Controls.Add(this.bosLine1);
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(901, 888);
            this.fld_tabInfomation.Text = "Loại hàng hóa";
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
            this.bosLine3.Controls.Add(this.fld_btnProductTypeMapping);
            this.bosLine3.Controls.Add(this.fld_dgcICProductTypeMappings);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine3.Location = new System.Drawing.Point(9, 598);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(836, 219);
            this.bosLine3.TabIndex = 9;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Loại hàng hóa với loại sản phẩm cho bán hàng";
            // 
            // fld_btnProductTypeMapping
            // 
            this.fld_btnProductTypeMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnProductTypeMapping.BOSComment = null;
            this.fld_btnProductTypeMapping.BOSDataMember = null;
            this.fld_btnProductTypeMapping.BOSDataSource = null;
            this.fld_btnProductTypeMapping.BOSDescription = null;
            this.fld_btnProductTypeMapping.BOSError = null;
            this.fld_btnProductTypeMapping.BOSFieldGroup = null;
            this.fld_btnProductTypeMapping.BOSFieldRelation = null;
            this.fld_btnProductTypeMapping.BOSPrivilege = null;
            this.fld_btnProductTypeMapping.BOSPropertyName = null;
            this.fld_btnProductTypeMapping.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnProductTypeMapping.Location = new System.Drawing.Point(795, 20);
            this.fld_btnProductTypeMapping.Name = "fld_btnProductTypeMapping";
            this.fld_btnProductTypeMapping.Screen = null;
            this.fld_btnProductTypeMapping.Size = new System.Drawing.Size(31, 30);
            this.fld_btnProductTypeMapping.TabIndex = 7;
            this.fld_btnProductTypeMapping.Text = "bosButton1";
            this.fld_btnProductTypeMapping.Click += new System.EventHandler(this.fld_btnProductTypeMapping_Click);
            // 
            // fld_dgcICProductTypeMappings
            // 
            this.fld_dgcICProductTypeMappings.AllowDrop = true;
            this.fld_dgcICProductTypeMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductTypeMappings.BOSComment = " ";
            this.fld_dgcICProductTypeMappings.BOSDataMember = null;
            this.fld_dgcICProductTypeMappings.BOSDataSource = "ICProductTypeMappings";
            this.fld_dgcICProductTypeMappings.BOSDescription = null;
            this.fld_dgcICProductTypeMappings.BOSError = " ";
            this.fld_dgcICProductTypeMappings.BOSFieldGroup = " ";
            this.fld_dgcICProductTypeMappings.BOSFieldRelation = null;
            this.fld_dgcICProductTypeMappings.BOSGridType = null;
            this.fld_dgcICProductTypeMappings.BOSPrivilege = " ";
            this.fld_dgcICProductTypeMappings.BOSPropertyName = null;
            this.fld_dgcICProductTypeMappings.CommodityType = "";
            this.fld_dgcICProductTypeMappings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductTypeMappings.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICProductTypeMappings.MainView = this.gridView3;
            this.fld_dgcICProductTypeMappings.Name = "fld_dgcICProductTypeMappings";
            this.fld_dgcICProductTypeMappings.PrintReport = false;
            this.fld_dgcICProductTypeMappings.Screen = null;
            this.fld_dgcICProductTypeMappings.Size = new System.Drawing.Size(783, 193);
            this.fld_dgcICProductTypeMappings.TabIndex = 4;
            this.fld_dgcICProductTypeMappings.Tag = "DC";
            this.fld_dgcICProductTypeMappings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcICProductTypeMappings;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
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
            this.fld_grpGroupControl5.Controls.Add(this.fld_btnCommodityType);
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcCommodityType);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(842, 170);
            this.fld_grpGroupControl5.TabIndex = 6;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Loại hàng hóa";
            // 
            // fld_btnCommodityType
            // 
            this.fld_btnCommodityType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCommodityType.BOSComment = null;
            this.fld_btnCommodityType.BOSDataMember = null;
            this.fld_btnCommodityType.BOSDataSource = null;
            this.fld_btnCommodityType.BOSDescription = null;
            this.fld_btnCommodityType.BOSError = null;
            this.fld_btnCommodityType.BOSFieldGroup = null;
            this.fld_btnCommodityType.BOSFieldRelation = null;
            this.fld_btnCommodityType.BOSPrivilege = null;
            this.fld_btnCommodityType.BOSPropertyName = null;
            this.fld_btnCommodityType.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnCommodityType.Location = new System.Drawing.Point(801, 20);
            this.fld_btnCommodityType.Name = "fld_btnCommodityType";
            this.fld_btnCommodityType.Screen = null;
            this.fld_btnCommodityType.Size = new System.Drawing.Size(31, 30);
            this.fld_btnCommodityType.TabIndex = 7;
            this.fld_btnCommodityType.Text = "bosButton1";
            this.fld_btnCommodityType.Click += new System.EventHandler(this.fld_btnCommodityType_Click);
            // 
            // fld_dgcCommodityType
            // 
            this.fld_dgcCommodityType.AllowDrop = true;
            this.fld_dgcCommodityType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCommodityType.BOSComment = " ";
            this.fld_dgcCommodityType.BOSDataMember = null;
            this.fld_dgcCommodityType.BOSDataSource = "";
            this.fld_dgcCommodityType.BOSDescription = null;
            this.fld_dgcCommodityType.BOSError = " ";
            this.fld_dgcCommodityType.BOSFieldGroup = " ";
            this.fld_dgcCommodityType.BOSFieldRelation = null;
            this.fld_dgcCommodityType.BOSGridType = null;
            this.fld_dgcCommodityType.BOSPrivilege = " ";
            this.fld_dgcCommodityType.BOSPropertyName = null;
            this.fld_dgcCommodityType.CommodityType = "";
            this.fld_dgcCommodityType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCommodityType.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcCommodityType.MainView = this.fld_dgvCustomerType;
            this.fld_dgcCommodityType.Name = "fld_dgcCommodityType";
            this.fld_dgcCommodityType.PrintReport = false;
            this.fld_dgcCommodityType.Screen = null;
            this.fld_dgcCommodityType.Size = new System.Drawing.Size(789, 144);
            this.fld_dgcCommodityType.TabIndex = 4;
            this.fld_dgcCommodityType.Tag = "DC";
            this.fld_dgcCommodityType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvCustomerType});
            // 
            // fld_dgvCustomerType
            // 
            this.fld_dgvCustomerType.GridControl = this.fld_dgcCommodityType;
            this.fld_dgvCustomerType.Name = "fld_dgvCustomerType";
            this.fld_dgvCustomerType.PaintStyleName = "Office2003";
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
            this.bosLine2.Controls.Add(this.fld_btnCommodityProductTypeMapping);
            this.bosLine2.Controls.Add(this.fld_dgcICCommodityProductTypeMappings);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 382);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(842, 216);
            this.bosLine2.TabIndex = 8;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Loại hàng hóa với loại sản phẩm cho mua hàng";
            // 
            // fld_btnCommodityProductTypeMapping
            // 
            this.fld_btnCommodityProductTypeMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCommodityProductTypeMapping.BOSComment = null;
            this.fld_btnCommodityProductTypeMapping.BOSDataMember = null;
            this.fld_btnCommodityProductTypeMapping.BOSDataSource = null;
            this.fld_btnCommodityProductTypeMapping.BOSDescription = null;
            this.fld_btnCommodityProductTypeMapping.BOSError = null;
            this.fld_btnCommodityProductTypeMapping.BOSFieldGroup = null;
            this.fld_btnCommodityProductTypeMapping.BOSFieldRelation = null;
            this.fld_btnCommodityProductTypeMapping.BOSPrivilege = null;
            this.fld_btnCommodityProductTypeMapping.BOSPropertyName = null;
            this.fld_btnCommodityProductTypeMapping.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnCommodityProductTypeMapping.Location = new System.Drawing.Point(801, 20);
            this.fld_btnCommodityProductTypeMapping.Name = "fld_btnCommodityProductTypeMapping";
            this.fld_btnCommodityProductTypeMapping.Screen = null;
            this.fld_btnCommodityProductTypeMapping.Size = new System.Drawing.Size(31, 30);
            this.fld_btnCommodityProductTypeMapping.TabIndex = 7;
            this.fld_btnCommodityProductTypeMapping.Text = "bosButton1";
            this.fld_btnCommodityProductTypeMapping.Click += new System.EventHandler(this.fld_btnCommodityProductTypeMapping_Click);
            // 
            // fld_dgcICCommodityProductTypeMappings
            // 
            this.fld_dgcICCommodityProductTypeMappings.AllowDrop = true;
            this.fld_dgcICCommodityProductTypeMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICCommodityProductTypeMappings.BOSComment = " ";
            this.fld_dgcICCommodityProductTypeMappings.BOSDataMember = null;
            this.fld_dgcICCommodityProductTypeMappings.BOSDataSource = "ICCommodityProductTypeMappings";
            this.fld_dgcICCommodityProductTypeMappings.BOSDescription = null;
            this.fld_dgcICCommodityProductTypeMappings.BOSError = " ";
            this.fld_dgcICCommodityProductTypeMappings.BOSFieldGroup = " ";
            this.fld_dgcICCommodityProductTypeMappings.BOSFieldRelation = null;
            this.fld_dgcICCommodityProductTypeMappings.BOSGridType = null;
            this.fld_dgcICCommodityProductTypeMappings.BOSPrivilege = " ";
            this.fld_dgcICCommodityProductTypeMappings.BOSPropertyName = null;
            this.fld_dgcICCommodityProductTypeMappings.CommodityType = "";
            this.fld_dgcICCommodityProductTypeMappings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICCommodityProductTypeMappings.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICCommodityProductTypeMappings.MainView = this.gridView2;
            this.fld_dgcICCommodityProductTypeMappings.Name = "fld_dgcICCommodityProductTypeMappings";
            this.fld_dgcICCommodityProductTypeMappings.PrintReport = false;
            this.fld_dgcICCommodityProductTypeMappings.Screen = null;
            this.fld_dgcICCommodityProductTypeMappings.Size = new System.Drawing.Size(789, 190);
            this.fld_dgcICCommodityProductTypeMappings.TabIndex = 4;
            this.fld_dgcICCommodityProductTypeMappings.Tag = "DC";
            this.fld_dgcICCommodityProductTypeMappings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcICCommodityProductTypeMappings;
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
            this.bosLine1.Controls.Add(this.fld_btnCommodityGridControlTypeMapping);
            this.bosLine1.Controls.Add(this.fld_dgcICCommodityGridControlTypeMappings);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 179);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(842, 197);
            this.bosLine1.TabIndex = 7;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Loại hàng hóa với loại hh chung";
            // 
            // fld_btnCommodityGridControlTypeMapping
            // 
            this.fld_btnCommodityGridControlTypeMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCommodityGridControlTypeMapping.BOSComment = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSDataMember = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSDataSource = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSDescription = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSError = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSFieldGroup = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSFieldRelation = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSPrivilege = null;
            this.fld_btnCommodityGridControlTypeMapping.BOSPropertyName = null;
            this.fld_btnCommodityGridControlTypeMapping.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.Save_as_icon;
            this.fld_btnCommodityGridControlTypeMapping.Location = new System.Drawing.Point(801, 20);
            this.fld_btnCommodityGridControlTypeMapping.Name = "fld_btnCommodityGridControlTypeMapping";
            this.fld_btnCommodityGridControlTypeMapping.Screen = null;
            this.fld_btnCommodityGridControlTypeMapping.Size = new System.Drawing.Size(31, 30);
            this.fld_btnCommodityGridControlTypeMapping.TabIndex = 7;
            this.fld_btnCommodityGridControlTypeMapping.Text = "bosButton1";
            this.fld_btnCommodityGridControlTypeMapping.Click += new System.EventHandler(this.fld_btnCommodityGridControlTypeMapping_Click);
            // 
            // fld_dgcICCommodityGridControlTypeMappings
            // 
            this.fld_dgcICCommodityGridControlTypeMappings.AllowDrop = true;
            this.fld_dgcICCommodityGridControlTypeMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICCommodityGridControlTypeMappings.BOSComment = " ";
            this.fld_dgcICCommodityGridControlTypeMappings.BOSDataMember = null;
            this.fld_dgcICCommodityGridControlTypeMappings.BOSDataSource = "ICCommodityGridControlTypeMappings";
            this.fld_dgcICCommodityGridControlTypeMappings.BOSDescription = null;
            this.fld_dgcICCommodityGridControlTypeMappings.BOSError = " ";
            this.fld_dgcICCommodityGridControlTypeMappings.BOSFieldGroup = " ";
            this.fld_dgcICCommodityGridControlTypeMappings.BOSFieldRelation = null;
            this.fld_dgcICCommodityGridControlTypeMappings.BOSGridType = null;
            this.fld_dgcICCommodityGridControlTypeMappings.BOSPrivilege = " ";
            this.fld_dgcICCommodityGridControlTypeMappings.BOSPropertyName = null;
            this.fld_dgcICCommodityGridControlTypeMappings.CommodityType = "";
            this.fld_dgcICCommodityGridControlTypeMappings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICCommodityGridControlTypeMappings.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICCommodityGridControlTypeMappings.MainView = this.gridView1;
            this.fld_dgcICCommodityGridControlTypeMappings.Name = "fld_dgcICCommodityGridControlTypeMappings";
            this.fld_dgcICCommodityGridControlTypeMappings.PrintReport = false;
            this.fld_dgcICCommodityGridControlTypeMappings.Screen = null;
            this.fld_dgcICCommodityGridControlTypeMappings.Size = new System.Drawing.Size(789, 171);
            this.fld_dgcICCommodityGridControlTypeMappings.TabIndex = 4;
            this.fld_dgcICCommodityGridControlTypeMappings.Tag = "DC";
            this.fld_dgcICCommodityGridControlTypeMappings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICCommodityGridControlTypeMappings;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // gridView8
            // 
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // DMCS122
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(903, 913);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMCS122.IconOptions.Icon")));
            this.Name = "DMCS122";
            this.Text = "Cấu loại hàng hóa";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTypeMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCommodityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvCustomerType)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCommodityProductTypeMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCommodityGridControlTypeMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private BOSComponent.BOSButton fld_btnCommodityType;
        private CommodityTypeGridControl fld_dgcCommodityType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvCustomerType;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnCommodityProductTypeMapping;
        private ICCommodityProductTypeMappingGridControl fld_dgcICCommodityProductTypeMappings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSButton fld_btnCommodityGridControlTypeMapping;
        private ICCommodityGridControlTypeMappingGridControl fld_dgcICCommodityGridControlTypeMappings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSButton fld_btnProductTypeMapping;
        private ICProductTypeMappingGridControl fld_dgcICProductTypeMappings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}
