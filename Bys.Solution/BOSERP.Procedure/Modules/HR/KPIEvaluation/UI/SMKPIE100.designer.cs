using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.KPIEvaluation.UI
{
	/// <summary>
	/// Summary description for SMKPIE100
	/// </summary>
	partial class SMKPIE100
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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRKPIEvaluations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchKPIEvaluationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchKPIEvaluationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRKPIEvaluationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeSearchFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_HRDepartmentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(33, 40);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã đánh giá";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(33, 66);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 26;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(33, 170);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 27;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(318, 170);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcHRKPIEvaluations
            // 
            this.fld_dgcHRKPIEvaluations.AllowDrop = true;
            this.fld_dgcHRKPIEvaluations.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIEvaluations.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIEvaluations.BOSDataSource = "HRKPIEvaluations";
            this.fld_dgcHRKPIEvaluations.BOSDescription = null;
            this.fld_dgcHRKPIEvaluations.BOSError = null;
            this.fld_dgcHRKPIEvaluations.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIEvaluations.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIEvaluations.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRKPIEvaluations.BOSPropertyName = null;
            this.fld_dgcHRKPIEvaluations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRKPIEvaluations.Location = new System.Drawing.Point(32, 216);
            this.fld_dgcHRKPIEvaluations.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRKPIEvaluations.Name = "fld_dgcHRKPIEvaluations";
            this.fld_dgcHRKPIEvaluations.Screen = null;
            this.fld_dgcHRKPIEvaluations.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRKPIEvaluations.TabIndex = 33;
            this.fld_dgcHRKPIEvaluations.Tag = "SR";
            this.fld_dgcHRKPIEvaluations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRKPIEvaluations;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchKPIEvaluationFromDate
            // 
            this.fld_dteSearchKPIEvaluationFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationFromDate.BOSDataMember = "KPIEvaluationFromDate";
            this.fld_dteSearchKPIEvaluationFromDate.BOSDataSource = "HRKPIEvaluations";
            this.fld_dteSearchKPIEvaluationFromDate.BOSDescription = null;
            this.fld_dteSearchKPIEvaluationFromDate.BOSError = null;
            this.fld_dteSearchKPIEvaluationFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIEvaluationFromDate.EditValue = null;
            this.fld_dteSearchKPIEvaluationFromDate.Location = new System.Drawing.Point(144, 167);
            this.fld_dteSearchKPIEvaluationFromDate.Name = "fld_dteSearchKPIEvaluationFromDate";
            this.fld_dteSearchKPIEvaluationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIEvaluationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIEvaluationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIEvaluationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIEvaluationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIEvaluationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIEvaluationFromDate.Screen = null;
            this.fld_dteSearchKPIEvaluationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIEvaluationFromDate.TabIndex = 3;
            this.fld_dteSearchKPIEvaluationFromDate.Tag = "SC";
            // 
            // fld_dteSearchKPIEvaluationToDate
            // 
            this.fld_dteSearchKPIEvaluationToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationToDate.BOSDataMember = "KPIEvaluationToDate";
            this.fld_dteSearchKPIEvaluationToDate.BOSDataSource = "HRKPIEvaluations";
            this.fld_dteSearchKPIEvaluationToDate.BOSDescription = null;
            this.fld_dteSearchKPIEvaluationToDate.BOSError = null;
            this.fld_dteSearchKPIEvaluationToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchKPIEvaluationToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchKPIEvaluationToDate.EditValue = null;
            this.fld_dteSearchKPIEvaluationToDate.Location = new System.Drawing.Point(357, 167);
            this.fld_dteSearchKPIEvaluationToDate.Name = "fld_dteSearchKPIEvaluationToDate";
            this.fld_dteSearchKPIEvaluationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchKPIEvaluationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchKPIEvaluationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchKPIEvaluationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchKPIEvaluationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchKPIEvaluationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchKPIEvaluationToDate.Screen = null;
            this.fld_dteSearchKPIEvaluationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchKPIEvaluationToDate.TabIndex = 4;
            this.fld_dteSearchKPIEvaluationToDate.Tag = "SC";
            // 
            // fld_txtHRKPIEvaluationNo
            // 
            this.fld_txtHRKPIEvaluationNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRKPIEvaluationNo.BOSDataMember = "HRKPIEvaluationNo";
            this.fld_txtHRKPIEvaluationNo.BOSDataSource = "HRKPIEvaluations";
            this.fld_txtHRKPIEvaluationNo.BOSDescription = null;
            this.fld_txtHRKPIEvaluationNo.BOSError = null;
            this.fld_txtHRKPIEvaluationNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRKPIEvaluationNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRKPIEvaluationNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRKPIEvaluationNo.BOSPropertyName = "EditValue";
            this.fld_txtHRKPIEvaluationNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRKPIEvaluationNo.Location = new System.Drawing.Point(144, 37);
            this.fld_txtHRKPIEvaluationNo.Name = "fld_txtHRKPIEvaluationNo";
            this.fld_txtHRKPIEvaluationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRKPIEvaluationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRKPIEvaluationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRKPIEvaluationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRKPIEvaluationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRKPIEvaluationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRKPIEvaluationNo.Screen = null;
            this.fld_txtHRKPIEvaluationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRKPIEvaluationNo.TabIndex = 0;
            this.fld_txtHRKPIEvaluationNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID2
            // 
            this.fld_lkeFK_HREmployeeID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID2.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSDataMember = "FK_HREmployeeID2";
            this.fld_lkeFK_HREmployeeID2.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeFK_HREmployeeID2.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID2.BOSError = null;
            this.fld_lkeFK_HREmployeeID2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID2.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.Location = new System.Drawing.Point(144, 63);
            this.fld_lkeFK_HREmployeeID2.Name = "fld_lkeFK_HREmployeeID2";
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID2.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID2.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID2.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID2.Screen = null;
            this.fld_lkeFK_HREmployeeID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID2.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID2.Tag = "SC";
            // 
            // fld_lkeSearchFK_BRBranchID
            // 
            this.fld_lkeSearchFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_BRBranchID.BOSComment = null;
            this.fld_lkeSearchFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeSearchFK_BRBranchID.BOSDescription = null;
            this.fld_lkeSearchFK_BRBranchID.BOSError = null;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeSearchFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeSearchFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeSearchFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeSearchFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeSearchFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeSearchFK_BRBranchID.Location = new System.Drawing.Point(144, 89);
            this.fld_lkeSearchFK_BRBranchID.Name = "fld_lkeSearchFK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSearchFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeSearchFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeSearchFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeSearchFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSearchFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Screen = null;
            this.fld_lkeSearchFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeSearchFK_BRBranchID.TabIndex = 2;
            this.fld_lkeSearchFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(32, 92);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 35;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(32, 144);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 45;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Bộ phận";
            // 
            // fld_lkeSearchFK_HRDepartmentRoomID
            // 
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSFieldParent = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Location = new System.Drawing.Point(144, 141);
            this.fld_lkeSearchFK_HRDepartmentRoomID.Name = "fld_lkeSearchFK_HRDepartmentRoomID";
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeSearchFK_HRDepartmentRoomID.Screen = null;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeSearchFK_HRDepartmentRoomID.TabIndex = 44;
            this.fld_lkeSearchFK_HRDepartmentRoomID.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(32, 118);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 43;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Phòng ban";
            // 
            // fld_lkeSearchFK_HRDepartmentID
            // 
            this.fld_lkeSearchFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeSearchFK_HRDepartmentID.BOSDataSource = "HRKPIEvaluations";
            this.fld_lkeSearchFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSError = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSFieldParent = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeSearchFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeSearchFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeSearchFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeSearchFK_HRDepartmentID.Location = new System.Drawing.Point(144, 115);
            this.fld_lkeSearchFK_HRDepartmentID.Name = "fld_lkeSearchFK_HRDepartmentID";
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSearchFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeSearchFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeSearchFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeSearchFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSearchFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeSearchFK_HRDepartmentID.Screen = null;
            this.fld_lkeSearchFK_HRDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeSearchFK_HRDepartmentID.TabIndex = 42;
            this.fld_lkeSearchFK_HRDepartmentID.Tag = "SC";
            // 
            // SMKPIE100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeSearchFK_HRDepartmentRoomID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeSearchFK_HRDepartmentID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeSearchFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRKPIEvaluations);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtHRKPIEvaluationNo);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID2);
            this.Controls.Add(this.fld_dteSearchKPIEvaluationFromDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchKPIEvaluationToDate);
            this.Name = "SMKPIE100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchKPIEvaluationToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchKPIEvaluationFromDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_txtHRKPIEvaluationNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRKPIEvaluations, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_HRDepartmentID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_HRDepartmentRoomID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRKPIEvaluations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchKPIEvaluationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRKPIEvaluationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_HRDepartmentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRKPIEvaluations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIEvaluationFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchKPIEvaluationToDate;
        private BOSComponent.BOSTextBox fld_txtHRKPIEvaluationNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID2;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_HRDepartmentRoomID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_HRDepartmentID;
	}
}
