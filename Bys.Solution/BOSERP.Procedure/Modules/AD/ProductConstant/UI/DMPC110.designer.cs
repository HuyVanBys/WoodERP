using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
    /// Summary description for DMPC110
	/// </summary>
    partial class DMPC110
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
            this.fld_dgcMMQuantityAllocationPercentConfigs = new BOSERP.Modules.ProductConstant.MMQuantityAllocationPercentConfigsGridControl();
            this.fld_dgvMMQuantityAllocationPercentConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMQuantityAllocationPercentConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMQuantityAllocationPercentConfigs)).BeginInit();
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMQuantityAllocationPercentConfigs);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(862, 567);
            this.bosGroupControl1.TabIndex = 9;
            this.bosGroupControl1.Text = "Danh sách";
            // 
            // fld_dgcMMQuantityAllocationPercentConfigs
            // 
            this.fld_dgcMMQuantityAllocationPercentConfigs.AllowDrop = true;
            this.fld_dgcMMQuantityAllocationPercentConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSDataMember = null;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSDataSource = "MMQuantityAllocationPercentConfigs";
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSDescription = null;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSFieldRelation = null;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSGridType = null;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMQuantityAllocationPercentConfigs.BOSPropertyName = null;
            this.fld_dgcMMQuantityAllocationPercentConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMQuantityAllocationPercentConfigs.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMMQuantityAllocationPercentConfigs.MainView = this.fld_dgvMMQuantityAllocationPercentConfigs;
            this.fld_dgcMMQuantityAllocationPercentConfigs.Name = "fld_dgcMMQuantityAllocationPercentConfigs";
            this.fld_dgcMMQuantityAllocationPercentConfigs.PrintReport = false;
            this.fld_dgcMMQuantityAllocationPercentConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMQuantityAllocationPercentConfigs, true);
            this.fld_dgcMMQuantityAllocationPercentConfigs.Size = new System.Drawing.Size(858, 543);
            this.fld_dgcMMQuantityAllocationPercentConfigs.TabIndex = 8;
            this.fld_dgcMMQuantityAllocationPercentConfigs.Tag = "DC";
            this.fld_dgcMMQuantityAllocationPercentConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMQuantityAllocationPercentConfigs});
            // 
            // fld_dgvMMQuantityAllocationPercentConfigs
            // 
            this.fld_dgvMMQuantityAllocationPercentConfigs.GridControl = this.fld_dgcMMQuantityAllocationPercentConfigs;
            this.fld_dgvMMQuantityAllocationPercentConfigs.Name = "fld_dgvMMQuantityAllocationPercentConfigs";
            this.fld_dgvMMQuantityAllocationPercentConfigs.PaintStyleName = "Office2003";
            // 
            // DMPC110
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosGroupControl1);
            this.Name = "DMPC110";
            this.Text = "Tỷ lệ phân bổ giá trị sản lượng từng CĐ";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMQuantityAllocationPercentConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMQuantityAllocationPercentConfigs)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private MMQuantityAllocationPercentConfigsGridControl fld_dgcMMQuantityAllocationPercentConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMQuantityAllocationPercentConfigs;
	}
}
