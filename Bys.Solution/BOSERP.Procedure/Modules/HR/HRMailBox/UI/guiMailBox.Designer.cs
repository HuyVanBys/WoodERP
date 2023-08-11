namespace BOSERP.Modules.HR.HRMailBox.UI
{
    partial class guiMailBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiMailBox));
            this.fld_statusStripMail = new System.Windows.Forms.StatusStrip();
            this.fld_pnlScreenContainer = new BOSComponent.BOSPanel(this.components);
            this.fld_navbarMail = new DevExpress.XtraNavBar.NavBarControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_navbarMail)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_statusStripMail
            // 
            this.fld_statusStripMail.Location = new System.Drawing.Point(0, 646);
            this.fld_statusStripMail.Name = "fld_statusStripMail";
            this.fld_statusStripMail.Size = new System.Drawing.Size(979, 22);
            this.fld_statusStripMail.TabIndex = 6;
            this.fld_statusStripMail.Text = "statusStrip1";
            // 
            // fld_pnlScreenContainer
            // 
            this.fld_pnlScreenContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlScreenContainer.BOSComment = null;
            this.fld_pnlScreenContainer.BOSDataMember = null;
            this.fld_pnlScreenContainer.BOSDataSource = null;
            this.fld_pnlScreenContainer.BOSDescription = null;
            this.fld_pnlScreenContainer.BOSError = null;
            this.fld_pnlScreenContainer.BOSFieldGroup = null;
            this.fld_pnlScreenContainer.BOSFieldRelation = null;
            this.fld_pnlScreenContainer.BOSPrivilege = null;
            this.fld_pnlScreenContainer.BOSPropertyName = null;
            this.fld_pnlScreenContainer.Location = new System.Drawing.Point(215, 0);
            this.fld_pnlScreenContainer.Name = "fld_pnlScreenContainer";
            this.fld_pnlScreenContainer.Screen = null;
            this.fld_pnlScreenContainer.Size = new System.Drawing.Size(764, 646);
            this.fld_pnlScreenContainer.TabIndex = 8;
            // 
            // fld_navbarMail
            // 
            this.fld_navbarMail.ActiveGroup = null;
            this.fld_navbarMail.ContentButtonHint = null;
            this.fld_navbarMail.Dock = System.Windows.Forms.DockStyle.Left;
            this.fld_navbarMail.Location = new System.Drawing.Point(0, 0);
            this.fld_navbarMail.Name = "fld_navbarMail";
            this.fld_navbarMail.OptionsNavPane.ExpandedWidth = 140;
            this.fld_navbarMail.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.fld_navbarMail.Size = new System.Drawing.Size(215, 646);
            this.fld_navbarMail.TabIndex = 7;
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_navbarMail);
            this.bosPanel1.Controls.Add(this.fld_pnlScreenContainer);
            this.bosPanel1.Controls.Add(this.fld_statusStripMail);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(979, 668);
            this.bosPanel1.TabIndex = 9;
            // 
            // guiMailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 668);
            this.Controls.Add(this.bosPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiMailBox";
            this.Text = "Hộp thư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fld_navbarMail)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip fld_statusStripMail;
        private BOSComponent.BOSPanel fld_pnlScreenContainer;
        private DevExpress.XtraNavBar.NavBarControl fld_navbarMail;
        private BOSComponent.BOSPanel bosPanel1;

    }
}