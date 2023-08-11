namespace BOSERP.Modules.POS
{
    partial class guiGiftVoucherList
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
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARCreditNoteNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcCreditNotes = new BOSERP.Modules.POS.CreditNoteGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCreditNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_btnFind);
            this.bosPanel1.Controls.Add(this.fld_dteToDate);
            this.bosPanel1.Controls.Add(this.fld_dteFromDate);
            this.bosPanel1.Controls.Add(this.fld_txtARCreditNoteNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(811, 69);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Location = new System.Drawing.Point(731, 5);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(75, 27);
            this.fld_btnFind.TabIndex = 5;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = null;
            this.fld_dteToDate.BOSDataSource = null;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(362, 38);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 4;
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = null;
            this.fld_dteFromDate.BOSDataSource = null;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(116, 38);
            this.fld_dteFromDate.MenuManager = this.screenToolbar;
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 3;
            // 
            // fld_txtARCreditNoteNo
            // 
            this.fld_txtARCreditNoteNo.BOSComment = null;
            this.fld_txtARCreditNoteNo.BOSDataMember = "";
            this.fld_txtARCreditNoteNo.BOSDataSource = "";
            this.fld_txtARCreditNoteNo.BOSDescription = null;
            this.fld_txtARCreditNoteNo.BOSError = null;
            this.fld_txtARCreditNoteNo.BOSFieldGroup = null;
            this.fld_txtARCreditNoteNo.BOSFieldRelation = null;
            this.fld_txtARCreditNoteNo.BOSPrivilege = null;
            this.fld_txtARCreditNoteNo.BOSPropertyName = "";
            this.fld_txtARCreditNoteNo.Location = new System.Drawing.Point(116, 12);
            this.fld_txtARCreditNoteNo.MenuManager = this.screenToolbar;
            this.fld_txtARCreditNoteNo.Name = "fld_txtARCreditNoteNo";
            this.fld_txtARCreditNoteNo.Screen = null;
            this.fld_txtARCreditNoteNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCreditNoteNo.TabIndex = 1;
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(362, 12);
            this.fld_lkeFK_ARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "Điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactAddressLine3", "Địa chỉ liên lạc")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 2;
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
            this.bosLabel4.Location = new System.Drawing.Point(289, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(20, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Đến";
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
            this.bosLabel3.Location = new System.Drawing.Point(15, 41);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(85, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Ngày lập phiếu từ";
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
            this.bosLabel2.Location = new System.Drawing.Point(289, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(56, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Khách hàng";
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(43, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Mã phiếu";
            // 
            // fld_dgcCreditNotes
            // 
            this.fld_dgcCreditNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcCreditNotes.BOSComment = null;
            this.fld_dgcCreditNotes.BOSDataMember = null;
            this.fld_dgcCreditNotes.BOSDataSource = "ARCreditNotes";
            this.fld_dgcCreditNotes.BOSDescription = null;
            this.fld_dgcCreditNotes.BOSError = null;
            this.fld_dgcCreditNotes.BOSFieldGroup = null;
            this.fld_dgcCreditNotes.BOSFieldRelation = null;
            this.fld_dgcCreditNotes.BOSGridType = null;
            this.fld_dgcCreditNotes.BOSPrivilege = null;
            this.fld_dgcCreditNotes.BOSPropertyName = null;
            this.fld_dgcCreditNotes.Location = new System.Drawing.Point(0, 71);
            this.fld_dgcCreditNotes.MenuManager = this.screenToolbar;
            this.fld_dgcCreditNotes.Name = "fld_dgcCreditNotes";
            this.fld_dgcCreditNotes.Screen = null;
            this.fld_dgcCreditNotes.Size = new System.Drawing.Size(811, 395);
            this.fld_dgcCreditNotes.TabIndex = 2;
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
            this.fld_btnClose.Location = new System.Drawing.Point(724, 481);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Đóng";
            // 
            // guiGiftVoucherList
            // 
            this.AcceptButton = this.fld_btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(811, 520);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_dgcCreditNotes);
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiGiftVoucherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách phiếu quà tặng";
            this.Load += new System.EventHandler(this.guiGiftVoucherList_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcCreditNotes, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCreditNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private CreditNoteGridControl fld_dgcCreditNotes;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSTextBox fld_txtARCreditNoteNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
    }
}