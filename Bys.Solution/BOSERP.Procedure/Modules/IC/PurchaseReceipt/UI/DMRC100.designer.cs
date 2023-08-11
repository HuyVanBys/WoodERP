using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseReceipt.UI
{
	/// <summary>
	/// Summary description for DMRC100
	/// </summary>
	partial class DMRC100
    {
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSLabel fld_Lablel2;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRC100));
            this.fld_rdgReceiptType = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptInvoiceInNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptPackNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICReceiptInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptDeliveryContactName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptShippingFee = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptShippingExtraFee = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptProportion = new BOSComponent.BOSTextBox(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_panelProduct = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnGroupPackage = new BOSComponent.BOSButton(this.components);
            this.btnGenPackage = new BOSComponent.BOSButton(this.components);
            this.fld_btnZoomProduct = new BOSComponent.BOSButton(this.components);
            this.fld_btnShowPurchaseOrderItems = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptItems = new BOSERP.Modules.PurchaseReceipt.ICReceiptItemsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICReceiptItemProductPicture1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.fld_tabpageConts = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICReceiptItemConts = new BOSERP.Modules.PurchaseReceipt.ICReceiptItemContsGridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICReceiptItemContFees = new BOSERP.Modules.PurchaseReceipt.ICReceiptItemContFeesGridControl();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeICReceiptReceiptType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GETerminalID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductAttributeWoodTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICReceiptPurposeType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit7 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lkeFK_ACAssObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medICReceiptComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnClearPackage = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgReceiptType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptProportion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).BeginInit();
            this.fld_panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            this.fld_tabpageConts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptItemConts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemContFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptReceiptType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptPurposeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_rdgReceiptType
            // 
            this.fld_rdgReceiptType.BOSComment = null;
            this.fld_rdgReceiptType.BOSDataMember = "";
            this.fld_rdgReceiptType.BOSDataSource = "";
            this.fld_rdgReceiptType.BOSDescription = null;
            this.fld_rdgReceiptType.BOSError = null;
            this.fld_rdgReceiptType.BOSFieldGroup = null;
            this.fld_rdgReceiptType.BOSFieldRelation = null;
            this.fld_rdgReceiptType.BOSPrivilege = null;
            this.fld_rdgReceiptType.BOSPropertyName = null;
            this.fld_rdgReceiptType.Location = new System.Drawing.Point(377, 614);
            this.fld_rdgReceiptType.MenuManager = this.screenToolbar;
            this.fld_rdgReceiptType.Name = "fld_rdgReceiptType";
            this.fld_rdgReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_rdgReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_rdgReceiptType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Nhập kho theo thành phẩm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Nhập kho theo kiện")});
            this.fld_rdgReceiptType.Screen = null;
            this.fld_rdgReceiptType.Size = new System.Drawing.Size(444, 29);
            this.fld_rdgReceiptType.TabIndex = 0;
            this.fld_rdgReceiptType.Tag = "DC";
            this.fld_rdgReceiptType.Visible = false;
            this.fld_rdgReceiptType.SelectedIndexChanged += new System.EventHandler(this.fld_rdgReceiptType_SelectedIndexChanged);
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 16;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            this.fld_lkeFK_HREmployeeID.Validated += new System.EventHandler(this.fld_lkeFK_HREmployeeID_Validated);
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICReceiptEmployeePicture.FileName = null;
            this.fld_pteICReceiptEmployeePicture.FilePath = null;
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 0;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(661, 15);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = null;
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = null;
            this.fld_lblLabel7.BOSPrivilege = null;
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(127, 41);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 481;
            this.fld_lblLabel7.Text = "Nhà cung cấp";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = "";
            this.fld_Lablel3.BOSDataSource = "";
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = "";
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(127, 68);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 482;
            this.fld_Lablel3.Text = "Kho";
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICReceiptDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(215, 146);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(430, 46);
            this.fld_medICReceiptDesc.TabIndex = 10;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICStockID1.BOSDescription = null;
            this.fld_lkeFK_ICStockID1.BOSError = "";
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(215, 65);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = "";
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 2;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            this.fld_lkeFK_ICStockID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID1_CloseUp);
            // 
            // fld_dteICReceiptDate
            // 
            this.fld_dteICReceiptDate.BOSComment = null;
            this.fld_dteICReceiptDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate.BOSDescription = null;
            this.fld_dteICReceiptDate.BOSError = null;
            this.fld_dteICReceiptDate.BOSFieldGroup = null;
            this.fld_dteICReceiptDate.BOSFieldRelation = null;
            this.fld_dteICReceiptDate.BOSPrivilege = null;
            this.fld_dteICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate.EditValue = null;
            this.fld_dteICReceiptDate.Location = new System.Drawing.Point(495, 12);
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptDate.TabIndex = 5;
            this.fld_dteICReceiptDate.Tag = "DC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(397, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 508;
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(127, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 510;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = null;
            this.fld_txtICReceiptNo.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = null;
            this.fld_txtICReceiptNo.BOSFieldRelation = null;
            this.fld_txtICReceiptNo.BOSPrivilege = null;
            this.fld_txtICReceiptNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(215, 12);
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptNo.TabIndex = 0;
            this.fld_txtICReceiptNo.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(397, 42);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(80, 13);
            this.bosLabel6.TabIndex = 518;
            this.bosLabel6.Text = "Mã hóa đơn NCC";
            // 
            // fld_txtICReceiptInvoiceInNo
            // 
            this.fld_txtICReceiptInvoiceInNo.BOSComment = null;
            this.fld_txtICReceiptInvoiceInNo.BOSDataMember = "ICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptInvoiceInNo.BOSDescription = null;
            this.fld_txtICReceiptInvoiceInNo.BOSError = null;
            this.fld_txtICReceiptInvoiceInNo.BOSFieldGroup = null;
            this.fld_txtICReceiptInvoiceInNo.BOSFieldRelation = null;
            this.fld_txtICReceiptInvoiceInNo.BOSPrivilege = null;
            this.fld_txtICReceiptInvoiceInNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptInvoiceInNo.Location = new System.Drawing.Point(495, 38);
            this.fld_txtICReceiptInvoiceInNo.Name = "fld_txtICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptInvoiceInNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptInvoiceInNo.Screen = null;
            this.fld_txtICReceiptInvoiceInNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptInvoiceInNo.TabIndex = 6;
            this.fld_txtICReceiptInvoiceInNo.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(397, 68);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 526;
            this.bosLabel10.Text = "Mã lô hàng";
            // 
            // fld_txtICReceiptPackNo
            // 
            this.fld_txtICReceiptPackNo.BOSComment = null;
            this.fld_txtICReceiptPackNo.BOSDataMember = "ICReceiptPackNo";
            this.fld_txtICReceiptPackNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptPackNo.BOSDescription = null;
            this.fld_txtICReceiptPackNo.BOSError = null;
            this.fld_txtICReceiptPackNo.BOSFieldGroup = null;
            this.fld_txtICReceiptPackNo.BOSFieldRelation = null;
            this.fld_txtICReceiptPackNo.BOSPrivilege = null;
            this.fld_txtICReceiptPackNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptPackNo.Location = new System.Drawing.Point(495, 65);
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptPackNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptPackNo.Screen = null;
            this.fld_txtICReceiptPackNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptPackNo.TabIndex = 7;
            this.fld_txtICReceiptPackNo.Tag = "DC";
            this.fld_txtICReceiptPackNo.Validated += new System.EventHandler(this.fld_txtICReceiptPackNo_Validated);
            // 
            // fld_lkeICReceiptStatus
            // 
            this.fld_lkeICReceiptStatus.BOSAllowAddNew = false;
            this.fld_lkeICReceiptStatus.BOSAllowDummy = false;
            this.fld_lkeICReceiptStatus.BOSComment = null;
            this.fld_lkeICReceiptStatus.BOSDataMember = "ICReceiptStatus";
            this.fld_lkeICReceiptStatus.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptStatus.BOSDescription = null;
            this.fld_lkeICReceiptStatus.BOSError = null;
            this.fld_lkeICReceiptStatus.BOSFieldGroup = null;
            this.fld_lkeICReceiptStatus.BOSFieldParent = null;
            this.fld_lkeICReceiptStatus.BOSFieldRelation = null;
            this.fld_lkeICReceiptStatus.BOSPrivilege = null;
            this.fld_lkeICReceiptStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptStatus.BOSSelectType = null;
            this.fld_lkeICReceiptStatus.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptStatus.CurrentDisplayText = null;
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(754, 13);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ColumnName = null;
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 11;
            this.fld_lkeICReceiptStatus.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(661, 42);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(67, 13);
            this.bosLabel3.TabIndex = 518;
            this.bosLabel3.Text = "Ngày hóa đơn";
            // 
            // fld_dteICReceiptInvoiceInDate
            // 
            this.fld_dteICReceiptInvoiceInDate.BOSComment = null;
            this.fld_dteICReceiptInvoiceInDate.BOSDataMember = "ICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptInvoiceInDate.BOSDescription = null;
            this.fld_dteICReceiptInvoiceInDate.BOSError = null;
            this.fld_dteICReceiptInvoiceInDate.BOSFieldGroup = null;
            this.fld_dteICReceiptInvoiceInDate.BOSFieldRelation = null;
            this.fld_dteICReceiptInvoiceInDate.BOSPrivilege = null;
            this.fld_dteICReceiptInvoiceInDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptInvoiceInDate.EditValue = null;
            this.fld_dteICReceiptInvoiceInDate.Location = new System.Drawing.Point(754, 39);
            this.fld_dteICReceiptInvoiceInDate.Name = "fld_dteICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptInvoiceInDate.Screen = null;
            this.fld_dteICReceiptInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptInvoiceInDate.TabIndex = 12;
            this.fld_dteICReceiptInvoiceInDate.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(397, 94);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(78, 13);
            this.bosLabel4.TabIndex = 528;
            this.bosLabel4.Text = "Người giao hàng";
            // 
            // fld_txtICReceiptDeliveryContactName
            // 
            this.fld_txtICReceiptDeliveryContactName.BOSComment = null;
            this.fld_txtICReceiptDeliveryContactName.BOSDataMember = "ICReceiptDeliveryContactName";
            this.fld_txtICReceiptDeliveryContactName.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDeliveryContactName.BOSDescription = null;
            this.fld_txtICReceiptDeliveryContactName.BOSError = null;
            this.fld_txtICReceiptDeliveryContactName.BOSFieldGroup = null;
            this.fld_txtICReceiptDeliveryContactName.BOSFieldRelation = null;
            this.fld_txtICReceiptDeliveryContactName.BOSPrivilege = null;
            this.fld_txtICReceiptDeliveryContactName.BOSPropertyName = "Text";
            this.fld_txtICReceiptDeliveryContactName.Location = new System.Drawing.Point(495, 91);
            this.fld_txtICReceiptDeliveryContactName.Name = "fld_txtICReceiptDeliveryContactName";
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDeliveryContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDeliveryContactName.Screen = null;
            this.fld_txtICReceiptDeliveryContactName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptDeliveryContactName.TabIndex = 8;
            this.fld_txtICReceiptDeliveryContactName.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(1183, 778);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(45, 13);
            this.bosLabel5.TabIndex = 529;
            this.bosLabel5.Text = "Tổng tiền";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(1162, 906);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 529;
            this.bosLabel8.Text = "THÀNH TIỀN";
            // 
            // fld_txtICReceiptSubTotalCost
            // 
            this.fld_txtICReceiptSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptSubTotalCost.BOSComment = "";
            this.fld_txtICReceiptSubTotalCost.BOSDataMember = "ICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtICReceiptSubTotalCost.BOSError = null;
            this.fld_txtICReceiptSubTotalCost.BOSFieldGroup = "";
            this.fld_txtICReceiptSubTotalCost.BOSFieldRelation = "";
            this.fld_txtICReceiptSubTotalCost.BOSPrivilege = "";
            this.fld_txtICReceiptSubTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSubTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptSubTotalCost.Location = new System.Drawing.Point(1250, 775);
            this.fld_txtICReceiptSubTotalCost.Name = "fld_txtICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptSubTotalCost.Screen = null;
            this.fld_txtICReceiptSubTotalCost.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptSubTotalCost.TabIndex = 14;
            this.fld_txtICReceiptSubTotalCost.Tag = "DC";
            // 
            // fld_txtICReceiptTotalCost
            // 
            this.fld_txtICReceiptTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTotalCost.BOSComment = "";
            this.fld_txtICReceiptTotalCost.BOSDataMember = "ICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalCost.BOSDescription = null;
            this.fld_txtICReceiptTotalCost.BOSError = null;
            this.fld_txtICReceiptTotalCost.BOSFieldGroup = "";
            this.fld_txtICReceiptTotalCost.BOSFieldRelation = "";
            this.fld_txtICReceiptTotalCost.BOSPrivilege = "";
            this.fld_txtICReceiptTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptTotalCost.Location = new System.Drawing.Point(1250, 903);
            this.fld_txtICReceiptTotalCost.Name = "fld_txtICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTotalCost.Screen = null;
            this.fld_txtICReceiptTotalCost.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptTotalCost.TabIndex = 21;
            this.fld_txtICReceiptTotalCost.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(1155, 829);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(73, 13);
            this.bosLabel11.TabIndex = 529;
            this.bosLabel11.Text = "Phí vận chuyển";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(1189, 855);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 529;
            this.bosLabel12.Text = "Phí khác";
            // 
            // fld_txtICReceiptShippingFee
            // 
            this.fld_txtICReceiptShippingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingFee.BOSComment = "";
            this.fld_txtICReceiptShippingFee.BOSDataMember = "ICReceiptShippingFees";
            this.fld_txtICReceiptShippingFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingFee.BOSDescription = null;
            this.fld_txtICReceiptShippingFee.BOSError = null;
            this.fld_txtICReceiptShippingFee.BOSFieldGroup = "";
            this.fld_txtICReceiptShippingFee.BOSFieldRelation = "";
            this.fld_txtICReceiptShippingFee.BOSPrivilege = "";
            this.fld_txtICReceiptShippingFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingFee.Location = new System.Drawing.Point(1250, 826);
            this.fld_txtICReceiptShippingFee.Name = "fld_txtICReceiptShippingFee";
            this.fld_txtICReceiptShippingFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptShippingFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptShippingFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptShippingFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptShippingFee.Screen = null;
            this.fld_txtICReceiptShippingFee.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptShippingFee.TabIndex = 17;
            this.fld_txtICReceiptShippingFee.Tag = "DC";
            this.fld_txtICReceiptShippingFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingFees_Validated);
            // 
            // fld_txtICReceiptShippingExtraFee
            // 
            this.fld_txtICReceiptShippingExtraFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingExtraFee.BOSComment = "";
            this.fld_txtICReceiptShippingExtraFee.BOSDataMember = "ICReceiptShippingExtraFees";
            this.fld_txtICReceiptShippingExtraFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingExtraFee.BOSDescription = null;
            this.fld_txtICReceiptShippingExtraFee.BOSError = null;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldGroup = "";
            this.fld_txtICReceiptShippingExtraFee.BOSFieldRelation = "";
            this.fld_txtICReceiptShippingExtraFee.BOSPrivilege = "";
            this.fld_txtICReceiptShippingExtraFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingExtraFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingExtraFee.Location = new System.Drawing.Point(1250, 852);
            this.fld_txtICReceiptShippingExtraFee.Name = "fld_txtICReceiptShippingExtraFee";
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptShippingExtraFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptShippingExtraFee.Screen = null;
            this.fld_txtICReceiptShippingExtraFee.Size = new System.Drawing.Size(168, 20);
            this.fld_txtICReceiptShippingExtraFee.TabIndex = 18;
            this.fld_txtICReceiptShippingExtraFee.Tag = "DC";
            this.fld_txtICReceiptShippingExtraFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingExtraFees_Validated);
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
            this.bosPanel1.Controls.Add(this.bosLabel26);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLookupEdit3);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptProportion);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptReceiptType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GETerminalID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeWoodTypeID);
            this.bosPanel1.Controls.Add(this.bosLabel25);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptPurposeType);
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.bosLookupEdit7);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptContainerNo);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel29);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_rdgReceiptType);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptInvoiceInDate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptInvoiceInNo);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDiscountFix);
            this.bosPanel1.Controls.Add(this.BOSLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTotalCost);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptShippingExtraFee);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptShippingFee);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTaxAmount);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTaxPercent);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDiscountPerCent);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSubTotalCost);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDeliveryContactName);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1439, 935);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel26
            // 
            this.bosLabel26.BOSComment = null;
            this.bosLabel26.BOSDataMember = null;
            this.bosLabel26.BOSDataSource = null;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = null;
            this.bosLabel26.BOSFieldRelation = null;
            this.bosLabel26.BOSPrivilege = null;
            this.bosLabel26.BOSPropertyName = null;
            this.bosLabel26.Location = new System.Drawing.Point(918, 174);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel26, true);
            this.bosLabel26.Size = new System.Drawing.Size(94, 13);
            this.bosLabel26.TabIndex = 659;
            this.bosLabel26.Text = "Mã đơn hàng nội bộ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICReceiptSOName";
            this.bosTextBox1.BOSDataSource = "ICReceipts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Enabled = false;
            this.bosTextBox1.Location = new System.Drawing.Point(1029, 169);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 658;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "ICReceiptProposedEmployeeID";
            this.bosLookupEdit3.BOSDataSource = "ICReceipts";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(754, 171);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.bosLookupEdit3.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit3.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit3, true);
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 644;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(661, 174);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(55, 13);
            this.bosLabel18.TabIndex = 645;
            this.bosLabel18.Text = "Người nhận";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(918, 146);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(41, 13);
            this.bosLabel17.TabIndex = 618;
            this.bosLabel17.Text = "Tỷ trọng";
            // 
            // fld_txtICReceiptProportion
            // 
            this.fld_txtICReceiptProportion.BOSComment = null;
            this.fld_txtICReceiptProportion.BOSDataMember = "ICReceiptProportion";
            this.fld_txtICReceiptProportion.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptProportion.BOSDescription = null;
            this.fld_txtICReceiptProportion.BOSError = null;
            this.fld_txtICReceiptProportion.BOSFieldGroup = null;
            this.fld_txtICReceiptProportion.BOSFieldRelation = null;
            this.fld_txtICReceiptProportion.BOSPrivilege = null;
            this.fld_txtICReceiptProportion.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptProportion.Location = new System.Drawing.Point(1029, 143);
            this.fld_txtICReceiptProportion.Name = "fld_txtICReceiptProportion";
            this.fld_txtICReceiptProportion.Screen = null;
            this.fld_txtICReceiptProportion.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptProportion.TabIndex = 617;
            this.fld_txtICReceiptProportion.Tag = "DC";
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(3, 201);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(1433, 556);
            this.fld_tabReceiptItems.TabIndex = 616;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems,
            this.fld_tabpageConts,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_panelProduct);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(1431, 531);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            // 
            // fld_panelProduct
            // 
            this.fld_panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_panelProduct.Controls.Add(this.fld_btnGroupPackage);
            this.fld_panelProduct.Controls.Add(this.fld_btnClearPackage);
            this.fld_panelProduct.Controls.Add(this.btnGenPackage);
            this.fld_panelProduct.Controls.Add(this.fld_btnZoomProduct);
            this.fld_panelProduct.Controls.Add(this.fld_btnShowPurchaseOrderItems);
            this.fld_panelProduct.Controls.Add(this.fld_dgcICReceiptItems);
            this.fld_panelProduct.Controls.Add(this.bosLabel13);
            this.fld_panelProduct.Controls.Add(this.fld_pteICReceiptItemProductPicture1);
            this.fld_panelProduct.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.fld_panelProduct.Location = new System.Drawing.Point(6, 5);
            this.fld_panelProduct.Name = "fld_panelProduct";
            this.fld_panelProduct.Size = new System.Drawing.Size(1422, 516);
            this.fld_panelProduct.TabIndex = 12;
            this.fld_panelProduct.Tag = "DC";
            // 
            // fld_btnGroupPackage
            // 
            this.fld_btnGroupPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnGroupPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnGroupPackage.Appearance.Options.UseForeColor = true;
            this.fld_btnGroupPackage.BOSComment = "";
            this.fld_btnGroupPackage.BOSDataMember = "";
            this.fld_btnGroupPackage.BOSDataSource = "";
            this.fld_btnGroupPackage.BOSDescription = null;
            this.fld_btnGroupPackage.BOSError = null;
            this.fld_btnGroupPackage.BOSFieldGroup = "";
            this.fld_btnGroupPackage.BOSFieldRelation = "";
            this.fld_btnGroupPackage.BOSPrivilege = "";
            this.fld_btnGroupPackage.BOSPropertyName = "";
            this.fld_btnGroupPackage.Location = new System.Drawing.Point(1278, 247);
            this.fld_btnGroupPackage.Name = "fld_btnGroupPackage";
            this.fld_btnGroupPackage.Screen = null;
            this.fld_btnGroupPackage.Size = new System.Drawing.Size(137, 29);
            this.fld_btnGroupPackage.TabIndex = 409;
            this.fld_btnGroupPackage.Tag = "";
            this.fld_btnGroupPackage.Text = "Gộp kiện";
            this.fld_btnGroupPackage.Click += new System.EventHandler(this.fld_btnGroupPackage_Click);
            // 
            // btnGenPackage
            // 
            this.btnGenPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenPackage.Appearance.Options.UseForeColor = true;
            this.btnGenPackage.BOSComment = "";
            this.btnGenPackage.BOSDataMember = "";
            this.btnGenPackage.BOSDataSource = "";
            this.btnGenPackage.BOSDescription = null;
            this.btnGenPackage.BOSError = null;
            this.btnGenPackage.BOSFieldGroup = "";
            this.btnGenPackage.BOSFieldRelation = "";
            this.btnGenPackage.BOSPrivilege = "";
            this.btnGenPackage.BOSPropertyName = "";
            this.btnGenPackage.Location = new System.Drawing.Point(1278, 212);
            this.btnGenPackage.Name = "btnGenPackage";
            this.btnGenPackage.Screen = null;
            this.btnGenPackage.Size = new System.Drawing.Size(137, 29);
            this.btnGenPackage.TabIndex = 409;
            this.btnGenPackage.Tag = "";
            this.btnGenPackage.Text = "Tạo kiện";
            this.btnGenPackage.Click += new System.EventHandler(this.btnGenPackage_Click);
            // 
            // fld_btnZoomProduct
            // 
            this.fld_btnZoomProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnZoomProduct.BOSComment = null;
            this.fld_btnZoomProduct.BOSDataMember = null;
            this.fld_btnZoomProduct.BOSDataSource = null;
            this.fld_btnZoomProduct.BOSDescription = null;
            this.fld_btnZoomProduct.BOSError = null;
            this.fld_btnZoomProduct.BOSFieldGroup = null;
            this.fld_btnZoomProduct.BOSFieldRelation = null;
            this.fld_btnZoomProduct.BOSPrivilege = null;
            this.fld_btnZoomProduct.BOSPropertyName = null;
            this.fld_btnZoomProduct.Location = new System.Drawing.Point(1393, 5);
            this.fld_btnZoomProduct.Name = "fld_btnZoomProduct";
            this.fld_btnZoomProduct.Screen = null;
            this.fld_btnZoomProduct.Size = new System.Drawing.Size(22, 22);
            this.fld_btnZoomProduct.TabIndex = 408;
            this.fld_btnZoomProduct.Text = "❐";
            this.fld_btnZoomProduct.ToolTip = "Phóng to";
            this.fld_btnZoomProduct.Click += new System.EventHandler(this.fld_btnZoomProduct_Click);
            // 
            // fld_btnShowPurchaseOrderItems
            // 
            this.fld_btnShowPurchaseOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnShowPurchaseOrderItems.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowPurchaseOrderItems.Appearance.Options.UseForeColor = true;
            this.fld_btnShowPurchaseOrderItems.BOSComment = "";
            this.fld_btnShowPurchaseOrderItems.BOSDataMember = "";
            this.fld_btnShowPurchaseOrderItems.BOSDataSource = "";
            this.fld_btnShowPurchaseOrderItems.BOSDescription = null;
            this.fld_btnShowPurchaseOrderItems.BOSError = null;
            this.fld_btnShowPurchaseOrderItems.BOSFieldGroup = "";
            this.fld_btnShowPurchaseOrderItems.BOSFieldRelation = "";
            this.fld_btnShowPurchaseOrderItems.BOSPrivilege = "";
            this.fld_btnShowPurchaseOrderItems.BOSPropertyName = "";
            this.fld_btnShowPurchaseOrderItems.Location = new System.Drawing.Point(1278, 33);
            this.fld_btnShowPurchaseOrderItems.Name = "fld_btnShowPurchaseOrderItems";
            this.fld_btnShowPurchaseOrderItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShowPurchaseOrderItems, true);
            this.fld_btnShowPurchaseOrderItems.Size = new System.Drawing.Size(137, 27);
            this.fld_btnShowPurchaseOrderItems.TabIndex = 388;
            this.fld_btnShowPurchaseOrderItems.Tag = "";
            this.fld_btnShowPurchaseOrderItems.Text = "Thêm từ đơn hàng";
            this.fld_btnShowPurchaseOrderItems.Click += new System.EventHandler(this.fld_btnShowPurchaseOrderItems_Click);
            // 
            // fld_dgcICReceiptItems
            // 
            this.fld_dgcICReceiptItems.AllowDrop = true;
            this.fld_dgcICReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptItems.BOSComment = null;
            this.fld_dgcICReceiptItems.BOSDataMember = null;
            this.fld_dgcICReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcICReceiptItems.BOSDescription = null;
            this.fld_dgcICReceiptItems.BOSError = null;
            this.fld_dgcICReceiptItems.BOSFieldGroup = null;
            this.fld_dgcICReceiptItems.BOSFieldRelation = null;
            this.fld_dgcICReceiptItems.BOSGridType = null;
            this.fld_dgcICReceiptItems.BOSPrivilege = null;
            this.fld_dgcICReceiptItems.BOSPropertyName = null;
            this.fld_dgcICReceiptItems.CommodityType = "";
            this.fld_dgcICReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptItems.Location = new System.Drawing.Point(5, 38);
            this.fld_dgcICReceiptItems.MainView = this.gridView4;
            this.fld_dgcICReceiptItems.Name = "fld_dgcICReceiptItems";
            this.fld_dgcICReceiptItems.PrintReport = false;
            this.fld_dgcICReceiptItems.Screen = null;
            this.fld_dgcICReceiptItems.Size = new System.Drawing.Size(1267, 476);
            this.fld_dgcICReceiptItems.TabIndex = 1;
            this.fld_dgcICReceiptItems.Tag = "DC";
            this.fld_dgcICReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcICReceiptItems;
            this.gridView4.Name = "gridView4";
            this.gridView4.PaintStyleName = "Office2003";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(14, 14);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 387;
            this.bosLabel13.Text = "Sản phẩm";
            // 
            // fld_pteICReceiptItemProductPicture1
            // 
            this.fld_pteICReceiptItemProductPicture1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICReceiptItemProductPicture1.BOSComment = null;
            this.fld_pteICReceiptItemProductPicture1.BOSDataMember = "ICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture1.BOSDataSource = "ICReceiptItems";
            this.fld_pteICReceiptItemProductPicture1.BOSDescription = null;
            this.fld_pteICReceiptItemProductPicture1.BOSError = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldGroup = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldRelation = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPrivilege = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptItemProductPicture1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICReceiptItemProductPicture1.FileName = null;
            this.fld_pteICReceiptItemProductPicture1.FilePath = null;
            this.fld_pteICReceiptItemProductPicture1.Location = new System.Drawing.Point(1277, 66);
            this.fld_pteICReceiptItemProductPicture1.Name = "fld_pteICReceiptItemProductPicture1";
            this.fld_pteICReceiptItemProductPicture1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptItemProductPicture1.Screen = null;
            this.fld_pteICReceiptItemProductPicture1.Size = new System.Drawing.Size(138, 140);
            this.fld_pteICReceiptItemProductPicture1.TabIndex = 2;
            this.fld_pteICReceiptItemProductPicture1.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID1
            // 
            this.fld_lkeFK_ICProductID1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID1.BOSComment = null;
            this.fld_lkeFK_ICProductID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID1.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID1.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = null;
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID1.Location = new System.Drawing.Point(67, 12);
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID1.Properties.NullText = "";
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.fld_lkeFK_ICProductID1.Size = new System.Drawing.Size(1205, 20);
            this.fld_lkeFK_ICProductID1.TabIndex = 0;
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            this.fld_lkeFK_ICProductID1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID1_KeyUp);
            // 
            // fld_tabpageConts
            // 
            this.fld_tabpageConts.Controls.Add(this.splitContainerControl1);
            this.fld_tabpageConts.Name = "fld_tabpageConts";
            this.fld_tabpageConts.PageVisible = false;
            this.fld_tabpageConts.Size = new System.Drawing.Size(1417, 524);
            this.fld_tabpageConts.Text = "Danh sách conts";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1417, 524);
            this.splitContainerControl1.SplitterPosition = 539;
            this.splitContainerControl1.TabIndex = 16;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeICReceiptItemConts);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(535, 514);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Container";
            // 
            // fld_lkeICReceiptItemConts
            // 
            this.fld_lkeICReceiptItemConts.AllowDrop = true;
            this.fld_lkeICReceiptItemConts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICReceiptItemConts.BOSComment = null;
            this.fld_lkeICReceiptItemConts.BOSDataMember = null;
            this.fld_lkeICReceiptItemConts.BOSDataSource = "ICReceiptItemConts";
            this.fld_lkeICReceiptItemConts.BOSDescription = null;
            this.fld_lkeICReceiptItemConts.BOSError = null;
            this.fld_lkeICReceiptItemConts.BOSFieldGroup = null;
            this.fld_lkeICReceiptItemConts.BOSFieldRelation = null;
            this.fld_lkeICReceiptItemConts.BOSGridType = null;
            this.fld_lkeICReceiptItemConts.BOSPrivilege = null;
            this.fld_lkeICReceiptItemConts.BOSPropertyName = null;
            this.fld_lkeICReceiptItemConts.CommodityType = "";
            this.fld_lkeICReceiptItemConts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_lkeICReceiptItemConts.Location = new System.Drawing.Point(5, 23);
            this.fld_lkeICReceiptItemConts.MainView = this.gridView8;
            this.fld_lkeICReceiptItemConts.Name = "fld_lkeICReceiptItemConts";
            this.fld_lkeICReceiptItemConts.PrintReport = false;
            this.fld_lkeICReceiptItemConts.Screen = null;
            this.fld_lkeICReceiptItemConts.Size = new System.Drawing.Size(525, 486);
            this.fld_lkeICReceiptItemConts.TabIndex = 2;
            this.fld_lkeICReceiptItemConts.Tag = "DC";
            this.fld_lkeICReceiptItemConts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.fld_lkeICReceiptItemConts;
            this.gridView8.Name = "gridView8";
            this.gridView8.PaintStyleName = "Office2003";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.bosGroupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(868, 524);
            this.panelControl2.TabIndex = 0;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcICReceiptItemContFees);
            this.bosGroupControl2.Location = new System.Drawing.Point(5, 5);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(852, 507);
            this.bosGroupControl2.TabIndex = 0;
            this.bosGroupControl2.Text = "Danh sách phí";
            // 
            // fld_dgcICReceiptItemContFees
            // 
            this.fld_dgcICReceiptItemContFees.AllowDrop = true;
            this.fld_dgcICReceiptItemContFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICReceiptItemContFees.BOSComment = null;
            this.fld_dgcICReceiptItemContFees.BOSDataMember = null;
            this.fld_dgcICReceiptItemContFees.BOSDataSource = "ICReceiptItemContFees";
            this.fld_dgcICReceiptItemContFees.BOSDescription = null;
            this.fld_dgcICReceiptItemContFees.BOSError = null;
            this.fld_dgcICReceiptItemContFees.BOSFieldGroup = null;
            this.fld_dgcICReceiptItemContFees.BOSFieldRelation = null;
            this.fld_dgcICReceiptItemContFees.BOSGridType = null;
            this.fld_dgcICReceiptItemContFees.BOSPrivilege = null;
            this.fld_dgcICReceiptItemContFees.BOSPropertyName = null;
            this.fld_dgcICReceiptItemContFees.CommodityType = "";
            this.fld_dgcICReceiptItemContFees.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptItemContFees.Location = new System.Drawing.Point(5, 23);
            this.fld_dgcICReceiptItemContFees.MainView = this.gridView9;
            this.fld_dgcICReceiptItemContFees.Name = "fld_dgcICReceiptItemContFees";
            this.fld_dgcICReceiptItemContFees.PrintReport = false;
            this.fld_dgcICReceiptItemContFees.Screen = null;
            this.fld_dgcICReceiptItemContFees.Size = new System.Drawing.Size(842, 479);
            this.fld_dgcICReceiptItemContFees.TabIndex = 3;
            this.fld_dgcICReceiptItemContFees.Tag = "DC";
            this.fld_dgcICReceiptItemContFees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView9});
            // 
            // gridView9
            // 
            this.gridView9.GridControl = this.fld_dgcICReceiptItemContFees;
            this.gridView9.Name = "gridView9";
            this.gridView9.PaintStyleName = "Office2003";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1417, 524);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
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
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1417, 524);
            this.fld_dgcACDocumentEntrys.TabIndex = 1;
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
            // fld_lkeICReceiptReceiptType
            // 
            this.fld_lkeICReceiptReceiptType.BOSAllowAddNew = false;
            this.fld_lkeICReceiptReceiptType.BOSAllowDummy = true;
            this.fld_lkeICReceiptReceiptType.BOSComment = "";
            this.fld_lkeICReceiptReceiptType.BOSDataMember = "ICReceiptReceiptType";
            this.fld_lkeICReceiptReceiptType.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptReceiptType.BOSDescription = null;
            this.fld_lkeICReceiptReceiptType.BOSError = null;
            this.fld_lkeICReceiptReceiptType.BOSFieldGroup = "";
            this.fld_lkeICReceiptReceiptType.BOSFieldParent = "";
            this.fld_lkeICReceiptReceiptType.BOSFieldRelation = "";
            this.fld_lkeICReceiptReceiptType.BOSPrivilege = "";
            this.fld_lkeICReceiptReceiptType.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptReceiptType.BOSSelectType = "";
            this.fld_lkeICReceiptReceiptType.BOSSelectTypeValue = "";
            this.fld_lkeICReceiptReceiptType.CurrentDisplayText = null;
            this.fld_lkeICReceiptReceiptType.Location = new System.Drawing.Point(215, 91);
            this.fld_lkeICReceiptReceiptType.Name = "fld_lkeICReceiptReceiptType";
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICReceiptReceiptType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptReceiptType.Properties.ColumnName = null;
            this.fld_lkeICReceiptReceiptType.Properties.NullText = "";
            this.fld_lkeICReceiptReceiptType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICReceiptReceiptType.Screen = null;
            this.fld_lkeICReceiptReceiptType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICReceiptReceiptType.TabIndex = 3;
            this.fld_lkeICReceiptReceiptType.Tag = "DC";
            this.fld_lkeICReceiptReceiptType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeICReceiptReceiptType_CloseUp);
            // 
            // fld_lkeFK_GETerminalID
            // 
            this.fld_lkeFK_GETerminalID.BOSAllowAddNew = false;
            this.fld_lkeFK_GETerminalID.BOSAllowDummy = true;
            this.fld_lkeFK_GETerminalID.BOSComment = "";
            this.fld_lkeFK_GETerminalID.BOSDataMember = "FK_GETerminalID";
            this.fld_lkeFK_GETerminalID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GETerminalID.BOSDescription = null;
            this.fld_lkeFK_GETerminalID.BOSError = null;
            this.fld_lkeFK_GETerminalID.BOSFieldGroup = "";
            this.fld_lkeFK_GETerminalID.BOSFieldParent = "";
            this.fld_lkeFK_GETerminalID.BOSFieldRelation = "";
            this.fld_lkeFK_GETerminalID.BOSPrivilege = "";
            this.fld_lkeFK_GETerminalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GETerminalID.BOSSelectType = "";
            this.fld_lkeFK_GETerminalID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GETerminalID.CurrentDisplayText = "";
            this.fld_lkeFK_GETerminalID.Location = new System.Drawing.Point(754, 145);
            this.fld_lkeFK_GETerminalID.Name = "fld_lkeFK_GETerminalID";
            this.fld_lkeFK_GETerminalID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GETerminalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GETerminalID.Properties.ColumnName = null;
            this.fld_lkeFK_GETerminalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GETerminalName", "Tên")});
            this.fld_lkeFK_GETerminalID.Properties.DisplayMember = "GETerminalName";
            this.fld_lkeFK_GETerminalID.Properties.NullText = "";
            this.fld_lkeFK_GETerminalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GETerminalID.Properties.ValueMember = "GETerminalID";
            this.fld_lkeFK_GETerminalID.Screen = null;
            this.fld_lkeFK_GETerminalID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GETerminalID.TabIndex = 16;
            this.fld_lkeFK_GETerminalID.Tag = "DC";
            this.fld_lkeFK_GETerminalID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_GETerminalID_CloseUp);
            // 
            // fld_lkeFK_ICProductAttributeWoodTypeID
            // 
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDataMember = "FK_ICProductAttributeWoodTypeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectTypeValue = "WoodType";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Location = new System.Drawing.Point(1029, 91);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Name = "fld_lkeFK_ICProductAttributeWoodTypeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại gỗ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại gỗ")});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeWoodTypeID, true);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.TabIndex = 21;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel25.BOSPropertyName = "";
            this.bosLabel25.Location = new System.Drawing.Point(661, 148);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(25, 13);
            this.bosLabel25.TabIndex = 615;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Cảng";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(918, 95);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, true);
            this.bosLabel24.Size = new System.Drawing.Size(34, 13);
            this.bosLabel24.TabIndex = 614;
            this.bosLabel24.Text = "Loại gỗ";
            // 
            // fld_lbWoodType
            // 
            this.fld_lbWoodType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.Options.UseBackColor = true;
            this.fld_lbWoodType.Appearance.Options.UseForeColor = true;
            this.fld_lbWoodType.BOSComment = null;
            this.fld_lbWoodType.BOSDataMember = null;
            this.fld_lbWoodType.BOSDataSource = null;
            this.fld_lbWoodType.BOSDescription = null;
            this.fld_lbWoodType.BOSError = null;
            this.fld_lbWoodType.BOSFieldGroup = null;
            this.fld_lbWoodType.BOSFieldRelation = null;
            this.fld_lbWoodType.BOSPrivilege = null;
            this.fld_lbWoodType.BOSPropertyName = null;
            this.fld_lbWoodType.Location = new System.Drawing.Point(918, 68);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 613;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(1029, 65);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ReadOnly = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 20;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // fld_lkeICReceiptPurposeType
            // 
            this.fld_lkeICReceiptPurposeType.BOSAllowAddNew = false;
            this.fld_lkeICReceiptPurposeType.BOSAllowDummy = true;
            this.fld_lkeICReceiptPurposeType.BOSComment = null;
            this.fld_lkeICReceiptPurposeType.BOSDataMember = "ICReceiptPurposeType";
            this.fld_lkeICReceiptPurposeType.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptPurposeType.BOSDescription = null;
            this.fld_lkeICReceiptPurposeType.BOSError = null;
            this.fld_lkeICReceiptPurposeType.BOSFieldGroup = null;
            this.fld_lkeICReceiptPurposeType.BOSFieldParent = null;
            this.fld_lkeICReceiptPurposeType.BOSFieldRelation = null;
            this.fld_lkeICReceiptPurposeType.BOSPrivilege = null;
            this.fld_lkeICReceiptPurposeType.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptPurposeType.BOSSelectType = null;
            this.fld_lkeICReceiptPurposeType.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptPurposeType.CurrentDisplayText = null;
            this.fld_lkeICReceiptPurposeType.Location = new System.Drawing.Point(754, 91);
            this.fld_lkeICReceiptPurposeType.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptPurposeType.Name = "fld_lkeICReceiptPurposeType";
            this.fld_lkeICReceiptPurposeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptPurposeType.Properties.ColumnName = null;
            this.fld_lkeICReceiptPurposeType.Screen = null;
            this.fld_lkeICReceiptPurposeType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICReceiptPurposeType.TabIndex = 14;
            this.fld_lkeICReceiptPurposeType.Tag = "DC";
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
            this.bosLabel23.Location = new System.Drawing.Point(661, 94);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(83, 13);
            this.bosLabel23.TabIndex = 610;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Mục đích sử dụng";
            // 
            // bosLookupEdit7
            // 
            this.bosLookupEdit7.BOSAllowAddNew = false;
            this.bosLookupEdit7.BOSAllowDummy = true;
            this.bosLookupEdit7.BOSComment = "";
            this.bosLookupEdit7.BOSDataMember = "FK_GECountryID";
            this.bosLookupEdit7.BOSDataSource = "ICReceipts";
            this.bosLookupEdit7.BOSDescription = null;
            this.bosLookupEdit7.BOSError = null;
            this.bosLookupEdit7.BOSFieldGroup = "";
            this.bosLookupEdit7.BOSFieldParent = "";
            this.bosLookupEdit7.BOSFieldRelation = "";
            this.bosLookupEdit7.BOSPrivilege = "";
            this.bosLookupEdit7.BOSPropertyName = "EditValue";
            this.bosLookupEdit7.BOSSelectType = "";
            this.bosLookupEdit7.BOSSelectTypeValue = "";
            this.bosLookupEdit7.CurrentDisplayText = null;
            this.bosLookupEdit7.Location = new System.Drawing.Point(1029, 117);
            this.bosLookupEdit7.Name = "bosLookupEdit7";
            this.bosLookupEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit7.Properties.ColumnName = null;
            this.bosLookupEdit7.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Xuất xứ")});
            this.bosLookupEdit7.Properties.DisplayMember = "GECountryName";
            this.bosLookupEdit7.Properties.NullText = "";
            this.bosLookupEdit7.Properties.PopupWidth = 40;
            this.bosLookupEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit7.Properties.ValueMember = "GECountryID";
            this.bosLookupEdit7.Screen = null;
            this.bosLookupEdit7.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit7.TabIndex = 19;
            this.bosLookupEdit7.Tag = "DC";
            this.bosLookupEdit7.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.BosLookupEdit7_CloseUp);
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(127, 94);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(67, 13);
            this.bosLabel21.TabIndex = 608;
            this.bosLabel21.Text = "Loại hàng hóa";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(918, 120);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, true);
            this.bosLabel20.Size = new System.Drawing.Size(38, 13);
            this.bosLabel20.TabIndex = 607;
            this.bosLabel20.Text = "Xuất xứ";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(661, 68);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(60, 13);
            this.bosLabel19.TabIndex = 606;
            this.bosLabel19.Text = "ContainerNo";
            // 
            // fld_txtICReceiptContainerNo
            // 
            this.fld_txtICReceiptContainerNo.BOSComment = "";
            this.fld_txtICReceiptContainerNo.BOSDataMember = "ICReceiptContainerNo";
            this.fld_txtICReceiptContainerNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptContainerNo.BOSDescription = null;
            this.fld_txtICReceiptContainerNo.BOSError = null;
            this.fld_txtICReceiptContainerNo.BOSFieldGroup = "";
            this.fld_txtICReceiptContainerNo.BOSFieldRelation = "";
            this.fld_txtICReceiptContainerNo.BOSPrivilege = "";
            this.fld_txtICReceiptContainerNo.BOSPropertyName = "Text";
            this.fld_txtICReceiptContainerNo.EditValue = "";
            this.fld_txtICReceiptContainerNo.Location = new System.Drawing.Point(754, 65);
            this.fld_txtICReceiptContainerNo.Name = "fld_txtICReceiptContainerNo";
            this.fld_txtICReceiptContainerNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICReceiptContainerNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptContainerNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptContainerNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptContainerNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptContainerNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptContainerNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptContainerNo, true);
            this.fld_txtICReceiptContainerNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptContainerNo.TabIndex = 13;
            this.fld_txtICReceiptContainerNo.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(495, 117);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 9;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = "";
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACAssObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACAssObjectID.Location = new System.Drawing.Point(215, 39);
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACAssObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACAssObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACAssObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACAssObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.fld_lkeFK_ACAssObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAssObjectID.TabIndex = 1;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            this.fld_lkeFK_ACAssObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACAssObjectID_CloseUp);
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(661, 121);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(34, 13);
            this.bosLabel22.TabIndex = 593;
            this.bosLabel22.Text = "Mã LSX";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_MMBatchProductID";
            this.bosLookupEdit1.BOSDataSource = "ICReceipts";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(754, 119);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.bosLookupEdit1.Properties.DisplayMember = "MMBatchProductNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "MMBatchProductID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 15;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = "";
            this.fld_lblLabel10.BOSDataMember = "";
            this.fld_lblLabel10.BOSDataSource = "ARInvoices";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = "";
            this.fld_lblLabel10.BOSFieldRelation = "";
            this.fld_lblLabel10.BOSPrivilege = "";
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(397, 120);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 591;
            this.fld_lblLabel10.Tag = "";
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // bosLabel29
            // 
            this.bosLabel29.BOSComment = null;
            this.bosLabel29.BOSDataMember = null;
            this.bosLabel29.BOSDataSource = null;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = null;
            this.bosLabel29.BOSFieldRelation = null;
            this.bosLabel29.BOSPrivilege = null;
            this.bosLabel29.BOSPropertyName = null;
            this.bosLabel29.Location = new System.Drawing.Point(127, 123);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(46, 13);
            this.bosLabel29.TabIndex = 589;
            this.bosLabel29.Text = "Số PO.No";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ICReceiptPONo";
            this.bosTextBox2.BOSDataSource = "ICReceipts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(215, 117);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 4;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_medICReceiptComment);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(7, 778);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(307, 141);
            this.bosLine1.TabIndex = 23;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Ghi chú";
            // 
            // fld_medICReceiptComment
            // 
            this.fld_medICReceiptComment.BOSComment = null;
            this.fld_medICReceiptComment.BOSDataMember = "ICReceiptComment";
            this.fld_medICReceiptComment.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptComment.BOSDescription = null;
            this.fld_medICReceiptComment.BOSError = null;
            this.fld_medICReceiptComment.BOSFieldGroup = null;
            this.fld_medICReceiptComment.BOSFieldRelation = null;
            this.fld_medICReceiptComment.BOSPrivilege = null;
            this.fld_medICReceiptComment.BOSPropertyName = "Text";
            this.fld_medICReceiptComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_medICReceiptComment.Location = new System.Drawing.Point(3, 17);
            this.fld_medICReceiptComment.MenuManager = this.screenToolbar;
            this.fld_medICReceiptComment.Name = "fld_medICReceiptComment";
            this.fld_medICReceiptComment.Screen = null;
            this.fld_medICReceiptComment.Size = new System.Drawing.Size(301, 121);
            this.fld_medICReceiptComment.TabIndex = 0;
            this.fld_medICReceiptComment.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(1029, 13);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 17;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICReceiptDiscountFix
            // 
            this.fld_txtICReceiptDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountFix.BOSComment = "";
            this.fld_txtICReceiptDiscountFix.BOSDataMember = "ICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountFix.BOSDescription = null;
            this.fld_txtICReceiptDiscountFix.BOSError = null;
            this.fld_txtICReceiptDiscountFix.BOSFieldGroup = "";
            this.fld_txtICReceiptDiscountFix.BOSFieldRelation = "";
            this.fld_txtICReceiptDiscountFix.BOSPrivilege = "";
            this.fld_txtICReceiptDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountFix.EditValue = "0.00";
            this.fld_txtICReceiptDiscountFix.Location = new System.Drawing.Point(1328, 800);
            this.fld_txtICReceiptDiscountFix.Name = "fld_txtICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptDiscountFix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDiscountFix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDiscountFix.Screen = null;
            this.fld_txtICReceiptDiscountFix.Size = new System.Drawing.Size(90, 20);
            this.fld_txtICReceiptDiscountFix.TabIndex = 16;
            this.fld_txtICReceiptDiscountFix.Tag = "DC";
            this.fld_txtICReceiptDiscountFix.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountFix_Validated);
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
            this.bosLabel15.Location = new System.Drawing.Point(918, 42);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(29, 13);
            this.bosLabel15.TabIndex = 518;
            this.bosLabel15.Text = "Tỷ giá";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(127, 148);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(40, 13);
            this.bosLabel16.TabIndex = 518;
            this.bosLabel16.Text = "Diễn giải";
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
            this.bosLabel14.Location = new System.Drawing.Point(918, 16);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(53, 13);
            this.bosLabel14.TabIndex = 518;
            this.bosLabel14.Text = "Loại tiền tệ";
            // 
            // fld_txtICReceiptTaxAmount
            // 
            this.fld_txtICReceiptTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxAmount.BOSComment = "";
            this.fld_txtICReceiptTaxAmount.BOSDataMember = "ICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxAmount.BOSDescription = null;
            this.fld_txtICReceiptTaxAmount.BOSError = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldRelation = "";
            this.fld_txtICReceiptTaxAmount.BOSPrivilege = "";
            this.fld_txtICReceiptTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxAmount.EditValue = "0.00";
            this.fld_txtICReceiptTaxAmount.Location = new System.Drawing.Point(1328, 878);
            this.fld_txtICReceiptTaxAmount.Name = "fld_txtICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTaxAmount.Screen = null;
            this.fld_txtICReceiptTaxAmount.Size = new System.Drawing.Size(90, 20);
            this.fld_txtICReceiptTaxAmount.TabIndex = 20;
            this.fld_txtICReceiptTaxAmount.Tag = "DC";
            this.fld_txtICReceiptTaxAmount.Validated += new System.EventHandler(this.fld_txtICReceiptTaxAmount_Validated);
            // 
            // fld_txtICReceiptTaxPercent
            // 
            this.fld_txtICReceiptTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxPercent.BOSComment = "";
            this.fld_txtICReceiptTaxPercent.BOSDataMember = "ICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxPercent.BOSDescription = null;
            this.fld_txtICReceiptTaxPercent.BOSError = null;
            this.fld_txtICReceiptTaxPercent.BOSFieldGroup = "";
            this.fld_txtICReceiptTaxPercent.BOSFieldRelation = "";
            this.fld_txtICReceiptTaxPercent.BOSPrivilege = "";
            this.fld_txtICReceiptTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxPercent.EditValue = "0.00";
            this.fld_txtICReceiptTaxPercent.Location = new System.Drawing.Point(1250, 878);
            this.fld_txtICReceiptTaxPercent.Name = "fld_txtICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptTaxPercent.Screen = null;
            this.fld_txtICReceiptTaxPercent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtICReceiptTaxPercent.TabIndex = 19;
            this.fld_txtICReceiptTaxPercent.Tag = "DC";
            this.fld_txtICReceiptTaxPercent.Validated += new System.EventHandler(this.fld_txtICReceiptTaxPercent_Validated);
            // 
            // fld_txtICReceiptDiscountPerCent
            // 
            this.fld_txtICReceiptDiscountPerCent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountPerCent.BOSComment = "";
            this.fld_txtICReceiptDiscountPerCent.BOSDataMember = "ICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountPerCent.BOSDescription = null;
            this.fld_txtICReceiptDiscountPerCent.BOSError = null;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldGroup = "";
            this.fld_txtICReceiptDiscountPerCent.BOSFieldRelation = "";
            this.fld_txtICReceiptDiscountPerCent.BOSPrivilege = "";
            this.fld_txtICReceiptDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountPerCent.EditValue = "0.00";
            this.fld_txtICReceiptDiscountPerCent.Location = new System.Drawing.Point(1250, 800);
            this.fld_txtICReceiptDiscountPerCent.Name = "fld_txtICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.EditMask = "n";
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDiscountPerCent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDiscountPerCent.Screen = null;
            this.fld_txtICReceiptDiscountPerCent.Size = new System.Drawing.Size(72, 20);
            this.fld_txtICReceiptDiscountPerCent.TabIndex = 15;
            this.fld_txtICReceiptDiscountPerCent.Tag = "DC";
            this.fld_txtICReceiptDiscountPerCent.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountPercent_Validated);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(1204, 881);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(24, 13);
            this.bosLabel9.TabIndex = 529;
            this.bosLabel9.Text = "Thuế";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(1175, 803);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(51, 13);
            this.bosLabel7.TabIndex = 529;
            this.bosLabel7.Text = "Chiết khấu";
            // 
            // fld_txtICReceiptExchangeRate
            // 
            this.fld_txtICReceiptExchangeRate.BOSComment = null;
            this.fld_txtICReceiptExchangeRate.BOSDataMember = "ICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptExchangeRate.BOSDescription = null;
            this.fld_txtICReceiptExchangeRate.BOSError = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldGroup = null;
            this.fld_txtICReceiptExchangeRate.BOSFieldRelation = null;
            this.fld_txtICReceiptExchangeRate.BOSPrivilege = null;
            this.fld_txtICReceiptExchangeRate.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(1029, 39);
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 18;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            this.fld_txtICReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtICReceiptExchangeRate_Validated);
            // 
            // fld_btnClearPackage
            // 
            this.fld_btnClearPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClearPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnClearPackage.Appearance.Options.UseForeColor = true;
            this.fld_btnClearPackage.BOSComment = "";
            this.fld_btnClearPackage.BOSDataMember = "";
            this.fld_btnClearPackage.BOSDataSource = "";
            this.fld_btnClearPackage.BOSDescription = null;
            this.fld_btnClearPackage.BOSError = null;
            this.fld_btnClearPackage.BOSFieldGroup = "";
            this.fld_btnClearPackage.BOSFieldRelation = "";
            this.fld_btnClearPackage.BOSPrivilege = "";
            this.fld_btnClearPackage.BOSPropertyName = "";
            this.fld_btnClearPackage.Location = new System.Drawing.Point(1278, 282);
            this.fld_btnClearPackage.Name = "fld_btnClearPackage";
            this.fld_btnClearPackage.Screen = null;
            this.fld_btnClearPackage.Size = new System.Drawing.Size(137, 29);
            this.fld_btnClearPackage.TabIndex = 409;
            this.fld_btnClearPackage.Tag = "";
            this.fld_btnClearPackage.Text = "Xóa mã kiện";
            this.fld_btnClearPackage.Click += new System.EventHandler(this.fld_btnClearPackage_Click);
            // 
            // DMRC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1439, 935);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMRC100.IconOptions.Icon")));
            this.Name = "DMRC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgReceiptType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptProportion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).EndInit();
            this.fld_panelProduct.ResumeLayout(false);
            this.fld_panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            this.fld_tabpageConts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptItemConts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItemContFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptReceiptType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GETerminalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptPurposeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteICReceiptDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtICReceiptInvoiceInNo;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_txtICReceiptPackNo;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSDateEdit fld_dteICReceiptInvoiceInDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICReceiptDeliveryContactName;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICReceiptSubTotalCost;
        private BOSComponent.BOSTextBox fld_txtICReceiptTotalCost;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTextBox fld_txtICReceiptShippingFee;
        private BOSComponent.BOSTextBox fld_txtICReceiptShippingExtraFee;
        private BOSComponent.BOSRadioGroup fld_rdgReceiptType;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtICReceiptExchangeRate;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountFix;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxAmount;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxPercent;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountPerCent;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medICReceiptComment;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtICReceiptContainerNo;
        private BOSComponent.BOSLookupEdit bosLookupEdit7;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptPurposeType;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeWoodTypeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GETerminalID;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptReceiptType;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private DevExpress.XtraEditors.PanelControl fld_panelProduct;
        private BOSComponent.BOSButton fld_btnShowPurchaseOrderItems;
        private ICReceiptItemsGridControl fld_dgcICReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptItemProductPicture1;
        private ItemLookupEdit fld_lkeFK_ICProductID1;
        private DevExpress.XtraTab.XtraTabPage fld_tabpageConts;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private ICReceiptItemContsGridControl fld_lkeICReceiptItemConts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICReceiptItemContFeesGridControl fld_dgcICReceiptItemContFees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox fld_txtICReceiptProportion;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSButton fld_btnZoomProduct;
        private BOSComponent.BOSButton btnGenPackage;
        private BOSComponent.BOSButton fld_btnGroupPackage;
        private BOSComponent.BOSButton fld_btnClearPackage;
    }
}
