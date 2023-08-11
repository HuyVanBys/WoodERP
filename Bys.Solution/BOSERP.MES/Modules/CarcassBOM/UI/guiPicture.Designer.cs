namespace BOSERP.Modules.CarcassBOM
{
    partial class guiPicture
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
            this.fld_ptbProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbProductPicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_ptbProductPicture
            // 
            this.fld_ptbProductPicture.BOSComment = null;
            this.fld_ptbProductPicture.BOSDataMember = null;
            this.fld_ptbProductPicture.BOSDataSource = null;
            this.fld_ptbProductPicture.BOSDescription = null;
            this.fld_ptbProductPicture.BOSError = null;
            this.fld_ptbProductPicture.BOSFieldGroup = null;
            this.fld_ptbProductPicture.BOSFieldRelation = null;
            this.fld_ptbProductPicture.BOSPrivilege = null;
            this.fld_ptbProductPicture.BOSPropertyName = null;
            this.fld_ptbProductPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_ptbProductPicture.FileName = null;
            this.fld_ptbProductPicture.FilePath = null;
            this.fld_ptbProductPicture.Location = new System.Drawing.Point(0, 0);
            this.fld_ptbProductPicture.MenuManager = this.screenToolbar;
            this.fld_ptbProductPicture.Name = "fld_ptbProductPicture";
            this.fld_ptbProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_ptbProductPicture.Screen = null;
            this.fld_ptbProductPicture.Size = new System.Drawing.Size(769, 541);
            this.fld_ptbProductPicture.TabIndex = 6;
            // 
            // guiPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(769, 541);
            this.ControlBox = true;
            this.Controls.Add(this.fld_ptbProductPicture);
            this.Name = "guiPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem hình ảnh";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.guiPicture_Load);
            this.Controls.SetChildIndex(this.fld_ptbProductPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbProductPicture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSPictureEdit fld_ptbProductPicture;

    }
}