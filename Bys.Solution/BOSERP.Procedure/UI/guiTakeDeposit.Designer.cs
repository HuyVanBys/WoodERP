namespace BOSERP
{
    partial class guiTakeDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiTakeDeposit));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblMinimumDepositTitle = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblBalanceDue = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_txtBankAccount = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dtePaymentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medPaymentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtPaymentAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblMinimumDeposit = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblDepositBalance = new DevExpress.XtraEditors.LabelControl();
            this.fld_lblTotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBankAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPaymentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đã trả";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Còn lại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 211);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tiền thanh toán";
            // 
            // fld_lblMinimumDepositTitle
            // 
            this.fld_lblMinimumDepositTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblMinimumDepositTitle.Appearance.Options.UseFont = true;
            this.fld_lblMinimumDepositTitle.Location = new System.Drawing.Point(26, 143);
            this.fld_lblMinimumDepositTitle.Name = "fld_lblMinimumDepositTitle";
            this.fld_lblMinimumDepositTitle.Size = new System.Drawing.Size(113, 16);
            this.fld_lblMinimumDepositTitle.TabIndex = 2;
            this.fld_lblMinimumDepositTitle.Text = "Số tiền cọc tối thiểu";
            // 
            // fld_lblBalanceDue
            // 
            this.fld_lblBalanceDue.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblBalanceDue.Appearance.Options.UseFont = true;
            this.fld_lblBalanceDue.Location = new System.Drawing.Point(165, 104);
            this.fld_lblBalanceDue.Name = "fld_lblBalanceDue";
            this.fld_lblBalanceDue.Size = new System.Drawing.Size(75, 16);
            this.fld_lblBalanceDue.TabIndex = 3;
            this.fld_lblBalanceDue.Text = "labelControl5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_txtBankAccount);
            this.groupBox1.Controls.Add(this.fld_lkeBankID);
            this.groupBox1.Controls.Add(this.fld_dtePaymentDate);
            this.groupBox1.Controls.Add(this.fld_medPaymentDesc);
            this.groupBox1.Controls.Add(this.fld_txtPaymentAmount);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.fld_lblMinimumDeposit);
            this.groupBox1.Controls.Add(this.fld_lblDepositBalance);
            this.groupBox1.Controls.Add(this.fld_lblTotalAmount);
            this.groupBox1.Controls.Add(this.fld_lblBalanceDue);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.fld_lblMinimumDepositTitle);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thanh toán";
            // 
            // fld_txtBankAccount
            // 
            this.fld_txtBankAccount.BOSComment = null;
            this.fld_txtBankAccount.BOSDataMember = "";
            this.fld_txtBankAccount.BOSDataSource = "";
            this.fld_txtBankAccount.BOSDescription = null;
            this.fld_txtBankAccount.BOSError = null;
            this.fld_txtBankAccount.BOSFieldGroup = null;
            this.fld_txtBankAccount.BOSFieldRelation = null;
            this.fld_txtBankAccount.BOSPrivilege = null;
            this.fld_txtBankAccount.BOSPropertyName = "Text";
            this.fld_txtBankAccount.Location = new System.Drawing.Point(415, 236);
            this.fld_txtBankAccount.Name = "fld_txtBankAccount";
            this.fld_txtBankAccount.Screen = null;
            this.fld_txtBankAccount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBankAccount.TabIndex = 3;
            this.fld_txtBankAccount.Tag = "";
            // 
            // fld_lkeBankID
            // 
            this.fld_lkeBankID.BOSAllowAddNew = false;
            this.fld_lkeBankID.BOSAllowDummy = true;
            this.fld_lkeBankID.BOSComment = "";
            this.fld_lkeBankID.BOSDataMember = "CSCompanyBankID";
            this.fld_lkeBankID.BOSDataSource = "CSCompanyBanks";
            this.fld_lkeBankID.BOSDescription = null;
            this.fld_lkeBankID.BOSError = null;
            this.fld_lkeBankID.BOSFieldGroup = "";
            this.fld_lkeBankID.BOSFieldParent = "";
            this.fld_lkeBankID.BOSFieldRelation = "";
            this.fld_lkeBankID.BOSPrivilege = "";
            this.fld_lkeBankID.BOSPropertyName = "EditValue";
            this.fld_lkeBankID.BOSSelectType = "";
            this.fld_lkeBankID.BOSSelectTypeValue = "";
            this.fld_lkeBankID.CurrentDisplayText = null;
            this.fld_lkeBankID.Location = new System.Drawing.Point(165, 236);
            this.fld_lkeBankID.Name = "fld_lkeBankID";
            this.fld_lkeBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Ngân hàng")});
            this.fld_lkeBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeBankID.Properties.NullText = "";
            this.fld_lkeBankID.Properties.PopupWidth = 40;
            this.fld_lkeBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeBankID.Screen = null;
            this.fld_lkeBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBankID.TabIndex = 2;
            this.fld_lkeBankID.Tag = "";
            this.fld_lkeBankID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_CSCompanyBankID_CloseUp);
            // 
            // fld_dtePaymentDate
            // 
            this.fld_dtePaymentDate.BOSComment = null;
            this.fld_dtePaymentDate.BOSDataMember = null;
            this.fld_dtePaymentDate.BOSDataSource = null;
            this.fld_dtePaymentDate.BOSDescription = null;
            this.fld_dtePaymentDate.BOSError = null;
            this.fld_dtePaymentDate.BOSFieldGroup = null;
            this.fld_dtePaymentDate.BOSFieldRelation = null;
            this.fld_dtePaymentDate.BOSPrivilege = null;
            this.fld_dtePaymentDate.BOSPropertyName = null;
            this.fld_dtePaymentDate.EditValue = null;
            this.fld_dtePaymentDate.Location = new System.Drawing.Point(165, 184);
            this.fld_dtePaymentDate.MenuManager = this.screenToolbar;
            this.fld_dtePaymentDate.Name = "fld_dtePaymentDate";
            this.fld_dtePaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePaymentDate.Screen = null;
            this.fld_dtePaymentDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtePaymentDate.TabIndex = 0;
            // 
            // fld_medPaymentDesc
            // 
            this.fld_medPaymentDesc.BOSComment = null;
            this.fld_medPaymentDesc.BOSDataMember = null;
            this.fld_medPaymentDesc.BOSDataSource = null;
            this.fld_medPaymentDesc.BOSDescription = null;
            this.fld_medPaymentDesc.BOSError = null;
            this.fld_medPaymentDesc.BOSFieldGroup = null;
            this.fld_medPaymentDesc.BOSFieldRelation = null;
            this.fld_medPaymentDesc.BOSPrivilege = null;
            this.fld_medPaymentDesc.BOSPropertyName = null;
            this.fld_medPaymentDesc.Location = new System.Drawing.Point(165, 262);
            this.fld_medPaymentDesc.MenuManager = this.screenToolbar;
            this.fld_medPaymentDesc.Name = "fld_medPaymentDesc";
            this.fld_medPaymentDesc.Screen = null;
            this.fld_medPaymentDesc.Size = new System.Drawing.Size(400, 56);
            this.fld_medPaymentDesc.TabIndex = 4;
            // 
            // fld_txtPaymentAmount
            // 
            this.fld_txtPaymentAmount.Location = new System.Drawing.Point(165, 210);
            this.fld_txtPaymentAmount.Name = "fld_txtPaymentAmount";
            this.fld_txtPaymentAmount.Properties.Mask.EditMask = "n0";
            this.fld_txtPaymentAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtPaymentAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPaymentAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtPaymentAmount.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // fld_lblMinimumDeposit
            // 
            this.fld_lblMinimumDeposit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblMinimumDeposit.Appearance.Options.UseFont = true;
            this.fld_lblMinimumDeposit.Location = new System.Drawing.Point(165, 143);
            this.fld_lblMinimumDeposit.Name = "fld_lblMinimumDeposit";
            this.fld_lblMinimumDeposit.Size = new System.Drawing.Size(75, 16);
            this.fld_lblMinimumDeposit.TabIndex = 3;
            this.fld_lblMinimumDeposit.Text = "labelControl5";
            // 
            // fld_lblDepositBalance
            // 
            this.fld_lblDepositBalance.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblDepositBalance.Appearance.Options.UseFont = true;
            this.fld_lblDepositBalance.Location = new System.Drawing.Point(165, 67);
            this.fld_lblDepositBalance.Name = "fld_lblDepositBalance";
            this.fld_lblDepositBalance.Size = new System.Drawing.Size(75, 16);
            this.fld_lblDepositBalance.TabIndex = 3;
            this.fld_lblDepositBalance.Text = "labelControl5";
            // 
            // fld_lblTotalAmount
            // 
            this.fld_lblTotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.fld_lblTotalAmount.Appearance.Options.UseFont = true;
            this.fld_lblTotalAmount.Location = new System.Drawing.Point(165, 32);
            this.fld_lblTotalAmount.Name = "fld_lblTotalAmount";
            this.fld_lblTotalAmount.Size = new System.Drawing.Size(75, 16);
            this.fld_lblTotalAmount.TabIndex = 3;
            this.fld_lblTotalAmount.Text = "labelControl5";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 263);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 16);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Diễn giải";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Ngày thanh toán";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(341, 237);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 16);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Tài khoản";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 237);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Ngân hàng";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Location = new System.Drawing.Point(436, 348);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(517, 348);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiTakeDeposit
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(598, 385);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiTakeDeposit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thu tiền ứng trước";
            this.Load += new System.EventHandler(this.guiTakeDeposit_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBankAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPaymentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPaymentAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl fld_lblMinimumDepositTitle;
        private DevExpress.XtraEditors.LabelControl fld_lblBalanceDue;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit fld_txtPaymentAmount;
        private DevExpress.XtraEditors.LabelControl fld_lblMinimumDeposit;
        private DevExpress.XtraEditors.LabelControl fld_lblDepositBalance;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl fld_lblTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private BOSComponent.BOSMemoEdit fld_medPaymentDesc;
        private BOSComponent.BOSDateEdit fld_dtePaymentDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private BOSComponent.BOSTextBox fld_txtBankAccount;
        private BOSComponent.BOSLookupEdit fld_lkeBankID;
    }
}