using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Document.UI
{
	/// <summary>
	/// Summary description for DMDC100
	/// </summary>
	partial class DMDC100
    {
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSTextBox fld_txtACDocumentNo1;
		private BOSComponent.BOSDateEdit fld_dteACDocumentDate;
		private BOSComponent.BOSMemoEdit fld_medACDocumentDesc;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		//private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private ACDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;


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
            this.fld_txtACDocumentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACDocumentDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medACDocumentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACDocumentEntrys = new BOSERP.Modules.Document.UI.ACDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentObjectTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACVATInvoiceNoCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVoucherNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentVATFormNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ACDocumentTypeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAssObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_pteACDocumentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACDocumentExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentObjectTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceNoCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATFormNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDocumentTypeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACDocumentNo1
            // 
            this.fld_txtACDocumentNo1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo1.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo1.BOSDescription = null;
            this.fld_txtACDocumentNo1.BOSError = null;
            this.fld_txtACDocumentNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentNo1.Location = new System.Drawing.Point(219, 12);
            this.fld_txtACDocumentNo1.Name = "fld_txtACDocumentNo1";
            this.fld_txtACDocumentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo1.Screen = null;
            this.fld_txtACDocumentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo1.TabIndex = 0;
            this.fld_txtACDocumentNo1.Tag = "DC";
            // 
            // fld_dteACDocumentDate
            // 
            this.fld_dteACDocumentDate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate.BOSDataMember = "ACDocumentDate";
            this.fld_dteACDocumentDate.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentDate.BOSDescription = null;
            this.fld_dteACDocumentDate.BOSError = null;
            this.fld_dteACDocumentDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteACDocumentDate.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentDate.EditValue = null;
            this.fld_dteACDocumentDate.Location = new System.Drawing.Point(490, 12);
            this.fld_dteACDocumentDate.Name = "fld_dteACDocumentDate";
            this.fld_dteACDocumentDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentDate.Screen = null;
            this.fld_dteACDocumentDate.Size = new System.Drawing.Size(173, 20);
            this.fld_dteACDocumentDate.TabIndex = 4;
            this.fld_dteACDocumentDate.Tag = "DC";
            // 
            // fld_medACDocumentDesc
            // 
            this.fld_medACDocumentDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSDataMember = "ACDocumentDesc";
            this.fld_medACDocumentDesc.BOSDataSource = "ACDocuments";
            this.fld_medACDocumentDesc.BOSDescription = null;
            this.fld_medACDocumentDesc.BOSError = null;
            this.fld_medACDocumentDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.BOSPropertyName = "Text";
            this.fld_medACDocumentDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medACDocumentDesc.Location = new System.Drawing.Point(219, 116);
            this.fld_medACDocumentDesc.Name = "fld_medACDocumentDesc";
            this.fld_medACDocumentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACDocumentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACDocumentDesc.Screen = null;
            this.fld_medACDocumentDesc.Size = new System.Drawing.Size(444, 31);
            this.fld_medACDocumentDesc.TabIndex = 8;
            this.fld_medACDocumentDesc.Tag = "DC";
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(128, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 9;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(398, 15);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 3;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Ngày chứng từ";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(128, 119);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 7;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Diễn giải";
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
            this.fld_grcGroupControl1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 211);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(954, 415);
            this.fld_grcGroupControl1.TabIndex = 10;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(950, 391);
            this.fld_dgcACDocumentEntrys.TabIndex = 0;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.bosDateEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentObjectTaxNumber);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVATSymbol);
            this.bosPanel1.Controls.Add(this.fld_lkeACVATInvoiceNoCombo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVoucherNo);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentVATFormNo);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeACVATDocumentType);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosMemoEdit1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACDocumentTypeID1);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_pteACDocumentEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentNo1);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_medACDocumentDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(962, 626);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosDateEdit1.BOSDataMember = "ACDocumentInvoiceDate";
            this.bosDateEdit1.BOSDataSource = "ACDocuments";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosDateEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosDateEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(791, 168);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(159, 20);
            this.bosDateEdit1.TabIndex = 114;
            this.bosDateEdit1.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.Location = new System.Drawing.Point(691, 171);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(67, 13);
            this.bosLabel9.TabIndex = 113;
            this.bosLabel9.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel9.Text = "Ngày hóa đơn";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(692, 145);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(20, 13);
            this.bosLabel18.TabIndex = 112;
            this.bosLabel18.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.Text = "MST";
            // 
            // fld_txtACDocumentObjectTaxNumber
            // 
            this.fld_txtACDocumentObjectTaxNumber.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentObjectTaxNumber.BOSDataMember = "ACDocumentObjectTaxNumber";
            this.fld_txtACDocumentObjectTaxNumber.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentObjectTaxNumber.BOSDescription = null;
            this.fld_txtACDocumentObjectTaxNumber.BOSError = null;
            this.fld_txtACDocumentObjectTaxNumber.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentObjectTaxNumber.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentObjectTaxNumber.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentObjectTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentObjectTaxNumber.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentObjectTaxNumber.Location = new System.Drawing.Point(791, 142);
            this.fld_txtACDocumentObjectTaxNumber.Name = "fld_txtACDocumentObjectTaxNumber";
            this.fld_txtACDocumentObjectTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentObjectTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentObjectTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentObjectTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentObjectTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentObjectTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentObjectTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentObjectTaxNumber.Screen = null;
            this.fld_txtACDocumentObjectTaxNumber.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentObjectTaxNumber.TabIndex = 15;
            this.fld_txtACDocumentObjectTaxNumber.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(692, 119);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(35, 13);
            this.bosLabel20.TabIndex = 110;
            this.bosLabel20.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel20.Text = "Ký hiệu";
            // 
            // fld_txtACDocumentVATSymbol
            // 
            this.fld_txtACDocumentVATSymbol.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATSymbol.BOSDataMember = "ACDocumentVATSymbol";
            this.fld_txtACDocumentVATSymbol.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVATSymbol.BOSDescription = null;
            this.fld_txtACDocumentVATSymbol.BOSError = null;
            this.fld_txtACDocumentVATSymbol.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATSymbol.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATSymbol.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVATSymbol.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATSymbol.Location = new System.Drawing.Point(791, 116);
            this.fld_txtACDocumentVATSymbol.Name = "fld_txtACDocumentVATSymbol";
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVATSymbol.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVATSymbol.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVATSymbol.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVATSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVATSymbol.Screen = null;
            this.fld_txtACDocumentVATSymbol.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVATSymbol.TabIndex = 14;
            this.fld_txtACDocumentVATSymbol.Tag = "DC";
            // 
            // fld_lkeACVATInvoiceNoCombo
            // 
            this.fld_lkeACVATInvoiceNoCombo.BOSAllowAddNew = false;
            this.fld_lkeACVATInvoiceNoCombo.BOSAllowDummy = true;
            this.fld_lkeACVATInvoiceNoCombo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSDataMember = "ACVATInvoiceNoCombo";
            this.fld_lkeACVATInvoiceNoCombo.BOSDataSource = "ACDocuments";
            this.fld_lkeACVATInvoiceNoCombo.BOSDescription = null;
            this.fld_lkeACVATInvoiceNoCombo.BOSError = null;
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSPropertyName = "EditValue";
            this.fld_lkeACVATInvoiceNoCombo.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.CurrentDisplayText = null;
            this.fld_lkeACVATInvoiceNoCombo.Location = new System.Drawing.Point(791, 90);
            this.fld_lkeACVATInvoiceNoCombo.Name = "fld_lkeACVATInvoiceNoCombo";
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATInvoiceNoCombo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATInvoiceNoCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATInvoiceNoCombo.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATInvoiceNoCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATInvoiceNoCombo.Screen = null;
            this.fld_lkeACVATInvoiceNoCombo.Size = new System.Drawing.Size(159, 20);
            this.fld_lkeACVATInvoiceNoCombo.TabIndex = 13;
            this.fld_lkeACVATInvoiceNoCombo.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(692, 93);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(85, 13);
            this.bosLabel10.TabIndex = 108;
            this.bosLabel10.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel10.Text = "Mã hóa đơn GTGT";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(691, 68);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(54, 13);
            this.bosLabel19.TabIndex = 106;
            this.bosLabel19.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel19.Text = "Số hóa đơn";
            // 
            // fld_txtACDocumentVoucherNo
            // 
            this.fld_txtACDocumentVoucherNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVoucherNo.BOSDataMember = "ACDocumentVoucherNo";
            this.fld_txtACDocumentVoucherNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVoucherNo.BOSDescription = null;
            this.fld_txtACDocumentVoucherNo.BOSError = null;
            this.fld_txtACDocumentVoucherNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVoucherNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVoucherNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVoucherNo.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVoucherNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVoucherNo.Location = new System.Drawing.Point(791, 65);
            this.fld_txtACDocumentVoucherNo.Name = "fld_txtACDocumentVoucherNo";
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVoucherNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVoucherNo.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVoucherNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVoucherNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVoucherNo.Screen = null;
            this.fld_txtACDocumentVoucherNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVoucherNo.TabIndex = 12;
            this.fld_txtACDocumentVoucherNo.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(692, 42);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 104;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.Text = "Mẫu số";
            // 
            // fld_txtACDocumentVATFormNo
            // 
            this.fld_txtACDocumentVATFormNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATFormNo.BOSDataMember = "ACDocumentVATFormNo";
            this.fld_txtACDocumentVATFormNo.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentVATFormNo.BOSDescription = null;
            this.fld_txtACDocumentVATFormNo.BOSError = null;
            this.fld_txtACDocumentVATFormNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATFormNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATFormNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATFormNo.BOSPropertyName = "EditValue";
            this.fld_txtACDocumentVATFormNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentVATFormNo.Location = new System.Drawing.Point(791, 39);
            this.fld_txtACDocumentVATFormNo.Name = "fld_txtACDocumentVATFormNo";
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentVATFormNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentVATFormNo.Properties.Mask.EditMask = "n";
            this.fld_txtACDocumentVATFormNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentVATFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentVATFormNo.Screen = null;
            this.fld_txtACDocumentVATFormNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtACDocumentVATFormNo.TabIndex = 11;
            this.fld_txtACDocumentVATFormNo.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(691, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(61, 13);
            this.bosLabel8.TabIndex = 102;
            this.bosLabel8.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel8.Text = "Loại hóa đơn";
            // 
            // fld_lkeACVATDocumentType
            // 
            this.fld_lkeACVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeACVATDocumentType.BOSAllowDummy = false;
            this.fld_lkeACVATDocumentType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSDataMember = "ACVATDocumentType";
            this.fld_lkeACVATDocumentType.BOSDataSource = "ACDocuments";
            this.fld_lkeACVATDocumentType.BOSDescription = null;
            this.fld_lkeACVATDocumentType.BOSError = null;
            this.fld_lkeACVATDocumentType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATDocumentType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.CurrentDisplayText = null;
            this.fld_lkeACVATDocumentType.Location = new System.Drawing.Point(791, 12);
            this.fld_lkeACVATDocumentType.Name = "fld_lkeACVATDocumentType";
            this.fld_lkeACVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATDocumentType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeACVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATDocumentType.Screen = null;
            this.fld_lkeACVATDocumentType.Size = new System.Drawing.Size(159, 20);
            this.fld_lkeACVATDocumentType.TabIndex = 10;
            this.fld_lkeACVATDocumentType.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel7.Location = new System.Drawing.Point(128, 156);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 49;
            this.bosLabel7.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel7.Text = "Mặt hàng";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosMemoEdit1.BOSDataMember = "ACDocumentProductDesc";
            this.bosMemoEdit1.BOSDataSource = "ACDocuments";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosMemoEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosMemoEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.bosMemoEdit1.Location = new System.Drawing.Point(219, 153);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(444, 31);
            this.bosMemoEdit1.TabIndex = 9;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_lkeFK_ACDocumentTypeID1
            // 
            this.fld_lkeFK_ACDocumentTypeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDocumentTypeID1.BOSAllowDummy = true;
            this.fld_lkeFK_ACDocumentTypeID1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSDataMember = "FK_ACDocumentTypeID";
            this.fld_lkeFK_ACDocumentTypeID1.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACDocumentTypeID1.BOSDescription = null;
            this.fld_lkeFK_ACDocumentTypeID1.BOSError = null;
            this.fld_lkeFK_ACDocumentTypeID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACDocumentTypeID1.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.CurrentDisplayText = null;
            this.fld_lkeFK_ACDocumentTypeID1.Enabled = false;
            this.fld_lkeFK_ACDocumentTypeID1.Location = new System.Drawing.Point(490, 90);
            this.fld_lkeFK_ACDocumentTypeID1.Name = "fld_lkeFK_ACDocumentTypeID1";
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDocumentTypeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACDocumentTypeDesc", "Loại chứng từ")});
            this.fld_lkeFK_ACDocumentTypeID1.Properties.DisplayMember = "ACDocumentTypeDesc";
            this.fld_lkeFK_ACDocumentTypeID1.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACDocumentTypeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACDocumentTypeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDocumentTypeID1.Properties.ValueMember = "ACDocumentTypeID";
            this.fld_lkeFK_ACDocumentTypeID1.Screen = null;
            this.fld_lkeFK_ACDocumentTypeID1.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeFK_ACDocumentTypeID1.TabIndex = 7;
            this.fld_lkeFK_ACDocumentTypeID1.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel6.Location = new System.Drawing.Point(398, 93);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 47;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Loại chứng từ";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ACDocuments";
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
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(490, 38);
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
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 5;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Location = new System.Drawing.Point(399, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(85, 13);
            this.bosLabel5.TabIndex = 46;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Khoản mục chi phí";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(219, 64);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 2;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = null;
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.Location = new System.Drawing.Point(490, 64);
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.fld_lkeFK_ACAssObjectID.Size = new System.Drawing.Size(173, 20);
            this.fld_lkeFK_ACAssObjectID.TabIndex = 6;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(219, 38);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 1;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ACObjectID_EditValueChanged);
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_pteACDocumentEmployeePicture
            // 
            this.fld_pteACDocumentEmployeePicture.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteACDocumentEmployeePicture.BOSDataMember = "ACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.BOSDataSource = "ACDocuments";
            this.fld_pteACDocumentEmployeePicture.BOSDescription = null;
            this.fld_pteACDocumentEmployeePicture.BOSError = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteACDocumentEmployeePicture.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteACDocumentEmployeePicture.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteACDocumentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACDocumentEmployeePicture.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_pteACDocumentEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteACDocumentEmployeePicture.Name = "fld_pteACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteACDocumentEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteACDocumentEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteACDocumentEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteACDocumentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACDocumentEmployeePicture.Screen = null;
            this.fld_pteACDocumentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACDocumentEmployeePicture.TabIndex = 0;
            this.fld_pteACDocumentEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACDocuments";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_txtACDocumentExchangeRate
            // 
            this.fld_txtACDocumentExchangeRate.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentExchangeRate.BOSDataMember = "ACDocumentExchangeRate";
            this.fld_txtACDocumentExchangeRate.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentExchangeRate.BOSDescription = null;
            this.fld_txtACDocumentExchangeRate.BOSError = null;
            this.fld_txtACDocumentExchangeRate.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentExchangeRate.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentExchangeRate.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentExchangeRate.BOSPropertyName = "Text";
            this.fld_txtACDocumentExchangeRate.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACDocumentExchangeRate.Location = new System.Drawing.Point(219, 90);
            this.fld_txtACDocumentExchangeRate.Name = "fld_txtACDocumentExchangeRate";
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentExchangeRate.Screen = null;
            this.fld_txtACDocumentExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentExchangeRate.TabIndex = 3;
            this.fld_txtACDocumentExchangeRate.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Location = new System.Drawing.Point(128, 93);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(29, 13);
            this.bosLabel3.TabIndex = 9;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Tỷ giá";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel2.Location = new System.Drawing.Point(128, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel4.Location = new System.Drawing.Point(398, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(57, 13);
            this.bosLabel4.TabIndex = 9;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Đối tượng 2";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Location = new System.Drawing.Point(128, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(57, 13);
            this.bosLabel1.TabIndex = 9;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Đối tượng 1";
            // 
            // DMDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(962, 626);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDC100";
            this.Text = "Thông tin ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentObjectTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceNoCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentVATFormNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDocumentTypeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteACDocumentEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSTextBox fld_txtACDocumentExchangeRate;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDocumentTypeID1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtACDocumentVoucherNo;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACDocumentVATFormNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeACVATDocumentType;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtACDocumentVATSymbol;
        private BOSComponent.BOSLookupEdit fld_lkeACVATInvoiceNoCombo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtACDocumentObjectTaxNumber;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSLabel bosLabel9;
	}
}
