using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTrainningEmployee.UI
{
	/// <summary>
	/// Summary description for DMHRTE100
	/// </summary>
	partial class DMHRTE100
	{
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private HRTrainningEmployeesGridControl fld_dgcHRTrainningEmployees;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTrainningEmployees;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HRTrainningCourseID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRTrainningClassID;
		private BOSComponent.BOSLabel fld_lblHRTrainningClassMaxQty;
        private BOSComponent.BOSLabel fld_lblHRTrainningClassRegisteredQty;


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
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_HRTrainningCourseID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRTrainningClassID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblHRTrainningClassMaxQty = new BOSComponent.BOSLabel(this.components);
            this.fld_lblHRTrainningClassRegisteredQty = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRTrainningEmployees = new BOSERP.Modules.HRTrainningEmployee.HRTrainningEmployeesGridControl();
            this.fld_dgvHRTrainningEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningCourseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningClassID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTrainningEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTrainningEmployees)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(172, 28);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLabel1.TabIndex = 4;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Khóa";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(179, 52);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(17, 13);
            this.fld_lblLabel2.TabIndex = 5;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Lớp";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(447, 28);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(113, 13);
            this.fld_lblLabel3.TabIndex = 6;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Số lượng đăng ký tối đa";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(462, 53);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(98, 13);
            this.fld_lblLabel4.TabIndex = 7;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Số lượng đã đăng ký";
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
            this.fld_grcGroupControl.Controls.Add(this.fld_btnSave);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRTrainningCourseID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRTrainningClassID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblHRTrainningClassMaxQty);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblHRTrainningClassRegisteredQty);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(903, 76);
            this.fld_grcGroupControl.TabIndex = 8;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin đăng ký";
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
            this.fld_btnSave.Location = new System.Drawing.Point(802, 36);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(89, 27);
            this.fld_btnSave.TabIndex = 17;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // fld_lkeFK_HRTrainningCourseID
            // 
            this.fld_lkeFK_HRTrainningCourseID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTrainningCourseID.BOSAllowDummy = false;
            this.fld_lkeFK_HRTrainningCourseID.BOSComment = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSDataMember = "HRTrainningCourseID";
            this.fld_lkeFK_HRTrainningCourseID.BOSDataSource = "HRTrainningCourses";
            this.fld_lkeFK_HRTrainningCourseID.BOSDescription = null;
            this.fld_lkeFK_HRTrainningCourseID.BOSError = null;
            this.fld_lkeFK_HRTrainningCourseID.BOSFieldGroup = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSFieldParent = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSFieldRelation = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSPrivilege = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTrainningCourseID.BOSSelectType = "";
            this.fld_lkeFK_HRTrainningCourseID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRTrainningCourseID.CurrentDisplayText = null;
            this.fld_lkeFK_HRTrainningCourseID.Location = new System.Drawing.Point(207, 25);
            this.fld_lkeFK_HRTrainningCourseID.Name = "fld_lkeFK_HRTrainningCourseID";
            this.fld_lkeFK_HRTrainningCourseID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTrainningCourseID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTrainningCourseID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTrainningCourseID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTrainningCourseID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTrainningCourseID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningCourseNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningCourseName", "Name")});
            this.fld_lkeFK_HRTrainningCourseID.Properties.DisplayMember = "HRTrainningCourseName";
            this.fld_lkeFK_HRTrainningCourseID.Properties.NullText = "";
            this.fld_lkeFK_HRTrainningCourseID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRTrainningCourseID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTrainningCourseID.Properties.ValueMember = "HRTrainningCourseID";
            this.fld_lkeFK_HRTrainningCourseID.Screen = null;
            this.fld_lkeFK_HRTrainningCourseID.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeFK_HRTrainningCourseID.TabIndex = 11;
            this.fld_lkeFK_HRTrainningCourseID.Tag = "DC";
            // 
            // fld_lkeFK_HRTrainningClassID
            // 
            this.fld_lkeFK_HRTrainningClassID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRTrainningClassID.BOSAllowDummy = true;
            this.fld_lkeFK_HRTrainningClassID.BOSComment = "";
            this.fld_lkeFK_HRTrainningClassID.BOSDataMember = "HRTrainningClassID";
            this.fld_lkeFK_HRTrainningClassID.BOSDataSource = "HRTrainningClass";
            this.fld_lkeFK_HRTrainningClassID.BOSDescription = null;
            this.fld_lkeFK_HRTrainningClassID.BOSError = null;
            this.fld_lkeFK_HRTrainningClassID.BOSFieldGroup = "";
            this.fld_lkeFK_HRTrainningClassID.BOSFieldParent = "";
            this.fld_lkeFK_HRTrainningClassID.BOSFieldRelation = "";
            this.fld_lkeFK_HRTrainningClassID.BOSPrivilege = "";
            this.fld_lkeFK_HRTrainningClassID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRTrainningClassID.BOSSelectType = "";
            this.fld_lkeFK_HRTrainningClassID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HRTrainningClassID.CurrentDisplayText = null;
            this.fld_lkeFK_HRTrainningClassID.Location = new System.Drawing.Point(207, 49);
            this.fld_lkeFK_HRTrainningClassID.Name = "fld_lkeFK_HRTrainningClassID";
            this.fld_lkeFK_HRTrainningClassID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRTrainningClassID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRTrainningClassID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRTrainningClassID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRTrainningClassID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRTrainningClassID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningClassNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRTrainningClassName", "Name")});
            this.fld_lkeFK_HRTrainningClassID.Properties.DisplayMember = "HRTrainningClassName";
            this.fld_lkeFK_HRTrainningClassID.Properties.NullText = "";
            this.fld_lkeFK_HRTrainningClassID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRTrainningClassID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRTrainningClassID.Properties.ValueMember = "HRTrainningClassID";
            this.fld_lkeFK_HRTrainningClassID.Screen = null;
            this.fld_lkeFK_HRTrainningClassID.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeFK_HRTrainningClassID.TabIndex = 12;
            this.fld_lkeFK_HRTrainningClassID.Tag = "DC";
            this.fld_lkeFK_HRTrainningClassID.Validated += new System.EventHandler(this.fld_lkeFK_HRTrainningClassID_Validated);
            // 
            // fld_lblHRTrainningClassMaxQty
            // 
            this.fld_lblHRTrainningClassMaxQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRTrainningClassMaxQty.Appearance.ForeColor = System.Drawing.Color.Black;
            this.fld_lblHRTrainningClassMaxQty.Appearance.Options.UseBackColor = true;
            this.fld_lblHRTrainningClassMaxQty.Appearance.Options.UseForeColor = true;
            this.fld_lblHRTrainningClassMaxQty.BOSComment = "";
            this.fld_lblHRTrainningClassMaxQty.BOSDataMember = "";
            this.fld_lblHRTrainningClassMaxQty.BOSDataSource = "";
            this.fld_lblHRTrainningClassMaxQty.BOSDescription = null;
            this.fld_lblHRTrainningClassMaxQty.BOSError = null;
            this.fld_lblHRTrainningClassMaxQty.BOSFieldGroup = "";
            this.fld_lblHRTrainningClassMaxQty.BOSFieldRelation = "";
            this.fld_lblHRTrainningClassMaxQty.BOSPrivilege = "";
            this.fld_lblHRTrainningClassMaxQty.BOSPropertyName = "";
            this.fld_lblHRTrainningClassMaxQty.Location = new System.Drawing.Point(571, 28);
            this.fld_lblHRTrainningClassMaxQty.Name = "fld_lblHRTrainningClassMaxQty";
            this.fld_lblHRTrainningClassMaxQty.Screen = null;
            this.fld_lblHRTrainningClassMaxQty.Size = new System.Drawing.Size(6, 13);
            this.fld_lblHRTrainningClassMaxQty.TabIndex = 15;
            this.fld_lblHRTrainningClassMaxQty.Tag = "";
            this.fld_lblHRTrainningClassMaxQty.Text = "0";
            // 
            // fld_lblHRTrainningClassRegisteredQty
            // 
            this.fld_lblHRTrainningClassRegisteredQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRTrainningClassRegisteredQty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRTrainningClassRegisteredQty.Appearance.Options.UseBackColor = true;
            this.fld_lblHRTrainningClassRegisteredQty.Appearance.Options.UseForeColor = true;
            this.fld_lblHRTrainningClassRegisteredQty.BOSComment = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSDataMember = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSDataSource = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSDescription = null;
            this.fld_lblHRTrainningClassRegisteredQty.BOSError = null;
            this.fld_lblHRTrainningClassRegisteredQty.BOSFieldGroup = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSFieldRelation = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSPrivilege = "";
            this.fld_lblHRTrainningClassRegisteredQty.BOSPropertyName = "";
            this.fld_lblHRTrainningClassRegisteredQty.Location = new System.Drawing.Point(571, 53);
            this.fld_lblHRTrainningClassRegisteredQty.Name = "fld_lblHRTrainningClassRegisteredQty";
            this.fld_lblHRTrainningClassRegisteredQty.Screen = null;
            this.fld_lblHRTrainningClassRegisteredQty.Size = new System.Drawing.Size(6, 13);
            this.fld_lblHRTrainningClassRegisteredQty.TabIndex = 16;
            this.fld_lblHRTrainningClassRegisteredQty.Tag = "";
            this.fld_lblHRTrainningClassRegisteredQty.Text = "0";
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
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 75);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(903, 489);
            this.fld_grcGroupControl1.TabIndex = 9;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Danh sách học viên";
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
            this.fld_dgcHRTrainningEmployees.Size = new System.Drawing.Size(899, 465);
            this.fld_dgcHRTrainningEmployees.TabIndex = 10;
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
            this.bosPanel1.Size = new System.Drawing.Size(903, 567);
            this.bosPanel1.TabIndex = 10;
            // 
            // DMHRTE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(903, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTE100";
            this.Text = "Đăng ký";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningCourseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRTrainningClassID.Properties)).EndInit();
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
        private BOSComponent.BOSButton fld_btnSave;
	}
}
