namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiChoosePurchaseOrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChoosePurchaseOrderItem));
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.fld_txtFind = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl = new BOSERP.Modules.PurchaseReceipt.APPurchaseOrderItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnSelect
            // 
            this.fld_btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSelect.BOSComment = null;
            this.fld_btnSelect.BOSDataMember = null;
            this.fld_btnSelect.BOSDataSource = null;
            this.fld_btnSelect.BOSDescription = null;
            this.fld_btnSelect.BOSError = null;
            this.fld_btnSelect.BOSFieldGroup = null;
            this.fld_btnSelect.BOSFieldRelation = null;
            this.fld_btnSelect.BOSPrivilege = null;
            this.fld_btnSelect.BOSPropertyName = null;
            this.fld_btnSelect.Location = new System.Drawing.Point(707, 524);
            this.fld_btnSelect.Name = "fld_btnSelect";
            this.fld_btnSelect.Screen = null;
            this.fld_btnSelect.Size = new System.Drawing.Size(83, 27);
            this.fld_btnSelect.TabIndex = 9;
            this.fld_btnSelect.Text = "Chọn";
            this.fld_btnSelect.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_txtFind
            // 
            this.fld_txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtFind.BOSComment = null;
            this.fld_txtFind.BOSDataMember = null;
            this.fld_txtFind.BOSDataSource = null;
            this.fld_txtFind.BOSDescription = null;
            this.fld_txtFind.BOSError = null;
            this.fld_txtFind.BOSFieldGroup = null;
            this.fld_txtFind.BOSFieldRelation = null;
            this.fld_txtFind.BOSPrivilege = null;
            this.fld_txtFind.BOSPropertyName = null;
            this.fld_txtFind.EditValue = "Nhập vào từ khóa";
            this.fld_txtFind.Location = new System.Drawing.Point(12, 12);
            this.fld_txtFind.MenuManager = this.screenToolbar;
            this.fld_txtFind.Name = "fld_txtFind";
            this.fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.fld_txtFind.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFind.Screen = null;
            this.fld_txtFind.Size = new System.Drawing.Size(799, 20);
            this.fld_txtFind.TabIndex = 6;
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.ImageOptions.Image")));
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(817, 9);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(64, 27);
            this.fld_btnFind.TabIndex = 7;
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(798, 524);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 8;
            this.fld_btnClose.Text = "Hủy";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl
            // 
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSComment = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSDataMember = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSDataSource = "APPurchaseOrderItems";
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSDescription = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSError = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSGridType = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSPrivilege = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.BOSPropertyName = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.CommodityType = "";
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.Location = new System.Drawing.Point(12, 46);
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.Name = "fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl";
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.PrintReport = false;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.Screen = null;
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.Size = new System.Drawing.Size(869, 472);
            this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.TabIndex = 10;
            // 
            // guiChoosePurchaseOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 563);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl);
            this.Controls.Add(this.fld_btnSelect);
            this.Controls.Add(this.fld_txtFind);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_btnClose);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiChoosePurchaseOrderItem.IconOptions.Icon")));
            this.Name = "guiChoosePurchaseOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiến thông tin";
            this.Load += new System.EventHandler(this.guiChoosePurchaseOrderItem_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_txtFind, 0);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnSelect;
        private BOSComponent.BOSTextBox fld_txtFind;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSButton fld_btnClose;
        private APPurchaseOrderItemsGridControl fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl;


    }
}