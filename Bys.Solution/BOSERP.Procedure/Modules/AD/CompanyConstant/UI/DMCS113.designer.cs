using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS113
	/// </summary>
	partial class DMCS113
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMCS113));
            this.fld_tabHumanResource = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcADPrivilegeAppSatffsGridControl = new BOSERP.Modules.CompanyConstant.ADPrivilegeAppSatffsGridControl();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.fld_dgcADPrivilegeAppSatffGroups = new BOSERP.Modules.CompanyConstant.ADPrivilegeAppSatffGroupsGridControl();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHumanResource)).BeginInit();
            this.fld_tabHumanResource.SuspendLayout();
            this.xtraTabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADPrivilegeAppSatffsGridControl)).BeginInit();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADPrivilegeAppSatffGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_tabHumanResource
            // 
            this.fld_tabHumanResource.BOSComment = null;
            this.fld_tabHumanResource.BOSDataMember = null;
            this.fld_tabHumanResource.BOSDataSource = null;
            this.fld_tabHumanResource.BOSDescription = null;
            this.fld_tabHumanResource.BOSError = null;
            this.fld_tabHumanResource.BOSFieldGroup = null;
            this.fld_tabHumanResource.BOSFieldRelation = null;
            this.fld_tabHumanResource.BOSPrivilege = null;
            this.fld_tabHumanResource.BOSPropertyName = null;
            resources.ApplyResources(this.fld_tabHumanResource, "fld_tabHumanResource");
            this.fld_tabHumanResource.Name = "fld_tabHumanResource";
            this.fld_tabHumanResource.Screen = null;
            this.fld_tabHumanResource.SelectedTabPage = this.xtraTabPage9;
            this.ScreenHelper.SetShowHelp(this.fld_tabHumanResource, ((bool)(resources.GetObject("fld_tabHumanResource.ShowHelp"))));
            this.fld_tabHumanResource.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage9});
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.bosPanel1);
            this.xtraTabPage9.Name = "xtraTabPage9";
            resources.ApplyResources(this.xtraTabPage9, "xtraTabPage9");
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            this.gridView7.PaintStyleName = "Office2003";
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            this.gridView6.PaintStyleName = "Office2003";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // gridView5
            // 
            this.gridView5.Name = "gridView5";
            this.gridView5.PaintStyleName = "Office2003";
            // 
            // gridView8
            // 
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // gridView9
            // 
            this.gridView9.Name = "gridView9";
            this.gridView9.PaintStyleName = "Office2003";
            // 
            // bosPanel1
            // 
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLine7);
            this.bosPanel1.Controls.Add(this.groupBox19);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            // 
            // bosLine7
            // 
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.fld_dgcADPrivilegeAppSatffsGridControl);
            resources.ApplyResources(this.bosLine7, "bosLine7");
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine7, ((bool)(resources.GetObject("bosLine7.ShowHelp"))));
            this.bosLine7.TabStop = false;
            // 
            // fld_dgcADPrivilegeAppSatffsGridControl
            // 
            this.fld_dgcADPrivilegeAppSatffsGridControl.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcADPrivilegeAppSatffsGridControl, "fld_dgcADPrivilegeAppSatffsGridControl");
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSComment = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSDataMember = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSDataSource = "ADPrivilegeAppSatffs";
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSDescription = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSError = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSFieldGroup = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSFieldRelation = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSGridType = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSPrivilege = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.BOSPropertyName = null;
            this.fld_dgcADPrivilegeAppSatffsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcADPrivilegeAppSatffsGridControl.Name = "fld_dgcADPrivilegeAppSatffsGridControl";
            this.fld_dgcADPrivilegeAppSatffsGridControl.PrintReport = false;
            this.fld_dgcADPrivilegeAppSatffsGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADPrivilegeAppSatffsGridControl, ((bool)(resources.GetObject("fld_dgcADPrivilegeAppSatffsGridControl.ShowHelp"))));
            this.fld_dgcADPrivilegeAppSatffsGridControl.Tag = "DC";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.fld_dgcADPrivilegeAppSatffGroups);
            resources.ApplyResources(this.groupBox19, "groupBox19");
            this.groupBox19.Name = "groupBox19";
            this.ScreenHelper.SetShowHelp(this.groupBox19, ((bool)(resources.GetObject("groupBox19.ShowHelp"))));
            this.groupBox19.TabStop = false;
            // 
            // fld_dgcADPrivilegeAppSatffGroups
            // 
            this.fld_dgcADPrivilegeAppSatffGroups.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcADPrivilegeAppSatffGroups, "fld_dgcADPrivilegeAppSatffGroups");
            this.fld_dgcADPrivilegeAppSatffGroups.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSDataMember = null;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSDataSource = "ADConfigValues";
            this.fld_dgcADPrivilegeAppSatffGroups.BOSDescription = null;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSError = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSFieldRelation = null;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSGridType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcADPrivilegeAppSatffGroups.BOSPropertyName = null;
            this.fld_dgcADPrivilegeAppSatffGroups.MainView = this.gridView21;
            this.fld_dgcADPrivilegeAppSatffGroups.Name = "fld_dgcADPrivilegeAppSatffGroups";
            this.fld_dgcADPrivilegeAppSatffGroups.PrintReport = false;
            this.fld_dgcADPrivilegeAppSatffGroups.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADPrivilegeAppSatffGroups, ((bool)(resources.GetObject("fld_dgcADPrivilegeAppSatffGroups.ShowHelp"))));
            this.fld_dgcADPrivilegeAppSatffGroups.Tag = "DC";
            this.fld_dgcADPrivilegeAppSatffGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView21});
            // 
            // gridView21
            // 
            this.gridView21.GridControl = this.fld_dgcADPrivilegeAppSatffGroups;
            this.gridView21.Name = "gridView21";
            this.gridView21.PaintStyleName = "Office2003";
            // 
            // DMCS113
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_tabHumanResource);
            this.Name = "DMCS113";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_tabHumanResource, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHumanResource)).EndInit();
            this.fld_tabHumanResource.ResumeLayout(false);
            this.xtraTabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADPrivilegeAppSatffsGridControl)).EndInit();
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADPrivilegeAppSatffGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabHumanResource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine7;
        private ADPrivilegeAppSatffsGridControl fld_dgcADPrivilegeAppSatffsGridControl;
        private GroupBox groupBox19;
        private ADPrivilegeAppSatffGroupsGridControl fld_dgcADPrivilegeAppSatffGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
	}
}
