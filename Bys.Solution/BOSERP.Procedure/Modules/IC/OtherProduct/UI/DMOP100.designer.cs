using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OtherProduct.UI
{
    /// <summary>
    /// Summary description for DMOP100
    /// </summary>
    partial class DMOP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMOP100));
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
            this.fld_txtICProductNumberSign = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_btnAddProductImageDefault = new BOSComponent.BOSButton(this.components);
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductUses = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductOriginOfProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductTargetType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
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
            this.fld_lkeICProductUsingMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
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
            this.fld_xTabMain = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel31 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICProductPurchaseType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel35 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductDepth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductDiameter = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductRadius = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductThickness = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductTrademark = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.OtherProduct.ICProductMeasureUnitsGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountDiscountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountCostPriceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueInternalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnSaveProductMeasureUnit = new BOSComponent.BOSButton(this.components);
            this.fld_xTabOperation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductOperations = new BOSERP.Modules.OtherProduct.ICProductOperationsGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xTabMachine = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductMachines = new BOSERP.Modules.OtherProduct.ICProductMachinesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_xTabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductSemis = new BOSERP.Modules.OtherProduct.ICProductSemisGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTolenrances = new BOSERP.Modules.OtherProduct.ICProductTolenrancesGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNumberSign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTargetType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUsingMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_xTabMain)).BeginInit();
            this.fld_xTabMain.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductRadius.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTrademark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            this.fld_xTabOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            this.fld_xTabMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_xTabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(9, 276);
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
            this.fld_Lablel1.Location = new System.Drawing.Point(9, 28);
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
            this.fld_txtICProductStockMin.Location = new System.Drawing.Point(110, 25);
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
            this.fld_txtICProductStockMin.Size = new System.Drawing.Size(155, 20);
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNumberSign);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel28);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_GECountryID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel26);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddProductImageDefault);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductUses);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel21);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOriginOfProduct);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel22);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductTargetType);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox1);
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
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(4, 2);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 508);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_txtICProductNumberSign
            // 
            this.fld_txtICProductNumberSign.BOSComment = null;
            this.fld_txtICProductNumberSign.BOSDataMember = "ICProductNumberSign";
            this.fld_txtICProductNumberSign.BOSDataSource = "ICProducts";
            this.fld_txtICProductNumberSign.BOSDescription = null;
            this.fld_txtICProductNumberSign.BOSError = null;
            this.fld_txtICProductNumberSign.BOSFieldGroup = null;
            this.fld_txtICProductNumberSign.BOSFieldRelation = null;
            this.fld_txtICProductNumberSign.BOSPrivilege = null;
            this.fld_txtICProductNumberSign.BOSPropertyName = "Text";
            this.fld_txtICProductNumberSign.Location = new System.Drawing.Point(110, 474);
            this.fld_txtICProductNumberSign.Name = "fld_txtICProductNumberSign";
            this.fld_txtICProductNumberSign.Screen = null;
            this.fld_txtICProductNumberSign.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductNumberSign.TabIndex = 385;
            this.fld_txtICProductNumberSign.Tag = "DC";
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
            this.bosLabel28.Location = new System.Drawing.Point(9, 477);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(35, 13);
            this.bosLabel28.TabIndex = 384;
            this.bosLabel28.Text = "Số hiệu";
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
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(110, 448);
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
            this.fld_lkeFK_GECountryID.TabIndex = 382;
            this.fld_lkeFK_GECountryID.Tag = "DC";
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
            this.bosLabel26.Location = new System.Drawing.Point(9, 451);
            this.bosLabel26.Name = "bosLabel26";
            this.bosLabel26.Screen = null;
            this.bosLabel26.Size = new System.Drawing.Size(38, 13);
            this.bosLabel26.TabIndex = 383;
            this.bosLabel26.Text = "Xuất xứ";
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(282, 206);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_ptbICProductPicture.TabIndex = 370;
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
            this.fld_btnAddProductImageDefault.Location = new System.Drawing.Point(283, 319);
            this.fld_btnAddProductImageDefault.Name = "fld_btnAddProductImageDefault";
            this.fld_btnAddProductImageDefault.Screen = null;
            this.fld_btnAddProductImageDefault.Size = new System.Drawing.Size(125, 21);
            this.fld_btnAddProductImageDefault.TabIndex = 16;
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
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(281, 393);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 19;
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
            this.fld_lkeICProductUses.Location = new System.Drawing.Point(110, 299);
            this.fld_lkeICProductUses.MenuManager = this.screenToolbar;
            this.fld_lkeICProductUses.Name = "fld_lkeICProductUses";
            this.fld_lkeICProductUses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductUses.Properties.ColumnName = null;
            this.fld_lkeICProductUses.Properties.NullText = "";
            this.fld_lkeICProductUses.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductUses.Screen = null;
            this.fld_lkeICProductUses.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductUses.TabIndex = 10;
            this.fld_lkeICProductUses.Tag = "DC";
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
            this.bosLabel21.Location = new System.Drawing.Point(9, 302);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(88, 13);
            this.bosLabel21.TabIndex = 368;
            this.bosLabel21.Text = "Hình thức sử dụng";
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
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(281, 348);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 17;
            this.fld_chkICProductPromotionCheck.Tag = "DC";
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
            this.fld_lkeICProductOriginOfProduct.CurrentDisplayText = "";
            this.fld_lkeICProductOriginOfProduct.Location = new System.Drawing.Point(110, 396);
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
            this.fld_lkeICProductOriginOfProduct.TabIndex = 14;
            this.fld_lkeICProductOriginOfProduct.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(9, 425);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(77, 13);
            this.bosLabel22.TabIndex = 348;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Số ngày lưu kho";
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
            this.bosLabel7.Location = new System.Drawing.Point(9, 400);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(66, 13);
            this.bosLabel7.TabIndex = 348;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Nguồn gốc SP";
            // 
            // fld_lkeICProductTargetType
            // 
            this.fld_lkeICProductTargetType.BOSAllowAddNew = false;
            this.fld_lkeICProductTargetType.BOSAllowDummy = false;
            this.fld_lkeICProductTargetType.BOSComment = null;
            this.fld_lkeICProductTargetType.BOSDataMember = "ICProductTargetType";
            this.fld_lkeICProductTargetType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductTargetType.BOSDescription = null;
            this.fld_lkeICProductTargetType.BOSError = null;
            this.fld_lkeICProductTargetType.BOSFieldGroup = null;
            this.fld_lkeICProductTargetType.BOSFieldParent = null;
            this.fld_lkeICProductTargetType.BOSFieldRelation = null;
            this.fld_lkeICProductTargetType.BOSPrivilege = null;
            this.fld_lkeICProductTargetType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductTargetType.BOSSelectType = null;
            this.fld_lkeICProductTargetType.BOSSelectTypeValue = null;
            this.fld_lkeICProductTargetType.CurrentDisplayText = null;
            this.fld_lkeICProductTargetType.Enabled = false;
            this.fld_lkeICProductTargetType.Location = new System.Drawing.Point(110, 247);
            this.fld_lkeICProductTargetType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductTargetType.Name = "fld_lkeICProductTargetType";
            this.fld_lkeICProductTargetType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductTargetType.Properties.ColumnName = null;
            this.fld_lkeICProductTargetType.Properties.NullText = "";
            this.fld_lkeICProductTargetType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductTargetType.Screen = null;
            this.fld_lkeICProductTargetType.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductTargetType.TabIndex = 8;
            this.fld_lkeICProductTargetType.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(9, 250);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(41, 13);
            this.bosLabel6.TabIndex = 347;
            this.bosLabel6.Text = "Mục đích";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICProductStorageDay";
            this.bosTextBox1.BOSDataSource = "ICProducts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(110, 422);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(155, 20);
            this.bosTextBox1.TabIndex = 15;
            this.bosTextBox1.Tag = "DC";
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
            this.fld_txtICProductBarCode.Size = new System.Drawing.Size(155, 20);
            this.fld_txtICProductBarCode.TabIndex = 13;
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
            this.fld_lblLabel13.Location = new System.Drawing.Point(9, 373);
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
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(110, 273);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(155, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 9;
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
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(281, 370);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 18;
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(110, 325);
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
            this.fld_lkeFK_APSupplierID.TabIndex = 11;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(110, 348);
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
            this.fld_txtICProductName.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.fld_txtICProductName_EditValueChanging);
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
            this.fld_lkeICProductType.Location = new System.Drawing.Point(110, 221);
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
            this.fld_lkeICProductType.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeICProductType_Closed);
            this.fld_lkeICProductType.EditValueChanged += new System.EventHandler(this.fld_lkeICProductType_EditValueChanged);
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(9, 224);
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(9, 327);
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
            this.fld_txtICProductStockMax.Location = new System.Drawing.Point(110, 51);
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
            this.fld_txtICProductStockMax.Size = new System.Drawing.Size(155, 20);
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
            this.fld_lblLabel2.Location = new System.Drawing.Point(9, 54);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATName", "Thuế")});
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
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(433, 252);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(453, 258);
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
            this.fld_lnkShowHistoryBranchPrice.TabIndex = 8;
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
            this.fld_lnkEditPurchasePrice.TabIndex = 7;
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(92, 113);
            this.fld_lkeFK_ICProductBasicUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Tên đơn vị")});
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
            this.fld_lnkEditPrice.TabIndex = 4;
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
            this.fld_grcGroupControl4.Controls.Add(this.fld_lkeICProductUsingMethod);
            this.fld_grcGroupControl4.Controls.Add(this.bosLabel23);
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
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(4, 1);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(882, 108);
            this.fld_grcGroupControl4.TabIndex = 1;
            this.fld_grcGroupControl4.Tag = "";
            this.fld_grcGroupControl4.Text = "Thông tin kho";
            // 
            // fld_lkeICProductUsingMethod
            // 
            this.fld_lkeICProductUsingMethod.BOSAllowAddNew = false;
            this.fld_lkeICProductUsingMethod.BOSAllowDummy = false;
            this.fld_lkeICProductUsingMethod.BOSComment = null;
            this.fld_lkeICProductUsingMethod.BOSDataMember = "ICProductUsingMethod";
            this.fld_lkeICProductUsingMethod.BOSDataSource = "ICProducts";
            this.fld_lkeICProductUsingMethod.BOSDescription = null;
            this.fld_lkeICProductUsingMethod.BOSError = null;
            this.fld_lkeICProductUsingMethod.BOSFieldGroup = null;
            this.fld_lkeICProductUsingMethod.BOSFieldParent = null;
            this.fld_lkeICProductUsingMethod.BOSFieldRelation = null;
            this.fld_lkeICProductUsingMethod.BOSPrivilege = null;
            this.fld_lkeICProductUsingMethod.BOSPropertyName = "EditValue";
            this.fld_lkeICProductUsingMethod.BOSSelectType = null;
            this.fld_lkeICProductUsingMethod.BOSSelectTypeValue = null;
            this.fld_lkeICProductUsingMethod.CurrentDisplayText = null;
            this.fld_lkeICProductUsingMethod.Location = new System.Drawing.Point(110, 77);
            this.fld_lkeICProductUsingMethod.MenuManager = this.screenToolbar;
            this.fld_lkeICProductUsingMethod.Name = "fld_lkeICProductUsingMethod";
            this.fld_lkeICProductUsingMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductUsingMethod.Properties.ColumnName = null;
            this.fld_lkeICProductUsingMethod.Properties.NullText = "";
            this.fld_lkeICProductUsingMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductUsingMethod.Screen = null;
            this.fld_lkeICProductUsingMethod.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeICProductUsingMethod.TabIndex = 6;
            this.fld_lkeICProductUsingMethod.Tag = "DC";
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
            this.bosLabel23.Location = new System.Drawing.Point(9, 80);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(57, 13);
            this.bosLabel23.TabIndex = 336;
            this.bosLabel23.Text = "PT xuất kho";
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
            this.fld_lblLabel12.Location = new System.Drawing.Point(303, 30);
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
            this.fld_lblLabel26.Location = new System.Drawing.Point(594, 30);
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(303, 54);
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
            this.fld_lblLabel29.Location = new System.Drawing.Point(594, 54);
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
            this.fld_dteICProductStockMinDateFrom.Location = new System.Drawing.Point(405, 25);
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
            this.fld_dteICProductStockMinDateFrom.Size = new System.Drawing.Size(155, 20);
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
            this.fld_dteICProductStockMinDateTo.Location = new System.Drawing.Point(669, 25);
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
            this.fld_dteICProductStockMinDateTo.Size = new System.Drawing.Size(155, 20);
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
            this.fld_dteICProductStockMaxDateFrom.Location = new System.Drawing.Point(405, 51);
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
            this.fld_dteICProductStockMaxDateFrom.Size = new System.Drawing.Size(155, 20);
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
            this.fld_dteICProductStockMaxDateTo.Location = new System.Drawing.Point(669, 51);
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
            this.fld_dteICProductStockMaxDateTo.Size = new System.Drawing.Size(155, 20);
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
            this.fld_lblLabel11.TabIndex = 331;
            this.fld_lblLabel11.Tag = "";
            // 
            // bosPanel1
            // 
            this.bosPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_xTabMain);
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1135, 1000);
            this.bosPanel1.TabIndex = 333;
            // 
            // fld_xTabMain
            // 
            this.fld_xTabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_xTabMain.BOSComment = null;
            this.fld_xTabMain.BOSDataMember = null;
            this.fld_xTabMain.BOSDataSource = null;
            this.fld_xTabMain.BOSDescription = null;
            this.fld_xTabMain.BOSError = null;
            this.fld_xTabMain.BOSFieldGroup = null;
            this.fld_xTabMain.BOSFieldRelation = null;
            this.fld_xTabMain.BOSPrivilege = null;
            this.fld_xTabMain.BOSPropertyName = null;
            this.fld_xTabMain.Location = new System.Drawing.Point(0, 0);
            this.fld_xTabMain.Name = "fld_xTabMain";
            this.fld_xTabMain.Screen = null;
            this.fld_xTabMain.SelectedTabPage = this.xtraTabPage1;
            this.fld_xTabMain.Size = new System.Drawing.Size(1123, 1758);
            this.fld_xTabMain.TabIndex = 0;
            this.fld_xTabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.fld_xTabOperation,
            this.fld_xTabMachine,
            this.fld_xTabSemiProduct,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1121, 1733);
            this.xtraTabPage1.Text = "Thông tin";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_grcGroupControl4);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1121, 1733);
            this.splitContainerControl1.SplitterPosition = 515;
            this.splitContainerControl1.TabIndex = 342;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.bosGroupControl2.Controls.Add(this.bosLabel31);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWeight);
            this.bosGroupControl2.Controls.Add(this.bosLabel30);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductCapacity);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductPurchaseType);
            this.bosGroupControl2.Controls.Add(this.bosLabel35);
            this.bosGroupControl2.Controls.Add(this.bosLabel13);
            this.bosGroupControl2.Controls.Add(this.bosLabel12);
            this.bosGroupControl2.Controls.Add(this.bosLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductDepth);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductHeight);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductDiameter);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductRadius);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductThickness);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLength);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWidth);
            this.bosGroupControl2.Controls.Add(this.bosLabel11);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductTrademark);
            this.bosGroupControl2.Controls.Add(this.bosLabel10);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductAttribute);
            this.bosGroupControl2.Location = new System.Drawing.Point(433, 2);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(453, 244);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thuộc tính";
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
            this.bosLabel31.Location = new System.Drawing.Point(18, 212);
            this.bosLabel31.Name = "bosLabel31";
            this.bosLabel31.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel31, true);
            this.bosLabel31.Size = new System.Drawing.Size(122, 13);
            this.bosLabel31.TabIndex = 472;
            this.bosLabel31.Text = "Khối lượng riêng (Gr/cm3)";
            // 
            // fld_txtICProductWeight
            // 
            this.fld_txtICProductWeight.BOSComment = "";
            this.fld_txtICProductWeight.BOSDataMember = "ICProductWeight";
            this.fld_txtICProductWeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductWeight.BOSDescription = null;
            this.fld_txtICProductWeight.BOSError = null;
            this.fld_txtICProductWeight.BOSFieldGroup = "";
            this.fld_txtICProductWeight.BOSFieldRelation = "";
            this.fld_txtICProductWeight.BOSPrivilege = "";
            this.fld_txtICProductWeight.BOSPropertyName = "Text";
            this.fld_txtICProductWeight.Location = new System.Drawing.Point(157, 210);
            this.fld_txtICProductWeight.Name = "fld_txtICProductWeight";
            this.fld_txtICProductWeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWeight.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductWeight.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductWeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWeight, true);
            this.fld_txtICProductWeight.Size = new System.Drawing.Size(270, 20);
            this.fld_txtICProductWeight.TabIndex = 471;
            this.fld_txtICProductWeight.Tag = "DC";
            // 
            // bosLabel30
            // 
            this.bosLabel30.BOSComment = null;
            this.bosLabel30.BOSDataMember = null;
            this.bosLabel30.BOSDataSource = null;
            this.bosLabel30.BOSDescription = null;
            this.bosLabel30.BOSError = null;
            this.bosLabel30.BOSFieldGroup = null;
            this.bosLabel30.BOSFieldRelation = null;
            this.bosLabel30.BOSPrivilege = null;
            this.bosLabel30.BOSPropertyName = null;
            this.bosLabel30.Location = new System.Drawing.Point(18, 186);
            this.bosLabel30.Name = "bosLabel30";
            this.bosLabel30.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel30, true);
            this.bosLabel30.Size = new System.Drawing.Size(74, 13);
            this.bosLabel30.TabIndex = 470;
            this.bosLabel30.Text = "Công suất (Kw)";
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
            this.fld_txtICProductCapacity.Location = new System.Drawing.Point(157, 184);
            this.fld_txtICProductCapacity.Name = "fld_txtICProductCapacity";
            this.fld_txtICProductCapacity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductCapacity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductCapacity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductCapacity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductCapacity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductCapacity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductCapacity.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductCapacity.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductCapacity, true);
            this.fld_txtICProductCapacity.Size = new System.Drawing.Size(270, 20);
            this.fld_txtICProductCapacity.TabIndex = 469;
            this.fld_txtICProductCapacity.Tag = "DC";
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
            this.fld_lkeICProductPurchaseType.Location = new System.Drawing.Point(157, 158);
            this.fld_lkeICProductPurchaseType.Name = "fld_lkeICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPurchaseType.Properties.ColumnName = null;
            this.fld_lkeICProductPurchaseType.Properties.NullText = "";
            this.fld_lkeICProductPurchaseType.Screen = null;
            this.fld_lkeICProductPurchaseType.Size = new System.Drawing.Size(270, 20);
            this.fld_lkeICProductPurchaseType.TabIndex = 11;
            this.fld_lkeICProductPurchaseType.Tag = "DC";
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
            this.bosLabel35.Location = new System.Drawing.Point(18, 161);
            this.bosLabel35.Name = "bosLabel35";
            this.bosLabel35.Screen = null;
            this.bosLabel35.Size = new System.Drawing.Size(69, 13);
            this.bosLabel35.TabIndex = 464;
            this.bosLabel35.Tag = "";
            this.bosLabel35.Text = "Loại mua hàng";
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
            this.bosLabel13.Location = new System.Drawing.Point(250, 135);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(67, 13);
            this.bosLabel13.TabIndex = 9;
            this.bosLabel13.Text = "Bán kính (mm)";
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
            this.bosLabel12.Location = new System.Drawing.Point(250, 108);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(82, 13);
            this.bosLabel12.TabIndex = 6;
            this.bosLabel12.Text = "Đường kính (mm)";
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
            this.bosLabel8.Location = new System.Drawing.Point(18, 134);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(74, 13);
            this.bosLabel8.TabIndex = 439;
            this.bosLabel8.Text = "Chiều sâu (mm)";
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
            this.fld_txtICProductDepth.Location = new System.Drawing.Point(157, 132);
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
            this.fld_txtICProductDepth.Size = new System.Drawing.Size(82, 20);
            this.fld_txtICProductDepth.TabIndex = 8;
            this.fld_txtICProductDepth.Tag = "DC";
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
            this.fld_txtICProductHeight.Location = new System.Drawing.Point(344, 80);
            this.fld_txtICProductHeight.Name = "fld_txtICProductHeight";
            this.fld_txtICProductHeight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductHeight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductHeight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductHeight.Properties.Mask.EditMask = "n3";
            this.fld_txtICProductHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductHeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductHeight, true);
            this.fld_txtICProductHeight.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductHeight.TabIndex = 4;
            this.fld_txtICProductHeight.Tag = "DC";
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
            this.fld_txtICProductDiameter.Location = new System.Drawing.Point(344, 105);
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
            this.fld_txtICProductDiameter.TabIndex = 7;
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
            this.fld_txtICProductRadius.Location = new System.Drawing.Point(344, 132);
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
            this.fld_txtICProductRadius.TabIndex = 10;
            this.fld_txtICProductRadius.Tag = "DC";
            // 
            // fld_txtICProductThickness
            // 
            this.fld_txtICProductThickness.BOSComment = "";
            this.fld_txtICProductThickness.BOSDataMember = "ICProductThickness";
            this.fld_txtICProductThickness.BOSDataSource = "ICProducts";
            this.fld_txtICProductThickness.BOSDescription = null;
            this.fld_txtICProductThickness.BOSError = null;
            this.fld_txtICProductThickness.BOSFieldGroup = "";
            this.fld_txtICProductThickness.BOSFieldRelation = "";
            this.fld_txtICProductThickness.BOSPrivilege = "";
            this.fld_txtICProductThickness.BOSPropertyName = "Text";
            this.fld_txtICProductThickness.Location = new System.Drawing.Point(157, 106);
            this.fld_txtICProductThickness.Name = "fld_txtICProductThickness";
            this.fld_txtICProductThickness.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductThickness.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductThickness.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductThickness.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductThickness.Properties.Mask.EditMask = null;
            this.fld_txtICProductThickness.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductThickness, false);
            this.fld_txtICProductThickness.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductThickness.TabIndex = 5;
            this.fld_txtICProductThickness.Tag = "DC";
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
            this.fld_txtICProductLength.Location = new System.Drawing.Point(250, 80);
            this.fld_txtICProductLength.Name = "fld_txtICProductLength";
            this.fld_txtICProductLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLength.Properties.Mask.EditMask = "n3";
            this.fld_txtICProductLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductLength, true);
            this.fld_txtICProductLength.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductLength.TabIndex = 3;
            this.fld_txtICProductLength.Tag = "DC";
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
            this.fld_txtICProductWidth.Location = new System.Drawing.Point(157, 80);
            this.fld_txtICProductWidth.Name = "fld_txtICProductWidth";
            this.fld_txtICProductWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth.Properties.Mask.EditMask = "n3";
            this.fld_txtICProductWidth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth, false);
            this.fld_txtICProductWidth.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductWidth.TabIndex = 2;
            this.fld_txtICProductWidth.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(18, 108);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(62, 13);
            this.bosLabel11.TabIndex = 438;
            this.bosLabel11.Text = "Độ dày (mm)";
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
            this.bosLabel9.Location = new System.Drawing.Point(18, 82);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(75, 13);
            this.bosLabel9.TabIndex = 434;
            this.bosLabel9.Text = "W x D x H (mm)";
            // 
            // fld_lkeICProductTrademark
            // 
            this.fld_lkeICProductTrademark.BOSAllowAddNew = false;
            this.fld_lkeICProductTrademark.BOSAllowDummy = false;
            this.fld_lkeICProductTrademark.BOSComment = null;
            this.fld_lkeICProductTrademark.BOSDataMember = "FK_ICModelID";
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
            this.fld_lkeICProductTrademark.Location = new System.Drawing.Point(157, 54);
            this.fld_lkeICProductTrademark.Name = "fld_lkeICProductTrademark";
            this.fld_lkeICProductTrademark.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeICProductTrademark.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductTrademark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductTrademark.Properties.ColumnName = null;
            this.fld_lkeICProductTrademark.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICModelName", "Thương hiệu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICModelID", "ICModelID")});
            this.fld_lkeICProductTrademark.Properties.DisplayMember = "ICModelName";
            this.fld_lkeICProductTrademark.Properties.NullText = "";
            this.fld_lkeICProductTrademark.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductTrademark.Properties.ValueMember = "ICModelID";
            this.fld_lkeICProductTrademark.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductTrademark, true);
            this.fld_lkeICProductTrademark.Size = new System.Drawing.Size(270, 20);
            this.fld_lkeICProductTrademark.TabIndex = 1;
            this.fld_lkeICProductTrademark.Tag = "DC";
            this.fld_lkeICProductTrademark.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeICProductTrademark_Closed);
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
            this.bosLabel10.Location = new System.Drawing.Point(18, 57);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(60, 13);
            this.bosLabel10.TabIndex = 424;
            this.bosLabel10.Text = "Thương hiệu";
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(18, 31);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel8.TabIndex = 341;
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
            this.fld_bedICProductAttribute.Location = new System.Drawing.Point(157, 28);
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
            this.fld_bedICProductAttribute.Size = new System.Drawing.Size(271, 20);
            this.fld_bedICProductAttribute.TabIndex = 0;
            this.fld_bedICProductAttribute.Tag = "DC";
            this.fld_bedICProductAttribute.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedICProductAttribute_ButtonClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosButton1);
            this.xtraTabPage2.Controls.Add(this.bosGroupControl3);
            this.xtraTabPage2.Controls.Add(this.bosGroupControl1);
            this.xtraTabPage2.Controls.Add(this.fld_btnSaveProductMeasureUnit);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1121, 1733);
            this.xtraTabPage2.Text = "Tài khoản - ĐVT quy đổi";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(901, 575);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(83, 39);
            this.bosButton1.TabIndex = 498;
            this.bosButton1.Text = "Lưu";
            this.bosButton1.Click += new System.EventHandler(this.fld_btnSaveProductMeasureUnit_Click);
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl3.Appearance.Options.UseBackColor = true;
            this.bosGroupControl3.Appearance.Options.UseForeColor = true;
            this.bosGroupControl3.BOSComment = "";
            this.bosGroupControl3.BOSDataMember = "";
            this.bosGroupControl3.BOSDataSource = "";
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = "";
            this.bosGroupControl3.BOSFieldRelation = "";
            this.bosGroupControl3.BOSPrivilege = "";
            this.bosGroupControl3.BOSPropertyName = "";
            this.bosGroupControl3.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.bosGroupControl3.Location = new System.Drawing.Point(5, 114);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(979, 457);
            this.bosGroupControl3.TabIndex = 348;
            this.bosGroupControl3.Tag = "";
            this.bosGroupControl3.Text = "ĐVT quy đổi";
            // 
            // fld_dgcICProductMeasureUnits
            // 
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
            this.fld_dgcICProductMeasureUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProductMeasureUnits.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcICProductMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMeasureUnits.Name = "fld_dgcICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.PrintReport = false;
            this.fld_dgcICProductMeasureUnits.Screen = null;
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(975, 432);
            this.fld_dgcICProductMeasureUnits.TabIndex = 6;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl1.Controls.Add(this.bosLabel14);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Location = new System.Drawing.Point(5, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(979, 105);
            this.bosGroupControl1.TabIndex = 113;
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(110, 25);
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 0;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ICProductTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductTypeAccountConfigID_CloseUp);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseFont = true;
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
            this.bosLabel20.Location = new System.Drawing.Point(9, 28);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(75, 13);
            this.bosLabel20.TabIndex = 347;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Nhóm tài khoản";
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
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(669, 77);
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
            this.fld_lkeFK_ACAccountDiscountID.Size = new System.Drawing.Size(155, 20);
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
            this.bosLabel17.Location = new System.Drawing.Point(594, 80);
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
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(405, 77);
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
            this.fld_lkeFK_ACAccountSaleReturnID.Size = new System.Drawing.Size(155, 20);
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
            this.bosLabel16.Location = new System.Drawing.Point(303, 80);
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
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(110, 77);
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
            this.fld_lkeFK_ACAccountRevenueID.Size = new System.Drawing.Size(155, 20);
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
            this.bosLabel15.Location = new System.Drawing.Point(9, 80);
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
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(669, 51);
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
            this.fld_lkeFK_ACAccountCostPriceID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_ACAccountCostPriceID.TabIndex = 4;
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
            this.bosLabel14.Location = new System.Drawing.Point(594, 54);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(405, 51);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Size = new System.Drawing.Size(155, 20);
            this.fld_lkeFK_ACAccountRevenueInternalID.TabIndex = 3;
            this.fld_lkeFK_ACAccountRevenueInternalID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
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
            this.bosLabel18.Location = new System.Drawing.Point(303, 54);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(96, 13);
            this.bosLabel18.TabIndex = 334;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "TK doanh thu nội bộ";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(110, 51);
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
            this.bosLookupEdit1.Size = new System.Drawing.Size(155, 20);
            this.bosLookupEdit1.TabIndex = 2;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(9, 54);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(53, 13);
            this.bosLabel19.TabIndex = 332;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "TK Tồn kho";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(405, 25);
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
            this.bosLabel4.Location = new System.Drawing.Point(303, 28);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(46, 13);
            this.bosLabel4.TabIndex = 332;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Tài khoản";
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
            this.fld_btnSaveProductMeasureUnit.Location = new System.Drawing.Point(815, 2007);
            this.fld_btnSaveProductMeasureUnit.Name = "fld_btnSaveProductMeasureUnit";
            this.fld_btnSaveProductMeasureUnit.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSaveProductMeasureUnit, true);
            this.fld_btnSaveProductMeasureUnit.Size = new System.Drawing.Size(69, 25);
            this.fld_btnSaveProductMeasureUnit.TabIndex = 112;
            this.fld_btnSaveProductMeasureUnit.Text = "Lưu";
            this.fld_btnSaveProductMeasureUnit.Click += new System.EventHandler(this.fld_btnSaveProductMeasureUnit_Click);
            // 
            // fld_xTabOperation
            // 
            this.fld_xTabOperation.Controls.Add(this.fld_btnAdd);
            this.fld_xTabOperation.Controls.Add(this.fld_dgcICProductOperations);
            this.fld_xTabOperation.Name = "fld_xTabOperation";
            this.fld_xTabOperation.PageVisible = false;
            this.fld_xTabOperation.Size = new System.Drawing.Size(1107, 1726);
            this.fld_xTabOperation.Text = "Danh sách công đoạn theo khuôn";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.BOSComment = null;
            this.fld_btnAdd.BOSDataMember = null;
            this.fld_btnAdd.BOSDataSource = null;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = null;
            this.fld_btnAdd.BOSFieldRelation = null;
            this.fld_btnAdd.BOSPrivilege = null;
            this.fld_btnAdd.BOSPropertyName = null;
            this.fld_btnAdd.Location = new System.Drawing.Point(11, 12);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(124, 25);
            this.fld_btnAdd.TabIndex = 10;
            this.fld_btnAdd.Tag = "DC";
            this.fld_btnAdd.Text = "Thêm công đoạn";
            this.fld_btnAdd.Click += new System.EventHandler(this.Fld_btnAdd_Click);
            // 
            // fld_dgcICProductOperations
            // 
            this.fld_dgcICProductOperations.AllowDrop = true;
            this.fld_dgcICProductOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductOperations.BOSComment = "";
            this.fld_dgcICProductOperations.BOSDataMember = "";
            this.fld_dgcICProductOperations.BOSDataSource = "ICProductOperations";
            this.fld_dgcICProductOperations.BOSDescription = null;
            this.fld_dgcICProductOperations.BOSError = null;
            this.fld_dgcICProductOperations.BOSFieldGroup = "";
            this.fld_dgcICProductOperations.BOSFieldRelation = "";
            this.fld_dgcICProductOperations.BOSGridType = null;
            this.fld_dgcICProductOperations.BOSPrivilege = "";
            this.fld_dgcICProductOperations.BOSPropertyName = "";
            this.fld_dgcICProductOperations.CommodityType = "";
            this.fld_dgcICProductOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductOperations.Location = new System.Drawing.Point(3, 43);
            this.fld_dgcICProductOperations.MainView = this.fld_dgvGridControl1;
            this.fld_dgcICProductOperations.Name = "fld_dgcICProductOperations";
            this.fld_dgcICProductOperations.PrintReport = false;
            this.fld_dgcICProductOperations.Screen = null;
            this.fld_dgcICProductOperations.Size = new System.Drawing.Size(1087, 1669);
            this.fld_dgcICProductOperations.TabIndex = 9;
            this.fld_dgcICProductOperations.Tag = "DC";
            this.fld_dgcICProductOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcICProductOperations;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // fld_xTabMachine
            // 
            this.fld_xTabMachine.Controls.Add(this.fld_dgcICProductMachines);
            this.fld_xTabMachine.Name = "fld_xTabMachine";
            this.fld_xTabMachine.PageVisible = false;
            this.fld_xTabMachine.Size = new System.Drawing.Size(1107, 1726);
            this.fld_xTabMachine.Text = "Danh sách máy";
            // 
            // fld_dgcICProductMachines
            // 
            this.fld_dgcICProductMachines.AllowDrop = true;
            this.fld_dgcICProductMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductMachines.BOSComment = "";
            this.fld_dgcICProductMachines.BOSDataMember = "";
            this.fld_dgcICProductMachines.BOSDataSource = "ICProductMachines";
            this.fld_dgcICProductMachines.BOSDescription = null;
            this.fld_dgcICProductMachines.BOSError = null;
            this.fld_dgcICProductMachines.BOSFieldGroup = "";
            this.fld_dgcICProductMachines.BOSFieldRelation = "";
            this.fld_dgcICProductMachines.BOSGridType = null;
            this.fld_dgcICProductMachines.BOSPrivilege = "";
            this.fld_dgcICProductMachines.BOSPropertyName = "";
            this.fld_dgcICProductMachines.CommodityType = "";
            this.fld_dgcICProductMachines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductMachines.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductMachines.MainView = this.gridView1;
            this.fld_dgcICProductMachines.Name = "fld_dgcICProductMachines";
            this.fld_dgcICProductMachines.PrintReport = false;
            this.fld_dgcICProductMachines.Screen = null;
            this.fld_dgcICProductMachines.Size = new System.Drawing.Size(1087, 1713);
            this.fld_dgcICProductMachines.TabIndex = 10;
            this.fld_dgcICProductMachines.Tag = "DC";
            this.fld_dgcICProductMachines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICProductMachines;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_xTabSemiProduct
            // 
            this.fld_xTabSemiProduct.Controls.Add(this.fld_btnAddProduct);
            this.fld_xTabSemiProduct.Controls.Add(this.fld_dgcICProductSemis);
            this.fld_xTabSemiProduct.Name = "fld_xTabSemiProduct";
            this.fld_xTabSemiProduct.PageVisible = false;
            this.fld_xTabSemiProduct.Size = new System.Drawing.Size(1107, 1726);
            this.fld_xTabSemiProduct.Text = "Danh sách BTP/ TP";
            // 
            // fld_btnAddProduct
            // 
            this.fld_btnAddProduct.BOSComment = null;
            this.fld_btnAddProduct.BOSDataMember = null;
            this.fld_btnAddProduct.BOSDataSource = null;
            this.fld_btnAddProduct.BOSDescription = null;
            this.fld_btnAddProduct.BOSError = null;
            this.fld_btnAddProduct.BOSFieldGroup = null;
            this.fld_btnAddProduct.BOSFieldRelation = null;
            this.fld_btnAddProduct.BOSPrivilege = null;
            this.fld_btnAddProduct.BOSPropertyName = null;
            this.fld_btnAddProduct.Location = new System.Drawing.Point(3, 13);
            this.fld_btnAddProduct.Name = "fld_btnAddProduct";
            this.fld_btnAddProduct.Screen = null;
            this.fld_btnAddProduct.Size = new System.Drawing.Size(124, 25);
            this.fld_btnAddProduct.TabIndex = 12;
            this.fld_btnAddProduct.Tag = "DC";
            this.fld_btnAddProduct.Text = "Thêm chi tiết từ BOM";
            this.fld_btnAddProduct.Click += new System.EventHandler(this.Fld_btnAddProduct_Click);
            // 
            // fld_dgcICProductSemis
            // 
            this.fld_dgcICProductSemis.AllowDrop = true;
            this.fld_dgcICProductSemis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductSemis.BOSComment = "";
            this.fld_dgcICProductSemis.BOSDataMember = "";
            this.fld_dgcICProductSemis.BOSDataSource = "ICProductSemis";
            this.fld_dgcICProductSemis.BOSDescription = null;
            this.fld_dgcICProductSemis.BOSError = null;
            this.fld_dgcICProductSemis.BOSFieldGroup = "";
            this.fld_dgcICProductSemis.BOSFieldRelation = "";
            this.fld_dgcICProductSemis.BOSGridType = null;
            this.fld_dgcICProductSemis.BOSPrivilege = "";
            this.fld_dgcICProductSemis.BOSPropertyName = "";
            this.fld_dgcICProductSemis.CommodityType = "";
            this.fld_dgcICProductSemis.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductSemis.Location = new System.Drawing.Point(3, 44);
            this.fld_dgcICProductSemis.MainView = this.gridView2;
            this.fld_dgcICProductSemis.Name = "fld_dgcICProductSemis";
            this.fld_dgcICProductSemis.PrintReport = false;
            this.fld_dgcICProductSemis.Screen = null;
            this.fld_dgcICProductSemis.Size = new System.Drawing.Size(1087, 1672);
            this.fld_dgcICProductSemis.TabIndex = 11;
            this.fld_dgcICProductSemis.Tag = "DC";
            this.fld_dgcICProductSemis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcICProductSemis;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcICProductTolenrances);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1107, 1726);
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
            this.fld_dgcICProductTolenrances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICProductTolenrances.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICProductTolenrances.MainView = this.gridView3;
            this.fld_dgcICProductTolenrances.Name = "fld_dgcICProductTolenrances";
            this.fld_dgcICProductTolenrances.PrintReport = false;
            this.fld_dgcICProductTolenrances.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductTolenrances, true);
            this.fld_dgcICProductTolenrances.Size = new System.Drawing.Size(1065, 628);
            this.fld_dgcICProductTolenrances.TabIndex = 11;
            this.fld_dgcICProductTolenrances.Tag = "DC";
            this.fld_dgcICProductTolenrances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcICProductTolenrances;
            this.gridView3.Name = "gridView3";
            this.gridView3.PaintStyleName = "Office2003";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DMOP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1135, 753);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMOP100.IconOptions.Icon")));
            this.Name = "DMOP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNumberSign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTargetType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductUsingMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_xTabMain)).EndInit();
            this.fld_xTabMain.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductRadius.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductTrademark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            this.fld_xTabOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            this.fld_xTabMachine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_xTabSemiProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPurchasePrice;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkShowHistoryBranchPrice;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICProductNoOfOldSys;
        private BOSComponent.BOSTextBox fld_txtICProductBarCode;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSButtonEdit fld_bedICProductAttribute;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeICProductTargetType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeICProductTrademark;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOriginOfProduct;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtICProductDepth;
        private BOSComponent.BOSTextBox fld_txtICProductHeight;
        private BOSComponent.BOSTextBox fld_txtICProductDiameter;
        private BOSComponent.BOSTextBox fld_txtICProductRadius;
        private BOSComponent.BOSTextBox fld_txtICProductThickness;
        private BOSComponent.BOSTextBox fld_txtICProductLength;
        private BOSComponent.BOSTextBox fld_txtICProductWidth;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSLookupEdit fld_lkeICProductUses;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSTabControl fld_xTabMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSButton fld_btnSaveProductMeasureUnit;
		private DevExpress.Utils.ToolTipController toolTipController1;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSButton fld_btnAddProductImageDefault;
        private OpenFileDialog openFileDialog1;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private DevExpress.XtraTab.XtraTabPage fld_xTabOperation;
        private DevExpress.XtraTab.XtraTabPage fld_xTabMachine;
        private DevExpress.XtraTab.XtraTabPage fld_xTabSemiProduct;
        private BOSComponent.BOSButton fld_btnAdd;
        private ICProductOperationsGridControl fld_dgcICProductOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
        private ICProductMachinesGridControl fld_dgcICProductMachines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ICProductSemisGridControl fld_dgcICProductSemis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPurchaseType;
        private BOSComponent.BOSLabel bosLabel35;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLookupEdit fld_lkeICProductUsingMethod;
        private BOSComponent.BOSLabel bosLabel23;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private ICProductTolenrancesGridControl fld_dgcICProductTolenrances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSLabel bosLabel31;
        private BOSComponent.BOSTextBox fld_txtICProductWeight;
        private BOSComponent.BOSLabel bosLabel30;
        private BOSComponent.BOSTextBox fld_txtICProductCapacity;
        private BOSComponent.BOSTextBox fld_txtICProductNumberSign;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel26;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountDiscountID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountSaleReturnID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountCostPriceID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountRevenueInternalID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSButton bosButton1;
    }
}