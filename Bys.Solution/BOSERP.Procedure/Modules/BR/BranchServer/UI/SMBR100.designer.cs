using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Branch.UI
{
	/// <summary>
	/// Summary description for SMBR100
	/// </summary>
	partial class SMBR100
	{
		private BOSComponent.BOSTextBox fld_txtBRBranchName1;
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSSearchResultsGridControl fld_dgcBRBranch;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvBRBranch;
        private BOSComponent.BOSTextBox fld_txtBRBranchNo;


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
            this.fld_txtBRBranchName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcBRBranch = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvBRBranch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtBRBranchNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtBRBranchContactAddressLine3 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressLine3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtBRBranchName1
            // 
            this.fld_txtBRBranchName1.BOSComment = "";
            this.fld_txtBRBranchName1.BOSDataMember = "BRBranchName";
            this.fld_txtBRBranchName1.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchName1.BOSDescription = null;
            this.fld_txtBRBranchName1.BOSError = "";
            this.fld_txtBRBranchName1.BOSFieldGroup = "";
            this.fld_txtBRBranchName1.BOSFieldRelation = "";
            this.fld_txtBRBranchName1.BOSPrivilege = "";
            this.fld_txtBRBranchName1.BOSPropertyName = "Text";
            this.fld_txtBRBranchName1.Location = new System.Drawing.Point(133, 35);
            this.fld_txtBRBranchName1.Name = "fld_txtBRBranchName1";
            this.fld_txtBRBranchName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchName1.Screen = null;
            this.fld_txtBRBranchName1.Size = new System.Drawing.Size(306, 20);
            this.fld_txtBRBranchName1.TabIndex = 2;
            this.fld_txtBRBranchName1.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseFont = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(40, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel.TabIndex = 11;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chi nhánh";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(40, 38);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(69, 13);
            this.fld_lblLabel1.TabIndex = 12;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên chi nhánh";
            // 
            // fld_dgcBRBranch
            // 
            this.fld_dgcBRBranch.AllowDrop = true;
            this.fld_dgcBRBranch.BOSComment = "";
            this.fld_dgcBRBranch.BOSDataMember = null;
            this.fld_dgcBRBranch.BOSDataSource = "BRBranchs";
            this.fld_dgcBRBranch.BOSDescription = null;
            this.fld_dgcBRBranch.BOSError = "";
            this.fld_dgcBRBranch.BOSFieldGroup = "";
            this.fld_dgcBRBranch.BOSFieldRelation = null;
            this.fld_dgcBRBranch.BOSPrivilege = "";
            this.fld_dgcBRBranch.BOSPropertyName = null;
            this.fld_dgcBRBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcBRBranch.Location = new System.Drawing.Point(40, 160);
            this.fld_dgcBRBranch.MainView = this.fld_dgvBRBranch;
            this.fld_dgcBRBranch.Name = "fld_dgcBRBranch";
            this.fld_dgcBRBranch.Screen = null;
            this.fld_dgcBRBranch.Size = new System.Drawing.Size(516, 377);
            this.fld_dgcBRBranch.TabIndex = 10;
            this.fld_dgcBRBranch.Tag = "SR";
            this.fld_dgcBRBranch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvBRBranch});
            // 
            // fld_dgvBRBranch
            // 
            this.fld_dgvBRBranch.GridControl = this.fld_dgcBRBranch;
            this.fld_dgvBRBranch.Name = "fld_dgvBRBranch";
            this.fld_dgvBRBranch.PaintStyleName = "Office2003";
            // 
            // fld_txtBRBranchNo
            // 
            this.fld_txtBRBranchNo.BOSComment = "";
            this.fld_txtBRBranchNo.BOSDataMember = "BRBranchNo";
            this.fld_txtBRBranchNo.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchNo.BOSDescription = null;
            this.fld_txtBRBranchNo.BOSError = "";
            this.fld_txtBRBranchNo.BOSFieldGroup = "";
            this.fld_txtBRBranchNo.BOSFieldRelation = "";
            this.fld_txtBRBranchNo.BOSPrivilege = "";
            this.fld_txtBRBranchNo.BOSPropertyName = "Text";
            this.fld_txtBRBranchNo.Location = new System.Drawing.Point(133, 9);
            this.fld_txtBRBranchNo.Name = "fld_txtBRBranchNo";
            this.fld_txtBRBranchNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchNo.Screen = null;
            this.fld_txtBRBranchNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtBRBranchNo.TabIndex = 1;
            this.fld_txtBRBranchNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(40, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(33, 13);
            this.bosLabel1.TabIndex = 12;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Địa chỉ";
            // 
            // fld_txtBRBranchContactAddressLine3
            // 
            this.fld_txtBRBranchContactAddressLine3.BOSComment = "";
            this.fld_txtBRBranchContactAddressLine3.BOSDataMember = "BRBranchContactAddressLine3";
            this.fld_txtBRBranchContactAddressLine3.BOSDataSource = "BRBranchs";
            this.fld_txtBRBranchContactAddressLine3.BOSDescription = null;
            this.fld_txtBRBranchContactAddressLine3.BOSError = "";
            this.fld_txtBRBranchContactAddressLine3.BOSFieldGroup = "";
            this.fld_txtBRBranchContactAddressLine3.BOSFieldRelation = "";
            this.fld_txtBRBranchContactAddressLine3.BOSPrivilege = "";
            this.fld_txtBRBranchContactAddressLine3.BOSPropertyName = "Text";
            this.fld_txtBRBranchContactAddressLine3.Location = new System.Drawing.Point(133, 61);
            this.fld_txtBRBranchContactAddressLine3.Name = "fld_txtBRBranchContactAddressLine3";
            this.fld_txtBRBranchContactAddressLine3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtBRBranchContactAddressLine3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtBRBranchContactAddressLine3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtBRBranchContactAddressLine3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtBRBranchContactAddressLine3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtBRBranchContactAddressLine3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtBRBranchContactAddressLine3.Screen = null;
            this.fld_txtBRBranchContactAddressLine3.Size = new System.Drawing.Size(306, 20);
            this.fld_txtBRBranchContactAddressLine3.TabIndex = 3;
            this.fld_txtBRBranchContactAddressLine3.Tag = "SC";
            // 
            // SMBR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(594, 567);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtBRBranchName1);
            this.Controls.Add(this.fld_txtBRBranchNo);
            this.Controls.Add(this.fld_txtBRBranchContactAddressLine3);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_dgcBRBranch);
            this.Controls.Add(this.bosLabel1);
            this.Name = "SMBR100";
            this.Text = "Search";
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcBRBranch, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtBRBranchContactAddressLine3, 0);
            this.Controls.SetChildIndex(this.fld_txtBRBranchNo, 0);
            this.Controls.SetChildIndex(this.fld_txtBRBranchName1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcBRBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBRBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtBRBranchContactAddressLine3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtBRBranchContactAddressLine3;
	}
}
