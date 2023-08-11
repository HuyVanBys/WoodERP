using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRCalender.UI
{
	/// <summary>
	/// Summary description for DMHRCL100
	/// </summary>
	partial class DMHRCL100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSTextBox fld_txtHRCalendarNo1;
		private BOSComponent.BOSTextBox fld_txtHRCalendarName1;
		private BOSComponent.BOSTextBox fld_txtHRCalendarYear1;
		private BOSComponent.BOSMemoEdit fld_medHRCalendarDesc;
		private BOSComponent.BOSLookupEdit fld_lkeLookupEdit1;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HRCalendarEntrysGridControl fld_dgcHRCalendarEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRCalendarEntrys;


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
            this.fld_txtHRCalendarNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCalendarName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRCalendarYear1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRCalendarDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRCalendarEntrys = new BOSERP.Modules.HRCalender.HRCalendarEntrysGridControl();
            this.fld_dgvHRCalendarEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarYear1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRCalendarDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCalendarEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRCalendarEntrys)).BeginInit();
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
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRCalendarNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRCalendarName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHRCalendarYear1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHRCalendarDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeLookupEdit1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(949, 108);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_txtHRCalendarNo1
            // 
            this.fld_txtHRCalendarNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarNo1.BOSDataMember = "HRCalendarNo";
            this.fld_txtHRCalendarNo1.BOSDataSource = "HRCalendars";
            this.fld_txtHRCalendarNo1.BOSDescription = null;
            this.fld_txtHRCalendarNo1.BOSError = null;
            this.fld_txtHRCalendarNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarNo1.BOSPropertyName = "Text";
            this.fld_txtHRCalendarNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarNo1.Location = new System.Drawing.Point(83, 28);
            this.fld_txtHRCalendarNo1.Name = "fld_txtHRCalendarNo1";
            this.fld_txtHRCalendarNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCalendarNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCalendarNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCalendarNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCalendarNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCalendarNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCalendarNo1.Screen = null;
            this.fld_txtHRCalendarNo1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRCalendarNo1.TabIndex = 1;
            this.fld_txtHRCalendarNo1.Tag = "DC";
            // 
            // fld_txtHRCalendarName1
            // 
            this.fld_txtHRCalendarName1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarName1.BOSDataMember = "HRCalendarName";
            this.fld_txtHRCalendarName1.BOSDataSource = "HRCalendars";
            this.fld_txtHRCalendarName1.BOSDescription = null;
            this.fld_txtHRCalendarName1.BOSError = null;
            this.fld_txtHRCalendarName1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarName1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarName1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarName1.BOSPropertyName = "Text";
            this.fld_txtHRCalendarName1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarName1.Location = new System.Drawing.Point(335, 28);
            this.fld_txtHRCalendarName1.Name = "fld_txtHRCalendarName1";
            this.fld_txtHRCalendarName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCalendarName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCalendarName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCalendarName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCalendarName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCalendarName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCalendarName1.Screen = null;
            this.fld_txtHRCalendarName1.Size = new System.Drawing.Size(176, 20);
            this.fld_txtHRCalendarName1.TabIndex = 2;
            this.fld_txtHRCalendarName1.Tag = "DC";
            // 
            // fld_txtHRCalendarYear1
            // 
            this.fld_txtHRCalendarYear1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarYear1.BOSDataMember = "HRCalendarYear";
            this.fld_txtHRCalendarYear1.BOSDataSource = "HRCalendars";
            this.fld_txtHRCalendarYear1.BOSDescription = null;
            this.fld_txtHRCalendarYear1.BOSError = null;
            this.fld_txtHRCalendarYear1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarYear1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarYear1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarYear1.BOSPropertyName = "Text";
            this.fld_txtHRCalendarYear1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRCalendarYear1.Location = new System.Drawing.Point(820, 28);
            this.fld_txtHRCalendarYear1.Name = "fld_txtHRCalendarYear1";
            this.fld_txtHRCalendarYear1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRCalendarYear1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRCalendarYear1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRCalendarYear1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRCalendarYear1.Properties.Mask.EditMask = "d";
            this.fld_txtHRCalendarYear1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRCalendarYear1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRCalendarYear1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRCalendarYear1.Screen = null;
            this.fld_txtHRCalendarYear1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHRCalendarYear1.TabIndex = 4;
            this.fld_txtHRCalendarYear1.Tag = "DC";
            // 
            // fld_medHRCalendarDesc
            // 
            this.fld_medHRCalendarDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRCalendarDesc.BOSDataMember = "HRCalendarDesc";
            this.fld_medHRCalendarDesc.BOSDataSource = "HRCalendars";
            this.fld_medHRCalendarDesc.BOSDescription = null;
            this.fld_medHRCalendarDesc.BOSError = null;
            this.fld_medHRCalendarDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRCalendarDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRCalendarDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRCalendarDesc.BOSPropertyName = "Text";
            this.fld_medHRCalendarDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRCalendarDesc.Location = new System.Drawing.Point(83, 52);
            this.fld_medHRCalendarDesc.Name = "fld_medHRCalendarDesc";
            this.fld_medHRCalendarDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRCalendarDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRCalendarDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRCalendarDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRCalendarDesc.Screen = null;
            this.fld_medHRCalendarDesc.Size = new System.Drawing.Size(862, 50);
            this.fld_medHRCalendarDesc.TabIndex = 5;
            this.fld_medHRCalendarDesc.Tag = "DC";
            // 
            // fld_lkeLookupEdit1
            // 
            this.fld_lkeLookupEdit1.BOSAllowAddNew = false;
            this.fld_lkeLookupEdit1.BOSAllowDummy = false;
            this.fld_lkeLookupEdit1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSDataMember = "HRCalendarType";
            this.fld_lkeLookupEdit1.BOSDataSource = "HRCalendars";
            this.fld_lkeLookupEdit1.BOSDescription = null;
            this.fld_lkeLookupEdit1.BOSError = null;
            this.fld_lkeLookupEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSPropertyName = "EditValue";
            this.fld_lkeLookupEdit1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.CurrentDisplayText = null;
            this.fld_lkeLookupEdit1.Location = new System.Drawing.Point(608, 28);
            this.fld_lkeLookupEdit1.Name = "fld_lkeLookupEdit1";
            this.fld_lkeLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeLookupEdit1.Screen = null;
            this.fld_lkeLookupEdit1.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeLookupEdit1.TabIndex = 3;
            this.fld_lkeLookupEdit1.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(11, 31);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel4.TabIndex = 14;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã danh sách";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(236, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel5.TabIndex = 15;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel5.Text = "Tên danh sách";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(548, 31);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel6.TabIndex = 16;
            this.fld_lblLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel6.Text = "Loại";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.Location = new System.Drawing.Point(768, 31);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(21, 13);
            this.fld_lblLabel7.TabIndex = 17;
            this.fld_lblLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel7.Text = "Năm";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Location = new System.Drawing.Point(11, 70);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel8.TabIndex = 18;
            this.fld_lblLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Text = "Diễn giải";
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
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRCalendarEntrys);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 109);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(949, 583);
            this.fld_grcGroupControl1.TabIndex = 19;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Danh sách các ngày lễ";
            // 
            // fld_dgcHRCalendarEntrys
            // 
            this.fld_dgcHRCalendarEntrys.AllowDrop = true;
            this.fld_dgcHRCalendarEntrys.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.BOSDataSource = "HRCalendarEntrys";
            this.fld_dgcHRCalendarEntrys.BOSDescription = null;
            this.fld_dgcHRCalendarEntrys.BOSError = null;
            this.fld_dgcHRCalendarEntrys.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.BOSGridType = null;
            this.fld_dgcHRCalendarEntrys.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRCalendarEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRCalendarEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRCalendarEntrys.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRCalendarEntrys.MainView = this.fld_dgvHRCalendarEntrys;
            this.fld_dgcHRCalendarEntrys.Name = "fld_dgcHRCalendarEntrys";
            this.fld_dgcHRCalendarEntrys.PrintReport = false;
            this.fld_dgcHRCalendarEntrys.Screen = null;
            this.fld_dgcHRCalendarEntrys.Size = new System.Drawing.Size(945, 559);
            this.fld_dgcHRCalendarEntrys.TabIndex = 20;
            this.fld_dgcHRCalendarEntrys.Tag = "DC";
            this.fld_dgcHRCalendarEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRCalendarEntrys});
            // 
            // fld_dgvHRCalendarEntrys
            // 
            this.fld_dgvHRCalendarEntrys.GridControl = this.fld_dgcHRCalendarEntrys;
            this.fld_dgvHRCalendarEntrys.Name = "fld_dgvHRCalendarEntrys";
            this.fld_dgvHRCalendarEntrys.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(949, 691);
            this.bosPanel1.TabIndex = 20;
            // 
            // DMHRCL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(949, 691);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRCL100";
            this.Text = "Thông tin ngày lễ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRCalendarYear1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRCalendarDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRCalendarEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRCalendarEntrys)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
