namespace BOSERP.Modules.GeneralAccounting
{
    partial class guiEvaluateForeignExchangeDiff
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_cmEvaluateType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkInvoice = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkObject = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeGECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOK = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_chkSellectAllAccount = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcACRP060Accounts = new BOSERP.Modules.Report.AccountGridControl();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmEvaluateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkObject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtExchangeRate.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAllAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRP060Accounts)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 27);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_cmEvaluateType);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.fld_chkInvoice);
            this.bosLine1.Controls.Add(this.fld_chkObject);
            this.bosLine1.Controls.Add(this.fld_dteToDate);
            this.bosLine1.Controls.Add(this.fld_dteFromDate);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.fld_lkeGECurrencyID);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_txtExchangeRate);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLine1.Location = new System.Drawing.Point(9, 7);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(770, 104);
            this.bosLine1.TabIndex = 0;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Kỳ báo cáo";
            // 
            // fld_cmEvaluateType
            // 
            this.fld_cmEvaluateType.Location = new System.Drawing.Point(614, 24);
            this.fld_cmEvaluateType.MenuManager = this.screenToolbar;
            this.fld_cmEvaluateType.Name = "fld_cmEvaluateType";
            this.fld_cmEvaluateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmEvaluateType.Properties.Items.AddRange(new object[] {
            "Tài sản (Phải thu)",
            "Công nợ (Phải trả)"});
            this.fld_cmEvaluateType.Size = new System.Drawing.Size(150, 20);
            this.fld_cmEvaluateType.TabIndex = 5;
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(533, 27);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(63, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Loại đánh giá";
            // 
            // fld_chkInvoice
            // 
            this.fld_chkInvoice.BOSComment = null;
            this.fld_chkInvoice.BOSDataMember = null;
            this.fld_chkInvoice.BOSDataSource = null;
            this.fld_chkInvoice.BOSDescription = null;
            this.fld_chkInvoice.BOSError = null;
            this.fld_chkInvoice.BOSFieldGroup = null;
            this.fld_chkInvoice.BOSFieldRelation = null;
            this.fld_chkInvoice.BOSPrivilege = null;
            this.fld_chkInvoice.BOSPropertyName = null;
            this.fld_chkInvoice.Location = new System.Drawing.Point(275, 52);
            this.fld_chkInvoice.Name = "fld_chkInvoice";
            this.fld_chkInvoice.Properties.Caption = "Theo hóa đơn";
            this.fld_chkInvoice.Screen = null;
            this.fld_chkInvoice.Size = new System.Drawing.Size(118, 19);
            this.fld_chkInvoice.TabIndex = 7;
            // 
            // fld_chkObject
            // 
            this.fld_chkObject.BOSComment = null;
            this.fld_chkObject.BOSDataMember = null;
            this.fld_chkObject.BOSDataSource = null;
            this.fld_chkObject.BOSDescription = null;
            this.fld_chkObject.BOSError = null;
            this.fld_chkObject.BOSFieldGroup = null;
            this.fld_chkObject.BOSFieldRelation = null;
            this.fld_chkObject.BOSPrivilege = null;
            this.fld_chkObject.BOSPropertyName = null;
            this.fld_chkObject.Location = new System.Drawing.Point(70, 51);
            this.fld_chkObject.MenuManager = this.screenToolbar;
            this.fld_chkObject.Name = "fld_chkObject";
            this.fld_chkObject.Properties.Caption = "Theo đối tượng";
            this.fld_chkObject.Screen = null;
            this.fld_chkObject.Size = new System.Drawing.Size(118, 19);
            this.fld_chkObject.TabIndex = 6;
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
            this.fld_dteToDate.Location = new System.Drawing.Point(277, 24);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 3;
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
            this.fld_dteFromDate.Location = new System.Drawing.Point(70, 24);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 1;
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
            this.bosLabel2.Location = new System.Drawing.Point(239, 27);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Text = "Đến";
            // 
            // fld_lkeGECurrencyID
            // 
            this.fld_lkeGECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeGECurrencyID.BOSAllowDummy = false;
            this.fld_lkeGECurrencyID.BOSComment = null;
            this.fld_lkeGECurrencyID.BOSDataMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.BOSDataSource = "GECurrencies";
            this.fld_lkeGECurrencyID.BOSDescription = null;
            this.fld_lkeGECurrencyID.BOSError = null;
            this.fld_lkeGECurrencyID.BOSFieldGroup = null;
            this.fld_lkeGECurrencyID.BOSFieldParent = null;
            this.fld_lkeGECurrencyID.BOSFieldRelation = null;
            this.fld_lkeGECurrencyID.BOSPrivilege = null;
            this.fld_lkeGECurrencyID.BOSPropertyName = null;
            this.fld_lkeGECurrencyID.BOSSelectType = null;
            this.fld_lkeGECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeGECurrencyID.CurrentDisplayText = null;
            this.fld_lkeGECurrencyID.Location = new System.Drawing.Point(614, 51);
            this.fld_lkeGECurrencyID.Name = "fld_lkeGECurrencyID";
            this.fld_lkeGECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeGECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeGECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeGECurrencyID.Screen = null;
            this.fld_lkeGECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGECurrencyID.TabIndex = 9;
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(533, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(33, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Text = "Tiền tệ";
            // 
            // fld_txtExchangeRate
            // 
            this.fld_txtExchangeRate.BOSComment = null;
            this.fld_txtExchangeRate.BOSDataMember = null;
            this.fld_txtExchangeRate.BOSDataSource = null;
            this.fld_txtExchangeRate.BOSDescription = null;
            this.fld_txtExchangeRate.BOSError = null;
            this.fld_txtExchangeRate.BOSFieldGroup = null;
            this.fld_txtExchangeRate.BOSFieldRelation = null;
            this.fld_txtExchangeRate.BOSPrivilege = null;
            this.fld_txtExchangeRate.BOSPropertyName = null;
            this.fld_txtExchangeRate.EditValue = "0";
            this.fld_txtExchangeRate.Location = new System.Drawing.Point(614, 77);
            this.fld_txtExchangeRate.MenuManager = this.screenToolbar;
            this.fld_txtExchangeRate.Name = "fld_txtExchangeRate";
            this.fld_txtExchangeRate.Properties.Mask.EditMask = "n3";
            this.fld_txtExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtExchangeRate.Screen = null;
            this.fld_txtExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtExchangeRate.TabIndex = 11;
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
            this.bosLabel4.Location = new System.Drawing.Point(533, 80);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 10;
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.BOSComment = null;
            this.fld_btnOK.BOSDataMember = null;
            this.fld_btnOK.BOSDataSource = null;
            this.fld_btnOK.BOSDescription = null;
            this.fld_btnOK.BOSError = null;
            this.fld_btnOK.BOSFieldGroup = null;
            this.fld_btnOK.BOSFieldRelation = null;
            this.fld_btnOK.BOSPrivilege = null;
            this.fld_btnOK.BOSPropertyName = null;
            this.fld_btnOK.Location = new System.Drawing.Point(623, 533);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Screen = null;
            this.fld_btnOK.Size = new System.Drawing.Size(75, 27);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Text = "OK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(704, 533);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_chkSellectAllAccount);
            this.bosLine2.Controls.Add(this.fld_dgcACRP060Accounts);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(12, 117);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(767, 410);
            this.bosLine2.TabIndex = 1;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = global::Localization.SaleOrderLocalizedResources.String1;
            this.bosLine2.Text = "Danh sách tài khoản";
            // 
            // fld_chkSellectAllAccount
            // 
            this.fld_chkSellectAllAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAllAccount.BOSComment = null;
            this.fld_chkSellectAllAccount.BOSDataMember = null;
            this.fld_chkSellectAllAccount.BOSDataSource = null;
            this.fld_chkSellectAllAccount.BOSDescription = null;
            this.fld_chkSellectAllAccount.BOSError = null;
            this.fld_chkSellectAllAccount.BOSFieldGroup = null;
            this.fld_chkSellectAllAccount.BOSFieldRelation = null;
            this.fld_chkSellectAllAccount.BOSPrivilege = null;
            this.fld_chkSellectAllAccount.BOSPropertyName = null;
            this.fld_chkSellectAllAccount.Location = new System.Drawing.Point(12, 381);
            this.fld_chkSellectAllAccount.MenuManager = this.screenToolbar;
            this.fld_chkSellectAllAccount.Name = "fld_chkSellectAllAccount";
            this.fld_chkSellectAllAccount.Properties.Caption = "Chọn tất cả ";
            this.fld_chkSellectAllAccount.Screen = null;
            this.fld_chkSellectAllAccount.Size = new System.Drawing.Size(137, 19);
            this.fld_chkSellectAllAccount.TabIndex = 1;
            this.fld_chkSellectAllAccount.Tag = "DC";
            this.fld_chkSellectAllAccount.CheckedChanged += new System.EventHandler(this.fld_chkSellectAllAccount_CheckedChanged);
            // 
            // fld_dgcACRP060Accounts
            // 
            this.fld_dgcACRP060Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACRP060Accounts.BOSComment = null;
            this.fld_dgcACRP060Accounts.BOSDataMember = null;
            this.fld_dgcACRP060Accounts.BOSDataSource = "ACAccounts";
            this.fld_dgcACRP060Accounts.BOSDescription = null;
            this.fld_dgcACRP060Accounts.BOSError = null;
            this.fld_dgcACRP060Accounts.BOSFieldGroup = null;
            this.fld_dgcACRP060Accounts.BOSFieldRelation = null;
            this.fld_dgcACRP060Accounts.BOSGridType = null;
            this.fld_dgcACRP060Accounts.BOSPrivilege = null;
            this.fld_dgcACRP060Accounts.BOSPropertyName = null;
            this.fld_dgcACRP060Accounts.Location = new System.Drawing.Point(3, 20);
            this.fld_dgcACRP060Accounts.Name = "fld_dgcACRP060Accounts";
            this.fld_dgcACRP060Accounts.PrintReport = false;
            this.fld_dgcACRP060Accounts.Screen = null;
            this.fld_dgcACRP060Accounts.Size = new System.Drawing.Size(761, 355);
            this.fld_dgcACRP060Accounts.TabIndex = 0;
            this.fld_dgcACRP060Accounts.Tag = "DC";
            // 
            // guiEvaluateForeignExchangeDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(804, 572);
            this.ControlBox = true;
            this.Controls.Add(this.bosLine2);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.bosLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiEvaluateForeignExchangeDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đánh giá lại ngoại tệ";
            this.Load += new System.EventHandler(this.guiEvaluateForeignExchangeDiff_Load);
            this.Controls.SetChildIndex(this.bosLine1, 0);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.bosLine2, 0);
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmEvaluateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkObject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtExchangeRate.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAllAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRP060Accounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeGECurrencyID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnOK;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtExchangeRate;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSCheckEdit fld_chkSellectAllAccount;
        private BOSERP.Modules.Report.AccountGridControl fld_dgcACRP060Accounts;
        private BOSComponent.BOSCheckEdit fld_chkObject;
        private BOSComponent.BOSCheckEdit fld_chkInvoice;
        private DevExpress.XtraEditors.ComboBoxEdit fld_cmEvaluateType;
        private BOSComponent.BOSLabel bosLabel7;
    }
}