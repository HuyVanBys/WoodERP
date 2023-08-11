using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTimeSheetAudit.UI
{
	/// <summary>
	/// Summary description for SMHRTSA100
	/// </summary>
	partial class SMHRTSA100
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
            this.fld_dgcHRTimeSheetAudit = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRTimeSheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtHRTimeSheetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRTimeSheetName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRTimeSheetDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRTimeSheetDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblHRTimeSheetType1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTimeSheetType1 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRTimeSheetAudit
            // 
            this.fld_dgcHRTimeSheetAudit.AllowDrop = true;
            this.fld_dgcHRTimeSheetAudit.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dgcHRTimeSheetAudit.BOSDescription = null;
            this.fld_dgcHRTimeSheetAudit.BOSError = null;
            this.fld_dgcHRTimeSheetAudit.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHRTimeSheetAudit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTimeSheetAudit.Location = new System.Drawing.Point(37, 186);
            this.fld_dgcHRTimeSheetAudit.MainView = this.fld_dgvHRTimeSheet;
            this.fld_dgcHRTimeSheetAudit.Name = "fld_dgcHRTimeSheetAudit";
            this.fld_dgcHRTimeSheetAudit.Screen = null;
            this.fld_dgcHRTimeSheetAudit.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRTimeSheetAudit.TabIndex = 7;
            this.fld_dgcHRTimeSheetAudit.Tag = "SR";
            this.fld_dgcHRTimeSheetAudit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTimeSheet});
            // 
            // fld_dgvHRTimeSheet
            // 
            this.fld_dgvHRTimeSheet.GridControl = this.fld_dgcHRTimeSheetAudit;
            this.fld_dgvHRTimeSheet.Name = "fld_dgvHRTimeSheet";
            this.fld_dgvHRTimeSheet.PaintStyleName = "Office2003";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(37, 122);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 100;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = "";
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRTimeSheetAudits";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = "";
            this.fld_lkeFK_BRBranchID.BOSFieldParent = "";
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = "";
            this.fld_lkeFK_BRBranchID.BOSPrivilege = "";
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = "";
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = "";
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(142, 120);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 92;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_txtHRTimeSheetNo
            // 
            this.fld_txtHRTimeSheetNo.BOSComment = "";
            this.fld_txtHRTimeSheetNo.BOSDataMember = "HRTimeSheetAuditNo";
            this.fld_txtHRTimeSheetNo.BOSDataSource = "HRTimeSheetAudits";
            this.fld_txtHRTimeSheetNo.BOSDescription = null;
            this.fld_txtHRTimeSheetNo.BOSError = null;
            this.fld_txtHRTimeSheetNo.BOSFieldGroup = "";
            this.fld_txtHRTimeSheetNo.BOSFieldRelation = "";
            this.fld_txtHRTimeSheetNo.BOSPrivilege = "";
            this.fld_txtHRTimeSheetNo.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetNo.EditValue = "";
            this.fld_txtHRTimeSheetNo.Location = new System.Drawing.Point(142, 44);
            this.fld_txtHRTimeSheetNo.Name = "fld_txtHRTimeSheetNo";
            this.fld_txtHRTimeSheetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetNo.Screen = null;
            this.fld_txtHRTimeSheetNo.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRTimeSheetNo.TabIndex = 89;
            this.fld_txtHRTimeSheetNo.Tag = "SC";
            // 
            // fld_txtHRTimeSheetName
            // 
            this.fld_txtHRTimeSheetName.BOSComment = "";
            this.fld_txtHRTimeSheetName.BOSDataMember = "HRTimeSheetAuditName";
            this.fld_txtHRTimeSheetName.BOSDataSource = "HRTimeSheetAudits";
            this.fld_txtHRTimeSheetName.BOSDescription = null;
            this.fld_txtHRTimeSheetName.BOSError = null;
            this.fld_txtHRTimeSheetName.BOSFieldGroup = "";
            this.fld_txtHRTimeSheetName.BOSFieldRelation = "";
            this.fld_txtHRTimeSheetName.BOSPrivilege = "";
            this.fld_txtHRTimeSheetName.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetName.EditValue = "";
            this.fld_txtHRTimeSheetName.Location = new System.Drawing.Point(142, 68);
            this.fld_txtHRTimeSheetName.Name = "fld_txtHRTimeSheetName";
            this.fld_txtHRTimeSheetName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetName.Screen = null;
            this.fld_txtHRTimeSheetName.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRTimeSheetName.TabIndex = 90;
            this.fld_txtHRTimeSheetName.Tag = "SC";
            // 
            // fld_dteHRTimeSheetDateTo
            // 
            this.fld_dteHRTimeSheetDateTo.BOSComment = "";
            this.fld_dteHRTimeSheetDateTo.BOSDataMember = "HRTimeSheetAuditDateTo";
            this.fld_dteHRTimeSheetDateTo.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dteHRTimeSheetDateTo.BOSDescription = null;
            this.fld_dteHRTimeSheetDateTo.BOSError = null;
            this.fld_dteHRTimeSheetDateTo.BOSFieldGroup = "";
            this.fld_dteHRTimeSheetDateTo.BOSFieldRelation = "";
            this.fld_dteHRTimeSheetDateTo.BOSPrivilege = "";
            this.fld_dteHRTimeSheetDateTo.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetDateTo.EditValue = null;
            this.fld_dteHRTimeSheetDateTo.Location = new System.Drawing.Point(426, 146);
            this.fld_dteHRTimeSheetDateTo.Name = "fld_dteHRTimeSheetDateTo";
            this.fld_dteHRTimeSheetDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetDateTo.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetDateTo.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRTimeSheetDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetDateTo.Screen = null;
            this.fld_dteHRTimeSheetDateTo.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRTimeSheetDateTo.TabIndex = 94;
            this.fld_dteHRTimeSheetDateTo.Tag = "SC";
            // 
            // fld_dteHRTimeSheetDateFrom
            // 
            this.fld_dteHRTimeSheetDateFrom.BOSComment = "";
            this.fld_dteHRTimeSheetDateFrom.BOSDataMember = "HRTimeSheetAuditDateFrom";
            this.fld_dteHRTimeSheetDateFrom.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dteHRTimeSheetDateFrom.BOSDescription = null;
            this.fld_dteHRTimeSheetDateFrom.BOSError = null;
            this.fld_dteHRTimeSheetDateFrom.BOSFieldGroup = "";
            this.fld_dteHRTimeSheetDateFrom.BOSFieldRelation = "";
            this.fld_dteHRTimeSheetDateFrom.BOSPrivilege = "";
            this.fld_dteHRTimeSheetDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetDateFrom.EditValue = null;
            this.fld_dteHRTimeSheetDateFrom.Location = new System.Drawing.Point(142, 146);
            this.fld_dteHRTimeSheetDateFrom.Name = "fld_dteHRTimeSheetDateFrom";
            this.fld_dteHRTimeSheetDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetDateFrom.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetDateFrom.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRTimeSheetDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetDateFrom.Screen = null;
            this.fld_dteHRTimeSheetDateFrom.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRTimeSheetDateFrom.TabIndex = 93;
            this.fld_dteHRTimeSheetDateFrom.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.Location = new System.Drawing.Point(37, 46);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel.TabIndex = 95;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã bảng công";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel2.Location = new System.Drawing.Point(400, 149);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 98;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.Location = new System.Drawing.Point(37, 70);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel1.TabIndex = 96;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên bảng công";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel2.Location = new System.Drawing.Point(37, 148);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(98, 13);
            this.fld_lblLabel2.TabIndex = 97;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Tháng chấm công từ";
            // 
            // fld_lblHRTimeSheetType1
            // 
            this.fld_lblHRTimeSheetType1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRTimeSheetType1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRTimeSheetType1.Appearance.Options.UseBackColor = true;
            this.fld_lblHRTimeSheetType1.Appearance.Options.UseForeColor = true;
            this.fld_lblHRTimeSheetType1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSDescription = null;
            this.fld_lblHRTimeSheetType1.BOSError = null;
            this.fld_lblHRTimeSheetType1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRTimeSheetType1.Location = new System.Drawing.Point(37, 97);
            this.fld_lblHRTimeSheetType1.Name = "fld_lblHRTimeSheetType1";
            this.fld_lblHRTimeSheetType1.Screen = null;
            this.fld_lblHRTimeSheetType1.Size = new System.Drawing.Size(76, 13);
            this.fld_lblHRTimeSheetType1.TabIndex = 99;
            this.fld_lblHRTimeSheetType1.Tag = "SI";
            this.fld_lblHRTimeSheetType1.Text = "Loại bảng lương";
            // 
            // fld_lkeHRTimeSheetType1
            // 
            this.fld_lkeHRTimeSheetType1.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetType1.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetType1.BOSComment = "";
            this.fld_lkeHRTimeSheetType1.BOSDataMember = "HRTimeSheetAuditType";
            this.fld_lkeHRTimeSheetType1.BOSDataSource = "HRTimeSheetAudits";
            this.fld_lkeHRTimeSheetType1.BOSDescription = null;
            this.fld_lkeHRTimeSheetType1.BOSError = null;
            this.fld_lkeHRTimeSheetType1.BOSFieldGroup = "";
            this.fld_lkeHRTimeSheetType1.BOSFieldParent = "";
            this.fld_lkeHRTimeSheetType1.BOSFieldRelation = "";
            this.fld_lkeHRTimeSheetType1.BOSPrivilege = "";
            this.fld_lkeHRTimeSheetType1.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetType1.BOSSelectType = "";
            this.fld_lkeHRTimeSheetType1.BOSSelectTypeValue = "";
            this.fld_lkeHRTimeSheetType1.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetType1.Location = new System.Drawing.Point(142, 94);
            this.fld_lkeHRTimeSheetType1.Name = "fld_lkeHRTimeSheetType1";
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRTimeSheetType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetType1.Properties.NullText = "";
            this.fld_lkeHRTimeSheetType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRTimeSheetType1.Screen = null;
            this.fld_lkeHRTimeSheetType1.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeHRTimeSheetType1.TabIndex = 91;
            this.fld_lkeHRTimeSheetType1.Tag = "SC";
            // 
            // SMHRTSA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_txtHRTimeSheetNo);
            this.Controls.Add(this.fld_txtHRTimeSheetName);
            this.Controls.Add(this.fld_dteHRTimeSheetDateTo);
            this.Controls.Add(this.fld_dteHRTimeSheetDateFrom);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblHRTimeSheetType1);
            this.Controls.Add(this.fld_lkeHRTimeSheetType1);
            this.Controls.Add(this.fld_dgcHRTimeSheetAudit);
            this.Name = "SMHRTSA100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHRTimeSheetAudit, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRTimeSheetType1, 0);
            this.Controls.SetChildIndex(this.fld_lblHRTimeSheetType1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteHRTimeSheetDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteHRTimeSheetDateTo, 0);
            this.Controls.SetChildIndex(this.fld_txtHRTimeSheetName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRTimeSheetNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheetAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcHRTimeSheetAudit;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTimeSheet;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTextBox fld_txtHRTimeSheetNo;
        private BOSComponent.BOSTextBox fld_txtHRTimeSheetName;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetDateTo;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetDateFrom;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblHRTimeSheetType1;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetType1;
	}
}
