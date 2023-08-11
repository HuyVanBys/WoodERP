using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmloyeePayRollFormula.UI
{
	/// <summary>
	/// Summary description for SMEPRF100
	/// </summary>
	partial class SMEPRF100
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
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAllowanceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRAllowanceFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRAllowanceToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcHREmployeePayrollFormulas = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayrollFormulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(28, 26);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel2.TabIndex = 66;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã công thức";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Location = new System.Drawing.Point(28, 52);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 67;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Từ ngày";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Location = new System.Drawing.Point(28, 78);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel6.TabIndex = 68;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Đến ngày";
            // 
            // fld_txtHRAllowanceNo
            // 
            this.fld_txtHRAllowanceNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAllowanceNo.BOSDataMember = "HRAllowanceNo";
            this.fld_txtHRAllowanceNo.BOSDataSource = "HRAllowances";
            this.fld_txtHRAllowanceNo.BOSDescription = null;
            this.fld_txtHRAllowanceNo.BOSError = null;
            this.fld_txtHRAllowanceNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAllowanceNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAllowanceNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAllowanceNo.BOSPropertyName = "Text";
            this.fld_txtHRAllowanceNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAllowanceNo.Location = new System.Drawing.Point(126, 23);
            this.fld_txtHRAllowanceNo.Name = "fld_txtHRAllowanceNo";
            this.fld_txtHRAllowanceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAllowanceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAllowanceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAllowanceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAllowanceNo.Screen = null;
            this.fld_txtHRAllowanceNo.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHRAllowanceNo.TabIndex = 69;
            this.fld_txtHRAllowanceNo.Tag = "DC";
            // 
            // fld_dteHRAllowanceFromDate
            // 
            this.fld_dteHRAllowanceFromDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceFromDate.BOSDataMember = "HRAllowanceFromDate";
            this.fld_dteHRAllowanceFromDate.BOSDataSource = "HRAllowances";
            this.fld_dteHRAllowanceFromDate.BOSDescription = null;
            this.fld_dteHRAllowanceFromDate.BOSError = null;
            this.fld_dteHRAllowanceFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAllowanceFromDate.EditValue = null;
            this.fld_dteHRAllowanceFromDate.Location = new System.Drawing.Point(126, 49);
            this.fld_dteHRAllowanceFromDate.Name = "fld_dteHRAllowanceFromDate";
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAllowanceFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAllowanceFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAllowanceFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAllowanceFromDate.Screen = null;
            this.fld_dteHRAllowanceFromDate.Size = new System.Drawing.Size(195, 20);
            this.fld_dteHRAllowanceFromDate.TabIndex = 70;
            this.fld_dteHRAllowanceFromDate.Tag = "DC";
            // 
            // fld_dteHRAllowanceToDate
            // 
            this.fld_dteHRAllowanceToDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceToDate.BOSDataMember = "HRAllowanceToDate";
            this.fld_dteHRAllowanceToDate.BOSDataSource = "HRAllowances";
            this.fld_dteHRAllowanceToDate.BOSDescription = null;
            this.fld_dteHRAllowanceToDate.BOSError = null;
            this.fld_dteHRAllowanceToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAllowanceToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAllowanceToDate.EditValue = null;
            this.fld_dteHRAllowanceToDate.Location = new System.Drawing.Point(126, 75);
            this.fld_dteHRAllowanceToDate.Name = "fld_dteHRAllowanceToDate";
            this.fld_dteHRAllowanceToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAllowanceToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAllowanceToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAllowanceToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAllowanceToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAllowanceToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAllowanceToDate.Screen = null;
            this.fld_dteHRAllowanceToDate.Size = new System.Drawing.Size(195, 20);
            this.fld_dteHRAllowanceToDate.TabIndex = 71;
            this.fld_dteHRAllowanceToDate.Tag = "DC";
            // 
            // fld_dgcHREmployeePayrollFormulas
            // 
            this.fld_dgcHREmployeePayrollFormulas.AllowDrop = true;
            this.fld_dgcHREmployeePayrollFormulas.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePayrollFormulas.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePayrollFormulas.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_dgcHREmployeePayrollFormulas.BOSDescription = null;
            this.fld_dgcHREmployeePayrollFormulas.BOSError = null;
            this.fld_dgcHREmployeePayrollFormulas.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePayrollFormulas.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePayrollFormulas.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeePayrollFormulas.BOSPropertyName = "Search Result";
            this.fld_dgcHREmployeePayrollFormulas.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePayrollFormulas.Location = new System.Drawing.Point(28, 115);
            this.fld_dgcHREmployeePayrollFormulas.MainView = this.fld_dgvHRAllowances;
            this.fld_dgcHREmployeePayrollFormulas.Name = "fld_dgcHREmployeePayrollFormulas";
            this.fld_dgcHREmployeePayrollFormulas.Screen = null;
            this.fld_dgcHREmployeePayrollFormulas.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHREmployeePayrollFormulas.TabIndex = 72;
            this.fld_dgcHREmployeePayrollFormulas.Tag = "SR";
            this.fld_dgcHREmployeePayrollFormulas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRAllowances});
            // 
            // fld_dgvHRAllowances
            // 
            this.fld_dgvHRAllowances.GridControl = this.fld_dgcHREmployeePayrollFormulas;
            this.fld_dgvHRAllowances.Name = "fld_dgvHRAllowances";
            this.fld_dgvHRAllowances.PaintStyleName = "Office2003";
            // 
            // SMEPRF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHREmployeePayrollFormulas);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.fld_txtHRAllowanceNo);
            this.Controls.Add(this.fld_dteHRAllowanceFromDate);
            this.Controls.Add(this.fld_dteHRAllowanceToDate);
            this.Name = "SMEPRF100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteHRAllowanceToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteHRAllowanceFromDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRAllowanceNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployeePayrollFormulas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAllowanceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAllowanceToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayrollFormulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtHRAllowanceNo;
        private BOSComponent.BOSDateEdit fld_dteHRAllowanceFromDate;
        private BOSComponent.BOSDateEdit fld_dteHRAllowanceToDate;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHREmployeePayrollFormulas;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRAllowances;
	}
}
