namespace BOSERP.Modules.SaleOrder
{
    partial class guiExportSaleOrderItemsProcess
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
            this.fld_pgbProcessExport = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pgbProcessExport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_pgbProcessExport
            // 
            this.fld_pgbProcessExport.Location = new System.Drawing.Point(12, 39);
            this.fld_pgbProcessExport.Name = "fld_pgbProcessExport";
            this.fld_pgbProcessExport.Size = new System.Drawing.Size(401, 24);
            this.fld_pgbProcessExport.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đang xuất dữ liệu";
            // 
            // guiExportProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 87);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fld_pgbProcessExport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiExportProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.guiExportSaleOrderItemsProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pgbProcessExport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl fld_pgbProcessExport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}