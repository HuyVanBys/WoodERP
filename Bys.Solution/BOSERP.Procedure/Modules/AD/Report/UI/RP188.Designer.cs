namespace BOSERP.Modules.Report
{
    partial class RP188
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP188));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPInvoiceInID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblFrom = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptCDITems = new BOSERP.Modules.Report.RP143SaleOrdersGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptCDITems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosLabel11);
            this.panelControl1.Controls.Add(this.fld_lkeAPInvoiceInID);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.fld_lblFrom);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 90);
            this.panelControl1.TabIndex = 0;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(12, 41);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 359;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel11.Text = "Hóa đơn";
            // 
            // fld_lkeAPInvoiceInID
            // 
            this.fld_lkeAPInvoiceInID.BOSAllowAddNew = false;
            this.fld_lkeAPInvoiceInID.BOSAllowDummy = true;
            this.fld_lkeAPInvoiceInID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSDataSource = "APInvoiceIns";
            this.fld_lkeAPInvoiceInID.BOSDescription = null;
            this.fld_lkeAPInvoiceInID.BOSError = null;
            this.fld_lkeAPInvoiceInID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSPropertyName = "EditValue";
            this.fld_lkeAPInvoiceInID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.Location = new System.Drawing.Point(89, 38);
            this.fld_lkeAPInvoiceInID.Name = "fld_lkeAPInvoiceInID";
            this.fld_lkeAPInvoiceInID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPInvoiceInID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPInvoiceInID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPInvoiceInID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPInvoiceInID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPInvoiceInID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APInvoiceInNo", "Mã hóa đơn")});
            this.fld_lkeAPInvoiceInID.Properties.DisplayMember = "APInvoiceInNo";
            this.fld_lkeAPInvoiceInID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPInvoiceInID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPInvoiceInID.Properties.ValueMember = "APInvoiceInID";
            this.fld_lkeAPInvoiceInID.Screen = null;
            this.fld_lkeAPInvoiceInID.Size = new System.Drawing.Size(164, 20);
            this.fld_lkeAPInvoiceInID.TabIndex = 360;
            this.fld_lkeAPInvoiceInID.Tag = "DC";
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
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(364, 9);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(164, 20);
            this.fld_dteSearchToDate.TabIndex = 6;
            this.fld_dteSearchToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(278, 12);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 353;
            this.bosLabel9.Text = "Đến ngày";
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
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(89, 9);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(164, 20);
            this.fld_dteSearchFromDate.TabIndex = 5;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_lblFrom
            // 
            this.fld_lblFrom.BOSComment = null;
            this.fld_lblFrom.BOSDataMember = null;
            this.fld_lblFrom.BOSDataSource = null;
            this.fld_lblFrom.BOSDescription = null;
            this.fld_lblFrom.BOSError = null;
            this.fld_lblFrom.BOSFieldGroup = null;
            this.fld_lblFrom.BOSFieldRelation = null;
            this.fld_lblFrom.BOSPrivilege = null;
            this.fld_lblFrom.BOSPropertyName = null;
            this.fld_lblFrom.Location = new System.Drawing.Point(12, 12);
            this.fld_lblFrom.Name = "fld_lblFrom";
            this.fld_lblFrom.Screen = null;
            this.fld_lblFrom.Size = new System.Drawing.Size(40, 13);
            this.fld_lblFrom.TabIndex = 11;
            this.fld_lblFrom.Text = "Từ ngày";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(427, 41);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(101, 30);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(217, 107);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(453, 19);
            this.fld_lblTitle.TabIndex = 8;
            this.fld_lblTitle.Text = "BÁO CÁO SO SÁNH KHỐI LƯỢNG HÓA ĐƠN VÀ THỰC TẾ";
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
            this.fld_btnClose.Location = new System.Drawing.Point(837, 438);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lbl_FromdateTodate
            // 
            this.fld_lbl_FromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lbl_FromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lbl_FromdateTodate.BOSComment = null;
            this.fld_lbl_FromdateTodate.BOSDataMember = null;
            this.fld_lbl_FromdateTodate.BOSDataSource = null;
            this.fld_lbl_FromdateTodate.BOSDescription = null;
            this.fld_lbl_FromdateTodate.BOSError = null;
            this.fld_lbl_FromdateTodate.BOSFieldGroup = null;
            this.fld_lbl_FromdateTodate.BOSFieldRelation = null;
            this.fld_lbl_FromdateTodate.BOSPrivilege = null;
            this.fld_lbl_FromdateTodate.BOSPropertyName = null;
            this.fld_lbl_FromdateTodate.Location = new System.Drawing.Point(382, 168);
            this.fld_lbl_FromdateTodate.Name = "fld_lbl_FromdateTodate";
            this.fld_lbl_FromdateTodate.Screen = null;
            this.fld_lbl_FromdateTodate.Size = new System.Drawing.Size(0, 16);
            this.fld_lbl_FromdateTodate.TabIndex = 11;
            // 
            // fld_btnExcel
            // 
            this.fld_btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExcel.BOSComment = null;
            this.fld_btnExcel.BOSDataMember = null;
            this.fld_btnExcel.BOSDataSource = null;
            this.fld_btnExcel.BOSDescription = null;
            this.fld_btnExcel.BOSError = null;
            this.fld_btnExcel.BOSFieldGroup = null;
            this.fld_btnExcel.BOSFieldRelation = null;
            this.fld_btnExcel.BOSPrivilege = null;
            this.fld_btnExcel.BOSPropertyName = null;
            this.fld_btnExcel.Location = new System.Drawing.Point(756, 438);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExcel.TabIndex = 1;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // fld_dgcICReceiptCDITems
            // 
            this.fld_dgcICReceiptCDITems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptCDITems.BOSComment = null;
            this.fld_dgcICReceiptCDITems.BOSDataMember = null;
            this.fld_dgcICReceiptCDITems.BOSDataSource = "ICReceiptCDItems";
            this.fld_dgcICReceiptCDITems.BOSDescription = null;
            this.fld_dgcICReceiptCDITems.BOSError = null;
            this.fld_dgcICReceiptCDITems.BOSFieldGroup = null;
            this.fld_dgcICReceiptCDITems.BOSFieldRelation = null;
            this.fld_dgcICReceiptCDITems.BOSGridType = null;
            this.fld_dgcICReceiptCDITems.BOSPrivilege = null;
            this.fld_dgcICReceiptCDITems.BOSPropertyName = null;
            this.fld_dgcICReceiptCDITems.Location = new System.Drawing.Point(-2, 145);
            this.fld_dgcICReceiptCDITems.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptCDITems.Name = "fld_dgcICReceiptCDITems";
            this.fld_dgcICReceiptCDITems.PrintReport = false;
            this.fld_dgcICReceiptCDITems.Screen = null;
            this.fld_dgcICReceiptCDITems.Size = new System.Drawing.Size(927, 287);
            this.fld_dgcICReceiptCDITems.TabIndex = 12;
            // 
            // RP188
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 477);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcICReceiptCDITems);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_lbl_FromdateTodate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP188";
            this.Tag = "SS";
            this.Text = "Báo cáo so sánh khối lượng hóa đơn và thực tế";
            this.Load += new System.EventHandler(this.RP188_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_btnExcel, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceiptCDITems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPInvoiceInID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptCDITems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblFrom;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel fld_lbl_FromdateTodate;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeAPInvoiceInID;
        private RP143SaleOrdersGridControl fld_dgcICReceiptCDITems;
    }
}