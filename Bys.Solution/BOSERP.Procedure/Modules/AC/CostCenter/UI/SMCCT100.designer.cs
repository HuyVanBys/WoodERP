using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostCenter.UI
{
	/// <summary>
	/// Summary description for SMCCT100
	/// </summary>
	partial class SMCCT100
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
            this.fld_dgcACCostCenter = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostCenterNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACCostCenterName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostCenterOtherName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterOtherName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACCostCenter
            // 
            this.fld_dgcACCostCenter.BOSComment = null;
            this.fld_dgcACCostCenter.BOSDataMember = null;
            this.fld_dgcACCostCenter.BOSDataSource = "ACCostCenters";
            this.fld_dgcACCostCenter.BOSDescription = null;
            this.fld_dgcACCostCenter.BOSError = null;
            this.fld_dgcACCostCenter.BOSFieldGroup = null;
            this.fld_dgcACCostCenter.BOSFieldRelation = null;
            this.fld_dgcACCostCenter.BOSPrivilege = null;
            this.fld_dgcACCostCenter.BOSPropertyName = null;
            this.fld_dgcACCostCenter.Location = new System.Drawing.Point(107, 174);
            this.fld_dgcACCostCenter.MenuManager = this.screenToolbar;
            this.fld_dgcACCostCenter.Name = "fld_dgcACCostCenter";
            this.fld_dgcACCostCenter.Screen = null;
            this.fld_dgcACCostCenter.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACCostCenter.TabIndex = 15;
            this.fld_dgcACCostCenter.Tag = "SR";
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
            this.bosLabel2.Location = new System.Drawing.Point(22, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên TTCP";
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
            this.bosLabel1.Location = new System.Drawing.Point(22, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(42, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã TTCP";
            // 
            // fld_txtACCostCenterNo1
            // 
            this.fld_txtACCostCenterNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterNo1.BOSDataMember = "ACCostCenterNo";
            this.fld_txtACCostCenterNo1.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterNo1.BOSDescription = null;
            this.fld_txtACCostCenterNo1.BOSError = null;
            this.fld_txtACCostCenterNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterNo1.BOSPropertyName = "Text";
            this.fld_txtACCostCenterNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterNo1.Location = new System.Drawing.Point(107, 9);
            this.fld_txtACCostCenterNo1.Name = "fld_txtACCostCenterNo1";
            this.fld_txtACCostCenterNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterNo1.Screen = null;
            this.fld_txtACCostCenterNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostCenterNo1.TabIndex = 0;
            this.fld_txtACCostCenterNo1.Tag = "SC";
            // 
            // fld_txtACCostCenterName1
            // 
            this.fld_txtACCostCenterName1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterName1.BOSDataMember = "ACCostCenterName";
            this.fld_txtACCostCenterName1.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterName1.BOSDescription = null;
            this.fld_txtACCostCenterName1.BOSError = null;
            this.fld_txtACCostCenterName1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterName1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterName1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterName1.BOSPropertyName = "Text";
            this.fld_txtACCostCenterName1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterName1.Location = new System.Drawing.Point(107, 35);
            this.fld_txtACCostCenterName1.Name = "fld_txtACCostCenterName1";
            this.fld_txtACCostCenterName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterName1.Screen = null;
            this.fld_txtACCostCenterName1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostCenterName1.TabIndex = 1;
            this.fld_txtACCostCenterName1.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(22, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(55, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tên TTCP 2";
            // 
            // fld_txtACCostCenterOtherName
            // 
            this.fld_txtACCostCenterOtherName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterOtherName.BOSDataMember = "ACCostCenterOtherName";
            this.fld_txtACCostCenterOtherName.BOSDataSource = "ACCostCenters";
            this.fld_txtACCostCenterOtherName.BOSDescription = null;
            this.fld_txtACCostCenterOtherName.BOSError = null;
            this.fld_txtACCostCenterOtherName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterOtherName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterOtherName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterOtherName.BOSPropertyName = "Text";
            this.fld_txtACCostCenterOtherName.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostCenterOtherName.Location = new System.Drawing.Point(107, 61);
            this.fld_txtACCostCenterOtherName.Name = "fld_txtACCostCenterOtherName";
            this.fld_txtACCostCenterOtherName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostCenterOtherName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostCenterOtherName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostCenterOtherName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostCenterOtherName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostCenterOtherName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostCenterOtherName.Screen = null;
            this.fld_txtACCostCenterOtherName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostCenterOtherName.TabIndex = 2;
            this.fld_txtACCostCenterOtherName.Tag = "SC";
            // 
            // SMCCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_txtACCostCenterOtherName);
            this.Controls.Add(this.fld_dgcACCostCenter);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACCostCenterNo1);
            this.Controls.Add(this.fld_txtACCostCenterName1);
            this.Name = "SMCCT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACCostCenterName1, 0);
            this.Controls.SetChildIndex(this.fld_txtACCostCenterNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcACCostCenter, 0);
            this.Controls.SetChildIndex(this.fld_txtACCostCenterOtherName, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostCenterOtherName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACCostCenter;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACCostCenterNo1;
        private BOSComponent.BOSTextBox fld_txtACCostCenterName1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtACCostCenterOtherName;
	}
}
