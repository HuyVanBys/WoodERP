namespace BOSERP.Modules.UserManagement
{
    partial class guiAddUserGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddUserGroups));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtUserGroup = new DevExpress.XtraEditors.TextEdit();
            this.fld_btnAddUserGroup = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUserGroup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhóm người dùng";
            // 
            // fld_txtUserGroup
            // 
            this.fld_txtUserGroup.Location = new System.Drawing.Point(12, 31);
            this.fld_txtUserGroup.Name = "fld_txtUserGroup";
            this.fld_txtUserGroup.Size = new System.Drawing.Size(266, 20);
            this.fld_txtUserGroup.TabIndex = 1;
            // 
            // fld_btnAddUserGroup
            // 
            this.fld_btnAddUserGroup.Location = new System.Drawing.Point(122, 66);
            this.fld_btnAddUserGroup.Name = "fld_btnAddUserGroup";
            this.fld_btnAddUserGroup.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUserGroup.TabIndex = 2;
            this.fld_btnAddUserGroup.Text = "Đồng ý";
            this.fld_btnAddUserGroup.Click += new System.EventHandler(this.fld_btnAddUserGroup_Click);
            // 
            // fld_btnCloseUserGroup
            // 
            this.fld_btnCloseUserGroup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUserGroup.Location = new System.Drawing.Point(203, 66);
            this.fld_btnCloseUserGroup.Name = "fld_btnCloseUserGroup";
            this.fld_btnCloseUserGroup.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUserGroup.TabIndex = 3;
            this.fld_btnCloseUserGroup.Text = "Hủy bỏ";
            this.fld_btnCloseUserGroup.Click += new System.EventHandler(this.fld_btnCloseUserGroup_Click);
            // 
            // guiAddUserGroups
            // 
            this.AcceptButton = this.fld_btnAddUserGroup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUserGroup;
            this.ClientSize = new System.Drawing.Size(296, 110);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnCloseUserGroup);
            this.Controls.Add(this.fld_btnAddUserGroup);
            this.Controls.Add(this.fld_txtUserGroup);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiAddUserGroups.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddUserGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhóm người dùng";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_txtUserGroup, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUserGroup, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUserGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit fld_txtUserGroup;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUserGroup;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUserGroup;
    }
}