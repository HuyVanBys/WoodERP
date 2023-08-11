using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Equipment.UI
{
	/// <summary>
	/// Summary description for SMEQ100
	/// </summary>
	partial class SMEQ100
	{
		private BOSComponent.BOSLabel fld_lblLabel11;
		private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox fld_txtICProductNo;


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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcProducts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_txtMaDinhDanh = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaDinhDanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.Location = new System.Drawing.Point(27, 29);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(45, 13);
            this.fld_lblLabel11.TabIndex = 4;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã CCDC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel12.Location = new System.Drawing.Point(27, 55);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel12.TabIndex = 5;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Tên CCDC";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = null;
            this.fld_txtICProductNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductNo.Location = new System.Drawing.Point(99, 26);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo.TabIndex = 1;
            this.fld_txtICProductNo.Tag = "SC";
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment = null;
            this.fld_txtICProductName.BOSDataMember = "ICProductName";
            this.fld_txtICProductName.BOSDataSource = "ICProducts";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = null;
            this.fld_txtICProductName.BOSFieldGroup = null;
            this.fld_txtICProductName.BOSFieldRelation = null;
            this.fld_txtICProductName.BOSPrivilege = null;
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.Location = new System.Drawing.Point(99, 52);
            this.fld_txtICProductName.MenuManager = this.screenToolbar;
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(305, 20);
            this.fld_txtICProductName.TabIndex = 2;
            this.fld_txtICProductName.Tag = "SC";
            // 
            // fld_dgcProducts
            // 
            this.fld_dgcProducts.BOSComment = null;
            this.fld_dgcProducts.BOSDataMember = null;
            this.fld_dgcProducts.BOSDataSource = "ICProducts";
            this.fld_dgcProducts.BOSDescription = null;
            this.fld_dgcProducts.BOSError = null;
            this.fld_dgcProducts.BOSFieldGroup = null;
            this.fld_dgcProducts.BOSFieldRelation = null;
            this.fld_dgcProducts.BOSPrivilege = null;
            this.fld_dgcProducts.BOSPropertyName = null;
            this.fld_dgcProducts.Location = new System.Drawing.Point(27, 169);
            this.fld_dgcProducts.MenuManager = this.screenToolbar;
            this.fld_dgcProducts.Name = "fld_dgcProducts";
            this.fld_dgcProducts.Screen = null;
            this.fld_dgcProducts.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcProducts.TabIndex = 6;
            this.fld_dgcProducts.Tag = "SR";
            // 
            // fld_txtMaDinhDanh
            // 
            this.fld_txtMaDinhDanh.BOSComment = null;
            this.fld_txtMaDinhDanh.BOSDataMember = "MaDinhDanh";
            this.fld_txtMaDinhDanh.BOSDataSource = "ICProducts";
            this.fld_txtMaDinhDanh.BOSDescription = null;
            this.fld_txtMaDinhDanh.BOSError = null;
            this.fld_txtMaDinhDanh.BOSFieldGroup = null;
            this.fld_txtMaDinhDanh.BOSFieldRelation = null;
            this.fld_txtMaDinhDanh.BOSPrivilege = null;
            this.fld_txtMaDinhDanh.BOSPropertyName = "Text";
            this.fld_txtMaDinhDanh.Location = new System.Drawing.Point(99, 78);
            this.fld_txtMaDinhDanh.MenuManager = this.screenToolbar;
            this.fld_txtMaDinhDanh.Name = "fld_txtMaDinhDanh";
            this.fld_txtMaDinhDanh.Screen = null;
            this.fld_txtMaDinhDanh.Size = new System.Drawing.Size(305, 20);
            this.fld_txtMaDinhDanh.TabIndex = 7;
            this.fld_txtMaDinhDanh.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(27, 81);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã định danh";
            // 
            // SMEQ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMaDinhDanh);
            this.Controls.Add(this.fld_dgcProducts);
            this.Controls.Add(this.fld_txtICProductName);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.fld_txtICProductNo);
            this.Name = "SMEQ100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICProductNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductName, 0);
            this.Controls.SetChildIndex(this.fld_dgcProducts, 0);
            this.Controls.SetChildIndex(this.fld_txtMaDinhDanh, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMaDinhDanh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSSearchResultsGridControl fld_dgcProducts;
        private BOSComponent.BOSTextBox fld_txtMaDinhDanh;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
