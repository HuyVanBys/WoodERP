using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Department.UI
{
	/// <summary>
	/// Summary description for DMDE100
	/// </summary>
	partial class DMDE100
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtICDepartmentNo1;
		private BOSComponent.BOSTextBox fld_txtICDepartmentName1;
		private BOSComponent.BOSMemoEdit fld_medICDepartmentDesc;
		private BOSComponent.BOSCheckEdit fld_chkICDepartmentActiveCheck;
		private BOSComponent.BOSLabel fld_lblLabel8;
		private BOSComponent.BOSButton fld_btnButton;
		private BOSComponent.BOSButton fld_btnButton1;
		private BOSComponent.BOSButton fld_btnButton2;
		private ICProductGroupsTreeListControl fld_trlICProductGroups;
		private BOSComponent.BOSTextBox fld_txtICProductGroupName;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl2;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSComboBox fld_cmbAttributes;
		private ICDepartmentAttributeValuesGridControl fld_dgcICDepartmentAttributeValues;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICDepartmentAttributeValues;
		private BOSComponent.BOSButton fld_btnButton4;
        private BOSComponent.BOSButton fld_btnButton5;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMDE100));
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICDepartmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICDepartmentName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICDepartmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_chkICDepartmentActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnButton = new BOSComponent.BOSButton(this.components);
            this.fld_btnButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_trlICProductGroups = new BOSERP.Modules.Department.ICProductGroupsTreeListControl();
            this.fld_txtICProductGroupName = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductGroupConfigGroupNoLength = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductGroupConfigLength = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductGroupConfigStart = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductGroupIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_cmbAttributes = new BOSComponent.BOSComboBox(this.components);
            this.fld_dgcICDepartmentAttributeValues = new BOSERP.Modules.Department.ICDepartmentAttributeValuesGridControl();
            this.fld_dgvICDepartmentAttributeValues = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnButton4 = new BOSComponent.BOSButton(this.components);
            this.fld_btnButton5 = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICDepartmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICDepartmentActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigGroupNoLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductGroupIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbAttributes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartmentAttributeValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartmentAttributeValues)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICDepartmentNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtICDepartmentName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medICDepartmentDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_chkICDepartmentActiveCheck);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(929, 150);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
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
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(10, 33);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã ngành";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(306, 33);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Tên ngành";
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
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(10, 78);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 8;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtICDepartmentNo1
            // 
            this.fld_txtICDepartmentNo1.BOSComment = "";
            this.fld_txtICDepartmentNo1.BOSDataMember = "ICDepartmentNo";
            this.fld_txtICDepartmentNo1.BOSDataSource = "ICDepartments";
            this.fld_txtICDepartmentNo1.BOSDescription = null;
            this.fld_txtICDepartmentNo1.BOSError = "Mã ngành không thể rỗng.";
            this.fld_txtICDepartmentNo1.BOSFieldGroup = "";
            this.fld_txtICDepartmentNo1.BOSFieldRelation = "";
            this.fld_txtICDepartmentNo1.BOSPrivilege = "";
            this.fld_txtICDepartmentNo1.BOSPropertyName = "Text";
            this.fld_txtICDepartmentNo1.Location = new System.Drawing.Point(77, 30);
            this.fld_txtICDepartmentNo1.Name = "fld_txtICDepartmentNo1";
            this.fld_txtICDepartmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDepartmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDepartmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDepartmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDepartmentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDepartmentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDepartmentNo1.Screen = null;
            this.fld_txtICDepartmentNo1.Size = new System.Drawing.Size(180, 20);
            this.fld_txtICDepartmentNo1.TabIndex = 0;
            this.fld_txtICDepartmentNo1.Tag = "DC";
            // 
            // fld_txtICDepartmentName1
            // 
            this.fld_txtICDepartmentName1.BOSComment = "";
            this.fld_txtICDepartmentName1.BOSDataMember = "ICDepartmentName";
            this.fld_txtICDepartmentName1.BOSDataSource = "ICDepartments";
            this.fld_txtICDepartmentName1.BOSDescription = null;
            this.fld_txtICDepartmentName1.BOSError = "Tên ngành không thể rỗng";
            this.fld_txtICDepartmentName1.BOSFieldGroup = "";
            this.fld_txtICDepartmentName1.BOSFieldRelation = "";
            this.fld_txtICDepartmentName1.BOSPrivilege = "";
            this.fld_txtICDepartmentName1.BOSPropertyName = "Text";
            this.fld_txtICDepartmentName1.Location = new System.Drawing.Point(419, 30);
            this.fld_txtICDepartmentName1.Name = "fld_txtICDepartmentName1";
            this.fld_txtICDepartmentName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICDepartmentName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICDepartmentName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICDepartmentName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICDepartmentName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICDepartmentName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICDepartmentName1.Screen = null;
            this.fld_txtICDepartmentName1.Size = new System.Drawing.Size(271, 20);
            this.fld_txtICDepartmentName1.TabIndex = 1;
            this.fld_txtICDepartmentName1.Tag = "DC";
            // 
            // fld_medICDepartmentDesc
            // 
            this.fld_medICDepartmentDesc.BOSComment = "";
            this.fld_medICDepartmentDesc.BOSDataMember = "ICDepartmentDesc";
            this.fld_medICDepartmentDesc.BOSDataSource = "ICDepartments";
            this.fld_medICDepartmentDesc.BOSDescription = null;
            this.fld_medICDepartmentDesc.BOSError = "";
            this.fld_medICDepartmentDesc.BOSFieldGroup = "";
            this.fld_medICDepartmentDesc.BOSFieldRelation = "";
            this.fld_medICDepartmentDesc.BOSPrivilege = "";
            this.fld_medICDepartmentDesc.BOSPropertyName = "Text";
            this.fld_medICDepartmentDesc.Location = new System.Drawing.Point(77, 55);
            this.fld_medICDepartmentDesc.Name = "fld_medICDepartmentDesc";
            this.fld_medICDepartmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICDepartmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICDepartmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICDepartmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICDepartmentDesc.Screen = null;
            this.fld_medICDepartmentDesc.Size = new System.Drawing.Size(613, 60);
            this.fld_medICDepartmentDesc.TabIndex = 2;
            this.fld_medICDepartmentDesc.Tag = "DC";
            // 
            // fld_chkICDepartmentActiveCheck
            // 
            this.fld_chkICDepartmentActiveCheck.BOSComment = "";
            this.fld_chkICDepartmentActiveCheck.BOSDataMember = "ICDepartmentActiveCheck";
            this.fld_chkICDepartmentActiveCheck.BOSDataSource = "ICDepartments";
            this.fld_chkICDepartmentActiveCheck.BOSDescription = null;
            this.fld_chkICDepartmentActiveCheck.BOSError = "";
            this.fld_chkICDepartmentActiveCheck.BOSFieldGroup = "";
            this.fld_chkICDepartmentActiveCheck.BOSFieldRelation = "";
            this.fld_chkICDepartmentActiveCheck.BOSPrivilege = "";
            this.fld_chkICDepartmentActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkICDepartmentActiveCheck.Location = new System.Drawing.Point(75, 118);
            this.fld_chkICDepartmentActiveCheck.Name = "fld_chkICDepartmentActiveCheck";
            this.fld_chkICDepartmentActiveCheck.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICDepartmentActiveCheck.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICDepartmentActiveCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICDepartmentActiveCheck.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICDepartmentActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICDepartmentActiveCheck.Screen = null;
            this.fld_chkICDepartmentActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICDepartmentActiveCheck.TabIndex = 4;
            this.fld_chkICDepartmentActiveCheck.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(14, 59);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel8.TabIndex = 18;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Tên nhóm";
            // 
            // fld_btnButton
            // 
            this.fld_btnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnButton.Appearance.Options.UseForeColor = true;
            this.fld_btnButton.BOSComment = "";
            this.fld_btnButton.BOSDataMember = null;
            this.fld_btnButton.BOSDataSource = null;
            this.fld_btnButton.BOSDescription = null;
            this.fld_btnButton.BOSError = null;
            this.fld_btnButton.BOSFieldGroup = "";
            this.fld_btnButton.BOSFieldRelation = "";
            this.fld_btnButton.BOSPrivilege = "EditCategory";
            this.fld_btnButton.BOSPropertyName = null;
            this.fld_btnButton.Location = new System.Drawing.Point(304, 213);
            this.fld_btnButton.Name = "fld_btnButton";
            this.fld_btnButton.Screen = null;
            this.fld_btnButton.Size = new System.Drawing.Size(75, 26);
            this.fld_btnButton.TabIndex = 4;
            this.fld_btnButton.Tag = "";
            this.fld_btnButton.Text = "Sửa";
            this.fld_btnButton.Click += new System.EventHandler(this.fld_btnButton_Click);
            // 
            // fld_btnButton1
            // 
            this.fld_btnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnButton1.Appearance.Options.UseForeColor = true;
            this.fld_btnButton1.BOSComment = "";
            this.fld_btnButton1.BOSDataMember = null;
            this.fld_btnButton1.BOSDataSource = null;
            this.fld_btnButton1.BOSDescription = null;
            this.fld_btnButton1.BOSError = null;
            this.fld_btnButton1.BOSFieldGroup = "";
            this.fld_btnButton1.BOSFieldRelation = "";
            this.fld_btnButton1.BOSPrivilege = "AddCategory";
            this.fld_btnButton1.BOSPropertyName = null;
            this.fld_btnButton1.Location = new System.Drawing.Point(222, 213);
            this.fld_btnButton1.Name = "fld_btnButton1";
            this.fld_btnButton1.Screen = null;
            this.fld_btnButton1.Size = new System.Drawing.Size(75, 27);
            this.fld_btnButton1.TabIndex = 3;
            this.fld_btnButton1.Tag = "";
            this.fld_btnButton1.Text = "Thêm";
            this.fld_btnButton1.Click += new System.EventHandler(this.fld_btnButton1_Click);
            // 
            // fld_btnButton2
            // 
            this.fld_btnButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnButton2.Appearance.Options.UseForeColor = true;
            this.fld_btnButton2.BOSComment = "";
            this.fld_btnButton2.BOSDataMember = null;
            this.fld_btnButton2.BOSDataSource = null;
            this.fld_btnButton2.BOSDescription = null;
            this.fld_btnButton2.BOSError = null;
            this.fld_btnButton2.BOSFieldGroup = "";
            this.fld_btnButton2.BOSFieldRelation = "";
            this.fld_btnButton2.BOSPrivilege = "DeleteCategory";
            this.fld_btnButton2.BOSPropertyName = null;
            this.fld_btnButton2.Location = new System.Drawing.Point(385, 212);
            this.fld_btnButton2.Name = "fld_btnButton2";
            this.fld_btnButton2.Screen = null;
            this.fld_btnButton2.Size = new System.Drawing.Size(75, 27);
            this.fld_btnButton2.TabIndex = 5;
            this.fld_btnButton2.Tag = "";
            this.fld_btnButton2.Text = "Xóa";
            this.fld_btnButton2.Click += new System.EventHandler(this.fld_btnButton2_Click);
            // 
            // fld_trlICProductGroups
            // 
            this.fld_trlICProductGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlICProductGroups.BOSComment = "";
            this.fld_trlICProductGroups.BOSDataMember = null;
            this.fld_trlICProductGroups.BOSDataSource = "ICProductGroups";
            this.fld_trlICProductGroups.BOSDescription = null;
            this.fld_trlICProductGroups.BOSDisplayOption = false;
            this.fld_trlICProductGroups.BOSDisplayRoot = true;
            this.fld_trlICProductGroups.BOSError = "";
            this.fld_trlICProductGroups.BOSFieldGroup = "";
            this.fld_trlICProductGroups.BOSFieldRelation = null;
            this.fld_trlICProductGroups.BOSPrivilege = "";
            this.fld_trlICProductGroups.BOSPropertyName = null;
            this.fld_trlICProductGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlICProductGroups.Location = new System.Drawing.Point(14, 254);
            this.fld_trlICProductGroups.Name = "fld_trlICProductGroups";
            this.fld_trlICProductGroups.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlICProductGroups.Screen = null;
            this.fld_trlICProductGroups.Size = new System.Drawing.Size(446, 377);
            this.fld_trlICProductGroups.TabIndex = 6;
            this.fld_trlICProductGroups.Tag = "DC";
            // 
            // fld_txtICProductGroupName
            // 
            this.fld_txtICProductGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICProductGroupName.BOSComment = "";
            this.fld_txtICProductGroupName.BOSDataMember = "ICProductGroupName";
            this.fld_txtICProductGroupName.BOSDataSource = "ICProductGroups";
            this.fld_txtICProductGroupName.BOSDescription = null;
            this.fld_txtICProductGroupName.BOSError = "";
            this.fld_txtICProductGroupName.BOSFieldGroup = "";
            this.fld_txtICProductGroupName.BOSFieldRelation = "";
            this.fld_txtICProductGroupName.BOSPrivilege = "";
            this.fld_txtICProductGroupName.BOSPropertyName = "Text";
            this.fld_txtICProductGroupName.Location = new System.Drawing.Point(136, 57);
            this.fld_txtICProductGroupName.Name = "fld_txtICProductGroupName";
            this.fld_txtICProductGroupName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGroupName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGroupName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGroupName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGroupName.Screen = null;
            this.fld_txtICProductGroupName.Size = new System.Drawing.Size(324, 20);
            this.fld_txtICProductGroupName.TabIndex = 1;
            this.fld_txtICProductGroupName.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductGroupConfigGroupNoLength);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductGroupConfigLength);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductGroupConfigStart);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_chkICProductGroupIsShowWeb);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnButton);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnButton1);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnButton2);
            this.fld_grcGroupControl1.Controls.Add(this.fld_trlICProductGroups);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductGroupNo);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductGroupName);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(2, 155);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(486, 657);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Text = "Danh sách nhóm hàng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(14, 163);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(116, 13);
            this.bosLabel5.TabIndex = 351;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Độ dài ký tự Nhóm hàng";
            // 
            // fld_txtICProductGroupConfigGroupNoLength
            // 
            this.fld_txtICProductGroupConfigGroupNoLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICProductGroupConfigGroupNoLength.BOSComment = "";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSDataMember = "ICProductGroupConfigGroupNoLength";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSDataSource = "ICProductGroups";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSDescription = null;
            this.fld_txtICProductGroupConfigGroupNoLength.BOSError = "";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSFieldGroup = "";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSFieldRelation = "";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSPrivilege = "";
            this.fld_txtICProductGroupConfigGroupNoLength.BOSPropertyName = "Text";
            this.fld_txtICProductGroupConfigGroupNoLength.Location = new System.Drawing.Point(136, 161);
            this.fld_txtICProductGroupConfigGroupNoLength.Name = "fld_txtICProductGroupConfigGroupNoLength";
            this.fld_txtICProductGroupConfigGroupNoLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGroupConfigGroupNoLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGroupConfigGroupNoLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGroupConfigGroupNoLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGroupConfigGroupNoLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGroupConfigGroupNoLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGroupConfigGroupNoLength.Screen = null;
            this.fld_txtICProductGroupConfigGroupNoLength.Size = new System.Drawing.Size(324, 20);
            this.fld_txtICProductGroupConfigGroupNoLength.TabIndex = 350;
            this.fld_txtICProductGroupConfigGroupNoLength.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(14, 137);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 349;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Độ dài số";
            // 
            // fld_txtICProductGroupConfigLength
            // 
            this.fld_txtICProductGroupConfigLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICProductGroupConfigLength.BOSComment = "";
            this.fld_txtICProductGroupConfigLength.BOSDataMember = "ICProductGroupConfigLength";
            this.fld_txtICProductGroupConfigLength.BOSDataSource = "ICProductGroups";
            this.fld_txtICProductGroupConfigLength.BOSDescription = null;
            this.fld_txtICProductGroupConfigLength.BOSError = "";
            this.fld_txtICProductGroupConfigLength.BOSFieldGroup = "";
            this.fld_txtICProductGroupConfigLength.BOSFieldRelation = "";
            this.fld_txtICProductGroupConfigLength.BOSPrivilege = "";
            this.fld_txtICProductGroupConfigLength.BOSPropertyName = "Text";
            this.fld_txtICProductGroupConfigLength.Location = new System.Drawing.Point(136, 135);
            this.fld_txtICProductGroupConfigLength.Name = "fld_txtICProductGroupConfigLength";
            this.fld_txtICProductGroupConfigLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGroupConfigLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGroupConfigLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGroupConfigLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGroupConfigLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGroupConfigLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGroupConfigLength.Screen = null;
            this.fld_txtICProductGroupConfigLength.Size = new System.Drawing.Size(324, 20);
            this.fld_txtICProductGroupConfigLength.TabIndex = 348;
            this.fld_txtICProductGroupConfigLength.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(14, 111);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 347;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Số tự động";
            // 
            // fld_txtICProductGroupConfigStart
            // 
            this.fld_txtICProductGroupConfigStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICProductGroupConfigStart.BOSComment = "";
            this.fld_txtICProductGroupConfigStart.BOSDataMember = "ICProductGroupConfigStart";
            this.fld_txtICProductGroupConfigStart.BOSDataSource = "ICProductGroups";
            this.fld_txtICProductGroupConfigStart.BOSDescription = null;
            this.fld_txtICProductGroupConfigStart.BOSError = "";
            this.fld_txtICProductGroupConfigStart.BOSFieldGroup = "";
            this.fld_txtICProductGroupConfigStart.BOSFieldRelation = "";
            this.fld_txtICProductGroupConfigStart.BOSPrivilege = "";
            this.fld_txtICProductGroupConfigStart.BOSPropertyName = "Text";
            this.fld_txtICProductGroupConfigStart.Location = new System.Drawing.Point(136, 109);
            this.fld_txtICProductGroupConfigStart.Name = "fld_txtICProductGroupConfigStart";
            this.fld_txtICProductGroupConfigStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGroupConfigStart.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGroupConfigStart.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGroupConfigStart.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGroupConfigStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGroupConfigStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGroupConfigStart.Screen = null;
            this.fld_txtICProductGroupConfigStart.Size = new System.Drawing.Size(324, 20);
            this.fld_txtICProductGroupConfigStart.TabIndex = 346;
            this.fld_txtICProductGroupConfigStart.Tag = "DC";
            // 
            // fld_lkeFK_ICProductTypeAccountConfigID
            // 
            this.fld_lkeFK_ICProductTypeAccountConfigID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSComment = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataMember = "FK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataSource = "ICProductGroups";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSError = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectType = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(136, 83);
            this.fld_lkeFK_ICProductTypeAccountConfigID.Name = "fld_lkeFK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.DisplayMember = "ICProductTypeAccountConfigName";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.NullText = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ValueMember = "ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(324, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 345;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(14, 88);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(74, 13);
            this.bosLabel2.TabIndex = 19;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Nhóm tài khoản";
            // 
            // fld_chkICProductGroupIsShowWeb
            // 
            this.fld_chkICProductGroupIsShowWeb.BOSComment = "";
            this.fld_chkICProductGroupIsShowWeb.BOSDataMember = "ICProductGroupIsShowWeb";
            this.fld_chkICProductGroupIsShowWeb.BOSDataSource = "ICProductGroups";
            this.fld_chkICProductGroupIsShowWeb.BOSDescription = null;
            this.fld_chkICProductGroupIsShowWeb.BOSError = "";
            this.fld_chkICProductGroupIsShowWeb.BOSFieldGroup = "";
            this.fld_chkICProductGroupIsShowWeb.BOSFieldRelation = "";
            this.fld_chkICProductGroupIsShowWeb.BOSPrivilege = "";
            this.fld_chkICProductGroupIsShowWeb.BOSPropertyName = "EditValue";
            this.fld_chkICProductGroupIsShowWeb.Location = new System.Drawing.Point(136, 188);
            this.fld_chkICProductGroupIsShowWeb.Name = "fld_chkICProductGroupIsShowWeb";
            this.fld_chkICProductGroupIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductGroupIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductGroupIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductGroupIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductGroupIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductGroupIsShowWeb.Screen = null;
            this.fld_chkICProductGroupIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductGroupIsShowWeb.TabIndex = 2;
            this.fld_chkICProductGroupIsShowWeb.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(14, 31);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(43, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã nhóm";
            // 
            // fld_txtICProductGroupNo
            // 
            this.fld_txtICProductGroupNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICProductGroupNo.BOSComment = "";
            this.fld_txtICProductGroupNo.BOSDataMember = "ICProductGroupNo";
            this.fld_txtICProductGroupNo.BOSDataSource = "ICProductGroups";
            this.fld_txtICProductGroupNo.BOSDescription = null;
            this.fld_txtICProductGroupNo.BOSError = "";
            this.fld_txtICProductGroupNo.BOSFieldGroup = "";
            this.fld_txtICProductGroupNo.BOSFieldRelation = "";
            this.fld_txtICProductGroupNo.BOSPrivilege = "";
            this.fld_txtICProductGroupNo.BOSPropertyName = "Text";
            this.fld_txtICProductGroupNo.Location = new System.Drawing.Point(136, 29);
            this.fld_txtICProductGroupNo.Name = "fld_txtICProductGroupNo";
            this.fld_txtICProductGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGroupNo.Screen = null;
            this.fld_txtICProductGroupNo.Size = new System.Drawing.Size(324, 20);
            this.fld_txtICProductGroupNo.TabIndex = 0;
            this.fld_txtICProductGroupNo.Tag = "DC";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = null;
            this.fld_grcGroupControl2.BOSDataSource = null;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = null;
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = null;
            this.fld_grcGroupControl2.Controls.Add(this.fld_lblLabel7);
            this.fld_grcGroupControl2.Controls.Add(this.fld_cmbAttributes);
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcICDepartmentAttributeValues);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnButton4);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnButton5);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(492, 155);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(440, 657);
            this.fld_grcGroupControl2.TabIndex = 2;
            this.fld_grcGroupControl2.Text = "Danh sách thuộc tính";
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
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(17, 31);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel7.TabIndex = 29;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Chọn thuộc tính";
            // 
            // fld_cmbAttributes
            // 
            this.fld_cmbAttributes.BOSComment = "";
            this.fld_cmbAttributes.BOSDataMember = "ComboBox";
            this.fld_cmbAttributes.BOSDataSource = "";
            this.fld_cmbAttributes.BOSDescription = null;
            this.fld_cmbAttributes.BOSError = "";
            this.fld_cmbAttributes.BOSFieldGroup = "";
            this.fld_cmbAttributes.BOSFieldRelation = "";
            this.fld_cmbAttributes.BOSPrivilege = "AddAttribute";
            this.fld_cmbAttributes.BOSPropertyName = "Text";
            this.fld_cmbAttributes.Location = new System.Drawing.Point(108, 29);
            this.fld_cmbAttributes.Name = "fld_cmbAttributes";
            this.fld_cmbAttributes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_cmbAttributes.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_cmbAttributes.Properties.Appearance.Options.UseBackColor = true;
            this.fld_cmbAttributes.Properties.Appearance.Options.UseForeColor = true;
            this.fld_cmbAttributes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbAttributes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fld_cmbAttributes.Screen = null;
            this.fld_cmbAttributes.Size = new System.Drawing.Size(139, 20);
            this.fld_cmbAttributes.TabIndex = 10;
            this.fld_cmbAttributes.Tag = "DC";
            // 
            // fld_dgcICDepartmentAttributeValues
            // 
            this.fld_dgcICDepartmentAttributeValues.AllowDrop = true;
            this.fld_dgcICDepartmentAttributeValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICDepartmentAttributeValues.BOSComment = "";
            this.fld_dgcICDepartmentAttributeValues.BOSDataMember = null;
            this.fld_dgcICDepartmentAttributeValues.BOSDataSource = "ICDepartmentAttributeValues";
            this.fld_dgcICDepartmentAttributeValues.BOSDescription = null;
            this.fld_dgcICDepartmentAttributeValues.BOSError = "";
            this.fld_dgcICDepartmentAttributeValues.BOSFieldGroup = "";
            this.fld_dgcICDepartmentAttributeValues.BOSFieldRelation = null;
            this.fld_dgcICDepartmentAttributeValues.BOSGridType = null;
            this.fld_dgcICDepartmentAttributeValues.BOSPrivilege = "";
            this.fld_dgcICDepartmentAttributeValues.BOSPropertyName = null;
            this.fld_dgcICDepartmentAttributeValues.CommodityType = "";
            this.fld_dgcICDepartmentAttributeValues.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICDepartmentAttributeValues.Location = new System.Drawing.Point(12, 59);
            this.fld_dgcICDepartmentAttributeValues.MainView = this.fld_dgvICDepartmentAttributeValues;
            this.fld_dgcICDepartmentAttributeValues.Name = "fld_dgcICDepartmentAttributeValues";
            this.fld_dgcICDepartmentAttributeValues.PrintReport = false;
            this.fld_dgcICDepartmentAttributeValues.Screen = null;
            this.fld_dgcICDepartmentAttributeValues.Size = new System.Drawing.Size(410, 572);
            this.fld_dgcICDepartmentAttributeValues.TabIndex = 14;
            this.fld_dgcICDepartmentAttributeValues.Tag = "DC";
            this.fld_dgcICDepartmentAttributeValues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICDepartmentAttributeValues});
            // 
            // fld_dgvICDepartmentAttributeValues
            // 
            this.fld_dgvICDepartmentAttributeValues.GridControl = this.fld_dgcICDepartmentAttributeValues;
            this.fld_dgvICDepartmentAttributeValues.Name = "fld_dgvICDepartmentAttributeValues";
            this.fld_dgvICDepartmentAttributeValues.PaintStyleName = "Office2003";
            // 
            // fld_btnButton4
            // 
            this.fld_btnButton4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnButton4.Appearance.Options.UseForeColor = true;
            this.fld_btnButton4.BOSComment = "";
            this.fld_btnButton4.BOSDataMember = null;
            this.fld_btnButton4.BOSDataSource = null;
            this.fld_btnButton4.BOSDescription = null;
            this.fld_btnButton4.BOSError = null;
            this.fld_btnButton4.BOSFieldGroup = "";
            this.fld_btnButton4.BOSFieldRelation = "";
            this.fld_btnButton4.BOSPrivilege = "EditAttribute";
            this.fld_btnButton4.BOSPropertyName = null;
            this.fld_btnButton4.Location = new System.Drawing.Point(263, 28);
            this.fld_btnButton4.Name = "fld_btnButton4";
            this.fld_btnButton4.Screen = null;
            this.fld_btnButton4.Size = new System.Drawing.Size(75, 25);
            this.fld_btnButton4.TabIndex = 11;
            this.fld_btnButton4.Tag = "";
            this.fld_btnButton4.Text = "Sửa";
            this.fld_btnButton4.Click += new System.EventHandler(this.fld_btnButton4_Click);
            // 
            // fld_btnButton5
            // 
            this.fld_btnButton5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnButton5.Appearance.Options.UseForeColor = true;
            this.fld_btnButton5.BOSComment = "";
            this.fld_btnButton5.BOSDataMember = null;
            this.fld_btnButton5.BOSDataSource = null;
            this.fld_btnButton5.BOSDescription = null;
            this.fld_btnButton5.BOSError = null;
            this.fld_btnButton5.BOSFieldGroup = "";
            this.fld_btnButton5.BOSFieldRelation = "";
            this.fld_btnButton5.BOSPrivilege = "DeleteAttribute";
            this.fld_btnButton5.BOSPropertyName = null;
            this.fld_btnButton5.Location = new System.Drawing.Point(347, 28);
            this.fld_btnButton5.Name = "fld_btnButton5";
            this.fld_btnButton5.Screen = null;
            this.fld_btnButton5.Size = new System.Drawing.Size(75, 25);
            this.fld_btnButton5.TabIndex = 12;
            this.fld_btnButton5.Tag = "";
            this.fld_btnButton5.Text = "Xóa";
            this.fld_btnButton5.Click += new System.EventHandler(this.fld_btnButton5_Click);
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(977, 848);
            this.bosPanel1.TabIndex = 29;
            // 
            // DMDE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(977, 848);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMDE100.IconOptions.Icon")));
            this.Name = "DMDE100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICDepartmentName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICDepartmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICDepartmentActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlICProductGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigGroupNoLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupConfigStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductGroupIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            this.fld_grcGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbAttributes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICDepartmentAttributeValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICDepartmentAttributeValues)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductGroupNo;
        private BOSComponent.BOSCheckEdit fld_chkICProductGroupIsShowWeb;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICProductGroupConfigGroupNoLength;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductGroupConfigLength;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductGroupConfigStart;
    }
}
