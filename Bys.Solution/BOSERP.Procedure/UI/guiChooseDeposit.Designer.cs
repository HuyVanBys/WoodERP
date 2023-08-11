namespace BOSERP
{
    partial class guiChooseDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseDeposit));
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteCustomerPaymentDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteCustomerPaymentDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcDeposits = new BOSERP.DepositGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDeposits)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel1.Size = new System.Drawing.Size(62, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Text = "Mã đơn hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeARCustomerID);
            this.panelControl1.Controls.Add(this.fld_dteCustomerPaymentDateTo);
            this.panelControl1.Controls.Add(this.fld_dteCustomerPaymentDateFrom);
            this.panelControl1.Controls.Add(this.bosLabel3);
            this.panelControl1.Controls.Add(this.fld_btnSearch);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.fld_txtARSaleOrderNo);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(754, 70);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeARCustomerID
            // 
            this.fld_lkeARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeARCustomerID.BOSAllowDummy = true;
            this.fld_lkeARCustomerID.BOSComment = null;
            this.fld_lkeARCustomerID.BOSDataMember = "ARCustomerID";
            this.fld_lkeARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerID.BOSDescription = null;
            this.fld_lkeARCustomerID.BOSError = null;
            this.fld_lkeARCustomerID.BOSFieldGroup = null;
            this.fld_lkeARCustomerID.BOSFieldParent = null;
            this.fld_lkeARCustomerID.BOSFieldRelation = null;
            this.fld_lkeARCustomerID.BOSPrivilege = null;
            this.fld_lkeARCustomerID.BOSPropertyName = null;
            this.fld_lkeARCustomerID.BOSSelectType = null;
            this.fld_lkeARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerID.CurrentDisplayText = null;
            this.fld_lkeARCustomerID.Location = new System.Drawing.Point(334, 9);
            this.fld_lkeARCustomerID.Name = "fld_lkeARCustomerID";
            this.fld_lkeARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactAddressLine3", "Địa chỉ liên lạc")});
            this.fld_lkeARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID.Screen = null;
            this.fld_lkeARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerID.TabIndex = 2;
            // 
            // fld_dteCustomerPaymentDateTo
            // 
            this.fld_dteCustomerPaymentDateTo.BOSComment = null;
            this.fld_dteCustomerPaymentDateTo.BOSDataMember = null;
            this.fld_dteCustomerPaymentDateTo.BOSDataSource = null;
            this.fld_dteCustomerPaymentDateTo.BOSDescription = null;
            this.fld_dteCustomerPaymentDateTo.BOSError = null;
            this.fld_dteCustomerPaymentDateTo.BOSFieldGroup = null;
            this.fld_dteCustomerPaymentDateTo.BOSFieldRelation = null;
            this.fld_dteCustomerPaymentDateTo.BOSPrivilege = null;
            this.fld_dteCustomerPaymentDateTo.BOSPropertyName = null;
            this.fld_dteCustomerPaymentDateTo.EditValue = new System.DateTime(2012, 2, 27, 0, 0, 0, 0);
            this.fld_dteCustomerPaymentDateTo.Location = new System.Drawing.Point(334, 36);
            this.fld_dteCustomerPaymentDateTo.Name = "fld_dteCustomerPaymentDateTo";
            this.fld_dteCustomerPaymentDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCustomerPaymentDateTo.Screen = null;
            this.fld_dteCustomerPaymentDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteCustomerPaymentDateTo.TabIndex = 4;
            // 
            // fld_dteCustomerPaymentDateFrom
            // 
            this.fld_dteCustomerPaymentDateFrom.BOSComment = null;
            this.fld_dteCustomerPaymentDateFrom.BOSDataMember = null;
            this.fld_dteCustomerPaymentDateFrom.BOSDataSource = null;
            this.fld_dteCustomerPaymentDateFrom.BOSDescription = null;
            this.fld_dteCustomerPaymentDateFrom.BOSError = null;
            this.fld_dteCustomerPaymentDateFrom.BOSFieldGroup = null;
            this.fld_dteCustomerPaymentDateFrom.BOSFieldRelation = null;
            this.fld_dteCustomerPaymentDateFrom.BOSPrivilege = null;
            this.fld_dteCustomerPaymentDateFrom.BOSPropertyName = null;
            this.fld_dteCustomerPaymentDateFrom.EditValue = new System.DateTime(2012, 2, 27, 0, 0, 0, 0);
            this.fld_dteCustomerPaymentDateFrom.Location = new System.Drawing.Point(88, 35);
            this.fld_dteCustomerPaymentDateFrom.Name = "fld_dteCustomerPaymentDateFrom";
            this.fld_dteCustomerPaymentDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCustomerPaymentDateFrom.Screen = null;
            this.fld_dteCustomerPaymentDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteCustomerPaymentDateFrom.TabIndex = 3;
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 38);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(58, 13);
            this.bosLabel3.TabIndex = 5;
            this.bosLabel3.Text = "Ngày cọc từ";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(674, 5);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 5;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(260, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(56, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Khách hàng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(260, 39);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Text = "Đến";
            // 
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = null;
            this.fld_txtARSaleOrderNo.BOSDataMember = null;
            this.fld_txtARSaleOrderNo.BOSDataSource = null;
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = null;
            this.fld_txtARSaleOrderNo.BOSFieldGroup = null;
            this.fld_txtARSaleOrderNo.BOSFieldRelation = null;
            this.fld_txtARSaleOrderNo.BOSPrivilege = null;
            this.fld_txtARSaleOrderNo.BOSPropertyName = null;
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(88, 9);
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 1;
            // 
            // fld_dgcDeposits
            // 
            this.fld_dgcDeposits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcDeposits.BOSComment = null;
            this.fld_dgcDeposits.BOSDataMember = null;
            this.fld_dgcDeposits.BOSDataSource = "ARCustomerPayments";
            this.fld_dgcDeposits.BOSDescription = null;
            this.fld_dgcDeposits.BOSError = null;
            this.fld_dgcDeposits.BOSFieldGroup = null;
            this.fld_dgcDeposits.BOSFieldRelation = null;
            this.fld_dgcDeposits.BOSGridType = null;
            this.fld_dgcDeposits.BOSPrivilege = null;
            this.fld_dgcDeposits.BOSPropertyName = null;
            this.fld_dgcDeposits.Location = new System.Drawing.Point(0, 71);
            this.fld_dgcDeposits.Name = "fld_dgcDeposits";
            this.fld_dgcDeposits.Screen = null;
            this.fld_dgcDeposits.Size = new System.Drawing.Size(754, 340);
            this.fld_dgcDeposits.TabIndex = 4;
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(593, 429);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Chọn";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
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
            this.fld_btnCancel.Location = new System.Drawing.Point(674, 429);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiChooseDeposit
            // 
            this.AcceptButton = this.fld_btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(754, 463);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnChoose);
            this.Controls.Add(this.fld_dgcDeposits);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn phiếu cọc";
            this.Load += new System.EventHandler(this.guiChooseDeposit_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcDeposits, 0);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCustomerPaymentDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDeposits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteCustomerPaymentDateTo;
        private BOSComponent.BOSDateEdit fld_dteCustomerPaymentDateFrom;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
        private DepositGridControl fld_dgcDeposits;
        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLookupEdit fld_lkeARCustomerID;
    }
}