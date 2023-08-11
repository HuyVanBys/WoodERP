using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SalaryEvaluation.UI
{
    /// <summary>
    /// Summary description for SMHRSE100
    /// </summary>
    partial class SMHRSE100
    {
		private BOSSearchResultsGridControl fld_dgcHRSalaryEvaluations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRDepartment;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMHRSE100));
            this.fld_dgcHRSalaryEvaluations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel100 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel101 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRSalaryEvaluationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRSalaryEvaluationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchHRSalaryEvaluationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchHRSalaryEvaluationToDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSalaryEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRSalaryEvaluations
            // 
            this.fld_dgcHRSalaryEvaluations.AllowDrop = true;
            this.fld_dgcHRSalaryEvaluations.BOSComment = "";
            this.fld_dgcHRSalaryEvaluations.BOSDataMember = "";
            this.fld_dgcHRSalaryEvaluations.BOSDataSource = "HRSalaryEvaluations";
            this.fld_dgcHRSalaryEvaluations.BOSDescription = null;
            this.fld_dgcHRSalaryEvaluations.BOSError = null;
            this.fld_dgcHRSalaryEvaluations.BOSFieldGroup = "";
            this.fld_dgcHRSalaryEvaluations.BOSFieldRelation = "";
            this.fld_dgcHRSalaryEvaluations.BOSGridType = null;
            this.fld_dgcHRSalaryEvaluations.BOSPrivilege = "";
            this.fld_dgcHRSalaryEvaluations.BOSPropertyName = "";
            this.fld_dgcHRSalaryEvaluations.CommodityType = "";
            resources.ApplyResources(this.fld_dgcHRSalaryEvaluations, "fld_dgcHRSalaryEvaluations");
            this.fld_dgcHRSalaryEvaluations.MainView = this.fld_dgvHRDepartment;
            this.fld_dgcHRSalaryEvaluations.Name = "fld_dgcHRSalaryEvaluations";
            this.fld_dgcHRSalaryEvaluations.PrintReport = false;
            this.fld_dgcHRSalaryEvaluations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHRSalaryEvaluations, ((bool)(resources.GetObject("fld_dgcHRSalaryEvaluations.ShowHelp"))));
            this.fld_dgcHRSalaryEvaluations.Tag = "SR";
            this.fld_dgcHRSalaryEvaluations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRDepartment});
            // 
            // fld_dgvHRDepartment
            // 
            this.fld_dgvHRDepartment.GridControl = this.fld_dgcHRSalaryEvaluations;
            this.fld_dgvHRDepartment.Name = "fld_dgvHRDepartment";
            this.fld_dgvHRDepartment.PaintStyleName = "Office2003";
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
            // fld_txtHRSalaryEvaluationNo
            // 
            this.fld_txtHRSalaryEvaluationNo.BOSComment = null;
            this.fld_txtHRSalaryEvaluationNo.BOSDataMember = "HRSalaryEvaluationNo";
            this.fld_txtHRSalaryEvaluationNo.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationNo.BOSDescription = null;
            this.fld_txtHRSalaryEvaluationNo.BOSError = null;
            this.fld_txtHRSalaryEvaluationNo.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationNo.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationNo.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationNo.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationNo, "fld_txtHRSalaryEvaluationNo");
            this.fld_txtHRSalaryEvaluationNo.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationNo.Name = "fld_txtHRSalaryEvaluationNo";
            this.fld_txtHRSalaryEvaluationNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRSalaryEvaluationNo, ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationNo.ShowHelp"))));
            this.fld_txtHRSalaryEvaluationNo.Tag = "SC";
            // 
            // fld_txtHRSalaryEvaluationName
            // 
            this.fld_txtHRSalaryEvaluationName.BOSComment = null;
            this.fld_txtHRSalaryEvaluationName.BOSDataMember = "HRSalaryEvaluationName";
            this.fld_txtHRSalaryEvaluationName.BOSDataSource = "HRSalaryEvaluations";
            this.fld_txtHRSalaryEvaluationName.BOSDescription = "";
            this.fld_txtHRSalaryEvaluationName.BOSError = null;
            this.fld_txtHRSalaryEvaluationName.BOSFieldGroup = null;
            this.fld_txtHRSalaryEvaluationName.BOSFieldRelation = null;
            this.fld_txtHRSalaryEvaluationName.BOSPrivilege = null;
            this.fld_txtHRSalaryEvaluationName.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtHRSalaryEvaluationName, "fld_txtHRSalaryEvaluationName");
            this.fld_txtHRSalaryEvaluationName.MenuManager = this.screenToolbar;
            this.fld_txtHRSalaryEvaluationName.Name = "fld_txtHRSalaryEvaluationName";
            this.fld_txtHRSalaryEvaluationName.Properties.NullText = resources.GetString("fld_txtHRDepartmentName.Properties.NullText");
            this.fld_txtHRSalaryEvaluationName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHRSalaryEvaluationName, ((bool)(resources.GetObject("fld_txtHRSalaryEvaluationName.ShowHelp"))));
            this.fld_txtHRSalaryEvaluationName.Tag = "SC";
            // 
            // fld_dteSearchHRSalaryEvaluationFromDate
            // 
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSComment = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSDataMember = "HRSalaryEvaluationFromDate";
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSDataSource = "HRSalaryEvaluations";
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSDescription = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSError = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSFieldGroup = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSFieldRelation = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSPrivilege = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteSearchHRSalaryEvaluationFromDate, "fld_dteSearchHRSalaryEvaluationFromDate");
            this.fld_dteSearchHRSalaryEvaluationFromDate.Name = "fld_dteSearchHRSalaryEvaluationFromDate";
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteHRKPIRegistrationDate.Properties.Buttons"))))});
            this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRSalaryEvaluationFromDate.Screen = null;
            this.fld_dteSearchHRSalaryEvaluationFromDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel26, "fld_lblLabel26");
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel17, "fld_lblLabel17");
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Tag = "SI";
            // 
            // fld_dteSearchHRSalaryEvaluationToDate
            // 
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSComment = "";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSDataMember = "HRSalaryEvaluationToDate";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSDataSource = "HRSalaryEvaluations";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSDescription = null;
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSError = null;
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSFieldGroup = "";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSFieldRelation = "";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSPrivilege = "";
            this.fld_dteSearchHRSalaryEvaluationToDate.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_dteSearchHRSalaryEvaluationToDate, "fld_dteSearchHRSalaryEvaluationToDate");
            this.fld_dteSearchHRSalaryEvaluationToDate.Name = "fld_dteSearchHRSalaryEvaluationToDate";
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchKPIFormToDate.Properties.Buttons"))))});
            this.fld_dteSearchHRSalaryEvaluationToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRSalaryEvaluationToDate.Screen = null;
            this.fld_dteSearchHRSalaryEvaluationToDate.Tag = "SC";
            // 
            // SMHRSE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchHRSalaryEvaluationToDate);
            this.Controls.Add(this.fld_dteSearchHRSalaryEvaluationFromDate);
            this.Controls.Add(this.fld_lblLabel26);
            this.Controls.Add(this.fld_dgcHRSalaryEvaluations);
            this.Controls.Add(this.fld_txtHRSalaryEvaluationNo);
            this.Controls.Add(this.fld_lblLabel101);
            this.Controls.Add(this.fld_lblLabel100);
            this.Controls.Add(this.fld_txtHRSalaryEvaluationName);
            this.Name = "SMHRSE100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_txtHRSalaryEvaluationName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel100, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel101, 0);
            this.Controls.SetChildIndex(this.fld_txtHRSalaryEvaluationNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRSalaryEvaluations, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel26, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchHRSalaryEvaluationFromDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchHRSalaryEvaluationToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSalaryEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSalaryEvaluationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRSalaryEvaluationToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel100;
        private BOSComponent.BOSLabel fld_lblLabel101;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationNo;
        private BOSComponent.BOSTextBox fld_txtHRSalaryEvaluationName;
        private BOSComponent.BOSDateEdit fld_dteSearchHRSalaryEvaluationFromDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchHRSalaryEvaluationToDate;
    }
}
