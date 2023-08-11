namespace BOSERP.Modules.UserManagement
{
    partial class guiCopyPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiCopyPermission));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUser = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lkeUserGroup = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUserGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm người dùng";
            // 
            // fld_btnAddUser
            // 
            this.fld_btnAddUser.Location = new System.Drawing.Point(106, 69);
            this.fld_btnAddUser.Name = "fld_btnAddUser";
            this.fld_btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUser.TabIndex = 2;
            this.fld_btnAddUser.Text = "Đồng ý";
            this.fld_btnAddUser.Click += new System.EventHandler(this.fld_btnAddUser_Click);
            // 
            // fld_btnCloseUser
            // 
            this.fld_btnCloseUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUser.Location = new System.Drawing.Point(187, 69);
            this.fld_btnCloseUser.Name = "fld_btnCloseUser";
            this.fld_btnCloseUser.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUser.TabIndex = 3;
            this.fld_btnCloseUser.Text = "Hủy bỏ";
            this.fld_btnCloseUser.Click += new System.EventHandler(this.fld_btnCloseUser_Click);
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
            this.fld_lkeUserGroup.Location = new System.Drawing.Point(12, 35);
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
            this.fld_lkeUserGroup.Size = new System.Drawing.Size(250, 20);
            this.fld_lkeUserGroup.TabIndex = 20;
            this.fld_lkeUserGroup.Tag = "DC";
            // 
            // guiCopyPermission
            // 
            this.AcceptButton = this.fld_btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUser;
            this.ClientSize = new System.Drawing.Size(283, 114);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeUserGroup);
            this.Controls.Add(this.fld_btnCloseUser);
            this.Controls.Add(this.fld_btnAddUser);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiCopyPermission.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiCopyPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sao chép phân quyền";
            this.Load += new System.EventHandler(this.guiCopyPermission_Load);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUser, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUser, 0);
            this.Controls.SetChildIndex(this.fld_lkeUserGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUserGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUser;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUser;
        private BOSComponent.BOSLookupEdit fld_lkeUserGroup;
    }
}