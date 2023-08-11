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
    partial class DMPC109
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
            this.fld_dgcICModelDetails = new BOSERP.Modules.ProductConstant.ICModelDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICModels = new BOSERP.Modules.ProductConstant.ICModelsGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICModelDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcICModelDetails);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(8, 255);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(842, 300);
            this.fld_grcGroupControl.TabIndex = 8;
            this.fld_grcGroupControl.Text = "Model";
            // 
            // fld_dgcICModelDetails
            // 
            this.fld_dgcICModelDetails.AllowDrop = true;
            this.fld_dgcICModelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICModelDetails.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModelDetails.BOSDataMember = null;
            this.fld_dgcICModelDetails.BOSDataSource = "ICModelDetails";
            this.fld_dgcICModelDetails.BOSDescription = null;
            this.fld_dgcICModelDetails.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModelDetails.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModelDetails.BOSFieldRelation = null;
            this.fld_dgcICModelDetails.BOSGridType = null;
            this.fld_dgcICModelDetails.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModelDetails.BOSPropertyName = null;
            this.fld_dgcICModelDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICModelDetails.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcICModelDetails.MainView = this.gridView1;
            this.fld_dgcICModelDetails.Name = "fld_dgcICModelDetails";
            this.fld_dgcICModelDetails.PrintReport = false;
            this.fld_dgcICModelDetails.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICModelDetails, true);
            this.fld_dgcICModelDetails.Size = new System.Drawing.Size(832, 270);
            this.fld_dgcICModelDetails.TabIndex = 6;
            this.fld_dgcICModelDetails.Tag = "DC";
            this.fld_dgcICModelDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICModelDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcICModels);
            this.bosGroupControl1.Location = new System.Drawing.Point(8, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(842, 246);
            this.bosGroupControl1.TabIndex = 9;
            this.bosGroupControl1.Text = "Nhãn hiệu";
            // 
            // fld_dgcICModels
            // 
            this.fld_dgcICModels.AllowDrop = true;
            this.fld_dgcICModels.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModels.BOSDataMember = null;
            this.fld_dgcICModels.BOSDataSource = "ICModels";
            this.fld_dgcICModels.BOSDescription = null;
            this.fld_dgcICModels.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModels.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModels.BOSFieldRelation = null;
            this.fld_dgcICModels.BOSGridType = null;
            this.fld_dgcICModels.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcICModels.BOSPropertyName = null;
            this.fld_dgcICModels.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICModels.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcICModels.MainView = this.fld_dgvProductType;
            this.fld_dgcICModels.Name = "fld_dgcICModels";
            this.fld_dgcICModels.PrintReport = false;
            this.fld_dgcICModels.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICModels, true);
            this.fld_dgcICModels.Size = new System.Drawing.Size(832, 216);
            this.fld_dgcICModels.TabIndex = 8;
            this.fld_dgcICModels.Tag = "DC";
            this.fld_dgcICModels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcICModels;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // DMPC109
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMPC109";
            this.Text = "Cấu hình nhãn hiệu - Model";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICModelDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private ICModelDetailsGridControl fld_dgcICModelDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private ICModelsGridControl fld_dgcICModels;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
	}
}
