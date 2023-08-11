using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC107
	/// </summary>
	partial class DMPC107
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
            this.fld_dgcMMOverallInsideDimensionConfigs = new BOSERP.Modules.ProductConstant.OverallInsideDimensionConfigGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOverallInsideDimensionConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMOverallInsideDimensionConfigs);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 8;
            this.fld_grcGroupControl.Text = "Cấu hình công thức tính phủ bì";
            // 
            // fld_dgcMMOverallInsideDimensionConfigs
            // 
            this.fld_dgcMMOverallInsideDimensionConfigs.AllowDrop = true;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSDataMember = null;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSDataSource = "MMOverallInsideDimensionConfigs";
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSDescription = null;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSFieldGroup = "";
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSFieldRelation = null;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSGridType = null;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMOverallInsideDimensionConfigs.BOSPropertyName = null;
            this.fld_dgcMMOverallInsideDimensionConfigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMOverallInsideDimensionConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMOverallInsideDimensionConfigs.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMMOverallInsideDimensionConfigs.MainView = this.fld_dgvProductType;
            this.fld_dgcMMOverallInsideDimensionConfigs.Name = "fld_dgcMMOverallInsideDimensionConfigs";
            this.fld_dgcMMOverallInsideDimensionConfigs.PrintReport = false;
            this.fld_dgcMMOverallInsideDimensionConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMOverallInsideDimensionConfigs, true);
            this.fld_dgcMMOverallInsideDimensionConfigs.Size = new System.Drawing.Size(858, 543);
            this.fld_dgcMMOverallInsideDimensionConfigs.TabIndex = 6;
            this.fld_dgcMMOverallInsideDimensionConfigs.Tag = "DC";
            this.fld_dgcMMOverallInsideDimensionConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMOverallInsideDimensionConfigs;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
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
            // DMPC107
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPC107";
            this.Text = "Cấu hình công thức tính phủ bì";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOverallInsideDimensionConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private OverallInsideDimensionConfigGridControl fld_dgcMMOverallInsideDimensionConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
