namespace BOSERP.Modules.UserManagement
{
    partial class guiManageUser_AppStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiManageUser_AppStaff));
            this.fld_lkeStaff = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_lblStaff = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeStaff
            // 
            this.fld_lkeStaff.BOSAllowAddNew = false;
            this.fld_lkeStaff.BOSAllowDummy = true;
            this.fld_lkeStaff.BOSComment = null;
            this.fld_lkeStaff.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeStaff.BOSDataSource = "HREmployeeGroupAppStaffs";
            this.fld_lkeStaff.BOSDescription = null;
            this.fld_lkeStaff.BOSError = null;
            this.fld_lkeStaff.BOSFieldGroup = null;
            this.fld_lkeStaff.BOSFieldParent = null;
            this.fld_lkeStaff.BOSFieldRelation = null;
            this.fld_lkeStaff.BOSPrivilege = null;
            this.fld_lkeStaff.BOSPropertyName = "EditValue";
            this.fld_lkeStaff.BOSSelectType = null;
            this.fld_lkeStaff.BOSSelectTypeValue = null;
            this.fld_lkeStaff.CurrentDisplayText = string.Empty;
            this.fld_lkeStaff.Location = new System.Drawing.Point(12, 34);
            this.fld_lkeStaff.Name = "fld_lkeStaff";
            this.fld_lkeStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeStaff.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeStaff.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeStaff.Properties.NullText = string.Empty;
            this.fld_lkeStaff.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeStaff.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeStaff.Screen = null;
            this.fld_lkeStaff.Size = new System.Drawing.Size(313, 20);
            this.fld_lkeStaff.TabIndex = 0;
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
            this.fld_btnCancel.Location = new System.Drawing.Point(171, 69);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Tag = string.Empty;
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
            this.fld_btnSave.Location = new System.Drawing.Point(90, 69);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Tag = string.Empty;
            this.fld_btnSave.Text = "Đồng ý";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
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
            this.fld_lblStaff.Location = new System.Drawing.Point(12, 12);
            this.fld_lblStaff.Name = "fld_lblStaff";
            this.fld_lblStaff.Screen = null;
            this.fld_lblStaff.Size = new System.Drawing.Size(68, 13);
            this.fld_lblStaff.TabIndex = 18;
            this.fld_lblStaff.Text = "Tên nhân viên";
            // 
            // guiManageUser_AppStaff
            // 
            this.AcceptButton = this.fld_btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(337, 110);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lkeStaff);
            this.Controls.Add(this.fld_lblStaff);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "guiManageUser_AppStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Chỉnh sửa nhân viên";
            this.Load += new System.EventHandler(this.guiManageUser_Load);
            this.Controls.SetChildIndex(this.fld_btnSave, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lblStaff, 0);
            this.Controls.SetChildIndex(this.fld_lkeStaff, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStaff.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BOSComponent.BOSLookupEdit fld_lkeStaff;
        private BOSComponent.BOSButton fld_btnCancel;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSLabel fld_lblStaff;
    }
}