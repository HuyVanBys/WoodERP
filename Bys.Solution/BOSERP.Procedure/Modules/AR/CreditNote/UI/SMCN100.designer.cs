using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CreditNote.UI
{
	/// <summary>
	/// Summary description for SMCN100
	/// </summary>
	partial class SMCN100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel111;
		private BOSComponent.BOSDateEdit fld_dteSearchToARCreditNoteStartDate;
		private BOSSearchResultsGridControl fld_dgcARCreditNote;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARCreditNote;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARCreditNoteStartDate;
        private BOSComponent.BOSTextBox fld_txtARCreditNoteNo;
		private BOSComponent.BOSLabel fld_lblLabel36;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeARCreditNoteType;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel111 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARCreditNoteStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcARCreditNote = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARCreditNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromARCreditNoteStartDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARCreditNoteNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARCreditNoteType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCreditNoteStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCreditNoteStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCreditNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCreditNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCreditNoteStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCreditNoteStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCreditNoteType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(42, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(43, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã phiếu";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(42, 142);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 7;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(42, 64);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel3.TabIndex = 7;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Loại";
            // 
            // fld_lblLabel111
            // 
            this.fld_lblLabel111.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel111.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel111.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel111.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel111.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSDescription = null;
            this.fld_lblLabel111.BOSError = null;
            this.fld_lblLabel111.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel111.BOSPropertyName = null;
            this.fld_lblLabel111.Location = new System.Drawing.Point(291, 142);
            this.fld_lblLabel111.Name = "fld_lblLabel111";
            this.fld_lblLabel111.Screen = null;
            this.fld_lblLabel111.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel111.TabIndex = 29;
            this.fld_lblLabel111.Tag = "SI";
            this.fld_lblLabel111.Text = "Đến";
            // 
            // fld_dteSearchToARCreditNoteStartDate
            // 
            this.fld_dteSearchToARCreditNoteStartDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToARCreditNoteStartDate.BOSDataMember = "CreditNoteDateTo";
            this.fld_dteSearchToARCreditNoteStartDate.BOSDataSource = "ARCreditNotes";
            this.fld_dteSearchToARCreditNoteStartDate.BOSDescription = null;
            this.fld_dteSearchToARCreditNoteStartDate.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToARCreditNoteStartDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToARCreditNoteStartDate.BOSFieldRelation = null;
            this.fld_dteSearchToARCreditNoteStartDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchToARCreditNoteStartDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARCreditNoteStartDate.EditValue = null;
            this.fld_dteSearchToARCreditNoteStartDate.Location = new System.Drawing.Point(325, 139);
            this.fld_dteSearchToARCreditNoteStartDate.Name = "fld_dteSearchToARCreditNoteStartDate";
            this.fld_dteSearchToARCreditNoteStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARCreditNoteStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARCreditNoteStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARCreditNoteStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARCreditNoteStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARCreditNoteStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARCreditNoteStartDate.Screen = null;
            this.fld_dteSearchToARCreditNoteStartDate.Size = new System.Drawing.Size(138, 20);
            this.fld_dteSearchToARCreditNoteStartDate.TabIndex = 6;
            this.fld_dteSearchToARCreditNoteStartDate.Tag = "SC";
            // 
            // fld_dgcARCreditNote
            // 
            this.fld_dgcARCreditNote.AllowDrop = true;
            this.fld_dgcARCreditNote.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcARCreditNote.BOSDataMember = null;
            this.fld_dgcARCreditNote.BOSDataSource = "ARCreditNotes";
            this.fld_dgcARCreditNote.BOSDescription = null;
            this.fld_dgcARCreditNote.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcARCreditNote.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcARCreditNote.BOSFieldRelation = null;
            this.fld_dgcARCreditNote.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcARCreditNote.BOSPropertyName = null;
            this.fld_dgcARCreditNote.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARCreditNote.Location = new System.Drawing.Point(42, 180);
            this.fld_dgcARCreditNote.MainView = this.fld_dgvARCreditNote;
            this.fld_dgcARCreditNote.Name = "fld_dgcARCreditNote";
            this.fld_dgcARCreditNote.Screen = null;
            this.fld_dgcARCreditNote.Size = new System.Drawing.Size(423, 292);
            this.fld_dgcARCreditNote.TabIndex = 79;
            this.fld_dgcARCreditNote.Tag = "SR";
            this.fld_dgcARCreditNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARCreditNote});
            // 
            // fld_dgvARCreditNote
            // 
            this.fld_dgvARCreditNote.GridControl = this.fld_dgcARCreditNote;
            this.fld_dgvARCreditNote.Name = "fld_dgvARCreditNote";
            this.fld_dgvARCreditNote.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromARCreditNoteStartDate
            // 
            this.fld_dteSearchFromARCreditNoteStartDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSDataMember = "CreditNoteDateFrom";
            this.fld_dteSearchFromARCreditNoteStartDate.BOSDataSource = "ARCreditNotes";
            this.fld_dteSearchFromARCreditNoteStartDate.BOSDescription = null;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteSearchFromARCreditNoteStartDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARCreditNoteStartDate.EditValue = null;
            this.fld_dteSearchFromARCreditNoteStartDate.Location = new System.Drawing.Point(124, 139);
            this.fld_dteSearchFromARCreditNoteStartDate.Name = "fld_dteSearchFromARCreditNoteStartDate";
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARCreditNoteStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARCreditNoteStartDate.Screen = null;
            this.fld_dteSearchFromARCreditNoteStartDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARCreditNoteStartDate.TabIndex = 5;
            this.fld_dteSearchFromARCreditNoteStartDate.Tag = "SC";
            // 
            // fld_txtARCreditNoteNo
            // 
            this.fld_txtARCreditNoteNo.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteNo.BOSDataMember = "ARCreditNoteNo";
            this.fld_txtARCreditNoteNo.BOSDataSource = "ARCreditNotes";
            this.fld_txtARCreditNoteNo.BOSDescription = null;
            this.fld_txtARCreditNoteNo.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARCreditNoteNo.BOSPropertyName = "Text";
            this.fld_txtARCreditNoteNo.Location = new System.Drawing.Point(124, 9);
            this.fld_txtARCreditNoteNo.Name = "fld_txtARCreditNoteNo";
            this.fld_txtARCreditNoteNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCreditNoteNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCreditNoteNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCreditNoteNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCreditNoteNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARCreditNoteNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARCreditNoteNo.Screen = null;
            this.fld_txtARCreditNoteNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARCreditNoteNo.TabIndex = 0;
            this.fld_txtARCreditNoteNo.Tag = "SC";
            // 
            // fld_lblLabel36
            // 
            this.fld_lblLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel36.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel36.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel36.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSDescription = null;
            this.fld_lblLabel36.BOSError = null;
            this.fld_lblLabel36.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel36.BOSPropertyName = null;
            this.fld_lblLabel36.Location = new System.Drawing.Point(42, 90);
            this.fld_lblLabel36.Name = "fld_lblLabel36";
            this.fld_lblLabel36.Screen = null;
            this.fld_lblLabel36.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel36.TabIndex = 84;
            this.fld_lblLabel36.Tag = "SI";
            this.fld_lblLabel36.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARCreditNotes";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(124, 87);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeFName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeARCreditNoteType
            // 
            this.fld_lkeARCreditNoteType.BOSAllowAddNew = false;
            this.fld_lkeARCreditNoteType.BOSAllowDummy = true;
            this.fld_lkeARCreditNoteType.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSDataMember = "ARCreditNoteType";
            this.fld_lkeARCreditNoteType.BOSDataSource = "ARCreditNotes";
            this.fld_lkeARCreditNoteType.BOSDescription = null;
            this.fld_lkeARCreditNoteType.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSPropertyName = "EditValue";
            this.fld_lkeARCreditNoteType.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.Location = new System.Drawing.Point(124, 61);
            this.fld_lkeARCreditNoteType.Name = "fld_lkeARCreditNoteType";
            this.fld_lkeARCreditNoteType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARCreditNoteType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARCreditNoteType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARCreditNoteType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARCreditNoteType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCreditNoteType.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeARCreditNoteType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARCreditNoteType.Screen = null;
            this.fld_lkeARCreditNoteType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCreditNoteType.TabIndex = 2;
            this.fld_lkeARCreditNoteType.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.Location = new System.Drawing.Point(42, 116);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 88;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARCreditNotes";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(124, 113);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 4;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARCreditNotes";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(124, 35);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "SC";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel6.BOSPropertyName = null;
            this.fld_lblLabel6.Location = new System.Drawing.Point(42, 38);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel6.TabIndex = 403;
            this.fld_lblLabel6.Tag = "SI";
            this.fld_lblLabel6.Text = "Đối tượng";
            // 
            // SMCN100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.Controls.Add(this.fld_lblLabel6);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_dgcARCreditNote);
            this.Controls.Add(this.fld_txtARCreditNoteNo);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel111);
            this.Controls.Add(this.fld_dteSearchToARCreditNoteStartDate);
            this.Controls.Add(this.fld_lkeARCreditNoteType);
            this.Controls.Add(this.fld_dteSearchFromARCreditNoteStartDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lblLabel36);
            this.Name = "SMCN100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lblLabel36, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARCreditNoteStartDate, 0);
            this.Controls.SetChildIndex(this.fld_lkeARCreditNoteType, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARCreditNoteStartDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel111, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_txtARCreditNoteNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcARCreditNote, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel6, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACObjectID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCreditNoteStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARCreditNoteStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARCreditNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARCreditNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCreditNoteStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARCreditNoteStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCreditNoteNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCreditNoteType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel6;
	}
}
