namespace BOSERP.Modules.UserManagement
{
    partial class guiAddUserGroups_AppStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddUserGroups_AppStaff));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtUserGroup_AppStaff = new DevExpress.XtraEditors.TextEdit();
            this.fld_btnAddUserGroup_AppStaff = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUserGroup_AppStaff = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_AppStaff.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhóm người dùng";
            // 
            // fld_txtUserGroup_AppStaff
            // 
            this.fld_txtUserGroup_AppStaff.Location = new System.Drawing.Point(136, 12);
            this.fld_txtUserGroup_AppStaff.Name = "fld_txtUserGroup_AppStaff";
            this.fld_txtUserGroup_AppStaff.Size = new System.Drawing.Size(229, 20);
            this.fld_txtUserGroup_AppStaff.TabIndex = 0;
            // 
            // fld_btnAddUserGroup_AppStaff
            // 
            this.fld_btnAddUserGroup_AppStaff.Location = new System.Drawing.Point(209, 38);
            this.fld_btnAddUserGroup_AppStaff.Name = "fld_btnAddUserGroup_AppStaff";
            this.fld_btnAddUserGroup_AppStaff.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUserGroup_AppStaff.TabIndex = 3;
            this.fld_btnAddUserGroup_AppStaff.Text = "Đồng ý";
            this.fld_btnAddUserGroup_AppStaff.Click += new System.EventHandler(this.fld_btnAddUserGroup_AppStaff_Click);
            // 
            // fld_btnCloseUserGroup_AppStaff
            // 
            this.fld_btnCloseUserGroup_AppStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUserGroup_AppStaff.Location = new System.Drawing.Point(290, 38);
            this.fld_btnCloseUserGroup_AppStaff.Name = "fld_btnCloseUserGroup_AppStaff";
            this.fld_btnCloseUserGroup_AppStaff.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUserGroup_AppStaff.TabIndex = 4;
            this.fld_btnCloseUserGroup_AppStaff.Text = "Hủy bỏ";
            this.fld_btnCloseUserGroup_AppStaff.Click += new System.EventHandler(this.fld_btnCloseUserGroup_AppStaff_Click);
            // 
            // guiAddUserGroups_AppStaff
            // 
            this.AcceptButton = this.fld_btnAddUserGroup_AppStaff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUserGroup_AppStaff;
            this.ClientSize = new System.Drawing.Size(397, 71);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCloseUserGroup_AppStaff);
            this.Controls.Add(this.fld_btnAddUserGroup_AppStaff);
            this.Controls.Add(this.fld_txtUserGroup_AppStaff);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddUserGroups_AppStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhóm người dùng";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_txtUserGroup_AppStaff, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUserGroup_AppStaff, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUserGroup_AppStaff, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_AppStaff.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit fld_txtUserGroup_AppStaff;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUserGroup_AppStaff;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUserGroup_AppStaff;
    }
}