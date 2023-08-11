namespace BOSERP.Modules.SaleOrder
{
    partial class guiAddSaleOrderPaymentTimes<T>
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
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcSaleOrderPaymentTimes = new BOSERP.Modules.SaleOrder.SaleOrderPaymentTimesGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderPaymentTimes)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(685, 408);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 4;
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
            this.fld_btnApply.Location = new System.Drawing.Point(596, 408);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcSaleOrderPaymentTimes
            // 
            this.fld_dgcSaleOrderPaymentTimes.BOSComment = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSDataMember = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSDataSource = "ARSaleOrderPaymentTimes";
            this.fld_dgcSaleOrderPaymentTimes.BOSDescription = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSError = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSFieldGroup = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSFieldRelation = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSGridType = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSPrivilege = null;
            this.fld_dgcSaleOrderPaymentTimes.BOSPropertyName = null;
            this.fld_dgcSaleOrderPaymentTimes.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcSaleOrderPaymentTimes.MenuManager = this.screenToolbar;
            this.fld_dgcSaleOrderPaymentTimes.Name = "fld_dgcSaleOrderPaymentTimes";
            this.fld_dgcSaleOrderPaymentTimes.PrintReport = false;
            this.fld_dgcSaleOrderPaymentTimes.Screen = null;
            this.fld_dgcSaleOrderPaymentTimes.Size = new System.Drawing.Size(756, 390);
            this.fld_dgcSaleOrderPaymentTimes.TabIndex = 8;
            // 
            // guiAddSaleOrderPaymentTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(780, 447);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcSaleOrderPaymentTimes);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAddSaleOrderPaymentTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đợt thanh toán";
            this.Load += new System.EventHandler(this.guiAddSaleOrderPaymentTimes_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcSaleOrderPaymentTimes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrderPaymentTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSERP.Modules.SaleOrder.SaleOrderPaymentTimesGridControl fld_dgcSaleOrderPaymentTimes;
    }
}