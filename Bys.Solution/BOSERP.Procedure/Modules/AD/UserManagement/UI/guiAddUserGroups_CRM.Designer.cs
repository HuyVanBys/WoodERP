namespace BOSERP.Modules.UserManagement
{
    partial class guiAddUserGroups_CRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddUserGroups_CRM));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtUserGroup_CRM = new DevExpress.XtraEditors.TextEdit();
            this.fld_btnAddUserGroup_CRM = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUserGroup_CRM = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_CRM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
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
            // fld_txtUserGroup_CRM
            // 
            this.fld_txtUserGroup_CRM.Location = new System.Drawing.Point(136, 12);
            this.fld_txtUserGroup_CRM.Name = "fld_txtUserGroup_CRM";
            this.fld_txtUserGroup_CRM.Size = new System.Drawing.Size(229, 20);
            this.fld_txtUserGroup_CRM.TabIndex = 1;
            // 
            // fld_btnAddUserGroup_CRM
            // 
            this.fld_btnAddUserGroup_CRM.Location = new System.Drawing.Point(134, 70);
            this.fld_btnAddUserGroup_CRM.Name = "fld_btnAddUserGroup_CRM";
            this.fld_btnAddUserGroup_CRM.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUserGroup_CRM.TabIndex = 2;
            this.fld_btnAddUserGroup_CRM.Text = "Đồng ý";
            this.fld_btnAddUserGroup_CRM.Click += new System.EventHandler(this.fld_btnAddUserGroup_CRM_Click);
            // 
            // fld_btnCloseUserGroup_CRM
            // 
            this.fld_btnCloseUserGroup_CRM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUserGroup_CRM.Location = new System.Drawing.Point(215, 70);
            this.fld_btnCloseUserGroup_CRM.Name = "fld_btnCloseUserGroup_CRM";
            this.fld_btnCloseUserGroup_CRM.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUserGroup_CRM.TabIndex = 3;
            this.fld_btnCloseUserGroup_CRM.Text = "Hủy bỏ";
            this.fld_btnCloseUserGroup_CRM.Click += new System.EventHandler(this.fld_btnCloseUserGroup_CRM_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRGroups";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = string.Empty;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(136, 38);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhanh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = string.Empty;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(229, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 21;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // guiAddUserGroups_CRM
            // 
            this.AcceptButton = this.fld_btnAddUserGroup_CRM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUserGroup_CRM;
            this.ClientSize = new System.Drawing.Size(397, 108);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_btnCloseUserGroup_CRM);
            this.Controls.Add(this.fld_btnAddUserGroup_CRM);
            this.Controls.Add(this.fld_txtUserGroup_CRM);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddUserGroups_CRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhóm người dùng";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_txtUserGroup_CRM, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUserGroup_CRM, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUserGroup_CRM, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_CRM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit fld_txtUserGroup_CRM;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUserGroup_CRM;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUserGroup_CRM;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
    }
}