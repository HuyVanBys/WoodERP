namespace BOSERP.Modules.HardwareProduct
{
    partial class guiEditPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiEditPrice));
            this.fld_btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_pnlEditPrice = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.AccessibleDescription = null;
            this.fld_btnCancel.AccessibleName = null;
            resources.ApplyResources(this.fld_btnCancel, "fld_btnCancel");
            this.fld_btnCancel.BackgroundImage = null;
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.AccessibleDescription = null;
            this.fld_btnOK.AccessibleName = null;
            resources.ApplyResources(this.fld_btnOK, "fld_btnOK");
            this.fld_btnOK.BackgroundImage = null;
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_pnlEditPrice
            // 
            this.fld_pnlEditPrice.AccessibleDescription = null;
            this.fld_pnlEditPrice.AccessibleName = null;
            resources.ApplyResources(this.fld_pnlEditPrice, "fld_pnlEditPrice");
            this.fld_pnlEditPrice.BackgroundImage = null;
            this.fld_pnlEditPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fld_pnlEditPrice.Font = null;
            this.fld_pnlEditPrice.Name = "fld_pnlEditPrice";
            // 
            // guiEditPrice
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.fld_pnlEditPrice);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_btnCancel);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiEditPrice";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.guiEditPrice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private System.Windows.Forms.Panel fld_pnlEditPrice;
    }
}