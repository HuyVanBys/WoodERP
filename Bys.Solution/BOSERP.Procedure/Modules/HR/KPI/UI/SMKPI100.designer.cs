using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPI.UI
{
	/// <summary>
	/// Summary description for SMUCC100
	/// </summary>
	partial class SMKPI100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtHRKPINo;
        private BOSComponent.BOSTextBox fld_txtHRKPIName;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRKPINo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRKPIName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcHRKPIs = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPINo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIs)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã KPI";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(34, 56);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên KPI";
            // 
            // fld_txtHRKPINo
            // 
            this.fld_txtHRKPINo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPINo.BOSDataMember = "HRKPINo";
            this.fld_txtHRKPINo.BOSDataSource = "HRKPIs";
            this.fld_txtHRKPINo.BOSDescription = null;
            this.fld_txtHRKPINo.BOSError = null;
            this.fld_txtHRKPINo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPINo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPINo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPINo.BOSPropertyName = "Text";
            this.fld_txtHRKPINo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPINo.Location = new System.Drawing.Point(166, 27);
            this.fld_txtHRKPINo.Name = "fld_txtHRKPINo";
            this.fld_txtHRKPINo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPINo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPINo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPINo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPINo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPINo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPINo.Screen = null;
            this.fld_txtHRKPINo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRKPINo.TabIndex = 0;
            this.fld_txtHRKPINo.Tag = "SC";
            // 
            // fld_txtHRKPIName
            // 
            this.fld_txtHRKPIName.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPIName.BOSDataMember = "HRKPIName";
            this.fld_txtHRKPIName.BOSDataSource = "HRKPIs";
            this.fld_txtHRKPIName.BOSDescription = null;
            this.fld_txtHRKPIName.BOSError = null;
            this.fld_txtHRKPIName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPIName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPIName.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPIName.BOSPropertyName = "Text";
            this.fld_txtHRKPIName.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRKPIName.Location = new System.Drawing.Point(166, 53);
            this.fld_txtHRKPIName.Name = "fld_txtHRKPIName";
            this.fld_txtHRKPIName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPIName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPIName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPIName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPIName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPIName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPIName.Screen = null;
            this.fld_txtHRKPIName.Size = new System.Drawing.Size(319, 20);
            this.fld_txtHRKPIName.TabIndex = 1;
            this.fld_txtHRKPIName.Tag = "SC";
            // 
            // fld_dgcHRKPIs
            // 
            this.fld_dgcHRKPIs.BOSComment = null;
            this.fld_dgcHRKPIs.BOSDataMember = null;
            this.fld_dgcHRKPIs.BOSDataSource = "HRKPIs";
            this.fld_dgcHRKPIs.BOSDescription = null;
            this.fld_dgcHRKPIs.BOSError = null;
            this.fld_dgcHRKPIs.BOSFieldGroup = null;
            this.fld_dgcHRKPIs.BOSFieldRelation = null;
            this.fld_dgcHRKPIs.BOSPrivilege = null;
            this.fld_dgcHRKPIs.BOSPropertyName = null;
            this.fld_dgcHRKPIs.Location = new System.Drawing.Point(34, 178);
            this.fld_dgcHRKPIs.MenuManager = this.screenToolbar;
            this.fld_dgcHRKPIs.Name = "fld_dgcHRKPIs";
            this.fld_dgcHRKPIs.Screen = null;
            this.fld_dgcHRKPIs.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRKPIs.TabIndex = 11;
            this.fld_dgcHRKPIs.Tag = "SR";
            // 
            // SMKPI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(599, 567);
            this.Controls.Add(this.fld_dgcHRKPIs);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtHRKPINo);
            this.Controls.Add(this.fld_txtHRKPIName);
            this.Name = "SMKPI100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRKPIName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRKPINo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRKPIs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPINo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRKPIs;
	}
}
