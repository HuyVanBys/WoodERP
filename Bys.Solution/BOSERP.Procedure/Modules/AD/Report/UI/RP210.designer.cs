﻿namespace BOSERP.Modules.Report
{
    partial class RP210
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
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeGECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnPrint.Location = new System.Drawing.Point(333, 85);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 8;
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
            this.fld_btnClose.Location = new System.Drawing.Point(414, 85);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 9;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosPanel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosPanel1.Appearance.Options.UseBackColor = true;
            this.bosPanel1.Appearance.Options.UseForeColor = true;
            this.bosPanel1.Controls.Add(this.fld_lkeGECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeBRBranchID);
            this.bosPanel1.Controls.Add(this.fld_btnPrint);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Controls.Add(this.fld_lkeACAccountID);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(521, 123);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            // 
            // fld_lkeGECurrencyID
            // 
            this.fld_lkeGECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeGECurrencyID.BOSAllowDummy = true;
            this.fld_lkeGECurrencyID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSDataMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.BOSDataSource = "GECurrencies";
            this.fld_lkeGECurrencyID.BOSDescription = null;
            this.fld_lkeGECurrencyID.BOSError = null;
            this.fld_lkeGECurrencyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeGECurrencyID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.Location = new System.Drawing.Point(339, 39);
            this.fld_lkeGECurrencyID.Name = "fld_lkeGECurrencyID";
            this.fld_lkeGECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeGECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeGECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeGECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeGECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeGECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeGECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.Screen = null;
            this.fld_lkeGECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGECurrencyID.TabIndex = 6;
            this.fld_lkeGECurrencyID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(265, 42);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(53, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Text = "Loại tiền tệ";
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(91, 39);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 4;
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
            this.bosLabel6.Location = new System.Drawing.Point(14, 42);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 11;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // fld_lkeACAccountID
            // 
            this.fld_lkeACAccountID.BOSAllowAddNew = false;
            this.fld_lkeACAccountID.BOSAllowDummy = true;
            this.fld_lkeACAccountID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSDataMember = "ACAccountID";
            this.fld_lkeACAccountID.BOSDataSource = "ACAccounts";
            this.fld_lkeACAccountID.BOSDescription = null;
            this.fld_lkeACAccountID.BOSError = null;
            this.fld_lkeACAccountID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeACAccountID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Location = new System.Drawing.Point(91, 65);
            this.fld_lkeACAccountID.Name = "fld_lkeACAccountID";
            this.fld_lkeACAccountID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACAccountID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACAccountID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACAccountID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountType", "Tính chất"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountPostingRule", "Cách định khoản")});
            this.fld_lkeACAccountID.Properties.DisplayMember = "ACAccountName";
            this.fld_lkeACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeACAccountID.Screen = null;
            this.fld_lkeACAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAccountID.TabIndex = 7;
            this.fld_lkeACAccountID.Tag = "DC";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(91, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(14, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Từ ngày";
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
            this.bosLabel2.Location = new System.Drawing.Point(14, 68);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Tài khoản";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(265, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 2;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(339, 12);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 3;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // RP210
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(521, 124);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP210";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ chữ T tài khoản";
            this.Load += new System.EventHandler(this.RP210_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeACAccountID;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeGECurrencyID;
        private BOSComponent.BOSLabel bosLabel1;
    }
}