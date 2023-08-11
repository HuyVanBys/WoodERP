namespace BOSERP.Modules.SaleOrder
{
    partial class guiSaleOrderWorkItemComponent
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_tabTemplateItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorkMaterialsGridControl();
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcSaleOrderWorkItemTasksGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderItemWorkTasksGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).BeginInit();
            this.fld_tabTemplateItem.SuspendLayout();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderWorkItemComponentsGridControl)).BeginInit();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderWorkItemTasksGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(849, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Hủy";
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
            this.fld_btnApply.Location = new System.Drawing.Point(760, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_tabTemplateItem
            // 
            this.fld_tabTemplateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabTemplateItem.BOSComment = null;
            this.fld_tabTemplateItem.BOSDataMember = null;
            this.fld_tabTemplateItem.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_tabTemplateItem.BOSDescription = null;
            this.fld_tabTemplateItem.BOSError = null;
            this.fld_tabTemplateItem.BOSFieldGroup = null;
            this.fld_tabTemplateItem.BOSFieldRelation = null;
            this.fld_tabTemplateItem.BOSPrivilege = null;
            this.fld_tabTemplateItem.BOSPropertyName = null;
            this.fld_tabTemplateItem.Location = new System.Drawing.Point(4, 12);
            this.fld_tabTemplateItem.Name = "fld_tabTemplateItem";
            this.fld_tabTemplateItem.Screen = null;
            this.fld_tabTemplateItem.SelectedTabPage = this.fld_tabMaterial;
            this.fld_tabTemplateItem.Size = new System.Drawing.Size(929, 526);
            this.fld_tabTemplateItem.TabIndex = 132;
            this.fld_tabTemplateItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabMaterial,
            this.fld_tabTask});
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_dgcARSaleOrderWorkItemComponentsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(922, 497);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_dgcARSaleOrderWorkItemComponentsGridControl
            // 
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSDataSource = "ARSaleOrderItemWorkItems";
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSError = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.Name = "fld_dgcARSaleOrderWorkItemComponentsGridControl";
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.Screen = null;
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.Size = new System.Drawing.Size(916, 491);
            this.fld_dgcARSaleOrderWorkItemComponentsGridControl.TabIndex = 0;
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcSaleOrderWorkItemTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(922, 497);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_dgcSaleOrderWorkItemTasksGridControl
            // 
            this.fld_dgcSaleOrderWorkItemTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSComment = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSDataMember = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSDataSource = "ARSaleOrderItemWorkTasks";
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSDescription = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSError = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSGridType = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSPrivilege = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.BOSPropertyName = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcSaleOrderWorkItemTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.Name = "fld_dgcSaleOrderWorkItemTasksGridControl";
            this.fld_dgcSaleOrderWorkItemTasksGridControl.PrintReport = false;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.Screen = null;
            this.fld_dgcSaleOrderWorkItemTasksGridControl.Size = new System.Drawing.Size(916, 491);
            this.fld_dgcSaleOrderWorkItemTasksGridControl.TabIndex = 0;
            // 
            // guiSaleOrderWorkItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(945, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_tabTemplateItem);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiSaleOrderWorkItemComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách thành phần";
            this.Load += new System.EventHandler(this.guiProductWorkItemComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_tabTemplateItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).EndInit();
            this.fld_tabTemplateItem.ResumeLayout(false);
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderWorkItemComponentsGridControl)).EndInit();
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderWorkItemTasksGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSTabControl fld_tabTemplateItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private ARSaleOrderItemWorkMaterialsGridControl fld_dgcARSaleOrderWorkItemComponentsGridControl;
        private ARSaleOrderItemWorkTasksGridControl fld_dgcSaleOrderWorkItemTasksGridControl;
    }
}