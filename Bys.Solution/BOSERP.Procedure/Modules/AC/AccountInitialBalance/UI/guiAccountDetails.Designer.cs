namespace BOSERP.Modules.AccountInitialBalance
{
    partial class guiAccountDetails
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeGECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAccountDetails = new BOSERP.Modules.AccountInitialBalance.AccountDetailGridControl();
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAccountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 18);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Đối tượng";
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_lkeBRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeGECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(853, 55);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel3.Location = new System.Drawing.Point(514, 18);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 7;
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeGECurrencyID
            // 
            this.fld_lkeGECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeGECurrencyID.BOSAllowDummy = true;
            this.fld_lkeGECurrencyID.BOSComment = null;
            this.fld_lkeGECurrencyID.BOSDataMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.BOSDataSource = "GECurrencies";
            this.fld_lkeGECurrencyID.BOSDescription = null;
            this.fld_lkeGECurrencyID.BOSError = null;
            this.fld_lkeGECurrencyID.BOSFieldGroup = null;
            this.fld_lkeGECurrencyID.BOSFieldParent = null;
            this.fld_lkeGECurrencyID.BOSFieldRelation = null;
            this.fld_lkeGECurrencyID.BOSPrivilege = null;
            this.fld_lkeGECurrencyID.BOSPropertyName = null;
            this.fld_lkeGECurrencyID.BOSSelectType = null;
            this.fld_lkeGECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeGECurrencyID.CurrentDisplayText = null;
            this.fld_lkeGECurrencyID.Location = new System.Drawing.Point(329, 15);
            this.fld_lkeGECurrencyID.Name = "fld_lkeGECurrencyID";
            this.fld_lkeGECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeGECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeGECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.Screen = null;
            this.fld_lkeGECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGECurrencyID.TabIndex = 2;
            this.fld_lkeGECurrencyID.EditValueChanged += new System.EventHandler(this.fld_lkeGECurrencyID_EditValueChanged);
            // 
            // fld_lkeACObjectID
            // 
            this.fld_lkeACObjectID.BOSAllowAddNew = false;
            this.fld_lkeACObjectID.BOSAllowDummy = true;
            this.fld_lkeACObjectID.BOSComment = null;
            this.fld_lkeACObjectID.BOSDataMember = null;
            this.fld_lkeACObjectID.BOSDataSource = null;
            this.fld_lkeACObjectID.BOSDescription = null;
            this.fld_lkeACObjectID.BOSError = null;
            this.fld_lkeACObjectID.BOSFieldGroup = null;
            this.fld_lkeACObjectID.BOSFieldParent = null;
            this.fld_lkeACObjectID.BOSFieldRelation = null;
            this.fld_lkeACObjectID.BOSPrivilege = null;
            this.fld_lkeACObjectID.BOSPropertyName = null;
            this.fld_lkeACObjectID.BOSSelectType = null;
            this.fld_lkeACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeACObjectID.CurrentDisplayText = null;
            this.fld_lkeACObjectID.Location = new System.Drawing.Point(84, 15);
            this.fld_lkeACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeACObjectID.Name = "fld_lkeACObjectID";
            this.fld_lkeACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectID.Screen = null;
            this.fld_lkeACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectID.TabIndex = 1;
            this.fld_lkeACObjectID.EditValueChanged += new System.EventHandler(this.fld_lkeACObjectID_EditValueChanged);
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
            this.bosLabel2.Location = new System.Drawing.Point(257, 18);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_dgcAccountDetails
            // 
            this.fld_dgcAccountDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAccountDetails.BOSComment = null;
            this.fld_dgcAccountDetails.BOSDataMember = null;
            this.fld_dgcAccountDetails.BOSDataSource = "ACAccountDetails";
            this.fld_dgcAccountDetails.BOSDescription = null;
            this.fld_dgcAccountDetails.BOSError = null;
            this.fld_dgcAccountDetails.BOSFieldGroup = null;
            this.fld_dgcAccountDetails.BOSFieldRelation = null;
            this.fld_dgcAccountDetails.BOSGridType = null;
            this.fld_dgcAccountDetails.BOSPrivilege = null;
            this.fld_dgcAccountDetails.BOSPropertyName = null;
            this.fld_dgcAccountDetails.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcAccountDetails.MenuManager = this.screenToolbar;
            this.fld_dgcAccountDetails.Name = "fld_dgcAccountDetails";
            this.fld_dgcAccountDetails.PrintReport = false;
            this.fld_dgcAccountDetails.Screen = null;
            this.fld_dgcAccountDetails.Size = new System.Drawing.Size(850, 296);
            this.fld_dgcAccountDetails.TabIndex = 1;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(685, 371);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(766, 371);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(582, 15);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 3;
            // 
            // guiAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(853, 430);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnSave);
            this.Controls.Add(this.fld_dgcAccountDetails);
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiAccountDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiAccountDetails_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcAccountDetails, 0);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAccountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeGECurrencyID;
        private AccObjectLookupEdit fld_lkeACObjectID;
        private BOSComponent.BOSLabel bosLabel2;
        private AccountDetailGridControl fld_dgcAccountDetails;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
    }
}