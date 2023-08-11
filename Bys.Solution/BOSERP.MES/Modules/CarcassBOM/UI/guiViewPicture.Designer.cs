namespace BOSERP.Modules.CarcassBOM
{
    partial class guiViewPicture
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
            this.pbx_ViewPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ViewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_ViewPicture
            // 
            this.pbx_ViewPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_ViewPicture.Location = new System.Drawing.Point(0, 0);
            this.pbx_ViewPicture.Name = "pbx_ViewPicture";
            this.pbx_ViewPicture.Size = new System.Drawing.Size(775, 548);
            this.pbx_ViewPicture.TabIndex = 6;
            this.pbx_ViewPicture.TabStop = false;
            // 
            // guiViewPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(775, 548);
            this.ControlBox = true;
            this.Controls.Add(this.pbx_ViewPicture);
            this.Name = "guiViewPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hình ảnh";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.guiViewPicture_Load);
            this.Controls.SetChildIndex(this.pbx_ViewPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ViewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_ViewPicture;
    }
}