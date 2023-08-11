using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC108
	/// </summary>
	partial class DMPC108
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
            this.fld_dgcMMExchangeMeasureUnitConfigs = new BOSERP.Modules.ProductConstant.MMExchangeMeasureUnitConfigsConfigGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMExchangeMeasureUnitConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.AutoSize = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMExchangeMeasureUnitConfigs);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 8;
            this.fld_grcGroupControl.Text = "Cấu hình quy đổi đơn vị tính PLDG";
            // 
            // fld_dgcMMExchangeMeasureUnitConfigs
            // 
            this.fld_dgcMMExchangeMeasureUnitConfigs.AllowDrop = true;
            this.fld_dgcMMExchangeMeasureUnitConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSDataMember = null;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSDataSource = "MMExchangeMeasureUnitConfigs";
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSDescription = null;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSFieldRelation = null;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSGridType = null;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcMMExchangeMeasureUnitConfigs.BOSPropertyName = null;
            this.fld_dgcMMExchangeMeasureUnitConfigs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMExchangeMeasureUnitConfigs.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcMMExchangeMeasureUnitConfigs.MainView = this.fld_dgvProductType;
            this.fld_dgcMMExchangeMeasureUnitConfigs.Name = "fld_dgcMMExchangeMeasureUnitConfigs";
            this.fld_dgcMMExchangeMeasureUnitConfigs.PrintReport = false;
            this.fld_dgcMMExchangeMeasureUnitConfigs.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMExchangeMeasureUnitConfigs, true);
            this.fld_dgcMMExchangeMeasureUnitConfigs.Size = new System.Drawing.Size(849, 535);
            this.fld_dgcMMExchangeMeasureUnitConfigs.TabIndex = 8;
            this.fld_dgcMMExchangeMeasureUnitConfigs.Tag = "DC";
            this.fld_dgcMMExchangeMeasureUnitConfigs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMExchangeMeasureUnitConfigs;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // DMPC108
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMPC108";
            this.Text = "Cấu hình quy đổi đơn vị tính PLDG";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMExchangeMeasureUnitConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private MMExchangeMeasureUnitConfigsConfigGridControl fld_dgcMMExchangeMeasureUnitConfigs;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private IContainer components;

    }
}
