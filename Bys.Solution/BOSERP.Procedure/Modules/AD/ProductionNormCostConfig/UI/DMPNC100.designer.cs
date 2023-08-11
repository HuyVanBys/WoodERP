using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNormCostConfig.UI
{
	/// <summary>
	/// Summary description for DMCS100
	/// </summary>
	partial class DMPNC100
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionNormFactors = new BOSERP.Modules.ProductionNormCostConfig.MMProductionNormFactorsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabBankAndCash = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionNormCostFactors = new BOSERP.Modules.ProductionNormCostConfig.MMProductionNormCostFactorsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabBankAndCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormCostFactors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.fld_tabCompany);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(855, 536);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // fld_tabCompany
            // 
            this.fld_tabCompany.BOSComment = null;
            this.fld_tabCompany.BOSDataMember = null;
            this.fld_tabCompany.BOSDataSource = null;
            this.fld_tabCompany.BOSDescription = null;
            this.fld_tabCompany.BOSError = null;
            this.fld_tabCompany.BOSFieldGroup = null;
            this.fld_tabCompany.BOSFieldRelation = null;
            this.fld_tabCompany.BOSPrivilege = null;
            this.fld_tabCompany.BOSPropertyName = null;
            this.fld_tabCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabCompany.Location = new System.Drawing.Point(0, 0);
            this.fld_tabCompany.Name = "fld_tabCompany";
            this.fld_tabCompany.Screen = null;
            this.fld_tabCompany.SelectedTabPage = this.fld_tabBankAndCash;
            this.ScreenHelper.SetShowHelp(this.fld_tabCompany, true);
            this.fld_tabCompany.Size = new System.Drawing.Size(855, 536);
            this.fld_tabCompany.TabIndex = 63;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabBankAndCash,
            this.fld_tabInfomation});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.Controls.Add(this.fld_dgcMMProductionNormFactors);
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(848, 507);
            this.fld_tabInfomation.Text = "Nhóm yếu tố định mức";
            // 
            // fld_dgcMMProductionNormFactors
            // 
            this.fld_dgcMMProductionNormFactors.AllowDrop = true;
            this.fld_dgcMMProductionNormFactors.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormFactors.BOSDataMember = null;
            this.fld_dgcMMProductionNormFactors.BOSDataSource = "MMProductionNormFactors";
            this.fld_dgcMMProductionNormFactors.BOSDescription = null;
            this.fld_dgcMMProductionNormFactors.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormFactors.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormFactors.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormFactors.BOSGridType = null;
            this.fld_dgcMMProductionNormFactors.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormFactors.BOSPropertyName = null;
            this.fld_dgcMMProductionNormFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionNormFactors.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionNormFactors.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionNormFactors.MainView = this.gridView1;
            this.fld_dgcMMProductionNormFactors.Name = "fld_dgcMMProductionNormFactors";
            this.fld_dgcMMProductionNormFactors.PrintReport = false;
            this.fld_dgcMMProductionNormFactors.Screen = null;
            this.fld_dgcMMProductionNormFactors.Size = new System.Drawing.Size(848, 507);
            this.fld_dgcMMProductionNormFactors.TabIndex = 62;
            this.fld_dgcMMProductionNormFactors.Tag = "DC";
            this.fld_dgcMMProductionNormFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductionNormFactors;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabBankAndCash
            // 
            this.fld_tabBankAndCash.Controls.Add(this.fld_dgcMMProductionNormCostFactors);
            this.fld_tabBankAndCash.Name = "fld_tabBankAndCash";
            this.fld_tabBankAndCash.Size = new System.Drawing.Size(848, 507);
            this.fld_tabBankAndCash.Text = "Yếu tố chi phí định mức";
            // 
            // fld_dgcMMProductionNormCostFactors
            // 
            this.fld_dgcMMProductionNormCostFactors.AllowDrop = true;
            this.fld_dgcMMProductionNormCostFactors.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormCostFactors.BOSDataMember = null;
            this.fld_dgcMMProductionNormCostFactors.BOSDataSource = "MMProductionNormCostFactors";
            this.fld_dgcMMProductionNormCostFactors.BOSDescription = null;
            this.fld_dgcMMProductionNormCostFactors.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormCostFactors.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormCostFactors.BOSFieldRelation = null;
            this.fld_dgcMMProductionNormCostFactors.BOSGridType = null;
            this.fld_dgcMMProductionNormCostFactors.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMProductionNormCostFactors.BOSPropertyName = null;
            this.fld_dgcMMProductionNormCostFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionNormCostFactors.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionNormCostFactors.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionNormCostFactors.MainView = this.gridView2;
            this.fld_dgcMMProductionNormCostFactors.Name = "fld_dgcMMProductionNormCostFactors";
            this.fld_dgcMMProductionNormCostFactors.PrintReport = false;
            this.fld_dgcMMProductionNormCostFactors.Screen = null;
            this.fld_dgcMMProductionNormCostFactors.Size = new System.Drawing.Size(848, 507);
            this.fld_dgcMMProductionNormCostFactors.TabIndex = 62;
            this.fld_dgcMMProductionNormCostFactors.Tag = "DC";
            this.fld_dgcMMProductionNormCostFactors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionNormCostFactors;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // DMPNC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(855, 536);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMPNC100";
            this.Text = "Cấu hình giá thành định mức";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabBankAndCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionNormCostFactors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private MMProductionNormFactorsGridControl fld_dgcMMProductionNormFactors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage fld_tabBankAndCash;
        private MMProductionNormCostFactorsGridControl fld_dgcMMProductionNormCostFactors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
	}
}
