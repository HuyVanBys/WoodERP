namespace BOSERP.Modules.Report
{
    partial class RP102Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP102Item));
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.RP143ACDocumentItems = new BOSERP.Modules.Report.RP143ACDocumentsGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RP143ACDocumentItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(633, 359);
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
            this.fld_btnExportExcel.Location = new System.Drawing.Point(552, 359);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportExcel.TabIndex = 5;
            this.fld_btnExportExcel.Text = "Xuất Excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // RP143ACDocumentItems
            // 
            this.RP143ACDocumentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RP143ACDocumentItems.BOSComment = null;
            this.RP143ACDocumentItems.BOSDataMember = null;
            this.RP143ACDocumentItems.BOSDataSource = "ACDocuments";
            this.RP143ACDocumentItems.BOSDescription = null;
            this.RP143ACDocumentItems.BOSError = null;
            this.RP143ACDocumentItems.BOSFieldGroup = null;
            this.RP143ACDocumentItems.BOSFieldRelation = null;
            this.RP143ACDocumentItems.BOSGridType = null;
            this.RP143ACDocumentItems.BOSPrivilege = null;
            this.RP143ACDocumentItems.BOSPropertyName = null;
            this.RP143ACDocumentItems.Location = new System.Drawing.Point(3, 3);
            this.RP143ACDocumentItems.Name = "RP143ACDocumentItems";
            this.RP143ACDocumentItems.PrintReport = false;
            this.RP143ACDocumentItems.Screen = null;
            this.RP143ACDocumentItems.Size = new System.Drawing.Size(714, 350);
            this.RP143ACDocumentItems.TabIndex = 0;
            this.RP143ACDocumentItems.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
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
            this.bosPanel1.Controls.Add(this.RP143ACDocumentItems);
            this.bosPanel1.Controls.Add(this.fld_btnClose);
            this.bosPanel1.Controls.Add(this.fld_btnExportExcel);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(720, 398);
            this.bosPanel1.TabIndex = 7;
            // 
            // RP143Item
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 398);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP143Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Báo cáo tiền sở hữu";
            this.Load += new System.EventHandler(this.RP001_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RP143ACDocumentItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExportExcel;
        private RP143ACDocumentsGridControl RP143ACDocumentItems;
        private BOSComponent.BOSPanel bosPanel1;

    }
}