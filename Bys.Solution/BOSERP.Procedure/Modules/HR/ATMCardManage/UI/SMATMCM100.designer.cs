using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ATMCardManage.UI
{
    /// <summary>
    /// Summary description for SMATMCM100
    /// </summary>
    partial class SMATMCM100
    {
		private BOSSearchResultsGridControl fld_dgcHRATMCardManages;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRATMCardManage;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMATMCM100));
            this.fld_dgcHRATMCardManages = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRATMCardManage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel100 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel101 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRATMCardManageNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRATMCardManageName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardManages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRATMCardManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRATMCardManages
            // 
            this.fld_dgcHRATMCardManages.AllowDrop = true;
            this.fld_dgcHRATMCardManages.BOSComment = "";
            this.fld_dgcHRATMCardManages.BOSDataMember = "";
            this.fld_dgcHRATMCardManages.BOSDataSource = "HRATMCardManages";
            this.fld_dgcHRATMCardManages.BOSDescription = null;
            this.fld_dgcHRATMCardManages.BOSError = null;
            this.fld_dgcHRATMCardManages.BOSFieldGroup = "";
            this.fld_dgcHRATMCardManages.BOSFieldRelation = "";
            this.fld_dgcHRATMCardManages.BOSGridType = null;
            this.fld_dgcHRATMCardManages.BOSPrivilege = "";
            this.fld_dgcHRATMCardManages.BOSPropertyName = "";
            this.fld_dgcHRATMCardManages.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRATMCardManages, "fld_dgcHRATMCardManages");
            this.fld_dgcHRATMCardManages.MainView = this.fld_dgvHRATMCardManage;
            this.fld_dgcHRATMCardManages.Name = "fld_dgcHRATMCardManages";
            this.fld_dgcHRATMCardManages.PrintReport = false;
            this.fld_dgcHRATMCardManages.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRATMCardManages, ((bool)(resources.GetObject("fld_dgcHRATMCardManages.ShowHelp"))));
            this.fld_dgcHRATMCardManages.Tag = "SR";
            this.fld_dgcHRATMCardManages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRATMCardManage});
            // 
            // fld_dgvHRATMCardManage
            // 
            this.fld_dgvHRATMCardManage.GridControl = this.fld_dgcHRATMCardManages;
            this.fld_dgvHRATMCardManage.Name = "fld_dgvHRATMCardManage";
            this.fld_dgvHRATMCardManage.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel100
            // 
            this.fld_lblLabel100.BOSComment = null;
            this.fld_lblLabel100.BOSDataMember = null;
            this.fld_lblLabel100.BOSDataSource = null;
            this.fld_lblLabel100.BOSDescription = null;
            this.fld_lblLabel100.BOSError = null;
            this.fld_lblLabel100.BOSFieldGroup = null;
            this.fld_lblLabel100.BOSFieldRelation = null;
            this.fld_lblLabel100.BOSPrivilege = null;
            this.fld_lblLabel100.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel100, "fld_lblLabel100");
            this.fld_lblLabel100.Name = "fld_lblLabel100";
            this.fld_lblLabel100.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel100, ((bool)(resources.GetObject("fld_lblLabel100.ShowHelp"))));
            this.fld_lblLabel100.Tag = "SI";
            // 
            // fld_lblLabel101
            // 
            this.fld_lblLabel101.BOSComment = null;
            this.fld_lblLabel101.BOSDataMember = null;
            this.fld_lblLabel101.BOSDataSource = null;
            this.fld_lblLabel101.BOSDescription = null;
            this.fld_lblLabel101.BOSError = null;
            this.fld_lblLabel101.BOSFieldGroup = null;
            this.fld_lblLabel101.BOSFieldRelation = null;
            this.fld_lblLabel101.BOSPrivilege = null;
            this.fld_lblLabel101.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel101, "fld_lblLabel101");
            this.fld_lblLabel101.Name = "fld_lblLabel101";
            this.fld_lblLabel101.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel101, ((bool)(resources.GetObject("fld_lblLabel101.ShowHelp"))));
            this.fld_lblLabel101.Tag = "SI";
            // 
            // fld_txtHRATMCardManageNo
            // 
            this.fld_txtHRATMCardManageNo.BOSComment = null;
            this.fld_txtHRATMCardManageNo.BOSDataMember = "HRATMCardManageNo";
            this.fld_txtHRATMCardManageNo.BOSDataSource = "HRATMCardManages";
            this.fld_txtHRATMCardManageNo.BOSDescription = null;
            this.fld_txtHRATMCardManageNo.BOSError = null;
            this.fld_txtHRATMCardManageNo.BOSFieldGroup = null;
            this.fld_txtHRATMCardManageNo.BOSFieldRelation = null;
            this.fld_txtHRATMCardManageNo.BOSPrivilege = null;
            this.fld_txtHRATMCardManageNo.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRATMCardManageNo, "fld_txtHRATMCardManageNo");
            this.fld_txtHRATMCardManageNo.MenuManager = this.screenToolbar;
            this.fld_txtHRATMCardManageNo.Name = "fld_txtHRATMCardManageNo";
            this.fld_txtHRATMCardManageNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardManageNo, ((bool)(resources.GetObject("fld_txtHRATMCardManageNo.ShowHelp"))));
            this.fld_txtHRATMCardManageNo.Tag = "SC";
            // 
            // fld_txtHRATMCardManageName
            // 
            this.fld_txtHRATMCardManageName.BOSComment = null;
            this.fld_txtHRATMCardManageName.BOSDataMember = "HRATMCardManageName";
            this.fld_txtHRATMCardManageName.BOSDataSource = "HRATMCardManages";
            this.fld_txtHRATMCardManageName.BOSDescription = null;
            this.fld_txtHRATMCardManageName.BOSError = null;
            this.fld_txtHRATMCardManageName.BOSFieldGroup = null;
            this.fld_txtHRATMCardManageName.BOSFieldRelation = null;
            this.fld_txtHRATMCardManageName.BOSPrivilege = null;
            this.fld_txtHRATMCardManageName.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRATMCardManageName, "fld_txtHRATMCardManageName");
            this.fld_txtHRATMCardManageName.MenuManager = this.screenToolbar;
            this.fld_txtHRATMCardManageName.Name = "fld_txtHRATMCardManageName";
            this.fld_txtHRATMCardManageName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardManageName, ((bool)(resources.GetObject("fld_txtHRATMCardManageName.ShowHelp"))));
            this.fld_txtHRATMCardManageName.Tag = "SC";
            // 
            // SMATMCM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_dgcHRATMCardManages);
            this.Controls.Add(this.fld_txtHRATMCardManageNo);
            this.Controls.Add(this.fld_lblLabel101);
            this.Controls.Add(this.fld_lblLabel100);
            this.Controls.Add(this.fld_txtHRATMCardManageName);
            this.Name = "SMATMCM100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_txtHRATMCardManageName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel100, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel101, 0);
            this.Controls.SetChildIndex(this.fld_txtHRATMCardManageNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRATMCardManages, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardManages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRATMCardManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardManageName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel100;
        private BOSComponent.BOSLabel fld_lblLabel101;
        private BOSComponent.BOSTextBox fld_txtHRATMCardManageNo;
        private BOSComponent.BOSTextBox fld_txtHRATMCardManageName;
	}
}
