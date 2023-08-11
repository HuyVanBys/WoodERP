namespace BOSERP.Modules.SemiProductReceipt
{
    partial class guiImportReceiptItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiImportReceiptItem));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApprove = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptPackageItemDetails1 = new BOSERP.Modules.SemiProductReceipt.IPReceiptItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(794, 515);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(105, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Thoát";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnApprove
            // 
            this.fld_btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApprove.BOSComment = null;
            this.fld_btnApprove.BOSDataMember = null;
            this.fld_btnApprove.BOSDataSource = null;
            this.fld_btnApprove.BOSDescription = null;
            this.fld_btnApprove.BOSError = null;
            this.fld_btnApprove.BOSFieldGroup = null;
            this.fld_btnApprove.BOSFieldRelation = null;
            this.fld_btnApprove.BOSPrivilege = null;
            this.fld_btnApprove.BOSPropertyName = null;
            this.fld_btnApprove.Location = new System.Drawing.Point(683, 515);
            this.fld_btnApprove.Name = "fld_btnApprove";
            this.fld_btnApprove.Screen = null;
            this.fld_btnApprove.Size = new System.Drawing.Size(105, 27);
            this.fld_btnApprove.TabIndex = 4;
            this.fld_btnApprove.Text = "Duyệt Import";
            this.fld_btnApprove.Click += new System.EventHandler(this.fld_btnApprove_Click);
            // 
            // fld_dgcICReceiptPackageItemDetails1
            // 
            this.fld_dgcICReceiptPackageItemDetails1.AllowDrop = true;
            this.fld_dgcICReceiptPackageItemDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptPackageItemDetails1.BOSComment = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSDataMember = "";
            this.fld_dgcICReceiptPackageItemDetails1.BOSDataSource = "IPReceiptItems";
            this.fld_dgcICReceiptPackageItemDetails1.BOSDescription = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSError = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSFieldGroup = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSFieldRelation = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSGridType = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSPrivilege = null;
            this.fld_dgcICReceiptPackageItemDetails1.BOSPropertyName = null;
            this.fld_dgcICReceiptPackageItemDetails1.CommodityType = "";
            this.fld_dgcICReceiptPackageItemDetails1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptPackageItemDetails1.Location = new System.Drawing.Point(11, 12);
            this.fld_dgcICReceiptPackageItemDetails1.Name = "fld_dgcICReceiptPackageItemDetails1";
            this.fld_dgcICReceiptPackageItemDetails1.PrintReport = false;
            this.fld_dgcICReceiptPackageItemDetails1.Screen = null;
            this.fld_dgcICReceiptPackageItemDetails1.Size = new System.Drawing.Size(888, 497);
            this.fld_dgcICReceiptPackageItemDetails1.TabIndex = 6;
            this.fld_dgcICReceiptPackageItemDetails1.Tag = "DC";
            this.fld_dgcICReceiptPackageItemDetails1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICReceiptPackageItemDetails1;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // guiImportReceiptItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 553);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcICReceiptPackageItemDetails1);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApprove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiImportReceiptItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dữ liệu import ";
            this.Load += new System.EventHandler(this.guiPrintInventoryPackageBarcode_Load);
            this.Controls.SetChildIndex(this.fld_btnApprove, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceiptPackageItemDetails1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptPackageItemDetails1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApprove;
        private IPReceiptItemsGridControl fld_dgcICReceiptPackageItemDetails1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}