namespace BOSERP.Modules.DeliveryPlan
{
    partial class guiDeliveryPlanTruckItem
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARDeliveryPlanTruckItemsGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanTruckItemsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckItemsGridControl)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(708, 546);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
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
            this.fld_btnApply.Location = new System.Drawing.Point(619, 546);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcARDeliveryPlanTruckItemsGridControl
            // 
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSComment = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSDataMember = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSDataSource = "ARDeliveryPlanTruckItems";
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.Name = "fld_dgcARDeliveryPlanTruckItemsGridControl";
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.Size = new System.Drawing.Size(779, 512);
            this.fld_dgcARDeliveryPlanTruckItemsGridControl.TabIndex = 6;
            // 
            // guiDeliveryPlanTruckItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(803, 585);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARDeliveryPlanTruckItemsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiDeliveryPlanTruckItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARDeliveryPlanTruckItemsGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckItemsGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ARDeliveryPlanTruckItemsGridControl fld_dgcARDeliveryPlanTruckItemsGridControl;
    }
}