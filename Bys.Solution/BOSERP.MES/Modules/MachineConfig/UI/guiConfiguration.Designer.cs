namespace BOSERP.Modules.MachineConfig.UI
{
    partial class guiConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiConfiguration));
            this.fld_trlSections = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.fld_pnlScreenContainer = new BOSComponent.BOSPanel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlSections)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_trlSections
            // 
            this.fld_trlSections.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.fld_trlSections.Dock = System.Windows.Forms.DockStyle.Left;
            this.fld_trlSections.Location = new System.Drawing.Point(0, 0);
            this.fld_trlSections.Name = "fld_trlSections";
            this.fld_trlSections.OptionsBehavior.Editable = false;
            this.fld_trlSections.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlSections.OptionsView.ShowColumns = false;
            this.fld_trlSections.OptionsView.ShowIndicator = false;
            this.fld_trlSections.Size = new System.Drawing.Size(149, 641);
            this.fld_trlSections.TabIndex = 0;
            this.fld_trlSections.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.fld_trlSections_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 93;
            // 
            // fld_pnlScreenContainer
            // 
            this.fld_pnlScreenContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlScreenContainer.BOSComment = null;
            this.fld_pnlScreenContainer.BOSDataMember = null;
            this.fld_pnlScreenContainer.BOSDataSource = null;
            this.fld_pnlScreenContainer.BOSDescription = null;
            this.fld_pnlScreenContainer.BOSError = null;
            this.fld_pnlScreenContainer.BOSFieldGroup = null;
            this.fld_pnlScreenContainer.BOSFieldRelation = null;
            this.fld_pnlScreenContainer.BOSPrivilege = null;
            this.fld_pnlScreenContainer.BOSPropertyName = null;
            this.fld_pnlScreenContainer.Location = new System.Drawing.Point(148, 2);
            this.fld_pnlScreenContainer.Name = "fld_pnlScreenContainer";
            this.fld_pnlScreenContainer.Screen = null;
            this.fld_pnlScreenContainer.Size = new System.Drawing.Size(842, 636);
            this.fld_pnlScreenContainer.TabIndex = 2;
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_trlSections);
            this.bosPanel1.Controls.Add(this.fld_pnlScreenContainer);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(991, 641);
            this.bosPanel1.TabIndex = 6;
            // 
            // guiConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 641);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiConfiguration";
            this.ShowInTaskbar = false;
            this.Text = "Cấu hình nguồn lực sản xuất";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlSections)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList fld_trlSections;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private BOSComponent.BOSPanel fld_pnlScreenContainer;
        private BOSComponent.BOSPanel bosPanel1;
    }
}