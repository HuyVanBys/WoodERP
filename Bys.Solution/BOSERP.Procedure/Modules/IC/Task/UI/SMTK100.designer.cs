using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Task.UI
{
	/// <summary>
    /// Summary description for SMTK100
	/// </summary>
    partial class SMTK100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtICTaskName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcICTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
        private BOSComponent.BOSTextBox fld_txtICTaskNo;


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
            this.fld_txtICTaskName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICTasks = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICTaskNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskNo.Properties)).BeginInit();
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
            this.fld_lblLabel53.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(47, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(38, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã task";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(47, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên task";
            // 
            // fld_txtICTaskName
            // 
            this.fld_txtICTaskName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskName.BOSDataMember = "ICTaskName";
            this.fld_txtICTaskName.BOSDataSource = "ICTasks";
            this.fld_txtICTaskName.BOSDescription = null;
            this.fld_txtICTaskName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskName.BOSPropertyName = "Text";
            this.fld_txtICTaskName.Location = new System.Drawing.Point(151, 35);
            this.fld_txtICTaskName.Name = "fld_txtICTaskName";
            this.fld_txtICTaskName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskName.Screen = null;
            this.fld_txtICTaskName.Size = new System.Drawing.Size(363, 20);
            this.fld_txtICTaskName.TabIndex = 2;
            this.fld_txtICTaskName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel51.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
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
            this.fld_lblLabel58.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcICTasks
            // 
            this.fld_dgcICTasks.AllowDrop = true;
            this.fld_dgcICTasks.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICTasks.BOSDataMember = null;
            this.fld_dgcICTasks.BOSDataSource = "ICTasks";
            this.fld_dgcICTasks.BOSDescription = null;
            this.fld_dgcICTasks.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICTasks.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICTasks.BOSFieldRelation = null;
            this.fld_dgcICTasks.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICTasks.BOSPropertyName = null;
            this.fld_dgcICTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICTasks.Location = new System.Drawing.Point(47, 85);
            this.fld_dgcICTasks.MainView = this.fld_dgvICDepartment;
            this.fld_dgcICTasks.Name = "fld_dgcICTasks";
            this.fld_dgcICTasks.Screen = null;
            this.fld_dgcICTasks.Size = new System.Drawing.Size(567, 412);
            this.fld_dgcICTasks.TabIndex = 2;
            this.fld_dgcICTasks.Tag = "SR";
            this.fld_dgcICTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcICTasks;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // fld_txtICTaskNo
            // 
            this.fld_txtICTaskNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskNo.BOSDataMember = "ICTaskNo";
            this.fld_txtICTaskNo.BOSDataSource = "ICTasks";
            this.fld_txtICTaskNo.BOSDescription = null;
            this.fld_txtICTaskNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICTaskNo.BOSPropertyName = "Text";
            this.fld_txtICTaskNo.Location = new System.Drawing.Point(151, 9);
            this.fld_txtICTaskNo.Name = "fld_txtICTaskNo";
            this.fld_txtICTaskNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskNo.Screen = null;
            this.fld_txtICTaskNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtICTaskNo.TabIndex = 1;
            this.fld_txtICTaskNo.Tag = "SC";
            // 
            // SMTK100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 567);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtICTaskName);
            this.Controls.Add(this.fld_dgcICTasks);
            this.Controls.Add(this.fld_txtICTaskNo);
            this.Name = "SMTK100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICTaskNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcICTasks, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
