namespace BOSERP.Modules.Product
{
    partial class guiProductWorkItemComponent
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
            this.fld_dgcProductWorkItemComponentsGridControl = new BOSERP.Modules.Product.ProductWorkItemMaterialsGridControl();
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcProductWorkItemTasksGridControl = new BOSERP.Modules.Product.ProductWorkItemTasksGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).BeginInit();
            this.fld_tabTemplateItem.SuspendLayout();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkItemComponentsGridControl)).BeginInit();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkItemTasksGridControl)).BeginInit();
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
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_tabTemplateItem.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_tabMaterial.Controls.Add(this.fld_dgcProductWorkItemComponentsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(922, 497);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_dgcProductWorkItemComponentsGridControl
            // 
            this.fld_dgcProductWorkItemComponentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductWorkItemComponentsGridControl.BOSComment = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSDataMember = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcProductWorkItemComponentsGridControl.BOSDescription = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSError = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSFieldGroup = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSFieldRelation = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSGridType = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSPrivilege = null;
            this.fld_dgcProductWorkItemComponentsGridControl.BOSPropertyName = null;
            this.fld_dgcProductWorkItemComponentsGridControl.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcProductWorkItemComponentsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductWorkItemComponentsGridControl.Name = "fld_dgcProductWorkItemComponentsGridControl";
            this.fld_dgcProductWorkItemComponentsGridControl.PrintReport = false;
            this.fld_dgcProductWorkItemComponentsGridControl.Screen = null;
            this.fld_dgcProductWorkItemComponentsGridControl.Size = new System.Drawing.Size(913, 491);
            this.fld_dgcProductWorkItemComponentsGridControl.TabIndex = 0;
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcProductWorkItemTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(922, 497);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_dgcProductWorkItemTasksGridControl
            // 
            this.fld_dgcProductWorkItemTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductWorkItemTasksGridControl.BOSComment = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSDataMember = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSDataSource = "ICProductTasks";
            this.fld_dgcProductWorkItemTasksGridControl.BOSDescription = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSError = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSGridType = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSPrivilege = null;
            this.fld_dgcProductWorkItemTasksGridControl.BOSPropertyName = null;
            this.fld_dgcProductWorkItemTasksGridControl.Location = new System.Drawing.Point(6, 3);
            this.fld_dgcProductWorkItemTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductWorkItemTasksGridControl.Name = "fld_dgcProductWorkItemTasksGridControl";
            this.fld_dgcProductWorkItemTasksGridControl.PrintReport = false;
            this.fld_dgcProductWorkItemTasksGridControl.Screen = null;
            this.fld_dgcProductWorkItemTasksGridControl.Size = new System.Drawing.Size(913, 491);
            this.fld_dgcProductWorkItemTasksGridControl.TabIndex = 0;
            // 
            // guiProductWorkItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(945, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_tabTemplateItem);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiProductWorkItemComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách thành phần";
            this.Load += new System.EventHandler(this.guiProductWorkItemComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_tabTemplateItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).EndInit();
            this.fld_tabTemplateItem.ResumeLayout(false);
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkItemComponentsGridControl)).EndInit();
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductWorkItemTasksGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSTabControl fld_tabTemplateItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private ProductWorkItemMaterialsGridControl fld_dgcProductWorkItemComponentsGridControl;
        private ProductWorkItemTasksGridControl fld_dgcProductWorkItemTasksGridControl;
    }
}