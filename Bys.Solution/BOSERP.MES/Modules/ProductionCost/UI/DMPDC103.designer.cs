using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC103
	/// </summary>
	partial class DMPDC103
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
            this.fld_dgcMMProductionCostOveralls627 = new BOSERP.Modules.ProductionCost.MMProductionCostOverallsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox7 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox8 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox9 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostOveralls6279 = new BOSERP.Modules.ProductionCost.MMProductionCostOverallsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionCostOveralls627A = new BOSERP.Modules.ProductionCost.MMProductionCostOverallsGridControl();
            this.fld_dgvMMProductionCostOveralls6271 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox6 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox5 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls6279)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).BeginInit();
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
            this.bosTabControl1.Size = new System.Drawing.Size(941, 558);
            this.bosTabControl1.TabIndex = 6;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionCostOveralls627);
            this.xtraTabPage3.Controls.Add(this.bosLabel4);
            this.xtraTabPage3.Controls.Add(this.bosTextBox7);
            this.xtraTabPage3.Controls.Add(this.bosLabel5);
            this.xtraTabPage3.Controls.Add(this.bosTextBox8);
            this.xtraTabPage3.Controls.Add(this.bosTextBox9);
            this.xtraTabPage3.Controls.Add(this.bosLabel6);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(934, 529);
            this.xtraTabPage3.Text = "Chi phí chung";
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
            this.fld_dgcMMProductionCostOveralls627.Location = new System.Drawing.Point(9, 85);
            this.fld_dgcMMProductionCostOveralls627.MainView = this.gridView2;
            this.fld_dgcMMProductionCostOveralls627.Name = "fld_dgcMMProductionCostOveralls627";
            this.fld_dgcMMProductionCostOveralls627.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls627.Screen = null;
            this.fld_dgcMMProductionCostOveralls627.Size = new System.Drawing.Size(917, 437);
            this.fld_dgcMMProductionCostOveralls627.TabIndex = 121;
            this.fld_dgcMMProductionCostOveralls627.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls627.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionCostOveralls627;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 62);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(32, 13);
            this.bosLabel4.TabIndex = 120;
            this.bosLabel4.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Text = "Còn lại";
            // 
            // bosTextBox7
            // 
            this.bosTextBox7.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox7.BOSDataMember = "OverallProductionCostFor627BalanceAmount";
            this.bosTextBox7.BOSDataSource = "MMProductionCosts";
            this.bosTextBox7.BOSDescription = null;
            this.bosTextBox7.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox7.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox7.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox7.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox7.BOSPropertyName = "Text";
            this.bosTextBox7.Enabled = false;
            this.bosTextBox7.Location = new System.Drawing.Point(111, 59);
            this.bosTextBox7.Name = "bosTextBox7";
            this.bosTextBox7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox7.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox7.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox7.Screen = null;
            this.bosTextBox7.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox7.TabIndex = 115;
            this.bosTextBox7.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(12, 36);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(92, 13);
            this.bosLabel5.TabIndex = 118;
            this.bosLabel5.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel5.Text = "Chi phí đã phân bổ";
            // 
            // bosTextBox8
            // 
            this.bosTextBox8.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox8.BOSDataMember = "OverallProductionCostFor627TotalAmount";
            this.bosTextBox8.BOSDataSource = "MMProductionCosts";
            this.bosTextBox8.BOSDescription = null;
            this.bosTextBox8.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox8.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox8.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox8.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox8.BOSPropertyName = "Text";
            this.bosTextBox8.Enabled = false;
            this.bosTextBox8.Location = new System.Drawing.Point(111, 7);
            this.bosTextBox8.Name = "bosTextBox8";
            this.bosTextBox8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox8.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox8.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox8.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox8.Screen = null;
            this.bosTextBox8.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox8.TabIndex = 116;
            this.bosTextBox8.Tag = "DC";
            // 
            // bosTextBox9
            // 
            this.bosTextBox9.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox9.BOSDataMember = "OverallProductionCostFor627AppropriationAmount";
            this.bosTextBox9.BOSDataSource = "MMProductionCosts";
            this.bosTextBox9.BOSDescription = null;
            this.bosTextBox9.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox9.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox9.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox9.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox9.BOSPropertyName = "Text";
            this.bosTextBox9.Enabled = false;
            this.bosTextBox9.Location = new System.Drawing.Point(111, 33);
            this.bosTextBox9.Name = "bosTextBox9";
            this.bosTextBox9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox9.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox9.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox9.Screen = null;
            this.bosTextBox9.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox9.TabIndex = 117;
            this.bosTextBox9.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 10);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(61, 13);
            this.bosLabel6.TabIndex = 119;
            this.bosLabel6.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.Text = "Tổng chi phí";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcMMProductionCostOveralls6279);
            this.xtraTabPage2.Controls.Add(this.bosLabel1);
            this.xtraTabPage2.Controls.Add(this.bosTextBox1);
            this.xtraTabPage2.Controls.Add(this.bosLabel2);
            this.xtraTabPage2.Controls.Add(this.bosTextBox2);
            this.xtraTabPage2.Controls.Add(this.bosTextBox3);
            this.xtraTabPage2.Controls.Add(this.bosLabel3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(934, 529);
            this.xtraTabPage2.Text = "Chi phí vật liệu toàn nhà máy";
            // 
            // fld_dgcMMProductionCostOveralls6279
            // 
            this.fld_dgcMMProductionCostOveralls6279.AllowDrop = true;
            this.fld_dgcMMProductionCostOveralls6279.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOveralls6279.BOSComment = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSDataMember = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSDataSource = "MMProductionCostOveralls";
            this.fld_dgcMMProductionCostOveralls6279.BOSDescription = "6279";
            this.fld_dgcMMProductionCostOveralls6279.BOSError = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSGridType = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOveralls6279.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOveralls6279.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOveralls6279.Location = new System.Drawing.Point(10, 82);
            this.fld_dgcMMProductionCostOveralls6279.MainView = this.gridView1;
            this.fld_dgcMMProductionCostOveralls6279.Name = "fld_dgcMMProductionCostOveralls6279";
            this.fld_dgcMMProductionCostOveralls6279.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls6279.Screen = null;
            this.fld_dgcMMProductionCostOveralls6279.Size = new System.Drawing.Size(917, 437);
            this.fld_dgcMMProductionCostOveralls6279.TabIndex = 120;
            this.fld_dgcMMProductionCostOveralls6279.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls6279.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionCostOveralls6279;
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
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(16, 59);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(32, 13);
            this.bosLabel1.TabIndex = 119;
            this.bosLabel1.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel1.Text = "Còn lại";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "OverallProductionCostFor6279BalanceAmount";
            this.bosTextBox1.BOSDataSource = "MMProductionCosts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
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
            this.bosLabel2.Location = new System.Drawing.Point(16, 33);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(92, 13);
            this.bosLabel2.TabIndex = 117;
            this.bosLabel2.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel2.Text = "Chi phí đã phân bổ";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSDataMember = "OverallProductionCostFor6279TotalAmount";
            this.bosTextBox2.BOSDataSource = "MMProductionCosts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Enabled = false;
            this.bosTextBox2.Location = new System.Drawing.Point(115, 4);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox2.TabIndex = 116;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox3.BOSDataMember = "OverallProductionCostFor6279AppropriationAmount";
            this.bosTextBox3.BOSDataSource = "MMProductionCosts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox3.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox3.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox3.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
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
            this.bosLabel3.Location = new System.Drawing.Point(16, 7);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 118;
            this.bosLabel3.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel3.Text = "Tổng chi phí";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostOveralls627A);
            this.xtraTabPage1.Controls.Add(this.bosLabel10);
            this.xtraTabPage1.Controls.Add(this.bosTextBox4);
            this.xtraTabPage1.Controls.Add(this.bosLabel11);
            this.xtraTabPage1.Controls.Add(this.bosTextBox6);
            this.xtraTabPage1.Controls.Add(this.bosTextBox5);
            this.xtraTabPage1.Controls.Add(this.bosLabel12);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(934, 529);
            this.xtraTabPage1.Text = "Chi phí nhân công toàn nhà máy";
            // 
            // fld_dgcMMProductionCostOveralls627A
            // 
            this.fld_dgcMMProductionCostOveralls627A.AllowDrop = true;
            this.fld_dgcMMProductionCostOveralls627A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOveralls627A.BOSComment = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSDataMember = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSDataSource = "MMProductionCostOveralls";
            this.fld_dgcMMProductionCostOveralls627A.BOSDescription = "627A";
            this.fld_dgcMMProductionCostOveralls627A.BOSError = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSGridType = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOveralls627A.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOveralls627A.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOveralls627A.Location = new System.Drawing.Point(10, 85);
            this.fld_dgcMMProductionCostOveralls627A.MainView = this.fld_dgvMMProductionCostOveralls6271;
            this.fld_dgcMMProductionCostOveralls627A.Name = "fld_dgcMMProductionCostOveralls627A";
            this.fld_dgcMMProductionCostOveralls627A.PrintReport = false;
            this.fld_dgcMMProductionCostOveralls627A.Screen = null;
            this.fld_dgcMMProductionCostOveralls627A.Size = new System.Drawing.Size(917, 437);
            this.fld_dgcMMProductionCostOveralls627A.TabIndex = 114;
            this.fld_dgcMMProductionCostOveralls627A.Tag = "DC";
            this.fld_dgcMMProductionCostOveralls627A.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionCostOveralls6271});
            // 
            // fld_dgvMMProductionCostOveralls6271
            // 
            this.fld_dgvMMProductionCostOveralls6271.GridControl = this.fld_dgcMMProductionCostOveralls627A;
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
            this.bosLabel10.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(13, 62);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(32, 13);
            this.bosLabel10.TabIndex = 113;
            this.bosLabel10.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.Text = "Còn lại";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSDataMember = "OverallProductionCostFor627ABalanceAmount";
            this.bosTextBox4.BOSDataSource = "MMProductionCosts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
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
            this.bosLabel11.Location = new System.Drawing.Point(13, 36);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(92, 13);
            this.bosLabel11.TabIndex = 111;
            this.bosLabel11.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel11.Text = "Chi phí đã phân bổ";
            // 
            // bosTextBox6
            // 
            this.bosTextBox6.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSDataMember = "OverallProductionCostFor627ATotalAmount";
            this.bosTextBox6.BOSDataSource = "MMProductionCosts";
            this.bosTextBox6.BOSDescription = null;
            this.bosTextBox6.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox6.BOSPropertyName = "Text";
            this.bosTextBox6.Enabled = false;
            this.bosTextBox6.Location = new System.Drawing.Point(112, 7);
            this.bosTextBox6.Name = "bosTextBox6";
            this.bosTextBox6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox6.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox6.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox6.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox6.Screen = null;
            this.bosTextBox6.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox6.TabIndex = 108;
            this.bosTextBox6.Tag = "DC";
            // 
            // bosTextBox5
            // 
            this.bosTextBox5.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSDataMember = "OverallProductionCostFor627AAppropriationAmount";
            this.bosTextBox5.BOSDataSource = "MMProductionCosts";
            this.bosTextBox5.BOSDescription = null;
            this.bosTextBox5.BOSError = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox5.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
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
            this.bosLabel12.Location = new System.Drawing.Point(13, 10);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(61, 13);
            this.bosLabel12.TabIndex = 112;
            this.bosLabel12.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Text = "Tổng chi phí";
            // 
            // DMPDC103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(941, 558);
            this.Controls.Add(this.bosTabControl1);
            this.Name = "DMPDC103";
            this.Text = "Chi phí chung";
            this.Controls.SetChildIndex(this.bosTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox9.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls6279)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOveralls627A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox5.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox5;
        private BOSComponent.BOSLabel bosLabel12;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private IContainer components;
        private BOSComponent.BOSTextBox bosTextBox6;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel3;
        private MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls627A;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionCostOveralls6271;
        private MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls6279;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private MMProductionCostOverallsGridControl fld_dgcMMProductionCostOveralls627;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox bosTextBox8;
        private BOSComponent.BOSTextBox bosTextBox9;
        private BOSComponent.BOSLabel bosLabel6;
	}
}
