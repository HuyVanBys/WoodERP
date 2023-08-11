using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OutsourcingReceipt.UI
{
	/// <summary>
	/// Summary description for DMOR100
	/// </summary>
	partial class DMOR100
    {
		private BOSComponent.BOSLabel fld_Lablel;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptItemProductPicture;
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
            this.fld_panelProduct = new DevExpress.XtraEditors.PanelControl();
            this.fld_dgcICReceiptItems = new BOSERP.Modules.OutsourcingReceipt.ICReceiptItemsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICReceiptItemProductPicture1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSERP.ItemLookupEdit(this.components);
            this.fld_panelPackage = new DevExpress.XtraEditors.PanelControl();
            this.fld_tabChoocePackingList = new BOSComponent.BOSTabControl(this.components);
            this.fld_xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiPackageReceiptItems = new BOSERP.Modules.OutsourcingReceipt.MultiPackageReceiptItemsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiProductReceiptItems = new BOSERP.Modules.OutsourcingReceipt.MultiProductReceiptItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiReceiptItems = new BOSERP.Modules.OutsourcingReceipt.MultiReceiptItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_Lablel = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICReceiptItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
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
            this.fld_lkeFK_ACAssObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptTotalQuantity = new BOSComponent.BOSTextBox(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medICReceiptComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).BeginInit();
            this.fld_panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelPackage)).BeginInit();
            this.fld_panelPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabChoocePackingList)).BeginInit();
            this.fld_tabChoocePackingList.SuspendLayout();
            this.fld_xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiPackageReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.fld_xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiProductReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeliveryContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalQuantity.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_panelProduct
            // 
            this.fld_panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_panelProduct.Controls.Add(this.fld_dgcICReceiptItems);
            this.fld_panelProduct.Controls.Add(this.bosLabel13);
            this.fld_panelProduct.Controls.Add(this.fld_pteICReceiptItemProductPicture1);
            this.fld_panelProduct.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.fld_panelProduct.Location = new System.Drawing.Point(0, 3);
            this.fld_panelProduct.Name = "fld_panelProduct";
            this.fld_panelProduct.Size = new System.Drawing.Size(1103, 354);
            this.fld_panelProduct.TabIndex = 12;
            this.fld_panelProduct.Tag = "DC";
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
            this.fld_dgcICReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICReceiptItems.Location = new System.Drawing.Point(5, 38);
            this.fld_dgcICReceiptItems.MainView = this.gridView4;
            this.fld_dgcICReceiptItems.Name = "fld_dgcICReceiptItems";
            this.fld_dgcICReceiptItems.PrintReport = false;
            this.fld_dgcICReceiptItems.Screen = null;
            this.fld_dgcICReceiptItems.Size = new System.Drawing.Size(948, 311);
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
            this.fld_pteICReceiptItemProductPicture1.Location = new System.Drawing.Point(959, 11);
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
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID1.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.fld_lkeFK_ICProductID1.Size = new System.Drawing.Size(886, 20);
            this.fld_lkeFK_ICProductID1.TabIndex = 0;
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            this.fld_lkeFK_ICProductID1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID1_KeyUp);
            // 
            // fld_panelPackage
            // 
            this.fld_panelPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_panelPackage.Controls.Add(this.fld_tabChoocePackingList);
            this.fld_panelPackage.Controls.Add(this.fld_Lablel);
            this.fld_panelPackage.Controls.Add(this.fld_pteICReceiptItemProductPicture);
            this.fld_panelPackage.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_panelPackage.Location = new System.Drawing.Point(0, 29);
            this.fld_panelPackage.Name = "fld_panelPackage";
            this.fld_panelPackage.Size = new System.Drawing.Size(1106, 326);
            this.fld_panelPackage.TabIndex = 15;
            this.fld_panelPackage.Tag = "DC";
            this.fld_panelPackage.Visible = false;
            // 
            // fld_tabChoocePackingList
            // 
            this.fld_tabChoocePackingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabChoocePackingList.BOSComment = null;
            this.fld_tabChoocePackingList.BOSDataMember = null;
            this.fld_tabChoocePackingList.BOSDataSource = null;
            this.fld_tabChoocePackingList.BOSDescription = null;
            this.fld_tabChoocePackingList.BOSError = null;
            this.fld_tabChoocePackingList.BOSFieldGroup = null;
            this.fld_tabChoocePackingList.BOSFieldRelation = null;
            this.fld_tabChoocePackingList.BOSPrivilege = null;
            this.fld_tabChoocePackingList.BOSPropertyName = null;
            this.fld_tabChoocePackingList.Location = new System.Drawing.Point(1, 38);
            this.fld_tabChoocePackingList.Name = "fld_tabChoocePackingList";
            this.fld_tabChoocePackingList.Screen = null;
            this.fld_tabChoocePackingList.SelectedTabPage = this.fld_xtraTabPage1;
            this.fld_tabChoocePackingList.Size = new System.Drawing.Size(954, 290);
            this.fld_tabChoocePackingList.TabIndex = 472;
            this.fld_tabChoocePackingList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_xtraTabPage1,
            this.fld_xtraTabPage2,
            this.fld_xtraTabPage3});
            // 
            // fld_xtraTabPage1
            // 
            this.fld_xtraTabPage1.Controls.Add(this.fld_dgcMultiPackageReceiptItems);
            this.fld_xtraTabPage1.Name = "fld_xtraTabPage1";
            this.fld_xtraTabPage1.Size = new System.Drawing.Size(947, 261);
            this.fld_xtraTabPage1.Text = "1 sản phẩm đóng trong nhiều kiện hàng";
            // 
            // fld_dgcMultiPackageReceiptItems
            // 
            this.fld_dgcMultiPackageReceiptItems.AllowDrop = true;
            this.fld_dgcMultiPackageReceiptItems.BOSComment = null;
            this.fld_dgcMultiPackageReceiptItems.BOSDataMember = null;
            this.fld_dgcMultiPackageReceiptItems.BOSDataSource = "ICReceiptComponentItems";
            this.fld_dgcMultiPackageReceiptItems.BOSDescription = null;
            this.fld_dgcMultiPackageReceiptItems.BOSError = null;
            this.fld_dgcMultiPackageReceiptItems.BOSFieldGroup = null;
            this.fld_dgcMultiPackageReceiptItems.BOSFieldRelation = null;
            this.fld_dgcMultiPackageReceiptItems.BOSGridType = null;
            this.fld_dgcMultiPackageReceiptItems.BOSPrivilege = null;
            this.fld_dgcMultiPackageReceiptItems.BOSPropertyName = null;
            this.fld_dgcMultiPackageReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMultiPackageReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMultiPackageReceiptItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMultiPackageReceiptItems.MainView = this.gridView3;
            this.fld_dgcMultiPackageReceiptItems.Name = "fld_dgcMultiPackageReceiptItems";
            this.fld_dgcMultiPackageReceiptItems.PrintReport = false;
            this.fld_dgcMultiPackageReceiptItems.Screen = null;
            this.fld_dgcMultiPackageReceiptItems.Size = new System.Drawing.Size(947, 261);
            this.fld_dgcMultiPackageReceiptItems.TabIndex = 22;
            this.fld_dgcMultiPackageReceiptItems.Tag = "DC";
            this.fld_dgcMultiPackageReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcMultiPackageReceiptItems;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // fld_xtraTabPage2
            // 
            this.fld_xtraTabPage2.Controls.Add(this.fld_dgcMultiProductReceiptItems);
            this.fld_xtraTabPage2.Name = "fld_xtraTabPage2";
            this.fld_xtraTabPage2.Size = new System.Drawing.Size(947, 261);
            this.fld_xtraTabPage2.Text = "1 kiện chứa nhiều sản phẩm";
            // 
            // fld_dgcMultiProductReceiptItems
            // 
            this.fld_dgcMultiProductReceiptItems.AllowDrop = true;
            this.fld_dgcMultiProductReceiptItems.BOSComment = null;
            this.fld_dgcMultiProductReceiptItems.BOSDataMember = null;
            this.fld_dgcMultiProductReceiptItems.BOSDataSource = "ICReceiptComponentItems";
            this.fld_dgcMultiProductReceiptItems.BOSDescription = null;
            this.fld_dgcMultiProductReceiptItems.BOSError = null;
            this.fld_dgcMultiProductReceiptItems.BOSFieldGroup = null;
            this.fld_dgcMultiProductReceiptItems.BOSFieldRelation = null;
            this.fld_dgcMultiProductReceiptItems.BOSGridType = null;
            this.fld_dgcMultiProductReceiptItems.BOSPrivilege = null;
            this.fld_dgcMultiProductReceiptItems.BOSPropertyName = null;
            this.fld_dgcMultiProductReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMultiProductReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMultiProductReceiptItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMultiProductReceiptItems.MainView = this.gridView1;
            this.fld_dgcMultiProductReceiptItems.Name = "fld_dgcMultiProductReceiptItems";
            this.fld_dgcMultiProductReceiptItems.PrintReport = false;
            this.fld_dgcMultiProductReceiptItems.Screen = null;
            this.fld_dgcMultiProductReceiptItems.Size = new System.Drawing.Size(947, 261);
            this.fld_dgcMultiProductReceiptItems.TabIndex = 21;
            this.fld_dgcMultiProductReceiptItems.Tag = "DC";
            this.fld_dgcMultiProductReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMultiProductReceiptItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_xtraTabPage3
            // 
            this.fld_xtraTabPage3.Controls.Add(this.fld_dgcMultiReceiptItems);
            this.fld_xtraTabPage3.Name = "fld_xtraTabPage3";
            this.fld_xtraTabPage3.Size = new System.Drawing.Size(947, 261);
            this.fld_xtraTabPage3.Text = "Nhiều kiện chứa nhiều sản phẩm";
            // 
            // fld_dgcMultiReceiptItems
            // 
            this.fld_dgcMultiReceiptItems.AllowDrop = true;
            this.fld_dgcMultiReceiptItems.BOSComment = null;
            this.fld_dgcMultiReceiptItems.BOSDataMember = null;
            this.fld_dgcMultiReceiptItems.BOSDataSource = "ICReceiptComponentItems";
            this.fld_dgcMultiReceiptItems.BOSDescription = null;
            this.fld_dgcMultiReceiptItems.BOSError = null;
            this.fld_dgcMultiReceiptItems.BOSFieldGroup = null;
            this.fld_dgcMultiReceiptItems.BOSFieldRelation = null;
            this.fld_dgcMultiReceiptItems.BOSGridType = null;
            this.fld_dgcMultiReceiptItems.BOSPrivilege = null;
            this.fld_dgcMultiReceiptItems.BOSPropertyName = null;
            this.fld_dgcMultiReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMultiReceiptItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMultiReceiptItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMultiReceiptItems.MainView = this.gridView2;
            this.fld_dgcMultiReceiptItems.Name = "fld_dgcMultiReceiptItems";
            this.fld_dgcMultiReceiptItems.PrintReport = false;
            this.fld_dgcMultiReceiptItems.Screen = null;
            this.fld_dgcMultiReceiptItems.Size = new System.Drawing.Size(947, 261);
            this.fld_dgcMultiReceiptItems.TabIndex = 21;
            this.fld_dgcMultiReceiptItems.Tag = "DC";
            this.fld_dgcMultiReceiptItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMultiReceiptItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_Lablel
            // 
            this.fld_Lablel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel.Appearance.Options.UseBackColor = true;
            this.fld_Lablel.Appearance.Options.UseForeColor = true;
            this.fld_Lablel.BOSComment = null;
            this.fld_Lablel.BOSDataMember = null;
            this.fld_Lablel.BOSDataSource = null;
            this.fld_Lablel.BOSDescription = null;
            this.fld_Lablel.BOSError = null;
            this.fld_Lablel.BOSFieldGroup = null;
            this.fld_Lablel.BOSFieldRelation = null;
            this.fld_Lablel.BOSPrivilege = null;
            this.fld_Lablel.BOSPropertyName = null;
            this.fld_Lablel.Location = new System.Drawing.Point(14, 14);
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.fld_Lablel.Size = new System.Drawing.Size(47, 13);
            this.fld_Lablel.TabIndex = 387;
            this.fld_Lablel.Text = "Sản phẩm";
            // 
            // fld_pteICReceiptItemProductPicture
            // 
            this.fld_pteICReceiptItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICReceiptItemProductPicture.BOSComment = null;
            this.fld_pteICReceiptItemProductPicture.BOSDataMember = "ICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture.BOSDataSource = "ICReceiptItems";
            this.fld_pteICReceiptItemProductPicture.BOSDescription = null;
            this.fld_pteICReceiptItemProductPicture.BOSError = null;
            this.fld_pteICReceiptItemProductPicture.BOSFieldGroup = null;
            this.fld_pteICReceiptItemProductPicture.BOSFieldRelation = null;
            this.fld_pteICReceiptItemProductPicture.BOSPrivilege = null;
            this.fld_pteICReceiptItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptItemProductPicture.Location = new System.Drawing.Point(960, 9);
            this.fld_pteICReceiptItemProductPicture.Name = "fld_pteICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptItemProductPicture.Screen = null;
            this.fld_pteICReceiptItemProductPicture.Size = new System.Drawing.Size(140, 140);
            this.fld_pteICReceiptItemProductPicture.TabIndex = 471;
            this.fld_pteICReceiptItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = null;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(67, 12);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(887, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 1;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = string.Empty;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(7, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = string.Empty;
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
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(7, 3);
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
            this.fld_lblLabel7.BOSDataMember = string.Empty;
            this.fld_lblLabel7.BOSDataSource = string.Empty;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = string.Empty;
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
            this.fld_Lablel3.BOSDataMember = string.Empty;
            this.fld_Lablel3.BOSDataSource = string.Empty;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = string.Empty;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(127, 67);
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
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(495, 92);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(400, 46);
            this.fld_medICReceiptDesc.TabIndex = 13;
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
            this.fld_lkeFK_ICStockID1.BOSError = string.Empty;
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(215, 64);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = string.Empty;
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 8;
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
            this.fld_dteICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptDate.TabIndex = 1;
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
            this.fld_txtICReceiptInvoiceInNo.TabIndex = 5;
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
            this.fld_txtICReceiptPackNo.TabIndex = 9;
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
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(745, 13);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 2;
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
            this.bosLabel3.Location = new System.Drawing.Point(662, 42);
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
            this.fld_dteICReceiptInvoiceInDate.Location = new System.Drawing.Point(745, 39);
            this.fld_dteICReceiptInvoiceInDate.Name = "fld_dteICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptInvoiceInDate.Screen = null;
            this.fld_dteICReceiptInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICReceiptInvoiceInDate.TabIndex = 6;
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
            this.bosLabel4.Location = new System.Drawing.Point(127, 93);
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
            this.fld_txtICReceiptDeliveryContactName.Location = new System.Drawing.Point(215, 90);
            this.fld_txtICReceiptDeliveryContactName.Name = "fld_txtICReceiptDeliveryContactName";
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICReceiptDeliveryContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICReceiptDeliveryContactName.Screen = null;
            this.fld_txtICReceiptDeliveryContactName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptDeliveryContactName.TabIndex = 12;
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
            this.bosLabel5.Location = new System.Drawing.Point(877, 533);
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
            this.bosLabel8.Location = new System.Drawing.Point(856, 661);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(66, 13);
            this.bosLabel8.TabIndex = 529;
            this.bosLabel8.Text = "THÀNH TIỀN";
            // 
            // fld_txtICReceiptSubTotalCost
            // 
            this.fld_txtICReceiptSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptSubTotalCost.BOSComment = string.Empty;
            this.fld_txtICReceiptSubTotalCost.BOSDataMember = "ICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtICReceiptSubTotalCost.BOSError = null;
            this.fld_txtICReceiptSubTotalCost.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptSubTotalCost.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptSubTotalCost.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptSubTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSubTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptSubTotalCost.Location = new System.Drawing.Point(944, 530);
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
            this.fld_txtICReceiptTotalCost.BOSComment = string.Empty;
            this.fld_txtICReceiptTotalCost.BOSDataMember = "ICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalCost.BOSDescription = null;
            this.fld_txtICReceiptTotalCost.BOSError = null;
            this.fld_txtICReceiptTotalCost.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptTotalCost.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptTotalCost.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalCost.EditValue = "0.00";
            this.fld_txtICReceiptTotalCost.Location = new System.Drawing.Point(944, 658);
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
            this.bosLabel11.Location = new System.Drawing.Point(849, 584);
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
            this.bosLabel12.Location = new System.Drawing.Point(883, 610);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 529;
            this.bosLabel12.Text = "Phí khác";
            // 
            // fld_txtICReceiptShippingFee
            // 
            this.fld_txtICReceiptShippingFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptShippingFee.BOSComment = string.Empty;
            this.fld_txtICReceiptShippingFee.BOSDataMember = "ICReceiptShippingFees";
            this.fld_txtICReceiptShippingFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingFee.BOSDescription = null;
            this.fld_txtICReceiptShippingFee.BOSError = null;
            this.fld_txtICReceiptShippingFee.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptShippingFee.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptShippingFee.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptShippingFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingFee.Location = new System.Drawing.Point(944, 581);
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
            this.fld_txtICReceiptShippingExtraFee.BOSComment = string.Empty;
            this.fld_txtICReceiptShippingExtraFee.BOSDataMember = "ICReceiptShippingExtraFees";
            this.fld_txtICReceiptShippingExtraFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingExtraFee.BOSDescription = null;
            this.fld_txtICReceiptShippingExtraFee.BOSError = null;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptShippingExtraFee.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptShippingExtraFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingExtraFee.EditValue = "0.00";
            this.fld_txtICReceiptShippingExtraFee.Location = new System.Drawing.Point(944, 607);
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel29);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTotalQuantity);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptInvoiceInDate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptPackNo);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
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
            this.bosPanel1.Size = new System.Drawing.Size(1133, 690);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = string.Empty;
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.Location = new System.Drawing.Point(215, 39);
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACAssObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACAssObjectID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ACAssObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACAssObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.fld_lkeFK_ACAssObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAssObjectID.TabIndex = 4;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            this.fld_lkeFK_ACAssObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
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
            this.bosLabel22.Location = new System.Drawing.Point(909, 93);
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
            this.bosLookupEdit1.BOSAllowDummy = false;
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
            this.bosLookupEdit1.BOSSelectType = string.Empty;
            this.bosLookupEdit1.BOSSelectTypeValue = string.Empty;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(969, 91);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.bosLookupEdit1.Properties.DisplayMember = "MMBatchProductNo";
            this.bosLookupEdit1.Properties.NullText = string.Empty;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "MMBatchProductID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, true);
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 15;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosLabel29.Location = new System.Drawing.Point(910, 68);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, true);
            this.bosLabel29.Size = new System.Drawing.Size(46, 13);
            this.bosLabel29.TabIndex = 589;
            this.bosLabel29.Text = "Số PO.No";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = string.Empty;
            this.bosTextBox2.BOSDataMember = "ICReceiptPONo";
            this.bosTextBox2.BOSDataSource = "ICReceipts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = string.Empty;
            this.bosTextBox2.BOSFieldRelation = string.Empty;
            this.bosTextBox2.BOSPrivilege = string.Empty;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = string.Empty;
            this.bosTextBox2.Location = new System.Drawing.Point(969, 65);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 11;
            this.bosTextBox2.Tag = "DC";
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
            this.bosLabel17.Location = new System.Drawing.Point(661, 68);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(63, 13);
            this.bosLabel17.TabIndex = 531;
            this.bosLabel17.Text = "Tổng KL (m3)";
            // 
            // fld_txtICReceiptTotalQuantity
            // 
            this.fld_txtICReceiptTotalQuantity.BOSComment = null;
            this.fld_txtICReceiptTotalQuantity.BOSDataMember = "ICReceiptTotalQty";
            this.fld_txtICReceiptTotalQuantity.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalQuantity.BOSDescription = null;
            this.fld_txtICReceiptTotalQuantity.BOSError = null;
            this.fld_txtICReceiptTotalQuantity.BOSFieldGroup = null;
            this.fld_txtICReceiptTotalQuantity.BOSFieldRelation = null;
            this.fld_txtICReceiptTotalQuantity.BOSPrivilege = null;
            this.fld_txtICReceiptTotalQuantity.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalQuantity.Enabled = false;
            this.fld_txtICReceiptTotalQuantity.Location = new System.Drawing.Point(745, 65);
            this.fld_txtICReceiptTotalQuantity.Name = "fld_txtICReceiptTotalQuantity";
            this.fld_txtICReceiptTotalQuantity.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTotalQuantity, true);
            this.fld_txtICReceiptTotalQuantity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptTotalQuantity.TabIndex = 10;
            this.fld_txtICReceiptTotalQuantity.Tag = "DC";
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
            this.bosLine1.Location = new System.Drawing.Point(7, 533);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(396, 141);
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
            this.fld_medICReceiptComment.Size = new System.Drawing.Size(390, 121);
            this.fld_medICReceiptComment.TabIndex = 0;
            this.fld_medICReceiptComment.Tag = "DC";
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
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(7, 143);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(1108, 384);
            this.fld_tabReceiptItems.TabIndex = 13;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_panelProduct);
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_panelPackage);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(1101, 355);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(1101, 355);
            this.fld_tabPageDocumentEntrys.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataMember = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = string.Empty;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = string.Empty;
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1101, 355);
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
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = null;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = string.Empty;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(969, 13);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = string.Empty;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICReceiptDiscountFix
            // 
            this.fld_txtICReceiptDiscountFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptDiscountFix.BOSComment = string.Empty;
            this.fld_txtICReceiptDiscountFix.BOSDataMember = "ICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountFix.BOSDescription = null;
            this.fld_txtICReceiptDiscountFix.BOSError = null;
            this.fld_txtICReceiptDiscountFix.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptDiscountFix.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptDiscountFix.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountFix.EditValue = "0.00";
            this.fld_txtICReceiptDiscountFix.Location = new System.Drawing.Point(1022, 555);
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
            this.bosLabel15.Location = new System.Drawing.Point(910, 42);
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
            this.bosLabel16.Location = new System.Drawing.Point(397, 93);
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
            this.bosLabel14.Location = new System.Drawing.Point(910, 16);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(53, 13);
            this.bosLabel14.TabIndex = 518;
            this.bosLabel14.Text = "Loại tiền tệ";
            // 
            // fld_txtICReceiptTaxAmount
            // 
            this.fld_txtICReceiptTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtICReceiptTaxAmount.BOSComment = string.Empty;
            this.fld_txtICReceiptTaxAmount.BOSDataMember = "ICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxAmount.BOSDescription = null;
            this.fld_txtICReceiptTaxAmount.BOSError = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptTaxAmount.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxAmount.EditValue = "0.00";
            this.fld_txtICReceiptTaxAmount.Location = new System.Drawing.Point(1022, 633);
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
            this.fld_txtICReceiptTaxPercent.BOSComment = string.Empty;
            this.fld_txtICReceiptTaxPercent.BOSDataMember = "ICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxPercent.BOSDescription = null;
            this.fld_txtICReceiptTaxPercent.BOSError = null;
            this.fld_txtICReceiptTaxPercent.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptTaxPercent.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptTaxPercent.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxPercent.EditValue = "0.00";
            this.fld_txtICReceiptTaxPercent.Location = new System.Drawing.Point(944, 633);
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
            this.fld_txtICReceiptDiscountPerCent.BOSComment = string.Empty;
            this.fld_txtICReceiptDiscountPerCent.BOSDataMember = "ICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountPerCent.BOSDescription = null;
            this.fld_txtICReceiptDiscountPerCent.BOSError = null;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldGroup = string.Empty;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldRelation = string.Empty;
            this.fld_txtICReceiptDiscountPerCent.BOSPrivilege = string.Empty;
            this.fld_txtICReceiptDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountPerCent.EditValue = "0.00";
            this.fld_txtICReceiptDiscountPerCent.Location = new System.Drawing.Point(944, 555);
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
            this.bosLabel9.Location = new System.Drawing.Point(898, 636);
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
            this.bosLabel7.Location = new System.Drawing.Point(869, 558);
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
            this.fld_txtICReceiptExchangeRate.Location = new System.Drawing.Point(969, 39);
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.fld_txtICReceiptExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICReceiptExchangeRate.TabIndex = 7;
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            this.fld_txtICReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtICReceiptExchangeRate_Validated);
            // 
            // DMOR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1133, 690);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMOR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).EndInit();
            this.fld_panelProduct.ResumeLayout(false);
            this.fld_panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelPackage)).EndInit();
            this.fld_panelPackage.ResumeLayout(false);
            this.fld_panelPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabChoocePackingList)).EndInit();
            this.fld_tabChoocePackingList.ResumeLayout(false);
            this.fld_xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiPackageReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.fld_xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiProductReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMultiReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptInvoiceInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptPackNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeliveryContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptShippingExtraFee.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalQuantity.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountFix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDiscountPerCent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            this.ResumeLayout(false);

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
        private BOSComponent.BOSTabControl fld_tabChoocePackingList;
        private DevExpress.XtraTab.XtraTabPage fld_xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage fld_xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage fld_xtraTabPage3;
        private MultiProductReceiptItemsGridControl fld_dgcMultiProductReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MultiReceiptItemsGridControl fld_dgcMultiReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MultiPackageReceiptItemsGridControl fld_dgcMultiPackageReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
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
        private DevExpress.XtraEditors.PanelControl fld_panelPackage;
        private DevExpress.XtraEditors.PanelControl fld_panelProduct;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptItemProductPicture1;
        private ItemLookupEdit fld_lkeFK_ICProductID1;
        private ICReceiptItemsGridControl fld_dgcICReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtICReceiptExchangeRate;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountFix;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxAmount;
        private BOSComponent.BOSTextBox fld_txtICReceiptTaxPercent;
        private BOSComponent.BOSTextBox fld_txtICReceiptDiscountPerCent;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSMemoEdit fld_medICReceiptComment;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox fld_txtICReceiptTotalQuantity;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private BOSComponent.BOSLabel bosLabel22;
	}
}
