using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostCenter.UI
{
	/// <summary>
	/// Summary description for DMCCT100
	/// </summary>
	partial class DMCCT100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostCenterNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostCenterName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostCenterOtherName = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkACCostCenterIsActive = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterOtherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkACCostCenterIsActive.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_chkACCostCenterIsActive);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtACCostCenterOtherName);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtACCostCenterName);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtACCostCenterNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(488, 190);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(18, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(97, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Text = "Mã trung tâm chi phí";
            // 
            // fld_txtACCostCenterNo
            // 
            this.fld_txtACCostCenterNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterNo.BOSDataMember = "ACCostCenterNo";
            this.fld_txtACCostCenterNo.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterNo.BOSDescription = null;
            this.fld_txtACCostCenterNo.BOSError = null;
            this.fld_txtACCostCenterNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterNo.BOSPropertyName = "Text";
            this.fld_txtACCostCenterNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterNo.Location = new System.Drawing.Point(134, 12);
            this.fld_txtACCostCenterNo.Name = "fld_txtACCostCenterNo";
            this.fld_txtACCostCenterNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterNo.Screen = null;
            this.fld_txtACCostCenterNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostCenterNo.TabIndex = 0;
            this.fld_txtACCostCenterNo.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(18, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(101, 13);
            this.bosLabel2.TabIndex = 11;
            this.bosLabel2.Text = "Tên trung tâm chi phí";
            // 
            // fld_txtACCostCenterName
            // 
            this.fld_txtACCostCenterName.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterName.BOSDataMember = "ACCostCenterName";
            this.fld_txtACCostCenterName.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterName.BOSDescription = null;
            this.fld_txtACCostCenterName.BOSError = null;
            this.fld_txtACCostCenterName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterName.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterName.BOSPropertyName = "Text";
            this.fld_txtACCostCenterName.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterName.Location = new System.Drawing.Point(134, 38);
            this.fld_txtACCostCenterName.Name = "fld_txtACCostCenterName";
            this.fld_txtACCostCenterName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterName.Screen = null;
            this.fld_txtACCostCenterName.Size = new System.Drawing.Size(266, 20);
            this.fld_txtACCostCenterName.TabIndex = 1;
            this.fld_txtACCostCenterName.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(18, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(110, 13);
            this.bosLabel3.TabIndex = 13;
            this.bosLabel3.Text = "Tên trung tâm chi phí 2";
            // 
            // fld_txtACCostCenterOtherName
            // 
            this.fld_txtACCostCenterOtherName.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterOtherName.BOSDataMember = "ACCostCenterOtherName";
            this.fld_txtACCostCenterOtherName.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterOtherName.BOSDescription = null;
            this.fld_txtACCostCenterOtherName.BOSError = null;
            this.fld_txtACCostCenterOtherName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterOtherName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterOtherName.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterOtherName.BOSPropertyName = "Text";
            this.fld_txtACCostCenterOtherName.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtACCostCenterOtherName.Location = new System.Drawing.Point(134, 64);
            this.fld_txtACCostCenterOtherName.Name = "fld_txtACCostCenterOtherName";
            this.fld_txtACCostCenterOtherName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterOtherName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterOtherName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterOtherName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterOtherName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterOtherName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterOtherName.Screen = null;
            this.fld_txtACCostCenterOtherName.Size = new System.Drawing.Size(266, 20);
            this.fld_txtACCostCenterOtherName.TabIndex = 2;
            this.fld_txtACCostCenterOtherName.Tag = "DC";
            // 
            // fld_chkACCostCenterIsActive
            // 
            this.fld_chkACCostCenterIsActive.BOSComment = null;
            this.fld_chkACCostCenterIsActive.BOSDataMember = "ACCostCenterIsActive";
            this.fld_chkACCostCenterIsActive.BOSDataSource = "ACCostCenters";
            this.fld_chkACCostCenterIsActive.BOSDescription = null;
            this.fld_chkACCostCenterIsActive.BOSError = null;
            this.fld_chkACCostCenterIsActive.BOSFieldGroup = null;
            this.fld_chkACCostCenterIsActive.BOSFieldRelation = null;
            this.fld_chkACCostCenterIsActive.BOSPrivilege = null;
            this.fld_chkACCostCenterIsActive.BOSPropertyName = "EditValue";
            this.fld_chkACCostCenterIsActive.Location = new System.Drawing.Point(132, 90);
            this.fld_chkACCostCenterIsActive.MenuManager = this.screenToolbar;
            this.fld_chkACCostCenterIsActive.Name = "fld_chkACCostCenterIsActive";
            this.fld_chkACCostCenterIsActive.Properties.Caption = "Hoạt động";
            this.fld_chkACCostCenterIsActive.Screen = null;
            this.fld_chkACCostCenterIsActive.Size = new System.Drawing.Size(75, 19);
            this.fld_chkACCostCenterIsActive.TabIndex = 3;
            this.fld_chkACCostCenterIsActive.Tag = "DC";
            // 
            // DMCCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(488, 190);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCCT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterOtherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkACCostCenterIsActive.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACCostCenterNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACCostCenterOtherName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtACCostCenterName;
        private BOSComponent.BOSCheckEdit fld_chkACCostCenterIsActive;
	}
}
