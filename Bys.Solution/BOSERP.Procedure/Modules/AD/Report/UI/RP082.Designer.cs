namespace BOSERP.Modules.Report
{
    partial class RP082
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
            this.fld_lkeACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
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
            this.bosLabel1.Location = new System.Drawing.Point(19, 27);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(79, 13);
            this.bosLabel1.TabIndex = 1;
            this.bosLabel1.Text = "Chọn khoản mục";
            // 
            // fld_lkeACSegmentID
            // 
            this.fld_lkeACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeACSegmentID.BOSAllowDummy = true;
            this.fld_lkeACSegmentID.BOSComment = null;
            this.fld_lkeACSegmentID.BOSDataMember = "ACSegmentID";
            this.fld_lkeACSegmentID.BOSDataSource = "ACSegments";
            this.fld_lkeACSegmentID.BOSDescription = null;
            this.fld_lkeACSegmentID.BOSError = null;
            this.fld_lkeACSegmentID.BOSFieldGroup = null;
            this.fld_lkeACSegmentID.BOSFieldParent = null;
            this.fld_lkeACSegmentID.BOSFieldRelation = null;
            this.fld_lkeACSegmentID.BOSPrivilege = null;
            this.fld_lkeACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeACSegmentID.BOSSelectType = null;
            this.fld_lkeACSegmentID.BOSSelectTypeValue = null;
            this.fld_lkeACSegmentID.CurrentDisplayText = null;
            this.fld_lkeACSegmentID.Location = new System.Drawing.Point(110, 24);
            this.fld_lkeACSegmentID.Name = "fld_lkeACSegmentID";
            this.fld_lkeACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentNo", "Khoản mục"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Tên khoản mục")});
            this.fld_lkeACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeACSegmentID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeACSegmentID.Screen = null;
            this.fld_lkeACSegmentID.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeACSegmentID.TabIndex = 5;
            this.fld_lkeACSegmentID.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(19, 79);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 1;
            this.bosLabel2.Text = "Đối tượng";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(107, 118);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 11;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(188, 118);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 12;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ACObjects";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(110, 76);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 13;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(110, 50);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeBRBranchID.TabIndex = 16;
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
            this.bosLabel6.Location = new System.Drawing.Point(19, 53);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 17;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // RP082
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 157);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeBRBranchID);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_lkeACSegmentID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Name = "RP082";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo khoản mục";
            this.Load += new System.EventHandler(this.RP082_Load);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeACSegmentID, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.fld_lkeACObjectAccessKey, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeBRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeACSegmentID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel6;
    }
}