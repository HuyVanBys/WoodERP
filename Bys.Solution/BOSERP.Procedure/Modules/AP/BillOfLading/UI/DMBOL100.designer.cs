using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BillOfLading.UI
{
	/// <summary>
	/// Summary description for DMBOL100
	/// </summary>
	partial class DMBOL100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBOL100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingReference = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeAPBillOfLadingImportExportType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeAPBillOfLadingType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPBillOfLadingClearanceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingVATTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingEnviromentTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingConsumptionTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingImportTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPBillOfLadingItems = new BOSERP.Modules.BillOfLading.APBillOfLadingItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_GEPaymentTermID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_medAPBillOfLadingDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPBillOfLadingStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPBillOfLadingVATDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingSupplierNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingTaxNumber = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPBillOfLadingDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteAPBillOfLadingBOLDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPBillOfLadingContractDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingContractNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblType = new BOSComponent.BOSLabel(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPBillOfLadingRegisDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingDeclarationNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtAPBillOfLadingNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingImportExportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingClearanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingClearanceDate.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingVATTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingImportTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPBillOfLadingItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPBillOfLadingDesc.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingVATDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingVATDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingSupplierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingTaxNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingBOLDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingBOLDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingContractDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingRegisDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingRegisDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingDeclarationNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingReference);
            this.bosPanel1.Controls.Add(this.fld_lkeAPBillOfLadingImportExportType);
            this.bosPanel1.Controls.Add(this.fld_lkeAPBillOfLadingType);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingClearanceDate);
            this.bosPanel1.Controls.Add(this.bosLabel28);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GEPaymentTermID);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_medAPBillOfLadingDesc);
            this.bosPanel1.Controls.Add(this.statusStrip1);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_lkeAPBillOfLadingStatus);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel33);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingVATDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingSupplierNo);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingTaxNumber);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingDate);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingBOLDate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingNo1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingContractDate);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingContractNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel35);
            this.bosPanel1.Controls.Add(this.fld_lblType);
            this.bosPanel1.Controls.Add(this.bosLabel27);
            this.bosPanel1.Controls.Add(this.fld_dteAPBillOfLadingRegisDate);
            this.bosPanel1.Controls.Add(this.bosLabel26);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingDeclarationNumber);
            this.bosPanel1.Controls.Add(this.fld_txtAPBillOfLadingNo);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(918, 640);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(282, 223);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(67, 13);
            this.bosLabel11.TabIndex = 668;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Số tham chiếu";
            // 
            // fld_txtAPBillOfLadingReference
            // 
            this.fld_txtAPBillOfLadingReference.BOSComment = "";
            this.fld_txtAPBillOfLadingReference.BOSDataMember = "APBillOfLadingReference";
            this.fld_txtAPBillOfLadingReference.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingReference.BOSDescription = null;
            this.fld_txtAPBillOfLadingReference.BOSError = null;
            this.fld_txtAPBillOfLadingReference.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingReference.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingReference.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingReference.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingReference.EditValue = "";
            this.fld_txtAPBillOfLadingReference.Location = new System.Drawing.Point(394, 220);
            this.fld_txtAPBillOfLadingReference.Name = "fld_txtAPBillOfLadingReference";
            this.fld_txtAPBillOfLadingReference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingReference.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingReference.Properties.ReadOnly = true;
            this.fld_txtAPBillOfLadingReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingReference.Screen = null;
            this.fld_txtAPBillOfLadingReference.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingReference.TabIndex = 20;
            this.fld_txtAPBillOfLadingReference.Tag = "DC";
            // 
            // fld_lkeAPBillOfLadingImportExportType
            // 
            this.fld_lkeAPBillOfLadingImportExportType.BOSAllowAddNew = false;
            this.fld_lkeAPBillOfLadingImportExportType.BOSAllowDummy = true;
            this.fld_lkeAPBillOfLadingImportExportType.BOSComment = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSDataMember = "APBillOfLadingImportExportType";
            this.fld_lkeAPBillOfLadingImportExportType.BOSDataSource = "APBillOfLadings";
            this.fld_lkeAPBillOfLadingImportExportType.BOSDescription = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSError = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSFieldGroup = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSFieldParent = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSFieldRelation = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSPrivilege = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSPropertyName = "EditValue";
            this.fld_lkeAPBillOfLadingImportExportType.BOSSelectType = null;
            this.fld_lkeAPBillOfLadingImportExportType.BOSSelectTypeValue = null;
            this.fld_lkeAPBillOfLadingImportExportType.CurrentDisplayText = null;
            this.fld_lkeAPBillOfLadingImportExportType.Location = new System.Drawing.Point(647, 64);
            this.fld_lkeAPBillOfLadingImportExportType.Name = "fld_lkeAPBillOfLadingImportExportType";
            this.fld_lkeAPBillOfLadingImportExportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPBillOfLadingImportExportType.Properties.ColumnName = null;
            this.fld_lkeAPBillOfLadingImportExportType.Properties.NullText = "";
            this.fld_lkeAPBillOfLadingImportExportType.Properties.ReadOnly = true;
            this.fld_lkeAPBillOfLadingImportExportType.Screen = null;
            this.fld_lkeAPBillOfLadingImportExportType.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPBillOfLadingImportExportType.TabIndex = 8;
            this.fld_lkeAPBillOfLadingImportExportType.Tag = "DC";
            // 
            // fld_lkeAPBillOfLadingType
            // 
            this.fld_lkeAPBillOfLadingType.BOSAllowAddNew = false;
            this.fld_lkeAPBillOfLadingType.BOSAllowDummy = true;
            this.fld_lkeAPBillOfLadingType.BOSComment = null;
            this.fld_lkeAPBillOfLadingType.BOSDataMember = "APBillOfLadingType";
            this.fld_lkeAPBillOfLadingType.BOSDataSource = "APBillOfLadings";
            this.fld_lkeAPBillOfLadingType.BOSDescription = null;
            this.fld_lkeAPBillOfLadingType.BOSError = null;
            this.fld_lkeAPBillOfLadingType.BOSFieldGroup = null;
            this.fld_lkeAPBillOfLadingType.BOSFieldParent = null;
            this.fld_lkeAPBillOfLadingType.BOSFieldRelation = null;
            this.fld_lkeAPBillOfLadingType.BOSPrivilege = null;
            this.fld_lkeAPBillOfLadingType.BOSPropertyName = "EditValue";
            this.fld_lkeAPBillOfLadingType.BOSSelectType = null;
            this.fld_lkeAPBillOfLadingType.BOSSelectTypeValue = null;
            this.fld_lkeAPBillOfLadingType.CurrentDisplayText = null;
            this.fld_lkeAPBillOfLadingType.Location = new System.Drawing.Point(103, 90);
            this.fld_lkeAPBillOfLadingType.MenuManager = this.screenToolbar;
            this.fld_lkeAPBillOfLadingType.Name = "fld_lkeAPBillOfLadingType";
            this.fld_lkeAPBillOfLadingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPBillOfLadingType.Properties.ColumnName = null;
            this.fld_lkeAPBillOfLadingType.Properties.NullText = "";
            this.fld_lkeAPBillOfLadingType.Screen = null;
            this.fld_lkeAPBillOfLadingType.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPBillOfLadingType.TabIndex = 9;
            this.fld_lkeAPBillOfLadingType.Tag = "DC";
            // 
            // fld_dteAPBillOfLadingClearanceDate
            // 
            this.fld_dteAPBillOfLadingClearanceDate.BOSComment = "";
            this.fld_dteAPBillOfLadingClearanceDate.BOSDataMember = "APBillOfLadingClearanceDate";
            this.fld_dteAPBillOfLadingClearanceDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingClearanceDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingClearanceDate.BOSError = null;
            this.fld_dteAPBillOfLadingClearanceDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingClearanceDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingClearanceDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingClearanceDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingClearanceDate.EditValue = null;
            this.fld_dteAPBillOfLadingClearanceDate.Location = new System.Drawing.Point(394, 168);
            this.fld_dteAPBillOfLadingClearanceDate.Name = "fld_dteAPBillOfLadingClearanceDate";
            this.fld_dteAPBillOfLadingClearanceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingClearanceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingClearanceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingClearanceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingClearanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingClearanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingClearanceDate.Screen = null;
            this.fld_dteAPBillOfLadingClearanceDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingClearanceDate.TabIndex = 17;
            this.fld_dteAPBillOfLadingClearanceDate.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = "";
            this.bosLabel28.BOSDataMember = "";
            this.bosLabel28.BOSDataSource = "";
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = "";
            this.bosLabel28.BOSFieldRelation = "";
            this.bosLabel28.BOSPrivilege = "";
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(282, 171);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(83, 13);
            this.bosLabel28.TabIndex = 34;
            this.bosLabel28.Tag = "";
            this.bosLabel28.Text = "Ngày thông quan";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.bosLabel29);
            this.bosLine1.Controls.Add(this.bosLabel25);
            this.bosLine1.Controls.Add(this.bosLabel24);
            this.bosLine1.Controls.Add(this.bosLabel23);
            this.bosLine1.Controls.Add(this.bosLabel22);
            this.bosLine1.Controls.Add(this.fld_txtAPBillOfLadingVATTaxPercent);
            this.bosLine1.Controls.Add(this.bosLabel21);
            this.bosLine1.Controls.Add(this.fld_txtAPBillOfLadingEnviromentTaxPercent);
            this.bosLine1.Controls.Add(this.bosLabel20);
            this.bosLine1.Controls.Add(this.fld_txtAPBillOfLadingConsumptionTaxPercent);
            this.bosLine1.Controls.Add(this.bosLabel19);
            this.bosLine1.Controls.Add(this.fld_txtAPBillOfLadingImportTaxPercent);
            this.bosLine1.Location = new System.Drawing.Point(545, 116);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(245, 127);
            this.bosLine1.TabIndex = 40;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "% thuế";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = "";
            this.bosLabel29.BOSDataMember = "";
            this.bosLabel29.BOSDataSource = "";
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = "";
            this.bosLabel29.BOSFieldRelation = "";
            this.bosLabel29.BOSPrivilege = "";
            this.bosLabel29.BOSPropertyName = "";
            this.bosLabel29.Location = new System.Drawing.Point(21, 23);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(79, 13);
            this.bosLabel29.TabIndex = 0;
            this.bosLabel29.Tag = "";
            this.bosLabel29.Text = "Xuất/ nhập khẩu";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(198, 101);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(25, 13);
            this.bosLabel25.TabIndex = 11;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "( % )";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(198, 75);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(25, 13);
            this.bosLabel24.TabIndex = 8;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "( % )";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(198, 49);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(25, 13);
            this.bosLabel23.TabIndex = 5;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "( % )";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(198, 23);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(25, 13);
            this.bosLabel22.TabIndex = 2;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "( % )";
            // 
            // fld_txtAPBillOfLadingVATTaxPercent
            // 
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSComment = "";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSDataMember = "APBillOfLadingVATTaxPercent";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSDescription = null;
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSError = null;
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingVATTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingVATTaxPercent.EditValue = "";
            this.fld_txtAPBillOfLadingVATTaxPercent.Location = new System.Drawing.Point(116, 46);
            this.fld_txtAPBillOfLadingVATTaxPercent.Name = "fld_txtAPBillOfLadingVATTaxPercent";
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingVATTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingVATTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingVATTaxPercent.Screen = null;
            this.fld_txtAPBillOfLadingVATTaxPercent.Size = new System.Drawing.Size(59, 20);
            this.fld_txtAPBillOfLadingVATTaxPercent.TabIndex = 1;
            this.fld_txtAPBillOfLadingVATTaxPercent.Tag = "DC";
            this.fld_txtAPBillOfLadingVATTaxPercent.Validated += new System.EventHandler(this.fld_txtAPBillOfLadingVATTaxPercent_Validated);
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(21, 49);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(26, 13);
            this.bosLabel21.TabIndex = 3;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "GTGT";
            // 
            // fld_txtAPBillOfLadingEnviromentTaxPercent
            // 
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSComment = "";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSDataMember = "APBillOfLadingEnviromentTaxPercent";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSDescription = null;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSError = null;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.EditValue = "";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Location = new System.Drawing.Point(116, 98);
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Name = "fld_txtAPBillOfLadingEnviromentTaxPercent";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Screen = null;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Size = new System.Drawing.Size(59, 20);
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.TabIndex = 3;
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Tag = "DC";
            this.fld_txtAPBillOfLadingEnviromentTaxPercent.Validated += new System.EventHandler(this.fld_txtAPBillOfLadingEnviromentTaxPercent_Validated);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(21, 101);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(88, 13);
            this.bosLabel20.TabIndex = 9;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Bảo vệ môi trường";
            // 
            // fld_txtAPBillOfLadingConsumptionTaxPercent
            // 
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSComment = "";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSDataMember = "APBillOfLadingConsumptionTaxPercent";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSDescription = null;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSError = null;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.EditValue = "";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Location = new System.Drawing.Point(116, 72);
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Name = "fld_txtAPBillOfLadingConsumptionTaxPercent";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Screen = null;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Size = new System.Drawing.Size(59, 20);
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.TabIndex = 2;
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Tag = "DC";
            this.fld_txtAPBillOfLadingConsumptionTaxPercent.Validated += new System.EventHandler(this.fld_txtAPBillOfLadingConsumptionTaxPercent_Validated);
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(21, 75);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(80, 13);
            this.bosLabel19.TabIndex = 6;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Tiêu thụ đặc biệt";
            // 
            // fld_txtAPBillOfLadingImportTaxPercent
            // 
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSComment = "";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSDataMember = "APBillOfLadingImportTaxPercent";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSDescription = null;
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSError = null;
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingImportTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingImportTaxPercent.EditValue = "";
            this.fld_txtAPBillOfLadingImportTaxPercent.Location = new System.Drawing.Point(116, 20);
            this.fld_txtAPBillOfLadingImportTaxPercent.Name = "fld_txtAPBillOfLadingImportTaxPercent";
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingImportTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingImportTaxPercent.Screen = null;
            this.fld_txtAPBillOfLadingImportTaxPercent.Size = new System.Drawing.Size(59, 20);
            this.fld_txtAPBillOfLadingImportTaxPercent.TabIndex = 0;
            this.fld_txtAPBillOfLadingImportTaxPercent.Tag = "DC";
            this.fld_txtAPBillOfLadingImportTaxPercent.Validated += new System.EventHandler(this.fld_txtAPBillOfLadingImportTaxPercent_Validated);
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(12, 249);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(903, 388);
            this.bosTabControl1.TabIndex = 41;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPBillOfLadingItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(901, 363);
            this.xtraTabPage1.Text = "Chi tiết";
            // 
            // fld_dgcAPBillOfLadingItems
            // 
            this.fld_dgcAPBillOfLadingItems.AllowDrop = true;
            this.fld_dgcAPBillOfLadingItems.BOSComment = "";
            this.fld_dgcAPBillOfLadingItems.BOSDataMember = "";
            this.fld_dgcAPBillOfLadingItems.BOSDataSource = "APBillOfLadingItems";
            this.fld_dgcAPBillOfLadingItems.BOSDescription = null;
            this.fld_dgcAPBillOfLadingItems.BOSError = null;
            this.fld_dgcAPBillOfLadingItems.BOSFieldGroup = "";
            this.fld_dgcAPBillOfLadingItems.BOSFieldRelation = "";
            this.fld_dgcAPBillOfLadingItems.BOSGridType = null;
            this.fld_dgcAPBillOfLadingItems.BOSPrivilege = "";
            this.fld_dgcAPBillOfLadingItems.BOSPropertyName = "";
            this.fld_dgcAPBillOfLadingItems.CommodityType = "";
            this.fld_dgcAPBillOfLadingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPBillOfLadingItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPBillOfLadingItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPBillOfLadingItems.MainView = this.gridView1;
            this.fld_dgcAPBillOfLadingItems.Name = "fld_dgcAPBillOfLadingItems";
            this.fld_dgcAPBillOfLadingItems.PrintReport = false;
            this.fld_dgcAPBillOfLadingItems.Screen = null;
            this.fld_dgcAPBillOfLadingItems.Size = new System.Drawing.Size(901, 363);
            this.fld_dgcAPBillOfLadingItems.TabIndex = 0;
            this.fld_dgcAPBillOfLadingItems.Tag = "DC";
            this.fld_dgcAPBillOfLadingItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPBillOfLadingItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(887, 356);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(887, 356);
            this.fld_dgcACDocumentEntrys.TabIndex = 2;
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
            // fld_lkeFK_GEPaymentTermID
            // 
            this.fld_lkeFK_GEPaymentTermID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEPaymentTermID.BOSAllowDummy = false;
            this.fld_lkeFK_GEPaymentTermID.BOSComment = null;
            this.fld_lkeFK_GEPaymentTermID.BOSDataMember = "FK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.BOSDataSource = "APBillOfLadings";
            this.fld_lkeFK_GEPaymentTermID.BOSDescription = null;
            this.fld_lkeFK_GEPaymentTermID.BOSError = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldGroup = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldParent = null;
            this.fld_lkeFK_GEPaymentTermID.BOSFieldRelation = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPrivilege = null;
            this.fld_lkeFK_GEPaymentTermID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEPaymentTermID.BOSSelectType = null;
            this.fld_lkeFK_GEPaymentTermID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GEPaymentTermID.CurrentDisplayText = null;
            this.fld_lkeFK_GEPaymentTermID.Location = new System.Drawing.Point(394, 194);
            this.fld_lkeFK_GEPaymentTermID.Name = "fld_lkeFK_GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEPaymentTermID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEPaymentTermID.Properties.ColumnName = null;
            this.fld_lkeFK_GEPaymentTermID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEPaymentTermName", "Điều khoản thanh toán", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEPaymentTermID.Properties.DisplayMember = "GEPaymentTermName";
            this.fld_lkeFK_GEPaymentTermID.Properties.NullText = "";
            this.fld_lkeFK_GEPaymentTermID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEPaymentTermID.Properties.ValueMember = "GEPaymentTermID";
            this.fld_lkeFK_GEPaymentTermID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GEPaymentTermID, true);
            this.fld_lkeFK_GEPaymentTermID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_GEPaymentTermID.TabIndex = 19;
            this.fld_lkeFK_GEPaymentTermID.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = "";
            this.bosLabel17.Location = new System.Drawing.Point(17, 197);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(40, 13);
            this.bosLabel17.TabIndex = 36;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Diễn giải";
            // 
            // fld_medAPBillOfLadingDesc
            // 
            this.fld_medAPBillOfLadingDesc.BOSComment = "";
            this.fld_medAPBillOfLadingDesc.BOSDataMember = "APBillOfLadingDesc";
            this.fld_medAPBillOfLadingDesc.BOSDataSource = "APBillOfLadings";
            this.fld_medAPBillOfLadingDesc.BOSDescription = null;
            this.fld_medAPBillOfLadingDesc.BOSError = null;
            this.fld_medAPBillOfLadingDesc.BOSFieldGroup = "";
            this.fld_medAPBillOfLadingDesc.BOSFieldRelation = "";
            this.fld_medAPBillOfLadingDesc.BOSPrivilege = "";
            this.fld_medAPBillOfLadingDesc.BOSPropertyName = "Text";
            this.fld_medAPBillOfLadingDesc.EditValue = "";
            this.fld_medAPBillOfLadingDesc.Location = new System.Drawing.Point(103, 194);
            this.fld_medAPBillOfLadingDesc.Name = "fld_medAPBillOfLadingDesc";
            this.fld_medAPBillOfLadingDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medAPBillOfLadingDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medAPBillOfLadingDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medAPBillOfLadingDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medAPBillOfLadingDesc.Screen = null;
            this.fld_medAPBillOfLadingDesc.Size = new System.Drawing.Size(133, 46);
            this.fld_medAPBillOfLadingDesc.TabIndex = 18;
            this.fld_medAPBillOfLadingDesc.Tag = "DC";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 665;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "";
            this.fld_Lablel2.BOSDataMember = "";
            this.fld_Lablel2.BOSDataSource = "";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "";
            this.fld_Lablel2.BOSFieldRelation = "";
            this.fld_Lablel2.BOSPrivilege = "";
            this.fld_Lablel2.BOSPropertyName = "";
            this.fld_Lablel2.Location = new System.Drawing.Point(560, 93);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 22;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lkeAPBillOfLadingStatus
            // 
            this.fld_lkeAPBillOfLadingStatus.BOSAllowAddNew = false;
            this.fld_lkeAPBillOfLadingStatus.BOSAllowDummy = false;
            this.fld_lkeAPBillOfLadingStatus.BOSComment = null;
            this.fld_lkeAPBillOfLadingStatus.BOSDataMember = "APBillOfLadingStatus";
            this.fld_lkeAPBillOfLadingStatus.BOSDataSource = "APBillOfLadings";
            this.fld_lkeAPBillOfLadingStatus.BOSDescription = null;
            this.fld_lkeAPBillOfLadingStatus.BOSError = null;
            this.fld_lkeAPBillOfLadingStatus.BOSFieldGroup = null;
            this.fld_lkeAPBillOfLadingStatus.BOSFieldParent = null;
            this.fld_lkeAPBillOfLadingStatus.BOSFieldRelation = null;
            this.fld_lkeAPBillOfLadingStatus.BOSPrivilege = null;
            this.fld_lkeAPBillOfLadingStatus.BOSPropertyName = "EditValue";
            this.fld_lkeAPBillOfLadingStatus.BOSSelectType = null;
            this.fld_lkeAPBillOfLadingStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPBillOfLadingStatus.CurrentDisplayText = null;
            this.fld_lkeAPBillOfLadingStatus.Location = new System.Drawing.Point(647, 90);
            this.fld_lkeAPBillOfLadingStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPBillOfLadingStatus.Name = "fld_lkeAPBillOfLadingStatus";
            this.fld_lkeAPBillOfLadingStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPBillOfLadingStatus.Properties.ColumnName = null;
            this.fld_lkeAPBillOfLadingStatus.Properties.NullText = "";
            this.fld_lkeAPBillOfLadingStatus.Properties.ReadOnly = true;
            this.fld_lkeAPBillOfLadingStatus.Screen = null;
            this.fld_lkeAPBillOfLadingStatus.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeAPBillOfLadingStatus.TabIndex = 11;
            this.fld_lkeAPBillOfLadingStatus.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(560, 41);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(29, 13);
            this.bosLabel16.TabIndex = 10;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Tỷ giá";
            // 
            // fld_txtAPBillOfLadingExchangeRate
            // 
            this.fld_txtAPBillOfLadingExchangeRate.BOSComment = "";
            this.fld_txtAPBillOfLadingExchangeRate.BOSDataMember = "APBillOfLadingExchangeRate";
            this.fld_txtAPBillOfLadingExchangeRate.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingExchangeRate.BOSDescription = null;
            this.fld_txtAPBillOfLadingExchangeRate.BOSError = null;
            this.fld_txtAPBillOfLadingExchangeRate.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingExchangeRate.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingExchangeRate.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingExchangeRate.EditValue = "";
            this.fld_txtAPBillOfLadingExchangeRate.Location = new System.Drawing.Point(647, 38);
            this.fld_txtAPBillOfLadingExchangeRate.Name = "fld_txtAPBillOfLadingExchangeRate";
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingExchangeRate.Screen = null;
            this.fld_txtAPBillOfLadingExchangeRate.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingExchangeRate.TabIndex = 5;
            this.fld_txtAPBillOfLadingExchangeRate.Tag = "DC";
            this.fld_txtAPBillOfLadingExchangeRate.Validated += new System.EventHandler(this.fld_txtAPBillOfLadingExchangeRate_Validated);
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APBillOfLadings";
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
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(647, 12);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.ReadOnly = true;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 2;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(561, 15);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(53, 13);
            this.bosLabel15.TabIndex = 4;
            this.bosLabel15.Text = "Loại tiền tệ";
            // 
            // bosLabel33
            // 
            this.bosLabel33.BOSComment = null;
            this.bosLabel33.BOSDataMember = null;
            this.bosLabel33.BOSDataSource = null;
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = null;
            this.bosLabel33.BOSFieldRelation = null;
            this.bosLabel33.BOSPrivilege = null;
            this.bosLabel33.BOSPropertyName = null;
            this.bosLabel33.Location = new System.Drawing.Point(282, 197);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel33, true);
            this.bosLabel33.Size = new System.Drawing.Size(26, 13);
            this.bosLabel33.TabIndex = 38;
            this.bosLabel33.Text = "ĐKTT";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(282, 145);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(67, 13);
            this.bosLabel10.TabIndex = 30;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Ngày hóa đơn";
            // 
            // fld_dteAPBillOfLadingVATDate
            // 
            this.fld_dteAPBillOfLadingVATDate.BOSComment = "";
            this.fld_dteAPBillOfLadingVATDate.BOSDataMember = "APBillOfLadingVATDate";
            this.fld_dteAPBillOfLadingVATDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingVATDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingVATDate.BOSError = null;
            this.fld_dteAPBillOfLadingVATDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingVATDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingVATDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingVATDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingVATDate.EditValue = null;
            this.fld_dteAPBillOfLadingVATDate.Location = new System.Drawing.Point(394, 142);
            this.fld_dteAPBillOfLadingVATDate.Name = "fld_dteAPBillOfLadingVATDate";
            this.fld_dteAPBillOfLadingVATDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingVATDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingVATDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingVATDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingVATDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingVATDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingVATDate.Properties.ReadOnly = true;
            this.fld_dteAPBillOfLadingVATDate.Screen = null;
            this.fld_dteAPBillOfLadingVATDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingVATDate.TabIndex = 15;
            this.fld_dteAPBillOfLadingVATDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(282, 119);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(97, 13);
            this.bosLabel9.TabIndex = 26;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Hóa đơn thương mại";
            // 
            // fld_txtAPBillOfLadingSupplierNo
            // 
            this.fld_txtAPBillOfLadingSupplierNo.BOSComment = "";
            this.fld_txtAPBillOfLadingSupplierNo.BOSDataMember = "APBillOfLadingSupplierNo";
            this.fld_txtAPBillOfLadingSupplierNo.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingSupplierNo.BOSDescription = null;
            this.fld_txtAPBillOfLadingSupplierNo.BOSError = null;
            this.fld_txtAPBillOfLadingSupplierNo.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingSupplierNo.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingSupplierNo.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingSupplierNo.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingSupplierNo.EditValue = "";
            this.fld_txtAPBillOfLadingSupplierNo.Location = new System.Drawing.Point(394, 116);
            this.fld_txtAPBillOfLadingSupplierNo.Name = "fld_txtAPBillOfLadingSupplierNo";
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingSupplierNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingSupplierNo.Properties.ReadOnly = true;
            this.fld_txtAPBillOfLadingSupplierNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingSupplierNo.Screen = null;
            this.fld_txtAPBillOfLadingSupplierNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingSupplierNo.TabIndex = 13;
            this.fld_txtAPBillOfLadingSupplierNo.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(282, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(53, 13);
            this.bosLabel8.TabIndex = 20;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Mã số thuế";
            // 
            // fld_txtAPBillOfLadingTaxNumber
            // 
            this.fld_txtAPBillOfLadingTaxNumber.BOSComment = "";
            this.fld_txtAPBillOfLadingTaxNumber.BOSDataMember = "APBillOfLadingTaxNumber";
            this.fld_txtAPBillOfLadingTaxNumber.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingTaxNumber.BOSDescription = null;
            this.fld_txtAPBillOfLadingTaxNumber.BOSError = null;
            this.fld_txtAPBillOfLadingTaxNumber.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingTaxNumber.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingTaxNumber.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingTaxNumber.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingTaxNumber.EditValue = "";
            this.fld_txtAPBillOfLadingTaxNumber.Location = new System.Drawing.Point(394, 90);
            this.fld_txtAPBillOfLadingTaxNumber.Name = "fld_txtAPBillOfLadingTaxNumber";
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingTaxNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingTaxNumber.Properties.ReadOnly = true;
            this.fld_txtAPBillOfLadingTaxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingTaxNumber.Screen = null;
            this.fld_txtAPBillOfLadingTaxNumber.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingTaxNumber.TabIndex = 10;
            this.fld_txtAPBillOfLadingTaxNumber.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(282, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 2;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(282, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(67, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Ngày vận đơn";
            // 
            // fld_dteAPBillOfLadingDate
            // 
            this.fld_dteAPBillOfLadingDate.BOSComment = "";
            this.fld_dteAPBillOfLadingDate.BOSDataMember = "APBillOfLadingDate";
            this.fld_dteAPBillOfLadingDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingDate.BOSError = null;
            this.fld_dteAPBillOfLadingDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingDate.EditValue = null;
            this.fld_dteAPBillOfLadingDate.Location = new System.Drawing.Point(394, 12);
            this.fld_dteAPBillOfLadingDate.Name = "fld_dteAPBillOfLadingDate";
            this.fld_dteAPBillOfLadingDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingDate.Screen = null;
            this.fld_dteAPBillOfLadingDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingDate.TabIndex = 1;
            this.fld_dteAPBillOfLadingDate.Tag = "DC";
            // 
            // fld_dteAPBillOfLadingBOLDate
            // 
            this.fld_dteAPBillOfLadingBOLDate.BOSComment = "";
            this.fld_dteAPBillOfLadingBOLDate.BOSDataMember = "APBillOfLadingBOLDate";
            this.fld_dteAPBillOfLadingBOLDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingBOLDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingBOLDate.BOSError = null;
            this.fld_dteAPBillOfLadingBOLDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingBOLDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingBOLDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingBOLDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingBOLDate.EditValue = null;
            this.fld_dteAPBillOfLadingBOLDate.Location = new System.Drawing.Point(394, 64);
            this.fld_dteAPBillOfLadingBOLDate.Name = "fld_dteAPBillOfLadingBOLDate";
            this.fld_dteAPBillOfLadingBOLDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingBOLDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingBOLDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingBOLDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingBOLDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingBOLDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingBOLDate.Screen = null;
            this.fld_dteAPBillOfLadingBOLDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingBOLDate.TabIndex = 7;
            this.fld_dteAPBillOfLadingBOLDate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(282, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 8;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Vận đơn số";
            // 
            // fld_txtAPBillOfLadingNo1
            // 
            this.fld_txtAPBillOfLadingNo1.BOSComment = "";
            this.fld_txtAPBillOfLadingNo1.BOSDataMember = "APBillOfLadingDeclarationNo";
            this.fld_txtAPBillOfLadingNo1.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingNo1.BOSDescription = null;
            this.fld_txtAPBillOfLadingNo1.BOSError = null;
            this.fld_txtAPBillOfLadingNo1.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingNo1.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingNo1.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingNo1.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingNo1.EditValue = "";
            this.fld_txtAPBillOfLadingNo1.Location = new System.Drawing.Point(394, 38);
            this.fld_txtAPBillOfLadingNo1.Name = "fld_txtAPBillOfLadingNo1";
            this.fld_txtAPBillOfLadingNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingNo1.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingNo1.Screen = null;
            this.fld_txtAPBillOfLadingNo1.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingNo1.TabIndex = 4;
            this.fld_txtAPBillOfLadingNo1.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(17, 171);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(73, 13);
            this.bosLabel3.TabIndex = 32;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Ngày hợp đồng";
            // 
            // fld_dteAPBillOfLadingContractDate
            // 
            this.fld_dteAPBillOfLadingContractDate.BOSComment = "";
            this.fld_dteAPBillOfLadingContractDate.BOSDataMember = "APBillOfLadingContractDate";
            this.fld_dteAPBillOfLadingContractDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingContractDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingContractDate.BOSError = null;
            this.fld_dteAPBillOfLadingContractDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingContractDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingContractDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingContractDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingContractDate.EditValue = null;
            this.fld_dteAPBillOfLadingContractDate.Enabled = false;
            this.fld_dteAPBillOfLadingContractDate.Location = new System.Drawing.Point(103, 168);
            this.fld_dteAPBillOfLadingContractDate.Name = "fld_dteAPBillOfLadingContractDate";
            this.fld_dteAPBillOfLadingContractDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingContractDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingContractDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingContractDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingContractDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingContractDate.Properties.ReadOnly = true;
            this.fld_dteAPBillOfLadingContractDate.Screen = null;
            this.fld_dteAPBillOfLadingContractDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingContractDate.TabIndex = 16;
            this.fld_dteAPBillOfLadingContractDate.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(17, 145);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 28;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Hợp đồng";
            // 
            // fld_txtAPBillOfLadingContractNo
            // 
            this.fld_txtAPBillOfLadingContractNo.BOSComment = "";
            this.fld_txtAPBillOfLadingContractNo.BOSDataMember = "APBillOfLadingContractNo";
            this.fld_txtAPBillOfLadingContractNo.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingContractNo.BOSDescription = null;
            this.fld_txtAPBillOfLadingContractNo.BOSError = null;
            this.fld_txtAPBillOfLadingContractNo.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingContractNo.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingContractNo.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingContractNo.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingContractNo.EditValue = "";
            this.fld_txtAPBillOfLadingContractNo.Enabled = false;
            this.fld_txtAPBillOfLadingContractNo.Location = new System.Drawing.Point(103, 142);
            this.fld_txtAPBillOfLadingContractNo.Name = "fld_txtAPBillOfLadingContractNo";
            this.fld_txtAPBillOfLadingContractNo.Properties.AllowFocused = false;
            this.fld_txtAPBillOfLadingContractNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingContractNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingContractNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingContractNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingContractNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingContractNo.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtAPBillOfLadingContractNo.Properties.ReadOnly = true;
            this.fld_txtAPBillOfLadingContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingContractNo.Screen = null;
            this.fld_txtAPBillOfLadingContractNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingContractNo.TabIndex = 14;
            this.fld_txtAPBillOfLadingContractNo.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = null;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APBillOfLadings";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(103, 116);
            this.fld_lkeFK_ACObjectID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 12;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(561, 67);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 16;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Loại chứng từ";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = null;
            this.bosLabel35.BOSDataMember = "";
            this.bosLabel35.BOSDataSource = "";
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = "";
            this.bosLabel35.BOSFieldRelation = null;
            this.bosLabel35.BOSPrivilege = null;
            this.bosLabel35.BOSPropertyName = null;
            this.bosLabel35.Location = new System.Drawing.Point(17, 119);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(70, 13);
            this.bosLabel35.TabIndex = 24;
            this.bosLabel35.Text = "Đối tượng XNK";
            // 
            // fld_lblType
            // 
            this.fld_lblType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblType.Appearance.Options.UseBackColor = true;
            this.fld_lblType.Appearance.Options.UseForeColor = true;
            this.fld_lblType.BOSComment = "";
            this.fld_lblType.BOSDataMember = "";
            this.fld_lblType.BOSDataSource = "";
            this.fld_lblType.BOSDescription = null;
            this.fld_lblType.BOSError = null;
            this.fld_lblType.BOSFieldGroup = "";
            this.fld_lblType.BOSFieldRelation = "";
            this.fld_lblType.BOSPrivilege = "";
            this.fld_lblType.BOSPropertyName = null;
            this.fld_lblType.Location = new System.Drawing.Point(17, 93);
            this.fld_lblType.Name = "fld_lblType";
            this.fld_lblType.Screen = null;
            this.fld_lblType.Size = new System.Drawing.Size(42, 13);
            this.fld_lblType.TabIndex = 18;
            this.fld_lblType.Tag = "";
            this.fld_lblType.Text = "Loại hình";
            // 
            // bosLabel27
            // 
            this.bosLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel27.Appearance.Options.UseBackColor = true;
            this.bosLabel27.Appearance.Options.UseForeColor = true;
            this.bosLabel27.BOSComment = "";
            this.bosLabel27.BOSDataMember = "";
            this.bosLabel27.BOSDataSource = "";
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = "";
            this.bosLabel27.BOSFieldRelation = "";
            this.bosLabel27.BOSPrivilege = "";
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(17, 67);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(66, 13);
            this.bosLabel27.TabIndex = 12;
            this.bosLabel27.Tag = "";
            this.bosLabel27.Text = "Ngày đăng ký";
            // 
            // fld_dteAPBillOfLadingRegisDate
            // 
            this.fld_dteAPBillOfLadingRegisDate.BOSComment = "";
            this.fld_dteAPBillOfLadingRegisDate.BOSDataMember = "APBillOfLadingRegisDate";
            this.fld_dteAPBillOfLadingRegisDate.BOSDataSource = "APBillOfLadings";
            this.fld_dteAPBillOfLadingRegisDate.BOSDescription = null;
            this.fld_dteAPBillOfLadingRegisDate.BOSError = null;
            this.fld_dteAPBillOfLadingRegisDate.BOSFieldGroup = "";
            this.fld_dteAPBillOfLadingRegisDate.BOSFieldRelation = "";
            this.fld_dteAPBillOfLadingRegisDate.BOSPrivilege = "";
            this.fld_dteAPBillOfLadingRegisDate.BOSPropertyName = "EditValue";
            this.fld_dteAPBillOfLadingRegisDate.EditValue = null;
            this.fld_dteAPBillOfLadingRegisDate.Location = new System.Drawing.Point(103, 64);
            this.fld_dteAPBillOfLadingRegisDate.Name = "fld_dteAPBillOfLadingRegisDate";
            this.fld_dteAPBillOfLadingRegisDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPBillOfLadingRegisDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPBillOfLadingRegisDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPBillOfLadingRegisDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPBillOfLadingRegisDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPBillOfLadingRegisDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPBillOfLadingRegisDate.Screen = null;
            this.fld_dteAPBillOfLadingRegisDate.Size = new System.Drawing.Size(133, 20);
            this.fld_dteAPBillOfLadingRegisDate.TabIndex = 6;
            this.fld_dteAPBillOfLadingRegisDate.Tag = "DC";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = "";
            this.bosLabel26.BOSDataMember = "";
            this.bosLabel26.BOSDataSource = "";
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = "";
            this.bosLabel26.BOSFieldRelation = "";
            this.bosLabel26.BOSPrivilege = "";
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(17, 41);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(47, 13);
            this.bosLabel26.TabIndex = 6;
            this.bosLabel26.Tag = "";
            this.bosLabel26.Text = "Số tờ khai";
            // 
            // fld_txtAPBillOfLadingDeclarationNumber
            // 
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSComment = "";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSDataMember = "APBillOfLadingDeclarationNumber";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSDescription = null;
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSError = null;
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingDeclarationNumber.BOSPropertyName = "EditValue";
            this.fld_txtAPBillOfLadingDeclarationNumber.EditValue = "";
            this.fld_txtAPBillOfLadingDeclarationNumber.Location = new System.Drawing.Point(103, 38);
            this.fld_txtAPBillOfLadingDeclarationNumber.Name = "fld_txtAPBillOfLadingDeclarationNumber";
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Mask.EditMask = "n";
            this.fld_txtAPBillOfLadingDeclarationNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingDeclarationNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingDeclarationNumber.Screen = null;
            this.fld_txtAPBillOfLadingDeclarationNumber.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingDeclarationNumber.TabIndex = 3;
            this.fld_txtAPBillOfLadingDeclarationNumber.Tag = "DC";
            // 
            // fld_txtAPBillOfLadingNo
            // 
            this.fld_txtAPBillOfLadingNo.BOSComment = "";
            this.fld_txtAPBillOfLadingNo.BOSDataMember = "APBillOfLadingNo";
            this.fld_txtAPBillOfLadingNo.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingNo.BOSDescription = null;
            this.fld_txtAPBillOfLadingNo.BOSError = null;
            this.fld_txtAPBillOfLadingNo.BOSFieldGroup = "";
            this.fld_txtAPBillOfLadingNo.BOSFieldRelation = "";
            this.fld_txtAPBillOfLadingNo.BOSPrivilege = "";
            this.fld_txtAPBillOfLadingNo.BOSPropertyName = "Text";
            this.fld_txtAPBillOfLadingNo.EditValue = "";
            this.fld_txtAPBillOfLadingNo.Location = new System.Drawing.Point(103, 12);
            this.fld_txtAPBillOfLadingNo.Name = "fld_txtAPBillOfLadingNo";
            this.fld_txtAPBillOfLadingNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingNo.Screen = null;
            this.fld_txtAPBillOfLadingNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtAPBillOfLadingNo.TabIndex = 0;
            this.fld_txtAPBillOfLadingNo.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(17, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // DMBOL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(918, 640);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBOL100.IconOptions.Icon")));
            this.Name = "DMBOL100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingImportExportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingClearanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingClearanceDate.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingVATTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingEnviromentTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingConsumptionTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingImportTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPBillOfLadingItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEPaymentTermID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medAPBillOfLadingDesc.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPBillOfLadingStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingVATDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingVATDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingSupplierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingTaxNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingBOLDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingBOLDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingContractDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingRegisDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPBillOfLadingRegisDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingDeclarationNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingDeclarationNumber;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingRegisDate;
        private BOSComponent.BOSLabel fld_lblType;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingContractDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingContractNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingNo1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingVATDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingSupplierNo;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingTaxNumber;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingBOLDate;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLookupEdit fld_lkeAPBillOfLadingStatus;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSMemoEdit fld_medAPBillOfLadingDesc;
        private BOSERP.Modules.BillOfLading.APBillOfLadingItemsGridControl fld_dgcAPBillOfLadingItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEPaymentTermID;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingVATTaxPercent;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingEnviromentTaxPercent;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingConsumptionTaxPercent;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingImportTaxPercent;

        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingClearanceDate;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLookupEdit fld_lkeAPBillOfLadingType;
        private BOSComponent.BOSLookupEdit fld_lkeAPBillOfLadingImportExportType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteAPBillOfLadingDate;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingReference;



        //private BOSComponent.BOSLabel bosLabel18;



        //private BOSComponent.BOSLabel bosLabel18;
    }
}

