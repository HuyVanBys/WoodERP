using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREmployeeWorkSchedule.UI
{
	/// <summary>
	/// Summary description for SMEWS100
	/// </summary>
	partial class SMEWS100
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
            this.fld_dgcHREmployeeWorkSchedules = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARProspectCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtHREmployeeWorkScheduleNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeeWorkScheduleDesc = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeeCardNumber = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeWorkSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProspectCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHREmployeeWorkSchedules
            // 
            this.fld_dgcHREmployeeWorkSchedules.AllowDrop = true;
            this.fld_dgcHREmployeeWorkSchedules.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeeWorkSchedules.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeeWorkSchedules.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_dgcHREmployeeWorkSchedules.BOSDescription = null;
            this.fld_dgcHREmployeeWorkSchedules.BOSError = null;
            this.fld_dgcHREmployeeWorkSchedules.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeeWorkSchedules.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeeWorkSchedules.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHREmployeeWorkSchedules.BOSPropertyName = null;
            this.fld_dgcHREmployeeWorkSchedules.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeWorkSchedules.Location = new System.Drawing.Point(183, 230);
            this.fld_dgcHREmployeeWorkSchedules.MainView = this.fld_dgvARProspectCustomer;
            this.fld_dgcHREmployeeWorkSchedules.Name = "fld_dgcHREmployeeWorkSchedules";
            this.fld_dgcHREmployeeWorkSchedules.Screen = null;
            this.fld_dgcHREmployeeWorkSchedules.Size = new System.Drawing.Size(426, 309);
            this.fld_dgcHREmployeeWorkSchedules.TabIndex = 13;
            this.fld_dgcHREmployeeWorkSchedules.Tag = "SR";
            this.fld_dgcHREmployeeWorkSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARProspectCustomer});
            // 
            // fld_dgvARProspectCustomer
            // 
            this.fld_dgvARProspectCustomer.GridControl = this.fld_dgcHREmployeeWorkSchedules;
            this.fld_dgvARProspectCustomer.Name = "fld_dgvARProspectCustomer";
            this.fld_dgvARProspectCustomer.PaintStyleName = "Office2003";
            // 
            // fld_txtHREmployeeWorkScheduleNo
            // 
            this.fld_txtHREmployeeWorkScheduleNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleNo.BOSDataMember = "HREmployeeWorkScheduleNo";
            this.fld_txtHREmployeeWorkScheduleNo.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_txtHREmployeeWorkScheduleNo.BOSDescription = null;
            this.fld_txtHREmployeeWorkScheduleNo.BOSError = null;
            this.fld_txtHREmployeeWorkScheduleNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeeWorkScheduleNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleNo.Location = new System.Drawing.Point(140, 46);
            this.fld_txtHREmployeeWorkScheduleNo.Name = "fld_txtHREmployeeWorkScheduleNo";
            this.fld_txtHREmployeeWorkScheduleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeWorkScheduleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeWorkScheduleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeWorkScheduleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeWorkScheduleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeWorkScheduleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeWorkScheduleNo.Screen = null;
            this.fld_txtHREmployeeWorkScheduleNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeWorkScheduleNo.TabIndex = 14;
            this.fld_txtHREmployeeWorkScheduleNo.Tag = "SC";
            // 
            // fld_txtHREmployeeWorkScheduleDesc
            // 
            this.fld_txtHREmployeeWorkScheduleDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSDataMember = "HREmployeeWorkScheduleDesc";
            this.fld_txtHREmployeeWorkScheduleDesc.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_txtHREmployeeWorkScheduleDesc.BOSDescription = null;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSError = null;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleDesc.BOSPropertyName = "Text";
            this.fld_txtHREmployeeWorkScheduleDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeWorkScheduleDesc.Location = new System.Drawing.Point(140, 70);
            this.fld_txtHREmployeeWorkScheduleDesc.Name = "fld_txtHREmployeeWorkScheduleDesc";
            this.fld_txtHREmployeeWorkScheduleDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeWorkScheduleDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeWorkScheduleDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeWorkScheduleDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeWorkScheduleDesc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeWorkScheduleDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeWorkScheduleDesc.Screen = null;
            this.fld_txtHREmployeeWorkScheduleDesc.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeWorkScheduleDesc.TabIndex = 15;
            this.fld_txtHREmployeeWorkScheduleDesc.Tag = "SC";
            // 
            // fld_dteSearchFromHREmployeeWorkScheduleDateFrom
            // 
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSDataMember = "HREmployeeWorkScheduleDateFrom";
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSDescription = null;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSError = null;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.EditValue = null;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Location = new System.Drawing.Point(140, 122);
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Name = "fld_dteSearchFromHREmployeeWorkScheduleDateFrom";
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Screen = null;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.TabIndex = 16;
            this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Tag = "SC";
            // 
            // fld_dteSearchToHREmployeeWorkScheduleDateTo
            // 
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSDataMember = "HREmployeeWorkScheduleDateTo";
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSDescription = null;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSError = null;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.EditValue = null;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Location = new System.Drawing.Point(140, 148);
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Name = "fld_dteSearchToHREmployeeWorkScheduleDateTo";
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Screen = null;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.TabIndex = 17;
            this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 49);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel.TabIndex = 18;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã danh sách";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(37, 73);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel1.TabIndex = 19;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Nội dung";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(37, 125);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 20;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(37, 151);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 21;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(37, 99);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 19;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã ID";
            // 
            // fld_txtHREmployeeCardNumber
            // 
            this.fld_txtHREmployeeCardNumber.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeCardNumber.BOSDataMember = "HREmployeeCardNumber";
            this.fld_txtHREmployeeCardNumber.BOSDataSource = "HREmployeeWorkSchedules";
            this.fld_txtHREmployeeCardNumber.BOSDescription = null;
            this.fld_txtHREmployeeCardNumber.BOSError = null;
            this.fld_txtHREmployeeCardNumber.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeCardNumber.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeCardNumber.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeCardNumber.BOSPropertyName = "Text";
            this.fld_txtHREmployeeCardNumber.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeeCardNumber.Location = new System.Drawing.Point(140, 96);
            this.fld_txtHREmployeeCardNumber.Name = "fld_txtHREmployeeCardNumber";
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeeCardNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeeCardNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeeCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeeCardNumber.Screen = null;
            this.fld_txtHREmployeeCardNumber.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREmployeeCardNumber.TabIndex = 15;
            this.fld_txtHREmployeeCardNumber.Tag = "SC";
            // 
            // SMEWS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_txtHREmployeeWorkScheduleNo);
            this.Controls.Add(this.fld_txtHREmployeeCardNumber);
            this.Controls.Add(this.fld_txtHREmployeeWorkScheduleDesc);
            this.Controls.Add(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom);
            this.Controls.Add(this.fld_dteSearchToHREmployeeWorkScheduleDateTo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcHREmployeeWorkSchedules);
            this.Name = "SMEWS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHREmployeeWorkSchedules, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHREmployeeWorkScheduleDateTo, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeWorkScheduleDesc, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeCardNumber, 0);
            this.Controls.SetChildIndex(this.fld_txtHREmployeeWorkScheduleNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeWorkSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARProspectCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeWorkScheduleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHREmployeeWorkScheduleDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHREmployeeWorkScheduleDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeeCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcHREmployeeWorkSchedules;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARProspectCustomer;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtHREmployeeWorkScheduleNo;
        private BOSComponent.BOSTextBox fld_txtHREmployeeWorkScheduleDesc;
        private BOSComponent.BOSDateEdit fld_dteSearchFromHREmployeeWorkScheduleDateFrom;
        private BOSComponent.BOSDateEdit fld_dteSearchToHREmployeeWorkScheduleDateTo;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtHREmployeeCardNumber;
	}
}
