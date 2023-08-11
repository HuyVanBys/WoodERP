namespace BOSERP.Modules.Report
{
    partial class RP161
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
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeCSCompanyBankID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.fld_dgcPrintMultiPaymentOrdersGridControl = new BOSERP.Modules.Report.RP_PrintMultiPaymentOrdertsGridControl();
            this.fld_dgvACBankTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkePrintTemplates = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCSCompanyBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintMultiPaymentOrdersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrintTemplates.Properties)).BeginInit();
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
            this.fld_btnPrint.Location = new System.Drawing.Point(737, 515);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 4;
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
            this.fld_btnClose.Location = new System.Drawing.Point(818, 515);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 5;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = "";
            this.fld_dteSearchToDate.BOSDataSource = "";
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(307, 12);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
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
            this.bosLabel9.Location = new System.Drawing.Point(245, 15);
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 0;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = "";
            this.fld_dteSearchFromDate.BOSDataSource = "";
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(72, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 1;
            this.fld_dteSearchFromDate.Tag = "DC";
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
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(307, 38);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 12;
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(245, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 9;
            this.bosLabel5.Text = "Chi nhánh";
            // 
            // fld_lkeCSCompanyBankID
            // 
            this.fld_lkeCSCompanyBankID.BOSAllowAddNew = false;
            this.fld_lkeCSCompanyBankID.BOSAllowDummy = true;
            this.fld_lkeCSCompanyBankID.BOSComment = "";
            this.fld_lkeCSCompanyBankID.BOSDataMember = "CSCompanyBankID";
            this.fld_lkeCSCompanyBankID.BOSDataSource = "CSCompanyBanks";
            this.fld_lkeCSCompanyBankID.BOSDescription = null;
            this.fld_lkeCSCompanyBankID.BOSError = null;
            this.fld_lkeCSCompanyBankID.BOSFieldGroup = "";
            this.fld_lkeCSCompanyBankID.BOSFieldParent = "";
            this.fld_lkeCSCompanyBankID.BOSFieldRelation = "";
            this.fld_lkeCSCompanyBankID.BOSPrivilege = "";
            this.fld_lkeCSCompanyBankID.BOSPropertyName = "EditValue";
            this.fld_lkeCSCompanyBankID.BOSSelectType = "";
            this.fld_lkeCSCompanyBankID.BOSSelectTypeValue = "";
            this.fld_lkeCSCompanyBankID.CurrentDisplayText = "";
            this.fld_lkeCSCompanyBankID.Location = new System.Drawing.Point(72, 38);
            this.fld_lkeCSCompanyBankID.Name = "fld_lkeCSCompanyBankID";
            this.fld_lkeCSCompanyBankID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeCSCompanyBankID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeCSCompanyBankID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeCSCompanyBankID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeCSCompanyBankID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCSCompanyBankID.Properties.ColumnName = null;
            this.fld_lkeCSCompanyBankID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankCode", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng")});
            this.fld_lkeCSCompanyBankID.Properties.DisplayMember = "CSCompanyBankName";
            this.fld_lkeCSCompanyBankID.Properties.NullText = "";
            this.fld_lkeCSCompanyBankID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeCSCompanyBankID.Properties.ValueMember = "CSCompanyBankID";
            this.fld_lkeCSCompanyBankID.Screen = null;
            this.fld_lkeCSCompanyBankID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeCSCompanyBankID.TabIndex = 14;
            this.fld_lkeCSCompanyBankID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Text = "Ngân hàng";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(526, 31);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 15;
            this.fld_btnSearch.Text = "Xem";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // fld_dgcPrintMultiPaymentOrdersGridControl
            // 
            this.fld_dgcPrintMultiPaymentOrdersGridControl.AllowDrop = true;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSComment = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSDataMember = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSDataSource = "ACBankTransactionItems";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSDescription = null;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSError = null;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSFieldGroup = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSFieldRelation = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSGridType = null;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSPrivilege = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.BOSPropertyName = null;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.CommodityType = "";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Location = new System.Drawing.Point(12, 81);
            this.fld_dgcPrintMultiPaymentOrdersGridControl.MainView = this.fld_dgvACBankTransactions;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Name = "fld_dgcPrintMultiPaymentOrdersGridControl";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.PrintReport = false;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Screen = null;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Size = new System.Drawing.Size(881, 428);
            this.fld_dgcPrintMultiPaymentOrdersGridControl.TabIndex = 16;
            this.fld_dgcPrintMultiPaymentOrdersGridControl.Tag = "DC";
            this.fld_dgcPrintMultiPaymentOrdersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACBankTransactions});
            // 
            // fld_dgvACBankTransactions
            // 
            this.fld_dgvACBankTransactions.GridControl = this.fld_dgcPrintMultiPaymentOrdersGridControl;
            this.fld_dgvACBankTransactions.Name = "fld_dgvACBankTransactions";
            this.fld_dgvACBankTransactions.PaintStyleName = "Office2003";
            // 
            // fld_lkePrintTemplates
            // 
            this.fld_lkePrintTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkePrintTemplates.BOSAllowAddNew = false;
            this.fld_lkePrintTemplates.BOSAllowDummy = true;
            this.fld_lkePrintTemplates.BOSComment = "";
            this.fld_lkePrintTemplates.BOSDataMember = "";
            this.fld_lkePrintTemplates.BOSDataSource = "RPDetailBankTransactionMethod";
            this.fld_lkePrintTemplates.BOSDescription = null;
            this.fld_lkePrintTemplates.BOSError = null;
            this.fld_lkePrintTemplates.BOSFieldGroup = "";
            this.fld_lkePrintTemplates.BOSFieldParent = "";
            this.fld_lkePrintTemplates.BOSFieldRelation = "";
            this.fld_lkePrintTemplates.BOSPrivilege = "";
            this.fld_lkePrintTemplates.BOSPropertyName = "EditValue";
            this.fld_lkePrintTemplates.BOSSelectType = "";
            this.fld_lkePrintTemplates.BOSSelectTypeValue = "";
            this.fld_lkePrintTemplates.CurrentDisplayText = "";
            this.fld_lkePrintTemplates.Location = new System.Drawing.Point(581, 519);
            this.fld_lkePrintTemplates.Name = "fld_lkePrintTemplates";
            this.fld_lkePrintTemplates.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkePrintTemplates.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePrintTemplates.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePrintTemplates.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePrintTemplates.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePrintTemplates.Properties.ColumnName = null;
            this.fld_lkePrintTemplates.Properties.NullText = "";
            this.fld_lkePrintTemplates.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePrintTemplates.Screen = null;
            this.fld_lkePrintTemplates.Size = new System.Drawing.Size(150, 20);
            this.fld_lkePrintTemplates.TabIndex = 18;
            this.fld_lkePrintTemplates.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(516, 522);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(59, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Text = "Chọn mẫu in";
            // 
            // RP161
            // 
            this.AcceptButton = this.fld_btnPrint;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(905, 554);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkePrintTemplates);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dgcPrintMultiPaymentOrdersGridControl);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.fld_lkeCSCompanyBankID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeBRBranchID);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_dteSearchToDate);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_btnPrint);
            this.Controls.Add(this.fld_dteSearchFromDate);
            this.Controls.Add(this.fld_btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP161";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng kê thanh toán";
            this.Load += new System.EventHandler(this.RP054_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromDate, 0);
            this.Controls.SetChildIndex(this.fld_btnPrint, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToDate, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeBRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeCSCompanyBankID, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.fld_dgcPrintMultiPaymentOrdersGridControl, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkePrintTemplates, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCSCompanyBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintMultiPaymentOrdersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACBankTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrintTemplates.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeCSCompanyBankID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSButton fld_btnSearch;
        private RP_PrintMultiPaymentOrdertsGridControl fld_dgcPrintMultiPaymentOrdersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACBankTransactions;
        private BOSComponent.BOSLookupEdit fld_lkePrintTemplates;
        private BOSComponent.BOSLabel bosLabel2;
    }
}