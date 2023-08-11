using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Collection.UI
{
	/// <summary>
    /// Summary description for SMCT100
	/// </summary>
    partial class SMCT100
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
            this.fld_dgcICCollections = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtICCollectionName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICCollectionNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionNo.Properties)).BeginInit();
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
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(72, 13);
            this.bosLabel1.TabIndex = 48;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên bộ sưu tập";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel4.TabIndex = 51;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã bộ sưu tập";
            // 
            // fld_dgcICCollections
            // 
            this.fld_dgcICCollections.AllowDrop = true;
            this.fld_dgcICCollections.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICCollections.BOSDataMember = null;
            this.fld_dgcICCollections.BOSDataSource = "ICCollections";
            this.fld_dgcICCollections.BOSDescription = null;
            this.fld_dgcICCollections.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICCollections.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICCollections.BOSFieldRelation = null;
            this.fld_dgcICCollections.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICCollections.BOSPropertyName = null;
            this.fld_dgcICCollections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_dgcICCollections.Location = new System.Drawing.Point(12, 209);
            this.fld_dgcICCollections.MainView = this.fld_dgvICProduct;
            this.fld_dgcICCollections.Name = "fld_dgcICCollections";
            this.fld_dgcICCollections.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICCollections, true);
            this.fld_dgcICCollections.Size = new System.Drawing.Size(495, 265);
            this.fld_dgcICCollections.TabIndex = 52;
            this.fld_dgcICCollections.Tag = "SR";
            this.fld_dgcICCollections.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICProduct});
            // 
            // fld_dgvICProduct
            // 
            this.fld_dgvICProduct.GridControl = this.fld_dgcICCollections;
            this.fld_dgvICProduct.Name = "fld_dgvICProduct";
            this.fld_dgvICProduct.PaintStyleName = "Office2003";
            // 
            // fld_txtICCollectionName
            // 
            this.fld_txtICCollectionName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionName.BOSDataMember = "ICCollectionName";
            this.fld_txtICCollectionName.BOSDataSource = "ICCollections";
            this.fld_txtICCollectionName.BOSDescription = null;
            this.fld_txtICCollectionName.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionName.BOSPropertyName = "Text";
            this.fld_txtICCollectionName.Location = new System.Drawing.Point(117, 35);
            this.fld_txtICCollectionName.Name = "fld_txtICCollectionName";
            this.fld_txtICCollectionName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICCollectionName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICCollectionName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICCollectionName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICCollectionName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICCollectionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICCollectionName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICCollectionName, true);
            this.fld_txtICCollectionName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICCollectionName.TabIndex = 45;
            this.fld_txtICCollectionName.Tag = "SC";
            // 
            // fld_txtICCollectionNo
            // 
            this.fld_txtICCollectionNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionNo.BOSDataMember = "ICCollectionNo";
            this.fld_txtICCollectionNo.BOSDataSource = "ICCollections";
            this.fld_txtICCollectionNo.BOSDescription = null;
            this.fld_txtICCollectionNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICCollectionNo.BOSPropertyName = "Text";
            this.fld_txtICCollectionNo.Location = new System.Drawing.Point(117, 9);
            this.fld_txtICCollectionNo.Name = "fld_txtICCollectionNo";
            this.fld_txtICCollectionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICCollectionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICCollectionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICCollectionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICCollectionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICCollectionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICCollectionNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICCollectionNo, true);
            this.fld_txtICCollectionNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICCollectionNo.TabIndex = 44;
            this.fld_txtICCollectionNo.Tag = "SC";
            // 
            // SMCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(586, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dgcICCollections);
            this.Controls.Add(this.fld_txtICCollectionName);
            this.Controls.Add(this.fld_txtICCollectionNo);
            this.Name = "SMCT100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICCollectionNo, 0);
            this.Controls.SetChildIndex(this.fld_txtICCollectionName, 0);
            this.Controls.SetChildIndex(this.fld_dgcICCollections, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICCollections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICCollectionNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSSearchResultsGridControl fld_dgcICCollections;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICProduct;
        private BOSComponent.BOSTextBox fld_txtICCollectionName;
        private BOSComponent.BOSTextBox fld_txtICCollectionNo;
        private IContainer components;
	}
}
