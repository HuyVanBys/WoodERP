namespace BOSERP.Modules.ProductionPlanning
{
    partial class guiChooseARSaleOrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseARSaleOrderItem));
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.ProductionPlanning.ARSaleOrderItemsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcARSaleOrderItems
            // 
            this.fld_dgcARSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItems.BOSComment = null;
            this.fld_dgcARSaleOrderItems.BOSDataMember = null;
            this.fld_dgcARSaleOrderItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.BOSDescription = null;
            this.fld_dgcARSaleOrderItems.BOSError = null;
            this.fld_dgcARSaleOrderItems.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItems.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItems.BOSGridType = null;
            this.fld_dgcARSaleOrderItems.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItems.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItems.CommodityType = "";
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(2, 12);
            this.fld_dgcARSaleOrderItems.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(903, 534);
            this.fld_dgcARSaleOrderItems.TabIndex = 0;
            this.fld_dgcARSaleOrderItems.Tag = "DC";
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
            this.fld_btnOK.Location = new System.Drawing.Point(714, 554);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(813, 554);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(92, 27);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiChooseARSaleOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(913, 588);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARSaleOrderItems);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseARSaleOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách mặt hàng từ đơn bán hàng";
            this.Load += new System.EventHandler(this.guiChooseProposalItem_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
    }
}