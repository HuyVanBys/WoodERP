namespace BOSERP.Modules.UserManagement
{
    partial class guiUserManagement_AppStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiUserManagement_AppStaff));
            this.fld_imglUserGroup = new System.Windows.Forms.ImageList(this.components);
            this.fld_trlstUserGroup_AppStaff = new DevExpress.XtraTreeList.TreeList();
            this.fld_tlcUserGroupName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_lblTitleAppStaff = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcADDataViewPermissionAppStaffs = new BOSERP.Modules.UserManagement.ADDataViewPermissionAppStaffsGridControl();
            this.fld_tabScreenContainer = new BOSComponent.BOSTabControl(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADDataViewPermissions = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADReportViewPermissions = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.adDataViewPermissionsGridControl1 = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.adDataViewPermissionsGridControl2 = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_AppStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDataViewPermissionAppStaffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDataViewPermissions)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewPermissions)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adDataViewPermissionsGridControl1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adDataViewPermissionsGridControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_imglUserGroup
            // 
            this.fld_imglUserGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fld_imglUserGroup.ImageStream")));
            this.fld_imglUserGroup.TransparentColor = System.Drawing.Color.Transparent;
            this.fld_imglUserGroup.Images.SetKeyName(0, "BOS");
            // 
            // fld_trlstUserGroup_AppStaff
            // 
            this.fld_trlstUserGroup_AppStaff.AllowDrop = true;
            this.fld_trlstUserGroup_AppStaff.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.fld_tlcUserGroupName});
            this.fld_trlstUserGroup_AppStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlstUserGroup_AppStaff.Location = new System.Drawing.Point(2, 20);
            this.fld_trlstUserGroup_AppStaff.Name = "fld_trlstUserGroup_AppStaff";
            this.fld_trlstUserGroup_AppStaff.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlstUserGroup_AppStaff.OptionsView.ShowColumns = false;
            this.fld_trlstUserGroup_AppStaff.OptionsView.ShowIndicator = false;
            this.fld_trlstUserGroup_AppStaff.Size = new System.Drawing.Size(296, 625);
            this.fld_trlstUserGroup_AppStaff.TabIndex = 7;
            this.fld_trlstUserGroup_AppStaff.DragDrop += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_DragDrop);
            this.fld_trlstUserGroup_AppStaff.DragOver += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_DragOver);
            this.fld_trlstUserGroup_AppStaff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseClick);
            this.fld_trlstUserGroup_AppStaff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseDoubleClick);
            this.fld_trlstUserGroup_AppStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseDown);
            this.fld_trlstUserGroup_AppStaff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseMove);
            // 
            // fld_tlcUserGroupName
            // 
            this.fld_tlcUserGroupName.Caption = "User Group";
            this.fld_tlcUserGroupName.FieldName = "UserGroup";
            this.fld_tlcUserGroupName.Name = "fld_tlcUserGroupName";
            this.fld_tlcUserGroupName.OptionsColumn.AllowEdit = false;
            this.fld_tlcUserGroupName.OptionsColumn.ReadOnly = true;
            this.fld_tlcUserGroupName.Visible = true;
            this.fld_tlcUserGroupName.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.fld_trlstUserGroup_AppStaff);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 647);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Nhóm người dùng";
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
            this.bosPanel1.Controls.Add(this.panel1);
            this.bosPanel1.Controls.Add(this.splitterControl1);
            this.bosPanel1.Controls.Add(this.groupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1085, 647);
            this.bosPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_lblTitleAppStaff);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 647);
            this.panel1.TabIndex = 15;
            // 
            // fld_lblTitleAppStaff
            // 
            this.fld_lblTitleAppStaff.AutoSize = true;
            this.fld_lblTitleAppStaff.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblTitleAppStaff.Location = new System.Drawing.Point(7, 4);
            this.fld_lblTitleAppStaff.Name = "fld_lblTitleAppStaff";
            this.fld_lblTitleAppStaff.Size = new System.Drawing.Size(110, 23);
            this.fld_lblTitleAppStaff.TabIndex = 17;
            this.fld_lblTitleAppStaff.Text = "Phân quyền";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.fld_dgcADDataViewPermissionAppStaffs);
            this.groupControl1.Controls.Add(this.fld_tabScreenContainer);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(777, 614);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Phân quyền";
            // 
            // fld_dgcADDataViewPermissionAppStaffs
            // 
            this.fld_dgcADDataViewPermissionAppStaffs.BOSComment = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSDataMember = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSDataSource = "ADDataViewPermissionAppStaffs";
            this.fld_dgcADDataViewPermissionAppStaffs.BOSDescription = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSError = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSFieldGroup = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSFieldRelation = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSGridType = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSPrivilege = null;
            this.fld_dgcADDataViewPermissionAppStaffs.BOSPropertyName = null;
            this.fld_dgcADDataViewPermissionAppStaffs.CommodityType = "";
            this.fld_dgcADDataViewPermissionAppStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcADDataViewPermissionAppStaffs.GridViewMain = null;
            this.fld_dgcADDataViewPermissionAppStaffs.Location = new System.Drawing.Point(2, 20);
            this.fld_dgcADDataViewPermissionAppStaffs.MenuManager = this.screenToolbar;
            this.fld_dgcADDataViewPermissionAppStaffs.Name = "fld_dgcADDataViewPermissionAppStaffs";
            this.fld_dgcADDataViewPermissionAppStaffs.PrintReport = false;
            this.fld_dgcADDataViewPermissionAppStaffs.Screen = null;
            this.fld_dgcADDataViewPermissionAppStaffs.Size = new System.Drawing.Size(773, 544);
            this.fld_dgcADDataViewPermissionAppStaffs.TabIndex = 9;
            this.fld_dgcADDataViewPermissionAppStaffs.Tag = "Module";
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
            this.fld_tabScreenContainer.Size = new System.Drawing.Size(773, 544);
            this.fld_tabScreenContainer.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 564);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(695, 13);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(70, 30);
            this.fld_btnSave.TabIndex = 0;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(300, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 647);
            this.splitterControl1.TabIndex = 14;
            this.splitterControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcADDataViewPermissions);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(521, 466);
            this.xtraTabPage1.Text = "Màn hình";
            // 
            // fld_dgcADDataViewPermissions
            // 
            this.fld_dgcADDataViewPermissions.BOSComment = null;
            this.fld_dgcADDataViewPermissions.BOSDataMember = null;
            this.fld_dgcADDataViewPermissions.BOSDataSource = "ADDataViewPermissions";
            this.fld_dgcADDataViewPermissions.BOSDescription = null;
            this.fld_dgcADDataViewPermissions.BOSError = null;
            this.fld_dgcADDataViewPermissions.BOSFieldGroup = null;
            this.fld_dgcADDataViewPermissions.BOSFieldRelation = null;
            this.fld_dgcADDataViewPermissions.BOSGridType = null;
            this.fld_dgcADDataViewPermissions.BOSPrivilege = null;
            this.fld_dgcADDataViewPermissions.BOSPropertyName = null;
            this.fld_dgcADDataViewPermissions.CommodityType = "";
            this.fld_dgcADDataViewPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcADDataViewPermissions.GridViewMain = null;
            this.fld_dgcADDataViewPermissions.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcADDataViewPermissions.MenuManager = this.screenToolbar;
            this.fld_dgcADDataViewPermissions.Name = "fld_dgcADDataViewPermissions";
            this.fld_dgcADDataViewPermissions.PrintReport = false;
            this.fld_dgcADDataViewPermissions.Screen = null;
            this.fld_dgcADDataViewPermissions.Size = new System.Drawing.Size(521, 466);
            this.fld_dgcADDataViewPermissions.TabIndex = 8;
            this.fld_dgcADDataViewPermissions.Tag = "Module";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcADReportViewPermissions);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(521, 466);
            this.xtraTabPage2.Text = "Báo cáo";
            // 
            // fld_dgcADReportViewPermissions
            // 
            this.fld_dgcADReportViewPermissions.BOSComment = null;
            this.fld_dgcADReportViewPermissions.BOSDataMember = null;
            this.fld_dgcADReportViewPermissions.BOSDataSource = "ADDataViewPermissions";
            this.fld_dgcADReportViewPermissions.BOSDescription = null;
            this.fld_dgcADReportViewPermissions.BOSError = null;
            this.fld_dgcADReportViewPermissions.BOSFieldGroup = null;
            this.fld_dgcADReportViewPermissions.BOSFieldRelation = null;
            this.fld_dgcADReportViewPermissions.BOSGridType = null;
            this.fld_dgcADReportViewPermissions.BOSPrivilege = null;
            this.fld_dgcADReportViewPermissions.BOSPropertyName = null;
            this.fld_dgcADReportViewPermissions.CommodityType = "";
            this.fld_dgcADReportViewPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcADReportViewPermissions.GridViewMain = null;
            this.fld_dgcADReportViewPermissions.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcADReportViewPermissions.MenuManager = this.screenToolbar;
            this.fld_dgcADReportViewPermissions.Name = "fld_dgcADReportViewPermissions";
            this.fld_dgcADReportViewPermissions.PrintReport = false;
            this.fld_dgcADReportViewPermissions.Screen = null;
            this.fld_dgcADReportViewPermissions.Size = new System.Drawing.Size(521, 466);
            this.fld_dgcADReportViewPermissions.TabIndex = 9;
            this.fld_dgcADReportViewPermissions.Tag = "Report";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.adDataViewPermissionsGridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(521, 466);
            this.xtraTabPage3.Text = "Màn hình";
            // 
            // adDataViewPermissionsGridControl1
            // 
            this.adDataViewPermissionsGridControl1.BOSComment = null;
            this.adDataViewPermissionsGridControl1.BOSDataMember = null;
            this.adDataViewPermissionsGridControl1.BOSDataSource = "ADDataViewPermissions";
            this.adDataViewPermissionsGridControl1.BOSDescription = null;
            this.adDataViewPermissionsGridControl1.BOSError = null;
            this.adDataViewPermissionsGridControl1.BOSFieldGroup = null;
            this.adDataViewPermissionsGridControl1.BOSFieldRelation = null;
            this.adDataViewPermissionsGridControl1.BOSGridType = null;
            this.adDataViewPermissionsGridControl1.BOSPrivilege = null;
            this.adDataViewPermissionsGridControl1.BOSPropertyName = null;
            this.adDataViewPermissionsGridControl1.CommodityType = "";
            this.adDataViewPermissionsGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adDataViewPermissionsGridControl1.GridViewMain = null;
            this.adDataViewPermissionsGridControl1.Location = new System.Drawing.Point(0, 0);
            this.adDataViewPermissionsGridControl1.MenuManager = this.screenToolbar;
            this.adDataViewPermissionsGridControl1.Name = "adDataViewPermissionsGridControl1";
            this.adDataViewPermissionsGridControl1.PrintReport = false;
            this.adDataViewPermissionsGridControl1.Screen = null;
            this.adDataViewPermissionsGridControl1.Size = new System.Drawing.Size(521, 466);
            this.adDataViewPermissionsGridControl1.TabIndex = 8;
            this.adDataViewPermissionsGridControl1.Tag = "Module";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.adDataViewPermissionsGridControl2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(521, 466);
            this.xtraTabPage4.Text = "Báo cáo";
            // 
            // adDataViewPermissionsGridControl2
            // 
            this.adDataViewPermissionsGridControl2.BOSComment = null;
            this.adDataViewPermissionsGridControl2.BOSDataMember = null;
            this.adDataViewPermissionsGridControl2.BOSDataSource = "ADDataViewPermissions";
            this.adDataViewPermissionsGridControl2.BOSDescription = null;
            this.adDataViewPermissionsGridControl2.BOSError = null;
            this.adDataViewPermissionsGridControl2.BOSFieldGroup = null;
            this.adDataViewPermissionsGridControl2.BOSFieldRelation = null;
            this.adDataViewPermissionsGridControl2.BOSGridType = null;
            this.adDataViewPermissionsGridControl2.BOSPrivilege = null;
            this.adDataViewPermissionsGridControl2.BOSPropertyName = null;
            this.adDataViewPermissionsGridControl2.CommodityType = "";
            this.adDataViewPermissionsGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adDataViewPermissionsGridControl2.GridViewMain = null;
            this.adDataViewPermissionsGridControl2.Location = new System.Drawing.Point(0, 0);
            this.adDataViewPermissionsGridControl2.MenuManager = this.screenToolbar;
            this.adDataViewPermissionsGridControl2.Name = "adDataViewPermissionsGridControl2";
            this.adDataViewPermissionsGridControl2.PrintReport = false;
            this.adDataViewPermissionsGridControl2.Screen = null;
            this.adDataViewPermissionsGridControl2.Size = new System.Drawing.Size(521, 466);
            this.adDataViewPermissionsGridControl2.TabIndex = 9;
            this.adDataViewPermissionsGridControl2.Tag = "Report";
            // 
            // guiUserManagement_AppStaff
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 647);
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Name = "guiUserManagement_AppStaff";
            this.Text = "Phân quyền App Staff";
            this.Load += new System.EventHandler(this.guiUserManagement_AppStaff_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_AppStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDataViewPermissionAppStaffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADDataViewPermissions)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADReportViewPermissions)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adDataViewPermissionsGridControl1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adDataViewPermissionsGridControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList fld_imglUserGroup;
        public DevExpress.XtraTreeList.TreeList fld_trlstUserGroup_AppStaff;
        public DevExpress.XtraTreeList.Columns.TreeListColumn fld_tlcUserGroupName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ADDataViewPermissionsGridControl fld_dgcADDataViewPermissions;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ADDataViewPermissionsGridControl fld_dgcADReportViewPermissions;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ADDataViewPermissionsGridControl adDataViewPermissionsGridControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private ADDataViewPermissionsGridControl adDataViewPermissionsGridControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fld_lblTitleAppStaff;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ADDataViewPermissionAppStaffsGridControl fld_dgcADDataViewPermissionAppStaffs;
        private BOSComponent.BOSTabControl fld_tabScreenContainer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnSave;
    }
}