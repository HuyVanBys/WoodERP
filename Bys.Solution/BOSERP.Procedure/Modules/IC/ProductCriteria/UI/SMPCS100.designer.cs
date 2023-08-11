using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductCriteria.UI
{
	/// <summary>
    /// Summary description for SMPCS100
	/// </summary>
    partial class SMPCS100
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICProductCriterias = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICProductCriteriaName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductCriteriaNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCriterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 48;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 51;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_dgcICProductCriterias
            // 
            this.fld_dgcICProductCriterias.AllowDrop = true;
            this.fld_dgcICProductCriterias.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductCriterias.BOSDataMember = null;
            this.fld_dgcICProductCriterias.BOSDataSource = "ICProductCriterias";
            this.fld_dgcICProductCriterias.BOSDescription = null;
            this.fld_dgcICProductCriterias.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductCriterias.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductCriterias.BOSFieldRelation = null;
            this.fld_dgcICProductCriterias.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICProductCriterias.BOSPropertyName = null;
            this.fld_dgcICProductCriterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICProductCriterias.Location = new System.Drawing.Point(12, 209);
            this.fld_dgcICProductCriterias.MainView = this.fld_dgvICProduct;
            this.fld_dgcICProductCriterias.Name = "fld_dgcICProductCriterias";
            this.fld_dgcICProductCriterias.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductCriterias, true);
            this.fld_dgcICProductCriterias.Size = new System.Drawing.Size(495, 265);
            this.fld_dgcICProductCriterias.TabIndex = 52;
            this.fld_dgcICProductCriterias.Tag = "SR";
            this.fld_dgcICProductCriterias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcICProductCriterias;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // fld_txtICProductCriteriaName
            // 
            this.fld_txtICProductCriteriaName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaName.BOSDataMember = "ICProductCriteriaName";
            this.fld_txtICProductCriteriaName.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaName.BOSDescription = null;
            this.fld_txtICProductCriteriaName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaName.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaName.Location = new System.Drawing.Point(117, 35);
            this.fld_txtICProductCriteriaName.Name = "fld_txtICProductCriteriaName";
            this.fld_txtICProductCriteriaName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCriteriaName, true);
            this.fld_txtICProductCriteriaName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductCriteriaName.TabIndex = 45;
            this.fld_txtICProductCriteriaName.Tag = "SC";
            // 
            // fld_txtICProductCriteriaNo
            // 
            this.fld_txtICProductCriteriaNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSDataMember = "ICProductCriteriaNo";
            this.fld_txtICProductCriteriaNo.BOSDataSource = "ICProductCriterias";
            this.fld_txtICProductCriteriaNo.BOSDescription = null;
            this.fld_txtICProductCriteriaNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICProductCriteriaNo.BOSPropertyName = "Text";
            this.fld_txtICProductCriteriaNo.Location = new System.Drawing.Point(117, 9);
            this.fld_txtICProductCriteriaNo.Name = "fld_txtICProductCriteriaNo";
            this.fld_txtICProductCriteriaNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCriteriaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCriteriaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCriteriaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCriteriaNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCriteriaNo, true);
            this.fld_txtICProductCriteriaNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductCriteriaNo.TabIndex = 44;
            this.fld_txtICProductCriteriaNo.Tag = "SC";
            // 
            // SMPCS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(586, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dgcICProductCriterias);
            this.Controls.Add(this.fld_txtICProductCriteriaName);
            this.Controls.Add(this.fld_txtICProductCriteriaNo);
            this.Name = "SMPCS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICProductCriteriaNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICProductCriteriaName, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProductCriterias, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCriterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCriteriaNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSSearchResultsGridControl fld_dgcICProductCriterias;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaName;
        private BOSComponent.BOSTextBox fld_txtICProductCriteriaNo;
        private IContainer components;
	}
}
