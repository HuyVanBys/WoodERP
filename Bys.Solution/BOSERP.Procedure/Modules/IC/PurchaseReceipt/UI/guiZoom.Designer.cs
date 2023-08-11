namespace BOSERP.Modules.PurchaseReceipt
{
    partial class guiZoom
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
            this.panelMain = new BOSComponent.BOSPanel(this.components);
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BOSComment = null;
            this.panelMain.BOSDataMember = null;
            this.panelMain.BOSDataSource = null;
            this.panelMain.BOSDescription = null;
            this.panelMain.BOSError = null;
            this.panelMain.BOSFieldGroup = null;
            this.panelMain.BOSFieldRelation = null;
            this.panelMain.BOSPrivilege = null;
            this.panelMain.BOSPropertyName = null;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Screen = null;
            this.panelMain.Size = new System.Drawing.Size(775, 547);
            this.panelMain.TabIndex = 7;
            // 
            // guiZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 547);
            this.ControlBox = true;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guiZoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiZoom_Load);
            this.ResizeBegin += new System.EventHandler(this.guiZoom_ResizeBegin);
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public BOSComponent.BOSPanel panelMain;


    }
}