namespace BOSERP.MES.Modules.ProductionNorm
{
    partial class guiShowHardwareBySaleOrder<T>
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
            this.fld_dgcARSaleOrderItemGridControl = new BOSERP.MES.Modules.ProductionNorm.ARSaleOrderItemGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(559, 360);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "OK";
            // 
            // fld_dgcARSaleOrderItemGridControl
            // 
            this.fld_dgcARSaleOrderItemGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItemGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemGridControl.Location = new System.Drawing.Point(12, 39);
            this.fld_dgcARSaleOrderItemGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemGridControl.Name = "fld_dgcARSaleOrderItemGridControl";
            this.fld_dgcARSaleOrderItemGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemGridControl.Size = new System.Drawing.Size(630, 315);
            this.fld_dgcARSaleOrderItemGridControl.TabIndex = 6;
            // 
            // guiShowHardwareBySaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(654, 399);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARSaleOrderItemGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "guiShowHardwareBySaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách Hardware trong đơn hàng vừa chọn";
            this.Load += new System.EventHandler(this.guiShowCollectionComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderItemGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private ARSaleOrderItemGridControl fld_dgcARSaleOrderItemGridControl;
    }
}