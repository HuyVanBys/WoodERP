using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaintProduct.UI
{
	/// <summary>
	/// Summary description for DMPAP100
	/// </summary>
	partial class DMPAP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPAP100));
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
            this.fld_txtICProductExpiryDay = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_cbbICProductStorageConditionAttribute = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel19111 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductOriginOfProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICModelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_btnAddProductImageDefault = new BOSComponent.BOSButton(this.components);
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductUses = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtICProductStorageDay = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductBarCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNoOfOldSys = new BOSComponent.BOSTextBox(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductAttributeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductStockMax = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
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
            this.xtraTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductPurchaseType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductLeadTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
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
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProductMeasureUnit = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.PaintProduct.ICProductMeasureUnitsGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTolenrances = new BOSERP.Modules.PaintProduct.ICProductTolenrancesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_kleICProductIdentifyColor = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductExpiryDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbICProductStorageConditionAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).BeginInit();
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(9, 32);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel15.TabIndex = 7;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã sản phẩm";
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
            this.fld_lblLabel21.Location = new System.Drawing.Point(9, 159);
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(10, 252);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 20;
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
            this.fld_Lablel1.Location = new System.Drawing.Point(16, 30);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(82, 13);
            this.fld_Lablel1.TabIndex = 182;
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
            this.fld_txtICProductStockMin.Location = new System.Drawing.Point(103, 27);
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
            this.fld_txtICProductStockMin.TabIndex = 0;
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
            this.fld_medICProductDesc.Location = new System.Drawing.Point(110, 156);
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
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(92, 61);
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
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductSupplierPrice.TabIndex = 1;
            this.fld_txtICProductSupplierPrice.Tag = "DC";
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductExpiryDay);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl5.Controls.Add(this.fld_cbbICProductStorageConditionAttribute);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel19111);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOriginOfProduct);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_GECountryID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel28);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ICModelID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel29);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddProductImageDefault);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductUses);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductStorageDay);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductBarCode);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel13);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNoOfOldSys);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductAttributeNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductSupplierNumber);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ACAccountID);
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
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 563);
            this.fld_grcGroupControl5.TabIndex = 1;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_txtICProductExpiryDay
            // 
            this.fld_txtICProductExpiryDay.BOSComment = "";
            this.fld_txtICProductExpiryDay.BOSDataMember = "ICProductExpiryDay";
            this.fld_txtICProductExpiryDay.BOSDataSource = "ICProducts";
            this.fld_txtICProductExpiryDay.BOSDescription = null;
            this.fld_txtICProductExpiryDay.BOSError = null;
            this.fld_txtICProductExpiryDay.BOSFieldGroup = "";
            this.fld_txtICProductExpiryDay.BOSFieldRelation = "";
            this.fld_txtICProductExpiryDay.BOSPrivilege = "";
            this.fld_txtICProductExpiryDay.BOSPropertyName = "Text";
            this.fld_txtICProductExpiryDay.EditValue = "0.00";
            this.fld_txtICProductExpiryDay.Location = new System.Drawing.Point(109, 530);
            this.fld_txtICProductExpiryDay.Name = "fld_txtICProductExpiryDay";
            this.fld_txtICProductExpiryDay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductExpiryDay.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductExpiryDay.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductExpiryDay.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductExpiryDay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductExpiryDay.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductExpiryDay.Properties.MaskSettings.Set("mask", "n0");
            this.fld_txtICProductExpiryDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductExpiryDay.Screen = null;
            this.fld_txtICProductExpiryDay.Size = new System.Drawing.Size(156, 20);
            this.fld_txtICProductExpiryDay.TabIndex = 498;
            this.fld_txtICProductExpiryDay.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(9, 533);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(96, 13);
            this.bosLabel18.TabIndex = 497;
            this.bosLabel18.Text = "Hạn sử dụng (Days)";
            // 
            // fld_cbbICProductStorageConditionAttribute
            // 
            this.fld_cbbICProductStorageConditionAttribute.Location = new System.Drawing.Point(110, 504);
            this.fld_cbbICProductStorageConditionAttribute.Name = "fld_cbbICProductStorageConditionAttribute";
            this.fld_cbbICProductStorageConditionAttribute.Properties.AllowMultiSelect = true;
            this.fld_cbbICProductStorageConditionAttribute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbbICProductStorageConditionAttribute.Properties.DropDownRows = 20;
            this.fld_cbbICProductStorageConditionAttribute.Size = new System.Drawing.Size(297, 20);
            this.fld_cbbICProductStorageConditionAttribute.TabIndex = 495;
            // 
            // bosLabel19111
            // 
            this.bosLabel19111.BOSComment = null;
            this.bosLabel19111.BOSDataMember = null;
            this.bosLabel19111.BOSDataSource = null;
            this.bosLabel19111.BOSDescription = null;
            this.bosLabel19111.BOSError = null;
            this.bosLabel19111.BOSFieldGroup = null;
            this.bosLabel19111.BOSFieldRelation = null;
            this.bosLabel19111.BOSPrivilege = null;
            this.bosLabel19111.BOSPropertyName = null;
            this.bosLabel19111.Location = new System.Drawing.Point(9, 507);
            this.bosLabel19111.Name = "bosLabel19111";
            this.bosLabel19111.Screen = null;
            this.bosLabel19111.Size = new System.Drawing.Size(92, 13);
            this.bosLabel19111.TabIndex = 494;
            this.bosLabel19111.Text = "Điều kiện bảo quản";
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
            this.fld_lkeICProductOriginOfProduct.Location = new System.Drawing.Point(110, 427);
            this.fld_lkeICProductOriginOfProduct.MenuManager = this.screenToolbar;
            this.fld_lkeICProductOriginOfProduct.Name = "fld_lkeICProductOriginOfProduct";
            this.fld_lkeICProductOriginOfProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductOriginOfProduct.Properties.ColumnName = null;
            this.fld_lkeICProductOriginOfProduct.Properties.NullText = "";
            this.fld_lkeICProductOriginOfProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductOriginOfProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductOriginOfProduct, true);
            this.fld_lkeICProductOriginOfProduct.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductOriginOfProduct.TabIndex = 401;
            this.fld_lkeICProductOriginOfProduct.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(10, 430);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(66, 13);
            this.bosLabel12.TabIndex = 402;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Nguồn gốc SP";
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
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(110, 453);
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
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 399;
            this.fld_lkeFK_GECountryID.Tag = "DC";
            // 
            // bosLabel28
            // 
            this.bosLabel28.BOSComment = null;
            this.bosLabel28.BOSDataMember = null;
            this.bosLabel28.BOSDataSource = null;
            this.bosLabel28.BOSDescription = null;
            this.bosLabel28.BOSError = null;
            this.bosLabel28.BOSFieldGroup = null;
            this.bosLabel28.BOSFieldRelation = null;
            this.bosLabel28.BOSPrivilege = null;
            this.bosLabel28.BOSPropertyName = null;
            this.bosLabel28.Location = new System.Drawing.Point(10, 456);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(38, 13);
            this.bosLabel28.TabIndex = 400;
            this.bosLabel28.Text = "Xuất xứ";
            // 
            // fld_lkeFK_ICModelID
            // 
            this.fld_lkeFK_ICModelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICModelID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ICModelID.Location = new System.Drawing.Point(110, 479);
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
            this.fld_lkeFK_ICModelID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_ICModelID.TabIndex = 397;
            this.fld_lkeFK_ICModelID.Tag = "DC";
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
            this.bosLabel29.Location = new System.Drawing.Point(10, 482);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(60, 13);
            this.bosLabel29.TabIndex = 398;
            this.bosLabel29.Text = "Thương hiệu";
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(282, 201);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_ptbICProductPicture.TabIndex = 372;
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
            this.fld_btnAddProductImageDefault.Location = new System.Drawing.Point(283, 314);
            this.fld_btnAddProductImageDefault.Name = "fld_btnAddProductImageDefault";
            this.fld_btnAddProductImageDefault.Screen = null;
            this.fld_btnAddProductImageDefault.Size = new System.Drawing.Size(125, 21);
            this.fld_btnAddProductImageDefault.TabIndex = 18;
            this.fld_btnAddProductImageDefault.Tag = "";
            this.fld_btnAddProductImageDefault.Text = "Chọn ảnh chính";
            this.fld_btnAddProductImageDefault.Click += new System.EventHandler(this.fld_btnAddProductImageDefault_Click);
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
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(284, 376);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 16;
            this.fld_chkICProductIsShowWeb.Tag = "DC";
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
            this.fld_lkeICProductUses.Location = new System.Drawing.Point(110, 275);
            this.fld_lkeICProductUses.MenuManager = this.screenToolbar;
            this.fld_lkeICProductUses.Name = "fld_lkeICProductUses";
            this.fld_lkeICProductUses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductUses.Properties.ColumnName = null;
            this.fld_lkeICProductUses.Properties.NullText = "";
            this.fld_lkeICProductUses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductUses.Screen = null;
            this.fld_lkeICProductUses.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductUses.TabIndex = 9;
            this.fld_lkeICProductUses.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(10, 278);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(88, 13);
            this.bosLabel10.TabIndex = 368;
            this.bosLabel10.Text = "Hình thức sử dụng";
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
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(284, 350);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 15;
            this.fld_chkICProductPromotionCheck.Tag = "DC";
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
            this.fld_txtICProductStorageDay.Location = new System.Drawing.Point(110, 401);
            this.fld_txtICProductStorageDay.Name = "fld_txtICProductStorageDay";
            this.fld_txtICProductStorageDay.Screen = null;
            this.fld_txtICProductStorageDay.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductStorageDay.TabIndex = 14;
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
            this.fld_txtICProductBarCode.Location = new System.Drawing.Point(110, 349);
            this.fld_txtICProductBarCode.MenuManager = this.screenToolbar;
            this.fld_txtICProductBarCode.Name = "fld_txtICProductBarCode";
            this.fld_txtICProductBarCode.Screen = null;
            this.fld_txtICProductBarCode.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductBarCode.TabIndex = 12;
            this.fld_txtICProductBarCode.Tag = "DC";
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
            this.fld_lblLabel13.Location = new System.Drawing.Point(10, 352);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel13.TabIndex = 345;
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
            this.bosLabel5.Location = new System.Drawing.Point(9, 58);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 343;
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
            this.fld_txtICProductNoOfOldSys.Location = new System.Drawing.Point(110, 55);
            this.fld_txtICProductNoOfOldSys.Name = "fld_txtICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNoOfOldSys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNoOfOldSys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNoOfOldSys, true);
            this.fld_txtICProductNoOfOldSys.Size = new System.Drawing.Size(155, 20);
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
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(110, 249);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(155, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 8;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
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
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(284, 402);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 17;
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(110, 301);
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
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 10;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(109, 325);
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
            this.bosLabel3.Location = new System.Drawing.Point(9, 109);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(67, 13);
            this.bosLabel3.TabIndex = 339;
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 84);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(89, 13);
            this.bosLabel1.TabIndex = 339;
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
            this.fld_txtICProductName.Location = new System.Drawing.Point(110, 132);
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
            this.fld_txtICProductAttributeNo.Location = new System.Drawing.Point(110, 106);
            this.fld_txtICProductAttributeNo.Name = "fld_txtICProductAttributeNo";
            this.fld_txtICProductAttributeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductAttributeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductAttributeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductAttributeNo.Screen = null;
            this.fld_txtICProductAttributeNo.Size = new System.Drawing.Size(155, 20);
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
            this.fld_txtICProductSupplierNumber.Location = new System.Drawing.Point(110, 81);
            this.fld_txtICProductSupplierNumber.Name = "fld_txtICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierNumber.Screen = null;
            this.fld_txtICProductSupplierNumber.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductSupplierNumber.TabIndex = 2;
            this.fld_txtICProductSupplierNumber.Tag = "DC";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(110, 375);
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
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 13;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = false;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "";
            this.fld_lkeICProductType.BOSDataSource = "";
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
            this.fld_lkeICProductType.Location = new System.Drawing.Point(110, 223);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.fld_lkeICProductType.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductType.TabIndex = 7;
            this.fld_lkeICProductType.Tag = "DC";
            this.fld_lkeICProductType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductType_CloseUp);
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(110, 199);
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(10, 226);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel17.TabIndex = 334;
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
            this.bosLabel2.Location = new System.Drawing.Point(9, 135);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên sản phẩm";
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(10, 302);
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
            this.fld_txtICProductNo.Location = new System.Drawing.Point(110, 29);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(10, 404);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(77, 13);
            this.bosLabel9.TabIndex = 332;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Số ngày lưu kho";
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
            this.bosLabel4.Location = new System.Drawing.Point(10, 378);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(46, 13);
            this.bosLabel4.TabIndex = 332;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tài khoản";
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
            this.fld_txtICProductStockMax.Location = new System.Drawing.Point(103, 53);
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
            this.fld_txtICProductStockMax.TabIndex = 3;
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(16, 56);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel2.TabIndex = 277;
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
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(92, 87);
            this.fld_lkeFK_GEVATID.Name = "fld_lkeFK_GEVATID";
            this.fld_lkeFK_GEVATID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEVATID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEVATID.Properties.ColumnName = null;
            this.fld_lkeFK_GEVATID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATNo", "Mã thuế"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATPercentValue", "Mức thuế")});
            this.fld_lkeFK_GEVATID.Properties.DisplayMember = "GEVATPercentValue";
            this.fld_lkeFK_GEVATID.Properties.NullText = "";
            this.fld_lkeFK_GEVATID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEVATID.Properties.ValueMember = "GEVATID";
            this.fld_lkeFK_GEVATID.Screen = null;
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 2;
            this.fld_lkeFK_GEVATID.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
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
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel27);
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
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(434, 204);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(453, 362);
            this.fld_grcGroupControl1.TabIndex = 1;
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
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(92, 165);
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(92, 139);
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
            this.bosLabel27.Location = new System.Drawing.Point(18, 142);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(50, 13);
            this.bosLabel27.TabIndex = 349;
            this.bosLabel27.Text = "PP tính giá";
            // 
            // fld_lnkShowHistoryBranchPrice
            // 
            this.fld_lnkShowHistoryBranchPrice.EditValue = "Lịch sử giá bán theo chi nhánh";
            this.fld_lnkShowHistoryBranchPrice.Location = new System.Drawing.Point(239, 84);
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
            this.fld_lnkEditPurchasePrice.Location = new System.Drawing.Point(239, 60);
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
            this.fld_lnkOpenBranchPrice.Location = new System.Drawing.Point(316, 38);
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(92, 113);
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
            this.fld_lnkEditPrice.Location = new System.Drawing.Point(239, 38);
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
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(92, 35);
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
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(125, 20);
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
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(3, 687);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(884, 98);
            this.fld_grcGroupControl4.TabIndex = 3;
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(261, 30);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel12.TabIndex = 313;
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(504, 30);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel26.TabIndex = 315;
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(263, 56);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel27.TabIndex = 316;
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
            this.fld_lblLabel29.Location = new System.Drawing.Point(506, 56);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel29.TabIndex = 317;
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
            this.fld_dteICProductStockMinDateFrom.Location = new System.Drawing.Point(348, 27);
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
            this.fld_dteICProductStockMinDateFrom.TabIndex = 1;
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
            this.fld_dteICProductStockMinDateTo.Location = new System.Drawing.Point(548, 27);
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
            this.fld_dteICProductStockMinDateTo.TabIndex = 2;
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
            this.fld_dteICProductStockMaxDateFrom.Location = new System.Drawing.Point(348, 53);
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
            this.fld_dteICProductStockMaxDateFrom.TabIndex = 4;
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
            this.fld_dteICProductStockMaxDateTo.Location = new System.Drawing.Point(548, 53);
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
            this.fld_dteICProductStockMaxDateTo.TabIndex = 5;
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
            this.fld_lblLabel11.TabIndex = 0;
            this.fld_lblLabel11.Tag = "";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.BOSComment = null;
            this.xtraTabControl1.BOSDataMember = null;
            this.xtraTabControl1.BOSDataSource = null;
            this.xtraTabControl1.BOSDescription = null;
            this.xtraTabControl1.BOSError = null;
            this.xtraTabControl1.BOSFieldGroup = null;
            this.xtraTabControl1.BOSFieldRelation = null;
            this.xtraTabControl1.BOSPrivilege = null;
            this.xtraTabControl1.BOSPropertyName = null;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Screen = null;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1091, 914);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosGroupControl2);
            this.xtraTabPage1.Controls.Add(this.fld_grcGroupControl5);
            this.xtraTabPage1.Controls.Add(this.bosGroupControl1);
            this.xtraTabPage1.Controls.Add(this.fld_grcGroupControl4);
            this.xtraTabPage1.Controls.Add(this.fld_grcGroupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1089, 889);
            this.xtraTabPage1.Text = "Thông tin";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.bosLabel19);
            this.bosGroupControl2.Controls.Add(this.fld_kleICProductIdentifyColor);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductPurchaseType);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLeadTime);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductAttribute);
            this.bosGroupControl2.Controls.Add(this.bosLabel8);
            this.bosGroupControl2.Location = new System.Drawing.Point(434, 4);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(453, 192);
            this.bosGroupControl2.TabIndex = 4;
            this.bosGroupControl2.Text = "Thuộc tính";
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
            this.fld_lkeICProductPurchaseType.Location = new System.Drawing.Point(161, 106);
            this.fld_lkeICProductPurchaseType.Name = "fld_lkeICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPurchaseType.Properties.ColumnName = null;
            this.fld_lkeICProductPurchaseType.Screen = null;
            this.fld_lkeICProductPurchaseType.Size = new System.Drawing.Size(272, 20);
            this.fld_lkeICProductPurchaseType.TabIndex = 2;
            this.fld_lkeICProductPurchaseType.Tag = "DC";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = null;
            this.fld_lblLabel8.BOSDataMember = null;
            this.fld_lblLabel8.BOSDataSource = null;
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = null;
            this.fld_lblLabel8.BOSFieldRelation = null;
            this.fld_lblLabel8.BOSPrivilege = null;
            this.fld_lblLabel8.BOSPropertyName = null;
            this.fld_lblLabel8.Location = new System.Drawing.Point(18, 57);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel8.TabIndex = 0;
            this.fld_lblLabel8.Text = "Thuộc tính khác";
            // 
            // fld_txtICProductLeadTime
            // 
            this.fld_txtICProductLeadTime.BOSComment = null;
            this.fld_txtICProductLeadTime.BOSDataMember = "ICProductLeadTime";
            this.fld_txtICProductLeadTime.BOSDataSource = "ICProducts";
            this.fld_txtICProductLeadTime.BOSDescription = null;
            this.fld_txtICProductLeadTime.BOSError = null;
            this.fld_txtICProductLeadTime.BOSFieldGroup = null;
            this.fld_txtICProductLeadTime.BOSFieldRelation = null;
            this.fld_txtICProductLeadTime.BOSPrivilege = null;
            this.fld_txtICProductLeadTime.BOSPropertyName = "Text";
            this.fld_txtICProductLeadTime.Location = new System.Drawing.Point(161, 80);
            this.fld_txtICProductLeadTime.Name = "fld_txtICProductLeadTime";
            this.fld_txtICProductLeadTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLeadTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLeadTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductLeadTime.Screen = null;
            this.fld_txtICProductLeadTime.Size = new System.Drawing.Size(272, 20);
            this.fld_txtICProductLeadTime.TabIndex = 1;
            this.fld_txtICProductLeadTime.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(18, 109);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(69, 13);
            this.bosLabel7.TabIndex = 4;
            this.bosLabel7.Text = "Loại mua hàng";
            // 
            // fld_bedICProductAttribute
            // 
            this.fld_bedICProductAttribute.BOSComment = null;
            this.fld_bedICProductAttribute.BOSDataMember = "ICProductAttribute";
            this.fld_bedICProductAttribute.BOSDataSource = "ICProducts";
            this.fld_bedICProductAttribute.BOSDescription = null;
            this.fld_bedICProductAttribute.BOSError = null;
            this.fld_bedICProductAttribute.BOSFieldGroup = null;
            this.fld_bedICProductAttribute.BOSFieldRelation = null;
            this.fld_bedICProductAttribute.BOSPrivilege = null;
            this.fld_bedICProductAttribute.BOSPropertyName = "Text";
            this.fld_bedICProductAttribute.EditValue = "<ButtonEdit>";
            this.fld_bedICProductAttribute.Location = new System.Drawing.Point(161, 54);
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
            this.fld_bedICProductAttribute.Size = new System.Drawing.Size(272, 20);
            this.fld_bedICProductAttribute.TabIndex = 0;
            this.fld_bedICProductAttribute.Tag = "DC";
            this.fld_bedICProductAttribute.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedICProductAttribute_ButtonClick);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(18, 83);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(117, 13);
            this.bosLabel8.TabIndex = 2;
            this.bosLabel8.Text = "T.gian hoàn thành (day)";
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl1.Controls.Add(this.bosLabel11);
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
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 572);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(884, 109);
            this.bosGroupControl1.TabIndex = 2;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Tài khoản";
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(103, 28);
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
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
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
            this.bosLabel11.Location = new System.Drawing.Point(9, 31);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(75, 13);
            this.bosLabel11.TabIndex = 0;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Nhóm tài khoản";
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
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(592, 80);
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
            this.bosLabel17.Location = new System.Drawing.Point(519, 83);
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
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(359, 80);
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
            this.bosLabel16.Location = new System.Drawing.Point(257, 83);
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
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(103, 80);
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
            this.bosLabel15.Location = new System.Drawing.Point(9, 83);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(64, 13);
            this.bosLabel15.TabIndex = 338;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "TK doanh thu";
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
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(592, 54);
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
            this.bosLabel14.Location = new System.Drawing.Point(519, 57);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(359, 54);
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
            this.bosLabel13.Location = new System.Drawing.Point(257, 57);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(96, 13);
            this.bosLabel13.TabIndex = 334;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "TK doanh thu nội bộ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACAccountID";
            this.bosLookupEdit1.BOSDataSource = "ICProducts";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(103, 54);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.bosLookupEdit1.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(125, 20);
            this.bosLookupEdit1.TabIndex = 1;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(10, 57);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(53, 13);
            this.bosLabel6.TabIndex = 332;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "TK Tồn kho";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnSaveProductMeasureUnit);
            this.xtraTabPage2.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1075, 882);
            this.xtraTabPage2.Text = "ĐVT quy đổi";
            // 
            // fld_btnSaveProductMeasureUnit
            // 
            this.fld_btnSaveProductMeasureUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnSaveProductMeasureUnit.BOSComment = null;
            this.fld_btnSaveProductMeasureUnit.BOSDataMember = null;
            this.fld_btnSaveProductMeasureUnit.BOSDataSource = null;
            this.fld_btnSaveProductMeasureUnit.BOSDescription = null;
            this.fld_btnSaveProductMeasureUnit.BOSError = null;
            this.fld_btnSaveProductMeasureUnit.BOSFieldGroup = null;
            this.fld_btnSaveProductMeasureUnit.BOSFieldRelation = null;
            this.fld_btnSaveProductMeasureUnit.BOSPrivilege = null;
            this.fld_btnSaveProductMeasureUnit.BOSPropertyName = null;
            this.fld_btnSaveProductMeasureUnit.Location = new System.Drawing.Point(818, 853);
            this.fld_btnSaveProductMeasureUnit.Name = "fld_btnSaveProductMeasureUnit";
            this.fld_btnSaveProductMeasureUnit.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveProductMeasureUnit, true);
            this.fld_btnSaveProductMeasureUnit.Size = new System.Drawing.Size(69, 25);
            this.fld_btnSaveProductMeasureUnit.TabIndex = 112;
            this.fld_btnSaveProductMeasureUnit.Text = "Lưu";
            this.fld_btnSaveProductMeasureUnit.Click += new System.EventHandler(this.fld_btnSaveProductMeasureUnit_Click);
            // 
            // fld_dgcICProductMeasureUnits
            // 
            this.fld_dgcICProductMeasureUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.fld_dgcICProductMeasureUnits.Location = new System.Drawing.Point(7, 3);
            this.fld_dgcICProductMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMeasureUnits.Name = "fld_dgcICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.PrintReport = false;
            this.fld_dgcICProductMeasureUnits.Screen = null;
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(880, 844);
            this.fld_dgcICProductMeasureUnits.TabIndex = 5;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICProductTolenrances);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1075, 882);
            this.xtraTabPage3.Text = "Dung sai";
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
            this.fld_dgcICProductTolenrances.Size = new System.Drawing.Size(1075, 882);
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
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(18, 31);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(41, 13);
            this.bosLabel19.TabIndex = 453;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Màu sơn";
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
            this.fld_kleICProductIdentifyColor.Location = new System.Drawing.Point(161, 28);
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
            this.fld_kleICProductIdentifyColor.TabIndex = 452;
            this.fld_kleICProductIdentifyColor.Tag = "DC";
            // 
            // DMPAP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1125, 931);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.fld_lblLabel11);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPAP100.IconOptions.Icon")));
            this.Name = "DMPAP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductExpiryDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbICProductStorageConditionAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_kleICProductIdentifyColor.Properties)).EndInit();
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
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenBranchPrice;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductAttributeNo;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPurchasePrice;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkShowHistoryBranchPrice;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSTextBox fld_txtICProductNoOfOldSys;
        private BOSComponent.BOSTextBox fld_txtICProductBarCode;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
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
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeICProductUses;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private BOSComponent.BOSTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSERP.Modules.PaintProduct.ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private BOSComponent.BOSButton fld_btnSaveProductMeasureUnit;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPurchaseType;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtICProductLeadTime;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButtonEdit fld_bedICProductAttribute;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private BOSComponent.BOSTextBox fld_txtICProductStorageDay;
        private BOSComponent.BOSLabel bosLabel9;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSButton fld_btnAddProductImageDefault;
        private OpenFileDialog openFileDialog1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ICProductTolenrancesGridControl fld_dgcICProductTolenrances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOriginOfProduct;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICModelID;
        private BOSComponent.BOSLabel bosLabel29;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_cbbICProductStorageConditionAttribute;
        private BOSComponent.BOSLabel bosLabel19111;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtICProductExpiryDay;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_kleICProductIdentifyColor;
    }
}
