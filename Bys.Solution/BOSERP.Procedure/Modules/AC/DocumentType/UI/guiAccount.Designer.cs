namespace BOSERP.Modules.ACDocumentType
{
    partial class guiAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAccount));
            this.fld_trlACAccounts = new BOSERP.Modules.ACDocumentType.AccountTreeListControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlACAccounts)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_trlACAccounts
            // 
            this.fld_trlACAccounts.BOSComment = null;
            this.fld_trlACAccounts.BOSDataMember = null;
            this.fld_trlACAccounts.BOSDataSource = "ACAccounts";
            this.fld_trlACAccounts.BOSDescription = null;
            this.fld_trlACAccounts.BOSDisplayOption = true;
            this.fld_trlACAccounts.BOSDisplayRoot = false;
            this.fld_trlACAccounts.BOSError = null;
            this.fld_trlACAccounts.BOSFieldGroup = null;
            this.fld_trlACAccounts.BOSFieldRelation = null;
            this.fld_trlACAccounts.BOSPrivilege = null;
            this.fld_trlACAccounts.BOSPropertyName = null;
            this.fld_trlACAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlACAccounts.Location = new System.Drawing.Point(0, 0);
            this.fld_trlACAccounts.Name = "fld_trlACAccounts";
            this.fld_trlACAccounts.OptionsView.AutoCalcPreviewLineCount = true;
            this.fld_trlACAccounts.Screen = null;
            this.fld_trlACAccounts.Size = new System.Drawing.Size(594, 420);
            this.fld_trlACAccounts.TabIndex = 6;
            this.fld_trlACAccounts.Tag = "DC";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_btnCancel);
            this.bosPanel2.Controls.Add(this.fld_btnSave);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel2.Location = new System.Drawing.Point(0, 420);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(594, 52);
            this.bosPanel2.TabIndex = 8;
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.Location = new System.Drawing.Point(507, 13);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 1;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(409, 13);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 0;
            this.fld_btnSave.Text = "Đồng ý";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.bosPanel1.Controls.Add(this.fld_trlACAccounts);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(594, 420);
            this.bosPanel1.TabIndex = 9;
            // 
            // guiAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.bosPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hệ thống tài khoản";
            this.Load += new System.EventHandler(this.guiAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlACAccounts)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AccountTreeListControl fld_trlACAccounts;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSPanel bosPanel1;
    }
}