using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RegisterDormitory.UI
{
	/// <summary>
    /// Summary description for DMRD100
	/// </summary>
	partial class DMRD100
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
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_HREmployeeID02 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRRegisterDormitoryToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HRDormitoryID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRRegisterDormitoryCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRRegisterDormitoryAcreage = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRRegisterDormitoryDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRRegisterDormitoryFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRRegisterDormitoryNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHRRegisterDormitoryItems = new BOSERP.Modules.RegisterDormitory.HRRegisterDormitoryItemsGridControl();
            this.fld_pteHRRegisterDormitoryEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARSaleOrderItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductAttributeID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dgcARSaleOrderItems = new BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID02.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDormitoryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryAcreage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRegisterDormitoryDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRegisterDormitoryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRegisterDormitoryEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID02);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_dteHRRegisterDormitoryToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDormitoryID);
            this.bosPanel1.Controls.Add(this.fld_txtHRRegisterDormitoryCapacity);
            this.bosPanel1.Controls.Add(this.fld_txtHRRegisterDormitoryAcreage);
            this.bosPanel1.Controls.Add(this.fld_medHRRegisterDormitoryDesc);
            this.bosPanel1.Controls.Add(this.fld_dteHRRegisterDormitoryFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel35);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtHRRegisterDormitoryNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_pteHRRegisterDormitoryEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(920, 424);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.Location = new System.Drawing.Point(132, 388);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(100, 27);
            this.bosButton1.TabIndex = 91;
            this.bosButton1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosButton1.Text = "Thêm từ nhân thân";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_lkeFK_HREmployeeID02
            // 
            this.fld_lkeFK_HREmployeeID02.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID02.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID02.BOSComment = null;
            this.fld_lkeFK_HREmployeeID02.BOSDataMember = "FK_HREmployeeManager";
            this.fld_lkeFK_HREmployeeID02.BOSDataSource = "HRRegisterDormitorys";
            this.fld_lkeFK_HREmployeeID02.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID02.BOSError = null;
            this.fld_lkeFK_HREmployeeID02.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID02.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID02.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID02.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID02.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID02.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID02.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID02.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID02.Location = new System.Drawing.Point(590, 12);
            this.fld_lkeFK_HREmployeeID02.Name = "fld_lkeFK_HREmployeeID02";
            this.fld_lkeFK_HREmployeeID02.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID02.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID02.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID02.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID02.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID02.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên")});
            this.fld_lkeFK_HREmployeeID02.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID02.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID02.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID02.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID02.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID02.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID02, true);
            this.fld_lkeFK_HREmployeeID02.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HREmployeeID02.TabIndex = 90;
            this.fld_lkeFK_HREmployeeID02.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(502, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(68, 13);
            this.bosLabel6.TabIndex = 89;
            this.bosLabel6.Text = "Trưởng phòng";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(12, 388);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 88;
            this.fld_btnAddEmployee.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_btnAddEmployee.Text = "Thêm từ nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(185, 93);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 87;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_dteHRRegisterDormitoryToDate
            // 
            this.fld_dteHRRegisterDormitoryToDate.BOSComment = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSDataMember = "HRRegisterDormitoryToDate";
            this.fld_dteHRRegisterDormitoryToDate.BOSDataSource = "HRRegisterDormitorys";
            this.fld_dteHRRegisterDormitoryToDate.BOSDescription = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSError = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSFieldGroup = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSFieldRelation = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSPrivilege = null;
            this.fld_dteHRRegisterDormitoryToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRegisterDormitoryToDate.EditValue = null;
            this.fld_dteHRRegisterDormitoryToDate.Location = new System.Drawing.Point(273, 90);
            this.fld_dteHRRegisterDormitoryToDate.Name = "fld_dteHRRegisterDormitoryToDate";
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRegisterDormitoryToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRegisterDormitoryToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRegisterDormitoryToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRegisterDormitoryToDate.Screen = null;
            this.fld_dteHRRegisterDormitoryToDate.Size = new System.Drawing.Size(197, 20);
            this.fld_dteHRRegisterDormitoryToDate.TabIndex = 86;
            this.fld_dteHRRegisterDormitoryToDate.Tag = "DC";
            // 
            // fld_lkeFK_HRDormitoryID
            // 
            this.fld_lkeFK_HRDormitoryID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDormitoryID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDormitoryID.BOSComment = null;
            this.fld_lkeFK_HRDormitoryID.BOSDataMember = "FK_HRDormitoryID";
            this.fld_lkeFK_HRDormitoryID.BOSDataSource = "HRRegisterDormitorys";
            this.fld_lkeFK_HRDormitoryID.BOSDescription = null;
            this.fld_lkeFK_HRDormitoryID.BOSError = null;
            this.fld_lkeFK_HRDormitoryID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDormitoryID.BOSFieldParent = null;
            this.fld_lkeFK_HRDormitoryID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDormitoryID.BOSPrivilege = null;
            this.fld_lkeFK_HRDormitoryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDormitoryID.BOSSelectType = null;
            this.fld_lkeFK_HRDormitoryID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDormitoryID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDormitoryID.Location = new System.Drawing.Point(273, 38);
            this.fld_lkeFK_HRDormitoryID.Name = "fld_lkeFK_HRDormitoryID";
            this.fld_lkeFK_HRDormitoryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDormitoryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDormitoryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDormitoryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDormitoryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDormitoryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDormitoryNo", "Mã phòng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDormitoryName", "Tên phòng")});
            this.fld_lkeFK_HRDormitoryID.Properties.DisplayMember = "HRDormitoryName";
            this.fld_lkeFK_HRDormitoryID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HRDormitoryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDormitoryID.Properties.ValueMember = "HRDormitoryID";
            this.fld_lkeFK_HRDormitoryID.Screen = null;
            this.fld_lkeFK_HRDormitoryID.Size = new System.Drawing.Size(197, 20);
            this.fld_lkeFK_HRDormitoryID.TabIndex = 85;
            this.fld_lkeFK_HRDormitoryID.Tag = "DC";
            this.fld_lkeFK_HRDormitoryID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRDormitoryID_CloseUp);
            // 
            // fld_txtHRRegisterDormitoryCapacity
            // 
            this.fld_txtHRRegisterDormitoryCapacity.BOSComment = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSDataMember = "HRRegisterDormitoryCapacity";
            this.fld_txtHRRegisterDormitoryCapacity.BOSDataSource = "HRRegisterDormitorys";
            this.fld_txtHRRegisterDormitoryCapacity.BOSDescription = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSError = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSFieldGroup = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSFieldRelation = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSPrivilege = null;
            this.fld_txtHRRegisterDormitoryCapacity.BOSPropertyName = "EditValue";
            this.fld_txtHRRegisterDormitoryCapacity.Location = new System.Drawing.Point(590, 64);
            this.fld_txtHRRegisterDormitoryCapacity.MenuManager = this.screenToolbar;
            this.fld_txtHRRegisterDormitoryCapacity.Name = "fld_txtHRRegisterDormitoryCapacity";
            this.fld_txtHRRegisterDormitoryCapacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRRegisterDormitoryCapacity.Screen = null;
            this.fld_txtHRRegisterDormitoryCapacity.Size = new System.Drawing.Size(171, 20);
            this.fld_txtHRRegisterDormitoryCapacity.TabIndex = 84;
            this.fld_txtHRRegisterDormitoryCapacity.Tag = "DC";
            // 
            // fld_txtHRRegisterDormitoryAcreage
            // 
            this.fld_txtHRRegisterDormitoryAcreage.BOSComment = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSDataMember = "HRRegisterDormitoryAcreage";
            this.fld_txtHRRegisterDormitoryAcreage.BOSDataSource = "HRRegisterDormitorys";
            this.fld_txtHRRegisterDormitoryAcreage.BOSDescription = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSError = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSFieldGroup = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSFieldRelation = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSPrivilege = null;
            this.fld_txtHRRegisterDormitoryAcreage.BOSPropertyName = "EditValue";
            this.fld_txtHRRegisterDormitoryAcreage.Location = new System.Drawing.Point(590, 38);
            this.fld_txtHRRegisterDormitoryAcreage.MenuManager = this.screenToolbar;
            this.fld_txtHRRegisterDormitoryAcreage.Name = "fld_txtHRRegisterDormitoryAcreage";
            this.fld_txtHRRegisterDormitoryAcreage.Properties.Mask.EditMask = "n";
            this.fld_txtHRRegisterDormitoryAcreage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtHRRegisterDormitoryAcreage.Screen = null;
            this.fld_txtHRRegisterDormitoryAcreage.Size = new System.Drawing.Size(171, 20);
            this.fld_txtHRRegisterDormitoryAcreage.TabIndex = 83;
            this.fld_txtHRRegisterDormitoryAcreage.Tag = "DC";
            // 
            // fld_medHRRegisterDormitoryDesc
            // 
            this.fld_medHRRegisterDormitoryDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRRegisterDormitoryDesc.BOSDataMember = "HRRegisterDormitoryDesc";
            this.fld_medHRRegisterDormitoryDesc.BOSDataSource = "HRRegisterDormitorys";
            this.fld_medHRRegisterDormitoryDesc.BOSDescription = null;
            this.fld_medHRRegisterDormitoryDesc.BOSError = null;
            this.fld_medHRRegisterDormitoryDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRRegisterDormitoryDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRRegisterDormitoryDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRRegisterDormitoryDesc.BOSPropertyName = "EditValue";
            this.fld_medHRRegisterDormitoryDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHRRegisterDormitoryDesc.Location = new System.Drawing.Point(273, 115);
            this.fld_medHRRegisterDormitoryDesc.Name = "fld_medHRRegisterDormitoryDesc";
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRRegisterDormitoryDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRRegisterDormitoryDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHRRegisterDormitoryDesc, true);
            this.fld_medHRRegisterDormitoryDesc.Size = new System.Drawing.Size(488, 53);
            this.fld_medHRRegisterDormitoryDesc.TabIndex = 82;
            this.fld_medHRRegisterDormitoryDesc.Tag = "DC";
            // 
            // fld_dteHRRegisterDormitoryFromDate
            // 
            this.fld_dteHRRegisterDormitoryFromDate.BOSComment = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSDataMember = "HRRegisterDormitoryFromDate";
            this.fld_dteHRRegisterDormitoryFromDate.BOSDataSource = "HRRegisterDormitorys";
            this.fld_dteHRRegisterDormitoryFromDate.BOSDescription = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSError = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSFieldGroup = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSFieldRelation = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSPrivilege = null;
            this.fld_dteHRRegisterDormitoryFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRRegisterDormitoryFromDate.EditValue = null;
            this.fld_dteHRRegisterDormitoryFromDate.Location = new System.Drawing.Point(273, 64);
            this.fld_dteHRRegisterDormitoryFromDate.Name = "fld_dteHRRegisterDormitoryFromDate";
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRRegisterDormitoryFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRRegisterDormitoryFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRRegisterDormitoryFromDate.Screen = null;
            this.fld_dteHRRegisterDormitoryFromDate.Size = new System.Drawing.Size(197, 20);
            this.fld_dteHRRegisterDormitoryFromDate.TabIndex = 81;
            this.fld_dteHRRegisterDormitoryFromDate.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(185, 121);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 79;
            this.bosLabel5.Text = "Mô tả";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(502, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(80, 13);
            this.bosLabel4.TabIndex = 78;
            this.bosLabel4.Text = "Sức chứa(người)";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = null;
            this.bosLabel35.BOSDataSource = null;
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = null;
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(502, 43);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(63, 13);
            this.bosLabel35.TabIndex = 76;
            this.bosLabel35.Text = "Diện tích(M2)";
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
            this.bosLabel3.Location = new System.Drawing.Point(185, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 73;
            this.bosLabel3.Text = "Từ ngày";
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
            this.bosLabel2.Location = new System.Drawing.Point(185, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 71;
            this.bosLabel2.Text = "Phòng trọ";
            // 
            // fld_txtHRRegisterDormitoryNo
            // 
            this.fld_txtHRRegisterDormitoryNo.BOSComment = null;
            this.fld_txtHRRegisterDormitoryNo.BOSDataMember = "HRRegisterDormitoryNo";
            this.fld_txtHRRegisterDormitoryNo.BOSDataSource = "HRRegisterDormitorys";
            this.fld_txtHRRegisterDormitoryNo.BOSDescription = null;
            this.fld_txtHRRegisterDormitoryNo.BOSError = null;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldGroup = null;
            this.fld_txtHRRegisterDormitoryNo.BOSFieldRelation = null;
            this.fld_txtHRRegisterDormitoryNo.BOSPrivilege = null;
            this.fld_txtHRRegisterDormitoryNo.BOSPropertyName = "EditValue";
            this.fld_txtHRRegisterDormitoryNo.Location = new System.Drawing.Point(273, 12);
            this.fld_txtHRRegisterDormitoryNo.MenuManager = this.screenToolbar;
            this.fld_txtHRRegisterDormitoryNo.Name = "fld_txtHRRegisterDormitoryNo";
            this.fld_txtHRRegisterDormitoryNo.Screen = null;
            this.fld_txtHRRegisterDormitoryNo.Size = new System.Drawing.Size(197, 20);
            this.fld_txtHRRegisterDormitoryNo.TabIndex = 70;
            this.fld_txtHRRegisterDormitoryNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(185, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 69;
            this.bosLabel7.Text = "Mã chứng từ";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 168);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(914, 214);
            this.bosTabControl1.TabIndex = 68;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcHRRegisterDormitoryItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(907, 185);
            this.xtraTabPage1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHRRegisterDormitoryItems
            // 
            this.fld_dgcHRRegisterDormitoryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRRegisterDormitoryItems.BOSComment = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSDataMember = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSDataSource = "HRRegisterDormitoryItems";
            this.fld_dgcHRRegisterDormitoryItems.BOSDescription = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSError = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSFieldGroup = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSFieldRelation = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSGridType = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSPrivilege = null;
            this.fld_dgcHRRegisterDormitoryItems.BOSPropertyName = null;
            this.fld_dgcHRRegisterDormitoryItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcHRRegisterDormitoryItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRRegisterDormitoryItems.Name = "fld_dgcHRRegisterDormitoryItems";
            this.fld_dgcHRRegisterDormitoryItems.PrintReport = false;
            this.fld_dgcHRRegisterDormitoryItems.Screen = null;
            this.fld_dgcHRRegisterDormitoryItems.Size = new System.Drawing.Size(900, 179);
            this.fld_dgcHRRegisterDormitoryItems.TabIndex = 3;
            // 
            // fld_pteHRRegisterDormitoryEmployeePicture
            // 
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSComment = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSDataMember = "HRRegisterDormitoryEmployeePicture";
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSDataSource = "HRRegisterDormitorys";
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSDescription = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSError = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRRegisterDormitoryEmployeePicture.Location = new System.Drawing.Point(12, 12);
            this.fld_pteHRRegisterDormitoryEmployeePicture.Name = "fld_pteHRRegisterDormitoryEmployeePicture";
            this.fld_pteHRRegisterDormitoryEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteHRRegisterDormitoryEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteHRRegisterDormitoryEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteHRRegisterDormitoryEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteHRRegisterDormitoryEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRRegisterDormitoryEmployeePicture.Screen = null;
            this.fld_pteHRRegisterDormitoryEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRRegisterDormitoryEmployeePicture.TabIndex = 7;
            this.fld_pteHRRegisterDormitoryEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "HRRegisterDormitorys";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(12, 114);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 8;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            this.fld_lkeFK_HREmployeeID1.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID1_Validated);
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(11, 6);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Sản phẩm";
            // 
            // fld_pteARSaleOrderItemProductPicture
            // 
            this.fld_pteARSaleOrderItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARSaleOrderItemProductPicture.BOSComment = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSDataMember = "ARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.BOSDataSource = "ARSaleOrderItems";
            this.fld_pteARSaleOrderItemProductPicture.BOSDescription = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSError = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPrivilege = null;
            this.fld_pteARSaleOrderItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARSaleOrderItemProductPicture.Location = new System.Drawing.Point(1015, 3);
            this.fld_pteARSaleOrderItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARSaleOrderItemProductPicture.Name = "fld_pteARSaleOrderItemProductPicture";
            this.fld_pteARSaleOrderItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARSaleOrderItemProductPicture.Screen = null;
            this.fld_pteARSaleOrderItemProductPicture.Size = new System.Drawing.Size(141, 140);
            this.fld_pteARSaleOrderItemProductPicture.TabIndex = 2;
            this.fld_pteARSaleOrderItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductAttributeID
            // 
            this.fld_lkeFK_ICProductAttributeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductAttributeID.BOSDataSource = "ARSaleOrderItems";
            this.fld_lkeFK_ICProductAttributeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeID.BOSSelectType = null;
            this.fld_lkeFK_ICProductAttributeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductAttributeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeID.Location = new System.Drawing.Point(64, 3);
            this.fld_lkeFK_ICProductAttributeID.Name = "fld_lkeFK_ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeFK_ICProductAttributeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductAttributeID.Screen = null;
            this.fld_lkeFK_ICProductAttributeID.Size = new System.Drawing.Size(946, 20);
            this.fld_lkeFK_ICProductAttributeID.TabIndex = 0;
            this.fld_lkeFK_ICProductAttributeID.Tag = "DC";
            // 
            // fld_dgcARSaleOrderItems
            // 
            this.fld_dgcARSaleOrderItems.AllowDrop = true;
            this.fld_dgcARSaleOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrderItems.BOSComment = null;
            this.fld_dgcARSaleOrderItems.BOSDataMember = null;
            this.fld_dgcARSaleOrderItems.BOSDataSource = "ARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.BOSDescription = null;
            this.fld_dgcARSaleOrderItems.BOSError = null;
            this.fld_dgcARSaleOrderItems.BOSFieldGroup = null;
            this.fld_dgcARSaleOrderItems.BOSFieldRelation = null;
            this.fld_dgcARSaleOrderItems.BOSGridType = null;
            this.fld_dgcARSaleOrderItems.BOSPrivilege = null;
            this.fld_dgcARSaleOrderItems.BOSPropertyName = null;
            this.fld_dgcARSaleOrderItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrderItems.Location = new System.Drawing.Point(3, 29);
            this.fld_dgcARSaleOrderItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrderItems.Name = "fld_dgcARSaleOrderItems";
            this.fld_dgcARSaleOrderItems.PrintReport = false;
            this.fld_dgcARSaleOrderItems.Screen = null;
            this.fld_dgcARSaleOrderItems.Size = new System.Drawing.Size(1007, 153);
            this.fld_dgcARSaleOrderItems.TabIndex = 1;
            this.fld_dgcARSaleOrderItems.Tag = "DC";
            this.fld_dgcARSaleOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARSaleOrderItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // DMRD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(920, 424);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRD100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID02.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDormitoryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryAcreage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRRegisterDormitoryDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRRegisterDormitoryFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRegisterDormitoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRegisterDormitoryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRRegisterDormitoryEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARSaleOrderItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteHRRegisterDormitoryEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel fld_lblLabel48;
        private BOSComponent.BOSPictureEdit fld_pteARSaleOrderItemProductPicture;
        private ItemLookupEdit fld_lkeFK_ICProductAttributeID;
        private BOSERP.Modules.SaleOrder.ARSaleOrderItemsGridControl fld_dgcARSaleOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtHRRegisterDormitoryNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSDateEdit fld_dteHRRegisterDormitoryFromDate;
        private BOSComponent.BOSMemoEdit fld_medHRRegisterDormitoryDesc;
        private BOSComponent.BOSTextBox fld_txtHRRegisterDormitoryAcreage;
        private BOSComponent.BOSTextBox fld_txtHRRegisterDormitoryCapacity;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDormitoryID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteHRRegisterDormitoryToDate;
        private HRRegisterDormitoryItemsGridControl fld_dgcHRRegisterDormitoryItems;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID02;
        private BOSComponent.BOSButton bosButton1;
	}
}
