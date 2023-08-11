using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LeaveApplication.UI
{
	/// <summary>
	/// Summary description for SMLA100
	/// </summary>
	partial class SMLA100
	{
		private BOSComponent.BOSTextBox fld_txtSearchHRRequestLeaveDays;
		private BOSComponent.BOSTextBox fld_txtSearchHRRequestLeaveDayNote;
		private BOSComponent.BOSDateEdit fld_dteSearchFromHRRequestLeaveDayDateFrom;
		private BOSComponent.BOSDateEdit fld_dteSearchToHRRequestLeaveDayDate;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSSearchResultsGridControl fld_dgcSearchHRRequestLeaveDays;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHROverTime;


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
            this.fld_txtSearchHRRequestLeaveDays = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtSearchHRRequestLeaveDayNote = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToHRRequestLeaveDayDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcSearchHRRequestLeaveDays = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHROverTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchHRRequestLeaveDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchHRRequestLeaveDayNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRRequestLeaveDayDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRRequestLeaveDayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSearchHRRequestLeaveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHROverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtSearchHRRequestLeaveDays
            // 
            this.fld_txtSearchHRRequestLeaveDays.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDays.BOSDataMember = "HRRequestLeaveDayNo";
            this.fld_txtSearchHRRequestLeaveDays.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtSearchHRRequestLeaveDays.BOSDescription = null;
            this.fld_txtSearchHRRequestLeaveDays.BOSError = null;
            this.fld_txtSearchHRRequestLeaveDays.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDays.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDays.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDays.BOSPropertyName = "Text";
            this.fld_txtSearchHRRequestLeaveDays.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDays.Location = new System.Drawing.Point(157, 63);
            this.fld_txtSearchHRRequestLeaveDays.Name = "fld_txtSearchHRRequestLeaveDays";
            this.fld_txtSearchHRRequestLeaveDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtSearchHRRequestLeaveDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtSearchHRRequestLeaveDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtSearchHRRequestLeaveDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSearchHRRequestLeaveDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtSearchHRRequestLeaveDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtSearchHRRequestLeaveDays.Screen = null;
            this.fld_txtSearchHRRequestLeaveDays.Size = new System.Drawing.Size(125, 20);
            this.fld_txtSearchHRRequestLeaveDays.TabIndex = 0;
            this.fld_txtSearchHRRequestLeaveDays.Tag = "SC";
            // 
            // fld_txtSearchHRRequestLeaveDayNote
            // 
            this.fld_txtSearchHRRequestLeaveDayNote.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSDataMember = "HRRequestLeaveDayNote";
            this.fld_txtSearchHRRequestLeaveDayNote.BOSDataSource = "HRRequestLeaveDays";
            this.fld_txtSearchHRRequestLeaveDayNote.BOSDescription = null;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSError = null;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDayNote.BOSPropertyName = "Text";
            this.fld_txtSearchHRRequestLeaveDayNote.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtSearchHRRequestLeaveDayNote.Location = new System.Drawing.Point(157, 87);
            this.fld_txtSearchHRRequestLeaveDayNote.Name = "fld_txtSearchHRRequestLeaveDayNote";
            this.fld_txtSearchHRRequestLeaveDayNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtSearchHRRequestLeaveDayNote.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtSearchHRRequestLeaveDayNote.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtSearchHRRequestLeaveDayNote.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtSearchHRRequestLeaveDayNote.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtSearchHRRequestLeaveDayNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtSearchHRRequestLeaveDayNote.Screen = null;
            this.fld_txtSearchHRRequestLeaveDayNote.Size = new System.Drawing.Size(125, 20);
            this.fld_txtSearchHRRequestLeaveDayNote.TabIndex = 1;
            this.fld_txtSearchHRRequestLeaveDayNote.Tag = "SC";
            // 
            // fld_dteSearchFromHRRequestLeaveDayDateFrom
            // 
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSDataMember = "LeaveApplicationSearchFromDate";
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSDescription = null;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSError = null;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.EditValue = null;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Location = new System.Drawing.Point(157, 111);
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Name = "fld_dteSearchFromHRRequestLeaveDayDateFrom";
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Screen = null;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.TabIndex = 2;
            this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Tag = "SC";
            // 
            // fld_dteSearchToHRRequestLeaveDayDate
            // 
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSDataMember = "LeaveApplicationSearchToDate";
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSDescription = null;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSError = null;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteSearchToHRRequestLeaveDayDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToHRRequestLeaveDayDate.EditValue = null;
            this.fld_dteSearchToHRRequestLeaveDayDate.Location = new System.Drawing.Point(157, 135);
            this.fld_dteSearchToHRRequestLeaveDayDate.Name = "fld_dteSearchToHRRequestLeaveDayDate";
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToHRRequestLeaveDayDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToHRRequestLeaveDayDate.Screen = null;
            this.fld_dteSearchToHRRequestLeaveDayDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteSearchToHRRequestLeaveDayDate.TabIndex = 3;
            this.fld_dteSearchToHRRequestLeaveDayDate.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel.Location = new System.Drawing.Point(54, 66);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 9;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(54, 90);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 10;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên chứng từ";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(54, 114);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel2.TabIndex = 11;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Từ ngày";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel3.Location = new System.Drawing.Point(54, 138);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel3.TabIndex = 12;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Đến ngày";
            // 
            // fld_dgcSearchHRRequestLeaveDays
            // 
            this.fld_dgcSearchHRRequestLeaveDays.AllowDrop = true;
            this.fld_dgcSearchHRRequestLeaveDays.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dgcSearchHRRequestLeaveDays.BOSDescription = null;
            this.fld_dgcSearchHRRequestLeaveDays.BOSError = null;
            this.fld_dgcSearchHRRequestLeaveDays.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcSearchHRRequestLeaveDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSearchHRRequestLeaveDays.Location = new System.Drawing.Point(12, 221);
            this.fld_dgcSearchHRRequestLeaveDays.MainView = this.fld_dgvHROverTime;
            this.fld_dgcSearchHRRequestLeaveDays.Name = "fld_dgcSearchHRRequestLeaveDays";
            this.fld_dgcSearchHRRequestLeaveDays.Screen = null;
            this.fld_dgcSearchHRRequestLeaveDays.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcSearchHRRequestLeaveDays.TabIndex = 5;
            this.fld_dgcSearchHRRequestLeaveDays.Tag = "SR";
            this.fld_dgcSearchHRRequestLeaveDays.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHROverTime});
            // 
            // fld_dgvHROverTime
            // 
            this.fld_dgvHROverTime.GridControl = this.fld_dgcSearchHRRequestLeaveDays;
            this.fld_dgvHROverTime.Name = "fld_dgvHROverTime";
            this.fld_dgvHROverTime.PaintStyleName = "Office2003";
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
            this.bosLabel1.Location = new System.Drawing.Point(54, 164);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 37;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeSearchFK_BRBranchID
            // 
            this.fld_lkeSearchFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_BRBranchID.BOSComment = null;
            this.fld_lkeSearchFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.BOSDataSource = "HRKPIRegistrations";
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
            this.fld_lkeSearchFK_BRBranchID.Location = new System.Drawing.Point(157, 161);
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
            this.fld_lkeSearchFK_BRBranchID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeSearchFK_BRBranchID.TabIndex = 4;
            this.fld_lkeSearchFK_BRBranchID.Tag = "SC";
            // 
            // SMLA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeSearchFK_BRBranchID);
            this.Controls.Add(this.fld_txtSearchHRRequestLeaveDays);
            this.Controls.Add(this.fld_txtSearchHRRequestLeaveDayNote);
            this.Controls.Add(this.fld_dteSearchFromHRRequestLeaveDayDateFrom);
            this.Controls.Add(this.fld_dteSearchToHRRequestLeaveDayDate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_dgcSearchHRRequestLeaveDays);
            this.Name = "SMLA100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcSearchHRRequestLeaveDays, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToHRRequestLeaveDayDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromHRRequestLeaveDayDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_txtSearchHRRequestLeaveDayNote, 0);
            this.Controls.SetChildIndex(this.fld_txtSearchHRRequestLeaveDays, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchHRRequestLeaveDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSearchHRRequestLeaveDayNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromHRRequestLeaveDayDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRRequestLeaveDayDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToHRRequestLeaveDayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSearchHRRequestLeaveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHROverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_BRBranchID;
	}
}
