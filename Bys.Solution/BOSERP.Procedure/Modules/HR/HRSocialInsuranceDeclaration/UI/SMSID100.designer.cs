using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRSocialInsuranceDeclaration.UI
{
	/// <summary>
	/// Summary description for SMSID100
	/// </summary>
	partial class SMSID100
	{
		private BOSComponent.BOSTextBox fld_txtHRSocialInsuranceDeclarationNo;
		private BOSComponent.BOSTextBox fld_txtHRSocialInsuranceDeclarationName;
		private BOSComponent.BOSDateEdit fld_dteHRSocialInsuranceDeclarationDateFrom;
		private BOSSearchResultsGridControl fld_dgcHRSocialInsuranceDeclarations;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRSocialInsuranceDeclaration;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblHRSocialInsuranceDeclarationType1;
        private BOSComponent.BOSLookupEdit fld_lkeHRSocialInsuranceDeclarationType1;


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
            this.fld_txtHRSocialInsuranceDeclarationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRSocialInsuranceDeclarationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRSocialInsuranceDeclarationDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcHRSocialInsuranceDeclarations = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRSocialInsuranceDeclaration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblHRSocialInsuranceDeclarationType1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRSocialInsuranceDeclarationType1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRSocialInsuranceDeclarationDateTo = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRSocialInsuranceDeclaration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRSocialInsuranceDeclarationNo
            // 
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSDataMember = "HRSocialInsuranceDeclarationNo";
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSDescription = null;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSError = null;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationNo.BOSPropertyName = "Text";
            this.fld_txtHRSocialInsuranceDeclarationNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationNo.Location = new System.Drawing.Point(130, 27);
            this.fld_txtHRSocialInsuranceDeclarationNo.Name = "fld_txtHRSocialInsuranceDeclarationNo";
            this.fld_txtHRSocialInsuranceDeclarationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRSocialInsuranceDeclarationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRSocialInsuranceDeclarationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRSocialInsuranceDeclarationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRSocialInsuranceDeclarationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRSocialInsuranceDeclarationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRSocialInsuranceDeclarationNo.Screen = null;
            this.fld_txtHRSocialInsuranceDeclarationNo.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRSocialInsuranceDeclarationNo.TabIndex = 0;
            this.fld_txtHRSocialInsuranceDeclarationNo.Tag = "SC";
            // 
            // fld_txtHRSocialInsuranceDeclarationName
            // 
            this.fld_txtHRSocialInsuranceDeclarationName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSDataMember = "HRSocialInsuranceDeclarationName";
            this.fld_txtHRSocialInsuranceDeclarationName.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_txtHRSocialInsuranceDeclarationName.BOSDescription = null;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSError = null;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationName.BOSPropertyName = "Text";
            this.fld_txtHRSocialInsuranceDeclarationName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRSocialInsuranceDeclarationName.Location = new System.Drawing.Point(130, 51);
            this.fld_txtHRSocialInsuranceDeclarationName.Name = "fld_txtHRSocialInsuranceDeclarationName";
            this.fld_txtHRSocialInsuranceDeclarationName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRSocialInsuranceDeclarationName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRSocialInsuranceDeclarationName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRSocialInsuranceDeclarationName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRSocialInsuranceDeclarationName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRSocialInsuranceDeclarationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRSocialInsuranceDeclarationName.Screen = null;
            this.fld_txtHRSocialInsuranceDeclarationName.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRSocialInsuranceDeclarationName.TabIndex = 1;
            this.fld_txtHRSocialInsuranceDeclarationName.Tag = "SC";
            // 
            // fld_dteHRSocialInsuranceDeclarationDateFrom
            // 
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSDataMember = "HRSocialInsuranceDeclarationDateFrom";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSDescription = null;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSError = null;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.EditValue = null;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Location = new System.Drawing.Point(130, 103);
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Name = "fld_dteHRSocialInsuranceDeclarationDateFrom";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Screen = null;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.TabIndex = 4;
            this.fld_dteHRSocialInsuranceDeclarationDateFrom.Tag = "SC";
            // 
            // fld_dgcHRSocialInsuranceDeclarations
            // 
            this.fld_dgcHRSocialInsuranceDeclarations.AllowDrop = true;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_dgcHRSocialInsuranceDeclarations.BOSDescription = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSError = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSGridType = null;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRSocialInsuranceDeclarations.CommodityType = "";
            this.fld_dgcHRSocialInsuranceDeclarations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRSocialInsuranceDeclarations.Location = new System.Drawing.Point(15, 187);
            this.fld_dgcHRSocialInsuranceDeclarations.MainView = this.fld_dgvHRSocialInsuranceDeclaration;
            this.fld_dgcHRSocialInsuranceDeclarations.Name = "fld_dgcHRSocialInsuranceDeclarations";
            this.fld_dgcHRSocialInsuranceDeclarations.PrintReport = false;
            this.fld_dgcHRSocialInsuranceDeclarations.Screen = null;
            this.fld_dgcHRSocialInsuranceDeclarations.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRSocialInsuranceDeclarations.TabIndex = 6;
            this.fld_dgcHRSocialInsuranceDeclarations.Tag = "SR";
            this.fld_dgcHRSocialInsuranceDeclarations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRSocialInsuranceDeclaration});
            // 
            // fld_dgvHRSocialInsuranceDeclaration
            // 
            this.fld_dgvHRSocialInsuranceDeclaration.GridControl = this.fld_dgcHRSocialInsuranceDeclarations;
            this.fld_dgvHRSocialInsuranceDeclaration.Name = "fld_dgvHRSocialInsuranceDeclaration";
            this.fld_dgvHRSocialInsuranceDeclaration.PaintStyleName = "Office2003";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(31, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 10;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chừng từ";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(31, 54);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel1.TabIndex = 11;
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(31, 106);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel2.TabIndex = 12;
            this.fld_lblLabel2.Tag = "SI";
            this.fld_lblLabel2.Text = "Tháng áp dụng từ";
            // 
            // fld_lblHRSocialInsuranceDeclarationType1
            // 
            this.fld_lblHRSocialInsuranceDeclarationType1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRSocialInsuranceDeclarationType1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblHRSocialInsuranceDeclarationType1.Appearance.Options.UseBackColor = true;
            this.fld_lblHRSocialInsuranceDeclarationType1.Appearance.Options.UseForeColor = true;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSDescription = null;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSError = null;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblHRSocialInsuranceDeclarationType1.Location = new System.Drawing.Point(31, 81);
            this.fld_lblHRSocialInsuranceDeclarationType1.Name = "fld_lblHRSocialInsuranceDeclarationType1";
            this.fld_lblHRSocialInsuranceDeclarationType1.Screen = null;
            this.fld_lblHRSocialInsuranceDeclarationType1.Size = new System.Drawing.Size(66, 13);
            this.fld_lblHRSocialInsuranceDeclarationType1.TabIndex = 37;
            this.fld_lblHRSocialInsuranceDeclarationType1.Tag = "SI";
            this.fld_lblHRSocialInsuranceDeclarationType1.Text = "Loại chứng từ";
            // 
            // fld_lkeHRSocialInsuranceDeclarationType1
            // 
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSAllowAddNew = false;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSAllowDummy = false;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSDataMember = "HRSocialInsuranceDeclarationType";
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSDescription = null;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSError = null;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSPropertyName = "EditValue";
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.CurrentDisplayText = null;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Location = new System.Drawing.Point(130, 77);
            this.fld_lkeHRSocialInsuranceDeclarationType1.Name = "fld_lkeHRSocialInsuranceDeclarationType1";
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.ColumnName = null;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Screen = null;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeHRSocialInsuranceDeclarationType1.TabIndex = 2;
            this.fld_lkeHRSocialInsuranceDeclarationType1.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(379, 106);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 12;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // fld_dteHRSocialInsuranceDeclarationDateTo
            // 
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSDataMember = "HRSocialInsuranceDeclarationDateTo";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSDataSource = "HRSocialInsuranceDeclarations";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSDescription = null;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSError = null;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.BOSPropertyName = "EditValue";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.EditValue = null;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Location = new System.Drawing.Point(478, 103);
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Name = "fld_dteHRSocialInsuranceDeclarationDateTo";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Screen = null;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Size = new System.Drawing.Size(220, 20);
            this.fld_dteHRSocialInsuranceDeclarationDateTo.TabIndex = 5;
            this.fld_dteHRSocialInsuranceDeclarationDateTo.Tag = "SC";
            // 
            // SMSID100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.fld_txtHRSocialInsuranceDeclarationNo);
            this.Controls.Add(this.fld_txtHRSocialInsuranceDeclarationName);
            this.Controls.Add(this.fld_dteHRSocialInsuranceDeclarationDateTo);
            this.Controls.Add(this.fld_dteHRSocialInsuranceDeclarationDateFrom);
            this.Controls.Add(this.fld_dgcHRSocialInsuranceDeclarations);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblHRSocialInsuranceDeclarationType1);
            this.Controls.Add(this.fld_lkeHRSocialInsuranceDeclarationType1);
            this.Name = "SMSID100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeHRSocialInsuranceDeclarationType1, 0);
            this.Controls.SetChildIndex(this.fld_lblHRSocialInsuranceDeclarationType1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRSocialInsuranceDeclarations, 0);
            this.Controls.SetChildIndex(this.fld_dteHRSocialInsuranceDeclarationDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteHRSocialInsuranceDeclarationDateTo, 0);
            this.Controls.SetChildIndex(this.fld_txtHRSocialInsuranceDeclarationName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRSocialInsuranceDeclarationNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRSocialInsuranceDeclarationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRSocialInsuranceDeclarations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRSocialInsuranceDeclaration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRSocialInsuranceDeclarationType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRSocialInsuranceDeclarationDateTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHRSocialInsuranceDeclarationDateTo;
	}
}
