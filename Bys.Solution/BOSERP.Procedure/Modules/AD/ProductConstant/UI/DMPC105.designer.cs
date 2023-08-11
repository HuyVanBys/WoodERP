using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC105
	/// </summary>
	partial class DMPC105
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
            this.fld_dgcMMFormulaConfigurations = new BOSERP.Modules.ProductConstant.MMFormulaConfigurationGridControl();
            this.fld_dgvMMProductionNormItemConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPaint = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtToNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFromNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_tabAddMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgvMMFormulaConfigurationAddMaterials = new BOSERP.Modules.ProductConstant.MMFormulaConfigurationAddMaterialGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMFormulaConfigurations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionNormItemConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.fld_tabPaint.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtToNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFromNumber.Properties)).BeginInit();
            this.fld_tabAddMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMFormulaConfigurationAddMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMFormulaConfigurations
            // 
            this.fld_dgcMMFormulaConfigurations.AllowDrop = true;
            this.fld_dgcMMFormulaConfigurations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMFormulaConfigurations.BOSComment = "";
            this.fld_dgcMMFormulaConfigurations.BOSDataMember = null;
            this.fld_dgcMMFormulaConfigurations.BOSDataSource = "MMFormulaConfigurations";
            this.fld_dgcMMFormulaConfigurations.BOSDescription = null;
            this.fld_dgcMMFormulaConfigurations.BOSError = "";
            this.fld_dgcMMFormulaConfigurations.BOSFieldGroup = "";
            this.fld_dgcMMFormulaConfigurations.BOSFieldRelation = null;
            this.fld_dgcMMFormulaConfigurations.BOSGridType = null;
            this.fld_dgcMMFormulaConfigurations.BOSPrivilege = "";
            this.fld_dgcMMFormulaConfigurations.BOSPropertyName = null;
            this.fld_dgcMMFormulaConfigurations.CommodityType = "";
            this.fld_dgcMMFormulaConfigurations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMFormulaConfigurations.Location = new System.Drawing.Point(3, -1);
            this.fld_dgcMMFormulaConfigurations.MainView = this.fld_dgvMMProductionNormItemConfigs;
            this.fld_dgcMMFormulaConfigurations.Name = "fld_dgcMMFormulaConfigurations";
            this.fld_dgcMMFormulaConfigurations.PrintReport = false;
            this.fld_dgcMMFormulaConfigurations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMFormulaConfigurations, true);
            this.fld_dgcMMFormulaConfigurations.Size = new System.Drawing.Size(860, 549);
            this.fld_dgcMMFormulaConfigurations.TabIndex = 6;
            this.fld_dgcMMFormulaConfigurations.Tag = "DC";
            this.fld_dgcMMFormulaConfigurations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionNormItemConfigs});
            // 
            // fld_dgvMMProductionNormItemConfigs
            // 
            this.fld_dgvMMProductionNormItemConfigs.GridControl = this.fld_dgcMMFormulaConfigurations;
            this.fld_dgvMMProductionNormItemConfigs.Name = "fld_dgvMMProductionNormItemConfigs";
            this.fld_dgvMMProductionNormItemConfigs.PaintStyleName = "Office2003";
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
            this.bosTabControl1.SelectedTabPage = this.fld_tabPaint;
            this.bosTabControl1.Size = new System.Drawing.Size(874, 579);
            this.bosTabControl1.TabIndex = 69;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPaint,
            this.fld_tabAddMaterial});
            // 
            // fld_tabPaint
            // 
            this.fld_tabPaint.Controls.Add(this.fld_dgcMMFormulaConfigurations);
            this.fld_tabPaint.Controls.Add(this.bosLine2);
            this.fld_tabPaint.Name = "fld_tabPaint";
            this.fld_tabPaint.Size = new System.Drawing.Size(868, 551);
            this.fld_tabPaint.Text = "Công thức tính sơn";
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
            this.bosLine2.Controls.Add(this.fld_btnPrint);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.fld_txtToNumber);
            this.bosLine2.Controls.Add(this.bosLabel5);
            this.bosLine2.Controls.Add(this.fld_txtFromNumber);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 575);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(824, 67);
            this.bosLine2.TabIndex = 65;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "In mã định danh";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(285, 20);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(94, 31);
            this.fld_btnPrint.TabIndex = 66;
            this.fld_btnPrint.Text = "In";
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
            this.bosLabel1.Location = new System.Drawing.Point(143, 28);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(34, 13);
            this.bosLabel1.TabIndex = 7;
            this.bosLabel1.Text = "Đến số";
            // 
            // fld_txtToNumber
            // 
            this.fld_txtToNumber.BOSComment = null;
            this.fld_txtToNumber.BOSDataMember = null;
            this.fld_txtToNumber.BOSDataSource = null;
            this.fld_txtToNumber.BOSDescription = null;
            this.fld_txtToNumber.BOSError = null;
            this.fld_txtToNumber.BOSFieldGroup = null;
            this.fld_txtToNumber.BOSFieldRelation = null;
            this.fld_txtToNumber.BOSPrivilege = null;
            this.fld_txtToNumber.BOSPropertyName = null;
            this.fld_txtToNumber.Location = new System.Drawing.Point(183, 25);
            this.fld_txtToNumber.Name = "fld_txtToNumber";
            this.fld_txtToNumber.Properties.Mask.EditMask = "n0";
            this.fld_txtToNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtToNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtToNumber, true);
            this.fld_txtToNumber.Size = new System.Drawing.Size(96, 20);
            this.fld_txtToNumber.TabIndex = 6;
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
            this.bosLabel5.Location = new System.Drawing.Point(8, 28);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 5;
            this.bosLabel5.Text = "Từ số";
            // 
            // fld_txtFromNumber
            // 
            this.fld_txtFromNumber.BOSComment = null;
            this.fld_txtFromNumber.BOSDataMember = null;
            this.fld_txtFromNumber.BOSDataSource = null;
            this.fld_txtFromNumber.BOSDescription = null;
            this.fld_txtFromNumber.BOSError = null;
            this.fld_txtFromNumber.BOSFieldGroup = null;
            this.fld_txtFromNumber.BOSFieldRelation = null;
            this.fld_txtFromNumber.BOSPrivilege = null;
            this.fld_txtFromNumber.BOSPropertyName = null;
            this.fld_txtFromNumber.Location = new System.Drawing.Point(41, 25);
            this.fld_txtFromNumber.Name = "fld_txtFromNumber";
            this.fld_txtFromNumber.Properties.Mask.EditMask = "n0";
            this.fld_txtFromNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtFromNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtFromNumber, true);
            this.fld_txtFromNumber.Size = new System.Drawing.Size(96, 20);
            this.fld_txtFromNumber.TabIndex = 1;
            // 
            // fld_tabAddMaterial
            // 
            this.fld_tabAddMaterial.Controls.Add(this.fld_dgvMMFormulaConfigurationAddMaterials);
            this.fld_tabAddMaterial.Name = "fld_tabAddMaterial";
            this.fld_tabAddMaterial.Size = new System.Drawing.Size(868, 551);
            this.fld_tabAddMaterial.Text = "Công thức tính chỉ viền";
            // 
            // fld_dgvMMFormulaConfigurationAddMaterials
            // 
            this.fld_dgvMMFormulaConfigurationAddMaterials.AllowDrop = true;
            this.fld_dgvMMFormulaConfigurationAddMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSComment = "";
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSDataMember = null;
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSDataSource = "MMFormulaConfigurations";
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSDescription = null;
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSError = "";
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSFieldGroup = "";
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSFieldRelation = null;
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSGridType = null;
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSPrivilege = "";
            this.fld_dgvMMFormulaConfigurationAddMaterials.BOSPropertyName = null;
            this.fld_dgvMMFormulaConfigurationAddMaterials.CommodityType = "";
            this.fld_dgvMMFormulaConfigurationAddMaterials.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgvMMFormulaConfigurationAddMaterials.Location = new System.Drawing.Point(4, 1);
            this.fld_dgvMMFormulaConfigurationAddMaterials.MainView = this.gridView1;
            this.fld_dgvMMFormulaConfigurationAddMaterials.Name = "fld_dgvMMFormulaConfigurationAddMaterials";
            this.fld_dgvMMFormulaConfigurationAddMaterials.PrintReport = false;
            this.fld_dgvMMFormulaConfigurationAddMaterials.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgvMMFormulaConfigurationAddMaterials, true);
            this.fld_dgvMMFormulaConfigurationAddMaterials.Size = new System.Drawing.Size(860, 549);
            this.fld_dgvMMFormulaConfigurationAddMaterials.TabIndex = 7;
            this.fld_dgvMMFormulaConfigurationAddMaterials.Tag = "DC";
            this.fld_dgvMMFormulaConfigurationAddMaterials.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgvMMFormulaConfigurationAddMaterials;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // DMPC105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(874, 579);
            this.Controls.Add(this.bosTabControl1);
            this.Name = "DMPC105";
            this.Text = "Cấu hình công thức sơn / quy đổi chỉ viền";
            this.Controls.SetChildIndex(this.bosTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMFormulaConfigurations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionNormItemConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.fld_tabPaint.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtToNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFromNumber.Properties)).EndInit();
            this.fld_tabAddMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMFormulaConfigurationAddMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private MMFormulaConfigurationGridControl fld_dgcMMFormulaConfigurations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionNormItemConfigs;
        private IContainer components;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaint;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtToNumber;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtFromNumber;
        private DevExpress.XtraTab.XtraTabPage fld_tabAddMaterial;
        private MMFormulaConfigurationAddMaterialGridControl fld_dgvMMFormulaConfigurationAddMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
