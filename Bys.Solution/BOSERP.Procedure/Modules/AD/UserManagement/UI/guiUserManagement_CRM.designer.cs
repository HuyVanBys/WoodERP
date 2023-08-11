namespace BOSERP.Modules.UserManagement
{
    partial class guiUserManagement_CRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiUserManagement_CRM));
            this.fld_imglUserGroup_CRM = new System.Windows.Forms.ImageList(this.components);
            this.fld_trlstUserGroup_CRM = new DevExpress.XtraTreeList.TreeList();
            this.fld_tlcUserGroupName_CRM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_tabScreenContainer = new BOSComponent.BOSTabControl(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnConfigureToolbar = new BOSComponent.BOSButton(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_CRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_imglUserGroup_CRM
            // 
            this.fld_imglUserGroup_CRM.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fld_imglUserGroup_CRM.ImageStream")));
            this.fld_imglUserGroup_CRM.TransparentColor = System.Drawing.Color.Transparent;
            this.fld_imglUserGroup_CRM.Images.SetKeyName(0, "BOS");
            // 
            // fld_trlstUserGroup_CRM
            // 
            this.fld_trlstUserGroup_CRM.AllowDrop = true;
            this.fld_trlstUserGroup_CRM.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.fld_tlcUserGroupName_CRM});
            this.fld_trlstUserGroup_CRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlstUserGroup_CRM.Location = new System.Drawing.Point(2, 20);
            this.fld_trlstUserGroup_CRM.Name = "fld_trlstUserGroup_CRM";
            this.fld_trlstUserGroup_CRM.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlstUserGroup_CRM.OptionsView.ShowColumns = false;
            this.fld_trlstUserGroup_CRM.OptionsView.ShowIndicator = false;
            this.fld_trlstUserGroup_CRM.Size = new System.Drawing.Size(296, 625);
            this.fld_trlstUserGroup_CRM.TabIndex = 7;
            this.fld_trlstUserGroup_CRM.DragDrop += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_CRM_DragDrop);
            this.fld_trlstUserGroup_CRM.DragOver += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_CRM_DragOver);
            this.fld_trlstUserGroup_CRM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_CRM_MouseClick);
            this.fld_trlstUserGroup_CRM.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_CRM_MouseDoubleClick);
            this.fld_trlstUserGroup_CRM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_CRM_MouseDown);
            this.fld_trlstUserGroup_CRM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_CRM_MouseMove);
            // 
            // fld_tlcUserGroupName_CRM
            // 
            this.fld_tlcUserGroupName_CRM.Caption = "User Group CRM";
            this.fld_tlcUserGroupName_CRM.FieldName = "UserGroup_CRM";
            this.fld_tlcUserGroupName_CRM.Name = "fld_tlcUserGroupName_CRM";
            this.fld_tlcUserGroupName_CRM.OptionsColumn.AllowEdit = false;
            this.fld_tlcUserGroupName_CRM.OptionsColumn.ReadOnly = true;
            this.fld_tlcUserGroupName_CRM.Visible = true;
            this.fld_tlcUserGroupName_CRM.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.fld_trlstUserGroup_CRM);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 647);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Nhóm người dùng - CRM";
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
            this.bosPanel1.Controls.Add(this.groupControl1);
            this.bosPanel1.Controls.Add(this.splitterControl1);
            this.bosPanel1.Controls.Add(this.groupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1085, 647);
            this.bosPanel1.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_tabScreenContainer);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(305, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 647);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Phân quyền";
            // 
            // fld_tabScreenContainer
            // 
            this.fld_tabScreenContainer.BOSComment = null;
            this.fld_tabScreenContainer.BOSDataMember = null;
            this.fld_tabScreenContainer.BOSDataSource = null;
            this.fld_tabScreenContainer.BOSDescription = null;
            this.fld_tabScreenContainer.BOSError = null;
            this.fld_tabScreenContainer.BOSFieldGroup = null;
            this.fld_tabScreenContainer.BOSFieldRelation = null;
            this.fld_tabScreenContainer.BOSPrivilege = null;
            this.fld_tabScreenContainer.BOSPropertyName = null;
            this.fld_tabScreenContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabScreenContainer.Location = new System.Drawing.Point(2, 20);
            this.fld_tabScreenContainer.Name = "fld_tabScreenContainer";
            this.fld_tabScreenContainer.Screen = null;
            this.fld_tabScreenContainer.Size = new System.Drawing.Size(776, 577);
            this.fld_tabScreenContainer.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_btnConfigureToolbar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 597);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(776, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_btnConfigureToolbar
            // 
            this.fld_btnConfigureToolbar.BOSComment = null;
            this.fld_btnConfigureToolbar.BOSDataMember = null;
            this.fld_btnConfigureToolbar.BOSDataSource = null;
            this.fld_btnConfigureToolbar.BOSDescription = null;
            this.fld_btnConfigureToolbar.BOSError = null;
            this.fld_btnConfigureToolbar.BOSFieldGroup = null;
            this.fld_btnConfigureToolbar.BOSFieldRelation = null;
            this.fld_btnConfigureToolbar.BOSPrivilege = null;
            this.fld_btnConfigureToolbar.BOSPropertyName = null;
            this.fld_btnConfigureToolbar.Location = new System.Drawing.Point(5, 8);
            this.fld_btnConfigureToolbar.Name = "fld_btnConfigureToolbar";
            this.fld_btnConfigureToolbar.Screen = null;
            this.fld_btnConfigureToolbar.Size = new System.Drawing.Size(133, 30);
            this.fld_btnConfigureToolbar.TabIndex = 0;
            this.fld_btnConfigureToolbar.Text = "Cấu hình thanh công cụ";
            this.fld_btnConfigureToolbar.Click += new System.EventHandler(this.fld_btnConfigureToolbar_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(300, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 647);
            this.splitterControl1.TabIndex = 14;
            this.splitterControl1.TabStop = false;
            // 
            // guiUserManagement_CRM
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 647);
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Name = "guiUserManagement_CRM";
            this.Text = "Danh sách nhóm người dùng - CRM";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_CRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList fld_imglUserGroup_CRM;
        public DevExpress.XtraTreeList.TreeList fld_trlstUserGroup_CRM;
        public DevExpress.XtraTreeList.Columns.TreeListColumn fld_tlcUserGroupName_CRM;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BOSComponent.BOSTabControl fld_tabScreenContainer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnConfigureToolbar;
    }
}