using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
	/// Summary description for DMPM104
	/// </summary>
	partial class DMPM104
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
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchHistoryToDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApplyView = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteSearchHistoryFromDateView = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcPMProjectNormHistorysGridControl = new BOSERP.Modules.Project.PMProjectNormHistorysGridControl();
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectNormHistorysGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.Location = new System.Drawing.Point(240, 15);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel20.TabIndex = 50;
            this.fld_lblLabel20.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel20.Text = "Đến ngày";
            // 
            // fld_dteSearchHistoryToDateView
            // 
            this.fld_dteSearchHistoryToDateView.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSDescription = null;
            this.fld_dteSearchHistoryToDateView.BOSError = null;
            this.fld_dteSearchHistoryToDateView.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryToDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchHistoryToDateView.EditValue = null;
            this.fld_dteSearchHistoryToDateView.Location = new System.Drawing.Point(293, 12);
            this.fld_dteSearchHistoryToDateView.Name = "fld_dteSearchHistoryToDateView";
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHistoryToDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHistoryToDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHistoryToDateView.Screen = null;
            this.fld_dteSearchHistoryToDateView.Size = new System.Drawing.Size(133, 20);
            this.fld_dteSearchHistoryToDateView.TabIndex = 5;
            this.fld_dteSearchHistoryToDateView.Tag = "DC";
            // 
            // fld_btnApplyView
            // 
            this.fld_btnApplyView.BOSComment = null;
            this.fld_btnApplyView.BOSDataMember = null;
            this.fld_btnApplyView.BOSDataSource = null;
            this.fld_btnApplyView.BOSDescription = null;
            this.fld_btnApplyView.BOSError = null;
            this.fld_btnApplyView.BOSFieldGroup = null;
            this.fld_btnApplyView.BOSFieldRelation = null;
            this.fld_btnApplyView.BOSPrivilege = null;
            this.fld_btnApplyView.BOSPropertyName = null;
            this.fld_btnApplyView.Location = new System.Drawing.Point(467, 3);
            this.fld_btnApplyView.Name = "fld_btnApplyView";
            this.fld_btnApplyView.Screen = null;
            this.fld_btnApplyView.Size = new System.Drawing.Size(75, 38);
            this.fld_btnApplyView.TabIndex = 6;
            this.fld_btnApplyView.Text = "Xem";
            this.fld_btnApplyView.Click += new System.EventHandler(this.fld_btnApplyView_Click);
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
            this.bosPanel1.Controls.Add(this.fld_dteSearchHistoryFromDateView);
            this.bosPanel1.Controls.Add(this.fld_dgcPMProjectNormHistorysGridControl);
            this.bosPanel1.Controls.Add(this.fld_btnApplyView);
            this.bosPanel1.Controls.Add(this.BOSLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteSearchHistoryToDateView);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 57;
            // 
            // fld_dteSearchHistoryFromDateView
            // 
            this.fld_dteSearchHistoryFromDateView.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSDescription = null;
            this.fld_dteSearchHistoryFromDateView.BOSError = null;
            this.fld_dteSearchHistoryFromDateView.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHistoryFromDateView.BOSPropertyName = "EditValue";
            this.fld_dteSearchHistoryFromDateView.EditValue = null;
            this.fld_dteSearchHistoryFromDateView.Location = new System.Drawing.Point(81, 12);
            this.fld_dteSearchHistoryFromDateView.Name = "fld_dteSearchHistoryFromDateView";
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHistoryFromDateView.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHistoryFromDateView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHistoryFromDateView.Screen = null;
            this.fld_dteSearchHistoryFromDateView.Size = new System.Drawing.Size(133, 20);
            this.fld_dteSearchHistoryFromDateView.TabIndex = 108;
            this.fld_dteSearchHistoryFromDateView.Tag = "DC";
            // 
            // fld_dgcPMProjectNormHistorysGridControl
            // 
            this.fld_dgcPMProjectNormHistorysGridControl.AllowDrop = true;
            this.fld_dgcPMProjectNormHistorysGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMProjectNormHistorysGridControl.BOSComment = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSDataMember = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSDataSource = "PMProjectNormHistorys";
            this.fld_dgcPMProjectNormHistorysGridControl.BOSDescription = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSError = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSFieldGroup = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSFieldRelation = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSGridType = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSPrivilege = null;
            this.fld_dgcPMProjectNormHistorysGridControl.BOSPropertyName = null;
            this.fld_dgcPMProjectNormHistorysGridControl.Location = new System.Drawing.Point(3, 47);
            this.fld_dgcPMProjectNormHistorysGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcPMProjectNormHistorysGridControl.Name = "fld_dgcPMProjectNormHistorysGridControl";
            this.fld_dgcPMProjectNormHistorysGridControl.PrintReport = false;
            this.fld_dgcPMProjectNormHistorysGridControl.Screen = null;
            this.fld_dgcPMProjectNormHistorysGridControl.Size = new System.Drawing.Size(856, 517);
            this.fld_dgcPMProjectNormHistorysGridControl.TabIndex = 107;
            this.fld_dgcPMProjectNormHistorysGridControl.Tag = "DC";
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(35, 15);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel4.TabIndex = 53;
            this.BOSLabel4.Text = "Từ ngày";
            // 
            // DMPM104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPM104";
            this.Text = "Lịch sử thay đổi";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryToDateView.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHistoryFromDateView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMProjectNormHistorysGridControl)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSDateEdit fld_dteSearchHistoryToDateView;
        private BOSComponent.BOSButton fld_btnApplyView;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel BOSLabel4;
        private PMProjectNormHistorysGridControl fld_dgcPMProjectNormHistorysGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchHistoryFromDateView;
	}
}
