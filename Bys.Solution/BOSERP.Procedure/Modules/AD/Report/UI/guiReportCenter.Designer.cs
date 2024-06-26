namespace BOSERP.Modules.Report
{
    partial class guiReportCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiReportCenter));
            this.fld_navBarReportTypes = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.fld_dgcReports = new DevExpress.XtraGrid.GridControl();
            this.fld_dgvReports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_navBarReportTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_navBarReportTypes
            // 
            this.fld_navBarReportTypes.ActiveGroup = this.navBarGroup1;
            this.fld_navBarReportTypes.ContentButtonHint = null;
            this.fld_navBarReportTypes.Dock = System.Windows.Forms.DockStyle.Left;
            this.fld_navBarReportTypes.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.fld_navBarReportTypes.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7});
            this.fld_navBarReportTypes.LargeImages = this.imageCollection1;
            this.fld_navBarReportTypes.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.fld_navBarReportTypes.Location = new System.Drawing.Point(0, 0);
            this.fld_navBarReportTypes.Name = "fld_navBarReportTypes";
            this.fld_navBarReportTypes.OptionsNavPane.ExpandedWidth = 241;
            this.fld_navBarReportTypes.OptionsNavPane.ShowOverflowPanel = false;
            this.fld_navBarReportTypes.Size = new System.Drawing.Size(241, 642);
            this.fld_navBarReportTypes.SmallImages = this.imageCollection1;
            this.fld_navBarReportTypes.StoreDefaultPaintStyleName = true;
            this.fld_navBarReportTypes.TabIndex = 0;
            this.fld_navBarReportTypes.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Section";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SelectedLinkIndex = 4;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Bán hàng";
            this.navBarItem1.ImageOptions.LargeImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.Tag = "Sale";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Khách hàng";
            this.navBarItem2.ImageOptions.LargeImageIndex = 1;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.Tag = "Customer";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Tồn kho";
            this.navBarItem3.ImageOptions.LargeImageIndex = 2;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.Tag = "Inventory";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Mua hàng";
            this.navBarItem4.ImageOptions.LargeImageIndex = 3;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.Tag = "Purchasing";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Sản xuất";
            this.navBarItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.ImageOptions.LargeImage")));
            this.navBarItem7.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.ImageOptions.SmallImage")));
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.Tag = "Produce";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Nhân viên";
            this.navBarItem5.ImageOptions.LargeImageIndex = 5;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.Tag = "Staff";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Kế toán";
            this.navBarItem6.ImageOptions.LargeImageIndex = 6;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.Tag = "Accounting";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "POS.png");
            this.imageCollection1.Images.SetKeyName(1, "Customer.jpg");
            this.imageCollection1.Images.SetKeyName(2, "ProductGroup.jpg");
            this.imageCollection1.Images.SetKeyName(3, "Supplier.jpg");
            this.imageCollection1.Images.SetKeyName(4, "Report.jpg");
            this.imageCollection1.Images.SetKeyName(5, "Staff List.png");
            this.imageCollection1.Images.SetKeyName(6, "Accounting.png");
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(241, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 642);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // fld_dgcReports
            // 
            this.fld_dgcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcReports.Location = new System.Drawing.Point(246, 0);
            this.fld_dgcReports.MainView = this.fld_dgvReports;
            this.fld_dgcReports.Name = "fld_dgcReports";
            this.fld_dgcReports.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemHyperLinkEdit1});
            this.fld_dgcReports.Size = new System.Drawing.Size(778, 642);
            this.fld_dgcReports.TabIndex = 2;
            this.fld_dgcReports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvReports});
            // 
            // fld_dgvReports
            // 
            this.fld_dgvReports.Appearance.FocusedRow.Options.UseBackColor = true;
            this.fld_dgvReports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.fld_dgvReports.GridControl = this.fld_dgcReports;
            this.fld_dgvReports.GroupCount = 1;
            this.fld_dgvReports.GroupFormat = "[#image]{1} {2}";
            this.fld_dgvReports.Name = "fld_dgvReports";
            this.fld_dgvReports.OptionsBehavior.AutoExpandAllGroups = true;
            this.fld_dgvReports.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_dgvReports.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.fld_dgvReports.OptionsView.ShowColumnHeaders = false;
            this.fld_dgvReports.OptionsView.ShowGroupPanel = false;
            this.fld_dgvReports.OptionsView.ShowIndicator = false;
            this.fld_dgvReports.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.fld_dgvReports.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.fld_dgvReports.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.fld_dgvReports_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumn1.FieldName = "ADReportName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 269;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.Appearance.Image = global::BOSERP.Procedure.Properties.Resources.Edit;
            this.repositoryItemHyperLinkEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Image = global::BOSERP.Procedure.Properties.Resources.spreadsheet;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "ADReportDesc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 498;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Section";
            this.gridColumn3.FieldName = "ADReportSection";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Images = this.imageCollection1;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // guiReportCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 642);
            this.Controls.Add(this.fld_dgcReports);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.fld_navBarReportTypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiReportCenter";
            this.Text = "Report Center";
            this.Controls.SetChildIndex(this.fld_navBarReportTypes, 0);
            this.Controls.SetChildIndex(this.splitterControl1, 0);
            this.Controls.SetChildIndex(this.fld_dgcReports, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_navBarReportTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl fld_navBarReportTypes;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl fld_dgcReports;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvReports;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;

    }
}
