namespace BOSERP.Modules.TransferPlan
{
    partial class guiTransferToTruck
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
            this.fld_dgcTransferToTruckGridControl = new BOSERP.Modules.TransferPlan.TransferToTruckGridControl();
            this.fld_chkCheckAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTransferToTruckGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAll.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(824, 491);
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
            this.fld_btnApply.Location = new System.Drawing.Point(735, 491);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcTransferToTruckGridControl
            // 
            this.fld_dgcTransferToTruckGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcTransferToTruckGridControl.BOSComment = null;
            this.fld_dgcTransferToTruckGridControl.BOSDataMember = null;
            this.fld_dgcTransferToTruckGridControl.BOSDataSource = "ICTransfers";
            this.fld_dgcTransferToTruckGridControl.BOSDescription = null;
            this.fld_dgcTransferToTruckGridControl.BOSError = null;
            this.fld_dgcTransferToTruckGridControl.BOSFieldGroup = null;
            this.fld_dgcTransferToTruckGridControl.BOSFieldRelation = null;
            this.fld_dgcTransferToTruckGridControl.BOSGridType = null;
            this.fld_dgcTransferToTruckGridControl.BOSPrivilege = null;
            this.fld_dgcTransferToTruckGridControl.BOSPropertyName = null;
            this.fld_dgcTransferToTruckGridControl.GridViewMain = null;
            this.fld_dgcTransferToTruckGridControl.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcTransferToTruckGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcTransferToTruckGridControl.Name = "fld_dgcTransferToTruckGridControl";
            this.fld_dgcTransferToTruckGridControl.PrintReport = false;
            this.fld_dgcTransferToTruckGridControl.Screen = null;
            this.fld_dgcTransferToTruckGridControl.Size = new System.Drawing.Size(895, 473);
            this.fld_dgcTransferToTruckGridControl.TabIndex = 6;
            // 
            // fld_chkCheckAll
            // 
            this.fld_chkCheckAll.BOSComment = null;
            this.fld_chkCheckAll.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_chkCheckAll.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_chkCheckAll.BOSDescription = null;
            this.fld_chkCheckAll.BOSError = null;
            this.fld_chkCheckAll.BOSFieldGroup = null;
            this.fld_chkCheckAll.BOSFieldRelation = null;
            this.fld_chkCheckAll.BOSPrivilege = null;
            this.fld_chkCheckAll.BOSPropertyName = "EditValue";
            this.fld_chkCheckAll.Location = new System.Drawing.Point(12, 489);
            this.fld_chkCheckAll.MenuManager = this.screenToolbar;
            this.fld_chkCheckAll.Name = "fld_chkCheckAll";
            this.fld_chkCheckAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkCheckAll.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkCheckAll, true);
            this.fld_chkCheckAll.Size = new System.Drawing.Size(107, 19);
            this.fld_chkCheckAll.TabIndex = 23;
            this.fld_chkCheckAll.Tag = "DC";
            this.fld_chkCheckAll.Visible = false;
            this.fld_chkCheckAll.CheckedChanged += new System.EventHandler(this.fld_chkCheckAll_CheckedChanged);
            // 
            // guiTransferToTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(919, 530);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkCheckAll);
            this.Controls.Add(this.fld_dgcTransferToTruckGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiTransferToTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách chuyển kho";
            this.Load += new System.EventHandler(this.guiAttributionItemToTruck_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcTransferToTruckGridControl, 0);
            this.Controls.SetChildIndex(this.fld_chkCheckAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTransferToTruckGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private TransferToTruckGridControl fld_dgcTransferToTruckGridControl;
        private BOSComponent.BOSCheckEdit fld_chkCheckAll;
    }
}