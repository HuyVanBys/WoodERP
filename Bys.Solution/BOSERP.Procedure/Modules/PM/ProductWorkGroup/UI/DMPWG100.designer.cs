using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductWorkGroup.UI
{
	/// <summary>
    /// Summary description for DMPWG100
	/// </summary>
    partial class DMPWG100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtICProductWorkGroupNo1;
		private BOSComponent.BOSTextBox fld_txtICProductWorkGroupName1;
        private BOSComponent.BOSMemoEdit fld_medICProductWorkGroupDesc;


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
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMPhaseTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWorkGroupNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWorkGroupName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICProductWorkGroupDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductWorkGroupDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_PMPhaseTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICProductWorkGroupNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICProductWorkGroupName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medICProductWorkGroupDesc);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(727, 192);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "ICProductWorkGroups";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(111, 87);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 3;
            this.fld_lkeFK_PMProjectTypeID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(10, 90);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(50, 13);
            this.bosLabel1.TabIndex = 132;
            this.bosLabel1.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.Text = "Loại dự án";
            // 
            // fld_lkeFK_PMPhaseTypeID
            // 
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMPhaseTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMPhaseTypeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSDataMember = "FK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.BOSDataSource = "ICProductWorkGroups";
            this.fld_lkeFK_PMPhaseTypeID.BOSDescription = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSError = null;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMPhaseTypeID.Location = new System.Drawing.Point(111, 113);
            this.fld_lkeFK_PMPhaseTypeID.Name = "fld_lkeFK_PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMPhaseTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMPhaseTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMPhaseTypeName", 300, "Giai đoạn")});
            this.fld_lkeFK_PMPhaseTypeID.Properties.DisplayMember = "PMPhaseTypeName";
            this.fld_lkeFK_PMPhaseTypeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_PMPhaseTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMPhaseTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMPhaseTypeID.Properties.ValueMember = "PMPhaseTypeID";
            this.fld_lkeFK_PMPhaseTypeID.Screen = null;
            this.fld_lkeFK_PMPhaseTypeID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_PMPhaseTypeID.TabIndex = 4;
            this.fld_lkeFK_PMPhaseTypeID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(10, 116);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(46, 13);
            this.bosLabel3.TabIndex = 130;
            this.bosLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.Text = "Giai đoạn";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(10, 33);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(91, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel2.Text = "Mã nhóm công việc";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(10, 64);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(95, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel3.Text = "Tên nhóm công việc";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(10, 142);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtICProductWorkGroupNo1
            // 
            this.fld_txtICProductWorkGroupNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupNo1.BOSDataMember = "ICProductWorkGroupNo";
            this.fld_txtICProductWorkGroupNo1.BOSDataSource = "ICProductWorkGroups";
            this.fld_txtICProductWorkGroupNo1.BOSDescription = null;
            this.fld_txtICProductWorkGroupNo1.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupNo1.BOSPropertyName = "Text";
            this.fld_txtICProductWorkGroupNo1.Location = new System.Drawing.Point(111, 30);
            this.fld_txtICProductWorkGroupNo1.Name = "fld_txtICProductWorkGroupNo1";
            this.fld_txtICProductWorkGroupNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWorkGroupNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWorkGroupNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWorkGroupNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWorkGroupNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWorkGroupNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductWorkGroupNo1.Screen = null;
            this.fld_txtICProductWorkGroupNo1.Size = new System.Drawing.Size(199, 20);
            this.fld_txtICProductWorkGroupNo1.TabIndex = 1;
            this.fld_txtICProductWorkGroupNo1.Tag = "DC";
            // 
            // fld_txtICProductWorkGroupName1
            // 
            this.fld_txtICProductWorkGroupName1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupName1.BOSDataMember = "ICProductWorkGroupName";
            this.fld_txtICProductWorkGroupName1.BOSDataSource = "ICProductWorkGroups";
            this.fld_txtICProductWorkGroupName1.BOSDescription = null;
            this.fld_txtICProductWorkGroupName1.BOSError = "Tên nhóm công việc không thể rỗng";
            this.fld_txtICProductWorkGroupName1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupName1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupName1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductWorkGroupName1.BOSPropertyName = "Text";
            this.fld_txtICProductWorkGroupName1.Location = new System.Drawing.Point(111, 61);
            this.fld_txtICProductWorkGroupName1.Name = "fld_txtICProductWorkGroupName1";
            this.fld_txtICProductWorkGroupName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWorkGroupName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWorkGroupName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWorkGroupName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWorkGroupName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWorkGroupName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductWorkGroupName1.Screen = null;
            this.fld_txtICProductWorkGroupName1.Size = new System.Drawing.Size(488, 20);
            this.fld_txtICProductWorkGroupName1.TabIndex = 2;
            this.fld_txtICProductWorkGroupName1.Tag = "DC";
            // 
            // fld_medICProductWorkGroupDesc
            // 
            this.fld_medICProductWorkGroupDesc.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductWorkGroupDesc.BOSDataMember = "ICProductWorkGroupDesc";
            this.fld_medICProductWorkGroupDesc.BOSDataSource = "ICProductWorkGroups";
            this.fld_medICProductWorkGroupDesc.BOSDescription = null;
            this.fld_medICProductWorkGroupDesc.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductWorkGroupDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductWorkGroupDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductWorkGroupDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductWorkGroupDesc.BOSPropertyName = "Text";
            this.fld_medICProductWorkGroupDesc.Location = new System.Drawing.Point(111, 139);
            this.fld_medICProductWorkGroupDesc.Name = "fld_medICProductWorkGroupDesc";
            this.fld_medICProductWorkGroupDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductWorkGroupDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductWorkGroupDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductWorkGroupDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductWorkGroupDesc.Screen = null;
            this.fld_medICProductWorkGroupDesc.Size = new System.Drawing.Size(488, 38);
            this.fld_medICProductWorkGroupDesc.TabIndex = 5;
            this.fld_medICProductWorkGroupDesc.Tag = "DC";
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
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(742, 482);
            this.bosPanel1.TabIndex = 29;
            // 
            // DMPWG100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(742, 482);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPWG100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMPhaseTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWorkGroupName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductWorkGroupDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMPhaseTypeID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
