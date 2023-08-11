using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRequest.UI
{
	/// <summary>
	/// Summary description for SMHAR100
	/// </summary>
	partial class SMHAR100
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
            this.fld_txtHRAdvanceRequestNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRAdvanceRequestDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRAdvanceRequestExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcHRAdvanceRequests = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRDisciplines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeHRAdvanceRequestStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRAdvanceRequestNo
            // 
            this.fld_txtHRAdvanceRequestNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestNo.BOSDataMember = "HRAdvanceRequestNo";
            this.fld_txtHRAdvanceRequestNo.BOSDataSource = "HRAdvanceRequests";
            this.fld_txtHRAdvanceRequestNo.BOSDescription = null;
            this.fld_txtHRAdvanceRequestNo.BOSError = null;
            this.fld_txtHRAdvanceRequestNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestNo.BOSPropertyName = "Text";
            this.fld_txtHRAdvanceRequestNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestNo.Location = new System.Drawing.Point(121, 12);
            this.fld_txtHRAdvanceRequestNo.Name = "fld_txtHRAdvanceRequestNo";
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdvanceRequestNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdvanceRequestNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdvanceRequestNo.Screen = null;
            this.fld_txtHRAdvanceRequestNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRequestNo.TabIndex = 0;
            this.fld_txtHRAdvanceRequestNo.Tag = "SC";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(121, 64);
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 2;
            this.fld_lkeFK_ACSegmentID.Tag = "SC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Location = new System.Drawing.Point(18, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(85, 13);
            this.bosLabel7.TabIndex = 56;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Khoản mục chi phí";
            // 
            // fld_dteHRAdvanceRequestDate
            // 
            this.fld_dteHRAdvanceRequestDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdvanceRequestDate.BOSDataMember = "HRAdvanceRequestDate";
            this.fld_dteHRAdvanceRequestDate.BOSDataSource = "HRAdvanceRequests";
            this.fld_dteHRAdvanceRequestDate.BOSDescription = null;
            this.fld_dteHRAdvanceRequestDate.BOSError = null;
            this.fld_dteHRAdvanceRequestDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdvanceRequestDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdvanceRequestDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHRAdvanceRequestDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAdvanceRequestDate.EditValue = null;
            this.fld_dteHRAdvanceRequestDate.Location = new System.Drawing.Point(121, 38);
            this.fld_dteHRAdvanceRequestDate.Name = "fld_dteHRAdvanceRequestDate";
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdvanceRequestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdvanceRequestDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdvanceRequestDate.Screen = null;
            this.fld_dteHRAdvanceRequestDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRAdvanceRequestDate.TabIndex = 1;
            this.fld_dteHRAdvanceRequestDate.Tag = "SC";
            // 
            // fld_txtHRAdvanceRequestExchangeRate
            // 
            this.fld_txtHRAdvanceRequestExchangeRate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDataMember = "HRAdvanceRequestExchangeRate";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDataSource = "HRAdvanceRequests";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDescription = null;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSError = null;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSPropertyName = "Text";
            this.fld_txtHRAdvanceRequestExchangeRate.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHRAdvanceRequestExchangeRate.Location = new System.Drawing.Point(121, 116);
            this.fld_txtHRAdvanceRequestExchangeRate.Name = "fld_txtHRAdvanceRequestExchangeRate";
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdvanceRequestExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdvanceRequestExchangeRate.Screen = null;
            this.fld_txtHRAdvanceRequestExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRequestExchangeRate.TabIndex = 4;
            this.fld_txtHRAdvanceRequestExchangeRate.Tag = "SC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(18, 119);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 54;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(18, 41);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 48;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(18, 93);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 53;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(18, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 45;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(121, 90);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID.Tag = "SC";
            // 
            // fld_dgcHRAdvanceRequests
            // 
            this.fld_dgcHRAdvanceRequests.AllowDrop = true;
            this.fld_dgcHRAdvanceRequests.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdvanceRequests.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdvanceRequests.BOSDataSource = "HRAdvanceRequests";
            this.fld_dgcHRAdvanceRequests.BOSDescription = null;
            this.fld_dgcHRAdvanceRequests.BOSError = null;
            this.fld_dgcHRAdvanceRequests.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdvanceRequests.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdvanceRequests.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcHRAdvanceRequests.BOSPropertyName = "Search Result";
            this.fld_dgcHRAdvanceRequests.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRAdvanceRequests.Location = new System.Drawing.Point(18, 197);
            this.fld_dgcHRAdvanceRequests.MainView = this.fld_dgvHRDisciplines;
            this.fld_dgcHRAdvanceRequests.Name = "fld_dgcHRAdvanceRequests";
            this.fld_dgcHRAdvanceRequests.Screen = null;
            this.fld_dgcHRAdvanceRequests.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRAdvanceRequests.TabIndex = 57;
            this.fld_dgcHRAdvanceRequests.Tag = "SR";
            this.fld_dgcHRAdvanceRequests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRDisciplines});
            // 
            // fld_dgvHRDisciplines
            // 
            this.fld_dgvHRDisciplines.GridControl = this.fld_dgcHRAdvanceRequests;
            this.fld_dgvHRDisciplines.Name = "fld_dgvHRDisciplines";
            this.fld_dgvHRDisciplines.PaintStyleName = "Office2003";
            // 
            // fld_lkeHRAdvanceRequestStatus
            // 
            this.fld_lkeHRAdvanceRequestStatus.BOSAllowAddNew = false;
            this.fld_lkeHRAdvanceRequestStatus.BOSAllowDummy = false;
            this.fld_lkeHRAdvanceRequestStatus.BOSComment = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSDataMember = "HRAdvanceRequestStatus";
            this.fld_lkeHRAdvanceRequestStatus.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeHRAdvanceRequestStatus.BOSDescription = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSError = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldGroup = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldParent = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldRelation = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSPrivilege = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdvanceRequestStatus.BOSSelectType = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRAdvanceRequestStatus.CurrentDisplayText = null;
            this.fld_lkeHRAdvanceRequestStatus.Location = new System.Drawing.Point(121, 142);
            this.fld_lkeHRAdvanceRequestStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRAdvanceRequestStatus.Name = "fld_lkeHRAdvanceRequestStatus";
            this.fld_lkeHRAdvanceRequestStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRAdvanceRequestStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdvanceRequestStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdvanceRequestStatus.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeHRAdvanceRequestStatus.Properties.ReadOnly = true;
            this.fld_lkeHRAdvanceRequestStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdvanceRequestStatus.Screen = null;
            this.fld_lkeHRAdvanceRequestStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRAdvanceRequestStatus.TabIndex = 5;
            this.fld_lkeHRAdvanceRequestStatus.Tag = "SC";
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
            this.fld_lblLabel25.Location = new System.Drawing.Point(18, 145);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 59;
            this.fld_lblLabel25.Tag = "SI";
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // SMHAR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(523, 409);
            this.Controls.Add(this.fld_lkeHRAdvanceRequestStatus);
            this.Controls.Add(this.fld_lblLabel25);
            this.Controls.Add(this.fld_dgcHRAdvanceRequests);
            this.Controls.Add(this.fld_txtHRAdvanceRequestNo);
            this.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.Controls.Add(this.bosLabel7);
            this.Controls.Add(this.fld_dteHRAdvanceRequestDate);
            this.Controls.Add(this.fld_txtHRAdvanceRequestExchangeRate);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.Name = "SMHAR100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_GECurrencyID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtHRAdvanceRequestExchangeRate, 0);
            this.Controls.SetChildIndex(this.fld_dteHRAdvanceRequestDate, 0);
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ACSegmentID, 0);
            this.Controls.SetChildIndex(this.fld_txtHRAdvanceRequestNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRAdvanceRequests, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel25, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRAdvanceRequestStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSTextBox fld_txtHRAdvanceRequestNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteHRAdvanceRequestDate;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRequestExchangeRate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcHRAdvanceRequests;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRDisciplines;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdvanceRequestStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
	}
}
