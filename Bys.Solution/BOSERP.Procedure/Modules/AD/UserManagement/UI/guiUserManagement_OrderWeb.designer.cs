namespace BOSERP.Modules.UserManagement
{
    partial class guiUserManagement_OrderWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiUserManagement_OrderWeb));
            this.fld_imglUserGroup = new System.Windows.Forms.ImageList(this.components);
            this.fld_trlstUserGroup_OrderWeb = new DevExpress.XtraTreeList.TreeList();
            this.fld_tlcUserGroupName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_tabScreenContainer = new BOSComponent.BOSTabControl(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADDataViewPermissions = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcADReportViewPermissions = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.adDataViewPermissionsGridControl1 = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.adDataViewPermissionsGridControl2 = new BOSERP.Modules.UserManagement.ADDataViewPermissionsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_OrderWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
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
            // fld_trlstUserGroup_OrderWeb
            // 
            this.fld_trlstUserGroup_OrderWeb.AllowDrop = true;
            this.fld_trlstUserGroup_OrderWeb.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.fld_tlcUserGroupName});
            this.fld_trlstUserGroup_OrderWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlstUserGroup_OrderWeb.Location = new System.Drawing.Point(2, 20);
            this.fld_trlstUserGroup_OrderWeb.Name = "fld_trlstUserGroup_OrderWeb";
            this.fld_trlstUserGroup_OrderWeb.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlstUserGroup_OrderWeb.OptionsView.ShowColumns = false;
            this.fld_trlstUserGroup_OrderWeb.OptionsView.ShowIndicator = false;
            this.fld_trlstUserGroup_OrderWeb.Size = new System.Drawing.Size(296, 625);
            this.fld_trlstUserGroup_OrderWeb.TabIndex = 7;
            this.fld_trlstUserGroup_OrderWeb.DragDrop += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_DragDrop);
            this.fld_trlstUserGroup_OrderWeb.DragOver += new System.Windows.Forms.DragEventHandler(this.fld_trlstUserGroup_DragOver);
            this.fld_trlstUserGroup_OrderWeb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseClick);
            this.fld_trlstUserGroup_OrderWeb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseDown);
            this.fld_trlstUserGroup_OrderWeb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fld_trlstUserGroup_MouseMove);
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
            this.groupControl2.Controls.Add(this.fld_trlstUserGroup_OrderWeb);
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
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 647);
            this.panel1.TabIndex = 15;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.fld_tabScreenContainer);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(777, 647);
            this.groupControl1.TabIndex = 14;
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
            this.fld_tabScreenContainer.Size = new System.Drawing.Size(773, 577);
            this.fld_tabScreenContainer.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 597);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 48);
            this.panelControl1.TabIndex = 0;
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
            // guiUserManagement_OrderWeb
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 647);
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Name = "guiUserManagement_OrderWeb";
            this.Text = "Phân quyền WebOrder";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlstUserGroup_OrderWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabScreenContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
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
        public DevExpress.XtraTreeList.TreeList fld_trlstUserGroup_OrderWeb;
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BOSComponent.BOSTabControl fld_tabScreenContainer;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}