using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRollAudit.UI
{
	/// <summary>
	/// Summary description for DMHRPR100
	/// </summary>
	partial class DMHRPRA100
    {
        private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSDateEdit fld_dteHRPayRollAuditDate1;
		private BOSComponent.BOSTextBox fld_txtHRPayRollAuditNo1;
		private BOSComponent.BOSTextBox fld_txtHRPayRollAuditName1;
        private BOSComponent.BOSMemoEdit fld_medHRPayRollAuditDesc;
		private BOSComponent.BOSLookupEdit fld_lkeHRPayRollAuditType1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSButton fld_btnAddEmployee;


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
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRPayRollAuditDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRPayRollAuditNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRPayRollAuditName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRPayRollAuditDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeHRPayRollAuditType1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeePayRollAudits = new BOSERP.Modules.HRPayRollAudit.HREmployeePayRollAuditsGridControl();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeHRPayRollAuditStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRTimeSheetAuditEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRPayRollAuditDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollAudits)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetAuditEmployeePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel9.Text = "Tháng";
            // 
            // fld_dteHRPayRollAuditDate1
            // 
            this.fld_dteHRPayRollAuditDate1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRPayRollAuditDate1.BOSDataMember = "HRPayRollAuditDate";
            this.fld_dteHRPayRollAuditDate1.BOSDataSource = "HRPayRollAudits";
            this.fld_dteHRPayRollAuditDate1.BOSDescription = null;
            this.fld_dteHRPayRollAuditDate1.BOSError = null;
            this.fld_dteHRPayRollAuditDate1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRPayRollAuditDate1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRPayRollAuditDate1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteHRPayRollAuditDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRPayRollAuditDate1.EditValue = null;
            this.fld_dteHRPayRollAuditDate1.Location = new System.Drawing.Point(203, 35);
            this.fld_dteHRPayRollAuditDate1.Name = "fld_dteHRPayRollAuditDate1";
            this.fld_dteHRPayRollAuditDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRPayRollAuditDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRPayRollAuditDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRPayRollAuditDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRPayRollAuditDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRPayRollAuditDate1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollAuditDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollAuditDate1.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollAuditDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollAuditDate1.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRPayRollAuditDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRPayRollAuditDate1.Screen = null;
            this.fld_dteHRPayRollAuditDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRPayRollAuditDate1.TabIndex = 2;
            this.fld_dteHRPayRollAuditDate1.Tag = "DC";
            // 
            // fld_txtHRPayRollAuditNo1
            // 
            this.fld_txtHRPayRollAuditNo1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditNo1.BOSDataMember = "HRPayRollAuditNo";
            this.fld_txtHRPayRollAuditNo1.BOSDataSource = "HRPayRollAudits";
            this.fld_txtHRPayRollAuditNo1.BOSDescription = null;
            this.fld_txtHRPayRollAuditNo1.BOSError = null;
            this.fld_txtHRPayRollAuditNo1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditNo1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditNo1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditNo1.BOSPropertyName = "Text";
            this.fld_txtHRPayRollAuditNo1.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditNo1.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRPayRollAuditNo1.Name = "fld_txtHRPayRollAuditNo1";
            this.fld_txtHRPayRollAuditNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollAuditNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollAuditNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollAuditNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollAuditNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollAuditNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollAuditNo1.Screen = null;
            this.fld_txtHRPayRollAuditNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRPayRollAuditNo1.TabIndex = 0;
            this.fld_txtHRPayRollAuditNo1.Tag = "DC";
            // 
            // fld_txtHRPayRollAuditName1
            // 
            this.fld_txtHRPayRollAuditName1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditName1.BOSDataMember = "HRPayRollAuditName";
            this.fld_txtHRPayRollAuditName1.BOSDataSource = "HRPayRollAudits";
            this.fld_txtHRPayRollAuditName1.BOSDescription = null;
            this.fld_txtHRPayRollAuditName1.BOSError = null;
            this.fld_txtHRPayRollAuditName1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditName1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditName1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditName1.BOSPropertyName = "Text";
            this.fld_txtHRPayRollAuditName1.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtHRPayRollAuditName1.Location = new System.Drawing.Point(471, 9);
            this.fld_txtHRPayRollAuditName1.Name = "fld_txtHRPayRollAuditName1";
            this.fld_txtHRPayRollAuditName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollAuditName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollAuditName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollAuditName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollAuditName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollAuditName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollAuditName1.Screen = null;
            this.fld_txtHRPayRollAuditName1.Size = new System.Drawing.Size(387, 20);
            this.fld_txtHRPayRollAuditName1.TabIndex = 1;
            this.fld_txtHRPayRollAuditName1.Tag = "DC";
            // 
            // fld_medHRPayRollAuditDesc
            // 
            this.fld_medHRPayRollAuditDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medHRPayRollAuditDesc.BOSDataMember = "HRPayRollAuditDesc";
            this.fld_medHRPayRollAuditDesc.BOSDataSource = "HRPayRollAudits";
            this.fld_medHRPayRollAuditDesc.BOSDescription = null;
            this.fld_medHRPayRollAuditDesc.BOSError = null;
            this.fld_medHRPayRollAuditDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medHRPayRollAuditDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medHRPayRollAuditDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medHRPayRollAuditDesc.BOSPropertyName = "Text";
            this.fld_medHRPayRollAuditDesc.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_medHRPayRollAuditDesc.Location = new System.Drawing.Point(203, 61);
            this.fld_medHRPayRollAuditDesc.Name = "fld_medHRPayRollAuditDesc";
            this.fld_medHRPayRollAuditDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRPayRollAuditDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRPayRollAuditDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRPayRollAuditDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRPayRollAuditDesc.Screen = null;
            this.fld_medHRPayRollAuditDesc.Size = new System.Drawing.Size(655, 38);
            this.fld_medHRPayRollAuditDesc.TabIndex = 5;
            this.fld_medHRPayRollAuditDesc.Tag = "DC";
            // 
            // fld_lkeHRPayRollAuditType1
            // 
            this.fld_lkeHRPayRollAuditType1.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollAuditType1.BOSAllowDummy = false;
            this.fld_lkeHRPayRollAuditType1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSDataMember = "HRPayRollAuditType";
            this.fld_lkeHRPayRollAuditType1.BOSDataSource = "HRPayRollAudits";
            this.fld_lkeHRPayRollAuditType1.BOSDescription = null;
            this.fld_lkeHRPayRollAuditType1.BOSError = null;
            this.fld_lkeHRPayRollAuditType1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollAuditType1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.CurrentDisplayText = null;
            this.fld_lkeHRPayRollAuditType1.Location = new System.Drawing.Point(471, 35);
            this.fld_lkeHRPayRollAuditType1.Name = "fld_lkeHRPayRollAuditType1";
            this.fld_lkeHRPayRollAuditType1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRPayRollAuditType1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRPayRollAuditType1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRPayRollAuditType1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRPayRollAuditType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollAuditType1.Properties.ColumnName = null;
            this.fld_lkeHRPayRollAuditType1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeHRPayRollAuditType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRPayRollAuditType1.Screen = null;
            this.fld_lkeHRPayRollAuditType1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollAuditType1.TabIndex = 3;
            this.fld_lkeHRPayRollAuditType1.Tag = "DC";
            this.fld_lkeHRPayRollAuditType1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRPayRollAuditType1_CloseUp);
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
            this.fld_grcGroupControl1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnExportExcel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeePayRollAudits);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 127);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(934, 581);
            this.fld_grcGroupControl1.TabIndex = 17;
            this.fld_grcGroupControl1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHREmployeePayRollAudits
            // 
            this.fld_dgcHREmployeePayRollAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePayRollAudits.BOSComment = null;
            this.fld_dgcHREmployeePayRollAudits.BOSDataMember = null;
            this.fld_dgcHREmployeePayRollAudits.BOSDataSource = "HREmployeePayRollAudits";
            this.fld_dgcHREmployeePayRollAudits.BOSDescription = null;
            this.fld_dgcHREmployeePayRollAudits.BOSError = null;
            this.fld_dgcHREmployeePayRollAudits.BOSFieldGroup = null;
            this.fld_dgcHREmployeePayRollAudits.BOSFieldRelation = null;
            this.fld_dgcHREmployeePayRollAudits.BOSGridType = null;
            this.fld_dgcHREmployeePayRollAudits.BOSPrivilege = null;
            this.fld_dgcHREmployeePayRollAudits.BOSPropertyName = null;
            this.fld_dgcHREmployeePayRollAudits.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeePayRollAudits.GridViewMain = null;
            this.fld_dgcHREmployeePayRollAudits.Location = new System.Drawing.Point(3, 25);
            this.fld_dgcHREmployeePayRollAudits.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeePayRollAudits.Name = "fld_dgcHREmployeePayRollAudits";
            this.fld_dgcHREmployeePayRollAudits.PrintReport = false;
            this.fld_dgcHREmployeePayRollAudits.Screen = null;
            this.fld_dgcHREmployeePayRollAudits.Size = new System.Drawing.Size(928, 514);
            this.fld_dgcHREmployeePayRollAudits.TabIndex = 1;
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(111, 545);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Visible = false;
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(934, 711);
            this.bosPanel1.TabIndex = 0;
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
            this.bosPanel2.Controls.Add(this.fld_lkeHRPayRollAuditStatus);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetAuditEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel9);
            this.bosPanel2.Controls.Add(this.fld_medHRPayRollAuditDesc);
            this.bosPanel2.Controls.Add(this.fld_txtHRPayRollAuditNo1);
            this.bosPanel2.Controls.Add(this.fld_dteHRPayRollAuditDate1);
            this.bosPanel2.Controls.Add(this.fld_txtHRPayRollAuditName1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lkeHRPayRollAuditType1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(934, 124);
            this.bosPanel2.TabIndex = 18;
            // 
            // fld_lkeHRPayRollAuditStatus
            // 
            this.fld_lkeHRPayRollAuditStatus.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollAuditStatus.BOSAllowDummy = false;
            this.fld_lkeHRPayRollAuditStatus.BOSComment = null;
            this.fld_lkeHRPayRollAuditStatus.BOSDataMember = "HRPayRollAuditStatus";
            this.fld_lkeHRPayRollAuditStatus.BOSDataSource = "HRPayRollAudits";
            this.fld_lkeHRPayRollAuditStatus.BOSDescription = null;
            this.fld_lkeHRPayRollAuditStatus.BOSError = null;
            this.fld_lkeHRPayRollAuditStatus.BOSFieldGroup = null;
            this.fld_lkeHRPayRollAuditStatus.BOSFieldParent = null;
            this.fld_lkeHRPayRollAuditStatus.BOSFieldRelation = null;
            this.fld_lkeHRPayRollAuditStatus.BOSPrivilege = null;
            this.fld_lkeHRPayRollAuditStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollAuditStatus.BOSSelectType = null;
            this.fld_lkeHRPayRollAuditStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRPayRollAuditStatus.CurrentDisplayText = null;
            this.fld_lkeHRPayRollAuditStatus.Location = new System.Drawing.Point(708, 35);
            this.fld_lkeHRPayRollAuditStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRPayRollAuditStatus.Name = "fld_lkeHRPayRollAuditStatus";
            this.fld_lkeHRPayRollAuditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollAuditStatus.Properties.ColumnName = null;
            this.fld_lkeHRPayRollAuditStatus.Properties.ReadOnly = true;
            this.fld_lkeHRPayRollAuditStatus.Screen = null;
            this.fld_lkeHRPayRollAuditStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollAuditStatus.TabIndex = 4;
            this.fld_lkeHRPayRollAuditStatus.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRPayRollAudits";
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
            // fld_pteHRTimeSheetAuditEmployeePicture
            // 
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSDataMember = "HRPayRollAuditEmployeePicture";
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSDataSource = "HRPayRollAudits";
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetAuditEmployeePicture.FileName = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.FilePath = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetAuditEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetAuditEmployeePicture.Name = "fld_pteHRTimeSheetAuditEmployeePicture";
            this.fld_pteHRTimeSheetAuditEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetAuditEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetAuditEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRTimeSheetAuditEmployeePicture.TabIndex = 7;
            this.fld_pteHRTimeSheetAuditEmployeePicture.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(641, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(49, 13);
            this.bosLabel2.TabIndex = 5;
            this.bosLabel2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel2.Text = "Tình trạng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.Location = new System.Drawing.Point(375, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(76, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel1.Text = "Loại bảng lương";
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
            this.fld_lblLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel2.Text = "Mã bảng lương";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.Location = new System.Drawing.Point(375, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.Text = "Tên bảng lương";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.Location = new System.Drawing.Point(120, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_btnExportExcel
            // 
            this.fld_btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnExportExcel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnExportExcel.Appearance.Options.UseForeColor = true;
            this.fld_btnExportExcel.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.Location = new System.Drawing.Point(5, 545);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(100, 27);
            this.fld_btnExportExcel.TabIndex = 7;
            this.fld_btnExportExcel.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // DMHRPRA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRPRA100";
            this.Text = "Thông tin bảng lương Audit";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollAuditDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollAuditName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRPayRollAuditDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRollAudits)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollAuditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetAuditEmployeePicture.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetAuditEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeHRPayRollAuditStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private HREmployeePayRollAuditsGridControl fld_dgcHREmployeePayRollAudits;
        private BOSComponent.BOSButton fld_btnExportExcel;
	}
}
