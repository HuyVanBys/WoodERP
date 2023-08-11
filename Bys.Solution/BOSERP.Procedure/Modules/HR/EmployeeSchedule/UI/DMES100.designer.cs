using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeeSchedule.UI
{
	/// <summary>
	/// Summary description for DMES100
	/// </summary>
	partial class DMES100
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
            this.fld_grcMainObject = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dteHRScheduleToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRScheduleFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_medHRScheduleDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtHRScheduleName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRScheduleNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteHRScheduleDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnImportFromExcel = new BOSComponent.BOSButton(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtChooseFile = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcEmployeeScheduelList = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeSchedules = new BOSERP.Modules.EmployeeSchedule.EmployeeScheduleGridControl();
            this.RLKEWorkingShift = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_btnChooseFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditinExcel = new BOSComponent.BOSButton(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcMainObject)).BeginInit();
            this.fld_grcMainObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRScheduleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtChooseFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcEmployeeScheduelList)).BeginInit();
            this.fld_grcEmployeeScheduelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcMainObject
            // 
            this.fld_grcMainObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcMainObject.BOSComment = null;
            this.fld_grcMainObject.BOSDataMember = null;
            this.fld_grcMainObject.BOSDataSource = null;
            this.fld_grcMainObject.BOSDescription = null;
            this.fld_grcMainObject.BOSError = null;
            this.fld_grcMainObject.BOSFieldGroup = null;
            this.fld_grcMainObject.BOSFieldRelation = null;
            this.fld_grcMainObject.BOSPrivilege = null;
            this.fld_grcMainObject.BOSPropertyName = null;
            this.fld_grcMainObject.Controls.Add(this.fld_dteHRScheduleToDate);
            this.fld_grcMainObject.Controls.Add(this.fld_dteHRScheduleFromDate);
            this.fld_grcMainObject.Controls.Add(this.bosLabel5);
            this.fld_grcMainObject.Controls.Add(this.bosLabel4);
            this.fld_grcMainObject.Controls.Add(this.fld_medHRScheduleDesc);
            this.fld_grcMainObject.Controls.Add(this.fld_txtHRScheduleName);
            this.fld_grcMainObject.Controls.Add(this.fld_txtHRScheduleNo);
            this.fld_grcMainObject.Controls.Add(this.bosLabel9);
            this.fld_grcMainObject.Controls.Add(this.bosLabel8);
            this.fld_grcMainObject.Controls.Add(this.bosLabel7);
            this.fld_grcMainObject.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcMainObject.Controls.Add(this.fld_dteHRScheduleDate);
            this.fld_grcMainObject.Controls.Add(this.bosLabel11);
            this.fld_grcMainObject.Controls.Add(this.bosLabel10);
            this.fld_grcMainObject.Location = new System.Drawing.Point(5, 5);
            this.fld_grcMainObject.Name = "fld_grcMainObject";
            this.fld_grcMainObject.Screen = null;
            this.fld_grcMainObject.Size = new System.Drawing.Size(998, 178);
            this.fld_grcMainObject.TabIndex = 12;
            this.fld_grcMainObject.Tag = "DC";
            this.fld_grcMainObject.Text = "Thông Tin";
            // 
            // fld_dteHRScheduleToDate
            // 
            this.fld_dteHRScheduleToDate.BOSComment = null;
            this.fld_dteHRScheduleToDate.BOSDataMember = "HRScheduleToDate";
            this.fld_dteHRScheduleToDate.BOSDataSource = "HRSchedules";
            this.fld_dteHRScheduleToDate.BOSDescription = null;
            this.fld_dteHRScheduleToDate.BOSError = null;
            this.fld_dteHRScheduleToDate.BOSFieldGroup = null;
            this.fld_dteHRScheduleToDate.BOSFieldRelation = null;
            this.fld_dteHRScheduleToDate.BOSPrivilege = null;
            this.fld_dteHRScheduleToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRScheduleToDate.EditValue = null;
            this.fld_dteHRScheduleToDate.Location = new System.Drawing.Point(393, 83);
            this.fld_dteHRScheduleToDate.Name = "fld_dteHRScheduleToDate";
            this.fld_dteHRScheduleToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRScheduleToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRScheduleToDate.Screen = null;
            this.fld_dteHRScheduleToDate.Size = new System.Drawing.Size(165, 20);
            this.fld_dteHRScheduleToDate.TabIndex = 67;
            this.fld_dteHRScheduleToDate.Tag = "DC";
            // 
            // fld_dteHRScheduleFromDate
            // 
            this.fld_dteHRScheduleFromDate.BOSComment = null;
            this.fld_dteHRScheduleFromDate.BOSDataMember = "HRScheduleFromDate";
            this.fld_dteHRScheduleFromDate.BOSDataSource = "HRSchedules";
            this.fld_dteHRScheduleFromDate.BOSDescription = null;
            this.fld_dteHRScheduleFromDate.BOSError = null;
            this.fld_dteHRScheduleFromDate.BOSFieldGroup = null;
            this.fld_dteHRScheduleFromDate.BOSFieldRelation = null;
            this.fld_dteHRScheduleFromDate.BOSPrivilege = null;
            this.fld_dteHRScheduleFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRScheduleFromDate.EditValue = null;
            this.fld_dteHRScheduleFromDate.Location = new System.Drawing.Point(90, 83);
            this.fld_dteHRScheduleFromDate.MenuManager = this.screenToolbar;
            this.fld_dteHRScheduleFromDate.Name = "fld_dteHRScheduleFromDate";
            this.fld_dteHRScheduleFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRScheduleFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRScheduleFromDate.Screen = null;
            this.fld_dteHRScheduleFromDate.Size = new System.Drawing.Size(165, 20);
            this.fld_dteHRScheduleFromDate.TabIndex = 66;
            this.fld_dteHRScheduleFromDate.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(301, 86);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 90;
            this.bosLabel5.Text = "Đến ngày";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(10, 86);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(40, 13);
            this.bosLabel4.TabIndex = 91;
            this.bosLabel4.Text = "Từ ngày";
            // 
            // fld_medHRScheduleDesc
            // 
            this.fld_medHRScheduleDesc.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_medHRScheduleDesc.BOSDataMember = "HRScheduleDesc";
            this.fld_medHRScheduleDesc.BOSDataSource = "HRSchedules";
            this.fld_medHRScheduleDesc.BOSDescription = null;
            this.fld_medHRScheduleDesc.BOSError = null;
            this.fld_medHRScheduleDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_medHRScheduleDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_medHRScheduleDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_medHRScheduleDesc.BOSPropertyName = "Text";
            this.fld_medHRScheduleDesc.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_medHRScheduleDesc.Location = new System.Drawing.Point(90, 112);
            this.fld_medHRScheduleDesc.Name = "fld_medHRScheduleDesc";
            this.fld_medHRScheduleDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRScheduleDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRScheduleDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRScheduleDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRScheduleDesc.Screen = null;
            this.fld_medHRScheduleDesc.Size = new System.Drawing.Size(468, 57);
            this.fld_medHRScheduleDesc.TabIndex = 68;
            this.fld_medHRScheduleDesc.Tag = "DC";
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
            this.fld_txtHRScheduleName.Location = new System.Drawing.Point(393, 27);
            this.fld_txtHRScheduleName.MenuManager = this.screenToolbar;
            this.fld_txtHRScheduleName.Name = "fld_txtHRScheduleName";
            this.fld_txtHRScheduleName.Screen = null;
            this.fld_txtHRScheduleName.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRScheduleName.TabIndex = 63;
            this.fld_txtHRScheduleName.Tag = "DC";
            // 
            // fld_txtHRScheduleNo
            // 
            this.fld_txtHRScheduleNo.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSDataMember = "HRScheduleNo";
            this.fld_txtHRScheduleNo.BOSDataSource = "HRSchedules";
            this.fld_txtHRScheduleNo.BOSDescription = null;
            this.fld_txtHRScheduleNo.BOSError = null;
            this.fld_txtHRScheduleNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRScheduleNo.BOSPropertyName = "Text";
            this.fld_txtHRScheduleNo.EditValue = global::Localization.CommonLocalizedResources.String1;
            this.fld_txtHRScheduleNo.Location = new System.Drawing.Point(90, 27);
            this.fld_txtHRScheduleNo.Name = "fld_txtHRScheduleNo";
            this.fld_txtHRScheduleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRScheduleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRScheduleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRScheduleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRScheduleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRScheduleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRScheduleNo.Screen = null;
            this.fld_txtHRScheduleNo.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRScheduleNo.TabIndex = 62;
            this.fld_txtHRScheduleNo.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(10, 58);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 6;
            this.bosLabel9.Tag = "DC";
            this.bosLabel9.Text = "Người tạo";
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
            this.bosLabel8.Location = new System.Drawing.Point(301, 30);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(77, 13);
            this.bosLabel8.TabIndex = 6;
            this.bosLabel8.Tag = "DC";
            this.bosLabel8.Text = "Tên lịch làm việc";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(10, 30);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(73, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Tag = "DC";
            this.bosLabel7.Text = "Mã lịch làm việc";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRSchedules";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(90, 55);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 64;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.EditValueChanged += new System.EventHandler(this.fld_lkeHREmployeePayrollFormulaID_EditValueChanged);
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
            this.fld_dteHRScheduleDate.BOSPropertyName = "EditValue";
            this.fld_dteHRScheduleDate.EditValue = null;
            this.fld_dteHRScheduleDate.Location = new System.Drawing.Point(393, 55);
            this.fld_dteHRScheduleDate.Name = "fld_dteHRScheduleDate";
            this.fld_dteHRScheduleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRScheduleDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRScheduleDate.Screen = null;
            this.fld_dteHRScheduleDate.Size = new System.Drawing.Size(165, 20);
            this.fld_dteHRScheduleDate.TabIndex = 65;
            this.fld_dteHRScheduleDate.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(10, 114);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 6;
            this.bosLabel11.Tag = "DC";
            this.bosLabel11.Text = "Diễn giải";
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
            this.bosLabel10.Location = new System.Drawing.Point(301, 58);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(44, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Tag = "DC";
            this.bosLabel10.Text = "Ngày tạo";
            // 
            // fld_btnImportFromExcel
            // 
            this.fld_btnImportFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnImportFromExcel.BOSComment = null;
            this.fld_btnImportFromExcel.BOSDataMember = null;
            this.fld_btnImportFromExcel.BOSDataSource = null;
            this.fld_btnImportFromExcel.BOSDescription = null;
            this.fld_btnImportFromExcel.BOSError = null;
            this.fld_btnImportFromExcel.BOSFieldGroup = null;
            this.fld_btnImportFromExcel.BOSFieldRelation = null;
            this.fld_btnImportFromExcel.BOSPrivilege = null;
            this.fld_btnImportFromExcel.BOSPropertyName = null;
            this.fld_btnImportFromExcel.Location = new System.Drawing.Point(514, 558);
            this.fld_btnImportFromExcel.Name = "fld_btnImportFromExcel";
            this.fld_btnImportFromExcel.Screen = null;
            this.fld_btnImportFromExcel.Size = new System.Drawing.Size(114, 27);
            this.fld_btnImportFromExcel.TabIndex = 10;
            this.fld_btnImportFromExcel.Tag = "DC";
            this.fld_btnImportFromExcel.Text = "Import Từ Excel";
            this.fld_btnImportFromExcel.Click += new System.EventHandler(this.fld_btnImportFromExcel_Click);
            // 
            // bosLabel12
            // 
            this.bosLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(10, 565);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(48, 13);
            this.bosLabel12.TabIndex = 14;
            this.bosLabel12.Text = "Chọn File:";
            // 
            // fld_txtChooseFile
            // 
            this.fld_txtChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_txtChooseFile.BOSComment = null;
            this.fld_txtChooseFile.BOSDataMember = null;
            this.fld_txtChooseFile.BOSDataSource = null;
            this.fld_txtChooseFile.BOSDescription = null;
            this.fld_txtChooseFile.BOSError = null;
            this.fld_txtChooseFile.BOSFieldGroup = null;
            this.fld_txtChooseFile.BOSFieldRelation = null;
            this.fld_txtChooseFile.BOSPrivilege = null;
            this.fld_txtChooseFile.BOSPropertyName = null;
            this.fld_txtChooseFile.Location = new System.Drawing.Point(64, 562);
            this.fld_txtChooseFile.MenuManager = this.screenToolbar;
            this.fld_txtChooseFile.Name = "fld_txtChooseFile";
            this.fld_txtChooseFile.Screen = null;
            this.fld_txtChooseFile.Size = new System.Drawing.Size(424, 20);
            this.fld_txtChooseFile.TabIndex = 15;
            this.fld_txtChooseFile.EditValueChanged += new System.EventHandler(this.fld_txtChooseFile_EditValueChanged);
            this.fld_txtChooseFile.Click += new System.EventHandler(this.fld_txtChooseFile_Click);
            // 
            // fld_grcEmployeeScheduelList
            // 
            this.fld_grcEmployeeScheduelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcEmployeeScheduelList.BOSComment = null;
            this.fld_grcEmployeeScheduelList.BOSDataMember = null;
            this.fld_grcEmployeeScheduelList.BOSDataSource = null;
            this.fld_grcEmployeeScheduelList.BOSDescription = null;
            this.fld_grcEmployeeScheduelList.BOSError = null;
            this.fld_grcEmployeeScheduelList.BOSFieldGroup = null;
            this.fld_grcEmployeeScheduelList.BOSFieldRelation = null;
            this.fld_grcEmployeeScheduelList.BOSPrivilege = null;
            this.fld_grcEmployeeScheduelList.BOSPropertyName = null;
            this.fld_grcEmployeeScheduelList.Controls.Add(this.fld_dgcHREmployeeSchedules);
            this.fld_grcEmployeeScheduelList.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcEmployeeScheduelList.Location = new System.Drawing.Point(5, 189);
            this.fld_grcEmployeeScheduelList.Name = "fld_grcEmployeeScheduelList";
            this.fld_grcEmployeeScheduelList.Screen = null;
            this.fld_grcEmployeeScheduelList.Size = new System.Drawing.Size(998, 363);
            this.fld_grcEmployeeScheduelList.TabIndex = 16;
            this.fld_grcEmployeeScheduelList.Tag = "DC";
            this.fld_grcEmployeeScheduelList.Text = "Danh sách nhân viên";
            // 
            // fld_dgcHREmployeeSchedules
            // 
            this.fld_dgcHREmployeeSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeSchedules.BOSComment = null;
            this.fld_dgcHREmployeeSchedules.BOSDataMember = null;
            this.fld_dgcHREmployeeSchedules.BOSDataSource = null;
            this.fld_dgcHREmployeeSchedules.BOSDescription = null;
            this.fld_dgcHREmployeeSchedules.BOSError = null;
            this.fld_dgcHREmployeeSchedules.BOSFieldGroup = null;
            this.fld_dgcHREmployeeSchedules.BOSFieldRelation = null;
            this.fld_dgcHREmployeeSchedules.BOSGridType = null;
            this.fld_dgcHREmployeeSchedules.BOSPrivilege = null;
            this.fld_dgcHREmployeeSchedules.BOSPropertyName = null;
            this.fld_dgcHREmployeeSchedules.Location = new System.Drawing.Point(5, 58);
            this.fld_dgcHREmployeeSchedules.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeSchedules.Name = "fld_dgcHREmployeeSchedules";
            this.fld_dgcHREmployeeSchedules.PrintReport = false;
            this.fld_dgcHREmployeeSchedules.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RLKEWorkingShift});
            this.fld_dgcHREmployeeSchedules.Screen = null;
            this.fld_dgcHREmployeeSchedules.Size = new System.Drawing.Size(988, 300);
            this.fld_dgcHREmployeeSchedules.TabIndex = 13;
            // 
            // RLKEWorkingShift
            // 
            this.RLKEWorkingShift.AutoHeight = false;
            this.RLKEWorkingShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RLKEWorkingShift.DisplayMember = "HRWorkingShiftName";
            this.RLKEWorkingShift.Name = "RLKEWorkingShift";
            this.RLKEWorkingShift.ValueMember = "HRWorkingShiftID";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.BOSComment = null;
            this.fld_btnAddEmployee.BOSDataMember = null;
            this.fld_btnAddEmployee.BOSDataSource = null;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = null;
            this.fld_btnAddEmployee.BOSFieldRelation = null;
            this.fld_btnAddEmployee.BOSPrivilege = null;
            this.fld_btnAddEmployee.BOSPropertyName = null;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(5, 25);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(123, 27);
            this.fld_btnAddEmployee.TabIndex = 12;
            this.fld_btnAddEmployee.Tag = "DC";
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_btnChooseFile
            // 
            this.fld_btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnChooseFile.BOSComment = null;
            this.fld_btnChooseFile.BOSDataMember = null;
            this.fld_btnChooseFile.BOSDataSource = null;
            this.fld_btnChooseFile.BOSDescription = null;
            this.fld_btnChooseFile.BOSError = null;
            this.fld_btnChooseFile.BOSFieldGroup = null;
            this.fld_btnChooseFile.BOSFieldRelation = null;
            this.fld_btnChooseFile.BOSPrivilege = null;
            this.fld_btnChooseFile.BOSPropertyName = null;
            this.fld_btnChooseFile.Location = new System.Drawing.Point(488, 562);
            this.fld_btnChooseFile.Name = "fld_btnChooseFile";
            this.fld_btnChooseFile.Screen = null;
            this.fld_btnChooseFile.Size = new System.Drawing.Size(20, 20);
            this.fld_btnChooseFile.TabIndex = 17;
            this.fld_btnChooseFile.Text = "...";
            this.fld_btnChooseFile.Click += new System.EventHandler(this.fld_btnChooseFile_Click);
            // 
            // fld_btnEditinExcel
            // 
            this.fld_btnEditinExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnEditinExcel.BOSComment = null;
            this.fld_btnEditinExcel.BOSDataMember = null;
            this.fld_btnEditinExcel.BOSDataSource = null;
            this.fld_btnEditinExcel.BOSDescription = null;
            this.fld_btnEditinExcel.BOSError = null;
            this.fld_btnEditinExcel.BOSFieldGroup = null;
            this.fld_btnEditinExcel.BOSFieldRelation = null;
            this.fld_btnEditinExcel.BOSPrivilege = null;
            this.fld_btnEditinExcel.BOSPropertyName = null;
            this.fld_btnEditinExcel.Location = new System.Drawing.Point(634, 558);
            this.fld_btnEditinExcel.Name = "fld_btnEditinExcel";
            this.fld_btnEditinExcel.Screen = null;
            this.fld_btnEditinExcel.Size = new System.Drawing.Size(98, 27);
            this.fld_btnEditinExcel.TabIndex = 18;
            this.fld_btnEditinExcel.Tag = "DC";
            this.fld_btnEditinExcel.Text = "Sửa trên Excel";
            this.fld_btnEditinExcel.Click += new System.EventHandler(this.fld_btnEditinExcel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_txtChooseFile);
            this.panelControl1.Controls.Add(this.fld_grcMainObject);
            this.panelControl1.Controls.Add(this.fld_grcEmployeeScheduelList);
            this.panelControl1.Controls.Add(this.fld_btnEditinExcel);
            this.panelControl1.Controls.Add(this.fld_btnImportFromExcel);
            this.panelControl1.Controls.Add(this.fld_btnChooseFile);
            this.panelControl1.Controls.Add(this.bosLabel12);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 587);
            this.panelControl1.TabIndex = 19;
            // 
            // DMES100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1008, 587);
            this.Controls.Add(this.panelControl1);
            this.Name = "DMES100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcMainObject)).EndInit();
            this.fld_grcMainObject.ResumeLayout(false);
            this.fld_grcMainObject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRScheduleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRScheduleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRScheduleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtChooseFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcEmployeeScheduelList)).EndInit();
            this.fld_grcEmployeeScheduelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
      
        private BOSComponent.BOSGroupControl fld_grcMainObject;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtHRScheduleNo;
        private BOSComponent.BOSTextBox fld_txtHRScheduleName;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteHRScheduleDate;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSMemoEdit fld_medHRScheduleDesc;
        private BOSComponent.BOSButton fld_btnImportFromExcel;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtChooseFile;
        private BOSComponent.BOSGroupControl fld_grcEmployeeScheduelList;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSButton fld_btnChooseFile;
        private BOSERP.Modules.EmployeeSchedule.EmployeeScheduleGridControl fld_dgcHREmployeeSchedules;
        private BOSComponent.BOSButton fld_btnEditinExcel;
        private BOSComponent.BOSDateEdit fld_dteHRScheduleToDate;
        private BOSComponent.BOSDateEdit fld_dteHRScheduleFromDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RLKEWorkingShift;
        private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}
