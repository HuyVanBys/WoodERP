namespace BOSERP.Modules.UserManagement
{
    partial class guiManageUser
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiManageUser));
            this.fld_lkeUserGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeStaff = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_txtConfirmPassword = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPassword = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtUserName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblUserGroup = new BOSComponent.BOSLabel(this.components);
            this.fld_lblStaff = new BOSComponent.BOSLabel(this.components);
            this.fld_lblConfirmPassword = new BOSComponent.BOSLabel(this.components);
            this.fld_lblPassword = new BOSComponent.BOSLabel(this.components);
            this.fld_lblUserName = new BOSComponent.BOSLabel(this.components);
            this.fld_chkUserActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeChooseCustomizeColumn = new BOSComponent.BOSCheckEdit(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fld_ckeAllowExportExcel = new BOSComponent.BOSCheckEdit(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_ckeADUserIsExceptionalSalePermission = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUserGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkUserActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeChooseCustomizeColumn.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeAllowExportExcel.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeADUserIsExceptionalSalePermission.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeUserGroup
            // 
            this.fld_lkeUserGroup.BOSAllowAddNew = false;
            this.fld_lkeUserGroup.BOSAllowDummy = false;
            this.fld_lkeUserGroup.BOSComment = null;
            this.fld_lkeUserGroup.BOSDataMember = "ADUserGroupID";
            this.fld_lkeUserGroup.BOSDataSource = "ADUsers";
            this.fld_lkeUserGroup.BOSDescription = null;
            this.fld_lkeUserGroup.BOSError = null;
            this.fld_lkeUserGroup.BOSFieldGroup = null;
            this.fld_lkeUserGroup.BOSFieldParent = null;
            this.fld_lkeUserGroup.BOSFieldRelation = null;
            this.fld_lkeUserGroup.BOSPrivilege = null;
            this.fld_lkeUserGroup.BOSPropertyName = "EditValue";
            this.fld_lkeUserGroup.BOSSelectType = null;
            this.fld_lkeUserGroup.BOSSelectTypeValue = null;
            this.fld_lkeUserGroup.CurrentDisplayText = null;
            this.fld_lkeUserGroup.Location = new System.Drawing.Point(122, 146);
            this.fld_lkeUserGroup.Name = "fld_lkeUserGroup";
            this.fld_lkeUserGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeUserGroup.Properties.ColumnName = null;
            this.fld_lkeUserGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADUserGroupName", "Tên nhóm")});
            this.fld_lkeUserGroup.Properties.DisplayMember = "ADUserGroupName";
            this.fld_lkeUserGroup.Properties.NullText = "";
            this.fld_lkeUserGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeUserGroup.Properties.ValueMember = "ADUserGroupID";
            this.fld_lkeUserGroup.Screen = null;
            this.fld_lkeUserGroup.Size = new System.Drawing.Size(204, 20);
            this.fld_lkeUserGroup.TabIndex = 4;
            this.fld_lkeUserGroup.Tag = "DC";
            // 
            // fld_lkeStaff
            // 
            this.fld_lkeStaff.BOSAllowAddNew = false;
            this.fld_lkeStaff.BOSAllowDummy = true;
            this.fld_lkeStaff.BOSComment = null;
            this.fld_lkeStaff.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeStaff.BOSDataSource = "ADUsers";
            this.fld_lkeStaff.BOSDescription = null;
            this.fld_lkeStaff.BOSError = null;
            this.fld_lkeStaff.BOSFieldGroup = null;
            this.fld_lkeStaff.BOSFieldParent = null;
            this.fld_lkeStaff.BOSFieldRelation = null;
            this.fld_lkeStaff.BOSPrivilege = null;
            this.fld_lkeStaff.BOSPropertyName = "EditValue";
            this.fld_lkeStaff.BOSSelectType = null;
            this.fld_lkeStaff.BOSSelectTypeValue = null;
            this.fld_lkeStaff.CurrentDisplayText = "";
            this.fld_lkeStaff.Location = new System.Drawing.Point(122, 120);
            this.fld_lkeStaff.Name = "fld_lkeStaff";
            this.fld_lkeStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeStaff.Properties.ColumnName = null;
            this.fld_lkeStaff.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeStaff.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeStaff.Properties.NullText = "";
            this.fld_lkeStaff.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeStaff.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeStaff.Screen = null;
            this.fld_lkeStaff.Size = new System.Drawing.Size(204, 20);
            this.fld_lkeStaff.TabIndex = 3;
            this.fld_lkeStaff.Tag = "DC";
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
            this.fld_btnCancel.Location = new System.Drawing.Point(254, 275);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(100, 25);
            this.fld_btnCancel.TabIndex = 7;
            this.fld_btnCancel.Tag = "";
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(148, 275);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(100, 25);
            this.fld_btnSave.TabIndex = 6;
            this.fld_btnSave.Tag = "";
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_txtConfirmPassword
            // 
            this.fld_txtConfirmPassword.BOSComment = null;
            this.fld_txtConfirmPassword.BOSDataMember = null;
            this.fld_txtConfirmPassword.BOSDataSource = null;
            this.fld_txtConfirmPassword.BOSDescription = null;
            this.fld_txtConfirmPassword.BOSError = null;
            this.fld_txtConfirmPassword.BOSFieldGroup = null;
            this.fld_txtConfirmPassword.BOSFieldRelation = null;
            this.fld_txtConfirmPassword.BOSPrivilege = null;
            this.fld_txtConfirmPassword.BOSPropertyName = null;
            this.fld_txtConfirmPassword.Location = new System.Drawing.Point(122, 69);
            this.fld_txtConfirmPassword.Name = "fld_txtConfirmPassword";
            this.fld_txtConfirmPassword.Properties.PasswordChar = '*';
            this.fld_txtConfirmPassword.Screen = null;
            this.fld_txtConfirmPassword.Size = new System.Drawing.Size(204, 20);
            this.fld_txtConfirmPassword.TabIndex = 2;
            this.fld_txtConfirmPassword.Tag = "";
            // 
            // fld_txtPassword
            // 
            this.fld_txtPassword.BOSComment = null;
            this.fld_txtPassword.BOSDataMember = "ADPassword";
            this.fld_txtPassword.BOSDataSource = "ADUsers";
            this.fld_txtPassword.BOSDescription = null;
            this.fld_txtPassword.BOSError = null;
            this.fld_txtPassword.BOSFieldGroup = null;
            this.fld_txtPassword.BOSFieldRelation = null;
            this.fld_txtPassword.BOSPrivilege = null;
            this.fld_txtPassword.BOSPropertyName = "EditValue";
            this.fld_txtPassword.Location = new System.Drawing.Point(122, 43);
            this.fld_txtPassword.Name = "fld_txtPassword";
            this.fld_txtPassword.Properties.PasswordChar = '*';
            this.fld_txtPassword.Screen = null;
            this.fld_txtPassword.Size = new System.Drawing.Size(204, 20);
            this.fld_txtPassword.TabIndex = 1;
            this.fld_txtPassword.Tag = "DC";
            // 
            // fld_txtUserName
            // 
            this.fld_txtUserName.BOSComment = null;
            this.fld_txtUserName.BOSDataMember = "ADUserName";
            this.fld_txtUserName.BOSDataSource = "ADUsers";
            this.fld_txtUserName.BOSDescription = null;
            this.fld_txtUserName.BOSError = null;
            this.fld_txtUserName.BOSFieldGroup = null;
            this.fld_txtUserName.BOSFieldRelation = null;
            this.fld_txtUserName.BOSPrivilege = null;
            this.fld_txtUserName.BOSPropertyName = "EditValue";
            this.fld_txtUserName.Location = new System.Drawing.Point(122, 17);
            this.fld_txtUserName.Name = "fld_txtUserName";
            this.fld_txtUserName.Screen = null;
            this.fld_txtUserName.Size = new System.Drawing.Size(204, 20);
            this.fld_txtUserName.TabIndex = 0;
            this.fld_txtUserName.Tag = "DC";
            // 
            // fld_lblUserGroup
            // 
            this.fld_lblUserGroup.BOSComment = null;
            this.fld_lblUserGroup.BOSDataMember = null;
            this.fld_lblUserGroup.BOSDataSource = null;
            this.fld_lblUserGroup.BOSDescription = null;
            this.fld_lblUserGroup.BOSError = null;
            this.fld_lblUserGroup.BOSFieldGroup = null;
            this.fld_lblUserGroup.BOSFieldRelation = null;
            this.fld_lblUserGroup.BOSPrivilege = null;
            this.fld_lblUserGroup.BOSPropertyName = null;
            this.fld_lblUserGroup.Location = new System.Drawing.Point(11, 149);
            this.fld_lblUserGroup.Name = "fld_lblUserGroup";
            this.fld_lblUserGroup.Screen = null;
            this.fld_lblUserGroup.Size = new System.Drawing.Size(84, 13);
            this.fld_lblUserGroup.TabIndex = 19;
            this.fld_lblUserGroup.Text = "Nhóm người dùng";
            // 
            // fld_lblStaff
            // 
            this.fld_lblStaff.BOSComment = null;
            this.fld_lblStaff.BOSDataMember = null;
            this.fld_lblStaff.BOSDataSource = null;
            this.fld_lblStaff.BOSDescription = null;
            this.fld_lblStaff.BOSError = null;
            this.fld_lblStaff.BOSFieldGroup = null;
            this.fld_lblStaff.BOSFieldRelation = null;
            this.fld_lblStaff.BOSPrivilege = null;
            this.fld_lblStaff.BOSPropertyName = null;
            this.fld_lblStaff.Location = new System.Drawing.Point(10, 123);
            this.fld_lblStaff.Name = "fld_lblStaff";
            this.fld_lblStaff.Screen = null;
            this.fld_lblStaff.Size = new System.Drawing.Size(48, 13);
            this.fld_lblStaff.TabIndex = 18;
            this.fld_lblStaff.Text = "Nhân viên";
            // 
            // fld_lblConfirmPassword
            // 
            this.fld_lblConfirmPassword.BOSComment = null;
            this.fld_lblConfirmPassword.BOSDataMember = null;
            this.fld_lblConfirmPassword.BOSDataSource = null;
            this.fld_lblConfirmPassword.BOSDescription = null;
            this.fld_lblConfirmPassword.BOSError = null;
            this.fld_lblConfirmPassword.BOSFieldGroup = null;
            this.fld_lblConfirmPassword.BOSFieldRelation = null;
            this.fld_lblConfirmPassword.BOSPrivilege = null;
            this.fld_lblConfirmPassword.BOSPropertyName = null;
            this.fld_lblConfirmPassword.Location = new System.Drawing.Point(11, 72);
            this.fld_lblConfirmPassword.Name = "fld_lblConfirmPassword";
            this.fld_lblConfirmPassword.Screen = null;
            this.fld_lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.fld_lblConfirmPassword.TabIndex = 17;
            this.fld_lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // fld_lblPassword
            // 
            this.fld_lblPassword.BOSComment = null;
            this.fld_lblPassword.BOSDataMember = null;
            this.fld_lblPassword.BOSDataSource = null;
            this.fld_lblPassword.BOSDescription = null;
            this.fld_lblPassword.BOSError = null;
            this.fld_lblPassword.BOSFieldGroup = null;
            this.fld_lblPassword.BOSFieldRelation = null;
            this.fld_lblPassword.BOSPrivilege = null;
            this.fld_lblPassword.BOSPropertyName = null;
            this.fld_lblPassword.Location = new System.Drawing.Point(11, 46);
            this.fld_lblPassword.Name = "fld_lblPassword";
            this.fld_lblPassword.Screen = null;
            this.fld_lblPassword.Size = new System.Drawing.Size(44, 13);
            this.fld_lblPassword.TabIndex = 16;
            this.fld_lblPassword.Text = "Mật khẩu";
            // 
            // fld_lblUserName
            // 
            this.fld_lblUserName.BOSComment = null;
            this.fld_lblUserName.BOSDataMember = null;
            this.fld_lblUserName.BOSDataSource = null;
            this.fld_lblUserName.BOSDescription = null;
            this.fld_lblUserName.BOSError = null;
            this.fld_lblUserName.BOSFieldGroup = null;
            this.fld_lblUserName.BOSFieldRelation = null;
            this.fld_lblUserName.BOSPrivilege = null;
            this.fld_lblUserName.BOSPropertyName = null;
            this.fld_lblUserName.Location = new System.Drawing.Point(11, 20);
            this.fld_lblUserName.Name = "fld_lblUserName";
            this.fld_lblUserName.Screen = null;
            this.fld_lblUserName.Size = new System.Drawing.Size(65, 13);
            this.fld_lblUserName.TabIndex = 15;
            this.fld_lblUserName.Text = "Tên tài khoản";
            // 
            // fld_chkUserActiveCheck
            // 
            this.fld_chkUserActiveCheck.BOSComment = null;
            this.fld_chkUserActiveCheck.BOSDataMember = "ADUserActiveCheck";
            this.fld_chkUserActiveCheck.BOSDataSource = "ADUsers";
            this.fld_chkUserActiveCheck.BOSDescription = null;
            this.fld_chkUserActiveCheck.BOSError = null;
            this.fld_chkUserActiveCheck.BOSFieldGroup = null;
            this.fld_chkUserActiveCheck.BOSFieldRelation = null;
            this.fld_chkUserActiveCheck.BOSPrivilege = null;
            this.fld_chkUserActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkUserActiveCheck.Location = new System.Drawing.Point(227, 20);
            this.fld_chkUserActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkUserActiveCheck.Name = "fld_chkUserActiveCheck";
            this.fld_chkUserActiveCheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_chkUserActiveCheck.Properties.Appearance.Options.UseFont = true;
            this.fld_chkUserActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkUserActiveCheck.Screen = null;
            this.fld_chkUserActiveCheck.Size = new System.Drawing.Size(87, 20);
            this.fld_chkUserActiveCheck.TabIndex = 1;
            this.fld_chkUserActiveCheck.Tag = "DC";
            // 
            // fld_ckeChooseCustomizeColumn
            // 
            this.fld_ckeChooseCustomizeColumn.BOSComment = null;
            this.fld_ckeChooseCustomizeColumn.BOSDataMember = "ADUserIsCustomizeColumn";
            this.fld_ckeChooseCustomizeColumn.BOSDataSource = "ADUsers";
            this.fld_ckeChooseCustomizeColumn.BOSDescription = null;
            this.fld_ckeChooseCustomizeColumn.BOSError = null;
            this.fld_ckeChooseCustomizeColumn.BOSFieldGroup = null;
            this.fld_ckeChooseCustomizeColumn.BOSFieldRelation = null;
            this.fld_ckeChooseCustomizeColumn.BOSPrivilege = null;
            this.fld_ckeChooseCustomizeColumn.BOSPropertyName = "EditValue";
            this.fld_ckeChooseCustomizeColumn.Location = new System.Drawing.Point(12, 20);
            this.fld_ckeChooseCustomizeColumn.MenuManager = this.screenToolbar;
            this.fld_ckeChooseCustomizeColumn.Name = "fld_ckeChooseCustomizeColumn";
            this.fld_ckeChooseCustomizeColumn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_ckeChooseCustomizeColumn.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeChooseCustomizeColumn.Properties.Caption = "Lưu cột tùy chỉnh cho hệ thống";
            this.fld_ckeChooseCustomizeColumn.Screen = null;
            this.fld_ckeChooseCustomizeColumn.Size = new System.Drawing.Size(204, 20);
            this.fld_ckeChooseCustomizeColumn.TabIndex = 0;
            this.fld_ckeChooseCustomizeColumn.Tag = "DC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fld_ckeADUserIsExceptionalSalePermission);
            this.groupBox1.Controls.Add(this.fld_ckeAllowExportExcel);
            this.groupBox1.Controls.Add(this.fld_ckeChooseCustomizeColumn);
            this.groupBox1.Controls.Add(this.fld_chkUserActiveCheck);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 74);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền hạn";
            // 
            // fld_ckeAllowExportExcel
            // 
            this.fld_ckeAllowExportExcel.BOSComment = null;
            this.fld_ckeAllowExportExcel.BOSDataMember = "ADUserIsAllowExportExcel";
            this.fld_ckeAllowExportExcel.BOSDataSource = "ADUsers";
            this.fld_ckeAllowExportExcel.BOSDescription = null;
            this.fld_ckeAllowExportExcel.BOSError = null;
            this.fld_ckeAllowExportExcel.BOSFieldGroup = null;
            this.fld_ckeAllowExportExcel.BOSFieldRelation = null;
            this.fld_ckeAllowExportExcel.BOSPrivilege = null;
            this.fld_ckeAllowExportExcel.BOSPropertyName = "EditValue";
            this.fld_ckeAllowExportExcel.Location = new System.Drawing.Point(12, 45);
            this.fld_ckeAllowExportExcel.MenuManager = this.screenToolbar;
            this.fld_ckeAllowExportExcel.Name = "fld_ckeAllowExportExcel";
            this.fld_ckeAllowExportExcel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_ckeAllowExportExcel.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeAllowExportExcel.Properties.Caption = "Xuất Excel trên lưới";
            this.fld_ckeAllowExportExcel.Screen = null;
            this.fld_ckeAllowExportExcel.Size = new System.Drawing.Size(204, 20);
            this.fld_ckeAllowExportExcel.TabIndex = 2;
            this.fld_ckeAllowExportExcel.Tag = "DC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bosLine1);
            this.groupBox2.Controls.Add(this.fld_lblUserName);
            this.groupBox2.Controls.Add(this.fld_txtUserName);
            this.groupBox2.Controls.Add(this.fld_lblPassword);
            this.groupBox2.Controls.Add(this.fld_lblConfirmPassword);
            this.groupBox2.Controls.Add(this.fld_lkeUserGroup);
            this.groupBox2.Controls.Add(this.fld_txtPassword);
            this.groupBox2.Controls.Add(this.fld_lkeStaff);
            this.groupBox2.Controls.Add(this.fld_txtConfirmPassword);
            this.groupBox2.Controls.Add(this.fld_lblUserGroup);
            this.groupBox2.Controls.Add(this.fld_lblStaff);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 177);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
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
            this.bosLine1.Location = new System.Drawing.Point(9, 97);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(315, 10);
            this.bosLine1.TabIndex = 20;
            this.bosLine1.TabStop = false;
            // 
            // fld_ckeADUserIsExceptionalSalePermission
            // 
            this.fld_ckeADUserIsExceptionalSalePermission.BOSComment = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSDataMember = "ADUserIsExceptionalSalePermission";
            this.fld_ckeADUserIsExceptionalSalePermission.BOSDataSource = "ADUsers";
            this.fld_ckeADUserIsExceptionalSalePermission.BOSDescription = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSError = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSFieldGroup = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSFieldRelation = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSPrivilege = null;
            this.fld_ckeADUserIsExceptionalSalePermission.BOSPropertyName = "EditValue";
            this.fld_ckeADUserIsExceptionalSalePermission.Location = new System.Drawing.Point(227, 45);
            this.fld_ckeADUserIsExceptionalSalePermission.MenuManager = this.screenToolbar;
            this.fld_ckeADUserIsExceptionalSalePermission.Name = "fld_ckeADUserIsExceptionalSalePermission";
            this.fld_ckeADUserIsExceptionalSalePermission.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_ckeADUserIsExceptionalSalePermission.Properties.Appearance.Options.UseFont = true;
            this.fld_ckeADUserIsExceptionalSalePermission.Properties.Caption = "[SALE] Ngoại lệ ";
            this.fld_ckeADUserIsExceptionalSalePermission.Screen = null;
            this.fld_ckeADUserIsExceptionalSalePermission.Size = new System.Drawing.Size(109, 20);
            toolTipTitleItem1.Text = "Giải thích";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Những user [SALE] Ngoại lệ được xem tât cả chứng từ ĐBH của chi nhánh được phân q" +
    "uyền.\r\nNgược lại, chỉ xem được ĐBH của khách hàng user đó quản lý/bán";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.fld_ckeADUserIsExceptionalSalePermission.SuperTip = superToolTip1;
            this.fld_ckeADUserIsExceptionalSalePermission.TabIndex = 3;
            this.fld_ckeADUserIsExceptionalSalePermission.Tag = "DC";
            // 
            // guiManageUser
            // 
            this.AcceptButton = this.fld_btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 326);
            this.ControlBox = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiManageUser.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "guiManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.guiManageUser_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUserGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkUserActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeChooseCustomizeColumn.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeAllowExportExcel.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeADUserIsExceptionalSalePermission.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSLookupEdit fld_lkeUserGroup;
        private BOSComponent.BOSLookupEdit fld_lkeStaff;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSTextBox fld_txtConfirmPassword;
        private BOSComponent.BOSTextBox fld_txtPassword;
        private BOSComponent.BOSTextBox fld_txtUserName;
        private BOSComponent.BOSLabel fld_lblUserGroup;
        private BOSComponent.BOSLabel fld_lblStaff;
        private BOSComponent.BOSLabel fld_lblConfirmPassword;
        private BOSComponent.BOSLabel fld_lblPassword;
        private BOSComponent.BOSLabel fld_lblUserName;
        private BOSComponent.BOSCheckEdit fld_chkUserActiveCheck;
        private BOSComponent.BOSCheckEdit fld_ckeChooseCustomizeColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BOSComponent.BOSCheckEdit fld_ckeAllowExportExcel;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSCheckEdit fld_ckeADUserIsExceptionalSalePermission;
    }
}