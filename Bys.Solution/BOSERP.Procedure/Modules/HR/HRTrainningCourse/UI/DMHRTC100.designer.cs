using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
	/// <summary>
	/// Summary description for DMHRTC100
	/// </summary>
	partial class DMHRTC100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSTextBox fld_txtHRTrainningCourseNo1;
		private BOSComponent.BOSTextBox fld_txtHRTrainningCourseName1;
		private BOSComponent.BOSDateEdit fld_dteHRTranningCourseStartDate;
		private BOSComponent.BOSDateEdit fld_dteHRTrainningCourseEndDate;
		private BOSComponent.BOSMemoEdit fld_medHRTrainningCourseDesc;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLookupEdit fld_lkeLookupEdit;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLookupEdit fld_lkeHRTrainningCourses;
		private HRTrainningEmployeesGridControl fld_dgcHRTrainningEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTrainningEmployees;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtHRTrainningCourseNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRTrainningCourseName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRTranningCourseStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRTrainningCourseEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHRTrainningCourseDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeLookupEdit = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTrainningCourses = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRTrainningEmployees = new BOSERP.Modules.HRTrainningCourse.HRTrainningEmployeesGridControl();
            this.fld_dgvHRTrainningEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTranningCourseStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTranningCourseStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTrainningCourseEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTrainningCourseEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRTrainningCourseDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTrainningCourses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningEmployees)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRTrainningCourseNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRTrainningCourseName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRTranningCourseStartDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteHRTrainningCourseEndDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRTrainningCourseDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeLookupEdit);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeHRTrainningCourses);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, -1);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 150);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin khóa học";
            // 
            // fld_txtHRTrainningCourseNo1
            // 
            this.fld_txtHRTrainningCourseNo1.BOSComment = "";
            this.fld_txtHRTrainningCourseNo1.BOSDataMember = "HRTrainningCourseNo";
            this.fld_txtHRTrainningCourseNo1.BOSDataSource = "HRTrainningCourses";
            this.fld_txtHRTrainningCourseNo1.BOSDescription = null;
            this.fld_txtHRTrainningCourseNo1.BOSError = null;
            this.fld_txtHRTrainningCourseNo1.BOSFieldGroup = "";
            this.fld_txtHRTrainningCourseNo1.BOSFieldRelation = "";
            this.fld_txtHRTrainningCourseNo1.BOSPrivilege = "";
            this.fld_txtHRTrainningCourseNo1.BOSPropertyName = "Text";
            this.fld_txtHRTrainningCourseNo1.EditValue = "";
            this.fld_txtHRTrainningCourseNo1.Location = new System.Drawing.Point(86, 28);
            this.fld_txtHRTrainningCourseNo1.Name = "fld_txtHRTrainningCourseNo1";
            this.fld_txtHRTrainningCourseNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTrainningCourseNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTrainningCourseNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTrainningCourseNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTrainningCourseNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTrainningCourseNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTrainningCourseNo1.Screen = null;
            this.fld_txtHRTrainningCourseNo1.Size = new System.Drawing.Size(225, 20);
            this.fld_txtHRTrainningCourseNo1.TabIndex = 6;
            this.fld_txtHRTrainningCourseNo1.Tag = "DC";
            // 
            // fld_txtHRTrainningCourseName1
            // 
            this.fld_txtHRTrainningCourseName1.BOSComment = "";
            this.fld_txtHRTrainningCourseName1.BOSDataMember = "HRTrainningCourseName";
            this.fld_txtHRTrainningCourseName1.BOSDataSource = "HRTrainningCourses";
            this.fld_txtHRTrainningCourseName1.BOSDescription = null;
            this.fld_txtHRTrainningCourseName1.BOSError = null;
            this.fld_txtHRTrainningCourseName1.BOSFieldGroup = "";
            this.fld_txtHRTrainningCourseName1.BOSFieldRelation = "";
            this.fld_txtHRTrainningCourseName1.BOSPrivilege = "";
            this.fld_txtHRTrainningCourseName1.BOSPropertyName = "Text";
            this.fld_txtHRTrainningCourseName1.EditValue = "";
            this.fld_txtHRTrainningCourseName1.Location = new System.Drawing.Point(86, 52);
            this.fld_txtHRTrainningCourseName1.Name = "fld_txtHRTrainningCourseName1";
            this.fld_txtHRTrainningCourseName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTrainningCourseName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTrainningCourseName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTrainningCourseName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTrainningCourseName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTrainningCourseName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTrainningCourseName1.Screen = null;
            this.fld_txtHRTrainningCourseName1.Size = new System.Drawing.Size(465, 20);
            this.fld_txtHRTrainningCourseName1.TabIndex = 7;
            this.fld_txtHRTrainningCourseName1.Tag = "DC";
            // 
            // fld_dteHRTranningCourseStartDate
            // 
            this.fld_dteHRTranningCourseStartDate.BOSComment = "";
            this.fld_dteHRTranningCourseStartDate.BOSDataMember = "HRTranningCourseStartDate";
            this.fld_dteHRTranningCourseStartDate.BOSDataSource = "HRTrainningCourses";
            this.fld_dteHRTranningCourseStartDate.BOSDescription = null;
            this.fld_dteHRTranningCourseStartDate.BOSError = null;
            this.fld_dteHRTranningCourseStartDate.BOSFieldGroup = "";
            this.fld_dteHRTranningCourseStartDate.BOSFieldRelation = "";
            this.fld_dteHRTranningCourseStartDate.BOSPrivilege = "";
            this.fld_dteHRTranningCourseStartDate.BOSPropertyName = "EditValue";
            this.fld_dteHRTranningCourseStartDate.EditValue = null;
            this.fld_dteHRTranningCourseStartDate.Location = new System.Drawing.Point(400, 28);
            this.fld_dteHRTranningCourseStartDate.Name = "fld_dteHRTranningCourseStartDate";
            this.fld_dteHRTranningCourseStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTranningCourseStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTranningCourseStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTranningCourseStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTranningCourseStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTranningCourseStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTranningCourseStartDate.Screen = null;
            this.fld_dteHRTranningCourseStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTranningCourseStartDate.TabIndex = 8;
            this.fld_dteHRTranningCourseStartDate.Tag = "DC";
            this.fld_dteHRTranningCourseStartDate.Validating += new System.ComponentModel.CancelEventHandler(this.fld_dteHRTranningCourseStartDate_Validating);
            // 
            // fld_dteHRTrainningCourseEndDate
            // 
            this.fld_dteHRTrainningCourseEndDate.BOSComment = "";
            this.fld_dteHRTrainningCourseEndDate.BOSDataMember = "HRTrainningCourseEndDate";
            this.fld_dteHRTrainningCourseEndDate.BOSDataSource = "HRTrainningCourses";
            this.fld_dteHRTrainningCourseEndDate.BOSDescription = null;
            this.fld_dteHRTrainningCourseEndDate.BOSError = null;
            this.fld_dteHRTrainningCourseEndDate.BOSFieldGroup = "";
            this.fld_dteHRTrainningCourseEndDate.BOSFieldRelation = "";
            this.fld_dteHRTrainningCourseEndDate.BOSPrivilege = "";
            this.fld_dteHRTrainningCourseEndDate.BOSPropertyName = "EditValue";
            this.fld_dteHRTrainningCourseEndDate.EditValue = null;
            this.fld_dteHRTrainningCourseEndDate.Location = new System.Drawing.Point(641, 27);
            this.fld_dteHRTrainningCourseEndDate.Name = "fld_dteHRTrainningCourseEndDate";
            this.fld_dteHRTrainningCourseEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTrainningCourseEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTrainningCourseEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTrainningCourseEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTrainningCourseEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTrainningCourseEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTrainningCourseEndDate.Screen = null;
            this.fld_dteHRTrainningCourseEndDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTrainningCourseEndDate.TabIndex = 9;
            this.fld_dteHRTrainningCourseEndDate.Tag = "DC";
            this.fld_dteHRTrainningCourseEndDate.Validating += new System.ComponentModel.CancelEventHandler(this.fld_dteHRTrainningCourseEndDate_Validating);
            // 
            // fld_medHRTrainningCourseDesc
            // 
            this.fld_medHRTrainningCourseDesc.BOSComment = "";
            this.fld_medHRTrainningCourseDesc.BOSDataMember = "HRTrainningCourseDesc";
            this.fld_medHRTrainningCourseDesc.BOSDataSource = "HRTrainningCourses";
            this.fld_medHRTrainningCourseDesc.BOSDescription = null;
            this.fld_medHRTrainningCourseDesc.BOSError = null;
            this.fld_medHRTrainningCourseDesc.BOSFieldGroup = "";
            this.fld_medHRTrainningCourseDesc.BOSFieldRelation = "";
            this.fld_medHRTrainningCourseDesc.BOSPrivilege = "";
            this.fld_medHRTrainningCourseDesc.BOSPropertyName = "Text";
            this.fld_medHRTrainningCourseDesc.EditValue = "";
            this.fld_medHRTrainningCourseDesc.Location = new System.Drawing.Point(86, 76);
            this.fld_medHRTrainningCourseDesc.Name = "fld_medHRTrainningCourseDesc";
            this.fld_medHRTrainningCourseDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRTrainningCourseDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRTrainningCourseDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRTrainningCourseDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRTrainningCourseDesc.Screen = null;
            this.fld_medHRTrainningCourseDesc.Size = new System.Drawing.Size(704, 60);
            this.fld_medHRTrainningCourseDesc.TabIndex = 10;
            this.fld_medHRTrainningCourseDesc.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(15, 32);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel2.TabIndex = 11;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã khóa học";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(15, 55);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên khóa học";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(327, 30);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel4.TabIndex = 13;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Ngày bắt đầu";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(564, 30);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel5.TabIndex = 14;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày kết thúc";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(15, 99);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel6.TabIndex = 15;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_lkeLookupEdit
            // 
            this.fld_lkeLookupEdit.BOSAllowAddNew = false;
            this.fld_lkeLookupEdit.BOSAllowDummy = false;
            this.fld_lkeLookupEdit.BOSComment = "";
            this.fld_lkeLookupEdit.BOSDataMember = "HRTrainningCourseStatus";
            this.fld_lkeLookupEdit.BOSDataSource = "HRTrainningCourses";
            this.fld_lkeLookupEdit.BOSDescription = null;
            this.fld_lkeLookupEdit.BOSError = null;
            this.fld_lkeLookupEdit.BOSFieldGroup = "";
            this.fld_lkeLookupEdit.BOSFieldParent = "";
            this.fld_lkeLookupEdit.BOSFieldRelation = "";
            this.fld_lkeLookupEdit.BOSPrivilege = "";
            this.fld_lkeLookupEdit.BOSPropertyName = "EditValue";
            this.fld_lkeLookupEdit.BOSSelectType = "";
            this.fld_lkeLookupEdit.BOSSelectTypeValue = "";
            this.fld_lkeLookupEdit.CurrentDisplayText = null;
            this.fld_lkeLookupEdit.Location = new System.Drawing.Point(641, 51);
            this.fld_lkeLookupEdit.Name = "fld_lkeLookupEdit";
            this.fld_lkeLookupEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeLookupEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeLookupEdit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeLookupEdit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeLookupEdit.Properties.NullText = "";
            this.fld_lkeLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeLookupEdit.Screen = null;
            this.fld_lkeLookupEdit.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeLookupEdit.TabIndex = 18;
            this.fld_lkeLookupEdit.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(564, 54);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel7.TabIndex = 19;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Tình trạng";
            // 
            // fld_lkeHRTrainningCourses
            // 
            this.fld_lkeHRTrainningCourses.BOSAllowAddNew = false;
            this.fld_lkeHRTrainningCourses.BOSAllowDummy = false;
            this.fld_lkeHRTrainningCourses.BOSComment = "";
            this.fld_lkeHRTrainningCourses.BOSDataMember = "HRTrainningCourseStatus";
            this.fld_lkeHRTrainningCourses.BOSDataSource = "HRTrainningCourses";
            this.fld_lkeHRTrainningCourses.BOSDescription = null;
            this.fld_lkeHRTrainningCourses.BOSError = null;
            this.fld_lkeHRTrainningCourses.BOSFieldGroup = "";
            this.fld_lkeHRTrainningCourses.BOSFieldParent = "";
            this.fld_lkeHRTrainningCourses.BOSFieldRelation = "";
            this.fld_lkeHRTrainningCourses.BOSPrivilege = "";
            this.fld_lkeHRTrainningCourses.BOSPropertyName = "EditValue";
            this.fld_lkeHRTrainningCourses.BOSSelectType = "";
            this.fld_lkeHRTrainningCourses.BOSSelectTypeValue = "";
            this.fld_lkeHRTrainningCourses.CurrentDisplayText = null;
            this.fld_lkeHRTrainningCourses.Location = new System.Drawing.Point(641, 51);
            this.fld_lkeHRTrainningCourses.Name = "fld_lkeHRTrainningCourses";
            this.fld_lkeHRTrainningCourses.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRTrainningCourses.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRTrainningCourses.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRTrainningCourses.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRTrainningCourses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTrainningCourses.Properties.NullText = "";
            this.fld_lkeHRTrainningCourses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRTrainningCourses.Screen = null;
            this.fld_lkeHRTrainningCourses.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTrainningCourses.TabIndex = 18;
            this.fld_lkeHRTrainningCourses.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRTrainningEmployees);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 151);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(862, 413);
            this.fld_grcGroupControl1.TabIndex = 5;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Danh sách người hướng dẫn";
            // 
            // fld_dgcHRTrainningEmployees
            // 
            this.fld_dgcHRTrainningEmployees.AllowDrop = true;
            this.fld_dgcHRTrainningEmployees.BOSComment = "";
            this.fld_dgcHRTrainningEmployees.BOSDataMember = "";
            this.fld_dgcHRTrainningEmployees.BOSDataSource = "HRTrainningEmployees";
            this.fld_dgcHRTrainningEmployees.BOSDescription = null;
            this.fld_dgcHRTrainningEmployees.BOSError = null;
            this.fld_dgcHRTrainningEmployees.BOSFieldGroup = "";
            this.fld_dgcHRTrainningEmployees.BOSFieldRelation = "";
            this.fld_dgcHRTrainningEmployees.BOSGridType = null;
            this.fld_dgcHRTrainningEmployees.BOSPrivilege = "";
            this.fld_dgcHRTrainningEmployees.BOSPropertyName = "";
            this.fld_dgcHRTrainningEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTrainningEmployees.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTrainningEmployees.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRTrainningEmployees.MainView = this.fld_dgvHRTrainningEmployees;
            this.fld_dgcHRTrainningEmployees.Name = "fld_dgcHRTrainningEmployees";
            this.fld_dgcHRTrainningEmployees.Screen = null;
            this.fld_dgcHRTrainningEmployees.Size = new System.Drawing.Size(858, 389);
            this.fld_dgcHRTrainningEmployees.TabIndex = 20;
            this.fld_dgcHRTrainningEmployees.Tag = "DC";
            this.fld_dgcHRTrainningEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTrainningEmployees});
            // 
            // fld_dgvHRTrainningEmployees
            // 
            this.fld_dgvHRTrainningEmployees.GridControl = this.fld_dgcHRTrainningEmployees;
            this.fld_dgvHRTrainningEmployees.Name = "fld_dgvHRTrainningEmployees";
            this.fld_dgvHRTrainningEmployees.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMHRTC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTC100";
            this.Text = "Thông tin chung";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTrainningCourseName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTranningCourseStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTranningCourseStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTrainningCourseEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTrainningCourseEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRTrainningCourseDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTrainningCourses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningEmployees)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
