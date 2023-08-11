namespace BOSERP.Modules.UserManagement
{
    partial class guiAddUserGroups_OrderWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddUserGroups_OrderWeb));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtUserGroup_WebOrder = new DevExpress.XtraEditors.TextEdit();
            this.fld_btnAddUserGroup_WebOrder = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCloseUserGroup_WebOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fld_lkeADGroupWebOrderRole = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_WebOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeADGroupWebOrderRole.Properties)).BeginInit();
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
            // fld_txtUserGroup_WebOrder
            // 
            this.fld_txtUserGroup_WebOrder.Location = new System.Drawing.Point(136, 12);
            this.fld_txtUserGroup_WebOrder.Name = "fld_txtUserGroup_WebOrder";
            this.fld_txtUserGroup_WebOrder.Size = new System.Drawing.Size(229, 20);
            this.fld_txtUserGroup_WebOrder.TabIndex = 0;
            // 
            // fld_btnAddUserGroup_WebOrder
            // 
            this.fld_btnAddUserGroup_WebOrder.Location = new System.Drawing.Point(135, 64);
            this.fld_btnAddUserGroup_WebOrder.Name = "fld_btnAddUserGroup_WebOrder";
            this.fld_btnAddUserGroup_WebOrder.Size = new System.Drawing.Size(75, 23);
            this.fld_btnAddUserGroup_WebOrder.TabIndex = 3;
            this.fld_btnAddUserGroup_WebOrder.Text = "Đồng ý";
            this.fld_btnAddUserGroup_WebOrder.Click += new System.EventHandler(this.fld_btnAddUserGroup_AppStaff_Click);
            // 
            // fld_btnCloseUserGroup_WebOrder
            // 
            this.fld_btnCloseUserGroup_WebOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCloseUserGroup_WebOrder.Location = new System.Drawing.Point(216, 64);
            this.fld_btnCloseUserGroup_WebOrder.Name = "fld_btnCloseUserGroup_WebOrder";
            this.fld_btnCloseUserGroup_WebOrder.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCloseUserGroup_WebOrder.TabIndex = 4;
            this.fld_btnCloseUserGroup_WebOrder.Text = "Hủy bỏ";
            this.fld_btnCloseUserGroup_WebOrder.Click += new System.EventHandler(this.fld_btnCloseUserGroup_AppStaff_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Quyền";
            // 
            // fld_lkeADGroupWebOrderRole
            // 
            this.fld_lkeADGroupWebOrderRole.BOSAllowAddNew = false;
            this.fld_lkeADGroupWebOrderRole.BOSAllowDummy = true;
            this.fld_lkeADGroupWebOrderRole.BOSComment = null;
            this.fld_lkeADGroupWebOrderRole.BOSDataMember = "ADGroupOrderWebRole";
            this.fld_lkeADGroupWebOrderRole.BOSDataSource = "ADGroupOrderWebs";
            this.fld_lkeADGroupWebOrderRole.BOSDescription = null;
            this.fld_lkeADGroupWebOrderRole.BOSError = null;
            this.fld_lkeADGroupWebOrderRole.BOSFieldGroup = null;
            this.fld_lkeADGroupWebOrderRole.BOSFieldParent = null;
            this.fld_lkeADGroupWebOrderRole.BOSFieldRelation = null;
            this.fld_lkeADGroupWebOrderRole.BOSPrivilege = null;
            this.fld_lkeADGroupWebOrderRole.BOSPropertyName = "EditValue";
            this.fld_lkeADGroupWebOrderRole.BOSSelectType = null;
            this.fld_lkeADGroupWebOrderRole.BOSSelectTypeValue = null;
            this.fld_lkeADGroupWebOrderRole.CurrentDisplayText = string.Empty;
            this.fld_lkeADGroupWebOrderRole.Location = new System.Drawing.Point(135, 38);
            this.fld_lkeADGroupWebOrderRole.Name = "fld_lkeADGroupWebOrderRole";
            this.fld_lkeADGroupWebOrderRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeADGroupWebOrderRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại")});
            this.fld_lkeADGroupWebOrderRole.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeADGroupWebOrderRole.Properties.NullText = string.Empty;
            this.fld_lkeADGroupWebOrderRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeADGroupWebOrderRole.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeADGroupWebOrderRole.Screen = null;
            this.fld_lkeADGroupWebOrderRole.Size = new System.Drawing.Size(229, 20);
            this.fld_lkeADGroupWebOrderRole.TabIndex = 24;
            this.fld_lkeADGroupWebOrderRole.Tag = "DC";
            // 
            // guiAddUserGroups_OrderWeb
            // 
            this.AcceptButton = this.fld_btnAddUserGroup_WebOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCloseUserGroup_WebOrder;
            this.ClientSize = new System.Drawing.Size(397, 97);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeADGroupWebOrderRole);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.fld_btnCloseUserGroup_WebOrder);
            this.Controls.Add(this.fld_btnAddUserGroup_WebOrder);
            this.Controls.Add(this.fld_txtUserGroup_WebOrder);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddUserGroups_OrderWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhóm người dùng";
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_txtUserGroup_WebOrder, 0);
            this.Controls.SetChildIndex(this.fld_btnAddUserGroup_WebOrder, 0);
            this.Controls.SetChildIndex(this.fld_btnCloseUserGroup_WebOrder, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.fld_lkeADGroupWebOrderRole, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUserGroup_WebOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeADGroupWebOrderRole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit fld_txtUserGroup_WebOrder;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddUserGroup_WebOrder;
        private DevExpress.XtraEditors.SimpleButton fld_btnCloseUserGroup_WebOrder;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public BOSComponent.BOSLookupEdit fld_lkeADGroupWebOrderRole;
    }
}