namespace BOSERP.Modules.Report
{
    partial class RP099
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP099));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lblBranchName = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARRP099InvoiceItems = new BOSERP.Modules.Report.ARRP099SalesGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExportexcel = new BOSComponent.BOSButton(this.components);
            this.fld_lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP099InvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panelControl1.Controls.Add(this.bosLabel4);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_dteFromDate);
            this.panelControl1.Controls.Add(this.bosLabel2);
            this.panelControl1.Controls.Add(this.fld_dteToDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1092, 89);
            this.panelControl1.TabIndex = 0;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = "Invoice";
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(80, 42);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 19;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(12, 45);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(56, 13);
            this.bosLabel4.TabIndex = 18;
            this.bosLabel4.Text = "Khách hàng";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 19);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = null;
            this.fld_dteFromDate.BOSDataSource = null;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(80, 16);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 13;
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
            this.bosLabel2.Location = new System.Drawing.Point(259, 19);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = null;
            this.fld_dteToDate.BOSDataSource = null;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(327, 16);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 14;
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
            this.fld_btnApply.Location = new System.Drawing.Point(848, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(84, 27);
            this.fld_btnApply.TabIndex = 6;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lblBranchName
            // 
            this.fld_lblBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBranchName.BOSComment = null;
            this.fld_lblBranchName.BOSDataMember = null;
            this.fld_lblBranchName.BOSDataSource = null;
            this.fld_lblBranchName.BOSDescription = null;
            this.fld_lblBranchName.BOSError = null;
            this.fld_lblBranchName.BOSFieldGroup = null;
            this.fld_lblBranchName.BOSFieldRelation = null;
            this.fld_lblBranchName.BOSPrivilege = null;
            this.fld_lblBranchName.BOSPropertyName = null;
            this.fld_lblBranchName.Location = new System.Drawing.Point(707, 105);
            this.fld_lblBranchName.Name = "fld_lblBranchName";
            this.fld_lblBranchName.Screen = null;
            this.fld_lblBranchName.Size = new System.Drawing.Size(38, 19);
            this.fld_lblBranchName.TabIndex = 8;
            this.fld_lblBranchName.Text = "Text";
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
            this.fld_lblTitle.Location = new System.Drawing.Point(146, 105);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(545, 19);
            this.fld_lblTitle.TabIndex = 8;
            this.fld_lblTitle.Text = "Báo cáo kinh doanh theo Khách hàng - Doanh số - Doanh thu tháng";
            // 
            // fld_dgcARRP099InvoiceItems
            // 
            this.fld_dgcARRP099InvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP099InvoiceItems.BOSComment = null;
            this.fld_dgcARRP099InvoiceItems.BOSDataMember = null;
            this.fld_dgcARRP099InvoiceItems.BOSDataSource = "ARCustomers";
            this.fld_dgcARRP099InvoiceItems.BOSDescription = null;
            this.fld_dgcARRP099InvoiceItems.BOSError = null;
            this.fld_dgcARRP099InvoiceItems.BOSFieldGroup = null;
            this.fld_dgcARRP099InvoiceItems.BOSFieldRelation = null;
            this.fld_dgcARRP099InvoiceItems.BOSGridType = null;
            this.fld_dgcARRP099InvoiceItems.BOSPrivilege = null;
            this.fld_dgcARRP099InvoiceItems.BOSPropertyName = null;
            this.fld_dgcARRP099InvoiceItems.CommodityType = "";
            this.fld_dgcARRP099InvoiceItems.CustomerList = null;
            this.fld_dgcARRP099InvoiceItems.GridViewMain = null;
            this.fld_dgcARRP099InvoiceItems.Location = new System.Drawing.Point(0, 155);
            this.fld_dgcARRP099InvoiceItems.MenuManager = this.screenToolbar;
            this.fld_dgcARRP099InvoiceItems.Name = "fld_dgcARRP099InvoiceItems";
            this.fld_dgcARRP099InvoiceItems.PrintReport = false;
            this.fld_dgcARRP099InvoiceItems.Screen = null;
            this.fld_dgcARRP099InvoiceItems.Size = new System.Drawing.Size(1092, 528);
            this.fld_dgcARRP099InvoiceItems.TabIndex = 9;
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
            this.fld_btnClose.Location = new System.Drawing.Point(1004, 703);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 9;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnExportexcel
            // 
            this.fld_btnExportexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportexcel.BOSComment = null;
            this.fld_btnExportexcel.BOSDataMember = null;
            this.fld_btnExportexcel.BOSDataSource = null;
            this.fld_btnExportexcel.BOSDescription = null;
            this.fld_btnExportexcel.BOSError = null;
            this.fld_btnExportexcel.BOSFieldGroup = null;
            this.fld_btnExportexcel.BOSFieldRelation = null;
            this.fld_btnExportexcel.BOSPrivilege = null;
            this.fld_btnExportexcel.BOSPropertyName = null;
            this.fld_btnExportexcel.Location = new System.Drawing.Point(923, 703);
            this.fld_btnExportexcel.Name = "fld_btnExportexcel";
            this.fld_btnExportexcel.Screen = null;
            this.fld_btnExportexcel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportexcel.TabIndex = 10;
            this.fld_btnExportexcel.Text = "Xuất excel";
            this.fld_btnExportexcel.Click += new System.EventHandler(this.fld_btnExportexcel_Click);
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
            this.fld_lbl_FromdateTodate.Location = new System.Drawing.Point(383, 130);
            this.fld_lbl_FromdateTodate.Name = "fld_lbl_FromdateTodate";
            this.fld_lbl_FromdateTodate.Screen = null;
            this.fld_lbl_FromdateTodate.Size = new System.Drawing.Size(28, 16);
            this.fld_lbl_FromdateTodate.TabIndex = 8;
            this.fld_lbl_FromdateTodate.Text = "Text";
            // 
            // RP099
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 742);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcARRP099InvoiceItems);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lbl_FromdateTodate);
            this.Controls.Add(this.fld_lblBranchName);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnExportexcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP099";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Báo cáo kinh doanh theo Khách hàng - Doanh số - Doanh thu tháng";
            this.Load += new System.EventHandler(this.RP002_Load);
            this.Controls.SetChildIndex(this.fld_btnExportexcel, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblBranchName, 0);
            this.Controls.SetChildIndex(this.fld_lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_dgcARRP099InvoiceItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP099InvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel fld_lblBranchName;
        private BOSComponent.BOSLabel fld_lblTitle;
        private ARRP099SalesGridControl fld_dgcARRP099InvoiceItems;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExportexcel;
        private BOSComponent.BOSLabel fld_lbl_FromdateTodate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
    }
}