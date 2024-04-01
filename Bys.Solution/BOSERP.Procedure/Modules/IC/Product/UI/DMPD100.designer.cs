using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Product.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    partial class DMPD100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPD100));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabProducts = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductContainerDetails = new BOSERP.Modules.Product.ICProductContainerDetailsGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl6 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductPackingDetails = new BOSERP.Modules.Product.ICProductPackingDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_pbxConverSize = new System.Windows.Forms.PictureBox();
            this.bosMemoEdit2 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel40 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductQtyInBox = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel39 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel38 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductPurchaseType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductLeadTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductFormulaPriceConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeProductParentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductBlock = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductDepth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductDiameter = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductRadius = new BOSComponent.BOSTextBox(this.components);
            this.fld_ccbeFinishing = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.fld_ccbeColor = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_ccbeWoodType = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductPaintNoOfManufacture = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICProductIdentifyWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_pnlOtherAttribute = new BOSComponent.BOSPanel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductOtherSize = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_kleICProductIdentifyColor = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel41 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductTrademark = new BOSComponent.BOSLookupEdit(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fld_txtICProductImageFile = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkHasComponent = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductCarcassID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkCarcass = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.bosCheckEdit1 = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtICProductStorageDay = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductTemplateType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnAddProductImageDefault = new BOSComponent.BOSButton(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_lkeICProductOrigin = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductLockedPurchaseOrder = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductOriginOfProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductWorkType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductBarCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductCustomerNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbl5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNoOfOldSys = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMHTold = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductName2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel42 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductCollection = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkShowHistoryBranchPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lnkEditPurchasePrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lnkOpenBranchPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkEditPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabComponent = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductComponents = new BOSERP.Modules.Product.ICProductComponentGridControl();
            this.fld_btnAddProductComponentItem = new BOSComponent.BOSButton(this.components);
            this.fld_tabAccountStockHistory = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabProductTask = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabWork = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductWorkItemsGridControl = new BOSERP.Modules.Product.ICProductWorkItemsGridControl();
            this.fld_btnAddProductWork = new BOSComponent.BOSButton(this.components);
            this.fld_tabMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductWorkItemMaterialsGridControl = new BOSERP.Modules.Product.ICProductWorkItemMaterialsGridControl();
            this.fld_tabAsset = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductWorkItemAssetsGridControl = new BOSERP.Modules.Product.ICProductWorkItemAssetsGridControl();
            this.fld_tabTask = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTasksGridControl = new BOSERP.Modules.Product.ICProductTasksGridControl();
            this.fld_tabBatchProductItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMBatchProductItems = new BOSERP.Modules.Product.MMBatchProductItemGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductImage = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductImagesGridControl = new BOSERP.Modules.Product.ICProductImagesGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductDetails = new BOSERP.Modules.Product.ICProductDetailGridControl();
            this.AddProductDetail = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ACAccountRevenueHinterLandID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel37 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountDiscountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountCostPriceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueInternalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabProductMeasureUnits = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProductMeasureUnit = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.Product.ICProductMeasureUnitsGridControl();
            this.fld_tabProductTemplete = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTemplates = new BOSERP.Modules.Product.ProductTemplatesGridControl();
            this.fld_tabBranch = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductBranchs = new BOSERP.Modules.Product.ICProductBranchGridControl();
            this.fld_tabTolenrance = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTolenrances = new BOSERP.Modules.Product.ICProductTolenrancesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductCustomers = new BOSERP.Modules.Product.ICProductCustomerGridControl();
            this.gridView53 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProducts)).BeginInit();
            this.fld_tabProducts.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductContainerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).BeginInit();
            this.bosGroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pbxConverSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductQtyInBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductRadius.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeFinishing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPaintNoOfManufacture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).BeginInit();
            this.fld_pnlOtherAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_fld_bedICProductAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductOtherSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTrademark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductImageFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHasComponent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductCarcassID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCarcass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTemplateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOrigin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductWorkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCustomerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCollection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkShowHistoryBranchPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            this.fld_tabComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductComponents)).BeginInit();
            this.fld_tabAccountStockHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).BeginInit();
            this.fld_tabProductTask.SuspendLayout();
            this.fld_tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemsGridControl)).BeginInit();
            this.fld_tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemMaterialsGridControl)).BeginInit();
            this.fld_tabAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemAssetsGridControl)).BeginInit();
            this.fld_tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTasksGridControl)).BeginInit();
            this.fld_tabBatchProductItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItems)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductImagesGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            this.fld_tabProductMeasureUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            this.fld_tabProductTemplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTemplates)).BeginInit();
            this.fld_tabBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductBranchs)).BeginInit();
            this.fld_tabTolenrance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView53)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseFont = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = "";
            this.fld_lblLabel11.BOSDataMember = "";
            this.fld_lblLabel11.BOSDataSource = "";
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = "";
            this.fld_lblLabel11.BOSFieldRelation = "";
            this.fld_lblLabel11.BOSPrivilege = "";
            this.fld_lblLabel11.BOSPropertyName = "";
            this.fld_lblLabel11.Location = new System.Drawing.Point(363, 414);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 0;
            this.fld_lblLabel11.Tag = "";
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
            this.bosPanel1.Controls.Add(this.fld_tabProducts);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1311, 972);
            this.bosPanel1.TabIndex = 333;
            // 
            // fld_tabProducts
            // 
            this.fld_tabProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProducts.BOSComment = null;
            this.fld_tabProducts.BOSDataMember = null;
            this.fld_tabProducts.BOSDataSource = null;
            this.fld_tabProducts.BOSDescription = null;
            this.fld_tabProducts.BOSError = null;
            this.fld_tabProducts.BOSFieldGroup = null;
            this.fld_tabProducts.BOSFieldRelation = null;
            this.fld_tabProducts.BOSPrivilege = null;
            this.fld_tabProducts.BOSPropertyName = null;
            this.fld_tabProducts.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProducts.Name = "fld_tabProducts";
            this.fld_tabProducts.Screen = null;
            this.fld_tabProducts.SelectedTabPage = this.fld_tabInfomation;
            this.fld_tabProducts.Size = new System.Drawing.Size(1311, 969);
            this.fld_tabProducts.TabIndex = 0;
            this.fld_tabProducts.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabInfomation,
            this.fld_tabComponent,
            this.fld_tabAccountStockHistory,
            this.fld_tabProductMeasureUnits,
            this.fld_tabProductTemplete,
            this.fld_tabBranch,
            this.fld_tabTolenrance,
            this.xtraTabPage3});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.Controls.Add(this.bosGroupControl2);
            this.fld_tabInfomation.Controls.Add(this.bosGroupControl6);
            this.fld_tabInfomation.Controls.Add(this.bosGroupControl3);
            this.fld_tabInfomation.Controls.Add(this.fld_grcGroupControl5);
            this.fld_tabInfomation.Controls.Add(this.fld_grcGroupControl1);
            this.fld_tabInfomation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(1309, 944);
            this.fld_tabInfomation.Text = "Thông tin";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcICProductContainerDetails);
            this.bosGroupControl2.Location = new System.Drawing.Point(230, 606);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(198, 335);
            this.bosGroupControl2.TabIndex = 3;
            this.bosGroupControl2.Text = "Thông tin số lượng Cont";
            // 
            // fld_dgcICProductContainerDetails
            // 
            this.fld_dgcICProductContainerDetails.AllowDrop = true;
            this.fld_dgcICProductContainerDetails.BOSComment = null;
            this.fld_dgcICProductContainerDetails.BOSDataMember = null;
            this.fld_dgcICProductContainerDetails.BOSDataSource = "ICProductContainerDetails";
            this.fld_dgcICProductContainerDetails.BOSDescription = null;
            this.fld_dgcICProductContainerDetails.BOSError = null;
            this.fld_dgcICProductContainerDetails.BOSFieldGroup = null;
            this.fld_dgcICProductContainerDetails.BOSFieldRelation = null;
            this.fld_dgcICProductContainerDetails.BOSGridType = null;
            this.fld_dgcICProductContainerDetails.BOSPrivilege = null;
            this.fld_dgcICProductContainerDetails.BOSPropertyName = null;
            this.fld_dgcICProductContainerDetails.CommodityType = "";
            this.fld_dgcICProductContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductContainerDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductContainerDetails.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductContainerDetails.MainView = this.gridView3;
            this.fld_dgcICProductContainerDetails.Name = "fld_dgcICProductContainerDetails";
            this.fld_dgcICProductContainerDetails.PrintReport = false;
            this.fld_dgcICProductContainerDetails.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductContainerDetails, true);
            this.fld_dgcICProductContainerDetails.Size = new System.Drawing.Size(194, 310);
            this.fld_dgcICProductContainerDetails.TabIndex = 1;
            this.fld_dgcICProductContainerDetails.Tag = "DC";
            this.fld_dgcICProductContainerDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcICProductContainerDetails;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // bosGroupControl6
            // 
            this.bosGroupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bosGroupControl6.BOSComment = null;
            this.bosGroupControl6.BOSDataMember = null;
            this.bosGroupControl6.BOSDataSource = null;
            this.bosGroupControl6.BOSDescription = null;
            this.bosGroupControl6.BOSError = null;
            this.bosGroupControl6.BOSFieldGroup = null;
            this.bosGroupControl6.BOSFieldRelation = null;
            this.bosGroupControl6.BOSPrivilege = null;
            this.bosGroupControl6.BOSPropertyName = null;
            this.bosGroupControl6.Controls.Add(this.fld_dgcICProductPackingDetails);
            this.bosGroupControl6.Location = new System.Drawing.Point(434, 583);
            this.bosGroupControl6.Name = "bosGroupControl6";
            this.bosGroupControl6.Screen = null;
            this.bosGroupControl6.Size = new System.Drawing.Size(483, 358);
            this.bosGroupControl6.TabIndex = 2;
            this.bosGroupControl6.Text = "Thông tin đóng thùng";
            // 
            // fld_dgcICProductPackingDetails
            // 
            this.fld_dgcICProductPackingDetails.AllowDrop = true;
            this.fld_dgcICProductPackingDetails.BOSComment = null;
            this.fld_dgcICProductPackingDetails.BOSDataMember = null;
            this.fld_dgcICProductPackingDetails.BOSDataSource = "ICProductPackingDetails";
            this.fld_dgcICProductPackingDetails.BOSDescription = null;
            this.fld_dgcICProductPackingDetails.BOSError = null;
            this.fld_dgcICProductPackingDetails.BOSFieldGroup = null;
            this.fld_dgcICProductPackingDetails.BOSFieldRelation = null;
            this.fld_dgcICProductPackingDetails.BOSGridType = null;
            this.fld_dgcICProductPackingDetails.BOSPrivilege = null;
            this.fld_dgcICProductPackingDetails.BOSPropertyName = null;
            this.fld_dgcICProductPackingDetails.CommodityType = "";
            this.fld_dgcICProductPackingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductPackingDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductPackingDetails.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductPackingDetails.MainView = this.gridView1;
            this.fld_dgcICProductPackingDetails.Name = "fld_dgcICProductPackingDetails";
            this.fld_dgcICProductPackingDetails.PrintReport = false;
            this.fld_dgcICProductPackingDetails.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductPackingDetails, true);
            this.fld_dgcICProductPackingDetails.Size = new System.Drawing.Size(479, 333);
            this.fld_dgcICProductPackingDetails.TabIndex = 0;
            this.fld_dgcICProductPackingDetails.Tag = "DC";
            this.fld_dgcICProductPackingDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICProductPackingDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_pbxConverSize);
            this.bosGroupControl3.Controls.Add(this.bosMemoEdit2);
            this.bosGroupControl3.Controls.Add(this.bosLabel40);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductQtyInBox);
            this.bosGroupControl3.Controls.Add(this.bosLabel32);
            this.bosGroupControl3.Controls.Add(this.bosTextBox3);
            this.bosGroupControl3.Controls.Add(this.bosLabel39);
            this.bosGroupControl3.Controls.Add(this.bosTextBox2);
            this.bosGroupControl3.Controls.Add(this.bosLabel38);
            this.bosGroupControl3.Controls.Add(this.fld_lkeICProductPurchaseType);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductLeadTime);
            this.bosGroupControl3.Controls.Add(this.bosLabel35);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ICProductFormulaPriceConfigID);
            this.bosGroupControl3.Controls.Add(this.bosLabel19);
            this.bosGroupControl3.Controls.Add(this.bosLabel36);
            this.bosGroupControl3.Controls.Add(this.fld_lkeProductParentID);
            this.bosGroupControl3.Controls.Add(this.bosLabel34);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductBlock);
            this.bosGroupControl3.Controls.Add(this.bosLabel31);
            this.bosGroupControl3.Controls.Add(this.bosLabel30);
            this.bosGroupControl3.Controls.Add(this.bosLabel29);
            this.bosGroupControl3.Controls.Add(this.bosLabel28);
            this.bosGroupControl3.Controls.Add(this.bosLabel21);
            this.bosGroupControl3.Controls.Add(this.bosLabel22);
            this.bosGroupControl3.Controls.Add(this.bosLabel23);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductDepth);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductDiameter);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductRadius);
            this.bosGroupControl3.Controls.Add(this.fld_ccbeFinishing);
            this.bosGroupControl3.Controls.Add(this.fld_ccbeColor);
            this.bosGroupControl3.Controls.Add(this.bosLabel5);
            this.bosGroupControl3.Controls.Add(this.fld_ccbeWoodType);
            this.bosGroupControl3.Controls.Add(this.bosLabel1);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductHeight);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductPaintNoOfManufacture);
            this.bosGroupControl3.Controls.Add(this.bosLabel8);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductLength);
            this.bosGroupControl3.Controls.Add(this.fld_lkeICProductIdentifyWoodType);
            this.bosGroupControl3.Controls.Add(this.fld_txtICProductWidth);
            this.bosGroupControl3.Controls.Add(this.fld_pnlOtherAttribute);
            this.bosGroupControl3.Controls.Add(this.bosLabel6);
            this.bosGroupControl3.Controls.Add(this.fld_kleICProductIdentifyColor);
            this.bosGroupControl3.Location = new System.Drawing.Point(434, 3);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(483, 574);
            this.bosGroupControl3.TabIndex = 0;
            this.bosGroupControl3.Text = "Thuộc tính";
            // 
            // fld_pbxConverSize
            // 
            this.fld_pbxConverSize.BackColor = System.Drawing.Color.Transparent;
            this.fld_pbxConverSize.Image = global::BOSERP.Procedure.Properties.Resources.arrow_refresh_small_icon;
            this.fld_pbxConverSize.Location = new System.Drawing.Point(181, 210);
            this.fld_pbxConverSize.Name = "fld_pbxConverSize";
            this.fld_pbxConverSize.Size = new System.Drawing.Size(20, 20);
            this.fld_pbxConverSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_pbxConverSize.TabIndex = 478;
            this.fld_pbxConverSize.TabStop = false;
            this.fld_pbxConverSize.Click += new System.EventHandler(this.fld_pbxConverSize_Click);
            // 
            // bosMemoEdit2
            // 
            this.bosMemoEdit2.BOSComment = "";
            this.bosMemoEdit2.BOSDataMember = "ICProductPackagingDetail";
            this.bosMemoEdit2.BOSDataSource = "ICProducts";
            this.bosMemoEdit2.BOSDescription = null;
            this.bosMemoEdit2.BOSError = null;
            this.bosMemoEdit2.BOSFieldGroup = "";
            this.bosMemoEdit2.BOSFieldRelation = "";
            this.bosMemoEdit2.BOSPrivilege = "";
            this.bosMemoEdit2.BOSPropertyName = "Text";
            this.bosMemoEdit2.EditValue = "";
            this.bosMemoEdit2.Location = new System.Drawing.Point(216, 531);
            this.bosMemoEdit2.Name = "bosMemoEdit2";
            this.bosMemoEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit2.Screen = null;
            this.bosMemoEdit2.Size = new System.Drawing.Size(200, 37);
            this.bosMemoEdit2.TabIndex = 475;
            this.bosMemoEdit2.Tag = "DC";
            // 
            // bosLabel40
            // 
            this.bosLabel40.BOSComment = null;
            this.bosLabel40.BOSDataMember = null;
            this.bosLabel40.BOSDataSource = null;
            this.bosLabel40.BOSDescription = null;
            this.bosLabel40.BOSError = null;
            this.bosLabel40.BOSFieldGroup = null;
            this.bosLabel40.BOSFieldRelation = null;
            this.bosLabel40.BOSPrivilege = null;
            this.bosLabel40.BOSPropertyName = null;
            this.bosLabel40.Location = new System.Drawing.Point(18, 534);
            this.bosLabel40.Name = "bosLabel40";
            this.bosLabel40.Screen = null;
            this.bosLabel40.Size = new System.Drawing.Size(89, 13);
            this.bosLabel40.TabIndex = 474;
            this.bosLabel40.Text = "Thông tin đóng gói";
            // 
            // fld_txtICProductQtyInBox
            // 
            this.fld_txtICProductQtyInBox.BOSComment = "";
            this.fld_txtICProductQtyInBox.BOSDataMember = "ICProductQtyInBox";
            this.fld_txtICProductQtyInBox.BOSDataSource = "ICProducts";
            this.fld_txtICProductQtyInBox.BOSDescription = null;
            this.fld_txtICProductQtyInBox.BOSError = null;
            this.fld_txtICProductQtyInBox.BOSFieldGroup = "";
            this.fld_txtICProductQtyInBox.BOSFieldRelation = "";
            this.fld_txtICProductQtyInBox.BOSPrivilege = "";
            this.fld_txtICProductQtyInBox.BOSPropertyName = "Text";
            this.fld_txtICProductQtyInBox.Location = new System.Drawing.Point(216, 505);
            this.fld_txtICProductQtyInBox.Name = "fld_txtICProductQtyInBox";
            this.fld_txtICProductQtyInBox.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductQtyInBox.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductQtyInBox.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductQtyInBox.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductQtyInBox.Properties.MaskSettings.Set("mask", null);
            this.fld_txtICProductQtyInBox.Screen = null;
            this.fld_txtICProductQtyInBox.Size = new System.Drawing.Size(200, 20);
            this.fld_txtICProductQtyInBox.TabIndex = 471;
            this.fld_txtICProductQtyInBox.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.BOSComment = null;
            this.bosLabel32.BOSDataMember = null;
            this.bosLabel32.BOSDataSource = null;
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = null;
            this.bosLabel32.BOSFieldRelation = null;
            this.bosLabel32.BOSPrivilege = null;
            this.bosLabel32.BOSPropertyName = null;
            this.bosLabel32.Location = new System.Drawing.Point(18, 508);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(145, 13);
            this.bosLabel32.TabIndex = 472;
            this.bosLabel32.Text = "Số lượng SP (/Số lượng thùng)";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "ICProductGrossWeight";
            this.bosTextBox3.BOSDataSource = "ICProducts";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = null;
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(216, 313);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox3.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, true);
            this.bosTextBox3.Size = new System.Drawing.Size(83, 20);
            this.bosTextBox3.TabIndex = 470;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosLabel39
            // 
            this.bosLabel39.BOSComment = null;
            this.bosLabel39.BOSDataMember = null;
            this.bosLabel39.BOSDataSource = null;
            this.bosLabel39.BOSDescription = null;
            this.bosLabel39.BOSError = null;
            this.bosLabel39.BOSFieldGroup = null;
            this.bosLabel39.BOSFieldRelation = null;
            this.bosLabel39.BOSPrivilege = null;
            this.bosLabel39.BOSPropertyName = null;
            this.bosLabel39.Location = new System.Drawing.Point(18, 316);
            this.bosLabel39.Name = "bosLabel39";
            this.bosLabel39.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel39, true);
            this.bosLabel39.Size = new System.Drawing.Size(97, 13);
            this.bosLabel39.TabIndex = 469;
            this.bosLabel39.Text = "Khối lượng SP (G.W)";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ICProductNetWeight";
            this.bosTextBox2.BOSDataSource = "ICProducts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(216, 287);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox2.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(83, 20);
            this.bosTextBox2.TabIndex = 468;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel38
            // 
            this.bosLabel38.BOSComment = null;
            this.bosLabel38.BOSDataMember = null;
            this.bosLabel38.BOSDataSource = null;
            this.bosLabel38.BOSDescription = null;
            this.bosLabel38.BOSError = null;
            this.bosLabel38.BOSFieldGroup = null;
            this.bosLabel38.BOSFieldRelation = null;
            this.bosLabel38.BOSPrivilege = null;
            this.bosLabel38.BOSPropertyName = null;
            this.bosLabel38.Location = new System.Drawing.Point(18, 290);
            this.bosLabel38.Name = "bosLabel38";
            this.bosLabel38.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel38, true);
            this.bosLabel38.Size = new System.Drawing.Size(103, 13);
            this.bosLabel38.TabIndex = 467;
            this.bosLabel38.Text = "Khối lượng tịnh (N.W)";
            // 
            // fld_lkeICProductPurchaseType
            // 
            this.fld_lkeICProductPurchaseType.BOSAllowAddNew = false;
            this.fld_lkeICProductPurchaseType.BOSAllowDummy = true;
            this.fld_lkeICProductPurchaseType.BOSComment = null;
            this.fld_lkeICProductPurchaseType.BOSDataMember = "ICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductPurchaseType.BOSDescription = null;
            this.fld_lkeICProductPurchaseType.BOSError = null;
            this.fld_lkeICProductPurchaseType.BOSFieldGroup = null;
            this.fld_lkeICProductPurchaseType.BOSFieldParent = null;
            this.fld_lkeICProductPurchaseType.BOSFieldRelation = null;
            this.fld_lkeICProductPurchaseType.BOSPrivilege = null;
            this.fld_lkeICProductPurchaseType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductPurchaseType.BOSSelectType = null;
            this.fld_lkeICProductPurchaseType.BOSSelectTypeValue = null;
            this.fld_lkeICProductPurchaseType.CurrentDisplayText = null;
            this.fld_lkeICProductPurchaseType.Location = new System.Drawing.Point(216, 418);
            this.fld_lkeICProductPurchaseType.Name = "fld_lkeICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPurchaseType.Properties.ColumnName = null;
            this.fld_lkeICProductPurchaseType.Properties.NullText = "";
            this.fld_lkeICProductPurchaseType.Screen = null;
            this.fld_lkeICProductPurchaseType.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeICProductPurchaseType.TabIndex = 18;
            this.fld_lkeICProductPurchaseType.Tag = "DC";
            // 
            // fld_txtICProductLeadTime
            // 
            this.fld_txtICProductLeadTime.BOSComment = "";
            this.fld_txtICProductLeadTime.BOSDataMember = "ICProductLeadTime";
            this.fld_txtICProductLeadTime.BOSDataSource = "ICProducts";
            this.fld_txtICProductLeadTime.BOSDescription = null;
            this.fld_txtICProductLeadTime.BOSError = null;
            this.fld_txtICProductLeadTime.BOSFieldGroup = "";
            this.fld_txtICProductLeadTime.BOSFieldRelation = "";
            this.fld_txtICProductLeadTime.BOSPrivilege = "";
            this.fld_txtICProductLeadTime.BOSPropertyName = "Text";
            this.fld_txtICProductLeadTime.EditValue = "";
            this.fld_txtICProductLeadTime.Location = new System.Drawing.Point(216, 393);
            this.fld_txtICProductLeadTime.Name = "fld_txtICProductLeadTime";
            this.fld_txtICProductLeadTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLeadTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLeadTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductLeadTime.Screen = null;
            this.fld_txtICProductLeadTime.Size = new System.Drawing.Size(200, 20);
            this.fld_txtICProductLeadTime.TabIndex = 17;
            this.fld_txtICProductLeadTime.Tag = "DC";
            // 
            // bosLabel35
            // 
            this.bosLabel35.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel35.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel35.Appearance.Options.UseBackColor = true;
            this.bosLabel35.Appearance.Options.UseForeColor = true;
            this.bosLabel35.BOSComment = "";
            this.bosLabel35.BOSDataMember = "";
            this.bosLabel35.BOSDataSource = "";
            this.bosLabel35.BOSDescription = null;
            this.bosLabel35.BOSError = null;
            this.bosLabel35.BOSFieldGroup = "";
            this.bosLabel35.BOSFieldRelation = "";
            this.bosLabel35.BOSPrivilege = "";
            this.bosLabel35.BOSPropertyName = "";
            this.bosLabel35.Location = new System.Drawing.Point(18, 423);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(69, 13);
            this.bosLabel35.TabIndex = 462;
            this.bosLabel35.Tag = "";
            this.bosLabel35.Text = "Loại mua hàng";
            // 
            // fld_lkeFK_ICProductFormulaPriceConfigID
            // 
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSComment = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSDataMember = "FK_ICProductFormulaPriceConfigID";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSError = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSSelectType = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Location = new System.Drawing.Point(217, 184);
            this.fld_lkeFK_ICProductFormulaPriceConfigID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Name = "fld_lkeFK_ICProductFormulaPriceConfigID";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductFormulaPriceConfigName", "Tên công thức")});
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.DisplayMember = "ICProductFormulaPriceConfigName";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.NullText = "";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties.ValueMember = "ICProductFormulaPriceConfigID";
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Screen = null;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_ICProductFormulaPriceConfigID.TabIndex = 6;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Tag = "DC";
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
            this.bosLabel19.Location = new System.Drawing.Point(18, 187);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(50, 13);
            this.bosLabel19.TabIndex = 343;
            this.bosLabel19.Text = "Công thức";
            // 
            // bosLabel36
            // 
            this.bosLabel36.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel36.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel36.Appearance.Options.UseBackColor = true;
            this.bosLabel36.Appearance.Options.UseForeColor = true;
            this.bosLabel36.BOSComment = "";
            this.bosLabel36.BOSDataMember = "";
            this.bosLabel36.BOSDataSource = "";
            this.bosLabel36.BOSDescription = null;
            this.bosLabel36.BOSError = null;
            this.bosLabel36.BOSFieldGroup = "";
            this.bosLabel36.BOSFieldRelation = "";
            this.bosLabel36.BOSPrivilege = "";
            this.bosLabel36.BOSPropertyName = "";
            this.bosLabel36.Location = new System.Drawing.Point(18, 396);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(72, 13);
            this.bosLabel36.TabIndex = 461;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "Leadtime (day)";
            // 
            // fld_lkeProductParentID
            // 
            this.fld_lkeProductParentID.BOSAllowAddNew = false;
            this.fld_lkeProductParentID.BOSAllowDummy = true;
            this.fld_lkeProductParentID.BOSComment = "";
            this.fld_lkeProductParentID.BOSDataMember = "FK_ICProductParentID";
            this.fld_lkeProductParentID.BOSDataSource = "ICProducts";
            this.fld_lkeProductParentID.BOSDescription = null;
            this.fld_lkeProductParentID.BOSError = null;
            this.fld_lkeProductParentID.BOSFieldGroup = "";
            this.fld_lkeProductParentID.BOSFieldParent = "";
            this.fld_lkeProductParentID.BOSFieldRelation = "";
            this.fld_lkeProductParentID.BOSPrivilege = "";
            this.fld_lkeProductParentID.BOSPropertyName = "EditValue";
            this.fld_lkeProductParentID.BOSSelectType = "ICProductCheckCarcass";
            this.fld_lkeProductParentID.BOSSelectTypeValue = "True";
            this.fld_lkeProductParentID.CurrentDisplayText = null;
            this.fld_lkeProductParentID.Location = new System.Drawing.Point(216, 367);
            this.fld_lkeProductParentID.Name = "fld_lkeProductParentID";
            this.fld_lkeProductParentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeProductParentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeProductParentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeProductParentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeProductParentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductParentID.Properties.ColumnName = null;
            this.fld_lkeProductParentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã "),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeProductParentID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeProductParentID.Properties.NullText = "";
            this.fld_lkeProductParentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeProductParentID.Properties.ValueMember = "ICProductID";
            this.fld_lkeProductParentID.Screen = null;
            this.fld_lkeProductParentID.Size = new System.Drawing.Size(200, 20);
            this.fld_lkeProductParentID.TabIndex = 16;
            this.fld_lkeProductParentID.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel34.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
            this.bosLabel34.Appearance.Options.UseFont = true;
            this.bosLabel34.Appearance.Options.UseForeColor = true;
            this.bosLabel34.BOSComment = "";
            this.bosLabel34.BOSDataMember = "";
            this.bosLabel34.BOSDataSource = "";
            this.bosLabel34.BOSDescription = null;
            this.bosLabel34.BOSError = null;
            this.bosLabel34.BOSFieldGroup = "";
            this.bosLabel34.BOSFieldRelation = "";
            this.bosLabel34.BOSPrivilege = "";
            this.bosLabel34.BOSPropertyName = "";
            this.bosLabel34.Location = new System.Drawing.Point(18, 370);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(90, 13);
            this.bosLabel34.TabIndex = 458;
            this.bosLabel34.Tag = "";
            this.bosLabel34.Text = "Thuộc thành phẩm";
            // 
            // fld_txtICProductBlock
            // 
            this.fld_txtICProductBlock.BOSComment = "";
            this.fld_txtICProductBlock.BOSDataMember = "ICProductBlock";
            this.fld_txtICProductBlock.BOSDataSource = "ICProducts";
            this.fld_txtICProductBlock.BOSDescription = null;
            this.fld_txtICProductBlock.BOSError = null;
            this.fld_txtICProductBlock.BOSFieldGroup = "";
            this.fld_txtICProductBlock.BOSFieldRelation = "";
            this.fld_txtICProductBlock.BOSPrivilege = "";
            this.fld_txtICProductBlock.BOSPropertyName = "Text";
            this.fld_txtICProductBlock.Location = new System.Drawing.Point(216, 341);
            this.fld_txtICProductBlock.Name = "fld_txtICProductBlock";
            this.fld_txtICProductBlock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductBlock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductBlock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductBlock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductBlock.Properties.Mask.EditMask = null;
            this.fld_txtICProductBlock.Screen = null;
            this.fld_txtICProductBlock.Size = new System.Drawing.Size(200, 20);
            this.fld_txtICProductBlock.TabIndex = 15;
            this.fld_txtICProductBlock.Tag = "DC";
            // 
            // bosLabel31
            // 
            this.bosLabel31.BOSComment = null;
            this.bosLabel31.BOSDataMember = null;
            this.bosLabel31.BOSDataSource = null;
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = null;
            this.bosLabel31.BOSFieldRelation = null;
            this.bosLabel31.BOSPrivilege = null;
            this.bosLabel31.BOSPropertyName = null;
            this.bosLabel31.Location = new System.Drawing.Point(18, 344);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(41, 13);
            this.bosLabel31.TabIndex = 453;
            this.bosLabel31.Text = "Khối tinh";
            // 
            // bosLabel30
            // 
            this.bosLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel30.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel30.Appearance.Options.UseBackColor = true;
            this.bosLabel30.Appearance.Options.UseFont = true;
            this.bosLabel30.Appearance.Options.UseForeColor = true;
            this.bosLabel30.BOSComment = "";
            this.bosLabel30.BOSDataMember = "ICProductName";
            this.bosLabel30.BOSDataSource = "ICProducts";
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = "";
            this.bosLabel30.BOSFieldRelation = "";
            this.bosLabel30.BOSPrivilege = "";
            this.bosLabel30.BOSPropertyName = "";
            this.bosLabel30.Location = new System.Drawing.Point(18, 161);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.bosLabel30.Size = new System.Drawing.Size(52, 13);
            this.bosLabel30.TabIndex = 452;
            this.bosLabel30.Tag = "";
            this.bosLabel30.Text = "Hoàn thiện";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseFont = true;
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
            this.bosLabel29.Location = new System.Drawing.Point(18, 83);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(41, 13);
            this.bosLabel29.TabIndex = 451;
            this.bosLabel29.Tag = "";
            this.bosLabel29.Text = "Màu sơn";
            // 
            // bosLabel28
            // 
            this.bosLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel28.Appearance.Options.UseBackColor = true;
            this.bosLabel28.Appearance.Options.UseFont = true;
            this.bosLabel28.Appearance.Options.UseForeColor = true;
            this.bosLabel28.BOSComment = "";
            this.bosLabel28.BOSDataMember = "";
            this.bosLabel28.BOSDataSource = "";
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = "";
            this.bosLabel28.BOSFieldRelation = "";
            this.bosLabel28.BOSPrivilege = "";
            this.bosLabel28.BOSPropertyName = "";
            this.bosLabel28.Location = new System.Drawing.Point(18, 31);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(77, 13);
            this.bosLabel28.TabIndex = 450;
            this.bosLabel28.Tag = "";
            this.bosLabel28.Text = "Loại nguyên liệu";
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
            this.bosLabel21.Location = new System.Drawing.Point(305, 238);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(67, 13);
            this.bosLabel21.TabIndex = 11;
            this.bosLabel21.Text = "Bán kính (mm)";
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
            this.bosLabel22.Location = new System.Drawing.Point(18, 238);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(82, 13);
            this.bosLabel22.TabIndex = 448;
            this.bosLabel22.Text = "Đường kính (mm)";
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
            this.bosLabel23.Location = new System.Drawing.Point(18, 264);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel23, true);
            this.bosLabel23.Size = new System.Drawing.Size(80, 13);
            this.bosLabel23.TabIndex = 447;
            this.bosLabel23.Text = "Độ dày (D) (mm)";
            // 
            // fld_txtICProductDepth
            // 
            this.fld_txtICProductDepth.BOSComment = "";
            this.fld_txtICProductDepth.BOSDataMember = "ICProductDepth";
            this.fld_txtICProductDepth.BOSDataSource = "ICProducts";
            this.fld_txtICProductDepth.BOSDescription = null;
            this.fld_txtICProductDepth.BOSError = null;
            this.fld_txtICProductDepth.BOSFieldGroup = "";
            this.fld_txtICProductDepth.BOSFieldRelation = "";
            this.fld_txtICProductDepth.BOSPrivilege = "";
            this.fld_txtICProductDepth.BOSPropertyName = "Text";
            this.fld_txtICProductDepth.Location = new System.Drawing.Point(216, 261);
            this.fld_txtICProductDepth.Name = "fld_txtICProductDepth";
            this.fld_txtICProductDepth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDepth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDepth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDepth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDepth.Properties.Mask.EditMask = "n";
            this.fld_txtICProductDepth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductDepth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDepth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductDepth, true);
            this.fld_txtICProductDepth.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductDepth.TabIndex = 13;
            this.fld_txtICProductDepth.Tag = "DC";
            // 
            // fld_txtICProductDiameter
            // 
            this.fld_txtICProductDiameter.BOSComment = "";
            this.fld_txtICProductDiameter.BOSDataMember = "ICProductDiameter";
            this.fld_txtICProductDiameter.BOSDataSource = "ICProducts";
            this.fld_txtICProductDiameter.BOSDescription = null;
            this.fld_txtICProductDiameter.BOSError = null;
            this.fld_txtICProductDiameter.BOSFieldGroup = "";
            this.fld_txtICProductDiameter.BOSFieldRelation = "";
            this.fld_txtICProductDiameter.BOSPrivilege = "";
            this.fld_txtICProductDiameter.BOSPropertyName = "Text";
            this.fld_txtICProductDiameter.Location = new System.Drawing.Point(216, 235);
            this.fld_txtICProductDiameter.Name = "fld_txtICProductDiameter";
            this.fld_txtICProductDiameter.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDiameter.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDiameter.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDiameter.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDiameter.Properties.Mask.EditMask = "n";
            this.fld_txtICProductDiameter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductDiameter.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDiameter.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductDiameter, true);
            this.fld_txtICProductDiameter.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductDiameter.TabIndex = 10;
            this.fld_txtICProductDiameter.Tag = "DC";
            // 
            // fld_txtICProductRadius
            // 
            this.fld_txtICProductRadius.BOSComment = "";
            this.fld_txtICProductRadius.BOSDataMember = "ICProductRadius";
            this.fld_txtICProductRadius.BOSDataSource = "ICProducts";
            this.fld_txtICProductRadius.BOSDescription = null;
            this.fld_txtICProductRadius.BOSError = null;
            this.fld_txtICProductRadius.BOSFieldGroup = "";
            this.fld_txtICProductRadius.BOSFieldRelation = "";
            this.fld_txtICProductRadius.BOSPrivilege = "";
            this.fld_txtICProductRadius.BOSPropertyName = "Text";
            this.fld_txtICProductRadius.Location = new System.Drawing.Point(394, 235);
            this.fld_txtICProductRadius.Name = "fld_txtICProductRadius";
            this.fld_txtICProductRadius.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductRadius.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductRadius.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductRadius.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductRadius.Properties.Mask.EditMask = "n";
            this.fld_txtICProductRadius.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductRadius.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductRadius.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductRadius, true);
            this.fld_txtICProductRadius.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductRadius.TabIndex = 12;
            this.fld_txtICProductRadius.Tag = "DC";
            // 
            // fld_ccbeFinishing
            // 
            this.fld_ccbeFinishing.Location = new System.Drawing.Point(217, 158);
            this.fld_ccbeFinishing.MenuManager = this.screenToolbar;
            this.fld_ccbeFinishing.Name = "fld_ccbeFinishing";
            this.fld_ccbeFinishing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeFinishing.Size = new System.Drawing.Size(199, 20);
            this.fld_ccbeFinishing.TabIndex = 5;
            // 
            // fld_ccbeColor
            // 
            this.fld_ccbeColor.Location = new System.Drawing.Point(217, 106);
            this.fld_ccbeColor.MenuManager = this.screenToolbar;
            this.fld_ccbeColor.Name = "fld_ccbeColor";
            this.fld_ccbeColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeColor.Size = new System.Drawing.Size(199, 20);
            this.fld_ccbeColor.TabIndex = 3;
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(18, 109);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(68, 13);
            this.bosLabel5.TabIndex = 359;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Màu sắc khác";
            // 
            // fld_ccbeWoodType
            // 
            this.fld_ccbeWoodType.Location = new System.Drawing.Point(217, 54);
            this.fld_ccbeWoodType.MenuManager = this.screenToolbar;
            this.fld_ccbeWoodType.Name = "fld_ccbeWoodType";
            this.fld_ccbeWoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeWoodType.Size = new System.Drawing.Size(199, 20);
            this.fld_ccbeWoodType.TabIndex = 1;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
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
            this.bosLabel1.Location = new System.Drawing.Point(18, 57);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 357;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Loại NL khác";
            // 
            // fld_txtICProductHeight
            // 
            this.fld_txtICProductHeight.BOSComment = "";
            this.fld_txtICProductHeight.BOSDataMember = "ICProductHeight";
            this.fld_txtICProductHeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductHeight.BOSDescription = null;
            this.fld_txtICProductHeight.BOSError = null;
            this.fld_txtICProductHeight.BOSFieldGroup = "";
            this.fld_txtICProductHeight.BOSFieldRelation = "";
            this.fld_txtICProductHeight.BOSPrivilege = "";
            this.fld_txtICProductHeight.BOSPropertyName = "Text";
            this.fld_txtICProductHeight.Location = new System.Drawing.Point(394, 210);
            this.fld_txtICProductHeight.Name = "fld_txtICProductHeight";
            this.fld_txtICProductHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductHeight.Properties.Mask.EditMask = "c0";
            this.fld_txtICProductHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductHeight, true);
            this.fld_txtICProductHeight.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductHeight.TabIndex = 9;
            this.fld_txtICProductHeight.Tag = "DC";
            // 
            // fld_txtICProductPaintNoOfManufacture
            // 
            this.fld_txtICProductPaintNoOfManufacture.BOSComment = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSDataMember = "ICProductPaintNoOfManufacture";
            this.fld_txtICProductPaintNoOfManufacture.BOSDataSource = "ICProducts";
            this.fld_txtICProductPaintNoOfManufacture.BOSDescription = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSError = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSFieldGroup = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSFieldRelation = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSPrivilege = null;
            this.fld_txtICProductPaintNoOfManufacture.BOSPropertyName = "Text";
            this.fld_txtICProductPaintNoOfManufacture.Location = new System.Drawing.Point(217, 132);
            this.fld_txtICProductPaintNoOfManufacture.MenuManager = this.screenToolbar;
            this.fld_txtICProductPaintNoOfManufacture.Name = "fld_txtICProductPaintNoOfManufacture";
            this.fld_txtICProductPaintNoOfManufacture.Screen = null;
            this.fld_txtICProductPaintNoOfManufacture.Size = new System.Drawing.Size(128, 20);
            this.fld_txtICProductPaintNoOfManufacture.TabIndex = 4;
            this.fld_txtICProductPaintNoOfManufacture.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(18, 213);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 345;
            this.bosLabel8.Text = "D x R x C (mm)";
            // 
            // fld_txtICProductLength
            // 
            this.fld_txtICProductLength.BOSComment = "";
            this.fld_txtICProductLength.BOSDataMember = "ICProductLength";
            this.fld_txtICProductLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductLength.BOSDescription = null;
            this.fld_txtICProductLength.BOSError = null;
            this.fld_txtICProductLength.BOSFieldGroup = "";
            this.fld_txtICProductLength.BOSFieldRelation = "";
            this.fld_txtICProductLength.BOSPrivilege = "";
            this.fld_txtICProductLength.BOSPropertyName = "Text";
            this.fld_txtICProductLength.Location = new System.Drawing.Point(305, 210);
            this.fld_txtICProductLength.Name = "fld_txtICProductLength";
            this.fld_txtICProductLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLength.Properties.Mask.EditMask = "c0";
            this.fld_txtICProductLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductLength, true);
            this.fld_txtICProductLength.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductLength.TabIndex = 8;
            this.fld_txtICProductLength.Tag = "DC";
            // 
            // fld_lkeICProductIdentifyWoodType
            // 
            this.fld_lkeICProductIdentifyWoodType.BOSAllowAddNew = false;
            this.fld_lkeICProductIdentifyWoodType.BOSAllowDummy = false;
            this.fld_lkeICProductIdentifyWoodType.BOSComment = null;
            this.fld_lkeICProductIdentifyWoodType.BOSDataMember = "FK_ICProductAttributeWoodTypeID";
            this.fld_lkeICProductIdentifyWoodType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductIdentifyWoodType.BOSDescription = null;
            this.fld_lkeICProductIdentifyWoodType.BOSError = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldGroup = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldParent = null;
            this.fld_lkeICProductIdentifyWoodType.BOSFieldRelation = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPrivilege = null;
            this.fld_lkeICProductIdentifyWoodType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductIdentifyWoodType.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductIdentifyWoodType.BOSSelectTypeValue = "WoodType";
            this.fld_lkeICProductIdentifyWoodType.CurrentDisplayText = null;
            this.fld_lkeICProductIdentifyWoodType.Location = new System.Drawing.Point(217, 28);
            this.fld_lkeICProductIdentifyWoodType.Name = "fld_lkeICProductIdentifyWoodType";
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeICProductIdentifyWoodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductIdentifyWoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIdentifyWoodType.Properties.ColumnName = null;
            this.fld_lkeICProductIdentifyWoodType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại gỗ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại gỗ")});
            this.fld_lkeICProductIdentifyWoodType.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductIdentifyWoodType.Properties.NullText = "";
            this.fld_lkeICProductIdentifyWoodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductIdentifyWoodType.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductIdentifyWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductIdentifyWoodType, true);
            this.fld_lkeICProductIdentifyWoodType.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeICProductIdentifyWoodType.TabIndex = 0;
            this.fld_lkeICProductIdentifyWoodType.Tag = "DC";
            // 
            // fld_txtICProductWidth
            // 
            this.fld_txtICProductWidth.BOSComment = "";
            this.fld_txtICProductWidth.BOSDataMember = "ICProductWidth";
            this.fld_txtICProductWidth.BOSDataSource = "ICProducts";
            this.fld_txtICProductWidth.BOSDescription = null;
            this.fld_txtICProductWidth.BOSError = null;
            this.fld_txtICProductWidth.BOSFieldGroup = "";
            this.fld_txtICProductWidth.BOSFieldRelation = "";
            this.fld_txtICProductWidth.BOSPrivilege = "";
            this.fld_txtICProductWidth.BOSPropertyName = "Text";
            this.fld_txtICProductWidth.Location = new System.Drawing.Point(216, 210);
            this.fld_txtICProductWidth.Name = "fld_txtICProductWidth";
            this.fld_txtICProductWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth.Properties.Mask.EditMask = "c0";
            this.fld_txtICProductWidth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.fld_txtICProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth, false);
            this.fld_txtICProductWidth.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductWidth.TabIndex = 7;
            this.fld_txtICProductWidth.Tag = "DC";
            // 
            // fld_pnlOtherAttribute
            // 
            this.fld_pnlOtherAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlOtherAttribute.BOSComment = null;
            this.fld_pnlOtherAttribute.BOSDataMember = null;
            this.fld_pnlOtherAttribute.BOSDataSource = null;
            this.fld_pnlOtherAttribute.BOSDescription = null;
            this.fld_pnlOtherAttribute.BOSError = null;
            this.fld_pnlOtherAttribute.BOSFieldGroup = null;
            this.fld_pnlOtherAttribute.BOSFieldRelation = null;
            this.fld_pnlOtherAttribute.BOSPrivilege = null;
            this.fld_pnlOtherAttribute.BOSPropertyName = null;
            this.fld_pnlOtherAttribute.Controls.Add(this.bosLabel10);
            this.fld_pnlOtherAttribute.Controls.Add(this.fld_fld_bedICProductAttribute);
            this.fld_pnlOtherAttribute.Controls.Add(this.bosLabel9);
            this.fld_pnlOtherAttribute.Controls.Add(this.fld_medICProductOtherSize);
            this.fld_pnlOtherAttribute.Location = new System.Drawing.Point(8, 442);
            this.fld_pnlOtherAttribute.Name = "fld_pnlOtherAttribute";
            this.fld_pnlOtherAttribute.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_pnlOtherAttribute, true);
            this.fld_pnlOtherAttribute.Size = new System.Drawing.Size(475, 60);
            this.fld_pnlOtherAttribute.TabIndex = 351;
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(10, 31);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(70, 13);
            this.bosLabel10.TabIndex = 333;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Quy cách khác";
            // 
            // fld_fld_bedICProductAttribute
            // 
            this.fld_fld_bedICProductAttribute.BOSComment = "";
            this.fld_fld_bedICProductAttribute.BOSDataMember = "ICProductAttribute";
            this.fld_fld_bedICProductAttribute.BOSDataSource = "ICProducts";
            this.fld_fld_bedICProductAttribute.BOSDescription = null;
            this.fld_fld_bedICProductAttribute.BOSError = null;
            this.fld_fld_bedICProductAttribute.BOSFieldGroup = "";
            this.fld_fld_bedICProductAttribute.BOSFieldRelation = "";
            this.fld_fld_bedICProductAttribute.BOSPrivilege = "";
            this.fld_fld_bedICProductAttribute.BOSPropertyName = "Text";
            this.fld_fld_bedICProductAttribute.EditValue = "<ButtonEdit>";
            this.fld_fld_bedICProductAttribute.Location = new System.Drawing.Point(208, 4);
            this.fld_fld_bedICProductAttribute.Name = "fld_fld_bedICProductAttribute";
            this.fld_fld_bedICProductAttribute.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_fld_bedICProductAttribute.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_fld_bedICProductAttribute.Properties.Appearance.Options.UseBackColor = true;
            this.fld_fld_bedICProductAttribute.Properties.Appearance.Options.UseForeColor = true;
            this.fld_fld_bedICProductAttribute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_fld_bedICProductAttribute.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_fld_bedICProductAttribute.Properties.ReadOnly = true;
            this.fld_fld_bedICProductAttribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_fld_bedICProductAttribute.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_fld_bedICProductAttribute, true);
            this.fld_fld_bedICProductAttribute.Size = new System.Drawing.Size(200, 20);
            this.fld_fld_bedICProductAttribute.TabIndex = 0;
            this.fld_fld_bedICProductAttribute.Tag = "DC";
            this.fld_fld_bedICProductAttribute.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_fld_bedICProductAttribute_ButtonClick);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel9.BOSPropertyName = "";
            this.bosLabel9.Location = new System.Drawing.Point(10, 7);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(75, 13);
            this.bosLabel9.TabIndex = 332;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Thuộc tính khác";
            // 
            // fld_medICProductOtherSize
            // 
            this.fld_medICProductOtherSize.BOSComment = "";
            this.fld_medICProductOtherSize.BOSDataMember = "ICProductOtherSize";
            this.fld_medICProductOtherSize.BOSDataSource = "ICProducts";
            this.fld_medICProductOtherSize.BOSDescription = null;
            this.fld_medICProductOtherSize.BOSError = null;
            this.fld_medICProductOtherSize.BOSFieldGroup = "";
            this.fld_medICProductOtherSize.BOSFieldRelation = "";
            this.fld_medICProductOtherSize.BOSPrivilege = "";
            this.fld_medICProductOtherSize.BOSPropertyName = "Text";
            this.fld_medICProductOtherSize.EditValue = "";
            this.fld_medICProductOtherSize.Location = new System.Drawing.Point(208, 30);
            this.fld_medICProductOtherSize.Name = "fld_medICProductOtherSize";
            this.fld_medICProductOtherSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductOtherSize.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductOtherSize.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductOtherSize.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductOtherSize.Screen = null;
            this.fld_medICProductOtherSize.Size = new System.Drawing.Size(200, 27);
            this.fld_medICProductOtherSize.TabIndex = 19;
            this.fld_medICProductOtherSize.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "ICProductName";
            this.bosLabel6.BOSDataSource = "ICProducts";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(18, 135);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(83, 13);
            this.bosLabel6.TabIndex = 345;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Mã màu sắc NSX";
            // 
            // fld_kleICProductIdentifyColor
            // 
            this.fld_kleICProductIdentifyColor.BOSAllowAddNew = false;
            this.fld_kleICProductIdentifyColor.BOSAllowDummy = false;
            this.fld_kleICProductIdentifyColor.BOSComment = null;
            this.fld_kleICProductIdentifyColor.BOSDataMember = "FK_ICProductAttributeColorID";
            this.fld_kleICProductIdentifyColor.BOSDataSource = "ICProducts";
            this.fld_kleICProductIdentifyColor.BOSDescription = null;
            this.fld_kleICProductIdentifyColor.BOSError = null;
            this.fld_kleICProductIdentifyColor.BOSFieldGroup = null;
            this.fld_kleICProductIdentifyColor.BOSFieldParent = null;
            this.fld_kleICProductIdentifyColor.BOSFieldRelation = null;
            this.fld_kleICProductIdentifyColor.BOSPrivilege = null;
            this.fld_kleICProductIdentifyColor.BOSPropertyName = "EditValue";
            this.fld_kleICProductIdentifyColor.BOSSelectType = "ICProductAttributeGroup";
            this.fld_kleICProductIdentifyColor.BOSSelectTypeValue = "COLOR";
            this.fld_kleICProductIdentifyColor.CurrentDisplayText = null;
            this.fld_kleICProductIdentifyColor.Location = new System.Drawing.Point(217, 80);
            this.fld_kleICProductIdentifyColor.MenuManager = this.screenToolbar;
            this.fld_kleICProductIdentifyColor.Name = "fld_kleICProductIdentifyColor";
            this.fld_kleICProductIdentifyColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_kleICProductIdentifyColor.Properties.ColumnName = null;
            this.fld_kleICProductIdentifyColor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên màu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeAbbreviation", "Tên viết tắt"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Hệ sơn")});
            this.fld_kleICProductIdentifyColor.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_kleICProductIdentifyColor.Properties.NullText = "";
            this.fld_kleICProductIdentifyColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_kleICProductIdentifyColor.Properties.ValueMember = "ICProductAttributeID";
            this.fld_kleICProductIdentifyColor.Screen = null;
            this.fld_kleICProductIdentifyColor.Size = new System.Drawing.Size(128, 20);
            this.fld_kleICProductIdentifyColor.TabIndex = 2;
            this.fld_kleICProductIdentifyColor.Tag = "DC";
            this.fld_kleICProductIdentifyColor.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_kleICProductIdentifyColor_CloseUp_1);
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.bosMemoEdit1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel41);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductTrademark);
            this.fld_grcGroupControl5.Controls.Add(this.pictureBox1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductImageFile);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkHasComponent);
            this.fld_grcGroupControl5.Controls.Add(this.bosLookupEdit4);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel33);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ICProductCarcassID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkCarcass);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel25);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl5.Controls.Add(this.bosCheckEdit1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductStorageDay);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel26);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel20);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductTemplateType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddProductImageDefault);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOrigin);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductLockedPurchaseOrder);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOriginOfProduct);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel11);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductWorkType);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductBarCode);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductCustomerNumber);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lbl5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNoOfOldSys);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtMHTold);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkSetDefaultDesc);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel15);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel21);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel28);
            this.fld_grcGroupControl5.Controls.Add(this.fld_medICProductDesc);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNo);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 596);
            this.fld_grcGroupControl5.TabIndex = 1;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "ICProductProductionComment";
            this.bosMemoEdit1.BOSDataSource = "ICProducts";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(107, 553);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(297, 37);
            this.bosMemoEdit1.TabIndex = 477;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosLabel41
            // 
            this.bosLabel41.BOSComment = null;
            this.bosLabel41.BOSDataMember = null;
            this.bosLabel41.BOSDataSource = null;
            this.bosLabel41.BOSDescription = null;
            this.bosLabel41.BOSError = null;
            this.bosLabel41.BOSFieldGroup = null;
            this.bosLabel41.BOSFieldRelation = null;
            this.bosLabel41.BOSPrivilege = null;
            this.bosLabel41.BOSPropertyName = null;
            this.bosLabel41.Location = new System.Drawing.Point(12, 556);
            this.bosLabel41.Name = "bosLabel41";
            this.bosLabel41.Screen = null;
            this.bosLabel41.Size = new System.Drawing.Size(80, 13);
            this.bosLabel41.TabIndex = 476;
            this.bosLabel41.Text = "Ghi chú sản xuất";
            // 
            // fld_lkeICProductTrademark
            // 
            this.fld_lkeICProductTrademark.BOSAllowAddNew = false;
            this.fld_lkeICProductTrademark.BOSAllowDummy = false;
            this.fld_lkeICProductTrademark.BOSComment = null;
            this.fld_lkeICProductTrademark.BOSDataMember = "ICProductTrademark";
            this.fld_lkeICProductTrademark.BOSDataSource = "ICProducts";
            this.fld_lkeICProductTrademark.BOSDescription = null;
            this.fld_lkeICProductTrademark.BOSError = null;
            this.fld_lkeICProductTrademark.BOSFieldGroup = null;
            this.fld_lkeICProductTrademark.BOSFieldParent = null;
            this.fld_lkeICProductTrademark.BOSFieldRelation = null;
            this.fld_lkeICProductTrademark.BOSPrivilege = null;
            this.fld_lkeICProductTrademark.BOSPropertyName = "EditValue";
            this.fld_lkeICProductTrademark.BOSSelectType = "";
            this.fld_lkeICProductTrademark.BOSSelectTypeValue = "";
            this.fld_lkeICProductTrademark.CurrentDisplayText = null;
            this.fld_lkeICProductTrademark.Location = new System.Drawing.Point(110, 475);
            this.fld_lkeICProductTrademark.MenuManager = this.screenToolbar;
            this.fld_lkeICProductTrademark.Name = "fld_lkeICProductTrademark";
            this.fld_lkeICProductTrademark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductTrademark.Properties.ColumnName = null;
            this.fld_lkeICProductTrademark.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeICProductTrademark.Properties.NullText = "";
            this.fld_lkeICProductTrademark.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductTrademark.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductTrademark, true);
            this.fld_lkeICProductTrademark.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductTrademark.TabIndex = 377;
            this.fld_lkeICProductTrademark.Tag = "DC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BOSERP.Procedure.Properties.Resources.Edit;
            this.pictureBox1.Location = new System.Drawing.Point(384, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 376;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fld_txtICProductImageFile
            // 
            this.fld_txtICProductImageFile.BOSComment = null;
            this.fld_txtICProductImageFile.BOSDataMember = "ICProductImageFile";
            this.fld_txtICProductImageFile.BOSDataSource = "ICProducts";
            this.fld_txtICProductImageFile.BOSDescription = null;
            this.fld_txtICProductImageFile.BOSError = null;
            this.fld_txtICProductImageFile.BOSFieldGroup = null;
            this.fld_txtICProductImageFile.BOSFieldRelation = null;
            this.fld_txtICProductImageFile.BOSPrivilege = null;
            this.fld_txtICProductImageFile.BOSPropertyName = "Text";
            this.fld_txtICProductImageFile.Location = new System.Drawing.Point(282, 341);
            this.fld_txtICProductImageFile.MenuManager = this.screenToolbar;
            this.fld_txtICProductImageFile.Name = "fld_txtICProductImageFile";
            this.fld_txtICProductImageFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.fld_txtICProductImageFile.Properties.Appearance.Options.UseFont = true;
            this.fld_txtICProductImageFile.Properties.ReadOnly = true;
            this.fld_txtICProductImageFile.Screen = null;
            this.fld_txtICProductImageFile.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductImageFile.TabIndex = 375;
            this.fld_txtICProductImageFile.Tag = "DC";
            this.fld_txtICProductImageFile.Click += new System.EventHandler(this.fld_txtICProductImageFile_Click);
            // 
            // fld_chkHasComponent
            // 
            this.fld_chkHasComponent.BOSComment = null;
            this.fld_chkHasComponent.BOSDataMember = "HasComponent";
            this.fld_chkHasComponent.BOSDataSource = "ICProducts";
            this.fld_chkHasComponent.BOSDescription = null;
            this.fld_chkHasComponent.BOSError = null;
            this.fld_chkHasComponent.BOSFieldGroup = null;
            this.fld_chkHasComponent.BOSFieldRelation = null;
            this.fld_chkHasComponent.BOSPrivilege = null;
            this.fld_chkHasComponent.BOSPropertyName = "EditValue";
            this.fld_chkHasComponent.Location = new System.Drawing.Point(284, 527);
            this.fld_chkHasComponent.Name = "fld_chkHasComponent";
            this.fld_chkHasComponent.Properties.Caption = "Có thành phần";
            this.fld_chkHasComponent.Screen = null;
            this.fld_chkHasComponent.Size = new System.Drawing.Size(104, 20);
            this.fld_chkHasComponent.TabIndex = 374;
            this.fld_chkHasComponent.Tag = "DC";
            this.fld_chkHasComponent.CheckedChanged += new System.EventHandler(this.fld_chkHasComponent_CheckedChanged);
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = true;
            this.bosLookupEdit4.BOSComment = "";
            this.bosLookupEdit4.BOSDataMember = "FK_ARCustomerID";
            this.bosLookupEdit4.BOSDataSource = "ICProducts";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = "";
            this.bosLookupEdit4.BOSFieldParent = "";
            this.bosLookupEdit4.BOSFieldRelation = "";
            this.bosLookupEdit4.BOSPrivilege = "";
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = "";
            this.bosLookupEdit4.BOSSelectTypeValue = "";
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(109, 301);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã "),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên")});
            this.bosLookupEdit4.Properties.DisplayMember = "ARCustomerName";
            this.bosLookupEdit4.Properties.NullText = "";
            this.bosLookupEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit4.Properties.ValueMember = "ARCustomerID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(156, 20);
            this.bosLookupEdit4.TabIndex = 10;
            this.bosLookupEdit4.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel33.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
            this.bosLabel33.Appearance.Options.UseFont = true;
            this.bosLabel33.Appearance.Options.UseForeColor = true;
            this.bosLabel33.BOSComment = "";
            this.bosLabel33.BOSDataMember = "";
            this.bosLabel33.BOSDataSource = "";
            this.bosLabel33.BOSDescription = null;
            this.bosLabel33.BOSError = null;
            this.bosLabel33.BOSFieldGroup = "";
            this.bosLabel33.BOSFieldRelation = "";
            this.bosLabel33.BOSPrivilege = "";
            this.bosLabel33.BOSPropertyName = "";
            this.bosLabel33.Location = new System.Drawing.Point(11, 304);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(58, 13);
            this.bosLabel33.TabIndex = 373;
            this.bosLabel33.Tag = "";
            this.bosLabel33.Text = "Khách hàng";
            // 
            // fld_lkeFK_ICProductCarcassID
            // 
            this.fld_lkeFK_ICProductCarcassID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductCarcassID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductCarcassID.BOSComment = null;
            this.fld_lkeFK_ICProductCarcassID.BOSDataMember = "FK_ICProductCarcassID";
            this.fld_lkeFK_ICProductCarcassID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductCarcassID.BOSDescription = null;
            this.fld_lkeFK_ICProductCarcassID.BOSError = null;
            this.fld_lkeFK_ICProductCarcassID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductCarcassID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductCarcassID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductCarcassID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductCarcassID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductCarcassID.BOSSelectType = "";
            this.fld_lkeFK_ICProductCarcassID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductCarcassID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductCarcassID.Location = new System.Drawing.Point(109, 28);
            this.fld_lkeFK_ICProductCarcassID.Name = "fld_lkeFK_ICProductCarcassID";
            this.fld_lkeFK_ICProductCarcassID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeFK_ICProductCarcassID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductCarcassID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductCarcassID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductCarcassID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductCarcassID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductCarcassID.Properties.NullText = "";
            this.fld_lkeFK_ICProductCarcassID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductCarcassID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductCarcassID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductCarcassID, true);
            this.fld_lkeFK_ICProductCarcassID.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeFK_ICProductCarcassID.TabIndex = 0;
            this.fld_lkeFK_ICProductCarcassID.Tag = "DC";
            this.fld_lkeFK_ICProductCarcassID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductCarcassID_CloseUp);
            // 
            // fld_chkCarcass
            // 
            this.fld_chkCarcass.BOSComment = null;
            this.fld_chkCarcass.BOSDataMember = "ICProductCheckCarcass";
            this.fld_chkCarcass.BOSDataSource = "ICProducts";
            this.fld_chkCarcass.BOSDescription = null;
            this.fld_chkCarcass.BOSError = null;
            this.fld_chkCarcass.BOSFieldGroup = null;
            this.fld_chkCarcass.BOSFieldRelation = null;
            this.fld_chkCarcass.BOSPrivilege = null;
            this.fld_chkCarcass.BOSPropertyName = "EditValue";
            this.fld_chkCarcass.Location = new System.Drawing.Point(11, 28);
            this.fld_chkCarcass.MenuManager = this.screenToolbar;
            this.fld_chkCarcass.Name = "fld_chkCarcass";
            this.fld_chkCarcass.Properties.Caption = "Hàng mẫu";
            this.fld_chkCarcass.Screen = null;
            this.fld_chkCarcass.Size = new System.Drawing.Size(75, 20);
            this.fld_chkCarcass.TabIndex = 370;
            this.fld_chkCarcass.Tag = "DC";
            this.fld_chkCarcass.CheckedChanged += new System.EventHandler(this.fld_chkCarcass_CheckedChanged);
            // 
            // bosLabel25
            // 
            this.bosLabel25.BOSComment = null;
            this.bosLabel25.BOSDataMember = null;
            this.bosLabel25.BOSDataSource = null;
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = null;
            this.bosLabel25.BOSFieldRelation = null;
            this.bosLabel25.BOSPrivilege = null;
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(11, 480);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(60, 13);
            this.bosLabel25.TabIndex = 369;
            this.bosLabel25.Text = "Thương hiệu";
            // 
            // fld_chkICProductIsShowWeb
            // 
            this.fld_chkICProductIsShowWeb.BOSComment = "";
            this.fld_chkICProductIsShowWeb.BOSDataMember = "ICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.BOSDataSource = "ICProducts";
            this.fld_chkICProductIsShowWeb.BOSDescription = null;
            this.fld_chkICProductIsShowWeb.BOSError = "";
            this.fld_chkICProductIsShowWeb.BOSFieldGroup = "";
            this.fld_chkICProductIsShowWeb.BOSFieldRelation = "";
            this.fld_chkICProductIsShowWeb.BOSPrivilege = "";
            this.fld_chkICProductIsShowWeb.BOSPropertyName = "EditValue";
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(284, 499);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 24;
            this.fld_chkICProductIsShowWeb.Tag = "DC";
            // 
            // bosCheckEdit1
            // 
            this.bosCheckEdit1.BOSComment = null;
            this.bosCheckEdit1.BOSDataMember = "ICProductNonRetail";
            this.bosCheckEdit1.BOSDataSource = "ICProducts";
            this.bosCheckEdit1.BOSDescription = null;
            this.bosCheckEdit1.BOSError = null;
            this.bosCheckEdit1.BOSFieldGroup = null;
            this.bosCheckEdit1.BOSFieldRelation = null;
            this.bosCheckEdit1.BOSPrivilege = null;
            this.bosCheckEdit1.BOSPropertyName = "EditValue";
            this.bosCheckEdit1.Location = new System.Drawing.Point(284, 474);
            this.bosCheckEdit1.Name = "bosCheckEdit1";
            this.bosCheckEdit1.Properties.Caption = "Không bán lẻ";
            this.bosCheckEdit1.Screen = null;
            this.bosCheckEdit1.Size = new System.Drawing.Size(123, 20);
            this.bosCheckEdit1.TabIndex = 23;
            this.bosCheckEdit1.Tag = "DC";
            // 
            // fld_txtICProductStorageDay
            // 
            this.fld_txtICProductStorageDay.BOSComment = "";
            this.fld_txtICProductStorageDay.BOSDataMember = "ICProductStorageDay";
            this.fld_txtICProductStorageDay.BOSDataSource = "ICProducts";
            this.fld_txtICProductStorageDay.BOSDescription = null;
            this.fld_txtICProductStorageDay.BOSError = null;
            this.fld_txtICProductStorageDay.BOSFieldGroup = "";
            this.fld_txtICProductStorageDay.BOSFieldRelation = "";
            this.fld_txtICProductStorageDay.BOSPrivilege = "";
            this.fld_txtICProductStorageDay.BOSPropertyName = "Text";
            this.fld_txtICProductStorageDay.EditValue = "0";
            this.fld_txtICProductStorageDay.Location = new System.Drawing.Point(109, 527);
            this.fld_txtICProductStorageDay.Name = "fld_txtICProductStorageDay";
            this.fld_txtICProductStorageDay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductStorageDay.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductStorageDay.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductStorageDay.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductStorageDay.Properties.Mask.EditMask = "n";
            this.fld_txtICProductStorageDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductStorageDay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductStorageDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductStorageDay.Screen = null;
            this.fld_txtICProductStorageDay.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductStorageDay.TabIndex = 19;
            this.fld_txtICProductStorageDay.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ICProductGuaranteeMonth";
            this.bosTextBox1.BOSDataSource = "ICProducts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "0.00";
            this.bosTextBox1.Location = new System.Drawing.Point(110, 501);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(157, 20);
            this.bosTextBox1.TabIndex = 18;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel26.Location = new System.Drawing.Point(12, 530);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(77, 13);
            this.bosLabel26.TabIndex = 367;
            this.bosLabel26.Text = "Số ngày lưu kho";
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
            this.bosLabel20.Location = new System.Drawing.Point(11, 504);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(91, 13);
            this.bosLabel20.TabIndex = 367;
            this.bosLabel20.Text = "Số tháng bảo hành";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(11, 278);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(47, 13);
            this.bosLabel18.TabIndex = 366;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Loại hàng";
            // 
            // fld_lkeICProductTemplateType
            // 
            this.fld_lkeICProductTemplateType.BOSAllowAddNew = false;
            this.fld_lkeICProductTemplateType.BOSAllowDummy = false;
            this.fld_lkeICProductTemplateType.BOSComment = null;
            this.fld_lkeICProductTemplateType.BOSDataMember = "ICProductTemplateType";
            this.fld_lkeICProductTemplateType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductTemplateType.BOSDescription = null;
            this.fld_lkeICProductTemplateType.BOSError = null;
            this.fld_lkeICProductTemplateType.BOSFieldGroup = null;
            this.fld_lkeICProductTemplateType.BOSFieldParent = null;
            this.fld_lkeICProductTemplateType.BOSFieldRelation = null;
            this.fld_lkeICProductTemplateType.BOSPrivilege = null;
            this.fld_lkeICProductTemplateType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductTemplateType.BOSSelectType = "";
            this.fld_lkeICProductTemplateType.BOSSelectTypeValue = "";
            this.fld_lkeICProductTemplateType.CurrentDisplayText = null;
            this.fld_lkeICProductTemplateType.Location = new System.Drawing.Point(109, 275);
            this.fld_lkeICProductTemplateType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductTemplateType.Name = "fld_lkeICProductTemplateType";
            this.fld_lkeICProductTemplateType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductTemplateType.Properties.ColumnName = null;
            this.fld_lkeICProductTemplateType.Properties.NullText = "";
            this.fld_lkeICProductTemplateType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductTemplateType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductTemplateType, true);
            this.fld_lkeICProductTemplateType.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductTemplateType.TabIndex = 9;
            this.fld_lkeICProductTemplateType.Tag = "DC";
            // 
            // fld_btnAddProductImageDefault
            // 
            this.fld_btnAddProductImageDefault.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductImageDefault.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductImageDefault.BOSComment = "";
            this.fld_btnAddProductImageDefault.BOSDataMember = null;
            this.fld_btnAddProductImageDefault.BOSDataSource = null;
            this.fld_btnAddProductImageDefault.BOSDescription = null;
            this.fld_btnAddProductImageDefault.BOSError = null;
            this.fld_btnAddProductImageDefault.BOSFieldGroup = "";
            this.fld_btnAddProductImageDefault.BOSFieldRelation = "";
            this.fld_btnAddProductImageDefault.BOSPrivilege = "";
            this.fld_btnAddProductImageDefault.BOSPropertyName = null;
            this.fld_btnAddProductImageDefault.Location = new System.Drawing.Point(282, 371);
            this.fld_btnAddProductImageDefault.Name = "fld_btnAddProductImageDefault";
            this.fld_btnAddProductImageDefault.Screen = null;
            this.fld_btnAddProductImageDefault.Size = new System.Drawing.Size(125, 21);
            this.fld_btnAddProductImageDefault.TabIndex = 25;
            this.fld_btnAddProductImageDefault.Tag = "";
            this.fld_btnAddProductImageDefault.Text = "Chọn ảnh chính";
            this.fld_btnAddProductImageDefault.Visible = false;
            this.fld_btnAddProductImageDefault.Click += new System.EventHandler(this.fld_btnAddProductImageDefault_Click);
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.InitialImage = null;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(282, 228);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_ptbICProductPicture.TabIndex = 334;
            this.fld_ptbICProductPicture.TabStop = false;
            // 
            // fld_lkeICProductOrigin
            // 
            this.fld_lkeICProductOrigin.BOSAllowAddNew = false;
            this.fld_lkeICProductOrigin.BOSAllowDummy = false;
            this.fld_lkeICProductOrigin.BOSComment = null;
            this.fld_lkeICProductOrigin.BOSDataMember = "ICProductOrigin";
            this.fld_lkeICProductOrigin.BOSDataSource = "ICProducts";
            this.fld_lkeICProductOrigin.BOSDescription = null;
            this.fld_lkeICProductOrigin.BOSError = null;
            this.fld_lkeICProductOrigin.BOSFieldGroup = null;
            this.fld_lkeICProductOrigin.BOSFieldParent = null;
            this.fld_lkeICProductOrigin.BOSFieldRelation = null;
            this.fld_lkeICProductOrigin.BOSPrivilege = null;
            this.fld_lkeICProductOrigin.BOSPropertyName = "EditValue";
            this.fld_lkeICProductOrigin.BOSSelectType = "";
            this.fld_lkeICProductOrigin.BOSSelectTypeValue = "";
            this.fld_lkeICProductOrigin.CurrentDisplayText = null;
            this.fld_lkeICProductOrigin.Location = new System.Drawing.Point(110, 449);
            this.fld_lkeICProductOrigin.MenuManager = this.screenToolbar;
            this.fld_lkeICProductOrigin.Name = "fld_lkeICProductOrigin";
            this.fld_lkeICProductOrigin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductOrigin.Properties.ColumnName = null;
            this.fld_lkeICProductOrigin.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeICProductOrigin.Properties.NullText = "";
            this.fld_lkeICProductOrigin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductOrigin.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductOrigin, true);
            this.fld_lkeICProductOrigin.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductOrigin.TabIndex = 16;
            this.fld_lkeICProductOrigin.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(11, 452);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(38, 13);
            this.bosLabel12.TabIndex = 363;
            this.bosLabel12.Text = "Xuất xứ";
            // 
            // fld_chkICProductLockedPurchaseOrder
            // 
            this.fld_chkICProductLockedPurchaseOrder.BOSComment = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSDataMember = "ICProductLockedPurchaseOrder";
            this.fld_chkICProductLockedPurchaseOrder.BOSDataSource = "ICProducts";
            this.fld_chkICProductLockedPurchaseOrder.BOSDescription = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSError = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldGroup = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSFieldRelation = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPrivilege = null;
            this.fld_chkICProductLockedPurchaseOrder.BOSPropertyName = "EditValue";
            this.fld_chkICProductLockedPurchaseOrder.Location = new System.Drawing.Point(284, 423);
            this.fld_chkICProductLockedPurchaseOrder.MenuManager = this.screenToolbar;
            this.fld_chkICProductLockedPurchaseOrder.Name = "fld_chkICProductLockedPurchaseOrder";
            this.fld_chkICProductLockedPurchaseOrder.Properties.Caption = "Khóa mua hàng";
            this.fld_chkICProductLockedPurchaseOrder.Screen = null;
            this.fld_chkICProductLockedPurchaseOrder.Size = new System.Drawing.Size(104, 20);
            this.fld_chkICProductLockedPurchaseOrder.TabIndex = 21;
            this.fld_chkICProductLockedPurchaseOrder.Tag = "DC";
            // 
            // fld_lkeICProductOriginOfProduct
            // 
            this.fld_lkeICProductOriginOfProduct.BOSAllowAddNew = false;
            this.fld_lkeICProductOriginOfProduct.BOSAllowDummy = false;
            this.fld_lkeICProductOriginOfProduct.BOSComment = null;
            this.fld_lkeICProductOriginOfProduct.BOSDataMember = "ICProductOriginOfProduct";
            this.fld_lkeICProductOriginOfProduct.BOSDataSource = "ICProducts";
            this.fld_lkeICProductOriginOfProduct.BOSDescription = null;
            this.fld_lkeICProductOriginOfProduct.BOSError = null;
            this.fld_lkeICProductOriginOfProduct.BOSFieldGroup = null;
            this.fld_lkeICProductOriginOfProduct.BOSFieldParent = null;
            this.fld_lkeICProductOriginOfProduct.BOSFieldRelation = null;
            this.fld_lkeICProductOriginOfProduct.BOSPrivilege = null;
            this.fld_lkeICProductOriginOfProduct.BOSPropertyName = "EditValue";
            this.fld_lkeICProductOriginOfProduct.BOSSelectType = "";
            this.fld_lkeICProductOriginOfProduct.BOSSelectTypeValue = "";
            this.fld_lkeICProductOriginOfProduct.CurrentDisplayText = null;
            this.fld_lkeICProductOriginOfProduct.Location = new System.Drawing.Point(110, 423);
            this.fld_lkeICProductOriginOfProduct.Name = "fld_lkeICProductOriginOfProduct";
            this.fld_lkeICProductOriginOfProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductOriginOfProduct.Properties.ColumnName = null;
            this.fld_lkeICProductOriginOfProduct.Properties.NullText = "";
            this.fld_lkeICProductOriginOfProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductOriginOfProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductOriginOfProduct, true);
            this.fld_lkeICProductOriginOfProduct.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductOriginOfProduct.TabIndex = 15;
            this.fld_lkeICProductOriginOfProduct.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(11, 426);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(66, 13);
            this.bosLabel11.TabIndex = 361;
            this.bosLabel11.Text = "Nguồn gốc SP";
            // 
            // fld_lkeICProductWorkType
            // 
            this.fld_lkeICProductWorkType.BOSAllowAddNew = false;
            this.fld_lkeICProductWorkType.BOSAllowDummy = false;
            this.fld_lkeICProductWorkType.BOSComment = null;
            this.fld_lkeICProductWorkType.BOSDataMember = "ICProductWorkType";
            this.fld_lkeICProductWorkType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductWorkType.BOSDescription = null;
            this.fld_lkeICProductWorkType.BOSError = null;
            this.fld_lkeICProductWorkType.BOSFieldGroup = null;
            this.fld_lkeICProductWorkType.BOSFieldParent = null;
            this.fld_lkeICProductWorkType.BOSFieldRelation = null;
            this.fld_lkeICProductWorkType.BOSPrivilege = null;
            this.fld_lkeICProductWorkType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductWorkType.BOSSelectType = "";
            this.fld_lkeICProductWorkType.BOSSelectTypeValue = "";
            this.fld_lkeICProductWorkType.CurrentDisplayText = null;
            this.fld_lkeICProductWorkType.Location = new System.Drawing.Point(110, 397);
            this.fld_lkeICProductWorkType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductWorkType.Name = "fld_lkeICProductWorkType";
            this.fld_lkeICProductWorkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductWorkType.Properties.ColumnName = null;
            this.fld_lkeICProductWorkType.Properties.NullText = "";
            this.fld_lkeICProductWorkType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductWorkType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductWorkType, true);
            this.fld_lkeICProductWorkType.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductWorkType.TabIndex = 14;
            this.fld_lkeICProductWorkType.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(11, 400);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(90, 13);
            this.bosLabel7.TabIndex = 358;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Loại hình thực hiện";
            // 
            // fld_txtICProductBarCode
            // 
            this.fld_txtICProductBarCode.BOSComment = null;
            this.fld_txtICProductBarCode.BOSDataMember = "ICProductBarCode";
            this.fld_txtICProductBarCode.BOSDataSource = "ICProducts";
            this.fld_txtICProductBarCode.BOSDescription = null;
            this.fld_txtICProductBarCode.BOSError = null;
            this.fld_txtICProductBarCode.BOSFieldGroup = null;
            this.fld_txtICProductBarCode.BOSFieldRelation = null;
            this.fld_txtICProductBarCode.BOSPrivilege = null;
            this.fld_txtICProductBarCode.BOSPropertyName = "Text";
            this.fld_txtICProductBarCode.Location = new System.Drawing.Point(110, 370);
            this.fld_txtICProductBarCode.MenuManager = this.screenToolbar;
            this.fld_txtICProductBarCode.Name = "fld_txtICProductBarCode";
            this.fld_txtICProductBarCode.Screen = null;
            this.fld_txtICProductBarCode.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductBarCode.TabIndex = 13;
            this.fld_txtICProductBarCode.Tag = "DC";
            // 
            // fld_txtICProductCustomerNumber
            // 
            this.fld_txtICProductCustomerNumber.BOSComment = null;
            this.fld_txtICProductCustomerNumber.BOSDataMember = "ICProductCustomerNumber";
            this.fld_txtICProductCustomerNumber.BOSDataSource = "ICProducts";
            this.fld_txtICProductCustomerNumber.BOSDescription = null;
            this.fld_txtICProductCustomerNumber.BOSError = null;
            this.fld_txtICProductCustomerNumber.BOSFieldGroup = null;
            this.fld_txtICProductCustomerNumber.BOSFieldRelation = null;
            this.fld_txtICProductCustomerNumber.BOSPrivilege = null;
            this.fld_txtICProductCustomerNumber.BOSPropertyName = "Text";
            this.fld_txtICProductCustomerNumber.Location = new System.Drawing.Point(110, 107);
            this.fld_txtICProductCustomerNumber.MenuManager = this.screenToolbar;
            this.fld_txtICProductCustomerNumber.Name = "fld_txtICProductCustomerNumber";
            this.fld_txtICProductCustomerNumber.Screen = null;
            this.fld_txtICProductCustomerNumber.Size = new System.Drawing.Size(192, 20);
            this.fld_txtICProductCustomerNumber.TabIndex = 3;
            this.fld_txtICProductCustomerNumber.Tag = "DC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.BOSComment = null;
            this.fld_lblLabel13.BOSDataMember = null;
            this.fld_lblLabel13.BOSDataSource = null;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = null;
            this.fld_lblLabel13.BOSFieldRelation = null;
            this.fld_lblLabel13.BOSPrivilege = null;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(11, 370);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel13.TabIndex = 339;
            this.fld_lblLabel13.Text = "Mã vạch";
            // 
            // fld_lbl5
            // 
            this.fld_lbl5.BOSComment = null;
            this.fld_lbl5.BOSDataMember = null;
            this.fld_lbl5.BOSDataSource = null;
            this.fld_lbl5.BOSDescription = null;
            this.fld_lbl5.BOSError = null;
            this.fld_lbl5.BOSFieldGroup = null;
            this.fld_lbl5.BOSFieldRelation = null;
            this.fld_lbl5.BOSPrivilege = null;
            this.fld_lbl5.BOSPropertyName = null;
            this.fld_lbl5.Location = new System.Drawing.Point(11, 110);
            this.fld_lbl5.Name = "fld_lbl5";
            this.fld_lbl5.Screen = null;
            this.fld_lbl5.Size = new System.Drawing.Size(64, 13);
            this.fld_lbl5.TabIndex = 343;
            this.fld_lbl5.Text = "Mã SP đối tác";
            // 
            // fld_txtICProductNoOfOldSys
            // 
            this.fld_txtICProductNoOfOldSys.BOSComment = null;
            this.fld_txtICProductNoOfOldSys.BOSDataMember = "ICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.BOSDataSource = "ICProducts";
            this.fld_txtICProductNoOfOldSys.BOSDescription = null;
            this.fld_txtICProductNoOfOldSys.BOSError = null;
            this.fld_txtICProductNoOfOldSys.BOSFieldGroup = null;
            this.fld_txtICProductNoOfOldSys.BOSFieldRelation = null;
            this.fld_txtICProductNoOfOldSys.BOSPrivilege = null;
            this.fld_txtICProductNoOfOldSys.BOSPropertyName = "Text";
            this.fld_txtICProductNoOfOldSys.Location = new System.Drawing.Point(109, 81);
            this.fld_txtICProductNoOfOldSys.MenuManager = this.screenToolbar;
            this.fld_txtICProductNoOfOldSys.Name = "fld_txtICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.Screen = null;
            this.fld_txtICProductNoOfOldSys.Size = new System.Drawing.Size(193, 20);
            this.fld_txtICProductNoOfOldSys.TabIndex = 2;
            this.fld_txtICProductNoOfOldSys.Tag = "DC";
            // 
            // fld_txtMHTold
            // 
            this.fld_txtMHTold.BOSComment = null;
            this.fld_txtMHTold.BOSDataMember = null;
            this.fld_txtMHTold.BOSDataSource = null;
            this.fld_txtMHTold.BOSDescription = null;
            this.fld_txtMHTold.BOSError = null;
            this.fld_txtMHTold.BOSFieldGroup = null;
            this.fld_txtMHTold.BOSFieldRelation = null;
            this.fld_txtMHTold.BOSPrivilege = null;
            this.fld_txtMHTold.BOSPropertyName = null;
            this.fld_txtMHTold.Location = new System.Drawing.Point(11, 84);
            this.fld_txtMHTold.Name = "fld_txtMHTold";
            this.fld_txtMHTold.Screen = null;
            this.fld_txtMHTold.Size = new System.Drawing.Size(44, 13);
            this.fld_txtMHTold.TabIndex = 341;
            this.fld_txtMHTold.Text = "Mã HT cũ";
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "ICProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "ICProducts";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(109, 249);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(157, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 8;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_chkICProductPromotionCheck
            // 
            this.fld_chkICProductPromotionCheck.BOSComment = null;
            this.fld_chkICProductPromotionCheck.BOSDataMember = "ICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.BOSDataSource = "ICProducts";
            this.fld_chkICProductPromotionCheck.BOSDescription = null;
            this.fld_chkICProductPromotionCheck.BOSError = null;
            this.fld_chkICProductPromotionCheck.BOSFieldGroup = null;
            this.fld_chkICProductPromotionCheck.BOSFieldRelation = null;
            this.fld_chkICProductPromotionCheck.BOSPrivilege = null;
            this.fld_chkICProductPromotionCheck.BOSPropertyName = "EditValue";
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(284, 449);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 22;
            this.fld_chkICProductPromotionCheck.Tag = "DC";
            // 
            // fld_chkICProductActiveCheck
            // 
            this.fld_chkICProductActiveCheck.BOSComment = null;
            this.fld_chkICProductActiveCheck.BOSDataMember = "ICProductActiveCheck";
            this.fld_chkICProductActiveCheck.BOSDataSource = "ICProducts";
            this.fld_chkICProductActiveCheck.BOSDescription = null;
            this.fld_chkICProductActiveCheck.BOSError = null;
            this.fld_chkICProductActiveCheck.BOSFieldGroup = null;
            this.fld_chkICProductActiveCheck.BOSFieldRelation = null;
            this.fld_chkICProductActiveCheck.BOSPrivilege = null;
            this.fld_chkICProductActiveCheck.BOSPropertyName = "EditValue";
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(284, 398);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 20;
            this.fld_chkICProductActiveCheck.Tag = "DC";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = "";
            this.fld_lkeFK_APSupplierID.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(109, 328);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã nhà cung cấp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên nhà cung cấp")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 11;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(110, 350);
            this.fld_lnkOpenSupplier.MenuManager = this.screenToolbar;
            this.fld_lnkOpenSupplier.Name = "fld_lnkOpenSupplier";
            this.fld_lnkOpenSupplier.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkOpenSupplier.Size = new System.Drawing.Size(155, 18);
            this.fld_lnkOpenSupplier.TabIndex = 12;
            this.fld_lnkOpenSupplier.TabStop = false;
            this.fld_lnkOpenSupplier.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkOpenSupplier_OpenLink);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "ICProductName";
            this.bosLabel3.BOSDataSource = "ICProducts";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(11, 136);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(65, 13);
            this.bosLabel3.TabIndex = 339;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tên tiếng việt";
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment = "";
            this.fld_txtICProductName.BOSDataMember = "ICProductName";
            this.fld_txtICProductName.BOSDataSource = "ICProducts";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = null;
            this.fld_txtICProductName.BOSFieldGroup = "";
            this.fld_txtICProductName.BOSFieldRelation = "";
            this.fld_txtICProductName.BOSPrivilege = "";
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.EditValue = "";
            this.fld_txtICProductName.Location = new System.Drawing.Point(110, 159);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(192, 20);
            this.fld_txtICProductName.TabIndex = 5;
            this.fld_txtICProductName.Tag = "DC";
            // 
            // fld_txtICProductName2
            // 
            this.fld_txtICProductName2.BOSComment = "";
            this.fld_txtICProductName2.BOSDataMember = "ICProductName2";
            this.fld_txtICProductName2.BOSDataSource = "ICProducts";
            this.fld_txtICProductName2.BOSDescription = null;
            this.fld_txtICProductName2.BOSError = null;
            this.fld_txtICProductName2.BOSFieldGroup = "";
            this.fld_txtICProductName2.BOSFieldRelation = "";
            this.fld_txtICProductName2.BOSPrivilege = "";
            this.fld_txtICProductName2.BOSPropertyName = "Text";
            this.fld_txtICProductName2.EditValue = "";
            this.fld_txtICProductName2.Location = new System.Drawing.Point(110, 133);
            this.fld_txtICProductName2.Name = "fld_txtICProductName2";
            this.fld_txtICProductName2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName2.Screen = null;
            this.fld_txtICProductName2.Size = new System.Drawing.Size(192, 20);
            this.fld_txtICProductName2.TabIndex = 4;
            this.fld_txtICProductName2.Tag = "DC";
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(110, 228);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 7;
            this.fld_lnkSetDefaultDesc.TabStop = false;
            this.fld_lnkSetDefaultDesc.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkSetDefaultDesc_OpenLink);
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseFont = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "ICProductNo";
            this.fld_lblLabel15.BOSDataSource = "ICProducts";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = "";
            this.fld_lblLabel15.Location = new System.Drawing.Point(11, 58);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel15.TabIndex = 340;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã sản phẩm";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(11, 162);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 356;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên sản phẩm";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseFont = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment = "";
            this.fld_lblLabel21.BOSDataMember = "";
            this.fld_lblLabel21.BOSDataSource = "";
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup = "";
            this.fld_lblLabel21.BOSFieldRelation = "";
            this.fld_lblLabel21.BOSPrivilege = "";
            this.fld_lblLabel21.BOSPropertyName = "";
            this.fld_lblLabel21.Location = new System.Drawing.Point(11, 188);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 13;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Mô tả";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = "";
            this.fld_lblLabel28.Location = new System.Drawing.Point(11, 252);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 20;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Nhóm hàng";
            // 
            // fld_medICProductDesc
            // 
            this.fld_medICProductDesc.BOSComment = "";
            this.fld_medICProductDesc.BOSDataMember = "ICProductDesc";
            this.fld_medICProductDesc.BOSDataSource = "ICProducts";
            this.fld_medICProductDesc.BOSDescription = null;
            this.fld_medICProductDesc.BOSError = null;
            this.fld_medICProductDesc.BOSFieldGroup = "";
            this.fld_medICProductDesc.BOSFieldRelation = "";
            this.fld_medICProductDesc.BOSPrivilege = "";
            this.fld_medICProductDesc.BOSPropertyName = "Text";
            this.fld_medICProductDesc.EditValue = "";
            this.fld_medICProductDesc.Location = new System.Drawing.Point(110, 185);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.fld_medICProductDesc.Size = new System.Drawing.Size(297, 37);
            this.fld_medICProductDesc.TabIndex = 6;
            this.fld_medICProductDesc.Tag = "DC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(11, 331);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel1.TabIndex = 271;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Nhà cung cấp";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = "";
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = null;
            this.fld_txtICProductNo.BOSFieldGroup = "";
            this.fld_txtICProductNo.BOSFieldRelation = "";
            this.fld_txtICProductNo.BOSPrivilege = "";
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.EditValue = "";
            this.fld_txtICProductNo.Location = new System.Drawing.Point(110, 55);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(191, 20);
            this.fld_txtICProductNo.TabIndex = 1;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel42);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeICProductCollection);
            this.fld_grcGroupControl1.Controls.Add(this.fld_ckICProductIsFollowInventoryStock);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICPriceCalculationMethodID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel27);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEVATID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkShowHistoryBranchPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkEditPurchasePrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkOpenBranchPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkEditPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductPrice01);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductSupplierPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(3, 605);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(222, 336);
            this.fld_grcGroupControl1.TabIndex = 1;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Đơn vị tính && Giá";
            // 
            // bosLabel42
            // 
            this.bosLabel42.BOSComment = null;
            this.bosLabel42.BOSDataMember = null;
            this.bosLabel42.BOSDataSource = null;
            this.bosLabel42.BOSDescription = null;
            this.bosLabel42.BOSError = null;
            this.bosLabel42.BOSFieldGroup = null;
            this.bosLabel42.BOSFieldRelation = null;
            this.bosLabel42.BOSPrivilege = null;
            this.bosLabel42.BOSPropertyName = null;
            this.bosLabel42.Location = new System.Drawing.Point(9, 187);
            this.bosLabel42.Name = "bosLabel42";
            this.bosLabel42.Screen = null;
            this.bosLabel42.Size = new System.Drawing.Size(46, 13);
            this.bosLabel42.TabIndex = 478;
            this.bosLabel42.Text = "Collection";
            this.bosLabel42.Visible = false;
            // 
            // fld_lkeICProductCollection
            // 
            this.fld_lkeICProductCollection.BOSAllowAddNew = false;
            this.fld_lkeICProductCollection.BOSAllowDummy = false;
            this.fld_lkeICProductCollection.BOSComment = null;
            this.fld_lkeICProductCollection.BOSDataMember = "ICProductCollection";
            this.fld_lkeICProductCollection.BOSDataSource = "ICProducts";
            this.fld_lkeICProductCollection.BOSDescription = null;
            this.fld_lkeICProductCollection.BOSError = null;
            this.fld_lkeICProductCollection.BOSFieldGroup = null;
            this.fld_lkeICProductCollection.BOSFieldParent = null;
            this.fld_lkeICProductCollection.BOSFieldRelation = null;
            this.fld_lkeICProductCollection.BOSPrivilege = null;
            this.fld_lkeICProductCollection.BOSPropertyName = "EditValue";
            this.fld_lkeICProductCollection.BOSSelectType = "";
            this.fld_lkeICProductCollection.BOSSelectTypeValue = "";
            this.fld_lkeICProductCollection.CurrentDisplayText = null;
            this.fld_lkeICProductCollection.Location = new System.Drawing.Point(83, 180);
            this.fld_lkeICProductCollection.MenuManager = this.screenToolbar;
            this.fld_lkeICProductCollection.Name = "fld_lkeICProductCollection";
            this.fld_lkeICProductCollection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductCollection.Properties.ColumnName = null;
            this.fld_lkeICProductCollection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeICProductCollection.Properties.NullText = "";
            this.fld_lkeICProductCollection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductCollection.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductCollection, true);
            this.fld_lkeICProductCollection.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeICProductCollection.TabIndex = 479;
            this.fld_lkeICProductCollection.Tag = "DC";
            this.fld_lkeICProductCollection.Visible = false;
            // 
            // fld_ckICProductIsFollowInventoryStock
            // 
            this.fld_ckICProductIsFollowInventoryStock.BOSComment = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSDataMember = "ICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.BOSDataSource = "ICProducts";
            this.fld_ckICProductIsFollowInventoryStock.BOSDescription = null;
            this.fld_ckICProductIsFollowInventoryStock.BOSError = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSFieldGroup = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSFieldRelation = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSPrivilege = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSPropertyName = "EditValue";
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(8, 154);
            this.fld_ckICProductIsFollowInventoryStock.Name = "fld_ckICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Caption = "Theo dõi tồn kho";
            this.fld_ckICProductIsFollowInventoryStock.Screen = null;
            this.fld_ckICProductIsFollowInventoryStock.Size = new System.Drawing.Size(111, 20);
            this.fld_ckICProductIsFollowInventoryStock.TabIndex = 9;
            this.fld_ckICProductIsFollowInventoryStock.Tag = "DC";
            // 
            // fld_lkeFK_ICPriceCalculationMethodID
            // 
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSAllowDummy = false;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSComment = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDataMember = "FK_ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDescription = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSError = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldGroup = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldParent = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldRelation = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSPrivilege = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSSelectType = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.CurrentDisplayText = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(83, 128);
            this.fld_lkeFK_ICPriceCalculationMethodID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICPriceCalculationMethodID.Name = "fld_lkeFK_ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.ColumnName = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPriceCalculationMethodName", "Tên phương pháp")});
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.DisplayMember = "ICPriceCalculationMethodName";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.NullText = "";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.ValueMember = "ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.Screen = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICPriceCalculationMethodID.TabIndex = 4;
            this.fld_lkeFK_ICPriceCalculationMethodID.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(9, 132);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(50, 13);
            this.bosLabel27.TabIndex = 345;
            this.bosLabel27.Text = "PP tính giá";
            // 
            // fld_lkeFK_GEVATID
            // 
            this.fld_lkeFK_GEVATID.BOSAllowAddNew = false;
            this.fld_lkeFK_GEVATID.BOSAllowDummy = true;
            this.fld_lkeFK_GEVATID.BOSComment = "";
            this.fld_lkeFK_GEVATID.BOSDataMember = "FK_GEVATID";
            this.fld_lkeFK_GEVATID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_GEVATID.BOSDescription = null;
            this.fld_lkeFK_GEVATID.BOSError = null;
            this.fld_lkeFK_GEVATID.BOSFieldGroup = "";
            this.fld_lkeFK_GEVATID.BOSFieldParent = "";
            this.fld_lkeFK_GEVATID.BOSFieldRelation = "";
            this.fld_lkeFK_GEVATID.BOSPrivilege = "";
            this.fld_lkeFK_GEVATID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GEVATID.BOSSelectType = "";
            this.fld_lkeFK_GEVATID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GEVATID.CurrentDisplayText = null;
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(83, 76);
            this.fld_lkeFK_GEVATID.Name = "fld_lkeFK_GEVATID";
            this.fld_lkeFK_GEVATID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEVATID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEVATID.Properties.ColumnName = null;
            this.fld_lkeFK_GEVATID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATPercentValue", "% thuế", 10, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEVATID.Properties.DisplayFormat.FormatString = "n0";
            this.fld_lkeFK_GEVATID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeFK_GEVATID.Properties.DisplayMember = "GEVATPercentValue";
            this.fld_lkeFK_GEVATID.Properties.EditFormat.FormatString = "n0";
            this.fld_lkeFK_GEVATID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeFK_GEVATID.Properties.NullText = "";
            this.fld_lkeFK_GEVATID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEVATID.Properties.ValueMember = "GEVATID";
            this.fld_lkeFK_GEVATID.Screen = null;
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 2;
            this.fld_lkeFK_GEVATID.Tag = "DC";
            // 
            // fld_lnkShowHistoryBranchPrice
            // 
            this.fld_lnkShowHistoryBranchPrice.EditValue = "Lịch sử giá bán theo chi nhánh";
            this.fld_lnkShowHistoryBranchPrice.Location = new System.Drawing.Point(227, 74);
            this.fld_lnkShowHistoryBranchPrice.MenuManager = this.screenToolbar;
            this.fld_lnkShowHistoryBranchPrice.Name = "fld_lnkShowHistoryBranchPrice";
            this.fld_lnkShowHistoryBranchPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkShowHistoryBranchPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkShowHistoryBranchPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkShowHistoryBranchPrice.Size = new System.Drawing.Size(169, 18);
            this.fld_lnkShowHistoryBranchPrice.TabIndex = 8;
            this.fld_lnkShowHistoryBranchPrice.TabStop = false;
            this.fld_lnkShowHistoryBranchPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkShowHistoryBranchPrice_OpenLink);
            // 
            // fld_lnkEditPurchasePrice
            // 
            this.fld_lnkEditPurchasePrice.EditValue = "Sửa giá mua theo tiền tệ";
            this.fld_lnkEditPurchasePrice.Location = new System.Drawing.Point(227, 50);
            this.fld_lnkEditPurchasePrice.Name = "fld_lnkEditPurchasePrice";
            this.fld_lnkEditPurchasePrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPurchasePrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPurchasePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkEditPurchasePrice.Size = new System.Drawing.Size(155, 18);
            this.fld_lnkEditPurchasePrice.TabIndex = 7;
            this.fld_lnkEditPurchasePrice.TabStop = false;
            this.fld_lnkEditPurchasePrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPurchasePrice_OpenLink);
            // 
            // fld_lnkOpenBranchPrice
            // 
            this.fld_lnkOpenBranchPrice.EditValue = "Sửa giá các chi nhánh";
            this.fld_lnkOpenBranchPrice.Location = new System.Drawing.Point(304, 28);
            this.fld_lnkOpenBranchPrice.MenuManager = this.screenToolbar;
            this.fld_lnkOpenBranchPrice.Name = "fld_lnkOpenBranchPrice";
            this.fld_lnkOpenBranchPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenBranchPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenBranchPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkOpenBranchPrice.Size = new System.Drawing.Size(126, 18);
            this.fld_lnkOpenBranchPrice.TabIndex = 6;
            this.fld_lnkOpenBranchPrice.TabStop = false;
            this.fld_lnkOpenBranchPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkOpenBranchPrice_OpenLink);
            // 
            // fld_lkeFK_ICProductBasicUnitID
            // 
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSComment = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataMember = "FK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDescription = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSError = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectType = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductBasicUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(83, 102);
            this.fld_lkeFK_ICProductBasicUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Tên")});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.NullText = "";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Screen = null;
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 3;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.BOSComment = null;
            this.fld_lblLabel16.BOSDataMember = null;
            this.fld_lblLabel16.BOSDataSource = null;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = null;
            this.fld_lblLabel16.BOSFieldRelation = null;
            this.fld_lblLabel16.BOSPrivilege = null;
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(9, 105);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel16.TabIndex = 341;
            this.fld_lblLabel16.Text = "ĐVT";
            // 
            // fld_lnkEditPrice
            // 
            this.fld_lnkEditPrice.EditValue = "Sửa mức giá";
            this.fld_lnkEditPrice.Location = new System.Drawing.Point(134, 156);
            this.fld_lnkEditPrice.MenuManager = this.screenToolbar;
            this.fld_lnkEditPrice.Name = "fld_lnkEditPrice";
            this.fld_lnkEditPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkEditPrice.Size = new System.Drawing.Size(74, 18);
            this.fld_lnkEditPrice.TabIndex = 5;
            this.fld_lnkEditPrice.TabStop = false;
            this.fld_lnkEditPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPrice_OpenLink);
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseFont = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(9, 80);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel.TabIndex = 253;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Thuế BL";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = "";
            this.fld_lblLabel14.Location = new System.Drawing.Point(9, 54);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel14.TabIndex = 266;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Giá mua";
            // 
            // fld_txtICProductPrice01
            // 
            this.fld_txtICProductPrice01.BOSComment = "";
            this.fld_txtICProductPrice01.BOSDataMember = "ICProductPrice01";
            this.fld_txtICProductPrice01.BOSDataSource = "ICProducts";
            this.fld_txtICProductPrice01.BOSDescription = null;
            this.fld_txtICProductPrice01.BOSError = null;
            this.fld_txtICProductPrice01.BOSFieldGroup = "";
            this.fld_txtICProductPrice01.BOSFieldRelation = "";
            this.fld_txtICProductPrice01.BOSPrivilege = "";
            this.fld_txtICProductPrice01.BOSPropertyName = "Text";
            this.fld_txtICProductPrice01.EditValue = "0.000";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(83, 24);
            this.fld_txtICProductPrice01.Name = "fld_txtICProductPrice01";
            this.fld_txtICProductPrice01.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductPrice01.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductPrice01.Properties.Mask.EditMask = "0.000";
            this.fld_txtICProductPrice01.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductPrice01.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductPrice01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductPrice01.Screen = null;
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductPrice01.TabIndex = 0;
            this.fld_txtICProductPrice01.Tag = "DC";
            // 
            // fld_txtICProductSupplierPrice
            // 
            this.fld_txtICProductSupplierPrice.BOSComment = "";
            this.fld_txtICProductSupplierPrice.BOSDataMember = "ICProductSupplierPrice";
            this.fld_txtICProductSupplierPrice.BOSDataSource = "ICProducts";
            this.fld_txtICProductSupplierPrice.BOSDescription = null;
            this.fld_txtICProductSupplierPrice.BOSError = null;
            this.fld_txtICProductSupplierPrice.BOSFieldGroup = "";
            this.fld_txtICProductSupplierPrice.BOSFieldRelation = "";
            this.fld_txtICProductSupplierPrice.BOSPrivilege = "";
            this.fld_txtICProductSupplierPrice.BOSPropertyName = "Text";
            this.fld_txtICProductSupplierPrice.EditValue = "0.000";
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(83, 50);
            this.fld_txtICProductSupplierPrice.Name = "fld_txtICProductSupplierPrice";
            this.fld_txtICProductSupplierPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Mask.EditMask = "0.000";
            this.fld_txtICProductSupplierPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductSupplierPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierPrice.Screen = null;
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductSupplierPrice.TabIndex = 1;
            this.fld_txtICProductSupplierPrice.Tag = "DC";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseFont = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = "";
            this.fld_lblLabel23.Location = new System.Drawing.Point(9, 29);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel23.TabIndex = 325;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Giá bán";
            // 
            // fld_tabComponent
            // 
            this.fld_tabComponent.Controls.Add(this.fld_dgcICProductComponents);
            this.fld_tabComponent.Controls.Add(this.fld_btnAddProductComponentItem);
            this.fld_tabComponent.Name = "fld_tabComponent";
            this.fld_tabComponent.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabComponent.Text = "Thành phần";
            // 
            // fld_dgcICProductComponents
            // 
            this.fld_dgcICProductComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductComponents.BOSComment = null;
            this.fld_dgcICProductComponents.BOSDataMember = null;
            this.fld_dgcICProductComponents.BOSDataSource = "ICProductComponents";
            this.fld_dgcICProductComponents.BOSDescription = null;
            this.fld_dgcICProductComponents.BOSError = null;
            this.fld_dgcICProductComponents.BOSFieldGroup = null;
            this.fld_dgcICProductComponents.BOSFieldRelation = null;
            this.fld_dgcICProductComponents.BOSGridType = null;
            this.fld_dgcICProductComponents.BOSPrivilege = null;
            this.fld_dgcICProductComponents.BOSPropertyName = null;
            this.fld_dgcICProductComponents.CommodityType = "";
            this.fld_dgcICProductComponents.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductComponents.MenuManager = this.screenToolbar;
            this.fld_dgcICProductComponents.Name = "fld_dgcICProductComponents";
            this.fld_dgcICProductComponents.PrintReport = false;
            this.fld_dgcICProductComponents.Screen = null;
            this.fld_dgcICProductComponents.Size = new System.Drawing.Size(1289, 893);
            this.fld_dgcICProductComponents.TabIndex = 2;
            // 
            // fld_btnAddProductComponentItem
            // 
            this.fld_btnAddProductComponentItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductComponentItem.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductComponentItem.BOSComment = "";
            this.fld_btnAddProductComponentItem.BOSDataMember = null;
            this.fld_btnAddProductComponentItem.BOSDataSource = null;
            this.fld_btnAddProductComponentItem.BOSDescription = null;
            this.fld_btnAddProductComponentItem.BOSError = null;
            this.fld_btnAddProductComponentItem.BOSFieldGroup = "";
            this.fld_btnAddProductComponentItem.BOSFieldRelation = "";
            this.fld_btnAddProductComponentItem.BOSPrivilege = "";
            this.fld_btnAddProductComponentItem.BOSPropertyName = null;
            this.fld_btnAddProductComponentItem.Location = new System.Drawing.Point(3, 3);
            this.fld_btnAddProductComponentItem.Name = "fld_btnAddProductComponentItem";
            this.fld_btnAddProductComponentItem.Screen = null;
            this.fld_btnAddProductComponentItem.Size = new System.Drawing.Size(115, 27);
            this.fld_btnAddProductComponentItem.TabIndex = 1;
            this.fld_btnAddProductComponentItem.Tag = "";
            this.fld_btnAddProductComponentItem.Text = "Thêm thành phần";
            this.fld_btnAddProductComponentItem.Click += new System.EventHandler(this.fld_btnAddProductComponentItem_Click);
            // 
            // fld_tabAccountStockHistory
            // 
            this.fld_tabAccountStockHistory.Controls.Add(this.fld_tabProductTask);
            this.fld_tabAccountStockHistory.Controls.Add(this.bosGroupControl1);
            this.fld_tabAccountStockHistory.Name = "fld_tabAccountStockHistory";
            this.fld_tabAccountStockHistory.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabAccountStockHistory.Text = "Công việc - vật tư - MMTB - Task ";
            // 
            // fld_tabProductTask
            // 
            this.fld_tabProductTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductTask.BOSComment = null;
            this.fld_tabProductTask.BOSDataMember = null;
            this.fld_tabProductTask.BOSDataSource = "ICProductWorkItems";
            this.fld_tabProductTask.BOSDescription = null;
            this.fld_tabProductTask.BOSError = null;
            this.fld_tabProductTask.BOSFieldGroup = null;
            this.fld_tabProductTask.BOSFieldRelation = null;
            this.fld_tabProductTask.BOSPrivilege = null;
            this.fld_tabProductTask.BOSPropertyName = null;
            this.fld_tabProductTask.Location = new System.Drawing.Point(2, 90);
            this.fld_tabProductTask.Name = "fld_tabProductTask";
            this.fld_tabProductTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductTask.Screen = null;
            this.fld_tabProductTask.SelectedTabPage = this.fld_tabWork;
            this.fld_tabProductTask.Size = new System.Drawing.Size(1285, 844);
            this.fld_tabProductTask.TabIndex = 6;
            this.fld_tabProductTask.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabWork,
            this.fld_tabMaterial,
            this.fld_tabAsset,
            this.fld_tabTask,
            this.fld_tabBatchProductItems,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // fld_tabWork
            // 
            this.fld_tabWork.Controls.Add(this.fld_dgcICProductWorkItemsGridControl);
            this.fld_tabWork.Controls.Add(this.fld_btnAddProductWork);
            this.fld_tabWork.Name = "fld_tabWork";
            this.fld_tabWork.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabWork.Size = new System.Drawing.Size(1283, 819);
            this.fld_tabWork.Text = "Công việc thực hiện";
            // 
            // fld_dgcICProductWorkItemsGridControl
            // 
            this.fld_dgcICProductWorkItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductWorkItemsGridControl.BOSComment = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSDataMember = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcICProductWorkItemsGridControl.BOSDescription = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSError = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSGridType = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSPrivilege = null;
            this.fld_dgcICProductWorkItemsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductWorkItemsGridControl.CommodityType = "";
            this.fld_dgcICProductWorkItemsGridControl.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductWorkItemsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductWorkItemsGridControl.Name = "fld_dgcICProductWorkItemsGridControl";
            this.fld_dgcICProductWorkItemsGridControl.PrintReport = false;
            this.fld_dgcICProductWorkItemsGridControl.Screen = null;
            this.fld_dgcICProductWorkItemsGridControl.Size = new System.Drawing.Size(1277, 793);
            this.fld_dgcICProductWorkItemsGridControl.TabIndex = 12;
            // 
            // fld_btnAddProductWork
            // 
            this.fld_btnAddProductWork.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductWork.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductWork.BOSComment = "";
            this.fld_btnAddProductWork.BOSDataMember = null;
            this.fld_btnAddProductWork.BOSDataSource = null;
            this.fld_btnAddProductWork.BOSDescription = null;
            this.fld_btnAddProductWork.BOSError = null;
            this.fld_btnAddProductWork.BOSFieldGroup = "";
            this.fld_btnAddProductWork.BOSFieldRelation = "";
            this.fld_btnAddProductWork.BOSPrivilege = "";
            this.fld_btnAddProductWork.BOSPropertyName = null;
            this.fld_btnAddProductWork.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddProductWork.Name = "fld_btnAddProductWork";
            this.fld_btnAddProductWork.Screen = null;
            this.fld_btnAddProductWork.Size = new System.Drawing.Size(133, 27);
            this.fld_btnAddProductWork.TabIndex = 11;
            this.fld_btnAddProductWork.Tag = "";
            this.fld_btnAddProductWork.Text = "Thêm công việc thực hiện";
            this.fld_btnAddProductWork.Click += new System.EventHandler(this.fld_btnAddProductWork_Click);
            // 
            // fld_tabMaterial
            // 
            this.fld_tabMaterial.Controls.Add(this.fld_dgcICProductWorkItemMaterialsGridControl);
            this.fld_tabMaterial.Name = "fld_tabMaterial";
            this.fld_tabMaterial.Size = new System.Drawing.Size(1283, 819);
            this.fld_tabMaterial.Text = "Vật tư";
            // 
            // fld_dgcICProductWorkItemMaterialsGridControl
            // 
            this.fld_dgcICProductWorkItemMaterialsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSComment = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSDataMember = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSDescription = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSError = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSGridType = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSPrivilege = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.CommodityType = "";
            this.fld_dgcICProductWorkItemMaterialsGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductWorkItemMaterialsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductWorkItemMaterialsGridControl.Name = "fld_dgcICProductWorkItemMaterialsGridControl";
            this.fld_dgcICProductWorkItemMaterialsGridControl.PrintReport = false;
            this.fld_dgcICProductWorkItemMaterialsGridControl.Screen = null;
            this.fld_dgcICProductWorkItemMaterialsGridControl.Size = new System.Drawing.Size(1277, 813);
            this.fld_dgcICProductWorkItemMaterialsGridControl.TabIndex = 13;
            // 
            // fld_tabAsset
            // 
            this.fld_tabAsset.Controls.Add(this.fld_dgcICProductWorkItemAssetsGridControl);
            this.fld_tabAsset.Name = "fld_tabAsset";
            this.fld_tabAsset.Size = new System.Drawing.Size(1283, 819);
            this.fld_tabAsset.Text = "MMTB";
            // 
            // fld_dgcICProductWorkItemAssetsGridControl
            // 
            this.fld_dgcICProductWorkItemAssetsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSComment = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSDataMember = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSDataSource = "ICProductWorkItems";
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSDescription = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSError = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSGridType = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSPrivilege = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.BOSPropertyName = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.CommodityType = "";
            this.fld_dgcICProductWorkItemAssetsGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductWorkItemAssetsGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductWorkItemAssetsGridControl.Name = "fld_dgcICProductWorkItemAssetsGridControl";
            this.fld_dgcICProductWorkItemAssetsGridControl.PrintReport = false;
            this.fld_dgcICProductWorkItemAssetsGridControl.Screen = null;
            this.fld_dgcICProductWorkItemAssetsGridControl.Size = new System.Drawing.Size(1277, 813);
            this.fld_dgcICProductWorkItemAssetsGridControl.TabIndex = 0;
            // 
            // fld_tabTask
            // 
            this.fld_tabTask.Controls.Add(this.fld_dgcICProductTasksGridControl);
            this.fld_tabTask.Name = "fld_tabTask";
            this.fld_tabTask.Size = new System.Drawing.Size(1283, 819);
            this.fld_tabTask.Text = "Task";
            // 
            // fld_dgcICProductTasksGridControl
            // 
            this.fld_dgcICProductTasksGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductTasksGridControl.BOSComment = null;
            this.fld_dgcICProductTasksGridControl.BOSDataMember = null;
            this.fld_dgcICProductTasksGridControl.BOSDataSource = "ICProductTasks";
            this.fld_dgcICProductTasksGridControl.BOSDescription = null;
            this.fld_dgcICProductTasksGridControl.BOSError = null;
            this.fld_dgcICProductTasksGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductTasksGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductTasksGridControl.BOSGridType = null;
            this.fld_dgcICProductTasksGridControl.BOSPrivilege = null;
            this.fld_dgcICProductTasksGridControl.BOSPropertyName = null;
            this.fld_dgcICProductTasksGridControl.CommodityType = "";
            this.fld_dgcICProductTasksGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductTasksGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductTasksGridControl.Name = "fld_dgcICProductTasksGridControl";
            this.fld_dgcICProductTasksGridControl.PrintReport = false;
            this.fld_dgcICProductTasksGridControl.Screen = null;
            this.fld_dgcICProductTasksGridControl.Size = new System.Drawing.Size(1277, 813);
            this.fld_dgcICProductTasksGridControl.TabIndex = 14;
            // 
            // fld_tabBatchProductItems
            // 
            this.fld_tabBatchProductItems.Controls.Add(this.fld_dgcMMBatchProductItems);
            this.fld_tabBatchProductItems.Name = "fld_tabBatchProductItems";
            this.fld_tabBatchProductItems.Size = new System.Drawing.Size(1283, 819);
            this.fld_tabBatchProductItems.Text = "Lịch sử sản xuất";
            // 
            // fld_dgcMMBatchProductItems
            // 
            this.fld_dgcMMBatchProductItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBatchProductItems.BOSComment = null;
            this.fld_dgcMMBatchProductItems.BOSDataMember = null;
            this.fld_dgcMMBatchProductItems.BOSDataSource = "MMBatchProductItems";
            this.fld_dgcMMBatchProductItems.BOSDescription = null;
            this.fld_dgcMMBatchProductItems.BOSError = null;
            this.fld_dgcMMBatchProductItems.BOSFieldGroup = null;
            this.fld_dgcMMBatchProductItems.BOSFieldRelation = null;
            this.fld_dgcMMBatchProductItems.BOSGridType = null;
            this.fld_dgcMMBatchProductItems.BOSPrivilege = null;
            this.fld_dgcMMBatchProductItems.BOSPropertyName = null;
            this.fld_dgcMMBatchProductItems.CommodityType = "";
            this.fld_dgcMMBatchProductItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMBatchProductItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMBatchProductItems.Name = "fld_dgcMMBatchProductItems";
            this.fld_dgcMMBatchProductItems.PrintReport = false;
            this.fld_dgcMMBatchProductItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMBatchProductItems, true);
            this.fld_dgcMMBatchProductItems.Size = new System.Drawing.Size(1277, 813);
            this.fld_dgcMMBatchProductItems.TabIndex = 32;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_btnAddProductImage);
            this.xtraTabPage1.Controls.Add(this.fld_dgcICProductImagesGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.xtraTabPage1.Size = new System.Drawing.Size(1283, 819);
            this.xtraTabPage1.Text = "Hình ảnh";
            // 
            // fld_btnAddProductImage
            // 
            this.fld_btnAddProductImage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddProductImage.Appearance.Options.UseForeColor = true;
            this.fld_btnAddProductImage.BOSComment = "";
            this.fld_btnAddProductImage.BOSDataMember = null;
            this.fld_btnAddProductImage.BOSDataSource = null;
            this.fld_btnAddProductImage.BOSDescription = null;
            this.fld_btnAddProductImage.BOSError = null;
            this.fld_btnAddProductImage.BOSFieldGroup = "";
            this.fld_btnAddProductImage.BOSFieldRelation = "";
            this.fld_btnAddProductImage.BOSPrivilege = "";
            this.fld_btnAddProductImage.BOSPropertyName = null;
            this.fld_btnAddProductImage.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddProductImage.Name = "fld_btnAddProductImage";
            this.fld_btnAddProductImage.Screen = null;
            this.fld_btnAddProductImage.Size = new System.Drawing.Size(115, 27);
            this.fld_btnAddProductImage.TabIndex = 11;
            this.fld_btnAddProductImage.Tag = "";
            this.fld_btnAddProductImage.Text = "Chọn ảnh";
            this.fld_btnAddProductImage.Click += new System.EventHandler(this.fld_btnAddProductImage_Click);
            // 
            // fld_dgcICProductImagesGridControl
            // 
            this.fld_dgcICProductImagesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductImagesGridControl.BOSComment = null;
            this.fld_dgcICProductImagesGridControl.BOSDataMember = null;
            this.fld_dgcICProductImagesGridControl.BOSDataSource = "ICProductFiles";
            this.fld_dgcICProductImagesGridControl.BOSDescription = null;
            this.fld_dgcICProductImagesGridControl.BOSError = null;
            this.fld_dgcICProductImagesGridControl.BOSFieldGroup = null;
            this.fld_dgcICProductImagesGridControl.BOSFieldRelation = null;
            this.fld_dgcICProductImagesGridControl.BOSGridType = null;
            this.fld_dgcICProductImagesGridControl.BOSPrivilege = null;
            this.fld_dgcICProductImagesGridControl.BOSPropertyName = null;
            this.fld_dgcICProductImagesGridControl.CommodityType = "";
            this.fld_dgcICProductImagesGridControl.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductImagesGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcICProductImagesGridControl.Name = "fld_dgcICProductImagesGridControl";
            this.fld_dgcICProductImagesGridControl.PrintReport = false;
            this.fld_dgcICProductImagesGridControl.Screen = null;
            this.fld_dgcICProductImagesGridControl.Size = new System.Drawing.Size(1277, 777);
            this.fld_dgcICProductImagesGridControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcICProductDetails);
            this.xtraTabPage2.Controls.Add(this.AddProductDetail);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1283, 819);
            this.xtraTabPage2.Text = "Chi tiết sản phẩm";
            // 
            // fld_dgcICProductDetails
            // 
            this.fld_dgcICProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductDetails.BOSComment = null;
            this.fld_dgcICProductDetails.BOSDataMember = null;
            this.fld_dgcICProductDetails.BOSDataSource = "ICProductDetails";
            this.fld_dgcICProductDetails.BOSDescription = null;
            this.fld_dgcICProductDetails.BOSError = null;
            this.fld_dgcICProductDetails.BOSFieldGroup = null;
            this.fld_dgcICProductDetails.BOSFieldRelation = null;
            this.fld_dgcICProductDetails.BOSGridType = null;
            this.fld_dgcICProductDetails.BOSPrivilege = null;
            this.fld_dgcICProductDetails.BOSPropertyName = null;
            this.fld_dgcICProductDetails.CommodityType = "";
            this.fld_dgcICProductDetails.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcICProductDetails.MenuManager = this.screenToolbar;
            this.fld_dgcICProductDetails.Name = "fld_dgcICProductDetails";
            this.fld_dgcICProductDetails.PrintReport = false;
            this.fld_dgcICProductDetails.Screen = null;
            this.fld_dgcICProductDetails.Size = new System.Drawing.Size(1276, 793);
            this.fld_dgcICProductDetails.TabIndex = 2;
            // 
            // AddProductDetail
            // 
            this.AddProductDetail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddProductDetail.Appearance.Options.UseForeColor = true;
            this.AddProductDetail.BOSComment = "";
            this.AddProductDetail.BOSDataMember = null;
            this.AddProductDetail.BOSDataSource = null;
            this.AddProductDetail.BOSDescription = null;
            this.AddProductDetail.BOSError = null;
            this.AddProductDetail.BOSFieldGroup = "";
            this.AddProductDetail.BOSFieldRelation = "";
            this.AddProductDetail.BOSPrivilege = "";
            this.AddProductDetail.BOSPropertyName = null;
            this.AddProductDetail.Location = new System.Drawing.Point(7, 3);
            this.AddProductDetail.Name = "AddProductDetail";
            this.AddProductDetail.Screen = null;
            this.AddProductDetail.Size = new System.Drawing.Size(115, 27);
            this.AddProductDetail.TabIndex = 1;
            this.AddProductDetail.Tag = "";
            this.AddProductDetail.Text = "Thêm chi tiết";
            this.AddProductDetail.Click += new System.EventHandler(this.AddProductDetail_Click);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueHinterLandID);
            this.bosGroupControl1.Controls.Add(this.bosLabel37);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl1.Controls.Add(this.bosLabel24);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Location = new System.Drawing.Point(2, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1137, 81);
            this.bosGroupControl1.TabIndex = 4;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Tài khoản";
            // 
            // fld_lkeFK_ACAccountRevenueHinterLandID
            // 
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSComment = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSDataMember = "FK_ACAccountRevenueHinterLandID";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSDescription = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSError = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Location = new System.Drawing.Point(114, 50);
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Name = "fld_lkeFK_ACAccountRevenueHinterLandID";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Screen = null;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountRevenueHinterLandID.TabIndex = 4;
            this.fld_lkeFK_ACAccountRevenueHinterLandID.Tag = "DC";
            // 
            // bosLabel37
            // 
            this.bosLabel37.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel37.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel37.Appearance.Options.UseBackColor = true;
            this.bosLabel37.Appearance.Options.UseForeColor = true;
            this.bosLabel37.BOSComment = "";
            this.bosLabel37.BOSDataMember = "";
            this.bosLabel37.BOSDataSource = "";
            this.bosLabel37.BOSDescription = null;
            this.bosLabel37.BOSError = null;
            this.bosLabel37.BOSFieldGroup = "";
            this.bosLabel37.BOSFieldRelation = "";
            this.bosLabel37.BOSPrivilege = "";
            this.bosLabel37.BOSPropertyName = "";
            this.bosLabel37.Location = new System.Drawing.Point(9, 53);
            this.bosLabel37.Name = "bosLabel37";
            this.bosLabel37.Screen = null;
            this.bosLabel37.Size = new System.Drawing.Size(99, 13);
            this.bosLabel37.TabIndex = 347;
            this.bosLabel37.Tag = "";
            this.bosLabel37.Text = "TK doanh thu Nội địa";
            // 
            // fld_lkeFK_ICProductTypeAccountConfigID
            // 
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSComment = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataMember = "FK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSError = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectType = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CurrentDisplayText = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(114, 24);
            this.fld_lkeFK_ICProductTypeAccountConfigID.Name = "fld_lkeFK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.DisplayMember = "ICProductTypeAccountConfigName";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.NullText = "";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ValueMember = "ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 0;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductTypeAccountConfigID_CloseUp);
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseFont = true;
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
            this.bosLabel24.Location = new System.Drawing.Point(9, 27);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(75, 13);
            this.bosLabel24.TabIndex = 345;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Nhóm tài khoản";
            // 
            // fld_lkeFK_ACAccountDiscountID
            // 
            this.fld_lkeFK_ACAccountDiscountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountDiscountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountDiscountID.BOSComment = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSDataMember = "FK_ACAccountDiscountID";
            this.fld_lkeFK_ACAccountDiscountID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountDiscountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSError = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountDiscountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountDiscountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountDiscountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(932, 50);
            this.fld_lkeFK_ACAccountDiscountID.Name = "fld_lkeFK_ACAccountDiscountID";
            this.fld_lkeFK_ACAccountDiscountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountDiscountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountDiscountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountDiscountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountDiscountID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountDiscountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountDiscountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountDiscountID.Screen = null;
            this.fld_lkeFK_ACAccountDiscountID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountDiscountID.TabIndex = 7;
            this.fld_lkeFK_ACAccountDiscountID.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel17.Location = new System.Drawing.Point(859, 53);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(67, 13);
            this.bosLabel17.TabIndex = 341;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "TK Chiết Khấu";
            // 
            // fld_lkeFK_ACAccountSaleReturnID
            // 
            this.fld_lkeFK_ACAccountSaleReturnID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSComment = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDataMember = "FK_ACAccountSaleReturnID";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSDescription = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSError = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountSaleReturnID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountSaleReturnID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountSaleReturnID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(695, 50);
            this.fld_lkeFK_ACAccountSaleReturnID.Name = "fld_lkeFK_ACAccountSaleReturnID";
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountSaleReturnID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountSaleReturnID.Screen = null;
            this.fld_lkeFK_ACAccountSaleReturnID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountSaleReturnID.TabIndex = 6;
            this.fld_lkeFK_ACAccountSaleReturnID.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(584, 53);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(90, 13);
            this.bosLabel16.TabIndex = 340;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "TK hàng bán trả lại";
            // 
            // fld_lkeFK_ACAccountRevenueID
            // 
            this.fld_lkeFK_ACAccountRevenueID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountRevenueID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountRevenueID.BOSComment = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSDataMember = "FK_ACAccountRevenueID";
            this.fld_lkeFK_ACAccountRevenueID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountRevenueID.BOSDescription = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSError = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountRevenueID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountRevenueID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountRevenueID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(411, 50);
            this.fld_lkeFK_ACAccountRevenueID.Name = "fld_lkeFK_ACAccountRevenueID";
            this.fld_lkeFK_ACAccountRevenueID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountRevenueID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountRevenueID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountRevenueID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountRevenueID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountRevenueID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountRevenueID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountRevenueID.Screen = null;
            this.fld_lkeFK_ACAccountRevenueID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountRevenueID.TabIndex = 5;
            this.fld_lkeFK_ACAccountRevenueID.Tag = "DC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(290, 53);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(115, 13);
            this.bosLabel15.TabIndex = 338;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "TK doanh thu Xuất khẩu";
            // 
            // fld_lkeFK_ACAccountCostPriceID
            // 
            this.fld_lkeFK_ACAccountCostPriceID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountCostPriceID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountCostPriceID.BOSComment = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSDataMember = "FK_ACAccountCostPriceID";
            this.fld_lkeFK_ACAccountCostPriceID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountCostPriceID.BOSDescription = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSError = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountCostPriceID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountCostPriceID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountCostPriceID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(932, 24);
            this.fld_lkeFK_ACAccountCostPriceID.Name = "fld_lkeFK_ACAccountCostPriceID";
            this.fld_lkeFK_ACAccountCostPriceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountCostPriceID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountCostPriceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountCostPriceID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountCostPriceID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountCostPriceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountCostPriceID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountCostPriceID.Screen = null;
            this.fld_lkeFK_ACAccountCostPriceID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountCostPriceID.TabIndex = 3;
            this.fld_lkeFK_ACAccountCostPriceID.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(859, 27);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(50, 13);
            this.bosLabel14.TabIndex = 335;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "TK giá vốn";
            // 
            // fld_lkeFK_ACAccountRevenueInternalID
            // 
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSComment = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDataMember = "FK_ACAccountRevenueInternalID";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSDescription = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSError = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(695, 24);
            this.fld_lkeFK_ACAccountRevenueInternalID.Name = "fld_lkeFK_ACAccountRevenueInternalID";
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountRevenueInternalID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountRevenueInternalID.Screen = null;
            this.fld_lkeFK_ACAccountRevenueInternalID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountRevenueInternalID.TabIndex = 2;
            this.fld_lkeFK_ACAccountRevenueInternalID.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(584, 27);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(96, 13);
            this.bosLabel13.TabIndex = 334;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "TK doanh thu nội bộ";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ACAccountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountID.BOSError = null;
            this.fld_lkeFK_ACAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(411, 24);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(111, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 1;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(290, 27);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(53, 13);
            this.bosLabel4.TabIndex = 332;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "TK Tồn kho";
            // 
            // fld_tabProductMeasureUnits
            // 
            this.fld_tabProductMeasureUnits.Controls.Add(this.fld_btnSaveProductMeasureUnit);
            this.fld_tabProductMeasureUnits.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.fld_tabProductMeasureUnits.Name = "fld_tabProductMeasureUnits";
            this.fld_tabProductMeasureUnits.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabProductMeasureUnits.Text = "ĐVT quy đổi";
            // 
            // fld_btnSaveProductMeasureUnit
            // 
            this.fld_btnSaveProductMeasureUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSaveProductMeasureUnit.BOSComment = null;
            this.fld_btnSaveProductMeasureUnit.BOSDataMember = null;
            this.fld_btnSaveProductMeasureUnit.BOSDataSource = null;
            this.fld_btnSaveProductMeasureUnit.BOSDescription = null;
            this.fld_btnSaveProductMeasureUnit.BOSError = null;
            this.fld_btnSaveProductMeasureUnit.BOSFieldGroup = null;
            this.fld_btnSaveProductMeasureUnit.BOSFieldRelation = null;
            this.fld_btnSaveProductMeasureUnit.BOSPrivilege = null;
            this.fld_btnSaveProductMeasureUnit.BOSPropertyName = null;
            this.fld_btnSaveProductMeasureUnit.Location = new System.Drawing.Point(1223, 908);
            this.fld_btnSaveProductMeasureUnit.Name = "fld_btnSaveProductMeasureUnit";
            this.fld_btnSaveProductMeasureUnit.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveProductMeasureUnit, true);
            this.fld_btnSaveProductMeasureUnit.Size = new System.Drawing.Size(69, 25);
            this.fld_btnSaveProductMeasureUnit.TabIndex = 110;
            this.fld_btnSaveProductMeasureUnit.Text = "Lưu";
            this.fld_btnSaveProductMeasureUnit.Click += new System.EventHandler(this.fld_btnSaveProductMeasureUnit_Click);
            // 
            // fld_dgcICProductMeasureUnits
            // 
            this.fld_dgcICProductMeasureUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductMeasureUnits.BOSComment = null;
            this.fld_dgcICProductMeasureUnits.BOSDataMember = null;
            this.fld_dgcICProductMeasureUnits.BOSDataSource = "ICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.BOSDescription = null;
            this.fld_dgcICProductMeasureUnits.BOSError = null;
            this.fld_dgcICProductMeasureUnits.BOSFieldGroup = null;
            this.fld_dgcICProductMeasureUnits.BOSFieldRelation = null;
            this.fld_dgcICProductMeasureUnits.BOSGridType = null;
            this.fld_dgcICProductMeasureUnits.BOSPrivilege = null;
            this.fld_dgcICProductMeasureUnits.BOSPropertyName = null;
            this.fld_dgcICProductMeasureUnits.CommodityType = "";
            this.fld_dgcICProductMeasureUnits.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMeasureUnits.Name = "fld_dgcICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.PrintReport = false;
            this.fld_dgcICProductMeasureUnits.Screen = null;
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(1289, 895);
            this.fld_dgcICProductMeasureUnits.TabIndex = 3;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
            // 
            // fld_tabProductTemplete
            // 
            this.fld_tabProductTemplete.Controls.Add(this.fld_dgcICProductTemplates);
            this.fld_tabProductTemplete.Name = "fld_tabProductTemplete";
            this.fld_tabProductTemplete.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabProductTemplete.Text = "Khu vực";
            // 
            // fld_dgcICProductTemplates
            // 
            this.fld_dgcICProductTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductTemplates.BOSComment = null;
            this.fld_dgcICProductTemplates.BOSDataMember = null;
            this.fld_dgcICProductTemplates.BOSDataSource = "ICProductTemplates";
            this.fld_dgcICProductTemplates.BOSDescription = null;
            this.fld_dgcICProductTemplates.BOSError = null;
            this.fld_dgcICProductTemplates.BOSFieldGroup = null;
            this.fld_dgcICProductTemplates.BOSFieldRelation = null;
            this.fld_dgcICProductTemplates.BOSGridType = null;
            this.fld_dgcICProductTemplates.BOSPrivilege = null;
            this.fld_dgcICProductTemplates.BOSPropertyName = null;
            this.fld_dgcICProductTemplates.CommodityType = "";
            this.fld_dgcICProductTemplates.Location = new System.Drawing.Point(-1, 3);
            this.fld_dgcICProductTemplates.MenuManager = this.screenToolbar;
            this.fld_dgcICProductTemplates.Name = "fld_dgcICProductTemplates";
            this.fld_dgcICProductTemplates.PrintReport = false;
            this.fld_dgcICProductTemplates.Screen = null;
            this.fld_dgcICProductTemplates.Size = new System.Drawing.Size(1293, 930);
            this.fld_dgcICProductTemplates.TabIndex = 118;
            this.fld_dgcICProductTemplates.Tag = "DC";
            // 
            // fld_tabBranch
            // 
            this.fld_tabBranch.Controls.Add(this.fld_dgcICProductBranchs);
            this.fld_tabBranch.Name = "fld_tabBranch";
            this.fld_tabBranch.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabBranch.Text = "Chi nhánh của SP";
            // 
            // fld_dgcICProductBranchs
            // 
            this.fld_dgcICProductBranchs.BOSComment = null;
            this.fld_dgcICProductBranchs.BOSDataMember = null;
            this.fld_dgcICProductBranchs.BOSDataSource = "ICProductBranchs";
            this.fld_dgcICProductBranchs.BOSDescription = null;
            this.fld_dgcICProductBranchs.BOSError = null;
            this.fld_dgcICProductBranchs.BOSFieldGroup = null;
            this.fld_dgcICProductBranchs.BOSFieldRelation = null;
            this.fld_dgcICProductBranchs.BOSGridType = null;
            this.fld_dgcICProductBranchs.BOSPrivilege = null;
            this.fld_dgcICProductBranchs.BOSPropertyName = null;
            this.fld_dgcICProductBranchs.CommodityType = "";
            this.fld_dgcICProductBranchs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductBranchs.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductBranchs.MenuManager = this.screenToolbar;
            this.fld_dgcICProductBranchs.Name = "fld_dgcICProductBranchs";
            this.fld_dgcICProductBranchs.PrintReport = false;
            this.fld_dgcICProductBranchs.Screen = null;
            this.fld_dgcICProductBranchs.Size = new System.Drawing.Size(1295, 937);
            this.fld_dgcICProductBranchs.TabIndex = 119;
            this.fld_dgcICProductBranchs.Tag = "DC";
            // 
            // fld_tabTolenrance
            // 
            this.fld_tabTolenrance.Controls.Add(this.fld_dgcICProductTolenrances);
            this.fld_tabTolenrance.Name = "fld_tabTolenrance";
            this.fld_tabTolenrance.Size = new System.Drawing.Size(1295, 937);
            this.fld_tabTolenrance.Text = "Dung sai";
            // 
            // fld_dgcICProductTolenrances
            // 
            this.fld_dgcICProductTolenrances.AllowDrop = true;
            this.fld_dgcICProductTolenrances.BOSComment = null;
            this.fld_dgcICProductTolenrances.BOSDataMember = null;
            this.fld_dgcICProductTolenrances.BOSDataSource = "ICProductTolenrances";
            this.fld_dgcICProductTolenrances.BOSDescription = null;
            this.fld_dgcICProductTolenrances.BOSError = null;
            this.fld_dgcICProductTolenrances.BOSFieldGroup = null;
            this.fld_dgcICProductTolenrances.BOSFieldRelation = null;
            this.fld_dgcICProductTolenrances.BOSGridType = null;
            this.fld_dgcICProductTolenrances.BOSPrivilege = null;
            this.fld_dgcICProductTolenrances.BOSPropertyName = null;
            this.fld_dgcICProductTolenrances.CommodityType = "";
            this.fld_dgcICProductTolenrances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductTolenrances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductTolenrances.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductTolenrances.MainView = this.gridView2;
            this.fld_dgcICProductTolenrances.Name = "fld_dgcICProductTolenrances";
            this.fld_dgcICProductTolenrances.PrintReport = false;
            this.fld_dgcICProductTolenrances.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductTolenrances, true);
            this.fld_dgcICProductTolenrances.Size = new System.Drawing.Size(1295, 937);
            this.fld_dgcICProductTolenrances.TabIndex = 10;
            this.fld_dgcICProductTolenrances.Tag = "DC";
            this.fld_dgcICProductTolenrances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcICProductTolenrances;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICProductCustomers);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1295, 937);
            this.xtraTabPage3.Text = "Thông tin sản phẩm theo khách hàng";
            // 
            // fld_dgcICProductCustomers
            // 
            this.fld_dgcICProductCustomers.BOSComment = null;
            this.fld_dgcICProductCustomers.BOSDataMember = null;
            this.fld_dgcICProductCustomers.BOSDataSource = "ICProductCustomers";
            this.fld_dgcICProductCustomers.BOSDescription = null;
            this.fld_dgcICProductCustomers.BOSError = null;
            this.fld_dgcICProductCustomers.BOSFieldGroup = null;
            this.fld_dgcICProductCustomers.BOSFieldRelation = null;
            this.fld_dgcICProductCustomers.BOSGridType = null;
            this.fld_dgcICProductCustomers.BOSPrivilege = null;
            this.fld_dgcICProductCustomers.BOSPropertyName = null;
            this.fld_dgcICProductCustomers.CommodityType = "";
            this.fld_dgcICProductCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductCustomers.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductCustomers.MenuManager = this.screenToolbar;
            this.fld_dgcICProductCustomers.Name = "fld_dgcICProductCustomers";
            this.fld_dgcICProductCustomers.PrintReport = false;
            this.fld_dgcICProductCustomers.Screen = null;
            this.fld_dgcICProductCustomers.Size = new System.Drawing.Size(1295, 937);
            this.fld_dgcICProductCustomers.TabIndex = 120;
            this.fld_dgcICProductCustomers.Tag = "DC";
            // 
            // gridView53
            // 
            this.gridView53.Name = "gridView53";
            this.gridView53.PaintStyleName = "Office2003";
            // 
            // DMPD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1311, 972);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPD100.IconOptions.Icon")));
            this.Name = "DMPD100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProducts)).EndInit();
            this.fld_tabProducts.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductContainerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).EndInit();
            this.bosGroupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductPackingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pbxConverSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductQtyInBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductRadius.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeFinishing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPaintNoOfManufacture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).EndInit();
            this.fld_pnlOtherAttribute.ResumeLayout(false);
            this.fld_pnlOtherAttribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_fld_bedICProductAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductOtherSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTrademark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductImageFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkHasComponent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductCarcassID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCarcass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTemplateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOrigin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductLockedPurchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductWorkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCustomerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductCollection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkShowHistoryBranchPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            this.fld_tabComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductComponents)).EndInit();
            this.fld_tabAccountStockHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).EndInit();
            this.fld_tabProductTask.ResumeLayout(false);
            this.fld_tabWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemsGridControl)).EndInit();
            this.fld_tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemMaterialsGridControl)).EndInit();
            this.fld_tabAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductWorkItemAssetsGridControl)).EndInit();
            this.fld_tabTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTasksGridControl)).EndInit();
            this.fld_tabBatchProductItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItems)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductImagesGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueHinterLandID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            this.fld_tabProductMeasureUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
            this.fld_tabProductTemplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTemplates)).EndInit();
            this.fld_tabBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductBranchs)).EndInit();
            this.fld_tabTolenrance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView53)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        //private ICProductComponentsGridControl fld_dgcICProductComponents;
        private OpenFileDialog openFileDialog1;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabProducts;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductMeasureUnits;
        private BOSComponent.BOSButton fld_btnSaveProductMeasureUnit;
        private ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private DevExpress.XtraTab.XtraTabPage fld_tabAccountStockHistory;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtICProductDepth;
        private BOSComponent.BOSTextBox fld_txtICProductDiameter;
        private BOSComponent.BOSTextBox fld_txtICProductRadius;
        private BOSComponent.BOSMemoEdit fld_medICProductOtherSize;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeFinishing;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeColor;
        private BOSComponent.BOSLabel bosLabel5;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeWoodType;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductHeight;
        private BOSComponent.BOSTextBox fld_txtICProductPaintNoOfManufacture;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtICProductLength;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIdentifyWoodType;
        private BOSComponent.BOSTextBox fld_txtICProductWidth;
        private BOSComponent.BOSPanel fld_pnlOtherAttribute;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButtonEdit fld_fld_bedICProductAttribute;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_kleICProductIdentifyColor;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private BOSComponent.BOSCheckEdit bosCheckEdit1;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeICProductTemplateType;
        private BOSComponent.BOSButton fld_btnAddProductImageDefault;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOrigin;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSCheckEdit fld_chkICProductLockedPurchaseOrder;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOriginOfProduct;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeICProductWorkType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtICProductBarCode;
        private BOSComponent.BOSTextBox fld_txtICProductCustomerNumber;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lbl5;
        private BOSComponent.BOSTextBox fld_txtICProductNoOfOldSys;
        private BOSComponent.BOSLabel fld_txtMHTold;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSTextBox fld_txtICProductName2;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductFormulaPriceConfigID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEVATID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkShowHistoryBranchPrice;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPurchasePrice;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenBranchPrice;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPrice;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierPrice;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSTabControl fld_tabProductTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabWork;
        private ICProductWorkItemsGridControl fld_dgcICProductWorkItemsGridControl;
        private BOSComponent.BOSButton fld_btnAddProductWork;
        private DevExpress.XtraTab.XtraTabPage fld_tabMaterial;
        private ICProductWorkItemMaterialsGridControl fld_dgcICProductWorkItemMaterialsGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabAsset;
        private ICProductWorkItemAssetsGridControl fld_dgcICProductWorkItemAssetsGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabTask;
        private ICProductTasksGridControl fld_dgcICProductTasksGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabBatchProductItems;
        private MMBatchProductItemGridControl fld_dgcMMBatchProductItems;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnAddProductImage;
        private ICProductImagesGridControl fld_dgcICProductImagesGridControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ICProductDetailGridControl fld_dgcICProductDetails;
        private BOSComponent.BOSButton AddProductDetail;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountDiscountID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleReturnID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountCostPriceID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueInternalID;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductBlock;
        private BOSComponent.BOSLabel bosLabel31;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView53;
        private BOSComponent.BOSCheckEdit fld_chkCarcass;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductCarcassID;
        private BOSComponent.BOSLookupEdit fld_lkeProductParentID;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPurchaseType;
        private BOSComponent.BOSTextBox fld_txtICProductLeadTime;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel36;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private BOSComponent.BOSGroupControl bosGroupControl6;
        private ICProductPackingDetailsGridControl fld_dgcICProductPackingDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductTemplete;
        private ProductTemplatesGridControl fld_dgcICProductTemplates;
        private DevExpress.XtraTab.XtraTabPage fld_tabBranch;
        private ICProductBranchGridControl fld_dgcICProductBranchs;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel33;
        private DevExpress.XtraTab.XtraTabPage fld_tabTolenrance;
        private ICProductTolenrancesGridControl fld_dgcICProductTolenrances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSTextBox fld_txtICProductStorageDay;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueHinterLandID;
        private BOSComponent.BOSLabel bosLabel37;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSLabel bosLabel39;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel38;
        private BOSComponent.BOSCheckEdit fld_chkHasComponent;
        private DevExpress.XtraTab.XtraTabPage fld_tabComponent;
        private ICProductComponentGridControl fld_dgcICProductComponents;
        private BOSComponent.BOSButton fld_btnAddProductComponentItem;
        private BOSComponent.BOSTextBox fld_txtICProductImageFile;
        private PictureBox pictureBox1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICProductContainerDetailsGridControl fld_dgcICProductContainerDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSTextBox fld_txtICProductQtyInBox;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLookupEdit fld_lkeICProductTrademark;
        private BOSComponent.BOSLabel bosLabel40;
        private BOSComponent.BOSLabel bosLabel41;
        private BOSComponent.BOSMemoEdit bosMemoEdit2;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ICProductCustomerGridControl fld_dgcICProductCustomers;
        private PictureBox fld_pbxConverSize;
        private BOSComponent.BOSLookupEdit fld_lkeICProductCollection;
        private BOSComponent.BOSLabel bosLabel42;
    }
}
