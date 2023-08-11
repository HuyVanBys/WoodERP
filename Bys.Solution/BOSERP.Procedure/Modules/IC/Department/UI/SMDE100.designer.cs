using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Department.UI
{
	/// <summary>
	/// Summary description for SMDE100
	/// </summary>
	partial class SMDE100
	{
		private BOSComponent.BOSLabel fld_lblLabel53;
        private BOSComponent.BOSLabel fld_lblLabel57;
		private BOSComponent.BOSTextBox fld_txtICDepartmentName;
		private BOSComponent.BOSLabel fld_lblLabel51;
		private BOSComponent.BOSLabel fld_lblLabel58;
		private BOSSearchResultsGridControl fld_dgcICDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartment;
        private BOSComponent.BOSTextBox fld_txtICDepartmentNo;


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
            this.fld_txtICDepartmentName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel51 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel58 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICDepartment = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICDepartmentNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentNo.Properties)).BeginInit();
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
            this.fld_lblLabel53.BOSComment = "";
            this.fld_lblLabel53.BOSDataMember = "";
            this.fld_lblLabel53.BOSDataSource = "";
            this.fld_lblLabel53.BOSDescription = null;
            this.fld_lblLabel53.BOSError = null;
            this.fld_lblLabel53.BOSFieldGroup = "";
            this.fld_lblLabel53.BOSFieldRelation = "";
            this.fld_lblLabel53.BOSPrivilege = "";
            this.fld_lblLabel53.BOSPropertyName = null;
            this.fld_lblLabel53.Location = new System.Drawing.Point(47, 12);
            this.fld_lblLabel53.Name = "fld_lblLabel53";
            this.fld_lblLabel53.Screen = null;
            this.fld_lblLabel53.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel53.TabIndex = 4;
            this.fld_lblLabel53.Tag = "SI";
            this.fld_lblLabel53.Text = "Mã ngành hàng";
            // 
            // fld_lblLabel57
            // 
            this.fld_lblLabel57.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel57.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel57.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel57.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel57.Appearance.Options.UseFont = true;
            this.fld_lblLabel57.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel57.BOSComment = "";
            this.fld_lblLabel57.BOSDataMember = "";
            this.fld_lblLabel57.BOSDataSource = "";
            this.fld_lblLabel57.BOSDescription = null;
            this.fld_lblLabel57.BOSError = null;
            this.fld_lblLabel57.BOSFieldGroup = "";
            this.fld_lblLabel57.BOSFieldRelation = "";
            this.fld_lblLabel57.BOSPrivilege = "";
            this.fld_lblLabel57.BOSPropertyName = null;
            this.fld_lblLabel57.Location = new System.Drawing.Point(47, 38);
            this.fld_lblLabel57.Name = "fld_lblLabel57";
            this.fld_lblLabel57.Screen = null;
            this.fld_lblLabel57.Size = new System.Drawing.Size(79, 13);
            this.fld_lblLabel57.TabIndex = 5;
            this.fld_lblLabel57.Tag = "SI";
            this.fld_lblLabel57.Text = "Tên ngành hàng";
            // 
            // fld_txtICDepartmentName
            // 
            this.fld_txtICDepartmentName.BOSComment = "";
            this.fld_txtICDepartmentName.BOSDataMember = "ICDepartmentName";
            this.fld_txtICDepartmentName.BOSDataSource = "ICDepartments";
            this.fld_txtICDepartmentName.BOSDescription = null;
            this.fld_txtICDepartmentName.BOSError = "";
            this.fld_txtICDepartmentName.BOSFieldGroup = "";
            this.fld_txtICDepartmentName.BOSFieldRelation = "";
            this.fld_txtICDepartmentName.BOSPrivilege = "";
            this.fld_txtICDepartmentName.BOSPropertyName = "Text";
            this.fld_txtICDepartmentName.Location = new System.Drawing.Point(162, 35);
            this.fld_txtICDepartmentName.Name = "fld_txtICDepartmentName";
            this.fld_txtICDepartmentName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDepartmentName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDepartmentName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDepartmentName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDepartmentName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDepartmentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDepartmentName.Screen = null;
            this.fld_txtICDepartmentName.Size = new System.Drawing.Size(322, 20);
            this.fld_txtICDepartmentName.TabIndex = 2;
            this.fld_txtICDepartmentName.Tag = "SC";
            // 
            // fld_lblLabel51
            // 
            this.fld_lblLabel51.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel51.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel51.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel51.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel51.Appearance.Options.UseFont = true;
            this.fld_lblLabel51.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel51.BOSComment = "";
            this.fld_lblLabel51.BOSDataMember = "";
            this.fld_lblLabel51.BOSDataSource = "";
            this.fld_lblLabel51.BOSDescription = null;
            this.fld_lblLabel51.BOSError = null;
            this.fld_lblLabel51.BOSFieldGroup = "";
            this.fld_lblLabel51.BOSFieldRelation = "";
            this.fld_lblLabel51.BOSPrivilege = "";
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
            this.fld_lblLabel58.BOSComment = "";
            this.fld_lblLabel58.BOSDataMember = "";
            this.fld_lblLabel58.BOSDataSource = "";
            this.fld_lblLabel58.BOSDescription = null;
            this.fld_lblLabel58.BOSError = null;
            this.fld_lblLabel58.BOSFieldGroup = "";
            this.fld_lblLabel58.BOSFieldRelation = "";
            this.fld_lblLabel58.BOSPrivilege = "";
            this.fld_lblLabel58.BOSPropertyName = null;
            this.fld_lblLabel58.Location = new System.Drawing.Point(10, 99);
            this.fld_lblLabel58.Name = "fld_lblLabel58";
            this.fld_lblLabel58.Screen = null;
            this.fld_lblLabel58.Size = new System.Drawing.Size(0, 13);
            this.fld_lblLabel58.TabIndex = 66;
            this.fld_lblLabel58.Tag = "SI";
            // 
            // fld_dgcICDepartment
            // 
            this.fld_dgcICDepartment.AllowDrop = true;
            this.fld_dgcICDepartment.BOSComment = "";
            this.fld_dgcICDepartment.BOSDataMember = null;
            this.fld_dgcICDepartment.BOSDataSource = "ICDepartments";
            this.fld_dgcICDepartment.BOSDescription = null;
            this.fld_dgcICDepartment.BOSError = "";
            this.fld_dgcICDepartment.BOSFieldGroup = "";
            this.fld_dgcICDepartment.BOSFieldRelation = null;
            this.fld_dgcICDepartment.BOSPrivilege = "";
            this.fld_dgcICDepartment.BOSPropertyName = null;
            this.fld_dgcICDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICDepartment.Location = new System.Drawing.Point(47, 85);
            this.fld_dgcICDepartment.MainView = this.fld_dgvICDepartment;
            this.fld_dgcICDepartment.Name = "fld_dgcICDepartment";
            this.fld_dgcICDepartment.Screen = null;
            this.fld_dgcICDepartment.Size = new System.Drawing.Size(567, 412);
            this.fld_dgcICDepartment.TabIndex = 2;
            this.fld_dgcICDepartment.Tag = "SR";
            this.fld_dgcICDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartment});
            // 
            // fld_dgvICDepartment
            // 
            this.fld_dgvICDepartment.GridControl = this.fld_dgcICDepartment;
            this.fld_dgvICDepartment.Name = "fld_dgvICDepartment";
            this.fld_dgvICDepartment.PaintStyleName = "Office2003";
            // 
            // fld_txtICDepartmentNo
            // 
            this.fld_txtICDepartmentNo.BOSComment = "";
            this.fld_txtICDepartmentNo.BOSDataMember = "ICDepartmentNo";
            this.fld_txtICDepartmentNo.BOSDataSource = "ICDepartments";
            this.fld_txtICDepartmentNo.BOSDescription = null;
            this.fld_txtICDepartmentNo.BOSError = "";
            this.fld_txtICDepartmentNo.BOSFieldGroup = "";
            this.fld_txtICDepartmentNo.BOSFieldRelation = "";
            this.fld_txtICDepartmentNo.BOSPrivilege = "";
            this.fld_txtICDepartmentNo.BOSPropertyName = "Text";
            this.fld_txtICDepartmentNo.Location = new System.Drawing.Point(162, 9);
            this.fld_txtICDepartmentNo.Name = "fld_txtICDepartmentNo";
            this.fld_txtICDepartmentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDepartmentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDepartmentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDepartmentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDepartmentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDepartmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDepartmentNo.Screen = null;
            this.fld_txtICDepartmentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICDepartmentNo.TabIndex = 1;
            this.fld_txtICDepartmentNo.Tag = "SC";
            // 
            // SMDE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(663, 567);
            this.Controls.Add(this.fld_lblLabel53);
            this.Controls.Add(this.fld_lblLabel51);
            this.Controls.Add(this.fld_lblLabel58);
            this.Controls.Add(this.fld_lblLabel57);
            this.Controls.Add(this.fld_txtICDepartmentName);
            this.Controls.Add(this.fld_dgcICDepartment);
            this.Controls.Add(this.fld_txtICDepartmentNo);
            this.Name = "SMDE100";
            this.Text = "Search";
            this.Controls.SetChildIndex(this.fld_txtICDepartmentNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcICDepartment, 0);
            this.Controls.SetChildIndex(this.fld_txtICDepartmentName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel57, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel58, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel51, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel53, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
