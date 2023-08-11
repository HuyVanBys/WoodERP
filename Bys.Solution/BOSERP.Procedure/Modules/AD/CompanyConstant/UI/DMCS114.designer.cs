using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS112
    /// </summary>
    partial class DMCS114
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
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_grpGroupControl5 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADTemplatesGridControl = new BOSERP.Modules.CompanyConstant.ADTemplatesGridControl();
            this.fld_dgvADTemplatesGenarals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADTemplateParamsGridControl = new BOSERP.Modules.CompanyConstant.ADTemplateParamsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSTFieldFormats = new BOSERP.Modules.CompanyConstant.STFieldFormatsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.fld_grpGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplatesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADTemplatesGenarals)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplateParamsGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTFieldFormats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.bosTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(828, 535);
            this.panel1.TabIndex = 6;
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
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(828, 535);
            this.bosTabControl1.TabIndex = 15;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_grpGroupControl5);
            this.xtraTabPage1.Controls.Add(this.bosLine2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(822, 507);
            this.xtraTabPage1.Text = "Mẫu in";
            // 
            // fld_grpGroupControl5
            // 
            this.fld_grpGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpGroupControl5.BOSComment = null;
            this.fld_grpGroupControl5.BOSDataMember = null;
            this.fld_grpGroupControl5.BOSDataSource = null;
            this.fld_grpGroupControl5.BOSDescription = null;
            this.fld_grpGroupControl5.BOSError = null;
            this.fld_grpGroupControl5.BOSFieldGroup = null;
            this.fld_grpGroupControl5.BOSFieldRelation = null;
            this.fld_grpGroupControl5.BOSPrivilege = null;
            this.fld_grpGroupControl5.BOSPropertyName = null;
            this.fld_grpGroupControl5.Controls.Add(this.fld_dgcADTemplatesGridControl);
            this.fld_grpGroupControl5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_grpGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grpGroupControl5.Name = "fld_grpGroupControl5";
            this.fld_grpGroupControl5.Screen = null;
            this.fld_grpGroupControl5.Size = new System.Drawing.Size(812, 255);
            this.fld_grpGroupControl5.TabIndex = 12;
            this.fld_grpGroupControl5.TabStop = false;
            this.fld_grpGroupControl5.Text = "Mẫu in";
            // 
            // fld_dgcADTemplatesGridControl
            // 
            this.fld_dgcADTemplatesGridControl.AllowDrop = true;
            this.fld_dgcADTemplatesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADTemplatesGridControl.BOSComment = "";
            this.fld_dgcADTemplatesGridControl.BOSDataMember = null;
            this.fld_dgcADTemplatesGridControl.BOSDataSource = "ADTemplates";
            this.fld_dgcADTemplatesGridControl.BOSDescription = null;
            this.fld_dgcADTemplatesGridControl.BOSError = "";
            this.fld_dgcADTemplatesGridControl.BOSFieldGroup = "";
            this.fld_dgcADTemplatesGridControl.BOSFieldRelation = null;
            this.fld_dgcADTemplatesGridControl.BOSGridType = null;
            this.fld_dgcADTemplatesGridControl.BOSPrivilege = "";
            this.fld_dgcADTemplatesGridControl.BOSPropertyName = null;
            this.fld_dgcADTemplatesGridControl.CommodityType = "";
            this.fld_dgcADTemplatesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcADTemplatesGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADTemplatesGridControl.MainView = this.fld_dgvADTemplatesGenarals;
            this.fld_dgcADTemplatesGridControl.Name = "fld_dgcADTemplatesGridControl";
            this.fld_dgcADTemplatesGridControl.PrintReport = false;
            this.fld_dgcADTemplatesGridControl.Screen = null;
            this.fld_dgcADTemplatesGridControl.Size = new System.Drawing.Size(801, 229);
            this.fld_dgcADTemplatesGridControl.TabIndex = 4;
            this.fld_dgcADTemplatesGridControl.Tag = "DC";
            this.fld_dgcADTemplatesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvADTemplatesGenarals});
            // 
            // fld_dgvADTemplatesGenarals
            // 
            this.fld_dgvADTemplatesGenarals.GridControl = this.fld_dgcADTemplatesGridControl;
            this.fld_dgvADTemplatesGenarals.Name = "fld_dgvADTemplatesGenarals";
            this.fld_dgvADTemplatesGenarals.PaintStyleName = "Office2003";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcADTemplateParamsGridControl);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 258);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(812, 239);
            this.bosLine2.TabIndex = 14;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Tham số";
            // 
            // fld_dgcADTemplateParamsGridControl
            // 
            this.fld_dgcADTemplateParamsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcADTemplateParamsGridControl.BOSComment = null;
            this.fld_dgcADTemplateParamsGridControl.BOSDataMember = null;
            this.fld_dgcADTemplateParamsGridControl.BOSDataSource = "ADTemplateParams";
            this.fld_dgcADTemplateParamsGridControl.BOSDescription = null;
            this.fld_dgcADTemplateParamsGridControl.BOSError = null;
            this.fld_dgcADTemplateParamsGridControl.BOSFieldGroup = null;
            this.fld_dgcADTemplateParamsGridControl.BOSFieldRelation = null;
            this.fld_dgcADTemplateParamsGridControl.BOSGridType = null;
            this.fld_dgcADTemplateParamsGridControl.BOSPrivilege = null;
            this.fld_dgcADTemplateParamsGridControl.BOSPropertyName = null;
            this.fld_dgcADTemplateParamsGridControl.CommodityType = "";
            this.fld_dgcADTemplateParamsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcADTemplateParamsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcADTemplateParamsGridControl.Name = "fld_dgcADTemplateParamsGridControl";
            this.fld_dgcADTemplateParamsGridControl.PrintReport = false;
            this.fld_dgcADTemplateParamsGridControl.Screen = null;
            this.fld_dgcADTemplateParamsGridControl.Size = new System.Drawing.Size(800, 213);
            this.fld_dgcADTemplateParamsGridControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcSTFieldFormats);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(816, 660);
            this.xtraTabPage2.Text = "Alias Format";
            // 
            // fld_dgcSTFieldFormats
            // 
            this.fld_dgcSTFieldFormats.AllowDrop = true;
            this.fld_dgcSTFieldFormats.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcSTFieldFormats.BOSDataMember = null;
            this.fld_dgcSTFieldFormats.BOSDataSource = "STFieldFormats";
            this.fld_dgcSTFieldFormats.BOSDescription = null;
            this.fld_dgcSTFieldFormats.BOSError = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcSTFieldFormats.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcSTFieldFormats.BOSFieldRelation = null;
            this.fld_dgcSTFieldFormats.BOSGridType = null;
            this.fld_dgcSTFieldFormats.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dgcSTFieldFormats.BOSPropertyName = null;
            this.fld_dgcSTFieldFormats.CommodityType = "";
            this.fld_dgcSTFieldFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcSTFieldFormats.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSTFieldFormats.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcSTFieldFormats.MainView = this.gridView1;
            this.fld_dgcSTFieldFormats.Name = "fld_dgcSTFieldFormats";
            this.fld_dgcSTFieldFormats.PrintReport = false;
            this.fld_dgcSTFieldFormats.Screen = null;
            this.fld_dgcSTFieldFormats.Size = new System.Drawing.Size(816, 660);
            this.fld_dgcSTFieldFormats.TabIndex = 5;
            this.fld_dgcSTFieldFormats.Tag = "DC";
            this.fld_dgcSTFieldFormats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcSTFieldFormats;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMCS114
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(828, 535);
            this.Controls.Add(this.panel1);
            this.Name = "DMCS114";
            this.Text = "Cấu hình mẫu in";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.fld_grpGroupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplatesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvADTemplatesGenarals)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADTemplateParamsGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSTFieldFormats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine fld_grpGroupControl5;
        private ADTemplatesGridControl fld_dgcADTemplatesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvADTemplatesGenarals;
        private BOSComponent.BOSLine bosLine2;
        private ADTemplateParamsGridControl fld_dgcADTemplateParamsGridControl;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private STFieldFormatsGridControl fld_dgcSTFieldFormats;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
