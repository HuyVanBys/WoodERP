namespace BOSERP.Modules.Report
{
    partial class RP110
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_lkeACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAssetID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_ACDepreciationCostAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentRoomID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDepreciationCostAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // fld_lkeACAccountID
            // 
            this.fld_lkeACAccountID.BOSAllowAddNew = false;
            this.fld_lkeACAccountID.BOSAllowDummy = true;
            this.fld_lkeACAccountID.BOSComment = null;
            this.fld_lkeACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeACAccountID.BOSDataSource = "ICProducts";
            this.fld_lkeACAccountID.BOSDescription = null;
            this.fld_lkeACAccountID.BOSError = null;
            this.fld_lkeACAccountID.BOSFieldGroup = null;
            this.fld_lkeACAccountID.BOSFieldParent = null;
            this.fld_lkeACAccountID.BOSFieldRelation = null;
            this.fld_lkeACAccountID.BOSPrivilege = null;
            this.fld_lkeACAccountID.BOSPropertyName = null;
            this.fld_lkeACAccountID.BOSSelectType = null;
            this.fld_lkeACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeACAccountID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Location = new System.Drawing.Point(107, 99);
            this.fld_lkeACAccountID.Name = "fld_lkeACAccountID";
            this.fld_lkeACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeACAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeACAccountID.Screen = null;
            this.fld_lkeACAccountID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeACAccountID.TabIndex = 120;
            this.fld_lkeACAccountID.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.bosLabel3.Location = new System.Drawing.Point(21, 102);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(46, 13);
            this.bosLabel3.TabIndex = 121;
            this.bosLabel3.Text = "Tài khoản";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(21, 76);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 116;
            this.bosLabel11.Text = "Tài sản";
            // 
            // fld_lkeACAssetID
            // 
            this.fld_lkeACAssetID.BOSAllowAddNew = false;
            this.fld_lkeACAssetID.BOSAllowDummy = true;
            this.fld_lkeACAssetID.BOSComment = null;
            this.fld_lkeACAssetID.BOSDataMember = "ACAssetID";
            this.fld_lkeACAssetID.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetID.BOSDescription = null;
            this.fld_lkeACAssetID.BOSError = null;
            this.fld_lkeACAssetID.BOSFieldGroup = null;
            this.fld_lkeACAssetID.BOSFieldParent = null;
            this.fld_lkeACAssetID.BOSFieldRelation = null;
            this.fld_lkeACAssetID.BOSPrivilege = null;
            this.fld_lkeACAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetID.BOSSelectType = "";
            this.fld_lkeACAssetID.BOSSelectTypeValue = "";
            this.fld_lkeACAssetID.CurrentDisplayText = null;
            this.fld_lkeACAssetID.Location = new System.Drawing.Point(107, 73);
            this.fld_lkeACAssetID.Name = "fld_lkeACAssetID";
            this.fld_lkeACAssetID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACAssetID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACAssetID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACAssetID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã tài sản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên tài sản")});
            this.fld_lkeACAssetID.Properties.DisplayMember = "ACAssetName";
            this.fld_lkeACAssetID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeACAssetID.Screen = null;
            this.fld_lkeACAssetID.Size = new System.Drawing.Size(385, 20);
            this.fld_lkeACAssetID.TabIndex = 117;
            this.fld_lkeACAssetID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(21, 24);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 115;
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
            this.fld_dteFromDate.Location = new System.Drawing.Point(107, 21);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteFromDate.TabIndex = 112;
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
            this.bosLabel2.Location = new System.Drawing.Point(274, 24);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 114;
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
            this.fld_dteToDate.Location = new System.Drawing.Point(359, 21);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteToDate.TabIndex = 113;
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(417, 125);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 110;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
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
            this.fld_btnApply.Location = new System.Drawing.Point(326, 125);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 111;
            this.fld_btnApply.Text = "In";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_lkeFK_ACDepreciationCostAccountID
            // 
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSComment = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDataMember = "FK_ACDepreciationCostAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDescription = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSError = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSPropertyName = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDepreciationCostAccountID.Location = new System.Drawing.Point(359, 99);
            this.fld_lkeFK_ACDepreciationCostAccountID.Name = "fld_lkeFK_ACDepreciationCostAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.Screen = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_ACDepreciationCostAccountID.TabIndex = 122;
            this.fld_lkeFK_ACDepreciationCostAccountID.Tag = global::Localization.ReportLocalizedResources.tutu;
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
            this.bosLabel4.Location = new System.Drawing.Point(274, 102);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(79, 13);
            this.bosLabel4.TabIndex = 123;
            this.bosLabel4.Text = "Tài khoản chi phí";
            // 
            // fld_lkeHRDepartmentRoomID1
            // 
            this.fld_lkeHRDepartmentRoomID1.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID1.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID1.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID1.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID1.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID1.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID1.BOSError = null;
            this.fld_lkeHRDepartmentRoomID1.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID1.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomID1.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomID1.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID1.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRoomID1.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID1.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID1.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID1.Location = new System.Drawing.Point(107, 47);
            this.fld_lkeHRDepartmentRoomID1.MenuManager = this.screenToolbar;
            this.fld_lkeHRDepartmentRoomID1.Name = "fld_lkeHRDepartmentRoomID1";
            this.fld_lkeHRDepartmentRoomID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomNo", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Tên phòng ban")});
            this.fld_lkeHRDepartmentRoomID1.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID1.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID1.Screen = null;
            this.fld_lkeHRDepartmentRoomID1.Size = new System.Drawing.Size(385, 20);
            this.fld_lkeHRDepartmentRoomID1.TabIndex = 124;
            this.fld_lkeHRDepartmentRoomID1.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Location = new System.Drawing.Point(21, 50);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(51, 13);
            this.bosLabel5.TabIndex = 125;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Phòng ban";
            // 
            // RP110
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 159);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeHRDepartmentRoomID1);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_lkeFK_ACDepreciationCostAccountID);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeACAccountID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.fld_lkeACAssetID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dteFromDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_dteToDate);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP110";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.RP110_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_dteToDate, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteFromDate, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAssetID, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeACAccountID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACDepreciationCostAccountID, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRDepartmentRoomID1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDepreciationCostAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BOSComponent.BOSLookupEdit fld_lkeACAccountID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeACAssetID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDepreciationCostAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID1;
        private BOSComponent.BOSLabel bosLabel5;
    }
}