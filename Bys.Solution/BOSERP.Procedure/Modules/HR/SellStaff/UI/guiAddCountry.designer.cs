namespace BOSERP.Modules.SellStaff
{
    partial class guiAddCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiAddCountry));
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_lblCode = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtAttributeCode = new DevExpress.XtraEditors.TextEdit();
            this.fld_lblName = new DevExpress.XtraEditors.LabelControl();
            this.fld_txtAttributeName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Location = new System.Drawing.Point(127, 64);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 23);
            this.fld_btnOK.TabIndex = 2;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(208, 64);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy bỏ";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_lblCode
            // 
            this.fld_lblCode.Location = new System.Drawing.Point(13, 15);
            this.fld_lblCode.Name = "fld_lblCode";
            this.fld_lblCode.Size = new System.Drawing.Size(57, 13);
            this.fld_lblCode.TabIndex = 1;
            this.fld_lblCode.Text = "Mã quốc gia";
            // 
            // fld_txtAttributeCode
            // 
            this.fld_txtAttributeCode.Location = new System.Drawing.Point(101, 12);
            this.fld_txtAttributeCode.Name = "fld_txtAttributeCode";
            this.fld_txtAttributeCode.Size = new System.Drawing.Size(183, 20);
            this.fld_txtAttributeCode.TabIndex = 0;
            // 
            // fld_lblName
            // 
            this.fld_lblName.Location = new System.Drawing.Point(13, 43);
            this.fld_lblName.Name = "fld_lblName";
            this.fld_lblName.Size = new System.Drawing.Size(61, 13);
            this.fld_lblName.TabIndex = 1;
            this.fld_lblName.Text = "Tên quốc gia";
            // 
            // fld_txtAttributeName
            // 
            this.fld_txtAttributeName.Location = new System.Drawing.Point(101, 38);
            this.fld_txtAttributeName.Name = "fld_txtAttributeName";
            this.fld_txtAttributeName.Size = new System.Drawing.Size(183, 20);
            this.fld_txtAttributeName.TabIndex = 1;
            // 
            // guiAddCountry
            // 
            this.AcceptButton = this.fld_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(289, 95);
            this.Controls.Add(this.fld_txtAttributeName);
            this.Controls.Add(this.fld_txtAttributeCode);
            this.Controls.Add(this.fld_lblName);
            this.Controls.Add(this.fld_lblCode);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiAddCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin quốc gia";
            this.Load += new System.EventHandler(this.guiAttributeInput_Load);
            this.Controls.SetChildIndex(this.fld_btnOK, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_lblCode, 0);
            this.Controls.SetChildIndex(this.fld_lblName, 0);
            this.Controls.SetChildIndex(this.fld_txtAttributeCode, 0);
            this.Controls.SetChildIndex(this.fld_txtAttributeName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAttributeName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.LabelControl fld_lblCode;
        public DevExpress.XtraEditors.TextEdit fld_txtAttributeCode;
        private DevExpress.XtraEditors.LabelControl fld_lblName;
        public DevExpress.XtraEditors.TextEdit fld_txtAttributeName;
    }
}