namespace BOSERP.Modules.UserManagement
{
    partial class guiAddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddUsers));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtUser = new DevExpress.XtraEditors.TextEdit();
            this.fld_btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUser = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lkeStaff = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // fld_txtUser
            // 
            this.fld_txtUser.Location = new System.Drawing.Point(12, 32);
            this.fld_txtUser.Name = "fld_txtUser";
            this.fld_txtUser.Size = new System.Drawing.Size(303, 20);
            this.fld_txtUser.TabIndex = 1;
            // 
            // fld_btnAddUser
            // 
            this.fld_btnAddUser.Location = new System.Drawing.Point(85, 84);
            this.fld_btnAddUser.Name = "fld_btnAddUser";
            this.fld_btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUser.TabIndex = 2;
            this.fld_btnAddUser.Text = "Đồng ý";
            this.fld_btnAddUser.Click += new System.EventHandler(this.fld_btnAddUser_Click);
            // 
            // fld_btnCloseUser
            // 
            this.fld_btnCloseUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUser.Location = new System.Drawing.Point(166, 84);
            this.fld_btnCloseUser.Name = "fld_btnCloseUser";
            this.fld_btnCloseUser.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUser.TabIndex = 3;
            this.fld_btnCloseUser.Text = "Hủy bỏ";
            this.fld_btnCloseUser.Click += new System.EventHandler(this.fld_btnCloseUser_Click);
            // 
            // fld_lkeStaff
            // 
            this.fld_lkeStaff.BOSAllowAddNew = false;
            this.fld_lkeStaff.BOSAllowDummy = true;
            this.fld_lkeStaff.BOSComment = null;
            this.fld_lkeStaff.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeStaff.BOSDataSource = "HREmployeeGroups";
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
            this.fld_lkeStaff.Location = new System.Drawing.Point(12, 58);
            this.fld_lkeStaff.Name = "fld_lkeStaff";
            this.fld_lkeStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeStaff.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeStaff.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeStaff.Properties.NullText = "";
            this.fld_lkeStaff.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeStaff.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeStaff.Screen = null;
            this.fld_lkeStaff.Size = new System.Drawing.Size(303, 20);
            this.fld_lkeStaff.TabIndex = 6;
            this.fld_lkeStaff.Tag = "DC";
            // 
            // guiAddUsers
            // 
            this.AcceptButton = this.fld_btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUser;
            this.ClientSize = new System.Drawing.Size(327, 119);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeStaff);
            this.Controls.Add(this.fld_btnCloseUser);
            this.Controls.Add(this.fld_btnAddUser);
            this.Controls.Add(this.fld_txtUser);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhân viên";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_txtUser, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUser, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUser, 0);
            this.Controls.SetChildIndex(this.fld_lkeStaff, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit fld_txtUser;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUser;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUser;
        private BOSComponent.BOSLookupEdit fld_lkeStaff;
    }
}