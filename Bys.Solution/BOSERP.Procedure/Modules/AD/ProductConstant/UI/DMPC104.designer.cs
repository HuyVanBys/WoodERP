using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC104
	/// </summary>
	partial class DMPC104
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
            this.fld_dgcMMProductionNormItemConfigs = new BOSERP.Modules.ProductConstant.MMProductionNormItemConfigsGridControl();
            this.fld_dgvMMProductionNormItemConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionNormItemConfigs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMProductionNormItemConfigs);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 8;
            this.fld_grcGroupControl.Text = "Cấu hình công thức tính gỗ";
            // 
            // fld_dgcMMProductionNormItemConfigs
            // 
            this.fld_dgcMMProductionNormItemConfigs.AllowDrop = true;
            this.fld_dgcMMProductionNormItemConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionNormItemConfigs.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormItemConfigs.BOSDataMember = null;
            this.fld_dgcMMProductionNormItemConfigs.BOSDataSource = "MMProductionNormItemConfigs";
            this.fld_dgcMMProductionNormItemConfigs.BOSDescription = null;
            this.fld_dgcMMProductionNormItemConfigs.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormItemConfigs.BOSFieldGroup = "";
            this.fld_dgcMMProductionNormItemConfigs.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormItemConfigs.BOSGridType = null;
            this.fld_dgcMMProductionNormItemConfigs.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormItemConfigs.BOSPropertyName = null;
            this.fld_dgcMMProductionNormItemConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionNormItemConfigs.Location = new System.Drawing.Point(4, 28);
            this.fld_dgcMMProductionNormItemConfigs.MainView = this.fld_dgvMMProductionNormItemConfigs;
            this.fld_dgcMMProductionNormItemConfigs.Name = "fld_dgcMMProductionNormItemConfigs";
            this.fld_dgcMMProductionNormItemConfigs.PrintReport = false;
            this.fld_dgcMMProductionNormItemConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProductionNormItemConfigs, true);
            this.fld_dgcMMProductionNormItemConfigs.Size = new System.Drawing.Size(851, 537);
            this.fld_dgcMMProductionNormItemConfigs.TabIndex = 6;
            this.fld_dgcMMProductionNormItemConfigs.Tag = "DC";
            this.fld_dgcMMProductionNormItemConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionNormItemConfigs});
            // 
            // fld_dgvMMProductionNormItemConfigs
            // 
            this.fld_dgvMMProductionNormItemConfigs.GridControl = this.fld_dgcMMProductionNormItemConfigs;
            this.fld_dgvMMProductionNormItemConfigs.Name = "fld_dgvMMProductionNormItemConfigs";
            this.fld_dgvMMProductionNormItemConfigs.PaintStyleName = "Office2003";
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
            this.bosPanel1.TabIndex = 9;
            // 
            // DMPC104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPC104";
            this.Text = "Cấu hình công thức tính gỗ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormItemConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionNormItemConfigs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private MMProductionNormItemConfigsGridControl fld_dgcMMProductionNormItemConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionNormItemConfigs;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
