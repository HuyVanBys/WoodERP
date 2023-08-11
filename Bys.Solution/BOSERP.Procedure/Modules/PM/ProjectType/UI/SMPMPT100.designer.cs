using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProjectType.UI
{
	/// <summary>
	/// Summary description for SMDE100
	/// </summary>
    partial class SMPMPT100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtPMProjectTypeName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcPMProjectType;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
        private BOSComponent.BOSTextBox fld_txtPMProjectTypeNo;


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
            this.fld_lblLabel53 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel57 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectTypeName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcPMProjectType = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtPMProjectTypeNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel53
            // 
            this.fld_lblLabel53.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel53.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel53.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel53.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel53.Appearance.Options.UseFont = true;
            this.fld_lblLabel53.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel53.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(47, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã loại dự án";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(47, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên loại dự án";
            // 
            // fld_txtPMProjectTypeName
            // 
            this.fld_txtPMProjectTypeName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeName.BOSDataMember = "PMProjectTypeName";
            this.fld_txtPMProjectTypeName.BOSDataSource = "PMProjectTypes";
            this.fld_txtPMProjectTypeName.BOSDescription = null;
            this.fld_txtPMProjectTypeName.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeName.BOSPropertyName = "Text";
            this.fld_txtPMProjectTypeName.Location = new System.Drawing.Point(121, 35);
            this.fld_txtPMProjectTypeName.Name = "fld_txtPMProjectTypeName";
            this.fld_txtPMProjectTypeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectTypeName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectTypeName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectTypeName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectTypeName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectTypeName.Screen = null;
            this.fld_txtPMProjectTypeName.Size = new System.Drawing.Size(363, 20);
            this.fld_txtPMProjectTypeName.TabIndex = 2;
            this.fld_txtPMProjectTypeName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel51.BOSPropertyName = null;
            this.fld_lblLabel51.Location = new System.Drawing.Point(70, 85);
            this.fld_lblLabel51.Name = "fld_lblLabel51";
            this.fld_lblLabel51.Screen = null;
            this.fld_lblLabel51.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel51.TabIndex = 65;
            this.fld_lblLabel51.Tag = "SI";
            // 
            // fld_lblLabel58
            // 
            this.fld_lblLabel58.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel58.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel58.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel58.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel58.Appearance.Options.UseFont = true;
            this.fld_lblLabel58.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel58.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcPMProjectType
            // 
            this.fld_dgcPMProjectType.AllowDrop = true;
            this.fld_dgcPMProjectType.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcPMProjectType.BOSDataMember = null;
            this.fld_dgcPMProjectType.BOSDataSource = "PMProjectTypes";
            this.fld_dgcPMProjectType.BOSDescription = null;
            this.fld_dgcPMProjectType.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcPMProjectType.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcPMProjectType.BOSFieldRelation = null;
            this.fld_dgcPMProjectType.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcPMProjectType.BOSPropertyName = null;
            this.fld_dgcPMProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcPMProjectType.Location = new System.Drawing.Point(47, 85);
            this.fld_dgcPMProjectType.MainView = this.fld_dgvICDepartment;
            this.fld_dgcPMProjectType.Name = "fld_dgcPMProjectType";
            this.fld_dgcPMProjectType.Screen = null;
            this.fld_dgcPMProjectType.Size = new System.Drawing.Size(567, 412);
            this.fld_dgcPMProjectType.TabIndex = 2;
            this.fld_dgcPMProjectType.Tag = "SR";
            this.fld_dgcPMProjectType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcPMProjectType;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // fld_txtPMProjectTypeNo
            // 
            this.fld_txtPMProjectTypeNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeNo.BOSDataMember = "PMProjectTypeNo";
            this.fld_txtPMProjectTypeNo.BOSDataSource = "PMProjectTypes";
            this.fld_txtPMProjectTypeNo.BOSDescription = null;
            this.fld_txtPMProjectTypeNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtPMProjectTypeNo.BOSPropertyName = "Text";
            this.fld_txtPMProjectTypeNo.Location = new System.Drawing.Point(121, 9);
            this.fld_txtPMProjectTypeNo.Name = "fld_txtPMProjectTypeNo";
            this.fld_txtPMProjectTypeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectTypeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectTypeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectTypeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectTypeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectTypeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectTypeNo.Screen = null;
            this.fld_txtPMProjectTypeNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtPMProjectTypeNo.TabIndex = 1;
            this.fld_txtPMProjectTypeNo.Tag = "SC";
            // 
            // SMPMPT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 567);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtPMProjectTypeName);
            this.Controls.Add(this.fld_dgcPMProjectType);
            this.Controls.Add(this.fld_txtPMProjectTypeNo);
            this.Name = "SMPMPT100";
            this.Text = "Search";
            this.Controls.SetChildIndex(this.fld_txtPMProjectTypeNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcPMProjectType, 0);
            this.Controls.SetChildIndex(this.fld_txtPMProjectTypeName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
