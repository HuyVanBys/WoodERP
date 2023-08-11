namespace BOSERP.Modules.Report
{
    partial class guiRP049CurrencyShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiRP049CurrencyShow));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.label_Account = new BOSComponent.BOSLabel(this.components);
            this.label_FromDateToDate = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcRP049CurrencyACDocumentEntrys = new BOSERP.Modules.Report.RP049CurrencyACDocumentEntrysGridControl();
            this.Title = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP049CurrencyACDocumentEntrys)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.label_Account);
            this.bosPanel1.Controls.Add(this.label_FromDateToDate);
            this.bosPanel1.Controls.Add(this.fld_dgcRP049CurrencyACDocumentEntrys);
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
            this.fld_btnExportExcel.TabIndex = 7;
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // label_Account
            // 
            this.label_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Account.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Account.Appearance.Options.UseFont = true;
            this.label_Account.BOSComment = null;
            this.label_Account.BOSDataMember = null;
            this.label_Account.BOSDataSource = null;
            this.label_Account.BOSDescription = null;
            this.label_Account.BOSError = null;
            this.label_Account.BOSFieldGroup = null;
            this.label_Account.BOSFieldRelation = null;
            this.label_Account.BOSPrivilege = null;
            this.label_Account.BOSPropertyName = null;
            this.label_Account.Location = new System.Drawing.Point(12, 67);
            this.label_Account.Name = "label_Account";
            this.label_Account.Screen = null;
            this.label_Account.Size = new System.Drawing.Size(61, 16);
            this.label_Account.TabIndex = 6;
            this.label_Account.Text = "Tài khoản:";
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
            this.label_FromDateToDate.Location = new System.Drawing.Point(580, 51);
            this.label_FromDateToDate.Name = "label_FromDateToDate";
            this.label_FromDateToDate.Screen = null;
            this.label_FromDateToDate.Size = new System.Drawing.Size(148, 16);
            this.label_FromDateToDate.TabIndex = 5;
            this.label_FromDateToDate.Text = "Từ ngày                    đến";
            // 
            // fld_dgcRP049CurrencyACDocumentEntrys
            // 
            this.fld_dgcRP049CurrencyACDocumentEntrys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSComment = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSDataMember = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSDescription = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSError = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSGridType = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.Location = new System.Drawing.Point(3, 89);
            this.fld_dgcRP049CurrencyACDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcRP049CurrencyACDocumentEntrys.Name = "fld_dgcRP049CurrencyACDocumentEntrys";
            this.fld_dgcRP049CurrencyACDocumentEntrys.PrintReport = false;
            this.fld_dgcRP049CurrencyACDocumentEntrys.RowHandle = 0;
            this.fld_dgcRP049CurrencyACDocumentEntrys.Screen = null;
            this.fld_dgcRP049CurrencyACDocumentEntrys.Size = new System.Drawing.Size(1178, 206);
            this.fld_dgcRP049CurrencyACDocumentEntrys.TabIndex = 4;
            this.fld_dgcRP049CurrencyACDocumentEntrys.DoubleClick += new System.EventHandler(this.fld_dgcRP049CurrencyACDocumentEntrys_DoubleClick);
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
            this.Title.Size = new System.Drawing.Size(361, 33);
            this.Title.TabIndex = 3;
            this.Title.Text = "Tổng hợp công nợ phải thu";
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
            // guiRP049CurrencyShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 331);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiRP049CurrencyShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tổng hợp công nợ phải thu";
            this.Load += new System.EventHandler(this.guiRP049Show_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP049CurrencyACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSLabel Title;
        private RP049CurrencyACDocumentEntrysGridControl fld_dgcRP049CurrencyACDocumentEntrys;
        private BOSComponent.BOSLabel label_FromDateToDate;
        private BOSComponent.BOSLabel label_Account;
        private BOSComponent.BOSButton fld_btnExportExcel;
    }
}