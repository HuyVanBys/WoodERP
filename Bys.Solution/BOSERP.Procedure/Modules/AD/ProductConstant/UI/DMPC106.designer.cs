using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC106
	/// </summary>
	partial class DMPC106
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
            this.fld_tabProductionNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabFSCType = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblNote = new DevExpress.XtraEditors.LabelControl();
            this.fld_dgcMaterialSpeciality = new BOSERP.Modules.ProductConstant.MaterialSpecialityGridControl();
            this.gridView38 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabQuality = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcPackingMaterialSize = new BOSERP.Modules.ProductConstant.PackingMaterialSizeGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMaterialWeightPerVolume = new BOSERP.Modules.ProductConstant.MaterialWeightPerVolumeGridControl();
            this.gridView48 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabWeightPerVolumnMarket = new DevExpress.XtraTab.XtraTabPage();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcMMPackingMaterialMarketDimensions = new BOSERP.Modules.ProductConstant.PackingMaterialMarketDimensionsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).BeginInit();
            this.fld_tabProductionNorm.SuspendLayout();
            this.fld_tabFSCType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).BeginInit();
            this.fld_tabQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPackingMaterialSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            this.xtraTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialWeightPerVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView48)).BeginInit();
            this.fld_tabWeightPerVolumnMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPackingMaterialMarketDimensions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_tabProductionNorm
            // 
            this.fld_tabProductionNorm.BOSComment = null;
            this.fld_tabProductionNorm.BOSDataMember = null;
            this.fld_tabProductionNorm.BOSDataSource = null;
            this.fld_tabProductionNorm.BOSDescription = null;
            this.fld_tabProductionNorm.BOSError = null;
            this.fld_tabProductionNorm.BOSFieldGroup = null;
            this.fld_tabProductionNorm.BOSFieldRelation = null;
            this.fld_tabProductionNorm.BOSPrivilege = null;
            this.fld_tabProductionNorm.BOSPropertyName = null;
            this.fld_tabProductionNorm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProductionNorm.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProductionNorm.Name = "fld_tabProductionNorm";
            this.fld_tabProductionNorm.Screen = null;
            this.fld_tabProductionNorm.SelectedTabPage = this.fld_tabFSCType;
            this.ScreenHelper.SetShowHelp(this.fld_tabProductionNorm, true);
            this.fld_tabProductionNorm.Size = new System.Drawing.Size(862, 567);
            this.fld_tabProductionNorm.TabIndex = 17;
            this.fld_tabProductionNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabFSCType,
            this.fld_tabQuality,
            this.xtraTabPage12,
            this.fld_tabWeightPerVolumnMarket});
            // 
            // fld_tabFSCType
            // 
            this.fld_tabFSCType.Controls.Add(this.labelControl3);
            this.fld_tabFSCType.Controls.Add(this.labelControl2);
            this.fld_tabFSCType.Controls.Add(this.labelControl1);
            this.fld_tabFSCType.Controls.Add(this.fld_lblNote);
            this.fld_tabFSCType.Controls.Add(this.fld_dgcMaterialSpeciality);
            this.fld_tabFSCType.Name = "fld_tabFSCType";
            this.fld_tabFSCType.Size = new System.Drawing.Size(855, 538);
            this.fld_tabFSCType.Text = "Đặc tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(288, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(211, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lưu ý: chỉ hổ trợ các biến số: D,R,C,A,B";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(288, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(325, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = " D = Dài; R = Rộng; C= Cao, A =  diện tích A, B = diện tích B";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "*Thùng -A công thức = (R+C) * 2 + 80";
            // 
            // fld_lblNote
            // 
            this.fld_lblNote.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblNote.Appearance.Options.UseFont = true;
            this.fld_lblNote.Location = new System.Drawing.Point(8, 12);
            this.fld_lblNote.Name = "fld_lblNote";
            this.fld_lblNote.Size = new System.Drawing.Size(243, 13);
            this.fld_lblNote.TabIndex = 6;
            this.fld_lblNote.Text = "* Diện tích thùng A/B theo công thức, ví dụ:";
            // 
            // fld_dgcMaterialSpeciality
            // 
            this.fld_dgcMaterialSpeciality.AllowDrop = true;
            this.fld_dgcMaterialSpeciality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMaterialSpeciality.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialSpeciality.BOSDataMember = null;
            this.fld_dgcMaterialSpeciality.BOSDataSource = "ICProductAttributes";
            this.fld_dgcMaterialSpeciality.BOSDescription = null;
            this.fld_dgcMaterialSpeciality.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialSpeciality.BOSFieldGroup = "Accept";
            this.fld_dgcMaterialSpeciality.BOSFieldRelation = null;
            this.fld_dgcMaterialSpeciality.BOSGridType = null;
            this.fld_dgcMaterialSpeciality.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialSpeciality.BOSPropertyName = null;
            this.fld_dgcMaterialSpeciality.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialSpeciality.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMaterialSpeciality.Location = new System.Drawing.Point(8, 50);
            this.fld_dgcMaterialSpeciality.MainView = this.gridView38;
            this.fld_dgcMaterialSpeciality.Name = "fld_dgcMaterialSpeciality";
            this.fld_dgcMaterialSpeciality.PrintReport = false;
            this.fld_dgcMaterialSpeciality.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMaterialSpeciality, true);
            this.fld_dgcMaterialSpeciality.Size = new System.Drawing.Size(844, 481);
            this.fld_dgcMaterialSpeciality.TabIndex = 5;
            this.fld_dgcMaterialSpeciality.Tag = "DC";
            this.fld_dgcMaterialSpeciality.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView38});
            // 
            // gridView38
            // 
            this.gridView38.GridControl = this.fld_dgcMaterialSpeciality;
            this.gridView38.Name = "gridView38";
            this.gridView38.PaintStyleName = "Office2003";
            // 
            // fld_tabQuality
            // 
            this.fld_tabQuality.Controls.Add(this.fld_dgcPackingMaterialSize);
            this.fld_tabQuality.Name = "fld_tabQuality";
            this.fld_tabQuality.Size = new System.Drawing.Size(855, 538);
            this.fld_tabQuality.Text = "Khổ màng foam";
            // 
            // fld_dgcPackingMaterialSize
            // 
            this.fld_dgcPackingMaterialSize.AllowDrop = true;
            this.fld_dgcPackingMaterialSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPackingMaterialSize.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcPackingMaterialSize.BOSDataMember = null;
            this.fld_dgcPackingMaterialSize.BOSDataSource = "ICProductAttributes";
            this.fld_dgcPackingMaterialSize.BOSDescription = null;
            this.fld_dgcPackingMaterialSize.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcPackingMaterialSize.BOSFieldGroup = "Accept";
            this.fld_dgcPackingMaterialSize.BOSFieldRelation = null;
            this.fld_dgcPackingMaterialSize.BOSGridType = null;
            this.fld_dgcPackingMaterialSize.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcPackingMaterialSize.BOSPropertyName = null;
            this.fld_dgcPackingMaterialSize.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcPackingMaterialSize.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPackingMaterialSize.Location = new System.Drawing.Point(8, 8);
            this.fld_dgcPackingMaterialSize.MainView = this.fld_dgvProductType;
            this.fld_dgcPackingMaterialSize.Name = "fld_dgcPackingMaterialSize";
            this.fld_dgcPackingMaterialSize.PrintReport = false;
            this.fld_dgcPackingMaterialSize.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcPackingMaterialSize, true);
            this.fld_dgcPackingMaterialSize.Size = new System.Drawing.Size(844, 527);
            this.fld_dgcPackingMaterialSize.TabIndex = 5;
            this.fld_dgcPackingMaterialSize.Tag = "DC";
            this.fld_dgcPackingMaterialSize.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcPackingMaterialSize;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Controls.Add(this.fld_dgcMaterialWeightPerVolume);
            this.xtraTabPage12.Name = "xtraTabPage12";
            this.xtraTabPage12.Size = new System.Drawing.Size(855, 538);
            this.xtraTabPage12.Text = "Định lượng thùng Cartor/Xốp";
            // 
            // fld_dgcMaterialWeightPerVolume
            // 
            this.fld_dgcMaterialWeightPerVolume.AllowDrop = true;
            this.fld_dgcMaterialWeightPerVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMaterialWeightPerVolume.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialWeightPerVolume.BOSDataMember = null;
            this.fld_dgcMaterialWeightPerVolume.BOSDataSource = " ICProductAttributes";
            this.fld_dgcMaterialWeightPerVolume.BOSDescription = null;
            this.fld_dgcMaterialWeightPerVolume.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialWeightPerVolume.BOSFieldGroup = "Accept";
            this.fld_dgcMaterialWeightPerVolume.BOSFieldRelation = null;
            this.fld_dgcMaterialWeightPerVolume.BOSGridType = null;
            this.fld_dgcMaterialWeightPerVolume.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialWeightPerVolume.BOSPropertyName = null;
            this.fld_dgcMaterialWeightPerVolume.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMaterialWeightPerVolume.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMaterialWeightPerVolume.Location = new System.Drawing.Point(10, 14);
            this.fld_dgcMaterialWeightPerVolume.MainView = this.gridView48;
            this.fld_dgcMaterialWeightPerVolume.Name = "fld_dgcMaterialWeightPerVolume";
            this.fld_dgcMaterialWeightPerVolume.PrintReport = false;
            this.fld_dgcMaterialWeightPerVolume.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMaterialWeightPerVolume, true);
            this.fld_dgcMaterialWeightPerVolume.Size = new System.Drawing.Size(838, 521);
            this.fld_dgcMaterialWeightPerVolume.TabIndex = 6;
            this.fld_dgcMaterialWeightPerVolume.Tag = "DC";
            this.fld_dgcMaterialWeightPerVolume.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView48});
            // 
            // gridView48
            // 
            this.gridView48.GridControl = this.fld_dgcMaterialWeightPerVolume;
            this.gridView48.Name = "gridView48";
            this.gridView48.PaintStyleName = "Office2003";
            // 
            // fld_tabWeightPerVolumnMarket
            // 
            this.fld_tabWeightPerVolumnMarket.Controls.Add(this.fld_dgcMMPackingMaterialMarketDimensions);
            this.fld_tabWeightPerVolumnMarket.Name = "fld_tabWeightPerVolumnMarket";
            this.fld_tabWeightPerVolumnMarket.Size = new System.Drawing.Size(855, 538);
            this.fld_tabWeightPerVolumnMarket.Text = "Quy cách định lượng theo thị trường";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgcMMPackingMaterialMarketDimensions
            // 
            this.fld_dgcMMPackingMaterialMarketDimensions.AllowDrop = true;
            this.fld_dgcMMPackingMaterialMarketDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSDataMember = null;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSDataSource = "MMPackingMaterialMarketDimensions";
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSDescription = null;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSFieldGroup = "Accept";
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSFieldRelation = null;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSGridType = null;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMPackingMaterialMarketDimensions.BOSPropertyName = null;
            this.fld_dgcMMPackingMaterialMarketDimensions.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMMPackingMaterialMarketDimensions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMPackingMaterialMarketDimensions.Location = new System.Drawing.Point(1, 3);
            this.fld_dgcMMPackingMaterialMarketDimensions.MainView = this.gridView2;
            this.fld_dgcMMPackingMaterialMarketDimensions.Name = "fld_dgcMMPackingMaterialMarketDimensions";
            this.fld_dgcMMPackingMaterialMarketDimensions.PrintReport = false;
            this.fld_dgcMMPackingMaterialMarketDimensions.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMPackingMaterialMarketDimensions, true);
            this.fld_dgcMMPackingMaterialMarketDimensions.Size = new System.Drawing.Size(852, 532);
            this.fld_dgcMMPackingMaterialMarketDimensions.TabIndex = 8;
            this.fld_dgcMMPackingMaterialMarketDimensions.Tag = "DC";
            this.fld_dgcMMPackingMaterialMarketDimensions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMPackingMaterialMarketDimensions;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMPC106
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_tabProductionNorm);
            this.Name = "DMPC106";
            this.Text = "Cấu hình thuộc tính PLDG";
            this.Controls.SetChildIndex(this.fld_tabProductionNorm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductionNorm)).EndInit();
            this.fld_tabProductionNorm.ResumeLayout(false);
            this.fld_tabFSCType.ResumeLayout(false);
            this.fld_tabFSCType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).EndInit();
            this.fld_tabQuality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPackingMaterialSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            this.xtraTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMaterialWeightPerVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView48)).EndInit();
            this.fld_tabWeightPerVolumnMarket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPackingMaterialMarketDimensions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabProductionNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabFSCType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl fld_lblNote;
        private MaterialSpecialityGridControl fld_dgcMaterialSpeciality;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView38;
        private DevExpress.XtraTab.XtraTabPage fld_tabQuality;
        private PackingMaterialSizeGridControl fld_dgcPackingMaterialSize;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;
        private MaterialWeightPerVolumeGridControl fld_dgcMaterialWeightPerVolume;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView48;
        private DevExpress.XtraTab.XtraTabPage fld_tabWeightPerVolumnMarket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PackingMaterialMarketDimensionsGridControl fld_dgcMMPackingMaterialMarketDimensions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
	}
}
