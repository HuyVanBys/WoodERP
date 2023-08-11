using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
    /// Summary description for DMPC111
	/// </summary>
    partial class DMPC111
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
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMLabourProductivityTargetConfigs = new BOSERP.Modules.ProductConstant.MMLabourProductivityTargetConfigsGridControl();
            this.fld_dgvMMLabourProductivityTargetConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLabourProductivityTargetConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMLabourProductivityTargetConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMLabourProductivityTargetConfigs);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(862, 567);
            this.bosGroupControl1.TabIndex = 9;
            this.bosGroupControl1.Text = "Danh sách";
            // 
            // fld_dgcMMLabourProductivityTargetConfigs
            // 
            this.fld_dgcMMLabourProductivityTargetConfigs.AllowDrop = true;
            this.fld_dgcMMLabourProductivityTargetConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSDataMember = null;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSDataSource = "MMLabourProductivityTargetConfigs";
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSDescription = null;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSFieldRelation = null;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSGridType = null;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMLabourProductivityTargetConfigs.BOSPropertyName = null;
            this.fld_dgcMMLabourProductivityTargetConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMLabourProductivityTargetConfigs.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMMLabourProductivityTargetConfigs.MainView = this.fld_dgvMMLabourProductivityTargetConfigs;
            this.fld_dgcMMLabourProductivityTargetConfigs.Name = "fld_dgcMMLabourProductivityTargetConfigs";
            this.fld_dgcMMLabourProductivityTargetConfigs.PrintReport = false;
            this.fld_dgcMMLabourProductivityTargetConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMLabourProductivityTargetConfigs, true);
            this.fld_dgcMMLabourProductivityTargetConfigs.Size = new System.Drawing.Size(858, 543);
            this.fld_dgcMMLabourProductivityTargetConfigs.TabIndex = 8;
            this.fld_dgcMMLabourProductivityTargetConfigs.Tag = "DC";
            this.fld_dgcMMLabourProductivityTargetConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMLabourProductivityTargetConfigs});
            // 
            // fld_dgvMMLabourProductivityTargetConfigs
            // 
            this.fld_dgvMMLabourProductivityTargetConfigs.GridControl = this.fld_dgcMMLabourProductivityTargetConfigs;
            this.fld_dgvMMLabourProductivityTargetConfigs.Name = "fld_dgvMMLabourProductivityTargetConfigs";
            this.fld_dgvMMLabourProductivityTargetConfigs.PaintStyleName = "Office2003";
            // 
            // DMPC111
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosGroupControl1);
            this.Name = "DMPC111";
            this.Text = "Sản lượng mục tiêu trung bình (ngày/tháng)";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLabourProductivityTargetConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMLabourProductivityTargetConfigs)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private MMLabourProductivityTargetConfigsGridControl fld_dgcMMLabourProductivityTargetConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMLabourProductivityTargetConfigs;
	}
}
