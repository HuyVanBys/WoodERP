namespace BOSERP.Modules.ProductConversion
{
    partial class guiChooseItemShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseItemShipment));
            this.fld_btnLoad = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_tabTransferItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProductSource = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_grpProductSource = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcShowAllTargetProduct = new BOSERP.Modules.ProductConversion.ICProductConversionItemTargetViewsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAllocation = new BOSComponent.BOSButton(this.components);
            this.fld_grpProductTarget = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcMMAllocationPlanItemsGridControl = new BOSERP.Modules.ProductConversion.MMAllocationPlanItemsGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).BeginInit();
            this.fld_tabTransferItems.SuspendLayout();
            this.fld_tabProductSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductSource)).BeginInit();
            this.fld_grpProductSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllTargetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductTarget)).BeginInit();
            this.fld_grpProductTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanItemsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnLoad
            // 
            this.fld_btnLoad.BOSComment = null;
            this.fld_btnLoad.BOSDataMember = null;
            this.fld_btnLoad.BOSDataSource = null;
            this.fld_btnLoad.BOSDescription = null;
            this.fld_btnLoad.BOSError = null;
            this.fld_btnLoad.BOSFieldGroup = null;
            this.fld_btnLoad.BOSFieldRelation = null;
            this.fld_btnLoad.BOSPrivilege = null;
            this.fld_btnLoad.BOSPropertyName = null;
            this.fld_btnLoad.Location = new System.Drawing.Point(161, 6);
            this.fld_btnLoad.Name = "fld_btnLoad";
            this.fld_btnLoad.Screen = null;
            this.fld_btnLoad.Size = new System.Drawing.Size(135, 27);
            this.fld_btnLoad.TabIndex = 17;
            this.fld_btnLoad.Text = "Load lại kế hoạch";
            this.fld_btnLoad.Click += new System.EventHandler(this.fld_btnLoad_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(1108, 700);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 16;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_tabTransferItems
            // 
            this.fld_tabTransferItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabTransferItems.BOSComment = null;
            this.fld_tabTransferItems.BOSDataMember = null;
            this.fld_tabTransferItems.BOSDataSource = null;
            this.fld_tabTransferItems.BOSDescription = null;
            this.fld_tabTransferItems.BOSError = null;
            this.fld_tabTransferItems.BOSFieldGroup = null;
            this.fld_tabTransferItems.BOSFieldRelation = null;
            this.fld_tabTransferItems.BOSPrivilege = null;
            this.fld_tabTransferItems.BOSPropertyName = null;
            this.fld_tabTransferItems.Location = new System.Drawing.Point(12, 4);
            this.fld_tabTransferItems.Name = "fld_tabTransferItems";
            this.fld_tabTransferItems.Screen = null;
            this.fld_tabTransferItems.SelectedTabPage = this.fld_tabProductSource;
            this.ScreenHelper.SetShowHelp(this.fld_tabTransferItems, true);
            this.fld_tabTransferItems.Size = new System.Drawing.Size(1179, 690);
            this.fld_tabTransferItems.TabIndex = 567;
            this.fld_tabTransferItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductSource});
            // 
            // fld_tabProductSource
            // 
            this.fld_tabProductSource.Controls.Add(this.splitContainerControl1);
            this.fld_tabProductSource.Name = "fld_tabProductSource";
            this.ScreenHelper.SetShowHelp(this.fld_tabProductSource, true);
            this.fld_tabProductSource.Size = new System.Drawing.Size(1177, 665);
            this.fld_tabProductSource.Text = "Danh sách chuyển mã";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grpProductSource);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_grpProductTarget);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnAllocation);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_btnLoad);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1177, 665);
            this.splitContainerControl1.SplitterPosition = 774;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // fld_grpProductSource
            // 
            this.fld_grpProductSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpProductSource.Controls.Add(this.fld_dgcShowAllTargetProduct);
            this.fld_grpProductSource.Location = new System.Drawing.Point(0, 36);
            this.fld_grpProductSource.Name = "fld_grpProductSource";
            this.fld_grpProductSource.Size = new System.Drawing.Size(774, 626);
            this.fld_grpProductSource.TabIndex = 0;
            // 
            // fld_dgcShowAllTargetProduct
            // 
            this.fld_dgcShowAllTargetProduct.BOSComment = "";
            this.fld_dgcShowAllTargetProduct.BOSDataMember = "";
            this.fld_dgcShowAllTargetProduct.BOSDataSource = "ICProductConversionItems";
            this.fld_dgcShowAllTargetProduct.BOSDescription = null;
            this.fld_dgcShowAllTargetProduct.BOSError = null;
            this.fld_dgcShowAllTargetProduct.BOSFieldGroup = "";
            this.fld_dgcShowAllTargetProduct.BOSFieldRelation = "";
            this.fld_dgcShowAllTargetProduct.BOSGridType = null;
            this.fld_dgcShowAllTargetProduct.BOSPrivilege = "";
            this.fld_dgcShowAllTargetProduct.BOSPropertyName = null;
            this.fld_dgcShowAllTargetProduct.CommodityType = "";
            this.fld_dgcShowAllTargetProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcShowAllTargetProduct.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcShowAllTargetProduct.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcShowAllTargetProduct.MainView = this.gridView1;
            this.fld_dgcShowAllTargetProduct.Name = "fld_dgcShowAllTargetProduct";
            this.fld_dgcShowAllTargetProduct.PrintReport = false;
            this.fld_dgcShowAllTargetProduct.Screen = null;
            this.fld_dgcShowAllTargetProduct.Size = new System.Drawing.Size(770, 601);
            this.fld_dgcShowAllTargetProduct.TabIndex = 6;
            this.fld_dgcShowAllTargetProduct.Tag = "DC";
            this.fld_dgcShowAllTargetProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcShowAllTargetProduct;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_btnAllocation
            // 
            this.fld_btnAllocation.BOSComment = null;
            this.fld_btnAllocation.BOSDataMember = null;
            this.fld_btnAllocation.BOSDataSource = null;
            this.fld_btnAllocation.BOSDescription = null;
            this.fld_btnAllocation.BOSError = null;
            this.fld_btnAllocation.BOSFieldGroup = null;
            this.fld_btnAllocation.BOSFieldRelation = null;
            this.fld_btnAllocation.BOSPrivilege = null;
            this.fld_btnAllocation.BOSPropertyName = null;
            this.fld_btnAllocation.Location = new System.Drawing.Point(13, 6);
            this.fld_btnAllocation.Name = "fld_btnAllocation";
            this.fld_btnAllocation.Screen = null;
            this.fld_btnAllocation.Size = new System.Drawing.Size(135, 27);
            this.fld_btnAllocation.TabIndex = 17;
            this.fld_btnAllocation.Text = "Phân bổ";
            this.fld_btnAllocation.Click += new System.EventHandler(this.fld_btnAllocation_Click);
            // 
            // fld_grpProductTarget
            // 
            this.fld_grpProductTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grpProductTarget.Controls.Add(this.fld_dgcMMAllocationPlanItemsGridControl);
            this.fld_grpProductTarget.Location = new System.Drawing.Point(11, 36);
            this.fld_grpProductTarget.Name = "fld_grpProductTarget";
            this.fld_grpProductTarget.Size = new System.Drawing.Size(382, 629);
            this.fld_grpProductTarget.TabIndex = 1;
            // 
            // fld_dgcMMAllocationPlanItemsGridControl
            // 
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSComment = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDataMember = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDataSource = "MMAllocationPlanItems";
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSDescription = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSError = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSGridType = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSPrivilege = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.BOSPropertyName = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.CommodityType = "";
            this.fld_dgcMMAllocationPlanItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMAllocationPlanItemsGridControl.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMAllocationPlanItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcMMAllocationPlanItemsGridControl.Name = "fld_dgcMMAllocationPlanItemsGridControl";
            this.fld_dgcMMAllocationPlanItemsGridControl.PrintReport = false;
            this.fld_dgcMMAllocationPlanItemsGridControl.Screen = null;
            this.fld_dgcMMAllocationPlanItemsGridControl.Size = new System.Drawing.Size(378, 604);
            this.fld_dgcMMAllocationPlanItemsGridControl.TabIndex = 11;
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(992, 700);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(101, 27);
            this.fld_btnChoose.TabIndex = 17;
            this.fld_btnChoose.Text = "Chọn";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // guiChooseItemShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 737);
            this.ControlBox = true;
            this.Controls.Add(this.fld_tabTransferItems);
            this.Controls.Add(this.fld_btnChoose);
            this.Controls.Add(this.fld_btnClose);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiChooseItemShipment.IconOptions.Icon")));
            this.Name = "guiChooseItemShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiShowAll_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_tabTransferItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTransferItems)).EndInit();
            this.fld_tabTransferItems.ResumeLayout(false);
            this.fld_tabProductSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductSource)).EndInit();
            this.fld_grpProductSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShowAllTargetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grpProductTarget)).EndInit();
            this.fld_grpProductTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMAllocationPlanItemsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnLoad;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSTabControl fld_tabTransferItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl fld_grpProductSource;
        private ICProductConversionItemTargetViewsGridControl fld_dgcShowAllTargetProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl fld_grpProductTarget;
        private ProductConversion.MMAllocationPlanItemsGridControl fld_dgcMMAllocationPlanItemsGridControl;
        private BOSComponent.BOSButton fld_btnAllocation;
        private BOSComponent.BOSButton fld_btnChoose;
    }
}