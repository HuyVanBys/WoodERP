namespace BOSERP.Modules.OtherProduct
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
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.Location = new System.Drawing.Point(354, 392);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 25);
            this.fld_btnCancel.TabIndex = 2;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(273, 392);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 25);
            this.fld_btnOK.TabIndex = 1;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_pnlEditPrice
            // 
            this.fld_pnlEditPrice.AutoScroll = true;
            this.fld_pnlEditPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fld_pnlEditPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_pnlEditPrice.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlEditPrice.Name = "fld_pnlEditPrice";
            this.fld_pnlEditPrice.Size = new System.Drawing.Size(440, 386);
            this.fld_pnlEditPrice.TabIndex = 0;
            // 
            // guiEditPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 429);
            this.Controls.Add(this.fld_pnlEditPrice);
            this.Controls.Add(this.fld_btnOK);
            this.Controls.Add(this.fld_btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiEditPrice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa giá";
            this.Load += new System.EventHandler(this.guiEditPrice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton fld_btnCancel;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private System.Windows.Forms.Panel fld_pnlEditPrice;
    }
}