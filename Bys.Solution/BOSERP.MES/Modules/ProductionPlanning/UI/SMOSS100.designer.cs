using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionPlanning.UI
{
	/// <summary>
	/// Summary description for SMOSS100
	/// </summary>
	partial class SMOSS100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMOSS100));
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARProductionPlanning = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromARProductionPlanningDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARProductionPlanningDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARProductionPlanningNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARProductionPlanningStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.boslabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProductionPlanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProductionPlanningDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProductionPlanningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProductionPlanningDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProductionPlanningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(30, 15);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 94;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(30, 67);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 99;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(30, 119);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel14.TabIndex = 100;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Từ ngày";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(272, 119);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel17.TabIndex = 102;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ngày";
            // 
            // fld_dgcARProductionPlanning
            // 
            this.fld_dgcARProductionPlanning.AllowDrop = true;
            this.fld_dgcARProductionPlanning.BOSComment = "";
            this.fld_dgcARProductionPlanning.BOSDataMember = "";
            this.fld_dgcARProductionPlanning.BOSDataSource = "ARProductionPlannings";
            this.fld_dgcARProductionPlanning.BOSDescription = null;
            this.fld_dgcARProductionPlanning.BOSError = null;
            this.fld_dgcARProductionPlanning.BOSFieldGroup = "";
            this.fld_dgcARProductionPlanning.BOSFieldRelation = "";
            this.fld_dgcARProductionPlanning.BOSGridType = null;
            this.fld_dgcARProductionPlanning.BOSPrivilege = "";
            this.fld_dgcARProductionPlanning.BOSPropertyName = null;
            this.fld_dgcARProductionPlanning.CommodityType = "";
            this.fld_dgcARProductionPlanning.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARProductionPlanning.Location = new System.Drawing.Point(9, 198);
            this.fld_dgcARProductionPlanning.MainView = this.fld_dgvGridControl;
            this.fld_dgcARProductionPlanning.Name = "fld_dgcARProductionPlanning";
            this.fld_dgcARProductionPlanning.PrintReport = false;
            this.fld_dgcARProductionPlanning.Screen = null;
            this.fld_dgcARProductionPlanning.Size = new System.Drawing.Size(869, 358);
            this.fld_dgcARProductionPlanning.TabIndex = 101;
            this.fld_dgcARProductionPlanning.Tag = "SR";
            this.fld_dgcARProductionPlanning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARProductionPlanning;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromARProductionPlanningDate
            // 
            this.fld_dteSearchFromARProductionPlanningDate.BOSComment = "";
            this.fld_dteSearchFromARProductionPlanningDate.BOSDataMember = "ProductionPlanningFromDate";
            this.fld_dteSearchFromARProductionPlanningDate.BOSDataSource = "ARProductionPlannings";
            this.fld_dteSearchFromARProductionPlanningDate.BOSDescription = null;
            this.fld_dteSearchFromARProductionPlanningDate.BOSError = null;
            this.fld_dteSearchFromARProductionPlanningDate.BOSFieldGroup = "";
            this.fld_dteSearchFromARProductionPlanningDate.BOSFieldRelation = "";
            this.fld_dteSearchFromARProductionPlanningDate.BOSPrivilege = "";
            this.fld_dteSearchFromARProductionPlanningDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARProductionPlanningDate.EditValue = null;
            this.fld_dteSearchFromARProductionPlanningDate.Location = new System.Drawing.Point(104, 116);
            this.fld_dteSearchFromARProductionPlanningDate.Name = "fld_dteSearchFromARProductionPlanningDate";
            this.fld_dteSearchFromARProductionPlanningDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARProductionPlanningDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARProductionPlanningDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARProductionPlanningDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARProductionPlanningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARProductionPlanningDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARProductionPlanningDate.Screen = null;
            this.fld_dteSearchFromARProductionPlanningDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARProductionPlanningDate.TabIndex = 4;
            this.fld_dteSearchFromARProductionPlanningDate.Tag = "SC";
            // 
            // fld_dteSearchToARProductionPlanningDate
            // 
            this.fld_dteSearchToARProductionPlanningDate.BOSComment = "";
            this.fld_dteSearchToARProductionPlanningDate.BOSDataMember = "ProductionPlanningToDate";
            this.fld_dteSearchToARProductionPlanningDate.BOSDataSource = "ARProductionPlannings";
            this.fld_dteSearchToARProductionPlanningDate.BOSDescription = null;
            this.fld_dteSearchToARProductionPlanningDate.BOSError = null;
            this.fld_dteSearchToARProductionPlanningDate.BOSFieldGroup = "";
            this.fld_dteSearchToARProductionPlanningDate.BOSFieldRelation = "";
            this.fld_dteSearchToARProductionPlanningDate.BOSPrivilege = "";
            this.fld_dteSearchToARProductionPlanningDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARProductionPlanningDate.EditValue = null;
            this.fld_dteSearchToARProductionPlanningDate.Location = new System.Drawing.Point(337, 116);
            this.fld_dteSearchToARProductionPlanningDate.Name = "fld_dteSearchToARProductionPlanningDate";
            this.fld_dteSearchToARProductionPlanningDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARProductionPlanningDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARProductionPlanningDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARProductionPlanningDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARProductionPlanningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARProductionPlanningDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARProductionPlanningDate.Screen = null;
            this.fld_dteSearchToARProductionPlanningDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARProductionPlanningDate.TabIndex = 5;
            this.fld_dteSearchToARProductionPlanningDate.Tag = "SC";
            // 
            // fld_txtARProductionPlanningNo
            // 
            this.fld_txtARProductionPlanningNo.BOSComment = "";
            this.fld_txtARProductionPlanningNo.BOSDataMember = "ARProductionPlanningNo";
            this.fld_txtARProductionPlanningNo.BOSDataSource = "ARProductionPlannings";
            this.fld_txtARProductionPlanningNo.BOSDescription = null;
            this.fld_txtARProductionPlanningNo.BOSError = null;
            this.fld_txtARProductionPlanningNo.BOSFieldGroup = "";
            this.fld_txtARProductionPlanningNo.BOSFieldRelation = "";
            this.fld_txtARProductionPlanningNo.BOSPrivilege = "";
            this.fld_txtARProductionPlanningNo.BOSPropertyName = "EditValue";
            this.fld_txtARProductionPlanningNo.EditValue = "";
            this.fld_txtARProductionPlanningNo.Location = new System.Drawing.Point(104, 12);
            this.fld_txtARProductionPlanningNo.Name = "fld_txtARProductionPlanningNo";
            this.fld_txtARProductionPlanningNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARProductionPlanningNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARProductionPlanningNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARProductionPlanningNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARProductionPlanningNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARProductionPlanningNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARProductionPlanningNo.Screen = null;
            this.fld_txtARProductionPlanningNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARProductionPlanningNo.TabIndex = 0;
            this.fld_txtARProductionPlanningNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(104, 64);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(104, 38);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopNo", "Mã xưởng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 1;
            this.fld_lkeFK_MMWorkShopID.Tag = "SC";
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
            this.bosLabel1.Location = new System.Drawing.Point(30, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(31, 13);
            this.bosLabel1.TabIndex = 105;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Xưởng";
            // 
            // fld_lkeARProductionPlanningStatus
            // 
            this.fld_lkeARProductionPlanningStatus.BOSAllowAddNew = false;
            this.fld_lkeARProductionPlanningStatus.BOSAllowDummy = false;
            this.fld_lkeARProductionPlanningStatus.BOSComment = null;
            this.fld_lkeARProductionPlanningStatus.BOSDataMember = "ARProductionPlanningStatus";
            this.fld_lkeARProductionPlanningStatus.BOSDataSource = "ARProductionPlannings";
            this.fld_lkeARProductionPlanningStatus.BOSDescription = null;
            this.fld_lkeARProductionPlanningStatus.BOSError = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldGroup = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldParent = null;
            this.fld_lkeARProductionPlanningStatus.BOSFieldRelation = null;
            this.fld_lkeARProductionPlanningStatus.BOSPrivilege = null;
            this.fld_lkeARProductionPlanningStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARProductionPlanningStatus.BOSSelectType = null;
            this.fld_lkeARProductionPlanningStatus.BOSSelectTypeValue = null;
            this.fld_lkeARProductionPlanningStatus.CurrentDisplayText = null;
            this.fld_lkeARProductionPlanningStatus.Location = new System.Drawing.Point(104, 90);
            this.fld_lkeARProductionPlanningStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARProductionPlanningStatus.Name = "fld_lkeARProductionPlanningStatus";
            this.fld_lkeARProductionPlanningStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeARProductionPlanningStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProductionPlanningStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProductionPlanningStatus.Properties.ColumnName = null;
            this.fld_lkeARProductionPlanningStatus.Properties.NullText = "";
            this.fld_lkeARProductionPlanningStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProductionPlanningStatus.Screen = null;
            this.fld_lkeARProductionPlanningStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARProductionPlanningStatus.TabIndex = 3;
            this.fld_lkeARProductionPlanningStatus.Tag = "SC";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(30, 93);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 107;
            this.fld_lblLabel25.Tag = "SI";
            this.fld_lblLabel25.Text = "Tình trạng";
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
            this.bosLabel2.Location = new System.Drawing.Point(30, 145);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 109;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đối tượng";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = "";
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ARProductionPlanningItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "Product";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(104, 168);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(383, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 110;
            this.fld_lkeFK_ICProductID.Tag = "SC";
            // 
            // boslabel29
            // 
            this.boslabel29.BOSComment = null;
            this.boslabel29.BOSDataMember = null;
            this.boslabel29.BOSDataSource = null;
            this.boslabel29.BOSDescription = null;
            this.boslabel29.BOSError = null;
            this.boslabel29.BOSFieldGroup = null;
            this.boslabel29.BOSFieldRelation = null;
            this.boslabel29.BOSPrivilege = null;
            this.boslabel29.BOSPropertyName = null;
            this.boslabel29.Location = new System.Drawing.Point(30, 171);
            this.boslabel29.Name = "boslabel29";
            this.boslabel29.Screen = null;
            this.boslabel29.Size = new System.Drawing.Size(47, 13);
            this.boslabel29.TabIndex = 111;
            this.boslabel29.Tag = "SI";
            this.boslabel29.Text = "Sản phẩm";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "ARProductionPlanningItems";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(104, 142);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 89;
            this.fld_lkeACObjectAccessKey.Tag = "SC";
            // 
            // SMOSS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.Controls.Add(this.fld_lkeFK_ICProductID);
            this.Controls.Add(this.boslabel29);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeARProductionPlanningStatus);
            this.Controls.Add(this.fld_lblLabel25);
            this.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dgcARProductionPlanning);
            this.Controls.Add(this.fld_dteSearchFromARProductionPlanningDate);
            this.Controls.Add(this.fld_dteSearchToARProductionPlanningDate);
            this.Controls.Add(this.fld_txtARProductionPlanningNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMOSS100.IconOptions.Icon")));
            this.Name = "SMOSS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtARProductionPlanningNo, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARProductionPlanningDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARProductionPlanningDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcARProductionPlanning, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMWorkShopID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel25, 0);
            this.Controls.SetChildIndex(this.fld_lkeARProductionPlanningStatus, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.boslabel29, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID, 0);
            this.Controls.SetChildIndex(this.fld_lkeACObjectAccessKey, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARProductionPlanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProductionPlanningDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARProductionPlanningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProductionPlanningDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARProductionPlanningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARProductionPlanningNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcARProductionPlanning;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARProductionPlanningDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARProductionPlanningDate;
        private BOSComponent.BOSTextBox fld_txtARProductionPlanningNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeARProductionPlanningStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel boslabel29;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
    }
}
