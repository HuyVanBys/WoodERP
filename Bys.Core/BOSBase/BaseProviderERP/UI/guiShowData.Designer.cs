namespace BOSERP
{
    partial class guiShowData<T>
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
            this.fld_pnlMainGroup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // fld_pnlMainGroup
            // 
            this.fld_pnlMainGroup.BackColor = System.Drawing.Color.Transparent;
            this.fld_pnlMainGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnlMainGroup.Location = new System.Drawing.Point(0, 0);
            this.fld_pnlMainGroup.Name = "fld_pnlMainGroup";
            this.fld_pnlMainGroup.Size = new System.Drawing.Size(799, 377);
            this.fld_pnlMainGroup.TabIndex = 2;
            // 
            // guiShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 377);
            this.ControlBox = true;
            this.Controls.Add(this.fld_pnlMainGroup);
            this.Icon = global::CommonResources.Resources.BYSLogo;
            this.Name = "guiShowData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết";
            this.Load += new System.EventHandler(this.guiShowData_Load);
            this.Controls.SetChildIndex(this.fld_pnlMainGroup, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fld_pnlMainGroup;
    }
}