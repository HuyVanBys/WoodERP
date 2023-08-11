namespace BOSERP.Modules.Home
{
    partial class ShowPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPicture));
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_pteHREmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductProfiles = new BOSERP.Modules.Home.ICProductProfilesGridControl();
            this.fld_dgvAPPurchaseOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.fld_Line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHREmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(727, 287);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_Line);
            this.bosPanel2.Controls.Add(this.bosGroupControl2);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(2, 2);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(723, 283);
            this.bosPanel2.TabIndex = 1;
            // 
            // fld_Line
            // 
            this.fld_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = null;
            this.fld_Line.BOSDataMember = null;
            this.fld_Line.BOSDataSource = null;
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = null;
            this.fld_Line.BOSFieldRelation = null;
            this.fld_Line.BOSPrivilege = null;
            this.fld_Line.BOSPropertyName = null;
            this.fld_Line.Controls.Add(this.fld_pteHREmployeePicture);
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Location = new System.Drawing.Point(3, 3);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Line, true);
            this.fld_Line.Size = new System.Drawing.Size(256, 280);
            this.fld_Line.TabIndex = 14;
            this.fld_Line.TabStop = false;
            this.fld_Line.Text = "Hình ảnh";
            // 
            // fld_pteHREmployeePicture
            // 
            this.fld_pteHREmployeePicture.BOSComment = null;
            this.fld_pteHREmployeePicture.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteHREmployeePicture.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteHREmployeePicture.BOSDescription = null;
            this.fld_pteHREmployeePicture.BOSError = null;
            this.fld_pteHREmployeePicture.BOSFieldGroup = null;
            this.fld_pteHREmployeePicture.BOSFieldRelation = null;
            this.fld_pteHREmployeePicture.BOSPrivilege = null;
            this.fld_pteHREmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHREmployeePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pteHREmployeePicture.Location = new System.Drawing.Point(3, 17);
            this.fld_pteHREmployeePicture.Name = "fld_pteHREmployeePicture";
            this.fld_pteHREmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHREmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHREmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHREmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHREmployeePicture.Properties.ShowMenu = false;
            this.fld_pteHREmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHREmployeePicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteHREmployeePicture, true);
            this.fld_pteHREmployeePicture.Size = new System.Drawing.Size(250, 260);
            this.fld_pteHREmployeePicture.TabIndex = 0;
            this.fld_pteHREmployeePicture.Tag = "DC";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcICProductProfiles);
            this.bosGroupControl2.Location = new System.Drawing.Point(261, 0);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(462, 283);
            this.bosGroupControl2.TabIndex = 6;
            this.bosGroupControl2.Text = "Hồ sơ";
            // 
            // fld_dgcICProductProfiles
            // 
            this.fld_dgcICProductProfiles.AllowDrop = true;
            this.fld_dgcICProductProfiles.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.BOSDataSource = "ICProductProfiles";
            this.fld_dgcICProductProfiles.BOSDescription = null;
            this.fld_dgcICProductProfiles.BOSError = null;
            this.fld_dgcICProductProfiles.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.BOSGridType = null;
            this.fld_dgcICProductProfiles.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductProfiles.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductProfiles.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcICProductProfiles.MainView = this.fld_dgvAPPurchaseOrders;
            this.fld_dgcICProductProfiles.Name = "fld_dgcICProductProfiles";
            this.fld_dgcICProductProfiles.PrintReport = false;
            this.fld_dgcICProductProfiles.Screen = null;
            this.fld_dgcICProductProfiles.Size = new System.Drawing.Size(458, 259);
            this.fld_dgcICProductProfiles.TabIndex = 5;
            this.fld_dgcICProductProfiles.Tag = "DC";
            this.fld_dgcICProductProfiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrders});
            // 
            // fld_dgvAPPurchaseOrders
            // 
            this.fld_dgvAPPurchaseOrders.GridControl = this.fld_dgcICProductProfiles;
            this.fld_dgvAPPurchaseOrders.Name = "fld_dgvAPPurchaseOrders";
            this.fld_dgvAPPurchaseOrders.PaintStyleName = "Office2003";
            // 
            // ShowPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 287);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Hồ sơ sản phẩm";
            this.Load += new System.EventHandler(this.PrintWoodPlan_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.fld_Line.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHREmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICProductProfilesGridControl fld_dgcICProductProfiles;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrders;
        private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSPictureEdit fld_pteHREmployeePicture;
    }
}