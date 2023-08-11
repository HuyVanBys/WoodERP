namespace BOSERP.Modules.DeliveryPlan
{
    partial class guiPrintMultiDeliveryPlan
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dgcDeliveryPlansGridControl = new BOSERP.Modules.DeliveryPlan.ARDeliveryPlanForPrintsGridControl();
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ARDeliveryPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDeliveryPlanType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteDeliveryPlanDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteDeliveryPlanDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDeliveryPlansGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateTo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_btnClose.Location = new System.Drawing.Point(891, 537);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 2;
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
            this.fld_btnApply.Location = new System.Drawing.Point(802, 537);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 1;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dgcDeliveryPlansGridControl
            // 
            this.fld_dgcDeliveryPlansGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcDeliveryPlansGridControl.BOSComment = null;
            this.fld_dgcDeliveryPlansGridControl.BOSDataMember = null;
            this.fld_dgcDeliveryPlansGridControl.BOSDataSource = "ARDeliveryPlans";
            this.fld_dgcDeliveryPlansGridControl.BOSDescription = null;
            this.fld_dgcDeliveryPlansGridControl.BOSError = null;
            this.fld_dgcDeliveryPlansGridControl.BOSFieldGroup = null;
            this.fld_dgcDeliveryPlansGridControl.BOSFieldRelation = null;
            this.fld_dgcDeliveryPlansGridControl.BOSGridType = null;
            this.fld_dgcDeliveryPlansGridControl.BOSPrivilege = null;
            this.fld_dgcDeliveryPlansGridControl.BOSPropertyName = null;
            this.fld_dgcDeliveryPlansGridControl.Location = new System.Drawing.Point(12, 77);
            this.fld_dgcDeliveryPlansGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcDeliveryPlansGridControl.Name = "fld_dgcDeliveryPlansGridControl";
            this.fld_dgcDeliveryPlansGridControl.PrintReport = false;
            this.fld_dgcDeliveryPlansGridControl.Screen = null;
            this.fld_dgcDeliveryPlansGridControl.Size = new System.Drawing.Size(961, 454);
            this.fld_dgcDeliveryPlansGridControl.TabIndex = 13;
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(877, 25);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(94, 27);
            this.fld_btnFind.TabIndex = 0;
            this.fld_btnFind.Text = "Tìm kiếm";
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_lkeFK_ARDeliveryPlanID
            // 
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARDeliveryPlanID.BOSAllowDummy = true;
            this.fld_lkeFK_ARDeliveryPlanID.BOSComment = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataMember = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSDataSource = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSDescription = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSError = null;
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectType = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_ARDeliveryPlanID.Location = new System.Drawing.Point(78, 25);
            this.fld_lkeFK_ARDeliveryPlanID.Name = "fld_lkeFK_ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARDeliveryPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanNo", "Mã KHGH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanName", "Tên KHGH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanBeginDate", "Bắt đầu", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARDeliveryPlanEndDate", "Kết thúc", 20, DevExpress.Utils.FormatType.DateTime, "d", true, DevExpress.Utils.HorzAlignment.Default)});
            this.fld_lkeFK_ARDeliveryPlanID.Properties.DisplayMember = "ARDeliveryPlanNo";
            this.fld_lkeFK_ARDeliveryPlanID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARDeliveryPlanID.Properties.ValueMember = "ARDeliveryPlanID";
            this.fld_lkeFK_ARDeliveryPlanID.Screen = null;
            this.fld_lkeFK_ARDeliveryPlanID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ARDeliveryPlanID.TabIndex = 0;
            this.fld_lkeFK_ARDeliveryPlanID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = string.Empty;
            this.bosLabel6.BOSDataMember = string.Empty;
            this.bosLabel6.BOSDataSource = string.Empty;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = string.Empty;
            this.bosLabel6.BOSFieldRelation = string.Empty;
            this.bosLabel6.BOSPrivilege = string.Empty;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(12, 28);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 142;
            this.bosLabel6.Tag = string.Empty;
            this.bosLabel6.Text = "Mã KHGH";
            // 
            // fld_lkeARDeliveryPlanType
            // 
            this.fld_lkeARDeliveryPlanType.BOSAllowAddNew = false;
            this.fld_lkeARDeliveryPlanType.BOSAllowDummy = true;
            this.fld_lkeARDeliveryPlanType.BOSComment = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSDataMember = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSDataSource = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSDescription = null;
            this.fld_lkeARDeliveryPlanType.BOSError = null;
            this.fld_lkeARDeliveryPlanType.BOSFieldGroup = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSFieldParent = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSFieldRelation = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSPrivilege = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSPropertyName = "EditValue";
            this.fld_lkeARDeliveryPlanType.BOSSelectType = string.Empty;
            this.fld_lkeARDeliveryPlanType.BOSSelectTypeValue = string.Empty;
            this.fld_lkeARDeliveryPlanType.CurrentDisplayText = null;
            this.fld_lkeARDeliveryPlanType.Location = new System.Drawing.Point(281, 26);
            this.fld_lkeARDeliveryPlanType.Name = "fld_lkeARDeliveryPlanType";
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDeliveryPlanType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDeliveryPlanType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Loại kế hoạch")});
            this.fld_lkeARDeliveryPlanType.Properties.NullText = string.Empty;
            this.fld_lkeARDeliveryPlanType.Properties.PopupWidth = 40;
            this.fld_lkeARDeliveryPlanType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDeliveryPlanType.Screen = null;
            this.fld_lkeARDeliveryPlanType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeARDeliveryPlanType.TabIndex = 1;
            this.fld_lkeARDeliveryPlanType.Tag = "DC";
            this.fld_lkeARDeliveryPlanType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeARDeliveryPlanType_CloseUp);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(224, 29);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 144;
            this.bosLabel1.Text = "Loại KH";
            // 
            // fld_dteDeliveryPlanDateFrom
            // 
            this.fld_dteDeliveryPlanDateFrom.BOSComment = null;
            this.fld_dteDeliveryPlanDateFrom.BOSDataMember = string.Empty;
            this.fld_dteDeliveryPlanDateFrom.BOSDataSource = string.Empty;
            this.fld_dteDeliveryPlanDateFrom.BOSDescription = null;
            this.fld_dteDeliveryPlanDateFrom.BOSError = null;
            this.fld_dteDeliveryPlanDateFrom.BOSFieldGroup = null;
            this.fld_dteDeliveryPlanDateFrom.BOSFieldRelation = null;
            this.fld_dteDeliveryPlanDateFrom.BOSPrivilege = null;
            this.fld_dteDeliveryPlanDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteDeliveryPlanDateFrom.EditValue = null;
            this.fld_dteDeliveryPlanDateFrom.Location = new System.Drawing.Point(492, 25);
            this.fld_dteDeliveryPlanDateFrom.Name = "fld_dteDeliveryPlanDateFrom";
            this.fld_dteDeliveryPlanDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteDeliveryPlanDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteDeliveryPlanDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteDeliveryPlanDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteDeliveryPlanDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteDeliveryPlanDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteDeliveryPlanDateFrom.Screen = null;
            this.fld_dteDeliveryPlanDateFrom.Size = new System.Drawing.Size(131, 20);
            this.fld_dteDeliveryPlanDateFrom.TabIndex = 2;
            this.fld_dteDeliveryPlanDateFrom.Tag = "DC";
            this.fld_dteDeliveryPlanDateFrom.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dteDeliveryPlanDateFrom_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(429, 28);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 146;
            this.bosLabel2.Tag = string.Empty;
            this.bosLabel2.Text = "Từ ngày";
            // 
            // fld_dteDeliveryPlanDateTo
            // 
            this.fld_dteDeliveryPlanDateTo.BOSComment = null;
            this.fld_dteDeliveryPlanDateTo.BOSDataMember = string.Empty;
            this.fld_dteDeliveryPlanDateTo.BOSDataSource = string.Empty;
            this.fld_dteDeliveryPlanDateTo.BOSDescription = null;
            this.fld_dteDeliveryPlanDateTo.BOSError = null;
            this.fld_dteDeliveryPlanDateTo.BOSFieldGroup = null;
            this.fld_dteDeliveryPlanDateTo.BOSFieldRelation = null;
            this.fld_dteDeliveryPlanDateTo.BOSPrivilege = null;
            this.fld_dteDeliveryPlanDateTo.BOSPropertyName = "EditValue";
            this.fld_dteDeliveryPlanDateTo.EditValue = null;
            this.fld_dteDeliveryPlanDateTo.Location = new System.Drawing.Point(713, 25);
            this.fld_dteDeliveryPlanDateTo.Name = "fld_dteDeliveryPlanDateTo";
            this.fld_dteDeliveryPlanDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteDeliveryPlanDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteDeliveryPlanDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteDeliveryPlanDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteDeliveryPlanDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteDeliveryPlanDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteDeliveryPlanDateTo.Screen = null;
            this.fld_dteDeliveryPlanDateTo.Size = new System.Drawing.Size(131, 20);
            this.fld_dteDeliveryPlanDateTo.TabIndex = 3;
            this.fld_dteDeliveryPlanDateTo.Tag = "DC";
            this.fld_dteDeliveryPlanDateTo.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_dteDeliveryPlanDateTo_CloseUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(643, 28);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(46, 13);
            this.bosLabel3.TabIndex = 148;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Đến ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bosLabel6);
            this.groupBox1.Controls.Add(this.fld_dteDeliveryPlanDateTo);
            this.groupBox1.Controls.Add(this.fld_lkeFK_ARDeliveryPlanID);
            this.groupBox1.Controls.Add(this.bosLabel3);
            this.groupBox1.Controls.Add(this.bosLabel1);
            this.groupBox1.Controls.Add(this.fld_dteDeliveryPlanDateFrom);
            this.groupBox1.Controls.Add(this.fld_lkeARDeliveryPlanType);
            this.groupBox1.Controls.Add(this.bosLabel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 65);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // guiPrintMultiDeliveryPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(986, 576);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_dgcDeliveryPlansGridControl);
            this.Controls.Add(this.fld_btnFind);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiPrintMultiDeliveryPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm ";
            this.Load += new System.EventHandler(this.guiChooseMaterials_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_btnFind, 0);
            this.Controls.SetChildIndex(this.fld_dgcDeliveryPlansGridControl, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDeliveryPlansGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARDeliveryPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDeliveryPlanType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDeliveryPlanDateTo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSERP.Modules.DeliveryPlan.ARDeliveryPlanForPrintsGridControl fld_dgcDeliveryPlansGridControl;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARDeliveryPlanID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeARDeliveryPlanType;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteDeliveryPlanDateFrom;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteDeliveryPlanDateTo;
        private BOSComponent.BOSLabel bosLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}