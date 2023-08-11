using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PriceAdjustment.UI
{
	/// <summary>
	/// Summary description for SMPAJ100
	/// </summary>
	partial class SMPAJ100
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
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtICReceiptNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcICReceipt = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvICReceipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(16, 66);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 121;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ICPriceAdjustments";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(133, 63);
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
            this.fld_lkeFK_BRBranchID.TabIndex = 113;
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
            this.fld_lblLabel.Location = new System.Drawing.Point(16, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 109;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(16, 92);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel2.TabIndex = 115;
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
            this.fld_lblLabel111.Location = new System.Drawing.Point(307, 92);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel111.TabIndex = 118;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến";
            // 
            // fld_dteSearchFromICReceiptDate
            // 
            this.fld_dteSearchFromICReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSDataMember = "ReceiptDateFrom";
            this.fld_dteSearchFromICReceiptDate.BOSDataSource = "ICPriceAdjustments";
            this.fld_dteSearchFromICReceiptDate.BOSDescription = null;
            this.fld_dteSearchFromICReceiptDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSFieldRelation = null;
            this.fld_dteSearchFromICReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromICReceiptDate.EditValue = null;
            this.fld_dteSearchFromICReceiptDate.Location = new System.Drawing.Point(133, 89);
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
            this.fld_dteSearchFromICReceiptDate.TabIndex = 114;
            this.fld_dteSearchFromICReceiptDate.Tag = "SC";
            // 
            // fld_dteSearchToICReceiptDate
            // 
            this.fld_dteSearchToICReceiptDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSDataMember = "ReceiptDateTo";
            this.fld_dteSearchToICReceiptDate.BOSDataSource = "ICPriceAdjustments";
            this.fld_dteSearchToICReceiptDate.BOSDescription = null;
            this.fld_dteSearchToICReceiptDate.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSFieldRelation = null;
            this.fld_dteSearchToICReceiptDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToICReceiptDate.EditValue = null;
            this.fld_dteSearchToICReceiptDate.Location = new System.Drawing.Point(349, 89);
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
            this.fld_dteSearchToICReceiptDate.TabIndex = 116;
            this.fld_dteSearchToICReceiptDate.Tag = "SC";
            // 
            // fld_txtICReceiptNo1
            // 
            this.fld_txtICReceiptNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSDataMember = "ICPriceAdjustmentNo";
            this.fld_txtICReceiptNo1.BOSDataSource = "ICPriceAdjustments";
            this.fld_txtICReceiptNo1.BOSDescription = null;
            this.fld_txtICReceiptNo1.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptNo1.BOSPropertyName = "Text";
            this.fld_txtICReceiptNo1.Location = new System.Drawing.Point(133, 12);
            this.fld_txtICReceiptNo1.Name = "fld_txtICReceiptNo1";
            this.fld_txtICReceiptNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptNo1.Screen = null;
            this.fld_txtICReceiptNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo1.TabIndex = 105;
            this.fld_txtICReceiptNo1.Tag = "SC";
            // 
            // fld_dgcICReceipt
            // 
            this.fld_dgcICReceipt.AllowDrop = true;
            this.fld_dgcICReceipt.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSDataMember = null;
            this.fld_dgcICReceipt.BOSDataSource = "ICPriceAdjustments";
            this.fld_dgcICReceipt.BOSDescription = null;
            this.fld_dgcICReceipt.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSFieldRelation = null;
            this.fld_dgcICReceipt.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcICReceipt.BOSPropertyName = null;
            this.fld_dgcICReceipt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceipt.Location = new System.Drawing.Point(16, 134);
            this.fld_dgcICReceipt.MainView = this.fld_dgvICReceipt;
            this.fld_dgcICReceipt.Name = "fld_dgcICReceipt";
            this.fld_dgcICReceipt.Screen = null;
            this.fld_dgcICReceipt.Size = new System.Drawing.Size(504, 286);
            this.fld_dgcICReceipt.TabIndex = 117;
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(16, 40);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 119;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICPriceAdjustments";
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(133, 37);
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
            this.fld_lkeFK_HREmployeeID1.TabIndex = 110;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // SMPAJ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchFromICReceiptDate);
            this.Controls.Add(this.fld_dteSearchToICReceiptDate);
            this.Controls.Add(this.fld_txtICReceiptNo1);
            this.Controls.Add(this.fld_dgcICReceipt);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Name = "SMPAJ100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceipt, 0);
            this.Controls.SetChildIndex(this.fld_txtICReceiptNo1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToICReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromICReceiptDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel111;
        private BOSComponent.BOSDateEdit fld_dteSearchFromICReceiptDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToICReceiptDate;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo1;
        private BOSSearchResultsGridControl fld_dgcICReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICReceipt;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private IContainer components;
	}
}
