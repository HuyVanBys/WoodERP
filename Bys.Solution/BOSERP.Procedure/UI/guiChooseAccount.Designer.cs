namespace BOSERP
{
    partial class guiChooseAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiChooseAccount));
            this.fld_dgcACDocTypeEntryAccounts = new BOSERP.ACDocTypeEntryAccountsGridControl();
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntryAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACDocTypeEntryAccounts
            // 
            this.fld_dgcACDocTypeEntryAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDocTypeEntryAccounts.BOSComment = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSDataMember = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSDataSource = "ACDocTypeEntryAccounts";
            this.fld_dgcACDocTypeEntryAccounts.BOSDescription = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSError = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSFieldGroup = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSFieldRelation = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSGridType = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSPrivilege = null;
            this.fld_dgcACDocTypeEntryAccounts.BOSPropertyName = null;
            this.fld_dgcACDocTypeEntryAccounts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocTypeEntryAccounts.MenuManager = this.screenToolbar;
            this.fld_dgcACDocTypeEntryAccounts.Name = "fld_dgcACDocTypeEntryAccounts";
            this.fld_dgcACDocTypeEntryAccounts.Screen = null;
            this.fld_dgcACDocTypeEntryAccounts.Size = new System.Drawing.Size(612, 346);
            this.fld_dgcACDocTypeEntryAccounts.TabIndex = 6;
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnOK.Appearance.Options.UseForeColor = true;
            this.fld_btnOK.BOSComment = "";
            this.fld_btnOK.BOSDataMember = "";
            this.fld_btnOK.BOSDataSource = "";
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = "";
            this.fld_btnOK.BOSFieldRelation = "";
            this.fld_btnOK.BOSPrivilege = "";
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(447, 356);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 25);
            this.fld_btnOK.TabIndex = 10;
            this.fld_btnOK.Tag = "";
            this.fld_btnOK.Text = "Chọn";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancel.Appearance.Options.UseForeColor = true;
            this.fld_btnCancel.BOSComment = "";
            this.fld_btnCancel.BOSDataMember = "";
            this.fld_btnCancel.BOSDataSource = "";
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = "";
            this.fld_btnCancel.BOSFieldRelation = "";
            this.fld_btnCancel.BOSPrivilege = "";
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(531, 356);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 25);
            this.fld_btnCancel.TabIndex = 11;
            this.fld_btnCancel.Tag = "";
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // guiChooseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 390);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_dgcACDocTypeEntryAccounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiChooseAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tài khoản";
            this.Load += new System.EventHandler(this.guiChooseAccount_Load);
            this.Controls.SetChildIndex(this.fld_dgcACDocTypeEntryAccounts, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocTypeEntryAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACDocTypeEntryAccountsGridControl fld_dgcACDocTypeEntryAccounts;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;

    }
}