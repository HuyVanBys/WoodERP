using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration.UI
{
	/// <summary>
	/// Summary description for DMSID100
	/// </summary>
	partial class DMSID100
    {
		private BOSComponent.BOSTextBox fld_txtHRSocialInsuranceDeclarationNo1;
		private BOSComponent.BOSTextBox fld_txtHRSocialInsuranceDeclarationName1;
        private BOSComponent.BOSDateEdit fld_dteHRSocialInsuranceDeclarationDate1;
		private BOSComponent.BOSButton fld_btnAddEmployee;


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
            this.fld_txtHRSocialInsuranceDeclarationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRSocialInsuranceDeclarationName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRSocialInsuranceDeclarationDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeHRSocialInsuranceDeclarationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRSocialInsuranceDeclarationType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.TabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases = new BOSERP.Modules.HRSocialInsuranceDeclaration.HRSocialInsuranceDeclarationItemIncreasessGridControl();
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions = new BOSERP.Modules.HRSocialInsuranceDeclaration.HRSocialInsuranceDeclarationItemReductionsGridControl();
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears = new BOSERP.Modules.HRSocialInsuranceDeclaration.HRSocialInsuranceDeclarationItemArrearsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDate1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemIncreases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemReductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemArrears)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRSocialInsuranceDeclarationNo1
            // 
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSComment = "";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSDataMember = "HRSocialInsuranceDeclarationNo";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSDescription = null;
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSError = null;
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSFieldGroup = "";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSFieldRelation = "";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSPrivilege = "";
            this.fld_txtHRSocialInsuranceDeclarationNo1.BOSPropertyName = "Text";
            this.fld_txtHRSocialInsuranceDeclarationNo1.EditValue = "";
            this.fld_txtHRSocialInsuranceDeclarationNo1.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRSocialInsuranceDeclarationNo1.Name = "fld_txtHRSocialInsuranceDeclarationNo1";
            this.fld_txtHRSocialInsuranceDeclarationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRSocialInsuranceDeclarationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRSocialInsuranceDeclarationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRSocialInsuranceDeclarationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRSocialInsuranceDeclarationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRSocialInsuranceDeclarationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRSocialInsuranceDeclarationNo1.Screen = null;
            this.fld_txtHRSocialInsuranceDeclarationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRSocialInsuranceDeclarationNo1.TabIndex = 0;
            this.fld_txtHRSocialInsuranceDeclarationNo1.Tag = "DC";
            // 
            // fld_txtHRSocialInsuranceDeclarationName1
            // 
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSComment = "";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSDataMember = "HRSocialInsuranceDeclarationName";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSDescription = null;
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSError = null;
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSFieldGroup = "";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSFieldRelation = "";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSPrivilege = "";
            this.fld_txtHRSocialInsuranceDeclarationName1.BOSPropertyName = "Text";
            this.fld_txtHRSocialInsuranceDeclarationName1.EditValue = "";
            this.fld_txtHRSocialInsuranceDeclarationName1.Location = new System.Drawing.Point(203, 35);
            this.fld_txtHRSocialInsuranceDeclarationName1.Name = "fld_txtHRSocialInsuranceDeclarationName1";
            this.fld_txtHRSocialInsuranceDeclarationName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRSocialInsuranceDeclarationName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRSocialInsuranceDeclarationName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRSocialInsuranceDeclarationName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRSocialInsuranceDeclarationName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRSocialInsuranceDeclarationName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRSocialInsuranceDeclarationName1.Screen = null;
            this.fld_txtHRSocialInsuranceDeclarationName1.Size = new System.Drawing.Size(551, 20);
            this.fld_txtHRSocialInsuranceDeclarationName1.TabIndex = 2;
            this.fld_txtHRSocialInsuranceDeclarationName1.Tag = "DC";
            // 
            // fld_dteHRSocialInsuranceDeclarationDate1
            // 
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSComment = "";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSDataMember = "HRSocialInsuranceDeclarationDate";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSDescription = null;
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSError = null;
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSFieldGroup = "";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSFieldRelation = "";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSPrivilege = "";
            this.fld_dteHRSocialInsuranceDeclarationDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRSocialInsuranceDeclarationDate1.EditValue = null;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Location = new System.Drawing.Point(203, 61);
            this.fld_dteHRSocialInsuranceDeclarationDate1.Name = "fld_dteHRSocialInsuranceDeclarationDate1";
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDate1.Screen = null;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRSocialInsuranceDeclarationDate1.TabIndex = 3;
            this.fld_dteHRSocialInsuranceDeclarationDate1.Tag = "DC";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = "";
            this.fld_btnAddEmployee.BOSDataMember = "";
            this.fld_btnAddEmployee.BOSDataSource = "";
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = "";
            this.fld_btnAddEmployee.BOSFieldRelation = "";
            this.fld_btnAddEmployee.BOSPrivilege = "";
            this.fld_btnAddEmployee.BOSPropertyName = "";
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(6, 759);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 1;
            this.fld_btnAddEmployee.Tag = "";
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosPanel1.Controls.Add(this.TabControl1);
            this.bosPanel1.Controls.Add(this.fld_btnExcel);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1018, 790);
            this.bosPanel1.TabIndex = 17;
            // 
            // fld_btnExcel
            // 
            this.fld_btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnExcel.BOSComment = null;
            this.fld_btnExcel.BOSDataMember = null;
            this.fld_btnExcel.BOSDataSource = null;
            this.fld_btnExcel.BOSDescription = null;
            this.fld_btnExcel.BOSError = null;
            this.fld_btnExcel.BOSFieldGroup = null;
            this.fld_btnExcel.BOSFieldRelation = null;
            this.fld_btnExcel.BOSPrivilege = null;
            this.fld_btnExcel.BOSPropertyName = null;
            this.fld_btnExcel.Location = new System.Drawing.Point(112, 759);
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Size = new System.Drawing.Size(89, 27);
            this.fld_btnExcel.TabIndex = 3;
            this.fld_btnExcel.Text = "Xuất excel";
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeHRSocialInsuranceDeclarationStatus);
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.fld_dteHRSocialInsuranceDeclarationDate1);
            this.bosPanel2.Controls.Add(this.fld_txtHRSocialInsuranceDeclarationName1);
            this.bosPanel2.Controls.Add(this.fld_txtHRSocialInsuranceDeclarationNo1);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_pteHRSocialInsuranceDeclarationEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_lkeHRSocialInsuranceDeclarationType);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1018, 133);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeHRSocialInsuranceDeclarationStatus
            // 
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSAllowAddNew = false;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSAllowDummy = false;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSComment = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDataMember = "HRSocialInsuranceDeclarationStatus";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSDescription = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSError = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldGroup = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldParent = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSFieldRelation = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSPrivilege = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSSelectType = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.CurrentDisplayText = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Location = new System.Drawing.Point(604, 61);
            this.fld_lkeHRSocialInsuranceDeclarationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Name = "fld_lkeHRSocialInsuranceDeclarationStatus";
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.ColumnName = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties.ReadOnly = true;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Screen = null;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRSocialInsuranceDeclarationStatus.TabIndex = 4;
            this.fld_lkeHRSocialInsuranceDeclarationStatus.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "HRSocialInsuranceDeclarationDesc";
            this.bosMemoEdit1.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(203, 87);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(551, 35);
            this.bosMemoEdit1.TabIndex = 7;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRSocialInsuranceDeclarations";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteHRSocialInsuranceDeclarationEmployeePicture
            // 
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSComment = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSDataMember = "HRSocialInsuranceDeclarationEmployeePicture";
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSDescription = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSError = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.FileName = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.FilePath = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Name = "fld_pteHRSocialInsuranceDeclarationEmployeePicture";
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Screen = null;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.TabIndex = 0;
            this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(120, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(72, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tháng áp dụng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(519, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tình trạng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(519, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(66, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Loại chứng từ";
            // 
            // fld_lkeHRSocialInsuranceDeclarationType
            // 
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSAllowAddNew = false;
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSAllowDummy = false;
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSComment = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSDataMember = "HRSocialInsuranceDeclarationType";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSDescription = null;
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSError = null;
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSFieldGroup = "NonEditable";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSFieldParent = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSFieldRelation = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSPrivilege = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSPropertyName = "EditValue";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSSelectType = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.BOSSelectTypeValue = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.CurrentDisplayText = null;
            this.fld_lkeHRSocialInsuranceDeclarationType.Location = new System.Drawing.Point(604, 9);
            this.fld_lkeHRSocialInsuranceDeclarationType.Name = "fld_lkeHRSocialInsuranceDeclarationType";
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.ColumnName = null;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.NullText = "";
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.PopupWidth = 40;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.ReadOnly = true;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRSocialInsuranceDeclarationType.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeHRSocialInsuranceDeclarationType.Screen = null;
            this.fld_lkeHRSocialInsuranceDeclarationType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRSocialInsuranceDeclarationType.TabIndex = 1;
            this.fld_lkeHRSocialInsuranceDeclarationType.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã chứng từ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Tên chứng từ";
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(120, 89);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Diễn giải";
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Location = new System.Drawing.Point(3, 139);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabPage = this.xtraTabPage1;
            this.TabControl1.Size = new System.Drawing.Size(1012, 614);
            this.TabControl1.TabIndex = 5;
            this.TabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AllowTouchScroll = true;
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRSocialInsuranceDeclarationItemIncreases);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1006, 586);
            this.xtraTabPage1.Text = "Báo tăng";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AllowTouchScroll = true;
            this.xtraTabPage2.Controls.Add(this.fld_dgcHRSocialInsuranceDeclarationItemReductions);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1006, 586);
            this.xtraTabPage2.Text = "Báo giảm";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AllowTouchScroll = true;
            this.xtraTabPage3.Controls.Add(this.fld_dgcHRSocialInsuranceDeclarationItemArrears);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1006, 586);
            this.xtraTabPage3.Text = "Truy thu";
            // 
            // fld_dgcHRSocialInsuranceDeclarationItemIncreases
            // 
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSComment = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSDataMember = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSDataSource = "HRSocialInsuranceDeclarationItems";
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSDescription = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSError = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSFieldGroup = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSFieldRelation = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSGridType = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSPrivilege = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.BOSPropertyName = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.CommodityType = "";
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.GridViewMain = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.MenuManager = this.screenToolbar;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.Name = "fld_dgcHRSocialInsuranceDeclarationItemIncreases";
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.PrintReport = false;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.RowHandle = 0;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.Screen = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.Size = new System.Drawing.Size(1006, 586);
            this.fld_dgcHRSocialInsuranceDeclarationItemIncreases.TabIndex = 2;
            // 
            // fld_dgcHRSocialInsuranceDeclarationItemReductions
            // 
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSComment = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSDataMember = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSDataSource = "HRSocialInsuranceDeclarationItems";
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSDescription = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSError = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSFieldGroup = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSFieldRelation = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSGridType = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSPrivilege = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.BOSPropertyName = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.CommodityType = "";
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.GridViewMain = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.MenuManager = this.screenToolbar;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.Name = "fld_dgcHRSocialInsuranceDeclarationItemReductions";
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.PrintReport = false;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.RowHandle = 0;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.Screen = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.Size = new System.Drawing.Size(1006, 586);
            this.fld_dgcHRSocialInsuranceDeclarationItemReductions.TabIndex = 3;
            // 
            // fld_dgcHRSocialInsuranceDeclarationItemArrears
            // 
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSComment = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSDataMember = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSDataSource = "HRSocialInsuranceDeclarationItems";
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSDescription = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSError = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSFieldGroup = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSFieldRelation = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSGridType = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSPrivilege = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.BOSPropertyName = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.CommodityType = "";
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.GridViewMain = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.MenuManager = this.screenToolbar;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.Name = "fld_dgcHRSocialInsuranceDeclarationItemArrears";
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.PrintReport = false;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.RowHandle = 0;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.Screen = null;
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.Size = new System.Drawing.Size(1006, 586);
            this.fld_dgcHRSocialInsuranceDeclarationItemArrears.TabIndex = 3;
            // 
            // DMSID100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1018, 790);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSID100";
            this.Text = "Quản lý chấm công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDate1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRSocialInsuranceDeclarationEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemIncreases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemReductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarationItemArrears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRSocialInsuranceDeclarationEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeHRSocialInsuranceDeclarationType;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHRSocialInsuranceDeclarationStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel3;
        private DevExpress.XtraTab.XtraTabControl TabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private HRSocialInsuranceDeclarationItemIncreasessGridControl fld_dgcHRSocialInsuranceDeclarationItemIncreases;
        private HRSocialInsuranceDeclarationItemReductionsGridControl fld_dgcHRSocialInsuranceDeclarationItemReductions;
        private HRSocialInsuranceDeclarationItemArrearsGridControl fld_dgcHRSocialInsuranceDeclarationItemArrears;
    }
}
