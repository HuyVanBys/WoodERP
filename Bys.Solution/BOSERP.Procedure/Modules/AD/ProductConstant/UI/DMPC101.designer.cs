using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC101
	/// </summary>
    partial class DMPC101
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMReuseSpecificateConfigs = new BOSERP.Modules.ProductConstant.ReuseSpecificateGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvMMReuseSpecificateConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMReuseSpecificateConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMReuseSpecificateConfigs);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 6;
            this.fld_grcGroupControl.Text = "Danh sách qui định qui cách chi tiết";
            // 
            // fld_dgcMMReuseSpecificateConfigs
            // 
            this.fld_dgcMMReuseSpecificateConfigs.AllowDrop = true;
            this.fld_dgcMMReuseSpecificateConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMReuseSpecificateConfigs.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMReuseSpecificateConfigs.BOSDataMember = null;
            this.fld_dgcMMReuseSpecificateConfigs.BOSDataSource = "MMReuseSpecificateConfigs";
            this.fld_dgcMMReuseSpecificateConfigs.BOSDescription = null;
            this.fld_dgcMMReuseSpecificateConfigs.BOSError = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMReuseSpecificateConfigs.BOSFieldGroup = "Accept";
            this.fld_dgcMMReuseSpecificateConfigs.BOSFieldRelation = null;
            this.fld_dgcMMReuseSpecificateConfigs.BOSGridType = null;
            this.fld_dgcMMReuseSpecificateConfigs.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMReuseSpecificateConfigs.BOSPropertyName = null;
            this.fld_dgcMMReuseSpecificateConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMReuseSpecificateConfigs.Location = new System.Drawing.Point(4, 28);
            this.fld_dgcMMReuseSpecificateConfigs.MainView = this.fld_dgvProductType;
            this.fld_dgcMMReuseSpecificateConfigs.Name = "fld_dgcMMReuseSpecificateConfigs";
            this.fld_dgcMMReuseSpecificateConfigs.PrintReport = false;
            this.fld_dgcMMReuseSpecificateConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMReuseSpecificateConfigs, true);
            this.fld_dgcMMReuseSpecificateConfigs.Size = new System.Drawing.Size(851, 537);
            this.fld_dgcMMReuseSpecificateConfigs.TabIndex = 6;
            this.fld_dgcMMReuseSpecificateConfigs.Tag = "DC";
            this.fld_dgcMMReuseSpecificateConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMReuseSpecificateConfigs;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // fld_dgvMMReuseSpecificateConfigs
            // 
            this.fld_dgvMMReuseSpecificateConfigs.Name = "fld_dgvMMReuseSpecificateConfigs";
            this.fld_dgvMMReuseSpecificateConfigs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMPC101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPC101";
            this.Text = "Cấu hình quy cách gỗ tận dụng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMReuseSpecificateConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMReuseSpecificateConfigs;
        private IContainer components;
        private ReuseSpecificateGridControl fld_dgcMMReuseSpecificateConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
