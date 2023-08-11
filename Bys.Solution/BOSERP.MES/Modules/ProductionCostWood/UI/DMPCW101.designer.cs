using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCostWood.UI
{
	/// <summary>
	/// Summary description for DMPCW101
	/// </summary>
	partial class DMPCW101
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
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostIngredientCosts = new BOSERP.Modules.ProductionCostWood.MMProductionCostIngredientCostsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostOveralls622 = new BOSERP.Modules.ProductionCostWood.MMProductionCostOverallsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txt622TotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostOveralls627 = new BOSERP.Modules.ProductionCostWood.MMProductionCostOverallsGridControl();
            this.fld_dgvMMProductionCostOveralls6271 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txt627TotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls622)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txt622TotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txt627TotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.bosTabControl1.Size = new System.Drawing.Size(942, 567);
            this.bosTabControl1.TabIndex = 7;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionCostIngredientCosts);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(935, 538);
            this.xtraTabPage3.Text = "Chi phí nguyên vật liệu TT";
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
            this.fld_dgcMMProductionCostIngredientCosts.BOSDescription = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMProductionCostIngredientCosts.BOSError = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSGridType = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSPrivilege = null;
            this.fld_dgcMMProductionCostIngredientCosts.BOSPropertyName = null;
            this.fld_dgcMMProductionCostIngredientCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostIngredientCosts.Location = new System.Drawing.Point(9, 3);
            this.fld_dgcMMProductionCostIngredientCosts.MainView = this.gridView2;
            this.fld_dgcMMProductionCostIngredientCosts.Name = "fld_dgcMMProductionCostIngredientCosts";
            this.fld_dgcMMProductionCostIngredientCosts.PrintReport = false;
            this.fld_dgcMMProductionCostIngredientCosts.Screen = null;
            this.fld_dgcMMProductionCostIngredientCosts.Size = new System.Drawing.Size(918, 528);
            this.fld_dgcMMProductionCostIngredientCosts.TabIndex = 121;
            this.fld_dgcMMProductionCostIngredientCosts.Tag = "DC";
            this.fld_dgcMMProductionCostIngredientCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostIngredientCosts;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcMMProductionCostOveralls622);
            this.xtraTabPage2.Controls.Add(this.bosLabel1);
            this.xtraTabPage2.Controls.Add(this.bosTextBox1);
            this.xtraTabPage2.Controls.Add(this.bosLabel2);
            this.xtraTabPage2.Controls.Add(this.fld_txt622TotalAmount);
            this.xtraTabPage2.Controls.Add(this.bosTextBox3);
            this.xtraTabPage2.Controls.Add(this.bosLabel3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(935, 538);
            this.xtraTabPage2.Text = "Chi phí nhân công TT";
            // 
            // fld_dgcMMProductionCostOveralls622
            // 
            this.fld_dgcMMProductionCostOveralls622.AllowDrop = true;
            this.fld_dgcMMProductionCostOveralls622.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOveralls622.BOSComment = null;
            this.fld_dgcMMProductionCostOveralls622.BOSDataMember = null;
            this.fld_dgcMMProductionCostOveralls622.BOSDataSource = "MMProductionCostOveralls";
            this.fld_dgcMMProductionCostOveralls622.BOSDescription = "622";
            this.fld_dgcMMProductionCostOveralls622.BOSError = null;
            this.fld_dgcMMProductionCostOveralls622.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOveralls622.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOveralls622.BOSGridType = null;
            this.fld_dgcMMProductionCostOveralls622.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOveralls622.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOveralls622.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOveralls622.Location = new System.Drawing.Point(10, 30);
            this.fld_dgcMMProductionCostOveralls622.MainView = this.gridView1;
            this.fld_dgcMMProductionCostOveralls622.Name = "fld_dgcMMProductionCostOveralls622";
            this.fld_dgcMMProductionCostOveralls622.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls622.Screen = null;
            this.fld_dgcMMProductionCostOveralls622.Size = new System.Drawing.Size(918, 498);
            this.fld_dgcMMProductionCostOveralls622.TabIndex = 120;
            this.fld_dgcMMProductionCostOveralls622.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls622.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostOveralls622;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(16, 59);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 119;
            this.bosLabel1.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel1.Text = "Còn lại";
            this.bosLabel1.Visible = false;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "DirectLaborCostFor622BalanceAmount";
            this.bosTextBox1.BOSDataSource = "MMProductionCosts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Enabled = false;
            this.bosTextBox1.Location = new System.Drawing.Point(115, 56);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox1.TabIndex = 114;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.Visible = false;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(16, 33);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(92, 13);
            this.bosLabel2.TabIndex = 117;
            this.bosLabel2.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel2.Text = "Chi phí đã phân bổ";
            this.bosLabel2.Visible = false;
            // 
            // fld_txt622TotalAmount
            // 
            this.fld_txt622TotalAmount.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt622TotalAmount.BOSDataMember = "";
            this.fld_txt622TotalAmount.BOSDataSource = "";
            this.fld_txt622TotalAmount.BOSDescription = null;
            this.fld_txt622TotalAmount.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt622TotalAmount.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt622TotalAmount.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt622TotalAmount.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt622TotalAmount.BOSPropertyName = "Text";
            this.fld_txt622TotalAmount.Enabled = false;
            this.fld_txt622TotalAmount.Location = new System.Drawing.Point(115, 4);
            this.fld_txt622TotalAmount.Name = "fld_txt622TotalAmount";
            this.fld_txt622TotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txt622TotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txt622TotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txt622TotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txt622TotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txt622TotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txt622TotalAmount.Screen = null;
            this.fld_txt622TotalAmount.Size = new System.Drawing.Size(160, 20);
            this.fld_txt622TotalAmount.TabIndex = 116;
            this.fld_txt622TotalAmount.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSDataMember = "DirectLaborCostFor622AppropriationAmount";
            this.bosTextBox3.BOSDataSource = "MMProductionCosts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Enabled = false;
            this.bosTextBox3.Location = new System.Drawing.Point(115, 30);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox3.TabIndex = 115;
            this.bosTextBox3.Tag = "DC";
            this.bosTextBox3.Visible = false;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(16, 7);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 118;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel3.Text = "Tổng chi phí";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostOveralls627);
            this.xtraTabPage1.Controls.Add(this.bosLabel10);
            this.xtraTabPage1.Controls.Add(this.bosTextBox4);
            this.xtraTabPage1.Controls.Add(this.bosLabel11);
            this.xtraTabPage1.Controls.Add(this.fld_txt627TotalAmount);
            this.xtraTabPage1.Controls.Add(this.bosTextBox5);
            this.xtraTabPage1.Controls.Add(this.bosLabel12);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(935, 538);
            this.xtraTabPage1.Text = "Chi phí chung";
            // 
            // fld_dgcMMProductionCostOveralls627
            // 
            this.fld_dgcMMProductionCostOveralls627.AllowDrop = true;
            this.fld_dgcMMProductionCostOveralls627.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOveralls627.BOSComment = null;
            this.fld_dgcMMProductionCostOveralls627.BOSDataMember = null;
            this.fld_dgcMMProductionCostOveralls627.BOSDataSource = "MMProductionCostOveralls";
            this.fld_dgcMMProductionCostOveralls627.BOSDescription = "627";
            this.fld_dgcMMProductionCostOveralls627.BOSError = null;
            this.fld_dgcMMProductionCostOveralls627.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOveralls627.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOveralls627.BOSGridType = null;
            this.fld_dgcMMProductionCostOveralls627.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOveralls627.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOveralls627.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOveralls627.Location = new System.Drawing.Point(10, 33);
            this.fld_dgcMMProductionCostOveralls627.MainView = this.fld_dgvMMProductionCostOveralls6271;
            this.fld_dgcMMProductionCostOveralls627.Name = "fld_dgcMMProductionCostOveralls627";
            this.fld_dgcMMProductionCostOveralls627.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls627.Screen = null;
            this.fld_dgcMMProductionCostOveralls627.Size = new System.Drawing.Size(918, 498);
            this.fld_dgcMMProductionCostOveralls627.TabIndex = 114;
            this.fld_dgcMMProductionCostOveralls627.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls627.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionCostOveralls6271});
            // 
            // fld_dgvMMProductionCostOveralls6271
            // 
            this.fld_dgvMMProductionCostOveralls6271.GridControl = this.fld_dgcMMProductionCostOveralls627;
            this.fld_dgvMMProductionCostOveralls6271.Name = "fld_dgvMMProductionCostOveralls6271";
            this.fld_dgvMMProductionCostOveralls6271.PaintStyleName = "Office2003";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(13, 62);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(32, 13);
            this.bosLabel10.TabIndex = 113;
            this.bosLabel10.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel10.Text = "Còn lại";
            this.bosLabel10.Visible = false;
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox4.BOSDataMember = "OverallProductionCostFor627BalanceAmount";
            this.bosTextBox4.BOSDataSource = "MMProductionCosts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox4.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Enabled = false;
            this.bosTextBox4.Location = new System.Drawing.Point(112, 59);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox4.TabIndex = 107;
            this.bosTextBox4.Tag = "DC";
            this.bosTextBox4.Visible = false;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(13, 36);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(92, 13);
            this.bosLabel11.TabIndex = 111;
            this.bosLabel11.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel11.Text = "Chi phí đã phân bổ";
            this.bosLabel11.Visible = false;
            // 
            // fld_txt627TotalAmount
            // 
            this.fld_txt627TotalAmount.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt627TotalAmount.BOSDataMember = "";
            this.fld_txt627TotalAmount.BOSDataSource = "";
            this.fld_txt627TotalAmount.BOSDescription = null;
            this.fld_txt627TotalAmount.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt627TotalAmount.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt627TotalAmount.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt627TotalAmount.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txt627TotalAmount.BOSPropertyName = "Text";
            this.fld_txt627TotalAmount.Enabled = false;
            this.fld_txt627TotalAmount.Location = new System.Drawing.Point(112, 7);
            this.fld_txt627TotalAmount.Name = "fld_txt627TotalAmount";
            this.fld_txt627TotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txt627TotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txt627TotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txt627TotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txt627TotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txt627TotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txt627TotalAmount.Screen = null;
            this.fld_txt627TotalAmount.Size = new System.Drawing.Size(160, 20);
            this.fld_txt627TotalAmount.TabIndex = 108;
            this.fld_txt627TotalAmount.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox5.BOSDataMember = "OverallProductionCostFor627AppropriationAmount";
            this.bosTextBox5.BOSDataSource = "MMProductionCosts";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox5.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosTextBox5.BOSPropertyName = "Text";
            this.bosTextBox5.Enabled = false;
            this.bosTextBox5.Location = new System.Drawing.Point(112, 33);
            this.bosTextBox5.Name = "bosTextBox5";
            this.bosTextBox5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox5.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox5.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox5.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox5.Screen = null;
            this.bosTextBox5.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox5.TabIndex = 108;
            this.bosTextBox5.Tag = "DC";
            this.bosTextBox5.Visible = false;
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(13, 10);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 112;
            this.bosLabel12.Tag = global::Localization.CommonLocalizedResources.String1;
            this.bosLabel12.Text = "Tổng chi phí";
            // 
            // DMPCW101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(942, 567);
            this.Controls.Add(this.bosTabControl1);
            this.Name = "DMPCW101";
            this.Text = "Chi phí";
            this.Controls.SetChildIndex(this.bosTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostIngredientCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls622)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txt622TotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txt627TotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSERP.Modules.ProductionCostWood.MMProductionCostIngredientCostsGridControl fld_dgcMMProductionCostIngredientCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSERP.Modules.ProductionCostWood.MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls622;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txt622TotalAmount;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSERP.Modules.ProductionCostWood.MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls627;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionCostOveralls6271;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txt627TotalAmount;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel12;
        private IContainer components;
	}
}
