namespace BOSERP.Modules.InvoiceIn
{
    partial class guiPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiPayment));
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtWaitingPayment = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPaidAmount = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_cedDeposit = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnChooseReceiptVoucher = new BOSComponent.BOSButton(this.components);
            this.fld_dgcAPClearingDetails = new BOSERP.Modules.InvoiceIn.guiPayment_APClearingDetailsGridControl();
            this.fld_txtBalanceDue = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtTotalAmount = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cedDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = "";
            this.fld_btnOK.BOSDataSource = "";
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = "";
            this.fld_btnOK.Location = new System.Drawing.Point(559, 426);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Tag = "";
            this.fld_btnOK.Text = "OK";
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
            this.fld_btnCancel.Location = new System.Drawing.Point(640, 426);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_txtWaitingPayment);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtPaidAmount);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_txtBalanceDue);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtTotalAmount);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_btnCancel);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(718, 456);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_txtWaitingPayment
            // 
            this.fld_txtWaitingPayment.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtWaitingPayment.Appearance.Options.UseFont = true;
            this.fld_txtWaitingPayment.BOSComment = null;
            this.fld_txtWaitingPayment.BOSDataMember = null;
            this.fld_txtWaitingPayment.BOSDataSource = null;
            this.fld_txtWaitingPayment.BOSDescription = null;
            this.fld_txtWaitingPayment.BOSError = null;
            this.fld_txtWaitingPayment.BOSFieldGroup = null;
            this.fld_txtWaitingPayment.BOSFieldRelation = null;
            this.fld_txtWaitingPayment.BOSPrivilege = null;
            this.fld_txtWaitingPayment.BOSPropertyName = null;
            this.fld_txtWaitingPayment.Location = new System.Drawing.Point(109, 50);
            this.fld_txtWaitingPayment.Name = "fld_txtWaitingPayment";
            this.fld_txtWaitingPayment.Screen = null;
            this.fld_txtWaitingPayment.Size = new System.Drawing.Size(7, 13);
            this.fld_txtWaitingPayment.TabIndex = 18;
            this.fld_txtWaitingPayment.Text = "0";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 50);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(79, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Text = "Chờ thanh toán:";
            // 
            // fld_txtPaidAmount
            // 
            this.fld_txtPaidAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtPaidAmount.Appearance.Options.UseFont = true;
            this.fld_txtPaidAmount.BOSComment = null;
            this.fld_txtPaidAmount.BOSDataMember = null;
            this.fld_txtPaidAmount.BOSDataSource = null;
            this.fld_txtPaidAmount.BOSDescription = null;
            this.fld_txtPaidAmount.BOSError = null;
            this.fld_txtPaidAmount.BOSFieldGroup = null;
            this.fld_txtPaidAmount.BOSFieldRelation = null;
            this.fld_txtPaidAmount.BOSPrivilege = null;
            this.fld_txtPaidAmount.BOSPropertyName = null;
            this.fld_txtPaidAmount.Location = new System.Drawing.Point(109, 31);
            this.fld_txtPaidAmount.Name = "fld_txtPaidAmount";
            this.fld_txtPaidAmount.Screen = null;
            this.fld_txtPaidAmount.Size = new System.Drawing.Size(7, 13);
            this.fld_txtPaidAmount.TabIndex = 10;
            this.fld_txtPaidAmount.Text = "0";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(12, 31);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(74, 13);
            this.bosLabel6.TabIndex = 9;
            this.bosLabel6.Text = "Đã thanh toán:";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_cedDeposit);
            this.bosGroupControl1.Controls.Add(this.fld_btnChooseReceiptVoucher);
            this.bosGroupControl1.Controls.Add(this.fld_dgcAPClearingDetails);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 97);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(712, 323);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Danh sách chứng từ cấn trừ";
            // 
            // fld_cedDeposit
            // 
            this.fld_cedDeposit.BOSComment = null;
            this.fld_cedDeposit.BOSDataMember = null;
            this.fld_cedDeposit.BOSDataSource = null;
            this.fld_cedDeposit.BOSDescription = null;
            this.fld_cedDeposit.BOSError = null;
            this.fld_cedDeposit.BOSFieldGroup = null;
            this.fld_cedDeposit.BOSFieldRelation = null;
            this.fld_cedDeposit.BOSPrivilege = null;
            this.fld_cedDeposit.BOSPropertyName = null;
            this.fld_cedDeposit.Location = new System.Drawing.Point(159, 33);
            this.fld_cedDeposit.MenuManager = this.screenToolbar;
            this.fld_cedDeposit.Name = "fld_cedDeposit";
            this.fld_cedDeposit.Properties.Caption = "Chỉ hiện chứng từ cọc";
            this.fld_cedDeposit.Screen = null;
            this.fld_cedDeposit.Size = new System.Drawing.Size(132, 20);
            this.fld_cedDeposit.TabIndex = 9;
            // 
            // fld_btnChooseReceiptVoucher
            // 
            this.fld_btnChooseReceiptVoucher.BOSComment = null;
            this.fld_btnChooseReceiptVoucher.BOSDataMember = null;
            this.fld_btnChooseReceiptVoucher.BOSDataSource = null;
            this.fld_btnChooseReceiptVoucher.BOSDescription = null;
            this.fld_btnChooseReceiptVoucher.BOSError = null;
            this.fld_btnChooseReceiptVoucher.BOSFieldGroup = null;
            this.fld_btnChooseReceiptVoucher.BOSFieldRelation = null;
            this.fld_btnChooseReceiptVoucher.BOSPrivilege = null;
            this.fld_btnChooseReceiptVoucher.BOSPropertyName = null;
            this.fld_btnChooseReceiptVoucher.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnChooseReceiptVoucher.Location = new System.Drawing.Point(5, 25);
            this.fld_btnChooseReceiptVoucher.Name = "fld_btnChooseReceiptVoucher";
            this.fld_btnChooseReceiptVoucher.Screen = null;
            this.fld_btnChooseReceiptVoucher.Size = new System.Drawing.Size(148, 27);
            this.fld_btnChooseReceiptVoucher.TabIndex = 8;
            this.fld_btnChooseReceiptVoucher.Text = "Chọn chứng từ";
            this.fld_btnChooseReceiptVoucher.Click += new System.EventHandler(this.fld_btnChooseReceiptVoucher_Click);
            // 
            // fld_dgcAPClearingDetails
            // 
            this.fld_dgcAPClearingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPClearingDetails.BOSComment = null;
            this.fld_dgcAPClearingDetails.BOSDataMember = null;
            this.fld_dgcAPClearingDetails.BOSDataSource = "APClearingDetails";
            this.fld_dgcAPClearingDetails.BOSDescription = null;
            this.fld_dgcAPClearingDetails.BOSError = null;
            this.fld_dgcAPClearingDetails.BOSFieldGroup = null;
            this.fld_dgcAPClearingDetails.BOSFieldRelation = null;
            this.fld_dgcAPClearingDetails.BOSGridType = null;
            this.fld_dgcAPClearingDetails.BOSPrivilege = null;
            this.fld_dgcAPClearingDetails.BOSPropertyName = null;
            this.fld_dgcAPClearingDetails.CommodityType = "";
            this.fld_dgcAPClearingDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcAPClearingDetails.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcAPClearingDetails.MenuManager = this.screenToolbar;
            this.fld_dgcAPClearingDetails.Name = "fld_dgcAPClearingDetails";
            this.fld_dgcAPClearingDetails.PrintReport = false;
            this.fld_dgcAPClearingDetails.Screen = null;
            this.fld_dgcAPClearingDetails.Size = new System.Drawing.Size(702, 260);
            this.fld_dgcAPClearingDetails.TabIndex = 7;
            // 
            // fld_txtBalanceDue
            // 
            this.fld_txtBalanceDue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtBalanceDue.Appearance.Options.UseFont = true;
            this.fld_txtBalanceDue.BOSComment = null;
            this.fld_txtBalanceDue.BOSDataMember = null;
            this.fld_txtBalanceDue.BOSDataSource = null;
            this.fld_txtBalanceDue.BOSDescription = null;
            this.fld_txtBalanceDue.BOSError = null;
            this.fld_txtBalanceDue.BOSFieldGroup = null;
            this.fld_txtBalanceDue.BOSFieldRelation = null;
            this.fld_txtBalanceDue.BOSPrivilege = null;
            this.fld_txtBalanceDue.BOSPropertyName = null;
            this.fld_txtBalanceDue.Location = new System.Drawing.Point(109, 70);
            this.fld_txtBalanceDue.Name = "fld_txtBalanceDue";
            this.fld_txtBalanceDue.Screen = null;
            this.fld_txtBalanceDue.Size = new System.Drawing.Size(7, 13);
            this.fld_txtBalanceDue.TabIndex = 7;
            this.fld_txtBalanceDue.Text = "0";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(12, 70);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Text = "Còn lại:";
            // 
            // fld_txtTotalAmount
            // 
            this.fld_txtTotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtTotalAmount.Appearance.Options.UseFont = true;
            this.fld_txtTotalAmount.BOSComment = null;
            this.fld_txtTotalAmount.BOSDataMember = null;
            this.fld_txtTotalAmount.BOSDataSource = null;
            this.fld_txtTotalAmount.BOSDescription = null;
            this.fld_txtTotalAmount.BOSError = null;
            this.fld_txtTotalAmount.BOSFieldGroup = null;
            this.fld_txtTotalAmount.BOSFieldRelation = null;
            this.fld_txtTotalAmount.BOSPrivilege = null;
            this.fld_txtTotalAmount.BOSPropertyName = null;
            this.fld_txtTotalAmount.Location = new System.Drawing.Point(109, 12);
            this.fld_txtTotalAmount.Name = "fld_txtTotalAmount";
            this.fld_txtTotalAmount.Screen = null;
            this.fld_txtTotalAmount.Size = new System.Drawing.Size(7, 13);
            this.fld_txtTotalAmount.TabIndex = 5;
            this.fld_txtTotalAmount.Text = "0";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(91, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Text = "Tổng tiền hóa đơn:";
            // 
            // guiPayment
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(718, 456);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiPayment.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấn trừ công nợ";
            this.Load += new System.EventHandler(this.guiPayment_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_cedDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPClearingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel fld_txtTotalAmount;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_txtBalanceDue;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private guiPayment_APClearingDetailsGridControl fld_dgcAPClearingDetails;
        private BOSComponent.BOSButton fld_btnChooseReceiptVoucher;
        private BOSComponent.BOSCheckEdit fld_cedDeposit;
        private BOSComponent.BOSLabel fld_txtPaidAmount;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_txtWaitingPayment;
        private BOSComponent.BOSLabel bosLabel3;
    }
}