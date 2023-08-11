namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiReceiptHistory
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
            this.fld_dgcGEHistoryDetails = new BOSERP.Modules.PurchaseReceipt.GEHistoryDetailsGridControl();
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICReceiptItemLogs = new BOSERP.Modules.PurchaseReceipt.ICReceiptItemLogsGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEHistoryDetails)).BeginInit();
            this.BOSLine1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcGEHistoryDetails
            // 
            this.fld_dgcGEHistoryDetails.BOSComment = null;
            this.fld_dgcGEHistoryDetails.BOSDataMember = null;
            this.fld_dgcGEHistoryDetails.BOSDataSource = "GEHistoryDetails";
            this.fld_dgcGEHistoryDetails.BOSDescription = null;
            this.fld_dgcGEHistoryDetails.BOSError = null;
            this.fld_dgcGEHistoryDetails.BOSFieldGroup = null;
            this.fld_dgcGEHistoryDetails.BOSFieldRelation = null;
            this.fld_dgcGEHistoryDetails.BOSGridType = null;
            this.fld_dgcGEHistoryDetails.BOSPrivilege = null;
            this.fld_dgcGEHistoryDetails.BOSPropertyName = null;
            this.fld_dgcGEHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEHistoryDetails.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcGEHistoryDetails.MenuManager = this.screenToolbar;
            this.fld_dgcGEHistoryDetails.Name = "fld_dgcGEHistoryDetails";
            this.fld_dgcGEHistoryDetails.Screen = null;
            this.fld_dgcGEHistoryDetails.Size = new System.Drawing.Size(904, 328);
            this.fld_dgcGEHistoryDetails.TabIndex = 6;
            this.fld_dgcGEHistoryDetails.Tag = "DC";
            // 
            // BOSLine1
            // 
            this.BOSLine1.BackColor = System.Drawing.Color.Transparent;
            this.BOSLine1.BOSComment = null;
            this.BOSLine1.BOSDataMember = null;
            this.BOSLine1.BOSDataSource = null;
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = null;
            this.BOSLine1.BOSFieldRelation = null;
            this.BOSLine1.BOSPrivilege = null;
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Controls.Add(this.fld_dgcGEHistoryDetails);
            this.BOSLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BOSLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLine1.Location = new System.Drawing.Point(0, 0);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(910, 348);
            this.BOSLine1.TabIndex = 17;
            this.BOSLine1.TabStop = false;
            this.BOSLine1.Text = "Thông tin thay đổi chung";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcICReceiptItemLogs);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(0, 351);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(910, 242);
            this.bosLine2.TabIndex = 18;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thông tin thay đổi chi tiết";
            // 
            // fld_dgcICReceiptItemLogs
            // 
            this.fld_dgcICReceiptItemLogs.BOSComment = null;
            this.fld_dgcICReceiptItemLogs.BOSDataMember = null;
            this.fld_dgcICReceiptItemLogs.BOSDataSource = "ICReceiptItemLogs";
            this.fld_dgcICReceiptItemLogs.BOSDescription = null;
            this.fld_dgcICReceiptItemLogs.BOSError = null;
            this.fld_dgcICReceiptItemLogs.BOSFieldGroup = null;
            this.fld_dgcICReceiptItemLogs.BOSFieldRelation = null;
            this.fld_dgcICReceiptItemLogs.BOSGridType = null;
            this.fld_dgcICReceiptItemLogs.BOSPrivilege = null;
            this.fld_dgcICReceiptItemLogs.BOSPropertyName = null;
            this.fld_dgcICReceiptItemLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICReceiptItemLogs.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcICReceiptItemLogs.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptItemLogs.Name = "fld_dgcICReceiptItemLogs";
            this.fld_dgcICReceiptItemLogs.Screen = null;
            this.fld_dgcICReceiptItemLogs.Size = new System.Drawing.Size(904, 222);
            this.fld_dgcICReceiptItemLogs.TabIndex = 6;
            this.fld_dgcICReceiptItemLogs.Tag = "DC";
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
            this.fld_btnClose.Location = new System.Drawing.Point(823, 599);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 19;
            this.fld_btnClose.Tag = "";
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // guiReceiptHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 631);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.BOSLine1);
            this.Name = "guiReceiptHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký thay đổi";
            this.Load += new System.EventHandler(this.guiReceiptHistory_Load);
            this.Controls.SetChildIndex(this.BOSLine1, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEHistoryDetails)).EndInit();
            this.BOSLine1.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GEHistoryDetailsGridControl fld_dgcGEHistoryDetails;
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSLine bosLine2;
        private ICReceiptItemLogsGridControl fld_dgcICReceiptItemLogs;
        private BOSComponent.BOSButton fld_btnClose;
    }
}