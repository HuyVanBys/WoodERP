using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeeSchedule.UI
{
	/// <summary>
	/// Summary description for SMES100
	/// </summary>
	partial class SMES100
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
            this.fld_dgcHRSchedules = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRScheduleNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRScheduleName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRScheduleDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRSchedules
            // 
            this.fld_dgcHRSchedules.AllowDrop = true;
            this.fld_dgcHRSchedules.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRSchedules.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRSchedules.BOSDataSource = "HRSchedules";
            this.fld_dgcHRSchedules.BOSDescription = null;
            this.fld_dgcHRSchedules.BOSError = null;
            this.fld_dgcHRSchedules.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRSchedules.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRSchedules.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRSchedules.BOSPropertyName = "Search Result";
            this.fld_dgcHRSchedules.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRSchedules.Location = new System.Drawing.Point(63, 168);
            this.fld_dgcHRSchedules.MainView = this.fld_dgvHRAllowances;
            this.fld_dgcHRSchedules.Name = "fld_dgcHRSchedules";
            this.fld_dgcHRSchedules.Screen = null;
            this.fld_dgcHRSchedules.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRSchedules.TabIndex = 79;
            this.fld_dgcHRSchedules.Tag = "SR";
            this.fld_dgcHRSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRAllowances});
            // 
            // fld_dgvHRAllowances
            // 
            this.fld_dgvHRAllowances.GridControl = this.fld_dgcHRSchedules;
            this.fld_dgvHRAllowances.Name = "fld_dgvHRAllowances";
            this.fld_dgvHRAllowances.PaintStyleName = "Office2003";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(12, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel2.TabIndex = 73;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã lịch làm việc";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(12, 71);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel5.TabIndex = 74;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Người tạo";
            // 
            // fld_txtHRScheduleNo
            // 
            this.fld_txtHRScheduleNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSDataMember = "HRScheduleNo";
            this.fld_txtHRScheduleNo.BOSDataSource = "HRSchedules";
            this.fld_txtHRScheduleNo.BOSDescription = null;
            this.fld_txtHRScheduleNo.BOSError = null;
            this.fld_txtHRScheduleNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSPropertyName = "Text";
            this.fld_txtHRScheduleNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRScheduleNo.Location = new System.Drawing.Point(110, 9);
            this.fld_txtHRScheduleNo.Name = "fld_txtHRScheduleNo";
            this.fld_txtHRScheduleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRScheduleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRScheduleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRScheduleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRScheduleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRScheduleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRScheduleNo.Screen = null;
            this.fld_txtHRScheduleNo.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHRScheduleNo.TabIndex = 76;
            this.fld_txtHRScheduleNo.Tag = "SC";
            // 
            // fld_lkeHREmployeeID
            // 
            this.fld_lkeHREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID.BOSAllowDummy = false;
            this.fld_lkeHREmployeeID.BOSComment = null;
            this.fld_lkeHREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeHREmployeeID.BOSDataSource = "HRSchedules";
            this.fld_lkeHREmployeeID.BOSDescription = null;
            this.fld_lkeHREmployeeID.BOSError = null;
            this.fld_lkeHREmployeeID.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID.BOSFieldParent = null;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(110, 68);
            this.fld_lkeHREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(195, 20);
            this.fld_lkeHREmployeeID.TabIndex = 80;
            this.fld_lkeHREmployeeID.Tag = "SC";
            // 
            // fld_txtHRScheduleName
            // 
            this.fld_txtHRScheduleName.BOSComment = null;
            this.fld_txtHRScheduleName.BOSDataMember = "HRScheduleName";
            this.fld_txtHRScheduleName.BOSDataSource = "HRSchedules";
            this.fld_txtHRScheduleName.BOSDescription = null;
            this.fld_txtHRScheduleName.BOSError = null;
            this.fld_txtHRScheduleName.BOSFieldGroup = null;
            this.fld_txtHRScheduleName.BOSFieldRelation = null;
            this.fld_txtHRScheduleName.BOSPrivilege = null;
            this.fld_txtHRScheduleName.BOSPropertyName = "Text";
            this.fld_txtHRScheduleName.Location = new System.Drawing.Point(110, 40);
            this.fld_txtHRScheduleName.MenuManager = this.screenToolbar;
            this.fld_txtHRScheduleName.Name = "fld_txtHRScheduleName";
            this.fld_txtHRScheduleName.Screen = null;
            this.fld_txtHRScheduleName.Size = new System.Drawing.Size(195, 20);
            this.fld_txtHRScheduleName.TabIndex = 82;
            this.fld_txtHRScheduleName.Tag = "SC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 43);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(77, 13);
            this.bosLabel8.TabIndex = 81;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Tên lịch làm việc";
            // 
            // fld_dteHRScheduleDate
            // 
            this.fld_dteHRScheduleDate.BOSComment = null;
            this.fld_dteHRScheduleDate.BOSDataMember = "HRScheduleDate";
            this.fld_dteHRScheduleDate.BOSDataSource = "HRSchedules";
            this.fld_dteHRScheduleDate.BOSDescription = null;
            this.fld_dteHRScheduleDate.BOSError = null;
            this.fld_dteHRScheduleDate.BOSFieldGroup = null;
            this.fld_dteHRScheduleDate.BOSFieldRelation = null;
            this.fld_dteHRScheduleDate.BOSPrivilege = null;
            this.fld_dteHRScheduleDate.BOSPropertyName = null;
            this.fld_dteHRScheduleDate.EditValue = null;
            this.fld_dteHRScheduleDate.Location = new System.Drawing.Point(110, 96);
            this.fld_dteHRScheduleDate.Name = "fld_dteHRScheduleDate";
            this.fld_dteHRScheduleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRScheduleDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRScheduleDate.Screen = null;
            this.fld_dteHRScheduleDate.Size = new System.Drawing.Size(195, 20);
            this.fld_dteHRScheduleDate.TabIndex = 84;
            this.fld_dteHRScheduleDate.Tag = "SC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(12, 99);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(44, 13);
            this.bosLabel10.TabIndex = 83;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Ngày tạo";
            // 
            // SMES100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(546, 380);
            this.Controls.Add(this.fld_dteHRScheduleDate);
            this.Controls.Add(this.bosLabel10);
            this.Controls.Add(this.fld_txtHRScheduleName);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_lkeHREmployeeID);
            this.Controls.Add(this.fld_dgcHRSchedules);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtHRScheduleNo);
            this.Name = "SMES100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRScheduleNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRSchedules, 0);
            this.Controls.SetChildIndex(this.fld_lkeHREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_txtHRScheduleName, 0);
            this.Controls.SetChildIndex(this.bosLabel10, 0);
            this.Controls.SetChildIndex(this.fld_dteHRScheduleDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcHRSchedules;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRAllowances;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtHRScheduleNo;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID;
        private BOSComponent.BOSTextBox fld_txtHRScheduleName;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSDateEdit fld_dteHRScheduleDate;
        private BOSComponent.BOSLabel bosLabel10;
	}
}
