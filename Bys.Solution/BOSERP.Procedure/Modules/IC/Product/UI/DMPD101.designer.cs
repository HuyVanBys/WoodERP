using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Product.UI
{
	/// <summary>
	/// Summary description for DMSF102
	/// </summary>
    partial class DMPD101
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;


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
            this.fld_dgcICProductProfiles = new BOSERP.Modules.Product.ICProductProfileGridControl();
            this.fld_dgvARSaleForecastTemplates = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcICProductProfiles);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 567);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Text = "Hồ sơ sản phẩm";
            // 
            // fld_dgcICProductProfiles
            // 
            this.fld_dgcICProductProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductProfiles.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.BOSDataSource = "ICProductProfiles";
            this.fld_dgcICProductProfiles.BOSDescription = null;
            this.fld_dgcICProductProfiles.BOSError = null;
            this.fld_dgcICProductProfiles.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.BOSGridType = null;
            this.fld_dgcICProductProfiles.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICProductProfiles.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductProfiles.Location = new System.Drawing.Point(12, 25);
            this.fld_dgcICProductProfiles.MainView = this.fld_dgvARSaleForecastTemplates;
            this.fld_dgcICProductProfiles.Name = "fld_dgcICProductProfiles";
            this.fld_dgcICProductProfiles.PrintReport = false;
            this.fld_dgcICProductProfiles.Screen = null;
            this.fld_dgcICProductProfiles.Size = new System.Drawing.Size(838, 530);
            this.fld_dgcICProductProfiles.TabIndex = 21;
            this.fld_dgcICProductProfiles.Tag = "DC";
            this.fld_dgcICProductProfiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleForecastTemplates});
            // 
            // fld_dgvARSaleForecastTemplates
            // 
            this.fld_dgvARSaleForecastTemplates.GridControl = this.fld_dgcICProductProfiles;
            this.fld_dgvARSaleForecastTemplates.Name = "fld_dgvARSaleForecastTemplates";
            // 
            // DMPD101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMPD101";
            this.Text = "Hồ sơ sản phẩm";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleForecastTemplates)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private ICProductProfileGridControl fld_dgcICProductProfiles;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleForecastTemplates;
	}
}
