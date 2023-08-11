namespace BOSERP.Modules.CompanyConstant.UI
{
    partial class DMCS106
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
            this.fld_dgcReports = new BOSERP.Modules.CompanyConstant.ReportGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReports)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcReports
            // 
            this.fld_dgcReports.BOSComment = null;
            this.fld_dgcReports.BOSDataMember = null;
            this.fld_dgcReports.BOSDataSource = "ADReports";
            this.fld_dgcReports.BOSDescription = null;
            this.fld_dgcReports.BOSError = null;
            this.fld_dgcReports.BOSFieldGroup = null;
            this.fld_dgcReports.BOSFieldRelation = null;
            this.fld_dgcReports.BOSGridType = null;
            this.fld_dgcReports.BOSPrivilege = null;
            this.fld_dgcReports.BOSPropertyName = null;
            this.fld_dgcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcReports.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcReports.MenuManager = this.screenToolbar;
            this.fld_dgcReports.Name = "fld_dgcReports";
            this.fld_dgcReports.Screen = null;
            this.fld_dgcReports.Size = new System.Drawing.Size(610, 288);
            this.fld_dgcReports.TabIndex = 6;
            this.fld_dgcReports.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_dgcReports);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(610, 288);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMCS106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 288);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS106";
            this.ScreenNumber = "DMCS106";
            this.Tag = "DM";
            this.Text = "Báo cáo";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReports)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportGridControl fld_dgcReports;
        private BOSComponent.BOSPanel bosPanel1;
    }
}