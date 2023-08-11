namespace BOSERP.Modules.Project
{
    partial class guiProjectNormItem<T>
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
            this.fld_dgcProjectNormItemMaterialsGridControl = new BOSERP.Modules.Project.ProjectNormItemsGridControl();
            this.fld_btnAddProjectNormItemMaterial = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddProjectNormItemAsset = new BOSComponent.BOSButton(this.components);
            this.fld_tabProjectNorm = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddTask = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPMTasksGridControl = new BOSERP.Modules.Project.PMTasksGridControl();
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcProjectNormItemAssetsGridControl = new BOSERP.Modules.Project.ProjectNormItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemMaterialsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectNorm)).BeginInit();
            this.fld_tabProjectNorm.SuspendLayout();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
            this.fld_tabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemAssetsGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(843, 544);
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
            this.fld_btnApply.Location = new System.Drawing.Point(754, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcProjectNormItemMaterialsGridControl
            // 
            this.fld_dgcProjectNormItemMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSComment = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDataSource = "PMProjectNormItems";
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSDescription = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSError = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSGridType = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcProjectNormItemMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectNormItemMaterialsGridControl.Name = "fld_dgcProjectNormItemMaterialsGridControl";
            this.fld_dgcProjectNormItemMaterialsGridControl.PrintReport = false;
            this.fld_dgcProjectNormItemMaterialsGridControl.Screen = null;
            this.fld_dgcProjectNormItemMaterialsGridControl.Size = new System.Drawing.Size(914, 458);
            this.fld_dgcProjectNormItemMaterialsGridControl.TabIndex = 129;
            this.fld_dgcProjectNormItemMaterialsGridControl.Tag = string.Empty;
            this.fld_dgcProjectNormItemMaterialsGridControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_dgcProjectNormItemsGridControl_KeyUp);
            // 
            // fld_btnAddProjectNormItemMaterial
            // 
            this.fld_btnAddProjectNormItemMaterial.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProjectNormItemMaterial.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProjectNormItemMaterial.BOSComment = string.Empty;
            this.fld_btnAddProjectNormItemMaterial.BOSDataMember = null;
            this.fld_btnAddProjectNormItemMaterial.BOSDataSource = null;
            this.fld_btnAddProjectNormItemMaterial.BOSDescription = null;
            this.fld_btnAddProjectNormItemMaterial.BOSError = null;
            this.fld_btnAddProjectNormItemMaterial.BOSFieldGroup = string.Empty;
            this.fld_btnAddProjectNormItemMaterial.BOSFieldRelation = string.Empty;
            this.fld_btnAddProjectNormItemMaterial.BOSPrivilege = string.Empty;
            this.fld_btnAddProjectNormItemMaterial.BOSPropertyName = null;
            this.fld_btnAddProjectNormItemMaterial.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddProjectNormItemMaterial.Name = "fld_btnAddProjectNormItemMaterial";
            this.fld_btnAddProjectNormItemMaterial.Screen = null;
            this.fld_btnAddProjectNormItemMaterial.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddProjectNormItemMaterial.TabIndex = 130;
            this.fld_btnAddProjectNormItemMaterial.Tag = string.Empty;
            this.fld_btnAddProjectNormItemMaterial.Text = "Thêm vật tư";
            this.fld_btnAddProjectNormItemMaterial.Click += new System.EventHandler(this.fld_btnAddProjectNormItemMaterial_Click);
            // 
            // fld_btnAddProjectNormItemAsset
            // 
            this.fld_btnAddProjectNormItemAsset.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProjectNormItemAsset.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProjectNormItemAsset.BOSComment = string.Empty;
            this.fld_btnAddProjectNormItemAsset.BOSDataMember = null;
            this.fld_btnAddProjectNormItemAsset.BOSDataSource = null;
            this.fld_btnAddProjectNormItemAsset.BOSDescription = null;
            this.fld_btnAddProjectNormItemAsset.BOSError = null;
            this.fld_btnAddProjectNormItemAsset.BOSFieldGroup = string.Empty;
            this.fld_btnAddProjectNormItemAsset.BOSFieldRelation = string.Empty;
            this.fld_btnAddProjectNormItemAsset.BOSPrivilege = string.Empty;
            this.fld_btnAddProjectNormItemAsset.BOSPropertyName = null;
            this.fld_btnAddProjectNormItemAsset.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddProjectNormItemAsset.Name = "fld_btnAddProjectNormItemAsset";
            this.fld_btnAddProjectNormItemAsset.Screen = null;
            this.fld_btnAddProjectNormItemAsset.Size = new System.Drawing.Size(139, 27);
            this.fld_btnAddProjectNormItemAsset.TabIndex = 131;
            this.fld_btnAddProjectNormItemAsset.Tag = string.Empty;
            this.fld_btnAddProjectNormItemAsset.Text = "Thêm máy móc, thiết bị";
            this.fld_btnAddProjectNormItemAsset.Click += new System.EventHandler(this.fld_btnAddProjectNormItemAsset_Click);
            // 
            // fld_tabProjectNorm
            // 
            this.fld_tabProjectNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProjectNorm.BOSComment = null;
            this.fld_tabProjectNorm.BOSDataMember = null;
            this.fld_tabProjectNorm.BOSDataSource = string.Empty;
            this.fld_tabProjectNorm.BOSDescription = null;
            this.fld_tabProjectNorm.BOSError = null;
            this.fld_tabProjectNorm.BOSFieldGroup = null;
            this.fld_tabProjectNorm.BOSFieldRelation = null;
            this.fld_tabProjectNorm.BOSPrivilege = null;
            this.fld_tabProjectNorm.BOSPropertyName = null;
            this.fld_tabProjectNorm.Location = new System.Drawing.Point(5, 12);
            this.fld_tabProjectNorm.Name = "fld_tabProjectNorm";
            this.fld_tabProjectNorm.Screen = null;
            this.fld_tabProjectNorm.SelectedTabPage = this.fld_tabTask;
            this.fld_tabProjectNorm.Size = new System.Drawing.Size(929, 526);
            this.fld_tabProjectNorm.TabIndex = 133;
            this.fld_tabProjectNorm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabTask,
            this.fld_tabMaterial,
            this.fld_tabAsset});
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_btnAddTask);
            this.fld_tabTask.Controls.Add(this.fld_dgcPMTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(922, 497);
            this.fld_tabTask.Text = "Danh sách task";
            // 
            // fld_btnAddTask
            // 
            this.fld_btnAddTask.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddTask.Appearance.Options.UseForeColor = true;
            this.fld_btnAddTask.BOSComment = string.Empty;
            this.fld_btnAddTask.BOSDataMember = null;
            this.fld_btnAddTask.BOSDataSource = null;
            this.fld_btnAddTask.BOSDescription = null;
            this.fld_btnAddTask.BOSError = null;
            this.fld_btnAddTask.BOSFieldGroup = string.Empty;
            this.fld_btnAddTask.BOSFieldRelation = string.Empty;
            this.fld_btnAddTask.BOSPrivilege = string.Empty;
            this.fld_btnAddTask.BOSPropertyName = null;
            this.fld_btnAddTask.Location = new System.Drawing.Point(5, 3);
            this.fld_btnAddTask.Name = "fld_btnAddTask";
            this.fld_btnAddTask.Screen = null;
            this.fld_btnAddTask.Size = new System.Drawing.Size(103, 27);
            this.fld_btnAddTask.TabIndex = 134;
            this.fld_btnAddTask.Tag = string.Empty;
            this.fld_btnAddTask.Text = "Thêm task";
            this.fld_btnAddTask.Click += new System.EventHandler(this.fld_btnAddTask_Click);
            // 
            // fld_dgcPMTasksGridControl
            // 
            this.fld_dgcPMTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMTasksGridControl.BOSComment = null;
            this.fld_dgcPMTasksGridControl.BOSDataMember = null;
            this.fld_dgcPMTasksGridControl.BOSDataSource = "PMTasks";
            this.fld_dgcPMTasksGridControl.BOSDescription = null;
            this.fld_dgcPMTasksGridControl.BOSError = null;
            this.fld_dgcPMTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcPMTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcPMTasksGridControl.BOSGridType = null;
            this.fld_dgcPMTasksGridControl.BOSPrivilege = null;
            this.fld_dgcPMTasksGridControl.BOSPropertyName = null;
            this.fld_dgcPMTasksGridControl.Location = new System.Drawing.Point(5, 36);
            this.fld_dgcPMTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMTasksGridControl.Name = "fld_dgcPMTasksGridControl";
            this.fld_dgcPMTasksGridControl.PrintReport = false;
            this.fld_dgcPMTasksGridControl.Screen = null;
            this.fld_dgcPMTasksGridControl.Size = new System.Drawing.Size(914, 458);
            this.fld_dgcPMTasksGridControl.TabIndex = 133;
            this.fld_dgcPMTasksGridControl.Tag = string.Empty;
            this.fld_dgcPMTasksGridControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_dgcPMTasksGridControl_KeyUp);
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_btnAddProjectNormItemMaterial);
            this.fld_tabMaterial.Controls.Add(this.fld_dgcProjectNormItemMaterialsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(922, 497);
            this.fld_tabMaterial.Text = "Danh sách vật tư";
            // 
            // fld_tabAsset
            // 
            this.fld_tabAsset.Controls.Add(this.fld_dgcProjectNormItemAssetsGridControl);
            this.fld_tabAsset.Controls.Add(this.fld_btnAddProjectNormItemAsset);
            this.fld_tabAsset.Name = "fld_tabAsset";
            this.fld_tabAsset.Size = new System.Drawing.Size(922, 497);
            this.fld_tabAsset.Text = "Danh sách MM, CCDC";
            // 
            // fld_dgcProjectNormItemAssetsGridControl
            // 
            this.fld_dgcProjectNormItemAssetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProjectNormItemAssetsGridControl.BOSComment = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDataMember = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDataSource = "PMProjectNormItems";
            this.fld_dgcProjectNormItemAssetsGridControl.BOSDescription = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSError = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSGridType = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcProjectNormItemAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcProjectNormItemAssetsGridControl.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcProjectNormItemAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProjectNormItemAssetsGridControl.Name = "fld_dgcProjectNormItemAssetsGridControl";
            this.fld_dgcProjectNormItemAssetsGridControl.PrintReport = false;
            this.fld_dgcProjectNormItemAssetsGridControl.Screen = null;
            this.fld_dgcProjectNormItemAssetsGridControl.Size = new System.Drawing.Size(914, 458);
            this.fld_dgcProjectNormItemAssetsGridControl.TabIndex = 132;
            this.fld_dgcProjectNormItemAssetsGridControl.Tag = string.Empty;
            this.fld_dgcProjectNormItemAssetsGridControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_dgcProjectNormItemAssetsGridControl_KeyUp);
            // 
            // guiProjectNormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_tabProjectNorm);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiProjectNormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách task, vật tư, máy móc thiết bị";
            this.Load += new System.EventHandler(this.guiProjectNormItem_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_tabProjectNorm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemMaterialsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProjectNorm)).EndInit();
            this.fld_tabProjectNorm.ResumeLayout(false);
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMTasksGridControl)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            this.fld_tabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProjectNormItemAssetsGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ProjectNormItemsGridControl fld_dgcProjectNormItemMaterialsGridControl;
        private BOSComponent.BOSButton fld_btnAddProjectNormItemMaterial;
        private BOSComponent.BOSButton fld_btnAddProjectNormItemAsset;
        private BOSComponent.BOSTabControl fld_tabProjectNorm;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tabAsset;
        private ProjectNormItemsGridControl fld_dgcProjectNormItemAssetsGridControl;
        private BOSComponent.BOSButton fld_btnAddTask;
        private PMTasksGridControl fld_dgcPMTasksGridControl;
    }
}