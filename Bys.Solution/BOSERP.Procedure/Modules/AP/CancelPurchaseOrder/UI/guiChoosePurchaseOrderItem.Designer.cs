namespace BOSERP.Modules.CancelPurchaseOrder
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
            this.fld_dgcAPProductsOfProposalItemsGridControl = new BOSERP.Modules.APPurchaseOrderItemsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_txtFind = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProductsOfProposalItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPProductsOfProposalItemsGridControl
            // 
            this.fld_dgcAPProductsOfProposalItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSComment = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSDataMember = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSDataSource = "APPurchaseOrderItems";
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSDescription = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSError = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSGridType = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSPrivilege = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.BOSPropertyName = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.Location = new System.Drawing.Point(12, 42);
            this.fld_dgcAPProductsOfProposalItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcAPProductsOfProposalItemsGridControl.Name = "fld_dgcAPProductsOfProposalItemsGridControl";
            this.fld_dgcAPProductsOfProposalItemsGridControl.PrintReport = false;
            this.fld_dgcAPProductsOfProposalItemsGridControl.Screen = null;
            this.fld_dgcAPProductsOfProposalItemsGridControl.Size = new System.Drawing.Size(873, 501);
            this.fld_dgcAPProductsOfProposalItemsGridControl.TabIndex = 2;
            this.fld_dgcAPProductsOfProposalItemsGridControl.Tag = "DC";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(694, 549);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(92, 27);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(793, 549);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
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
            this.fld_txtFind.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtFind.Location = new System.Drawing.Point(12, 12);
            this.fld_txtFind.MenuManager = this.screenToolbar;
            this.fld_txtFind.Name = "fld_txtFind";
            this.fld_txtFind.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_txtFind.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFind.Screen = null;
            this.fld_txtFind.Size = new System.Drawing.Size(778, 20);
            this.fld_txtFind.TabIndex = 0;
            this.fld_txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtFind_KeyUp);
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
            this.fld_btnFind.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.Image")));
            this.fld_btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(800, 9);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(85, 27);
            this.fld_btnFind.TabIndex = 1;
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // guiChoosePurchaseOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtFind);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_dgcAPProductsOfProposalItemsGridControl);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChoosePurchaseOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiChoosePurchaseOrderItem_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPProductsOfProposalItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_txtFind, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProductsOfProposalItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private APPurchaseOrderItemsGridControl fld_dgcAPProductsOfProposalItemsGridControl;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSTextBox fld_txtFind;
        private BOSComponent.BOSButton fld_btnFind;
    }
}