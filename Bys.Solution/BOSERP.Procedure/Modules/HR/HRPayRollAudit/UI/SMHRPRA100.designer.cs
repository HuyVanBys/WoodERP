using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRollAudit.UI
{
	/// <summary>
	/// Summary description for SMHRPR100
	/// </summary>
	partial class SMHRPRA100
	{
		private BOSSearchResultsGridControl fld_dgcHRPayRollAudit;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRPayRoll;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSTextBox fld_txtHRPayRollAuditNo;
		private BOSComponent.BOSTextBox fld_txtHRPayRollAuditName;
        private BOSComponent.BOSDateEdit fld_dteHRPayRollAuditDate;
        private BOSComponent.BOSLookupEdit fld_lkeHRPayRollAuditType;


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
            this.fld_dgcHRPayRollAudit = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRPayRoll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRPayRollAuditNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRPayRollAuditName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRPayRollAuditDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeHRPayRollAuditType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRPayRollAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHRPayRollAudit
            // 
            this.fld_dgcHRPayRollAudit.AllowDrop = true;
            this.fld_dgcHRPayRollAudit.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.BOSDataSource = "HRPayRollAudits";
            this.fld_dgcHRPayRollAudit.BOSDescription = null;
            this.fld_dgcHRPayRollAudit.BOSError = null;
            this.fld_dgcHRPayRollAudit.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRPayRollAudit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRPayRollAudit.Location = new System.Drawing.Point(20, 168);
            this.fld_dgcHRPayRollAudit.MainView = this.fld_dgvHRPayRoll;
            this.fld_dgcHRPayRollAudit.Name = "fld_dgcHRPayRollAudit";
            this.fld_dgcHRPayRollAudit.Screen = null;
            this.fld_dgcHRPayRollAudit.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRPayRollAudit.TabIndex = 4;
            this.fld_dgcHRPayRollAudit.Tag = "SR";
            this.fld_dgcHRPayRollAudit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRPayRoll});
            // 
            // fld_dgvHRPayRoll
            // 
            this.fld_dgvHRPayRoll.GridControl = this.fld_dgcHRPayRollAudit;
            this.fld_dgvHRPayRoll.Name = "fld_dgvHRPayRoll";
            this.fld_dgvHRPayRoll.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(60, 19);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã bảng lương";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel1.Location = new System.Drawing.Point(60, 43);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel1.TabIndex = 6;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên bảng lương";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(60, 67);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel2.TabIndex = 7;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Tháng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(60, 91);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Loại bảng lương";
            // 
            // fld_txtHRPayRollAuditNo
            // 
            this.fld_txtHRPayRollAuditNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditNo.BOSDataMember = "HRPayRollAuditNo";
            this.fld_txtHRPayRollAuditNo.BOSDataSource = "HRPayRollAudits";
            this.fld_txtHRPayRollAuditNo.BOSDescription = null;
            this.fld_txtHRPayRollAuditNo.BOSError = null;
            this.fld_txtHRPayRollAuditNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditNo.BOSPropertyName = "Text";
            this.fld_txtHRPayRollAuditNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditNo.Location = new System.Drawing.Point(182, 16);
            this.fld_txtHRPayRollAuditNo.Name = "fld_txtHRPayRollAuditNo";
            this.fld_txtHRPayRollAuditNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollAuditNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollAuditNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollAuditNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollAuditNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollAuditNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollAuditNo.Screen = null;
            this.fld_txtHRPayRollAuditNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRPayRollAuditNo.TabIndex = 10;
            this.fld_txtHRPayRollAuditNo.Tag = "SC";
            // 
            // fld_txtHRPayRollAuditName
            // 
            this.fld_txtHRPayRollAuditName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditName.BOSDataMember = "HRPayRollAuditName";
            this.fld_txtHRPayRollAuditName.BOSDataSource = "HRPayRollAudits";
            this.fld_txtHRPayRollAuditName.BOSDescription = null;
            this.fld_txtHRPayRollAuditName.BOSError = null;
            this.fld_txtHRPayRollAuditName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditName.BOSPropertyName = "Text";
            this.fld_txtHRPayRollAuditName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRPayRollAuditName.Location = new System.Drawing.Point(182, 40);
            this.fld_txtHRPayRollAuditName.Name = "fld_txtHRPayRollAuditName";
            this.fld_txtHRPayRollAuditName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollAuditName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollAuditName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollAuditName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollAuditName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollAuditName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollAuditName.Screen = null;
            this.fld_txtHRPayRollAuditName.Size = new System.Drawing.Size(335, 20);
            this.fld_txtHRPayRollAuditName.TabIndex = 11;
            this.fld_txtHRPayRollAuditName.Tag = "SC";
            // 
            // fld_dteHRPayRollAuditDate
            // 
            this.fld_dteHRPayRollAuditDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRPayRollAuditDate.BOSDataMember = "HRPayRollAuditDate";
            this.fld_dteHRPayRollAuditDate.BOSDataSource = "HRPayRollAudits";
            this.fld_dteHRPayRollAuditDate.BOSDescription = null;
            this.fld_dteHRPayRollAuditDate.BOSError = null;
            this.fld_dteHRPayRollAuditDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRPayRollAuditDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRPayRollAuditDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRPayRollAuditDate.BOSPropertyName = "EditValue";
            this.fld_dteHRPayRollAuditDate.EditValue = null;
            this.fld_dteHRPayRollAuditDate.Location = new System.Drawing.Point(182, 64);
            this.fld_dteHRPayRollAuditDate.Name = "fld_dteHRPayRollAuditDate";
            this.fld_dteHRPayRollAuditDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRPayRollAuditDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRPayRollAuditDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRPayRollAuditDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRPayRollAuditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRPayRollAuditDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollAuditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollAuditDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollAuditDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollAuditDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRPayRollAuditDate.Screen = null;
            this.fld_dteHRPayRollAuditDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRPayRollAuditDate.TabIndex = 12;
            this.fld_dteHRPayRollAuditDate.Tag = "SC";
            // 
            // fld_lkeHRPayRollAuditType
            // 
            this.fld_lkeHRPayRollAuditType.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollAuditType.BOSAllowDummy = true;
            this.fld_lkeHRPayRollAuditType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSDataMember = "HRPayRollAuditType";
            this.fld_lkeHRPayRollAuditType.BOSDataSource = "HRPayRollAudits";
            this.fld_lkeHRPayRollAuditType.BOSDescription = null;
            this.fld_lkeHRPayRollAuditType.BOSError = null;
            this.fld_lkeHRPayRollAuditType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollAuditType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.CurrentDisplayText = null;
            this.fld_lkeHRPayRollAuditType.Location = new System.Drawing.Point(182, 88);
            this.fld_lkeHRPayRollAuditType.Name = "fld_lkeHRPayRollAuditType";
            this.fld_lkeHRPayRollAuditType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRPayRollAuditType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRPayRollAuditType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRPayRollAuditType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRPayRollAuditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollAuditType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRPayRollAuditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRPayRollAuditType.Screen = null;
            this.fld_lkeHRPayRollAuditType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollAuditType.TabIndex = 15;
            this.fld_lkeHRPayRollAuditType.Tag = "SC";
            // 
            // SMHRPRA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHRPayRollAudit);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtHRPayRollAuditNo);
            this.Controls.Add(this.fld_txtHRPayRollAuditName);
            this.Controls.Add(this.fld_dteHRPayRollAuditDate);
            this.Controls.Add(this.fld_lkeHRPayRollAuditType);
            this.Name = "SMHRPRA100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeHRPayRollAuditType, 0);
            this.Controls.SetChildIndex(this.fld_dteHRPayRollAuditDate, 0);
            this.Controls.SetChildIndex(this.fld_txtHRPayRollAuditName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRPayRollAuditNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRPayRollAudit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRPayRollAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRPayRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
