using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryStockCount.UI
{
	/// <summary>
	/// Summary description for SMISC100
	/// </summary>
	partial class SMISC100
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
            this.fld_dgcICInventoryStockCounts = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICInventoryStockCountName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICInventoryStockCountNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSearchFromICInventoryStockCountDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICInventoryStockCountDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStockCounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICInventoryStockCountDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICInventoryStockCountDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICInventoryStockCountDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICInventoryStockCountDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICInventoryStockCounts
            // 
            this.fld_dgcICInventoryStockCounts.AllowDrop = true;
            this.fld_dgcICInventoryStockCounts.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICInventoryStockCounts.BOSDataMember = null;
            this.fld_dgcICInventoryStockCounts.BOSDataSource = "ICInventoryStockCounts";
            this.fld_dgcICInventoryStockCounts.BOSDescription = null;
            this.fld_dgcICInventoryStockCounts.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICInventoryStockCounts.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICInventoryStockCounts.BOSFieldRelation = null;
            this.fld_dgcICInventoryStockCounts.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICInventoryStockCounts.BOSPropertyName = null;
            this.fld_dgcICInventoryStockCounts.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcICInventoryStockCounts.Location = new System.Drawing.Point(41, 172);
            this.fld_dgcICInventoryStockCounts.MainView = this.fld_dgvARCustomer;
            this.fld_dgcICInventoryStockCounts.Name = "fld_dgcICInventoryStockCounts";
            this.fld_dgcICInventoryStockCounts.Screen = null;
            this.fld_dgcICInventoryStockCounts.Size = new System.Drawing.Size(515, 243);
            this.fld_dgcICInventoryStockCounts.TabIndex = 69;
            this.fld_dgcICInventoryStockCounts.Tag = "SR";
            this.fld_dgcICInventoryStockCounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCustomer});
            // 
            // fld_dgvARCustomer
            // 
            this.fld_dgvARCustomer.GridControl = this.fld_dgcICInventoryStockCounts;
            this.fld_dgvARCustomer.Name = "fld_dgvARCustomer";
            this.fld_dgvARCustomer.PaintStyleName = "Office2003";
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
            this.bosLabel4.Location = new System.Drawing.Point(52, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(79, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tên lần kiểm kho";
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
            this.bosLabel3.Location = new System.Drawing.Point(52, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(75, 13);
            this.bosLabel3.TabIndex = 11;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Mã lần kiểm kho";
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
            this.bosLabel2.Location = new System.Drawing.Point(52, 90);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Người kiểm";
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
            this.bosLabel1.Location = new System.Drawing.Point(52, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(18, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Kho";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(155, 87);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_txtICInventoryStockCountName
            // 
            this.fld_txtICInventoryStockCountName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICInventoryStockCountName.BOSDataMember = "ICInventoryStockCountName";
            this.fld_txtICInventoryStockCountName.BOSDataSource = "ICInventoryStockCounts";
            this.fld_txtICInventoryStockCountName.BOSDescription = null;
            this.fld_txtICInventoryStockCountName.BOSError = null;
            this.fld_txtICInventoryStockCountName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICInventoryStockCountName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICInventoryStockCountName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICInventoryStockCountName.BOSPropertyName = "Text";
            this.fld_txtICInventoryStockCountName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICInventoryStockCountName.Location = new System.Drawing.Point(155, 35);
            this.fld_txtICInventoryStockCountName.Name = "fld_txtICInventoryStockCountName";
            this.fld_txtICInventoryStockCountName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICInventoryStockCountName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICInventoryStockCountName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICInventoryStockCountName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICInventoryStockCountName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICInventoryStockCountName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICInventoryStockCountName.Screen = null;
            this.fld_txtICInventoryStockCountName.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICInventoryStockCountName.TabIndex = 1;
            this.fld_txtICInventoryStockCountName.Tag = "SC";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = true;
            this.fld_lkeFK_ICStockID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(155, 61);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockNo";
            this.fld_lkeFK_ICStockID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 2;
            this.fld_lkeFK_ICStockID.Tag = "SC";
            // 
            // fld_txtICInventoryStockCountNo
            // 
            this.fld_txtICInventoryStockCountNo.BOSComment = null;
            this.fld_txtICInventoryStockCountNo.BOSDataMember = "ICInventoryStockCountNo";
            this.fld_txtICInventoryStockCountNo.BOSDataSource = "ICInventoryStockCounts";
            this.fld_txtICInventoryStockCountNo.BOSDescription = null;
            this.fld_txtICInventoryStockCountNo.BOSError = null;
            this.fld_txtICInventoryStockCountNo.BOSFieldGroup = null;
            this.fld_txtICInventoryStockCountNo.BOSFieldRelation = null;
            this.fld_txtICInventoryStockCountNo.BOSPrivilege = null;
            this.fld_txtICInventoryStockCountNo.BOSPropertyName = null;
            this.fld_txtICInventoryStockCountNo.Location = new System.Drawing.Point(155, 9);
            this.fld_txtICInventoryStockCountNo.MenuManager = this.screenToolbar;
            this.fld_txtICInventoryStockCountNo.Name = "fld_txtICInventoryStockCountNo";
            this.fld_txtICInventoryStockCountNo.Screen = null;
            this.fld_txtICInventoryStockCountNo.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICInventoryStockCountNo.TabIndex = 0;
            this.fld_txtICInventoryStockCountNo.Tag = "SC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Location = new System.Drawing.Point(52, 116);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 74;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(155, 113);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_dteSearchFromICInventoryStockCountDate
            // 
            this.fld_dteSearchFromICInventoryStockCountDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSDataMember = "InventoryStockCountDateFrom";
            this.fld_dteSearchFromICInventoryStockCountDate.BOSDataSource = "ICInventoryStockCounts";
            this.fld_dteSearchFromICInventoryStockCountDate.BOSDescription = null;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSError = null;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromICInventoryStockCountDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICInventoryStockCountDate.EditValue = null;
            this.fld_dteSearchFromICInventoryStockCountDate.Location = new System.Drawing.Point(155, 139);
            this.fld_dteSearchFromICInventoryStockCountDate.Name = "fld_dteSearchFromICInventoryStockCountDate";
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICInventoryStockCountDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICInventoryStockCountDate.Screen = null;
            this.fld_dteSearchFromICInventoryStockCountDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromICInventoryStockCountDate.TabIndex = 5;
            this.fld_dteSearchFromICInventoryStockCountDate.Tag = "SC";
            // 
            // fld_dteSearchToICInventoryStockCountDate
            // 
            this.fld_dteSearchToICInventoryStockCountDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICInventoryStockCountDate.BOSDataMember = "InventoryStockCountDateTo";
            this.fld_dteSearchToICInventoryStockCountDate.BOSDataSource = "ICInventoryStockCounts";
            this.fld_dteSearchToICInventoryStockCountDate.BOSDescription = null;
            this.fld_dteSearchToICInventoryStockCountDate.BOSError = null;
            this.fld_dteSearchToICInventoryStockCountDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICInventoryStockCountDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICInventoryStockCountDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToICInventoryStockCountDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICInventoryStockCountDate.EditValue = null;
            this.fld_dteSearchToICInventoryStockCountDate.Location = new System.Drawing.Point(374, 139);
            this.fld_dteSearchToICInventoryStockCountDate.Name = "fld_dteSearchToICInventoryStockCountDate";
            this.fld_dteSearchToICInventoryStockCountDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICInventoryStockCountDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICInventoryStockCountDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICInventoryStockCountDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICInventoryStockCountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICInventoryStockCountDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICInventoryStockCountDate.Screen = null;
            this.fld_dteSearchToICInventoryStockCountDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToICInventoryStockCountDate.TabIndex = 6;
            this.fld_dteSearchToICInventoryStockCountDate.Tag = "SC";
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
            this.bosLabel7.Location = new System.Drawing.Point(311, 142);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(47, 13);
            this.bosLabel7.TabIndex = 78;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Đến ngày";
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
            this.bosLabel5.Location = new System.Drawing.Point(52, 142);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 77;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Từ ngày";
            // 
            // SMISC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(614, 473);
            this.Controls.Add(this.fld_dteSearchFromICInventoryStockCountDate);
            this.Controls.Add(this.fld_dteSearchToICInventoryStockCountDate);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_txtICInventoryStockCountNo);
            this.Controls.Add(this.fld_dgcICInventoryStockCounts);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_ICStockID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtICInventoryStockCountName);
            this.Name = "SMISC100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtICInventoryStockCountName, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICStockID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_dgcICInventoryStockCounts, 0);
            this.Controls.SetChildIndex(this.fld_txtICInventoryStockCountNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICInventoryStockCountDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICInventoryStockCountDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStockCounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICInventoryStockCountDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICInventoryStockCountDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICInventoryStockCountDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICInventoryStockCountDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSTextBox fld_txtICInventoryStockCountName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSSearchResultsGridControl fld_dgcICInventoryStockCounts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCustomer;
        private BOSComponent.BOSTextBox fld_txtICInventoryStockCountNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSDateEdit fld_dteSearchFromICInventoryStockCountDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToICInventoryStockCountDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
	}
}
