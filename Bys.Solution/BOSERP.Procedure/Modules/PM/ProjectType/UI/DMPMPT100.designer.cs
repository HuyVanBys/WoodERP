using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProjectType.UI
{
	/// <summary>
	/// Summary description for DMDE100
	/// </summary>
    partial class DMPMPT100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtPMProjectTypeNo1;
		private BOSComponent.BOSTextBox fld_txtPMProjectTypeName1;
        private BOSComponent.BOSMemoEdit fld_medPMProjectTypeDesc;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSButton fld_btnEditPhaseType;
		private BOSComponent.BOSButton fld_btnAddPhaseType;
        private BOSComponent.BOSButton fld_btnDeletePhaseType;
		private BOSComponent.BOSTextBox fld_txtPMPhaseTypeName;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;


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
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMProjectTypeNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPMProjectTypeName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medPMProjectTypeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnEditPhaseType = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddPhaseType = new BOSComponent.BOSButton(this.components);
            this.fld_btnDeletePhaseType = new BOSComponent.BOSButton(this.components);
            this.fld_txtPMPhaseTypeName = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcPMPhaseTypes = new BOSERP.Modules.ProjectType.PMPhaseTypesGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtPMPhaseTypeNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMProjectTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMPhaseTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeNo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectTypeNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtPMProjectTypeName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medPMProjectTypeDesc);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(867, 130);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
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
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(10, 33);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã loại dự án";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(279, 33);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Tên loại dự án";
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
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(13, 58);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtPMProjectTypeNo1
            // 
            this.fld_txtPMProjectTypeNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeNo1.BOSDataMember = "PMProjectTypeNo";
            this.fld_txtPMProjectTypeNo1.BOSDataSource = "PMProjectTypes";
            this.fld_txtPMProjectTypeNo1.BOSDescription = null;
            this.fld_txtPMProjectTypeNo1.BOSError = "Loại dự án không thể rỗng.";
            this.fld_txtPMProjectTypeNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeNo1.BOSPropertyName = "Text";
            this.fld_txtPMProjectTypeNo1.Location = new System.Drawing.Point(80, 30);
            this.fld_txtPMProjectTypeNo1.Name = "fld_txtPMProjectTypeNo1";
            this.fld_txtPMProjectTypeNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectTypeNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectTypeNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectTypeNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectTypeNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectTypeNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectTypeNo1.Screen = null;
            this.fld_txtPMProjectTypeNo1.Size = new System.Drawing.Size(180, 20);
            this.fld_txtPMProjectTypeNo1.TabIndex = 1;
            this.fld_txtPMProjectTypeNo1.Tag = "DC";
            // 
            // fld_txtPMProjectTypeName1
            // 
            this.fld_txtPMProjectTypeName1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeName1.BOSDataMember = "PMProjectTypeName";
            this.fld_txtPMProjectTypeName1.BOSDataSource = "PMProjectTypes";
            this.fld_txtPMProjectTypeName1.BOSDescription = null;
            this.fld_txtPMProjectTypeName1.BOSError = "Tên loại dự án không thể rỗng";
            this.fld_txtPMProjectTypeName1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeName1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeName1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMProjectTypeName1.BOSPropertyName = "Text";
            this.fld_txtPMProjectTypeName1.Location = new System.Drawing.Point(353, 30);
            this.fld_txtPMProjectTypeName1.Name = "fld_txtPMProjectTypeName1";
            this.fld_txtPMProjectTypeName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMProjectTypeName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMProjectTypeName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMProjectTypeName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMProjectTypeName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMProjectTypeName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMProjectTypeName1.Screen = null;
            this.fld_txtPMProjectTypeName1.Size = new System.Drawing.Size(488, 20);
            this.fld_txtPMProjectTypeName1.TabIndex = 2;
            this.fld_txtPMProjectTypeName1.Tag = "DC";
            // 
            // fld_medPMProjectTypeDesc
            // 
            this.fld_medPMProjectTypeDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medPMProjectTypeDesc.BOSDataMember = "PMProjectTypeDesc";
            this.fld_medPMProjectTypeDesc.BOSDataSource = "PMProjectTypes";
            this.fld_medPMProjectTypeDesc.BOSDescription = null;
            this.fld_medPMProjectTypeDesc.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_medPMProjectTypeDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medPMProjectTypeDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medPMProjectTypeDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medPMProjectTypeDesc.BOSPropertyName = "Text";
            this.fld_medPMProjectTypeDesc.Location = new System.Drawing.Point(80, 55);
            this.fld_medPMProjectTypeDesc.Name = "fld_medPMProjectTypeDesc";
            this.fld_medPMProjectTypeDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medPMProjectTypeDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medPMProjectTypeDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medPMProjectTypeDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medPMProjectTypeDesc.Screen = null;
            this.fld_medPMProjectTypeDesc.Size = new System.Drawing.Size(761, 60);
            this.fld_medPMProjectTypeDesc.TabIndex = 3;
            this.fld_medPMProjectTypeDesc.Tag = "DC";
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
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(11, 60);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel8.TabIndex = 18;
            this.fld_lblLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel8.Text = "Tên giai đoạn";
            // 
            // fld_btnEditPhaseType
            // 
            this.fld_btnEditPhaseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEditPhaseType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEditPhaseType.Appearance.Options.UseForeColor = true;
            this.fld_btnEditPhaseType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnEditPhaseType.BOSDataMember = null;
            this.fld_btnEditPhaseType.BOSDataSource = null;
            this.fld_btnEditPhaseType.BOSDescription = null;
            this.fld_btnEditPhaseType.BOSError = null;
            this.fld_btnEditPhaseType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnEditPhaseType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnEditPhaseType.BOSPrivilege = "EditCategory";
            this.fld_btnEditPhaseType.BOSPropertyName = null;
            this.fld_btnEditPhaseType.Location = new System.Drawing.Point(685, 98);
            this.fld_btnEditPhaseType.Name = "fld_btnEditPhaseType";
            this.fld_btnEditPhaseType.Screen = null;
            this.fld_btnEditPhaseType.Size = new System.Drawing.Size(75, 26);
            this.fld_btnEditPhaseType.TabIndex = 4;
            this.fld_btnEditPhaseType.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnEditPhaseType.Text = "Sửa";
            this.fld_btnEditPhaseType.Click += new System.EventHandler(this.fld_btnEditPhaseType_Click);
            // 
            // fld_btnAddPhaseType
            // 
            this.fld_btnAddPhaseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddPhaseType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddPhaseType.Appearance.Options.UseForeColor = true;
            this.fld_btnAddPhaseType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddPhaseType.BOSDataMember = null;
            this.fld_btnAddPhaseType.BOSDataSource = null;
            this.fld_btnAddPhaseType.BOSDescription = null;
            this.fld_btnAddPhaseType.BOSError = null;
            this.fld_btnAddPhaseType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddPhaseType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddPhaseType.BOSPrivilege = "AddCategory";
            this.fld_btnAddPhaseType.BOSPropertyName = null;
            this.fld_btnAddPhaseType.Location = new System.Drawing.Point(598, 97);
            this.fld_btnAddPhaseType.Name = "fld_btnAddPhaseType";
            this.fld_btnAddPhaseType.Screen = null;
            this.fld_btnAddPhaseType.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAddPhaseType.TabIndex = 3;
            this.fld_btnAddPhaseType.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddPhaseType.Text = "Thêm";
            this.fld_btnAddPhaseType.Click += new System.EventHandler(this.fld_btnAddPhaseType_Click);
            // 
            // fld_btnDeletePhaseType
            // 
            this.fld_btnDeletePhaseType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDeletePhaseType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDeletePhaseType.Appearance.Options.UseForeColor = true;
            this.fld_btnDeletePhaseType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeletePhaseType.BOSDataMember = null;
            this.fld_btnDeletePhaseType.BOSDataSource = null;
            this.fld_btnDeletePhaseType.BOSDescription = null;
            this.fld_btnDeletePhaseType.BOSError = null;
            this.fld_btnDeletePhaseType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeletePhaseType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeletePhaseType.BOSPrivilege = "DeleteCategory";
            this.fld_btnDeletePhaseType.BOSPropertyName = null;
            this.fld_btnDeletePhaseType.Location = new System.Drawing.Point(767, 97);
            this.fld_btnDeletePhaseType.Name = "fld_btnDeletePhaseType";
            this.fld_btnDeletePhaseType.Screen = null;
            this.fld_btnDeletePhaseType.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDeletePhaseType.TabIndex = 5;
            this.fld_btnDeletePhaseType.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnDeletePhaseType.Text = "Xóa";
            this.fld_btnDeletePhaseType.Click += new System.EventHandler(this.fld_btnDeletePhaseType_Click);
            // 
            // fld_txtPMPhaseTypeName
            // 
            this.fld_txtPMPhaseTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtPMPhaseTypeName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeName.BOSDataMember = "PMPhaseTypeName";
            this.fld_txtPMPhaseTypeName.BOSDataSource = "PMPhaseTypes";
            this.fld_txtPMPhaseTypeName.BOSDescription = null;
            this.fld_txtPMPhaseTypeName.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeName.BOSPropertyName = "Text";
            this.fld_txtPMPhaseTypeName.Location = new System.Drawing.Point(81, 57);
            this.fld_txtPMPhaseTypeName.Name = "fld_txtPMPhaseTypeName";
            this.fld_txtPMPhaseTypeName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMPhaseTypeName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMPhaseTypeName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMPhaseTypeName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMPhaseTypeName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMPhaseTypeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMPhaseTypeName.Screen = null;
            this.fld_txtPMPhaseTypeName.Size = new System.Drawing.Size(761, 20);
            this.fld_txtPMPhaseTypeName.TabIndex = 2;
            this.fld_txtPMPhaseTypeName.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcPMPhaseTypes);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnEditPhaseType);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddPhaseType);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnDeletePhaseType);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtPMPhaseTypeNo);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtPMPhaseTypeName);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(2, 139);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(868, 499);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Text = "Danh sách giai đoạn";
            // 
            // fld_dgcPMPhaseTypes
            // 
            this.fld_dgcPMPhaseTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPMPhaseTypes.BOSComment = null;
            this.fld_dgcPMPhaseTypes.BOSDataMember = null;
            this.fld_dgcPMPhaseTypes.BOSDataSource = "PMPhaseTypes";
            this.fld_dgcPMPhaseTypes.BOSDescription = null;
            this.fld_dgcPMPhaseTypes.BOSError = null;
            this.fld_dgcPMPhaseTypes.BOSFieldGroup = null;
            this.fld_dgcPMPhaseTypes.BOSFieldRelation = null;
            this.fld_dgcPMPhaseTypes.BOSGridType = null;
            this.fld_dgcPMPhaseTypes.BOSPrivilege = null;
            this.fld_dgcPMPhaseTypes.BOSPropertyName = null;
            this.fld_dgcPMPhaseTypes.Location = new System.Drawing.Point(10, 130);
            this.fld_dgcPMPhaseTypes.MenuManager = this.screenToolbar;
            this.fld_dgcPMPhaseTypes.Name = "fld_dgcPMPhaseTypes";
            this.fld_dgcPMPhaseTypes.PrintReport = false;
            this.fld_dgcPMPhaseTypes.Screen = null;
            this.fld_dgcPMPhaseTypes.Size = new System.Drawing.Size(853, 360);
            this.fld_dgcPMPhaseTypes.TabIndex = 0;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(11, 32);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(60, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Mã giai đoạn";
            // 
            // fld_txtPMPhaseTypeNo
            // 
            this.fld_txtPMPhaseTypeNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeNo.BOSDataMember = "PMPhaseTypeNo";
            this.fld_txtPMPhaseTypeNo.BOSDataSource = "PMPhaseTypes";
            this.fld_txtPMPhaseTypeNo.BOSDescription = null;
            this.fld_txtPMPhaseTypeNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtPMPhaseTypeNo.BOSPropertyName = "Text";
            this.fld_txtPMPhaseTypeNo.Location = new System.Drawing.Point(81, 29);
            this.fld_txtPMPhaseTypeNo.Name = "fld_txtPMPhaseTypeNo";
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPMPhaseTypeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPMPhaseTypeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPMPhaseTypeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPMPhaseTypeNo.Screen = null;
            this.fld_txtPMPhaseTypeNo.Size = new System.Drawing.Size(180, 20);
            this.fld_txtPMPhaseTypeNo.TabIndex = 1;
            this.fld_txtPMPhaseTypeNo.Tag = "DC";
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
            this.bosPanel1.Size = new System.Drawing.Size(882, 641);
            this.bosPanel1.TabIndex = 29;
            // 
            // DMPMPT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(882, 641);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPMPT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMProjectTypeName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medPMProjectTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPMPhaseTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPMPhaseTypeNo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtPMPhaseTypeNo;
        private PMPhaseTypesGridControl fld_dgcPMPhaseTypes;
	}
}
