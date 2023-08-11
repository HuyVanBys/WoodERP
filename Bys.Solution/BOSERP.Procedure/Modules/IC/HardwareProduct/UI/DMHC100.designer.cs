using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HardwareProduct.UI
{
	/// <summary>
	/// Summary description for DMHC100
	/// </summary>
	partial class DMHC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMHC100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.xtraTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountDiscountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountSaleReturnID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountCostPriceID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACAccountRevenueInternalID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl4 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductStockMin = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductStockMax = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICProductStockMinDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMinDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMaxDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteICProductStockMaxDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel201 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductThickness1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel301 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel261 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductDiameter1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel231 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWarping1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductDepth1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel221 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductInDiameter1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductInRadius = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductHeight1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductLength1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWidth1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel121 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductPurchaseType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductLeadTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductOtherSize = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICModelID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductImageFile = new BOSComponent.BOSTextBox(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeICProductOriginOfProduct = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNoOfOldSys = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductAttributeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierNumber = new BOSComponent.BOSTextBox(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lnkEditPurchasePrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lnkOpenBranchPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkEditPrice = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabProductTask = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddHardwareProductImage = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductImagesGridControl = new BOSERP.Modules.HardwareProduct.ICProductImagesGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAddProductComponentItem = new BOSComponent.BOSButton(this.components);
            this.fld_dgcProductComponentGridControl = new BOSERP.Modules.HardwareProduct.ICProductComponentGridControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSaveProductMeasureUnit = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.HardwareProduct.ICProductMeasureUnitsGridControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductTolenrances = new BOSERP.Modules.HardwareProduct.ICProductTolenrancesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductComponents = new BOSERP.Modules.HardwareProduct.ICProductComponentGridControl();
            this.fld_btnShowProductComponent = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).BeginInit();
            this.fld_grcGroupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductThickness1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWarping1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInDiameter1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInRadius.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductOtherSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductImageFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).BeginInit();
            this.fld_tabProductTask.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductImagesGridControl)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductComponentGridControl)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductComponents)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.xtraTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(1032, 873);
            this.bosPanel1.TabIndex = 335;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BOSComment = null;
            this.xtraTabControl1.BOSDataMember = null;
            this.xtraTabControl1.BOSDataSource = null;
            this.xtraTabControl1.BOSDescription = null;
            this.xtraTabControl1.BOSError = null;
            this.xtraTabControl1.BOSFieldGroup = null;
            this.xtraTabControl1.BOSFieldRelation = null;
            this.xtraTabControl1.BOSPrivilege = null;
            this.xtraTabControl1.BOSPropertyName = null;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Screen = null;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(1032, 873);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1030, 848);
            this.xtraTabPage3.Text = "Thông tin";
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
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_grcGroupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_tabProductTask);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.ScreenHelper.SetShowHelp(this.splitContainerControl1, true);
            this.splitContainerControl1.Size = new System.Drawing.Size(1030, 848);
            this.splitContainerControl1.SplitterPosition = 657;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl3.Controls.Add(this.bosLabel11);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl3.Controls.Add(this.bosLabel17);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl3.Controls.Add(this.bosLabel16);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl3.Controls.Add(this.bosLabel8);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl3.Controls.Add(this.bosLabel15);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl3.Controls.Add(this.bosLabel14);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl3.Controls.Add(this.bosLabel13);
            this.bosGroupControl3.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl3.Controls.Add(this.bosLabel18);
            this.bosGroupControl3.Location = new System.Drawing.Point(2, 462);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(1022, 105);
            this.bosGroupControl3.TabIndex = 3;
            this.bosGroupControl3.Tag = "";
            this.bosGroupControl3.Text = "Tài khoản";
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
            this.bosLabel11.Location = new System.Drawing.Point(14, 28);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(75, 13);
            this.bosLabel11.TabIndex = 343;
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
            this.bosLabel17.Location = new System.Drawing.Point(524, 80);
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
            this.bosLabel16.Location = new System.Drawing.Point(262, 80);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(90, 13);
            this.bosLabel16.TabIndex = 340;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "TK hàng bán trả lại";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(364, 25);
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
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(262, 28);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 343;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tài khoản";
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
            this.bosLabel15.Location = new System.Drawing.Point(14, 80);
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
            this.bosLabel14.Location = new System.Drawing.Point(524, 54);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.TabIndex = 3;
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
            this.bosLabel13.Location = new System.Drawing.Point(262, 54);
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(108, 51);
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
            this.bosLookupEdit1.TabIndex = 2;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosLabel18.Location = new System.Drawing.Point(15, 54);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(53, 13);
            this.bosLabel18.TabIndex = 332;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "TK Tồn kho";
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
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(3, 573);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl4, true);
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(1024, 85);
            this.fld_grcGroupControl4.TabIndex = 4;
            this.fld_grcGroupControl4.Tag = "";
            this.fld_grcGroupControl4.Text = "Thông tin kho";
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
            this.ScreenHelper.SetShowHelp(this.fld_Lablel1, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductStockMin, true);
            this.fld_txtICProductStockMin.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductStockMin.TabIndex = 0;
            this.fld_txtICProductStockMin.Tag = "DC";
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
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductStockMax, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel2, true);
            this.fld_lblLabel2.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel2.TabIndex = 277;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Số lượng tối đa";
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
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel26, true);
            this.fld_lblLabel26.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel26.TabIndex = 2;
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
            this.fld_lblLabel27.Location = new System.Drawing.Point(261, 56);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel27, true);
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
            this.fld_lblLabel29.Location = new System.Drawing.Point(504, 56);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel29, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductStockMinDateFrom, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductStockMinDateTo, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductStockMaxDateFrom, true);
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
            this.ScreenHelper.SetShowHelp(this.fld_dteICProductStockMaxDateTo, true);
            this.fld_dteICProductStockMaxDateTo.Size = new System.Drawing.Size(132, 20);
            this.fld_dteICProductStockMaxDateTo.TabIndex = 5;
            this.fld_dteICProductStockMaxDateTo.Tag = "DC";
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
            this.bosGroupControl2.Controls.Add(this.bosLabel201);
            this.bosGroupControl2.Controls.Add(this.bosLabel61);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductThickness1);
            this.bosGroupControl2.Controls.Add(this.bosLabel301);
            this.bosGroupControl2.Controls.Add(this.bosLabel261);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductDiameter1);
            this.bosGroupControl2.Controls.Add(this.bosLabel231);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWarping1);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductDepth1);
            this.bosGroupControl2.Controls.Add(this.bosLabel221);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductInDiameter1);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductInRadius);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductHeight1);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLength1);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWidth1);
            this.bosGroupControl2.Controls.Add(this.bosLabel121);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductPurchaseType);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLeadTime);
            this.bosGroupControl2.Controls.Add(this.bosLabel24);
            this.bosGroupControl2.Controls.Add(this.bosLabel25);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.fld_medICProductOtherSize);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductAttribute);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl2.Location = new System.Drawing.Point(434, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(593, 287);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thuộc tính && Thương hiệu";
            // 
            // bosLabel201
            // 
            this.bosLabel201.BOSComment = null;
            this.bosLabel201.BOSDataMember = null;
            this.bosLabel201.BOSDataSource = null;
            this.bosLabel201.BOSDescription = null;
            this.bosLabel201.BOSError = null;
            this.bosLabel201.BOSFieldGroup = null;
            this.bosLabel201.BOSFieldRelation = null;
            this.bosLabel201.BOSPrivilege = null;
            this.bosLabel201.BOSPropertyName = null;
            this.bosLabel201.Location = new System.Drawing.Point(221, 208);
            this.bosLabel201.Name = "bosLabel201";
            this.bosLabel201.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel201, true);
            this.bosLabel201.Size = new System.Drawing.Size(96, 13);
            this.bosLabel201.TabIndex = 496;
            this.bosLabel201.Text = "Bán kính trong (mm)";
            this.bosLabel201.UseWaitCursor = true;
            // 
            // bosLabel61
            // 
            this.bosLabel61.BOSComment = null;
            this.bosLabel61.BOSDataMember = null;
            this.bosLabel61.BOSDataSource = null;
            this.bosLabel61.BOSDescription = null;
            this.bosLabel61.BOSError = null;
            this.bosLabel61.BOSFieldGroup = null;
            this.bosLabel61.BOSFieldRelation = null;
            this.bosLabel61.BOSPrivilege = null;
            this.bosLabel61.BOSPropertyName = null;
            this.bosLabel61.Location = new System.Drawing.Point(224, 260);
            this.bosLabel61.Name = "bosLabel61";
            this.bosLabel61.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel61, true);
            this.bosLabel61.Size = new System.Drawing.Size(45, 13);
            this.bosLabel61.TabIndex = 495;
            this.bosLabel61.Text = "Sâu (mm)";
            this.bosLabel61.UseWaitCursor = true;
            // 
            // fld_txtICProductThickness1
            // 
            this.fld_txtICProductThickness1.BOSComment = "";
            this.fld_txtICProductThickness1.BOSDataMember = "ICProductThickness";
            this.fld_txtICProductThickness1.BOSDataSource = "ICProducts";
            this.fld_txtICProductThickness1.BOSDescription = null;
            this.fld_txtICProductThickness1.BOSError = null;
            this.fld_txtICProductThickness1.BOSFieldGroup = "";
            this.fld_txtICProductThickness1.BOSFieldRelation = "";
            this.fld_txtICProductThickness1.BOSPrivilege = "";
            this.fld_txtICProductThickness1.BOSPropertyName = "Text";
            this.fld_txtICProductThickness1.Location = new System.Drawing.Point(133, 179);
            this.fld_txtICProductThickness1.Name = "fld_txtICProductThickness1";
            this.fld_txtICProductThickness1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductThickness1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductThickness1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductThickness1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductThickness1.Properties.MaskSettings.Set("mask", null);
            this.fld_txtICProductThickness1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductThickness1, false);
            this.fld_txtICProductThickness1.Size = new System.Drawing.Size(270, 20);
            this.fld_txtICProductThickness1.TabIndex = 493;
            this.fld_txtICProductThickness1.Tag = "DC";
            this.fld_txtICProductThickness1.UseWaitCursor = true;
            // 
            // bosLabel301
            // 
            this.bosLabel301.BOSComment = null;
            this.bosLabel301.BOSDataMember = null;
            this.bosLabel301.BOSDataSource = null;
            this.bosLabel301.BOSDescription = null;
            this.bosLabel301.BOSError = null;
            this.bosLabel301.BOSFieldGroup = null;
            this.bosLabel301.BOSFieldRelation = null;
            this.bosLabel301.BOSPrivilege = null;
            this.bosLabel301.BOSPropertyName = null;
            this.bosLabel301.Location = new System.Drawing.Point(17, 182);
            this.bosLabel301.Name = "bosLabel301";
            this.bosLabel301.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel301, true);
            this.bosLabel301.Size = new System.Drawing.Size(46, 13);
            this.bosLabel301.TabIndex = 494;
            this.bosLabel301.Text = "Dày (mm)";
            this.bosLabel301.UseWaitCursor = true;
            // 
            // bosLabel261
            // 
            this.bosLabel261.BOSComment = null;
            this.bosLabel261.BOSDataMember = null;
            this.bosLabel261.BOSDataSource = null;
            this.bosLabel261.BOSDescription = null;
            this.bosLabel261.BOSError = null;
            this.bosLabel261.BOSFieldGroup = null;
            this.bosLabel261.BOSFieldRelation = null;
            this.bosLabel261.BOSPrivilege = null;
            this.bosLabel261.BOSPropertyName = null;
            this.bosLabel261.Location = new System.Drawing.Point(17, 234);
            this.bosLabel261.Name = "bosLabel261";
            this.bosLabel261.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel261, true);
            this.bosLabel261.Size = new System.Drawing.Size(111, 13);
            this.bosLabel261.TabIndex = 492;
            this.bosLabel261.Text = "Đường kính ngoài (mm)";
            this.bosLabel261.UseWaitCursor = true;
            // 
            // fld_txtICProductDiameter1
            // 
            this.fld_txtICProductDiameter1.BOSComment = "";
            this.fld_txtICProductDiameter1.BOSDataMember = "ICProductDiameter";
            this.fld_txtICProductDiameter1.BOSDataSource = "ICProducts";
            this.fld_txtICProductDiameter1.BOSDescription = null;
            this.fld_txtICProductDiameter1.BOSError = null;
            this.fld_txtICProductDiameter1.BOSFieldGroup = "";
            this.fld_txtICProductDiameter1.BOSFieldRelation = "";
            this.fld_txtICProductDiameter1.BOSPrivilege = "";
            this.fld_txtICProductDiameter1.BOSPropertyName = "Text";
            this.fld_txtICProductDiameter1.Location = new System.Drawing.Point(133, 231);
            this.fld_txtICProductDiameter1.Name = "fld_txtICProductDiameter1";
            this.fld_txtICProductDiameter1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDiameter1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDiameter1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDiameter1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDiameter1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDiameter1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductDiameter1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductDiameter1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductDiameter1, true);
            this.fld_txtICProductDiameter1.Size = new System.Drawing.Size(270, 20);
            this.fld_txtICProductDiameter1.TabIndex = 491;
            this.fld_txtICProductDiameter1.Tag = "DC";
            this.fld_txtICProductDiameter1.UseWaitCursor = true;
            // 
            // bosLabel231
            // 
            this.bosLabel231.BOSComment = null;
            this.bosLabel231.BOSDataMember = null;
            this.bosLabel231.BOSDataSource = null;
            this.bosLabel231.BOSDescription = null;
            this.bosLabel231.BOSError = null;
            this.bosLabel231.BOSFieldGroup = null;
            this.bosLabel231.BOSFieldRelation = null;
            this.bosLabel231.BOSPrivilege = null;
            this.bosLabel231.BOSPropertyName = null;
            this.bosLabel231.Location = new System.Drawing.Point(17, 260);
            this.bosLabel231.Name = "bosLabel231";
            this.bosLabel231.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel231, true);
            this.bosLabel231.Size = new System.Drawing.Size(68, 13);
            this.bosLabel231.TabIndex = 490;
            this.bosLabel231.Text = "Độ vênh (mm)";
            this.bosLabel231.UseWaitCursor = true;
            // 
            // fld_txtICProductWarping1
            // 
            this.fld_txtICProductWarping1.BOSComment = "";
            this.fld_txtICProductWarping1.BOSDataMember = "ICProductWarping";
            this.fld_txtICProductWarping1.BOSDataSource = "ICProducts";
            this.fld_txtICProductWarping1.BOSDescription = null;
            this.fld_txtICProductWarping1.BOSError = null;
            this.fld_txtICProductWarping1.BOSFieldGroup = "";
            this.fld_txtICProductWarping1.BOSFieldRelation = "";
            this.fld_txtICProductWarping1.BOSPrivilege = "";
            this.fld_txtICProductWarping1.BOSPropertyName = "Text";
            this.fld_txtICProductWarping1.Location = new System.Drawing.Point(133, 257);
            this.fld_txtICProductWarping1.Name = "fld_txtICProductWarping1";
            this.fld_txtICProductWarping1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWarping1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWarping1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWarping1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWarping1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWarping1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductWarping1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductWarping1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWarping1, true);
            this.fld_txtICProductWarping1.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductWarping1.TabIndex = 489;
            this.fld_txtICProductWarping1.Tag = "DC";
            this.fld_txtICProductWarping1.UseWaitCursor = true;
            // 
            // fld_txtICProductDepth1
            // 
            this.fld_txtICProductDepth1.BOSComment = "";
            this.fld_txtICProductDepth1.BOSDataMember = "ICProductDepth";
            this.fld_txtICProductDepth1.BOSDataSource = "ICProducts";
            this.fld_txtICProductDepth1.BOSDescription = null;
            this.fld_txtICProductDepth1.BOSError = null;
            this.fld_txtICProductDepth1.BOSFieldGroup = "";
            this.fld_txtICProductDepth1.BOSFieldRelation = "";
            this.fld_txtICProductDepth1.BOSPrivilege = "";
            this.fld_txtICProductDepth1.BOSPropertyName = "Text";
            this.fld_txtICProductDepth1.Location = new System.Drawing.Point(320, 257);
            this.fld_txtICProductDepth1.Name = "fld_txtICProductDepth1";
            this.fld_txtICProductDepth1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDepth1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDepth1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDepth1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDepth1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDepth1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductDepth1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductDepth1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductDepth1, true);
            this.fld_txtICProductDepth1.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductDepth1.TabIndex = 488;
            this.fld_txtICProductDepth1.Tag = "DC";
            this.fld_txtICProductDepth1.UseWaitCursor = true;
            // 
            // bosLabel221
            // 
            this.bosLabel221.BOSComment = null;
            this.bosLabel221.BOSDataMember = null;
            this.bosLabel221.BOSDataSource = null;
            this.bosLabel221.BOSDescription = null;
            this.bosLabel221.BOSError = null;
            this.bosLabel221.BOSFieldGroup = null;
            this.bosLabel221.BOSFieldRelation = null;
            this.bosLabel221.BOSPrivilege = null;
            this.bosLabel221.BOSPropertyName = null;
            this.bosLabel221.Location = new System.Drawing.Point(17, 208);
            this.bosLabel221.Name = "bosLabel221";
            this.bosLabel221.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel221, true);
            this.bosLabel221.Size = new System.Drawing.Size(111, 13);
            this.bosLabel221.TabIndex = 487;
            this.bosLabel221.Text = "Đường kính trong (mm)";
            this.bosLabel221.UseWaitCursor = true;
            // 
            // fld_txtICProductInDiameter1
            // 
            this.fld_txtICProductInDiameter1.BOSComment = "";
            this.fld_txtICProductInDiameter1.BOSDataMember = "ICProductInDiameter";
            this.fld_txtICProductInDiameter1.BOSDataSource = "ICProducts";
            this.fld_txtICProductInDiameter1.BOSDescription = null;
            this.fld_txtICProductInDiameter1.BOSError = null;
            this.fld_txtICProductInDiameter1.BOSFieldGroup = "";
            this.fld_txtICProductInDiameter1.BOSFieldRelation = "";
            this.fld_txtICProductInDiameter1.BOSPrivilege = "";
            this.fld_txtICProductInDiameter1.BOSPropertyName = "Text";
            this.fld_txtICProductInDiameter1.Location = new System.Drawing.Point(133, 205);
            this.fld_txtICProductInDiameter1.Name = "fld_txtICProductInDiameter1";
            this.fld_txtICProductInDiameter1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductInDiameter1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductInDiameter1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductInDiameter1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductInDiameter1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductInDiameter1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductInDiameter1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductInDiameter1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductInDiameter1, true);
            this.fld_txtICProductInDiameter1.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductInDiameter1.TabIndex = 485;
            this.fld_txtICProductInDiameter1.Tag = "DC";
            this.fld_txtICProductInDiameter1.UseWaitCursor = true;
            // 
            // fld_txtICProductInRadius
            // 
            this.fld_txtICProductInRadius.BOSComment = "";
            this.fld_txtICProductInRadius.BOSDataMember = "ICProductInRadius";
            this.fld_txtICProductInRadius.BOSDataSource = "ICProducts";
            this.fld_txtICProductInRadius.BOSDescription = null;
            this.fld_txtICProductInRadius.BOSError = null;
            this.fld_txtICProductInRadius.BOSFieldGroup = "";
            this.fld_txtICProductInRadius.BOSFieldRelation = "";
            this.fld_txtICProductInRadius.BOSPrivilege = "";
            this.fld_txtICProductInRadius.BOSPropertyName = "Text";
            this.fld_txtICProductInRadius.Location = new System.Drawing.Point(320, 205);
            this.fld_txtICProductInRadius.Name = "fld_txtICProductInRadius";
            this.fld_txtICProductInRadius.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductInRadius.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductInRadius.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductInRadius.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductInRadius.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductInRadius.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductInRadius.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductInRadius.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductInRadius, true);
            this.fld_txtICProductInRadius.Size = new System.Drawing.Size(83, 20);
            this.fld_txtICProductInRadius.TabIndex = 486;
            this.fld_txtICProductInRadius.Tag = "DC";
            this.fld_txtICProductInRadius.UseWaitCursor = true;
            // 
            // fld_txtICProductHeight1
            // 
            this.fld_txtICProductHeight1.BOSComment = "";
            this.fld_txtICProductHeight1.BOSDataMember = "ICProductHeight";
            this.fld_txtICProductHeight1.BOSDataSource = "ICProducts";
            this.fld_txtICProductHeight1.BOSDescription = null;
            this.fld_txtICProductHeight1.BOSError = null;
            this.fld_txtICProductHeight1.BOSFieldGroup = "";
            this.fld_txtICProductHeight1.BOSFieldRelation = "";
            this.fld_txtICProductHeight1.BOSPrivilege = "";
            this.fld_txtICProductHeight1.BOSPropertyName = "Text";
            this.fld_txtICProductHeight1.Location = new System.Drawing.Point(133, 153);
            this.fld_txtICProductHeight1.Name = "fld_txtICProductHeight1";
            this.fld_txtICProductHeight1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductHeight1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductHeight1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductHeight1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductHeight1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductHeight1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductHeight1.Properties.MaskSettings.Set("mask", "n2");
            this.fld_txtICProductHeight1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductHeight1, true);
            this.fld_txtICProductHeight1.Size = new System.Drawing.Size(85, 20);
            this.fld_txtICProductHeight1.TabIndex = 481;
            this.fld_txtICProductHeight1.Tag = "DC";
            this.fld_txtICProductHeight1.UseWaitCursor = true;
            // 
            // fld_txtICProductLength1
            // 
            this.fld_txtICProductLength1.BOSComment = "";
            this.fld_txtICProductLength1.BOSDataMember = "ICProductLength";
            this.fld_txtICProductLength1.BOSDataSource = "ICProducts";
            this.fld_txtICProductLength1.BOSDescription = null;
            this.fld_txtICProductLength1.BOSError = null;
            this.fld_txtICProductLength1.BOSFieldGroup = "";
            this.fld_txtICProductLength1.BOSFieldRelation = "";
            this.fld_txtICProductLength1.BOSPrivilege = "";
            this.fld_txtICProductLength1.BOSPropertyName = "Text";
            this.fld_txtICProductLength1.Location = new System.Drawing.Point(318, 153);
            this.fld_txtICProductLength1.Name = "fld_txtICProductLength1";
            this.fld_txtICProductLength1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLength1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLength1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLength1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLength1.Properties.MaskSettings.Set("mask", null);
            this.fld_txtICProductLength1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductLength1, false);
            this.fld_txtICProductLength1.Size = new System.Drawing.Size(85, 20);
            this.fld_txtICProductLength1.TabIndex = 483;
            this.fld_txtICProductLength1.Tag = "DC";
            this.fld_txtICProductLength1.UseWaitCursor = true;
            // 
            // fld_txtICProductWidth1
            // 
            this.fld_txtICProductWidth1.BOSComment = "";
            this.fld_txtICProductWidth1.BOSDataMember = "ICProductWidth";
            this.fld_txtICProductWidth1.BOSDataSource = "ICProducts";
            this.fld_txtICProductWidth1.BOSDescription = null;
            this.fld_txtICProductWidth1.BOSError = null;
            this.fld_txtICProductWidth1.BOSFieldGroup = "";
            this.fld_txtICProductWidth1.BOSFieldRelation = "";
            this.fld_txtICProductWidth1.BOSPrivilege = "";
            this.fld_txtICProductWidth1.BOSPropertyName = "Text";
            this.fld_txtICProductWidth1.Location = new System.Drawing.Point(224, 153);
            this.fld_txtICProductWidth1.Name = "fld_txtICProductWidth1";
            this.fld_txtICProductWidth1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWidth1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductWidth1.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductWidth1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth1, true);
            this.fld_txtICProductWidth1.Size = new System.Drawing.Size(85, 20);
            this.fld_txtICProductWidth1.TabIndex = 482;
            this.fld_txtICProductWidth1.Tag = "DC";
            this.fld_txtICProductWidth1.UseWaitCursor = true;
            // 
            // bosLabel121
            // 
            this.bosLabel121.BOSComment = null;
            this.bosLabel121.BOSDataMember = null;
            this.bosLabel121.BOSDataSource = null;
            this.bosLabel121.BOSDescription = null;
            this.bosLabel121.BOSError = null;
            this.bosLabel121.BOSFieldGroup = null;
            this.bosLabel121.BOSFieldRelation = null;
            this.bosLabel121.BOSPrivilege = null;
            this.bosLabel121.BOSPropertyName = null;
            this.bosLabel121.Location = new System.Drawing.Point(17, 156);
            this.bosLabel121.Name = "bosLabel121";
            this.bosLabel121.Screen = null;
            this.bosLabel121.Size = new System.Drawing.Size(110, 13);
            this.bosLabel121.TabIndex = 484;
            this.bosLabel121.Text = "Cao x Rộng x Dài (mm)";
            this.bosLabel121.UseWaitCursor = true;
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
            this.fld_lkeICProductPurchaseType.Location = new System.Drawing.Point(133, 127);
            this.fld_lkeICProductPurchaseType.Name = "fld_lkeICProductPurchaseType";
            this.fld_lkeICProductPurchaseType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductPurchaseType.Properties.ColumnName = null;
            this.fld_lkeICProductPurchaseType.Screen = null;
            this.fld_lkeICProductPurchaseType.Size = new System.Drawing.Size(270, 20);
            this.fld_lkeICProductPurchaseType.TabIndex = 12;
            this.fld_lkeICProductPurchaseType.Tag = "DC";
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
            this.fld_txtICProductLeadTime.Location = new System.Drawing.Point(133, 101);
            this.fld_txtICProductLeadTime.Name = "fld_txtICProductLeadTime";
            this.fld_txtICProductLeadTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLeadTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLeadTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductLeadTime.Screen = null;
            this.fld_txtICProductLeadTime.Size = new System.Drawing.Size(270, 20);
            this.fld_txtICProductLeadTime.TabIndex = 11;
            this.fld_txtICProductLeadTime.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel24.Location = new System.Drawing.Point(17, 130);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(69, 13);
            this.bosLabel24.TabIndex = 464;
            this.bosLabel24.Text = "Loại mua hàng";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel25.Location = new System.Drawing.Point(17, 104);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(88, 13);
            this.bosLabel25.TabIndex = 463;
            this.bosLabel25.Text = "T.gian hoàn thành";
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
            this.bosLabel9.Location = new System.Drawing.Point(17, 55);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(99, 13);
            this.bosLabel9.TabIndex = 460;
            this.bosLabel9.Text = "Kích thước/Quy cách";
            // 
            // fld_medICProductOtherSize
            // 
            this.fld_medICProductOtherSize.BOSComment = "";
            this.fld_medICProductOtherSize.BOSDataMember = "ICProductSizeAndSpecifiCations";
            this.fld_medICProductOtherSize.BOSDataSource = "ICProducts";
            this.fld_medICProductOtherSize.BOSDescription = null;
            this.fld_medICProductOtherSize.BOSError = null;
            this.fld_medICProductOtherSize.BOSFieldGroup = "";
            this.fld_medICProductOtherSize.BOSFieldRelation = "";
            this.fld_medICProductOtherSize.BOSPrivilege = "";
            this.fld_medICProductOtherSize.BOSPropertyName = "Text";
            this.fld_medICProductOtherSize.EditValue = "";
            this.fld_medICProductOtherSize.Location = new System.Drawing.Point(133, 52);
            this.fld_medICProductOtherSize.Name = "fld_medICProductOtherSize";
            this.fld_medICProductOtherSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductOtherSize.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductOtherSize.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductOtherSize.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductOtherSize.Screen = null;
            this.fld_medICProductOtherSize.Size = new System.Drawing.Size(270, 43);
            this.fld_medICProductOtherSize.TabIndex = 10;
            this.fld_medICProductOtherSize.Tag = "DC";
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
            this.fld_bedICProductAttribute.Location = new System.Drawing.Point(133, 26);
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
            this.ScreenHelper.SetShowHelp(this.fld_bedICProductAttribute, true);
            this.fld_bedICProductAttribute.Size = new System.Drawing.Size(270, 20);
            this.fld_bedICProductAttribute.TabIndex = 0;
            this.fld_bedICProductAttribute.Tag = "DC";
            this.fld_bedICProductAttribute.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedICProductAttribute_ButtonClick);
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(17, 29);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel8, true);
            this.fld_lblLabel8.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel8.TabIndex = 332;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Thuộc tính khác";
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_GECountryID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel28);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ICModelID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel29);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductImageFile);
            this.fld_grcGroupControl5.Controls.Add(this.pictureBox1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductOriginOfProduct);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel19);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel10);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductNoOfOldSys);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox4);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICProductType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel17);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductAttributeNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductSupplierNumber);
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
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 453);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
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
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(110, 396);
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
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 391;
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.UseWaitCursor = true;
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
            this.bosLabel28.Location = new System.Drawing.Point(12, 399);
            this.bosLabel28.Name = "bosLabel28";
            this.bosLabel28.Screen = null;
            this.bosLabel28.Size = new System.Drawing.Size(38, 13);
            this.bosLabel28.TabIndex = 392;
            this.bosLabel28.Text = "Xuất xứ";
            this.bosLabel28.UseWaitCursor = true;
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
            this.fld_lkeFK_ICModelID.Location = new System.Drawing.Point(110, 422);
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
            this.fld_lkeFK_ICModelID.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeFK_ICModelID.TabIndex = 389;
            this.fld_lkeFK_ICModelID.Tag = "DC";
            this.fld_lkeFK_ICModelID.UseWaitCursor = true;
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
            this.bosLabel29.Location = new System.Drawing.Point(12, 425);
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.bosLabel29.Size = new System.Drawing.Size(60, 13);
            this.bosLabel29.TabIndex = 390;
            this.bosLabel29.Text = "Thương hiệu";
            this.bosLabel29.UseWaitCursor = true;
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
            this.fld_txtICProductImageFile.Location = new System.Drawing.Point(283, 312);
            this.fld_txtICProductImageFile.MenuManager = this.screenToolbar;
            this.fld_txtICProductImageFile.Name = "fld_txtICProductImageFile";
            this.fld_txtICProductImageFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.fld_txtICProductImageFile.Properties.Appearance.Options.UseFont = true;
            this.fld_txtICProductImageFile.Properties.ReadOnly = true;
            this.fld_txtICProductImageFile.Screen = null;
            this.fld_txtICProductImageFile.Size = new System.Drawing.Size(125, 20);
            this.fld_txtICProductImageFile.TabIndex = 378;
            this.fld_txtICProductImageFile.Tag = "DC";
            this.fld_txtICProductImageFile.DoubleClick += new System.EventHandler(this.fld_txtICProductImageFile_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BOSERP.Procedure.Properties.Resources.Edit;
            this.pictureBox1.Location = new System.Drawing.Point(386, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 377;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(283, 366);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 18;
            this.fld_chkICProductIsShowWeb.Tag = "DC";
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(283, 200);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fld_ptbICProductPicture.TabIndex = 371;
            this.fld_ptbICProductPicture.TabStop = false;
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
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(283, 391);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 19;
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
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(283, 338);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductActiveCheck, true);
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(75, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 17;
            this.fld_chkICProductActiveCheck.Tag = "DC";
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
            this.fld_lkeICProductOriginOfProduct.Location = new System.Drawing.Point(110, 344);
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
            this.fld_lkeICProductOriginOfProduct.TabIndex = 13;
            this.fld_lkeICProductOriginOfProduct.Tag = "DC";
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
            this.bosLabel19.Location = new System.Drawing.Point(12, 373);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(77, 13);
            this.bosLabel19.TabIndex = 344;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Số ngày lưu kho";
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 346);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(66, 13);
            this.bosLabel10.TabIndex = 344;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Nguồn gốc SP";
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
            this.bosLabel4.BOSDataMember = "ICProductName";
            this.bosLabel4.BOSDataSource = "ICProducts";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(12, 59);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 341;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mã HT cũ";
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
            this.fld_txtICProductNoOfOldSys.Location = new System.Drawing.Point(110, 52);
            this.fld_txtICProductNoOfOldSys.Name = "fld_txtICProductNoOfOldSys";
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNoOfOldSys.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNoOfOldSys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNoOfOldSys.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNoOfOldSys, true);
            this.fld_txtICProductNoOfOldSys.Size = new System.Drawing.Size(190, 20);
            this.fld_txtICProductNoOfOldSys.TabIndex = 1;
            this.fld_txtICProductNoOfOldSys.Tag = "DC";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = null;
            this.bosTextBox4.BOSDataMember = "ICProductStorageDay";
            this.bosTextBox4.BOSDataSource = "ICProducts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = null;
            this.bosTextBox4.BOSFieldRelation = null;
            this.bosTextBox4.BOSPrivilege = null;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Location = new System.Drawing.Point(110, 370);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(156, 20);
            this.bosTextBox4.TabIndex = 15;
            this.bosTextBox4.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICProductBarCode";
            this.bosTextBox1.BOSDataSource = "ICProducts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(110, 318);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(156, 20);
            this.bosTextBox1.TabIndex = 12;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(12, 321);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 339;
            this.bosLabel5.Text = "Mã vạch";
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
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(110, 245);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedFK_ICProductGroupID, true);
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(156, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 8;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
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
            this.fld_lkeICProductType.BOSSelectType = "";
            this.fld_lkeICProductType.BOSSelectTypeValue = "";
            this.fld_lkeICProductType.CurrentDisplayText = null;
            this.fld_lkeICProductType.Enabled = false;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(110, 219);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductType, true);
            this.fld_lkeICProductType.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeICProductType.TabIndex = 7;
            this.fld_lkeICProductType.Tag = "DC";
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(12, 222);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel17, true);
            this.fld_lblLabel17.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel17.TabIndex = 334;
            this.fld_lblLabel17.Text = "Loại";
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(110, 271);
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
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_APSupplierID, true);
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(156, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 10;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(110, 299);
            this.fld_lnkOpenSupplier.MenuManager = this.screenToolbar;
            this.fld_lnkOpenSupplier.Name = "fld_lnkOpenSupplier";
            this.fld_lnkOpenSupplier.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkOpenSupplier, true);
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 111);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 85);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
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
            this.fld_txtICProductName.Location = new System.Drawing.Point(110, 130);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductName, true);
            this.fld_txtICProductName.Size = new System.Drawing.Size(296, 20);
            this.fld_txtICProductName.TabIndex = 4;
            this.fld_txtICProductName.Tag = "DC";
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
            this.fld_txtICProductAttributeNo.Location = new System.Drawing.Point(110, 104);
            this.fld_txtICProductAttributeNo.Name = "fld_txtICProductAttributeNo";
            this.fld_txtICProductAttributeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductAttributeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductAttributeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductAttributeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductAttributeNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductAttributeNo, true);
            this.fld_txtICProductAttributeNo.Size = new System.Drawing.Size(190, 20);
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
            this.fld_txtICProductSupplierNumber.Location = new System.Drawing.Point(110, 78);
            this.fld_txtICProductSupplierNumber.Name = "fld_txtICProductSupplierNumber";
            this.fld_txtICProductSupplierNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductSupplierNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductSupplierNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductSupplierNumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductSupplierNumber, true);
            this.fld_txtICProductSupplierNumber.Size = new System.Drawing.Size(190, 20);
            this.fld_txtICProductSupplierNumber.TabIndex = 2;
            this.fld_txtICProductSupplierNumber.Tag = "DC";
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(110, 198);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkSetDefaultDesc, true);
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 6;
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(12, 33);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(62, 13);
            this.fld_lblLabel15.TabIndex = 7;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã hardware";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 137);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(66, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên hardware";
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
            this.fld_lblLabel21.Location = new System.Drawing.Point(11, 159);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel21, true);
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(12, 252);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
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
            this.fld_medICProductDesc.Location = new System.Drawing.Point(110, 156);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICProductDesc, true);
            this.fld_medICProductDesc.Size = new System.Drawing.Size(296, 37);
            this.fld_medICProductDesc.TabIndex = 5;
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(12, 276);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel1, true);
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
            this.fld_txtICProductNo.Location = new System.Drawing.Point(110, 26);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNo, true);
            this.fld_txtICProductNo.Size = new System.Drawing.Size(190, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel27);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEVATID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkEditPurchasePrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkOpenBranchPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lnkEditPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductPrice01);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductSupplierPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(434, 296);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl1, true);
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(593, 160);
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
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(284, 132);
            this.fld_ckICProductIsFollowInventoryStock.Name = "fld_ckICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Caption = "Theo dõi tồn kho";
            this.fld_ckICProductIsFollowInventoryStock.Screen = null;
            this.fld_ckICProductIsFollowInventoryStock.Size = new System.Drawing.Size(111, 20);
            this.fld_ckICProductIsFollowInventoryStock.TabIndex = 8;
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(133, 131);
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Size = new System.Drawing.Size(143, 20);
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
            this.bosLabel27.Location = new System.Drawing.Point(18, 134);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(50, 13);
            this.bosLabel27.TabIndex = 349;
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
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(133, 79);
            this.fld_lkeFK_GEVATID.Name = "fld_lkeFK_GEVATID";
            this.fld_lkeFK_GEVATID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GEVATID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GEVATID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GEVATID.Properties.ColumnName = null;
            this.fld_lkeFK_GEVATID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATPercentValue", "% thuế", 20, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.fld_lkeFK_GEVATID.Properties.DisplayFormat.FormatString = "n0";
            this.fld_lkeFK_GEVATID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_lkeFK_GEVATID.Properties.DisplayMember = "GEVATPercentValue";
            this.fld_lkeFK_GEVATID.Properties.NullText = "";
            this.fld_lkeFK_GEVATID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GEVATID.Properties.ValueMember = "GEVATID";
            this.fld_lkeFK_GEVATID.Screen = null;
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 2;
            this.fld_lkeFK_GEVATID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
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
            this.bosLabel7.Location = new System.Drawing.Point(18, 83);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(25, 13);
            this.bosLabel7.TabIndex = 342;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Thuế";
            // 
            // fld_lnkEditPurchasePrice
            // 
            this.fld_lnkEditPurchasePrice.EditValue = "Sửa giá mua theo tiền tệ";
            this.fld_lnkEditPurchasePrice.Location = new System.Drawing.Point(284, 81);
            this.fld_lnkEditPurchasePrice.Name = "fld_lnkEditPurchasePrice";
            this.fld_lnkEditPurchasePrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPurchasePrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPurchasePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkEditPurchasePrice, true);
            this.fld_lnkEditPurchasePrice.Size = new System.Drawing.Size(126, 18);
            this.fld_lnkEditPurchasePrice.TabIndex = 7;
            this.fld_lnkEditPurchasePrice.TabStop = false;
            this.fld_lnkEditPurchasePrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPurchasePrice_OpenLink);
            // 
            // fld_lnkOpenBranchPrice
            // 
            this.fld_lnkOpenBranchPrice.EditValue = "Sửa giá các chi nhánh";
            this.fld_lnkOpenBranchPrice.Location = new System.Drawing.Point(284, 54);
            this.fld_lnkOpenBranchPrice.MenuManager = this.screenToolbar;
            this.fld_lnkOpenBranchPrice.Name = "fld_lnkOpenBranchPrice";
            this.fld_lnkOpenBranchPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenBranchPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenBranchPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkOpenBranchPrice, true);
            this.fld_lnkOpenBranchPrice.Size = new System.Drawing.Size(126, 18);
            this.fld_lnkOpenBranchPrice.TabIndex = 6;
            this.fld_lnkOpenBranchPrice.TabStop = false;
            this.fld_lnkOpenBranchPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkOpenBranchPrice_OpenLink);
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(18, 109);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel16, true);
            this.fld_lblLabel16.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel16.TabIndex = 341;
            this.fld_lblLabel16.Text = "ĐVT";
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(133, 105);
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
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductBasicUnitID, true);
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(143, 20);
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 3;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
            // 
            // fld_lnkEditPrice
            // 
            this.fld_lnkEditPrice.EditValue = "Sửa mức giá";
            this.fld_lnkEditPrice.Location = new System.Drawing.Point(284, 29);
            this.fld_lnkEditPrice.MenuManager = this.screenToolbar;
            this.fld_lnkEditPrice.Name = "fld_lnkEditPrice";
            this.fld_lnkEditPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkEditPrice.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkEditPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkEditPrice, true);
            this.fld_lnkEditPrice.Size = new System.Drawing.Size(74, 18);
            this.fld_lnkEditPrice.TabIndex = 5;
            this.fld_lnkEditPrice.TabStop = false;
            this.fld_lnkEditPrice.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkEditPrice_OpenLink);
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(18, 56);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel14, true);
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
            this.fld_txtICProductPrice01.EditValue = "0.00";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(133, 25);
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
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductPrice01, true);
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(143, 20);
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
            this.fld_txtICProductSupplierPrice.EditValue = "0.00";
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(133, 52);
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
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductSupplierPrice, true);
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(143, 20);
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
            this.fld_lblLabel23.Location = new System.Drawing.Point(18, 29);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel23, true);
            this.fld_lblLabel23.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel23.TabIndex = 325;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Giá bán";
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
            this.fld_tabProductTask.Location = new System.Drawing.Point(5, 17);
            this.fld_tabProductTask.Name = "fld_tabProductTask";
            this.fld_tabProductTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductTask.Screen = null;
            this.fld_tabProductTask.SelectedTabPage = this.xtraTabPage8;
            this.fld_tabProductTask.Size = new System.Drawing.Size(1022, 169);
            this.fld_tabProductTask.TabIndex = 7;
            this.fld_tabProductTask.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage8});
            this.fld_tabProductTask.Visible = false;
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.fld_btnAddHardwareProductImage);
            this.xtraTabPage8.Controls.Add(this.fld_dgcICProductImagesGridControl);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.xtraTabPage8.Size = new System.Drawing.Size(1020, 144);
            this.xtraTabPage8.Text = "Hình ảnh";
            // 
            // fld_btnAddHardwareProductImage
            // 
            this.fld_btnAddHardwareProductImage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddHardwareProductImage.Appearance.Options.UseForeColor = true;
            this.fld_btnAddHardwareProductImage.BOSComment = "";
            this.fld_btnAddHardwareProductImage.BOSDataMember = null;
            this.fld_btnAddHardwareProductImage.BOSDataSource = null;
            this.fld_btnAddHardwareProductImage.BOSDescription = null;
            this.fld_btnAddHardwareProductImage.BOSError = null;
            this.fld_btnAddHardwareProductImage.BOSFieldGroup = "";
            this.fld_btnAddHardwareProductImage.BOSFieldRelation = "";
            this.fld_btnAddHardwareProductImage.BOSPrivilege = "";
            this.fld_btnAddHardwareProductImage.BOSPropertyName = null;
            this.fld_btnAddHardwareProductImage.Location = new System.Drawing.Point(7, 3);
            this.fld_btnAddHardwareProductImage.Name = "fld_btnAddHardwareProductImage";
            this.fld_btnAddHardwareProductImage.Screen = null;
            this.fld_btnAddHardwareProductImage.Size = new System.Drawing.Size(115, 27);
            this.fld_btnAddHardwareProductImage.TabIndex = 11;
            this.fld_btnAddHardwareProductImage.Tag = "";
            this.fld_btnAddHardwareProductImage.Text = "Chọn ảnh";
            this.fld_btnAddHardwareProductImage.Click += new System.EventHandler(this.fld_btnAddHardwareProductImage_Click);
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
            this.fld_dgcICProductImagesGridControl.Size = new System.Drawing.Size(1009, 105);
            this.fld_dgcICProductImagesGridControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_btnAddProductComponentItem);
            this.xtraTabPage2.Controls.Add(this.fld_dgcProductComponentGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1006, 137);
            this.xtraTabPage2.Text = "Thành phần";
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
            this.fld_btnAddProductComponentItem.Location = new System.Drawing.Point(3, 4);
            this.fld_btnAddProductComponentItem.Name = "fld_btnAddProductComponentItem";
            this.fld_btnAddProductComponentItem.Screen = null;
            this.fld_btnAddProductComponentItem.Size = new System.Drawing.Size(115, 27);
            this.fld_btnAddProductComponentItem.TabIndex = 2;
            this.fld_btnAddProductComponentItem.Tag = "";
            this.fld_btnAddProductComponentItem.Text = "Thêm thành phần";
            this.fld_btnAddProductComponentItem.Click += new System.EventHandler(this.fld_btnAddProductComponentItem_Click);
            // 
            // fld_dgcProductComponentGridControl
            // 
            this.fld_dgcProductComponentGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcProductComponentGridControl.BOSComment = null;
            this.fld_dgcProductComponentGridControl.BOSDataMember = null;
            this.fld_dgcProductComponentGridControl.BOSDataSource = "ICProductComponents";
            this.fld_dgcProductComponentGridControl.BOSDescription = null;
            this.fld_dgcProductComponentGridControl.BOSError = null;
            this.fld_dgcProductComponentGridControl.BOSFieldGroup = null;
            this.fld_dgcProductComponentGridControl.BOSFieldRelation = null;
            this.fld_dgcProductComponentGridControl.BOSGridType = null;
            this.fld_dgcProductComponentGridControl.BOSPrivilege = null;
            this.fld_dgcProductComponentGridControl.BOSPropertyName = null;
            this.fld_dgcProductComponentGridControl.CommodityType = "";
            this.fld_dgcProductComponentGridControl.Location = new System.Drawing.Point(3, 37);
            this.fld_dgcProductComponentGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcProductComponentGridControl.Name = "fld_dgcProductComponentGridControl";
            this.fld_dgcProductComponentGridControl.PrintReport = false;
            this.fld_dgcProductComponentGridControl.Screen = null;
            this.fld_dgcProductComponentGridControl.Size = new System.Drawing.Size(1000, 96);
            this.fld_dgcProductComponentGridControl.TabIndex = 1;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_btnSaveProductMeasureUnit);
            this.xtraTabPage4.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1016, 841);
            this.xtraTabPage4.Text = "ĐVT quy đổi";
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
            this.fld_btnSaveProductMeasureUnit.Location = new System.Drawing.Point(854, 809);
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
            this.fld_dgcICProductMeasureUnits.Location = new System.Drawing.Point(3, 4);
            this.fld_dgcICProductMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMeasureUnits.Name = "fld_dgcICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.PrintReport = false;
            this.fld_dgcICProductMeasureUnits.Screen = null;
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(894, 799);
            this.fld_dgcICProductMeasureUnits.TabIndex = 5;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.fld_dgcICProductTolenrances);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1016, 841);
            this.xtraTabPage5.Text = "Dung sai";
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
            this.fld_dgcICProductTolenrances.Size = new System.Drawing.Size(1016, 841);
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
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICProductComponents);
            this.xtraTabPage1.Controls.Add(this.fld_btnShowProductComponent);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(919, 75);
            this.xtraTabPage1.Text = "Thành phần";
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
            this.fld_dgcICProductComponents.Size = new System.Drawing.Size(913, 35);
            this.fld_dgcICProductComponents.TabIndex = 13;
            // 
            // fld_btnShowProductComponent
            // 
            this.fld_btnShowProductComponent.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShowProductComponent.Appearance.Options.UseForeColor = true;
            this.fld_btnShowProductComponent.BOSComment = "";
            this.fld_btnShowProductComponent.BOSDataMember = null;
            this.fld_btnShowProductComponent.BOSDataSource = null;
            this.fld_btnShowProductComponent.BOSDescription = null;
            this.fld_btnShowProductComponent.BOSError = null;
            this.fld_btnShowProductComponent.BOSFieldGroup = "";
            this.fld_btnShowProductComponent.BOSFieldRelation = "";
            this.fld_btnShowProductComponent.BOSPrivilege = "";
            this.fld_btnShowProductComponent.BOSPropertyName = null;
            this.fld_btnShowProductComponent.Location = new System.Drawing.Point(5, 3);
            this.fld_btnShowProductComponent.Name = "fld_btnShowProductComponent";
            this.fld_btnShowProductComponent.Screen = null;
            this.fld_btnShowProductComponent.Size = new System.Drawing.Size(115, 27);
            this.fld_btnShowProductComponent.TabIndex = 12;
            this.fld_btnShowProductComponent.Tag = "";
            this.fld_btnShowProductComponent.Text = "Thêm thành phần";
            this.fld_btnShowProductComponent.Click += new System.EventHandler(this.fld_btnShowProductComponent_Click);
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
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(0, 16);
            this.fld_lblLabel11.TabIndex = 334;
            this.fld_lblLabel11.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DMHC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1032, 873);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_lblLabel11);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMHC100.IconOptions.Icon")));
            this.Name = "DMHC100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMHC100_Load);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl4)).EndInit();
            this.fld_grcGroupControl4.ResumeLayout(false);
            this.fld_grcGroupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStockMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMinDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICProductStockMaxDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductThickness1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDiameter1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWarping1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInDiameter1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductInRadius.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductHeight1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductPurchaseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductOtherSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICModelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductImageFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductOriginOfProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNoOfOldSys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductAttributeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenBranchPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).EndInit();
            this.fld_tabProductTask.ResumeLayout(false);
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductImagesGridControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcProductComponentGridControl)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductTolenrances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl4;
        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSComponent.BOSTextBox fld_txtICProductStockMin;
        private BOSComponent.BOSTextBox fld_txtICProductStockMax;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLabel fld_lblLabel29;
        private BOSComponent.BOSDateEdit fld_dteICProductStockMinDateFrom;
        private BOSComponent.BOSDateEdit fld_dteICProductStockMinDateTo;
        private BOSComponent.BOSDateEdit fld_dteICProductStockMaxDateFrom;
        private BOSComponent.BOSDateEdit fld_dteICProductStockMaxDateTo;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButtonEdit fld_bedICProductAttribute;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICProductNoOfOldSys;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSTextBox fld_txtICProductAttributeNo;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierNumber;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkSetDefaultDesc;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSLabel fld_lblLabel15;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPurchasePrice;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenBranchPrice;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkEditPrice;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierPrice;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEVATID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeICProductOriginOfProduct;
        private BOSComponent.BOSGroupControl bosGroupControl3;
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
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTabControl fld_tabProductTask;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private BOSComponent.BOSButton fld_btnAddHardwareProductImage;
        private BOSERP.Modules.HardwareProduct.ICProductImagesGridControl fld_dgcICProductImagesGridControl;
        private OpenFileDialog openFileDialog1;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSButton fld_btnShowProductComponent;
        private ICProductComponentGridControl fld_dgcICProductComponents;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ICProductComponentGridControl fld_dgcProductComponentGridControl;
        private BOSComponent.BOSButton fld_btnAddProductComponentItem;
        private BOSComponent.BOSTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private BOSERP.Modules.HardwareProduct.ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private BOSComponent.BOSButton fld_btnSaveProductMeasureUnit;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSMemoEdit fld_medICProductOtherSize;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeICProductPurchaseType;
        private BOSComponent.BOSTextBox fld_txtICProductLeadTime;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel25;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSTextBox bosTextBox4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private ICProductTolenrancesGridControl fld_dgcICProductTolenrances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private PictureBox pictureBox1;
        private BOSComponent.BOSTextBox fld_txtICProductImageFile;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel28;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICModelID;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox fld_txtICProductThickness1;
        private BOSComponent.BOSLabel bosLabel301;
        private BOSComponent.BOSLabel bosLabel261;
        private BOSComponent.BOSTextBox fld_txtICProductDiameter1;
        private BOSComponent.BOSLabel bosLabel231;
        private BOSComponent.BOSTextBox fld_txtICProductWarping1;
        private BOSComponent.BOSTextBox fld_txtICProductDepth1;
        private BOSComponent.BOSLabel bosLabel221;
        private BOSComponent.BOSTextBox fld_txtICProductInDiameter1;
        private BOSComponent.BOSTextBox fld_txtICProductInRadius;
        private BOSComponent.BOSTextBox fld_txtICProductHeight1;
        private BOSComponent.BOSTextBox fld_txtICProductLength1;
        private BOSComponent.BOSTextBox fld_txtICProductWidth1;
        private BOSComponent.BOSLabel bosLabel121;
        private BOSComponent.BOSLabel bosLabel201;
        private BOSComponent.BOSLabel bosLabel61;
    }
}
