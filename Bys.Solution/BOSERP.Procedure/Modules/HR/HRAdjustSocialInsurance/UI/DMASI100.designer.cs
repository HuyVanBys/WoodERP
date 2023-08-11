using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRAdjustSocialInsurance.UI
{
	/// <summary>
	/// Summary description for DMASI100
	/// </summary>
	partial class DMASI100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeAdjustSocialInsurances = new BOSERP.Modules.HRAdjustSocialInsurance.HREmployeeAdjustSocialInsurancesGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeArrearSocialInsurances = new BOSERP.Modules.HRAdjustSocialInsurance.HREmployeeArrearSocialInsurancesGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeSocialInsuranceChanges = new BOSERP.Modules.HRAdjustSocialInsurance.HREmployeeSocialInsuranceChangesGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeHRAdjustSocialInsuranceStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRAdjustSocialInsuranceNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRAdjustSocialInsuranceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHRAdjustSocialInsuranceDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeAdjustSocialInsurances)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrearSocialInsurances)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSocialInsuranceChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdjustSocialInsuranceStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdjustSocialInsuranceDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 146);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(856, 418);
            this.bosTabControl1.TabIndex = 10;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnAddEmployee);
            this.xtraTabPage1.Controls.Add(this.fld_dgcHREmployeeAdjustSocialInsurances);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 389);
            this.xtraTabPage1.Text = "Điều chỉnh BHXH";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(5, 358);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 2;
            this.fld_btnAddEmployee.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_dgcHREmployeeAdjustSocialInsurances
            // 
            this.fld_dgcHREmployeeAdjustSocialInsurances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSComment = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSDataMember = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSDataSource = "HREmployeeAdjustSocialInsurances";
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSDescription = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSError = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSFieldGroup = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSFieldRelation = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSGridType = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSPrivilege = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.BOSPropertyName = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.GridViewMain = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHREmployeeAdjustSocialInsurances.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeAdjustSocialInsurances.Name = "fld_dgcHREmployeeAdjustSocialInsurances";          
            this.fld_dgcHREmployeeAdjustSocialInsurances.Screen = null;
            this.fld_dgcHREmployeeAdjustSocialInsurances.Size = new System.Drawing.Size(846, 349);
            this.fld_dgcHREmployeeAdjustSocialInsurances.TabIndex = 1;
            this.fld_dgcHREmployeeAdjustSocialInsurances.TabStop = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosGroupControl2);
            this.xtraTabPage2.Controls.Add(this.bosButton1);
            this.xtraTabPage2.Controls.Add(this.fld_dgcHREmployeeArrearSocialInsurances);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(849, 389);
            this.xtraTabPage2.Text = "Truy thu BHXH";
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.Location = new System.Drawing.Point(5, 358);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(100, 27);
            this.bosButton1.TabIndex = 4;
            this.bosButton1.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton1.Text = "Thêm nhân viên";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_dgcHREmployeeArrearSocialInsurances
            // 
            this.fld_dgcHREmployeeArrearSocialInsurances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSComment = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSDataMember = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSDataSource = "HREmployeeArrearSocialInsurances";
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSDescription = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSError = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSFieldGroup = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSFieldRelation = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSGridType = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSPrivilege = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.BOSPropertyName = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.GridViewMain = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.Location = new System.Drawing.Point(3, 59);
            this.fld_dgcHREmployeeArrearSocialInsurances.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeArrearSocialInsurances.Name = "fld_dgcHREmployeeArrearSocialInsurances";            
            this.fld_dgcHREmployeeArrearSocialInsurances.Screen = null;
            this.fld_dgcHREmployeeArrearSocialInsurances.Size = new System.Drawing.Size(846, 293);
            this.fld_dgcHREmployeeArrearSocialInsurances.TabIndex = 3;
            this.fld_dgcHREmployeeArrearSocialInsurances.TabStop = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosButton2);
            this.xtraTabPage3.Controls.Add(this.fld_dgcHREmployeeSocialInsuranceChanges);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(849, 389);
            this.xtraTabPage3.Text = "Điều chỉnh thông tin BHXH";
            // 
            // bosButton2
            // 
            this.bosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton2.Appearance.Options.UseForeColor = true;
            this.bosButton2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.Location = new System.Drawing.Point(5, 358);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(100, 27);
            this.bosButton2.TabIndex = 6;
            this.bosButton2.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosButton2.Text = "Thêm nhân viên";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // fld_dgcHREmployeeSocialInsuranceChanges
            // 
            this.fld_dgcHREmployeeSocialInsuranceChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSComment = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSDataMember = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSDataSource = "HREmployeeSocialInsuranceChanges";
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSDescription = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSError = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSFieldGroup = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSFieldRelation = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSGridType = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSPrivilege = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.BOSPropertyName = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHREmployeeSocialInsuranceChanges.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeSocialInsuranceChanges.Name = "fld_dgcHREmployeeSocialInsuranceChanges";            
            this.fld_dgcHREmployeeSocialInsuranceChanges.Screen = null;
            this.fld_dgcHREmployeeSocialInsuranceChanges.Size = new System.Drawing.Size(846, 349);
            this.fld_dgcHREmployeeSocialInsuranceChanges.TabIndex = 5;
            this.fld_dgcHREmployeeSocialInsuranceChanges.TabStop = false;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeHRAdjustSocialInsuranceStatus);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.bosTextBox1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosGroupControl1.Controls.Add(this.fld_txtHRAdjustSocialInsuranceNo);
            this.bosGroupControl1.Controls.Add(this.fld_dteHRAdjustSocialInsuranceDate);
            this.bosGroupControl1.Controls.Add(this.fld_medHRAdjustSocialInsuranceDesc);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 4);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 136);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_lkeHRAdjustSocialInsuranceStatus
            // 
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSAllowAddNew = false;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSAllowDummy = false;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSComment = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSDataMember = "HRAdjustSocialInsuranceStatus";
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSDescription = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSError = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSFieldGroup = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSFieldParent = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSFieldRelation = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSPrivilege = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSSelectType = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.CurrentDisplayText = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Location = new System.Drawing.Point(357, 51);
            this.fld_lkeHRAdjustSocialInsuranceStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Name = "fld_lkeHRAdjustSocialInsuranceStatus";
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.ReadOnly = true;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Screen = null;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Size = new System.Drawing.Size(139, 20);
            this.fld_lkeHRAdjustSocialInsuranceStatus.TabIndex = 4;
            this.fld_lkeHRAdjustSocialInsuranceStatus.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(278, 54);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 14;
            this.bosLabel4.Text = "Tình trạng";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(18, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(18, 80);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(40, 13);
            this.bosLabel6.TabIndex = 14;
            this.bosLabel6.Text = "Diễn giải";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(537, 28);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(30, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Text = "Tháng";
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
            this.bosLabel5.Location = new System.Drawing.Point(278, 28);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(69, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Text = "Đợt điều chỉnh";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(18, 28);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 14;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSDataMember = "HRAdjustSocialInsurancePhase";
            this.bosTextBox1.BOSDataSource = "HRAdjustSocialInsurances";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox1.Location = new System.Drawing.Point(357, 25);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(139, 20);
            this.bosTextBox1.TabIndex = 1;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(104, 51);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.InvoiceLocalizedResources.Contact2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Name")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            this.fld_lkeFK_BRBranchID.Validated += new System.EventHandler(this.fld_lkeFK_BRBranchID_Validated);
            // 
            // fld_txtHRAdjustSocialInsuranceNo
            // 
            this.fld_txtHRAdjustSocialInsuranceNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSDataMember = "HRAdjustSocialInsuranceNo";
            this.fld_txtHRAdjustSocialInsuranceNo.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_txtHRAdjustSocialInsuranceNo.BOSDescription = null;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSError = null;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAdjustSocialInsuranceNo.BOSPropertyName = "Text";
            this.fld_txtHRAdjustSocialInsuranceNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRAdjustSocialInsuranceNo.Location = new System.Drawing.Point(104, 25);
            this.fld_txtHRAdjustSocialInsuranceNo.Name = "fld_txtHRAdjustSocialInsuranceNo";
            this.fld_txtHRAdjustSocialInsuranceNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdjustSocialInsuranceNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdjustSocialInsuranceNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdjustSocialInsuranceNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdjustSocialInsuranceNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdjustSocialInsuranceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdjustSocialInsuranceNo.Screen = null;
            this.fld_txtHRAdjustSocialInsuranceNo.Size = new System.Drawing.Size(135, 20);
            this.fld_txtHRAdjustSocialInsuranceNo.TabIndex = 0;
            this.fld_txtHRAdjustSocialInsuranceNo.Tag = "DC";
            // 
            // fld_dteHRAdjustSocialInsuranceDate
            // 
            this.fld_dteHRAdjustSocialInsuranceDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSDataMember = "HRAdjustSocialInsuranceDate";
            this.fld_dteHRAdjustSocialInsuranceDate.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_dteHRAdjustSocialInsuranceDate.BOSDescription = null;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSError = null;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRAdjustSocialInsuranceDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAdjustSocialInsuranceDate.EditValue = null;
            this.fld_dteHRAdjustSocialInsuranceDate.Location = new System.Drawing.Point(581, 25);
            this.fld_dteHRAdjustSocialInsuranceDate.Name = "fld_dteHRAdjustSocialInsuranceDate";
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRAdjustSocialInsuranceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdjustSocialInsuranceDate.Screen = null;
            this.fld_dteHRAdjustSocialInsuranceDate.Size = new System.Drawing.Size(139, 20);
            this.fld_dteHRAdjustSocialInsuranceDate.TabIndex = 2;
            this.fld_dteHRAdjustSocialInsuranceDate.Tag = "DC";
            // 
            // fld_medHRAdjustSocialInsuranceDesc
            // 
            this.fld_medHRAdjustSocialInsuranceDesc.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSDataMember = "HRAdjustSocialInsuranceDesc";
            this.fld_medHRAdjustSocialInsuranceDesc.BOSDataSource = "HRAdjustSocialInsurances";
            this.fld_medHRAdjustSocialInsuranceDesc.BOSDescription = null;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSError = null;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAdjustSocialInsuranceDesc.BOSPropertyName = "Text";
            this.fld_medHRAdjustSocialInsuranceDesc.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_medHRAdjustSocialInsuranceDesc.Location = new System.Drawing.Point(104, 77);
            this.fld_medHRAdjustSocialInsuranceDesc.Name = "fld_medHRAdjustSocialInsuranceDesc";
            this.fld_medHRAdjustSocialInsuranceDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRAdjustSocialInsuranceDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRAdjustSocialInsuranceDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRAdjustSocialInsuranceDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRAdjustSocialInsuranceDesc.Screen = null;
            this.fld_medHRAdjustSocialInsuranceDesc.Size = new System.Drawing.Size(616, 47);
            this.fld_medHRAdjustSocialInsuranceDesc.TabIndex = 5;
            this.fld_medHRAdjustSocialInsuranceDesc.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox2.BOSDataMember = "HRAdjustSocialInsuranceBHXHRate";
            this.bosTextBox2.BOSDataSource = "HRAdjustSocialInsurances";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox2.Location = new System.Drawing.Point(108, 27);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(135, 20);
            this.bosTextBox2.TabIndex = 0;
            this.bosTextBox2.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(11, 30);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(88, 13);
            this.bosLabel7.TabIndex = 14;
            this.bosLabel7.Text = "BHXH, BHTN/Năm:";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.bosTextBox3);
            this.bosGroupControl2.Controls.Add(this.bosLabel8);
            this.bosGroupControl2.Controls.Add(this.bosTextBox2);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Location = new System.Drawing.Point(5, 0);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(844, 53);
            this.bosGroupControl2.TabIndex = 15;
            this.bosGroupControl2.Text = "Lãi suất truy thu";
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
            this.bosLabel8.Location = new System.Drawing.Point(291, 30);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(54, 13);
            this.bosLabel8.TabIndex = 14;
            this.bosLabel8.Text = "BHYT/Năm:";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox3.BOSDataMember = "HRAdjustSocialInsuranceBHYTRate";
            this.bosTextBox3.BOSDataSource = "HRAdjustSocialInsurances";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosTextBox3.Location = new System.Drawing.Point(388, 27);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.bosTextBox3.Size = new System.Drawing.Size(135, 20);
            this.bosTextBox3.TabIndex = 1;
            this.bosTextBox3.Tag = "DC";
            // 
            // DMASI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMASI100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeAdjustSocialInsurances)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrearSocialInsurances)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeSocialInsuranceChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdjustSocialInsuranceStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdjustSocialInsuranceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdjustSocialInsuranceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdjustSocialInsuranceDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTextBox fld_txtHRAdjustSocialInsuranceNo;
        private BOSComponent.BOSDateEdit fld_dteHRAdjustSocialInsuranceDate;
        private BOSComponent.BOSMemoEdit fld_medHRAdjustSocialInsuranceDesc;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdjustSocialInsuranceStatus;
        private HREmployeeAdjustSocialInsurancesGridControl fld_dgcHREmployeeAdjustSocialInsurances;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSButton bosButton1;
        private HREmployeeArrearSocialInsurancesGridControl fld_dgcHREmployeeArrearSocialInsurances;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSButton bosButton2;
        private HREmployeeSocialInsuranceChangesGridControl fld_dgcHREmployeeSocialInsuranceChanges;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel8;
	}
}
