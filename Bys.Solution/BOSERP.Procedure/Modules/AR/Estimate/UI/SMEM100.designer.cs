using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Estimate.UI
{
	/// <summary>
    /// Summary description for SMEM100
	/// </summary>
    partial class SMEM100
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
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcARDeliveryPlans = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_txtARDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARDeliveryPlans;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dgcARDeliveryPlans
            // 
            this.fld_dgcARDeliveryPlans.AllowDrop = true;
            this.fld_dgcARDeliveryPlans.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSDataSource = "ARDeliveryPlans";
            this.fld_dgcARDeliveryPlans.BOSDescription = null;
            this.fld_dgcARDeliveryPlans.BOSError = null;
            this.fld_dgcARDeliveryPlans.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDeliveryPlans.Location = new System.Drawing.Point(43, 156);
            this.fld_dgcARDeliveryPlans.MainView = this.fld_dgvGridControl;
            this.fld_dgcARDeliveryPlans.Name = "fld_dgcARDeliveryPlans";
            this.fld_dgcARDeliveryPlans.Screen = null;
            this.fld_dgcARDeliveryPlans.Size = new System.Drawing.Size(528, 200);
            this.fld_dgcARDeliveryPlans.TabIndex = 9;
            this.fld_dgcARDeliveryPlans.Tag = "SR";
            this.fld_dgcARDeliveryPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_txtARDeliveryPlanNo
            // 
            this.fld_txtARDeliveryPlanNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanNo.BOSDataMember = "ARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARDeliveryPlanNo.BOSError = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanNo.Location = new System.Drawing.Point(126, 10);
            this.fld_txtARDeliveryPlanNo.Name = "fld_txtARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDeliveryPlanNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDeliveryPlanNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDeliveryPlanNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDeliveryPlanNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDeliveryPlanNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDeliveryPlanNo.Screen = null;
            this.fld_txtARDeliveryPlanNo.Size = new System.Drawing.Size(187, 20);
            this.fld_txtARDeliveryPlanNo.TabIndex = 0;
            this.fld_txtARDeliveryPlanNo.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(43, 13);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 95;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Mã chứng từ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(43, 39);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 102;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtARDeliveryPlanName
            // 
            this.fld_txtARDeliveryPlanName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanName.BOSDataMember = "ARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanName.BOSDescription = null;
            this.fld_txtARDeliveryPlanName.BOSError = null;
            this.fld_txtARDeliveryPlanName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanName.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanName.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtARDeliveryPlanName.Location = new System.Drawing.Point(126, 36);
            this.fld_txtARDeliveryPlanName.Name = "fld_txtARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDeliveryPlanName.Screen = null;
            this.fld_txtARDeliveryPlanName.Size = new System.Drawing.Size(445, 20);
            this.fld_txtARDeliveryPlanName.TabIndex = 1;
            this.fld_txtARDeliveryPlanName.Tag = "SC";
            // 
            // SMEM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(636, 386);
            this.Controls.Add(this.fld_txtARDeliveryPlanName);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtARDeliveryPlanNo);
            this.Controls.Add(this.fld_dgcARDeliveryPlans);
            this.Controls.Add(this.bosLabel3);
            this.Name = "SMEM100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dgcARDeliveryPlans, 0);
            this.Controls.SetChildIndex(this.fld_txtARDeliveryPlanNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARDeliveryPlanName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSSearchResultsGridControl fld_dgcARDeliveryPlans;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanName;
	}
}
