namespace BOSERP.Modules.Report
{
    partial class RP192
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
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICRP192Products = new BOSERP.Modules.Report.ICRP051ProductsGridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP192Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(816, 497);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosPanel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPanel1.Appearance.Options.UseBackColor = true;
            this.bosPanel1.Appearance.Options.UseForeColor = true;
            this.bosPanel1.Controls.Add(this.fld_lkeICProductGroupID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeICDepartmentID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_btnSearch);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(903, 46);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_lkeICProductGroupID
            // 
            this.fld_lkeICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeICProductGroupID.BOSAllowDummy = true;
            this.fld_lkeICProductGroupID.BOSComment = null;
            this.fld_lkeICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroupID.BOSDescription = null;
            this.fld_lkeICProductGroupID.BOSError = null;
            this.fld_lkeICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeICProductGroupID.BOSFieldParent = null;
            this.fld_lkeICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeICProductGroupID.BOSPrivilege = null;
            this.fld_lkeICProductGroupID.BOSPropertyName = null;
            this.fld_lkeICProductGroupID.BOSSelectType = null;
            this.fld_lkeICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroupID.CurrentDisplayText = null;
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(328, 10);
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Nhóm hàng")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeICProductGroupID.TabIndex = 85;
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 13);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(58, 13);
            this.bosLabel4.TabIndex = 84;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel4.Text = "Ngành hàng";
            // 
            // fld_lkeICDepartmentID
            // 
            this.fld_lkeICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeICDepartmentID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSDataMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.BOSDataSource = "ICDepartments";
            this.fld_lkeICDepartmentID.BOSDescription = null;
            this.fld_lkeICDepartmentID.BOSError = null;
            this.fld_lkeICDepartmentID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeICDepartmentID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.Location = new System.Drawing.Point(86, 10);
            this.fld_lkeICDepartmentID.Name = "fld_lkeICDepartmentID";
            this.fld_lkeICDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentNo", "Mã ngành hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Tên ngành hàng")});
            this.fld_lkeICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeICDepartmentID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.Screen = null;
            this.fld_lkeICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICDepartmentID.TabIndex = 0;
            this.fld_lkeICDepartmentID.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(259, 13);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(54, 13);
            this.bosLabel3.TabIndex = 83;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Nhóm hàng";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(504, 7);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(73, 27);
            this.fld_btnSearch.TabIndex = 2;
            this.fld_btnSearch.Text = "Xem";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcICRP192Products);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(0, 52);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(903, 439);
            this.bosLine2.TabIndex = 2;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLine2.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcICRP192Products
            // 
            this.fld_dgcICRP192Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICRP192Products.BOSComment = null;
            this.fld_dgcICRP192Products.BOSDataMember = null;
            this.fld_dgcICRP192Products.BOSDataSource = "ICProducts";
            this.fld_dgcICRP192Products.BOSDescription = null;
            this.fld_dgcICRP192Products.BOSError = null;
            this.fld_dgcICRP192Products.BOSFieldGroup = null;
            this.fld_dgcICRP192Products.BOSFieldRelation = null;
            this.fld_dgcICRP192Products.BOSGridType = null;
            this.fld_dgcICRP192Products.BOSPrivilege = null;
            this.fld_dgcICRP192Products.BOSPropertyName = null;
            this.fld_dgcICRP192Products.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcICRP192Products.Name = "fld_dgcICRP192Products";
            this.fld_dgcICRP192Products.PrintReport = false;
            this.fld_dgcICRP192Products.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.fld_dgcICRP192Products.Screen = null;
            this.fld_dgcICRP192Products.Size = new System.Drawing.Size(891, 413);
            this.fld_dgcICRP192Products.TabIndex = 2;
            this.fld_dgcICRP192Products.Tag = "DC";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // RP192
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(903, 532);
            this.ControlBox = true;
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP192";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.RP192_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICRP192Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLine bosLine2;
        private ICRP051ProductsGridControl fld_dgcICRP192Products;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeICDepartmentID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
    }
}