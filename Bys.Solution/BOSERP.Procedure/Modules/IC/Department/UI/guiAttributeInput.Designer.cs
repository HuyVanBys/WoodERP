namespace BOSERP.Modules.Department
{
    partial class guiAttributeInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAttributeInput));
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtAttributeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtAttributeDesc = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Location = new System.Drawing.Point(107, 101);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 23);
            this.fld_btnOK.TabIndex = 3;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(188, 101);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCancel.TabIndex = 4;
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên thuộc tính";
            // 
            // fld_txtAttributeName
            // 
            this.fld_txtAttributeName.Location = new System.Drawing.Point(101, 12);
            this.fld_txtAttributeName.Name = "fld_txtAttributeName";
            this.fld_txtAttributeName.Size = new System.Drawing.Size(264, 20);
            this.fld_txtAttributeName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mô tả";
            // 
            // fld_txtAttributeDesc
            // 
            this.fld_txtAttributeDesc.Location = new System.Drawing.Point(101, 38);
            this.fld_txtAttributeDesc.Name = "fld_txtAttributeDesc";
            this.fld_txtAttributeDesc.Size = new System.Drawing.Size(264, 43);
            this.fld_txtAttributeDesc.TabIndex = 2;
            // 
            // guiAttributeInput
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(377, 136);
            this.Controls.Add(this.fld_txtAttributeDesc);
            this.Controls.Add(this.fld_txtAttributeName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAttributeInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin thuộc tính";
            this.Load += new System.EventHandler(this.guiAttributeInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit fld_txtAttributeName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.MemoEdit fld_txtAttributeDesc;
    }
}