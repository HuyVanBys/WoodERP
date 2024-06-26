namespace BOSERP.Modules.Invoice
{
    partial class guiFindShipmentSaleOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiFindShipmentSaleOrder));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICShipmentsGridControl = new BOSERP.Modules.Invoice.ShipmentsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentsGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(828, 565);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 10;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(739, 565);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcICShipmentsGridControl
            // 
            this.fld_dgcICShipmentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICShipmentsGridControl.BOSComment = null;
            this.fld_dgcICShipmentsGridControl.BOSDataMember = null;
            this.fld_dgcICShipmentsGridControl.BOSDataSource = "ICShipments";
            this.fld_dgcICShipmentsGridControl.BOSDescription = null;
            this.fld_dgcICShipmentsGridControl.BOSError = null;
            this.fld_dgcICShipmentsGridControl.BOSFieldGroup = null;
            this.fld_dgcICShipmentsGridControl.BOSFieldRelation = null;
            this.fld_dgcICShipmentsGridControl.BOSGridType = null;
            this.fld_dgcICShipmentsGridControl.BOSPrivilege = null;
            this.fld_dgcICShipmentsGridControl.BOSPropertyName = null;
            this.fld_dgcICShipmentsGridControl.CommodityType = "";
            this.fld_dgcICShipmentsGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcICShipmentsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICShipmentsGridControl.Name = "fld_dgcICShipmentsGridControl";
            this.fld_dgcICShipmentsGridControl.PrintReport = false;
            this.fld_dgcICShipmentsGridControl.Screen = null;
            this.fld_dgcICShipmentsGridControl.Size = new System.Drawing.Size(899, 547);
            this.fld_dgcICShipmentsGridControl.TabIndex = 8;
            this.fld_dgcICShipmentsGridControl.Tag = "";
            // 
            // guiFindShipmentSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(923, 604);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcICShipmentsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiFindShipmentSaleOrder.IconOptions.Icon")));
            this.Name = "guiFindShipmentSaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcICShipmentsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICShipmentsGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ShipmentsGridControl fld_dgcICShipmentsGridControl;
    }
}