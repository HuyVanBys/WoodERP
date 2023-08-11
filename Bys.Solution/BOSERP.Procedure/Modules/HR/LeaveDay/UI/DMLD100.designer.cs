using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LeaveDay.UI
{
	/// <summary>
	/// Summary description for DMLD100
	/// </summary>
	partial class DMLD100
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
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_HREmployeePayrollFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.fld_lkeHRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcLeaveDays = new BOSERP.Modules.LeaveDay.LeaveDayGridControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcLeaveDays)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.bosLabel1.Location = new System.Drawing.Point(18, 21);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Chi nhánh";
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
            this.bosLabel2.Location = new System.Drawing.Point(268, 21);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Phòng ban";
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
            this.bosLabel3.Location = new System.Drawing.Point(543, 21);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Bộ phận";
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeePayrollFormulaID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel22);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeStatus);
            this.bosPanel1.Controls.Add(this.fld_btnView);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartmentRoomID);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_lkeBRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(881, 101);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_HREmployeePayrollFormulaID
            // 
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSComment = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSDescription = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSError = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Location = new System.Drawing.Point(370, 70);
            this.fld_lkeFK_HREmployeePayrollFormulaID.Name = "fld_lkeFK_HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Nhóm chấm công")});
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeFK_HREmployeePayrollFormulaID.Screen = null;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeePayrollFormulaID.TabIndex = 7;
            this.fld_lkeFK_HREmployeePayrollFormulaID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(267, 72);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(81, 13);
            this.bosLabel7.TabIndex = 100;
            this.bosLabel7.Text = "Nhóm chấm công";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(370, 44);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 4;
            this.fld_dteSearchFromDate.Tag = "DC";
            this.fld_dteSearchFromDate.Validated += new System.EventHandler(this.fld_dteLeaveDayFrom_Validated);
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.Location = new System.Drawing.Point(543, 47);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel22.TabIndex = 99;
            this.fld_lblLabel22.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel22.Text = "Đến";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(599, 44);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 5;
            this.fld_dteSearchToDate.Tag = "DC";
            this.fld_dteSearchToDate.Validated += new System.EventHandler(this.fld_dteLeaveDayTo_Validated);
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.Location = new System.Drawing.Point(267, 47);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel20.TabIndex = 98;
            this.fld_lblLabel20.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel20.Text = "Từ ngày";
            // 
            // fld_lkeHREmployeeStatus
            // 
            this.fld_lkeHREmployeeStatus.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeStatus.BOSAllowDummy = true;
            this.fld_lkeHREmployeeStatus.BOSComment = null;
            this.fld_lkeHREmployeeStatus.BOSDataMember = "EmployeeStatus";
            this.fld_lkeHREmployeeStatus.BOSDataSource = "ADConfigValues";
            this.fld_lkeHREmployeeStatus.BOSDescription = null;
            this.fld_lkeHREmployeeStatus.BOSError = null;
            this.fld_lkeHREmployeeStatus.BOSFieldGroup = null;
            this.fld_lkeHREmployeeStatus.BOSFieldParent = null;
            this.fld_lkeHREmployeeStatus.BOSFieldRelation = null;
            this.fld_lkeHREmployeeStatus.BOSPrivilege = null;
            this.fld_lkeHREmployeeStatus.BOSPropertyName = null;
            this.fld_lkeHREmployeeStatus.BOSSelectType = null;
            this.fld_lkeHREmployeeStatus.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeStatus.CurrentDisplayText = null;
            this.fld_lkeHREmployeeStatus.Location = new System.Drawing.Point(86, 70);
            this.fld_lkeHREmployeeStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeStatus.Name = "fld_lkeHREmployeeStatus";
            this.fld_lkeHREmployeeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeStatus.Properties.ColumnName = null;
            this.fld_lkeHREmployeeStatus.Screen = null;
            this.fld_lkeHREmployeeStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeStatus.TabIndex = 6;
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(777, 12);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(75, 27);
            this.fld_btnView.TabIndex = 8;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // fld_lkeHRDepartmentRoomID
            // 
            this.fld_lkeHRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRoomID.BOSComment = null;
            this.fld_lkeHRDepartmentRoomID.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeHRDepartmentRoomID.BOSError = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRoomID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeHRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRoomID.Location = new System.Drawing.Point(599, 18);
            this.fld_lkeHRDepartmentRoomID.Name = "fld_lkeHRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRoomID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeHRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRoomID.Screen = null;
            this.fld_lkeHRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRoomID.TabIndex = 2;
            this.fld_lkeHRDepartmentRoomID.EditValueChanged += new System.EventHandler(this.fld_lkeHRDepartmentRoomID_EditValueChanged);
            this.fld_lkeHRDepartmentRoomID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRDepartmentRoomID_QueryPopUp);
            // 
            // fld_lkeHRDepartmentID
            // 
            this.fld_lkeHRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentID.BOSComment = null;
            this.fld_lkeHRDepartmentID.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartmentID.BOSDescription = null;
            this.fld_lkeHRDepartmentID.BOSError = null;
            this.fld_lkeHRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentID.BOSFieldParent = null;
            this.fld_lkeHRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentID.BOSPrivilege = null;
            this.fld_lkeHRDepartmentID.BOSPropertyName = null;
            this.fld_lkeHRDepartmentID.BOSSelectType = null;
            this.fld_lkeHRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentID.Location = new System.Drawing.Point(370, 18);
            this.fld_lkeHRDepartmentID.Name = "fld_lkeHRDepartmentID";
            this.fld_lkeHRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentID.Properties.ColumnName = null;
            this.fld_lkeHRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeHRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartmentID.Screen = null;
            this.fld_lkeHRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentID.TabIndex = 1;
            this.fld_lkeHRDepartmentID.EditValueChanged += new System.EventHandler(this.fld_lkeHRDepartmentID_EditValueChanged);
            // 
            // fld_lkeHREmployeeID
            // 
            this.fld_lkeHREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeID.BOSComment = null;
            this.fld_lkeHREmployeeID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeID.BOSDescription = null;
            this.fld_lkeHREmployeeID.BOSError = null;
            this.fld_lkeHREmployeeID.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID.BOSFieldParent = null;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = null;
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(86, 44);
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeID.TabIndex = 3;
            this.fld_lkeHREmployeeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHREmployeeID_QueryPopUp);
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = null;
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(86, 18);
            this.fld_lkeBRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.ColumnName = null;
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 0;
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
            this.bosLabel6.Location = new System.Drawing.Point(18, 72);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(49, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Text = "Tình trạng";
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
            this.bosLabel5.Location = new System.Drawing.Point(18, 47);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Text = "Nhân viên";
            // 
            // fld_dgcLeaveDays
            // 
            this.fld_dgcLeaveDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcLeaveDays.BOSComment = null;
            this.fld_dgcLeaveDays.BOSDataMember = null;
            this.fld_dgcLeaveDays.BOSDataSource = "HRLeaveDays";
            this.fld_dgcLeaveDays.BOSDescription = null;
            this.fld_dgcLeaveDays.BOSError = null;
            this.fld_dgcLeaveDays.BOSFieldGroup = null;
            this.fld_dgcLeaveDays.BOSFieldRelation = null;
            this.fld_dgcLeaveDays.BOSGridType = null;
            this.fld_dgcLeaveDays.BOSPrivilege = null;
            this.fld_dgcLeaveDays.BOSPropertyName = null;
            this.fld_dgcLeaveDays.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcLeaveDays.FromDate = new System.DateTime(((long)(0)));
            this.fld_dgcLeaveDays.GridViewMain = null;
            this.fld_dgcLeaveDays.Location = new System.Drawing.Point(3, 107);
            this.fld_dgcLeaveDays.MenuManager = this.screenToolbar;
            this.fld_dgcLeaveDays.Name = "fld_dgcLeaveDays";
            this.fld_dgcLeaveDays.PrintReport = false;
            this.fld_dgcLeaveDays.RowHandle = 0;
            this.fld_dgcLeaveDays.Screen = null;
            this.fld_dgcLeaveDays.Size = new System.Drawing.Size(875, 411);
            this.fld_dgcLeaveDays.TabIndex = 0;
            this.fld_dgcLeaveDays.ToDate = new System.DateTime(((long)(0)));
            this.fld_dgcLeaveDays.ViewDate = new System.DateTime(((long)(0)));
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
            this.bosPanel2.Controls.Add(this.bosPanel1);
            this.bosPanel2.Controls.Add(this.bosButton1);
            this.bosPanel2.Controls.Add(this.fld_btnSave);
            this.bosPanel2.Controls.Add(this.fld_dgcLeaveDays);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(881, 567);
            this.bosPanel2.TabIndex = 0;
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(713, 524);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 1;
            this.bosButton1.Text = "Xuất Excel";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(794, 524);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSave.TabIndex = 2;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // DMLD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(881, 567);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMLD100";
            this.Text = "Quản lý ngày nghỉ";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeePayrollFormulaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcLeaveDays)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSButton fld_btnView;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentID;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRoomID;
        private LeaveDayGridControl fld_dgcLeaveDays;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSButton fld_btnSave;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeStatus;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel fld_lblLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeePayrollFormulaID;
        private BOSComponent.BOSLabel bosLabel7;
	}
}
