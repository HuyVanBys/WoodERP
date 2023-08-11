namespace BOSERP.Modules.AccountingFormulaReport.UI
{
    partial class DMAFPS100
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
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcGEAccountingFormulaItems = new BOSERP.Modules.AccountingFormulaReport.ACAccountingFormulaItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabInvoiceInItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageInvoiceInItems = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_BRBranchCentralID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchOpeningFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchOpeningToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEAccountingFormulaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).BeginInit();
            this.fld_tabInvoiceInItems.SuspendLayout();
            this.fld_tabPageInvoiceInItems.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchCentralID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(616, 64);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(102, 27);
            this.fld_btnPrint.TabIndex = 3;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(354, 38);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteSearchToDate.TabIndex = 2;
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
            this.bosLabel9.Location = new System.Drawing.Point(258, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 2;
            this.bosLabel9.Text = "Đến ngày";
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
            this.bosLabel10.Location = new System.Drawing.Point(17, 41);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(106, 38);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(146, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_dgcGEAccountingFormulaItems
            // 
            this.fld_dgcGEAccountingFormulaItems.AllowDrop = true;
            this.fld_dgcGEAccountingFormulaItems.BOSComment = null;
            this.fld_dgcGEAccountingFormulaItems.BOSDataMember = null;
            this.fld_dgcGEAccountingFormulaItems.BOSDataSource = "GEAccountingFormulaItems";
            this.fld_dgcGEAccountingFormulaItems.BOSDescription = null;
            this.fld_dgcGEAccountingFormulaItems.BOSError = null;
            this.fld_dgcGEAccountingFormulaItems.BOSFieldGroup = null;
            this.fld_dgcGEAccountingFormulaItems.BOSFieldRelation = null;
            this.fld_dgcGEAccountingFormulaItems.BOSGridType = null;
            this.fld_dgcGEAccountingFormulaItems.BOSPrivilege = null;
            this.fld_dgcGEAccountingFormulaItems.BOSPropertyName = null;
            this.fld_dgcGEAccountingFormulaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEAccountingFormulaItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcGEAccountingFormulaItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGEAccountingFormulaItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcGEAccountingFormulaItems.Name = "fld_dgcGEAccountingFormulaItems";
            this.fld_dgcGEAccountingFormulaItems.PrintReport = false;
            this.fld_dgcGEAccountingFormulaItems.Screen = null;
            this.fld_dgcGEAccountingFormulaItems.Size = new System.Drawing.Size(993, 499);
            this.fld_dgcGEAccountingFormulaItems.TabIndex = 6;
            this.fld_dgcGEAccountingFormulaItems.Tag = "DC";
            this.fld_dgcGEAccountingFormulaItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcGEAccountingFormulaItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_tabInvoiceInItems
            // 
            this.fld_tabInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabInvoiceInItems.BOSComment = null;
            this.fld_tabInvoiceInItems.BOSDataMember = null;
            this.fld_tabInvoiceInItems.BOSDataSource = null;
            this.fld_tabInvoiceInItems.BOSDescription = null;
            this.fld_tabInvoiceInItems.BOSError = null;
            this.fld_tabInvoiceInItems.BOSFieldGroup = null;
            this.fld_tabInvoiceInItems.BOSFieldRelation = null;
            this.fld_tabInvoiceInItems.BOSPrivilege = null;
            this.fld_tabInvoiceInItems.BOSPropertyName = null;
            this.fld_tabInvoiceInItems.Location = new System.Drawing.Point(3, 97);
            this.fld_tabInvoiceInItems.Name = "fld_tabInvoiceInItems";
            this.fld_tabInvoiceInItems.Screen = null;
            this.fld_tabInvoiceInItems.SelectedTabPage = this.fld_tabPageInvoiceInItems;
            this.fld_tabInvoiceInItems.Size = new System.Drawing.Size(1000, 528);
            this.fld_tabInvoiceInItems.TabIndex = 7;
            this.fld_tabInvoiceInItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageInvoiceInItems});
            // 
            // fld_tabPageInvoiceInItems
            // 
            this.fld_tabPageInvoiceInItems.Controls.Add(this.fld_dgcGEAccountingFormulaItems);
            this.fld_tabPageInvoiceInItems.Name = "fld_tabPageInvoiceInItems";
            this.fld_tabPageInvoiceInItems.Size = new System.Drawing.Size(993, 499);
            this.fld_tabPageInvoiceInItems.Text = "Danh sách chỉ tiêu";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchCentralID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteSearchOpeningFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteSearchOpeningToDate);
            this.bosPanel1.Controls.Add(this.fld_btnView);
            this.bosPanel1.Controls.Add(this.fld_btnPrint);
            this.bosPanel1.Controls.Add(this.fld_tabInvoiceInItems);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1006, 628);
            this.bosPanel1.TabIndex = 8;
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(508, 64);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(102, 27);
            this.fld_btnView.TabIndex = 3;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // fld_lkeFK_BRBranchCentralID
            // 
            this.fld_lkeFK_BRBranchCentralID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchCentralID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchCentralID.BOSComment = null;
            this.fld_lkeFK_BRBranchCentralID.BOSDataMember = "";
            this.fld_lkeFK_BRBranchCentralID.BOSDataSource = "";
            this.fld_lkeFK_BRBranchCentralID.BOSDescription = null;
            this.fld_lkeFK_BRBranchCentralID.BOSError = null;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchCentralID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchCentralID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchCentralID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchCentralID.BOSSelectType = "BRBranchType";
            this.fld_lkeFK_BRBranchCentralID.BOSSelectTypeValue = "Central";
            this.fld_lkeFK_BRBranchCentralID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchCentralID.Location = new System.Drawing.Point(562, 12);
            this.fld_lkeFK_BRBranchCentralID.Name = "fld_lkeFK_BRBranchCentralID";
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchCentralID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchCentralID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchCentralID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchCentralID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchCentralID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchCentralID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchCentralID.Screen = null;
            this.fld_lkeFK_BRBranchCentralID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchCentralID.TabIndex = 600;
            this.fld_lkeFK_BRBranchCentralID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = "ARInvoices";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(508, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 603;
            this.bosLabel3.Text = "Trung tâm";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(17, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(83, 13);
            this.bosLabel1.TabIndex = 601;
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Text = "Từ ngày kỳ trước";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Location = new System.Drawing.Point(258, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 602;
            this.bosLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Text = "Đến ngày kỳ trước";
            // 
            // fld_dteSearchOpeningFromDate
            // 
            this.fld_dteSearchOpeningFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningFromDate.BOSDataMember = "";
            this.fld_dteSearchOpeningFromDate.BOSDataSource = "";
            this.fld_dteSearchOpeningFromDate.BOSDescription = null;
            this.fld_dteSearchOpeningFromDate.BOSError = null;
            this.fld_dteSearchOpeningFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchOpeningFromDate.EditValue = null;
            this.fld_dteSearchOpeningFromDate.Location = new System.Drawing.Point(106, 12);
            this.fld_dteSearchOpeningFromDate.Name = "fld_dteSearchOpeningFromDate";
            this.fld_dteSearchOpeningFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchOpeningFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchOpeningFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchOpeningFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchOpeningFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchOpeningFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchOpeningFromDate.Screen = null;
            this.fld_dteSearchOpeningFromDate.Size = new System.Drawing.Size(146, 20);
            this.fld_dteSearchOpeningFromDate.TabIndex = 598;
            this.fld_dteSearchOpeningFromDate.Tag = "DC";
            // 
            // fld_dteSearchOpeningToDate
            // 
            this.fld_dteSearchOpeningToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningToDate.BOSDataMember = "";
            this.fld_dteSearchOpeningToDate.BOSDataSource = "";
            this.fld_dteSearchOpeningToDate.BOSDescription = null;
            this.fld_dteSearchOpeningToDate.BOSError = null;
            this.fld_dteSearchOpeningToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchOpeningToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchOpeningToDate.EditValue = null;
            this.fld_dteSearchOpeningToDate.Location = new System.Drawing.Point(354, 12);
            this.fld_dteSearchOpeningToDate.Name = "fld_dteSearchOpeningToDate";
            this.fld_dteSearchOpeningToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchOpeningToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchOpeningToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchOpeningToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchOpeningToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchOpeningToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchOpeningToDate.Screen = null;
            this.fld_dteSearchOpeningToDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteSearchOpeningToDate.TabIndex = 599;
            this.fld_dteSearchOpeningToDate.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(562, 38);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 604;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = "ARInvoices";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(508, 41);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 605;
            this.bosLabel18.Text = "Chi nhánh";
            // 
            // DMAFPS100
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DMAFPS100";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.RP056_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEAccountingFormulaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabInvoiceInItems)).EndInit();
            this.fld_tabInvoiceInItems.ResumeLayout(false);
            this.fld_tabPageInvoiceInItems.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchCentralID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchOpeningToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private ACAccountingFormulaItemsGridControl fld_dgcGEAccountingFormulaItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSTabControl fld_tabInvoiceInItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageInvoiceInItems;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnView;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchCentralID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteSearchOpeningFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchOpeningToDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel18;
    }
}