namespace BOSERP.Modules.DeliveryPlan
{
    partial class guiFindSaleOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiFindSaleOrder));
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcARSaleOrderItemsGridControl = new BOSERP.Modules.DeliveryPlan.ARSaleOrderItemsGridControl();
            this.fld_dteARSaleOrderDeliveryDateForm = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARSaleOrderDeliveryDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARDeliveryPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARDeliveryPlanAddNewType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtARSaleOrderSaleAgreement = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanAddNewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).BeginInit();
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
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(12, 27);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(87, 13);
            this.bosLabel3.TabIndex = 128;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Ngày giao hàng từ";
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
            this.fld_btnClose.Location = new System.Drawing.Point(816, 551);
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
            this.fld_btnApply.Location = new System.Drawing.Point(727, 551);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 9;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcARSaleOrderItemsGridControl
            // 
            this.fld_dgcARSaleOrderItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItemsGridControl.BOSComment = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItemsGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSError = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItemsGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItemsGridControl.CommodityType = "";
            this.fld_dgcARSaleOrderItemsGridControl.Location = new System.Drawing.Point(12, 86);
            this.fld_dgcARSaleOrderItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrderItemsGridControl.Name = "fld_dgcARSaleOrderItemsGridControl";
            this.fld_dgcARSaleOrderItemsGridControl.PrintReport = false;
            this.fld_dgcARSaleOrderItemsGridControl.Screen = null;
            this.fld_dgcARSaleOrderItemsGridControl.Size = new System.Drawing.Size(887, 459);
            this.fld_dgcARSaleOrderItemsGridControl.TabIndex = 8;
            this.fld_dgcARSaleOrderItemsGridControl.Tag = "";
            // 
            // fld_dteARSaleOrderDeliveryDateForm
            // 
            this.fld_dteARSaleOrderDeliveryDateForm.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataMember = "";
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDataSource = "";
            this.fld_dteARSaleOrderDeliveryDateForm.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDateForm.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDateForm.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Location = new System.Drawing.Point(105, 24);
            this.fld_dteARSaleOrderDeliveryDateForm.Name = "fld_dteARSaleOrderDeliveryDateForm";
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDateForm.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDateForm.Screen = null;
            this.fld_dteARSaleOrderDeliveryDateForm.Size = new System.Drawing.Size(129, 20);
            this.fld_dteARSaleOrderDeliveryDateForm.TabIndex = 0;
            this.fld_dteARSaleOrderDeliveryDateForm.Tag = "DC";
            // 
            // fld_dteARSaleOrderDeliveryDateTo
            // 
            this.fld_dteARSaleOrderDeliveryDateTo.BOSComment = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDataMember = "";
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDataSource = "";
            this.fld_dteARSaleOrderDeliveryDateTo.BOSDescription = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSError = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSFieldGroup = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSFieldRelation = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSPrivilege = null;
            this.fld_dteARSaleOrderDeliveryDateTo.BOSPropertyName = "EditValue";
            this.fld_dteARSaleOrderDeliveryDateTo.EditValue = null;
            this.fld_dteARSaleOrderDeliveryDateTo.Location = new System.Drawing.Point(105, 50);
            this.fld_dteARSaleOrderDeliveryDateTo.Name = "fld_dteARSaleOrderDeliveryDateTo";
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARSaleOrderDeliveryDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARSaleOrderDeliveryDateTo.Screen = null;
            this.fld_dteARSaleOrderDeliveryDateTo.Size = new System.Drawing.Size(129, 20);
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
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 53);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(46, 13);
            this.bosLabel1.TabIndex = 131;
            this.bosLabel1.Tag = "";
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
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(250, 27);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(41, 13);
            this.bosLabel2.TabIndex = 134;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã ĐBH";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(250, 53);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(32, 13);
            this.bosLabel4.TabIndex = 135;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Số HĐ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(444, 53);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(20, 13);
            this.bosLabel5.TabIndex = 139;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Loại";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(444, 27);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 138;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mã ĐNXK";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(648, 27);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(58, 13);
            this.bosLabel7.TabIndex = 141;
            this.bosLabel7.Tag = "";
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
            this.fld_btnFind.Location = new System.Drawing.Point(712, 53);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(137, 27);
            this.fld_btnFind.TabIndex = 7;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = "";
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = "";
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = "";
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = "";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(297, 24);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã ĐBH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDate", "Ngày chứng từ", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao hàng", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = "";
            this.fld_lkeFK_ARSaleOrderID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 2;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // fld_lkeFK_ARDeliveryPlanID
            // 
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowDummy = true;
            this.fld_lkeFK_ARDeliveryPlanID.BOSComment = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataMember = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataSource = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSDescription = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSError = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldGroup = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldParent = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldRelation = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSPrivilege = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectType = "";
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARDeliveryPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_ARDeliveryPlanID.Location = new System.Drawing.Point(499, 24);
            this.fld_lkeFK_ARDeliveryPlanID.Name = "fld_lkeFK_ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ColumnName = null;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanNo", "Mã ĐNXK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanName", "Tên ĐNXK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanBeginDate", "Bắt đầu", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanEndDate", "Kết thúc", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_ARDeliveryPlanID.Properties.DisplayMember = "ARDeliveryPlanNo";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.NullText = "";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ValueMember = "ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Screen = null;
            this.fld_lkeFK_ARDeliveryPlanID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ARDeliveryPlanID.TabIndex = 4;
            this.fld_lkeFK_ARDeliveryPlanID.Tag = "DC";
            // 
            // fld_lkeARDeliveryPlanAddNewType
            // 
            this.fld_lkeARDeliveryPlanAddNewType.BOSAllowAddNew = false;
            this.fld_lkeARDeliveryPlanAddNewType.BOSAllowDummy = false;
            this.fld_lkeARDeliveryPlanAddNewType.BOSComment = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSDataMember = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSDataSource = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSDescription = null;
            this.fld_lkeARDeliveryPlanAddNewType.BOSError = null;
            this.fld_lkeARDeliveryPlanAddNewType.BOSFieldGroup = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSFieldParent = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSFieldRelation = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSPrivilege = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanAddNewType.BOSSelectType = "";
            this.fld_lkeARDeliveryPlanAddNewType.BOSSelectTypeValue = "";
            this.fld_lkeARDeliveryPlanAddNewType.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanAddNewType.Location = new System.Drawing.Point(499, 50);
            this.fld_lkeARDeliveryPlanAddNewType.Name = "fld_lkeARDeliveryPlanAddNewType";
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanAddNewType.Properties.ColumnName = null;
            this.fld_lkeARDeliveryPlanAddNewType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Loại")});
            this.fld_lkeARDeliveryPlanAddNewType.Properties.NullText = "";
            this.fld_lkeARDeliveryPlanAddNewType.Properties.PopupWidth = 40;
            this.fld_lkeARDeliveryPlanAddNewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDeliveryPlanAddNewType.Screen = null;
            this.fld_lkeARDeliveryPlanAddNewType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeARDeliveryPlanAddNewType.TabIndex = 5;
            this.fld_lkeARDeliveryPlanAddNewType.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "";
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
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(713, 24);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(137, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 6;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // fld_txtARSaleOrderSaleAgreement
            // 
            this.fld_txtARSaleOrderSaleAgreement.BOSComment = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSDataMember = "";
            this.fld_txtARSaleOrderSaleAgreement.BOSDataSource = "";
            this.fld_txtARSaleOrderSaleAgreement.BOSDescription = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSError = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldGroup = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSFieldRelation = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPrivilege = null;
            this.fld_txtARSaleOrderSaleAgreement.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderSaleAgreement.Location = new System.Drawing.Point(297, 50);
            this.fld_txtARSaleOrderSaleAgreement.MenuManager = this.screenToolbar;
            this.fld_txtARSaleOrderSaleAgreement.Name = "fld_txtARSaleOrderSaleAgreement";
            this.fld_txtARSaleOrderSaleAgreement.Screen = null;
            this.fld_txtARSaleOrderSaleAgreement.Size = new System.Drawing.Size(131, 20);
            this.fld_txtARSaleOrderSaleAgreement.TabIndex = 3;
            this.fld_txtARSaleOrderSaleAgreement.Tag = "DC";
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = "";
            this.fld_chkSelectedAll.BOSDataSource = "";
            this.fld_chkSelectedAll.BOSDescription = null;
            this.fld_chkSelectedAll.BOSError = null;
            this.fld_chkSelectedAll.BOSFieldGroup = null;
            this.fld_chkSelectedAll.BOSFieldRelation = null;
            this.fld_chkSelectedAll.BOSPrivilege = null;
            this.fld_chkSelectedAll.BOSPropertyName = "EditValue";
            this.fld_chkSelectedAll.Location = new System.Drawing.Point(12, 549);
            this.fld_chkSelectedAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectedAll.Name = "fld_chkSelectedAll";
            this.fld_chkSelectedAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectedAll.Screen = null;
            this.fld_chkSelectedAll.Size = new System.Drawing.Size(118, 20);
            this.fld_chkSelectedAll.TabIndex = 142;
            this.fld_chkSelectedAll.Tag = "DC";
            this.fld_chkSelectedAll.Visible = false;
            this.fld_chkSelectedAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectedAll_CheckedChanged);
            // 
            // guiFindSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(911, 590);
            this.ControlBox = true;
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_txtARSaleOrderSaleAgreement);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.Controls.Add(this.fld_lkeARDeliveryPlanAddNewType);
            this.Controls.Add(this.fld_lkeFK_ARDeliveryPlanID);
            this.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDateTo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dteARSaleOrderDeliveryDateForm);
            this.Controls.Add(this.fld_dgcARSaleOrderItemsGridControl);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Controls.Add(this.bosLabel3);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiFindSaleOrder.IconOptions.Icon")));
            this.Name = "guiFindSaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.guiAddWorkGroup_Load);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrderItemsGridControl, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDeliveryDateForm, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteARSaleOrderDeliveryDateTo, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARSaleOrderID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARDeliveryPlanID, 0);
            this.Controls.SetChildIndex(this.fld_lkeARDeliveryPlanAddNewType, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerID, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleOrderSaleAgreement, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARSaleOrderDeliveryDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanAddNewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderSaleAgreement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private ARSaleOrderItemsGridControl fld_dgcARSaleOrderItemsGridControl;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDateForm;
        private BOSComponent.BOSDateEdit fld_dteARSaleOrderDeliveryDateTo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARDeliveryPlanID;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanAddNewType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderSaleAgreement;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
    }
}