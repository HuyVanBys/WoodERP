namespace BOSERP.Modules.Product
{
    partial class guiProductItemWorkComponent
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
            this.fld_btnAddProductWorkItem = new BOSComponent.BOSButton(this.components);
            this.fld_tabTemplateItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTaskByProductItemWorkGridControl = new BOSERP.Modules.Product.ICProductTaskByProductItemWorkGridControl();
            this.fld_btnAddTask = new BOSComponent.BOSButton(this.components);
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).BeginInit();
            this.fld_tabTemplateItem.SuspendLayout();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTaskByProductItemWorkGridControl)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
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
            // fld_btnAddProductWorkItem
            // 
            this.fld_btnAddProductWorkItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWorkItem.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWorkItem.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddProductWorkItem.BOSDataMember = null;
            this.fld_btnAddProductWorkItem.BOSDataSource = null;
            this.fld_btnAddProductWorkItem.BOSDescription = null;
            this.fld_btnAddProductWorkItem.BOSError = null;
            this.fld_btnAddProductWorkItem.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddProductWorkItem.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddProductWorkItem.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddProductWorkItem.BOSPropertyName = null;
            this.fld_btnAddProductWorkItem.Location = new System.Drawing.Point(3, 3);
            this.fld_btnAddProductWorkItem.Name = "fld_btnAddProductWorkItem";
            this.fld_btnAddProductWorkItem.Screen = null;
            this.fld_btnAddProductWorkItem.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProductWorkItem.TabIndex = 130;
            this.fld_btnAddProductWorkItem.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddProductWorkItem.Text = "Thêm vật tư";
            this.fld_btnAddProductWorkItem.Click += new System.EventHandler(this.fld_btnAddProductWorkItem_Click);
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
            this.fld_tabTemplateItem.SelectedTabPage = this.fld_tabTask;
            this.fld_tabTemplateItem.Size = new System.Drawing.Size(929, 526);
            this.fld_tabTemplateItem.TabIndex = 132;
            this.fld_tabTemplateItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabTask,
            this.fld_tabMaterial});
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcICProductTaskByProductItemWorkGridControl);
            this.fld_tabTask.Controls.Add(this.fld_btnAddTask);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(922, 497);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_dgcICProductTaskByProductItemWorkGridControl
            // 
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSComment = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSDataMember = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSDataSource = "ICProductTasks";
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSDescription = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSError = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSGridType = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSPrivilege = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.BOSPropertyName = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductTaskByProductItemWorkGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.Name = "fld_dgcICProductTaskByProductItemWorkGridControl";
            this.fld_dgcICProductTaskByProductItemWorkGridControl.PrintReport = false;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.Screen = null;
            this.fld_dgcICProductTaskByProductItemWorkGridControl.Size = new System.Drawing.Size(923, 461);
            this.fld_dgcICProductTaskByProductItemWorkGridControl.TabIndex = 133;
            // 
            // fld_btnAddTask
            // 
            this.fld_btnAddTask.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddTask.Appearance.Options.UseForeColor = true;
            this.fld_btnAddTask.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddTask.BOSDataMember = null;
            this.fld_btnAddTask.BOSDataSource = null;
            this.fld_btnAddTask.BOSDescription = null;
            this.fld_btnAddTask.BOSError = null;
            this.fld_btnAddTask.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddTask.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddTask.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddTask.BOSPropertyName = null;
            this.fld_btnAddTask.Location = new System.Drawing.Point(3, 3);
            this.fld_btnAddTask.Name = "fld_btnAddTask";
            this.fld_btnAddTask.Screen = null;
            this.fld_btnAddTask.Size = new System.Drawing.Size(91, 27);
            this.fld_btnAddTask.TabIndex = 132;
            this.fld_btnAddTask.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_btnAddTask.Text = "Thêm task";
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_btnAddProductWorkItem);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(922, 497);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // guiProductItemWorkComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(945, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_tabTemplateItem);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiProductItemWorkComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách task, vật tư, máy móc thiết bị";
            this.Load += new System.EventHandler(this.guiAddWork_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_tabTemplateItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabTemplateItem)).EndInit();
            this.fld_tabTemplateItem.ResumeLayout(false);
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTaskByProductItemWorkGridControl)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnAddProductWorkItem;
        private BOSComponent.BOSTabControl fld_tabTemplateItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private BOSComponent.BOSButton fld_btnAddTask;
        private ICProductTaskByProductItemWorkGridControl fld_dgcICProductTaskByProductItemWorkGridControl;
    }
}