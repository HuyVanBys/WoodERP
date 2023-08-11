using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchReceiptRoundWood.UI
{
	/// <summary>
	/// Summary description for SMBRRW100
	/// </summary>
	partial class SMBRRW100
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
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICReceiptNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICReceipt = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReceipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(58, 126);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 104;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(175, 123);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 96;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(58, 22);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 95;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(58, 48);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 97;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Nhà cung cấp";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(58, 152);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel2.TabIndex = 99;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel111
            // 
            this.fld_lblLabel111.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel111.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel111.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel111.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel111.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSDescription = null;
            this.fld_lblLabel111.BOSError = null;
            this.fld_lblLabel111.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel111.BOSPropertyName = null;
            this.fld_lblLabel111.Location = new System.Drawing.Point(352, 152);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel111.TabIndex = 101;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến";
            // 
            // fld_dteSearchFromICReceiptDate
            // 
            this.fld_dteSearchFromICReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSDataMember = "ReceiptDateFrom";
            this.fld_dteSearchFromICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteSearchFromICReceiptDate.BOSDescription = null;
            this.fld_dteSearchFromICReceiptDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICReceiptDate.EditValue = null;
            this.fld_dteSearchFromICReceiptDate.Location = new System.Drawing.Point(175, 149);
            this.fld_dteSearchFromICReceiptDate.Name = "fld_dteSearchFromICReceiptDate";
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromICReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromICReceiptDate.Screen = null;
            this.fld_dteSearchFromICReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromICReceiptDate.TabIndex = 98;
            this.fld_dteSearchFromICReceiptDate.Tag = "SC";
            // 
            // fld_dteSearchToICReceiptDate
            // 
            this.fld_dteSearchToICReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSDataMember = "ReceiptDateTo";
            this.fld_dteSearchToICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteSearchToICReceiptDate.BOSDescription = null;
            this.fld_dteSearchToICReceiptDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSFieldRelation = null;
            this.fld_dteSearchToICReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICReceiptDate.EditValue = null;
            this.fld_dteSearchToICReceiptDate.Location = new System.Drawing.Point(394, 149);
            this.fld_dteSearchToICReceiptDate.Name = "fld_dteSearchToICReceiptDate";
            this.fld_dteSearchToICReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToICReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToICReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToICReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToICReceiptDate.Screen = null;
            this.fld_dteSearchToICReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToICReceiptDate.TabIndex = 100;
            this.fld_dteSearchToICReceiptDate.Tag = "SC";
            // 
            // fld_txtICReceiptNo1
            // 
            this.fld_txtICReceiptNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo1.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo1.BOSDescription = null;
            this.fld_txtICReceiptNo1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptNo1.Location = new System.Drawing.Point(175, 19);
            this.fld_txtICReceiptNo1.Name = "fld_txtICReceiptNo1";
            this.fld_txtICReceiptNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptNo1.Screen = null;
            this.fld_txtICReceiptNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo1.TabIndex = 91;
            this.fld_txtICReceiptNo1.Tag = "SC";
            // 
            // fld_lkeFK_APSupplierID1
            // 
            this.fld_lkeFK_APSupplierID1.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID1.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_APSupplierID1.BOSDescription = null;
            this.fld_lkeFK_APSupplierID1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.Location = new System.Drawing.Point(175, 45);
            this.fld_lkeFK_APSupplierID1.Name = "fld_lkeFK_APSupplierID1";
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID1.Properties.DisplayMember = "APSupplierNo";
            this.fld_lkeFK_APSupplierID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_APSupplierID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID1.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID1.Screen = null;
            this.fld_lkeFK_APSupplierID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID1.TabIndex = 92;
            this.fld_lkeFK_APSupplierID1.Tag = "SC";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(58, 100);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 102;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(175, 97);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 94;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_lkeFK_ICStockID2
            // 
            this.fld_lkeFK_ICStockID2.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID2.BOSAllowDummy = true;
            this.fld_lkeFK_ICStockID2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID2.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICStockID2.BOSDescription = null;
            this.fld_lkeFK_ICStockID2.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID2.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.Location = new System.Drawing.Point(175, 71);
            this.fld_lkeFK_ICStockID2.Name = "fld_lkeFK_ICStockID2";
            this.fld_lkeFK_ICStockID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID2.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID2.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ICStockID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID2.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID2.Screen = null;
            this.fld_lkeFK_ICStockID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID2.TabIndex = 93;
            this.fld_lkeFK_ICStockID2.Tag = "SC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(58, 74);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(18, 13);
            this.fld_lblLabel8.TabIndex = 103;
            this.fld_lblLabel8.Tag = "SI";
            this.fld_lblLabel8.Text = "Kho";
            // 
            // fld_dgcICReceipt
            // 
            this.fld_dgcICReceipt.AllowDrop = true;
            this.fld_dgcICReceipt.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSDataMember = null;
            this.fld_dgcICReceipt.BOSDataSource = "ICReceipts";
            this.fld_dgcICReceipt.BOSDescription = null;
            this.fld_dgcICReceipt.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSFieldRelation = null;
            this.fld_dgcICReceipt.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSPropertyName = null;
            this.fld_dgcICReceipt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceipt.Location = new System.Drawing.Point(58, 195);
            this.fld_dgcICReceipt.MainView = this.fld_dgvICReceipt;
            this.fld_dgcICReceipt.Name = "fld_dgcICReceipt";
            this.fld_dgcICReceipt.Screen = null;
            this.fld_dgcICReceipt.Size = new System.Drawing.Size(504, 286);
            this.fld_dgcICReceipt.TabIndex = 105;
            this.fld_dgcICReceipt.Tag = "SR";
            this.fld_dgcICReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICReceipt});
            // 
            // fld_dgvICReceipt
            // 
            this.fld_dgvICReceipt.GridControl = this.fld_dgcICReceipt;
            this.fld_dgvICReceipt.Name = "fld_dgvICReceipt";
            this.fld_dgvICReceipt.PaintStyleName = "Office2003";
            // 
            // SMBRRW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(642, 526);
            this.Controls.Add(this.fld_dgcICReceipt);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchFromICReceiptDate);
            this.Controls.Add(this.fld_dteSearchToICReceiptDate);
            this.Controls.Add(this.fld_txtICReceiptNo1);
            this.Controls.Add(this.fld_lkeFK_APSupplierID1);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lkeFK_ICStockID2);
            this.Controls.Add(this.fld_lblLabel8);
            this.Name = "SMBRRW100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICStockID2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_APSupplierID1, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptNo1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceipt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel111;
        private BOSComponent.BOSDateEdit fld_dteSearchFromICReceiptDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToICReceiptDate;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID1;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID2;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcICReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReceipt;
	}
}
