namespace BOSERP.Modules.Report
{
    partial class RP089
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP089));
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.Report.RP089GridControl();
            this.fld_btnExportFile = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblTitle.Location = new System.Drawing.Point(413, 11);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(181, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Tag = "HD";
            this.fld_lblTitle.Text = "DANH SÁCH HÓA ĐƠN";
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
            this.fld_btnClose.Location = new System.Drawing.Point(948, 637);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 6;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblFromdateTodate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(413, 35);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(28, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            this.fld_lblFromdateTodate.Text = "Text";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACDocumentEntrys.BOSComment = null;
            this.fld_dgcACDocumentEntrys.BOSDataMember = null;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcACDocumentEntrys.GridViewMain = null;
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(12, 57);
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1011, 574);
            this.fld_dgcACDocumentEntrys.TabIndex = 4;
            this.fld_dgcACDocumentEntrys.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // fld_btnExportFile
            // 
            this.fld_btnExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportFile.BOSComment = null;
            this.fld_btnExportFile.BOSDataMember = null;
            this.fld_btnExportFile.BOSDataSource = null;
            this.fld_btnExportFile.BOSDescription = null;
            this.fld_btnExportFile.BOSError = null;
            this.fld_btnExportFile.BOSFieldGroup = null;
            this.fld_btnExportFile.BOSFieldRelation = null;
            this.fld_btnExportFile.BOSPrivilege = null;
            this.fld_btnExportFile.BOSPropertyName = null;
            this.fld_btnExportFile.Location = new System.Drawing.Point(867, 637);
            this.fld_btnExportFile.Name = "fld_btnExportFile";
            this.fld_btnExportFile.Screen = null;
            this.fld_btnExportFile.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportFile.TabIndex = 6;
            this.fld_btnExportFile.Text = "Xuất excel";
            this.fld_btnExportFile.Click += new System.EventHandler(this.fld_btnExportFile_Click);
            // 
            // RP089
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 672);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnExportFile);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP089";
            this.Tag = "SS";
            this.Text = "Tổng hợp khấu hao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP089_Load);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_dgcACDocumentEntrys, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnExportFile, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
        private RP089GridControl fld_dgcACDocumentEntrys;
        private BOSComponent.BOSButton fld_btnExportFile;

    }
}