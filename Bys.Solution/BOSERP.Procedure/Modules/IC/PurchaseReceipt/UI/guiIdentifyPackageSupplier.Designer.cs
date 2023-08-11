namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiIdentifyPackageSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiIdentifyPackageSupplier));
            this.fld_dgcICReceiptItemPackages = new BOSERP.Modules.PurchaseReceipt.ICReceiptItemPackagesGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICReceiptItemPackages
            // 
            this.fld_dgcICReceiptItemPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptItemPackages.BOSComment = null;
            this.fld_dgcICReceiptItemPackages.BOSDataMember = null;
            this.fld_dgcICReceiptItemPackages.BOSDataSource = "ICReceiptItemPackages";
            this.fld_dgcICReceiptItemPackages.BOSDescription = null;
            this.fld_dgcICReceiptItemPackages.BOSError = null;
            this.fld_dgcICReceiptItemPackages.BOSFieldGroup = null;
            this.fld_dgcICReceiptItemPackages.BOSFieldRelation = null;
            this.fld_dgcICReceiptItemPackages.BOSGridType = null;
            this.fld_dgcICReceiptItemPackages.BOSPrivilege = null;
            this.fld_dgcICReceiptItemPackages.BOSPropertyName = null;
            this.fld_dgcICReceiptItemPackages.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICReceiptItemPackages.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptItemPackages.Name = "fld_dgcICReceiptItemPackages";
            this.fld_dgcICReceiptItemPackages.Screen = null;
            this.fld_dgcICReceiptItemPackages.Size = new System.Drawing.Size(633, 385);
            this.fld_dgcICReceiptItemPackages.TabIndex = 0;
            this.fld_dgcICReceiptItemPackages.Tag = "DC";
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
            this.fld_btnClose.Location = new System.Drawing.Point(552, 393);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(471, 393);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 1;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // guiIdentifyPackageSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 428);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_dgcICReceiptItemPackages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiIdentifyPackageSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác định mã kiện NCC";
            this.Load += new System.EventHandler(this.guiIdentifyPackageSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ICReceiptItemPackagesGridControl fld_dgcICReceiptItemPackages;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnSave;
    }
}