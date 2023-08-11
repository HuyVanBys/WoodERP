using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningEmployee.UI
{
	/// <summary>
	/// Summary description for DMHRTE101
	/// </summary>
	partial class DMHRTE101
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl3;
		private BOSComponent.BOSGroupControl fld_grcGroupControl4;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HRTrainningCourseID1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HRTrainningClassID1;
		private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSLabel fld_lblLabel10;
		private HRClassSchedulesGridControl fld_dgcHRClassSchedules;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAbsences;
		private HREmployeeAbsencesGridControl fld_dgcHRTrainningEmployees1;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAbsences1;


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
            this.fld_grcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRClassSchedules = new BOSERP.Modules.HRTrainningEmployee.HRClassSchedulesGridControl();
            this.fld_dgvHREmployeeAbsences = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRTrainningEmployees1 = new BOSERP.Modules.HRTrainningEmployee.HREmployeeAbsencesGridControl();
            this.fld_dgvHREmployeeAbsences1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HRTrainningCourseID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRTrainningClassID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).BeginInit();
            this.fld_grcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRClassSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).BeginInit();
            this.fld_grcGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningEmployees1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAbsences1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningCourseID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningClassID1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl3
            // 
            this.fld_grcGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl3.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl3.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl3.BOSComment = "";
            this.fld_grcGroupControl3.BOSDataMember = "";
            this.fld_grcGroupControl3.BOSDataSource = "";
            this.fld_grcGroupControl3.BOSDescription = null;
            this.fld_grcGroupControl3.BOSError = null;
            this.fld_grcGroupControl3.BOSFieldGroup = "";
            this.fld_grcGroupControl3.BOSFieldRelation = "";
            this.fld_grcGroupControl3.BOSPrivilege = "";
            this.fld_grcGroupControl3.BOSPropertyName = "";
            this.fld_grcGroupControl3.Controls.Add(this.fld_dgcHRClassSchedules);
            this.fld_grcGroupControl3.Location = new System.Drawing.Point(12, 43);
            this.fld_grcGroupControl3.Name = "fld_grcGroupControl3";
            this.fld_grcGroupControl3.Screen = null;
            this.fld_grcGroupControl3.Size = new System.Drawing.Size(767, 260);
            this.fld_grcGroupControl3.TabIndex = 5;
            this.fld_grcGroupControl3.Tag = "";
            this.fld_grcGroupControl3.Text = "Thông tin lớp học";
            // 
            // fld_dgcHRClassSchedules
            // 
            this.fld_dgcHRClassSchedules.AllowDrop = true;
            this.fld_dgcHRClassSchedules.BOSComment = "";
            this.fld_dgcHRClassSchedules.BOSDataMember = "";
            this.fld_dgcHRClassSchedules.BOSDataSource = "HRClassSchedules";
            this.fld_dgcHRClassSchedules.BOSDescription = null;
            this.fld_dgcHRClassSchedules.BOSError = null;
            this.fld_dgcHRClassSchedules.BOSFieldGroup = "";
            this.fld_dgcHRClassSchedules.BOSFieldRelation = "";
            this.fld_dgcHRClassSchedules.BOSGridType = null;
            this.fld_dgcHRClassSchedules.BOSPrivilege = "";
            this.fld_dgcHRClassSchedules.BOSPropertyName = "";
            this.fld_dgcHRClassSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRClassSchedules.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRClassSchedules.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRClassSchedules.MainView = this.fld_dgvHREmployeeAbsences;
            this.fld_dgcHRClassSchedules.Name = "fld_dgcHRClassSchedules";
            this.fld_dgcHRClassSchedules.Screen = null;
            this.fld_dgcHRClassSchedules.Size = new System.Drawing.Size(763, 236);
            this.fld_dgcHRClassSchedules.TabIndex = 11;
            this.fld_dgcHRClassSchedules.Tag = "DC";
            this.fld_dgcHRClassSchedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAbsences});
            // 
            // fld_dgvHREmployeeAbsences
            // 
            this.fld_dgvHREmployeeAbsences.GridControl = this.fld_dgcHRClassSchedules;
            this.fld_dgvHREmployeeAbsences.Name = "fld_dgvHREmployeeAbsences";
            this.fld_dgvHREmployeeAbsences.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl4
            // 
            this.fld_grcGroupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl4.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl4.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl4.BOSComment = "";
            this.fld_grcGroupControl4.BOSDataMember = "";
            this.fld_grcGroupControl4.BOSDataSource = "";
            this.fld_grcGroupControl4.BOSDescription = null;
            this.fld_grcGroupControl4.BOSError = null;
            this.fld_grcGroupControl4.BOSFieldGroup = "";
            this.fld_grcGroupControl4.BOSFieldRelation = "";
            this.fld_grcGroupControl4.BOSPrivilege = "";
            this.fld_grcGroupControl4.BOSPropertyName = "";
            this.fld_grcGroupControl4.Controls.Add(this.fld_dgcHRTrainningEmployees1);
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(12, 307);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(765, 248);
            this.fld_grcGroupControl4.TabIndex = 6;
            this.fld_grcGroupControl4.Tag = "";
            this.fld_grcGroupControl4.Text = "Điểm danh nhân viên";
            // 
            // fld_dgcHRTrainningEmployees1
            // 
            this.fld_dgcHRTrainningEmployees1.AllowDrop = true;
            this.fld_dgcHRTrainningEmployees1.BOSComment = "";
            this.fld_dgcHRTrainningEmployees1.BOSDataMember = "";
            this.fld_dgcHRTrainningEmployees1.BOSDataSource = "HRTrainningEmployees";
            this.fld_dgcHRTrainningEmployees1.BOSDescription = null;
            this.fld_dgcHRTrainningEmployees1.BOSError = null;
            this.fld_dgcHRTrainningEmployees1.BOSFieldGroup = "";
            this.fld_dgcHRTrainningEmployees1.BOSFieldRelation = "";
            this.fld_dgcHRTrainningEmployees1.BOSGridType = null;
            this.fld_dgcHRTrainningEmployees1.BOSPrivilege = "";
            this.fld_dgcHRTrainningEmployees1.BOSPropertyName = "";
            this.fld_dgcHRTrainningEmployees1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTrainningEmployees1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTrainningEmployees1.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRTrainningEmployees1.MainView = this.fld_dgvHREmployeeAbsences1;
            this.fld_dgcHRTrainningEmployees1.Name = "fld_dgcHRTrainningEmployees1";
            this.fld_dgcHRTrainningEmployees1.Screen = null;
            this.fld_dgcHRTrainningEmployees1.Size = new System.Drawing.Size(761, 224);
            this.fld_dgcHRTrainningEmployees1.TabIndex = 12;
            this.fld_dgcHRTrainningEmployees1.Tag = "DC";
            this.fld_dgcHRTrainningEmployees1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAbsences1});
            // 
            // fld_dgvHREmployeeAbsences1
            // 
            this.fld_dgvHREmployeeAbsences1.GridControl = this.fld_dgcHRTrainningEmployees1;
            this.fld_dgvHREmployeeAbsences1.Name = "fld_dgvHREmployeeAbsences1";
            this.fld_dgvHREmployeeAbsences1.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HRTrainningCourseID1
            // 
            this.fld_lkeFK_HRTrainningCourseID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTrainningCourseID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRTrainningCourseID1.BOSComment = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSDataMember = "FK_HRTrainningCourseID";
            this.fld_lkeFK_HRTrainningCourseID1.BOSDataSource = "HREmployeeAbsences";
            this.fld_lkeFK_HRTrainningCourseID1.BOSDescription = null;
            this.fld_lkeFK_HRTrainningCourseID1.BOSError = null;
            this.fld_lkeFK_HRTrainningCourseID1.BOSFieldGroup = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSFieldParent = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSFieldRelation = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSPrivilege = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTrainningCourseID1.BOSSelectType = "";
            this.fld_lkeFK_HRTrainningCourseID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRTrainningCourseID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRTrainningCourseID1.Location = new System.Drawing.Point(47, 9);
            this.fld_lkeFK_HRTrainningCourseID1.Name = "fld_lkeFK_HRTrainningCourseID1";
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTrainningCourseID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningCourseNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningCourseName", "Name")});
            this.fld_lkeFK_HRTrainningCourseID1.Properties.DisplayMember = "HRTrainningCourseName";
            this.fld_lkeFK_HRTrainningCourseID1.Properties.NullText = "";
            this.fld_lkeFK_HRTrainningCourseID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRTrainningCourseID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTrainningCourseID1.Properties.ValueMember = "HRTrainningCourseID";
            this.fld_lkeFK_HRTrainningCourseID1.Screen = null;
            this.fld_lkeFK_HRTrainningCourseID1.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeFK_HRTrainningCourseID1.TabIndex = 7;
            this.fld_lkeFK_HRTrainningCourseID1.Tag = "DC";
            // 
            // fld_lkeFK_HRTrainningClassID1
            // 
            this.fld_lkeFK_HRTrainningClassID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTrainningClassID1.BOSAllowDummy = false;
            this.fld_lkeFK_HRTrainningClassID1.BOSComment = "";
            this.fld_lkeFK_HRTrainningClassID1.BOSDataMember = "FK_HRTrainningClassID";
            this.fld_lkeFK_HRTrainningClassID1.BOSDataSource = "HREmployeeAbsences";
            this.fld_lkeFK_HRTrainningClassID1.BOSDescription = null;
            this.fld_lkeFK_HRTrainningClassID1.BOSError = null;
            this.fld_lkeFK_HRTrainningClassID1.BOSFieldGroup = "";
            this.fld_lkeFK_HRTrainningClassID1.BOSFieldParent = "fld_lkeFK_HRTrainningCourseID1";
            this.fld_lkeFK_HRTrainningClassID1.BOSFieldRelation = "";
            this.fld_lkeFK_HRTrainningClassID1.BOSPrivilege = "";
            this.fld_lkeFK_HRTrainningClassID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTrainningClassID1.BOSSelectType = "";
            this.fld_lkeFK_HRTrainningClassID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRTrainningClassID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRTrainningClassID1.Location = new System.Drawing.Point(330, 9);
            this.fld_lkeFK_HRTrainningClassID1.Name = "fld_lkeFK_HRTrainningClassID1";
            this.fld_lkeFK_HRTrainningClassID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTrainningClassID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTrainningClassID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTrainningClassID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTrainningClassID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTrainningClassID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningClassNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningClassName", "Name")});
            this.fld_lkeFK_HRTrainningClassID1.Properties.DisplayMember = "HRTrainningClassName";
            this.fld_lkeFK_HRTrainningClassID1.Properties.NullText = "";
            this.fld_lkeFK_HRTrainningClassID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRTrainningClassID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTrainningClassID1.Properties.ValueMember = "HRTrainningClassID";
            this.fld_lkeFK_HRTrainningClassID1.Screen = null;
            this.fld_lkeFK_HRTrainningClassID1.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeFK_HRTrainningClassID1.TabIndex = 8;
            this.fld_lkeFK_HRTrainningClassID1.Tag = "DC";
            this.fld_lkeFK_HRTrainningClassID1.Validated += new System.EventHandler(this.fld_lkeFK_HRTrainningClassID1_Validated);
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = "";
            this.fld_lblLabel9.BOSDataMember = "";
            this.fld_lblLabel9.BOSDataSource = "";
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = "";
            this.fld_lblLabel9.BOSFieldRelation = "";
            this.fld_lblLabel9.BOSPrivilege = "";
            this.fld_lblLabel9.BOSPropertyName = "";
            this.fld_lblLabel9.Location = new System.Drawing.Point(14, 12);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = "";
            this.fld_lblLabel9.Text = "Khóa";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = "";
            this.fld_lblLabel10.Location = new System.Drawing.Point(297, 12);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(17, 13);
            this.fld_lblLabel10.TabIndex = 10;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Lớp";
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
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl3);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl4);
            this.bosPanel1.Controls.Add(this.fld_lblLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRTrainningCourseID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRTrainningClassID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(801, 567);
            this.bosPanel1.TabIndex = 11;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(680, 8);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(97, 27);
            this.fld_btnSave.TabIndex = 11;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // DMHRTE101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(801, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTE101";
            this.Text = "Điểm danh";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl3)).EndInit();
            this.fld_grcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRClassSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).EndInit();
            this.fld_grcGroupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningEmployees1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAbsences1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningCourseID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningClassID1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnSave;
	}
}
