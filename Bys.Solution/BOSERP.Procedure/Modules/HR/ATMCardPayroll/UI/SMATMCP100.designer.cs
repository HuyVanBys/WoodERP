using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ATMCardPayroll.UI
{
    /// <summary>
    /// Summary description for SMATMCM100
    /// </summary>
    partial class SMATMCP100
    {
		private BOSSearchResultsGridControl fld_dgcHRATMCardPayrolls;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRATMCardPayroll;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMATMCP100));
            this.fld_dgcHRATMCardPayrolls = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRATMCardPayroll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel100 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel101 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRATMCardPayrollNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRATMCardPayrollName = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRATMCardPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRATMCardPayrolls
            // 
            this.fld_dgcHRATMCardPayrolls.AllowDrop = true;
            this.fld_dgcHRATMCardPayrolls.BOSComment = "";
            this.fld_dgcHRATMCardPayrolls.BOSDataMember = "";
            this.fld_dgcHRATMCardPayrolls.BOSDataSource = "HRATMCardPayrolls";
            this.fld_dgcHRATMCardPayrolls.BOSDescription = null;
            this.fld_dgcHRATMCardPayrolls.BOSError = null;
            this.fld_dgcHRATMCardPayrolls.BOSFieldGroup = "";
            this.fld_dgcHRATMCardPayrolls.BOSFieldRelation = "";
            this.fld_dgcHRATMCardPayrolls.BOSGridType = null;
            this.fld_dgcHRATMCardPayrolls.BOSPrivilege = "";
            this.fld_dgcHRATMCardPayrolls.BOSPropertyName = "";
            this.fld_dgcHRATMCardPayrolls.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRATMCardPayrolls, "fld_dgcHRATMCardPayrolls");
            this.fld_dgcHRATMCardPayrolls.MainView = this.fld_dgvHRATMCardPayroll;
            this.fld_dgcHRATMCardPayrolls.Name = "fld_dgcHRATMCardPayrolls";
            this.fld_dgcHRATMCardPayrolls.PrintReport = false;
            this.fld_dgcHRATMCardPayrolls.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRATMCardPayrolls, ((bool)(resources.GetObject("fld_dgcHRATMCardPayrolls.ShowHelp"))));
            this.fld_dgcHRATMCardPayrolls.Tag = "SR";
            this.fld_dgcHRATMCardPayrolls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRATMCardPayroll});
            // 
            // fld_dgvHRATMCardPayroll
            // 
            this.fld_dgvHRATMCardPayroll.GridControl = this.fld_dgcHRATMCardPayrolls;
            this.fld_dgvHRATMCardPayroll.Name = "fld_dgvHRATMCardPayroll";
            this.fld_dgvHRATMCardPayroll.PaintStyleName = "Office2003";
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
            // fld_txtHRATMCardPayrollNo
            // 
            this.fld_txtHRATMCardPayrollNo.BOSComment = null;
            this.fld_txtHRATMCardPayrollNo.BOSDataMember = "HRATMCardPayrollNo";
            this.fld_txtHRATMCardPayrollNo.BOSDataSource = "HRATMCardPayrolls";
            this.fld_txtHRATMCardPayrollNo.BOSDescription = null;
            this.fld_txtHRATMCardPayrollNo.BOSError = null;
            this.fld_txtHRATMCardPayrollNo.BOSFieldGroup = null;
            this.fld_txtHRATMCardPayrollNo.BOSFieldRelation = null;
            this.fld_txtHRATMCardPayrollNo.BOSPrivilege = null;
            this.fld_txtHRATMCardPayrollNo.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRATMCardPayrollNo, "fld_txtHRATMCardPayrollNo");
            this.fld_txtHRATMCardPayrollNo.MenuManager = this.screenToolbar;
            this.fld_txtHRATMCardPayrollNo.Name = "fld_txtHRATMCardPayrollNo";
            this.fld_txtHRATMCardPayrollNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardPayrollNo, ((bool)(resources.GetObject("fld_txtHRATMCardPayrollNo.ShowHelp"))));
            this.fld_txtHRATMCardPayrollNo.Tag = "SC";
            // 
            // fld_txtHRATMCardPayrollName
            // 
            this.fld_txtHRATMCardPayrollName.BOSComment = null;
            this.fld_txtHRATMCardPayrollName.BOSDataMember = "HRATMCardPayrollName";
            this.fld_txtHRATMCardPayrollName.BOSDataSource = "HRATMCardPayrolls";
            this.fld_txtHRATMCardPayrollName.BOSDescription = null;
            this.fld_txtHRATMCardPayrollName.BOSError = null;
            this.fld_txtHRATMCardPayrollName.BOSFieldGroup = null;
            this.fld_txtHRATMCardPayrollName.BOSFieldRelation = null;
            this.fld_txtHRATMCardPayrollName.BOSPrivilege = null;
            this.fld_txtHRATMCardPayrollName.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRATMCardPayrollName, "fld_txtHRATMCardPayrollName");
            this.fld_txtHRATMCardPayrollName.MenuManager = this.screenToolbar;
            this.fld_txtHRATMCardPayrollName.Name = "fld_txtHRATMCardPayrollName";
            this.fld_txtHRATMCardPayrollName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRATMCardPayrollName, ((bool)(resources.GetObject("fld_txtHRATMCardPayrollName.ShowHelp"))));
            this.fld_txtHRATMCardPayrollName.Tag = "SC";
            // 
            // SMATMCP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_dgcHRATMCardPayrolls);
            this.Controls.Add(this.fld_txtHRATMCardPayrollNo);
            this.Controls.Add(this.fld_lblLabel101);
            this.Controls.Add(this.fld_lblLabel100);
            this.Controls.Add(this.fld_txtHRATMCardPayrollName);
            this.Name = "SMATMCP100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_txtHRATMCardPayrollName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel100, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel101, 0);
            this.Controls.SetChildIndex(this.fld_txtHRATMCardPayrollNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRATMCardPayrolls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRATMCardPayrolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRATMCardPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRATMCardPayrollName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel100;
        private BOSComponent.BOSLabel fld_lblLabel101;
        private BOSComponent.BOSTextBox fld_txtHRATMCardPayrollNo;
        private BOSComponent.BOSTextBox fld_txtHRATMCardPayrollName;
	}
}
