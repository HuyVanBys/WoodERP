namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiPrintPackageBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPrintPackageBarcode));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPrintedPackages = new BOSERP.Modules.PurchaseReceipt.ICPackagesGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_txtICProductSupplierNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintedPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
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
            // fld_dgcPrintedPackages
            // 
            this.fld_dgcPrintedPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPrintedPackages.BOSComment = null;
            this.fld_dgcPrintedPackages.BOSDataMember = null;
            this.fld_dgcPrintedPackages.BOSDataSource = "ICPackages";
            this.fld_dgcPrintedPackages.BOSDescription = null;
            this.fld_dgcPrintedPackages.BOSError = null;
            this.fld_dgcPrintedPackages.BOSFieldGroup = null;
            this.fld_dgcPrintedPackages.BOSFieldRelation = null;
            this.fld_dgcPrintedPackages.BOSGridType = null;
            this.fld_dgcPrintedPackages.BOSPrivilege = null;
            this.fld_dgcPrintedPackages.BOSPropertyName = null;
            this.fld_dgcPrintedPackages.Location = new System.Drawing.Point(0, 42);
            this.fld_dgcPrintedPackages.MenuManager = this.screenToolbar;
            this.fld_dgcPrintedPackages.Name = "fld_dgcPrintedPackages";
            this.fld_dgcPrintedPackages.Screen = null;
            this.fld_dgcPrintedPackages.Size = new System.Drawing.Size(888, 437);
            this.fld_dgcPrintedPackages.TabIndex = 2;
            this.fld_dgcPrintedPackages.Tag = "DC";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_txtICProductSupplierNumber);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(887, 43);
            this.panelControl1.TabIndex = 35;
            // 
            // fld_txtICProductSupplierNumber
            // 
            this.fld_txtICProductSupplierNumber.BOSComment = null;
            this.fld_txtICProductSupplierNumber.BOSDataMember = null;
            this.fld_txtICProductSupplierNumber.BOSDataSource = null;
            this.fld_txtICProductSupplierNumber.BOSDescription = null;
            this.fld_txtICProductSupplierNumber.BOSError = null;
            this.fld_txtICProductSupplierNumber.BOSFieldGroup = null;
            this.fld_txtICProductSupplierNumber.BOSFieldRelation = null;
            this.fld_txtICProductSupplierNumber.BOSPrivilege = null;
            this.fld_txtICProductSupplierNumber.BOSPropertyName = null;
            this.fld_txtICProductSupplierNumber.Location = new System.Drawing.Point(118, 12);
            this.fld_txtICProductSupplierNumber.MenuManager = this.screenToolbar;
            this.fld_txtICProductSupplierNumber.Name = "fld_txtICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.Screen = null;
            this.fld_txtICProductSupplierNumber.Size = new System.Drawing.Size(243, 20);
            this.fld_txtICProductSupplierNumber.TabIndex = 0;
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(395, 9);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(94, 27);
            this.fld_btnApply.TabIndex = 1;
            this.fld_btnApply.Text = "Tìm kiện";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(9, 15);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(87, 13);
            this.BOSLabel3.TabIndex = 8;
            this.BOSLabel3.Text = "Mã sản phẩm NCC";
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
            // guiPrintPackageBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 525);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_dgcPrintedPackages);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiPrintPackageBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In mã vạch";
            this.Load += new System.EventHandler(this.guiPrintPackageBarcode_Load);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcPrintedPackages, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintedPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private ICPackagesGridControl fld_dgcPrintedPackages;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierNumber;
    }
}