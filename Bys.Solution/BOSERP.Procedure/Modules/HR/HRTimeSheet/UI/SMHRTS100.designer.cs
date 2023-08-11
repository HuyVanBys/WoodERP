using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRTimeSheet.UI
{
	/// <summary>
	/// Summary description for SMHRTS100
	/// </summary>
	partial class SMHRTS100
	{
		private BOSComponent.BOSTextBox fld_txtHRTimeSheetNo;
		private BOSComponent.BOSTextBox fld_txtHRTimeSheetName;
		private BOSComponent.BOSDateEdit fld_dteHRTimeSheetDateFrom;
		private BOSSearchResultsGridControl fld_dgcHRTimeSheet;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTimeSheet;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblHRTimeSheetType1;
        private BOSComponent.BOSLookupEdit fld_lkeHRTimeSheetType1;


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
            this.fld_txtHRTimeSheetNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRTimeSheetName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteHRTimeSheetDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcHRTimeSheet = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRTimeSheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblHRTimeSheetType1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRTimeSheetType1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRTimeSheetDateTo = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRTimeSheetNo
            // 
            this.fld_txtHRTimeSheetNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetNo.BOSDataMember = "HRTimeSheetNo";
            this.fld_txtHRTimeSheetNo.BOSDataSource = "HRTimeSheets";
            this.fld_txtHRTimeSheetNo.BOSDescription = null;
            this.fld_txtHRTimeSheetNo.BOSError = null;
            this.fld_txtHRTimeSheetNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetNo.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetNo.Location = new System.Drawing.Point(130, 27);
            this.fld_txtHRTimeSheetNo.Name = "fld_txtHRTimeSheetNo";
            this.fld_txtHRTimeSheetNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetNo.Screen = null;
            this.fld_txtHRTimeSheetNo.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRTimeSheetNo.TabIndex = 0;
            this.fld_txtHRTimeSheetNo.Tag = "SC";
            // 
            // fld_txtHRTimeSheetName
            // 
            this.fld_txtHRTimeSheetName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetName.BOSDataMember = "HRTimeSheetName";
            this.fld_txtHRTimeSheetName.BOSDataSource = "HRTimeSheets";
            this.fld_txtHRTimeSheetName.BOSDescription = null;
            this.fld_txtHRTimeSheetName.BOSError = null;
            this.fld_txtHRTimeSheetName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetName.BOSPropertyName = "Text";
            this.fld_txtHRTimeSheetName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRTimeSheetName.Location = new System.Drawing.Point(130, 51);
            this.fld_txtHRTimeSheetName.Name = "fld_txtHRTimeSheetName";
            this.fld_txtHRTimeSheetName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRTimeSheetName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRTimeSheetName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRTimeSheetName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRTimeSheetName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRTimeSheetName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRTimeSheetName.Screen = null;
            this.fld_txtHRTimeSheetName.Size = new System.Drawing.Size(220, 20);
            this.fld_txtHRTimeSheetName.TabIndex = 1;
            this.fld_txtHRTimeSheetName.Tag = "SC";
            // 
            // fld_dteHRTimeSheetDateFrom
            // 
            this.fld_dteHRTimeSheetDateFrom.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateFrom.BOSDataMember = "HRTimeSheetDateFrom";
            this.fld_dteHRTimeSheetDateFrom.BOSDataSource = "HRTimeSheets";
            this.fld_dteHRTimeSheetDateFrom.BOSDescription = null;
            this.fld_dteHRTimeSheetDateFrom.BOSError = null;
            this.fld_dteHRTimeSheetDateFrom.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateFrom.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateFrom.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetDateFrom.EditValue = null;
            this.fld_dteHRTimeSheetDateFrom.Location = new System.Drawing.Point(130, 129);
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
            this.fld_dteHRTimeSheetDateFrom.TabIndex = 4;
            this.fld_dteHRTimeSheetDateFrom.Tag = "SC";
            // 
            // fld_dgcHRTimeSheet
            // 
            this.fld_dgcHRTimeSheet.AllowDrop = true;
            this.fld_dgcHRTimeSheet.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.BOSDataSource = "HRTimeSheets";
            this.fld_dgcHRTimeSheet.BOSDescription = null;
            this.fld_dgcHRTimeSheet.BOSError = null;
            this.fld_dgcHRTimeSheet.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRTimeSheet.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTimeSheet.Location = new System.Drawing.Point(15, 187);
            this.fld_dgcHRTimeSheet.MainView = this.fld_dgvHRTimeSheet;
            this.fld_dgcHRTimeSheet.Name = "fld_dgcHRTimeSheet";
            this.fld_dgcHRTimeSheet.Screen = null;
            this.fld_dgcHRTimeSheet.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRTimeSheet.TabIndex = 6;
            this.fld_dgcHRTimeSheet.Tag = "SR";
            this.fld_dgcHRTimeSheet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTimeSheet});
            // 
            // fld_dgvHRTimeSheet
            // 
            this.fld_dgvHRTimeSheet.GridControl = this.fld_dgcHRTimeSheet;
            this.fld_dgvHRTimeSheet.Name = "fld_dgvHRTimeSheet";
            this.fld_dgvHRTimeSheet.PaintStyleName = "Office2003";
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
            this.fld_lblLabel.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel.TabIndex = 10;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã bảng công";
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
            this.fld_lblLabel1.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel1.TabIndex = 11;
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(31, 132);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(98, 13);
            this.fld_lblLabel2.TabIndex = 12;
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
            this.fld_lblHRTimeSheetType1.Location = new System.Drawing.Point(31, 81);
            this.fld_lblHRTimeSheetType1.Name = "fld_lblHRTimeSheetType1";
            this.fld_lblHRTimeSheetType1.Screen = null;
            this.fld_lblHRTimeSheetType1.Size = new System.Drawing.Size(76, 13);
            this.fld_lblHRTimeSheetType1.TabIndex = 37;
            this.fld_lblHRTimeSheetType1.Tag = "SI";
            this.fld_lblHRTimeSheetType1.Text = "Loại bảng lương";
            // 
            // fld_lkeHRTimeSheetType1
            // 
            this.fld_lkeHRTimeSheetType1.BOSAllowAddNew = false;
            this.fld_lkeHRTimeSheetType1.BOSAllowDummy = false;
            this.fld_lkeHRTimeSheetType1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSDataMember = "HRTimeSheetType";
            this.fld_lkeHRTimeSheetType1.BOSDataSource = "HRTimeSheets";
            this.fld_lkeHRTimeSheetType1.BOSDescription = null;
            this.fld_lkeHRTimeSheetType1.BOSError = null;
            this.fld_lkeHRTimeSheetType1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSPropertyName = "EditValue";
            this.fld_lkeHRTimeSheetType1.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.CurrentDisplayText = null;
            this.fld_lkeHRTimeSheetType1.Location = new System.Drawing.Point(130, 77);
            this.fld_lkeHRTimeSheetType1.Name = "fld_lkeHRTimeSheetType1";
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRTimeSheetType1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRTimeSheetType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRTimeSheetType1.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeHRTimeSheetType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRTimeSheetType1.Screen = null;
            this.fld_lkeHRTimeSheetType1.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeHRTimeSheetType1.TabIndex = 2;
            this.fld_lkeHRTimeSheetType1.Tag = "SC";
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
            this.bosLabel1.Location = new System.Drawing.Point(31, 106);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 88;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(130, 103);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(220, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(379, 132);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(20, 13);
            this.bosLabel2.TabIndex = 12;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến";
            // 
            // fld_dteHRTimeSheetDateTo
            // 
            this.fld_dteHRTimeSheetDateTo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateTo.BOSDataMember = "HRTimeSheetDateTo";
            this.fld_dteHRTimeSheetDateTo.BOSDataSource = "HRTimeSheets";
            this.fld_dteHRTimeSheetDateTo.BOSDescription = null;
            this.fld_dteHRTimeSheetDateTo.BOSError = null;
            this.fld_dteHRTimeSheetDateTo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateTo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateTo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteHRTimeSheetDateTo.BOSPropertyName = "EditValue";
            this.fld_dteHRTimeSheetDateTo.EditValue = null;
            this.fld_dteHRTimeSheetDateTo.Location = new System.Drawing.Point(478, 129);
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
            this.fld_dteHRTimeSheetDateTo.TabIndex = 5;
            this.fld_dteHRTimeSheetDateTo.Tag = "SC";
            // 
            // SMHRTS100
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
            this.Controls.Add(this.fld_dgcHRTimeSheet);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblHRTimeSheetType1);
            this.Controls.Add(this.fld_lkeHRTimeSheetType1);
            this.Name = "SMHRTS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeHRTimeSheetType1, 0);
            this.Controls.SetChildIndex(this.fld_lblHRTimeSheetType1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRTimeSheet, 0);
            this.Controls.SetChildIndex(this.fld_dteHRTimeSheetDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dteHRTimeSheetDateTo, 0);
            this.Controls.SetChildIndex(this.fld_txtHRTimeSheetName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRTimeSheetNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRTimeSheetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTimeSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTimeSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRTimeSheetType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRTimeSheetDateTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteHRTimeSheetDateTo;
	}
}
