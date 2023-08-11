using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PackagingProduct.UI
{
	/// <summary>
	/// Summary description for DMPKP100
	/// </summary>
	partial class DMPKP100
	{
        private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLabel fld_lblLabel28;
		private BOSComponent.BOSLabel fld_Lablel1;
		private BOSComponent.BOSTextBox fld_txtICProductStockMin;
		private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSTextBox fld_txtICProductSupplierPrice;
		private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtICProductNo;
		private BOSComponent.BOSTextBox fld_txtICProductStockMax;
		private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEVATID;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl4;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel26;
		private BOSComponent.BOSLabel fld_lblLabel27;
		private BOSComponent.BOSLabel fld_lblLabel29;
		private BOSComponent.BOSDateEdit fld_dteICProductStockMinDateFrom;
		private BOSComponent.BOSDateEdit fld_dteICProductStockMinDateTo;
		private BOSComponent.BOSDateEdit fld_dteICProductStockMaxDateFrom;
        private BOSComponent.BOSDateEdit fld_dteICProductStockMaxDateTo;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSLabel fld_lblLabel11;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPKP100));
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductStockMin = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductSupplierPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductOriginOfProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICModelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_btnAddProductImageDefault = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductUses = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtICProductStorageDay = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductBarCode = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNoOfOldSys = new BOSComponent.BOSTextBox(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductAttributeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductStockMax = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkShowHistoryBranchPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lnkEditPurchasePrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lnkOpenBranchPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkEditPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductStockMinDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMinDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMaxDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMaxDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabProducts = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtICProductCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSizeAndSpecifiCations = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdateInside = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateOverroll = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductPurchaseType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductOverallDimensionHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductBoxUnitPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductBoxArea = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductLeadTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductInsideDimensionHeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductOverallDimensionLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductInsideDimensionLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductOverallDimensionWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductInsideDimensionWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductGrossWeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNetWeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabAccountStockHistory = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddMoreProduct = new DevExpress.XtraEditors.SimpleButton();
            this.fld_dgcICProductItems = new BOSERP.Modules.PackagingProduct.ICProductComponentsGridControl();
            this.fld_btnMoveUp = new BOSComponent.BOSButton(this.components);
            this.fld_btnMoveDown = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl6 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAccountDiscountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel32 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel33 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountCostPriceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel34 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueInternalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel36 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl7 = new BOSComponent.BOSGroupControl(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.icProductComponentsGridControl1 = new BOSERP.Modules.PackagingProduct.ICProductComponentsGridControl();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.fld_tabPackagingNorm = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICPackagingNormItems = new BOSERP.Modules.PackagingProduct.ICPackagingNormItemGridControl();
            this.fld_tabProductMeasureUnits = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProductMeasureUnit = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.PackagingProduct.ICProductMeasureUnitsGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTolenrances = new BOSERP.Modules.PackagingProduct.ICProductTolenrancesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkShowHistoryBranchPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).BeginInit();
            this.fld_grcGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProducts)).BeginInit();
            this.fld_tabProducts.SuspendLayout();
            this.fld_tabInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSizeAndSpecifiCations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBoxUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBoxArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGrossWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNetWeight.Properties)).BeginInit();
            this.fld_tabAccountStockHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).BeginInit();
            this.bosGroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl7)).BeginInit();
            this.bosGroupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icProductComponentsGridControl1)).BeginInit();
            this.fld_tabPackagingNorm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackagingNormItems)).BeginInit();
            this.fld_tabProductMeasureUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(22, 32);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel15.TabIndex = 14;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã PLDG";
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
            this.fld_lblLabel21.Location = new System.Drawing.Point(22, 159);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 19;
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(22, 250);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 21;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Nhóm hàng";
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseFont = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = "";
            this.fld_Lablel1.BOSDataMember = "";
            this.fld_Lablel1.BOSDataSource = "";
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = "Rent";
            this.fld_Lablel1.BOSFieldRelation = "";
            this.fld_Lablel1.BOSPrivilege = "";
            this.fld_Lablel1.BOSPropertyName = "";
            this.fld_Lablel1.Location = new System.Drawing.Point(13, 30);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(82, 13);
            this.fld_Lablel1.TabIndex = 0;
            this.fld_Lablel1.Tag = "";
            this.fld_Lablel1.Text = "Số lượng tối thiểu";
            // 
            // fld_txtICProductStockMin
            // 
            this.fld_txtICProductStockMin.BOSComment = "";
            this.fld_txtICProductStockMin.BOSDataMember = "ICProductStockMin";
            this.fld_txtICProductStockMin.BOSDataSource = "ICProducts";
            this.fld_txtICProductStockMin.BOSDescription = null;
            this.fld_txtICProductStockMin.BOSError = null;
            this.fld_txtICProductStockMin.BOSFieldGroup = "Rent";
            this.fld_txtICProductStockMin.BOSFieldRelation = "";
            this.fld_txtICProductStockMin.BOSPrivilege = "";
            this.fld_txtICProductStockMin.BOSPropertyName = "Text";
            this.fld_txtICProductStockMin.EditValue = "0.00";
            this.fld_txtICProductStockMin.Location = new System.Drawing.Point(106, 27);
            this.fld_txtICProductStockMin.Name = "fld_txtICProductStockMin";
            this.fld_txtICProductStockMin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductStockMin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductStockMin.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductStockMin.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductStockMin.Properties.Mask.EditMask = "n";
            this.fld_txtICProductStockMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductStockMin.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductStockMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductStockMin.Screen = null;
            this.fld_txtICProductStockMin.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductStockMin.TabIndex = 1;
            this.fld_txtICProductStockMin.Tag = "DC";
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
            this.fld_medICProductDesc.Location = new System.Drawing.Point(120, 156);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.fld_medICProductDesc.Size = new System.Drawing.Size(297, 37);
            this.fld_medICProductDesc.TabIndex = 5;
            this.fld_medICProductDesc.Tag = "DC";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(18, 91);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel.TabIndex = 253;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Thuế";
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(18, 65);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel14.TabIndex = 266;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Giá mua";
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
            this.fld_txtICProductSupplierPrice.EditValue = "0.00";
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(108, 63);
            this.fld_txtICProductSupplierPrice.Name = "fld_txtICProductSupplierPrice";
            this.fld_txtICProductSupplierPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierPrice.Properties.Mask.EditMask = "n";
            this.fld_txtICProductSupplierPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductSupplierPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierPrice.Screen = null;
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(152, 20);
            this.fld_txtICProductSupplierPrice.TabIndex = 1;
            this.fld_txtICProductSupplierPrice.Tag = "DC";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOriginOfProduct);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel22);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_GECountryID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel23);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ICModelID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel25);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddProductImageDefault);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductUses);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel17);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductStorageDay);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductBarCode);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNoOfOldSys);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductAttributeNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductSupplierNumber);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkSetDefaultDesc);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel17);
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
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 682);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
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
            this.fld_lkeICProductOriginOfProduct.Location = new System.Drawing.Point(120, 451);
            this.fld_lkeICProductOriginOfProduct.Name = "fld_lkeICProductOriginOfProduct";
            this.fld_lkeICProductOriginOfProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductOriginOfProduct.Properties.ColumnName = null;
            this.fld_lkeICProductOriginOfProduct.Properties.NullText = "";
            this.fld_lkeICProductOriginOfProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductOriginOfProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductOriginOfProduct, true);
            this.fld_lkeICProductOriginOfProduct.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductOriginOfProduct.TabIndex = 391;
            this.fld_lkeICProductOriginOfProduct.Tag = "DC";
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
            this.bosLabel22.Location = new System.Drawing.Point(22, 454);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(66, 13);
            this.bosLabel22.TabIndex = 392;
            this.bosLabel22.Text = "Nguồn gốc SP";
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = false;
            this.fld_lkeFK_GECountryID.BOSComment = null;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = null;
            this.fld_lkeFK_GECountryID.BOSFieldParent = null;
            this.fld_lkeFK_GECountryID.BOSFieldRelation = null;
            this.fld_lkeFK_GECountryID.BOSPrivilege = null;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = "";
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(120, 399);
            this.fld_lkeFK_GECountryID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECountryID.Properties.ColumnName = null;
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Xuất xứ")});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = "";
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_GECountryID, true);
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 389;
            this.fld_lkeFK_GECountryID.Tag = "DC";
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
            this.bosLabel23.Location = new System.Drawing.Point(22, 402);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(38, 13);
            this.bosLabel23.TabIndex = 390;
            this.bosLabel23.Text = "Xuất xứ";
            // 
            // fld_lkeFK_ICModelID
            // 
            this.fld_lkeFK_ICModelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICModelID.BOSAllowDummy = true;
            this.fld_lkeFK_ICModelID.BOSComment = "";
            this.fld_lkeFK_ICModelID.BOSDataMember = "FK_ICModelID";
            this.fld_lkeFK_ICModelID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICModelID.BOSDescription = null;
            this.fld_lkeFK_ICModelID.BOSError = null;
            this.fld_lkeFK_ICModelID.BOSFieldGroup = "";
            this.fld_lkeFK_ICModelID.BOSFieldParent = "";
            this.fld_lkeFK_ICModelID.BOSFieldRelation = "";
            this.fld_lkeFK_ICModelID.BOSPrivilege = "";
            this.fld_lkeFK_ICModelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICModelID.BOSSelectType = "";
            this.fld_lkeFK_ICModelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICModelID.CurrentDisplayText = null;
            this.fld_lkeFK_ICModelID.Location = new System.Drawing.Point(120, 425);
            this.fld_lkeFK_ICModelID.Name = "fld_lkeFK_ICModelID";
            this.fld_lkeFK_ICModelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICModelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICModelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICModelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICModelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICModelID.Properties.ColumnName = null;
            this.fld_lkeFK_ICModelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICModelName", "Tên thương hiệu")});
            this.fld_lkeFK_ICModelID.Properties.DisplayMember = "ICModelName";
            this.fld_lkeFK_ICModelID.Properties.NullText = "";
            this.fld_lkeFK_ICModelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICModelID.Properties.ValueMember = "ICModelID";
            this.fld_lkeFK_ICModelID.Screen = null;
            this.fld_lkeFK_ICModelID.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeFK_ICModelID.TabIndex = 387;
            this.fld_lkeFK_ICModelID.Tag = "DC";
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
            this.bosLabel25.Location = new System.Drawing.Point(22, 428);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(60, 13);
            this.bosLabel25.TabIndex = 388;
            this.bosLabel25.Text = "Thương hiệu";
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(291, 204);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_ptbICProductPicture.TabIndex = 374;
            this.fld_ptbICProductPicture.TabStop = false;
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
            this.fld_btnAddProductImageDefault.Location = new System.Drawing.Point(292, 317);
            this.fld_btnAddProductImageDefault.Name = "fld_btnAddProductImageDefault";
            this.fld_btnAddProductImageDefault.Screen = null;
            this.fld_btnAddProductImageDefault.Size = new System.Drawing.Size(125, 21);
            this.fld_btnAddProductImageDefault.TabIndex = 373;
            this.fld_btnAddProductImageDefault.Tag = "";
            this.fld_btnAddProductImageDefault.Text = "Chọn ảnh chính";
            this.fld_btnAddProductImageDefault.Click += new System.EventHandler(this.fld_btnAddProductImageDefault_Click);
            // 
            // fld_lkeICProductUses
            // 
            this.fld_lkeICProductUses.BOSAllowAddNew = false;
            this.fld_lkeICProductUses.BOSAllowDummy = false;
            this.fld_lkeICProductUses.BOSComment = null;
            this.fld_lkeICProductUses.BOSDataMember = "ICProductUses";
            this.fld_lkeICProductUses.BOSDataSource = "ICProducts";
            this.fld_lkeICProductUses.BOSDescription = null;
            this.fld_lkeICProductUses.BOSError = null;
            this.fld_lkeICProductUses.BOSFieldGroup = null;
            this.fld_lkeICProductUses.BOSFieldParent = null;
            this.fld_lkeICProductUses.BOSFieldRelation = null;
            this.fld_lkeICProductUses.BOSPrivilege = null;
            this.fld_lkeICProductUses.BOSPropertyName = "EditValue";
            this.fld_lkeICProductUses.BOSSelectType = null;
            this.fld_lkeICProductUses.BOSSelectTypeValue = null;
            this.fld_lkeICProductUses.CurrentDisplayText = null;
            this.fld_lkeICProductUses.Location = new System.Drawing.Point(120, 273);
            this.fld_lkeICProductUses.MenuManager = this.screenToolbar;
            this.fld_lkeICProductUses.Name = "fld_lkeICProductUses";
            this.fld_lkeICProductUses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductUses.Properties.ColumnName = null;
            this.fld_lkeICProductUses.Properties.NullText = "";
            this.fld_lkeICProductUses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductUses.Screen = null;
            this.fld_lkeICProductUses.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductUses.TabIndex = 9;
            this.fld_lkeICProductUses.Tag = "DC";
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
            this.bosLabel17.Location = new System.Drawing.Point(22, 276);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(88, 13);
            this.bosLabel17.TabIndex = 372;
            this.bosLabel17.Text = "Hình thức sử dụng";
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
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(292, 374);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 15;
            this.fld_chkICProductIsShowWeb.Tag = "DC";
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
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(291, 399);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 16;
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
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(292, 348);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductActiveCheck, true);
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 14;
            this.fld_chkICProductActiveCheck.Tag = "DC";
            // 
            // fld_txtICProductStorageDay
            // 
            this.fld_txtICProductStorageDay.BOSComment = null;
            this.fld_txtICProductStorageDay.BOSDataMember = "ICProductStorageDay";
            this.fld_txtICProductStorageDay.BOSDataSource = "ICProducts";
            this.fld_txtICProductStorageDay.BOSDescription = null;
            this.fld_txtICProductStorageDay.BOSError = null;
            this.fld_txtICProductStorageDay.BOSFieldGroup = null;
            this.fld_txtICProductStorageDay.BOSFieldRelation = null;
            this.fld_txtICProductStorageDay.BOSPrivilege = null;
            this.fld_txtICProductStorageDay.BOSPropertyName = "Text";
            this.fld_txtICProductStorageDay.Location = new System.Drawing.Point(120, 373);
            this.fld_txtICProductStorageDay.Name = "fld_txtICProductStorageDay";
            this.fld_txtICProductStorageDay.Screen = null;
            this.fld_txtICProductStorageDay.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductStorageDay.TabIndex = 13;
            this.fld_txtICProductStorageDay.Tag = "DC";
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
            this.fld_txtICProductBarCode.Location = new System.Drawing.Point(120, 347);
            this.fld_txtICProductBarCode.MenuManager = this.screenToolbar;
            this.fld_txtICProductBarCode.Name = "fld_txtICProductBarCode";
            this.fld_txtICProductBarCode.Screen = null;
            this.fld_txtICProductBarCode.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductBarCode.TabIndex = 12;
            this.fld_txtICProductBarCode.Tag = "DC";
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
            this.bosLabel21.Location = new System.Drawing.Point(22, 377);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(77, 13);
            this.bosLabel21.TabIndex = 23;
            this.bosLabel21.Text = "Số ngày lưu kho";
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
            this.fld_lblLabel13.Location = new System.Drawing.Point(22, 348);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel13.TabIndex = 23;
            this.fld_lblLabel13.Text = "Mã vạch";
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
            this.bosLabel5.BOSDataMember = "ICProductName";
            this.bosLabel5.BOSDataSource = "ICProducts";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(22, 58);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 15;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Mã HT cũ";
            // 
            // fld_txtICProductNoOfOldSys
            // 
            this.fld_txtICProductNoOfOldSys.BOSComment = "";
            this.fld_txtICProductNoOfOldSys.BOSDataMember = "ICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.BOSDataSource = "ICProducts";
            this.fld_txtICProductNoOfOldSys.BOSDescription = null;
            this.fld_txtICProductNoOfOldSys.BOSError = null;
            this.fld_txtICProductNoOfOldSys.BOSFieldGroup = "";
            this.fld_txtICProductNoOfOldSys.BOSFieldRelation = "";
            this.fld_txtICProductNoOfOldSys.BOSPrivilege = "";
            this.fld_txtICProductNoOfOldSys.BOSPropertyName = "Text";
            this.fld_txtICProductNoOfOldSys.EditValue = "";
            this.fld_txtICProductNoOfOldSys.Location = new System.Drawing.Point(120, 55);
            this.fld_txtICProductNoOfOldSys.Name = "fld_txtICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNoOfOldSys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNoOfOldSys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNoOfOldSys, true);
            this.fld_txtICProductNoOfOldSys.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductNoOfOldSys.TabIndex = 1;
            this.fld_txtICProductNoOfOldSys.Tag = "DC";
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
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(120, 247);
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(120, 299);
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
            this.fld_lkeFK_APSupplierID.TabIndex = 10;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(120, 322);
            this.fld_lnkOpenSupplier.MenuManager = this.screenToolbar;
            this.fld_lnkOpenSupplier.Name = "fld_lnkOpenSupplier";
            this.fld_lnkOpenSupplier.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkOpenSupplier.Size = new System.Drawing.Size(155, 18);
            this.fld_lnkOpenSupplier.TabIndex = 11;
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
            this.bosLabel3.Location = new System.Drawing.Point(22, 109);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(67, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Mã thuộc tính";
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
            this.bosLabel1.BOSDataMember = "ICProductName";
            this.bosLabel1.BOSDataSource = "ICProducts";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(22, 84);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(89, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Mã sản phẩm NCC";
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
            this.fld_txtICProductName.Location = new System.Drawing.Point(120, 132);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(296, 20);
            this.fld_txtICProductName.TabIndex = 4;
            this.fld_txtICProductName.Tag = "DC";
            this.fld_txtICProductName.EditValueChanged += new System.EventHandler(this.fld_txtICProductName_EditValueChanged);
            // 
            // fld_txtICProductAttributeNo
            // 
            this.fld_txtICProductAttributeNo.BOSComment = "";
            this.fld_txtICProductAttributeNo.BOSDataMember = "ICProductAttributeNo";
            this.fld_txtICProductAttributeNo.BOSDataSource = "ICProducts";
            this.fld_txtICProductAttributeNo.BOSDescription = null;
            this.fld_txtICProductAttributeNo.BOSError = null;
            this.fld_txtICProductAttributeNo.BOSFieldGroup = "";
            this.fld_txtICProductAttributeNo.BOSFieldRelation = "";
            this.fld_txtICProductAttributeNo.BOSPrivilege = "";
            this.fld_txtICProductAttributeNo.BOSPropertyName = "Text";
            this.fld_txtICProductAttributeNo.EditValue = "";
            this.fld_txtICProductAttributeNo.Location = new System.Drawing.Point(120, 106);
            this.fld_txtICProductAttributeNo.Name = "fld_txtICProductAttributeNo";
            this.fld_txtICProductAttributeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductAttributeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductAttributeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductAttributeNo.Screen = null;
            this.fld_txtICProductAttributeNo.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductAttributeNo.TabIndex = 3;
            this.fld_txtICProductAttributeNo.Tag = "DC";
            // 
            // fld_txtICProductSupplierNumber
            // 
            this.fld_txtICProductSupplierNumber.BOSComment = "";
            this.fld_txtICProductSupplierNumber.BOSDataMember = "ICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.BOSDataSource = "ICProducts";
            this.fld_txtICProductSupplierNumber.BOSDescription = null;
            this.fld_txtICProductSupplierNumber.BOSError = null;
            this.fld_txtICProductSupplierNumber.BOSFieldGroup = "";
            this.fld_txtICProductSupplierNumber.BOSFieldRelation = "";
            this.fld_txtICProductSupplierNumber.BOSPrivilege = "";
            this.fld_txtICProductSupplierNumber.BOSPropertyName = "Text";
            this.fld_txtICProductSupplierNumber.EditValue = "";
            this.fld_txtICProductSupplierNumber.Location = new System.Drawing.Point(120, 81);
            this.fld_txtICProductSupplierNumber.Name = "fld_txtICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierNumber.Screen = null;
            this.fld_txtICProductSupplierNumber.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductSupplierNumber.TabIndex = 2;
            this.fld_txtICProductSupplierNumber.Tag = "DC";
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = false;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "ICProductType";
            this.fld_lkeICProductType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductType.BOSDescription = null;
            this.fld_lkeICProductType.BOSError = null;
            this.fld_lkeICProductType.BOSFieldGroup = null;
            this.fld_lkeICProductType.BOSFieldParent = null;
            this.fld_lkeICProductType.BOSFieldRelation = null;
            this.fld_lkeICProductType.BOSPrivilege = null;
            this.fld_lkeICProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductType.BOSSelectType = null;
            this.fld_lkeICProductType.BOSSelectTypeValue = null;
            this.fld_lkeICProductType.CurrentDisplayText = null;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(120, 221);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.fld_lkeICProductType.Size = new System.Drawing.Size(157, 20);
            this.fld_lkeICProductType.TabIndex = 7;
            this.fld_lkeICProductType.Tag = "DC";
            this.fld_lkeICProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductType_CloseUp);
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(120, 199);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 6;
            this.fld_lnkSetDefaultDesc.TabStop = false;
            this.fld_lnkSetDefaultDesc.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkSetDefaultDesc_OpenLink);
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.BOSComment = null;
            this.fld_lblLabel17.BOSDataMember = null;
            this.fld_lblLabel17.BOSDataSource = null;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = null;
            this.fld_lblLabel17.BOSFieldRelation = null;
            this.fld_lblLabel17.BOSPrivilege = null;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(22, 224);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel17.TabIndex = 20;
            this.fld_lblLabel17.Text = "Loại";
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
            this.bosLabel2.Location = new System.Drawing.Point(22, 135);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 18;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên PLDG";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(22, 298);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel1.TabIndex = 22;
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
            this.fld_txtICProductNo.Location = new System.Drawing.Point(120, 29);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(157, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_txtICProductStockMax
            // 
            this.fld_txtICProductStockMax.BOSComment = "";
            this.fld_txtICProductStockMax.BOSDataMember = "ICProductStockMax";
            this.fld_txtICProductStockMax.BOSDataSource = "ICProducts";
            this.fld_txtICProductStockMax.BOSDescription = null;
            this.fld_txtICProductStockMax.BOSError = null;
            this.fld_txtICProductStockMax.BOSFieldGroup = "";
            this.fld_txtICProductStockMax.BOSFieldRelation = "";
            this.fld_txtICProductStockMax.BOSPrivilege = "";
            this.fld_txtICProductStockMax.BOSPropertyName = "Text";
            this.fld_txtICProductStockMax.EditValue = "0.00";
            this.fld_txtICProductStockMax.Location = new System.Drawing.Point(106, 53);
            this.fld_txtICProductStockMax.Name = "fld_txtICProductStockMax";
            this.fld_txtICProductStockMax.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductStockMax.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductStockMax.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductStockMax.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductStockMax.Properties.Mask.EditMask = "n";
            this.fld_txtICProductStockMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductStockMax.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductStockMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductStockMax.Screen = null;
            this.fld_txtICProductStockMax.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductStockMax.TabIndex = 7;
            this.fld_txtICProductStockMax.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseFont = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(13, 56);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel2.TabIndex = 6;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Số lượng tối đa";
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
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(108, 89);
            this.fld_lkeFK_GEVATID.Name = "fld_lkeFK_GEVATID";
            this.fld_lkeFK_GEVATID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEVATID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEVATID.Properties.ColumnName = null;
            this.fld_lkeFK_GEVATID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATPercentValue", "Thuế")});
            this.fld_lkeFK_GEVATID.Properties.DisplayMember = "GEVATPercentValue";
            this.fld_lkeFK_GEVATID.Properties.NullText = "";
            this.fld_lkeFK_GEVATID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEVATID.Properties.ValueMember = "GEVATID";
            this.fld_lkeFK_GEVATID.Screen = null;
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 2;
            this.fld_lkeFK_GEVATID.Tag = "DC";
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
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_ckICProductIsFollowInventoryStock);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICPriceCalculationMethodID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel20);
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEVATID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(434, 354);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(644, 328);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Đơn vị tính && Giá";
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
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(108, 165);
            this.fld_ckICProductIsFollowInventoryStock.Name = "fld_ckICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Caption = "Theo dõi tồn kho";
            this.fld_ckICProductIsFollowInventoryStock.Screen = null;
            this.fld_ckICProductIsFollowInventoryStock.Size = new System.Drawing.Size(111, 20);
            this.fld_ckICProductIsFollowInventoryStock.TabIndex = 5;
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(108, 139);
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeFK_ICPriceCalculationMethodID.TabIndex = 4;
            this.fld_lkeFK_ICPriceCalculationMethodID.Tag = "DC";
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
            this.bosLabel20.Location = new System.Drawing.Point(18, 142);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(80, 13);
            this.bosLabel20.TabIndex = 349;
            this.bosLabel20.Text = "Nhóm PP tính giá";
            // 
            // fld_lnkShowHistoryBranchPrice
            // 
            this.fld_lnkShowHistoryBranchPrice.EditValue = "Lịch sử giá bán theo chi nhánh";
            this.fld_lnkShowHistoryBranchPrice.Location = new System.Drawing.Point(276, 85);
            this.fld_lnkShowHistoryBranchPrice.MenuManager = this.screenToolbar;
            this.fld_lnkShowHistoryBranchPrice.Name = "fld_lnkShowHistoryBranchPrice";
            this.fld_lnkShowHistoryBranchPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkShowHistoryBranchPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkShowHistoryBranchPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkShowHistoryBranchPrice.Size = new System.Drawing.Size(169, 18);
            this.fld_lnkShowHistoryBranchPrice.TabIndex = 9;
            this.fld_lnkShowHistoryBranchPrice.TabStop = false;
            this.fld_lnkShowHistoryBranchPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkShowHistoryBranchPrice_OpenLink);
            // 
            // fld_lnkEditPurchasePrice
            // 
            this.fld_lnkEditPurchasePrice.EditValue = "Sửa giá mua theo tiền tệ";
            this.fld_lnkEditPurchasePrice.Location = new System.Drawing.Point(276, 61);
            this.fld_lnkEditPurchasePrice.Name = "fld_lnkEditPurchasePrice";
            this.fld_lnkEditPurchasePrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPurchasePrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPurchasePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkEditPurchasePrice.Size = new System.Drawing.Size(155, 18);
            this.fld_lnkEditPurchasePrice.TabIndex = 8;
            this.fld_lnkEditPurchasePrice.TabStop = false;
            this.fld_lnkEditPurchasePrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPurchasePrice_OpenLink);
            // 
            // fld_lnkOpenBranchPrice
            // 
            this.fld_lnkOpenBranchPrice.EditValue = "Sửa giá các chi nhánh";
            this.fld_lnkOpenBranchPrice.Location = new System.Drawing.Point(353, 39);
            this.fld_lnkOpenBranchPrice.MenuManager = this.screenToolbar;
            this.fld_lnkOpenBranchPrice.Name = "fld_lnkOpenBranchPrice";
            this.fld_lnkOpenBranchPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenBranchPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenBranchPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkOpenBranchPrice.Size = new System.Drawing.Size(126, 18);
            this.fld_lnkOpenBranchPrice.TabIndex = 7;
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(108, 115);
            this.fld_lkeFK_ICProductBasicUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Đơn vị tính")});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.NullText = "";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Screen = null;
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(152, 20);
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(18, 116);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel16.TabIndex = 341;
            this.fld_lblLabel16.Text = "ĐVT";
            // 
            // fld_lnkEditPrice
            // 
            this.fld_lnkEditPrice.EditValue = "Sửa mức giá";
            this.fld_lnkEditPrice.Location = new System.Drawing.Point(276, 39);
            this.fld_lnkEditPrice.MenuManager = this.screenToolbar;
            this.fld_lnkEditPrice.Name = "fld_lnkEditPrice";
            this.fld_lnkEditPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fld_lnkEditPrice.Size = new System.Drawing.Size(74, 18);
            this.fld_lnkEditPrice.TabIndex = 6;
            this.fld_lnkEditPrice.TabStop = false;
            this.fld_lnkEditPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPrice_OpenLink);
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
            this.fld_txtICProductPrice01.EditValue = "0.00";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(108, 37);
            this.fld_txtICProductPrice01.Name = "fld_txtICProductPrice01";
            this.fld_txtICProductPrice01.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductPrice01.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductPrice01.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductPrice01.Properties.Mask.EditMask = "n";
            this.fld_txtICProductPrice01.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductPrice01.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductPrice01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductPrice01.Screen = null;
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(152, 20);
            this.fld_txtICProductPrice01.TabIndex = 0;
            this.fld_txtICProductPrice01.Tag = "DC";
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
            this.fld_lblLabel23.Location = new System.Drawing.Point(18, 40);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel23.TabIndex = 325;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Giá bán";
            // 
            // fld_grcGroupControl4
            // 
            this.fld_grcGroupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl4.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl4.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl4.BOSComment = "";
            this.fld_grcGroupControl4.BOSDataMember = "";
            this.fld_grcGroupControl4.BOSDataSource = "";
            this.fld_grcGroupControl4.BOSDescription = null;
            this.fld_grcGroupControl4.BOSError = null;
            this.fld_grcGroupControl4.BOSFieldGroup = "";
            this.fld_grcGroupControl4.BOSFieldRelation = "";
            this.fld_grcGroupControl4.BOSPrivilege = "";
            this.fld_grcGroupControl4.BOSPropertyName = "";
            this.fld_grcGroupControl4.Controls.Add(this.fld_Lablel1);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtICProductStockMin);
            this.fld_grcGroupControl4.Controls.Add(this.fld_txtICProductStockMax);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel12);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel26);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel27);
            this.fld_grcGroupControl4.Controls.Add(this.fld_lblLabel29);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteICProductStockMinDateFrom);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteICProductStockMinDateTo);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteICProductStockMaxDateFrom);
            this.fld_grcGroupControl4.Controls.Add(this.fld_dteICProductStockMaxDateTo);
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(1, 117);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(1058, 89);
            this.fld_grcGroupControl4.TabIndex = 1;
            this.fld_grcGroupControl4.Tag = "";
            this.fld_grcGroupControl4.Text = "Thông tin kho";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(260, 30);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel12.TabIndex = 2;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Từ ngày";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel26.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseFont = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = "";
            this.fld_lblLabel26.BOSDataMember = "";
            this.fld_lblLabel26.BOSDataSource = "";
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = "";
            this.fld_lblLabel26.BOSFieldRelation = "";
            this.fld_lblLabel26.BOSPrivilege = "";
            this.fld_lblLabel26.BOSPropertyName = "";
            this.fld_lblLabel26.Location = new System.Drawing.Point(522, 30);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel26.TabIndex = 4;
            this.fld_lblLabel26.Tag = "";
            this.fld_lblLabel26.Text = "Đến";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseFont = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = "";
            this.fld_lblLabel27.Location = new System.Drawing.Point(260, 56);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel27.TabIndex = 8;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Từ ngày";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseFont = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "";
            this.fld_lblLabel29.BOSDataSource = "";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = "";
            this.fld_lblLabel29.Location = new System.Drawing.Point(522, 56);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel29.TabIndex = 10;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "Đến";
            // 
            // fld_dteICProductStockMinDateFrom
            // 
            this.fld_dteICProductStockMinDateFrom.BOSComment = "";
            this.fld_dteICProductStockMinDateFrom.BOSDataMember = "ICProductStockMinDateFrom";
            this.fld_dteICProductStockMinDateFrom.BOSDataSource = "ICProducts";
            this.fld_dteICProductStockMinDateFrom.BOSDescription = null;
            this.fld_dteICProductStockMinDateFrom.BOSError = null;
            this.fld_dteICProductStockMinDateFrom.BOSFieldGroup = "";
            this.fld_dteICProductStockMinDateFrom.BOSFieldRelation = "";
            this.fld_dteICProductStockMinDateFrom.BOSPrivilege = "";
            this.fld_dteICProductStockMinDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteICProductStockMinDateFrom.EditValue = null;
            this.fld_dteICProductStockMinDateFrom.Location = new System.Drawing.Point(362, 27);
            this.fld_dteICProductStockMinDateFrom.Name = "fld_dteICProductStockMinDateFrom";
            this.fld_dteICProductStockMinDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductStockMinDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductStockMinDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductStockMinDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductStockMinDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductStockMinDateFrom.Screen = null;
            this.fld_dteICProductStockMinDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteICProductStockMinDateFrom.TabIndex = 3;
            this.fld_dteICProductStockMinDateFrom.Tag = "DC";
            // 
            // fld_dteICProductStockMinDateTo
            // 
            this.fld_dteICProductStockMinDateTo.BOSComment = "";
            this.fld_dteICProductStockMinDateTo.BOSDataMember = "ICProductStockMinDateTo";
            this.fld_dteICProductStockMinDateTo.BOSDataSource = "ICProducts";
            this.fld_dteICProductStockMinDateTo.BOSDescription = null;
            this.fld_dteICProductStockMinDateTo.BOSError = null;
            this.fld_dteICProductStockMinDateTo.BOSFieldGroup = "";
            this.fld_dteICProductStockMinDateTo.BOSFieldRelation = "";
            this.fld_dteICProductStockMinDateTo.BOSPrivilege = "";
            this.fld_dteICProductStockMinDateTo.BOSPropertyName = "EditValue";
            this.fld_dteICProductStockMinDateTo.EditValue = null;
            this.fld_dteICProductStockMinDateTo.Location = new System.Drawing.Point(595, 27);
            this.fld_dteICProductStockMinDateTo.Name = "fld_dteICProductStockMinDateTo";
            this.fld_dteICProductStockMinDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductStockMinDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductStockMinDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductStockMinDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductStockMinDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductStockMinDateTo.Screen = null;
            this.fld_dteICProductStockMinDateTo.Size = new System.Drawing.Size(132, 20);
            this.fld_dteICProductStockMinDateTo.TabIndex = 5;
            this.fld_dteICProductStockMinDateTo.Tag = "DC";
            // 
            // fld_dteICProductStockMaxDateFrom
            // 
            this.fld_dteICProductStockMaxDateFrom.BOSComment = "";
            this.fld_dteICProductStockMaxDateFrom.BOSDataMember = "ICProductStockMaxDateFrom";
            this.fld_dteICProductStockMaxDateFrom.BOSDataSource = "ICProducts";
            this.fld_dteICProductStockMaxDateFrom.BOSDescription = null;
            this.fld_dteICProductStockMaxDateFrom.BOSError = null;
            this.fld_dteICProductStockMaxDateFrom.BOSFieldGroup = "";
            this.fld_dteICProductStockMaxDateFrom.BOSFieldRelation = "";
            this.fld_dteICProductStockMaxDateFrom.BOSPrivilege = "";
            this.fld_dteICProductStockMaxDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteICProductStockMaxDateFrom.EditValue = null;
            this.fld_dteICProductStockMaxDateFrom.Location = new System.Drawing.Point(362, 53);
            this.fld_dteICProductStockMaxDateFrom.Name = "fld_dteICProductStockMaxDateFrom";
            this.fld_dteICProductStockMaxDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductStockMaxDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductStockMaxDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductStockMaxDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductStockMaxDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductStockMaxDateFrom.Screen = null;
            this.fld_dteICProductStockMaxDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteICProductStockMaxDateFrom.TabIndex = 9;
            this.fld_dteICProductStockMaxDateFrom.Tag = "DC";
            // 
            // fld_dteICProductStockMaxDateTo
            // 
            this.fld_dteICProductStockMaxDateTo.BOSComment = "";
            this.fld_dteICProductStockMaxDateTo.BOSDataMember = "ICProductStockMaxDateTo";
            this.fld_dteICProductStockMaxDateTo.BOSDataSource = "ICProducts";
            this.fld_dteICProductStockMaxDateTo.BOSDescription = null;
            this.fld_dteICProductStockMaxDateTo.BOSError = null;
            this.fld_dteICProductStockMaxDateTo.BOSFieldGroup = "";
            this.fld_dteICProductStockMaxDateTo.BOSFieldRelation = "";
            this.fld_dteICProductStockMaxDateTo.BOSPrivilege = "";
            this.fld_dteICProductStockMaxDateTo.BOSPropertyName = "EditValue";
            this.fld_dteICProductStockMaxDateTo.EditValue = null;
            this.fld_dteICProductStockMaxDateTo.Location = new System.Drawing.Point(595, 53);
            this.fld_dteICProductStockMaxDateTo.Name = "fld_dteICProductStockMaxDateTo";
            this.fld_dteICProductStockMaxDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICProductStockMaxDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICProductStockMaxDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICProductStockMaxDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICProductStockMaxDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICProductStockMaxDateTo.Screen = null;
            this.fld_dteICProductStockMaxDateTo.Size = new System.Drawing.Size(132, 20);
            this.fld_dteICProductStockMaxDateTo.TabIndex = 11;
            this.fld_dteICProductStockMaxDateTo.Tag = "DC";
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
            this.fld_lblLabel11.TabIndex = 331;
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
            this.bosPanel1.Size = new System.Drawing.Size(1083, 710);
            this.bosPanel1.TabIndex = 333;
            // 
            // fld_tabProducts
            // 
            this.fld_tabProducts.BOSComment = null;
            this.fld_tabProducts.BOSDataMember = null;
            this.fld_tabProducts.BOSDataSource = null;
            this.fld_tabProducts.BOSDescription = null;
            this.fld_tabProducts.BOSError = null;
            this.fld_tabProducts.BOSFieldGroup = null;
            this.fld_tabProducts.BOSFieldRelation = null;
            this.fld_tabProducts.BOSPrivilege = null;
            this.fld_tabProducts.BOSPropertyName = null;
            this.fld_tabProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProducts.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProducts.Name = "fld_tabProducts";
            this.fld_tabProducts.Screen = null;
            this.fld_tabProducts.SelectedTabPage = this.fld_tabInfomation;
            this.ScreenHelper.SetShowHelp(this.fld_tabProducts, true);
            this.fld_tabProducts.Size = new System.Drawing.Size(1083, 710);
            this.fld_tabProducts.TabIndex = 0;
            this.fld_tabProducts.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabInfomation,
            this.fld_tabAccountStockHistory,
            this.fld_tabPackagingNorm,
            this.fld_tabProductMeasureUnits,
            this.xtraTabPage1});
            // 
            // fld_tabInfomation
            // 
            this.fld_tabInfomation.Controls.Add(this.fld_grcGroupControl5);
            this.fld_tabInfomation.Controls.Add(this.bosGroupControl2);
            this.fld_tabInfomation.Controls.Add(this.fld_grcGroupControl1);
            this.fld_tabInfomation.Name = "fld_tabInfomation";
            this.fld_tabInfomation.Size = new System.Drawing.Size(1081, 685);
            this.fld_tabInfomation.Text = "Thông tin chung - thuộc tính";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductCapacity);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductSizeAndSpecifiCations);
            this.bosGroupControl2.Controls.Add(this.bosLabel19);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductAttribute);
            this.bosGroupControl2.Controls.Add(this.bosLabel16);
            this.bosGroupControl2.Controls.Add(this.bosLabel4);
            this.bosGroupControl2.Controls.Add(this.fld_btnUpdateInside);
            this.bosGroupControl2.Controls.Add(this.fld_btnUpdateOverroll);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductPurchaseType);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductOverallDimensionHeight);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductBoxUnitPrice);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductBoxArea);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLeadTime);
            this.bosGroupControl2.Controls.Add(this.bosLabel14);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductInsideDimensionHeight);
            this.bosGroupControl2.Controls.Add(this.bosLabel15);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductOverallDimensionLength);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductInsideDimensionLength);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductOverallDimensionWidth);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductInsideDimensionWidth);
            this.bosGroupControl2.Controls.Add(this.fld_txtFK_ICProdAttPackingMaterialSpecialityID);
            this.bosGroupControl2.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl2.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl2.Controls.Add(this.bosLabel11);
            this.bosGroupControl2.Controls.Add(this.bosLabel10);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductGrossWeight);
            this.bosGroupControl2.Controls.Add(this.bosLabel13);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductNetWeight);
            this.bosGroupControl2.Controls.Add(this.bosLabel12);
            this.bosGroupControl2.Controls.Add(this.bosLabel8);
            this.bosGroupControl2.Controls.Add(this.bosLabel6);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Location = new System.Drawing.Point(434, 4);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(644, 339);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thuộc tính";
            // 
            // fld_txtICProductCapacity
            // 
            this.fld_txtICProductCapacity.BOSComment = "";
            this.fld_txtICProductCapacity.BOSDataMember = "ICProductCapacity";
            this.fld_txtICProductCapacity.BOSDataSource = "ICProducts";
            this.fld_txtICProductCapacity.BOSDescription = null;
            this.fld_txtICProductCapacity.BOSError = null;
            this.fld_txtICProductCapacity.BOSFieldGroup = "";
            this.fld_txtICProductCapacity.BOSFieldRelation = "";
            this.fld_txtICProductCapacity.BOSPrivilege = "";
            this.fld_txtICProductCapacity.BOSPropertyName = "Text";
            this.fld_txtICProductCapacity.EditValue = "";
            this.fld_txtICProductCapacity.Location = new System.Drawing.Point(139, 181);
            this.fld_txtICProductCapacity.Name = "fld_txtICProductCapacity";
            this.fld_txtICProductCapacity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCapacity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCapacity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCapacity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCapacity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductCapacity.Screen = null;
            this.fld_txtICProductCapacity.Size = new System.Drawing.Size(266, 20);
            this.fld_txtICProductCapacity.TabIndex = 12;
            this.fld_txtICProductCapacity.Tag = "DC";
            // 
            // fld_txtICProductSizeAndSpecifiCations
            // 
            this.fld_txtICProductSizeAndSpecifiCations.BOSComment = "";
            this.fld_txtICProductSizeAndSpecifiCations.BOSDataMember = "ICProductSizeAndSpecifiCations";
            this.fld_txtICProductSizeAndSpecifiCations.BOSDataSource = "ICProducts";
            this.fld_txtICProductSizeAndSpecifiCations.BOSDescription = null;
            this.fld_txtICProductSizeAndSpecifiCations.BOSError = null;
            this.fld_txtICProductSizeAndSpecifiCations.BOSFieldGroup = "";
            this.fld_txtICProductSizeAndSpecifiCations.BOSFieldRelation = "";
            this.fld_txtICProductSizeAndSpecifiCations.BOSPrivilege = "";
            this.fld_txtICProductSizeAndSpecifiCations.BOSPropertyName = "Text";
            this.fld_txtICProductSizeAndSpecifiCations.EditValue = "";
            this.fld_txtICProductSizeAndSpecifiCations.Location = new System.Drawing.Point(139, 155);
            this.fld_txtICProductSizeAndSpecifiCations.Name = "fld_txtICProductSizeAndSpecifiCations";
            this.fld_txtICProductSizeAndSpecifiCations.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSizeAndSpecifiCations.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSizeAndSpecifiCations.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSizeAndSpecifiCations.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSizeAndSpecifiCations.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSizeAndSpecifiCations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSizeAndSpecifiCations.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductSizeAndSpecifiCations, true);
            this.fld_txtICProductSizeAndSpecifiCations.Size = new System.Drawing.Size(266, 20);
            this.fld_txtICProductSizeAndSpecifiCations.TabIndex = 11;
            this.fld_txtICProductSizeAndSpecifiCations.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "ICProductName";
            this.bosLabel19.BOSDataSource = "ICProducts";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(18, 157);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel19, true);
            this.bosLabel19.Size = new System.Drawing.Size(99, 13);
            this.bosLabel19.TabIndex = 345;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Kích thước / Q.cách";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(18, 314);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel8.TabIndex = 343;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Thuộc tính khác";
            // 
            // fld_bedICProductAttribute
            // 
            this.fld_bedICProductAttribute.BOSComment = "";
            this.fld_bedICProductAttribute.BOSDataMember = "ICProductAttribute";
            this.fld_bedICProductAttribute.BOSDataSource = "ICProducts";
            this.fld_bedICProductAttribute.BOSDescription = null;
            this.fld_bedICProductAttribute.BOSError = null;
            this.fld_bedICProductAttribute.BOSFieldGroup = "";
            this.fld_bedICProductAttribute.BOSFieldRelation = "";
            this.fld_bedICProductAttribute.BOSPrivilege = "";
            this.fld_bedICProductAttribute.BOSPropertyName = "Text";
            this.fld_bedICProductAttribute.EditValue = "<ButtonEdit>";
            this.fld_bedICProductAttribute.Location = new System.Drawing.Point(139, 311);
            this.fld_bedICProductAttribute.Name = "fld_bedICProductAttribute";
            this.fld_bedICProductAttribute.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_bedICProductAttribute.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_bedICProductAttribute.Properties.Appearance.Options.UseBackColor = true;
            this.fld_bedICProductAttribute.Properties.Appearance.Options.UseForeColor = true;
            this.fld_bedICProductAttribute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedICProductAttribute.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_bedICProductAttribute.Properties.ReadOnly = true;
            this.fld_bedICProductAttribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_bedICProductAttribute.Screen = null;
            this.fld_bedICProductAttribute.Size = new System.Drawing.Size(266, 20);
            this.fld_bedICProductAttribute.TabIndex = 21;
            this.fld_bedICProductAttribute.Tag = "DC";
            this.fld_bedICProductAttribute.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Fld_bedICProductAttribute_ButtonClick_1);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
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
            this.bosLabel16.Location = new System.Drawing.Point(252, 236);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(61, 13);
            this.bosLabel16.TabIndex = 17;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Đơn giá (M2)";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
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
            this.bosLabel4.Location = new System.Drawing.Point(18, 236);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(98, 13);
            this.bosLabel4.TabIndex = 27;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Diện tích thùng (M2)";
            // 
            // fld_btnUpdateInside
            // 
            this.fld_btnUpdateInside.BOSComment = null;
            this.fld_btnUpdateInside.BOSDataMember = null;
            this.fld_btnUpdateInside.BOSDataSource = null;
            this.fld_btnUpdateInside.BOSDescription = null;
            this.fld_btnUpdateInside.BOSError = null;
            this.fld_btnUpdateInside.BOSFieldGroup = null;
            this.fld_btnUpdateInside.BOSFieldRelation = null;
            this.fld_btnUpdateInside.BOSPrivilege = null;
            this.fld_btnUpdateInside.BOSPropertyName = null;
            this.fld_btnUpdateInside.Location = new System.Drawing.Point(411, 103);
            this.fld_btnUpdateInside.Name = "fld_btnUpdateInside";
            this.fld_btnUpdateInside.Screen = null;
            this.fld_btnUpdateInside.Size = new System.Drawing.Size(84, 20);
            this.fld_btnUpdateInside.TabIndex = 6;
            this.fld_btnUpdateInside.Text = "Tính lọt lòng";
            this.fld_btnUpdateInside.Click += new System.EventHandler(this.fld_btnUpdateInside_Click);
            // 
            // fld_btnUpdateOverroll
            // 
            this.fld_btnUpdateOverroll.BOSComment = null;
            this.fld_btnUpdateOverroll.BOSDataMember = null;
            this.fld_btnUpdateOverroll.BOSDataSource = null;
            this.fld_btnUpdateOverroll.BOSDescription = null;
            this.fld_btnUpdateOverroll.BOSError = null;
            this.fld_btnUpdateOverroll.BOSFieldGroup = null;
            this.fld_btnUpdateOverroll.BOSFieldRelation = null;
            this.fld_btnUpdateOverroll.BOSPrivilege = null;
            this.fld_btnUpdateOverroll.BOSPropertyName = null;
            this.fld_btnUpdateOverroll.Location = new System.Drawing.Point(411, 128);
            this.fld_btnUpdateOverroll.Name = "fld_btnUpdateOverroll";
            this.fld_btnUpdateOverroll.Screen = null;
            this.fld_btnUpdateOverroll.Size = new System.Drawing.Size(84, 20);
            this.fld_btnUpdateOverroll.TabIndex = 10;
            this.fld_btnUpdateOverroll.Text = "Tính phủ bì";
            this.fld_btnUpdateOverroll.Click += new System.EventHandler(this.fld_btnUpdateOverroll_Click);
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
            this.fld_lkeICProductPurchaseType.Location = new System.Drawing.Point(139, 285);
            this.fld_lkeICProductPurchaseType.Name = "fld_lkeICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPurchaseType.Properties.ColumnName = null;
            this.fld_lkeICProductPurchaseType.Properties.NullText = "";
            this.fld_lkeICProductPurchaseType.Screen = null;
            this.fld_lkeICProductPurchaseType.Size = new System.Drawing.Size(266, 20);
            this.fld_lkeICProductPurchaseType.TabIndex = 20;
            this.fld_lkeICProductPurchaseType.Tag = "DC";
            // 
            // fld_txtICProductOverallDimensionHeight
            // 
            this.fld_txtICProductOverallDimensionHeight.BOSComment = "";
            this.fld_txtICProductOverallDimensionHeight.BOSDataMember = "ICProductOverallDimensionHeight";
            this.fld_txtICProductOverallDimensionHeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductOverallDimensionHeight.BOSDescription = null;
            this.fld_txtICProductOverallDimensionHeight.BOSError = null;
            this.fld_txtICProductOverallDimensionHeight.BOSFieldGroup = "";
            this.fld_txtICProductOverallDimensionHeight.BOSFieldRelation = "";
            this.fld_txtICProductOverallDimensionHeight.BOSPrivilege = "";
            this.fld_txtICProductOverallDimensionHeight.BOSPropertyName = "Text";
            this.fld_txtICProductOverallDimensionHeight.Location = new System.Drawing.Point(325, 129);
            this.fld_txtICProductOverallDimensionHeight.Name = "fld_txtICProductOverallDimensionHeight";
            this.fld_txtICProductOverallDimensionHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductOverallDimensionHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductOverallDimensionHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductOverallDimensionHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductOverallDimensionHeight.Properties.Mask.EditMask = "n";
            this.fld_txtICProductOverallDimensionHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductOverallDimensionHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductOverallDimensionHeight.Screen = null;
            this.fld_txtICProductOverallDimensionHeight.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductOverallDimensionHeight.TabIndex = 9;
            this.fld_txtICProductOverallDimensionHeight.Tag = "DC";
            this.fld_txtICProductOverallDimensionHeight.Validated += new System.EventHandler(this.fld_txtICProductOverallDimensionHeight_Validated);
            // 
            // fld_txtICProductBoxUnitPrice
            // 
            this.fld_txtICProductBoxUnitPrice.BOSComment = "";
            this.fld_txtICProductBoxUnitPrice.BOSDataMember = "ICProductBoxUnitPrice";
            this.fld_txtICProductBoxUnitPrice.BOSDataSource = "ICProducts";
            this.fld_txtICProductBoxUnitPrice.BOSDescription = null;
            this.fld_txtICProductBoxUnitPrice.BOSError = null;
            this.fld_txtICProductBoxUnitPrice.BOSFieldGroup = "";
            this.fld_txtICProductBoxUnitPrice.BOSFieldRelation = "";
            this.fld_txtICProductBoxUnitPrice.BOSPrivilege = "";
            this.fld_txtICProductBoxUnitPrice.BOSPropertyName = "Text";
            this.fld_txtICProductBoxUnitPrice.EditValue = "";
            this.fld_txtICProductBoxUnitPrice.Location = new System.Drawing.Point(325, 233);
            this.fld_txtICProductBoxUnitPrice.Name = "fld_txtICProductBoxUnitPrice";
            this.fld_txtICProductBoxUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductBoxUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductBoxUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductBoxUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductBoxUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductBoxUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductBoxUnitPrice.Screen = null;
            this.fld_txtICProductBoxUnitPrice.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductBoxUnitPrice.TabIndex = 18;
            this.fld_txtICProductBoxUnitPrice.Tag = "DC";
            this.fld_txtICProductBoxUnitPrice.Validated += new System.EventHandler(this.fld_txtICProductBoxUnitPrice_Validated);
            // 
            // fld_txtICProductBoxArea
            // 
            this.fld_txtICProductBoxArea.BOSComment = "";
            this.fld_txtICProductBoxArea.BOSDataMember = "ICProductBoxArea";
            this.fld_txtICProductBoxArea.BOSDataSource = "ICProducts";
            this.fld_txtICProductBoxArea.BOSDescription = null;
            this.fld_txtICProductBoxArea.BOSError = null;
            this.fld_txtICProductBoxArea.BOSFieldGroup = "";
            this.fld_txtICProductBoxArea.BOSFieldRelation = "";
            this.fld_txtICProductBoxArea.BOSPrivilege = "";
            this.fld_txtICProductBoxArea.BOSPropertyName = "EditValue";
            this.fld_txtICProductBoxArea.EditValue = "";
            this.fld_txtICProductBoxArea.Location = new System.Drawing.Point(139, 233);
            this.fld_txtICProductBoxArea.Name = "fld_txtICProductBoxArea";
            this.fld_txtICProductBoxArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductBoxArea.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductBoxArea.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductBoxArea.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductBoxArea.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductBoxArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductBoxArea.Screen = null;
            this.fld_txtICProductBoxArea.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductBoxArea.TabIndex = 16;
            this.fld_txtICProductBoxArea.Tag = "DC";
            this.fld_txtICProductBoxArea.Validated += new System.EventHandler(this.fld_txtICProductBoxArea_Validated);
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
            this.fld_txtICProductLeadTime.Location = new System.Drawing.Point(139, 259);
            this.fld_txtICProductLeadTime.Name = "fld_txtICProductLeadTime";
            this.fld_txtICProductLeadTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLeadTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLeadTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductLeadTime.Screen = null;
            this.fld_txtICProductLeadTime.Size = new System.Drawing.Size(266, 20);
            this.fld_txtICProductLeadTime.TabIndex = 19;
            this.fld_txtICProductLeadTime.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(18, 288);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(69, 13);
            this.bosLabel14.TabIndex = 29;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Loại mua hàng";
            // 
            // fld_txtICProductInsideDimensionHeight
            // 
            this.fld_txtICProductInsideDimensionHeight.BOSComment = "";
            this.fld_txtICProductInsideDimensionHeight.BOSDataMember = "ICProductInsideDimensionHeight";
            this.fld_txtICProductInsideDimensionHeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductInsideDimensionHeight.BOSDescription = null;
            this.fld_txtICProductInsideDimensionHeight.BOSError = null;
            this.fld_txtICProductInsideDimensionHeight.BOSFieldGroup = "";
            this.fld_txtICProductInsideDimensionHeight.BOSFieldRelation = "";
            this.fld_txtICProductInsideDimensionHeight.BOSPrivilege = "";
            this.fld_txtICProductInsideDimensionHeight.BOSPropertyName = "Text";
            this.fld_txtICProductInsideDimensionHeight.Location = new System.Drawing.Point(325, 103);
            this.fld_txtICProductInsideDimensionHeight.Name = "fld_txtICProductInsideDimensionHeight";
            this.fld_txtICProductInsideDimensionHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductInsideDimensionHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductInsideDimensionHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductInsideDimensionHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductInsideDimensionHeight.Properties.Mask.EditMask = "n";
            this.fld_txtICProductInsideDimensionHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductInsideDimensionHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductInsideDimensionHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductInsideDimensionHeight, true);
            this.fld_txtICProductInsideDimensionHeight.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductInsideDimensionHeight.TabIndex = 5;
            this.fld_txtICProductInsideDimensionHeight.Tag = "DC";
            this.fld_txtICProductInsideDimensionHeight.Validated += new System.EventHandler(this.Fld_txtICProductInsideDimensionHeight_Validated);
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
            this.bosLabel15.Location = new System.Drawing.Point(18, 262);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(117, 13);
            this.bosLabel15.TabIndex = 28;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "T.gian hoàn thành (day)";
            // 
            // fld_txtICProductOverallDimensionLength
            // 
            this.fld_txtICProductOverallDimensionLength.BOSComment = "";
            this.fld_txtICProductOverallDimensionLength.BOSDataMember = "ICProductOverallDimensionLength";
            this.fld_txtICProductOverallDimensionLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductOverallDimensionLength.BOSDescription = null;
            this.fld_txtICProductOverallDimensionLength.BOSError = null;
            this.fld_txtICProductOverallDimensionLength.BOSFieldGroup = "";
            this.fld_txtICProductOverallDimensionLength.BOSFieldRelation = "";
            this.fld_txtICProductOverallDimensionLength.BOSPrivilege = "";
            this.fld_txtICProductOverallDimensionLength.BOSPropertyName = "Text";
            this.fld_txtICProductOverallDimensionLength.Location = new System.Drawing.Point(139, 129);
            this.fld_txtICProductOverallDimensionLength.Name = "fld_txtICProductOverallDimensionLength";
            this.fld_txtICProductOverallDimensionLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductOverallDimensionLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductOverallDimensionLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductOverallDimensionLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductOverallDimensionLength.Properties.Mask.EditMask = "n";
            this.fld_txtICProductOverallDimensionLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductOverallDimensionLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductOverallDimensionLength.Screen = null;
            this.fld_txtICProductOverallDimensionLength.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductOverallDimensionLength.TabIndex = 8;
            this.fld_txtICProductOverallDimensionLength.Tag = "DC";
            this.fld_txtICProductOverallDimensionLength.Validated += new System.EventHandler(this.fld_txtICProductOverallDimensionLength_Validated);
            // 
            // fld_txtICProductInsideDimensionLength
            // 
            this.fld_txtICProductInsideDimensionLength.BOSComment = "";
            this.fld_txtICProductInsideDimensionLength.BOSDataMember = "ICProductInsideDimensionLength";
            this.fld_txtICProductInsideDimensionLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductInsideDimensionLength.BOSDescription = null;
            this.fld_txtICProductInsideDimensionLength.BOSError = null;
            this.fld_txtICProductInsideDimensionLength.BOSFieldGroup = "";
            this.fld_txtICProductInsideDimensionLength.BOSFieldRelation = "";
            this.fld_txtICProductInsideDimensionLength.BOSPrivilege = "";
            this.fld_txtICProductInsideDimensionLength.BOSPropertyName = "Text";
            this.fld_txtICProductInsideDimensionLength.Location = new System.Drawing.Point(139, 103);
            this.fld_txtICProductInsideDimensionLength.Name = "fld_txtICProductInsideDimensionLength";
            this.fld_txtICProductInsideDimensionLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductInsideDimensionLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductInsideDimensionLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductInsideDimensionLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductInsideDimensionLength.Properties.Mask.EditMask = "n";
            this.fld_txtICProductInsideDimensionLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductInsideDimensionLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductInsideDimensionLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductInsideDimensionLength, true);
            this.fld_txtICProductInsideDimensionLength.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductInsideDimensionLength.TabIndex = 4;
            this.fld_txtICProductInsideDimensionLength.Tag = "DC";
            this.fld_txtICProductInsideDimensionLength.Validated += new System.EventHandler(this.Fld_txtICProductInsideDimensionLength_Validated);
            // 
            // fld_txtICProductOverallDimensionWidth
            // 
            this.fld_txtICProductOverallDimensionWidth.BOSComment = "";
            this.fld_txtICProductOverallDimensionWidth.BOSDataMember = "ICProductOverallDimensionWidth";
            this.fld_txtICProductOverallDimensionWidth.BOSDataSource = "ICProducts";
            this.fld_txtICProductOverallDimensionWidth.BOSDescription = null;
            this.fld_txtICProductOverallDimensionWidth.BOSError = null;
            this.fld_txtICProductOverallDimensionWidth.BOSFieldGroup = "";
            this.fld_txtICProductOverallDimensionWidth.BOSFieldRelation = "";
            this.fld_txtICProductOverallDimensionWidth.BOSPrivilege = "";
            this.fld_txtICProductOverallDimensionWidth.BOSPropertyName = "Text";
            this.fld_txtICProductOverallDimensionWidth.Location = new System.Drawing.Point(233, 129);
            this.fld_txtICProductOverallDimensionWidth.Name = "fld_txtICProductOverallDimensionWidth";
            this.fld_txtICProductOverallDimensionWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductOverallDimensionWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductOverallDimensionWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductOverallDimensionWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductOverallDimensionWidth.Properties.Mask.EditMask = null;
            this.fld_txtICProductOverallDimensionWidth.Screen = null;
            this.fld_txtICProductOverallDimensionWidth.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductOverallDimensionWidth.TabIndex = 7;
            this.fld_txtICProductOverallDimensionWidth.Tag = "DC";
            this.fld_txtICProductOverallDimensionWidth.Validated += new System.EventHandler(this.fld_txtICProductOverallDimensionWidth_Validated);
            // 
            // fld_txtICProductInsideDimensionWidth
            // 
            this.fld_txtICProductInsideDimensionWidth.BOSComment = "";
            this.fld_txtICProductInsideDimensionWidth.BOSDataMember = "ICProductInsideDimensionWidth";
            this.fld_txtICProductInsideDimensionWidth.BOSDataSource = "ICProducts";
            this.fld_txtICProductInsideDimensionWidth.BOSDescription = null;
            this.fld_txtICProductInsideDimensionWidth.BOSError = null;
            this.fld_txtICProductInsideDimensionWidth.BOSFieldGroup = "";
            this.fld_txtICProductInsideDimensionWidth.BOSFieldRelation = "";
            this.fld_txtICProductInsideDimensionWidth.BOSPrivilege = "";
            this.fld_txtICProductInsideDimensionWidth.BOSPropertyName = "Text";
            this.fld_txtICProductInsideDimensionWidth.Location = new System.Drawing.Point(233, 103);
            this.fld_txtICProductInsideDimensionWidth.Name = "fld_txtICProductInsideDimensionWidth";
            this.fld_txtICProductInsideDimensionWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductInsideDimensionWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductInsideDimensionWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductInsideDimensionWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductInsideDimensionWidth.Properties.Mask.EditMask = null;
            this.fld_txtICProductInsideDimensionWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductInsideDimensionWidth, false);
            this.fld_txtICProductInsideDimensionWidth.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductInsideDimensionWidth.TabIndex = 3;
            this.fld_txtICProductInsideDimensionWidth.Tag = "DC";
            this.fld_txtICProductInsideDimensionWidth.Validated += new System.EventHandler(this.Fld_txtICProductInsideDimensionWidth_Validated);
            // 
            // fld_txtFK_ICProdAttPackingMaterialSpecialityID
            // 
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSAllowAddNew = false;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSAllowDummy = true;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSComment = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSDataMember = "FK_ICProdAttPackingMaterialSpecialityID";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSDataSource = "ICProducts";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSDescription = null;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSError = null;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSFieldGroup = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSFieldParent = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSFieldRelation = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSPrivilege = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSPropertyName = "EditValue";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.BOSSelectTypeValue = "PackingMaterialSpeciality";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.CurrentDisplayText = null;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Location = new System.Drawing.Point(139, 25);
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Name = "fld_txtFK_ICProdAttPackingMaterialSpecialityID";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.ColumnName = null;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Đặc tính")});
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.NullText = "";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Screen = null;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Size = new System.Drawing.Size(266, 20);
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.TabIndex = 0;
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Tag = "DC";
            this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Validated += new System.EventHandler(this.fld_txtFK_ICProdAttPackingMaterialSpecialityID_Validated);
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "FK_ICProdAttPackingMaterialSizeID";
            this.bosLookupEdit2.BOSDataSource = "ICProducts";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "ICProductAttributeGroup";
            this.bosLookupEdit2.BOSSelectTypeValue = "PackingMaterialSize";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(139, 51);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Khổ màng foam PLDG")});
            this.bosLookupEdit2.Properties.DisplayMember = "ICProductAttributeValue";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "ICProductAttributeID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(266, 20);
            this.bosLookupEdit2.TabIndex = 1;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "FK_ICProdAttPackingMaterialWeightPerVolumeID";
            this.bosLookupEdit1.BOSDataSource = "ICProducts";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "ICProductAttributeGroup";
            this.bosLookupEdit1.BOSSelectTypeValue = "PackingMaterialWeightPerVolume";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(139, 77);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Định lượng PLDG")});
            this.bosLookupEdit1.Properties.DisplayMember = "ICProductAttributeValue";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ICProductAttributeID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(266, 20);
            this.bosLookupEdit1.TabIndex = 2;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(18, 83);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(80, 13);
            this.bosLabel11.TabIndex = 22;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Định lượng PLDG";
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
            this.bosLabel10.Location = new System.Drawing.Point(18, 57);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(102, 13);
            this.bosLabel10.TabIndex = 21;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Khổ màng foam PLDG";
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
            this.bosLabel9.Location = new System.Drawing.Point(18, 31);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(68, 13);
            this.bosLabel9.TabIndex = 20;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Đặc tính PLDG";
            // 
            // fld_txtICProductGrossWeight
            // 
            this.fld_txtICProductGrossWeight.BOSComment = "";
            this.fld_txtICProductGrossWeight.BOSDataMember = "ICProductGrossWeight";
            this.fld_txtICProductGrossWeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductGrossWeight.BOSDescription = null;
            this.fld_txtICProductGrossWeight.BOSError = null;
            this.fld_txtICProductGrossWeight.BOSFieldGroup = "";
            this.fld_txtICProductGrossWeight.BOSFieldRelation = "";
            this.fld_txtICProductGrossWeight.BOSPrivilege = "";
            this.fld_txtICProductGrossWeight.BOSPropertyName = "Text";
            this.fld_txtICProductGrossWeight.EditValue = "";
            this.fld_txtICProductGrossWeight.Location = new System.Drawing.Point(325, 207);
            this.fld_txtICProductGrossWeight.Name = "fld_txtICProductGrossWeight";
            this.fld_txtICProductGrossWeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductGrossWeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductGrossWeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductGrossWeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductGrossWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductGrossWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductGrossWeight.Screen = null;
            this.fld_txtICProductGrossWeight.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductGrossWeight.TabIndex = 15;
            this.fld_txtICProductGrossWeight.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "ICProductName";
            this.bosLabel13.BOSDataSource = "ICProducts";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(252, 211);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(61, 13);
            this.bosLabel13.TabIndex = 14;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Gross weight";
            // 
            // fld_txtICProductNetWeight
            // 
            this.fld_txtICProductNetWeight.BOSComment = "";
            this.fld_txtICProductNetWeight.BOSDataMember = "ICProductNetWeight";
            this.fld_txtICProductNetWeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductNetWeight.BOSDescription = null;
            this.fld_txtICProductNetWeight.BOSError = null;
            this.fld_txtICProductNetWeight.BOSFieldGroup = "";
            this.fld_txtICProductNetWeight.BOSFieldRelation = "";
            this.fld_txtICProductNetWeight.BOSPrivilege = "";
            this.fld_txtICProductNetWeight.BOSPropertyName = "Text";
            this.fld_txtICProductNetWeight.EditValue = "";
            this.fld_txtICProductNetWeight.Location = new System.Drawing.Point(139, 207);
            this.fld_txtICProductNetWeight.Name = "fld_txtICProductNetWeight";
            this.fld_txtICProductNetWeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNetWeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNetWeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNetWeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNetWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNetWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNetWeight.Screen = null;
            this.fld_txtICProductNetWeight.Size = new System.Drawing.Size(80, 20);
            this.fld_txtICProductNetWeight.TabIndex = 13;
            this.fld_txtICProductNetWeight.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "ICProductName";
            this.bosLabel12.BOSDataSource = "ICProducts";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(18, 211);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(51, 13);
            this.bosLabel12.TabIndex = 26;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Net weight";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "ICProductName";
            this.bosLabel8.BOSDataSource = "ICProducts";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(18, 184);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 25;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Thể tích (mm3)";
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
            this.bosLabel6.Location = new System.Drawing.Point(18, 132);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(108, 13);
            this.bosLabel6.TabIndex = 24;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "KT phủ bì DxWxH(mm)";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "ICProductName";
            this.bosLabel7.BOSDataSource = "ICProducts";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(18, 106);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(113, 13);
            this.bosLabel7.TabIndex = 23;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "KT lọt lòng DxWxH(mm)";
            // 
            // fld_tabAccountStockHistory
            // 
            this.fld_tabAccountStockHistory.Controls.Add(this.bosGroupControl1);
            this.fld_tabAccountStockHistory.Controls.Add(this.bosGroupControl6);
            this.fld_tabAccountStockHistory.Controls.Add(this.fld_grcGroupControl4);
            this.fld_tabAccountStockHistory.Controls.Add(this.bosGroupControl7);
            this.fld_tabAccountStockHistory.Name = "fld_tabAccountStockHistory";
            this.fld_tabAccountStockHistory.Size = new System.Drawing.Size(1067, 678);
            this.fld_tabAccountStockHistory.Text = "Tài khoản - Tồn kho - Danh sách thành phẩm";
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
            this.bosGroupControl1.Controls.Add(this.fld_btnAddMoreProduct);
            this.bosGroupControl1.Controls.Add(this.fld_dgcICProductItems);
            this.bosGroupControl1.Controls.Add(this.fld_btnMoveUp);
            this.bosGroupControl1.Controls.Add(this.fld_btnMoveDown);
            this.bosGroupControl1.Location = new System.Drawing.Point(4, 212);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1055, 436);
            this.bosGroupControl1.TabIndex = 3;
            this.bosGroupControl1.Text = "Danh sách thành phẩm sử dụng";
            // 
            // fld_btnAddMoreProduct
            // 
            this.fld_btnAddMoreProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAddMoreProduct.Location = new System.Drawing.Point(968, 25);
            this.fld_btnAddMoreProduct.Name = "fld_btnAddMoreProduct";
            this.ScreenHelper.SetShowHelp(this.fld_btnAddMoreProduct, true);
            this.fld_btnAddMoreProduct.Size = new System.Drawing.Size(82, 23);
            this.fld_btnAddMoreProduct.TabIndex = 2;
            this.fld_btnAddMoreProduct.Text = "Thêm sản phẩm";
            // 
            // fld_dgcICProductItems
            // 
            this.fld_dgcICProductItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductItems.BOSComment = null;
            this.fld_dgcICProductItems.BOSDataMember = null;
            this.fld_dgcICProductItems.BOSDataSource = "ICProductItems";
            this.fld_dgcICProductItems.BOSDescription = null;
            this.fld_dgcICProductItems.BOSError = null;
            this.fld_dgcICProductItems.BOSFieldGroup = null;
            this.fld_dgcICProductItems.BOSFieldRelation = null;
            this.fld_dgcICProductItems.BOSGridType = null;
            this.fld_dgcICProductItems.BOSPrivilege = null;
            this.fld_dgcICProductItems.BOSPropertyName = null;
            this.fld_dgcICProductItems.CommodityType = "";
            this.fld_dgcICProductItems.Location = new System.Drawing.Point(9, 25);
            this.fld_dgcICProductItems.MenuManager = this.screenToolbar;
            this.fld_dgcICProductItems.Name = "fld_dgcICProductItems";
            this.fld_dgcICProductItems.PrintReport = false;
            this.fld_dgcICProductItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductItems, true);
            this.fld_dgcICProductItems.Size = new System.Drawing.Size(953, 405);
            this.fld_dgcICProductItems.TabIndex = 1;
            // 
            // fld_btnMoveUp
            // 
            this.fld_btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMoveUp.BOSComment = null;
            this.fld_btnMoveUp.BOSDataMember = null;
            this.fld_btnMoveUp.BOSDataSource = null;
            this.fld_btnMoveUp.BOSDescription = null;
            this.fld_btnMoveUp.BOSError = null;
            this.fld_btnMoveUp.BOSFieldGroup = null;
            this.fld_btnMoveUp.BOSFieldRelation = null;
            this.fld_btnMoveUp.BOSPrivilege = null;
            this.fld_btnMoveUp.BOSPropertyName = null;
            this.fld_btnMoveUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnMoveUp.ImageOptions.Image")));
            this.fld_btnMoveUp.Location = new System.Drawing.Point(993, 54);
            this.fld_btnMoveUp.Name = "fld_btnMoveUp";
            this.fld_btnMoveUp.Screen = null;
            this.fld_btnMoveUp.Size = new System.Drawing.Size(31, 26);
            this.fld_btnMoveUp.TabIndex = 3;
            this.fld_btnMoveUp.ToolTip = "Di chyển lên";
            // 
            // fld_btnMoveDown
            // 
            this.fld_btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnMoveDown.BOSComment = null;
            this.fld_btnMoveDown.BOSDataMember = null;
            this.fld_btnMoveDown.BOSDataSource = null;
            this.fld_btnMoveDown.BOSDescription = null;
            this.fld_btnMoveDown.BOSError = null;
            this.fld_btnMoveDown.BOSFieldGroup = null;
            this.fld_btnMoveDown.BOSFieldRelation = null;
            this.fld_btnMoveDown.BOSPrivilege = null;
            this.fld_btnMoveDown.BOSPropertyName = null;
            this.fld_btnMoveDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnMoveDown.ImageOptions.Image")));
            this.fld_btnMoveDown.Location = new System.Drawing.Point(993, 86);
            this.fld_btnMoveDown.Name = "fld_btnMoveDown";
            this.fld_btnMoveDown.Screen = null;
            this.fld_btnMoveDown.Size = new System.Drawing.Size(31, 26);
            this.fld_btnMoveDown.TabIndex = 0;
            this.fld_btnMoveDown.ToolTip = "Di chuyển xuống";
            // 
            // bosGroupControl6
            // 
            this.bosGroupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl6.Appearance.Options.UseBackColor = true;
            this.bosGroupControl6.Appearance.Options.UseForeColor = true;
            this.bosGroupControl6.BOSComment = "";
            this.bosGroupControl6.BOSDataMember = "";
            this.bosGroupControl6.BOSDataSource = "";
            this.bosGroupControl6.BOSDescription = null;
            this.bosGroupControl6.BOSError = null;
            this.bosGroupControl6.BOSFieldGroup = "";
            this.bosGroupControl6.BOSFieldRelation = "";
            this.bosGroupControl6.BOSPrivilege = "";
            this.bosGroupControl6.BOSPropertyName = "";
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl6.Controls.Add(this.bosLabel18);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl6.Controls.Add(this.bosLabel31);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl6.Controls.Add(this.bosLabel32);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl6.Controls.Add(this.bosLabel33);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl6.Controls.Add(this.bosLabel34);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl6.Controls.Add(this.bosLabel35);
            this.bosGroupControl6.Controls.Add(this.bosLabel36);
            this.bosGroupControl6.Location = new System.Drawing.Point(1, 3);
            this.bosGroupControl6.Name = "bosGroupControl6";
            this.bosGroupControl6.Screen = null;
            this.bosGroupControl6.Size = new System.Drawing.Size(1058, 108);
            this.bosGroupControl6.TabIndex = 0;
            this.bosGroupControl6.Tag = "";
            this.bosGroupControl6.Text = "Tài khoản";
            // 
            // fld_lkeFK_ICProductTypeAccountConfigID
            // 
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(108, 25);
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 0;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductTypeAccountConfigID_CloseUp);
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
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(14, 28);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(75, 13);
            this.bosLabel18.TabIndex = 347;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Nhóm tài khoản";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(108, 51);
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
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 1;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
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
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(597, 77);
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
            this.fld_lkeFK_ACAccountDiscountID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_ACAccountDiscountID.TabIndex = 6;
            this.fld_lkeFK_ACAccountDiscountID.Tag = "DC";
            // 
            // bosLabel31
            // 
            this.bosLabel31.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel31.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel31.Appearance.Options.UseBackColor = true;
            this.bosLabel31.Appearance.Options.UseForeColor = true;
            this.bosLabel31.BOSComment = "";
            this.bosLabel31.BOSDataMember = "";
            this.bosLabel31.BOSDataSource = "";
            this.bosLabel31.BOSDescription = null;
            this.bosLabel31.BOSError = null;
            this.bosLabel31.BOSFieldGroup = "";
            this.bosLabel31.BOSFieldRelation = "";
            this.bosLabel31.BOSPrivilege = "";
            this.bosLabel31.BOSPropertyName = "";
            this.bosLabel31.Location = new System.Drawing.Point(524, 80);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.bosLabel31.Size = new System.Drawing.Size(67, 13);
            this.bosLabel31.TabIndex = 10;
            this.bosLabel31.Tag = "";
            this.bosLabel31.Text = "TK Chiết Khấu";
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
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(364, 77);
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
            this.fld_lkeFK_ACAccountSaleReturnID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountSaleReturnID.TabIndex = 5;
            this.fld_lkeFK_ACAccountSaleReturnID.Tag = "DC";
            // 
            // bosLabel32
            // 
            this.bosLabel32.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel32.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel32.Appearance.Options.UseBackColor = true;
            this.bosLabel32.Appearance.Options.UseForeColor = true;
            this.bosLabel32.BOSComment = "";
            this.bosLabel32.BOSDataMember = "";
            this.bosLabel32.BOSDataSource = "";
            this.bosLabel32.BOSDescription = null;
            this.bosLabel32.BOSError = null;
            this.bosLabel32.BOSFieldGroup = "";
            this.bosLabel32.BOSFieldRelation = "";
            this.bosLabel32.BOSPrivilege = "";
            this.bosLabel32.BOSPropertyName = "";
            this.bosLabel32.Location = new System.Drawing.Point(262, 80);
            this.bosLabel32.Name = "bosLabel32";
            this.bosLabel32.Screen = null;
            this.bosLabel32.Size = new System.Drawing.Size(90, 13);
            this.bosLabel32.TabIndex = 8;
            this.bosLabel32.Tag = "";
            this.bosLabel32.Text = "TK hàng bán trả lại";
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
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(108, 77);
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
            this.fld_lkeFK_ACAccountRevenueID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountRevenueID.TabIndex = 4;
            this.fld_lkeFK_ACAccountRevenueID.Tag = "DC";
            // 
            // bosLabel33
            // 
            this.bosLabel33.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel33.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel33.Appearance.Options.UseBackColor = true;
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
            this.bosLabel33.Location = new System.Drawing.Point(14, 80);
            this.bosLabel33.Name = "bosLabel33";
            this.bosLabel33.Screen = null;
            this.bosLabel33.Size = new System.Drawing.Size(64, 13);
            this.bosLabel33.TabIndex = 6;
            this.bosLabel33.Tag = "";
            this.bosLabel33.Text = "TK doanh thu";
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
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(597, 51);
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
            this.fld_lkeFK_ACAccountCostPriceID.Size = new System.Drawing.Size(132, 20);
            this.fld_lkeFK_ACAccountCostPriceID.TabIndex = 3;
            this.fld_lkeFK_ACAccountCostPriceID.Tag = "DC";
            // 
            // bosLabel34
            // 
            this.bosLabel34.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel34.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel34.Appearance.Options.UseBackColor = true;
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
            this.bosLabel34.Location = new System.Drawing.Point(524, 54);
            this.bosLabel34.Name = "bosLabel34";
            this.bosLabel34.Screen = null;
            this.bosLabel34.Size = new System.Drawing.Size(50, 13);
            this.bosLabel34.TabIndex = 4;
            this.bosLabel34.Tag = "";
            this.bosLabel34.Text = "TK giá vốn";
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(364, 51);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ACAccountRevenueInternalID.TabIndex = 2;
            this.fld_lkeFK_ACAccountRevenueInternalID.Tag = "DC";
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
            this.bosLabel35.Location = new System.Drawing.Point(262, 54);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(96, 13);
            this.bosLabel35.TabIndex = 2;
            this.bosLabel35.Tag = "";
            this.bosLabel35.Text = "TK doanh thu nội bộ";
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
            this.bosLabel36.Location = new System.Drawing.Point(15, 54);
            this.bosLabel36.Name = "bosLabel36";
            this.bosLabel36.Screen = null;
            this.bosLabel36.Size = new System.Drawing.Size(53, 13);
            this.bosLabel36.TabIndex = 0;
            this.bosLabel36.Tag = "";
            this.bosLabel36.Text = "TK Tồn kho";
            // 
            // bosGroupControl7
            // 
            this.bosGroupControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bosGroupControl7.BOSComment = null;
            this.bosGroupControl7.BOSDataMember = null;
            this.bosGroupControl7.BOSDataSource = null;
            this.bosGroupControl7.BOSDescription = null;
            this.bosGroupControl7.BOSError = null;
            this.bosGroupControl7.BOSFieldGroup = null;
            this.bosGroupControl7.BOSFieldRelation = null;
            this.bosGroupControl7.BOSPrivilege = null;
            this.bosGroupControl7.BOSPropertyName = null;
            this.bosGroupControl7.Controls.Add(this.simpleButton1);
            this.bosGroupControl7.Controls.Add(this.icProductComponentsGridControl1);
            this.bosGroupControl7.Controls.Add(this.bosButton1);
            this.bosGroupControl7.Controls.Add(this.bosButton2);
            this.bosGroupControl7.Location = new System.Drawing.Point(0, 529);
            this.bosGroupControl7.Name = "bosGroupControl7";
            this.bosGroupControl7.Screen = null;
            this.bosGroupControl7.Size = new System.Drawing.Size(888, 147);
            this.bosGroupControl7.TabIndex = 0;
            this.bosGroupControl7.Text = "Danh sách thành phần";
            this.bosGroupControl7.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(801, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.ScreenHelper.SetShowHelp(this.simpleButton1, true);
            this.simpleButton1.Size = new System.Drawing.Size(82, 23);
            this.simpleButton1.TabIndex = 353;
            this.simpleButton1.Text = "Thêm sản phẩm";
            // 
            // icProductComponentsGridControl1
            // 
            this.icProductComponentsGridControl1.BOSComment = null;
            this.icProductComponentsGridControl1.BOSDataMember = null;
            this.icProductComponentsGridControl1.BOSDataSource = "ICProductItems";
            this.icProductComponentsGridControl1.BOSDescription = null;
            this.icProductComponentsGridControl1.BOSError = null;
            this.icProductComponentsGridControl1.BOSFieldGroup = null;
            this.icProductComponentsGridControl1.BOSFieldRelation = null;
            this.icProductComponentsGridControl1.BOSGridType = null;
            this.icProductComponentsGridControl1.BOSPrivilege = null;
            this.icProductComponentsGridControl1.BOSPropertyName = null;
            this.icProductComponentsGridControl1.CommodityType = "";
            this.icProductComponentsGridControl1.Location = new System.Drawing.Point(9, 25);
            this.icProductComponentsGridControl1.MenuManager = this.screenToolbar;
            this.icProductComponentsGridControl1.Name = "icProductComponentsGridControl1";
            this.icProductComponentsGridControl1.PrintReport = false;
            this.icProductComponentsGridControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.icProductComponentsGridControl1, true);
            this.icProductComponentsGridControl1.Size = new System.Drawing.Size(782, 223);
            this.icProductComponentsGridControl1.TabIndex = 30;
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bosButton1.ImageOptions.Image")));
            this.bosButton1.Location = new System.Drawing.Point(832, 69);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(31, 26);
            this.bosButton1.TabIndex = 27;
            this.bosButton1.ToolTip = "Di chyển lên";
            // 
            // bosButton2
            // 
            this.bosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bosButton2.ImageOptions.Image")));
            this.bosButton2.Location = new System.Drawing.Point(832, 101);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(31, 26);
            this.bosButton2.TabIndex = 28;
            this.bosButton2.ToolTip = "Di chuyển xuống";
            // 
            // fld_tabPackagingNorm
            // 
            this.fld_tabPackagingNorm.Controls.Add(this.fld_dgcICPackagingNormItems);
            this.fld_tabPackagingNorm.Name = "fld_tabPackagingNorm";
            this.fld_tabPackagingNorm.Size = new System.Drawing.Size(1067, 678);
            this.fld_tabPackagingNorm.Text = "Định mức PLDG";
            // 
            // fld_dgcICPackagingNormItems
            // 
            this.fld_dgcICPackagingNormItems.BOSComment = null;
            this.fld_dgcICPackagingNormItems.BOSDataMember = null;
            this.fld_dgcICPackagingNormItems.BOSDataSource = "ICPackagingNormItems";
            this.fld_dgcICPackagingNormItems.BOSDescription = null;
            this.fld_dgcICPackagingNormItems.BOSError = null;
            this.fld_dgcICPackagingNormItems.BOSFieldGroup = null;
            this.fld_dgcICPackagingNormItems.BOSFieldRelation = null;
            this.fld_dgcICPackagingNormItems.BOSGridType = null;
            this.fld_dgcICPackagingNormItems.BOSPrivilege = null;
            this.fld_dgcICPackagingNormItems.BOSPropertyName = null;
            this.fld_dgcICPackagingNormItems.CommodityType = "";
            this.fld_dgcICPackagingNormItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICPackagingNormItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICPackagingNormItems.MenuManager = this.screenToolbar;
            this.fld_dgcICPackagingNormItems.Name = "fld_dgcICPackagingNormItems";
            this.fld_dgcICPackagingNormItems.PrintReport = false;
            this.fld_dgcICPackagingNormItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICPackagingNormItems, true);
            this.fld_dgcICPackagingNormItems.Size = new System.Drawing.Size(1067, 678);
            this.fld_dgcICPackagingNormItems.TabIndex = 2;
            // 
            // fld_tabProductMeasureUnits
            // 
            this.fld_tabProductMeasureUnits.Controls.Add(this.fld_btnSaveProductMeasureUnit);
            this.fld_tabProductMeasureUnits.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.fld_tabProductMeasureUnits.Name = "fld_tabProductMeasureUnits";
            this.fld_tabProductMeasureUnits.Size = new System.Drawing.Size(1067, 678);
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
            this.fld_btnSaveProductMeasureUnit.Location = new System.Drawing.Point(991, 646);
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
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(1061, 637);
            this.fld_dgcICProductMeasureUnits.TabIndex = 109;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICProductTolenrances);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1067, 678);
            this.xtraTabPage1.Text = "Dung sai";
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
            this.fld_dgcICProductTolenrances.Size = new System.Drawing.Size(1067, 678);
            this.fld_dgcICProductTolenrances.TabIndex = 11;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DMPKP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1083, 710);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPKP100.IconOptions.Icon")));
            this.Name = "DMPKP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkShowHistoryBranchPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).EndInit();
            this.fld_grcGroupControl4.ResumeLayout(false);
            this.fld_grcGroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProducts)).EndInit();
            this.fld_tabProducts.ResumeLayout(false);
            this.fld_tabInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSizeAndSpecifiCations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBoxUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBoxArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductOverallDimensionWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInsideDimensionWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_ICProdAttPackingMaterialSpecialityID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductGrossWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNetWeight.Properties)).EndInit();
            this.fld_tabAccountStockHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).EndInit();
            this.bosGroupControl6.ResumeLayout(false);
            this.bosGroupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl7)).EndInit();
            this.bosGroupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icProductComponentsGridControl1)).EndInit();
            this.fld_tabPackagingNorm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICPackagingNormItems)).EndInit();
            this.fld_tabProductMeasureUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPrice;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierNumber;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenBranchPrice;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductAttributeNo;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPurchasePrice;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkShowHistoryBranchPrice;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICProductNoOfOldSys;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtICProductBarCode;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_txtFK_ICProdAttPackingMaterialSpecialityID;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtICProductInsideDimensionHeight;
        private BOSComponent.BOSTextBox fld_txtICProductInsideDimensionLength;
        private BOSComponent.BOSTextBox fld_txtICProductInsideDimensionWidth;
        private BOSComponent.BOSTextBox fld_txtICProductOverallDimensionHeight;
        private BOSComponent.BOSTextBox fld_txtICProductOverallDimensionLength;
        private BOSComponent.BOSTextBox fld_txtICProductOverallDimensionWidth;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddMoreProduct;
        private BOSERP.Modules.PackagingProduct.ICProductComponentsGridControl fld_dgcICProductItems;
        private BOSComponent.BOSButton fld_btnMoveUp;
        private BOSComponent.BOSButton fld_btnMoveDown;
        private BOSComponent.BOSTextBox fld_txtICProductGrossWeight;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSTextBox fld_txtICProductNetWeight;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSTabControl fld_tabProducts;
        private DevExpress.XtraTab.XtraTabPage fld_tabInfomation;
        private DevExpress.XtraTab.XtraTabPage fld_tabAccountStockHistory;
        private BOSComponent.BOSGroupControl bosGroupControl6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountDiscountID;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleReturnID;
        private BOSComponent.BOSLabel bosLabel32;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueID;
        private BOSComponent.BOSLabel bosLabel33;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountCostPriceID;
        private BOSComponent.BOSLabel bosLabel34;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueInternalID;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel36;
        private BOSComponent.BOSGroupControl bosGroupControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private ICProductComponentsGridControl icProductComponentsGridControl1;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPurchaseType;
        private BOSComponent.BOSTextBox fld_txtICProductLeadTime;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSButton fld_btnUpdateInside;
        private BOSComponent.BOSButton fld_btnUpdateOverroll;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductBoxArea;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSTextBox fld_txtICProductBoxUnitPrice;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel20;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackagingNorm;
        private ICPackagingNormItemGridControl fld_dgcICPackagingNormItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductMeasureUnits;
        private BOSComponent.BOSButton fld_btnSaveProductMeasureUnit;
        private BOSERP.Modules.PackagingProduct.ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private BOSComponent.BOSLookupEdit fld_lkeICProductUses;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSButtonEdit fld_bedICProductAttribute;
        private BOSComponent.BOSTextBox fld_txtICProductSizeAndSpecifiCations;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox fld_txtICProductCapacity;
        private BOSComponent.BOSTextBox fld_txtICProductStorageDay;
        private BOSComponent.BOSLabel bosLabel21;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSButton fld_btnAddProductImageDefault;
        private OpenFileDialog openFileDialog1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private ICProductTolenrancesGridControl fld_dgcICProductTolenrances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOriginOfProduct;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICModelID;
        private BOSComponent.BOSLabel bosLabel25;
    }
}
