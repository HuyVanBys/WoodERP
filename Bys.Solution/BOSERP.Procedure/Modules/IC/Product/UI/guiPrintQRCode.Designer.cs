namespace BOSERP.Modules.Product
{
    partial class guiPrintQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPrintQRCode));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPrintQRCodeGridControl = new BOSERP.Modules.Product.PrintQRCodeGridControl();
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSearchProducts = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintQRCodeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(800, 490);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(719, 490);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 4;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_dgcPrintQRCodeGridControl
            // 
            this.fld_dgcPrintQRCodeGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPrintQRCodeGridControl.BOSComment = null;
            this.fld_dgcPrintQRCodeGridControl.BOSDataMember = null;
            this.fld_dgcPrintQRCodeGridControl.BOSDataSource = "ICProducts";
            this.fld_dgcPrintQRCodeGridControl.BOSDescription = null;
            this.fld_dgcPrintQRCodeGridControl.BOSError = null;
            this.fld_dgcPrintQRCodeGridControl.BOSFieldGroup = null;
            this.fld_dgcPrintQRCodeGridControl.BOSFieldRelation = null;
            this.fld_dgcPrintQRCodeGridControl.BOSGridType = null;
            this.fld_dgcPrintQRCodeGridControl.BOSPrivilege = null;
            this.fld_dgcPrintQRCodeGridControl.BOSPropertyName = null;
            this.fld_dgcPrintQRCodeGridControl.Location = new System.Drawing.Point(0, 64);
            this.fld_dgcPrintQRCodeGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPrintQRCodeGridControl.Name = "fld_dgcPrintQRCodeGridControl";
            this.fld_dgcPrintQRCodeGridControl.PrintReport = false;
            this.fld_dgcPrintQRCodeGridControl.Screen = null;
            this.fld_dgcPrintQRCodeGridControl.Size = new System.Drawing.Size(888, 415);
            this.fld_dgcPrintQRCodeGridControl.TabIndex = 2;
            this.fld_dgcPrintQRCodeGridControl.Tag = "DC";
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(12, 494);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 3;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
            // 
            // fld_lkeICDepartmentID
            // 
            this.fld_lkeICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeICDepartmentID.BOSComment = null;
            this.fld_lkeICDepartmentID.BOSDataMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.BOSDataSource = "ICDepartments";
            this.fld_lkeICDepartmentID.BOSDescription = null;
            this.fld_lkeICDepartmentID.BOSError = null;
            this.fld_lkeICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeICDepartmentID.BOSFieldParent = null;
            this.fld_lkeICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeICDepartmentID.BOSPrivilege = null;
            this.fld_lkeICDepartmentID.BOSPropertyName = null;
            this.fld_lkeICDepartmentID.BOSSelectType = null;
            this.fld_lkeICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeICDepartmentID.CurrentDisplayText = null;
            this.fld_lkeICDepartmentID.Location = new System.Drawing.Point(82, 12);
            this.fld_lkeICDepartmentID.Name = "fld_lkeICDepartmentID";
            this.fld_lkeICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Ngành hàng")});
            this.fld_lkeICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.Screen = null;
            this.fld_lkeICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICDepartmentID.TabIndex = 9;
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
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(337, 12);
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Nhóm hàng")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(151, 20);
            this.fld_lkeICProductGroupID.TabIndex = 10;
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = null;
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(82, 38);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(406, 20);
            this.fld_lkeICProductID.TabIndex = 11;
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(7, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Tag = "DC";
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(7, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(58, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Tag = "DC";
            this.bosLabel5.Text = "Ngành hàng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(257, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 8;
            this.bosLabel4.Tag = "DC";
            this.bosLabel4.Text = "Nhóm hàng";
            // 
            // fld_btnSearchProducts
            // 
            this.fld_btnSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearchProducts.BOSComment = null;
            this.fld_btnSearchProducts.BOSDataMember = null;
            this.fld_btnSearchProducts.BOSDataSource = null;
            this.fld_btnSearchProducts.BOSDescription = null;
            this.fld_btnSearchProducts.BOSError = null;
            this.fld_btnSearchProducts.BOSFieldGroup = null;
            this.fld_btnSearchProducts.BOSFieldRelation = null;
            this.fld_btnSearchProducts.BOSPrivilege = null;
            this.fld_btnSearchProducts.BOSPropertyName = null;
            this.fld_btnSearchProducts.Location = new System.Drawing.Point(494, 31);
            this.fld_btnSearchProducts.Name = "fld_btnSearchProducts";
            this.fld_btnSearchProducts.Screen = null;
            this.fld_btnSearchProducts.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearchProducts.TabIndex = 12;
            this.fld_btnSearchProducts.Text = "Tìm kiếm";
            this.fld_btnSearchProducts.Click += new System.EventHandler(this.fld_btnSearchProducts_Click);
            // 
            // guiPrintQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 525);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnSearchProducts);
            this.Controls.Add(this.fld_lkeICDepartmentID);
            this.Controls.Add(this.fld_lkeICProductGroupID);
            this.Controls.Add(this.fld_lkeICProductID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.fld_dgcPrintQRCodeGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiPrintQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In mã vạch";
            this.Load += new System.EventHandler(this.guiPrintInventoryPackageBarcode_Load);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcPrintQRCodeGridControl, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductGroupID, 0);
            this.Controls.SetChildIndex(this.fld_lkeICDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_btnSearchProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintQRCodeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private PrintQRCodeGridControl fld_dgcPrintQRCodeGridControl;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSComponent.BOSLookupEdit fld_lkeICDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnSearchProducts;
    }
}