namespace BOSERP.Modules.Home.UI
{
    partial class DMHM105
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
            this.fld_dgcProposals = new BOSComponent.BOSGridControl(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProposals)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcProposals
            // 
            this.fld_dgcProposals.BOSComment = null;
            this.fld_dgcProposals.BOSDataMember = null;
            this.fld_dgcProposals.BOSDataSource = "APProposals";
            this.fld_dgcProposals.BOSDescription = null;
            this.fld_dgcProposals.BOSError = null;
            this.fld_dgcProposals.BOSFieldGroup = null;
            this.fld_dgcProposals.BOSFieldRelation = null;
            this.fld_dgcProposals.BOSGridType = null;
            this.fld_dgcProposals.BOSPrivilege = null;
            this.fld_dgcProposals.BOSPropertyName = null;
            this.fld_dgcProposals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcProposals.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcProposals.Name = "fld_dgcProposals";
            this.fld_dgcProposals.Screen = null;
            this.fld_dgcProposals.Size = new System.Drawing.Size(693, 418);
            this.fld_dgcProposals.TabIndex = 1;
            this.fld_dgcProposals.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_dgcProposals);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(693, 418);
            this.bosPanel1.TabIndex = 1;
            // 
            // DMHM105
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 418);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHM105";
            this.Text = "Nhắc nhở đề nghị";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProposals)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSGridControl fld_dgcProposals;
        private BOSComponent.BOSPanel bosPanel1;
    }
}