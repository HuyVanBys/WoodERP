using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WoodMaterialsProduct.UI
{
	/// <summary>
	/// Summary description for DMWMP100
	/// </summary>
	partial class DMWMP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMWMP100));
            this.fld_tabProductExtra = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProductComponent = new DevExpress.XtraTab.XtraTabPage();
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductFormulaPriceConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GEVATID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_chkICProductIsShowWeb = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductPrice01 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductSupplierPrice = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkICProductPromotionCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductIdentifyWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductLeadTime = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMProductionNormItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductParentID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductAttribute = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductWeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductJoinery1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblICProductJoinery = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ptbICProductPicture = new System.Windows.Forms.PictureBox();
            this.fld_btnAddProductImageDefault = new BOSComponent.BOSButton(this.components);
            this.fld_txtICProductStorageDay = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkOpenSupplier = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lnkSetDefaultDesc = new DevExpress.XtraEditors.HyperLinkEdit();
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkICProductActiveCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
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
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
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
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICProductMeasureUnits = new BOSERP.Modules.WoodMaterialsProduct.ICProductMeasureUnitsGridControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductExtra)).BeginInit();
            this.fld_tabProductExtra.SuspendLayout();
            this.fld_tabProductComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductJoinery1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_tabProductExtra
            // 
            this.fld_tabProductExtra.BOSComment = null;
            this.fld_tabProductExtra.BOSDataMember = null;
            this.fld_tabProductExtra.BOSDataSource = "";
            this.fld_tabProductExtra.BOSDescription = null;
            this.fld_tabProductExtra.BOSError = null;
            this.fld_tabProductExtra.BOSFieldGroup = null;
            this.fld_tabProductExtra.BOSFieldRelation = null;
            this.fld_tabProductExtra.BOSPrivilege = null;
            this.fld_tabProductExtra.BOSPropertyName = null;
            this.fld_tabProductExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProductExtra.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProductExtra.Name = "fld_tabProductExtra";
            this.fld_tabProductExtra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductExtra.Screen = null;
            this.fld_tabProductExtra.SelectedTabPage = this.fld_tabProductComponent;
            this.fld_tabProductExtra.Size = new System.Drawing.Size(1074, 624);
            this.fld_tabProductExtra.TabIndex = 8;
            this.fld_tabProductExtra.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductComponent,
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // fld_tabProductComponent
            // 
            this.fld_tabProductComponent.Controls.Add(this.fld_grcGroupControl1);
            this.fld_tabProductComponent.Controls.Add(this.bosGroupControl2);
            this.fld_tabProductComponent.Controls.Add(this.fld_grcGroupControl5);
            this.fld_tabProductComponent.Name = "fld_tabProductComponent";
            this.fld_tabProductComponent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductComponent.Size = new System.Drawing.Size(1072, 599);
            this.fld_tabProductComponent.Text = "Thông tin";
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
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.fld_grcGroupControl1.Controls.Add(this.fld_ckICProductIsFollowInventoryStock);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICPriceCalculationMethodID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel27);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_ICProductFormulaPriceConfigID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel19);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lkeFK_GEVATID);
            this.fld_grcGroupControl1.Controls.Add(this.bosLabel12);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_chkICProductIsShowWeb);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel14);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductPrice01);
            this.fld_grcGroupControl1.Controls.Add(this.fld_txtICProductSupplierPrice);
            this.fld_grcGroupControl1.Controls.Add(this.fld_chkICProductPromotionCheck);
            this.fld_grcGroupControl1.Controls.Add(this.fld_lblLabel23);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(5, 328);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(899, 159);
            this.fld_grcGroupControl1.TabIndex = 2;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Đơn vị tính && Giá";
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
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(92, 102);
            this.fld_lkeFK_ICProductBasicUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Tên ĐV")});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.NullText = "";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductBasicUnitID, true);
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(116, 20);
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 4;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
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
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(227, 128);
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(92, 128);
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
            this.fld_lkeFK_ICPriceCalculationMethodID.Size = new System.Drawing.Size(116, 20);
            this.fld_lkeFK_ICPriceCalculationMethodID.TabIndex = 5;
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
            // fld_lkeFK_ICProductFormulaPriceConfigID
            // 
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductFormulaPriceConfigID.BOSAllowDummy = false;
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
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Location = new System.Drawing.Point(283, 24);
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
            this.fld_lkeFK_ICProductFormulaPriceConfigID.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_ICProductFormulaPriceConfigID.TabIndex = 1;
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
            this.bosLabel19.Location = new System.Drawing.Point(227, 27);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(50, 13);
            this.bosLabel19.TabIndex = 343;
            this.bosLabel19.Text = "Công thức";
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
            this.fld_lkeFK_GEVATID.Location = new System.Drawing.Point(92, 76);
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
            this.fld_lkeFK_GEVATID.Size = new System.Drawing.Size(116, 20);
            this.fld_lkeFK_GEVATID.TabIndex = 3;
            this.fld_lkeFK_GEVATID.Tag = "DC";
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
            this.bosLabel12.Location = new System.Drawing.Point(9, 105);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(20, 13);
            this.bosLabel12.TabIndex = 341;
            this.bosLabel12.Text = "ĐVT";
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
            this.fld_lblLabel.Size = new System.Drawing.Size(25, 13);
            this.fld_lblLabel.TabIndex = 253;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Thuế";
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
            this.fld_chkICProductIsShowWeb.Location = new System.Drawing.Point(227, 103);
            this.fld_chkICProductIsShowWeb.Name = "fld_chkICProductIsShowWeb";
            this.fld_chkICProductIsShowWeb.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkICProductIsShowWeb.Properties.Caption = "Hiển thị trên Web";
            this.fld_chkICProductIsShowWeb.Screen = null;
            this.fld_chkICProductIsShowWeb.Size = new System.Drawing.Size(111, 20);
            this.fld_chkICProductIsShowWeb.TabIndex = 7;
            this.fld_chkICProductIsShowWeb.Tag = "DC";
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
            this.fld_txtICProductPrice01.EditValue = "0.00";
            this.fld_txtICProductPrice01.Location = new System.Drawing.Point(92, 24);
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
            this.fld_txtICProductPrice01.Size = new System.Drawing.Size(116, 20);
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
            this.fld_txtICProductSupplierPrice.Location = new System.Drawing.Point(92, 50);
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
            this.fld_txtICProductSupplierPrice.Size = new System.Drawing.Size(116, 20);
            this.fld_txtICProductSupplierPrice.TabIndex = 2;
            this.fld_txtICProductSupplierPrice.Tag = "DC";
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
            this.fld_chkICProductPromotionCheck.Location = new System.Drawing.Point(227, 77);
            this.fld_chkICProductPromotionCheck.Name = "fld_chkICProductPromotionCheck";
            this.fld_chkICProductPromotionCheck.Properties.Caption = "Hàng khuyến mãi";
            this.fld_chkICProductPromotionCheck.Screen = null;
            this.fld_chkICProductPromotionCheck.Size = new System.Drawing.Size(123, 20);
            this.fld_chkICProductPromotionCheck.TabIndex = 6;
            this.fld_chkICProductPromotionCheck.Tag = "DC";
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
            this.bosGroupControl2.Controls.Add(this.fld_lkeICProductIdentifyWoodType);
            this.bosGroupControl2.Controls.Add(this.bosTextBox2);
            this.bosGroupControl2.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl2.Controls.Add(this.bosLabel11);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLeadTime);
            this.bosGroupControl2.Controls.Add(this.bosLabel10);
            this.bosGroupControl2.Controls.Add(this.bosLabel6);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_MMProductionNormItemID);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICProductParentID);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductAttribute);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWeight);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductLength);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductWidth);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductJoinery1);
            this.bosGroupControl2.Controls.Add(this.bosLabel1);
            this.bosGroupControl2.Controls.Add(this.bosLabel4);
            this.bosGroupControl2.Controls.Add(this.fld_lblICProductJoinery);
            this.bosGroupControl2.Location = new System.Drawing.Point(435, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(469, 319);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thuộc tính";
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
            this.fld_lkeICProductIdentifyWoodType.Location = new System.Drawing.Point(187, 56);
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
            this.fld_lkeICProductIdentifyWoodType.Size = new System.Drawing.Size(255, 20);
            this.fld_lkeICProductIdentifyWoodType.TabIndex = 3;
            this.fld_lkeICProductIdentifyWoodType.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ICProductLeadTime";
            this.bosTextBox2.BOSDataSource = "ICProducts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(187, 212);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(255, 20);
            this.bosTextBox2.TabIndex = 9;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "ICProductPurchaseType";
            this.bosLookupEdit2.BOSDataSource = "ICProducts";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(187, 238);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(255, 20);
            this.bosLookupEdit2.TabIndex = 10;
            this.bosLookupEdit2.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(14, 58);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(74, 13);
            this.bosLabel11.TabIndex = 28;
            this.bosLabel11.Text = "Xác định loại gỗ";
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
            this.bosLabel7.Location = new System.Drawing.Point(14, 32);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(153, 13);
            this.bosLabel7.TabIndex = 27;
            this.bosLabel7.Text = "Xác định Dài x Rộng x Dày (mm)";
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
            this.fld_txtICProductLeadTime.Location = new System.Drawing.Point(187, 186);
            this.fld_txtICProductLeadTime.Name = "fld_txtICProductLeadTime";
            this.fld_txtICProductLeadTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLeadTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLeadTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductLeadTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductLeadTime.Screen = null;
            this.fld_txtICProductLeadTime.Size = new System.Drawing.Size(255, 20);
            this.fld_txtICProductLeadTime.TabIndex = 8;
            this.fld_txtICProductLeadTime.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(14, 243);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(69, 13);
            this.bosLabel10.TabIndex = 26;
            this.bosLabel10.Text = "Loại mua hàng";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(14, 215);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(117, 13);
            this.bosLabel6.TabIndex = 25;
            this.bosLabel6.Text = "T.gian hoàn thành (day)";
            // 
            // fld_lkeFK_MMProductionNormItemID
            // 
            this.fld_lkeFK_MMProductionNormItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormItemID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProductionNormItemID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSDataMember = "FK_MMProductionNormItemID";
            this.fld_lkeFK_MMProductionNormItemID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_MMProductionNormItemID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSError = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormItemID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormItemID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormItemID.Location = new System.Drawing.Point(187, 160);
            this.fld_lkeFK_MMProductionNormItemID.Name = "fld_lkeFK_MMProductionNormItemID";
            this.fld_lkeFK_MMProductionNormItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormItemID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionNormItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormItemNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormItemProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormItemProductDesc", "Mô tả")});
            this.fld_lkeFK_MMProductionNormItemID.Properties.DisplayMember = "MMProductionNormItemProductName";
            this.fld_lkeFK_MMProductionNormItemID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionNormItemID.Properties.PopupWidth = 300;
            this.fld_lkeFK_MMProductionNormItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionNormItemID.Properties.ValueMember = "MMProductionNormItemID";
            this.fld_lkeFK_MMProductionNormItemID.Screen = null;
            this.fld_lkeFK_MMProductionNormItemID.Size = new System.Drawing.Size(255, 20);
            this.fld_lkeFK_MMProductionNormItemID.TabIndex = 7;
            this.fld_lkeFK_MMProductionNormItemID.Tag = "DC";
            // 
            // fld_lkeFK_ICProductParentID
            // 
            this.fld_lkeFK_ICProductParentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductParentID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductParentID.BOSComment = null;
            this.fld_lkeFK_ICProductParentID.BOSDataMember = "FK_ICProductParentID";
            this.fld_lkeFK_ICProductParentID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductParentID.BOSDescription = null;
            this.fld_lkeFK_ICProductParentID.BOSError = null;
            this.fld_lkeFK_ICProductParentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductParentID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductParentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductParentID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductParentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductParentID.BOSSelectType = null;
            this.fld_lkeFK_ICProductParentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductParentID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductParentID.Location = new System.Drawing.Point(187, 134);
            this.fld_lkeFK_ICProductParentID.Name = "fld_lkeFK_ICProductParentID";
            this.fld_lkeFK_ICProductParentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductParentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductParentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Mô tả")});
            this.fld_lkeFK_ICProductParentID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductParentID.Properties.NullText = "";
            this.fld_lkeFK_ICProductParentID.Properties.PopupWidth = 300;
            this.fld_lkeFK_ICProductParentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductParentID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductParentID.Screen = null;
            this.fld_lkeFK_ICProductParentID.Size = new System.Drawing.Size(255, 20);
            this.fld_lkeFK_ICProductParentID.TabIndex = 6;
            this.fld_lkeFK_ICProductParentID.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(13, 85);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(64, 13);
            this.bosLabel9.TabIndex = 6;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Ghi chú mộng";
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
            this.fld_bedICProductAttribute.Location = new System.Drawing.Point(187, 108);
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
            this.fld_bedICProductAttribute.Size = new System.Drawing.Size(255, 20);
            this.fld_bedICProductAttribute.TabIndex = 5;
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
            this.fld_lblLabel8.Location = new System.Drawing.Point(13, 137);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel8, true);
            this.fld_lblLabel8.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel8.TabIndex = 10;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Thuộc sản phẩm";
            // 
            // fld_txtICProductWeight
            // 
            this.fld_txtICProductWeight.BOSComment = "";
            this.fld_txtICProductWeight.BOSDataMember = "ICProductLength";
            this.fld_txtICProductWeight.BOSDataSource = "ICProducts";
            this.fld_txtICProductWeight.BOSDescription = null;
            this.fld_txtICProductWeight.BOSError = null;
            this.fld_txtICProductWeight.BOSFieldGroup = "";
            this.fld_txtICProductWeight.BOSFieldRelation = "";
            this.fld_txtICProductWeight.BOSPrivilege = "";
            this.fld_txtICProductWeight.BOSPropertyName = "Text";
            this.fld_txtICProductWeight.Location = new System.Drawing.Point(187, 30);
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
            this.fld_txtICProductWeight.Size = new System.Drawing.Size(81, 20);
            this.fld_txtICProductWeight.TabIndex = 0;
            this.fld_txtICProductWeight.Tag = "DC";
            // 
            // fld_txtICProductLength
            // 
            this.fld_txtICProductLength.BOSComment = "";
            this.fld_txtICProductLength.BOSDataMember = "ICProductHeight";
            this.fld_txtICProductLength.BOSDataSource = "ICProducts";
            this.fld_txtICProductLength.BOSDescription = null;
            this.fld_txtICProductLength.BOSError = null;
            this.fld_txtICProductLength.BOSFieldGroup = "";
            this.fld_txtICProductLength.BOSFieldRelation = "";
            this.fld_txtICProductLength.BOSPrivilege = "";
            this.fld_txtICProductLength.BOSPropertyName = "Text";
            this.fld_txtICProductLength.Location = new System.Drawing.Point(361, 30);
            this.fld_txtICProductLength.Name = "fld_txtICProductLength";
            this.fld_txtICProductLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductLength.Properties.Mask.EditMask = null;
            this.fld_txtICProductLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductLength, false);
            this.fld_txtICProductLength.Size = new System.Drawing.Size(81, 20);
            this.fld_txtICProductLength.TabIndex = 2;
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
            this.fld_txtICProductWidth.Location = new System.Drawing.Point(274, 30);
            this.fld_txtICProductWidth.Name = "fld_txtICProductWidth";
            this.fld_txtICProductWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductWidth.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.fld_txtICProductWidth.Properties.MaskSettings.Set("mask", "n");
            this.fld_txtICProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductWidth, true);
            this.fld_txtICProductWidth.Size = new System.Drawing.Size(81, 20);
            this.fld_txtICProductWidth.TabIndex = 1;
            this.fld_txtICProductWidth.Tag = "DC";
            // 
            // fld_txtICProductJoinery1
            // 
            this.fld_txtICProductJoinery1.BOSComment = "";
            this.fld_txtICProductJoinery1.BOSDataMember = "ICProductJoinery";
            this.fld_txtICProductJoinery1.BOSDataSource = "ICProducts";
            this.fld_txtICProductJoinery1.BOSDescription = null;
            this.fld_txtICProductJoinery1.BOSError = null;
            this.fld_txtICProductJoinery1.BOSFieldGroup = "";
            this.fld_txtICProductJoinery1.BOSFieldRelation = "";
            this.fld_txtICProductJoinery1.BOSPrivilege = "";
            this.fld_txtICProductJoinery1.BOSPropertyName = "Text";
            this.fld_txtICProductJoinery1.EditValue = "";
            this.fld_txtICProductJoinery1.Location = new System.Drawing.Point(187, 82);
            this.fld_txtICProductJoinery1.Name = "fld_txtICProductJoinery1";
            this.fld_txtICProductJoinery1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductJoinery1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductJoinery1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductJoinery1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductJoinery1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductJoinery1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductJoinery1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductJoinery1, true);
            this.fld_txtICProductJoinery1.Size = new System.Drawing.Size(255, 20);
            this.fld_txtICProductJoinery1.TabIndex = 4;
            this.fld_txtICProductJoinery1.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(13, 189);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(63, 13);
            this.bosLabel1.TabIndex = 14;
            this.bosLabel1.Text = "Thời gian chờ";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(13, 163);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(89, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Text = "Thuộc thành phẩm";
            // 
            // fld_lblICProductJoinery
            // 
            this.fld_lblICProductJoinery.BOSComment = null;
            this.fld_lblICProductJoinery.BOSDataMember = null;
            this.fld_lblICProductJoinery.BOSDataSource = null;
            this.fld_lblICProductJoinery.BOSDescription = null;
            this.fld_lblICProductJoinery.BOSError = null;
            this.fld_lblICProductJoinery.BOSFieldGroup = null;
            this.fld_lblICProductJoinery.BOSFieldRelation = null;
            this.fld_lblICProductJoinery.BOSPrivilege = null;
            this.fld_lblICProductJoinery.BOSPropertyName = null;
            this.fld_lblICProductJoinery.Location = new System.Drawing.Point(13, 110);
            this.fld_lblICProductJoinery.Name = "fld_lblICProductJoinery";
            this.fld_lblICProductJoinery.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblICProductJoinery, true);
            this.fld_lblICProductJoinery.Size = new System.Drawing.Size(50, 13);
            this.fld_lblICProductJoinery.TabIndex = 8;
            this.fld_lblICProductJoinery.Text = "Thuộc tính";
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_ptbICProductPicture);
            this.fld_grcGroupControl5.Controls.Add(this.fld_btnAddProductImageDefault);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductStorageDay);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lnkOpenSupplier);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICProductName);
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
            this.fld_grcGroupControl5.Controls.Add(this.fld_chkICProductActiveCheck);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(5, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl5, true);
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(425, 319);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_ptbICProductPicture
            // 
            this.fld_ptbICProductPicture.BackColor = System.Drawing.Color.Transparent;
            this.fld_ptbICProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_ptbICProductPicture.Location = new System.Drawing.Point(284, 137);
            this.fld_ptbICProductPicture.Name = "fld_ptbICProductPicture";
            this.fld_ptbICProductPicture.Size = new System.Drawing.Size(125, 107);
            this.fld_ptbICProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fld_ptbICProductPicture.TabIndex = 376;
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
            this.fld_btnAddProductImageDefault.Location = new System.Drawing.Point(285, 250);
            this.fld_btnAddProductImageDefault.Name = "fld_btnAddProductImageDefault";
            this.fld_btnAddProductImageDefault.Screen = null;
            this.fld_btnAddProductImageDefault.Size = new System.Drawing.Size(125, 21);
            this.fld_btnAddProductImageDefault.TabIndex = 375;
            this.fld_btnAddProductImageDefault.Tag = "";
            this.fld_btnAddProductImageDefault.Text = "Chọn ảnh chính";
            this.fld_btnAddProductImageDefault.Click += new System.EventHandler(this.fld_btnAddProductImageDefault_Click);
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
            this.fld_txtICProductStorageDay.Location = new System.Drawing.Point(92, 276);
            this.fld_txtICProductStorageDay.Name = "fld_txtICProductStorageDay";
            this.fld_txtICProductStorageDay.Screen = null;
            this.fld_txtICProductStorageDay.Size = new System.Drawing.Size(185, 20);
            this.fld_txtICProductStorageDay.TabIndex = 9;
            this.fld_txtICProductStorageDay.Tag = "DC";
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
            this.bosTextBox1.Location = new System.Drawing.Point(92, 250);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(185, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel18.Location = new System.Drawing.Point(9, 279);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(77, 13);
            this.bosLabel18.TabIndex = 15;
            this.bosLabel18.Text = "Số ngày lưu kho";
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
            this.bosLabel5.Location = new System.Drawing.Point(11, 253);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 15;
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
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(92, 148);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_bedFK_ICProductGroupID, true);
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(181, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 4;
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
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(92, 200);
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
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 6;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lnkOpenSupplier
            // 
            this.fld_lnkOpenSupplier.EditValue = "Nhà cung cấp phụ ";
            this.fld_lnkOpenSupplier.Location = new System.Drawing.Point(92, 226);
            this.fld_lnkOpenSupplier.MenuManager = this.screenToolbar;
            this.fld_lnkOpenSupplier.Name = "fld_lnkOpenSupplier";
            this.fld_lnkOpenSupplier.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkOpenSupplier.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkOpenSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkOpenSupplier, true);
            this.fld_lnkOpenSupplier.Size = new System.Drawing.Size(153, 18);
            this.fld_lnkOpenSupplier.TabIndex = 7;
            this.fld_lnkOpenSupplier.TabStop = false;
            this.fld_lnkOpenSupplier.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.fld_lnkOpenSupplier_OpenLink);
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
            this.fld_txtICProductName.Location = new System.Drawing.Point(92, 55);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductName, true);
            this.fld_txtICProductName.Size = new System.Drawing.Size(181, 20);
            this.fld_txtICProductName.TabIndex = 1;
            this.fld_txtICProductName.Tag = "DC";
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
            this.fld_lkeICProductType.Enabled = false;
            this.fld_lkeICProductType.Location = new System.Drawing.Point(92, 174);
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = "";
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductType, true);
            this.fld_lkeICProductType.Size = new System.Drawing.Size(183, 20);
            this.fld_lkeICProductType.TabIndex = 5;
            this.fld_lkeICProductType.Tag = "DC";
            // 
            // fld_lnkSetDefaultDesc
            // 
            this.fld_lnkSetDefaultDesc.EditValue = "Thiết lập mô tả mặc định";
            this.fld_lnkSetDefaultDesc.Location = new System.Drawing.Point(92, 124);
            this.fld_lnkSetDefaultDesc.Name = "fld_lnkSetDefaultDesc";
            this.fld_lnkSetDefaultDesc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_lnkSetDefaultDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lnkSetDefaultDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenHelper.SetShowHelp(this.fld_lnkSetDefaultDesc, true);
            this.fld_lnkSetDefaultDesc.Size = new System.Drawing.Size(134, 18);
            this.fld_lnkSetDefaultDesc.TabIndex = 3;
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
            this.fld_lblLabel17.Location = new System.Drawing.Point(11, 178);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel17, true);
            this.fld_lblLabel17.Size = new System.Drawing.Size(19, 13);
            this.fld_lblLabel17.TabIndex = 4;
            this.fld_lblLabel17.Text = "Loại";
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(11, 32);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel15, true);
            this.fld_lblLabel15.Size = new System.Drawing.Size(39, 13);
            this.fld_lblLabel15.TabIndex = 0;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã BTP";
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
            this.bosLabel2.Location = new System.Drawing.Point(11, 58);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(43, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tên BTP";
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
            this.fld_lblLabel21.Location = new System.Drawing.Point(11, 83);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel21, true);
            this.fld_lblLabel21.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel21.TabIndex = 7;
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
            this.fld_lblLabel28.Location = new System.Drawing.Point(11, 152);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, true);
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 9;
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
            this.fld_medICProductDesc.Location = new System.Drawing.Point(92, 81);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medICProductDesc, true);
            this.fld_medICProductDesc.Size = new System.Drawing.Size(317, 37);
            this.fld_medICProductDesc.TabIndex = 2;
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
            this.fld_lblLabel1.Location = new System.Drawing.Point(11, 204);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel1, true);
            this.fld_lblLabel1.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel1.TabIndex = 12;
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
            this.fld_txtICProductNo.Location = new System.Drawing.Point(92, 29);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtICProductNo, true);
            this.fld_txtICProductNo.Size = new System.Drawing.Size(181, 20);
            this.fld_txtICProductNo.TabIndex = 0;
            this.fld_txtICProductNo.Tag = "DC";
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
            this.fld_chkICProductActiveCheck.Location = new System.Drawing.Point(289, 277);
            this.fld_chkICProductActiveCheck.MenuManager = this.screenToolbar;
            this.fld_chkICProductActiveCheck.Name = "fld_chkICProductActiveCheck";
            this.fld_chkICProductActiveCheck.Properties.Caption = "Hoạt động";
            this.fld_chkICProductActiveCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkICProductActiveCheck, true);
            this.fld_chkICProductActiveCheck.Size = new System.Drawing.Size(78, 20);
            this.fld_chkICProductActiveCheck.TabIndex = 10;
            this.fld_chkICProductActiveCheck.Tag = "DC";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_grcGroupControl4);
            this.xtraTabPage2.Controls.Add(this.bosGroupControl3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1058, 592);
            this.xtraTabPage2.Text = "Tài khoản - Kho";
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
            this.fld_grcGroupControl4.Location = new System.Drawing.Point(3, 119);
            this.fld_grcGroupControl4.Name = "fld_grcGroupControl4";
            this.fld_grcGroupControl4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl4, true);
            this.fld_grcGroupControl4.Size = new System.Drawing.Size(660, 79);
            this.fld_grcGroupControl4.TabIndex = 6;
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
            this.fld_txtICProductStockMax.TabIndex = 4;
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
            this.fld_dteICProductStockMaxDateFrom.TabIndex = 5;
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
            this.fld_dteICProductStockMaxDateTo.TabIndex = 6;
            this.fld_dteICProductStockMaxDateTo.Tag = "DC";
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
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl3.Controls.Add(this.bosLabel8);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ICProductTypeAccountConfigID);
            this.bosGroupControl3.Controls.Add(this.bosLabel24);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountDiscountID);
            this.bosGroupControl3.Controls.Add(this.bosLabel17);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountSaleReturnID);
            this.bosGroupControl3.Controls.Add(this.bosLabel16);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountRevenueID);
            this.bosGroupControl3.Controls.Add(this.bosLabel15);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountCostPriceID);
            this.bosGroupControl3.Controls.Add(this.bosLabel14);
            this.bosGroupControl3.Controls.Add(this.fld_lkeFK_ACAccountRevenueInternalID);
            this.bosGroupControl3.Controls.Add(this.bosLabel13);
            this.bosGroupControl3.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl3.Controls.Add(this.bosLabel3);
            this.bosGroupControl3.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(660, 110);
            this.bosGroupControl3.TabIndex = 5;
            this.bosGroupControl3.Tag = "";
            this.bosGroupControl3.Text = "Tài khoản";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(359, 25);
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
            this.fld_lkeFK_ACAccountID.TabIndex = 350;
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
            this.bosLabel8.Location = new System.Drawing.Point(257, 28);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 351;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Tài khoản";
            // 
            // fld_lkeFK_ICProductTypeAccountConfigID
            // 
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSComment = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataMember = "FK_ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSError = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectType = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Location = new System.Drawing.Point(103, 25);
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
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Properties.ValueMember = "ICProductTypeAccountConfigID";
            this.fld_lkeFK_ICProductTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ICProductTypeAccountConfigID.Size = new System.Drawing.Size(125, 20);
            this.fld_lkeFK_ICProductTypeAccountConfigID.TabIndex = 348;
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
            this.bosLabel24.BOSComment = null;
            this.bosLabel24.BOSDataMember = null;
            this.bosLabel24.BOSDataSource = null;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = null;
            this.bosLabel24.BOSFieldRelation = null;
            this.bosLabel24.BOSPrivilege = null;
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(9, 28);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(75, 13);
            this.bosLabel24.TabIndex = 349;
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
            this.fld_lkeFK_ACAccountDiscountID.Location = new System.Drawing.Point(592, 77);
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
            this.fld_lkeFK_ACAccountDiscountID.TabIndex = 5;
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
            this.bosLabel17.Location = new System.Drawing.Point(519, 80);
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
            this.fld_lkeFK_ACAccountSaleReturnID.Location = new System.Drawing.Point(359, 77);
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
            this.fld_lkeFK_ACAccountSaleReturnID.TabIndex = 3;
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
            this.bosLabel16.Location = new System.Drawing.Point(257, 80);
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
            this.fld_lkeFK_ACAccountRevenueID.Location = new System.Drawing.Point(103, 77);
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
            this.fld_lkeFK_ACAccountRevenueID.TabIndex = 1;
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
            this.fld_lkeFK_ACAccountCostPriceID.Location = new System.Drawing.Point(592, 51);
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
            this.bosLabel14.Location = new System.Drawing.Point(519, 54);
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
            this.fld_lkeFK_ACAccountRevenueInternalID.Location = new System.Drawing.Point(359, 51);
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
            this.bosLabel13.Location = new System.Drawing.Point(257, 54);
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(103, 51);
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
            this.bosLookupEdit1.TabIndex = 0;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(10, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(53, 13);
            this.bosLabel3.TabIndex = 332;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "TK Tồn kho";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcICProductMeasureUnits);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1058, 592);
            this.xtraTabPage1.Text = "ĐVT quy đổi";
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
            this.fld_dgcICProductMeasureUnits.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcICProductMeasureUnits.MenuManager = this.screenToolbar;
            this.fld_dgcICProductMeasureUnits.Name = "fld_dgcICProductMeasureUnits";
            this.fld_dgcICProductMeasureUnits.PrintReport = false;
            this.fld_dgcICProductMeasureUnits.Screen = null;
            this.fld_dgcICProductMeasureUnits.Size = new System.Drawing.Size(1279, 586);
            this.fld_dgcICProductMeasureUnits.TabIndex = 4;
            this.fld_dgcICProductMeasureUnits.Tag = "DC";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DMWMP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.fld_tabProductExtra);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMWMP100.IconOptions.Icon")));
            this.Name = "DMWMP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_tabProductExtra, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductExtra)).EndInit();
            this.fld_tabProductExtra.ResumeLayout(false);
            this.fld_tabProductComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            this.fld_grcGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductFormulaPriceConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GEVATID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductIsShowWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductPrice01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductSupplierPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductPromotionCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifyWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLeadTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductAttribute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductJoinery1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptbICProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductStorageDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkOpenSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lnkSetDefaultDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkICProductActiveCheck.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            this.bosGroupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountDiscountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountSaleReturnID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountCostPriceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountRevenueInternalID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductMeasureUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSComponent.BOSTabControl fld_tabProductExtra;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductComponent;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private DevExpress.XtraEditors.HyperLinkEdit fld_lnkOpenSupplier;
        private BOSComponent.BOSTextBox fld_txtICProductName;
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
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private WoodMaterialsProduct.ICProductMeasureUnitsGridControl fld_dgcICProductMeasureUnits;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
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
        private BOSComponent.BOSGroupControl bosGroupControl3;
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
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductFormulaPriceConfigID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GEVATID;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSTextBox fld_txtICProductPrice01;
        private BOSComponent.BOSTextBox fld_txtICProductSupplierPrice;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtICProductLeadTime;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSCheckEdit fld_chkICProductIsShowWeb;
        private BOSComponent.BOSCheckEdit fld_chkICProductPromotionCheck;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormItemID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductParentID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSButtonEdit fld_bedICProductAttribute;
        private BOSComponent.BOSLabel fld_lblLabel8;
        private BOSComponent.BOSTextBox fld_txtICProductWeight;
        private BOSComponent.BOSTextBox fld_txtICProductLength;
        private BOSComponent.BOSTextBox fld_txtICProductWidth;
        private BOSComponent.BOSTextBox fld_txtICProductJoinery1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblICProductJoinery;
        private BOSComponent.BOSCheckEdit fld_chkICProductActiveCheck;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductIdentifyWoodType;
        private BOSComponent.BOSTextBox fld_txtICProductStorageDay;
        private BOSComponent.BOSLabel bosLabel18;
        private PictureBox fld_ptbICProductPicture;
        private BOSComponent.BOSButton fld_btnAddProductImageDefault;
        private OpenFileDialog openFileDialog1;
    }
}
