namespace BOSERP.Modules.BatchProductShedule
{
    partial class guiAddMaterialOverBOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddMaterialOverBOM));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_trlMMViewChangeSemiBOMs = new BOSERP.Modules.BatchProductShedule.MMViewChangeSemiBOMsTreeList();
            this.fld_dgcItemHardware = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabVMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcItemMaterials = new BOSERP.Modules.BatchProductShedule.MMBPProductionNormItemMaterialsGridControl();
            this.fld_tabVHardware = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcItemHardwares = new BOSERP.Modules.BatchProductShedule.MMBPItemHardwareGridControl();
            this.fld_tabVPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcItemPaint = new BOSERP.Modules.BatchProductShedule.MMBPItemIngredientPaintGridControl();
            this.fld_tabVPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcItemPackagingList = new BOSERP.Modules.BatchProductShedule.MMBPItemIngredientPackagingGridControl();
            this.fld_tabVGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcItemGeneralMaterial = new BOSERP.Modules.BatchProductShedule.MMBPItemGeneralMaterialGridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMViewChangeSemiBOMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemHardware)).BeginInit();
            this.fld_dgcItemHardware.SuspendLayout();
            this.fld_tabVMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemMaterials)).BeginInit();
            this.fld_tabVHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemHardwares)).BeginInit();
            this.fld_tabVPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemPaint)).BeginInit();
            this.fld_tabVPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemPackagingList)).BeginInit();
            this.fld_tabVGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemGeneralMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(1214, 741);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(90, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Huỷ";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(1118, 741);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(90, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Lưu";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(6, 16);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_trlMMViewChangeSemiBOMs);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_dgcItemHardware);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1296, 706);
            this.splitContainerControl1.SplitterPosition = 287;
            this.splitContainerControl1.TabIndex = 20;
            // 
            // fld_trlMMViewChangeSemiBOMs
            // 
            this.fld_trlMMViewChangeSemiBOMs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMViewChangeSemiBOMs.BOSComment = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSDataMember = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_trlMMViewChangeSemiBOMs.BOSDescription = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSDisplayOption = false;
            this.fld_trlMMViewChangeSemiBOMs.BOSDisplayRoot = false;
            this.fld_trlMMViewChangeSemiBOMs.BOSError = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSFieldGroup = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSFieldRelation = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSPrivilege = null;
            this.fld_trlMMViewChangeSemiBOMs.BOSPropertyName = null;
            this.fld_trlMMViewChangeSemiBOMs.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_trlMMViewChangeSemiBOMs.KeyFieldName = "MMBatchProductProductionNormItemID";
            this.fld_trlMMViewChangeSemiBOMs.Location = new System.Drawing.Point(0, 2);
            this.fld_trlMMViewChangeSemiBOMs.Name = "fld_trlMMViewChangeSemiBOMs";
            this.fld_trlMMViewChangeSemiBOMs.OptionsView.AutoWidth = false;
            this.fld_trlMMViewChangeSemiBOMs.ParentFieldName = "MMBatchProductProductionNormItemParentID";
            this.fld_trlMMViewChangeSemiBOMs.Screen = null;
            this.fld_trlMMViewChangeSemiBOMs.Size = new System.Drawing.Size(286, 699);
            this.fld_trlMMViewChangeSemiBOMs.TabIndex = 104;
            // 
            // fld_dgcItemHardware
            // 
            this.fld_dgcItemHardware.BOSComment = null;
            this.fld_dgcItemHardware.BOSDataMember = null;
            this.fld_dgcItemHardware.BOSDataSource = null;
            this.fld_dgcItemHardware.BOSDescription = null;
            this.fld_dgcItemHardware.BOSError = null;
            this.fld_dgcItemHardware.BOSFieldGroup = null;
            this.fld_dgcItemHardware.BOSFieldRelation = null;
            this.fld_dgcItemHardware.BOSPrivilege = null;
            this.fld_dgcItemHardware.BOSPropertyName = null;
            this.fld_dgcItemHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemHardware.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemHardware.Name = "fld_dgcItemHardware";
            this.fld_dgcItemHardware.Screen = null;
            this.fld_dgcItemHardware.SelectedTabPage = this.fld_tabVMaterial;
            this.ScreenHelper.SetShowHelp(this.fld_dgcItemHardware, true);
            this.fld_dgcItemHardware.Size = new System.Drawing.Size(999, 706);
            this.fld_dgcItemHardware.TabIndex = 38;
            this.fld_dgcItemHardware.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabVMaterial,
            this.fld_tabVHardware,
            this.fld_tabVPaint,
            this.fld_tabVPackaging,
            this.fld_tabVGeneral});
            // 
            // fld_tabVMaterial
            // 
            this.fld_tabVMaterial.Controls.Add(this.fld_dgcItemMaterials);
            this.fld_tabVMaterial.Name = "fld_tabVMaterial";
            this.ScreenHelper.SetShowHelp(this.fld_tabVMaterial, true);
            this.fld_tabVMaterial.Size = new System.Drawing.Size(997, 681);
            this.fld_tabVMaterial.Text = "ĐM nguyên liệu chính";
            // 
            // fld_dgcItemMaterials
            // 
            this.fld_dgcItemMaterials.BatchProductItemID = 0;
            this.fld_dgcItemMaterials.BOSComment = null;
            this.fld_dgcItemMaterials.BOSDataMember = null;
            this.fld_dgcItemMaterials.BOSDataSource = "MMBatchProductProductionNormItemMeterials";
            this.fld_dgcItemMaterials.BOSDescription = null;
            this.fld_dgcItemMaterials.BOSError = null;
            this.fld_dgcItemMaterials.BOSFieldGroup = null;
            this.fld_dgcItemMaterials.BOSFieldRelation = null;
            this.fld_dgcItemMaterials.BOSGridType = null;
            this.fld_dgcItemMaterials.BOSPrivilege = null;
            this.fld_dgcItemMaterials.BOSPropertyName = null;
            this.fld_dgcItemMaterials.CommodityType = "";
            this.fld_dgcItemMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemMaterials.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemMaterials.MenuManager = this.screenToolbar;
            this.fld_dgcItemMaterials.Name = "fld_dgcItemMaterials";
            this.fld_dgcItemMaterials.OperationDataSource = null;
            this.fld_dgcItemMaterials.PrintReport = false;
            this.fld_dgcItemMaterials.Screen = null;
            this.fld_dgcItemMaterials.Size = new System.Drawing.Size(997, 681);
            this.fld_dgcItemMaterials.TabIndex = 3;
            this.fld_dgcItemMaterials.Tag = "";
            // 
            // fld_tabVHardware
            // 
            this.fld_tabVHardware.Controls.Add(this.fld_dgcItemHardwares);
            this.fld_tabVHardware.Name = "fld_tabVHardware";
            this.ScreenHelper.SetShowHelp(this.fld_tabVHardware, true);
            this.fld_tabVHardware.Size = new System.Drawing.Size(983, 674);
            this.fld_tabVHardware.Text = "ĐM Hardware";
            // 
            // fld_dgcItemHardwares
            // 
            this.fld_dgcItemHardwares.BOSComment = null;
            this.fld_dgcItemHardwares.BOSDataMember = null;
            this.fld_dgcItemHardwares.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcItemHardwares.BOSDescription = null;
            this.fld_dgcItemHardwares.BOSError = null;
            this.fld_dgcItemHardwares.BOSFieldGroup = null;
            this.fld_dgcItemHardwares.BOSFieldRelation = null;
            this.fld_dgcItemHardwares.BOSGridType = null;
            this.fld_dgcItemHardwares.BOSPrivilege = null;
            this.fld_dgcItemHardwares.BOSPropertyName = null;
            this.fld_dgcItemHardwares.CommodityType = "";
            this.fld_dgcItemHardwares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemHardwares.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemHardwares.MenuManager = this.screenToolbar;
            this.fld_dgcItemHardwares.Name = "fld_dgcItemHardwares";
            this.fld_dgcItemHardwares.PrintReport = false;
            this.fld_dgcItemHardwares.Screen = null;
            this.fld_dgcItemHardwares.Size = new System.Drawing.Size(983, 674);
            this.fld_dgcItemHardwares.TabIndex = 4;
            this.fld_dgcItemHardwares.Tag = "";
            // 
            // fld_tabVPaint
            // 
            this.fld_tabVPaint.Controls.Add(this.fld_dgcItemPaint);
            this.fld_tabVPaint.Name = "fld_tabVPaint";
            this.fld_tabVPaint.Size = new System.Drawing.Size(983, 674);
            this.fld_tabVPaint.Text = "ĐM Sơn";
            // 
            // fld_dgcItemPaint
            // 
            this.fld_dgcItemPaint.BOSComment = null;
            this.fld_dgcItemPaint.BOSDataMember = null;
            this.fld_dgcItemPaint.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcItemPaint.BOSDescription = null;
            this.fld_dgcItemPaint.BOSError = null;
            this.fld_dgcItemPaint.BOSFieldGroup = null;
            this.fld_dgcItemPaint.BOSFieldRelation = null;
            this.fld_dgcItemPaint.BOSGridType = null;
            this.fld_dgcItemPaint.BOSPrivilege = null;
            this.fld_dgcItemPaint.BOSPropertyName = null;
            this.fld_dgcItemPaint.CommodityType = "";
            this.fld_dgcItemPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemPaint.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemPaint.MenuManager = this.screenToolbar;
            this.fld_dgcItemPaint.Name = "fld_dgcItemPaint";
            this.fld_dgcItemPaint.PrintReport = false;
            this.fld_dgcItemPaint.Screen = null;
            this.fld_dgcItemPaint.Size = new System.Drawing.Size(983, 674);
            this.fld_dgcItemPaint.TabIndex = 5;
            this.fld_dgcItemPaint.Tag = "";
            // 
            // fld_tabVPackaging
            // 
            this.fld_tabVPackaging.Controls.Add(this.fld_dgcItemPackagingList);
            this.fld_tabVPackaging.Name = "fld_tabVPackaging";
            this.fld_tabVPackaging.Size = new System.Drawing.Size(983, 674);
            this.fld_tabVPackaging.Text = "ĐM Phụ liệu đóng gói";
            // 
            // fld_dgcItemPackagingList
            // 
            this.fld_dgcItemPackagingList.BOSComment = null;
            this.fld_dgcItemPackagingList.BOSDataMember = null;
            this.fld_dgcItemPackagingList.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcItemPackagingList.BOSDescription = null;
            this.fld_dgcItemPackagingList.BOSError = null;
            this.fld_dgcItemPackagingList.BOSFieldGroup = null;
            this.fld_dgcItemPackagingList.BOSFieldRelation = null;
            this.fld_dgcItemPackagingList.BOSGridType = null;
            this.fld_dgcItemPackagingList.BOSPrivilege = null;
            this.fld_dgcItemPackagingList.BOSPropertyName = null;
            this.fld_dgcItemPackagingList.CommodityType = "";
            this.fld_dgcItemPackagingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemPackagingList.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemPackagingList.MenuManager = this.screenToolbar;
            this.fld_dgcItemPackagingList.Name = "fld_dgcItemPackagingList";
            this.fld_dgcItemPackagingList.PrintReport = false;
            this.fld_dgcItemPackagingList.Screen = null;
            this.fld_dgcItemPackagingList.Size = new System.Drawing.Size(983, 674);
            this.fld_dgcItemPackagingList.TabIndex = 5;
            this.fld_dgcItemPackagingList.Tag = "";
            // 
            // fld_tabVGeneral
            // 
            this.fld_tabVGeneral.Controls.Add(this.fld_dgcItemGeneralMaterial);
            this.fld_tabVGeneral.Name = "fld_tabVGeneral";
            this.fld_tabVGeneral.Size = new System.Drawing.Size(983, 674);
            this.fld_tabVGeneral.Text = "Vật tư khác";
            // 
            // fld_dgcItemGeneralMaterial
            // 
            this.fld_dgcItemGeneralMaterial.BOSComment = null;
            this.fld_dgcItemGeneralMaterial.BOSDataMember = null;
            this.fld_dgcItemGeneralMaterial.BOSDataSource = "MMBatchProductProductionNormItems";
            this.fld_dgcItemGeneralMaterial.BOSDescription = null;
            this.fld_dgcItemGeneralMaterial.BOSError = null;
            this.fld_dgcItemGeneralMaterial.BOSFieldGroup = null;
            this.fld_dgcItemGeneralMaterial.BOSFieldRelation = null;
            this.fld_dgcItemGeneralMaterial.BOSGridType = null;
            this.fld_dgcItemGeneralMaterial.BOSPrivilege = null;
            this.fld_dgcItemGeneralMaterial.BOSPropertyName = null;
            this.fld_dgcItemGeneralMaterial.CommodityType = "";
            this.fld_dgcItemGeneralMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcItemGeneralMaterial.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcItemGeneralMaterial.MenuManager = this.screenToolbar;
            this.fld_dgcItemGeneralMaterial.Name = "fld_dgcItemGeneralMaterial";
            this.fld_dgcItemGeneralMaterial.PrintReport = false;
            this.fld_dgcItemGeneralMaterial.Screen = null;
            this.fld_dgcItemGeneralMaterial.Size = new System.Drawing.Size(983, 674);
            this.fld_dgcItemGeneralMaterial.TabIndex = 5;
            this.fld_dgcItemGeneralMaterial.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainerControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 728);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết thay đổi";
            // 
            // guiAddMaterialOverBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(1320, 776);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiAddMaterialOverBOM.IconOptions.Icon")));
            this.Name = "guiAddMaterialOverBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm vật tư ngoài định mức";
            this.Load += new System.EventHandler(this.guiAddMaterialOverBOM_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMViewChangeSemiBOMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemHardware)).EndInit();
            this.fld_dgcItemHardware.ResumeLayout(false);
            this.fld_tabVMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemMaterials)).EndInit();
            this.fld_tabVHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemHardwares)).EndInit();
            this.fld_tabVPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemPaint)).EndInit();
            this.fld_tabVPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemPackagingList)).EndInit();
            this.fld_tabVGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcItemGeneralMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BatchProductShedule.MMViewChangeSemiBOMsTreeList fld_trlMMViewChangeSemiBOMs;
        private BOSComponent.BOSTabControl fld_dgcItemHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tabVMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabVHardware;
        private DevExpress.XtraTab.XtraTabPage fld_tabVPaint;
        private DevExpress.XtraTab.XtraTabPage fld_tabVPackaging;
        private DevExpress.XtraTab.XtraTabPage fld_tabVGeneral;
        private MMBPProductionNormItemMaterialsGridControl fld_dgcItemMaterials;
        private MMBPItemHardwareGridControl fld_dgcItemHardwares;
        private MMBPItemIngredientPaintGridControl fld_dgcItemPaint;
        private MMBPItemIngredientPackagingGridControl fld_dgcItemPackagingList;
        private MMBPItemGeneralMaterialGridControl fld_dgcItemGeneralMaterial;
    }
}