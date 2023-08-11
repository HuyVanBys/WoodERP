namespace BOSERP.Modules.CompanyConstant.UI
{
    partial class DMCS109
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
            this.fld_dgcGENumbering = new BOSERP.Modules.CompanyConstant.NumberingGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGENumbering)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcGENumbering
            // 
            this.fld_dgcGENumbering.BOSComment = null;
            this.fld_dgcGENumbering.BOSDataMember = null;
            this.fld_dgcGENumbering.BOSDataSource = "GENumbering";
            this.fld_dgcGENumbering.BOSDescription = null;
            this.fld_dgcGENumbering.BOSError = null;
            this.fld_dgcGENumbering.BOSFieldGroup = null;
            this.fld_dgcGENumbering.BOSFieldRelation = null;
            this.fld_dgcGENumbering.BOSGridType = null;
            this.fld_dgcGENumbering.BOSPrivilege = null;
            this.fld_dgcGENumbering.BOSPropertyName = null;
            this.fld_dgcGENumbering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGENumbering.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcGENumbering.MenuManager = this.screenToolbar;
            this.fld_dgcGENumbering.Name = "fld_dgcGENumbering";
            this.fld_dgcGENumbering.PrintReport = false;
            this.fld_dgcGENumbering.Screen = null;
            this.fld_dgcGENumbering.Size = new System.Drawing.Size(610, 288);
            this.fld_dgcGENumbering.TabIndex = 6;
            this.fld_dgcGENumbering.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_dgcGENumbering);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(610, 288);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMCS109
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 288);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS109";
            this.ScreenNumber = "DMCS106";
            this.Tag = "DM";
            this.Text = "Cấu hình số chứng từ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGENumbering)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NumberingGridControl fld_dgcGENumbering;
        private BOSComponent.BOSPanel bosPanel1;
    }
}