namespace BOSERP.Modules.Supplier
{
    partial class guiImportSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiImportSuppliers));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnApproveImport = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgvIPSuppliers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvIPSupplierAttributes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcIPSuppliers = new BOSERP.Modules.Supplier.IPSuppliersGridControl();
            this.fld_dgvIPProductGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPSupplierAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIPSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPProductGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_btnApproveImport);
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1018, 580);
            this.bosPanel1.TabIndex = 406;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 3);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1012, 528);
            this.bosTabControl1.TabIndex = 559;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcIPSuppliers);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1010, 503);
            this.xtraTabPage2.Text = "Danh sách import NCC";
            // 
            // fld_btnApproveImport
            // 
            this.fld_btnApproveImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApproveImport.BOSComment = null;
            this.fld_btnApproveImport.BOSDataMember = null;
            this.fld_btnApproveImport.BOSDataSource = null;
            this.fld_btnApproveImport.BOSDescription = null;
            this.fld_btnApproveImport.BOSError = null;
            this.fld_btnApproveImport.BOSFieldGroup = null;
            this.fld_btnApproveImport.BOSFieldRelation = null;
            this.fld_btnApproveImport.BOSPrivilege = null;
            this.fld_btnApproveImport.BOSPropertyName = null;
            this.fld_btnApproveImport.Location = new System.Drawing.Point(804, 537);
            this.fld_btnApproveImport.Name = "fld_btnApproveImport";
            this.fld_btnApproveImport.Screen = null;
            this.fld_btnApproveImport.Size = new System.Drawing.Size(99, 27);
            this.fld_btnApproveImport.TabIndex = 558;
            this.fld_btnApproveImport.Text = "Duyệt Import";
            this.fld_btnApproveImport.Click += new System.EventHandler(this.fld_btnApproveImport_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(909, 537);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(99, 27);
            this.fld_btnClose.TabIndex = 557;
            this.fld_btnClose.Text = "Thoát";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgvIPSuppliers
            // 
            this.fld_dgvIPSuppliers.Name = "fld_dgvIPSuppliers";
            this.fld_dgvIPSuppliers.PaintStyleName = "Office2003";
            // 
            // fld_dgvIPSupplierAttributes
            // 
            this.fld_dgvIPSupplierAttributes.Name = "fld_dgvIPSupplierAttributes";
            this.fld_dgvIPSupplierAttributes.PaintStyleName = "Office2003";
            // 
            // fld_dgcIPSuppliers
            // 
            this.fld_dgcIPSuppliers.AllowDrop = true;
            this.fld_dgcIPSuppliers.BOSComment = "";
            this.fld_dgcIPSuppliers.BOSDataMember = "";
            this.fld_dgcIPSuppliers.BOSDataSource = "IPSuppliers";
            this.fld_dgcIPSuppliers.BOSDescription = null;
            this.fld_dgcIPSuppliers.BOSError = null;
            this.fld_dgcIPSuppliers.BOSFieldGroup = "";
            this.fld_dgcIPSuppliers.BOSFieldRelation = "";
            this.fld_dgcIPSuppliers.BOSGridType = null;
            this.fld_dgcIPSuppliers.BOSPrivilege = "";
            this.fld_dgcIPSuppliers.BOSPropertyName = "";
            this.fld_dgcIPSuppliers.CommodityType = "";
            this.fld_dgcIPSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcIPSuppliers.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcIPSuppliers.ListImport = null;
            this.fld_dgcIPSuppliers.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcIPSuppliers.MainView = this.fld_dgvIPProductGroups;
            this.fld_dgcIPSuppliers.Name = "fld_dgcIPSuppliers";
            this.fld_dgcIPSuppliers.PrintReport = false;
            this.fld_dgcIPSuppliers.Screen = null;
            this.fld_dgcIPSuppliers.Size = new System.Drawing.Size(1010, 503);
            this.fld_dgcIPSuppliers.TabIndex = 2;
            this.fld_dgcIPSuppliers.Tag = "DC";
            this.fld_dgcIPSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvIPProductGroups});
            // 
            // fld_dgvIPProductGroups
            // 
            this.fld_dgvIPProductGroups.GridControl = this.fld_dgcIPSuppliers;
            this.fld_dgvIPProductGroups.Name = "fld_dgvIPProductGroups";
            this.fld_dgvIPProductGroups.PaintStyleName = "Office2003";
            // 
            // guiImportSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 580);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiImportSuppliers.IconOptions.Icon")));
            this.Name = "guiImportSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Danh sách dữ liệu nhập từ Excel";
            this.Load += new System.EventHandler(this.guiImportSuppliers_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPSupplierAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIPSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvIPProductGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApproveImport;
        private IPSuppliersGridControl fld_dgcIPSupplierInvisiables;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvIPSuppliers;
        private IPSupplierAttributesGridControl fld_dgcIPSupplierAttributes;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvIPSupplierAttributes;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Supplier.IPSuppliersGridControl fld_dgcIPSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvIPProductGroups;
    }
}