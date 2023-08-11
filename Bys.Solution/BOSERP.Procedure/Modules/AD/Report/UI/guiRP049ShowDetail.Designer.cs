namespace BOSERP.Modules.Report
{
    partial class guiRP049ShowDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiRP049ShowDetail));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.label_GECurrencyName = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP049DetailACDocumentEntrys = new BOSERP.Modules.Report.RP049DetailACDocumentEntrysGridControl();
            this.label_ObjectName = new BOSComponent.BOSLabel(this.components);
            this.label_FromDateToDate = new BOSComponent.BOSLabel(this.components);
            this.Title = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP049DetailACDocumentEntrys)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_btnExportExcel);
            this.bosPanel1.Controls.Add(this.label_GECurrencyName);
            this.bosPanel1.Controls.Add(this.fld_dgcRP049DetailACDocumentEntrys);
            this.bosPanel1.Controls.Add(this.label_ObjectName);
            this.bosPanel1.Controls.Add(this.label_FromDateToDate);
            this.bosPanel1.Controls.Add(this.Title);
            this.bosPanel1.Controls.Add(this.fld_btnOK);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1184, 331);
            this.bosPanel1.TabIndex = 6;
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
            this.fld_btnExportExcel.Location = new System.Drawing.Point(1014, 301);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportExcel, true);
            this.fld_btnExportExcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportExcel.TabIndex = 10;
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // label_GECurrencyName
            // 
            this.label_GECurrencyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_GECurrencyName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GECurrencyName.Appearance.Options.UseFont = true;
            this.label_GECurrencyName.BOSComment = null;
            this.label_GECurrencyName.BOSDataMember = null;
            this.label_GECurrencyName.BOSDataSource = null;
            this.label_GECurrencyName.BOSDescription = null;
            this.label_GECurrencyName.BOSError = null;
            this.label_GECurrencyName.BOSFieldGroup = null;
            this.label_GECurrencyName.BOSFieldRelation = null;
            this.label_GECurrencyName.BOSPrivilege = null;
            this.label_GECurrencyName.BOSPropertyName = null;
            this.label_GECurrencyName.Location = new System.Drawing.Point(1050, 67);
            this.label_GECurrencyName.Name = "label_GECurrencyName";
            this.label_GECurrencyName.Screen = null;
            this.label_GECurrencyName.Size = new System.Drawing.Size(49, 16);
            this.label_GECurrencyName.TabIndex = 9;
            this.label_GECurrencyName.Text = "Tiền tệ: ";
            // 
            // fld_dgcRP049DetailACDocumentEntrys
            // 
            this.fld_dgcRP049DetailACDocumentEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP049DetailACDocumentEntrys.BOSComment = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSDataMember = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSDataSource = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSDescription = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSError = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSGridType = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcRP049DetailACDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcRP049DetailACDocumentEntrys.Location = new System.Drawing.Point(3, 89);
            this.fld_dgcRP049DetailACDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcRP049DetailACDocumentEntrys.Name = "fld_dgcRP049DetailACDocumentEntrys";
            this.fld_dgcRP049DetailACDocumentEntrys.PrintReport = false;
            this.fld_dgcRP049DetailACDocumentEntrys.RowHandle = 0;
            this.fld_dgcRP049DetailACDocumentEntrys.Screen = null;
            this.fld_dgcRP049DetailACDocumentEntrys.Size = new System.Drawing.Size(1178, 206);
            this.fld_dgcRP049DetailACDocumentEntrys.TabIndex = 8;
            // 
            // label_ObjectName
            // 
            this.label_ObjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ObjectName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ObjectName.Appearance.Options.UseFont = true;
            this.label_ObjectName.BOSComment = null;
            this.label_ObjectName.BOSDataMember = null;
            this.label_ObjectName.BOSDataSource = null;
            this.label_ObjectName.BOSDescription = null;
            this.label_ObjectName.BOSError = null;
            this.label_ObjectName.BOSFieldGroup = null;
            this.label_ObjectName.BOSFieldRelation = null;
            this.label_ObjectName.BOSPrivilege = null;
            this.label_ObjectName.BOSPropertyName = null;
            this.label_ObjectName.Location = new System.Drawing.Point(12, 67);
            this.label_ObjectName.Name = "label_ObjectName";
            this.label_ObjectName.Screen = null;
            this.label_ObjectName.Size = new System.Drawing.Size(65, 16);
            this.label_ObjectName.TabIndex = 7;
            this.label_ObjectName.Text = "Đối tượng: ";
            // 
            // label_FromDateToDate
            // 
            this.label_FromDateToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FromDateToDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromDateToDate.Appearance.Options.UseFont = true;
            this.label_FromDateToDate.BOSComment = null;
            this.label_FromDateToDate.BOSDataMember = null;
            this.label_FromDateToDate.BOSDataSource = null;
            this.label_FromDateToDate.BOSDescription = null;
            this.label_FromDateToDate.BOSError = null;
            this.label_FromDateToDate.BOSFieldGroup = null;
            this.label_FromDateToDate.BOSFieldRelation = null;
            this.label_FromDateToDate.BOSPrivilege = null;
            this.label_FromDateToDate.BOSPropertyName = null;
            this.label_FromDateToDate.Location = new System.Drawing.Point(575, 51);
            this.label_FromDateToDate.Name = "label_FromDateToDate";
            this.label_FromDateToDate.Screen = null;
            this.label_FromDateToDate.Size = new System.Drawing.Size(148, 16);
            this.label_FromDateToDate.TabIndex = 4;
            this.label_FromDateToDate.Text = "Từ ngày                    đến";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Appearance.Options.UseFont = true;
            this.Title.BOSComment = null;
            this.Title.BOSDataMember = null;
            this.Title.BOSDataSource = null;
            this.Title.BOSDescription = null;
            this.Title.BOSError = null;
            this.Title.BOSFieldGroup = null;
            this.Title.BOSFieldRelation = null;
            this.Title.BOSPrivilege = null;
            this.Title.BOSPropertyName = null;
            this.Title.Location = new System.Drawing.Point(520, 12);
            this.Title.Name = "Title";
            this.Title.Screen = null;
            this.Title.Size = new System.Drawing.Size(331, 33);
            this.Title.TabIndex = 2;
            this.Title.Text = "Chi tiết công nợ phải thu";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(1095, 301);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(86, 27);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đóng";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // guiRP049ShowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 331);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiRP049ShowDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết công nợ phải thu";
            this.Load += new System.EventHandler(this.guiRP049Show_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP049DetailACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSLabel label_FromDateToDate;
        private BOSComponent.BOSLabel Title;
        private BOSComponent.BOSLabel label_ObjectName;
        private RP049DetailACDocumentEntrysGridControl fld_dgcRP049DetailACDocumentEntrys;
        private System.Windows.Forms.PrintDialog printDialog1;
        private BOSComponent.BOSLabel label_GECurrencyName;
        private BOSComponent.BOSButton fld_btnExportExcel;
    }
}