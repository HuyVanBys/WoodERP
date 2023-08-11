using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeePieceWork.UI
{
	/// <summary>
	/// Summary description for DMEPW100
	/// </summary>
	partial class DMEPW100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ADMatchCodeBatchComponent = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ilkFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_dteHREmployeePieceWorkFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHREmployeePieceWorkToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medHREmployeePieceWorkRemark = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREmployeePieceWorkAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWorkQuantity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREmployeePieceWorkNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADMatchCodeBatchComponent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ilkFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePieceWorkRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ADMatchCodeBatchComponent);
            this.bosPanel1.Controls.Add(this.fld_ilkFK_ICProductID);
            this.bosPanel1.Controls.Add(this.fld_dteHREmployeePieceWorkFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteHREmployeePieceWorkToDate);
            this.bosPanel1.Controls.Add(this.fld_medHREmployeePieceWorkRemark);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePieceWorkAmount);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePieceWorkQuantity);
            this.bosPanel1.Controls.Add(this.fld_txtHREmployeePieceWorkNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lkeFK_ADMatchCodeBatchComponent
            // 
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSAllowAddNew = false;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSAllowDummy = true;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSDataMember = "FK_ADMatchCodeBatchComponent";
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSDataSource = "HREmployeePieceWorks";
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSDescription = null;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSError = null;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSSelectType = "ADMatchCodeColumnName";
            this.fld_lkeFK_ADMatchCodeBatchComponent.BOSSelectTypeValue = "Component";
            this.fld_lkeFK_ADMatchCodeBatchComponent.CurrentDisplayText = null;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Location = new System.Drawing.Point(98, 116);
            this.fld_lkeFK_ADMatchCodeBatchComponent.Name = "fld_lkeFK_ADMatchCodeBatchComponent";
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADMatchCodeValue", "Thành phần")});
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.DisplayMember = "ADMatchCodeValue";
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.PopupWidth = 40;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Properties.ValueMember = "ADMatchCodeID";
            this.fld_lkeFK_ADMatchCodeBatchComponent.Screen = null;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Size = new System.Drawing.Size(174, 20);
            this.fld_lkeFK_ADMatchCodeBatchComponent.TabIndex = 377;
            this.fld_lkeFK_ADMatchCodeBatchComponent.Tag = "DC";
            // 
            // fld_ilkFK_ICProductID
            // 
            this.fld_ilkFK_ICProductID.BOSAllowAddNew = false;
            this.fld_ilkFK_ICProductID.BOSAllowDummy = false;
            this.fld_ilkFK_ICProductID.BOSComment = null;
            this.fld_ilkFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_ilkFK_ICProductID.BOSDataSource = "HREmployeePieceWorks";
            this.fld_ilkFK_ICProductID.BOSDescription = null;
            this.fld_ilkFK_ICProductID.BOSError = null;
            this.fld_ilkFK_ICProductID.BOSFieldGroup = null;
            this.fld_ilkFK_ICProductID.BOSFieldParent = null;
            this.fld_ilkFK_ICProductID.BOSFieldRelation = null;
            this.fld_ilkFK_ICProductID.BOSPrivilege = null;
            this.fld_ilkFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_ilkFK_ICProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_ilkFK_ICProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_ilkFK_ICProductID.CurrentDisplayText = null;
            this.fld_ilkFK_ICProductID.Location = new System.Drawing.Point(98, 38);
            this.fld_ilkFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_ilkFK_ICProductID.Name = "fld_ilkFK_ICProductID";
            this.fld_ilkFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ilkFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_ilkFK_ICProductID.Properties.ValueMember = "FK_ICProductID";
            this.fld_ilkFK_ICProductID.Screen = null;
            this.fld_ilkFK_ICProductID.Size = new System.Drawing.Size(174, 20);
            this.fld_ilkFK_ICProductID.TabIndex = 376;
            this.fld_ilkFK_ICProductID.Tag = "DC";
            // 
            // fld_dteHREmployeePieceWorkFromDate
            // 
            this.fld_dteHREmployeePieceWorkFromDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSDataMember = "HREmployeePieceWorkFromDate";
            this.fld_dteHREmployeePieceWorkFromDate.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dteHREmployeePieceWorkFromDate.BOSDescription = null;
            this.fld_dteHREmployeePieceWorkFromDate.BOSError = null;
            this.fld_dteHREmployeePieceWorkFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePieceWorkFromDate.EditValue = null;
            this.fld_dteHREmployeePieceWorkFromDate.Location = new System.Drawing.Point(98, 168);
            this.fld_dteHREmployeePieceWorkFromDate.Name = "fld_dteHREmployeePieceWorkFromDate";
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePieceWorkFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePieceWorkFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeePieceWorkFromDate, true);
            this.fld_dteHREmployeePieceWorkFromDate.Size = new System.Drawing.Size(174, 20);
            this.fld_dteHREmployeePieceWorkFromDate.TabIndex = 354;
            this.fld_dteHREmployeePieceWorkFromDate.Tag = "DC";
            // 
            // fld_dteHREmployeePieceWorkToDate
            // 
            this.fld_dteHREmployeePieceWorkToDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSDataMember = "HREmployeePieceWorkToDate";
            this.fld_dteHREmployeePieceWorkToDate.BOSDataSource = "HREmployeePieceWorks";
            this.fld_dteHREmployeePieceWorkToDate.BOSDescription = null;
            this.fld_dteHREmployeePieceWorkToDate.BOSError = null;
            this.fld_dteHREmployeePieceWorkToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteHREmployeePieceWorkToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeePieceWorkToDate.EditValue = null;
            this.fld_dteHREmployeePieceWorkToDate.Location = new System.Drawing.Point(360, 168);
            this.fld_dteHREmployeePieceWorkToDate.Name = "fld_dteHREmployeePieceWorkToDate";
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeePieceWorkToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeePieceWorkToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeePieceWorkToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeePieceWorkToDate, true);
            this.fld_dteHREmployeePieceWorkToDate.Size = new System.Drawing.Size(174, 20);
            this.fld_dteHREmployeePieceWorkToDate.TabIndex = 355;
            this.fld_dteHREmployeePieceWorkToDate.Tag = "DC";
            // 
            // fld_medHREmployeePieceWorkRemark
            // 
            this.fld_medHREmployeePieceWorkRemark.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHREmployeePieceWorkRemark.BOSDataMember = "HREmployeePieceWorkRemark";
            this.fld_medHREmployeePieceWorkRemark.BOSDataSource = "HREmployeePieceWorks";
            this.fld_medHREmployeePieceWorkRemark.BOSDescription = null;
            this.fld_medHREmployeePieceWorkRemark.BOSError = null;
            this.fld_medHREmployeePieceWorkRemark.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHREmployeePieceWorkRemark.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHREmployeePieceWorkRemark.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHREmployeePieceWorkRemark.BOSPropertyName = "EditValue";
            this.fld_medHREmployeePieceWorkRemark.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medHREmployeePieceWorkRemark.Location = new System.Drawing.Point(98, 194);
            this.fld_medHREmployeePieceWorkRemark.Name = "fld_medHREmployeePieceWorkRemark";
            this.fld_medHREmployeePieceWorkRemark.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREmployeePieceWorkRemark.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREmployeePieceWorkRemark.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREmployeePieceWorkRemark.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREmployeePieceWorkRemark.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medHREmployeePieceWorkRemark, true);
            this.fld_medHREmployeePieceWorkRemark.Size = new System.Drawing.Size(436, 37);
            this.fld_medHREmployeePieceWorkRemark.TabIndex = 356;
            this.fld_medHREmployeePieceWorkRemark.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(19, 197);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(40, 13);
            this.bosLabel13.TabIndex = 359;
            this.bosLabel13.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel13.Text = "Diễn giải";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(19, 171);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 358;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Từ ngày";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(294, 171);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 357;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(19, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 353;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Sản phẩm";
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
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(19, 119);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 353;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "Thành phần SX";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "HREmployeePieceWorks";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(98, 90);
            this.fld_lkeFK_MMOperationID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã công đoạn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(174, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 352;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(19, 93);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 353;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Công đoạn";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(19, 145);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(50, 13);
            this.bosLabel6.TabIndex = 101;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Text = "Mức lương";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(19, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(42, 13);
            this.bosLabel5.TabIndex = 101;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Số lượng";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(19, 15);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel4.TabIndex = 101;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mã CH lương";
            // 
            // fld_txtHREmployeePieceWorkAmount
            // 
            this.fld_txtHREmployeePieceWorkAmount.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSDataMember = "HREmployeePieceWorkAmount";
            this.fld_txtHREmployeePieceWorkAmount.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkAmount.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkAmount.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkAmount.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkAmount.Location = new System.Drawing.Point(98, 142);
            this.fld_txtHREmployeePieceWorkAmount.Name = "fld_txtHREmployeePieceWorkAmount";
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkAmount.Screen = null;
            this.fld_txtHREmployeePieceWorkAmount.Size = new System.Drawing.Size(174, 20);
            this.fld_txtHREmployeePieceWorkAmount.TabIndex = 100;
            this.fld_txtHREmployeePieceWorkAmount.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWorkQuantity
            // 
            this.fld_txtHREmployeePieceWorkQuantity.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSDataMember = "HREmployeePieceWorkQuantity";
            this.fld_txtHREmployeePieceWorkQuantity.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkQuantity.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkQuantity.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkQuantity.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkQuantity.Location = new System.Drawing.Point(98, 64);
            this.fld_txtHREmployeePieceWorkQuantity.Name = "fld_txtHREmployeePieceWorkQuantity";
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkQuantity.Screen = null;
            this.fld_txtHREmployeePieceWorkQuantity.Size = new System.Drawing.Size(174, 20);
            this.fld_txtHREmployeePieceWorkQuantity.TabIndex = 100;
            this.fld_txtHREmployeePieceWorkQuantity.Tag = "DC";
            // 
            // fld_txtHREmployeePieceWorkNo
            // 
            this.fld_txtHREmployeePieceWorkNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSDataMember = "HREmployeePieceWorkNo";
            this.fld_txtHREmployeePieceWorkNo.BOSDataSource = "HREmployeePieceWorks";
            this.fld_txtHREmployeePieceWorkNo.BOSDescription = null;
            this.fld_txtHREmployeePieceWorkNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtHREmployeePieceWorkNo.BOSPropertyName = "Text";
            this.fld_txtHREmployeePieceWorkNo.Location = new System.Drawing.Point(98, 12);
            this.fld_txtHREmployeePieceWorkNo.Name = "fld_txtHREmployeePieceWorkNo";
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREmployeePieceWorkNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREmployeePieceWorkNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREmployeePieceWorkNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREmployeePieceWorkNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtHREmployeePieceWorkNo, true);
            this.fld_txtHREmployeePieceWorkNo.Size = new System.Drawing.Size(174, 20);
            this.fld_txtHREmployeePieceWorkNo.TabIndex = 100;
            this.fld_txtHREmployeePieceWorkNo.Tag = "DC";
            // 
            // DMEPW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEPW100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ADMatchCodeBatchComponent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ilkFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeePieceWorkToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREmployeePieceWorkRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREmployeePieceWorkNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePieceWorkFromDate;
        private BOSComponent.BOSDateEdit fld_dteHREmployeePieceWorkToDate;
        private BOSComponent.BOSMemoEdit fld_medHREmployeePieceWorkRemark;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkAmount;
        private BOSComponent.BOSTextBox fld_txtHREmployeePieceWorkQuantity;
        private ItemLookupEdit fld_ilkFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ADMatchCodeBatchComponent;
	}
}
