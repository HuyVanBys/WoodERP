using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WoodPurchaseReceipt.UI
{
	/// <summary>
	/// Summary description for DMWPR100
	/// </summary>
	partial class DMWPR100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMWPR100));
            this.fld_rdgReceiptType = new BOSComponent.BOSRadioGroup(this.components);
            this.fld_panelProduct = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_ICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcICReceiptItems = new BOSERP.Modules.WoodPurchaseReceipt.ICReceiptItemsGridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICReceiptItemProductPicture1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_panelPackage = new DevExpress.XtraEditors.PanelControl();
            this.fld_tabChoocePackingList = new BOSComponent.BOSTabControl(this.components);
            this.fld_xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiPackageReceiptItems = new BOSERP.Modules.WoodPurchaseReceipt.MultiPackageReceiptItemsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiProductReceiptItems = new BOSERP.Modules.WoodPurchaseReceipt.MultiProductReceiptItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMultiReceiptItems = new BOSERP.Modules.WoodPurchaseReceipt.MultiReceiptItemsGridControl();
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
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptDeclarations = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptReceiptType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeWoodTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_medICReceiptComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptDiscountFix = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptDiscountPerCent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptTotalWoodQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptTotalQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICReceiptExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ARSaleContractID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgReceiptType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).BeginInit();
            this.fld_panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeclarations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptReceiptType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalWoodQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_rdgReceiptType
            // 
            this.fld_rdgReceiptType.BOSComment = null;
            this.fld_rdgReceiptType.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_rdgReceiptType.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_rdgReceiptType.BOSDescription = null;
            this.fld_rdgReceiptType.BOSError = null;
            this.fld_rdgReceiptType.BOSFieldGroup = null;
            this.fld_rdgReceiptType.BOSFieldRelation = null;
            this.fld_rdgReceiptType.BOSPrivilege = null;
            this.fld_rdgReceiptType.BOSPropertyName = null;
            resources.ApplyResources(this.fld_rdgReceiptType, "fld_rdgReceiptType");
            this.fld_rdgReceiptType.MenuManager = this.screenToolbar;
            this.fld_rdgReceiptType.Name = "fld_rdgReceiptType";
            this.fld_rdgReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_rdgReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_rdgReceiptType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("fld_rdgReceiptType.Properties.Items"))), resources.GetString("fld_rdgReceiptType.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("fld_rdgReceiptType.Properties.Items2"))), resources.GetString("fld_rdgReceiptType.Properties.Items3"))});
            this.fld_rdgReceiptType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_rdgReceiptType, ((bool)(resources.GetObject("fld_rdgReceiptType.ShowHelp"))));
            this.fld_rdgReceiptType.Tag = "DC";
            this.fld_rdgReceiptType.SelectedIndexChanged += new System.EventHandler(this.fld_rdgReceiptType_SelectedIndexChanged);
            // 
            // fld_panelProduct
            // 
            resources.ApplyResources(this.fld_panelProduct, "fld_panelProduct");
            this.fld_panelProduct.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.fld_panelProduct.Controls.Add(this.fld_dgcICReceiptItems);
            this.fld_panelProduct.Controls.Add(this.bosLabel13);
            this.fld_panelProduct.Controls.Add(this.fld_pteICReceiptItemProductPicture1);
            this.fld_panelProduct.Name = "fld_panelProduct";
            this.ScreenHelper.SetShowHelp(this.fld_panelProduct, ((bool)(resources.GetObject("fld_panelProduct.ShowHelp"))));
            this.fld_panelProduct.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID1
            // 
            resources.ApplyResources(this.fld_lkeFK_ICProductID1, "fld_lkeFK_ICProductID1");
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ICReceiptItems";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICProductID1.Properties.Buttons"))))});
            this.fld_lkeFK_ICProductID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns2"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns4"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns5"))});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID1, ((bool)(resources.GetObject("fld_lkeFK_ICProductID1.ShowHelp"))));
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            this.fld_lkeFK_ICProductID1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID1_KeyUp);
            // 
            // fld_dgcICReceiptItems
            // 
            this.fld_dgcICReceiptItems.AllowDrop = true;
            resources.ApplyResources(this.fld_dgcICReceiptItems, "fld_dgcICReceiptItems");
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
            this.fld_dgcICReceiptItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcICReceiptItems.MainView = this.gridView4;
            this.fld_dgcICReceiptItems.Name = "fld_dgcICReceiptItems";
            this.fld_dgcICReceiptItems.PrintReport = false;
            this.fld_dgcICReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICReceiptItems, ((bool)(resources.GetObject("fld_dgcICReceiptItems.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel13, "bosLabel13");
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, ((bool)(resources.GetObject("bosLabel13.ShowHelp"))));
            // 
            // fld_pteICReceiptItemProductPicture1
            // 
            resources.ApplyResources(this.fld_pteICReceiptItemProductPicture1, "fld_pteICReceiptItemProductPicture1");
            this.fld_pteICReceiptItemProductPicture1.BOSComment = null;
            this.fld_pteICReceiptItemProductPicture1.BOSDataMember = "ICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture1.BOSDataSource = "ICReceiptItems";
            this.fld_pteICReceiptItemProductPicture1.BOSDescription = null;
            this.fld_pteICReceiptItemProductPicture1.BOSError = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldGroup = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldRelation = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPrivilege = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptItemProductPicture1.FileName = null;
            this.fld_pteICReceiptItemProductPicture1.FilePath = null;
            this.fld_pteICReceiptItemProductPicture1.Name = "fld_pteICReceiptItemProductPicture1";
            this.fld_pteICReceiptItemProductPicture1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptItemProductPicture1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteICReceiptItemProductPicture1, ((bool)(resources.GetObject("fld_pteICReceiptItemProductPicture1.ShowHelp"))));
            this.fld_pteICReceiptItemProductPicture1.Tag = "DC";
            // 
            // fld_panelPackage
            // 
            resources.ApplyResources(this.fld_panelPackage, "fld_panelPackage");
            this.fld_panelPackage.Controls.Add(this.fld_tabChoocePackingList);
            this.fld_panelPackage.Controls.Add(this.fld_Lablel);
            this.fld_panelPackage.Controls.Add(this.fld_pteICReceiptItemProductPicture);
            this.fld_panelPackage.Controls.Add(this.fld_lkeFK_ICProductID);
            this.fld_panelPackage.Name = "fld_panelPackage";
            this.ScreenHelper.SetShowHelp(this.fld_panelPackage, ((bool)(resources.GetObject("fld_panelPackage.ShowHelp"))));
            this.fld_panelPackage.Tag = "DC";
            // 
            // fld_tabChoocePackingList
            // 
            resources.ApplyResources(this.fld_tabChoocePackingList, "fld_tabChoocePackingList");
            this.fld_tabChoocePackingList.BOSComment = null;
            this.fld_tabChoocePackingList.BOSDataMember = null;
            this.fld_tabChoocePackingList.BOSDataSource = null;
            this.fld_tabChoocePackingList.BOSDescription = null;
            this.fld_tabChoocePackingList.BOSError = null;
            this.fld_tabChoocePackingList.BOSFieldGroup = null;
            this.fld_tabChoocePackingList.BOSFieldRelation = null;
            this.fld_tabChoocePackingList.BOSPrivilege = null;
            this.fld_tabChoocePackingList.BOSPropertyName = null;
            this.fld_tabChoocePackingList.Name = "fld_tabChoocePackingList";
            this.fld_tabChoocePackingList.Screen = null;
            this.fld_tabChoocePackingList.SelectedTabPage = this.fld_xtraTabPage1;
            this.ScreenHelper.SetShowHelp(this.fld_tabChoocePackingList, ((bool)(resources.GetObject("fld_tabChoocePackingList.ShowHelp"))));
            this.fld_tabChoocePackingList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_xtraTabPage1,
            this.fld_xtraTabPage2,
            this.fld_xtraTabPage3});
            // 
            // fld_xtraTabPage1
            // 
            this.fld_xtraTabPage1.Controls.Add(this.fld_dgcMultiPackageReceiptItems);
            this.fld_xtraTabPage1.Name = "fld_xtraTabPage1";
            this.ScreenHelper.SetShowHelp(this.fld_xtraTabPage1, ((bool)(resources.GetObject("fld_xtraTabPage1.ShowHelp"))));
            resources.ApplyResources(this.fld_xtraTabPage1, "fld_xtraTabPage1");
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
            this.fld_dgcMultiPackageReceiptItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_dgcMultiPackageReceiptItems, "fld_dgcMultiPackageReceiptItems");
            this.fld_dgcMultiPackageReceiptItems.MainView = this.gridView3;
            this.fld_dgcMultiPackageReceiptItems.Name = "fld_dgcMultiPackageReceiptItems";
            this.fld_dgcMultiPackageReceiptItems.PrintReport = false;
            this.fld_dgcMultiPackageReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMultiPackageReceiptItems, ((bool)(resources.GetObject("fld_dgcMultiPackageReceiptItems.ShowHelp"))));
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
            this.ScreenHelper.SetShowHelp(this.fld_xtraTabPage2, ((bool)(resources.GetObject("fld_xtraTabPage2.ShowHelp"))));
            resources.ApplyResources(this.fld_xtraTabPage2, "fld_xtraTabPage2");
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
            this.fld_dgcMultiProductReceiptItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_dgcMultiProductReceiptItems, "fld_dgcMultiProductReceiptItems");
            this.fld_dgcMultiProductReceiptItems.MainView = this.gridView1;
            this.fld_dgcMultiProductReceiptItems.Name = "fld_dgcMultiProductReceiptItems";
            this.fld_dgcMultiProductReceiptItems.PrintReport = false;
            this.fld_dgcMultiProductReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMultiProductReceiptItems, ((bool)(resources.GetObject("fld_dgcMultiProductReceiptItems.ShowHelp"))));
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
            this.ScreenHelper.SetShowHelp(this.fld_xtraTabPage3, ((bool)(resources.GetObject("fld_xtraTabPage3.ShowHelp"))));
            resources.ApplyResources(this.fld_xtraTabPage3, "fld_xtraTabPage3");
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
            this.fld_dgcMultiReceiptItems.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_dgcMultiReceiptItems, "fld_dgcMultiReceiptItems");
            this.fld_dgcMultiReceiptItems.MainView = this.gridView2;
            this.fld_dgcMultiReceiptItems.Name = "fld_dgcMultiReceiptItems";
            this.fld_dgcMultiReceiptItems.PrintReport = false;
            this.fld_dgcMultiReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMultiReceiptItems, ((bool)(resources.GetObject("fld_dgcMultiReceiptItems.ShowHelp"))));
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
            resources.ApplyResources(this.fld_Lablel, "fld_Lablel");
            this.fld_Lablel.Name = "fld_Lablel";
            this.fld_Lablel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Lablel, ((bool)(resources.GetObject("fld_Lablel.ShowHelp"))));
            // 
            // fld_pteICReceiptItemProductPicture
            // 
            resources.ApplyResources(this.fld_pteICReceiptItemProductPicture, "fld_pteICReceiptItemProductPicture");
            this.fld_pteICReceiptItemProductPicture.BOSComment = null;
            this.fld_pteICReceiptItemProductPicture.BOSDataMember = "ICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture.BOSDataSource = "ICReceiptItems";
            this.fld_pteICReceiptItemProductPicture.BOSDescription = null;
            this.fld_pteICReceiptItemProductPicture.BOSError = null;
            this.fld_pteICReceiptItemProductPicture.BOSFieldGroup = null;
            this.fld_pteICReceiptItemProductPicture.BOSFieldRelation = null;
            this.fld_pteICReceiptItemProductPicture.BOSPrivilege = null;
            this.fld_pteICReceiptItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptItemProductPicture.FileName = null;
            this.fld_pteICReceiptItemProductPicture.FilePath = null;
            this.fld_pteICReceiptItemProductPicture.Name = "fld_pteICReceiptItemProductPicture";
            this.fld_pteICReceiptItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptItemProductPicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteICReceiptItemProductPicture, ((bool)(resources.GetObject("fld_pteICReceiptItemProductPicture.ShowHelp"))));
            this.fld_pteICReceiptItemProductPicture.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID
            // 
            resources.ApplyResources(this.fld_lkeFK_ICProductID, "fld_lkeFK_ICProductID");
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
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICProductID.Properties.Buttons"))))});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID.Properties.Columns"), resources.GetString("fld_lkeFK_ICProductID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID.Properties.Columns2"), resources.GetString("fld_lkeFK_ICProductID.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID.Properties.Columns4"), resources.GetString("fld_lkeFK_ICProductID.Properties.Columns5"))});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, ((bool)(resources.GetObject("fld_lkeFK_ICProductID.ShowHelp"))));
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
            this.fld_lkeFK_HREmployeeID.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_HREmployeeID, "fld_lkeFK_HREmployeeID");
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Buttons"))))});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns3"))), global::Localization.SaleOrderLocalizedResources.String, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns6"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns7"))});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.ShowHelp"))));
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
            this.fld_pteICReceiptEmployeePicture.FileName = null;
            this.fld_pteICReceiptEmployeePicture.FilePath = null;
            resources.ApplyResources(this.fld_pteICReceiptEmployeePicture, "fld_pteICReceiptEmployeePicture");
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pteICReceiptEmployeePicture, ((bool)(resources.GetObject("fld_pteICReceiptEmployeePicture.ShowHelp"))));
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
            resources.ApplyResources(this.fld_Lablel2, "fld_Lablel2");
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Lablel2, ((bool)(resources.GetObject("fld_Lablel2.ShowHelp"))));
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = null;
            this.fld_lblLabel7.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel7.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel7.BOSFieldRelation = null;
            this.fld_lblLabel7.BOSPrivilege = null;
            this.fld_lblLabel7.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel7, "fld_lblLabel7");
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel7, ((bool)(resources.GetObject("fld_lblLabel7.ShowHelp"))));
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            resources.ApplyResources(this.fld_Lablel3, "fld_Lablel3");
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_Lablel3, ((bool)(resources.GetObject("fld_Lablel3.ShowHelp"))));
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
            resources.ApplyResources(this.fld_medICReceiptDesc, "fld_medICReceiptDesc");
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICReceiptDesc, ((bool)(resources.GetObject("fld_medICReceiptDesc.ShowHelp"))));
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
            this.fld_lkeFK_ICStockID1.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_ICStockID1, "fld_lkeFK_ICStockID1");
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICStockID1.Properties.Buttons"))))});
            this.fld_lkeFK_ICStockID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICStockID1.Properties.Columns"), resources.GetString("fld_lkeFK_ICStockID1.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_ICStockID1.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_ICStockID1.Properties.Columns3"))), global::Localization.SaleOrderLocalizedResources.String, ((bool)(resources.GetObject("fld_lkeFK_ICStockID1.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_ICStockID1.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICStockID1.Properties.Columns6"), resources.GetString("fld_lkeFK_ICStockID1.Properties.Columns7"))});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICStockID1, ((bool)(resources.GetObject("fld_lkeFK_ICStockID1.ShowHelp"))));
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
            resources.ApplyResources(this.fld_dteICReceiptDate, "fld_dteICReceiptDate");
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteICReceiptDate.Properties.Buttons"))))});
            this.fld_dteICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICReceiptDate, ((bool)(resources.GetObject("fld_dteICReceiptDate.ShowHelp"))));
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
            resources.ApplyResources(this.BOSLabel2, "BOSLabel2");
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.BOSLabel2, ((bool)(resources.GetObject("BOSLabel2.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtICReceiptNo, "fld_txtICReceiptNo");
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptNo, ((bool)(resources.GetObject("fld_txtICReceiptNo.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtICReceiptInvoiceInNo, "fld_txtICReceiptInvoiceInNo");
            this.fld_txtICReceiptInvoiceInNo.Name = "fld_txtICReceiptInvoiceInNo";
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptInvoiceInNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptInvoiceInNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptInvoiceInNo, ((bool)(resources.GetObject("fld_txtICReceiptInvoiceInNo.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtICReceiptPackNo, "fld_txtICReceiptPackNo");
            this.fld_txtICReceiptPackNo.Name = "fld_txtICReceiptPackNo";
            this.fld_txtICReceiptPackNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptPackNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptPackNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptPackNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptPackNo, ((bool)(resources.GetObject("fld_txtICReceiptPackNo.ShowHelp"))));
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
            resources.ApplyResources(this.fld_lkeICReceiptStatus, "fld_lkeICReceiptStatus");
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICReceiptStatus.Properties.Buttons"))))});
            this.fld_lkeICReceiptStatus.Properties.ColumnName = null;
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICReceiptStatus, ((bool)(resources.GetObject("fld_lkeICReceiptStatus.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
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
            resources.ApplyResources(this.fld_dteICReceiptInvoiceInDate, "fld_dteICReceiptInvoiceInDate");
            this.fld_dteICReceiptInvoiceInDate.Name = "fld_dteICReceiptInvoiceInDate";
            this.fld_dteICReceiptInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteICReceiptInvoiceInDate.Properties.Buttons"))))});
            this.fld_dteICReceiptInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptInvoiceInDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICReceiptInvoiceInDate, ((bool)(resources.GetObject("fld_dteICReceiptInvoiceInDate.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
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
            resources.ApplyResources(this.fld_txtICReceiptDeliveryContactName, "fld_txtICReceiptDeliveryContactName");
            this.fld_txtICReceiptDeliveryContactName.Name = "fld_txtICReceiptDeliveryContactName";
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDeliveryContactName.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptDeliveryContactName.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptDeliveryContactName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptDeliveryContactName, ((bool)(resources.GetObject("fld_txtICReceiptDeliveryContactName.ShowHelp"))));
            this.fld_txtICReceiptDeliveryContactName.Tag = "DC";
            // 
            // bosLabel5
            // 
            resources.ApplyResources(this.bosLabel5, "bosLabel5");
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, ((bool)(resources.GetObject("bosLabel5.ShowHelp"))));
            // 
            // bosLabel8
            // 
            resources.ApplyResources(this.bosLabel8, "bosLabel8");
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
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, ((bool)(resources.GetObject("bosLabel8.ShowHelp"))));
            // 
            // fld_txtICReceiptSubTotalCost
            // 
            resources.ApplyResources(this.fld_txtICReceiptSubTotalCost, "fld_txtICReceiptSubTotalCost");
            this.fld_txtICReceiptSubTotalCost.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptSubTotalCost.BOSDataMember = "ICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSubTotalCost.BOSDescription = null;
            this.fld_txtICReceiptSubTotalCost.BOSError = null;
            this.fld_txtICReceiptSubTotalCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptSubTotalCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptSubTotalCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptSubTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSubTotalCost.Name = "fld_txtICReceiptSubTotalCost";
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptSubTotalCost.Properties.Mask.EditMask");
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptSubTotalCost.Properties.Mask.MaskType")));
            this.fld_txtICReceiptSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptSubTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptSubTotalCost.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptSubTotalCost, ((bool)(resources.GetObject("fld_txtICReceiptSubTotalCost.ShowHelp"))));
            this.fld_txtICReceiptSubTotalCost.Tag = "DC";
            // 
            // fld_txtICReceiptTotalCost
            // 
            resources.ApplyResources(this.fld_txtICReceiptTotalCost, "fld_txtICReceiptTotalCost");
            this.fld_txtICReceiptTotalCost.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTotalCost.BOSDataMember = "ICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalCost.BOSDescription = null;
            this.fld_txtICReceiptTotalCost.BOSError = null;
            this.fld_txtICReceiptTotalCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTotalCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTotalCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTotalCost.Name = "fld_txtICReceiptTotalCost";
            this.fld_txtICReceiptTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTotalCost.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptTotalCost.Properties.Mask.EditMask");
            this.fld_txtICReceiptTotalCost.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptTotalCost.Properties.Mask.MaskType")));
            this.fld_txtICReceiptTotalCost.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptTotalCost.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptTotalCost.Properties.ReadOnly = true;
            this.fld_txtICReceiptTotalCost.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTotalCost, ((bool)(resources.GetObject("fld_txtICReceiptTotalCost.ShowHelp"))));
            this.fld_txtICReceiptTotalCost.Tag = "DC";
            // 
            // bosLabel11
            // 
            resources.ApplyResources(this.bosLabel11, "bosLabel11");
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, ((bool)(resources.GetObject("bosLabel11.ShowHelp"))));
            // 
            // bosLabel12
            // 
            resources.ApplyResources(this.bosLabel12, "bosLabel12");
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, ((bool)(resources.GetObject("bosLabel12.ShowHelp"))));
            // 
            // fld_txtICReceiptShippingFee
            // 
            resources.ApplyResources(this.fld_txtICReceiptShippingFee, "fld_txtICReceiptShippingFee");
            this.fld_txtICReceiptShippingFee.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingFee.BOSDataMember = "ICReceiptShippingFees";
            this.fld_txtICReceiptShippingFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingFee.BOSDescription = null;
            this.fld_txtICReceiptShippingFee.BOSError = null;
            this.fld_txtICReceiptShippingFee.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingFee.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingFee.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingFee.Name = "fld_txtICReceiptShippingFee";
            this.fld_txtICReceiptShippingFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingFee.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptShippingFee.Properties.Mask.EditMask");
            this.fld_txtICReceiptShippingFee.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptShippingFee.Properties.Mask.MaskType")));
            this.fld_txtICReceiptShippingFee.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptShippingFee.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptShippingFee.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptShippingFee, ((bool)(resources.GetObject("fld_txtICReceiptShippingFee.ShowHelp"))));
            this.fld_txtICReceiptShippingFee.Tag = "DC";
            this.fld_txtICReceiptShippingFee.Validated += new System.EventHandler(this.fld_txtICReceiptShippingFees_Validated);
            // 
            // fld_txtICReceiptShippingExtraFee
            // 
            resources.ApplyResources(this.fld_txtICReceiptShippingExtraFee, "fld_txtICReceiptShippingExtraFee");
            this.fld_txtICReceiptShippingExtraFee.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingExtraFee.BOSDataMember = "ICReceiptShippingExtraFees";
            this.fld_txtICReceiptShippingExtraFee.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptShippingExtraFee.BOSDescription = null;
            this.fld_txtICReceiptShippingExtraFee.BOSError = null;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingExtraFee.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingExtraFee.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptShippingExtraFee.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptShippingExtraFee.Name = "fld_txtICReceiptShippingExtraFee";
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptShippingExtraFee.Properties.Mask.EditMask");
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptShippingExtraFee.Properties.Mask.MaskType")));
            this.fld_txtICReceiptShippingExtraFee.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptShippingExtraFee.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptShippingExtraFee.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptShippingExtraFee, ((bool)(resources.GetObject("fld_txtICReceiptShippingExtraFee.ShowHelp"))));
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleContractID);
            this.bosPanel1.Controls.Add(this.bosLabel26);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosPanel1.Controls.Add(this.bosLabel25);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel29);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDeclarations);
            this.bosPanel1.Controls.Add(this.bosLabel22);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECountryID);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptReceiptType);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeWoodTypeID);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_rdgReceiptType);
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
            this.bosPanel1.Controls.Add(this.bosLabel23);
            this.bosPanel1.Controls.Add(this.bosLabel17);
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
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptContainerNo);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptDeliveryContactName);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel24);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTotalWoodQty);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptTotalQty);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptExchangeRate);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACAssObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            resources.ApplyResources(this.fld_lkeFK_ACAssObjectID, "fld_lkeFK_ACAssObjectID");
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ACAssObjectID.Properties.Buttons"))))});
            this.fld_lkeFK_ACAssObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACAssObjectID.Properties.Columns"), resources.GetString("fld_lkeFK_ACAssObjectID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_ACAssObjectID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_ACAssObjectID.Properties.Columns3"))), global::Localization.SaleOrderLocalizedResources.String, ((bool)(resources.GetObject("fld_lkeFK_ACAssObjectID.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_ACAssObjectID.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACAssObjectID.Properties.Columns6"), resources.GetString("fld_lkeFK_ACAssObjectID.Properties.Columns7"))});
            this.fld_lkeFK_ACAssObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACAssObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACAssObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACAssObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            this.fld_lkeFK_ACAssObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACAssObjectID_CloseUp);
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            resources.ApplyResources(this.fld_lkeFK_ACObjectID, "fld_lkeFK_ACObjectID");
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Buttons"))))});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns3"))), global::Localization.SaleOrderLocalizedResources.String, ((bool)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_ACObjectID.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns6"), resources.GetString("fld_lkeFK_ACObjectID.Properties.Columns7"))});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel25, "bosLabel25");
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel25, ((bool)(resources.GetObject("bosLabel25.ShowHelp"))));
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
            this.bosLookupEdit1.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit1.CurrentDisplayText = null;
            resources.ApplyResources(this.bosLookupEdit1, "bosLookupEdit1");
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("bosLookupEdit1.Properties.Buttons"))))});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("bosLookupEdit1.Properties.Columns"), resources.GetString("bosLookupEdit1.Properties.Columns1"))});
            this.bosLookupEdit1.Properties.DisplayMember = "MMBatchProductNo";
            this.bosLookupEdit1.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "MMBatchProductID";
            this.bosLookupEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLookupEdit1, ((bool)(resources.GetObject("bosLookupEdit1.ShowHelp"))));
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel10.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel10.BOSDataSource = "ARInvoices";
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel10.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel10.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel10.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel10, "fld_lblLabel10");
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.fld_lblLabel10.Tag = global::Localization.SaleOrderLocalizedResources.String;
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
            resources.ApplyResources(this.bosLabel29, "bosLabel29");
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, ((bool)(resources.GetObject("bosLabel29.ShowHelp"))));
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox2.BOSDataMember = "ICReceiptPONo";
            this.bosTextBox2.BOSDataSource = "ICReceipts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.bosTextBox2, "bosTextBox2");
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat")));
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, ((bool)(resources.GetObject("bosTextBox2.ShowHelp"))));
            this.bosTextBox2.Tag = "DC";
            // 
            // fld_txtICReceiptDeclarations
            // 
            this.fld_txtICReceiptDeclarations.BOSComment = null;
            this.fld_txtICReceiptDeclarations.BOSDataMember = "ICReceiptDeclarations";
            this.fld_txtICReceiptDeclarations.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDeclarations.BOSDescription = null;
            this.fld_txtICReceiptDeclarations.BOSError = null;
            this.fld_txtICReceiptDeclarations.BOSFieldGroup = null;
            this.fld_txtICReceiptDeclarations.BOSFieldRelation = null;
            this.fld_txtICReceiptDeclarations.BOSPrivilege = null;
            this.fld_txtICReceiptDeclarations.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtICReceiptDeclarations, "fld_txtICReceiptDeclarations");
            this.fld_txtICReceiptDeclarations.Name = "fld_txtICReceiptDeclarations";
            this.fld_txtICReceiptDeclarations.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDeclarations.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDeclarations.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDeclarations.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDeclarations.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptDeclarations.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptDeclarations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptDeclarations, ((bool)(resources.GetObject("fld_txtICReceiptDeclarations.ShowHelp"))));
            this.fld_txtICReceiptDeclarations.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel22, "bosLabel22");
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, ((bool)(resources.GetObject("bosLabel22.ShowHelp"))));
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = false;
            this.fld_lkeFK_GECountryID.BOSComment = null;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID.BOSFieldParent = null;
            this.fld_lkeFK_GECountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GECountryID, "fld_lkeFK_GECountryID");
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GECountryID.Properties.Buttons"))))});
            this.fld_lkeFK_GECountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECountryID.Properties.Columns"), resources.GetString("fld_lkeFK_GECountryID.Properties.Columns1"))});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID, ((bool)(resources.GetObject("fld_lkeFK_GECountryID.ShowHelp"))));
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.Validated += new System.EventHandler(this.fld_lkeICReceiptProductOriginCombo_Validated);
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
            resources.ApplyResources(this.bosLabel21, "bosLabel21");
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, ((bool)(resources.GetObject("bosLabel21.ShowHelp"))));
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_lkeFK_ICProductAttributeTTMTID, "fld_lkeFK_ICProductAttributeTTMTID");
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons"))))});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns"), resources.GetString("fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns1"))});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, ((bool)(resources.GetObject("fld_lkeFK_ICProductAttributeTTMTID.ShowHelp"))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.Validated += new System.EventHandler(this.fld_lkeICReceiptProductFSCCombo_Validated);
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
            resources.ApplyResources(this.bosLabel19, "bosLabel19");
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, ((bool)(resources.GetObject("bosLabel19.ShowHelp"))));
            // 
            // fld_lkeICReceiptReceiptType
            // 
            this.fld_lkeICReceiptReceiptType.BOSAllowAddNew = false;
            this.fld_lkeICReceiptReceiptType.BOSAllowDummy = false;
            this.fld_lkeICReceiptReceiptType.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSDataMember = "ICReceiptReceiptType";
            this.fld_lkeICReceiptReceiptType.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptReceiptType.BOSDescription = null;
            this.fld_lkeICReceiptReceiptType.BOSError = null;
            this.fld_lkeICReceiptReceiptType.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptReceiptType.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeICReceiptReceiptType, "fld_lkeICReceiptReceiptType");
            this.fld_lkeICReceiptReceiptType.Name = "fld_lkeICReceiptReceiptType";
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICReceiptReceiptType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICReceiptReceiptType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICReceiptReceiptType.Properties.Buttons"))))});
            this.fld_lkeICReceiptReceiptType.Properties.ColumnName = null;
            this.fld_lkeICReceiptReceiptType.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeICReceiptReceiptType.Properties.PopupWidth = 40;
            this.fld_lkeICReceiptReceiptType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICReceiptReceiptType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICReceiptReceiptType, ((bool)(resources.GetObject("fld_lkeICReceiptReceiptType.ShowHelp"))));
            this.fld_lkeICReceiptReceiptType.Tag = "DC";
            this.fld_lkeICReceiptReceiptType.EditValueChanged += new System.EventHandler(this.fld_lkeReceiptPurchaseTypeCombo_EditValueChanged);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel18, "bosLabel18");
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, ((bool)(resources.GetObject("bosLabel18.ShowHelp"))));
            this.bosLabel18.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // fld_lkeFK_ICProductAttributeWoodTypeID
            // 
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_ICProductAttributeWoodTypeID, "fld_lkeFK_ICProductAttributeWoodTypeID");
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Name = "fld_lkeFK_ICProductAttributeWoodTypeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Buttons"))))});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns"), resources.GetString("fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns2"), resources.GetString("fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns3"))});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeWoodTypeID, ((bool)(resources.GetObject("fld_lkeFK_ICProductAttributeWoodTypeID.ShowHelp"))));
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Validated += new System.EventHandler(this.fld_lkeFK_ADMatchCodeIDPaintType_Validated);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeICProductIdentifyWoodType_QueryPopUp);
            // 
            // bosLine1
            // 
            resources.ApplyResources(this.bosLine1, "bosLine1");
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
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
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
            resources.ApplyResources(this.fld_medICReceiptComment, "fld_medICReceiptComment");
            this.fld_medICReceiptComment.MenuManager = this.screenToolbar;
            this.fld_medICReceiptComment.Name = "fld_medICReceiptComment";
            this.fld_medICReceiptComment.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICReceiptComment, ((bool)(resources.GetObject("fld_medICReceiptComment.ShowHelp"))));
            this.fld_medICReceiptComment.Tag = "DC";
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
            resources.ApplyResources(this.bosLabel20, "bosLabel20");
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel20, ((bool)(resources.GetObject("bosLabel20.ShowHelp"))));
            // 
            // fld_tabReceiptItems
            // 
            resources.ApplyResources(this.fld_tabReceiptItems, "fld_tabReceiptItems");
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.ScreenHelper.SetShowHelp(this.fld_tabReceiptItems, ((bool)(resources.GetObject("fld_tabReceiptItems.ShowHelp"))));
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems,
            this.fld_tabPageDocumentEntrys});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_panelProduct);
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_panelPackage);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageReceiptItems, ((bool)(resources.GetObject("fld_tabPageReceiptItems.ShowHelp"))));
            resources.ApplyResources(this.fld_tabPageReceiptItems, "fld_tabPageReceiptItems");
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.ScreenHelper.SetShowHelp(this.fld_tabPageDocumentEntrys, ((bool)(resources.GetObject("fld_tabPageDocumentEntrys.ShowHelp"))));
            resources.ApplyResources(this.fld_tabPageDocumentEntrys, "fld_tabPageDocumentEntrys");
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcACDocumentEntrys.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_dgcACDocumentEntrys, "fld_dgcACDocumentEntrys");
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcACDocumentEntrys, ((bool)(resources.GetObject("fld_dgcACDocumentEntrys.ShowHelp"))));
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
            this.fld_lkeFK_GECurrencyID.BOSError = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = null;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = null;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = null;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = null;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_GECurrencyID, "fld_lkeFK_GECurrencyID");
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_GECurrencyID.Properties.Buttons"))))});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns"), resources.GetString("fld_lkeFK_GECurrencyID.Properties.Columns1"))});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECurrencyID, ((bool)(resources.GetObject("fld_lkeFK_GECurrencyID.ShowHelp"))));
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // fld_txtICReceiptDiscountFix
            // 
            resources.ApplyResources(this.fld_txtICReceiptDiscountFix, "fld_txtICReceiptDiscountFix");
            this.fld_txtICReceiptDiscountFix.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountFix.BOSDataMember = "ICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountFix.BOSDescription = null;
            this.fld_txtICReceiptDiscountFix.BOSError = null;
            this.fld_txtICReceiptDiscountFix.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountFix.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountFix.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountFix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountFix.Name = "fld_txtICReceiptDiscountFix";
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountFix.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptDiscountFix.Properties.Mask.EditMask");
            this.fld_txtICReceiptDiscountFix.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptDiscountFix.Properties.Mask.MaskType")));
            this.fld_txtICReceiptDiscountFix.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptDiscountFix.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptDiscountFix.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptDiscountFix, ((bool)(resources.GetObject("fld_txtICReceiptDiscountFix.ShowHelp"))));
            this.fld_txtICReceiptDiscountFix.Tag = "DC";
            this.fld_txtICReceiptDiscountFix.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountFix_Validated);
            // 
            // bosLabel23
            // 
            this.bosLabel23.BOSComment = null;
            this.bosLabel23.BOSDataMember = null;
            this.bosLabel23.BOSDataSource = null;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = null;
            this.bosLabel23.BOSFieldRelation = null;
            this.bosLabel23.BOSPrivilege = null;
            this.bosLabel23.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel23, "bosLabel23");
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, ((bool)(resources.GetObject("bosLabel23.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel17, "bosLabel17");
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, ((bool)(resources.GetObject("bosLabel17.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel15, "bosLabel15");
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, ((bool)(resources.GetObject("bosLabel15.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel16, "bosLabel16");
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, ((bool)(resources.GetObject("bosLabel16.ShowHelp"))));
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
            resources.ApplyResources(this.bosLabel14, "bosLabel14");
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, ((bool)(resources.GetObject("bosLabel14.ShowHelp"))));
            // 
            // fld_txtICReceiptTaxAmount
            // 
            resources.ApplyResources(this.fld_txtICReceiptTaxAmount, "fld_txtICReceiptTaxAmount");
            this.fld_txtICReceiptTaxAmount.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxAmount.BOSDataMember = "ICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxAmount.BOSDescription = null;
            this.fld_txtICReceiptTaxAmount.BOSError = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldGroup = null;
            this.fld_txtICReceiptTaxAmount.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxAmount.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxAmount.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxAmount.Name = "fld_txtICReceiptTaxAmount";
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxAmount.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptTaxAmount.Properties.Mask.EditMask");
            this.fld_txtICReceiptTaxAmount.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptTaxAmount.Properties.Mask.MaskType")));
            this.fld_txtICReceiptTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptTaxAmount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptTaxAmount.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTaxAmount, ((bool)(resources.GetObject("fld_txtICReceiptTaxAmount.ShowHelp"))));
            this.fld_txtICReceiptTaxAmount.Tag = "DC";
            this.fld_txtICReceiptTaxAmount.Validated += new System.EventHandler(this.fld_txtICReceiptTaxAmount_Validated);
            // 
            // fld_txtICReceiptTaxPercent
            // 
            resources.ApplyResources(this.fld_txtICReceiptTaxPercent, "fld_txtICReceiptTaxPercent");
            this.fld_txtICReceiptTaxPercent.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxPercent.BOSDataMember = "ICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTaxPercent.BOSDescription = null;
            this.fld_txtICReceiptTaxPercent.BOSError = null;
            this.fld_txtICReceiptTaxPercent.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxPercent.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxPercent.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptTaxPercent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptTaxPercent.Name = "fld_txtICReceiptTaxPercent";
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptTaxPercent.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptTaxPercent.Properties.Mask.EditMask");
            this.fld_txtICReceiptTaxPercent.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptTaxPercent.Properties.Mask.MaskType")));
            this.fld_txtICReceiptTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptTaxPercent.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptTaxPercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTaxPercent, ((bool)(resources.GetObject("fld_txtICReceiptTaxPercent.ShowHelp"))));
            this.fld_txtICReceiptTaxPercent.Tag = "DC";
            this.fld_txtICReceiptTaxPercent.Validated += new System.EventHandler(this.fld_txtICReceiptTaxPercent_Validated);
            // 
            // fld_txtICReceiptDiscountPerCent
            // 
            resources.ApplyResources(this.fld_txtICReceiptDiscountPerCent, "fld_txtICReceiptDiscountPerCent");
            this.fld_txtICReceiptDiscountPerCent.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountPerCent.BOSDataMember = "ICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptDiscountPerCent.BOSDescription = null;
            this.fld_txtICReceiptDiscountPerCent.BOSError = null;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountPerCent.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountPerCent.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtICReceiptDiscountPerCent.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptDiscountPerCent.Name = "fld_txtICReceiptDiscountPerCent";
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptDiscountPerCent.Properties.Mask.EditMask");
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("fld_txtICReceiptDiscountPerCent.Properties.Mask.MaskType")));
            this.fld_txtICReceiptDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptDiscountPerCent.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptDiscountPerCent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptDiscountPerCent, ((bool)(resources.GetObject("fld_txtICReceiptDiscountPerCent.ShowHelp"))));
            this.fld_txtICReceiptDiscountPerCent.Tag = "DC";
            this.fld_txtICReceiptDiscountPerCent.Validated += new System.EventHandler(this.fld_txtICReceiptDiscountPercent_Validated);
            // 
            // fld_txtICReceiptContainerNo
            // 
            this.fld_txtICReceiptContainerNo.BOSComment = null;
            this.fld_txtICReceiptContainerNo.BOSDataMember = "ICReceiptContainerNo";
            this.fld_txtICReceiptContainerNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptContainerNo.BOSDescription = null;
            this.fld_txtICReceiptContainerNo.BOSError = null;
            this.fld_txtICReceiptContainerNo.BOSFieldGroup = null;
            this.fld_txtICReceiptContainerNo.BOSFieldRelation = null;
            this.fld_txtICReceiptContainerNo.BOSPrivilege = null;
            this.fld_txtICReceiptContainerNo.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtICReceiptContainerNo, "fld_txtICReceiptContainerNo");
            this.fld_txtICReceiptContainerNo.Name = "fld_txtICReceiptContainerNo";
            this.fld_txtICReceiptContainerNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptContainerNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptContainerNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptContainerNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptContainerNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptContainerNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptContainerNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptContainerNo, ((bool)(resources.GetObject("fld_txtICReceiptContainerNo.ShowHelp"))));
            this.fld_txtICReceiptContainerNo.Tag = "DC";
            this.fld_txtICReceiptContainerNo.EditValueChanged += new System.EventHandler(this.fld_txtICReceiptContainerNo_EditValueChanged);
            this.fld_txtICReceiptContainerNo.Validated += new System.EventHandler(this.fld_txtICReceiptContainerNo_Validated);
            // 
            // bosLabel9
            // 
            resources.ApplyResources(this.bosLabel9, "bosLabel9");
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, ((bool)(resources.GetObject("bosLabel9.ShowHelp"))));
            // 
            // bosLabel7
            // 
            resources.ApplyResources(this.bosLabel7, "bosLabel7");
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, ((bool)(resources.GetObject("bosLabel7.ShowHelp"))));
            // 
            // bosLabel24
            // 
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel24, "bosLabel24");
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel24, ((bool)(resources.GetObject("bosLabel24.ShowHelp"))));
            // 
            // fld_txtICReceiptTotalWoodQty
            // 
            this.fld_txtICReceiptTotalWoodQty.BOSComment = null;
            this.fld_txtICReceiptTotalWoodQty.BOSDataMember = "ICReceiptTotalWoodQty";
            this.fld_txtICReceiptTotalWoodQty.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalWoodQty.BOSDescription = null;
            this.fld_txtICReceiptTotalWoodQty.BOSError = null;
            this.fld_txtICReceiptTotalWoodQty.BOSFieldGroup = null;
            this.fld_txtICReceiptTotalWoodQty.BOSFieldRelation = null;
            this.fld_txtICReceiptTotalWoodQty.BOSPrivilege = null;
            this.fld_txtICReceiptTotalWoodQty.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtICReceiptTotalWoodQty, "fld_txtICReceiptTotalWoodQty");
            this.fld_txtICReceiptTotalWoodQty.Name = "fld_txtICReceiptTotalWoodQty";
            this.fld_txtICReceiptTotalWoodQty.Properties.EditFormat.FormatString = "{0:0.####}";
            this.fld_txtICReceiptTotalWoodQty.Properties.Mask.EditMask = resources.GetString("fld_txtICReceiptTotalWoodQty.Properties.Mask.EditMask");
            this.fld_txtICReceiptTotalWoodQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTotalWoodQty, ((bool)(resources.GetObject("fld_txtICReceiptTotalWoodQty.ShowHelp"))));
            this.fld_txtICReceiptTotalWoodQty.Tag = "DC";
            // 
            // fld_txtICReceiptTotalQty
            // 
            this.fld_txtICReceiptTotalQty.BOSComment = null;
            this.fld_txtICReceiptTotalQty.BOSDataMember = "ICReceiptTotalQty";
            this.fld_txtICReceiptTotalQty.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptTotalQty.BOSDescription = null;
            this.fld_txtICReceiptTotalQty.BOSError = null;
            this.fld_txtICReceiptTotalQty.BOSFieldGroup = null;
            this.fld_txtICReceiptTotalQty.BOSFieldRelation = null;
            this.fld_txtICReceiptTotalQty.BOSPrivilege = null;
            this.fld_txtICReceiptTotalQty.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_txtICReceiptTotalQty, "fld_txtICReceiptTotalQty");
            this.fld_txtICReceiptTotalQty.Name = "fld_txtICReceiptTotalQty";
            this.fld_txtICReceiptTotalQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptTotalQty, ((bool)(resources.GetObject("fld_txtICReceiptTotalQty.ShowHelp"))));
            this.fld_txtICReceiptTotalQty.Tag = "DC";
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
            resources.ApplyResources(this.fld_txtICReceiptExchangeRate, "fld_txtICReceiptExchangeRate");
            this.fld_txtICReceiptExchangeRate.Name = "fld_txtICReceiptExchangeRate";
            this.fld_txtICReceiptExchangeRate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICReceiptExchangeRate, ((bool)(resources.GetObject("fld_txtICReceiptExchangeRate.ShowHelp"))));
            this.fld_txtICReceiptExchangeRate.Tag = "DC";
            this.fld_txtICReceiptExchangeRate.Validated += new System.EventHandler(this.fld_txtICReceiptExchangeRate_Validated);
            // 
            // fld_lkeFK_ARSaleContractID
            // 
            this.fld_lkeFK_ARSaleContractID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleContractID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleContractID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSDataMember = "FK_APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ARSaleContractID.BOSDescription = null;
            this.fld_lkeFK_ARSaleContractID.BOSError = null;
            this.fld_lkeFK_ARSaleContractID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleContractID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.fld_lkeFK_ARSaleContractID, "fld_lkeFK_ARSaleContractID");
            this.fld_lkeFK_ARSaleContractID.Name = "fld_lkeFK_ARSaleContractID";
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleContractID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ARSaleContractID.Properties.Buttons"))))});
            this.fld_lkeFK_ARSaleContractID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleContractID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARSaleContractID.Properties.Columns"), resources.GetString("fld_lkeFK_ARSaleContractID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARSaleContractID.Properties.Columns2"), resources.GetString("fld_lkeFK_ARSaleContractID.Properties.Columns3"))});
            this.fld_lkeFK_ARSaleContractID.Properties.DisplayMember = "APPurchaseContractNo";
            this.fld_lkeFK_ARSaleContractID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ARSaleContractID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleContractID.Properties.ValueMember = "APPurchaseContractID";
            this.fld_lkeFK_ARSaleContractID.Screen = null;
            this.fld_lkeFK_ARSaleContractID.Tag = "DC";
            // 
            // bosLabel26
            // 
            this.bosLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel26.Appearance.Options.UseBackColor = true;
            this.bosLabel26.Appearance.Options.UseForeColor = true;
            this.bosLabel26.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSDescription = null;
            this.bosLabel26.BOSError = null;
            this.bosLabel26.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel26.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            resources.ApplyResources(this.bosLabel26, "bosLabel26");
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Tag = global::Localization.SaleOrderLocalizedResources.String;
            // 
            // DMWPR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMWPR100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_rdgReceiptType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_panelProduct)).EndInit();
            this.fld_panelProduct.ResumeLayout(false);
            this.fld_panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptDeclarations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptReceiptType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalWoodQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptTotalQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleContractID.Properties)).EndInit();
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
        private ICReceiptItemsGridControl fld_dgcICReceiptItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSRadioGroup fld_rdgReceiptType;
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
        private BOSComponent.BOSTextBox fld_txtICReceiptTotalQty;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID1;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptReceiptType;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeWoodTypeID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSTextBox fld_txtICReceiptDeclarations;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtICReceiptTotalWoodQty;
        private BOSComponent.BOSTextBox fld_txtICReceiptContainerNo;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleContractID;
        private BOSComponent.BOSLabel bosLabel26;
	}
}
