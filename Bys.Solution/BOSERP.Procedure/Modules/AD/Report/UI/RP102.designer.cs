namespace BOSERP.Modules.Report
{
    partial class RP102
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP102));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.RP143ACDocuments = new BOSERP.Modules.Report.RP143ACDocumentsGridControl();
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RP143ACDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_dteSearchToARInvoiceDate
            // 
            this.fld_dteSearchToARInvoiceDate.BOSComment = null;
            this.fld_dteSearchToARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchToARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchToARInvoiceDate.BOSError = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchToARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchToARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchToARInvoiceDate.EditValue = null;
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(330, 5);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 5;
            this.fld_dteSearchToARInvoiceDate.Tag = "SC";
            // 
            // fld_dteSearchFromARInvoiceDate
            // 
            this.fld_dteSearchFromARInvoiceDate.BOSComment = null;
            this.fld_dteSearchFromARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchFromARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchFromARInvoiceDate.BOSError = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchFromARInvoiceDate.EditValue = null;
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(85, 5);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 4;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(666, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(93, 27);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(265, 8);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(47, 13);
            this.BOSLabel2.TabIndex = 10;
            this.BOSLabel2.Text = "Đến ngày";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(14, 8);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 8;
            this.BOSLabel1.Text = "Từ ngày";
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
            this.fld_lblTitle.Location = new System.Drawing.Point(290, 48);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(190, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Tag = "HD";
            this.fld_lblTitle.Text = "BÁO CÁO TIỀN SỞ HỮU";
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
            this.fld_btnClose.Location = new System.Drawing.Point(681, 425);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 6;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnExportExcel
            // 
            this.fld_btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportExcel.BOSComment = null;
            this.fld_btnExportExcel.BOSDataMember = null;
            this.fld_btnExportExcel.BOSDataSource = null;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = null;
            this.fld_btnExportExcel.BOSFieldRelation = null;
            this.fld_btnExportExcel.BOSPrivilege = null;
            this.fld_btnExportExcel.BOSPropertyName = null;
            this.fld_btnExportExcel.Location = new System.Drawing.Point(600, 425);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportExcel.TabIndex = 5;
            this.fld_btnExportExcel.Text = "Xuất Excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // RP143ACDocuments
            // 
            this.RP143ACDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RP143ACDocuments.BOSComment = null;
            this.RP143ACDocuments.BOSDataMember = null;
            this.RP143ACDocuments.BOSDataSource = "ACDocuments";
            this.RP143ACDocuments.BOSDescription = null;
            this.RP143ACDocuments.BOSError = null;
            this.RP143ACDocuments.BOSFieldGroup = null;
            this.RP143ACDocuments.BOSFieldRelation = null;
            this.RP143ACDocuments.BOSGridType = null;
            this.RP143ACDocuments.BOSPrivilege = null;
            this.RP143ACDocuments.BOSPropertyName = null;
            this.RP143ACDocuments.Location = new System.Drawing.Point(12, 95);
            this.RP143ACDocuments.Name = "RP143ACDocuments";
            this.RP143ACDocuments.PrintReport = false;
            this.RP143ACDocuments.Screen = null;
            this.RP143ACDocuments.Size = new System.Drawing.Size(744, 324);
            this.RP143ACDocuments.TabIndex = 0;
            this.RP143ACDocuments.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblFromdateTodate.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(358, 73);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(0, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            // 
            // RP102
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnExportExcel);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.RP143ACDocuments);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP102";
            this.Tag = "SS";
            this.Text = "Báo cáo tiền sở hữu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP001_Load);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.RP143ACDocuments, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnExportExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RP143ACDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExportExcel;
        private RP143ACDocumentsGridControl RP143ACDocuments;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;

    }
}