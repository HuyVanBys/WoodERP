using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ACVAT.UI
{
	/// <summary>
	/// Summary description for DMAS100
	/// </summary>
    partial class DMACVAT100
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
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_medACVATComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fdl_medACVATInvoiceComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_Line3 = new BOSComponent.BOSLine(this.components);
            this.fld_medACVATDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeACVATDocumentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACVATObjectTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATObjectCareer = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATTotalAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACVATObjectAddress = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACVATDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACVATInvoiceDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACVATInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACVATObjectName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACVATInvoiceType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACVATReceiver = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATInvoiceDeliveryName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATSymbol = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACVATInvoiceNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACVATNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACVATComment.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fdl_medACVATInvoiceComment.Properties)).BeginInit();
            this.fld_Line3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACVATDesc.Properties)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectCareer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceDeliveryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine3);
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.fld_Line3);
            this.bosPanel1.Controls.Add(this.bosLine4);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(799, 499);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_medACVATComment);
            this.bosLine3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine3.Location = new System.Drawing.Point(564, 248);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(231, 108);
            this.bosLine3.TabIndex = 3;
            this.bosLine3.TabStop = false;
            this.bosLine3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine3.Text = "Ghi chú khác";
            // 
            // fld_medACVATComment
            // 
            this.fld_medACVATComment.BOSComment = null;
            this.fld_medACVATComment.BOSDataMember = "ACVATComment";
            this.fld_medACVATComment.BOSDataSource = "ACVATs";
            this.fld_medACVATComment.BOSDescription = null;
            this.fld_medACVATComment.BOSError = null;
            this.fld_medACVATComment.BOSFieldGroup = null;
            this.fld_medACVATComment.BOSFieldRelation = null;
            this.fld_medACVATComment.BOSPrivilege = null;
            this.fld_medACVATComment.BOSPropertyName = "EditValue";
            this.fld_medACVATComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medACVATComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medACVATComment.Name = "fld_medACVATComment";
            this.fld_medACVATComment.Screen = null;
            this.fld_medACVATComment.Size = new System.Drawing.Size(225, 88);
            this.fld_medACVATComment.TabIndex = 0;
            this.fld_medACVATComment.Tag = "DC";
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fdl_medACVATInvoiceComment);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(281, 248);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(277, 108);
            this.bosLine2.TabIndex = 2;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine2.Text = "Ghi chú thanh toán";
            // 
            // fdl_medACVATInvoiceComment
            // 
            this.fdl_medACVATInvoiceComment.BOSComment = null;
            this.fdl_medACVATInvoiceComment.BOSDataMember = "ACVATInvoiceComment";
            this.fdl_medACVATInvoiceComment.BOSDataSource = "ACVATs";
            this.fdl_medACVATInvoiceComment.BOSDescription = null;
            this.fdl_medACVATInvoiceComment.BOSError = null;
            this.fdl_medACVATInvoiceComment.BOSFieldGroup = null;
            this.fdl_medACVATInvoiceComment.BOSFieldRelation = null;
            this.fdl_medACVATInvoiceComment.BOSPrivilege = null;
            this.fdl_medACVATInvoiceComment.BOSPropertyName = "EditValue";
            this.fdl_medACVATInvoiceComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdl_medACVATInvoiceComment.Location = new System.Drawing.Point(3, 17);
            this.fdl_medACVATInvoiceComment.Name = "fdl_medACVATInvoiceComment";
            this.fdl_medACVATInvoiceComment.Screen = null;
            this.fdl_medACVATInvoiceComment.Size = new System.Drawing.Size(271, 88);
            this.fdl_medACVATInvoiceComment.TabIndex = 0;
            this.fdl_medACVATInvoiceComment.Tag = "DC";
            // 
            // fld_Line3
            // 
            this.fld_Line3.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSDescription = null;
            this.fld_Line3.BOSError = null;
            this.fld_Line3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.BOSPropertyName = null;
            this.fld_Line3.Controls.Add(this.fld_medACVATDesc);
            this.fld_Line3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line3.Location = new System.Drawing.Point(3, 248);
            this.fld_Line3.Name = "fld_Line3";
            this.fld_Line3.Screen = null;
            this.fld_Line3.Size = new System.Drawing.Size(277, 108);
            this.fld_Line3.TabIndex = 1;
            this.fld_Line3.TabStop = false;
            this.fld_Line3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Line3.Text = "Mô tả dịch vụ, hàng hóa";
            // 
            // fld_medACVATDesc
            // 
            this.fld_medACVATDesc.BOSComment = null;
            this.fld_medACVATDesc.BOSDataMember = "ACVATDesc";
            this.fld_medACVATDesc.BOSDataSource = "ACVATs";
            this.fld_medACVATDesc.BOSDescription = null;
            this.fld_medACVATDesc.BOSError = null;
            this.fld_medACVATDesc.BOSFieldGroup = null;
            this.fld_medACVATDesc.BOSFieldRelation = null;
            this.fld_medACVATDesc.BOSPrivilege = null;
            this.fld_medACVATDesc.BOSPropertyName = "EditValue";
            this.fld_medACVATDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medACVATDesc.Location = new System.Drawing.Point(3, 17);
            this.fld_medACVATDesc.MenuManager = this.screenToolbar;
            this.fld_medACVATDesc.Name = "fld_medACVATDesc";
            this.fld_medACVATDesc.Screen = null;
            this.fld_medACVATDesc.Size = new System.Drawing.Size(271, 88);
            this.fld_medACVATDesc.TabIndex = 0;
            this.fld_medACVATDesc.Tag = "DC";
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BackColor = System.Drawing.Color.Transparent;
            this.bosLine4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_lkeACVATDocumentType);
            this.bosLine4.Controls.Add(this.bosLabel13);
            this.bosLine4.Controls.Add(this.fld_txtACVATObjectTaxNumber);
            this.bosLine4.Controls.Add(this.fld_txtACVATObjectCareer);
            this.bosLine4.Controls.Add(this.fld_txtACVATTotalAmount);
            this.bosLine4.Controls.Add(this.bosLabel12);
            this.bosLine4.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosLine4.Controls.Add(this.fld_lblLabel5);
            this.bosLine4.Controls.Add(this.bosLabel14);
            this.bosLine4.Controls.Add(this.bosLabel16);
            this.bosLine4.Controls.Add(this.bosLabel1);
            this.bosLine4.Controls.Add(this.fld_txtACVATObjectAddress);
            this.bosLine4.Controls.Add(this.bosLabel9);
            this.bosLine4.Controls.Add(this.fld_dteACVATDate);
            this.bosLine4.Controls.Add(this.fld_dteACVATInvoiceDeliveryDate);
            this.bosLine4.Controls.Add(this.fld_lblLabel13);
            this.bosLine4.Controls.Add(this.fld_dteACVATInvoiceDate);
            this.bosLine4.Controls.Add(this.fld_txtACVATObjectName);
            this.bosLine4.Controls.Add(this.bosLabel2);
            this.bosLine4.Controls.Add(this.bosLabel17);
            this.bosLine4.Controls.Add(this.fld_lkeACVATInvoiceType);
            this.bosLine4.Controls.Add(this.fld_txtACVATReceiver);
            this.bosLine4.Controls.Add(this.fld_txtACVATAmount);
            this.bosLine4.Controls.Add(this.fld_txtACVATTaxAmount);
            this.bosLine4.Controls.Add(this.fld_txtACVATTaxPercent);
            this.bosLine4.Controls.Add(this.fld_txtACVATInvoiceDeliveryName);
            this.bosLine4.Controls.Add(this.fld_txtACVATSymbol);
            this.bosLine4.Controls.Add(this.fld_txtACVATInvoiceNo);
            this.bosLine4.Controls.Add(this.bosLabel7);
            this.bosLine4.Controls.Add(this.bosLabel6);
            this.bosLine4.Controls.Add(this.bosLabel8);
            this.bosLine4.Controls.Add(this.bosLabel5);
            this.bosLine4.Controls.Add(this.bosLabel4);
            this.bosLine4.Controls.Add(this.bosLabel3);
            this.bosLine4.Controls.Add(this.bosLabel15);
            this.bosLine4.Controls.Add(this.bosLabel10);
            this.bosLine4.Controls.Add(this.bosLabel11);
            this.bosLine4.Controls.Add(this.fld_txtACVATNo);
            this.bosLine4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine4.Location = new System.Drawing.Point(3, 3);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(792, 239);
            this.bosLine4.TabIndex = 0;
            this.bosLine4.TabStop = false;
            this.bosLine4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLine4.Text = "Thông tin VAT";
            // 
            // fld_lkeACVATDocumentType
            // 
            this.fld_lkeACVATDocumentType.BOSAllowAddNew = false;
            this.fld_lkeACVATDocumentType.BOSAllowDummy = true;
            this.fld_lkeACVATDocumentType.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSDataMember = "";
            this.fld_lkeACVATDocumentType.BOSDataSource = "ACVATs";
            this.fld_lkeACVATDocumentType.BOSDescription = null;
            this.fld_lkeACVATDocumentType.BOSError = null;
            this.fld_lkeACVATDocumentType.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATDocumentType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.Location = new System.Drawing.Point(368, 21);
            this.fld_lkeACVATDocumentType.Name = "fld_lkeACVATDocumentType";
            this.fld_lkeACVATDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATDocumentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATDocumentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "Loại")});
            this.fld_lkeACVATDocumentType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeACVATDocumentType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATDocumentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATDocumentType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeACVATDocumentType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACVATDocumentType, true);
            this.fld_lkeACVATDocumentType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACVATDocumentType.TabIndex = 3;
            this.fld_lkeACVATDocumentType.Tag = "DC";
            this.fld_lkeACVATDocumentType.EditValueChanged += new System.EventHandler(this.fld_lkeACVATDocumentType_EditValueChanged);
            this.fld_lkeACVATDocumentType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeACVATDocumentType_QueryPopUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(545, 102);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(58, 13);
            this.bosLabel13.TabIndex = 18;
            this.bosLabel13.Text = "Ngành nghề";
            // 
            // fld_txtACVATObjectTaxNumber
            // 
            this.fld_txtACVATObjectTaxNumber.BOSComment = null;
            this.fld_txtACVATObjectTaxNumber.BOSDataMember = "ACVATObjectTaxNumber";
            this.fld_txtACVATObjectTaxNumber.BOSDataSource = "ACVATs";
            this.fld_txtACVATObjectTaxNumber.BOSDescription = null;
            this.fld_txtACVATObjectTaxNumber.BOSError = null;
            this.fld_txtACVATObjectTaxNumber.BOSFieldGroup = null;
            this.fld_txtACVATObjectTaxNumber.BOSFieldRelation = null;
            this.fld_txtACVATObjectTaxNumber.BOSPrivilege = null;
            this.fld_txtACVATObjectTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectTaxNumber.Location = new System.Drawing.Point(646, 73);
            this.fld_txtACVATObjectTaxNumber.Name = "fld_txtACVATObjectTaxNumber";
            this.fld_txtACVATObjectTaxNumber.Screen = null;
            this.fld_txtACVATObjectTaxNumber.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATObjectTaxNumber.TabIndex = 15;
            this.fld_txtACVATObjectTaxNumber.Tag = "DC";
            // 
            // fld_txtACVATObjectCareer
            // 
            this.fld_txtACVATObjectCareer.BOSComment = null;
            this.fld_txtACVATObjectCareer.BOSDataMember = "ACVATObjectCareer";
            this.fld_txtACVATObjectCareer.BOSDataSource = "ACVATs";
            this.fld_txtACVATObjectCareer.BOSDescription = null;
            this.fld_txtACVATObjectCareer.BOSError = null;
            this.fld_txtACVATObjectCareer.BOSFieldGroup = null;
            this.fld_txtACVATObjectCareer.BOSFieldRelation = null;
            this.fld_txtACVATObjectCareer.BOSPrivilege = null;
            this.fld_txtACVATObjectCareer.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectCareer.Location = new System.Drawing.Point(646, 99);
            this.fld_txtACVATObjectCareer.Name = "fld_txtACVATObjectCareer";
            this.fld_txtACVATObjectCareer.Screen = null;
            this.fld_txtACVATObjectCareer.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATObjectCareer.TabIndex = 19;
            this.fld_txtACVATObjectCareer.Tag = "DC";
            // 
            // fld_txtACVATTotalAmount
            // 
            this.fld_txtACVATTotalAmount.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACVATTotalAmount.BOSDataMember = "ACVATTotalAmount";
            this.fld_txtACVATTotalAmount.BOSDataSource = "ACVATs";
            this.fld_txtACVATTotalAmount.BOSDescription = null;
            this.fld_txtACVATTotalAmount.BOSError = null;
            this.fld_txtACVATTotalAmount.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACVATTotalAmount.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACVATTotalAmount.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACVATTotalAmount.BOSPropertyName = "EditValue";
            this.fld_txtACVATTotalAmount.EditValue = "0.00";
            this.fld_txtACVATTotalAmount.Location = new System.Drawing.Point(646, 151);
            this.fld_txtACVATTotalAmount.Name = "fld_txtACVATTotalAmount";
            this.fld_txtACVATTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.fld_txtACVATTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACVATTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACVATTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACVATTotalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACVATTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACVATTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACVATTotalAmount.Properties.ReadOnly = true;
            this.fld_txtACVATTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACVATTotalAmount.Screen = null;
            this.fld_txtACVATTotalAmount.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATTotalAmount.TabIndex = 29;
            this.fld_txtACVATTotalAmount.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(545, 76);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(53, 13);
            this.bosLabel12.TabIndex = 14;
            this.bosLabel12.Text = "Mã số thuế";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ACVATs";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(646, 47);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectNo";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 11;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Location = new System.Drawing.Point(545, 50);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 10;
            this.fld_lblLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(13, 102);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(32, 13);
            this.bosLabel14.TabIndex = 16;
            this.bosLabel14.Text = "Địa chỉ";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(276, 206);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(72, 13);
            this.bosLabel16.TabIndex = 36;
            this.bosLabel16.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel16.Text = "Ngày chứng từ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(545, 180);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(86, 13);
            this.bosLabel1.TabIndex = 32;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Text = "Ngày giao HĐ gốc";
            // 
            // fld_txtACVATObjectAddress
            // 
            this.fld_txtACVATObjectAddress.BOSComment = null;
            this.fld_txtACVATObjectAddress.BOSDataMember = "ACVATObjectAddress";
            this.fld_txtACVATObjectAddress.BOSDataSource = "ACVATs";
            this.fld_txtACVATObjectAddress.BOSDescription = null;
            this.fld_txtACVATObjectAddress.BOSError = null;
            this.fld_txtACVATObjectAddress.BOSFieldGroup = null;
            this.fld_txtACVATObjectAddress.BOSFieldRelation = null;
            this.fld_txtACVATObjectAddress.BOSPrivilege = null;
            this.fld_txtACVATObjectAddress.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectAddress.Location = new System.Drawing.Point(111, 99);
            this.fld_txtACVATObjectAddress.Name = "fld_txtACVATObjectAddress";
            this.fld_txtACVATObjectAddress.Screen = null;
            this.fld_txtACVATObjectAddress.Size = new System.Drawing.Size(388, 20);
            this.fld_txtACVATObjectAddress.TabIndex = 17;
            this.fld_txtACVATObjectAddress.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(13, 76);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(67, 13);
            this.bosLabel9.TabIndex = 12;
            this.bosLabel9.Text = "Tên đối tượng";
            // 
            // fld_dteACVATDate
            // 
            this.fld_dteACVATDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATDate.BOSDataMember = "ACVATDate";
            this.fld_dteACVATDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATDate.BOSDescription = null;
            this.fld_dteACVATDate.BOSError = null;
            this.fld_dteACVATDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATDate.EditValue = null;
            this.fld_dteACVATDate.Location = new System.Drawing.Point(368, 203);
            this.fld_dteACVATDate.Name = "fld_dteACVATDate";
            this.fld_dteACVATDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATDate.Screen = null;
            this.fld_dteACVATDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATDate.TabIndex = 37;
            this.fld_dteACVATDate.Tag = "DC";
            // 
            // fld_dteACVATInvoiceDeliveryDate
            // 
            this.fld_dteACVATInvoiceDeliveryDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDeliveryDate.BOSDataMember = "ACVATInvoiceDeliveryDate";
            this.fld_dteACVATInvoiceDeliveryDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATInvoiceDeliveryDate.BOSDescription = null;
            this.fld_dteACVATInvoiceDeliveryDate.BOSError = null;
            this.fld_dteACVATInvoiceDeliveryDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDeliveryDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDeliveryDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATInvoiceDeliveryDate.EditValue = null;
            this.fld_dteACVATInvoiceDeliveryDate.Location = new System.Drawing.Point(646, 177);
            this.fld_dteACVATInvoiceDeliveryDate.Name = "fld_dteACVATInvoiceDeliveryDate";
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATInvoiceDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATInvoiceDeliveryDate.Screen = null;
            this.fld_dteACVATInvoiceDeliveryDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATInvoiceDeliveryDate.TabIndex = 33;
            this.fld_dteACVATInvoiceDeliveryDate.Tag = "DC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(276, 50);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel13.TabIndex = 8;
            this.fld_lblLabel13.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.Text = "Ngày hóa đơn";
            // 
            // fld_dteACVATInvoiceDate
            // 
            this.fld_dteACVATInvoiceDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDate.BOSDataMember = "ACVATInvoiceDate";
            this.fld_dteACVATInvoiceDate.BOSDataSource = "ACVATs";
            this.fld_dteACVATInvoiceDate.BOSDescription = null;
            this.fld_dteACVATInvoiceDate.BOSError = null;
            this.fld_dteACVATInvoiceDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACVATInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteACVATInvoiceDate.EditValue = null;
            this.fld_dteACVATInvoiceDate.Location = new System.Drawing.Point(368, 47);
            this.fld_dteACVATInvoiceDate.Name = "fld_dteACVATInvoiceDate";
            this.fld_dteACVATInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACVATInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACVATInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACVATInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACVATInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACVATInvoiceDate.Screen = null;
            this.fld_dteACVATInvoiceDate.Size = new System.Drawing.Size(131, 20);
            this.fld_dteACVATInvoiceDate.TabIndex = 9;
            this.fld_dteACVATInvoiceDate.Tag = "DC";
            // 
            // fld_txtACVATObjectName
            // 
            this.fld_txtACVATObjectName.BOSComment = null;
            this.fld_txtACVATObjectName.BOSDataMember = "ACVATObjectName";
            this.fld_txtACVATObjectName.BOSDataSource = "ACVATs";
            this.fld_txtACVATObjectName.BOSDescription = null;
            this.fld_txtACVATObjectName.BOSError = null;
            this.fld_txtACVATObjectName.BOSFieldGroup = null;
            this.fld_txtACVATObjectName.BOSFieldRelation = null;
            this.fld_txtACVATObjectName.BOSPrivilege = null;
            this.fld_txtACVATObjectName.BOSPropertyName = "EditValue";
            this.fld_txtACVATObjectName.Location = new System.Drawing.Point(111, 73);
            this.fld_txtACVATObjectName.Name = "fld_txtACVATObjectName";
            this.fld_txtACVATObjectName.Screen = null;
            this.fld_txtACVATObjectName.Size = new System.Drawing.Size(388, 20);
            this.fld_txtACVATObjectName.TabIndex = 13;
            this.fld_txtACVATObjectName.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(276, 24);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Text = "Loại hóa đơn";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(13, 24);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(66, 13);
            this.bosLabel17.TabIndex = 0;
            this.bosLabel17.Text = "Loại chứng từ";
            // 
            // fld_lkeACVATInvoiceType
            // 
            this.fld_lkeACVATInvoiceType.BOSAllowAddNew = false;
            this.fld_lkeACVATInvoiceType.BOSAllowDummy = false;
            this.fld_lkeACVATInvoiceType.BOSComment = null;
            this.fld_lkeACVATInvoiceType.BOSDataMember = "ACVATInvoiceType";
            this.fld_lkeACVATInvoiceType.BOSDataSource = "ACVATs";
            this.fld_lkeACVATInvoiceType.BOSDescription = null;
            this.fld_lkeACVATInvoiceType.BOSError = null;
            this.fld_lkeACVATInvoiceType.BOSFieldGroup = null;
            this.fld_lkeACVATInvoiceType.BOSFieldParent = null;
            this.fld_lkeACVATInvoiceType.BOSFieldRelation = null;
            this.fld_lkeACVATInvoiceType.BOSPrivilege = null;
            this.fld_lkeACVATInvoiceType.BOSPropertyName = "EditValue";
            this.fld_lkeACVATInvoiceType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATInvoiceType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATInvoiceType.CurrentDisplayText = null;
            this.fld_lkeACVATInvoiceType.Location = new System.Drawing.Point(111, 21);
            this.fld_lkeACVATInvoiceType.Name = "fld_lkeACVATInvoiceType";
            this.fld_lkeACVATInvoiceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACVATInvoiceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACVATInvoiceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACVATInvoiceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACVATInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACVATInvoiceType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACVATInvoiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACVATInvoiceType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACVATInvoiceType, true);
            this.fld_lkeACVATInvoiceType.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACVATInvoiceType.TabIndex = 1;
            this.fld_lkeACVATInvoiceType.Tag = "DC";
            this.fld_lkeACVATInvoiceType.EditValueChanged += new System.EventHandler(this.fld_lkeACVATInvoiceType_EditValueChanged);
            // 
            // fld_txtACVATReceiver
            // 
            this.fld_txtACVATReceiver.BOSComment = null;
            this.fld_txtACVATReceiver.BOSDataMember = "ACVATReceiver";
            this.fld_txtACVATReceiver.BOSDataSource = "ACVATs";
            this.fld_txtACVATReceiver.BOSDescription = null;
            this.fld_txtACVATReceiver.BOSError = null;
            this.fld_txtACVATReceiver.BOSFieldGroup = null;
            this.fld_txtACVATReceiver.BOSFieldRelation = null;
            this.fld_txtACVATReceiver.BOSPrivilege = null;
            this.fld_txtACVATReceiver.BOSPropertyName = "EditValue";
            this.fld_txtACVATReceiver.Location = new System.Drawing.Point(111, 177);
            this.fld_txtACVATReceiver.Name = "fld_txtACVATReceiver";
            this.fld_txtACVATReceiver.Screen = null;
            this.fld_txtACVATReceiver.Size = new System.Drawing.Size(388, 20);
            this.fld_txtACVATReceiver.TabIndex = 31;
            this.fld_txtACVATReceiver.Tag = "DC";
            // 
            // fld_txtACVATAmount
            // 
            this.fld_txtACVATAmount.BOSComment = null;
            this.fld_txtACVATAmount.BOSDataMember = "ACVATAmount";
            this.fld_txtACVATAmount.BOSDataSource = "ACVATs";
            this.fld_txtACVATAmount.BOSDescription = null;
            this.fld_txtACVATAmount.BOSError = null;
            this.fld_txtACVATAmount.BOSFieldGroup = null;
            this.fld_txtACVATAmount.BOSFieldRelation = null;
            this.fld_txtACVATAmount.BOSPrivilege = null;
            this.fld_txtACVATAmount.BOSPropertyName = "EditValue";
            this.fld_txtACVATAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtACVATAmount.Location = new System.Drawing.Point(111, 125);
            this.fld_txtACVATAmount.Name = "fld_txtACVATAmount";
            this.fld_txtACVATAmount.Properties.EditFormat.FormatString = "n";
            this.fld_txtACVATAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtACVATAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACVATAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACVATAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACVATAmount.Screen = null;
            this.fld_txtACVATAmount.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATAmount.TabIndex = 21;
            this.fld_txtACVATAmount.Tag = "DC";
            this.fld_txtACVATAmount.Validated += new System.EventHandler(this.fld_txtACVATAmount_Validated);
            // 
            // fld_txtACVATTaxAmount
            // 
            this.fld_txtACVATTaxAmount.BOSComment = null;
            this.fld_txtACVATTaxAmount.BOSDataMember = "ACVATTaxAmount";
            this.fld_txtACVATTaxAmount.BOSDataSource = "ACVATs";
            this.fld_txtACVATTaxAmount.BOSDescription = null;
            this.fld_txtACVATTaxAmount.BOSError = null;
            this.fld_txtACVATTaxAmount.BOSFieldGroup = null;
            this.fld_txtACVATTaxAmount.BOSFieldRelation = null;
            this.fld_txtACVATTaxAmount.BOSPrivilege = null;
            this.fld_txtACVATTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtACVATTaxAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtACVATTaxAmount.Location = new System.Drawing.Point(646, 125);
            this.fld_txtACVATTaxAmount.Name = "fld_txtACVATTaxAmount";
            this.fld_txtACVATTaxAmount.Properties.EditFormat.FormatString = "n";
            this.fld_txtACVATTaxAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtACVATTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACVATTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACVATTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACVATTaxAmount.Screen = null;
            this.fld_txtACVATTaxAmount.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATTaxAmount.TabIndex = 25;
            this.fld_txtACVATTaxAmount.Tag = "DC";
            this.fld_txtACVATTaxAmount.Validated += new System.EventHandler(this.fld_txtACVATTaxAmount_Validated);
            // 
            // fld_txtACVATTaxPercent
            // 
            this.fld_txtACVATTaxPercent.BOSComment = null;
            this.fld_txtACVATTaxPercent.BOSDataMember = "ACVATTaxPercent";
            this.fld_txtACVATTaxPercent.BOSDataSource = "ACVATs";
            this.fld_txtACVATTaxPercent.BOSDescription = null;
            this.fld_txtACVATTaxPercent.BOSError = null;
            this.fld_txtACVATTaxPercent.BOSFieldGroup = null;
            this.fld_txtACVATTaxPercent.BOSFieldRelation = null;
            this.fld_txtACVATTaxPercent.BOSPrivilege = null;
            this.fld_txtACVATTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtACVATTaxPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.fld_txtACVATTaxPercent.Location = new System.Drawing.Point(368, 125);
            this.fld_txtACVATTaxPercent.Name = "fld_txtACVATTaxPercent";
            this.fld_txtACVATTaxPercent.Properties.EditFormat.FormatString = "n";
            this.fld_txtACVATTaxPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtACVATTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtACVATTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACVATTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACVATTaxPercent.Screen = null;
            this.fld_txtACVATTaxPercent.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATTaxPercent.TabIndex = 23;
            this.fld_txtACVATTaxPercent.Tag = "DC";
            this.fld_txtACVATTaxPercent.Validated += new System.EventHandler(this.fld_txtACVATTaxPercent_Validated);
            // 
            // fld_txtACVATInvoiceDeliveryName
            // 
            this.fld_txtACVATInvoiceDeliveryName.BOSComment = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSDataMember = "ACVATInvoiceDeliveryName";
            this.fld_txtACVATInvoiceDeliveryName.BOSDataSource = "ACVATs";
            this.fld_txtACVATInvoiceDeliveryName.BOSDescription = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSError = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSFieldGroup = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSFieldRelation = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSPrivilege = null;
            this.fld_txtACVATInvoiceDeliveryName.BOSPropertyName = "EditValue";
            this.fld_txtACVATInvoiceDeliveryName.Location = new System.Drawing.Point(111, 151);
            this.fld_txtACVATInvoiceDeliveryName.Name = "fld_txtACVATInvoiceDeliveryName";
            this.fld_txtACVATInvoiceDeliveryName.Screen = null;
            this.fld_txtACVATInvoiceDeliveryName.Size = new System.Drawing.Size(388, 20);
            this.fld_txtACVATInvoiceDeliveryName.TabIndex = 27;
            this.fld_txtACVATInvoiceDeliveryName.Tag = "DC";
            // 
            // fld_txtACVATSymbol
            // 
            this.fld_txtACVATSymbol.BOSComment = null;
            this.fld_txtACVATSymbol.BOSDataMember = "ACVATSymbol";
            this.fld_txtACVATSymbol.BOSDataSource = "ACVATs";
            this.fld_txtACVATSymbol.BOSDescription = null;
            this.fld_txtACVATSymbol.BOSError = null;
            this.fld_txtACVATSymbol.BOSFieldGroup = null;
            this.fld_txtACVATSymbol.BOSFieldRelation = null;
            this.fld_txtACVATSymbol.BOSPrivilege = null;
            this.fld_txtACVATSymbol.BOSPropertyName = "EditValue";
            this.fld_txtACVATSymbol.Location = new System.Drawing.Point(111, 47);
            this.fld_txtACVATSymbol.Name = "fld_txtACVATSymbol";
            this.fld_txtACVATSymbol.Screen = null;
            this.fld_txtACVATSymbol.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATSymbol.TabIndex = 7;
            this.fld_txtACVATSymbol.Tag = "DC";
            // 
            // fld_txtACVATInvoiceNo
            // 
            this.fld_txtACVATInvoiceNo.BOSComment = null;
            this.fld_txtACVATInvoiceNo.BOSDataMember = "ACVATInvoiceNo";
            this.fld_txtACVATInvoiceNo.BOSDataSource = "ACVATs";
            this.fld_txtACVATInvoiceNo.BOSDescription = null;
            this.fld_txtACVATInvoiceNo.BOSError = null;
            this.fld_txtACVATInvoiceNo.BOSFieldGroup = null;
            this.fld_txtACVATInvoiceNo.BOSFieldRelation = null;
            this.fld_txtACVATInvoiceNo.BOSPrivilege = null;
            this.fld_txtACVATInvoiceNo.BOSPropertyName = "EditValue";
            this.fld_txtACVATInvoiceNo.Location = new System.Drawing.Point(646, 21);
            this.fld_txtACVATInvoiceNo.MenuManager = this.screenToolbar;
            this.fld_txtACVATInvoiceNo.Name = "fld_txtACVATInvoiceNo";
            this.fld_txtACVATInvoiceNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtACVATInvoiceNo, false);
            this.fld_txtACVATInvoiceNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATInvoiceNo.TabIndex = 5;
            this.fld_txtACVATInvoiceNo.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(545, 128);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 24;
            this.bosLabel7.Text = "Tiền thuế";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(276, 128);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(70, 13);
            this.bosLabel6.TabIndex = 22;
            this.bosLabel6.Text = "Thuế suất (%)";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(545, 154);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 28;
            this.bosLabel8.Text = "Tổng hóa đơn";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(13, 128);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(47, 13);
            this.bosLabel5.TabIndex = 20;
            this.bosLabel5.Text = "Tiền hàng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 180);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(55, 13);
            this.bosLabel4.TabIndex = 30;
            this.bosLabel4.Text = "Người nhận";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 154);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(51, 13);
            this.bosLabel3.TabIndex = 26;
            this.bosLabel3.Text = "Người giao";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(13, 50);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(32, 13);
            this.bosLabel15.TabIndex = 6;
            this.bosLabel15.Text = "Số seri";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(545, 24);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(54, 13);
            this.bosLabel10.TabIndex = 4;
            this.bosLabel10.Text = "Số hóa đơn";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(13, 206);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(61, 13);
            this.bosLabel11.TabIndex = 34;
            this.bosLabel11.Text = "Mã chứng từ";
            // 
            // fld_txtACVATNo
            // 
            this.fld_txtACVATNo.BOSComment = null;
            this.fld_txtACVATNo.BOSDataMember = "ACVATNo";
            this.fld_txtACVATNo.BOSDataSource = "ACVATs";
            this.fld_txtACVATNo.BOSDescription = null;
            this.fld_txtACVATNo.BOSError = null;
            this.fld_txtACVATNo.BOSFieldGroup = null;
            this.fld_txtACVATNo.BOSFieldRelation = null;
            this.fld_txtACVATNo.BOSPrivilege = null;
            this.fld_txtACVATNo.BOSPropertyName = "EditValue";
            this.fld_txtACVATNo.Location = new System.Drawing.Point(111, 203);
            this.fld_txtACVATNo.MenuManager = this.screenToolbar;
            this.fld_txtACVATNo.Name = "fld_txtACVATNo";
            this.fld_txtACVATNo.Screen = null;
            this.fld_txtACVATNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtACVATNo.TabIndex = 35;
            this.fld_txtACVATNo.Tag = "DC";
            // 
            // DMACVAT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACVAT100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACVATComment.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fdl_medACVATInvoiceComment.Properties)).EndInit();
            this.fld_Line3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACVATDesc.Properties)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATDocumentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectCareer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACVATInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATObjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACVATInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceDeliveryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACVATNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeACVATInvoiceType;
        private BOSComponent.BOSTextBox fld_txtACVATInvoiceNo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACVATNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSDateEdit fld_dteACVATInvoiceDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteACVATInvoiceDeliveryDate;
        private BOSComponent.BOSTextBox fld_txtACVATReceiver;
        private BOSComponent.BOSTextBox fld_txtACVATInvoiceDeliveryName;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtACVATTaxPercent;
        private BOSComponent.BOSTextBox fld_txtACVATAmount;
        private BOSComponent.BOSTextBox fld_txtACVATTaxAmount;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtACVATObjectName;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtACVATObjectCareer;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtACVATObjectAddress;
        private BOSComponent.BOSLine fld_Line3;
        private BOSComponent.BOSMemoEdit fld_medACVATDesc;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSMemoEdit fld_medACVATComment;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSMemoEdit fdl_medACVATInvoiceComment;
        private BOSComponent.BOSTextBox fld_txtACVATSymbol;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtACVATTotalAmount;
        private BOSComponent.BOSTextBox fld_txtACVATObjectTaxNumber;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSDateEdit fld_dteACVATDate;
        private BOSComponent.BOSLookupEdit fld_lkeACVATDocumentType;
	}
}
