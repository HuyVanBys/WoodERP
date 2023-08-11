using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTimeSheetAudit.UI
{
	/// <summary>
	/// Summary description for DMHRTSA100
	/// </summary>
	partial class DMHRTSA100
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeHRTimeSheetAuditStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRTimeSheetAuditToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRTimeSheetAuditFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRTimeSheetAuditDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRTimeSheetAuditName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRTimeSheetAuditNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRTimeSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTimeSheetAuditType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAddFromFile = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeTimeSheetAudits = new BOSERP.Modules.HRTimeSheetAudit.HREmployeeTimeSheetAuditsGridControl();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetAuditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetAuditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetAuditNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetAuditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTimeSheetAudits)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.fld_btnAddFromFile);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(976, 741);
            this.bosPanel1.TabIndex = 18;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeHRTimeSheetAuditStatus);
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.fld_dteHRTimeSheetAuditToDate);
            this.bosPanel2.Controls.Add(this.fld_dteHRTimeSheetAuditFromDate);
            this.bosPanel2.Controls.Add(this.fld_dteHRTimeSheetAuditDate);
            this.bosPanel2.Controls.Add(this.fld_txtHRTimeSheetAuditName);
            this.bosPanel2.Controls.Add(this.fld_txtHRTimeSheetAuditNo);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.fld_lkeHRTimeSheetAuditType);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(976, 157);
            this.bosPanel2.TabIndex = 17;
            // 
            // fld_lkeHRTimeSheetAuditStatus
            // 
            this.fld_lkeHRTimeSheetAuditStatus.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetAuditStatus.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetAuditStatus.BOSComment = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSDataMember = "HRTimeSheetAuditStatus";
            this.fld_lkeHRTimeSheetAuditStatus.BOSDataSource = "HRTimeSheetAudits";
            this.fld_lkeHRTimeSheetAuditStatus.BOSDescription = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSError = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSFieldGroup = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSFieldParent = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSFieldRelation = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSPrivilege = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetAuditStatus.BOSSelectType = null;
            this.fld_lkeHRTimeSheetAuditStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRTimeSheetAuditStatus.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetAuditStatus.Location = new System.Drawing.Point(604, 61);
            this.fld_lkeHRTimeSheetAuditStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRTimeSheetAuditStatus.Name = "fld_lkeHRTimeSheetAuditStatus";
            this.fld_lkeHRTimeSheetAuditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetAuditStatus.Properties.ColumnName = null;
            this.fld_lkeHRTimeSheetAuditStatus.Properties.ReadOnly = true;
            this.fld_lkeHRTimeSheetAuditStatus.Screen = null;
            this.fld_lkeHRTimeSheetAuditStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTimeSheetAuditStatus.TabIndex = 4;
            this.fld_lkeHRTimeSheetAuditStatus.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosMemoEdit1.BOSDataMember = "HRTimeSheetAuditDesc";
            this.bosMemoEdit1.BOSDataSource = "HRTimeSheetAudits";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosMemoEdit1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosMemoEdit1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosMemoEdit1.Location = new System.Drawing.Point(203, 113);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(551, 35);
            this.bosMemoEdit1.TabIndex = 7;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_dteHRTimeSheetAuditToDate
            // 
            this.fld_dteHRTimeSheetAuditToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditToDate.BOSDataMember = "HRTimeSheetAuditToDate";
            this.fld_dteHRTimeSheetAuditToDate.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dteHRTimeSheetAuditToDate.BOSDescription = null;
            this.fld_dteHRTimeSheetAuditToDate.BOSError = null;
            this.fld_dteHRTimeSheetAuditToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetAuditToDate.EditValue = null;
            this.fld_dteHRTimeSheetAuditToDate.Location = new System.Drawing.Point(604, 87);
            this.fld_dteHRTimeSheetAuditToDate.Name = "fld_dteHRTimeSheetAuditToDate";
            this.fld_dteHRTimeSheetAuditToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetAuditToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetAuditToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetAuditToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetAuditToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetAuditToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetAuditToDate.Screen = null;
            this.fld_dteHRTimeSheetAuditToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTimeSheetAuditToDate.TabIndex = 6;
            this.fld_dteHRTimeSheetAuditToDate.Tag = "DC";
            this.fld_dteHRTimeSheetAuditToDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_dteHRTimeSheetAuditToDate_EditValueChanging);
            // 
            // fld_dteHRTimeSheetAuditFromDate
            // 
            this.fld_dteHRTimeSheetAuditFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditFromDate.BOSDataMember = "HRTimeSheetAuditFromDate";
            this.fld_dteHRTimeSheetAuditFromDate.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dteHRTimeSheetAuditFromDate.BOSDescription = null;
            this.fld_dteHRTimeSheetAuditFromDate.BOSError = null;
            this.fld_dteHRTimeSheetAuditFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetAuditFromDate.EditValue = null;
            this.fld_dteHRTimeSheetAuditFromDate.Location = new System.Drawing.Point(203, 87);
            this.fld_dteHRTimeSheetAuditFromDate.Name = "fld_dteHRTimeSheetAuditFromDate";
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetAuditFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRTimeSheetAuditFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetAuditFromDate.Screen = null;
            this.fld_dteHRTimeSheetAuditFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTimeSheetAuditFromDate.TabIndex = 5;
            this.fld_dteHRTimeSheetAuditFromDate.Tag = "DC";
            this.fld_dteHRTimeSheetAuditFromDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_dteHRTimeSheetAuditFromDate_EditValueChanging);
            // 
            // fld_dteHRTimeSheetAuditDate
            // 
            this.fld_dteHRTimeSheetAuditDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditDate.BOSDataMember = "HRTimeSheetAuditDate";
            this.fld_dteHRTimeSheetAuditDate.BOSDataSource = "HRTimeSheetAudits";
            this.fld_dteHRTimeSheetAuditDate.BOSDescription = null;
            this.fld_dteHRTimeSheetAuditDate.BOSError = null;
            this.fld_dteHRTimeSheetAuditDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteHRTimeSheetAuditDate.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetAuditDate.EditValue = null;
            this.fld_dteHRTimeSheetAuditDate.Location = new System.Drawing.Point(203, 61);
            this.fld_dteHRTimeSheetAuditDate.Name = "fld_dteHRTimeSheetAuditDate";
            this.fld_dteHRTimeSheetAuditDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRTimeSheetAuditDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRTimeSheetAuditDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRTimeSheetAuditDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRTimeSheetAuditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRTimeSheetAuditDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetAuditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditDate.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRTimeSheetAuditDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRTimeSheetAuditDate.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRTimeSheetAuditDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRTimeSheetAuditDate.Screen = null;
            this.fld_dteHRTimeSheetAuditDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRTimeSheetAuditDate.TabIndex = 3;
            this.fld_dteHRTimeSheetAuditDate.Tag = "DC";
            this.fld_dteHRTimeSheetAuditDate.Validated += new System.EventHandler(this.fld_dteHRTimeSheetAuditDate_Validated);
            // 
            // fld_txtHRTimeSheetAuditName
            // 
            this.fld_txtHRTimeSheetAuditName.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditName.BOSDataMember = "HRTimeSheetAuditName";
            this.fld_txtHRTimeSheetAuditName.BOSDataSource = "HRTimeSheetAudits";
            this.fld_txtHRTimeSheetAuditName.BOSDescription = null;
            this.fld_txtHRTimeSheetAuditName.BOSError = null;
            this.fld_txtHRTimeSheetAuditName.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditName.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditName.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditName.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetAuditName.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditName.Location = new System.Drawing.Point(203, 35);
            this.fld_txtHRTimeSheetAuditName.Name = "fld_txtHRTimeSheetAuditName";
            this.fld_txtHRTimeSheetAuditName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetAuditName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetAuditName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetAuditName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetAuditName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetAuditName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetAuditName.Screen = null;
            this.fld_txtHRTimeSheetAuditName.Size = new System.Drawing.Size(551, 20);
            this.fld_txtHRTimeSheetAuditName.TabIndex = 2;
            this.fld_txtHRTimeSheetAuditName.Tag = "DC";
            // 
            // fld_txtHRTimeSheetAuditNo
            // 
            this.fld_txtHRTimeSheetAuditNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditNo.BOSDataMember = "HRTimeSheetAuditNo";
            this.fld_txtHRTimeSheetAuditNo.BOSDataSource = "HRTimeSheetAudits";
            this.fld_txtHRTimeSheetAuditNo.BOSDescription = null;
            this.fld_txtHRTimeSheetAuditNo.BOSError = null;
            this.fld_txtHRTimeSheetAuditNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditNo.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetAuditNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRTimeSheetAuditNo.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRTimeSheetAuditNo.Name = "fld_txtHRTimeSheetAuditNo";
            this.fld_txtHRTimeSheetAuditNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetAuditNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetAuditNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetAuditNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetAuditNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetAuditNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetAuditNo.Screen = null;
            this.fld_txtHRTimeSheetAuditNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRTimeSheetAuditNo.TabIndex = 0;
            this.fld_txtHRTimeSheetAuditNo.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.Location = new System.Drawing.Point(519, 90);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 5;
            this.bosLabel6.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRTimeSheetAudits";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.Location = new System.Drawing.Point(120, 90);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 5;
            this.bosLabel5.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_pteHRTimeSheetEmployeePicture
            // 
            this.fld_pteHRTimeSheetEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataMember = "HRTimeSheetAuditEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataSource = "HRTimeSheetAudits";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetEmployeePicture.FileName = null;
            this.fld_pteHRTimeSheetEmployeePicture.FilePath = null;
            this.fld_pteHRTimeSheetEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetEmployeePicture.Name = "fld_pteHRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRTimeSheetEmployeePicture.TabIndex = 0;
            this.fld_pteHRTimeSheetEmployeePicture.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Location = new System.Drawing.Point(120, 64);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(30, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel1.Text = "Tháng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.Location = new System.Drawing.Point(519, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(49, 13);
            this.bosLabel4.TabIndex = 7;
            this.bosLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.Text = "Tình trạng";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Location = new System.Drawing.Point(519, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 7;
            this.bosLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Text = "Loại bảng công";
            // 
            // fld_lkeHRTimeSheetAuditType
            // 
            this.fld_lkeHRTimeSheetAuditType.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetAuditType.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetAuditType.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.BOSDataMember = "HRTimeSheetAuditType";
            this.fld_lkeHRTimeSheetAuditType.BOSDataSource = "HRTimeSheetAudits";
            this.fld_lkeHRTimeSheetAuditType.BOSDescription = null;
            this.fld_lkeHRTimeSheetAuditType.BOSError = null;
            this.fld_lkeHRTimeSheetAuditType.BOSFieldGroup = "NonEditable";
            this.fld_lkeHRTimeSheetAuditType.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetAuditType.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetAuditType.Location = new System.Drawing.Point(604, 9);
            this.fld_lkeHRTimeSheetAuditType.Name = "fld_lkeHRTimeSheetAuditType";
            this.fld_lkeHRTimeSheetAuditType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRTimeSheetAuditType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRTimeSheetAuditType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRTimeSheetAuditType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRTimeSheetAuditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetAuditType.Properties.ColumnName = null;
            this.fld_lkeHRTimeSheetAuditType.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeHRTimeSheetAuditType.Properties.PopupWidth = 40;
            this.fld_lkeHRTimeSheetAuditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRTimeSheetAuditType.Screen = null;
            this.fld_lkeHRTimeSheetAuditType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRTimeSheetAuditType.TabIndex = 1;
            this.fld_lkeHRTimeSheetAuditType.Tag = "DC";
            this.fld_lkeHRTimeSheetAuditType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRTimeSheetAuditType_CloseUp);
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel2.Text = "Mã bảng công";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel4.Text = "Tên bảng công";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Location = new System.Drawing.Point(120, 113);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_btnAddFromFile
            // 
            this.fld_btnAddFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddFromFile.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddFromFile.Appearance.Options.UseForeColor = true;
            this.fld_btnAddFromFile.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSDescription = null;
            this.fld_btnAddFromFile.BOSError = null;
            this.fld_btnAddFromFile.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.Location = new System.Drawing.Point(112, 710);
            this.fld_btnAddFromFile.Name = "fld_btnAddFromFile";
            this.fld_btnAddFromFile.Screen = null;
            this.fld_btnAddFromFile.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddFromFile.TabIndex = 15;
            this.fld_btnAddFromFile.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddFromFile.Text = "Thêm từ file";
            this.fld_btnAddFromFile.Visible = false;
            this.fld_btnAddFromFile.Click += new System.EventHandler(this.fld_btnAddFromFile_Click);
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(6, 710);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 15;
            this.fld_btnAddEmployee.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Visible = false;
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeTimeSheetAudits);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(6, 163);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(965, 545);
            this.fld_grcGroupControl1.TabIndex = 13;
            this.fld_grcGroupControl1.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHREmployeeTimeSheetAudits
            // 
            this.fld_dgcHREmployeeTimeSheetAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeTimeSheetAudits.BOSComment = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSDataMember = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSDataSource = "HREmployeeTimeSheetAudits";
            this.fld_dgcHREmployeeTimeSheetAudits.BOSDescription = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSError = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSFieldGroup = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSFieldRelation = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSGridType = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSPrivilege = null;
            this.fld_dgcHREmployeeTimeSheetAudits.BOSPropertyName = null;
            this.fld_dgcHREmployeeTimeSheetAudits.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHREmployeeTimeSheetAudits.GridViewMain = null;
            this.fld_dgcHREmployeeTimeSheetAudits.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcHREmployeeTimeSheetAudits.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeTimeSheetAudits.Name = "fld_dgcHREmployeeTimeSheetAudits";
            this.fld_dgcHREmployeeTimeSheetAudits.PrintReport = false;
            this.fld_dgcHREmployeeTimeSheetAudits.RowHandle = 0;
            this.fld_dgcHREmployeeTimeSheetAudits.Screen = null;
            this.fld_dgcHREmployeeTimeSheetAudits.Size = new System.Drawing.Size(955, 515);
            this.fld_dgcHREmployeeTimeSheetAudits.TabIndex = 0;
            // 
            // DMHRTSA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(976, 741);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRTSA100";
            this.Text = "Quản lý chấm công";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetAuditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetAuditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetAuditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetAuditNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetAuditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeTimeSheetAudits)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetAuditStatus;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetAuditToDate;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetAuditFromDate;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetAuditDate;
        private BOSComponent.BOSTextBox fld_txtHRTimeSheetAuditName;
        private BOSComponent.BOSTextBox fld_txtHRTimeSheetAuditNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetAuditType;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnAddFromFile;
        private BOSComponent.BOSButton fld_btnAddEmployee;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HREmployeeTimeSheetAuditsGridControl fld_dgcHREmployeeTimeSheetAudits;
	}
}
