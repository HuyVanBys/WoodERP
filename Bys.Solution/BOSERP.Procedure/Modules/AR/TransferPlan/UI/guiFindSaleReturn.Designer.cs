namespace BOSERP.Modules.TransferPlan
{
    partial class guiFindSaleReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleReturnItemsGridControl = new BOSERP.Modules.TransferPlan.ARSaleReturnItemsGridControl();
            this.fld_dteARSaleOrderDeliveryDateForm = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARSaleOrderDeliveryDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ARSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleReturnItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 27);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Từ ngày";
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
            this.fld_btnClose.Location = new System.Drawing.Point(802, 544);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 10;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(713, 544);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcARSaleReturnItemsGridControl
            // 
            this.fld_dgcARSaleReturnItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleReturnItemsGridControl.BOSComment = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSDataMember = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSDataSource = "ARSaleReturnItems";
            this.fld_dgcARSaleReturnItemsGridControl.BOSDescription = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSError = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSGridType = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleReturnItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleReturnItemsGridControl.Location = new System.Drawing.Point(12, 86);
            this.fld_dgcARSaleReturnItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleReturnItemsGridControl.Name = "fld_dgcARSaleReturnItemsGridControl";
            this.fld_dgcARSaleReturnItemsGridControl.PrintReport = false;
            this.fld_dgcARSaleReturnItemsGridControl.Screen = null;
            this.fld_dgcARSaleReturnItemsGridControl.Size = new System.Drawing.Size(873, 452);
            this.fld_dgcARSaleReturnItemsGridControl.TabIndex = 8;
            this.fld_dgcARSaleReturnItemsGridControl.Tag = global::Localization.ReportLocalizedResources.String2;
            // 
            // fld_dteARSaleOrderDeliveryDateForm
            // 
            this.fld_dteARSaleOrderDeliveryDateForm.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDateForm.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Location = new System.Drawing.Point(82, 24);
            this.fld_dteARSaleOrderDeliveryDateForm.Name = "fld_dteARSaleOrderDeliveryDateForm";
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDateForm.Screen = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Size = new System.Drawing.Size(177, 20);
            this.fld_dteARSaleOrderDeliveryDateForm.TabIndex = 0;
            this.fld_dteARSaleOrderDeliveryDateForm.Tag = "DC";
            // 
            // fld_dteARSaleOrderDeliveryDateTo
            // 
            this.fld_dteARSaleOrderDeliveryDateTo.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDateTo.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDateTo.Location = new System.Drawing.Point(82, 50);
            this.fld_dteARSaleOrderDeliveryDateTo.Name = "fld_dteARSaleOrderDeliveryDateTo";
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDateTo.Screen = null;
            this.fld_dteARSaleOrderDeliveryDateTo.Size = new System.Drawing.Size(177, 20);
            this.fld_dteARSaleOrderDeliveryDateTo.TabIndex = 1;
            this.fld_dteARSaleOrderDeliveryDateTo.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 53);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 131;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(290, 27);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 134;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel2.Text = "Mã HBTL";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(290, 53);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(58, 13);
            this.bosLabel7.TabIndex = 141;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel7.Text = "Khách hàng";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.Location = new System.Drawing.Point(576, 25);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(94, 27);
            this.fld_btnFind.TabIndex = 7;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_ARSaleReturnID
            // 
            this.fld_lkeFK_ARSaleReturnID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleReturnID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleReturnID.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSDescription = null;
            this.fld_lkeFK_ARSaleReturnID.BOSError = null;
            this.fld_lkeFK_ARSaleReturnID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSFieldParent = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleReturnID.BOSSelectType = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleReturnID.Location = new System.Drawing.Point(375, 24);
            this.fld_lkeFK_ARSaleReturnID.Name = "fld_lkeFK_ARSaleReturnID";
            this.fld_lkeFK_ARSaleReturnID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleReturnID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleReturnID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleReturnID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleReturnID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleReturnID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleReturnNo", "Mã HBTL"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleReturnDate", "Ngày chứng từ", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default)});
            this.fld_lkeFK_ARSaleReturnID.Properties.DisplayMember = "ARSaleReturnNo";
            this.fld_lkeFK_ARSaleReturnID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARSaleReturnID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARSaleReturnID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleReturnID.Properties.ValueMember = "ARSaleReturnID";
            this.fld_lkeFK_ARSaleReturnID.Screen = null;
            this.fld_lkeFK_ARSaleReturnID.Size = new System.Drawing.Size(172, 20);
            this.fld_lkeFK_ARSaleReturnID.TabIndex = 2;
            this.fld_lkeFK_ARSaleReturnID.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARCustomerID.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(375, 50);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(172, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 6;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_chkSelectedAll.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_chkSelectedAll.BOSDescription = null;
            this.fld_chkSelectedAll.BOSError = null;
            this.fld_chkSelectedAll.BOSFieldGroup = null;
            this.fld_chkSelectedAll.BOSFieldRelation = null;
            this.fld_chkSelectedAll.BOSPrivilege = null;
            this.fld_chkSelectedAll.BOSPropertyName = "EditValue";
            this.fld_chkSelectedAll.Location = new System.Drawing.Point(12, 542);
            this.fld_chkSelectedAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectedAll.Name = "fld_chkSelectedAll";
            this.fld_chkSelectedAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectedAll.Screen = null;
            this.fld_chkSelectedAll.Size = new System.Drawing.Size(118, 19);
            this.fld_chkSelectedAll.TabIndex = 142;
            this.fld_chkSelectedAll.Tag = "DC";
            this.fld_chkSelectedAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectedAll_CheckedChanged);
            // 
            // guiFindSaleReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lkeFK_ARSaleReturnID);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDateTo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDateForm);
            this.Controls.Add(this.fld_dgcARSaleReturnItemsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.Name = "guiFindSaleReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleReturnItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDeliveryDateForm, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDeliveryDateTo, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleReturnID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleReturnItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ARSaleReturnItemsGridControl fld_dgcARSaleReturnItemsGridControl;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDateForm;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDateTo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleReturnID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
    }
}