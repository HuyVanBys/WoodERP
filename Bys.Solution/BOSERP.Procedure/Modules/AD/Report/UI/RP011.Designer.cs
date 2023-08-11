namespace BOSERP.Modules.Report
{
    partial class RP011
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP011));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lkeARSaleOrderNo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARRP011Invoices = new BOSERP.Modules.Report.ARRP011InvoicesGridControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP011Invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_lkeARSaleOrderNo);
            this.panelControl1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.BOSLabel4);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel3);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1093, 63);
            this.panelControl1.TabIndex = 6;
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
            this.fld_btnApply.Location = new System.Drawing.Point(539, 6);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 23);
            this.fld_btnApply.TabIndex = 5;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lkeARSaleOrderNo
            // 
            this.fld_lkeARSaleOrderNo.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderNo.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderNo.BOSComment = null;
            this.fld_lkeARSaleOrderNo.BOSDataMember = "ARSaleOrderNo";
            this.fld_lkeARSaleOrderNo.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderNo.BOSDescription = null;
            this.fld_lkeARSaleOrderNo.BOSError = null;
            this.fld_lkeARSaleOrderNo.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderNo.BOSFieldParent = "fld_lkeFK_ARCustomerID";
            this.fld_lkeARSaleOrderNo.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderNo.BOSPrivilege = null;
            this.fld_lkeARSaleOrderNo.BOSPropertyName = null;
            this.fld_lkeARSaleOrderNo.BOSSelectType = null;
            this.fld_lkeARSaleOrderNo.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderNo.CurrentDisplayText = "";
            this.fld_lkeARSaleOrderNo.Location = new System.Drawing.Point(326, 34);
            this.fld_lkeARSaleOrderNo.Name = "fld_lkeARSaleOrderNo";
            this.fld_lkeARSaleOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "No.")});
            this.fld_lkeARSaleOrderNo.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeARSaleOrderNo.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeARSaleOrderNo.Screen = null;
            this.fld_lkeARSaleOrderNo.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeARSaleOrderNo.TabIndex = 4;
            this.fld_lkeARSaleOrderNo.Tag = "";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(95, 34);
            this.fld_lkeFK_ARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Name")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 3;
            this.fld_lkeFK_ARCustomerID.Tag = "SC";
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
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(326, 9);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 2;
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
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(95, 9);
            this.fld_dteSearchFromARInvoiceDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 1;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(265, 37);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(47, 13);
            this.BOSLabel4.TabIndex = 7;
            this.BOSLabel4.Text = "Đơn hàng";
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
            this.BOSLabel2.Location = new System.Drawing.Point(12, 37);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(56, 13);
            this.BOSLabel2.TabIndex = 7;
            this.BOSLabel2.Text = "Khách hàng";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(265, 12);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel3.TabIndex = 7;
            this.BOSLabel3.Text = "Đến";
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
            this.BOSLabel1.Location = new System.Drawing.Point(12, 12);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 7;
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
            this.fld_lblTitle.Location = new System.Drawing.Point(400, 83);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(245, 19);
            this.fld_lblTitle.TabIndex = 7;
            this.fld_lblTitle.Text = "Danh sách biên nhận trả trước";
            // 
            // fld_dgcARRP011Invoices
            // 
            this.fld_dgcARRP011Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRP011Invoices.BOSComment = null;
            this.fld_dgcARRP011Invoices.BOSDataMember = null;
            this.fld_dgcARRP011Invoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARRP011Invoices.BOSDescription = null;
            this.fld_dgcARRP011Invoices.BOSError = null;
            this.fld_dgcARRP011Invoices.BOSFieldGroup = null;
            this.fld_dgcARRP011Invoices.BOSFieldRelation = null;
            this.fld_dgcARRP011Invoices.BOSGridType = null;
            this.fld_dgcARRP011Invoices.BOSPrivilege = null;
            this.fld_dgcARRP011Invoices.BOSPropertyName = null;
            this.fld_dgcARRP011Invoices.Location = new System.Drawing.Point(12, 119);
            this.fld_dgcARRP011Invoices.MenuManager = this.screenToolbar;
            this.fld_dgcARRP011Invoices.Name = "fld_dgcARRP011Invoices";
            this.fld_dgcARRP011Invoices.Screen = null;
            this.fld_dgcARRP011Invoices.Size = new System.Drawing.Size(904, 492);
            this.fld_dgcARRP011Invoices.TabIndex = 8;
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
            this.fld_btnClose.Location = new System.Drawing.Point(1005, 649);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 23);
            this.fld_btnClose.TabIndex = 8;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnExcel.Location = new System.Drawing.Point(913, 649);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnExcel.TabIndex = 8;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // RP011
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 684);
            this.Controls.Add(this.fld_dgcARRP011Invoices);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP011";
            this.Tag = "SS";
            this.Text = "Danh sách biên nhận trả trước";
            this.Load += new System.EventHandler(this.RP011_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRP011Invoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeARSaleOrderNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel fld_lblTitle;
        private ARRP011InvoicesGridControl fld_dgcARRP011Invoices;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnExcel;
    }
}