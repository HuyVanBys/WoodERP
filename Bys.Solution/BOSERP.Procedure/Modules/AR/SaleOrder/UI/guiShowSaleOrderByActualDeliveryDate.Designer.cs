namespace BOSERP.Modules.SaleOrder
{
    partial class guiShowSaleOrderByActualDeliveryDate<T>
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
            this.fld_dgcARSaleOrderGridControl = new BOSERP.Modules.SaleOrder.ARSaleOrderGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(402, 366);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "OK";
            // 
            // fld_dgcARSaleOrderGridControl
            // 
            this.fld_dgcARSaleOrderGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderGridControl.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrderGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderGridControl.BOSError = null;
            this.fld_dgcARSaleOrderGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderGridControl.Location = new System.Drawing.Point(12, 39);
            this.fld_dgcARSaleOrderGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderGridControl.Name = "fld_dgcARSaleOrderGridControl";
            this.fld_dgcARSaleOrderGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderGridControl.Screen = null;
            this.fld_dgcARSaleOrderGridControl.Size = new System.Drawing.Size(473, 321);
            this.fld_dgcARSaleOrderGridControl.TabIndex = 6;
            // 
            // guiShowSaleOrderByActualDeliveryDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(497, 405);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARSaleOrderGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "guiShowSaleOrderByActualDeliveryDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đơn hàng có ngày giao thực tế bằng ngày giao vừa chọn";
            this.Load += new System.EventHandler(this.guiShowCollectionComponent_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private ARSaleOrderGridControl fld_dgcARSaleOrderGridControl;
    }
}