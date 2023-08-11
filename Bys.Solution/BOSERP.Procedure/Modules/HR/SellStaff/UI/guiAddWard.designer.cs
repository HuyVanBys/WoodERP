namespace BOSERP.Modules.SellStaff
{
    partial class guiAddWard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddWard));
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lblCode = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtCode = new DevExpress.XtraEditors.TextEdit();
            this.fld_lblName = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fld_cmbCountry = new BOSComponent.BOSComboBox(this.components);
            this.cbm_StateProvince = new DevExpress.XtraEditors.LabelControl();
            this.fld_cmbStateProvince = new BOSComponent.BOSComboBox(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_cmbDistrict = new BOSComponent.BOSComboBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStateProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbDistrict.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Location = new System.Drawing.Point(140, 142);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 23);
            this.fld_btnOK.TabIndex = 5;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(221, 142);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCancel.TabIndex = 6;
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_lblCode
            // 
            this.fld_lblCode.Location = new System.Drawing.Point(4, 93);
            this.fld_lblCode.Name = "fld_lblCode";
            this.fld_lblCode.Size = new System.Drawing.Size(76, 13);
            this.fld_lblCode.TabIndex = 1;
            this.fld_lblCode.Text = "Mã xã / phường";
            // 
            // fld_txtCode
            // 
            this.fld_txtCode.Location = new System.Drawing.Point(119, 90);
            this.fld_txtCode.Name = "fld_txtCode";
            this.fld_txtCode.Size = new System.Drawing.Size(183, 20);
            this.fld_txtCode.TabIndex = 3;
            // 
            // fld_lblName
            // 
            this.fld_lblName.Location = new System.Drawing.Point(4, 123);
            this.fld_lblName.Name = "fld_lblName";
            this.fld_lblName.Size = new System.Drawing.Size(80, 13);
            this.fld_lblName.TabIndex = 1;
            this.fld_lblName.Text = "Tên xã / phường";
            // 
            // fld_txtName
            // 
            this.fld_txtName.Location = new System.Drawing.Point(119, 116);
            this.fld_txtName.Name = "fld_txtName";
            this.fld_txtName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "Quốc gia";
            // 
            // fld_cmbCountry
            // 
            this.fld_cmbCountry.BOSComment = string.Empty;
            this.fld_cmbCountry.BOSDataMember = "ComboBox";
            this.fld_cmbCountry.BOSDataSource = string.Empty;
            this.fld_cmbCountry.BOSDescription = null;
            this.fld_cmbCountry.BOSError = string.Empty;
            this.fld_cmbCountry.BOSFieldGroup = string.Empty;
            this.fld_cmbCountry.BOSFieldRelation = string.Empty;
            this.fld_cmbCountry.BOSPrivilege = "AddAttribute";
            this.fld_cmbCountry.BOSPropertyName = "Text";
            this.fld_cmbCountry.Location = new System.Drawing.Point(119, 12);
            this.fld_cmbCountry.Name = "fld_cmbCountry";
            this.fld_cmbCountry.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_cmbCountry.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_cmbCountry.Properties.Appearance.Options.UseBackColor = true;
            this.fld_cmbCountry.Properties.Appearance.Options.UseForeColor = true;
            this.fld_cmbCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fld_cmbCountry.Screen = null;
            this.fld_cmbCountry.Size = new System.Drawing.Size(183, 20);
            this.fld_cmbCountry.TabIndex = 0;
            this.fld_cmbCountry.Tag = "DC";
            this.fld_cmbCountry.SelectedIndexChanged += new System.EventHandler(this.fld_cmbCountry_SelectedIndexChanged);
            // 
            // cbm_StateProvince
            // 
            this.cbm_StateProvince.Location = new System.Drawing.Point(4, 41);
            this.cbm_StateProvince.Name = "cbm_StateProvince";
            this.cbm_StateProvince.Size = new System.Drawing.Size(79, 13);
            this.cbm_StateProvince.TabIndex = 100;
            this.cbm_StateProvince.Text = "Tỉnh / thành phố";
            // 
            // fld_cmbStateProvince
            // 
            this.fld_cmbStateProvince.BOSComment = string.Empty;
            this.fld_cmbStateProvince.BOSDataMember = "ComboBox";
            this.fld_cmbStateProvince.BOSDataSource = string.Empty;
            this.fld_cmbStateProvince.BOSDescription = null;
            this.fld_cmbStateProvince.BOSError = string.Empty;
            this.fld_cmbStateProvince.BOSFieldGroup = string.Empty;
            this.fld_cmbStateProvince.BOSFieldRelation = string.Empty;
            this.fld_cmbStateProvince.BOSPrivilege = "AddAttribute";
            this.fld_cmbStateProvince.BOSPropertyName = "Text";
            this.fld_cmbStateProvince.Location = new System.Drawing.Point(119, 38);
            this.fld_cmbStateProvince.Name = "fld_cmbStateProvince";
            this.fld_cmbStateProvince.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_cmbStateProvince.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_cmbStateProvince.Properties.Appearance.Options.UseBackColor = true;
            this.fld_cmbStateProvince.Properties.Appearance.Options.UseForeColor = true;
            this.fld_cmbStateProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbStateProvince.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fld_cmbStateProvince.Screen = null;
            this.fld_cmbStateProvince.Size = new System.Drawing.Size(183, 20);
            this.fld_cmbStateProvince.TabIndex = 1;
            this.fld_cmbStateProvince.Tag = "DC";
            this.fld_cmbStateProvince.SelectedIndexChanged += new System.EventHandler(this.fld_cmbStateProvince_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Quận / Huyện";
            // 
            // fld_cmbDistrict
            // 
            this.fld_cmbDistrict.BOSComment = string.Empty;
            this.fld_cmbDistrict.BOSDataMember = "ComboBox";
            this.fld_cmbDistrict.BOSDataSource = string.Empty;
            this.fld_cmbDistrict.BOSDescription = null;
            this.fld_cmbDistrict.BOSError = string.Empty;
            this.fld_cmbDistrict.BOSFieldGroup = string.Empty;
            this.fld_cmbDistrict.BOSFieldRelation = string.Empty;
            this.fld_cmbDistrict.BOSPrivilege = "AddAttribute";
            this.fld_cmbDistrict.BOSPropertyName = "Text";
            this.fld_cmbDistrict.Location = new System.Drawing.Point(119, 64);
            this.fld_cmbDistrict.Name = "fld_cmbDistrict";
            this.fld_cmbDistrict.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_cmbDistrict.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_cmbDistrict.Properties.Appearance.Options.UseBackColor = true;
            this.fld_cmbDistrict.Properties.Appearance.Options.UseForeColor = true;
            this.fld_cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbDistrict.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fld_cmbDistrict.Screen = null;
            this.fld_cmbDistrict.Size = new System.Drawing.Size(183, 20);
            this.fld_cmbDistrict.TabIndex = 2;
            this.fld_cmbDistrict.Tag = "DC";
            // 
            // guiAddWard
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(308, 172);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_cmbDistrict);
            this.Controls.Add(this.cbm_StateProvince);
            this.Controls.Add(this.fld_cmbStateProvince);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_cmbCountry);
            this.Controls.Add(this.fld_txtName);
            this.Controls.Add(this.fld_txtCode);
            this.Controls.Add(this.fld_lblName);
            this.Controls.Add(this.fld_lblCode);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddWard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin xã phường";
            this.Load += new System.EventHandler(this.guiAttributeInput_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lblCode, 0);
            this.Controls.SetChildIndex(this.fld_lblName, 0);
            this.Controls.SetChildIndex(this.fld_txtCode, 0);
            this.Controls.SetChildIndex(this.fld_txtName, 0);
            this.Controls.SetChildIndex(this.fld_cmbCountry, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.fld_cmbStateProvince, 0);
            this.Controls.SetChildIndex(this.cbm_StateProvince, 0);
            this.Controls.SetChildIndex(this.fld_cmbDistrict, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbStateProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbDistrict.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.LabelControl fld_lblCode;
        public DevExpress.XtraEditors.TextEdit fld_txtCode;
        private DevExpress.XtraEditors.LabelControl fld_lblName;
        public DevExpress.XtraEditors.TextEdit fld_txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public BOSComponent.BOSComboBox fld_cmbCountry;
        private DevExpress.XtraEditors.LabelControl cbm_StateProvince;
        public BOSComponent.BOSComboBox fld_cmbStateProvince;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public BOSComponent.BOSComboBox fld_cmbDistrict;
    }
}