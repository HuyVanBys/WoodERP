using BOSComponent;
namespace BOSERP.Modules.Report
{
    partial class RPPTCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPPTCP));
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACCostCenterID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACCostType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteToMonth = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromMonth = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARNormFeeConfigItems = new BOSComponent.BOSGridControl(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostCenterID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnApply.Location = new System.Drawing.Point(557, 15);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(78, 28);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosPanel1.Controls.Add(this.bosButton2);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartmentID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeACCostCenterID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeACAccountID);
            this.bosPanel1.Controls.Add(this.fld_lkeACCostType);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeACSegmentID);
            this.bosPanel1.Controls.Add(this.fld_dteToMonth);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteFromMonth);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1237, 679);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(725, 15);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(78, 28);
            this.bosButton2.TabIndex = 406;
            this.bosButton2.Text = "In";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(51, 13);
            this.bosLabel8.TabIndex = 405;
            this.bosLabel8.Text = "Phòng ban";
            // 
            // fld_lkeHRDepartmentID
            // 
            this.fld_lkeHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentID.BOSComment = null;
            this.fld_lkeHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartmentID.BOSDescription = null;
            this.fld_lkeHRDepartmentID.BOSError = null;
            this.fld_lkeHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentID.BOSSelectType = null;
            this.fld_lkeHRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentID.Location = new System.Drawing.Point(122, 90);
            this.fld_lkeHRDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeHRDepartmentID.Name = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.fld_lkeHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.Screen = null;
            this.fld_lkeHRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentID.TabIndex = 6;
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
            this.bosLabel7.Location = new System.Drawing.Point(304, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(25, 13);
            this.bosLabel7.TabIndex = 403;
            this.bosLabel7.Text = "TTCP";
            // 
            // fld_lkeACCostCenterID
            // 
            this.fld_lkeACCostCenterID.BOSAllowAddNew = false;
            this.fld_lkeACCostCenterID.BOSAllowDummy = true;
            this.fld_lkeACCostCenterID.BOSComment = null;
            this.fld_lkeACCostCenterID.BOSDataMember = "ACCostCenterID";
            this.fld_lkeACCostCenterID.BOSDataSource = "ACCostCenters";
            this.fld_lkeACCostCenterID.BOSDescription = null;
            this.fld_lkeACCostCenterID.BOSError = null;
            this.fld_lkeACCostCenterID.BOSFieldGroup = null;
            this.fld_lkeACCostCenterID.BOSFieldParent = null;
            this.fld_lkeACCostCenterID.BOSFieldRelation = null;
            this.fld_lkeACCostCenterID.BOSPrivilege = null;
            this.fld_lkeACCostCenterID.BOSPropertyName = null;
            this.fld_lkeACCostCenterID.BOSSelectType = null;
            this.fld_lkeACCostCenterID.BOSSelectTypeValue = null;
            this.fld_lkeACCostCenterID.CurrentDisplayText = null;
            this.fld_lkeACCostCenterID.Location = new System.Drawing.Point(389, 64);
            this.fld_lkeACCostCenterID.MenuManager = this.screenToolbar;
            this.fld_lkeACCostCenterID.Name = "fld_lkeACCostCenterID";
            this.fld_lkeACCostCenterID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCostCenterID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterNo", "Mã TTCP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterName", "Tên TTCP")});
            this.fld_lkeACCostCenterID.Properties.DisplayMember = "ACCostCenterName";
            this.fld_lkeACCostCenterID.Properties.ValueMember = "ACCostCenterID";
            this.fld_lkeACCostCenterID.Screen = null;
            this.fld_lkeACCostCenterID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACCostCenterID.TabIndex = 5;
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(12, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(61, 13);
            this.bosLabel6.TabIndex = 401;
            this.bosLabel6.Text = "Tài khoản nợ";
            // 
            // fld_lkeACAccountID
            // 
            this.fld_lkeACAccountID.BOSAllowAddNew = false;
            this.fld_lkeACAccountID.BOSAllowDummy = true;
            this.fld_lkeACAccountID.BOSComment = null;
            this.fld_lkeACAccountID.BOSDataMember = "ACAccountID";
            this.fld_lkeACAccountID.BOSDataSource = "ACAccounts";
            this.fld_lkeACAccountID.BOSDescription = null;
            this.fld_lkeACAccountID.BOSError = null;
            this.fld_lkeACAccountID.BOSFieldGroup = null;
            this.fld_lkeACAccountID.BOSFieldParent = null;
            this.fld_lkeACAccountID.BOSFieldRelation = null;
            this.fld_lkeACAccountID.BOSPrivilege = null;
            this.fld_lkeACAccountID.BOSPropertyName = null;
            this.fld_lkeACAccountID.BOSSelectType = null;
            this.fld_lkeACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeACAccountID.CurrentDisplayText = null;
            this.fld_lkeACAccountID.Location = new System.Drawing.Point(122, 64);
            this.fld_lkeACAccountID.MenuManager = this.screenToolbar;
            this.fld_lkeACAccountID.Name = "fld_lkeACAccountID";
            this.fld_lkeACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeACAccountID.Screen = null;
            this.fld_lkeACAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAccountID.TabIndex = 4;
            // 
            // fld_lkeACCostType
            // 
            this.fld_lkeACCostType.BOSAllowAddNew = false;
            this.fld_lkeACCostType.BOSAllowDummy = true;
            this.fld_lkeACCostType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSDataMember = "ACSegmentType";
            this.fld_lkeACCostType.BOSDataSource = "ACSegments";
            this.fld_lkeACCostType.BOSDescription = null;
            this.fld_lkeACCostType.BOSError = null;
            this.fld_lkeACCostType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSPropertyName = "EditValue";
            this.fld_lkeACCostType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.Location = new System.Drawing.Point(389, 38);
            this.fld_lkeACCostType.Name = "fld_lkeACCostType";
            this.fld_lkeACCostType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACCostType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACCostType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACCostType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACCostType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCostType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACCostType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACCostType.Screen = null;
            this.fld_lkeACCostType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACCostType.TabIndex = 3;
            this.fld_lkeACCostType.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(304, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(60, 13);
            this.bosLabel5.TabIndex = 398;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Nhóm chi phí";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(85, 13);
            this.bosLabel4.TabIndex = 397;
            this.bosLabel4.Text = "Khoản mục chi phí";
            // 
            // fld_lkeACSegmentID
            // 
            this.fld_lkeACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeACSegmentID.BOSAllowDummy = true;
            this.fld_lkeACSegmentID.BOSComment = null;
            this.fld_lkeACSegmentID.BOSDataMember = "ACSegmentID";
            this.fld_lkeACSegmentID.BOSDataSource = "ACSegments";
            this.fld_lkeACSegmentID.BOSDescription = null;
            this.fld_lkeACSegmentID.BOSError = null;
            this.fld_lkeACSegmentID.BOSFieldGroup = null;
            this.fld_lkeACSegmentID.BOSFieldParent = null;
            this.fld_lkeACSegmentID.BOSFieldRelation = null;
            this.fld_lkeACSegmentID.BOSPrivilege = null;
            this.fld_lkeACSegmentID.BOSPropertyName = null;
            this.fld_lkeACSegmentID.BOSSelectType = null;
            this.fld_lkeACSegmentID.BOSSelectTypeValue = null;
            this.fld_lkeACSegmentID.CurrentDisplayText = null;
            this.fld_lkeACSegmentID.Location = new System.Drawing.Point(122, 38);
            this.fld_lkeACSegmentID.MenuManager = this.screenToolbar;
            this.fld_lkeACSegmentID.Name = "fld_lkeACSegmentID";
            this.fld_lkeACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentNo", "Mã khoản mục"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Tên khoản mục")});
            this.fld_lkeACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeACSegmentID.Screen = null;
            this.fld_lkeACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACSegmentID.TabIndex = 2;
            // 
            // fld_dteToMonth
            // 
            this.fld_dteToMonth.BOSComment = null;
            this.fld_dteToMonth.BOSDataMember = null;
            this.fld_dteToMonth.BOSDataSource = null;
            this.fld_dteToMonth.BOSDescription = null;
            this.fld_dteToMonth.BOSError = null;
            this.fld_dteToMonth.BOSFieldGroup = null;
            this.fld_dteToMonth.BOSFieldRelation = null;
            this.fld_dteToMonth.BOSPrivilege = null;
            this.fld_dteToMonth.BOSPropertyName = null;
            this.fld_dteToMonth.EditValue = null;
            this.fld_dteToMonth.Location = new System.Drawing.Point(389, 12);
            this.fld_dteToMonth.MenuManager = this.screenToolbar;
            this.fld_dteToMonth.Name = "fld_dteToMonth";
            this.fld_dteToMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteToMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteToMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteToMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToMonth.Screen = null;
            this.fld_dteToMonth.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToMonth.TabIndex = 1;
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
            this.bosLabel2.Location = new System.Drawing.Point(304, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 392;
            this.bosLabel2.Text = "Đến tháng";
            // 
            // fld_dteFromMonth
            // 
            this.fld_dteFromMonth.BOSComment = null;
            this.fld_dteFromMonth.BOSDataMember = null;
            this.fld_dteFromMonth.BOSDataSource = null;
            this.fld_dteFromMonth.BOSDescription = null;
            this.fld_dteFromMonth.BOSError = null;
            this.fld_dteFromMonth.BOSFieldGroup = null;
            this.fld_dteFromMonth.BOSFieldRelation = null;
            this.fld_dteFromMonth.BOSPrivilege = null;
            this.fld_dteFromMonth.BOSPropertyName = null;
            this.fld_dteFromMonth.EditValue = null;
            this.fld_dteFromMonth.Location = new System.Drawing.Point(122, 12);
            this.fld_dteFromMonth.MenuManager = this.screenToolbar;
            this.fld_dteFromMonth.Name = "fld_dteFromMonth";
            this.fld_dteFromMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromMonth.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteFromMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromMonth.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteFromMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromMonth.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteFromMonth.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromMonth.Screen = null;
            this.fld_dteFromMonth.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromMonth.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(44, 13);
            this.bosLabel1.TabIndex = 390;
            this.bosLabel1.Text = "Từ tháng";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(641, 15);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(78, 28);
            this.bosButton1.TabIndex = 8;
            this.bosButton1.Text = "Xuất excel";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click_1);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_dgcARNormFeeConfigItems);
            this.bosLine1.Location = new System.Drawing.Point(3, 116);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1231, 563);
            this.bosLine1.TabIndex = 377;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Chi tiết    ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(49, 17);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(330, 27);
            this.bosLabel3.TabIndex = 35;
            this.bosLabel3.Text = "BÁO CÁO PHÂN TÍCH CHI PHÍ";
            // 
            // fld_dgcARNormFeeConfigItems
            // 
            this.fld_dgcARNormFeeConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARNormFeeConfigItems.BOSComment = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataMember = null;
            this.fld_dgcARNormFeeConfigItems.BOSDataSource = "APInvoiceIns";
            this.fld_dgcARNormFeeConfigItems.BOSDescription = null;
            this.fld_dgcARNormFeeConfigItems.BOSError = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldGroup = null;
            this.fld_dgcARNormFeeConfigItems.BOSFieldRelation = null;
            this.fld_dgcARNormFeeConfigItems.BOSGridType = null;
            this.fld_dgcARNormFeeConfigItems.BOSPrivilege = null;
            this.fld_dgcARNormFeeConfigItems.BOSPropertyName = null;
            this.fld_dgcARNormFeeConfigItems.Location = new System.Drawing.Point(0, 50);
            this.fld_dgcARNormFeeConfigItems.MenuManager = this.screenToolbar;
            this.fld_dgcARNormFeeConfigItems.Name = "fld_dgcARNormFeeConfigItems";
            this.fld_dgcARNormFeeConfigItems.PrintReport = false;
            this.fld_dgcARNormFeeConfigItems.Screen = null;
            this.fld_dgcARNormFeeConfigItems.Size = new System.Drawing.Size(1228, 510);
            this.fld_dgcARNormFeeConfigItems.TabIndex = 16;
            // 
            // RPPTCP
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 679);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPPTCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "BÁO CÁO PHÂN TÍCH CHI PHÍ";
            this.Load += new System.EventHandler(this.RPPTCP_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostCenterID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromMonth.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARNormFeeConfigItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnApply;
        private BOSPanel bosPanel1;
        private BOSLine bosLine1;
        private BOSGridControl fld_dgcARNormFeeConfigItems;
        private BOSLabel bosLabel3;
        private BOSButton bosButton1;
        private BOSDateEdit fld_dteToMonth;
        private BOSLabel bosLabel2;
        private BOSDateEdit fld_dteFromMonth;
        private BOSLabel bosLabel1;
        private BOSLabel bosLabel4;
        private BOSLookupEdit fld_lkeACSegmentID;
        private BOSLookupEdit fld_lkeACCostType;
        private BOSLabel bosLabel5;
        private BOSLabel bosLabel6;
        private BOSLookupEdit fld_lkeACAccountID;
        private BOSLabel bosLabel7;
        private BOSLookupEdit fld_lkeACCostCenterID;
        private BOSLabel bosLabel8;
        private BOSLookupEdit fld_lkeHRDepartmentID;
        private BOSButton bosButton2;
    }
}